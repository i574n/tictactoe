import Row from "./Row"
import * as db from "../db"
import DbConnectionInput from "./DbConnectionInput"
import BaseTable from "./BaseTable"


function DbConnection(props: { type: db.DbType }) {
    return (
        <BaseTable>
            <Row title="URL">
                <DbConnectionInput type={props.type} key="url" />
            </Row>
            <Row title="Port">
                <DbConnectionInput type={props.type} key="port" />
            </Row>
        </BaseTable>
    )
}

export default DbConnection
