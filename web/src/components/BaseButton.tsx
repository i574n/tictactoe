import * as components_spi from "../../../lib_ts/components_spi"
import { ButtonProps } from "@hope-ui/solid"


function BaseButton(props: ButtonProps) {
    return <components_spi.v7 {...components_spi.v13(Object.entries(props))} />
}

export default BaseButton
