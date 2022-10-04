import * as components_spi from "../../../lib_ts/components_spi"
import { ButtonProps } from "@hope-ui/solid"


function BaseButton(props: ButtonProps) {
    return <components_spi.v62 {...components_spi.v1.l0["create_obj_props"](Object.entries(props))} />
}

export default BaseButton
