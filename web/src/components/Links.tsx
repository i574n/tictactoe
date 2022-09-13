import { Table, Tbody } from '@hope-ui/solid'
import Row from "./Row"


function Links() {
    return (
        <Table striped="odd">
            <Tbody>
                <Row>
                    <a target="_blank" href="https://github.com/fc1943s/tictactoe_spiral">
                        https://github.com/fc1943s/tictactoe_spiral
                    </a>
                </Row>
                <Row>
                    <a target="_blank" href="https://fc1943s.github.io/tictactoe_spiral">
                        https://fc1943s.github.io/tictactoe_spiral
                    </a>
                </Row>
                <Row>
                    <a target="_blank" href="https://fc1943s.github.io/tictactoe_spiral/docs">
                        https://fc1943s.github.io/tictactoe_spiral/docs
                    </a>
                </Row>
            </Tbody>
        </Table>
    )
}

export default Links
