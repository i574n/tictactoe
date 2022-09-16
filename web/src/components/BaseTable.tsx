import { TableProps } from "@hope-ui/solid"
import * as components_spi from "../../../lib_ts/components_spi"


function BaseTable(props: TableProps) {
    return <components_spi.v4 {...{ l6: new components_spi.US7(1, [props.children]) } as components_spi.Heap0} />
}

export default BaseTable
