import './buffer-shim'
import { StoreonProvider } from "@storeon/solidjs"
import { globalCss, HopeProvider } from '@hope-ui/solid'
import * as ui from "./ui"
import * as components_spi from "../../lib_ts/components_spi"
import { ErrorBoundary } from 'solid-js'


function Render(Component: any, props = {}) {
    return <Component.Component {...props} />
}

function App() {
    globalCss(ui.globalCss)()

    return (
        <ErrorBoundary
            fallback={err => {
                console.error(err)
                return `ErrorBoundary: ${err}`
            }}
        >
            <StoreonProvider
                store={components_spi.v1.l0["store"]}
            >
                <HopeProvider
                    config={ui.config}
                >
                    <Render Component={components_spi.v1.l0["db_listener"]} />
                    <Render Component={components_spi.v1.l0["content"]} />
                </HopeProvider>
            </StoreonProvider>
        </ErrorBoundary>
    )
}

export default App
