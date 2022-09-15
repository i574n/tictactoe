import Row from "./Row"
import * as db from "../db"
import * as ui from "../ui"
import DbConnection from './DbConnection'
import BaseTable from "./BaseTable"


function Database<State extends db.DbState & ui.UiState>() {
    return (
        <BaseTable>
            <Row<State>
                title="Rust -> Rust"
                props={{
                    id: "db-gun-rs-rs",
                    loader: false,
                    onLoad: (state, dispatch) => {
                        dispatch({
                            dbStatus: {
                                ...state.dbStatus,
                                gun_rs: {
                                    ...state.dbStatus.gun_rs,
                                    gun_rs: true
                                }
                            }
                        } as Partial<State>)
                    }
                }}
            >
                <DbConnection
                    type="gun_rs"
                />
            </Row>
            <Row<State>
                title="Rust -> JavaScript"
                props={{
                    id: "db-gun-rs-js",
                    loader: false,
                    onLoad: (state, dispatch) => {
                        dispatch({
                            dbStatus: {
                                ...state.dbStatus,
                                gun_rs: {
                                    ...state.dbStatus.gun_rs,
                                    gun_js: true
                                }
                            }
                        } as Partial<State>)
                    }
                }}
            >
                <DbConnection
                    type="gun_js"
                />
            </Row>
            <Row<State>
                title="JavaScript -> JavaScript"
                props={{
                    id: "db-gun-js-js",
                    loader: false,
                    onLoad: (state, dispatch) => {
                        dispatch({
                            dbStatus: {
                                ...state.dbStatus,
                                gun_js: {
                                    ...state.dbStatus.gun_js,
                                    gun_js: true
                                }
                            }
                        } as Partial<State>)
                    }
                }}
            >
                <DbConnection
                    type="gun_js"
                />
            </Row>
            <Row<State>
                title="JavaScript -> Rust"
                props={{
                    id: "db-gun-js-rs",
                    loader: false,
                    onLoad: (state, dispatch) => {
                        dispatch({
                            dbStatus: {
                                ...state.dbStatus,
                                gun_js: {
                                    ...state.dbStatus.gun_js,
                                    gun_rs: true
                                }
                            }
                        } as Partial<State>)
                    }
                }}
            >
                <DbConnection
                    type="gun_rs"
                />
            </Row>
        </BaseTable>
    )
}

export default Database
