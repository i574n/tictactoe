#r "nuget: Feliz.JSX.Solid, 1.0.0-beta-002"
#r "nuget: Fable.Promise, 3.2.0"
open System
open Fable.Core
open Fable.Core.JsInterop
open Feliz.JSX.Solid

type Mut0 = {mutable l0 : obj}
and [<Struct>] US1 =
    | US1_0
    | US1_1
and [<Struct>] US0 =
    | US0_0
    | US0_1 of f1_0 : US1
and [<Struct>] US2 =
    | US2_0
    | US2_1
    | US2_2
and [<Struct>] US3 =
    | US3_0
    | US3_1
and [<Struct>] US4 =
    | US4_0
    | US4_1
    | US4_2
    | US4_3
and [<Struct>] US5 =
    | US5_0
    | US5_1 of f1_0 : int32
and [<Struct>] US6 =
    | US6_0
    | US6_1 of f1_0 : string
and [<Struct>] US7 =
    | US7_0
    | US7_1 of f1_0 : JS.Function
and [<Struct>] US8 =
    | US8_0
    | US8_1 of f1_0 : bool
and [<Struct>] US9 =
    | US9_0
    | US9_1 of f1_0 : (unit -> (JSX.Element []))
and [<Struct>] US10 =
    | US10_0
    | US10_1 of f1_0 : obj
and [<Struct>] US11 =
    | US11_0
    | US11_1 of f1_0 : (obj [])
and [<Struct>] US12 =
    | US12_0
    | US12_1 of f1_0 : JSX.Element
and [<Struct>] US13 =
    | US13_0
    | US13_1 of f1_0 : (obj -> unit)
and [<Struct>] US14 =
    | US14_0
    | US14_1 of f1_0 : (unit -> unit)
and Mut1 = {mutable l0 : US6; mutable l1 : US6; mutable l2 : US6; mutable l3 : US7; mutable l4 : US6; mutable l5 : US6; mutable l6 : US6; mutable l7 : US6; mutable l8 : US6; mutable l9 : US6; mutable l10 : US8; mutable l11 : US9; mutable l12 : US6; mutable l13 : US6; mutable l14 : US8; mutable l15 : US10; mutable l16 : US6; mutable l17 : US6; mutable l18 : US6; mutable l19 : US11; mutable l20 : US8; mutable l21 : US6; mutable l22 : US6; mutable l23 : US6; mutable l24 : US6; mutable l25 : US6; mutable l26 : US6; mutable l27 : US12; mutable l28 : US6; mutable l29 : US6; mutable l30 : US6; mutable l31 : US12; mutable l32 : US6; mutable l33 : US6; mutable l34 : US6; mutable l35 : US6; mutable l36 : US6; mutable l37 : US6; mutable l38 : US6; mutable l39 : US6; mutable l40 : US6; mutable l41 : US6; mutable l42 : US13; mutable l43 : US14; mutable l44 : US13; mutable l45 : US6; mutable l46 : US6; mutable l47 : US6; mutable l48 : US6; mutable l49 : US6; mutable l50 : US6; mutable l51 : US6; mutable l52 : US6; mutable l53 : US6; mutable l54 : US6; mutable l55 : US6; mutable l56 : US6; mutable l57 : US6; mutable l58 : US6; mutable l59 : US6; mutable l60 : US6; mutable l61 : US6; mutable l62 : US12; mutable l63 : US6; mutable l64 : US6; mutable l65 : US10; mutable l66 : US10; mutable l67 : US6; mutable l68 : US5; mutable l69 : US6}
and Mut2() = class end
and UH0 =
    | UH0_0 of (string * obj) * UH0
    | UH0_1
and [<Struct>] US15 =
    | US15_0
    | US15_1
    | US15_2
and Mut3 = {mutable l0 : US14; mutable l1 : US14; mutable l2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)); mutable l3 : US15}
and Mut4 = {mutable l0 : (unit -> bool); mutable l1 : (bool -> unit); mutable l2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6))}
and Mut5 = {mutable l0 : bool; mutable l1 : bool; mutable l2 : US14; mutable l3 : US14; mutable l4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6))}
and Mut6 = {mutable l0 : int32}
and Mut7 = {mutable l0 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)); mutable l1 : (unit -> JS.Function); mutable l2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6))}
and Mut8 = {mutable l0 : (string -> obj); mutable l1 : (unit -> struct ((unit -> string) * (string -> unit))); mutable l2 : string}
and Mut9 = {mutable l0 : (int32 -> obj); mutable l1 : (unit -> struct ((unit -> int32) * (int32 -> unit))); mutable l2 : string}
and Mut10 = {mutable l0 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit))); mutable l2 : string}
and Mut11 = {mutable l0 : ((struct (US2 * obj * string) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit))); mutable l2 : string}
and Mut12 = {mutable l0 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit))); mutable l2 : string}
and Mut13 = {mutable l0 : (US4 -> obj); mutable l1 : (unit -> struct ((unit -> US4) * (US4 -> unit))); mutable l2 : string}
and Mut14 = {mutable l0 : (US5 -> obj); mutable l1 : (unit -> struct ((unit -> US5) * (US5 -> unit))); mutable l2 : string}
and Mut15 = {mutable l0 : ((struct (int64 * int32) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit))); mutable l2 : string}
and Mut16 = {mutable l0 : ((struct (int64 * obj) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit))); mutable l2 : string}
and Mut17 = {mutable l0 : (unit -> US6); mutable l1 : (US6 -> unit)}
and Mut18 = {mutable l0 : (unit -> US5); mutable l1 : (US5 -> unit)}
and Mut19 = {mutable l0 : US3}
and Mut20 = {mutable l0 : (struct ((US2 []) * int32 * US3 * string * string) -> US6); mutable l1 : US3; mutable l2 : (struct ((US2 []) * int32 * US3 * string * string) -> (US6 -> struct ((US2 []) * int32 * US3 * string * string)))}
and Mut21 = {mutable l0 : int32; mutable l1 : US6}
and Mut22 = {mutable l0 : (struct ((US2 []) * int32 * US3 * string * string) -> US5); mutable l1 : US3; mutable l2 : (struct ((US2 []) * int32 * US3 * string * string) -> (US5 -> struct ((US2 []) * int32 * US3 * string * string)))}
and Mut23 = {mutable l0 : int32; mutable l1 : US5}
and Mut24 = {mutable l0 : US2; mutable l1 : US3}
and Mut25 = {mutable l0 : int32; mutable l1 : int32}
and [<Struct>] US16 =
    | US16_0
    | US16_1 of f1_0 : US2 * f1_1 : int64 * f1_2 : int32
and [<Struct>] US17 =
    | US17_0
    | US17_1 of f1_0 : US2 * f1_1 : int64 * f1_2 : string
and Mut26 = {mutable l0 : int32; mutable l1 : US17}
and Mut27 = {mutable l0 : int32; mutable l1 : obj}
and UH1 =
    | UH1_0 of int64 * int32 * UH1
    | UH1_1
and Mut28 = {mutable l0 : int32; mutable l1 : UH1}
and [<Struct>] US18 =
    | US18_0
    | US18_1 of f1_0 : US2 * f1_1 : int64 * f1_2 : (struct (int64 * obj) [])
and UH2 =
    | UH2_0 of int64 * obj * UH2
    | UH2_1
and Mut29 = {mutable l0 : int32; mutable l1 : UH2}
and [<Struct>] US19 =
    | US19_0
    | US19_1 of f1_0 : US2 * f1_1 : obj * f1_2 : string
and Mut30 = {mutable l0 : int32; mutable l1 : US19}
and [<Struct>] US20 =
    | US20_0
    | US20_1 of f1_0 : (US2 []) * f1_1 : int32 * f1_2 : US3 * f1_3 : string * f1_4 : string
and Mut31 = {mutable l0 : int32; mutable l1 : US20}
and Mut32 = {mutable l0 : int32; mutable l1 : (struct (US2 * obj * string) [])}
let rec closure0 () () : struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit)) =
    let struct (v0 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v1 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v2 : (unit -> int32), v3 : (int32 -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit), v8 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v9 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v10 : (unit -> (struct (US2 * obj * string) [])), v11 : ((struct (US2 * obj * string) []) -> unit), v12 : (unit -> (struct (int64 * obj) [])), v13 : ((struct (int64 * obj) []) -> unit), v14 : (unit -> (struct (int64 * obj) [])), v15 : ((struct (int64 * obj) []) -> unit), v16 : (unit -> (struct (int64 * int32) [])), v17 : ((struct (int64 * int32) []) -> unit), v18 : (unit -> US4), v19 : (US4 -> unit), v20 : (unit -> US5), v21 : (US5 -> unit)) = JS.undefined
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21)
and method0 () : obj =
    let v0 : string = "createContext"
    let v1 : string = "solid-js"
    let v2 : JS.Function = import v0 v1
    let v3 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))) = closure0()
    let v4 : obj = emitJsExpr () $"{v2}<ReturnType<typeof {v3}>>()"
    v4
and method2 () : struct (string * obj * string * string * bool) =
    let v0 : obj = emitJsExpr () "components_spi.env"
    let v1 : string = emitJsExpr v0 "$0.CODESPACE_NAME || \"\""
    let v2 : string = emitJsExpr v0 "$0.GITHUB_RUN_ID || \"\""
    let v3 : string = emitJsExpr v0 "$0.GITHUB_SHA || \"\""
    let v4 : obj = v0?IS_TEST
    let v5 : bool = emitJsExpr v4 "!$0"
    let v6 : bool = v5 = false
    struct (v1, v0, v2, v3, v6)
and closure2 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "$bg"
    let v71 : US6 = US6_1(v70)
    let v72 : string = "$text1"
    let v73 : US6 = US6_1(v72)
    let v74 : string = "flex"
    let v75 : US6 = US6_1(v74)
    let v76 : string = "1"
    let v77 : US6 = US6_1(v76)
    let v78 : string = "column"
    let v79 : US6 = US6_1(v78)
    let v80 : string = "$sm"
    let v81 : US6 = US6_1(v80)
    let v82 : string = "100vh"
    let v83 : US6 = US6_1(v82)
    let v84 : string = "100vw"
    let v85 : US6 = US6_1(v84)
    let v86 : string = "1px"
    let v87 : US6 = US6_1(v86)
    struct (v0, v1, v2, v3, v71, v5, v6, v7, v8, v9, v10, v11, v73, v13, v14, v15, v16, v17, v75, v19, v20, v77, v79, v23, v81, v83, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v85, v40, v41, v42, v43, v44, v45, v46, v47, v48, v87, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure5 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "$blackAlpha12"
    let v71 : US6 = US6_1(v70)
    let v72 : string = "0"
    let v73 : US6 = US6_1(v72)
    let v74 : string = "flex"
    let v75 : US6 = US6_1(v74)
    let v76 : string = "column"
    let v77 : US6 = US6_1(v76)
    let v78 : string = "80vh"
    let v79 : US6 = US6_1(v78)
    let v80 : string = "50vw"
    let v81 : US6 = US6_1(v80)
    let v82 : string = "auto"
    let v83 : US6 = US6_1(v82)
    let v84 : string = "absolute"
    let v85 : US6 = US6_1(v84)
    let v86 : US6 = US6_1(v72)
    let v87 : US5 = US5_1(2)
    struct (v0, v1, v2, v3, v71, v5, v6, v7, v8, v73, v10, v11, v12, v13, v14, v15, v16, v17, v75, v19, v20, v21, v77, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v79, v81, v40, v41, v42, v43, v44, v45, v83, v47, v48, v49, v50, v51, v52, v53, v54, v85, v86, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v87, v69)
and closure8 (v0 : Mut1) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : US6 = v0.l47
    let v74 : string =
        match v71 with
        | US6_0 -> (* None *)
            let v72 : string = "hidden"
            v72
        | US6_1(v73) -> (* Some *)
            v73
    let v75 : US6 = v0.l48
    let v78 : string =
        match v75 with
        | US6_0 -> (* None *)
            let v76 : string = "hidden"
            v76
        | US6_1(v77) -> (* Some *)
            v77
    let v79 : string = "flex"
    let v80 : US6 = US6_1(v79)
    let v81 : string = "1"
    let v82 : US6 = US6_1(v81)
    let v83 : string = "column"
    let v84 : US6 = US6_1(v83)
    let v85 : US6 = US6_1(v74)
    let v86 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v80, v20, v21, v82, v84, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v85, v86, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure10 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "$blackAlpha7"
    let v71 : US6 = US6_1(v70)
    let v72 : string = "flex"
    let v73 : US6 = US6_1(v72)
    let v74 : string = "column"
    let v75 : US6 = US6_1(v74)
    let v76 : string = "-1px"
    let v77 : US6 = US6_1(v76)
    struct (v0, v1, v2, v3, v71, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v73, v19, v20, v21, v75, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v77, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure11 () () : (JSX.Element []) =
    [||]
and method6 () : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v0 : US6 = US6_0
    let v1 : US6 = US6_0
    let v2 : US6 = US6_0
    let v3 : US7 = US7_0
    let v4 : US6 = US6_0
    let v5 : US6 = US6_0
    let v6 : US6 = US6_0
    let v7 : US6 = US6_0
    let v8 : US6 = US6_0
    let v9 : US6 = US6_0
    let v10 : US8 = US8_0
    let v11 : US9 = US9_0
    let v12 : US6 = US6_0
    let v13 : US6 = US6_0
    let v14 : US8 = US8_0
    let v15 : US10 = US10_0
    let v16 : US6 = US6_0
    let v17 : US6 = US6_0
    let v18 : US6 = US6_0
    let v19 : US11 = US11_0
    let v20 : US8 = US8_0
    let v21 : US6 = US6_0
    let v22 : US6 = US6_0
    let v23 : US6 = US6_0
    let v24 : US6 = US6_0
    let v25 : US6 = US6_0
    let v26 : US6 = US6_0
    let v27 : US12 = US12_0
    let v28 : US6 = US6_0
    let v29 : US6 = US6_0
    let v30 : US6 = US6_0
    let v31 : US12 = US12_0
    let v32 : US6 = US6_0
    let v33 : US6 = US6_0
    let v34 : US6 = US6_0
    let v35 : US6 = US6_0
    let v36 : US6 = US6_0
    let v37 : US6 = US6_0
    let v38 : US6 = US6_0
    let v39 : US6 = US6_0
    let v40 : US6 = US6_0
    let v41 : US6 = US6_0
    let v42 : US13 = US13_0
    let v43 : US14 = US14_0
    let v44 : US13 = US13_0
    let v45 : US6 = US6_0
    let v46 : US6 = US6_0
    let v47 : US6 = US6_0
    let v48 : US6 = US6_0
    let v49 : US6 = US6_0
    let v50 : US6 = US6_0
    let v51 : US6 = US6_0
    let v52 : US6 = US6_0
    let v53 : US6 = US6_0
    let v54 : US6 = US6_0
    let v55 : US6 = US6_0
    let v56 : US6 = US6_0
    let v57 : US6 = US6_0
    let v58 : US6 = US6_0
    let v59 : US6 = US6_0
    let v60 : US6 = US6_0
    let v61 : US6 = US6_0
    let v62 : US12 = US12_0
    let v63 : US6 = US6_0
    let v64 : US6 = US6_0
    let v65 : US10 = US10_0
    let v66 : US10 = US10_0
    let v67 : US6 = US6_0
    let v68 : US5 = US5_0
    let v69 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and method9 (v0 : UH0, v1 : int32) : int32 =
    match v0 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : int32 = v1 + 1
        method9(v3, v4)
    | UH0_1 -> (* Nil *)
        v1
and method10 (v0 : ((string * obj) []), v1 : UH0, v2 : int32) : int32 =
    match v1 with
    | UH0_0(v3, v4) -> (* Cons *)
        v0.[int v2] <- v3
        let v5 : int32 = v2 + 1
        method10(v0, v4, v5)
    | UH0_1 -> (* Nil *)
        v2
and method8 (v0 : UH0) : ((string * obj) []) =
    let v1 : int32 = 0
    let v2 : int32 = method9(v0, v1)
    let v3 : ((string * obj) []) = Array.zeroCreate<(string * obj)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method10(v3, v0, v4)
    v3
and method7 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : ((string * obj) []) =
    let v73 : obj =
        match v0 with
        | US6_0 -> (* None *)
            let v70 : obj = ()
            v70
        | US6_1(v71) -> (* Some *)
            let v72 : obj = v71
            v72
    let v74 : bool = emitJsExpr v73 "!$0"
    let v80 : UH0 =
        if v74 then
            UH0_1
        else
            let v76 : string = "alignItems"
            let v77 : (string * obj) = v76, v73
            let v78 : UH0 = UH0_1
            UH0_0(v77, v78)
    let v84 : obj =
        match v1 with
        | US6_0 -> (* None *)
            let v81 : obj = ()
            v81
        | US6_1(v82) -> (* Some *)
            let v83 : obj = v82
            v83
    let v85 : bool = emitJsExpr v84 "!$0"
    let v89 : UH0 =
        if v85 then
            v80
        else
            let v86 : string = "alignSelf"
            let v87 : (string * obj) = v86, v84
            UH0_0(v87, v80)
    let v93 : obj =
        match v2 with
        | US6_0 -> (* None *)
            let v90 : obj = ()
            v90
        | US6_1(v91) -> (* Some *)
            let v92 : obj = v91
            v92
    let v94 : bool = emitJsExpr v93 "!$0"
    let v98 : UH0 =
        if v94 then
            v89
        else
            let v95 : string = "aria-label"
            let v96 : (string * obj) = v95, v93
            UH0_0(v96, v89)
    let v102 : obj =
        match v3 with
        | US7_0 -> (* None *)
            let v99 : obj = ()
            v99
        | US7_1(v100) -> (* Some *)
            let v101 : obj = v100
            v101
    let v103 : bool = emitJsExpr v102 "!$0"
    let v107 : UH0 =
        if v103 then
            v98
        else
            let v104 : string = "as"
            let v105 : (string * obj) = v104, v102
            UH0_0(v105, v98)
    let v111 : obj =
        match v4 with
        | US6_0 -> (* None *)
            let v108 : obj = ()
            v108
        | US6_1(v109) -> (* Some *)
            let v110 : obj = v109
            v110
    let v112 : bool = emitJsExpr v111 "!$0"
    let v116 : UH0 =
        if v112 then
            v107
        else
            let v113 : string = "backgroundColor"
            let v114 : (string * obj) = v113, v111
            UH0_0(v114, v107)
    let v120 : obj =
        match v5 with
        | US6_0 -> (* None *)
            let v117 : obj = ()
            v117
        | US6_1(v118) -> (* Some *)
            let v119 : obj = v118
            v119
    let v121 : bool = emitJsExpr v120 "!$0"
    let v125 : UH0 =
        if v121 then
            v116
        else
            let v122 : string = "border"
            let v123 : (string * obj) = v122, v120
            UH0_0(v123, v116)
    let v129 : obj =
        match v6 with
        | US6_0 -> (* None *)
            let v126 : obj = ()
            v126
        | US6_1(v127) -> (* Some *)
            let v128 : obj = v127
            v128
    let v130 : bool = emitJsExpr v129 "!$0"
    let v134 : UH0 =
        if v130 then
            v125
        else
            let v131 : string = "borderBottomWidth"
            let v132 : (string * obj) = v131, v129
            UH0_0(v132, v125)
    let v138 : obj =
        match v7 with
        | US6_0 -> (* None *)
            let v135 : obj = ()
            v135
        | US6_1(v136) -> (* Some *)
            let v137 : obj = v136
            v137
    let v139 : bool = emitJsExpr v138 "!$0"
    let v143 : UH0 =
        if v139 then
            v134
        else
            let v140 : string = "borderColor"
            let v141 : (string * obj) = v140, v138
            UH0_0(v141, v134)
    let v147 : obj =
        match v8 with
        | US6_0 -> (* None *)
            let v144 : obj = ()
            v144
        | US6_1(v145) -> (* Some *)
            let v146 : obj = v145
            v146
    let v148 : bool = emitJsExpr v147 "!$0"
    let v152 : UH0 =
        if v148 then
            v143
        else
            let v149 : string = "borderWidth"
            let v150 : (string * obj) = v149, v147
            UH0_0(v150, v143)
    let v156 : obj =
        match v9 with
        | US6_0 -> (* None *)
            let v153 : obj = ()
            v153
        | US6_1(v154) -> (* Some *)
            let v155 : obj = v154
            v155
    let v157 : bool = emitJsExpr v156 "!$0"
    let v161 : UH0 =
        if v157 then
            v152
        else
            let v158 : string = "bottom"
            let v159 : (string * obj) = v158, v156
            UH0_0(v159, v152)
    let v165 : obj =
        match v10 with
        | US8_0 -> (* None *)
            let v162 : obj = ()
            v162
        | US8_1(v163) -> (* Some *)
            let v164 : obj = v163
            v164
    let v166 : bool = emitJsExpr v165 "!$0"
    let v170 : UH0 =
        if v166 then
            v161
        else
            let v167 : string = "checked"
            let v168 : (string * obj) = v167, v165
            UH0_0(v168, v161)
    let v174 : obj =
        match v11 with
        | US9_0 -> (* None *)
            let v171 : obj = ()
            v171
        | US9_1(v172) -> (* Some *)
            let v173 : obj = v172
            v173
    let v175 : bool = emitJsExpr v174 "!$0"
    let v179 : UH0 =
        if v175 then
            v170
        else
            let v176 : string = "children"
            let v177 : (string * obj) = v176, v174
            UH0_0(v177, v170)
    let v183 : obj =
        match v12 with
        | US6_0 -> (* None *)
            let v180 : obj = ()
            v180
        | US6_1(v181) -> (* Some *)
            let v182 : obj = v181
            v182
    let v184 : bool = emitJsExpr v183 "!$0"
    let v188 : UH0 =
        if v184 then
            v179
        else
            let v185 : string = "color"
            let v186 : (string * obj) = v185, v183
            UH0_0(v186, v179)
    let v192 : obj =
        match v13 with
        | US6_0 -> (* None *)
            let v189 : obj = ()
            v189
        | US6_1(v190) -> (* Some *)
            let v191 : obj = v190
            v191
    let v193 : bool = emitJsExpr v192 "!$0"
    let v197 : UH0 =
        if v193 then
            v188
        else
            let v194 : string = "colorScheme"
            let v195 : (string * obj) = v194, v192
            UH0_0(v195, v188)
    let v201 : obj =
        match v14 with
        | US8_0 -> (* None *)
            let v198 : obj = ()
            v198
        | US8_1(v199) -> (* Some *)
            let v200 : obj = v199
            v200
    let v202 : bool = emitJsExpr v201 "!$0"
    let v206 : UH0 =
        if v202 then
            v197
        else
            let v203 : string = "compact"
            let v204 : (string * obj) = v203, v201
            UH0_0(v204, v197)
    let v210 : obj =
        match v15 with
        | US10_0 -> (* None *)
            let v207 : obj = ()
            v207
        | US10_1(v208) -> (* Some *)
            let v209 : obj = v208
            v209
    let v211 : bool = emitJsExpr v210 "!$0"
    let v215 : UH0 =
        if v211 then
            v206
        else
            let v212 : string = "css"
            let v213 : (string * obj) = v212, v210
            UH0_0(v213, v206)
    let v219 : obj =
        match v16 with
        | US6_0 -> (* None *)
            let v216 : obj = ()
            v216
        | US6_1(v217) -> (* Some *)
            let v218 : obj = v217
            v218
    let v220 : bool = emitJsExpr v219 "!$0"
    let v224 : UH0 =
        if v220 then
            v215
        else
            let v221 : string = "defaultValue"
            let v222 : (string * obj) = v221, v219
            UH0_0(v222, v215)
    let v228 : obj =
        match v17 with
        | US6_0 -> (* None *)
            let v225 : obj = ()
            v225
        | US6_1(v226) -> (* Some *)
            let v227 : obj = v226
            v227
    let v229 : bool = emitJsExpr v228 "!$0"
    let v233 : UH0 =
        if v229 then
            v224
        else
            let v230 : string = "direction"
            let v231 : (string * obj) = v230, v228
            UH0_0(v231, v224)
    let v237 : obj =
        match v18 with
        | US6_0 -> (* None *)
            let v234 : obj = ()
            v234
        | US6_1(v235) -> (* Some *)
            let v236 : obj = v235
            v236
    let v238 : bool = emitJsExpr v237 "!$0"
    let v242 : UH0 =
        if v238 then
            v233
        else
            let v239 : string = "display"
            let v240 : (string * obj) = v239, v237
            UH0_0(v240, v233)
    let v246 : obj =
        match v19 with
        | US11_0 -> (* None *)
            let v243 : obj = ()
            v243
        | US11_1(v244) -> (* Some *)
            let v245 : obj = v244
            v245
    let v247 : bool = emitJsExpr v246 "!$0"
    let v251 : UH0 =
        if v247 then
            v242
        else
            let v248 : string = "each"
            let v249 : (string * obj) = v248, v246
            UH0_0(v249, v242)
    let v255 : obj =
        match v20 with
        | US8_0 -> (* None *)
            let v252 : obj = ()
            v252
        | US8_1(v253) -> (* Some *)
            let v254 : obj = v253
            v254
    let v256 : bool = emitJsExpr v255 "!$0"
    let v260 : UH0 =
        if v256 then
            v251
        else
            let v257 : string = "external"
            let v258 : (string * obj) = v257, v255
            UH0_0(v258, v251)
    let v264 : obj =
        match v21 with
        | US6_0 -> (* None *)
            let v261 : obj = ()
            v261
        | US6_1(v262) -> (* Some *)
            let v263 : obj = v262
            v263
    let v265 : bool = emitJsExpr v264 "!$0"
    let v269 : UH0 =
        if v265 then
            v260
        else
            let v266 : string = "flex"
            let v267 : (string * obj) = v266, v264
            UH0_0(v267, v260)
    let v273 : obj =
        match v22 with
        | US6_0 -> (* None *)
            let v270 : obj = ()
            v270
        | US6_1(v271) -> (* Some *)
            let v272 : obj = v271
            v272
    let v274 : bool = emitJsExpr v273 "!$0"
    let v278 : UH0 =
        if v274 then
            v269
        else
            let v275 : string = "flexDirection"
            let v276 : (string * obj) = v275, v273
            UH0_0(v276, v269)
    let v282 : obj =
        match v23 with
        | US6_0 -> (* None *)
            let v279 : obj = ()
            v279
        | US6_1(v280) -> (* Some *)
            let v281 : obj = v280
            v281
    let v283 : bool = emitJsExpr v282 "!$0"
    let v287 : UH0 =
        if v283 then
            v278
        else
            let v284 : string = "flexFlow"
            let v285 : (string * obj) = v284, v282
            UH0_0(v285, v278)
    let v291 : obj =
        match v24 with
        | US6_0 -> (* None *)
            let v288 : obj = ()
            v288
        | US6_1(v289) -> (* Some *)
            let v290 : obj = v289
            v290
    let v292 : bool = emitJsExpr v291 "!$0"
    let v296 : UH0 =
        if v292 then
            v287
        else
            let v293 : string = "fontSize"
            let v294 : (string * obj) = v293, v291
            UH0_0(v294, v287)
    let v300 : obj =
        match v25 with
        | US6_0 -> (* None *)
            let v297 : obj = ()
            v297
        | US6_1(v298) -> (* Some *)
            let v299 : obj = v298
            v299
    let v301 : bool = emitJsExpr v300 "!$0"
    let v305 : UH0 =
        if v301 then
            v296
        else
            let v302 : string = "height"
            let v303 : (string * obj) = v302, v300
            UH0_0(v303, v296)
    let v309 : obj =
        match v26 with
        | US6_0 -> (* None *)
            let v306 : obj = ()
            v306
        | US6_1(v307) -> (* Some *)
            let v308 : obj = v307
            v308
    let v310 : bool = emitJsExpr v309 "!$0"
    let v314 : UH0 =
        if v310 then
            v305
        else
            let v311 : string = "href"
            let v312 : (string * obj) = v311, v309
            UH0_0(v312, v305)
    let v318 : obj =
        match v27 with
        | US12_0 -> (* None *)
            let v315 : obj = ()
            v315
        | US12_1(v316) -> (* Some *)
            let v317 : obj = v316
            v317
    let v319 : bool = emitJsExpr v318 "!$0"
    let v323 : UH0 =
        if v319 then
            v314
        else
            let v320 : string = "icon"
            let v321 : (string * obj) = v320, v318
            UH0_0(v321, v314)
    let v327 : obj =
        match v28 with
        | US6_0 -> (* None *)
            let v324 : obj = ()
            v324
        | US6_1(v325) -> (* Some *)
            let v326 : obj = v325
            v326
    let v328 : bool = emitJsExpr v327 "!$0"
    let v332 : UH0 =
        if v328 then
            v323
        else
            let v329 : string = "id"
            let v330 : (string * obj) = v329, v327
            UH0_0(v330, v323)
    let v336 : obj =
        match v29 with
        | US6_0 -> (* None *)
            let v333 : obj = ()
            v333
        | US6_1(v334) -> (* Some *)
            let v335 : obj = v334
            v335
    let v337 : bool = emitJsExpr v336 "!$0"
    let v341 : UH0 =
        if v337 then
            v332
        else
            let v338 : string = "justifyContent"
            let v339 : (string * obj) = v338, v336
            UH0_0(v339, v332)
    let v345 : obj =
        match v30 with
        | US6_0 -> (* None *)
            let v342 : obj = ()
            v342
        | US6_1(v343) -> (* Some *)
            let v344 : obj = v343
            v344
    let v346 : bool = emitJsExpr v345 "!$0"
    let v350 : UH0 =
        if v346 then
            v341
        else
            let v347 : string = "left"
            let v348 : (string * obj) = v347, v345
            UH0_0(v348, v341)
    let v354 : obj =
        match v31 with
        | US12_0 -> (* None *)
            let v351 : obj = ()
            v351
        | US12_1(v352) -> (* Some *)
            let v353 : obj = v352
            v353
    let v355 : bool = emitJsExpr v354 "!$0"
    let v359 : UH0 =
        if v355 then
            v350
        else
            let v356 : string = "leftIcon"
            let v357 : (string * obj) = v356, v354
            UH0_0(v357, v350)
    let v363 : obj =
        match v32 with
        | US6_0 -> (* None *)
            let v360 : obj = ()
            v360
        | US6_1(v361) -> (* Some *)
            let v362 : obj = v361
            v362
    let v364 : bool = emitJsExpr v363 "!$0"
    let v368 : UH0 =
        if v364 then
            v359
        else
            let v365 : string = "lineHeight"
            let v366 : (string * obj) = v365, v363
            UH0_0(v366, v359)
    let v372 : obj =
        match v33 with
        | US6_0 -> (* None *)
            let v369 : obj = ()
            v369
        | US6_1(v370) -> (* Some *)
            let v371 : obj = v370
            v371
    let v373 : bool = emitJsExpr v372 "!$0"
    let v377 : UH0 =
        if v373 then
            v368
        else
            let v374 : string = "margin"
            let v375 : (string * obj) = v374, v372
            UH0_0(v375, v368)
    let v381 : obj =
        match v34 with
        | US6_0 -> (* None *)
            let v378 : obj = ()
            v378
        | US6_1(v379) -> (* Some *)
            let v380 : obj = v379
            v380
    let v382 : bool = emitJsExpr v381 "!$0"
    let v386 : UH0 =
        if v382 then
            v377
        else
            let v383 : string = "marginBottom"
            let v384 : (string * obj) = v383, v381
            UH0_0(v384, v377)
    let v390 : obj =
        match v35 with
        | US6_0 -> (* None *)
            let v387 : obj = ()
            v387
        | US6_1(v388) -> (* Some *)
            let v389 : obj = v388
            v389
    let v391 : bool = emitJsExpr v390 "!$0"
    let v395 : UH0 =
        if v391 then
            v386
        else
            let v392 : string = "marginLeft"
            let v393 : (string * obj) = v392, v390
            UH0_0(v393, v386)
    let v399 : obj =
        match v36 with
        | US6_0 -> (* None *)
            let v396 : obj = ()
            v396
        | US6_1(v397) -> (* Some *)
            let v398 : obj = v397
            v398
    let v400 : bool = emitJsExpr v399 "!$0"
    let v404 : UH0 =
        if v400 then
            v395
        else
            let v401 : string = "marginRight"
            let v402 : (string * obj) = v401, v399
            UH0_0(v402, v395)
    let v408 : obj =
        match v37 with
        | US6_0 -> (* None *)
            let v405 : obj = ()
            v405
        | US6_1(v406) -> (* Some *)
            let v407 : obj = v406
            v407
    let v409 : bool = emitJsExpr v408 "!$0"
    let v413 : UH0 =
        if v409 then
            v404
        else
            let v410 : string = "marginTop"
            let v411 : (string * obj) = v410, v408
            UH0_0(v411, v404)
    let v417 : obj =
        match v38 with
        | US6_0 -> (* None *)
            let v414 : obj = ()
            v414
        | US6_1(v415) -> (* Some *)
            let v416 : obj = v415
            v416
    let v418 : bool = emitJsExpr v417 "!$0"
    let v422 : UH0 =
        if v418 then
            v413
        else
            let v419 : string = "maxHeight"
            let v420 : (string * obj) = v419, v417
            UH0_0(v420, v413)
    let v426 : obj =
        match v39 with
        | US6_0 -> (* None *)
            let v423 : obj = ()
            v423
        | US6_1(v424) -> (* Some *)
            let v425 : obj = v424
            v425
    let v427 : bool = emitJsExpr v426 "!$0"
    let v431 : UH0 =
        if v427 then
            v422
        else
            let v428 : string = "maxWidth"
            let v429 : (string * obj) = v428, v426
            UH0_0(v429, v422)
    let v435 : obj =
        match v40 with
        | US6_0 -> (* None *)
            let v432 : obj = ()
            v432
        | US6_1(v433) -> (* Some *)
            let v434 : obj = v433
            v434
    let v436 : bool = emitJsExpr v435 "!$0"
    let v440 : UH0 =
        if v436 then
            v431
        else
            let v437 : string = "minHeight"
            let v438 : (string * obj) = v437, v435
            UH0_0(v438, v431)
    let v444 : obj =
        match v41 with
        | US6_0 -> (* None *)
            let v441 : obj = ()
            v441
        | US6_1(v442) -> (* Some *)
            let v443 : obj = v442
            v443
    let v445 : bool = emitJsExpr v444 "!$0"
    let v449 : UH0 =
        if v445 then
            v440
        else
            let v446 : string = "minWidth"
            let v447 : (string * obj) = v446, v444
            UH0_0(v447, v440)
    let v453 : obj =
        match v42 with
        | US13_0 -> (* None *)
            let v450 : obj = ()
            v450
        | US13_1(v451) -> (* Some *)
            let v452 : obj = v451
            v452
    let v454 : bool = emitJsExpr v453 "!$0"
    let v458 : UH0 =
        if v454 then
            v449
        else
            let v455 : string = "onChange"
            let v456 : (string * obj) = v455, v453
            UH0_0(v456, v449)
    let v462 : obj =
        match v43 with
        | US14_0 -> (* None *)
            let v459 : obj = ()
            v459
        | US14_1(v460) -> (* Some *)
            let v461 : obj = v460
            v461
    let v463 : bool = emitJsExpr v462 "!$0"
    let v467 : UH0 =
        if v463 then
            v458
        else
            let v464 : string = "onClick"
            let v465 : (string * obj) = v464, v462
            UH0_0(v465, v458)
    let v471 : obj =
        match v44 with
        | US13_0 -> (* None *)
            let v468 : obj = ()
            v468
        | US13_1(v469) -> (* Some *)
            let v470 : obj = v469
            v470
    let v472 : bool = emitJsExpr v471 "!$0"
    let v476 : UH0 =
        if v472 then
            v467
        else
            let v473 : string = "onInput"
            let v474 : (string * obj) = v473, v471
            UH0_0(v474, v467)
    let v480 : obj =
        match v45 with
        | US6_0 -> (* None *)
            let v477 : obj = ()
            v477
        | US6_1(v478) -> (* Some *)
            let v479 : obj = v478
            v479
    let v481 : bool = emitJsExpr v480 "!$0"
    let v485 : UH0 =
        if v481 then
            v476
        else
            let v482 : string = "outline"
            let v483 : (string * obj) = v482, v480
            UH0_0(v483, v476)
    let v489 : obj =
        match v46 with
        | US6_0 -> (* None *)
            let v486 : obj = ()
            v486
        | US6_1(v487) -> (* Some *)
            let v488 : obj = v487
            v488
    let v490 : bool = emitJsExpr v489 "!$0"
    let v494 : UH0 =
        if v490 then
            v485
        else
            let v491 : string = "overflow"
            let v492 : (string * obj) = v491, v489
            UH0_0(v492, v485)
    let v498 : obj =
        match v47 with
        | US6_0 -> (* None *)
            let v495 : obj = ()
            v495
        | US6_1(v496) -> (* Some *)
            let v497 : obj = v496
            v497
    let v499 : bool = emitJsExpr v498 "!$0"
    let v503 : UH0 =
        if v499 then
            v494
        else
            let v500 : string = "overflowX"
            let v501 : (string * obj) = v500, v498
            UH0_0(v501, v494)
    let v507 : obj =
        match v48 with
        | US6_0 -> (* None *)
            let v504 : obj = ()
            v504
        | US6_1(v505) -> (* Some *)
            let v506 : obj = v505
            v506
    let v508 : bool = emitJsExpr v507 "!$0"
    let v512 : UH0 =
        if v508 then
            v503
        else
            let v509 : string = "overflowY"
            let v510 : (string * obj) = v509, v507
            UH0_0(v510, v503)
    let v516 : obj =
        match v49 with
        | US6_0 -> (* None *)
            let v513 : obj = ()
            v513
        | US6_1(v514) -> (* Some *)
            let v515 : obj = v514
            v515
    let v517 : bool = emitJsExpr v516 "!$0"
    let v521 : UH0 =
        if v517 then
            v512
        else
            let v518 : string = "padding"
            let v519 : (string * obj) = v518, v516
            UH0_0(v519, v512)
    let v525 : obj =
        match v50 with
        | US6_0 -> (* None *)
            let v522 : obj = ()
            v522
        | US6_1(v523) -> (* Some *)
            let v524 : obj = v523
            v524
    let v526 : bool = emitJsExpr v525 "!$0"
    let v530 : UH0 =
        if v526 then
            v521
        else
            let v527 : string = "paddingBottom"
            let v528 : (string * obj) = v527, v525
            UH0_0(v528, v521)
    let v534 : obj =
        match v51 with
        | US6_0 -> (* None *)
            let v531 : obj = ()
            v531
        | US6_1(v532) -> (* Some *)
            let v533 : obj = v532
            v533
    let v535 : bool = emitJsExpr v534 "!$0"
    let v539 : UH0 =
        if v535 then
            v530
        else
            let v536 : string = "paddingLeft"
            let v537 : (string * obj) = v536, v534
            UH0_0(v537, v530)
    let v543 : obj =
        match v52 with
        | US6_0 -> (* None *)
            let v540 : obj = ()
            v540
        | US6_1(v541) -> (* Some *)
            let v542 : obj = v541
            v542
    let v544 : bool = emitJsExpr v543 "!$0"
    let v548 : UH0 =
        if v544 then
            v539
        else
            let v545 : string = "paddingRight"
            let v546 : (string * obj) = v545, v543
            UH0_0(v546, v539)
    let v552 : obj =
        match v53 with
        | US6_0 -> (* None *)
            let v549 : obj = ()
            v549
        | US6_1(v550) -> (* Some *)
            let v551 : obj = v550
            v551
    let v553 : bool = emitJsExpr v552 "!$0"
    let v557 : UH0 =
        if v553 then
            v548
        else
            let v554 : string = "paddingTop"
            let v555 : (string * obj) = v554, v552
            UH0_0(v555, v548)
    let v561 : obj =
        match v54 with
        | US6_0 -> (* None *)
            let v558 : obj = ()
            v558
        | US6_1(v559) -> (* Some *)
            let v560 : obj = v559
            v560
    let v562 : bool = emitJsExpr v561 "!$0"
    let v566 : UH0 =
        if v562 then
            v557
        else
            let v563 : string = "placeholder"
            let v564 : (string * obj) = v563, v561
            UH0_0(v564, v557)
    let v570 : obj =
        match v55 with
        | US6_0 -> (* None *)
            let v567 : obj = ()
            v567
        | US6_1(v568) -> (* Some *)
            let v569 : obj = v568
            v569
    let v571 : bool = emitJsExpr v570 "!$0"
    let v575 : UH0 =
        if v571 then
            v566
        else
            let v572 : string = "position"
            let v573 : (string * obj) = v572, v570
            UH0_0(v573, v566)
    let v579 : obj =
        match v56 with
        | US6_0 -> (* None *)
            let v576 : obj = ()
            v576
        | US6_1(v577) -> (* Some *)
            let v578 : obj = v577
            v578
    let v580 : bool = emitJsExpr v579 "!$0"
    let v584 : UH0 =
        if v580 then
            v575
        else
            let v581 : string = "right"
            let v582 : (string * obj) = v581, v579
            UH0_0(v582, v575)
    let v588 : obj =
        match v57 with
        | US6_0 -> (* None *)
            let v585 : obj = ()
            v585
        | US6_1(v586) -> (* Some *)
            let v587 : obj = v586
            v587
    let v589 : bool = emitJsExpr v588 "!$0"
    let v593 : UH0 =
        if v589 then
            v584
        else
            let v590 : string = "size"
            let v591 : (string * obj) = v590, v588
            UH0_0(v591, v584)
    let v597 : obj =
        match v58 with
        | US6_0 -> (* None *)
            let v594 : obj = ()
            v594
        | US6_1(v595) -> (* Some *)
            let v596 : obj = v595
            v596
    let v598 : bool = emitJsExpr v597 "!$0"
    let v602 : UH0 =
        if v598 then
            v593
        else
            let v599 : string = "spacing"
            let v600 : (string * obj) = v599, v597
            UH0_0(v600, v593)
    let v606 : obj =
        match v59 with
        | US6_0 -> (* None *)
            let v603 : obj = ()
            v603
        | US6_1(v604) -> (* Some *)
            let v605 : obj = v604
            v605
    let v607 : bool = emitJsExpr v606 "!$0"
    let v611 : UH0 =
        if v607 then
            v602
        else
            let v608 : string = "src"
            let v609 : (string * obj) = v608, v606
            UH0_0(v609, v602)
    let v615 : obj =
        match v60 with
        | US6_0 -> (* None *)
            let v612 : obj = ()
            v612
        | US6_1(v613) -> (* Some *)
            let v614 : obj = v613
            v614
    let v616 : bool = emitJsExpr v615 "!$0"
    let v620 : UH0 =
        if v616 then
            v611
        else
            let v617 : string = "striped"
            let v618 : (string * obj) = v617, v615
            UH0_0(v618, v611)
    let v624 : obj =
        match v61 with
        | US6_0 -> (* None *)
            let v621 : obj = ()
            v621
        | US6_1(v622) -> (* Some *)
            let v623 : obj = v622
            v623
    let v625 : bool = emitJsExpr v624 "!$0"
    let v629 : UH0 =
        if v625 then
            v620
        else
            let v626 : string = "thickness"
            let v627 : (string * obj) = v626, v624
            UH0_0(v627, v620)
    let v633 : obj =
        match v62 with
        | US12_0 -> (* None *)
            let v630 : obj = ()
            v630
        | US12_1(v631) -> (* Some *)
            let v632 : obj = v631
            v632
    let v634 : bool = emitJsExpr v633 "!$0"
    let v638 : UH0 =
        if v634 then
            v629
        else
            let v635 : string = "title"
            let v636 : (string * obj) = v635, v633
            UH0_0(v636, v629)
    let v642 : obj =
        match v63 with
        | US6_0 -> (* None *)
            let v639 : obj = ()
            v639
        | US6_1(v640) -> (* Some *)
            let v641 : obj = v640
            v641
    let v643 : bool = emitJsExpr v642 "!$0"
    let v647 : UH0 =
        if v643 then
            v638
        else
            let v644 : string = "top"
            let v645 : (string * obj) = v644, v642
            UH0_0(v645, v638)
    let v651 : obj =
        match v64 with
        | US6_0 -> (* None *)
            let v648 : obj = ()
            v648
        | US6_1(v649) -> (* Some *)
            let v650 : obj = v649
            v650
    let v652 : bool = emitJsExpr v651 "!$0"
    let v656 : UH0 =
        if v652 then
            v647
        else
            let v653 : string = "type"
            let v654 : (string * obj) = v653, v651
            UH0_0(v654, v647)
    let v660 : obj =
        match v65 with
        | US10_0 -> (* None *)
            let v657 : obj = ()
            v657
        | US10_1(v658) -> (* Some *)
            let v659 : obj = v658
            v659
    let v661 : bool = emitJsExpr v660 "!$0"
    let v665 : UH0 =
        if v661 then
            v656
        else
            let v662 : string = "value"
            let v663 : (string * obj) = v662, v660
            UH0_0(v663, v656)
    let v669 : obj =
        match v66 with
        | US10_0 -> (* None *)
            let v666 : obj = ()
            v666
        | US10_1(v667) -> (* Some *)
            let v668 : obj = v667
            v668
    let v670 : bool = emitJsExpr v669 "!$0"
    let v674 : UH0 =
        if v670 then
            v665
        else
            let v671 : string = "when"
            let v672 : (string * obj) = v671, v669
            UH0_0(v672, v665)
    let v678 : obj =
        match v67 with
        | US6_0 -> (* None *)
            let v675 : obj = ()
            v675
        | US6_1(v676) -> (* Some *)
            let v677 : obj = v676
            v677
    let v679 : bool = emitJsExpr v678 "!$0"
    let v683 : UH0 =
        if v679 then
            v674
        else
            let v680 : string = "width"
            let v681 : (string * obj) = v680, v678
            UH0_0(v681, v674)
    let v687 : obj =
        match v68 with
        | US5_0 -> (* None *)
            let v684 : obj = ()
            v684
        | US5_1(v685) -> (* Some *)
            let v686 : obj = v685
            v686
    let v688 : bool = emitJsExpr v687 "!$0"
    let v692 : UH0 =
        if v688 then
            v683
        else
            let v689 : string = "zIndex"
            let v690 : (string * obj) = v689, v687
            UH0_0(v690, v683)
    let v696 : obj =
        match v69 with
        | US6_0 -> (* None *)
            let v693 : obj = ()
            v693
        | US6_1(v694) -> (* Some *)
            let v695 : obj = v694
            v695
    let v697 : bool = emitJsExpr v696 "!$0"
    let v701 : UH0 =
        if v697 then
            v692
        else
            let v698 : string = "zoom"
            let v699 : (string * obj) = v698, v696
            UH0_0(v699, v692)
    method8(v701)
and method5 (v0 : JS.Function, v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)), v2 : (unit -> (JSX.Element []))) : JSX.Element =
    let struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US10, v19 : US6, v20 : US6, v21 : US6, v22 : US11, v23 : US8, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US12, v31 : US6, v32 : US6, v33 : US6, v34 : US12, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US13, v46 : US14, v47 : US13, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US12, v66 : US6, v67 : US6, v68 : US10, v69 : US10, v70 : US6, v71 : US5, v72 : US6) = method6()
    let struct (v73 : US6, v74 : US6, v75 : US6, v76 : US7, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US6, v83 : US8, v84 : US9, v85 : US6, v86 : US6, v87 : US8, v88 : US10, v89 : US6, v90 : US6, v91 : US6, v92 : US11, v93 : US8, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US6, v99 : US6, v100 : US12, v101 : US6, v102 : US6, v103 : US6, v104 : US12, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US6, v115 : US13, v116 : US14, v117 : US13, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US6, v135 : US12, v136 : US6, v137 : US6, v138 : US10, v139 : US10, v140 : US6, v141 : US5, v142 : US6) = v1 struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v150 : US9 =
        match v84 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v144) -> (* Some *)
            let v145 : string = "children"
            let v146 : string = "solid-js"
            let v147 : JS.Function = import v145 v146
            let v148 : (unit -> (JSX.Element [])) = v147.Invoke v144 |> unbox<unit -> JSX.Element[]>
            US9_1(v148)
    let v152 : (unit -> (JSX.Element [])) =
        match v150 with
        | US9_0 -> (* None *)
            v2
        | US9_1(v151) -> (* Some *)
            v151
    let v153 : US9 = US9_1(v152)
    let v154 : ((string * obj) []) = method7(v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v153, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142)
    let v155 : obj = createObj v154
    emitJsExpr (v155, v2) "$0.children = $1"
    let v156 : (obj -> JSX.Element) = v0 |> unbox<(obj -> JSX.Element)>
    let v157 : string = "createComponent"
    let v158 : string = "solid-js"
    let v159 : JS.Function = import v157 v158
    let v160 : JSX.Element = v159.Invoke (v156, v155) |> unbox<JSX.Element>
    v160
and closure9 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : string = "Tbody"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure10()
    let v5 : US9 = v0.l11
    let v8 : (unit -> (JSX.Element [])) =
        match v5 with
        | US9_0 -> (* None *)
            closure11()
        | US9_1(v7) -> (* Some *)
            v7
    let v9 : JSX.Element = method5(v3, v4, v8)
    [|v9|]
and method4 (v0 : Mut1) : JSX.Element =
    let v1 : string = "Table"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure8(v0)
    let v5 : (unit -> (JSX.Element [])) = closure9(v0)
    method5(v3, v4, v5)
and closure7 () (v0 : Mut1) : JSX.Element =
    method4(v0)
and closure12 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and method12 (v0 : string, v1 : string) : string =
    let v2 : string = {| ``@initial`` = v1; ``@sm`` = v0 |} |> unbox<string>
    v2
and closure15 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) struct (v70 : US6, v71 : US6, v72 : US6, v73 : US7, v74 : US6, v75 : US6, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US8, v81 : US9, v82 : US6, v83 : US6, v84 : US8, v85 : US10, v86 : US6, v87 : US6, v88 : US6, v89 : US11, v90 : US8, v91 : US6, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US12, v98 : US6, v99 : US6, v100 : US6, v101 : US12, v102 : US6, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US13, v113 : US14, v114 : US13, v115 : US6, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US12, v133 : US6, v134 : US6, v135 : US10, v136 : US10, v137 : US6, v138 : US5, v139 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v140 : string = "column"
    let v141 : string = "row"
    let v142 : string = method12(v141, v140)
    let v143 : string = "$neutral5"
    let v144 : US6 = US6_1(v143)
    let v145 : string = "1px 1px"
    let v146 : US6 = US6_1(v145)
    let v147 : string = "flex"
    let v148 : US6 = US6_1(v147)
    let v149 : string = "1"
    let v150 : US6 = US6_1(v149)
    let v151 : US6 = US6_1(v142)
    struct (v70, v71, v72, v73, v74, v75, v76, v144, v146, v79, v80, v81, v82, v83, v84, v85, v86, v87, v148, v89, v90, v150, v151, v93, v94, v95, v96, v97, v28, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139)
and closure17 (v0 : Mut3, v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6, v71 : (unit -> bool)) struct (v72 : US6, v73 : US6, v74 : US6, v75 : US7, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US8, v83 : US9, v84 : US6, v85 : US6, v86 : US8, v87 : US10, v88 : US6, v89 : US6, v90 : US6, v91 : US11, v92 : US8, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US6, v99 : US12, v100 : US6, v101 : US6, v102 : US6, v103 : US12, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US13, v115 : US14, v116 : US13, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US12, v135 : US6, v136 : US6, v137 : US10, v138 : US10, v139 : US6, v140 : US5, v141 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v142 : US15 = v0.l3
    let v144 : bool =
        match v142 with
        | US15_2 -> (* CheckHidden *)
            true
        | _ ->
            false
    let v146 : bool =
        if v144 then
            true
        else
            let v145 : bool = v71 ()
            v145
    let v151 : string =
        if v146 then
            let v147 : string = JS.undefined
            let v148 : string = "0px !important"
            method12(v148, v147)
        else
            let v150 : string = "0px !important"
            v150
    let v154 : string =
        match v25 with
        | US6_0 -> (* None *)
            let v152 : string = "$sm"
            v152
        | US6_1(v153) -> (* Some *)
            v153
    let v157 : string =
        match v53 with
        | US6_0 -> (* None *)
            let v155 : string = "0"
            v155
        | US6_1(v156) -> (* Some *)
            v156
    let v164 : string =
        match v52 with
        | US6_0 -> (* None *)
            let v158 : string = "15px"
            v158
        | US6_1(v159) -> (* Some *)
            let v160 : bool = "0" = v159
            if v160 then
                let v161 : string = "0"
                v161
            else
                let v162 : string = "15px"
                v162
    let v165 : string = method12(v164, v157)
    let v166 : US6 = US6_1(v151)
    let v167 : string = "$neutral5"
    let v168 : US6 = US6_1(v167)
    let v169 : string = "$neutral11"
    let v170 : US6 = US6_1(v169)
    let v171 : string = "flex"
    let v172 : US6 = US6_1(v171)
    let v173 : string = "column"
    let v174 : US6 = US6_1(v173)
    let v175 : US6 = US6_1(v154)
    let v176 : string = "0"
    let v177 : US6 = US6_1(v176)
    let v178 : US6 = US6_1(v176)
    let v179 : US6 = US6_1(v165)
    let v180 : US6 = US6_1(v176)
    struct (v72, v73, v74, v75, v76, v77, v166, v168, v80, v81, v82, v83, v170, v85, v86, v87, v88, v89, v172, v91, v92, v93, v174, v95, v175, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v177, v178, v179, v180, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141)
and closure19 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) struct (v70 : US6, v71 : US6, v72 : US6, v73 : US7, v74 : US6, v75 : US6, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US8, v81 : US9, v82 : US6, v83 : US6, v84 : US8, v85 : US10, v86 : US6, v87 : US6, v88 : US6, v89 : US11, v90 : US8, v91 : US6, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US12, v98 : US6, v99 : US6, v100 : US6, v101 : US12, v102 : US6, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US13, v113 : US14, v114 : US13, v115 : US6, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US12, v133 : US6, v134 : US6, v135 : US10, v136 : US10, v137 : US6, v138 : US5, v139 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v142 : string =
        match v53 with
        | US6_0 -> (* None *)
            let v140 : string = "4px"
            v140
        | US6_1(v141) -> (* Some *)
            v141
    let v145 : string =
        match v50 with
        | US6_0 -> (* None *)
            let v143 : string = "2px"
            v143
        | US6_1(v144) -> (* Some *)
            v144
    let v148 : string =
        match v51 with
        | US6_0 -> (* None *)
            let v146 : string = "8px"
            v146
        | US6_1(v147) -> (* Some *)
            v147
    let v149 : US6 = US6_1(v145)
    let v150 : US6 = US6_1(v148)
    let v151 : US6 = US6_1(v142)
    struct (v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v149, v150, v122, v151, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139)
and closure23 (v0 : Mut4) (v1 : obj) : unit =
    let v2 : bool = v1?target?checked
    let v3 : (bool -> unit) = v0.l1
    v3 v2
    ()
and closure22 (v0 : Mut4) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (unit -> bool) = v0.l0
    let v72 : bool = v71 ()
    let v73 : US8 = US8_1(v72)
    let v74 : string = "neutral"
    let v75 : US6 = US6_1(v74)
    let v76 : (obj -> unit) = closure23(v0)
    let v77 : US13 = US13_1(v76)
    let v78 : string = "2px"
    let v79 : US6 = US6_1(v78)
    let v80 : string = "3px"
    let v81 : US6 = US6_1(v80)
    let v82 : string = "1px"
    let v83 : US6 = US6_1(v82)
    let v84 : string = "sm"
    let v85 : US6 = US6_1(v84)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v73, v12, v13, v75, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v77, v44, v45, v46, v47, v48, v49, v50, v79, v81, v53, v83, v55, v56, v57, v85, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure25 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "1.5px"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v71, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure26 () () : (JSX.Element []) =
    [||]
and closure24 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) () : (JSX.Element []) =
    let v70 : string = "Box"
    let v71 : string = "@hope-ui/solid"
    let v72 : JS.Function = import v70 v71
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure25()
    let v76 : (unit -> (JSX.Element [])) =
        match v11 with
        | US9_0 -> (* None *)
            closure26()
        | US9_1(v75) -> (* Some *)
            v75
    let v77 : JSX.Element = method5(v72, v73, v76)
    [|v77|]
and closure21 () (v0 : Mut4) : JSX.Element =
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = v0.l2
    let struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) = method6()
    let struct (v72 : US6, v73 : US6, v74 : US6, v75 : US7, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US8, v83 : US9, v84 : US6, v85 : US6, v86 : US8, v87 : US10, v88 : US6, v89 : US6, v90 : US6, v91 : US11, v92 : US8, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US6, v99 : US12, v100 : US6, v101 : US6, v102 : US6, v103 : US12, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US13, v115 : US14, v116 : US13, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US12, v135 : US6, v136 : US6, v137 : US10, v138 : US10, v139 : US6, v140 : US5, v141 : US6) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
    let v149 : US9 =
        match v83 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v143) -> (* Some *)
            let v144 : string = "children"
            let v145 : string = "solid-js"
            let v146 : JS.Function = import v144 v145
            let v147 : (unit -> (JSX.Element [])) = v146.Invoke v143 |> unbox<unit -> JSX.Element[]>
            US9_1(v147)
    let v150 : string = "Checkbox"
    let v151 : string = "@hope-ui/solid"
    let v152 : JS.Function = import v150 v151
    let v153 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure22(v0)
    let v154 : (unit -> (JSX.Element [])) = closure24(v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141)
    method5(v152, v153, v154)
and closure28 (v0 : JSX.Element) () : (JSX.Element []) =
    [|v0|]
and closure27 (v0 : JSX.Element) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (unit -> (JSX.Element [])) = closure28(v0)
    let v72 : US9 = US9_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v72, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and method13 (v0 : (Mut4 -> JSX.Element), v1 : (unit -> bool), v2 : (bool -> unit), v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6))) : JSX.Element =
    let v4 : Mut4 = {l0 = v1; l1 = v2; l2 = v3} : Mut4
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure20 (v0 : Mut3, v1 : (bool -> unit), v2 : (unit -> bool), v3 : JSX.Element) () : (JSX.Element []) =
    let v4 : US15 = v0.l3
    let v11 : JSX.Element =
        match v4 with
        | US15_0 -> (* CheckDisabled *)
            let v5 : (Mut4 -> JSX.Element) = closure21()
            let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure27(v3)
            method13(v5, v2, v1, v6)
        | US15_1 -> (* CheckEnabled *)
            let v8 : (Mut4 -> JSX.Element) = closure21()
            let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure27(v3)
            method13(v8, v2, v1, v9)
        | US15_2 -> (* CheckHidden *)
            v3
    [|v11|]
and closure18 (v0 : Mut3, v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6, v71 : (bool -> unit), v72 : (unit -> bool), v73 : JSX.Element) () : (JSX.Element []) =
    let v74 : string = "Box"
    let v75 : string = "@hope-ui/solid"
    let v76 : JS.Function = import v74 v75
    let v77 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure19(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
    let v78 : (unit -> (JSX.Element [])) = closure20(v0, v71, v72, v73)
    let v79 : JSX.Element = method5(v76, v77, v78)
    [|v79|]
and closure29 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "0"
    let v71 : US6 = US6_1(v70)
    let v72 : string = "9px"
    let v73 : US6 = US6_1(v72)
    let v74 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v71, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v73, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v74, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure30 () () : (JSX.Element []) =
    let v0 : string = "&nbsp;"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure31 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) struct (v70 : US6, v71 : US6, v72 : US6, v73 : US7, v74 : US6, v75 : US6, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US8, v81 : US9, v82 : US6, v83 : US6, v84 : US8, v85 : US10, v86 : US6, v87 : US6, v88 : US6, v89 : US11, v90 : US8, v91 : US6, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US12, v98 : US6, v99 : US6, v100 : US6, v101 : US12, v102 : US6, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US13, v113 : US14, v114 : US13, v115 : US6, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US12, v133 : US6, v134 : US6, v135 : US10, v136 : US10, v137 : US6, v138 : US5, v139 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v142 : string =
        match v24 with
        | US6_0 -> (* None *)
            let v140 : string = "$sm"
            v140
        | US6_1(v141) -> (* Some *)
            v141
    let v145 : string =
        match v29 with
        | US6_0 -> (* None *)
            let v143 : string = "center"
            v143
        | US6_1(v144) -> (* Some *)
            v144
    let v148 : string =
        match v35 with
        | US6_0 -> (* None *)
            let v146 : string = "0"
            v146
        | US6_1(v147) -> (* Some *)
            v147
    let v151 : string =
        match v34 with
        | US6_0 -> (* None *)
            let v149 : string = "0"
            v149
        | US6_1(v150) -> (* Some *)
            v150
    let v154 : string =
        match v49 with
        | US6_0 -> (* None *)
            let v152 : string = "0"
            v152
        | US6_1(v153) -> (* Some *)
            v153
    let v155 : string = "0"
    let v156 : US6 = US6_1(v155)
    let v157 : string = "flex"
    let v158 : US6 = US6_1(v157)
    let v159 : string = "6"
    let v160 : US6 = US6_1(v159)
    let v161 : string = "column"
    let v162 : US6 = US6_1(v161)
    let v163 : US6 = US6_1(v142)
    let v164 : US6 = US6_1(v145)
    let v165 : string = "$base"
    let v166 : US6 = US6_1(v165)
    let v167 : US6 = US6_1(v151)
    let v168 : US6 = US6_1(v148)
    let v169 : US6 = US6_1(v155)
    let v170 : US6 = US6_1(v155)
    let v171 : string = "85vh"
    let v172 : US6 = US6_1(v171)
    let v173 : US6 = US6_1(v155)
    let v174 : string = "auto"
    let v175 : US6 = US6_1(v174)
    let v176 : US6 = US6_1(v154)
    struct (v70, v71, v72, v73, v74, v156, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v158, v89, v90, v160, v162, v93, v163, v95, v96, v97, v98, v164, v100, v101, v166, v103, v167, v168, v169, v170, v172, v109, v110, v111, v112, v113, v114, v173, v175, v117, v118, v176, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139)
and closure34 (v0 : int32, v1 : (unit -> string), v2 : (unit -> US4), v3 : (unit -> US5)) () : (obj []) =
    let v4 : string = "loader_id:"
    let v5 : obj = struct (v4, v0)
    let v6 : string = v1 ()
    let v7 : string = "chain_token:"
    let v8 : obj = struct (v7, v6)
    let v9 : US4 = v2 ()
    let v14 : string =
        match v9 with
        | US4_0 -> (* Debug *)
            let v10 : string = "Debug"
            v10
        | US4_1 -> (* Error *)
            let v11 : string = "Error"
            v11
        | US4_2 -> (* Info *)
            let v12 : string = "Info"
            v12
        | US4_3 -> (* Warn *)
            let v13 : string = "Warn"
            v13
    let v15 : string = "log_level:"
    let v16 : obj = struct (v15, v14)
    let v17 : US5 = v3 ()
    let v18 : string = "ui_modal:"
    let v19 : obj = struct (v18, v17)
    [|v5; v8; v16; v19|]
and method17 (v0 : int32, v1 : string) : string =
    let v2 : int32 = String.length v1
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : string = $"0{v1}"
        method17(v0, v4)
    else
        v1
and closure36 (v0 : (unit -> US4), v1 : (unit -> (obj [])), v2 : string, v3 : string, v4 : obj, v5 : string, v6 : string, v7 : bool, v8 : int64, v9 : US4) (v10 : (obj [])) : unit =
    let v11 : US4 = v0 ()
    let v12 : int32 = (fst (Reflection.FSharpValue.GetUnionFields(v11, typeof<US4>))).Tag
    let v13 : int32 = (fst (Reflection.FSharpValue.GetUnionFields(v9, typeof<US4>))).Tag
    let v14 : bool = v12 <= v13
    if v14 then
        let v15 : int64 = DateTime.UtcNow.Ticks / 1000L
        let v16 : int64 = v15 - v8
        let v17 : string = v16.ToString ()
        let v18 : int32 = 6
        let v19 : string = method17(v18, v17)
        let v20 : int32 = emitJsExpr () "components_spi.run_id"
        let v21 : string = "timestamp:"
        let v22 : obj = struct (v21, v19)
        let v23 : string = "run_id:"
        let v24 : obj = struct (v23, v20)
        let v25 : (obj []) = [|v22; v24|]
        let v26 : (obj []) = v1 ()
        let v27 : string = JS.JSON.stringify v26
        let v28 : string = JS.JSON.stringify v10
        let v29 : string = JS.JSON.stringify v25
        let struct (v35 : string, v36 : string, v37 : string, v38 : string, v39 : string) =
            if v7 then
                let v30 : string = ""
                struct (v28, v27, v29, v30, v30)
            else
                let v31 : string = $"font-weight: bold; color: {v2}"
                let v32 : string = $"{v27} {v29}"
                let v33 : string = "%c%s %c%s"
                let v34 : string = "font-weight: bold; color: #444"
                struct (v33, v31, v28, v34, v32)
        emitJsExpr () $"console.log.apply(console, {struct (v35, v36, v37, v38, v39)})"
        ()
and closure35 (v0 : (unit -> US4), v1 : (unit -> (obj [])), v2 : string, v3 : string, v4 : obj, v5 : string, v6 : string, v7 : bool, v8 : int64) (v9 : US4) : ((obj []) -> unit) =
    closure36(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9)
and method16 (v0 : (unit -> US4), v1 : (unit -> (obj [])), v2 : string) : (US4 -> ((obj []) -> unit)) =
    let struct (v3 : string, v4 : obj, v5 : string, v6 : string, v7 : bool) = method2()
    let v8 : int64 = DateTime.UtcNow.Ticks / 1000L
    closure35(v0, v1, v2, v3, v4, v5, v6, v7, v8)
and method15 (v0 : (unit -> (obj [])), v1 : string) : (US4 -> ((obj []) -> unit)) =
    let v127 : obj = emitJsExpr () "components_spi.state_context"
    let v128 : string = "useContext"
    let v129 : string = "solid-js"
    let v130 : JS.Function = import v128 v129
    let struct (v131 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v132 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v133 : (unit -> int32), v134 : (int32 -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> string), v138 : (string -> unit), v139 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v140 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v141 : (unit -> (struct (US2 * obj * string) [])), v142 : ((struct (US2 * obj * string) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * obj) [])), v146 : ((struct (int64 * obj) []) -> unit), v147 : (unit -> (struct (int64 * int32) [])), v148 : ((struct (int64 * int32) []) -> unit), v149 : (unit -> US4), v150 : (US4 -> unit), v151 : (unit -> US5), v152 : (US5 -> unit)) = v130.Invoke v127 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    method16(v149, v0, v1)
and closure37 (v0 : Mut5, v1 : int32, v2 : (US5 -> unit)) () : unit =
    let v3 : bool = v0.l1
    if v3 then
        let v4 : US5 = US5_1(v1)
        v2 v4
        ()
and closure38 (v0 : (bool -> unit), v1 : (unit -> bool)) () : unit =
    let v2 : bool = v1 ()
    if v2 then
        v0 false
        ()
and closure39 (v0 : Mut5) () : unit =
    let v1 : US14 = v0.l3
    match v1 with
    | US14_0 -> (* None *)
        ()
    | US14_1(v2) -> (* Some *)
        v2 ()
        ()
and closure40 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) struct (v70 : US6, v71 : US6, v72 : US6, v73 : US7, v74 : US6, v75 : US6, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US8, v81 : US9, v82 : US6, v83 : US6, v84 : US8, v85 : US10, v86 : US6, v87 : US6, v88 : US6, v89 : US11, v90 : US8, v91 : US6, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US12, v98 : US6, v99 : US6, v100 : US6, v101 : US12, v102 : US6, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US13, v113 : US14, v114 : US13, v115 : US6, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US12, v133 : US6, v134 : US6, v135 : US10, v136 : US10, v137 : US6, v138 : US5, v139 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v140 : string = "flex"
    let v141 : US6 = US6_1(v140)
    let v142 : string = "1"
    let v143 : US6 = US6_1(v142)
    struct (v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v141, v89, v90, v143, v92, v93, v94, v95, v96, v97, v28, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139)
and closure42 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "3px 0"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v71, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and method20 (v0 : int32, v1 : Mut6) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method19 (v0 : Mut1, v1 : Mut1) : unit =
    let v2 : (string []) = JS.Constructors.Object.keys v0 |> unbox<string[]>
    let v3 : int32 = v2.Length
    let v4 : Mut6 = {l0 = 0} : Mut6
    while method20(v3, v4) do
        let v6 : int32 = v4.l0
        let v7 : string = v2.[int v6]
        let v8 : bool = emitJsExpr (v1, v7) "!!$0[$1].tag"
        if v8 then
            emitJsExpr (v0, v7, v1) "$0[$1] = $2[$1]"
            ()
        let v9 : int32 = v6 + 1
        v4.l0 <- v9
        ()
    ()
and closure45 (v0 : Mut1) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let struct (v71 : US6, v72 : US6, v73 : US6, v74 : US7, v75 : US6, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US8, v82 : US9, v83 : US6, v84 : US6, v85 : US8, v86 : US10, v87 : US6, v88 : US6, v89 : US6, v90 : US11, v91 : US8, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US12, v99 : US6, v100 : US6, v101 : US6, v102 : US12, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US13, v114 : US14, v115 : US13, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US12, v134 : US6, v135 : US6, v136 : US10, v137 : US10, v138 : US6, v139 : US5, v140 : US6) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61, v0.l62, v0.l63, v0.l64, v0.l65, v0.l66, v0.l67, v0.l68, v0.l69
    let v141 : Mut1 = {l0 = v71; l1 = v72; l2 = v73; l3 = v74; l4 = v75; l5 = v76; l6 = v77; l7 = v78; l8 = v79; l9 = v80; l10 = v81; l11 = v82; l12 = v83; l13 = v84; l14 = v85; l15 = v86; l16 = v87; l17 = v88; l18 = v89; l19 = v90; l20 = v91; l21 = v92; l22 = v93; l23 = v94; l24 = v95; l25 = v96; l26 = v97; l27 = v98; l28 = v99; l29 = v100; l30 = v101; l31 = v102; l32 = v103; l33 = v104; l34 = v105; l35 = v106; l36 = v107; l37 = v108; l38 = v109; l39 = v110; l40 = v111; l41 = v112; l42 = v113; l43 = v114; l44 = v115; l45 = v116; l46 = v117; l47 = v118; l48 = v119; l49 = v120; l50 = v121; l51 = v122; l52 = v123; l53 = v124; l54 = v125; l55 = v126; l56 = v127; l57 = v128; l58 = v129; l59 = v130; l60 = v131; l61 = v132; l62 = v133; l63 = v134; l64 = v135; l65 = v136; l66 = v137; l67 = v138; l68 = v139; l69 = v140} : Mut1
    let v142 : string = "neutral"
    let v143 : US6 = US6_1(v142)
    let v144 : US8 = US8_1(true)
    let v145 : string = "left"
    let v146 : US6 = US6_1(v145)
    let v147 : string = "xs"
    let v148 : US6 = US6_1(v147)
    let v149 : Mut1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v143; l14 = v144; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v146; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v148; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63; l63 = v64; l64 = v65; l65 = v66; l66 = v67; l67 = v68; l68 = v69; l69 = v70} : Mut1
    method19(v149, v141)
    let struct (v150 : US6, v151 : US6, v152 : US6, v153 : US7, v154 : US6, v155 : US6, v156 : US6, v157 : US6, v158 : US6, v159 : US6, v160 : US8, v161 : US9, v162 : US6, v163 : US6, v164 : US8, v165 : US10, v166 : US6, v167 : US6, v168 : US6, v169 : US11, v170 : US8, v171 : US6, v172 : US6, v173 : US6, v174 : US6, v175 : US6, v176 : US6, v177 : US12, v178 : US6, v179 : US6, v180 : US6, v181 : US12, v182 : US6, v183 : US6, v184 : US6, v185 : US6, v186 : US6, v187 : US6, v188 : US6, v189 : US6, v190 : US6, v191 : US6, v192 : US13, v193 : US14, v194 : US13, v195 : US6, v196 : US6, v197 : US6, v198 : US6, v199 : US6, v200 : US6, v201 : US6, v202 : US6, v203 : US6, v204 : US6, v205 : US6, v206 : US6, v207 : US6, v208 : US6, v209 : US6, v210 : US6, v211 : US6, v212 : US12, v213 : US6, v214 : US6, v215 : US10, v216 : US10, v217 : US6, v218 : US5, v219 : US6) = v149.l0, v149.l1, v149.l2, v149.l3, v149.l4, v149.l5, v149.l6, v149.l7, v149.l8, v149.l9, v149.l10, v149.l11, v149.l12, v149.l13, v149.l14, v149.l15, v149.l16, v149.l17, v149.l18, v149.l19, v149.l20, v149.l21, v149.l22, v149.l23, v149.l24, v149.l25, v149.l26, v149.l27, v149.l28, v149.l29, v149.l30, v149.l31, v149.l32, v149.l33, v149.l34, v149.l35, v149.l36, v149.l37, v149.l38, v149.l39, v149.l40, v149.l41, v149.l42, v149.l43, v149.l44, v149.l45, v149.l46, v149.l47, v149.l48, v149.l49, v149.l50, v149.l51, v149.l52, v149.l53, v149.l54, v149.l55, v149.l56, v149.l57, v149.l58, v149.l59, v149.l60, v149.l61, v149.l62, v149.l63, v149.l64, v149.l65, v149.l66, v149.l67, v149.l68, v149.l69
    struct (v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219)
and closure46 () () : (JSX.Element []) =
    [||]
and method18 (v0 : Mut1) : JSX.Element =
    let v1 : string = "Button"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure45(v0)
    let v5 : US9 = v0.l11
    let v8 : (unit -> (JSX.Element [])) =
        match v5 with
        | US9_0 -> (* None *)
            closure46()
        | US9_1(v7) -> (* Some *)
            v7
    method5(v3, v4, v8)
and closure44 () (v0 : Mut1) : JSX.Element =
    method18(v0)
and closure48 (v0 : (bool -> unit), v1 : Mut5) () : unit =
    let v2 : US14 = v1.l2
    match v2 with
    | US14_0 -> (* None *)
        ()
    | US14_1(v3) -> (* Some *)
        v3 ()
        ()
    v0 true
    ()
and closure47 (v0 : (bool -> unit), v1 : Mut5) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : (unit -> unit) = closure48(v0, v1)
    let v73 : US14 = US14_1(v72)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v73, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
and closure49 () () : (JSX.Element []) =
    let v0 : string = "Load"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and method21 (v0 : (Mut1 -> JSX.Element), v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)), v2 : (unit -> (JSX.Element []))) : JSX.Element =
    let struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US10, v19 : US6, v20 : US6, v21 : US6, v22 : US11, v23 : US8, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US12, v31 : US6, v32 : US6, v33 : US6, v34 : US12, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US13, v46 : US14, v47 : US13, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US12, v66 : US6, v67 : US6, v68 : US10, v69 : US10, v70 : US6, v71 : US5, v72 : US6) = method6()
    let struct (v73 : US6, v74 : US6, v75 : US6, v76 : US7, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US6, v83 : US8, v84 : US9, v85 : US6, v86 : US6, v87 : US8, v88 : US10, v89 : US6, v90 : US6, v91 : US6, v92 : US11, v93 : US8, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US6, v99 : US6, v100 : US12, v101 : US6, v102 : US6, v103 : US6, v104 : US12, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US6, v115 : US13, v116 : US14, v117 : US13, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US6, v135 : US12, v136 : US6, v137 : US6, v138 : US10, v139 : US10, v140 : US6, v141 : US5, v142 : US6) = v1 struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v150 : US9 =
        match v84 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v144) -> (* Some *)
            let v145 : string = "children"
            let v146 : string = "solid-js"
            let v147 : JS.Function = import v145 v146
            let v148 : (unit -> (JSX.Element [])) = v147.Invoke v144 |> unbox<unit -> JSX.Element[]>
            US9_1(v148)
    let v152 : (unit -> (JSX.Element [])) =
        match v150 with
        | US9_0 -> (* None *)
            v2
        | US9_1(v151) -> (* Some *)
            v151
    let v153 : US9 = US9_1(v152)
    let v154 : Mut1 = {l0 = v73; l1 = v74; l2 = v75; l3 = v76; l4 = v77; l5 = v78; l6 = v79; l7 = v80; l8 = v81; l9 = v82; l10 = v83; l11 = v153; l12 = v85; l13 = v86; l14 = v87; l15 = v88; l16 = v89; l17 = v90; l18 = v91; l19 = v92; l20 = v93; l21 = v94; l22 = v95; l23 = v96; l24 = v97; l25 = v98; l26 = v99; l27 = v100; l28 = v101; l29 = v102; l30 = v103; l31 = v104; l32 = v105; l33 = v106; l34 = v107; l35 = v108; l36 = v109; l37 = v110; l38 = v111; l39 = v112; l40 = v113; l41 = v114; l42 = v115; l43 = v116; l44 = v117; l45 = v118; l46 = v119; l47 = v120; l48 = v121; l49 = v122; l50 = v123; l51 = v124; l52 = v125; l53 = v126; l54 = v127; l55 = v128; l56 = v129; l57 = v130; l58 = v131; l59 = v132; l60 = v133; l61 = v134; l62 = v135; l63 = v136; l64 = v137; l65 = v138; l66 = v139; l67 = v140; l68 = v141; l69 = v142} : Mut1
    emitJsExpr (v154, v2) "$0.children = $1"
    let v155 : string = "createComponent"
    let v156 : string = "solid-js"
    let v157 : JS.Function = import v155 v156
    let v158 : JSX.Element = v157.Invoke (v0, v154) |> unbox<JSX.Element>
    v158
and closure43 (v0 : (bool -> unit), v1 : Mut5) () : (JSX.Element []) =
    let v2 : (Mut1 -> JSX.Element) = closure44()
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure47(v0, v1)
    let v4 : (unit -> (JSX.Element [])) = closure49()
    let v5 : JSX.Element = method21(v2, v3, v4)
    [|v5|]
and closure50 (v0 : int32, v1 : (unit -> US5)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : US5 = v1 ()
    let v76 : bool =
        match v72 with
        | US5_1(v74) -> (* Some *)
            let v75 : bool = v74 = v0
            v75
        | _ ->
            false
    let v80 : US6 =
        if v76 then
            let v77 : string = "$bg"
            US6_1(v77)
        else
            US6_0
    let v81 : US5 = v1 ()
    let v85 : bool =
        match v81 with
        | US5_1(v83) -> (* Some *)
            let v84 : bool = v83 = v0
            v84
        | _ ->
            false
    let v89 : US6 =
        if v85 then
            let v86 : string = "0"
            US6_1(v86)
        else
            US6_0
    let v90 : US5 = v1 ()
    let v94 : bool =
        match v90 with
        | US5_1(v92) -> (* Some *)
            let v93 : bool = v92 = v0
            v93
        | _ ->
            false
    let v98 : US6 =
        if v94 then
            let v95 : string = "0"
            US6_1(v95)
        else
            US6_0
    let v99 : US5 = v1 ()
    let v103 : bool =
        match v99 with
        | US5_1(v101) -> (* Some *)
            let v102 : bool = v101 = v0
            v102
        | _ ->
            false
    let v107 : US6 =
        if v103 then
            let v104 : string = "fixed"
            US6_1(v104)
        else
            US6_0
    let v108 : US5 = v1 ()
    let v112 : bool =
        match v108 with
        | US5_1(v110) -> (* Some *)
            let v111 : bool = v110 = v0
            v111
        | _ ->
            false
    let v116 : US6 =
        if v112 then
            let v113 : string = "0"
            US6_1(v113)
        else
            US6_0
    let v117 : US5 = v1 ()
    let v121 : bool =
        match v117 with
        | US5_1(v119) -> (* Some *)
            let v120 : bool = v119 = v0
            v120
        | _ ->
            false
    let v125 : US6 =
        if v121 then
            let v122 : string = "0"
            US6_1(v122)
        else
            US6_0
    let v126 : US5 = v1 ()
    let v130 : bool =
        match v126 with
        | US5_1(v128) -> (* Some *)
            let v129 : bool = v128 = v0
            v129
        | _ ->
            false
    let v133 : US5 =
        if v130 then
            US5_1(1)
        else
            US5_0
    let v134 : string = "flex"
    let v135 : US6 = US6_1(v134)
    let v136 : string = "1"
    let v137 : US6 = US6_1(v136)
    struct (v2, v3, v4, v5, v80, v7, v8, v9, v10, v89, v12, v13, v14, v15, v16, v17, v18, v19, v135, v21, v22, v137, v24, v25, v26, v27, v28, v29, v30, v31, v98, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v107, v116, v59, v60, v61, v62, v63, v64, v125, v66, v67, v68, v69, v133, v71)
and closure52 (v0 : (unit -> US5)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : US5 = v0 ()
    let v73 : bool =
        match v71 with
        | US5_0 -> (* None *)
            true
        | _ ->
            false
    let v77 : US6 =
        if v73 then
            let v74 : string = "relative"
            US6_1(v74)
        else
            US6_0
    let v78 : string = "flex"
    let v79 : US6 = US6_1(v78)
    let v80 : string = "1"
    let v81 : US6 = US6_1(v80)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v79, v20, v21, v81, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v77, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure54 (v0 : int32, v1 : (unit -> US5)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : US5 = v1 ()
    let v81 : US6 =
        match v72 with
        | US5_0 -> (* None *)
            US6_0
        | US5_1(v74) -> (* Some *)
            let v75 : bool = v74 = v0
            let v76 : bool = v75 <> true
            if v76 then
                let v77 : string = "none"
                US6_1(v77)
            else
                US6_0
    let v82 : string = "row"
    let v83 : US6 = US6_1(v82)
    let v84 : string = "absolute"
    let v85 : US6 = US6_1(v84)
    let v86 : string = "6px"
    let v87 : US6 = US6_1(v86)
    let v88 : string = "3px"
    let v89 : US6 = US6_1(v88)
    let v90 : US6 = US6_1(v86)
    let v91 : US5 = US5_1(2)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v83, v81, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v85, v87, v59, v89, v61, v62, v63, v64, v90, v66, v67, v68, v69, v91, v71)
and closure58 (v0 : Mut7) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (unit -> JS.Function) = v0.l1
    let v72 : JS.Function = v71 ()
    let struct (v73 : US6, v74 : US6, v75 : US6, v76 : US7, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US6, v83 : US8, v84 : US9, v85 : US6, v86 : US6, v87 : US8, v88 : US10, v89 : US6, v90 : US6, v91 : US6, v92 : US11, v93 : US8, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US6, v99 : US6, v100 : US12, v101 : US6, v102 : US6, v103 : US6, v104 : US12, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US6, v115 : US13, v116 : US14, v117 : US13, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US6, v135 : US12, v136 : US6, v137 : US6, v138 : US10, v139 : US10, v140 : US6, v141 : US5, v142 : US6) = method6()
    let v150 : US9 =
        match v84 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v144) -> (* Some *)
            let v145 : string = "children"
            let v146 : string = "solid-js"
            let v147 : JS.Function = import v145 v146
            let v148 : (unit -> (JSX.Element [])) = v147.Invoke v144 |> unbox<unit -> JSX.Element[]>
            US9_1(v148)
    let v151 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = v0.l0
    let v152 : string = "-12px"
    let v153 : US6 = US6_1(v152)
    let v154 : US6 = US6_1(v152)
    let v155 : string = "0.6"
    let v156 : US6 = US6_1(v155)
    let struct (v157 : US6, v158 : US6, v159 : US6, v160 : US7, v161 : US6, v162 : US6, v163 : US6, v164 : US6, v165 : US6, v166 : US6, v167 : US8, v168 : US9, v169 : US6, v170 : US6, v171 : US8, v172 : US10, v173 : US6, v174 : US6, v175 : US6, v176 : US11, v177 : US8, v178 : US6, v179 : US6, v180 : US6, v181 : US6, v182 : US6, v183 : US6, v184 : US12, v185 : US6, v186 : US6, v187 : US6, v188 : US12, v189 : US6, v190 : US6, v191 : US6, v192 : US6, v193 : US6, v194 : US6, v195 : US6, v196 : US6, v197 : US6, v198 : US6, v199 : US13, v200 : US14, v201 : US13, v202 : US6, v203 : US6, v204 : US6, v205 : US6, v206 : US6, v207 : US6, v208 : US6, v209 : US6, v210 : US6, v211 : US6, v212 : US6, v213 : US6, v214 : US6, v215 : US6, v216 : US6, v217 : US6, v218 : US6, v219 : US12, v220 : US6, v221 : US6, v222 : US10, v223 : US10, v224 : US6, v225 : US5, v226 : US6) = v151 struct (v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v150, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v153, v109, v154, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v156)
    let v227 : ((string * obj) []) = method7(v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v220, v221, v222, v223, v224, v225, v226)
    let v228 : obj = createObj v227
    let v229 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = v0.l2
    let v230 : US7 = US7_1(v72)
    let v231 : US10 = US10_1(v228)
    let v232 : string = "14px"
    let v233 : US6 = US6_1(v232)
    let struct (v234 : US6, v235 : US6, v236 : US6, v237 : US7, v238 : US6, v239 : US6, v240 : US6, v241 : US6, v242 : US6, v243 : US6, v244 : US8, v245 : US9, v246 : US6, v247 : US6, v248 : US8, v249 : US10, v250 : US6, v251 : US6, v252 : US6, v253 : US11, v254 : US8, v255 : US6, v256 : US6, v257 : US6, v258 : US6, v259 : US6, v260 : US6, v261 : US12, v262 : US6, v263 : US6, v264 : US6, v265 : US12, v266 : US6, v267 : US6, v268 : US6, v269 : US6, v270 : US6, v271 : US6, v272 : US6, v273 : US6, v274 : US6, v275 : US6, v276 : US13, v277 : US14, v278 : US13, v279 : US6, v280 : US6, v281 : US6, v282 : US6, v283 : US6, v284 : US6, v285 : US6, v286 : US6, v287 : US6, v288 : US6, v289 : US6, v290 : US6, v291 : US6, v292 : US6, v293 : US6, v294 : US6, v295 : US6, v296 : US12, v297 : US6, v298 : US6, v299 : US10, v300 : US10, v301 : US6, v302 : US5, v303 : US6) = v229 struct (v1, v2, v3, v230, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v231, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v233, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
    struct (v234, v235, v236, v237, v238, v239, v240, v241, v242, v243, v244, v245, v246, v247, v248, v249, v250, v251, v252, v253, v254, v255, v256, v257, v258, v259, v260, v261, v262, v263, v264, v265, v266, v267, v268, v269, v270, v271, v272, v273, v274, v275, v276, v277, v278, v279, v280, v281, v282, v283, v284, v285, v286, v287, v288, v289, v290, v291, v292, v293, v294, v295, v296, v297, v298, v299, v300, v301, v302, v303)
and closure59 () () : (JSX.Element []) =
    [||]
and method22 (v0 : Mut7) : JSX.Element =
    let v1 : string = "Icon"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure58(v0)
    let v5 : (unit -> (JSX.Element [])) = closure59()
    method5(v3, v4, v5)
and closure57 () (v0 : Mut7) : JSX.Element =
    method22(v0)
and closure60 () () : JS.Function =
    let v0 : string = "BiRegularRefresh"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and method23 (v0 : (Mut7 -> JSX.Element), v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)), v2 : (unit -> JS.Function)) : JSX.Element =
    let v3 : Mut7 = {l0 = v1; l1 = v2; l2 = v1} : Mut7
    let v4 : string = "createComponent"
    let v5 : string = "solid-js"
    let v6 : JS.Function = import v4 v5
    let v7 : JSX.Element = v6.Invoke (v0, v3) |> unbox<JSX.Element>
    v7
and closure61 (v0 : (bool -> unit)) () : unit =
    v0 true
    ()
and closure56 (v0 : (bool -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (Mut7 -> JSX.Element) = closure57()
    let v72 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v73 : (unit -> JS.Function) = closure60()
    let v74 : JSX.Element = method23(v71, v72, v73)
    let v75 : string = "Refresh"
    let v76 : US6 = US6_1(v75)
    let v77 : string = "neutral"
    let v78 : US6 = US6_1(v77)
    let v79 : string = "20px"
    let v80 : US6 = US6_1(v79)
    let v81 : US12 = US12_1(v74)
    let v82 : (unit -> unit) = closure61(v0)
    let v83 : US14 = US14_1(v82)
    let v84 : string = "xs"
    let v85 : US6 = US6_1(v84)
    struct (v1, v2, v76, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v78, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v80, v27, v81, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v83, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v85, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure62 () () : (JSX.Element []) =
    [||]
and closure64 () () : JS.Function =
    let v0 : string = "BiRegularDownArrow"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure65 () () : JS.Function =
    let v0 : string = "BiRegularUpArrow"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure66 (v0 : int32, v1 : (US5 -> unit), v2 : (unit -> US5)) () : unit =
    let v3 : US5 = v2 ()
    let v7 : bool =
        match v3 with
        | US5_1(v5) -> (* Some *)
            let v6 : bool = v5 = v0
            v6
        | _ ->
            false
    let v8 : bool = v7 = false
    let v11 : US5 =
        if v8 then
            US5_1(v0)
        else
            US5_0
    v1 v11
    ()
and closure63 (v0 : int32, v1 : (US5 -> unit), v2 : (unit -> US5)) struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US10, v19 : US6, v20 : US6, v21 : US6, v22 : US11, v23 : US8, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US12, v31 : US6, v32 : US6, v33 : US6, v34 : US12, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US13, v46 : US14, v47 : US13, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US12, v66 : US6, v67 : US6, v68 : US10, v69 : US10, v70 : US6, v71 : US5, v72 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v73 : US5 = v2 ()
    let v77 : bool =
        match v73 with
        | US5_1(v75) -> (* Some *)
            let v76 : bool = v75 = v0
            v76
        | _ ->
            false
    let v80 : string =
        if v77 then
            let v78 : string = "Restore"
            v78
        else
            let v79 : string = "Maximize"
            v79
    let v81 : (Mut7 -> JSX.Element) = closure57()
    let v82 : US5 = v2 ()
    let v86 : bool =
        match v82 with
        | US5_1(v84) -> (* Some *)
            let v85 : bool = v84 = v0
            v85
        | _ ->
            false
    let v89 : (unit -> JS.Function) =
        if v86 then
            closure64()
        else
            closure65()
    let v90 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v91 : JSX.Element = method23(v81, v90, v89)
    let v92 : US6 = US6_1(v80)
    let v93 : string = "neutral"
    let v94 : US6 = US6_1(v93)
    let v95 : string = "20px"
    let v96 : US6 = US6_1(v95)
    let v97 : US12 = US12_1(v91)
    let v98 : (unit -> unit) = closure66(v0, v1, v2)
    let v99 : US14 = US14_1(v98)
    let v100 : string = "xs"
    let v101 : US6 = US6_1(v100)
    struct (v3, v4, v92, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v94, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v96, v29, v97, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v99, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v101, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
and closure67 () () : (JSX.Element []) =
    [||]
and closure69 () () : JS.Function =
    let v0 : string = "BiRegularUndo"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure70 (v0 : (bool -> unit), v1 : Mut5) () : unit =
    let v2 : US14 = v1.l3
    match v2 with
    | US14_0 -> (* None *)
        ()
    | US14_1(v3) -> (* Some *)
        v3 ()
        ()
    v0 false
    ()
and closure68 (v0 : (bool -> unit), v1 : Mut5) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : (Mut7 -> JSX.Element) = closure57()
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v74 : (unit -> JS.Function) = closure69()
    let v75 : JSX.Element = method23(v72, v73, v74)
    let v76 : string = "Unload"
    let v77 : US6 = US6_1(v76)
    let v78 : string = "neutral"
    let v79 : US6 = US6_1(v78)
    let v80 : string = "20px"
    let v81 : US6 = US6_1(v80)
    let v82 : US12 = US12_1(v75)
    let v83 : (unit -> unit) = closure70(v0, v1)
    let v84 : US14 = US14_1(v83)
    let v85 : string = "xs"
    let v86 : US6 = US6_1(v85)
    struct (v2, v3, v77, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v79, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v81, v28, v82, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v84, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v86, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
and closure71 () () : (JSX.Element []) =
    [||]
and closure55 (v0 : int32, v1 : (US5 -> unit), v2 : (bool -> unit), v3 : (bool -> unit), v4 : Mut5, v5 : (unit -> US5)) () : (JSX.Element []) =
    let v6 : string = "IconButton"
    let v7 : string = "@hope-ui/solid"
    let v8 : JS.Function = import v6 v7
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure56(v3)
    let v10 : (unit -> (JSX.Element [])) = closure62()
    let v11 : JSX.Element = method5(v8, v9, v10)
    let v12 : JS.Function = import v6 v7
    let v13 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure63(v0, v1, v5)
    let v14 : (unit -> (JSX.Element [])) = closure67()
    let v15 : JSX.Element = method5(v12, v13, v14)
    let v16 : JS.Function = import v6 v7
    let v17 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure68(v2, v4)
    let v18 : (unit -> (JSX.Element [])) = closure71()
    let v19 : JSX.Element = method5(v16, v17, v18)
    [|v11; v15; v19|]
and closure53 (v0 : int32, v1 : (US5 -> unit), v2 : (unit -> US5), v3 : (bool -> unit), v4 : (bool -> unit), v5 : (unit -> bool), v6 : Mut5, v7 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v8 : string = "Stack"
    let v9 : string = "@hope-ui/solid"
    let v10 : JS.Function = import v8 v9
    let v11 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure54(v0, v2)
    let v12 : (unit -> (JSX.Element [])) = closure55(v0, v1, v3, v4, v6, v2)
    let v13 : JSX.Element = method5(v10, v11, v12)
    let v14 : bool = v5 ()
    let v17 : JSX.Element =
        if v14 then
            let v15 : JSX.Element = JS.undefined
            v15
        else
            let v16 : JSX.Element = v7 |> unbox<JSX.Element>
            v16
    [|v13; v17|]
and closure51 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6, v70 : int32, v71 : (US5 -> unit), v72 : (unit -> US5), v73 : (bool -> unit), v74 : (bool -> unit), v75 : (unit -> bool), v76 : Mut5) () : (JSX.Element []) =
    let v85 : JSX.Element =
        match v11 with
        | US9_0 -> (* None *)
            let v77 : JSX.Element = JS.undefined
            v77
        | US9_1(v78) -> (* Some *)
            let v79 : string = "Box"
            let v80 : string = "@hope-ui/solid"
            let v81 : JS.Function = import v79 v80
            let v82 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure52(v72)
            let v83 : (unit -> (JSX.Element [])) = closure53(v70, v71, v72, v73, v74, v75, v76, v78)
            method5(v81, v82, v83)
    [|v85|]
and closure41 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6, v70 : int32, v71 : (US5 -> unit), v72 : (unit -> US5), v73 : (bool -> unit), v74 : (unit -> bool), v75 : (bool -> unit), v76 : (unit -> bool), v77 : Mut5) () : (JSX.Element []) =
    let v78 : bool = v74 ()
    let v79 : bool = v78 = false
    let v92 : JSX.Element =
        if v79 then
            let v80 : string = "Box"
            let v81 : string = "@hope-ui/solid"
            let v82 : JS.Function = import v80 v81
            let v83 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure42()
            let v84 : (unit -> (JSX.Element [])) = closure43(v73, v77)
            method5(v82, v83, v84)
        else
            let v86 : string = "Box"
            let v87 : string = "@hope-ui/solid"
            let v88 : JS.Function = import v86 v87
            let v89 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure50(v70, v72)
            let v90 : (unit -> (JSX.Element [])) = closure51(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v75, v76, v77)
            method5(v88, v89, v90)
    [|v92|]
and method14 (v0 : Mut5) : JSX.Element =
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = v0.l4
    let struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) = method6()
    let struct (v72 : US6, v73 : US6, v74 : US6, v75 : US7, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US8, v83 : US9, v84 : US6, v85 : US6, v86 : US8, v87 : US10, v88 : US6, v89 : US6, v90 : US6, v91 : US11, v92 : US8, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US6, v99 : US12, v100 : US6, v101 : US6, v102 : US6, v103 : US12, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US13, v115 : US14, v116 : US13, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US12, v135 : US6, v136 : US6, v137 : US10, v138 : US10, v139 : US6, v140 : US5, v141 : US6) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
    let v149 : US9 =
        match v83 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v143) -> (* Some *)
            let v144 : string = "children"
            let v145 : string = "solid-js"
            let v146 : JS.Function = import v144 v145
            let v147 : (unit -> (JSX.Element [])) = v146.Invoke v143 |> unbox<unit -> JSX.Element[]>
            US9_1(v147)
    let v150 : int32 = Random().Next ()
    let v276 : obj = emitJsExpr () "components_spi.state_context"
    let v277 : string = "useContext"
    let v278 : string = "solid-js"
    let v279 : JS.Function = import v277 v278
    let struct (v280 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v281 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v282 : (unit -> int32), v283 : (int32 -> unit), v284 : (unit -> string), v285 : (string -> unit), v286 : (unit -> string), v287 : (string -> unit), v288 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v289 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v290 : (unit -> (struct (US2 * obj * string) [])), v291 : ((struct (US2 * obj * string) []) -> unit), v292 : (unit -> (struct (int64 * obj) [])), v293 : ((struct (int64 * obj) []) -> unit), v294 : (unit -> (struct (int64 * obj) [])), v295 : ((struct (int64 * obj) []) -> unit), v296 : (unit -> (struct (int64 * int32) [])), v297 : ((struct (int64 * int32) []) -> unit), v298 : (unit -> US4), v299 : (US4 -> unit), v300 : (unit -> US5), v301 : (US5 -> unit)) = v279.Invoke v276 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v425 : obj = emitJsExpr () "components_spi.state_context"
    let v426 : JS.Function = import v277 v278
    let struct (v427 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v428 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v429 : (unit -> int32), v430 : (int32 -> unit), v431 : (unit -> string), v432 : (string -> unit), v433 : (unit -> string), v434 : (string -> unit), v435 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v436 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v437 : (unit -> (struct (US2 * obj * string) [])), v438 : ((struct (US2 * obj * string) []) -> unit), v439 : (unit -> (struct (int64 * obj) [])), v440 : ((struct (int64 * obj) []) -> unit), v441 : (unit -> (struct (int64 * obj) [])), v442 : ((struct (int64 * obj) []) -> unit), v443 : (unit -> (struct (int64 * int32) [])), v444 : ((struct (int64 * int32) []) -> unit), v445 : (unit -> US4), v446 : (US4 -> unit), v447 : (unit -> US5), v448 : (US5 -> unit)) = v426.Invoke v425 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v572 : obj = emitJsExpr () "components_spi.state_context"
    let v573 : JS.Function = import v277 v278
    let struct (v574 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v575 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v576 : (unit -> int32), v577 : (int32 -> unit), v578 : (unit -> string), v579 : (string -> unit), v580 : (unit -> string), v581 : (string -> unit), v582 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v583 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v584 : (unit -> (struct (US2 * obj * string) [])), v585 : ((struct (US2 * obj * string) []) -> unit), v586 : (unit -> (struct (int64 * obj) [])), v587 : ((struct (int64 * obj) []) -> unit), v588 : (unit -> (struct (int64 * obj) [])), v589 : ((struct (int64 * obj) []) -> unit), v590 : (unit -> (struct (int64 * int32) [])), v591 : ((struct (int64 * int32) []) -> unit), v592 : (unit -> US4), v593 : (US4 -> unit), v594 : (unit -> US5), v595 : (US5 -> unit)) = v573.Invoke v572 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v596 : (unit -> (obj [])) = closure34(v150, v284, v445, v594)
    let v597 : string = "#de884c"
    let v598 : (US4 -> ((obj []) -> unit)) = method15(v596, v597)
    let v599 : US4 = US4_0
    let v600 : ((obj []) -> unit) = v598 v599
    let v601 : string = "> loader ()"
    let v602 : obj = v601
    let v603 : (obj []) = [|v602|]
    v600 v603
    let v604 : bool = v0.l0
    let v605 : string = "createSignal"
    let v606 : JS.Function = import v605 v278
    let v607 : (JS.Function []) = v606.Invoke v604 |> unbox<JS.Function[]>
    let v608 : (unit -> bool) = v607.[0] |> unbox
    let v609 : (bool -> unit) = v607.[1] |> unbox
    let v610 : JS.Function = import v605 v278
    let v611 : (JS.Function []) = v610.Invoke false |> unbox<JS.Function[]>
    let v612 : (unit -> bool) = v611.[0] |> unbox
    let v613 : (bool -> unit) = v611.[1] |> unbox
    let v614 : string = "createEffect"
    let v615 : JS.Function = import v614 v278
    let v616 : (unit -> unit) = closure37(v0, v150, v595)
    v615.Invoke v616 |> ignore
    let v617 : JS.Function = import v614 v278
    let v618 : (unit -> unit) = closure38(v613, v612)
    v617.Invoke v618 |> ignore
    let v619 : string = "onCleanup"
    let v620 : JS.Function = import v619 v278
    let v621 : (unit -> unit) = closure39(v0)
    v620.Invoke v621 |> ignore
    let v622 : bool = v0.l0
    let v623 : bool = v622 = true
    if v623 then
        let v624 : US14 = v0.l2
        match v624 with
        | US14_0 -> (* None *)
            ()
        | US14_1(v625) -> (* Some *)
            v625 ()
            ()
    let v626 : string = "Box"
    let v627 : string = "@hope-ui/solid"
    let v628 : JS.Function = import v626 v627
    let v629 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure40(v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141)
    let v630 : (unit -> (JSX.Element [])) = closure41(v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v150, v595, v594, v609, v608, v613, v612, v0)
    method5(v628, v629, v630)
and closure33 () (v0 : Mut5) : JSX.Element =
    method14(v0)
and closure72 (v0 : (unit -> (JSX.Element []))) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : US9 = US9_1(v0)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v71, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and method24 (v0 : (Mut5 -> JSX.Element), v1 : bool, v2 : bool, v3 : US14, v4 : US14, v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6))) : JSX.Element =
    let v6 : Mut5 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5} : Mut5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v0, v6) |> unbox<JSX.Element>
    v10
and closure32 (v0 : Mut3, v1 : (unit -> bool), v2 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v3 : US15 = v0.l3
    let v25 : JSX.Element =
        match v3 with
        | US15_0 -> (* CheckDisabled *)
            let v4 : bool = v1 ()
            if v4 then
                let v5 : (Mut5 -> JSX.Element) = closure33()
                let v6 : US14 = v0.l0
                let v7 : US14 = v0.l1
                let v8 : bool = true
                let v9 : bool = false
                let v10 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure72(v2)
                method24(v5, v8, v9, v6, v7, v10)
            else
                let v12 : JSX.Element = JS.undefined
                v12
        | US15_1 -> (* CheckEnabled *)
            let v14 : bool = v1 ()
            if v14 then
                let v15 : (Mut5 -> JSX.Element) = closure33()
                let v16 : US14 = v0.l0
                let v17 : US14 = v0.l1
                let v18 : bool = true
                let v19 : bool = false
                let v20 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure72(v2)
                method24(v15, v18, v19, v16, v17, v20)
            else
                let v22 : JSX.Element = JS.undefined
                v22
        | US15_2 -> (* CheckHidden *)
            let v24 : JSX.Element = v2 |> unbox<JSX.Element>
            v24
    [|v25|]
and closure16 (v0 : Mut3, v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6, v71 : (bool -> unit), v72 : (unit -> bool)) () : (JSX.Element []) =
    let v81 : JSX.Element =
        match v63 with
        | US12_0 -> (* None *)
            let v73 : JSX.Element = JS.undefined
            v73
        | US12_1(v74) -> (* Some *)
            let v75 : string = "Td"
            let v76 : string = "@hope-ui/solid"
            let v77 : JS.Function = import v75 v76
            let v78 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure17(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v72)
            let v79 : (unit -> (JSX.Element [])) = closure18(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v74)
            method5(v77, v78, v79)
    let v95 : JSX.Element =
        match v12 with
        | US9_0 -> (* None *)
            let v82 : string = "Td"
            let v83 : string = "@hope-ui/solid"
            let v84 : JS.Function = import v82 v83
            let v85 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure29()
            let v86 : (unit -> (JSX.Element [])) = closure30()
            method5(v84, v85, v86)
        | US9_1(v88) -> (* Some *)
            let v89 : string = "Td"
            let v90 : string = "@hope-ui/solid"
            let v91 : JS.Function = import v89 v90
            let v92 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure31(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
            let v93 : (unit -> (JSX.Element [])) = closure32(v0, v72, v88)
            method5(v91, v92, v93)
    [|v81; v95|]
and method11 (v0 : Mut3) : JSX.Element =
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = v0.l2
    let struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) = method6()
    let struct (v72 : US6, v73 : US6, v74 : US6, v75 : US7, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US8, v83 : US9, v84 : US6, v85 : US6, v86 : US8, v87 : US10, v88 : US6, v89 : US6, v90 : US6, v91 : US11, v92 : US8, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US6, v99 : US12, v100 : US6, v101 : US6, v102 : US6, v103 : US12, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US13, v115 : US14, v116 : US13, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US12, v135 : US6, v136 : US6, v137 : US10, v138 : US10, v139 : US6, v140 : US5, v141 : US6) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
    let v149 : US9 =
        match v83 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v143) -> (* Some *)
            let v144 : string = "children"
            let v145 : string = "solid-js"
            let v146 : JS.Function = import v144 v145
            let v147 : (unit -> (JSX.Element [])) = v146.Invoke v143 |> unbox<unit -> JSX.Element[]>
            US9_1(v147)
    let v150 : US15 = v0.l3
    let v152 : bool =
        match v150 with
        | US15_0 -> (* CheckDisabled *)
            true
        | _ ->
            false
    let v153 : bool = v152 <> true
    let v154 : string = "createSignal"
    let v155 : string = "solid-js"
    let v156 : JS.Function = import v154 v155
    let v157 : (JS.Function []) = v156.Invoke v153 |> unbox<JS.Function[]>
    let v158 : (unit -> bool) = v157.[0] |> unbox
    let v159 : (bool -> unit) = v157.[1] |> unbox
    let v160 : string = "Tr"
    let v161 : string = "@hope-ui/solid"
    let v162 : JS.Function = import v160 v161
    let v163 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure15(v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141)
    let v164 : (unit -> (JSX.Element [])) = closure16(v0, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v159, v158)
    method5(v162, v163, v164)
and closure14 () (v0 : Mut3) : JSX.Element =
    method11(v0)
and closure79 (v0 : Mut1) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : US6 = v0.l37
    let v72 : US6 = v0.l54
    let v73 : US13 = v0.l42
    let v74 : US10 = v0.l65
    let v75 : string = "xs"
    let v76 : US6 = US6_1(v75)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v71, v39, v40, v41, v42, v73, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v72, v56, v57, v76, v59, v60, v61, v62, v63, v64, v65, v74, v67, v68, v69, v70)
and closure81 (v0 : (obj [])) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (obj []) = v0 |> unbox<(obj [])>
    let v72 : US11 = US11_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v72, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure83 (v0 : obj) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : US10 = US10_1(v0)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v71, v67, v68, v69, v70)
and closure84 (v0 : obj) () : (JSX.Element []) =
    let v1 : string = v0.ToString ()
    let v2 : JSX.Element = v1 |> unbox<JSX.Element>
    let v3 : JSX.Element = Html.fragment [ v2 ]
    [|v3|]
and closure82 () (v0 : obj) : (JSX.Element []) =
    let v1 : string = "SimpleOption"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure83(v0)
    let v5 : (unit -> (JSX.Element [])) = closure84(v0)
    let v6 : JSX.Element = method5(v3, v4, v5)
    [|v6|]
and closure80 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : US11 = v0.l19
    let v2 : (obj []) = [||]
    let v4 : (obj []) =
        match v1 with
        | US11_0 -> (* None *)
            v2
        | US11_1(v3) -> (* Some *)
            v3
    let v5 : string = "For"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure81(v4)
    let v9 : (obj -> (JSX.Element [])) = closure82()
    let v10 : (unit -> (JSX.Element [])) = v9 |> unbox<(unit -> (JSX.Element []))>
    let v11 : JSX.Element = method5(v7, v8, v10)
    [|v11|]
and method25 (v0 : Mut1) : JSX.Element =
    let v1 : string = "SimpleSelect"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure79(v0)
    let v5 : (unit -> (JSX.Element [])) = closure80(v0)
    method5(v3, v4, v5)
and closure78 () (v0 : Mut1) : JSX.Element =
    method25(v0)
and closure86 (v0 : (US4 -> unit)) (v1 : obj) : unit =
    let v2 : string = v1.ToString ()
    let v3 : bool = "Debug" = v2
    let v15 : US4 =
        if v3 then
            US4_0
        else
            let v5 : bool = "Info" = v2
            if v5 then
                US4_2
            else
                let v7 : bool = "Warn" = v2
                if v7 then
                    US4_3
                else
                    let v9 : bool = "Error" = v2
                    US4_1
    v0 v15
    ()
and closure85 (v0 : (US4 -> unit), v1 : (unit -> US4)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : US4 = US4_0
    let v73 : US4 = US4_2
    let v74 : US4 = US4_3
    let v75 : US4 = US4_1
    let v76 : (US4 []) = [|v72; v73; v74; v75|]
    let v77 : int32 = v76.Length
    let v78 : (string []) = Array.zeroCreate<string> (v77)
    let v79 : Mut6 = {l0 = 0} : Mut6
    while method20(v77, v79) do
        let v81 : int32 = v79.l0
        let v82 : US4 = v76.[int v81]
        let v87 : string =
            match v82 with
            | US4_0 -> (* Debug *)
                let v83 : string = "Debug"
                v83
            | US4_1 -> (* Error *)
                let v84 : string = "Error"
                v84
            | US4_2 -> (* Info *)
                let v85 : string = "Info"
                v85
            | US4_3 -> (* Warn *)
                let v86 : string = "Warn"
                v86
        v78.[int v81] <- v87
        let v88 : int32 = v81 + 1
        v79.l0 <- v88
        ()
    let v89 : int32 = v78.Length
    let v90 : (obj []) = Array.zeroCreate<obj> (v89)
    let v91 : Mut6 = {l0 = 0} : Mut6
    while method20(v89, v91) do
        let v93 : int32 = v91.l0
        let v94 : string = v78.[int v93]
        let v95 : obj = v94
        v90.[int v93] <- v95
        let v96 : int32 = v93 + 1
        v91.l0 <- v96
        ()
    let v97 : US4 = v1 ()
    let v102 : string =
        match v97 with
        | US4_0 -> (* Debug *)
            let v98 : string = "Debug"
            v98
        | US4_1 -> (* Error *)
            let v99 : string = "Error"
            v99
        | US4_2 -> (* Info *)
            let v100 : string = "Info"
            v100
        | US4_3 -> (* Warn *)
            let v101 : string = "Warn"
            v101
    let v103 : obj = v102
    let v104 : US11 = US11_1(v90)
    let v105 : string = "2px"
    let v106 : US6 = US6_1(v105)
    let v107 : (obj -> unit) = closure86(v0)
    let v108 : US13 = US13_1(v107)
    let v109 : US10 = US10_1(v103)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v104, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v106, v40, v41, v42, v43, v108, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v109, v68, v69, v70, v71)
and closure87 () () : (JSX.Element []) =
    [||]
and closure77 (v0 : (US4 -> unit), v1 : (unit -> US4)) () : (JSX.Element []) =
    let v2 : (Mut1 -> JSX.Element) = closure78()
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure85(v0, v1)
    let v4 : (unit -> (JSX.Element [])) = closure87()
    let v5 : JSX.Element = method21(v2, v3, v4)
    [|v5|]
and closure76 (v0 : (US4 -> unit), v1 : (unit -> US4)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = "Log Level"
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure77(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v77, v65, v66, v67, v68, v69, v70, v71)
and method26 (v0 : (Mut3 -> JSX.Element), v1 : US14, v2 : US14, v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)), v4 : US15) : JSX.Element =
    let v5 : Mut3 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4} : Mut3
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v0, v5) |> unbox<JSX.Element>
    v9
and closure90 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "8px"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v71, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure95 (v0 : Mut8, v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : string = v1 ()
    let v3 : (string -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure94 (v0 : Mut8, v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure95(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure93 (v0 : Mut8, v1 : (unit -> string)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure94(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v78, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method27 (v0 : Mut8) : JSX.Element =
    let v1 : (unit -> struct ((unit -> string) * (string -> unit))) = v0.l1
    let struct (v2 : (unit -> string), v3 : (string -> unit)) = v1 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US14 = US14_0
    let v6 : US14 = US14_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure93(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure92 () (v0 : Mut8) : JSX.Element =
    method27(v0)
and closure96 () (v0 : string) : obj =
    let v1 : obj = v0
    v1
and closure97 () () : struct ((unit -> string) * (string -> unit)) =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v138 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * obj * string) [])), v140 : ((struct (US2 * obj * string) []) -> unit), v141 : (unit -> (struct (int64 * obj) [])), v142 : ((struct (int64 * obj) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * int32) [])), v146 : ((struct (int64 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v133, v134)
and method28 (v0 : (Mut8 -> JSX.Element), v1 : (string -> obj), v2 : (unit -> struct ((unit -> string) * (string -> unit))), v3 : string) : JSX.Element =
    let v4 : Mut8 = {l0 = v1; l1 = v2; l2 = v3} : Mut8
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure98 () () : struct ((unit -> string) * (string -> unit)) =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v138 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * obj * string) [])), v140 : ((struct (US2 * obj * string) []) -> unit), v141 : (unit -> (struct (int64 * obj) [])), v142 : ((struct (int64 * obj) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * int32) [])), v146 : ((struct (int64 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v135, v136)
and closure102 (v0 : Mut9, v1 : (unit -> int32)) () : (JSX.Element []) =
    let v2 : int32 = v1 ()
    let v3 : (int32 -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure101 (v0 : Mut9, v1 : (unit -> int32)) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure102(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure100 (v0 : Mut9, v1 : (unit -> int32)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure101(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v78, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method29 (v0 : Mut9) : JSX.Element =
    let v1 : (unit -> struct ((unit -> int32) * (int32 -> unit))) = v0.l1
    let struct (v2 : (unit -> int32), v3 : (int32 -> unit)) = v1 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US14 = US14_0
    let v6 : US14 = US14_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure100(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure99 () (v0 : Mut9) : JSX.Element =
    method29(v0)
and closure103 () (v0 : int32) : obj =
    let v1 : obj = v0
    v1
and closure104 () () : struct ((unit -> int32) * (int32 -> unit)) =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v138 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * obj * string) [])), v140 : ((struct (US2 * obj * string) []) -> unit), v141 : (unit -> (struct (int64 * obj) [])), v142 : ((struct (int64 * obj) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * int32) [])), v146 : ((struct (int64 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v131, v132)
and method30 (v0 : (Mut9 -> JSX.Element), v1 : (int32 -> obj), v2 : (unit -> struct ((unit -> int32) * (int32 -> unit))), v3 : string) : JSX.Element =
    let v4 : Mut9 = {l0 = v1; l1 = v2; l2 = v3} : Mut9
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure108 (v0 : Mut10, v1 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []))) () : (JSX.Element []) =
    let v2 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) = v1 ()
    let v3 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure107 (v0 : Mut10, v1 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []))) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure108(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure106 (v0 : Mut10, v1 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure107(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v78, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method31 (v0 : Mut10) : JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v3 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit)) = v1 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US14 = US14_0
    let v6 : US14 = US14_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure106(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure105 () (v0 : Mut10) : JSX.Element =
    method31(v0)
and closure109 () (v0 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) : obj =
    let v1 : int32 = v0.Length
    let v2 : (struct (US0 * string * string * string) []) = Array.zeroCreate<struct (US0 * string * string * string)> (v1)
    let v3 : Mut6 = {l0 = 0} : Mut6
    while method20(v1, v3) do
        let v5 : int32 = v3.l0
        let struct (v6 : (unit -> US0), v7 : (US0 -> unit), v8 : (unit -> string), v9 : (string -> unit), v10 : (unit -> string), v11 : (string -> unit), v12 : (unit -> string), v13 : (string -> unit)) = v0.[int v5]
        let v14 : US0 = v6 ()
        let v15 : string = v12 ()
        let v16 : string = v8 ()
        let v17 : string = v10 ()
        v2.[int v5] <- struct (v14, v16, v17, v15)
        let v18 : int32 = v5 + 1
        v3.l0 <- v18
        ()
    let v19 : obj = v2
    v19
and closure110 () () : struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit)) =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v138 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * obj * string) [])), v140 : ((struct (US2 * obj * string) []) -> unit), v141 : (unit -> (struct (int64 * obj) [])), v142 : ((struct (int64 * obj) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * int32) [])), v146 : ((struct (int64 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v129, v130)
and method32 (v0 : (Mut10 -> JSX.Element), v1 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> obj), v2 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit))), v3 : string) : JSX.Element =
    let v4 : Mut10 = {l0 = v1; l1 = v2; l2 = v3} : Mut10
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure114 (v0 : Mut11, v1 : (unit -> (struct (US2 * obj * string) []))) () : (JSX.Element []) =
    let v2 : (struct (US2 * obj * string) []) = v1 ()
    let v3 : ((struct (US2 * obj * string) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure113 (v0 : Mut11, v1 : (unit -> (struct (US2 * obj * string) []))) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure114(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure112 (v0 : Mut11, v1 : (unit -> (struct (US2 * obj * string) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure113(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v78, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method33 (v0 : Mut11) : JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct (US2 * obj * string) [])), v3 : ((struct (US2 * obj * string) []) -> unit)) = v1 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US14 = US14_0
    let v6 : US14 = US14_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure112(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure111 () (v0 : Mut11) : JSX.Element =
    method33(v0)
and closure115 () (v0 : (struct (US2 * obj * string) [])) : obj =
    let v1 : obj = v0
    v1
and closure116 () () : struct ((unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit)) =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v138 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * obj * string) [])), v140 : ((struct (US2 * obj * string) []) -> unit), v141 : (unit -> (struct (int64 * obj) [])), v142 : ((struct (int64 * obj) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * int32) [])), v146 : ((struct (int64 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v139, v140)
and method34 (v0 : (Mut11 -> JSX.Element), v1 : ((struct (US2 * obj * string) []) -> obj), v2 : (unit -> struct ((unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit))), v3 : string) : JSX.Element =
    let v4 : Mut11 = {l0 = v1; l1 = v2; l2 = v3} : Mut11
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure120 (v0 : Mut12, v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) () : (JSX.Element []) =
    let v2 : (struct ((US2 []) * int32 * US3 * string * string) []) = v1 ()
    let v3 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure119 (v0 : Mut12, v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure120(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure118 (v0 : Mut12, v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure119(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v78, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method35 (v0 : Mut12) : JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v3 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit)) = v1 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US14 = US14_0
    let v6 : US14 = US14_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure118(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure117 () (v0 : Mut12) : JSX.Element =
    method35(v0)
and closure121 () (v0 : (struct ((US2 []) * int32 * US3 * string * string) [])) : obj =
    let v1 : obj = v0
    v1
and closure122 () () : struct ((unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit)) =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v138 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * obj * string) [])), v140 : ((struct (US2 * obj * string) []) -> unit), v141 : (unit -> (struct (int64 * obj) [])), v142 : ((struct (int64 * obj) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * int32) [])), v146 : ((struct (int64 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v137, v138)
and method36 (v0 : (Mut12 -> JSX.Element), v1 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> obj), v2 : (unit -> struct ((unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit))), v3 : string) : JSX.Element =
    let v4 : Mut12 = {l0 = v1; l1 = v2; l2 = v3} : Mut12
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure126 (v0 : Mut13, v1 : (unit -> US4)) () : (JSX.Element []) =
    let v2 : US4 = v1 ()
    let v3 : (US4 -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure125 (v0 : Mut13, v1 : (unit -> US4)) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure126(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure124 (v0 : Mut13, v1 : (unit -> US4)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure125(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v78, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method37 (v0 : Mut13) : JSX.Element =
    let v1 : (unit -> struct ((unit -> US4) * (US4 -> unit))) = v0.l1
    let struct (v2 : (unit -> US4), v3 : (US4 -> unit)) = v1 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US14 = US14_0
    let v6 : US14 = US14_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure124(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure123 () (v0 : Mut13) : JSX.Element =
    method37(v0)
and closure127 () (v0 : US4) : obj =
    let v5 : string =
        match v0 with
        | US4_0 -> (* Debug *)
            let v1 : string = "Debug"
            v1
        | US4_1 -> (* Error *)
            let v2 : string = "Error"
            v2
        | US4_2 -> (* Info *)
            let v3 : string = "Info"
            v3
        | US4_3 -> (* Warn *)
            let v4 : string = "Warn"
            v4
    let v6 : obj = v5
    v6
and closure128 () () : struct ((unit -> US4) * (US4 -> unit)) =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v138 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * obj * string) [])), v140 : ((struct (US2 * obj * string) []) -> unit), v141 : (unit -> (struct (int64 * obj) [])), v142 : ((struct (int64 * obj) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * int32) [])), v146 : ((struct (int64 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v147, v148)
and method38 (v0 : (Mut13 -> JSX.Element), v1 : (US4 -> obj), v2 : (unit -> struct ((unit -> US4) * (US4 -> unit))), v3 : string) : JSX.Element =
    let v4 : Mut13 = {l0 = v1; l1 = v2; l2 = v3} : Mut13
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure132 (v0 : Mut14, v1 : (unit -> US5)) () : (JSX.Element []) =
    let v2 : US5 = v1 ()
    let v3 : (US5 -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure131 (v0 : Mut14, v1 : (unit -> US5)) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure132(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure130 (v0 : Mut14, v1 : (unit -> US5)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure131(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v78, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method39 (v0 : Mut14) : JSX.Element =
    let v1 : (unit -> struct ((unit -> US5) * (US5 -> unit))) = v0.l1
    let struct (v2 : (unit -> US5), v3 : (US5 -> unit)) = v1 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US14 = US14_0
    let v6 : US14 = US14_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure130(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure129 () (v0 : Mut14) : JSX.Element =
    method39(v0)
and closure133 () (v0 : US5) : obj =
    let v1 : obj = v0
    v1
and closure134 () () : struct ((unit -> US5) * (US5 -> unit)) =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v138 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * obj * string) [])), v140 : ((struct (US2 * obj * string) []) -> unit), v141 : (unit -> (struct (int64 * obj) [])), v142 : ((struct (int64 * obj) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * int32) [])), v146 : ((struct (int64 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v149, v150)
and method40 (v0 : (Mut14 -> JSX.Element), v1 : (US5 -> obj), v2 : (unit -> struct ((unit -> US5) * (US5 -> unit))), v3 : string) : JSX.Element =
    let v4 : Mut14 = {l0 = v1; l1 = v2; l2 = v3} : Mut14
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure138 (v0 : Mut15, v1 : (unit -> (struct (int64 * int32) []))) () : (JSX.Element []) =
    let v2 : (struct (int64 * int32) []) = v1 ()
    let v3 : ((struct (int64 * int32) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure137 (v0 : Mut15, v1 : (unit -> (struct (int64 * int32) []))) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure138(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure136 (v0 : Mut15, v1 : (unit -> (struct (int64 * int32) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure137(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v78, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method41 (v0 : Mut15) : JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct (int64 * int32) [])), v3 : ((struct (int64 * int32) []) -> unit)) = v1 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US14 = US14_0
    let v6 : US14 = US14_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure136(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure135 () (v0 : Mut15) : JSX.Element =
    method41(v0)
and closure139 () (v0 : (struct (int64 * int32) [])) : obj =
    let v1 : obj = v0
    v1
and closure140 () () : struct ((unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit)) =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v138 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * obj * string) [])), v140 : ((struct (US2 * obj * string) []) -> unit), v141 : (unit -> (struct (int64 * obj) [])), v142 : ((struct (int64 * obj) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * int32) [])), v146 : ((struct (int64 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v145, v146)
and method42 (v0 : (Mut15 -> JSX.Element), v1 : ((struct (int64 * int32) []) -> obj), v2 : (unit -> struct ((unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit))), v3 : string) : JSX.Element =
    let v4 : Mut15 = {l0 = v1; l1 = v2; l2 = v3} : Mut15
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure144 (v0 : Mut16, v1 : (unit -> (struct (int64 * obj) []))) () : (JSX.Element []) =
    let v2 : (struct (int64 * obj) []) = v1 ()
    let v3 : ((struct (int64 * obj) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure143 (v0 : Mut16, v1 : (unit -> (struct (int64 * obj) []))) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure144(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure142 (v0 : Mut16, v1 : (unit -> (struct (int64 * obj) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure143(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v78, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method43 (v0 : Mut16) : JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct (int64 * obj) [])), v3 : ((struct (int64 * obj) []) -> unit)) = v1 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US14 = US14_0
    let v6 : US14 = US14_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure142(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure141 () (v0 : Mut16) : JSX.Element =
    method43(v0)
and closure145 () (v0 : (struct (int64 * obj) [])) : obj =
    let v1 : obj = v0
    v1
and closure146 () () : struct ((unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit)) =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v138 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * obj * string) [])), v140 : ((struct (US2 * obj * string) []) -> unit), v141 : (unit -> (struct (int64 * obj) [])), v142 : ((struct (int64 * obj) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * int32) [])), v146 : ((struct (int64 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v143, v144)
and method44 (v0 : (Mut16 -> JSX.Element), v1 : ((struct (int64 * obj) []) -> obj), v2 : (unit -> struct ((unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit))), v3 : string) : JSX.Element =
    let v4 : Mut16 = {l0 = v1; l1 = v2; l2 = v3} : Mut16
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure147 () () : struct ((unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit)) =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v138 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * obj * string) [])), v140 : ((struct (US2 * obj * string) []) -> unit), v141 : (unit -> (struct (int64 * obj) [])), v142 : ((struct (int64 * obj) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * int32) [])), v146 : ((struct (int64 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v141, v142)
and closure91 () () : (JSX.Element []) =
    let v0 : (Mut8 -> JSX.Element) = closure92()
    let v1 : (string -> obj) = closure96()
    let v2 : (unit -> struct ((unit -> string) * (string -> unit))) = closure97()
    let v3 : string = "chain.token"
    let v4 : JSX.Element = method28(v0, v1, v2, v3)
    let v5 : (unit -> struct ((unit -> string) * (string -> unit))) = closure98()
    let v6 : string = "chain.url"
    let v7 : JSX.Element = method28(v0, v1, v5, v6)
    let v8 : (Mut9 -> JSX.Element) = closure99()
    let v9 : (int32 -> obj) = closure103()
    let v10 : (unit -> struct ((unit -> int32) * (int32 -> unit))) = closure104()
    let v11 : string = "chain.port"
    let v12 : JSX.Element = method30(v8, v9, v10, v11)
    let v13 : (Mut10 -> JSX.Element) = closure105()
    let v14 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> obj) = closure109()
    let v15 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit))) = closure110()
    let v16 : string = "chain.accounts"
    let v17 : JSX.Element = method32(v13, v14, v15, v16)
    let v18 : (Mut11 -> JSX.Element) = closure111()
    let v19 : ((struct (US2 * obj * string) []) -> obj) = closure115()
    let v20 : (unit -> struct ((unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit))) = closure116()
    let v21 : string = "db.connections"
    let v22 : JSX.Element = method34(v18, v19, v20, v21)
    let v23 : (Mut12 -> JSX.Element) = closure117()
    let v24 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> obj) = closure121()
    let v25 : (unit -> struct ((unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit))) = closure122()
    let v26 : string = "db.connection_options"
    let v27 : JSX.Element = method36(v23, v24, v25, v26)
    let v28 : (Mut13 -> JSX.Element) = closure123()
    let v29 : (US4 -> obj) = closure127()
    let v30 : (unit -> struct ((unit -> US4) * (US4 -> unit))) = closure128()
    let v31 : string = "settings.log_level"
    let v32 : JSX.Element = method38(v28, v29, v30, v31)
    let v33 : (Mut14 -> JSX.Element) = closure129()
    let v34 : (US5 -> obj) = closure133()
    let v35 : (unit -> struct ((unit -> US5) * (US5 -> unit))) = closure134()
    let v36 : string = "settings.ui.modal"
    let v37 : JSX.Element = method40(v33, v34, v35, v36)
    let v38 : (Mut15 -> JSX.Element) = closure135()
    let v39 : ((struct (int64 * int32) []) -> obj) = closure139()
    let v40 : (unit -> struct ((unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit))) = closure140()
    let v41 : string = "profile.tmp.counter"
    let v42 : JSX.Element = method42(v38, v39, v40, v41)
    let v43 : (Mut16 -> JSX.Element) = closure141()
    let v44 : ((struct (int64 * obj) []) -> obj) = closure145()
    let v45 : (unit -> struct ((unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit))) = closure146()
    let v46 : string = "profile.tmp.chain_status"
    let v47 : JSX.Element = method44(v43, v44, v45, v46)
    let v48 : (unit -> struct ((unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit))) = closure147()
    let v49 : string = "profile.tmp.chain_deploy"
    let v50 : JSX.Element = method44(v43, v44, v48, v49)
    [|v4; v7; v12; v17; v22; v27; v32; v37; v42; v47; v50|]
and closure89 () () : (JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : JS.Function = v2?pre
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure90()
    let v5 : (unit -> (JSX.Element [])) = closure91()
    let v6 : JSX.Element = method5(v3, v4, v5)
    [|v6|]
and closure88 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "State"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure89()
    let v74 : US9 = US9_1(v73)
    let v75 : string = "flex-start"
    let v76 : US6 = US6_1(v75)
    let v77 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v76, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v77, v63, v64, v65, v66, v67, v68, v69)
and closure75 (v0 : (US4 -> unit), v1 : (unit -> US4)) () : (JSX.Element []) =
    let v2 : (Mut3 -> JSX.Element) = closure14()
    let v3 : US14 = US14_0
    let v4 : US14 = US14_0
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure76(v0, v1)
    let v6 : US15 = US15_2
    let v7 : JSX.Element = method26(v2, v3, v4, v5, v6)
    let v8 : US14 = US14_0
    let v9 : US14 = US14_0
    let v10 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure88()
    let v11 : US15 = US15_2
    let v12 : JSX.Element = method26(v2, v8, v9, v10, v11)
    [|v7; v12|]
and closure74 (v0 : (US4 -> unit), v1 : (unit -> US4)) () : (JSX.Element []) =
    let v2 : (Mut1 -> JSX.Element) = closure7()
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v4 : (unit -> (JSX.Element [])) = closure75(v0, v1)
    let v5 : JSX.Element = method21(v2, v3, v4)
    [|v5|]
and closure73 (v0 : (US4 -> unit), v1 : (unit -> US4)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = "Debug"
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure74(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "flex-start"
    let v78 : US6 = US6_1(v77)
    let v79 : string = "15px"
    let v80 : US6 = US6_1(v79)
    let v81 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v78, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v80, v55, v56, v57, v58, v59, v60, v61, v62, v63, v81, v65, v66, v67, v68, v69, v70, v71)
and closure13 (v0 : (US4 -> unit), v1 : (unit -> US4)) () : (JSX.Element []) =
    let v2 : (Mut3 -> JSX.Element) = closure14()
    let v3 : US14 = US14_0
    let v4 : US14 = US14_0
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure73(v0, v1)
    let v6 : US15 = US15_0
    let v7 : JSX.Element = method26(v2, v3, v4, v5, v6)
    [|v7|]
and closure6 (v0 : (US4 -> unit), v1 : (unit -> US4)) () : (JSX.Element []) =
    let v2 : (Mut1 -> JSX.Element) = closure7()
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v4 : (unit -> (JSX.Element [])) = closure13(v0, v1)
    let v5 : JSX.Element = method21(v2, v3, v4)
    [|v5|]
and method3 () : JSX.Element =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v138 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * obj * string) [])), v140 : ((struct (US2 * obj * string) []) -> unit), v141 : (unit -> (struct (int64 * obj) [])), v142 : ((struct (int64 * obj) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * int32) [])), v146 : ((struct (int64 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v151 : string = "Box"
    let v152 : string = "@hope-ui/solid"
    let v153 : JS.Function = import v151 v152
    let v154 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure5()
    let v155 : (unit -> (JSX.Element [])) = closure6(v148, v147)
    method5(v153, v154, v155)
and closure4 () (v0 : Mut2) : JSX.Element =
    method3()
and method45 (v0 : (Mut2 -> JSX.Element)) : JSX.Element =
    let v1 : Mut2 = Mut2()
    let v2 : string = "createComponent"
    let v3 : string = "solid-js"
    let v4 : JS.Function = import v2 v3
    let v5 : JSX.Element = v4.Invoke (v0, v1) |> unbox<JSX.Element>
    v5
and closure148 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "flex"
    let v71 : US6 = US6_1(v70)
    let v72 : string = "1"
    let v73 : US6 = US6_1(v72)
    let v74 : string = "column"
    let v75 : US6 = US6_1(v74)
    let v76 : string = "hidden"
    let v77 : US6 = US6_1(v76)
    let v78 : string = "auto"
    let v79 : US6 = US6_1(v78)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v71, v19, v20, v73, v75, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v77, v79, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure158 (v0 : Mut1) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let struct (v71 : US6, v72 : US6, v73 : US6, v74 : US7, v75 : US6, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US8, v82 : US9, v83 : US6, v84 : US6, v85 : US8, v86 : US10, v87 : US6, v88 : US6, v89 : US6, v90 : US11, v91 : US8, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US12, v99 : US6, v100 : US6, v101 : US6, v102 : US12, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US13, v114 : US14, v115 : US13, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US12, v134 : US6, v135 : US6, v136 : US10, v137 : US10, v138 : US6, v139 : US5, v140 : US6) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61, v0.l62, v0.l63, v0.l64, v0.l65, v0.l66, v0.l67, v0.l68, v0.l69
    let v141 : Mut1 = {l0 = v71; l1 = v72; l2 = v73; l3 = v74; l4 = v75; l5 = v76; l6 = v77; l7 = v78; l8 = v79; l9 = v80; l10 = v81; l11 = v82; l12 = v83; l13 = v84; l14 = v85; l15 = v86; l16 = v87; l17 = v88; l18 = v89; l19 = v90; l20 = v91; l21 = v92; l22 = v93; l23 = v94; l24 = v95; l25 = v96; l26 = v97; l27 = v98; l28 = v99; l29 = v100; l30 = v101; l31 = v102; l32 = v103; l33 = v104; l34 = v105; l35 = v106; l36 = v107; l37 = v108; l38 = v109; l39 = v110; l40 = v111; l41 = v112; l42 = v113; l43 = v114; l44 = v115; l45 = v116; l46 = v117; l47 = v118; l48 = v119; l49 = v120; l50 = v121; l51 = v122; l52 = v123; l53 = v124; l54 = v125; l55 = v126; l56 = v127; l57 = v128; l58 = v129; l59 = v130; l60 = v131; l61 = v132; l62 = v133; l63 = v134; l64 = v135; l65 = v136; l66 = v137; l67 = v138; l68 = v139; l69 = v140} : Mut1
    let v142 : US8 = US8_1(true)
    let v143 : Mut1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v142; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63; l63 = v64; l64 = v65; l65 = v66; l66 = v67; l67 = v68; l68 = v69; l69 = v70} : Mut1
    method19(v143, v141)
    let struct (v144 : US6, v145 : US6, v146 : US6, v147 : US7, v148 : US6, v149 : US6, v150 : US6, v151 : US6, v152 : US6, v153 : US6, v154 : US8, v155 : US9, v156 : US6, v157 : US6, v158 : US8, v159 : US10, v160 : US6, v161 : US6, v162 : US6, v163 : US11, v164 : US8, v165 : US6, v166 : US6, v167 : US6, v168 : US6, v169 : US6, v170 : US6, v171 : US12, v172 : US6, v173 : US6, v174 : US6, v175 : US12, v176 : US6, v177 : US6, v178 : US6, v179 : US6, v180 : US6, v181 : US6, v182 : US6, v183 : US6, v184 : US6, v185 : US6, v186 : US13, v187 : US14, v188 : US13, v189 : US6, v190 : US6, v191 : US6, v192 : US6, v193 : US6, v194 : US6, v195 : US6, v196 : US6, v197 : US6, v198 : US6, v199 : US6, v200 : US6, v201 : US6, v202 : US6, v203 : US6, v204 : US6, v205 : US6, v206 : US12, v207 : US6, v208 : US6, v209 : US10, v210 : US10, v211 : US6, v212 : US5, v213 : US6) = v143.l0, v143.l1, v143.l2, v143.l3, v143.l4, v143.l5, v143.l6, v143.l7, v143.l8, v143.l9, v143.l10, v143.l11, v143.l12, v143.l13, v143.l14, v143.l15, v143.l16, v143.l17, v143.l18, v143.l19, v143.l20, v143.l21, v143.l22, v143.l23, v143.l24, v143.l25, v143.l26, v143.l27, v143.l28, v143.l29, v143.l30, v143.l31, v143.l32, v143.l33, v143.l34, v143.l35, v143.l36, v143.l37, v143.l38, v143.l39, v143.l40, v143.l41, v143.l42, v143.l43, v143.l44, v143.l45, v143.l46, v143.l47, v143.l48, v143.l49, v143.l50, v143.l51, v143.l52, v143.l53, v143.l54, v143.l55, v143.l56, v143.l57, v143.l58, v143.l59, v143.l60, v143.l61, v143.l62, v143.l63, v143.l64, v143.l65, v143.l66, v143.l67, v143.l68, v143.l69
    struct (v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213)
and closure159 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : US6 = v0.l26
    let v4 : string =
        match v1 with
        | US6_0 -> (* None *)
            let v2 : string = ""
            v2
        | US6_1(v3) -> (* Some *)
            v3
    let v5 : JSX.Element = v4 |> unbox<JSX.Element>
    let v6 : JSX.Element = Html.fragment [ v5 ]
    [|v6|]
and closure160 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    let v71 : string = "-13px"
    let v72 : US6 = US6_1(v71)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v70, v36, v72, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure161 () () : JS.Function =
    let v0 : string = "BiRegularLinkExternal"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and method48 (v0 : (Mut7 -> JSX.Element), v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)), v2 : (unit -> JS.Function), v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6))) : JSX.Element =
    let v4 : Mut7 = {l0 = v1; l1 = v2; l2 = v3} : Mut7
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure157 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : string = "Anchor"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure158(v0)
    let v5 : (unit -> (JSX.Element [])) = closure159(v0)
    let v6 : JSX.Element = method5(v3, v4, v5)
    let v7 : string = "&nbsp;"
    let v8 : JSX.Element = v7 |> unbox<JSX.Element>
    let v9 : JSX.Element = Html.fragment [ v8 ]
    let v10 : (Mut7 -> JSX.Element) = closure57()
    let v11 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure160()
    let v12 : (unit -> JS.Function) = closure161()
    let v13 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v14 : JSX.Element = method48(v10, v11, v12, v13)
    [|v6; v9; v14|]
and method47 (v0 : Mut1) : JSX.Element =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v5 : (unit -> (JSX.Element [])) = closure157(v0)
    method5(v3, v4, v5)
and closure156 () (v0 : Mut1) : JSX.Element =
    method47(v0)
and closure162 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "https://github.com/fc1943s/tictactoe_spiral"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v71, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure163 () () : (JSX.Element []) =
    [||]
and closure155 () () : (JSX.Element []) =
    let v0 : (Mut1 -> JSX.Element) = closure156()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure162()
    let v2 : (unit -> (JSX.Element [])) = closure163()
    let v3 : JSX.Element = method21(v0, v1, v2)
    [|v3|]
and closure154 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : (unit -> (JSX.Element [])) = closure155()
    let v71 : US9 = US9_1(v70)
    let v72 : string = "1px 6px"
    let v73 : US6 = US6_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v73, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure166 (v0 : string) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : US6 = US6_1(v0)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v71, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure165 (v0 : string) () : (JSX.Element []) =
    let v1 : (Mut1 -> JSX.Element) = closure156()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure166(v0)
    let v3 : (unit -> (JSX.Element [])) = closure163()
    let v4 : JSX.Element = method21(v1, v2, v3)
    [|v4|]
and closure164 (v0 : string) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (unit -> (JSX.Element [])) = closure165(v0)
    let v72 : US9 = US9_1(v71)
    let v73 : string = "1px 6px"
    let v74 : US6 = US6_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v72, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v74, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure169 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "https://fc1943s.github.io/tictactoe_spiral"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v71, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure168 () () : (JSX.Element []) =
    let v0 : (Mut1 -> JSX.Element) = closure156()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure169()
    let v2 : (unit -> (JSX.Element [])) = closure163()
    let v3 : JSX.Element = method21(v0, v1, v2)
    [|v3|]
and closure167 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : (unit -> (JSX.Element [])) = closure168()
    let v71 : US9 = US9_1(v70)
    let v72 : string = "1px 6px"
    let v73 : US6 = US6_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v73, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure172 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "https://fc1943s.github.io/tictactoe_spiral/docs"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v71, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure171 () () : (JSX.Element []) =
    let v0 : (Mut1 -> JSX.Element) = closure156()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure172()
    let v2 : (unit -> (JSX.Element [])) = closure163()
    let v3 : JSX.Element = method21(v0, v1, v2)
    [|v3|]
and closure170 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : (unit -> (JSX.Element [])) = closure171()
    let v71 : US9 = US9_1(v70)
    let v72 : string = "1px 6px"
    let v73 : US6 = US6_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v73, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure153 (v0 : string) () : (JSX.Element []) =
    let v1 : bool = "" = v0
    let v15 : JSX.Element =
        if v1 then
            let v2 : (Mut3 -> JSX.Element) = closure14()
            let v3 : US14 = US14_0
            let v4 : US14 = US14_0
            let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure154()
            let v6 : US15 = US15_2
            method26(v2, v3, v4, v5, v6)
        else
            let v8 : string = $"https://github.com/fc1943s/tictactoe_spiral/tree/{v0}"
            let v9 : (Mut3 -> JSX.Element) = closure14()
            let v10 : US14 = US14_0
            let v11 : US14 = US14_0
            let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure164(v8)
            let v13 : US15 = US15_2
            method26(v9, v10, v11, v12, v13)
    let v16 : (Mut3 -> JSX.Element) = closure14()
    let v17 : US14 = US14_0
    let v18 : US14 = US14_0
    let v19 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure167()
    let v20 : US15 = US15_2
    let v21 : JSX.Element = method26(v16, v17, v18, v19, v20)
    let v22 : US14 = US14_0
    let v23 : US14 = US14_0
    let v24 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure170()
    let v25 : US15 = US15_2
    let v26 : JSX.Element = method26(v16, v22, v23, v24, v25)
    [|v15; v21; v26|]
and method46 () : JSX.Element =
    let struct (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) = method2()
    let v5 : (Mut1 -> JSX.Element) = closure7()
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure153(v3)
    method21(v5, v6, v7)
and closure152 () (v0 : Mut1) : JSX.Element =
    method46()
and closure173 () () : (JSX.Element []) =
    [||]
and closure151 () () : (JSX.Element []) =
    let v0 : (Mut1 -> JSX.Element) = closure152()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (JSX.Element [])) = closure173()
    let v3 : JSX.Element = method21(v0, v1, v2)
    [|v3|]
and closure150 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Links"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure151()
    let v74 : US9 = US9_1(v73)
    let v75 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure181 (v0 : (unit -> unit)) (v1 : obj) : unit =
    v0 ()
    ()
and closure180 (v0 : (unit -> unit), v1 : (unit -> string)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = v1 ()
    let v73 : US6 = US6_1(v72)
    let v74 : (obj -> unit) = closure181(v0)
    let v75 : US13 = US13_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v73, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v75, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
and closure183 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "row"
    let v71 : US6 = US6_1(v70)
    let v72 : string = "$4"
    let v73 : US6 = US6_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v71, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v73, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure185 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "dark"
    let v71 : obj = v70
    let v72 : string = "neutral"
    let v73 : US6 = US6_1(v72)
    let v74 : string = "sm"
    let v75 : US6 = US6_1(v74)
    let v76 : US10 = US10_1(v71)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v73, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v75, v58, v59, v60, v61, v62, v63, v64, v76, v66, v67, v68, v69)
and closure186 () () : (JSX.Element []) =
    let v0 : string = "Dark"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure187 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "light"
    let v71 : obj = v70
    let v72 : string = "neutral"
    let v73 : US6 = US6_1(v72)
    let v74 : string = "sm"
    let v75 : US6 = US6_1(v74)
    let v76 : US10 = US10_1(v71)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v73, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v75, v58, v59, v60, v61, v62, v63, v64, v76, v66, v67, v68, v69)
and closure188 () () : (JSX.Element []) =
    let v0 : string = "Light"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure184 () () : (JSX.Element []) =
    let v0 : string = "Radio"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure185()
    let v4 : (unit -> (JSX.Element [])) = closure186()
    let v5 : JSX.Element = method5(v2, v3, v4)
    let v6 : JS.Function = import v0 v1
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure187()
    let v8 : (unit -> (JSX.Element [])) = closure188()
    let v9 : JSX.Element = method5(v6, v7, v8)
    [|v5; v9|]
and closure182 () () : (JSX.Element []) =
    let v0 : string = "Stack"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure183()
    let v4 : (unit -> (JSX.Element [])) = closure184()
    let v5 : JSX.Element = method5(v2, v3, v4)
    [|v5|]
and closure179 (v0 : (unit -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : string = "RadioGroup"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure180(v0, v1)
    let v6 : (unit -> (JSX.Element [])) = closure182()
    let v7 : JSX.Element = method5(v4, v5, v6)
    [|v7|]
and closure178 (v0 : (unit -> unit), v1 : (unit -> string)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = "Theme"
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure179(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "5px 6px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v78, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and closure177 (v0 : (unit -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : (Mut3 -> JSX.Element) = closure14()
    let v3 : US14 = US14_0
    let v4 : US14 = US14_0
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure178(v0, v1)
    let v6 : US15 = US15_2
    let v7 : JSX.Element = method26(v2, v3, v4, v5, v6)
    [|v7|]
and method49 () : JSX.Element =
    let v0 : string = "useColorMode"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : obj = v2.Invoke () |> unbox
    let v4 : (unit -> string) = v3?colorMode |> unbox
    let v5 : (unit -> unit) = v3?toggleColorMode |> unbox
    let v6 : (Mut1 -> JSX.Element) = closure7()
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v8 : (unit -> (JSX.Element [])) = closure177(v5, v4)
    method21(v6, v7, v8)
and closure176 () (v0 : Mut1) : JSX.Element =
    method49()
and closure189 () () : (JSX.Element []) =
    [||]
and closure175 () () : (JSX.Element []) =
    let v0 : (Mut1 -> JSX.Element) = closure176()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (JSX.Element [])) = closure189()
    let v3 : JSX.Element = method21(v0, v1, v2)
    [|v3|]
and closure174 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Settings"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure175()
    let v74 : US9 = US9_1(v73)
    let v75 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure202 (v0 : Mut17) (v1 : obj) : unit =
    let v2 : string = v1?currentTarget?value
    let v3 : (US6 -> unit) = v0.l1
    let v4 : US6 = US6_1(v2)
    v3 v4
    ()
and closure201 (v0 : Mut17) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (unit -> US6) = v0.l0
    let v72 : US6 = v71 ()
    let v73 : string = JS.undefined
    let v75 : string =
        match v72 with
        | US6_0 -> (* None *)
            v73
        | US6_1(v74) -> (* Some *)
            v74
    let v76 : obj = v75
    let v77 : string = "15vw"
    let v78 : US6 = US6_1(v77)
    let v79 : (obj -> unit) = closure202(v0)
    let v80 : US13 = US13_1(v79)
    let v81 : string = "xs"
    let v82 : US6 = US6_1(v81)
    let v83 : string = "text"
    let v84 : US6 = US6_1(v83)
    let v85 : US10 = US10_1(v76)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v78, v43, v44, v80, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v82, v59, v60, v61, v62, v63, v64, v84, v85, v67, v68, v69, v70)
and closure203 () () : (JSX.Element []) =
    [||]
and method52 (v0 : Mut17) : JSX.Element =
    let v1 : string = "Input"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure201(v0)
    let v5 : (unit -> (JSX.Element [])) = closure203()
    method5(v3, v4, v5)
and closure200 () (v0 : Mut17) : JSX.Element =
    method52(v0)
and closure204 (v0 : (unit -> string)) () : US6 =
    let v1 : string = v0 ()
    US6_1(v1)
and closure205 (v0 : (string -> unit)) (v1 : US6) : unit =
    let v4 : string =
        match v1 with
        | US6_0 -> (* None *)
            failwith<string> "Option does not have a value."
        | US6_1(v3) -> (* Some *)
            v3
    v0 v4
    ()
and method53 (v0 : (Mut17 -> JSX.Element), v1 : (unit -> US6), v2 : (US6 -> unit)) : JSX.Element =
    let v3 : Mut17 = {l0 = v1; l1 = v2} : Mut17
    let v4 : string = "createComponent"
    let v5 : string = "solid-js"
    let v6 : JS.Function = import v4 v5
    let v7 : JSX.Element = v6.Invoke (v0, v3) |> unbox<JSX.Element>
    v7
and closure199 (v0 : (string -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : (Mut17 -> JSX.Element) = closure200()
    let v3 : (unit -> US6) = closure204(v1)
    let v4 : (US6 -> unit) = closure205(v0)
    let v5 : JSX.Element = method53(v2, v3, v4)
    [|v5|]
and closure198 (v0 : (string -> unit), v1 : (unit -> string)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = "Token"
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure199(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "3px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v78, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and closure207 (v0 : (string -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : (Mut17 -> JSX.Element) = closure200()
    let v3 : (unit -> US6) = closure204(v1)
    let v4 : (US6 -> unit) = closure205(v0)
    let v5 : JSX.Element = method53(v2, v3, v4)
    [|v5|]
and closure206 (v0 : (string -> unit), v1 : (unit -> string)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = "URL"
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure207(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "3px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v78, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and closure212 (v0 : Mut18) (v1 : obj) : unit =
    let v2 : int32 = v1?currentTarget?value
    let v3 : (US5 -> unit) = v0.l1
    let v4 : US5 = US5_1(v2)
    v3 v4
    ()
and closure211 (v0 : Mut18) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (unit -> US5) = v0.l0
    let v72 : US5 = v71 ()
    let v73 : int32 = JS.undefined
    let v75 : int32 =
        match v72 with
        | US5_0 -> (* None *)
            v73
        | US5_1(v74) -> (* Some *)
            v74
    let v76 : obj = v75
    let v77 : string = "15vw"
    let v78 : US6 = US6_1(v77)
    let v79 : (obj -> unit) = closure212(v0)
    let v80 : US13 = US13_1(v79)
    let v81 : string = "xs"
    let v82 : US6 = US6_1(v81)
    let v83 : string = "text"
    let v84 : US6 = US6_1(v83)
    let v85 : US10 = US10_1(v76)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v78, v43, v44, v80, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v82, v59, v60, v61, v62, v63, v64, v84, v85, v67, v68, v69, v70)
and method54 (v0 : Mut18) : JSX.Element =
    let v1 : string = "Input"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure211(v0)
    let v5 : (unit -> (JSX.Element [])) = closure203()
    method5(v3, v4, v5)
and closure210 () (v0 : Mut18) : JSX.Element =
    method54(v0)
and closure213 (v0 : (unit -> int32)) () : US5 =
    let v1 : int32 = v0 ()
    US5_1(v1)
and closure214 (v0 : (int32 -> unit)) (v1 : US5) : unit =
    let v4 : int32 =
        match v1 with
        | US5_0 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US5_1(v3) -> (* Some *)
            v3
    v0 v4
    ()
and method55 (v0 : (Mut18 -> JSX.Element), v1 : (unit -> US5), v2 : (US5 -> unit)) : JSX.Element =
    let v3 : Mut18 = {l0 = v1; l1 = v2} : Mut18
    let v4 : string = "createComponent"
    let v5 : string = "solid-js"
    let v6 : JS.Function = import v4 v5
    let v7 : JSX.Element = v6.Invoke (v0, v3) |> unbox<JSX.Element>
    v7
and closure209 (v0 : (int32 -> unit), v1 : (unit -> int32)) () : (JSX.Element []) =
    let v2 : (Mut18 -> JSX.Element) = closure210()
    let v3 : (unit -> US5) = closure213(v1)
    let v4 : (US5 -> unit) = closure214(v0)
    let v5 : JSX.Element = method55(v2, v3, v4)
    [|v5|]
and closure208 (v0 : (int32 -> unit), v1 : (unit -> int32)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = "Port"
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure209(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "3px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v78, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and closure197 (v0 : (string -> unit), v1 : (unit -> string), v2 : (string -> unit), v3 : (unit -> string), v4 : (int32 -> unit), v5 : (unit -> int32)) () : (JSX.Element []) =
    let v6 : (Mut3 -> JSX.Element) = closure14()
    let v7 : US14 = US14_0
    let v8 : US14 = US14_0
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure198(v0, v1)
    let v10 : US15 = US15_2
    let v11 : JSX.Element = method26(v6, v7, v8, v9, v10)
    let v12 : US14 = US14_0
    let v13 : US14 = US14_0
    let v14 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure206(v2, v3)
    let v15 : US15 = US15_2
    let v16 : JSX.Element = method26(v6, v12, v13, v14, v15)
    let v17 : US14 = US14_0
    let v18 : US14 = US14_0
    let v19 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure208(v4, v5)
    let v20 : US15 = US15_2
    let v21 : JSX.Element = method26(v6, v17, v18, v19, v20)
    [|v11; v16; v21|]
and method51 () : JSX.Element =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v138 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * obj * string) [])), v140 : ((struct (US2 * obj * string) []) -> unit), v141 : (unit -> (struct (int64 * obj) [])), v142 : ((struct (int64 * obj) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * int32) [])), v146 : ((struct (int64 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v274 : obj = emitJsExpr () "components_spi.state_context"
    let v275 : JS.Function = import v126 v127
    let struct (v276 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v277 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v278 : (unit -> int32), v279 : (int32 -> unit), v280 : (unit -> string), v281 : (string -> unit), v282 : (unit -> string), v283 : (string -> unit), v284 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v285 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v286 : (unit -> (struct (US2 * obj * string) [])), v287 : ((struct (US2 * obj * string) []) -> unit), v288 : (unit -> (struct (int64 * obj) [])), v289 : ((struct (int64 * obj) []) -> unit), v290 : (unit -> (struct (int64 * obj) [])), v291 : ((struct (int64 * obj) []) -> unit), v292 : (unit -> (struct (int64 * int32) [])), v293 : ((struct (int64 * int32) []) -> unit), v294 : (unit -> US4), v295 : (US4 -> unit), v296 : (unit -> US5), v297 : (US5 -> unit)) = v275.Invoke v274 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v421 : obj = emitJsExpr () "components_spi.state_context"
    let v422 : JS.Function = import v126 v127
    let struct (v423 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v424 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v425 : (unit -> int32), v426 : (int32 -> unit), v427 : (unit -> string), v428 : (string -> unit), v429 : (unit -> string), v430 : (string -> unit), v431 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v432 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v433 : (unit -> (struct (US2 * obj * string) [])), v434 : ((struct (US2 * obj * string) []) -> unit), v435 : (unit -> (struct (int64 * obj) [])), v436 : ((struct (int64 * obj) []) -> unit), v437 : (unit -> (struct (int64 * obj) [])), v438 : ((struct (int64 * obj) []) -> unit), v439 : (unit -> (struct (int64 * int32) [])), v440 : ((struct (int64 * int32) []) -> unit), v441 : (unit -> US4), v442 : (US4 -> unit), v443 : (unit -> US5), v444 : (US5 -> unit)) = v422.Invoke v421 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v445 : (Mut1 -> JSX.Element) = closure7()
    let v446 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v447 : (unit -> (JSX.Element [])) = closure197(v134, v133, v283, v282, v426, v425)
    method21(v445, v446, v447)
and closure196 () (v0 : Mut1) : JSX.Element =
    method51()
and closure215 () () : (JSX.Element []) =
    [||]
and closure195 () () : (JSX.Element []) =
    let v0 : (Mut1 -> JSX.Element) = closure196()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (JSX.Element [])) = closure215()
    let v3 : JSX.Element = method21(v0, v1, v2)
    [|v3|]
and closure194 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Connection"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure195()
    let v74 : US9 = US9_1(v73)
    let v75 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure220 (v0 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (obj []) = v0 |> unbox<(obj [])>
    let v72 : US11 = US11_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v72, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure227 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : US6 =
    let v8 : string = v2 ()
    US6_1(v8)
and closure228 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) (v8 : US6) : unit =
    let v11 : string =
        match v8 with
        | US6_0 -> (* None *)
            let v9 : string = ""
            v9
        | US6_1(v10) -> (* Some *)
            v10
    v3 v11
    ()
and closure226 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : (JSX.Element []) =
    let v8 : (Mut17 -> JSX.Element) = closure200()
    let v9 : (unit -> US6) = closure227(v0, v1, v2, v3, v4, v5, v6, v7)
    let v10 : (US6 -> unit) = closure228(v0, v1, v2, v3, v4, v5, v6, v7)
    let v11 : JSX.Element = method53(v8, v9, v10)
    [|v11|]
and closure225 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) struct (v8 : US6, v9 : US6, v10 : US6, v11 : US7, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US6, v17 : US6, v18 : US8, v19 : US9, v20 : US6, v21 : US6, v22 : US8, v23 : US10, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US8, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US12, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US13, v51 : US14, v52 : US13, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US6, v69 : US6, v70 : US12, v71 : US6, v72 : US6, v73 : US10, v74 : US10, v75 : US6, v76 : US5, v77 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v78 : string = "Address"
    let v79 : JSX.Element = v78 |> unbox<JSX.Element>
    let v80 : JSX.Element = Html.fragment [ v79 ]
    let v81 : (unit -> (JSX.Element [])) = closure226(v0, v1, v2, v3, v4, v5, v6, v7)
    let v82 : US9 = US9_1(v81)
    let v83 : string = "3px"
    let v84 : US6 = US6_1(v83)
    let v85 : US12 = US12_1(v80)
    struct (v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v82, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v84, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v85, v71, v72, v73, v74, v75, v76, v77)
and closure231 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : US6 =
    let v8 : string = v6 ()
    US6_1(v8)
and closure232 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) (v8 : US6) : unit =
    let v11 : string =
        match v8 with
        | US6_0 -> (* None *)
            let v9 : string = ""
            v9
        | US6_1(v10) -> (* Some *)
            v10
    v7 v11
    ()
and closure230 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : (JSX.Element []) =
    let v8 : (Mut17 -> JSX.Element) = closure200()
    let v9 : (unit -> US6) = closure231(v0, v1, v2, v3, v4, v5, v6, v7)
    let v10 : (US6 -> unit) = closure232(v0, v1, v2, v3, v4, v5, v6, v7)
    let v11 : JSX.Element = method53(v8, v9, v10)
    [|v11|]
and closure229 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) struct (v8 : US6, v9 : US6, v10 : US6, v11 : US7, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US6, v17 : US6, v18 : US8, v19 : US9, v20 : US6, v21 : US6, v22 : US8, v23 : US10, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US8, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US12, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US13, v51 : US14, v52 : US13, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US6, v69 : US6, v70 : US12, v71 : US6, v72 : US6, v73 : US10, v74 : US10, v75 : US6, v76 : US5, v77 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v78 : string = "Private Key"
    let v79 : JSX.Element = v78 |> unbox<JSX.Element>
    let v80 : JSX.Element = Html.fragment [ v79 ]
    let v81 : (unit -> (JSX.Element [])) = closure230(v0, v1, v2, v3, v4, v5, v6, v7)
    let v82 : US9 = US9_1(v81)
    let v83 : string = "3px"
    let v84 : US6 = US6_1(v83)
    let v85 : US12 = US12_1(v80)
    struct (v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v82, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v84, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v85, v71, v72, v73, v74, v75, v76, v77)
and closure224 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : (JSX.Element []) =
    let v8 : (Mut3 -> JSX.Element) = closure14()
    let v9 : US14 = US14_0
    let v10 : US14 = US14_0
    let v11 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure225(v0, v1, v2, v3, v4, v5, v6, v7)
    let v12 : US15 = US15_2
    let v13 : JSX.Element = method26(v8, v9, v10, v11, v12)
    let v14 : US14 = US14_0
    let v15 : US14 = US14_0
    let v16 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure229(v0, v1, v2, v3, v4, v5, v6, v7)
    let v17 : US15 = US15_2
    let v18 : JSX.Element = method26(v8, v14, v15, v16, v17)
    [|v13; v18|]
and closure223 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : (JSX.Element []) =
    let v8 : (Mut1 -> JSX.Element) = closure7()
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v10 : (unit -> (JSX.Element [])) = closure224(v0, v1, v2, v3, v4, v5, v6, v7)
    let v11 : JSX.Element = method21(v8, v9, v10)
    [|v11|]
and closure222 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) struct (v8 : US6, v9 : US6, v10 : US6, v11 : US7, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US6, v17 : US6, v18 : US8, v19 : US9, v20 : US6, v21 : US6, v22 : US8, v23 : US10, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US8, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US12, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US13, v51 : US14, v52 : US13, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US6, v69 : US6, v70 : US12, v71 : US6, v72 : US6, v73 : US10, v74 : US10, v75 : US6, v76 : US5, v77 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v78 : US0 = v0 ()
    let v84 : string =
        match v78 with
        | US0_0 -> (* Admin *)
            let v79 : string = "admin"
            v79
        | US0_1(v80) -> (* Player *)
            match v80 with
            | US1_0 -> (* O *)
                let v81 : string = "o"
                v81
            | US1_1 -> (* X *)
                let v82 : string = "x"
                v82
    let v85 : JSX.Element = v84 |> unbox<JSX.Element>
    let v86 : JSX.Element = Html.fragment [ v85 ]
    let v87 : (unit -> (JSX.Element [])) = closure223(v0, v1, v2, v3, v4, v5, v6, v7)
    let v88 : US9 = US9_1(v87)
    let v89 : US12 = US12_1(v86)
    struct (v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v88, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v89, v71, v72, v73, v74, v75, v76, v77)
and closure221 () struct (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) : (JSX.Element []) =
    let v8 : (Mut3 -> JSX.Element) = closure14()
    let v9 : US14 = US14_0
    let v10 : US14 = US14_0
    let v11 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure222(v0, v1, v2, v3, v4, v5, v6, v7)
    let v12 : US15 = US15_2
    let v13 : JSX.Element = method26(v8, v9, v10, v11, v12)
    [|v13|]
and closure219 (v0 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []))) () : (JSX.Element []) =
    let v1 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) = v0 ()
    let v2 : string = "For"
    let v3 : string = "solid-js"
    let v4 : JS.Function = import v2 v3
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure220(v1)
    let v6 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) -> (JSX.Element [])) = closure221()
    let v7 : (unit -> (JSX.Element [])) = v6 |> unbox<(unit -> (JSX.Element []))>
    let v8 : JSX.Element = method5(v4, v5, v7)
    [|v8|]
and method56 () : JSX.Element =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v138 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * obj * string) [])), v140 : ((struct (US2 * obj * string) []) -> unit), v141 : (unit -> (struct (int64 * obj) [])), v142 : ((struct (int64 * obj) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * int32) [])), v146 : ((struct (int64 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v151 : (Mut1 -> JSX.Element) = closure7()
    let v152 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v153 : (unit -> (JSX.Element [])) = closure219(v129)
    method21(v151, v152, v153)
and closure218 () (v0 : Mut1) : JSX.Element =
    method56()
and closure233 () () : (JSX.Element []) =
    [||]
and closure217 () () : (JSX.Element []) =
    let v0 : (Mut1 -> JSX.Element) = closure218()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (JSX.Element [])) = closure233()
    let v3 : JSX.Element = method21(v0, v1, v2)
    [|v3|]
and closure216 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Accounts"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure217()
    let v74 : US9 = US9_1(v73)
    let v75 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure236 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "algorand testnet bank"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : string = "#aaa"
    let v74 : US6 = US6_1(v73)
    let v75 : string = "1"
    let v76 : US6 = US6_1(v75)
    let v77 : string = "350px"
    let v78 : US6 = US6_1(v77)
    let v79 : string = "https://bank.testnet.algorand.network"
    let v80 : US6 = US6_1(v79)
    let v81 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v74, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v76, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v80, v60, v61, v81, v63, v64, v65, v66, v67, v68, v69)
and closure237 () () : (JSX.Element []) =
    [||]
and closure235 () () : (JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : JS.Function = v2?iframe
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure236()
    let v5 : (unit -> (JSX.Element [])) = closure237()
    let v6 : JSX.Element = method5(v3, v4, v5)
    [|v6|]
and closure234 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Testnet Bank Dispenser"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure235()
    let v74 : US9 = US9_1(v73)
    let v75 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure193 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure14()
    let v1 : US14 = US14_0
    let v2 : US14 = US14_0
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure194()
    let v4 : US15 = US15_2
    let v5 : JSX.Element = method26(v0, v1, v2, v3, v4)
    let v6 : US14 = US14_0
    let v7 : US14 = US14_0
    let v8 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure216()
    let v9 : US15 = US15_2
    let v10 : JSX.Element = method26(v0, v6, v7, v8, v9)
    let v11 : US14 = US14_0
    let v12 : US14 = US14_0
    let v13 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure234()
    let v14 : US15 = US15_0
    let v15 : JSX.Element = method26(v0, v11, v12, v13, v14)
    [|v5; v10; v15|]
and method50 () : JSX.Element =
    let v0 : (Mut1 -> JSX.Element) = closure7()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (JSX.Element [])) = closure193()
    method21(v0, v1, v2)
and closure192 () (v0 : Mut1) : JSX.Element =
    method50()
and closure238 () () : (JSX.Element []) =
    [||]
and closure191 () () : (JSX.Element []) =
    let v0 : (Mut1 -> JSX.Element) = closure192()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (JSX.Element [])) = closure238()
    let v3 : JSX.Element = method21(v0, v1, v2)
    [|v3|]
and closure190 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Chain"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure191()
    let v74 : US9 = US9_1(v73)
    let v75 : string = "db"
    let v76 : US6 = US6_1(v75)
    let v77 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v76, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v77, v63, v64, v65, v66, v67, v68, v69)
and method60 (v0 : int32, v1 : Mut21) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure251 (v0 : Mut20, v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) () : US6 =
    let v2 : (struct ((US2 []) * int32 * US3 * string * string) []) = v1 ()
    let v3 : int32 = v2.Length
    let v4 : US6 = US6_0
    let v5 : Mut21 = {l0 = 0; l1 = v4} : Mut21
    while method60(v3, v5) do
        let v7 : int32 = v5.l0
        let v8 : int32 =  -v7
        let v9 : int32 = v8 + v3
        let v10 : int32 = v9 - 1
        let v11 : US6 = v5.l1
        let struct (v12 : (US2 []), v13 : int32, v14 : US3, v15 : string, v16 : string) = v2.[int v10]
        let v24 : US6 =
            match v11 with
            | US6_0 -> (* None *)
                let v17 : US3 = v0.l1
                let v18 : bool =
                    match v14, v17 with
                    | US3_0, US3_0 -> (* GunJsServer *)
                        true
                    | US3_1, US3_1 -> (* GunRsServer *)
                        true
                    | _ ->
                        false
                if v18 then
                    let v19 : (struct ((US2 []) * int32 * US3 * string * string) -> US6) = v0.l0
                    let v20 : US6 = v19 struct (v12, v13, v14, v15, v16)
                    v20
                else
                    US6_0
            | US6_1(v23) -> (* Some *)
                v11
        let v25 : int32 = v7 + 1
        v5.l0 <- v25
        v5.l1 <- v24
        ()
    let v26 : US6 = v5.l1
    v26
and closure252 (v0 : Mut20, v1 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v2 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) (v3 : US6) : unit =
    let v4 : (struct ((US2 []) * int32 * US3 * string * string) []) = v2 ()
    let v5 : int32 = v4.Length
    let v6 : (struct ((US2 []) * int32 * US3 * string * string) []) = Array.zeroCreate<struct ((US2 []) * int32 * US3 * string * string)> (v5)
    let v7 : Mut6 = {l0 = 0} : Mut6
    while method20(v5, v7) do
        let v9 : int32 = v7.l0
        let struct (v10 : (US2 []), v11 : int32, v12 : US3, v13 : string, v14 : string) = v4.[int v9]
        let v15 : US3 = v0.l1
        let v16 : bool =
            match v12, v15 with
            | US3_0, US3_0 -> (* GunJsServer *)
                true
            | US3_1, US3_1 -> (* GunRsServer *)
                true
            | _ ->
                false
        let struct (v24 : (US2 []), v25 : int32, v26 : US3, v27 : string, v28 : string) =
            if v16 then
                let v17 : (struct ((US2 []) * int32 * US3 * string * string) -> (US6 -> struct ((US2 []) * int32 * US3 * string * string))) = v0.l2
                let v18 : (US6 -> struct ((US2 []) * int32 * US3 * string * string)) = v17 struct (v10, v11, v12, v13, v14)
                let struct (v19 : (US2 []), v20 : int32, v21 : US3, v22 : string, v23 : string) = v18 v3
                struct (v19, v20, v21, v22, v23)
            else
                struct (v10, v11, v12, v13, v14)
        v6.[int v9] <- struct (v24, v25, v26, v27, v28)
        let v29 : int32 = v9 + 1
        v7.l0 <- v29
        ()
    v1 v6
    ()
and method59 (v0 : Mut20) : JSX.Element =
    let v126 : obj = emitJsExpr () "components_spi.state_context"
    let v127 : string = "useContext"
    let v128 : string = "solid-js"
    let v129 : JS.Function = import v127 v128
    let struct (v130 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v131 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v132 : (unit -> int32), v133 : (int32 -> unit), v134 : (unit -> string), v135 : (string -> unit), v136 : (unit -> string), v137 : (string -> unit), v138 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v139 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v140 : (unit -> (struct (US2 * obj * string) [])), v141 : ((struct (US2 * obj * string) []) -> unit), v142 : (unit -> (struct (int64 * obj) [])), v143 : ((struct (int64 * obj) []) -> unit), v144 : (unit -> (struct (int64 * obj) [])), v145 : ((struct (int64 * obj) []) -> unit), v146 : (unit -> (struct (int64 * int32) [])), v147 : ((struct (int64 * int32) []) -> unit), v148 : (unit -> US4), v149 : (US4 -> unit), v150 : (unit -> US5), v151 : (US5 -> unit)) = v129.Invoke v126 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v152 : (Mut17 -> JSX.Element) = closure200()
    let v153 : (unit -> US6) = closure251(v0, v138)
    let v154 : (US6 -> unit) = closure252(v0, v139, v138)
    method53(v152, v153, v154)
and closure250 () (v0 : Mut20) : JSX.Element =
    method59(v0)
and closure253 () struct (v0 : (US2 []), v1 : int32, v2 : US3, v3 : string, v4 : string) : US6 =
    US6_1(v3)
and closure255 (v0 : Mut19, v1 : (US2 []), v2 : int32, v3 : US3, v4 : string, v5 : string) (v6 : US6) : struct ((US2 []) * int32 * US3 * string * string) =
    let v7 : US3 = v0.l0
    let v10 : string =
        match v6 with
        | US6_0 -> (* None *)
            let v8 : string = ""
            v8
        | US6_1(v9) -> (* Some *)
            v9
    struct (v1, v2, v7, v10, v5)
and closure254 (v0 : Mut19) struct (v1 : (US2 []), v2 : int32, v3 : US3, v4 : string, v5 : string) : (US6 -> struct ((US2 []) * int32 * US3 * string * string)) =
    closure255(v0, v1, v2, v3, v4, v5)
and method61 (v0 : (Mut20 -> JSX.Element), v1 : (struct ((US2 []) * int32 * US3 * string * string) -> US6), v2 : US3, v3 : (struct ((US2 []) * int32 * US3 * string * string) -> (US6 -> struct ((US2 []) * int32 * US3 * string * string)))) : JSX.Element =
    let v4 : Mut20 = {l0 = v1; l1 = v2; l2 = v3} : Mut20
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure249 (v0 : Mut19) () : (JSX.Element []) =
    let v1 : (Mut20 -> JSX.Element) = closure250()
    let v2 : US3 = v0.l0
    let v3 : (struct ((US2 []) * int32 * US3 * string * string) -> US6) = closure253()
    let v4 : (struct ((US2 []) * int32 * US3 * string * string) -> (US6 -> struct ((US2 []) * int32 * US3 * string * string))) = closure254(v0)
    let v5 : JSX.Element = method61(v1, v3, v2, v4)
    [|v5|]
and closure248 (v0 : Mut19) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : string = "URL"
    let v72 : JSX.Element = v71 |> unbox<JSX.Element>
    let v73 : JSX.Element = Html.fragment [ v72 ]
    let v74 : (unit -> (JSX.Element [])) = closure249(v0)
    let v75 : US9 = US9_1(v74)
    let v76 : string = "3px"
    let v77 : US6 = US6_1(v76)
    let v78 : US12 = US12_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v75, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v77, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v78, v64, v65, v66, v67, v68, v69, v70)
and method63 (v0 : int32, v1 : Mut23) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure259 (v0 : Mut22, v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) () : US5 =
    let v2 : (struct ((US2 []) * int32 * US3 * string * string) []) = v1 ()
    let v3 : int32 = v2.Length
    let v4 : US5 = US5_0
    let v5 : Mut23 = {l0 = 0; l1 = v4} : Mut23
    while method63(v3, v5) do
        let v7 : int32 = v5.l0
        let v8 : int32 =  -v7
        let v9 : int32 = v8 + v3
        let v10 : int32 = v9 - 1
        let v11 : US5 = v5.l1
        let struct (v12 : (US2 []), v13 : int32, v14 : US3, v15 : string, v16 : string) = v2.[int v10]
        let v24 : US5 =
            match v11 with
            | US5_0 -> (* None *)
                let v17 : US3 = v0.l1
                let v18 : bool =
                    match v14, v17 with
                    | US3_0, US3_0 -> (* GunJsServer *)
                        true
                    | US3_1, US3_1 -> (* GunRsServer *)
                        true
                    | _ ->
                        false
                if v18 then
                    let v19 : (struct ((US2 []) * int32 * US3 * string * string) -> US5) = v0.l0
                    let v20 : US5 = v19 struct (v12, v13, v14, v15, v16)
                    v20
                else
                    US5_0
            | US5_1(v23) -> (* Some *)
                v11
        let v25 : int32 = v7 + 1
        v5.l0 <- v25
        v5.l1 <- v24
        ()
    let v26 : US5 = v5.l1
    v26
and closure260 (v0 : Mut22, v1 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v2 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) (v3 : US5) : unit =
    let v4 : (struct ((US2 []) * int32 * US3 * string * string) []) = v2 ()
    let v5 : int32 = v4.Length
    let v6 : (struct ((US2 []) * int32 * US3 * string * string) []) = Array.zeroCreate<struct ((US2 []) * int32 * US3 * string * string)> (v5)
    let v7 : Mut6 = {l0 = 0} : Mut6
    while method20(v5, v7) do
        let v9 : int32 = v7.l0
        let struct (v10 : (US2 []), v11 : int32, v12 : US3, v13 : string, v14 : string) = v4.[int v9]
        let v15 : US3 = v0.l1
        let v16 : bool =
            match v12, v15 with
            | US3_0, US3_0 -> (* GunJsServer *)
                true
            | US3_1, US3_1 -> (* GunRsServer *)
                true
            | _ ->
                false
        let struct (v24 : (US2 []), v25 : int32, v26 : US3, v27 : string, v28 : string) =
            if v16 then
                let v17 : (struct ((US2 []) * int32 * US3 * string * string) -> (US5 -> struct ((US2 []) * int32 * US3 * string * string))) = v0.l2
                let v18 : (US5 -> struct ((US2 []) * int32 * US3 * string * string)) = v17 struct (v10, v11, v12, v13, v14)
                let struct (v19 : (US2 []), v20 : int32, v21 : US3, v22 : string, v23 : string) = v18 v3
                struct (v19, v20, v21, v22, v23)
            else
                struct (v10, v11, v12, v13, v14)
        v6.[int v9] <- struct (v24, v25, v26, v27, v28)
        let v29 : int32 = v9 + 1
        v7.l0 <- v29
        ()
    v1 v6
    ()
and method62 (v0 : Mut22) : JSX.Element =
    let v126 : obj = emitJsExpr () "components_spi.state_context"
    let v127 : string = "useContext"
    let v128 : string = "solid-js"
    let v129 : JS.Function = import v127 v128
    let struct (v130 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v131 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v132 : (unit -> int32), v133 : (int32 -> unit), v134 : (unit -> string), v135 : (string -> unit), v136 : (unit -> string), v137 : (string -> unit), v138 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v139 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v140 : (unit -> (struct (US2 * obj * string) [])), v141 : ((struct (US2 * obj * string) []) -> unit), v142 : (unit -> (struct (int64 * obj) [])), v143 : ((struct (int64 * obj) []) -> unit), v144 : (unit -> (struct (int64 * obj) [])), v145 : ((struct (int64 * obj) []) -> unit), v146 : (unit -> (struct (int64 * int32) [])), v147 : ((struct (int64 * int32) []) -> unit), v148 : (unit -> US4), v149 : (US4 -> unit), v150 : (unit -> US5), v151 : (US5 -> unit)) = v129.Invoke v126 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v152 : (Mut18 -> JSX.Element) = closure210()
    let v153 : (unit -> US5) = closure259(v0, v138)
    let v154 : (US5 -> unit) = closure260(v0, v139, v138)
    method55(v152, v153, v154)
and closure258 () (v0 : Mut22) : JSX.Element =
    method62(v0)
and closure261 () struct (v0 : (US2 []), v1 : int32, v2 : US3, v3 : string, v4 : string) : US5 =
    US5_1(v1)
and closure263 (v0 : Mut19, v1 : (US2 []), v2 : int32, v3 : US3, v4 : string, v5 : string) (v6 : US5) : struct ((US2 []) * int32 * US3 * string * string) =
    let v7 : US3 = v0.l0
    let v9 : int32 =
        match v6 with
        | US5_0 -> (* None *)
            0
        | US5_1(v8) -> (* Some *)
            v8
    struct (v1, v9, v7, v4, v5)
and closure262 (v0 : Mut19) struct (v1 : (US2 []), v2 : int32, v3 : US3, v4 : string, v5 : string) : (US5 -> struct ((US2 []) * int32 * US3 * string * string)) =
    closure263(v0, v1, v2, v3, v4, v5)
and method64 (v0 : (Mut22 -> JSX.Element), v1 : (struct ((US2 []) * int32 * US3 * string * string) -> US5), v2 : US3, v3 : (struct ((US2 []) * int32 * US3 * string * string) -> (US5 -> struct ((US2 []) * int32 * US3 * string * string)))) : JSX.Element =
    let v4 : Mut22 = {l0 = v1; l1 = v2; l2 = v3} : Mut22
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure257 (v0 : Mut19) () : (JSX.Element []) =
    let v1 : (Mut22 -> JSX.Element) = closure258()
    let v2 : US3 = v0.l0
    let v3 : (struct ((US2 []) * int32 * US3 * string * string) -> US5) = closure261()
    let v4 : (struct ((US2 []) * int32 * US3 * string * string) -> (US5 -> struct ((US2 []) * int32 * US3 * string * string))) = closure262(v0)
    let v5 : JSX.Element = method64(v1, v3, v2, v4)
    [|v5|]
and closure256 (v0 : Mut19) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : string = "Port"
    let v72 : JSX.Element = v71 |> unbox<JSX.Element>
    let v73 : JSX.Element = Html.fragment [ v72 ]
    let v74 : (unit -> (JSX.Element [])) = closure257(v0)
    let v75 : US9 = US9_1(v74)
    let v76 : string = "3px"
    let v77 : US6 = US6_1(v76)
    let v78 : US12 = US12_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v75, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v77, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v78, v64, v65, v66, v67, v68, v69, v70)
and closure247 (v0 : Mut19) () : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure14()
    let v2 : US14 = US14_0
    let v3 : US14 = US14_0
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure248(v0)
    let v5 : US15 = US15_2
    let v6 : JSX.Element = method26(v1, v2, v3, v4, v5)
    let v7 : US14 = US14_0
    let v8 : US14 = US14_0
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure256(v0)
    let v10 : US15 = US15_2
    let v11 : JSX.Element = method26(v1, v7, v8, v9, v10)
    [|v6; v11|]
and method58 (v0 : Mut19) : JSX.Element =
    let v1 : (Mut1 -> JSX.Element) = closure7()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v3 : (unit -> (JSX.Element [])) = closure247(v0)
    method21(v1, v2, v3)
and closure246 () (v0 : Mut19) : JSX.Element =
    method58(v0)
and method65 (v0 : (Mut19 -> JSX.Element), v1 : US3) : JSX.Element =
    let v2 : Mut19 = {l0 = v1} : Mut19
    let v3 : string = "createComponent"
    let v4 : string = "solid-js"
    let v5 : JS.Function = import v3 v4
    let v6 : JSX.Element = v5.Invoke (v0, v2) |> unbox<JSX.Element>
    v6
and closure245 () () : (JSX.Element []) =
    let v0 : (Mut19 -> JSX.Element) = closure246()
    let v1 : US3 = US3_1
    let v2 : JSX.Element = method65(v0, v1)
    [|v2|]
and closure244 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Gun Rust"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure245()
    let v74 : US9 = US9_1(v73)
    let v75 : US6 = US6_0
    let v76 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v75, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v76, v63, v64, v65, v66, v67, v68, v69)
and closure269 (v0 : Mut24) () : (obj []) =
    let v1 : US3 = v0.l1
    let v2 : string = "props.ServerType:"
    let v3 : obj = struct (v2, v1)
    let v4 : US2 = v0.l0
    let v5 : string = "props.ClientType:"
    let v6 : obj = struct (v5, v4)
    [|v3; v6|]
and method69 (v0 : US2, v1 : (US2 []), v2 : int32) : bool =
    let v3 : int32 = v1.Length
    let v4 : bool = v2 < v3
    if v4 then
        let v5 : US2 = v1.[int v2]
        let v6 : bool =
            match v0, v5 with
            | US2_0, US2_0 -> (* GunJsClient *)
                true
            | US2_1, US2_1 -> (* GunRsClient *)
                true
            | US2_2, US2_2 -> (* Memory *)
                true
            | _ ->
                false
        if v6 then
            true
        else
            let v7 : int32 = v2 + 1
            method69(v0, v1, v7)
    else
        false
and method68 (v0 : Mut24, v1 : (struct ((US2 []) * int32 * US3 * string * string) []), v2 : int32) : bool =
    let v3 : int32 = v1.Length
    let v4 : bool = v2 < v3
    if v4 then
        let struct (v5 : (US2 []), v6 : int32, v7 : US3, v8 : string, v9 : string) = v1.[int v2]
        let v10 : US3 = v0.l1
        let v11 : bool =
            match v7, v10 with
            | US3_0, US3_0 -> (* GunJsServer *)
                true
            | US3_1, US3_1 -> (* GunRsServer *)
                true
            | _ ->
                false
        let v15 : bool =
            if v11 then
                let v12 : US2 = v0.l0
                let v13 : int32 = 0
                method69(v12, v5, v13)
            else
                false
        if v15 then
            true
        else
            let v16 : int32 = v2 + 1
            method68(v0, v1, v16)
    else
        false
and closure270 (v0 : Mut24, v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) () : bool =
    let v2 : (struct ((US2 []) * int32 * US3 * string * string) []) = v1 ()
    let v3 : int32 = 0
    method68(v0, v2, v3)
and method70 (v0 : int32, v1 : Mut25) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure271 (v0 : Mut24, v1 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v2 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) (v3 : bool) : unit =
    let v4 : (struct ((US2 []) * int32 * US3 * string * string) []) = v2 ()
    let v5 : int32 = v4.Length
    let v6 : (struct ((US2 []) * int32 * US3 * string * string) []) = Array.zeroCreate<struct ((US2 []) * int32 * US3 * string * string)> (v5)
    let v7 : Mut6 = {l0 = 0} : Mut6
    while method20(v5, v7) do
        let v9 : int32 = v7.l0
        let struct (v10 : (US2 []), v11 : int32, v12 : US3, v13 : string, v14 : string) = v4.[int v9]
        let v15 : US3 = v0.l1
        let v16 : bool =
            match v12, v15 with
            | US3_0, US3_0 -> (* GunJsServer *)
                true
            | US3_1, US3_1 -> (* GunRsServer *)
                true
            | _ ->
                false
        let struct (v53 : (US2 []), v54 : int32, v55 : US3, v56 : string, v57 : string) =
            if v16 then
                let v52 : (US2 []) =
                    if v3 then
                        let v17 : US2 = v0.l0
                        let v18 : (US2 []) = [|v17|]
                        let v19 : int32 = v10.Length
                        let v20 : int32 = v18.Length
                        let v21 : int32 = v19 + v20
                        let v22 : (US2 []) = Array.zeroCreate<US2> (v21)
                        let v23 : Mut6 = {l0 = 0} : Mut6
                        while method20(v21, v23) do
                            let v25 : int32 = v23.l0
                            let v26 : bool = v25 < v19
                            let v30 : US2 =
                                if v26 then
                                    let v27 : US2 = v10.[int v25]
                                    v27
                                else
                                    let v28 : int32 = v25 - v19
                                    let v29 : US2 = v18.[int v28]
                                    v29
                            v22.[int v25] <- v30
                            let v31 : int32 = v25 + 1
                            v23.l0 <- v31
                            ()
                        v22
                    else
                        let v32 : US2 = v0.l0
                        let v33 : int32 = v10.Length
                        let v34 : (US2 []) = Array.zeroCreate<US2> (v33)
                        let v35 : Mut25 = {l0 = 0; l1 = 0} : Mut25
                        while method70(v33, v35) do
                            let v37 : int32 = v35.l0
                            let v38 : int32 = v35.l1
                            let v39 : US2 = v10.[int v37]
                            let v40 : bool =
                                match v32, v39 with
                                | US2_0, US2_0 -> (* GunJsClient *)
                                    true
                                | US2_1, US2_1 -> (* GunRsClient *)
                                    true
                                | US2_2, US2_2 -> (* Memory *)
                                    true
                                | _ ->
                                    false
                            let v41 : bool = v40 <> true
                            let v43 : int32 =
                                if v41 then
                                    v34.[int v38] <- v39
                                    let v42 : int32 = v38 + 1
                                    v42
                                else
                                    v38
                            let v44 : int32 = v37 + 1
                            v35.l0 <- v44
                            v35.l1 <- v43
                            ()
                        let v45 : int32 = v35.l1
                        let v46 : (US2 []) = Array.zeroCreate<US2> (v45)
                        let v47 : Mut6 = {l0 = 0} : Mut6
                        while method20(v45, v47) do
                            let v49 : int32 = v47.l0
                            let v50 : US2 = v34.[int v49]
                            v46.[int v49] <- v50
                            let v51 : int32 = v49 + 1
                            v47.l0 <- v51
                            ()
                        v46
                struct (v52, v11, v12, v13, v14)
            else
                struct (v10, v11, v12, v13, v14)
        v6.[int v9] <- struct (v53, v54, v55, v56, v57)
        let v58 : int32 = v9 + 1
        v7.l0 <- v58
        ()
    v1 v6
    ()
and closure273 (v0 : Mut24) () : (JSX.Element []) =
    let v1 : US2 = v0.l0
    let v5 : string =
        match v1 with
        | US2_0 -> (* GunJsClient *)
            let v2 : string = "Gun JavaScript"
            v2
        | US2_1 -> (* GunRsClient *)
            let v3 : string = "Gun Rust"
            v3
        | US2_2 -> (* Memory *)
            let v4 : string = "???"
            v4
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure272 (v0 : Mut24) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (unit -> (JSX.Element [])) = closure273(v0)
    let v72 : US9 = US9_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v72, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and method67 (v0 : Mut24) : JSX.Element =
    let v126 : obj = emitJsExpr () "components_spi.state_context"
    let v127 : string = "useContext"
    let v128 : string = "solid-js"
    let v129 : JS.Function = import v127 v128
    let struct (v130 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v131 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v132 : (unit -> int32), v133 : (int32 -> unit), v134 : (unit -> string), v135 : (string -> unit), v136 : (unit -> string), v137 : (string -> unit), v138 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v139 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v140 : (unit -> (struct (US2 * obj * string) [])), v141 : ((struct (US2 * obj * string) []) -> unit), v142 : (unit -> (struct (int64 * obj) [])), v143 : ((struct (int64 * obj) []) -> unit), v144 : (unit -> (struct (int64 * obj) [])), v145 : ((struct (int64 * obj) []) -> unit), v146 : (unit -> (struct (int64 * int32) [])), v147 : ((struct (int64 * int32) []) -> unit), v148 : (unit -> US4), v149 : (US4 -> unit), v150 : (unit -> US5), v151 : (US5 -> unit)) = v129.Invoke v126 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v152 : (unit -> (obj [])) = closure269(v0)
    let v153 : string = "#666"
    let v154 : (US4 -> ((obj []) -> unit)) = method15(v152, v153)
    let v155 : US4 = US4_0
    let v156 : ((obj []) -> unit) = v154 v155
    let v157 : string = "> db_client ()"
    let v158 : obj = v157
    let v159 : (obj []) = [|v158|]
    v156 v159
    let v160 : (Mut4 -> JSX.Element) = closure21()
    let v161 : (unit -> bool) = closure270(v0, v138)
    let v162 : (bool -> unit) = closure271(v0, v139, v138)
    let v163 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure272(v0)
    method13(v160, v161, v162, v163)
and closure268 () (v0 : Mut24) : JSX.Element =
    method67(v0)
and method71 (v0 : (Mut24 -> JSX.Element), v1 : US2, v2 : US3) : JSX.Element =
    let v3 : Mut24 = {l0 = v1; l1 = v2} : Mut24
    let v4 : string = "createComponent"
    let v5 : string = "solid-js"
    let v6 : JS.Function = import v4 v5
    let v7 : JSX.Element = v6.Invoke (v0, v3) |> unbox<JSX.Element>
    v7
and closure267 (v0 : Mut19) () : (JSX.Element []) =
    let v1 : (Mut24 -> JSX.Element) = closure268()
    let v2 : US3 = v0.l0
    let v3 : US2 = US2_1
    let v4 : JSX.Element = method71(v1, v3, v2)
    let v5 : US3 = v0.l0
    let v6 : US2 = US2_0
    let v7 : JSX.Element = method71(v1, v6, v5)
    [|v4; v7|]
and closure266 (v0 : Mut19) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : string = "Clients"
    let v72 : JSX.Element = v71 |> unbox<JSX.Element>
    let v73 : JSX.Element = Html.fragment [ v72 ]
    let v74 : (unit -> (JSX.Element [])) = closure267(v0)
    let v75 : US9 = US9_1(v74)
    let v76 : US6 = US6_0
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v75, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v76, v30, v31, v32, v33, v34, v35, v78, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v79, v64, v65, v66, v67, v68, v69, v70)
and method66 (v0 : Mut19) : JSX.Element =
    let v1 : (Mut3 -> JSX.Element) = closure14()
    let v2 : US14 = US14_0
    let v3 : US14 = US14_0
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure266(v0)
    let v5 : US15 = US15_2
    method26(v1, v2, v3, v4, v5)
and closure265 () (v0 : Mut19) : JSX.Element =
    method66(v0)
and closure264 () () : (JSX.Element []) =
    let v0 : (Mut19 -> JSX.Element) = closure265()
    let v1 : US3 = US3_1
    let v2 : JSX.Element = method65(v0, v1)
    [|v2|]
and closure243 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : (Mut3 -> JSX.Element) = closure14()
    let v71 : US14 = US14_0
    let v72 : US14 = US14_0
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure244()
    let v74 : US15 = US15_2
    let v75 : JSX.Element = method26(v70, v71, v72, v73, v74)
    let v76 : (unit -> (JSX.Element [])) = closure264()
    let v77 : US9 = US9_1(v76)
    let v78 : US6 = US6_0
    let v79 : string = "0"
    let v80 : US6 = US6_1(v79)
    let v81 : US6 = US6_1(v79)
    let v82 : US6 = US6_1(v79)
    let v83 : US12 = US12_1(v75)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v77, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v78, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v80, v81, v52, v82, v54, v55, v56, v57, v58, v59, v60, v61, v83, v63, v64, v65, v66, v67, v68, v69)
and closure276 () () : (JSX.Element []) =
    let v0 : (Mut19 -> JSX.Element) = closure246()
    let v1 : US3 = US3_0
    let v2 : JSX.Element = method65(v0, v1)
    [|v2|]
and closure275 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Gun JavaScript"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure276()
    let v74 : US9 = US9_1(v73)
    let v75 : US6 = US6_0
    let v76 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v75, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v76, v63, v64, v65, v66, v67, v68, v69)
and closure277 () () : (JSX.Element []) =
    let v0 : (Mut19 -> JSX.Element) = closure265()
    let v1 : US3 = US3_0
    let v2 : JSX.Element = method65(v0, v1)
    [|v2|]
and closure274 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : (Mut3 -> JSX.Element) = closure14()
    let v71 : US14 = US14_0
    let v72 : US14 = US14_0
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure275()
    let v74 : US15 = US15_2
    let v75 : JSX.Element = method26(v70, v71, v72, v73, v74)
    let v76 : (unit -> (JSX.Element [])) = closure277()
    let v77 : US9 = US9_1(v76)
    let v78 : US6 = US6_0
    let v79 : string = "0"
    let v80 : US6 = US6_1(v79)
    let v81 : US6 = US6_1(v79)
    let v82 : US6 = US6_1(v79)
    let v83 : US12 = US12_1(v75)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v77, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v78, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v80, v81, v52, v82, v54, v55, v56, v57, v58, v59, v60, v61, v83, v63, v64, v65, v66, v67, v68, v69)
and closure242 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure14()
    let v1 : US14 = US14_0
    let v2 : US14 = US14_0
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure243()
    let v4 : US15 = US15_2
    let v5 : JSX.Element = method26(v0, v1, v2, v3, v4)
    let v6 : US14 = US14_0
    let v7 : US14 = US14_0
    let v8 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure274()
    let v9 : US15 = US15_2
    let v10 : JSX.Element = method26(v0, v6, v7, v8, v9)
    [|v5; v10|]
and method57 () : JSX.Element =
    let v0 : (Mut1 -> JSX.Element) = closure7()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (JSX.Element [])) = closure242()
    method21(v0, v1, v2)
and closure241 () (v0 : Mut1) : JSX.Element =
    method57()
and closure278 () () : (JSX.Element []) =
    [||]
and closure240 () () : (JSX.Element []) =
    let v0 : (Mut1 -> JSX.Element) = closure241()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (JSX.Element [])) = closure278()
    let v3 : JSX.Element = method21(v0, v1, v2)
    [|v3|]
and closure239 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Database"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure240()
    let v74 : US9 = US9_1(v73)
    let v75 : string = "db"
    let v76 : US6 = US6_1(v75)
    let v77 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v76, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v77, v63, v64, v65, v66, v67, v68, v69)
and closure283 (v0 : ((struct (int64 * int32) []) -> unit)) struct (v1 : (struct (int64 * int32) []), v2 : US2, v3 : int64, v4 : int32) : unit =
    let v5 : (struct (int64 * int32) []) = [|struct (v3, v4)|]
    let v6 : int32 = v1.Length
    let v7 : int32 = v5.Length
    let v8 : int32 = v6 + v7
    let v9 : (struct (int64 * int32) []) = Array.zeroCreate<struct (int64 * int32)> (v8)
    let v10 : Mut6 = {l0 = 0} : Mut6
    while method20(v8, v10) do
        let v12 : int32 = v10.l0
        let v13 : bool = v12 < v6
        let struct (v19 : int64, v20 : int32) =
            if v13 then
                let struct (v14 : int64, v15 : int32) = v1.[int v12]
                struct (v14, v15)
            else
                let v16 : int32 = v12 - v6
                let struct (v17 : int64, v18 : int32) = v5.[int v16]
                struct (v17, v18)
        v9.[int v12] <- struct (v19, v20)
        let v21 : int32 = v12 + 1
        v10.l0 <- v21
        ()
    v0 v9
    ()
and closure286 (v0 : (unit -> (struct (int64 * int32) [])), v1 : (int32 -> unit)) (v2 : (exn -> unit)) : unit =
    let v3 : (struct (int64 * int32) []) = v0 ()
    let v4 : int32 = v3.Length
    v1 v4
    ()
and closure285 (v0 : (unit -> (struct (int64 * int32) []))) (v1 : (int32 -> unit)) : ((exn -> unit) -> unit) =
    closure286(v0, v1)
and closure284 (v0 : (unit -> (struct (int64 * int32) []))) (v1 : obj) : JS.Promise<int32> =
    let v2 : ((int32 -> unit) -> ((exn -> unit) -> unit)) = closure285(v0)
    let v3 : JS.Promise<int32> = Promise.create v2
    v3
and closure287 (v0 : string, v1 : (unit -> (struct (int64 * int32) [])), v2 : (unit -> (struct (US2 * obj * string) [])), v3 : (unit -> unit), v4 : (unit -> unit), v5 : (unit -> US16), v6 : (unit -> (struct (US2 * int64 * string) []))) () : (obj []) =
    let v7 : string = "content_address:"
    let v8 : obj = struct (v7, v0)
    let v9 : (struct (int64 * int32) []) = v1 ()
    let v10 : string = "getter:"
    let v11 : obj = struct (v10, v9)
    v3 ()
    let v12 : string = "events:"
    let v13 : obj = v12
    v4 ()
    let v14 : string = "timers:"
    let v15 : obj = v14
    let v16 : US16 = v5 ()
    let v17 : string = "value:"
    let v18 : obj = struct (v17, v16)
    let v19 : (struct (US2 * int64 * string) []) = v6 ()
    let v20 : int32 = v19.Length
    let v21 : (struct (US2 * int64) []) = Array.zeroCreate<struct (US2 * int64)> (v20)
    let v22 : Mut6 = {l0 = 0} : Mut6
    while method20(v20, v22) do
        let v24 : int32 = v22.l0
        let struct (v25 : US2, v26 : int64, v27 : string) = v19.[int v24]
        v21.[int v24] <- struct (v25, v26)
        let v28 : int32 = v24 + 1
        v22.l0 <- v28
        ()
    let v29 : string = "subscriptions:"
    let v30 : obj = struct (v29, v21)
    let v31 : (struct (US2 * obj * string) []) = v2 ()
    let v32 : int32 = v31.Length
    let v33 : (US2 []) = Array.zeroCreate<US2> (v32)
    let v34 : Mut6 = {l0 = 0} : Mut6
    while method20(v32, v34) do
        let v36 : int32 = v34.l0
        let struct (v37 : US2, v38 : obj, v39 : string) = v31.[int v36]
        v33.[int v36] <- v37
        let v40 : int32 = v36 + 1
        v34.l0 <- v40
        ()
    let v41 : string = "db_connections:"
    let v42 : obj = struct (v41, v33)
    [|v8; v11; v13; v15; v18; v30; v42|]
and method74 (v0 : int32, v1 : Mut26) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure289 (v0 : string, v1 : US2) () : (obj []) =
    let v2 : string = "content_address:"
    let v3 : obj = struct (v2, v0)
    let v4 : string = "client_type:"
    let v5 : obj = struct (v4, v1)
    [|v3; v5|]
and method76 (v0 : int32, v1 : Mut27) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method75 (v0 : string, v1 : (unit -> (struct (int64 * int32) [])), v2 : (struct ((struct (int64 * int32) []) * US2 * int64 * int32) -> unit), v3 : (US16 -> unit), v4 : (unit -> US16), v5 : (US4 -> ((obj []) -> unit)), v6 : US2, v7 : (struct (US2 * obj * string) []), v8 : (US4 -> ((obj []) -> unit)), v9 : int32, v10 : obj) : unit =
    let v11 : int64 = DateTime.UtcNow.Ticks / 1000L
    let v12 : US4 = US4_2
    let v13 : ((obj []) -> unit) = v8 v12
    let v14 : string = "> db_on > on_value ()"
    let v15 : obj = v14
    let v16 : string = "v:"
    let v17 : obj = struct (v16, v9)
    let v18 : string = "k:"
    let v19 : obj = struct (v18, v10)
    let v20 : string = "new_timestamp:"
    let v21 : obj = struct (v20, v11)
    let v22 : (obj []) = [|v15; v17; v19; v21|]
    v13 v22
    let v23 : US16 = v4 ()
    match v23 with
    | US16_0 -> (* None *)
        let v24 : US4 = US4_2
        let v25 : ((obj []) -> unit) = v5 v24
        let v26 : string = "> use_fetch > on_value > set ()"
        let v27 : obj = v26
        let v28 : string = "new_value:"
        let v29 : obj = struct (v28, v9)
        let v30 : (obj []) = [|v27; v29|]
        v25 v30
        let v31 : (struct (int64 * int32) []) = v1 ()
        v2 struct (v31, v6, v11, v9)
        let v32 : US16 = US16_1(v6, v11, v9)
        v3 v32
        let v33 : int32 = v7.Length
        let v34 : Mut6 = {l0 = 0} : Mut6
        while method20(v33, v34) do
            let v36 : int32 = v34.l0
            let struct (v37 : US2, v38 : obj, v39 : string) = v7.[int v36]
            let v40 : bool =
                match v37, v6 with
                | US2_0, US2_0 -> (* GunJsClient *)
                    true
                | US2_1, US2_1 -> (* GunRsClient *)
                    true
                | US2_2, US2_2 -> (* Memory *)
                    true
                | _ ->
                    false
            let v41 : bool = v40 <> true
            if v41 then
                let v42 : US4 = US4_2
                let v43 : ((obj []) -> unit) = v5 v42
                let v44 : string = "> use_fetch > on_value > set () > db_put"
                let v45 : obj = v44
                let v46 : obj = struct (v28, v9)
                let v47 : string = "connection_client_type:"
                let v48 : obj = struct (v47, v37)
                let v49 : (obj []) = [|v45; v46; v48|]
                v43 v49
                let v50 : (string []) = v0.Split [| '/' |]
                let v51 : (string -> obj) = v38?get
                let v52 : string = "tictactoe_spiral"
                let v53 : obj = v51 v52
                let v54 : int32 = v50.Length
                let v55 : Mut27 = {l0 = 0; l1 = v53} : Mut27
                while method76(v54, v55) do
                    let v57 : int32 = v55.l0
                    let v58 : obj = v55.l1
                    let v59 : string = v50.[int v57]
                    let v60 : (string -> obj) = v58?get
                    let v61 : obj = v60 v59
                    let v62 : int32 = v57 + 1
                    v55.l0 <- v62
                    v55.l1 <- v61
                    ()
                let v63 : obj = v55.l1
                v63?put v9
                ()
            let v64 : int32 = v36 + 1
            v34.l0 <- v64
            ()
        ()
    | US16_1(v65, v66, v67) -> (* Some *)
        let v68 : bool = v67 <> v9 && v11 > v66
        if v68 then
            let v69 : US4 = US4_2
            let v70 : ((obj []) -> unit) = v5 v69
            let v71 : string = "> use_fetch > on_value > set ()"
            let v72 : obj = v71
            let v73 : string = "new_value:"
            let v74 : obj = struct (v73, v9)
            let v75 : (obj []) = [|v72; v74|]
            v70 v75
            let v76 : (struct (int64 * int32) []) = v1 ()
            v2 struct (v76, v6, v11, v9)
            let v77 : US16 = US16_1(v6, v11, v9)
            v3 v77
            let v78 : int32 = v7.Length
            let v79 : Mut6 = {l0 = 0} : Mut6
            while method20(v78, v79) do
                let v81 : int32 = v79.l0
                let struct (v82 : US2, v83 : obj, v84 : string) = v7.[int v81]
                let v85 : bool =
                    match v82, v6 with
                    | US2_0, US2_0 -> (* GunJsClient *)
                        true
                    | US2_1, US2_1 -> (* GunRsClient *)
                        true
                    | US2_2, US2_2 -> (* Memory *)
                        true
                    | _ ->
                        false
                let v86 : bool = v85 <> true
                if v86 then
                    let v87 : US4 = US4_2
                    let v88 : ((obj []) -> unit) = v5 v87
                    let v89 : string = "> use_fetch > on_value > set () > db_put"
                    let v90 : obj = v89
                    let v91 : obj = struct (v73, v9)
                    let v92 : string = "connection_client_type:"
                    let v93 : obj = struct (v92, v82)
                    let v94 : (obj []) = [|v90; v91; v93|]
                    v88 v94
                    let v95 : (string []) = v0.Split [| '/' |]
                    let v96 : (string -> obj) = v83?get
                    let v97 : string = "tictactoe_spiral"
                    let v98 : obj = v96 v97
                    let v99 : int32 = v95.Length
                    let v100 : Mut27 = {l0 = 0; l1 = v98} : Mut27
                    while method76(v99, v100) do
                        let v102 : int32 = v100.l0
                        let v103 : obj = v100.l1
                        let v104 : string = v95.[int v102]
                        let v105 : (string -> obj) = v103?get
                        let v106 : obj = v105 v104
                        let v107 : int32 = v102 + 1
                        v100.l0 <- v107
                        v100.l1 <- v106
                        ()
                    let v108 : obj = v100.l1
                    v108?put v9
                    ()
                let v109 : int32 = v81 + 1
                v79.l0 <- v109
                ()
            ()
and closure291 (v0 : string, v1 : (unit -> (struct (int64 * int32) [])), v2 : (struct ((struct (int64 * int32) []) * US2 * int64 * int32) -> unit), v3 : (US16 -> unit), v4 : (unit -> US16), v5 : (US4 -> ((obj []) -> unit)), v6 : US2, v7 : (struct (US2 * obj * string) []), v8 : (US4 -> ((obj []) -> unit)), v9 : int32) (v10 : obj) : unit =
    method75(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
and closure290 (v0 : string, v1 : (unit -> (struct (int64 * int32) [])), v2 : (struct ((struct (int64 * int32) []) * US2 * int64 * int32) -> unit), v3 : (US16 -> unit), v4 : (unit -> US16), v5 : (US4 -> ((obj []) -> unit)), v6 : US2, v7 : (struct (US2 * obj * string) []), v8 : (US4 -> ((obj []) -> unit))) (v9 : int32) : (obj -> unit) =
    closure291(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9)
and method77 (v0 : (struct (US2 * string) []), v1 : (struct (US2 * string) []), v2 : int32) : bool =
    let v3 : int32 = v0.Length
    let v4 : bool = v2 < v3
    if v4 then
        let struct (v5 : US2, v6 : string) = v0.[int v2]
        let struct (v7 : US2, v8 : string) = v1.[int v2]
        let v9 : bool =
            match v5, v7 with
            | US2_0, US2_0 -> (* GunJsClient *)
                true
            | US2_1, US2_1 -> (* GunRsClient *)
                true
            | US2_2, US2_2 -> (* Memory *)
                true
            | _ ->
                false
        let v11 : bool =
            if v9 then
                let v10 : bool = v6 = v8
                v10
            else
                false
        if v11 then
            let v12 : int32 = v2 + 1
            method77(v0, v1, v12)
        else
            false
    else
        true
and closure288 (v0 : string, v1 : (unit -> US4), v2 : ((struct (US2 * int64 * string) []) -> unit), v3 : (unit -> (struct (US2 * int64 * string) [])), v4 : (US4 -> ((obj []) -> unit)), v5 : (unit -> (struct (int64 * int32) [])), v6 : (struct ((struct (int64 * int32) []) * US2 * int64 * int32) -> unit), v7 : (US16 -> unit), v8 : (unit -> US16)) (v9 : (struct (US2 * obj * string) [])) : unit =
    let v10 : (struct (US2 * int64 * string) []) = v3 ()
    let v11 : int32 = v9.Length
    let v12 : (struct (US2 * int64 * string) []) = Array.zeroCreate<struct (US2 * int64 * string)> (v11)
    let v13 : Mut6 = {l0 = 0} : Mut6
    while method20(v11, v13) do
        let v15 : int32 = v13.l0
        let struct (v16 : US2, v17 : obj, v18 : string) = v9.[int v15]
        let v19 : int32 = v10.Length
        let v20 : US17 = US17_0
        let v21 : Mut26 = {l0 = 0; l1 = v20} : Mut26
        while method74(v19, v21) do
            let v23 : int32 = v21.l0
            let v24 : int32 =  -v23
            let v25 : int32 = v24 + v19
            let v26 : int32 = v25 - 1
            let v27 : US17 = v21.l1
            let struct (v28 : US2, v29 : int64, v30 : string) = v10.[int v26]
            let v40 : US17 =
                match v27 with
                | US17_0 -> (* None *)
                    let v31 : bool =
                        match v28, v16 with
                        | US2_0, US2_0 -> (* GunJsClient *)
                            true
                        | US2_1, US2_1 -> (* GunRsClient *)
                            true
                        | US2_2, US2_2 -> (* Memory *)
                            true
                        | _ ->
                            false
                    let v33 : bool =
                        if v31 then
                            let v32 : bool = v30 = v18
                            v32
                        else
                            false
                    if v33 then
                        US17_1(v28, v29, v30)
                    else
                        US17_0
                | US17_1(v37, v38, v39) -> (* Some *)
                    v27
            let v41 : int32 = v23 + 1
            v21.l0 <- v41
            v21.l1 <- v40
            ()
        let v42 : US17 = v21.l1
        let struct (v74 : US2, v75 : int64, v76 : string) =
            match v42 with
            | US17_0 -> (* None *)
                let v43 : (unit -> (obj [])) = closure289(v0, v16)
                let v44 : string = "#666"
                let v45 : (US4 -> ((obj []) -> unit)) = method16(v1, v43, v44)
                let v46 : US4 = US4_0
                let v47 : ((obj []) -> unit) = v45 v46
                let v48 : string = "> db_on ()"
                let v49 : obj = v48
                let v50 : (obj []) = [|v49|]
                v47 v50
                let v51 : (int32 -> (obj -> unit)) = closure290(v0, v5, v6, v7, v8, v4, v16, v9, v45)
                let v52 : (struct (obj * obj) -> unit) = emitJsExpr () $"(v: any, k: any) => {v51}(v)(k)"
                let v53 : (string []) = v0.Split [| '/' |]
                let v54 : (string -> obj) = v17?get
                let v55 : string = "tictactoe_spiral"
                let v56 : obj = v54 v55
                let v57 : int32 = v53.Length
                let v58 : Mut27 = {l0 = 0; l1 = v56} : Mut27
                while method76(v57, v58) do
                    let v60 : int32 = v58.l0
                    let v61 : obj = v58.l1
                    let v62 : string = v53.[int v60]
                    let v63 : (string -> obj) = v61?get
                    let v64 : obj = v63 v62
                    let v65 : int32 = v60 + 1
                    v58.l0 <- v65
                    v58.l1 <- v64
                    ()
                let v66 : obj = v58.l1
                let v70 : int64 =
                    match v16 with
                    | US2_0 -> (* GunJsClient *)
                        v66?on v52
                        let v67 : int64 = DateTime.UtcNow.Ticks / 1000L
                        v67
                    | US2_1 -> (* GunRsClient *)
                        let v68 : int64 = v66?on v52
                        v68
                    | US2_2 -> (* Memory *)
                        failwith<int64> "db_on Memory"
                struct (v16, v70, v18)
            | US17_1(v71, v72, v73) -> (* Some *)
                struct (v71, v72, v73)
        v12.[int v15] <- struct (v74, v75, v76)
        let v77 : int32 = v15 + 1
        v13.l0 <- v77
        ()
    let v78 : int32 = v10.Length
    let v79 : (struct (US2 * string) []) = Array.zeroCreate<struct (US2 * string)> (v78)
    let v80 : Mut6 = {l0 = 0} : Mut6
    while method20(v78, v80) do
        let v82 : int32 = v80.l0
        let struct (v83 : US2, v84 : int64, v85 : string) = v10.[int v82]
        v79.[int v82] <- struct (v83, v85)
        let v86 : int32 = v82 + 1
        v80.l0 <- v86
        ()
    let v87 : int32 = v12.Length
    let v88 : (struct (US2 * string) []) = Array.zeroCreate<struct (US2 * string)> (v87)
    let v89 : Mut6 = {l0 = 0} : Mut6
    while method20(v87, v89) do
        let v91 : int32 = v89.l0
        let struct (v92 : US2, v93 : int64, v94 : string) = v12.[int v91]
        v88.[int v91] <- struct (v92, v94)
        let v95 : int32 = v91 + 1
        v89.l0 <- v95
        ()
    let v96 : int32 = v79.Length
    let v97 : int32 = v88.Length
    let v98 : bool = v96 = v97
    let v99 : bool = v98 <> true
    let v102 : bool =
        if v99 then
            false
        else
            let v100 : int32 = 0
            method77(v79, v88, v100)
    let v103 : bool = v102 <> true
    if v103 then
        let v104 : US4 = US4_2
        let v105 : ((obj []) -> unit) = v4 v104
        let v106 : string = "> use_fetch > connections_change"
        let v107 : obj = v106
        let v108 : (struct (US2 * int64) []) = Array.zeroCreate<struct (US2 * int64)> (v87)
        let v109 : Mut6 = {l0 = 0} : Mut6
        while method20(v87, v109) do
            let v111 : int32 = v109.l0
            let struct (v112 : US2, v113 : int64, v114 : string) = v12.[int v111]
            v108.[int v111] <- struct (v112, v113)
            let v115 : int32 = v111 + 1
            v109.l0 <- v115
            ()
        let v116 : string = "new_subscriptions:"
        let v117 : obj = struct (v116, v108)
        let v118 : (obj []) = [|v107; v117|]
        v105 v118
        v2 v12
        ()
and closure292 (v0 : (unit -> (struct (US2 * obj * string) [])), v1 : ((struct (US2 * obj * string) []) -> unit)) () : unit =
    let v2 : (struct (US2 * obj * string) []) = v0 ()
    v1 v2
    ()
and closure293 (v0 : ((struct (US2 * obj * string) []) -> unit), v1 : string, v2 : (US4 -> ((obj []) -> unit))) () : unit =
    v0?clear ()
    let v3 : US4 = US4_0
    let v4 : ((obj []) -> unit) = v2 v3
    let v5 : string = "> use_fetch > unsubscribe () [1]"
    let v6 : obj = v5
    let v7 : (obj []) = [|v6|]
    v4 v7
    let v8 : string = "db_off"
    printfn $"%A{struct (v8, v1)}"
    ()
and closure295 (v0 : string, v1 : (unit -> (struct (int64 * int32) [])), v2 : (struct ((struct (int64 * int32) []) * US2 * int64 * int32) -> unit), v3 : (US16 -> unit), v4 : (unit -> US16), v5 : (US4 -> ((obj []) -> unit)), v6 : (struct (US2 * obj * string) []), v7 : int64) (v8 : int32) : unit =
    let v9 : US16 = v4 ()
    match v9 with
    | US16_0 -> (* None *)
        let v10 : US4 = US4_2
        let v11 : ((obj []) -> unit) = v5 v10
        let v12 : string = "> use_fetch > on_value > set ()"
        let v13 : obj = v12
        let v14 : string = "new_value:"
        let v15 : obj = struct (v14, v8)
        let v16 : (obj []) = [|v13; v15|]
        v11 v16
        let v17 : (struct (int64 * int32) []) = v1 ()
        let v18 : US2 = US2_2
        v2 struct (v17, v18, v7, v8)
        let v19 : US2 = US2_2
        let v20 : US16 = US16_1(v19, v7, v8)
        v3 v20
        let v21 : int32 = v6.Length
        let v22 : Mut6 = {l0 = 0} : Mut6
        while method20(v21, v22) do
            let v24 : int32 = v22.l0
            let struct (v25 : US2, v26 : obj, v27 : string) = v6.[int v24]
            let v29 : bool =
                match v25 with
                | US2_2 -> (* Memory *)
                    true
                | _ ->
                    false
            let v30 : bool = v29 <> true
            if v30 then
                let v31 : US4 = US4_2
                let v32 : ((obj []) -> unit) = v5 v31
                let v33 : string = "> use_fetch > on_value > set () > db_put"
                let v34 : obj = v33
                let v35 : obj = struct (v14, v8)
                let v36 : string = "connection_client_type:"
                let v37 : obj = struct (v36, v25)
                let v38 : (obj []) = [|v34; v35; v37|]
                v32 v38
                let v39 : (string []) = v0.Split [| '/' |]
                let v40 : (string -> obj) = v26?get
                let v41 : string = "tictactoe_spiral"
                let v42 : obj = v40 v41
                let v43 : int32 = v39.Length
                let v44 : Mut27 = {l0 = 0; l1 = v42} : Mut27
                while method76(v43, v44) do
                    let v46 : int32 = v44.l0
                    let v47 : obj = v44.l1
                    let v48 : string = v39.[int v46]
                    let v49 : (string -> obj) = v47?get
                    let v50 : obj = v49 v48
                    let v51 : int32 = v46 + 1
                    v44.l0 <- v51
                    v44.l1 <- v50
                    ()
                let v52 : obj = v44.l1
                v52?put v8
                ()
            let v53 : int32 = v24 + 1
            v22.l0 <- v53
            ()
        ()
    | US16_1(v54, v55, v56) -> (* Some *)
        let v57 : bool = v56 <> v8 && v7 > v55
        if v57 then
            let v58 : US4 = US4_2
            let v59 : ((obj []) -> unit) = v5 v58
            let v60 : string = "> use_fetch > on_value > set ()"
            let v61 : obj = v60
            let v62 : string = "new_value:"
            let v63 : obj = struct (v62, v8)
            let v64 : (obj []) = [|v61; v63|]
            v59 v64
            let v65 : (struct (int64 * int32) []) = v1 ()
            let v66 : US2 = US2_2
            v2 struct (v65, v66, v7, v8)
            let v67 : US2 = US2_2
            let v68 : US16 = US16_1(v67, v7, v8)
            v3 v68
            let v69 : int32 = v6.Length
            let v70 : Mut6 = {l0 = 0} : Mut6
            while method20(v69, v70) do
                let v72 : int32 = v70.l0
                let struct (v73 : US2, v74 : obj, v75 : string) = v6.[int v72]
                let v77 : bool =
                    match v73 with
                    | US2_2 -> (* Memory *)
                        true
                    | _ ->
                        false
                let v78 : bool = v77 <> true
                if v78 then
                    let v79 : US4 = US4_2
                    let v80 : ((obj []) -> unit) = v5 v79
                    let v81 : string = "> use_fetch > on_value > set () > db_put"
                    let v82 : obj = v81
                    let v83 : obj = struct (v62, v8)
                    let v84 : string = "connection_client_type:"
                    let v85 : obj = struct (v84, v73)
                    let v86 : (obj []) = [|v82; v83; v85|]
                    v80 v86
                    let v87 : (string []) = v0.Split [| '/' |]
                    let v88 : (string -> obj) = v74?get
                    let v89 : string = "tictactoe_spiral"
                    let v90 : obj = v88 v89
                    let v91 : int32 = v87.Length
                    let v92 : Mut27 = {l0 = 0; l1 = v90} : Mut27
                    while method76(v91, v92) do
                        let v94 : int32 = v92.l0
                        let v95 : obj = v92.l1
                        let v96 : string = v87.[int v94]
                        let v97 : (string -> obj) = v95?get
                        let v98 : obj = v97 v96
                        let v99 : int32 = v94 + 1
                        v92.l0 <- v99
                        v92.l1 <- v98
                        ()
                    let v100 : obj = v92.l1
                    v100?put v8
                    ()
                let v101 : int32 = v72 + 1
                v70.l0 <- v101
                ()
            ()
and closure294 (v0 : (obj -> JS.Promise<int32>), v1 : (unit -> (struct (US2 * obj * string) [])), v2 : string, v3 : (unit -> (struct (int64 * int32) [])), v4 : (struct ((struct (int64 * int32) []) * US2 * int64 * int32) -> unit), v5 : (US16 -> unit), v6 : (unit -> US16), v7 : (US4 -> ((obj []) -> unit))) () : unit =
    let v8 : (struct (US2 * obj * string) []) = v1 ()
    let v9 : int64 = DateTime.UtcNow.Ticks / 1000L
    let v10 : obj = ()
    let v11 : JS.Promise<int32> = v0 v10
    let v12 : (int32 -> unit) = closure295(v2, v3, v4, v5, v6, v7, v8, v9)
    v11 |> Promise.iter v12
    ()
and closure296 (v0 : (unit -> (struct (US2 * obj * string) [])), v1 : (US4 -> ((obj []) -> unit)), v2 : string, v3 : (unit -> (struct (int64 * int32) [])), v4 : (struct ((struct (int64 * int32) []) * US2 * int64 * int32) -> unit), v5 : (US16 -> unit), v6 : (unit -> US16)) () : unit =
    let v7 : US4 = US4_2
    let v8 : ((obj []) -> unit) = v1 v7
    let v9 : string = ">> use_fetch clear()"
    let v10 : obj = v9
    let v11 : (obj []) = [|v10|]
    v8 v11
    let v12 : (struct (US2 * obj * string) []) = v0 ()
    let v13 : int64 = DateTime.UtcNow.Ticks / 1000L
    let v14 : obj = emitJsExpr () "null"
    let v15 : int32 = v14 |> unbox
    let v16 : US16 = v6 ()
    match v16 with
    | US16_0 -> (* None *)
        let v17 : US4 = US4_2
        let v18 : ((obj []) -> unit) = v1 v17
        let v19 : string = "> use_fetch > on_value > set ()"
        let v20 : obj = v19
        let v21 : string = "new_value:"
        let v22 : obj = struct (v21, v15)
        let v23 : (obj []) = [|v20; v22|]
        v18 v23
        let v24 : (struct (int64 * int32) []) = v3 ()
        let v25 : US2 = US2_2
        v4 struct (v24, v25, v13, v15)
        let v26 : US2 = US2_2
        let v27 : US16 = US16_1(v26, v13, v15)
        v5 v27
        let v28 : int32 = v12.Length
        let v29 : Mut6 = {l0 = 0} : Mut6
        while method20(v28, v29) do
            let v31 : int32 = v29.l0
            let struct (v32 : US2, v33 : obj, v34 : string) = v12.[int v31]
            let v36 : bool =
                match v32 with
                | US2_2 -> (* Memory *)
                    true
                | _ ->
                    false
            let v37 : bool = v36 <> true
            if v37 then
                let v38 : US4 = US4_2
                let v39 : ((obj []) -> unit) = v1 v38
                let v40 : string = "> use_fetch > on_value > set () > db_put"
                let v41 : obj = v40
                let v42 : obj = struct (v21, v15)
                let v43 : string = "connection_client_type:"
                let v44 : obj = struct (v43, v32)
                let v45 : (obj []) = [|v41; v42; v44|]
                v39 v45
                let v46 : (string []) = v2.Split [| '/' |]
                let v47 : (string -> obj) = v33?get
                let v48 : string = "tictactoe_spiral"
                let v49 : obj = v47 v48
                let v50 : int32 = v46.Length
                let v51 : Mut27 = {l0 = 0; l1 = v49} : Mut27
                while method76(v50, v51) do
                    let v53 : int32 = v51.l0
                    let v54 : obj = v51.l1
                    let v55 : string = v46.[int v53]
                    let v56 : (string -> obj) = v54?get
                    let v57 : obj = v56 v55
                    let v58 : int32 = v53 + 1
                    v51.l0 <- v58
                    v51.l1 <- v57
                    ()
                let v59 : obj = v51.l1
                v59?put v15
                ()
            let v60 : int32 = v31 + 1
            v29.l0 <- v60
            ()
        ()
    | US16_1(v61, v62, v63) -> (* Some *)
        let v64 : bool = v63 <> v15 && v13 > v62
        if v64 then
            let v65 : US4 = US4_2
            let v66 : ((obj []) -> unit) = v1 v65
            let v67 : string = "> use_fetch > on_value > set ()"
            let v68 : obj = v67
            let v69 : string = "new_value:"
            let v70 : obj = struct (v69, v15)
            let v71 : (obj []) = [|v68; v70|]
            v66 v71
            let v72 : (struct (int64 * int32) []) = v3 ()
            let v73 : US2 = US2_2
            v4 struct (v72, v73, v13, v15)
            let v74 : US2 = US2_2
            let v75 : US16 = US16_1(v74, v13, v15)
            v5 v75
            let v76 : int32 = v12.Length
            let v77 : Mut6 = {l0 = 0} : Mut6
            while method20(v76, v77) do
                let v79 : int32 = v77.l0
                let struct (v80 : US2, v81 : obj, v82 : string) = v12.[int v79]
                let v84 : bool =
                    match v80 with
                    | US2_2 -> (* Memory *)
                        true
                    | _ ->
                        false
                let v85 : bool = v84 <> true
                if v85 then
                    let v86 : US4 = US4_2
                    let v87 : ((obj []) -> unit) = v1 v86
                    let v88 : string = "> use_fetch > on_value > set () > db_put"
                    let v89 : obj = v88
                    let v90 : obj = struct (v69, v15)
                    let v91 : string = "connection_client_type:"
                    let v92 : obj = struct (v91, v80)
                    let v93 : (obj []) = [|v89; v90; v92|]
                    v87 v93
                    let v94 : (string []) = v2.Split [| '/' |]
                    let v95 : (string -> obj) = v81?get
                    let v96 : string = "tictactoe_spiral"
                    let v97 : obj = v95 v96
                    let v98 : int32 = v94.Length
                    let v99 : Mut27 = {l0 = 0; l1 = v97} : Mut27
                    while method76(v98, v99) do
                        let v101 : int32 = v99.l0
                        let v102 : obj = v99.l1
                        let v103 : string = v94.[int v101]
                        let v104 : (string -> obj) = v102?get
                        let v105 : obj = v104 v103
                        let v106 : int32 = v101 + 1
                        v99.l0 <- v106
                        v99.l1 <- v105
                        ()
                    let v107 : obj = v99.l1
                    v107?put v15
                    ()
                let v108 : int32 = v79 + 1
                v77.l0 <- v108
                ()
            ()
and method73 (v0 : string, v1 : (unit -> (struct (int64 * int32) [])), v2 : (struct ((struct (int64 * int32) []) * US2 * int64 * int32) -> unit), v3 : (obj -> JS.Promise<int32>)) : struct ((unit -> unit) * (unit -> unit)) =
    let v129 : obj = emitJsExpr () "components_spi.state_context"
    let v130 : string = "useContext"
    let v131 : string = "solid-js"
    let v132 : JS.Function = import v130 v131
    let struct (v133 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v134 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v135 : (unit -> int32), v136 : (int32 -> unit), v137 : (unit -> string), v138 : (string -> unit), v139 : (unit -> string), v140 : (string -> unit), v141 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v142 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v143 : (unit -> (struct (US2 * obj * string) [])), v144 : ((struct (US2 * obj * string) []) -> unit), v145 : (unit -> (struct (int64 * obj) [])), v146 : ((struct (int64 * obj) []) -> unit), v147 : (unit -> (struct (int64 * obj) [])), v148 : ((struct (int64 * obj) []) -> unit), v149 : (unit -> (struct (int64 * int32) [])), v150 : ((struct (int64 * int32) []) -> unit), v151 : (unit -> US4), v152 : (US4 -> unit), v153 : (unit -> US5), v154 : (US5 -> unit)) = v132.Invoke v129 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v278 : obj = emitJsExpr () "components_spi.state_context"
    let v279 : JS.Function = import v130 v131
    let struct (v280 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v281 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v282 : (unit -> int32), v283 : (int32 -> unit), v284 : (unit -> string), v285 : (string -> unit), v286 : (unit -> string), v287 : (string -> unit), v288 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v289 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v290 : (unit -> (struct (US2 * obj * string) [])), v291 : ((struct (US2 * obj * string) []) -> unit), v292 : (unit -> (struct (int64 * obj) [])), v293 : ((struct (int64 * obj) []) -> unit), v294 : (unit -> (struct (int64 * obj) [])), v295 : ((struct (int64 * obj) []) -> unit), v296 : (unit -> (struct (int64 * int32) [])), v297 : ((struct (int64 * int32) []) -> unit), v298 : (unit -> US4), v299 : (US4 -> unit), v300 : (unit -> US5), v301 : (US5 -> unit)) = v279.Invoke v278 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v302 : string = "createSignal"
    let v303 : JS.Function = import v302 v131
    let v304 : (JS.Function []) = v303.Invoke () |> unbox<JS.Function[]>
    let v305 : (unit -> unit) = v304.[0] |> unbox
    let v306 : (unit -> unit) = v304.[1] |> unbox
    let v307 : JS.Function = import v302 v131
    let v308 : (JS.Function []) = v307.Invoke () |> unbox<JS.Function[]>
    let v309 : (unit -> unit) = v308.[0] |> unbox
    let v310 : (unit -> unit) = v308.[1] |> unbox
    let v311 : JS.Function = import v302 v131
    let v312 : US16 = US16_0
    let v313 : (JS.Function []) = v311.Invoke v312 |> unbox<JS.Function[]>
    let v314 : (unit -> US16) = v313.[0] |> unbox
    let v315 : (US16 -> unit) = v313.[1] |> unbox
    let v316 : (struct (US2 * int64 * string) []) = [||]
    let v317 : JS.Function = import v302 v131
    let v318 : (JS.Function []) = v317.Invoke v316 |> unbox<JS.Function[]>
    let v319 : (unit -> (struct (US2 * int64 * string) [])) = v318.[0] |> unbox
    let v320 : ((struct (US2 * int64 * string) []) -> unit) = v318.[1] |> unbox
    let v321 : (uint8 []) = System.Text.Encoding.UTF8.GetBytes v0
    let v322 : int32 = v321.Length
    let v323 : Mut25 = {l0 = 0; l1 = 100000} : Mut25
    while method70(v322, v323) do
        let v325 : int32 = v323.l0
        let v326 : int32 = v323.l1
        let v327 : uint8 = v321.[int v325]
        let v328 : int32 = v327 |> unbox<int32>
        let v329 : int32 = v328 * 14
        let v330 : int32 = v326 + v329
        let v331 : int32 = v325 + 1
        v323.l0 <- v331
        v323.l1 <- v330
        ()
    let v332 : int32 = v323.l1
    let v333 : string = v332.ToString ()
    let v334 : string = $"#{v333}"
    let v335 : (unit -> (obj [])) = closure287(v0, v1, v290, v305, v309, v314, v319)
    let v336 : (US4 -> ((obj []) -> unit)) = method15(v335, v334)
    let v337 : US4 = US4_0
    let v338 : ((obj []) -> unit) = v336 v337
    let v339 : string = "> use_fetch ()"
    let v340 : obj = v339
    let v341 : (obj []) = [|v340|]
    v338 v341
    let v342 : string = "debounce"
    let v343 : string = "@solid-primitives/scheduled"
    let v344 : JS.Function = import v342 v343
    let v345 : ((struct (US2 * obj * string) []) -> unit) = closure288(v0, v151, v320, v319, v336, v1, v2, v315, v314)
    let v346 : ((struct (US2 * obj * string) []) -> unit) = v344.Invoke (v345, 2500) |> unbox<(struct (US2 * obj * string) []) -> unit>
    let v347 : string = "createEffect"
    let v348 : JS.Function = import v347 v131
    let v349 : (unit -> unit) = closure292(v290, v346)
    v348.Invoke v349 |> ignore
    let v350 : string = "onCleanup"
    let v351 : JS.Function = import v350 v131
    let v352 : (unit -> unit) = closure293(v346, v0, v336)
    v351.Invoke v352 |> ignore
    let v353 : (unit -> unit) = closure294(v3, v290, v0, v1, v2, v315, v314, v336)
    let v354 : (unit -> unit) = closure296(v290, v336, v0, v1, v2, v315, v314)
    struct (v353, v354)
and closure298 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "center"
    let v71 : string = "baseline"
    let v72 : string = method12(v71, v70)
    let v73 : string = "row"
    let v74 : string = "column"
    let v75 : string = method12(v74, v73)
    let v76 : string = "0"
    let v77 : string = "8px"
    let v78 : string = method12(v77, v76)
    let v79 : US6 = US6_1(v72)
    let v80 : US6 = US6_1(v75)
    let v81 : US6 = US6_1(v78)
    let v82 : string = "3px"
    let v83 : US6 = US6_1(v82)
    let v84 : string = "7px"
    let v85 : US6 = US6_1(v84)
    struct (v79, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v80, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v81, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v83, v50, v51, v52, v53, v54, v55, v56, v57, v85, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure300 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure301 () () : (JSX.Element []) =
    let v0 : string = "Counter"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure303 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v70, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure304 () () : JS.Function =
    let v0 : string = "BiRegularPlus"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure302 (v0 : (unit -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (Mut7 -> JSX.Element) = closure57()
    let v72 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure303()
    let v73 : (unit -> JS.Function) = closure304()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v75 : JSX.Element = method48(v71, v72, v73, v74)
    let v76 : US12 = US12_1(v75)
    let v77 : US14 = US14_1(v0)
    let v78 : string = "10px"
    let v79 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v76, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v77, v45, v46, v47, v48, v49, v50, v51, v52, v79, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure305 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure307 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v70, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure308 () () : JS.Function =
    let v0 : string = "BiRegularMinus"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure306 (v0 : (unit -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (Mut7 -> JSX.Element) = closure57()
    let v72 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure307()
    let v73 : (unit -> JS.Function) = closure308()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v75 : JSX.Element = method48(v71, v72, v73, v74)
    let v76 : US12 = US12_1(v75)
    let v77 : US14 = US14_1(v0)
    let v78 : string = "10px"
    let v79 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v76, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v77, v45, v46, v47, v48, v49, v50, v51, v52, v79, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure309 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure299 (v0 : (unit -> unit), v1 : (unit -> unit)) () : (JSX.Element []) =
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure300()
    let v6 : (unit -> (JSX.Element [])) = closure301()
    let v7 : JSX.Element = method5(v4, v5, v6)
    let v8 : (Mut1 -> JSX.Element) = closure44()
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure302(v1)
    let v10 : (unit -> (JSX.Element [])) = closure305()
    let v11 : JSX.Element = method21(v8, v9, v10)
    let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure306(v0)
    let v13 : (unit -> (JSX.Element [])) = closure309()
    let v14 : JSX.Element = method21(v8, v12, v13)
    [|v7; v11; v14|]
and method78 (v0 : int32, v1 : Mut28) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method79 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH1 = UH1_0(v2, v3, v1)
        method79(v4, v5)
    | UH1_1 -> (* Nil *)
        v1
and method81 (v0 : UH1, v1 : int32) : int32 =
    match v0 with
    | UH1_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method81(v4, v5)
    | UH1_1 -> (* Nil *)
        v1
and method82 (v0 : (struct (int64 * int32) []), v1 : UH1, v2 : int32) : int32 =
    match v1 with
    | UH1_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method82(v0, v5, v6)
    | UH1_1 -> (* Nil *)
        v2
and method80 (v0 : UH1) : (struct (int64 * int32) []) =
    let v1 : int32 = 0
    let v2 : int32 = method81(v0, v1)
    let v3 : (struct (int64 * int32) []) = Array.zeroCreate<struct (int64 * int32)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method82(v3, v0, v4)
    v3
and closure312 (v0 : (struct (int64 * int32) [])) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (obj []) = v0 |> unbox<(obj [])>
    let v72 : US11 = US11_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v72, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure316 (v0 : (unit -> struct (int64 * int32))) () : (JSX.Element []) =
    let struct (v1 : int64, v2 : int32) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = v3 |> unbox<JSX.Element>
    let v5 : JSX.Element = Html.fragment [ v4 ]
    [|v5|]
and closure315 (v0 : (unit -> struct (int64 * int32))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v6 : (unit -> (JSX.Element [])) = closure316(v0)
    let v7 : JSX.Element = method5(v4, v5, v6)
    [|v7|]
and closure314 (v0 : (unit -> struct (int64 * int32))) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let struct (v71 : int64, v72 : int32) = v0 ()
    let v73 : string = v71.ToString ()
    let v74 : JSX.Element = v73 |> unbox<JSX.Element>
    let v75 : JSX.Element = Html.fragment [ v74 ]
    let v76 : (unit -> (JSX.Element [])) = closure315(v0)
    let v77 : US9 = US9_1(v76)
    let v78 : string = "3px"
    let v79 : US6 = US6_1(v78)
    let v80 : US12 = US12_1(v75)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v77, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v79, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v80, v64, v65, v66, v67, v68, v69, v70)
and closure313 () (v0 : (unit -> struct (int64 * int32))) : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure14()
    let v2 : US14 = US14_0
    let v3 : US14 = US14_0
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure314(v0)
    let v5 : US15 = US15_2
    let v6 : JSX.Element = method26(v1, v2, v3, v4, v5)
    [|v6|]
and closure311 (v0 : (unit -> (struct (int64 * int32) []))) () : (JSX.Element []) =
    let v1 : (struct (int64 * int32) []) = v0 ()
    let v2 : int32 = v1.Length
    let v3 : UH1 = UH1_1
    let v4 : Mut28 = {l0 = 0; l1 = v3} : Mut28
    while method78(v2, v4) do
        let v6 : int32 = v4.l0
        let v7 : int32 =  -v6
        let v8 : int32 = v7 + v2
        let v9 : int32 = v8 - 1
        let v10 : UH1 = v4.l1
        let struct (v11 : int64, v12 : int32) = v1.[int v9]
        let v13 : int32 = v6 + 1
        let v14 : UH1 = UH1_0(v11, v12, v10)
        v4.l0 <- v13
        v4.l1 <- v14
        ()
    let v15 : UH1 = v4.l1
    let v16 : UH1 = UH1_1
    let v17 : UH1 = method79(v15, v16)
    let v18 : (struct (int64 * int32) []) = method80(v17)
    let v19 : string = "Index"
    let v20 : string = "solid-js"
    let v21 : JS.Function = import v19 v20
    let v22 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure312(v18)
    let v23 : ((unit -> struct (int64 * int32)) -> (JSX.Element [])) = closure313()
    let v24 : (unit -> (JSX.Element [])) = v23 |> unbox<(unit -> (JSX.Element []))>
    let v25 : JSX.Element = method5(v21, v22, v24)
    [|v25|]
and closure310 (v0 : (unit -> (struct (int64 * int32) []))) () : (JSX.Element []) =
    let v1 : (Mut1 -> JSX.Element) = closure7()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v3 : (unit -> (JSX.Element [])) = closure311(v0)
    let v4 : JSX.Element = method21(v1, v2, v3)
    [|v4|]
and closure297 (v0 : (unit -> (struct (int64 * int32) [])), v1 : (unit -> unit), v2 : (unit -> unit)) struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US10, v19 : US6, v20 : US6, v21 : US6, v22 : US11, v23 : US8, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US12, v31 : US6, v32 : US6, v33 : US6, v34 : US12, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US13, v46 : US14, v47 : US13, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US12, v66 : US6, v67 : US6, v68 : US10, v69 : US10, v70 : US6, v71 : US5, v72 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v73 : string = "Stack"
    let v74 : string = "@hope-ui/solid"
    let v75 : JS.Function = import v73 v74
    let v76 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure298()
    let v77 : (unit -> (JSX.Element [])) = closure299(v1, v2)
    let v78 : JSX.Element = method5(v75, v76, v77)
    let v79 : (unit -> (JSX.Element [])) = closure310(v0)
    let v80 : US9 = US9_1(v79)
    let v81 : string = "counter"
    let v82 : US6 = US6_1(v81)
    let v83 : US12 = US12_1(v78)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v80, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v82, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v83, v66, v67, v68, v69, v70, v71, v72)
and method72 () : JSX.Element =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v138 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * obj * string) [])), v140 : ((struct (US2 * obj * string) []) -> unit), v141 : (unit -> (struct (int64 * obj) [])), v142 : ((struct (int64 * obj) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * int32) [])), v146 : ((struct (int64 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v151 : string = "profile/tmp/counter"
    let v152 : (struct ((struct (int64 * int32) []) * US2 * int64 * int32) -> unit) = closure283(v146)
    let v153 : (obj -> JS.Promise<int32>) = closure284(v145)
    let struct (v154 : (unit -> unit), v155 : (unit -> unit)) = method73(v151, v145, v152, v153)
    let v156 : (Mut3 -> JSX.Element) = closure14()
    let v157 : US14 = US14_0
    let v158 : US14 = US14_0
    let v159 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure297(v145, v155, v154)
    let v160 : US15 = US15_2
    method26(v156, v157, v158, v159, v160)
and closure282 () (v0 : Mut1) : JSX.Element =
    method72()
and closure317 () () : (JSX.Element []) =
    [||]
and closure319 (v0 : ((struct (int64 * obj) []) -> unit)) struct (v1 : (struct (int64 * obj) []), v2 : US2, v3 : int64, v4 : (struct (int64 * obj) [])) : unit =
    v0 v4
    ()
and closure322 (v0 : (unit -> (struct (int64 * obj) [])), v1 : ((struct (int64 * obj) []) -> unit)) (v2 : (exn -> unit)) : unit =
    let v3 : (struct (int64 * obj) []) = v0 ()
    v1 v3
    ()
and closure321 (v0 : (unit -> (struct (int64 * obj) []))) (v1 : ((struct (int64 * obj) []) -> unit)) : ((exn -> unit) -> unit) =
    closure322(v0, v1)
and closure320 (v0 : (unit -> (struct (int64 * obj) []))) (v1 : obj) : JS.Promise<(struct (int64 * obj) [])> =
    let v2 : (((struct (int64 * obj) []) -> unit) -> ((exn -> unit) -> unit)) = closure321(v0)
    let v3 : JS.Promise<(struct (int64 * obj) [])> = Promise.create v2
    v3
and closure323 (v0 : string, v1 : (unit -> (struct (int64 * obj) [])), v2 : (unit -> (struct (US2 * obj * string) [])), v3 : (unit -> unit), v4 : (unit -> unit), v5 : (unit -> US18), v6 : (unit -> (struct (US2 * int64 * string) []))) () : (obj []) =
    let v7 : string = "content_address:"
    let v8 : obj = struct (v7, v0)
    let v9 : (struct (int64 * obj) []) = v1 ()
    let v10 : string = "getter:"
    let v11 : obj = struct (v10, v9)
    v3 ()
    let v12 : string = "events:"
    let v13 : obj = v12
    v4 ()
    let v14 : string = "timers:"
    let v15 : obj = v14
    let v16 : US18 = v5 ()
    let v17 : string = "value:"
    let v18 : obj = struct (v17, v16)
    let v19 : (struct (US2 * int64 * string) []) = v6 ()
    let v20 : int32 = v19.Length
    let v21 : (struct (US2 * int64) []) = Array.zeroCreate<struct (US2 * int64)> (v20)
    let v22 : Mut6 = {l0 = 0} : Mut6
    while method20(v20, v22) do
        let v24 : int32 = v22.l0
        let struct (v25 : US2, v26 : int64, v27 : string) = v19.[int v24]
        v21.[int v24] <- struct (v25, v26)
        let v28 : int32 = v24 + 1
        v22.l0 <- v28
        ()
    let v29 : string = "subscriptions:"
    let v30 : obj = struct (v29, v21)
    let v31 : (struct (US2 * obj * string) []) = v2 ()
    let v32 : int32 = v31.Length
    let v33 : (US2 []) = Array.zeroCreate<US2> (v32)
    let v34 : Mut6 = {l0 = 0} : Mut6
    while method20(v32, v34) do
        let v36 : int32 = v34.l0
        let struct (v37 : US2, v38 : obj, v39 : string) = v31.[int v36]
        v33.[int v36] <- v37
        let v40 : int32 = v36 + 1
        v34.l0 <- v40
        ()
    let v41 : string = "db_connections:"
    let v42 : obj = struct (v41, v33)
    [|v8; v11; v13; v15; v18; v30; v42|]
and method85 (v0 : string, v1 : (unit -> (struct (int64 * obj) [])), v2 : (struct ((struct (int64 * obj) []) * US2 * int64 * (struct (int64 * obj) [])) -> unit), v3 : (US18 -> unit), v4 : (unit -> US18), v5 : (US4 -> ((obj []) -> unit)), v6 : US2, v7 : (struct (US2 * obj * string) []), v8 : (US4 -> ((obj []) -> unit)), v9 : (struct (int64 * obj) []), v10 : obj) : unit =
    let v11 : int64 = DateTime.UtcNow.Ticks / 1000L
    let v12 : US4 = US4_2
    let v13 : ((obj []) -> unit) = v8 v12
    let v14 : string = "> db_on > on_value ()"
    let v15 : obj = v14
    let v16 : string = "v:"
    let v17 : obj = struct (v16, v9)
    let v18 : string = "k:"
    let v19 : obj = struct (v18, v10)
    let v20 : string = "new_timestamp:"
    let v21 : obj = struct (v20, v11)
    let v22 : (obj []) = [|v15; v17; v19; v21|]
    v13 v22
    let v23 : US18 = v4 ()
    match v23 with
    | US18_0 -> (* None *)
        let v24 : US4 = US4_2
        let v25 : ((obj []) -> unit) = v5 v24
        let v26 : string = "> use_fetch > on_value > set ()"
        let v27 : obj = v26
        let v28 : string = "new_value:"
        let v29 : obj = struct (v28, v9)
        let v30 : (obj []) = [|v27; v29|]
        v25 v30
        let v31 : (struct (int64 * obj) []) = v1 ()
        v2 struct (v31, v6, v11, v9)
        let v32 : US18 = US18_1(v6, v11, v9)
        v3 v32
        let v33 : int32 = v7.Length
        let v34 : Mut6 = {l0 = 0} : Mut6
        while method20(v33, v34) do
            let v36 : int32 = v34.l0
            let struct (v37 : US2, v38 : obj, v39 : string) = v7.[int v36]
            let v40 : bool =
                match v37, v6 with
                | US2_0, US2_0 -> (* GunJsClient *)
                    true
                | US2_1, US2_1 -> (* GunRsClient *)
                    true
                | US2_2, US2_2 -> (* Memory *)
                    true
                | _ ->
                    false
            let v41 : bool = v40 <> true
            if v41 then
                let v42 : US4 = US4_2
                let v43 : ((obj []) -> unit) = v5 v42
                let v44 : string = "> use_fetch > on_value > set () > db_put"
                let v45 : obj = v44
                let v46 : obj = struct (v28, v9)
                let v47 : string = "connection_client_type:"
                let v48 : obj = struct (v47, v37)
                let v49 : (obj []) = [|v45; v46; v48|]
                v43 v49
                let v50 : (string []) = v0.Split [| '/' |]
                let v51 : (string -> obj) = v38?get
                let v52 : string = "tictactoe_spiral"
                let v53 : obj = v51 v52
                let v54 : int32 = v50.Length
                let v55 : Mut27 = {l0 = 0; l1 = v53} : Mut27
                while method76(v54, v55) do
                    let v57 : int32 = v55.l0
                    let v58 : obj = v55.l1
                    let v59 : string = v50.[int v57]
                    let v60 : (string -> obj) = v58?get
                    let v61 : obj = v60 v59
                    let v62 : int32 = v57 + 1
                    v55.l0 <- v62
                    v55.l1 <- v61
                    ()
                let v63 : obj = v55.l1
                v63?put v9
                ()
            let v64 : int32 = v36 + 1
            v34.l0 <- v64
            ()
        ()
    | US18_1(v65, v66, v67) -> (* Some *)
        let v68 : bool = v67 <> v9 && v11 > v66
        if v68 then
            let v69 : US4 = US4_2
            let v70 : ((obj []) -> unit) = v5 v69
            let v71 : string = "> use_fetch > on_value > set ()"
            let v72 : obj = v71
            let v73 : string = "new_value:"
            let v74 : obj = struct (v73, v9)
            let v75 : (obj []) = [|v72; v74|]
            v70 v75
            let v76 : (struct (int64 * obj) []) = v1 ()
            v2 struct (v76, v6, v11, v9)
            let v77 : US18 = US18_1(v6, v11, v9)
            v3 v77
            let v78 : int32 = v7.Length
            let v79 : Mut6 = {l0 = 0} : Mut6
            while method20(v78, v79) do
                let v81 : int32 = v79.l0
                let struct (v82 : US2, v83 : obj, v84 : string) = v7.[int v81]
                let v85 : bool =
                    match v82, v6 with
                    | US2_0, US2_0 -> (* GunJsClient *)
                        true
                    | US2_1, US2_1 -> (* GunRsClient *)
                        true
                    | US2_2, US2_2 -> (* Memory *)
                        true
                    | _ ->
                        false
                let v86 : bool = v85 <> true
                if v86 then
                    let v87 : US4 = US4_2
                    let v88 : ((obj []) -> unit) = v5 v87
                    let v89 : string = "> use_fetch > on_value > set () > db_put"
                    let v90 : obj = v89
                    let v91 : obj = struct (v73, v9)
                    let v92 : string = "connection_client_type:"
                    let v93 : obj = struct (v92, v82)
                    let v94 : (obj []) = [|v90; v91; v93|]
                    v88 v94
                    let v95 : (string []) = v0.Split [| '/' |]
                    let v96 : (string -> obj) = v83?get
                    let v97 : string = "tictactoe_spiral"
                    let v98 : obj = v96 v97
                    let v99 : int32 = v95.Length
                    let v100 : Mut27 = {l0 = 0; l1 = v98} : Mut27
                    while method76(v99, v100) do
                        let v102 : int32 = v100.l0
                        let v103 : obj = v100.l1
                        let v104 : string = v95.[int v102]
                        let v105 : (string -> obj) = v103?get
                        let v106 : obj = v105 v104
                        let v107 : int32 = v102 + 1
                        v100.l0 <- v107
                        v100.l1 <- v106
                        ()
                    let v108 : obj = v100.l1
                    v108?put v9
                    ()
                let v109 : int32 = v81 + 1
                v79.l0 <- v109
                ()
            ()
and closure326 (v0 : string, v1 : (unit -> (struct (int64 * obj) [])), v2 : (struct ((struct (int64 * obj) []) * US2 * int64 * (struct (int64 * obj) [])) -> unit), v3 : (US18 -> unit), v4 : (unit -> US18), v5 : (US4 -> ((obj []) -> unit)), v6 : US2, v7 : (struct (US2 * obj * string) []), v8 : (US4 -> ((obj []) -> unit)), v9 : (struct (int64 * obj) [])) (v10 : obj) : unit =
    method85(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
and closure325 (v0 : string, v1 : (unit -> (struct (int64 * obj) [])), v2 : (struct ((struct (int64 * obj) []) * US2 * int64 * (struct (int64 * obj) [])) -> unit), v3 : (US18 -> unit), v4 : (unit -> US18), v5 : (US4 -> ((obj []) -> unit)), v6 : US2, v7 : (struct (US2 * obj * string) []), v8 : (US4 -> ((obj []) -> unit))) (v9 : (struct (int64 * obj) [])) : (obj -> unit) =
    closure326(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9)
and closure324 (v0 : string, v1 : (unit -> US4), v2 : ((struct (US2 * int64 * string) []) -> unit), v3 : (unit -> (struct (US2 * int64 * string) [])), v4 : (US4 -> ((obj []) -> unit)), v5 : (unit -> (struct (int64 * obj) [])), v6 : (struct ((struct (int64 * obj) []) * US2 * int64 * (struct (int64 * obj) [])) -> unit), v7 : (US18 -> unit), v8 : (unit -> US18)) (v9 : (struct (US2 * obj * string) [])) : unit =
    let v10 : (struct (US2 * int64 * string) []) = v3 ()
    let v11 : int32 = v9.Length
    let v12 : (struct (US2 * int64 * string) []) = Array.zeroCreate<struct (US2 * int64 * string)> (v11)
    let v13 : Mut6 = {l0 = 0} : Mut6
    while method20(v11, v13) do
        let v15 : int32 = v13.l0
        let struct (v16 : US2, v17 : obj, v18 : string) = v9.[int v15]
        let v19 : int32 = v10.Length
        let v20 : US17 = US17_0
        let v21 : Mut26 = {l0 = 0; l1 = v20} : Mut26
        while method74(v19, v21) do
            let v23 : int32 = v21.l0
            let v24 : int32 =  -v23
            let v25 : int32 = v24 + v19
            let v26 : int32 = v25 - 1
            let v27 : US17 = v21.l1
            let struct (v28 : US2, v29 : int64, v30 : string) = v10.[int v26]
            let v40 : US17 =
                match v27 with
                | US17_0 -> (* None *)
                    let v31 : bool =
                        match v28, v16 with
                        | US2_0, US2_0 -> (* GunJsClient *)
                            true
                        | US2_1, US2_1 -> (* GunRsClient *)
                            true
                        | US2_2, US2_2 -> (* Memory *)
                            true
                        | _ ->
                            false
                    let v33 : bool =
                        if v31 then
                            let v32 : bool = v30 = v18
                            v32
                        else
                            false
                    if v33 then
                        US17_1(v28, v29, v30)
                    else
                        US17_0
                | US17_1(v37, v38, v39) -> (* Some *)
                    v27
            let v41 : int32 = v23 + 1
            v21.l0 <- v41
            v21.l1 <- v40
            ()
        let v42 : US17 = v21.l1
        let struct (v74 : US2, v75 : int64, v76 : string) =
            match v42 with
            | US17_0 -> (* None *)
                let v43 : (unit -> (obj [])) = closure289(v0, v16)
                let v44 : string = "#666"
                let v45 : (US4 -> ((obj []) -> unit)) = method16(v1, v43, v44)
                let v46 : US4 = US4_0
                let v47 : ((obj []) -> unit) = v45 v46
                let v48 : string = "> db_on ()"
                let v49 : obj = v48
                let v50 : (obj []) = [|v49|]
                v47 v50
                let v51 : ((struct (int64 * obj) []) -> (obj -> unit)) = closure325(v0, v5, v6, v7, v8, v4, v16, v9, v45)
                let v52 : (struct (obj * obj) -> unit) = emitJsExpr () $"(v: any, k: any) => {v51}(v)(k)"
                let v53 : (string []) = v0.Split [| '/' |]
                let v54 : (string -> obj) = v17?get
                let v55 : string = "tictactoe_spiral"
                let v56 : obj = v54 v55
                let v57 : int32 = v53.Length
                let v58 : Mut27 = {l0 = 0; l1 = v56} : Mut27
                while method76(v57, v58) do
                    let v60 : int32 = v58.l0
                    let v61 : obj = v58.l1
                    let v62 : string = v53.[int v60]
                    let v63 : (string -> obj) = v61?get
                    let v64 : obj = v63 v62
                    let v65 : int32 = v60 + 1
                    v58.l0 <- v65
                    v58.l1 <- v64
                    ()
                let v66 : obj = v58.l1
                let v70 : int64 =
                    match v16 with
                    | US2_0 -> (* GunJsClient *)
                        v66?on v52
                        let v67 : int64 = DateTime.UtcNow.Ticks / 1000L
                        v67
                    | US2_1 -> (* GunRsClient *)
                        let v68 : int64 = v66?on v52
                        v68
                    | US2_2 -> (* Memory *)
                        failwith<int64> "db_on Memory"
                struct (v16, v70, v18)
            | US17_1(v71, v72, v73) -> (* Some *)
                struct (v71, v72, v73)
        v12.[int v15] <- struct (v74, v75, v76)
        let v77 : int32 = v15 + 1
        v13.l0 <- v77
        ()
    let v78 : int32 = v10.Length
    let v79 : (struct (US2 * string) []) = Array.zeroCreate<struct (US2 * string)> (v78)
    let v80 : Mut6 = {l0 = 0} : Mut6
    while method20(v78, v80) do
        let v82 : int32 = v80.l0
        let struct (v83 : US2, v84 : int64, v85 : string) = v10.[int v82]
        v79.[int v82] <- struct (v83, v85)
        let v86 : int32 = v82 + 1
        v80.l0 <- v86
        ()
    let v87 : int32 = v12.Length
    let v88 : (struct (US2 * string) []) = Array.zeroCreate<struct (US2 * string)> (v87)
    let v89 : Mut6 = {l0 = 0} : Mut6
    while method20(v87, v89) do
        let v91 : int32 = v89.l0
        let struct (v92 : US2, v93 : int64, v94 : string) = v12.[int v91]
        v88.[int v91] <- struct (v92, v94)
        let v95 : int32 = v91 + 1
        v89.l0 <- v95
        ()
    let v96 : int32 = v79.Length
    let v97 : int32 = v88.Length
    let v98 : bool = v96 = v97
    let v99 : bool = v98 <> true
    let v102 : bool =
        if v99 then
            false
        else
            let v100 : int32 = 0
            method77(v79, v88, v100)
    let v103 : bool = v102 <> true
    if v103 then
        let v104 : US4 = US4_2
        let v105 : ((obj []) -> unit) = v4 v104
        let v106 : string = "> use_fetch > connections_change"
        let v107 : obj = v106
        let v108 : (struct (US2 * int64) []) = Array.zeroCreate<struct (US2 * int64)> (v87)
        let v109 : Mut6 = {l0 = 0} : Mut6
        while method20(v87, v109) do
            let v111 : int32 = v109.l0
            let struct (v112 : US2, v113 : int64, v114 : string) = v12.[int v111]
            v108.[int v111] <- struct (v112, v113)
            let v115 : int32 = v111 + 1
            v109.l0 <- v115
            ()
        let v116 : string = "new_subscriptions:"
        let v117 : obj = struct (v116, v108)
        let v118 : (obj []) = [|v107; v117|]
        v105 v118
        v2 v12
        ()
and closure328 (v0 : string, v1 : (unit -> (struct (int64 * obj) [])), v2 : (struct ((struct (int64 * obj) []) * US2 * int64 * (struct (int64 * obj) [])) -> unit), v3 : (US18 -> unit), v4 : (unit -> US18), v5 : (US4 -> ((obj []) -> unit)), v6 : (struct (US2 * obj * string) []), v7 : int64) (v8 : (struct (int64 * obj) [])) : unit =
    let v9 : US18 = v4 ()
    match v9 with
    | US18_0 -> (* None *)
        let v10 : US4 = US4_2
        let v11 : ((obj []) -> unit) = v5 v10
        let v12 : string = "> use_fetch > on_value > set ()"
        let v13 : obj = v12
        let v14 : string = "new_value:"
        let v15 : obj = struct (v14, v8)
        let v16 : (obj []) = [|v13; v15|]
        v11 v16
        let v17 : (struct (int64 * obj) []) = v1 ()
        let v18 : US2 = US2_2
        v2 struct (v17, v18, v7, v8)
        let v19 : US2 = US2_2
        let v20 : US18 = US18_1(v19, v7, v8)
        v3 v20
        let v21 : int32 = v6.Length
        let v22 : Mut6 = {l0 = 0} : Mut6
        while method20(v21, v22) do
            let v24 : int32 = v22.l0
            let struct (v25 : US2, v26 : obj, v27 : string) = v6.[int v24]
            let v29 : bool =
                match v25 with
                | US2_2 -> (* Memory *)
                    true
                | _ ->
                    false
            let v30 : bool = v29 <> true
            if v30 then
                let v31 : US4 = US4_2
                let v32 : ((obj []) -> unit) = v5 v31
                let v33 : string = "> use_fetch > on_value > set () > db_put"
                let v34 : obj = v33
                let v35 : obj = struct (v14, v8)
                let v36 : string = "connection_client_type:"
                let v37 : obj = struct (v36, v25)
                let v38 : (obj []) = [|v34; v35; v37|]
                v32 v38
                let v39 : (string []) = v0.Split [| '/' |]
                let v40 : (string -> obj) = v26?get
                let v41 : string = "tictactoe_spiral"
                let v42 : obj = v40 v41
                let v43 : int32 = v39.Length
                let v44 : Mut27 = {l0 = 0; l1 = v42} : Mut27
                while method76(v43, v44) do
                    let v46 : int32 = v44.l0
                    let v47 : obj = v44.l1
                    let v48 : string = v39.[int v46]
                    let v49 : (string -> obj) = v47?get
                    let v50 : obj = v49 v48
                    let v51 : int32 = v46 + 1
                    v44.l0 <- v51
                    v44.l1 <- v50
                    ()
                let v52 : obj = v44.l1
                v52?put v8
                ()
            let v53 : int32 = v24 + 1
            v22.l0 <- v53
            ()
        ()
    | US18_1(v54, v55, v56) -> (* Some *)
        let v57 : bool = v56 <> v8 && v7 > v55
        if v57 then
            let v58 : US4 = US4_2
            let v59 : ((obj []) -> unit) = v5 v58
            let v60 : string = "> use_fetch > on_value > set ()"
            let v61 : obj = v60
            let v62 : string = "new_value:"
            let v63 : obj = struct (v62, v8)
            let v64 : (obj []) = [|v61; v63|]
            v59 v64
            let v65 : (struct (int64 * obj) []) = v1 ()
            let v66 : US2 = US2_2
            v2 struct (v65, v66, v7, v8)
            let v67 : US2 = US2_2
            let v68 : US18 = US18_1(v67, v7, v8)
            v3 v68
            let v69 : int32 = v6.Length
            let v70 : Mut6 = {l0 = 0} : Mut6
            while method20(v69, v70) do
                let v72 : int32 = v70.l0
                let struct (v73 : US2, v74 : obj, v75 : string) = v6.[int v72]
                let v77 : bool =
                    match v73 with
                    | US2_2 -> (* Memory *)
                        true
                    | _ ->
                        false
                let v78 : bool = v77 <> true
                if v78 then
                    let v79 : US4 = US4_2
                    let v80 : ((obj []) -> unit) = v5 v79
                    let v81 : string = "> use_fetch > on_value > set () > db_put"
                    let v82 : obj = v81
                    let v83 : obj = struct (v62, v8)
                    let v84 : string = "connection_client_type:"
                    let v85 : obj = struct (v84, v73)
                    let v86 : (obj []) = [|v82; v83; v85|]
                    v80 v86
                    let v87 : (string []) = v0.Split [| '/' |]
                    let v88 : (string -> obj) = v74?get
                    let v89 : string = "tictactoe_spiral"
                    let v90 : obj = v88 v89
                    let v91 : int32 = v87.Length
                    let v92 : Mut27 = {l0 = 0; l1 = v90} : Mut27
                    while method76(v91, v92) do
                        let v94 : int32 = v92.l0
                        let v95 : obj = v92.l1
                        let v96 : string = v87.[int v94]
                        let v97 : (string -> obj) = v95?get
                        let v98 : obj = v97 v96
                        let v99 : int32 = v94 + 1
                        v92.l0 <- v99
                        v92.l1 <- v98
                        ()
                    let v100 : obj = v92.l1
                    v100?put v8
                    ()
                let v101 : int32 = v72 + 1
                v70.l0 <- v101
                ()
            ()
and closure327 (v0 : (obj -> JS.Promise<(struct (int64 * obj) [])>), v1 : (unit -> (struct (US2 * obj * string) [])), v2 : string, v3 : (unit -> (struct (int64 * obj) [])), v4 : (struct ((struct (int64 * obj) []) * US2 * int64 * (struct (int64 * obj) [])) -> unit), v5 : (US18 -> unit), v6 : (unit -> US18), v7 : (US4 -> ((obj []) -> unit))) () : unit =
    let v8 : (struct (US2 * obj * string) []) = v1 ()
    let v9 : int64 = DateTime.UtcNow.Ticks / 1000L
    let v10 : obj = ()
    let v11 : JS.Promise<(struct (int64 * obj) [])> = v0 v10
    let v12 : ((struct (int64 * obj) []) -> unit) = closure328(v2, v3, v4, v5, v6, v7, v8, v9)
    v11 |> Promise.iter v12
    ()
and closure329 (v0 : (unit -> (struct (US2 * obj * string) [])), v1 : (US4 -> ((obj []) -> unit)), v2 : string, v3 : (unit -> (struct (int64 * obj) [])), v4 : (struct ((struct (int64 * obj) []) * US2 * int64 * (struct (int64 * obj) [])) -> unit), v5 : (US18 -> unit), v6 : (unit -> US18)) () : unit =
    let v7 : US4 = US4_2
    let v8 : ((obj []) -> unit) = v1 v7
    let v9 : string = ">> use_fetch clear()"
    let v10 : obj = v9
    let v11 : (obj []) = [|v10|]
    v8 v11
    let v12 : (struct (US2 * obj * string) []) = v0 ()
    let v13 : int64 = DateTime.UtcNow.Ticks / 1000L
    let v14 : obj = emitJsExpr () "null"
    let v15 : (struct (int64 * obj) []) = v14 |> unbox
    let v16 : US18 = v6 ()
    match v16 with
    | US18_0 -> (* None *)
        let v17 : US4 = US4_2
        let v18 : ((obj []) -> unit) = v1 v17
        let v19 : string = "> use_fetch > on_value > set ()"
        let v20 : obj = v19
        let v21 : string = "new_value:"
        let v22 : obj = struct (v21, v15)
        let v23 : (obj []) = [|v20; v22|]
        v18 v23
        let v24 : (struct (int64 * obj) []) = v3 ()
        let v25 : US2 = US2_2
        v4 struct (v24, v25, v13, v15)
        let v26 : US2 = US2_2
        let v27 : US18 = US18_1(v26, v13, v15)
        v5 v27
        let v28 : int32 = v12.Length
        let v29 : Mut6 = {l0 = 0} : Mut6
        while method20(v28, v29) do
            let v31 : int32 = v29.l0
            let struct (v32 : US2, v33 : obj, v34 : string) = v12.[int v31]
            let v36 : bool =
                match v32 with
                | US2_2 -> (* Memory *)
                    true
                | _ ->
                    false
            let v37 : bool = v36 <> true
            if v37 then
                let v38 : US4 = US4_2
                let v39 : ((obj []) -> unit) = v1 v38
                let v40 : string = "> use_fetch > on_value > set () > db_put"
                let v41 : obj = v40
                let v42 : obj = struct (v21, v15)
                let v43 : string = "connection_client_type:"
                let v44 : obj = struct (v43, v32)
                let v45 : (obj []) = [|v41; v42; v44|]
                v39 v45
                let v46 : (string []) = v2.Split [| '/' |]
                let v47 : (string -> obj) = v33?get
                let v48 : string = "tictactoe_spiral"
                let v49 : obj = v47 v48
                let v50 : int32 = v46.Length
                let v51 : Mut27 = {l0 = 0; l1 = v49} : Mut27
                while method76(v50, v51) do
                    let v53 : int32 = v51.l0
                    let v54 : obj = v51.l1
                    let v55 : string = v46.[int v53]
                    let v56 : (string -> obj) = v54?get
                    let v57 : obj = v56 v55
                    let v58 : int32 = v53 + 1
                    v51.l0 <- v58
                    v51.l1 <- v57
                    ()
                let v59 : obj = v51.l1
                v59?put v15
                ()
            let v60 : int32 = v31 + 1
            v29.l0 <- v60
            ()
        ()
    | US18_1(v61, v62, v63) -> (* Some *)
        let v64 : bool = v63 <> v15 && v13 > v62
        if v64 then
            let v65 : US4 = US4_2
            let v66 : ((obj []) -> unit) = v1 v65
            let v67 : string = "> use_fetch > on_value > set ()"
            let v68 : obj = v67
            let v69 : string = "new_value:"
            let v70 : obj = struct (v69, v15)
            let v71 : (obj []) = [|v68; v70|]
            v66 v71
            let v72 : (struct (int64 * obj) []) = v3 ()
            let v73 : US2 = US2_2
            v4 struct (v72, v73, v13, v15)
            let v74 : US2 = US2_2
            let v75 : US18 = US18_1(v74, v13, v15)
            v5 v75
            let v76 : int32 = v12.Length
            let v77 : Mut6 = {l0 = 0} : Mut6
            while method20(v76, v77) do
                let v79 : int32 = v77.l0
                let struct (v80 : US2, v81 : obj, v82 : string) = v12.[int v79]
                let v84 : bool =
                    match v80 with
                    | US2_2 -> (* Memory *)
                        true
                    | _ ->
                        false
                let v85 : bool = v84 <> true
                if v85 then
                    let v86 : US4 = US4_2
                    let v87 : ((obj []) -> unit) = v1 v86
                    let v88 : string = "> use_fetch > on_value > set () > db_put"
                    let v89 : obj = v88
                    let v90 : obj = struct (v69, v15)
                    let v91 : string = "connection_client_type:"
                    let v92 : obj = struct (v91, v80)
                    let v93 : (obj []) = [|v89; v90; v92|]
                    v87 v93
                    let v94 : (string []) = v2.Split [| '/' |]
                    let v95 : (string -> obj) = v81?get
                    let v96 : string = "tictactoe_spiral"
                    let v97 : obj = v95 v96
                    let v98 : int32 = v94.Length
                    let v99 : Mut27 = {l0 = 0; l1 = v97} : Mut27
                    while method76(v98, v99) do
                        let v101 : int32 = v99.l0
                        let v102 : obj = v99.l1
                        let v103 : string = v94.[int v101]
                        let v104 : (string -> obj) = v102?get
                        let v105 : obj = v104 v103
                        let v106 : int32 = v101 + 1
                        v99.l0 <- v106
                        v99.l1 <- v105
                        ()
                    let v107 : obj = v99.l1
                    v107?put v15
                    ()
                let v108 : int32 = v79 + 1
                v77.l0 <- v108
                ()
            ()
and method84 (v0 : string, v1 : (unit -> (struct (int64 * obj) [])), v2 : (struct ((struct (int64 * obj) []) * US2 * int64 * (struct (int64 * obj) [])) -> unit), v3 : (obj -> JS.Promise<(struct (int64 * obj) [])>)) : struct ((unit -> unit) * (unit -> unit)) =
    let v129 : obj = emitJsExpr () "components_spi.state_context"
    let v130 : string = "useContext"
    let v131 : string = "solid-js"
    let v132 : JS.Function = import v130 v131
    let struct (v133 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v134 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v135 : (unit -> int32), v136 : (int32 -> unit), v137 : (unit -> string), v138 : (string -> unit), v139 : (unit -> string), v140 : (string -> unit), v141 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v142 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v143 : (unit -> (struct (US2 * obj * string) [])), v144 : ((struct (US2 * obj * string) []) -> unit), v145 : (unit -> (struct (int64 * obj) [])), v146 : ((struct (int64 * obj) []) -> unit), v147 : (unit -> (struct (int64 * obj) [])), v148 : ((struct (int64 * obj) []) -> unit), v149 : (unit -> (struct (int64 * int32) [])), v150 : ((struct (int64 * int32) []) -> unit), v151 : (unit -> US4), v152 : (US4 -> unit), v153 : (unit -> US5), v154 : (US5 -> unit)) = v132.Invoke v129 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v278 : obj = emitJsExpr () "components_spi.state_context"
    let v279 : JS.Function = import v130 v131
    let struct (v280 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v281 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v282 : (unit -> int32), v283 : (int32 -> unit), v284 : (unit -> string), v285 : (string -> unit), v286 : (unit -> string), v287 : (string -> unit), v288 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v289 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v290 : (unit -> (struct (US2 * obj * string) [])), v291 : ((struct (US2 * obj * string) []) -> unit), v292 : (unit -> (struct (int64 * obj) [])), v293 : ((struct (int64 * obj) []) -> unit), v294 : (unit -> (struct (int64 * obj) [])), v295 : ((struct (int64 * obj) []) -> unit), v296 : (unit -> (struct (int64 * int32) [])), v297 : ((struct (int64 * int32) []) -> unit), v298 : (unit -> US4), v299 : (US4 -> unit), v300 : (unit -> US5), v301 : (US5 -> unit)) = v279.Invoke v278 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v302 : string = "createSignal"
    let v303 : JS.Function = import v302 v131
    let v304 : (JS.Function []) = v303.Invoke () |> unbox<JS.Function[]>
    let v305 : (unit -> unit) = v304.[0] |> unbox
    let v306 : (unit -> unit) = v304.[1] |> unbox
    let v307 : JS.Function = import v302 v131
    let v308 : (JS.Function []) = v307.Invoke () |> unbox<JS.Function[]>
    let v309 : (unit -> unit) = v308.[0] |> unbox
    let v310 : (unit -> unit) = v308.[1] |> unbox
    let v311 : JS.Function = import v302 v131
    let v312 : US18 = US18_0
    let v313 : (JS.Function []) = v311.Invoke v312 |> unbox<JS.Function[]>
    let v314 : (unit -> US18) = v313.[0] |> unbox
    let v315 : (US18 -> unit) = v313.[1] |> unbox
    let v316 : (struct (US2 * int64 * string) []) = [||]
    let v317 : JS.Function = import v302 v131
    let v318 : (JS.Function []) = v317.Invoke v316 |> unbox<JS.Function[]>
    let v319 : (unit -> (struct (US2 * int64 * string) [])) = v318.[0] |> unbox
    let v320 : ((struct (US2 * int64 * string) []) -> unit) = v318.[1] |> unbox
    let v321 : (uint8 []) = System.Text.Encoding.UTF8.GetBytes v0
    let v322 : int32 = v321.Length
    let v323 : Mut25 = {l0 = 0; l1 = 100000} : Mut25
    while method70(v322, v323) do
        let v325 : int32 = v323.l0
        let v326 : int32 = v323.l1
        let v327 : uint8 = v321.[int v325]
        let v328 : int32 = v327 |> unbox<int32>
        let v329 : int32 = v328 * 14
        let v330 : int32 = v326 + v329
        let v331 : int32 = v325 + 1
        v323.l0 <- v331
        v323.l1 <- v330
        ()
    let v332 : int32 = v323.l1
    let v333 : string = v332.ToString ()
    let v334 : string = $"#{v333}"
    let v335 : (unit -> (obj [])) = closure323(v0, v1, v290, v305, v309, v314, v319)
    let v336 : (US4 -> ((obj []) -> unit)) = method15(v335, v334)
    let v337 : US4 = US4_0
    let v338 : ((obj []) -> unit) = v336 v337
    let v339 : string = "> use_fetch ()"
    let v340 : obj = v339
    let v341 : (obj []) = [|v340|]
    v338 v341
    let v342 : string = "debounce"
    let v343 : string = "@solid-primitives/scheduled"
    let v344 : JS.Function = import v342 v343
    let v345 : ((struct (US2 * obj * string) []) -> unit) = closure324(v0, v151, v320, v319, v336, v1, v2, v315, v314)
    let v346 : ((struct (US2 * obj * string) []) -> unit) = v344.Invoke (v345, 2500) |> unbox<(struct (US2 * obj * string) []) -> unit>
    let v347 : string = "createEffect"
    let v348 : JS.Function = import v347 v131
    let v349 : (unit -> unit) = closure292(v290, v346)
    v348.Invoke v349 |> ignore
    let v350 : string = "onCleanup"
    let v351 : JS.Function = import v350 v131
    let v352 : (unit -> unit) = closure293(v346, v0, v336)
    v351.Invoke v352 |> ignore
    let v353 : (unit -> unit) = closure327(v3, v290, v0, v1, v2, v315, v314, v336)
    let v354 : (unit -> unit) = closure329(v290, v336, v0, v1, v2, v315, v314)
    struct (v353, v354)
and closure331 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "center"
    let v71 : string = "baseline"
    let v72 : string = method12(v71, v70)
    let v73 : string = "row"
    let v74 : string = "column"
    let v75 : string = method12(v74, v73)
    let v76 : string = "0"
    let v77 : string = "8px"
    let v78 : string = method12(v77, v76)
    let v79 : US6 = US6_1(v72)
    let v80 : US6 = US6_1(v75)
    let v81 : US6 = US6_1(v78)
    let v82 : string = "3px"
    let v83 : US6 = US6_1(v82)
    let v84 : string = "7px"
    let v85 : US6 = US6_1(v84)
    struct (v79, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v80, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v81, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v83, v50, v51, v52, v53, v54, v55, v56, v57, v85, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure333 () () : (JSX.Element []) =
    let v0 : string = "Chain Status"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure335 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v70, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure334 (v0 : (unit -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (Mut7 -> JSX.Element) = closure57()
    let v72 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure335()
    let v73 : (unit -> JS.Function) = closure304()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v75 : JSX.Element = method48(v71, v72, v73, v74)
    let v76 : US12 = US12_1(v75)
    let v77 : US14 = US14_1(v0)
    let v78 : string = "10px"
    let v79 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v76, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v77, v45, v46, v47, v48, v49, v50, v51, v52, v79, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure336 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure338 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v70, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure337 (v0 : (unit -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (Mut7 -> JSX.Element) = closure57()
    let v72 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure338()
    let v73 : (unit -> JS.Function) = closure308()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v75 : JSX.Element = method48(v71, v72, v73, v74)
    let v76 : US12 = US12_1(v75)
    let v77 : US14 = US14_1(v0)
    let v78 : string = "10px"
    let v79 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v76, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v77, v45, v46, v47, v48, v49, v50, v51, v52, v79, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure339 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure332 (v0 : (unit -> unit), v1 : (unit -> unit)) () : (JSX.Element []) =
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v6 : (unit -> (JSX.Element [])) = closure333()
    let v7 : JSX.Element = method5(v4, v5, v6)
    let v8 : (Mut1 -> JSX.Element) = closure44()
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure334(v1)
    let v10 : (unit -> (JSX.Element [])) = closure336()
    let v11 : JSX.Element = method21(v8, v9, v10)
    let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure337(v0)
    let v13 : (unit -> (JSX.Element [])) = closure339()
    let v14 : JSX.Element = method21(v8, v12, v13)
    [|v7; v11; v14|]
and method86 (v0 : int32, v1 : Mut29) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method87 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH2 = UH2_0(v2, v3, v1)
        method87(v4, v5)
    | UH2_1 -> (* Nil *)
        v1
and method89 (v0 : UH2, v1 : int32) : int32 =
    match v0 with
    | UH2_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method89(v4, v5)
    | UH2_1 -> (* Nil *)
        v1
and method90 (v0 : (struct (int64 * obj) []), v1 : UH2, v2 : int32) : int32 =
    match v1 with
    | UH2_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method90(v0, v5, v6)
    | UH2_1 -> (* Nil *)
        v2
and method88 (v0 : UH2) : (struct (int64 * obj) []) =
    let v1 : int32 = 0
    let v2 : int32 = method89(v0, v1)
    let v3 : (struct (int64 * obj) []) = Array.zeroCreate<struct (int64 * obj)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method90(v3, v0, v4)
    v3
and closure342 (v0 : (struct (int64 * obj) [])) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (obj []) = v0 |> unbox<(obj [])>
    let v72 : US11 = US11_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v72, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure346 (v0 : (unit -> struct (int64 * obj))) () : (JSX.Element []) =
    let struct (v1 : int64, v2 : obj) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = v3 |> unbox<JSX.Element>
    let v5 : JSX.Element = Html.fragment [ v4 ]
    [|v5|]
and closure345 (v0 : (unit -> struct (int64 * obj))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v6 : (unit -> (JSX.Element [])) = closure346(v0)
    let v7 : JSX.Element = method5(v4, v5, v6)
    [|v7|]
and closure344 (v0 : (unit -> struct (int64 * obj))) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let struct (v71 : int64, v72 : obj) = v0 ()
    let v73 : string = v71.ToString ()
    let v74 : JSX.Element = v73 |> unbox<JSX.Element>
    let v75 : JSX.Element = Html.fragment [ v74 ]
    let v76 : (unit -> (JSX.Element [])) = closure345(v0)
    let v77 : US9 = US9_1(v76)
    let v78 : string = "3px"
    let v79 : US6 = US6_1(v78)
    let v80 : US12 = US12_1(v75)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v77, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v79, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v80, v64, v65, v66, v67, v68, v69, v70)
and closure343 () (v0 : (unit -> struct (int64 * obj))) : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure14()
    let v2 : US14 = US14_0
    let v3 : US14 = US14_0
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure344(v0)
    let v5 : US15 = US15_2
    let v6 : JSX.Element = method26(v1, v2, v3, v4, v5)
    [|v6|]
and closure341 (v0 : (unit -> (struct (int64 * obj) []))) () : (JSX.Element []) =
    let v1 : (struct (int64 * obj) []) = v0 ()
    let v2 : int32 = v1.Length
    let v3 : UH2 = UH2_1
    let v4 : Mut29 = {l0 = 0; l1 = v3} : Mut29
    while method86(v2, v4) do
        let v6 : int32 = v4.l0
        let v7 : int32 =  -v6
        let v8 : int32 = v7 + v2
        let v9 : int32 = v8 - 1
        let v10 : UH2 = v4.l1
        let struct (v11 : int64, v12 : obj) = v1.[int v9]
        let v13 : int32 = v6 + 1
        let v14 : UH2 = UH2_0(v11, v12, v10)
        v4.l0 <- v13
        v4.l1 <- v14
        ()
    let v15 : UH2 = v4.l1
    let v16 : UH2 = UH2_1
    let v17 : UH2 = method87(v15, v16)
    let v18 : (struct (int64 * obj) []) = method88(v17)
    let v19 : string = "Index"
    let v20 : string = "solid-js"
    let v21 : JS.Function = import v19 v20
    let v22 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure342(v18)
    let v23 : ((unit -> struct (int64 * obj)) -> (JSX.Element [])) = closure343()
    let v24 : (unit -> (JSX.Element [])) = v23 |> unbox<(unit -> (JSX.Element []))>
    let v25 : JSX.Element = method5(v21, v22, v24)
    [|v25|]
and closure340 (v0 : (unit -> (struct (int64 * obj) []))) () : (JSX.Element []) =
    let v1 : (Mut1 -> JSX.Element) = closure7()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v3 : (unit -> (JSX.Element [])) = closure341(v0)
    let v4 : JSX.Element = method21(v1, v2, v3)
    [|v4|]
and closure330 (v0 : (unit -> (struct (int64 * obj) [])), v1 : (unit -> unit), v2 : (unit -> unit)) struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US10, v19 : US6, v20 : US6, v21 : US6, v22 : US11, v23 : US8, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US12, v31 : US6, v32 : US6, v33 : US6, v34 : US12, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US13, v46 : US14, v47 : US13, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US12, v66 : US6, v67 : US6, v68 : US10, v69 : US10, v70 : US6, v71 : US5, v72 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v73 : string = "Stack"
    let v74 : string = "@hope-ui/solid"
    let v75 : JS.Function = import v73 v74
    let v76 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure331()
    let v77 : (unit -> (JSX.Element [])) = closure332(v1, v2)
    let v78 : JSX.Element = method5(v75, v76, v77)
    let v79 : (unit -> (JSX.Element [])) = closure340(v0)
    let v80 : US9 = US9_1(v79)
    let v81 : string = "status"
    let v82 : US6 = US6_1(v81)
    let v83 : US12 = US12_1(v78)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v80, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v82, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v83, v66, v67, v68, v69, v70, v71, v72)
and method83 () : JSX.Element =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v138 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * obj * string) [])), v140 : ((struct (US2 * obj * string) []) -> unit), v141 : (unit -> (struct (int64 * obj) [])), v142 : ((struct (int64 * obj) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * int32) [])), v146 : ((struct (int64 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v151 : string = "profile/tmp/chain_status"
    let v152 : (struct ((struct (int64 * obj) []) * US2 * int64 * (struct (int64 * obj) [])) -> unit) = closure319(v144)
    let v153 : (obj -> JS.Promise<(struct (int64 * obj) [])>) = closure320(v143)
    let struct (v154 : (unit -> unit), v155 : (unit -> unit)) = method84(v151, v143, v152, v153)
    let v156 : (Mut3 -> JSX.Element) = closure14()
    let v157 : US14 = US14_0
    let v158 : US14 = US14_0
    let v159 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure330(v143, v155, v154)
    let v160 : US15 = US15_2
    method26(v156, v157, v158, v159, v160)
and closure318 () (v0 : Mut1) : JSX.Element =
    method83()
and closure347 () () : (JSX.Element []) =
    [||]
and closure349 (v0 : ((struct (int64 * obj) []) -> unit)) struct (v1 : (struct (int64 * obj) []), v2 : US2, v3 : int64, v4 : (struct (int64 * obj) [])) : unit =
    v0 v4
    ()
and closure352 (v0 : (unit -> (struct (int64 * obj) [])), v1 : ((struct (int64 * obj) []) -> unit)) (v2 : (exn -> unit)) : unit =
    let v3 : (struct (int64 * obj) []) = v0 ()
    v1 v3
    ()
and closure351 (v0 : (unit -> (struct (int64 * obj) []))) (v1 : ((struct (int64 * obj) []) -> unit)) : ((exn -> unit) -> unit) =
    closure352(v0, v1)
and closure350 (v0 : (unit -> (struct (int64 * obj) []))) (v1 : obj) : JS.Promise<(struct (int64 * obj) [])> =
    let v2 : (((struct (int64 * obj) []) -> unit) -> ((exn -> unit) -> unit)) = closure351(v0)
    let v3 : JS.Promise<(struct (int64 * obj) [])> = Promise.create v2
    v3
and closure354 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "center"
    let v71 : string = "baseline"
    let v72 : string = method12(v71, v70)
    let v73 : string = "row"
    let v74 : string = "column"
    let v75 : string = method12(v74, v73)
    let v76 : string = "0"
    let v77 : string = "8px"
    let v78 : string = method12(v77, v76)
    let v79 : US6 = US6_1(v72)
    let v80 : US6 = US6_1(v75)
    let v81 : US6 = US6_1(v78)
    let v82 : string = "3px"
    let v83 : US6 = US6_1(v82)
    let v84 : string = "7px"
    let v85 : US6 = US6_1(v84)
    struct (v79, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v80, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v81, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v83, v50, v51, v52, v53, v54, v55, v56, v57, v85, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure356 () () : (JSX.Element []) =
    let v0 : string = "Chain Deploy"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure358 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v70, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure357 (v0 : (unit -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (Mut7 -> JSX.Element) = closure57()
    let v72 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure358()
    let v73 : (unit -> JS.Function) = closure304()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v75 : JSX.Element = method48(v71, v72, v73, v74)
    let v76 : US12 = US12_1(v75)
    let v77 : US14 = US14_1(v0)
    let v78 : string = "10px"
    let v79 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v76, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v77, v45, v46, v47, v48, v49, v50, v51, v52, v79, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure359 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure361 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v70, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure360 (v0 : (unit -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (Mut7 -> JSX.Element) = closure57()
    let v72 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure361()
    let v73 : (unit -> JS.Function) = closure308()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v75 : JSX.Element = method48(v71, v72, v73, v74)
    let v76 : US12 = US12_1(v75)
    let v77 : US14 = US14_1(v0)
    let v78 : string = "10px"
    let v79 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v76, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v77, v45, v46, v47, v48, v49, v50, v51, v52, v79, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure362 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure355 (v0 : (unit -> unit), v1 : (unit -> unit)) () : (JSX.Element []) =
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v6 : (unit -> (JSX.Element [])) = closure356()
    let v7 : JSX.Element = method5(v4, v5, v6)
    let v8 : (Mut1 -> JSX.Element) = closure44()
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure357(v1)
    let v10 : (unit -> (JSX.Element [])) = closure359()
    let v11 : JSX.Element = method21(v8, v9, v10)
    let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure360(v0)
    let v13 : (unit -> (JSX.Element [])) = closure362()
    let v14 : JSX.Element = method21(v8, v12, v13)
    [|v7; v11; v14|]
and closure368 (v0 : (unit -> struct (int64 * obj))) () : (JSX.Element []) =
    let struct (v1 : int64, v2 : obj) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = v3 |> unbox<JSX.Element>
    let v5 : JSX.Element = Html.fragment [ v4 ]
    [|v5|]
and closure367 (v0 : (unit -> struct (int64 * obj))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v6 : (unit -> (JSX.Element [])) = closure368(v0)
    let v7 : JSX.Element = method5(v4, v5, v6)
    [|v7|]
and closure366 (v0 : (unit -> struct (int64 * obj))) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let struct (v71 : int64, v72 : obj) = v0 ()
    let v73 : string = v71.ToString ()
    let v74 : JSX.Element = v73 |> unbox<JSX.Element>
    let v75 : JSX.Element = Html.fragment [ v74 ]
    let v76 : (unit -> (JSX.Element [])) = closure367(v0)
    let v77 : US9 = US9_1(v76)
    let v78 : string = "3px"
    let v79 : US6 = US6_1(v78)
    let v80 : US12 = US12_1(v75)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v77, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v79, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v80, v64, v65, v66, v67, v68, v69, v70)
and closure365 () (v0 : (unit -> struct (int64 * obj))) : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure14()
    let v2 : US14 = US14_0
    let v3 : US14 = US14_0
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure366(v0)
    let v5 : US15 = US15_2
    let v6 : JSX.Element = method26(v1, v2, v3, v4, v5)
    [|v6|]
and closure364 (v0 : (unit -> (struct (int64 * obj) []))) () : (JSX.Element []) =
    let v1 : (struct (int64 * obj) []) = v0 ()
    let v2 : int32 = v1.Length
    let v3 : UH2 = UH2_1
    let v4 : Mut29 = {l0 = 0; l1 = v3} : Mut29
    while method86(v2, v4) do
        let v6 : int32 = v4.l0
        let v7 : int32 =  -v6
        let v8 : int32 = v7 + v2
        let v9 : int32 = v8 - 1
        let v10 : UH2 = v4.l1
        let struct (v11 : int64, v12 : obj) = v1.[int v9]
        let v13 : int32 = v6 + 1
        let v14 : UH2 = UH2_0(v11, v12, v10)
        v4.l0 <- v13
        v4.l1 <- v14
        ()
    let v15 : UH2 = v4.l1
    let v16 : UH2 = UH2_1
    let v17 : UH2 = method87(v15, v16)
    let v18 : (struct (int64 * obj) []) = method88(v17)
    let v19 : string = "Index"
    let v20 : string = "solid-js"
    let v21 : JS.Function = import v19 v20
    let v22 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure342(v18)
    let v23 : ((unit -> struct (int64 * obj)) -> (JSX.Element [])) = closure365()
    let v24 : (unit -> (JSX.Element [])) = v23 |> unbox<(unit -> (JSX.Element []))>
    let v25 : JSX.Element = method5(v21, v22, v24)
    [|v25|]
and closure363 (v0 : (unit -> (struct (int64 * obj) []))) () : (JSX.Element []) =
    let v1 : (Mut1 -> JSX.Element) = closure7()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v3 : (unit -> (JSX.Element [])) = closure364(v0)
    let v4 : JSX.Element = method21(v1, v2, v3)
    [|v4|]
and closure353 (v0 : (unit -> (struct (int64 * obj) [])), v1 : (unit -> unit), v2 : (unit -> unit)) struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US10, v19 : US6, v20 : US6, v21 : US6, v22 : US11, v23 : US8, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US12, v31 : US6, v32 : US6, v33 : US6, v34 : US12, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US13, v46 : US14, v47 : US13, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US12, v66 : US6, v67 : US6, v68 : US10, v69 : US10, v70 : US6, v71 : US5, v72 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v73 : string = "Stack"
    let v74 : string = "@hope-ui/solid"
    let v75 : JS.Function = import v73 v74
    let v76 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure354()
    let v77 : (unit -> (JSX.Element [])) = closure355(v1, v2)
    let v78 : JSX.Element = method5(v75, v76, v77)
    let v79 : (unit -> (JSX.Element [])) = closure363(v0)
    let v80 : US9 = US9_1(v79)
    let v81 : string = "deploy"
    let v82 : US6 = US6_1(v81)
    let v83 : US12 = US12_1(v78)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v80, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v82, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v83, v66, v67, v68, v69, v70, v71, v72)
and method91 () : JSX.Element =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v138 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * obj * string) [])), v140 : ((struct (US2 * obj * string) []) -> unit), v141 : (unit -> (struct (int64 * obj) [])), v142 : ((struct (int64 * obj) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * int32) [])), v146 : ((struct (int64 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v151 : string = "profile/tmp/chain_deploy"
    let v152 : (struct ((struct (int64 * obj) []) * US2 * int64 * (struct (int64 * obj) [])) -> unit) = closure349(v142)
    let v153 : (obj -> JS.Promise<(struct (int64 * obj) [])>) = closure350(v141)
    let struct (v154 : (unit -> unit), v155 : (unit -> unit)) = method84(v151, v141, v152, v153)
    let v156 : (Mut3 -> JSX.Element) = closure14()
    let v157 : US14 = US14_0
    let v158 : US14 = US14_0
    let v159 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure353(v141, v155, v154)
    let v160 : US15 = US15_2
    method26(v156, v157, v158, v159, v160)
and closure348 () (v0 : Mut1) : JSX.Element =
    method91()
and closure369 () () : (JSX.Element []) =
    [||]
and closure281 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut1 -> JSX.Element) = closure282()
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure317()
    let v8 : JSX.Element = method21(v5, v6, v7)
    let v10 : bool = v2 = ""
    let v11 : bool = v10 <> true
    let v16 : JSX.Element =
        if v11 then
            let v12 : (Mut1 -> JSX.Element) = closure318()
            let v13 : (unit -> (JSX.Element [])) = closure347()
            method21(v12, v6, v13)
        else
            let v15 : JSX.Element = JS.undefined
            v15
    let v22 : JSX.Element =
        if v11 then
            let v18 : (Mut1 -> JSX.Element) = closure348()
            let v19 : (unit -> (JSX.Element [])) = closure369()
            method21(v18, v6, v19)
        else
            let v21 : JSX.Element = JS.undefined
            v21
    [|v8; v16; v22|]
and closure280 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut1 -> JSX.Element) = closure7()
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure281(v0, v1, v2, v3, v4)
    let v8 : JSX.Element = method21(v5, v6, v7)
    [|v8|]
and closure279 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) struct (v5 : US6, v6 : US6, v7 : US6, v8 : US7, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US8, v16 : US9, v17 : US6, v18 : US6, v19 : US8, v20 : US10, v21 : US6, v22 : US6, v23 : US6, v24 : US11, v25 : US8, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US12, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US13, v48 : US14, v49 : US13, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US12, v68 : US6, v69 : US6, v70 : US10, v71 : US10, v72 : US6, v73 : US5, v74 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v75 : string = "Profile"
    let v76 : JSX.Element = v75 |> unbox<JSX.Element>
    let v77 : JSX.Element = Html.fragment [ v76 ]
    let v78 : (unit -> (JSX.Element [])) = closure280(v0, v1, v2, v3, v4)
    let v79 : US9 = US9_1(v78)
    let v80 : US12 = US12_1(v77)
    struct (v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v79, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v80, v68, v69, v70, v71, v72, v73, v74)
and closure149 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut3 -> JSX.Element) = closure14()
    let v6 : US14 = US14_0
    let v7 : US14 = US14_0
    let v8 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure150()
    let v9 : US15 = US15_2
    let v10 : JSX.Element = method26(v5, v6, v7, v8, v9)
    let v11 : US14 = US14_0
    let v12 : US14 = US14_0
    let v13 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure12()
    let v14 : US15 = US15_2
    let v15 : JSX.Element = method26(v5, v11, v12, v13, v14)
    let v16 : US14 = US14_0
    let v17 : US14 = US14_0
    let v18 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure174()
    let v19 : US15 = US15_2
    let v20 : JSX.Element = method26(v5, v16, v17, v18, v19)
    let v21 : US14 = US14_0
    let v22 : US14 = US14_0
    let v23 : US15 = US15_2
    let v24 : JSX.Element = method26(v5, v21, v22, v13, v23)
    let v25 : US14 = US14_0
    let v26 : US14 = US14_0
    let v27 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure190()
    let v28 : US15 = US15_0
    let v29 : JSX.Element = method26(v5, v25, v26, v27, v28)
    let v30 : US14 = US14_0
    let v31 : US14 = US14_0
    let v32 : US15 = US15_2
    let v33 : JSX.Element = method26(v5, v30, v31, v13, v32)
    let v34 : US14 = US14_0
    let v35 : US14 = US14_0
    let v36 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure239()
    let v37 : US15 = US15_0
    let v38 : JSX.Element = method26(v5, v34, v35, v36, v37)
    let v39 : US14 = US14_0
    let v40 : US14 = US14_0
    let v41 : US15 = US15_2
    let v42 : JSX.Element = method26(v5, v39, v40, v13, v41)
    let v43 : US14 = US14_0
    let v44 : US14 = US14_0
    let v45 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure279(v0, v1, v2, v3, v4)
    let v46 : US15 = US15_2
    let v47 : JSX.Element = method26(v5, v43, v44, v45, v46)
    [|v10; v15; v20; v24; v29; v33; v38; v42; v47|]
and closure3 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v6 : bool = v2 = ""
    let v10 : JSX.Element =
        if v6 then
            let v7 : (Mut2 -> JSX.Element) = closure4()
            method45(v7)
        else
            let v9 : JSX.Element = JS.undefined
            v9
    let v11 : (Mut1 -> JSX.Element) = closure7()
    let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure148()
    let v13 : (unit -> (JSX.Element [])) = closure149(v0, v1, v2, v3, v4)
    let v14 : JSX.Element = method21(v11, v12, v13)
    [|v10; v14|]
and method1 () : JSX.Element =
    let struct (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) = method2()
    let v5 : string = "Box"
    let v6 : string = "@hope-ui/solid"
    let v7 : JS.Function = import v5 v6
    let v8 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure2()
    let v9 : (unit -> (JSX.Element [])) = closure3(v0, v1, v2, v3, v4)
    method5(v7, v8, v9)
and closure1 () (v0 : Mut1) : JSX.Element =
    method1()
and closure371 (v0 : (unit -> (struct (US2 * obj * string) [])), v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) () : (obj []) =
    let v2 : (struct ((US2 []) * int32 * US3 * string * string) []) = v1 ()
    let v3 : string = "db_connection_options':"
    let v4 : obj = struct (v3, v2)
    let v5 : (struct (US2 * obj * string) []) = v0 ()
    let v6 : string = "db_connections':"
    let v7 : obj = struct (v6, v5)
    [|v4; v7|]
and method93 (v0 : int32, v1 : Mut30) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method94 (v0 : int32, v1 : Mut31) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method95 (v0 : int32, v1 : Mut32) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure372 (v0 : ((struct (US2 * obj * string) []) -> unit), v1 : (US4 -> ((obj []) -> unit))) struct (v2 : (struct ((US2 []) * int32 * US3 * string * string) []), v3 : (struct (US2 * obj * string) [])) : unit =
    let v4 : int32 = v2.Length
    let v5 : ((struct (US2 * obj * string) []) []) = Array.zeroCreate<(struct (US2 * obj * string) [])> (v4)
    let v6 : Mut6 = {l0 = 0} : Mut6
    while method20(v4, v6) do
        let v8 : int32 = v6.l0
        let struct (v9 : (US2 []), v10 : int32, v11 : US3, v12 : string, v13 : string) = v2.[int v8]
        let v14 : int32 = v9.Length
        let v15 : (struct (US2 * obj * string) []) = Array.zeroCreate<struct (US2 * obj * string)> (v14)
        let v16 : Mut6 = {l0 = 0} : Mut6
        while method20(v14, v16) do
            let v18 : int32 = v16.l0
            let v19 : US2 = v9.[int v18]
            let v20 : int32 = v3.Length
            let v21 : US19 = US19_0
            let v22 : Mut30 = {l0 = 0; l1 = v21} : Mut30
            while method93(v20, v22) do
                let v24 : int32 = v22.l0
                let v25 : int32 =  -v24
                let v26 : int32 = v25 + v20
                let v27 : int32 = v26 - 1
                let v28 : US19 = v22.l1
                let struct (v29 : US2, v30 : obj, v31 : string) = v3.[int v27]
                let v41 : US19 =
                    match v28 with
                    | US19_0 -> (* None *)
                        let v32 : bool =
                            match v29, v19 with
                            | US2_0, US2_0 -> (* GunJsClient *)
                                true
                            | US2_1, US2_1 -> (* GunRsClient *)
                                true
                            | US2_2, US2_2 -> (* Memory *)
                                true
                            | _ ->
                                false
                        let v34 : bool =
                            if v32 then
                                let v33 : bool = v31 = v12
                                v33
                            else
                                false
                        if v34 then
                            US19_1(v29, v30, v31)
                        else
                            US19_0
                    | US19_1(v38, v39, v40) -> (* Some *)
                        v28
                let v42 : int32 = v24 + 1
                v22.l0 <- v42
                v22.l1 <- v41
                ()
            let v43 : US19 = v22.l1
            let struct (v102 : US2, v103 : obj, v104 : string) =
                match v43 with
                | US19_0 -> (* None *)
                    let v44 : US20 = US20_0
                    let v45 : Mut31 = {l0 = 0; l1 = v44} : Mut31
                    while method94(v4, v45) do
                        let v47 : int32 = v45.l0
                        let v48 : int32 =  -v47
                        let v49 : int32 = v48 + v4
                        let v50 : int32 = v49 - 1
                        let v51 : US20 = v45.l1
                        let struct (v52 : (US2 []), v53 : int32, v54 : US3, v55 : string, v56 : string) = v2.[int v50]
                        let v66 : US20 =
                            match v51 with
                            | US20_0 -> (* None *)
                                let v57 : bool =
                                    match v54, v11 with
                                    | US3_0, US3_0 -> (* GunJsServer *)
                                        true
                                    | US3_1, US3_1 -> (* GunRsServer *)
                                        true
                                    | _ ->
                                        false
                                if v57 then
                                    US20_1(v52, v53, v54, v55, v56)
                                else
                                    US20_0
                            | US20_1(v61, v62, v63, v64, v65) -> (* Some *)
                                v51
                        let v67 : int32 = v47 + 1
                        v45.l0 <- v67
                        v45.l1 <- v66
                        ()
                    let v68 : US20 = v45.l1
                    let v76 : string =
                        match v68 with
                        | US20_0 -> (* None *)
                            let v69 : string = ""
                            v69
                        | US20_1(v70, v71, v72, v73, v74) -> (* Some *)
                            let v75 : string = $"{v73}:{v71}/{v74}"
                            v75
                    let v98 : obj =
                        match v19 with
                        | US2_0 -> (* GunJsClient *)
                            let v77 : string = "gun/gun"
                            let v78 : JS.Function = importDefault v77
                            let v79 : string = "gun/lib/radix"
                            importSideEffects v79
                            let v80 : string = "gun/lib/radisk"
                            importSideEffects v80
                            let v81 : string = "gun/lib/store"
                            importSideEffects v81
                            let v82 : string = "gun/lib/rindexed"
                            importSideEffects v82
                            let v83 : string = "url"
                            let v84 : (string * obj) = v83, v76
                            let v85 : string = "localStorage"
                            let v86 : (string * obj) = v85, false
                            let v87 : string = "radisk"
                            let v88 : (string * obj) = v87, true
                            let v89 : ((string * obj) []) = [|v84; v86; v88|]
                            let v90 : obj = createObj v89
                            let v91 : obj = createNew v78 v90
                            v91
                        | US2_1 -> (* GunRsClient *)
                            let v92 : string = "Node"
                            let v93 : string = "rusty-gun"
                            let v94 : JS.Function = import v92 v93
                            let v95 : obj = v76
                            let v96 : obj = createNew v94 v95
                            v96
                        | US2_2 -> (* Memory *)
                            failwith<obj> "new_db Memory"
                    struct (v19, v98, v76)
                | US19_1(v99, v100, v101) -> (* Some *)
                    struct (v99, v100, v101)
            v15.[int v18] <- struct (v102, v103, v104)
            let v105 : int32 = v18 + 1
            v16.l0 <- v105
            ()
        v5.[int v8] <- v15
        let v106 : int32 = v8 + 1
        v6.l0 <- v106
        ()
    let v107 : (struct (US2 * obj * string) []) = [||]
    let v108 : int32 = v5.Length
    let v109 : Mut32 = {l0 = 0; l1 = v107} : Mut32
    while method95(v108, v109) do
        let v111 : int32 = v109.l0
        let v112 : (struct (US2 * obj * string) []) = v109.l1
        let v113 : (struct (US2 * obj * string) []) = v5.[int v111]
        let v114 : int32 = v112.Length
        let v115 : int32 = v113.Length
        let v116 : int32 = v114 + v115
        let v117 : (struct (US2 * obj * string) []) = Array.zeroCreate<struct (US2 * obj * string)> (v116)
        let v118 : Mut6 = {l0 = 0} : Mut6
        while method20(v116, v118) do
            let v120 : int32 = v118.l0
            let v121 : bool = v120 < v114
            let struct (v129 : US2, v130 : obj, v131 : string) =
                if v121 then
                    let struct (v122 : US2, v123 : obj, v124 : string) = v112.[int v120]
                    struct (v122, v123, v124)
                else
                    let v125 : int32 = v120 - v114
                    let struct (v126 : US2, v127 : obj, v128 : string) = v113.[int v125]
                    struct (v126, v127, v128)
            v117.[int v120] <- struct (v129, v130, v131)
            let v132 : int32 = v120 + 1
            v118.l0 <- v132
            ()
        let v133 : int32 = v111 + 1
        v109.l0 <- v133
        v109.l1 <- v117
        ()
    let v134 : (struct (US2 * obj * string) []) = v109.l1
    let v135 : int32 = v3.Length
    let v136 : (struct (US2 * string) []) = Array.zeroCreate<struct (US2 * string)> (v135)
    let v137 : Mut6 = {l0 = 0} : Mut6
    while method20(v135, v137) do
        let v139 : int32 = v137.l0
        let struct (v140 : US2, v141 : obj, v142 : string) = v3.[int v139]
        v136.[int v139] <- struct (v140, v142)
        let v143 : int32 = v139 + 1
        v137.l0 <- v143
        ()
    let v144 : int32 = v134.Length
    let v145 : (struct (US2 * string) []) = Array.zeroCreate<struct (US2 * string)> (v144)
    let v146 : Mut6 = {l0 = 0} : Mut6
    while method20(v144, v146) do
        let v148 : int32 = v146.l0
        let struct (v149 : US2, v150 : obj, v151 : string) = v134.[int v148]
        v145.[int v148] <- struct (v149, v151)
        let v152 : int32 = v148 + 1
        v146.l0 <- v152
        ()
    let v153 : int32 = v136.Length
    let v154 : int32 = v145.Length
    let v155 : bool = v153 = v154
    let v156 : bool = v155 <> true
    let v159 : bool =
        if v156 then
            false
        else
            let v157 : int32 = 0
            method77(v136, v145, v157)
    let v160 : bool = v159 <> true
    if v160 then
        let v161 : US4 = US4_2
        let v162 : ((obj []) -> unit) = v1 v161
        let v163 : string = "> db_listener > effect"
        let v164 : obj = v163
        let v165 : string = "new_connections:"
        let v166 : obj = struct (v165, v134)
        let v167 : (obj []) = [|v164; v166|]
        v162 v167
        v0 v134
        ()
and closure373 (v0 : (unit -> (struct (US2 * obj * string) [])), v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v2 : (struct ((struct ((US2 []) * int32 * US3 * string * string) []) * (struct (US2 * obj * string) [])) -> unit)) () : unit =
    let v3 : (struct (US2 * obj * string) []) = v0 ()
    let v4 : (struct ((US2 []) * int32 * US3 * string * string) []) = v1 ()
    v2 struct (v4, v3)
    ()
and closure374 (v0 : (struct ((struct ((US2 []) * int32 * US3 * string * string) []) * (struct (US2 * obj * string) [])) -> unit)) () : unit =
    v0?clear ()
    ()
and method92 () : JSX.Element =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v138 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * obj * string) [])), v140 : ((struct (US2 * obj * string) []) -> unit), v141 : (unit -> (struct (int64 * obj) [])), v142 : ((struct (int64 * obj) []) -> unit), v143 : (unit -> (struct (int64 * obj) [])), v144 : ((struct (int64 * obj) []) -> unit), v145 : (unit -> (struct (int64 * int32) [])), v146 : ((struct (int64 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v274 : obj = emitJsExpr () "components_spi.state_context"
    let v275 : JS.Function = import v126 v127
    let struct (v276 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v277 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v278 : (unit -> int32), v279 : (int32 -> unit), v280 : (unit -> string), v281 : (string -> unit), v282 : (unit -> string), v283 : (string -> unit), v284 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v285 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v286 : (unit -> (struct (US2 * obj * string) [])), v287 : ((struct (US2 * obj * string) []) -> unit), v288 : (unit -> (struct (int64 * obj) [])), v289 : ((struct (int64 * obj) []) -> unit), v290 : (unit -> (struct (int64 * obj) [])), v291 : ((struct (int64 * obj) []) -> unit), v292 : (unit -> (struct (int64 * int32) [])), v293 : ((struct (int64 * int32) []) -> unit), v294 : (unit -> US4), v295 : (US4 -> unit), v296 : (unit -> US5), v297 : (US5 -> unit)) = v275.Invoke v274 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * obj) [])) * ((struct (int64 * obj) []) -> unit) * (unit -> (struct (int64 * int32) [])) * ((struct (int64 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v298 : (unit -> (obj [])) = closure371(v139, v284)
    let v299 : string = "#cf1100"
    let v300 : (US4 -> ((obj []) -> unit)) = method15(v298, v299)
    let v301 : US4 = US4_0
    let v302 : ((obj []) -> unit) = v300 v301
    let v303 : string = "> db_listener ()"
    let v304 : obj = v303
    let v305 : (obj []) = [|v304|]
    v302 v305
    let v306 : string = "debounce"
    let v307 : string = "@solid-primitives/scheduled"
    let v308 : JS.Function = import v306 v307
    let v309 : (struct ((struct ((US2 []) * int32 * US3 * string * string) []) * (struct (US2 * obj * string) [])) -> unit) = closure372(v140, v300)
    let v310 : (struct ((struct ((US2 []) * int32 * US3 * string * string) []) * (struct (US2 * obj * string) [])) -> unit) = v308.Invoke (v309, 300) |> unbox<struct ((struct ((US2 []) * int32 * US3 * string * string) []) * (struct (US2 * obj * string) [])) -> unit>
    let v311 : string = "createEffect"
    let v312 : JS.Function = import v311 v127
    let v313 : (unit -> unit) = closure373(v139, v284, v310)
    v312.Invoke v313 |> ignore
    let v314 : string = "onCleanup"
    let v315 : JS.Function = import v314 v127
    let v316 : (unit -> unit) = closure374(v310)
    v315.Invoke v316 |> ignore
    let v317 : JSX.Element = JS.undefined
    v317
and closure370 () (v0 : Mut2) : JSX.Element =
    method92()
and method96 () : (struct (US0 * string * string * string) []) =
    let v0 : US0 = US0_0
    let v1 : string = "4ZZJNAAPJGOUBHORYKX5DQSJJIMQLADNUIH7ONXZAVEZYZGOAM5CM7HV2M"
    let v2 : string = "poem slush dry adult final thunder price pause concert topic mesh wild dry gate judge celery winter list promote clump country loan move about faith"
    let v3 : string = "OBVzhzxAK4ZPdaF1QbkXsd8hgRUPJeCfYFjFghgMGnLmcpaAD0mdQJ3Rwq/RwklKGQWAbaIP9zb5BUmcZM4DOg=="
    let v4 : US1 = US1_1
    let v5 : US0 = US0_1(v4)
    let v6 : string = "Q2MAJEB7HYFK42KSN2MY26PL3P5P7HVIGR22GDAGCJQUARDEIM4WLHSIFQ"
    let v7 : string = "crater dove click normal kitten aisle obvious error exotic lunar guard impact donkey gun lamp divide announce match cement excess piano turn fish above make"
    let v8 : string = "lHFQVWKpvRYU00yAQqHOHJegn5nvP0owYkroBFKr94qGmASQPz4KrmlSbpmNeevb+v+eqDR1owwGEmFARGRDOQ=="
    let v9 : US1 = US1_0
    let v10 : US0 = US0_1(v9)
    let v11 : string = "KVGJONR4BETXZ3AS224T4MAJATTSTQGVO3VC3YAGSWAYBVD7KPR23RKNBI"
    let v12 : string = "key churn alert mother lock run lyrics category office lamp silver nut cement pistol fury hollow faculty feed capable announce index cloth faint about bid"
    let v13 : string = "0DNKDAK5QfWuMCTMNJ+Re5mSlc7rbI0q1UOUYDmvPGpVTJc2PAknfOwS1rk+MAkE5ynA1XbqLeAGlYGA1H9T4w=="
    let v14 : (struct (US0 * string * string * string) []) = [|struct (v0, v1, v2, v3); struct (v5, v6, v7, v8); struct (v10, v11, v12, v13)|]
    v14
and method97 () : int32 =
    4001
and method98 () : string =
    let v0 : string = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
    v0
and method99 () : string =
    let v0 : string = "http://localhost"
    v0
and closure375 () () : obj =
    let struct (v125 : string, v126 : obj, v127 : string, v128 : string, v129 : bool) = method2()
    let v130 : (struct (US0 * string * string * string) []) = method96()
    let v131 : int32 = v130.Length
    let v132 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) = Array.zeroCreate<struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit))> (v131)
    let v133 : Mut6 = {l0 = 0} : Mut6
    while method20(v131, v133) do
        let v135 : int32 = v133.l0
        let struct (v136 : US0, v137 : string, v138 : string, v139 : string) = v130.[int v135]
        let v140 : string = "createSignal"
        let v141 : string = "solid-js"
        let v142 : JS.Function = import v140 v141
        let v143 : (JS.Function []) = v142.Invoke v136 |> unbox<JS.Function[]>
        let v144 : (unit -> US0) = v143.[0] |> unbox
        let v145 : (US0 -> unit) = v143.[1] |> unbox
        let v146 : JS.Function = import v140 v141
        let v147 : (JS.Function []) = v146.Invoke v139 |> unbox<JS.Function[]>
        let v148 : (unit -> string) = v147.[0] |> unbox
        let v149 : (string -> unit) = v147.[1] |> unbox
        let v150 : JS.Function = import v140 v141
        let v151 : (JS.Function []) = v150.Invoke v137 |> unbox<JS.Function[]>
        let v152 : (unit -> string) = v151.[0] |> unbox
        let v153 : (string -> unit) = v151.[1] |> unbox
        let v154 : JS.Function = import v140 v141
        let v155 : (JS.Function []) = v154.Invoke v138 |> unbox<JS.Function[]>
        let v156 : (unit -> string) = v155.[0] |> unbox
        let v157 : (string -> unit) = v155.[1] |> unbox
        v132.[int v135] <- struct (v144, v145, v152, v153, v156, v157, v148, v149)
        let v158 : int32 = v135 + 1
        v133.l0 <- v158
        ()
    let v159 : string = "createSignal"
    let v160 : string = "solid-js"
    let v161 : JS.Function = import v159 v160
    let v162 : (JS.Function []) = v161.Invoke v132 |> unbox<JS.Function[]>
    let v163 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) = v162.[0] |> unbox
    let v164 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) = v162.[1] |> unbox
    let v165 : bool = "" = v125
    let v167 : int32 =
        if v165 then
            method97()
        else
            80
    let v168 : JS.Function = import v159 v160
    let v169 : (JS.Function []) = v168.Invoke v167 |> unbox<JS.Function[]>
    let v170 : (unit -> int32) = v169.[0] |> unbox
    let v171 : (int32 -> unit) = v169.[1] |> unbox
    let v172 : string = method98()
    let v173 : JS.Function = import v159 v160
    let v174 : (JS.Function []) = v173.Invoke v172 |> unbox<JS.Function[]>
    let v175 : (unit -> string) = v174.[0] |> unbox
    let v176 : (string -> unit) = v174.[1] |> unbox
    let v179 : string =
        if v165 then
            method99()
        else
            let v178 : string = $"http://{v125}-4001.githubpreview.dev"
            v178
    let v180 : JS.Function = import v159 v160
    let v181 : (JS.Function []) = v180.Invoke v179 |> unbox<JS.Function[]>
    let v182 : (unit -> string) = v181.[0] |> unbox
    let v183 : (string -> unit) = v181.[1] |> unbox
    let v184 : (struct (US2 * obj * string) []) = Array.zeroCreate<struct (US2 * obj * string)> (0)
    let v185 : JS.Function = import v159 v160
    let v186 : (JS.Function []) = v185.Invoke v184 |> unbox<JS.Function[]>
    let v187 : (unit -> (struct (US2 * obj * string) [])) = v186.[0] |> unbox
    let v188 : ((struct (US2 * obj * string) []) -> unit) = v186.[1] |> unbox
    let v194 : string =
        if v165 then
            let v189 : string = "ws://localhost"
            v189
        else
            let v190 : bool = true = v129
            if v190 then
                let v191 : string = "ws://localhost"
                v191
            else
                let v192 : string = $"ws://{v125}-4944.githubpreview.dev"
                v192
    let v199 : int32 =
        if v165 then
            let v195 : bool = true = v129
            if v195 then
                14944
            else
                let v196 : bool = false = v129
                if v196 then
                    4944
                else
                    80
        else
            80
    let v200 : (US2 []) = Array.zeroCreate<US2> (0)
    let v201 : US3 = US3_1
    let v202 : string = "ws"
    let v208 : string =
        if v165 then
            let v203 : string = "wss://localhost"
            v203
        else
            let v204 : bool = true = v129
            if v204 then
                let v205 : string = "wss://localhost"
                v205
            else
                let v206 : string = $"ws://{v125}-8765.githubpreview.dev"
                v206
    let v213 : int32 =
        if v165 then
            let v209 : bool = true = v129
            if v209 then
                18765
            else
                let v210 : bool = false = v129
                if v210 then
                    8765
                else
                    80
        else
            80
    let v214 : (US2 []) = Array.zeroCreate<US2> (0)
    let v215 : US3 = US3_0
    let v216 : string = "gun"
    let v217 : (struct ((US2 []) * int32 * US3 * string * string) []) = [|struct (v200, v199, v201, v194, v202); struct (v214, v213, v215, v208, v216)|]
    let v218 : JS.Function = import v159 v160
    let v219 : (JS.Function []) = v218.Invoke v217 |> unbox<JS.Function[]>
    let v220 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) = v219.[0] |> unbox
    let v221 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) = v219.[1] |> unbox
    let v222 : bool = "" = v127
    let v225 : US4 =
        if v222 then
            US4_0
        else
            US4_3
    let v226 : JS.Function = import v159 v160
    let v227 : (JS.Function []) = v226.Invoke v225 |> unbox<JS.Function[]>
    let v228 : (unit -> US4) = v227.[0] |> unbox
    let v229 : (US4 -> unit) = v227.[1] |> unbox
    let v230 : JS.Function = import v159 v160
    let v231 : US5 = US5_0
    let v232 : (JS.Function []) = v230.Invoke v231 |> unbox<JS.Function[]>
    let v233 : (unit -> US5) = v232.[0] |> unbox
    let v234 : (US5 -> unit) = v232.[1] |> unbox
    let v235 : (struct (int64 * int32) []) = Array.zeroCreate<struct (int64 * int32)> (0)
    let v236 : JS.Function = import v159 v160
    let v237 : (JS.Function []) = v236.Invoke v235 |> unbox<JS.Function[]>
    let v238 : (unit -> (struct (int64 * int32) [])) = v237.[0] |> unbox
    let v239 : ((struct (int64 * int32) []) -> unit) = v237.[1] |> unbox
    let v240 : (struct (int64 * obj) []) = Array.zeroCreate<struct (int64 * obj)> (0)
    let v241 : JS.Function = import v159 v160
    let v242 : (JS.Function []) = v241.Invoke v240 |> unbox<JS.Function[]>
    let v243 : (unit -> (struct (int64 * obj) [])) = v242.[0] |> unbox
    let v244 : ((struct (int64 * obj) []) -> unit) = v242.[1] |> unbox
    let v245 : (struct (int64 * obj) []) = Array.zeroCreate<struct (int64 * obj)> (0)
    let v246 : JS.Function = import v159 v160
    let v247 : (JS.Function []) = v246.Invoke v245 |> unbox<JS.Function[]>
    let v248 : (unit -> (struct (int64 * obj) [])) = v247.[0] |> unbox
    let v249 : ((struct (int64 * obj) []) -> unit) = v247.[1] |> unbox
    let v250 : obj = struct (v163, v164, v170, v171, v175, v176, v182, v183, v220, v221, v187, v188, v248, v249, v243, v244, v238, v239, v228, v229, v233, v234)
    v250
let v0 : obj = JS.undefined
let v1 : Mut0 = {l0 = v0} : Mut0
let v72 : obj = emitJsExpr () "process.env"
let v73 : string = "env"
let v74 : (string * obj) = v73, v72
let v75 : ((string * obj) []) = [|v74|]
let v76 : obj = createObj v75
Browser.Dom.window?components_spi <- v76
let v77 : int32 = Random().Next ()
let v203 : obj = method0()
let v204 : string = "content"
let v205 : (Mut1 -> JSX.Element) = closure1()
let v206 : (string * obj) = v204, v205
let v207 : string = "db_listener"
let v208 : (Mut2 -> JSX.Element) = closure370()
let v209 : (string * obj) = v207, v208
let v210 : string = "run_id"
let v211 : (string * obj) = v210, v77
let v212 : string = "new_state_context_any"
let v213 : (unit -> obj) = closure375()
let v214 : (string * obj) = v212, v213
let v215 : string = "state_context"
let v216 : (string * obj) = v215, v203
let v217 : ((string * obj) []) = [|v206; v209; v211; v214; v216; v74|]
let v218 : obj = createObj v217
Browser.Dom.window?components_spi <- v218
v1.l0 <- v218
()
