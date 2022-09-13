import * as ui from "../ui"
import Loader from "./Loader"
import { createSignal } from "solid-js"
import { Checkbox, Tr, Td, Box } from '@hope-ui/solid'


function Row<State extends ui.UiState>(
    props: {
        title?: string,
        children?: any,
        loader?: boolean,
        id?: string,
        onLoad?: (state: State, dispatch: (_: Partial<State>) => void) => void
    }
) {
    const [checkedItems, setCheckedItems] = createSignal([props.loader !== false, false])
    return (
        <Tr
            id={props.id}
            display="flex"
            // verticalAlign="top"
            flexDirection={{
                "@initial": "column",
                "@sm": "row"
            }}
        >
            {props.title && (
                <Td
                    display="flex"
                    flexDirection="column"
                    padding="2px 5px"
                    outline="1px solid #777"
                    flex={1}
                    fontSize="$sm"
                >
                    {typeof props.loader !== 'boolean'
                        ? props.title
                        : (
                            <Checkbox
                                size="sm"
                                checked={checkedItems()[0]}
                                onChange={(e: any) => setCheckedItems([e.target.checked, checkedItems()[1]])}
                            >
                                <Box
                                    marginTop="2px"
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
                padding="2px"
                outline="1px solid #777"
                flex={5}
                fontSize="$sm"

                lineHeight={!props.children ? "6px" : undefined}
                maxHeight="85vh"
                overflow={props.children && "auto"}
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
