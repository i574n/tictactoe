import * as store from "../store"
import useStore from "../hooks/useStore"
import { Box, Stack } from '@hope-ui/solid'
import useFetch from "../hooks/useFetch"
import BaseButton from "./BaseButton"
import { BiRegularPlus, BiRegularMinus } from "solid-icons/bi"
import { Index } from "solid-js"
import BaseTable from "./BaseTable"
import Row from "./Row"


function ChainStatus<State extends store.State>() {
    const { state } = useStore<State>()

    const { request, clear } = useFetch<typeof state.profile.tmp.chainStatus, State>(
        { contentAddress: `profile/tmp/chainStatus` },
        state.profile.tmp.chainStatus || {},
        (state, newValue) => ({
            profile: {
                ...state.profile,
                tmp: {
                    ...state.profile.tmp,
                    chainStatus: newValue
                }
            }
        } as Partial<State>),
        (client) => client.status().do()
    )

    return (
        <Row
            props={{
                id: "status",
                title:
                    <Stack
                        alignItems="start"
                        direction="column"
                        spacing="6px"
                        padding="3px"
                    >
                        <Box>Chain Status</Box>
                        <BaseButton
                            leftIcon={<BiRegularPlus />}
                            onClick={request}
                        >
                            Request
                        </BaseButton>
                        <BaseButton
                            leftIcon={<BiRegularMinus />}
                            onClick={clear}
                        >
                            Clear
                        </BaseButton>
                    </Stack>
            }}
        >
            <BaseTable>
                <Index each={Object.entries(state.profile.tmp.chainStatus || {}).reverse()}>
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

export default ChainStatus
