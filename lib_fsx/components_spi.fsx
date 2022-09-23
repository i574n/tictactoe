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
and Heap1 = {l0 : US1; l1 : US1; l2 : US2; l3 : US3; l4 : US4; l5 : US3; l6 : US3; l7 : US3; l8 : US3; l9 : US3; l10 : US3; l11 : US1; l12 : US5; l13 : US3; l14 : US3; l15 : US1; l16 : US3; l17 : US3; l18 : US1; l19 : US3; l20 : US3; l21 : US3; l22 : US3; l23 : US3; l24 : US6; l25 : US3; l26 : US3; l27 : US3; l28 : US7; l29 : US3; l30 : US3; l31 : US3; l32 : US3; l33 : US3; l34 : US8; l35 : US9; l36 : US3; l37 : US3; l38 : US3; l39 : US3; l40 : US3; l41 : US3; l42 : US3; l43 : US3; l44 : US3; l45 : US3; l46 : US3; l47 : US3; l48 : US1; l49 : US3; l50 : US3; l51 : US6; l52 : US3; l53 : US3; l54 : US0}
and [<Struct>] US10 =
    | US10_0
    | US10_1 of f1_0 : JSX.Prop
and Mut1 = {mutable l0 : int32; mutable l1 : int32}
and Mut2 = {mutable l0 : int32}
and Mut3 = {mutable l0 : int32; mutable l1 : US1; mutable l2 : US1; mutable l3 : US2; mutable l4 : US3; mutable l5 : US4; mutable l6 : US3; mutable l7 : US3; mutable l8 : US3; mutable l9 : US3; mutable l10 : US3; mutable l11 : US3; mutable l12 : US1; mutable l13 : US5; mutable l14 : US3; mutable l15 : US3; mutable l16 : US1; mutable l17 : US3; mutable l18 : US3; mutable l19 : US1; mutable l20 : US3; mutable l21 : US3; mutable l22 : US3; mutable l23 : US3; mutable l24 : US3; mutable l25 : US6; mutable l26 : US3; mutable l27 : US3; mutable l28 : US3; mutable l29 : US7; mutable l30 : US3; mutable l31 : US3; mutable l32 : US3; mutable l33 : US3; mutable l34 : US3; mutable l35 : US8; mutable l36 : US9; mutable l37 : US3; mutable l38 : US3; mutable l39 : US3; mutable l40 : US3; mutable l41 : US3; mutable l42 : US3; mutable l43 : US3; mutable l44 : US3; mutable l45 : US3; mutable l46 : US3; mutable l47 : US3; mutable l48 : US3; mutable l49 : US1; mutable l50 : US3; mutable l51 : US3; mutable l52 : US6; mutable l53 : US3; mutable l54 : US3; mutable l55 : US0}
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
and method3 () : struct (US1 * US1 * US2 * US3 * US4 * US3 * US3 * US3 * US3 * US3 * US3 * US1 * US5 * US3 * US3 * US1 * US3 * US3 * US1 * US3 * US3 * US3 * US3 * US3 * US6 * US3 * US3 * US3 * US7 * US3 * US3 * US3 * US3 * US3 * US8 * US9 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US1 * US3 * US3 * US6 * US3 * US3 * US0) =
    let v0 : US1 = US1_0
    let v1 : US1 = US1_0
    let v2 : US2 = US2_0
    let v3 : US3 = US3_0
    let v4 : US4 = US4_0
    let v5 : US3 = US3_0
    let v6 : US3 = US3_0
    let v7 : US3 = US3_0
    let v8 : US3 = US3_0
    let v9 : US3 = US3_0
    let v10 : US3 = US3_0
    let v11 : US1 = US1_0
    let v12 : US5 = US5_0
    let v13 : US3 = US3_0
    let v14 : US3 = US3_0
    let v15 : US1 = US1_0
    let v16 : US3 = US3_0
    let v17 : US3 = US3_0
    let v18 : US1 = US1_0
    let v19 : US3 = US3_0
    let v20 : US3 = US3_0
    let v21 : US3 = US3_0
    let v22 : US3 = US3_0
    let v23 : US3 = US3_0
    let v24 : US6 = US6_0
    let v25 : US3 = US3_0
    let v26 : US3 = US3_0
    let v27 : US3 = US3_0
    let v28 : US7 = US7_0
    let v29 : US3 = US3_0
    let v30 : US3 = US3_0
    let v31 : US3 = US3_0
    let v32 : US3 = US3_0
    let v33 : US3 = US3_0
    let v34 : US8 = US8_0
    let v35 : US9 = US9_0
    let v36 : US3 = US3_0
    let v37 : US3 = US3_0
    let v38 : US3 = US3_0
    let v39 : US3 = US3_0
    let v40 : US3 = US3_0
    let v41 : US3 = US3_0
    let v42 : US3 = US3_0
    let v43 : US3 = US3_0
    let v44 : US3 = US3_0
    let v45 : US3 = US3_0
    let v46 : US3 = US3_0
    let v47 : US3 = US3_0
    let v48 : US1 = US1_0
    let v49 : US3 = US3_0
    let v50 : US3 = US3_0
    let v51 : US6 = US6_0
    let v52 : US3 = US3_0
    let v53 : US3 = US3_0
    let v54 : US0 = US0_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54)
and method4 (v0 : Heap1, v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US1, v13 : US5, v14 : US3, v15 : US3, v16 : US1, v17 : US3, v18 : US3, v19 : US1, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US7, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US8, v36 : US9, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US1, v50 : US3, v51 : US3, v52 : US6, v53 : US3, v54 : US3, v55 : US0) : Heap1 =
    let v56 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55} : Heap1
    let v57 : US1 = v0.l0
    let v58 : US1 = v56.l0
    let v65 : US1 =
        match v58 with
        | US1_0 -> (* None *)
            match v57 with
            | US1_0 -> (* None *)
                US1_0
            | US1_1(v60) -> (* Some *)
                US1_1(v60)
        | US1_1(v63) -> (* Some *)
            US1_1(v63)
    let v66 : US1 = v0.l1
    let v67 : US1 = v56.l1
    let v74 : US1 =
        match v67 with
        | US1_0 -> (* None *)
            match v66 with
            | US1_0 -> (* None *)
                US1_0
            | US1_1(v69) -> (* Some *)
                US1_1(v69)
        | US1_1(v72) -> (* Some *)
            US1_1(v72)
    let v75 : US2 = v0.l2
    let v76 : US2 = v56.l2
    let v83 : US2 =
        match v76 with
        | US2_0 -> (* None *)
            match v75 with
            | US2_0 -> (* None *)
                US2_0
            | US2_1(v78) -> (* Some *)
                US2_1(v78)
        | US2_1(v81) -> (* Some *)
            US2_1(v81)
    let v84 : US3 = v0.l3
    let v85 : US3 = v56.l3
    let v92 : US3 =
        match v85 with
        | US3_0 -> (* None *)
            match v84 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v87) -> (* Some *)
                US3_1(v87)
        | US3_1(v90) -> (* Some *)
            US3_1(v90)
    let v93 : US4 = v0.l4
    let v94 : US4 = v56.l4
    let v101 : US4 =
        match v94 with
        | US4_0 -> (* None *)
            match v93 with
            | US4_0 -> (* None *)
                US4_0
            | US4_1(v96) -> (* Some *)
                US4_1(v96)
        | US4_1(v99) -> (* Some *)
            US4_1(v99)
    let v102 : US3 = v0.l5
    let v103 : US3 = v56.l5
    let v110 : US3 =
        match v103 with
        | US3_0 -> (* None *)
            match v102 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v105) -> (* Some *)
                US3_1(v105)
        | US3_1(v108) -> (* Some *)
            US3_1(v108)
    let v111 : US3 = v0.l6
    let v112 : US3 = v56.l6
    let v119 : US3 =
        match v112 with
        | US3_0 -> (* None *)
            match v111 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v114) -> (* Some *)
                US3_1(v114)
        | US3_1(v117) -> (* Some *)
            US3_1(v117)
    let v120 : US3 = v0.l9
    let v121 : US3 = v56.l9
    let v128 : US3 =
        match v121 with
        | US3_0 -> (* None *)
            match v120 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v123) -> (* Some *)
                US3_1(v123)
        | US3_1(v126) -> (* Some *)
            US3_1(v126)
    let v129 : US3 = v0.l7
    let v130 : US3 = v56.l7
    let v137 : US3 =
        match v130 with
        | US3_0 -> (* None *)
            match v129 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v132) -> (* Some *)
                US3_1(v132)
        | US3_1(v135) -> (* Some *)
            US3_1(v135)
    let v138 : US3 = v0.l8
    let v139 : US3 = v56.l8
    let v146 : US3 =
        match v139 with
        | US3_0 -> (* None *)
            match v138 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v141) -> (* Some *)
                US3_1(v141)
        | US3_1(v144) -> (* Some *)
            US3_1(v144)
    let v147 : US3 = v0.l10
    let v148 : US3 = v56.l10
    let v155 : US3 =
        match v148 with
        | US3_0 -> (* None *)
            match v147 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v150) -> (* Some *)
                US3_1(v150)
        | US3_1(v153) -> (* Some *)
            US3_1(v153)
    let v156 : US3 = v0.l13
    let v157 : US3 = v56.l13
    let v164 : US3 =
        match v157 with
        | US3_0 -> (* None *)
            match v156 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v159) -> (* Some *)
                US3_1(v159)
        | US3_1(v162) -> (* Some *)
            US3_1(v162)
    let v165 : US1 = v0.l11
    let v166 : US1 = v56.l11
    let v173 : US1 =
        match v166 with
        | US1_0 -> (* None *)
            match v165 with
            | US1_0 -> (* None *)
                US1_0
            | US1_1(v168) -> (* Some *)
                US1_1(v168)
        | US1_1(v171) -> (* Some *)
            US1_1(v171)
    let v174 : US5 = v0.l12
    let v175 : US5 = v56.l12
    let v182 : US5 =
        match v175 with
        | US5_0 -> (* None *)
            match v174 with
            | US5_0 -> (* None *)
                US5_0
            | US5_1(v177) -> (* Some *)
                US5_1(v177)
        | US5_1(v180) -> (* Some *)
            US5_1(v180)
    let v183 : US3 = v0.l14
    let v184 : US3 = v56.l14
    let v191 : US3 =
        match v184 with
        | US3_0 -> (* None *)
            match v183 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v186) -> (* Some *)
                US3_1(v186)
        | US3_1(v189) -> (* Some *)
            US3_1(v189)
    let v192 : US1 = v0.l15
    let v193 : US1 = v56.l15
    let v200 : US1 =
        match v193 with
        | US1_0 -> (* None *)
            match v192 with
            | US1_0 -> (* None *)
                US1_0
            | US1_1(v195) -> (* Some *)
                US1_1(v195)
        | US1_1(v198) -> (* Some *)
            US1_1(v198)
    let v201 : US3 = v0.l16
    let v202 : US3 = v56.l16
    let v209 : US3 =
        match v202 with
        | US3_0 -> (* None *)
            match v201 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v204) -> (* Some *)
                US3_1(v204)
        | US3_1(v207) -> (* Some *)
            US3_1(v207)
    let v210 : US3 = v0.l17
    let v211 : US3 = v56.l17
    let v218 : US3 =
        match v211 with
        | US3_0 -> (* None *)
            match v210 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v213) -> (* Some *)
                US3_1(v213)
        | US3_1(v216) -> (* Some *)
            US3_1(v216)
    let v219 : US1 = v0.l18
    let v220 : US1 = v56.l18
    let v227 : US1 =
        match v220 with
        | US1_0 -> (* None *)
            match v219 with
            | US1_0 -> (* None *)
                US1_0
            | US1_1(v222) -> (* Some *)
                US1_1(v222)
        | US1_1(v225) -> (* Some *)
            US1_1(v225)
    let v228 : US3 = v0.l19
    let v229 : US3 = v56.l19
    let v236 : US3 =
        match v229 with
        | US3_0 -> (* None *)
            match v228 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v231) -> (* Some *)
                US3_1(v231)
        | US3_1(v234) -> (* Some *)
            US3_1(v234)
    let v237 : US3 = v0.l20
    let v238 : US3 = v56.l20
    let v245 : US3 =
        match v238 with
        | US3_0 -> (* None *)
            match v237 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v240) -> (* Some *)
                US3_1(v240)
        | US3_1(v243) -> (* Some *)
            US3_1(v243)
    let v246 : US3 = v0.l21
    let v247 : US3 = v56.l21
    let v254 : US3 =
        match v247 with
        | US3_0 -> (* None *)
            match v246 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v249) -> (* Some *)
                US3_1(v249)
        | US3_1(v252) -> (* Some *)
            US3_1(v252)
    let v255 : US3 = v0.l22
    let v256 : US3 = v56.l22
    let v263 : US3 =
        match v256 with
        | US3_0 -> (* None *)
            match v255 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v258) -> (* Some *)
                US3_1(v258)
        | US3_1(v261) -> (* Some *)
            US3_1(v261)
    let v264 : US3 = v0.l23
    let v265 : US3 = v56.l23
    let v272 : US3 =
        match v265 with
        | US3_0 -> (* None *)
            match v264 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v267) -> (* Some *)
                US3_1(v267)
        | US3_1(v270) -> (* Some *)
            US3_1(v270)
    let v273 : US6 = v0.l24
    let v274 : US6 = v56.l24
    let v281 : US6 =
        match v274 with
        | US6_0 -> (* None *)
            match v273 with
            | US6_0 -> (* None *)
                US6_0
            | US6_1(v276) -> (* Some *)
                US6_1(v276)
        | US6_1(v279) -> (* Some *)
            US6_1(v279)
    let v282 : US3 = v0.l25
    let v283 : US3 = v56.l25
    let v290 : US3 =
        match v283 with
        | US3_0 -> (* None *)
            match v282 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v285) -> (* Some *)
                US3_1(v285)
        | US3_1(v288) -> (* Some *)
            US3_1(v288)
    let v291 : US1 = v0.l48
    let v292 : US1 = v56.l48
    let v299 : US1 =
        match v292 with
        | US1_0 -> (* None *)
            match v291 with
            | US1_0 -> (* None *)
                US1_0
            | US1_1(v294) -> (* Some *)
                US1_1(v294)
        | US1_1(v297) -> (* Some *)
            US1_1(v297)
    let v300 : US3 = v0.l26
    let v301 : US3 = v56.l26
    let v308 : US3 =
        match v301 with
        | US3_0 -> (* None *)
            match v300 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v303) -> (* Some *)
                US3_1(v303)
        | US3_1(v306) -> (* Some *)
            US3_1(v306)
    let v309 : US3 = v0.l27
    let v310 : US3 = v56.l27
    let v317 : US3 =
        match v310 with
        | US3_0 -> (* None *)
            match v309 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v312) -> (* Some *)
                US3_1(v312)
        | US3_1(v315) -> (* Some *)
            US3_1(v315)
    let v318 : US7 = v0.l28
    let v319 : US7 = v56.l28
    let v326 : US7 =
        match v319 with
        | US7_0 -> (* None *)
            match v318 with
            | US7_0 -> (* None *)
                US7_0
            | US7_1(v321) -> (* Some *)
                US7_1(v321)
        | US7_1(v324) -> (* Some *)
            US7_1(v324)
    let v327 : US3 = v0.l29
    let v328 : US3 = v56.l29
    let v335 : US3 =
        match v328 with
        | US3_0 -> (* None *)
            match v327 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v330) -> (* Some *)
                US3_1(v330)
        | US3_1(v333) -> (* Some *)
            US3_1(v333)
    let v336 : US3 = v0.l30
    let v337 : US3 = v56.l30
    let v344 : US3 =
        match v337 with
        | US3_0 -> (* None *)
            match v336 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v339) -> (* Some *)
                US3_1(v339)
        | US3_1(v342) -> (* Some *)
            US3_1(v342)
    let v345 : US3 = v0.l31
    let v346 : US3 = v56.l31
    let v353 : US3 =
        match v346 with
        | US3_0 -> (* None *)
            match v345 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v348) -> (* Some *)
                US3_1(v348)
        | US3_1(v351) -> (* Some *)
            US3_1(v351)
    let v354 : US3 = v0.l32
    let v355 : US3 = v56.l32
    let v362 : US3 =
        match v355 with
        | US3_0 -> (* None *)
            match v354 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v357) -> (* Some *)
                US3_1(v357)
        | US3_1(v360) -> (* Some *)
            US3_1(v360)
    let v363 : US3 = v0.l33
    let v364 : US3 = v56.l33
    let v371 : US3 =
        match v364 with
        | US3_0 -> (* None *)
            match v363 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v366) -> (* Some *)
                US3_1(v366)
        | US3_1(v369) -> (* Some *)
            US3_1(v369)
    let v372 : US8 = v0.l34
    let v373 : US8 = v56.l34
    let v380 : US8 =
        match v373 with
        | US8_0 -> (* None *)
            match v372 with
            | US8_0 -> (* None *)
                US8_0
            | US8_1(v375) -> (* Some *)
                US8_1(v375)
        | US8_1(v378) -> (* Some *)
            US8_1(v378)
    let v381 : US9 = v0.l35
    let v382 : US9 = v56.l35
    let v389 : US9 =
        match v382 with
        | US9_0 -> (* None *)
            match v381 with
            | US9_0 -> (* None *)
                US9_0
            | US9_1(v384) -> (* Some *)
                US9_1(v384)
        | US9_1(v387) -> (* Some *)
            US9_1(v387)
    let v390 : US3 = v0.l36
    let v391 : US3 = v56.l36
    let v398 : US3 =
        match v391 with
        | US3_0 -> (* None *)
            match v390 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v393) -> (* Some *)
                US3_1(v393)
        | US3_1(v396) -> (* Some *)
            US3_1(v396)
    let v399 : US3 = v0.l37
    let v400 : US3 = v56.l37
    let v407 : US3 =
        match v400 with
        | US3_0 -> (* None *)
            match v399 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v402) -> (* Some *)
                US3_1(v402)
        | US3_1(v405) -> (* Some *)
            US3_1(v405)
    let v408 : US3 = v0.l38
    let v409 : US3 = v56.l38
    let v416 : US3 =
        match v409 with
        | US3_0 -> (* None *)
            match v408 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v411) -> (* Some *)
                US3_1(v411)
        | US3_1(v414) -> (* Some *)
            US3_1(v414)
    let v417 : US3 = v0.l39
    let v418 : US3 = v56.l39
    let v425 : US3 =
        match v418 with
        | US3_0 -> (* None *)
            match v417 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v420) -> (* Some *)
                US3_1(v420)
        | US3_1(v423) -> (* Some *)
            US3_1(v423)
    let v426 : US3 = v0.l43
    let v427 : US3 = v56.l43
    let v434 : US3 =
        match v427 with
        | US3_0 -> (* None *)
            match v426 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v429) -> (* Some *)
                US3_1(v429)
        | US3_1(v432) -> (* Some *)
            US3_1(v432)
    let v435 : US3 = v0.l42
    let v436 : US3 = v56.l42
    let v443 : US3 =
        match v436 with
        | US3_0 -> (* None *)
            match v435 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v438) -> (* Some *)
                US3_1(v438)
        | US3_1(v441) -> (* Some *)
            US3_1(v441)
    let v444 : US3 = v0.l40
    let v445 : US3 = v56.l40
    let v452 : US3 =
        match v445 with
        | US3_0 -> (* None *)
            match v444 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v447) -> (* Some *)
                US3_1(v447)
        | US3_1(v450) -> (* Some *)
            US3_1(v450)
    let v453 : US3 = v0.l41
    let v454 : US3 = v56.l41
    let v461 : US3 =
        match v454 with
        | US3_0 -> (* None *)
            match v453 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v456) -> (* Some *)
                US3_1(v456)
        | US3_1(v459) -> (* Some *)
            US3_1(v459)
    let v462 : US3 = v0.l44
    let v463 : US3 = v56.l44
    let v470 : US3 =
        match v463 with
        | US3_0 -> (* None *)
            match v462 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v465) -> (* Some *)
                US3_1(v465)
        | US3_1(v468) -> (* Some *)
            US3_1(v468)
    let v471 : US3 = v0.l45
    let v472 : US3 = v56.l45
    let v479 : US3 =
        match v472 with
        | US3_0 -> (* None *)
            match v471 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v474) -> (* Some *)
                US3_1(v474)
        | US3_1(v477) -> (* Some *)
            US3_1(v477)
    let v480 : US3 = v0.l46
    let v481 : US3 = v56.l46
    let v488 : US3 =
        match v481 with
        | US3_0 -> (* None *)
            match v480 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v483) -> (* Some *)
                US3_1(v483)
        | US3_1(v486) -> (* Some *)
            US3_1(v486)
    let v489 : US3 = v0.l47
    let v490 : US3 = v56.l47
    let v497 : US3 =
        match v490 with
        | US3_0 -> (* None *)
            match v489 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v492) -> (* Some *)
                US3_1(v492)
        | US3_1(v495) -> (* Some *)
            US3_1(v495)
    let v498 : US3 = v0.l49
    let v499 : US3 = v56.l49
    let v506 : US3 =
        match v499 with
        | US3_0 -> (* None *)
            match v498 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v501) -> (* Some *)
                US3_1(v501)
        | US3_1(v504) -> (* Some *)
            US3_1(v504)
    let v507 : US3 = v0.l50
    let v508 : US3 = v56.l50
    let v515 : US3 =
        match v508 with
        | US3_0 -> (* None *)
            match v507 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v510) -> (* Some *)
                US3_1(v510)
        | US3_1(v513) -> (* Some *)
            US3_1(v513)
    let v516 : US6 = v0.l51
    let v517 : US6 = v56.l51
    let v524 : US6 =
        match v517 with
        | US6_0 -> (* None *)
            match v516 with
            | US6_0 -> (* None *)
                US6_0
            | US6_1(v519) -> (* Some *)
                US6_1(v519)
        | US6_1(v522) -> (* Some *)
            US6_1(v522)
    let v525 : US3 = v0.l52
    let v526 : US3 = v56.l52
    let v533 : US3 =
        match v526 with
        | US3_0 -> (* None *)
            match v525 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v528) -> (* Some *)
                US3_1(v528)
        | US3_1(v531) -> (* Some *)
            US3_1(v531)
    let v534 : US3 = v0.l53
    let v535 : US3 = v56.l53
    let v542 : US3 =
        match v535 with
        | US3_0 -> (* None *)
            match v534 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v537) -> (* Some *)
                US3_1(v537)
        | US3_1(v540) -> (* Some *)
            US3_1(v540)
    let v543 : US0 = v0.l54
    let v544 : US0 = v56.l54
    let v551 : US0 =
        match v544 with
        | US0_0 -> (* None *)
            match v543 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v546) -> (* Some *)
                US0_1(v546)
        | US0_1(v549) -> (* Some *)
            US0_1(v549)
    {l0 = v65; l1 = v74; l2 = v83; l3 = v92; l4 = v101; l5 = v110; l6 = v119; l7 = v137; l8 = v146; l9 = v128; l10 = v155; l11 = v173; l12 = v182; l13 = v164; l14 = v191; l15 = v200; l16 = v209; l17 = v218; l18 = v227; l19 = v236; l20 = v245; l21 = v254; l22 = v263; l23 = v272; l24 = v281; l25 = v290; l26 = v308; l27 = v317; l28 = v326; l29 = v335; l30 = v344; l31 = v353; l32 = v362; l33 = v371; l34 = v380; l35 = v389; l36 = v398; l37 = v407; l38 = v416; l39 = v425; l40 = v452; l41 = v461; l42 = v443; l43 = v434; l44 = v470; l45 = v479; l46 = v488; l47 = v497; l48 = v299; l49 = v506; l50 = v515; l51 = v524; l52 = v533; l53 = v542; l54 = v551} : Heap1
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
and method10 (v0 : string, v1 : US6) : US10 =
    match v1 with
    | US6_0 -> (* None *)
        US10_0
    | US6_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US10_1(v4)
and method11 (v0 : string, v1 : US7) : US10 =
    match v1 with
    | US7_0 -> (* None *)
        US10_0
    | US7_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US10_1(v4)
and method12 (v0 : string, v1 : US8) : US10 =
    match v1 with
    | US8_0 -> (* None *)
        US10_0
    | US8_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US10_1(v4)
and method13 (v0 : string, v1 : US9) : US10 =
    match v1 with
    | US9_0 -> (* None *)
        US10_0
    | US9_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US10_1(v4)
and method14 (v0 : string, v1 : US0) : US10 =
    match v1 with
    | US0_0 -> (* None *)
        US10_0
    | US0_1(v3) -> (* Some *)
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
    let v13 : string = "borderWidth"
    let v14 : US3 = v0.l9
    let v15 : US10 = method6(v13, v14)
    let v16 : string = "borderBottomWidth"
    let v17 : US3 = v0.l7
    let v18 : US10 = method6(v16, v17)
    let v19 : string = "borderColor"
    let v20 : US3 = v0.l8
    let v21 : US10 = method6(v19, v20)
    let v22 : string = "bottom"
    let v23 : US3 = v0.l10
    let v24 : US10 = method6(v22, v23)
    let v25 : string = "color"
    let v26 : US3 = v0.l13
    let v27 : US10 = method6(v25, v26)
    let v28 : string = "checked"
    let v29 : US1 = v0.l11
    let v30 : US10 = method8(v28, v29)
    let v31 : string = "children"
    let v32 : US5 = v0.l12
    let v33 : US10 = method9(v31, v32)
    let v34 : string = "colorScheme"
    let v35 : US3 = v0.l14
    let v36 : US10 = method6(v34, v35)
    let v37 : string = "compact"
    let v38 : US1 = v0.l15
    let v39 : US10 = method8(v37, v38)
    let v40 : string = "display"
    let v41 : US3 = v0.l17
    let v42 : US10 = method6(v40, v41)
    let v43 : string = "direction"
    let v44 : US3 = v0.l16
    let v45 : US10 = method6(v43, v44)
    let v46 : string = "external"
    let v47 : US1 = v0.l18
    let v48 : US10 = method8(v46, v47)
    let v49 : string = "flex"
    let v50 : US3 = v0.l19
    let v51 : US10 = method6(v49, v50)
    let v52 : string = "flexDirection"
    let v53 : US3 = v0.l20
    let v54 : US10 = method6(v52, v53)
    let v55 : string = "fontSize"
    let v56 : US3 = v0.l21
    let v57 : US10 = method6(v55, v56)
    let v58 : string = "height"
    let v59 : US3 = v0.l22
    let v60 : US10 = method6(v58, v59)
    let v61 : string = "href"
    let v62 : US3 = v0.l23
    let v63 : US10 = method6(v61, v62)
    let v64 : string = "icon"
    let v65 : US6 = v0.l24
    let v66 : US10 = method10(v64, v65)
    let v67 : string = "id"
    let v68 : US3 = v0.l25
    let v69 : US10 = method6(v67, v68)
    let v70 : string = "justifyContent"
    let v71 : US3 = v0.l26
    let v72 : US10 = method6(v70, v71)
    let v73 : string = "left"
    let v74 : US3 = v0.l27
    let v75 : US10 = method6(v73, v74)
    let v76 : string = "leftIcon"
    let v77 : US7 = v0.l28
    let v78 : US10 = method11(v76, v77)
    let v79 : string = "lineHeight"
    let v80 : US3 = v0.l29
    let v81 : US10 = method6(v79, v80)
    let v82 : string = "margin"
    let v83 : US3 = v0.l30
    let v84 : US10 = method6(v82, v83)
    let v85 : string = "marginBottom"
    let v86 : US3 = v0.l31
    let v87 : US10 = method6(v85, v86)
    let v88 : string = "marginTop"
    let v89 : US3 = v0.l32
    let v90 : US10 = method6(v88, v89)
    let v91 : string = "maxHeight"
    let v92 : US3 = v0.l33
    let v93 : US10 = method6(v91, v92)
    let v94 : string = "onChange"
    let v95 : US8 = v0.l34
    let v96 : US10 = method12(v94, v95)
    let v97 : string = "onClick"
    let v98 : US9 = v0.l35
    let v99 : US10 = method13(v97, v98)
    let v100 : string = "outline"
    let v101 : US3 = v0.l36
    let v102 : US10 = method6(v100, v101)
    let v103 : string = "overflowX"
    let v104 : US3 = v0.l37
    let v105 : US10 = method6(v103, v104)
    let v106 : string = "overflowY"
    let v107 : US3 = v0.l38
    let v108 : US10 = method6(v106, v107)
    let v109 : string = "padding"
    let v110 : US3 = v0.l39
    let v111 : US10 = method6(v109, v110)
    let v112 : string = "paddingTop"
    let v113 : US3 = v0.l43
    let v114 : US10 = method6(v112, v113)
    let v115 : string = "paddingRight"
    let v116 : US3 = v0.l42
    let v117 : US10 = method6(v115, v116)
    let v118 : string = "paddingBottom"
    let v119 : US3 = v0.l40
    let v120 : US10 = method6(v118, v119)
    let v121 : string = "paddingLeft"
    let v122 : US3 = v0.l41
    let v123 : US10 = method6(v121, v122)
    let v124 : string = "position"
    let v125 : US3 = v0.l44
    let v126 : US10 = method6(v124, v125)
    let v127 : string = "right"
    let v128 : US3 = v0.l45
    let v129 : US10 = method6(v127, v128)
    let v130 : string = "size"
    let v131 : US3 = v0.l46
    let v132 : US10 = method6(v130, v131)
    let v133 : string = "spacing"
    let v134 : US3 = v0.l47
    let v135 : US10 = method6(v133, v134)
    let v136 : string = "status"
    let v137 : US1 = v0.l48
    let v138 : US10 = method8(v136, v137)
    let v139 : string = "striped"
    let v140 : US3 = v0.l49
    let v141 : US10 = method6(v139, v140)
    let v142 : string = "thickness"
    let v143 : US3 = v0.l50
    let v144 : US10 = method6(v142, v143)
    let v145 : string = "title"
    let v146 : US6 = v0.l51
    let v147 : US10 = method10(v145, v146)
    let v148 : string = "top"
    let v149 : US3 = v0.l52
    let v150 : US10 = method6(v148, v149)
    let v151 : string = "width"
    let v152 : US3 = v0.l53
    let v153 : US10 = method6(v151, v152)
    let v154 : string = "zIndex"
    let v155 : US0 = v0.l54
    let v156 : US10 = method14(v154, v155)
    let v157 : (US10 []) = [|v3; v6; v9; v12; v15; v18; v21; v24; v27; v30; v33; v36; v39; v42; v45; v48; v51; v54; v57; v60; v63; v66; v69; v72; v75; v78; v81; v84; v87; v90; v93; v96; v99; v102; v105; v108; v111; v114; v117; v120; v123; v126; v129; v132; v135; v138; v141; v144; v147; v150; v153; v156|]
    let v158 : int32 = v157.Length
    let v159 : (US10 []) = Array.zeroCreate<US10> (v158)
    let v160 : Mut1 = {l0 = 0; l1 = 0} : Mut1
    while method15(v158, v160) do
        let v162 : int32 = v160.l0
        let v163 : int32 = v160.l1
        let v164 : US10 = v157.[int v162]
        let v166 : bool =
            match v164 with
            | US10_0 -> (* None *)
                false
            | US10_1(v165) -> (* Some *)
                true
        let v168 : int32 =
            if v166 then
                v159.[int v163] <- v164
                let v167 : int32 = v163 + 1
                v167
            else
                v163
        let v169 : int32 = v162 + 1
        v160.l0 <- v169
        v160.l1 <- v168
        ()
    let v170 : int32 = v160.l1
    let v171 : (US10 []) = Array.zeroCreate<US10> (v170)
    let v172 : Mut2 = {l0 = 0} : Mut2
    while method16(v170, v172) do
        let v174 : int32 = v172.l0
        let v175 : US10 = v159.[int v174]
        v171.[int v174] <- v175
        let v176 : int32 = v174 + 1
        v172.l0 <- v176
        ()
    let v177 : int32 = v171.Length
    let v178 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v177)
    let v179 : Mut2 = {l0 = 0} : Mut2
    while method16(v177, v179) do
        let v181 : int32 = v179.l0
        let v182 : US10 = v171.[int v181]
        let v185 : JSX.Prop =
            match v182 with
            | US10_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US10_1(v184) -> (* Some *)
                v184
        v178.[int v181] <- v185
        let v186 : int32 = v181 + 1
        v179.l0 <- v186
        ()
    v178
and method2 (v0 : Heap1) : JSX.Element =
    let struct (v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US1, v13 : US5, v14 : US3, v15 : US3, v16 : US1, v17 : US3, v18 : US3, v19 : US1, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US7, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US8, v36 : US9, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US1, v50 : US3, v51 : US3, v52 : US6, v53 : US3, v54 : US3, v55 : US0) = method3()
    let v56 : string = "neutral"
    let v57 : US3 = US3_1(v56)
    let v58 : bool = true
    let v59 : US1 = US1_1(v58)
    let v60 : string = "left"
    let v61 : US3 = US3_1(v60)
    let v62 : string = "xs"
    let v63 : US3 = US3_1(v62)
    let v64 : Heap1 = method4(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v57, v59, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v61, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v63, v48, v49, v50, v51, v52, v53, v54, v55)
    let v65 : (JSX.Prop []) = method5(v64)
    let v66 : obj = createObj v65
    let v67 : string = "createComponent"
    let v68 : string = "solid-js"
    let v69 : JS.Function = import v67 v68
    let v70 : string = "Button"
    let v71 : string = "@hope-ui/solid"
    let v72 : JSX.Element = v69.Invoke ((import v70 v71), v66) |> unbox<JSX.Element>
    v72
and closure1 () (v0 : Heap1) : JSX.Element =
    method2(v0)
and closure3 (v0 : Heap1, v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US1, v13 : US5, v14 : US3, v15 : US3, v16 : US1, v17 : US3, v18 : US3, v19 : US1, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US7, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US8, v36 : US9, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US1, v50 : US3, v51 : US3, v52 : US6, v53 : US3, v54 : US3, v55 : US0) () : JSX.Element =
    let v56 : US5 = v0.l12
    let v57 : string = "$blackAlpha3"
    let v58 : US3 = US3_1(v57)
    let v59 : string = "flex"
    let v60 : US3 = US3_1(v59)
    let v61 : string = "column"
    let v62 : US3 = US3_1(v61)
    let v63 : string = "-1px"
    let v64 : US3 = US3_1(v63)
    let v65 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v58; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v56; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v60; l18 = v19; l19 = v20; l20 = v62; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v64; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55} : Heap1
    let v66 : (JSX.Prop []) = method5(v65)
    let v67 : obj = createObj v66
    let v68 : string = "createComponent"
    let v69 : string = "solid-js"
    let v70 : JS.Function = import v68 v69
    let v71 : string = "Tbody"
    let v72 : string = "@hope-ui/solid"
    let v73 : JSX.Element = v70.Invoke ((import v71 v72), v67) |> unbox<JSX.Element>
    let v74 : (JSX.Element []) = [|v73|]
    let v75 : JSX.Element = v74 |> unbox<JSX.Element>
    v75
and method17 (v0 : Heap1) : JSX.Element =
    let struct (v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US1, v13 : US5, v14 : US3, v15 : US3, v16 : US1, v17 : US3, v18 : US3, v19 : US1, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US7, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US8, v36 : US9, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US1, v50 : US3, v51 : US3, v52 : US6, v53 : US3, v54 : US3, v55 : US0) = method3()
    let v56 : US3 = v0.l38
    let v59 : string =
        match v56 with
        | US3_0 -> (* None *)
            let v57 : string = "hidden"
            v57
        | US3_1(v58) -> (* Some *)
            v58
    let v60 : (unit -> JSX.Element) = closure3(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55)
    let v61 : US5 = US5_1(v60)
    let v62 : string = "flex"
    let v63 : US3 = US3_1(v62)
    let v64 : string = "1"
    let v65 : US3 = US3_1(v64)
    let v66 : string = "column"
    let v67 : US3 = US3_1(v66)
    let v68 : string = "hidden"
    let v69 : US3 = US3_1(v68)
    let v70 : US3 = US3_1(v59)
    let v71 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v61; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v63; l18 = v19; l19 = v65; l20 = v67; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v69; l38 = v70; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55} : Heap1
    let v72 : (JSX.Prop []) = method5(v71)
    let v73 : obj = createObj v72
    let v74 : string = "createComponent"
    let v75 : string = "solid-js"
    let v76 : JS.Function = import v74 v75
    let v77 : string = "Table"
    let v78 : string = "@hope-ui/solid"
    let v79 : JSX.Element = v76.Invoke ((import v77 v78), v73) |> unbox<JSX.Element>
    v79
and closure2 () (v0 : Heap1) : JSX.Element =
    method17(v0)
and method19 (v0 : int32, v1 : Mut3) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method18 (v0 : (struct (string * obj) [])) : Heap1 =
    let struct (v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US1, v13 : US5, v14 : US3, v15 : US3, v16 : US1, v17 : US3, v18 : US3, v19 : US1, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US7, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US8, v36 : US9, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US1, v50 : US3, v51 : US3, v52 : US6, v53 : US3, v54 : US3, v55 : US0) = method3()
    let v56 : int32 = v0.Length
    let v57 : Mut3 = {l0 = 0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55} : Mut3
    while method19(v56, v57) do
        let v59 : int32 = v57.l0
        let struct (v60 : US1, v61 : US1, v62 : US2, v63 : US3, v64 : US4, v65 : US3, v66 : US3, v67 : US3, v68 : US3, v69 : US3, v70 : US3, v71 : US1, v72 : US5, v73 : US3, v74 : US3, v75 : US1, v76 : US3, v77 : US3, v78 : US1, v79 : US3, v80 : US3, v81 : US3, v82 : US3, v83 : US3, v84 : US6, v85 : US3, v86 : US3, v87 : US3, v88 : US7, v89 : US3, v90 : US3, v91 : US3, v92 : US3, v93 : US3, v94 : US8, v95 : US9, v96 : US3, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US1, v109 : US3, v110 : US3, v111 : US6, v112 : US3, v113 : US3, v114 : US0) = v57.l1, v57.l2, v57.l3, v57.l4, v57.l5, v57.l6, v57.l7, v57.l8, v57.l9, v57.l10, v57.l11, v57.l12, v57.l13, v57.l14, v57.l15, v57.l16, v57.l17, v57.l18, v57.l19, v57.l20, v57.l21, v57.l22, v57.l23, v57.l24, v57.l25, v57.l26, v57.l27, v57.l28, v57.l29, v57.l30, v57.l31, v57.l32, v57.l33, v57.l34, v57.l35, v57.l36, v57.l37, v57.l38, v57.l39, v57.l40, v57.l41, v57.l42, v57.l43, v57.l44, v57.l45, v57.l46, v57.l47, v57.l48, v57.l49, v57.l50, v57.l51, v57.l52, v57.l53, v57.l54, v57.l55
        let struct (v115 : string, v116 : obj) = v0.[int v59]
        let v117 : bool = v116 = JS.undefined
        let struct (v3364 : US1, v3365 : US1, v3366 : US2, v3367 : US3, v3368 : US4, v3369 : US3, v3370 : US3, v3371 : US3, v3372 : US3, v3373 : US3, v3374 : US3, v3375 : US1, v3376 : US5, v3377 : US3, v3378 : US3, v3379 : US1, v3380 : US3, v3381 : US3, v3382 : US1, v3383 : US3, v3384 : US3, v3385 : US3, v3386 : US3, v3387 : US3, v3388 : US6, v3389 : US3, v3390 : US3, v3391 : US3, v3392 : US7, v3393 : US3, v3394 : US3, v3395 : US3, v3396 : US3, v3397 : US3, v3398 : US8, v3399 : US9, v3400 : US3, v3401 : US3, v3402 : US3, v3403 : US3, v3404 : US3, v3405 : US3, v3406 : US3, v3407 : US3, v3408 : US3, v3409 : US3, v3410 : US3, v3411 : US3, v3412 : US1, v3413 : US3, v3414 : US3, v3415 : US6, v3416 : US3, v3417 : US3, v3418 : US0) =
            if v117 then
                struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
            else
                let v118 : bool = "_loaded" = v115
                if v118 then
                    let v119 : bool = v116 |> unbox
                    let v120 : US1 = US1_1(v119)
                    struct (v120, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                else
                    let v121 : bool = "_modal" = v115
                    if v121 then
                        let v122 : bool = v116 |> unbox
                        let v123 : US1 = US1_1(v122)
                        struct (v60, v123, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                    else
                        let v124 : bool = "_on_load" = v115
                        if v124 then
                            let v125 : (obj -> ((obj -> unit) -> unit)) = v116 |> unbox
                            let v126 : US2 = US2_1(v125)
                            struct (v60, v61, v126, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                        else
                            let v127 : bool = "aria-label" = v115
                            if v127 then
                                let v128 : string = v116 |> unbox
                                let v129 : US3 = US3_1(v128)
                                struct (v60, v61, v62, v129, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                            else
                                let v130 : bool = "as" = v115
                                if v130 then
                                    let v131 : JS.Function = v116 |> unbox
                                    let v132 : US4 = US4_1(v131)
                                    struct (v60, v61, v62, v63, v132, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                else
                                    let v133 : bool = "backgroundColor" = v115
                                    if v133 then
                                        let v134 : string = v116 |> unbox
                                        let v135 : US3 = US3_1(v134)
                                        struct (v60, v61, v62, v63, v64, v135, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                    else
                                        let v136 : bool = "border" = v115
                                        if v136 then
                                            let v137 : string = v116 |> unbox
                                            let v138 : US3 = US3_1(v137)
                                            struct (v60, v61, v62, v63, v64, v65, v138, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                        else
                                            let v139 : bool = "borderWidth" = v115
                                            if v139 then
                                                let v140 : string = v116 |> unbox
                                                let v141 : US3 = US3_1(v140)
                                                struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v141, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                            else
                                                let v142 : bool = "borderBottomWidth" = v115
                                                if v142 then
                                                    let v143 : string = v116 |> unbox
                                                    let v144 : US3 = US3_1(v143)
                                                    struct (v60, v61, v62, v63, v64, v65, v66, v144, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                else
                                                    let v145 : bool = "borderColor" = v115
                                                    if v145 then
                                                        let v146 : string = v116 |> unbox
                                                        let v147 : US3 = US3_1(v146)
                                                        struct (v60, v61, v62, v63, v64, v65, v66, v67, v147, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                    else
                                                        let v148 : bool = "bottom" = v115
                                                        if v148 then
                                                            let v149 : string = v116 |> unbox
                                                            let v150 : US3 = US3_1(v149)
                                                            struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v150, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                        else
                                                            let v151 : bool = "color" = v115
                                                            if v151 then
                                                                let v152 : string = v116 |> unbox
                                                                let v153 : US3 = US3_1(v152)
                                                                struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v153, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                            else
                                                                let v154 : bool = "checked" = v115
                                                                if v154 then
                                                                    let v155 : bool = v116 |> unbox
                                                                    let v156 : US1 = US1_1(v155)
                                                                    struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v156, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                else
                                                                    let v157 : bool = "children" = v115
                                                                    if v157 then
                                                                        let v158 : (unit -> JSX.Element) = v116 |> unbox
                                                                        let v159 : US5 = US5_1(v158)
                                                                        struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v159, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                    else
                                                                        let v160 : bool = "colorScheme" = v115
                                                                        if v160 then
                                                                            let v161 : string = v116 |> unbox
                                                                            let v162 : US3 = US3_1(v161)
                                                                            struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v162, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                        else
                                                                            let v163 : bool = "compact" = v115
                                                                            if v163 then
                                                                                let v164 : bool = v116 |> unbox
                                                                                let v165 : US1 = US1_1(v164)
                                                                                struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v165, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                            else
                                                                                let v166 : bool = "display" = v115
                                                                                if v166 then
                                                                                    let v167 : string = v116 |> unbox
                                                                                    let v168 : US3 = US3_1(v167)
                                                                                    struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v168, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                else
                                                                                    let v169 : bool = "direction" = v115
                                                                                    if v169 then
                                                                                        let v170 : string = v116 |> unbox
                                                                                        let v171 : US3 = US3_1(v170)
                                                                                        struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v171, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                    else
                                                                                        let v172 : bool = "external" = v115
                                                                                        if v172 then
                                                                                            let v173 : bool = v116 |> unbox
                                                                                            let v174 : US1 = US1_1(v173)
                                                                                            struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v174, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                        else
                                                                                            let v175 : bool = "flex" = v115
                                                                                            if v175 then
                                                                                                let v176 : string = v116 |> unbox
                                                                                                let v177 : US3 = US3_1(v176)
                                                                                                struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v177, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                            else
                                                                                                let v178 : bool = "flexDirection" = v115
                                                                                                if v178 then
                                                                                                    let v179 : string = v116 |> unbox
                                                                                                    let v180 : US3 = US3_1(v179)
                                                                                                    struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v180, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                else
                                                                                                    let v181 : bool = "fontSize" = v115
                                                                                                    if v181 then
                                                                                                        let v182 : string = v116 |> unbox
                                                                                                        let v183 : US3 = US3_1(v182)
                                                                                                        struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v183, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                    else
                                                                                                        let v184 : bool = "height" = v115
                                                                                                        if v184 then
                                                                                                            let v185 : string = v116 |> unbox
                                                                                                            let v186 : US3 = US3_1(v185)
                                                                                                            struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v186, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                        else
                                                                                                            let v187 : bool = "href" = v115
                                                                                                            if v187 then
                                                                                                                let v188 : string = v116 |> unbox
                                                                                                                let v189 : US3 = US3_1(v188)
                                                                                                                struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v189, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                            else
                                                                                                                let v190 : bool = "icon" = v115
                                                                                                                if v190 then
                                                                                                                    let v191 : JSX.Element = v116 |> unbox
                                                                                                                    let v192 : US6 = US6_1(v191)
                                                                                                                    struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v192, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                else
                                                                                                                    let v193 : bool = "id" = v115
                                                                                                                    if v193 then
                                                                                                                        let v194 : string = v116 |> unbox
                                                                                                                        let v195 : US3 = US3_1(v194)
                                                                                                                        struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v195, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                    else
                                                                                                                        let v196 : bool = "justifyContent" = v115
                                                                                                                        if v196 then
                                                                                                                            let v197 : string = v116 |> unbox
                                                                                                                            let v198 : US3 = US3_1(v197)
                                                                                                                            struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v198, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                        else
                                                                                                                            let v199 : bool = "left" = v115
                                                                                                                            if v199 then
                                                                                                                                let v200 : string = v116 |> unbox
                                                                                                                                let v201 : US3 = US3_1(v200)
                                                                                                                                struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v201, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                            else
                                                                                                                                let v202 : bool = "leftIcon" = v115
                                                                                                                                if v202 then
                                                                                                                                    let v203 : obj = v116 |> unbox
                                                                                                                                    let v204 : US7 = US7_1(v203)
                                                                                                                                    struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v204, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                else
                                                                                                                                    let v205 : bool = "lineHeight" = v115
                                                                                                                                    if v205 then
                                                                                                                                        let v206 : string = v116 |> unbox
                                                                                                                                        let v207 : US3 = US3_1(v206)
                                                                                                                                        struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v207, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                    else
                                                                                                                                        let v208 : bool = "margin" = v115
                                                                                                                                        if v208 then
                                                                                                                                            let v209 : string = v116 |> unbox
                                                                                                                                            let v210 : US3 = US3_1(v209)
                                                                                                                                            struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v210, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                        else
                                                                                                                                            let v211 : bool = "marginBottom" = v115
                                                                                                                                            if v211 then
                                                                                                                                                let v212 : string = v116 |> unbox
                                                                                                                                                let v213 : US3 = US3_1(v212)
                                                                                                                                                struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v213, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                            else
                                                                                                                                                let v214 : bool = "marginTop" = v115
                                                                                                                                                if v214 then
                                                                                                                                                    let v215 : string = v116 |> unbox
                                                                                                                                                    let v216 : US3 = US3_1(v215)
                                                                                                                                                    struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v216, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                                else
                                                                                                                                                    let v217 : bool = "maxHeight" = v115
                                                                                                                                                    if v217 then
                                                                                                                                                        let v218 : string = v116 |> unbox
                                                                                                                                                        let v219 : US3 = US3_1(v218)
                                                                                                                                                        struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v219, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                                    else
                                                                                                                                                        let v220 : bool = "onChange" = v115
                                                                                                                                                        if v220 then
                                                                                                                                                            let v221 : (obj -> unit) = v116 |> unbox
                                                                                                                                                            let v222 : US8 = US8_1(v221)
                                                                                                                                                            struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v222, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                                        else
                                                                                                                                                            let v223 : bool = "onClick" = v115
                                                                                                                                                            if v223 then
                                                                                                                                                                let v224 : (unit -> unit) = v116 |> unbox
                                                                                                                                                                let v225 : US9 = US9_1(v224)
                                                                                                                                                                struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v225, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                                            else
                                                                                                                                                                let v226 : bool = "outline" = v115
                                                                                                                                                                if v226 then
                                                                                                                                                                    let v227 : string = v116 |> unbox
                                                                                                                                                                    let v228 : US3 = US3_1(v227)
                                                                                                                                                                    struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v228, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                                                else
                                                                                                                                                                    let v229 : bool = "overflowX" = v115
                                                                                                                                                                    if v229 then
                                                                                                                                                                        let v230 : string = v116 |> unbox
                                                                                                                                                                        let v231 : US3 = US3_1(v230)
                                                                                                                                                                        struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v231, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                                                    else
                                                                                                                                                                        let v232 : bool = "overflowY" = v115
                                                                                                                                                                        if v232 then
                                                                                                                                                                            let v233 : string = v116 |> unbox
                                                                                                                                                                            let v234 : US3 = US3_1(v233)
                                                                                                                                                                            struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v234, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                                                        else
                                                                                                                                                                            let v235 : bool = "padding" = v115
                                                                                                                                                                            if v235 then
                                                                                                                                                                                let v236 : string = v116 |> unbox
                                                                                                                                                                                let v237 : US3 = US3_1(v236)
                                                                                                                                                                                struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v237, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                                                            else
                                                                                                                                                                                let v238 : bool = "paddingTop" = v115
                                                                                                                                                                                if v238 then
                                                                                                                                                                                    let v239 : string = v116 |> unbox
                                                                                                                                                                                    let v240 : US3 = US3_1(v239)
                                                                                                                                                                                    struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v240, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                                                                else
                                                                                                                                                                                    let v241 : bool = "paddingRight" = v115
                                                                                                                                                                                    if v241 then
                                                                                                                                                                                        let v242 : string = v116 |> unbox
                                                                                                                                                                                        let v243 : US3 = US3_1(v242)
                                                                                                                                                                                        struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v243, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                                                                    else
                                                                                                                                                                                        let v244 : bool = "paddingBottom" = v115
                                                                                                                                                                                        if v244 then
                                                                                                                                                                                            let v245 : string = v116 |> unbox
                                                                                                                                                                                            let v246 : US3 = US3_1(v245)
                                                                                                                                                                                            struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v246, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                                                                        else
                                                                                                                                                                                            let v247 : bool = "paddingLeft" = v115
                                                                                                                                                                                            if v247 then
                                                                                                                                                                                                let v248 : string = v116 |> unbox
                                                                                                                                                                                                let v249 : US3 = US3_1(v248)
                                                                                                                                                                                                struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v249, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                                                                            else
                                                                                                                                                                                                let v250 : bool = "position" = v115
                                                                                                                                                                                                if v250 then
                                                                                                                                                                                                    let v251 : string = v116 |> unbox
                                                                                                                                                                                                    let v252 : US3 = US3_1(v251)
                                                                                                                                                                                                    struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v252, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                                                                                else
                                                                                                                                                                                                    let v253 : bool = "right" = v115
                                                                                                                                                                                                    if v253 then
                                                                                                                                                                                                        let v254 : string = v116 |> unbox
                                                                                                                                                                                                        let v255 : US3 = US3_1(v254)
                                                                                                                                                                                                        struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v255, v106, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                                                                                    else
                                                                                                                                                                                                        let v256 : bool = "size" = v115
                                                                                                                                                                                                        if v256 then
                                                                                                                                                                                                            let v257 : string = v116 |> unbox
                                                                                                                                                                                                            let v258 : US3 = US3_1(v257)
                                                                                                                                                                                                            struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v258, v107, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                                                                                        else
                                                                                                                                                                                                            let v259 : bool = "spacing" = v115
                                                                                                                                                                                                            if v259 then
                                                                                                                                                                                                                let v260 : string = v116 |> unbox
                                                                                                                                                                                                                let v261 : US3 = US3_1(v260)
                                                                                                                                                                                                                struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v261, v108, v109, v110, v111, v112, v113, v114)
                                                                                                                                                                                                            else
                                                                                                                                                                                                                let v262 : bool = "status" = v115
                                                                                                                                                                                                                if v262 then
                                                                                                                                                                                                                    let v263 : bool = v116 |> unbox
                                                                                                                                                                                                                    let v264 : US1 = US1_1(v263)
                                                                                                                                                                                                                    struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v264, v109, v110, v111, v112, v113, v114)
                                                                                                                                                                                                                else
                                                                                                                                                                                                                    let v265 : bool = "striped" = v115
                                                                                                                                                                                                                    if v265 then
                                                                                                                                                                                                                        let v266 : string = v116 |> unbox
                                                                                                                                                                                                                        let v267 : US3 = US3_1(v266)
                                                                                                                                                                                                                        struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v267, v110, v111, v112, v113, v114)
                                                                                                                                                                                                                    else
                                                                                                                                                                                                                        let v268 : bool = "thickness" = v115
                                                                                                                                                                                                                        if v268 then
                                                                                                                                                                                                                            let v269 : string = v116 |> unbox
                                                                                                                                                                                                                            let v270 : US3 = US3_1(v269)
                                                                                                                                                                                                                            struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v270, v111, v112, v113, v114)
                                                                                                                                                                                                                        else
                                                                                                                                                                                                                            let v271 : bool = "title" = v115
                                                                                                                                                                                                                            if v271 then
                                                                                                                                                                                                                                let v272 : JSX.Element = v116 |> unbox
                                                                                                                                                                                                                                let v273 : US6 = US6_1(v272)
                                                                                                                                                                                                                                struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v273, v112, v113, v114)
                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                let v274 : bool = "top" = v115
                                                                                                                                                                                                                                if v274 then
                                                                                                                                                                                                                                    let v275 : string = v116 |> unbox
                                                                                                                                                                                                                                    let v276 : US3 = US3_1(v275)
                                                                                                                                                                                                                                    struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v276, v113, v114)
                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                    let v277 : bool = "width" = v115
                                                                                                                                                                                                                                    if v277 then
                                                                                                                                                                                                                                        let v278 : string = v116 |> unbox
                                                                                                                                                                                                                                        let v279 : US3 = US3_1(v278)
                                                                                                                                                                                                                                        struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v279, v114)
                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                        let v280 : bool = "zIndex" = v115
                                                                                                                                                                                                                                        if v280 then
                                                                                                                                                                                                                                            let v281 : int32 = v116 |> unbox
                                                                                                                                                                                                                                            let v282 : US0 = US0_1(v281)
                                                                                                                                                                                                                                            struct (v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v282)
                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                            let v283 : string = $"unknown prop: {v115} = {v116}"
                                                                                                                                                                                                                                            failwith<struct (US1 * US1 * US2 * US3 * US4 * US3 * US3 * US3 * US3 * US3 * US3 * US1 * US5 * US3 * US3 * US1 * US3 * US3 * US1 * US3 * US3 * US3 * US3 * US3 * US6 * US3 * US3 * US3 * US7 * US3 * US3 * US3 * US3 * US3 * US8 * US9 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US1 * US3 * US3 * US6 * US3 * US3 * US0)> v283
        let v3419 : int32 = v59 + 1
        v57.l0 <- v3419
        v57.l1 <- v3364
        v57.l2 <- v3365
        v57.l3 <- v3366
        v57.l4 <- v3367
        v57.l5 <- v3368
        v57.l6 <- v3369
        v57.l7 <- v3370
        v57.l8 <- v3371
        v57.l9 <- v3372
        v57.l10 <- v3373
        v57.l11 <- v3374
        v57.l12 <- v3375
        v57.l13 <- v3376
        v57.l14 <- v3377
        v57.l15 <- v3378
        v57.l16 <- v3379
        v57.l17 <- v3380
        v57.l18 <- v3381
        v57.l19 <- v3382
        v57.l20 <- v3383
        v57.l21 <- v3384
        v57.l22 <- v3385
        v57.l23 <- v3386
        v57.l24 <- v3387
        v57.l25 <- v3388
        v57.l26 <- v3389
        v57.l27 <- v3390
        v57.l28 <- v3391
        v57.l29 <- v3392
        v57.l30 <- v3393
        v57.l31 <- v3394
        v57.l32 <- v3395
        v57.l33 <- v3396
        v57.l34 <- v3397
        v57.l35 <- v3398
        v57.l36 <- v3399
        v57.l37 <- v3400
        v57.l38 <- v3401
        v57.l39 <- v3402
        v57.l40 <- v3403
        v57.l41 <- v3404
        v57.l42 <- v3405
        v57.l43 <- v3406
        v57.l44 <- v3407
        v57.l45 <- v3408
        v57.l46 <- v3409
        v57.l47 <- v3410
        v57.l48 <- v3411
        v57.l49 <- v3412
        v57.l50 <- v3413
        v57.l51 <- v3414
        v57.l52 <- v3415
        v57.l53 <- v3416
        v57.l54 <- v3417
        v57.l55 <- v3418
        ()
    let struct (v3420 : US1, v3421 : US1, v3422 : US2, v3423 : US3, v3424 : US4, v3425 : US3, v3426 : US3, v3427 : US3, v3428 : US3, v3429 : US3, v3430 : US3, v3431 : US1, v3432 : US5, v3433 : US3, v3434 : US3, v3435 : US1, v3436 : US3, v3437 : US3, v3438 : US1, v3439 : US3, v3440 : US3, v3441 : US3, v3442 : US3, v3443 : US3, v3444 : US6, v3445 : US3, v3446 : US3, v3447 : US3, v3448 : US7, v3449 : US3, v3450 : US3, v3451 : US3, v3452 : US3, v3453 : US3, v3454 : US8, v3455 : US9, v3456 : US3, v3457 : US3, v3458 : US3, v3459 : US3, v3460 : US3, v3461 : US3, v3462 : US3, v3463 : US3, v3464 : US3, v3465 : US3, v3466 : US3, v3467 : US3, v3468 : US1, v3469 : US3, v3470 : US3, v3471 : US6, v3472 : US3, v3473 : US3, v3474 : US0) = v57.l1, v57.l2, v57.l3, v57.l4, v57.l5, v57.l6, v57.l7, v57.l8, v57.l9, v57.l10, v57.l11, v57.l12, v57.l13, v57.l14, v57.l15, v57.l16, v57.l17, v57.l18, v57.l19, v57.l20, v57.l21, v57.l22, v57.l23, v57.l24, v57.l25, v57.l26, v57.l27, v57.l28, v57.l29, v57.l30, v57.l31, v57.l32, v57.l33, v57.l34, v57.l35, v57.l36, v57.l37, v57.l38, v57.l39, v57.l40, v57.l41, v57.l42, v57.l43, v57.l44, v57.l45, v57.l46, v57.l47, v57.l48, v57.l49, v57.l50, v57.l51, v57.l52, v57.l53, v57.l54, v57.l55
    {l0 = v3420; l1 = v3421; l2 = v3422; l3 = v3423; l4 = v3424; l5 = v3425; l6 = v3426; l7 = v3427; l8 = v3428; l9 = v3429; l10 = v3430; l11 = v3431; l12 = v3432; l13 = v3433; l14 = v3434; l15 = v3435; l16 = v3436; l17 = v3437; l18 = v3438; l19 = v3439; l20 = v3440; l21 = v3441; l22 = v3442; l23 = v3443; l24 = v3444; l25 = v3445; l26 = v3446; l27 = v3447; l28 = v3448; l29 = v3449; l30 = v3450; l31 = v3451; l32 = v3452; l33 = v3453; l34 = v3454; l35 = v3455; l36 = v3456; l37 = v3457; l38 = v3458; l39 = v3459; l40 = v3460; l41 = v3461; l42 = v3462; l43 = v3463; l44 = v3464; l45 = v3465; l46 = v3466; l47 = v3467; l48 = v3468; l49 = v3469; l50 = v3470; l51 = v3471; l52 = v3472; l53 = v3473; l54 = v3474} : Heap1
and closure4 () (v0 : (struct (string * obj) [])) : Heap1 =
    method18(v0)
and closure5 () (v0 : obj) : obj =
    method1(v0)
and closure8 (v0 : Heap1) () : JSX.Element =
    let v1 : US3 = v0.l23
    let v4 : string =
        match v1 with
        | US3_0 -> (* None *)
            let v2 : string = ""
            v2
        | US3_1(v3) -> (* Some *)
            v3
    let v5 : JSX.Element = Html.fragment [ v4 |> unbox<JSX.Element> ]
    let v6 : (JSX.Element []) = [|v5|]
    let v7 : JSX.Element = v6 |> unbox<JSX.Element>
    v7
and closure7 (v0 : Heap1, v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US1, v13 : US5, v14 : US3, v15 : US3, v16 : US1, v17 : US3, v18 : US3, v19 : US1, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US7, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US8, v36 : US9, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US1, v50 : US3, v51 : US3, v52 : US6, v53 : US3, v54 : US3, v55 : US0) () : JSX.Element =
    let v56 : (unit -> JSX.Element) = closure8(v0)
    let v57 : US5 = US5_1(v56)
    let v58 : bool = true
    let v59 : US1 = US1_1(v58)
    let v60 : Heap1 = method4(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v57, v14, v15, v16, v17, v18, v59, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55)
    let v61 : (JSX.Prop []) = method5(v60)
    let v62 : obj = createObj v61
    let v63 : string = "createComponent"
    let v64 : string = "solid-js"
    let v65 : JS.Function = import v63 v64
    let v66 : string = "Anchor"
    let v67 : string = "@hope-ui/solid"
    let v68 : JSX.Element = v65.Invoke ((import v66 v67), v62) |> unbox<JSX.Element>
    let v69 : string = "&nbsp;"
    let v70 : JSX.Element = Html.fragment [ v69 |> unbox<JSX.Element> ]
    let v71 : string = "BiRegularLinkExternal"
    let v72 : string = "solid-icons/bi"
    let v73 : JS.Function = import v71 v72
    let v74 : US4 = US4_1(v73)
    let v75 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v74; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55} : Heap1
    let v76 : (JSX.Prop []) = method5(v75)
    let v77 : obj = createObj v76
    let v78 : JS.Function = import v63 v64
    let v79 : string = "Icon"
    let v80 : JSX.Element = v78.Invoke ((import v79 v67), v77) |> unbox<JSX.Element>
    let v81 : (JSX.Element []) = [|v68; v70; v80|]
    let v82 : JSX.Element = v81 |> unbox<JSX.Element>
    v82
and method20 (v0 : Heap1) : JSX.Element =
    let struct (v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US1, v13 : US5, v14 : US3, v15 : US3, v16 : US1, v17 : US3, v18 : US3, v19 : US1, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US7, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US8, v36 : US9, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US1, v50 : US3, v51 : US3, v52 : US6, v53 : US3, v54 : US3, v55 : US0) = method3()
    let v56 : (unit -> JSX.Element) = closure7(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55)
    let v57 : US5 = US5_1(v56)
    let v58 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v57; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55} : Heap1
    let v59 : (JSX.Prop []) = method5(v58)
    let v60 : obj = createObj v59
    let v61 : string = "createComponent"
    let v62 : string = "solid-js"
    let v63 : JS.Function = import v61 v62
    let v64 : string = "Box"
    let v65 : string = "@hope-ui/solid"
    let v66 : JSX.Element = v63.Invoke ((import v64 v65), v60) |> unbox<JSX.Element>
    v66
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
and closure15 (v0 : JSX.Element) () : JSX.Element =
    let v1 : (JSX.Element []) = [|v0|]
    let v2 : JSX.Element = v1 |> unbox<JSX.Element>
    v2
and closure14 (v0 : US1, v1 : US1, v2 : US2, v3 : US3, v4 : US4, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US1, v12 : US5, v13 : US3, v14 : US3, v15 : US1, v16 : US3, v17 : US3, v18 : US1, v19 : US3, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US7, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US8, v35 : US9, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US1, v49 : US3, v50 : US3, v51 : US6, v52 : US3, v53 : US3, v54 : US0, v55 : JSX.Element) () : JSX.Element =
    let v56 : (unit -> JSX.Element) = closure15(v55)
    let v57 : US5 = US5_1(v56)
    let v58 : string = "2px"
    let v59 : US3 = US3_1(v58)
    let v60 : Heap1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v57; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v59; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54} : Heap1
    let v61 : (JSX.Prop []) = method5(v60)
    let v62 : obj = createObj v61
    let v63 : string = "createComponent"
    let v64 : string = "solid-js"
    let v65 : JS.Function = import v63 v64
    let v66 : string = "Box"
    let v67 : string = "@hope-ui/solid"
    let v68 : JSX.Element = v65.Invoke ((import v66 v67), v62) |> unbox<JSX.Element>
    let v69 : (JSX.Element []) = [|v68|]
    let v70 : JSX.Element = v69 |> unbox<JSX.Element>
    v70
and closure16 (v0 : (bool -> unit)) (v1 : obj) : unit =
    let v2 : bool = v1?target?checked
    v0 v2
    ()
and closure13 (v0 : Heap1, v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US1, v13 : US5, v14 : US3, v15 : US3, v16 : US1, v17 : US3, v18 : US3, v19 : US1, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US7, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US8, v36 : US9, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US1, v50 : US3, v51 : US3, v52 : US6, v53 : US3, v54 : US3, v55 : US0, v56 : (bool -> unit), v57 : (unit -> bool), v58 : JSX.Element) () : JSX.Element =
    let v59 : US1 = v0.l48
    let v82 : JSX.Element =
        match v59 with
        | US1_0 -> (* None *)
            v58
        | US1_1(v60) -> (* Some *)
            let v61 : bool = v57 ()
            let v62 : US1 = US1_1(v61)
            let v63 : (unit -> JSX.Element) = closure14(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v58)
            let v64 : US5 = US5_1(v63)
            let v65 : string = "neutral"
            let v66 : US3 = US3_1(v65)
            let v67 : string = "2px"
            let v68 : US3 = US3_1(v67)
            let v69 : (obj -> unit) = closure16(v56)
            let v70 : US8 = US8_1(v69)
            let v71 : string = "sm"
            let v72 : US3 = US3_1(v71)
            let v73 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v62; l12 = v64; l13 = v14; l14 = v66; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v68; l32 = v33; l33 = v34; l34 = v70; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v72; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55} : Heap1
            let v74 : (JSX.Prop []) = method5(v73)
            let v75 : obj = createObj v74
            let v76 : string = "createComponent"
            let v77 : string = "solid-js"
            let v78 : JS.Function = import v76 v77
            let v79 : string = "Checkbox"
            let v80 : string = "@hope-ui/solid"
            let v81 : JSX.Element = v78.Invoke ((import v79 v80), v75) |> unbox<JSX.Element>
            v81
    let v83 : (JSX.Element []) = [|v82|]
    let v84 : JSX.Element = v83 |> unbox<JSX.Element>
    v84
and closure17 () () : JSX.Element =
    let v0 : string = "&nbsp;"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    let v2 : (JSX.Element []) = [|v1|]
    let v3 : JSX.Element = v2 |> unbox<JSX.Element>
    v3
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
and method26 (v0 : (Heap1 -> JSX.Element), v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US1, v13 : US5, v14 : US3, v15 : US3, v16 : US1, v17 : US3, v18 : US3, v19 : US1, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US7, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US8, v36 : US9, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US1, v50 : US3, v51 : US3, v52 : US6, v53 : US3, v54 : US3, v55 : US0) : JSX.Element =
    let v56 : JS.Function = v0 |> unbox<JS.Function>
    let v57 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55} : Heap1
    let v58 : string = "createComponent"
    let v59 : string = "solid-js"
    let v60 : JS.Function = import v58 v59
    let v61 : JSX.Element = v60.Invoke (v56, v57) |> unbox<JSX.Element>
    v61
and closure24 (v0 : US1, v1 : US1, v2 : US2, v3 : US3, v4 : US4, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US1, v12 : US5, v13 : US3, v14 : US3, v15 : US1, v16 : US3, v17 : US3, v18 : US1, v19 : US3, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US7, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US8, v35 : US9, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US1, v49 : US3, v50 : US3, v51 : US6, v52 : US3, v53 : US3, v54 : US0, v55 : (bool -> unit), v56 : Heap1, v57 : (obj -> unit), v58 : obj) () : JSX.Element =
    let v59 : (Heap1 -> JSX.Element) = closure1()
    let v60 : (unit -> JSX.Element) = closure25()
    let v61 : US5 = US5_1(v60)
    let v62 : (unit -> unit) = closure26(v55, v56, v57, v58)
    let v63 : US9 = US9_1(v62)
    let v64 : JSX.Element = method26(v59, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v61, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v63, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54)
    let v65 : (JSX.Element []) = [|v64|]
    let v66 : JSX.Element = v65 |> unbox<JSX.Element>
    v66
and method27 (v0 : JS.Function, v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US1, v13 : US5, v14 : US3, v15 : US3, v16 : US1, v17 : US3, v18 : US3, v19 : US1, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US7, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US8, v36 : US9, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US1, v50 : US3, v51 : US3, v52 : US6, v53 : US3, v54 : US3, v55 : US0) : JSX.Element =
    let v56 : JS.Function = v0 |> unbox<JS.Function>
    let v57 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55} : Heap1
    let v58 : string = "createComponent"
    let v59 : string = "solid-js"
    let v60 : JS.Function = import v58 v59
    let v61 : JSX.Element = v60.Invoke (v56, v57) |> unbox<JSX.Element>
    v61
and closure30 (v0 : (bool -> unit)) () : unit =
    v0 true
    ()
and method28 (v0 : US0) : (JSX.Prop []) =
    let v1 : string = "ui_modal"
    let v2 : US10 = method14(v1, v0)
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
and closure29 (v0 : US1, v1 : US1, v2 : US2, v3 : US3, v4 : US4, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US1, v12 : US5, v13 : US3, v14 : US3, v15 : US1, v16 : US3, v17 : US3, v18 : US1, v19 : US3, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US7, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US8, v35 : US9, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US1, v49 : US3, v50 : US3, v51 : US6, v52 : US3, v53 : US3, v54 : US0, v55 : (obj -> unit), v56 : int32, v57 : (bool -> unit), v58 : (bool -> unit), v59 : (bool -> unit), v60 : (unit -> bool)) () : JSX.Element =
    let v61 : string = "BiRegularRefresh"
    let v62 : string = "solid-icons/bi"
    let v63 : JS.Function = import v61 v62
    let v64 : string = "14px"
    let v65 : US3 = US3_1(v64)
    let v66 : JSX.Element = method27(v63, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v65, v47, v48, v49, v50, v51, v52, v53, v54)
    let v67 : string = "Refresh"
    let v68 : US3 = US3_1(v67)
    let v69 : string = "neutral"
    let v70 : US3 = US3_1(v69)
    let v71 : string = "20px"
    let v72 : US3 = US3_1(v71)
    let v73 : US6 = US6_1(v66)
    let v74 : (unit -> unit) = closure30(v58)
    let v75 : US9 = US9_1(v74)
    let v76 : string = "xs"
    let v77 : US3 = US3_1(v76)
    let v78 : Heap1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v68; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v70; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v72; l23 = v23; l24 = v73; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v75; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v77; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54} : Heap1
    let v79 : (JSX.Prop []) = method5(v78)
    let v80 : obj = createObj v79
    let v81 : string = "createComponent"
    let v82 : string = "solid-js"
    let v83 : JS.Function = import v81 v82
    let v84 : string = "IconButton"
    let v85 : string = "@hope-ui/solid"
    let v86 : JSX.Element = v83.Invoke ((import v84 v85), v80) |> unbox<JSX.Element>
    let v87 : bool = v60 ()
    let v90 : string =
        if v87 then
            let v88 : string = "Restore"
            v88
        else
            let v89 : string = "Maximize"
            v89
    let v91 : bool = v60 ()
    let v96 : JS.Function =
        if v91 then
            let v92 : string = "BiRegularDownArrow"
            let v93 : JS.Function = import v92 v62
            v93
        else
            let v94 : string = "BiRegularUpArrow"
            let v95 : JS.Function = import v94 v62
            v95
    let v97 : US3 = US3_1(v64)
    let v98 : JSX.Element = method27(v96, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v97, v47, v48, v49, v50, v51, v52, v53, v54)
    let v99 : US3 = US3_1(v90)
    let v100 : US3 = US3_1(v69)
    let v101 : US3 = US3_1(v71)
    let v102 : US6 = US6_1(v98)
    let v103 : (unit -> unit) = closure31(v55, v56, v59, v60)
    let v104 : US9 = US9_1(v103)
    let v105 : US3 = US3_1(v76)
    let v106 : Heap1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v99; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v100; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v101; l23 = v23; l24 = v102; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v104; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v105; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54} : Heap1
    let v107 : (JSX.Prop []) = method5(v106)
    let v108 : obj = createObj v107
    let v109 : JS.Function = import v81 v82
    let v110 : JSX.Element = v109.Invoke ((import v84 v85), v108) |> unbox<JSX.Element>
    let v111 : string = "BiRegularUndo"
    let v112 : JS.Function = import v111 v62
    let v113 : US3 = US3_1(v64)
    let v114 : JSX.Element = method27(v112, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v113, v47, v48, v49, v50, v51, v52, v53, v54)
    let v115 : string = "Unload"
    let v116 : US3 = US3_1(v115)
    let v117 : US3 = US3_1(v69)
    let v118 : US3 = US3_1(v71)
    let v119 : US6 = US6_1(v114)
    let v120 : (unit -> unit) = closure32(v57)
    let v121 : US9 = US9_1(v120)
    let v122 : US3 = US3_1(v76)
    let v123 : Heap1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v116; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v117; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v118; l23 = v23; l24 = v119; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v121; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v122; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54} : Heap1
    let v124 : (JSX.Prop []) = method5(v123)
    let v125 : obj = createObj v124
    let v126 : JS.Function = import v81 v82
    let v127 : JSX.Element = v126.Invoke ((import v84 v85), v125) |> unbox<JSX.Element>
    let v128 : (JSX.Element []) = [|v86; v110; v127|]
    let v129 : JSX.Element = v128 |> unbox<JSX.Element>
    v129
and closure28 (v0 : US1, v1 : US1, v2 : US2, v3 : US3, v4 : US4, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US1, v12 : US5, v13 : US3, v14 : US3, v15 : US1, v16 : US3, v17 : US3, v18 : US1, v19 : US3, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US7, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US8, v35 : US9, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US1, v49 : US3, v50 : US3, v51 : US6, v52 : US3, v53 : US3, v54 : US0, v55 : (obj -> unit), v56 : int32, v57 : (bool -> unit), v58 : (bool -> unit), v59 : (unit -> bool), v60 : (bool -> unit), v61 : (unit -> bool), v62 : obj, v63 : (unit -> JSX.Element)) () : JSX.Element =
    let v64 : int32 = match v62?ui_modal with x when x = JS.undefined -> -2 | x -> x
    let v65 : bool = v64 > 0
    let v68 : bool =
        if v65 then
            let v66 : bool = v64 = v56
            let v67 : bool = v66 <> true
            v67
        else
            false
    let v72 : US3 =
        if v68 then
            let v69 : string = "none"
            US3_1(v69)
        else
            US3_0
    let v73 : (unit -> JSX.Element) = closure29(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v60, v61)
    let v74 : US5 = US5_1(v73)
    let v75 : string = "row"
    let v76 : US3 = US3_1(v75)
    let v77 : string = "absolute"
    let v78 : US3 = US3_1(v77)
    let v79 : string = "6px"
    let v80 : US3 = US3_1(v79)
    let v81 : string = "3px"
    let v82 : US3 = US3_1(v81)
    let v83 : US3 = US3_1(v79)
    let v84 : US0 = US0_1(1)
    let v85 : Heap1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v74; l13 = v13; l14 = v14; l15 = v15; l16 = v76; l17 = v72; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v78; l45 = v80; l46 = v46; l47 = v82; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v83; l53 = v53; l54 = v84} : Heap1
    let v86 : (JSX.Prop []) = method5(v85)
    let v87 : obj = createObj v86
    let v88 : string = "createComponent"
    let v89 : string = "solid-js"
    let v90 : JS.Function = import v88 v89
    let v91 : string = "Stack"
    let v92 : string = "@hope-ui/solid"
    let v93 : JSX.Element = v90.Invoke ((import v91 v92), v87) |> unbox<JSX.Element>
    let v94 : bool = v59 ()
    let v95 : bool = v94 = false
    let v98 : JSX.Element =
        if v95 then
            let v96 : JSX.Element = v63 ()
            v96
        else
            let v97 : JSX.Element = Html.fragment []
            v97
    let v99 : (JSX.Element []) = [|v93; v98|]
    let v100 : JSX.Element = v99 |> unbox<JSX.Element>
    v100
and closure27 (v0 : Heap1, v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US1, v13 : US5, v14 : US3, v15 : US3, v16 : US1, v17 : US3, v18 : US3, v19 : US1, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US7, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US8, v36 : US9, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US1, v50 : US3, v51 : US3, v52 : US6, v53 : US3, v54 : US3, v55 : US0, v56 : (obj -> unit), v57 : int32, v58 : (bool -> unit), v59 : (bool -> unit), v60 : (unit -> bool), v61 : (bool -> unit), v62 : (unit -> bool), v63 : obj) () : JSX.Element =
    let v64 : US5 = v0.l12
    let v88 : JSX.Element =
        match v64 with
        | US5_0 -> (* None *)
            let v65 : JSX.Element = Html.fragment []
            v65
        | US5_1(v66) -> (* Some *)
            let v67 : int32 = match v63?ui_modal with x when x = JS.undefined -> -2 | x -> x
            let v68 : bool = v67 <= 0
            let v72 : US3 =
                if v68 then
                    let v69 : string = "relative"
                    US3_1(v69)
                else
                    US3_0
            let v73 : (unit -> JSX.Element) = closure28(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v66)
            let v74 : US5 = US5_1(v73)
            let v75 : string = "flex"
            let v76 : US3 = US3_1(v75)
            let v77 : string = "1"
            let v78 : US3 = US3_1(v77)
            let v79 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v74; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v76; l18 = v19; l19 = v78; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v72; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55} : Heap1
            let v80 : (JSX.Prop []) = method5(v79)
            let v81 : obj = createObj v80
            let v82 : string = "createComponent"
            let v83 : string = "solid-js"
            let v84 : JS.Function = import v82 v83
            let v85 : string = "Box"
            let v86 : string = "@hope-ui/solid"
            let v87 : JSX.Element = v84.Invoke ((import v85 v86), v81) |> unbox<JSX.Element>
            v87
    let v89 : (JSX.Element []) = [|v88|]
    let v90 : JSX.Element = v89 |> unbox<JSX.Element>
    v90
and closure23 (v0 : Heap1, v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US1, v13 : US5, v14 : US3, v15 : US3, v16 : US1, v17 : US3, v18 : US3, v19 : US1, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US7, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US8, v36 : US9, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US1, v50 : US3, v51 : US3, v52 : US6, v53 : US3, v54 : US3, v55 : US0, v56 : (obj -> unit), v57 : int32, v58 : (bool -> unit), v59 : (unit -> bool), v60 : (bool -> unit), v61 : (unit -> bool), v62 : (bool -> unit), v63 : (unit -> bool), v64 : obj) () : JSX.Element =
    let v65 : bool = v59 ()
    let v66 : bool = v65 = false
    let v129 : JSX.Element =
        if v66 then
            let v67 : (unit -> JSX.Element) = closure24(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v58, v0, v56, v64)
            let v68 : US5 = US5_1(v67)
            let v69 : string = "4px 0"
            let v70 : US3 = US3_1(v69)
            let v71 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v68; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v70; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55} : Heap1
            let v72 : (JSX.Prop []) = method5(v71)
            let v73 : obj = createObj v72
            let v74 : string = "createComponent"
            let v75 : string = "solid-js"
            let v76 : JS.Function = import v74 v75
            let v77 : string = "Box"
            let v78 : string = "@hope-ui/solid"
            let v79 : JSX.Element = v76.Invoke ((import v77 v78), v73) |> unbox<JSX.Element>
            v79
        else
            let v80 : bool = v63 ()
            let v83 : US0 =
                if v80 then
                    US0_1(1)
                else
                    US0_0
            let v84 : bool = v63 ()
            let v88 : US3 =
                if v84 then
                    let v85 : string = "absolute"
                    US3_1(v85)
                else
                    US3_0
            let v89 : bool = v63 ()
            let v93 : US3 =
                if v89 then
                    let v90 : string = "0"
                    US3_1(v90)
                else
                    US3_0
            let v94 : bool = v63 ()
            let v98 : US3 =
                if v94 then
                    let v95 : string = "0"
                    US3_1(v95)
                else
                    US3_0
            let v99 : bool = v63 ()
            let v103 : US3 =
                if v99 then
                    let v100 : string = "0"
                    US3_1(v100)
                else
                    US3_0
            let v104 : bool = v63 ()
            let v108 : US3 =
                if v104 then
                    let v105 : string = "0"
                    US3_1(v105)
                else
                    US3_0
            let v109 : bool = v63 ()
            let v113 : US3 =
                if v109 then
                    let v110 : string = "$bg"
                    US3_1(v110)
                else
                    US3_0
            let v114 : (unit -> JSX.Element) = closure27(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v60, v61, v62, v63, v64)
            let v115 : US5 = US5_1(v114)
            let v116 : string = "flex"
            let v117 : US3 = US3_1(v116)
            let v118 : string = "1"
            let v119 : US3 = US3_1(v118)
            let v120 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v113; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v103; l11 = v12; l12 = v115; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v117; l18 = v19; l19 = v119; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v108; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v88; l45 = v98; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v93; l53 = v54; l54 = v83} : Heap1
            let v121 : (JSX.Prop []) = method5(v120)
            let v122 : obj = createObj v121
            let v123 : string = "createComponent"
            let v124 : string = "solid-js"
            let v125 : JS.Function = import v123 v124
            let v126 : string = "Box"
            let v127 : string = "@hope-ui/solid"
            let v128 : JSX.Element = v125.Invoke ((import v126 v127), v122) |> unbox<JSX.Element>
            v128
    let v130 : (JSX.Element []) = [|v129|]
    let v131 : JSX.Element = v130 |> unbox<JSX.Element>
    v131
and method24 (v0 : Heap1) : JSX.Element =
    let struct (v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US1, v13 : US5, v14 : US3, v15 : US3, v16 : US1, v17 : US3, v18 : US3, v19 : US1, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US7, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US8, v36 : US9, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US1, v50 : US3, v51 : US3, v52 : US6, v53 : US3, v54 : US3, v55 : US0) = method3()
    let struct (v56 : obj, v57 : (obj -> unit)) = method25()
    let v58 : int32 = Random().Next()
    let v59 : US1 = v0.l0
    let v61 : bool =
        match v59 with
        | US1_0 -> (* None *)
            false
        | US1_1(v60) -> (* Some *)
            v60
    let struct (v62 : (unit -> bool), v63 : (bool -> unit)) = method23(v61)
    let v64 : bool = false
    let struct (v65 : (unit -> bool), v66 : (bool -> unit)) = method23(v64)
    let v67 : US1 = v0.l1
    let v69 : bool =
        match v67 with
        | US1_0 -> (* None *)
            false
        | US1_1(v68) -> (* Some *)
            v68
    let struct (v70 : (unit -> bool), v71 : (bool -> unit)) = method23(v69)
    let v72 : string = "on"
    let v73 : string = "solid-js"
    let v74 : JS.Function = import v72 v73
    let v75 : (unit -> (bool [])) = closure21(v65)
    let v76 : (unit -> unit) = closure22(v66, v65)
    let v77 : JS.Function = v74.Invoke (v75, v76) |> unbox<JS.Function>
    let v78 : string = "createEffect"
    let v79 : JS.Function = import v78 v73
    v79.Invoke v77 |> ignore
    let v83 : bool =
        match v59 with
        | US1_1(v81) -> (* Some *)
            let v82 : bool = v81 = true
            v82
        | _ ->
            false
    if v83 then
        let v84 : US2 = v0.l2
        match v84 with
        | US2_0 -> (* None *)
            ()
        | US2_1(v85) -> (* Some *)
            let v86 : ((obj -> unit) -> unit) = v85 v56
            v86 v57
            ()
    let v87 : US3 = v0.l25
    let v88 : (unit -> JSX.Element) = closure23(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v57, v58, v63, v62, v66, v65, v71, v70, v56)
    let v89 : US5 = US5_1(v88)
    let v90 : string = "flex"
    let v91 : US3 = US3_1(v90)
    let v92 : string = "1"
    let v93 : US3 = US3_1(v92)
    let v94 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v89; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v91; l18 = v19; l19 = v93; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v87; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55} : Heap1
    let v95 : (JSX.Prop []) = method5(v94)
    let v96 : obj = createObj v95
    let v97 : string = "createComponent"
    let v98 : JS.Function = import v97 v73
    let v99 : string = "Box"
    let v100 : string = "@hope-ui/solid"
    let v101 : JSX.Element = v98.Invoke ((import v99 v100), v96) |> unbox<JSX.Element>
    v101
and closure19 () (v0 : Heap1) : JSX.Element =
    method24(v0)
and closure33 (v0 : (unit -> JSX.Element)) () : JSX.Element =
    let v1 : JSX.Element = v0 ()
    let v2 : (JSX.Element []) = [|v1|]
    let v3 : JSX.Element = v2 |> unbox<JSX.Element>
    v3
and closure18 (v0 : Heap1, v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US1, v13 : US5, v14 : US3, v15 : US3, v16 : US1, v17 : US3, v18 : US3, v19 : US1, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US7, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US8, v36 : US9, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US1, v50 : US3, v51 : US3, v52 : US6, v53 : US3, v54 : US3, v55 : US0, v56 : (unit -> bool), v57 : (unit -> JSX.Element)) () : JSX.Element =
    let v58 : US1 = v0.l48
    let v75 : JSX.Element =
        match v58 with
        | US1_0 -> (* None *)
            let v59 : string = jsTypeof v57
            let v60 : bool = "function" = v59
            if v60 then
                let v61 : JSX.Element = v57 |> unbox
                v61
            else
                let v62 : JSX.Element = (fun () -> v57) |> unbox
                v62
        | US1_1(v64) -> (* Some *)
            let v65 : bool = v56 ()
            if v65 then
                let v66 : (Heap1 -> JSX.Element) = closure19()
                let v67 : US2 = v0.l2
                let v68 : bool = true
                let v69 : US1 = US1_1(v68)
                let v70 : (unit -> JSX.Element) = closure33(v57)
                let v71 : US5 = US5_1(v70)
                method26(v66, v69, v2, v67, v4, v5, v6, v7, v8, v9, v10, v11, v12, v71, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55)
            else
                let v73 : JSX.Element = Html.fragment []
                v73
    let v76 : (JSX.Element []) = [|v75|]
    let v77 : JSX.Element = v76 |> unbox<JSX.Element>
    v77
and closure12 (v0 : Heap1, v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US1, v13 : US5, v14 : US3, v15 : US3, v16 : US1, v17 : US3, v18 : US3, v19 : US1, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US7, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US8, v36 : US9, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US1, v50 : US3, v51 : US3, v52 : US6, v53 : US3, v54 : US3, v55 : US0, v56 : (bool -> unit), v57 : (unit -> bool)) () : JSX.Element =
    let v58 : US6 = v0.l51
    let v96 : JSX.Element =
        match v58 with
        | US6_0 -> (* None *)
            let v59 : JSX.Element = Html.fragment []
            v59
        | US6_1(v60) -> (* Some *)
            let v61 : US1 = v0.l48
            let v63 : bool =
                match v61 with
                | US1_0 -> (* None *)
                    true
                | _ ->
                    false
            let v65 : bool =
                if v63 then
                    true
                else
                    let v64 : bool = v57 ()
                    v64
            let v72 : US3 =
                if v65 then
                    let v66 : string = "2px !important"
                    let v67 : string = "0px !important"
                    let v68 : string = {| ``@initial`` = v66; ``@sm`` = v67 |} |> unbox<string>
                    US3_1(v68)
                else
                    let v70 : string = "0px !important"
                    US3_1(v70)
            let v73 : string = "$neutral5"
            let v74 : US3 = US3_1(v73)
            let v75 : (unit -> JSX.Element) = closure13(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v60)
            let v76 : US5 = US5_1(v75)
            let v77 : string = "$neutral9"
            let v78 : US3 = US3_1(v77)
            let v79 : string = "flex"
            let v80 : US3 = US3_1(v79)
            let v81 : string = "column"
            let v82 : US3 = US3_1(v81)
            let v83 : string = "$sm"
            let v84 : US3 = US3_1(v83)
            let v85 : string = "3px 20px 0 8px"
            let v86 : US3 = US3_1(v85)
            let v87 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v72; l8 = v74; l9 = v10; l10 = v11; l11 = v12; l12 = v76; l13 = v78; l14 = v15; l15 = v16; l16 = v17; l17 = v80; l18 = v19; l19 = v20; l20 = v82; l21 = v84; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v86; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55} : Heap1
            let v88 : (JSX.Prop []) = method5(v87)
            let v89 : obj = createObj v88
            let v90 : string = "createComponent"
            let v91 : string = "solid-js"
            let v92 : JS.Function = import v90 v91
            let v93 : string = "Td"
            let v94 : string = "@hope-ui/solid"
            let v95 : JSX.Element = v92.Invoke ((import v93 v94), v89) |> unbox<JSX.Element>
            v95
    let v97 : US5 = v0.l12
    let v149 : JSX.Element =
        match v97 with
        | US5_0 -> (* None *)
            let v98 : string = "0"
            let v99 : US3 = US3_1(v98)
            let v100 : (unit -> JSX.Element) = closure17()
            let v101 : US5 = US5_1(v100)
            let v102 : string = "9px"
            let v103 : US3 = US3_1(v102)
            let v104 : US3 = US3_1(v98)
            let v105 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v99; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v101; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v103; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v104; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55} : Heap1
            let v106 : (JSX.Prop []) = method5(v105)
            let v107 : obj = createObj v106
            let v108 : string = "createComponent"
            let v109 : string = "solid-js"
            let v110 : JS.Function = import v108 v109
            let v111 : string = "Td"
            let v112 : string = "@hope-ui/solid"
            let v113 : JSX.Element = v110.Invoke ((import v111 v112), v107) |> unbox<JSX.Element>
            v113
        | US5_1(v114) -> (* Some *)
            let v115 : US3 = v0.l39
            let v118 : string =
                match v115 with
                | US3_0 -> (* None *)
                    let v116 : string = "0"
                    v116
                | US3_1(v117) -> (* Some *)
                    v117
            let v119 : string = "0"
            let v120 : US3 = US3_1(v119)
            let v121 : (unit -> JSX.Element) = closure18(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v57, v114)
            let v122 : US5 = US5_1(v121)
            let v123 : string = "flex"
            let v124 : US3 = US3_1(v123)
            let v125 : string = "6"
            let v126 : US3 = US3_1(v125)
            let v127 : string = "column"
            let v128 : US3 = US3_1(v127)
            let v129 : string = "$sm"
            let v130 : US3 = US3_1(v129)
            let v131 : string = "$base"
            let v132 : US3 = US3_1(v131)
            let v133 : US3 = US3_1(v119)
            let v134 : string = "85vh"
            let v135 : US3 = US3_1(v134)
            let v136 : US3 = US3_1(v119)
            let v137 : string = "auto"
            let v138 : US3 = US3_1(v137)
            let v139 : US3 = US3_1(v118)
            let v140 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v120; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v122; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v124; l18 = v19; l19 = v126; l20 = v128; l21 = v130; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v132; l30 = v133; l31 = v32; l32 = v33; l33 = v135; l34 = v35; l35 = v36; l36 = v136; l37 = v38; l38 = v138; l39 = v139; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55} : Heap1
            let v141 : (JSX.Prop []) = method5(v140)
            let v142 : obj = createObj v141
            let v143 : string = "createComponent"
            let v144 : string = "solid-js"
            let v145 : JS.Function = import v143 v144
            let v146 : string = "Td"
            let v147 : string = "@hope-ui/solid"
            let v148 : JSX.Element = v145.Invoke ((import v146 v147), v142) |> unbox<JSX.Element>
            v148
    let v150 : (JSX.Element []) = [|v96; v149|]
    let v151 : JSX.Element = v150 |> unbox<JSX.Element>
    v151
and method22 (v0 : Heap1) : JSX.Element =
    let struct (v1 : US1, v2 : US1, v3 : US2, v4 : US3, v5 : US4, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US1, v13 : US5, v14 : US3, v15 : US3, v16 : US1, v17 : US3, v18 : US3, v19 : US1, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US7, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US8, v36 : US9, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US1, v50 : US3, v51 : US3, v52 : US6, v53 : US3, v54 : US3, v55 : US0) = method3()
    let v56 : US1 = v0.l48
    let v60 : bool =
        match v56 with
        | US1_1(v58) -> (* Some *)
            let v59 : bool = v58 = false
            v59
        | _ ->
            false
    let v61 : bool = v60 <> true
    let struct (v62 : (unit -> bool), v63 : (bool -> unit)) = method23(v61)
    let v64 : US6 = v0.l51
    let v68 : bool =
        match v56 with
        | US1_1(v66) -> (* Some *)
            let v67 : bool = v66 = true
            v67
        | _ ->
            false
    let v69 : bool = v68 <> true
    let v70 : bool = v62 ()
    let v71 : string = "row"
    let v72 : string = "title:"
    let v73 : string = "props.status <> Some true:"
    let v74 : string = "checked:"
    let v75 : string = "props.status"
    let v76 : (struct (string * string * US6 * string * bool * string * bool * string * US1) []) = [|struct (v71, v72, v64, v73, v69, v74, v70, v75, v56)|]
    printfn $"%A{v76}"
    let v77 : US3 = v0.l25
    let v78 : string = "column"
    let v79 : string = {| ``@initial`` = v78; ``@sm`` = v71 |} |> unbox<string>
    let v80 : string = "$neutral5"
    let v81 : US3 = US3_1(v80)
    let v82 : string = "1px 2px"
    let v83 : US3 = US3_1(v82)
    let v84 : (unit -> JSX.Element) = closure12(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v63, v62)
    let v85 : US5 = US5_1(v84)
    let v86 : string = "flex"
    let v87 : US3 = US3_1(v86)
    let v88 : string = "1"
    let v89 : US3 = US3_1(v88)
    let v90 : US3 = US3_1(v79)
    let v91 : Heap1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v81; l9 = v83; l10 = v11; l11 = v12; l12 = v85; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v87; l18 = v19; l19 = v89; l20 = v90; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v77; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55} : Heap1
    let v92 : (JSX.Prop []) = method5(v91)
    let v93 : obj = createObj v92
    let v94 : string = "createComponent"
    let v95 : string = "solid-js"
    let v96 : JS.Function = import v94 v95
    let v97 : string = "Tr"
    let v98 : string = "@hope-ui/solid"
    let v99 : JSX.Element = v96.Invoke ((import v97 v98), v93) |> unbox<JSX.Element>
    v99
and closure11 () (v0 : Heap1) : JSX.Element =
    method22(v0)
and closure34 (v0 : US1, v1 : US1, v2 : US2, v3 : US3, v4 : US4, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US1, v12 : US5, v13 : US3, v14 : US3, v15 : US1, v16 : US3, v17 : US3, v18 : US1, v19 : US3, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US7, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US8, v35 : US9, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US1, v49 : US3, v50 : US3, v51 : US6, v52 : US3, v53 : US3, v54 : US0) () : JSX.Element =
    let v55 : (Heap1 -> JSX.Element) = closure6()
    let v56 : string = "https://github.com/fc1943s/tictactoe_spiral"
    let v57 : US3 = US3_1(v56)
    let v58 : JSX.Element = method26(v55, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v57, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54)
    let v59 : (JSX.Element []) = [|v58|]
    let v60 : JSX.Element = v59 |> unbox<JSX.Element>
    v60
and closure35 (v0 : US1, v1 : US1, v2 : US2, v3 : US3, v4 : US4, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US1, v12 : US5, v13 : US3, v14 : US3, v15 : US1, v16 : US3, v17 : US3, v18 : US1, v19 : US3, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US7, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US8, v35 : US9, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US1, v49 : US3, v50 : US3, v51 : US6, v52 : US3, v53 : US3, v54 : US0) () : JSX.Element =
    let v55 : (Heap1 -> JSX.Element) = closure6()
    let v56 : string = "https://fc1943s.github.io/tictactoe_spiral"
    let v57 : US3 = US3_1(v56)
    let v58 : JSX.Element = method26(v55, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v57, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54)
    let v59 : (JSX.Element []) = [|v58|]
    let v60 : JSX.Element = v59 |> unbox<JSX.Element>
    v60
and closure36 (v0 : US1, v1 : US1, v2 : US2, v3 : US3, v4 : US4, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US1, v12 : US5, v13 : US3, v14 : US3, v15 : US1, v16 : US3, v17 : US3, v18 : US1, v19 : US3, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US7, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US8, v35 : US9, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US1, v49 : US3, v50 : US3, v51 : US6, v52 : US3, v53 : US3, v54 : US0) () : JSX.Element =
    let v55 : (Heap1 -> JSX.Element) = closure6()
    let v56 : string = "https://fc1943s.github.io/tictactoe_spiral/docs"
    let v57 : US3 = US3_1(v56)
    let v58 : JSX.Element = method26(v55, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v57, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54)
    let v59 : (JSX.Element []) = [|v58|]
    let v60 : JSX.Element = v59 |> unbox<JSX.Element>
    v60
and closure10 (v0 : US1, v1 : US1, v2 : US2, v3 : US3, v4 : US4, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US1, v12 : US5, v13 : US3, v14 : US3, v15 : US1, v16 : US3, v17 : US3, v18 : US1, v19 : US3, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US7, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US8, v35 : US9, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US1, v49 : US3, v50 : US3, v51 : US6, v52 : US3, v53 : US3, v54 : US0) () : JSX.Element =
    let v55 : (Heap1 -> JSX.Element) = closure11()
    let v56 : (unit -> JSX.Element) = closure34(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54)
    let v57 : US5 = US5_1(v56)
    let v58 : string = "1px 6px"
    let v59 : US3 = US3_1(v58)
    let v60 : JSX.Element = method26(v55, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v57, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v59, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54)
    let v61 : (unit -> JSX.Element) = closure35(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54)
    let v62 : US5 = US5_1(v61)
    let v63 : US3 = US3_1(v58)
    let v64 : JSX.Element = method26(v55, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v62, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v63, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54)
    let v65 : (unit -> JSX.Element) = closure36(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54)
    let v66 : US5 = US5_1(v65)
    let v67 : US3 = US3_1(v58)
    let v68 : JSX.Element = method26(v55, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v66, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v67, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54)
    let v69 : (JSX.Element []) = [|v60; v64; v68|]
    let v70 : JSX.Element = v69 |> unbox<JSX.Element>
    v70
and method21 () : JSX.Element =
    let struct (v0 : US1, v1 : US1, v2 : US2, v3 : US3, v4 : US4, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US1, v12 : US5, v13 : US3, v14 : US3, v15 : US1, v16 : US3, v17 : US3, v18 : US1, v19 : US3, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US7, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US8, v35 : US9, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US1, v49 : US3, v50 : US3, v51 : US6, v52 : US3, v53 : US3, v54 : US0) = method3()
    let v55 : (Heap1 -> JSX.Element) = closure2()
    let v56 : (unit -> JSX.Element) = closure10(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54)
    let v57 : US5 = US5_1(v56)
    method26(v55, v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v57, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54)
and closure9 () () : JSX.Element =
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
let v22 : (unit -> JSX.Element) = closure9()
let v23 : JSX.Prop = JSX.Prop (v21, v22)
let v24 : string = "loader"
let v25 : (Heap1 -> JSX.Element) = closure19()
let v26 : JSX.Prop = JSX.Prop (v24, v25)
let v27 : string = "row"
let v28 : (Heap1 -> JSX.Element) = closure11()
let v29 : JSX.Prop = JSX.Prop (v27, v28)
let v30 : string = "store"
let v31 : JSX.Prop = JSX.Prop (v30, v5)
let v32 : (JSX.Prop []) = [|v8; v11; v14; v17; v20; v23; v26; v29; v31|]
let v33 : obj = createObj v32
v1.l0 <- v33
()
