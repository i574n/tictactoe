import useStore from "../hooks/useStore"
import { Input } from '@hope-ui/solid'


function StateInput<T, State extends object>(
    props: {
        get: (state: State) => T,
        set: (state: State, value: T) => State
    }
) {
    const { state, dispatch } = useStore<State>()

    return (
        <Input
            type="text"
            size="xs"
            value={props.get(state) as any}
            onInput={(e: { currentTarget: { value: any } }) => {
                const newValue = props.set(state, e.currentTarget.value)
                dispatch(newValue)
            }} />
    )
}

export default StateInput
