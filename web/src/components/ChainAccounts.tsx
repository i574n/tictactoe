import Row from "./Row"
import * as chain from "../chain"
import { For } from "solid-js"
import { Table, Tbody } from '@hope-ui/solid'
import ChainAccountInput from "./ChainAccountInput"
import useStore from "../hooks/useStore"


function ChainAccounts<State extends chain.ChainState>() {
    const { state } = useStore<State>()

    return (
        <Table striped="odd">
            <Tbody>
                <For each={state.chainAccounts}>
                    {(account) => (
                        <Row title={account.alias}>
                            <Table striped="odd">
                                <Tbody>
                                    <Row title="Address">
                                        <ChainAccountInput account={account} key="address" />
                                    </Row>
                                    <Row title="Private Key">
                                        <ChainAccountInput account={account} key="privateKey" />
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

export default ChainAccounts
