import * as ui from "../ui"
import * as components_spi from "../../../lib_ts/components_spi"


function Loader<State extends ui.UiState>(props: {
    id?: string,
    onLoad?: (state: State, dispatch: (_: Partial<State>) => void) => void,
    defaults?: { loaded?: boolean, refreshing?: boolean, modal?: boolean }
    children: any
}) {
    return <components_spi.v80 {...components_spi.v1.l0["create_obj_props"](Object.entries({
        onLoad__: props?.onLoad,
        loaded__: props.defaults?.loaded,
        modal__: props.defaults?.modal
    }))} />
}

export default Loader
