import * as ui from "../ui"
import { JSX } from "solid-js"
import { TdProps } from '@hope-ui/solid'
import * as components_spi from "../../../lib_ts/components_spi"


function Row<State extends ui.UiState>(
    { props: props_, ...props }: TdProps & {
        props?: {
            id?: string,
            loader?: boolean,
            title?: JSX.Element,
            onLoad?: (state: State, dispatch: (_: Partial<State>) => void) => void
        }
    }
) {
    return <components_spi.v83 {...components_spi.v1.l0["create_obj_props"](Object.entries({
        ...props,
        onLoad__: props_?.onLoad,
        id: props_?.id,
        status: props_?.loader,
        title: props_?.title || props.title
    }))} />
}

export default Row
