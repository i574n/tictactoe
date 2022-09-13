import Row from "./Row"
import * as db from "../db"
import { Table, Tbody } from '@hope-ui/solid'
import DbConnectionInput from "./DbConnectionInput"


function DbConnection(props: { type: db.DbType }) {
    return (
        <Table striped="odd">
            <Tbody>
                <Row title="URL">
                    <DbConnectionInput type={props.type} key="url" />
                </Row>
                <Row title="Port">
                    <DbConnectionInput type={props.type} key="port" />
                </Row>
            </Tbody>
        </Table>
    )
}

export default DbConnection
