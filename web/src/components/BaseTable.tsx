import { TableProps, Table, Tbody } from "@hope-ui/solid"

function BaseTable(props: TableProps) {
    return (
        <Table
            display="flex"
            flex={1}
            flexDirection="column"
            striped="odd"
            {...props}
        >
            <Tbody
                display="flex"
                flexDirection="column"
            >
                {props.children}
            </Tbody>
        </Table>
    )
}

export default BaseTable
