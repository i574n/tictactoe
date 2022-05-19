#r "nuget: Fable.Python"
open Fable.Core.PyInterop
open Fable.Core
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
and closure0 () () : bool =
    let v0 : string = "app_initialization_logic"
    printfn $"%A{v0}"
    let v1 : int32 = (importAll "pyteal")?Int 0
    let v2 : int32 = (importAll "pyteal")?Int 0
    let v3 : int32 = (importAll "pyteal")?Int 0
    let v4 : int32 = (importAll "pyteal")?Int 1000000
    let v5 : int32 = (importAll "pyteal")?Int 3600
    let struct (v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : string, v12 : string, v13 : string, v14 : string) = method0()
    let v15 : bool = (importAll "pyteal")?App?globalPut (v14, v1)
    let v16 : bool = (importAll "pyteal")?App?globalPut (v11, v2)
    let v17 : bool = (importAll "pyteal")?App?globalPut (v9, v3)
    let v18 : bool = (importAll "pyteal")?App?globalPut (v7, v4)
    let v19 : int32 = (importAll "pyteal")?Int 1
    let v20 : bool = (importAll "pyteal")?Return v19
    let v21 : (bool []) = [|v15; v16; v17; v18; v20|]
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
and closure2 () (v0 : int32) : bool =
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
    let v34 : bool = (importAll "pyteal")?Or v5 v9 v13 v17 v21 v25 v29 v33
    let v35 : int32 = (importAll "pyteal")?Int 1
    let v36 : int32 = (importAll "pyteal")?Int 0
    (importAll "pyteal")?If v34 v35 v36
and closure3 () () : bool =
    let v0 : string = "money_refund_logic"
    printfn $"%A{v0}"
    let struct (v1 : string, v2 : string, v3 : string, v4 : string, v5 : string, v6 : string, v7 : string, v8 : string, v9 : string) = method0()
    let v10 : int32 = (importAll "pyteal")?App?globalGet v4
    let v11 : int32 = (importAll "pyteal")?Int 1
    let v12 : bool = v10 = v11
    let v13 : int32 = (importAll "pyteal")?App?globalGet v4
    let v14 : int32 = (importAll "pyteal")?Int 0
    let v15 : bool = v13 = v14
    let v16 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v17 : int32 = (importAll "pyteal")?App?globalGet v1
    let v18 : bool = v16 > v17
    let v19 : int32 = (importAll "pyteal")?App?globalGet v7
    let v20 : int32 = (importAll "pyteal")?App?globalGet v5
    let v21 : bool = v19 = v20
    let v22 : bool = (importAll "pyteal")?And v15 v18 v21
    let v23 : bool = (importAll "pyteal")?Or v12 v22
    let v24 : int32 = (importAll "pyteal")?App?globalGet v4
    let v25 : int32 = (importAll "pyteal")?Int 2
    let v26 : bool = v24 = v25
    let v27 : int32 = (importAll "pyteal")?App?globalGet v4
    let v28 : int32 = (importAll "pyteal")?Int 0
    let v29 : bool = v27 = v28
    let v30 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v31 : int32 = (importAll "pyteal")?App?globalGet v1
    let v32 : bool = v30 > v31
    let v33 : int32 = (importAll "pyteal")?App?globalGet v7
    let v34 : int32 = (importAll "pyteal")?App?globalGet v8
    let v35 : bool = v33 = v34
    let v36 : bool = (importAll "pyteal")?And v29 v32 v35
    let v37 : bool = (importAll "pyteal")?Or v26 v36
    let v38 : obj = (import "TxnGroup" "pyteal")?__getitem__(import "Gtxn" "pyteal", 1)
    let v39 : int32 = v38?receiver ()
    let v40 : int32 = (importAll "pyteal")?App?globalGet v8
    let v41 : bool = v39 = v40
    let v42 : bool = (importAll "pyteal")?Assert v41
    let v43 : obj = (import "TxnGroup" "pyteal")?__getitem__(import "Gtxn" "pyteal", 1)
    let v44 : int32 = v43?amount ()
    let v45 : int32 = (importAll "pyteal")?Int 2
    let v46 : int32 = (importAll "pyteal")?App?globalGet v2
    let v47 : int32 = v45 * v46
    let v48 : bool = v44 = v47
    let v49 : bool = (importAll "pyteal")?Assert v48
    let v50 : int32 = (importAll "pyteal")?Int 1
    let v51 : bool = (importAll "pyteal")?App?globalPut (v4, v50)
    let v52 : (bool []) = [|v42; v49; v51|]
    let v53 : bool = (importAll "pyteal")?Seq v52
    let v54 : obj = (import "TxnGroup" "pyteal")?__getitem__(import "Gtxn" "pyteal", 1)
    let v55 : int32 = v54?receiver ()
    let v56 : int32 = (importAll "pyteal")?App?globalGet v5
    let v57 : bool = v55 = v56
    let v58 : bool = (importAll "pyteal")?Assert v57
    let v59 : obj = (import "TxnGroup" "pyteal")?__getitem__(import "Gtxn" "pyteal", 1)
    let v60 : int32 = v59?amount ()
    let v61 : int32 = (importAll "pyteal")?Int 2
    let v62 : int32 = (importAll "pyteal")?App?globalGet v2
    let v63 : int32 = v61 * v62
    let v64 : bool = v60 = v63
    let v65 : bool = (importAll "pyteal")?Assert v64
    let v66 : int32 = (importAll "pyteal")?Int 2
    let v67 : bool = (importAll "pyteal")?App?globalPut (v4, v66)
    let v68 : (bool []) = [|v58; v65; v67|]
    let v69 : bool = (importAll "pyteal")?Seq v68
    let v70 : int32 = (importAll "pyteal")?App?globalGet v4
    let v71 : int32 = (importAll "pyteal")?Int 3
    let v72 : bool = v70 = v71
    let v73 : obj = (import "TxnGroup" "pyteal")?__getitem__(import "Gtxn" "pyteal", 1)
    let v74 : int32 = v73?receiver ()
    let v75 : int32 = (importAll "pyteal")?App?globalGet v8
    let v76 : bool = v74 = v75
    let v77 : bool = (importAll "pyteal")?Assert v76
    let v78 : obj = (import "TxnGroup" "pyteal")?__getitem__(import "Gtxn" "pyteal", 1)
    let v79 : int32 = v78?amount ()
    let v80 : int32 = (importAll "pyteal")?App?globalGet v2
    let v81 : bool = v79 = v80
    let v82 : bool = (importAll "pyteal")?Assert v81
    let v83 : obj = (import "TxnGroup" "pyteal")?__getitem__(import "Gtxn" "pyteal", 2)
    let v84 : int32 = v83?type_enum ()
    let v85 : int32 = (importAll "pyteal")?TxnType?Payment
    let v86 : bool = v84 = v85
    let v87 : bool = (importAll "pyteal")?Assert v86
    let v88 : obj = (import "TxnGroup" "pyteal")?__getitem__(import "Gtxn" "pyteal", 2)
    let v89 : int32 = v88?sender ()
    let v90 : int32 = (importAll "pyteal")?App?globalGet v3
    let v91 : bool = v89 = v90
    let v92 : bool = (importAll "pyteal")?Assert v91
    let v93 : obj = (import "TxnGroup" "pyteal")?__getitem__(import "Gtxn" "pyteal", 2)
    let v94 : int32 = v93?receiver ()
    let v95 : int32 = (importAll "pyteal")?App?globalGet v5
    let v96 : bool = v94 = v95
    let v97 : bool = (importAll "pyteal")?Assert v96
    let v98 : obj = (import "TxnGroup" "pyteal")?__getitem__(import "Gtxn" "pyteal", 2)
    let v99 : int32 = v98?amount ()
    let v100 : int32 = (importAll "pyteal")?App?globalGet v2
    let v101 : bool = v99 = v100
    let v102 : bool = (importAll "pyteal")?Assert v101
    let v103 : (bool []) = [|v77; v82; v87; v92; v97; v102|]
    let v104 : bool = (importAll "pyteal")?Seq v103
    let v105 : obj = (import "TxnGroup" "pyteal")?__getitem__(import "Gtxn" "pyteal", 1)
    let v106 : int32 = v105?type_enum ()
    let v107 : int32 = (importAll "pyteal")?TxnType?Payment
    let v108 : bool = v106 = v107
    let v109 : bool = (importAll "pyteal")?Assert v108
    let v110 : obj = (import "TxnGroup" "pyteal")?__getitem__(import "Gtxn" "pyteal", 1)
    let v111 : int32 = v110?sender ()
    let v112 : int32 = (importAll "pyteal")?App?globalGet v3
    let v113 : bool = v111 = v112
    let v114 : bool = (importAll "pyteal")?Assert v113
    let v115 : (bool []) = [|v23; v53|]
    let v116 : (bool []) = [|v37; v69|]
    let v117 : (bool []) = [|v72; v104|]
    let v118 : bool = (importAll "pyteal")?Cond v115 v116 v117
    let v119 : int32 = (importAll "pyteal")?Int 1
    let v120 : bool = (importAll "pyteal")?Return v119
    let v121 : (bool []) = [|v109; v114; v118; v120|]
    (importAll "pyteal")?Seq v121
let v0 : string = "main.spi Loaded"
printfn $"%A{v0}"
let v1 : (unit -> bool) = closure0()
let v2 : (unit -> bool) = closure1()
let v3 : (int32 -> bool) = closure2()
let v4 : (unit -> bool) = closure3()
()
