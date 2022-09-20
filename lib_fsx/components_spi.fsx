#r "nuget: Feliz.JSX.Solid, 1.0.0-beta-001"
open System
open Fable.Core
open Fable.Core.JsInterop
open Feliz.JSX.Solid

type Mut0 = {mutable l0 : obj}
and [<Struct>] US0 =
    | US0_0
    | US0_1 of f1_0 : int32
and Heap0 = {l0 : US0}
and [<Struct>] US1 =
    | US1_0
    | US1_1 of f1_0 : bool
and [<Struct>] US2 =
    | US2_0
    | US2_1 of f1_0 : (obj -> ((obj -> unit) -> unit))
and [<Struct>] US3 =
    | US3_0
    | US3_1 of f1_0 : string
and [<Struct>] US4 =
    | US4_0
    | US4_1 of f1_0 : JS.Function
and [<Struct>] US5 =
    | US5_0
    | US5_1 of f1_0 : (unit -> JSX.Element)
and [<Struct>] US6 =
    | US6_0
    | US6_1 of f1_0 : JSX.Element
and [<Struct>] US7 =
    | US7_0
    | US7_1 of f1_0 : obj
and [<Struct>] US8 =
    | US8_0
    | US8_1 of f1_0 : (obj -> unit)
and [<Struct>] US9 =
    | US9_0
    | US9_1 of f1_0 : (unit -> unit)
and Heap1 = {l0 : US1; l1 : US1; l2 : US2; l3 : US3; l4 : US4; l5 : US3; l6 : US3; l7 : US3; l8 : US1; l9 : US5; l10 : US3; l11 : US3; l12 : US1; l13 : US3; l14 : US3; l15 : US1; l16 : US0; l17 : US3; l18 : US3; l19 : US3; l20 : US3; l21 : US6; l22 : US3; l23 : US3; l24 : US3; l25 : US7; l26 : US3; l27 : US3; l28 : US3; l29 : US3; l30 : US8; l31 : US9; l32 : US3; l33 : US3; l34 : US3; l35 : US3; l36 : US3; l37 : US3; l38 : US3; l39 : US3; l40 : US1; l41 : US3; l42 : US3; l43 : US6; l44 : US3; l45 : US3; l46 : US0}
and [<Struct>] US10 =
    | US10_0
    | US10_1 of f1_0 : JSX.Prop
and Mut1 = {mutable l0 : int32; mutable l1 : int32}
and Mut2 = {mutable l0 : int32}
and Mut3 = {mutable l0 : int32; mutable l1 : US1; mutable l2 : US1; mutable l3 : US2; mutable l4 : US3; mutable l5 : US4; mutable l6 : US3; mutable l7 : US3; mutable l8 : US3; mutable l9 : US1; mutable l10 : US5; mutable l11 : US3; mutable l12 : US3; mutable l13 : US1; mutable l14 : US3; mutable l15 : US3; mutable l16 : US1; mutable l17 : US0; mutable l18 : US3; mutable l19 : US3; mutable l20 : US3; mutable l21 : US3; mutable l22 : US6; mutable l23 : US3; mutable l24 : US3; mutable l25 : US3; mutable l26 : US7; mutable l27 : US3; mutable l28 : US3; mutable l29 : US3; mutable l30 : US3; mutable l31 : US8; mutable l32 : US9; mutable l33 : US3; mutable l34 : US3; mutable l35 : US3; mutable l36 : US3; mutable l37 : US3; mutable l38 : US3; mutable l39 : US3; mutable l40 : US3; mutable l41 : US1; mutable l42 : US3; mutable l43 : US3; mutable l44 : US6; mutable l45 : US3; mutable l46 : US3; mutable l47 : US0}
let rec method0 () : US0 =
    let v0 : US0 = US0_0
    v0
and closure0 (v0 : obj) (v1 : obj) : unit =
    let v2 : JS.Function = v1?on |> unbox<JS.Function>
    v2.Invoke ("@init", fun () -> v0) |> ignore
    v2.Invoke ("set", emitJsExpr () "(_, state) => state") |> ignore
    ()
and method1 (v0 : obj) : obj =
    let v1 : string = "createStoreon"
    let v2 : string = "storeon"
    let v3 : JS.Function = import v1 v2
    let v4 : (obj -> unit) = closure0(v0)
    let v5 : obj = v3.Invoke [| v4 |]
    v5
and method3 () : struct (US1 * US1 * US2 * US3 * US4 * US3 * US3 * US3 * US1 * US5 * US3 * US3 * US1 * US3 * US3 * US1 * US0 * US3 * US3 * US3 * US3 * US6 * US3 * US3 * US3 * US7 * US3 * US3 * US3 * US3 * US8 * US9 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US1 * US3 * US3 * US6 * US3 * US3 * US0) =
    let v0 : US1 = US1_0
    let v1 : US1 = US1_0
    let v2 : US2 = US2_0
    let v3 : US3 = US3_0
    let v4 : US4 = US4_0
    let v5 : US3 = US3_0
    let v6 : US3 = US3_0
    let v7 : US3 = US3_0
    let v8 : US1 = US1_0
    let v9 : US5 = US5_0
    let v10 : US3 = US3_0
    let v11 : US3 = US3_0
    let v12 : US1 = US1_0
    let v13 : US3 = US3_0
    let v14 : US3 = US3_0
    let v15 : US1 = US1_0
    let v16 : US0 = US0_0
    let v17 : US3 = US3_0
    let v18 : US3 = US3_0
    let v19 : US3 = US3_0
    let v20 : US3 = US3_0
    let v21 : US6 = US6_0
    let v22 : US3 = US3_0
    let v23 : US3 = US3_0
    let v24 : US3 = US3_0
    let v25 : US7 = US7_0
    let v26 : US3 = US3_0
    let v27 : US3 = US3_0
    let v28 : US3 = US3_0
    let v29 : US3 = US3_0
    let v30 : US8 = US8_0
    let v31 : US9 = US9_0
    let v32 : US3 = US3_0
    let v33 : US3 = US3_0
    let v34 : US3 = US3_0
    let v35 : US3 = US3_0
    let v36 : US3 = US3_0
    let v37 : US3 = US3_0
    let v38 : US3 = US3_0
    let v39 : US3 = US3_0
    let v40 : US1 = US1_0
    let v41 : US3 = US3_0
    let v42 : US3 = US3_0
    let v43 : US6 = US6_0
    let v44 : US3 = US3_0
    let v45 : US3 = US3_0
    let v46 : US0 = US0_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)
and method4 (v0 : Heap1, v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US1, v10 : US5, v11 : US3, v12 : US3, v13 : US1, v14 : US3, v15 : US3, v16 : US1, v17 : US0, v18 : US3, v19 : US3, v20 : US3, v21 : US3, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US7, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US8, v32 : US9, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US1, v42 : US3, v43 : US3, v44 : US6, v45 : US3, v46 : US3, v47 : US0) : Heap1 =
    let v48 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47} : Heap1
    let v49 : US1 = v0.l0
    let v50 : US1 = v48.l0
    let v57 : US1 =
        match v50 with
        | US1_0 -> (* None *)
            match v49 with
            | US1_0 -> (* None *)
                US1_0
            | US1_1(v52) -> (* Some *)
                US1_1(v52)
        | US1_1(v55) -> (* Some *)
            US1_1(v55)
    let v58 : US1 = v0.l1
    let v59 : US1 = v48.l1
    let v66 : US1 =
        match v59 with
        | US1_0 -> (* None *)
            match v58 with
            | US1_0 -> (* None *)
                US1_0
            | US1_1(v61) -> (* Some *)
                US1_1(v61)
        | US1_1(v64) -> (* Some *)
            US1_1(v64)
    let v67 : US2 = v0.l2
    let v68 : US2 = v48.l2
    let v75 : US2 =
        match v68 with
        | US2_0 -> (* None *)
            match v67 with
            | US2_0 -> (* None *)
                US2_0
            | US2_1(v70) -> (* Some *)
                US2_1(v70)
        | US2_1(v73) -> (* Some *)
            US2_1(v73)
    let v76 : US3 = v0.l3
    let v77 : US3 = v48.l3
    let v84 : US3 =
        match v77 with
        | US3_0 -> (* None *)
            match v76 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v79) -> (* Some *)
                US3_1(v79)
        | US3_1(v82) -> (* Some *)
            US3_1(v82)
    let v85 : US4 = v0.l4
    let v86 : US4 = v48.l4
    let v93 : US4 =
        match v86 with
        | US4_0 -> (* None *)
            match v85 with
            | US4_0 -> (* None *)
                US4_0
            | US4_1(v88) -> (* Some *)
                US4_1(v88)
        | US4_1(v91) -> (* Some *)
            US4_1(v91)
    let v94 : US3 = v0.l5
    let v95 : US3 = v48.l5
    let v102 : US3 =
        match v95 with
        | US3_0 -> (* None *)
            match v94 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v97) -> (* Some *)
                US3_1(v97)
        | US3_1(v100) -> (* Some *)
            US3_1(v100)
    let v103 : US3 = v0.l6
    let v104 : US3 = v48.l6
    let v111 : US3 =
        match v104 with
        | US3_0 -> (* None *)
            match v103 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v106) -> (* Some *)
                US3_1(v106)
        | US3_1(v109) -> (* Some *)
            US3_1(v109)
    let v112 : US3 = v0.l7
    let v113 : US3 = v48.l7
    let v120 : US3 =
        match v113 with
        | US3_0 -> (* None *)
            match v112 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v115) -> (* Some *)
                US3_1(v115)
        | US3_1(v118) -> (* Some *)
            US3_1(v118)
    let v121 : US3 = v0.l10
    let v122 : US3 = v48.l10
    let v129 : US3 =
        match v122 with
        | US3_0 -> (* None *)
            match v121 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v124) -> (* Some *)
                US3_1(v124)
        | US3_1(v127) -> (* Some *)
            US3_1(v127)
    let v130 : US1 = v0.l8
    let v131 : US1 = v48.l8
    let v138 : US1 =
        match v131 with
        | US1_0 -> (* None *)
            match v130 with
            | US1_0 -> (* None *)
                US1_0
            | US1_1(v133) -> (* Some *)
                US1_1(v133)
        | US1_1(v136) -> (* Some *)
            US1_1(v136)
    let v139 : US5 = v0.l9
    let v140 : US5 = v48.l9
    let v147 : US5 =
        match v140 with
        | US5_0 -> (* None *)
            match v139 with
            | US5_0 -> (* None *)
                US5_0
            | US5_1(v142) -> (* Some *)
                US5_1(v142)
        | US5_1(v145) -> (* Some *)
            US5_1(v145)
    let v148 : US3 = v0.l11
    let v149 : US3 = v48.l11
    let v156 : US3 =
        match v149 with
        | US3_0 -> (* None *)
            match v148 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v151) -> (* Some *)
                US3_1(v151)
        | US3_1(v154) -> (* Some *)
            US3_1(v154)
    let v157 : US1 = v0.l12
    let v158 : US1 = v48.l12
    let v165 : US1 =
        match v158 with
        | US1_0 -> (* None *)
            match v157 with
            | US1_0 -> (* None *)
                US1_0
            | US1_1(v160) -> (* Some *)
                US1_1(v160)
        | US1_1(v163) -> (* Some *)
            US1_1(v163)
    let v166 : US3 = v0.l13
    let v167 : US3 = v48.l13
    let v174 : US3 =
        match v167 with
        | US3_0 -> (* None *)
            match v166 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v169) -> (* Some *)
                US3_1(v169)
        | US3_1(v172) -> (* Some *)
            US3_1(v172)
    let v175 : US3 = v0.l14
    let v176 : US3 = v48.l14
    let v183 : US3 =
        match v176 with
        | US3_0 -> (* None *)
            match v175 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v178) -> (* Some *)
                US3_1(v178)
        | US3_1(v181) -> (* Some *)
            US3_1(v181)
    let v184 : US1 = v0.l15
    let v185 : US1 = v48.l15
    let v192 : US1 =
        match v185 with
        | US1_0 -> (* None *)
            match v184 with
            | US1_0 -> (* None *)
                US1_0
            | US1_1(v187) -> (* Some *)
                US1_1(v187)
        | US1_1(v190) -> (* Some *)
            US1_1(v190)
    let v193 : US0 = v0.l16
    let v194 : US0 = v48.l16
    let v201 : US0 =
        match v194 with
        | US0_0 -> (* None *)
            match v193 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v196) -> (* Some *)
                US0_1(v196)
        | US0_1(v199) -> (* Some *)
            US0_1(v199)
    let v202 : US3 = v0.l17
    let v203 : US3 = v48.l17
    let v210 : US3 =
        match v203 with
        | US3_0 -> (* None *)
            match v202 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v205) -> (* Some *)
                US3_1(v205)
        | US3_1(v208) -> (* Some *)
            US3_1(v208)
    let v211 : US3 = v0.l18
    let v212 : US3 = v48.l18
    let v219 : US3 =
        match v212 with
        | US3_0 -> (* None *)
            match v211 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v214) -> (* Some *)
                US3_1(v214)
        | US3_1(v217) -> (* Some *)
            US3_1(v217)
    let v220 : US3 = v0.l19
    let v221 : US3 = v48.l19
    let v228 : US3 =
        match v221 with
        | US3_0 -> (* None *)
            match v220 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v223) -> (* Some *)
                US3_1(v223)
        | US3_1(v226) -> (* Some *)
            US3_1(v226)
    let v229 : US3 = v0.l20
    let v230 : US3 = v48.l20
    let v237 : US3 =
        match v230 with
        | US3_0 -> (* None *)
            match v229 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v232) -> (* Some *)
                US3_1(v232)
        | US3_1(v235) -> (* Some *)
            US3_1(v235)
    let v238 : US6 = v0.l21
    let v239 : US6 = v48.l21
    let v246 : US6 =
        match v239 with
        | US6_0 -> (* None *)
            match v238 with
            | US6_0 -> (* None *)
                US6_0
            | US6_1(v241) -> (* Some *)
                US6_1(v241)
        | US6_1(v244) -> (* Some *)
            US6_1(v244)
    let v247 : US3 = v0.l22
    let v248 : US3 = v48.l22
    let v255 : US3 =
        match v248 with
        | US3_0 -> (* None *)
            match v247 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v250) -> (* Some *)
                US3_1(v250)
        | US3_1(v253) -> (* Some *)
            US3_1(v253)
    let v256 : US1 = v0.l40
    let v257 : US1 = v48.l40
    let v264 : US1 =
        match v257 with
        | US1_0 -> (* None *)
            match v256 with
            | US1_0 -> (* None *)
                US1_0
            | US1_1(v259) -> (* Some *)
                US1_1(v259)
        | US1_1(v262) -> (* Some *)
            US1_1(v262)
    let v265 : US3 = v0.l23
    let v266 : US3 = v48.l23
    let v273 : US3 =
        match v266 with
        | US3_0 -> (* None *)
            match v265 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v268) -> (* Some *)
                US3_1(v268)
        | US3_1(v271) -> (* Some *)
            US3_1(v271)
    let v274 : US3 = v0.l24
    let v275 : US3 = v48.l24
    let v282 : US3 =
        match v275 with
        | US3_0 -> (* None *)
            match v274 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v277) -> (* Some *)
                US3_1(v277)
        | US3_1(v280) -> (* Some *)
            US3_1(v280)
    let v283 : US7 = v0.l25
    let v284 : US7 = v48.l25
    let v291 : US7 =
        match v284 with
        | US7_0 -> (* None *)
            match v283 with
            | US7_0 -> (* None *)
                US7_0
            | US7_1(v286) -> (* Some *)
                US7_1(v286)
        | US7_1(v289) -> (* Some *)
            US7_1(v289)
    let v292 : US3 = v0.l26
    let v293 : US3 = v48.l26
    let v300 : US3 =
        match v293 with
        | US3_0 -> (* None *)
            match v292 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v295) -> (* Some *)
                US3_1(v295)
        | US3_1(v298) -> (* Some *)
            US3_1(v298)
    let v301 : US3 = v0.l27
    let v302 : US3 = v48.l27
    let v309 : US3 =
        match v302 with
        | US3_0 -> (* None *)
            match v301 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v304) -> (* Some *)
                US3_1(v304)
        | US3_1(v307) -> (* Some *)
            US3_1(v307)
    let v310 : US3 = v0.l28
    let v311 : US3 = v48.l28
    let v318 : US3 =
        match v311 with
        | US3_0 -> (* None *)
            match v310 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v313) -> (* Some *)
                US3_1(v313)
        | US3_1(v316) -> (* Some *)
            US3_1(v316)
    let v319 : US3 = v0.l29
    let v320 : US3 = v48.l29
    let v327 : US3 =
        match v320 with
        | US3_0 -> (* None *)
            match v319 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v322) -> (* Some *)
                US3_1(v322)
        | US3_1(v325) -> (* Some *)
            US3_1(v325)
    let v328 : US8 = v0.l30
    let v329 : US8 = v48.l30
    let v336 : US8 =
        match v329 with
        | US8_0 -> (* None *)
            match v328 with
            | US8_0 -> (* None *)
                US8_0
            | US8_1(v331) -> (* Some *)
                US8_1(v331)
        | US8_1(v334) -> (* Some *)
            US8_1(v334)
    let v337 : US9 = v0.l31
    let v338 : US9 = v48.l31
    let v345 : US9 =
        match v338 with
        | US9_0 -> (* None *)
            match v337 with
            | US9_0 -> (* None *)
                US9_0
            | US9_1(v340) -> (* Some *)
                US9_1(v340)
        | US9_1(v343) -> (* Some *)
            US9_1(v343)
    let v346 : US3 = v0.l32
    let v347 : US3 = v48.l32
    let v354 : US3 =
        match v347 with
        | US3_0 -> (* None *)
            match v346 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v349) -> (* Some *)
                US3_1(v349)
        | US3_1(v352) -> (* Some *)
            US3_1(v352)
    let v355 : US3 = v0.l33
    let v356 : US3 = v48.l33
    let v363 : US3 =
        match v356 with
        | US3_0 -> (* None *)
            match v355 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v358) -> (* Some *)
                US3_1(v358)
        | US3_1(v361) -> (* Some *)
            US3_1(v361)
    let v364 : US3 = v0.l34
    let v365 : US3 = v48.l34
    let v372 : US3 =
        match v365 with
        | US3_0 -> (* None *)
            match v364 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v367) -> (* Some *)
                US3_1(v367)
        | US3_1(v370) -> (* Some *)
            US3_1(v370)
    let v373 : US3 = v0.l35
    let v374 : US3 = v48.l35
    let v381 : US3 =
        match v374 with
        | US3_0 -> (* None *)
            match v373 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v376) -> (* Some *)
                US3_1(v376)
        | US3_1(v379) -> (* Some *)
            US3_1(v379)
    let v382 : US3 = v0.l36
    let v383 : US3 = v48.l36
    let v390 : US3 =
        match v383 with
        | US3_0 -> (* None *)
            match v382 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v385) -> (* Some *)
                US3_1(v385)
        | US3_1(v388) -> (* Some *)
            US3_1(v388)
    let v391 : US3 = v0.l37
    let v392 : US3 = v48.l37
    let v399 : US3 =
        match v392 with
        | US3_0 -> (* None *)
            match v391 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v394) -> (* Some *)
                US3_1(v394)
        | US3_1(v397) -> (* Some *)
            US3_1(v397)
    let v400 : US3 = v0.l38
    let v401 : US3 = v48.l38
    let v408 : US3 =
        match v401 with
        | US3_0 -> (* None *)
            match v400 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v403) -> (* Some *)
                US3_1(v403)
        | US3_1(v406) -> (* Some *)
            US3_1(v406)
    let v409 : US3 = v0.l39
    let v410 : US3 = v48.l39
    let v417 : US3 =
        match v410 with
        | US3_0 -> (* None *)
            match v409 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v412) -> (* Some *)
                US3_1(v412)
        | US3_1(v415) -> (* Some *)
            US3_1(v415)
    let v418 : US3 = v0.l41
    let v419 : US3 = v48.l41
    let v426 : US3 =
        match v419 with
        | US3_0 -> (* None *)
            match v418 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v421) -> (* Some *)
                US3_1(v421)
        | US3_1(v424) -> (* Some *)
            US3_1(v424)
    let v427 : US3 = v0.l42
    let v428 : US3 = v48.l42
    let v435 : US3 =
        match v428 with
        | US3_0 -> (* None *)
            match v427 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v430) -> (* Some *)
                US3_1(v430)
        | US3_1(v433) -> (* Some *)
            US3_1(v433)
    let v436 : US6 = v0.l43
    let v437 : US6 = v48.l43
    let v444 : US6 =
        match v437 with
        | US6_0 -> (* None *)
            match v436 with
            | US6_0 -> (* None *)
                US6_0
            | US6_1(v439) -> (* Some *)
                US6_1(v439)
        | US6_1(v442) -> (* Some *)
            US6_1(v442)
    let v445 : US3 = v0.l44
    let v446 : US3 = v48.l44
    let v453 : US3 =
        match v446 with
        | US3_0 -> (* None *)
            match v445 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v448) -> (* Some *)
                US3_1(v448)
        | US3_1(v451) -> (* Some *)
            US3_1(v451)
    let v454 : US3 = v0.l45
    let v455 : US3 = v48.l45
    let v462 : US3 =
        match v455 with
        | US3_0 -> (* None *)
            match v454 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v457) -> (* Some *)
                US3_1(v457)
        | US3_1(v460) -> (* Some *)
            US3_1(v460)
    let v463 : US0 = v0.l46
    let v464 : US0 = v48.l46
    let v471 : US0 =
        match v464 with
        | US0_0 -> (* None *)
            match v463 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v466) -> (* Some *)
                US0_1(v466)
        | US0_1(v469) -> (* Some *)
            US0_1(v469)
    {l0 = v57; l1 = v66; l2 = v75; l3 = v84; l4 = v93; l5 = v102; l6 = v111; l7 = v120; l8 = v138; l9 = v147; l10 = v129; l11 = v156; l12 = v165; l13 = v174; l14 = v183; l15 = v192; l16 = v201; l17 = v210; l18 = v219; l19 = v228; l20 = v237; l21 = v246; l22 = v255; l23 = v273; l24 = v282; l25 = v291; l26 = v300; l27 = v309; l28 = v318; l29 = v327; l30 = v336; l31 = v345; l32 = v354; l33 = v363; l34 = v372; l35 = v381; l36 = v390; l37 = v399; l38 = v408; l39 = v417; l40 = v264; l41 = v426; l42 = v435; l43 = v444; l44 = v453; l45 = v462; l46 = v471} : Heap1
and method6 (v0 : string, v1 : US3) : US10 =
    match v1 with
    | US3_0 -> (* None *)
        US10_0
    | US3_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US10_1(v4)
and method7 (v0 : string, v1 : US4) : US10 =
    match v1 with
    | US4_0 -> (* None *)
        US10_0
    | US4_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US10_1(v4)
and method8 (v0 : string, v1 : US1) : US10 =
    match v1 with
    | US1_0 -> (* None *)
        US10_0
    | US1_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US10_1(v4)
and method9 (v0 : string, v1 : US5) : US10 =
    match v1 with
    | US5_0 -> (* None *)
        US10_0
    | US5_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US10_1(v4)
and method10 (v0 : string, v1 : US0) : US10 =
    match v1 with
    | US0_0 -> (* None *)
        US10_0
    | US0_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US10_1(v4)
and method11 (v0 : string, v1 : US6) : US10 =
    match v1 with
    | US6_0 -> (* None *)
        US10_0
    | US6_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US10_1(v4)
and method12 (v0 : string, v1 : US7) : US10 =
    match v1 with
    | US7_0 -> (* None *)
        US10_0
    | US7_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US10_1(v4)
and method13 (v0 : string, v1 : US8) : US10 =
    match v1 with
    | US8_0 -> (* None *)
        US10_0
    | US8_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US10_1(v4)
and method14 (v0 : string, v1 : US9) : US10 =
    match v1 with
    | US9_0 -> (* None *)
        US10_0
    | US9_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US10_1(v4)
and method15 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method16 (v0 : int32, v1 : Mut2) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method5 (v0 : Heap1) : (JSX.Prop []) =
    let v1 : string = "aria-label"
    let v2 : US3 = v0.l3
    let v3 : US10 = method6(v1, v2)
    let v4 : string = "as"
    let v5 : US4 = v0.l4
    let v6 : US10 = method7(v4, v5)
    let v7 : string = "backgroundColor"
    let v8 : US3 = v0.l5
    let v9 : US10 = method6(v7, v8)
    let v10 : string = "border"
    let v11 : US3 = v0.l6
    let v12 : US10 = method6(v10, v11)
    let v13 : string = "bottom"
    let v14 : US3 = v0.l7
    let v15 : US10 = method6(v13, v14)
    let v16 : string = "color"
    let v17 : US3 = v0.l10
    let v18 : US10 = method6(v16, v17)
    let v19 : string = "checked"
    let v20 : US1 = v0.l8
    let v21 : US10 = method8(v19, v20)
    let v22 : string = "children"
    let v23 : US5 = v0.l9
    let v24 : US10 = method9(v22, v23)
    let v25 : string = "colorScheme"
    let v26 : US3 = v0.l11
    let v27 : US10 = method6(v25, v26)
    let v28 : string = "compact"
    let v29 : US1 = v0.l12
    let v30 : US10 = method8(v28, v29)
    let v31 : string = "display"
    let v32 : US3 = v0.l14
    let v33 : US10 = method6(v31, v32)
    let v34 : string = "direction"
    let v35 : US3 = v0.l13
    let v36 : US10 = method6(v34, v35)
    let v37 : string = "external"
    let v38 : US1 = v0.l15
    let v39 : US10 = method8(v37, v38)
    let v40 : string = "flex"
    let v41 : US0 = v0.l16
    let v42 : US10 = method10(v40, v41)
    let v43 : string = "flexDirection"
    let v44 : US3 = v0.l17
    let v45 : US10 = method6(v43, v44)
    let v46 : string = "fontSize"
    let v47 : US3 = v0.l18
    let v48 : US10 = method6(v46, v47)
    let v49 : string = "height"
    let v50 : US3 = v0.l19
    let v51 : US10 = method6(v49, v50)
    let v52 : string = "href"
    let v53 : US3 = v0.l20
    let v54 : US10 = method6(v52, v53)
    let v55 : string = "icon"
    let v56 : US6 = v0.l21
    let v57 : US10 = method11(v55, v56)
    let v58 : string = "id"
    let v59 : US3 = v0.l22
    let v60 : US10 = method6(v58, v59)
    let v61 : string = "justifyContent"
    let v62 : US3 = v0.l23
    let v63 : US10 = method6(v61, v62)
    let v64 : string = "left"
    let v65 : US3 = v0.l24
    let v66 : US10 = method6(v64, v65)
    let v67 : string = "leftIcon"
    let v68 : US7 = v0.l25
    let v69 : US10 = method12(v67, v68)
    let v70 : string = "lineHeight"
    let v71 : US3 = v0.l26
    let v72 : US10 = method6(v70, v71)
    let v73 : string = "margin"
    let v74 : US3 = v0.l27
    let v75 : US10 = method6(v73, v74)
    let v76 : string = "marginBottom"
    let v77 : US3 = v0.l28
    let v78 : US10 = method6(v76, v77)
    let v79 : string = "maxHeight"
    let v80 : US3 = v0.l29
    let v81 : US10 = method6(v79, v80)
    let v82 : string = "onChange"
    let v83 : US8 = v0.l30
    let v84 : US10 = method13(v82, v83)
    let v85 : string = "onClick"
    let v86 : US9 = v0.l31
    let v87 : US10 = method14(v85, v86)
    let v88 : string = "outline"
    let v89 : US3 = v0.l32
    let v90 : US10 = method6(v88, v89)
    let v91 : string = "overflowY"
    let v92 : US3 = v0.l33
    let v93 : US10 = method6(v91, v92)
    let v94 : string = "padding"
    let v95 : US3 = v0.l34
    let v96 : US10 = method6(v94, v95)
    let v97 : string = "paddingTop"
    let v98 : US3 = v0.l35
    let v99 : US10 = method6(v97, v98)
    let v100 : string = "position"
    let v101 : US3 = v0.l36
    let v102 : US10 = method6(v100, v101)
    let v103 : string = "right"
    let v104 : US3 = v0.l37
    let v105 : US10 = method6(v103, v104)
    let v106 : string = "size"
    let v107 : US3 = v0.l38
    let v108 : US10 = method6(v106, v107)
    let v109 : string = "spacing"
    let v110 : US3 = v0.l39
    let v111 : US10 = method6(v109, v110)
    let v112 : string = "status"
    let v113 : US1 = v0.l40
    let v114 : US10 = method8(v112, v113)
    let v115 : string = "striped"
    let v116 : US3 = v0.l41
    let v117 : US10 = method6(v115, v116)
    let v118 : string = "thickness"
    let v119 : US3 = v0.l42
    let v120 : US10 = method6(v118, v119)
    let v121 : string = "title"
    let v122 : US6 = v0.l43
    let v123 : US10 = method11(v121, v122)
    let v124 : string = "top"
    let v125 : US3 = v0.l44
    let v126 : US10 = method6(v124, v125)
    let v127 : string = "width"
    let v128 : US3 = v0.l45
    let v129 : US10 = method6(v127, v128)
    let v130 : string = "zIndex"
    let v131 : US0 = v0.l46
    let v132 : US10 = method10(v130, v131)
    let v133 : (US10 []) = [|v3; v6; v9; v12; v15; v18; v21; v24; v27; v30; v33; v36; v39; v42; v45; v48; v51; v54; v57; v60; v63; v66; v69; v72; v75; v78; v81; v84; v87; v90; v93; v96; v99; v102; v105; v108; v111; v114; v117; v120; v123; v126; v129; v132|]
    let v134 : int32 = v133.Length
    let v135 : (US10 []) = Array.zeroCreate<US10> (v134)
    let v136 : Mut1 = {l0 = 0; l1 = 0} : Mut1
    while method15(v134, v136) do
        let v138 : int32 = v136.l0
        let v139 : int32 = v136.l1
        let v140 : US10 = v133.[int v138]
        let v142 : bool =
            match v140 with
            | US10_0 -> (* None *)
                false
            | US10_1(v141) -> (* Some *)
                true
        let v144 : int32 =
            if v142 then
                v135.[int v139] <- v140
                let v143 : int32 = v139 + 1
                v143
            else
                v139
        let v145 : int32 = v138 + 1
        v136.l0 <- v145
        v136.l1 <- v144
        ()
    let v146 : int32 = v136.l1
    let v147 : (US10 []) = Array.zeroCreate<US10> (v146)
    let v148 : Mut2 = {l0 = 0} : Mut2
    while method16(v146, v148) do
        let v150 : int32 = v148.l0
        let v151 : US10 = v135.[int v150]
        v147.[int v150] <- v151
        let v152 : int32 = v150 + 1
        v148.l0 <- v152
        ()
    let v153 : int32 = v147.Length
    let v154 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v153)
    let v155 : Mut2 = {l0 = 0} : Mut2
    while method16(v153, v155) do
        let v157 : int32 = v155.l0
        let v158 : US10 = v147.[int v157]
        let v161 : JSX.Prop =
            match v158 with
            | US10_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US10_1(v160) -> (* Some *)
                v160
        v154.[int v157] <- v161
        let v162 : int32 = v157 + 1
        v155.l0 <- v162
        ()
    v154
and method2 (v0 : Heap1) : JSX.Element =
    let struct (v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US1, v10 : US5, v11 : US3, v12 : US3, v13 : US1, v14 : US3, v15 : US3, v16 : US1, v17 : US0, v18 : US3, v19 : US3, v20 : US3, v21 : US3, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US7, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US8, v32 : US9, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US1, v42 : US3, v43 : US3, v44 : US6, v45 : US3, v46 : US3, v47 : US0) = method3()
    let v48 : string = "neutral"
    let v49 : US3 = US3_1(v48)
    let v50 : bool = true
    let v51 : US1 = US1_1(v50)
    let v52 : string = "left"
    let v53 : US3 = US3_1(v52)
    let v54 : string = "xs"
    let v55 : US3 = US3_1(v54)
    let v56 : Heap1 = method4(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v49, v51, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v53, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v55, v40, v41, v42, v43, v44, v45, v46, v47)
    let v57 : (JSX.Prop []) = method5(v56)
    let v58 : obj = createObj v57
    let v59 : string = "createComponent"
    let v60 : string = "solid-js"
    let v61 : JS.Function = import v59 v60
    let v62 : string = "Button"
    let v63 : string = "@hope-ui/solid"
    let v64 : JSX.Element = v61.Invoke ((import v62 v63), v58) |> unbox<JSX.Element>
    v64
and closure1 () (v0 : Heap1) : JSX.Element =
    method2(v0)
and closure3 (v0 : Heap1, v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US1, v10 : US5, v11 : US3, v12 : US3, v13 : US1, v14 : US3, v15 : US3, v16 : US1, v17 : US0, v18 : US3, v19 : US3, v20 : US3, v21 : US3, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US7, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US8, v32 : US9, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US1, v42 : US3, v43 : US3, v44 : US6, v45 : US3, v46 : US3, v47 : US0) () : JSX.Element =
    let v48 : US5 = v0.l9
    let v49 : string = "flex"
    let v50 : US3 = US3_1(v49)
    let v51 : string = "column"
    let v52 : US3 = US3_1(v51)
    let v53 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v48; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v50; l15 = v16; l16 = v17; l17 = v52; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47} : Heap1
    let v54 : (JSX.Prop []) = method5(v53)
    let v55 : obj = createObj v54
    let v56 : string = "createComponent"
    let v57 : string = "solid-js"
    let v58 : JS.Function = import v56 v57
    let v59 : string = "Tbody"
    let v60 : string = "@hope-ui/solid"
    let v61 : JSX.Element = v58.Invoke ((import v59 v60), v55) |> unbox<JSX.Element>
    let v62 : (JSX.Element []) = [|v61|]
    let v63 : JSX.Element = v62 |> unbox<JSX.Element>
    v63
and method17 (v0 : Heap1) : JSX.Element =
    let struct (v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US1, v10 : US5, v11 : US3, v12 : US3, v13 : US1, v14 : US3, v15 : US3, v16 : US1, v17 : US0, v18 : US3, v19 : US3, v20 : US3, v21 : US3, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US7, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US8, v32 : US9, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US1, v42 : US3, v43 : US3, v44 : US6, v45 : US3, v46 : US3, v47 : US0) = method3()
    let v48 : (unit -> JSX.Element) = closure3(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47)
    let v49 : US5 = US5_1(v48)
    let v50 : string = "flex"
    let v51 : US3 = US3_1(v50)
    let v52 : US0 = US0_1(1)
    let v53 : string = "column"
    let v54 : US3 = US3_1(v53)
    let v55 : string = "odd"
    let v56 : US3 = US3_1(v55)
    let v57 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v49; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v51; l15 = v16; l16 = v52; l17 = v54; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v56; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47} : Heap1
    let v58 : (JSX.Prop []) = method5(v57)
    let v59 : obj = createObj v58
    let v60 : string = "createComponent"
    let v61 : string = "solid-js"
    let v62 : JS.Function = import v60 v61
    let v63 : string = "Table"
    let v64 : string = "@hope-ui/solid"
    let v65 : JSX.Element = v62.Invoke ((import v63 v64), v59) |> unbox<JSX.Element>
    v65
and closure2 () (v0 : Heap1) : JSX.Element =
    method17(v0)
and method19 (v0 : int32, v1 : Mut3) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method18 (v0 : (struct (string * obj) [])) : Heap1 =
    let struct (v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US1, v10 : US5, v11 : US3, v12 : US3, v13 : US1, v14 : US3, v15 : US3, v16 : US1, v17 : US0, v18 : US3, v19 : US3, v20 : US3, v21 : US3, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US7, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US8, v32 : US9, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US1, v42 : US3, v43 : US3, v44 : US6, v45 : US3, v46 : US3, v47 : US0) = method3()
    let v48 : int32 = v0.Length
    let v49 : Mut3 = {l0 = 0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47} : Mut3
    while method19(v48, v49) do
        let v51 : int32 = v49.l0
        let struct (v52 : US1, v53 : US1, v54 : US2, v55 : US3, v56 : US4, v57 : US3, v58 : US3, v59 : US3, v60 : US1, v61 : US5, v62 : US3, v63 : US3, v64 : US1, v65 : US3, v66 : US3, v67 : US1, v68 : US0, v69 : US3, v70 : US3, v71 : US3, v72 : US3, v73 : US6, v74 : US3, v75 : US3, v76 : US3, v77 : US7, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US8, v83 : US9, v84 : US3, v85 : US3, v86 : US3, v87 : US3, v88 : US3, v89 : US3, v90 : US3, v91 : US3, v92 : US1, v93 : US3, v94 : US3, v95 : US6, v96 : US3, v97 : US3, v98 : US0) = v49.l1, v49.l2, v49.l3, v49.l4, v49.l5, v49.l6, v49.l7, v49.l8, v49.l9, v49.l10, v49.l11, v49.l12, v49.l13, v49.l14, v49.l15, v49.l16, v49.l17, v49.l18, v49.l19, v49.l20, v49.l21, v49.l22, v49.l23, v49.l24, v49.l25, v49.l26, v49.l27, v49.l28, v49.l29, v49.l30, v49.l31, v49.l32, v49.l33, v49.l34, v49.l35, v49.l36, v49.l37, v49.l38, v49.l39, v49.l40, v49.l41, v49.l42, v49.l43, v49.l44, v49.l45, v49.l46, v49.l47
        let struct (v99 : string, v100 : obj) = v0.[int v51]
        let v101 : bool = v100 = JS.undefined
        let struct (v2500 : US1, v2501 : US1, v2502 : US2, v2503 : US3, v2504 : US4, v2505 : US3, v2506 : US3, v2507 : US3, v2508 : US1, v2509 : US5, v2510 : US3, v2511 : US3, v2512 : US1, v2513 : US3, v2514 : US3, v2515 : US1, v2516 : US0, v2517 : US3, v2518 : US3, v2519 : US3, v2520 : US3, v2521 : US6, v2522 : US3, v2523 : US3, v2524 : US3, v2525 : US7, v2526 : US3, v2527 : US3, v2528 : US3, v2529 : US3, v2530 : US8, v2531 : US9, v2532 : US3, v2533 : US3, v2534 : US3, v2535 : US3, v2536 : US3, v2537 : US3, v2538 : US3, v2539 : US3, v2540 : US1, v2541 : US3, v2542 : US3, v2543 : US6, v2544 : US3, v2545 : US3, v2546 : US0) =
            if v101 then
                struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
            else
                let v102 : bool = "_loaded" = v99
                if v102 then
                    let v103 : bool = v100 |> unbox
                    let v104 : US1 = US1_1(v103)
                    struct (v104, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                else
                    let v105 : bool = "_modal" = v99
                    if v105 then
                        let v106 : bool = v100 |> unbox
                        let v107 : US1 = US1_1(v106)
                        struct (v52, v107, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                    else
                        let v108 : bool = "_on_load" = v99
                        if v108 then
                            let v109 : (obj -> ((obj -> unit) -> unit)) = v100 |> unbox
                            let v110 : US2 = US2_1(v109)
                            struct (v52, v53, v110, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                        else
                            let v111 : bool = "aria-label" = v99
                            if v111 then
                                let v112 : string = v100 |> unbox
                                let v113 : US3 = US3_1(v112)
                                struct (v52, v53, v54, v113, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                            else
                                let v114 : bool = "as" = v99
                                if v114 then
                                    let v115 : JS.Function = v100 |> unbox
                                    let v116 : US4 = US4_1(v115)
                                    struct (v52, v53, v54, v55, v116, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                else
                                    let v117 : bool = "backgroundColor" = v99
                                    if v117 then
                                        let v118 : string = v100 |> unbox
                                        let v119 : US3 = US3_1(v118)
                                        struct (v52, v53, v54, v55, v56, v119, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                    else
                                        let v120 : bool = "border" = v99
                                        if v120 then
                                            let v121 : string = v100 |> unbox
                                            let v122 : US3 = US3_1(v121)
                                            struct (v52, v53, v54, v55, v56, v57, v122, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                        else
                                            let v123 : bool = "bottom" = v99
                                            if v123 then
                                                let v124 : string = v100 |> unbox
                                                let v125 : US3 = US3_1(v124)
                                                struct (v52, v53, v54, v55, v56, v57, v58, v125, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                            else
                                                let v126 : bool = "color" = v99
                                                if v126 then
                                                    let v127 : string = v100 |> unbox
                                                    let v128 : US3 = US3_1(v127)
                                                    struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v128, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                else
                                                    let v129 : bool = "checked" = v99
                                                    if v129 then
                                                        let v130 : bool = v100 |> unbox
                                                        let v131 : US1 = US1_1(v130)
                                                        struct (v52, v53, v54, v55, v56, v57, v58, v59, v131, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                    else
                                                        let v132 : bool = "children" = v99
                                                        if v132 then
                                                            let v133 : (unit -> JSX.Element) = v100 |> unbox
                                                            let v134 : US5 = US5_1(v133)
                                                            struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v134, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                        else
                                                            let v135 : bool = "colorScheme" = v99
                                                            if v135 then
                                                                let v136 : string = v100 |> unbox
                                                                let v137 : US3 = US3_1(v136)
                                                                struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v137, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                            else
                                                                let v138 : bool = "compact" = v99
                                                                if v138 then
                                                                    let v139 : bool = v100 |> unbox
                                                                    let v140 : US1 = US1_1(v139)
                                                                    struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v140, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                else
                                                                    let v141 : bool = "display" = v99
                                                                    if v141 then
                                                                        let v142 : string = v100 |> unbox
                                                                        let v143 : US3 = US3_1(v142)
                                                                        struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v143, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                    else
                                                                        let v144 : bool = "direction" = v99
                                                                        if v144 then
                                                                            let v145 : string = v100 |> unbox
                                                                            let v146 : US3 = US3_1(v145)
                                                                            struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v146, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                        else
                                                                            let v147 : bool = "external" = v99
                                                                            if v147 then
                                                                                let v148 : bool = v100 |> unbox
                                                                                let v149 : US1 = US1_1(v148)
                                                                                struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v149, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                            else
                                                                                let v150 : bool = "flex" = v99
                                                                                if v150 then
                                                                                    let v151 : int32 = v100 |> unbox
                                                                                    let v152 : US0 = US0_1(v151)
                                                                                    struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v152, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                else
                                                                                    let v153 : bool = "flexDirection" = v99
                                                                                    if v153 then
                                                                                        let v154 : string = v100 |> unbox
                                                                                        let v155 : US3 = US3_1(v154)
                                                                                        struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v155, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                    else
                                                                                        let v156 : bool = "fontSize" = v99
                                                                                        if v156 then
                                                                                            let v157 : string = v100 |> unbox
                                                                                            let v158 : US3 = US3_1(v157)
                                                                                            struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v158, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                        else
                                                                                            let v159 : bool = "height" = v99
                                                                                            if v159 then
                                                                                                let v160 : string = v100 |> unbox
                                                                                                let v161 : US3 = US3_1(v160)
                                                                                                struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v161, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                            else
                                                                                                let v162 : bool = "href" = v99
                                                                                                if v162 then
                                                                                                    let v163 : string = v100 |> unbox
                                                                                                    let v164 : US3 = US3_1(v163)
                                                                                                    struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v164, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                else
                                                                                                    let v165 : bool = "icon" = v99
                                                                                                    if v165 then
                                                                                                        let v166 : JSX.Element = v100 |> unbox
                                                                                                        let v167 : US6 = US6_1(v166)
                                                                                                        struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v167, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                    else
                                                                                                        let v168 : bool = "id" = v99
                                                                                                        if v168 then
                                                                                                            let v169 : string = v100 |> unbox
                                                                                                            let v170 : US3 = US3_1(v169)
                                                                                                            struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v170, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                        else
                                                                                                            let v171 : bool = "justifyContent" = v99
                                                                                                            if v171 then
                                                                                                                let v172 : string = v100 |> unbox
                                                                                                                let v173 : US3 = US3_1(v172)
                                                                                                                struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v173, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                            else
                                                                                                                let v174 : bool = "left" = v99
                                                                                                                if v174 then
                                                                                                                    let v175 : string = v100 |> unbox
                                                                                                                    let v176 : US3 = US3_1(v175)
                                                                                                                    struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v176, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                                else
                                                                                                                    let v177 : bool = "leftIcon" = v99
                                                                                                                    if v177 then
                                                                                                                        let v178 : obj = v100 |> unbox
                                                                                                                        let v179 : US7 = US7_1(v178)
                                                                                                                        struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v179, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                                    else
                                                                                                                        let v180 : bool = "lineHeight" = v99
                                                                                                                        if v180 then
                                                                                                                            let v181 : string = v100 |> unbox
                                                                                                                            let v182 : US3 = US3_1(v181)
                                                                                                                            struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v182, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                                        else
                                                                                                                            let v183 : bool = "margin" = v99
                                                                                                                            if v183 then
                                                                                                                                let v184 : string = v100 |> unbox
                                                                                                                                let v185 : US3 = US3_1(v184)
                                                                                                                                struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v185, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                                            else
                                                                                                                                let v186 : bool = "marginBottom" = v99
                                                                                                                                if v186 then
                                                                                                                                    let v187 : string = v100 |> unbox
                                                                                                                                    let v188 : US3 = US3_1(v187)
                                                                                                                                    struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v188, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                                                else
                                                                                                                                    let v189 : bool = "maxHeight" = v99
                                                                                                                                    if v189 then
                                                                                                                                        let v190 : string = v100 |> unbox
                                                                                                                                        let v191 : US3 = US3_1(v190)
                                                                                                                                        struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v191, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                                                    else
                                                                                                                                        let v192 : bool = "onChange" = v99
                                                                                                                                        if v192 then
                                                                                                                                            let v193 : (obj -> unit) = v100 |> unbox
                                                                                                                                            let v194 : US8 = US8_1(v193)
                                                                                                                                            struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v194, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                                                        else
                                                                                                                                            let v195 : bool = "onClick" = v99
                                                                                                                                            if v195 then
                                                                                                                                                let v196 : (unit -> unit) = v100 |> unbox
                                                                                                                                                let v197 : US9 = US9_1(v196)
                                                                                                                                                struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v197, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                                                            else
                                                                                                                                                let v198 : bool = "outline" = v99
                                                                                                                                                if v198 then
                                                                                                                                                    let v199 : string = v100 |> unbox
                                                                                                                                                    let v200 : US3 = US3_1(v199)
                                                                                                                                                    struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v200, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                                                                else
                                                                                                                                                    let v201 : bool = "overflowY" = v99
                                                                                                                                                    if v201 then
                                                                                                                                                        let v202 : string = v100 |> unbox
                                                                                                                                                        let v203 : US3 = US3_1(v202)
                                                                                                                                                        struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v203, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                                                                    else
                                                                                                                                                        let v204 : bool = "padding" = v99
                                                                                                                                                        if v204 then
                                                                                                                                                            let v205 : string = v100 |> unbox
                                                                                                                                                            let v206 : US3 = US3_1(v205)
                                                                                                                                                            struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v206, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                                                                        else
                                                                                                                                                            let v207 : bool = "paddingTop" = v99
                                                                                                                                                            if v207 then
                                                                                                                                                                let v208 : string = v100 |> unbox
                                                                                                                                                                let v209 : US3 = US3_1(v208)
                                                                                                                                                                struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v209, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                                                                            else
                                                                                                                                                                let v210 : bool = "position" = v99
                                                                                                                                                                if v210 then
                                                                                                                                                                    let v211 : string = v100 |> unbox
                                                                                                                                                                    let v212 : US3 = US3_1(v211)
                                                                                                                                                                    struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v212, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                                                                                else
                                                                                                                                                                    let v213 : bool = "right" = v99
                                                                                                                                                                    if v213 then
                                                                                                                                                                        let v214 : string = v100 |> unbox
                                                                                                                                                                        let v215 : US3 = US3_1(v214)
                                                                                                                                                                        struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v215, v90, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                                                                                    else
                                                                                                                                                                        let v216 : bool = "size" = v99
                                                                                                                                                                        if v216 then
                                                                                                                                                                            let v217 : string = v100 |> unbox
                                                                                                                                                                            let v218 : US3 = US3_1(v217)
                                                                                                                                                                            struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v218, v91, v92, v93, v94, v95, v96, v97, v98)
                                                                                                                                                                        else
                                                                                                                                                                            let v219 : bool = "spacing" = v99
                                                                                                                                                                            if v219 then
                                                                                                                                                                                let v220 : string = v100 |> unbox
                                                                                                                                                                                let v221 : US3 = US3_1(v220)
                                                                                                                                                                                struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v221, v92, v93, v94, v95, v96, v97, v98)
                                                                                                                                                                            else
                                                                                                                                                                                let v222 : bool = "status" = v99
                                                                                                                                                                                if v222 then
                                                                                                                                                                                    let v223 : bool = v100 |> unbox
                                                                                                                                                                                    let v224 : US1 = US1_1(v223)
                                                                                                                                                                                    struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v224, v93, v94, v95, v96, v97, v98)
                                                                                                                                                                                else
                                                                                                                                                                                    let v225 : bool = "striped" = v99
                                                                                                                                                                                    if v225 then
                                                                                                                                                                                        let v226 : string = v100 |> unbox
                                                                                                                                                                                        let v227 : US3 = US3_1(v226)
                                                                                                                                                                                        struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v227, v94, v95, v96, v97, v98)
                                                                                                                                                                                    else
                                                                                                                                                                                        let v228 : bool = "thickness" = v99
                                                                                                                                                                                        if v228 then
                                                                                                                                                                                            let v229 : string = v100 |> unbox
                                                                                                                                                                                            let v230 : US3 = US3_1(v229)
                                                                                                                                                                                            struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v230, v95, v96, v97, v98)
                                                                                                                                                                                        else
                                                                                                                                                                                            let v231 : bool = "title" = v99
                                                                                                                                                                                            if v231 then
                                                                                                                                                                                                let v232 : JSX.Element = v100 |> unbox
                                                                                                                                                                                                let v233 : US6 = US6_1(v232)
                                                                                                                                                                                                struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v233, v96, v97, v98)
                                                                                                                                                                                            else
                                                                                                                                                                                                let v234 : bool = "top" = v99
                                                                                                                                                                                                if v234 then
                                                                                                                                                                                                    let v235 : string = v100 |> unbox
                                                                                                                                                                                                    let v236 : US3 = US3_1(v235)
                                                                                                                                                                                                    struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v236, v97, v98)
                                                                                                                                                                                                else
                                                                                                                                                                                                    let v237 : bool = "width" = v99
                                                                                                                                                                                                    if v237 then
                                                                                                                                                                                                        let v238 : string = v100 |> unbox
                                                                                                                                                                                                        let v239 : US3 = US3_1(v238)
                                                                                                                                                                                                        struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v239, v98)
                                                                                                                                                                                                    else
                                                                                                                                                                                                        let v240 : bool = "zIndex" = v99
                                                                                                                                                                                                        if v240 then
                                                                                                                                                                                                            let v241 : int32 = v100 |> unbox
                                                                                                                                                                                                            let v242 : US0 = US0_1(v241)
                                                                                                                                                                                                            struct (v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v242)
                                                                                                                                                                                                        else
                                                                                                                                                                                                            let v243 : string = $"unknown prop: {v99} = {v100}"
                                                                                                                                                                                                            failwith<struct (US1 * US1 * US2 * US3 * US4 * US3 * US3 * US3 * US1 * US5 * US3 * US3 * US1 * US3 * US3 * US1 * US0 * US3 * US3 * US3 * US3 * US6 * US3 * US3 * US3 * US7 * US3 * US3 * US3 * US3 * US8 * US9 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US1 * US3 * US3 * US6 * US3 * US3 * US0)> v243
        let v2547 : int32 = v51 + 1
        v49.l0 <- v2547
        v49.l1 <- v2500
        v49.l2 <- v2501
        v49.l3 <- v2502
        v49.l4 <- v2503
        v49.l5 <- v2504
        v49.l6 <- v2505
        v49.l7 <- v2506
        v49.l8 <- v2507
        v49.l9 <- v2508
        v49.l10 <- v2509
        v49.l11 <- v2510
        v49.l12 <- v2511
        v49.l13 <- v2512
        v49.l14 <- v2513
        v49.l15 <- v2514
        v49.l16 <- v2515
        v49.l17 <- v2516
        v49.l18 <- v2517
        v49.l19 <- v2518
        v49.l20 <- v2519
        v49.l21 <- v2520
        v49.l22 <- v2521
        v49.l23 <- v2522
        v49.l24 <- v2523
        v49.l25 <- v2524
        v49.l26 <- v2525
        v49.l27 <- v2526
        v49.l28 <- v2527
        v49.l29 <- v2528
        v49.l30 <- v2529
        v49.l31 <- v2530
        v49.l32 <- v2531
        v49.l33 <- v2532
        v49.l34 <- v2533
        v49.l35 <- v2534
        v49.l36 <- v2535
        v49.l37 <- v2536
        v49.l38 <- v2537
        v49.l39 <- v2538
        v49.l40 <- v2539
        v49.l41 <- v2540
        v49.l42 <- v2541
        v49.l43 <- v2542
        v49.l44 <- v2543
        v49.l45 <- v2544
        v49.l46 <- v2545
        v49.l47 <- v2546
        ()
    let struct (v2548 : US1, v2549 : US1, v2550 : US2, v2551 : US3, v2552 : US4, v2553 : US3, v2554 : US3, v2555 : US3, v2556 : US1, v2557 : US5, v2558 : US3, v2559 : US3, v2560 : US1, v2561 : US3, v2562 : US3, v2563 : US1, v2564 : US0, v2565 : US3, v2566 : US3, v2567 : US3, v2568 : US3, v2569 : US6, v2570 : US3, v2571 : US3, v2572 : US3, v2573 : US7, v2574 : US3, v2575 : US3, v2576 : US3, v2577 : US3, v2578 : US8, v2579 : US9, v2580 : US3, v2581 : US3, v2582 : US3, v2583 : US3, v2584 : US3, v2585 : US3, v2586 : US3, v2587 : US3, v2588 : US1, v2589 : US3, v2590 : US3, v2591 : US6, v2592 : US3, v2593 : US3, v2594 : US0) = v49.l1, v49.l2, v49.l3, v49.l4, v49.l5, v49.l6, v49.l7, v49.l8, v49.l9, v49.l10, v49.l11, v49.l12, v49.l13, v49.l14, v49.l15, v49.l16, v49.l17, v49.l18, v49.l19, v49.l20, v49.l21, v49.l22, v49.l23, v49.l24, v49.l25, v49.l26, v49.l27, v49.l28, v49.l29, v49.l30, v49.l31, v49.l32, v49.l33, v49.l34, v49.l35, v49.l36, v49.l37, v49.l38, v49.l39, v49.l40, v49.l41, v49.l42, v49.l43, v49.l44, v49.l45, v49.l46, v49.l47
    {l0 = v2548; l1 = v2549; l2 = v2550; l3 = v2551; l4 = v2552; l5 = v2553; l6 = v2554; l7 = v2555; l8 = v2556; l9 = v2557; l10 = v2558; l11 = v2559; l12 = v2560; l13 = v2561; l14 = v2562; l15 = v2563; l16 = v2564; l17 = v2565; l18 = v2566; l19 = v2567; l20 = v2568; l21 = v2569; l22 = v2570; l23 = v2571; l24 = v2572; l25 = v2573; l26 = v2574; l27 = v2575; l28 = v2576; l29 = v2577; l30 = v2578; l31 = v2579; l32 = v2580; l33 = v2581; l34 = v2582; l35 = v2583; l36 = v2584; l37 = v2585; l38 = v2586; l39 = v2587; l40 = v2588; l41 = v2589; l42 = v2590; l43 = v2591; l44 = v2592; l45 = v2593; l46 = v2594} : Heap1
and closure4 () (v0 : (struct (string * obj) [])) : Heap1 =
    method18(v0)
and closure5 () (v0 : obj) : obj =
    method1(v0)
and closure7 (v0 : Heap1, v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US1, v10 : US5, v11 : US3, v12 : US3, v13 : US1, v14 : US3, v15 : US3, v16 : US1, v17 : US0, v18 : US3, v19 : US3, v20 : US3, v21 : US3, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US7, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US8, v32 : US9, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US1, v42 : US3, v43 : US3, v44 : US6, v45 : US3, v46 : US3, v47 : US0) () : JSX.Element =
    let v48 : US3 = v0.l20
    let v51 : string =
        match v48 with
        | US3_0 -> (* None *)
            let v49 : string = ""
            v49
        | US3_1(v50) -> (* Some *)
            v50
    let v52 : JSX.Element = Html.fragment [ v51 |> unbox<JSX.Element> ]
    let v53 : string = "&nbsp;"
    let v54 : JSX.Element = Html.fragment [ v53 |> unbox<JSX.Element> ]
    let v55 : string = "BiRegularLinkExternal"
    let v56 : string = "solid-icons/bi"
    let v57 : JS.Function = import v55 v56
    let v58 : US4 = US4_1(v57)
    let v59 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v58; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47} : Heap1
    let v60 : (JSX.Prop []) = method5(v59)
    let v61 : obj = createObj v60
    let v62 : string = "createComponent"
    let v63 : string = "solid-js"
    let v64 : JS.Function = import v62 v63
    let v65 : string = "Icon"
    let v66 : string = "@hope-ui/solid"
    let v67 : JSX.Element = v64.Invoke ((import v65 v66), v61) |> unbox<JSX.Element>
    let v68 : (JSX.Element []) = [|v52; v54; v67|]
    let v69 : JSX.Element = v68 |> unbox<JSX.Element>
    v69
and method20 (v0 : Heap1) : JSX.Element =
    let struct (v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US1, v10 : US5, v11 : US3, v12 : US3, v13 : US1, v14 : US3, v15 : US3, v16 : US1, v17 : US0, v18 : US3, v19 : US3, v20 : US3, v21 : US3, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US7, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US8, v32 : US9, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US1, v42 : US3, v43 : US3, v44 : US6, v45 : US3, v46 : US3, v47 : US0) = method3()
    let v48 : (unit -> JSX.Element) = closure7(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47)
    let v49 : US5 = US5_1(v48)
    let v50 : bool = true
    let v51 : US1 = US1_1(v50)
    let v52 : Heap1 = method4(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v49, v11, v12, v13, v14, v15, v51, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47)
    let v53 : (JSX.Prop []) = method5(v52)
    let v54 : obj = createObj v53
    let v55 : string = "createComponent"
    let v56 : string = "solid-js"
    let v57 : JS.Function = import v55 v56
    let v58 : string = "Anchor"
    let v59 : string = "@hope-ui/solid"
    let v60 : JSX.Element = v57.Invoke ((import v58 v59), v54) |> unbox<JSX.Element>
    v60
and closure6 () (v0 : Heap1) : JSX.Element =
    method20(v0)
and method23 (v0 : bool) : struct ((unit -> bool) * (bool -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke v0 |> unbox<JS.Function[]>
    let v5 : (unit -> bool) = v4.[0] |> unbox
    let v6 : (bool -> unit) = v4.[1] |> unbox
    struct (v5, v6)
and closure14 (v0 : JSX.Element) () : JSX.Element =
    let v1 : (JSX.Element []) = [|v0|]
    let v2 : JSX.Element = v1 |> unbox<JSX.Element>
    v2
and closure13 (v0 : US1, v1 : US1, v2 : US2, v3 : US3, v4 : US4, v5 : US3, v6 : US3, v7 : US3, v8 : US1, v9 : US5, v10 : US3, v11 : US3, v12 : US1, v13 : US3, v14 : US3, v15 : US1, v16 : US0, v17 : US3, v18 : US3, v19 : US3, v20 : US3, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US8, v31 : US9, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US1, v41 : US3, v42 : US3, v43 : US6, v44 : US3, v45 : US3, v46 : US0, v47 : JSX.Element) () : JSX.Element =
    let v48 : (unit -> JSX.Element) = closure14(v47)
    let v49 : US5 = US5_1(v48)
    let v50 : string = "2px"
    let v51 : US3 = US3_1(v50)
    let v52 : Heap1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v49; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v51; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46} : Heap1
    let v53 : (JSX.Prop []) = method5(v52)
    let v54 : obj = createObj v53
    let v55 : string = "createComponent"
    let v56 : string = "solid-js"
    let v57 : JS.Function = import v55 v56
    let v58 : string = "Box"
    let v59 : string = "@hope-ui/solid"
    let v60 : JSX.Element = v57.Invoke ((import v58 v59), v54) |> unbox<JSX.Element>
    let v61 : (JSX.Element []) = [|v60|]
    let v62 : JSX.Element = v61 |> unbox<JSX.Element>
    v62
and closure15 (v0 : (bool -> unit)) (v1 : obj) : unit =
    let v2 : bool = v1?target?checked
    v0 v2
    ()
and closure12 (v0 : Heap1, v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US1, v10 : US5, v11 : US3, v12 : US3, v13 : US1, v14 : US3, v15 : US3, v16 : US1, v17 : US0, v18 : US3, v19 : US3, v20 : US3, v21 : US3, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US7, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US8, v32 : US9, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US1, v42 : US3, v43 : US3, v44 : US6, v45 : US3, v46 : US3, v47 : US0, v48 : (bool -> unit), v49 : (unit -> bool), v50 : JSX.Element) () : JSX.Element =
    let v51 : US1 = v0.l40
    let v74 : JSX.Element =
        match v51 with
        | US1_0 -> (* None *)
            v50
        | US1_1(v52) -> (* Some *)
            let v53 : bool = v49 ()
            let v54 : US1 = US1_1(v53)
            let v55 : (unit -> JSX.Element) = closure13(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v50)
            let v56 : US5 = US5_1(v55)
            let v57 : string = "neutral"
            let v58 : US3 = US3_1(v57)
            let v59 : string = "2px"
            let v60 : US3 = US3_1(v59)
            let v61 : (obj -> unit) = closure15(v48)
            let v62 : US8 = US8_1(v61)
            let v63 : string = "sm"
            let v64 : US3 = US3_1(v63)
            let v65 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v54; l9 = v56; l10 = v11; l11 = v58; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v60; l29 = v30; l30 = v62; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v64; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47} : Heap1
            let v66 : (JSX.Prop []) = method5(v65)
            let v67 : obj = createObj v66
            let v68 : string = "createComponent"
            let v69 : string = "solid-js"
            let v70 : JS.Function = import v68 v69
            let v71 : string = "Checkbox"
            let v72 : string = "@hope-ui/solid"
            let v73 : JSX.Element = v70.Invoke ((import v71 v72), v67) |> unbox<JSX.Element>
            v73
    let v75 : (JSX.Element []) = [|v74|]
    let v76 : JSX.Element = v75 |> unbox<JSX.Element>
    v76
and closure16 () () : JSX.Element =
    let v0 : string = "&nbsp;"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    let v2 : (JSX.Element []) = [|v1|]
    let v3 : JSX.Element = v2 |> unbox<JSX.Element>
    v3
and closure18 () () : JSX.Element =
    let v0 : JSX.Element = Html.fragment []
    v0
and closure20 (v0 : JS.Function) (v1 : obj) : unit =
    v0.Invoke ("set", v1) |> unbox
    ()
and method25 () : struct (obj * (obj -> unit)) =
    let v0 : string = "useStoreon"
    let v1 : string = "@storeon/solidjs"
    let v2 : JS.Function = import v0 v1
    let v3 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v4 : obj = v3.[0] |> unbox
    let v5 : JS.Function = v3.[1] |> unbox
    let v6 : (obj -> unit) = closure20(v5)
    struct (v4, v6)
and closure21 (v0 : (unit -> bool)) () : (bool []) =
    let v1 : bool = v0 ()
    [|v1|]
and closure22 (v0 : (bool -> unit), v1 : (unit -> bool)) () : unit =
    let v2 : bool = v1 ()
    if v2 then
        v0 false
        ()
and closure25 () () : JSX.Element =
    let v0 : string = "Load"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    let v2 : (JSX.Element []) = [|v1|]
    let v3 : JSX.Element = v2 |> unbox<JSX.Element>
    v3
and closure26 (v0 : (bool -> unit), v1 : Heap1, v2 : (obj -> unit), v3 : obj) () : unit =
    let v4 : US2 = v1.l2
    match v4 with
    | US2_0 -> (* None *)
        ()
    | US2_1(v5) -> (* Some *)
        let v6 : ((obj -> unit) -> unit) = v5 v3
        v6 v2
        ()
    v0 true
    ()
and method26 (v0 : (Heap1 -> JSX.Element), v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US1, v10 : US5, v11 : US3, v12 : US3, v13 : US1, v14 : US3, v15 : US3, v16 : US1, v17 : US0, v18 : US3, v19 : US3, v20 : US3, v21 : US3, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US7, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US8, v32 : US9, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US1, v42 : US3, v43 : US3, v44 : US6, v45 : US3, v46 : US3, v47 : US0) : JSX.Element =
    let v48 : JS.Function = v0 |> unbox<JS.Function>
    let v49 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47} : Heap1
    let v50 : string = "createComponent"
    let v51 : string = "solid-js"
    let v52 : JS.Function = import v50 v51
    let v53 : JSX.Element = v52.Invoke (v48, v49) |> unbox<JSX.Element>
    v53
and closure24 (v0 : US1, v1 : US1, v2 : US2, v3 : US3, v4 : US4, v5 : US3, v6 : US3, v7 : US3, v8 : US1, v9 : US5, v10 : US3, v11 : US3, v12 : US1, v13 : US3, v14 : US3, v15 : US1, v16 : US0, v17 : US3, v18 : US3, v19 : US3, v20 : US3, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US8, v31 : US9, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US1, v41 : US3, v42 : US3, v43 : US6, v44 : US3, v45 : US3, v46 : US0, v47 : (bool -> unit), v48 : Heap1, v49 : (obj -> unit), v50 : obj) () : JSX.Element =
    let v51 : (Heap1 -> JSX.Element) = closure1()
    let v52 : (unit -> JSX.Element) = closure25()
    let v53 : US5 = US5_1(v52)
    let v54 : (unit -> unit) = closure26(v47, v48, v49, v50)
    let v55 : US9 = US9_1(v54)
    let v56 : JSX.Element = method26(v51, v0, v1, v2, v3, v4, v5, v6, v7, v8, v53, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v55, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)
    let v57 : (JSX.Element []) = [|v56|]
    let v58 : JSX.Element = v57 |> unbox<JSX.Element>
    v58
and method27 (v0 : JS.Function, v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US1, v10 : US5, v11 : US3, v12 : US3, v13 : US1, v14 : US3, v15 : US3, v16 : US1, v17 : US0, v18 : US3, v19 : US3, v20 : US3, v21 : US3, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US7, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US8, v32 : US9, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US1, v42 : US3, v43 : US3, v44 : US6, v45 : US3, v46 : US3, v47 : US0) : JSX.Element =
    let v48 : JS.Function = v0 |> unbox<JS.Function>
    let v49 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47} : Heap1
    let v50 : string = "createComponent"
    let v51 : string = "solid-js"
    let v52 : JS.Function = import v50 v51
    let v53 : JSX.Element = v52.Invoke (v48, v49) |> unbox<JSX.Element>
    v53
and closure30 (v0 : (bool -> unit)) () : unit =
    v0 true
    ()
and method28 (v0 : US0) : (JSX.Prop []) =
    let v1 : string = "ui_modal"
    let v2 : US10 = method10(v1, v0)
    let v3 : (US10 []) = [|v2|]
    let v4 : int32 = v3.Length
    let v5 : (US10 []) = Array.zeroCreate<US10> (v4)
    let v6 : Mut1 = {l0 = 0; l1 = 0} : Mut1
    while method15(v4, v6) do
        let v8 : int32 = v6.l0
        let v9 : int32 = v6.l1
        let v10 : US10 = v3.[int v8]
        let v12 : bool =
            match v10 with
            | US10_0 -> (* None *)
                false
            | US10_1(v11) -> (* Some *)
                true
        let v14 : int32 =
            if v12 then
                v5.[int v9] <- v10
                let v13 : int32 = v9 + 1
                v13
            else
                v9
        let v15 : int32 = v8 + 1
        v6.l0 <- v15
        v6.l1 <- v14
        ()
    let v16 : int32 = v6.l1
    let v17 : (US10 []) = Array.zeroCreate<US10> (v16)
    let v18 : Mut2 = {l0 = 0} : Mut2
    while method16(v16, v18) do
        let v20 : int32 = v18.l0
        let v21 : US10 = v5.[int v20]
        v17.[int v20] <- v21
        let v22 : int32 = v20 + 1
        v18.l0 <- v22
        ()
    let v23 : int32 = v17.Length
    let v24 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v23)
    let v25 : Mut2 = {l0 = 0} : Mut2
    while method16(v23, v25) do
        let v27 : int32 = v25.l0
        let v28 : US10 = v17.[int v27]
        let v31 : JSX.Prop =
            match v28 with
            | US10_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US10_1(v30) -> (* Some *)
                v30
        v24.[int v27] <- v31
        let v32 : int32 = v27 + 1
        v25.l0 <- v32
        ()
    v24
and closure31 (v0 : (obj -> unit), v1 : int32, v2 : (bool -> unit), v3 : (unit -> bool)) () : unit =
    let v4 : bool = v3 ()
    let v5 : bool = v4 = false
    v2 v5
    let v8 : US0 =
        if v5 then
            US0_1(v1)
        else
            US0_1(-3)
    let v9 : (JSX.Prop []) = method28(v8)
    let v10 : obj = createObj v9
    v0 v10
    ()
and closure32 (v0 : (bool -> unit)) () : unit =
    v0 false
    ()
and closure29 (v0 : US1, v1 : US1, v2 : US2, v3 : US3, v4 : US4, v5 : US3, v6 : US3, v7 : US3, v8 : US1, v9 : US5, v10 : US3, v11 : US3, v12 : US1, v13 : US3, v14 : US3, v15 : US1, v16 : US0, v17 : US3, v18 : US3, v19 : US3, v20 : US3, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US8, v31 : US9, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US1, v41 : US3, v42 : US3, v43 : US6, v44 : US3, v45 : US3, v46 : US0, v47 : (obj -> unit), v48 : int32, v49 : (bool -> unit), v50 : (bool -> unit), v51 : (bool -> unit), v52 : (unit -> bool)) () : JSX.Element =
    let v53 : string = "BiRegularRefresh"
    let v54 : string = "solid-icons/bi"
    let v55 : JS.Function = import v53 v54
    let v56 : string = "14px"
    let v57 : US3 = US3_1(v56)
    let v58 : JSX.Element = method27(v55, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v57, v39, v40, v41, v42, v43, v44, v45, v46)
    let v59 : string = "Refresh"
    let v60 : US3 = US3_1(v59)
    let v61 : string = "neutral"
    let v62 : US3 = US3_1(v61)
    let v63 : string = "20px"
    let v64 : US3 = US3_1(v63)
    let v65 : US6 = US6_1(v58)
    let v66 : (unit -> unit) = closure30(v50)
    let v67 : US9 = US9_1(v66)
    let v68 : string = "xs"
    let v69 : US3 = US3_1(v68)
    let v70 : Heap1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v60; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v62; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v64; l20 = v20; l21 = v65; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v67; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v69; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46} : Heap1
    let v71 : (JSX.Prop []) = method5(v70)
    let v72 : obj = createObj v71
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : string = "IconButton"
    let v77 : string = "@hope-ui/solid"
    let v78 : JSX.Element = v75.Invoke ((import v76 v77), v72) |> unbox<JSX.Element>
    let v79 : bool = v52 ()
    let v82 : string =
        if v79 then
            let v80 : string = "Restore"
            v80
        else
            let v81 : string = "Maximize"
            v81
    let v83 : bool = v52 ()
    let v88 : JS.Function =
        if v83 then
            let v84 : string = "BiRegularDownArrow"
            let v85 : JS.Function = import v84 v54
            v85
        else
            let v86 : string = "BiRegularUpArrow"
            let v87 : JS.Function = import v86 v54
            v87
    let v89 : US3 = US3_1(v56)
    let v90 : JSX.Element = method27(v88, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v89, v39, v40, v41, v42, v43, v44, v45, v46)
    let v91 : US3 = US3_1(v82)
    let v92 : US3 = US3_1(v61)
    let v93 : US3 = US3_1(v63)
    let v94 : US6 = US6_1(v90)
    let v95 : (unit -> unit) = closure31(v47, v48, v51, v52)
    let v96 : US9 = US9_1(v95)
    let v97 : US3 = US3_1(v68)
    let v98 : Heap1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v91; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v92; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v93; l20 = v20; l21 = v94; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v96; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v97; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46} : Heap1
    let v99 : (JSX.Prop []) = method5(v98)
    let v100 : obj = createObj v99
    let v101 : JS.Function = import v73 v74
    let v102 : JSX.Element = v101.Invoke ((import v76 v77), v100) |> unbox<JSX.Element>
    let v103 : string = "BiRegularUndo"
    let v104 : JS.Function = import v103 v54
    let v105 : US3 = US3_1(v56)
    let v106 : JSX.Element = method27(v104, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v105, v39, v40, v41, v42, v43, v44, v45, v46)
    let v107 : string = "Unload"
    let v108 : US3 = US3_1(v107)
    let v109 : US3 = US3_1(v61)
    let v110 : US3 = US3_1(v63)
    let v111 : US6 = US6_1(v106)
    let v112 : (unit -> unit) = closure32(v49)
    let v113 : US9 = US9_1(v112)
    let v114 : US3 = US3_1(v68)
    let v115 : Heap1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v108; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v109; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v110; l20 = v20; l21 = v111; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v113; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v114; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46} : Heap1
    let v116 : (JSX.Prop []) = method5(v115)
    let v117 : obj = createObj v116
    let v118 : JS.Function = import v73 v74
    let v119 : JSX.Element = v118.Invoke ((import v76 v77), v117) |> unbox<JSX.Element>
    let v120 : (JSX.Element []) = [|v78; v102; v119|]
    let v121 : JSX.Element = v120 |> unbox<JSX.Element>
    v121
and closure28 (v0 : US1, v1 : US1, v2 : US2, v3 : US3, v4 : US4, v5 : US3, v6 : US3, v7 : US3, v8 : US1, v9 : US5, v10 : US3, v11 : US3, v12 : US1, v13 : US3, v14 : US3, v15 : US1, v16 : US0, v17 : US3, v18 : US3, v19 : US3, v20 : US3, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US8, v31 : US9, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US1, v41 : US3, v42 : US3, v43 : US6, v44 : US3, v45 : US3, v46 : US0, v47 : (obj -> unit), v48 : int32, v49 : (bool -> unit), v50 : (bool -> unit), v51 : (unit -> bool), v52 : (bool -> unit), v53 : (unit -> bool), v54 : obj, v55 : (unit -> JSX.Element)) () : JSX.Element =
    let v56 : int32 = match v54?ui_modal with x when x = JS.undefined -> -2 | x -> x
    let v57 : bool = v56 > 0
    let v60 : bool =
        if v57 then
            let v58 : bool = v56 = v48
            let v59 : bool = v58 <> true
            v59
        else
            false
    let v64 : US3 =
        if v60 then
            let v61 : string = "none"
            US3_1(v61)
        else
            US3_0
    let v65 : (unit -> JSX.Element) = closure29(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v52, v53)
    let v66 : US5 = US5_1(v65)
    let v67 : string = "row"
    let v68 : US3 = US3_1(v67)
    let v69 : string = "absolute"
    let v70 : US3 = US3_1(v69)
    let v71 : string = "6px"
    let v72 : US3 = US3_1(v71)
    let v73 : string = "3px"
    let v74 : US3 = US3_1(v73)
    let v75 : US3 = US3_1(v71)
    let v76 : US0 = US0_1(1)
    let v77 : Heap1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v66; l10 = v10; l11 = v11; l12 = v12; l13 = v68; l14 = v64; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v70; l37 = v72; l38 = v38; l39 = v74; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v75; l45 = v45; l46 = v76} : Heap1
    let v78 : (JSX.Prop []) = method5(v77)
    let v79 : obj = createObj v78
    let v80 : string = "createComponent"
    let v81 : string = "solid-js"
    let v82 : JS.Function = import v80 v81
    let v83 : string = "Stack"
    let v84 : string = "@hope-ui/solid"
    let v85 : JSX.Element = v82.Invoke ((import v83 v84), v79) |> unbox<JSX.Element>
    let v86 : bool = v51 ()
    let v87 : bool = v86 = false
    let v90 : JSX.Element =
        if v87 then
            let v88 : JSX.Element = v55 ()
            v88
        else
            let v89 : JSX.Element = Html.fragment []
            v89
    let v91 : (JSX.Element []) = [|v85; v90|]
    let v92 : JSX.Element = v91 |> unbox<JSX.Element>
    v92
and closure27 (v0 : Heap1, v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US1, v10 : US5, v11 : US3, v12 : US3, v13 : US1, v14 : US3, v15 : US3, v16 : US1, v17 : US0, v18 : US3, v19 : US3, v20 : US3, v21 : US3, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US7, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US8, v32 : US9, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US1, v42 : US3, v43 : US3, v44 : US6, v45 : US3, v46 : US3, v47 : US0, v48 : (obj -> unit), v49 : int32, v50 : (bool -> unit), v51 : (bool -> unit), v52 : (unit -> bool), v53 : (bool -> unit), v54 : (unit -> bool), v55 : obj) () : JSX.Element =
    let v56 : US5 = v0.l9
    let v79 : JSX.Element =
        match v56 with
        | US5_0 -> (* None *)
            let v57 : JSX.Element = Html.fragment []
            v57
        | US5_1(v58) -> (* Some *)
            let v59 : int32 = match v55?ui_modal with x when x = JS.undefined -> -2 | x -> x
            let v60 : bool = v59 <= 0
            let v64 : US3 =
                if v60 then
                    let v61 : string = "relative"
                    US3_1(v61)
                else
                    US3_0
            let v65 : (unit -> JSX.Element) = closure28(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v58)
            let v66 : US5 = US5_1(v65)
            let v67 : string = "flex"
            let v68 : US3 = US3_1(v67)
            let v69 : US0 = US0_1(1)
            let v70 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v66; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v68; l15 = v16; l16 = v69; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v64; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47} : Heap1
            let v71 : (JSX.Prop []) = method5(v70)
            let v72 : obj = createObj v71
            let v73 : string = "createComponent"
            let v74 : string = "solid-js"
            let v75 : JS.Function = import v73 v74
            let v76 : string = "Box"
            let v77 : string = "@hope-ui/solid"
            let v78 : JSX.Element = v75.Invoke ((import v76 v77), v72) |> unbox<JSX.Element>
            v78
    let v80 : (JSX.Element []) = [|v79|]
    let v81 : JSX.Element = v80 |> unbox<JSX.Element>
    v81
and closure23 (v0 : Heap1, v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US1, v10 : US5, v11 : US3, v12 : US3, v13 : US1, v14 : US3, v15 : US3, v16 : US1, v17 : US0, v18 : US3, v19 : US3, v20 : US3, v21 : US3, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US7, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US8, v32 : US9, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US1, v42 : US3, v43 : US3, v44 : US6, v45 : US3, v46 : US3, v47 : US0, v48 : (obj -> unit), v49 : int32, v50 : (bool -> unit), v51 : (unit -> bool), v52 : (bool -> unit), v53 : (unit -> bool), v54 : (bool -> unit), v55 : (unit -> bool), v56 : obj) () : JSX.Element =
    let v57 : bool = v51 ()
    let v58 : bool = v57 = false
    let v120 : JSX.Element =
        if v58 then
            let v59 : (unit -> JSX.Element) = closure24(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v50, v0, v48, v56)
            let v60 : US5 = US5_1(v59)
            let v61 : string = "4px 0"
            let v62 : US3 = US3_1(v61)
            let v63 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v60; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v62; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47} : Heap1
            let v64 : (JSX.Prop []) = method5(v63)
            let v65 : obj = createObj v64
            let v66 : string = "createComponent"
            let v67 : string = "solid-js"
            let v68 : JS.Function = import v66 v67
            let v69 : string = "Box"
            let v70 : string = "@hope-ui/solid"
            let v71 : JSX.Element = v68.Invoke ((import v69 v70), v65) |> unbox<JSX.Element>
            v71
        else
            let v72 : bool = v55 ()
            let v75 : US0 =
                if v72 then
                    US0_1(1)
                else
                    US0_0
            let v76 : bool = v55 ()
            let v80 : US3 =
                if v76 then
                    let v77 : string = "absolute"
                    US3_1(v77)
                else
                    US3_0
            let v81 : bool = v55 ()
            let v85 : US3 =
                if v81 then
                    let v82 : string = "0"
                    US3_1(v82)
                else
                    US3_0
            let v86 : bool = v55 ()
            let v90 : US3 =
                if v86 then
                    let v87 : string = "0"
                    US3_1(v87)
                else
                    US3_0
            let v91 : bool = v55 ()
            let v95 : US3 =
                if v91 then
                    let v92 : string = "0"
                    US3_1(v92)
                else
                    US3_0
            let v96 : bool = v55 ()
            let v100 : US3 =
                if v96 then
                    let v97 : string = "0"
                    US3_1(v97)
                else
                    US3_0
            let v101 : bool = v55 ()
            let v105 : US3 =
                if v101 then
                    let v102 : string = "$bg"
                    US3_1(v102)
                else
                    US3_0
            let v106 : (unit -> JSX.Element) = closure27(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v52, v53, v54, v55, v56)
            let v107 : US5 = US5_1(v106)
            let v108 : string = "flex"
            let v109 : US3 = US3_1(v108)
            let v110 : US0 = US0_1(1)
            let v111 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v105; l6 = v7; l7 = v95; l8 = v9; l9 = v107; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v109; l15 = v16; l16 = v110; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v100; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v80; l37 = v90; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v85; l45 = v46; l46 = v75} : Heap1
            let v112 : (JSX.Prop []) = method5(v111)
            let v113 : obj = createObj v112
            let v114 : string = "createComponent"
            let v115 : string = "solid-js"
            let v116 : JS.Function = import v114 v115
            let v117 : string = "Box"
            let v118 : string = "@hope-ui/solid"
            let v119 : JSX.Element = v116.Invoke ((import v117 v118), v113) |> unbox<JSX.Element>
            v119
    let v121 : (JSX.Element []) = [|v120|]
    let v122 : JSX.Element = v121 |> unbox<JSX.Element>
    v122
and method24 (v0 : Heap1) : JSX.Element =
    let struct (v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US1, v10 : US5, v11 : US3, v12 : US3, v13 : US1, v14 : US3, v15 : US3, v16 : US1, v17 : US0, v18 : US3, v19 : US3, v20 : US3, v21 : US3, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US7, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US8, v32 : US9, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US1, v42 : US3, v43 : US3, v44 : US6, v45 : US3, v46 : US3, v47 : US0) = method3()
    let struct (v48 : obj, v49 : (obj -> unit)) = method25()
    let v50 : int32 = Random().Next()
    let v51 : US1 = v0.l0
    let v53 : bool =
        match v51 with
        | US1_0 -> (* None *)
            false
        | US1_1(v52) -> (* Some *)
            v52
    let struct (v54 : (unit -> bool), v55 : (bool -> unit)) = method23(v53)
    let v56 : bool = false
    let struct (v57 : (unit -> bool), v58 : (bool -> unit)) = method23(v56)
    let v59 : US1 = v0.l1
    let v61 : bool =
        match v59 with
        | US1_0 -> (* None *)
            false
        | US1_1(v60) -> (* Some *)
            v60
    let struct (v62 : (unit -> bool), v63 : (bool -> unit)) = method23(v61)
    let v64 : string = "on"
    let v65 : string = "solid-js"
    let v66 : JS.Function = import v64 v65
    let v67 : (unit -> (bool [])) = closure21(v57)
    let v68 : (unit -> unit) = closure22(v58, v57)
    let v69 : JS.Function = v66.Invoke (v67, v68) |> unbox<JS.Function>
    let v70 : string = "createEffect"
    let v71 : JS.Function = import v70 v65
    v71.Invoke v69 |> ignore
    let v75 : bool =
        match v51 with
        | US1_1(v73) -> (* Some *)
            let v74 : bool = v73 = true
            v74
        | _ ->
            false
    if v75 then
        let v76 : US2 = v0.l2
        match v76 with
        | US2_0 -> (* None *)
            ()
        | US2_1(v77) -> (* Some *)
            let v78 : ((obj -> unit) -> unit) = v77 v48
            v78 v49
            ()
    let v79 : US3 = v0.l22
    let v80 : (unit -> JSX.Element) = closure23(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v49, v50, v55, v54, v58, v57, v63, v62, v48)
    let v81 : US5 = US5_1(v80)
    let v82 : string = "flex"
    let v83 : US3 = US3_1(v82)
    let v84 : US0 = US0_1(1)
    let v85 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v81; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v83; l15 = v16; l16 = v84; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v79; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47} : Heap1
    let v86 : (JSX.Prop []) = method5(v85)
    let v87 : obj = createObj v86
    let v88 : string = "createComponent"
    let v89 : JS.Function = import v88 v65
    let v90 : string = "Box"
    let v91 : string = "@hope-ui/solid"
    let v92 : JSX.Element = v89.Invoke ((import v90 v91), v87) |> unbox<JSX.Element>
    v92
and closure19 () (v0 : Heap1) : JSX.Element =
    method24(v0)
and closure33 (v0 : (unit -> JSX.Element)) () : JSX.Element =
    let v1 : JSX.Element = v0 ()
    let v2 : (JSX.Element []) = [|v1|]
    let v3 : JSX.Element = v2 |> unbox<JSX.Element>
    v3
and closure17 (v0 : Heap1, v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US1, v10 : US5, v11 : US3, v12 : US3, v13 : US1, v14 : US3, v15 : US3, v16 : US1, v17 : US0, v18 : US3, v19 : US3, v20 : US3, v21 : US3, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US7, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US8, v32 : US9, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US1, v42 : US3, v43 : US3, v44 : US6, v45 : US3, v46 : US3, v47 : US0, v48 : (unit -> bool), v49 : (unit -> JSX.Element)) () : JSX.Element =
    let v50 : US1 = v0.l40
    let v65 : JSX.Element =
        match v50 with
        | US1_0 -> (* None *)
            let v51 : (unit -> JSX.Element) = closure18()
            let v52 : (unit -> JSX.Element) = v49 |> unbox<(unit -> JSX.Element) option> |> Option.defaultValue v51
            let v53 : JSX.Element = v52 ()
            v53
        | US1_1(v54) -> (* Some *)
            let v55 : bool = v48 ()
            if v55 then
                let v56 : (Heap1 -> JSX.Element) = closure19()
                let v57 : US2 = v0.l2
                let v58 : bool = true
                let v59 : US1 = US1_1(v58)
                let v60 : (unit -> JSX.Element) = closure33(v49)
                let v61 : US5 = US5_1(v60)
                method26(v56, v59, v2, v57, v4, v5, v6, v7, v8, v9, v61, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47)
            else
                let v63 : JSX.Element = Html.fragment []
                v63
    let v66 : (JSX.Element []) = [|v65|]
    let v67 : JSX.Element = v66 |> unbox<JSX.Element>
    v67
and closure11 (v0 : Heap1, v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US1, v10 : US5, v11 : US3, v12 : US3, v13 : US1, v14 : US3, v15 : US3, v16 : US1, v17 : US0, v18 : US3, v19 : US3, v20 : US3, v21 : US3, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US7, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US8, v32 : US9, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US1, v42 : US3, v43 : US3, v44 : US6, v45 : US3, v46 : US3, v47 : US0, v48 : (bool -> unit), v49 : (unit -> bool)) () : JSX.Element =
    let v50 : US6 = v0.l43
    let v78 : JSX.Element =
        match v50 with
        | US6_0 -> (* None *)
            let v51 : JSX.Element = Html.fragment []
            v51
        | US6_1(v52) -> (* Some *)
            let v53 : string = "0 !important"
            let v54 : US3 = US3_1(v53)
            let v55 : (unit -> JSX.Element) = closure12(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v52)
            let v56 : US5 = US5_1(v55)
            let v57 : string = "$neutral9"
            let v58 : US3 = US3_1(v57)
            let v59 : string = "flex"
            let v60 : US3 = US3_1(v59)
            let v61 : string = "column"
            let v62 : US3 = US3_1(v61)
            let v63 : string = "$sm"
            let v64 : US3 = US3_1(v63)
            let v65 : string = "1px solid $neutral5"
            let v66 : US3 = US3_1(v65)
            let v67 : string = "3px 20px 0 8px"
            let v68 : US3 = US3_1(v67)
            let v69 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v54; l7 = v8; l8 = v9; l9 = v56; l10 = v58; l11 = v12; l12 = v13; l13 = v14; l14 = v60; l15 = v16; l16 = v17; l17 = v62; l18 = v64; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v66; l33 = v34; l34 = v68; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47} : Heap1
            let v70 : (JSX.Prop []) = method5(v69)
            let v71 : obj = createObj v70
            let v72 : string = "createComponent"
            let v73 : string = "solid-js"
            let v74 : JS.Function = import v72 v73
            let v75 : string = "Td"
            let v76 : string = "@hope-ui/solid"
            let v77 : JSX.Element = v74.Invoke ((import v75 v76), v71) |> unbox<JSX.Element>
            v77
    let v79 : US5 = v0.l9
    let v128 : JSX.Element =
        match v79 with
        | US5_0 -> (* None *)
            let v80 : (unit -> JSX.Element) = closure16()
            let v81 : US5 = US5_1(v80)
            let v82 : string = "9px"
            let v83 : US3 = US3_1(v82)
            let v84 : string = "0"
            let v85 : US3 = US3_1(v84)
            let v86 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v81; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v83; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v85; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47} : Heap1
            let v87 : (JSX.Prop []) = method5(v86)
            let v88 : obj = createObj v87
            let v89 : string = "createComponent"
            let v90 : string = "solid-js"
            let v91 : JS.Function = import v89 v90
            let v92 : string = "Td"
            let v93 : string = "@hope-ui/solid"
            let v94 : JSX.Element = v91.Invoke ((import v92 v93), v88) |> unbox<JSX.Element>
            v94
        | US5_1(v95) -> (* Some *)
            let v96 : US3 = v0.l34
            let v99 : string =
                match v96 with
                | US3_0 -> (* None *)
                    let v97 : string = "0"
                    v97
                | US3_1(v98) -> (* Some *)
                    v98
            let v100 : string = "0 !important"
            let v101 : US3 = US3_1(v100)
            let v102 : (unit -> JSX.Element) = closure17(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v49, v95)
            let v103 : US5 = US5_1(v102)
            let v104 : string = "flex"
            let v105 : US3 = US3_1(v104)
            let v106 : US0 = US0_1(6)
            let v107 : string = "column"
            let v108 : US3 = US3_1(v107)
            let v109 : string = "$sm"
            let v110 : US3 = US3_1(v109)
            let v111 : string = "0"
            let v112 : US3 = US3_1(v111)
            let v113 : string = "85vh"
            let v114 : US3 = US3_1(v113)
            let v115 : US3 = US3_1(v111)
            let v116 : string = "auto"
            let v117 : US3 = US3_1(v116)
            let v118 : US3 = US3_1(v99)
            let v119 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v101; l7 = v8; l8 = v9; l9 = v103; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v105; l15 = v16; l16 = v106; l17 = v108; l18 = v110; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v112; l28 = v29; l29 = v114; l30 = v31; l31 = v32; l32 = v115; l33 = v117; l34 = v118; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47} : Heap1
            let v120 : (JSX.Prop []) = method5(v119)
            let v121 : obj = createObj v120
            let v122 : string = "createComponent"
            let v123 : string = "solid-js"
            let v124 : JS.Function = import v122 v123
            let v125 : string = "Td"
            let v126 : string = "@hope-ui/solid"
            let v127 : JSX.Element = v124.Invoke ((import v125 v126), v121) |> unbox<JSX.Element>
            v127
    let v129 : (JSX.Element []) = [|v78; v128|]
    let v130 : JSX.Element = v129 |> unbox<JSX.Element>
    v130
and method22 (v0 : Heap1) : JSX.Element =
    let struct (v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US1, v10 : US5, v11 : US3, v12 : US3, v13 : US1, v14 : US3, v15 : US3, v16 : US1, v17 : US0, v18 : US3, v19 : US3, v20 : US3, v21 : US3, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US7, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US8, v32 : US9, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US1, v42 : US3, v43 : US3, v44 : US6, v45 : US3, v46 : US3, v47 : US0) = method3()
    let v48 : US1 = v0.l40
    let v52 : bool =
        match v48 with
        | US1_1(v50) -> (* Some *)
            let v51 : bool = v50 = false
            v51
        | _ ->
            false
    let v53 : bool = v52 <> true
    let struct (v54 : (unit -> bool), v55 : (bool -> unit)) = method23(v53)
    let v56 : US3 = v0.l22
    let v57 : string = {| ``@initial`` = "column"; ``@sm`` = "row" |} |> unbox<string>
    let v58 : string = "1px solid $neutral5"
    let v59 : US3 = US3_1(v58)
    let v60 : (unit -> JSX.Element) = closure11(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v55, v54)
    let v61 : US5 = US5_1(v60)
    let v62 : string = "flex"
    let v63 : US3 = US3_1(v62)
    let v64 : US0 = US0_1(1)
    let v65 : US3 = US3_1(v57)
    let v66 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v59; l7 = v8; l8 = v9; l9 = v61; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v63; l15 = v16; l16 = v64; l17 = v65; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v56; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47} : Heap1
    let v67 : (JSX.Prop []) = method5(v66)
    let v68 : obj = createObj v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : string = "Tr"
    let v73 : string = "@hope-ui/solid"
    let v74 : JSX.Element = v71.Invoke ((import v72 v73), v68) |> unbox<JSX.Element>
    v74
and closure10 () (v0 : Heap1) : JSX.Element =
    method22(v0)
and closure34 (v0 : US1, v1 : US1, v2 : US2, v3 : US3, v4 : US4, v5 : US3, v6 : US3, v7 : US3, v8 : US1, v9 : US5, v10 : US3, v11 : US3, v12 : US1, v13 : US3, v14 : US3, v15 : US1, v16 : US0, v17 : US3, v18 : US3, v19 : US3, v20 : US3, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US8, v31 : US9, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US1, v41 : US3, v42 : US3, v43 : US6, v44 : US3, v45 : US3, v46 : US0) () : JSX.Element =
    let v47 : (Heap1 -> JSX.Element) = closure6()
    let v48 : string = "https://github.com/fc1943s/tictactoe_spiral"
    let v49 : US3 = US3_1(v48)
    let v50 : JSX.Element = method26(v47, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v49, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)
    let v51 : (JSX.Element []) = [|v50|]
    let v52 : JSX.Element = v51 |> unbox<JSX.Element>
    v52
and closure35 (v0 : US1, v1 : US1, v2 : US2, v3 : US3, v4 : US4, v5 : US3, v6 : US3, v7 : US3, v8 : US1, v9 : US5, v10 : US3, v11 : US3, v12 : US1, v13 : US3, v14 : US3, v15 : US1, v16 : US0, v17 : US3, v18 : US3, v19 : US3, v20 : US3, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US8, v31 : US9, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US1, v41 : US3, v42 : US3, v43 : US6, v44 : US3, v45 : US3, v46 : US0) () : JSX.Element =
    let v47 : (Heap1 -> JSX.Element) = closure6()
    let v48 : string = "https://fc1943s.github.io/tictactoe_spiral"
    let v49 : US3 = US3_1(v48)
    let v50 : JSX.Element = method26(v47, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v49, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)
    let v51 : (JSX.Element []) = [|v50|]
    let v52 : JSX.Element = v51 |> unbox<JSX.Element>
    v52
and closure36 (v0 : US1, v1 : US1, v2 : US2, v3 : US3, v4 : US4, v5 : US3, v6 : US3, v7 : US3, v8 : US1, v9 : US5, v10 : US3, v11 : US3, v12 : US1, v13 : US3, v14 : US3, v15 : US1, v16 : US0, v17 : US3, v18 : US3, v19 : US3, v20 : US3, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US8, v31 : US9, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US1, v41 : US3, v42 : US3, v43 : US6, v44 : US3, v45 : US3, v46 : US0) () : JSX.Element =
    let v47 : (Heap1 -> JSX.Element) = closure6()
    let v48 : string = "https://fc1943s.github.io/tictactoe_spiral/docs"
    let v49 : US3 = US3_1(v48)
    let v50 : JSX.Element = method26(v47, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v49, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)
    let v51 : (JSX.Element []) = [|v50|]
    let v52 : JSX.Element = v51 |> unbox<JSX.Element>
    v52
and closure9 (v0 : US1, v1 : US1, v2 : US2, v3 : US3, v4 : US4, v5 : US3, v6 : US3, v7 : US3, v8 : US1, v9 : US5, v10 : US3, v11 : US3, v12 : US1, v13 : US3, v14 : US3, v15 : US1, v16 : US0, v17 : US3, v18 : US3, v19 : US3, v20 : US3, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US8, v31 : US9, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US1, v41 : US3, v42 : US3, v43 : US6, v44 : US3, v45 : US3, v46 : US0) () : JSX.Element =
    let v47 : (Heap1 -> JSX.Element) = closure10()
    let v48 : (unit -> JSX.Element) = closure34(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)
    let v49 : US5 = US5_1(v48)
    let v50 : string = "1px 6px"
    let v51 : US3 = US3_1(v50)
    let v52 : JSX.Element = method26(v47, v0, v1, v2, v3, v4, v5, v6, v7, v8, v49, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v51, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)
    let v53 : (unit -> JSX.Element) = closure35(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)
    let v54 : US5 = US5_1(v53)
    let v55 : US3 = US3_1(v50)
    let v56 : JSX.Element = method26(v47, v0, v1, v2, v3, v4, v5, v6, v7, v8, v54, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v55, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)
    let v57 : (unit -> JSX.Element) = closure36(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)
    let v58 : US5 = US5_1(v57)
    let v59 : US3 = US3_1(v50)
    let v60 : JSX.Element = method26(v47, v0, v1, v2, v3, v4, v5, v6, v7, v8, v58, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v59, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)
    let v61 : (JSX.Element []) = [|v52; v56; v60|]
    let v62 : JSX.Element = v61 |> unbox<JSX.Element>
    v62
and method21 () : JSX.Element =
    let struct (v0 : US1, v1 : US1, v2 : US2, v3 : US3, v4 : US4, v5 : US3, v6 : US3, v7 : US3, v8 : US1, v9 : US5, v10 : US3, v11 : US3, v12 : US1, v13 : US3, v14 : US3, v15 : US1, v16 : US0, v17 : US3, v18 : US3, v19 : US3, v20 : US3, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US7, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US8, v31 : US9, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US1, v41 : US3, v42 : US3, v43 : US6, v44 : US3, v45 : US3, v46 : US0) = method3()
    let v47 : (Heap1 -> JSX.Element) = closure2()
    let v48 : (unit -> JSX.Element) = closure9(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)
    let v49 : US5 = US5_1(v48)
    method26(v47, v0, v1, v2, v3, v4, v5, v6, v7, v8, v49, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)
and closure8 () () : JSX.Element =
    method21()
let v0 : obj = JS.undefined
let v1 : Mut0 = {l0 = v0} : Mut0
let v2 : US0 = method0()
let v3 : Heap0 = {l0 = v2} : Heap0
let v4 : obj = v3
let v5 : obj = method1(v4)
let v6 : string = "base_button"
let v7 : (Heap1 -> JSX.Element) = closure1()
let v8 : JSX.Prop = JSX.Prop (v6, v7)
let v9 : string = "base_table"
let v10 : (Heap1 -> JSX.Element) = closure2()
let v11 : JSX.Prop = JSX.Prop (v9, v10)
let v12 : string = "create_obj_props"
let v13 : ((struct (string * obj) []) -> Heap1) = closure4()
let v14 : JSX.Prop = JSX.Prop (v12, v13)
let v15 : string = "create_storeon"
let v16 : (obj -> obj) = closure5()
let v17 : JSX.Prop = JSX.Prop (v15, v16)
let v18 : string = "external_link"
let v19 : (Heap1 -> JSX.Element) = closure6()
let v20 : JSX.Prop = JSX.Prop (v18, v19)
let v21 : string = "links"
let v22 : (unit -> JSX.Element) = closure8()
let v23 : JSX.Prop = JSX.Prop (v21, v22)
let v24 : string = "loader"
let v25 : (Heap1 -> JSX.Element) = closure19()
let v26 : JSX.Prop = JSX.Prop (v24, v25)
let v27 : string = "row"
let v28 : (Heap1 -> JSX.Element) = closure10()
let v29 : JSX.Prop = JSX.Prop (v27, v28)
let v30 : string = "store"
let v31 : JSX.Prop = JSX.Prop (v30, v5)
let v32 : (JSX.Prop []) = [|v8; v11; v14; v17; v20; v23; v26; v29; v31|]
let v33 : obj = createObj v32
v1.l0 <- v33
()
