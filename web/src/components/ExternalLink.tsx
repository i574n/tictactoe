import * as components_spi from "../../../lib_ts/components_spi"


function ExternalLink(props: {
    href: string
}) {
    return <>{components_spi.v1(props.href)}</>
}

export default ExternalLink
