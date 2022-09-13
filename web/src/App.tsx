import './buffer-shim'
import * as db from "./db"
import * as raw from "./raw"
import * as util from "../../lib_ts/util"
import * as tictactoe_pyteal from "../../lib_ts/tictactoe_pyteal"
import * as algo_network from "../../lib_ts/algo_network"
import * as tictactoe_testnet from "../../lib_ts/tictactoe_testnet"
import algosdk from "algosdk"
import { createSignal, For, onCleanup } from "solid-js"
import { StoreonStore, createStoreon, StoreonDispatch } from "storeon"
import { StoreonProvider, useStoreon } from "@storeon/solidjs"
import { globalCss, HopeProvider, HopeThemeConfig, Table, Tbody, Checkbox, Tr, Td, Stack, Button,
    Input } from '@hope-ui/solid'
import { Diff } from "./diff/Diff"
import { Loader } from "./Loader"
// @ts-ignore
import styles from "./App.module.css"

type ChainState = {
    chainToken: string
    chainUrl: string
    chainPort: number
    chainAccounts: {
        alias: string
        privateKey: string
        address: string
        mnemonic: string
    }[]
}

type State = db.DbState & ChainState & {
    ui: {
        modal?: string
    }
    profile: {
        tmp: {
            counter?: { [_: string]: number } | undefined
            chainStatus?: { [_: string]: any } | undefined
            chainDeploy?: { [_: string]: any } | undefined
        }
    }
}

const init: State = {
    chainToken: tictactoe_testnet.token,
    chainUrl: util.CODESPACE_NAME ? `http://${util.CODESPACE_NAME}-4001.githubpreview.dev` : tictactoe_testnet.url,
    chainPort: util.CODESPACE_NAME ? 80 : tictactoe_testnet.port,
    chainAccounts: tictactoe_testnet.accounts,
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
    },
    dbStatus: {
        gun_rs: {
            gun_rs: false,
            gun_js: false
        } as { [_ in db.DbType]: boolean },
        gun_js: {
            gun_rs: false,
            gun_js: false
        } as { [_ in db.DbType]: boolean }
    },
    dbRef: {},
    ui: {},
    profile: {
        tmp: {}
    }
}

type Account = typeof init.chainAccounts[number]

type Events = {
    set: Partial<State>
}


const getStateLocals = (state: State) => {
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

const store = createStoreon([(store: StoreonStore<State, Events>) => {
    store.on('@init', () => init)
    store.on('set', (_, state) => state)
}])


function StateInput(props: { get: (state: State) => any, set: (state: State, value: any) => State }) {
    const [state, dispatch] = useStoreon<State, Events>()

    return (
        <Input
            type="text"
            size="xs"
            value={props.get(state)}
            onInput={(e: { currentTarget: { value: any } }) =>
                dispatch('set', props.set(state, e.currentTarget.value))} />
    )
}

function Row(props: {
    title?: string,
    children: any,
    loader?: boolean,
    id?: string,
    onLoad?: (state: State, dispatch: StoreonDispatch<Events>) => void
}) {
    const [checkedItems, setCheckedItems] = createSignal([props.loader !== false, false])
    return (
        <Tr id={props.id}>
            {props.title && (
                <Td
                    display="flex"
                    flexDirection="column"
                >
                    {typeof props.loader !== 'boolean'
                        ? props.title
                        : (
                            <Checkbox
                                size="sm"
                                checked={checkedItems()[0]}
                                onChange={(e: any) => setCheckedItems([e.target.checked, checkedItems()[1]])}
                            >
                                {props.title}
                            </Checkbox>
                        )}
                </Td>
            )}
            <Td>
                {typeof props.loader !== 'boolean'
                    ? props.children
                    : (checkedItems()[0] &&
                        <Loader<State, Events>
                            onLoad={props.onLoad}
                            defaults={{ loaded: true }}
                        >
                            {props.children}
                        </Loader>
                    )}
            </Td>
        </Tr>
    )
}

function Links() {
    return (
        <Table striped="odd">
            <Tbody>
                <Row>
                    <a target="_blank" href="https://github.com/fc1943s/tictactoe_spiral">
                        https://github.com/fc1943s/tictactoe_spiral
                    </a>
                </Row>
                <Row>
                    <a target="_blank" href="https://fc1943s.github.io/tictactoe_spiral">
                        https://fc1943s.github.io/tictactoe_spiral
                    </a>
                </Row>
                <Row>
                    <a target="_blank" href="https://fc1943s.github.io/tictactoe_spiral/docs">
                        https://fc1943s.github.io/tictactoe_spiral/docs
                    </a>
                </Row>
            </Tbody>
        </Table>
    )
}

function Settings() {
    return (
        <Table striped="odd">
            <Tbody>
                <Row
                    title="Display"
                >
                    ??
                </Row>
            </Tbody>
        </Table>
    )
}

function ChainConnection() {
    return (
        <Table striped="odd">
            <Tbody>
                <Row title="Token">
                    <StateInput
                        get={(state) => state.chainToken}
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
            </Tbody>
        </Table>
    )
}

function AccountInput(props: { key: keyof Omit<Account, 'alias'>, account: Account }) {
    return (
        <StateInput
            get={(_state) => props.account[props.key]}
            set={(state, value) => ({
                ...state,
                accounts:
                    state.chainAccounts.map(
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
        <Table striped="odd">
            <Tbody>
                <For each={state.chainAccounts}>
                    {(account) => (
                        <Row title={account.alias}>
                            <Table striped="odd">
                                <Tbody>
                                    <Row title="Address">
                                        <AccountInput account={account} key="address" />
                                    </Row>
                                    <Row title="Private Key">
                                        <AccountInput account={account} key="privateKey" />
                                    </Row>
                                </Tbody>
                            </Table>
                        </Row>
                    )}
                </For>
            </Tbody>
        </Table>
    )
}

function DbConnectionInput(props: { type: db.DbType, key: keyof typeof init.dbConnection[db.DbType] }) {
    return (
        <StateInput
            get={(state) => state.dbConnection[props.type][props.key]}
            set={(state, value) => ({
                ...state,
                dbConnection: {
                    [props.type]: {
                        ...state.dbConnection[props.type],
                        [props.key]: value
                    }
                } as { [key in db.DbType]: typeof state.dbConnection[typeof props.type] }
            })} />
    )
}

function DbConnection(props: { type: db.DbType }) {
    return (
        <Table striped="odd">
            <Tbody>
                <Row title="URL">
                    <DbConnectionInput type={props.type} key="url" />
                </Row>
                <Row title="Port">
                    <DbConnectionInput type={props.type} key="port" />
                </Row>
            </Tbody>
        </Table>
    )
}

function DbListener() {
    const [state, dispatch] = useStoreon<State, Events>()

    const getLocals = () => ({ ...getStateLocals(state) })
    const log = util.getLog(getLocals, '#cf1100')

    log('DbListener() 0')

    const refresh = () => {
        const newDbRef = db.getDbIdList(state)[0].reduce((accDb, { dbType, url, id }) => ({
            ...accDb,
            [id]: accDb[id] || db.newDb(dbType, { url })
        }), state.dbRef)

        log('DbListener refresh() 1', { newDbRef })

        dispatch('set', { dbRef: newDbRef })
    }

    const unbind = store.on('@changed', (newState, changed, store) => {
        log('DbListener store.on(@changed) 1', {
            changed: Object.keys(changed).map((key) => ({
                key,
                state: db.objectValueCount(state[key as keyof State]),
                newState: db.objectValueCount(newState[key as keyof State]),
                changed: db.objectValueCount(changed[key as keyof State]),
                store: db.objectValueCount(store.get()[key as keyof State]),
            }))
        })
        if (changed.dbStatus || changed.dbConnection) {
            refresh()
        }
    })
    onCleanup(() => {
        unbind()
    })

    return <></>
}

export function useFetch<T extends db.Proxy>(
    contentAddress: db.ContentAddress,
    proxy: T,
    apply: (state: State, newValue: T) => Partial<State>,
    requestFn: ((_: algosdk.Algodv2) => Promise<any>)
) {
    const [state, dispatch] = useStoreon<State, Events>()

    const [subscriptions, setSubscriptions] = createSignal({} as { [_: string]: db.DbSubscription })

    const [events, setEvents] = createSignal({} as { [_: string]: { off: () => void } | undefined })
    const [timers, setTimers] = createSignal({} as { [_: string]: NodeJS.Timer | undefined })
    const [values, setValues] = createSignal({} as { [_: string]: T })

    const getLocals = () => ({
        contentAddress,
        [`proxy`]: db.objectValueCount(proxy),
        [`events`]: Object.entries(events()),
        [`timers`]: Object.entries(timers()),
        [`values`]: Object.entries(values()).reduce(
            ([keys, emptyKeys]: (string | any[])[][], [id, value]) =>
                !!value
                    ? [[...keys, [id, db.objectValueCount(value)]], emptyKeys]
                    : [keys, [...emptyKeys, id]],
            [[], []]),
        [`subscriptions`]: Object.entries(subscriptions()).map(([id, { subscription }]) => [id, subscription])
    })

    // const randomHexColorString = () => "#" + Math.floor(Math.random() * 16777215).toString(16)

    const generateSixDigitNumericHashFromString = (text: string) =>
        [...text].map((c) => c.charCodeAt(0)).reduce((acc, x) => acc + (x * 11), 100000).toString().substring(-6)

    const log = util.getLog(getLocals, `#${generateSixDigitNumericHashFromString(contentAddress.contentAddress)}`)

    log('useFetch() 0')

    const newOnValue = (resub: (_: string) => void) =>
        async (id: string, hash: string, newValue: T, rawValue: object | undefined) => {
            const logObj = {
                id,
                hash,
                newValue: db.objectValueCount(newValue),
                rawValue: db.objectValueCount(rawValue)
            }
            log('useFetch.onValue() 1/2', { ...logObj })

            if (hash && Object.keys(proxy || {}).length > 0) {
                log('useFetch.onValue() 2/2. resub (hash)', { ...logObj })

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

                // const newDispatch = dispatch as any as ((event: keyof Events, value: State) => void)
                dispatch('set', apply(state, newValue))

                const oldValues = values()
                const newValues = { ...oldValues, [id]: newValue }
                setValues(newValues)

                log('useFetch.onValue() 2/2. set', {
                    ...logObj,
                    oldValues: Object.entries(oldValues).map(([id, values]) =>
                        [id, db.objectValueCount(values)]
                    ),
                    newValues: Object.entries(newValues).map(([id, values]) =>
                        [id, db.objectValueCount(values)]
                    )
                })

                if (rawValue
                    && Object.keys(newValue || {}).length > 0
                    && JSON.stringify(oldValues[id]) !== JSON.stringify(newValue)) {
                    await Promise.all(
                        db.getDbIdList(state)[0]
                            .filter((dbId) => id !== dbId.id)
                            .map(async (dbId) => {
                                log('useFetch.onValue() 3/2. before put item ###', {
                                    ...logObj,
                                    dbId: dbId.id,
                                    lastSourceOld: db.lastObjectEntry(oldValues[id]),
                                    lastSource: db.lastObjectEntry(newValues[id]),
                                    lastTargetOld: db.lastObjectEntry(oldValues[dbId.id]),
                                    lastTarget: db.lastObjectEntry(newValues[dbId.id])
                                })
                                db.dbPut(state, dbId, contentAddress, rawValue)
                            })
                    )
                }
            }
        }

    const unsubscribe = () => {
        log('useFetch.unsubscribe() 1')

        Object.entries(subscriptions()).forEach(([id, { type, subscription }]) => {
            log('useFetch.unsubscribe 2 item', { id, type, subscription })
            db.dbOff(state, id, contentAddress, subscription)
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
            }, db.DB_RESUB_TIMEOUT)
        })
    }

    const subscribe = (id: db.Id) => {
        const oldSubscriptions = subscriptions()
        const oldSubscription = oldSubscriptions[id.id]
        log('useFetch.subscribe() 1', { oldSubscription })

        if (!oldSubscription && state.dbStatus) {
            const onValue = newOnValue(resub)
            const newSubscription = db.dbOn(state, proxy, id, contentAddress, onValue)
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
        if (changed.dbStatus || changed.dbRef) {
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
                    [id.id]: setTimeout(() => subscribe(id), db.DB_INIT_TIMEOUT)
                }), {} as { [_: string]: NodeJS.Timer | undefined })
            )
        }
    })
    onCleanup(() => {
        unbind()
        unsubscribe()
    })

    const request = async () => {
        const client = algo_network.newClient(state.chainToken, state.chainUrl, state.chainPort)
        let result: {}
        try {
            result = await requestFn(client)
        } catch (e) {
            result = e as {}
        }

        const enabledDbIdList = db.getDbIdList(state)[0]
        const timestamp = `${new Date().getTime()}`

        log('useFetch.request() 1', { result, timestamp, enabledDbIdList })

        if (enabledDbIdList.length === 0) {
            const newValue = {
                ...proxy,
                [timestamp]: result
            }
            dispatch('set', apply(state, newValue))
        } else {
            await Promise.all(
                enabledDbIdList.map((id) =>
                    db.dbPut(state, id, contentAddress, { [timestamp]: result })
                )
            )

            Object.values(timers()).forEach((timer) => timer && clearTimeout(timer))
            setTimers(
                enabledDbIdList.reduce((accIntervals, id) =>
                ({
                    ...accIntervals,
                    [id.id]: setTimeout(() => {
                        const oldSubscriptions = subscriptions()
                        const oldSubscription = oldSubscriptions[id.id]

                        log('useFetch.request() 1 resub timeout', { id: id.id, oldSubscription })

                        if (oldSubscription) {
                            db.dbOff(state, id.id, contentAddress, oldSubscription.subscription)
                        }
                        const newSubscriptions = { ...subscriptions() }
                        delete newSubscriptions[id.id]
                        setSubscriptions(newSubscriptions)

                        subscribe(id)
                    }, db.DB_RESUB_TIMEOUT)
                }), {} as { [_: string]: NodeJS.Timer | undefined })
            )
        }
    }

    const clear = async () => {
        const enabledDbIdList = db.getDbIdList(state)[0]
        const timestamp = `${new Date().getTime()}`

        log('useFetch.clear() 1', { timestamp, enabledDbIdList })

        if (enabledDbIdList.length === 0) {
            const newValue = {
                ...proxy,
                [timestamp]: null
            }
            dispatch('set', apply(state, newValue))
        } else {
            await Promise.all(
                enabledDbIdList.map((id) =>
                    db.dbPut(state, id, contentAddress, { [timestamp]: null })
                )
            )

            Object.values(timers()).forEach((timer) => timer && clearTimeout(timer))
            setTimers(
                enabledDbIdList.reduce((accIntervals, id) =>
                ({
                    ...accIntervals,
                    [id.id]: setTimeout(() => {
                        log('useFetch.clear() 1 resub timeout', { id: id.id })
                        subscribe(id)
                    }, db.DB_RESUB_TIMEOUT)
                }), {} as { [_: string]: NodeJS.Timer | undefined })
            )
        }
    }

    return { request, clear }
}

function Counter() {
    const [state, _] = useStoreon<State, Events>()

    const { request, clear } = useFetch(
        { contentAddress: `profile/tmp/counter` },
        state.profile.tmp.counter || {},
        (state, newValue) => ({
            profile: {
                ...state.profile,
                tmp: {
                    ...state.profile.tmp,
                    counter: newValue
                }
            }
        }),
        async (_client) => Object.values(state.profile.tmp.counter || {}).reduce((acc, v) => v === null ? 0 : acc + 1, 0)
    )

    return (
        <div id="counter">
            <Stack direction="row" spacing="4px">
                <Button size="xs" compact onClick={request}>Request</Button>
                <Button size="xs" compact onClick={clear}>Clear</Button>
            </Stack>
            <pre>{JSON.stringify(db.lastObjectEntry(state.profile.tmp.counter), null, 2)}</pre>
        </div>
    )
}

function Status() {
    const [state, _] = useStoreon<State, Events>()

    const { request, clear } = useFetch(
        { contentAddress: `profile/tmp/chainStatus` },
        state.profile.tmp.chainStatus || {},
        (state, newValue) => ({
            profile: {
                ...state.profile,
                tmp: {
                    ...state.profile.tmp,
                    chainStatus: newValue
                }
            }
        }),
        (client) => client.status().do()
    )

    return (
        <div id="status">
            <Stack direction="row" spacing="4px">
                <Button size="xs" compact onClick={request}>Request</Button>
                <Button size="xs" compact onClick={clear}>Clear</Button>
            </Stack>
            <pre>{JSON.stringify(db.lastObjectEntry(state.profile.tmp.chainStatus), null, 2)}</pre>
        </div>
    )
}

function Deploy() {
    const [state, _] = useStoreon<State, Events>()

    const { request, clear } = useFetch(
        { contentAddress: `profile/tmp/chainDeploy` },
        state.profile.tmp.chainDeploy || {},
        (state, newValue) => ({
            profile: {
                ...state.profile,
                tmp: {
                    ...state.profile.tmp,
                    chainDeploy: newValue
                }
            }
        }),
        async (client) => {
            const address = state.chainAccounts[0]?.address
            const privateKey = state.chainAccounts[0]?.privateKey
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
        }
    )

    return (
        <div id="deploy">
            <Stack direction="row" spacing="4px">
                <Button size="xs" compact onClick={request}>Request</Button>
                <Button size="xs" compact onClick={clear}>Clear</Button>
            </Stack>
            <pre>{JSON.stringify(db.lastObjectEntry(state.profile.tmp.chainDeploy), null, 2)}</pre>
        </div>
    )
}

function App() {
    globalCss({
        '*': {
          margin: 0,
          padding: 0
        },
        body: {
            margin: '1px 2px 1px 1px'
        }
      })

    const config: HopeThemeConfig = {
        initialColorMode: 'dark',
        darkTheme: {
            colors: {
                bg: "#1A1A1A"
            }
        }
    }
    return (
        <StoreonProvider
            store={store}
        >
            <HopeProvider
                config={config}
            >
                <DbListener />
                <Table
                    striped="odd"
                    class={styles.App}
                    display="flex"
                    overflow="auto"
                    flex={1}
                    maxWidth="100vw"
                    height="100vh"
                    margin="1px 2px 1px 1px"
                    padding="1px"
                    flexDirection="column"
                    backgroundColor="$bg"
                    color="#eeffff"
                >
                    <Tbody>
                        <Row
                            title="Links"
                        >
                            <Links />
                        </Row>
                        <Tr><Td></Td></Tr>
                        <Row
                            title="Settings"
                        >
                            <Settings />
                        </Row>
                        <Tr><Td></Td></Tr>
                        <Row
                            loader={false}
                            title="Chain"
                        >
                            <Table
                                striped="odd"
                            >
                                <Tbody>
                                    <Row
                                        title="Connection"
                                    >
                                        <ChainConnection />
                                    </Row>
                                    <Row
                                        title="Accounts"
                                    >
                                        <ChainAccounts />
                                    </Row>
                                    <Row
                                        loader={false}
                                        title="Testnet Bank Dispenser"
                                    >
                                        <iframe
                                            src="https://bank.testnet.algorand.network"
                                            title="algorand testnet bank"
                                            style={{
                                                height: '350px',
                                                'background-color': '#aaa',
                                                flex: 1
                                            }}
                                        />
                                    </Row>
                                </Tbody>
                            </Table>
                        </Row>
                        <Tr><Td></Td></Tr>
                        <Row
                            id="db"
                            loader={false}
                            title="Database"
                        >
                            <Table
                                striped="odd"
                            >
                                <Tbody>
                                    <Row
                                        id="db-gun-rs-rs"
                                        loader={false}
                                        onLoad={(state, dispatch) => {
                                            dispatch('set', {
                                                dbStatus: {
                                                    ...state.dbStatus,
                                                    gun_rs: {
                                                        ...state.dbStatus.gun_rs,
                                                        gun_rs: true
                                                    }
                                                }
                                            })
                                        }}
                                        title="Rust -> Rust"
                                    >
                                        <DbConnection
                                            type="gun_rs"
                                        />
                                    </Row>
                                    <Row
                                        id="db-gun-rs-js"
                                        loader={false}
                                        onLoad={(state, dispatch) => {
                                            dispatch('set', {
                                                dbStatus: {
                                                    ...state.dbStatus,
                                                    gun_rs: {
                                                        ...state.dbStatus.gun_rs,
                                                        gun_js: true
                                                    }
                                                }
                                            })
                                        }}
                                        title="Rust -> JavaScript"
                                    >
                                        <DbConnection
                                            type="gun_js"
                                        />
                                    </Row>
                                    <Row
                                        id="db-gun-js-js"
                                        loader={false}
                                        onLoad={(state, dispatch) => {
                                            dispatch('set', {
                                                dbStatus: {
                                                    ...state.dbStatus,
                                                    gun_js: {
                                                        ...state.dbStatus.gun_js,
                                                        gun_js: true
                                                    }
                                                }
                                            })
                                        }}
                                        title="JavaScript -> JavaScript"
                                    >
                                        <DbConnection
                                            type="gun_js"
                                        />
                                    </Row>
                                    <Row
                                        id="db-gun-js-rs"
                                        loader={false}
                                        onLoad={(state, dispatch) => {
                                            dispatch('set', {
                                                dbStatus: {
                                                    ...state.dbStatus,
                                                    gun_js: {
                                                        ...state.dbStatus.gun_js,
                                                        gun_rs: true
                                                    }
                                                }
                                            })
                                        }}
                                        title="JavaScript -> Rust"
                                    >
                                        <DbConnection
                                            type="gun_rs"
                                        />
                                    </Row>
                                </Tbody>
                            </Table>
                        </Row>
                        <Tr><Td></Td></Tr>
                        <Row
                            title="Counter"
                        >
                            <Counter />
                        </Row>
                        {!!util.env.GITHUB_RUN_ID
                            ? <>
                                <Row
                                    title="Status"
                                >
                                    <Status />
                                </Row>
                                <Row
                                    title="Deploy"
                                >
                                    <Deploy />
                                </Row>
                            </>
                            : <></>}
                        {/* {!util.IS_TEST && !util.env.GITHUB_RUN_ID
                            ? <>
                                <Tr><Td></Td></Tr>
                                <Row title="Diff">
                                    <Diff />
                                </Row>
                            </>
                            : <></>} */}
                    </Tbody>
                </Table>
            </HopeProvider>
        </StoreonProvider>
    )
}

export default App
