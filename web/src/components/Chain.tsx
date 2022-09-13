import { Table, Tbody } from '@hope-ui/solid'
import ChainAccounts from './ChainAccounts'
import ChainConnection from './ChainConnection'
import Row from './Row'

function Chain() {
    return (
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
    )
}

export default Chain
