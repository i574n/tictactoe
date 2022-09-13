import * as db from "../db"
import * as store from "../store"
import useStore from "../hooks/useStore"
import { Button, Stack } from '@hope-ui/solid'
import useFetch from "../hooks/useFetch"


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
        <div id="status">
            <Stack direction="row" spacing="4px">
                <Button size="xs" compact onClick={request}>Request</Button>
                <Button size="xs" compact onClick={clear}>Clear</Button>
            </Stack>
            <pre>{JSON.stringify(db.lastObjectEntry(state.profile.tmp.chainStatus), null, 2)}</pre>
        </div>
    )
}

export default ChainStatus
