import * as db from "../db"
import * as store from "../store"
import * as profile from "../profile"
import * as algo_network from "../../../lib_ts/algo_network"
import * as tictactoe_pyteal from "../../../lib_ts/tictactoe_pyteal"
import * as raw from "../raw"
import { Stack, Button } from "@hope-ui/solid"
import useFetch from "../hooks/useFetch"
import useStore from "../hooks/useStore"
import BaseButton from "./BaseButton"


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
        } as Partial<State>),
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
        <div id="deploy">
            <Stack direction="row" spacing="4px">
                <BaseButton
                    onClick={request}
                >
                    Request
                </BaseButton>
                <BaseButton
                    onClick={clear}
                >
                    Clear
                </BaseButton>
            </Stack>
            <pre>{JSON.stringify(db.lastObjectEntry(state.profile.tmp.chainDeploy), null, 2)}</pre>
        </div>
    )
}

export default ChainDeploy
