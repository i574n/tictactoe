import * as components_spi from "../../../lib_ts/components_spi"
import { ButtonProps } from "@hope-ui/solid"


function BaseButton(props: ButtonProps) {
    return <components_spi.v1 {...{ l6: new components_spi.US7(1, [props.children]) } as components_spi.Heap0} />
}

export default BaseButton
