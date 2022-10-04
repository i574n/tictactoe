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
    | US1_0 of f0_0 : string
    | US1_1 of f1_0 : JS.Function
    | US1_2 of f2_0 : string
    | US1_3 of f3_0 : string
    | US1_4 of f4_0 : string
    | US1_5 of f5_0 : string
    | US1_6 of f6_0 : string
    | US1_7 of f7_0 : string
    | US1_8 of f8_0 : bool
    | US1_9 of f9_0 : (unit -> (JSX.Element []))
    | US1_10 of f10_0 : string
    | US1_11 of f11_0 : string
    | US1_12 of f12_0 : bool
    | US1_13 of f13_0 : string
    | US1_14 of f14_0 : string
    | US1_15 of f15_0 : bool
    | US1_16 of f16_0 : string
    | US1_17 of f17_0 : string
    | US1_18 of f18_0 : string
    | US1_19 of f19_0 : string
    | US1_20 of f20_0 : string
    | US1_21 of f21_0 : JSX.Element
    | US1_22 of f22_0 : string
    | US1_23 of f23_0 : string
    | US1_24 of f24_0 : string
    | US1_25 of f25_0 : obj
    | US1_26 of f26_0 : string
    | US1_27 of f27_0 : bool
    | US1_28 of f28_0 : string
    | US1_29 of f29_0 : string
    | US1_30 of f30_0 : string
    | US1_31 of f31_0 : string
    | US1_32 of f32_0 : bool
    | US1_33 of f33_0 : (obj -> unit)
    | US1_34 of f34_0 : (unit -> unit)
    | US1_35 of f35_0 : (obj -> ((obj -> unit) -> unit))
    | US1_36 of f36_0 : string
    | US1_37 of f37_0 : string
    | US1_38 of f38_0 : string
    | US1_39 of f39_0 : string
    | US1_40 of f40_0 : string
    | US1_41 of f41_0 : string
    | US1_42 of f42_0 : string
    | US1_43 of f43_0 : string
    | US1_44 of f44_0 : string
    | US1_45 of f45_0 : string
    | US1_46 of f46_0 : string
    | US1_47 of f47_0 : string
    | US1_48 of f48_0 : bool
    | US1_49 of f49_0 : string
    | US1_50 of f50_0 : string
    | US1_51 of f51_0 : JSX.Element
    | US1_52 of f52_0 : string
    | US1_53 of f53_0 : string
    | US1_54 of f54_0 : int32
and UH0 =
    | UH0_0 of US1 * UH0
    | UH0_1
and UH1 =
    | UH1_0 of (string * obj) * UH1
    | UH1_1
and [<Struct>] US2 =
    | US2_0
    | US2_1 of f1_0 : string
and [<Struct>] US3 =
    | US3_0
    | US3_1 of f1_0 : (unit -> (JSX.Element []))
and Mut1 = {mutable l0 : int32; mutable l1 : UH0}
and [<Struct>] US4 =
    | US4_0
    | US4_1 of f1_0 : bool
and [<Struct>] US5 =
    | US5_0
    | US5_1 of f1_0 : JSX.Element
and [<Struct>] US6 =
    | US6_0
    | US6_1 of f1_0 : (obj -> ((obj -> unit) -> unit))
and [<Struct>] US7 =
    | US7_0
    | US7_1 of f1_0 : (string * obj)
and Mut2 = {mutable l0 : int32; mutable l1 : int32}
and Mut3 = {mutable l0 : int32}
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
and method3 (v0 : UH0, v1 : UH0) : UH0 =
    match v0 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : UH0 = method3(v3, v1)
        UH0_0(v2, v4)
    | UH0_1 -> (* Nil *)
        v1
and method4 (v0 : UH0, v1 : UH1) : UH1 =
    match v0 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : UH1 = method4(v3, v1)
        let v225 : (string * obj) =
            match v2 with
            | US1_0(v5) -> (* AriaLabel *)
                let v6 : obj = v5
                let v7 : string = "aria-label"
                let v8 : (string * obj) = v7, v6
                v8
            | US1_1(v9) -> (* As *)
                let v10 : obj = v9
                let v11 : string = "as"
                let v12 : (string * obj) = v11, v10
                v12
            | US1_2(v13) -> (* BackgroundColor *)
                let v14 : obj = v13
                let v15 : string = "backgroundColor"
                let v16 : (string * obj) = v15, v14
                v16
            | US1_3(v17) -> (* Border *)
                let v18 : obj = v17
                let v19 : string = "border"
                let v20 : (string * obj) = v19, v18
                v20
            | US1_4(v21) -> (* BorderBottomWidth *)
                let v22 : obj = v21
                let v23 : string = "borderBottomWidth"
                let v24 : (string * obj) = v23, v22
                v24
            | US1_5(v25) -> (* BorderColor *)
                let v26 : obj = v25
                let v27 : string = "borderColor"
                let v28 : (string * obj) = v27, v26
                v28
            | US1_6(v29) -> (* BorderWidth *)
                let v30 : obj = v29
                let v31 : string = "borderWidth"
                let v32 : (string * obj) = v31, v30
                v32
            | US1_7(v33) -> (* Bottom *)
                let v34 : obj = v33
                let v35 : string = "bottom"
                let v36 : (string * obj) = v35, v34
                v36
            | US1_8(v37) -> (* Checked *)
                let v38 : obj = v37
                let v39 : string = "checked"
                let v40 : (string * obj) = v39, v38
                v40
            | US1_9(v41) -> (* Children *)
                let v42 : obj = v41
                let v43 : string = "children"
                let v44 : (string * obj) = v43, v42
                v44
            | US1_10(v45) -> (* Color *)
                let v46 : obj = v45
                let v47 : string = "color"
                let v48 : (string * obj) = v47, v46
                v48
            | US1_11(v49) -> (* ColorScheme *)
                let v50 : obj = v49
                let v51 : string = "colorScheme"
                let v52 : (string * obj) = v51, v50
                v52
            | US1_12(v53) -> (* Compact *)
                let v54 : obj = v53
                let v55 : string = "compact"
                let v56 : (string * obj) = v55, v54
                v56
            | US1_13(v57) -> (* Direction *)
                let v58 : obj = v57
                let v59 : string = "direction"
                let v60 : (string * obj) = v59, v58
                v60
            | US1_14(v61) -> (* Display *)
                let v62 : obj = v61
                let v63 : string = "display"
                let v64 : (string * obj) = v63, v62
                v64
            | US1_15(v65) -> (* External *)
                let v66 : obj = v65
                let v67 : string = "external"
                let v68 : (string * obj) = v67, v66
                v68
            | US1_16(v69) -> (* Flex *)
                let v70 : obj = v69
                let v71 : string = "flex"
                let v72 : (string * obj) = v71, v70
                v72
            | US1_17(v73) -> (* FlexDirection *)
                let v74 : obj = v73
                let v75 : string = "flexDirection"
                let v76 : (string * obj) = v75, v74
                v76
            | US1_18(v77) -> (* FontSize *)
                let v78 : obj = v77
                let v79 : string = "fontSize"
                let v80 : (string * obj) = v79, v78
                v80
            | US1_19(v81) -> (* Height *)
                let v82 : obj = v81
                let v83 : string = "height"
                let v84 : (string * obj) = v83, v82
                v84
            | US1_20(v85) -> (* Href *)
                let v86 : obj = v85
                let v87 : string = "href"
                let v88 : (string * obj) = v87, v86
                v88
            | US1_21(v89) -> (* Icon *)
                let v90 : obj = v89
                let v91 : string = "icon"
                let v92 : (string * obj) = v91, v90
                v92
            | US1_22(v93) -> (* Id *)
                let v94 : obj = v93
                let v95 : string = "id"
                let v96 : (string * obj) = v95, v94
                v96
            | US1_23(v97) -> (* JustifyContent *)
                let v98 : obj = v97
                let v99 : string = "justifyContent"
                let v100 : (string * obj) = v99, v98
                v100
            | US1_24(v101) -> (* Left *)
                let v102 : obj = v101
                let v103 : string = "left"
                let v104 : (string * obj) = v103, v102
                v104
            | US1_25(v105) -> (* LeftIcon *)
                let v106 : obj = v105
                let v107 : string = "leftIcon"
                let v108 : (string * obj) = v107, v106
                v108
            | US1_26(v109) -> (* LineHeight *)
                let v110 : obj = v109
                let v111 : string = "lineHeight"
                let v112 : (string * obj) = v111, v110
                v112
            | US1_27(v113) -> (* Loaded__ *)
                let v114 : obj = v113
                let v115 : string = "loaded__"
                let v116 : (string * obj) = v115, v114
                v116
            | US1_28(v117) -> (* Margin *)
                let v118 : obj = v117
                let v119 : string = "margin"
                let v120 : (string * obj) = v119, v118
                v120
            | US1_29(v121) -> (* MarginBottom *)
                let v122 : obj = v121
                let v123 : string = "marginBottom"
                let v124 : (string * obj) = v123, v122
                v124
            | US1_30(v125) -> (* MarginTop *)
                let v126 : obj = v125
                let v127 : string = "marginTop"
                let v128 : (string * obj) = v127, v126
                v128
            | US1_31(v129) -> (* MaxHeight *)
                let v130 : obj = v129
                let v131 : string = "maxHeight"
                let v132 : (string * obj) = v131, v130
                v132
            | US1_32(v133) -> (* Modal__ *)
                let v134 : obj = v133
                let v135 : string = "modal__"
                let v136 : (string * obj) = v135, v134
                v136
            | US1_33(v137) -> (* OnChange *)
                let v138 : obj = v137
                let v139 : string = "onChange"
                let v140 : (string * obj) = v139, v138
                v140
            | US1_34(v141) -> (* OnClick *)
                let v142 : obj = v141
                let v143 : string = "onClick"
                let v144 : (string * obj) = v143, v142
                v144
            | US1_35(v145) -> (* OnLoad__ *)
                let v146 : obj = v145
                let v147 : string = "onLoad__"
                let v148 : (string * obj) = v147, v146
                v148
            | US1_36(v149) -> (* Outline *)
                let v150 : obj = v149
                let v151 : string = "outline"
                let v152 : (string * obj) = v151, v150
                v152
            | US1_37(v153) -> (* OverflowX *)
                let v154 : obj = v153
                let v155 : string = "overflowX"
                let v156 : (string * obj) = v155, v154
                v156
            | US1_38(v157) -> (* OverflowY *)
                let v158 : obj = v157
                let v159 : string = "overflowY"
                let v160 : (string * obj) = v159, v158
                v160
            | US1_39(v161) -> (* Padding *)
                let v162 : obj = v161
                let v163 : string = "padding"
                let v164 : (string * obj) = v163, v162
                v164
            | US1_40(v165) -> (* PaddingBottom *)
                let v166 : obj = v165
                let v167 : string = "paddingBottom"
                let v168 : (string * obj) = v167, v166
                v168
            | US1_41(v169) -> (* PaddingLeft *)
                let v170 : obj = v169
                let v171 : string = "paddingLeft"
                let v172 : (string * obj) = v171, v170
                v172
            | US1_42(v173) -> (* PaddingRight *)
                let v174 : obj = v173
                let v175 : string = "paddingRight"
                let v176 : (string * obj) = v175, v174
                v176
            | US1_43(v177) -> (* PaddingTop *)
                let v178 : obj = v177
                let v179 : string = "paddingTop"
                let v180 : (string * obj) = v179, v178
                v180
            | US1_44(v181) -> (* Position *)
                let v182 : obj = v181
                let v183 : string = "position"
                let v184 : (string * obj) = v183, v182
                v184
            | US1_45(v185) -> (* Right *)
                let v186 : obj = v185
                let v187 : string = "right"
                let v188 : (string * obj) = v187, v186
                v188
            | US1_46(v189) -> (* Size *)
                let v190 : obj = v189
                let v191 : string = "size"
                let v192 : (string * obj) = v191, v190
                v192
            | US1_47(v193) -> (* Spacing *)
                let v194 : obj = v193
                let v195 : string = "spacing"
                let v196 : (string * obj) = v195, v194
                v196
            | US1_48(v197) -> (* Status *)
                let v198 : obj = v197
                let v199 : string = "status"
                let v200 : (string * obj) = v199, v198
                v200
            | US1_49(v201) -> (* Striped *)
                let v202 : obj = v201
                let v203 : string = "striped"
                let v204 : (string * obj) = v203, v202
                v204
            | US1_50(v205) -> (* Thickness *)
                let v206 : obj = v205
                let v207 : string = "thickness"
                let v208 : (string * obj) = v207, v206
                v208
            | US1_51(v209) -> (* Title *)
                let v210 : obj = v209
                let v211 : string = "title"
                let v212 : (string * obj) = v211, v210
                v212
            | US1_52(v213) -> (* Top *)
                let v214 : obj = v213
                let v215 : string = "top"
                let v216 : (string * obj) = v215, v214
                v216
            | US1_53(v217) -> (* Width *)
                let v218 : obj = v217
                let v219 : string = "width"
                let v220 : (string * obj) = v219, v218
                v220
            | US1_54(v221) -> (* ZIndex *)
                let v222 : obj = v221
                let v223 : string = "zIndex"
                let v224 : (string * obj) = v223, v222
                v224
        UH1_0(v225, v4)
    | UH0_1 -> (* Nil *)
        v1
and method6 (v0 : UH1, v1 : int32) : int32 =
    match v0 with
    | UH1_0(v2, v3) -> (* Cons *)
        let v4 : int32 = v1 + 1
        method6(v3, v4)
    | UH1_1 -> (* Nil *)
        v1
and method7 (v0 : ((string * obj) []), v1 : UH1, v2 : int32) : int32 =
    match v1 with
    | UH1_0(v3, v4) -> (* Cons *)
        v0.[int v2] <- v3
        let v5 : int32 = v2 + 1
        method7(v0, v4, v5)
    | UH1_1 -> (* Nil *)
        v2
and method5 (v0 : UH1) : ((string * obj) []) =
    let v1 : int32 = 0
    let v2 : int32 = method6(v0, v1)
    let v3 : ((string * obj) []) = Array.zeroCreate<(string * obj)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method7(v3, v0, v4)
    v3
and method2 (v0 : UH0) : JSX.Element =
    let v1 : string = "xs"
    let v2 : US1 = US1_46(v1)
    let v3 : string = "left"
    let v4 : US1 = US1_23(v3)
    let v5 : bool = true
    let v6 : US1 = US1_12(v5)
    let v7 : string = "neutral"
    let v8 : US1 = US1_11(v7)
    let v9 : UH0 = UH0_1
    let v10 : UH0 = UH0_0(v8, v9)
    let v11 : UH0 = UH0_0(v6, v10)
    let v12 : UH0 = UH0_0(v4, v11)
    let v13 : UH0 = UH0_0(v2, v12)
    let v14 : UH0 = method3(v0, v13)
    let v15 : string = "Button"
    let v16 : string = "@hope-ui/solid"
    let v17 : JS.Function = import v15 v16
    let v18 : UH1 = UH1_1
    let v19 : UH1 = method4(v14, v18)
    let v20 : ((string * obj) []) = method5(v19)
    let v21 : obj = createObj v20
    let v22 : UH0 = v21 |> unbox
    let v23 : string = "createComponent"
    let v24 : string = "solid-js"
    let v25 : JS.Function = import v23 v24
    let v26 : JSX.Element = v25.Invoke (v17, v22) |> unbox<JSX.Element>
    v26
and closure1 () (v0 : UH0) : JSX.Element =
    method2(v0)
and method9 (v0 : UH0, v1 : US2) : US2 =
    match v0 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : US2 = method9(v3, v1)
        match v4 with
        | US2_0 -> (* None *)
            match v2 with
            | US1_0(v5) -> (* AriaLabel *)
                v4
            | US1_1(v6) -> (* As *)
                v4
            | US1_2(v7) -> (* BackgroundColor *)
                v4
            | US1_3(v8) -> (* Border *)
                v4
            | US1_4(v9) -> (* BorderBottomWidth *)
                v4
            | US1_5(v10) -> (* BorderColor *)
                v4
            | US1_6(v11) -> (* BorderWidth *)
                v4
            | US1_7(v12) -> (* Bottom *)
                v4
            | US1_8(v13) -> (* Checked *)
                v4
            | US1_9(v14) -> (* Children *)
                v4
            | US1_10(v15) -> (* Color *)
                v4
            | US1_11(v16) -> (* ColorScheme *)
                v4
            | US1_12(v17) -> (* Compact *)
                v4
            | US1_13(v18) -> (* Direction *)
                v4
            | US1_14(v19) -> (* Display *)
                v4
            | US1_15(v20) -> (* External *)
                v4
            | US1_16(v21) -> (* Flex *)
                v4
            | US1_17(v22) -> (* FlexDirection *)
                v4
            | US1_18(v23) -> (* FontSize *)
                v4
            | US1_19(v24) -> (* Height *)
                v4
            | US1_20(v25) -> (* Href *)
                v4
            | US1_21(v26) -> (* Icon *)
                v4
            | US1_22(v27) -> (* Id *)
                v4
            | US1_23(v28) -> (* JustifyContent *)
                v4
            | US1_24(v29) -> (* Left *)
                v4
            | US1_25(v30) -> (* LeftIcon *)
                v4
            | US1_26(v31) -> (* LineHeight *)
                v4
            | US1_27(v32) -> (* Loaded__ *)
                v4
            | US1_28(v33) -> (* Margin *)
                v4
            | US1_29(v34) -> (* MarginBottom *)
                v4
            | US1_30(v35) -> (* MarginTop *)
                v4
            | US1_31(v36) -> (* MaxHeight *)
                v4
            | US1_32(v37) -> (* Modal__ *)
                v4
            | US1_33(v38) -> (* OnChange *)
                v4
            | US1_34(v39) -> (* OnClick *)
                v4
            | US1_35(v40) -> (* OnLoad__ *)
                v4
            | US1_36(v41) -> (* Outline *)
                v4
            | US1_37(v42) -> (* OverflowX *)
                v4
            | US1_38(v43) -> (* OverflowY *)
                US2_1(v43)
            | US1_39(v45) -> (* Padding *)
                v4
            | US1_40(v46) -> (* PaddingBottom *)
                v4
            | US1_41(v47) -> (* PaddingLeft *)
                v4
            | US1_42(v48) -> (* PaddingRight *)
                v4
            | US1_43(v49) -> (* PaddingTop *)
                v4
            | US1_44(v50) -> (* Position *)
                v4
            | US1_45(v51) -> (* Right *)
                v4
            | US1_46(v52) -> (* Size *)
                v4
            | US1_47(v53) -> (* Spacing *)
                v4
            | US1_48(v54) -> (* Status *)
                v4
            | US1_49(v55) -> (* Striped *)
                v4
            | US1_50(v56) -> (* Thickness *)
                v4
            | US1_51(v57) -> (* Title *)
                v4
            | US1_52(v58) -> (* Top *)
                v4
            | US1_53(v59) -> (* Width *)
                v4
            | US1_54(v60) -> (* ZIndex *)
                v4
        | US2_1(v62) -> (* Some *)
            v4
    | UH0_1 -> (* Nil *)
        v1
and method10 (v0 : UH0, v1 : US3) : US3 =
    match v0 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : US3 = method10(v3, v1)
        match v4 with
        | US3_0 -> (* None *)
            match v2 with
            | US1_0(v5) -> (* AriaLabel *)
                v4
            | US1_1(v6) -> (* As *)
                v4
            | US1_2(v7) -> (* BackgroundColor *)
                v4
            | US1_3(v8) -> (* Border *)
                v4
            | US1_4(v9) -> (* BorderBottomWidth *)
                v4
            | US1_5(v10) -> (* BorderColor *)
                v4
            | US1_6(v11) -> (* BorderWidth *)
                v4
            | US1_7(v12) -> (* Bottom *)
                v4
            | US1_8(v13) -> (* Checked *)
                v4
            | US1_9(v14) -> (* Children *)
                US3_1(v14)
            | US1_10(v16) -> (* Color *)
                v4
            | US1_11(v17) -> (* ColorScheme *)
                v4
            | US1_12(v18) -> (* Compact *)
                v4
            | US1_13(v19) -> (* Direction *)
                v4
            | US1_14(v20) -> (* Display *)
                v4
            | US1_15(v21) -> (* External *)
                v4
            | US1_16(v22) -> (* Flex *)
                v4
            | US1_17(v23) -> (* FlexDirection *)
                v4
            | US1_18(v24) -> (* FontSize *)
                v4
            | US1_19(v25) -> (* Height *)
                v4
            | US1_20(v26) -> (* Href *)
                v4
            | US1_21(v27) -> (* Icon *)
                v4
            | US1_22(v28) -> (* Id *)
                v4
            | US1_23(v29) -> (* JustifyContent *)
                v4
            | US1_24(v30) -> (* Left *)
                v4
            | US1_25(v31) -> (* LeftIcon *)
                v4
            | US1_26(v32) -> (* LineHeight *)
                v4
            | US1_27(v33) -> (* Loaded__ *)
                v4
            | US1_28(v34) -> (* Margin *)
                v4
            | US1_29(v35) -> (* MarginBottom *)
                v4
            | US1_30(v36) -> (* MarginTop *)
                v4
            | US1_31(v37) -> (* MaxHeight *)
                v4
            | US1_32(v38) -> (* Modal__ *)
                v4
            | US1_33(v39) -> (* OnChange *)
                v4
            | US1_34(v40) -> (* OnClick *)
                v4
            | US1_35(v41) -> (* OnLoad__ *)
                v4
            | US1_36(v42) -> (* Outline *)
                v4
            | US1_37(v43) -> (* OverflowX *)
                v4
            | US1_38(v44) -> (* OverflowY *)
                v4
            | US1_39(v45) -> (* Padding *)
                v4
            | US1_40(v46) -> (* PaddingBottom *)
                v4
            | US1_41(v47) -> (* PaddingLeft *)
                v4
            | US1_42(v48) -> (* PaddingRight *)
                v4
            | US1_43(v49) -> (* PaddingTop *)
                v4
            | US1_44(v50) -> (* Position *)
                v4
            | US1_45(v51) -> (* Right *)
                v4
            | US1_46(v52) -> (* Size *)
                v4
            | US1_47(v53) -> (* Spacing *)
                v4
            | US1_48(v54) -> (* Status *)
                v4
            | US1_49(v55) -> (* Striped *)
                v4
            | US1_50(v56) -> (* Thickness *)
                v4
            | US1_51(v57) -> (* Title *)
                v4
            | US1_52(v58) -> (* Top *)
                v4
            | US1_53(v59) -> (* Width *)
                v4
            | US1_54(v60) -> (* ZIndex *)
                v4
        | US3_1(v62) -> (* Some *)
            v4
    | UH0_1 -> (* Nil *)
        v1
and closure4 () () : (JSX.Element []) =
    [||]
and closure3 (v0 : UH0) () : (JSX.Element []) =
    let v2 : US3 = US3_0
    let v3 : US3 = method10(v0, v2)
    let v6 : (unit -> (JSX.Element [])) =
        match v3 with
        | US3_0 -> (* None *)
            closure4()
        | US3_1(v5) -> (* Some *)
            v5
    let v7 : string = "Tbody"
    let v8 : string = "@hope-ui/solid"
    let v9 : JS.Function = import v7 v8
    let v10 : obj = v6
    let v11 : string = "children"
    let v12 : (string * obj) = v11, v10
    let v13 : string = "-1px"
    let v14 : obj = v13
    let v15 : string = "margin"
    let v16 : (string * obj) = v15, v14
    let v17 : string = "$blackAlpha3"
    let v18 : obj = v17
    let v19 : string = "backgroundColor"
    let v20 : (string * obj) = v19, v18
    let v21 : string = "column"
    let v22 : obj = v21
    let v23 : string = "flexDirection"
    let v24 : (string * obj) = v23, v22
    let v25 : string = "flex"
    let v26 : obj = v25
    let v27 : string = "display"
    let v28 : (string * obj) = v27, v26
    let v29 : UH1 = UH1_1
    let v30 : UH1 = UH1_0(v12, v29)
    let v31 : UH1 = UH1_0(v16, v30)
    let v32 : UH1 = UH1_0(v20, v31)
    let v33 : UH1 = UH1_0(v24, v32)
    let v34 : UH1 = UH1_0(v28, v33)
    let v35 : ((string * obj) []) = method5(v34)
    let v36 : obj = createObj v35
    let v37 : UH0 = v36 |> unbox
    let v38 : string = "createComponent"
    let v39 : string = "solid-js"
    let v40 : JS.Function = import v38 v39
    let v41 : JSX.Element = v40.Invoke (v9, v37) |> unbox<JSX.Element>
    [|v41|]
and method8 (v0 : UH0) : JSX.Element =
    let v2 : US2 = US2_0
    let v3 : US2 = method9(v0, v2)
    let v6 : string =
        match v3 with
        | US2_0 -> (* None *)
            let v4 : string = "hidden"
            v4
        | US2_1(v5) -> (* Some *)
            v5
    let v7 : string = "Table"
    let v8 : string = "@hope-ui/solid"
    let v9 : JS.Function = import v7 v8
    let v10 : (unit -> (JSX.Element [])) = closure3(v0)
    let v11 : obj = v10
    let v12 : string = "children"
    let v13 : (string * obj) = v12, v11
    let v14 : obj = v6
    let v15 : string = "overflowY"
    let v16 : (string * obj) = v15, v14
    let v17 : string = "hidden"
    let v18 : obj = v17
    let v19 : string = "overflowX"
    let v20 : (string * obj) = v19, v18
    let v21 : string = "column"
    let v22 : obj = v21
    let v23 : string = "flexDirection"
    let v24 : (string * obj) = v23, v22
    let v25 : string = "1"
    let v26 : obj = v25
    let v27 : string = "flex"
    let v28 : (string * obj) = v27, v26
    let v29 : obj = v27
    let v30 : string = "display"
    let v31 : (string * obj) = v30, v29
    let v32 : UH1 = UH1_1
    let v33 : UH1 = UH1_0(v13, v32)
    let v34 : UH1 = UH1_0(v16, v33)
    let v35 : UH1 = UH1_0(v20, v34)
    let v36 : UH1 = UH1_0(v24, v35)
    let v37 : UH1 = UH1_0(v28, v36)
    let v38 : UH1 = UH1_0(v31, v37)
    let v39 : ((string * obj) []) = method5(v38)
    let v40 : obj = createObj v39
    let v41 : UH0 = v40 |> unbox
    let v42 : string = "createComponent"
    let v43 : string = "solid-js"
    let v44 : JS.Function = import v42 v43
    let v45 : JSX.Element = v44.Invoke (v9, v41) |> unbox<JSX.Element>
    v45
and closure2 () (v0 : UH0) : JSX.Element =
    method8(v0)
and method12 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method11 (v0 : (struct (string * obj) [])) : UH0 =
    let v1 : int32 = v0.Length
    let v2 : UH0 = UH0_1
    let v3 : Mut1 = {l0 = 0; l1 = v2} : Mut1
    while method12(v1, v3) do
        let v5 : int32 = v3.l0
        let v6 : UH0 = v3.l1
        let struct (v7 : string, v8 : obj) = v0.[int v5]
        let v9 : bool = v8 = JS.undefined
        let v287 : UH0 =
            if v9 then
                v6
            else
                let v10 : bool = "loaded__" = v7
                if v10 then
                    let v11 : bool = v8 |> unbox
                    let v12 : US1 = US1_27(v11)
                    UH0_0(v12, v6)
                else
                    let v14 : bool = "modal__" = v7
                    if v14 then
                        let v15 : bool = v8 |> unbox
                        let v16 : US1 = US1_32(v15)
                        UH0_0(v16, v6)
                    else
                        let v18 : bool = "onLoad__" = v7
                        if v18 then
                            let v19 : (obj -> ((obj -> unit) -> unit)) = v8 |> unbox
                            let v20 : US1 = US1_35(v19)
                            UH0_0(v20, v6)
                        else
                            let v22 : bool = "aria-label" = v7
                            if v22 then
                                let v23 : string = v8 |> unbox
                                let v24 : US1 = US1_0(v23)
                                UH0_0(v24, v6)
                            else
                                let v26 : bool = "as" = v7
                                if v26 then
                                    let v27 : JS.Function = v8 |> unbox
                                    let v28 : US1 = US1_1(v27)
                                    UH0_0(v28, v6)
                                else
                                    let v30 : bool = "backgroundColor" = v7
                                    if v30 then
                                        let v31 : string = v8 |> unbox
                                        let v32 : US1 = US1_2(v31)
                                        UH0_0(v32, v6)
                                    else
                                        let v34 : bool = "border" = v7
                                        if v34 then
                                            let v35 : string = v8 |> unbox
                                            let v36 : US1 = US1_3(v35)
                                            UH0_0(v36, v6)
                                        else
                                            let v38 : bool = "borderWidth" = v7
                                            if v38 then
                                                let v39 : string = v8 |> unbox
                                                let v40 : US1 = US1_6(v39)
                                                UH0_0(v40, v6)
                                            else
                                                let v42 : bool = "borderBottomWidth" = v7
                                                if v42 then
                                                    let v43 : string = v8 |> unbox
                                                    let v44 : US1 = US1_4(v43)
                                                    UH0_0(v44, v6)
                                                else
                                                    let v46 : bool = "borderColor" = v7
                                                    if v46 then
                                                        let v47 : string = v8 |> unbox
                                                        let v48 : US1 = US1_5(v47)
                                                        UH0_0(v48, v6)
                                                    else
                                                        let v50 : bool = "bottom" = v7
                                                        if v50 then
                                                            let v51 : string = v8 |> unbox
                                                            let v52 : US1 = US1_7(v51)
                                                            UH0_0(v52, v6)
                                                        else
                                                            let v54 : bool = "color" = v7
                                                            if v54 then
                                                                let v55 : string = v8 |> unbox
                                                                let v56 : US1 = US1_10(v55)
                                                                UH0_0(v56, v6)
                                                            else
                                                                let v58 : bool = "checked" = v7
                                                                if v58 then
                                                                    let v59 : bool = v8 |> unbox
                                                                    let v60 : US1 = US1_8(v59)
                                                                    UH0_0(v60, v6)
                                                                else
                                                                    let v62 : bool = "children" = v7
                                                                    if v62 then
                                                                        let v63 : (unit -> (JSX.Element [])) = v8 |> unbox
                                                                        let v64 : US1 = US1_9(v63)
                                                                        UH0_0(v64, v6)
                                                                    else
                                                                        let v66 : bool = "colorScheme" = v7
                                                                        if v66 then
                                                                            let v67 : string = v8 |> unbox
                                                                            let v68 : US1 = US1_11(v67)
                                                                            UH0_0(v68, v6)
                                                                        else
                                                                            let v70 : bool = "compact" = v7
                                                                            if v70 then
                                                                                let v71 : bool = v8 |> unbox
                                                                                let v72 : US1 = US1_12(v71)
                                                                                UH0_0(v72, v6)
                                                                            else
                                                                                let v74 : bool = "direction" = v7
                                                                                if v74 then
                                                                                    let v75 : string = v8 |> unbox
                                                                                    let v76 : US1 = US1_13(v75)
                                                                                    UH0_0(v76, v6)
                                                                                else
                                                                                    let v78 : bool = "display" = v7
                                                                                    if v78 then
                                                                                        let v79 : string = v8 |> unbox
                                                                                        let v80 : US1 = US1_14(v79)
                                                                                        UH0_0(v80, v6)
                                                                                    else
                                                                                        let v82 : bool = "external" = v7
                                                                                        if v82 then
                                                                                            let v83 : bool = v8 |> unbox
                                                                                            let v84 : US1 = US1_15(v83)
                                                                                            UH0_0(v84, v6)
                                                                                        else
                                                                                            let v86 : bool = "flex" = v7
                                                                                            if v86 then
                                                                                                let v87 : string = v8 |> unbox
                                                                                                let v88 : US1 = US1_16(v87)
                                                                                                UH0_0(v88, v6)
                                                                                            else
                                                                                                let v90 : bool = "flexDirection" = v7
                                                                                                if v90 then
                                                                                                    let v91 : string = v8 |> unbox
                                                                                                    let v92 : US1 = US1_17(v91)
                                                                                                    UH0_0(v92, v6)
                                                                                                else
                                                                                                    let v94 : bool = "fontSize" = v7
                                                                                                    if v94 then
                                                                                                        let v95 : string = v8 |> unbox
                                                                                                        let v96 : US1 = US1_18(v95)
                                                                                                        UH0_0(v96, v6)
                                                                                                    else
                                                                                                        let v98 : bool = "height" = v7
                                                                                                        if v98 then
                                                                                                            let v99 : string = v8 |> unbox
                                                                                                            let v100 : US1 = US1_19(v99)
                                                                                                            UH0_0(v100, v6)
                                                                                                        else
                                                                                                            let v102 : bool = "href" = v7
                                                                                                            if v102 then
                                                                                                                let v103 : string = v8 |> unbox
                                                                                                                let v104 : US1 = US1_20(v103)
                                                                                                                UH0_0(v104, v6)
                                                                                                            else
                                                                                                                let v106 : bool = "icon" = v7
                                                                                                                if v106 then
                                                                                                                    let v107 : JSX.Element = v8 |> unbox
                                                                                                                    let v108 : US1 = US1_21(v107)
                                                                                                                    UH0_0(v108, v6)
                                                                                                                else
                                                                                                                    let v110 : bool = "id" = v7
                                                                                                                    if v110 then
                                                                                                                        let v111 : string = v8 |> unbox
                                                                                                                        let v112 : US1 = US1_22(v111)
                                                                                                                        UH0_0(v112, v6)
                                                                                                                    else
                                                                                                                        let v114 : bool = "justifyContent" = v7
                                                                                                                        if v114 then
                                                                                                                            let v115 : string = v8 |> unbox
                                                                                                                            let v116 : US1 = US1_23(v115)
                                                                                                                            UH0_0(v116, v6)
                                                                                                                        else
                                                                                                                            let v118 : bool = "left" = v7
                                                                                                                            if v118 then
                                                                                                                                let v119 : string = v8 |> unbox
                                                                                                                                let v120 : US1 = US1_24(v119)
                                                                                                                                UH0_0(v120, v6)
                                                                                                                            else
                                                                                                                                let v122 : bool = "leftIcon" = v7
                                                                                                                                if v122 then
                                                                                                                                    let v123 : obj = v8 |> unbox
                                                                                                                                    let v124 : US1 = US1_25(v123)
                                                                                                                                    UH0_0(v124, v6)
                                                                                                                                else
                                                                                                                                    let v126 : bool = "lineHeight" = v7
                                                                                                                                    if v126 then
                                                                                                                                        let v127 : string = v8 |> unbox
                                                                                                                                        let v128 : US1 = US1_26(v127)
                                                                                                                                        UH0_0(v128, v6)
                                                                                                                                    else
                                                                                                                                        let v130 : bool = "margin" = v7
                                                                                                                                        if v130 then
                                                                                                                                            let v131 : string = v8 |> unbox
                                                                                                                                            let v132 : US1 = US1_28(v131)
                                                                                                                                            UH0_0(v132, v6)
                                                                                                                                        else
                                                                                                                                            let v134 : bool = "marginBottom" = v7
                                                                                                                                            if v134 then
                                                                                                                                                let v135 : string = v8 |> unbox
                                                                                                                                                let v136 : US1 = US1_29(v135)
                                                                                                                                                UH0_0(v136, v6)
                                                                                                                                            else
                                                                                                                                                let v138 : bool = "marginTop" = v7
                                                                                                                                                if v138 then
                                                                                                                                                    let v139 : string = v8 |> unbox
                                                                                                                                                    let v140 : US1 = US1_30(v139)
                                                                                                                                                    UH0_0(v140, v6)
                                                                                                                                                else
                                                                                                                                                    let v142 : bool = "maxHeight" = v7
                                                                                                                                                    if v142 then
                                                                                                                                                        let v143 : string = v8 |> unbox
                                                                                                                                                        let v144 : US1 = US1_31(v143)
                                                                                                                                                        UH0_0(v144, v6)
                                                                                                                                                    else
                                                                                                                                                        let v146 : bool = "onChange" = v7
                                                                                                                                                        if v146 then
                                                                                                                                                            let v147 : (obj -> unit) = v8 |> unbox
                                                                                                                                                            let v148 : US1 = US1_33(v147)
                                                                                                                                                            UH0_0(v148, v6)
                                                                                                                                                        else
                                                                                                                                                            let v150 : bool = "onClick" = v7
                                                                                                                                                            if v150 then
                                                                                                                                                                let v151 : (unit -> unit) = v8 |> unbox
                                                                                                                                                                let v152 : US1 = US1_34(v151)
                                                                                                                                                                UH0_0(v152, v6)
                                                                                                                                                            else
                                                                                                                                                                let v154 : bool = "outline" = v7
                                                                                                                                                                if v154 then
                                                                                                                                                                    let v155 : string = v8 |> unbox
                                                                                                                                                                    let v156 : US1 = US1_36(v155)
                                                                                                                                                                    UH0_0(v156, v6)
                                                                                                                                                                else
                                                                                                                                                                    let v158 : bool = "overflowX" = v7
                                                                                                                                                                    if v158 then
                                                                                                                                                                        let v159 : string = v8 |> unbox
                                                                                                                                                                        let v160 : US1 = US1_37(v159)
                                                                                                                                                                        UH0_0(v160, v6)
                                                                                                                                                                    else
                                                                                                                                                                        let v162 : bool = "overflowY" = v7
                                                                                                                                                                        if v162 then
                                                                                                                                                                            let v163 : string = v8 |> unbox
                                                                                                                                                                            let v164 : US1 = US1_38(v163)
                                                                                                                                                                            UH0_0(v164, v6)
                                                                                                                                                                        else
                                                                                                                                                                            let v166 : bool = "padding" = v7
                                                                                                                                                                            if v166 then
                                                                                                                                                                                let v167 : string = v8 |> unbox
                                                                                                                                                                                let v168 : US1 = US1_39(v167)
                                                                                                                                                                                UH0_0(v168, v6)
                                                                                                                                                                            else
                                                                                                                                                                                let v170 : bool = "paddingTop" = v7
                                                                                                                                                                                if v170 then
                                                                                                                                                                                    let v171 : string = v8 |> unbox
                                                                                                                                                                                    let v172 : US1 = US1_43(v171)
                                                                                                                                                                                    UH0_0(v172, v6)
                                                                                                                                                                                else
                                                                                                                                                                                    let v174 : bool = "paddingRight" = v7
                                                                                                                                                                                    if v174 then
                                                                                                                                                                                        let v175 : string = v8 |> unbox
                                                                                                                                                                                        let v176 : US1 = US1_42(v175)
                                                                                                                                                                                        UH0_0(v176, v6)
                                                                                                                                                                                    else
                                                                                                                                                                                        let v178 : bool = "paddingBottom" = v7
                                                                                                                                                                                        if v178 then
                                                                                                                                                                                            let v179 : string = v8 |> unbox
                                                                                                                                                                                            let v180 : US1 = US1_40(v179)
                                                                                                                                                                                            UH0_0(v180, v6)
                                                                                                                                                                                        else
                                                                                                                                                                                            let v182 : bool = "paddingLeft" = v7
                                                                                                                                                                                            if v182 then
                                                                                                                                                                                                let v183 : string = v8 |> unbox
                                                                                                                                                                                                let v184 : US1 = US1_41(v183)
                                                                                                                                                                                                UH0_0(v184, v6)
                                                                                                                                                                                            else
                                                                                                                                                                                                let v186 : bool = "position" = v7
                                                                                                                                                                                                if v186 then
                                                                                                                                                                                                    let v187 : string = v8 |> unbox
                                                                                                                                                                                                    let v188 : US1 = US1_44(v187)
                                                                                                                                                                                                    UH0_0(v188, v6)
                                                                                                                                                                                                else
                                                                                                                                                                                                    let v190 : bool = "right" = v7
                                                                                                                                                                                                    if v190 then
                                                                                                                                                                                                        let v191 : string = v8 |> unbox
                                                                                                                                                                                                        let v192 : US1 = US1_45(v191)
                                                                                                                                                                                                        UH0_0(v192, v6)
                                                                                                                                                                                                    else
                                                                                                                                                                                                        let v194 : bool = "size" = v7
                                                                                                                                                                                                        if v194 then
                                                                                                                                                                                                            let v195 : string = v8 |> unbox
                                                                                                                                                                                                            let v196 : US1 = US1_46(v195)
                                                                                                                                                                                                            UH0_0(v196, v6)
                                                                                                                                                                                                        else
                                                                                                                                                                                                            let v198 : bool = "spacing" = v7
                                                                                                                                                                                                            if v198 then
                                                                                                                                                                                                                let v199 : string = v8 |> unbox
                                                                                                                                                                                                                let v200 : US1 = US1_47(v199)
                                                                                                                                                                                                                UH0_0(v200, v6)
                                                                                                                                                                                                            else
                                                                                                                                                                                                                let v202 : bool = "status" = v7
                                                                                                                                                                                                                if v202 then
                                                                                                                                                                                                                    let v203 : bool = v8 |> unbox
                                                                                                                                                                                                                    let v204 : US1 = US1_48(v203)
                                                                                                                                                                                                                    UH0_0(v204, v6)
                                                                                                                                                                                                                else
                                                                                                                                                                                                                    let v206 : bool = "striped" = v7
                                                                                                                                                                                                                    if v206 then
                                                                                                                                                                                                                        let v207 : string = v8 |> unbox
                                                                                                                                                                                                                        let v208 : US1 = US1_49(v207)
                                                                                                                                                                                                                        UH0_0(v208, v6)
                                                                                                                                                                                                                    else
                                                                                                                                                                                                                        let v210 : bool = "thickness" = v7
                                                                                                                                                                                                                        if v210 then
                                                                                                                                                                                                                            let v211 : string = v8 |> unbox
                                                                                                                                                                                                                            let v212 : US1 = US1_50(v211)
                                                                                                                                                                                                                            UH0_0(v212, v6)
                                                                                                                                                                                                                        else
                                                                                                                                                                                                                            let v214 : bool = "title" = v7
                                                                                                                                                                                                                            if v214 then
                                                                                                                                                                                                                                let v215 : JSX.Element = v8 |> unbox
                                                                                                                                                                                                                                let v216 : US1 = US1_51(v215)
                                                                                                                                                                                                                                UH0_0(v216, v6)
                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                let v218 : bool = "top" = v7
                                                                                                                                                                                                                                if v218 then
                                                                                                                                                                                                                                    let v219 : string = v8 |> unbox
                                                                                                                                                                                                                                    let v220 : US1 = US1_52(v219)
                                                                                                                                                                                                                                    UH0_0(v220, v6)
                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                    let v222 : bool = "width" = v7
                                                                                                                                                                                                                                    if v222 then
                                                                                                                                                                                                                                        let v223 : string = v8 |> unbox
                                                                                                                                                                                                                                        let v224 : US1 = US1_53(v223)
                                                                                                                                                                                                                                        UH0_0(v224, v6)
                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                        let v226 : bool = "zIndex" = v7
                                                                                                                                                                                                                                        if v226 then
                                                                                                                                                                                                                                            let v227 : int32 = v8 |> unbox
                                                                                                                                                                                                                                            let v228 : US1 = US1_54(v227)
                                                                                                                                                                                                                                            UH0_0(v228, v6)
                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                            let v230 : string = $"unknown prop: {v7} = {v8}"
                                                                                                                                                                                                                                            failwith<UH0> v230
        let v288 : int32 = v5 + 1
        v3.l0 <- v288
        v3.l1 <- v287
        ()
    let v289 : UH0 = v3.l1
    v289
and closure5 () (v0 : (struct (string * obj) [])) : UH0 =
    method11(v0)
and closure6 () (v0 : obj) : obj =
    method1(v0)
and method14 (v0 : UH0, v1 : US2) : US2 =
    match v0 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : US2 = method14(v3, v1)
        match v4 with
        | US2_0 -> (* None *)
            match v2 with
            | US1_0(v5) -> (* AriaLabel *)
                v4
            | US1_1(v6) -> (* As *)
                v4
            | US1_2(v7) -> (* BackgroundColor *)
                v4
            | US1_3(v8) -> (* Border *)
                v4
            | US1_4(v9) -> (* BorderBottomWidth *)
                v4
            | US1_5(v10) -> (* BorderColor *)
                v4
            | US1_6(v11) -> (* BorderWidth *)
                v4
            | US1_7(v12) -> (* Bottom *)
                v4
            | US1_8(v13) -> (* Checked *)
                v4
            | US1_9(v14) -> (* Children *)
                v4
            | US1_10(v15) -> (* Color *)
                v4
            | US1_11(v16) -> (* ColorScheme *)
                v4
            | US1_12(v17) -> (* Compact *)
                v4
            | US1_13(v18) -> (* Direction *)
                v4
            | US1_14(v19) -> (* Display *)
                v4
            | US1_15(v20) -> (* External *)
                v4
            | US1_16(v21) -> (* Flex *)
                v4
            | US1_17(v22) -> (* FlexDirection *)
                v4
            | US1_18(v23) -> (* FontSize *)
                v4
            | US1_19(v24) -> (* Height *)
                v4
            | US1_20(v25) -> (* Href *)
                US2_1(v25)
            | US1_21(v27) -> (* Icon *)
                v4
            | US1_22(v28) -> (* Id *)
                v4
            | US1_23(v29) -> (* JustifyContent *)
                v4
            | US1_24(v30) -> (* Left *)
                v4
            | US1_25(v31) -> (* LeftIcon *)
                v4
            | US1_26(v32) -> (* LineHeight *)
                v4
            | US1_27(v33) -> (* Loaded__ *)
                v4
            | US1_28(v34) -> (* Margin *)
                v4
            | US1_29(v35) -> (* MarginBottom *)
                v4
            | US1_30(v36) -> (* MarginTop *)
                v4
            | US1_31(v37) -> (* MaxHeight *)
                v4
            | US1_32(v38) -> (* Modal__ *)
                v4
            | US1_33(v39) -> (* OnChange *)
                v4
            | US1_34(v40) -> (* OnClick *)
                v4
            | US1_35(v41) -> (* OnLoad__ *)
                v4
            | US1_36(v42) -> (* Outline *)
                v4
            | US1_37(v43) -> (* OverflowX *)
                v4
            | US1_38(v44) -> (* OverflowY *)
                v4
            | US1_39(v45) -> (* Padding *)
                v4
            | US1_40(v46) -> (* PaddingBottom *)
                v4
            | US1_41(v47) -> (* PaddingLeft *)
                v4
            | US1_42(v48) -> (* PaddingRight *)
                v4
            | US1_43(v49) -> (* PaddingTop *)
                v4
            | US1_44(v50) -> (* Position *)
                v4
            | US1_45(v51) -> (* Right *)
                v4
            | US1_46(v52) -> (* Size *)
                v4
            | US1_47(v53) -> (* Spacing *)
                v4
            | US1_48(v54) -> (* Status *)
                v4
            | US1_49(v55) -> (* Striped *)
                v4
            | US1_50(v56) -> (* Thickness *)
                v4
            | US1_51(v57) -> (* Title *)
                v4
            | US1_52(v58) -> (* Top *)
                v4
            | US1_53(v59) -> (* Width *)
                v4
            | US1_54(v60) -> (* ZIndex *)
                v4
        | US2_1(v62) -> (* Some *)
            v4
    | UH0_1 -> (* Nil *)
        v1
and closure9 (v0 : UH0) () : (JSX.Element []) =
    let v2 : US2 = US2_0
    let v3 : US2 = method14(v0, v2)
    let v6 : string =
        match v3 with
        | US2_0 -> (* None *)
            let v4 : string = ""
            v4
        | US2_1(v5) -> (* Some *)
            v5
    let v7 : JSX.Element = Html.fragment [ v6 |> unbox<JSX.Element> ]
    [|v7|]
and closure8 (v0 : UH0) () : (JSX.Element []) =
    let v1 : bool = true
    let v2 : US1 = US1_15(v1)
    let v3 : (unit -> (JSX.Element [])) = closure9(v0)
    let v4 : US1 = US1_9(v3)
    let v5 : UH0 = UH0_1
    let v6 : UH0 = UH0_0(v4, v5)
    let v7 : UH0 = UH0_0(v2, v6)
    let v8 : UH0 = method3(v0, v7)
    let v9 : string = "Anchor"
    let v10 : string = "@hope-ui/solid"
    let v11 : JS.Function = import v9 v10
    let v12 : UH1 = UH1_1
    let v13 : UH1 = method4(v8, v12)
    let v14 : ((string * obj) []) = method5(v13)
    let v15 : obj = createObj v14
    let v16 : UH0 = v15 |> unbox
    let v17 : string = "createComponent"
    let v18 : string = "solid-js"
    let v19 : JS.Function = import v17 v18
    let v20 : JSX.Element = v19.Invoke (v11, v16) |> unbox<JSX.Element>
    let v21 : string = "&nbsp;"
    let v22 : JSX.Element = Html.fragment [ v21 |> unbox<JSX.Element> ]
    let v23 : string = "BiRegularLinkExternal"
    let v24 : string = "solid-icons/bi"
    let v25 : JS.Function = import v23 v24
    let v26 : string = "Icon"
    let v27 : JS.Function = import v26 v10
    let v28 : obj = v25
    let v29 : string = "as"
    let v30 : (string * obj) = v29, v28
    let v31 : UH1 = UH1_1
    let v32 : UH1 = UH1_0(v30, v31)
    let v33 : ((string * obj) []) = method5(v32)
    let v34 : obj = createObj v33
    let v35 : UH0 = v34 |> unbox
    let v36 : JS.Function = import v17 v18
    let v37 : JSX.Element = v36.Invoke (v27, v35) |> unbox<JSX.Element>
    [|v20; v22; v37|]
and method13 (v0 : UH0) : JSX.Element =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (unit -> (JSX.Element [])) = closure8(v0)
    let v5 : obj = v4
    let v6 : string = "children"
    let v7 : (string * obj) = v6, v5
    let v8 : UH1 = UH1_1
    let v9 : UH1 = UH1_0(v7, v8)
    let v10 : ((string * obj) []) = method5(v9)
    let v11 : obj = createObj v10
    let v12 : UH0 = v11 |> unbox
    let v13 : string = "createComponent"
    let v14 : string = "solid-js"
    let v15 : JS.Function = import v13 v14
    let v16 : JSX.Element = v15.Invoke (v3, v12) |> unbox<JSX.Element>
    v16
and closure7 () (v0 : UH0) : JSX.Element =
    method13(v0)
and method17 (v0 : UH0, v1 : US4) : US4 =
    match v0 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : US4 = method17(v3, v1)
        match v4 with
        | US4_0 -> (* None *)
            match v2 with
            | US1_0(v5) -> (* AriaLabel *)
                v4
            | US1_1(v6) -> (* As *)
                v4
            | US1_2(v7) -> (* BackgroundColor *)
                v4
            | US1_3(v8) -> (* Border *)
                v4
            | US1_4(v9) -> (* BorderBottomWidth *)
                v4
            | US1_5(v10) -> (* BorderColor *)
                v4
            | US1_6(v11) -> (* BorderWidth *)
                v4
            | US1_7(v12) -> (* Bottom *)
                v4
            | US1_8(v13) -> (* Checked *)
                v4
            | US1_9(v14) -> (* Children *)
                v4
            | US1_10(v15) -> (* Color *)
                v4
            | US1_11(v16) -> (* ColorScheme *)
                v4
            | US1_12(v17) -> (* Compact *)
                v4
            | US1_13(v18) -> (* Direction *)
                v4
            | US1_14(v19) -> (* Display *)
                v4
            | US1_15(v20) -> (* External *)
                v4
            | US1_16(v21) -> (* Flex *)
                v4
            | US1_17(v22) -> (* FlexDirection *)
                v4
            | US1_18(v23) -> (* FontSize *)
                v4
            | US1_19(v24) -> (* Height *)
                v4
            | US1_20(v25) -> (* Href *)
                v4
            | US1_21(v26) -> (* Icon *)
                v4
            | US1_22(v27) -> (* Id *)
                v4
            | US1_23(v28) -> (* JustifyContent *)
                v4
            | US1_24(v29) -> (* Left *)
                v4
            | US1_25(v30) -> (* LeftIcon *)
                v4
            | US1_26(v31) -> (* LineHeight *)
                v4
            | US1_27(v32) -> (* Loaded__ *)
                v4
            | US1_28(v33) -> (* Margin *)
                v4
            | US1_29(v34) -> (* MarginBottom *)
                v4
            | US1_30(v35) -> (* MarginTop *)
                v4
            | US1_31(v36) -> (* MaxHeight *)
                v4
            | US1_32(v37) -> (* Modal__ *)
                v4
            | US1_33(v38) -> (* OnChange *)
                v4
            | US1_34(v39) -> (* OnClick *)
                v4
            | US1_35(v40) -> (* OnLoad__ *)
                v4
            | US1_36(v41) -> (* Outline *)
                v4
            | US1_37(v42) -> (* OverflowX *)
                v4
            | US1_38(v43) -> (* OverflowY *)
                v4
            | US1_39(v44) -> (* Padding *)
                v4
            | US1_40(v45) -> (* PaddingBottom *)
                v4
            | US1_41(v46) -> (* PaddingLeft *)
                v4
            | US1_42(v47) -> (* PaddingRight *)
                v4
            | US1_43(v48) -> (* PaddingTop *)
                v4
            | US1_44(v49) -> (* Position *)
                v4
            | US1_45(v50) -> (* Right *)
                v4
            | US1_46(v51) -> (* Size *)
                v4
            | US1_47(v52) -> (* Spacing *)
                v4
            | US1_48(v53) -> (* Status *)
                US4_1(v53)
            | US1_49(v55) -> (* Striped *)
                v4
            | US1_50(v56) -> (* Thickness *)
                v4
            | US1_51(v57) -> (* Title *)
                v4
            | US1_52(v58) -> (* Top *)
                v4
            | US1_53(v59) -> (* Width *)
                v4
            | US1_54(v60) -> (* ZIndex *)
                v4
        | US4_1(v62) -> (* Some *)
            v4
    | UH0_1 -> (* Nil *)
        v1
and method18 (v0 : UH0, v1 : US2) : US2 =
    match v0 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : US2 = method18(v3, v1)
        match v4 with
        | US2_0 -> (* None *)
            match v2 with
            | US1_0(v5) -> (* AriaLabel *)
                v4
            | US1_1(v6) -> (* As *)
                v4
            | US1_2(v7) -> (* BackgroundColor *)
                v4
            | US1_3(v8) -> (* Border *)
                v4
            | US1_4(v9) -> (* BorderBottomWidth *)
                v4
            | US1_5(v10) -> (* BorderColor *)
                v4
            | US1_6(v11) -> (* BorderWidth *)
                v4
            | US1_7(v12) -> (* Bottom *)
                v4
            | US1_8(v13) -> (* Checked *)
                v4
            | US1_9(v14) -> (* Children *)
                v4
            | US1_10(v15) -> (* Color *)
                v4
            | US1_11(v16) -> (* ColorScheme *)
                v4
            | US1_12(v17) -> (* Compact *)
                v4
            | US1_13(v18) -> (* Direction *)
                v4
            | US1_14(v19) -> (* Display *)
                v4
            | US1_15(v20) -> (* External *)
                v4
            | US1_16(v21) -> (* Flex *)
                v4
            | US1_17(v22) -> (* FlexDirection *)
                v4
            | US1_18(v23) -> (* FontSize *)
                v4
            | US1_19(v24) -> (* Height *)
                v4
            | US1_20(v25) -> (* Href *)
                v4
            | US1_21(v26) -> (* Icon *)
                v4
            | US1_22(v27) -> (* Id *)
                US2_1(v27)
            | US1_23(v29) -> (* JustifyContent *)
                v4
            | US1_24(v30) -> (* Left *)
                v4
            | US1_25(v31) -> (* LeftIcon *)
                v4
            | US1_26(v32) -> (* LineHeight *)
                v4
            | US1_27(v33) -> (* Loaded__ *)
                v4
            | US1_28(v34) -> (* Margin *)
                v4
            | US1_29(v35) -> (* MarginBottom *)
                v4
            | US1_30(v36) -> (* MarginTop *)
                v4
            | US1_31(v37) -> (* MaxHeight *)
                v4
            | US1_32(v38) -> (* Modal__ *)
                v4
            | US1_33(v39) -> (* OnChange *)
                v4
            | US1_34(v40) -> (* OnClick *)
                v4
            | US1_35(v41) -> (* OnLoad__ *)
                v4
            | US1_36(v42) -> (* Outline *)
                v4
            | US1_37(v43) -> (* OverflowX *)
                v4
            | US1_38(v44) -> (* OverflowY *)
                v4
            | US1_39(v45) -> (* Padding *)
                v4
            | US1_40(v46) -> (* PaddingBottom *)
                v4
            | US1_41(v47) -> (* PaddingLeft *)
                v4
            | US1_42(v48) -> (* PaddingRight *)
                v4
            | US1_43(v49) -> (* PaddingTop *)
                v4
            | US1_44(v50) -> (* Position *)
                v4
            | US1_45(v51) -> (* Right *)
                v4
            | US1_46(v52) -> (* Size *)
                v4
            | US1_47(v53) -> (* Spacing *)
                v4
            | US1_48(v54) -> (* Status *)
                v4
            | US1_49(v55) -> (* Striped *)
                v4
            | US1_50(v56) -> (* Thickness *)
                v4
            | US1_51(v57) -> (* Title *)
                v4
            | US1_52(v58) -> (* Top *)
                v4
            | US1_53(v59) -> (* Width *)
                v4
            | US1_54(v60) -> (* ZIndex *)
                v4
        | US2_1(v62) -> (* Some *)
            v4
    | UH0_1 -> (* Nil *)
        v1
and method19 (v0 : UH0, v1 : US5) : US5 =
    match v0 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : US5 = method19(v3, v1)
        match v4 with
        | US5_0 -> (* None *)
            match v2 with
            | US1_0(v5) -> (* AriaLabel *)
                v4
            | US1_1(v6) -> (* As *)
                v4
            | US1_2(v7) -> (* BackgroundColor *)
                v4
            | US1_3(v8) -> (* Border *)
                v4
            | US1_4(v9) -> (* BorderBottomWidth *)
                v4
            | US1_5(v10) -> (* BorderColor *)
                v4
            | US1_6(v11) -> (* BorderWidth *)
                v4
            | US1_7(v12) -> (* Bottom *)
                v4
            | US1_8(v13) -> (* Checked *)
                v4
            | US1_9(v14) -> (* Children *)
                v4
            | US1_10(v15) -> (* Color *)
                v4
            | US1_11(v16) -> (* ColorScheme *)
                v4
            | US1_12(v17) -> (* Compact *)
                v4
            | US1_13(v18) -> (* Direction *)
                v4
            | US1_14(v19) -> (* Display *)
                v4
            | US1_15(v20) -> (* External *)
                v4
            | US1_16(v21) -> (* Flex *)
                v4
            | US1_17(v22) -> (* FlexDirection *)
                v4
            | US1_18(v23) -> (* FontSize *)
                v4
            | US1_19(v24) -> (* Height *)
                v4
            | US1_20(v25) -> (* Href *)
                v4
            | US1_21(v26) -> (* Icon *)
                v4
            | US1_22(v27) -> (* Id *)
                v4
            | US1_23(v28) -> (* JustifyContent *)
                v4
            | US1_24(v29) -> (* Left *)
                v4
            | US1_25(v30) -> (* LeftIcon *)
                v4
            | US1_26(v31) -> (* LineHeight *)
                v4
            | US1_27(v32) -> (* Loaded__ *)
                v4
            | US1_28(v33) -> (* Margin *)
                v4
            | US1_29(v34) -> (* MarginBottom *)
                v4
            | US1_30(v35) -> (* MarginTop *)
                v4
            | US1_31(v36) -> (* MaxHeight *)
                v4
            | US1_32(v37) -> (* Modal__ *)
                v4
            | US1_33(v38) -> (* OnChange *)
                v4
            | US1_34(v39) -> (* OnClick *)
                v4
            | US1_35(v40) -> (* OnLoad__ *)
                v4
            | US1_36(v41) -> (* Outline *)
                v4
            | US1_37(v42) -> (* OverflowX *)
                v4
            | US1_38(v43) -> (* OverflowY *)
                v4
            | US1_39(v44) -> (* Padding *)
                v4
            | US1_40(v45) -> (* PaddingBottom *)
                v4
            | US1_41(v46) -> (* PaddingLeft *)
                v4
            | US1_42(v47) -> (* PaddingRight *)
                v4
            | US1_43(v48) -> (* PaddingTop *)
                v4
            | US1_44(v49) -> (* Position *)
                v4
            | US1_45(v50) -> (* Right *)
                v4
            | US1_46(v51) -> (* Size *)
                v4
            | US1_47(v52) -> (* Spacing *)
                v4
            | US1_48(v53) -> (* Status *)
                v4
            | US1_49(v54) -> (* Striped *)
                v4
            | US1_50(v55) -> (* Thickness *)
                v4
            | US1_51(v56) -> (* Title *)
                US5_1(v56)
            | US1_52(v58) -> (* Top *)
                v4
            | US1_53(v59) -> (* Width *)
                v4
            | US1_54(v60) -> (* ZIndex *)
                v4
        | US5_1(v62) -> (* Some *)
            v4
    | UH0_1 -> (* Nil *)
        v1
and closure16 (v0 : JSX.Element) () : (JSX.Element []) =
    [|v0|]
and closure15 (v0 : JSX.Element) () : (JSX.Element []) =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (unit -> (JSX.Element [])) = closure16(v0)
    let v5 : obj = v4
    let v6 : string = "children"
    let v7 : (string * obj) = v6, v5
    let v8 : string = "2px"
    let v9 : obj = v8
    let v10 : string = "paddingTop"
    let v11 : (string * obj) = v10, v9
    let v12 : UH1 = UH1_1
    let v13 : UH1 = UH1_0(v7, v12)
    let v14 : UH1 = UH1_0(v11, v13)
    let v15 : ((string * obj) []) = method5(v14)
    let v16 : obj = createObj v15
    let v17 : UH0 = v16 |> unbox
    let v18 : string = "createComponent"
    let v19 : string = "solid-js"
    let v20 : JS.Function = import v18 v19
    let v21 : JSX.Element = v20.Invoke (v3, v17) |> unbox<JSX.Element>
    [|v21|]
and closure17 (v0 : (bool -> unit)) (v1 : obj) : unit =
    let v2 : bool = v1?target?checked
    v0 v2
    ()
and closure14 (v0 : UH0, v1 : (bool -> unit), v2 : (unit -> bool), v3 : JSX.Element) () : (JSX.Element []) =
    let v5 : US4 = US4_0
    let v6 : US4 = method17(v0, v5)
    let v49 : JSX.Element =
        match v6 with
        | US4_0 -> (* None *)
            v3
        | US4_1(v7) -> (* Some *)
            let v8 : bool = v2 ()
            let v9 : string = "Checkbox"
            let v10 : string = "@hope-ui/solid"
            let v11 : JS.Function = import v9 v10
            let v12 : (unit -> (JSX.Element [])) = closure15(v3)
            let v13 : obj = v12
            let v14 : string = "children"
            let v15 : (string * obj) = v14, v13
            let v16 : (obj -> unit) = closure17(v1)
            let v17 : obj = v16
            let v18 : string = "onChange"
            let v19 : (string * obj) = v18, v17
            let v20 : string = "neutral"
            let v21 : obj = v20
            let v22 : string = "colorScheme"
            let v23 : (string * obj) = v22, v21
            let v24 : obj = v8
            let v25 : string = "checked"
            let v26 : (string * obj) = v25, v24
            let v27 : string = "2px"
            let v28 : obj = v27
            let v29 : string = "marginBottom"
            let v30 : (string * obj) = v29, v28
            let v31 : string = "sm"
            let v32 : obj = v31
            let v33 : string = "size"
            let v34 : (string * obj) = v33, v32
            let v35 : UH1 = UH1_1
            let v36 : UH1 = UH1_0(v15, v35)
            let v37 : UH1 = UH1_0(v19, v36)
            let v38 : UH1 = UH1_0(v23, v37)
            let v39 : UH1 = UH1_0(v26, v38)
            let v40 : UH1 = UH1_0(v30, v39)
            let v41 : UH1 = UH1_0(v34, v40)
            let v42 : ((string * obj) []) = method5(v41)
            let v43 : obj = createObj v42
            let v44 : UH0 = v43 |> unbox
            let v45 : string = "createComponent"
            let v46 : string = "solid-js"
            let v47 : JS.Function = import v45 v46
            let v48 : JSX.Element = v47.Invoke (v11, v44) |> unbox<JSX.Element>
            v48
    [|v49|]
and closure18 () () : (JSX.Element []) =
    let v0 : string = "&nbsp;"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and method20 (v0 : UH0, v1 : US2) : US2 =
    match v0 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : US2 = method20(v3, v1)
        match v4 with
        | US2_0 -> (* None *)
            match v2 with
            | US1_0(v5) -> (* AriaLabel *)
                v4
            | US1_1(v6) -> (* As *)
                v4
            | US1_2(v7) -> (* BackgroundColor *)
                v4
            | US1_3(v8) -> (* Border *)
                v4
            | US1_4(v9) -> (* BorderBottomWidth *)
                v4
            | US1_5(v10) -> (* BorderColor *)
                v4
            | US1_6(v11) -> (* BorderWidth *)
                v4
            | US1_7(v12) -> (* Bottom *)
                v4
            | US1_8(v13) -> (* Checked *)
                v4
            | US1_9(v14) -> (* Children *)
                v4
            | US1_10(v15) -> (* Color *)
                v4
            | US1_11(v16) -> (* ColorScheme *)
                v4
            | US1_12(v17) -> (* Compact *)
                v4
            | US1_13(v18) -> (* Direction *)
                v4
            | US1_14(v19) -> (* Display *)
                v4
            | US1_15(v20) -> (* External *)
                v4
            | US1_16(v21) -> (* Flex *)
                v4
            | US1_17(v22) -> (* FlexDirection *)
                v4
            | US1_18(v23) -> (* FontSize *)
                v4
            | US1_19(v24) -> (* Height *)
                v4
            | US1_20(v25) -> (* Href *)
                v4
            | US1_21(v26) -> (* Icon *)
                v4
            | US1_22(v27) -> (* Id *)
                v4
            | US1_23(v28) -> (* JustifyContent *)
                v4
            | US1_24(v29) -> (* Left *)
                v4
            | US1_25(v30) -> (* LeftIcon *)
                v4
            | US1_26(v31) -> (* LineHeight *)
                v4
            | US1_27(v32) -> (* Loaded__ *)
                v4
            | US1_28(v33) -> (* Margin *)
                v4
            | US1_29(v34) -> (* MarginBottom *)
                v4
            | US1_30(v35) -> (* MarginTop *)
                v4
            | US1_31(v36) -> (* MaxHeight *)
                v4
            | US1_32(v37) -> (* Modal__ *)
                v4
            | US1_33(v38) -> (* OnChange *)
                v4
            | US1_34(v39) -> (* OnClick *)
                v4
            | US1_35(v40) -> (* OnLoad__ *)
                v4
            | US1_36(v41) -> (* Outline *)
                v4
            | US1_37(v42) -> (* OverflowX *)
                v4
            | US1_38(v43) -> (* OverflowY *)
                v4
            | US1_39(v44) -> (* Padding *)
                US2_1(v44)
            | US1_40(v46) -> (* PaddingBottom *)
                v4
            | US1_41(v47) -> (* PaddingLeft *)
                v4
            | US1_42(v48) -> (* PaddingRight *)
                v4
            | US1_43(v49) -> (* PaddingTop *)
                v4
            | US1_44(v50) -> (* Position *)
                v4
            | US1_45(v51) -> (* Right *)
                v4
            | US1_46(v52) -> (* Size *)
                v4
            | US1_47(v53) -> (* Spacing *)
                v4
            | US1_48(v54) -> (* Status *)
                v4
            | US1_49(v55) -> (* Striped *)
                v4
            | US1_50(v56) -> (* Thickness *)
                v4
            | US1_51(v57) -> (* Title *)
                v4
            | US1_52(v58) -> (* Top *)
                v4
            | US1_53(v59) -> (* Width *)
                v4
            | US1_54(v60) -> (* ZIndex *)
                v4
        | US2_1(v62) -> (* Some *)
            v4
    | UH0_1 -> (* Nil *)
        v1
and method21 (v0 : UH0, v1 : US6) : US6 =
    match v0 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : US6 = method21(v3, v1)
        match v4 with
        | US6_0 -> (* None *)
            match v2 with
            | US1_0(v5) -> (* AriaLabel *)
                v4
            | US1_1(v6) -> (* As *)
                v4
            | US1_2(v7) -> (* BackgroundColor *)
                v4
            | US1_3(v8) -> (* Border *)
                v4
            | US1_4(v9) -> (* BorderBottomWidth *)
                v4
            | US1_5(v10) -> (* BorderColor *)
                v4
            | US1_6(v11) -> (* BorderWidth *)
                v4
            | US1_7(v12) -> (* Bottom *)
                v4
            | US1_8(v13) -> (* Checked *)
                v4
            | US1_9(v14) -> (* Children *)
                v4
            | US1_10(v15) -> (* Color *)
                v4
            | US1_11(v16) -> (* ColorScheme *)
                v4
            | US1_12(v17) -> (* Compact *)
                v4
            | US1_13(v18) -> (* Direction *)
                v4
            | US1_14(v19) -> (* Display *)
                v4
            | US1_15(v20) -> (* External *)
                v4
            | US1_16(v21) -> (* Flex *)
                v4
            | US1_17(v22) -> (* FlexDirection *)
                v4
            | US1_18(v23) -> (* FontSize *)
                v4
            | US1_19(v24) -> (* Height *)
                v4
            | US1_20(v25) -> (* Href *)
                v4
            | US1_21(v26) -> (* Icon *)
                v4
            | US1_22(v27) -> (* Id *)
                v4
            | US1_23(v28) -> (* JustifyContent *)
                v4
            | US1_24(v29) -> (* Left *)
                v4
            | US1_25(v30) -> (* LeftIcon *)
                v4
            | US1_26(v31) -> (* LineHeight *)
                v4
            | US1_27(v32) -> (* Loaded__ *)
                v4
            | US1_28(v33) -> (* Margin *)
                v4
            | US1_29(v34) -> (* MarginBottom *)
                v4
            | US1_30(v35) -> (* MarginTop *)
                v4
            | US1_31(v36) -> (* MaxHeight *)
                v4
            | US1_32(v37) -> (* Modal__ *)
                v4
            | US1_33(v38) -> (* OnChange *)
                v4
            | US1_34(v39) -> (* OnClick *)
                v4
            | US1_35(v40) -> (* OnLoad__ *)
                US6_1(v40)
            | US1_36(v42) -> (* Outline *)
                v4
            | US1_37(v43) -> (* OverflowX *)
                v4
            | US1_38(v44) -> (* OverflowY *)
                v4
            | US1_39(v45) -> (* Padding *)
                v4
            | US1_40(v46) -> (* PaddingBottom *)
                v4
            | US1_41(v47) -> (* PaddingLeft *)
                v4
            | US1_42(v48) -> (* PaddingRight *)
                v4
            | US1_43(v49) -> (* PaddingTop *)
                v4
            | US1_44(v50) -> (* Position *)
                v4
            | US1_45(v51) -> (* Right *)
                v4
            | US1_46(v52) -> (* Size *)
                v4
            | US1_47(v53) -> (* Spacing *)
                v4
            | US1_48(v54) -> (* Status *)
                v4
            | US1_49(v55) -> (* Striped *)
                v4
            | US1_50(v56) -> (* Thickness *)
                v4
            | US1_51(v57) -> (* Title *)
                v4
            | US1_52(v58) -> (* Top *)
                v4
            | US1_53(v59) -> (* Width *)
                v4
            | US1_54(v60) -> (* ZIndex *)
                v4
        | US6_1(v62) -> (* Some *)
            v4
    | UH0_1 -> (* Nil *)
        v1
and method23 (v0 : UH0, v1 : US4) : US4 =
    match v0 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : US4 = method23(v3, v1)
        match v4 with
        | US4_0 -> (* None *)
            match v2 with
            | US1_0(v5) -> (* AriaLabel *)
                v4
            | US1_1(v6) -> (* As *)
                v4
            | US1_2(v7) -> (* BackgroundColor *)
                v4
            | US1_3(v8) -> (* Border *)
                v4
            | US1_4(v9) -> (* BorderBottomWidth *)
                v4
            | US1_5(v10) -> (* BorderColor *)
                v4
            | US1_6(v11) -> (* BorderWidth *)
                v4
            | US1_7(v12) -> (* Bottom *)
                v4
            | US1_8(v13) -> (* Checked *)
                v4
            | US1_9(v14) -> (* Children *)
                v4
            | US1_10(v15) -> (* Color *)
                v4
            | US1_11(v16) -> (* ColorScheme *)
                v4
            | US1_12(v17) -> (* Compact *)
                v4
            | US1_13(v18) -> (* Direction *)
                v4
            | US1_14(v19) -> (* Display *)
                v4
            | US1_15(v20) -> (* External *)
                v4
            | US1_16(v21) -> (* Flex *)
                v4
            | US1_17(v22) -> (* FlexDirection *)
                v4
            | US1_18(v23) -> (* FontSize *)
                v4
            | US1_19(v24) -> (* Height *)
                v4
            | US1_20(v25) -> (* Href *)
                v4
            | US1_21(v26) -> (* Icon *)
                v4
            | US1_22(v27) -> (* Id *)
                v4
            | US1_23(v28) -> (* JustifyContent *)
                v4
            | US1_24(v29) -> (* Left *)
                v4
            | US1_25(v30) -> (* LeftIcon *)
                v4
            | US1_26(v31) -> (* LineHeight *)
                v4
            | US1_27(v32) -> (* Loaded__ *)
                US4_1(v32)
            | US1_28(v34) -> (* Margin *)
                v4
            | US1_29(v35) -> (* MarginBottom *)
                v4
            | US1_30(v36) -> (* MarginTop *)
                v4
            | US1_31(v37) -> (* MaxHeight *)
                v4
            | US1_32(v38) -> (* Modal__ *)
                v4
            | US1_33(v39) -> (* OnChange *)
                v4
            | US1_34(v40) -> (* OnClick *)
                v4
            | US1_35(v41) -> (* OnLoad__ *)
                v4
            | US1_36(v42) -> (* Outline *)
                v4
            | US1_37(v43) -> (* OverflowX *)
                v4
            | US1_38(v44) -> (* OverflowY *)
                v4
            | US1_39(v45) -> (* Padding *)
                v4
            | US1_40(v46) -> (* PaddingBottom *)
                v4
            | US1_41(v47) -> (* PaddingLeft *)
                v4
            | US1_42(v48) -> (* PaddingRight *)
                v4
            | US1_43(v49) -> (* PaddingTop *)
                v4
            | US1_44(v50) -> (* Position *)
                v4
            | US1_45(v51) -> (* Right *)
                v4
            | US1_46(v52) -> (* Size *)
                v4
            | US1_47(v53) -> (* Spacing *)
                v4
            | US1_48(v54) -> (* Status *)
                v4
            | US1_49(v55) -> (* Striped *)
                v4
            | US1_50(v56) -> (* Thickness *)
                v4
            | US1_51(v57) -> (* Title *)
                v4
            | US1_52(v58) -> (* Top *)
                v4
            | US1_53(v59) -> (* Width *)
                v4
            | US1_54(v60) -> (* ZIndex *)
                v4
        | US4_1(v62) -> (* Some *)
            v4
    | UH0_1 -> (* Nil *)
        v1
and method24 (v0 : UH0, v1 : US4) : US4 =
    match v0 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : US4 = method24(v3, v1)
        match v4 with
        | US4_0 -> (* None *)
            match v2 with
            | US1_0(v5) -> (* AriaLabel *)
                v4
            | US1_1(v6) -> (* As *)
                v4
            | US1_2(v7) -> (* BackgroundColor *)
                v4
            | US1_3(v8) -> (* Border *)
                v4
            | US1_4(v9) -> (* BorderBottomWidth *)
                v4
            | US1_5(v10) -> (* BorderColor *)
                v4
            | US1_6(v11) -> (* BorderWidth *)
                v4
            | US1_7(v12) -> (* Bottom *)
                v4
            | US1_8(v13) -> (* Checked *)
                v4
            | US1_9(v14) -> (* Children *)
                v4
            | US1_10(v15) -> (* Color *)
                v4
            | US1_11(v16) -> (* ColorScheme *)
                v4
            | US1_12(v17) -> (* Compact *)
                v4
            | US1_13(v18) -> (* Direction *)
                v4
            | US1_14(v19) -> (* Display *)
                v4
            | US1_15(v20) -> (* External *)
                v4
            | US1_16(v21) -> (* Flex *)
                v4
            | US1_17(v22) -> (* FlexDirection *)
                v4
            | US1_18(v23) -> (* FontSize *)
                v4
            | US1_19(v24) -> (* Height *)
                v4
            | US1_20(v25) -> (* Href *)
                v4
            | US1_21(v26) -> (* Icon *)
                v4
            | US1_22(v27) -> (* Id *)
                v4
            | US1_23(v28) -> (* JustifyContent *)
                v4
            | US1_24(v29) -> (* Left *)
                v4
            | US1_25(v30) -> (* LeftIcon *)
                v4
            | US1_26(v31) -> (* LineHeight *)
                v4
            | US1_27(v32) -> (* Loaded__ *)
                v4
            | US1_28(v33) -> (* Margin *)
                v4
            | US1_29(v34) -> (* MarginBottom *)
                v4
            | US1_30(v35) -> (* MarginTop *)
                v4
            | US1_31(v36) -> (* MaxHeight *)
                v4
            | US1_32(v37) -> (* Modal__ *)
                US4_1(v37)
            | US1_33(v39) -> (* OnChange *)
                v4
            | US1_34(v40) -> (* OnClick *)
                v4
            | US1_35(v41) -> (* OnLoad__ *)
                v4
            | US1_36(v42) -> (* Outline *)
                v4
            | US1_37(v43) -> (* OverflowX *)
                v4
            | US1_38(v44) -> (* OverflowY *)
                v4
            | US1_39(v45) -> (* Padding *)
                v4
            | US1_40(v46) -> (* PaddingBottom *)
                v4
            | US1_41(v47) -> (* PaddingLeft *)
                v4
            | US1_42(v48) -> (* PaddingRight *)
                v4
            | US1_43(v49) -> (* PaddingTop *)
                v4
            | US1_44(v50) -> (* Position *)
                v4
            | US1_45(v51) -> (* Right *)
                v4
            | US1_46(v52) -> (* Size *)
                v4
            | US1_47(v53) -> (* Spacing *)
                v4
            | US1_48(v54) -> (* Status *)
                v4
            | US1_49(v55) -> (* Striped *)
                v4
            | US1_50(v56) -> (* Thickness *)
                v4
            | US1_51(v57) -> (* Title *)
                v4
            | US1_52(v58) -> (* Top *)
                v4
            | US1_53(v59) -> (* Width *)
                v4
            | US1_54(v60) -> (* ZIndex *)
                v4
        | US4_1(v62) -> (* Some *)
            v4
    | UH0_1 -> (* Nil *)
        v1
and closure21 (v0 : (unit -> bool)) () : (bool []) =
    let v1 : bool = v0 ()
    [|v1|]
and closure22 (v0 : (bool -> unit), v1 : (unit -> bool)) () : unit =
    let v2 : bool = v1 ()
    if v2 then
        v0 false
        ()
and closure23 (v0 : JS.Function) (v1 : obj) : unit =
    v0.Invoke ("set", v1) |> unbox
    ()
and closure26 (v0 : (bool -> unit), v1 : UH0, v2 : JS.Function, v3 : obj) () : unit =
    let v5 : US6 = US6_0
    let v6 : US6 = method21(v1, v5)
    match v6 with
    | US6_0 -> (* None *)
        ()
    | US6_1(v7) -> (* Some *)
        let v8 : ((obj -> unit) -> unit) = v7 v3
        let v9 : (obj -> unit) = closure23(v2)
        v8 v9
        ()
    v0 true
    ()
and closure27 () () : (JSX.Element []) =
    let v0 : string = "Load"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure25 (v0 : (bool -> unit), v1 : UH0, v2 : JS.Function, v3 : obj) () : (JSX.Element []) =
    let v4 : string = "createComponent"
    let v5 : string = "solid-js"
    let v6 : JS.Function = import v4 v5
    let v7 : (UH0 -> JSX.Element) = closure1()
    let v8 : (unit -> unit) = closure26(v0, v1, v2, v3)
    let v9 : US1 = US1_34(v8)
    let v10 : (unit -> (JSX.Element [])) = closure27()
    let v11 : US1 = US1_9(v10)
    let v12 : UH0 = UH0_1
    let v13 : UH0 = UH0_0(v11, v12)
    let v14 : UH0 = UH0_0(v9, v13)
    let v15 : JSX.Element = v6.Invoke (v7, v14) |> unbox<JSX.Element>
    [|v15|]
and closure31 (v0 : (bool -> unit)) () : unit =
    v0 true
    ()
and closure32 () (v0 : UH0) : JSX.Element =
    let v1 : string = "BiRegularDownArrow"
    let v2 : string = "solid-icons/bi"
    let v3 : JS.Function = import v1 v2
    let v4 : UH1 = UH1_1
    let v5 : UH1 = method4(v0, v4)
    let v6 : ((string * obj) []) = method5(v5)
    let v7 : obj = createObj v6
    let v8 : UH0 = v7 |> unbox
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : JSX.Element = v11.Invoke (v3, v8) |> unbox<JSX.Element>
    v12
and closure33 () (v0 : UH0) : JSX.Element =
    let v1 : string = "BiRegularUpArrow"
    let v2 : string = "solid-icons/bi"
    let v3 : JS.Function = import v1 v2
    let v4 : UH1 = UH1_1
    let v5 : UH1 = method4(v0, v4)
    let v6 : ((string * obj) []) = method5(v5)
    let v7 : obj = createObj v6
    let v8 : UH0 = v7 |> unbox
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : JSX.Element = v11.Invoke (v3, v8) |> unbox<JSX.Element>
    v12
and method26 (v0 : string, v1 : US0) : US7 =
    match v1 with
    | US0_0 -> (* None *)
        US7_0
    | US0_1(v3) -> (* Some *)
        let v4 : (string * obj) = v0, v3
        US7_1(v4)
and method27 (v0 : int32, v1 : Mut2) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method28 (v0 : int32, v1 : Mut3) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method25 (v0 : US0) : ((string * obj) []) =
    let v1 : string = "ui_modal"
    let v2 : US7 = method26(v1, v0)
    let v3 : (US7 []) = [|v2|]
    let v4 : int32 = v3.Length
    let v5 : (US7 []) = Array.zeroCreate<US7> (v4)
    let v6 : Mut2 = {l0 = 0; l1 = 0} : Mut2
    while method27(v4, v6) do
        let v8 : int32 = v6.l0
        let v9 : int32 = v6.l1
        let v10 : US7 = v3.[int v8]
        let v12 : bool =
            match v10 with
            | US7_0 -> (* None *)
                false
            | US7_1(v11) -> (* Some *)
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
    let v17 : (US7 []) = Array.zeroCreate<US7> (v16)
    let v18 : Mut3 = {l0 = 0} : Mut3
    while method28(v16, v18) do
        let v20 : int32 = v18.l0
        let v21 : US7 = v5.[int v20]
        v17.[int v20] <- v21
        let v22 : int32 = v20 + 1
        v18.l0 <- v22
        ()
    let v23 : int32 = v17.Length
    let v24 : ((string * obj) []) = Array.zeroCreate<(string * obj)> (v23)
    let v25 : Mut3 = {l0 = 0} : Mut3
    while method28(v23, v25) do
        let v27 : int32 = v25.l0
        let v28 : US7 = v17.[int v27]
        let v31 : (string * obj) =
            match v28 with
            | US7_0 -> (* None *)
                failwith<(string * obj)> "Option does not have a value."
            | US7_1(v30) -> (* Some *)
                v30
        v24.[int v27] <- v31
        let v32 : int32 = v27 + 1
        v25.l0 <- v32
        ()
    v24
and closure34 (v0 : JS.Function, v1 : int32, v2 : (bool -> unit), v3 : (unit -> bool)) () : unit =
    let v4 : bool = v3 ()
    let v5 : bool = v4 = false
    v2 v5
    let v8 : US0 =
        if v5 then
            US0_1(v1)
        else
            US0_1(-3)
    let v9 : ((string * obj) []) = method25(v8)
    let v10 : obj = createObj v9
    v0.Invoke ("set", v10) |> unbox
    ()
and closure35 (v0 : (bool -> unit)) () : unit =
    v0 false
    ()
and closure30 (v0 : JS.Function, v1 : int32, v2 : (bool -> unit), v3 : (bool -> unit), v4 : (bool -> unit), v5 : (unit -> bool)) () : (JSX.Element []) =
    let v6 : string = "BiRegularRefresh"
    let v7 : string = "solid-icons/bi"
    let v8 : JS.Function = import v6 v7
    let v9 : string = "14px"
    let v10 : obj = v9
    let v11 : string = "size"
    let v12 : (string * obj) = v11, v10
    let v13 : UH1 = UH1_1
    let v14 : UH1 = UH1_0(v12, v13)
    let v15 : ((string * obj) []) = method5(v14)
    let v16 : obj = createObj v15
    let v17 : UH0 = v16 |> unbox
    let v18 : string = "createComponent"
    let v19 : string = "solid-js"
    let v20 : JS.Function = import v18 v19
    let v21 : JSX.Element = v20.Invoke (v8, v17) |> unbox<JSX.Element>
    let v22 : string = "IconButton"
    let v23 : string = "@hope-ui/solid"
    let v24 : JS.Function = import v22 v23
    let v25 : obj = v21
    let v26 : string = "icon"
    let v27 : (string * obj) = v26, v25
    let v28 : (unit -> unit) = closure31(v3)
    let v29 : obj = v28
    let v30 : string = "onClick"
    let v31 : (string * obj) = v30, v29
    let v32 : string = "neutral"
    let v33 : obj = v32
    let v34 : string = "colorScheme"
    let v35 : (string * obj) = v34, v33
    let v36 : string = "20px"
    let v37 : obj = v36
    let v38 : string = "height"
    let v39 : (string * obj) = v38, v37
    let v40 : string = "xs"
    let v41 : obj = v40
    let v42 : (string * obj) = v11, v41
    let v43 : string = "Refresh"
    let v44 : obj = v43
    let v45 : string = "aria-label"
    let v46 : (string * obj) = v45, v44
    let v47 : UH1 = UH1_1
    let v48 : UH1 = UH1_0(v27, v47)
    let v49 : UH1 = UH1_0(v31, v48)
    let v50 : UH1 = UH1_0(v35, v49)
    let v51 : UH1 = UH1_0(v39, v50)
    let v52 : UH1 = UH1_0(v42, v51)
    let v53 : UH1 = UH1_0(v46, v52)
    let v54 : ((string * obj) []) = method5(v53)
    let v55 : obj = createObj v54
    let v56 : UH0 = v55 |> unbox
    let v57 : JS.Function = import v18 v19
    let v58 : JSX.Element = v57.Invoke (v24, v56) |> unbox<JSX.Element>
    let v59 : bool = v5 ()
    let v62 : string =
        if v59 then
            let v60 : string = "Restore"
            v60
        else
            let v61 : string = "Maximize"
            v61
    let v63 : bool = v5 ()
    let v66 : (UH0 -> JSX.Element) =
        if v63 then
            closure32()
        else
            closure33()
    let v67 : US1 = US1_46(v9)
    let v68 : UH0 = UH0_1
    let v69 : UH0 = UH0_0(v67, v68)
    let v70 : JSX.Element = v66 v69
    let v71 : JS.Function = import v22 v23
    let v72 : obj = v70
    let v73 : (string * obj) = v26, v72
    let v74 : (unit -> unit) = closure34(v0, v1, v4, v5)
    let v75 : obj = v74
    let v76 : (string * obj) = v30, v75
    let v77 : obj = v32
    let v78 : (string * obj) = v34, v77
    let v79 : obj = v36
    let v80 : (string * obj) = v38, v79
    let v81 : obj = v40
    let v82 : (string * obj) = v11, v81
    let v83 : obj = v62
    let v84 : (string * obj) = v45, v83
    let v85 : UH1 = UH1_1
    let v86 : UH1 = UH1_0(v73, v85)
    let v87 : UH1 = UH1_0(v76, v86)
    let v88 : UH1 = UH1_0(v78, v87)
    let v89 : UH1 = UH1_0(v80, v88)
    let v90 : UH1 = UH1_0(v82, v89)
    let v91 : UH1 = UH1_0(v84, v90)
    let v92 : ((string * obj) []) = method5(v91)
    let v93 : obj = createObj v92
    let v94 : UH0 = v93 |> unbox
    let v95 : JS.Function = import v18 v19
    let v96 : JSX.Element = v95.Invoke (v71, v94) |> unbox<JSX.Element>
    let v97 : string = "BiRegularUndo"
    let v98 : JS.Function = import v97 v7
    let v99 : obj = v9
    let v100 : (string * obj) = v11, v99
    let v101 : UH1 = UH1_1
    let v102 : UH1 = UH1_0(v100, v101)
    let v103 : ((string * obj) []) = method5(v102)
    let v104 : obj = createObj v103
    let v105 : UH0 = v104 |> unbox
    let v106 : JS.Function = import v18 v19
    let v107 : JSX.Element = v106.Invoke (v98, v105) |> unbox<JSX.Element>
    let v108 : JS.Function = import v22 v23
    let v109 : obj = v107
    let v110 : (string * obj) = v26, v109
    let v111 : (unit -> unit) = closure35(v2)
    let v112 : obj = v111
    let v113 : (string * obj) = v30, v112
    let v114 : obj = v32
    let v115 : (string * obj) = v34, v114
    let v116 : obj = v36
    let v117 : (string * obj) = v38, v116
    let v118 : obj = v40
    let v119 : (string * obj) = v11, v118
    let v120 : string = "Unload"
    let v121 : obj = v120
    let v122 : (string * obj) = v45, v121
    let v123 : UH1 = UH1_1
    let v124 : UH1 = UH1_0(v110, v123)
    let v125 : UH1 = UH1_0(v113, v124)
    let v126 : UH1 = UH1_0(v115, v125)
    let v127 : UH1 = UH1_0(v117, v126)
    let v128 : UH1 = UH1_0(v119, v127)
    let v129 : UH1 = UH1_0(v122, v128)
    let v130 : ((string * obj) []) = method5(v129)
    let v131 : obj = createObj v130
    let v132 : UH0 = v131 |> unbox
    let v133 : JS.Function = import v18 v19
    let v134 : JSX.Element = v133.Invoke (v108, v132) |> unbox<JSX.Element>
    [|v58; v96; v134|]
and closure29 (v0 : JS.Function, v1 : obj, v2 : int32, v3 : (bool -> unit), v4 : (bool -> unit), v5 : (unit -> bool), v6 : (bool -> unit), v7 : (unit -> bool), v8 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v9 : int32 = match v1?ui_modal with x when x = JS.undefined -> -2 | x -> x
    let v10 : bool = v9 > 0
    let v13 : bool =
        if v10 then
            let v11 : bool = v9 = v2
            let v12 : bool = v11 <> true
            v12
        else
            false
    let v19 : UH0 =
        if v13 then
            let v14 : string = "none"
            let v15 : US1 = US1_14(v14)
            let v16 : UH0 = UH0_1
            UH0_0(v15, v16)
        else
            UH0_1
    let v20 : string = "row"
    let v21 : US1 = US1_13(v20)
    let v22 : string = "3px"
    let v23 : US1 = US1_47(v22)
    let v24 : string = "absolute"
    let v25 : US1 = US1_44(v24)
    let v26 : string = "6px"
    let v27 : US1 = US1_52(v26)
    let v28 : US1 = US1_45(v26)
    let v29 : int32 = 1
    let v30 : US1 = US1_54(v29)
    let v31 : (unit -> (JSX.Element [])) = closure30(v0, v2, v3, v4, v6, v7)
    let v32 : US1 = US1_9(v31)
    let v33 : UH0 = UH0_1
    let v34 : UH0 = UH0_0(v32, v33)
    let v35 : UH0 = UH0_0(v30, v34)
    let v36 : UH0 = UH0_0(v28, v35)
    let v37 : UH0 = UH0_0(v27, v36)
    let v38 : UH0 = UH0_0(v25, v37)
    let v39 : UH0 = UH0_0(v23, v38)
    let v40 : UH0 = UH0_0(v21, v39)
    let v41 : UH0 = method3(v19, v40)
    let v42 : string = "Stack"
    let v43 : string = "@hope-ui/solid"
    let v44 : JS.Function = import v42 v43
    let v45 : UH1 = UH1_1
    let v46 : UH1 = method4(v41, v45)
    let v47 : ((string * obj) []) = method5(v46)
    let v48 : obj = createObj v47
    let v49 : UH0 = v48 |> unbox
    let v50 : string = "createComponent"
    let v51 : string = "solid-js"
    let v52 : JS.Function = import v50 v51
    let v53 : JSX.Element = v52.Invoke (v44, v49) |> unbox<JSX.Element>
    let v54 : bool = v5 ()
    let v57 : JSX.Element =
        if v54 then
            let v55 : JSX.Element = Html.fragment []
            v55
        else
            let v56 : JSX.Element = v8 |> unbox<JSX.Element>
            v56
    [|v53; v57|]
and closure28 (v0 : UH0, v1 : JS.Function, v2 : obj, v3 : int32, v4 : (bool -> unit), v5 : (bool -> unit), v6 : (unit -> bool), v7 : (bool -> unit), v8 : (unit -> bool)) () : (JSX.Element []) =
    let v10 : US3 = US3_0
    let v11 : US3 = method10(v0, v10)
    let v45 : JSX.Element =
        match v11 with
        | US3_0 -> (* None *)
            let v12 : JSX.Element = Html.fragment []
            v12
        | US3_1(v13) -> (* Some *)
            let v14 : int32 = match v2?ui_modal with x when x = JS.undefined -> -2 | x -> x
            let v15 : bool = v14 <= 0
            let v21 : UH0 =
                if v15 then
                    let v16 : string = "relative"
                    let v17 : US1 = US1_44(v16)
                    let v18 : UH0 = UH0_1
                    UH0_0(v17, v18)
                else
                    UH0_1
            let v22 : string = "1"
            let v23 : US1 = US1_16(v22)
            let v24 : string = "flex"
            let v25 : US1 = US1_14(v24)
            let v26 : (unit -> (JSX.Element [])) = closure29(v1, v2, v3, v4, v5, v6, v7, v8, v13)
            let v27 : US1 = US1_9(v26)
            let v28 : UH0 = UH0_1
            let v29 : UH0 = UH0_0(v27, v28)
            let v30 : UH0 = UH0_0(v25, v29)
            let v31 : UH0 = UH0_0(v23, v30)
            let v32 : UH0 = method3(v21, v31)
            let v33 : string = "Box"
            let v34 : string = "@hope-ui/solid"
            let v35 : JS.Function = import v33 v34
            let v36 : UH1 = UH1_1
            let v37 : UH1 = method4(v32, v36)
            let v38 : ((string * obj) []) = method5(v37)
            let v39 : obj = createObj v38
            let v40 : UH0 = v39 |> unbox
            let v41 : string = "createComponent"
            let v42 : string = "solid-js"
            let v43 : JS.Function = import v41 v42
            let v44 : JSX.Element = v43.Invoke (v35, v40) |> unbox<JSX.Element>
            v44
    [|v45|]
and closure24 (v0 : UH0, v1 : JS.Function, v2 : obj, v3 : int32, v4 : (bool -> unit), v5 : (unit -> bool), v6 : (bool -> unit), v7 : (unit -> bool), v8 : (bool -> unit), v9 : (unit -> bool)) () : (JSX.Element []) =
    let v10 : bool = v5 ()
    let v11 : bool = v10 = false
    let v77 : JSX.Element =
        if v11 then
            let v12 : string = "Box"
            let v13 : string = "@hope-ui/solid"
            let v14 : JS.Function = import v12 v13
            let v15 : (unit -> (JSX.Element [])) = closure25(v4, v0, v1, v2)
            let v16 : obj = v15
            let v17 : string = "children"
            let v18 : (string * obj) = v17, v16
            let v19 : string = "4px 0"
            let v20 : obj = v19
            let v21 : string = "padding"
            let v22 : (string * obj) = v21, v20
            let v23 : UH1 = UH1_1
            let v24 : UH1 = UH1_0(v18, v23)
            let v25 : UH1 = UH1_0(v22, v24)
            let v26 : ((string * obj) []) = method5(v25)
            let v27 : obj = createObj v26
            let v28 : UH0 = v27 |> unbox
            let v29 : string = "createComponent"
            let v30 : string = "solid-js"
            let v31 : JS.Function = import v29 v30
            let v32 : JSX.Element = v31.Invoke (v14, v28) |> unbox<JSX.Element>
            v32
        else
            let v33 : bool = v9 ()
            let v53 : UH0 =
                if v33 then
                    let v34 : US1 = US1_54(1)
                    let v35 : string = "absolute"
                    let v36 : US1 = US1_44(v35)
                    let v37 : string = "0"
                    let v38 : US1 = US1_52(v37)
                    let v39 : US1 = US1_45(v37)
                    let v40 : US1 = US1_7(v37)
                    let v41 : US1 = US1_24(v37)
                    let v42 : string = "$bg"
                    let v43 : US1 = US1_2(v42)
                    let v44 : UH0 = UH0_1
                    let v45 : UH0 = UH0_0(v43, v44)
                    let v46 : UH0 = UH0_0(v41, v45)
                    let v47 : UH0 = UH0_0(v40, v46)
                    let v48 : UH0 = UH0_0(v39, v47)
                    let v49 : UH0 = UH0_0(v38, v48)
                    let v50 : UH0 = UH0_0(v36, v49)
                    UH0_0(v34, v50)
                else
                    UH0_1
            let v54 : string = "flex"
            let v55 : US1 = US1_14(v54)
            let v56 : string = "1"
            let v57 : US1 = US1_16(v56)
            let v58 : (unit -> (JSX.Element [])) = closure28(v0, v1, v2, v3, v4, v6, v7, v8, v9)
            let v59 : US1 = US1_9(v58)
            let v60 : UH0 = UH0_1
            let v61 : UH0 = UH0_0(v59, v60)
            let v62 : UH0 = UH0_0(v57, v61)
            let v63 : UH0 = UH0_0(v55, v62)
            let v64 : UH0 = method3(v53, v63)
            let v65 : string = "Box"
            let v66 : string = "@hope-ui/solid"
            let v67 : JS.Function = import v65 v66
            let v68 : UH1 = UH1_1
            let v69 : UH1 = method4(v64, v68)
            let v70 : ((string * obj) []) = method5(v69)
            let v71 : obj = createObj v70
            let v72 : UH0 = v71 |> unbox
            let v73 : string = "createComponent"
            let v74 : string = "solid-js"
            let v75 : JS.Function = import v73 v74
            let v76 : JSX.Element = v75.Invoke (v67, v72) |> unbox<JSX.Element>
            v76
    [|v77|]
and method22 (v0 : UH0) : JSX.Element =
    let v1 : string = "useStoreon"
    let v2 : string = "@storeon/solidjs"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke () |> unbox<JS.Function[]>
    let v5 : obj = v4.[0] |> unbox
    let v6 : JS.Function = v4.[1] |> unbox
    let v7 : int32 = Random().Next ()
    let v9 : US4 = US4_0
    let v10 : US4 = method23(v0, v9)
    let v12 : bool =
        match v10 with
        | US4_0 -> (* None *)
            false
        | US4_1(v11) -> (* Some *)
            v11
    let v13 : string = "createSignal"
    let v14 : string = "solid-js"
    let v15 : JS.Function = import v13 v14
    let v16 : (JS.Function []) = v15.Invoke v12 |> unbox<JS.Function[]>
    let v17 : (unit -> bool) = v16.[0] |> unbox
    let v18 : (bool -> unit) = v16.[1] |> unbox
    let v19 : JS.Function = import v13 v14
    let v20 : (JS.Function []) = v19.Invoke false |> unbox<JS.Function[]>
    let v21 : (unit -> bool) = v20.[0] |> unbox
    let v22 : (bool -> unit) = v20.[1] |> unbox
    let v24 : US4 = US4_0
    let v25 : US4 = method24(v0, v24)
    let v27 : bool =
        match v25 with
        | US4_0 -> (* None *)
            false
        | US4_1(v26) -> (* Some *)
            v26
    let v28 : JS.Function = import v13 v14
    let v29 : (JS.Function []) = v28.Invoke v27 |> unbox<JS.Function[]>
    let v30 : (unit -> bool) = v29.[0] |> unbox
    let v31 : (bool -> unit) = v29.[1] |> unbox
    let v32 : string = "on"
    let v33 : JS.Function = import v32 v14
    let v34 : (unit -> (bool [])) = closure21(v21)
    let v35 : (unit -> unit) = closure22(v22, v21)
    let v36 : JS.Function = v33.Invoke (v34, v35) |> unbox<JS.Function>
    let v37 : string = "createEffect"
    let v38 : JS.Function = import v37 v14
    v38.Invoke v36 |> ignore
    let v40 : US4 = US4_0
    let v41 : US4 = method23(v0, v40)
    let v45 : bool =
        match v41 with
        | US4_1(v43) -> (* Some *)
            let v44 : bool = v43 = true
            v44
        | _ ->
            false
    if v45 then
        let v47 : US6 = US6_0
        let v48 : US6 = method21(v0, v47)
        match v48 with
        | US6_0 -> (* None *)
            ()
        | US6_1(v49) -> (* Some *)
            let v50 : ((obj -> unit) -> unit) = v49 v5
            let v51 : (obj -> unit) = closure23(v6)
            v50 v51
            ()
    let v53 : US2 = US2_0
    let v54 : US2 = method18(v0, v53)
    let v60 : UH0 =
        match v54 with
        | US2_0 -> (* None *)
            UH0_1
        | US2_1(v56) -> (* Some *)
            let v57 : US1 = US1_22(v56)
            let v58 : UH0 = UH0_1
            UH0_0(v57, v58)
    let v61 : string = "flex"
    let v62 : US1 = US1_14(v61)
    let v63 : string = "1"
    let v64 : US1 = US1_16(v63)
    let v65 : (unit -> (JSX.Element [])) = closure24(v0, v6, v5, v7, v18, v17, v22, v21, v31, v30)
    let v66 : US1 = US1_9(v65)
    let v67 : UH0 = UH0_1
    let v68 : UH0 = UH0_0(v66, v67)
    let v69 : UH0 = UH0_0(v64, v68)
    let v70 : UH0 = UH0_0(v62, v69)
    let v71 : UH0 = method3(v60, v70)
    let v72 : string = "Box"
    let v73 : string = "@hope-ui/solid"
    let v74 : JS.Function = import v72 v73
    let v75 : UH1 = UH1_1
    let v76 : UH1 = method4(v71, v75)
    let v77 : ((string * obj) []) = method5(v76)
    let v78 : obj = createObj v77
    let v79 : UH0 = v78 |> unbox
    let v80 : string = "createComponent"
    let v81 : JS.Function = import v80 v14
    let v82 : JSX.Element = v81.Invoke (v74, v79) |> unbox<JSX.Element>
    v82
and closure20 () (v0 : UH0) : JSX.Element =
    method22(v0)
and closure19 (v0 : UH0, v1 : (unit -> bool), v2 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v4 : US4 = US4_0
    let v5 : US4 = method17(v0, v4)
    let v32 : JSX.Element =
        match v5 with
        | US4_0 -> (* None *)
            let v6 : JSX.Element = v2 |> unbox<JSX.Element>
            v6
        | US4_1(v7) -> (* Some *)
            let v8 : bool = v1 ()
            if v8 then
                let v10 : US6 = US6_0
                let v11 : US6 = method21(v0, v10)
                let v17 : UH0 =
                    match v11 with
                    | US6_0 -> (* None *)
                        UH0_1
                    | US6_1(v13) -> (* Some *)
                        let v14 : US1 = US1_35(v13)
                        let v15 : UH0 = UH0_1
                        UH0_0(v14, v15)
                let v18 : bool = true
                let v19 : US1 = US1_27(v18)
                let v20 : US1 = US1_9(v2)
                let v21 : UH0 = UH0_1
                let v22 : UH0 = UH0_0(v20, v21)
                let v23 : UH0 = UH0_0(v19, v22)
                let v24 : UH0 = method3(v17, v23)
                let v25 : string = "createComponent"
                let v26 : string = "solid-js"
                let v27 : JS.Function = import v25 v26
                let v28 : (UH0 -> JSX.Element) = closure20()
                let v29 : JSX.Element = v27.Invoke (v28, v24) |> unbox<JSX.Element>
                v29
            else
                let v30 : JSX.Element = Html.fragment []
                v30
    [|v32|]
and closure13 (v0 : UH0, v1 : (bool -> unit), v2 : (unit -> bool)) () : (JSX.Element []) =
    let v4 : US5 = US5_0
    let v5 : US5 = method19(v0, v4)
    let v70 : JSX.Element =
        match v5 with
        | US5_0 -> (* None *)
            let v6 : JSX.Element = Html.fragment []
            v6
        | US5_1(v7) -> (* Some *)
            let v9 : US4 = US4_0
            let v10 : US4 = method17(v0, v9)
            let v12 : bool =
                match v10 with
                | US4_0 -> (* None *)
                    true
                | _ ->
                    false
            let v14 : bool =
                if v12 then
                    true
                else
                    let v13 : bool = v2 ()
                    v13
            let v19 : string =
                if v14 then
                    let v15 : string = "2px !important"
                    let v16 : string = "0px !important"
                    let v17 : string = {| ``@initial`` = v15; ``@sm`` = v16 |} |> unbox<string>
                    v17
                else
                    let v18 : string = "0px !important"
                    v18
            let v20 : string = "Td"
            let v21 : string = "@hope-ui/solid"
            let v22 : JS.Function = import v20 v21
            let v23 : (unit -> (JSX.Element [])) = closure14(v0, v1, v2, v7)
            let v24 : obj = v23
            let v25 : string = "children"
            let v26 : (string * obj) = v25, v24
            let v27 : string = "3px 20px 0 8px"
            let v28 : obj = v27
            let v29 : string = "padding"
            let v30 : (string * obj) = v29, v28
            let v31 : string = "$sm"
            let v32 : obj = v31
            let v33 : string = "fontSize"
            let v34 : (string * obj) = v33, v32
            let v35 : string = "column"
            let v36 : obj = v35
            let v37 : string = "flexDirection"
            let v38 : (string * obj) = v37, v36
            let v39 : string = "flex"
            let v40 : obj = v39
            let v41 : string = "display"
            let v42 : (string * obj) = v41, v40
            let v43 : string = "$neutral9"
            let v44 : obj = v43
            let v45 : string = "color"
            let v46 : (string * obj) = v45, v44
            let v47 : string = "$neutral5"
            let v48 : obj = v47
            let v49 : string = "borderColor"
            let v50 : (string * obj) = v49, v48
            let v51 : obj = v19
            let v52 : string = "borderBottomWidth"
            let v53 : (string * obj) = v52, v51
            let v54 : UH1 = UH1_1
            let v55 : UH1 = UH1_0(v26, v54)
            let v56 : UH1 = UH1_0(v30, v55)
            let v57 : UH1 = UH1_0(v34, v56)
            let v58 : UH1 = UH1_0(v38, v57)
            let v59 : UH1 = UH1_0(v42, v58)
            let v60 : UH1 = UH1_0(v46, v59)
            let v61 : UH1 = UH1_0(v50, v60)
            let v62 : UH1 = UH1_0(v53, v61)
            let v63 : ((string * obj) []) = method5(v62)
            let v64 : obj = createObj v63
            let v65 : UH0 = v64 |> unbox
            let v66 : string = "createComponent"
            let v67 : string = "solid-js"
            let v68 : JS.Function = import v66 v67
            let v69 : JSX.Element = v68.Invoke (v22, v65) |> unbox<JSX.Element>
            v69
    let v72 : US3 = US3_0
    let v73 : US3 = method10(v0, v72)
    let v178 : JSX.Element =
        match v73 with
        | US3_0 -> (* None *)
            let v74 : string = "Td"
            let v75 : string = "@hope-ui/solid"
            let v76 : JS.Function = import v74 v75
            let v77 : (unit -> (JSX.Element [])) = closure18()
            let v78 : obj = v77
            let v79 : string = "children"
            let v80 : (string * obj) = v79, v78
            let v81 : string = "9px"
            let v82 : obj = v81
            let v83 : string = "lineHeight"
            let v84 : (string * obj) = v83, v82
            let v85 : string = "0"
            let v86 : obj = v85
            let v87 : string = "padding"
            let v88 : (string * obj) = v87, v86
            let v89 : obj = v85
            let v90 : string = "border"
            let v91 : (string * obj) = v90, v89
            let v92 : UH1 = UH1_1
            let v93 : UH1 = UH1_0(v80, v92)
            let v94 : UH1 = UH1_0(v84, v93)
            let v95 : UH1 = UH1_0(v88, v94)
            let v96 : UH1 = UH1_0(v91, v95)
            let v97 : ((string * obj) []) = method5(v96)
            let v98 : obj = createObj v97
            let v99 : UH0 = v98 |> unbox
            let v100 : string = "createComponent"
            let v101 : string = "solid-js"
            let v102 : JS.Function = import v100 v101
            let v103 : JSX.Element = v102.Invoke (v76, v99) |> unbox<JSX.Element>
            v103
        | US3_1(v104) -> (* Some *)
            let v106 : US2 = US2_0
            let v107 : US2 = method20(v0, v106)
            let v110 : string =
                match v107 with
                | US2_0 -> (* None *)
                    let v108 : string = "0"
                    v108
                | US2_1(v109) -> (* Some *)
                    v109
            let v111 : string = "Td"
            let v112 : string = "@hope-ui/solid"
            let v113 : JS.Function = import v111 v112
            let v114 : (unit -> (JSX.Element [])) = closure19(v0, v2, v104)
            let v115 : obj = v114
            let v116 : string = "children"
            let v117 : (string * obj) = v116, v115
            let v118 : string = "auto"
            let v119 : obj = v118
            let v120 : string = "overflowY"
            let v121 : (string * obj) = v120, v119
            let v122 : string = "85vh"
            let v123 : obj = v122
            let v124 : string = "maxHeight"
            let v125 : (string * obj) = v124, v123
            let v126 : string = "$sm"
            let v127 : obj = v126
            let v128 : string = "fontSize"
            let v129 : (string * obj) = v128, v127
            let v130 : string = "column"
            let v131 : obj = v130
            let v132 : string = "flexDirection"
            let v133 : (string * obj) = v132, v131
            let v134 : string = "$base"
            let v135 : obj = v134
            let v136 : string = "lineHeight"
            let v137 : (string * obj) = v136, v135
            let v138 : string = "6"
            let v139 : obj = v138
            let v140 : string = "flex"
            let v141 : (string * obj) = v140, v139
            let v142 : obj = v140
            let v143 : string = "display"
            let v144 : (string * obj) = v143, v142
            let v145 : obj = v110
            let v146 : string = "padding"
            let v147 : (string * obj) = v146, v145
            let v148 : string = "0"
            let v149 : obj = v148
            let v150 : string = "margin"
            let v151 : (string * obj) = v150, v149
            let v152 : obj = v148
            let v153 : string = "outline"
            let v154 : (string * obj) = v153, v152
            let v155 : obj = v148
            let v156 : string = "border"
            let v157 : (string * obj) = v156, v155
            let v158 : UH1 = UH1_1
            let v159 : UH1 = UH1_0(v117, v158)
            let v160 : UH1 = UH1_0(v121, v159)
            let v161 : UH1 = UH1_0(v125, v160)
            let v162 : UH1 = UH1_0(v129, v161)
            let v163 : UH1 = UH1_0(v133, v162)
            let v164 : UH1 = UH1_0(v137, v163)
            let v165 : UH1 = UH1_0(v141, v164)
            let v166 : UH1 = UH1_0(v144, v165)
            let v167 : UH1 = UH1_0(v147, v166)
            let v168 : UH1 = UH1_0(v151, v167)
            let v169 : UH1 = UH1_0(v154, v168)
            let v170 : UH1 = UH1_0(v157, v169)
            let v171 : ((string * obj) []) = method5(v170)
            let v172 : obj = createObj v171
            let v173 : UH0 = v172 |> unbox
            let v174 : string = "createComponent"
            let v175 : string = "solid-js"
            let v176 : JS.Function = import v174 v175
            let v177 : JSX.Element = v176.Invoke (v113, v173) |> unbox<JSX.Element>
            v177
    [|v70; v178|]
and method16 (v0 : UH0) : JSX.Element =
    let v2 : US4 = US4_0
    let v3 : US4 = method17(v0, v2)
    let v7 : bool =
        match v3 with
        | US4_1(v5) -> (* Some *)
            let v6 : bool = v5 = false
            v6
        | _ ->
            false
    let v8 : bool = v7 <> true
    let v9 : string = "createSignal"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : (JS.Function []) = v11.Invoke v8 |> unbox<JS.Function[]>
    let v13 : (unit -> bool) = v12.[0] |> unbox
    let v14 : (bool -> unit) = v12.[1] |> unbox
    let v16 : US2 = US2_0
    let v17 : US2 = method18(v0, v16)
    let v23 : UH0 =
        match v17 with
        | US2_0 -> (* None *)
            UH0_1
        | US2_1(v19) -> (* Some *)
            let v20 : US1 = US1_22(v19)
            let v21 : UH0 = UH0_1
            UH0_0(v20, v21)
    let v24 : string = "column"
    let v25 : string = "row"
    let v26 : string = {| ``@initial`` = v24; ``@sm`` = v25 |} |> unbox<string>
    let v27 : string = "flex"
    let v28 : US1 = US1_14(v27)
    let v29 : string = "1"
    let v30 : US1 = US1_16(v29)
    let v31 : string = "1px 2px"
    let v32 : US1 = US1_6(v31)
    let v33 : string = "$neutral5"
    let v34 : US1 = US1_5(v33)
    let v35 : US1 = US1_17(v26)
    let v36 : (unit -> (JSX.Element [])) = closure13(v0, v14, v13)
    let v37 : US1 = US1_9(v36)
    let v38 : UH0 = UH0_1
    let v39 : UH0 = UH0_0(v37, v38)
    let v40 : UH0 = UH0_0(v35, v39)
    let v41 : UH0 = UH0_0(v34, v40)
    let v42 : UH0 = UH0_0(v32, v41)
    let v43 : UH0 = UH0_0(v30, v42)
    let v44 : UH0 = UH0_0(v28, v43)
    let v45 : UH0 = method3(v23, v44)
    let v46 : string = "Tr"
    let v47 : string = "@hope-ui/solid"
    let v48 : JS.Function = import v46 v47
    let v49 : UH1 = UH1_1
    let v50 : UH1 = method4(v45, v49)
    let v51 : ((string * obj) []) = method5(v50)
    let v52 : obj = createObj v51
    let v53 : UH0 = v52 |> unbox
    let v54 : string = "createComponent"
    let v55 : JS.Function = import v54 v10
    let v56 : JSX.Element = v55.Invoke (v48, v53) |> unbox<JSX.Element>
    v56
and closure12 () (v0 : UH0) : JSX.Element =
    method16(v0)
and closure36 () () : (JSX.Element []) =
    let v0 : string = "createComponent"
    let v1 : string = "solid-js"
    let v2 : JS.Function = import v0 v1
    let v3 : (UH0 -> JSX.Element) = closure7()
    let v4 : string = "https://github.com/fc1943s/tictactoe_spiral"
    let v5 : US1 = US1_20(v4)
    let v6 : UH0 = UH0_1
    let v7 : UH0 = UH0_0(v5, v6)
    let v8 : JSX.Element = v2.Invoke (v3, v7) |> unbox<JSX.Element>
    [|v8|]
and closure37 () () : (JSX.Element []) =
    let v0 : string = "createComponent"
    let v1 : string = "solid-js"
    let v2 : JS.Function = import v0 v1
    let v3 : (UH0 -> JSX.Element) = closure7()
    let v4 : string = "https://fc1943s.github.io/tictactoe_spiral"
    let v5 : US1 = US1_20(v4)
    let v6 : UH0 = UH0_1
    let v7 : UH0 = UH0_0(v5, v6)
    let v8 : JSX.Element = v2.Invoke (v3, v7) |> unbox<JSX.Element>
    [|v8|]
and closure38 () () : (JSX.Element []) =
    let v0 : string = "createComponent"
    let v1 : string = "solid-js"
    let v2 : JS.Function = import v0 v1
    let v3 : (UH0 -> JSX.Element) = closure7()
    let v4 : string = "https://fc1943s.github.io/tictactoe_spiral/docs"
    let v5 : US1 = US1_20(v4)
    let v6 : UH0 = UH0_1
    let v7 : UH0 = UH0_0(v5, v6)
    let v8 : JSX.Element = v2.Invoke (v3, v7) |> unbox<JSX.Element>
    [|v8|]
and closure11 () () : (JSX.Element []) =
    let v0 : string = "createComponent"
    let v1 : string = "solid-js"
    let v2 : JS.Function = import v0 v1
    let v3 : (UH0 -> JSX.Element) = closure12()
    let v4 : string = "1px 6px"
    let v5 : US1 = US1_39(v4)
    let v6 : (unit -> (JSX.Element [])) = closure36()
    let v7 : US1 = US1_9(v6)
    let v8 : UH0 = UH0_1
    let v9 : UH0 = UH0_0(v7, v8)
    let v10 : UH0 = UH0_0(v5, v9)
    let v11 : JSX.Element = v2.Invoke (v3, v10) |> unbox<JSX.Element>
    let v12 : JS.Function = import v0 v1
    let v13 : US1 = US1_39(v4)
    let v14 : (unit -> (JSX.Element [])) = closure37()
    let v15 : US1 = US1_9(v14)
    let v16 : UH0 = UH0_1
    let v17 : UH0 = UH0_0(v15, v16)
    let v18 : UH0 = UH0_0(v13, v17)
    let v19 : JSX.Element = v12.Invoke (v3, v18) |> unbox<JSX.Element>
    let v20 : JS.Function = import v0 v1
    let v21 : US1 = US1_39(v4)
    let v22 : (unit -> (JSX.Element [])) = closure38()
    let v23 : US1 = US1_9(v22)
    let v24 : UH0 = UH0_1
    let v25 : UH0 = UH0_0(v23, v24)
    let v26 : UH0 = UH0_0(v21, v25)
    let v27 : JSX.Element = v20.Invoke (v3, v26) |> unbox<JSX.Element>
    [|v11; v19; v27|]
and method15 () : JSX.Element =
    let v0 : string = "createComponent"
    let v1 : string = "solid-js"
    let v2 : JS.Function = import v0 v1
    let v3 : (UH0 -> JSX.Element) = closure2()
    let v4 : (unit -> (JSX.Element [])) = closure11()
    let v5 : US1 = US1_9(v4)
    let v6 : UH0 = UH0_1
    let v7 : UH0 = UH0_0(v5, v6)
    let v8 : JSX.Element = v2.Invoke (v3, v7) |> unbox<JSX.Element>
    v8
and closure10 () () : JSX.Element =
    method15()
let v0 : obj = JS.undefined
let v1 : Mut0 = {l0 = v0} : Mut0
let v57 : US0 = method0()
let v58 : Heap0 = {l0 = v57} : Heap0
let v59 : obj = v58
let v60 : obj = method1(v59)
let v61 : string = "base_button"
let v62 : (UH0 -> JSX.Element) = closure1()
let v63 : (string * obj) = v61, v62
let v64 : string = "base_table"
let v65 : (UH0 -> JSX.Element) = closure2()
let v66 : (string * obj) = v64, v65
let v67 : string = "create_obj_props"
let v68 : ((struct (string * obj) []) -> UH0) = closure5()
let v69 : (string * obj) = v67, v68
let v70 : string = "create_storeon"
let v71 : (obj -> obj) = closure6()
let v72 : (string * obj) = v70, v71
let v73 : string = "external_link"
let v74 : (UH0 -> JSX.Element) = closure7()
let v75 : (string * obj) = v73, v74
let v76 : string = "links"
let v77 : (unit -> JSX.Element) = closure10()
let v78 : (string * obj) = v76, v77
let v79 : string = "loader"
let v80 : (UH0 -> JSX.Element) = closure20()
let v81 : (string * obj) = v79, v80
let v82 : string = "row"
let v83 : (UH0 -> JSX.Element) = closure12()
let v84 : (string * obj) = v82, v83
let v85 : string = "store"
let v86 : (string * obj) = v85, v60
let v87 : ((string * obj) []) = [|v63; v66; v69; v72; v75; v78; v81; v84; v86|]
let v88 : obj = createObj v87
v1.l0 <- v88
()
