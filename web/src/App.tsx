import * as algo_network from "../../lib_ts/algo_network"
import * as tictactoe_pyteal from "../../lib_ts/tictactoe_pyteal"
import * as tictactoe_testnet from "../../lib_ts/tictactoe_testnet"
import * as util from "../../lib_ts/util"
import * as raw from "./raw"
import algosdk from "algosdk"
import { createEffect, createSignal, For, on, onCleanup } from "solid-js"
import { StoreonStore, createStoreon } from "storeon"
import { StoreonProvider, useStoreon } from "@storeon/solidjs"
import { BiRegularRefresh } from "solid-icons/bi"
import { Node as GunRS } from "rusty-gun"
import GunJS from "gun/gun"
import { IGunInstance as IGunJS } from "gun"
// @ts-ignore
import styles from "./App.module.css"


const soul = "app"
const CODESPACE_NAME = process.env.CODESPACE_NAME
const IS_TEST = Object.keys(window).filter((key) => key.startsWith("__playwright_snapshot_streamer")).length > 0

const init = {
    token: tictactoe_testnet.token,
    chainUrl: CODESPACE_NAME ? `http://${CODESPACE_NAME}-4001.githubpreview.dev` : tictactoe_testnet.url,
    chainPort: CODESPACE_NAME ? 80 : tictactoe_testnet.port,
    dbUrl: CODESPACE_NAME && !IS_TEST ? `ws://${CODESPACE_NAME}-18765.githubpreview.dev` : 'wss://localhost',
    dbPort: CODESPACE_NAME && !IS_TEST ? 80 : (IS_TEST ? 18765 : 8765),
    accounts: tictactoe_testnet.accounts,
    status: [] as any[],
    deploy: [] as any[],
    gunRs: {} as { [_: string]: GunRS },
    gunJs: {} as { [_: string]: IGunJS },
    counter: [] as number[]
}

type State = typeof init
type Account = typeof init.accounts[number]

type Events = {
    set: Partial<State>
}

const runId = Math.random().toString(36).substring(2, 5)

const getLog = (getLocals: () => object, argsColor = '#888') => {
    return (...args: any[]) => {
        console.log(
            `@${runId} %c%s %c%s`,
            `font-weight: bold; color: ${argsColor}`,
            JSON.stringify(args),
            'font-weight: bold; color: #444',
            JSON.stringify(getLocals())
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

function StateInput({ key }: { key: keyof util.PickByType<State, number | string> }) {
    const [state, dispatch] = useStoreon<State, Events>()

    return (
        <input type="text" value={state[key]} onInput={e => dispatch('set', { [key]: e.currentTarget.value })} />
    )
}

function ChainConnection() {
    return (
        <table>
            <tbody>
                <tr>
                    <td>Token</td>
                    <td><StateInput key="token" /></td>
                </tr>
                <tr>
                    <td>URL</td>
                    <td><StateInput key="chainUrl" /></td>
                </tr>
                <tr>
                    <td>Port</td>
                    <td><StateInput key="chainPort" /></td>
                </tr>
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

function Accounts() {
    const [state] = useStoreon<State, Events>()

    return (
        <table>
            <tbody>
                <For each={state.accounts}>
                    {(account) => (
                        <tr>
                            <td>{account.alias}</td>
                            <td>
                                <table>
                                    <tbody>
                                        <tr>
                                            <td>Address</td>
                                            <td><AccountInput account={account} key="address" /></td>
                                        </tr>
                                        <tr>
                                            <td>Private Key</td>
                                            <td><AccountInput account={account} key="privateKey" /></td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                    )}
                </For>
            </tbody>
        </table>
    )
}

function DbConnection() {
    return (
        <table>
            <tbody>
                <tr>
                    <td>URL</td>
                    <td><StateInput key="dbUrl" /></td>
                </tr>
                <tr>
                    <td>Port</td>
                    <td><StateInput key="dbPort" /></td>
                </tr>
            </tbody>
        </table>
    )
}

function GunListener() {
    const [state, dispatch] = useStoreon<State, Events>()

    const getLocals = () => {
        return {
            counter: state.counter,
            gunRs: Object.keys(state.gunRs).length,
            gunJs: Object.keys(state.gunJs).length
        }
    }

    const log = getLog(getLocals, '#cf1100')

    log('GunListener()')

    const gunJsEnabled = false

    const refresh = () => {
        const url = `${state.dbUrl}:${state.dbPort}/gun`
        const gunRs = ((state.gunRs as any)[url] as GunRS | null) || new GunRS(url)
        const gunJs = ((state.gunJs as any)[url] as IGunJS | null) || new GunJS(url)

        dispatch('set', {
            gunRs: { ...state.gunRs, [url]: gunRs },
            gunJs: gunJsEnabled ? { ...state.gunJs, [url]: gunJs } : state.gunJs
        })
    }

    let unbind = store.on('@changed', (_state, changed) => {
        log('GunListener.store.@changed', { changed: Object.keys(changed) })
        if (changed.dbUrl || changed.dbPort) {
            refresh()
        }
    })
    onCleanup(() => unbind())

    createEffect(on(
        () => [],
        () => {
            log('GunListener.createEffect() callback')
            refresh()
        }
    ))

    return <></>
}

function useFetch(key: keyof util.PickByType<State, any[]>, requestFn: ((_: algosdk.Algodv2) => Promise<any>)) {
    const [state, dispatch] = useStoreon<State, Events>()

    const [subscriptionRs, setSubscriptionRs] = createSignal({} as { [_: string]: number })
    const [subscriptionJs, setSubscriptionJs] = createSignal({} as { [_: string]: boolean })

    const getLocals = () => {
        return {
            key,
            [`state.${key}.length`]: state[key].length,
            // env: Object.keys(process.env),
            counter: state.counter,
            gunRs: Object.keys(state.gunRs).length,
            gunJs: Object.keys(state.gunJs).length,
            subscriptionRs: Object.values(subscriptionRs()),
            subscriptionJs: Object.keys(subscriptionJs()).length
        }
    }

    const defaultColors = Object.keys(init).reduce(
        (acc, x) => ({ ...acc, [x]: '#00cf2d' }),
        {} as { [key in keyof State]: string }
    )
    const colors = { ...defaultColors, status: '#cf6800', deploy: '#cccf00' }
    const log = getLog(getLocals, colors[key])

    log('useFetch()')

    let interval = null as NodeJS.Timer | null

    const subscribe = (gunRs: { [_: string]: GunRS }, gunJs: { [_: string]: IGunJS }) => {
        log('useFetch.subscribe()')

        const parse = (raw: object) => {
            let data = raw
            while (typeof data === 'string') {
                data = JSON.parse(data)
            }
            return Array.isArray(data) ? data : [data]
        }

        const subscriptionsRs = Object.entries(gunRs).map(([url, _gunRs]) => {
            const subscription = _gunRs.get(soul).get(key).on((v: any, k: any) => {
                interval && clearInterval(interval)

                const value = parse(v)
                log('useFetch.subscribe _gunRs.on() callback', { k, subscription, length: value.length })
                dispatch('set', { [key]: value })
            })
            log('useFetch.subscribe() gunRs', { subscription })
            return { url, subscription }
        })
        setSubscriptionRs({
            ...subscriptionRs(),
            ...subscriptionsRs.reduce((acc, { url, subscription }) => ({ ...acc, [url]: subscription }), {})
        })

        const subscriptionsJs = Object.entries(gunJs).map(([url, _gunJs]) => {
            _gunJs.get(soul).get(key).on((v: any, k: any) => {
                interval && clearInterval(interval)

                const value = parse(v)
                log('useFetch.subscribe _gunJs.on() callback', { k, length: value.length })
                dispatch('set', { [key]: value })
            })
            log('useFetch.subscribe() gunJs')
            return url
        })
        setSubscriptionJs({
            ...subscriptionJs(),
            ...subscriptionsJs.reduce((acc, url) => ({ ...acc, [url]: true }), {})
        })
    }

    const unsubscribe = (state: State) => {
        const _subscriptionRs = subscriptionRs()
        Object.entries(_subscriptionRs).forEach(([url, subscription]) => {
            log('useFetch.unsubscribe() subscriptionRs', { subscription })
            const _gunRs = (state.gunRs as any)[url] as GunRS | null
            _gunRs && _gunRs.get(soul).get(key).off(subscription)
        })
        setSubscriptionRs({})

        const _subscriptionJs = subscriptionJs()
        Object.entries(_subscriptionJs).forEach(([url, _]) => {
            log('useFetch.unsubscribe() subscriptionJs')
            const _gunJs = (state.gunJs as any)[url] as IGunJS | null
            _gunJs && _gunJs.get(soul).get(key).off()
        })
        setSubscriptionJs({})
    }

    let unbind = store.on('@changed', (oldState, changed) => {
        if (changed.gunRs || changed.gunJs) {
            log('useFetch.store.@changed', { changed: Object.keys(changed) })

            interval && clearInterval(interval)
            interval = setInterval(() => {
                log('useFetch.createEffect() callback setTimeout subscribe...')
                unsubscribe(oldState)
                subscribe(changed.gunRs, changed.gunJs)
            }, 2000)
        }
    })
    onCleanup(() => {
        unbind()
        unsubscribe(state)
    })

    const request = async () => {
        log('useFetch.request()')
        const client = algo_network.newClient(state.token, state.chainUrl, state.chainPort)
        let value: {}
        try {
            const result = await requestFn(client)
            value = [...state[key], result]
        } catch (e) {
            value = [...state[key], e]
        }

        dispatch('set', { [key]: value })

        Object.entries(state.gunRs).forEach(([_url, _gunRs]) => {
            log('useFetch.request() gunRs')
            _gunRs.get(soul).get(key).put(value)
        })

        Object.entries(state.gunJs).forEach(([_url, _gunJs]) => {
            log('useFetch.request() gunJs')
            _gunJs.get(soul).get(key).put(value)
        })
    }

    const clear = async () => {
        log('useFetch.clear()')

        dispatch('set', { [key]: [] })

        Object.entries(state.gunRs).forEach(([_url, _gunRs]) => {
            log('useFetch.clear() gunRs')
            _gunRs.get(soul).get(key).put([])
        })

        Object.entries(state.gunJs).forEach(([_url, _gunJs]) => {
            log('useFetch.clear() gunJs')
            _gunJs.get(soul).get(key).put([])
        })
    }

    return { request, clear }
}

function Counter() {
    const [state, _] = useStoreon<State, Events>()

    const { request, clear } = useFetch('counter', async (_client) => state.counter.length)

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


function IframeContainer({ url, title, height } = { url: 'URL', title: 'TITLE', height: '100vh' }) {
    const [loaded, setLoaded] = createSignal(false)
    const [refreshing, setRefreshing] = createSignal(false)

    createEffect(on(
        () => [refreshing()],
        () => refreshing() && setRefreshing(false)
    ))

    return (
        <>
            {!loaded()
                ? <div><button onClick={() => setLoaded(true)}>Load</button></div>
                : (
                    <div class={styles.IframeContainer}>
                        <button onClick={() => setRefreshing(true)}><BiRegularRefresh size="24px" /></button>
                        {!refreshing() &&
                            <iframe src={url} title={title} style={`height: ${height}`} />}
                    </div>
                )
            }
        </>
    )
}

function App() {
    return (
        <StoreonProvider store={store}>
            <GunListener />
            <table class={styles.App}>
                <tbody>
                    <tr>
                        <td>Links</td>
                        <td><Links /></td>
                    </tr>
                    <tr><td></td></tr>
                    <tr>
                        <td>Chain Connection</td>
                        <td><ChainConnection /></td>
                    </tr>
                    <tr>
                        <td>Accounts</td>
                        <td><Accounts /></td>
                    </tr>
                    <tr>
                        <td>Testnet Bank Dispenser</td>
                        <td>
                            <IframeContainer
                                url="https://bank.testnet.algorand.network"
                                title="algorand testnet bank"
                                height="350px" />
                        </td>
                    </tr>
                    <tr><td></td></tr>
                    <tr>
                        <td>Database Connection</td>
                        <td><DbConnection /></td>
                    </tr>
                    <tr><td></td></tr>
                    <tr>
                        <td>Counter</td>
                        <td><Counter /></td>
                    </tr>
                    <tr><td></td></tr>
                    <tr>
                        <td>Status</td>
                        <td><Status /></td>
                    </tr>
                    <tr>
                        <td>Deploy</td>
                        <td><Deploy /></td>
                    </tr>
                </tbody>
            </table>
        </StoreonProvider>
    )
}

const port = /[:-]([\d]{2,5})\D/.exec(location.href)?.[1] || '80'

function AppWrapper() {
    console.log({ location })

    return (
        <table class={styles.App}>
            <tbody>
                <tr>
                    <td>1</td>
                    <td>
                        <IframeContainer
                            url={location.origin.replace(port, '13701')}
                            title="Iframe 1"
                            height="60vh" />
                    </td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>
                        <IframeContainer
                            url={location.origin.replace(port, '13701')}
                            title="Iframe 2"
                            height="60vh" />
                    </td>
                </tr>
            </tbody>
        </table>
    )
}

export default port === '13700' ? AppWrapper : App
