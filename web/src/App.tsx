import './buffer-shim'
import { ColorModeScript, createGlobalStyles, extendTheme, HopeProvider } from '@hope-ui/core'
import * as ui from "./ui"
import * as components from "../../lib_ts/ui/components'"
import { Diff } from './diff/Diff'


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
            Component={components.v1.l0["state_context"].Provider}
            value={components.v1.l0["new_state_context_any"]()}
        >
            <ColorModeScript
                initialColorMode='system'
            />
            <HopeProvider
                initialColorMode='system'
                theme={theme}
            >
                <Render
                    Component={components.v1.l0["db_listener"]}
                />
                <Render
                    Component={components.v1.l0["content"]}
                />
                {/* <Diff /> */}
            </HopeProvider>
        </Render>
    )
}

export default App
