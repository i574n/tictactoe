import './buffer-shim'
import { ColorModeScript, createGlobalStyles, extendTheme, HopeProvider } from '@hope-ui/core'
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

const useGlobalStyles = createGlobalStyles(ui.globalCss)
const theme = extendTheme({})

function App() {
    useGlobalStyles()
    return (
        <Render
            Component={components_spi.v1.l0["state_context"].Provider}
            value={components_spi.v1.l0["new_state_context_any"]()}
        >
            <ColorModeScript
                initialColorMode='system'
            />
            <HopeProvider
                initialColorMode='system'
                theme={theme}
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
