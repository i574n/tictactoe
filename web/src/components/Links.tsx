import BaseTable from "./BaseTable"
import Row from "./Row"


function Links() {
    return (
        <BaseTable>
            <Row
                tdProps={{
                    padding: '1px 6px'
                }}
            >
                <a target="_blank" href="https://github.com/fc1943s/tictactoe_spiral">
                    https://github.com/fc1943s/tictactoe_spiral
                </a>
            </Row>
            <Row
                tdProps={{
                    padding: '1px 6px'
                }}
            >
                <a target="_blank" href="https://fc1943s.github.io/tictactoe_spiral">
                    https://fc1943s.github.io/tictactoe_spiral
                </a>
            </Row>
            <Row
                tdProps={{
                    padding: '1px 6px'
                }}
            >
                <a target="_blank" href="https://fc1943s.github.io/tictactoe_spiral/docs">
                    https://fc1943s.github.io/tictactoe_spiral/docs
                </a>
            </Row>
        </BaseTable>
    )
}

export default Links
