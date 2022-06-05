import * as algo_network from "../../algo_network"
import * as raw from "./raw"
import * as tictactoe_testnet from "../../tictactoe_testnet"
import * as tictactoe_pyteal from "../../tictactoe_pyteal"
import styles from './App.module.css'

const deploy = async () => {
  const client = algo_network.newClient(tictactoe_testnet.token, tictactoe_testnet.server, tictactoe_testnet.port)
  const output = await algo_network.deployApplication(
    client,
    tictactoe_testnet.accounts[0].address,
    tictactoe_testnet.accounts[0].privateKey,
    raw.applicationStartTeal,
    raw.clearProgramTeal,
    {
      numGlobalByteSlices: tictactoe_pyteal.numGlobalByteSlices,
      numGlobalInts: tictactoe_pyteal.numGlobalInts,
      numLocalByteSlices: 0,
      numLocalInts: 0
    }
  )

  console.log(output)
  return output
}

const App = () => {
  return (
    <div class={styles.App}>
      <button onClick={deploy}>Deploy</button>
    </div>
  )
}

export default App
