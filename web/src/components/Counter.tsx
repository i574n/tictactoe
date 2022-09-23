import * as store from "../store"
import useStore from "../hooks/useStore"
import { Stack, Box } from '@hope-ui/solid'
import useFetch from "../hooks/useFetch"
import { Index } from "solid-js"
import Row from "./Row"
import BaseButton from "./BaseButton"
import BaseTable from "./BaseTable"
import { BiRegularPlus, BiRegularMinus } from "solid-icons/bi"


function Counter<State extends store.State>() {
    const { state } = useStore<State>()

    const { request, clear } = useFetch<typeof state.profile.tmp.counter, State>(
        { contentAddress: `profile/tmp/counter` },
        state.profile.tmp.counter,
        (state, newValue) => ({
            profile: {
                ...state.profile,
                tmp: {
                    ...state.profile.tmp,
                    counter: newValue
                }
            }
        } as State),
        async (_client) => Object.values(state.profile.tmp.counter || {}).reduce((acc, v) => v === null ? 0 : acc + 1, 0)
    )

    return (
        <Row
            props={{
                id: "counter",
                title:
                    <Stack
                        alignItems="start"
                        direction={{
                            "@initial": "row",
                            "@sm": "column"
                        }}
                        marginBottom={{
                            "@initial": "0",
                            "@sm": "8px"
                        }}
                        spacing="7px"
                        padding="3px"
                    >
                        <Box>Counter</Box>
                        <BaseButton
                            leftIcon={<BiRegularPlus />}
                            paddingRight="10px"
                            onClick={request}
                        >
                            Request
                        </BaseButton>
                        <BaseButton
                            leftIcon={<BiRegularMinus />}
                            paddingRight="10px"
                            onClick={clear}
                        >
                            Clear
                        </BaseButton>
                    </Stack>
            }}
        >
            <BaseTable>
                <Index each={Object.entries(state.profile.tmp.counter || {}).reverse()}>
                    {(item) => (
                        <Row
                            title={item()[0]}
                            padding="3px"
                        >
                            <pre>{JSON.stringify(item()[1], null, 2)}</pre>
                        </Row>
                    )}
                </Index>
            </BaseTable>
        </Row>
    )
}

export default Counter