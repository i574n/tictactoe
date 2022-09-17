import { AnchorProps } from "@hope-ui/solid"
import * as components_spi from "../../../lib_ts/components_spi"


function ExternalLink(props: AnchorProps) {
    return <components_spi.v10 {...components_spi.v7(Object.entries(props))} />
}

export default ExternalLink
