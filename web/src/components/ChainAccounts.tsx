import Row from "./Row"
import * as chain from "../chain"
import { For } from "solid-js"
import ChainAccountInput from "./ChainAccountInput"
import useStore from "../hooks/useStore"
import BaseTable from "./BaseTable"


function ChainAccounts<State extends chain.ChainState>() {
    const { state } = useStore<State>()

    return (
        <BaseTable>
            <For each={state.chainAccounts}>
                {(account) => (
                    <Row
                        title={account.alias}
                    >
                        <BaseTable>
                            <Row
                                title="Address"
                                padding="3px"
                            >
                                <ChainAccountInput
                                    account={account}
                                    key="address"
                                />
                            </Row>
                            <Row
                                title="Private Key"
                                padding="3px"
                            >
                                <ChainAccountInput
                                    account={account}
                                    key="privateKey"
                                />
                            </Row>
                        </BaseTable>
                    </Row>
                )}
            </For>
        </BaseTable>
    )
}

export default ChainAccounts
