import './buffer-shim'
import { globalCss, HopeProvider } from '@hope-ui/solid'
import * as ui from "./ui"
import * as components_spi from "../../lib_ts/components_spi"


function Render(Component: any) {
    return (
        <Component.Component
            value={Component.value}
        >
            {Component.children}
        </Component.Component>
    )
}

function App() {
    globalCss(ui.globalCss)()

    return (
        <Render
            Component={components_spi.v1.l0["state_context"].Provider}
            value={components_spi.v1.l0["new_state_context_any"]()}
        >
            <HopeProvider
                config={ui.config}
            >
                <Render
                    Component={components_spi.v1.l0["db_listener"]}
                />
                <Render
                    Component={components_spi.v1.l0["content"]}
                />
            </HopeProvider>
        </Render>
    )
}

export default App
