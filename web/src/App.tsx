import './buffer-shim'
import * as raw from "./raw"
import * as util from "../../lib_ts/util"
import * as tictactoe_pyteal from "../../lib_ts/tictactoe_pyteal"
import * as algo_network from "../../lib_ts/algo_network"
import * as tictactoe_testnet from "../../lib_ts/tictactoe_testnet"
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


type NoneEmptyArray = readonly any[] & { 0: any }
type CompareUnionWithArray<P, Q extends NoneEmptyArray> = Exclude<P, Q[number]> extends never
    ? (Exclude<Q[number], P> extends never ? Q : ReadonlyArray<P>)
    : readonly [...Q, Exclude<P, Q[number]>]
export function assertTypeEquals<P, Q extends NoneEmptyArray>(_test: CompareUnionWithArray<P, Q>): void { }


const soul = "app"
const CODESPACE_NAME = process.env.CODESPACE_NAME
const IS_TEST = !!process.env.IS_TEST

const GUN_TYPE = ['rs', 'js'] as const

type Gun =
    | { type: 'rs', gun: GunRS }
    | { type: 'js', gun: IGunJS }
type GunType = Gun["type"]
assertTypeEquals<GunType, typeof GUN_TYPE>(GUN_TYPE)

type GunSubscription =
    | { type: 'rs', subscription: number }
    | { type: 'js', subscription: boolean }
type GunSubscriptionType = GunSubscription["type"]
assertTypeEquals<GunSubscriptionType, typeof GUN_TYPE>(GUN_TYPE)


type GunModel = { [K in GunType]: { rs?: GunRS, js?: IGunJS }[K] }

type GunSubscriptionModel = { [K in GunType]: { rs?: number, js?: boolean }[K] }

type Url = { url: string }

const newGun = (type: GunType, { url }: Url): Gun | null => {
    if (type === 'rs') {
        return { type, gun: new GunRS(url) }
    } else if (type === 'js') {
        return { type, gun: true ? null as unknown as IGunJS<any> : new GunJS(url) }
    }
    return null
}

const init = {
    token: tictactoe_testnet.token,
    chainUrl: CODESPACE_NAME ? `http://${CODESPACE_NAME}-4001.githubpreview.dev` : tictactoe_testnet.url,
    chainPort: CODESPACE_NAME ? 80 : tictactoe_testnet.port,
    dbUrl: CODESPACE_NAME && !IS_TEST ? `ws://${CODESPACE_NAME}-18765.githubpreview.dev` : 'wss://localhost',
    dbPort: CODESPACE_NAME && !IS_TEST ? 80 : (IS_TEST ? 18765 : 8765),
    accounts: tictactoe_testnet.accounts,
    status: [] as any[],
    deploy: [] as any[],
    gun: {} as { [_: string]: Gun[] },
    counter: [] as number[]
}

type State = typeof init
type Account = typeof init.accounts[number]

type Events = {
    set: Partial<State>
}

const runId = Math.random().toString(36).substring(2, 5)

const getStateLocals = (state: State) => {
    return {
        counter: state.counter,
        gun: Object.entries(state.gun)
            .map(([_url, gunList]) =>
                gunList
                    .map(({ type, gun }) => gun ? type : null)
                    .filter(type => type))
    }
}

const getLog =
    (getLocals: () => object, argsColor = '#888') =>
        (...args: any[]) => {
            IS_TEST
                ? console.log(
                    `@${runId}`,
                    JSON.stringify(args),
                    JSON.stringify(getLocals())
                )
                : console.log(
                    `@${runId} %c%s %c%s`,
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

function StateInput({ key }: { key: keyof util.PickByType<State, number | string> }) {
    const [state, dispatch] = useStoreon<State, Events>()

    return (
        <input type="text" value={state[key]} onInput={e => dispatch('set', { [key]: e.currentTarget.value })} />
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
                    <StateInput key="token" />
                </Row>
                <Row title="URL">
                    <StateInput key="chainUrl" />
                </Row>
                <Row title="Port">
                    <StateInput key="chainPort" />
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

function Accounts() {
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

function DbConnection() {
    return (
        <table>
            <tbody>
                <Row title="URL">
                    <StateInput key="dbUrl" />
                </Row>
                <Row title="Port">
                    <StateInput key="dbPort" />
                </Row>
            </tbody>
        </table>
    )
}

function GunListener() {
    const [state, dispatch] = useStoreon<State, Events>()

    const getLocals = () => ({
        ...getStateLocals(state)
    })

    const log = getLog(getLocals, '#cf1100')

    log('GunListener()')

    const refresh = () => {
        const currentUrl = `${state.dbUrl}:${state.dbPort}/gun`

        const gun = Object.entries({
            ...state.gun,
            [currentUrl]: state.gun[currentUrl] || []
        }).reduce((accGun, [url, gunList]) => ({
            ...accGun,
            [url]:
                Object.entries(
                    [
                        ...GUN_TYPE.map(type => ({ type, gun: null })),
                        ...gunList
                    ].reduce((accGunModel, { type, gun }) => ({
                        ...accGunModel,
                        [type]: gun || accGunModel[type] || newGun(type, { url })?.gun
                    }), {} as GunModel)
                ).reduce((accGunList, [type, gun]) => [
                    ...accGunList,
                    { type, gun } as Gun
                ], [] as Gun[])
        }), {} as typeof state.gun)

        dispatch('set', { gun })
    }

    const unbind = store.on('@changed', (_state, changed) => {
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

    const [subscriptions, setSubscriptions] = createSignal({} as { [_: string]: GunSubscription[] })

    const getLocals = () => ({
        ...getStateLocals(state),
        key,
        [`state.${key}.length`]: state[key].length,
        subscriptions: Object.entries(subscriptions())
            .map(([_url, subscription]) =>
                Object.entries(subscription)
                    .map(([type, value]) =>
                        !!value ? type : null)
                    .filter(type => type))
    })

    const defaultColors = Object.keys(init).reduce(
        (acc, x) => ({ ...acc, [x]: '#00cf2d' }),
        {} as { [key in keyof State]: string }
    )
    const colors = { ...defaultColors, status: '#cf6800', deploy: '#cccf00' }
    const log = getLog(getLocals, colors[key])

    log('useFetch()')

    let interval = null as NodeJS.Timer | null

    const subscribe = (gun: { [_: string]: Gun[] }) => {
        log('useFetch.subscribe()')

        const parse = (raw: object) => {
            let data = raw
            while (typeof data === 'string') {
                data = JSON.parse(data)
            }
            return Array.isArray(data) ? data : [data]
        }

        const currentSubscriptions = subscriptions()

        const newSubscriptions = Object.entries(gun).reduce((accGun, [url, gunList]) => ({
            ...accGun,
            [url]: gunList.reduce((accGunModel, { type, gun }) => {
                if (gun) {
                    const currentSubscriptionModel = currentSubscriptions[url] || ([] as GunSubscription[])
                    if (type === 'rs') {
                        const currentSubscription = currentSubscriptionModel
                            .find(({ type: subscriptionType }) => subscriptionType === type)?.subscription as number
                        const node = gun.get(soul).get(key)
                        if (currentSubscription) {
                            log('useFetch.subscribe rs unsubscribe')
                            node.off(currentSubscription)
                        }
                        const subscription = node.on((v: any, k: any) => {
                            interval && clearInterval(interval)

                            const value = parse(v)
                            log('useFetch.subscribe node.on() rs callback', { k, subscription, length: value.length })
                            dispatch('set', { [key]: value })
                        })
                        log('useFetch.subscribe() gunRs', { subscription })
                        return { ...accGunModel, [type]: subscription }
                    } else if (type === 'js') {
                        const currentSubscription = currentSubscriptionModel
                            .find(({ type: subscriptionType }) => subscriptionType === type)?.subscription as boolean
                        const node = (gun as IGunJS<any>).get(soul).get(key)
                        if (currentSubscription) {
                            log('useFetch.subscribe js unsubscribe')
                            node.off()
                        }
                        node.on((v: any, k: any) => {
                            interval && clearInterval(interval)

                            const value = parse(v)
                            log('useFetch.subscribe node.on() js callback', { k, length: value.length })
                            dispatch('set', { [key]: value })
                        })
                        log('useFetch.subscribe() gunJs')
                        return { ...accGunModel, [type]: true }
                    }
                }

                return accGunModel
            }, accGun[url])
        }), currentSubscriptions)
        setSubscriptions(newSubscriptions)
    }

    const unsubscribe = (state: State) => {
        log('useFetch.unsubscribe()')

        const currentSubscriptions = subscriptions()

        Object.entries(currentSubscriptions).forEach(([url, subscriptionList]) => {
            subscriptionList.forEach(({ type: subscriptionType, subscription }) => {
                const gun = state.gun[url].find(({ type }) => type === subscriptionType)
                if (gun) {
                    if (subscriptionType === 'rs') {
                        const node = (gun.gun as GunRS).get(soul).get(key)
                        log('useFetch.unsubscribe rs', { subscription })
                        node.off(subscription)
                    } else if (subscriptionType === 'js' && subscription) {
                        const node = (gun.gun as IGunJS).get(soul).get(key)
                        log('useFetch.unsubscribe js', { subscription })
                        node.off()
                    }
                }
            })
        })

        setSubscriptions({})
    }

    const unbind = store.on('@changed', (oldState, changed) => {
        if (changed.gun) {
            log('useFetch.store.@changed', { changed: Object.keys(changed) })

            interval && clearInterval(interval)
            interval = setInterval(() => {
                log('useFetch.createEffect() callback setTimeout subscribe...')
                unsubscribe(oldState)
                subscribe(changed.gun)
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

        Object.entries(state.gun).forEach(([_url, gunList]) => {
            gunList.forEach(({ type, gun }) => {
                log('useFetch.request()')
                if (gun) {
                    if (type === 'rs') {
                        const node = gun.get(soul).get(key) as GunRS
                        node.put(value)
                    } else if (type === 'js') {
                        const node = (gun as IGunJS).get(soul).get(key)
                        node.put(value)
                    }
                }
            })
        })
    }

    const clear = async () => {
        log('useFetch.clear()')

        dispatch('set', { [key]: [] })

        Object.entries(state.gun).forEach(([_url, gunList]) => {
            gunList.forEach(({ type, gun }) => {
                log('useFetch.clear()')
                if (gun) {
                    if (type === 'rs') {
                        const node = gun.get(soul).get(key) as GunRS
                        node.put([])
                    } else if (type === 'js') {
                        const node = (gun as IGunJS).get(soul).get(key)
                        node.put([])
                    }
                }
            })
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
                    <Row title="Links">
                        <Links />
                    </Row>
                    <tr><td></td></tr>
                    <Row title="Chain Connection">
                        <ChainConnection />
                    </Row>
                    <Row title="Accounts">
                        <Accounts />
                    </Row>
                    <Row title="Testnet Bank Dispenser">
                        <IframeContainer
                            url="https://bank.testnet.algorand.network"
                            title="algorand testnet bank"
                            height="350px" />
                    </Row>
                    <tr><td></td></tr>
                    <Row title="Database Connection">
                        <DbConnection />
                    </Row>
                    <tr><td></td></tr>
                    <Row title="Counter">
                        <Counter />
                    </Row>
                    <tr><td></td></tr>
                    <Row title="Status">
                        <Status />
                    </Row>
                    <Row title="Deploy">
                        <Deploy />
                    </Row>
                </tbody>
            </table>
        </StoreonProvider>
    )
}

export default App
