import * as util from "../../lib_ts/util"
import { Node as GunRS } from "rusty-gun"
import { IGunInstance as IGunJS, IGunChain } from "gun"
import GunJS from "gun/gun"

import "gun/lib/radix"
import "gun/lib/radisk"
import "gun/lib/store"
import "gun/lib/rindexed"


const DB_TYPE = ['gun_rs', 'gun_js'] as const

export type Db =
    | { type: 'gun_rs', url: string, db: GunRS }
    | { type: 'gun_js', url: string, db: IGunJS }
export type DbType = Db["type"]
util.assertTypeEquals<DbType, typeof DB_TYPE>(DB_TYPE)

export type DbSubscription =
    | { type: 'gun_rs', subscription: number }
    | { type: 'gun_js', subscription: number }
type DbSubscriptionType = DbSubscription["type"]
util.assertTypeEquals<DbSubscriptionType, typeof DB_TYPE>(DB_TYPE)

type DbNode = IGunChain<any> | GunRS

export type DbState = {
    dbConnection: {
        [_ in DbType]: {
            url: string,
            port: number,
            ws: string
        }
    }
    dbStatus: {
        [_ in DbType]: {
            [_ in DbType]: boolean
        }
    }
    dbRef: {
        [_: string]: Db
    }
}

export const getStateLocals = <TState extends DbState>(state: TState) => {
    return {
        db: Object.entries(state.dbStatus).reduce((accKeys, [dbType, enabledMap]) =>
            Object.entries(enabledMap).reduce((accKeys, [urlType, enabled]) =>
                !enabled
                    ? accKeys
                    : [
                        ...accKeys,
                        `${dbType}-${urlType}`.replace(/gun_/g, '')
                    ],
                accKeys
            ),
            [] as string[]
        )
    }
}


type Url = { url: string }

export const newDb = (type: DbType, { url }: Url): Db | null => {
    if (type === 'gun_rs') {
        return { type, url, db: new GunRS(url) }
    } else if (type === 'gun_js') {
        return { type, url, db: util.IS_TEST ? new GunJS(url) : new GunJS({ url, localStorage: false, radisk: true }) }
    }
    return null
}

const newUrl = (state: DbState, type: DbType) => {
    const connection = state.dbConnection[type]
    const url = `${connection.url}:${connection.port}/${connection.ws}`
    return url
}


export type Id = { dbType: DbType, urlType: DbType, url: string, id: string }

const newId = (state: DbState, dbType: DbType, urlType: DbType): Id => {
    const url = newUrl(state, urlType)
    return {
        dbType,
        urlType,
        url,
        id: [dbType, url.replace(/\:\/\/localhost/g, '')].toString()
    }
}

export const getDbIdList = (state: DbState): Id[][] =>
    Object.entries(state.dbStatus).reduce(
        (accKeys, [dbType, enabledMap]) =>
            Object.entries(enabledMap).reduce(
                ([accEnabled, accDisabled]: Id[][], [urlType, enabled]) => {
                    const id = newId(state, dbType as DbType, urlType as DbType)
                    return enabled
                        ? [[...accEnabled, id], accDisabled]
                        : [accEnabled, [...accDisabled, id]]
                }, accKeys
            ), [[], []] as Id[][]
    )


const soul = "tictactoe_spiral"

const parse = (raw: object) => {
    const getLocals = () => ({ nRaw: `${raw}`.length })
    const log = util.getLog(getLocals)
    log('parse() 0')
    let data = raw
    while (typeof data === 'string') {
        data = JSON.parse(data)
    }
    return data
}

export const lastObjectEntry = (obj: any) => Object.values(obj || {}).slice(-1)[0]
export const objectValueCount = (obj: any) => Object.values(obj || {}).filter((x) => x !== null).length


export type ContentAddress = { contentAddress: string }
export type Proxy = { [_: string]: any }

const newListenerHandler = <TProxy extends Proxy>(
    proxy: TProxy,
    id: string,
    contentAddress: ContentAddress,
    onValue: (id: string, hash: string, newValue: TProxy, rawValue: object | undefined) => Promise<void>
) =>
    async (v: object, k: any, _msg: any, _ev: any) => {
        const getLocals = () => ({
            id,
            contentAddress,
            k
        })
        const log = util.getLog(getLocals)

        const { '#': hash, _: { '#': hash2, '>': ptrs, ..._ }, ...value }: { [_: string]: any } = { _: {}, ...parse(v) }

        const newEntriesRaw = Object.entries(
            Object.keys(value).reduce((acc, k) => ({
                ...acc,
                [k]: value[k]
            }), proxy)
        )

        const newValue = Object.fromEntries(newEntriesRaw) as TProxy

        log('newListenerHandler 1', {
            vType: typeof v,
            hash,
            hash2,
            _keys: Object.keys(_ || {}),
            nPtrsKeys: Object.keys(ptrs || {}).length,
            // nValue: Object.keys(value).length,
            // nNewValue: Object.keys(newValue).length,
            value: objectValueCount(value),
            proxy: objectValueCount(proxy),
            newValue: objectValueCount(newValue)
            // nStateKey: Object.keys(state[key] || {}).length
        })

        await onValue(id, hash, newValue, Object.keys(value || {}).length > 0 ? value : undefined)
    }

const getDbNode = (db: Db, { contentAddress }: ContentAddress): DbNode | undefined => {
    const getLocals = () => ({
        soul,
        db,
        contentAddress,
    })
    const log = util.getLog(getLocals)

    log('getDbNode() 0')
    return contentAddress.split('/').reduce((acc, k) => acc.get(k as any), db.db.get(soul))
}

export const DB_INIT_TIMEOUT = 2500
export const DB_RESUB_TIMEOUT = 10000

export const dbPut = <TState extends DbState, TProxy extends Proxy>(
    state: TState,
    id: Id,
    contentAddress: ContentAddress,
    newValue: TProxy
) => {
    const getLocals = () => ({
        id,
        contentAddress,
        newValue
    })
    const log = util.getLog(getLocals)

    let db = state.dbRef[id.id]

    const node = getDbNode(db, contentAddress)

    log('dbPut() 0', { db, node })
    if (node) {
        node.put(newValue)
    }

    if (id.dbType === 'gun_js' && id.urlType === 'gun_rs') {
        const db = newDb('gun_rs', { url: id.url })
        if (db) {
            setTimeout(() => {
                const node = getDbNode(db, contentAddress)
                log('dbPut() 1 (##)', { db, node })
                if (node) {
                    node.put(newValue)
                }
            }, DB_INIT_TIMEOUT)
        }
    }
}

export const dbOn = <TState extends DbState, TProxy extends Proxy>(
    state: TState,
    proxy: TProxy,
    id: Id,
    contentAddress: ContentAddress,
    onValue: (id: string, hash: string, newValue: TProxy, rawValue: object | undefined) => Promise<void>
): number | undefined => {
    const { dbType } = id
    const getLocals = () => ({
        contentAddress,
        dbType,
        id
    })
    const log = util.getLog(getLocals)

    let db = state.dbRef[id.id]
    const node = getDbNode(db, contentAddress)

    log('dbOn() 0', { node })
    if (node) {
        if (dbType === 'gun_rs') {
            return node.on(newListenerHandler(proxy, id.id, contentAddress, onValue)) as number
        } else if (dbType === 'gun_js') {
            node.on(newListenerHandler(proxy, id.id, contentAddress, onValue))
            return util.newTimestamp()
        }
    }
}

export const dbOff = <TState extends DbState>(
    state: TState,
    id: string,
    contentAddress: ContentAddress,
    subscription: number | undefined
) => {
    const getLocals = () => ({
        id,
        contentAddress,
        subscription
    })
    const log = util.getLog(getLocals)

    let db = state.dbRef[id]
    const node = getDbNode(db, contentAddress)

    log('dbOff() 0', { node })
    if (node) {
        node.off(subscription as any)
    }
}
