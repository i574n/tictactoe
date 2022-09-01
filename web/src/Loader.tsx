import { createEffect, createSignal, on } from "solid-js"
import { StoreonDispatch } from "storeon"
import { useStoreon } from "@storeon/solidjs"
import { BiRegularRefresh, BiRegularUndo, BiRegularUpArrow, BiRegularDownArrow } from "solid-icons/bi"
// @ts-ignore
import styles from "./App.module.css"

export function Loader<State extends object, Events>(props: {
    id?: string,
    onLoad?: (state: State, dispatch: StoreonDispatch<Events>) => void,
    defaults?: { loaded?: boolean, refreshing?: boolean, modal?: boolean }
    children: any
}) {
    const [state, dispatch] = useStoreon<State, Events>()

    const [loaded, setLoaded] = createSignal(props.defaults?.loaded)
    const [refreshing, setRefreshing] = createSignal(props.defaults?.refreshing)
    const [modal, setModal] = createSignal(props.defaults?.modal)

    createEffect(on(
        () => [refreshing()],
        () => refreshing() && setRefreshing(false)
    ))

    const loadClick = () => {
        props.onLoad?.(state, dispatch)
        setLoaded(true)
    }

    const buttonSize = "20px"

    return (
        <div id={props.id}>
            {!loaded()
                ? <div><button onClick={loadClick}>Load</button></div>
                : (
                    <div classList={{ [styles.Modal]: modal() }}>
                        <div class={styles.IframeContainer}>
                            <div class={styles.buttons}>
                                <button onClick={() => setRefreshing(true)}>
                                    <BiRegularRefresh size={buttonSize} />
                                </button>
                                <button onClick={() => setModal(!modal())}>
                                    {modal()
                                        ? <BiRegularDownArrow size={buttonSize} />
                                        : <BiRegularUpArrow size={buttonSize} />}
                                </button>
                                <button onClick={() => setLoaded(false)}>
                                    <BiRegularUndo size={buttonSize} />
                                </button>
                            </div>
                            {!refreshing() && props.children}
                        </div>
                    </div>
                )
            }
        </div>
    )
}
