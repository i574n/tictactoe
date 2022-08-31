import './buffer-shim'
import * as raw from "./raw"
import * as util from "../../lib_ts/util"
import * as tictactoe_pyteal from "../../lib_ts/tictactoe_pyteal"
import * as algo_network from "../../lib_ts/algo_network"
import * as tictactoe_testnet from "../../lib_ts/tictactoe_testnet"
import algosdk from "algosdk"
import { createEffect, createSignal, For, on, onCleanup } from "solid-js"
import { StoreonStore, createStoreon, StoreonDispatch } from "storeon"
import { StoreonProvider, useStoreon } from "@storeon/solidjs"
import { BiRegularRefresh } from "solid-icons/bi"
import { Node as GunRS } from "rusty-gun"
import GunJS from "gun/gun"
import { IGunInstance as IGunJS, IGunChain } from "gun"
// @ts-ignore
import styles from "./App.module.css"


const soul = "app"
const env = process.env
const CODESPACE_NAME = env.CODESPACE_NAME
const IS_TEST = !!env.IS_TEST

const DB_TYPE = ['gun_rs', 'gun_js'] as const

type Db =
    | { type: 'gun_rs', url: string, db: GunRS }
    | { type: 'gun_js', url: string, db: IGunJS }
type DbType = Db["type"]
util.assertTypeEquals<DbType, typeof DB_TYPE>(DB_TYPE)

type DbSubscription =
    | { type: 'gun_rs', subscription: number }
    | { type: 'gun_js', subscription: number }
type DbSubscriptionType = DbSubscription["type"]
util.assertTypeEquals<DbSubscriptionType, typeof DB_TYPE>(DB_TYPE)

type DbNode = IGunChain<any> | GunRS


// type DbModel = { [K in DbType]: { gun_rs?: GunRS, gun_js?: IGunJS }[K] }

// type DbSubscriptionModel = { [K in DbType]: { gun_rs?: number, gun_js?: number }[K] }

type Url = { url: string }


const newDb = (type: DbType, { url }: Url): Db | null => {
    if (type === 'gun_rs') {
        return { type, url, db: new GunRS(url) }
    } else if (type === 'gun_js') {
        return { type, url, db: new GunJS(url) }
    }
    return null
}

const startTimestamp = new Date().getTime()
const newTimestamp = () => new Date().getTime() - startTimestamp

const init = {
    token: tictactoe_testnet.token,
    chainUrl: CODESPACE_NAME ? `http://${CODESPACE_NAME}-4001.githubpreview.dev` : tictactoe_testnet.url,
    chainPort: CODESPACE_NAME ? 80 : tictactoe_testnet.port,
    db: {} as { [_: string]: Db },
    dbEnabled: {
        gun_rs: {
            gun_rs: false,
            gun_js: false
        } as { [_ in DbType]: boolean },
        gun_js: {
            gun_rs: false,
            gun_js: false
        } as { [_ in DbType]: boolean }
    } as { [_ in DbType]: { [_ in DbType]: boolean } },
    dbConnection: {
        gun_rs: {
            url: CODESPACE_NAME && !IS_TEST ? `ws://${CODESPACE_NAME}-4944.githubpreview.dev` : 'ws://localhost',
            port: CODESPACE_NAME && !IS_TEST ? 80 : (IS_TEST ? 14944 : 4944),
            ws: "ws"
        },
        gun_js: {
            url: CODESPACE_NAME && !IS_TEST ? `ws://${CODESPACE_NAME}-8765.githubpreview.dev` : 'wss://localhost',
            port: CODESPACE_NAME && !IS_TEST ? 80 : (IS_TEST ? 18765 : 8765),
            ws: "gun"
        }
    } as { [_ in DbType]: { url: string, port: number, ws: string } },
    accounts: tictactoe_testnet.accounts,
    status: undefined as { [_: string]: any } | undefined,
    deploy: undefined as { [_: string]: any } | undefined,
    counter: undefined as { [_: string]: number } | undefined
}

type State = typeof init
type Account = typeof init.accounts[number]

type Events = {
    set: Partial<State>
}

const runId = Math.random().toString(36).substring(2, 5)

const getStateLocals = (state: State) => {
    return {
        db: Object.entries(state.dbEnabled).reduce((accKeys, [dbType, enabledMap]) =>
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

const pad = (n: string, count: number): string => n.length < count ? pad(`0${n}`, count) : `${n}`

const getLog =
    (getLocals = () => ({}), argsColor = '#888') =>
        (...args: any[]) => {
            IS_TEST
                ? console.log(
                    `[${pad(newTimestamp().toString(), 6)}] ${runId}`,
                    JSON.stringify(args),
                    JSON.stringify(getLocals())
                )
                : console.log(
                    `[${pad(newTimestamp().toString(), 6)}] ${runId} %c%s %c%s`,
                    `font-weight: bold; color: ${argsColor}`,
                    JSON.stringify(args),
                    'font-weight: bold; color: #444',
                    JSON.stringify(getLocals())
                )
        }

const store = createStoreon([(store: StoreonStore<State, Events>) => {
    store.on('@init', () => init)
    store.on('set', (_, state) => state)
}])


function Links() {
    return (
        <table>
            <tbody>
                <tr>
                    <td>
                        <a target="_blank" href="https://github.com/fc1943s/tictactoe_spiral">
                            https://github.com/fc1943s/tictactoe_spiral
                        </a>
                    </td>
                </tr>
                <tr>
                    <td>
                        <a target="_blank" href="https://fc1943s.github.io/tictactoe_spiral">
                            https://fc1943s.github.io/tictactoe_spiral
                        </a>
                    </td>
                </tr>
                <tr>
                    <td>
                        <a target="_blank" href="https://fc1943s.github.io/tictactoe_spiral/docs">
                            https://fc1943s.github.io/tictactoe_spiral/docs
                        </a>
                    </td>
                </tr>
            </tbody>
        </table>
    )
}

function StateInput({ get, set }: { get: (state: State) => any, set: (state: State, value: any) => State }) {
    const [state, dispatch] = useStoreon<State, Events>()

    return (
        <input
            type="text"
            value={get(state)}
            onInput={(e: { currentTarget: { value: any } }) => dispatch('set', set(state, e.currentTarget.value))} />
    )
}

function Row({ title, children }: { title: string, children: any }) {
    return (
        <tr>
            <td>{title}</td>
            <td>{children}</td>
        </tr>
    )
}

function ChainConnection() {
    return (
        <table>
            <tbody>
                <Row title="Token">
                    <StateInput
                        get={(state) => state.token}
                        set={(state, value) => ({ ...state, token: value })} />
                </Row>
                <Row title="URL">
                    <StateInput
                        get={(state) => state.chainUrl}
                        set={(state, value) => ({ ...state, chainUrl: value })} />
                </Row>
                <Row title="Port">
                    <StateInput
                        get={(state) => state.chainPort}
                        set={(state, value) => ({ ...state, chainPort: value })} />
                </Row>
            </tbody>
        </table>
    )
}

function AccountInput({ key, account }: { key: keyof Omit<Account, 'alias'>, account: Account }) {
    return (
        <StateInput
            get={(_state) => account[key]}
            set={(state, value) => ({
                ...state,
                accounts:
                    state.accounts.map(
                        (_account) =>
                            _account.alias === account.alias
                                ? { ..._account, [key]: value }
                                : _account
                    )
            })} />
    )
}

function ChainAccounts() {
    const [state] = useStoreon<State, Events>()

    return (
        <table>
            <tbody>
                <For each={state.accounts}>
                    {(account) => (
                        <Row title={account.alias}>
                            <table>
                                <tbody>
                                    <Row title="Address">
                                        <AccountInput account={account} key="address" />
                                    </Row>
                                    <Row title="Private Key">
                                        <AccountInput account={account} key="privateKey" />
                                    </Row>
                                </tbody>
                            </table>
                        </Row>
                    )}
                </For>
            </tbody>
        </table>
    )
}

function DbConnectionInput({ type, key }: { type: DbType, key: keyof typeof init.dbConnection[DbType] }) {
    return (
        <StateInput
            get={(state) => state.dbConnection[type][key]}
            set={(state, value) => ({
                ...state,
                dbConnection: {
                    ...state.dbConnection,
                    [type]: {
                        ...state.dbConnection[type],
                        [key]: value
                    }
                }
            })} />
    )
}

function DbConnection({ type }: { type: DbType }) {
    return (
        <table>
            <tbody>
                <Row title="URL">
                    <DbConnectionInput type={type} key="url" />
                </Row>
                <Row title="Port">
                    <DbConnectionInput type={type} key="port" />
                </Row>
            </tbody>
        </table>
    )
}

const newUrl = (state: State, type: DbType) => {
    const connection = state.dbConnection[type]
    const url = `${connection.url}:${connection.port}/${connection.ws}`
    return url
}

type Id = { dbType: DbType, urlType: DbType, url: string, id: string }

const newId = (state: State, dbType: DbType, urlType: DbType): Id => {
    const url = newUrl(state, urlType)
    return {
        dbType,
        urlType,
        url,
        id: [dbType, url.replace(/\:\/\/localhost/g, '')].toString()
    }
}

const getDbIdList = (state: State): Id[][] =>
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

const getEnabledDbIdMap = (state: State): Map<string, Id> => new Map(getDbIdList(state)[0].map((id) => [id.id, id]))

function DbListener() {
    const [state, dispatch] = useStoreon<State, Events>()

    const getLocals = () => ({ ...getStateLocals(state) })
    const log = getLog(getLocals, '#cf1100')

    log('DbListener() 0')

    const refresh = () => {
        const db = getDbIdList(state)[0].reduce((accDb, { dbType, url, id }) => ({
            ...accDb,
            [id]: accDb[id] || newDb(dbType, { url })
        }), state.db)

        log('DbListener refresh() 1', { db })

        dispatch('set', { db })
    }

    const unbind = store.on('@changed', (newState, changed, store) => {
        log('DbListener store.on(@changed) 1', {
            changed: Object.keys(changed).map((key) => ({
                key,
                state: state[key as keyof State],
                newState: newState[key as keyof State],
                changed: changed[key as keyof State],
                store: store.get()[key as keyof State],
            }))
        })
        if (changed.dbEnabled || changed.dbConnection) {
            refresh()
        }
    })
    onCleanup(() => {
        unbind()
    })

    return <></>
}

const parse = (raw: object) => {
    const getLocals = () => ({ nRaw: `${raw}`.length, raw })
    const log = getLog(getLocals)
    log('parse() 0')
    let data = raw
    while (typeof data === 'string') {
        data = JSON.parse(data)
    }
    return data
}

const newListenerHandler = (
    state: State,
    id: string,
    key: keyof State,
    onValue: (id: string, hash: string, newValue: object) => void
) =>
    (v: object, k: any, _msg: any, _ev: any) => {
        const getLocals = () => ({
            ...getStateLocals(state),
            id,
            key,
            k
        })
        const log = getLog(getLocals)

        const { '#': hash, _: { '#': hash2, '>': ptrs, ..._ }, ...value }: { [_: string]: any } = { _: {}, ...parse(v) }

        // const newValue =
        //     Object.fromEntries(
        //         Object.entries(
        //             Object.keys(value).reduce((acc, k) => ({
        //                 ...acc,
        //                 [k]: value[k]
        //             }), (state[key] || {}) as { [_: string]: any })
        //         ).filter(([_, v]) => v !== null && typeof v !== 'undefined')
        //     )

        const newValue =
            [...Object.keys(state[key] || {}), ...Object.keys(value)]
                .reduce((acc, k) => ({
                    ...acc,
                    [k]: value[k] === null
                        ? undefined
                        : (value[k] !== undefined
                            ? value[k]
                            : (state[key] as { [_: string]: any })[k])
                }), {} as { [_: string]: any })

        log('newListenerHandler 1', {
            vType: typeof v,
            hash,
            hash2,
            _keys: Object.keys(_ || {}),
            nPtrsKeys: Object.keys(ptrs || {}).length,
            // nValue: Object.keys(value).length,
            // nNewValue: Object.keys(newValue).length,
            value: Object.entries(value),
            newValue: Object.entries(newValue),
            // nStateKey: Object.keys(state[key] || {}).length
            stateKey: Object.entries(state[key] || {})
        })

        onValue(id, hash, newValue)
    }

const getDbNode = (state: State, id: string, key: keyof State, timestamp: number | undefined): DbNode | undefined => {
    const getLocals = () => ({
        ...getStateLocals(state),
        id,
        key,
        timestamp
    })
    const log = getLog(getLocals)

    const db = state.db[id]

    log('getDbNode() 0', { db: !!db })
    if (db) {
        let node: DbNode = db.db.get(soul).get(key)
        if (timestamp) {
            node = node.get(`${timestamp}`)
        }
        return node
    }
    return undefined
}

const dbPut = (state: State, id: string, key: keyof State, timestamp: number | undefined, newValue: { [_: string]: any }) => {
    const getLocals = () => ({
        ...getStateLocals(state),
        id,
        key,
        timestamp,
        newValue
    })
    const log = getLog(getLocals)

    const node = getDbNode(state, id, key, timestamp)

    log('dbPut() 0', { node })
    if (node) {
        node.put(timestamp ? newValue[`${timestamp}`] : newValue)
    }
}

const dbOn = (
    state: State,
    { dbType, id }: Id,
    key: keyof State,
    timestamp: number | undefined,
    onValue: (id: string, hash: string, newValue: object) => void
): number | undefined => {
    const getLocals = () => ({
        ...getStateLocals(state),
        key,
        dbType,
        id,
        timestamp
    })
    const log = getLog(getLocals)

    const node = getDbNode(state, id, key, timestamp)

    log('dbOn() 0', { node })
    if (node) {
        if (dbType === 'gun_rs') {
            return node.on(newListenerHandler(state, id, key, onValue)) as number
        } else if (dbType === 'gun_js') {
            node.on(newListenerHandler(state, id, key, onValue))
            return newTimestamp()
        }
    }
}

const dbOff = (state: State, id: string, key: keyof State, timestamp: number | undefined, subscription: number | undefined) => {
    const getLocals = () => ({
        ...getStateLocals(state),
        id,
        key,
        timestamp,
        subscription
    })
    const log = getLog(getLocals)

    const node = getDbNode(state, id, key, timestamp)

    log('dbOff() 0', { node })
    if (node) {
        node.off(subscription as any)
    }
}

function useFetch(
    key: keyof util.PickByType<State, { [_: number]: any } | undefined>,
    requestFn: ((_: algosdk.Algodv2) => Promise<any>)
) {
    const [state, dispatch] = useStoreon<State, Events>()

    const [subscriptions, setSubscriptions] = createSignal({} as { [_: string]: DbSubscription })

    const [events, setEvents] = createSignal({} as { [_: string]: { off: () => void } | undefined })
    const [timers, setTimers] = createSignal({} as { [_: string]: NodeJS.Timer | undefined })
    const [values, setValues] = createSignal({} as { [_: string]: any })

    const getLocals = () => ({
        ...getStateLocals(state),
        key,
        [`${key}.keys`]: Object.keys(state[key] || {}),
        [`events`]: Object.entries(events()),
        [`timers`]: Object.entries(timers()),
        [`values`]: Object.entries(values()).reduce(
            ([keys, emptyKeys]: (string | any[])[][], [id, value]) =>
                !!value
                    ? [[...keys, [id, value]], emptyKeys]
                    : [keys, [...emptyKeys, id]],
            [[], []]),
        [`subscriptions`]: Object.entries(subscriptions()).map(([id, { subscription }]) => [id, subscription])
    })

    const defaultColors = Object.keys(init).reduce(
        (acc, x) => ({ ...acc, [x]: '#00cf2d' }),
        {} as { [key in keyof State]: string }
    )
    const colors = { ...defaultColors, status: '#cf6800', deploy: '#cccf00' }
    const log = getLog(getLocals, colors[key])

    log('useFetch() 0')

    const newOnValue = (resub: (_: string) => void) =>
        (id: string, hash: string, newValue: object) => {
            log('useFetch.onValue() 1/2', { id, hash, newValue })

            if (hash && Object.keys(state[key] || {}).length > 0) {
                log('useFetch.onValue() 2/2. resub')

                resub(id)

                // const oldSubscriptions = subscriptions()
                // setSubscriptions({
                //     ...oldSubscriptions,
                //     [id]: oldSubscriptions[id]
                // })
            } else {
                const oldTimers = { ...timers() }
                oldTimers[id] && clearTimeout(oldTimers[id])
                delete oldTimers[id]
                setTimers(oldTimers)

                // Object.values(timers()).forEach(timer => timer && clearInterval(timer))
                // setTimers({})

                dispatch('set', { [key]: newValue })

                const oldValues = values()
                const newValueJson = JSON.stringify(newValue)

                log('useFetch.onValue() 2/2. before put loop', { newValue })

                if (newValueJson !== JSON.stringify(oldValues[id])) {
                    setValues({ ...oldValues, [id]: newValue })

                    getDbIdList(state)[0].forEach((dbId) => {
                        if (id !== dbId.id && newValueJson !== JSON.stringify(oldValues[dbId.id])) {
                            log('useFetch.onValue() 3/2. before put item', { id: dbId.id })

                            dbPut(state, dbId.id, key, undefined, newValue)
                        }
                    })
                } else {
                    log('useFetch.onValue() 2/2. skip')
                }
            }
        }

    const unsubscribe = () => {
        log('useFetch.unsubscribe() 1')

        Object.entries(subscriptions()).forEach(([id, { type, subscription }]) => {
            log('useFetch.unsubscribe 2 item', { id, type, subscription })
            dbOff(state, id, key, undefined, subscription)
        })
        setSubscriptions({})

        Object.values(events()).forEach((event) => event?.off())
        setEvents({} as { [_: string]: any })
    }

    const resub = (id: string) => {
        const oldTimers = timers()
        oldTimers[id] && clearTimeout(oldTimers[id])

        log('useFetch.resub() 1', { oldTimers })
        setTimers({
            ...oldTimers,
            [id]: setTimeout(() => {
                // const oldSubscriptions = subscriptions()
                // const oldSubscription = oldSubscriptions[id]

                log('useFetch.resub() inside timeout 2')//, oldSubscription)

                // if (oldSubscription) {
                //     dbOff(state, id, key, undefined, oldSubscription.subscription)
                // }

                // dispatch('set', {
                //     // db: {
                //     //     ...state.db,
                //     //     [id]: null as any as Db
                //     // },
                //     dbEnabled: {
                //         ...state.dbEnabled
                //     }
                // })
            }, 10000)
        })
    }

    const subscribe = (id: Id) => {
        const oldSubscriptions = subscriptions()
        const oldSubscription = oldSubscriptions[id.id]
        log('useFetch.subscribe() 1', { oldSubscription })

        if (!oldSubscription && state.dbEnabled) {
            const newSubscription = dbOn(state, id, key, undefined, newOnValue(resub))
            log('useFetch.subscribe() 2', { newSubscription })
            if (newSubscription) {
                setSubscriptions({
                    ...oldSubscriptions,
                    [id.id]: { type: id.dbType, subscription: newSubscription }
                })
            }

            resub(id.id)
        }
    }

    const unbind = store.on('@changed', (newState, changed, oldStore) => {
        if (changed.dbEnabled || changed.db) {
            log('useFetch.store.@changed 1', {
                changed: Object.keys(changed).map((key) => ({
                    key,
                    state: state[key as keyof State],
                    newState: newState[key as keyof State],
                    changed: changed[key as keyof State],
                    oldStore: oldStore.get()[key as keyof State],
                }))
            })

            unsubscribe()
            // setTimeout(() => getEnabledDbIdList(newState).forEach((id) => subscribe(newState, id)), 2000)

            Object.values(timers()).forEach((timer) => timer && clearTimeout(timer))
            setTimers(
                getDbIdList(newState)[0].reduce((accIntervals, id) =>
                ({
                    ...accIntervals,
                    [id.id]: setTimeout(() => subscribe(id), 2500)
                }), {} as { [_: string]: NodeJS.Timer | undefined })
            )
        }
    })
    onCleanup(() => {
        unbind()
        unsubscribe()
    })

    const request = async () => {
        const client = algo_network.newClient(state.token, state.chainUrl, state.chainPort)
        let result: {}
        try {
            result = await requestFn(client)
        } catch (e) {
            result = e as {}
        }

        const timestamp = newTimestamp()
        const newValue = {
            ...(state[key] as { [_: string]: any }),
            [`${timestamp}`]: result
        }

        log('useFetch.request() 1', { result, newValue })

        // dispatch('set', { [key]: newValue })

        getDbIdList(state)[0].forEach(({ id }) => {
            log('useFetch.request() 1 before dbPut', { id })

            dbPut(state, id, key, undefined, newValue)
        })

        Object.values(timers()).forEach((timer) => timer && clearTimeout(timer))
        setTimers(
            getDbIdList(state)[0].reduce((accIntervals, id) =>
            ({
                ...accIntervals,
                [id.id]: setTimeout(() => {
                    const oldSubscriptions = subscriptions()
                    const oldSubscription = oldSubscriptions[id.id]

                    log('useFetch.request() 1 resub timeout', { id: id.id, oldSubscription })

                    if (oldSubscription) {
                        dbOff(state, id.id, key, undefined, oldSubscription.subscription)
                    }
                    const newSubscriptions = { ...subscriptions() }
                    delete newSubscriptions[id.id]
                    setSubscriptions(newSubscriptions)

                    subscribe(id)
                }, 10000)
            }), {} as { [_: string]: NodeJS.Timer | undefined })
        )
    }

    const clear = () => {
        log('useFetch.clear() 1')

        const newValue = Object.keys(state[key] || {}).reduce((acc, k) => ({
            ...acc,
            [k]: null
        }), {})

        // dispatch('set', { [key]: newValue })

        getDbIdList(state)[0].forEach(({ id }) => {
            log('useFetch.clear() 1 before dbPut', { id })

            dbPut(state, id, key, undefined, newValue)
        })

        Object.values(timers()).forEach((timer) => timer && clearTimeout(timer))
        setTimers(
            getDbIdList(state)[0].reduce((accIntervals, id) =>
            ({
                ...accIntervals,
                [id.id]: setTimeout(() => {
                    log('useFetch.clear() 1 resub timeout', { id: id.id })
                    subscribe(id)
                }, 10000)
            }), {} as { [_: string]: NodeJS.Timer | undefined })
        )
    }

    return { request, clear, values }
}

function Counter() {
    const [state, _] = useStoreon<State, Events>()

    const { request, clear, values } = useFetch('counter', async (_client) => Object.keys(state.counter || {}).length)

    return (
        <div id="counter">
            <button onClick={request}>Request</button>
            <button onClick={clear}>Clear</button>
            <pre>{JSON.stringify({ counter: state.counter, values: values() }, null, 2)}</pre>
        </div>
    )
}

function Status() {
    const [state, _] = useStoreon<State, Events>()

    const { request, clear } = useFetch('status', (client) => client.status().do())

    return (
        <div id="status">
            <button onClick={request}>Request</button>
            <button onClick={clear}>Clear</button>
            <pre>{JSON.stringify(state.status, null, 2)}</pre>
        </div>
    )
}

function Deploy() {
    const [state, _] = useStoreon<State, Events>()

    const { request, clear } = useFetch('deploy', async (client) => {
        const address = state.accounts[0]?.address
        const privateKey = state.accounts[0]?.privateKey
        if (address && privateKey) {
            try {
                const output = await algo_network.deployApplication(
                    client,
                    address,
                    privateKey,
                    raw.applicationStartTeal,
                    raw.clearProgramTeal,
                    {
                        numGlobalByteSlices: tictactoe_pyteal.numGlobalByteSlices,
                        numGlobalInts: tictactoe_pyteal.numGlobalInts
                    }
                )

                return output
            } catch (e) {
                return e
            }
        } else {
            return 'Invalid admin account'
        }
    })

    return (
        <div id="deploy">
            <button onClick={request}>Request</button>
            <button onClick={clear}>Clear</button>
            <pre>{JSON.stringify(state.deploy, null, 2)}</pre>
        </div>
    )
}


function Loader({ id, onLoad, children }: {
    id?: string,
    onLoad?: (state: State, dispatch: StoreonDispatch<Events>) => void,
    children: any
}) {
    const [state, dispatch] = useStoreon<State, Events>()

    const [loaded, setLoaded] = createSignal(false)
    const [refreshing, setRefreshing] = createSignal(false)

    createEffect(on(
        () => [refreshing()],
        () => refreshing() && setRefreshing(false)
    ))

    const loadClick = () => {
        onLoad?.(state, dispatch)
        setLoaded(true)
    }

    return (
        <div id={id}>
            {!loaded()
                ? <div><button onClick={loadClick}>Load</button></div>
                : (
                    <div class={styles.IframeContainer}>
                        <button onClick={() => setRefreshing(true)}><BiRegularRefresh size="24px" /></button>
                        {!refreshing() && children}
                    </div>
                )
            }
        </div>
    )
}

function App() {
    return (
        <StoreonProvider store={store}>
            <DbListener />
            <table class={styles.App}>
                <tbody>
                    <Row title="Links">
                        <Links />
                    </Row>
                    <tr><td></td></tr>
                    <Row title="Chain Connection">
                        <ChainConnection />
                    </Row>
                    <Row title="Chain Accounts">
                        <ChainAccounts />
                    </Row>
                    <Row title="Testnet Bank Dispenser">
                        <Loader>
                            <iframe
                                src="https://bank.testnet.algorand.network"
                                title="algorand testnet bank"
                                style={`height: 350px`} />
                        </Loader>
                    </Row>
                    <tr><td></td></tr>
                    <Row title="Database (Rust->Rust)">
                        <Loader
                            id="db-gun-rs-rs"
                            onLoad={(state, dispatch) => {
                                dispatch('set', {
                                    dbEnabled: {
                                        ...state.dbEnabled,
                                        gun_rs: {
                                            ...state.dbEnabled.gun_rs,
                                            gun_rs: true
                                        }
                                    }
                                })
                            }}>
                            <DbConnection type="gun_rs" />
                        </Loader>
                    </Row>
                    <Row title="Database (Rust->JavaScript)">
                        <Loader
                            id="db-gun-rs-js"
                            onLoad={(state, dispatch) => {
                                dispatch('set', {
                                    dbEnabled: {
                                        ...state.dbEnabled,
                                        gun_rs: {
                                            ...state.dbEnabled.gun_rs,
                                            gun_js: true
                                        }
                                    }
                                })
                            }}>
                            <DbConnection type="gun_js" />
                        </Loader>
                    </Row>
                    <Row title="Database (JavaScript->Rust)">
                        <Loader
                            id="db-gun-js-rs"
                            onLoad={(state, dispatch) => {
                                dispatch('set', {
                                    dbEnabled: {
                                        ...state.dbEnabled,
                                        gun_js: {
                                            ...state.dbEnabled.gun_js,
                                            gun_rs: true
                                        }
                                    }
                                })
                            }}>
                            <DbConnection type="gun_rs" />
                        </Loader>
                    </Row>
                    <Row title="Database (JavaScript->JavaScript)">
                        <Loader
                            id="db-gun-js-js"
                            onLoad={(state, dispatch) => {
                                dispatch('set', {
                                    dbEnabled: {
                                        ...state.dbEnabled,
                                        gun_js: {
                                            ...state.dbEnabled.gun_js,
                                            gun_js: true
                                        }
                                    }
                                })
                            }}>
                            <DbConnection type="gun_js" />
                        </Loader>
                    </Row>
                    <tr><td></td></tr>
                    <Row title="Counter">
                        <Counter />
                    </Row>
                    {!!env.GITHUB_RUN_ID
                        ? <>
                            <Row title="Status">
                                <Status />
                            </Row>
                            <Row title="Deploy">
                                <Deploy />
                            </Row>
                        </>
                        : <></>}
                    <tr><td></td></tr>

                </tbody>
            </table>
        </StoreonProvider>
    )
}

export default App
