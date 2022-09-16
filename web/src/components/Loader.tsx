import { createEffect, createSignal, on } from "solid-js"
import * as ui from "../ui"
import useStore from "../hooks/useStore"
import { BiRegularRefresh, BiRegularUndo, BiRegularUpArrow, BiRegularDownArrow } from "solid-icons/bi"
import { Box, Stack, IconButton } from '@hope-ui/solid'
import BaseButton from "./BaseButton"


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

    const buttonSize = "14px"

    return (
        <Box
            id={props.id}
            display="flex"
            flex={1}
        >
            {!loaded()
                ? <Box>
                    <BaseButton
                        onClick={loadClick}
                    >
                        Load
                    </BaseButton>
                </Box>
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
                            spacing="3px"
                            position="absolute"
                            top="6px"
                            right="6px"
                            zIndex={1}
                        >
                            <IconButton
                                aria-label="Refresh"
                                size="xs"
                                height="20px"
                                colorScheme="neutral"
                                onClick={() => setRefreshing(true)}
                                icon={<BiRegularRefresh
                                    size={buttonSize}
                                />}
                            />
                            <IconButton
                                aria-label={modal() ? 'Restore' : 'Maximize'}
                                size="xs"
                                height="20px"
                                colorScheme="neutral"
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
                                height="20px"
                                colorScheme="neutral"
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
