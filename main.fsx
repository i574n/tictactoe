#r "nuget: Fable.Python"
open Fable.Core.PyInterop
open Fable.Core
let rec method0 (v0 : int32) : int32 =
    let v1 : (int32 -> int32) = import "Int" "pyteal"
    v1 v0
and method1 (v0 : string) : string =
    let v1 : (string -> string) = import "Bytes" "pyteal"
    v1 v0
and method2 (v0 : string, v1 : int32) : obj =
    (import "App" "pyteal")?globalPut(v0, v1)
and method3 (v0 : int32) : obj =
    let v1 : (int32 -> obj) = import "Return" "pyteal"
    v1 v0
and method4 (v0 : (obj [])) : obj =
    let v1 : ((obj []) -> obj) = import "Seq" "pyteal"
    v1 v0
and closure0 () () : obj =
    let v0 : int32 = 0
    let v1 : int32 = method0(v0)
    let v2 : int32 = 0
    let v3 : int32 = method0(v2)
    let v4 : int32 = 0
    let v5 : int32 = method0(v4)
    let v6 : int32 = 1000000
    let v7 : int32 = method0(v6)
    let v8 : int32 = 3600
    let v9 : int32 = method0(v8)
    let v10 : string = "PlayerXState"
    let v11 : string = method1(v10)
    let v12 : string = "PlayerOState"
    let v13 : string = method1(v12)
    let v14 : string = "PlayerXAddress"
    let v15 : string = method1(v14)
    let v16 : string = "PlayerOAddress"
    let v17 : string = method1(v16)
    let v18 : string = "PlayerTurnAddress"
    let v19 : string = method1(v18)
    let v20 : string = "FundsEscrowAddress"
    let v21 : string = method1(v20)
    let v22 : string = "ActionTimeout"
    let v23 : string = method1(v22)
    let v24 : string = "GameState"
    let v25 : string = method1(v24)
    let v26 : string = "BetAmount"
    let v27 : string = method1(v26)
    let v28 : obj = method2(v11, v1)
    let v29 : obj = method2(v13, v3)
    let v30 : obj = method2(v25, v5)
    let v31 : obj = method2(v27, v7)
    let v32 : int32 = 1
    let v33 : int32 = method0(v32)
    let v34 : obj = method3(v33)
    let v35 : (obj []) = [|v28; v29; v30; v31; v34|]
    method4(v35)
let v0 : string = "main.spi Loaded"
printfn $"%A{v0}"
let v1 : (unit -> obj) = closure0()
()
