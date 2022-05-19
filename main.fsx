let rec method0 () : struct (string * string * string * string * string * string * string * string * string) =
    let v0 : string = (importAll "pyteal")?Bytes "PlayerXState"
    let v1 : string = (importAll "pyteal")?Bytes "PlayerOState"
    let v2 : string = (importAll "pyteal")?Bytes "PlayerXAddress"
    let v3 : string = (importAll "pyteal")?Bytes "PlayerOAddress"
    let v4 : string = (importAll "pyteal")?Bytes "PlayerTurnAddress"
    let v5 : string = (importAll "pyteal")?Bytes "FundsEscrowAddress"
    let v6 : string = (importAll "pyteal")?Bytes "ActionTimeout"
    let v7 : string = (importAll "pyteal")?Bytes "GameState"
    let v8 : string = (importAll "pyteal")?Bytes "BetAmount"
    struct (v6, v8, v5, v7, v3, v1, v4, v2, v0)
and closure0 () () : obj =
    let v0 : string = "app_initialization_logic"
    printfn $"%A{v0}"
    let v1 : int32 = (importAll "pyteal")?Int 0
    let v2 : int32 = (importAll "pyteal")?Int 0
    let v3 : int32 = (importAll "pyteal")?Int 0
    let v4 : int32 = (importAll "pyteal")?Int 1000000
    let v5 : int32 = (importAll "pyteal")?Int 3600
    let struct (v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : string, v12 : string, v13 : string, v14 : string) = method0()
    let v15 : obj = (importAll "pyteal")?App?globalPut (v14, v1)
    let v16 : obj = (importAll "pyteal")?App?globalPut (v11, v2)
    let v17 : obj = (importAll "pyteal")?App?globalPut (v9, v3)
    let v18 : obj = (importAll "pyteal")?App?globalPut (v7, v4)
    let v19 : int32 = (importAll "pyteal")?Int 1
    let v20 : obj = (importAll "pyteal")?Return v19
    let v21 : (obj []) = [|v15; v16; v17; v18; v20|]
    (importAll "pyteal")?Seq v21
and closure1 () () : bool =
    let v0 : string = "is_tie"
    printfn $"%A{v0}"
    let struct (v1 : string, v2 : string, v3 : string, v4 : string, v5 : string, v6 : string, v7 : string, v8 : string, v9 : string) = method0()
    let v10 : int32 = (importAll "pyteal")?App?globalGet v9
    let v11 : int32 = (importAll "pyteal")?App?globalGet v6
    let v12 : int32 = (importAll "pyteal")?Int 511
    let v13 : int32 = (importAll "pyteal")?BitwiseOr v10 v11
    v12 = v13
and closure2 () (v0 : int32) : obj =
    let v1 : string = "has_player_won"
    printfn $"%A{v1}"
    let v2 : int32 = (importAll "pyteal")?Int 448
    let v3 : int32 = (importAll "pyteal")?BitwiseAnd v0 v2
    let v4 : int32 = (importAll "pyteal")?Int 448
    let v5 : bool = v3 = v4
    let v6 : int32 = (importAll "pyteal")?Int 56
    let v7 : int32 = (importAll "pyteal")?BitwiseAnd v0 v6
    let v8 : int32 = (importAll "pyteal")?Int 56
    let v9 : bool = v7 = v8
    let v10 : int32 = (importAll "pyteal")?Int 7
    let v11 : int32 = (importAll "pyteal")?BitwiseAnd v0 v10
    let v12 : int32 = (importAll "pyteal")?Int 7
    let v13 : bool = v11 = v12
    let v14 : int32 = (importAll "pyteal")?Int 292
    let v15 : int32 = (importAll "pyteal")?BitwiseAnd v0 v14
    let v16 : int32 = (importAll "pyteal")?Int 292
    let v17 : bool = v15 = v16
    let v18 : int32 = (importAll "pyteal")?Int 146
    let v19 : int32 = (importAll "pyteal")?BitwiseAnd v0 v18
    let v20 : int32 = (importAll "pyteal")?Int 146
    let v21 : bool = v19 = v20
    let v22 : int32 = (importAll "pyteal")?Int 73
    let v23 : int32 = (importAll "pyteal")?BitwiseAnd v0 v22
    let v24 : int32 = (importAll "pyteal")?Int 73
    let v25 : bool = v23 = v24
    let v26 : int32 = (importAll "pyteal")?Int 273
    let v27 : int32 = (importAll "pyteal")?BitwiseAnd v0 v26
    let v28 : int32 = (importAll "pyteal")?Int 273
    let v29 : bool = v27 = v28
    let v30 : int32 = (importAll "pyteal")?Int 84
    let v31 : int32 = (importAll "pyteal")?BitwiseAnd v0 v30
    let v32 : int32 = (importAll "pyteal")?Int 84
    let v33 : bool = v31 = v32
    let v34 : obj = (importAll "pyteal")?Or v5 v9 v13 v17 v21 v25 v29 v33
    let v35 : int32 = (importAll "pyteal")?Int 1
    let v36 : int32 = (importAll "pyteal")?Int 0
    (importAll "pyteal")?If v34 v35 v36
#r "nuget: Fable.Python"
open Fable.Core.PyInterop
open Fable.Core
let v0 : string = "main.spi Loaded"
printfn $"%A{v0}"
let v1 : (unit -> obj) = closure0()
let v2 : (unit -> bool) = closure1()
let v3 : (int32 -> obj) = closure2()
()
