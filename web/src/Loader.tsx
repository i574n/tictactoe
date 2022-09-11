import { createEffect, createSignal, on } from "solid-js"
import { StoreonDispatch } from "storeon"
import { useStoreon } from "@storeon/solidjs"
import { BiRegularRefresh, BiRegularUndo, BiRegularUpArrow, BiRegularDownArrow } from "solid-icons/bi"
import { Box, Stack } from '@hope-ui/solid'


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

    if (props.defaults?.loaded) {
        props.onLoad?.(state, dispatch)
    }

    const buttonSize = "20px"

    return (
        <Box
            id={props.id}
            display="flex"
            flex={1}
        >
            {!loaded()
                ? <div>
                    <button onClick={loadClick}>Load</button>
                </div>
                : <Box
                    display="flex"
                    flex={1}
                    position={modal() ? 'absolute' : undefined}
                    zIndex={modal() ? 1 : undefined}
                    top={modal() ? 0 : undefined}
                    right={modal() ? 0 : undefined}
                    bottom={modal() ? 0 : undefined}
                    left={modal() ? 0 : undefined}
                    backgroundColor={modal() ? '$bg' : undefined}
                >
                    <Box
                        position="relative"
                        display="flex"
                        flex={1}
                    >
                        <Stack
                            direction="row"
                            spacing="4px"
                            position="absolute"
                            top="3px"
                            right="3px"
                        >
                            <button
                                onClick={() => setRefreshing(true)}
                            >
                                <BiRegularRefresh
                                    size={buttonSize}
                                />
                            </button>
                            <button
                                onClick={() => setModal(!modal())}
                            >
                                {modal()
                                    ? <BiRegularDownArrow
                                        size={buttonSize}
                                    />
                                    : <BiRegularUpArrow
                                        size={buttonSize}
                                    />}
                            </button>
                            <button
                                onClick={() => setLoaded(false)}
                            >
                                <BiRegularUndo
                                    size={buttonSize}
                                />
                            </button>
                        </Stack>
                        {!refreshing() && props.children}
                    </Box>
                </Box>
            }
        </Box>
    )
}
