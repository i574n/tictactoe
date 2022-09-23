import * as chain from "../chain"
import StateInput from "./StateInput"
import { ChainAccount } from "../chain"


function ChainAccountInput<State extends chain.ChainState>(
    props: {
        key: keyof Omit<ChainAccount, 'alias'>,
        account: ChainAccount
    }) {
    return (
        <StateInput<ChainAccount[keyof ChainAccount], State>
            get={(_state) => props.account[props.key]}
            set={(state, value) => ({
                chainAccounts: state.chainAccounts.map((_account) =>
                    _account.alias === props.account.alias
                        ? { ..._account, [props.key]: value }
                        : _account
                )
            } as State)} />
    )
}

export default ChainAccountInput
