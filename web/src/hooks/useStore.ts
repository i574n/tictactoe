import { useStoreon } from "@storeon/solidjs"


function useStore<State extends object>() {
    const [state, dispatch] = useStoreon<State, { set: Partial<State> }>()

    const newDispatchRaw = dispatch as any as ((event: 'set', value: Partial<State>) => void)

    const newDispatch = (newValue: Partial<State>) => {
        newDispatchRaw('set', newValue)
    }

    return { state, dispatch: newDispatch }
}

export default useStore
