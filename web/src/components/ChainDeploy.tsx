import * as store from "../store"
import * as algo_network from "../../../lib_ts/algo_network"
import * as tictactoe_pyteal from "../../../lib_ts/tictactoe_pyteal"
import * as raw from "../raw"
import { Stack, Box } from "@hope-ui/solid"
import useFetch from "../hooks/useFetch"
import useStore from "../hooks/useStore"
import BaseButton from "./BaseButton"
import { BiRegularPlus, BiRegularMinus } from "solid-icons/bi"
import { Index } from "solid-js"
import BaseTable from "./BaseTable"
import Row from "./Row"


function ChainDeploy<State extends store.State>() {
    const { state } = useStore<State>()

    const { request, clear } = useFetch<typeof state.profile.tmp.chainDeploy, State>(
        { contentAddress: `profile/tmp/chainDeploy` },
        state.profile.tmp.chainDeploy || {},
        (state, newValue) => ({
            profile: {
                ...state.profile,
                tmp: {
                    ...state.profile.tmp,
                    chainDeploy: newValue
                }
            }
        } as State),
        async (client) => {
            const address = state.chainAccounts[0]?.address
            const privateKey = state.chainAccounts[0]?.privateKey
            if (address && privateKey) {
                try {
                    const output = await algo_network.deployApplication(
                        client,
                        address,
                        privateKey,
                        raw.applicationStartTeal,
                        raw.clearProgramTeal,
                        {
                            numGlobalByteSlices: tictactoe_pyteal.numGlobalByteSlices,
                            numGlobalInts: tictactoe_pyteal.numGlobalInts
                        }
                    )

                    return output
                } catch (e) {
                    return e
                }
            } else {
                return 'Invalid admin account'
            }
        }
    )

    return (
        <Row
            props={{
                id: "deploy",
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
                        <Box>Chain Deploy</Box>
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
                <Index each={Object.entries(state.profile.tmp.chainDeploy || {}).reverse()}>
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

export default ChainDeploy