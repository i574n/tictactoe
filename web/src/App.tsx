import './buffer-shim'
import * as db from "./db"
import * as raw from "./raw"
import * as util from "../../lib_ts/util"
import * as tictactoe_pyteal from "../../lib_ts/tictactoe_pyteal"
import * as algo_network from "../../lib_ts/algo_network"
import * as tictactoe_testnet from "../../lib_ts/tictactoe_testnet"
import algosdk from "algosdk"
import { createSignal, For, onCleanup } from "solid-js"
import { StoreonStore, createStoreon } from "storeon"
import { StoreonProvider, useStoreon } from "@storeon/solidjs"
import { Diff } from "./diff/Diff"
import { Loader } from "./Loader"
// @ts-ignore
import styles from "./App.module.css"


const init = {
    token: tictactoe_testnet.token,
    chainUrl: util.CODESPACE_NAME ? `http://${util.CODESPACE_NAME}-4001.githubpreview.dev` : tictactoe_testnet.url,
    chainPort: util.CODESPACE_NAME ? 80 : tictactoe_testnet.port,
    db: {} as { [_: string]: db.Db },
    dbEnabled: {
        gun_rs: {
            gun_rs: false,
            gun_js: false
        } as { [_ in db.DbType]: boolean },
        gun_js: {
            gun_rs: false,
            gun_js: false
        } as { [_ in db.DbType]: boolean }
    } as { [_ in db.DbType]: { [_ in db.DbType]: boolean } },
    dbConnection: {
        gun_rs: {
            url: util.CODESPACE_NAME && !util.IS_TEST ? `ws://${util.CODESPACE_NAME}-4944.githubpreview.dev` : 'ws://localhost',
            port: util.CODESPACE_NAME && !util.IS_TEST ? 80 : (util.IS_TEST ? 14944 : 4944),
            ws: "ws"
        },
        gun_js: {
            url: util.CODESPACE_NAME && !util.IS_TEST ? `ws://${util.CODESPACE_NAME}-8765.githubpreview.dev` : 'wss://localhost',
            port: util.CODESPACE_NAME && !util.IS_TEST ? 80 : (util.IS_TEST ? 18765 : 8765),
            ws: "gun"
        }
    } as { [_ in db.DbType]: { url: string, port: number, ws: string } },
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

function StateInput(props: { get: (state: State) => any, set: (state: State, value: any) => State }) {
    const [state, dispatch] = useStoreon<State, Events>()

    return (
        <input
            type="text"
            value={props.get(state)}
            onInput={(e: { currentTarget: { value: any } }) =>
                dispatch('set', props.set(state, e.currentTarget.value))} />
    )
}

function Row(props: { title: string, children: any }) {
    return (
        <tr>
            <td>{props.title}</td>
            <td>{props.children}</td>
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

function AccountInput(props: { key: keyof Omit<Account, 'alias'>, account: Account }) {
    return (
        <StateInput
            get={(_state) => props.account[props.key]}
            set={(state, value) => ({
                ...state,
                accounts:
                    state.accounts.map(
                        (_account) =>
                            _account.alias === props.account.alias
                                ? { ..._account, [props.key]: value }
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

function DbConnectionInput(props: { type: db.DbType, key: keyof typeof init.dbConnection[db.DbType] }) {
    return (
        <StateInput
            get={(state) => state.dbConnection[props.type][props.key]}
            set={(state, value) => ({
                ...state,
                dbConnection: {
                    ...state.dbConnection,
                    [props.type]: {
                        ...state.dbConnection[props.type],
                        [props.key]: value
                    }
                }
            })} />
    )
}

function DbConnection(props: { type: db.DbType }) {
    return (
        <table>
            <tbody>
                <Row title="URL">
                    <DbConnectionInput type={props.type} key="url" />
                </Row>
                <Row title="Port">
                    <DbConnectionInput type={props.type} key="port" />
                </Row>
            </tbody>
        </table>
    )
}

function DbListener() {
    const [state, dispatch] = useStoreon<State, Events>()

    const getLocals = () => ({ ...getStateLocals(state) })
    const log = util.getLog(getLocals, '#cf1100')

    log('DbListener() 0')

    const refresh = () => {
        const newDb = db.getDbIdList(state)[0].reduce((accDb, { dbType, url, id }) => ({
            ...accDb,
            [id]: accDb[id] || db.newDb(dbType, { url })
        }), state.db)

        log('DbListener refresh() 1', { newDb })

        dispatch('set', { db: newDb })
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

export function useFetch(
    key: keyof util.PickByType<State, { [_: number]: any } | undefined>,
    requestFn: ((_: algosdk.Algodv2) => Promise<any>)
) {
    const [state, dispatch] = useStoreon<State, Events>()

    const [subscriptions, setSubscriptions] = createSignal({} as { [_: string]: db.DbSubscription })

    const [events, setEvents] = createSignal({} as { [_: string]: { off: () => void } | undefined })
    const [timers, setTimers] = createSignal({} as { [_: string]: NodeJS.Timer | undefined })
    const [values, setValues] = createSignal({} as { [_: string]: any })

    const getLocals = () => ({
        key,
        [`${String(key)}.keys`]: Object.keys(state[key] || {}),
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

    // const randomHexColorString = () => "#" + Math.floor(Math.random() * 16777215).toString(16)

    const generateSixDigitNumericHashFromString = (text: string) =>
        [...text].map((c) => c.charCodeAt(0)).reduce((acc, x) => acc + (x * 10), 100000).toString().substring(-6)

    const log = util.getLog(getLocals, `#${generateSixDigitNumericHashFromString(key as string)}`)

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

                // const newDispatch = dispatch as any as ((event: keyof E, value: any) => void)
                dispatch('set', { [key]: newValue })

                const oldValues = values()
                const newValueJson = JSON.stringify(newValue)

                log('useFetch.onValue() 2/2. before put loop', { newValue })

                if (newValueJson !== JSON.stringify(oldValues[id])) {
                    setValues({ ...oldValues, [id]: newValue })

                    db.getDbIdList(state)[0].forEach((dbId) => {
                        if (id !== dbId.id && newValueJson !== JSON.stringify(oldValues[dbId.id])) {
                            log('useFetch.onValue() 3/2. before put item', { id: dbId.id })

                            db.dbPut(state, dbId.id, key, undefined, newValue)
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
            db.dbOff(state, id, key, undefined, subscription)
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

    const subscribe = (id: db.Id) => {
        const oldSubscriptions = subscriptions()
        const oldSubscription = oldSubscriptions[id.id]
        log('useFetch.subscribe() 1', { oldSubscription })

        if (!oldSubscription && state.dbEnabled) {
            const newSubscription = db.dbOn(state, id, key, undefined, newOnValue(resub))
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
                db.getDbIdList(newState)[0].reduce((accIntervals, id) =>
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

        const timestamp = util.newTimestamp()
        const newValue = {
            ...(state[key] as { [_: string]: any }),
            [`${timestamp}`]: result
        }

        log('useFetch.request() 1', { result, newValue })

        // dispatch('set', { [key]: newValue })

        db.getDbIdList(state)[0].forEach(({ id }) => {
            log('useFetch.request() 1 before dbPut', { id })

            db.dbPut(state, id, key, undefined, newValue)
        })

        Object.values(timers()).forEach((timer) => timer && clearTimeout(timer))
        setTimers(
            db.getDbIdList(state)[0].reduce((accIntervals, id) =>
            ({
                ...accIntervals,
                [id.id]: setTimeout(() => {
                    const oldSubscriptions = subscriptions()
                    const oldSubscription = oldSubscriptions[id.id]

                    log('useFetch.request() 1 resub timeout', { id: id.id, oldSubscription })

                    if (oldSubscription) {
                        db.dbOff(state, id.id, key, undefined, oldSubscription.subscription)
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

        db.getDbIdList(state)[0].forEach(({ id }) => {
            log('useFetch.clear() 1 before dbPut', { id })

            db.dbPut(state, id, key, undefined, newValue)
        })

        Object.values(timers()).forEach((timer) => timer && clearTimeout(timer))
        setTimers(
            db.getDbIdList(state)[0].reduce((accIntervals, id) =>
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
                        <Loader<State, Events>
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
                        <Loader<State, Events>
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
                        <Loader<State, Events>
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
                        <Loader<State, Events>
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
                    {!!util.env.GITHUB_RUN_ID
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
                    <Row title="Diff">
                        <Diff />
                    </Row>
                </tbody>
            </table>
        </StoreonProvider>
    )
}

export default App
