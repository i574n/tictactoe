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
    let v24 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v25 : int32 = v24?receiver ()
    let v26 : int32 = (importAll "pyteal")?App?globalGet v8
    let v27 : bool = v25 = v26
    let v28 : bool = (importAll "pyteal")?Assert v27
    let v29 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v30 : int32 = v29?amount ()
    let v31 : int32 = (importAll "pyteal")?Int 2
    let v32 : int32 = (importAll "pyteal")?App?globalGet v2
    let v33 : int32 = v31 * v32
    let v34 : bool = v30 = v33
    let v35 : bool = (importAll "pyteal")?Assert v34
    let v36 : int32 = (importAll "pyteal")?Int 1
    let v37 : bool = (importAll "pyteal")?App?globalPut (v4, v36)
    let v38 : (bool []) = [|v28; v35; v37|]
    let v39 : bool = (importAll "pyteal")?Seq v38
    let v40 : int32 = (importAll "pyteal")?App?globalGet v4
    let v41 : int32 = (importAll "pyteal")?Int 2
    let v42 : bool = v40 = v41
    let v43 : int32 = (importAll "pyteal")?App?globalGet v4
    let v44 : int32 = (importAll "pyteal")?Int 0
    let v45 : bool = v43 = v44
    let v46 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v47 : int32 = (importAll "pyteal")?App?globalGet v1
    let v48 : bool = v46 > v47
    let v49 : int32 = (importAll "pyteal")?App?globalGet v7
    let v50 : int32 = (importAll "pyteal")?App?globalGet v8
    let v51 : bool = v49 = v50
    let v52 : bool = (importAll "pyteal")?And v45 v48 v51
    let v53 : bool = (importAll "pyteal")?Or v42 v52
    let v54 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v55 : int32 = v54?receiver ()
    let v56 : int32 = (importAll "pyteal")?App?globalGet v5
    let v57 : bool = v55 = v56
    let v58 : bool = (importAll "pyteal")?Assert v57
    let v59 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
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
    let v73 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v74 : int32 = v73?receiver ()
    let v75 : int32 = (importAll "pyteal")?App?globalGet v8
    let v76 : bool = v74 = v75
    let v77 : bool = (importAll "pyteal")?Assert v76
    let v78 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v79 : int32 = v78?amount ()
    let v80 : int32 = (importAll "pyteal")?App?globalGet v2
    let v81 : bool = v79 = v80
    let v82 : bool = (importAll "pyteal")?Assert v81
    let v83 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v84 : int32 = v83?type_enum ()
    let v85 : int32 = (importAll "pyteal")?TxnType?Payment
    let v86 : bool = v84 = v85
    let v87 : bool = (importAll "pyteal")?Assert v86
    let v88 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v89 : int32 = v88?sender ()
    let v90 : int32 = (importAll "pyteal")?App?globalGet v3
    let v91 : bool = v89 = v90
    let v92 : bool = (importAll "pyteal")?Assert v91
    let v93 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v94 : int32 = v93?receiver ()
    let v95 : int32 = (importAll "pyteal")?App?globalGet v5
    let v96 : bool = v94 = v95
    let v97 : bool = (importAll "pyteal")?Assert v96
    let v98 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v99 : int32 = v98?amount ()
    let v100 : int32 = (importAll "pyteal")?App?globalGet v2
    let v101 : bool = v99 = v100
    let v102 : bool = (importAll "pyteal")?Assert v101
    let v103 : (bool []) = [|v77; v82; v87; v92; v97; v102|]
    let v104 : bool = (importAll "pyteal")?Seq v103
    let v105 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v106 : int32 = v105?type_enum ()
    let v107 : int32 = (importAll "pyteal")?TxnType?Payment
    let v108 : bool = v106 = v107
    let v109 : bool = (importAll "pyteal")?Assert v108
    let v110 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v111 : int32 = v110?sender ()
    let v112 : int32 = (importAll "pyteal")?App?globalGet v3
    let v113 : bool = v111 = v112
    let v114 : bool = (importAll "pyteal")?Assert v113
    let v115 : (bool []) = [|v23; v39|]
    let v116 : (bool []) = [|v53; v69|]
    let v117 : (bool []) = [|v72; v104|]
    let v118 : bool = (importAll "pyteal")?Cond v115 v116 v117
    let v119 : int32 = (importAll "pyteal")?Int 1
    let v120 : bool = (importAll "pyteal")?Return v119
    let v121 : (bool []) = [|v109; v114; v118; v120|]
    (importAll "pyteal")?Seq v121
and closure4 () () : bool =
    let v0 : string = "play_action_logic"
    printfn $"%A{v0}"
    let struct (v1 : string, v2 : string, v3 : string, v4 : string, v5 : string, v6 : string, v7 : string, v8 : string, v9 : string) = method0()
    let v10 : int32 = (importAll "pyteal")?Int 0
    let v11 : int32 = (importAll "pyteal")?Int 0
    let v12 : int32 = (importAll "pyteal")?Int 0
    let v13 : int32 = (importAll "pyteal")?Int 1000000
    let v14 : int32 = (importAll "pyteal")?Int 3600
    let v15 : string = ((importAll "pyteal")?Txn?application_args : string[]).[1]
    let v16 : int32 = (importAll "pyteal")?Btoi v15
    let v17 : int32 = (importAll "pyteal")?App?globalGet v9
    let v18 : int32 = (importAll "pyteal")?App?globalGet v6
    let v19 : int32 = (importAll "pyteal")?Int 1
    let v20 : int32 = (importAll "pyteal")?ShiftLeft v19 v16
    let v21 : int32 = (importAll "pyteal")?BitwiseOr v17 v20
    let v22 : bool = (importAll "pyteal")?App?globalPut (v9, v21)
    let v23 : int32 = (importAll "pyteal")?App?globalGet v9
    let v24 : string = "has_player_won"
    printfn $"%A{v24}"
    let v25 : int32 = (importAll "pyteal")?Int 448
    let v26 : int32 = (importAll "pyteal")?BitwiseAnd v23 v25
    let v27 : int32 = (importAll "pyteal")?Int 448
    let v28 : bool = v26 = v27
    let v29 : int32 = (importAll "pyteal")?Int 56
    let v30 : int32 = (importAll "pyteal")?BitwiseAnd v23 v29
    let v31 : int32 = (importAll "pyteal")?Int 56
    let v32 : bool = v30 = v31
    let v33 : int32 = (importAll "pyteal")?Int 7
    let v34 : int32 = (importAll "pyteal")?BitwiseAnd v23 v33
    let v35 : int32 = (importAll "pyteal")?Int 7
    let v36 : bool = v34 = v35
    let v37 : int32 = (importAll "pyteal")?Int 292
    let v38 : int32 = (importAll "pyteal")?BitwiseAnd v23 v37
    let v39 : int32 = (importAll "pyteal")?Int 292
    let v40 : bool = v38 = v39
    let v41 : int32 = (importAll "pyteal")?Int 146
    let v42 : int32 = (importAll "pyteal")?BitwiseAnd v23 v41
    let v43 : int32 = (importAll "pyteal")?Int 146
    let v44 : bool = v42 = v43
    let v45 : int32 = (importAll "pyteal")?Int 73
    let v46 : int32 = (importAll "pyteal")?BitwiseAnd v23 v45
    let v47 : int32 = (importAll "pyteal")?Int 73
    let v48 : bool = v46 = v47
    let v49 : int32 = (importAll "pyteal")?Int 273
    let v50 : int32 = (importAll "pyteal")?BitwiseAnd v23 v49
    let v51 : int32 = (importAll "pyteal")?Int 273
    let v52 : bool = v50 = v51
    let v53 : int32 = (importAll "pyteal")?Int 84
    let v54 : int32 = (importAll "pyteal")?BitwiseAnd v23 v53
    let v55 : int32 = (importAll "pyteal")?Int 84
    let v56 : bool = v54 = v55
    let v57 : bool = (importAll "pyteal")?Or v28 v32 v36 v40 v44 v48 v52 v56
    let v58 : int32 = (importAll "pyteal")?Int 1
    let v59 : int32 = (importAll "pyteal")?Int 0
    let v60 : bool = (importAll "pyteal")?If v57 v58 v59
    let v61 : int32 = (importAll "pyteal")?Int 1
    let v62 : bool = (importAll "pyteal")?App?globalPut (v4, v61)
    let v63 : bool = (importAll "pyteal")?If v60 v62
    let v64 : int32 = (importAll "pyteal")?App?globalGet v5
    let v65 : bool = (importAll "pyteal")?App?globalPut (v7, v64)
    let v66 : (bool []) = [|v22; v63; v65|]
    let v67 : bool = (importAll "pyteal")?Seq v66
    let v68 : int32 = (importAll "pyteal")?BitwiseOr v18 v20
    let v69 : bool = (importAll "pyteal")?App?globalPut (v6, v68)
    let v70 : int32 = (importAll "pyteal")?App?globalGet v6
    let v71 : string = "has_player_won"
    printfn $"%A{v71}"
    let v72 : int32 = (importAll "pyteal")?Int 448
    let v73 : int32 = (importAll "pyteal")?BitwiseAnd v70 v72
    let v74 : int32 = (importAll "pyteal")?Int 448
    let v75 : bool = v73 = v74
    let v76 : int32 = (importAll "pyteal")?Int 56
    let v77 : int32 = (importAll "pyteal")?BitwiseAnd v70 v76
    let v78 : int32 = (importAll "pyteal")?Int 56
    let v79 : bool = v77 = v78
    let v80 : int32 = (importAll "pyteal")?Int 7
    let v81 : int32 = (importAll "pyteal")?BitwiseAnd v70 v80
    let v82 : int32 = (importAll "pyteal")?Int 7
    let v83 : bool = v81 = v82
    let v84 : int32 = (importAll "pyteal")?Int 292
    let v85 : int32 = (importAll "pyteal")?BitwiseAnd v70 v84
    let v86 : int32 = (importAll "pyteal")?Int 292
    let v87 : bool = v85 = v86
    let v88 : int32 = (importAll "pyteal")?Int 146
    let v89 : int32 = (importAll "pyteal")?BitwiseAnd v70 v88
    let v90 : int32 = (importAll "pyteal")?Int 146
    let v91 : bool = v89 = v90
    let v92 : int32 = (importAll "pyteal")?Int 73
    let v93 : int32 = (importAll "pyteal")?BitwiseAnd v70 v92
    let v94 : int32 = (importAll "pyteal")?Int 73
    let v95 : bool = v93 = v94
    let v96 : int32 = (importAll "pyteal")?Int 273
    let v97 : int32 = (importAll "pyteal")?BitwiseAnd v70 v96
    let v98 : int32 = (importAll "pyteal")?Int 273
    let v99 : bool = v97 = v98
    let v100 : int32 = (importAll "pyteal")?Int 84
    let v101 : int32 = (importAll "pyteal")?BitwiseAnd v70 v100
    let v102 : int32 = (importAll "pyteal")?Int 84
    let v103 : bool = v101 = v102
    let v104 : bool = (importAll "pyteal")?Or v75 v79 v83 v87 v91 v95 v99 v103
    let v105 : int32 = (importAll "pyteal")?Int 1
    let v106 : int32 = (importAll "pyteal")?Int 0
    let v107 : bool = (importAll "pyteal")?If v104 v105 v106
    let v108 : int32 = (importAll "pyteal")?Int 2
    let v109 : bool = (importAll "pyteal")?App?globalPut (v4, v108)
    let v110 : bool = (importAll "pyteal")?If v107 v109
    let v111 : int32 = (importAll "pyteal")?App?globalGet v8
    let v112 : bool = (importAll "pyteal")?App?globalPut (v7, v111)
    let v113 : (bool []) = [|v69; v110; v112|]
    let v114 : bool = (importAll "pyteal")?Seq v113
    let v115 : int32 = (importAll "pyteal")?Int 0
    let v116 : bool = v16 >= v115
    let v117 : bool = (importAll "pyteal")?Assert v116
    let v118 : int32 = (importAll "pyteal")?Int 8
    let v119 : bool = v16 <= v118
    let v120 : bool = (importAll "pyteal")?Assert v119
    let v121 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v122 : int32 = (importAll "pyteal")?App?globalGet v1
    let v123 : bool = v121 <= v122
    let v124 : bool = (importAll "pyteal")?Assert v123
    let v125 : int32 = (importAll "pyteal")?App?globalGet v4
    let v126 : bool = v125 = v12
    let v127 : bool = (importAll "pyteal")?Assert v126
    let v128 : int32 = (importAll "pyteal")?Txn?sender ()
    let v129 : int32 = (importAll "pyteal")?App?globalGet v7
    let v130 : bool = v128 = v129
    let v131 : bool = (importAll "pyteal")?Assert v130
    let v132 : int32 = (importAll "pyteal")?BitwiseAnd v17 v20
    let v133 : int32 = (importAll "pyteal")?Int 0
    let v134 : bool = v132 = v133
    let v135 : int32 = (importAll "pyteal")?BitwiseAnd v18 v20
    let v136 : int32 = (importAll "pyteal")?Int 0
    let v137 : bool = v135 = v136
    let v138 : bool = (importAll "pyteal")?And v134 v137
    let v139 : bool = (importAll "pyteal")?Assert v138
    let v140 : int32 = (importAll "pyteal")?Txn?sender ()
    let v141 : int32 = (importAll "pyteal")?App?globalGet v8
    let v142 : bool = v140 = v141
    let v143 : (bool []) = [|v142; v67|]
    let v144 : int32 = (importAll "pyteal")?Txn?sender ()
    let v145 : int32 = (importAll "pyteal")?App?globalGet v5
    let v146 : bool = v144 = v145
    let v147 : (bool []) = [|v146; v114|]
    let v148 : bool = (importAll "pyteal")?Cond v143 v147
    let v149 : string = "is_tie"
    printfn $"%A{v149}"
    let struct (v150 : string, v151 : string, v152 : string, v153 : string, v154 : string, v155 : string, v156 : string, v157 : string, v158 : string) = method0()
    let v159 : int32 = (importAll "pyteal")?App?globalGet v158
    let v160 : int32 = (importAll "pyteal")?App?globalGet v155
    let v161 : int32 = (importAll "pyteal")?Int 511
    let v162 : int32 = (importAll "pyteal")?BitwiseOr v159 v160
    let v163 : bool = v161 = v162
    let v164 : int32 = (importAll "pyteal")?Int 3
    let v165 : bool = (importAll "pyteal")?App?globalPut (v4, v164)
    let v166 : bool = (importAll "pyteal")?If v163 v165
    let v167 : int32 = (importAll "pyteal")?Int 1
    let v168 : bool = (importAll "pyteal")?Return v167
    let v169 : (bool []) = [|v117; v120; v124; v127; v131; v139; v148; v166; v168|]
    (importAll "pyteal")?Seq v169
and closure5 () () : bool =
    let v0 : string = "initialize_players_logic"
    printfn $"%A{v0}"
    let struct (v1 : string, v2 : string, v3 : string, v4 : string, v5 : string, v6 : string, v7 : string, v8 : string, v9 : string) = method0()
    let v10 : int32 = (importAll "pyteal")?Int 0
    let v11 : int32 = (importAll "pyteal")?Int 0
    let v12 : int32 = (importAll "pyteal")?Int 0
    let v13 : int32 = (importAll "pyteal")?Int 1000000
    let v14 : int32 = (importAll "pyteal")?Int 3600
    let v15 : int32 = (importAll "pyteal")?Int 0
    let v16 : int32 = (importAll "pyteal")?App?globalGetEx v15 v8
    let v17 : int32 = (importAll "pyteal")?Int 0
    let v18 : int32 = (importAll "pyteal")?App?globalGetEx v17 v5
    let v19 : int32 = (importAll "pyteal")?Int 0
    let v20 : bool = (importAll "pyteal")?Return v19
    let v21 : (bool []) = [|v20|]
    let v22 : bool = (importAll "pyteal")?Seq v21
    let v23 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v24 : int32 = v23?type_enum ()
    let v25 : int32 = (importAll "pyteal")?TxnType?Payment
    let v26 : bool = v24 = v25
    let v27 : bool = (importAll "pyteal")?Assert v26
    let v28 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v29 : int32 = v28?type_enum ()
    let v30 : int32 = (importAll "pyteal")?TxnType?Payment
    let v31 : bool = v29 = v30
    let v32 : bool = (importAll "pyteal")?Assert v31
    let v33 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v34 : int32 = v33?receiver ()
    let v35 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v36 : int32 = v35?receiver ()
    let v37 : bool = v34 = v36
    let v38 : bool = (importAll "pyteal")?Assert v37
    let v39 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v40 : int32 = v39?amount ()
    let v41 : int32 = (importAll "pyteal")?App?globalGet v2
    let v42 : bool = v40 = v41
    let v43 : bool = (importAll "pyteal")?Assert v42
    let v44 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v45 : int32 = v44?amount ()
    let v46 : int32 = (importAll "pyteal")?App?globalGet v2
    let v47 : bool = v45 = v46
    let v48 : bool = (importAll "pyteal")?Assert v47
    let v49 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v50 : int32 = v49?sender ()
    let v51 : bool = (importAll "pyteal")?App?globalPut (v8, v50)
    let v52 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v53 : int32 = v52?sender ()
    let v54 : bool = (importAll "pyteal")?App?globalPut (v5, v53)
    let v55 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v56 : int32 = v55?sender ()
    let v57 : bool = (importAll "pyteal")?App?globalPut (v7, v56)
    let v58 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v59 : int32 = v58?receiver ()
    let v60 : bool = (importAll "pyteal")?App?globalPut (v3, v59)
    let v61 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v62 : int32 = v61 + v14
    let v63 : bool = (importAll "pyteal")?App?globalPut (v1, v62)
    let v64 : int32 = (importAll "pyteal")?Int 1
    let v65 : bool = (importAll "pyteal")?Return v64
    let v66 : (bool []) = [|v27; v32; v38; v43; v48; v51; v54; v57; v60; v63; v65|]
    let v67 : bool = (importAll "pyteal")?Seq v66
    let v68 : bool = v16?hasValue ()
    let v69 : bool = v18?hasValue ()
    let v70 : bool = (importAll "pyteal")?Or v68 v69
    let v71 : bool = (importAll "pyteal")?If v70 v22 v67
    (importAll "pyteal")?Seq([| box v16; box v18; box v71 |])
and closure6 () () : bool =
    let v0 : string = "application_start"
    printfn $"%A{v0}"
    let v1 : string = (importAll "pyteal")?Bytes "SetupPlayers"
    let v2 : string = (importAll "pyteal")?Bytes "ActionMove"
    let v3 : string = (importAll "pyteal")?Bytes "MoneyRefund"
    let v4 : int32 = (importAll "pyteal")?Txn?application_id ()
    let v5 : int32 = (importAll "pyteal")?Int 0
    let v6 : bool = v4 = v5
    let v7 : string = ((importAll "pyteal")?Txn?application_args : string[]).[0]
    let v8 : bool = v7 = v1
    let v9 : string = "initialize_players_logic"
    printfn $"%A{v9}"
    let struct (v10 : string, v11 : string, v12 : string, v13 : string, v14 : string, v15 : string, v16 : string, v17 : string, v18 : string) = method0()
    let v19 : int32 = (importAll "pyteal")?Int 0
    let v20 : int32 = (importAll "pyteal")?Int 0
    let v21 : int32 = (importAll "pyteal")?Int 0
    let v22 : int32 = (importAll "pyteal")?Int 1000000
    let v23 : int32 = (importAll "pyteal")?Int 3600
    let v24 : int32 = (importAll "pyteal")?Int 0
    let v25 : int32 = (importAll "pyteal")?App?globalGetEx v24 v17
    let v26 : int32 = (importAll "pyteal")?Int 0
    let v27 : int32 = (importAll "pyteal")?App?globalGetEx v26 v14
    let v28 : int32 = (importAll "pyteal")?Int 0
    let v29 : bool = (importAll "pyteal")?Return v28
    let v30 : (bool []) = [|v29|]
    let v31 : bool = (importAll "pyteal")?Seq v30
    let v32 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v33 : int32 = v32?type_enum ()
    let v34 : int32 = (importAll "pyteal")?TxnType?Payment
    let v35 : bool = v33 = v34
    let v36 : bool = (importAll "pyteal")?Assert v35
    let v37 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v38 : int32 = v37?type_enum ()
    let v39 : int32 = (importAll "pyteal")?TxnType?Payment
    let v40 : bool = v38 = v39
    let v41 : bool = (importAll "pyteal")?Assert v40
    let v42 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v43 : int32 = v42?receiver ()
    let v44 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v45 : int32 = v44?receiver ()
    let v46 : bool = v43 = v45
    let v47 : bool = (importAll "pyteal")?Assert v46
    let v48 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v49 : int32 = v48?amount ()
    let v50 : int32 = (importAll "pyteal")?App?globalGet v11
    let v51 : bool = v49 = v50
    let v52 : bool = (importAll "pyteal")?Assert v51
    let v53 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v54 : int32 = v53?amount ()
    let v55 : int32 = (importAll "pyteal")?App?globalGet v11
    let v56 : bool = v54 = v55
    let v57 : bool = (importAll "pyteal")?Assert v56
    let v58 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v59 : int32 = v58?sender ()
    let v60 : bool = (importAll "pyteal")?App?globalPut (v17, v59)
    let v61 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v62 : int32 = v61?sender ()
    let v63 : bool = (importAll "pyteal")?App?globalPut (v14, v62)
    let v64 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v65 : int32 = v64?sender ()
    let v66 : bool = (importAll "pyteal")?App?globalPut (v16, v65)
    let v67 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v68 : int32 = v67?receiver ()
    let v69 : bool = (importAll "pyteal")?App?globalPut (v12, v68)
    let v70 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v71 : int32 = v70 + v23
    let v72 : bool = (importAll "pyteal")?App?globalPut (v10, v71)
    let v73 : int32 = (importAll "pyteal")?Int 1
    let v74 : bool = (importAll "pyteal")?Return v73
    let v75 : (bool []) = [|v36; v41; v47; v52; v57; v60; v63; v66; v69; v72; v74|]
    let v76 : bool = (importAll "pyteal")?Seq v75
    let v77 : bool = v25?hasValue ()
    let v78 : bool = v27?hasValue ()
    let v79 : bool = (importAll "pyteal")?Or v77 v78
    let v80 : bool = (importAll "pyteal")?If v79 v31 v76
    let v81 : bool = (importAll "pyteal")?Seq([| box v25; box v27; box v80 |])
    let v82 : (bool []) = [|v8; v81|]
    let v83 : string = ((importAll "pyteal")?Txn?application_args : string[]).[0]
    let v84 : bool = v83 = v2
    let v85 : int32 = (importAll "pyteal")?Global?group_size ()
    let v86 : int32 = (importAll "pyteal")?Int 1
    let v87 : bool = v85 = v86
    let v88 : bool = (importAll "pyteal")?And v84 v87
    let v89 : string = "play_action_logic"
    printfn $"%A{v89}"
    let struct (v90 : string, v91 : string, v92 : string, v93 : string, v94 : string, v95 : string, v96 : string, v97 : string, v98 : string) = method0()
    let v99 : int32 = (importAll "pyteal")?Int 0
    let v100 : int32 = (importAll "pyteal")?Int 0
    let v101 : int32 = (importAll "pyteal")?Int 0
    let v102 : int32 = (importAll "pyteal")?Int 1000000
    let v103 : int32 = (importAll "pyteal")?Int 3600
    let v104 : string = ((importAll "pyteal")?Txn?application_args : string[]).[1]
    let v105 : int32 = (importAll "pyteal")?Btoi v104
    let v106 : int32 = (importAll "pyteal")?App?globalGet v98
    let v107 : int32 = (importAll "pyteal")?App?globalGet v95
    let v108 : int32 = (importAll "pyteal")?Int 1
    let v109 : int32 = (importAll "pyteal")?ShiftLeft v108 v105
    let v110 : int32 = (importAll "pyteal")?BitwiseOr v106 v109
    let v111 : bool = (importAll "pyteal")?App?globalPut (v98, v110)
    let v112 : int32 = (importAll "pyteal")?App?globalGet v98
    let v113 : string = "has_player_won"
    printfn $"%A{v113}"
    let v114 : int32 = (importAll "pyteal")?Int 448
    let v115 : int32 = (importAll "pyteal")?BitwiseAnd v112 v114
    let v116 : int32 = (importAll "pyteal")?Int 448
    let v117 : bool = v115 = v116
    let v118 : int32 = (importAll "pyteal")?Int 56
    let v119 : int32 = (importAll "pyteal")?BitwiseAnd v112 v118
    let v120 : int32 = (importAll "pyteal")?Int 56
    let v121 : bool = v119 = v120
    let v122 : int32 = (importAll "pyteal")?Int 7
    let v123 : int32 = (importAll "pyteal")?BitwiseAnd v112 v122
    let v124 : int32 = (importAll "pyteal")?Int 7
    let v125 : bool = v123 = v124
    let v126 : int32 = (importAll "pyteal")?Int 292
    let v127 : int32 = (importAll "pyteal")?BitwiseAnd v112 v126
    let v128 : int32 = (importAll "pyteal")?Int 292
    let v129 : bool = v127 = v128
    let v130 : int32 = (importAll "pyteal")?Int 146
    let v131 : int32 = (importAll "pyteal")?BitwiseAnd v112 v130
    let v132 : int32 = (importAll "pyteal")?Int 146
    let v133 : bool = v131 = v132
    let v134 : int32 = (importAll "pyteal")?Int 73
    let v135 : int32 = (importAll "pyteal")?BitwiseAnd v112 v134
    let v136 : int32 = (importAll "pyteal")?Int 73
    let v137 : bool = v135 = v136
    let v138 : int32 = (importAll "pyteal")?Int 273
    let v139 : int32 = (importAll "pyteal")?BitwiseAnd v112 v138
    let v140 : int32 = (importAll "pyteal")?Int 273
    let v141 : bool = v139 = v140
    let v142 : int32 = (importAll "pyteal")?Int 84
    let v143 : int32 = (importAll "pyteal")?BitwiseAnd v112 v142
    let v144 : int32 = (importAll "pyteal")?Int 84
    let v145 : bool = v143 = v144
    let v146 : bool = (importAll "pyteal")?Or v117 v121 v125 v129 v133 v137 v141 v145
    let v147 : int32 = (importAll "pyteal")?Int 1
    let v148 : int32 = (importAll "pyteal")?Int 0
    let v149 : bool = (importAll "pyteal")?If v146 v147 v148
    let v150 : int32 = (importAll "pyteal")?Int 1
    let v151 : bool = (importAll "pyteal")?App?globalPut (v93, v150)
    let v152 : bool = (importAll "pyteal")?If v149 v151
    let v153 : int32 = (importAll "pyteal")?App?globalGet v94
    let v154 : bool = (importAll "pyteal")?App?globalPut (v96, v153)
    let v155 : (bool []) = [|v111; v152; v154|]
    let v156 : bool = (importAll "pyteal")?Seq v155
    let v157 : int32 = (importAll "pyteal")?BitwiseOr v107 v109
    let v158 : bool = (importAll "pyteal")?App?globalPut (v95, v157)
    let v159 : int32 = (importAll "pyteal")?App?globalGet v95
    let v160 : string = "has_player_won"
    printfn $"%A{v160}"
    let v161 : int32 = (importAll "pyteal")?Int 448
    let v162 : int32 = (importAll "pyteal")?BitwiseAnd v159 v161
    let v163 : int32 = (importAll "pyteal")?Int 448
    let v164 : bool = v162 = v163
    let v165 : int32 = (importAll "pyteal")?Int 56
    let v166 : int32 = (importAll "pyteal")?BitwiseAnd v159 v165
    let v167 : int32 = (importAll "pyteal")?Int 56
    let v168 : bool = v166 = v167
    let v169 : int32 = (importAll "pyteal")?Int 7
    let v170 : int32 = (importAll "pyteal")?BitwiseAnd v159 v169
    let v171 : int32 = (importAll "pyteal")?Int 7
    let v172 : bool = v170 = v171
    let v173 : int32 = (importAll "pyteal")?Int 292
    let v174 : int32 = (importAll "pyteal")?BitwiseAnd v159 v173
    let v175 : int32 = (importAll "pyteal")?Int 292
    let v176 : bool = v174 = v175
    let v177 : int32 = (importAll "pyteal")?Int 146
    let v178 : int32 = (importAll "pyteal")?BitwiseAnd v159 v177
    let v179 : int32 = (importAll "pyteal")?Int 146
    let v180 : bool = v178 = v179
    let v181 : int32 = (importAll "pyteal")?Int 73
    let v182 : int32 = (importAll "pyteal")?BitwiseAnd v159 v181
    let v183 : int32 = (importAll "pyteal")?Int 73
    let v184 : bool = v182 = v183
    let v185 : int32 = (importAll "pyteal")?Int 273
    let v186 : int32 = (importAll "pyteal")?BitwiseAnd v159 v185
    let v187 : int32 = (importAll "pyteal")?Int 273
    let v188 : bool = v186 = v187
    let v189 : int32 = (importAll "pyteal")?Int 84
    let v190 : int32 = (importAll "pyteal")?BitwiseAnd v159 v189
    let v191 : int32 = (importAll "pyteal")?Int 84
    let v192 : bool = v190 = v191
    let v193 : bool = (importAll "pyteal")?Or v164 v168 v172 v176 v180 v184 v188 v192
    let v194 : int32 = (importAll "pyteal")?Int 1
    let v195 : int32 = (importAll "pyteal")?Int 0
    let v196 : bool = (importAll "pyteal")?If v193 v194 v195
    let v197 : int32 = (importAll "pyteal")?Int 2
    let v198 : bool = (importAll "pyteal")?App?globalPut (v93, v197)
    let v199 : bool = (importAll "pyteal")?If v196 v198
    let v200 : int32 = (importAll "pyteal")?App?globalGet v97
    let v201 : bool = (importAll "pyteal")?App?globalPut (v96, v200)
    let v202 : (bool []) = [|v158; v199; v201|]
    let v203 : bool = (importAll "pyteal")?Seq v202
    let v204 : int32 = (importAll "pyteal")?Int 0
    let v205 : bool = v105 >= v204
    let v206 : bool = (importAll "pyteal")?Assert v205
    let v207 : int32 = (importAll "pyteal")?Int 8
    let v208 : bool = v105 <= v207
    let v209 : bool = (importAll "pyteal")?Assert v208
    let v210 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v211 : int32 = (importAll "pyteal")?App?globalGet v90
    let v212 : bool = v210 <= v211
    let v213 : bool = (importAll "pyteal")?Assert v212
    let v214 : int32 = (importAll "pyteal")?App?globalGet v93
    let v215 : bool = v214 = v101
    let v216 : bool = (importAll "pyteal")?Assert v215
    let v217 : int32 = (importAll "pyteal")?Txn?sender ()
    let v218 : int32 = (importAll "pyteal")?App?globalGet v96
    let v219 : bool = v217 = v218
    let v220 : bool = (importAll "pyteal")?Assert v219
    let v221 : int32 = (importAll "pyteal")?BitwiseAnd v106 v109
    let v222 : int32 = (importAll "pyteal")?Int 0
    let v223 : bool = v221 = v222
    let v224 : int32 = (importAll "pyteal")?BitwiseAnd v107 v109
    let v225 : int32 = (importAll "pyteal")?Int 0
    let v226 : bool = v224 = v225
    let v227 : bool = (importAll "pyteal")?And v223 v226
    let v228 : bool = (importAll "pyteal")?Assert v227
    let v229 : int32 = (importAll "pyteal")?Txn?sender ()
    let v230 : int32 = (importAll "pyteal")?App?globalGet v97
    let v231 : bool = v229 = v230
    let v232 : (bool []) = [|v231; v156|]
    let v233 : int32 = (importAll "pyteal")?Txn?sender ()
    let v234 : int32 = (importAll "pyteal")?App?globalGet v94
    let v235 : bool = v233 = v234
    let v236 : (bool []) = [|v235; v203|]
    let v237 : bool = (importAll "pyteal")?Cond v232 v236
    let v238 : string = "is_tie"
    printfn $"%A{v238}"
    let struct (v239 : string, v240 : string, v241 : string, v242 : string, v243 : string, v244 : string, v245 : string, v246 : string, v247 : string) = method0()
    let v248 : int32 = (importAll "pyteal")?App?globalGet v247
    let v249 : int32 = (importAll "pyteal")?App?globalGet v244
    let v250 : int32 = (importAll "pyteal")?Int 511
    let v251 : int32 = (importAll "pyteal")?BitwiseOr v248 v249
    let v252 : bool = v250 = v251
    let v253 : int32 = (importAll "pyteal")?Int 3
    let v254 : bool = (importAll "pyteal")?App?globalPut (v93, v253)
    let v255 : bool = (importAll "pyteal")?If v252 v254
    let v256 : int32 = (importAll "pyteal")?Int 1
    let v257 : bool = (importAll "pyteal")?Return v256
    let v258 : (bool []) = [|v206; v209; v213; v216; v220; v228; v237; v255; v257|]
    let v259 : bool = (importAll "pyteal")?Seq v258
    let v260 : (bool []) = [|v88; v259|]
    let v261 : string = ((importAll "pyteal")?Txn?application_args : string[]).[0]
    let v262 : bool = v261 = v3
    let v263 : string = "money_refund_logic"
    printfn $"%A{v263}"
    let struct (v264 : string, v265 : string, v266 : string, v267 : string, v268 : string, v269 : string, v270 : string, v271 : string, v272 : string) = method0()
    let v273 : int32 = (importAll "pyteal")?App?globalGet v267
    let v274 : int32 = (importAll "pyteal")?Int 1
    let v275 : bool = v273 = v274
    let v276 : int32 = (importAll "pyteal")?App?globalGet v267
    let v277 : int32 = (importAll "pyteal")?Int 0
    let v278 : bool = v276 = v277
    let v279 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v280 : int32 = (importAll "pyteal")?App?globalGet v264
    let v281 : bool = v279 > v280
    let v282 : int32 = (importAll "pyteal")?App?globalGet v270
    let v283 : int32 = (importAll "pyteal")?App?globalGet v268
    let v284 : bool = v282 = v283
    let v285 : bool = (importAll "pyteal")?And v278 v281 v284
    let v286 : bool = (importAll "pyteal")?Or v275 v285
    let v287 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v288 : int32 = v287?receiver ()
    let v289 : int32 = (importAll "pyteal")?App?globalGet v271
    let v290 : bool = v288 = v289
    let v291 : bool = (importAll "pyteal")?Assert v290
    let v292 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v293 : int32 = v292?amount ()
    let v294 : int32 = (importAll "pyteal")?Int 2
    let v295 : int32 = (importAll "pyteal")?App?globalGet v265
    let v296 : int32 = v294 * v295
    let v297 : bool = v293 = v296
    let v298 : bool = (importAll "pyteal")?Assert v297
    let v299 : int32 = (importAll "pyteal")?Int 1
    let v300 : bool = (importAll "pyteal")?App?globalPut (v267, v299)
    let v301 : (bool []) = [|v291; v298; v300|]
    let v302 : bool = (importAll "pyteal")?Seq v301
    let v303 : int32 = (importAll "pyteal")?App?globalGet v267
    let v304 : int32 = (importAll "pyteal")?Int 2
    let v305 : bool = v303 = v304
    let v306 : int32 = (importAll "pyteal")?App?globalGet v267
    let v307 : int32 = (importAll "pyteal")?Int 0
    let v308 : bool = v306 = v307
    let v309 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v310 : int32 = (importAll "pyteal")?App?globalGet v264
    let v311 : bool = v309 > v310
    let v312 : int32 = (importAll "pyteal")?App?globalGet v270
    let v313 : int32 = (importAll "pyteal")?App?globalGet v271
    let v314 : bool = v312 = v313
    let v315 : bool = (importAll "pyteal")?And v308 v311 v314
    let v316 : bool = (importAll "pyteal")?Or v305 v315
    let v317 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v318 : int32 = v317?receiver ()
    let v319 : int32 = (importAll "pyteal")?App?globalGet v268
    let v320 : bool = v318 = v319
    let v321 : bool = (importAll "pyteal")?Assert v320
    let v322 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v323 : int32 = v322?amount ()
    let v324 : int32 = (importAll "pyteal")?Int 2
    let v325 : int32 = (importAll "pyteal")?App?globalGet v265
    let v326 : int32 = v324 * v325
    let v327 : bool = v323 = v326
    let v328 : bool = (importAll "pyteal")?Assert v327
    let v329 : int32 = (importAll "pyteal")?Int 2
    let v330 : bool = (importAll "pyteal")?App?globalPut (v267, v329)
    let v331 : (bool []) = [|v321; v328; v330|]
    let v332 : bool = (importAll "pyteal")?Seq v331
    let v333 : int32 = (importAll "pyteal")?App?globalGet v267
    let v334 : int32 = (importAll "pyteal")?Int 3
    let v335 : bool = v333 = v334
    let v336 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v337 : int32 = v336?receiver ()
    let v338 : int32 = (importAll "pyteal")?App?globalGet v271
    let v339 : bool = v337 = v338
    let v340 : bool = (importAll "pyteal")?Assert v339
    let v341 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v342 : int32 = v341?amount ()
    let v343 : int32 = (importAll "pyteal")?App?globalGet v265
    let v344 : bool = v342 = v343
    let v345 : bool = (importAll "pyteal")?Assert v344
    let v346 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v347 : int32 = v346?type_enum ()
    let v348 : int32 = (importAll "pyteal")?TxnType?Payment
    let v349 : bool = v347 = v348
    let v350 : bool = (importAll "pyteal")?Assert v349
    let v351 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v352 : int32 = v351?sender ()
    let v353 : int32 = (importAll "pyteal")?App?globalGet v266
    let v354 : bool = v352 = v353
    let v355 : bool = (importAll "pyteal")?Assert v354
    let v356 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v357 : int32 = v356?receiver ()
    let v358 : int32 = (importAll "pyteal")?App?globalGet v268
    let v359 : bool = v357 = v358
    let v360 : bool = (importAll "pyteal")?Assert v359
    let v361 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v362 : int32 = v361?amount ()
    let v363 : int32 = (importAll "pyteal")?App?globalGet v265
    let v364 : bool = v362 = v363
    let v365 : bool = (importAll "pyteal")?Assert v364
    let v366 : (bool []) = [|v340; v345; v350; v355; v360; v365|]
    let v367 : bool = (importAll "pyteal")?Seq v366
    let v368 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v369 : int32 = v368?type_enum ()
    let v370 : int32 = (importAll "pyteal")?TxnType?Payment
    let v371 : bool = v369 = v370
    let v372 : bool = (importAll "pyteal")?Assert v371
    let v373 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v374 : int32 = v373?sender ()
    let v375 : int32 = (importAll "pyteal")?App?globalGet v266
    let v376 : bool = v374 = v375
    let v377 : bool = (importAll "pyteal")?Assert v376
    let v378 : (bool []) = [|v286; v302|]
    let v379 : (bool []) = [|v316; v332|]
    let v380 : (bool []) = [|v335; v367|]
    let v381 : bool = (importAll "pyteal")?Cond v378 v379 v380
    let v382 : int32 = (importAll "pyteal")?Int 1
    let v383 : bool = (importAll "pyteal")?Return v382
    let v384 : (bool []) = [|v372; v377; v381; v383|]
    let v385 : bool = (importAll "pyteal")?Seq v384
    let v386 : (bool []) = [|v262; v385|]
    let v387 : bool = (importAll "pyteal")?Cond v82 v260 v386
    let v388 : string = "app_initialization_logic"
    printfn $"%A{v388}"
    let v389 : int32 = (importAll "pyteal")?Int 0
    let v390 : int32 = (importAll "pyteal")?Int 0
    let v391 : int32 = (importAll "pyteal")?Int 0
    let v392 : int32 = (importAll "pyteal")?Int 1000000
    let v393 : int32 = (importAll "pyteal")?Int 3600
    let struct (v394 : string, v395 : string, v396 : string, v397 : string, v398 : string, v399 : string, v400 : string, v401 : string, v402 : string) = method0()
    let v403 : bool = (importAll "pyteal")?App?globalPut (v402, v389)
    let v404 : bool = (importAll "pyteal")?App?globalPut (v399, v390)
    let v405 : bool = (importAll "pyteal")?App?globalPut (v397, v391)
    let v406 : bool = (importAll "pyteal")?App?globalPut (v395, v392)
    let v407 : int32 = (importAll "pyteal")?Int 1
    let v408 : bool = (importAll "pyteal")?Return v407
    let v409 : (bool []) = [|v403; v404; v405; v406; v408|]
    let v410 : bool = (importAll "pyteal")?Seq v409
    (importAll "pyteal")?If v6 v410 v387
let v0 : string = "main.spi Loaded"
printfn $"%A{v0}"
let v1 : (unit -> bool) = closure0()
let v2 : (unit -> bool) = closure1()
let v3 : (int32 -> bool) = closure2()
let v4 : (unit -> bool) = closure3()
let v5 : (unit -> bool) = closure4()
let v6 : (unit -> bool) = closure5()
let v7 : (unit -> bool) = closure6()
()
