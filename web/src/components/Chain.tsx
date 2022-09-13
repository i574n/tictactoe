import { hope } from '@hope-ui/solid'
import BaseTable from './BaseTable'
import ChainAccounts from './ChainAccounts'
import ChainConnection from './ChainConnection'
import Row from './Row'

function Chain() {
    return (
        <BaseTable>
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
                <hope.iframe
                    src="https://bank.testnet.algorand.network"
                    title="algorand testnet bank"
                    backgroundColor="#aaa"
                    height="350px"
                    flex={1}
                />
            </Row>
        </BaseTable>
    )
}

export default Chain
