import * as ui from "../ui"
import * as components_spi from "../../../lib_ts/components_spi"


function Loader<State extends ui.UiState>(props: {
    id?: string,
    onLoad?: (state: State, dispatch: (_: Partial<State>) => void) => void,
    defaults?: { loaded?: boolean, refreshing?: boolean, modal?: boolean }
    children: any
}) {
    return <components_spi.v16
        {...[
            props.defaults?.loaded || false,
            props.defaults?.modal || false,
            new components_spi.US10(1, props.onLoad),
            components_spi.v7(Object.entries(props))
        ]} />
}

export default Loader
