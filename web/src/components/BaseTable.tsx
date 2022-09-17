import { TableProps } from "@hope-ui/solid"
import * as components_spi from "../../../lib_ts/components_spi"


function BaseTable(props: TableProps) {
    return <components_spi.v4 {...components_spi.v7(Object.entries(props))} />
}

export default BaseTable
