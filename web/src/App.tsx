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

type NoneEmptyArray = readonly any[] & { 0: any }
type CompareUnionWithArray<P, Q extends NoneEmptyArray> = Exclude<P, Q[number]> extends never
    ? (Exclude<Q[number], P> extends never ? Q : ReadonlyArray<P>)
    : readonly [...Q, Exclude<P, Q[number]>]
export function assertTypeEquals<P, Q extends NoneEmptyArray>(_test: CompareUnionWithArray<P, Q>): void { }


const soul = "app"
const env = process.env
const CODESPACE_NAME = env.CODESPACE_NAME
const IS_TEST = !!env.IS_TEST

const DB_TYPE = ['gun_rs', 'gun_js'] as const

type Db =
    | { type: 'gun_rs', url: string, db: GunRS }
    | { type: 'gun_js', url: string, db: IGunJS }
type DbType = Db["type"]
assertTypeEquals<DbType, typeof DB_TYPE>(DB_TYPE)

type DbSubscription =
    | { type: 'gun_rs', subscription: number }
    | { type: 'gun_js', subscription: number }
type DbSubscriptionType = DbSubscription["type"]
assertTypeEquals<DbSubscriptionType, typeof DB_TYPE>(DB_TYPE)

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

type Id = { dbType: DbType, url: string, id: string }

const newId = (dbType: DbType, url: string): Id => {
    return {
        dbType,
        url,
        id: [dbType, url.replace(/\:\/\/localhost/g, '')].toString()
    }
}

const getEnabledDbIdList = (state: State): Id[] =>
    Object.entries(state.dbEnabled).reduce((accKeys, [dbType, enabledMap]) =>
        Object.entries(enabledMap).reduce((accKeys, [urlType, enabled]) =>
            !enabled
                ? accKeys
                : [
                    ...accKeys,
                    newId(dbType as DbType, newUrl(state, urlType as DbType))
                ],
            accKeys
        ),
        [] as Id[])

function DbListener() {
    const [state, dispatch] = useStoreon<State, Events>()

    const getLocals = () => ({ ...getStateLocals(state) })
    const log = getLog(getLocals, '#cf1100')

    log('DbListener() 0')

    const refresh = () => {
        const db = getEnabledDbIdList(state).reduce((accDb, { dbType, url, id }) => ({
            ...accDb,
            [id]: accDb[id] || newDb(dbType, { url })
        }), state.db)

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
    onCleanup(() => {
        unbind()
    })

    return <></>
}

const parse = (raw: object) => {
    const getLocals = () => ({ raw })
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
        const getLocals = () => ({ ...getStateLocals(state), id, k })
        const log = getLog(getLocals)

        const { _, '#': hash, ...value }: { [_: string]: any } = parse(v)

        const newValue =
            [...Object.keys(state[key]), ...Object.keys(value)]
                .reduce((acc, k) => ({
                    ...acc,
                    [k]: value[k] === null
                        ? undefined
                        : (value[k] !== undefined
                            ? value[k]
                            : (state[key] as { [_: string]: any })[k])
                }), {} as { [_: string]: any })

        log('newListenerHandler 1', {
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

        onValue(id, Object.keys(value).length === 0 ? hash : undefined, newValue)
    }

const getDbNode = (state: State, id: string, key: keyof State, timestamp: number | undefined): DbNode | undefined => {
    const getLocals = () => ({
        ...getStateLocals(state),
        id, key, timestamp
    })
    const log = getLog(getLocals)

    const db = state.db[id]

    log('getDbNode() 0')
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
        newValue
    })
    const log = getLog(getLocals)

    const node = getDbNode(state, id, key, timestamp)

    log('dbPut() 0', { node })
    if (node) {
        node.put(timestamp ? newValue[`${timestamp}`] : newValue)
    }
}

const dbOff = (state: State, id: string, key: keyof State, timestamp: number | undefined, subscription: number | undefined) => {
    const getLocals = () => ({
        ...getStateLocals(state)
    })
    const log = getLog(getLocals)

    const node = getDbNode(state, id, key, timestamp)

    log('dbOff() 0', { node })
    if (node) {
        node.off(subscription as any)
    }
}

const dbOn = (
    state: State,
    { dbType, id }: Id,
    key: keyof State,
    timestamp: number | undefined,
    subscriptions: { [_: string]: DbSubscription },
    onValue: (id: string, hash: string, newValue: object) => void
): number | undefined => {
    const getLocals = () => ({
        ...getStateLocals(state)
    })
    const log = getLog(getLocals)

    const node = getDbNode(state, id, key, timestamp)

    log('dbOn() 0', { node })
    if (node) {
        const oldSubscription = subscriptions[id]
        if (dbType === 'gun_rs') {
            oldSubscription && node.off(oldSubscription.subscription)
            return node.on(newListenerHandler(state, id, key, onValue)) as number
        } else if (dbType === 'gun_js') {
            oldSubscription && node.off(undefined as any)
            node.on(newListenerHandler(state, id, key, onValue))
            return newTimestamp()
        }
    }
}

function useFetch(key: keyof util.PickByType<State, { [_: number]: any }>, requestFn: ((_: algosdk.Algodv2) => Promise<any>)) {
    const [state, dispatch] = useStoreon<State, Events>()

    const [subscriptions, setSubscriptions] = createSignal({} as { [_: string]: DbSubscription })

    const [events, setEvents] = createSignal({} as { [_: string]: { off: () => void } | undefined })
    const [intervals, setIntervals] = createSignal({} as { [_: string]: NodeJS.Timer | undefined })
    const [values, setValues] = createSignal({} as { [_: string]: any })

    const getLocals = () => ({
        ...getStateLocals(state),
        key,
        [`${key}.keys`]: Object.keys(state[key]),
        [`events`]: Object.entries(events()),
        [`intervals`]: Object.entries(intervals()),
        [`values`]: Object.entries(values()),
        [`subscriptions`]: Object.entries(subscriptions()).map(([id, { subscription }]) => [id, subscription])
    })

    const defaultColors = Object.keys(init).reduce(
        (acc, x) => ({ ...acc, [x]: '#00cf2d' }),
        {} as { [key in keyof State]: string }
    )
    const colors = { ...defaultColors, status: '#cf6800', deploy: '#cccf00' }
    const log = getLog(getLocals, colors[key])

    log('useFetch() 0')

    const onValue = (id: string, hash: string, newValue: object) => {
        log('useFetch.onValue() 1', { id, hash, newValue })

        if (hash && Object.keys(state[key]).length > 0) {
            log('useFetch.onValue() 1. resub')

            // const oldSubscriptions = subscriptions()
            // setSubscriptions({
            //     ...oldSubscriptions,
            //     [id]: oldSubscriptions[id]
            // })
        }

        const oldIntervals = intervals()
        oldIntervals[id] && clearInterval(oldIntervals[id])
        setIntervals({
            ...oldIntervals,
            [id]: undefined
        })
        // Object.values(intervals()).forEach(interval => interval && clearInterval(interval))
        // setIntervals({})

        if (JSON.stringify(newValue) !== JSON.stringify(state[key])) {
            dispatch('set', { [key]: newValue })
            setValues({ ...values(), [id]: newValue })

            getEnabledDbIdList(state).forEach((dbId) => {
                if (id !== dbId.id) {
                    dbPut(state, dbId.id, key, undefined, newValue)
                }
            })
        } else {
            log('useFetch.onValue() 1. skip')
        }
    }

    const subscribe = (db: { [_: string]: Db }) => {
        const newSubscriptions = getEnabledDbIdList(state).reduce((accSubscriptions, dbId) => ({
            ...accSubscriptions,
            ...Object.entries(db).reduce((accSubscriptions, [id, { type, db }]) =>
                !db || id !== dbId.id
                    ? accSubscriptions
                    : {
                        ...accSubscriptions,
                        [id]: {
                            type,
                            subscription: dbOn(state, dbId, key, undefined, accSubscriptions, onValue)
                        } as DbSubscription
                    },
                accSubscriptions)
        }), subscriptions())

        log('useFetch.subscribe() 1', {
            newSubscriptions: Object.entries(newSubscriptions).map(([id, { subscription }]) => [id, subscription])
        })

        setSubscriptions(newSubscriptions)
    }

    const unsubscribe = (state: State) => {
        log('useFetch.unsubscribe() 1')

        Object.entries(subscriptions()).forEach(([id, { type: subscriptionType, subscription }]) => {
            log('useFetch.unsubscribe 2', { id, subscriptionType, subscription })


            getEnabledDbIdList(state).forEach(({ id }) => {
                dbOff(state, id, key, undefined, subscription)
            })
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
                getEnabledDbIdList(state).reduce((accIntervals, dbId) => ({
                    ...accIntervals,
                    ...Object.keys(changed.db || oldState.db).reduce((accIntervals, id) => {
                        if (id === dbId.id) {
                            return {
                                ...accIntervals,
                                [id]: setInterval(() => {
                                    log('useFetch.store.@changed callback setInterval unsubscribe -> subscribe... 2',
                                        { id, changedKeys: Object.keys(changed) })
                                    unsubscribe(oldState)
                                    oldState.dbEnabled && changed.dbEnabled && subscribe(changed.db || oldState.db)
                                }, 2000)
                            }
                        } else {
                            log('useFetch.store.@changed callback setInterval skip. 2',
                                { id, changedKeys: Object.keys(changed) })
                        }
                        return accIntervals
                    }, {} as { [_: string]: NodeJS.Timer | undefined })
                }), {} as { [_: string]: NodeJS.Timer | undefined })
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
        const newValue = {
            ...(state[key] as { [_: string]: any }),
            [`${timestamp}`]: result
        }

        log('useFetch.request() 1', { result, newValue })

        dispatch('set', { [key]: newValue })

        getEnabledDbIdList(state).forEach(({ id }) => {
            dbPut(state, id, key, undefined, newValue)
        })
    }

    const clear = () => {
        log('useFetch.clear() 1')

        const newValue = Object.keys(state[key]).reduce((acc, k) => ({
            ...acc,
            [k]: null
        }), {})

        dispatch('set', { [key]: newValue })

        getEnabledDbIdList(state).forEach(({ id }) => {
            dbPut(state, id, key, undefined, newValue)
        })
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
