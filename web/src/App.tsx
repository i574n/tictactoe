import * as algo_network from "../../algo_network"
import * as raw from "./raw"
import * as tictactoe_testnet from "../../tictactoe_testnet"
import * as tictactoe_pyteal from "../../tictactoe_pyteal"
import * as util from "../../util"
import styles from "./App.module.css"
import { StoreonProvider, useStoreon } from "@storeon/solidjs"
import { StoreonStore, createStoreon } from "storeon"
import { createEffect, createSignal, For, on } from "solid-js"
import { BiRefresh } from "solid-icons/bi"

const init = {
  token: tictactoe_testnet.token,
  server: tictactoe_testnet.server,
  port: tictactoe_testnet.port,
  accounts: tictactoe_testnet.accounts,
  status: {},
  deploy: {}
}

type State = typeof init
type Account = typeof init.accounts[number]

type Events = {
  set: Partial<State>
}

export const store = createStoreon([(store: StoreonStore<State, Events>) => {
  store.on('@init', () => init)
  store.on('set', (_, state) => state)
}])

export function StateInput({ key }: { key: keyof util.PickByType<State, number | string> }) {
  const [state, dispatch] = useStoreon<State, Events>()

  return (
    <input type="text" value={state[key]} onInput={e => dispatch('set', { [key]: e.currentTarget.value })} />
  )
}

export function Connection() {
  const [_, dispatch] = useStoreon<State, Events>()

  createEffect(on(
    () => [],
    () => {
      if (process.env.CODESPACE_NAME) {
        dispatch('set', {
          server: `http://${process.env.CODESPACE_NAME}-4001.githubpreview.dev`,
          port: 80
        })
      }
    }
  ))

  return (
    <table>
      <tbody>
        <tr>
          <td>Token</td>
          <td><StateInput key="token" /></td>
        </tr>
        <tr>
          <td>Server</td>
          <td><StateInput key="server" /></td>
        </tr>
        <tr>
          <td>Port</td>
          <td><StateInput key="port" /></td>
        </tr>
      </tbody>
    </table>
  )
}

export function AccountInput({ key, account }: { key: keyof Account, account: Account }) {
  const [state, dispatch] = useStoreon<State, Events>()

  return (
    <input
      type="text"
      value={account[key]}
      onInput={e => dispatch('set', {
        accounts:
          state.accounts.map(
            (_account) =>
              _account[key] === account[key]
                ? { ..._account, [key]: e.currentTarget.value }
                : _account
          )
      })}
    />
  )
}

export function Accounts() {
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

const Game = () => {
  const [state, dispatch] = useStoreon<State, Events>()

  const deploy = async () => {
    const address = state.accounts[0]?.address
    const privateKey = state.accounts[0]?.privateKey
    if (address && privateKey) {
      const client = algo_network.newClient(state.token, state.server, state.port)
      try {
        const output = await algo_network.deployApplication(
          client,
          address,
          privateKey,
          raw.applicationStartTeal,
          raw.clearProgramTeal,
          {
            numGlobalByteSlices: tictactoe_pyteal.numGlobalByteSlices,
            numGlobalInts: tictactoe_pyteal.numGlobalInts,
            numLocalByteSlices: 0,
            numLocalInts: 0
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

const Status = () => {
  const [state, dispatch] = useStoreon<State, Events>()

  const request = async () => {
    const client = algo_network.newClient(state.token, state.server, state.port)
    try {
      const status = await client.status().do()
      dispatch('set', { status })
    } catch (e) {
      dispatch('set', { status: e as {} })
    }
  }

  return (
    <div>
      <pre>{JSON.stringify(state.status, null, 2)}</pre>
      <button onClick={request}>Request</button>
    </div>
  )
}

const TestnetBankContainer = () => {
  const [refreshing, setRefreshing] = createSignal(false)

  createEffect(on(
    () => [refreshing()],
    () => refreshing() && setRefreshing(false)
  ))

  return (
    <div class={styles.TestnetBankContainer}>
      <button onClick={() => setRefreshing(true)}><BiRefresh size="24px" /></button>
      {!refreshing() &&
        <iframe src="https://bank.testnet.algorand.network" title="algorand testnet bank" width="320" height="280" />}
    </div>
  )
}

const App = () => {
  return (
    <StoreonProvider store={store}>
      <div class={styles.App}>
        <table>
          <tbody>
            <tr>
              <td>Connection</td>
              <td><Connection /></td>
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
          </tbody>
        </table>
      </div>
    </StoreonProvider>
  )
}

export default App
