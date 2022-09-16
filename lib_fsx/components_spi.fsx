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
    | US6_1 of f1_0 : (obj -> unit)
and [<Struct>] US7 =
    | US7_0
    | US7_1 of f1_0 : (unit -> unit)
and Heap0 = {l0 : US0; l1 : US1; l2 : US0; l3 : US0; l4 : US0; l5 : US2; l6 : US3; l7 : US0; l8 : US0; l9 : US2; l10 : US0; l11 : US0; l12 : US2; l13 : US4; l14 : US0; l15 : US0; l16 : US0; l17 : US0; l18 : US5; l19 : US0; l20 : US0; l21 : US0; l22 : US0; l23 : US0; l24 : US0; l25 : US0; l26 : US6; l27 : US7; l28 : US0; l29 : US0; l30 : US0; l31 : US0; l32 : US0; l33 : US0; l34 : US0; l35 : US0; l36 : US2; l37 : US0; l38 : US0; l39 : US5; l40 : US0; l41 : US0; l42 : US4}
and [<Struct>] US8 =
    | US8_0
    | US8_1 of f1_0 : JSX.Prop
and Mut0 = {mutable l0 : int32; mutable l1 : int32}
and Mut1 = {mutable l0 : int32}
let rec method0 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method1 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure0 () (v0 : Heap0) : JSX.Element =
    let v1 : US3 = v0.l6
    let v2 : US0 = US0_0
    let v3 : US1 = US1_0
    let v4 : US0 = US0_0
    let v5 : US0 = US0_0
    let v6 : US0 = US0_0
    let v7 : US2 = US2_0
    let v8 : US0 = US0_0
    let v9 : string = "neutral"
    let v10 : US0 = US0_1(v9)
    let v11 : US2 = US2_1(true)
    let v12 : US0 = US0_0
    let v13 : US0 = US0_0
    let v14 : US2 = US2_0
    let v15 : US4 = US4_0
    let v16 : US0 = US0_0
    let v17 : US0 = US0_0
    let v18 : US0 = US0_0
    let v19 : US0 = US0_0
    let v20 : US5 = US5_0
    let v21 : US0 = US0_0
    let v22 : string = "left"
    let v23 : US0 = US0_1(v22)
    let v24 : US0 = US0_0
    let v25 : US0 = US0_0
    let v26 : US0 = US0_0
    let v27 : US0 = US0_0
    let v28 : US0 = US0_0
    let v29 : US6 = US6_0
    let v30 : US7 = US7_0
    let v31 : US0 = US0_0
    let v32 : US0 = US0_0
    let v33 : US0 = US0_0
    let v34 : US0 = US0_0
    let v35 : US0 = US0_0
    let v36 : US0 = US0_0
    let v37 : string = "xs"
    let v38 : US0 = US0_1(v37)
    let v39 : US0 = US0_0
    let v40 : US2 = US2_0
    let v41 : US0 = US0_0
    let v42 : US0 = US0_0
    let v43 : US5 = US5_0
    let v44 : US0 = US0_0
    let v45 : US0 = US0_0
    let v46 : US4 = US4_0
    let v47 : Heap0 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v1; l7 = v8; l8 = v10; l9 = v11; l10 = v12; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46} : Heap0
    let v48 : US0 = v47.l0
    let v54 : US8 =
        match v48 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v50) -> (* Some *)
            let v51 : string = "aria-label"
            let v52 : JSX.Prop = JSX.Prop (v51, v50)
            US8_1(v52)
    let v55 : US1 = v47.l1
    let v61 : US8 =
        match v55 with
        | US1_0 -> (* None *)
            US8_0
        | US1_1(v57) -> (* Some *)
            let v58 : string = "as"
            let v59 : JSX.Prop = JSX.Prop (v58, v57)
            US8_1(v59)
    let v62 : US0 = v47.l2
    let v68 : US8 =
        match v62 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v64) -> (* Some *)
            let v65 : string = "backgroundColor"
            let v66 : JSX.Prop = JSX.Prop (v65, v64)
            US8_1(v66)
    let v69 : US0 = v47.l3
    let v75 : US8 =
        match v69 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v71) -> (* Some *)
            let v72 : string = "border"
            let v73 : JSX.Prop = JSX.Prop (v72, v71)
            US8_1(v73)
    let v76 : US0 = v47.l4
    let v82 : US8 =
        match v76 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v78) -> (* Some *)
            let v79 : string = "bottom"
            let v80 : JSX.Prop = JSX.Prop (v79, v78)
            US8_1(v80)
    let v83 : US0 = v47.l7
    let v89 : US8 =
        match v83 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v85) -> (* Some *)
            let v86 : string = "color"
            let v87 : JSX.Prop = JSX.Prop (v86, v85)
            US8_1(v87)
    let v90 : US2 = v47.l5
    let v96 : US8 =
        match v90 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v92) -> (* Some *)
            let v93 : string = "checked"
            let v94 : JSX.Prop = JSX.Prop (v93, v92)
            US8_1(v94)
    let v97 : US3 = v47.l6
    let v103 : US8 =
        match v97 with
        | US3_0 -> (* None *)
            US8_0
        | US3_1(v99) -> (* Some *)
            let v100 : string = "children"
            let v101 : JSX.Prop = JSX.Prop (v100, v99)
            US8_1(v101)
    let v104 : US0 = v47.l8
    let v110 : US8 =
        match v104 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v106) -> (* Some *)
            let v107 : string = "colorScheme"
            let v108 : JSX.Prop = JSX.Prop (v107, v106)
            US8_1(v108)
    let v111 : US2 = v47.l9
    let v117 : US8 =
        match v111 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v113) -> (* Some *)
            let v114 : string = "compact"
            let v115 : JSX.Prop = JSX.Prop (v114, v113)
            US8_1(v115)
    let v118 : US0 = v47.l11
    let v124 : US8 =
        match v118 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v120) -> (* Some *)
            let v121 : string = "display"
            let v122 : JSX.Prop = JSX.Prop (v121, v120)
            US8_1(v122)
    let v125 : US0 = v47.l10
    let v131 : US8 =
        match v125 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v127) -> (* Some *)
            let v128 : string = "direction"
            let v129 : JSX.Prop = JSX.Prop (v128, v127)
            US8_1(v129)
    let v132 : US2 = v47.l12
    let v138 : US8 =
        match v132 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v134) -> (* Some *)
            let v135 : string = "external"
            let v136 : JSX.Prop = JSX.Prop (v135, v134)
            US8_1(v136)
    let v139 : US4 = v47.l13
    let v145 : US8 =
        match v139 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v141) -> (* Some *)
            let v142 : string = "flex"
            let v143 : JSX.Prop = JSX.Prop (v142, v141)
            US8_1(v143)
    let v146 : US0 = v47.l14
    let v152 : US8 =
        match v146 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v148) -> (* Some *)
            let v149 : string = "flexDirection"
            let v150 : JSX.Prop = JSX.Prop (v149, v148)
            US8_1(v150)
    let v153 : US0 = v47.l15
    let v159 : US8 =
        match v153 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v155) -> (* Some *)
            let v156 : string = "fontSize"
            let v157 : JSX.Prop = JSX.Prop (v156, v155)
            US8_1(v157)
    let v160 : US0 = v47.l16
    let v166 : US8 =
        match v160 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v162) -> (* Some *)
            let v163 : string = "height"
            let v164 : JSX.Prop = JSX.Prop (v163, v162)
            US8_1(v164)
    let v167 : US0 = v47.l17
    let v173 : US8 =
        match v167 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v169) -> (* Some *)
            let v170 : string = "href"
            let v171 : JSX.Prop = JSX.Prop (v170, v169)
            US8_1(v171)
    let v174 : US5 = v47.l18
    let v180 : US8 =
        match v174 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v176) -> (* Some *)
            let v177 : string = "icon"
            let v178 : JSX.Prop = JSX.Prop (v177, v176)
            US8_1(v178)
    let v181 : US0 = v47.l19
    let v187 : US8 =
        match v181 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v183) -> (* Some *)
            let v184 : string = "id"
            let v185 : JSX.Prop = JSX.Prop (v184, v183)
            US8_1(v185)
    let v188 : US0 = v47.l20
    let v194 : US8 =
        match v188 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v190) -> (* Some *)
            let v191 : string = "justifyContent"
            let v192 : JSX.Prop = JSX.Prop (v191, v190)
            US8_1(v192)
    let v195 : US0 = v47.l21
    let v200 : US8 =
        match v195 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v197) -> (* Some *)
            let v198 : JSX.Prop = JSX.Prop (v22, v197)
            US8_1(v198)
    let v201 : US0 = v47.l22
    let v207 : US8 =
        match v201 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v203) -> (* Some *)
            let v204 : string = "lineHeight"
            let v205 : JSX.Prop = JSX.Prop (v204, v203)
            US8_1(v205)
    let v208 : US0 = v47.l23
    let v214 : US8 =
        match v208 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v210) -> (* Some *)
            let v211 : string = "margin"
            let v212 : JSX.Prop = JSX.Prop (v211, v210)
            US8_1(v212)
    let v215 : US0 = v47.l24
    let v221 : US8 =
        match v215 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v217) -> (* Some *)
            let v218 : string = "marginBottom"
            let v219 : JSX.Prop = JSX.Prop (v218, v217)
            US8_1(v219)
    let v222 : US0 = v47.l25
    let v228 : US8 =
        match v222 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v224) -> (* Some *)
            let v225 : string = "maxHeight"
            let v226 : JSX.Prop = JSX.Prop (v225, v224)
            US8_1(v226)
    let v229 : US6 = v47.l26
    let v235 : US8 =
        match v229 with
        | US6_0 -> (* None *)
            US8_0
        | US6_1(v231) -> (* Some *)
            let v232 : string = "onChange"
            let v233 : JSX.Prop = JSX.Prop (v232, v231)
            US8_1(v233)
    let v236 : US7 = v47.l27
    let v242 : US8 =
        match v236 with
        | US7_0 -> (* None *)
            US8_0
        | US7_1(v238) -> (* Some *)
            let v239 : string = "onClick"
            let v240 : JSX.Prop = JSX.Prop (v239, v238)
            US8_1(v240)
    let v243 : US0 = v47.l28
    let v249 : US8 =
        match v243 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v245) -> (* Some *)
            let v246 : string = "outline"
            let v247 : JSX.Prop = JSX.Prop (v246, v245)
            US8_1(v247)
    let v250 : US0 = v47.l29
    let v256 : US8 =
        match v250 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v252) -> (* Some *)
            let v253 : string = "overflowY"
            let v254 : JSX.Prop = JSX.Prop (v253, v252)
            US8_1(v254)
    let v257 : US0 = v47.l30
    let v263 : US8 =
        match v257 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v259) -> (* Some *)
            let v260 : string = "padding"
            let v261 : JSX.Prop = JSX.Prop (v260, v259)
            US8_1(v261)
    let v264 : US0 = v47.l31
    let v270 : US8 =
        match v264 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v266) -> (* Some *)
            let v267 : string = "paddingTop"
            let v268 : JSX.Prop = JSX.Prop (v267, v266)
            US8_1(v268)
    let v271 : US0 = v47.l32
    let v277 : US8 =
        match v271 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v273) -> (* Some *)
            let v274 : string = "position"
            let v275 : JSX.Prop = JSX.Prop (v274, v273)
            US8_1(v275)
    let v278 : US0 = v47.l33
    let v284 : US8 =
        match v278 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v280) -> (* Some *)
            let v281 : string = "right"
            let v282 : JSX.Prop = JSX.Prop (v281, v280)
            US8_1(v282)
    let v285 : US0 = v47.l34
    let v291 : US8 =
        match v285 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v287) -> (* Some *)
            let v288 : string = "size"
            let v289 : JSX.Prop = JSX.Prop (v288, v287)
            US8_1(v289)
    let v292 : US0 = v47.l35
    let v298 : US8 =
        match v292 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v294) -> (* Some *)
            let v295 : string = "spacing"
            let v296 : JSX.Prop = JSX.Prop (v295, v294)
            US8_1(v296)
    let v299 : US2 = v47.l36
    let v305 : US8 =
        match v299 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v301) -> (* Some *)
            let v302 : string = "status"
            let v303 : JSX.Prop = JSX.Prop (v302, v301)
            US8_1(v303)
    let v306 : US0 = v47.l37
    let v312 : US8 =
        match v306 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v308) -> (* Some *)
            let v309 : string = "striped"
            let v310 : JSX.Prop = JSX.Prop (v309, v308)
            US8_1(v310)
    let v313 : US0 = v47.l38
    let v319 : US8 =
        match v313 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v315) -> (* Some *)
            let v316 : string = "thickness"
            let v317 : JSX.Prop = JSX.Prop (v316, v315)
            US8_1(v317)
    let v320 : US5 = v47.l39
    let v326 : US8 =
        match v320 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v322) -> (* Some *)
            let v323 : string = "title"
            let v324 : JSX.Prop = JSX.Prop (v323, v322)
            US8_1(v324)
    let v327 : US0 = v47.l40
    let v333 : US8 =
        match v327 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v329) -> (* Some *)
            let v330 : string = "top"
            let v331 : JSX.Prop = JSX.Prop (v330, v329)
            US8_1(v331)
    let v334 : US0 = v47.l41
    let v340 : US8 =
        match v334 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v336) -> (* Some *)
            let v337 : string = "width"
            let v338 : JSX.Prop = JSX.Prop (v337, v336)
            US8_1(v338)
    let v341 : US4 = v47.l42
    let v347 : US8 =
        match v341 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v343) -> (* Some *)
            let v344 : string = "zIndex"
            let v345 : JSX.Prop = JSX.Prop (v344, v343)
            US8_1(v345)
    let v348 : (US8 []) = [|v54; v61; v68; v75; v82; v89; v96; v103; v110; v117; v124; v131; v138; v145; v152; v159; v166; v173; v180; v187; v194; v200; v207; v214; v221; v228; v235; v242; v249; v256; v263; v270; v277; v284; v291; v298; v305; v312; v319; v326; v333; v340; v347|]
    let v349 : int32 = v348.Length
    let v350 : (US8 []) = Array.zeroCreate<US8> (v349)
    let v351 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method0(v349, v351) do
        let v353 : int32 = v351.l0
        let v354 : int32 = v351.l1
        let v355 : US8 = v348.[int v353]
        let v357 : bool =
            match v355 with
            | US8_0 -> (* None *)
                false
            | US8_1(v356) -> (* Some *)
                true
        let v359 : int32 =
            if v357 then
                v350.[int v354] <- v355
                let v358 : int32 = v354 + 1
                v358
            else
                v354
        let v360 : int32 = v353 + 1
        v351.l0 <- v360
        v351.l1 <- v359
        ()
    let v361 : int32 = v351.l1
    let v362 : (US8 []) = Array.zeroCreate<US8> (v361)
    let v363 : Mut1 = {l0 = 0} : Mut1
    while method1(v361, v363) do
        let v365 : int32 = v363.l0
        let v366 : US8 = v350.[int v365]
        v362.[int v365] <- v366
        let v367 : int32 = v365 + 1
        v363.l0 <- v367
        ()
    let v368 : int32 = v362.Length
    let v369 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v368)
    let v370 : Mut1 = {l0 = 0} : Mut1
    while method1(v368, v370) do
        let v372 : int32 = v370.l0
        let v373 : US8 = v362.[int v372]
        let v376 : JSX.Prop =
            match v373 with
            | US8_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US8_1(v375) -> (* Some *)
                v375
        v369.[int v372] <- v376
        let v377 : int32 = v372 + 1
        v370.l0 <- v377
        ()
    let v378 : obj = createObj v369
    let v379 : string = "createComponent"
    let v380 : string = "solid-js"
    let v381 : JS.Function = import v379 v380
    let v382 : string = "Button"
    let v383 : string = "@hope-ui/solid"
    let v384 : JSX.Element = v381.Invoke ((import v382 v383), v378) |> unbox<JSX.Element>
    v384
and closure3 () (v0 : Heap0) : JSX.Element =
    let v1 : US0 = v0.l0
    let v7 : US8 =
        match v1 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v3) -> (* Some *)
            let v4 : string = "aria-label"
            let v5 : JSX.Prop = JSX.Prop (v4, v3)
            US8_1(v5)
    let v8 : US1 = v0.l1
    let v14 : US8 =
        match v8 with
        | US1_0 -> (* None *)
            US8_0
        | US1_1(v10) -> (* Some *)
            let v11 : string = "as"
            let v12 : JSX.Prop = JSX.Prop (v11, v10)
            US8_1(v12)
    let v15 : US0 = v0.l2
    let v21 : US8 =
        match v15 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v17) -> (* Some *)
            let v18 : string = "backgroundColor"
            let v19 : JSX.Prop = JSX.Prop (v18, v17)
            US8_1(v19)
    let v22 : US0 = v0.l3
    let v28 : US8 =
        match v22 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v24) -> (* Some *)
            let v25 : string = "border"
            let v26 : JSX.Prop = JSX.Prop (v25, v24)
            US8_1(v26)
    let v29 : US0 = v0.l4
    let v35 : US8 =
        match v29 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v31) -> (* Some *)
            let v32 : string = "bottom"
            let v33 : JSX.Prop = JSX.Prop (v32, v31)
            US8_1(v33)
    let v36 : US0 = v0.l7
    let v42 : US8 =
        match v36 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v38) -> (* Some *)
            let v39 : string = "color"
            let v40 : JSX.Prop = JSX.Prop (v39, v38)
            US8_1(v40)
    let v43 : US2 = v0.l5
    let v49 : US8 =
        match v43 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v45) -> (* Some *)
            let v46 : string = "checked"
            let v47 : JSX.Prop = JSX.Prop (v46, v45)
            US8_1(v47)
    let v50 : US3 = v0.l6
    let v56 : US8 =
        match v50 with
        | US3_0 -> (* None *)
            US8_0
        | US3_1(v52) -> (* Some *)
            let v53 : string = "children"
            let v54 : JSX.Prop = JSX.Prop (v53, v52)
            US8_1(v54)
    let v57 : US0 = v0.l8
    let v63 : US8 =
        match v57 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v59) -> (* Some *)
            let v60 : string = "colorScheme"
            let v61 : JSX.Prop = JSX.Prop (v60, v59)
            US8_1(v61)
    let v64 : US2 = v0.l9
    let v70 : US8 =
        match v64 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v66) -> (* Some *)
            let v67 : string = "compact"
            let v68 : JSX.Prop = JSX.Prop (v67, v66)
            US8_1(v68)
    let v71 : US0 = v0.l11
    let v77 : US8 =
        match v71 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v73) -> (* Some *)
            let v74 : string = "display"
            let v75 : JSX.Prop = JSX.Prop (v74, v73)
            US8_1(v75)
    let v78 : US0 = v0.l10
    let v84 : US8 =
        match v78 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v80) -> (* Some *)
            let v81 : string = "direction"
            let v82 : JSX.Prop = JSX.Prop (v81, v80)
            US8_1(v82)
    let v85 : US2 = v0.l12
    let v91 : US8 =
        match v85 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v87) -> (* Some *)
            let v88 : string = "external"
            let v89 : JSX.Prop = JSX.Prop (v88, v87)
            US8_1(v89)
    let v92 : US4 = v0.l13
    let v98 : US8 =
        match v92 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v94) -> (* Some *)
            let v95 : string = "flex"
            let v96 : JSX.Prop = JSX.Prop (v95, v94)
            US8_1(v96)
    let v99 : US0 = v0.l14
    let v105 : US8 =
        match v99 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v101) -> (* Some *)
            let v102 : string = "flexDirection"
            let v103 : JSX.Prop = JSX.Prop (v102, v101)
            US8_1(v103)
    let v106 : US0 = v0.l15
    let v112 : US8 =
        match v106 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v108) -> (* Some *)
            let v109 : string = "fontSize"
            let v110 : JSX.Prop = JSX.Prop (v109, v108)
            US8_1(v110)
    let v113 : US0 = v0.l16
    let v119 : US8 =
        match v113 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v115) -> (* Some *)
            let v116 : string = "height"
            let v117 : JSX.Prop = JSX.Prop (v116, v115)
            US8_1(v117)
    let v120 : US0 = v0.l17
    let v126 : US8 =
        match v120 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v122) -> (* Some *)
            let v123 : string = "href"
            let v124 : JSX.Prop = JSX.Prop (v123, v122)
            US8_1(v124)
    let v127 : US5 = v0.l18
    let v133 : US8 =
        match v127 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v129) -> (* Some *)
            let v130 : string = "icon"
            let v131 : JSX.Prop = JSX.Prop (v130, v129)
            US8_1(v131)
    let v134 : US0 = v0.l19
    let v140 : US8 =
        match v134 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v136) -> (* Some *)
            let v137 : string = "id"
            let v138 : JSX.Prop = JSX.Prop (v137, v136)
            US8_1(v138)
    let v141 : US0 = v0.l20
    let v147 : US8 =
        match v141 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v143) -> (* Some *)
            let v144 : string = "justifyContent"
            let v145 : JSX.Prop = JSX.Prop (v144, v143)
            US8_1(v145)
    let v148 : US0 = v0.l21
    let v154 : US8 =
        match v148 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v150) -> (* Some *)
            let v151 : string = "left"
            let v152 : JSX.Prop = JSX.Prop (v151, v150)
            US8_1(v152)
    let v155 : US0 = v0.l22
    let v161 : US8 =
        match v155 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v157) -> (* Some *)
            let v158 : string = "lineHeight"
            let v159 : JSX.Prop = JSX.Prop (v158, v157)
            US8_1(v159)
    let v162 : US0 = v0.l23
    let v168 : US8 =
        match v162 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v164) -> (* Some *)
            let v165 : string = "margin"
            let v166 : JSX.Prop = JSX.Prop (v165, v164)
            US8_1(v166)
    let v169 : US0 = v0.l24
    let v175 : US8 =
        match v169 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v171) -> (* Some *)
            let v172 : string = "marginBottom"
            let v173 : JSX.Prop = JSX.Prop (v172, v171)
            US8_1(v173)
    let v176 : US0 = v0.l25
    let v182 : US8 =
        match v176 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v178) -> (* Some *)
            let v179 : string = "maxHeight"
            let v180 : JSX.Prop = JSX.Prop (v179, v178)
            US8_1(v180)
    let v183 : US6 = v0.l26
    let v189 : US8 =
        match v183 with
        | US6_0 -> (* None *)
            US8_0
        | US6_1(v185) -> (* Some *)
            let v186 : string = "onChange"
            let v187 : JSX.Prop = JSX.Prop (v186, v185)
            US8_1(v187)
    let v190 : US7 = v0.l27
    let v196 : US8 =
        match v190 with
        | US7_0 -> (* None *)
            US8_0
        | US7_1(v192) -> (* Some *)
            let v193 : string = "onClick"
            let v194 : JSX.Prop = JSX.Prop (v193, v192)
            US8_1(v194)
    let v197 : US0 = v0.l28
    let v203 : US8 =
        match v197 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v199) -> (* Some *)
            let v200 : string = "outline"
            let v201 : JSX.Prop = JSX.Prop (v200, v199)
            US8_1(v201)
    let v204 : US0 = v0.l29
    let v210 : US8 =
        match v204 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v206) -> (* Some *)
            let v207 : string = "overflowY"
            let v208 : JSX.Prop = JSX.Prop (v207, v206)
            US8_1(v208)
    let v211 : US0 = v0.l30
    let v217 : US8 =
        match v211 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v213) -> (* Some *)
            let v214 : string = "padding"
            let v215 : JSX.Prop = JSX.Prop (v214, v213)
            US8_1(v215)
    let v218 : US0 = v0.l31
    let v224 : US8 =
        match v218 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v220) -> (* Some *)
            let v221 : string = "paddingTop"
            let v222 : JSX.Prop = JSX.Prop (v221, v220)
            US8_1(v222)
    let v225 : US0 = v0.l32
    let v231 : US8 =
        match v225 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v227) -> (* Some *)
            let v228 : string = "position"
            let v229 : JSX.Prop = JSX.Prop (v228, v227)
            US8_1(v229)
    let v232 : US0 = v0.l33
    let v238 : US8 =
        match v232 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v234) -> (* Some *)
            let v235 : string = "right"
            let v236 : JSX.Prop = JSX.Prop (v235, v234)
            US8_1(v236)
    let v239 : US0 = v0.l34
    let v245 : US8 =
        match v239 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v241) -> (* Some *)
            let v242 : string = "size"
            let v243 : JSX.Prop = JSX.Prop (v242, v241)
            US8_1(v243)
    let v246 : US0 = v0.l35
    let v252 : US8 =
        match v246 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v248) -> (* Some *)
            let v249 : string = "spacing"
            let v250 : JSX.Prop = JSX.Prop (v249, v248)
            US8_1(v250)
    let v253 : US2 = v0.l36
    let v259 : US8 =
        match v253 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v255) -> (* Some *)
            let v256 : string = "status"
            let v257 : JSX.Prop = JSX.Prop (v256, v255)
            US8_1(v257)
    let v260 : US0 = v0.l37
    let v266 : US8 =
        match v260 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v262) -> (* Some *)
            let v263 : string = "striped"
            let v264 : JSX.Prop = JSX.Prop (v263, v262)
            US8_1(v264)
    let v267 : US0 = v0.l38
    let v273 : US8 =
        match v267 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v269) -> (* Some *)
            let v270 : string = "thickness"
            let v271 : JSX.Prop = JSX.Prop (v270, v269)
            US8_1(v271)
    let v274 : US5 = v0.l39
    let v280 : US8 =
        match v274 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v276) -> (* Some *)
            let v277 : string = "title"
            let v278 : JSX.Prop = JSX.Prop (v277, v276)
            US8_1(v278)
    let v281 : US0 = v0.l40
    let v287 : US8 =
        match v281 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v283) -> (* Some *)
            let v284 : string = "top"
            let v285 : JSX.Prop = JSX.Prop (v284, v283)
            US8_1(v285)
    let v288 : US0 = v0.l41
    let v294 : US8 =
        match v288 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v290) -> (* Some *)
            let v291 : string = "width"
            let v292 : JSX.Prop = JSX.Prop (v291, v290)
            US8_1(v292)
    let v295 : US4 = v0.l42
    let v301 : US8 =
        match v295 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v297) -> (* Some *)
            let v298 : string = "zIndex"
            let v299 : JSX.Prop = JSX.Prop (v298, v297)
            US8_1(v299)
    let v302 : (US8 []) = [|v7; v14; v21; v28; v35; v42; v49; v56; v63; v70; v77; v84; v91; v98; v105; v112; v119; v126; v133; v140; v147; v154; v161; v168; v175; v182; v189; v196; v203; v210; v217; v224; v231; v238; v245; v252; v259; v266; v273; v280; v287; v294; v301|]
    let v303 : int32 = v302.Length
    let v304 : (US8 []) = Array.zeroCreate<US8> (v303)
    let v305 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method0(v303, v305) do
        let v307 : int32 = v305.l0
        let v308 : int32 = v305.l1
        let v309 : US8 = v302.[int v307]
        let v311 : bool =
            match v309 with
            | US8_0 -> (* None *)
                false
            | US8_1(v310) -> (* Some *)
                true
        let v313 : int32 =
            if v311 then
                v304.[int v308] <- v309
                let v312 : int32 = v308 + 1
                v312
            else
                v308
        let v314 : int32 = v307 + 1
        v305.l0 <- v314
        v305.l1 <- v313
        ()
    let v315 : int32 = v305.l1
    let v316 : (US8 []) = Array.zeroCreate<US8> (v315)
    let v317 : Mut1 = {l0 = 0} : Mut1
    while method1(v315, v317) do
        let v319 : int32 = v317.l0
        let v320 : US8 = v304.[int v319]
        v316.[int v319] <- v320
        let v321 : int32 = v319 + 1
        v317.l0 <- v321
        ()
    let v322 : int32 = v316.Length
    let v323 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v322)
    let v324 : Mut1 = {l0 = 0} : Mut1
    while method1(v322, v324) do
        let v326 : int32 = v324.l0
        let v327 : US8 = v316.[int v326]
        let v330 : JSX.Prop =
            match v327 with
            | US8_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US8_1(v329) -> (* Some *)
                v329
        v323.[int v326] <- v330
        let v331 : int32 = v326 + 1
        v324.l0 <- v331
        ()
    let v332 : obj = createObj v323
    let v333 : string = "createComponent"
    let v334 : string = "solid-js"
    let v335 : JS.Function = import v333 v334
    let v336 : string = "Tbody"
    let v337 : string = "@hope-ui/solid"
    let v338 : JSX.Element = v335.Invoke ((import v336 v337), v332) |> unbox<JSX.Element>
    v338
and closure2 (v0 : Heap0) () : JSX.Element =
    let v1 : US3 = v0.l6
    let v2 : US0 = US0_0
    let v3 : US1 = US1_0
    let v4 : US0 = US0_0
    let v5 : US0 = US0_0
    let v6 : US0 = US0_0
    let v7 : US2 = US2_0
    let v8 : US0 = US0_0
    let v9 : US0 = US0_0
    let v10 : US2 = US2_0
    let v11 : US0 = US0_0
    let v12 : string = "flex"
    let v13 : US0 = US0_1(v12)
    let v14 : US2 = US2_0
    let v15 : US4 = US4_0
    let v16 : string = "column"
    let v17 : US0 = US0_1(v16)
    let v18 : US0 = US0_0
    let v19 : US0 = US0_0
    let v20 : US0 = US0_0
    let v21 : US5 = US5_0
    let v22 : US0 = US0_0
    let v23 : US0 = US0_0
    let v24 : US0 = US0_0
    let v25 : US0 = US0_0
    let v26 : US0 = US0_0
    let v27 : US0 = US0_0
    let v28 : US0 = US0_0
    let v29 : US6 = US6_0
    let v30 : US7 = US7_0
    let v31 : US0 = US0_0
    let v32 : US0 = US0_0
    let v33 : US0 = US0_0
    let v34 : US0 = US0_0
    let v35 : US0 = US0_0
    let v36 : US0 = US0_0
    let v37 : US0 = US0_0
    let v38 : US0 = US0_0
    let v39 : US2 = US2_0
    let v40 : US0 = US0_0
    let v41 : US0 = US0_0
    let v42 : US5 = US5_0
    let v43 : US0 = US0_0
    let v44 : US0 = US0_0
    let v45 : US4 = US4_0
    let v46 : Heap0 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v1; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v13; l12 = v14; l13 = v15; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45} : Heap0
    let v47 : (Heap0 -> JSX.Element) = closure3()
    let v48 : JS.Function = v47 |> unbox<JS.Function>
    let v49 : string = "createComponent"
    let v50 : string = "solid-js"
    let v51 : JS.Function = import v49 v50
    let v52 : JSX.Element = v51.Invoke (v48, v46) |> unbox<JSX.Element>
    let v53 : (JSX.Element []) = [|v52|]
    let v54 : JSX.Element = v53 |> unbox<JSX.Element>
    v54
and closure4 () (v0 : Heap0) : JSX.Element =
    let v1 : US0 = v0.l0
    let v7 : US8 =
        match v1 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v3) -> (* Some *)
            let v4 : string = "aria-label"
            let v5 : JSX.Prop = JSX.Prop (v4, v3)
            US8_1(v5)
    let v8 : US1 = v0.l1
    let v14 : US8 =
        match v8 with
        | US1_0 -> (* None *)
            US8_0
        | US1_1(v10) -> (* Some *)
            let v11 : string = "as"
            let v12 : JSX.Prop = JSX.Prop (v11, v10)
            US8_1(v12)
    let v15 : US0 = v0.l2
    let v21 : US8 =
        match v15 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v17) -> (* Some *)
            let v18 : string = "backgroundColor"
            let v19 : JSX.Prop = JSX.Prop (v18, v17)
            US8_1(v19)
    let v22 : US0 = v0.l3
    let v28 : US8 =
        match v22 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v24) -> (* Some *)
            let v25 : string = "border"
            let v26 : JSX.Prop = JSX.Prop (v25, v24)
            US8_1(v26)
    let v29 : US0 = v0.l4
    let v35 : US8 =
        match v29 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v31) -> (* Some *)
            let v32 : string = "bottom"
            let v33 : JSX.Prop = JSX.Prop (v32, v31)
            US8_1(v33)
    let v36 : US0 = v0.l7
    let v42 : US8 =
        match v36 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v38) -> (* Some *)
            let v39 : string = "color"
            let v40 : JSX.Prop = JSX.Prop (v39, v38)
            US8_1(v40)
    let v43 : US2 = v0.l5
    let v49 : US8 =
        match v43 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v45) -> (* Some *)
            let v46 : string = "checked"
            let v47 : JSX.Prop = JSX.Prop (v46, v45)
            US8_1(v47)
    let v50 : US3 = v0.l6
    let v56 : US8 =
        match v50 with
        | US3_0 -> (* None *)
            US8_0
        | US3_1(v52) -> (* Some *)
            let v53 : string = "children"
            let v54 : JSX.Prop = JSX.Prop (v53, v52)
            US8_1(v54)
    let v57 : US0 = v0.l8
    let v63 : US8 =
        match v57 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v59) -> (* Some *)
            let v60 : string = "colorScheme"
            let v61 : JSX.Prop = JSX.Prop (v60, v59)
            US8_1(v61)
    let v64 : US2 = v0.l9
    let v70 : US8 =
        match v64 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v66) -> (* Some *)
            let v67 : string = "compact"
            let v68 : JSX.Prop = JSX.Prop (v67, v66)
            US8_1(v68)
    let v71 : US0 = v0.l11
    let v77 : US8 =
        match v71 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v73) -> (* Some *)
            let v74 : string = "display"
            let v75 : JSX.Prop = JSX.Prop (v74, v73)
            US8_1(v75)
    let v78 : US0 = v0.l10
    let v84 : US8 =
        match v78 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v80) -> (* Some *)
            let v81 : string = "direction"
            let v82 : JSX.Prop = JSX.Prop (v81, v80)
            US8_1(v82)
    let v85 : US2 = v0.l12
    let v91 : US8 =
        match v85 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v87) -> (* Some *)
            let v88 : string = "external"
            let v89 : JSX.Prop = JSX.Prop (v88, v87)
            US8_1(v89)
    let v92 : US4 = v0.l13
    let v98 : US8 =
        match v92 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v94) -> (* Some *)
            let v95 : string = "flex"
            let v96 : JSX.Prop = JSX.Prop (v95, v94)
            US8_1(v96)
    let v99 : US0 = v0.l14
    let v105 : US8 =
        match v99 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v101) -> (* Some *)
            let v102 : string = "flexDirection"
            let v103 : JSX.Prop = JSX.Prop (v102, v101)
            US8_1(v103)
    let v106 : US0 = v0.l15
    let v112 : US8 =
        match v106 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v108) -> (* Some *)
            let v109 : string = "fontSize"
            let v110 : JSX.Prop = JSX.Prop (v109, v108)
            US8_1(v110)
    let v113 : US0 = v0.l16
    let v119 : US8 =
        match v113 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v115) -> (* Some *)
            let v116 : string = "height"
            let v117 : JSX.Prop = JSX.Prop (v116, v115)
            US8_1(v117)
    let v120 : US0 = v0.l17
    let v126 : US8 =
        match v120 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v122) -> (* Some *)
            let v123 : string = "href"
            let v124 : JSX.Prop = JSX.Prop (v123, v122)
            US8_1(v124)
    let v127 : US5 = v0.l18
    let v133 : US8 =
        match v127 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v129) -> (* Some *)
            let v130 : string = "icon"
            let v131 : JSX.Prop = JSX.Prop (v130, v129)
            US8_1(v131)
    let v134 : US0 = v0.l19
    let v140 : US8 =
        match v134 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v136) -> (* Some *)
            let v137 : string = "id"
            let v138 : JSX.Prop = JSX.Prop (v137, v136)
            US8_1(v138)
    let v141 : US0 = v0.l20
    let v147 : US8 =
        match v141 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v143) -> (* Some *)
            let v144 : string = "justifyContent"
            let v145 : JSX.Prop = JSX.Prop (v144, v143)
            US8_1(v145)
    let v148 : US0 = v0.l21
    let v154 : US8 =
        match v148 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v150) -> (* Some *)
            let v151 : string = "left"
            let v152 : JSX.Prop = JSX.Prop (v151, v150)
            US8_1(v152)
    let v155 : US0 = v0.l22
    let v161 : US8 =
        match v155 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v157) -> (* Some *)
            let v158 : string = "lineHeight"
            let v159 : JSX.Prop = JSX.Prop (v158, v157)
            US8_1(v159)
    let v162 : US0 = v0.l23
    let v168 : US8 =
        match v162 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v164) -> (* Some *)
            let v165 : string = "margin"
            let v166 : JSX.Prop = JSX.Prop (v165, v164)
            US8_1(v166)
    let v169 : US0 = v0.l24
    let v175 : US8 =
        match v169 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v171) -> (* Some *)
            let v172 : string = "marginBottom"
            let v173 : JSX.Prop = JSX.Prop (v172, v171)
            US8_1(v173)
    let v176 : US0 = v0.l25
    let v182 : US8 =
        match v176 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v178) -> (* Some *)
            let v179 : string = "maxHeight"
            let v180 : JSX.Prop = JSX.Prop (v179, v178)
            US8_1(v180)
    let v183 : US6 = v0.l26
    let v189 : US8 =
        match v183 with
        | US6_0 -> (* None *)
            US8_0
        | US6_1(v185) -> (* Some *)
            let v186 : string = "onChange"
            let v187 : JSX.Prop = JSX.Prop (v186, v185)
            US8_1(v187)
    let v190 : US7 = v0.l27
    let v196 : US8 =
        match v190 with
        | US7_0 -> (* None *)
            US8_0
        | US7_1(v192) -> (* Some *)
            let v193 : string = "onClick"
            let v194 : JSX.Prop = JSX.Prop (v193, v192)
            US8_1(v194)
    let v197 : US0 = v0.l28
    let v203 : US8 =
        match v197 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v199) -> (* Some *)
            let v200 : string = "outline"
            let v201 : JSX.Prop = JSX.Prop (v200, v199)
            US8_1(v201)
    let v204 : US0 = v0.l29
    let v210 : US8 =
        match v204 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v206) -> (* Some *)
            let v207 : string = "overflowY"
            let v208 : JSX.Prop = JSX.Prop (v207, v206)
            US8_1(v208)
    let v211 : US0 = v0.l30
    let v217 : US8 =
        match v211 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v213) -> (* Some *)
            let v214 : string = "padding"
            let v215 : JSX.Prop = JSX.Prop (v214, v213)
            US8_1(v215)
    let v218 : US0 = v0.l31
    let v224 : US8 =
        match v218 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v220) -> (* Some *)
            let v221 : string = "paddingTop"
            let v222 : JSX.Prop = JSX.Prop (v221, v220)
            US8_1(v222)
    let v225 : US0 = v0.l32
    let v231 : US8 =
        match v225 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v227) -> (* Some *)
            let v228 : string = "position"
            let v229 : JSX.Prop = JSX.Prop (v228, v227)
            US8_1(v229)
    let v232 : US0 = v0.l33
    let v238 : US8 =
        match v232 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v234) -> (* Some *)
            let v235 : string = "right"
            let v236 : JSX.Prop = JSX.Prop (v235, v234)
            US8_1(v236)
    let v239 : US0 = v0.l34
    let v245 : US8 =
        match v239 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v241) -> (* Some *)
            let v242 : string = "size"
            let v243 : JSX.Prop = JSX.Prop (v242, v241)
            US8_1(v243)
    let v246 : US0 = v0.l35
    let v252 : US8 =
        match v246 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v248) -> (* Some *)
            let v249 : string = "spacing"
            let v250 : JSX.Prop = JSX.Prop (v249, v248)
            US8_1(v250)
    let v253 : US2 = v0.l36
    let v259 : US8 =
        match v253 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v255) -> (* Some *)
            let v256 : string = "status"
            let v257 : JSX.Prop = JSX.Prop (v256, v255)
            US8_1(v257)
    let v260 : US0 = v0.l37
    let v266 : US8 =
        match v260 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v262) -> (* Some *)
            let v263 : string = "striped"
            let v264 : JSX.Prop = JSX.Prop (v263, v262)
            US8_1(v264)
    let v267 : US0 = v0.l38
    let v273 : US8 =
        match v267 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v269) -> (* Some *)
            let v270 : string = "thickness"
            let v271 : JSX.Prop = JSX.Prop (v270, v269)
            US8_1(v271)
    let v274 : US5 = v0.l39
    let v280 : US8 =
        match v274 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v276) -> (* Some *)
            let v277 : string = "title"
            let v278 : JSX.Prop = JSX.Prop (v277, v276)
            US8_1(v278)
    let v281 : US0 = v0.l40
    let v287 : US8 =
        match v281 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v283) -> (* Some *)
            let v284 : string = "top"
            let v285 : JSX.Prop = JSX.Prop (v284, v283)
            US8_1(v285)
    let v288 : US0 = v0.l41
    let v294 : US8 =
        match v288 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v290) -> (* Some *)
            let v291 : string = "width"
            let v292 : JSX.Prop = JSX.Prop (v291, v290)
            US8_1(v292)
    let v295 : US4 = v0.l42
    let v301 : US8 =
        match v295 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v297) -> (* Some *)
            let v298 : string = "zIndex"
            let v299 : JSX.Prop = JSX.Prop (v298, v297)
            US8_1(v299)
    let v302 : (US8 []) = [|v7; v14; v21; v28; v35; v42; v49; v56; v63; v70; v77; v84; v91; v98; v105; v112; v119; v126; v133; v140; v147; v154; v161; v168; v175; v182; v189; v196; v203; v210; v217; v224; v231; v238; v245; v252; v259; v266; v273; v280; v287; v294; v301|]
    let v303 : int32 = v302.Length
    let v304 : (US8 []) = Array.zeroCreate<US8> (v303)
    let v305 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method0(v303, v305) do
        let v307 : int32 = v305.l0
        let v308 : int32 = v305.l1
        let v309 : US8 = v302.[int v307]
        let v311 : bool =
            match v309 with
            | US8_0 -> (* None *)
                false
            | US8_1(v310) -> (* Some *)
                true
        let v313 : int32 =
            if v311 then
                v304.[int v308] <- v309
                let v312 : int32 = v308 + 1
                v312
            else
                v308
        let v314 : int32 = v307 + 1
        v305.l0 <- v314
        v305.l1 <- v313
        ()
    let v315 : int32 = v305.l1
    let v316 : (US8 []) = Array.zeroCreate<US8> (v315)
    let v317 : Mut1 = {l0 = 0} : Mut1
    while method1(v315, v317) do
        let v319 : int32 = v317.l0
        let v320 : US8 = v304.[int v319]
        v316.[int v319] <- v320
        let v321 : int32 = v319 + 1
        v317.l0 <- v321
        ()
    let v322 : int32 = v316.Length
    let v323 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v322)
    let v324 : Mut1 = {l0 = 0} : Mut1
    while method1(v322, v324) do
        let v326 : int32 = v324.l0
        let v327 : US8 = v316.[int v326]
        let v330 : JSX.Prop =
            match v327 with
            | US8_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US8_1(v329) -> (* Some *)
                v329
        v323.[int v326] <- v330
        let v331 : int32 = v326 + 1
        v324.l0 <- v331
        ()
    let v332 : obj = createObj v323
    let v333 : string = "createComponent"
    let v334 : string = "solid-js"
    let v335 : JS.Function = import v333 v334
    let v336 : string = "Table"
    let v337 : string = "@hope-ui/solid"
    let v338 : JSX.Element = v335.Invoke ((import v336 v337), v332) |> unbox<JSX.Element>
    v338
and closure1 () (v0 : Heap0) : JSX.Element =
    let v1 : US0 = US0_0
    let v2 : US1 = US1_0
    let v3 : US0 = US0_0
    let v4 : US0 = US0_0
    let v5 : US0 = US0_0
    let v6 : US2 = US2_0
    let v7 : (unit -> JSX.Element) = closure2(v0)
    let v8 : US3 = US3_1(v7)
    let v9 : US0 = US0_0
    let v10 : US0 = US0_0
    let v11 : US2 = US2_0
    let v12 : US0 = US0_0
    let v13 : string = "flex"
    let v14 : US0 = US0_1(v13)
    let v15 : US2 = US2_0
    let v16 : US4 = US4_1(1)
    let v17 : string = "column"
    let v18 : US0 = US0_1(v17)
    let v19 : US0 = US0_0
    let v20 : US0 = US0_0
    let v21 : US0 = US0_0
    let v22 : US5 = US5_0
    let v23 : US0 = US0_0
    let v24 : US0 = US0_0
    let v25 : US0 = US0_0
    let v26 : US0 = US0_0
    let v27 : US0 = US0_0
    let v28 : US0 = US0_0
    let v29 : US0 = US0_0
    let v30 : US6 = US6_0
    let v31 : US7 = US7_0
    let v32 : US0 = US0_0
    let v33 : US0 = US0_0
    let v34 : US0 = US0_0
    let v35 : US0 = US0_0
    let v36 : US0 = US0_0
    let v37 : US0 = US0_0
    let v38 : US0 = US0_0
    let v39 : US0 = US0_0
    let v40 : US2 = US2_0
    let v41 : string = "odd"
    let v42 : US0 = US0_1(v41)
    let v43 : US0 = US0_0
    let v44 : US5 = US5_0
    let v45 : US0 = US0_0
    let v46 : US0 = US0_0
    let v47 : US4 = US4_0
    let v48 : Heap0 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v14; l12 = v15; l13 = v16; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47} : Heap0
    let v49 : (Heap0 -> JSX.Element) = closure4()
    let v50 : JS.Function = v49 |> unbox<JS.Function>
    let v51 : string = "createComponent"
    let v52 : string = "solid-js"
    let v53 : JS.Function = import v51 v52
    let v54 : JSX.Element = v53.Invoke (v50, v48) |> unbox<JSX.Element>
    v54
and closure6 (v0 : Heap0) () : JSX.Element =
    let v1 : US0 = v0.l17
    let v4 : string =
        match v1 with
        | US0_0 -> (* None *)
            let v2 : string = ""
            v2
        | US0_1(v3) -> (* Some *)
            v3
    let v5 : JSX.Element = v4 |> unbox<JSX.Element>
    let v6 : string = " "
    let v7 : JSX.Element = v6 |> unbox<JSX.Element>
    let v8 : string = "BiRegularLinkExternal"
    let v9 : string = "solid-icons/bi"
    let v10 : JS.Function = import v8 v9
    let v11 : US0 = US0_0
    let v12 : US1 = US1_1(v10)
    let v13 : US0 = US0_0
    let v14 : US0 = US0_0
    let v15 : US0 = US0_0
    let v16 : US2 = US2_0
    let v17 : US3 = US3_0
    let v18 : US0 = US0_0
    let v19 : US0 = US0_0
    let v20 : US2 = US2_0
    let v21 : US0 = US0_0
    let v22 : US0 = US0_0
    let v23 : US2 = US2_0
    let v24 : US4 = US4_0
    let v25 : US0 = US0_0
    let v26 : US0 = US0_0
    let v27 : US0 = US0_0
    let v28 : US0 = US0_0
    let v29 : US5 = US5_0
    let v30 : US0 = US0_0
    let v31 : US0 = US0_0
    let v32 : US0 = US0_0
    let v33 : US0 = US0_0
    let v34 : US0 = US0_0
    let v35 : US0 = US0_0
    let v36 : US0 = US0_0
    let v37 : US6 = US6_0
    let v38 : US7 = US7_0
    let v39 : US0 = US0_0
    let v40 : US0 = US0_0
    let v41 : US0 = US0_0
    let v42 : US0 = US0_0
    let v43 : US0 = US0_0
    let v44 : US0 = US0_0
    let v45 : US0 = US0_0
    let v46 : US0 = US0_0
    let v47 : US2 = US2_0
    let v48 : US0 = US0_0
    let v49 : US0 = US0_0
    let v50 : US5 = US5_0
    let v51 : US0 = US0_0
    let v52 : US0 = US0_0
    let v53 : US4 = US4_0
    let v54 : Heap0 = {l0 = v11; l1 = v12; l2 = v13; l3 = v14; l4 = v15; l5 = v16; l6 = v17; l7 = v18; l8 = v19; l9 = v20; l10 = v21; l11 = v22; l12 = v23; l13 = v24; l14 = v25; l15 = v26; l16 = v27; l17 = v28; l18 = v29; l19 = v30; l20 = v31; l21 = v32; l22 = v33; l23 = v34; l24 = v35; l25 = v36; l26 = v37; l27 = v38; l28 = v39; l29 = v40; l30 = v41; l31 = v42; l32 = v43; l33 = v44; l34 = v45; l35 = v46; l36 = v47; l37 = v48; l38 = v49; l39 = v50; l40 = v51; l41 = v52; l42 = v53} : Heap0
    let v55 : US0 = v54.l0
    let v61 : US8 =
        match v55 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v57) -> (* Some *)
            let v58 : string = "aria-label"
            let v59 : JSX.Prop = JSX.Prop (v58, v57)
            US8_1(v59)
    let v62 : US1 = v54.l1
    let v68 : US8 =
        match v62 with
        | US1_0 -> (* None *)
            US8_0
        | US1_1(v64) -> (* Some *)
            let v65 : string = "as"
            let v66 : JSX.Prop = JSX.Prop (v65, v64)
            US8_1(v66)
    let v69 : US0 = v54.l2
    let v75 : US8 =
        match v69 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v71) -> (* Some *)
            let v72 : string = "backgroundColor"
            let v73 : JSX.Prop = JSX.Prop (v72, v71)
            US8_1(v73)
    let v76 : US0 = v54.l3
    let v82 : US8 =
        match v76 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v78) -> (* Some *)
            let v79 : string = "border"
            let v80 : JSX.Prop = JSX.Prop (v79, v78)
            US8_1(v80)
    let v83 : US0 = v54.l4
    let v89 : US8 =
        match v83 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v85) -> (* Some *)
            let v86 : string = "bottom"
            let v87 : JSX.Prop = JSX.Prop (v86, v85)
            US8_1(v87)
    let v90 : US0 = v54.l7
    let v96 : US8 =
        match v90 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v92) -> (* Some *)
            let v93 : string = "color"
            let v94 : JSX.Prop = JSX.Prop (v93, v92)
            US8_1(v94)
    let v97 : US2 = v54.l5
    let v103 : US8 =
        match v97 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v99) -> (* Some *)
            let v100 : string = "checked"
            let v101 : JSX.Prop = JSX.Prop (v100, v99)
            US8_1(v101)
    let v104 : US3 = v54.l6
    let v110 : US8 =
        match v104 with
        | US3_0 -> (* None *)
            US8_0
        | US3_1(v106) -> (* Some *)
            let v107 : string = "children"
            let v108 : JSX.Prop = JSX.Prop (v107, v106)
            US8_1(v108)
    let v111 : US0 = v54.l8
    let v117 : US8 =
        match v111 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v113) -> (* Some *)
            let v114 : string = "colorScheme"
            let v115 : JSX.Prop = JSX.Prop (v114, v113)
            US8_1(v115)
    let v118 : US2 = v54.l9
    let v124 : US8 =
        match v118 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v120) -> (* Some *)
            let v121 : string = "compact"
            let v122 : JSX.Prop = JSX.Prop (v121, v120)
            US8_1(v122)
    let v125 : US0 = v54.l11
    let v131 : US8 =
        match v125 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v127) -> (* Some *)
            let v128 : string = "display"
            let v129 : JSX.Prop = JSX.Prop (v128, v127)
            US8_1(v129)
    let v132 : US0 = v54.l10
    let v138 : US8 =
        match v132 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v134) -> (* Some *)
            let v135 : string = "direction"
            let v136 : JSX.Prop = JSX.Prop (v135, v134)
            US8_1(v136)
    let v139 : US2 = v54.l12
    let v145 : US8 =
        match v139 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v141) -> (* Some *)
            let v142 : string = "external"
            let v143 : JSX.Prop = JSX.Prop (v142, v141)
            US8_1(v143)
    let v146 : US4 = v54.l13
    let v152 : US8 =
        match v146 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v148) -> (* Some *)
            let v149 : string = "flex"
            let v150 : JSX.Prop = JSX.Prop (v149, v148)
            US8_1(v150)
    let v153 : US0 = v54.l14
    let v159 : US8 =
        match v153 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v155) -> (* Some *)
            let v156 : string = "flexDirection"
            let v157 : JSX.Prop = JSX.Prop (v156, v155)
            US8_1(v157)
    let v160 : US0 = v54.l15
    let v166 : US8 =
        match v160 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v162) -> (* Some *)
            let v163 : string = "fontSize"
            let v164 : JSX.Prop = JSX.Prop (v163, v162)
            US8_1(v164)
    let v167 : US0 = v54.l16
    let v173 : US8 =
        match v167 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v169) -> (* Some *)
            let v170 : string = "height"
            let v171 : JSX.Prop = JSX.Prop (v170, v169)
            US8_1(v171)
    let v174 : US0 = v54.l17
    let v180 : US8 =
        match v174 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v176) -> (* Some *)
            let v177 : string = "href"
            let v178 : JSX.Prop = JSX.Prop (v177, v176)
            US8_1(v178)
    let v181 : US5 = v54.l18
    let v187 : US8 =
        match v181 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v183) -> (* Some *)
            let v184 : string = "icon"
            let v185 : JSX.Prop = JSX.Prop (v184, v183)
            US8_1(v185)
    let v188 : US0 = v54.l19
    let v194 : US8 =
        match v188 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v190) -> (* Some *)
            let v191 : string = "id"
            let v192 : JSX.Prop = JSX.Prop (v191, v190)
            US8_1(v192)
    let v195 : US0 = v54.l20
    let v201 : US8 =
        match v195 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v197) -> (* Some *)
            let v198 : string = "justifyContent"
            let v199 : JSX.Prop = JSX.Prop (v198, v197)
            US8_1(v199)
    let v202 : US0 = v54.l21
    let v208 : US8 =
        match v202 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v204) -> (* Some *)
            let v205 : string = "left"
            let v206 : JSX.Prop = JSX.Prop (v205, v204)
            US8_1(v206)
    let v209 : US0 = v54.l22
    let v215 : US8 =
        match v209 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v211) -> (* Some *)
            let v212 : string = "lineHeight"
            let v213 : JSX.Prop = JSX.Prop (v212, v211)
            US8_1(v213)
    let v216 : US0 = v54.l23
    let v222 : US8 =
        match v216 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v218) -> (* Some *)
            let v219 : string = "margin"
            let v220 : JSX.Prop = JSX.Prop (v219, v218)
            US8_1(v220)
    let v223 : US0 = v54.l24
    let v229 : US8 =
        match v223 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v225) -> (* Some *)
            let v226 : string = "marginBottom"
            let v227 : JSX.Prop = JSX.Prop (v226, v225)
            US8_1(v227)
    let v230 : US0 = v54.l25
    let v236 : US8 =
        match v230 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v232) -> (* Some *)
            let v233 : string = "maxHeight"
            let v234 : JSX.Prop = JSX.Prop (v233, v232)
            US8_1(v234)
    let v237 : US6 = v54.l26
    let v243 : US8 =
        match v237 with
        | US6_0 -> (* None *)
            US8_0
        | US6_1(v239) -> (* Some *)
            let v240 : string = "onChange"
            let v241 : JSX.Prop = JSX.Prop (v240, v239)
            US8_1(v241)
    let v244 : US7 = v54.l27
    let v250 : US8 =
        match v244 with
        | US7_0 -> (* None *)
            US8_0
        | US7_1(v246) -> (* Some *)
            let v247 : string = "onClick"
            let v248 : JSX.Prop = JSX.Prop (v247, v246)
            US8_1(v248)
    let v251 : US0 = v54.l28
    let v257 : US8 =
        match v251 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v253) -> (* Some *)
            let v254 : string = "outline"
            let v255 : JSX.Prop = JSX.Prop (v254, v253)
            US8_1(v255)
    let v258 : US0 = v54.l29
    let v264 : US8 =
        match v258 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v260) -> (* Some *)
            let v261 : string = "overflowY"
            let v262 : JSX.Prop = JSX.Prop (v261, v260)
            US8_1(v262)
    let v265 : US0 = v54.l30
    let v271 : US8 =
        match v265 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v267) -> (* Some *)
            let v268 : string = "padding"
            let v269 : JSX.Prop = JSX.Prop (v268, v267)
            US8_1(v269)
    let v272 : US0 = v54.l31
    let v278 : US8 =
        match v272 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v274) -> (* Some *)
            let v275 : string = "paddingTop"
            let v276 : JSX.Prop = JSX.Prop (v275, v274)
            US8_1(v276)
    let v279 : US0 = v54.l32
    let v285 : US8 =
        match v279 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v281) -> (* Some *)
            let v282 : string = "position"
            let v283 : JSX.Prop = JSX.Prop (v282, v281)
            US8_1(v283)
    let v286 : US0 = v54.l33
    let v292 : US8 =
        match v286 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v288) -> (* Some *)
            let v289 : string = "right"
            let v290 : JSX.Prop = JSX.Prop (v289, v288)
            US8_1(v290)
    let v293 : US0 = v54.l34
    let v299 : US8 =
        match v293 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v295) -> (* Some *)
            let v296 : string = "size"
            let v297 : JSX.Prop = JSX.Prop (v296, v295)
            US8_1(v297)
    let v300 : US0 = v54.l35
    let v306 : US8 =
        match v300 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v302) -> (* Some *)
            let v303 : string = "spacing"
            let v304 : JSX.Prop = JSX.Prop (v303, v302)
            US8_1(v304)
    let v307 : US2 = v54.l36
    let v313 : US8 =
        match v307 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v309) -> (* Some *)
            let v310 : string = "status"
            let v311 : JSX.Prop = JSX.Prop (v310, v309)
            US8_1(v311)
    let v314 : US0 = v54.l37
    let v320 : US8 =
        match v314 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v316) -> (* Some *)
            let v317 : string = "striped"
            let v318 : JSX.Prop = JSX.Prop (v317, v316)
            US8_1(v318)
    let v321 : US0 = v54.l38
    let v327 : US8 =
        match v321 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v323) -> (* Some *)
            let v324 : string = "thickness"
            let v325 : JSX.Prop = JSX.Prop (v324, v323)
            US8_1(v325)
    let v328 : US5 = v54.l39
    let v334 : US8 =
        match v328 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v330) -> (* Some *)
            let v331 : string = "title"
            let v332 : JSX.Prop = JSX.Prop (v331, v330)
            US8_1(v332)
    let v335 : US0 = v54.l40
    let v341 : US8 =
        match v335 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v337) -> (* Some *)
            let v338 : string = "top"
            let v339 : JSX.Prop = JSX.Prop (v338, v337)
            US8_1(v339)
    let v342 : US0 = v54.l41
    let v348 : US8 =
        match v342 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v344) -> (* Some *)
            let v345 : string = "width"
            let v346 : JSX.Prop = JSX.Prop (v345, v344)
            US8_1(v346)
    let v349 : US4 = v54.l42
    let v355 : US8 =
        match v349 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v351) -> (* Some *)
            let v352 : string = "zIndex"
            let v353 : JSX.Prop = JSX.Prop (v352, v351)
            US8_1(v353)
    let v356 : (US8 []) = [|v61; v68; v75; v82; v89; v96; v103; v110; v117; v124; v131; v138; v145; v152; v159; v166; v173; v180; v187; v194; v201; v208; v215; v222; v229; v236; v243; v250; v257; v264; v271; v278; v285; v292; v299; v306; v313; v320; v327; v334; v341; v348; v355|]
    let v357 : int32 = v356.Length
    let v358 : (US8 []) = Array.zeroCreate<US8> (v357)
    let v359 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method0(v357, v359) do
        let v361 : int32 = v359.l0
        let v362 : int32 = v359.l1
        let v363 : US8 = v356.[int v361]
        let v365 : bool =
            match v363 with
            | US8_0 -> (* None *)
                false
            | US8_1(v364) -> (* Some *)
                true
        let v367 : int32 =
            if v365 then
                v358.[int v362] <- v363
                let v366 : int32 = v362 + 1
                v366
            else
                v362
        let v368 : int32 = v361 + 1
        v359.l0 <- v368
        v359.l1 <- v367
        ()
    let v369 : int32 = v359.l1
    let v370 : (US8 []) = Array.zeroCreate<US8> (v369)
    let v371 : Mut1 = {l0 = 0} : Mut1
    while method1(v369, v371) do
        let v373 : int32 = v371.l0
        let v374 : US8 = v358.[int v373]
        v370.[int v373] <- v374
        let v375 : int32 = v373 + 1
        v371.l0 <- v375
        ()
    let v376 : int32 = v370.Length
    let v377 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v376)
    let v378 : Mut1 = {l0 = 0} : Mut1
    while method1(v376, v378) do
        let v380 : int32 = v378.l0
        let v381 : US8 = v370.[int v380]
        let v384 : JSX.Prop =
            match v381 with
            | US8_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US8_1(v383) -> (* Some *)
                v383
        v377.[int v380] <- v384
        let v385 : int32 = v380 + 1
        v378.l0 <- v385
        ()
    let v386 : obj = createObj v377
    let v387 : string = "createComponent"
    let v388 : string = "solid-js"
    let v389 : JS.Function = import v387 v388
    let v390 : string = "Icon"
    let v391 : string = "@hope-ui/solid"
    let v392 : JSX.Element = v389.Invoke ((import v390 v391), v386) |> unbox<JSX.Element>
    let v393 : (JSX.Element []) = [|v5; v7; v392|]
    let v394 : JSX.Element = v393 |> unbox<JSX.Element>
    v394
and closure5 () (v0 : Heap0) : JSX.Element =
    let v1 : US0 = v0.l17
    let v2 : US0 = US0_0
    let v3 : US1 = US1_0
    let v4 : US0 = US0_0
    let v5 : US0 = US0_0
    let v6 : US0 = US0_0
    let v7 : US2 = US2_0
    let v8 : (unit -> JSX.Element) = closure6(v0)
    let v9 : US3 = US3_1(v8)
    let v10 : US0 = US0_0
    let v11 : US0 = US0_0
    let v12 : US2 = US2_0
    let v13 : US0 = US0_0
    let v14 : US0 = US0_0
    let v15 : US2 = US2_1(true)
    let v16 : US4 = US4_0
    let v17 : US0 = US0_0
    let v18 : US0 = US0_0
    let v19 : US0 = US0_0
    let v20 : US5 = US5_0
    let v21 : US0 = US0_0
    let v22 : US0 = US0_0
    let v23 : US0 = US0_0
    let v24 : US0 = US0_0
    let v25 : US0 = US0_0
    let v26 : US0 = US0_0
    let v27 : US0 = US0_0
    let v28 : US6 = US6_0
    let v29 : US7 = US7_0
    let v30 : US0 = US0_0
    let v31 : US0 = US0_0
    let v32 : US0 = US0_0
    let v33 : US0 = US0_0
    let v34 : US0 = US0_0
    let v35 : US0 = US0_0
    let v36 : US0 = US0_0
    let v37 : US0 = US0_0
    let v38 : US2 = US2_0
    let v39 : US0 = US0_0
    let v40 : US0 = US0_0
    let v41 : US5 = US5_0
    let v42 : US0 = US0_0
    let v43 : US0 = US0_0
    let v44 : US4 = US4_0
    let v45 : Heap0 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v13; l11 = v14; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v1; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44} : Heap0
    let v46 : US0 = v45.l0
    let v52 : US8 =
        match v46 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v48) -> (* Some *)
            let v49 : string = "aria-label"
            let v50 : JSX.Prop = JSX.Prop (v49, v48)
            US8_1(v50)
    let v53 : US1 = v45.l1
    let v59 : US8 =
        match v53 with
        | US1_0 -> (* None *)
            US8_0
        | US1_1(v55) -> (* Some *)
            let v56 : string = "as"
            let v57 : JSX.Prop = JSX.Prop (v56, v55)
            US8_1(v57)
    let v60 : US0 = v45.l2
    let v66 : US8 =
        match v60 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v62) -> (* Some *)
            let v63 : string = "backgroundColor"
            let v64 : JSX.Prop = JSX.Prop (v63, v62)
            US8_1(v64)
    let v67 : US0 = v45.l3
    let v73 : US8 =
        match v67 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v69) -> (* Some *)
            let v70 : string = "border"
            let v71 : JSX.Prop = JSX.Prop (v70, v69)
            US8_1(v71)
    let v74 : US0 = v45.l4
    let v80 : US8 =
        match v74 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v76) -> (* Some *)
            let v77 : string = "bottom"
            let v78 : JSX.Prop = JSX.Prop (v77, v76)
            US8_1(v78)
    let v81 : US0 = v45.l7
    let v87 : US8 =
        match v81 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v83) -> (* Some *)
            let v84 : string = "color"
            let v85 : JSX.Prop = JSX.Prop (v84, v83)
            US8_1(v85)
    let v88 : US2 = v45.l5
    let v94 : US8 =
        match v88 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v90) -> (* Some *)
            let v91 : string = "checked"
            let v92 : JSX.Prop = JSX.Prop (v91, v90)
            US8_1(v92)
    let v95 : US3 = v45.l6
    let v101 : US8 =
        match v95 with
        | US3_0 -> (* None *)
            US8_0
        | US3_1(v97) -> (* Some *)
            let v98 : string = "children"
            let v99 : JSX.Prop = JSX.Prop (v98, v97)
            US8_1(v99)
    let v102 : US0 = v45.l8
    let v108 : US8 =
        match v102 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v104) -> (* Some *)
            let v105 : string = "colorScheme"
            let v106 : JSX.Prop = JSX.Prop (v105, v104)
            US8_1(v106)
    let v109 : US2 = v45.l9
    let v115 : US8 =
        match v109 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v111) -> (* Some *)
            let v112 : string = "compact"
            let v113 : JSX.Prop = JSX.Prop (v112, v111)
            US8_1(v113)
    let v116 : US0 = v45.l11
    let v122 : US8 =
        match v116 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v118) -> (* Some *)
            let v119 : string = "display"
            let v120 : JSX.Prop = JSX.Prop (v119, v118)
            US8_1(v120)
    let v123 : US0 = v45.l10
    let v129 : US8 =
        match v123 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v125) -> (* Some *)
            let v126 : string = "direction"
            let v127 : JSX.Prop = JSX.Prop (v126, v125)
            US8_1(v127)
    let v130 : US2 = v45.l12
    let v136 : US8 =
        match v130 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v132) -> (* Some *)
            let v133 : string = "external"
            let v134 : JSX.Prop = JSX.Prop (v133, v132)
            US8_1(v134)
    let v137 : US4 = v45.l13
    let v143 : US8 =
        match v137 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v139) -> (* Some *)
            let v140 : string = "flex"
            let v141 : JSX.Prop = JSX.Prop (v140, v139)
            US8_1(v141)
    let v144 : US0 = v45.l14
    let v150 : US8 =
        match v144 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v146) -> (* Some *)
            let v147 : string = "flexDirection"
            let v148 : JSX.Prop = JSX.Prop (v147, v146)
            US8_1(v148)
    let v151 : US0 = v45.l15
    let v157 : US8 =
        match v151 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v153) -> (* Some *)
            let v154 : string = "fontSize"
            let v155 : JSX.Prop = JSX.Prop (v154, v153)
            US8_1(v155)
    let v158 : US0 = v45.l16
    let v164 : US8 =
        match v158 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v160) -> (* Some *)
            let v161 : string = "height"
            let v162 : JSX.Prop = JSX.Prop (v161, v160)
            US8_1(v162)
    let v165 : US0 = v45.l17
    let v171 : US8 =
        match v165 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v167) -> (* Some *)
            let v168 : string = "href"
            let v169 : JSX.Prop = JSX.Prop (v168, v167)
            US8_1(v169)
    let v172 : US5 = v45.l18
    let v178 : US8 =
        match v172 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v174) -> (* Some *)
            let v175 : string = "icon"
            let v176 : JSX.Prop = JSX.Prop (v175, v174)
            US8_1(v176)
    let v179 : US0 = v45.l19
    let v185 : US8 =
        match v179 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v181) -> (* Some *)
            let v182 : string = "id"
            let v183 : JSX.Prop = JSX.Prop (v182, v181)
            US8_1(v183)
    let v186 : US0 = v45.l20
    let v192 : US8 =
        match v186 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v188) -> (* Some *)
            let v189 : string = "justifyContent"
            let v190 : JSX.Prop = JSX.Prop (v189, v188)
            US8_1(v190)
    let v193 : US0 = v45.l21
    let v199 : US8 =
        match v193 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v195) -> (* Some *)
            let v196 : string = "left"
            let v197 : JSX.Prop = JSX.Prop (v196, v195)
            US8_1(v197)
    let v200 : US0 = v45.l22
    let v206 : US8 =
        match v200 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v202) -> (* Some *)
            let v203 : string = "lineHeight"
            let v204 : JSX.Prop = JSX.Prop (v203, v202)
            US8_1(v204)
    let v207 : US0 = v45.l23
    let v213 : US8 =
        match v207 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v209) -> (* Some *)
            let v210 : string = "margin"
            let v211 : JSX.Prop = JSX.Prop (v210, v209)
            US8_1(v211)
    let v214 : US0 = v45.l24
    let v220 : US8 =
        match v214 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v216) -> (* Some *)
            let v217 : string = "marginBottom"
            let v218 : JSX.Prop = JSX.Prop (v217, v216)
            US8_1(v218)
    let v221 : US0 = v45.l25
    let v227 : US8 =
        match v221 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v223) -> (* Some *)
            let v224 : string = "maxHeight"
            let v225 : JSX.Prop = JSX.Prop (v224, v223)
            US8_1(v225)
    let v228 : US6 = v45.l26
    let v234 : US8 =
        match v228 with
        | US6_0 -> (* None *)
            US8_0
        | US6_1(v230) -> (* Some *)
            let v231 : string = "onChange"
            let v232 : JSX.Prop = JSX.Prop (v231, v230)
            US8_1(v232)
    let v235 : US7 = v45.l27
    let v241 : US8 =
        match v235 with
        | US7_0 -> (* None *)
            US8_0
        | US7_1(v237) -> (* Some *)
            let v238 : string = "onClick"
            let v239 : JSX.Prop = JSX.Prop (v238, v237)
            US8_1(v239)
    let v242 : US0 = v45.l28
    let v248 : US8 =
        match v242 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v244) -> (* Some *)
            let v245 : string = "outline"
            let v246 : JSX.Prop = JSX.Prop (v245, v244)
            US8_1(v246)
    let v249 : US0 = v45.l29
    let v255 : US8 =
        match v249 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v251) -> (* Some *)
            let v252 : string = "overflowY"
            let v253 : JSX.Prop = JSX.Prop (v252, v251)
            US8_1(v253)
    let v256 : US0 = v45.l30
    let v262 : US8 =
        match v256 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v258) -> (* Some *)
            let v259 : string = "padding"
            let v260 : JSX.Prop = JSX.Prop (v259, v258)
            US8_1(v260)
    let v263 : US0 = v45.l31
    let v269 : US8 =
        match v263 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v265) -> (* Some *)
            let v266 : string = "paddingTop"
            let v267 : JSX.Prop = JSX.Prop (v266, v265)
            US8_1(v267)
    let v270 : US0 = v45.l32
    let v276 : US8 =
        match v270 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v272) -> (* Some *)
            let v273 : string = "position"
            let v274 : JSX.Prop = JSX.Prop (v273, v272)
            US8_1(v274)
    let v277 : US0 = v45.l33
    let v283 : US8 =
        match v277 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v279) -> (* Some *)
            let v280 : string = "right"
            let v281 : JSX.Prop = JSX.Prop (v280, v279)
            US8_1(v281)
    let v284 : US0 = v45.l34
    let v290 : US8 =
        match v284 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v286) -> (* Some *)
            let v287 : string = "size"
            let v288 : JSX.Prop = JSX.Prop (v287, v286)
            US8_1(v288)
    let v291 : US0 = v45.l35
    let v297 : US8 =
        match v291 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v293) -> (* Some *)
            let v294 : string = "spacing"
            let v295 : JSX.Prop = JSX.Prop (v294, v293)
            US8_1(v295)
    let v298 : US2 = v45.l36
    let v304 : US8 =
        match v298 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v300) -> (* Some *)
            let v301 : string = "status"
            let v302 : JSX.Prop = JSX.Prop (v301, v300)
            US8_1(v302)
    let v305 : US0 = v45.l37
    let v311 : US8 =
        match v305 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v307) -> (* Some *)
            let v308 : string = "striped"
            let v309 : JSX.Prop = JSX.Prop (v308, v307)
            US8_1(v309)
    let v312 : US0 = v45.l38
    let v318 : US8 =
        match v312 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v314) -> (* Some *)
            let v315 : string = "thickness"
            let v316 : JSX.Prop = JSX.Prop (v315, v314)
            US8_1(v316)
    let v319 : US5 = v45.l39
    let v325 : US8 =
        match v319 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v321) -> (* Some *)
            let v322 : string = "title"
            let v323 : JSX.Prop = JSX.Prop (v322, v321)
            US8_1(v323)
    let v326 : US0 = v45.l40
    let v332 : US8 =
        match v326 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v328) -> (* Some *)
            let v329 : string = "top"
            let v330 : JSX.Prop = JSX.Prop (v329, v328)
            US8_1(v330)
    let v333 : US0 = v45.l41
    let v339 : US8 =
        match v333 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v335) -> (* Some *)
            let v336 : string = "width"
            let v337 : JSX.Prop = JSX.Prop (v336, v335)
            US8_1(v337)
    let v340 : US4 = v45.l42
    let v346 : US8 =
        match v340 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v342) -> (* Some *)
            let v343 : string = "zIndex"
            let v344 : JSX.Prop = JSX.Prop (v343, v342)
            US8_1(v344)
    let v347 : (US8 []) = [|v52; v59; v66; v73; v80; v87; v94; v101; v108; v115; v122; v129; v136; v143; v150; v157; v164; v171; v178; v185; v192; v199; v206; v213; v220; v227; v234; v241; v248; v255; v262; v269; v276; v283; v290; v297; v304; v311; v318; v325; v332; v339; v346|]
    let v348 : int32 = v347.Length
    let v349 : (US8 []) = Array.zeroCreate<US8> (v348)
    let v350 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method0(v348, v350) do
        let v352 : int32 = v350.l0
        let v353 : int32 = v350.l1
        let v354 : US8 = v347.[int v352]
        let v356 : bool =
            match v354 with
            | US8_0 -> (* None *)
                false
            | US8_1(v355) -> (* Some *)
                true
        let v358 : int32 =
            if v356 then
                v349.[int v353] <- v354
                let v357 : int32 = v353 + 1
                v357
            else
                v353
        let v359 : int32 = v352 + 1
        v350.l0 <- v359
        v350.l1 <- v358
        ()
    let v360 : int32 = v350.l1
    let v361 : (US8 []) = Array.zeroCreate<US8> (v360)
    let v362 : Mut1 = {l0 = 0} : Mut1
    while method1(v360, v362) do
        let v364 : int32 = v362.l0
        let v365 : US8 = v349.[int v364]
        v361.[int v364] <- v365
        let v366 : int32 = v364 + 1
        v362.l0 <- v366
        ()
    let v367 : int32 = v361.Length
    let v368 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v367)
    let v369 : Mut1 = {l0 = 0} : Mut1
    while method1(v367, v369) do
        let v371 : int32 = v369.l0
        let v372 : US8 = v361.[int v371]
        let v375 : JSX.Prop =
            match v372 with
            | US8_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US8_1(v374) -> (* Some *)
                v374
        v368.[int v371] <- v375
        let v376 : int32 = v371 + 1
        v369.l0 <- v376
        ()
    let v377 : obj = createObj v368
    let v378 : string = "createComponent"
    let v379 : string = "solid-js"
    let v380 : JS.Function = import v378 v379
    let v381 : string = "Anchor"
    let v382 : string = "@hope-ui/solid"
    let v383 : JSX.Element = v380.Invoke ((import v381 v382), v377) |> unbox<JSX.Element>
    v383
and closure9 () () : JSX.Element =
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
    let v17 : string = "https://github.com/fc1943s/tictactoe_spiral"
    let v18 : US0 = US0_1(v17)
    let v19 : US5 = US5_0
    let v20 : US0 = US0_0
    let v21 : US0 = US0_0
    let v22 : US0 = US0_0
    let v23 : US0 = US0_0
    let v24 : US0 = US0_0
    let v25 : US0 = US0_0
    let v26 : US0 = US0_0
    let v27 : US6 = US6_0
    let v28 : US7 = US7_0
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
    let v44 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43} : Heap0
    let v45 : US0 = v44.l17
    let v46 : US0 = US0_0
    let v47 : US1 = US1_0
    let v48 : US0 = US0_0
    let v49 : US0 = US0_0
    let v50 : US0 = US0_0
    let v51 : US2 = US2_0
    let v52 : (unit -> JSX.Element) = closure6(v44)
    let v53 : US3 = US3_1(v52)
    let v54 : US0 = US0_0
    let v55 : US0 = US0_0
    let v56 : US2 = US2_0
    let v57 : US0 = US0_0
    let v58 : US0 = US0_0
    let v59 : US2 = US2_1(true)
    let v60 : US4 = US4_0
    let v61 : US0 = US0_0
    let v62 : US0 = US0_0
    let v63 : US0 = US0_0
    let v64 : US5 = US5_0
    let v65 : US0 = US0_0
    let v66 : US0 = US0_0
    let v67 : US0 = US0_0
    let v68 : US0 = US0_0
    let v69 : US0 = US0_0
    let v70 : US0 = US0_0
    let v71 : US0 = US0_0
    let v72 : US6 = US6_0
    let v73 : US7 = US7_0
    let v74 : US0 = US0_0
    let v75 : US0 = US0_0
    let v76 : US0 = US0_0
    let v77 : US0 = US0_0
    let v78 : US0 = US0_0
    let v79 : US0 = US0_0
    let v80 : US0 = US0_0
    let v81 : US0 = US0_0
    let v82 : US2 = US2_0
    let v83 : US0 = US0_0
    let v84 : US0 = US0_0
    let v85 : US5 = US5_0
    let v86 : US0 = US0_0
    let v87 : US0 = US0_0
    let v88 : US4 = US4_0
    let v89 : Heap0 = {l0 = v46; l1 = v47; l2 = v48; l3 = v49; l4 = v50; l5 = v51; l6 = v53; l7 = v54; l8 = v55; l9 = v56; l10 = v57; l11 = v58; l12 = v59; l13 = v60; l14 = v61; l15 = v62; l16 = v63; l17 = v45; l18 = v64; l19 = v65; l20 = v66; l21 = v67; l22 = v68; l23 = v69; l24 = v70; l25 = v71; l26 = v72; l27 = v73; l28 = v74; l29 = v75; l30 = v76; l31 = v77; l32 = v78; l33 = v79; l34 = v80; l35 = v81; l36 = v82; l37 = v83; l38 = v84; l39 = v85; l40 = v86; l41 = v87; l42 = v88} : Heap0
    let v90 : US0 = v89.l0
    let v96 : US8 =
        match v90 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v92) -> (* Some *)
            let v93 : string = "aria-label"
            let v94 : JSX.Prop = JSX.Prop (v93, v92)
            US8_1(v94)
    let v97 : US1 = v89.l1
    let v103 : US8 =
        match v97 with
        | US1_0 -> (* None *)
            US8_0
        | US1_1(v99) -> (* Some *)
            let v100 : string = "as"
            let v101 : JSX.Prop = JSX.Prop (v100, v99)
            US8_1(v101)
    let v104 : US0 = v89.l2
    let v110 : US8 =
        match v104 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v106) -> (* Some *)
            let v107 : string = "backgroundColor"
            let v108 : JSX.Prop = JSX.Prop (v107, v106)
            US8_1(v108)
    let v111 : US0 = v89.l3
    let v117 : US8 =
        match v111 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v113) -> (* Some *)
            let v114 : string = "border"
            let v115 : JSX.Prop = JSX.Prop (v114, v113)
            US8_1(v115)
    let v118 : US0 = v89.l4
    let v124 : US8 =
        match v118 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v120) -> (* Some *)
            let v121 : string = "bottom"
            let v122 : JSX.Prop = JSX.Prop (v121, v120)
            US8_1(v122)
    let v125 : US0 = v89.l7
    let v131 : US8 =
        match v125 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v127) -> (* Some *)
            let v128 : string = "color"
            let v129 : JSX.Prop = JSX.Prop (v128, v127)
            US8_1(v129)
    let v132 : US2 = v89.l5
    let v138 : US8 =
        match v132 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v134) -> (* Some *)
            let v135 : string = "checked"
            let v136 : JSX.Prop = JSX.Prop (v135, v134)
            US8_1(v136)
    let v139 : US3 = v89.l6
    let v145 : US8 =
        match v139 with
        | US3_0 -> (* None *)
            US8_0
        | US3_1(v141) -> (* Some *)
            let v142 : string = "children"
            let v143 : JSX.Prop = JSX.Prop (v142, v141)
            US8_1(v143)
    let v146 : US0 = v89.l8
    let v152 : US8 =
        match v146 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v148) -> (* Some *)
            let v149 : string = "colorScheme"
            let v150 : JSX.Prop = JSX.Prop (v149, v148)
            US8_1(v150)
    let v153 : US2 = v89.l9
    let v159 : US8 =
        match v153 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v155) -> (* Some *)
            let v156 : string = "compact"
            let v157 : JSX.Prop = JSX.Prop (v156, v155)
            US8_1(v157)
    let v160 : US0 = v89.l11
    let v166 : US8 =
        match v160 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v162) -> (* Some *)
            let v163 : string = "display"
            let v164 : JSX.Prop = JSX.Prop (v163, v162)
            US8_1(v164)
    let v167 : US0 = v89.l10
    let v173 : US8 =
        match v167 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v169) -> (* Some *)
            let v170 : string = "direction"
            let v171 : JSX.Prop = JSX.Prop (v170, v169)
            US8_1(v171)
    let v174 : US2 = v89.l12
    let v180 : US8 =
        match v174 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v176) -> (* Some *)
            let v177 : string = "external"
            let v178 : JSX.Prop = JSX.Prop (v177, v176)
            US8_1(v178)
    let v181 : US4 = v89.l13
    let v187 : US8 =
        match v181 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v183) -> (* Some *)
            let v184 : string = "flex"
            let v185 : JSX.Prop = JSX.Prop (v184, v183)
            US8_1(v185)
    let v188 : US0 = v89.l14
    let v194 : US8 =
        match v188 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v190) -> (* Some *)
            let v191 : string = "flexDirection"
            let v192 : JSX.Prop = JSX.Prop (v191, v190)
            US8_1(v192)
    let v195 : US0 = v89.l15
    let v201 : US8 =
        match v195 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v197) -> (* Some *)
            let v198 : string = "fontSize"
            let v199 : JSX.Prop = JSX.Prop (v198, v197)
            US8_1(v199)
    let v202 : US0 = v89.l16
    let v208 : US8 =
        match v202 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v204) -> (* Some *)
            let v205 : string = "height"
            let v206 : JSX.Prop = JSX.Prop (v205, v204)
            US8_1(v206)
    let v209 : US0 = v89.l17
    let v215 : US8 =
        match v209 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v211) -> (* Some *)
            let v212 : string = "href"
            let v213 : JSX.Prop = JSX.Prop (v212, v211)
            US8_1(v213)
    let v216 : US5 = v89.l18
    let v222 : US8 =
        match v216 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v218) -> (* Some *)
            let v219 : string = "icon"
            let v220 : JSX.Prop = JSX.Prop (v219, v218)
            US8_1(v220)
    let v223 : US0 = v89.l19
    let v229 : US8 =
        match v223 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v225) -> (* Some *)
            let v226 : string = "id"
            let v227 : JSX.Prop = JSX.Prop (v226, v225)
            US8_1(v227)
    let v230 : US0 = v89.l20
    let v236 : US8 =
        match v230 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v232) -> (* Some *)
            let v233 : string = "justifyContent"
            let v234 : JSX.Prop = JSX.Prop (v233, v232)
            US8_1(v234)
    let v237 : US0 = v89.l21
    let v243 : US8 =
        match v237 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v239) -> (* Some *)
            let v240 : string = "left"
            let v241 : JSX.Prop = JSX.Prop (v240, v239)
            US8_1(v241)
    let v244 : US0 = v89.l22
    let v250 : US8 =
        match v244 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v246) -> (* Some *)
            let v247 : string = "lineHeight"
            let v248 : JSX.Prop = JSX.Prop (v247, v246)
            US8_1(v248)
    let v251 : US0 = v89.l23
    let v257 : US8 =
        match v251 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v253) -> (* Some *)
            let v254 : string = "margin"
            let v255 : JSX.Prop = JSX.Prop (v254, v253)
            US8_1(v255)
    let v258 : US0 = v89.l24
    let v264 : US8 =
        match v258 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v260) -> (* Some *)
            let v261 : string = "marginBottom"
            let v262 : JSX.Prop = JSX.Prop (v261, v260)
            US8_1(v262)
    let v265 : US0 = v89.l25
    let v271 : US8 =
        match v265 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v267) -> (* Some *)
            let v268 : string = "maxHeight"
            let v269 : JSX.Prop = JSX.Prop (v268, v267)
            US8_1(v269)
    let v272 : US6 = v89.l26
    let v278 : US8 =
        match v272 with
        | US6_0 -> (* None *)
            US8_0
        | US6_1(v274) -> (* Some *)
            let v275 : string = "onChange"
            let v276 : JSX.Prop = JSX.Prop (v275, v274)
            US8_1(v276)
    let v279 : US7 = v89.l27
    let v285 : US8 =
        match v279 with
        | US7_0 -> (* None *)
            US8_0
        | US7_1(v281) -> (* Some *)
            let v282 : string = "onClick"
            let v283 : JSX.Prop = JSX.Prop (v282, v281)
            US8_1(v283)
    let v286 : US0 = v89.l28
    let v292 : US8 =
        match v286 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v288) -> (* Some *)
            let v289 : string = "outline"
            let v290 : JSX.Prop = JSX.Prop (v289, v288)
            US8_1(v290)
    let v293 : US0 = v89.l29
    let v299 : US8 =
        match v293 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v295) -> (* Some *)
            let v296 : string = "overflowY"
            let v297 : JSX.Prop = JSX.Prop (v296, v295)
            US8_1(v297)
    let v300 : US0 = v89.l30
    let v306 : US8 =
        match v300 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v302) -> (* Some *)
            let v303 : string = "padding"
            let v304 : JSX.Prop = JSX.Prop (v303, v302)
            US8_1(v304)
    let v307 : US0 = v89.l31
    let v313 : US8 =
        match v307 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v309) -> (* Some *)
            let v310 : string = "paddingTop"
            let v311 : JSX.Prop = JSX.Prop (v310, v309)
            US8_1(v311)
    let v314 : US0 = v89.l32
    let v320 : US8 =
        match v314 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v316) -> (* Some *)
            let v317 : string = "position"
            let v318 : JSX.Prop = JSX.Prop (v317, v316)
            US8_1(v318)
    let v321 : US0 = v89.l33
    let v327 : US8 =
        match v321 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v323) -> (* Some *)
            let v324 : string = "right"
            let v325 : JSX.Prop = JSX.Prop (v324, v323)
            US8_1(v325)
    let v328 : US0 = v89.l34
    let v334 : US8 =
        match v328 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v330) -> (* Some *)
            let v331 : string = "size"
            let v332 : JSX.Prop = JSX.Prop (v331, v330)
            US8_1(v332)
    let v335 : US0 = v89.l35
    let v341 : US8 =
        match v335 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v337) -> (* Some *)
            let v338 : string = "spacing"
            let v339 : JSX.Prop = JSX.Prop (v338, v337)
            US8_1(v339)
    let v342 : US2 = v89.l36
    let v348 : US8 =
        match v342 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v344) -> (* Some *)
            let v345 : string = "status"
            let v346 : JSX.Prop = JSX.Prop (v345, v344)
            US8_1(v346)
    let v349 : US0 = v89.l37
    let v355 : US8 =
        match v349 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v351) -> (* Some *)
            let v352 : string = "striped"
            let v353 : JSX.Prop = JSX.Prop (v352, v351)
            US8_1(v353)
    let v356 : US0 = v89.l38
    let v362 : US8 =
        match v356 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v358) -> (* Some *)
            let v359 : string = "thickness"
            let v360 : JSX.Prop = JSX.Prop (v359, v358)
            US8_1(v360)
    let v363 : US5 = v89.l39
    let v369 : US8 =
        match v363 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v365) -> (* Some *)
            let v366 : string = "title"
            let v367 : JSX.Prop = JSX.Prop (v366, v365)
            US8_1(v367)
    let v370 : US0 = v89.l40
    let v376 : US8 =
        match v370 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v372) -> (* Some *)
            let v373 : string = "top"
            let v374 : JSX.Prop = JSX.Prop (v373, v372)
            US8_1(v374)
    let v377 : US0 = v89.l41
    let v383 : US8 =
        match v377 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v379) -> (* Some *)
            let v380 : string = "width"
            let v381 : JSX.Prop = JSX.Prop (v380, v379)
            US8_1(v381)
    let v384 : US4 = v89.l42
    let v390 : US8 =
        match v384 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v386) -> (* Some *)
            let v387 : string = "zIndex"
            let v388 : JSX.Prop = JSX.Prop (v387, v386)
            US8_1(v388)
    let v391 : (US8 []) = [|v96; v103; v110; v117; v124; v131; v138; v145; v152; v159; v166; v173; v180; v187; v194; v201; v208; v215; v222; v229; v236; v243; v250; v257; v264; v271; v278; v285; v292; v299; v306; v313; v320; v327; v334; v341; v348; v355; v362; v369; v376; v383; v390|]
    let v392 : int32 = v391.Length
    let v393 : (US8 []) = Array.zeroCreate<US8> (v392)
    let v394 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method0(v392, v394) do
        let v396 : int32 = v394.l0
        let v397 : int32 = v394.l1
        let v398 : US8 = v391.[int v396]
        let v400 : bool =
            match v398 with
            | US8_0 -> (* None *)
                false
            | US8_1(v399) -> (* Some *)
                true
        let v402 : int32 =
            if v400 then
                v393.[int v397] <- v398
                let v401 : int32 = v397 + 1
                v401
            else
                v397
        let v403 : int32 = v396 + 1
        v394.l0 <- v403
        v394.l1 <- v402
        ()
    let v404 : int32 = v394.l1
    let v405 : (US8 []) = Array.zeroCreate<US8> (v404)
    let v406 : Mut1 = {l0 = 0} : Mut1
    while method1(v404, v406) do
        let v408 : int32 = v406.l0
        let v409 : US8 = v393.[int v408]
        v405.[int v408] <- v409
        let v410 : int32 = v408 + 1
        v406.l0 <- v410
        ()
    let v411 : int32 = v405.Length
    let v412 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v411)
    let v413 : Mut1 = {l0 = 0} : Mut1
    while method1(v411, v413) do
        let v415 : int32 = v413.l0
        let v416 : US8 = v405.[int v415]
        let v419 : JSX.Prop =
            match v416 with
            | US8_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US8_1(v418) -> (* Some *)
                v418
        v412.[int v415] <- v419
        let v420 : int32 = v415 + 1
        v413.l0 <- v420
        ()
    let v421 : obj = createObj v412
    let v422 : string = "createComponent"
    let v423 : string = "solid-js"
    let v424 : JS.Function = import v422 v423
    let v425 : string = "Anchor"
    let v426 : string = "@hope-ui/solid"
    let v427 : JSX.Element = v424.Invoke ((import v425 v426), v421) |> unbox<JSX.Element>
    let v428 : (JSX.Element []) = [|v427|]
    let v429 : JSX.Element = v428 |> unbox<JSX.Element>
    v429
and closure13 (v0 : JSX.Element) () : JSX.Element =
    let v1 : (JSX.Element []) = [|v0|]
    let v2 : JSX.Element = v1 |> unbox<JSX.Element>
    v2
and closure12 (v0 : JSX.Element) () : JSX.Element =
    let v1 : US0 = US0_0
    let v2 : US1 = US1_0
    let v3 : US0 = US0_0
    let v4 : US0 = US0_0
    let v5 : US0 = US0_0
    let v6 : US2 = US2_0
    let v7 : (unit -> JSX.Element) = closure13(v0)
    let v8 : US3 = US3_1(v7)
    let v9 : US0 = US0_0
    let v10 : US0 = US0_0
    let v11 : US2 = US2_0
    let v12 : US0 = US0_0
    let v13 : US0 = US0_0
    let v14 : US2 = US2_0
    let v15 : US4 = US4_0
    let v16 : US0 = US0_0
    let v17 : US0 = US0_0
    let v18 : US0 = US0_0
    let v19 : US0 = US0_0
    let v20 : US5 = US5_0
    let v21 : US0 = US0_0
    let v22 : US0 = US0_0
    let v23 : US0 = US0_0
    let v24 : US0 = US0_0
    let v25 : US0 = US0_0
    let v26 : US0 = US0_0
    let v27 : US0 = US0_0
    let v28 : US6 = US6_0
    let v29 : US7 = US7_0
    let v30 : US0 = US0_0
    let v31 : US0 = US0_0
    let v32 : US0 = US0_0
    let v33 : string = "2px"
    let v34 : US0 = US0_1(v33)
    let v35 : US0 = US0_0
    let v36 : US0 = US0_0
    let v37 : US0 = US0_0
    let v38 : US0 = US0_0
    let v39 : US2 = US2_0
    let v40 : US0 = US0_0
    let v41 : US0 = US0_0
    let v42 : US5 = US5_0
    let v43 : US0 = US0_0
    let v44 : US0 = US0_0
    let v45 : US4 = US4_0
    let v46 : Heap0 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45} : Heap0
    let v47 : US0 = v46.l0
    let v53 : US8 =
        match v47 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v49) -> (* Some *)
            let v50 : string = "aria-label"
            let v51 : JSX.Prop = JSX.Prop (v50, v49)
            US8_1(v51)
    let v54 : US1 = v46.l1
    let v60 : US8 =
        match v54 with
        | US1_0 -> (* None *)
            US8_0
        | US1_1(v56) -> (* Some *)
            let v57 : string = "as"
            let v58 : JSX.Prop = JSX.Prop (v57, v56)
            US8_1(v58)
    let v61 : US0 = v46.l2
    let v67 : US8 =
        match v61 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v63) -> (* Some *)
            let v64 : string = "backgroundColor"
            let v65 : JSX.Prop = JSX.Prop (v64, v63)
            US8_1(v65)
    let v68 : US0 = v46.l3
    let v74 : US8 =
        match v68 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v70) -> (* Some *)
            let v71 : string = "border"
            let v72 : JSX.Prop = JSX.Prop (v71, v70)
            US8_1(v72)
    let v75 : US0 = v46.l4
    let v81 : US8 =
        match v75 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v77) -> (* Some *)
            let v78 : string = "bottom"
            let v79 : JSX.Prop = JSX.Prop (v78, v77)
            US8_1(v79)
    let v82 : US0 = v46.l7
    let v88 : US8 =
        match v82 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v84) -> (* Some *)
            let v85 : string = "color"
            let v86 : JSX.Prop = JSX.Prop (v85, v84)
            US8_1(v86)
    let v89 : US2 = v46.l5
    let v95 : US8 =
        match v89 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v91) -> (* Some *)
            let v92 : string = "checked"
            let v93 : JSX.Prop = JSX.Prop (v92, v91)
            US8_1(v93)
    let v96 : US3 = v46.l6
    let v102 : US8 =
        match v96 with
        | US3_0 -> (* None *)
            US8_0
        | US3_1(v98) -> (* Some *)
            let v99 : string = "children"
            let v100 : JSX.Prop = JSX.Prop (v99, v98)
            US8_1(v100)
    let v103 : US0 = v46.l8
    let v109 : US8 =
        match v103 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v105) -> (* Some *)
            let v106 : string = "colorScheme"
            let v107 : JSX.Prop = JSX.Prop (v106, v105)
            US8_1(v107)
    let v110 : US2 = v46.l9
    let v116 : US8 =
        match v110 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v112) -> (* Some *)
            let v113 : string = "compact"
            let v114 : JSX.Prop = JSX.Prop (v113, v112)
            US8_1(v114)
    let v117 : US0 = v46.l11
    let v123 : US8 =
        match v117 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v119) -> (* Some *)
            let v120 : string = "display"
            let v121 : JSX.Prop = JSX.Prop (v120, v119)
            US8_1(v121)
    let v124 : US0 = v46.l10
    let v130 : US8 =
        match v124 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v126) -> (* Some *)
            let v127 : string = "direction"
            let v128 : JSX.Prop = JSX.Prop (v127, v126)
            US8_1(v128)
    let v131 : US2 = v46.l12
    let v137 : US8 =
        match v131 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v133) -> (* Some *)
            let v134 : string = "external"
            let v135 : JSX.Prop = JSX.Prop (v134, v133)
            US8_1(v135)
    let v138 : US4 = v46.l13
    let v144 : US8 =
        match v138 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v140) -> (* Some *)
            let v141 : string = "flex"
            let v142 : JSX.Prop = JSX.Prop (v141, v140)
            US8_1(v142)
    let v145 : US0 = v46.l14
    let v151 : US8 =
        match v145 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v147) -> (* Some *)
            let v148 : string = "flexDirection"
            let v149 : JSX.Prop = JSX.Prop (v148, v147)
            US8_1(v149)
    let v152 : US0 = v46.l15
    let v158 : US8 =
        match v152 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v154) -> (* Some *)
            let v155 : string = "fontSize"
            let v156 : JSX.Prop = JSX.Prop (v155, v154)
            US8_1(v156)
    let v159 : US0 = v46.l16
    let v165 : US8 =
        match v159 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v161) -> (* Some *)
            let v162 : string = "height"
            let v163 : JSX.Prop = JSX.Prop (v162, v161)
            US8_1(v163)
    let v166 : US0 = v46.l17
    let v172 : US8 =
        match v166 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v168) -> (* Some *)
            let v169 : string = "href"
            let v170 : JSX.Prop = JSX.Prop (v169, v168)
            US8_1(v170)
    let v173 : US5 = v46.l18
    let v179 : US8 =
        match v173 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v175) -> (* Some *)
            let v176 : string = "icon"
            let v177 : JSX.Prop = JSX.Prop (v176, v175)
            US8_1(v177)
    let v180 : US0 = v46.l19
    let v186 : US8 =
        match v180 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v182) -> (* Some *)
            let v183 : string = "id"
            let v184 : JSX.Prop = JSX.Prop (v183, v182)
            US8_1(v184)
    let v187 : US0 = v46.l20
    let v193 : US8 =
        match v187 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v189) -> (* Some *)
            let v190 : string = "justifyContent"
            let v191 : JSX.Prop = JSX.Prop (v190, v189)
            US8_1(v191)
    let v194 : US0 = v46.l21
    let v200 : US8 =
        match v194 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v196) -> (* Some *)
            let v197 : string = "left"
            let v198 : JSX.Prop = JSX.Prop (v197, v196)
            US8_1(v198)
    let v201 : US0 = v46.l22
    let v207 : US8 =
        match v201 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v203) -> (* Some *)
            let v204 : string = "lineHeight"
            let v205 : JSX.Prop = JSX.Prop (v204, v203)
            US8_1(v205)
    let v208 : US0 = v46.l23
    let v214 : US8 =
        match v208 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v210) -> (* Some *)
            let v211 : string = "margin"
            let v212 : JSX.Prop = JSX.Prop (v211, v210)
            US8_1(v212)
    let v215 : US0 = v46.l24
    let v221 : US8 =
        match v215 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v217) -> (* Some *)
            let v218 : string = "marginBottom"
            let v219 : JSX.Prop = JSX.Prop (v218, v217)
            US8_1(v219)
    let v222 : US0 = v46.l25
    let v228 : US8 =
        match v222 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v224) -> (* Some *)
            let v225 : string = "maxHeight"
            let v226 : JSX.Prop = JSX.Prop (v225, v224)
            US8_1(v226)
    let v229 : US6 = v46.l26
    let v235 : US8 =
        match v229 with
        | US6_0 -> (* None *)
            US8_0
        | US6_1(v231) -> (* Some *)
            let v232 : string = "onChange"
            let v233 : JSX.Prop = JSX.Prop (v232, v231)
            US8_1(v233)
    let v236 : US7 = v46.l27
    let v242 : US8 =
        match v236 with
        | US7_0 -> (* None *)
            US8_0
        | US7_1(v238) -> (* Some *)
            let v239 : string = "onClick"
            let v240 : JSX.Prop = JSX.Prop (v239, v238)
            US8_1(v240)
    let v243 : US0 = v46.l28
    let v249 : US8 =
        match v243 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v245) -> (* Some *)
            let v246 : string = "outline"
            let v247 : JSX.Prop = JSX.Prop (v246, v245)
            US8_1(v247)
    let v250 : US0 = v46.l29
    let v256 : US8 =
        match v250 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v252) -> (* Some *)
            let v253 : string = "overflowY"
            let v254 : JSX.Prop = JSX.Prop (v253, v252)
            US8_1(v254)
    let v257 : US0 = v46.l30
    let v263 : US8 =
        match v257 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v259) -> (* Some *)
            let v260 : string = "padding"
            let v261 : JSX.Prop = JSX.Prop (v260, v259)
            US8_1(v261)
    let v264 : US0 = v46.l31
    let v270 : US8 =
        match v264 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v266) -> (* Some *)
            let v267 : string = "paddingTop"
            let v268 : JSX.Prop = JSX.Prop (v267, v266)
            US8_1(v268)
    let v271 : US0 = v46.l32
    let v277 : US8 =
        match v271 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v273) -> (* Some *)
            let v274 : string = "position"
            let v275 : JSX.Prop = JSX.Prop (v274, v273)
            US8_1(v275)
    let v278 : US0 = v46.l33
    let v284 : US8 =
        match v278 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v280) -> (* Some *)
            let v281 : string = "right"
            let v282 : JSX.Prop = JSX.Prop (v281, v280)
            US8_1(v282)
    let v285 : US0 = v46.l34
    let v291 : US8 =
        match v285 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v287) -> (* Some *)
            let v288 : string = "size"
            let v289 : JSX.Prop = JSX.Prop (v288, v287)
            US8_1(v289)
    let v292 : US0 = v46.l35
    let v298 : US8 =
        match v292 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v294) -> (* Some *)
            let v295 : string = "spacing"
            let v296 : JSX.Prop = JSX.Prop (v295, v294)
            US8_1(v296)
    let v299 : US2 = v46.l36
    let v305 : US8 =
        match v299 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v301) -> (* Some *)
            let v302 : string = "status"
            let v303 : JSX.Prop = JSX.Prop (v302, v301)
            US8_1(v303)
    let v306 : US0 = v46.l37
    let v312 : US8 =
        match v306 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v308) -> (* Some *)
            let v309 : string = "striped"
            let v310 : JSX.Prop = JSX.Prop (v309, v308)
            US8_1(v310)
    let v313 : US0 = v46.l38
    let v319 : US8 =
        match v313 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v315) -> (* Some *)
            let v316 : string = "thickness"
            let v317 : JSX.Prop = JSX.Prop (v316, v315)
            US8_1(v317)
    let v320 : US5 = v46.l39
    let v326 : US8 =
        match v320 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v322) -> (* Some *)
            let v323 : string = "title"
            let v324 : JSX.Prop = JSX.Prop (v323, v322)
            US8_1(v324)
    let v327 : US0 = v46.l40
    let v333 : US8 =
        match v327 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v329) -> (* Some *)
            let v330 : string = "top"
            let v331 : JSX.Prop = JSX.Prop (v330, v329)
            US8_1(v331)
    let v334 : US0 = v46.l41
    let v340 : US8 =
        match v334 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v336) -> (* Some *)
            let v337 : string = "width"
            let v338 : JSX.Prop = JSX.Prop (v337, v336)
            US8_1(v338)
    let v341 : US4 = v46.l42
    let v347 : US8 =
        match v341 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v343) -> (* Some *)
            let v344 : string = "zIndex"
            let v345 : JSX.Prop = JSX.Prop (v344, v343)
            US8_1(v345)
    let v348 : (US8 []) = [|v53; v60; v67; v74; v81; v88; v95; v102; v109; v116; v123; v130; v137; v144; v151; v158; v165; v172; v179; v186; v193; v200; v207; v214; v221; v228; v235; v242; v249; v256; v263; v270; v277; v284; v291; v298; v305; v312; v319; v326; v333; v340; v347|]
    let v349 : int32 = v348.Length
    let v350 : (US8 []) = Array.zeroCreate<US8> (v349)
    let v351 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method0(v349, v351) do
        let v353 : int32 = v351.l0
        let v354 : int32 = v351.l1
        let v355 : US8 = v348.[int v353]
        let v357 : bool =
            match v355 with
            | US8_0 -> (* None *)
                false
            | US8_1(v356) -> (* Some *)
                true
        let v359 : int32 =
            if v357 then
                v350.[int v354] <- v355
                let v358 : int32 = v354 + 1
                v358
            else
                v354
        let v360 : int32 = v353 + 1
        v351.l0 <- v360
        v351.l1 <- v359
        ()
    let v361 : int32 = v351.l1
    let v362 : (US8 []) = Array.zeroCreate<US8> (v361)
    let v363 : Mut1 = {l0 = 0} : Mut1
    while method1(v361, v363) do
        let v365 : int32 = v363.l0
        let v366 : US8 = v350.[int v365]
        v362.[int v365] <- v366
        let v367 : int32 = v365 + 1
        v363.l0 <- v367
        ()
    let v368 : int32 = v362.Length
    let v369 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v368)
    let v370 : Mut1 = {l0 = 0} : Mut1
    while method1(v368, v370) do
        let v372 : int32 = v370.l0
        let v373 : US8 = v362.[int v372]
        let v376 : JSX.Prop =
            match v373 with
            | US8_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US8_1(v375) -> (* Some *)
                v375
        v369.[int v372] <- v376
        let v377 : int32 = v372 + 1
        v370.l0 <- v377
        ()
    let v378 : obj = createObj v369
    let v379 : string = "createComponent"
    let v380 : string = "solid-js"
    let v381 : JS.Function = import v379 v380
    let v382 : string = "Box"
    let v383 : string = "@hope-ui/solid"
    let v384 : JSX.Element = v381.Invoke ((import v382 v383), v378) |> unbox<JSX.Element>
    let v385 : (JSX.Element []) = [|v384|]
    let v386 : JSX.Element = v385 |> unbox<JSX.Element>
    v386
and closure14 (v0 : (bool -> unit)) (v1 : obj) : unit =
    let v2 : bool = v1?target?checked
    v0 v2
    ()
and closure11 (v0 : Heap0, v1 : (bool -> unit), v2 : (unit -> bool), v3 : JSX.Element) () : JSX.Element =
    let v4 : US2 = v0.l36
    let v394 : JSX.Element =
        match v4 with
        | US2_0 -> (* None *)
            v3
        | US2_1(v5) -> (* Some *)
            let v6 : bool = v2 ()
            let v7 : US0 = US0_0
            let v8 : US1 = US1_0
            let v9 : US0 = US0_0
            let v10 : US0 = US0_0
            let v11 : US0 = US0_0
            let v12 : US2 = US2_1(v6)
            let v13 : (unit -> JSX.Element) = closure12(v3)
            let v14 : US3 = US3_1(v13)
            let v15 : US0 = US0_0
            let v16 : string = "neutral"
            let v17 : US0 = US0_1(v16)
            let v18 : US2 = US2_0
            let v19 : US0 = US0_0
            let v20 : US0 = US0_0
            let v21 : US2 = US2_0
            let v22 : US4 = US4_0
            let v23 : US0 = US0_0
            let v24 : US0 = US0_0
            let v25 : US0 = US0_0
            let v26 : US0 = US0_0
            let v27 : US5 = US5_0
            let v28 : US0 = US0_0
            let v29 : US0 = US0_0
            let v30 : US0 = US0_0
            let v31 : US0 = US0_0
            let v32 : US0 = US0_0
            let v33 : string = "2px"
            let v34 : US0 = US0_1(v33)
            let v35 : US0 = US0_0
            let v36 : (obj -> unit) = closure14(v1)
            let v37 : US6 = US6_1(v36)
            let v38 : US7 = US7_0
            let v39 : US0 = US0_0
            let v40 : US0 = US0_0
            let v41 : US0 = US0_0
            let v42 : US0 = US0_0
            let v43 : US0 = US0_0
            let v44 : US0 = US0_0
            let v45 : string = "sm"
            let v46 : US0 = US0_1(v45)
            let v47 : US0 = US0_0
            let v48 : US2 = US2_0
            let v49 : US0 = US0_0
            let v50 : US0 = US0_0
            let v51 : US5 = US5_0
            let v52 : US0 = US0_0
            let v53 : US0 = US0_0
            let v54 : US4 = US4_0
            let v55 : Heap0 = {l0 = v7; l1 = v8; l2 = v9; l3 = v10; l4 = v11; l5 = v12; l6 = v14; l7 = v15; l8 = v17; l9 = v18; l10 = v19; l11 = v20; l12 = v21; l13 = v22; l14 = v23; l15 = v24; l16 = v25; l17 = v26; l18 = v27; l19 = v28; l20 = v29; l21 = v30; l22 = v31; l23 = v32; l24 = v34; l25 = v35; l26 = v37; l27 = v38; l28 = v39; l29 = v40; l30 = v41; l31 = v42; l32 = v43; l33 = v44; l34 = v46; l35 = v47; l36 = v48; l37 = v49; l38 = v50; l39 = v51; l40 = v52; l41 = v53; l42 = v54} : Heap0
            let v56 : US0 = v55.l0
            let v62 : US8 =
                match v56 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v58) -> (* Some *)
                    let v59 : string = "aria-label"
                    let v60 : JSX.Prop = JSX.Prop (v59, v58)
                    US8_1(v60)
            let v63 : US1 = v55.l1
            let v69 : US8 =
                match v63 with
                | US1_0 -> (* None *)
                    US8_0
                | US1_1(v65) -> (* Some *)
                    let v66 : string = "as"
                    let v67 : JSX.Prop = JSX.Prop (v66, v65)
                    US8_1(v67)
            let v70 : US0 = v55.l2
            let v76 : US8 =
                match v70 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v72) -> (* Some *)
                    let v73 : string = "backgroundColor"
                    let v74 : JSX.Prop = JSX.Prop (v73, v72)
                    US8_1(v74)
            let v77 : US0 = v55.l3
            let v83 : US8 =
                match v77 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v79) -> (* Some *)
                    let v80 : string = "border"
                    let v81 : JSX.Prop = JSX.Prop (v80, v79)
                    US8_1(v81)
            let v84 : US0 = v55.l4
            let v90 : US8 =
                match v84 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v86) -> (* Some *)
                    let v87 : string = "bottom"
                    let v88 : JSX.Prop = JSX.Prop (v87, v86)
                    US8_1(v88)
            let v91 : US0 = v55.l7
            let v97 : US8 =
                match v91 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v93) -> (* Some *)
                    let v94 : string = "color"
                    let v95 : JSX.Prop = JSX.Prop (v94, v93)
                    US8_1(v95)
            let v98 : US2 = v55.l5
            let v104 : US8 =
                match v98 with
                | US2_0 -> (* None *)
                    US8_0
                | US2_1(v100) -> (* Some *)
                    let v101 : string = "checked"
                    let v102 : JSX.Prop = JSX.Prop (v101, v100)
                    US8_1(v102)
            let v105 : US3 = v55.l6
            let v111 : US8 =
                match v105 with
                | US3_0 -> (* None *)
                    US8_0
                | US3_1(v107) -> (* Some *)
                    let v108 : string = "children"
                    let v109 : JSX.Prop = JSX.Prop (v108, v107)
                    US8_1(v109)
            let v112 : US0 = v55.l8
            let v118 : US8 =
                match v112 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v114) -> (* Some *)
                    let v115 : string = "colorScheme"
                    let v116 : JSX.Prop = JSX.Prop (v115, v114)
                    US8_1(v116)
            let v119 : US2 = v55.l9
            let v125 : US8 =
                match v119 with
                | US2_0 -> (* None *)
                    US8_0
                | US2_1(v121) -> (* Some *)
                    let v122 : string = "compact"
                    let v123 : JSX.Prop = JSX.Prop (v122, v121)
                    US8_1(v123)
            let v126 : US0 = v55.l11
            let v132 : US8 =
                match v126 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v128) -> (* Some *)
                    let v129 : string = "display"
                    let v130 : JSX.Prop = JSX.Prop (v129, v128)
                    US8_1(v130)
            let v133 : US0 = v55.l10
            let v139 : US8 =
                match v133 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v135) -> (* Some *)
                    let v136 : string = "direction"
                    let v137 : JSX.Prop = JSX.Prop (v136, v135)
                    US8_1(v137)
            let v140 : US2 = v55.l12
            let v146 : US8 =
                match v140 with
                | US2_0 -> (* None *)
                    US8_0
                | US2_1(v142) -> (* Some *)
                    let v143 : string = "external"
                    let v144 : JSX.Prop = JSX.Prop (v143, v142)
                    US8_1(v144)
            let v147 : US4 = v55.l13
            let v153 : US8 =
                match v147 with
                | US4_0 -> (* None *)
                    US8_0
                | US4_1(v149) -> (* Some *)
                    let v150 : string = "flex"
                    let v151 : JSX.Prop = JSX.Prop (v150, v149)
                    US8_1(v151)
            let v154 : US0 = v55.l14
            let v160 : US8 =
                match v154 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v156) -> (* Some *)
                    let v157 : string = "flexDirection"
                    let v158 : JSX.Prop = JSX.Prop (v157, v156)
                    US8_1(v158)
            let v161 : US0 = v55.l15
            let v167 : US8 =
                match v161 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v163) -> (* Some *)
                    let v164 : string = "fontSize"
                    let v165 : JSX.Prop = JSX.Prop (v164, v163)
                    US8_1(v165)
            let v168 : US0 = v55.l16
            let v174 : US8 =
                match v168 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v170) -> (* Some *)
                    let v171 : string = "height"
                    let v172 : JSX.Prop = JSX.Prop (v171, v170)
                    US8_1(v172)
            let v175 : US0 = v55.l17
            let v181 : US8 =
                match v175 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v177) -> (* Some *)
                    let v178 : string = "href"
                    let v179 : JSX.Prop = JSX.Prop (v178, v177)
                    US8_1(v179)
            let v182 : US5 = v55.l18
            let v188 : US8 =
                match v182 with
                | US5_0 -> (* None *)
                    US8_0
                | US5_1(v184) -> (* Some *)
                    let v185 : string = "icon"
                    let v186 : JSX.Prop = JSX.Prop (v185, v184)
                    US8_1(v186)
            let v189 : US0 = v55.l19
            let v195 : US8 =
                match v189 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v191) -> (* Some *)
                    let v192 : string = "id"
                    let v193 : JSX.Prop = JSX.Prop (v192, v191)
                    US8_1(v193)
            let v196 : US0 = v55.l20
            let v202 : US8 =
                match v196 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v198) -> (* Some *)
                    let v199 : string = "justifyContent"
                    let v200 : JSX.Prop = JSX.Prop (v199, v198)
                    US8_1(v200)
            let v203 : US0 = v55.l21
            let v209 : US8 =
                match v203 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v205) -> (* Some *)
                    let v206 : string = "left"
                    let v207 : JSX.Prop = JSX.Prop (v206, v205)
                    US8_1(v207)
            let v210 : US0 = v55.l22
            let v216 : US8 =
                match v210 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v212) -> (* Some *)
                    let v213 : string = "lineHeight"
                    let v214 : JSX.Prop = JSX.Prop (v213, v212)
                    US8_1(v214)
            let v217 : US0 = v55.l23
            let v223 : US8 =
                match v217 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v219) -> (* Some *)
                    let v220 : string = "margin"
                    let v221 : JSX.Prop = JSX.Prop (v220, v219)
                    US8_1(v221)
            let v224 : US0 = v55.l24
            let v230 : US8 =
                match v224 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v226) -> (* Some *)
                    let v227 : string = "marginBottom"
                    let v228 : JSX.Prop = JSX.Prop (v227, v226)
                    US8_1(v228)
            let v231 : US0 = v55.l25
            let v237 : US8 =
                match v231 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v233) -> (* Some *)
                    let v234 : string = "maxHeight"
                    let v235 : JSX.Prop = JSX.Prop (v234, v233)
                    US8_1(v235)
            let v238 : US6 = v55.l26
            let v244 : US8 =
                match v238 with
                | US6_0 -> (* None *)
                    US8_0
                | US6_1(v240) -> (* Some *)
                    let v241 : string = "onChange"
                    let v242 : JSX.Prop = JSX.Prop (v241, v240)
                    US8_1(v242)
            let v245 : US7 = v55.l27
            let v251 : US8 =
                match v245 with
                | US7_0 -> (* None *)
                    US8_0
                | US7_1(v247) -> (* Some *)
                    let v248 : string = "onClick"
                    let v249 : JSX.Prop = JSX.Prop (v248, v247)
                    US8_1(v249)
            let v252 : US0 = v55.l28
            let v258 : US8 =
                match v252 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v254) -> (* Some *)
                    let v255 : string = "outline"
                    let v256 : JSX.Prop = JSX.Prop (v255, v254)
                    US8_1(v256)
            let v259 : US0 = v55.l29
            let v265 : US8 =
                match v259 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v261) -> (* Some *)
                    let v262 : string = "overflowY"
                    let v263 : JSX.Prop = JSX.Prop (v262, v261)
                    US8_1(v263)
            let v266 : US0 = v55.l30
            let v272 : US8 =
                match v266 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v268) -> (* Some *)
                    let v269 : string = "padding"
                    let v270 : JSX.Prop = JSX.Prop (v269, v268)
                    US8_1(v270)
            let v273 : US0 = v55.l31
            let v279 : US8 =
                match v273 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v275) -> (* Some *)
                    let v276 : string = "paddingTop"
                    let v277 : JSX.Prop = JSX.Prop (v276, v275)
                    US8_1(v277)
            let v280 : US0 = v55.l32
            let v286 : US8 =
                match v280 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v282) -> (* Some *)
                    let v283 : string = "position"
                    let v284 : JSX.Prop = JSX.Prop (v283, v282)
                    US8_1(v284)
            let v287 : US0 = v55.l33
            let v293 : US8 =
                match v287 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v289) -> (* Some *)
                    let v290 : string = "right"
                    let v291 : JSX.Prop = JSX.Prop (v290, v289)
                    US8_1(v291)
            let v294 : US0 = v55.l34
            let v300 : US8 =
                match v294 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v296) -> (* Some *)
                    let v297 : string = "size"
                    let v298 : JSX.Prop = JSX.Prop (v297, v296)
                    US8_1(v298)
            let v301 : US0 = v55.l35
            let v307 : US8 =
                match v301 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v303) -> (* Some *)
                    let v304 : string = "spacing"
                    let v305 : JSX.Prop = JSX.Prop (v304, v303)
                    US8_1(v305)
            let v308 : US2 = v55.l36
            let v314 : US8 =
                match v308 with
                | US2_0 -> (* None *)
                    US8_0
                | US2_1(v310) -> (* Some *)
                    let v311 : string = "status"
                    let v312 : JSX.Prop = JSX.Prop (v311, v310)
                    US8_1(v312)
            let v315 : US0 = v55.l37
            let v321 : US8 =
                match v315 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v317) -> (* Some *)
                    let v318 : string = "striped"
                    let v319 : JSX.Prop = JSX.Prop (v318, v317)
                    US8_1(v319)
            let v322 : US0 = v55.l38
            let v328 : US8 =
                match v322 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v324) -> (* Some *)
                    let v325 : string = "thickness"
                    let v326 : JSX.Prop = JSX.Prop (v325, v324)
                    US8_1(v326)
            let v329 : US5 = v55.l39
            let v335 : US8 =
                match v329 with
                | US5_0 -> (* None *)
                    US8_0
                | US5_1(v331) -> (* Some *)
                    let v332 : string = "title"
                    let v333 : JSX.Prop = JSX.Prop (v332, v331)
                    US8_1(v333)
            let v336 : US0 = v55.l40
            let v342 : US8 =
                match v336 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v338) -> (* Some *)
                    let v339 : string = "top"
                    let v340 : JSX.Prop = JSX.Prop (v339, v338)
                    US8_1(v340)
            let v343 : US0 = v55.l41
            let v349 : US8 =
                match v343 with
                | US0_0 -> (* None *)
                    US8_0
                | US0_1(v345) -> (* Some *)
                    let v346 : string = "width"
                    let v347 : JSX.Prop = JSX.Prop (v346, v345)
                    US8_1(v347)
            let v350 : US4 = v55.l42
            let v356 : US8 =
                match v350 with
                | US4_0 -> (* None *)
                    US8_0
                | US4_1(v352) -> (* Some *)
                    let v353 : string = "zIndex"
                    let v354 : JSX.Prop = JSX.Prop (v353, v352)
                    US8_1(v354)
            let v357 : (US8 []) = [|v62; v69; v76; v83; v90; v97; v104; v111; v118; v125; v132; v139; v146; v153; v160; v167; v174; v181; v188; v195; v202; v209; v216; v223; v230; v237; v244; v251; v258; v265; v272; v279; v286; v293; v300; v307; v314; v321; v328; v335; v342; v349; v356|]
            let v358 : int32 = v357.Length
            let v359 : (US8 []) = Array.zeroCreate<US8> (v358)
            let v360 : Mut0 = {l0 = 0; l1 = 0} : Mut0
            while method0(v358, v360) do
                let v362 : int32 = v360.l0
                let v363 : int32 = v360.l1
                let v364 : US8 = v357.[int v362]
                let v366 : bool =
                    match v364 with
                    | US8_0 -> (* None *)
                        false
                    | US8_1(v365) -> (* Some *)
                        true
                let v368 : int32 =
                    if v366 then
                        v359.[int v363] <- v364
                        let v367 : int32 = v363 + 1
                        v367
                    else
                        v363
                let v369 : int32 = v362 + 1
                v360.l0 <- v369
                v360.l1 <- v368
                ()
            let v370 : int32 = v360.l1
            let v371 : (US8 []) = Array.zeroCreate<US8> (v370)
            let v372 : Mut1 = {l0 = 0} : Mut1
            while method1(v370, v372) do
                let v374 : int32 = v372.l0
                let v375 : US8 = v359.[int v374]
                v371.[int v374] <- v375
                let v376 : int32 = v374 + 1
                v372.l0 <- v376
                ()
            let v377 : int32 = v371.Length
            let v378 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v377)
            let v379 : Mut1 = {l0 = 0} : Mut1
            while method1(v377, v379) do
                let v381 : int32 = v379.l0
                let v382 : US8 = v371.[int v381]
                let v385 : JSX.Prop =
                    match v382 with
                    | US8_0 -> (* None *)
                        failwith<JSX.Prop> "Option does not have a value."
                    | US8_1(v384) -> (* Some *)
                        v384
                v378.[int v381] <- v385
                let v386 : int32 = v381 + 1
                v379.l0 <- v386
                ()
            let v387 : obj = createObj v378
            let v388 : string = "createComponent"
            let v389 : string = "solid-js"
            let v390 : JS.Function = import v388 v389
            let v391 : string = "Checkbox"
            let v392 : string = "@hope-ui/solid"
            let v393 : JSX.Element = v390.Invoke ((import v391 v392), v387) |> unbox<JSX.Element>
            v393
    let v395 : (JSX.Element []) = [|v394|]
    let v396 : JSX.Element = v395 |> unbox<JSX.Element>
    v396
and closure15 () (v0 : Heap0) : JSX.Element =
    let v1 : US0 = v0.l0
    let v7 : US8 =
        match v1 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v3) -> (* Some *)
            let v4 : string = "aria-label"
            let v5 : JSX.Prop = JSX.Prop (v4, v3)
            US8_1(v5)
    let v8 : US1 = v0.l1
    let v14 : US8 =
        match v8 with
        | US1_0 -> (* None *)
            US8_0
        | US1_1(v10) -> (* Some *)
            let v11 : string = "as"
            let v12 : JSX.Prop = JSX.Prop (v11, v10)
            US8_1(v12)
    let v15 : US0 = v0.l2
    let v21 : US8 =
        match v15 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v17) -> (* Some *)
            let v18 : string = "backgroundColor"
            let v19 : JSX.Prop = JSX.Prop (v18, v17)
            US8_1(v19)
    let v22 : US0 = v0.l3
    let v28 : US8 =
        match v22 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v24) -> (* Some *)
            let v25 : string = "border"
            let v26 : JSX.Prop = JSX.Prop (v25, v24)
            US8_1(v26)
    let v29 : US0 = v0.l4
    let v35 : US8 =
        match v29 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v31) -> (* Some *)
            let v32 : string = "bottom"
            let v33 : JSX.Prop = JSX.Prop (v32, v31)
            US8_1(v33)
    let v36 : US0 = v0.l7
    let v42 : US8 =
        match v36 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v38) -> (* Some *)
            let v39 : string = "color"
            let v40 : JSX.Prop = JSX.Prop (v39, v38)
            US8_1(v40)
    let v43 : US2 = v0.l5
    let v49 : US8 =
        match v43 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v45) -> (* Some *)
            let v46 : string = "checked"
            let v47 : JSX.Prop = JSX.Prop (v46, v45)
            US8_1(v47)
    let v50 : US3 = v0.l6
    let v56 : US8 =
        match v50 with
        | US3_0 -> (* None *)
            US8_0
        | US3_1(v52) -> (* Some *)
            let v53 : string = "children"
            let v54 : JSX.Prop = JSX.Prop (v53, v52)
            US8_1(v54)
    let v57 : US0 = v0.l8
    let v63 : US8 =
        match v57 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v59) -> (* Some *)
            let v60 : string = "colorScheme"
            let v61 : JSX.Prop = JSX.Prop (v60, v59)
            US8_1(v61)
    let v64 : US2 = v0.l9
    let v70 : US8 =
        match v64 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v66) -> (* Some *)
            let v67 : string = "compact"
            let v68 : JSX.Prop = JSX.Prop (v67, v66)
            US8_1(v68)
    let v71 : US0 = v0.l11
    let v77 : US8 =
        match v71 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v73) -> (* Some *)
            let v74 : string = "display"
            let v75 : JSX.Prop = JSX.Prop (v74, v73)
            US8_1(v75)
    let v78 : US0 = v0.l10
    let v84 : US8 =
        match v78 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v80) -> (* Some *)
            let v81 : string = "direction"
            let v82 : JSX.Prop = JSX.Prop (v81, v80)
            US8_1(v82)
    let v85 : US2 = v0.l12
    let v91 : US8 =
        match v85 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v87) -> (* Some *)
            let v88 : string = "external"
            let v89 : JSX.Prop = JSX.Prop (v88, v87)
            US8_1(v89)
    let v92 : US4 = v0.l13
    let v98 : US8 =
        match v92 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v94) -> (* Some *)
            let v95 : string = "flex"
            let v96 : JSX.Prop = JSX.Prop (v95, v94)
            US8_1(v96)
    let v99 : US0 = v0.l14
    let v105 : US8 =
        match v99 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v101) -> (* Some *)
            let v102 : string = "flexDirection"
            let v103 : JSX.Prop = JSX.Prop (v102, v101)
            US8_1(v103)
    let v106 : US0 = v0.l15
    let v112 : US8 =
        match v106 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v108) -> (* Some *)
            let v109 : string = "fontSize"
            let v110 : JSX.Prop = JSX.Prop (v109, v108)
            US8_1(v110)
    let v113 : US0 = v0.l16
    let v119 : US8 =
        match v113 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v115) -> (* Some *)
            let v116 : string = "height"
            let v117 : JSX.Prop = JSX.Prop (v116, v115)
            US8_1(v117)
    let v120 : US0 = v0.l17
    let v126 : US8 =
        match v120 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v122) -> (* Some *)
            let v123 : string = "href"
            let v124 : JSX.Prop = JSX.Prop (v123, v122)
            US8_1(v124)
    let v127 : US5 = v0.l18
    let v133 : US8 =
        match v127 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v129) -> (* Some *)
            let v130 : string = "icon"
            let v131 : JSX.Prop = JSX.Prop (v130, v129)
            US8_1(v131)
    let v134 : US0 = v0.l19
    let v140 : US8 =
        match v134 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v136) -> (* Some *)
            let v137 : string = "id"
            let v138 : JSX.Prop = JSX.Prop (v137, v136)
            US8_1(v138)
    let v141 : US0 = v0.l20
    let v147 : US8 =
        match v141 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v143) -> (* Some *)
            let v144 : string = "justifyContent"
            let v145 : JSX.Prop = JSX.Prop (v144, v143)
            US8_1(v145)
    let v148 : US0 = v0.l21
    let v154 : US8 =
        match v148 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v150) -> (* Some *)
            let v151 : string = "left"
            let v152 : JSX.Prop = JSX.Prop (v151, v150)
            US8_1(v152)
    let v155 : US0 = v0.l22
    let v161 : US8 =
        match v155 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v157) -> (* Some *)
            let v158 : string = "lineHeight"
            let v159 : JSX.Prop = JSX.Prop (v158, v157)
            US8_1(v159)
    let v162 : US0 = v0.l23
    let v168 : US8 =
        match v162 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v164) -> (* Some *)
            let v165 : string = "margin"
            let v166 : JSX.Prop = JSX.Prop (v165, v164)
            US8_1(v166)
    let v169 : US0 = v0.l24
    let v175 : US8 =
        match v169 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v171) -> (* Some *)
            let v172 : string = "marginBottom"
            let v173 : JSX.Prop = JSX.Prop (v172, v171)
            US8_1(v173)
    let v176 : US0 = v0.l25
    let v182 : US8 =
        match v176 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v178) -> (* Some *)
            let v179 : string = "maxHeight"
            let v180 : JSX.Prop = JSX.Prop (v179, v178)
            US8_1(v180)
    let v183 : US6 = v0.l26
    let v189 : US8 =
        match v183 with
        | US6_0 -> (* None *)
            US8_0
        | US6_1(v185) -> (* Some *)
            let v186 : string = "onChange"
            let v187 : JSX.Prop = JSX.Prop (v186, v185)
            US8_1(v187)
    let v190 : US7 = v0.l27
    let v196 : US8 =
        match v190 with
        | US7_0 -> (* None *)
            US8_0
        | US7_1(v192) -> (* Some *)
            let v193 : string = "onClick"
            let v194 : JSX.Prop = JSX.Prop (v193, v192)
            US8_1(v194)
    let v197 : US0 = v0.l28
    let v203 : US8 =
        match v197 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v199) -> (* Some *)
            let v200 : string = "outline"
            let v201 : JSX.Prop = JSX.Prop (v200, v199)
            US8_1(v201)
    let v204 : US0 = v0.l29
    let v210 : US8 =
        match v204 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v206) -> (* Some *)
            let v207 : string = "overflowY"
            let v208 : JSX.Prop = JSX.Prop (v207, v206)
            US8_1(v208)
    let v211 : US0 = v0.l30
    let v217 : US8 =
        match v211 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v213) -> (* Some *)
            let v214 : string = "padding"
            let v215 : JSX.Prop = JSX.Prop (v214, v213)
            US8_1(v215)
    let v218 : US0 = v0.l31
    let v224 : US8 =
        match v218 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v220) -> (* Some *)
            let v221 : string = "paddingTop"
            let v222 : JSX.Prop = JSX.Prop (v221, v220)
            US8_1(v222)
    let v225 : US0 = v0.l32
    let v231 : US8 =
        match v225 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v227) -> (* Some *)
            let v228 : string = "position"
            let v229 : JSX.Prop = JSX.Prop (v228, v227)
            US8_1(v229)
    let v232 : US0 = v0.l33
    let v238 : US8 =
        match v232 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v234) -> (* Some *)
            let v235 : string = "right"
            let v236 : JSX.Prop = JSX.Prop (v235, v234)
            US8_1(v236)
    let v239 : US0 = v0.l34
    let v245 : US8 =
        match v239 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v241) -> (* Some *)
            let v242 : string = "size"
            let v243 : JSX.Prop = JSX.Prop (v242, v241)
            US8_1(v243)
    let v246 : US0 = v0.l35
    let v252 : US8 =
        match v246 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v248) -> (* Some *)
            let v249 : string = "spacing"
            let v250 : JSX.Prop = JSX.Prop (v249, v248)
            US8_1(v250)
    let v253 : US2 = v0.l36
    let v259 : US8 =
        match v253 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v255) -> (* Some *)
            let v256 : string = "status"
            let v257 : JSX.Prop = JSX.Prop (v256, v255)
            US8_1(v257)
    let v260 : US0 = v0.l37
    let v266 : US8 =
        match v260 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v262) -> (* Some *)
            let v263 : string = "striped"
            let v264 : JSX.Prop = JSX.Prop (v263, v262)
            US8_1(v264)
    let v267 : US0 = v0.l38
    let v273 : US8 =
        match v267 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v269) -> (* Some *)
            let v270 : string = "thickness"
            let v271 : JSX.Prop = JSX.Prop (v270, v269)
            US8_1(v271)
    let v274 : US5 = v0.l39
    let v280 : US8 =
        match v274 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v276) -> (* Some *)
            let v277 : string = "title"
            let v278 : JSX.Prop = JSX.Prop (v277, v276)
            US8_1(v278)
    let v281 : US0 = v0.l40
    let v287 : US8 =
        match v281 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v283) -> (* Some *)
            let v284 : string = "top"
            let v285 : JSX.Prop = JSX.Prop (v284, v283)
            US8_1(v285)
    let v288 : US0 = v0.l41
    let v294 : US8 =
        match v288 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v290) -> (* Some *)
            let v291 : string = "width"
            let v292 : JSX.Prop = JSX.Prop (v291, v290)
            US8_1(v292)
    let v295 : US4 = v0.l42
    let v301 : US8 =
        match v295 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v297) -> (* Some *)
            let v298 : string = "zIndex"
            let v299 : JSX.Prop = JSX.Prop (v298, v297)
            US8_1(v299)
    let v302 : (US8 []) = [|v7; v14; v21; v28; v35; v42; v49; v56; v63; v70; v77; v84; v91; v98; v105; v112; v119; v126; v133; v140; v147; v154; v161; v168; v175; v182; v189; v196; v203; v210; v217; v224; v231; v238; v245; v252; v259; v266; v273; v280; v287; v294; v301|]
    let v303 : int32 = v302.Length
    let v304 : (US8 []) = Array.zeroCreate<US8> (v303)
    let v305 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method0(v303, v305) do
        let v307 : int32 = v305.l0
        let v308 : int32 = v305.l1
        let v309 : US8 = v302.[int v307]
        let v311 : bool =
            match v309 with
            | US8_0 -> (* None *)
                false
            | US8_1(v310) -> (* Some *)
                true
        let v313 : int32 =
            if v311 then
                v304.[int v308] <- v309
                let v312 : int32 = v308 + 1
                v312
            else
                v308
        let v314 : int32 = v307 + 1
        v305.l0 <- v314
        v305.l1 <- v313
        ()
    let v315 : int32 = v305.l1
    let v316 : (US8 []) = Array.zeroCreate<US8> (v315)
    let v317 : Mut1 = {l0 = 0} : Mut1
    while method1(v315, v317) do
        let v319 : int32 = v317.l0
        let v320 : US8 = v304.[int v319]
        v316.[int v319] <- v320
        let v321 : int32 = v319 + 1
        v317.l0 <- v321
        ()
    let v322 : int32 = v316.Length
    let v323 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v322)
    let v324 : Mut1 = {l0 = 0} : Mut1
    while method1(v322, v324) do
        let v326 : int32 = v324.l0
        let v327 : US8 = v316.[int v326]
        let v330 : JSX.Prop =
            match v327 with
            | US8_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US8_1(v329) -> (* Some *)
                v329
        v323.[int v326] <- v330
        let v331 : int32 = v326 + 1
        v324.l0 <- v331
        ()
    let v332 : obj = createObj v323
    let v333 : string = "createComponent"
    let v334 : string = "solid-js"
    let v335 : JS.Function = import v333 v334
    let v336 : string = "Td"
    let v337 : string = "@hope-ui/solid"
    let v338 : JSX.Element = v335.Invoke ((import v336 v337), v332) |> unbox<JSX.Element>
    v338
and closure16 () () : JSX.Element =
    let v0 : string = "&nbsp;"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : (JSX.Element []) = [|v1|]
    let v3 : JSX.Element = v2 |> unbox<JSX.Element>
    v3
and closure18 (v0 : (unit -> JSX.Element)) () : JSX.Element =
    let v1 : JSX.Element = v0 ()
    let v2 : (JSX.Element []) = [|v1|]
    let v3 : JSX.Element = v2 |> unbox<JSX.Element>
    v3
and closure19 (v0 : (unit -> bool)) () : (bool []) =
    let v1 : bool = v0 ()
    [|v1|]
and closure20 (v0 : (bool -> unit), v1 : (unit -> bool)) () : unit =
    let v2 : bool = v1 ()
    if v2 then
        v0 false
        ()
and closure23 () () : JSX.Element =
    let v0 : string = "Load"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : (JSX.Element []) = [|v1|]
    let v3 : JSX.Element = v2 |> unbox<JSX.Element>
    v3
and closure24 (v0 : (bool -> unit)) () : unit =
    v0 true
    ()
and closure22 (v0 : (bool -> unit)) () : JSX.Element =
    let v1 : US0 = US0_0
    let v2 : US1 = US1_0
    let v3 : US0 = US0_0
    let v4 : US0 = US0_0
    let v5 : US0 = US0_0
    let v6 : US2 = US2_0
    let v7 : (unit -> JSX.Element) = closure23()
    let v8 : US3 = US3_1(v7)
    let v9 : US0 = US0_0
    let v10 : US0 = US0_0
    let v11 : US2 = US2_0
    let v12 : US0 = US0_0
    let v13 : US0 = US0_0
    let v14 : US2 = US2_0
    let v15 : US4 = US4_0
    let v16 : US0 = US0_0
    let v17 : US0 = US0_0
    let v18 : US0 = US0_0
    let v19 : US0 = US0_0
    let v20 : US5 = US5_0
    let v21 : US0 = US0_0
    let v22 : US0 = US0_0
    let v23 : US0 = US0_0
    let v24 : US0 = US0_0
    let v25 : US0 = US0_0
    let v26 : US0 = US0_0
    let v27 : US0 = US0_0
    let v28 : US6 = US6_0
    let v29 : (unit -> unit) = closure24(v0)
    let v30 : US7 = US7_1(v29)
    let v31 : US0 = US0_0
    let v32 : US0 = US0_0
    let v33 : US0 = US0_0
    let v34 : US0 = US0_0
    let v35 : US0 = US0_0
    let v36 : US0 = US0_0
    let v37 : US0 = US0_0
    let v38 : US0 = US0_0
    let v39 : US2 = US2_0
    let v40 : US0 = US0_0
    let v41 : US0 = US0_0
    let v42 : US5 = US5_0
    let v43 : US0 = US0_0
    let v44 : US0 = US0_0
    let v45 : US4 = US4_0
    let v46 : Heap0 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45} : Heap0
    let v47 : US3 = v46.l6
    let v48 : US0 = US0_0
    let v49 : US1 = US1_0
    let v50 : US0 = US0_0
    let v51 : US0 = US0_0
    let v52 : US0 = US0_0
    let v53 : US2 = US2_0
    let v54 : US0 = US0_0
    let v55 : string = "neutral"
    let v56 : US0 = US0_1(v55)
    let v57 : US2 = US2_1(true)
    let v58 : US0 = US0_0
    let v59 : US0 = US0_0
    let v60 : US2 = US2_0
    let v61 : US4 = US4_0
    let v62 : US0 = US0_0
    let v63 : US0 = US0_0
    let v64 : US0 = US0_0
    let v65 : US0 = US0_0
    let v66 : US5 = US5_0
    let v67 : US0 = US0_0
    let v68 : string = "left"
    let v69 : US0 = US0_1(v68)
    let v70 : US0 = US0_0
    let v71 : US0 = US0_0
    let v72 : US0 = US0_0
    let v73 : US0 = US0_0
    let v74 : US0 = US0_0
    let v75 : US6 = US6_0
    let v76 : US7 = US7_0
    let v77 : US0 = US0_0
    let v78 : US0 = US0_0
    let v79 : US0 = US0_0
    let v80 : US0 = US0_0
    let v81 : US0 = US0_0
    let v82 : US0 = US0_0
    let v83 : string = "xs"
    let v84 : US0 = US0_1(v83)
    let v85 : US0 = US0_0
    let v86 : US2 = US2_0
    let v87 : US0 = US0_0
    let v88 : US0 = US0_0
    let v89 : US5 = US5_0
    let v90 : US0 = US0_0
    let v91 : US0 = US0_0
    let v92 : US4 = US4_0
    let v93 : Heap0 = {l0 = v48; l1 = v49; l2 = v50; l3 = v51; l4 = v52; l5 = v53; l6 = v47; l7 = v54; l8 = v56; l9 = v57; l10 = v58; l11 = v59; l12 = v60; l13 = v61; l14 = v62; l15 = v63; l16 = v64; l17 = v65; l18 = v66; l19 = v67; l20 = v69; l21 = v70; l22 = v71; l23 = v72; l24 = v73; l25 = v74; l26 = v75; l27 = v76; l28 = v77; l29 = v78; l30 = v79; l31 = v80; l32 = v81; l33 = v82; l34 = v84; l35 = v85; l36 = v86; l37 = v87; l38 = v88; l39 = v89; l40 = v90; l41 = v91; l42 = v92} : Heap0
    let v94 : US0 = v93.l0
    let v100 : US8 =
        match v94 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v96) -> (* Some *)
            let v97 : string = "aria-label"
            let v98 : JSX.Prop = JSX.Prop (v97, v96)
            US8_1(v98)
    let v101 : US1 = v93.l1
    let v107 : US8 =
        match v101 with
        | US1_0 -> (* None *)
            US8_0
        | US1_1(v103) -> (* Some *)
            let v104 : string = "as"
            let v105 : JSX.Prop = JSX.Prop (v104, v103)
            US8_1(v105)
    let v108 : US0 = v93.l2
    let v114 : US8 =
        match v108 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v110) -> (* Some *)
            let v111 : string = "backgroundColor"
            let v112 : JSX.Prop = JSX.Prop (v111, v110)
            US8_1(v112)
    let v115 : US0 = v93.l3
    let v121 : US8 =
        match v115 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v117) -> (* Some *)
            let v118 : string = "border"
            let v119 : JSX.Prop = JSX.Prop (v118, v117)
            US8_1(v119)
    let v122 : US0 = v93.l4
    let v128 : US8 =
        match v122 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v124) -> (* Some *)
            let v125 : string = "bottom"
            let v126 : JSX.Prop = JSX.Prop (v125, v124)
            US8_1(v126)
    let v129 : US0 = v93.l7
    let v135 : US8 =
        match v129 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v131) -> (* Some *)
            let v132 : string = "color"
            let v133 : JSX.Prop = JSX.Prop (v132, v131)
            US8_1(v133)
    let v136 : US2 = v93.l5
    let v142 : US8 =
        match v136 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v138) -> (* Some *)
            let v139 : string = "checked"
            let v140 : JSX.Prop = JSX.Prop (v139, v138)
            US8_1(v140)
    let v143 : US3 = v93.l6
    let v149 : US8 =
        match v143 with
        | US3_0 -> (* None *)
            US8_0
        | US3_1(v145) -> (* Some *)
            let v146 : string = "children"
            let v147 : JSX.Prop = JSX.Prop (v146, v145)
            US8_1(v147)
    let v150 : US0 = v93.l8
    let v156 : US8 =
        match v150 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v152) -> (* Some *)
            let v153 : string = "colorScheme"
            let v154 : JSX.Prop = JSX.Prop (v153, v152)
            US8_1(v154)
    let v157 : US2 = v93.l9
    let v163 : US8 =
        match v157 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v159) -> (* Some *)
            let v160 : string = "compact"
            let v161 : JSX.Prop = JSX.Prop (v160, v159)
            US8_1(v161)
    let v164 : US0 = v93.l11
    let v170 : US8 =
        match v164 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v166) -> (* Some *)
            let v167 : string = "display"
            let v168 : JSX.Prop = JSX.Prop (v167, v166)
            US8_1(v168)
    let v171 : US0 = v93.l10
    let v177 : US8 =
        match v171 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v173) -> (* Some *)
            let v174 : string = "direction"
            let v175 : JSX.Prop = JSX.Prop (v174, v173)
            US8_1(v175)
    let v178 : US2 = v93.l12
    let v184 : US8 =
        match v178 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v180) -> (* Some *)
            let v181 : string = "external"
            let v182 : JSX.Prop = JSX.Prop (v181, v180)
            US8_1(v182)
    let v185 : US4 = v93.l13
    let v191 : US8 =
        match v185 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v187) -> (* Some *)
            let v188 : string = "flex"
            let v189 : JSX.Prop = JSX.Prop (v188, v187)
            US8_1(v189)
    let v192 : US0 = v93.l14
    let v198 : US8 =
        match v192 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v194) -> (* Some *)
            let v195 : string = "flexDirection"
            let v196 : JSX.Prop = JSX.Prop (v195, v194)
            US8_1(v196)
    let v199 : US0 = v93.l15
    let v205 : US8 =
        match v199 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v201) -> (* Some *)
            let v202 : string = "fontSize"
            let v203 : JSX.Prop = JSX.Prop (v202, v201)
            US8_1(v203)
    let v206 : US0 = v93.l16
    let v212 : US8 =
        match v206 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v208) -> (* Some *)
            let v209 : string = "height"
            let v210 : JSX.Prop = JSX.Prop (v209, v208)
            US8_1(v210)
    let v213 : US0 = v93.l17
    let v219 : US8 =
        match v213 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v215) -> (* Some *)
            let v216 : string = "href"
            let v217 : JSX.Prop = JSX.Prop (v216, v215)
            US8_1(v217)
    let v220 : US5 = v93.l18
    let v226 : US8 =
        match v220 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v222) -> (* Some *)
            let v223 : string = "icon"
            let v224 : JSX.Prop = JSX.Prop (v223, v222)
            US8_1(v224)
    let v227 : US0 = v93.l19
    let v233 : US8 =
        match v227 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v229) -> (* Some *)
            let v230 : string = "id"
            let v231 : JSX.Prop = JSX.Prop (v230, v229)
            US8_1(v231)
    let v234 : US0 = v93.l20
    let v240 : US8 =
        match v234 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v236) -> (* Some *)
            let v237 : string = "justifyContent"
            let v238 : JSX.Prop = JSX.Prop (v237, v236)
            US8_1(v238)
    let v241 : US0 = v93.l21
    let v246 : US8 =
        match v241 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v243) -> (* Some *)
            let v244 : JSX.Prop = JSX.Prop (v68, v243)
            US8_1(v244)
    let v247 : US0 = v93.l22
    let v253 : US8 =
        match v247 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v249) -> (* Some *)
            let v250 : string = "lineHeight"
            let v251 : JSX.Prop = JSX.Prop (v250, v249)
            US8_1(v251)
    let v254 : US0 = v93.l23
    let v260 : US8 =
        match v254 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v256) -> (* Some *)
            let v257 : string = "margin"
            let v258 : JSX.Prop = JSX.Prop (v257, v256)
            US8_1(v258)
    let v261 : US0 = v93.l24
    let v267 : US8 =
        match v261 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v263) -> (* Some *)
            let v264 : string = "marginBottom"
            let v265 : JSX.Prop = JSX.Prop (v264, v263)
            US8_1(v265)
    let v268 : US0 = v93.l25
    let v274 : US8 =
        match v268 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v270) -> (* Some *)
            let v271 : string = "maxHeight"
            let v272 : JSX.Prop = JSX.Prop (v271, v270)
            US8_1(v272)
    let v275 : US6 = v93.l26
    let v281 : US8 =
        match v275 with
        | US6_0 -> (* None *)
            US8_0
        | US6_1(v277) -> (* Some *)
            let v278 : string = "onChange"
            let v279 : JSX.Prop = JSX.Prop (v278, v277)
            US8_1(v279)
    let v282 : US7 = v93.l27
    let v288 : US8 =
        match v282 with
        | US7_0 -> (* None *)
            US8_0
        | US7_1(v284) -> (* Some *)
            let v285 : string = "onClick"
            let v286 : JSX.Prop = JSX.Prop (v285, v284)
            US8_1(v286)
    let v289 : US0 = v93.l28
    let v295 : US8 =
        match v289 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v291) -> (* Some *)
            let v292 : string = "outline"
            let v293 : JSX.Prop = JSX.Prop (v292, v291)
            US8_1(v293)
    let v296 : US0 = v93.l29
    let v302 : US8 =
        match v296 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v298) -> (* Some *)
            let v299 : string = "overflowY"
            let v300 : JSX.Prop = JSX.Prop (v299, v298)
            US8_1(v300)
    let v303 : US0 = v93.l30
    let v309 : US8 =
        match v303 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v305) -> (* Some *)
            let v306 : string = "padding"
            let v307 : JSX.Prop = JSX.Prop (v306, v305)
            US8_1(v307)
    let v310 : US0 = v93.l31
    let v316 : US8 =
        match v310 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v312) -> (* Some *)
            let v313 : string = "paddingTop"
            let v314 : JSX.Prop = JSX.Prop (v313, v312)
            US8_1(v314)
    let v317 : US0 = v93.l32
    let v323 : US8 =
        match v317 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v319) -> (* Some *)
            let v320 : string = "position"
            let v321 : JSX.Prop = JSX.Prop (v320, v319)
            US8_1(v321)
    let v324 : US0 = v93.l33
    let v330 : US8 =
        match v324 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v326) -> (* Some *)
            let v327 : string = "right"
            let v328 : JSX.Prop = JSX.Prop (v327, v326)
            US8_1(v328)
    let v331 : US0 = v93.l34
    let v337 : US8 =
        match v331 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v333) -> (* Some *)
            let v334 : string = "size"
            let v335 : JSX.Prop = JSX.Prop (v334, v333)
            US8_1(v335)
    let v338 : US0 = v93.l35
    let v344 : US8 =
        match v338 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v340) -> (* Some *)
            let v341 : string = "spacing"
            let v342 : JSX.Prop = JSX.Prop (v341, v340)
            US8_1(v342)
    let v345 : US2 = v93.l36
    let v351 : US8 =
        match v345 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v347) -> (* Some *)
            let v348 : string = "status"
            let v349 : JSX.Prop = JSX.Prop (v348, v347)
            US8_1(v349)
    let v352 : US0 = v93.l37
    let v358 : US8 =
        match v352 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v354) -> (* Some *)
            let v355 : string = "striped"
            let v356 : JSX.Prop = JSX.Prop (v355, v354)
            US8_1(v356)
    let v359 : US0 = v93.l38
    let v365 : US8 =
        match v359 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v361) -> (* Some *)
            let v362 : string = "thickness"
            let v363 : JSX.Prop = JSX.Prop (v362, v361)
            US8_1(v363)
    let v366 : US5 = v93.l39
    let v372 : US8 =
        match v366 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v368) -> (* Some *)
            let v369 : string = "title"
            let v370 : JSX.Prop = JSX.Prop (v369, v368)
            US8_1(v370)
    let v373 : US0 = v93.l40
    let v379 : US8 =
        match v373 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v375) -> (* Some *)
            let v376 : string = "top"
            let v377 : JSX.Prop = JSX.Prop (v376, v375)
            US8_1(v377)
    let v380 : US0 = v93.l41
    let v386 : US8 =
        match v380 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v382) -> (* Some *)
            let v383 : string = "width"
            let v384 : JSX.Prop = JSX.Prop (v383, v382)
            US8_1(v384)
    let v387 : US4 = v93.l42
    let v393 : US8 =
        match v387 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v389) -> (* Some *)
            let v390 : string = "zIndex"
            let v391 : JSX.Prop = JSX.Prop (v390, v389)
            US8_1(v391)
    let v394 : (US8 []) = [|v100; v107; v114; v121; v128; v135; v142; v149; v156; v163; v170; v177; v184; v191; v198; v205; v212; v219; v226; v233; v240; v246; v253; v260; v267; v274; v281; v288; v295; v302; v309; v316; v323; v330; v337; v344; v351; v358; v365; v372; v379; v386; v393|]
    let v395 : int32 = v394.Length
    let v396 : (US8 []) = Array.zeroCreate<US8> (v395)
    let v397 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method0(v395, v397) do
        let v399 : int32 = v397.l0
        let v400 : int32 = v397.l1
        let v401 : US8 = v394.[int v399]
        let v403 : bool =
            match v401 with
            | US8_0 -> (* None *)
                false
            | US8_1(v402) -> (* Some *)
                true
        let v405 : int32 =
            if v403 then
                v396.[int v400] <- v401
                let v404 : int32 = v400 + 1
                v404
            else
                v400
        let v406 : int32 = v399 + 1
        v397.l0 <- v406
        v397.l1 <- v405
        ()
    let v407 : int32 = v397.l1
    let v408 : (US8 []) = Array.zeroCreate<US8> (v407)
    let v409 : Mut1 = {l0 = 0} : Mut1
    while method1(v407, v409) do
        let v411 : int32 = v409.l0
        let v412 : US8 = v396.[int v411]
        v408.[int v411] <- v412
        let v413 : int32 = v411 + 1
        v409.l0 <- v413
        ()
    let v414 : int32 = v408.Length
    let v415 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v414)
    let v416 : Mut1 = {l0 = 0} : Mut1
    while method1(v414, v416) do
        let v418 : int32 = v416.l0
        let v419 : US8 = v408.[int v418]
        let v422 : JSX.Prop =
            match v419 with
            | US8_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US8_1(v421) -> (* Some *)
                v421
        v415.[int v418] <- v422
        let v423 : int32 = v418 + 1
        v416.l0 <- v423
        ()
    let v424 : obj = createObj v415
    let v425 : string = "createComponent"
    let v426 : string = "solid-js"
    let v427 : JS.Function = import v425 v426
    let v428 : string = "Button"
    let v429 : string = "@hope-ui/solid"
    let v430 : JSX.Element = v427.Invoke ((import v428 v429), v424) |> unbox<JSX.Element>
    let v431 : (JSX.Element []) = [|v430|]
    let v432 : JSX.Element = v431 |> unbox<JSX.Element>
    v432
and closure25 () (v0 : Heap0) : JSX.Element =
    let v1 : US0 = v0.l0
    let v7 : US8 =
        match v1 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v3) -> (* Some *)
            let v4 : string = "aria-label"
            let v5 : JSX.Prop = JSX.Prop (v4, v3)
            US8_1(v5)
    let v8 : US1 = v0.l1
    let v14 : US8 =
        match v8 with
        | US1_0 -> (* None *)
            US8_0
        | US1_1(v10) -> (* Some *)
            let v11 : string = "as"
            let v12 : JSX.Prop = JSX.Prop (v11, v10)
            US8_1(v12)
    let v15 : US0 = v0.l2
    let v21 : US8 =
        match v15 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v17) -> (* Some *)
            let v18 : string = "backgroundColor"
            let v19 : JSX.Prop = JSX.Prop (v18, v17)
            US8_1(v19)
    let v22 : US0 = v0.l3
    let v28 : US8 =
        match v22 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v24) -> (* Some *)
            let v25 : string = "border"
            let v26 : JSX.Prop = JSX.Prop (v25, v24)
            US8_1(v26)
    let v29 : US0 = v0.l4
    let v35 : US8 =
        match v29 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v31) -> (* Some *)
            let v32 : string = "bottom"
            let v33 : JSX.Prop = JSX.Prop (v32, v31)
            US8_1(v33)
    let v36 : US0 = v0.l7
    let v42 : US8 =
        match v36 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v38) -> (* Some *)
            let v39 : string = "color"
            let v40 : JSX.Prop = JSX.Prop (v39, v38)
            US8_1(v40)
    let v43 : US2 = v0.l5
    let v49 : US8 =
        match v43 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v45) -> (* Some *)
            let v46 : string = "checked"
            let v47 : JSX.Prop = JSX.Prop (v46, v45)
            US8_1(v47)
    let v50 : US3 = v0.l6
    let v56 : US8 =
        match v50 with
        | US3_0 -> (* None *)
            US8_0
        | US3_1(v52) -> (* Some *)
            let v53 : string = "children"
            let v54 : JSX.Prop = JSX.Prop (v53, v52)
            US8_1(v54)
    let v57 : US0 = v0.l8
    let v63 : US8 =
        match v57 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v59) -> (* Some *)
            let v60 : string = "colorScheme"
            let v61 : JSX.Prop = JSX.Prop (v60, v59)
            US8_1(v61)
    let v64 : US2 = v0.l9
    let v70 : US8 =
        match v64 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v66) -> (* Some *)
            let v67 : string = "compact"
            let v68 : JSX.Prop = JSX.Prop (v67, v66)
            US8_1(v68)
    let v71 : US0 = v0.l11
    let v77 : US8 =
        match v71 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v73) -> (* Some *)
            let v74 : string = "display"
            let v75 : JSX.Prop = JSX.Prop (v74, v73)
            US8_1(v75)
    let v78 : US0 = v0.l10
    let v84 : US8 =
        match v78 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v80) -> (* Some *)
            let v81 : string = "direction"
            let v82 : JSX.Prop = JSX.Prop (v81, v80)
            US8_1(v82)
    let v85 : US2 = v0.l12
    let v91 : US8 =
        match v85 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v87) -> (* Some *)
            let v88 : string = "external"
            let v89 : JSX.Prop = JSX.Prop (v88, v87)
            US8_1(v89)
    let v92 : US4 = v0.l13
    let v98 : US8 =
        match v92 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v94) -> (* Some *)
            let v95 : string = "flex"
            let v96 : JSX.Prop = JSX.Prop (v95, v94)
            US8_1(v96)
    let v99 : US0 = v0.l14
    let v105 : US8 =
        match v99 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v101) -> (* Some *)
            let v102 : string = "flexDirection"
            let v103 : JSX.Prop = JSX.Prop (v102, v101)
            US8_1(v103)
    let v106 : US0 = v0.l15
    let v112 : US8 =
        match v106 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v108) -> (* Some *)
            let v109 : string = "fontSize"
            let v110 : JSX.Prop = JSX.Prop (v109, v108)
            US8_1(v110)
    let v113 : US0 = v0.l16
    let v119 : US8 =
        match v113 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v115) -> (* Some *)
            let v116 : string = "height"
            let v117 : JSX.Prop = JSX.Prop (v116, v115)
            US8_1(v117)
    let v120 : US0 = v0.l17
    let v126 : US8 =
        match v120 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v122) -> (* Some *)
            let v123 : string = "href"
            let v124 : JSX.Prop = JSX.Prop (v123, v122)
            US8_1(v124)
    let v127 : US5 = v0.l18
    let v133 : US8 =
        match v127 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v129) -> (* Some *)
            let v130 : string = "icon"
            let v131 : JSX.Prop = JSX.Prop (v130, v129)
            US8_1(v131)
    let v134 : US0 = v0.l19
    let v140 : US8 =
        match v134 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v136) -> (* Some *)
            let v137 : string = "id"
            let v138 : JSX.Prop = JSX.Prop (v137, v136)
            US8_1(v138)
    let v141 : US0 = v0.l20
    let v147 : US8 =
        match v141 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v143) -> (* Some *)
            let v144 : string = "justifyContent"
            let v145 : JSX.Prop = JSX.Prop (v144, v143)
            US8_1(v145)
    let v148 : US0 = v0.l21
    let v154 : US8 =
        match v148 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v150) -> (* Some *)
            let v151 : string = "left"
            let v152 : JSX.Prop = JSX.Prop (v151, v150)
            US8_1(v152)
    let v155 : US0 = v0.l22
    let v161 : US8 =
        match v155 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v157) -> (* Some *)
            let v158 : string = "lineHeight"
            let v159 : JSX.Prop = JSX.Prop (v158, v157)
            US8_1(v159)
    let v162 : US0 = v0.l23
    let v168 : US8 =
        match v162 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v164) -> (* Some *)
            let v165 : string = "margin"
            let v166 : JSX.Prop = JSX.Prop (v165, v164)
            US8_1(v166)
    let v169 : US0 = v0.l24
    let v175 : US8 =
        match v169 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v171) -> (* Some *)
            let v172 : string = "marginBottom"
            let v173 : JSX.Prop = JSX.Prop (v172, v171)
            US8_1(v173)
    let v176 : US0 = v0.l25
    let v182 : US8 =
        match v176 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v178) -> (* Some *)
            let v179 : string = "maxHeight"
            let v180 : JSX.Prop = JSX.Prop (v179, v178)
            US8_1(v180)
    let v183 : US6 = v0.l26
    let v189 : US8 =
        match v183 with
        | US6_0 -> (* None *)
            US8_0
        | US6_1(v185) -> (* Some *)
            let v186 : string = "onChange"
            let v187 : JSX.Prop = JSX.Prop (v186, v185)
            US8_1(v187)
    let v190 : US7 = v0.l27
    let v196 : US8 =
        match v190 with
        | US7_0 -> (* None *)
            US8_0
        | US7_1(v192) -> (* Some *)
            let v193 : string = "onClick"
            let v194 : JSX.Prop = JSX.Prop (v193, v192)
            US8_1(v194)
    let v197 : US0 = v0.l28
    let v203 : US8 =
        match v197 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v199) -> (* Some *)
            let v200 : string = "outline"
            let v201 : JSX.Prop = JSX.Prop (v200, v199)
            US8_1(v201)
    let v204 : US0 = v0.l29
    let v210 : US8 =
        match v204 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v206) -> (* Some *)
            let v207 : string = "overflowY"
            let v208 : JSX.Prop = JSX.Prop (v207, v206)
            US8_1(v208)
    let v211 : US0 = v0.l30
    let v217 : US8 =
        match v211 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v213) -> (* Some *)
            let v214 : string = "padding"
            let v215 : JSX.Prop = JSX.Prop (v214, v213)
            US8_1(v215)
    let v218 : US0 = v0.l31
    let v224 : US8 =
        match v218 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v220) -> (* Some *)
            let v221 : string = "paddingTop"
            let v222 : JSX.Prop = JSX.Prop (v221, v220)
            US8_1(v222)
    let v225 : US0 = v0.l32
    let v231 : US8 =
        match v225 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v227) -> (* Some *)
            let v228 : string = "position"
            let v229 : JSX.Prop = JSX.Prop (v228, v227)
            US8_1(v229)
    let v232 : US0 = v0.l33
    let v238 : US8 =
        match v232 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v234) -> (* Some *)
            let v235 : string = "right"
            let v236 : JSX.Prop = JSX.Prop (v235, v234)
            US8_1(v236)
    let v239 : US0 = v0.l34
    let v245 : US8 =
        match v239 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v241) -> (* Some *)
            let v242 : string = "size"
            let v243 : JSX.Prop = JSX.Prop (v242, v241)
            US8_1(v243)
    let v246 : US0 = v0.l35
    let v252 : US8 =
        match v246 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v248) -> (* Some *)
            let v249 : string = "spacing"
            let v250 : JSX.Prop = JSX.Prop (v249, v248)
            US8_1(v250)
    let v253 : US2 = v0.l36
    let v259 : US8 =
        match v253 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v255) -> (* Some *)
            let v256 : string = "status"
            let v257 : JSX.Prop = JSX.Prop (v256, v255)
            US8_1(v257)
    let v260 : US0 = v0.l37
    let v266 : US8 =
        match v260 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v262) -> (* Some *)
            let v263 : string = "striped"
            let v264 : JSX.Prop = JSX.Prop (v263, v262)
            US8_1(v264)
    let v267 : US0 = v0.l38
    let v273 : US8 =
        match v267 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v269) -> (* Some *)
            let v270 : string = "thickness"
            let v271 : JSX.Prop = JSX.Prop (v270, v269)
            US8_1(v271)
    let v274 : US5 = v0.l39
    let v280 : US8 =
        match v274 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v276) -> (* Some *)
            let v277 : string = "title"
            let v278 : JSX.Prop = JSX.Prop (v277, v276)
            US8_1(v278)
    let v281 : US0 = v0.l40
    let v287 : US8 =
        match v281 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v283) -> (* Some *)
            let v284 : string = "top"
            let v285 : JSX.Prop = JSX.Prop (v284, v283)
            US8_1(v285)
    let v288 : US0 = v0.l41
    let v294 : US8 =
        match v288 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v290) -> (* Some *)
            let v291 : string = "width"
            let v292 : JSX.Prop = JSX.Prop (v291, v290)
            US8_1(v292)
    let v295 : US4 = v0.l42
    let v301 : US8 =
        match v295 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v297) -> (* Some *)
            let v298 : string = "zIndex"
            let v299 : JSX.Prop = JSX.Prop (v298, v297)
            US8_1(v299)
    let v302 : (US8 []) = [|v7; v14; v21; v28; v35; v42; v49; v56; v63; v70; v77; v84; v91; v98; v105; v112; v119; v126; v133; v140; v147; v154; v161; v168; v175; v182; v189; v196; v203; v210; v217; v224; v231; v238; v245; v252; v259; v266; v273; v280; v287; v294; v301|]
    let v303 : int32 = v302.Length
    let v304 : (US8 []) = Array.zeroCreate<US8> (v303)
    let v305 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method0(v303, v305) do
        let v307 : int32 = v305.l0
        let v308 : int32 = v305.l1
        let v309 : US8 = v302.[int v307]
        let v311 : bool =
            match v309 with
            | US8_0 -> (* None *)
                false
            | US8_1(v310) -> (* Some *)
                true
        let v313 : int32 =
            if v311 then
                v304.[int v308] <- v309
                let v312 : int32 = v308 + 1
                v312
            else
                v308
        let v314 : int32 = v307 + 1
        v305.l0 <- v314
        v305.l1 <- v313
        ()
    let v315 : int32 = v305.l1
    let v316 : (US8 []) = Array.zeroCreate<US8> (v315)
    let v317 : Mut1 = {l0 = 0} : Mut1
    while method1(v315, v317) do
        let v319 : int32 = v317.l0
        let v320 : US8 = v304.[int v319]
        v316.[int v319] <- v320
        let v321 : int32 = v319 + 1
        v317.l0 <- v321
        ()
    let v322 : int32 = v316.Length
    let v323 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v322)
    let v324 : Mut1 = {l0 = 0} : Mut1
    while method1(v322, v324) do
        let v326 : int32 = v324.l0
        let v327 : US8 = v316.[int v326]
        let v330 : JSX.Prop =
            match v327 with
            | US8_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US8_1(v329) -> (* Some *)
                v329
        v323.[int v326] <- v330
        let v331 : int32 = v326 + 1
        v324.l0 <- v331
        ()
    let v332 : obj = createObj v323
    let v333 : string = "createComponent"
    let v334 : string = "solid-js"
    let v335 : JS.Function = import v333 v334
    let v336 : string = "Box"
    let v337 : string = "@hope-ui/solid"
    let v338 : JSX.Element = v335.Invoke ((import v336 v337), v332) |> unbox<JSX.Element>
    v338
and closure29 (v0 : (bool -> unit)) () : unit =
    v0 true
    ()
and closure30 (v0 : (bool -> unit), v1 : (unit -> bool)) () : unit =
    let v2 : bool = v1 ()
    let v3 : bool = v2 = false
    v0 v3
    ()
and closure31 (v0 : (bool -> unit)) () : unit =
    v0 false
    ()
and closure28 (v0 : (bool -> unit), v1 : (bool -> unit), v2 : (bool -> unit), v3 : (unit -> bool)) () : JSX.Element =
    let v4 : string = "BiRegularRefresh"
    let v5 : string = "solid-icons/bi"
    let v6 : JS.Function = import v4 v5
    let v7 : US0 = US0_0
    let v8 : US1 = US1_0
    let v9 : US0 = US0_0
    let v10 : US0 = US0_0
    let v11 : US0 = US0_0
    let v12 : US2 = US2_0
    let v13 : US3 = US3_0
    let v14 : US0 = US0_0
    let v15 : US0 = US0_0
    let v16 : US2 = US2_0
    let v17 : US0 = US0_0
    let v18 : US0 = US0_0
    let v19 : US2 = US2_0
    let v20 : US4 = US4_0
    let v21 : US0 = US0_0
    let v22 : US0 = US0_0
    let v23 : US0 = US0_0
    let v24 : US0 = US0_0
    let v25 : US5 = US5_0
    let v26 : US0 = US0_0
    let v27 : US0 = US0_0
    let v28 : US0 = US0_0
    let v29 : US0 = US0_0
    let v30 : US0 = US0_0
    let v31 : US0 = US0_0
    let v32 : US0 = US0_0
    let v33 : US6 = US6_0
    let v34 : US7 = US7_0
    let v35 : US0 = US0_0
    let v36 : US0 = US0_0
    let v37 : US0 = US0_0
    let v38 : US0 = US0_0
    let v39 : US0 = US0_0
    let v40 : US0 = US0_0
    let v41 : string = "14px"
    let v42 : US0 = US0_1(v41)
    let v43 : US0 = US0_0
    let v44 : US2 = US2_0
    let v45 : US0 = US0_0
    let v46 : US0 = US0_0
    let v47 : US5 = US5_0
    let v48 : US0 = US0_0
    let v49 : US0 = US0_0
    let v50 : US4 = US4_0
    let v51 : Heap0 = {l0 = v7; l1 = v8; l2 = v9; l3 = v10; l4 = v11; l5 = v12; l6 = v13; l7 = v14; l8 = v15; l9 = v16; l10 = v17; l11 = v18; l12 = v19; l13 = v20; l14 = v21; l15 = v22; l16 = v23; l17 = v24; l18 = v25; l19 = v26; l20 = v27; l21 = v28; l22 = v29; l23 = v30; l24 = v31; l25 = v32; l26 = v33; l27 = v34; l28 = v35; l29 = v36; l30 = v37; l31 = v38; l32 = v39; l33 = v40; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50} : Heap0
    let v52 : JS.Function = v6 |> unbox<JS.Function>
    let v53 : string = "createComponent"
    let v54 : string = "solid-js"
    let v55 : JS.Function = import v53 v54
    let v56 : JSX.Element = v55.Invoke (v52, v51) |> unbox<JSX.Element>
    let v57 : string = "Refresh"
    let v58 : US0 = US0_1(v57)
    let v59 : US1 = US1_0
    let v60 : US0 = US0_0
    let v61 : US0 = US0_0
    let v62 : US0 = US0_0
    let v63 : US2 = US2_0
    let v64 : US3 = US3_0
    let v65 : US0 = US0_0
    let v66 : string = "neutral"
    let v67 : US0 = US0_1(v66)
    let v68 : US2 = US2_0
    let v69 : US0 = US0_0
    let v70 : US0 = US0_0
    let v71 : US2 = US2_0
    let v72 : US4 = US4_0
    let v73 : US0 = US0_0
    let v74 : US0 = US0_0
    let v75 : string = "20px"
    let v76 : US0 = US0_1(v75)
    let v77 : US0 = US0_0
    let v78 : US5 = US5_1(v56)
    let v79 : US0 = US0_0
    let v80 : US0 = US0_0
    let v81 : US0 = US0_0
    let v82 : US0 = US0_0
    let v83 : US0 = US0_0
    let v84 : US0 = US0_0
    let v85 : US0 = US0_0
    let v86 : US6 = US6_0
    let v87 : (unit -> unit) = closure29(v1)
    let v88 : US7 = US7_1(v87)
    let v89 : US0 = US0_0
    let v90 : US0 = US0_0
    let v91 : US0 = US0_0
    let v92 : US0 = US0_0
    let v93 : US0 = US0_0
    let v94 : US0 = US0_0
    let v95 : string = "xs"
    let v96 : US0 = US0_1(v95)
    let v97 : US0 = US0_0
    let v98 : US2 = US2_0
    let v99 : US0 = US0_0
    let v100 : US0 = US0_0
    let v101 : US5 = US5_0
    let v102 : US0 = US0_0
    let v103 : US0 = US0_0
    let v104 : US4 = US4_0
    let v105 : Heap0 = {l0 = v58; l1 = v59; l2 = v60; l3 = v61; l4 = v62; l5 = v63; l6 = v64; l7 = v65; l8 = v67; l9 = v68; l10 = v69; l11 = v70; l12 = v71; l13 = v72; l14 = v73; l15 = v74; l16 = v76; l17 = v77; l18 = v78; l19 = v79; l20 = v80; l21 = v81; l22 = v82; l23 = v83; l24 = v84; l25 = v85; l26 = v86; l27 = v88; l28 = v89; l29 = v90; l30 = v91; l31 = v92; l32 = v93; l33 = v94; l34 = v96; l35 = v97; l36 = v98; l37 = v99; l38 = v100; l39 = v101; l40 = v102; l41 = v103; l42 = v104} : Heap0
    let v106 : US0 = v105.l0
    let v112 : US8 =
        match v106 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v108) -> (* Some *)
            let v109 : string = "aria-label"
            let v110 : JSX.Prop = JSX.Prop (v109, v108)
            US8_1(v110)
    let v113 : US1 = v105.l1
    let v119 : US8 =
        match v113 with
        | US1_0 -> (* None *)
            US8_0
        | US1_1(v115) -> (* Some *)
            let v116 : string = "as"
            let v117 : JSX.Prop = JSX.Prop (v116, v115)
            US8_1(v117)
    let v120 : US0 = v105.l2
    let v126 : US8 =
        match v120 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v122) -> (* Some *)
            let v123 : string = "backgroundColor"
            let v124 : JSX.Prop = JSX.Prop (v123, v122)
            US8_1(v124)
    let v127 : US0 = v105.l3
    let v133 : US8 =
        match v127 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v129) -> (* Some *)
            let v130 : string = "border"
            let v131 : JSX.Prop = JSX.Prop (v130, v129)
            US8_1(v131)
    let v134 : US0 = v105.l4
    let v140 : US8 =
        match v134 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v136) -> (* Some *)
            let v137 : string = "bottom"
            let v138 : JSX.Prop = JSX.Prop (v137, v136)
            US8_1(v138)
    let v141 : US0 = v105.l7
    let v147 : US8 =
        match v141 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v143) -> (* Some *)
            let v144 : string = "color"
            let v145 : JSX.Prop = JSX.Prop (v144, v143)
            US8_1(v145)
    let v148 : US2 = v105.l5
    let v154 : US8 =
        match v148 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v150) -> (* Some *)
            let v151 : string = "checked"
            let v152 : JSX.Prop = JSX.Prop (v151, v150)
            US8_1(v152)
    let v155 : US3 = v105.l6
    let v161 : US8 =
        match v155 with
        | US3_0 -> (* None *)
            US8_0
        | US3_1(v157) -> (* Some *)
            let v158 : string = "children"
            let v159 : JSX.Prop = JSX.Prop (v158, v157)
            US8_1(v159)
    let v162 : US0 = v105.l8
    let v168 : US8 =
        match v162 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v164) -> (* Some *)
            let v165 : string = "colorScheme"
            let v166 : JSX.Prop = JSX.Prop (v165, v164)
            US8_1(v166)
    let v169 : US2 = v105.l9
    let v175 : US8 =
        match v169 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v171) -> (* Some *)
            let v172 : string = "compact"
            let v173 : JSX.Prop = JSX.Prop (v172, v171)
            US8_1(v173)
    let v176 : US0 = v105.l11
    let v182 : US8 =
        match v176 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v178) -> (* Some *)
            let v179 : string = "display"
            let v180 : JSX.Prop = JSX.Prop (v179, v178)
            US8_1(v180)
    let v183 : US0 = v105.l10
    let v189 : US8 =
        match v183 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v185) -> (* Some *)
            let v186 : string = "direction"
            let v187 : JSX.Prop = JSX.Prop (v186, v185)
            US8_1(v187)
    let v190 : US2 = v105.l12
    let v196 : US8 =
        match v190 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v192) -> (* Some *)
            let v193 : string = "external"
            let v194 : JSX.Prop = JSX.Prop (v193, v192)
            US8_1(v194)
    let v197 : US4 = v105.l13
    let v203 : US8 =
        match v197 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v199) -> (* Some *)
            let v200 : string = "flex"
            let v201 : JSX.Prop = JSX.Prop (v200, v199)
            US8_1(v201)
    let v204 : US0 = v105.l14
    let v210 : US8 =
        match v204 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v206) -> (* Some *)
            let v207 : string = "flexDirection"
            let v208 : JSX.Prop = JSX.Prop (v207, v206)
            US8_1(v208)
    let v211 : US0 = v105.l15
    let v217 : US8 =
        match v211 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v213) -> (* Some *)
            let v214 : string = "fontSize"
            let v215 : JSX.Prop = JSX.Prop (v214, v213)
            US8_1(v215)
    let v218 : US0 = v105.l16
    let v224 : US8 =
        match v218 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v220) -> (* Some *)
            let v221 : string = "height"
            let v222 : JSX.Prop = JSX.Prop (v221, v220)
            US8_1(v222)
    let v225 : US0 = v105.l17
    let v231 : US8 =
        match v225 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v227) -> (* Some *)
            let v228 : string = "href"
            let v229 : JSX.Prop = JSX.Prop (v228, v227)
            US8_1(v229)
    let v232 : US5 = v105.l18
    let v238 : US8 =
        match v232 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v234) -> (* Some *)
            let v235 : string = "icon"
            let v236 : JSX.Prop = JSX.Prop (v235, v234)
            US8_1(v236)
    let v239 : US0 = v105.l19
    let v245 : US8 =
        match v239 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v241) -> (* Some *)
            let v242 : string = "id"
            let v243 : JSX.Prop = JSX.Prop (v242, v241)
            US8_1(v243)
    let v246 : US0 = v105.l20
    let v252 : US8 =
        match v246 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v248) -> (* Some *)
            let v249 : string = "justifyContent"
            let v250 : JSX.Prop = JSX.Prop (v249, v248)
            US8_1(v250)
    let v253 : US0 = v105.l21
    let v259 : US8 =
        match v253 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v255) -> (* Some *)
            let v256 : string = "left"
            let v257 : JSX.Prop = JSX.Prop (v256, v255)
            US8_1(v257)
    let v260 : US0 = v105.l22
    let v266 : US8 =
        match v260 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v262) -> (* Some *)
            let v263 : string = "lineHeight"
            let v264 : JSX.Prop = JSX.Prop (v263, v262)
            US8_1(v264)
    let v267 : US0 = v105.l23
    let v273 : US8 =
        match v267 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v269) -> (* Some *)
            let v270 : string = "margin"
            let v271 : JSX.Prop = JSX.Prop (v270, v269)
            US8_1(v271)
    let v274 : US0 = v105.l24
    let v280 : US8 =
        match v274 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v276) -> (* Some *)
            let v277 : string = "marginBottom"
            let v278 : JSX.Prop = JSX.Prop (v277, v276)
            US8_1(v278)
    let v281 : US0 = v105.l25
    let v287 : US8 =
        match v281 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v283) -> (* Some *)
            let v284 : string = "maxHeight"
            let v285 : JSX.Prop = JSX.Prop (v284, v283)
            US8_1(v285)
    let v288 : US6 = v105.l26
    let v294 : US8 =
        match v288 with
        | US6_0 -> (* None *)
            US8_0
        | US6_1(v290) -> (* Some *)
            let v291 : string = "onChange"
            let v292 : JSX.Prop = JSX.Prop (v291, v290)
            US8_1(v292)
    let v295 : US7 = v105.l27
    let v301 : US8 =
        match v295 with
        | US7_0 -> (* None *)
            US8_0
        | US7_1(v297) -> (* Some *)
            let v298 : string = "onClick"
            let v299 : JSX.Prop = JSX.Prop (v298, v297)
            US8_1(v299)
    let v302 : US0 = v105.l28
    let v308 : US8 =
        match v302 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v304) -> (* Some *)
            let v305 : string = "outline"
            let v306 : JSX.Prop = JSX.Prop (v305, v304)
            US8_1(v306)
    let v309 : US0 = v105.l29
    let v315 : US8 =
        match v309 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v311) -> (* Some *)
            let v312 : string = "overflowY"
            let v313 : JSX.Prop = JSX.Prop (v312, v311)
            US8_1(v313)
    let v316 : US0 = v105.l30
    let v322 : US8 =
        match v316 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v318) -> (* Some *)
            let v319 : string = "padding"
            let v320 : JSX.Prop = JSX.Prop (v319, v318)
            US8_1(v320)
    let v323 : US0 = v105.l31
    let v329 : US8 =
        match v323 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v325) -> (* Some *)
            let v326 : string = "paddingTop"
            let v327 : JSX.Prop = JSX.Prop (v326, v325)
            US8_1(v327)
    let v330 : US0 = v105.l32
    let v336 : US8 =
        match v330 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v332) -> (* Some *)
            let v333 : string = "position"
            let v334 : JSX.Prop = JSX.Prop (v333, v332)
            US8_1(v334)
    let v337 : US0 = v105.l33
    let v343 : US8 =
        match v337 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v339) -> (* Some *)
            let v340 : string = "right"
            let v341 : JSX.Prop = JSX.Prop (v340, v339)
            US8_1(v341)
    let v344 : US0 = v105.l34
    let v350 : US8 =
        match v344 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v346) -> (* Some *)
            let v347 : string = "size"
            let v348 : JSX.Prop = JSX.Prop (v347, v346)
            US8_1(v348)
    let v351 : US0 = v105.l35
    let v357 : US8 =
        match v351 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v353) -> (* Some *)
            let v354 : string = "spacing"
            let v355 : JSX.Prop = JSX.Prop (v354, v353)
            US8_1(v355)
    let v358 : US2 = v105.l36
    let v364 : US8 =
        match v358 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v360) -> (* Some *)
            let v361 : string = "status"
            let v362 : JSX.Prop = JSX.Prop (v361, v360)
            US8_1(v362)
    let v365 : US0 = v105.l37
    let v371 : US8 =
        match v365 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v367) -> (* Some *)
            let v368 : string = "striped"
            let v369 : JSX.Prop = JSX.Prop (v368, v367)
            US8_1(v369)
    let v372 : US0 = v105.l38
    let v378 : US8 =
        match v372 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v374) -> (* Some *)
            let v375 : string = "thickness"
            let v376 : JSX.Prop = JSX.Prop (v375, v374)
            US8_1(v376)
    let v379 : US5 = v105.l39
    let v385 : US8 =
        match v379 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v381) -> (* Some *)
            let v382 : string = "title"
            let v383 : JSX.Prop = JSX.Prop (v382, v381)
            US8_1(v383)
    let v386 : US0 = v105.l40
    let v392 : US8 =
        match v386 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v388) -> (* Some *)
            let v389 : string = "top"
            let v390 : JSX.Prop = JSX.Prop (v389, v388)
            US8_1(v390)
    let v393 : US0 = v105.l41
    let v399 : US8 =
        match v393 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v395) -> (* Some *)
            let v396 : string = "width"
            let v397 : JSX.Prop = JSX.Prop (v396, v395)
            US8_1(v397)
    let v400 : US4 = v105.l42
    let v406 : US8 =
        match v400 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v402) -> (* Some *)
            let v403 : string = "zIndex"
            let v404 : JSX.Prop = JSX.Prop (v403, v402)
            US8_1(v404)
    let v407 : (US8 []) = [|v112; v119; v126; v133; v140; v147; v154; v161; v168; v175; v182; v189; v196; v203; v210; v217; v224; v231; v238; v245; v252; v259; v266; v273; v280; v287; v294; v301; v308; v315; v322; v329; v336; v343; v350; v357; v364; v371; v378; v385; v392; v399; v406|]
    let v408 : int32 = v407.Length
    let v409 : (US8 []) = Array.zeroCreate<US8> (v408)
    let v410 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method0(v408, v410) do
        let v412 : int32 = v410.l0
        let v413 : int32 = v410.l1
        let v414 : US8 = v407.[int v412]
        let v416 : bool =
            match v414 with
            | US8_0 -> (* None *)
                false
            | US8_1(v415) -> (* Some *)
                true
        let v418 : int32 =
            if v416 then
                v409.[int v413] <- v414
                let v417 : int32 = v413 + 1
                v417
            else
                v413
        let v419 : int32 = v412 + 1
        v410.l0 <- v419
        v410.l1 <- v418
        ()
    let v420 : int32 = v410.l1
    let v421 : (US8 []) = Array.zeroCreate<US8> (v420)
    let v422 : Mut1 = {l0 = 0} : Mut1
    while method1(v420, v422) do
        let v424 : int32 = v422.l0
        let v425 : US8 = v409.[int v424]
        v421.[int v424] <- v425
        let v426 : int32 = v424 + 1
        v422.l0 <- v426
        ()
    let v427 : int32 = v421.Length
    let v428 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v427)
    let v429 : Mut1 = {l0 = 0} : Mut1
    while method1(v427, v429) do
        let v431 : int32 = v429.l0
        let v432 : US8 = v421.[int v431]
        let v435 : JSX.Prop =
            match v432 with
            | US8_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US8_1(v434) -> (* Some *)
                v434
        v428.[int v431] <- v435
        let v436 : int32 = v431 + 1
        v429.l0 <- v436
        ()
    let v437 : obj = createObj v428
    let v438 : JS.Function = import v53 v54
    let v439 : string = "IconButton"
    let v440 : string = "@hope-ui/solid"
    let v441 : JSX.Element = v438.Invoke ((import v439 v440), v437) |> unbox<JSX.Element>
    let v442 : bool = v3 ()
    let v445 : string =
        if v442 then
            let v443 : string = "Restore"
            v443
        else
            let v444 : string = "Maximize"
            v444
    let v446 : bool = v3 ()
    let v451 : JS.Function =
        if v446 then
            let v447 : string = "BiRegularDownArrow"
            let v448 : JS.Function = import v447 v5
            v448
        else
            let v449 : string = "BiRegularUpArrow"
            let v450 : JS.Function = import v449 v5
            v450
    let v452 : US0 = US0_0
    let v453 : US1 = US1_0
    let v454 : US0 = US0_0
    let v455 : US0 = US0_0
    let v456 : US0 = US0_0
    let v457 : US2 = US2_0
    let v458 : US3 = US3_0
    let v459 : US0 = US0_0
    let v460 : US0 = US0_0
    let v461 : US2 = US2_0
    let v462 : US0 = US0_0
    let v463 : US0 = US0_0
    let v464 : US2 = US2_0
    let v465 : US4 = US4_0
    let v466 : US0 = US0_0
    let v467 : US0 = US0_0
    let v468 : US0 = US0_0
    let v469 : US0 = US0_0
    let v470 : US5 = US5_0
    let v471 : US0 = US0_0
    let v472 : US0 = US0_0
    let v473 : US0 = US0_0
    let v474 : US0 = US0_0
    let v475 : US0 = US0_0
    let v476 : US0 = US0_0
    let v477 : US0 = US0_0
    let v478 : US6 = US6_0
    let v479 : US7 = US7_0
    let v480 : US0 = US0_0
    let v481 : US0 = US0_0
    let v482 : US0 = US0_0
    let v483 : US0 = US0_0
    let v484 : US0 = US0_0
    let v485 : US0 = US0_0
    let v486 : US0 = US0_1(v41)
    let v487 : US0 = US0_0
    let v488 : US2 = US2_0
    let v489 : US0 = US0_0
    let v490 : US0 = US0_0
    let v491 : US5 = US5_0
    let v492 : US0 = US0_0
    let v493 : US0 = US0_0
    let v494 : US4 = US4_0
    let v495 : Heap0 = {l0 = v452; l1 = v453; l2 = v454; l3 = v455; l4 = v456; l5 = v457; l6 = v458; l7 = v459; l8 = v460; l9 = v461; l10 = v462; l11 = v463; l12 = v464; l13 = v465; l14 = v466; l15 = v467; l16 = v468; l17 = v469; l18 = v470; l19 = v471; l20 = v472; l21 = v473; l22 = v474; l23 = v475; l24 = v476; l25 = v477; l26 = v478; l27 = v479; l28 = v480; l29 = v481; l30 = v482; l31 = v483; l32 = v484; l33 = v485; l34 = v486; l35 = v487; l36 = v488; l37 = v489; l38 = v490; l39 = v491; l40 = v492; l41 = v493; l42 = v494} : Heap0
    let v496 : JS.Function = v451 |> unbox<JS.Function>
    let v497 : JS.Function = import v53 v54
    let v498 : JSX.Element = v497.Invoke (v496, v495) |> unbox<JSX.Element>
    let v499 : US0 = US0_1(v445)
    let v500 : US1 = US1_0
    let v501 : US0 = US0_0
    let v502 : US0 = US0_0
    let v503 : US0 = US0_0
    let v504 : US2 = US2_0
    let v505 : US3 = US3_0
    let v506 : US0 = US0_0
    let v507 : US0 = US0_1(v66)
    let v508 : US2 = US2_0
    let v509 : US0 = US0_0
    let v510 : US0 = US0_0
    let v511 : US2 = US2_0
    let v512 : US4 = US4_0
    let v513 : US0 = US0_0
    let v514 : US0 = US0_0
    let v515 : US0 = US0_1(v75)
    let v516 : US0 = US0_0
    let v517 : US5 = US5_1(v498)
    let v518 : US0 = US0_0
    let v519 : US0 = US0_0
    let v520 : US0 = US0_0
    let v521 : US0 = US0_0
    let v522 : US0 = US0_0
    let v523 : US0 = US0_0
    let v524 : US0 = US0_0
    let v525 : US6 = US6_0
    let v526 : (unit -> unit) = closure30(v2, v3)
    let v527 : US7 = US7_1(v526)
    let v528 : US0 = US0_0
    let v529 : US0 = US0_0
    let v530 : US0 = US0_0
    let v531 : US0 = US0_0
    let v532 : US0 = US0_0
    let v533 : US0 = US0_0
    let v534 : US0 = US0_1(v95)
    let v535 : US0 = US0_0
    let v536 : US2 = US2_0
    let v537 : US0 = US0_0
    let v538 : US0 = US0_0
    let v539 : US5 = US5_0
    let v540 : US0 = US0_0
    let v541 : US0 = US0_0
    let v542 : US4 = US4_0
    let v543 : Heap0 = {l0 = v499; l1 = v500; l2 = v501; l3 = v502; l4 = v503; l5 = v504; l6 = v505; l7 = v506; l8 = v507; l9 = v508; l10 = v509; l11 = v510; l12 = v511; l13 = v512; l14 = v513; l15 = v514; l16 = v515; l17 = v516; l18 = v517; l19 = v518; l20 = v519; l21 = v520; l22 = v521; l23 = v522; l24 = v523; l25 = v524; l26 = v525; l27 = v527; l28 = v528; l29 = v529; l30 = v530; l31 = v531; l32 = v532; l33 = v533; l34 = v534; l35 = v535; l36 = v536; l37 = v537; l38 = v538; l39 = v539; l40 = v540; l41 = v541; l42 = v542} : Heap0
    let v544 : US0 = v543.l0
    let v550 : US8 =
        match v544 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v546) -> (* Some *)
            let v547 : string = "aria-label"
            let v548 : JSX.Prop = JSX.Prop (v547, v546)
            US8_1(v548)
    let v551 : US1 = v543.l1
    let v557 : US8 =
        match v551 with
        | US1_0 -> (* None *)
            US8_0
        | US1_1(v553) -> (* Some *)
            let v554 : string = "as"
            let v555 : JSX.Prop = JSX.Prop (v554, v553)
            US8_1(v555)
    let v558 : US0 = v543.l2
    let v564 : US8 =
        match v558 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v560) -> (* Some *)
            let v561 : string = "backgroundColor"
            let v562 : JSX.Prop = JSX.Prop (v561, v560)
            US8_1(v562)
    let v565 : US0 = v543.l3
    let v571 : US8 =
        match v565 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v567) -> (* Some *)
            let v568 : string = "border"
            let v569 : JSX.Prop = JSX.Prop (v568, v567)
            US8_1(v569)
    let v572 : US0 = v543.l4
    let v578 : US8 =
        match v572 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v574) -> (* Some *)
            let v575 : string = "bottom"
            let v576 : JSX.Prop = JSX.Prop (v575, v574)
            US8_1(v576)
    let v579 : US0 = v543.l7
    let v585 : US8 =
        match v579 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v581) -> (* Some *)
            let v582 : string = "color"
            let v583 : JSX.Prop = JSX.Prop (v582, v581)
            US8_1(v583)
    let v586 : US2 = v543.l5
    let v592 : US8 =
        match v586 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v588) -> (* Some *)
            let v589 : string = "checked"
            let v590 : JSX.Prop = JSX.Prop (v589, v588)
            US8_1(v590)
    let v593 : US3 = v543.l6
    let v599 : US8 =
        match v593 with
        | US3_0 -> (* None *)
            US8_0
        | US3_1(v595) -> (* Some *)
            let v596 : string = "children"
            let v597 : JSX.Prop = JSX.Prop (v596, v595)
            US8_1(v597)
    let v600 : US0 = v543.l8
    let v606 : US8 =
        match v600 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v602) -> (* Some *)
            let v603 : string = "colorScheme"
            let v604 : JSX.Prop = JSX.Prop (v603, v602)
            US8_1(v604)
    let v607 : US2 = v543.l9
    let v613 : US8 =
        match v607 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v609) -> (* Some *)
            let v610 : string = "compact"
            let v611 : JSX.Prop = JSX.Prop (v610, v609)
            US8_1(v611)
    let v614 : US0 = v543.l11
    let v620 : US8 =
        match v614 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v616) -> (* Some *)
            let v617 : string = "display"
            let v618 : JSX.Prop = JSX.Prop (v617, v616)
            US8_1(v618)
    let v621 : US0 = v543.l10
    let v627 : US8 =
        match v621 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v623) -> (* Some *)
            let v624 : string = "direction"
            let v625 : JSX.Prop = JSX.Prop (v624, v623)
            US8_1(v625)
    let v628 : US2 = v543.l12
    let v634 : US8 =
        match v628 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v630) -> (* Some *)
            let v631 : string = "external"
            let v632 : JSX.Prop = JSX.Prop (v631, v630)
            US8_1(v632)
    let v635 : US4 = v543.l13
    let v641 : US8 =
        match v635 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v637) -> (* Some *)
            let v638 : string = "flex"
            let v639 : JSX.Prop = JSX.Prop (v638, v637)
            US8_1(v639)
    let v642 : US0 = v543.l14
    let v648 : US8 =
        match v642 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v644) -> (* Some *)
            let v645 : string = "flexDirection"
            let v646 : JSX.Prop = JSX.Prop (v645, v644)
            US8_1(v646)
    let v649 : US0 = v543.l15
    let v655 : US8 =
        match v649 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v651) -> (* Some *)
            let v652 : string = "fontSize"
            let v653 : JSX.Prop = JSX.Prop (v652, v651)
            US8_1(v653)
    let v656 : US0 = v543.l16
    let v662 : US8 =
        match v656 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v658) -> (* Some *)
            let v659 : string = "height"
            let v660 : JSX.Prop = JSX.Prop (v659, v658)
            US8_1(v660)
    let v663 : US0 = v543.l17
    let v669 : US8 =
        match v663 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v665) -> (* Some *)
            let v666 : string = "href"
            let v667 : JSX.Prop = JSX.Prop (v666, v665)
            US8_1(v667)
    let v670 : US5 = v543.l18
    let v676 : US8 =
        match v670 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v672) -> (* Some *)
            let v673 : string = "icon"
            let v674 : JSX.Prop = JSX.Prop (v673, v672)
            US8_1(v674)
    let v677 : US0 = v543.l19
    let v683 : US8 =
        match v677 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v679) -> (* Some *)
            let v680 : string = "id"
            let v681 : JSX.Prop = JSX.Prop (v680, v679)
            US8_1(v681)
    let v684 : US0 = v543.l20
    let v690 : US8 =
        match v684 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v686) -> (* Some *)
            let v687 : string = "justifyContent"
            let v688 : JSX.Prop = JSX.Prop (v687, v686)
            US8_1(v688)
    let v691 : US0 = v543.l21
    let v697 : US8 =
        match v691 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v693) -> (* Some *)
            let v694 : string = "left"
            let v695 : JSX.Prop = JSX.Prop (v694, v693)
            US8_1(v695)
    let v698 : US0 = v543.l22
    let v704 : US8 =
        match v698 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v700) -> (* Some *)
            let v701 : string = "lineHeight"
            let v702 : JSX.Prop = JSX.Prop (v701, v700)
            US8_1(v702)
    let v705 : US0 = v543.l23
    let v711 : US8 =
        match v705 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v707) -> (* Some *)
            let v708 : string = "margin"
            let v709 : JSX.Prop = JSX.Prop (v708, v707)
            US8_1(v709)
    let v712 : US0 = v543.l24
    let v718 : US8 =
        match v712 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v714) -> (* Some *)
            let v715 : string = "marginBottom"
            let v716 : JSX.Prop = JSX.Prop (v715, v714)
            US8_1(v716)
    let v719 : US0 = v543.l25
    let v725 : US8 =
        match v719 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v721) -> (* Some *)
            let v722 : string = "maxHeight"
            let v723 : JSX.Prop = JSX.Prop (v722, v721)
            US8_1(v723)
    let v726 : US6 = v543.l26
    let v732 : US8 =
        match v726 with
        | US6_0 -> (* None *)
            US8_0
        | US6_1(v728) -> (* Some *)
            let v729 : string = "onChange"
            let v730 : JSX.Prop = JSX.Prop (v729, v728)
            US8_1(v730)
    let v733 : US7 = v543.l27
    let v739 : US8 =
        match v733 with
        | US7_0 -> (* None *)
            US8_0
        | US7_1(v735) -> (* Some *)
            let v736 : string = "onClick"
            let v737 : JSX.Prop = JSX.Prop (v736, v735)
            US8_1(v737)
    let v740 : US0 = v543.l28
    let v746 : US8 =
        match v740 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v742) -> (* Some *)
            let v743 : string = "outline"
            let v744 : JSX.Prop = JSX.Prop (v743, v742)
            US8_1(v744)
    let v747 : US0 = v543.l29
    let v753 : US8 =
        match v747 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v749) -> (* Some *)
            let v750 : string = "overflowY"
            let v751 : JSX.Prop = JSX.Prop (v750, v749)
            US8_1(v751)
    let v754 : US0 = v543.l30
    let v760 : US8 =
        match v754 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v756) -> (* Some *)
            let v757 : string = "padding"
            let v758 : JSX.Prop = JSX.Prop (v757, v756)
            US8_1(v758)
    let v761 : US0 = v543.l31
    let v767 : US8 =
        match v761 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v763) -> (* Some *)
            let v764 : string = "paddingTop"
            let v765 : JSX.Prop = JSX.Prop (v764, v763)
            US8_1(v765)
    let v768 : US0 = v543.l32
    let v774 : US8 =
        match v768 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v770) -> (* Some *)
            let v771 : string = "position"
            let v772 : JSX.Prop = JSX.Prop (v771, v770)
            US8_1(v772)
    let v775 : US0 = v543.l33
    let v781 : US8 =
        match v775 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v777) -> (* Some *)
            let v778 : string = "right"
            let v779 : JSX.Prop = JSX.Prop (v778, v777)
            US8_1(v779)
    let v782 : US0 = v543.l34
    let v788 : US8 =
        match v782 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v784) -> (* Some *)
            let v785 : string = "size"
            let v786 : JSX.Prop = JSX.Prop (v785, v784)
            US8_1(v786)
    let v789 : US0 = v543.l35
    let v795 : US8 =
        match v789 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v791) -> (* Some *)
            let v792 : string = "spacing"
            let v793 : JSX.Prop = JSX.Prop (v792, v791)
            US8_1(v793)
    let v796 : US2 = v543.l36
    let v802 : US8 =
        match v796 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v798) -> (* Some *)
            let v799 : string = "status"
            let v800 : JSX.Prop = JSX.Prop (v799, v798)
            US8_1(v800)
    let v803 : US0 = v543.l37
    let v809 : US8 =
        match v803 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v805) -> (* Some *)
            let v806 : string = "striped"
            let v807 : JSX.Prop = JSX.Prop (v806, v805)
            US8_1(v807)
    let v810 : US0 = v543.l38
    let v816 : US8 =
        match v810 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v812) -> (* Some *)
            let v813 : string = "thickness"
            let v814 : JSX.Prop = JSX.Prop (v813, v812)
            US8_1(v814)
    let v817 : US5 = v543.l39
    let v823 : US8 =
        match v817 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v819) -> (* Some *)
            let v820 : string = "title"
            let v821 : JSX.Prop = JSX.Prop (v820, v819)
            US8_1(v821)
    let v824 : US0 = v543.l40
    let v830 : US8 =
        match v824 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v826) -> (* Some *)
            let v827 : string = "top"
            let v828 : JSX.Prop = JSX.Prop (v827, v826)
            US8_1(v828)
    let v831 : US0 = v543.l41
    let v837 : US8 =
        match v831 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v833) -> (* Some *)
            let v834 : string = "width"
            let v835 : JSX.Prop = JSX.Prop (v834, v833)
            US8_1(v835)
    let v838 : US4 = v543.l42
    let v844 : US8 =
        match v838 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v840) -> (* Some *)
            let v841 : string = "zIndex"
            let v842 : JSX.Prop = JSX.Prop (v841, v840)
            US8_1(v842)
    let v845 : (US8 []) = [|v550; v557; v564; v571; v578; v585; v592; v599; v606; v613; v620; v627; v634; v641; v648; v655; v662; v669; v676; v683; v690; v697; v704; v711; v718; v725; v732; v739; v746; v753; v760; v767; v774; v781; v788; v795; v802; v809; v816; v823; v830; v837; v844|]
    let v846 : int32 = v845.Length
    let v847 : (US8 []) = Array.zeroCreate<US8> (v846)
    let v848 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method0(v846, v848) do
        let v850 : int32 = v848.l0
        let v851 : int32 = v848.l1
        let v852 : US8 = v845.[int v850]
        let v854 : bool =
            match v852 with
            | US8_0 -> (* None *)
                false
            | US8_1(v853) -> (* Some *)
                true
        let v856 : int32 =
            if v854 then
                v847.[int v851] <- v852
                let v855 : int32 = v851 + 1
                v855
            else
                v851
        let v857 : int32 = v850 + 1
        v848.l0 <- v857
        v848.l1 <- v856
        ()
    let v858 : int32 = v848.l1
    let v859 : (US8 []) = Array.zeroCreate<US8> (v858)
    let v860 : Mut1 = {l0 = 0} : Mut1
    while method1(v858, v860) do
        let v862 : int32 = v860.l0
        let v863 : US8 = v847.[int v862]
        v859.[int v862] <- v863
        let v864 : int32 = v862 + 1
        v860.l0 <- v864
        ()
    let v865 : int32 = v859.Length
    let v866 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v865)
    let v867 : Mut1 = {l0 = 0} : Mut1
    while method1(v865, v867) do
        let v869 : int32 = v867.l0
        let v870 : US8 = v859.[int v869]
        let v873 : JSX.Prop =
            match v870 with
            | US8_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US8_1(v872) -> (* Some *)
                v872
        v866.[int v869] <- v873
        let v874 : int32 = v869 + 1
        v867.l0 <- v874
        ()
    let v875 : obj = createObj v866
    let v876 : JS.Function = import v53 v54
    let v877 : JSX.Element = v876.Invoke ((import v439 v440), v875) |> unbox<JSX.Element>
    let v878 : string = "BiRegularUndo"
    let v879 : JS.Function = import v878 v5
    let v880 : US0 = US0_0
    let v881 : US1 = US1_0
    let v882 : US0 = US0_0
    let v883 : US0 = US0_0
    let v884 : US0 = US0_0
    let v885 : US2 = US2_0
    let v886 : US3 = US3_0
    let v887 : US0 = US0_0
    let v888 : US0 = US0_0
    let v889 : US2 = US2_0
    let v890 : US0 = US0_0
    let v891 : US0 = US0_0
    let v892 : US2 = US2_0
    let v893 : US4 = US4_0
    let v894 : US0 = US0_0
    let v895 : US0 = US0_0
    let v896 : US0 = US0_0
    let v897 : US0 = US0_0
    let v898 : US5 = US5_0
    let v899 : US0 = US0_0
    let v900 : US0 = US0_0
    let v901 : US0 = US0_0
    let v902 : US0 = US0_0
    let v903 : US0 = US0_0
    let v904 : US0 = US0_0
    let v905 : US0 = US0_0
    let v906 : US6 = US6_0
    let v907 : US7 = US7_0
    let v908 : US0 = US0_0
    let v909 : US0 = US0_0
    let v910 : US0 = US0_0
    let v911 : US0 = US0_0
    let v912 : US0 = US0_0
    let v913 : US0 = US0_0
    let v914 : US0 = US0_1(v41)
    let v915 : US0 = US0_0
    let v916 : US2 = US2_0
    let v917 : US0 = US0_0
    let v918 : US0 = US0_0
    let v919 : US5 = US5_0
    let v920 : US0 = US0_0
    let v921 : US0 = US0_0
    let v922 : US4 = US4_0
    let v923 : Heap0 = {l0 = v880; l1 = v881; l2 = v882; l3 = v883; l4 = v884; l5 = v885; l6 = v886; l7 = v887; l8 = v888; l9 = v889; l10 = v890; l11 = v891; l12 = v892; l13 = v893; l14 = v894; l15 = v895; l16 = v896; l17 = v897; l18 = v898; l19 = v899; l20 = v900; l21 = v901; l22 = v902; l23 = v903; l24 = v904; l25 = v905; l26 = v906; l27 = v907; l28 = v908; l29 = v909; l30 = v910; l31 = v911; l32 = v912; l33 = v913; l34 = v914; l35 = v915; l36 = v916; l37 = v917; l38 = v918; l39 = v919; l40 = v920; l41 = v921; l42 = v922} : Heap0
    let v924 : JS.Function = v879 |> unbox<JS.Function>
    let v925 : JS.Function = import v53 v54
    let v926 : JSX.Element = v925.Invoke (v924, v923) |> unbox<JSX.Element>
    let v927 : string = "Unload"
    let v928 : US0 = US0_1(v927)
    let v929 : US1 = US1_0
    let v930 : US0 = US0_0
    let v931 : US0 = US0_0
    let v932 : US0 = US0_0
    let v933 : US2 = US2_0
    let v934 : US3 = US3_0
    let v935 : US0 = US0_0
    let v936 : US0 = US0_1(v66)
    let v937 : US2 = US2_0
    let v938 : US0 = US0_0
    let v939 : US0 = US0_0
    let v940 : US2 = US2_0
    let v941 : US4 = US4_0
    let v942 : US0 = US0_0
    let v943 : US0 = US0_0
    let v944 : US0 = US0_1(v75)
    let v945 : US0 = US0_0
    let v946 : US5 = US5_1(v926)
    let v947 : US0 = US0_0
    let v948 : US0 = US0_0
    let v949 : US0 = US0_0
    let v950 : US0 = US0_0
    let v951 : US0 = US0_0
    let v952 : US0 = US0_0
    let v953 : US0 = US0_0
    let v954 : US6 = US6_0
    let v955 : (unit -> unit) = closure31(v0)
    let v956 : US7 = US7_1(v955)
    let v957 : US0 = US0_0
    let v958 : US0 = US0_0
    let v959 : US0 = US0_0
    let v960 : US0 = US0_0
    let v961 : US0 = US0_0
    let v962 : US0 = US0_0
    let v963 : US0 = US0_1(v95)
    let v964 : US0 = US0_0
    let v965 : US2 = US2_0
    let v966 : US0 = US0_0
    let v967 : US0 = US0_0
    let v968 : US5 = US5_0
    let v969 : US0 = US0_0
    let v970 : US0 = US0_0
    let v971 : US4 = US4_0
    let v972 : Heap0 = {l0 = v928; l1 = v929; l2 = v930; l3 = v931; l4 = v932; l5 = v933; l6 = v934; l7 = v935; l8 = v936; l9 = v937; l10 = v938; l11 = v939; l12 = v940; l13 = v941; l14 = v942; l15 = v943; l16 = v944; l17 = v945; l18 = v946; l19 = v947; l20 = v948; l21 = v949; l22 = v950; l23 = v951; l24 = v952; l25 = v953; l26 = v954; l27 = v956; l28 = v957; l29 = v958; l30 = v959; l31 = v960; l32 = v961; l33 = v962; l34 = v963; l35 = v964; l36 = v965; l37 = v966; l38 = v967; l39 = v968; l40 = v969; l41 = v970; l42 = v971} : Heap0
    let v973 : US0 = v972.l0
    let v979 : US8 =
        match v973 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v975) -> (* Some *)
            let v976 : string = "aria-label"
            let v977 : JSX.Prop = JSX.Prop (v976, v975)
            US8_1(v977)
    let v980 : US1 = v972.l1
    let v986 : US8 =
        match v980 with
        | US1_0 -> (* None *)
            US8_0
        | US1_1(v982) -> (* Some *)
            let v983 : string = "as"
            let v984 : JSX.Prop = JSX.Prop (v983, v982)
            US8_1(v984)
    let v987 : US0 = v972.l2
    let v993 : US8 =
        match v987 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v989) -> (* Some *)
            let v990 : string = "backgroundColor"
            let v991 : JSX.Prop = JSX.Prop (v990, v989)
            US8_1(v991)
    let v994 : US0 = v972.l3
    let v1000 : US8 =
        match v994 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v996) -> (* Some *)
            let v997 : string = "border"
            let v998 : JSX.Prop = JSX.Prop (v997, v996)
            US8_1(v998)
    let v1001 : US0 = v972.l4
    let v1007 : US8 =
        match v1001 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1003) -> (* Some *)
            let v1004 : string = "bottom"
            let v1005 : JSX.Prop = JSX.Prop (v1004, v1003)
            US8_1(v1005)
    let v1008 : US0 = v972.l7
    let v1014 : US8 =
        match v1008 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1010) -> (* Some *)
            let v1011 : string = "color"
            let v1012 : JSX.Prop = JSX.Prop (v1011, v1010)
            US8_1(v1012)
    let v1015 : US2 = v972.l5
    let v1021 : US8 =
        match v1015 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v1017) -> (* Some *)
            let v1018 : string = "checked"
            let v1019 : JSX.Prop = JSX.Prop (v1018, v1017)
            US8_1(v1019)
    let v1022 : US3 = v972.l6
    let v1028 : US8 =
        match v1022 with
        | US3_0 -> (* None *)
            US8_0
        | US3_1(v1024) -> (* Some *)
            let v1025 : string = "children"
            let v1026 : JSX.Prop = JSX.Prop (v1025, v1024)
            US8_1(v1026)
    let v1029 : US0 = v972.l8
    let v1035 : US8 =
        match v1029 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1031) -> (* Some *)
            let v1032 : string = "colorScheme"
            let v1033 : JSX.Prop = JSX.Prop (v1032, v1031)
            US8_1(v1033)
    let v1036 : US2 = v972.l9
    let v1042 : US8 =
        match v1036 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v1038) -> (* Some *)
            let v1039 : string = "compact"
            let v1040 : JSX.Prop = JSX.Prop (v1039, v1038)
            US8_1(v1040)
    let v1043 : US0 = v972.l11
    let v1049 : US8 =
        match v1043 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1045) -> (* Some *)
            let v1046 : string = "display"
            let v1047 : JSX.Prop = JSX.Prop (v1046, v1045)
            US8_1(v1047)
    let v1050 : US0 = v972.l10
    let v1056 : US8 =
        match v1050 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1052) -> (* Some *)
            let v1053 : string = "direction"
            let v1054 : JSX.Prop = JSX.Prop (v1053, v1052)
            US8_1(v1054)
    let v1057 : US2 = v972.l12
    let v1063 : US8 =
        match v1057 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v1059) -> (* Some *)
            let v1060 : string = "external"
            let v1061 : JSX.Prop = JSX.Prop (v1060, v1059)
            US8_1(v1061)
    let v1064 : US4 = v972.l13
    let v1070 : US8 =
        match v1064 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v1066) -> (* Some *)
            let v1067 : string = "flex"
            let v1068 : JSX.Prop = JSX.Prop (v1067, v1066)
            US8_1(v1068)
    let v1071 : US0 = v972.l14
    let v1077 : US8 =
        match v1071 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1073) -> (* Some *)
            let v1074 : string = "flexDirection"
            let v1075 : JSX.Prop = JSX.Prop (v1074, v1073)
            US8_1(v1075)
    let v1078 : US0 = v972.l15
    let v1084 : US8 =
        match v1078 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1080) -> (* Some *)
            let v1081 : string = "fontSize"
            let v1082 : JSX.Prop = JSX.Prop (v1081, v1080)
            US8_1(v1082)
    let v1085 : US0 = v972.l16
    let v1091 : US8 =
        match v1085 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1087) -> (* Some *)
            let v1088 : string = "height"
            let v1089 : JSX.Prop = JSX.Prop (v1088, v1087)
            US8_1(v1089)
    let v1092 : US0 = v972.l17
    let v1098 : US8 =
        match v1092 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1094) -> (* Some *)
            let v1095 : string = "href"
            let v1096 : JSX.Prop = JSX.Prop (v1095, v1094)
            US8_1(v1096)
    let v1099 : US5 = v972.l18
    let v1105 : US8 =
        match v1099 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v1101) -> (* Some *)
            let v1102 : string = "icon"
            let v1103 : JSX.Prop = JSX.Prop (v1102, v1101)
            US8_1(v1103)
    let v1106 : US0 = v972.l19
    let v1112 : US8 =
        match v1106 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1108) -> (* Some *)
            let v1109 : string = "id"
            let v1110 : JSX.Prop = JSX.Prop (v1109, v1108)
            US8_1(v1110)
    let v1113 : US0 = v972.l20
    let v1119 : US8 =
        match v1113 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1115) -> (* Some *)
            let v1116 : string = "justifyContent"
            let v1117 : JSX.Prop = JSX.Prop (v1116, v1115)
            US8_1(v1117)
    let v1120 : US0 = v972.l21
    let v1126 : US8 =
        match v1120 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1122) -> (* Some *)
            let v1123 : string = "left"
            let v1124 : JSX.Prop = JSX.Prop (v1123, v1122)
            US8_1(v1124)
    let v1127 : US0 = v972.l22
    let v1133 : US8 =
        match v1127 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1129) -> (* Some *)
            let v1130 : string = "lineHeight"
            let v1131 : JSX.Prop = JSX.Prop (v1130, v1129)
            US8_1(v1131)
    let v1134 : US0 = v972.l23
    let v1140 : US8 =
        match v1134 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1136) -> (* Some *)
            let v1137 : string = "margin"
            let v1138 : JSX.Prop = JSX.Prop (v1137, v1136)
            US8_1(v1138)
    let v1141 : US0 = v972.l24
    let v1147 : US8 =
        match v1141 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1143) -> (* Some *)
            let v1144 : string = "marginBottom"
            let v1145 : JSX.Prop = JSX.Prop (v1144, v1143)
            US8_1(v1145)
    let v1148 : US0 = v972.l25
    let v1154 : US8 =
        match v1148 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1150) -> (* Some *)
            let v1151 : string = "maxHeight"
            let v1152 : JSX.Prop = JSX.Prop (v1151, v1150)
            US8_1(v1152)
    let v1155 : US6 = v972.l26
    let v1161 : US8 =
        match v1155 with
        | US6_0 -> (* None *)
            US8_0
        | US6_1(v1157) -> (* Some *)
            let v1158 : string = "onChange"
            let v1159 : JSX.Prop = JSX.Prop (v1158, v1157)
            US8_1(v1159)
    let v1162 : US7 = v972.l27
    let v1168 : US8 =
        match v1162 with
        | US7_0 -> (* None *)
            US8_0
        | US7_1(v1164) -> (* Some *)
            let v1165 : string = "onClick"
            let v1166 : JSX.Prop = JSX.Prop (v1165, v1164)
            US8_1(v1166)
    let v1169 : US0 = v972.l28
    let v1175 : US8 =
        match v1169 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1171) -> (* Some *)
            let v1172 : string = "outline"
            let v1173 : JSX.Prop = JSX.Prop (v1172, v1171)
            US8_1(v1173)
    let v1176 : US0 = v972.l29
    let v1182 : US8 =
        match v1176 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1178) -> (* Some *)
            let v1179 : string = "overflowY"
            let v1180 : JSX.Prop = JSX.Prop (v1179, v1178)
            US8_1(v1180)
    let v1183 : US0 = v972.l30
    let v1189 : US8 =
        match v1183 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1185) -> (* Some *)
            let v1186 : string = "padding"
            let v1187 : JSX.Prop = JSX.Prop (v1186, v1185)
            US8_1(v1187)
    let v1190 : US0 = v972.l31
    let v1196 : US8 =
        match v1190 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1192) -> (* Some *)
            let v1193 : string = "paddingTop"
            let v1194 : JSX.Prop = JSX.Prop (v1193, v1192)
            US8_1(v1194)
    let v1197 : US0 = v972.l32
    let v1203 : US8 =
        match v1197 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1199) -> (* Some *)
            let v1200 : string = "position"
            let v1201 : JSX.Prop = JSX.Prop (v1200, v1199)
            US8_1(v1201)
    let v1204 : US0 = v972.l33
    let v1210 : US8 =
        match v1204 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1206) -> (* Some *)
            let v1207 : string = "right"
            let v1208 : JSX.Prop = JSX.Prop (v1207, v1206)
            US8_1(v1208)
    let v1211 : US0 = v972.l34
    let v1217 : US8 =
        match v1211 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1213) -> (* Some *)
            let v1214 : string = "size"
            let v1215 : JSX.Prop = JSX.Prop (v1214, v1213)
            US8_1(v1215)
    let v1218 : US0 = v972.l35
    let v1224 : US8 =
        match v1218 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1220) -> (* Some *)
            let v1221 : string = "spacing"
            let v1222 : JSX.Prop = JSX.Prop (v1221, v1220)
            US8_1(v1222)
    let v1225 : US2 = v972.l36
    let v1231 : US8 =
        match v1225 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v1227) -> (* Some *)
            let v1228 : string = "status"
            let v1229 : JSX.Prop = JSX.Prop (v1228, v1227)
            US8_1(v1229)
    let v1232 : US0 = v972.l37
    let v1238 : US8 =
        match v1232 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1234) -> (* Some *)
            let v1235 : string = "striped"
            let v1236 : JSX.Prop = JSX.Prop (v1235, v1234)
            US8_1(v1236)
    let v1239 : US0 = v972.l38
    let v1245 : US8 =
        match v1239 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1241) -> (* Some *)
            let v1242 : string = "thickness"
            let v1243 : JSX.Prop = JSX.Prop (v1242, v1241)
            US8_1(v1243)
    let v1246 : US5 = v972.l39
    let v1252 : US8 =
        match v1246 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v1248) -> (* Some *)
            let v1249 : string = "title"
            let v1250 : JSX.Prop = JSX.Prop (v1249, v1248)
            US8_1(v1250)
    let v1253 : US0 = v972.l40
    let v1259 : US8 =
        match v1253 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1255) -> (* Some *)
            let v1256 : string = "top"
            let v1257 : JSX.Prop = JSX.Prop (v1256, v1255)
            US8_1(v1257)
    let v1260 : US0 = v972.l41
    let v1266 : US8 =
        match v1260 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v1262) -> (* Some *)
            let v1263 : string = "width"
            let v1264 : JSX.Prop = JSX.Prop (v1263, v1262)
            US8_1(v1264)
    let v1267 : US4 = v972.l42
    let v1273 : US8 =
        match v1267 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v1269) -> (* Some *)
            let v1270 : string = "zIndex"
            let v1271 : JSX.Prop = JSX.Prop (v1270, v1269)
            US8_1(v1271)
    let v1274 : (US8 []) = [|v979; v986; v993; v1000; v1007; v1014; v1021; v1028; v1035; v1042; v1049; v1056; v1063; v1070; v1077; v1084; v1091; v1098; v1105; v1112; v1119; v1126; v1133; v1140; v1147; v1154; v1161; v1168; v1175; v1182; v1189; v1196; v1203; v1210; v1217; v1224; v1231; v1238; v1245; v1252; v1259; v1266; v1273|]
    let v1275 : int32 = v1274.Length
    let v1276 : (US8 []) = Array.zeroCreate<US8> (v1275)
    let v1277 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method0(v1275, v1277) do
        let v1279 : int32 = v1277.l0
        let v1280 : int32 = v1277.l1
        let v1281 : US8 = v1274.[int v1279]
        let v1283 : bool =
            match v1281 with
            | US8_0 -> (* None *)
                false
            | US8_1(v1282) -> (* Some *)
                true
        let v1285 : int32 =
            if v1283 then
                v1276.[int v1280] <- v1281
                let v1284 : int32 = v1280 + 1
                v1284
            else
                v1280
        let v1286 : int32 = v1279 + 1
        v1277.l0 <- v1286
        v1277.l1 <- v1285
        ()
    let v1287 : int32 = v1277.l1
    let v1288 : (US8 []) = Array.zeroCreate<US8> (v1287)
    let v1289 : Mut1 = {l0 = 0} : Mut1
    while method1(v1287, v1289) do
        let v1291 : int32 = v1289.l0
        let v1292 : US8 = v1276.[int v1291]
        v1288.[int v1291] <- v1292
        let v1293 : int32 = v1291 + 1
        v1289.l0 <- v1293
        ()
    let v1294 : int32 = v1288.Length
    let v1295 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v1294)
    let v1296 : Mut1 = {l0 = 0} : Mut1
    while method1(v1294, v1296) do
        let v1298 : int32 = v1296.l0
        let v1299 : US8 = v1288.[int v1298]
        let v1302 : JSX.Prop =
            match v1299 with
            | US8_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US8_1(v1301) -> (* Some *)
                v1301
        v1295.[int v1298] <- v1302
        let v1303 : int32 = v1298 + 1
        v1296.l0 <- v1303
        ()
    let v1304 : obj = createObj v1295
    let v1305 : JS.Function = import v53 v54
    let v1306 : JSX.Element = v1305.Invoke ((import v439 v440), v1304) |> unbox<JSX.Element>
    let v1307 : (JSX.Element []) = [|v441; v877; v1306|]
    let v1308 : JSX.Element = v1307 |> unbox<JSX.Element>
    v1308
and closure32 () (v0 : Heap0) : JSX.Element =
    let v1 : US0 = v0.l0
    let v7 : US8 =
        match v1 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v3) -> (* Some *)
            let v4 : string = "aria-label"
            let v5 : JSX.Prop = JSX.Prop (v4, v3)
            US8_1(v5)
    let v8 : US1 = v0.l1
    let v14 : US8 =
        match v8 with
        | US1_0 -> (* None *)
            US8_0
        | US1_1(v10) -> (* Some *)
            let v11 : string = "as"
            let v12 : JSX.Prop = JSX.Prop (v11, v10)
            US8_1(v12)
    let v15 : US0 = v0.l2
    let v21 : US8 =
        match v15 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v17) -> (* Some *)
            let v18 : string = "backgroundColor"
            let v19 : JSX.Prop = JSX.Prop (v18, v17)
            US8_1(v19)
    let v22 : US0 = v0.l3
    let v28 : US8 =
        match v22 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v24) -> (* Some *)
            let v25 : string = "border"
            let v26 : JSX.Prop = JSX.Prop (v25, v24)
            US8_1(v26)
    let v29 : US0 = v0.l4
    let v35 : US8 =
        match v29 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v31) -> (* Some *)
            let v32 : string = "bottom"
            let v33 : JSX.Prop = JSX.Prop (v32, v31)
            US8_1(v33)
    let v36 : US0 = v0.l7
    let v42 : US8 =
        match v36 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v38) -> (* Some *)
            let v39 : string = "color"
            let v40 : JSX.Prop = JSX.Prop (v39, v38)
            US8_1(v40)
    let v43 : US2 = v0.l5
    let v49 : US8 =
        match v43 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v45) -> (* Some *)
            let v46 : string = "checked"
            let v47 : JSX.Prop = JSX.Prop (v46, v45)
            US8_1(v47)
    let v50 : US3 = v0.l6
    let v56 : US8 =
        match v50 with
        | US3_0 -> (* None *)
            US8_0
        | US3_1(v52) -> (* Some *)
            let v53 : string = "children"
            let v54 : JSX.Prop = JSX.Prop (v53, v52)
            US8_1(v54)
    let v57 : US0 = v0.l8
    let v63 : US8 =
        match v57 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v59) -> (* Some *)
            let v60 : string = "colorScheme"
            let v61 : JSX.Prop = JSX.Prop (v60, v59)
            US8_1(v61)
    let v64 : US2 = v0.l9
    let v70 : US8 =
        match v64 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v66) -> (* Some *)
            let v67 : string = "compact"
            let v68 : JSX.Prop = JSX.Prop (v67, v66)
            US8_1(v68)
    let v71 : US0 = v0.l11
    let v77 : US8 =
        match v71 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v73) -> (* Some *)
            let v74 : string = "display"
            let v75 : JSX.Prop = JSX.Prop (v74, v73)
            US8_1(v75)
    let v78 : US0 = v0.l10
    let v84 : US8 =
        match v78 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v80) -> (* Some *)
            let v81 : string = "direction"
            let v82 : JSX.Prop = JSX.Prop (v81, v80)
            US8_1(v82)
    let v85 : US2 = v0.l12
    let v91 : US8 =
        match v85 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v87) -> (* Some *)
            let v88 : string = "external"
            let v89 : JSX.Prop = JSX.Prop (v88, v87)
            US8_1(v89)
    let v92 : US4 = v0.l13
    let v98 : US8 =
        match v92 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v94) -> (* Some *)
            let v95 : string = "flex"
            let v96 : JSX.Prop = JSX.Prop (v95, v94)
            US8_1(v96)
    let v99 : US0 = v0.l14
    let v105 : US8 =
        match v99 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v101) -> (* Some *)
            let v102 : string = "flexDirection"
            let v103 : JSX.Prop = JSX.Prop (v102, v101)
            US8_1(v103)
    let v106 : US0 = v0.l15
    let v112 : US8 =
        match v106 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v108) -> (* Some *)
            let v109 : string = "fontSize"
            let v110 : JSX.Prop = JSX.Prop (v109, v108)
            US8_1(v110)
    let v113 : US0 = v0.l16
    let v119 : US8 =
        match v113 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v115) -> (* Some *)
            let v116 : string = "height"
            let v117 : JSX.Prop = JSX.Prop (v116, v115)
            US8_1(v117)
    let v120 : US0 = v0.l17
    let v126 : US8 =
        match v120 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v122) -> (* Some *)
            let v123 : string = "href"
            let v124 : JSX.Prop = JSX.Prop (v123, v122)
            US8_1(v124)
    let v127 : US5 = v0.l18
    let v133 : US8 =
        match v127 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v129) -> (* Some *)
            let v130 : string = "icon"
            let v131 : JSX.Prop = JSX.Prop (v130, v129)
            US8_1(v131)
    let v134 : US0 = v0.l19
    let v140 : US8 =
        match v134 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v136) -> (* Some *)
            let v137 : string = "id"
            let v138 : JSX.Prop = JSX.Prop (v137, v136)
            US8_1(v138)
    let v141 : US0 = v0.l20
    let v147 : US8 =
        match v141 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v143) -> (* Some *)
            let v144 : string = "justifyContent"
            let v145 : JSX.Prop = JSX.Prop (v144, v143)
            US8_1(v145)
    let v148 : US0 = v0.l21
    let v154 : US8 =
        match v148 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v150) -> (* Some *)
            let v151 : string = "left"
            let v152 : JSX.Prop = JSX.Prop (v151, v150)
            US8_1(v152)
    let v155 : US0 = v0.l22
    let v161 : US8 =
        match v155 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v157) -> (* Some *)
            let v158 : string = "lineHeight"
            let v159 : JSX.Prop = JSX.Prop (v158, v157)
            US8_1(v159)
    let v162 : US0 = v0.l23
    let v168 : US8 =
        match v162 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v164) -> (* Some *)
            let v165 : string = "margin"
            let v166 : JSX.Prop = JSX.Prop (v165, v164)
            US8_1(v166)
    let v169 : US0 = v0.l24
    let v175 : US8 =
        match v169 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v171) -> (* Some *)
            let v172 : string = "marginBottom"
            let v173 : JSX.Prop = JSX.Prop (v172, v171)
            US8_1(v173)
    let v176 : US0 = v0.l25
    let v182 : US8 =
        match v176 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v178) -> (* Some *)
            let v179 : string = "maxHeight"
            let v180 : JSX.Prop = JSX.Prop (v179, v178)
            US8_1(v180)
    let v183 : US6 = v0.l26
    let v189 : US8 =
        match v183 with
        | US6_0 -> (* None *)
            US8_0
        | US6_1(v185) -> (* Some *)
            let v186 : string = "onChange"
            let v187 : JSX.Prop = JSX.Prop (v186, v185)
            US8_1(v187)
    let v190 : US7 = v0.l27
    let v196 : US8 =
        match v190 with
        | US7_0 -> (* None *)
            US8_0
        | US7_1(v192) -> (* Some *)
            let v193 : string = "onClick"
            let v194 : JSX.Prop = JSX.Prop (v193, v192)
            US8_1(v194)
    let v197 : US0 = v0.l28
    let v203 : US8 =
        match v197 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v199) -> (* Some *)
            let v200 : string = "outline"
            let v201 : JSX.Prop = JSX.Prop (v200, v199)
            US8_1(v201)
    let v204 : US0 = v0.l29
    let v210 : US8 =
        match v204 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v206) -> (* Some *)
            let v207 : string = "overflowY"
            let v208 : JSX.Prop = JSX.Prop (v207, v206)
            US8_1(v208)
    let v211 : US0 = v0.l30
    let v217 : US8 =
        match v211 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v213) -> (* Some *)
            let v214 : string = "padding"
            let v215 : JSX.Prop = JSX.Prop (v214, v213)
            US8_1(v215)
    let v218 : US0 = v0.l31
    let v224 : US8 =
        match v218 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v220) -> (* Some *)
            let v221 : string = "paddingTop"
            let v222 : JSX.Prop = JSX.Prop (v221, v220)
            US8_1(v222)
    let v225 : US0 = v0.l32
    let v231 : US8 =
        match v225 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v227) -> (* Some *)
            let v228 : string = "position"
            let v229 : JSX.Prop = JSX.Prop (v228, v227)
            US8_1(v229)
    let v232 : US0 = v0.l33
    let v238 : US8 =
        match v232 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v234) -> (* Some *)
            let v235 : string = "right"
            let v236 : JSX.Prop = JSX.Prop (v235, v234)
            US8_1(v236)
    let v239 : US0 = v0.l34
    let v245 : US8 =
        match v239 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v241) -> (* Some *)
            let v242 : string = "size"
            let v243 : JSX.Prop = JSX.Prop (v242, v241)
            US8_1(v243)
    let v246 : US0 = v0.l35
    let v252 : US8 =
        match v246 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v248) -> (* Some *)
            let v249 : string = "spacing"
            let v250 : JSX.Prop = JSX.Prop (v249, v248)
            US8_1(v250)
    let v253 : US2 = v0.l36
    let v259 : US8 =
        match v253 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v255) -> (* Some *)
            let v256 : string = "status"
            let v257 : JSX.Prop = JSX.Prop (v256, v255)
            US8_1(v257)
    let v260 : US0 = v0.l37
    let v266 : US8 =
        match v260 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v262) -> (* Some *)
            let v263 : string = "striped"
            let v264 : JSX.Prop = JSX.Prop (v263, v262)
            US8_1(v264)
    let v267 : US0 = v0.l38
    let v273 : US8 =
        match v267 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v269) -> (* Some *)
            let v270 : string = "thickness"
            let v271 : JSX.Prop = JSX.Prop (v270, v269)
            US8_1(v271)
    let v274 : US5 = v0.l39
    let v280 : US8 =
        match v274 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v276) -> (* Some *)
            let v277 : string = "title"
            let v278 : JSX.Prop = JSX.Prop (v277, v276)
            US8_1(v278)
    let v281 : US0 = v0.l40
    let v287 : US8 =
        match v281 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v283) -> (* Some *)
            let v284 : string = "top"
            let v285 : JSX.Prop = JSX.Prop (v284, v283)
            US8_1(v285)
    let v288 : US0 = v0.l41
    let v294 : US8 =
        match v288 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v290) -> (* Some *)
            let v291 : string = "width"
            let v292 : JSX.Prop = JSX.Prop (v291, v290)
            US8_1(v292)
    let v295 : US4 = v0.l42
    let v301 : US8 =
        match v295 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v297) -> (* Some *)
            let v298 : string = "zIndex"
            let v299 : JSX.Prop = JSX.Prop (v298, v297)
            US8_1(v299)
    let v302 : (US8 []) = [|v7; v14; v21; v28; v35; v42; v49; v56; v63; v70; v77; v84; v91; v98; v105; v112; v119; v126; v133; v140; v147; v154; v161; v168; v175; v182; v189; v196; v203; v210; v217; v224; v231; v238; v245; v252; v259; v266; v273; v280; v287; v294; v301|]
    let v303 : int32 = v302.Length
    let v304 : (US8 []) = Array.zeroCreate<US8> (v303)
    let v305 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method0(v303, v305) do
        let v307 : int32 = v305.l0
        let v308 : int32 = v305.l1
        let v309 : US8 = v302.[int v307]
        let v311 : bool =
            match v309 with
            | US8_0 -> (* None *)
                false
            | US8_1(v310) -> (* Some *)
                true
        let v313 : int32 =
            if v311 then
                v304.[int v308] <- v309
                let v312 : int32 = v308 + 1
                v312
            else
                v308
        let v314 : int32 = v307 + 1
        v305.l0 <- v314
        v305.l1 <- v313
        ()
    let v315 : int32 = v305.l1
    let v316 : (US8 []) = Array.zeroCreate<US8> (v315)
    let v317 : Mut1 = {l0 = 0} : Mut1
    while method1(v315, v317) do
        let v319 : int32 = v317.l0
        let v320 : US8 = v304.[int v319]
        v316.[int v319] <- v320
        let v321 : int32 = v319 + 1
        v317.l0 <- v321
        ()
    let v322 : int32 = v316.Length
    let v323 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v322)
    let v324 : Mut1 = {l0 = 0} : Mut1
    while method1(v322, v324) do
        let v326 : int32 = v324.l0
        let v327 : US8 = v316.[int v326]
        let v330 : JSX.Prop =
            match v327 with
            | US8_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US8_1(v329) -> (* Some *)
                v329
        v323.[int v326] <- v330
        let v331 : int32 = v326 + 1
        v324.l0 <- v331
        ()
    let v332 : obj = createObj v323
    let v333 : string = "createComponent"
    let v334 : string = "solid-js"
    let v335 : JS.Function = import v333 v334
    let v336 : string = "Stack"
    let v337 : string = "@hope-ui/solid"
    let v338 : JSX.Element = v335.Invoke ((import v336 v337), v332) |> unbox<JSX.Element>
    v338
and closure27 (v0 : int32, v1 : (bool -> unit), v2 : (bool -> unit), v3 : (unit -> bool), v4 : (bool -> unit), v5 : (unit -> bool), v6 : (unit -> JSX.Element)) () : JSX.Element =
    let v10 : US0 = US0_0
    let v11 : US1 = US1_0
    let v12 : US0 = US0_0
    let v13 : US0 = US0_0
    let v14 : US0 = US0_0
    let v15 : US2 = US2_0
    let v16 : (unit -> JSX.Element) = closure28(v1, v2, v4, v5)
    let v17 : US3 = US3_1(v16)
    let v18 : US0 = US0_0
    let v19 : US0 = US0_0
    let v20 : US2 = US2_0
    let v21 : string = "row"
    let v22 : US0 = US0_1(v21)
    let v23 : US0 = US0_0
    let v24 : US2 = US2_0
    let v25 : US4 = US4_0
    let v26 : US0 = US0_0
    let v27 : US0 = US0_0
    let v28 : US0 = US0_0
    let v29 : US0 = US0_0
    let v30 : US5 = US5_0
    let v31 : US0 = US0_0
    let v32 : US0 = US0_0
    let v33 : US0 = US0_0
    let v34 : US0 = US0_0
    let v35 : US0 = US0_0
    let v36 : US0 = US0_0
    let v37 : US0 = US0_0
    let v38 : US6 = US6_0
    let v39 : US7 = US7_0
    let v40 : US0 = US0_0
    let v41 : US0 = US0_0
    let v42 : US0 = US0_0
    let v43 : US0 = US0_0
    let v44 : string = "absolute"
    let v45 : US0 = US0_1(v44)
    let v46 : string = "6px"
    let v47 : US0 = US0_1(v46)
    let v48 : US0 = US0_0
    let v49 : string = "3px"
    let v50 : US0 = US0_1(v49)
    let v51 : US2 = US2_0
    let v52 : US0 = US0_0
    let v53 : US0 = US0_0
    let v54 : US5 = US5_0
    let v55 : US0 = US0_1(v46)
    let v56 : US0 = US0_0
    let v57 : US4 = US4_1(1)
    let v58 : Heap0 = {l0 = v10; l1 = v11; l2 = v12; l3 = v13; l4 = v14; l5 = v15; l6 = v17; l7 = v18; l8 = v19; l9 = v20; l10 = v22; l11 = v23; l12 = v24; l13 = v25; l14 = v26; l15 = v27; l16 = v28; l17 = v29; l18 = v30; l19 = v31; l20 = v32; l21 = v33; l22 = v34; l23 = v35; l24 = v36; l25 = v37; l26 = v38; l27 = v39; l28 = v40; l29 = v41; l30 = v42; l31 = v43; l32 = v45; l33 = v47; l34 = v48; l35 = v50; l36 = v51; l37 = v52; l38 = v53; l39 = v54; l40 = v55; l41 = v56; l42 = v57} : Heap0
    let v59 : (Heap0 -> JSX.Element) = closure32()
    let v60 : JS.Function = v59 |> unbox<JS.Function>
    let v61 : string = "createComponent"
    let v62 : string = "solid-js"
    let v63 : JS.Function = import v61 v62
    let v64 : JSX.Element = v63.Invoke (v60, v58) |> unbox<JSX.Element>
    let v65 : bool = v3 ()
    let v66 : bool = v65 = false
    let v69 : JSX.Element =
        if v66 then
            let v67 : JSX.Element = v6 ()
            v67
        else
            let v68 : JSX.Element = Html.fragment []
            v68
    let v70 : (JSX.Element []) = [|v64; v69|]
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    v71
and closure26 (v0 : Heap0, v1 : int32, v2 : (bool -> unit), v3 : (bool -> unit), v4 : (unit -> bool), v5 : (bool -> unit), v6 : (unit -> bool)) () : JSX.Element =
    let v7 : US3 = v0.l6
    let v62 : JSX.Element =
        match v7 with
        | US3_0 -> (* None *)
            let v8 : JSX.Element = Html.fragment []
            v8
        | US3_1(v9) -> (* Some *)
            let v10 : US0 = US0_0
            let v11 : US1 = US1_0
            let v12 : US0 = US0_0
            let v13 : US0 = US0_0
            let v14 : US0 = US0_0
            let v15 : US2 = US2_0
            let v16 : (unit -> JSX.Element) = closure27(v1, v2, v3, v4, v5, v6, v9)
            let v17 : US3 = US3_1(v16)
            let v18 : US0 = US0_0
            let v19 : US0 = US0_0
            let v20 : US2 = US2_0
            let v21 : US0 = US0_0
            let v22 : string = "flex"
            let v23 : US0 = US0_1(v22)
            let v24 : US2 = US2_0
            let v25 : US4 = US4_1(1)
            let v26 : US0 = US0_0
            let v27 : US0 = US0_0
            let v28 : US0 = US0_0
            let v29 : US0 = US0_0
            let v30 : US5 = US5_0
            let v31 : US0 = US0_0
            let v32 : US0 = US0_0
            let v33 : US0 = US0_0
            let v34 : US0 = US0_0
            let v35 : US0 = US0_0
            let v36 : US0 = US0_0
            let v37 : US0 = US0_0
            let v38 : US6 = US6_0
            let v39 : US7 = US7_0
            let v40 : US0 = US0_0
            let v41 : US0 = US0_0
            let v42 : US0 = US0_0
            let v43 : US0 = US0_0
            let v44 : US0 = US0_0
            let v45 : US0 = US0_0
            let v46 : US0 = US0_0
            let v47 : US0 = US0_0
            let v48 : US2 = US2_0
            let v49 : US0 = US0_0
            let v50 : US0 = US0_0
            let v51 : US5 = US5_0
            let v52 : US0 = US0_0
            let v53 : US0 = US0_0
            let v54 : US4 = US4_0
            let v55 : Heap0 = {l0 = v10; l1 = v11; l2 = v12; l3 = v13; l4 = v14; l5 = v15; l6 = v17; l7 = v18; l8 = v19; l9 = v20; l10 = v21; l11 = v23; l12 = v24; l13 = v25; l14 = v26; l15 = v27; l16 = v28; l17 = v29; l18 = v30; l19 = v31; l20 = v32; l21 = v33; l22 = v34; l23 = v35; l24 = v36; l25 = v37; l26 = v38; l27 = v39; l28 = v40; l29 = v41; l30 = v42; l31 = v43; l32 = v44; l33 = v45; l34 = v46; l35 = v47; l36 = v48; l37 = v49; l38 = v50; l39 = v51; l40 = v52; l41 = v53; l42 = v54} : Heap0
            let v56 : (Heap0 -> JSX.Element) = closure25()
            let v57 : JS.Function = v56 |> unbox<JS.Function>
            let v58 : string = "createComponent"
            let v59 : string = "solid-js"
            let v60 : JS.Function = import v58 v59
            let v61 : JSX.Element = v60.Invoke (v57, v55) |> unbox<JSX.Element>
            v61
    let v63 : (JSX.Element []) = [|v62|]
    let v64 : JSX.Element = v63 |> unbox<JSX.Element>
    v64
and closure21 (v0 : Heap0, v1 : int32, v2 : (bool -> unit), v3 : (unit -> bool), v4 : (bool -> unit), v5 : (unit -> bool), v6 : (bool -> unit), v7 : (unit -> bool)) () : JSX.Element =
    let v8 : bool = v3 ()
    let v9 : bool = v8 = false
    let v140 : JSX.Element =
        if v9 then
            let v10 : US0 = US0_0
            let v11 : US1 = US1_0
            let v12 : US0 = US0_0
            let v13 : US0 = US0_0
            let v14 : US0 = US0_0
            let v15 : US2 = US2_0
            let v16 : (unit -> JSX.Element) = closure22(v2)
            let v17 : US3 = US3_1(v16)
            let v18 : US0 = US0_0
            let v19 : US0 = US0_0
            let v20 : US2 = US2_0
            let v21 : US0 = US0_0
            let v22 : US0 = US0_0
            let v23 : US2 = US2_0
            let v24 : US4 = US4_0
            let v25 : US0 = US0_0
            let v26 : US0 = US0_0
            let v27 : US0 = US0_0
            let v28 : US0 = US0_0
            let v29 : US5 = US5_0
            let v30 : US0 = US0_0
            let v31 : US0 = US0_0
            let v32 : US0 = US0_0
            let v33 : US0 = US0_0
            let v34 : US0 = US0_0
            let v35 : US0 = US0_0
            let v36 : US0 = US0_0
            let v37 : US6 = US6_0
            let v38 : US7 = US7_0
            let v39 : US0 = US0_0
            let v40 : US0 = US0_0
            let v41 : US0 = US0_0
            let v42 : US0 = US0_0
            let v43 : US0 = US0_0
            let v44 : US0 = US0_0
            let v45 : US0 = US0_0
            let v46 : US0 = US0_0
            let v47 : US2 = US2_0
            let v48 : US0 = US0_0
            let v49 : US0 = US0_0
            let v50 : US5 = US5_0
            let v51 : US0 = US0_0
            let v52 : US0 = US0_0
            let v53 : US4 = US4_0
            let v54 : Heap0 = {l0 = v10; l1 = v11; l2 = v12; l3 = v13; l4 = v14; l5 = v15; l6 = v17; l7 = v18; l8 = v19; l9 = v20; l10 = v21; l11 = v22; l12 = v23; l13 = v24; l14 = v25; l15 = v26; l16 = v27; l17 = v28; l18 = v29; l19 = v30; l20 = v31; l21 = v32; l22 = v33; l23 = v34; l24 = v35; l25 = v36; l26 = v37; l27 = v38; l28 = v39; l29 = v40; l30 = v41; l31 = v42; l32 = v43; l33 = v44; l34 = v45; l35 = v46; l36 = v47; l37 = v48; l38 = v49; l39 = v50; l40 = v51; l41 = v52; l42 = v53} : Heap0
            let v55 : (Heap0 -> JSX.Element) = closure25()
            let v56 : JS.Function = v55 |> unbox<JS.Function>
            let v57 : string = "createComponent"
            let v58 : string = "solid-js"
            let v59 : JS.Function = import v57 v58
            let v60 : JSX.Element = v59.Invoke (v56, v54) |> unbox<JSX.Element>
            v60
        else
            let v61 : bool = v7 ()
            let v64 : US4 =
                if v61 then
                    US4_1(1)
                else
                    US4_0
            let v65 : bool = v7 ()
            let v69 : US0 =
                if v65 then
                    let v66 : string = "absolute"
                    US0_1(v66)
                else
                    US0_0
            let v70 : bool = v7 ()
            let v74 : US0 =
                if v70 then
                    let v71 : string = "0"
                    US0_1(v71)
                else
                    US0_0
            let v75 : bool = v7 ()
            let v79 : US0 =
                if v75 then
                    let v76 : string = "0"
                    US0_1(v76)
                else
                    US0_0
            let v80 : bool = v7 ()
            let v84 : US0 =
                if v80 then
                    let v81 : string = "0"
                    US0_1(v81)
                else
                    US0_0
            let v85 : bool = v7 ()
            let v89 : US0 =
                if v85 then
                    let v86 : string = "0"
                    US0_1(v86)
                else
                    US0_0
            let v90 : bool = v7 ()
            let v94 : US0 =
                if v90 then
                    let v91 : string = "$bg"
                    US0_1(v91)
                else
                    US0_0
            let v95 : US0 = US0_0
            let v96 : US1 = US1_0
            let v97 : US0 = US0_0
            let v98 : US2 = US2_0
            let v99 : (unit -> JSX.Element) = closure26(v0, v1, v2, v4, v5, v6, v7)
            let v100 : US3 = US3_1(v99)
            let v101 : US0 = US0_0
            let v102 : US0 = US0_0
            let v103 : US2 = US2_0
            let v104 : US0 = US0_0
            let v105 : string = "flex"
            let v106 : US0 = US0_1(v105)
            let v107 : US2 = US2_0
            let v108 : US4 = US4_1(1)
            let v109 : US0 = US0_0
            let v110 : US0 = US0_0
            let v111 : US0 = US0_0
            let v112 : US0 = US0_0
            let v113 : US5 = US5_0
            let v114 : US0 = US0_0
            let v115 : US0 = US0_0
            let v116 : US0 = US0_0
            let v117 : US0 = US0_0
            let v118 : US0 = US0_0
            let v119 : US0 = US0_0
            let v120 : US6 = US6_0
            let v121 : US7 = US7_0
            let v122 : US0 = US0_0
            let v123 : US0 = US0_0
            let v124 : US0 = US0_0
            let v125 : US0 = US0_0
            let v126 : US0 = US0_0
            let v127 : US0 = US0_0
            let v128 : US2 = US2_0
            let v129 : US0 = US0_0
            let v130 : US0 = US0_0
            let v131 : US5 = US5_0
            let v132 : US0 = US0_0
            let v133 : Heap0 = {l0 = v95; l1 = v96; l2 = v94; l3 = v97; l4 = v84; l5 = v98; l6 = v100; l7 = v101; l8 = v102; l9 = v103; l10 = v104; l11 = v106; l12 = v107; l13 = v108; l14 = v109; l15 = v110; l16 = v111; l17 = v112; l18 = v113; l19 = v114; l20 = v115; l21 = v89; l22 = v116; l23 = v117; l24 = v118; l25 = v119; l26 = v120; l27 = v121; l28 = v122; l29 = v123; l30 = v124; l31 = v125; l32 = v69; l33 = v79; l34 = v126; l35 = v127; l36 = v128; l37 = v129; l38 = v130; l39 = v131; l40 = v74; l41 = v132; l42 = v64} : Heap0
            let v134 : (Heap0 -> JSX.Element) = closure25()
            let v135 : JS.Function = v134 |> unbox<JS.Function>
            let v136 : string = "createComponent"
            let v137 : string = "solid-js"
            let v138 : JS.Function = import v136 v137
            let v139 : JSX.Element = v138.Invoke (v135, v133) |> unbox<JSX.Element>
            v139
    let v141 : (JSX.Element []) = [|v140|]
    let v142 : JSX.Element = v141 |> unbox<JSX.Element>
    v142
and closure17 (v0 : Heap0, v1 : (unit -> bool), v2 : (unit -> JSX.Element)) () : JSX.Element =
    let v3 : US2 = v0.l36
    let v127 : JSX.Element =
        match v3 with
        | US2_0 -> (* None *)
            let v4 : JSX.Element = v2 ()
            v4
        | US2_1(v5) -> (* Some *)
            let v6 : bool = v1 ()
            if v6 then
                let v7 : US0 = US0_0
                let v8 : US1 = US1_0
                let v9 : US0 = US0_0
                let v10 : US0 = US0_0
                let v11 : US0 = US0_0
                let v12 : US2 = US2_0
                let v13 : (unit -> JSX.Element) = closure18(v2)
                let v14 : US3 = US3_1(v13)
                let v15 : US0 = US0_0
                let v16 : US0 = US0_0
                let v17 : US2 = US2_0
                let v18 : US0 = US0_0
                let v19 : US0 = US0_0
                let v20 : US2 = US2_0
                let v21 : US4 = US4_0
                let v22 : US0 = US0_0
                let v23 : US0 = US0_0
                let v24 : US0 = US0_0
                let v25 : US0 = US0_0
                let v26 : US5 = US5_0
                let v27 : US0 = US0_0
                let v28 : US0 = US0_0
                let v29 : US0 = US0_0
                let v30 : US0 = US0_0
                let v31 : US0 = US0_0
                let v32 : US0 = US0_0
                let v33 : US0 = US0_0
                let v34 : US6 = US6_0
                let v35 : US7 = US7_0
                let v36 : US0 = US0_0
                let v37 : US0 = US0_0
                let v38 : US0 = US0_0
                let v39 : US0 = US0_0
                let v40 : US0 = US0_0
                let v41 : US0 = US0_0
                let v42 : US0 = US0_0
                let v43 : US0 = US0_0
                let v44 : US2 = US2_0
                let v45 : US0 = US0_0
                let v46 : US0 = US0_0
                let v47 : US5 = US5_0
                let v48 : US0 = US0_0
                let v49 : US0 = US0_0
                let v50 : US4 = US4_0
                let v51 : Heap0 = {l0 = v7; l1 = v8; l2 = v9; l3 = v10; l4 = v11; l5 = v12; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v18; l11 = v19; l12 = v20; l13 = v21; l14 = v22; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v34; l27 = v35; l28 = v36; l29 = v37; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50} : Heap0
                let v52 : int32 = Random().Next()
                let v53 : string = "createSignal"
                let v54 : string = "solid-js"
                let v55 : JS.Function = import v53 v54
                let v56 : (JS.Function []) = v55.Invoke true |> unbox<JS.Function[]>
                let v57 : (unit -> bool) = v56.[0] |> unbox
                let v58 : (bool -> unit) = v56.[1] |> unbox
                let v59 : JS.Function = import v53 v54
                let v60 : (JS.Function []) = v59.Invoke false |> unbox<JS.Function[]>
                let v61 : (unit -> bool) = v60.[0] |> unbox
                let v62 : (bool -> unit) = v60.[1] |> unbox
                let v63 : JS.Function = import v53 v54
                let v64 : (JS.Function []) = v63.Invoke false |> unbox<JS.Function[]>
                let v65 : (unit -> bool) = v64.[0] |> unbox
                let v66 : (bool -> unit) = v64.[1] |> unbox
                let v67 : string = "on"
                let v68 : JS.Function = import v67 v54
                let v69 : (unit -> (bool [])) = closure19(v61)
                let v70 : (unit -> unit) = closure20(v62, v61)
                let v71 : JS.Function = v68.Invoke (v69, v70) |> unbox<JS.Function>
                let v72 : string = "createEffect"
                let v73 : JS.Function = import v72 v54
                v73.Invoke v71 |> ignore
                let v74 : US0 = v51.l19
                let v75 : US0 = US0_0
                let v76 : US1 = US1_0
                let v77 : US0 = US0_0
                let v78 : US0 = US0_0
                let v79 : US0 = US0_0
                let v80 : US2 = US2_0
                let v81 : (unit -> JSX.Element) = closure21(v51, v52, v58, v57, v62, v61, v66, v65)
                let v82 : US3 = US3_1(v81)
                let v83 : US0 = US0_0
                let v84 : US0 = US0_0
                let v85 : US2 = US2_0
                let v86 : US0 = US0_0
                let v87 : string = "flex"
                let v88 : US0 = US0_1(v87)
                let v89 : US2 = US2_0
                let v90 : US4 = US4_1(1)
                let v91 : US0 = US0_0
                let v92 : US0 = US0_0
                let v93 : US0 = US0_0
                let v94 : US0 = US0_0
                let v95 : US5 = US5_0
                let v96 : US0 = US0_0
                let v97 : US0 = US0_0
                let v98 : US0 = US0_0
                let v99 : US0 = US0_0
                let v100 : US0 = US0_0
                let v101 : US0 = US0_0
                let v102 : US6 = US6_0
                let v103 : US7 = US7_0
                let v104 : US0 = US0_0
                let v105 : US0 = US0_0
                let v106 : US0 = US0_0
                let v107 : US0 = US0_0
                let v108 : US0 = US0_0
                let v109 : US0 = US0_0
                let v110 : US0 = US0_0
                let v111 : US0 = US0_0
                let v112 : US2 = US2_0
                let v113 : US0 = US0_0
                let v114 : US0 = US0_0
                let v115 : US5 = US5_0
                let v116 : US0 = US0_0
                let v117 : US0 = US0_0
                let v118 : US4 = US4_0
                let v119 : Heap0 = {l0 = v75; l1 = v76; l2 = v77; l3 = v78; l4 = v79; l5 = v80; l6 = v82; l7 = v83; l8 = v84; l9 = v85; l10 = v86; l11 = v88; l12 = v89; l13 = v90; l14 = v91; l15 = v92; l16 = v93; l17 = v94; l18 = v95; l19 = v74; l20 = v96; l21 = v97; l22 = v98; l23 = v99; l24 = v100; l25 = v101; l26 = v102; l27 = v103; l28 = v104; l29 = v105; l30 = v106; l31 = v107; l32 = v108; l33 = v109; l34 = v110; l35 = v111; l36 = v112; l37 = v113; l38 = v114; l39 = v115; l40 = v116; l41 = v117; l42 = v118} : Heap0
                let v120 : (Heap0 -> JSX.Element) = closure25()
                let v121 : JS.Function = v120 |> unbox<JS.Function>
                let v122 : string = "createComponent"
                let v123 : JS.Function = import v122 v54
                let v124 : JSX.Element = v123.Invoke (v121, v119) |> unbox<JSX.Element>
                v124
            else
                let v125 : JSX.Element = Html.fragment []
                v125
    let v128 : (JSX.Element []) = [|v127|]
    let v129 : JSX.Element = v128 |> unbox<JSX.Element>
    v129
and closure10 (v0 : Heap0, v1 : (bool -> unit), v2 : (unit -> bool)) () : JSX.Element =
    let v3 : US5 = v0.l39
    let v64 : JSX.Element =
        match v3 with
        | US5_0 -> (* None *)
            let v4 : JSX.Element = Html.fragment []
            v4
        | US5_1(v5) -> (* Some *)
            let v6 : US0 = US0_0
            let v7 : US1 = US1_0
            let v8 : US0 = US0_0
            let v9 : string = "0 !important"
            let v10 : US0 = US0_1(v9)
            let v11 : US0 = US0_0
            let v12 : US2 = US2_0
            let v13 : (unit -> JSX.Element) = closure11(v0, v1, v2, v5)
            let v14 : US3 = US3_1(v13)
            let v15 : string = "$neutral9"
            let v16 : US0 = US0_1(v15)
            let v17 : US0 = US0_0
            let v18 : US2 = US2_0
            let v19 : US0 = US0_0
            let v20 : string = "flex"
            let v21 : US0 = US0_1(v20)
            let v22 : US2 = US2_0
            let v23 : US4 = US4_0
            let v24 : string = "column"
            let v25 : US0 = US0_1(v24)
            let v26 : string = "$sm"
            let v27 : US0 = US0_1(v26)
            let v28 : US0 = US0_0
            let v29 : US0 = US0_0
            let v30 : US5 = US5_0
            let v31 : US0 = US0_0
            let v32 : US0 = US0_0
            let v33 : US0 = US0_0
            let v34 : US0 = US0_0
            let v35 : US0 = US0_0
            let v36 : US0 = US0_0
            let v37 : US0 = US0_0
            let v38 : US6 = US6_0
            let v39 : US7 = US7_0
            let v40 : string = "1px solid $neutral5"
            let v41 : US0 = US0_1(v40)
            let v42 : US0 = US0_0
            let v43 : string = "3px 20px 0 8px"
            let v44 : US0 = US0_1(v43)
            let v45 : US0 = US0_0
            let v46 : US0 = US0_0
            let v47 : US0 = US0_0
            let v48 : US0 = US0_0
            let v49 : US0 = US0_0
            let v50 : US2 = US2_0
            let v51 : US0 = US0_0
            let v52 : US0 = US0_0
            let v53 : US5 = US5_0
            let v54 : US0 = US0_0
            let v55 : US0 = US0_0
            let v56 : US4 = US4_0
            let v57 : Heap0 = {l0 = v6; l1 = v7; l2 = v8; l3 = v10; l4 = v11; l5 = v12; l6 = v14; l7 = v16; l8 = v17; l9 = v18; l10 = v19; l11 = v21; l12 = v22; l13 = v23; l14 = v25; l15 = v27; l16 = v28; l17 = v29; l18 = v30; l19 = v31; l20 = v32; l21 = v33; l22 = v34; l23 = v35; l24 = v36; l25 = v37; l26 = v38; l27 = v39; l28 = v41; l29 = v42; l30 = v44; l31 = v45; l32 = v46; l33 = v47; l34 = v48; l35 = v49; l36 = v50; l37 = v51; l38 = v52; l39 = v53; l40 = v54; l41 = v55; l42 = v56} : Heap0
            let v58 : (Heap0 -> JSX.Element) = closure15()
            let v59 : JS.Function = v58 |> unbox<JS.Function>
            let v60 : string = "createComponent"
            let v61 : string = "solid-js"
            let v62 : JS.Function = import v60 v61
            let v63 : JSX.Element = v62.Invoke (v59, v57) |> unbox<JSX.Element>
            v63
    let v65 : US3 = v0.l6
    let v182 : JSX.Element =
        match v65 with
        | US3_0 -> (* None *)
            let v66 : US0 = US0_0
            let v67 : US1 = US1_0
            let v68 : US0 = US0_0
            let v69 : US0 = US0_0
            let v70 : US0 = US0_0
            let v71 : US2 = US2_0
            let v72 : (unit -> JSX.Element) = closure16()
            let v73 : US3 = US3_1(v72)
            let v74 : US0 = US0_0
            let v75 : US0 = US0_0
            let v76 : US2 = US2_0
            let v77 : US0 = US0_0
            let v78 : US0 = US0_0
            let v79 : US2 = US2_0
            let v80 : US4 = US4_0
            let v81 : US0 = US0_0
            let v82 : US0 = US0_0
            let v83 : US0 = US0_0
            let v84 : US0 = US0_0
            let v85 : US5 = US5_0
            let v86 : US0 = US0_0
            let v87 : US0 = US0_0
            let v88 : US0 = US0_0
            let v89 : string = "9px"
            let v90 : US0 = US0_1(v89)
            let v91 : US0 = US0_0
            let v92 : US0 = US0_0
            let v93 : US0 = US0_0
            let v94 : US6 = US6_0
            let v95 : US7 = US7_0
            let v96 : US0 = US0_0
            let v97 : US0 = US0_0
            let v98 : string = "0"
            let v99 : US0 = US0_1(v98)
            let v100 : US0 = US0_0
            let v101 : US0 = US0_0
            let v102 : US0 = US0_0
            let v103 : US0 = US0_0
            let v104 : US0 = US0_0
            let v105 : US2 = US2_0
            let v106 : US0 = US0_0
            let v107 : US0 = US0_0
            let v108 : US5 = US5_0
            let v109 : US0 = US0_0
            let v110 : US0 = US0_0
            let v111 : US4 = US4_0
            let v112 : Heap0 = {l0 = v66; l1 = v67; l2 = v68; l3 = v69; l4 = v70; l5 = v71; l6 = v73; l7 = v74; l8 = v75; l9 = v76; l10 = v77; l11 = v78; l12 = v79; l13 = v80; l14 = v81; l15 = v82; l16 = v83; l17 = v84; l18 = v85; l19 = v86; l20 = v87; l21 = v88; l22 = v90; l23 = v91; l24 = v92; l25 = v93; l26 = v94; l27 = v95; l28 = v96; l29 = v97; l30 = v99; l31 = v100; l32 = v101; l33 = v102; l34 = v103; l35 = v104; l36 = v105; l37 = v106; l38 = v107; l39 = v108; l40 = v109; l41 = v110; l42 = v111} : Heap0
            let v113 : (Heap0 -> JSX.Element) = closure15()
            let v114 : JS.Function = v113 |> unbox<JS.Function>
            let v115 : string = "createComponent"
            let v116 : string = "solid-js"
            let v117 : JS.Function = import v115 v116
            let v118 : JSX.Element = v117.Invoke (v114, v112) |> unbox<JSX.Element>
            v118
        | US3_1(v119) -> (* Some *)
            let v120 : US0 = v0.l30
            let v123 : string =
                match v120 with
                | US0_0 -> (* None *)
                    let v121 : string = "0"
                    v121
                | US0_1(v122) -> (* Some *)
                    v122
            let v124 : US0 = US0_0
            let v125 : US1 = US1_0
            let v126 : US0 = US0_0
            let v127 : string = "0 !important"
            let v128 : US0 = US0_1(v127)
            let v129 : US0 = US0_0
            let v130 : US2 = US2_0
            let v131 : (unit -> JSX.Element) = closure17(v0, v2, v119)
            let v132 : US3 = US3_1(v131)
            let v133 : US0 = US0_0
            let v134 : US0 = US0_0
            let v135 : US2 = US2_0
            let v136 : US0 = US0_0
            let v137 : string = "flex"
            let v138 : US0 = US0_1(v137)
            let v139 : US2 = US2_0
            let v140 : US4 = US4_1(6)
            let v141 : string = "column"
            let v142 : US0 = US0_1(v141)
            let v143 : string = "$sm"
            let v144 : US0 = US0_1(v143)
            let v145 : US0 = US0_0
            let v146 : US0 = US0_0
            let v147 : US5 = US5_0
            let v148 : US0 = US0_0
            let v149 : US0 = US0_0
            let v150 : US0 = US0_0
            let v151 : US0 = US0_0
            let v152 : string = "0"
            let v153 : US0 = US0_1(v152)
            let v154 : US0 = US0_0
            let v155 : string = "85vh"
            let v156 : US0 = US0_1(v155)
            let v157 : US6 = US6_0
            let v158 : US7 = US7_0
            let v159 : US0 = US0_1(v152)
            let v160 : string = "auto"
            let v161 : US0 = US0_1(v160)
            let v162 : US0 = US0_1(v123)
            let v163 : US0 = US0_0
            let v164 : US0 = US0_0
            let v165 : US0 = US0_0
            let v166 : US0 = US0_0
            let v167 : US0 = US0_0
            let v168 : US2 = US2_0
            let v169 : US0 = US0_0
            let v170 : US0 = US0_0
            let v171 : US5 = US5_0
            let v172 : US0 = US0_0
            let v173 : US0 = US0_0
            let v174 : US4 = US4_0
            let v175 : Heap0 = {l0 = v124; l1 = v125; l2 = v126; l3 = v128; l4 = v129; l5 = v130; l6 = v132; l7 = v133; l8 = v134; l9 = v135; l10 = v136; l11 = v138; l12 = v139; l13 = v140; l14 = v142; l15 = v144; l16 = v145; l17 = v146; l18 = v147; l19 = v148; l20 = v149; l21 = v150; l22 = v151; l23 = v153; l24 = v154; l25 = v156; l26 = v157; l27 = v158; l28 = v159; l29 = v161; l30 = v162; l31 = v163; l32 = v164; l33 = v165; l34 = v166; l35 = v167; l36 = v168; l37 = v169; l38 = v170; l39 = v171; l40 = v172; l41 = v173; l42 = v174} : Heap0
            let v176 : (Heap0 -> JSX.Element) = closure15()
            let v177 : JS.Function = v176 |> unbox<JS.Function>
            let v178 : string = "createComponent"
            let v179 : string = "solid-js"
            let v180 : JS.Function = import v178 v179
            let v181 : JSX.Element = v180.Invoke (v177, v175) |> unbox<JSX.Element>
            v181
    let v183 : (JSX.Element []) = [|v64; v182|]
    let v184 : JSX.Element = v183 |> unbox<JSX.Element>
    v184
and closure33 () (v0 : Heap0) : JSX.Element =
    let v1 : US0 = v0.l0
    let v7 : US8 =
        match v1 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v3) -> (* Some *)
            let v4 : string = "aria-label"
            let v5 : JSX.Prop = JSX.Prop (v4, v3)
            US8_1(v5)
    let v8 : US1 = v0.l1
    let v14 : US8 =
        match v8 with
        | US1_0 -> (* None *)
            US8_0
        | US1_1(v10) -> (* Some *)
            let v11 : string = "as"
            let v12 : JSX.Prop = JSX.Prop (v11, v10)
            US8_1(v12)
    let v15 : US0 = v0.l2
    let v21 : US8 =
        match v15 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v17) -> (* Some *)
            let v18 : string = "backgroundColor"
            let v19 : JSX.Prop = JSX.Prop (v18, v17)
            US8_1(v19)
    let v22 : US0 = v0.l3
    let v28 : US8 =
        match v22 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v24) -> (* Some *)
            let v25 : string = "border"
            let v26 : JSX.Prop = JSX.Prop (v25, v24)
            US8_1(v26)
    let v29 : US0 = v0.l4
    let v35 : US8 =
        match v29 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v31) -> (* Some *)
            let v32 : string = "bottom"
            let v33 : JSX.Prop = JSX.Prop (v32, v31)
            US8_1(v33)
    let v36 : US0 = v0.l7
    let v42 : US8 =
        match v36 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v38) -> (* Some *)
            let v39 : string = "color"
            let v40 : JSX.Prop = JSX.Prop (v39, v38)
            US8_1(v40)
    let v43 : US2 = v0.l5
    let v49 : US8 =
        match v43 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v45) -> (* Some *)
            let v46 : string = "checked"
            let v47 : JSX.Prop = JSX.Prop (v46, v45)
            US8_1(v47)
    let v50 : US3 = v0.l6
    let v56 : US8 =
        match v50 with
        | US3_0 -> (* None *)
            US8_0
        | US3_1(v52) -> (* Some *)
            let v53 : string = "children"
            let v54 : JSX.Prop = JSX.Prop (v53, v52)
            US8_1(v54)
    let v57 : US0 = v0.l8
    let v63 : US8 =
        match v57 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v59) -> (* Some *)
            let v60 : string = "colorScheme"
            let v61 : JSX.Prop = JSX.Prop (v60, v59)
            US8_1(v61)
    let v64 : US2 = v0.l9
    let v70 : US8 =
        match v64 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v66) -> (* Some *)
            let v67 : string = "compact"
            let v68 : JSX.Prop = JSX.Prop (v67, v66)
            US8_1(v68)
    let v71 : US0 = v0.l11
    let v77 : US8 =
        match v71 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v73) -> (* Some *)
            let v74 : string = "display"
            let v75 : JSX.Prop = JSX.Prop (v74, v73)
            US8_1(v75)
    let v78 : US0 = v0.l10
    let v84 : US8 =
        match v78 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v80) -> (* Some *)
            let v81 : string = "direction"
            let v82 : JSX.Prop = JSX.Prop (v81, v80)
            US8_1(v82)
    let v85 : US2 = v0.l12
    let v91 : US8 =
        match v85 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v87) -> (* Some *)
            let v88 : string = "external"
            let v89 : JSX.Prop = JSX.Prop (v88, v87)
            US8_1(v89)
    let v92 : US4 = v0.l13
    let v98 : US8 =
        match v92 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v94) -> (* Some *)
            let v95 : string = "flex"
            let v96 : JSX.Prop = JSX.Prop (v95, v94)
            US8_1(v96)
    let v99 : US0 = v0.l14
    let v105 : US8 =
        match v99 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v101) -> (* Some *)
            let v102 : string = "flexDirection"
            let v103 : JSX.Prop = JSX.Prop (v102, v101)
            US8_1(v103)
    let v106 : US0 = v0.l15
    let v112 : US8 =
        match v106 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v108) -> (* Some *)
            let v109 : string = "fontSize"
            let v110 : JSX.Prop = JSX.Prop (v109, v108)
            US8_1(v110)
    let v113 : US0 = v0.l16
    let v119 : US8 =
        match v113 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v115) -> (* Some *)
            let v116 : string = "height"
            let v117 : JSX.Prop = JSX.Prop (v116, v115)
            US8_1(v117)
    let v120 : US0 = v0.l17
    let v126 : US8 =
        match v120 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v122) -> (* Some *)
            let v123 : string = "href"
            let v124 : JSX.Prop = JSX.Prop (v123, v122)
            US8_1(v124)
    let v127 : US5 = v0.l18
    let v133 : US8 =
        match v127 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v129) -> (* Some *)
            let v130 : string = "icon"
            let v131 : JSX.Prop = JSX.Prop (v130, v129)
            US8_1(v131)
    let v134 : US0 = v0.l19
    let v140 : US8 =
        match v134 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v136) -> (* Some *)
            let v137 : string = "id"
            let v138 : JSX.Prop = JSX.Prop (v137, v136)
            US8_1(v138)
    let v141 : US0 = v0.l20
    let v147 : US8 =
        match v141 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v143) -> (* Some *)
            let v144 : string = "justifyContent"
            let v145 : JSX.Prop = JSX.Prop (v144, v143)
            US8_1(v145)
    let v148 : US0 = v0.l21
    let v154 : US8 =
        match v148 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v150) -> (* Some *)
            let v151 : string = "left"
            let v152 : JSX.Prop = JSX.Prop (v151, v150)
            US8_1(v152)
    let v155 : US0 = v0.l22
    let v161 : US8 =
        match v155 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v157) -> (* Some *)
            let v158 : string = "lineHeight"
            let v159 : JSX.Prop = JSX.Prop (v158, v157)
            US8_1(v159)
    let v162 : US0 = v0.l23
    let v168 : US8 =
        match v162 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v164) -> (* Some *)
            let v165 : string = "margin"
            let v166 : JSX.Prop = JSX.Prop (v165, v164)
            US8_1(v166)
    let v169 : US0 = v0.l24
    let v175 : US8 =
        match v169 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v171) -> (* Some *)
            let v172 : string = "marginBottom"
            let v173 : JSX.Prop = JSX.Prop (v172, v171)
            US8_1(v173)
    let v176 : US0 = v0.l25
    let v182 : US8 =
        match v176 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v178) -> (* Some *)
            let v179 : string = "maxHeight"
            let v180 : JSX.Prop = JSX.Prop (v179, v178)
            US8_1(v180)
    let v183 : US6 = v0.l26
    let v189 : US8 =
        match v183 with
        | US6_0 -> (* None *)
            US8_0
        | US6_1(v185) -> (* Some *)
            let v186 : string = "onChange"
            let v187 : JSX.Prop = JSX.Prop (v186, v185)
            US8_1(v187)
    let v190 : US7 = v0.l27
    let v196 : US8 =
        match v190 with
        | US7_0 -> (* None *)
            US8_0
        | US7_1(v192) -> (* Some *)
            let v193 : string = "onClick"
            let v194 : JSX.Prop = JSX.Prop (v193, v192)
            US8_1(v194)
    let v197 : US0 = v0.l28
    let v203 : US8 =
        match v197 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v199) -> (* Some *)
            let v200 : string = "outline"
            let v201 : JSX.Prop = JSX.Prop (v200, v199)
            US8_1(v201)
    let v204 : US0 = v0.l29
    let v210 : US8 =
        match v204 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v206) -> (* Some *)
            let v207 : string = "overflowY"
            let v208 : JSX.Prop = JSX.Prop (v207, v206)
            US8_1(v208)
    let v211 : US0 = v0.l30
    let v217 : US8 =
        match v211 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v213) -> (* Some *)
            let v214 : string = "padding"
            let v215 : JSX.Prop = JSX.Prop (v214, v213)
            US8_1(v215)
    let v218 : US0 = v0.l31
    let v224 : US8 =
        match v218 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v220) -> (* Some *)
            let v221 : string = "paddingTop"
            let v222 : JSX.Prop = JSX.Prop (v221, v220)
            US8_1(v222)
    let v225 : US0 = v0.l32
    let v231 : US8 =
        match v225 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v227) -> (* Some *)
            let v228 : string = "position"
            let v229 : JSX.Prop = JSX.Prop (v228, v227)
            US8_1(v229)
    let v232 : US0 = v0.l33
    let v238 : US8 =
        match v232 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v234) -> (* Some *)
            let v235 : string = "right"
            let v236 : JSX.Prop = JSX.Prop (v235, v234)
            US8_1(v236)
    let v239 : US0 = v0.l34
    let v245 : US8 =
        match v239 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v241) -> (* Some *)
            let v242 : string = "size"
            let v243 : JSX.Prop = JSX.Prop (v242, v241)
            US8_1(v243)
    let v246 : US0 = v0.l35
    let v252 : US8 =
        match v246 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v248) -> (* Some *)
            let v249 : string = "spacing"
            let v250 : JSX.Prop = JSX.Prop (v249, v248)
            US8_1(v250)
    let v253 : US2 = v0.l36
    let v259 : US8 =
        match v253 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v255) -> (* Some *)
            let v256 : string = "status"
            let v257 : JSX.Prop = JSX.Prop (v256, v255)
            US8_1(v257)
    let v260 : US0 = v0.l37
    let v266 : US8 =
        match v260 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v262) -> (* Some *)
            let v263 : string = "striped"
            let v264 : JSX.Prop = JSX.Prop (v263, v262)
            US8_1(v264)
    let v267 : US0 = v0.l38
    let v273 : US8 =
        match v267 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v269) -> (* Some *)
            let v270 : string = "thickness"
            let v271 : JSX.Prop = JSX.Prop (v270, v269)
            US8_1(v271)
    let v274 : US5 = v0.l39
    let v280 : US8 =
        match v274 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v276) -> (* Some *)
            let v277 : string = "title"
            let v278 : JSX.Prop = JSX.Prop (v277, v276)
            US8_1(v278)
    let v281 : US0 = v0.l40
    let v287 : US8 =
        match v281 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v283) -> (* Some *)
            let v284 : string = "top"
            let v285 : JSX.Prop = JSX.Prop (v284, v283)
            US8_1(v285)
    let v288 : US0 = v0.l41
    let v294 : US8 =
        match v288 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v290) -> (* Some *)
            let v291 : string = "width"
            let v292 : JSX.Prop = JSX.Prop (v291, v290)
            US8_1(v292)
    let v295 : US4 = v0.l42
    let v301 : US8 =
        match v295 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v297) -> (* Some *)
            let v298 : string = "zIndex"
            let v299 : JSX.Prop = JSX.Prop (v298, v297)
            US8_1(v299)
    let v302 : (US8 []) = [|v7; v14; v21; v28; v35; v42; v49; v56; v63; v70; v77; v84; v91; v98; v105; v112; v119; v126; v133; v140; v147; v154; v161; v168; v175; v182; v189; v196; v203; v210; v217; v224; v231; v238; v245; v252; v259; v266; v273; v280; v287; v294; v301|]
    let v303 : int32 = v302.Length
    let v304 : (US8 []) = Array.zeroCreate<US8> (v303)
    let v305 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method0(v303, v305) do
        let v307 : int32 = v305.l0
        let v308 : int32 = v305.l1
        let v309 : US8 = v302.[int v307]
        let v311 : bool =
            match v309 with
            | US8_0 -> (* None *)
                false
            | US8_1(v310) -> (* Some *)
                true
        let v313 : int32 =
            if v311 then
                v304.[int v308] <- v309
                let v312 : int32 = v308 + 1
                v312
            else
                v308
        let v314 : int32 = v307 + 1
        v305.l0 <- v314
        v305.l1 <- v313
        ()
    let v315 : int32 = v305.l1
    let v316 : (US8 []) = Array.zeroCreate<US8> (v315)
    let v317 : Mut1 = {l0 = 0} : Mut1
    while method1(v315, v317) do
        let v319 : int32 = v317.l0
        let v320 : US8 = v304.[int v319]
        v316.[int v319] <- v320
        let v321 : int32 = v319 + 1
        v317.l0 <- v321
        ()
    let v322 : int32 = v316.Length
    let v323 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v322)
    let v324 : Mut1 = {l0 = 0} : Mut1
    while method1(v322, v324) do
        let v326 : int32 = v324.l0
        let v327 : US8 = v316.[int v326]
        let v330 : JSX.Prop =
            match v327 with
            | US8_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US8_1(v329) -> (* Some *)
                v329
        v323.[int v326] <- v330
        let v331 : int32 = v326 + 1
        v324.l0 <- v331
        ()
    let v332 : obj = createObj v323
    let v333 : string = "createComponent"
    let v334 : string = "solid-js"
    let v335 : JS.Function = import v333 v334
    let v336 : string = "Tr"
    let v337 : string = "@hope-ui/solid"
    let v338 : JSX.Element = v335.Invoke ((import v336 v337), v332) |> unbox<JSX.Element>
    v338
and closure34 () () : JSX.Element =
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
    let v17 : string = "https://fc1943s.github.io/tictactoe_spiral"
    let v18 : US0 = US0_1(v17)
    let v19 : US5 = US5_0
    let v20 : US0 = US0_0
    let v21 : US0 = US0_0
    let v22 : US0 = US0_0
    let v23 : US0 = US0_0
    let v24 : US0 = US0_0
    let v25 : US0 = US0_0
    let v26 : US0 = US0_0
    let v27 : US6 = US6_0
    let v28 : US7 = US7_0
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
    let v44 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43} : Heap0
    let v45 : US0 = v44.l17
    let v46 : US0 = US0_0
    let v47 : US1 = US1_0
    let v48 : US0 = US0_0
    let v49 : US0 = US0_0
    let v50 : US0 = US0_0
    let v51 : US2 = US2_0
    let v52 : (unit -> JSX.Element) = closure6(v44)
    let v53 : US3 = US3_1(v52)
    let v54 : US0 = US0_0
    let v55 : US0 = US0_0
    let v56 : US2 = US2_0
    let v57 : US0 = US0_0
    let v58 : US0 = US0_0
    let v59 : US2 = US2_1(true)
    let v60 : US4 = US4_0
    let v61 : US0 = US0_0
    let v62 : US0 = US0_0
    let v63 : US0 = US0_0
    let v64 : US5 = US5_0
    let v65 : US0 = US0_0
    let v66 : US0 = US0_0
    let v67 : US0 = US0_0
    let v68 : US0 = US0_0
    let v69 : US0 = US0_0
    let v70 : US0 = US0_0
    let v71 : US0 = US0_0
    let v72 : US6 = US6_0
    let v73 : US7 = US7_0
    let v74 : US0 = US0_0
    let v75 : US0 = US0_0
    let v76 : US0 = US0_0
    let v77 : US0 = US0_0
    let v78 : US0 = US0_0
    let v79 : US0 = US0_0
    let v80 : US0 = US0_0
    let v81 : US0 = US0_0
    let v82 : US2 = US2_0
    let v83 : US0 = US0_0
    let v84 : US0 = US0_0
    let v85 : US5 = US5_0
    let v86 : US0 = US0_0
    let v87 : US0 = US0_0
    let v88 : US4 = US4_0
    let v89 : Heap0 = {l0 = v46; l1 = v47; l2 = v48; l3 = v49; l4 = v50; l5 = v51; l6 = v53; l7 = v54; l8 = v55; l9 = v56; l10 = v57; l11 = v58; l12 = v59; l13 = v60; l14 = v61; l15 = v62; l16 = v63; l17 = v45; l18 = v64; l19 = v65; l20 = v66; l21 = v67; l22 = v68; l23 = v69; l24 = v70; l25 = v71; l26 = v72; l27 = v73; l28 = v74; l29 = v75; l30 = v76; l31 = v77; l32 = v78; l33 = v79; l34 = v80; l35 = v81; l36 = v82; l37 = v83; l38 = v84; l39 = v85; l40 = v86; l41 = v87; l42 = v88} : Heap0
    let v90 : US0 = v89.l0
    let v96 : US8 =
        match v90 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v92) -> (* Some *)
            let v93 : string = "aria-label"
            let v94 : JSX.Prop = JSX.Prop (v93, v92)
            US8_1(v94)
    let v97 : US1 = v89.l1
    let v103 : US8 =
        match v97 with
        | US1_0 -> (* None *)
            US8_0
        | US1_1(v99) -> (* Some *)
            let v100 : string = "as"
            let v101 : JSX.Prop = JSX.Prop (v100, v99)
            US8_1(v101)
    let v104 : US0 = v89.l2
    let v110 : US8 =
        match v104 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v106) -> (* Some *)
            let v107 : string = "backgroundColor"
            let v108 : JSX.Prop = JSX.Prop (v107, v106)
            US8_1(v108)
    let v111 : US0 = v89.l3
    let v117 : US8 =
        match v111 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v113) -> (* Some *)
            let v114 : string = "border"
            let v115 : JSX.Prop = JSX.Prop (v114, v113)
            US8_1(v115)
    let v118 : US0 = v89.l4
    let v124 : US8 =
        match v118 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v120) -> (* Some *)
            let v121 : string = "bottom"
            let v122 : JSX.Prop = JSX.Prop (v121, v120)
            US8_1(v122)
    let v125 : US0 = v89.l7
    let v131 : US8 =
        match v125 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v127) -> (* Some *)
            let v128 : string = "color"
            let v129 : JSX.Prop = JSX.Prop (v128, v127)
            US8_1(v129)
    let v132 : US2 = v89.l5
    let v138 : US8 =
        match v132 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v134) -> (* Some *)
            let v135 : string = "checked"
            let v136 : JSX.Prop = JSX.Prop (v135, v134)
            US8_1(v136)
    let v139 : US3 = v89.l6
    let v145 : US8 =
        match v139 with
        | US3_0 -> (* None *)
            US8_0
        | US3_1(v141) -> (* Some *)
            let v142 : string = "children"
            let v143 : JSX.Prop = JSX.Prop (v142, v141)
            US8_1(v143)
    let v146 : US0 = v89.l8
    let v152 : US8 =
        match v146 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v148) -> (* Some *)
            let v149 : string = "colorScheme"
            let v150 : JSX.Prop = JSX.Prop (v149, v148)
            US8_1(v150)
    let v153 : US2 = v89.l9
    let v159 : US8 =
        match v153 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v155) -> (* Some *)
            let v156 : string = "compact"
            let v157 : JSX.Prop = JSX.Prop (v156, v155)
            US8_1(v157)
    let v160 : US0 = v89.l11
    let v166 : US8 =
        match v160 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v162) -> (* Some *)
            let v163 : string = "display"
            let v164 : JSX.Prop = JSX.Prop (v163, v162)
            US8_1(v164)
    let v167 : US0 = v89.l10
    let v173 : US8 =
        match v167 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v169) -> (* Some *)
            let v170 : string = "direction"
            let v171 : JSX.Prop = JSX.Prop (v170, v169)
            US8_1(v171)
    let v174 : US2 = v89.l12
    let v180 : US8 =
        match v174 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v176) -> (* Some *)
            let v177 : string = "external"
            let v178 : JSX.Prop = JSX.Prop (v177, v176)
            US8_1(v178)
    let v181 : US4 = v89.l13
    let v187 : US8 =
        match v181 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v183) -> (* Some *)
            let v184 : string = "flex"
            let v185 : JSX.Prop = JSX.Prop (v184, v183)
            US8_1(v185)
    let v188 : US0 = v89.l14
    let v194 : US8 =
        match v188 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v190) -> (* Some *)
            let v191 : string = "flexDirection"
            let v192 : JSX.Prop = JSX.Prop (v191, v190)
            US8_1(v192)
    let v195 : US0 = v89.l15
    let v201 : US8 =
        match v195 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v197) -> (* Some *)
            let v198 : string = "fontSize"
            let v199 : JSX.Prop = JSX.Prop (v198, v197)
            US8_1(v199)
    let v202 : US0 = v89.l16
    let v208 : US8 =
        match v202 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v204) -> (* Some *)
            let v205 : string = "height"
            let v206 : JSX.Prop = JSX.Prop (v205, v204)
            US8_1(v206)
    let v209 : US0 = v89.l17
    let v215 : US8 =
        match v209 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v211) -> (* Some *)
            let v212 : string = "href"
            let v213 : JSX.Prop = JSX.Prop (v212, v211)
            US8_1(v213)
    let v216 : US5 = v89.l18
    let v222 : US8 =
        match v216 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v218) -> (* Some *)
            let v219 : string = "icon"
            let v220 : JSX.Prop = JSX.Prop (v219, v218)
            US8_1(v220)
    let v223 : US0 = v89.l19
    let v229 : US8 =
        match v223 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v225) -> (* Some *)
            let v226 : string = "id"
            let v227 : JSX.Prop = JSX.Prop (v226, v225)
            US8_1(v227)
    let v230 : US0 = v89.l20
    let v236 : US8 =
        match v230 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v232) -> (* Some *)
            let v233 : string = "justifyContent"
            let v234 : JSX.Prop = JSX.Prop (v233, v232)
            US8_1(v234)
    let v237 : US0 = v89.l21
    let v243 : US8 =
        match v237 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v239) -> (* Some *)
            let v240 : string = "left"
            let v241 : JSX.Prop = JSX.Prop (v240, v239)
            US8_1(v241)
    let v244 : US0 = v89.l22
    let v250 : US8 =
        match v244 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v246) -> (* Some *)
            let v247 : string = "lineHeight"
            let v248 : JSX.Prop = JSX.Prop (v247, v246)
            US8_1(v248)
    let v251 : US0 = v89.l23
    let v257 : US8 =
        match v251 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v253) -> (* Some *)
            let v254 : string = "margin"
            let v255 : JSX.Prop = JSX.Prop (v254, v253)
            US8_1(v255)
    let v258 : US0 = v89.l24
    let v264 : US8 =
        match v258 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v260) -> (* Some *)
            let v261 : string = "marginBottom"
            let v262 : JSX.Prop = JSX.Prop (v261, v260)
            US8_1(v262)
    let v265 : US0 = v89.l25
    let v271 : US8 =
        match v265 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v267) -> (* Some *)
            let v268 : string = "maxHeight"
            let v269 : JSX.Prop = JSX.Prop (v268, v267)
            US8_1(v269)
    let v272 : US6 = v89.l26
    let v278 : US8 =
        match v272 with
        | US6_0 -> (* None *)
            US8_0
        | US6_1(v274) -> (* Some *)
            let v275 : string = "onChange"
            let v276 : JSX.Prop = JSX.Prop (v275, v274)
            US8_1(v276)
    let v279 : US7 = v89.l27
    let v285 : US8 =
        match v279 with
        | US7_0 -> (* None *)
            US8_0
        | US7_1(v281) -> (* Some *)
            let v282 : string = "onClick"
            let v283 : JSX.Prop = JSX.Prop (v282, v281)
            US8_1(v283)
    let v286 : US0 = v89.l28
    let v292 : US8 =
        match v286 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v288) -> (* Some *)
            let v289 : string = "outline"
            let v290 : JSX.Prop = JSX.Prop (v289, v288)
            US8_1(v290)
    let v293 : US0 = v89.l29
    let v299 : US8 =
        match v293 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v295) -> (* Some *)
            let v296 : string = "overflowY"
            let v297 : JSX.Prop = JSX.Prop (v296, v295)
            US8_1(v297)
    let v300 : US0 = v89.l30
    let v306 : US8 =
        match v300 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v302) -> (* Some *)
            let v303 : string = "padding"
            let v304 : JSX.Prop = JSX.Prop (v303, v302)
            US8_1(v304)
    let v307 : US0 = v89.l31
    let v313 : US8 =
        match v307 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v309) -> (* Some *)
            let v310 : string = "paddingTop"
            let v311 : JSX.Prop = JSX.Prop (v310, v309)
            US8_1(v311)
    let v314 : US0 = v89.l32
    let v320 : US8 =
        match v314 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v316) -> (* Some *)
            let v317 : string = "position"
            let v318 : JSX.Prop = JSX.Prop (v317, v316)
            US8_1(v318)
    let v321 : US0 = v89.l33
    let v327 : US8 =
        match v321 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v323) -> (* Some *)
            let v324 : string = "right"
            let v325 : JSX.Prop = JSX.Prop (v324, v323)
            US8_1(v325)
    let v328 : US0 = v89.l34
    let v334 : US8 =
        match v328 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v330) -> (* Some *)
            let v331 : string = "size"
            let v332 : JSX.Prop = JSX.Prop (v331, v330)
            US8_1(v332)
    let v335 : US0 = v89.l35
    let v341 : US8 =
        match v335 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v337) -> (* Some *)
            let v338 : string = "spacing"
            let v339 : JSX.Prop = JSX.Prop (v338, v337)
            US8_1(v339)
    let v342 : US2 = v89.l36
    let v348 : US8 =
        match v342 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v344) -> (* Some *)
            let v345 : string = "status"
            let v346 : JSX.Prop = JSX.Prop (v345, v344)
            US8_1(v346)
    let v349 : US0 = v89.l37
    let v355 : US8 =
        match v349 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v351) -> (* Some *)
            let v352 : string = "striped"
            let v353 : JSX.Prop = JSX.Prop (v352, v351)
            US8_1(v353)
    let v356 : US0 = v89.l38
    let v362 : US8 =
        match v356 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v358) -> (* Some *)
            let v359 : string = "thickness"
            let v360 : JSX.Prop = JSX.Prop (v359, v358)
            US8_1(v360)
    let v363 : US5 = v89.l39
    let v369 : US8 =
        match v363 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v365) -> (* Some *)
            let v366 : string = "title"
            let v367 : JSX.Prop = JSX.Prop (v366, v365)
            US8_1(v367)
    let v370 : US0 = v89.l40
    let v376 : US8 =
        match v370 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v372) -> (* Some *)
            let v373 : string = "top"
            let v374 : JSX.Prop = JSX.Prop (v373, v372)
            US8_1(v374)
    let v377 : US0 = v89.l41
    let v383 : US8 =
        match v377 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v379) -> (* Some *)
            let v380 : string = "width"
            let v381 : JSX.Prop = JSX.Prop (v380, v379)
            US8_1(v381)
    let v384 : US4 = v89.l42
    let v390 : US8 =
        match v384 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v386) -> (* Some *)
            let v387 : string = "zIndex"
            let v388 : JSX.Prop = JSX.Prop (v387, v386)
            US8_1(v388)
    let v391 : (US8 []) = [|v96; v103; v110; v117; v124; v131; v138; v145; v152; v159; v166; v173; v180; v187; v194; v201; v208; v215; v222; v229; v236; v243; v250; v257; v264; v271; v278; v285; v292; v299; v306; v313; v320; v327; v334; v341; v348; v355; v362; v369; v376; v383; v390|]
    let v392 : int32 = v391.Length
    let v393 : (US8 []) = Array.zeroCreate<US8> (v392)
    let v394 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method0(v392, v394) do
        let v396 : int32 = v394.l0
        let v397 : int32 = v394.l1
        let v398 : US8 = v391.[int v396]
        let v400 : bool =
            match v398 with
            | US8_0 -> (* None *)
                false
            | US8_1(v399) -> (* Some *)
                true
        let v402 : int32 =
            if v400 then
                v393.[int v397] <- v398
                let v401 : int32 = v397 + 1
                v401
            else
                v397
        let v403 : int32 = v396 + 1
        v394.l0 <- v403
        v394.l1 <- v402
        ()
    let v404 : int32 = v394.l1
    let v405 : (US8 []) = Array.zeroCreate<US8> (v404)
    let v406 : Mut1 = {l0 = 0} : Mut1
    while method1(v404, v406) do
        let v408 : int32 = v406.l0
        let v409 : US8 = v393.[int v408]
        v405.[int v408] <- v409
        let v410 : int32 = v408 + 1
        v406.l0 <- v410
        ()
    let v411 : int32 = v405.Length
    let v412 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v411)
    let v413 : Mut1 = {l0 = 0} : Mut1
    while method1(v411, v413) do
        let v415 : int32 = v413.l0
        let v416 : US8 = v405.[int v415]
        let v419 : JSX.Prop =
            match v416 with
            | US8_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US8_1(v418) -> (* Some *)
                v418
        v412.[int v415] <- v419
        let v420 : int32 = v415 + 1
        v413.l0 <- v420
        ()
    let v421 : obj = createObj v412
    let v422 : string = "createComponent"
    let v423 : string = "solid-js"
    let v424 : JS.Function = import v422 v423
    let v425 : string = "Anchor"
    let v426 : string = "@hope-ui/solid"
    let v427 : JSX.Element = v424.Invoke ((import v425 v426), v421) |> unbox<JSX.Element>
    let v428 : (JSX.Element []) = [|v427|]
    let v429 : JSX.Element = v428 |> unbox<JSX.Element>
    v429
and closure35 () () : JSX.Element =
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
    let v17 : string = "https://fc1943s.github.io/tictactoe_spiral/docs"
    let v18 : US0 = US0_1(v17)
    let v19 : US5 = US5_0
    let v20 : US0 = US0_0
    let v21 : US0 = US0_0
    let v22 : US0 = US0_0
    let v23 : US0 = US0_0
    let v24 : US0 = US0_0
    let v25 : US0 = US0_0
    let v26 : US0 = US0_0
    let v27 : US6 = US6_0
    let v28 : US7 = US7_0
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
    let v44 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43} : Heap0
    let v45 : US0 = v44.l17
    let v46 : US0 = US0_0
    let v47 : US1 = US1_0
    let v48 : US0 = US0_0
    let v49 : US0 = US0_0
    let v50 : US0 = US0_0
    let v51 : US2 = US2_0
    let v52 : (unit -> JSX.Element) = closure6(v44)
    let v53 : US3 = US3_1(v52)
    let v54 : US0 = US0_0
    let v55 : US0 = US0_0
    let v56 : US2 = US2_0
    let v57 : US0 = US0_0
    let v58 : US0 = US0_0
    let v59 : US2 = US2_1(true)
    let v60 : US4 = US4_0
    let v61 : US0 = US0_0
    let v62 : US0 = US0_0
    let v63 : US0 = US0_0
    let v64 : US5 = US5_0
    let v65 : US0 = US0_0
    let v66 : US0 = US0_0
    let v67 : US0 = US0_0
    let v68 : US0 = US0_0
    let v69 : US0 = US0_0
    let v70 : US0 = US0_0
    let v71 : US0 = US0_0
    let v72 : US6 = US6_0
    let v73 : US7 = US7_0
    let v74 : US0 = US0_0
    let v75 : US0 = US0_0
    let v76 : US0 = US0_0
    let v77 : US0 = US0_0
    let v78 : US0 = US0_0
    let v79 : US0 = US0_0
    let v80 : US0 = US0_0
    let v81 : US0 = US0_0
    let v82 : US2 = US2_0
    let v83 : US0 = US0_0
    let v84 : US0 = US0_0
    let v85 : US5 = US5_0
    let v86 : US0 = US0_0
    let v87 : US0 = US0_0
    let v88 : US4 = US4_0
    let v89 : Heap0 = {l0 = v46; l1 = v47; l2 = v48; l3 = v49; l4 = v50; l5 = v51; l6 = v53; l7 = v54; l8 = v55; l9 = v56; l10 = v57; l11 = v58; l12 = v59; l13 = v60; l14 = v61; l15 = v62; l16 = v63; l17 = v45; l18 = v64; l19 = v65; l20 = v66; l21 = v67; l22 = v68; l23 = v69; l24 = v70; l25 = v71; l26 = v72; l27 = v73; l28 = v74; l29 = v75; l30 = v76; l31 = v77; l32 = v78; l33 = v79; l34 = v80; l35 = v81; l36 = v82; l37 = v83; l38 = v84; l39 = v85; l40 = v86; l41 = v87; l42 = v88} : Heap0
    let v90 : US0 = v89.l0
    let v96 : US8 =
        match v90 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v92) -> (* Some *)
            let v93 : string = "aria-label"
            let v94 : JSX.Prop = JSX.Prop (v93, v92)
            US8_1(v94)
    let v97 : US1 = v89.l1
    let v103 : US8 =
        match v97 with
        | US1_0 -> (* None *)
            US8_0
        | US1_1(v99) -> (* Some *)
            let v100 : string = "as"
            let v101 : JSX.Prop = JSX.Prop (v100, v99)
            US8_1(v101)
    let v104 : US0 = v89.l2
    let v110 : US8 =
        match v104 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v106) -> (* Some *)
            let v107 : string = "backgroundColor"
            let v108 : JSX.Prop = JSX.Prop (v107, v106)
            US8_1(v108)
    let v111 : US0 = v89.l3
    let v117 : US8 =
        match v111 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v113) -> (* Some *)
            let v114 : string = "border"
            let v115 : JSX.Prop = JSX.Prop (v114, v113)
            US8_1(v115)
    let v118 : US0 = v89.l4
    let v124 : US8 =
        match v118 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v120) -> (* Some *)
            let v121 : string = "bottom"
            let v122 : JSX.Prop = JSX.Prop (v121, v120)
            US8_1(v122)
    let v125 : US0 = v89.l7
    let v131 : US8 =
        match v125 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v127) -> (* Some *)
            let v128 : string = "color"
            let v129 : JSX.Prop = JSX.Prop (v128, v127)
            US8_1(v129)
    let v132 : US2 = v89.l5
    let v138 : US8 =
        match v132 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v134) -> (* Some *)
            let v135 : string = "checked"
            let v136 : JSX.Prop = JSX.Prop (v135, v134)
            US8_1(v136)
    let v139 : US3 = v89.l6
    let v145 : US8 =
        match v139 with
        | US3_0 -> (* None *)
            US8_0
        | US3_1(v141) -> (* Some *)
            let v142 : string = "children"
            let v143 : JSX.Prop = JSX.Prop (v142, v141)
            US8_1(v143)
    let v146 : US0 = v89.l8
    let v152 : US8 =
        match v146 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v148) -> (* Some *)
            let v149 : string = "colorScheme"
            let v150 : JSX.Prop = JSX.Prop (v149, v148)
            US8_1(v150)
    let v153 : US2 = v89.l9
    let v159 : US8 =
        match v153 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v155) -> (* Some *)
            let v156 : string = "compact"
            let v157 : JSX.Prop = JSX.Prop (v156, v155)
            US8_1(v157)
    let v160 : US0 = v89.l11
    let v166 : US8 =
        match v160 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v162) -> (* Some *)
            let v163 : string = "display"
            let v164 : JSX.Prop = JSX.Prop (v163, v162)
            US8_1(v164)
    let v167 : US0 = v89.l10
    let v173 : US8 =
        match v167 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v169) -> (* Some *)
            let v170 : string = "direction"
            let v171 : JSX.Prop = JSX.Prop (v170, v169)
            US8_1(v171)
    let v174 : US2 = v89.l12
    let v180 : US8 =
        match v174 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v176) -> (* Some *)
            let v177 : string = "external"
            let v178 : JSX.Prop = JSX.Prop (v177, v176)
            US8_1(v178)
    let v181 : US4 = v89.l13
    let v187 : US8 =
        match v181 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v183) -> (* Some *)
            let v184 : string = "flex"
            let v185 : JSX.Prop = JSX.Prop (v184, v183)
            US8_1(v185)
    let v188 : US0 = v89.l14
    let v194 : US8 =
        match v188 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v190) -> (* Some *)
            let v191 : string = "flexDirection"
            let v192 : JSX.Prop = JSX.Prop (v191, v190)
            US8_1(v192)
    let v195 : US0 = v89.l15
    let v201 : US8 =
        match v195 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v197) -> (* Some *)
            let v198 : string = "fontSize"
            let v199 : JSX.Prop = JSX.Prop (v198, v197)
            US8_1(v199)
    let v202 : US0 = v89.l16
    let v208 : US8 =
        match v202 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v204) -> (* Some *)
            let v205 : string = "height"
            let v206 : JSX.Prop = JSX.Prop (v205, v204)
            US8_1(v206)
    let v209 : US0 = v89.l17
    let v215 : US8 =
        match v209 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v211) -> (* Some *)
            let v212 : string = "href"
            let v213 : JSX.Prop = JSX.Prop (v212, v211)
            US8_1(v213)
    let v216 : US5 = v89.l18
    let v222 : US8 =
        match v216 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v218) -> (* Some *)
            let v219 : string = "icon"
            let v220 : JSX.Prop = JSX.Prop (v219, v218)
            US8_1(v220)
    let v223 : US0 = v89.l19
    let v229 : US8 =
        match v223 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v225) -> (* Some *)
            let v226 : string = "id"
            let v227 : JSX.Prop = JSX.Prop (v226, v225)
            US8_1(v227)
    let v230 : US0 = v89.l20
    let v236 : US8 =
        match v230 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v232) -> (* Some *)
            let v233 : string = "justifyContent"
            let v234 : JSX.Prop = JSX.Prop (v233, v232)
            US8_1(v234)
    let v237 : US0 = v89.l21
    let v243 : US8 =
        match v237 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v239) -> (* Some *)
            let v240 : string = "left"
            let v241 : JSX.Prop = JSX.Prop (v240, v239)
            US8_1(v241)
    let v244 : US0 = v89.l22
    let v250 : US8 =
        match v244 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v246) -> (* Some *)
            let v247 : string = "lineHeight"
            let v248 : JSX.Prop = JSX.Prop (v247, v246)
            US8_1(v248)
    let v251 : US0 = v89.l23
    let v257 : US8 =
        match v251 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v253) -> (* Some *)
            let v254 : string = "margin"
            let v255 : JSX.Prop = JSX.Prop (v254, v253)
            US8_1(v255)
    let v258 : US0 = v89.l24
    let v264 : US8 =
        match v258 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v260) -> (* Some *)
            let v261 : string = "marginBottom"
            let v262 : JSX.Prop = JSX.Prop (v261, v260)
            US8_1(v262)
    let v265 : US0 = v89.l25
    let v271 : US8 =
        match v265 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v267) -> (* Some *)
            let v268 : string = "maxHeight"
            let v269 : JSX.Prop = JSX.Prop (v268, v267)
            US8_1(v269)
    let v272 : US6 = v89.l26
    let v278 : US8 =
        match v272 with
        | US6_0 -> (* None *)
            US8_0
        | US6_1(v274) -> (* Some *)
            let v275 : string = "onChange"
            let v276 : JSX.Prop = JSX.Prop (v275, v274)
            US8_1(v276)
    let v279 : US7 = v89.l27
    let v285 : US8 =
        match v279 with
        | US7_0 -> (* None *)
            US8_0
        | US7_1(v281) -> (* Some *)
            let v282 : string = "onClick"
            let v283 : JSX.Prop = JSX.Prop (v282, v281)
            US8_1(v283)
    let v286 : US0 = v89.l28
    let v292 : US8 =
        match v286 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v288) -> (* Some *)
            let v289 : string = "outline"
            let v290 : JSX.Prop = JSX.Prop (v289, v288)
            US8_1(v290)
    let v293 : US0 = v89.l29
    let v299 : US8 =
        match v293 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v295) -> (* Some *)
            let v296 : string = "overflowY"
            let v297 : JSX.Prop = JSX.Prop (v296, v295)
            US8_1(v297)
    let v300 : US0 = v89.l30
    let v306 : US8 =
        match v300 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v302) -> (* Some *)
            let v303 : string = "padding"
            let v304 : JSX.Prop = JSX.Prop (v303, v302)
            US8_1(v304)
    let v307 : US0 = v89.l31
    let v313 : US8 =
        match v307 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v309) -> (* Some *)
            let v310 : string = "paddingTop"
            let v311 : JSX.Prop = JSX.Prop (v310, v309)
            US8_1(v311)
    let v314 : US0 = v89.l32
    let v320 : US8 =
        match v314 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v316) -> (* Some *)
            let v317 : string = "position"
            let v318 : JSX.Prop = JSX.Prop (v317, v316)
            US8_1(v318)
    let v321 : US0 = v89.l33
    let v327 : US8 =
        match v321 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v323) -> (* Some *)
            let v324 : string = "right"
            let v325 : JSX.Prop = JSX.Prop (v324, v323)
            US8_1(v325)
    let v328 : US0 = v89.l34
    let v334 : US8 =
        match v328 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v330) -> (* Some *)
            let v331 : string = "size"
            let v332 : JSX.Prop = JSX.Prop (v331, v330)
            US8_1(v332)
    let v335 : US0 = v89.l35
    let v341 : US8 =
        match v335 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v337) -> (* Some *)
            let v338 : string = "spacing"
            let v339 : JSX.Prop = JSX.Prop (v338, v337)
            US8_1(v339)
    let v342 : US2 = v89.l36
    let v348 : US8 =
        match v342 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v344) -> (* Some *)
            let v345 : string = "status"
            let v346 : JSX.Prop = JSX.Prop (v345, v344)
            US8_1(v346)
    let v349 : US0 = v89.l37
    let v355 : US8 =
        match v349 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v351) -> (* Some *)
            let v352 : string = "striped"
            let v353 : JSX.Prop = JSX.Prop (v352, v351)
            US8_1(v353)
    let v356 : US0 = v89.l38
    let v362 : US8 =
        match v356 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v358) -> (* Some *)
            let v359 : string = "thickness"
            let v360 : JSX.Prop = JSX.Prop (v359, v358)
            US8_1(v360)
    let v363 : US5 = v89.l39
    let v369 : US8 =
        match v363 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v365) -> (* Some *)
            let v366 : string = "title"
            let v367 : JSX.Prop = JSX.Prop (v366, v365)
            US8_1(v367)
    let v370 : US0 = v89.l40
    let v376 : US8 =
        match v370 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v372) -> (* Some *)
            let v373 : string = "top"
            let v374 : JSX.Prop = JSX.Prop (v373, v372)
            US8_1(v374)
    let v377 : US0 = v89.l41
    let v383 : US8 =
        match v377 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v379) -> (* Some *)
            let v380 : string = "width"
            let v381 : JSX.Prop = JSX.Prop (v380, v379)
            US8_1(v381)
    let v384 : US4 = v89.l42
    let v390 : US8 =
        match v384 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v386) -> (* Some *)
            let v387 : string = "zIndex"
            let v388 : JSX.Prop = JSX.Prop (v387, v386)
            US8_1(v388)
    let v391 : (US8 []) = [|v96; v103; v110; v117; v124; v131; v138; v145; v152; v159; v166; v173; v180; v187; v194; v201; v208; v215; v222; v229; v236; v243; v250; v257; v264; v271; v278; v285; v292; v299; v306; v313; v320; v327; v334; v341; v348; v355; v362; v369; v376; v383; v390|]
    let v392 : int32 = v391.Length
    let v393 : (US8 []) = Array.zeroCreate<US8> (v392)
    let v394 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method0(v392, v394) do
        let v396 : int32 = v394.l0
        let v397 : int32 = v394.l1
        let v398 : US8 = v391.[int v396]
        let v400 : bool =
            match v398 with
            | US8_0 -> (* None *)
                false
            | US8_1(v399) -> (* Some *)
                true
        let v402 : int32 =
            if v400 then
                v393.[int v397] <- v398
                let v401 : int32 = v397 + 1
                v401
            else
                v397
        let v403 : int32 = v396 + 1
        v394.l0 <- v403
        v394.l1 <- v402
        ()
    let v404 : int32 = v394.l1
    let v405 : (US8 []) = Array.zeroCreate<US8> (v404)
    let v406 : Mut1 = {l0 = 0} : Mut1
    while method1(v404, v406) do
        let v408 : int32 = v406.l0
        let v409 : US8 = v393.[int v408]
        v405.[int v408] <- v409
        let v410 : int32 = v408 + 1
        v406.l0 <- v410
        ()
    let v411 : int32 = v405.Length
    let v412 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v411)
    let v413 : Mut1 = {l0 = 0} : Mut1
    while method1(v411, v413) do
        let v415 : int32 = v413.l0
        let v416 : US8 = v405.[int v415]
        let v419 : JSX.Prop =
            match v416 with
            | US8_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US8_1(v418) -> (* Some *)
                v418
        v412.[int v415] <- v419
        let v420 : int32 = v415 + 1
        v413.l0 <- v420
        ()
    let v421 : obj = createObj v412
    let v422 : string = "createComponent"
    let v423 : string = "solid-js"
    let v424 : JS.Function = import v422 v423
    let v425 : string = "Anchor"
    let v426 : string = "@hope-ui/solid"
    let v427 : JSX.Element = v424.Invoke ((import v425 v426), v421) |> unbox<JSX.Element>
    let v428 : (JSX.Element []) = [|v427|]
    let v429 : JSX.Element = v428 |> unbox<JSX.Element>
    v429
and closure8 () () : JSX.Element =
    let v0 : US0 = US0_0
    let v1 : US1 = US1_0
    let v2 : US0 = US0_0
    let v3 : US0 = US0_0
    let v4 : US0 = US0_0
    let v5 : US2 = US2_0
    let v6 : (unit -> JSX.Element) = closure9()
    let v7 : US3 = US3_1(v6)
    let v8 : US0 = US0_0
    let v9 : US0 = US0_0
    let v10 : US2 = US2_0
    let v11 : US0 = US0_0
    let v12 : US0 = US0_0
    let v13 : US2 = US2_0
    let v14 : US4 = US4_0
    let v15 : US0 = US0_0
    let v16 : US0 = US0_0
    let v17 : US0 = US0_0
    let v18 : US0 = US0_0
    let v19 : US5 = US5_0
    let v20 : US0 = US0_0
    let v21 : US0 = US0_0
    let v22 : US0 = US0_0
    let v23 : US0 = US0_0
    let v24 : US0 = US0_0
    let v25 : US0 = US0_0
    let v26 : US0 = US0_0
    let v27 : US6 = US6_0
    let v28 : US7 = US7_0
    let v29 : US0 = US0_0
    let v30 : US0 = US0_0
    let v31 : string = "1px 6px"
    let v32 : US0 = US0_1(v31)
    let v33 : US0 = US0_0
    let v34 : US0 = US0_0
    let v35 : US0 = US0_0
    let v36 : US0 = US0_0
    let v37 : US0 = US0_0
    let v38 : US2 = US2_0
    let v39 : US0 = US0_0
    let v40 : US0 = US0_0
    let v41 : US5 = US5_0
    let v42 : US0 = US0_0
    let v43 : US0 = US0_0
    let v44 : US4 = US4_0
    let v45 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44} : Heap0
    let v46 : US2 = v45.l36
    let v50 : bool =
        match v46 with
        | US2_1(v48) -> (* Some *)
            let v49 : bool = v48 = false
            v49
        | _ ->
            false
    let v51 : bool = v50 <> true
    let v52 : string = "createSignal"
    let v53 : string = "solid-js"
    let v54 : JS.Function = import v52 v53
    let v55 : (JS.Function []) = v54.Invoke v51 |> unbox<JS.Function[]>
    let v56 : (unit -> bool) = v55.[0] |> unbox
    let v57 : (bool -> unit) = v55.[1] |> unbox
    let v58 : US0 = v45.l19
    let v59 : string = {| ``@initial`` = "column"; ``@sm`` = "row" |} |> unbox<string>
    let v60 : US0 = US0_0
    let v61 : US1 = US1_0
    let v62 : US0 = US0_0
    let v63 : string = "1px solid $neutral5"
    let v64 : US0 = US0_1(v63)
    let v65 : US0 = US0_0
    let v66 : US2 = US2_0
    let v67 : (unit -> JSX.Element) = closure10(v45, v57, v56)
    let v68 : US3 = US3_1(v67)
    let v69 : US0 = US0_0
    let v70 : US0 = US0_0
    let v71 : US2 = US2_0
    let v72 : US0 = US0_0
    let v73 : string = "flex"
    let v74 : US0 = US0_1(v73)
    let v75 : US2 = US2_0
    let v76 : US4 = US4_1(1)
    let v77 : US0 = US0_1(v59)
    let v78 : US0 = US0_0
    let v79 : US0 = US0_0
    let v80 : US0 = US0_0
    let v81 : US5 = US5_0
    let v82 : US0 = US0_0
    let v83 : US0 = US0_0
    let v84 : US0 = US0_0
    let v85 : US0 = US0_0
    let v86 : US0 = US0_0
    let v87 : US0 = US0_0
    let v88 : US6 = US6_0
    let v89 : US7 = US7_0
    let v90 : US0 = US0_0
    let v91 : US0 = US0_0
    let v92 : US0 = US0_0
    let v93 : US0 = US0_0
    let v94 : US0 = US0_0
    let v95 : US0 = US0_0
    let v96 : US0 = US0_0
    let v97 : US0 = US0_0
    let v98 : US2 = US2_0
    let v99 : US0 = US0_0
    let v100 : US0 = US0_0
    let v101 : US5 = US5_0
    let v102 : US0 = US0_0
    let v103 : US0 = US0_0
    let v104 : US4 = US4_0
    let v105 : Heap0 = {l0 = v60; l1 = v61; l2 = v62; l3 = v64; l4 = v65; l5 = v66; l6 = v68; l7 = v69; l8 = v70; l9 = v71; l10 = v72; l11 = v74; l12 = v75; l13 = v76; l14 = v77; l15 = v78; l16 = v79; l17 = v80; l18 = v81; l19 = v58; l20 = v82; l21 = v83; l22 = v84; l23 = v85; l24 = v86; l25 = v87; l26 = v88; l27 = v89; l28 = v90; l29 = v91; l30 = v92; l31 = v93; l32 = v94; l33 = v95; l34 = v96; l35 = v97; l36 = v98; l37 = v99; l38 = v100; l39 = v101; l40 = v102; l41 = v103; l42 = v104} : Heap0
    let v106 : (Heap0 -> JSX.Element) = closure33()
    let v107 : JS.Function = v106 |> unbox<JS.Function>
    let v108 : string = "createComponent"
    let v109 : JS.Function = import v108 v53
    let v110 : JSX.Element = v109.Invoke (v107, v105) |> unbox<JSX.Element>
    let v111 : US0 = US0_0
    let v112 : US1 = US1_0
    let v113 : US0 = US0_0
    let v114 : US0 = US0_0
    let v115 : US0 = US0_0
    let v116 : US2 = US2_0
    let v117 : (unit -> JSX.Element) = closure34()
    let v118 : US3 = US3_1(v117)
    let v119 : US0 = US0_0
    let v120 : US0 = US0_0
    let v121 : US2 = US2_0
    let v122 : US0 = US0_0
    let v123 : US0 = US0_0
    let v124 : US2 = US2_0
    let v125 : US4 = US4_0
    let v126 : US0 = US0_0
    let v127 : US0 = US0_0
    let v128 : US0 = US0_0
    let v129 : US0 = US0_0
    let v130 : US5 = US5_0
    let v131 : US0 = US0_0
    let v132 : US0 = US0_0
    let v133 : US0 = US0_0
    let v134 : US0 = US0_0
    let v135 : US0 = US0_0
    let v136 : US0 = US0_0
    let v137 : US0 = US0_0
    let v138 : US6 = US6_0
    let v139 : US7 = US7_0
    let v140 : US0 = US0_0
    let v141 : US0 = US0_0
    let v142 : US0 = US0_1(v31)
    let v143 : US0 = US0_0
    let v144 : US0 = US0_0
    let v145 : US0 = US0_0
    let v146 : US0 = US0_0
    let v147 : US0 = US0_0
    let v148 : US2 = US2_0
    let v149 : US0 = US0_0
    let v150 : US0 = US0_0
    let v151 : US5 = US5_0
    let v152 : US0 = US0_0
    let v153 : US0 = US0_0
    let v154 : US4 = US4_0
    let v155 : Heap0 = {l0 = v111; l1 = v112; l2 = v113; l3 = v114; l4 = v115; l5 = v116; l6 = v118; l7 = v119; l8 = v120; l9 = v121; l10 = v122; l11 = v123; l12 = v124; l13 = v125; l14 = v126; l15 = v127; l16 = v128; l17 = v129; l18 = v130; l19 = v131; l20 = v132; l21 = v133; l22 = v134; l23 = v135; l24 = v136; l25 = v137; l26 = v138; l27 = v139; l28 = v140; l29 = v141; l30 = v142; l31 = v143; l32 = v144; l33 = v145; l34 = v146; l35 = v147; l36 = v148; l37 = v149; l38 = v150; l39 = v151; l40 = v152; l41 = v153; l42 = v154} : Heap0
    let v156 : US2 = v155.l36
    let v160 : bool =
        match v156 with
        | US2_1(v158) -> (* Some *)
            let v159 : bool = v158 = false
            v159
        | _ ->
            false
    let v161 : bool = v160 <> true
    let v162 : JS.Function = import v52 v53
    let v163 : (JS.Function []) = v162.Invoke v161 |> unbox<JS.Function[]>
    let v164 : (unit -> bool) = v163.[0] |> unbox
    let v165 : (bool -> unit) = v163.[1] |> unbox
    let v166 : US0 = v155.l19
    let v167 : string = {| ``@initial`` = "column"; ``@sm`` = "row" |} |> unbox<string>
    let v168 : US0 = US0_0
    let v169 : US1 = US1_0
    let v170 : US0 = US0_0
    let v171 : US0 = US0_1(v63)
    let v172 : US0 = US0_0
    let v173 : US2 = US2_0
    let v174 : (unit -> JSX.Element) = closure10(v155, v165, v164)
    let v175 : US3 = US3_1(v174)
    let v176 : US0 = US0_0
    let v177 : US0 = US0_0
    let v178 : US2 = US2_0
    let v179 : US0 = US0_0
    let v180 : US0 = US0_1(v73)
    let v181 : US2 = US2_0
    let v182 : US4 = US4_1(1)
    let v183 : US0 = US0_1(v167)
    let v184 : US0 = US0_0
    let v185 : US0 = US0_0
    let v186 : US0 = US0_0
    let v187 : US5 = US5_0
    let v188 : US0 = US0_0
    let v189 : US0 = US0_0
    let v190 : US0 = US0_0
    let v191 : US0 = US0_0
    let v192 : US0 = US0_0
    let v193 : US0 = US0_0
    let v194 : US6 = US6_0
    let v195 : US7 = US7_0
    let v196 : US0 = US0_0
    let v197 : US0 = US0_0
    let v198 : US0 = US0_0
    let v199 : US0 = US0_0
    let v200 : US0 = US0_0
    let v201 : US0 = US0_0
    let v202 : US0 = US0_0
    let v203 : US0 = US0_0
    let v204 : US2 = US2_0
    let v205 : US0 = US0_0
    let v206 : US0 = US0_0
    let v207 : US5 = US5_0
    let v208 : US0 = US0_0
    let v209 : US0 = US0_0
    let v210 : US4 = US4_0
    let v211 : Heap0 = {l0 = v168; l1 = v169; l2 = v170; l3 = v171; l4 = v172; l5 = v173; l6 = v175; l7 = v176; l8 = v177; l9 = v178; l10 = v179; l11 = v180; l12 = v181; l13 = v182; l14 = v183; l15 = v184; l16 = v185; l17 = v186; l18 = v187; l19 = v166; l20 = v188; l21 = v189; l22 = v190; l23 = v191; l24 = v192; l25 = v193; l26 = v194; l27 = v195; l28 = v196; l29 = v197; l30 = v198; l31 = v199; l32 = v200; l33 = v201; l34 = v202; l35 = v203; l36 = v204; l37 = v205; l38 = v206; l39 = v207; l40 = v208; l41 = v209; l42 = v210} : Heap0
    let v212 : JS.Function = v106 |> unbox<JS.Function>
    let v213 : JS.Function = import v108 v53
    let v214 : JSX.Element = v213.Invoke (v212, v211) |> unbox<JSX.Element>
    let v215 : US0 = US0_0
    let v216 : US1 = US1_0
    let v217 : US0 = US0_0
    let v218 : US0 = US0_0
    let v219 : US0 = US0_0
    let v220 : US2 = US2_0
    let v221 : (unit -> JSX.Element) = closure35()
    let v222 : US3 = US3_1(v221)
    let v223 : US0 = US0_0
    let v224 : US0 = US0_0
    let v225 : US2 = US2_0
    let v226 : US0 = US0_0
    let v227 : US0 = US0_0
    let v228 : US2 = US2_0
    let v229 : US4 = US4_0
    let v230 : US0 = US0_0
    let v231 : US0 = US0_0
    let v232 : US0 = US0_0
    let v233 : US0 = US0_0
    let v234 : US5 = US5_0
    let v235 : US0 = US0_0
    let v236 : US0 = US0_0
    let v237 : US0 = US0_0
    let v238 : US0 = US0_0
    let v239 : US0 = US0_0
    let v240 : US0 = US0_0
    let v241 : US0 = US0_0
    let v242 : US6 = US6_0
    let v243 : US7 = US7_0
    let v244 : US0 = US0_0
    let v245 : US0 = US0_0
    let v246 : US0 = US0_1(v31)
    let v247 : US0 = US0_0
    let v248 : US0 = US0_0
    let v249 : US0 = US0_0
    let v250 : US0 = US0_0
    let v251 : US0 = US0_0
    let v252 : US2 = US2_0
    let v253 : US0 = US0_0
    let v254 : US0 = US0_0
    let v255 : US5 = US5_0
    let v256 : US0 = US0_0
    let v257 : US0 = US0_0
    let v258 : US4 = US4_0
    let v259 : Heap0 = {l0 = v215; l1 = v216; l2 = v217; l3 = v218; l4 = v219; l5 = v220; l6 = v222; l7 = v223; l8 = v224; l9 = v225; l10 = v226; l11 = v227; l12 = v228; l13 = v229; l14 = v230; l15 = v231; l16 = v232; l17 = v233; l18 = v234; l19 = v235; l20 = v236; l21 = v237; l22 = v238; l23 = v239; l24 = v240; l25 = v241; l26 = v242; l27 = v243; l28 = v244; l29 = v245; l30 = v246; l31 = v247; l32 = v248; l33 = v249; l34 = v250; l35 = v251; l36 = v252; l37 = v253; l38 = v254; l39 = v255; l40 = v256; l41 = v257; l42 = v258} : Heap0
    let v260 : US2 = v259.l36
    let v264 : bool =
        match v260 with
        | US2_1(v262) -> (* Some *)
            let v263 : bool = v262 = false
            v263
        | _ ->
            false
    let v265 : bool = v264 <> true
    let v266 : JS.Function = import v52 v53
    let v267 : (JS.Function []) = v266.Invoke v265 |> unbox<JS.Function[]>
    let v268 : (unit -> bool) = v267.[0] |> unbox
    let v269 : (bool -> unit) = v267.[1] |> unbox
    let v270 : US0 = v259.l19
    let v271 : string = {| ``@initial`` = "column"; ``@sm`` = "row" |} |> unbox<string>
    let v272 : US0 = US0_0
    let v273 : US1 = US1_0
    let v274 : US0 = US0_0
    let v275 : US0 = US0_1(v63)
    let v276 : US0 = US0_0
    let v277 : US2 = US2_0
    let v278 : (unit -> JSX.Element) = closure10(v259, v269, v268)
    let v279 : US3 = US3_1(v278)
    let v280 : US0 = US0_0
    let v281 : US0 = US0_0
    let v282 : US2 = US2_0
    let v283 : US0 = US0_0
    let v284 : US0 = US0_1(v73)
    let v285 : US2 = US2_0
    let v286 : US4 = US4_1(1)
    let v287 : US0 = US0_1(v271)
    let v288 : US0 = US0_0
    let v289 : US0 = US0_0
    let v290 : US0 = US0_0
    let v291 : US5 = US5_0
    let v292 : US0 = US0_0
    let v293 : US0 = US0_0
    let v294 : US0 = US0_0
    let v295 : US0 = US0_0
    let v296 : US0 = US0_0
    let v297 : US0 = US0_0
    let v298 : US6 = US6_0
    let v299 : US7 = US7_0
    let v300 : US0 = US0_0
    let v301 : US0 = US0_0
    let v302 : US0 = US0_0
    let v303 : US0 = US0_0
    let v304 : US0 = US0_0
    let v305 : US0 = US0_0
    let v306 : US0 = US0_0
    let v307 : US0 = US0_0
    let v308 : US2 = US2_0
    let v309 : US0 = US0_0
    let v310 : US0 = US0_0
    let v311 : US5 = US5_0
    let v312 : US0 = US0_0
    let v313 : US0 = US0_0
    let v314 : US4 = US4_0
    let v315 : Heap0 = {l0 = v272; l1 = v273; l2 = v274; l3 = v275; l4 = v276; l5 = v277; l6 = v279; l7 = v280; l8 = v281; l9 = v282; l10 = v283; l11 = v284; l12 = v285; l13 = v286; l14 = v287; l15 = v288; l16 = v289; l17 = v290; l18 = v291; l19 = v270; l20 = v292; l21 = v293; l22 = v294; l23 = v295; l24 = v296; l25 = v297; l26 = v298; l27 = v299; l28 = v300; l29 = v301; l30 = v302; l31 = v303; l32 = v304; l33 = v305; l34 = v306; l35 = v307; l36 = v308; l37 = v309; l38 = v310; l39 = v311; l40 = v312; l41 = v313; l42 = v314} : Heap0
    let v316 : JS.Function = v106 |> unbox<JS.Function>
    let v317 : JS.Function = import v108 v53
    let v318 : JSX.Element = v317.Invoke (v316, v315) |> unbox<JSX.Element>
    let v319 : (JSX.Element []) = [|v110; v214; v318|]
    let v320 : JSX.Element = v319 |> unbox<JSX.Element>
    v320
and closure7 () () : JSX.Element =
    let v0 : US0 = US0_0
    let v1 : US1 = US1_0
    let v2 : US0 = US0_0
    let v3 : US0 = US0_0
    let v4 : US0 = US0_0
    let v5 : US2 = US2_0
    let v6 : (unit -> JSX.Element) = closure8()
    let v7 : US3 = US3_1(v6)
    let v8 : US0 = US0_0
    let v9 : US0 = US0_0
    let v10 : US2 = US2_0
    let v11 : US0 = US0_0
    let v12 : US0 = US0_0
    let v13 : US2 = US2_0
    let v14 : US4 = US4_0
    let v15 : US0 = US0_0
    let v16 : US0 = US0_0
    let v17 : US0 = US0_0
    let v18 : US0 = US0_0
    let v19 : US5 = US5_0
    let v20 : US0 = US0_0
    let v21 : US0 = US0_0
    let v22 : US0 = US0_0
    let v23 : US0 = US0_0
    let v24 : US0 = US0_0
    let v25 : US0 = US0_0
    let v26 : US0 = US0_0
    let v27 : US6 = US6_0
    let v28 : US7 = US7_0
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
    let v44 : Heap0 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43} : Heap0
    let v45 : (Heap0 -> JSX.Element) = closure1()
    let v46 : JS.Function = v45 |> unbox<JS.Function>
    let v47 : string = "createComponent"
    let v48 : string = "solid-js"
    let v49 : JS.Function = import v47 v48
    let v50 : JSX.Element = v49.Invoke (v46, v44) |> unbox<JSX.Element>
    v50
and closure40 (v0 : US7, v1 : (bool -> unit)) () : unit =
    match v0 with
    | US7_0 -> (* None *)
        ()
    | US7_1(v2) -> (* Some *)
        v2 ()
        ()
    v1 true
    ()
and closure39 (v0 : US7, v1 : (bool -> unit)) () : JSX.Element =
    let v2 : US0 = US0_0
    let v3 : US1 = US1_0
    let v4 : US0 = US0_0
    let v5 : US0 = US0_0
    let v6 : US0 = US0_0
    let v7 : US2 = US2_0
    let v8 : (unit -> JSX.Element) = closure23()
    let v9 : US3 = US3_1(v8)
    let v10 : US0 = US0_0
    let v11 : US0 = US0_0
    let v12 : US2 = US2_0
    let v13 : US0 = US0_0
    let v14 : US0 = US0_0
    let v15 : US2 = US2_0
    let v16 : US4 = US4_0
    let v17 : US0 = US0_0
    let v18 : US0 = US0_0
    let v19 : US0 = US0_0
    let v20 : US0 = US0_0
    let v21 : US5 = US5_0
    let v22 : US0 = US0_0
    let v23 : US0 = US0_0
    let v24 : US0 = US0_0
    let v25 : US0 = US0_0
    let v26 : US0 = US0_0
    let v27 : US0 = US0_0
    let v28 : US0 = US0_0
    let v29 : US6 = US6_0
    let v30 : (unit -> unit) = closure40(v0, v1)
    let v31 : US7 = US7_1(v30)
    let v32 : US0 = US0_0
    let v33 : US0 = US0_0
    let v34 : US0 = US0_0
    let v35 : US0 = US0_0
    let v36 : US0 = US0_0
    let v37 : US0 = US0_0
    let v38 : US0 = US0_0
    let v39 : US0 = US0_0
    let v40 : US2 = US2_0
    let v41 : US0 = US0_0
    let v42 : US0 = US0_0
    let v43 : US5 = US5_0
    let v44 : US0 = US0_0
    let v45 : US0 = US0_0
    let v46 : US4 = US4_0
    let v47 : Heap0 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v13; l11 = v14; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46} : Heap0
    let v48 : US3 = v47.l6
    let v49 : US0 = US0_0
    let v50 : US1 = US1_0
    let v51 : US0 = US0_0
    let v52 : US0 = US0_0
    let v53 : US0 = US0_0
    let v54 : US2 = US2_0
    let v55 : US0 = US0_0
    let v56 : string = "neutral"
    let v57 : US0 = US0_1(v56)
    let v58 : US2 = US2_1(true)
    let v59 : US0 = US0_0
    let v60 : US0 = US0_0
    let v61 : US2 = US2_0
    let v62 : US4 = US4_0
    let v63 : US0 = US0_0
    let v64 : US0 = US0_0
    let v65 : US0 = US0_0
    let v66 : US0 = US0_0
    let v67 : US5 = US5_0
    let v68 : US0 = US0_0
    let v69 : string = "left"
    let v70 : US0 = US0_1(v69)
    let v71 : US0 = US0_0
    let v72 : US0 = US0_0
    let v73 : US0 = US0_0
    let v74 : US0 = US0_0
    let v75 : US0 = US0_0
    let v76 : US6 = US6_0
    let v77 : US7 = US7_0
    let v78 : US0 = US0_0
    let v79 : US0 = US0_0
    let v80 : US0 = US0_0
    let v81 : US0 = US0_0
    let v82 : US0 = US0_0
    let v83 : US0 = US0_0
    let v84 : string = "xs"
    let v85 : US0 = US0_1(v84)
    let v86 : US0 = US0_0
    let v87 : US2 = US2_0
    let v88 : US0 = US0_0
    let v89 : US0 = US0_0
    let v90 : US5 = US5_0
    let v91 : US0 = US0_0
    let v92 : US0 = US0_0
    let v93 : US4 = US4_0
    let v94 : Heap0 = {l0 = v49; l1 = v50; l2 = v51; l3 = v52; l4 = v53; l5 = v54; l6 = v48; l7 = v55; l8 = v57; l9 = v58; l10 = v59; l11 = v60; l12 = v61; l13 = v62; l14 = v63; l15 = v64; l16 = v65; l17 = v66; l18 = v67; l19 = v68; l20 = v70; l21 = v71; l22 = v72; l23 = v73; l24 = v74; l25 = v75; l26 = v76; l27 = v77; l28 = v78; l29 = v79; l30 = v80; l31 = v81; l32 = v82; l33 = v83; l34 = v85; l35 = v86; l36 = v87; l37 = v88; l38 = v89; l39 = v90; l40 = v91; l41 = v92; l42 = v93} : Heap0
    let v95 : US0 = v94.l0
    let v101 : US8 =
        match v95 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v97) -> (* Some *)
            let v98 : string = "aria-label"
            let v99 : JSX.Prop = JSX.Prop (v98, v97)
            US8_1(v99)
    let v102 : US1 = v94.l1
    let v108 : US8 =
        match v102 with
        | US1_0 -> (* None *)
            US8_0
        | US1_1(v104) -> (* Some *)
            let v105 : string = "as"
            let v106 : JSX.Prop = JSX.Prop (v105, v104)
            US8_1(v106)
    let v109 : US0 = v94.l2
    let v115 : US8 =
        match v109 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v111) -> (* Some *)
            let v112 : string = "backgroundColor"
            let v113 : JSX.Prop = JSX.Prop (v112, v111)
            US8_1(v113)
    let v116 : US0 = v94.l3
    let v122 : US8 =
        match v116 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v118) -> (* Some *)
            let v119 : string = "border"
            let v120 : JSX.Prop = JSX.Prop (v119, v118)
            US8_1(v120)
    let v123 : US0 = v94.l4
    let v129 : US8 =
        match v123 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v125) -> (* Some *)
            let v126 : string = "bottom"
            let v127 : JSX.Prop = JSX.Prop (v126, v125)
            US8_1(v127)
    let v130 : US0 = v94.l7
    let v136 : US8 =
        match v130 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v132) -> (* Some *)
            let v133 : string = "color"
            let v134 : JSX.Prop = JSX.Prop (v133, v132)
            US8_1(v134)
    let v137 : US2 = v94.l5
    let v143 : US8 =
        match v137 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v139) -> (* Some *)
            let v140 : string = "checked"
            let v141 : JSX.Prop = JSX.Prop (v140, v139)
            US8_1(v141)
    let v144 : US3 = v94.l6
    let v150 : US8 =
        match v144 with
        | US3_0 -> (* None *)
            US8_0
        | US3_1(v146) -> (* Some *)
            let v147 : string = "children"
            let v148 : JSX.Prop = JSX.Prop (v147, v146)
            US8_1(v148)
    let v151 : US0 = v94.l8
    let v157 : US8 =
        match v151 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v153) -> (* Some *)
            let v154 : string = "colorScheme"
            let v155 : JSX.Prop = JSX.Prop (v154, v153)
            US8_1(v155)
    let v158 : US2 = v94.l9
    let v164 : US8 =
        match v158 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v160) -> (* Some *)
            let v161 : string = "compact"
            let v162 : JSX.Prop = JSX.Prop (v161, v160)
            US8_1(v162)
    let v165 : US0 = v94.l11
    let v171 : US8 =
        match v165 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v167) -> (* Some *)
            let v168 : string = "display"
            let v169 : JSX.Prop = JSX.Prop (v168, v167)
            US8_1(v169)
    let v172 : US0 = v94.l10
    let v178 : US8 =
        match v172 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v174) -> (* Some *)
            let v175 : string = "direction"
            let v176 : JSX.Prop = JSX.Prop (v175, v174)
            US8_1(v176)
    let v179 : US2 = v94.l12
    let v185 : US8 =
        match v179 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v181) -> (* Some *)
            let v182 : string = "external"
            let v183 : JSX.Prop = JSX.Prop (v182, v181)
            US8_1(v183)
    let v186 : US4 = v94.l13
    let v192 : US8 =
        match v186 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v188) -> (* Some *)
            let v189 : string = "flex"
            let v190 : JSX.Prop = JSX.Prop (v189, v188)
            US8_1(v190)
    let v193 : US0 = v94.l14
    let v199 : US8 =
        match v193 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v195) -> (* Some *)
            let v196 : string = "flexDirection"
            let v197 : JSX.Prop = JSX.Prop (v196, v195)
            US8_1(v197)
    let v200 : US0 = v94.l15
    let v206 : US8 =
        match v200 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v202) -> (* Some *)
            let v203 : string = "fontSize"
            let v204 : JSX.Prop = JSX.Prop (v203, v202)
            US8_1(v204)
    let v207 : US0 = v94.l16
    let v213 : US8 =
        match v207 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v209) -> (* Some *)
            let v210 : string = "height"
            let v211 : JSX.Prop = JSX.Prop (v210, v209)
            US8_1(v211)
    let v214 : US0 = v94.l17
    let v220 : US8 =
        match v214 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v216) -> (* Some *)
            let v217 : string = "href"
            let v218 : JSX.Prop = JSX.Prop (v217, v216)
            US8_1(v218)
    let v221 : US5 = v94.l18
    let v227 : US8 =
        match v221 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v223) -> (* Some *)
            let v224 : string = "icon"
            let v225 : JSX.Prop = JSX.Prop (v224, v223)
            US8_1(v225)
    let v228 : US0 = v94.l19
    let v234 : US8 =
        match v228 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v230) -> (* Some *)
            let v231 : string = "id"
            let v232 : JSX.Prop = JSX.Prop (v231, v230)
            US8_1(v232)
    let v235 : US0 = v94.l20
    let v241 : US8 =
        match v235 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v237) -> (* Some *)
            let v238 : string = "justifyContent"
            let v239 : JSX.Prop = JSX.Prop (v238, v237)
            US8_1(v239)
    let v242 : US0 = v94.l21
    let v247 : US8 =
        match v242 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v244) -> (* Some *)
            let v245 : JSX.Prop = JSX.Prop (v69, v244)
            US8_1(v245)
    let v248 : US0 = v94.l22
    let v254 : US8 =
        match v248 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v250) -> (* Some *)
            let v251 : string = "lineHeight"
            let v252 : JSX.Prop = JSX.Prop (v251, v250)
            US8_1(v252)
    let v255 : US0 = v94.l23
    let v261 : US8 =
        match v255 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v257) -> (* Some *)
            let v258 : string = "margin"
            let v259 : JSX.Prop = JSX.Prop (v258, v257)
            US8_1(v259)
    let v262 : US0 = v94.l24
    let v268 : US8 =
        match v262 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v264) -> (* Some *)
            let v265 : string = "marginBottom"
            let v266 : JSX.Prop = JSX.Prop (v265, v264)
            US8_1(v266)
    let v269 : US0 = v94.l25
    let v275 : US8 =
        match v269 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v271) -> (* Some *)
            let v272 : string = "maxHeight"
            let v273 : JSX.Prop = JSX.Prop (v272, v271)
            US8_1(v273)
    let v276 : US6 = v94.l26
    let v282 : US8 =
        match v276 with
        | US6_0 -> (* None *)
            US8_0
        | US6_1(v278) -> (* Some *)
            let v279 : string = "onChange"
            let v280 : JSX.Prop = JSX.Prop (v279, v278)
            US8_1(v280)
    let v283 : US7 = v94.l27
    let v289 : US8 =
        match v283 with
        | US7_0 -> (* None *)
            US8_0
        | US7_1(v285) -> (* Some *)
            let v286 : string = "onClick"
            let v287 : JSX.Prop = JSX.Prop (v286, v285)
            US8_1(v287)
    let v290 : US0 = v94.l28
    let v296 : US8 =
        match v290 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v292) -> (* Some *)
            let v293 : string = "outline"
            let v294 : JSX.Prop = JSX.Prop (v293, v292)
            US8_1(v294)
    let v297 : US0 = v94.l29
    let v303 : US8 =
        match v297 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v299) -> (* Some *)
            let v300 : string = "overflowY"
            let v301 : JSX.Prop = JSX.Prop (v300, v299)
            US8_1(v301)
    let v304 : US0 = v94.l30
    let v310 : US8 =
        match v304 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v306) -> (* Some *)
            let v307 : string = "padding"
            let v308 : JSX.Prop = JSX.Prop (v307, v306)
            US8_1(v308)
    let v311 : US0 = v94.l31
    let v317 : US8 =
        match v311 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v313) -> (* Some *)
            let v314 : string = "paddingTop"
            let v315 : JSX.Prop = JSX.Prop (v314, v313)
            US8_1(v315)
    let v318 : US0 = v94.l32
    let v324 : US8 =
        match v318 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v320) -> (* Some *)
            let v321 : string = "position"
            let v322 : JSX.Prop = JSX.Prop (v321, v320)
            US8_1(v322)
    let v325 : US0 = v94.l33
    let v331 : US8 =
        match v325 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v327) -> (* Some *)
            let v328 : string = "right"
            let v329 : JSX.Prop = JSX.Prop (v328, v327)
            US8_1(v329)
    let v332 : US0 = v94.l34
    let v338 : US8 =
        match v332 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v334) -> (* Some *)
            let v335 : string = "size"
            let v336 : JSX.Prop = JSX.Prop (v335, v334)
            US8_1(v336)
    let v339 : US0 = v94.l35
    let v345 : US8 =
        match v339 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v341) -> (* Some *)
            let v342 : string = "spacing"
            let v343 : JSX.Prop = JSX.Prop (v342, v341)
            US8_1(v343)
    let v346 : US2 = v94.l36
    let v352 : US8 =
        match v346 with
        | US2_0 -> (* None *)
            US8_0
        | US2_1(v348) -> (* Some *)
            let v349 : string = "status"
            let v350 : JSX.Prop = JSX.Prop (v349, v348)
            US8_1(v350)
    let v353 : US0 = v94.l37
    let v359 : US8 =
        match v353 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v355) -> (* Some *)
            let v356 : string = "striped"
            let v357 : JSX.Prop = JSX.Prop (v356, v355)
            US8_1(v357)
    let v360 : US0 = v94.l38
    let v366 : US8 =
        match v360 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v362) -> (* Some *)
            let v363 : string = "thickness"
            let v364 : JSX.Prop = JSX.Prop (v363, v362)
            US8_1(v364)
    let v367 : US5 = v94.l39
    let v373 : US8 =
        match v367 with
        | US5_0 -> (* None *)
            US8_0
        | US5_1(v369) -> (* Some *)
            let v370 : string = "title"
            let v371 : JSX.Prop = JSX.Prop (v370, v369)
            US8_1(v371)
    let v374 : US0 = v94.l40
    let v380 : US8 =
        match v374 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v376) -> (* Some *)
            let v377 : string = "top"
            let v378 : JSX.Prop = JSX.Prop (v377, v376)
            US8_1(v378)
    let v381 : US0 = v94.l41
    let v387 : US8 =
        match v381 with
        | US0_0 -> (* None *)
            US8_0
        | US0_1(v383) -> (* Some *)
            let v384 : string = "width"
            let v385 : JSX.Prop = JSX.Prop (v384, v383)
            US8_1(v385)
    let v388 : US4 = v94.l42
    let v394 : US8 =
        match v388 with
        | US4_0 -> (* None *)
            US8_0
        | US4_1(v390) -> (* Some *)
            let v391 : string = "zIndex"
            let v392 : JSX.Prop = JSX.Prop (v391, v390)
            US8_1(v392)
    let v395 : (US8 []) = [|v101; v108; v115; v122; v129; v136; v143; v150; v157; v164; v171; v178; v185; v192; v199; v206; v213; v220; v227; v234; v241; v247; v254; v261; v268; v275; v282; v289; v296; v303; v310; v317; v324; v331; v338; v345; v352; v359; v366; v373; v380; v387; v394|]
    let v396 : int32 = v395.Length
    let v397 : (US8 []) = Array.zeroCreate<US8> (v396)
    let v398 : Mut0 = {l0 = 0; l1 = 0} : Mut0
    while method0(v396, v398) do
        let v400 : int32 = v398.l0
        let v401 : int32 = v398.l1
        let v402 : US8 = v395.[int v400]
        let v404 : bool =
            match v402 with
            | US8_0 -> (* None *)
                false
            | US8_1(v403) -> (* Some *)
                true
        let v406 : int32 =
            if v404 then
                v397.[int v401] <- v402
                let v405 : int32 = v401 + 1
                v405
            else
                v401
        let v407 : int32 = v400 + 1
        v398.l0 <- v407
        v398.l1 <- v406
        ()
    let v408 : int32 = v398.l1
    let v409 : (US8 []) = Array.zeroCreate<US8> (v408)
    let v410 : Mut1 = {l0 = 0} : Mut1
    while method1(v408, v410) do
        let v412 : int32 = v410.l0
        let v413 : US8 = v397.[int v412]
        v409.[int v412] <- v413
        let v414 : int32 = v412 + 1
        v410.l0 <- v414
        ()
    let v415 : int32 = v409.Length
    let v416 : (JSX.Prop []) = Array.zeroCreate<JSX.Prop> (v415)
    let v417 : Mut1 = {l0 = 0} : Mut1
    while method1(v415, v417) do
        let v419 : int32 = v417.l0
        let v420 : US8 = v409.[int v419]
        let v423 : JSX.Prop =
            match v420 with
            | US8_0 -> (* None *)
                failwith<JSX.Prop> "Option does not have a value."
            | US8_1(v422) -> (* Some *)
                v422
        v416.[int v419] <- v423
        let v424 : int32 = v419 + 1
        v417.l0 <- v424
        ()
    let v425 : obj = createObj v416
    let v426 : string = "createComponent"
    let v427 : string = "solid-js"
    let v428 : JS.Function = import v426 v427
    let v429 : string = "Button"
    let v430 : string = "@hope-ui/solid"
    let v431 : JSX.Element = v428.Invoke ((import v429 v430), v425) |> unbox<JSX.Element>
    let v432 : (JSX.Element []) = [|v431|]
    let v433 : JSX.Element = v432 |> unbox<JSX.Element>
    v433
and closure38 (v0 : Heap0, v1 : int32, v2 : (bool -> unit), v3 : (unit -> bool), v4 : (bool -> unit), v5 : (unit -> bool), v6 : (bool -> unit), v7 : (unit -> bool), v8 : US7) () : JSX.Element =
    let v9 : bool = v3 ()
    let v10 : bool = v9 = false
    let v141 : JSX.Element =
        if v10 then
            let v11 : US0 = US0_0
            let v12 : US1 = US1_0
            let v13 : US0 = US0_0
            let v14 : US0 = US0_0
            let v15 : US0 = US0_0
            let v16 : US2 = US2_0
            let v17 : (unit -> JSX.Element) = closure39(v8, v2)
            let v18 : US3 = US3_1(v17)
            let v19 : US0 = US0_0
            let v20 : US0 = US0_0
            let v21 : US2 = US2_0
            let v22 : US0 = US0_0
            let v23 : US0 = US0_0
            let v24 : US2 = US2_0
            let v25 : US4 = US4_0
            let v26 : US0 = US0_0
            let v27 : US0 = US0_0
            let v28 : US0 = US0_0
            let v29 : US0 = US0_0
            let v30 : US5 = US5_0
            let v31 : US0 = US0_0
            let v32 : US0 = US0_0
            let v33 : US0 = US0_0
            let v34 : US0 = US0_0
            let v35 : US0 = US0_0
            let v36 : US0 = US0_0
            let v37 : US0 = US0_0
            let v38 : US6 = US6_0
            let v39 : US7 = US7_0
            let v40 : US0 = US0_0
            let v41 : US0 = US0_0
            let v42 : US0 = US0_0
            let v43 : US0 = US0_0
            let v44 : US0 = US0_0
            let v45 : US0 = US0_0
            let v46 : US0 = US0_0
            let v47 : US0 = US0_0
            let v48 : US2 = US2_0
            let v49 : US0 = US0_0
            let v50 : US0 = US0_0
            let v51 : US5 = US5_0
            let v52 : US0 = US0_0
            let v53 : US0 = US0_0
            let v54 : US4 = US4_0
            let v55 : Heap0 = {l0 = v11; l1 = v12; l2 = v13; l3 = v14; l4 = v15; l5 = v16; l6 = v18; l7 = v19; l8 = v20; l9 = v21; l10 = v22; l11 = v23; l12 = v24; l13 = v25; l14 = v26; l15 = v27; l16 = v28; l17 = v29; l18 = v30; l19 = v31; l20 = v32; l21 = v33; l22 = v34; l23 = v35; l24 = v36; l25 = v37; l26 = v38; l27 = v39; l28 = v40; l29 = v41; l30 = v42; l31 = v43; l32 = v44; l33 = v45; l34 = v46; l35 = v47; l36 = v48; l37 = v49; l38 = v50; l39 = v51; l40 = v52; l41 = v53; l42 = v54} : Heap0
            let v56 : (Heap0 -> JSX.Element) = closure25()
            let v57 : JS.Function = v56 |> unbox<JS.Function>
            let v58 : string = "createComponent"
            let v59 : string = "solid-js"
            let v60 : JS.Function = import v58 v59
            let v61 : JSX.Element = v60.Invoke (v57, v55) |> unbox<JSX.Element>
            v61
        else
            let v62 : bool = v7 ()
            let v65 : US4 =
                if v62 then
                    US4_1(1)
                else
                    US4_0
            let v66 : bool = v7 ()
            let v70 : US0 =
                if v66 then
                    let v67 : string = "absolute"
                    US0_1(v67)
                else
                    US0_0
            let v71 : bool = v7 ()
            let v75 : US0 =
                if v71 then
                    let v72 : string = "0"
                    US0_1(v72)
                else
                    US0_0
            let v76 : bool = v7 ()
            let v80 : US0 =
                if v76 then
                    let v77 : string = "0"
                    US0_1(v77)
                else
                    US0_0
            let v81 : bool = v7 ()
            let v85 : US0 =
                if v81 then
                    let v82 : string = "0"
                    US0_1(v82)
                else
                    US0_0
            let v86 : bool = v7 ()
            let v90 : US0 =
                if v86 then
                    let v87 : string = "0"
                    US0_1(v87)
                else
                    US0_0
            let v91 : bool = v7 ()
            let v95 : US0 =
                if v91 then
                    let v92 : string = "$bg"
                    US0_1(v92)
                else
                    US0_0
            let v96 : US0 = US0_0
            let v97 : US1 = US1_0
            let v98 : US0 = US0_0
            let v99 : US2 = US2_0
            let v100 : (unit -> JSX.Element) = closure26(v0, v1, v2, v4, v5, v6, v7)
            let v101 : US3 = US3_1(v100)
            let v102 : US0 = US0_0
            let v103 : US0 = US0_0
            let v104 : US2 = US2_0
            let v105 : US0 = US0_0
            let v106 : string = "flex"
            let v107 : US0 = US0_1(v106)
            let v108 : US2 = US2_0
            let v109 : US4 = US4_1(1)
            let v110 : US0 = US0_0
            let v111 : US0 = US0_0
            let v112 : US0 = US0_0
            let v113 : US0 = US0_0
            let v114 : US5 = US5_0
            let v115 : US0 = US0_0
            let v116 : US0 = US0_0
            let v117 : US0 = US0_0
            let v118 : US0 = US0_0
            let v119 : US0 = US0_0
            let v120 : US0 = US0_0
            let v121 : US6 = US6_0
            let v122 : US7 = US7_0
            let v123 : US0 = US0_0
            let v124 : US0 = US0_0
            let v125 : US0 = US0_0
            let v126 : US0 = US0_0
            let v127 : US0 = US0_0
            let v128 : US0 = US0_0
            let v129 : US2 = US2_0
            let v130 : US0 = US0_0
            let v131 : US0 = US0_0
            let v132 : US5 = US5_0
            let v133 : US0 = US0_0
            let v134 : Heap0 = {l0 = v96; l1 = v97; l2 = v95; l3 = v98; l4 = v85; l5 = v99; l6 = v101; l7 = v102; l8 = v103; l9 = v104; l10 = v105; l11 = v107; l12 = v108; l13 = v109; l14 = v110; l15 = v111; l16 = v112; l17 = v113; l18 = v114; l19 = v115; l20 = v116; l21 = v90; l22 = v117; l23 = v118; l24 = v119; l25 = v120; l26 = v121; l27 = v122; l28 = v123; l29 = v124; l30 = v125; l31 = v126; l32 = v70; l33 = v80; l34 = v127; l35 = v128; l36 = v129; l37 = v130; l38 = v131; l39 = v132; l40 = v75; l41 = v133; l42 = v65} : Heap0
            let v135 : (Heap0 -> JSX.Element) = closure25()
            let v136 : JS.Function = v135 |> unbox<JS.Function>
            let v137 : string = "createComponent"
            let v138 : string = "solid-js"
            let v139 : JS.Function = import v137 v138
            let v140 : JSX.Element = v139.Invoke (v136, v134) |> unbox<JSX.Element>
            v140
    let v142 : (JSX.Element []) = [|v141|]
    let v143 : JSX.Element = v142 |> unbox<JSX.Element>
    v143
and closure37 (v0 : Heap0) struct (v1 : bool, v2 : bool, v3 : US7) : JSX.Element =
    let v4 : int32 = Random().Next()
    let v5 : string = "createSignal"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (JS.Function []) = v7.Invoke v1 |> unbox<JS.Function[]>
    let v9 : (unit -> bool) = v8.[0] |> unbox
    let v10 : (bool -> unit) = v8.[1] |> unbox
    let v11 : JS.Function = import v5 v6
    let v12 : (JS.Function []) = v11.Invoke false |> unbox<JS.Function[]>
    let v13 : (unit -> bool) = v12.[0] |> unbox
    let v14 : (bool -> unit) = v12.[1] |> unbox
    let v15 : JS.Function = import v5 v6
    let v16 : (JS.Function []) = v15.Invoke v2 |> unbox<JS.Function[]>
    let v17 : (unit -> bool) = v16.[0] |> unbox
    let v18 : (bool -> unit) = v16.[1] |> unbox
    let v19 : string = "on"
    let v20 : JS.Function = import v19 v6
    let v21 : (unit -> (bool [])) = closure19(v13)
    let v22 : (unit -> unit) = closure20(v14, v13)
    let v23 : JS.Function = v20.Invoke (v21, v22) |> unbox<JS.Function>
    let v24 : string = "createEffect"
    let v25 : JS.Function = import v24 v6
    v25.Invoke v23 |> ignore
    match v3 with
    | US7_0 -> (* None *)
        ()
    | US7_1(v26) -> (* Some *)
        v26 ()
        ()
    let v27 : US0 = v0.l19
    let v28 : US0 = US0_0
    let v29 : US1 = US1_0
    let v30 : US0 = US0_0
    let v31 : US0 = US0_0
    let v32 : US0 = US0_0
    let v33 : US2 = US2_0
    let v34 : (unit -> JSX.Element) = closure38(v0, v4, v10, v9, v14, v13, v18, v17, v3)
    let v35 : US3 = US3_1(v34)
    let v36 : US0 = US0_0
    let v37 : US0 = US0_0
    let v38 : US2 = US2_0
    let v39 : US0 = US0_0
    let v40 : string = "flex"
    let v41 : US0 = US0_1(v40)
    let v42 : US2 = US2_0
    let v43 : US4 = US4_1(1)
    let v44 : US0 = US0_0
    let v45 : US0 = US0_0
    let v46 : US0 = US0_0
    let v47 : US0 = US0_0
    let v48 : US5 = US5_0
    let v49 : US0 = US0_0
    let v50 : US0 = US0_0
    let v51 : US0 = US0_0
    let v52 : US0 = US0_0
    let v53 : US0 = US0_0
    let v54 : US0 = US0_0
    let v55 : US6 = US6_0
    let v56 : US7 = US7_0
    let v57 : US0 = US0_0
    let v58 : US0 = US0_0
    let v59 : US0 = US0_0
    let v60 : US0 = US0_0
    let v61 : US0 = US0_0
    let v62 : US0 = US0_0
    let v63 : US0 = US0_0
    let v64 : US0 = US0_0
    let v65 : US2 = US2_0
    let v66 : US0 = US0_0
    let v67 : US0 = US0_0
    let v68 : US5 = US5_0
    let v69 : US0 = US0_0
    let v70 : US0 = US0_0
    let v71 : US4 = US4_0
    let v72 : Heap0 = {l0 = v28; l1 = v29; l2 = v30; l3 = v31; l4 = v32; l5 = v33; l6 = v35; l7 = v36; l8 = v37; l9 = v38; l10 = v39; l11 = v41; l12 = v42; l13 = v43; l14 = v44; l15 = v45; l16 = v46; l17 = v47; l18 = v48; l19 = v27; l20 = v49; l21 = v50; l22 = v51; l23 = v52; l24 = v53; l25 = v54; l26 = v55; l27 = v56; l28 = v57; l29 = v58; l30 = v59; l31 = v60; l32 = v61; l33 = v62; l34 = v63; l35 = v64; l36 = v65; l37 = v66; l38 = v67; l39 = v68; l40 = v69; l41 = v70; l42 = v71} : Heap0
    let v73 : (Heap0 -> JSX.Element) = closure25()
    let v74 : JS.Function = v73 |> unbox<JS.Function>
    let v75 : string = "createComponent"
    let v76 : JS.Function = import v75 v6
    let v77 : JSX.Element = v76.Invoke (v74, v72) |> unbox<JSX.Element>
    v77
and closure36 () (v0 : Heap0) : (struct (bool * bool * US7) -> JSX.Element) =
    closure37(v0)
and closure44 (v0 : US7, v1 : Heap0, v2 : (unit -> bool), v3 : (unit -> JSX.Element)) () : JSX.Element =
    let v4 : US2 = v1.l36
    let v129 : JSX.Element =
        match v4 with
        | US2_0 -> (* None *)
            let v5 : JSX.Element = v3 ()
            v5
        | US2_1(v6) -> (* Some *)
            let v7 : bool = v2 ()
            if v7 then
                let v8 : US0 = US0_0
                let v9 : US1 = US1_0
                let v10 : US0 = US0_0
                let v11 : US0 = US0_0
                let v12 : US0 = US0_0
                let v13 : US2 = US2_0
                let v14 : (unit -> JSX.Element) = closure18(v3)
                let v15 : US3 = US3_1(v14)
                let v16 : US0 = US0_0
                let v17 : US0 = US0_0
                let v18 : US2 = US2_0
                let v19 : US0 = US0_0
                let v20 : US0 = US0_0
                let v21 : US2 = US2_0
                let v22 : US4 = US4_0
                let v23 : US0 = US0_0
                let v24 : US0 = US0_0
                let v25 : US0 = US0_0
                let v26 : US0 = US0_0
                let v27 : US5 = US5_0
                let v28 : US0 = US0_0
                let v29 : US0 = US0_0
                let v30 : US0 = US0_0
                let v31 : US0 = US0_0
                let v32 : US0 = US0_0
                let v33 : US0 = US0_0
                let v34 : US0 = US0_0
                let v35 : US6 = US6_0
                let v36 : US7 = US7_0
                let v37 : US0 = US0_0
                let v38 : US0 = US0_0
                let v39 : US0 = US0_0
                let v40 : US0 = US0_0
                let v41 : US0 = US0_0
                let v42 : US0 = US0_0
                let v43 : US0 = US0_0
                let v44 : US0 = US0_0
                let v45 : US2 = US2_0
                let v46 : US0 = US0_0
                let v47 : US0 = US0_0
                let v48 : US5 = US5_0
                let v49 : US0 = US0_0
                let v50 : US0 = US0_0
                let v51 : US4 = US4_0
                let v52 : Heap0 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v15; l7 = v16; l8 = v17; l9 = v18; l10 = v19; l11 = v20; l12 = v21; l13 = v22; l14 = v23; l15 = v24; l16 = v25; l17 = v26; l18 = v27; l19 = v28; l20 = v29; l21 = v30; l22 = v31; l23 = v32; l24 = v33; l25 = v34; l26 = v35; l27 = v36; l28 = v37; l29 = v38; l30 = v39; l31 = v40; l32 = v41; l33 = v42; l34 = v43; l35 = v44; l36 = v45; l37 = v46; l38 = v47; l39 = v48; l40 = v49; l41 = v50; l42 = v51} : Heap0
                let v53 : int32 = Random().Next()
                let v54 : string = "createSignal"
                let v55 : string = "solid-js"
                let v56 : JS.Function = import v54 v55
                let v57 : (JS.Function []) = v56.Invoke true |> unbox<JS.Function[]>
                let v58 : (unit -> bool) = v57.[0] |> unbox
                let v59 : (bool -> unit) = v57.[1] |> unbox
                let v60 : JS.Function = import v54 v55
                let v61 : (JS.Function []) = v60.Invoke false |> unbox<JS.Function[]>
                let v62 : (unit -> bool) = v61.[0] |> unbox
                let v63 : (bool -> unit) = v61.[1] |> unbox
                let v64 : JS.Function = import v54 v55
                let v65 : (JS.Function []) = v64.Invoke false |> unbox<JS.Function[]>
                let v66 : (unit -> bool) = v65.[0] |> unbox
                let v67 : (bool -> unit) = v65.[1] |> unbox
                let v68 : string = "on"
                let v69 : JS.Function = import v68 v55
                let v70 : (unit -> (bool [])) = closure19(v62)
                let v71 : (unit -> unit) = closure20(v63, v62)
                let v72 : JS.Function = v69.Invoke (v70, v71) |> unbox<JS.Function>
                let v73 : string = "createEffect"
                let v74 : JS.Function = import v73 v55
                v74.Invoke v72 |> ignore
                match v0 with
                | US7_0 -> (* None *)
                    ()
                | US7_1(v75) -> (* Some *)
                    v75 ()
                    ()
                let v76 : US0 = v52.l19
                let v77 : US0 = US0_0
                let v78 : US1 = US1_0
                let v79 : US0 = US0_0
                let v80 : US0 = US0_0
                let v81 : US0 = US0_0
                let v82 : US2 = US2_0
                let v83 : (unit -> JSX.Element) = closure38(v52, v53, v59, v58, v63, v62, v67, v66, v0)
                let v84 : US3 = US3_1(v83)
                let v85 : US0 = US0_0
                let v86 : US0 = US0_0
                let v87 : US2 = US2_0
                let v88 : US0 = US0_0
                let v89 : string = "flex"
                let v90 : US0 = US0_1(v89)
                let v91 : US2 = US2_0
                let v92 : US4 = US4_1(1)
                let v93 : US0 = US0_0
                let v94 : US0 = US0_0
                let v95 : US0 = US0_0
                let v96 : US0 = US0_0
                let v97 : US5 = US5_0
                let v98 : US0 = US0_0
                let v99 : US0 = US0_0
                let v100 : US0 = US0_0
                let v101 : US0 = US0_0
                let v102 : US0 = US0_0
                let v103 : US0 = US0_0
                let v104 : US6 = US6_0
                let v105 : US7 = US7_0
                let v106 : US0 = US0_0
                let v107 : US0 = US0_0
                let v108 : US0 = US0_0
                let v109 : US0 = US0_0
                let v110 : US0 = US0_0
                let v111 : US0 = US0_0
                let v112 : US0 = US0_0
                let v113 : US0 = US0_0
                let v114 : US2 = US2_0
                let v115 : US0 = US0_0
                let v116 : US0 = US0_0
                let v117 : US5 = US5_0
                let v118 : US0 = US0_0
                let v119 : US0 = US0_0
                let v120 : US4 = US4_0
                let v121 : Heap0 = {l0 = v77; l1 = v78; l2 = v79; l3 = v80; l4 = v81; l5 = v82; l6 = v84; l7 = v85; l8 = v86; l9 = v87; l10 = v88; l11 = v90; l12 = v91; l13 = v92; l14 = v93; l15 = v94; l16 = v95; l17 = v96; l18 = v97; l19 = v76; l20 = v98; l21 = v99; l22 = v100; l23 = v101; l24 = v102; l25 = v103; l26 = v104; l27 = v105; l28 = v106; l29 = v107; l30 = v108; l31 = v109; l32 = v110; l33 = v111; l34 = v112; l35 = v113; l36 = v114; l37 = v115; l38 = v116; l39 = v117; l40 = v118; l41 = v119; l42 = v120} : Heap0
                let v122 : (Heap0 -> JSX.Element) = closure25()
                let v123 : JS.Function = v122 |> unbox<JS.Function>
                let v124 : string = "createComponent"
                let v125 : JS.Function = import v124 v55
                let v126 : JSX.Element = v125.Invoke (v123, v121) |> unbox<JSX.Element>
                v126
            else
                let v127 : JSX.Element = Html.fragment []
                v127
    let v130 : (JSX.Element []) = [|v129|]
    let v131 : JSX.Element = v130 |> unbox<JSX.Element>
    v131
and closure43 (v0 : US7, v1 : Heap0, v2 : (bool -> unit), v3 : (unit -> bool)) () : JSX.Element =
    let v4 : US5 = v1.l39
    let v65 : JSX.Element =
        match v4 with
        | US5_0 -> (* None *)
            let v5 : JSX.Element = Html.fragment []
            v5
        | US5_1(v6) -> (* Some *)
            let v7 : US0 = US0_0
            let v8 : US1 = US1_0
            let v9 : US0 = US0_0
            let v10 : string = "0 !important"
            let v11 : US0 = US0_1(v10)
            let v12 : US0 = US0_0
            let v13 : US2 = US2_0
            let v14 : (unit -> JSX.Element) = closure11(v1, v2, v3, v6)
            let v15 : US3 = US3_1(v14)
            let v16 : string = "$neutral9"
            let v17 : US0 = US0_1(v16)
            let v18 : US0 = US0_0
            let v19 : US2 = US2_0
            let v20 : US0 = US0_0
            let v21 : string = "flex"
            let v22 : US0 = US0_1(v21)
            let v23 : US2 = US2_0
            let v24 : US4 = US4_0
            let v25 : string = "column"
            let v26 : US0 = US0_1(v25)
            let v27 : string = "$sm"
            let v28 : US0 = US0_1(v27)
            let v29 : US0 = US0_0
            let v30 : US0 = US0_0
            let v31 : US5 = US5_0
            let v32 : US0 = US0_0
            let v33 : US0 = US0_0
            let v34 : US0 = US0_0
            let v35 : US0 = US0_0
            let v36 : US0 = US0_0
            let v37 : US0 = US0_0
            let v38 : US0 = US0_0
            let v39 : US6 = US6_0
            let v40 : US7 = US7_0
            let v41 : string = "1px solid $neutral5"
            let v42 : US0 = US0_1(v41)
            let v43 : US0 = US0_0
            let v44 : string = "3px 20px 0 8px"
            let v45 : US0 = US0_1(v44)
            let v46 : US0 = US0_0
            let v47 : US0 = US0_0
            let v48 : US0 = US0_0
            let v49 : US0 = US0_0
            let v50 : US0 = US0_0
            let v51 : US2 = US2_0
            let v52 : US0 = US0_0
            let v53 : US0 = US0_0
            let v54 : US5 = US5_0
            let v55 : US0 = US0_0
            let v56 : US0 = US0_0
            let v57 : US4 = US4_0
            let v58 : Heap0 = {l0 = v7; l1 = v8; l2 = v9; l3 = v11; l4 = v12; l5 = v13; l6 = v15; l7 = v17; l8 = v18; l9 = v19; l10 = v20; l11 = v22; l12 = v23; l13 = v24; l14 = v26; l15 = v28; l16 = v29; l17 = v30; l18 = v31; l19 = v32; l20 = v33; l21 = v34; l22 = v35; l23 = v36; l24 = v37; l25 = v38; l26 = v39; l27 = v40; l28 = v42; l29 = v43; l30 = v45; l31 = v46; l32 = v47; l33 = v48; l34 = v49; l35 = v50; l36 = v51; l37 = v52; l38 = v53; l39 = v54; l40 = v55; l41 = v56; l42 = v57} : Heap0
            let v59 : (Heap0 -> JSX.Element) = closure15()
            let v60 : JS.Function = v59 |> unbox<JS.Function>
            let v61 : string = "createComponent"
            let v62 : string = "solid-js"
            let v63 : JS.Function = import v61 v62
            let v64 : JSX.Element = v63.Invoke (v60, v58) |> unbox<JSX.Element>
            v64
    let v66 : US3 = v1.l6
    let v183 : JSX.Element =
        match v66 with
        | US3_0 -> (* None *)
            let v67 : US0 = US0_0
            let v68 : US1 = US1_0
            let v69 : US0 = US0_0
            let v70 : US0 = US0_0
            let v71 : US0 = US0_0
            let v72 : US2 = US2_0
            let v73 : (unit -> JSX.Element) = closure16()
            let v74 : US3 = US3_1(v73)
            let v75 : US0 = US0_0
            let v76 : US0 = US0_0
            let v77 : US2 = US2_0
            let v78 : US0 = US0_0
            let v79 : US0 = US0_0
            let v80 : US2 = US2_0
            let v81 : US4 = US4_0
            let v82 : US0 = US0_0
            let v83 : US0 = US0_0
            let v84 : US0 = US0_0
            let v85 : US0 = US0_0
            let v86 : US5 = US5_0
            let v87 : US0 = US0_0
            let v88 : US0 = US0_0
            let v89 : US0 = US0_0
            let v90 : string = "9px"
            let v91 : US0 = US0_1(v90)
            let v92 : US0 = US0_0
            let v93 : US0 = US0_0
            let v94 : US0 = US0_0
            let v95 : US6 = US6_0
            let v96 : US7 = US7_0
            let v97 : US0 = US0_0
            let v98 : US0 = US0_0
            let v99 : string = "0"
            let v100 : US0 = US0_1(v99)
            let v101 : US0 = US0_0
            let v102 : US0 = US0_0
            let v103 : US0 = US0_0
            let v104 : US0 = US0_0
            let v105 : US0 = US0_0
            let v106 : US2 = US2_0
            let v107 : US0 = US0_0
            let v108 : US0 = US0_0
            let v109 : US5 = US5_0
            let v110 : US0 = US0_0
            let v111 : US0 = US0_0
            let v112 : US4 = US4_0
            let v113 : Heap0 = {l0 = v67; l1 = v68; l2 = v69; l3 = v70; l4 = v71; l5 = v72; l6 = v74; l7 = v75; l8 = v76; l9 = v77; l10 = v78; l11 = v79; l12 = v80; l13 = v81; l14 = v82; l15 = v83; l16 = v84; l17 = v85; l18 = v86; l19 = v87; l20 = v88; l21 = v89; l22 = v91; l23 = v92; l24 = v93; l25 = v94; l26 = v95; l27 = v96; l28 = v97; l29 = v98; l30 = v100; l31 = v101; l32 = v102; l33 = v103; l34 = v104; l35 = v105; l36 = v106; l37 = v107; l38 = v108; l39 = v109; l40 = v110; l41 = v111; l42 = v112} : Heap0
            let v114 : (Heap0 -> JSX.Element) = closure15()
            let v115 : JS.Function = v114 |> unbox<JS.Function>
            let v116 : string = "createComponent"
            let v117 : string = "solid-js"
            let v118 : JS.Function = import v116 v117
            let v119 : JSX.Element = v118.Invoke (v115, v113) |> unbox<JSX.Element>
            v119
        | US3_1(v120) -> (* Some *)
            let v121 : US0 = v1.l30
            let v124 : string =
                match v121 with
                | US0_0 -> (* None *)
                    let v122 : string = "0"
                    v122
                | US0_1(v123) -> (* Some *)
                    v123
            let v125 : US0 = US0_0
            let v126 : US1 = US1_0
            let v127 : US0 = US0_0
            let v128 : string = "0 !important"
            let v129 : US0 = US0_1(v128)
            let v130 : US0 = US0_0
            let v131 : US2 = US2_0
            let v132 : (unit -> JSX.Element) = closure44(v0, v1, v3, v120)
            let v133 : US3 = US3_1(v132)
            let v134 : US0 = US0_0
            let v135 : US0 = US0_0
            let v136 : US2 = US2_0
            let v137 : US0 = US0_0
            let v138 : string = "flex"
            let v139 : US0 = US0_1(v138)
            let v140 : US2 = US2_0
            let v141 : US4 = US4_1(6)
            let v142 : string = "column"
            let v143 : US0 = US0_1(v142)
            let v144 : string = "$sm"
            let v145 : US0 = US0_1(v144)
            let v146 : US0 = US0_0
            let v147 : US0 = US0_0
            let v148 : US5 = US5_0
            let v149 : US0 = US0_0
            let v150 : US0 = US0_0
            let v151 : US0 = US0_0
            let v152 : US0 = US0_0
            let v153 : string = "0"
            let v154 : US0 = US0_1(v153)
            let v155 : US0 = US0_0
            let v156 : string = "85vh"
            let v157 : US0 = US0_1(v156)
            let v158 : US6 = US6_0
            let v159 : US7 = US7_0
            let v160 : US0 = US0_1(v153)
            let v161 : string = "auto"
            let v162 : US0 = US0_1(v161)
            let v163 : US0 = US0_1(v124)
            let v164 : US0 = US0_0
            let v165 : US0 = US0_0
            let v166 : US0 = US0_0
            let v167 : US0 = US0_0
            let v168 : US0 = US0_0
            let v169 : US2 = US2_0
            let v170 : US0 = US0_0
            let v171 : US0 = US0_0
            let v172 : US5 = US5_0
            let v173 : US0 = US0_0
            let v174 : US0 = US0_0
            let v175 : US4 = US4_0
            let v176 : Heap0 = {l0 = v125; l1 = v126; l2 = v127; l3 = v129; l4 = v130; l5 = v131; l6 = v133; l7 = v134; l8 = v135; l9 = v136; l10 = v137; l11 = v139; l12 = v140; l13 = v141; l14 = v143; l15 = v145; l16 = v146; l17 = v147; l18 = v148; l19 = v149; l20 = v150; l21 = v151; l22 = v152; l23 = v154; l24 = v155; l25 = v157; l26 = v158; l27 = v159; l28 = v160; l29 = v162; l30 = v163; l31 = v164; l32 = v165; l33 = v166; l34 = v167; l35 = v168; l36 = v169; l37 = v170; l38 = v171; l39 = v172; l40 = v173; l41 = v174; l42 = v175} : Heap0
            let v177 : (Heap0 -> JSX.Element) = closure15()
            let v178 : JS.Function = v177 |> unbox<JS.Function>
            let v179 : string = "createComponent"
            let v180 : string = "solid-js"
            let v181 : JS.Function = import v179 v180
            let v182 : JSX.Element = v181.Invoke (v178, v176) |> unbox<JSX.Element>
            v182
    let v184 : (JSX.Element []) = [|v65; v183|]
    let v185 : JSX.Element = v184 |> unbox<JSX.Element>
    v185
and closure42 (v0 : Heap0) (v1 : US7) : JSX.Element =
    let v2 : US2 = v0.l36
    let v6 : bool =
        match v2 with
        | US2_1(v4) -> (* Some *)
            let v5 : bool = v4 = false
            v5
        | _ ->
            false
    let v7 : bool = v6 <> true
    let v8 : string = "createSignal"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : (JS.Function []) = v10.Invoke v7 |> unbox<JS.Function[]>
    let v12 : (unit -> bool) = v11.[0] |> unbox
    let v13 : (bool -> unit) = v11.[1] |> unbox
    let v14 : US0 = v0.l19
    let v15 : string = {| ``@initial`` = "column"; ``@sm`` = "row" |} |> unbox<string>
    let v16 : US0 = US0_0
    let v17 : US1 = US1_0
    let v18 : US0 = US0_0
    let v19 : string = "1px solid $neutral5"
    let v20 : US0 = US0_1(v19)
    let v21 : US0 = US0_0
    let v22 : US2 = US2_0
    let v23 : (unit -> JSX.Element) = closure43(v1, v0, v13, v12)
    let v24 : US3 = US3_1(v23)
    let v25 : US0 = US0_0
    let v26 : US0 = US0_0
    let v27 : US2 = US2_0
    let v28 : US0 = US0_0
    let v29 : string = "flex"
    let v30 : US0 = US0_1(v29)
    let v31 : US2 = US2_0
    let v32 : US4 = US4_1(1)
    let v33 : US0 = US0_1(v15)
    let v34 : US0 = US0_0
    let v35 : US0 = US0_0
    let v36 : US0 = US0_0
    let v37 : US5 = US5_0
    let v38 : US0 = US0_0
    let v39 : US0 = US0_0
    let v40 : US0 = US0_0
    let v41 : US0 = US0_0
    let v42 : US0 = US0_0
    let v43 : US0 = US0_0
    let v44 : US6 = US6_0
    let v45 : US7 = US7_0
    let v46 : US0 = US0_0
    let v47 : US0 = US0_0
    let v48 : US0 = US0_0
    let v49 : US0 = US0_0
    let v50 : US0 = US0_0
    let v51 : US0 = US0_0
    let v52 : US0 = US0_0
    let v53 : US0 = US0_0
    let v54 : US2 = US2_0
    let v55 : US0 = US0_0
    let v56 : US0 = US0_0
    let v57 : US5 = US5_0
    let v58 : US0 = US0_0
    let v59 : US0 = US0_0
    let v60 : US4 = US4_0
    let v61 : Heap0 = {l0 = v16; l1 = v17; l2 = v18; l3 = v20; l4 = v21; l5 = v22; l6 = v24; l7 = v25; l8 = v26; l9 = v27; l10 = v28; l11 = v30; l12 = v31; l13 = v32; l14 = v33; l15 = v34; l16 = v35; l17 = v36; l18 = v37; l19 = v14; l20 = v38; l21 = v39; l22 = v40; l23 = v41; l24 = v42; l25 = v43; l26 = v44; l27 = v45; l28 = v46; l29 = v47; l30 = v48; l31 = v49; l32 = v50; l33 = v51; l34 = v52; l35 = v53; l36 = v54; l37 = v55; l38 = v56; l39 = v57; l40 = v58; l41 = v59; l42 = v60} : Heap0
    let v62 : (Heap0 -> JSX.Element) = closure33()
    let v63 : JS.Function = v62 |> unbox<JS.Function>
    let v64 : string = "createComponent"
    let v65 : JS.Function = import v64 v9
    let v66 : JSX.Element = v65.Invoke (v63, v61) |> unbox<JSX.Element>
    v66
and closure41 () (v0 : Heap0) : (US7 -> JSX.Element) =
    closure42(v0)
let v0 : string = "base_button"
let v1 : (Heap0 -> JSX.Element) = closure0()
let v2 : JSX.Prop = JSX.Prop (v0, v1)
let v3 : string = "base_table"
let v4 : (Heap0 -> JSX.Element) = closure1()
let v5 : JSX.Prop = JSX.Prop (v3, v4)
let v6 : string = "external_link"
let v7 : (Heap0 -> JSX.Element) = closure5()
let v8 : JSX.Prop = JSX.Prop (v6, v7)
let v9 : string = "links"
let v10 : (unit -> JSX.Element) = closure7()
let v11 : JSX.Prop = JSX.Prop (v9, v10)
let v12 : string = "loader"
let v13 : (Heap0 -> (struct (bool * bool * US7) -> JSX.Element)) = closure36()
let v14 : JSX.Prop = JSX.Prop (v12, v13)
let v15 : string = "row"
let v16 : (Heap0 -> (US7 -> JSX.Element)) = closure41()
let v17 : JSX.Prop = JSX.Prop (v15, v16)
let v18 : (JSX.Prop []) = [|v2; v5; v8; v11; v14; v17|]
let v19 : obj = createObj v18
()
