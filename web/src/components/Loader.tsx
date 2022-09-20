import * as ui from "../ui"
import * as components_spi from "../../../lib_ts/components_spi"


function Loader<State extends ui.UiState>(props: {
    id?: string,
    onLoad?: (state: State, dispatch: (_: Partial<State>) => void) => void,
    defaults?: { loaded?: boolean, refreshing?: boolean, modal?: boolean }
    children: any
}) {
    return <components_spi.v25 {...components_spi.v13(Object.entries({
        _on_load: props?.onLoad,
        _loaded: props.defaults?.loaded,
        _modal: props.defaults?.modal
    }))} />
}

export default Loader
