import { AnchorProps } from "@hope-ui/solid"
import * as components_spi from "../../../lib_ts/components_spi"


function ExternalLink(props: AnchorProps) {
    return <components_spi.v19 {...components_spi.v13(Object.entries(props))} />
}

export default ExternalLink
