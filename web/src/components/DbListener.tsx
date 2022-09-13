import * as db from "../db"
import * as store from "../store"
import * as util from "../../../lib_ts/util"
import { onCleanup } from "solid-js"
import useStore from "../hooks/useStore"


function DbListener<State extends db.DbState>() {
    const { state, dispatch } = useStore<State>()

    const getLocals = () => ({ ...db.getStateLocals(state) })
    const log = util.getLog(getLocals, '#cf1100')

    log('DbListener() 0')

    const refresh = () => {
        const newDbRef = db.getDbIdList(state)[0].reduce((accDb, { dbType, url, id }) => ({
            ...accDb,
            [id]: accDb[id] || db.newDb(dbType, { url })
        }), state.dbRef)

        log('DbListener refresh() 1', { newDbRef })

        dispatch({ dbRef: newDbRef } as Partial<State>)
    }

    const unbind = store.store.on('@changed', (newState, changed, store) => {
        log('DbListener store.on(@changed) 1', {
            changed: Object.keys(changed).map((key) => ({
                key,
                state: db.objectValueCount(state[key as keyof State]),
                newState: db.objectValueCount(newState[key as keyof store.State]),
                changed: db.objectValueCount(changed[key as keyof store.State]),
                store: db.objectValueCount(store.get()[key as keyof store.State]),
            }))
        })
        if (changed.dbStatus || changed.dbConnection) {
            refresh()
        }
    })
    onCleanup(() => {
        unbind()
    })

    return <></>
}

export default DbListener
