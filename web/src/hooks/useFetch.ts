import * as db from "../db"
import * as util from "../../../lib_ts/util"
import * as algo_network from "../../../lib_ts/algo_network"
import * as chain from "../chain"
import * as store from "../store"
import { createSignal, onCleanup } from "solid-js"
import algosdk from "algosdk"
import useStore from "./useStore"


function useFetch<
    T extends db.Proxy | undefined,
    State extends chain.ChainState & db.DbState
>(
    contentAddress: db.ContentAddress,
    proxy: T,
    apply: (state: State, newValue: T) => Partial<State>,
    requestFn: ((_: algosdk.Algodv2) => Promise<any>)
) {
    const { state, dispatch } = useStore<State>()

    const [subscriptions, setSubscriptions] = createSignal({} as { [_: string]: db.DbSubscription })

    const [events, setEvents] = createSignal({} as { [_: string]: { off: () => void } | undefined })
    const [timers, setTimers] = createSignal({} as { [_: string]: NodeJS.Timer | undefined })
    const [values, setValues] = createSignal({} as { [_: string]: T })

    const getLocals = () => ({
        contentAddress,
        [`proxy`]: db.objectValueCount(proxy),
        [`events`]: Object.entries(events()),
        [`timers`]: Object.entries(timers()),
        [`values`]: Object.entries(values()).reduce(
            ([keys, emptyKeys]: (string | any[])[][], [id, value]) =>
                !!value
                    ? [[...keys, [id, db.objectValueCount(value)]], emptyKeys]
                    : [keys, [...emptyKeys, id]],
            [[], []]),
        [`subscriptions`]: Object.entries(subscriptions()).map(([id, { subscription }]) => [id, subscription])
    })

    // const randomHexColorString = () => "#" + Math.floor(Math.random() * 16777215).toString(16)

    const generateSixDigitNumericHashFromString = (text: string) =>
        [...text].map((c) => c.charCodeAt(0)).reduce((acc, x) => acc + (x * 11), 100000).toString().substring(-6)

    const log = util.getLog(getLocals, `#${generateSixDigitNumericHashFromString(contentAddress.contentAddress)}`)

    log('useFetch() 0')

    const newOnValue = (resub: (_: string) => void) =>
        async (id: string, hash: string, newValue: T, rawValue: object | undefined) => {
            const logObj = {
                id,
                hash,
                newValue: db.objectValueCount(newValue),
                rawValue: db.objectValueCount(rawValue)
            }
            log('useFetch.onValue() 1/2', { ...logObj })

            if (hash && Object.keys(proxy || {}).length > 0) {
                log('useFetch.onValue() 2/2. resub (hash)', { ...logObj })

                resub(id)

                // const oldSubscriptions = subscriptions()
                // setSubscriptions({
                //     ...oldSubscriptions,
                //     [id]: oldSubscriptions[id]
                // })
            } else {
                const oldTimers = { ...timers() }
                oldTimers[id] && clearTimeout(oldTimers[id])
                delete oldTimers[id]
                setTimers(oldTimers)

                // Object.values(timers()).forEach(timer => timer && clearInterval(timer))
                // setTimers({})

                // const newDispatch = dispatch as any as ((event: keyof Events, value: State) => void)
                dispatch(apply(state, newValue))

                const oldValues = values()
                const newValues = { ...oldValues, [id]: newValue }
                setValues(newValues)

                log('useFetch.onValue() 2/2. set', {
                    ...logObj,
                    oldValues: Object.entries(oldValues).map(([id, values]) =>
                        [id, db.objectValueCount(values)]
                    ),
                    newValues: Object.entries(newValues).map(([id, values]) =>
                        [id, db.objectValueCount(values)]
                    )
                })

                if (rawValue
                    && Object.keys(newValue || {}).length > 0
                    && JSON.stringify(oldValues[id]) !== JSON.stringify(newValue)) {
                    await Promise.all(
                        db.getDbIdList(state)[0]
                            .filter((dbId) => id !== dbId.id)
                            .map(async (dbId) => {
                                log('useFetch.onValue() 3/2. before put item ###', {
                                    ...logObj,
                                    dbId: dbId.id,
                                    lastSourceOld: db.lastObjectEntry(oldValues[id]),
                                    lastSource: db.lastObjectEntry(newValues[id]),
                                    lastTargetOld: db.lastObjectEntry(oldValues[dbId.id]),
                                    lastTarget: db.lastObjectEntry(newValues[dbId.id])
                                })
                                db.dbPut(state, dbId, contentAddress, rawValue)
                            })
                    )
                }
            }
        }

    const unsubscribe = () => {
        log('useFetch.unsubscribe() 1')

        Object.entries(subscriptions()).forEach(([id, { type, subscription }]) => {
            log('useFetch.unsubscribe 2 item', { id, type, subscription })
            db.dbOff(state, id, contentAddress, subscription)
        })
        setSubscriptions({})

        Object.values(events()).forEach((event) => event?.off())
        setEvents({} as { [_: string]: any })
    }

    const resub = (id: string) => {
        const oldTimers = timers()
        oldTimers[id] && clearTimeout(oldTimers[id])

        log('useFetch.resub() 1', { oldTimers })
        setTimers({
            ...oldTimers,
            [id]: setTimeout(() => {
                // const oldSubscriptions = subscriptions()
                // const oldSubscription = oldSubscriptions[id]

                log('useFetch.resub() inside timeout 2')//, oldSubscription)

                // if (oldSubscription) {
                //     dbOff(state, id, key, undefined, oldSubscription.subscription)
                // }

                // dispatch('set', {
                //     // db: {
                //     //     ...state.db,
                //     //     [id]: null as any as Db
                //     // },
                //     dbEnabled: {
                //         ...state.dbEnabled
                //     }
                // })
            }, db.DB_RESUB_TIMEOUT)
        })
    }

    const subscribe = (id: db.Id) => {
        const oldSubscriptions = subscriptions()
        const oldSubscription = oldSubscriptions[id.id]
        log('useFetch.subscribe() 1', { oldSubscription })

        if (proxy && !oldSubscription && state.dbStatus) {
            const onValue = newOnValue(resub)
            const newSubscription = db.dbOn(state, proxy, id, contentAddress, onValue)
            log('useFetch.subscribe() 2', { newSubscription })
            if (newSubscription) {
                setSubscriptions({
                    ...oldSubscriptions,
                    [id.id]: { type: id.dbType, subscription: newSubscription }
                })
            }

            resub(id.id)
        }
    }

    const unbind = store.store.on('@changed', (newState, changed, oldStore) => {
        if (changed.dbStatus || changed.dbRef) {
            log('useFetch.store.@changed 1', {
                changed: Object.keys(changed).map((key) => ({
                    key,
                    state: state[key as keyof State],
                    newState: newState[key as keyof store.State],
                    changed: changed[key as keyof store.State],
                    oldStore: oldStore.get()[key as keyof store.State],
                }))
            })

            unsubscribe()
            // setTimeout(() => getEnabledDbIdList(newState).forEach((id) => subscribe(newState, id)), 2000)

            Object.values(timers()).forEach((timer) => timer && clearTimeout(timer))
            setTimers(
                db.getDbIdList(newState)[0].reduce((accIntervals, id) =>
                ({
                    ...accIntervals,
                    [id.id]: setTimeout(() => subscribe(id), db.DB_INIT_TIMEOUT)
                }), {} as { [_: string]: NodeJS.Timer | undefined })
            )
        }
    })
    onCleanup(() => {
        unbind()
        unsubscribe()
    })

    const request = async () => {
        const client = algo_network.newClient(state.chainToken, state.chainUrl, state.chainPort)
        let result: {}
        try {
            result = await requestFn(client)
        } catch (e) {
            result = e as {}
        }

        const enabledDbIdList = db.getDbIdList(state)[0]
        const timestamp = `${new Date().getTime()}`

        log('useFetch.request() 1', { result, timestamp, enabledDbIdList })

        if (enabledDbIdList.length === 0) {
            const newValue = {
                ...proxy,
                [timestamp]: result
            }
            dispatch(apply(state, newValue))
        } else {
            await Promise.all(
                enabledDbIdList.map((id) =>
                    db.dbPut(state, id, contentAddress, { [timestamp]: result })
                )
            )

            Object.values(timers()).forEach((timer) => timer && clearTimeout(timer))
            setTimers(
                enabledDbIdList.reduce((accIntervals, id) =>
                ({
                    ...accIntervals,
                    [id.id]: setTimeout(() => {
                        const oldSubscriptions = subscriptions()
                        const oldSubscription = oldSubscriptions[id.id]

                        log('useFetch.request() 1 resub timeout', { id: id.id, oldSubscription })

                        if (oldSubscription) {
                            db.dbOff(state, id.id, contentAddress, oldSubscription.subscription)
                        }
                        const newSubscriptions = { ...subscriptions() }
                        delete newSubscriptions[id.id]
                        setSubscriptions(newSubscriptions)

                        subscribe(id)
                    }, db.DB_RESUB_TIMEOUT)
                }), {} as { [_: string]: NodeJS.Timer | undefined })
            )
        }
    }

    const clear = async () => {
        const enabledDbIdList = db.getDbIdList(state)[0]
        const timestamp = `${new Date().getTime()}`

        log('useFetch.clear() 1', { timestamp, enabledDbIdList })

        if (enabledDbIdList.length === 0) {
            const newValue = {
                ...proxy,
                [timestamp]: null
            }
            dispatch(apply(state, newValue))
        } else {
            await Promise.all(
                enabledDbIdList.map((id) =>
                    db.dbPut(state, id, contentAddress, { [timestamp]: null })
                )
            )

            Object.values(timers()).forEach((timer) => timer && clearTimeout(timer))
            setTimers(
                enabledDbIdList.reduce((accIntervals, id) =>
                ({
                    ...accIntervals,
                    [id.id]: setTimeout(() => {
                        log('useFetch.clear() 1 resub timeout', { id: id.id })
                        subscribe(id)
                    }, db.DB_RESUB_TIMEOUT)
                }), {} as { [_: string]: NodeJS.Timer | undefined })
            )
        }
    }

    return { request, clear }
}

export default useFetch