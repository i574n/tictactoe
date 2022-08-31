import { createEffect, createSignal, on } from "solid-js"
import { StoreonDispatch } from "storeon"
import { useStoreon } from "@storeon/solidjs"
import { BiRegularRefresh } from "solid-icons/bi"
// @ts-ignore
import styles from "./App.module.css"

export function Loader<State extends object, Events>({ id, onLoad, children }: {
    id?: string,
    onLoad?: (state: State, dispatch: StoreonDispatch<Events>) => void,
    children: any
}) {
    const [state, dispatch] = useStoreon<State, Events>()

    const [loaded, setLoaded] = createSignal(false)
    const [refreshing, setRefreshing] = createSignal(false)

    createEffect(on(
        () => [refreshing()],
        () => refreshing() && setRefreshing(false)
    ))

    const loadClick = () => {
        onLoad?.(state, dispatch)
        setLoaded(true)
    }

    return (
        <div id={id}>
            {!loaded()
                ? <div><button onClick={loadClick}>Load</button></div>
                : (
                    <div class={styles.IframeContainer}>
                        <button onClick={() => setRefreshing(true)}><BiRegularRefresh size="24px" /></button>
                        {!refreshing() && children}
                    </div>
                )
            }
        </div>
    )
}
