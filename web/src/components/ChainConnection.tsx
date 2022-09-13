import Row from "./Row"
import * as chain from "../chain"
import { Table, Tbody } from '@hope-ui/solid'
import StateInput from "./StateInput"


function ChainConnection<
    State extends chain.ChainState,
    Events extends { set: Partial<State> }
>() {
    return (
        <Table striped="odd">
            <Tbody>
                <Row title="Token">
                    <StateInput<State['chainToken'], State, Events>
                        get={(state) => state.chainToken}
                        set={(state, value) => ({ ...state, token: value })} />
                </Row>
                <Row title="URL">
                    <StateInput<State['chainUrl'], State, Events>
                        get={(state) => state.chainUrl}
                        set={(state, value) => ({ ...state, chainUrl: value })} />
                </Row>
                <Row title="Port">
                    <StateInput<State['chainPort'], State, Events>
                        get={(state) => state.chainPort}
                        set={(state, value) => ({ ...state, chainPort: value })} />
                </Row>
            </Tbody>
        </Table>
    )
}

export default ChainConnection
