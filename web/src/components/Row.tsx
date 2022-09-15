import * as ui from "../ui"
import Loader from "./Loader"
import { createSignal, JSX } from "solid-js"
import { Checkbox, Tr, Td, Box, TdProps } from '@hope-ui/solid'


function Row<State extends ui.UiState>(
    { props: props_, ...props }: TdProps & {
        props?: {
            title?: JSX.Element,
            loader?: boolean,
            id?: string,
            onLoad?: (state: State, dispatch: (_: Partial<State>) => void) => void
        }
    }
) {
    const [checkedItems, setCheckedItems] = createSignal([props_?.loader !== false, false])
    return (
        <Tr
            id={props_?.id}
            display="flex"
            flex={1}
            border="1px solid $neutral5"
            flexDirection={{
                "@initial": "column",
                "@sm": "row"
            }}
        >
            {props_?.title || props.title && (
                <Td
                    border="0 !important"
                    color="$neutral9"
                    display="flex"
                    flexDirection="column"
                    fontSize="$sm"
                    outline="1px solid $neutral5"
                    padding="3px 20px 0 8px"
                >
                    {typeof props_?.loader !== 'boolean'
                        ? props_?.title || props.title
                        : <Checkbox
                            size="sm"
                            marginBottom="2px"
                            checked={checkedItems()[0]}
                            colorScheme="neutral"
                            onChange={(e: any) => setCheckedItems([e.target.checked, checkedItems()[1]])}
                        >
                            <Box
                                paddingTop="2px"
                            >
                                {props_?.title || props.title}
                            </Box>
                        </Checkbox>
                    }
                </Td>
            )}
            {props.children ? (
                <Td
                    border="0 !important"
                    outline="0"
                    margin="0"
                    padding="0"
                    display="flex"
                    flex={6}
                    flexDirection="column"
                    fontSize="$sm"
                    maxHeight="85vh"
                    overflowY="auto"
                    {...props}
                >
                    {typeof props_?.loader !== 'boolean'
                        ? props.children
                        : (
                            checkedItems()[0]
                                ? <Loader<State>
                                    onLoad={props_?.onLoad}
                                    defaults={{ loaded: true }}
                                >
                                    {props.children}
                                </Loader>
                                : <></>
                        )
                    }
                </Td>
            ) : (
                <Td
                    padding="0"
                    lineHeight="9px"
                >
                    &nbsp;
                </Td>
            )}
        </Tr>
    )
}

export default Row
