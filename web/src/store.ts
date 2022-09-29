import './buffer-shim'
import * as db from "./db"
import * as chain from "./chain"
import * as ui from "./ui"
import * as profile from "./profile"
import * as util from "../../lib_ts/util"
import * as tictactoe_testnet from "../../lib_ts/tictactoe_testnet"
import * as components_spi from "../../lib_ts/components_spi"


export type State = db.DbState & chain.ChainState & ui.UiState & profile.ProfileState

const init: State = {
    chainToken: tictactoe_testnet.token,
    chainUrl: util.CODESPACE_NAME ? `http://${util.CODESPACE_NAME}-4001.githubpreview.dev` : tictactoe_testnet.url,
    chainPort: util.CODESPACE_NAME ? 80 : tictactoe_testnet.port,
    chainAccounts: tictactoe_testnet.accounts,
    dbConnection: {
        gun_rs: {
            url: util.CODESPACE_NAME && !util.IS_TEST ? `ws://${util.CODESPACE_NAME}-4944.githubpreview.dev` : 'ws://localhost',
            port: util.CODESPACE_NAME && !util.IS_TEST ? 80 : (util.IS_TEST ? 14944 : 4944),
            ws: "ws"
        },
        gun_js: {
            url: util.CODESPACE_NAME && !util.IS_TEST ? `ws://${util.CODESPACE_NAME}-8765.githubpreview.dev` : 'wss://localhost',
            port: util.CODESPACE_NAME && !util.IS_TEST ? 80 : (util.IS_TEST ? 18765 : 8765),
            ws: "gun"
        }
    },
    dbStatus: {
        gun_rs: {
            gun_rs: false,
            gun_js: false
        } as { [_ in db.DbType]: boolean },
        gun_js: {
            gun_rs: false,
            gun_js: false
        } as { [_ in db.DbType]: boolean }
    },
    dbRef: {},
    ui_modal: -1,
    profile: {
        tmp: {}
    }
}

export const store = components_spi.v1.l0["create_storeon"](init)
