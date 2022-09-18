#r "nuget: Feliz.JSX.Solid, 1.0.0-beta-001"
open System
open Fable.Core
open Fable.Core.JsInterop
open Feliz.JSX.Solid

type [<Struct>] US0 =
    | US0_0
    | US0_1 of f1_0 : string
and [<Struct>] US1 =
    | US1_0
    | US1_1 of f1_0 : JS.Function
and [<Struct>] US2 =
    | US2_0
    | US2_1 of f1_0 : bool
and [<Struct>] US3 =
    | US3_0
    | US3_1 of f1_0 : (unit -> JSX.Element)
and [<Struct>] US4 =
    | US4_0
    | US4_1 of f1_0 : int32
and [<Struct>] US5 =
    | US5_0
    | US5_1 of f1_0 : JSX.Element
and [<Struct>] US6 =
    | US6_0
    | US6_1 of f1_0 : obj
and [<Struct>] US7 =
    | US7_0
    | US7_1 of f1_0 : (obj -> unit)
and [<Struct>] US8 =
    | US8_0
    | US8_1 of f1_0 : (unit -> unit)
and Heap0 = {l0 : US0; l1 : US1; l2 : US0; l3 : US0; l4 : US0; l5 : US2; l6 : US3; l7 : US0; l8 : US0; l9 : US2; l10 : US0; l11 : US0; l12 : US2; l13 : US4; l14 : US0; l15 : US0; l16 : US0; l17 : US0; l18 : US5; l19 : US0; l20 : US0; l21 : US0; l22 : US6; l23 : US0; l24 : US0; l25 : US0; l26 : US0; l27 : US7; l28 : US8; l29 : US0; l30 : US0; l31 : US0; l32 : US0; l33 : US0; l34 : US0; l35 : US0; l36 : US0; l37 : US2; l38 : US0; l39 : US0; l40 : US5; l41 : US0; l42 : US0; l43 : US4}
and [<Struct>] US9 =
    | US9_0
    | US9_1 of f1_0 : JSX.Prop
and Mut0 = {mutable l0 : int32; mutable l1 : int32}
and Mut1 = {mutable l0 : int32}
and Mut2 = {mutable l0 : int32; mutable l1 : US0; mutable l2 : US1; mutable l3 : US0; mutable l4 : US0; mutable l5 : US0; mutable l6 : US2; mutable l7 : US3; mutable l8 : US0; mutable l9 : US0; mutable l10 : US2; mutable l11 : US0; mutable l12 : US0; mutable l13 : US2; mutable l14 : US4; mutable l15 : US0; mutable l16 : US0; mutable l17 : US0; mutable l18 : US0; mutable l19 : US5; mutable l20 : US0; mutable l21 : US0; mutable l22 : US0; mutable l23 : US6; mutable l24 : US0; mutable l25 : US0; mutable l26 : US0; mutable l27 : US0; mutable l28 : US7; mutable l29 : US8; mutable l30 : US0; mutable l31 : US0; mutable l32 : US0; mutable l33 : US0; mutable l34 : US0; mutable l35 : US0; mutable l36 : US0; mutable l37 : US0; mutable l38 : US2; mutable l39 : US0; mutable l40 : US0; mutable l41 : US5; mutable l42 : US0; mutable l43 : US0; mutable l44 : US4}
and Mut3 = {mutable l0 : int32}
and [<Struct>] US10 =
    | US10_0
    | US10_1 of f1_0 : (Mut3 -> ((Mut3 -> unit) -> unit))
let rec method0 () : struct (US0 * US1 * US0 * US0 * US0 * US2 * US3 * US0 * US0 * US2 * US0 * US0 * US2 * US4 * US0 * US0 * US0 * US0 * US5 * US0 * US0 * US0 * US6 * US0 * US0 * US0 * US0 * US7 * US8 * US0 * US0 * US0 * US0 * US0 * US0 * US0 * US0 * US2 * US0 * US0 * US5 * US0 * US0 * US4) =
    let v0 : US0 = US0_0
    let v1 : US1 = US1_0
    let v2 : US0 = US0_0
    let v3 : US0 = US0_0
    let v4 : US0 = US0_0
    let v5 : US2 = US2_0
    let v6 : US3 = US3_0
    let v7 : US0 = US0_0
    let v8 : US0 = US0_0
    let v9 : US2 = US2_0
    let v10 : US0 = US0_0
    let v11 : US0 = US0_0
    let v12 : US2 = US2_0
    let v13 : US4 = US4_0
    let v14 : US0 = US0_0
    let v15 : US0 = US0_0
    let v16 : US0 = US0_0
    let v17 : US0 = US0_0
    let v18 : US5 = US5_0
    let v19 : US0 = US0_0
    let v20 : US0 = US0_0
    let v21 : US0 = US0_0
    let v22 : US6 = US6_0
    let v23 : US0 = US0_0
    let v24 : US0 = US0_0
    let v25 : US0 = US0_0
    let v26 : US0 = US0_0
    let v27 : US7 = US7_0
    let v28 : US8 = US8_0
    let v29 : US0 = US0_0
    let v30 : US0 = US0_0
    let v31 : US0 = US0_0
    let v32 : US0 = US0_0
    let v33 : US0 = US0_0
    let v34 : US0 = US0_0
    let v35 : US0 = US0_0
    let v36 : US0 = US0_0
    let v37 : US2 = US2_0
    let v38 : US0 = US0_0
    let v39 : US0 = US0_0
    let v40 : US5 = US5_0
    let v41 : US0 = US0_0
    let v42 : US0 = US0_0
    let v43 : US4 = US4_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43)
and method1 (v0 : Heap0, v1 : US0, v2 : US1, v3 : US0, v4 : US0, v5 : US0, v6 : US2, v7 : US3, v8 : US0, v9 : US0, v10 : US2, v11 : US0, v12 : US0, v13 : US2, v14 : US4, v15 : US0, v16 : US0, v17 : US0, v18 : US0, v19 : US5, v20 : US0, v21 : US0, v22 : US0, v23 : US6, v24 : US0, v25 : US0, v26 : US0, v27 : US0, v28 : US7, v29 : US8, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US0, v38 : US2, v39 : US0, v40 : US0, v41 : US5, v42 : US0, v43 : US0, v44 : US4) : Heap0 =
    let v45 : Heap0 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44} : Heap0
    let v46 : US0 = v0.l0
    let v47 : US0 = v45.l0
    let v54 : US0 =
        match v47 with
        | US0_0 -> (* None *)
            match v46 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v49) -> (* Some *)
                US0_1(v49)
        | US0_1(v52) -> (* Some *)
            US0_1(v52)
    let v55 : US1 = v0.l1
    let v56 : US1 = v45.l1
    let v63 : US1 =
        match v56 with
        | US1_0 -> (* None *)
            match v55 with
            | US1_0 -> (* None *)
                US1_0
            | US1_1(v58) -> (* Some *)
                US1_1(v58)
        | US1_1(v61) -> (* Some *)
            US1_1(v61)
    let v64 : US0 = v0.l2
    let v65 : US0 = v45.l2
    let v72 : US0 =
        match v65 with
        | US0_0 -> (* None *)
            match v64 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v67) -> (* Some *)
                US0_1(v67)
        | US0_1(v70) -> (* Some *)
            US0_1(v70)
    let v73 : US0 = v0.l3
    let v74 : US0 = v45.l3
    let v81 : US0 =
        match v74 with
        | US0_0 -> (* None *)
            match v73 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v76) -> (* Some *)
                US0_1(v76)
        | US0_1(v79) -> (* Some *)
            US0_1(v79)
    let v82 : US0 = v0.l4
    let v83 : US0 = v45.l4
    let v90 : US0 =
        match v83 with
        | US0_0 -> (* None *)
            match v82 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v85) -> (* Some *)
                US0_1(v85)
        | US0_1(v88) -> (* Some *)
            US0_1(v88)
    let v91 : US0 = v0.l7
    let v92 : US0 = v45.l7
    let v99 : US0 =
        match v92 with
        | US0_0 -> (* None *)
            match v91 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v94) -> (* Some *)
                US0_1(v94)
        | US0_1(v97) -> (* Some *)
            US0_1(v97)
    let v100 : US2 = v0.l5
    let v101 : US2 = v45.l5
    let v108 : US2 =
        match v101 with
        | US2_0 -> (* None *)
            match v100 with
            | US2_0 -> (* None *)
                US2_0
            | US2_1(v103) -> (* Some *)
                US2_1(v103)
        | US2_1(v106) -> (* Some *)
            US2_1(v106)
    let v109 : US3 = v0.l6
    let v110 : US3 = v45.l6
    let v117 : US3 =
        match v110 with
        | US3_0 -> (* None *)
            match v109 with
            | US3_0 -> (* None *)
                US3_0
            | US3_1(v112) -> (* Some *)
                US3_1(v112)
        | US3_1(v115) -> (* Some *)
            US3_1(v115)
    let v118 : US0 = v0.l8
    let v119 : US0 = v45.l8
    let v126 : US0 =
        match v119 with
        | US0_0 -> (* None *)
            match v118 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v121) -> (* Some *)
                US0_1(v121)
        | US0_1(v124) -> (* Some *)
            US0_1(v124)
    let v127 : US2 = v0.l9
    let v128 : US2 = v45.l9
    let v135 : US2 =
        match v128 with
        | US2_0 -> (* None *)
            match v127 with
            | US2_0 -> (* None *)
                US2_0
            | US2_1(v130) -> (* Some *)
                US2_1(v130)
        | US2_1(v133) -> (* Some *)
            US2_1(v133)
    let v136 : US0 = v0.l10
    let v137 : US0 = v45.l10
    let v144 : US0 =
        match v137 with
        | US0_0 -> (* None *)
            match v136 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v139) -> (* Some *)
                US0_1(v139)
        | US0_1(v142) -> (* Some *)
            US0_1(v142)
    let v145 : US0 = v0.l11
    let v146 : US0 = v45.l11
    let v153 : US0 =
        match v146 with
        | US0_0 -> (* None *)
            match v145 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v148) -> (* Some *)
                US0_1(v148)
        | US0_1(v151) -> (* Some *)
            US0_1(v151)
    let v154 : US2 = v0.l12
    let v155 : US2 = v45.l12
    let v162 : US2 =
        match v155 with
        | US2_0 -> (* None *)
            match v154 with
            | US2_0 -> (* None *)
                US2_0
            | US2_1(v157) -> (* Some *)
                US2_1(v157)
        | US2_1(v160) -> (* Some *)
            US2_1(v160)
    let v163 : US4 = v0.l13
    let v164 : US4 = v45.l13
    let v171 : US4 =
        match v164 with
        | US4_0 -> (* None *)
            match v163 with
            | US4_0 -> (* None *)
                US4_0
            | US4_1(v166) -> (* Some *)
                US4_1(v166)
        | US4_1(v169) -> (* Some *)
            US4_1(v169)
    let v172 : US0 = v0.l14
    let v173 : US0 = v45.l14
    let v180 : US0 =
        match v173 with
        | US0_0 -> (* None *)
            match v172 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v175) -> (* Some *)
                US0_1(v175)
        | US0_1(v178) -> (* Some *)
            US0_1(v178)
    let v181 : US0 = v0.l15
    let v182 : US0 = v45.l15
    let v189 : US0 =
        match v182 with
        | US0_0 -> (* None *)
            match v181 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v184) -> (* Some *)
                US0_1(v184)
        | US0_1(v187) -> (* Some *)
            US0_1(v187)
    let v190 : US0 = v0.l16
    let v191 : US0 = v45.l16
    let v198 : US0 =
        match v191 with
        | US0_0 -> (* None *)
            match v190 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v193) -> (* Some *)
                US0_1(v193)
        | US0_1(v196) -> (* Some *)
            US0_1(v196)
    let v199 : US0 = v0.l17
    let v200 : US0 = v45.l17
    let v207 : US0 =
        match v200 with
        | US0_0 -> (* None *)
            match v199 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v202) -> (* Some *)
                US0_1(v202)
        | US0_1(v205) -> (* Some *)
            US0_1(v205)
    let v208 : US5 = v0.l18
    let v209 : US5 = v45.l18
    let v216 : US5 =
        match v209 with
        | US5_0 -> (* None *)
            match v208 with
            | US5_0 -> (* None *)
                US5_0
            | US5_1(v211) -> (* Some *)
                US5_1(v211)
        | US5_1(v214) -> (* Some *)
            US5_1(v214)
    let v217 : US0 = v0.l19
    let v218 : US0 = v45.l19
    let v225 : US0 =
        match v218 with
        | US0_0 -> (* None *)
            match v217 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v220) -> (* Some *)
                US0_1(v220)
        | US0_1(v223) -> (* Some *)
            US0_1(v223)
    let v226 : US2 = v0.l37
    let v227 : US2 = v45.l37
    let v234 : US2 =
        match v227 with
        | US2_0 -> (* None *)
            match v226 with
            | US2_0 -> (* None *)
                US2_0
            | US2_1(v229) -> (* Some *)
                US2_1(v229)
        | US2_1(v232) -> (* Some *)
            US2_1(v232)
    let v235 : US0 = v0.l20
    let v236 : US0 = v45.l20
    let v243 : US0 =
        match v236 with
        | US0_0 -> (* None *)
            match v235 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v238) -> (* Some *)
                US0_1(v238)
        | US0_1(v241) -> (* Some *)
            US0_1(v241)
    let v244 : US0 = v0.l21
    let v245 : US0 = v45.l21
    let v252 : US0 =
        match v245 with
        | US0_0 -> (* None *)
            match v244 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v247) -> (* Some *)
                US0_1(v247)
        | US0_1(v250) -> (* Some *)
            US0_1(v250)
    let v253 : US6 = v0.l22
    let v254 : US6 = v45.l22
    let v261 : US6 =
        match v254 with
        | US6_0 -> (* None *)
            match v253 with
            | US6_0 -> (* None *)
                US6_0
            | US6_1(v256) -> (* Some *)
                US6_1(v256)
        | US6_1(v259) -> (* Some *)
            US6_1(v259)
    let v262 : US0 = v0.l23
    let v263 : US0 = v45.l23
    let v270 : US0 =
        match v263 with
        | US0_0 -> (* None *)
            match v262 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v265) -> (* Some *)
                US0_1(v265)
        | US0_1(v268) -> (* Some *)
            US0_1(v268)
    let v271 : US0 = v0.l24
    let v272 : US0 = v45.l24
    let v279 : US0 =
        match v272 with
        | US0_0 -> (* None *)
            match v271 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v274) -> (* Some *)
                US0_1(v274)
        | US0_1(v277) -> (* Some *)
            US0_1(v277)
    let v280 : US0 = v0.l25
    let v281 : US0 = v45.l25
    let v288 : US0 =
        match v281 with
        | US0_0 -> (* None *)
            match v280 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v283) -> (* Some *)
                US0_1(v283)
        | US0_1(v286) -> (* Some *)
            US0_1(v286)
    let v289 : US0 = v0.l26
    let v290 : US0 = v45.l26
    let v297 : US0 =
        match v290 with
        | US0_0 -> (* None *)
            match v289 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v292) -> (* Some *)
                US0_1(v292)
        | US0_1(v295) -> (* Some *)
            US0_1(v295)
    let v298 : US7 = v0.l27
    let v299 : US7 = v45.l27
    let v306 : US7 =
        match v299 with
        | US7_0 -> (* None *)
            match v298 with
            | US7_0 -> (* None *)
                US7_0
            | US7_1(v301) -> (* Some *)
                US7_1(v301)
        | US7_1(v304) -> (* Some *)
            US7_1(v304)
    let v307 : US8 = v0.l28
    let v308 : US8 = v45.l28
    let v315 : US8 =
        match v308 with
        | US8_0 -> (* None *)
            match v307 with
            | US8_0 -> (* None *)
                US8_0
            | US8_1(v310) -> (* Some *)
                US8_1(v310)
        | US8_1(v313) -> (* Some *)
            US8_1(v313)
    let v316 : US0 = v0.l29
    let v317 : US0 = v45.l29
    let v324 : US0 =
        match v317 with
        | US0_0 -> (* None *)
            match v316 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v319) -> (* Some *)
                US0_1(v319)
        | US0_1(v322) -> (* Some *)
            US0_1(v322)
    let v325 : US0 = v0.l30
    let v326 : US0 = v45.l30
    let v333 : US0 =
        match v326 with
        | US0_0 -> (* None *)
            match v325 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v328) -> (* Some *)
                US0_1(v328)
        | US0_1(v331) -> (* Some *)
            US0_1(v331)
    let v334 : US0 = v0.l31
    let v335 : US0 = v45.l31
    let v342 : US0 =
        match v335 with
        | US0_0 -> (* None *)
            match v334 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v337) -> (* Some *)
                US0_1(v337)
        | US0_1(v340) -> (* Some *)
            US0_1(v340)
    let v343 : US0 = v0.l32
    let v344 : US0 = v45.l32
    let v351 : US0 =
        match v344 with
        | US0_0 -> (* None *)
            match v343 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v346) -> (* Some *)
                US0_1(v346)
        | US0_1(v349) -> (* Some *)
            US0_1(v349)
    let v352 : US0 = v0.l33
    let v353 : US0 = v45.l33
    let v360 : US0 =
        match v353 with
        | US0_0 -> (* None *)
            match v352 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v355) -> (* Some *)
                US0_1(v355)
        | US0_1(v358) -> (* Some *)
            US0_1(v358)
    let v361 : US0 = v0.l34
    let v362 : US0 = v45.l34
    let v369 : US0 =
        match v362 with
        | US0_0 -> (* None *)
            match v361 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v364) -> (* Some *)
                US0_1(v364)
        | US0_1(v367) -> (* Some *)
            US0_1(v367)
    let v370 : US0 = v0.l35
    let v371 : US0 = v45.l35
    let v378 : US0 =
        match v371 with
        | US0_0 -> (* None *)
            match v370 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v373) -> (* Some *)
                US0_1(v373)
        | US0_1(v376) -> (* Some *)
            US0_1(v376)
    let v379 : US0 = v0.l36
    let v380 : US0 = v45.l36
    let v387 : US0 =
        match v380 with
        | US0_0 -> (* None *)
            match v379 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v382) -> (* Some *)
                US0_1(v382)
        | US0_1(v385) -> (* Some *)
            US0_1(v385)
    let v388 : US0 = v0.l38
    let v389 : US0 = v45.l38
    let v396 : US0 =
        match v389 with
        | US0_0 -> (* None *)
            match v388 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v391) -> (* Some *)
                US0_1(v391)
        | US0_1(v394) -> (* Some *)
            US0_1(v394)
    let v397 : US0 = v0.l39
    let v398 : US0 = v45.l39
    let v405 : US0 =
        match v398 with
        | US0_0 -> (* None *)
            match v397 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v400) -> (* Some *)
                US0_1(v400)
        | US0_1(v403) -> (* Some *)
            US0_1(v403)
    let v406 : US5 = v0.l40
    let v407 : US5 = v45.l40
    let v414 : US5 =
        match v407 with
        | US5_0 -> (* None *)
            match v406 with
            | US5_0 -> (* None *)
                US5_0
            | US5_1(v409) -> (* Some *)
                US5_1(v409)
        | US5_1(v412) -> (* Some *)
            US5_1(v412)
    let v415 : US0 = v0.l41
    let v416 : US0 = v45.l41
    let v423 : US0 =
        match v416 with
        | US0_0 -> (* None *)
            match v415 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v418) -> (* Some *)
                US0_1(v418)
        | US0_1(v421) -> (* Some *)
            US0_1(v421)
    let v424 : US0 = v0.l42
    let v425 : US0 = v45.l42
    let v432 : US0 =
        match v425 with
        | US0_0 -> (* None *)
            match v424 with
            | US0_0 -> (* None *)
                US0_0
            | US0_1(v427) -> (* Some *)
                US0_1(v427)
        | US0_1(v430) -> (* Some *)
            US0_1(v430)
    let v433 : US4 = v0.l43
    let v434 : US4 = v45.l43
    let v441 : US4 =
        match v434 with
        | US4_0 -> (* None *)
            match v433 with
            | US4_0 -> (* None *)
                US4_0
            | US4_1(v436) -> (* Some *)
                US4_1(v436)
        | US4_1(v439) -> (* Some *)
            US4_1(v439)
    let v442 : Heap0 = {l0 = v54; l1 = v63; l2 = v72; l3 = v81; l4 = v90; l5 = v108; l6 = v117; l7 = v99; l8 = v126; l9 = v135; l10 = v144; l11 = v153; l12 = v162; l13 = v171; l14 = v180; l15 = v189; l16 = v198; l17 = v207; l18 = v216; l19 = v225; l20 = v243; l21 = v252; l22 = v261; l23 = v270; l24 = v279; l25 = v288; l26 = v297; l27 = v306; l28 = v315; l29 = v324; l30 = v333; l31 = v342; l32 = v351; l33 = v360; l34 = v369; l35 = v378; l36 = v387; l37 = v234; l38 = v396; l39 = v405; l40 = v414; l41 = v423; l42 = v432; l43 = v441} : Heap0
    v442
and method3 (v0 : string, v1 : US0) : US9 =
    match v1 with
    | US0_0 -> (* None *)
        US9_0
    | US0_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US9_1(v4)
and method4 (v0 : string, v1 : US1) : US9 =
    match v1 with
    | US1_0 -> (* None *)
        US9_0
    | US1_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US9_1(v4)
and method5 (v0 : string, v1 : US2) : US9 =
    match v1 with
    | US2_0 -> (* None *)
        US9_0
    | US2_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US9_1(v4)
and method6 (v0 : string, v1 : US3) : US9 =
    match v1 with
    | US3_0 -> (* None *)
        US9_0
    | US3_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US9_1(v4)
and method7 (v0 : string, v1 : US4) : US9 =
    match v1 with
    | US4_0 -> (* None *)
        US9_0
    | US4_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US9_1(v4)
and method8 (v0 : string, v1 : US5) : US9 =
    match v1 with
    | US5_0 -> (* None *)
        US9_0
    | US5_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US9_1(v4)
and method9 (v0 : string, v1 : US6) : US9 =
    match v1 with
    | US6_0 -> (* None *)
        US9_0
    | US6_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US9_1(v4)
and method10 (v0 : string, v1 : US7) : US9 =
    match v1 with
    | US7_0 -> (* None *)
        US9_0
    | US7_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US9_1(v4)
and method11 (v0 : string, v1 : US8) : US9 =
    match v1 with
    | US8_0 -> (* None *)
        US9_0
    | US8_1(v3) -> (* Some *)
        let v4 : JSX.Prop = JSX.Prop (v0, v3)
        US9_1(v4)
and method12 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method13 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method2 (v0 : Heap0) : (JSX.Prop []) =
    let v1 : string = "aria-label"
    let v2 : US0 = v0.l0
    let v3 : US9 = method3(v1, v2)
    let v4 : string = "as"
    let v5 : US1 = v0.l1
    let v6 : US9 = method4(v4, v5)
    let v7 : string = "backgroundColor"
    let v8 : US0 = v0.l2
    let v9 : US9 = method3(v7, v8)
    let v10 : string = "border"
    let v11 : US0 = v0.l3
    let v12 : US9 = method3(v10, v11)
    let v13 : string = "bottom"
    let v14 : US0 = v0.l4
    let v15 : US9 = method3(v13, v14)
    let v16 : string = "color"
    let v17 : US0 = v0.l7
    let v18 : US9 = method3(v16, v17)
    let v19 : string = "checked"
    let v20 : US2 = v0.l5
    let v21 : US9 = method5(v19, v20)
    let v22 : string = "children"
    let v23 : US3 = v0.l6
    let v24 : US9 = method6(v22, v23)
    let v25 : string = "colorScheme"
    let v26 : US0 = v0.l8
    let v27 : US9 = method3(v25, v26)
    let v28 : string = "compact"
    let v29 : US2 = v0.l9
    let v30 : US9 = method5(v28, v29)
    let v31 : string = "display"
    let v32 : US0 = v0.l11
    let v33 : US9 = method3(v31, v32)
    let v34 : string = "direction"
    let v35 : US0 = v0.l10
    let v36 : US9 = method3(v34, v35)
    let v37 : string = "external"
    let v38 : US2 = v0.l12
    let v39 : US9 = method5(v37, v38)
    let v40 : string = "flex"
    let v41 : US4 = v0.l13
    let v42 : US9 = method7(v40, v41)
    let v43 : string = "flexDirection"
    let v44 : US0 = v0.l14
    let v45 : US9 = method3(v43, v44)
    let v46 : string = "fontSize"
    let v47 : US0 = v0.l15
    let v48 : US9 = method3(v46, v47)
    let v49 : string = "height"
    let v50 : US0 = v0.l16
    let v51 : US9 = method3(v49, v50)
    let v52 : string = "href"
    let v53 : US0 = v0.l17
    let v54 : US9 = method3(v52, v53)
    let v55 : string = "icon"
    let v56 : US5 = v0.l18
    let v57 : US9 = method8(v55, v56)
    let v58 : string = "id"
    let v59 : US0 = v0.l19
    let v60 : US9 = method3(v58, v59)
    let v61 : string = "justifyContent"
    let v62 : US0 = v0.l20
    let v63 : US9 = method3(v61, v62)
    let v64 : string = "left"
    let v65 : US0 = v0.l21
    let v66 : US9 = method3(v64, v65)
    let v67 : string = "leftIcon"
    let v68 : US6 = v0.l22
    let v69 : US9 = method9(v67, v68)
    let v70 : string = "lineHeight"
    let v71 : US0 = v0.l23
    let v72 : US9 = method3(v70, v71)
    let v73 : string = "margin"
    let v74 : US0 = v0.l24
    let v75 : US9 = method3(v73, v74)
    let v76 : string = "marginBottom"
    let v77 : US0 = v0.l25
    let v78 : US9 = method3(v76, v77)
    let v79 : string = "maxHeight"
    let v80 : US0 = v0.l26
    let v81 : US9 = method3(v79, v80)
    let v82 : string = "onChange"
    let v83 : US7 = v0.l27
    let v84 : US9 = method10(v82, v83)
    let v85 : string = "onClick"
    let v86 : US8 = v0.l28
    let v87 : US9 = method11(v85, v86)
    let v88 : string = "outline"
    let v89 : US0 = v0.l29
    let v90 : US9 = method3(v88, v89)
    let v91 : string = "overflowY"
    let v92 : US0 = v0.l30
    let v93 : US9 = method3(v91, v92)
    let v94 : string = "padding"
    let v95 : US0 = v0.l31
    let v96 : US9 = method3(v94, v95)
    let v97 : string = "paddingTop"
    let v98 : US0 = v0.l32
    let v99 : US9 = method3(v97, v98)
    let v100 : string = "position"
    let v101 : US0 = v0.l33
    let v102 : US9 = method3(v100, v101)
    let v103 : string = "right"
    let v104 : US0 = v0.l34
    let v105 : US9 = method3(v103, v104)
    let v106 : string = "size"
    let v107 : US0 = v0.l35
    let v108 : US9 = method3(v106, v107)
    let v109 : string = "spacing"
    let v110 : US0 = v0.l36
    let v111 : US9 = method3(v109, v110)
    let v112 : string = "status"
    let v113 : US2 = v0.l37
    let v114 : US9 = method5(v112, v113)
    let v115 : string = "striped"
    let v116 : US0 = v0.l38
    let v117 : US9 = method3(v115, v116)
    let v118 : string = "thickness"
    let v119 : US0 = v0.l39
    let v120 : US9 = method3(v118, v119)
    let v121 : string = "title"
    let v122 : US5 = v0.l40
    let v123 : US9 = method8(v121, v122)
    let v124 : string = "top"
    let v125 : US0 = v0.l41
    let v126 : US9 = method3(v124, v125)
    let v127 : string = "width"
    let v128 : US0 = v0.l42
    let v129 : US9 = method3(v127, v128)
    let v130 : string = "zIndex"
    let v131 : US4 = v0.l43
    let v132 : US9 = method7(v130, v131)
    let v133 : (US9 []) = [|v3; v6; v9; v12; v15; v18; v21; v24; v27; v30; v33; v36; v39; v42; v45; v48; v51; v54; v57; v60; v63; v66; v69; v72; v75; v78; v81; v84; v87; v90; v93; v96; v99; v102; v105; v108; v111; v114; v117; v120; v123; v126; v129; v132|]
    let v134 : int32 = v133.Length
    let v135 : (US9 []) = Array.zeroCreate<US9> (v134)
    let v136 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method12(v134, v136) do
        let v138 : int32 = v136.l0
        let v139 : int32 = v136.l1
        let v140 : US9 = v133.[int v138]
        let v142 : bool =
            match v140 with
            | US9_0 -> (* None *)
                false
            | US9_1(v141) -> (* Some *)
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
    let v147 : (US9 []) = Array.zeroCreate<US9> (v146)
    let v148 : Mut1 = {l0 = 0} : Mut1
    while method13(v146, v148) do
        let v150 : int32 = v148.l0
        let v151 : US9 = v135.[int v150]
        v147.[int v150] <- v151
        let v152 : int32 = v150 + 1
        v148.l0 <- v152
        ()
    let v153 : int32 = v147.Length
    let v154 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v153)
    let v155 : Mut1 = {l0 = 0} : Mut1
    while method13(v153, v155) do
        let v157 : int32 = v155.l0
        let v158 : US9 = v147.[int v157]
        let v161 : JSX.Prop =
            match v158 with
            | US9_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US9_1(v160) -> (* Some *)
                v160
        v154.[int v157] <- v161
        let v162 : int32 = v157 + 1
        v155.l0 <- v162
        ()
    v154
and closure0 () (v0 : Heap0) : JSX.Element =
    let struct (v1 : US0, v2 : US1, v3 : US0, v4 : US0, v5 : US0, v6 : US2, v7 : US3, v8 : US0, v9 : US0, v10 : US2, v11 : US0, v12 : US0, v13 : US2, v14 : US4, v15 : US0, v16 : US0, v17 : US0, v18 : US0, v19 : US5, v20 : US0, v21 : US0, v22 : US0, v23 : US6, v24 : US0, v25 : US0, v26 : US0, v27 : US0, v28 : US7, v29 : US8, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US0, v38 : US2, v39 : US0, v40 : US0, v41 : US5, v42 : US0, v43 : US0, v44 : US4) = method0()
    let v45 : string = "neutral"
    let v46 : US0 = US0_1(v45)
    let v47 : bool = true
    let v48 : US2 = US2_1(v47)
    let v49 : string = "left"
    let v50 : US0 = US0_1(v49)
    let v51 : string = "xs"
    let v52 : US0 = US0_1(v51)
    let v53 : Heap0 = method1(v0, v1, v2, v3, v4, v5, v6, v7, v8, v46, v48, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v50, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v52, v37, v38, v39, v40, v41, v42, v43, v44)
    let v54 : (JSX.Prop []) = method2(v53)
    let v55 : obj = createObj v54
    let v56 : string = "createComponent"
    let v57 : string = "solid-js"
    let v58 : JS.Function = import v56 v57
    let v59 : string = "Button"
    let v60 : string = "@hope-ui/solid"
    let v61 : JSX.Element = v58.Invoke ((import v59 v60), v55) |> unbox<JSX.Element>
    v61
and closure2 () (v0 : Heap0) : JSX.Element =
    let v1 : (JSX.Prop []) = method2(v0)
    let v2 : obj = createObj v1
    let v3 : string = "createComponent"
    let v4 : string = "solid-js"
    let v5 : JS.Function = import v3 v4
    let v6 : string = "Table"
    let v7 : string = "@hope-ui/solid"
    let v8 : JSX.Element = v5.Invoke ((import v6 v7), v2) |> unbox<JSX.Element>
    v8
and closure4 () (v0 : Heap0) : JSX.Element =
    let v1 : (JSX.Prop []) = method2(v0)
    let v2 : obj = createObj v1
    let v3 : string = "createComponent"
    let v4 : string = "solid-js"
    let v5 : JS.Function = import v3 v4
    let v6 : string = "Tbody"
    let v7 : string = "@hope-ui/solid"
    let v8 : JSX.Element = v5.Invoke ((import v6 v7), v2) |> unbox<JSX.Element>
    v8
and method14 (v0 : (Heap0 -> JSX.Element), v1 : Heap0) : JSX.Element =
    let v2 : JS.Function = v0 |> unbox<JS.Function>
    let v3 : string = "createComponent"
    let v4 : string = "solid-js"
    let v5 : JS.Function = import v3 v4
    let v6 : JSX.Element = v5.Invoke (v2, v1) |> unbox<JSX.Element>
    v6
and closure3 (v0 : Heap0, v1 : US0, v2 : US1, v3 : US0, v4 : US0, v5 : US0, v6 : US2, v7 : US3, v8 : US0, v9 : US0, v10 : US2, v11 : US0, v12 : US0, v13 : US2, v14 : US4, v15 : US0, v16 : US0, v17 : US0, v18 : US0, v19 : US5, v20 : US0, v21 : US0, v22 : US0, v23 : US6, v24 : US0, v25 : US0, v26 : US0, v27 : US0, v28 : US7, v29 : US8, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US0, v38 : US2, v39 : US0, v40 : US0, v41 : US5, v42 : US0, v43 : US0, v44 : US4) () : JSX.Element =
    let v45 : (Heap0 -> JSX.Element) = closure4()
    let v46 : US3 = v0.l6
    let v47 : string = "flex"
    let v48 : US0 = US0_1(v47)
    let v49 : string = "column"
    let v50 : US0 = US0_1(v49)
    let v51 : Heap0 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v46; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v48; l12 = v13; l13 = v14; l14 = v50; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44} : Heap0
    let v52 : JSX.Element = method14(v45, v51)
    let v53 : (JSX.Element []) = [|v52|]
    let v54 : JSX.Element = v53 |> unbox<JSX.Element>
    v54
and closure1 () (v0 : Heap0) : JSX.Element =
    let struct (v1 : US0, v2 : US1, v3 : US0, v4 : US0, v5 : US0, v6 : US2, v7 : US3, v8 : US0, v9 : US0, v10 : US2, v11 : US0, v12 : US0, v13 : US2, v14 : US4, v15 : US0, v16 : US0, v17 : US0, v18 : US0, v19 : US5, v20 : US0, v21 : US0, v22 : US0, v23 : US6, v24 : US0, v25 : US0, v26 : US0, v27 : US0, v28 : US7, v29 : US8, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US0, v38 : US2, v39 : US0, v40 : US0, v41 : US5, v42 : US0, v43 : US0, v44 : US4) = method0()
    let v45 : (Heap0 -> JSX.Element) = closure2()
    let v46 : (unit -> JSX.Element) = closure3(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44)
    let v47 : US3 = US3_1(v46)
    let v48 : string = "flex"
    let v49 : US0 = US0_1(v48)
    let v50 : US4 = US4_1(1)
    let v51 : string = "column"
    let v52 : US0 = US0_1(v51)
    let v53 : string = "odd"
    let v54 : US0 = US0_1(v53)
    let v55 : Heap0 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v47; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v49; l12 = v13; l13 = v50; l14 = v52; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v54; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44} : Heap0
    method14(v45, v55)
and method16 (v0 : int32, v1 : Mut2) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method15 (v0 : (struct (string * obj) [])) : Heap0 =
    let struct (v1 : US0, v2 : US1, v3 : US0, v4 : US0, v5 : US0, v6 : US2, v7 : US3, v8 : US0, v9 : US0, v10 : US2, v11 : US0, v12 : US0, v13 : US2, v14 : US4, v15 : US0, v16 : US0, v17 : US0, v18 : US0, v19 : US5, v20 : US0, v21 : US0, v22 : US0, v23 : US6, v24 : US0, v25 : US0, v26 : US0, v27 : US0, v28 : US7, v29 : US8, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US0, v38 : US2, v39 : US0, v40 : US0, v41 : US5, v42 : US0, v43 : US0, v44 : US4) = method0()
    let v45 : int32 = v0.Length
    let v46 : Mut2 = {l0 = 0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44} : Mut2
    while method16(v45, v46) do
        let v48 : int32 = v46.l0
        let struct (v49 : US0, v50 : US1, v51 : US0, v52 : US0, v53 : US0, v54 : US2, v55 : US3, v56 : US0, v57 : US0, v58 : US2, v59 : US0, v60 : US0, v61 : US2, v62 : US4, v63 : US0, v64 : US0, v65 : US0, v66 : US0, v67 : US5, v68 : US0, v69 : US0, v70 : US0, v71 : US6, v72 : US0, v73 : US0, v74 : US0, v75 : US0, v76 : US7, v77 : US8, v78 : US0, v79 : US0, v80 : US0, v81 : US0, v82 : US0, v83 : US0, v84 : US0, v85 : US0, v86 : US2, v87 : US0, v88 : US0, v89 : US5, v90 : US0, v91 : US0, v92 : US4) = v46.l1, v46.l2, v46.l3, v46.l4, v46.l5, v46.l6, v46.l7, v46.l8, v46.l9, v46.l10, v46.l11, v46.l12, v46.l13, v46.l14, v46.l15, v46.l16, v46.l17, v46.l18, v46.l19, v46.l20, v46.l21, v46.l22, v46.l23, v46.l24, v46.l25, v46.l26, v46.l27, v46.l28, v46.l29, v46.l30, v46.l31, v46.l32, v46.l33, v46.l34, v46.l35, v46.l36, v46.l37, v46.l38, v46.l39, v46.l40, v46.l41, v46.l42, v46.l43, v46.l44
        let struct (v93 : string, v94 : obj) = v0.[int v48]
        let v95 : bool = v94 = JS.undefined
        let struct (v2209 : US0, v2210 : US1, v2211 : US0, v2212 : US0, v2213 : US0, v2214 : US2, v2215 : US3, v2216 : US0, v2217 : US0, v2218 : US2, v2219 : US0, v2220 : US0, v2221 : US2, v2222 : US4, v2223 : US0, v2224 : US0, v2225 : US0, v2226 : US0, v2227 : US5, v2228 : US0, v2229 : US0, v2230 : US0, v2231 : US6, v2232 : US0, v2233 : US0, v2234 : US0, v2235 : US0, v2236 : US7, v2237 : US8, v2238 : US0, v2239 : US0, v2240 : US0, v2241 : US0, v2242 : US0, v2243 : US0, v2244 : US0, v2245 : US0, v2246 : US2, v2247 : US0, v2248 : US0, v2249 : US5, v2250 : US0, v2251 : US0, v2252 : US4) =
            if v95 then
                struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
            else
                let v96 : bool = "aria-label" = v93
                if v96 then
                    let v97 : string = v94 |> unbox
                    let v98 : US0 = US0_1(v97)
                    struct (v98, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                else
                    let v99 : bool = "as" = v93
                    if v99 then
                        let v100 : JS.Function = v94 |> unbox
                        let v101 : US1 = US1_1(v100)
                        struct (v49, v101, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                    else
                        let v102 : bool = "backgroundColor" = v93
                        if v102 then
                            let v103 : string = v94 |> unbox
                            let v104 : US0 = US0_1(v103)
                            struct (v49, v50, v104, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                        else
                            let v105 : bool = "border" = v93
                            if v105 then
                                let v106 : string = v94 |> unbox
                                let v107 : US0 = US0_1(v106)
                                struct (v49, v50, v51, v107, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                            else
                                let v108 : bool = "bottom" = v93
                                if v108 then
                                    let v109 : string = v94 |> unbox
                                    let v110 : US0 = US0_1(v109)
                                    struct (v49, v50, v51, v52, v110, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                else
                                    let v111 : bool = "color" = v93
                                    if v111 then
                                        let v112 : string = v94 |> unbox
                                        let v113 : US0 = US0_1(v112)
                                        struct (v49, v50, v51, v52, v53, v54, v55, v113, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                    else
                                        let v114 : bool = "checked" = v93
                                        if v114 then
                                            let v115 : bool = v94 |> unbox
                                            let v116 : US2 = US2_1(v115)
                                            struct (v49, v50, v51, v52, v53, v116, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                        else
                                            let v117 : bool = "children" = v93
                                            if v117 then
                                                let v118 : (unit -> JSX.Element) = v94 |> unbox
                                                let v119 : US3 = US3_1(v118)
                                                struct (v49, v50, v51, v52, v53, v54, v119, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                            else
                                                let v120 : bool = "colorScheme" = v93
                                                if v120 then
                                                    let v121 : string = v94 |> unbox
                                                    let v122 : US0 = US0_1(v121)
                                                    struct (v49, v50, v51, v52, v53, v54, v55, v56, v122, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                else
                                                    let v123 : bool = "compact" = v93
                                                    if v123 then
                                                        let v124 : bool = v94 |> unbox
                                                        let v125 : US2 = US2_1(v124)
                                                        struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v125, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                    else
                                                        let v126 : bool = "display" = v93
                                                        if v126 then
                                                            let v127 : string = v94 |> unbox
                                                            let v128 : US0 = US0_1(v127)
                                                            struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v128, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                        else
                                                            let v129 : bool = "direction" = v93
                                                            if v129 then
                                                                let v130 : string = v94 |> unbox
                                                                let v131 : US0 = US0_1(v130)
                                                                struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v131, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                            else
                                                                let v132 : bool = "external" = v93
                                                                if v132 then
                                                                    let v133 : bool = v94 |> unbox
                                                                    let v134 : US2 = US2_1(v133)
                                                                    struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v134, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                else
                                                                    let v135 : bool = "flex" = v93
                                                                    if v135 then
                                                                        let v136 : int32 = v94 |> unbox
                                                                        let v137 : US4 = US4_1(v136)
                                                                        struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v137, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                    else
                                                                        let v138 : bool = "flexDirection" = v93
                                                                        if v138 then
                                                                            let v139 : string = v94 |> unbox
                                                                            let v140 : US0 = US0_1(v139)
                                                                            struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v140, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                        else
                                                                            let v141 : bool = "fontSize" = v93
                                                                            if v141 then
                                                                                let v142 : string = v94 |> unbox
                                                                                let v143 : US0 = US0_1(v142)
                                                                                struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v143, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                            else
                                                                                let v144 : bool = "height" = v93
                                                                                if v144 then
                                                                                    let v145 : string = v94 |> unbox
                                                                                    let v146 : US0 = US0_1(v145)
                                                                                    struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v146, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                else
                                                                                    let v147 : bool = "href" = v93
                                                                                    if v147 then
                                                                                        let v148 : string = v94 |> unbox
                                                                                        let v149 : US0 = US0_1(v148)
                                                                                        struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v149, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                    else
                                                                                        let v150 : bool = "icon" = v93
                                                                                        if v150 then
                                                                                            let v151 : JSX.Element = v94 |> unbox
                                                                                            let v152 : US5 = US5_1(v151)
                                                                                            struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v152, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                        else
                                                                                            let v153 : bool = "id" = v93
                                                                                            if v153 then
                                                                                                let v154 : string = v94 |> unbox
                                                                                                let v155 : US0 = US0_1(v154)
                                                                                                struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v155, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                            else
                                                                                                let v156 : bool = "justifyContent" = v93
                                                                                                if v156 then
                                                                                                    let v157 : string = v94 |> unbox
                                                                                                    let v158 : US0 = US0_1(v157)
                                                                                                    struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v158, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                                else
                                                                                                    let v159 : bool = "left" = v93
                                                                                                    if v159 then
                                                                                                        let v160 : string = v94 |> unbox
                                                                                                        let v161 : US0 = US0_1(v160)
                                                                                                        struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v161, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                                    else
                                                                                                        let v162 : bool = "leftIcon" = v93
                                                                                                        if v162 then
                                                                                                            let v163 : obj = v94 |> unbox
                                                                                                            let v164 : US6 = US6_1(v163)
                                                                                                            struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v164, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                                        else
                                                                                                            let v165 : bool = "lineHeight" = v93
                                                                                                            if v165 then
                                                                                                                let v166 : string = v94 |> unbox
                                                                                                                let v167 : US0 = US0_1(v166)
                                                                                                                struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v167, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                                            else
                                                                                                                let v168 : bool = "margin" = v93
                                                                                                                if v168 then
                                                                                                                    let v169 : string = v94 |> unbox
                                                                                                                    let v170 : US0 = US0_1(v169)
                                                                                                                    struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v170, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                                                else
                                                                                                                    let v171 : bool = "marginBottom" = v93
                                                                                                                    if v171 then
                                                                                                                        let v172 : string = v94 |> unbox
                                                                                                                        let v173 : US0 = US0_1(v172)
                                                                                                                        struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v173, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                                                    else
                                                                                                                        let v174 : bool = "maxHeight" = v93
                                                                                                                        if v174 then
                                                                                                                            let v175 : string = v94 |> unbox
                                                                                                                            let v176 : US0 = US0_1(v175)
                                                                                                                            struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v176, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                                                        else
                                                                                                                            let v177 : bool = "onChange" = v93
                                                                                                                            if v177 then
                                                                                                                                let v178 : (obj -> unit) = v94 |> unbox
                                                                                                                                let v179 : US7 = US7_1(v178)
                                                                                                                                struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v179, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                                                            else
                                                                                                                                let v180 : bool = "onClick" = v93
                                                                                                                                if v180 then
                                                                                                                                    let v181 : (unit -> unit) = v94 |> unbox
                                                                                                                                    let v182 : US8 = US8_1(v181)
                                                                                                                                    struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v182, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                                                                else
                                                                                                                                    let v183 : bool = "outline" = v93
                                                                                                                                    if v183 then
                                                                                                                                        let v184 : string = v94 |> unbox
                                                                                                                                        let v185 : US0 = US0_1(v184)
                                                                                                                                        struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v185, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                                                                    else
                                                                                                                                        let v186 : bool = "overflowY" = v93
                                                                                                                                        if v186 then
                                                                                                                                            let v187 : string = v94 |> unbox
                                                                                                                                            let v188 : US0 = US0_1(v187)
                                                                                                                                            struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v188, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                                                                        else
                                                                                                                                            let v189 : bool = "padding" = v93
                                                                                                                                            if v189 then
                                                                                                                                                let v190 : string = v94 |> unbox
                                                                                                                                                let v191 : US0 = US0_1(v190)
                                                                                                                                                struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v191, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                                                                            else
                                                                                                                                                let v192 : bool = "paddingTop" = v93
                                                                                                                                                if v192 then
                                                                                                                                                    let v193 : string = v94 |> unbox
                                                                                                                                                    let v194 : US0 = US0_1(v193)
                                                                                                                                                    struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v194, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                                                                                else
                                                                                                                                                    let v195 : bool = "position" = v93
                                                                                                                                                    if v195 then
                                                                                                                                                        let v196 : string = v94 |> unbox
                                                                                                                                                        let v197 : US0 = US0_1(v196)
                                                                                                                                                        struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v197, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                                                                                    else
                                                                                                                                                        let v198 : bool = "right" = v93
                                                                                                                                                        if v198 then
                                                                                                                                                            let v199 : string = v94 |> unbox
                                                                                                                                                            let v200 : US0 = US0_1(v199)
                                                                                                                                                            struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v200, v84, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                                                                                        else
                                                                                                                                                            let v201 : bool = "size" = v93
                                                                                                                                                            if v201 then
                                                                                                                                                                let v202 : string = v94 |> unbox
                                                                                                                                                                let v203 : US0 = US0_1(v202)
                                                                                                                                                                struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v203, v85, v86, v87, v88, v89, v90, v91, v92)
                                                                                                                                                            else
                                                                                                                                                                let v204 : bool = "spacing" = v93
                                                                                                                                                                if v204 then
                                                                                                                                                                    let v205 : string = v94 |> unbox
                                                                                                                                                                    let v206 : US0 = US0_1(v205)
                                                                                                                                                                    struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v206, v86, v87, v88, v89, v90, v91, v92)
                                                                                                                                                                else
                                                                                                                                                                    let v207 : bool = "status" = v93
                                                                                                                                                                    if v207 then
                                                                                                                                                                        let v208 : bool = v94 |> unbox
                                                                                                                                                                        let v209 : US2 = US2_1(v208)
                                                                                                                                                                        struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v209, v87, v88, v89, v90, v91, v92)
                                                                                                                                                                    else
                                                                                                                                                                        let v210 : bool = "striped" = v93
                                                                                                                                                                        if v210 then
                                                                                                                                                                            let v211 : string = v94 |> unbox
                                                                                                                                                                            let v212 : US0 = US0_1(v211)
                                                                                                                                                                            struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v212, v88, v89, v90, v91, v92)
                                                                                                                                                                        else
                                                                                                                                                                            let v213 : bool = "thickness" = v93
                                                                                                                                                                            if v213 then
                                                                                                                                                                                let v214 : string = v94 |> unbox
                                                                                                                                                                                let v215 : US0 = US0_1(v214)
                                                                                                                                                                                struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v215, v89, v90, v91, v92)
                                                                                                                                                                            else
                                                                                                                                                                                let v216 : bool = "title" = v93
                                                                                                                                                                                if v216 then
                                                                                                                                                                                    let v217 : JSX.Element = v94 |> unbox
                                                                                                                                                                                    let v218 : US5 = US5_1(v217)
                                                                                                                                                                                    struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v218, v90, v91, v92)
                                                                                                                                                                                else
                                                                                                                                                                                    let v219 : bool = "top" = v93
                                                                                                                                                                                    if v219 then
                                                                                                                                                                                        let v220 : string = v94 |> unbox
                                                                                                                                                                                        let v221 : US0 = US0_1(v220)
                                                                                                                                                                                        struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v221, v91, v92)
                                                                                                                                                                                    else
                                                                                                                                                                                        let v222 : bool = "width" = v93
                                                                                                                                                                                        if v222 then
                                                                                                                                                                                            let v223 : string = v94 |> unbox
                                                                                                                                                                                            let v224 : US0 = US0_1(v223)
                                                                                                                                                                                            struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v224, v92)
                                                                                                                                                                                        else
                                                                                                                                                                                            let v225 : bool = "zIndex" = v93
                                                                                                                                                                                            if v225 then
                                                                                                                                                                                                let v226 : int32 = v94 |> unbox
                                                                                                                                                                                                let v227 : US4 = US4_1(v226)
                                                                                                                                                                                                struct (v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v227)
                                                                                                                                                                                            else
                                                                                                                                                                                                let v228 : string = $"unknown prop: {v93} = {v94}"
                                                                                                                                                                                                failwith<struct (US0 * US1 * US0 * US0 * US0 * US2 * US3 * US0 * US0 * US2 * US0 * US0 * US2 * US4 * US0 * US0 * US0 * US0 * US5 * US0 * US0 * US0 * US6 * US0 * US0 * US0 * US0 * US7 * US8 * US0 * US0 * US0 * US0 * US0 * US0 * US0 * US0 * US2 * US0 * US0 * US5 * US0 * US0 * US4)> v228
        let v2253 : int32 = v48 + 1
        v46.l0 <- v2253
        v46.l1 <- v2209
        v46.l2 <- v2210
        v46.l3 <- v2211
        v46.l4 <- v2212
        v46.l5 <- v2213
        v46.l6 <- v2214
        v46.l7 <- v2215
        v46.l8 <- v2216
        v46.l9 <- v2217
        v46.l10 <- v2218
        v46.l11 <- v2219
        v46.l12 <- v2220
        v46.l13 <- v2221
        v46.l14 <- v2222
        v46.l15 <- v2223
        v46.l16 <- v2224
        v46.l17 <- v2225
        v46.l18 <- v2226
        v46.l19 <- v2227
        v46.l20 <- v2228
        v46.l21 <- v2229
        v46.l22 <- v2230
        v46.l23 <- v2231
        v46.l24 <- v2232
        v46.l25 <- v2233
        v46.l26 <- v2234
        v46.l27 <- v2235
        v46.l28 <- v2236
        v46.l29 <- v2237
        v46.l30 <- v2238
        v46.l31 <- v2239
        v46.l32 <- v2240
        v46.l33 <- v2241
        v46.l34 <- v2242
        v46.l35 <- v2243
        v46.l36 <- v2244
        v46.l37 <- v2245
        v46.l38 <- v2246
        v46.l39 <- v2247
        v46.l40 <- v2248
        v46.l41 <- v2249
        v46.l42 <- v2250
        v46.l43 <- v2251
        v46.l44 <- v2252
        ()
    let struct (v2254 : US0, v2255 : US1, v2256 : US0, v2257 : US0, v2258 : US0, v2259 : US2, v2260 : US3, v2261 : US0, v2262 : US0, v2263 : US2, v2264 : US0, v2265 : US0, v2266 : US2, v2267 : US4, v2268 : US0, v2269 : US0, v2270 : US0, v2271 : US0, v2272 : US5, v2273 : US0, v2274 : US0, v2275 : US0, v2276 : US6, v2277 : US0, v2278 : US0, v2279 : US0, v2280 : US0, v2281 : US7, v2282 : US8, v2283 : US0, v2284 : US0, v2285 : US0, v2286 : US0, v2287 : US0, v2288 : US0, v2289 : US0, v2290 : US0, v2291 : US2, v2292 : US0, v2293 : US0, v2294 : US5, v2295 : US0, v2296 : US0, v2297 : US4) = v46.l1, v46.l2, v46.l3, v46.l4, v46.l5, v46.l6, v46.l7, v46.l8, v46.l9, v46.l10, v46.l11, v46.l12, v46.l13, v46.l14, v46.l15, v46.l16, v46.l17, v46.l18, v46.l19, v46.l20, v46.l21, v46.l22, v46.l23, v46.l24, v46.l25, v46.l26, v46.l27, v46.l28, v46.l29, v46.l30, v46.l31, v46.l32, v46.l33, v46.l34, v46.l35, v46.l36, v46.l37, v46.l38, v46.l39, v46.l40, v46.l41, v46.l42, v46.l43, v46.l44
    let v2298 : Heap0 = {l0 = v2254; l1 = v2255; l2 = v2256; l3 = v2257; l4 = v2258; l5 = v2259; l6 = v2260; l7 = v2261; l8 = v2262; l9 = v2263; l10 = v2264; l11 = v2265; l12 = v2266; l13 = v2267; l14 = v2268; l15 = v2269; l16 = v2270; l17 = v2271; l18 = v2272; l19 = v2273; l20 = v2274; l21 = v2275; l22 = v2276; l23 = v2277; l24 = v2278; l25 = v2279; l26 = v2280; l27 = v2281; l28 = v2282; l29 = v2283; l30 = v2284; l31 = v2285; l32 = v2286; l33 = v2287; l34 = v2288; l35 = v2289; l36 = v2290; l37 = v2291; l38 = v2292; l39 = v2293; l40 = v2294; l41 = v2295; l42 = v2296; l43 = v2297} : Heap0
    v2298
and closure5 () (v0 : (struct (string * obj) [])) : Heap0 =
    method15(v0)
and closure7 (v0 : Heap0, v1 : US0, v2 : US1, v3 : US0, v4 : US0, v5 : US0, v6 : US2, v7 : US3, v8 : US0, v9 : US0, v10 : US2, v11 : US0, v12 : US0, v13 : US2, v14 : US4, v15 : US0, v16 : US0, v17 : US0, v18 : US0, v19 : US5, v20 : US0, v21 : US0, v22 : US0, v23 : US6, v24 : US0, v25 : US0, v26 : US0, v27 : US0, v28 : US7, v29 : US8, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US0, v38 : US2, v39 : US0, v40 : US0, v41 : US5, v42 : US0, v43 : US0, v44 : US4) () : JSX.Element =
    let v45 : US0 = v0.l17
    let v48 : string =
        match v45 with
        | US0_0 -> (* None *)
            let v46 : string = ""
            v46
        | US0_1(v47) -> (* Some *)
            v47
    let v49 : JSX.Element = Html.fragment [ v48 |> unbox<JSX.Element> ]
    let v50 : string = "&nbsp;"
    let v51 : JSX.Element = Html.fragment [ v50 |> unbox<JSX.Element> ]
    let v52 : string = "BiRegularLinkExternal"
    let v53 : string = "solid-icons/bi"
    let v54 : JS.Function = import v52 v53
    let v55 : US1 = US1_1(v54)
    let v56 : Heap0 = {l0 = v1; l1 = v55; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44} : Heap0
    let v57 : (JSX.Prop []) = method2(v56)
    let v58 : obj = createObj v57
    let v59 : string = "createComponent"
    let v60 : string = "solid-js"
    let v61 : JS.Function = import v59 v60
    let v62 : string = "Icon"
    let v63 : string = "@hope-ui/solid"
    let v64 : JSX.Element = v61.Invoke ((import v62 v63), v58) |> unbox<JSX.Element>
    let v65 : (JSX.Element []) = [|v49; v51; v64|]
    let v66 : JSX.Element = v65 |> unbox<JSX.Element>
    v66
and closure6 () (v0 : Heap0) : JSX.Element =
    let struct (v1 : US0, v2 : US1, v3 : US0, v4 : US0, v5 : US0, v6 : US2, v7 : US3, v8 : US0, v9 : US0, v10 : US2, v11 : US0, v12 : US0, v13 : US2, v14 : US4, v15 : US0, v16 : US0, v17 : US0, v18 : US0, v19 : US5, v20 : US0, v21 : US0, v22 : US0, v23 : US6, v24 : US0, v25 : US0, v26 : US0, v27 : US0, v28 : US7, v29 : US8, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US0, v38 : US2, v39 : US0, v40 : US0, v41 : US5, v42 : US0, v43 : US0, v44 : US4) = method0()
    let v45 : (unit -> JSX.Element) = closure7(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44)
    let v46 : US3 = US3_1(v45)
    let v47 : bool = true
    let v48 : US2 = US2_1(v47)
    let v49 : Heap0 = method1(v0, v1, v2, v3, v4, v5, v6, v46, v8, v9, v10, v11, v12, v48, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44)
    let v50 : (JSX.Prop []) = method2(v49)
    let v51 : obj = createObj v50
    let v52 : string = "createComponent"
    let v53 : string = "solid-js"
    let v54 : JS.Function = import v52 v53
    let v55 : string = "Anchor"
    let v56 : string = "@hope-ui/solid"
    let v57 : JSX.Element = v54.Invoke ((import v55 v56), v51) |> unbox<JSX.Element>
    v57
and closure10 (v0 : US0, v1 : US1, v2 : US0, v3 : US0, v4 : US0, v5 : US2, v6 : US3, v7 : US0, v8 : US0, v9 : US2, v10 : US0, v11 : US0, v12 : US2, v13 : US4, v14 : US0, v15 : US0, v16 : US0, v17 : US0, v18 : US5, v19 : US0, v20 : US0, v21 : US0, v22 : US6, v23 : US0, v24 : US0, v25 : US0, v26 : US0, v27 : US7, v28 : US8, v29 : US0, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US2, v38 : US0, v39 : US0, v40 : US5, v41 : US0, v42 : US0, v43 : US4) () : JSX.Element =
    let v44 : (Heap0 -> JSX.Element) = closure6()
    let v45 : string = "https://github.com/fc1943s/tictactoe_spiral"
    let v46 : US0 = US0_1(v45)
    let v47 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v46; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43} : Heap0
    let v48 : JSX.Element = method14(v44, v47)
    let v49 : (JSX.Element []) = [|v48|]
    let v50 : JSX.Element = v49 |> unbox<JSX.Element>
    v50
and method17 (v0 : bool) : struct ((unit -> bool) * (bool -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke v0 |> unbox<JS.Function[]>
    let v5 : (unit -> bool) = v4.[0] |> unbox
    let v6 : (bool -> unit) = v4.[1] |> unbox
    struct (v5, v6)
and closure11 () (v0 : Heap0) : JSX.Element =
    let v1 : (JSX.Prop []) = method2(v0)
    let v2 : obj = createObj v1
    let v3 : string = "createComponent"
    let v4 : string = "solid-js"
    let v5 : JS.Function = import v3 v4
    let v6 : string = "Tr"
    let v7 : string = "@hope-ui/solid"
    let v8 : JSX.Element = v5.Invoke ((import v6 v7), v2) |> unbox<JSX.Element>
    v8
and closure13 () (v0 : Heap0) : JSX.Element =
    let v1 : (JSX.Prop []) = method2(v0)
    let v2 : obj = createObj v1
    let v3 : string = "createComponent"
    let v4 : string = "solid-js"
    let v5 : JS.Function = import v3 v4
    let v6 : string = "Td"
    let v7 : string = "@hope-ui/solid"
    let v8 : JSX.Element = v5.Invoke ((import v6 v7), v2) |> unbox<JSX.Element>
    v8
and closure16 (v0 : JSX.Element) () : JSX.Element =
    let v1 : (JSX.Element []) = [|v0|]
    let v2 : JSX.Element = v1 |> unbox<JSX.Element>
    v2
and closure15 (v0 : US0, v1 : US1, v2 : US0, v3 : US0, v4 : US0, v5 : US2, v6 : US3, v7 : US0, v8 : US0, v9 : US2, v10 : US0, v11 : US0, v12 : US2, v13 : US4, v14 : US0, v15 : US0, v16 : US0, v17 : US0, v18 : US5, v19 : US0, v20 : US0, v21 : US0, v22 : US6, v23 : US0, v24 : US0, v25 : US0, v26 : US0, v27 : US7, v28 : US8, v29 : US0, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US2, v38 : US0, v39 : US0, v40 : US5, v41 : US0, v42 : US0, v43 : US4, v44 : JSX.Element) () : JSX.Element =
    let v45 : (unit -> JSX.Element) = closure16(v44)
    let v46 : US3 = US3_1(v45)
    let v47 : string = "2px"
    let v48 : US0 = US0_1(v47)
    let v49 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v46; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v48; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43} : Heap0
    let v50 : (JSX.Prop []) = method2(v49)
    let v51 : obj = createObj v50
    let v52 : string = "createComponent"
    let v53 : string = "solid-js"
    let v54 : JS.Function = import v52 v53
    let v55 : string = "Box"
    let v56 : string = "@hope-ui/solid"
    let v57 : JSX.Element = v54.Invoke ((import v55 v56), v51) |> unbox<JSX.Element>
    let v58 : (JSX.Element []) = [|v57|]
    let v59 : JSX.Element = v58 |> unbox<JSX.Element>
    v59
and closure17 (v0 : (bool -> unit)) (v1 : obj) : unit =
    let v2 : bool = v1?target?checked
    v0 v2
    ()
and closure14 (v0 : Heap0, v1 : US0, v2 : US1, v3 : US0, v4 : US0, v5 : US0, v6 : US2, v7 : US3, v8 : US0, v9 : US0, v10 : US2, v11 : US0, v12 : US0, v13 : US2, v14 : US4, v15 : US0, v16 : US0, v17 : US0, v18 : US0, v19 : US5, v20 : US0, v21 : US0, v22 : US0, v23 : US6, v24 : US0, v25 : US0, v26 : US0, v27 : US0, v28 : US7, v29 : US8, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US0, v38 : US2, v39 : US0, v40 : US0, v41 : US5, v42 : US0, v43 : US0, v44 : US4, v45 : (bool -> unit), v46 : (unit -> bool), v47 : JSX.Element) () : JSX.Element =
    let v48 : US2 = v0.l37
    let v71 : JSX.Element =
        match v48 with
        | US2_0 -> (* None *)
            v47
        | US2_1(v49) -> (* Some *)
            let v50 : bool = v46 ()
            let v51 : US2 = US2_1(v50)
            let v52 : (unit -> JSX.Element) = closure15(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v47)
            let v53 : US3 = US3_1(v52)
            let v54 : string = "neutral"
            let v55 : US0 = US0_1(v54)
            let v56 : string = "2px"
            let v57 : US0 = US0_1(v56)
            let v58 : (obj -> unit) = closure17(v45)
            let v59 : US7 = US7_1(v58)
            let v60 : string = "sm"
            let v61 : US0 = US0_1(v60)
            let v62 : Heap0 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v51; l6 = v53; l7 = v8; l8 = v55; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v57; l26 = v27; l27 = v59; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v61; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44} : Heap0
            let v63 : (JSX.Prop []) = method2(v62)
            let v64 : obj = createObj v63
            let v65 : string = "createComponent"
            let v66 : string = "solid-js"
            let v67 : JS.Function = import v65 v66
            let v68 : string = "Checkbox"
            let v69 : string = "@hope-ui/solid"
            let v70 : JSX.Element = v67.Invoke ((import v68 v69), v64) |> unbox<JSX.Element>
            v70
    let v72 : (JSX.Element []) = [|v71|]
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    v73
and closure18 () () : JSX.Element =
    let v0 : string = "&nbsp;"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    let v2 : (JSX.Element []) = [|v1|]
    let v3 : JSX.Element = v2 |> unbox<JSX.Element>
    v3
and closure20 (v0 : (unit -> JSX.Element)) () : JSX.Element =
    let v1 : JSX.Element = v0 ()
    let v2 : (JSX.Element []) = [|v1|]
    let v3 : JSX.Element = v2 |> unbox<JSX.Element>
    v3
and closure21 (v0 : JS.Function) (v1 : Mut3) : unit =
    v0.Invoke ("set", v1) |> unbox
    ()
and method18 () : struct (Mut3 * (Mut3 -> unit)) =
    let v0 : string = "useStoreon"
    let v1 : string = "@storeon/solidjs"
    let v2 : JS.Function = import v0 v1
    let v3 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v4 : Mut3 = v3.[0] |> unbox
    let v5 : JS.Function = v3.[1] |> unbox
    let v6 : (Mut3 -> unit) = closure21(v5)
    struct (v4, v6)
and closure22 (v0 : (unit -> bool)) () : (bool []) =
    let v1 : bool = v0 ()
    [|v1|]
and closure23 (v0 : (bool -> unit), v1 : (unit -> bool)) () : unit =
    let v2 : bool = v1 ()
    if v2 then
        v0 false
        ()
and closure24 () (v0 : Heap0) : JSX.Element =
    let v1 : (JSX.Prop []) = method2(v0)
    let v2 : obj = createObj v1
    let v3 : string = "createComponent"
    let v4 : string = "solid-js"
    let v5 : JS.Function = import v3 v4
    let v6 : string = "Box"
    let v7 : string = "@hope-ui/solid"
    let v8 : JSX.Element = v5.Invoke ((import v6 v7), v2) |> unbox<JSX.Element>
    v8
and closure27 () () : JSX.Element =
    let v0 : string = "Load"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    let v2 : (JSX.Element []) = [|v1|]
    let v3 : JSX.Element = v2 |> unbox<JSX.Element>
    v3
and closure28 (v0 : (bool -> unit), v1 : (Mut3 -> unit), v2 : Mut3) () : unit =
    v0 true
    ()
and closure26 (v0 : US0, v1 : US1, v2 : US0, v3 : US0, v4 : US0, v5 : US2, v6 : US3, v7 : US0, v8 : US0, v9 : US2, v10 : US0, v11 : US0, v12 : US2, v13 : US4, v14 : US0, v15 : US0, v16 : US0, v17 : US0, v18 : US5, v19 : US0, v20 : US0, v21 : US0, v22 : US6, v23 : US0, v24 : US0, v25 : US0, v26 : US0, v27 : US7, v28 : US8, v29 : US0, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US2, v38 : US0, v39 : US0, v40 : US5, v41 : US0, v42 : US0, v43 : US4, v44 : (bool -> unit), v45 : (Mut3 -> unit), v46 : Mut3) () : JSX.Element =
    let v47 : (Heap0 -> JSX.Element) = closure0()
    let v48 : (unit -> JSX.Element) = closure27()
    let v49 : US3 = US3_1(v48)
    let v50 : (unit -> unit) = closure28(v44, v45, v46)
    let v51 : US8 = US8_1(v50)
    let v52 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v49; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v51; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43} : Heap0
    let v53 : JSX.Element = method14(v47, v52)
    let v54 : (JSX.Element []) = [|v53|]
    let v55 : JSX.Element = v54 |> unbox<JSX.Element>
    v55
and closure31 () (v0 : Heap0) : JSX.Element =
    let v1 : (JSX.Prop []) = method2(v0)
    let v2 : obj = createObj v1
    let v3 : string = "createComponent"
    let v4 : string = "solid-js"
    let v5 : JS.Function = import v3 v4
    let v6 : string = "Stack"
    let v7 : string = "@hope-ui/solid"
    let v8 : JSX.Element = v5.Invoke ((import v6 v7), v2) |> unbox<JSX.Element>
    v8
and method19 (v0 : JS.Function, v1 : Heap0) : JSX.Element =
    let v2 : JS.Function = v0 |> unbox<JS.Function>
    let v3 : string = "createComponent"
    let v4 : string = "solid-js"
    let v5 : JS.Function = import v3 v4
    let v6 : JSX.Element = v5.Invoke (v2, v1) |> unbox<JSX.Element>
    v6
and closure33 (v0 : (bool -> unit)) () : unit =
    v0 true
    ()
and closure34 (v0 : (Mut3 -> unit), v1 : Mut3, v2 : int32, v3 : (bool -> unit), v4 : (unit -> bool)) () : unit =
    let v5 : bool = v4 ()
    let v6 : bool = v5 = false
    v3 v6
    let v7 : int32 =
        if v6 then
            v2
        else
            0
    v1.l0 <- v7
    let v8 : string = "new_state"
    printfn $"%A{v8}"
    v0 v1
    ()
and closure35 (v0 : (bool -> unit)) () : unit =
    v0 false
    ()
and closure32 (v0 : US0, v1 : US1, v2 : US0, v3 : US0, v4 : US0, v5 : US2, v6 : US3, v7 : US0, v8 : US0, v9 : US2, v10 : US0, v11 : US0, v12 : US2, v13 : US4, v14 : US0, v15 : US0, v16 : US0, v17 : US0, v18 : US5, v19 : US0, v20 : US0, v21 : US0, v22 : US6, v23 : US0, v24 : US0, v25 : US0, v26 : US0, v27 : US7, v28 : US8, v29 : US0, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US2, v38 : US0, v39 : US0, v40 : US5, v41 : US0, v42 : US0, v43 : US4, v44 : (Mut3 -> unit), v45 : Mut3, v46 : int32, v47 : (bool -> unit), v48 : (bool -> unit), v49 : (bool -> unit), v50 : (unit -> bool)) () : JSX.Element =
    let v51 : string = "BiRegularRefresh"
    let v52 : string = "solid-icons/bi"
    let v53 : JS.Function = import v51 v52
    let v54 : string = "14px"
    let v55 : US0 = US0_1(v54)
    let v56 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v55; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43} : Heap0
    let v57 : JSX.Element = method19(v53, v56)
    let v58 : string = "Refresh"
    let v59 : US0 = US0_1(v58)
    let v60 : string = "neutral"
    let v61 : US0 = US0_1(v60)
    let v62 : string = "20px"
    let v63 : US0 = US0_1(v62)
    let v64 : US5 = US5_1(v57)
    let v65 : (unit -> unit) = closure33(v48)
    let v66 : US8 = US8_1(v65)
    let v67 : string = "xs"
    let v68 : US0 = US0_1(v67)
    let v69 : Heap0 = {l0 = v59; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v61; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v63; l17 = v17; l18 = v64; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v66; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v68; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43} : Heap0
    let v70 : (JSX.Prop []) = method2(v69)
    let v71 : obj = createObj v70
    let v72 : string = "createComponent"
    let v73 : string = "solid-js"
    let v74 : JS.Function = import v72 v73
    let v75 : string = "IconButton"
    let v76 : string = "@hope-ui/solid"
    let v77 : JSX.Element = v74.Invoke ((import v75 v76), v71) |> unbox<JSX.Element>
    let v78 : bool = v50 ()
    let v81 : string =
        if v78 then
            let v79 : string = "Restore"
            v79
        else
            let v80 : string = "Maximize"
            v80
    let v82 : bool = v50 ()
    let v87 : JS.Function =
        if v82 then
            let v83 : string = "BiRegularDownArrow"
            let v84 : JS.Function = import v83 v52
            v84
        else
            let v85 : string = "BiRegularUpArrow"
            let v86 : JS.Function = import v85 v52
            v86
    let v88 : US0 = US0_1(v54)
    let v89 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v88; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43} : Heap0
    let v90 : JSX.Element = method19(v87, v89)
    let v91 : US0 = US0_1(v81)
    let v92 : US0 = US0_1(v60)
    let v93 : US0 = US0_1(v62)
    let v94 : US5 = US5_1(v90)
    let v95 : (unit -> unit) = closure34(v44, v45, v46, v49, v50)
    let v96 : US8 = US8_1(v95)
    let v97 : US0 = US0_1(v67)
    let v98 : Heap0 = {l0 = v91; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v92; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v93; l17 = v17; l18 = v94; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v96; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v97; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43} : Heap0
    let v99 : (JSX.Prop []) = method2(v98)
    let v100 : obj = createObj v99
    let v101 : JS.Function = import v72 v73
    let v102 : JSX.Element = v101.Invoke ((import v75 v76), v100) |> unbox<JSX.Element>
    let v103 : string = "BiRegularUndo"
    let v104 : JS.Function = import v103 v52
    let v105 : US0 = US0_1(v54)
    let v106 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v105; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43} : Heap0
    let v107 : JSX.Element = method19(v104, v106)
    let v108 : string = "Unload"
    let v109 : US0 = US0_1(v108)
    let v110 : US0 = US0_1(v60)
    let v111 : US0 = US0_1(v62)
    let v112 : US5 = US5_1(v107)
    let v113 : (unit -> unit) = closure35(v47)
    let v114 : US8 = US8_1(v113)
    let v115 : US0 = US0_1(v67)
    let v116 : Heap0 = {l0 = v109; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v110; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v111; l17 = v17; l18 = v112; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v114; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v115; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43} : Heap0
    let v117 : (JSX.Prop []) = method2(v116)
    let v118 : obj = createObj v117
    let v119 : JS.Function = import v72 v73
    let v120 : JSX.Element = v119.Invoke ((import v75 v76), v118) |> unbox<JSX.Element>
    let v121 : (JSX.Element []) = [|v77; v102; v120|]
    let v122 : JSX.Element = v121 |> unbox<JSX.Element>
    v122
and closure30 (v0 : US0, v1 : US1, v2 : US0, v3 : US0, v4 : US0, v5 : US2, v6 : US3, v7 : US0, v8 : US0, v9 : US2, v10 : US0, v11 : US0, v12 : US2, v13 : US4, v14 : US0, v15 : US0, v16 : US0, v17 : US0, v18 : US5, v19 : US0, v20 : US0, v21 : US0, v22 : US6, v23 : US0, v24 : US0, v25 : US0, v26 : US0, v27 : US7, v28 : US8, v29 : US0, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US2, v38 : US0, v39 : US0, v40 : US5, v41 : US0, v42 : US0, v43 : US4, v44 : (Mut3 -> unit), v45 : Mut3, v46 : int32, v47 : (bool -> unit), v48 : (bool -> unit), v49 : (unit -> bool), v50 : (bool -> unit), v51 : (unit -> bool), v52 : (unit -> JSX.Element)) () : JSX.Element =
    let v53 : (Heap0 -> JSX.Element) = closure31()
    let v54 : int32 = v45.l0
    let v55 : bool = v54 = v46
    let v59 : US0 =
        if v55 then
            let v56 : string = "none"
            US0_1(v56)
        else
            US0_0
    let v60 : (unit -> JSX.Element) = closure32(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v50, v51)
    let v61 : US3 = US3_1(v60)
    let v62 : string = "row"
    let v63 : US0 = US0_1(v62)
    let v64 : string = "absolute"
    let v65 : US0 = US0_1(v64)
    let v66 : string = "6px"
    let v67 : US0 = US0_1(v66)
    let v68 : string = "3px"
    let v69 : US0 = US0_1(v68)
    let v70 : US0 = US0_1(v66)
    let v71 : US4 = US4_1(1)
    let v72 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v61; l7 = v7; l8 = v8; l9 = v9; l10 = v63; l11 = v59; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v65; l34 = v67; l35 = v35; l36 = v69; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v70; l42 = v42; l43 = v71} : Heap0
    let v73 : JSX.Element = method14(v53, v72)
    let v74 : bool = v49 ()
    let v75 : bool = v74 = false
    let v78 : JSX.Element =
        if v75 then
            let v76 : JSX.Element = v52 ()
            v76
        else
            let v77 : JSX.Element = Html.fragment []
            v77
    let v79 : (JSX.Element []) = [|v73; v78|]
    let v80 : JSX.Element = v79 |> unbox<JSX.Element>
    v80
and closure29 (v0 : Heap0, v1 : US0, v2 : US1, v3 : US0, v4 : US0, v5 : US0, v6 : US2, v7 : US3, v8 : US0, v9 : US0, v10 : US2, v11 : US0, v12 : US0, v13 : US2, v14 : US4, v15 : US0, v16 : US0, v17 : US0, v18 : US0, v19 : US5, v20 : US0, v21 : US0, v22 : US0, v23 : US6, v24 : US0, v25 : US0, v26 : US0, v27 : US0, v28 : US7, v29 : US8, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US0, v38 : US2, v39 : US0, v40 : US0, v41 : US5, v42 : US0, v43 : US0, v44 : US4, v45 : (Mut3 -> unit), v46 : Mut3, v47 : int32, v48 : (bool -> unit), v49 : (bool -> unit), v50 : (unit -> bool), v51 : (bool -> unit), v52 : (unit -> bool)) () : JSX.Element =
    let v53 : US3 = v0.l6
    let v70 : JSX.Element =
        match v53 with
        | US3_0 -> (* None *)
            let v54 : JSX.Element = Html.fragment []
            v54
        | US3_1(v55) -> (* Some *)
            let v56 : (Heap0 -> JSX.Element) = closure24()
            let v57 : int32 = v46.l0
            let v58 : bool = v57 <= 0
            let v62 : US0 =
                if v58 then
                    let v59 : string = "relative"
                    US0_1(v59)
                else
                    US0_0
            let v63 : (unit -> JSX.Element) = closure30(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v55)
            let v64 : US3 = US3_1(v63)
            let v65 : string = "flex"
            let v66 : US0 = US0_1(v65)
            let v67 : US4 = US4_1(1)
            let v68 : Heap0 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v64; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v66; l12 = v13; l13 = v67; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v62; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44} : Heap0
            method14(v56, v68)
    let v71 : (JSX.Element []) = [|v70|]
    let v72 : JSX.Element = v71 |> unbox<JSX.Element>
    v72
and closure25 (v0 : Heap0, v1 : US0, v2 : US1, v3 : US0, v4 : US0, v5 : US0, v6 : US2, v7 : US3, v8 : US0, v9 : US0, v10 : US2, v11 : US0, v12 : US0, v13 : US2, v14 : US4, v15 : US0, v16 : US0, v17 : US0, v18 : US0, v19 : US5, v20 : US0, v21 : US0, v22 : US0, v23 : US6, v24 : US0, v25 : US0, v26 : US0, v27 : US0, v28 : US7, v29 : US8, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US0, v38 : US2, v39 : US0, v40 : US0, v41 : US5, v42 : US0, v43 : US0, v44 : US4, v45 : (Mut3 -> unit), v46 : Mut3, v47 : int32, v48 : (bool -> unit), v49 : (unit -> bool), v50 : (bool -> unit), v51 : (unit -> bool), v52 : (bool -> unit), v53 : (unit -> bool)) () : JSX.Element =
    let v54 : bool = v49 ()
    let v55 : bool = v54 = false
    let v103 : JSX.Element =
        if v55 then
            let v56 : (Heap0 -> JSX.Element) = closure24()
            let v57 : (unit -> JSX.Element) = closure26(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v48, v45, v46)
            let v58 : US3 = US3_1(v57)
            let v59 : Heap0 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v58; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44} : Heap0
            method14(v56, v59)
        else
            let v61 : (Heap0 -> JSX.Element) = closure24()
            let v62 : bool = v53 ()
            let v65 : US4 =
                if v62 then
                    US4_1(1)
                else
                    US4_0
            let v66 : bool = v53 ()
            let v70 : US0 =
                if v66 then
                    let v67 : string = "absolute"
                    US0_1(v67)
                else
                    US0_0
            let v71 : bool = v53 ()
            let v75 : US0 =
                if v71 then
                    let v72 : string = "0"
                    US0_1(v72)
                else
                    US0_0
            let v76 : bool = v53 ()
            let v80 : US0 =
                if v76 then
                    let v77 : string = "0"
                    US0_1(v77)
                else
                    US0_0
            let v81 : bool = v53 ()
            let v85 : US0 =
                if v81 then
                    let v82 : string = "0"
                    US0_1(v82)
                else
                    US0_0
            let v86 : bool = v53 ()
            let v90 : US0 =
                if v86 then
                    let v87 : string = "0"
                    US0_1(v87)
                else
                    US0_0
            let v91 : bool = v53 ()
            let v95 : US0 =
                if v91 then
                    let v92 : string = "$bg"
                    US0_1(v92)
                else
                    US0_0
            let v96 : (unit -> JSX.Element) = closure29(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v50, v51, v52, v53)
            let v97 : US3 = US3_1(v96)
            let v98 : string = "flex"
            let v99 : US0 = US0_1(v98)
            let v100 : US4 = US4_1(1)
            let v101 : Heap0 = {l0 = v1; l1 = v2; l2 = v95; l3 = v4; l4 = v85; l5 = v6; l6 = v97; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v99; l12 = v13; l13 = v100; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v90; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v70; l34 = v80; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v75; l42 = v43; l43 = v65} : Heap0
            method14(v61, v101)
    let v104 : (JSX.Element []) = [|v103|]
    let v105 : JSX.Element = v104 |> unbox<JSX.Element>
    v105
and closure19 (v0 : Heap0, v1 : US0, v2 : US1, v3 : US0, v4 : US0, v5 : US0, v6 : US2, v7 : US3, v8 : US0, v9 : US0, v10 : US2, v11 : US0, v12 : US0, v13 : US2, v14 : US4, v15 : US0, v16 : US0, v17 : US0, v18 : US0, v19 : US5, v20 : US0, v21 : US0, v22 : US0, v23 : US6, v24 : US0, v25 : US0, v26 : US0, v27 : US0, v28 : US7, v29 : US8, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US0, v38 : US2, v39 : US0, v40 : US0, v41 : US5, v42 : US0, v43 : US0, v44 : US4, v45 : (unit -> bool), v46 : (unit -> JSX.Element)) () : JSX.Element =
    let v47 : US2 = v0.l37
    let v129 : JSX.Element =
        match v47 with
        | US2_0 -> (* None *)
            let v48 : JSX.Element = v46 ()
            v48
        | US2_1(v49) -> (* Some *)
            let v50 : bool = v45 ()
            if v50 then
                let v51 : (unit -> JSX.Element) = closure20(v46)
                let v52 : US3 = US3_1(v51)
                let v53 : Heap0 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v52; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44} : Heap0
                let struct (v54 : US0, v55 : US1, v56 : US0, v57 : US0, v58 : US0, v59 : US2, v60 : US3, v61 : US0, v62 : US0, v63 : US2, v64 : US0, v65 : US0, v66 : US2, v67 : US4, v68 : US0, v69 : US0, v70 : US0, v71 : US0, v72 : US5, v73 : US0, v74 : US0, v75 : US0, v76 : US6, v77 : US0, v78 : US0, v79 : US0, v80 : US0, v81 : US7, v82 : US8, v83 : US0, v84 : US0, v85 : US0, v86 : US0, v87 : US0, v88 : US0, v89 : US0, v90 : US0, v91 : US2, v92 : US0, v93 : US0, v94 : US5, v95 : US0, v96 : US0, v97 : US4) = method0()
                let struct (v98 : Mut3, v99 : (Mut3 -> unit)) = method18()
                let v100 : int32 = Random().Next()
                let v101 : bool = true
                let struct (v102 : (unit -> bool), v103 : (bool -> unit)) = method17(v101)
                let v104 : bool = false
                let struct (v105 : (unit -> bool), v106 : (bool -> unit)) = method17(v104)
                let v107 : bool = false
                let struct (v108 : (unit -> bool), v109 : (bool -> unit)) = method17(v107)
                let v110 : string = "on"
                let v111 : string = "solid-js"
                let v112 : JS.Function = import v110 v111
                let v113 : (unit -> (bool [])) = closure22(v105)
                let v114 : (unit -> unit) = closure23(v106, v105)
                let v115 : JS.Function = v112.Invoke (v113, v114) |> unbox<JS.Function>
                let v116 : string = "createEffect"
                let v117 : JS.Function = import v116 v111
                v117.Invoke v115 |> ignore
                let v118 : (Heap0 -> JSX.Element) = closure24()
                let v119 : US0 = v53.l19
                let v120 : (unit -> JSX.Element) = closure25(v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v99, v98, v100, v103, v102, v106, v105, v109, v108)
                let v121 : US3 = US3_1(v120)
                let v122 : string = "flex"
                let v123 : US0 = US0_1(v122)
                let v124 : US4 = US4_1(1)
                let v125 : Heap0 = {l0 = v54; l1 = v55; l2 = v56; l3 = v57; l4 = v58; l5 = v59; l6 = v121; l7 = v61; l8 = v62; l9 = v63; l10 = v64; l11 = v123; l12 = v66; l13 = v124; l14 = v68; l15 = v69; l16 = v70; l17 = v71; l18 = v72; l19 = v119; l20 = v74; l21 = v75; l22 = v76; l23 = v77; l24 = v78; l25 = v79; l26 = v80; l27 = v81; l28 = v82; l29 = v83; l30 = v84; l31 = v85; l32 = v86; l33 = v87; l34 = v88; l35 = v89; l36 = v90; l37 = v91; l38 = v92; l39 = v93; l40 = v94; l41 = v95; l42 = v96; l43 = v97} : Heap0
                method14(v118, v125)
            else
                let v127 : JSX.Element = Html.fragment []
                v127
    let v130 : (JSX.Element []) = [|v129|]
    let v131 : JSX.Element = v130 |> unbox<JSX.Element>
    v131
and closure12 (v0 : Heap0, v1 : US0, v2 : US1, v3 : US0, v4 : US0, v5 : US0, v6 : US2, v7 : US3, v8 : US0, v9 : US0, v10 : US2, v11 : US0, v12 : US0, v13 : US2, v14 : US4, v15 : US0, v16 : US0, v17 : US0, v18 : US0, v19 : US5, v20 : US0, v21 : US0, v22 : US0, v23 : US6, v24 : US0, v25 : US0, v26 : US0, v27 : US0, v28 : US7, v29 : US8, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US0, v38 : US2, v39 : US0, v40 : US0, v41 : US5, v42 : US0, v43 : US0, v44 : US4, v45 : (bool -> unit), v46 : (unit -> bool)) () : JSX.Element =
    let v47 : US5 = v0.l40
    let v69 : JSX.Element =
        match v47 with
        | US5_0 -> (* None *)
            let v48 : JSX.Element = Html.fragment []
            v48
        | US5_1(v49) -> (* Some *)
            let v50 : (Heap0 -> JSX.Element) = closure13()
            let v51 : string = "0 !important"
            let v52 : US0 = US0_1(v51)
            let v53 : (unit -> JSX.Element) = closure14(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v49)
            let v54 : US3 = US3_1(v53)
            let v55 : string = "$neutral9"
            let v56 : US0 = US0_1(v55)
            let v57 : string = "flex"
            let v58 : US0 = US0_1(v57)
            let v59 : string = "column"
            let v60 : US0 = US0_1(v59)
            let v61 : string = "$sm"
            let v62 : US0 = US0_1(v61)
            let v63 : string = "1px solid $neutral5"
            let v64 : US0 = US0_1(v63)
            let v65 : string = "3px 20px 0 8px"
            let v66 : US0 = US0_1(v65)
            let v67 : Heap0 = {l0 = v1; l1 = v2; l2 = v3; l3 = v52; l4 = v5; l5 = v6; l6 = v54; l7 = v56; l8 = v9; l9 = v10; l10 = v11; l11 = v58; l12 = v13; l13 = v14; l14 = v60; l15 = v62; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v64; l30 = v31; l31 = v66; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44} : Heap0
            method14(v50, v67)
    let v70 : US3 = v0.l6
    let v107 : JSX.Element =
        match v70 with
        | US3_0 -> (* None *)
            let v71 : (Heap0 -> JSX.Element) = closure13()
            let v72 : (unit -> JSX.Element) = closure18()
            let v73 : US3 = US3_1(v72)
            let v74 : string = "9px"
            let v75 : US0 = US0_1(v74)
            let v76 : string = "0"
            let v77 : US0 = US0_1(v76)
            let v78 : Heap0 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v73; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v75; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v77; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44} : Heap0
            method14(v71, v78)
        | US3_1(v80) -> (* Some *)
            let v81 : (Heap0 -> JSX.Element) = closure13()
            let v82 : US0 = v0.l31
            let v85 : string =
                match v82 with
                | US0_0 -> (* None *)
                    let v83 : string = "0"
                    v83
                | US0_1(v84) -> (* Some *)
                    v84
            let v86 : string = "0 !important"
            let v87 : US0 = US0_1(v86)
            let v88 : (unit -> JSX.Element) = closure19(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v46, v80)
            let v89 : US3 = US3_1(v88)
            let v90 : string = "flex"
            let v91 : US0 = US0_1(v90)
            let v92 : US4 = US4_1(6)
            let v93 : string = "column"
            let v94 : US0 = US0_1(v93)
            let v95 : string = "$sm"
            let v96 : US0 = US0_1(v95)
            let v97 : string = "0"
            let v98 : US0 = US0_1(v97)
            let v99 : string = "85vh"
            let v100 : US0 = US0_1(v99)
            let v101 : US0 = US0_1(v97)
            let v102 : string = "auto"
            let v103 : US0 = US0_1(v102)
            let v104 : US0 = US0_1(v85)
            let v105 : Heap0 = {l0 = v1; l1 = v2; l2 = v3; l3 = v87; l4 = v5; l5 = v6; l6 = v89; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v91; l12 = v13; l13 = v92; l14 = v94; l15 = v96; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v98; l25 = v26; l26 = v100; l27 = v28; l28 = v29; l29 = v101; l30 = v103; l31 = v104; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44} : Heap0
            method14(v81, v105)
    let v108 : (JSX.Element []) = [|v69; v107|]
    let v109 : JSX.Element = v108 |> unbox<JSX.Element>
    v109
and closure36 (v0 : US0, v1 : US1, v2 : US0, v3 : US0, v4 : US0, v5 : US2, v6 : US3, v7 : US0, v8 : US0, v9 : US2, v10 : US0, v11 : US0, v12 : US2, v13 : US4, v14 : US0, v15 : US0, v16 : US0, v17 : US0, v18 : US5, v19 : US0, v20 : US0, v21 : US0, v22 : US6, v23 : US0, v24 : US0, v25 : US0, v26 : US0, v27 : US7, v28 : US8, v29 : US0, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US2, v38 : US0, v39 : US0, v40 : US5, v41 : US0, v42 : US0, v43 : US4) () : JSX.Element =
    let v44 : (Heap0 -> JSX.Element) = closure6()
    let v45 : string = "https://fc1943s.github.io/tictactoe_spiral"
    let v46 : US0 = US0_1(v45)
    let v47 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v46; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43} : Heap0
    let v48 : JSX.Element = method14(v44, v47)
    let v49 : (JSX.Element []) = [|v48|]
    let v50 : JSX.Element = v49 |> unbox<JSX.Element>
    v50
and closure37 (v0 : US0, v1 : US1, v2 : US0, v3 : US0, v4 : US0, v5 : US2, v6 : US3, v7 : US0, v8 : US0, v9 : US2, v10 : US0, v11 : US0, v12 : US2, v13 : US4, v14 : US0, v15 : US0, v16 : US0, v17 : US0, v18 : US5, v19 : US0, v20 : US0, v21 : US0, v22 : US6, v23 : US0, v24 : US0, v25 : US0, v26 : US0, v27 : US7, v28 : US8, v29 : US0, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US2, v38 : US0, v39 : US0, v40 : US5, v41 : US0, v42 : US0, v43 : US4) () : JSX.Element =
    let v44 : (Heap0 -> JSX.Element) = closure6()
    let v45 : string = "https://fc1943s.github.io/tictactoe_spiral/docs"
    let v46 : US0 = US0_1(v45)
    let v47 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v46; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43} : Heap0
    let v48 : JSX.Element = method14(v44, v47)
    let v49 : (JSX.Element []) = [|v48|]
    let v50 : JSX.Element = v49 |> unbox<JSX.Element>
    v50
and closure9 (v0 : US0, v1 : US1, v2 : US0, v3 : US0, v4 : US0, v5 : US2, v6 : US3, v7 : US0, v8 : US0, v9 : US2, v10 : US0, v11 : US0, v12 : US2, v13 : US4, v14 : US0, v15 : US0, v16 : US0, v17 : US0, v18 : US5, v19 : US0, v20 : US0, v21 : US0, v22 : US6, v23 : US0, v24 : US0, v25 : US0, v26 : US0, v27 : US7, v28 : US8, v29 : US0, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US2, v38 : US0, v39 : US0, v40 : US5, v41 : US0, v42 : US0, v43 : US4) () : JSX.Element =
    let v44 : (unit -> JSX.Element) = closure10(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43)
    let v45 : US3 = US3_1(v44)
    let v46 : string = "1px 6px"
    let v47 : US0 = US0_1(v46)
    let v48 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v45; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v47; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43} : Heap0
    let struct (v49 : US0, v50 : US1, v51 : US0, v52 : US0, v53 : US0, v54 : US2, v55 : US3, v56 : US0, v57 : US0, v58 : US2, v59 : US0, v60 : US0, v61 : US2, v62 : US4, v63 : US0, v64 : US0, v65 : US0, v66 : US0, v67 : US5, v68 : US0, v69 : US0, v70 : US0, v71 : US6, v72 : US0, v73 : US0, v74 : US0, v75 : US0, v76 : US7, v77 : US8, v78 : US0, v79 : US0, v80 : US0, v81 : US0, v82 : US0, v83 : US0, v84 : US0, v85 : US0, v86 : US2, v87 : US0, v88 : US0, v89 : US5, v90 : US0, v91 : US0, v92 : US4) = method0()
    let v93 : US2 = v48.l37
    let v97 : bool =
        match v93 with
        | US2_1(v95) -> (* Some *)
            let v96 : bool = v95 = false
            v96
        | _ ->
            false
    let v98 : bool = v97 <> true
    let struct (v99 : (unit -> bool), v100 : (bool -> unit)) = method17(v98)
    let v101 : (Heap0 -> JSX.Element) = closure11()
    let v102 : US0 = v48.l19
    let v103 : string = {| ``@initial`` = "column"; ``@sm`` = "row" |} |> unbox<string>
    let v104 : string = "1px solid $neutral5"
    let v105 : US0 = US0_1(v104)
    let v106 : (unit -> JSX.Element) = closure12(v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v100, v99)
    let v107 : US3 = US3_1(v106)
    let v108 : string = "flex"
    let v109 : US0 = US0_1(v108)
    let v110 : US4 = US4_1(1)
    let v111 : US0 = US0_1(v103)
    let v112 : Heap0 = {l0 = v49; l1 = v50; l2 = v51; l3 = v105; l4 = v53; l5 = v54; l6 = v107; l7 = v56; l8 = v57; l9 = v58; l10 = v59; l11 = v109; l12 = v61; l13 = v110; l14 = v111; l15 = v64; l16 = v65; l17 = v66; l18 = v67; l19 = v102; l20 = v69; l21 = v70; l22 = v71; l23 = v72; l24 = v73; l25 = v74; l26 = v75; l27 = v76; l28 = v77; l29 = v78; l30 = v79; l31 = v80; l32 = v81; l33 = v82; l34 = v83; l35 = v84; l36 = v85; l37 = v86; l38 = v87; l39 = v88; l40 = v89; l41 = v90; l42 = v91; l43 = v92} : Heap0
    let v113 : JSX.Element = method14(v101, v112)
    let v114 : (unit -> JSX.Element) = closure36(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43)
    let v115 : US3 = US3_1(v114)
    let v116 : US0 = US0_1(v46)
    let v117 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v115; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v116; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43} : Heap0
    let struct (v118 : US0, v119 : US1, v120 : US0, v121 : US0, v122 : US0, v123 : US2, v124 : US3, v125 : US0, v126 : US0, v127 : US2, v128 : US0, v129 : US0, v130 : US2, v131 : US4, v132 : US0, v133 : US0, v134 : US0, v135 : US0, v136 : US5, v137 : US0, v138 : US0, v139 : US0, v140 : US6, v141 : US0, v142 : US0, v143 : US0, v144 : US0, v145 : US7, v146 : US8, v147 : US0, v148 : US0, v149 : US0, v150 : US0, v151 : US0, v152 : US0, v153 : US0, v154 : US0, v155 : US2, v156 : US0, v157 : US0, v158 : US5, v159 : US0, v160 : US0, v161 : US4) = method0()
    let v162 : US2 = v117.l37
    let v166 : bool =
        match v162 with
        | US2_1(v164) -> (* Some *)
            let v165 : bool = v164 = false
            v165
        | _ ->
            false
    let v167 : bool = v166 <> true
    let struct (v168 : (unit -> bool), v169 : (bool -> unit)) = method17(v167)
    let v170 : US0 = v117.l19
    let v171 : string = {| ``@initial`` = "column"; ``@sm`` = "row" |} |> unbox<string>
    let v172 : US0 = US0_1(v104)
    let v173 : (unit -> JSX.Element) = closure12(v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, v169, v168)
    let v174 : US3 = US3_1(v173)
    let v175 : US0 = US0_1(v108)
    let v176 : US4 = US4_1(1)
    let v177 : US0 = US0_1(v171)
    let v178 : Heap0 = {l0 = v118; l1 = v119; l2 = v120; l3 = v172; l4 = v122; l5 = v123; l6 = v174; l7 = v125; l8 = v126; l9 = v127; l10 = v128; l11 = v175; l12 = v130; l13 = v176; l14 = v177; l15 = v133; l16 = v134; l17 = v135; l18 = v136; l19 = v170; l20 = v138; l21 = v139; l22 = v140; l23 = v141; l24 = v142; l25 = v143; l26 = v144; l27 = v145; l28 = v146; l29 = v147; l30 = v148; l31 = v149; l32 = v150; l33 = v151; l34 = v152; l35 = v153; l36 = v154; l37 = v155; l38 = v156; l39 = v157; l40 = v158; l41 = v159; l42 = v160; l43 = v161} : Heap0
    let v179 : JSX.Element = method14(v101, v178)
    let v180 : (unit -> JSX.Element) = closure37(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43)
    let v181 : US3 = US3_1(v180)
    let v182 : US0 = US0_1(v46)
    let v183 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v181; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v182; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43} : Heap0
    let struct (v184 : US0, v185 : US1, v186 : US0, v187 : US0, v188 : US0, v189 : US2, v190 : US3, v191 : US0, v192 : US0, v193 : US2, v194 : US0, v195 : US0, v196 : US2, v197 : US4, v198 : US0, v199 : US0, v200 : US0, v201 : US0, v202 : US5, v203 : US0, v204 : US0, v205 : US0, v206 : US6, v207 : US0, v208 : US0, v209 : US0, v210 : US0, v211 : US7, v212 : US8, v213 : US0, v214 : US0, v215 : US0, v216 : US0, v217 : US0, v218 : US0, v219 : US0, v220 : US0, v221 : US2, v222 : US0, v223 : US0, v224 : US5, v225 : US0, v226 : US0, v227 : US4) = method0()
    let v228 : US2 = v183.l37
    let v232 : bool =
        match v228 with
        | US2_1(v230) -> (* Some *)
            let v231 : bool = v230 = false
            v231
        | _ ->
            false
    let v233 : bool = v232 <> true
    let struct (v234 : (unit -> bool), v235 : (bool -> unit)) = method17(v233)
    let v236 : US0 = v183.l19
    let v237 : string = {| ``@initial`` = "column"; ``@sm`` = "row" |} |> unbox<string>
    let v238 : US0 = US0_1(v104)
    let v239 : (unit -> JSX.Element) = closure12(v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v220, v221, v222, v223, v224, v225, v226, v227, v235, v234)
    let v240 : US3 = US3_1(v239)
    let v241 : US0 = US0_1(v108)
    let v242 : US4 = US4_1(1)
    let v243 : US0 = US0_1(v237)
    let v244 : Heap0 = {l0 = v184; l1 = v185; l2 = v186; l3 = v238; l4 = v188; l5 = v189; l6 = v240; l7 = v191; l8 = v192; l9 = v193; l10 = v194; l11 = v241; l12 = v196; l13 = v242; l14 = v243; l15 = v199; l16 = v200; l17 = v201; l18 = v202; l19 = v236; l20 = v204; l21 = v205; l22 = v206; l23 = v207; l24 = v208; l25 = v209; l26 = v210; l27 = v211; l28 = v212; l29 = v213; l30 = v214; l31 = v215; l32 = v216; l33 = v217; l34 = v218; l35 = v219; l36 = v220; l37 = v221; l38 = v222; l39 = v223; l40 = v224; l41 = v225; l42 = v226; l43 = v227} : Heap0
    let v245 : JSX.Element = method14(v101, v244)
    let v246 : (JSX.Element []) = [|v113; v179; v245|]
    let v247 : JSX.Element = v246 |> unbox<JSX.Element>
    v247
and closure8 () () : JSX.Element =
    let struct (v0 : US0, v1 : US1, v2 : US0, v3 : US0, v4 : US0, v5 : US2, v6 : US3, v7 : US0, v8 : US0, v9 : US2, v10 : US0, v11 : US0, v12 : US2, v13 : US4, v14 : US0, v15 : US0, v16 : US0, v17 : US0, v18 : US5, v19 : US0, v20 : US0, v21 : US0, v22 : US6, v23 : US0, v24 : US0, v25 : US0, v26 : US0, v27 : US7, v28 : US8, v29 : US0, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US2, v38 : US0, v39 : US0, v40 : US5, v41 : US0, v42 : US0, v43 : US4) = method0()
    let v44 : (Heap0 -> JSX.Element) = closure1()
    let v45 : (unit -> JSX.Element) = closure9(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43)
    let v46 : US3 = US3_1(v45)
    let v47 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v46; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43} : Heap0
    method14(v44, v47)
and closure41 (v0 : (bool -> unit), v1 : US10, v2 : (Mut3 -> unit), v3 : Mut3) () : unit =
    match v1 with
    | US10_0 -> (* None *)
        ()
    | US10_1(v4) -> (* Some *)
        let v5 : ((Mut3 -> unit) -> unit) = v4 v3
        v5 v2
        ()
    v0 true
    ()
and closure40 (v0 : US0, v1 : US1, v2 : US0, v3 : US0, v4 : US0, v5 : US2, v6 : US3, v7 : US0, v8 : US0, v9 : US2, v10 : US0, v11 : US0, v12 : US2, v13 : US4, v14 : US0, v15 : US0, v16 : US0, v17 : US0, v18 : US5, v19 : US0, v20 : US0, v21 : US0, v22 : US6, v23 : US0, v24 : US0, v25 : US0, v26 : US0, v27 : US7, v28 : US8, v29 : US0, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US2, v38 : US0, v39 : US0, v40 : US5, v41 : US0, v42 : US0, v43 : US4, v44 : (bool -> unit), v45 : US10, v46 : (Mut3 -> unit), v47 : Mut3) () : JSX.Element =
    let v48 : (Heap0 -> JSX.Element) = closure0()
    let v49 : (unit -> JSX.Element) = closure27()
    let v50 : US3 = US3_1(v49)
    let v51 : (unit -> unit) = closure41(v44, v45, v46, v47)
    let v52 : US8 = US8_1(v51)
    let v53 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v50; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v52; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43} : Heap0
    let v54 : JSX.Element = method14(v48, v53)
    let v55 : (JSX.Element []) = [|v54|]
    let v56 : JSX.Element = v55 |> unbox<JSX.Element>
    v56
and closure39 (v0 : Heap0, v1 : US0, v2 : US1, v3 : US0, v4 : US0, v5 : US0, v6 : US2, v7 : US3, v8 : US0, v9 : US0, v10 : US2, v11 : US0, v12 : US0, v13 : US2, v14 : US4, v15 : US0, v16 : US0, v17 : US0, v18 : US0, v19 : US5, v20 : US0, v21 : US0, v22 : US0, v23 : US6, v24 : US0, v25 : US0, v26 : US0, v27 : US0, v28 : US7, v29 : US8, v30 : US0, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US0, v38 : US2, v39 : US0, v40 : US0, v41 : US5, v42 : US0, v43 : US0, v44 : US4, v45 : (Mut3 -> unit), v46 : Mut3, v47 : int32, v48 : (bool -> unit), v49 : (unit -> bool), v50 : (bool -> unit), v51 : (unit -> bool), v52 : (bool -> unit), v53 : (unit -> bool), v54 : US10) () : JSX.Element =
    let v55 : bool = v49 ()
    let v56 : bool = v55 = false
    let v104 : JSX.Element =
        if v56 then
            let v57 : (Heap0 -> JSX.Element) = closure24()
            let v58 : (unit -> JSX.Element) = closure40(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v48, v54, v45, v46)
            let v59 : US3 = US3_1(v58)
            let v60 : Heap0 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v59; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44} : Heap0
            method14(v57, v60)
        else
            let v62 : (Heap0 -> JSX.Element) = closure24()
            let v63 : bool = v53 ()
            let v66 : US4 =
                if v63 then
                    US4_1(1)
                else
                    US4_0
            let v67 : bool = v53 ()
            let v71 : US0 =
                if v67 then
                    let v68 : string = "absolute"
                    US0_1(v68)
                else
                    US0_0
            let v72 : bool = v53 ()
            let v76 : US0 =
                if v72 then
                    let v73 : string = "0"
                    US0_1(v73)
                else
                    US0_0
            let v77 : bool = v53 ()
            let v81 : US0 =
                if v77 then
                    let v78 : string = "0"
                    US0_1(v78)
                else
                    US0_0
            let v82 : bool = v53 ()
            let v86 : US0 =
                if v82 then
                    let v83 : string = "0"
                    US0_1(v83)
                else
                    US0_0
            let v87 : bool = v53 ()
            let v91 : US0 =
                if v87 then
                    let v88 : string = "0"
                    US0_1(v88)
                else
                    US0_0
            let v92 : bool = v53 ()
            let v96 : US0 =
                if v92 then
                    let v93 : string = "$bg"
                    US0_1(v93)
                else
                    US0_0
            let v97 : (unit -> JSX.Element) = closure29(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v50, v51, v52, v53)
            let v98 : US3 = US3_1(v97)
            let v99 : string = "flex"
            let v100 : US0 = US0_1(v99)
            let v101 : US4 = US4_1(1)
            let v102 : Heap0 = {l0 = v1; l1 = v2; l2 = v96; l3 = v4; l4 = v86; l5 = v6; l6 = v98; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v100; l12 = v13; l13 = v101; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v91; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v71; l34 = v81; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v76; l42 = v43; l43 = v66} : Heap0
            method14(v62, v102)
    let v105 : (JSX.Element []) = [|v104|]
    let v106 : JSX.Element = v105 |> unbox<JSX.Element>
    v106
and closure38 () struct (v0 : bool, v1 : bool, v2 : US10, v3 : Heap0) : JSX.Element =
    let struct (v4 : US0, v5 : US1, v6 : US0, v7 : US0, v8 : US0, v9 : US2, v10 : US3, v11 : US0, v12 : US0, v13 : US2, v14 : US0, v15 : US0, v16 : US2, v17 : US4, v18 : US0, v19 : US0, v20 : US0, v21 : US0, v22 : US5, v23 : US0, v24 : US0, v25 : US0, v26 : US6, v27 : US0, v28 : US0, v29 : US0, v30 : US0, v31 : US7, v32 : US8, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US0, v38 : US0, v39 : US0, v40 : US0, v41 : US2, v42 : US0, v43 : US0, v44 : US5, v45 : US0, v46 : US0, v47 : US4) = method0()
    let struct (v48 : Mut3, v49 : (Mut3 -> unit)) = method18()
    let v50 : int32 = Random().Next()
    let struct (v51 : (unit -> bool), v52 : (bool -> unit)) = method17(v0)
    let v53 : bool = false
    let struct (v54 : (unit -> bool), v55 : (bool -> unit)) = method17(v53)
    let struct (v56 : (unit -> bool), v57 : (bool -> unit)) = method17(v1)
    let v58 : string = "on"
    let v59 : string = "solid-js"
    let v60 : JS.Function = import v58 v59
    let v61 : (unit -> (bool [])) = closure22(v54)
    let v62 : (unit -> unit) = closure23(v55, v54)
    let v63 : JS.Function = v60.Invoke (v61, v62) |> unbox<JS.Function>
    let v64 : string = "createEffect"
    let v65 : JS.Function = import v64 v59
    v65.Invoke v63 |> ignore
    if v0 then
        match v2 with
        | US10_0 -> (* None *)
            ()
        | US10_1(v66) -> (* Some *)
            let v67 : ((Mut3 -> unit) -> unit) = v66 v48
            v67 v49
            ()
    let v68 : (Heap0 -> JSX.Element) = closure24()
    let v69 : US0 = v3.l19
    let v70 : (unit -> JSX.Element) = closure39(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v49, v48, v50, v52, v51, v55, v54, v57, v56, v2)
    let v71 : US3 = US3_1(v70)
    let v72 : string = "flex"
    let v73 : US0 = US0_1(v72)
    let v74 : US4 = US4_1(1)
    let v75 : Heap0 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v71; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v73; l12 = v16; l13 = v74; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v69; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47} : Heap0
    method14(v68, v75)
and closure44 (v0 : US10, v1 : Heap0, v2 : US0, v3 : US1, v4 : US0, v5 : US0, v6 : US0, v7 : US2, v8 : US3, v9 : US0, v10 : US0, v11 : US2, v12 : US0, v13 : US0, v14 : US2, v15 : US4, v16 : US0, v17 : US0, v18 : US0, v19 : US0, v20 : US5, v21 : US0, v22 : US0, v23 : US0, v24 : US6, v25 : US0, v26 : US0, v27 : US0, v28 : US0, v29 : US7, v30 : US8, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US0, v38 : US0, v39 : US2, v40 : US0, v41 : US0, v42 : US5, v43 : US0, v44 : US0, v45 : US4, v46 : (unit -> bool), v47 : (unit -> JSX.Element)) () : JSX.Element =
    let v48 : US2 = v1.l37
    let v132 : JSX.Element =
        match v48 with
        | US2_0 -> (* None *)
            let v49 : JSX.Element = v47 ()
            v49
        | US2_1(v50) -> (* Some *)
            let v51 : bool = v46 ()
            if v51 then
                let v52 : (unit -> JSX.Element) = closure20(v47)
                let v53 : US3 = US3_1(v52)
                let v54 : Heap0 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v53; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45} : Heap0
                let struct (v55 : US0, v56 : US1, v57 : US0, v58 : US0, v59 : US0, v60 : US2, v61 : US3, v62 : US0, v63 : US0, v64 : US2, v65 : US0, v66 : US0, v67 : US2, v68 : US4, v69 : US0, v70 : US0, v71 : US0, v72 : US0, v73 : US5, v74 : US0, v75 : US0, v76 : US0, v77 : US6, v78 : US0, v79 : US0, v80 : US0, v81 : US0, v82 : US7, v83 : US8, v84 : US0, v85 : US0, v86 : US0, v87 : US0, v88 : US0, v89 : US0, v90 : US0, v91 : US0, v92 : US2, v93 : US0, v94 : US0, v95 : US5, v96 : US0, v97 : US0, v98 : US4) = method0()
                let struct (v99 : Mut3, v100 : (Mut3 -> unit)) = method18()
                let v101 : int32 = Random().Next()
                let v102 : bool = true
                let struct (v103 : (unit -> bool), v104 : (bool -> unit)) = method17(v102)
                let v105 : bool = false
                let struct (v106 : (unit -> bool), v107 : (bool -> unit)) = method17(v105)
                let v108 : bool = false
                let struct (v109 : (unit -> bool), v110 : (bool -> unit)) = method17(v108)
                let v111 : string = "on"
                let v112 : string = "solid-js"
                let v113 : JS.Function = import v111 v112
                let v114 : (unit -> (bool [])) = closure22(v106)
                let v115 : (unit -> unit) = closure23(v107, v106)
                let v116 : JS.Function = v113.Invoke (v114, v115) |> unbox<JS.Function>
                let v117 : string = "createEffect"
                let v118 : JS.Function = import v117 v112
                v118.Invoke v116 |> ignore
                match v0 with
                | US10_0 -> (* None *)
                    ()
                | US10_1(v119) -> (* Some *)
                    let v120 : ((Mut3 -> unit) -> unit) = v119 v99
                    v120 v100
                    ()
                let v121 : (Heap0 -> JSX.Element) = closure24()
                let v122 : US0 = v54.l19
                let v123 : (unit -> JSX.Element) = closure39(v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v100, v99, v101, v104, v103, v107, v106, v110, v109, v0)
                let v124 : US3 = US3_1(v123)
                let v125 : string = "flex"
                let v126 : US0 = US0_1(v125)
                let v127 : US4 = US4_1(1)
                let v128 : Heap0 = {l0 = v55; l1 = v56; l2 = v57; l3 = v58; l4 = v59; l5 = v60; l6 = v124; l7 = v62; l8 = v63; l9 = v64; l10 = v65; l11 = v126; l12 = v67; l13 = v127; l14 = v69; l15 = v70; l16 = v71; l17 = v72; l18 = v73; l19 = v122; l20 = v75; l21 = v76; l22 = v77; l23 = v78; l24 = v79; l25 = v80; l26 = v81; l27 = v82; l28 = v83; l29 = v84; l30 = v85; l31 = v86; l32 = v87; l33 = v88; l34 = v89; l35 = v90; l36 = v91; l37 = v92; l38 = v93; l39 = v94; l40 = v95; l41 = v96; l42 = v97; l43 = v98} : Heap0
                method14(v121, v128)
            else
                let v130 : JSX.Element = Html.fragment []
                v130
    let v133 : (JSX.Element []) = [|v132|]
    let v134 : JSX.Element = v133 |> unbox<JSX.Element>
    v134
and closure43 (v0 : US10, v1 : Heap0, v2 : US0, v3 : US1, v4 : US0, v5 : US0, v6 : US0, v7 : US2, v8 : US3, v9 : US0, v10 : US0, v11 : US2, v12 : US0, v13 : US0, v14 : US2, v15 : US4, v16 : US0, v17 : US0, v18 : US0, v19 : US0, v20 : US5, v21 : US0, v22 : US0, v23 : US0, v24 : US6, v25 : US0, v26 : US0, v27 : US0, v28 : US0, v29 : US7, v30 : US8, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US0, v38 : US0, v39 : US2, v40 : US0, v41 : US0, v42 : US5, v43 : US0, v44 : US0, v45 : US4, v46 : (bool -> unit), v47 : (unit -> bool)) () : JSX.Element =
    let v48 : US5 = v1.l40
    let v70 : JSX.Element =
        match v48 with
        | US5_0 -> (* None *)
            let v49 : JSX.Element = Html.fragment []
            v49
        | US5_1(v50) -> (* Some *)
            let v51 : (Heap0 -> JSX.Element) = closure13()
            let v52 : string = "0 !important"
            let v53 : US0 = US0_1(v52)
            let v54 : (unit -> JSX.Element) = closure14(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v50)
            let v55 : US3 = US3_1(v54)
            let v56 : string = "$neutral9"
            let v57 : US0 = US0_1(v56)
            let v58 : string = "flex"
            let v59 : US0 = US0_1(v58)
            let v60 : string = "column"
            let v61 : US0 = US0_1(v60)
            let v62 : string = "$sm"
            let v63 : US0 = US0_1(v62)
            let v64 : string = "1px solid $neutral5"
            let v65 : US0 = US0_1(v64)
            let v66 : string = "3px 20px 0 8px"
            let v67 : US0 = US0_1(v66)
            let v68 : Heap0 = {l0 = v2; l1 = v3; l2 = v4; l3 = v53; l4 = v6; l5 = v7; l6 = v55; l7 = v57; l8 = v10; l9 = v11; l10 = v12; l11 = v59; l12 = v14; l13 = v15; l14 = v61; l15 = v63; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v65; l30 = v32; l31 = v67; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45} : Heap0
            method14(v51, v68)
    let v71 : US3 = v1.l6
    let v108 : JSX.Element =
        match v71 with
        | US3_0 -> (* None *)
            let v72 : (Heap0 -> JSX.Element) = closure13()
            let v73 : (unit -> JSX.Element) = closure18()
            let v74 : US3 = US3_1(v73)
            let v75 : string = "9px"
            let v76 : US0 = US0_1(v75)
            let v77 : string = "0"
            let v78 : US0 = US0_1(v77)
            let v79 : Heap0 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v74; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v76; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v78; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45} : Heap0
            method14(v72, v79)
        | US3_1(v81) -> (* Some *)
            let v82 : (Heap0 -> JSX.Element) = closure13()
            let v83 : US0 = v1.l31
            let v86 : string =
                match v83 with
                | US0_0 -> (* None *)
                    let v84 : string = "0"
                    v84
                | US0_1(v85) -> (* Some *)
                    v85
            let v87 : string = "0 !important"
            let v88 : US0 = US0_1(v87)
            let v89 : (unit -> JSX.Element) = closure44(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v47, v81)
            let v90 : US3 = US3_1(v89)
            let v91 : string = "flex"
            let v92 : US0 = US0_1(v91)
            let v93 : US4 = US4_1(6)
            let v94 : string = "column"
            let v95 : US0 = US0_1(v94)
            let v96 : string = "$sm"
            let v97 : US0 = US0_1(v96)
            let v98 : string = "0"
            let v99 : US0 = US0_1(v98)
            let v100 : string = "85vh"
            let v101 : US0 = US0_1(v100)
            let v102 : US0 = US0_1(v98)
            let v103 : string = "auto"
            let v104 : US0 = US0_1(v103)
            let v105 : US0 = US0_1(v86)
            let v106 : Heap0 = {l0 = v2; l1 = v3; l2 = v4; l3 = v88; l4 = v6; l5 = v7; l6 = v90; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v92; l12 = v14; l13 = v93; l14 = v95; l15 = v97; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v99; l25 = v27; l26 = v101; l27 = v29; l28 = v30; l29 = v102; l30 = v104; l31 = v105; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45} : Heap0
            method14(v82, v106)
    let v109 : (JSX.Element []) = [|v70; v108|]
    let v110 : JSX.Element = v109 |> unbox<JSX.Element>
    v110
and closure42 () struct (v0 : US10, v1 : Heap0) : JSX.Element =
    let struct (v2 : US0, v3 : US1, v4 : US0, v5 : US0, v6 : US0, v7 : US2, v8 : US3, v9 : US0, v10 : US0, v11 : US2, v12 : US0, v13 : US0, v14 : US2, v15 : US4, v16 : US0, v17 : US0, v18 : US0, v19 : US0, v20 : US5, v21 : US0, v22 : US0, v23 : US0, v24 : US6, v25 : US0, v26 : US0, v27 : US0, v28 : US0, v29 : US7, v30 : US8, v31 : US0, v32 : US0, v33 : US0, v34 : US0, v35 : US0, v36 : US0, v37 : US0, v38 : US0, v39 : US2, v40 : US0, v41 : US0, v42 : US5, v43 : US0, v44 : US0, v45 : US4) = method0()
    let v46 : US2 = v1.l37
    let v50 : bool =
        match v46 with
        | US2_1(v48) -> (* Some *)
            let v49 : bool = v48 = false
            v49
        | _ ->
            false
    let v51 : bool = v50 <> true
    let struct (v52 : (unit -> bool), v53 : (bool -> unit)) = method17(v51)
    let v54 : (Heap0 -> JSX.Element) = closure11()
    let v55 : US0 = v1.l19
    let v56 : string = {| ``@initial`` = "column"; ``@sm`` = "row" |} |> unbox<string>
    let v57 : string = "1px solid $neutral5"
    let v58 : US0 = US0_1(v57)
    let v59 : (unit -> JSX.Element) = closure43(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v53, v52)
    let v60 : US3 = US3_1(v59)
    let v61 : string = "flex"
    let v62 : US0 = US0_1(v61)
    let v63 : US4 = US4_1(1)
    let v64 : US0 = US0_1(v56)
    let v65 : Heap0 = {l0 = v2; l1 = v3; l2 = v4; l3 = v58; l4 = v6; l5 = v7; l6 = v60; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v62; l12 = v14; l13 = v63; l14 = v64; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v55; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45} : Heap0
    method14(v54, v65)
let v0 : string = "base_button"
let v1 : (Heap0 -> JSX.Element) = closure0()
let v2 : JSX.Prop = JSX.Prop (v0, v1)
let v3 : string = "base_table"
let v4 : (Heap0 -> JSX.Element) = closure1()
let v5 : JSX.Prop = JSX.Prop (v3, v4)
let v6 : string = "create_obj_props"
let v7 : ((struct (string * obj) []) -> Heap0) = closure5()
let v8 : JSX.Prop = JSX.Prop (v6, v7)
let v9 : string = "external_link"
let v10 : (Heap0 -> JSX.Element) = closure6()
let v11 : JSX.Prop = JSX.Prop (v9, v10)
let v12 : string = "links"
let v13 : (unit -> JSX.Element) = closure8()
let v14 : JSX.Prop = JSX.Prop (v12, v13)
let v15 : string = "loader"
let v16 : (struct (bool * bool * US10 * Heap0) -> JSX.Element) = closure38()
let v17 : JSX.Prop = JSX.Prop (v15, v16)
let v18 : string = "row"
let v19 : (struct (US10 * Heap0) -> JSX.Element) = closure42()
let v20 : JSX.Prop = JSX.Prop (v18, v19)
let v21 : (JSX.Prop []) = [|v2; v5; v8; v11; v14; v17; v20|]
let v22 : obj = createObj v21
()
