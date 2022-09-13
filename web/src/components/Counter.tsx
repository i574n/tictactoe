import * as db from "../db"
import * as store from "../store"
import useStore from "../hooks/useStore"
import { Button, Stack } from '@hope-ui/solid'
import useFetch from "../hooks/useFetch"


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
        } as Partial<State>),
        async (_client) => Object.values(state.profile.tmp.counter || {}).reduce((acc, v) => v === null ? 0 : acc + 1, 0)
    )

    return (
        <div id="counter">
            <Stack direction="row" spacing="4px">
                <Button size="xs" compact onClick={request}>Request</Button>
                <Button size="xs" compact onClick={clear}>Clear</Button>
            </Stack>
            <pre>{JSON.stringify(db.lastObjectEntry(state.profile.tmp.counter), null, 2)}</pre>
        </div>
    )
}

export default Counter
