import * as util from "../../lib_ts/util"
import { Node as GunRS } from "rusty-gun"
import GunJS from "gun/gun"
import { IGunInstance as IGunJS, IGunChain } from "gun"


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

type State = {
    token: string
    chainUrl: string
    chainPort: number

    db: { [_: string]: Db }
    dbConnection: {
        [_ in DbType]: {
            url: string
            port: number
            ws: string
        }
    }
    dbEnabled: {
        [_ in DbType]: {
            [_ in DbType]: boolean
        }
    }
}

export type Id = { dbType: DbType, urlType: DbType, url: string, id: string }

type Url = { url: string }

export const newDb = (type: DbType, { url }: Url): Db | null => {
    if (type === 'gun_rs') {
        return { type, url, db: new GunRS(url) }
    } else if (type === 'gun_js') {
        return { type, url, db: new GunJS(url) }
    }
    return null
}

const newUrl = (state: State, type: DbType) => {
    const connection = state.dbConnection[type]
    const url = `${connection.url}:${connection.port}/${connection.ws}`
    return url
}

const newId = (state: State, dbType: DbType, urlType: DbType): Id => {
    const url = newUrl(state, urlType)
    return {
        dbType,
        urlType,
        url,
        id: [dbType, url.replace(/\:\/\/localhost/g, '')].toString()
    }
}

export const getDbIdList = (state: State): Id[][] =>
    Object.entries(state.dbEnabled).reduce(
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


const soul = "app"

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

const newListenerHandler = <State>(
    state: State,
    id: string,
    key: keyof State,
    onValue: (id: string, hash: string, newValue: object, rawValue: object | undefined) => Promise<void>
) =>
    async (v: object, k: any, _msg: any, _ev: any) => {
        const getLocals = () => ({
            id,
            key,
            k
        })
        const log = util.getLog(getLocals)

        const { '#': hash, _: { '#': hash2, '>': ptrs, ..._ }, ...value }: { [_: string]: any } = { _: {}, ...parse(v) }

        const oldValue = (state[key] || {}) as { [_: string]: any }

        const newEntriesRaw = Object.entries(
            Object.keys(value).reduce((acc, k) => ({
                ...acc,
                [k]: value[k]
            }), oldValue)
        )

        const newValue = Object.fromEntries(newEntriesRaw)

        log('newListenerHandler 1', {
            vType: typeof v,
            hash,
            hash2,
            _keys: Object.keys(_ || {}),
            nPtrsKeys: Object.keys(ptrs || {}).length,
            // nValue: Object.keys(value).length,
            // nNewValue: Object.keys(newValue).length,
            value: Object.values(value).filter((x) => x !== null).length,
            oldValue: Object.values(oldValue).filter((x) => x !== null).length,
            newValue: Object.values(newValue).filter((x) => x !== null).length
            // nStateKey: Object.keys(state[key] || {}).length
        })

        await onValue(id, hash, newValue, Object.keys(value || {}).length > 0 ? value : undefined)
    }

const getDbNode = <T extends State>(state: T, id: string, key: keyof T): DbNode | undefined => {
    const getLocals = () => ({
        id,
        key,
    })
    const log = util.getLog(getLocals)

    const db = state.db[id]

    log('getDbNode() 0', { db: !!db })
    return db && db.db.get(soul).get(key as string)
}

export const dbPut = <T extends State>(
    state: T,
    id: string,
    key: keyof T,
    newValue: any
) => {
    const getLocals = () => ({
        id,
        key,
        newValue
    })
    const log = util.getLog(getLocals)

    const node = getDbNode(state, id, key)

    log('dbPut() 0', { node })
    if (node) {
        node.put(newValue)
    }
}

export const dbOn = <T extends State>(
    state: T,
    { dbType, id }: Id,
    key: keyof T,
    onValue: (id: string, hash: string, newValue: object, rawValue: object | undefined) => Promise<void>
): number | undefined => {
    const getLocals = () => ({
        key,
        dbType,
        id
    })
    const log = util.getLog(getLocals)

    const node = getDbNode(state, id, key)

    log('dbOn() 0', { node })
    if (node) {
        if (dbType === 'gun_rs') {
            return node.on(newListenerHandler(state, id, key, onValue)) as number
        } else if (dbType === 'gun_js') {
            node.on(newListenerHandler(state, id, key, onValue))
            return util.newTimestamp()
        }
    }
}

export const dbOff = <T extends State>(state: T, id: string, key: keyof T, subscription: number | undefined) => {
    const getLocals = () => ({
        id,
        key,
        subscription
    })
    const log = util.getLog(getLocals)

    const node = getDbNode(state, id, key)

    log('dbOff() 0', { node })
    if (node) {
        node.off(subscription as any)
    }
}
