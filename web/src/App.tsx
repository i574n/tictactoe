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
import { IGunInstance as IGunJS } from "gun"
// @ts-ignore
import styles from "./App.module.css"


type NoneEmptyArray = readonly any[] & { 0: any }
type CompareUnionWithArray<P, Q extends NoneEmptyArray> = Exclude<P, Q[number]> extends never
    ? (Exclude<Q[number], P> extends never ? Q : ReadonlyArray<P>)
    : readonly [...Q, Exclude<P, Q[number]>]
export function assertTypeEquals<P, Q extends NoneEmptyArray>(_test: CompareUnionWithArray<P, Q>): void { }


const soul = "app"
const CODESPACE_NAME = process.env.CODESPACE_NAME
const IS_TEST = !!process.env.IS_TEST

const DB_TYPE = ['gun_rs', 'gun_js'] as const

type Db =
    | { type: 'gun_rs', url: string, db: GunRS }
    | { type: 'gun_js', url: string, db: IGunJS }
type DbType = Db["type"]
assertTypeEquals<DbType, typeof DB_TYPE>(DB_TYPE)

type DbSubscription =
    | { type: 'gun_rs', subscription: number }
    | { type: 'gun_js', subscription: boolean }
type DbSubscriptionType = DbSubscription["type"]
assertTypeEquals<DbSubscriptionType, typeof DB_TYPE>(DB_TYPE)


type DbModel = { [K in DbType]: { gun_rs?: GunRS, gun_js?: IGunJS }[K] }

type DbSubscriptionModel = { [K in DbType]: { gun_rs?: number, gun_js?: boolean }[K] }

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
    status: {} as { [_: string]: any },
    deploy: {} as { [_: string]: any },
    counter: {} as { [_: string]: number }
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
                        `${dbType}-${urlType}`
                    ],
                accKeys
            ),
            [] as string[]
        )
    }
}

const getLog =
    (getLocals: () => object, argsColor = '#888') =>
        (...args: any[]) => {
            IS_TEST
                ? console.log(
                    `[log] ${runId}`,
                    JSON.stringify(args),
                    JSON.stringify(getLocals())
                )
                : console.log(
                    `[log] ${runId} %c%s %c%s`,
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
    const [state, dispatch] = useStoreon<State, Events>()

    return (
        <input
            type="text"
            value={account[key]}
            onInput={e => dispatch('set', {
                accounts:
                    state.accounts.map(
                        (_account) =>
                            _account.alias === account.alias
                                ? { ..._account, [key]: e.currentTarget.value }
                                : _account
                    )
            })}
        />
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

function DbListener() {
    const [state, dispatch] = useStoreon<State, Events>()

    const getLocals = () => ({
        ...getStateLocals(state)
    })

    const log = getLog(getLocals, '#cf1100')

    log('DbListener() 0')

    const refresh = () => {
        log('DbListener.refresh() 1')

        const db = Object.entries(state.dbEnabled).reduce((accKeys, [dbType, enabledMap]) =>
            Object.entries(enabledMap).reduce((accKeys, [urlType, enabled]) =>
                !enabled
                    ? accKeys
                    : [
                        ...accKeys,
                        { type: dbType as DbType, url: newUrl(state, urlType as DbType) }
                    ],
                accKeys
            ),
            [] as { type: DbType; url: string }[]
        ).reduce((accDb, { type, url }) => {
            const id = JSON.stringify({ type, url })
            return {
                ...accDb,
                [id]: accDb[id] || newDb(type, { url })
            }
        }, state.db)

        log('DbListener.refresh() 1', { db })

        dispatch('set', { db })
    }

    const unbind = store.on('@changed', (oldState, changed, oldStore) => {
        log('DbListener.store.@changed 1', {
            changed: Object.keys(changed).map((key) => ({
                key,
                old: oldState[key as keyof State],
                new: changed[key as keyof State],
                store: oldStore.get()[key as keyof State],
            }))
        })
        if (changed.dbEnabled || changed.dbConnection) {
            refresh()
        }
    })
    onCleanup(() => unbind())

    // createEffect(on(
    //     () => [],
    //     () => {
    //         log('DbListener.createEffect() 1')
    //         refresh()
    //     }
    // ))

    return <></>
}

function useFetch(key: keyof util.PickByType<State, { [_: number]: any }>, requestFn: ((_: algosdk.Algodv2) => Promise<any>)) {
    const [state, dispatch] = useStoreon<State, Events>()

    const [subscriptions, setSubscriptions] = createSignal({} as { [_: string]: DbSubscription })

    const [events, setEvents] = createSignal({} as { [_: string]: { off: () => void } | null })
    const [intervals, setIntervals] = createSignal({} as { [_: string]: NodeJS.Timer | null })
    const [values, setValues] = createSignal({} as { [_: string]: any })

    const getLocals = () => ({
        ...getStateLocals(state),
        key,
        [`${key}.keys`]: Object.keys(state[key]),
        [`events`]: Object.values(events()),
        [`intervals`]: Object.values(intervals()),
        [`values`]: Object.values(values()),
        [`subscriptions`]: Object.values(subscriptions())
    })

    const defaultColors = Object.keys(init).reduce(
        (acc, x) => ({ ...acc, [x]: '#00cf2d' }),
        {} as { [key in keyof State]: string }
    )
    const colors = { ...defaultColors, status: '#cf6800', deploy: '#cccf00' }
    const log = getLog(getLocals, colors[key])

    log('useFetch() 0')

    const parse = (raw: object) => {
        log('useFetch.parse() 1', { raw })
        let data = raw
        while (typeof data === 'string') {
            data = JSON.parse(data)
        }
        return data
    }

    const newListenerHandler = (id: string) => (v: object, k: any, _msg: any, _ev: any) => {
        const { _, '#': hash, ...value }: { [_: string]: any } = parse(v)
        // const valueKeys = Object.keys(value)

        // if (valueKeys.length > 0 || !hash || Object.keys(state[key]).length === 0) {
        // const oldEvents = events()
        // oldEvents[id]?.off()
        // setEvents({
        //     ...oldEvents,
        //     [id]: _ev
        // })





        // Object.values(events()).forEach(events => events?.off())
        // setEvents({})



        // const oldIntervals = intervals()
        // const interval = oldIntervals[id]
        // if (interval) {
        //     clearInterval(interval)
        //     setIntervals({
        //         ...oldIntervals,
        //         [id]: null
        //     })
        // }

        Object.values(intervals()).forEach(interval => interval && clearInterval(interval))
        setIntervals({})

        const newValue =
            Object.keys(value)
                .reduce((acc, k) => ({
                    ...acc,
                    [k]: value[k] === null
                        ? undefined
                        : value[k]
                }), state[key] as { [_: string]: any })

        log('useFetch.newListenerHandler 1', {
            _,
            id,
            hash,
            k,
            vJson: JSON.stringify(v),
            vType: typeof v,
            valueEntries: Object.entries(value),
            newValueEntries: Object.entries(newValue),
            stateKeyEntries: Object.entries(state[key])
        })

        if (JSON.stringify(newValue) !== JSON.stringify(state[key])) {
            dispatch('set', { [key]: newValue })
            setValues({ ...values(), [id]: newValue })
        } else {
            log('useFetch.newListenerHandler 1. skip')
        }

        // } else {
        //     log('useFetch.newListenerHandler 1. skip')
        // }
    }

    const subscribe = (db: { [_: string]: Db }) => {
        log('useFetch.subscribe() 1')

        const newSubscriptions = Object.entries(state.dbEnabled).reduce((accSubscriptions, [dbType, enabledMap]) =>
            Object.entries(enabledMap).reduce((accSubscriptions, [urlType, enabled]) =>
                !enabled
                    ? accSubscriptions
                    : {
                        ...accSubscriptions,
                        ...Object.entries(db).reduce((accSubscriptions, [id, { type, db }]) => {
                            // const url = newUrl(state, urlType as DbType)
                            // const id = JSON.stringify({ type: dbType as DbType, url })
                            if (db) {
                                if (accSubscriptions[id]) {
                                    // const oldEvents = events()
                                    // oldEvents[id]?.off()
                                    // setEvents({
                                    //     ...oldEvents,
                                    //     [id]: null
                                    // })




                                    // accSubscriptions[id].forEach(({ off }) => off())



                                    // oldEvents[type]?.off()
                                    // setEvents({ ...oldEvents, [type]: undefined as any })
                                    //             currentSubscriptions.forEach((subscription) => {
                                    //                 node.off(subscription as number)
                                    //             })
                                    // node.off(accSubscriptions[id] as number)
                                }


                                if (type === 'gun_rs') {
                                    const node = (db as GunRS).get(soul).get(key)

                                    accSubscriptions[id] && node.off(accSubscriptions[id].subscription as number)

                                    const subscription: number = node.on(newListenerHandler(id))
                                    log('useFetch.subscribe() 2', { type, subscription })
                                    return {
                                        ...accSubscriptions,
                                        [id]: { type, subscription }
                                    }
                                } else if (type === 'gun_js') {
                                    const node = (db as IGunJS).get(soul).get(key)

                                    accSubscriptions[id] && node.off()

                                    node.on(newListenerHandler(id))
                                    const subscription = true
                                    log('useFetch.subscribe() 2', { type, subscription })
                                    return {
                                        ...accSubscriptions,
                                        [id]: { type, subscription }
                                    }
                                }
                            }
                            return accSubscriptions
                        }, {} as { [_: string]: DbSubscription })
                    },
                accSubscriptions
            ),
            subscriptions()
        )

        setSubscriptions(newSubscriptions)
    }

    const unsubscribe = (state: State) => {
        log('useFetch.unsubscribe() 1')

        Object.entries(subscriptions()).forEach(([id, { type: subscriptionType, subscription }]) => {
            log('useFetch.unsubscribe 2', { id, subscriptionType, subscription })

            Object.entries(state.dbEnabled).forEach(([dbType, enabledMap]) =>
                Object.entries(enabledMap).forEach(([urlType, enabled]) => {
                    if (enabled) {
                        const id = JSON.stringify({ type: dbType as DbType, url: newUrl(state, urlType as DbType) })
                        const db = state.db[id]
                        if (db) {
                            log('useFetch.unsubscribe() 3', { dbType, urlType, id })

                            if (dbType === 'gun_rs') {
                                const node = (db.db as GunRS).get(soul).get(key)
                                node.off(subscription as number)
                            } else if (dbType === 'gun_js' && subscription) {
                                const node = (db.db as IGunJS).get(soul).get(key)
                                node.off()
                            }
                        }
                    }
                })
            )
        })
        setSubscriptions({})

        Object.values(events()).forEach((event) => event?.off())
        setEvents({} as { [_ in DbType]: any })
    }

    const unbind = store.on('@changed', (oldState, changed, oldStore) => {
        if (changed.dbEnabled || changed.db) {
            log('useFetch.store.@changed 1', {
                changed: Object.keys(changed).map((key) => ({
                    key,
                    old: oldState[key as keyof State],
                    new: changed[key as keyof State],
                    store: oldStore.get()[key as keyof State]
                }))
            })

            unsubscribe(oldState)
            Object.values(intervals()).forEach((interval) => interval && clearInterval(interval))
            setIntervals(
                Object.entries(state.dbEnabled).reduce((accIntervals, [dbType, enabledMap]) =>
                    Object.entries(enabledMap).reduce((accIntervals, [urlType, enabled]) =>
                        !enabled
                            ? accIntervals
                            : {
                                ...accIntervals,
                                ...Object.entries(changed.db || oldState.db).reduce((accIntervals, [id, { type, db }]) => {
                                    const url = newUrl(state, urlType as DbType)
                                    const newId = JSON.stringify({ type: dbType as DbType, url })
                                    if (id === newId) {
                                        if (db) {
                                            return {
                                                ...accIntervals,
                                                [id]: setInterval(() => {
                                                    log('useFetch.store.@changed callback setInterval unsubscribe -> subscribe... 2',
                                                        { changedKeys: Object.keys(changed), type })
                                                    unsubscribe(oldState)
                                                    oldState.dbEnabled && changed.dbEnabled && subscribe(changed.db || oldState.db)
                                                }, 2000)
                                            }
                                        }
                                    } else {
                                        log('useFetch.store.@changed callback setInterval skip. 2',
                                            { id, changedKeys: Object.keys(changed), type })
                                    }
                                    return accIntervals
                                }, {} as { [_: string]: NodeJS.Timer | null })
                            },
                        accIntervals
                    ),
                    {} as { [_: string]: NodeJS.Timer | null }
                )
            )
        }
    })
    onCleanup(() => {
        unbind()
        unsubscribe(state)
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
        const data = {
            ...(state[key] as { [_: string]: any }),
            [`${timestamp}`]: result
        }

        log('useFetch.request() 1', { result, data })

        dispatch('set', { [key]: data })

        Object.entries(state.dbEnabled).forEach(([dbType, enabledMap]) =>
            Object.entries(enabledMap).forEach(([urlType, enabled]) => {
                if (enabled) {
                    const id = JSON.stringify({ type: dbType as DbType, url: newUrl(state, urlType as DbType) })
                    const db = state.db[id]
                    if (db) {
                        log('useFetch.request() 2', { dbType, urlType, data })

                        if (dbType === 'gun_rs') {
                            const node = (db.db as GunRS).get(soul).get(key)
                            // node.get(`${timestamp}`).put(result)
                            node.put(data)
                        } else if (dbType === 'gun_js') {
                            const node = (db.db as IGunJS).get(soul).get(key)
                            // node.get(`${timestamp}`).put(result)
                            node.put(data)
                        }
                    }
                }
            })
        )
    }

    const clear = async () => {
        log('useFetch.clear() 1')

        const data = Object.keys(state[key])
            .reduce((acc, k) => ({
                ...acc,
                [k]: null
            }), {})

        dispatch('set', { [key]: data })

        Object.entries(state.dbEnabled).forEach(([dbType, enabledMap]) =>
            Object.entries(enabledMap).forEach(([urlType, enabled]) => {
                if (enabled) {
                    const id = JSON.stringify({ type: dbType as DbType, url: newUrl(state, urlType as DbType) })
                    const db = state.db[id]
                    if (db) {
                        log('useFetch.clear() 2', { dbType, urlType, data })

                        if (dbType === 'gun_rs') {
                            const node = (db.db as GunRS).get(soul).get(key)
                            node.put(data)
                        } else if (dbType === 'gun_js') {
                            const node = (db.db as IGunJS).get(soul).get(key)
                            node.put(data)
                        }
                    }
                }
            })
        )
    }

    return { request, clear }
}

function Counter() {
    const [state, _] = useStoreon<State, Events>()

    const { request, clear } = useFetch('counter', async (_client) => Object.keys(state.counter).length)

    return (
        <div id="counter">
            <button onClick={request}>Request</button>
            <button onClick={clear}>Clear</button>
            <pre>{JSON.stringify(state.counter, null, 2)}</pre>
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
                    <tr><td></td></tr>
                    {/* <Row title="Status">
                        <Status />
                    </Row>
                    <Row title="Deploy">
                        <Deploy />
                    </Row> */}
                </tbody>
            </table>
        </StoreonProvider>
    )
}

export default App
