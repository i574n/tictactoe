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
    return <components_spi.v19
        {...[
            new components_spi.US10(props_?.onLoad ? 1 : 0, [props_?.onLoad]),
            components_spi.v7(Object.entries({
                ...props,
                id: props_?.id,
                status: props_?.loader,
                title: props_?.title || props.title
            }))
        ]} />
}

export default Row
