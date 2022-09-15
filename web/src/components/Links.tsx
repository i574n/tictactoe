import BaseTable from "./BaseTable"
import Row from "./Row"
import ExternalLink from "./ExternalLink"

function Links() {
    return (
        <BaseTable>
            <Row
                padding="1px 6px"
            >
                <ExternalLink href="https://github.com/fc1943s/tictactoe_spiral" />
            </Row>
            <Row
                padding="1px 6px"
            >
                <ExternalLink href="https://fc1943s.github.io/tictactoe_spiral" />
            </Row>
            <Row
                padding="1px 6px"
            >
                <ExternalLink href="https://fc1943s.github.io/tictactoe_spiral/docs" />
            </Row>
        </BaseTable>
    )
}

export default Links
