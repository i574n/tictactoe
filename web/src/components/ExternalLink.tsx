import * as components_spi from "../../../lib_ts/components_spi"


function ExternalLink(props: {
    href: string
}) {
    return <components_spi.v7 {...{ l17: new components_spi.US7(1, [props.href]) } as components_spi.Heap0} />
}

export default ExternalLink
