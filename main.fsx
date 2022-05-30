#r "nuget: Fable.Python"
open Fable.Core.PyInterop
open Fable.Core

type [<Struct>] US0 =
    | US0_0
    | US0_1 of f1_0 : int32
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
and closure0 () (v0 : US0) : bool =
    let v1 : string = "application_start"
    printfn $"%A{v1}"
    let v2 : string = (importAll "pyteal")?Bytes "SetupPlayers"
    let v3 : string = (importAll "pyteal")?Bytes "ActionMove"
    let v4 : string = (importAll "pyteal")?Bytes "MoneyRefund"
    let v5 : int32 = (importAll "pyteal")?Txn?application_id ()
    let v6 : int32 = (importAll "pyteal")?Int 0
    let v7 : bool = v5 = v6
    let v8 : string = ((importAll "pyteal")?Txn?application_args : string[]).[0]
    let v9 : bool = v8 = v2
    let v10 : string = "initialize_players_logic"
    printfn $"%A{v10}"
    let struct (v11 : string, v12 : string, v13 : string, v14 : string, v15 : string, v16 : string, v17 : string, v18 : string, v19 : string) = method0()
    let v20 : int32 = (importAll "pyteal")?Int 0
    let v21 : int32 = (importAll "pyteal")?Int 0
    let v22 : int32 = (importAll "pyteal")?Int 0
    let v23 : int32 = (importAll "pyteal")?Int 1000000
    let v24 : int32 = (importAll "pyteal")?Int 3600
    let v25 : int32 = (importAll "pyteal")?Int 0
    let v26 : int32 = (importAll "pyteal")?App?globalGetEx v25 v18
    let v27 : int32 = (importAll "pyteal")?Int 0
    let v28 : int32 = (importAll "pyteal")?App?globalGetEx v27 v15
    let v29 : int32 = (importAll "pyteal")?Int 0
    let v30 : bool = (importAll "pyteal")?Return v29
    let v31 : (bool []) = [|v30|]
    let v32 : bool = (importAll "pyteal")?Seq v31
    let v35 : int32 =
        match v0 with
        | US0_0 -> (* None *)
            v24
        | US0_1(v33) -> (* Some *)
            (importAll "pyteal")?Int v33
    let v36 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v37 : int32 = v36?type_enum ()
    let v38 : int32 = (importAll "pyteal")?TxnType?Payment
    let v39 : bool = v37 = v38
    let v40 : bool = (importAll "pyteal")?Assert v39
    let v41 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v42 : int32 = v41?type_enum ()
    let v43 : int32 = (importAll "pyteal")?TxnType?Payment
    let v44 : bool = v42 = v43
    let v45 : bool = (importAll "pyteal")?Assert v44
    let v46 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v47 : int32 = v46?receiver ()
    let v48 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v49 : int32 = v48?receiver ()
    let v50 : bool = v47 = v49
    let v51 : bool = (importAll "pyteal")?Assert v50
    let v52 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v53 : int32 = v52?amount ()
    let v54 : int32 = (importAll "pyteal")?App?globalGet v12
    let v55 : bool = v53 = v54
    let v56 : bool = (importAll "pyteal")?Assert v55
    let v57 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v58 : int32 = v57?amount ()
    let v59 : int32 = (importAll "pyteal")?App?globalGet v12
    let v60 : bool = v58 = v59
    let v61 : bool = (importAll "pyteal")?Assert v60
    let v62 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v63 : int32 = v62?sender ()
    let v64 : bool = (importAll "pyteal")?App?globalPut (v18, v63)
    let v65 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v66 : int32 = v65?sender ()
    let v67 : bool = (importAll "pyteal")?App?globalPut (v15, v66)
    let v68 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v69 : int32 = v68?sender ()
    let v70 : bool = (importAll "pyteal")?App?globalPut (v17, v69)
    let v71 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v72 : int32 = v71?receiver ()
    let v73 : bool = (importAll "pyteal")?App?globalPut (v13, v72)
    let v74 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v75 : int32 = v74 + v35
    let v76 : bool = (importAll "pyteal")?App?globalPut (v11, v75)
    let v77 : int32 = (importAll "pyteal")?Int 1
    let v78 : bool = (importAll "pyteal")?Return v77
    let v79 : (bool []) = [|v40; v45; v51; v56; v61; v64; v67; v70; v73; v76; v78|]
    let v80 : bool = (importAll "pyteal")?Seq v79
    let v81 : bool = v26?hasValue ()
    let v82 : bool = v28?hasValue ()
    let v83 : bool = (importAll "pyteal")?Or v81 v82
    let v84 : bool = (importAll "pyteal")?If v83 v32 v80
    let v85 : bool = (importAll "pyteal")?Seq([| box v26; box v28; box v84 |])
    let v86 : (bool []) = [|v9; v85|]
    let v87 : string = ((importAll "pyteal")?Txn?application_args : string[]).[0]
    let v88 : bool = v87 = v3
    let v89 : int32 = (importAll "pyteal")?Global?group_size ()
    let v90 : int32 = (importAll "pyteal")?Int 1
    let v91 : bool = v89 = v90
    let v92 : bool = (importAll "pyteal")?And v88 v91
    let v93 : string = "play_action_logic"
    printfn $"%A{v93}"
    let struct (v94 : string, v95 : string, v96 : string, v97 : string, v98 : string, v99 : string, v100 : string, v101 : string, v102 : string) = method0()
    let v103 : int32 = (importAll "pyteal")?Int 0
    let v104 : int32 = (importAll "pyteal")?Int 0
    let v105 : int32 = (importAll "pyteal")?Int 0
    let v106 : int32 = (importAll "pyteal")?Int 1000000
    let v107 : int32 = (importAll "pyteal")?Int 3600
    let v108 : string = ((importAll "pyteal")?Txn?application_args : string[]).[1]
    let v109 : int32 = (importAll "pyteal")?Btoi v108
    let v110 : int32 = (importAll "pyteal")?App?globalGet v102
    let v111 : int32 = (importAll "pyteal")?App?globalGet v99
    let v112 : int32 = (importAll "pyteal")?Int 1
    let v113 : int32 = (importAll "pyteal")?ShiftLeft v112 v109
    let v114 : int32 = (importAll "pyteal")?BitwiseOr v110 v113
    let v115 : bool = (importAll "pyteal")?App?globalPut (v102, v114)
    let v116 : int32 = (importAll "pyteal")?App?globalGet v102
    let v117 : string = "has_player_won"
    printfn $"%A{v117}"
    let v118 : int32 = (importAll "pyteal")?Int 448
    let v119 : int32 = (importAll "pyteal")?BitwiseAnd v116 v118
    let v120 : int32 = (importAll "pyteal")?Int 448
    let v121 : bool = v119 = v120
    let v122 : int32 = (importAll "pyteal")?Int 56
    let v123 : int32 = (importAll "pyteal")?BitwiseAnd v116 v122
    let v124 : int32 = (importAll "pyteal")?Int 56
    let v125 : bool = v123 = v124
    let v126 : int32 = (importAll "pyteal")?Int 7
    let v127 : int32 = (importAll "pyteal")?BitwiseAnd v116 v126
    let v128 : int32 = (importAll "pyteal")?Int 7
    let v129 : bool = v127 = v128
    let v130 : int32 = (importAll "pyteal")?Int 292
    let v131 : int32 = (importAll "pyteal")?BitwiseAnd v116 v130
    let v132 : int32 = (importAll "pyteal")?Int 292
    let v133 : bool = v131 = v132
    let v134 : int32 = (importAll "pyteal")?Int 146
    let v135 : int32 = (importAll "pyteal")?BitwiseAnd v116 v134
    let v136 : int32 = (importAll "pyteal")?Int 146
    let v137 : bool = v135 = v136
    let v138 : int32 = (importAll "pyteal")?Int 73
    let v139 : int32 = (importAll "pyteal")?BitwiseAnd v116 v138
    let v140 : int32 = (importAll "pyteal")?Int 73
    let v141 : bool = v139 = v140
    let v142 : int32 = (importAll "pyteal")?Int 273
    let v143 : int32 = (importAll "pyteal")?BitwiseAnd v116 v142
    let v144 : int32 = (importAll "pyteal")?Int 273
    let v145 : bool = v143 = v144
    let v146 : int32 = (importAll "pyteal")?Int 84
    let v147 : int32 = (importAll "pyteal")?BitwiseAnd v116 v146
    let v148 : int32 = (importAll "pyteal")?Int 84
    let v149 : bool = v147 = v148
    let v150 : bool = (importAll "pyteal")?Or v121 v125 v129 v133 v137 v141 v145 v149
    let v151 : int32 = (importAll "pyteal")?Int 1
    let v152 : int32 = (importAll "pyteal")?Int 0
    let v153 : bool = (importAll "pyteal")?If v150 v151 v152
    let v154 : int32 = (importAll "pyteal")?Int 1
    let v155 : bool = (importAll "pyteal")?App?globalPut (v97, v154)
    let v156 : bool = (importAll "pyteal")?If v153 v155
    let v157 : int32 = (importAll "pyteal")?App?globalGet v98
    let v158 : bool = (importAll "pyteal")?App?globalPut (v100, v157)
    let v159 : (bool []) = [|v115; v156; v158|]
    let v160 : bool = (importAll "pyteal")?Seq v159
    let v161 : int32 = (importAll "pyteal")?BitwiseOr v111 v113
    let v162 : bool = (importAll "pyteal")?App?globalPut (v99, v161)
    let v163 : int32 = (importAll "pyteal")?App?globalGet v99
    let v164 : string = "has_player_won"
    printfn $"%A{v164}"
    let v165 : int32 = (importAll "pyteal")?Int 448
    let v166 : int32 = (importAll "pyteal")?BitwiseAnd v163 v165
    let v167 : int32 = (importAll "pyteal")?Int 448
    let v168 : bool = v166 = v167
    let v169 : int32 = (importAll "pyteal")?Int 56
    let v170 : int32 = (importAll "pyteal")?BitwiseAnd v163 v169
    let v171 : int32 = (importAll "pyteal")?Int 56
    let v172 : bool = v170 = v171
    let v173 : int32 = (importAll "pyteal")?Int 7
    let v174 : int32 = (importAll "pyteal")?BitwiseAnd v163 v173
    let v175 : int32 = (importAll "pyteal")?Int 7
    let v176 : bool = v174 = v175
    let v177 : int32 = (importAll "pyteal")?Int 292
    let v178 : int32 = (importAll "pyteal")?BitwiseAnd v163 v177
    let v179 : int32 = (importAll "pyteal")?Int 292
    let v180 : bool = v178 = v179
    let v181 : int32 = (importAll "pyteal")?Int 146
    let v182 : int32 = (importAll "pyteal")?BitwiseAnd v163 v181
    let v183 : int32 = (importAll "pyteal")?Int 146
    let v184 : bool = v182 = v183
    let v185 : int32 = (importAll "pyteal")?Int 73
    let v186 : int32 = (importAll "pyteal")?BitwiseAnd v163 v185
    let v187 : int32 = (importAll "pyteal")?Int 73
    let v188 : bool = v186 = v187
    let v189 : int32 = (importAll "pyteal")?Int 273
    let v190 : int32 = (importAll "pyteal")?BitwiseAnd v163 v189
    let v191 : int32 = (importAll "pyteal")?Int 273
    let v192 : bool = v190 = v191
    let v193 : int32 = (importAll "pyteal")?Int 84
    let v194 : int32 = (importAll "pyteal")?BitwiseAnd v163 v193
    let v195 : int32 = (importAll "pyteal")?Int 84
    let v196 : bool = v194 = v195
    let v197 : bool = (importAll "pyteal")?Or v168 v172 v176 v180 v184 v188 v192 v196
    let v198 : int32 = (importAll "pyteal")?Int 1
    let v199 : int32 = (importAll "pyteal")?Int 0
    let v200 : bool = (importAll "pyteal")?If v197 v198 v199
    let v201 : int32 = (importAll "pyteal")?Int 2
    let v202 : bool = (importAll "pyteal")?App?globalPut (v97, v201)
    let v203 : bool = (importAll "pyteal")?If v200 v202
    let v204 : int32 = (importAll "pyteal")?App?globalGet v101
    let v205 : bool = (importAll "pyteal")?App?globalPut (v100, v204)
    let v206 : (bool []) = [|v162; v203; v205|]
    let v207 : bool = (importAll "pyteal")?Seq v206
    let v208 : int32 = (importAll "pyteal")?Int 0
    let v209 : bool = v109 >= v208
    let v210 : bool = (importAll "pyteal")?Assert v209
    let v211 : int32 = (importAll "pyteal")?Int 8
    let v212 : bool = v109 <= v211
    let v213 : bool = (importAll "pyteal")?Assert v212
    let v214 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v215 : int32 = (importAll "pyteal")?App?globalGet v94
    let v216 : bool = v214 <= v215
    let v217 : bool = (importAll "pyteal")?Assert v216
    let v218 : int32 = (importAll "pyteal")?App?globalGet v97
    let v219 : bool = v218 = v105
    let v220 : bool = (importAll "pyteal")?Assert v219
    let v221 : int32 = (importAll "pyteal")?Txn?sender ()
    let v222 : int32 = (importAll "pyteal")?App?globalGet v100
    let v223 : bool = v221 = v222
    let v224 : bool = (importAll "pyteal")?Assert v223
    let v225 : int32 = (importAll "pyteal")?BitwiseAnd v110 v113
    let v226 : int32 = (importAll "pyteal")?Int 0
    let v227 : bool = v225 = v226
    let v228 : int32 = (importAll "pyteal")?BitwiseAnd v111 v113
    let v229 : int32 = (importAll "pyteal")?Int 0
    let v230 : bool = v228 = v229
    let v231 : bool = (importAll "pyteal")?And v227 v230
    let v232 : bool = (importAll "pyteal")?Assert v231
    let v233 : int32 = (importAll "pyteal")?Txn?sender ()
    let v234 : int32 = (importAll "pyteal")?App?globalGet v101
    let v235 : bool = v233 = v234
    let v236 : (bool []) = [|v235; v160|]
    let v237 : int32 = (importAll "pyteal")?Txn?sender ()
    let v238 : int32 = (importAll "pyteal")?App?globalGet v98
    let v239 : bool = v237 = v238
    let v240 : (bool []) = [|v239; v207|]
    let v241 : bool = (importAll "pyteal")?Cond v236 v240
    let v242 : string = "is_tie"
    printfn $"%A{v242}"
    let struct (v243 : string, v244 : string, v245 : string, v246 : string, v247 : string, v248 : string, v249 : string, v250 : string, v251 : string) = method0()
    let v252 : int32 = (importAll "pyteal")?App?globalGet v251
    let v253 : int32 = (importAll "pyteal")?App?globalGet v248
    let v254 : int32 = (importAll "pyteal")?Int 511
    let v255 : int32 = (importAll "pyteal")?BitwiseOr v252 v253
    let v256 : bool = v254 = v255
    let v257 : int32 = (importAll "pyteal")?Int 3
    let v258 : bool = (importAll "pyteal")?App?globalPut (v97, v257)
    let v259 : bool = (importAll "pyteal")?If v256 v258
    let v260 : int32 = (importAll "pyteal")?Int 1
    let v261 : bool = (importAll "pyteal")?Return v260
    let v262 : (bool []) = [|v210; v213; v217; v220; v224; v232; v241; v259; v261|]
    let v263 : bool = (importAll "pyteal")?Seq v262
    let v264 : (bool []) = [|v92; v263|]
    let v265 : string = ((importAll "pyteal")?Txn?application_args : string[]).[0]
    let v266 : bool = v265 = v4
    let v267 : string = "money_refund_logic"
    printfn $"%A{v267}"
    let struct (v268 : string, v269 : string, v270 : string, v271 : string, v272 : string, v273 : string, v274 : string, v275 : string, v276 : string) = method0()
    let v277 : int32 = (importAll "pyteal")?App?globalGet v271
    let v278 : int32 = (importAll "pyteal")?Int 1
    let v279 : bool = v277 = v278
    let v280 : int32 = (importAll "pyteal")?App?globalGet v271
    let v281 : int32 = (importAll "pyteal")?Int 0
    let v282 : bool = v280 = v281
    let v283 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v284 : int32 = (importAll "pyteal")?App?globalGet v268
    let v285 : bool = v283 > v284
    let v286 : int32 = (importAll "pyteal")?App?globalGet v274
    let v287 : int32 = (importAll "pyteal")?App?globalGet v272
    let v288 : bool = v286 = v287
    let v289 : bool = (importAll "pyteal")?And v282 v285 v288
    let v290 : bool = (importAll "pyteal")?Or v279 v289
    let v291 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v292 : int32 = v291?receiver ()
    let v293 : int32 = (importAll "pyteal")?App?globalGet v275
    let v294 : bool = v292 = v293
    let v295 : bool = (importAll "pyteal")?Assert v294
    let v296 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v297 : int32 = v296?amount ()
    let v298 : int32 = (importAll "pyteal")?Int 2
    let v299 : int32 = (importAll "pyteal")?App?globalGet v269
    let v300 : int32 = v298 * v299
    let v301 : bool = v297 = v300
    let v302 : bool = (importAll "pyteal")?Assert v301
    let v303 : int32 = (importAll "pyteal")?Int 1
    let v304 : bool = (importAll "pyteal")?App?globalPut (v271, v303)
    let v305 : (bool []) = [|v295; v302; v304|]
    let v306 : bool = (importAll "pyteal")?Seq v305
    let v307 : int32 = (importAll "pyteal")?App?globalGet v271
    let v308 : int32 = (importAll "pyteal")?Int 2
    let v309 : bool = v307 = v308
    let v310 : int32 = (importAll "pyteal")?App?globalGet v271
    let v311 : int32 = (importAll "pyteal")?Int 0
    let v312 : bool = v310 = v311
    let v313 : int32 = (importAll "pyteal")?Global?latest_timestamp ()
    let v314 : int32 = (importAll "pyteal")?App?globalGet v268
    let v315 : bool = v313 > v314
    let v316 : int32 = (importAll "pyteal")?App?globalGet v274
    let v317 : int32 = (importAll "pyteal")?App?globalGet v275
    let v318 : bool = v316 = v317
    let v319 : bool = (importAll "pyteal")?And v312 v315 v318
    let v320 : bool = (importAll "pyteal")?Or v309 v319
    let v321 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v322 : int32 = v321?receiver ()
    let v323 : int32 = (importAll "pyteal")?App?globalGet v272
    let v324 : bool = v322 = v323
    let v325 : bool = (importAll "pyteal")?Assert v324
    let v326 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v327 : int32 = v326?amount ()
    let v328 : int32 = (importAll "pyteal")?Int 2
    let v329 : int32 = (importAll "pyteal")?App?globalGet v269
    let v330 : int32 = v328 * v329
    let v331 : bool = v327 = v330
    let v332 : bool = (importAll "pyteal")?Assert v331
    let v333 : int32 = (importAll "pyteal")?Int 2
    let v334 : bool = (importAll "pyteal")?App?globalPut (v271, v333)
    let v335 : (bool []) = [|v325; v332; v334|]
    let v336 : bool = (importAll "pyteal")?Seq v335
    let v337 : int32 = (importAll "pyteal")?App?globalGet v271
    let v338 : int32 = (importAll "pyteal")?Int 3
    let v339 : bool = v337 = v338
    let v340 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v341 : int32 = v340?receiver ()
    let v342 : int32 = (importAll "pyteal")?App?globalGet v275
    let v343 : bool = v341 = v342
    let v344 : bool = (importAll "pyteal")?Assert v343
    let v345 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v346 : int32 = v345?amount ()
    let v347 : int32 = (importAll "pyteal")?App?globalGet v269
    let v348 : bool = v346 = v347
    let v349 : bool = (importAll "pyteal")?Assert v348
    let v350 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v351 : int32 = v350?type_enum ()
    let v352 : int32 = (importAll "pyteal")?TxnType?Payment
    let v353 : bool = v351 = v352
    let v354 : bool = (importAll "pyteal")?Assert v353
    let v355 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v356 : int32 = v355?sender ()
    let v357 : int32 = (importAll "pyteal")?App?globalGet v270
    let v358 : bool = v356 = v357
    let v359 : bool = (importAll "pyteal")?Assert v358
    let v360 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v361 : int32 = v360?receiver ()
    let v362 : int32 = (importAll "pyteal")?App?globalGet v272
    let v363 : bool = v361 = v362
    let v364 : bool = (importAll "pyteal")?Assert v363
    let v365 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 2)
    let v366 : int32 = v365?amount ()
    let v367 : int32 = (importAll "pyteal")?App?globalGet v269
    let v368 : bool = v366 = v367
    let v369 : bool = (importAll "pyteal")?Assert v368
    let v370 : (bool []) = [|v344; v349; v354; v359; v364; v369|]
    let v371 : bool = (importAll "pyteal")?Seq v370
    let v372 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v373 : int32 = v372?type_enum ()
    let v374 : int32 = (importAll "pyteal")?TxnType?Payment
    let v375 : bool = v373 = v374
    let v376 : bool = (importAll "pyteal")?Assert v375
    let v377 : obj = (importAll "pyteal")?TxnGroup?__getitem__(import "Gtxn" "pyteal", 1)
    let v378 : int32 = v377?sender ()
    let v379 : int32 = (importAll "pyteal")?App?globalGet v270
    let v380 : bool = v378 = v379
    let v381 : bool = (importAll "pyteal")?Assert v380
    let v382 : (bool []) = [|v290; v306|]
    let v383 : (bool []) = [|v320; v336|]
    let v384 : (bool []) = [|v339; v371|]
    let v385 : bool = (importAll "pyteal")?Cond v382 v383 v384
    let v386 : int32 = (importAll "pyteal")?Int 1
    let v387 : bool = (importAll "pyteal")?Return v386
    let v388 : (bool []) = [|v376; v381; v385; v387|]
    let v389 : bool = (importAll "pyteal")?Seq v388
    let v390 : (bool []) = [|v266; v389|]
    let v391 : bool = (importAll "pyteal")?Cond v86 v264 v390
    let v392 : string = "app_initialization_logic"
    printfn $"%A{v392}"
    let v393 : int32 = (importAll "pyteal")?Int 0
    let v394 : int32 = (importAll "pyteal")?Int 0
    let v395 : int32 = (importAll "pyteal")?Int 0
    let v396 : int32 = (importAll "pyteal")?Int 1000000
    let v397 : int32 = (importAll "pyteal")?Int 3600
    let struct (v398 : string, v399 : string, v400 : string, v401 : string, v402 : string, v403 : string, v404 : string, v405 : string, v406 : string) = method0()
    let v407 : bool = (importAll "pyteal")?App?globalPut (v406, v393)
    let v408 : bool = (importAll "pyteal")?App?globalPut (v403, v394)
    let v409 : bool = (importAll "pyteal")?App?globalPut (v401, v395)
    let v410 : bool = (importAll "pyteal")?App?globalPut (v399, v396)
    let v411 : int32 = (importAll "pyteal")?Int 1
    let v412 : bool = (importAll "pyteal")?Return v411
    let v413 : (bool []) = [|v407; v408; v409; v410; v412|]
    let v414 : bool = (importAll "pyteal")?Seq v413
    (importAll "pyteal")?If v7 v414 v391
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
    (importAll "pyteal")?Seq v21
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
            (importAll "pyteal")?Int v24
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
    (importAll "pyteal")?Seq([| box v17; box v19; box v75 |])
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
and closure4 () () : bool =
    let v0 : string = "is_tie"
    printfn $"%A{v0}"
    let struct (v1 : string, v2 : string, v3 : string, v4 : string, v5 : string, v6 : string, v7 : string, v8 : string, v9 : string) = method0()
    let v10 : int32 = (importAll "pyteal")?App?globalGet v9
    let v11 : int32 = (importAll "pyteal")?App?globalGet v6
    let v12 : int32 = (importAll "pyteal")?Int 511
    let v13 : int32 = (importAll "pyteal")?BitwiseOr v10 v11
    v12 = v13
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
    (importAll "pyteal")?If v34 v35 v36
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
    (importAll "pyteal")?Seq v72
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
    (importAll "pyteal")?Seq v121
and closure8 () () : bool =
    let v0 : string = "clear_program"
    printfn $"%A{v0}"
    let v1 : int32 = (importAll "pyteal")?Int 1
    (importAll "pyteal")?Return v1
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
