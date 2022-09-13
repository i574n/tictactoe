import * as ui from "../ui"
import Loader from "./Loader"
import { createSignal } from "solid-js"
import { Checkbox, Tr, Td, Box, TdProps } from '@hope-ui/solid'


function Row<State extends ui.UiState>(
    props: {
        title?: string,
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
            display="inline-flex"
            flexDirection={{
                "@initial": "column",
                "@sm": "row"
            }}
        >
            {props.title && (
                <Td
                    display="flex"
                    color="$neutral9"
                    flexDirection="column"
                    padding="3px 20px 0px 8px"
                    outline="1px solid #777"
                    fontSize="$sm"
                >
                    {typeof props.loader !== 'boolean'
                        ? props.title
                        : (
                            <Checkbox
                                size="sm"
                                padding="0"
                                marginBottom="4px"
                                colorScheme="neutral"
                                checked={checkedItems()[0]}
                                onChange={(e: any) => setCheckedItems([e.target.checked, checkedItems()[1]])}
                            >
                                <Box
                                    paddingTop="2px"
                                >
                                    {props.title}
                                </Box>
                            </Checkbox>
                        )}
                </Td>
            )}
            <Td
                display="flex"
                flexDirection="column"
                outline="1px solid #777"
                padding="2px"
                flex={6}
                fontSize="$sm"
                lineHeight={!props.children ? "6px" : undefined}
                maxHeight="85vh"
                overflow={props.children && "auto"}
                {...props.tdProps}
            >
                {typeof props.loader !== 'boolean'
                    ? props.children || <>&nbsp;</>
                    : (checkedItems()[0] &&
                        <Loader<State>
                            onLoad={props.onLoad}
                            defaults={{ loaded: true }}
                        >
                            {props.children}
                        </Loader>
                    )}
            </Td>
        </Tr>
    )
}

export default Row
