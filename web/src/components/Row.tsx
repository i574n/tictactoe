import * as ui from "../ui"
import Loader from "./Loader"
import { createSignal, JSX } from "solid-js"
import { Checkbox, Tr, Td, Box, TdProps } from '@hope-ui/solid'


function Row<State extends ui.UiState>(
    props: {
        title?: string | JSX.Element,
        children?: any,
        loader?: boolean,
        id?: string,
        tdProps?: TdProps,
        onLoad?: (state: State, dispatch: (_: Partial<State>) => void) => void
    }
) {
    const [checkedItems, setCheckedItems] = createSignal([props.loader !== false, false])
    return (
        <Tr
            id={props.id}
            display="flex"
            flex={props.children && 1}
            border="1px solid $neutral5"
            flexDirection={{
                "@initial": "column",
                "@sm": "row"
            }}
        >
            {props.title && (
                <Td
                    border="0 !important"
                    color="$neutral9"
                    display="flex"
                    flexDirection="column"
                    fontSize="$sm"
                    outline="1px solid $neutral5"
                    padding="3px 20px 0 8px"
                >
                    {typeof props.loader !== 'boolean'
                        ? props.title
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
                                {props.title}
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
                    {...props.tdProps}
                >
                    {typeof props.loader !== 'boolean'
                        ? props.children
                        : (
                            checkedItems()[0]
                                ? <Loader<State>
                                    onLoad={props.onLoad}
                                    defaults={{ loaded: true }}
                                >
                                    {props.children}
                                </Loader>
                                : <>&nbsp;</>
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
