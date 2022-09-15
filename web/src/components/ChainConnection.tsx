import Row from "./Row"
import * as chain from "../chain"
import StateInput from "./StateInput"
import BaseTable from "./BaseTable"


function ChainConnection<State extends chain.ChainState>() {
    return (
        <BaseTable>
            <Row
                title="Token"
                padding="3px"
            >
                <StateInput<State['chainToken'], State>
                    get={(state) => state.chainToken}
                    set={(state, value) => ({ ...state, token: value })} />
            </Row>
            <Row
                title="URL"
                padding="3px"
            >
                <StateInput<State['chainUrl'], State>
                    get={(state) => state.chainUrl}
                    set={(state, value) => ({ ...state, chainUrl: value })} />
            </Row>
            <Row
                title="Port"
                padding="3px"
            >
                <StateInput<State['chainPort'], State>
                    get={(state) => state.chainPort}
                    set={(state, value) => ({ ...state, chainPort: value })} />
            </Row>
        </BaseTable>
    )
}

export default ChainConnection
