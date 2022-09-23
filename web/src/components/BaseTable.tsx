import { TableProps } from "@hope-ui/solid"
import * as components_spi from "../../../lib_ts/components_spi"


function BaseTable(props: TableProps) {
    props = new Proxy(props, {
        get: (target, phrase) => {
            if (phrase === "children") {
                return () => (target as any)[phrase]
            }
            return (target as any)[phrase]
        }
    })
    return <components_spi.v10 {...components_spi.v13(Object.entries(props))} />
}

export default BaseTable
