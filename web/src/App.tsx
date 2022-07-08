import * as algo_network from "../../lib_ts/algo_network"
import * as raw from "./raw"
import * as tictactoe_testnet from "../../lib_ts/tictactoe_testnet"
import * as tictactoe_pyteal from "../../lib_ts/tictactoe_pyteal"
import * as util from "../../lib_ts/util"
import { StoreonProvider, useStoreon } from "@storeon/solidjs"
import { StoreonStore, createStoreon } from "storeon"
import { createEffect, createSignal, For, on, onCleanup } from "solid-js"
import { BiRefresh } from "solid-icons/bi"
import { Node as Gun } from "rusty-gun"
// @ts-ignore
import styles from "./App.module.css"

const CODESPACE_NAME = process.env.CODESPACE_NAME

const init = {
    token: tictactoe_testnet.token,
    chainUrl: CODESPACE_NAME ? `http://${CODESPACE_NAME}-4001.githubpreview.dev` : tictactoe_testnet.url,
    chainPort: CODESPACE_NAME ? 80 : tictactoe_testnet.port,
    dbUrl: CODESPACE_NAME ? `ws://${CODESPACE_NAME}-8765.githubpreview.dev` : 'ws://localhost',
    dbPort: CODESPACE_NAME ? 80 : 8765,
    accounts: tictactoe_testnet.accounts,
    status: {},
    deploy: {}
}

type State = typeof init
type Account = typeof init.accounts[number]

type Events = {
    set: Partial<State>
}

const store = createStoreon([(store: StoreonStore<State, Events>) => {
    store.on('@init', () => init)
    store.on('set', (_, state) => state)
}])

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

function Game() {
    const [state, dispatch] = useStoreon<State, Events>()

    const deploy = async () => {
        const address = state.accounts[0]?.address
        const privateKey = state.accounts[0]?.privateKey
        if (address && privateKey) {
            const client = algo_network.newClient(state.token, state.chainUrl, state.chainPort)
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

                dispatch('set', { deploy: output })
            } catch (e) {
                dispatch('set', { deploy: e as {} })
            }
        } else {
            alert('Invalid admin account')
        }
    }

    return (
        <div>
            <div>Deploy:</div>
            <pre>{JSON.stringify(state.deploy, null, 2)}</pre>
            <button onClick={deploy}>Deploy</button>
        </div>
    )
}

function Status() {
    const [state, dispatch] = useStoreon<State, Events>()

    const [gun, setGun] = createSignal(null as Gun | null)

    const [subscription, setSubscription] = createSignal(-1)

    createEffect(on(
        () => [],
        () => {
            console.log(`${state.dbUrl}:${state.dbPort}/gun`)
            const _gun = new Gun(`${state.dbUrl}:${state.dbPort}/gun`)
            setGun(_gun)

            setTimeout(() => {
                _gun && setSubscription(
                    _gun.get("app").get("status").on((v: any, k: any) => {
                        dispatch('set', { status: JSON.parse(v) })
                    })
                )
            }, 1000)
        }
    ))

    onCleanup(() => {
        const _gun = gun()
        _gun && _gun.get("app").get("status").off(subscription())
    })

    const request = async () => {
        const client = algo_network.newClient(state.token, state.chainUrl, state.chainPort)
        const _gun = gun()
        try {
            const status = await client.status().do()
            dispatch('set', { status })

            _gun && _gun.get("app").get("status").put(status)
        } catch (e) {
            dispatch('set', { status: e as {} })

            _gun && _gun.get("app").get("status").put(e)
        }
    }

    return (
        <div>
            <pre>{JSON.stringify(state.status, null, 2)}</pre>
            <button onClick={request}>Request</button>
        </div>
    )
}

function TestnetBankContainer() {
    const [refreshing, setRefreshing] = createSignal(false)

    createEffect(on(
        () => [refreshing()],
        () => refreshing() && setRefreshing(false)
    ))

    return (
        <div class={styles.TestnetBankContainer}>
            <button onClick={() => setRefreshing(true)}><BiRefresh size="24px" /></button>
            {!refreshing() &&
                <iframe src="https://bank.testnet.algorand.network" title="algorand testnet bank" width="320" height="700" />}
        </div>
    )
}

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
            </tbody>
        </table>
    )
}

function App() {
    return (
        <StoreonProvider store={store}>
            <div class={styles.App}>
                <table>
                    <tbody>
                        <tr>
                            <td>Chain Connection</td>
                            <td><ChainConnection /></td>
                        </tr>
                        <tr>
                            <td>Database Connection</td>
                            <td><DbConnection /></td>
                        </tr>
                        <tr>
                            <td>Accounts</td>
                            <td><Accounts /></td>
                        </tr>
                        <tr>
                            <td>Status</td>
                            <td><Status /></td>
                        </tr>
                        <tr>
                            <td>Game</td>
                            <td><Game /></td>
                        </tr>
                        <tr>
                            <td>Testnet Bank Dispenser</td>
                            <td><TestnetBankContainer /></td>
                        </tr>
                        <tr>
                            <td>Links</td>
                            <td><Links /></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </StoreonProvider>
    )
}

export default App
