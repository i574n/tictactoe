import './buffer-shim'
import * as store from "./store"
import { StoreonProvider } from "@storeon/solidjs"
import { globalCss, HopeProvider } from '@hope-ui/solid'
import DbListener from './components/DbListener'
import Content from './components/Content'
import * as ui from "./ui"


function App() {
    globalCss(ui.globalCss)()

    return (
        <StoreonProvider
            store={store.store}
        >
            <HopeProvider
                config={ui.config}
            >
                <DbListener />
                <Content />
            </HopeProvider>
        </StoreonProvider>
    )
}

export default App
