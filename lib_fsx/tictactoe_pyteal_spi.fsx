#r "nuget: Fable.Python"
open Fable.Core.PyInterop
open Fable.Core

type [<Struct>] US0 =
    | US0_0
    | US0_1 of f1_0 : int32
let rec method0 () : struct (string * string * string * string * string * string * string * string * string) =
    let v0 : string = "PlayerXState"
    let v1 : string = (importAll "pyteal")?Bytes v0
    let v2 : string = "PlayerOState"
    let v3 : string = (importAll "pyteal")?Bytes v2
    let v4 : string = "PlayerXAddress"
    let v5 : string = (importAll "pyteal")?Bytes v4
    let v6 : string = "PlayerOAddress"
    let v7 : string = (importAll "pyteal")?Bytes v6
    let v8 : string = "PlayerTurnAddress"
    let v9 : string = (importAll "pyteal")?Bytes v8
    let v10 : string = "FundsEscrowAddress"
    let v11 : string = (importAll "pyteal")?Bytes v10
    let v12 : string = "ActionTimeout"
    let v13 : string = (importAll "pyteal")?Bytes v12
    let v14 : string = "GameState"
    let v15 : string = (importAll "pyteal")?Bytes v14
    let v16 : string = "BetAmount"
    let v17 : string = (importAll "pyteal")?Bytes v16
    struct (v13, v17, v11, v15, v7, v3, v9, v5, v1)
and closure0 () (v0 : US0) : bool =
    let v1 : string = "application_start"
    printfn $"%A{v1}"
    let v2 : string = "SetupPlayers"
    let v3 : string = (importAll "pyteal")?Bytes v2
    let v4 : string = "ActionMove"
    let v5 : string = (importAll "pyteal")?Bytes v4
    let v6 : string = "MoneyRefund"
    let v7 : string = (importAll "pyteal")?Bytes v6
    let v8 : int32 = (importAll "pyteal")?Txn?application_id ()
    let v9 : int32 = (importAll "pyteal")?Int 0
    let v10 : bool = v8 = v9
    let v11 : string = ((importAll "pyteal")?Txn?application_args : string[]).[0]
    let v12 : bool = v11 = v3
    let v13 : string = "initialize_players_logic"
    printfn $"%A{v13}"
    let struct (v14 : string, v15 : string, v16 : string, v17 : string, v18 : string, v19 : string, v20 : string, v21 : string, v22 : string) = method0()
    let v23 : int32 = (importAll "pyteal")?Int 0
    let v24 : int32 = (importAll "pyteal")?Int 0
    let v25 : int32 = (importAll "pyteal")?Int 0
    let v26 : int32 = (importAll "pyteal")?Int 1000000
    let v27 : int32 = (importAll "pyteal")?Int 3600
    let v28 : int32 = (importAll "pyteal")?Int 0
    let v29 : int32 = (importAll "pyteal")?App?globalGetEx v28 v21
    let v30 : int32 = (importAll "pyteal")?Int 0
    let v31 : int32 = (importAll "pyteal")?App?globalGetEx v30 v18
    let v32 : int32 = (importAll "pyteal")?Int 0
    let v33 : bool = (importAll "pyteal")?Return v32
    let v34 : (bool []) = [|v33|]
    let v35 : bool = (importAll "pyteal")?Seq v34
    let v38 : int32 =
        match v0 with
        | US0_0 -> (* None *)
            v27
        | US0_1(v36) -> (* Some *)
            let v37 : int32 = (importAll "pyteal")?Int v36
            v37
    let v39 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v40 : int32 = v39?type_enum ()
    let v41 : int32 = (importAll "pyteal")?TxnType?Payment
    let v42 : bool = v40 = v41
    let v43 : bool = (importAll "pyteal")?Assert v42
    let v44 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v45 : int32 = v44?type_enum ()
    let v46 : int32 = (importAll "pyteal")?TxnType?Payment
    let v47 : bool = v45 = v46
    let v48 : bool = (importAll "pyteal")?Assert v47
    let v49 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v50 : int32 = v49?receiver ()
    let v51 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v52 : int32 = v51?receiver ()
    let v53 : bool = v50 = v52
    let v54 : bool = (importAll "pyteal")?Assert v53
    let v55 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v56 : int32 = v55?amount ()
    let v57 : int32 = (importAll "pyteal")?App?globalGet v15
    let v58 : bool = v56 = v57
    let v59 : bool = (importAll "pyteal")?Assert v58
    let v60 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v61 : int32 = v60?amount ()
    let v62 : int32 = (importAll "pyteal")?App?globalGet v15
    let v63 : bool = v61 = v62
    let v64 : bool = (importAll "pyteal")?Assert v63
    let v65 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v66 : int32 = v65?sender ()
    let v67 : bool = (importAll "pyteal")?App?globalPut (v21, v66)
    let v68 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v69 : int32 = v68?sender ()
    let v70 : bool = (importAll "pyteal")?App?globalPut (v18, v69)
    let v71 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v72 : int32 = v71?sender ()
    let v73 : bool = (importAll "pyteal")?App?globalPut (v20, v72)
    let v74 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v75 : int32 = v74?receiver ()
    let v76 : bool = (importAll "pyteal")?App?globalPut (v16, v75)
    let v77 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v78 : int32 = v77 + v38
    let v79 : bool = (importAll "pyteal")?App?globalPut (v14, v78)
    let v80 : int32 = (importAll "pyteal")?Int 1
    let v81 : bool = (importAll "pyteal")?Return v80
    let v82 : (bool []) = [|v43; v48; v54; v59; v64; v67; v70; v73; v76; v79; v81|]
    let v83 : bool = (importAll "pyteal")?Seq v82
    let v84 : bool = v29?hasValue ()
    let v85 : bool = v31?hasValue ()
    let v86 : bool = (importAll "pyteal")?Or v84 v85
    let v87 : bool = (importAll "pyteal")?If v86 v35 v83
    let v88 : bool = (importAll "pyteal")?Seq([| box v29; box v31; box v87 |])
    let v89 : (bool []) = [|v12; v88|]
    let v90 : string = ((importAll "pyteal")?Txn?application_args : string[]).[0]
    let v91 : bool = v90 = v5
    let v92 : int32 = (importAll "pyteal")?Global?group_size ()
    let v93 : int32 = (importAll "pyteal")?Int 1
    let v94 : bool = v92 = v93
    let v95 : bool = (importAll "pyteal")?And v91 v94
    let v96 : string = "play_action_logic"
    printfn $"%A{v96}"
    let struct (v97 : string, v98 : string, v99 : string, v100 : string, v101 : string, v102 : string, v103 : string, v104 : string, v105 : string) = method0()
    let v106 : int32 = (importAll "pyteal")?Int 0
    let v107 : int32 = (importAll "pyteal")?Int 0
    let v108 : int32 = (importAll "pyteal")?Int 0
    let v109 : int32 = (importAll "pyteal")?Int 1000000
    let v110 : int32 = (importAll "pyteal")?Int 3600
    let v111 : string = ((importAll "pyteal")?Txn?application_args : string[]).[1]
    let v112 : int32 = (importAll "pyteal")?Btoi v111
    let v113 : int32 = (importAll "pyteal")?App?globalGet v105
    let v114 : int32 = (importAll "pyteal")?App?globalGet v102
    let v115 : int32 = (importAll "pyteal")?Int 1
    let v116 : int32 = (importAll "pyteal")?ShiftLeft v115 v112
    let v117 : int32 = (importAll "pyteal")?BitwiseOr v113 v116
    let v118 : bool = (importAll "pyteal")?App?globalPut (v105, v117)
    let v119 : int32 = (importAll "pyteal")?App?globalGet v105
    let v120 : string = "has_player_won"
    printfn $"%A{v120}"
    let v121 : int32 = (importAll "pyteal")?Int 448
    let v122 : int32 = (importAll "pyteal")?BitwiseAnd v119 v121
    let v123 : int32 = (importAll "pyteal")?Int 448
    let v124 : bool = v122 = v123
    let v125 : int32 = (importAll "pyteal")?Int 56
    let v126 : int32 = (importAll "pyteal")?BitwiseAnd v119 v125
    let v127 : int32 = (importAll "pyteal")?Int 56
    let v128 : bool = v126 = v127
    let v129 : int32 = (importAll "pyteal")?Int 7
    let v130 : int32 = (importAll "pyteal")?BitwiseAnd v119 v129
    let v131 : int32 = (importAll "pyteal")?Int 7
    let v132 : bool = v130 = v131
    let v133 : int32 = (importAll "pyteal")?Int 292
    let v134 : int32 = (importAll "pyteal")?BitwiseAnd v119 v133
    let v135 : int32 = (importAll "pyteal")?Int 292
    let v136 : bool = v134 = v135
    let v137 : int32 = (importAll "pyteal")?Int 146
    let v138 : int32 = (importAll "pyteal")?BitwiseAnd v119 v137
    let v139 : int32 = (importAll "pyteal")?Int 146
    let v140 : bool = v138 = v139
    let v141 : int32 = (importAll "pyteal")?Int 73
    let v142 : int32 = (importAll "pyteal")?BitwiseAnd v119 v141
    let v143 : int32 = (importAll "pyteal")?Int 73
    let v144 : bool = v142 = v143
    let v145 : int32 = (importAll "pyteal")?Int 273
    let v146 : int32 = (importAll "pyteal")?BitwiseAnd v119 v145
    let v147 : int32 = (importAll "pyteal")?Int 273
    let v148 : bool = v146 = v147
    let v149 : int32 = (importAll "pyteal")?Int 84
    let v150 : int32 = (importAll "pyteal")?BitwiseAnd v119 v149
    let v151 : int32 = (importAll "pyteal")?Int 84
    let v152 : bool = v150 = v151
    let v153 : bool = (importAll "pyteal")?Or v124 v128 v132 v136 v140 v144 v148 v152
    let v154 : int32 = (importAll "pyteal")?Int 1
    let v155 : int32 = (importAll "pyteal")?Int 0
    let v156 : bool = (importAll "pyteal")?If v153 v154 v155
    let v157 : int32 = (importAll "pyteal")?Int 1
    let v158 : bool = (importAll "pyteal")?App?globalPut (v100, v157)
    let v159 : bool = (importAll "pyteal")?If v156 v158
    let v160 : int32 = (importAll "pyteal")?App?globalGet v101
    let v161 : bool = (importAll "pyteal")?App?globalPut (v103, v160)
    let v162 : (bool []) = [|v118; v159; v161|]
    let v163 : bool = (importAll "pyteal")?Seq v162
    let v164 : int32 = (importAll "pyteal")?BitwiseOr v114 v116
    let v165 : bool = (importAll "pyteal")?App?globalPut (v102, v164)
    let v166 : int32 = (importAll "pyteal")?App?globalGet v102
    printfn $"%A{v120}"
    let v167 : int32 = (importAll "pyteal")?Int 448
    let v168 : int32 = (importAll "pyteal")?BitwiseAnd v166 v167
    let v169 : int32 = (importAll "pyteal")?Int 448
    let v170 : bool = v168 = v169
    let v171 : int32 = (importAll "pyteal")?Int 56
    let v172 : int32 = (importAll "pyteal")?BitwiseAnd v166 v171
    let v173 : int32 = (importAll "pyteal")?Int 56
    let v174 : bool = v172 = v173
    let v175 : int32 = (importAll "pyteal")?Int 7
    let v176 : int32 = (importAll "pyteal")?BitwiseAnd v166 v175
    let v177 : int32 = (importAll "pyteal")?Int 7
    let v178 : bool = v176 = v177
    let v179 : int32 = (importAll "pyteal")?Int 292
    let v180 : int32 = (importAll "pyteal")?BitwiseAnd v166 v179
    let v181 : int32 = (importAll "pyteal")?Int 292
    let v182 : bool = v180 = v181
    let v183 : int32 = (importAll "pyteal")?Int 146
    let v184 : int32 = (importAll "pyteal")?BitwiseAnd v166 v183
    let v185 : int32 = (importAll "pyteal")?Int 146
    let v186 : bool = v184 = v185
    let v187 : int32 = (importAll "pyteal")?Int 73
    let v188 : int32 = (importAll "pyteal")?BitwiseAnd v166 v187
    let v189 : int32 = (importAll "pyteal")?Int 73
    let v190 : bool = v188 = v189
    let v191 : int32 = (importAll "pyteal")?Int 273
    let v192 : int32 = (importAll "pyteal")?BitwiseAnd v166 v191
    let v193 : int32 = (importAll "pyteal")?Int 273
    let v194 : bool = v192 = v193
    let v195 : int32 = (importAll "pyteal")?Int 84
    let v196 : int32 = (importAll "pyteal")?BitwiseAnd v166 v195
    let v197 : int32 = (importAll "pyteal")?Int 84
    let v198 : bool = v196 = v197
    let v199 : bool = (importAll "pyteal")?Or v170 v174 v178 v182 v186 v190 v194 v198
    let v200 : int32 = (importAll "pyteal")?Int 1
    let v201 : int32 = (importAll "pyteal")?Int 0
    let v202 : bool = (importAll "pyteal")?If v199 v200 v201
    let v203 : int32 = (importAll "pyteal")?Int 2
    let v204 : bool = (importAll "pyteal")?App?globalPut (v100, v203)
    let v205 : bool = (importAll "pyteal")?If v202 v204
    let v206 : int32 = (importAll "pyteal")?App?globalGet v104
    let v207 : bool = (importAll "pyteal")?App?globalPut (v103, v206)
    let v208 : (bool []) = [|v165; v205; v207|]
    let v209 : bool = (importAll "pyteal")?Seq v208
    let v210 : int32 = (importAll "pyteal")?Int 0
    let v211 : bool = v112 >= v210
    let v212 : bool = (importAll "pyteal")?Assert v211
    let v213 : int32 = (importAll "pyteal")?Int 8
    let v214 : bool = v112 <= v213
    let v215 : bool = (importAll "pyteal")?Assert v214
    let v216 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v217 : int32 = (importAll "pyteal")?App?globalGet v97
    let v218 : bool = v216 <= v217
    let v219 : bool = (importAll "pyteal")?Assert v218
    let v220 : int32 = (importAll "pyteal")?App?globalGet v100
    let v221 : bool = v220 = v108
    let v222 : bool = (importAll "pyteal")?Assert v221
    let v223 : int32 = (importAll "pyteal")?Txn?sender ()
    let v224 : int32 = (importAll "pyteal")?App?globalGet v103
    let v225 : bool = v223 = v224
    let v226 : bool = (importAll "pyteal")?Assert v225
    let v227 : int32 = (importAll "pyteal")?BitwiseAnd v113 v116
    let v228 : int32 = (importAll "pyteal")?Int 0
    let v229 : bool = v227 = v228
    let v230 : int32 = (importAll "pyteal")?BitwiseAnd v114 v116
    let v231 : int32 = (importAll "pyteal")?Int 0
    let v232 : bool = v230 = v231
    let v233 : bool = (importAll "pyteal")?And v229 v232
    let v234 : bool = (importAll "pyteal")?Assert v233
    let v235 : int32 = (importAll "pyteal")?Txn?sender ()
    let v236 : int32 = (importAll "pyteal")?App?globalGet v104
    let v237 : bool = v235 = v236
    let v238 : (bool []) = [|v237; v163|]
    let v239 : int32 = (importAll "pyteal")?Txn?sender ()
    let v240 : int32 = (importAll "pyteal")?App?globalGet v101
    let v241 : bool = v239 = v240
    let v242 : (bool []) = [|v241; v209|]
    let v243 : bool = (importAll "pyteal")?Cond v238 v242
    let v244 : string = "is_tie"
    printfn $"%A{v244}"
    let struct (v245 : string, v246 : string, v247 : string, v248 : string, v249 : string, v250 : string, v251 : string, v252 : string, v253 : string) = method0()
    let v254 : int32 = (importAll "pyteal")?App?globalGet v253
    let v255 : int32 = (importAll "pyteal")?App?globalGet v250
    let v256 : int32 = (importAll "pyteal")?Int 511
    let v257 : int32 = (importAll "pyteal")?BitwiseOr v254 v255
    let v258 : bool = v256 = v257
    let v259 : int32 = (importAll "pyteal")?Int 3
    let v260 : bool = (importAll "pyteal")?App?globalPut (v100, v259)
    let v261 : bool = (importAll "pyteal")?If v258 v260
    let v262 : int32 = (importAll "pyteal")?Int 1
    let v263 : bool = (importAll "pyteal")?Return v262
    let v264 : (bool []) = [|v212; v215; v219; v222; v226; v234; v243; v261; v263|]
    let v265 : bool = (importAll "pyteal")?Seq v264
    let v266 : (bool []) = [|v95; v265|]
    let v267 : string = ((importAll "pyteal")?Txn?application_args : string[]).[0]
    let v268 : bool = v267 = v7
    let v269 : string = "money_refund_logic"
    printfn $"%A{v269}"
    let struct (v270 : string, v271 : string, v272 : string, v273 : string, v274 : string, v275 : string, v276 : string, v277 : string, v278 : string) = method0()
    let v279 : int32 = (importAll "pyteal")?App?globalGet v273
    let v280 : int32 = (importAll "pyteal")?Int 1
    let v281 : bool = v279 = v280
    let v282 : int32 = (importAll "pyteal")?App?globalGet v273
    let v283 : int32 = (importAll "pyteal")?Int 0
    let v284 : bool = v282 = v283
    let v285 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v286 : int32 = (importAll "pyteal")?App?globalGet v270
    let v287 : bool = v285 > v286
    let v288 : int32 = (importAll "pyteal")?App?globalGet v276
    let v289 : int32 = (importAll "pyteal")?App?globalGet v274
    let v290 : bool = v288 = v289
    let v291 : bool = (importAll "pyteal")?And v284 v287 v290
    let v292 : bool = (importAll "pyteal")?Or v281 v291
    let v293 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v294 : int32 = v293?receiver ()
    let v295 : int32 = (importAll "pyteal")?App?globalGet v277
    let v296 : bool = v294 = v295
    let v297 : bool = (importAll "pyteal")?Assert v296
    let v298 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v299 : int32 = v298?amount ()
    let v300 : int32 = (importAll "pyteal")?Int 2
    let v301 : int32 = (importAll "pyteal")?App?globalGet v271
    let v302 : int32 = v300 * v301
    let v303 : bool = v299 = v302
    let v304 : bool = (importAll "pyteal")?Assert v303
    let v305 : int32 = (importAll "pyteal")?Int 1
    let v306 : bool = (importAll "pyteal")?App?globalPut (v273, v305)
    let v307 : (bool []) = [|v297; v304; v306|]
    let v308 : bool = (importAll "pyteal")?Seq v307
    let v309 : int32 = (importAll "pyteal")?App?globalGet v273
    let v310 : int32 = (importAll "pyteal")?Int 2
    let v311 : bool = v309 = v310
    let v312 : int32 = (importAll "pyteal")?App?globalGet v273
    let v313 : int32 = (importAll "pyteal")?Int 0
    let v314 : bool = v312 = v313
    let v315 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v316 : int32 = (importAll "pyteal")?App?globalGet v270
    let v317 : bool = v315 > v316
    let v318 : int32 = (importAll "pyteal")?App?globalGet v276
    let v319 : int32 = (importAll "pyteal")?App?globalGet v277
    let v320 : bool = v318 = v319
    let v321 : bool = (importAll "pyteal")?And v314 v317 v320
    let v322 : bool = (importAll "pyteal")?Or v311 v321
    let v323 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v324 : int32 = v323?receiver ()
    let v325 : int32 = (importAll "pyteal")?App?globalGet v274
    let v326 : bool = v324 = v325
    let v327 : bool = (importAll "pyteal")?Assert v326
    let v328 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v329 : int32 = v328?amount ()
    let v330 : int32 = (importAll "pyteal")?Int 2
    let v331 : int32 = (importAll "pyteal")?App?globalGet v271
    let v332 : int32 = v330 * v331
    let v333 : bool = v329 = v332
    let v334 : bool = (importAll "pyteal")?Assert v333
    let v335 : int32 = (importAll "pyteal")?Int 2
    let v336 : bool = (importAll "pyteal")?App?globalPut (v273, v335)
    let v337 : (bool []) = [|v327; v334; v336|]
    let v338 : bool = (importAll "pyteal")?Seq v337
    let v339 : int32 = (importAll "pyteal")?App?globalGet v273
    let v340 : int32 = (importAll "pyteal")?Int 3
    let v341 : bool = v339 = v340
    let v342 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v343 : int32 = v342?receiver ()
    let v344 : int32 = (importAll "pyteal")?App?globalGet v277
    let v345 : bool = v343 = v344
    let v346 : bool = (importAll "pyteal")?Assert v345
    let v347 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v348 : int32 = v347?amount ()
    let v349 : int32 = (importAll "pyteal")?App?globalGet v271
    let v350 : bool = v348 = v349
    let v351 : bool = (importAll "pyteal")?Assert v350
    let v352 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v353 : int32 = v352?type_enum ()
    let v354 : int32 = (importAll "pyteal")?TxnType?Payment
    let v355 : bool = v353 = v354
    let v356 : bool = (importAll "pyteal")?Assert v355
    let v357 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v358 : int32 = v357?sender ()
    let v359 : int32 = (importAll "pyteal")?App?globalGet v272
    let v360 : bool = v358 = v359
    let v361 : bool = (importAll "pyteal")?Assert v360
    let v362 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v363 : int32 = v362?receiver ()
    let v364 : int32 = (importAll "pyteal")?App?globalGet v274
    let v365 : bool = v363 = v364
    let v366 : bool = (importAll "pyteal")?Assert v365
    let v367 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v368 : int32 = v367?amount ()
    let v369 : int32 = (importAll "pyteal")?App?globalGet v271
    let v370 : bool = v368 = v369
    let v371 : bool = (importAll "pyteal")?Assert v370
    let v372 : (bool []) = [|v346; v351; v356; v361; v366; v371|]
    let v373 : bool = (importAll "pyteal")?Seq v372
    let v374 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v375 : int32 = v374?type_enum ()
    let v376 : int32 = (importAll "pyteal")?TxnType?Payment
    let v377 : bool = v375 = v376
    let v378 : bool = (importAll "pyteal")?Assert v377
    let v379 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v380 : int32 = v379?sender ()
    let v381 : int32 = (importAll "pyteal")?App?globalGet v272
    let v382 : bool = v380 = v381
    let v383 : bool = (importAll "pyteal")?Assert v382
    let v384 : (bool []) = [|v292; v308|]
    let v385 : (bool []) = [|v322; v338|]
    let v386 : (bool []) = [|v341; v373|]
    let v387 : bool = (importAll "pyteal")?Cond v384 v385 v386
    let v388 : int32 = (importAll "pyteal")?Int 1
    let v389 : bool = (importAll "pyteal")?Return v388
    let v390 : (bool []) = [|v378; v383; v387; v389|]
    let v391 : bool = (importAll "pyteal")?Seq v390
    let v392 : (bool []) = [|v268; v391|]
    let v393 : bool = (importAll "pyteal")?Cond v89 v266 v392
    let v394 : string = "app_initialization_logic"
    printfn $"%A{v394}"
    let v395 : int32 = (importAll "pyteal")?Int 0
    let v396 : int32 = (importAll "pyteal")?Int 0
    let v397 : int32 = (importAll "pyteal")?Int 0
    let v398 : int32 = (importAll "pyteal")?Int 1000000
    let v399 : int32 = (importAll "pyteal")?Int 3600
    let struct (v400 : string, v401 : string, v402 : string, v403 : string, v404 : string, v405 : string, v406 : string, v407 : string, v408 : string) = method0()
    let v409 : bool = (importAll "pyteal")?App?globalPut (v408, v395)
    let v410 : bool = (importAll "pyteal")?App?globalPut (v405, v396)
    let v411 : bool = (importAll "pyteal")?App?globalPut (v403, v397)
    let v412 : bool = (importAll "pyteal")?App?globalPut (v401, v398)
    let v413 : int32 = (importAll "pyteal")?Int 1
    let v414 : bool = (importAll "pyteal")?Return v413
    let v415 : (bool []) = [|v409; v410; v411; v412; v414|]
    let v416 : bool = (importAll "pyteal")?Seq v415
    let v417 : bool = (importAll "pyteal")?If v10 v416 v393
    v417
and closure1 () () : bool =
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
    let v22 : bool = (importAll "pyteal")?Seq v21
    v22
and closure2 () (v0 : US0) : bool =
    let v1 : string = "initialize_players_logic"
    printfn $"%A{v1}"
    let struct (v2 : string, v3 : string, v4 : string, v5 : string, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string) = method0()
    let v11 : int32 = (importAll "pyteal")?Int 0
    let v12 : int32 = (importAll "pyteal")?Int 0
    let v13 : int32 = (importAll "pyteal")?Int 0
    let v14 : int32 = (importAll "pyteal")?Int 1000000
    let v15 : int32 = (importAll "pyteal")?Int 3600
    let v16 : int32 = (importAll "pyteal")?Int 0
    let v17 : int32 = (importAll "pyteal")?App?globalGetEx v16 v9
    let v18 : int32 = (importAll "pyteal")?Int 0
    let v19 : int32 = (importAll "pyteal")?App?globalGetEx v18 v6
    let v20 : int32 = (importAll "pyteal")?Int 0
    let v21 : bool = (importAll "pyteal")?Return v20
    let v22 : (bool []) = [|v21|]
    let v23 : bool = (importAll "pyteal")?Seq v22
    let v26 : int32 =
        match v0 with
        | US0_0 -> (* None *)
            v15
        | US0_1(v24) -> (* Some *)
            let v25 : int32 = (importAll "pyteal")?Int v24
            v25
    let v27 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v28 : int32 = v27?type_enum ()
    let v29 : int32 = (importAll "pyteal")?TxnType?Payment
    let v30 : bool = v28 = v29
    let v31 : bool = (importAll "pyteal")?Assert v30
    let v32 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v33 : int32 = v32?type_enum ()
    let v34 : int32 = (importAll "pyteal")?TxnType?Payment
    let v35 : bool = v33 = v34
    let v36 : bool = (importAll "pyteal")?Assert v35
    let v37 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v38 : int32 = v37?receiver ()
    let v39 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v40 : int32 = v39?receiver ()
    let v41 : bool = v38 = v40
    let v42 : bool = (importAll "pyteal")?Assert v41
    let v43 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v44 : int32 = v43?amount ()
    let v45 : int32 = (importAll "pyteal")?App?globalGet v3
    let v46 : bool = v44 = v45
    let v47 : bool = (importAll "pyteal")?Assert v46
    let v48 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v49 : int32 = v48?amount ()
    let v50 : int32 = (importAll "pyteal")?App?globalGet v3
    let v51 : bool = v49 = v50
    let v52 : bool = (importAll "pyteal")?Assert v51
    let v53 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v54 : int32 = v53?sender ()
    let v55 : bool = (importAll "pyteal")?App?globalPut (v9, v54)
    let v56 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v57 : int32 = v56?sender ()
    let v58 : bool = (importAll "pyteal")?App?globalPut (v6, v57)
    let v59 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v60 : int32 = v59?sender ()
    let v61 : bool = (importAll "pyteal")?App?globalPut (v8, v60)
    let v62 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v63 : int32 = v62?receiver ()
    let v64 : bool = (importAll "pyteal")?App?globalPut (v4, v63)
    let v65 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v66 : int32 = v65 + v26
    let v67 : bool = (importAll "pyteal")?App?globalPut (v2, v66)
    let v68 : int32 = (importAll "pyteal")?Int 1
    let v69 : bool = (importAll "pyteal")?Return v68
    let v70 : (bool []) = [|v31; v36; v42; v47; v52; v55; v58; v61; v64; v67; v69|]
    let v71 : bool = (importAll "pyteal")?Seq v70
    let v72 : bool = v17?hasValue ()
    let v73 : bool = v19?hasValue ()
    let v74 : bool = (importAll "pyteal")?Or v72 v73
    let v75 : bool = (importAll "pyteal")?If v74 v23 v71
    let v76 : bool = (importAll "pyteal")?Seq([| box v17; box v19; box v75 |])
    v76
and closure3 () () : bool =
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
    printfn $"%A{v24}"
    let v71 : int32 = (importAll "pyteal")?Int 448
    let v72 : int32 = (importAll "pyteal")?BitwiseAnd v70 v71
    let v73 : int32 = (importAll "pyteal")?Int 448
    let v74 : bool = v72 = v73
    let v75 : int32 = (importAll "pyteal")?Int 56
    let v76 : int32 = (importAll "pyteal")?BitwiseAnd v70 v75
    let v77 : int32 = (importAll "pyteal")?Int 56
    let v78 : bool = v76 = v77
    let v79 : int32 = (importAll "pyteal")?Int 7
    let v80 : int32 = (importAll "pyteal")?BitwiseAnd v70 v79
    let v81 : int32 = (importAll "pyteal")?Int 7
    let v82 : bool = v80 = v81
    let v83 : int32 = (importAll "pyteal")?Int 292
    let v84 : int32 = (importAll "pyteal")?BitwiseAnd v70 v83
    let v85 : int32 = (importAll "pyteal")?Int 292
    let v86 : bool = v84 = v85
    let v87 : int32 = (importAll "pyteal")?Int 146
    let v88 : int32 = (importAll "pyteal")?BitwiseAnd v70 v87
    let v89 : int32 = (importAll "pyteal")?Int 146
    let v90 : bool = v88 = v89
    let v91 : int32 = (importAll "pyteal")?Int 73
    let v92 : int32 = (importAll "pyteal")?BitwiseAnd v70 v91
    let v93 : int32 = (importAll "pyteal")?Int 73
    let v94 : bool = v92 = v93
    let v95 : int32 = (importAll "pyteal")?Int 273
    let v96 : int32 = (importAll "pyteal")?BitwiseAnd v70 v95
    let v97 : int32 = (importAll "pyteal")?Int 273
    let v98 : bool = v96 = v97
    let v99 : int32 = (importAll "pyteal")?Int 84
    let v100 : int32 = (importAll "pyteal")?BitwiseAnd v70 v99
    let v101 : int32 = (importAll "pyteal")?Int 84
    let v102 : bool = v100 = v101
    let v103 : bool = (importAll "pyteal")?Or v74 v78 v82 v86 v90 v94 v98 v102
    let v104 : int32 = (importAll "pyteal")?Int 1
    let v105 : int32 = (importAll "pyteal")?Int 0
    let v106 : bool = (importAll "pyteal")?If v103 v104 v105
    let v107 : int32 = (importAll "pyteal")?Int 2
    let v108 : bool = (importAll "pyteal")?App?globalPut (v4, v107)
    let v109 : bool = (importAll "pyteal")?If v106 v108
    let v110 : int32 = (importAll "pyteal")?App?globalGet v8
    let v111 : bool = (importAll "pyteal")?App?globalPut (v7, v110)
    let v112 : (bool []) = [|v69; v109; v111|]
    let v113 : bool = (importAll "pyteal")?Seq v112
    let v114 : int32 = (importAll "pyteal")?Int 0
    let v115 : bool = v16 >= v114
    let v116 : bool = (importAll "pyteal")?Assert v115
    let v117 : int32 = (importAll "pyteal")?Int 8
    let v118 : bool = v16 <= v117
    let v119 : bool = (importAll "pyteal")?Assert v118
    let v120 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v121 : int32 = (importAll "pyteal")?App?globalGet v1
    let v122 : bool = v120 <= v121
    let v123 : bool = (importAll "pyteal")?Assert v122
    let v124 : int32 = (importAll "pyteal")?App?globalGet v4
    let v125 : bool = v124 = v12
    let v126 : bool = (importAll "pyteal")?Assert v125
    let v127 : int32 = (importAll "pyteal")?Txn?sender ()
    let v128 : int32 = (importAll "pyteal")?App?globalGet v7
    let v129 : bool = v127 = v128
    let v130 : bool = (importAll "pyteal")?Assert v129
    let v131 : int32 = (importAll "pyteal")?BitwiseAnd v17 v20
    let v132 : int32 = (importAll "pyteal")?Int 0
    let v133 : bool = v131 = v132
    let v134 : int32 = (importAll "pyteal")?BitwiseAnd v18 v20
    let v135 : int32 = (importAll "pyteal")?Int 0
    let v136 : bool = v134 = v135
    let v137 : bool = (importAll "pyteal")?And v133 v136
    let v138 : bool = (importAll "pyteal")?Assert v137
    let v139 : int32 = (importAll "pyteal")?Txn?sender ()
    let v140 : int32 = (importAll "pyteal")?App?globalGet v8
    let v141 : bool = v139 = v140
    let v142 : (bool []) = [|v141; v67|]
    let v143 : int32 = (importAll "pyteal")?Txn?sender ()
    let v144 : int32 = (importAll "pyteal")?App?globalGet v5
    let v145 : bool = v143 = v144
    let v146 : (bool []) = [|v145; v113|]
    let v147 : bool = (importAll "pyteal")?Cond v142 v146
    let v148 : string = "is_tie"
    printfn $"%A{v148}"
    let struct (v149 : string, v150 : string, v151 : string, v152 : string, v153 : string, v154 : string, v155 : string, v156 : string, v157 : string) = method0()
    let v158 : int32 = (importAll "pyteal")?App?globalGet v157
    let v159 : int32 = (importAll "pyteal")?App?globalGet v154
    let v160 : int32 = (importAll "pyteal")?Int 511
    let v161 : int32 = (importAll "pyteal")?BitwiseOr v158 v159
    let v162 : bool = v160 = v161
    let v163 : int32 = (importAll "pyteal")?Int 3
    let v164 : bool = (importAll "pyteal")?App?globalPut (v4, v163)
    let v165 : bool = (importAll "pyteal")?If v162 v164
    let v166 : int32 = (importAll "pyteal")?Int 1
    let v167 : bool = (importAll "pyteal")?Return v166
    let v168 : (bool []) = [|v116; v119; v123; v126; v130; v138; v147; v165; v167|]
    let v169 : bool = (importAll "pyteal")?Seq v168
    v169
and closure4 () () : bool =
    let v0 : string = "is_tie"
    printfn $"%A{v0}"
    let struct (v1 : string, v2 : string, v3 : string, v4 : string, v5 : string, v6 : string, v7 : string, v8 : string, v9 : string) = method0()
    let v10 : int32 = (importAll "pyteal")?App?globalGet v9
    let v11 : int32 = (importAll "pyteal")?App?globalGet v6
    let v12 : int32 = (importAll "pyteal")?Int 511
    let v13 : int32 = (importAll "pyteal")?BitwiseOr v10 v11
    let v14 : bool = v12 = v13
    v14
and closure5 () (v0 : int32) : bool =
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
    let v37 : bool = (importAll "pyteal")?If v34 v35 v36
    v37
and closure6 () (v0 : int32) : bool =
    let v1 : string = "game_funds_escrow"
    printfn $"%A{v1}"
    let v2 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 0)
    let v3 : int32 = v2?application_id ()
    let v4 : int32 = (importAll "pyteal")?Int v0
    let v5 : bool = v3 = v4
    let v6 : bool = (importAll "pyteal")?Assert v5
    let v7 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v8 : int32 = v7?fee ()
    let v9 : int32 = (importAll "pyteal")?Int 1000
    let v10 : bool = v8 <= v9
    let v11 : bool = (importAll "pyteal")?Assert v10
    let v12 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v13 : int32 = v12?asset_close_to ()
    let v14 : int32 = (importAll "pyteal")?Global?zero_address ()
    let v15 : bool = v13 = v14
    let v16 : bool = (importAll "pyteal")?Assert v15
    let v17 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v18 : int32 = v17?rekey_to ()
    let v19 : int32 = (importAll "pyteal")?Global?zero_address ()
    let v20 : bool = v18 = v19
    let v21 : bool = (importAll "pyteal")?Assert v20
    let v22 : (bool []) = [|v6; v11; v16; v21|]
    let v23 : bool = (importAll "pyteal")?Seq v22
    let v24 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 0)
    let v25 : int32 = v24?application_id ()
    let v26 : int32 = (importAll "pyteal")?Int v0
    let v27 : bool = v25 = v26
    let v28 : bool = (importAll "pyteal")?Assert v27
    let v29 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v30 : int32 = v29?fee ()
    let v31 : int32 = (importAll "pyteal")?Int 1000
    let v32 : bool = v30 <= v31
    let v33 : bool = (importAll "pyteal")?Assert v32
    let v34 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v35 : int32 = v34?asset_close_to ()
    let v36 : int32 = (importAll "pyteal")?Global?zero_address ()
    let v37 : bool = v35 = v36
    let v38 : bool = (importAll "pyteal")?Assert v37
    let v39 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v40 : int32 = v39?rekey_to ()
    let v41 : int32 = (importAll "pyteal")?Global?zero_address ()
    let v42 : bool = v40 = v41
    let v43 : bool = (importAll "pyteal")?Assert v42
    let v44 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v45 : int32 = v44?fee ()
    let v46 : int32 = (importAll "pyteal")?Int 1000
    let v47 : bool = v45 <= v46
    let v48 : bool = (importAll "pyteal")?Assert v47
    let v49 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v50 : int32 = v49?asset_close_to ()
    let v51 : int32 = (importAll "pyteal")?Global?zero_address ()
    let v52 : bool = v50 = v51
    let v53 : bool = (importAll "pyteal")?Assert v52
    let v54 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v55 : int32 = v54?rekey_to ()
    let v56 : int32 = (importAll "pyteal")?Global?zero_address ()
    let v57 : bool = v55 = v56
    let v58 : bool = (importAll "pyteal")?Assert v57
    let v59 : (bool []) = [|v28; v33; v38; v43; v48; v53; v58|]
    let v60 : bool = (importAll "pyteal")?Seq v59
    let v61 : int32 = (importAll "pyteal")?Global?group_size ()
    let v62 : int32 = (importAll "pyteal")?Int 2
    let v63 : bool = v61 = v62
    let v64 : (bool []) = [|v63; v23|]
    let v65 : int32 = (importAll "pyteal")?Global?group_size ()
    let v66 : int32 = (importAll "pyteal")?Int 3
    let v67 : bool = v65 = v66
    let v68 : (bool []) = [|v67; v60|]
    let v69 : bool = (importAll "pyteal")?Cond v64 v68
    let v70 : int32 = (importAll "pyteal")?Int 1
    let v71 : bool = (importAll "pyteal")?Return v70
    let v72 : (bool []) = [|v69; v71|]
    let v73 : bool = (importAll "pyteal")?Seq v72
    v73
and closure7 () () : bool =
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
    let v122 : bool = (importAll "pyteal")?Seq v121
    v122
and closure8 () () : bool =
    let v0 : string = "clear_program"
    printfn $"%A{v0}"
    let v1 : int32 = (importAll "pyteal")?Int 1
    let v2 : bool = (importAll "pyteal")?Return v1
    v2
let v0 : string = "main.spi Loaded"
printfn $"%A{v0}"
let v1 : (US0 -> bool) = closure0()
let v2 : (unit -> bool) = closure1()
let v3 : (US0 -> bool) = closure2()
let v4 : (unit -> bool) = closure3()
let v5 : (unit -> bool) = closure4()
let v6 : (int32 -> bool) = closure5()
let v7 : (int32 -> bool) = closure6()
let v8 : (unit -> bool) = closure7()
let v9 : (unit -> bool) = closure8()
()
