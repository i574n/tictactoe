import { createEffect, createSignal, on } from "solid-js"
import * as ui from "../ui"
import useStore from "../hooks/useStore"
import { BiRegularRefresh, BiRegularUndo, BiRegularUpArrow, BiRegularDownArrow } from "solid-icons/bi"
import { Box, Stack, IconButton, Button } from '@hope-ui/solid'


function Loader<State extends ui.UiState>(props: {
    id?: string,
    onLoad?: (state: State, dispatch: (_: Partial<State>) => void) => void,
    defaults?: { loaded?: boolean, refreshing?: boolean, modal?: boolean }
    children: any
}) {
    const { state, dispatch } = useStore<State>()

    const loaderId = Math.random().toString(36)

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
                    <Button onClick={loadClick}>Load</Button>
                </div>
                : <Box
                    display="flex"
                    flex={1}
                    zIndex={modal() ? 1 : undefined}
                    position={modal() ? 'absolute' : undefined}
                    top={modal() ? 0 : undefined}
                    right={modal() ? 0 : undefined}
                    bottom={modal() ? 0 : undefined}
                    left={modal() ? 0 : undefined}
                    backgroundColor={modal() ? '$bg' : undefined}
                >
                    <Box
                        flex={1}
                        display="flex"
                        position={!state.ui.modal ? 'relative' : undefined}
                    >
                        <Stack
                            display={state.ui.modal && state.ui.modal !== loaderId ? 'none' : undefined}
                            direction="row"
                            spacing="4px"
                            position="absolute"
                            top="3px"
                            right="3px"
                            zIndex={1}
                        >
                            <IconButton
                                aria-label="Refresh"
                                size="xs"
                                onClick={() => setRefreshing(true)}
                                icon={<BiRegularRefresh
                                    size={buttonSize}
                                />}
                            />
                            <IconButton
                                aria-label={modal() ? 'Restore' : 'Maximize'}
                                size="xs"
                                onClick={() => {
                                    const newModal = !modal()
                                    setModal(newModal)
                                    dispatch({
                                        ui: {
                                            ...state.ui,
                                            modal: newModal ? loaderId : undefined
                                        }
                                    } as Partial<State>)
                                }}
                                icon={modal()
                                    ? <BiRegularDownArrow
                                        size={buttonSize}
                                    />
                                    : <BiRegularUpArrow
                                        size={buttonSize}
                                    />}
                            />
                            <IconButton
                                aria-label="Unload"
                                size="xs"
                                onClick={() => setLoaded(false)}
                                icon={<BiRegularUndo
                                    size={buttonSize}
                                />}
                            />
                        </Stack>

                        {!refreshing() && props.children}
                    </Box>
                </Box>
            }
        </Box>
    )
}

export default Loader
