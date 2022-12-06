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
    | US2_3
and [<Struct>] US3 =
    | US3_0
    | US3_1
    | US3_2
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
    | US10_1 of f1_0 : (obj [])
and [<Struct>] US11 =
    | US11_0
    | US11_1 of f1_0 : JSX.Element
and [<Struct>] US12 =
    | US12_0
    | US12_1 of f1_0 : (obj -> unit)
and [<Struct>] US13 =
    | US13_0
    | US13_1 of f1_0 : (unit -> unit)
and [<Struct>] US14 =
    | US14_0
    | US14_1 of f1_0 : obj
and Mut1 = {mutable l0 : US6; mutable l1 : US6; mutable l2 : US6; mutable l3 : US7; mutable l4 : US6; mutable l5 : US6; mutable l6 : US6; mutable l7 : US6; mutable l8 : US6; mutable l9 : US6; mutable l10 : US8; mutable l11 : US9; mutable l12 : US6; mutable l13 : US6; mutable l14 : US8; mutable l15 : US6; mutable l16 : US6; mutable l17 : US6; mutable l18 : US10; mutable l19 : US8; mutable l20 : US6; mutable l21 : US6; mutable l22 : US6; mutable l23 : US6; mutable l24 : US6; mutable l25 : US6; mutable l26 : US11; mutable l27 : US6; mutable l28 : US6; mutable l29 : US6; mutable l30 : US11; mutable l31 : US6; mutable l32 : US6; mutable l33 : US6; mutable l34 : US6; mutable l35 : US6; mutable l36 : US6; mutable l37 : US6; mutable l38 : US6; mutable l39 : US6; mutable l40 : US6; mutable l41 : US12; mutable l42 : US13; mutable l43 : US12; mutable l44 : US6; mutable l45 : US6; mutable l46 : US6; mutable l47 : US6; mutable l48 : US6; mutable l49 : US6; mutable l50 : US6; mutable l51 : US6; mutable l52 : US6; mutable l53 : US6; mutable l54 : US6; mutable l55 : US6; mutable l56 : US6; mutable l57 : US6; mutable l58 : US6; mutable l59 : US6; mutable l60 : US14; mutable l61 : US6; mutable l62 : US11; mutable l63 : US6; mutable l64 : US6; mutable l65 : US14; mutable l66 : US14; mutable l67 : US6; mutable l68 : US5; mutable l69 : US6}
and Mut2() = class end
and UH0 =
    | UH0_0 of (string * obj) * UH0
    | UH0_1
and [<Struct>] US15 =
    | US15_0
    | US15_1
    | US15_2
and Mut3 = {mutable l0 : US13; mutable l1 : US13; mutable l2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)); mutable l3 : US15}
and Mut4 = {mutable l0 : (unit -> bool); mutable l1 : (bool -> unit); mutable l2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6))}
and Mut5 = {mutable l0 : bool; mutable l1 : bool; mutable l2 : US13; mutable l3 : US13; mutable l4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6))}
and Mut6 = {mutable l0 : int32}
and Mut7 = {mutable l0 : (unit -> JS.Function); mutable l1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)); mutable l2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6))}
and Mut8 = {mutable l0 : (string -> obj); mutable l1 : (unit -> struct ((unit -> string) * (string -> unit))); mutable l2 : string}
and Mut9 = {mutable l0 : (int32 -> obj); mutable l1 : (unit -> struct ((unit -> int32) * (int32 -> unit))); mutable l2 : string}
and Mut10 = {mutable l0 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit))); mutable l2 : string}
and Mut11 = {mutable l0 : ((struct (US2 * obj * string) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit))); mutable l2 : string}
and Mut12 = {mutable l0 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit))); mutable l2 : string}
and Mut13 = {mutable l0 : (US4 -> obj); mutable l1 : (unit -> struct ((unit -> US4) * (US4 -> unit))); mutable l2 : string}
and Mut14 = {mutable l0 : (US5 -> obj); mutable l1 : (unit -> struct ((unit -> US5) * (US5 -> unit))); mutable l2 : string}
and Mut15 = {mutable l0 : ((struct (Guid * int32) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit))); mutable l2 : string}
and Mut16 = {mutable l0 : ((struct (Guid * obj) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit))); mutable l2 : string}
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
    | US16_1 of f1_0 : US2 * f1_1 : Guid * f1_2 : int32
and [<Struct>] US17 =
    | US17_0
    | US17_1 of f1_0 : US2 * f1_1 : int64 * f1_2 : string
and Mut26 = {mutable l0 : int32; mutable l1 : US17}
and Mut27 = {mutable l0 : int32; mutable l1 : obj}
and UH1 =
    | UH1_0 of string
    | UH1_1 of string * string
    | UH1_2 of string * string
    | UH1_3 of string * string * string
and UH2 =
    | UH2_0 of Guid * int32 * UH2
    | UH2_1
and Mut28 = {mutable l0 : int32; mutable l1 : UH2}
and [<Struct>] US18 =
    | US18_0
    | US18_1 of f1_0 : US2 * f1_1 : Guid * f1_2 : (struct (Guid * obj) [])
and UH3 =
    | UH3_0 of Guid * obj * UH3
    | UH3_1
and Mut29 = {mutable l0 : int32; mutable l1 : UH3}
and [<Struct>] US19 =
    | US19_0
    | US19_1 of f1_0 : US2 * f1_1 : obj * f1_2 : string
and Mut30 = {mutable l0 : int32; mutable l1 : US19}
and [<Struct>] US20 =
    | US20_0
    | US20_1 of f1_0 : (US2 []) * f1_1 : int32 * f1_2 : US3 * f1_3 : string * f1_4 : string
and Mut31 = {mutable l0 : int32; mutable l1 : US20}
and Mut32 = {mutable l0 : int32; mutable l1 : (struct (US2 * obj * string) [])}
let rec closure0 () () : struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit)) =
    let struct (v0 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v1 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v2 : (unit -> int32), v3 : (int32 -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit), v8 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v9 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v10 : (unit -> (struct (US2 * obj * string) [])), v11 : ((struct (US2 * obj * string) []) -> unit), v12 : (unit -> (struct (Guid * obj) [])), v13 : ((struct (Guid * obj) []) -> unit), v14 : (unit -> (struct (Guid * obj) [])), v15 : ((struct (Guid * obj) []) -> unit), v16 : (unit -> (struct (Guid * int32) [])), v17 : ((struct (Guid * int32) []) -> unit), v18 : (unit -> US4), v19 : (US4 -> unit), v20 : (unit -> US5), v21 : (US5 -> unit)) = JS.undefined
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21)
and method0 () : obj =
    let v0 : string = "createContext"
    let v1 : string = "solid-js"
    let v2 : JS.Function = import v0 v1
    let v3 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))) = closure0()
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
and closure2 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "neutral.900"
    let v71 : US6 = US6_1(v70)
    let v72 : string = "neutral.400"
    let v73 : US6 = US6_1(v72)
    let v74 : string = "flex"
    let v75 : US6 = US6_1(v74)
    let v76 : string = "1"
    let v77 : US6 = US6_1(v76)
    let v78 : string = "column"
    let v79 : US6 = US6_1(v78)
    let v80 : string = "sm"
    let v81 : US6 = US6_1(v80)
    let v82 : string = "100vh"
    let v83 : US6 = US6_1(v82)
    let v84 : string = "100vw"
    let v85 : US6 = US6_1(v84)
    let v86 : string = "1px"
    let v87 : US6 = US6_1(v86)
    struct (v0, v1, v2, v3, v71, v5, v6, v7, v8, v9, v10, v11, v73, v13, v14, v15, v16, v75, v18, v19, v77, v79, v22, v81, v83, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v85, v39, v40, v41, v42, v43, v44, v45, v46, v47, v87, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure5 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "blackAlpha.900"
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
    struct (v0, v1, v2, v3, v71, v5, v6, v7, v8, v73, v10, v11, v12, v13, v14, v15, v16, v75, v18, v19, v20, v77, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v79, v81, v39, v40, v41, v42, v43, v44, v83, v46, v47, v48, v49, v50, v51, v52, v53, v85, v86, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v87, v69)
and closure8 (v0 : Mut1) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : US6 = v0.l46
    let v74 : string =
        match v71 with
        | US6_0 -> (* None *)
            let v72 : string = "hidden"
            v72
        | US6_1(v73) -> (* Some *)
            v73
    let v75 : US6 = v0.l47
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
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v80, v19, v20, v82, v84, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v85, v86, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure10 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "blackAlpha.700"
    let v71 : US6 = US6_1(v70)
    let v72 : string = "flex"
    let v73 : US6 = US6_1(v72)
    let v74 : string = "column"
    let v75 : US6 = US6_1(v74)
    let v76 : string = "-1px"
    let v77 : US6 = US6_1(v76)
    struct (v0, v1, v2, v3, v71, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v73, v18, v19, v20, v75, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v77, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure11 () () : (JSX.Element []) =
    [||]
and method6 () : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
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
    let v15 : US6 = US6_0
    let v16 : US6 = US6_0
    let v17 : US6 = US6_0
    let v18 : US10 = US10_0
    let v19 : US8 = US8_0
    let v20 : US6 = US6_0
    let v21 : US6 = US6_0
    let v22 : US6 = US6_0
    let v23 : US6 = US6_0
    let v24 : US6 = US6_0
    let v25 : US6 = US6_0
    let v26 : US11 = US11_0
    let v27 : US6 = US6_0
    let v28 : US6 = US6_0
    let v29 : US6 = US6_0
    let v30 : US11 = US11_0
    let v31 : US6 = US6_0
    let v32 : US6 = US6_0
    let v33 : US6 = US6_0
    let v34 : US6 = US6_0
    let v35 : US6 = US6_0
    let v36 : US6 = US6_0
    let v37 : US6 = US6_0
    let v38 : US6 = US6_0
    let v39 : US6 = US6_0
    let v40 : US6 = US6_0
    let v41 : US12 = US12_0
    let v42 : US13 = US13_0
    let v43 : US12 = US12_0
    let v44 : US6 = US6_0
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
    let v60 : US14 = US14_0
    let v61 : US6 = US6_0
    let v62 : US11 = US11_0
    let v63 : US6 = US6_0
    let v64 : US6 = US6_0
    let v65 : US14 = US14_0
    let v66 : US14 = US14_0
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
and method7 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : ((string * obj) []) =
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
        | US6_0 -> (* None *)
            let v207 : obj = ()
            v207
        | US6_1(v208) -> (* Some *)
            let v209 : obj = v208
            v209
    let v211 : bool = emitJsExpr v210 "!$0"
    let v215 : UH0 =
        if v211 then
            v206
        else
            let v212 : string = "defaultValue"
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
            let v221 : string = "direction"
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
            let v230 : string = "display"
            let v231 : (string * obj) = v230, v228
            UH0_0(v231, v224)
    let v237 : obj =
        match v18 with
        | US10_0 -> (* None *)
            let v234 : obj = ()
            v234
        | US10_1(v235) -> (* Some *)
            let v236 : obj = v235
            v236
    let v238 : bool = emitJsExpr v237 "!$0"
    let v242 : UH0 =
        if v238 then
            v233
        else
            let v239 : string = "each"
            let v240 : (string * obj) = v239, v237
            UH0_0(v240, v233)
    let v246 : obj =
        match v19 with
        | US8_0 -> (* None *)
            let v243 : obj = ()
            v243
        | US8_1(v244) -> (* Some *)
            let v245 : obj = v244
            v245
    let v247 : bool = emitJsExpr v246 "!$0"
    let v251 : UH0 =
        if v247 then
            v242
        else
            let v248 : string = "external"
            let v249 : (string * obj) = v248, v246
            UH0_0(v249, v242)
    let v255 : obj =
        match v20 with
        | US6_0 -> (* None *)
            let v252 : obj = ()
            v252
        | US6_1(v253) -> (* Some *)
            let v254 : obj = v253
            v254
    let v256 : bool = emitJsExpr v255 "!$0"
    let v260 : UH0 =
        if v256 then
            v251
        else
            let v257 : string = "flex"
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
            let v266 : string = "flexDirection"
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
            let v275 : string = "flexFlow"
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
            let v284 : string = "fontSize"
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
            let v293 : string = "height"
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
            let v302 : string = "href"
            let v303 : (string * obj) = v302, v300
            UH0_0(v303, v296)
    let v309 : obj =
        match v26 with
        | US11_0 -> (* None *)
            let v306 : obj = ()
            v306
        | US11_1(v307) -> (* Some *)
            let v308 : obj = v307
            v308
    let v310 : bool = emitJsExpr v309 "!$0"
    let v314 : UH0 =
        if v310 then
            v305
        else
            let v311 : string = "icon"
            let v312 : (string * obj) = v311, v309
            UH0_0(v312, v305)
    let v318 : obj =
        match v27 with
        | US6_0 -> (* None *)
            let v315 : obj = ()
            v315
        | US6_1(v316) -> (* Some *)
            let v317 : obj = v316
            v317
    let v319 : bool = emitJsExpr v318 "!$0"
    let v323 : UH0 =
        if v319 then
            v314
        else
            let v320 : string = "id"
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
            let v329 : string = "justifyContent"
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
            let v338 : string = "left"
            let v339 : (string * obj) = v338, v336
            UH0_0(v339, v332)
    let v345 : obj =
        match v30 with
        | US11_0 -> (* None *)
            let v342 : obj = ()
            v342
        | US11_1(v343) -> (* Some *)
            let v344 : obj = v343
            v344
    let v346 : bool = emitJsExpr v345 "!$0"
    let v350 : UH0 =
        if v346 then
            v341
        else
            let v347 : string = "leftIcon"
            let v348 : (string * obj) = v347, v345
            UH0_0(v348, v341)
    let v354 : obj =
        match v31 with
        | US6_0 -> (* None *)
            let v351 : obj = ()
            v351
        | US6_1(v352) -> (* Some *)
            let v353 : obj = v352
            v353
    let v355 : bool = emitJsExpr v354 "!$0"
    let v359 : UH0 =
        if v355 then
            v350
        else
            let v356 : string = "lineHeight"
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
            let v365 : string = "margin"
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
            let v374 : string = "marginBottom"
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
            let v383 : string = "marginLeft"
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
            let v392 : string = "marginRight"
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
            let v401 : string = "marginTop"
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
            let v410 : string = "maxHeight"
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
            let v419 : string = "maxWidth"
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
            let v428 : string = "minHeight"
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
            let v437 : string = "minWidth"
            let v438 : (string * obj) = v437, v435
            UH0_0(v438, v431)
    let v444 : obj =
        match v41 with
        | US12_0 -> (* None *)
            let v441 : obj = ()
            v441
        | US12_1(v442) -> (* Some *)
            let v443 : obj = v442
            v443
    let v445 : bool = emitJsExpr v444 "!$0"
    let v449 : UH0 =
        if v445 then
            v440
        else
            let v446 : string = "onChange"
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
            let v455 : string = "onClick"
            let v456 : (string * obj) = v455, v453
            UH0_0(v456, v449)
    let v462 : obj =
        match v43 with
        | US12_0 -> (* None *)
            let v459 : obj = ()
            v459
        | US12_1(v460) -> (* Some *)
            let v461 : obj = v460
            v461
    let v463 : bool = emitJsExpr v462 "!$0"
    let v467 : UH0 =
        if v463 then
            v458
        else
            let v464 : string = "onInput"
            let v465 : (string * obj) = v464, v462
            UH0_0(v465, v458)
    let v471 : obj =
        match v44 with
        | US6_0 -> (* None *)
            let v468 : obj = ()
            v468
        | US6_1(v469) -> (* Some *)
            let v470 : obj = v469
            v470
    let v472 : bool = emitJsExpr v471 "!$0"
    let v476 : UH0 =
        if v472 then
            v467
        else
            let v473 : string = "outline"
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
            let v482 : string = "overflow"
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
            let v491 : string = "overflowX"
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
            let v500 : string = "overflowY"
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
            let v509 : string = "padding"
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
            let v518 : string = "paddingBottom"
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
            let v527 : string = "paddingLeft"
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
            let v536 : string = "paddingRight"
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
            let v545 : string = "paddingTop"
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
            let v554 : string = "placeholder"
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
            let v563 : string = "position"
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
            let v572 : string = "right"
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
            let v581 : string = "size"
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
            let v590 : string = "spacing"
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
            let v599 : string = "src"
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
            let v608 : string = "striped"
            let v609 : (string * obj) = v608, v606
            UH0_0(v609, v602)
    let v615 : obj =
        match v60 with
        | US14_0 -> (* None *)
            let v612 : obj = ()
            v612
        | US14_1(v613) -> (* Some *)
            let v614 : obj = v613
            v614
    let v616 : bool = emitJsExpr v615 "!$0"
    let v620 : UH0 =
        if v616 then
            v611
        else
            let v617 : string = "sx"
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
        | US11_0 -> (* None *)
            let v630 : obj = ()
            v630
        | US11_1(v631) -> (* Some *)
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
        | US14_0 -> (* None *)
            let v657 : obj = ()
            v657
        | US14_1(v658) -> (* Some *)
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
        | US14_0 -> (* None *)
            let v666 : obj = ()
            v666
        | US14_1(v667) -> (* Some *)
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
and method5 (v0 : JS.Function, v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)), v2 : (unit -> (JSX.Element []))) : JSX.Element =
    let struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US6, v19 : US6, v20 : US6, v21 : US10, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US11, v30 : US6, v31 : US6, v32 : US6, v33 : US11, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US12, v45 : US13, v46 : US12, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US14, v64 : US6, v65 : US11, v66 : US6, v67 : US6, v68 : US14, v69 : US14, v70 : US6, v71 : US5, v72 : US6) = method6()
    let struct (v73 : US6, v74 : US6, v75 : US6, v76 : US7, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US6, v83 : US8, v84 : US9, v85 : US6, v86 : US6, v87 : US8, v88 : US6, v89 : US6, v90 : US6, v91 : US10, v92 : US8, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US6, v99 : US11, v100 : US6, v101 : US6, v102 : US6, v103 : US11, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US12, v115 : US13, v116 : US12, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US14, v134 : US6, v135 : US11, v136 : US6, v137 : US6, v138 : US14, v139 : US14, v140 : US6, v141 : US5, v142 : US6) = v1 struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
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
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/core"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?tbody
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure10()
    let v6 : US9 = v0.l11
    let v9 : (unit -> (JSX.Element [])) =
        match v6 with
        | US9_0 -> (* None *)
            closure11()
        | US9_1(v8) -> (* Some *)
            v8
    let v10 : JSX.Element = method5(v4, v5, v9)
    [|v10|]
and method4 (v0 : Mut1) : JSX.Element =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/core"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?table
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure8(v0)
    let v6 : (unit -> (JSX.Element [])) = closure9(v0)
    method5(v4, v5, v6)
and closure7 () (v0 : Mut1) : JSX.Element =
    method4(v0)
and closure12 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and method12 (v0 : bool) : struct ((unit -> bool) * (bool -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke v0 |> unbox<JS.Function[]>
    let v5 : (unit -> bool) = v4.[0] |> unbox<unit -> bool>
    let v6 : (bool -> unit) = v4.[1] |> unbox<bool -> unit>
    struct (v5, v6)
and method13 (v0 : string, v1 : string) : string =
    let v2 : string = {| ``@base`` = v1; ``@sm`` = v0 |} |> unbox<string>
    v2
and closure15 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) struct (v70 : US6, v71 : US6, v72 : US6, v73 : US7, v74 : US6, v75 : US6, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US8, v81 : US9, v82 : US6, v83 : US6, v84 : US8, v85 : US6, v86 : US6, v87 : US6, v88 : US10, v89 : US8, v90 : US6, v91 : US6, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US11, v97 : US6, v98 : US6, v99 : US6, v100 : US11, v101 : US6, v102 : US6, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US12, v112 : US13, v113 : US12, v114 : US6, v115 : US6, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US14, v131 : US6, v132 : US11, v133 : US6, v134 : US6, v135 : US14, v136 : US14, v137 : US6, v138 : US5, v139 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v140 : string = "column"
    let v141 : string = "row"
    let v142 : string = method13(v141, v140)
    let v143 : string = "neutral.500"
    let v144 : US6 = US6_1(v143)
    let v145 : string = "1px 1px"
    let v146 : US6 = US6_1(v145)
    let v147 : string = "flex"
    let v148 : US6 = US6_1(v147)
    let v149 : string = "1"
    let v150 : US6 = US6_1(v149)
    let v151 : US6 = US6_1(v142)
    struct (v70, v71, v72, v73, v74, v75, v76, v144, v146, v79, v80, v81, v82, v83, v84, v85, v86, v148, v88, v89, v150, v151, v92, v93, v94, v95, v96, v27, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139)
and closure17 (v0 : Mut3, v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6, v71 : (unit -> bool)) struct (v72 : US6, v73 : US6, v74 : US6, v75 : US7, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US8, v83 : US9, v84 : US6, v85 : US6, v86 : US8, v87 : US6, v88 : US6, v89 : US6, v90 : US10, v91 : US8, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US11, v99 : US6, v100 : US6, v101 : US6, v102 : US11, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US12, v114 : US13, v115 : US12, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US14, v133 : US6, v134 : US11, v135 : US6, v136 : US6, v137 : US14, v138 : US14, v139 : US6, v140 : US5, v141 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
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
            method13(v148, v147)
        else
            let v150 : string = "0px !important"
            v150
    let v154 : string =
        match v24 with
        | US6_0 -> (* None *)
            let v152 : string = "sm"
            v152
        | US6_1(v153) -> (* Some *)
            v153
    let v157 : string =
        match v52 with
        | US6_0 -> (* None *)
            let v155 : string = "0"
            v155
        | US6_1(v156) -> (* Some *)
            v156
    let v164 : string =
        match v51 with
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
    let v165 : string = method13(v164, v157)
    let v166 : US6 = US6_1(v151)
    let v167 : string = "neutral.500"
    let v168 : US6 = US6_1(v167)
    let v169 : string = "neutral.400"
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
    struct (v72, v73, v74, v75, v76, v77, v166, v168, v80, v81, v82, v83, v170, v85, v86, v87, v88, v172, v90, v91, v92, v174, v94, v175, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v177, v178, v179, v180, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141)
and closure19 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) struct (v70 : US6, v71 : US6, v72 : US6, v73 : US7, v74 : US6, v75 : US6, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US8, v81 : US9, v82 : US6, v83 : US6, v84 : US8, v85 : US6, v86 : US6, v87 : US6, v88 : US10, v89 : US8, v90 : US6, v91 : US6, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US11, v97 : US6, v98 : US6, v99 : US6, v100 : US11, v101 : US6, v102 : US6, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US12, v112 : US13, v113 : US12, v114 : US6, v115 : US6, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US14, v131 : US6, v132 : US11, v133 : US6, v134 : US6, v135 : US14, v136 : US14, v137 : US6, v138 : US5, v139 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v142 : string =
        match v52 with
        | US6_0 -> (* None *)
            let v140 : string = "4px"
            v140
        | US6_1(v141) -> (* Some *)
            v141
    let v145 : string =
        match v49 with
        | US6_0 -> (* None *)
            let v143 : string = "2px"
            v143
        | US6_1(v144) -> (* Some *)
            v144
    let v148 : string =
        match v50 with
        | US6_0 -> (* None *)
            let v146 : string = "8px"
            v146
        | US6_1(v147) -> (* Some *)
            v147
    let v149 : US6 = US6_1(v145)
    let v150 : US6 = US6_1(v148)
    let v151 : US6 = US6_1(v142)
    struct (v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v149, v150, v121, v151, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139)
and closure22 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "flex"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v71, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure25 (v0 : Mut4) (v1 : obj) : unit =
    let v2 : bool = v1?target?checked
    let v3 : (bool -> unit) = v0.l1
    v3 v2
    ()
and closure24 (v0 : Mut4, v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) struct (v71 : US6, v72 : US6, v73 : US6, v74 : US7, v75 : US6, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US8, v82 : US9, v83 : US6, v84 : US6, v85 : US8, v86 : US6, v87 : US6, v88 : US6, v89 : US10, v90 : US8, v91 : US6, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US11, v98 : US6, v99 : US6, v100 : US6, v101 : US11, v102 : US6, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US12, v113 : US13, v114 : US12, v115 : US6, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US14, v132 : US6, v133 : US11, v134 : US6, v135 : US6, v136 : US14, v137 : US14, v138 : US6, v139 : US5, v140 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v141 : (unit -> bool) = v0.l0
    let v142 : bool = v141 ()
    let v143 : US8 = US8_1(v142)
    let v144 : string = "neutral"
    let v145 : US6 = US6_1(v144)
    let v146 : (obj -> unit) = closure25(v0)
    let v147 : US12 = US12_1(v146)
    let v148 : string = "2px"
    let v149 : US6 = US6_1(v148)
    let v150 : string = "3px"
    let v151 : US6 = US6_1(v150)
    let v152 : string = "1px"
    let v153 : US6 = US6_1(v152)
    let v154 : string = "sm"
    let v155 : US6 = US6_1(v154)
    let v156 : string = "checkbox"
    let v157 : US6 = US6_1(v156)
    struct (v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v143, v82, v83, v145, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v28, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v147, v113, v114, v115, v116, v117, v118, v119, v149, v151, v122, v153, v124, v125, v126, v155, v128, v129, v130, v131, v132, v133, v134, v157, v136, v137, v138, v139, v140)
and closure26 () () : (JSX.Element []) =
    [||]
and closure28 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "1.5px"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v71, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure29 () () : (JSX.Element []) =
    [||]
and closure27 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) () : (JSX.Element []) =
    let v70 : string = "Box"
    let v71 : string = "@hope-ui/core"
    let v72 : JS.Function = import v70 v71
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure28()
    let v76 : (unit -> (JSX.Element [])) =
        match v11 with
        | US9_0 -> (* None *)
            closure29()
        | US9_1(v75) -> (* Some *)
            v75
    let v77 : JSX.Element = method5(v72, v73, v76)
    [|v77|]
and closure23 (v0 : Mut4, v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) () : (JSX.Element []) =
    let v71 : string = "hope"
    let v72 : string = "@hope-ui/core"
    let v73 : JS.Function = import v71 v72
    let v74 : JS.Function = v73?input
    let v75 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure24(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
    let v76 : (unit -> (JSX.Element [])) = closure26()
    let v77 : JSX.Element = method5(v74, v75, v76)
    let v78 : string = "&nbsp;"
    let v79 : JSX.Element = v78 |> unbox<JSX.Element>
    let v80 : JSX.Element = Html.fragment [ v79 ]
    let v81 : (unit -> (JSX.Element [])) = closure27(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
    let v82 : JSX.Element = v81 |> unbox<JSX.Element>
    [|v77; v80; v82|]
and closure21 () (v0 : Mut4) : JSX.Element =
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = v0.l2
    let struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) = method6()
    let struct (v72 : US6, v73 : US6, v74 : US6, v75 : US7, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US8, v83 : US9, v84 : US6, v85 : US6, v86 : US8, v87 : US6, v88 : US6, v89 : US6, v90 : US10, v91 : US8, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US11, v99 : US6, v100 : US6, v101 : US6, v102 : US11, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US12, v114 : US13, v115 : US12, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US14, v133 : US6, v134 : US11, v135 : US6, v136 : US6, v137 : US14, v138 : US14, v139 : US6, v140 : US5, v141 : US6) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
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
    let v150 : string = "Box"
    let v151 : string = "@hope-ui/core"
    let v152 : JS.Function = import v150 v151
    let v153 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure22()
    let v154 : (unit -> (JSX.Element [])) = closure23(v0, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141)
    method5(v152, v153, v154)
and closure31 (v0 : JSX.Element) () : (JSX.Element []) =
    [|v0|]
and closure30 (v0 : JSX.Element) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (unit -> (JSX.Element [])) = closure31(v0)
    let v72 : US9 = US9_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v72, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and method14 (v0 : (Mut4 -> JSX.Element), v1 : (unit -> bool), v2 : (bool -> unit), v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6))) : JSX.Element =
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
            let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure30(v3)
            method14(v5, v2, v1, v6)
        | US15_1 -> (* CheckEnabled *)
            let v8 : (Mut4 -> JSX.Element) = closure21()
            let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure30(v3)
            method14(v8, v2, v1, v9)
        | US15_2 -> (* CheckHidden *)
            v3
    [|v11|]
and closure18 (v0 : Mut3, v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6, v71 : (bool -> unit), v72 : (unit -> bool), v73 : JSX.Element) () : (JSX.Element []) =
    let v74 : string = "Box"
    let v75 : string = "@hope-ui/core"
    let v76 : JS.Function = import v74 v75
    let v77 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure19(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
    let v78 : (unit -> (JSX.Element [])) = closure20(v0, v71, v72, v73)
    let v79 : JSX.Element = method5(v76, v77, v78)
    [|v79|]
and closure32 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "0"
    let v71 : US6 = US6_1(v70)
    let v72 : string = "9px"
    let v73 : US6 = US6_1(v72)
    let v74 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v71, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v73, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v74, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure33 () () : (JSX.Element []) =
    let v0 : string = "&nbsp;"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure34 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) struct (v70 : US6, v71 : US6, v72 : US6, v73 : US7, v74 : US6, v75 : US6, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US8, v81 : US9, v82 : US6, v83 : US6, v84 : US8, v85 : US6, v86 : US6, v87 : US6, v88 : US10, v89 : US8, v90 : US6, v91 : US6, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US11, v97 : US6, v98 : US6, v99 : US6, v100 : US11, v101 : US6, v102 : US6, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US12, v112 : US13, v113 : US12, v114 : US6, v115 : US6, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US14, v131 : US6, v132 : US11, v133 : US6, v134 : US6, v135 : US14, v136 : US14, v137 : US6, v138 : US5, v139 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v142 : string =
        match v23 with
        | US6_0 -> (* None *)
            let v140 : string = "sm"
            v140
        | US6_1(v141) -> (* Some *)
            v141
    let v145 : string =
        match v28 with
        | US6_0 -> (* None *)
            let v143 : string = "center"
            v143
        | US6_1(v144) -> (* Some *)
            v144
    let v148 : string =
        match v34 with
        | US6_0 -> (* None *)
            let v146 : string = "0"
            v146
        | US6_1(v147) -> (* Some *)
            v147
    let v151 : string =
        match v33 with
        | US6_0 -> (* None *)
            let v149 : string = "0"
            v149
        | US6_1(v150) -> (* Some *)
            v150
    let v154 : string =
        match v48 with
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
    let v165 : string = "base"
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
    struct (v70, v71, v72, v73, v74, v156, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v158, v88, v89, v160, v162, v92, v163, v94, v95, v96, v97, v164, v99, v100, v166, v102, v167, v168, v169, v170, v172, v108, v109, v110, v111, v112, v113, v173, v175, v116, v117, v176, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139)
and closure37 (v0 : int32, v1 : (unit -> string), v2 : (unit -> US4), v3 : (unit -> US5)) () : (obj []) =
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
and method18 (v0 : int32, v1 : string) : string =
    let v2 : int32 = String.length v1
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : string = $"0{v1}"
        method18(v0, v4)
    else
        v1
and closure39 (v0 : (unit -> US4), v1 : (unit -> (obj [])), v2 : string, v3 : string, v4 : obj, v5 : string, v6 : string, v7 : bool, v8 : int64, v9 : US4) (v10 : (obj [])) : unit =
    let v11 : US4 = v0 ()
    let v12 : int32 = (fst (Reflection.FSharpValue.GetUnionFields(v11, typeof<US4>))).Tag
    let v13 : int32 = (fst (Reflection.FSharpValue.GetUnionFields(v9, typeof<US4>))).Tag
    let v14 : bool = v12 <= v13
    if v14 then
        let v15 : int64 = DateTime.UtcNow.Ticks
        let v16 : int64 = v15 - v8
        let v17 : string = v16.ToString ()
        let v18 : int32 = 6
        let v19 : string = method18(v18, v17)
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
and closure38 (v0 : (unit -> US4), v1 : (unit -> (obj [])), v2 : string, v3 : string, v4 : obj, v5 : string, v6 : string, v7 : bool, v8 : int64) (v9 : US4) : ((obj []) -> unit) =
    closure39(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9)
and method17 (v0 : (unit -> US4), v1 : (unit -> (obj [])), v2 : string) : (US4 -> ((obj []) -> unit)) =
    let struct (v3 : string, v4 : obj, v5 : string, v6 : string, v7 : bool) = method2()
    let v8 : int64 = DateTime.UtcNow.Ticks
    closure38(v0, v1, v2, v3, v4, v5, v6, v7, v8)
and method16 (v0 : (unit -> (obj [])), v1 : string) : (US4 -> ((obj []) -> unit)) =
    let v110 : obj = emitJsExpr () "components_spi.state_context"
    let v111 : string = "useContext"
    let v112 : string = "solid-js"
    let v113 : JS.Function = import v111 v112
    let struct (v114 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v115 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v116 : (unit -> int32), v117 : (int32 -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> string), v121 : (string -> unit), v122 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v123 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v124 : (unit -> (struct (US2 * obj * string) [])), v125 : ((struct (US2 * obj * string) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * obj) [])), v129 : ((struct (Guid * obj) []) -> unit), v130 : (unit -> (struct (Guid * int32) [])), v131 : ((struct (Guid * int32) []) -> unit), v132 : (unit -> US4), v133 : (US4 -> unit), v134 : (unit -> US5), v135 : (US5 -> unit)) = v113.Invoke v110 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    method17(v132, v0, v1)
and closure40 (v0 : Mut5, v1 : int32, v2 : (US5 -> unit)) () : unit =
    let v3 : bool = v0.l1
    if v3 then
        let v4 : US5 = US5_1(v1)
        v2 v4
        ()
and closure41 (v0 : (bool -> unit), v1 : (unit -> bool)) () : unit =
    let v2 : bool = v1 ()
    if v2 then
        v0 false
        ()
and closure42 (v0 : Mut5) () : unit =
    let v1 : US13 = v0.l3
    match v1 with
    | US13_0 -> (* None *)
        ()
    | US13_1(v2) -> (* Some *)
        v2 ()
        ()
and closure43 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) struct (v70 : US6, v71 : US6, v72 : US6, v73 : US7, v74 : US6, v75 : US6, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US8, v81 : US9, v82 : US6, v83 : US6, v84 : US8, v85 : US6, v86 : US6, v87 : US6, v88 : US10, v89 : US8, v90 : US6, v91 : US6, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US11, v97 : US6, v98 : US6, v99 : US6, v100 : US11, v101 : US6, v102 : US6, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US12, v112 : US13, v113 : US12, v114 : US6, v115 : US6, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US14, v131 : US6, v132 : US11, v133 : US6, v134 : US6, v135 : US14, v136 : US14, v137 : US6, v138 : US5, v139 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v140 : string = "flex"
    let v141 : US6 = US6_1(v140)
    let v142 : string = "1"
    let v143 : US6 = US6_1(v142)
    struct (v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v141, v88, v89, v143, v91, v92, v93, v94, v95, v96, v27, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139)
and closure45 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "3px 0"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v71, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and method21 (v0 : int32, v1 : Mut6) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method20 (v0 : Mut1, v1 : Mut1) : unit =
    let v2 : (string []) = JS.Constructors.Object.keys v0 |> unbox<string[]>
    let v3 : int32 = v2.Length
    let v4 : Mut6 = {l0 = 0} : Mut6
    while method21(v3, v4) do
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
and closure48 (v0 : Mut1) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let struct (v71 : US6, v72 : US6, v73 : US6, v74 : US7, v75 : US6, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US8, v82 : US9, v83 : US6, v84 : US6, v85 : US8, v86 : US6, v87 : US6, v88 : US6, v89 : US10, v90 : US8, v91 : US6, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US11, v98 : US6, v99 : US6, v100 : US6, v101 : US11, v102 : US6, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US12, v113 : US13, v114 : US12, v115 : US6, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US14, v132 : US6, v133 : US11, v134 : US6, v135 : US6, v136 : US14, v137 : US14, v138 : US6, v139 : US5, v140 : US6) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61, v0.l62, v0.l63, v0.l64, v0.l65, v0.l66, v0.l67, v0.l68, v0.l69
    let v141 : Mut1 = {l0 = v71; l1 = v72; l2 = v73; l3 = v74; l4 = v75; l5 = v76; l6 = v77; l7 = v78; l8 = v79; l9 = v80; l10 = v81; l11 = v82; l12 = v83; l13 = v84; l14 = v85; l15 = v86; l16 = v87; l17 = v88; l18 = v89; l19 = v90; l20 = v91; l21 = v92; l22 = v93; l23 = v94; l24 = v95; l25 = v96; l26 = v97; l27 = v98; l28 = v99; l29 = v100; l30 = v101; l31 = v102; l32 = v103; l33 = v104; l34 = v105; l35 = v106; l36 = v107; l37 = v108; l38 = v109; l39 = v110; l40 = v111; l41 = v112; l42 = v113; l43 = v114; l44 = v115; l45 = v116; l46 = v117; l47 = v118; l48 = v119; l49 = v120; l50 = v121; l51 = v122; l52 = v123; l53 = v124; l54 = v125; l55 = v126; l56 = v127; l57 = v128; l58 = v129; l59 = v130; l60 = v131; l61 = v132; l62 = v133; l63 = v134; l64 = v135; l65 = v136; l66 = v137; l67 = v138; l68 = v139; l69 = v140} : Mut1
    let v142 : string = "neutral"
    let v143 : US6 = US6_1(v142)
    let v144 : US8 = US8_1(true)
    let v145 : string = "left"
    let v146 : US6 = US6_1(v145)
    let v147 : string = "xs"
    let v148 : US6 = US6_1(v147)
    let v149 : Mut1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v143; l14 = v144; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v146; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v148; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63; l63 = v64; l64 = v65; l65 = v66; l66 = v67; l67 = v68; l68 = v69; l69 = v70} : Mut1
    method20(v149, v141)
    let struct (v150 : US6, v151 : US6, v152 : US6, v153 : US7, v154 : US6, v155 : US6, v156 : US6, v157 : US6, v158 : US6, v159 : US6, v160 : US8, v161 : US9, v162 : US6, v163 : US6, v164 : US8, v165 : US6, v166 : US6, v167 : US6, v168 : US10, v169 : US8, v170 : US6, v171 : US6, v172 : US6, v173 : US6, v174 : US6, v175 : US6, v176 : US11, v177 : US6, v178 : US6, v179 : US6, v180 : US11, v181 : US6, v182 : US6, v183 : US6, v184 : US6, v185 : US6, v186 : US6, v187 : US6, v188 : US6, v189 : US6, v190 : US6, v191 : US12, v192 : US13, v193 : US12, v194 : US6, v195 : US6, v196 : US6, v197 : US6, v198 : US6, v199 : US6, v200 : US6, v201 : US6, v202 : US6, v203 : US6, v204 : US6, v205 : US6, v206 : US6, v207 : US6, v208 : US6, v209 : US6, v210 : US14, v211 : US6, v212 : US11, v213 : US6, v214 : US6, v215 : US14, v216 : US14, v217 : US6, v218 : US5, v219 : US6) = v149.l0, v149.l1, v149.l2, v149.l3, v149.l4, v149.l5, v149.l6, v149.l7, v149.l8, v149.l9, v149.l10, v149.l11, v149.l12, v149.l13, v149.l14, v149.l15, v149.l16, v149.l17, v149.l18, v149.l19, v149.l20, v149.l21, v149.l22, v149.l23, v149.l24, v149.l25, v149.l26, v149.l27, v149.l28, v149.l29, v149.l30, v149.l31, v149.l32, v149.l33, v149.l34, v149.l35, v149.l36, v149.l37, v149.l38, v149.l39, v149.l40, v149.l41, v149.l42, v149.l43, v149.l44, v149.l45, v149.l46, v149.l47, v149.l48, v149.l49, v149.l50, v149.l51, v149.l52, v149.l53, v149.l54, v149.l55, v149.l56, v149.l57, v149.l58, v149.l59, v149.l60, v149.l61, v149.l62, v149.l63, v149.l64, v149.l65, v149.l66, v149.l67, v149.l68, v149.l69
    struct (v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219)
and closure49 () () : (JSX.Element []) =
    [||]
and method19 (v0 : Mut1) : JSX.Element =
    let v1 : string = "Button"
    let v2 : string = "@hope-ui/core"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure48(v0)
    let v5 : US9 = v0.l11
    let v8 : (unit -> (JSX.Element [])) =
        match v5 with
        | US9_0 -> (* None *)
            closure49()
        | US9_1(v7) -> (* Some *)
            v7
    method5(v3, v4, v8)
and closure47 () (v0 : Mut1) : JSX.Element =
    method19(v0)
and closure51 (v0 : (bool -> unit), v1 : Mut5) () : unit =
    let v2 : US13 = v1.l2
    match v2 with
    | US13_0 -> (* None *)
        ()
    | US13_1(v3) -> (* Some *)
        v3 ()
        ()
    v0 true
    ()
and closure50 (v0 : (bool -> unit), v1 : Mut5) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : (unit -> unit) = closure51(v0, v1)
    let v73 : US13 = US13_1(v72)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v73, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
and closure52 () () : (JSX.Element []) =
    let v0 : string = "Load"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and method22 (v0 : (Mut1 -> JSX.Element), v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)), v2 : (unit -> (JSX.Element []))) : JSX.Element =
    let struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US6, v19 : US6, v20 : US6, v21 : US10, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US11, v30 : US6, v31 : US6, v32 : US6, v33 : US11, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US12, v45 : US13, v46 : US12, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US14, v64 : US6, v65 : US11, v66 : US6, v67 : US6, v68 : US14, v69 : US14, v70 : US6, v71 : US5, v72 : US6) = method6()
    let struct (v73 : US6, v74 : US6, v75 : US6, v76 : US7, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US6, v83 : US8, v84 : US9, v85 : US6, v86 : US6, v87 : US8, v88 : US6, v89 : US6, v90 : US6, v91 : US10, v92 : US8, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US6, v99 : US11, v100 : US6, v101 : US6, v102 : US6, v103 : US11, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US12, v115 : US13, v116 : US12, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US14, v134 : US6, v135 : US11, v136 : US6, v137 : US6, v138 : US14, v139 : US14, v140 : US6, v141 : US5, v142 : US6) = v1 struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
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
and closure46 (v0 : (bool -> unit), v1 : Mut5) () : (JSX.Element []) =
    let v2 : (Mut1 -> JSX.Element) = closure47()
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure50(v0, v1)
    let v4 : (unit -> (JSX.Element [])) = closure52()
    let v5 : JSX.Element = method22(v2, v3, v4)
    [|v5|]
and closure53 (v0 : int32, v1 : (unit -> US5)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
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
            let v77 : string = "neutral.800"
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
    struct (v2, v3, v4, v5, v80, v7, v8, v9, v10, v89, v12, v13, v14, v15, v16, v17, v18, v135, v20, v21, v137, v23, v24, v25, v26, v27, v28, v29, v30, v98, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v107, v116, v58, v59, v60, v61, v62, v63, v64, v125, v66, v67, v68, v69, v133, v71)
and closure55 (v0 : (unit -> US5)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
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
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v79, v19, v20, v81, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v77, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure57 (v0 : int32, v1 : (unit -> US5)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
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
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v83, v81, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v85, v87, v58, v89, v60, v61, v62, v63, v64, v90, v66, v67, v68, v69, v91, v71)
and closure61 (v0 : Mut7) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (unit -> JS.Function) = v0.l0
    let v72 : JS.Function = v71 ()
    let struct (v73 : US6, v74 : US6, v75 : US6, v76 : US7, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US6, v83 : US8, v84 : US9, v85 : US6, v86 : US6, v87 : US8, v88 : US6, v89 : US6, v90 : US6, v91 : US10, v92 : US8, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US6, v99 : US11, v100 : US6, v101 : US6, v102 : US6, v103 : US11, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US12, v115 : US13, v116 : US12, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US14, v134 : US6, v135 : US11, v136 : US6, v137 : US6, v138 : US14, v139 : US14, v140 : US6, v141 : US5, v142 : US6) = method6()
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
    let v151 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = v0.l2
    let v152 : string = "-12px"
    let v153 : US6 = US6_1(v152)
    let v154 : US6 = US6_1(v152)
    let v155 : string = "0.6"
    let v156 : US6 = US6_1(v155)
    let struct (v157 : US6, v158 : US6, v159 : US6, v160 : US7, v161 : US6, v162 : US6, v163 : US6, v164 : US6, v165 : US6, v166 : US6, v167 : US8, v168 : US9, v169 : US6, v170 : US6, v171 : US8, v172 : US6, v173 : US6, v174 : US6, v175 : US10, v176 : US8, v177 : US6, v178 : US6, v179 : US6, v180 : US6, v181 : US6, v182 : US6, v183 : US11, v184 : US6, v185 : US6, v186 : US6, v187 : US11, v188 : US6, v189 : US6, v190 : US6, v191 : US6, v192 : US6, v193 : US6, v194 : US6, v195 : US6, v196 : US6, v197 : US6, v198 : US12, v199 : US13, v200 : US12, v201 : US6, v202 : US6, v203 : US6, v204 : US6, v205 : US6, v206 : US6, v207 : US6, v208 : US6, v209 : US6, v210 : US6, v211 : US6, v212 : US6, v213 : US6, v214 : US6, v215 : US6, v216 : US6, v217 : US14, v218 : US6, v219 : US11, v220 : US6, v221 : US6, v222 : US14, v223 : US14, v224 : US6, v225 : US5, v226 : US6) = v151 struct (v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v150, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v153, v108, v154, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v156)
    let v227 : ((string * obj) []) = method7(v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v220, v221, v222, v223, v224, v225, v226)
    let v228 : obj = createObj v227
    let v229 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = v0.l1
    let v230 : US7 = US7_1(v72)
    let v231 : string = "14px"
    let v232 : US6 = US6_1(v231)
    let v233 : US14 = US14_1(v228)
    let struct (v234 : US6, v235 : US6, v236 : US6, v237 : US7, v238 : US6, v239 : US6, v240 : US6, v241 : US6, v242 : US6, v243 : US6, v244 : US8, v245 : US9, v246 : US6, v247 : US6, v248 : US8, v249 : US6, v250 : US6, v251 : US6, v252 : US10, v253 : US8, v254 : US6, v255 : US6, v256 : US6, v257 : US6, v258 : US6, v259 : US6, v260 : US11, v261 : US6, v262 : US6, v263 : US6, v264 : US11, v265 : US6, v266 : US6, v267 : US6, v268 : US6, v269 : US6, v270 : US6, v271 : US6, v272 : US6, v273 : US6, v274 : US6, v275 : US12, v276 : US13, v277 : US12, v278 : US6, v279 : US6, v280 : US6, v281 : US6, v282 : US6, v283 : US6, v284 : US6, v285 : US6, v286 : US6, v287 : US6, v288 : US6, v289 : US6, v290 : US6, v291 : US6, v292 : US6, v293 : US6, v294 : US14, v295 : US6, v296 : US11, v297 : US6, v298 : US6, v299 : US14, v300 : US14, v301 : US6, v302 : US5, v303 : US6) = v229 struct (v1, v2, v3, v230, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v232, v58, v59, v60, v233, v62, v63, v64, v65, v66, v67, v68, v69, v70)
    struct (v234, v235, v236, v237, v238, v239, v240, v241, v242, v243, v244, v245, v246, v247, v248, v249, v250, v251, v252, v253, v254, v255, v256, v257, v258, v259, v260, v261, v262, v263, v264, v265, v266, v267, v268, v269, v270, v271, v272, v273, v274, v275, v276, v277, v278, v279, v280, v281, v282, v283, v284, v285, v286, v287, v288, v289, v290, v291, v292, v293, v294, v295, v296, v297, v298, v299, v300, v301, v302, v303)
and closure62 () () : (JSX.Element []) =
    [||]
and method23 (v0 : Mut7) : JSX.Element =
    let v1 : string = "Icon"
    let v2 : string = "@hope-ui/core"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure61(v0)
    let v5 : (unit -> (JSX.Element [])) = closure62()
    method5(v3, v4, v5)
and closure60 () (v0 : Mut7) : JSX.Element =
    method23(v0)
and closure63 () () : JS.Function =
    let v0 : string = "BiRegularRefresh"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and method24 (v0 : (Mut7 -> JSX.Element), v1 : (unit -> JS.Function), v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6))) : JSX.Element =
    let v3 : Mut7 = {l0 = v1; l1 = v2; l2 = v2} : Mut7
    let v4 : string = "createComponent"
    let v5 : string = "solid-js"
    let v6 : JS.Function = import v4 v5
    let v7 : JSX.Element = v6.Invoke (v0, v3) |> unbox<JSX.Element>
    v7
and closure64 (v0 : (bool -> unit)) () : unit =
    v0 true
    ()
and closure59 (v0 : (bool -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (Mut7 -> JSX.Element) = closure60()
    let v72 : (unit -> JS.Function) = closure63()
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v74 : JSX.Element = method24(v71, v72, v73)
    let v75 : string = "Refresh"
    let v76 : US6 = US6_1(v75)
    let v77 : string = "neutral"
    let v78 : US6 = US6_1(v77)
    let v79 : string = "20px"
    let v80 : US6 = US6_1(v79)
    let v81 : US11 = US11_1(v74)
    let v82 : (unit -> unit) = closure64(v0)
    let v83 : US13 = US13_1(v82)
    let v84 : string = "xs"
    let v85 : US6 = US6_1(v84)
    struct (v1, v2, v76, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v78, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v80, v26, v81, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v83, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v85, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure65 () () : (JSX.Element []) =
    [||]
and closure67 () () : JS.Function =
    let v0 : string = "BiRegularDownArrow"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure68 () () : JS.Function =
    let v0 : string = "BiRegularUpArrow"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure69 (v0 : int32, v1 : (US5 -> unit), v2 : (unit -> US5)) () : unit =
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
and closure66 (v0 : int32, v1 : (US5 -> unit), v2 : (unit -> US5)) struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US6, v19 : US6, v20 : US6, v21 : US10, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US11, v30 : US6, v31 : US6, v32 : US6, v33 : US11, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US12, v45 : US13, v46 : US12, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US14, v64 : US6, v65 : US11, v66 : US6, v67 : US6, v68 : US14, v69 : US14, v70 : US6, v71 : US5, v72 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
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
    let v81 : (Mut7 -> JSX.Element) = closure60()
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
            closure67()
        else
            closure68()
    let v90 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v91 : JSX.Element = method24(v81, v89, v90)
    let v92 : US6 = US6_1(v80)
    let v93 : string = "neutral"
    let v94 : US6 = US6_1(v93)
    let v95 : string = "20px"
    let v96 : US6 = US6_1(v95)
    let v97 : US11 = US11_1(v91)
    let v98 : (unit -> unit) = closure69(v0, v1, v2)
    let v99 : US13 = US13_1(v98)
    let v100 : string = "xs"
    let v101 : US6 = US6_1(v100)
    struct (v3, v4, v92, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v94, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v96, v28, v97, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v99, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v101, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
and closure70 () () : (JSX.Element []) =
    [||]
and closure72 () () : JS.Function =
    let v0 : string = "BiRegularUndo"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure73 (v0 : (bool -> unit), v1 : Mut5) () : unit =
    let v2 : US13 = v1.l3
    match v2 with
    | US13_0 -> (* None *)
        ()
    | US13_1(v3) -> (* Some *)
        v3 ()
        ()
    v0 false
    ()
and closure71 (v0 : (bool -> unit), v1 : Mut5) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : (Mut7 -> JSX.Element) = closure60()
    let v73 : (unit -> JS.Function) = closure72()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v75 : JSX.Element = method24(v72, v73, v74)
    let v76 : string = "Unload"
    let v77 : US6 = US6_1(v76)
    let v78 : string = "neutral"
    let v79 : US6 = US6_1(v78)
    let v80 : string = "20px"
    let v81 : US6 = US6_1(v80)
    let v82 : US11 = US11_1(v75)
    let v83 : (unit -> unit) = closure73(v0, v1)
    let v84 : US13 = US13_1(v83)
    let v85 : string = "xs"
    let v86 : US6 = US6_1(v85)
    struct (v2, v3, v77, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v79, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v81, v27, v82, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v84, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v86, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
and closure74 () () : (JSX.Element []) =
    [||]
and closure58 (v0 : int32, v1 : (US5 -> unit), v2 : (bool -> unit), v3 : (bool -> unit), v4 : Mut5, v5 : (unit -> US5)) () : (JSX.Element []) =
    let v6 : string = "IconButton"
    let v7 : string = "@hope-ui/core"
    let v8 : JS.Function = import v6 v7
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure59(v3)
    let v10 : (unit -> (JSX.Element [])) = closure65()
    let v11 : JSX.Element = method5(v8, v9, v10)
    let v12 : JS.Function = import v6 v7
    let v13 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure66(v0, v1, v5)
    let v14 : (unit -> (JSX.Element [])) = closure70()
    let v15 : JSX.Element = method5(v12, v13, v14)
    let v16 : JS.Function = import v6 v7
    let v17 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure71(v2, v4)
    let v18 : (unit -> (JSX.Element [])) = closure74()
    let v19 : JSX.Element = method5(v16, v17, v18)
    [|v11; v15; v19|]
and closure56 (v0 : int32, v1 : (US5 -> unit), v2 : (unit -> US5), v3 : (bool -> unit), v4 : (bool -> unit), v5 : (unit -> bool), v6 : Mut5, v7 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v8 : string = "Stack"
    let v9 : string = "@hope-ui/core"
    let v10 : JS.Function = import v8 v9
    let v11 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure57(v0, v2)
    let v12 : (unit -> (JSX.Element [])) = closure58(v0, v1, v3, v4, v6, v2)
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
and closure54 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6, v70 : int32, v71 : (US5 -> unit), v72 : (unit -> US5), v73 : (bool -> unit), v74 : (bool -> unit), v75 : (unit -> bool), v76 : Mut5) () : (JSX.Element []) =
    let v85 : JSX.Element =
        match v11 with
        | US9_0 -> (* None *)
            let v77 : JSX.Element = JS.undefined
            v77
        | US9_1(v78) -> (* Some *)
            let v79 : string = "Box"
            let v80 : string = "@hope-ui/core"
            let v81 : JS.Function = import v79 v80
            let v82 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure55(v72)
            let v83 : (unit -> (JSX.Element [])) = closure56(v70, v71, v72, v73, v74, v75, v76, v78)
            method5(v81, v82, v83)
    [|v85|]
and closure44 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6, v70 : int32, v71 : (US5 -> unit), v72 : (unit -> US5), v73 : (bool -> unit), v74 : (unit -> bool), v75 : (bool -> unit), v76 : (unit -> bool), v77 : Mut5) () : (JSX.Element []) =
    let v78 : bool = v74 ()
    let v79 : bool = v78 = false
    let v92 : JSX.Element =
        if v79 then
            let v80 : string = "Box"
            let v81 : string = "@hope-ui/core"
            let v82 : JS.Function = import v80 v81
            let v83 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure45()
            let v84 : (unit -> (JSX.Element [])) = closure46(v73, v77)
            method5(v82, v83, v84)
        else
            let v86 : string = "Box"
            let v87 : string = "@hope-ui/core"
            let v88 : JS.Function = import v86 v87
            let v89 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure53(v70, v72)
            let v90 : (unit -> (JSX.Element [])) = closure54(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v75, v76, v77)
            method5(v88, v89, v90)
    [|v92|]
and method15 (v0 : Mut5) : JSX.Element =
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = v0.l4
    let struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) = method6()
    let struct (v72 : US6, v73 : US6, v74 : US6, v75 : US7, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US8, v83 : US9, v84 : US6, v85 : US6, v86 : US8, v87 : US6, v88 : US6, v89 : US6, v90 : US10, v91 : US8, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US11, v99 : US6, v100 : US6, v101 : US6, v102 : US11, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US12, v114 : US13, v115 : US12, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US14, v133 : US6, v134 : US11, v135 : US6, v136 : US6, v137 : US14, v138 : US14, v139 : US6, v140 : US5, v141 : US6) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
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
    let v259 : obj = emitJsExpr () "components_spi.state_context"
    let v260 : string = "useContext"
    let v261 : string = "solid-js"
    let v262 : JS.Function = import v260 v261
    let struct (v263 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v264 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v265 : (unit -> int32), v266 : (int32 -> unit), v267 : (unit -> string), v268 : (string -> unit), v269 : (unit -> string), v270 : (string -> unit), v271 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v272 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v273 : (unit -> (struct (US2 * obj * string) [])), v274 : ((struct (US2 * obj * string) []) -> unit), v275 : (unit -> (struct (Guid * obj) [])), v276 : ((struct (Guid * obj) []) -> unit), v277 : (unit -> (struct (Guid * obj) [])), v278 : ((struct (Guid * obj) []) -> unit), v279 : (unit -> (struct (Guid * int32) [])), v280 : ((struct (Guid * int32) []) -> unit), v281 : (unit -> US4), v282 : (US4 -> unit), v283 : (unit -> US5), v284 : (US5 -> unit)) = v262.Invoke v259 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v393 : obj = emitJsExpr () "components_spi.state_context"
    let v394 : JS.Function = import v260 v261
    let struct (v395 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v396 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v397 : (unit -> int32), v398 : (int32 -> unit), v399 : (unit -> string), v400 : (string -> unit), v401 : (unit -> string), v402 : (string -> unit), v403 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v404 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v405 : (unit -> (struct (US2 * obj * string) [])), v406 : ((struct (US2 * obj * string) []) -> unit), v407 : (unit -> (struct (Guid * obj) [])), v408 : ((struct (Guid * obj) []) -> unit), v409 : (unit -> (struct (Guid * obj) [])), v410 : ((struct (Guid * obj) []) -> unit), v411 : (unit -> (struct (Guid * int32) [])), v412 : ((struct (Guid * int32) []) -> unit), v413 : (unit -> US4), v414 : (US4 -> unit), v415 : (unit -> US5), v416 : (US5 -> unit)) = v394.Invoke v393 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v525 : obj = emitJsExpr () "components_spi.state_context"
    let v526 : JS.Function = import v260 v261
    let struct (v527 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v528 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v529 : (unit -> int32), v530 : (int32 -> unit), v531 : (unit -> string), v532 : (string -> unit), v533 : (unit -> string), v534 : (string -> unit), v535 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v536 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v537 : (unit -> (struct (US2 * obj * string) [])), v538 : ((struct (US2 * obj * string) []) -> unit), v539 : (unit -> (struct (Guid * obj) [])), v540 : ((struct (Guid * obj) []) -> unit), v541 : (unit -> (struct (Guid * obj) [])), v542 : ((struct (Guid * obj) []) -> unit), v543 : (unit -> (struct (Guid * int32) [])), v544 : ((struct (Guid * int32) []) -> unit), v545 : (unit -> US4), v546 : (US4 -> unit), v547 : (unit -> US5), v548 : (US5 -> unit)) = v526.Invoke v525 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v549 : (unit -> (obj [])) = closure37(v150, v267, v413, v547)
    let v550 : string = "#de884c"
    let v551 : (US4 -> ((obj []) -> unit)) = method16(v549, v550)
    let v552 : US4 = US4_0
    let v553 : ((obj []) -> unit) = v551 v552
    let v554 : string = "> loader ()"
    let v555 : obj = v554
    let v556 : (obj []) = [|v555|]
    v553 v556
    let v557 : bool = v0.l0
    let struct (v558 : (unit -> bool), v559 : (bool -> unit)) = method12(v557)
    let v560 : bool = false
    let struct (v561 : (unit -> bool), v562 : (bool -> unit)) = method12(v560)
    let v563 : string = "createEffect"
    let v564 : JS.Function = import v563 v261
    let v565 : (unit -> unit) = closure40(v0, v150, v548)
    v564.Invoke v565 |> ignore
    let v566 : JS.Function = import v563 v261
    let v567 : (unit -> unit) = closure41(v562, v561)
    v566.Invoke v567 |> ignore
    let v568 : string = "onCleanup"
    let v569 : JS.Function = import v568 v261
    let v570 : (unit -> unit) = closure42(v0)
    v569.Invoke v570 |> ignore
    let v571 : bool = v0.l0
    let v572 : bool = v571 = true
    if v572 then
        let v573 : US13 = v0.l2
        match v573 with
        | US13_0 -> (* None *)
            ()
        | US13_1(v574) -> (* Some *)
            v574 ()
            ()
    let v575 : string = "Box"
    let v576 : string = "@hope-ui/core"
    let v577 : JS.Function = import v575 v576
    let v578 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure43(v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141)
    let v579 : (unit -> (JSX.Element [])) = closure44(v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v150, v548, v547, v559, v558, v562, v561, v0)
    method5(v577, v578, v579)
and closure36 () (v0 : Mut5) : JSX.Element =
    method15(v0)
and closure75 (v0 : (unit -> (JSX.Element []))) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : US9 = US9_1(v0)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v71, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and method25 (v0 : (Mut5 -> JSX.Element), v1 : bool, v2 : bool, v3 : US13, v4 : US13, v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6))) : JSX.Element =
    let v6 : Mut5 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5} : Mut5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v0, v6) |> unbox<JSX.Element>
    v10
and closure35 (v0 : Mut3, v1 : (unit -> bool), v2 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v3 : US15 = v0.l3
    let v25 : JSX.Element =
        match v3 with
        | US15_0 -> (* CheckDisabled *)
            let v4 : bool = v1 ()
            if v4 then
                let v5 : (Mut5 -> JSX.Element) = closure36()
                let v6 : US13 = v0.l0
                let v7 : US13 = v0.l1
                let v8 : bool = true
                let v9 : bool = false
                let v10 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure75(v2)
                method25(v5, v8, v9, v6, v7, v10)
            else
                let v12 : JSX.Element = JS.undefined
                v12
        | US15_1 -> (* CheckEnabled *)
            let v14 : bool = v1 ()
            if v14 then
                let v15 : (Mut5 -> JSX.Element) = closure36()
                let v16 : US13 = v0.l0
                let v17 : US13 = v0.l1
                let v18 : bool = true
                let v19 : bool = false
                let v20 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure75(v2)
                method25(v15, v18, v19, v16, v17, v20)
            else
                let v22 : JSX.Element = JS.undefined
                v22
        | US15_2 -> (* CheckHidden *)
            let v24 : JSX.Element = v2 |> unbox<JSX.Element>
            v24
    [|v25|]
and closure16 (v0 : Mut3, v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6, v71 : (bool -> unit), v72 : (unit -> bool)) () : (JSX.Element []) =
    let v82 : JSX.Element =
        match v63 with
        | US11_0 -> (* None *)
            let v73 : JSX.Element = JS.undefined
            v73
        | US11_1(v74) -> (* Some *)
            let v75 : string = "hope"
            let v76 : string = "@hope-ui/core"
            let v77 : JS.Function = import v75 v76
            let v78 : JS.Function = v77?td
            let v79 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure17(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v72)
            let v80 : (unit -> (JSX.Element [])) = closure18(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v74)
            method5(v78, v79, v80)
    let v98 : JSX.Element =
        match v12 with
        | US9_0 -> (* None *)
            let v83 : string = "hope"
            let v84 : string = "@hope-ui/core"
            let v85 : JS.Function = import v83 v84
            let v86 : JS.Function = v85?td
            let v87 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure32()
            let v88 : (unit -> (JSX.Element [])) = closure33()
            method5(v86, v87, v88)
        | US9_1(v90) -> (* Some *)
            let v91 : string = "hope"
            let v92 : string = "@hope-ui/core"
            let v93 : JS.Function = import v91 v92
            let v94 : JS.Function = v93?td
            let v95 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure34(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
            let v96 : (unit -> (JSX.Element [])) = closure35(v0, v72, v90)
            method5(v94, v95, v96)
    [|v82; v98|]
and method11 (v0 : Mut3) : JSX.Element =
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = v0.l2
    let struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) = method6()
    let struct (v72 : US6, v73 : US6, v74 : US6, v75 : US7, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US8, v83 : US9, v84 : US6, v85 : US6, v86 : US8, v87 : US6, v88 : US6, v89 : US6, v90 : US10, v91 : US8, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US11, v99 : US6, v100 : US6, v101 : US6, v102 : US11, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US12, v114 : US13, v115 : US12, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US14, v133 : US6, v134 : US11, v135 : US6, v136 : US6, v137 : US14, v138 : US14, v139 : US6, v140 : US5, v141 : US6) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
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
    let struct (v154 : (unit -> bool), v155 : (bool -> unit)) = method12(v153)
    let v156 : string = "hope"
    let v157 : string = "@hope-ui/core"
    let v158 : JS.Function = import v156 v157
    let v159 : JS.Function = v158?tr
    let v160 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure15(v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141)
    let v161 : (unit -> (JSX.Element [])) = closure16(v0, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v155, v154)
    method5(v159, v160, v161)
and closure14 () (v0 : Mut3) : JSX.Element =
    method11(v0)
and closure80 (v0 : (unit -> US4)) () : (JSX.Element []) =
    let v1 : US4 = v0 ()
    let v6 : string =
        match v1 with
        | US4_0 -> (* Debug *)
            let v2 : string = "Debug"
            v2
        | US4_1 -> (* Error *)
            let v3 : string = "Error"
            v3
        | US4_2 -> (* Info *)
            let v4 : string = "Info"
            v4
        | US4_3 -> (* Warn *)
            let v5 : string = "Warn"
            v5
    let v7 : JSX.Element = v6 |> unbox<JSX.Element>
    let v8 : JSX.Element = Html.fragment [ v7 ]
    [|v8|]
and closure79 (v0 : (unit -> US4)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : string = "Log Level"
    let v72 : JSX.Element = v71 |> unbox<JSX.Element>
    let v73 : JSX.Element = Html.fragment [ v72 ]
    let v74 : (unit -> (JSX.Element [])) = closure80(v0)
    let v75 : US9 = US9_1(v74)
    let v76 : US11 = US11_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v75, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v76, v64, v65, v66, v67, v68, v69, v70)
and method26 (v0 : (Mut3 -> JSX.Element), v1 : US13, v2 : US13, v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)), v4 : US15) : JSX.Element =
    let v5 : Mut3 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4} : Mut3
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v0, v5) |> unbox<JSX.Element>
    v9
and closure83 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "8px"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v71, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure88 (v0 : Mut8, v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : string = v1 ()
    let v3 : (string -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure87 (v0 : Mut8, v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure88(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure86 (v0 : Mut8, v1 : (unit -> string)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure87(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method27 (v0 : Mut8) : JSX.Element =
    let v1 : (unit -> struct ((unit -> string) * (string -> unit))) = v0.l1
    let struct (v2 : (unit -> string), v3 : (string -> unit)) = v1 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure86(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure85 () (v0 : Mut8) : JSX.Element =
    method27(v0)
and closure89 () (v0 : string) : obj =
    let v1 : obj = v0
    v1
and closure90 () () : struct ((unit -> string) * (string -> unit)) =
    let v108 : obj = emitJsExpr () "components_spi.state_context"
    let v109 : string = "useContext"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let struct (v112 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v113 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v114 : (unit -> int32), v115 : (int32 -> unit), v116 : (unit -> string), v117 : (string -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v121 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v122 : (unit -> (struct (US2 * obj * string) [])), v123 : ((struct (US2 * obj * string) []) -> unit), v124 : (unit -> (struct (Guid * obj) [])), v125 : ((struct (Guid * obj) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * int32) [])), v129 : ((struct (Guid * int32) []) -> unit), v130 : (unit -> US4), v131 : (US4 -> unit), v132 : (unit -> US5), v133 : (US5 -> unit)) = v111.Invoke v108 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v116, v117)
and method28 (v0 : (Mut8 -> JSX.Element), v1 : (string -> obj), v2 : (unit -> struct ((unit -> string) * (string -> unit))), v3 : string) : JSX.Element =
    let v4 : Mut8 = {l0 = v1; l1 = v2; l2 = v3} : Mut8
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure91 () () : struct ((unit -> string) * (string -> unit)) =
    let v108 : obj = emitJsExpr () "components_spi.state_context"
    let v109 : string = "useContext"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let struct (v112 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v113 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v114 : (unit -> int32), v115 : (int32 -> unit), v116 : (unit -> string), v117 : (string -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v121 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v122 : (unit -> (struct (US2 * obj * string) [])), v123 : ((struct (US2 * obj * string) []) -> unit), v124 : (unit -> (struct (Guid * obj) [])), v125 : ((struct (Guid * obj) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * int32) [])), v129 : ((struct (Guid * int32) []) -> unit), v130 : (unit -> US4), v131 : (US4 -> unit), v132 : (unit -> US5), v133 : (US5 -> unit)) = v111.Invoke v108 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v118, v119)
and closure95 (v0 : Mut9, v1 : (unit -> int32)) () : (JSX.Element []) =
    let v2 : int32 = v1 ()
    let v3 : (int32 -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure94 (v0 : Mut9, v1 : (unit -> int32)) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure95(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure93 (v0 : Mut9, v1 : (unit -> int32)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure94(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method29 (v0 : Mut9) : JSX.Element =
    let v1 : (unit -> struct ((unit -> int32) * (int32 -> unit))) = v0.l1
    let struct (v2 : (unit -> int32), v3 : (int32 -> unit)) = v1 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure93(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure92 () (v0 : Mut9) : JSX.Element =
    method29(v0)
and closure96 () (v0 : int32) : obj =
    let v1 : obj = v0
    v1
and closure97 () () : struct ((unit -> int32) * (int32 -> unit)) =
    let v108 : obj = emitJsExpr () "components_spi.state_context"
    let v109 : string = "useContext"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let struct (v112 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v113 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v114 : (unit -> int32), v115 : (int32 -> unit), v116 : (unit -> string), v117 : (string -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v121 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v122 : (unit -> (struct (US2 * obj * string) [])), v123 : ((struct (US2 * obj * string) []) -> unit), v124 : (unit -> (struct (Guid * obj) [])), v125 : ((struct (Guid * obj) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * int32) [])), v129 : ((struct (Guid * int32) []) -> unit), v130 : (unit -> US4), v131 : (US4 -> unit), v132 : (unit -> US5), v133 : (US5 -> unit)) = v111.Invoke v108 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v114, v115)
and method30 (v0 : (Mut9 -> JSX.Element), v1 : (int32 -> obj), v2 : (unit -> struct ((unit -> int32) * (int32 -> unit))), v3 : string) : JSX.Element =
    let v4 : Mut9 = {l0 = v1; l1 = v2; l2 = v3} : Mut9
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure101 (v0 : Mut10, v1 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []))) () : (JSX.Element []) =
    let v2 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) = v1 ()
    let v3 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure100 (v0 : Mut10, v1 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []))) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure101(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure99 (v0 : Mut10, v1 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure100(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method31 (v0 : Mut10) : JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v3 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit)) = v1 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure99(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure98 () (v0 : Mut10) : JSX.Element =
    method31(v0)
and closure102 () (v0 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) : obj =
    let v1 : int32 = v0.Length
    let v2 : (struct (US0 * string * string * string) []) = Array.zeroCreate<struct (US0 * string * string * string)> (v1)
    let v3 : Mut6 = {l0 = 0} : Mut6
    while method21(v1, v3) do
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
and closure103 () () : struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit)) =
    let v108 : obj = emitJsExpr () "components_spi.state_context"
    let v109 : string = "useContext"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let struct (v112 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v113 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v114 : (unit -> int32), v115 : (int32 -> unit), v116 : (unit -> string), v117 : (string -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v121 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v122 : (unit -> (struct (US2 * obj * string) [])), v123 : ((struct (US2 * obj * string) []) -> unit), v124 : (unit -> (struct (Guid * obj) [])), v125 : ((struct (Guid * obj) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * int32) [])), v129 : ((struct (Guid * int32) []) -> unit), v130 : (unit -> US4), v131 : (US4 -> unit), v132 : (unit -> US5), v133 : (US5 -> unit)) = v111.Invoke v108 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v112, v113)
and method32 (v0 : (Mut10 -> JSX.Element), v1 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> obj), v2 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit))), v3 : string) : JSX.Element =
    let v4 : Mut10 = {l0 = v1; l1 = v2; l2 = v3} : Mut10
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure107 (v0 : Mut11, v1 : (unit -> (struct (US2 * obj * string) []))) () : (JSX.Element []) =
    let v2 : (struct (US2 * obj * string) []) = v1 ()
    let v3 : ((struct (US2 * obj * string) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure106 (v0 : Mut11, v1 : (unit -> (struct (US2 * obj * string) []))) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure107(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure105 (v0 : Mut11, v1 : (unit -> (struct (US2 * obj * string) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure106(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method33 (v0 : Mut11) : JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct (US2 * obj * string) [])), v3 : ((struct (US2 * obj * string) []) -> unit)) = v1 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure105(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure104 () (v0 : Mut11) : JSX.Element =
    method33(v0)
and closure108 () (v0 : (struct (US2 * obj * string) [])) : obj =
    let v1 : obj = v0
    v1
and closure109 () () : struct ((unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit)) =
    let v108 : obj = emitJsExpr () "components_spi.state_context"
    let v109 : string = "useContext"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let struct (v112 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v113 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v114 : (unit -> int32), v115 : (int32 -> unit), v116 : (unit -> string), v117 : (string -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v121 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v122 : (unit -> (struct (US2 * obj * string) [])), v123 : ((struct (US2 * obj * string) []) -> unit), v124 : (unit -> (struct (Guid * obj) [])), v125 : ((struct (Guid * obj) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * int32) [])), v129 : ((struct (Guid * int32) []) -> unit), v130 : (unit -> US4), v131 : (US4 -> unit), v132 : (unit -> US5), v133 : (US5 -> unit)) = v111.Invoke v108 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v122, v123)
and method34 (v0 : (Mut11 -> JSX.Element), v1 : ((struct (US2 * obj * string) []) -> obj), v2 : (unit -> struct ((unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit))), v3 : string) : JSX.Element =
    let v4 : Mut11 = {l0 = v1; l1 = v2; l2 = v3} : Mut11
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure113 (v0 : Mut12, v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) () : (JSX.Element []) =
    let v2 : (struct ((US2 []) * int32 * US3 * string * string) []) = v1 ()
    let v3 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure112 (v0 : Mut12, v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure113(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure111 (v0 : Mut12, v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure112(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method35 (v0 : Mut12) : JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v3 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit)) = v1 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure111(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure110 () (v0 : Mut12) : JSX.Element =
    method35(v0)
and closure114 () (v0 : (struct ((US2 []) * int32 * US3 * string * string) [])) : obj =
    let v1 : obj = v0
    v1
and closure115 () () : struct ((unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit)) =
    let v108 : obj = emitJsExpr () "components_spi.state_context"
    let v109 : string = "useContext"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let struct (v112 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v113 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v114 : (unit -> int32), v115 : (int32 -> unit), v116 : (unit -> string), v117 : (string -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v121 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v122 : (unit -> (struct (US2 * obj * string) [])), v123 : ((struct (US2 * obj * string) []) -> unit), v124 : (unit -> (struct (Guid * obj) [])), v125 : ((struct (Guid * obj) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * int32) [])), v129 : ((struct (Guid * int32) []) -> unit), v130 : (unit -> US4), v131 : (US4 -> unit), v132 : (unit -> US5), v133 : (US5 -> unit)) = v111.Invoke v108 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v120, v121)
and method36 (v0 : (Mut12 -> JSX.Element), v1 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> obj), v2 : (unit -> struct ((unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit))), v3 : string) : JSX.Element =
    let v4 : Mut12 = {l0 = v1; l1 = v2; l2 = v3} : Mut12
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure119 (v0 : Mut13, v1 : (unit -> US4)) () : (JSX.Element []) =
    let v2 : US4 = v1 ()
    let v3 : (US4 -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure118 (v0 : Mut13, v1 : (unit -> US4)) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure119(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure117 (v0 : Mut13, v1 : (unit -> US4)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure118(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method37 (v0 : Mut13) : JSX.Element =
    let v1 : (unit -> struct ((unit -> US4) * (US4 -> unit))) = v0.l1
    let struct (v2 : (unit -> US4), v3 : (US4 -> unit)) = v1 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure117(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure116 () (v0 : Mut13) : JSX.Element =
    method37(v0)
and closure120 () (v0 : US4) : obj =
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
and closure121 () () : struct ((unit -> US4) * (US4 -> unit)) =
    let v108 : obj = emitJsExpr () "components_spi.state_context"
    let v109 : string = "useContext"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let struct (v112 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v113 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v114 : (unit -> int32), v115 : (int32 -> unit), v116 : (unit -> string), v117 : (string -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v121 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v122 : (unit -> (struct (US2 * obj * string) [])), v123 : ((struct (US2 * obj * string) []) -> unit), v124 : (unit -> (struct (Guid * obj) [])), v125 : ((struct (Guid * obj) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * int32) [])), v129 : ((struct (Guid * int32) []) -> unit), v130 : (unit -> US4), v131 : (US4 -> unit), v132 : (unit -> US5), v133 : (US5 -> unit)) = v111.Invoke v108 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v130, v131)
and method38 (v0 : (Mut13 -> JSX.Element), v1 : (US4 -> obj), v2 : (unit -> struct ((unit -> US4) * (US4 -> unit))), v3 : string) : JSX.Element =
    let v4 : Mut13 = {l0 = v1; l1 = v2; l2 = v3} : Mut13
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure125 (v0 : Mut14, v1 : (unit -> US5)) () : (JSX.Element []) =
    let v2 : US5 = v1 ()
    let v3 : (US5 -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure124 (v0 : Mut14, v1 : (unit -> US5)) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure125(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure123 (v0 : Mut14, v1 : (unit -> US5)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure124(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method39 (v0 : Mut14) : JSX.Element =
    let v1 : (unit -> struct ((unit -> US5) * (US5 -> unit))) = v0.l1
    let struct (v2 : (unit -> US5), v3 : (US5 -> unit)) = v1 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure123(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure122 () (v0 : Mut14) : JSX.Element =
    method39(v0)
and closure126 () (v0 : US5) : obj =
    let v1 : obj = v0
    v1
and closure127 () () : struct ((unit -> US5) * (US5 -> unit)) =
    let v108 : obj = emitJsExpr () "components_spi.state_context"
    let v109 : string = "useContext"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let struct (v112 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v113 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v114 : (unit -> int32), v115 : (int32 -> unit), v116 : (unit -> string), v117 : (string -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v121 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v122 : (unit -> (struct (US2 * obj * string) [])), v123 : ((struct (US2 * obj * string) []) -> unit), v124 : (unit -> (struct (Guid * obj) [])), v125 : ((struct (Guid * obj) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * int32) [])), v129 : ((struct (Guid * int32) []) -> unit), v130 : (unit -> US4), v131 : (US4 -> unit), v132 : (unit -> US5), v133 : (US5 -> unit)) = v111.Invoke v108 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v132, v133)
and method40 (v0 : (Mut14 -> JSX.Element), v1 : (US5 -> obj), v2 : (unit -> struct ((unit -> US5) * (US5 -> unit))), v3 : string) : JSX.Element =
    let v4 : Mut14 = {l0 = v1; l1 = v2; l2 = v3} : Mut14
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure131 (v0 : Mut15, v1 : (unit -> (struct (Guid * int32) []))) () : (JSX.Element []) =
    let v2 : (struct (Guid * int32) []) = v1 ()
    let v3 : ((struct (Guid * int32) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure130 (v0 : Mut15, v1 : (unit -> (struct (Guid * int32) []))) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure131(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure129 (v0 : Mut15, v1 : (unit -> (struct (Guid * int32) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure130(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method41 (v0 : Mut15) : JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct (Guid * int32) [])), v3 : ((struct (Guid * int32) []) -> unit)) = v1 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure129(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure128 () (v0 : Mut15) : JSX.Element =
    method41(v0)
and closure132 () (v0 : (struct (Guid * int32) [])) : obj =
    let v1 : obj = v0
    v1
and closure133 () () : struct ((unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit)) =
    let v108 : obj = emitJsExpr () "components_spi.state_context"
    let v109 : string = "useContext"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let struct (v112 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v113 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v114 : (unit -> int32), v115 : (int32 -> unit), v116 : (unit -> string), v117 : (string -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v121 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v122 : (unit -> (struct (US2 * obj * string) [])), v123 : ((struct (US2 * obj * string) []) -> unit), v124 : (unit -> (struct (Guid * obj) [])), v125 : ((struct (Guid * obj) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * int32) [])), v129 : ((struct (Guid * int32) []) -> unit), v130 : (unit -> US4), v131 : (US4 -> unit), v132 : (unit -> US5), v133 : (US5 -> unit)) = v111.Invoke v108 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v128, v129)
and method42 (v0 : (Mut15 -> JSX.Element), v1 : ((struct (Guid * int32) []) -> obj), v2 : (unit -> struct ((unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit))), v3 : string) : JSX.Element =
    let v4 : Mut15 = {l0 = v1; l1 = v2; l2 = v3} : Mut15
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure137 (v0 : Mut16, v1 : (unit -> (struct (Guid * obj) []))) () : (JSX.Element []) =
    let v2 : (struct (Guid * obj) []) = v1 ()
    let v3 : ((struct (Guid * obj) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure136 (v0 : Mut16, v1 : (unit -> (struct (Guid * obj) []))) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure137(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure135 (v0 : Mut16, v1 : (unit -> (struct (Guid * obj) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure136(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method43 (v0 : Mut16) : JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct (Guid * obj) [])), v3 : ((struct (Guid * obj) []) -> unit)) = v1 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure135(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure134 () (v0 : Mut16) : JSX.Element =
    method43(v0)
and closure138 () (v0 : (struct (Guid * obj) [])) : obj =
    let v1 : obj = v0
    v1
and closure139 () () : struct ((unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit)) =
    let v108 : obj = emitJsExpr () "components_spi.state_context"
    let v109 : string = "useContext"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let struct (v112 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v113 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v114 : (unit -> int32), v115 : (int32 -> unit), v116 : (unit -> string), v117 : (string -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v121 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v122 : (unit -> (struct (US2 * obj * string) [])), v123 : ((struct (US2 * obj * string) []) -> unit), v124 : (unit -> (struct (Guid * obj) [])), v125 : ((struct (Guid * obj) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * int32) [])), v129 : ((struct (Guid * int32) []) -> unit), v130 : (unit -> US4), v131 : (US4 -> unit), v132 : (unit -> US5), v133 : (US5 -> unit)) = v111.Invoke v108 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v126, v127)
and method44 (v0 : (Mut16 -> JSX.Element), v1 : ((struct (Guid * obj) []) -> obj), v2 : (unit -> struct ((unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit))), v3 : string) : JSX.Element =
    let v4 : Mut16 = {l0 = v1; l1 = v2; l2 = v3} : Mut16
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure140 () () : struct ((unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit)) =
    let v108 : obj = emitJsExpr () "components_spi.state_context"
    let v109 : string = "useContext"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let struct (v112 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v113 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v114 : (unit -> int32), v115 : (int32 -> unit), v116 : (unit -> string), v117 : (string -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v121 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v122 : (unit -> (struct (US2 * obj * string) [])), v123 : ((struct (US2 * obj * string) []) -> unit), v124 : (unit -> (struct (Guid * obj) [])), v125 : ((struct (Guid * obj) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * int32) [])), v129 : ((struct (Guid * int32) []) -> unit), v130 : (unit -> US4), v131 : (US4 -> unit), v132 : (unit -> US5), v133 : (US5 -> unit)) = v111.Invoke v108 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v124, v125)
and closure84 () () : (JSX.Element []) =
    let v0 : (Mut8 -> JSX.Element) = closure85()
    let v1 : (string -> obj) = closure89()
    let v2 : (unit -> struct ((unit -> string) * (string -> unit))) = closure90()
    let v3 : string = "chain.token"
    let v4 : JSX.Element = method28(v0, v1, v2, v3)
    let v5 : (unit -> struct ((unit -> string) * (string -> unit))) = closure91()
    let v6 : string = "chain.url"
    let v7 : JSX.Element = method28(v0, v1, v5, v6)
    let v8 : (Mut9 -> JSX.Element) = closure92()
    let v9 : (int32 -> obj) = closure96()
    let v10 : (unit -> struct ((unit -> int32) * (int32 -> unit))) = closure97()
    let v11 : string = "chain.port"
    let v12 : JSX.Element = method30(v8, v9, v10, v11)
    let v13 : (Mut10 -> JSX.Element) = closure98()
    let v14 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> obj) = closure102()
    let v15 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit))) = closure103()
    let v16 : string = "chain.accounts"
    let v17 : JSX.Element = method32(v13, v14, v15, v16)
    let v18 : (Mut11 -> JSX.Element) = closure104()
    let v19 : ((struct (US2 * obj * string) []) -> obj) = closure108()
    let v20 : (unit -> struct ((unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit))) = closure109()
    let v21 : string = "db.connections"
    let v22 : JSX.Element = method34(v18, v19, v20, v21)
    let v23 : (Mut12 -> JSX.Element) = closure110()
    let v24 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> obj) = closure114()
    let v25 : (unit -> struct ((unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit))) = closure115()
    let v26 : string = "db.connection_options"
    let v27 : JSX.Element = method36(v23, v24, v25, v26)
    let v28 : (Mut13 -> JSX.Element) = closure116()
    let v29 : (US4 -> obj) = closure120()
    let v30 : (unit -> struct ((unit -> US4) * (US4 -> unit))) = closure121()
    let v31 : string = "settings.log_level"
    let v32 : JSX.Element = method38(v28, v29, v30, v31)
    let v33 : (Mut14 -> JSX.Element) = closure122()
    let v34 : (US5 -> obj) = closure126()
    let v35 : (unit -> struct ((unit -> US5) * (US5 -> unit))) = closure127()
    let v36 : string = "settings.ui.modal"
    let v37 : JSX.Element = method40(v33, v34, v35, v36)
    let v38 : (Mut15 -> JSX.Element) = closure128()
    let v39 : ((struct (Guid * int32) []) -> obj) = closure132()
    let v40 : (unit -> struct ((unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit))) = closure133()
    let v41 : string = "profile.tmp.counter"
    let v42 : JSX.Element = method42(v38, v39, v40, v41)
    let v43 : (Mut16 -> JSX.Element) = closure134()
    let v44 : ((struct (Guid * obj) []) -> obj) = closure138()
    let v45 : (unit -> struct ((unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit))) = closure139()
    let v46 : string = "profile.tmp.chain_status"
    let v47 : JSX.Element = method44(v43, v44, v45, v46)
    let v48 : (unit -> struct ((unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit))) = closure140()
    let v49 : string = "profile.tmp.chain_deploy"
    let v50 : JSX.Element = method44(v43, v44, v48, v49)
    [|v4; v7; v12; v17; v22; v27; v32; v37; v42; v47; v50|]
and closure82 () () : (JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/core"
    let v2 : JS.Function = import v0 v1
    let v3 : JS.Function = v2?pre
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure83()
    let v5 : (unit -> (JSX.Element [])) = closure84()
    let v6 : JSX.Element = method5(v3, v4, v5)
    [|v6|]
and closure81 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "State"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure82()
    let v74 : US9 = US9_1(v73)
    let v75 : string = "flex-start"
    let v76 : US6 = US6_1(v75)
    let v77 : US11 = US11_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v76, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v77, v63, v64, v65, v66, v67, v68, v69)
and closure78 (v0 : (unit -> US4)) () : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure14()
    let v2 : US13 = US13_0
    let v3 : US13 = US13_0
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure79(v0)
    let v5 : US15 = US15_2
    let v6 : JSX.Element = method26(v1, v2, v3, v4, v5)
    let v7 : US13 = US13_0
    let v8 : US13 = US13_0
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure81()
    let v10 : US15 = US15_2
    let v11 : JSX.Element = method26(v1, v7, v8, v9, v10)
    [|v6; v11|]
and closure77 (v0 : (unit -> US4)) () : (JSX.Element []) =
    let v1 : (Mut1 -> JSX.Element) = closure7()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v3 : (unit -> (JSX.Element [])) = closure78(v0)
    let v4 : JSX.Element = method22(v1, v2, v3)
    [|v4|]
and closure76 (v0 : (unit -> US4)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : string = "Debug"
    let v72 : JSX.Element = v71 |> unbox<JSX.Element>
    let v73 : JSX.Element = Html.fragment [ v72 ]
    let v74 : (unit -> (JSX.Element [])) = closure77(v0)
    let v75 : US9 = US9_1(v74)
    let v76 : string = "flex-start"
    let v77 : US6 = US6_1(v76)
    let v78 : string = "15px"
    let v79 : US6 = US6_1(v78)
    let v80 : US11 = US11_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v75, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v77, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v79, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v80, v64, v65, v66, v67, v68, v69, v70)
and closure13 (v0 : (unit -> US4)) () : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure14()
    let v2 : US13 = US13_0
    let v3 : US13 = US13_0
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure76(v0)
    let v5 : US15 = US15_0
    let v6 : JSX.Element = method26(v1, v2, v3, v4, v5)
    [|v6|]
and closure6 (v0 : (unit -> US4)) () : (JSX.Element []) =
    let v1 : (Mut1 -> JSX.Element) = closure7()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v3 : (unit -> (JSX.Element [])) = closure13(v0)
    let v4 : JSX.Element = method22(v1, v2, v3)
    [|v4|]
and method3 () : JSX.Element =
    let v108 : obj = emitJsExpr () "components_spi.state_context"
    let v109 : string = "useContext"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let struct (v112 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v113 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v114 : (unit -> int32), v115 : (int32 -> unit), v116 : (unit -> string), v117 : (string -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v121 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v122 : (unit -> (struct (US2 * obj * string) [])), v123 : ((struct (US2 * obj * string) []) -> unit), v124 : (unit -> (struct (Guid * obj) [])), v125 : ((struct (Guid * obj) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * int32) [])), v129 : ((struct (Guid * int32) []) -> unit), v130 : (unit -> US4), v131 : (US4 -> unit), v132 : (unit -> US5), v133 : (US5 -> unit)) = v111.Invoke v108 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v134 : string = "Box"
    let v135 : string = "@hope-ui/core"
    let v136 : JS.Function = import v134 v135
    let v137 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure5()
    let v138 : (unit -> (JSX.Element [])) = closure6(v130)
    method5(v136, v137, v138)
and closure4 () (v0 : Mut2) : JSX.Element =
    method3()
and method45 (v0 : (Mut2 -> JSX.Element)) : JSX.Element =
    let v1 : Mut2 = Mut2()
    let v2 : string = "createComponent"
    let v3 : string = "solid-js"
    let v4 : JS.Function = import v2 v3
    let v5 : JSX.Element = v4.Invoke (v0, v1) |> unbox<JSX.Element>
    v5
and closure141 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
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
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v71, v18, v19, v73, v75, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v77, v79, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure151 (v0 : Mut1) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let struct (v71 : US6, v72 : US6, v73 : US6, v74 : US7, v75 : US6, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US8, v82 : US9, v83 : US6, v84 : US6, v85 : US8, v86 : US6, v87 : US6, v88 : US6, v89 : US10, v90 : US8, v91 : US6, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US11, v98 : US6, v99 : US6, v100 : US6, v101 : US11, v102 : US6, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US12, v113 : US13, v114 : US12, v115 : US6, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US14, v132 : US6, v133 : US11, v134 : US6, v135 : US6, v136 : US14, v137 : US14, v138 : US6, v139 : US5, v140 : US6) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61, v0.l62, v0.l63, v0.l64, v0.l65, v0.l66, v0.l67, v0.l68, v0.l69
    let v141 : Mut1 = {l0 = v71; l1 = v72; l2 = v73; l3 = v74; l4 = v75; l5 = v76; l6 = v77; l7 = v78; l8 = v79; l9 = v80; l10 = v81; l11 = v82; l12 = v83; l13 = v84; l14 = v85; l15 = v86; l16 = v87; l17 = v88; l18 = v89; l19 = v90; l20 = v91; l21 = v92; l22 = v93; l23 = v94; l24 = v95; l25 = v96; l26 = v97; l27 = v98; l28 = v99; l29 = v100; l30 = v101; l31 = v102; l32 = v103; l33 = v104; l34 = v105; l35 = v106; l36 = v107; l37 = v108; l38 = v109; l39 = v110; l40 = v111; l41 = v112; l42 = v113; l43 = v114; l44 = v115; l45 = v116; l46 = v117; l47 = v118; l48 = v119; l49 = v120; l50 = v121; l51 = v122; l52 = v123; l53 = v124; l54 = v125; l55 = v126; l56 = v127; l57 = v128; l58 = v129; l59 = v130; l60 = v131; l61 = v132; l62 = v133; l63 = v134; l64 = v135; l65 = v136; l66 = v137; l67 = v138; l68 = v139; l69 = v140} : Mut1
    let v142 : US8 = US8_1(true)
    let v143 : Mut1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v142; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63; l63 = v64; l64 = v65; l65 = v66; l66 = v67; l67 = v68; l68 = v69; l69 = v70} : Mut1
    method20(v143, v141)
    let struct (v144 : US6, v145 : US6, v146 : US6, v147 : US7, v148 : US6, v149 : US6, v150 : US6, v151 : US6, v152 : US6, v153 : US6, v154 : US8, v155 : US9, v156 : US6, v157 : US6, v158 : US8, v159 : US6, v160 : US6, v161 : US6, v162 : US10, v163 : US8, v164 : US6, v165 : US6, v166 : US6, v167 : US6, v168 : US6, v169 : US6, v170 : US11, v171 : US6, v172 : US6, v173 : US6, v174 : US11, v175 : US6, v176 : US6, v177 : US6, v178 : US6, v179 : US6, v180 : US6, v181 : US6, v182 : US6, v183 : US6, v184 : US6, v185 : US12, v186 : US13, v187 : US12, v188 : US6, v189 : US6, v190 : US6, v191 : US6, v192 : US6, v193 : US6, v194 : US6, v195 : US6, v196 : US6, v197 : US6, v198 : US6, v199 : US6, v200 : US6, v201 : US6, v202 : US6, v203 : US6, v204 : US14, v205 : US6, v206 : US11, v207 : US6, v208 : US6, v209 : US14, v210 : US14, v211 : US6, v212 : US5, v213 : US6) = v143.l0, v143.l1, v143.l2, v143.l3, v143.l4, v143.l5, v143.l6, v143.l7, v143.l8, v143.l9, v143.l10, v143.l11, v143.l12, v143.l13, v143.l14, v143.l15, v143.l16, v143.l17, v143.l18, v143.l19, v143.l20, v143.l21, v143.l22, v143.l23, v143.l24, v143.l25, v143.l26, v143.l27, v143.l28, v143.l29, v143.l30, v143.l31, v143.l32, v143.l33, v143.l34, v143.l35, v143.l36, v143.l37, v143.l38, v143.l39, v143.l40, v143.l41, v143.l42, v143.l43, v143.l44, v143.l45, v143.l46, v143.l47, v143.l48, v143.l49, v143.l50, v143.l51, v143.l52, v143.l53, v143.l54, v143.l55, v143.l56, v143.l57, v143.l58, v143.l59, v143.l60, v143.l61, v143.l62, v143.l63, v143.l64, v143.l65, v143.l66, v143.l67, v143.l68, v143.l69
    struct (v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213)
and closure152 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : US6 = v0.l25
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
and closure153 () () : JS.Function =
    let v0 : string = "BiRegularLinkExternal"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure154 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    let v71 : string = "-13px"
    let v72 : US6 = US6_1(v71)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v70, v35, v72, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and method48 (v0 : (Mut7 -> JSX.Element), v1 : (unit -> JS.Function), v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)), v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6))) : JSX.Element =
    let v4 : Mut7 = {l0 = v1; l1 = v2; l2 = v3} : Mut7
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure150 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : string = "Anchor"
    let v2 : string = "@hope-ui/core"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure151(v0)
    let v5 : (unit -> (JSX.Element [])) = closure152(v0)
    let v6 : JSX.Element = method5(v3, v4, v5)
    let v7 : string = "&nbsp;"
    let v8 : JSX.Element = v7 |> unbox<JSX.Element>
    let v9 : JSX.Element = Html.fragment [ v8 ]
    let v10 : (Mut7 -> JSX.Element) = closure60()
    let v11 : (unit -> JS.Function) = closure153()
    let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v13 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure154()
    let v14 : JSX.Element = method48(v10, v11, v12, v13)
    [|v6; v9; v14|]
and method47 (v0 : Mut1) : JSX.Element =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/core"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v5 : (unit -> (JSX.Element [])) = closure150(v0)
    method5(v3, v4, v5)
and closure149 () (v0 : Mut1) : JSX.Element =
    method47(v0)
and closure155 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "https://github.com/fc1943s/tictactoe_spiral"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v71, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure156 () () : (JSX.Element []) =
    [||]
and closure148 () () : (JSX.Element []) =
    let v0 : (Mut1 -> JSX.Element) = closure149()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure155()
    let v2 : (unit -> (JSX.Element [])) = closure156()
    let v3 : JSX.Element = method22(v0, v1, v2)
    [|v3|]
and closure147 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : (unit -> (JSX.Element [])) = closure148()
    let v71 : US9 = US9_1(v70)
    let v72 : string = "1px 6px"
    let v73 : US6 = US6_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v73, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure159 (v0 : string) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : US6 = US6_1(v0)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v71, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure158 (v0 : string) () : (JSX.Element []) =
    let v1 : (Mut1 -> JSX.Element) = closure149()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure159(v0)
    let v3 : (unit -> (JSX.Element [])) = closure156()
    let v4 : JSX.Element = method22(v1, v2, v3)
    [|v4|]
and closure157 (v0 : string) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (unit -> (JSX.Element [])) = closure158(v0)
    let v72 : US9 = US9_1(v71)
    let v73 : string = "1px 6px"
    let v74 : US6 = US6_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v72, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v74, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure162 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "https://fc1943s.github.io/tictactoe_spiral"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v71, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure161 () () : (JSX.Element []) =
    let v0 : (Mut1 -> JSX.Element) = closure149()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure162()
    let v2 : (unit -> (JSX.Element [])) = closure156()
    let v3 : JSX.Element = method22(v0, v1, v2)
    [|v3|]
and closure160 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : (unit -> (JSX.Element [])) = closure161()
    let v71 : US9 = US9_1(v70)
    let v72 : string = "1px 6px"
    let v73 : US6 = US6_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v73, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure165 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "https://fc1943s.github.io/tictactoe_spiral/docs"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v71, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure164 () () : (JSX.Element []) =
    let v0 : (Mut1 -> JSX.Element) = closure149()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure165()
    let v2 : (unit -> (JSX.Element [])) = closure156()
    let v3 : JSX.Element = method22(v0, v1, v2)
    [|v3|]
and closure163 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : (unit -> (JSX.Element [])) = closure164()
    let v71 : US9 = US9_1(v70)
    let v72 : string = "1px 6px"
    let v73 : US6 = US6_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v73, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure146 (v0 : string) () : (JSX.Element []) =
    let v1 : bool = "" = v0
    let v15 : JSX.Element =
        if v1 then
            let v2 : (Mut3 -> JSX.Element) = closure14()
            let v3 : US13 = US13_0
            let v4 : US13 = US13_0
            let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure147()
            let v6 : US15 = US15_2
            method26(v2, v3, v4, v5, v6)
        else
            let v8 : string = $"https://github.com/fc1943s/tictactoe_spiral/tree/{v0}"
            let v9 : (Mut3 -> JSX.Element) = closure14()
            let v10 : US13 = US13_0
            let v11 : US13 = US13_0
            let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure157(v8)
            let v13 : US15 = US15_2
            method26(v9, v10, v11, v12, v13)
    let v16 : (Mut3 -> JSX.Element) = closure14()
    let v17 : US13 = US13_0
    let v18 : US13 = US13_0
    let v19 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure160()
    let v20 : US15 = US15_2
    let v21 : JSX.Element = method26(v16, v17, v18, v19, v20)
    let v22 : US13 = US13_0
    let v23 : US13 = US13_0
    let v24 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure163()
    let v25 : US15 = US15_2
    let v26 : JSX.Element = method26(v16, v22, v23, v24, v25)
    [|v15; v21; v26|]
and method46 () : JSX.Element =
    let struct (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) = method2()
    let v5 : (Mut1 -> JSX.Element) = closure7()
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure146(v3)
    method22(v5, v6, v7)
and closure145 () (v0 : Mut1) : JSX.Element =
    method46()
and closure166 () () : (JSX.Element []) =
    [||]
and closure144 () () : (JSX.Element []) =
    let v0 : (Mut1 -> JSX.Element) = closure145()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (JSX.Element [])) = closure166()
    let v3 : JSX.Element = method22(v0, v1, v2)
    [|v3|]
and closure143 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "Links"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure144()
    let v74 : US9 = US9_1(v73)
    let v75 : US11 = US11_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure173 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure176 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "row"
    let v71 : US6 = US6_1(v70)
    let v72 : string = "4"
    let v73 : US6 = US6_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v71, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v73, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure179 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "dark"
    let v71 : obj = v70
    let v72 : string = "neutral"
    let v73 : US6 = US6_1(v72)
    let v74 : string = "sm"
    let v75 : US6 = US6_1(v74)
    let v76 : string = "radio"
    let v77 : US6 = US6_1(v76)
    let v78 : US14 = US14_1(v71)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v73, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v75, v57, v58, v59, v60, v61, v62, v63, v77, v78, v66, v67, v68, v69)
and closure180 () () : (JSX.Element []) =
    let v0 : string = "Dark"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure178 () () : (JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/core"
    let v2 : JS.Function = import v0 v1
    let v3 : JS.Function = v2?input
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure179()
    let v5 : (unit -> (JSX.Element [])) = closure26()
    let v6 : JSX.Element = method5(v3, v4, v5)
    let v7 : string = "&nbsp;"
    let v8 : JSX.Element = v7 |> unbox<JSX.Element>
    let v9 : JSX.Element = Html.fragment [ v8 ]
    let v10 : (unit -> (JSX.Element [])) = closure180()
    let v11 : JSX.Element = v10 |> unbox<JSX.Element>
    [|v6; v9; v11|]
and closure182 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "light"
    let v71 : obj = v70
    let v72 : string = "neutral"
    let v73 : US6 = US6_1(v72)
    let v74 : string = "sm"
    let v75 : US6 = US6_1(v74)
    let v76 : string = "radio"
    let v77 : US6 = US6_1(v76)
    let v78 : US14 = US14_1(v71)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v73, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v75, v57, v58, v59, v60, v61, v62, v63, v77, v78, v66, v67, v68, v69)
and closure183 () () : (JSX.Element []) =
    let v0 : string = "Light"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure181 () () : (JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/core"
    let v2 : JS.Function = import v0 v1
    let v3 : JS.Function = v2?input
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure182()
    let v5 : (unit -> (JSX.Element [])) = closure26()
    let v6 : JSX.Element = method5(v3, v4, v5)
    let v7 : string = "&nbsp;"
    let v8 : JSX.Element = v7 |> unbox<JSX.Element>
    let v9 : JSX.Element = Html.fragment [ v8 ]
    let v10 : (unit -> (JSX.Element [])) = closure183()
    let v11 : JSX.Element = v10 |> unbox<JSX.Element>
    [|v6; v9; v11|]
and closure177 () () : (JSX.Element []) =
    let v0 : string = "Box"
    let v1 : string = "@hope-ui/core"
    let v2 : JS.Function = import v0 v1
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure22()
    let v4 : (unit -> (JSX.Element [])) = closure178()
    let v5 : JSX.Element = method5(v2, v3, v4)
    let v6 : JS.Function = import v0 v1
    let v7 : (unit -> (JSX.Element [])) = closure181()
    let v8 : JSX.Element = method5(v6, v3, v7)
    [|v5; v8|]
and closure175 () () : (JSX.Element []) =
    let v0 : string = "Stack"
    let v1 : string = "@hope-ui/core"
    let v2 : JS.Function = import v0 v1
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure176()
    let v4 : (unit -> (JSX.Element [])) = closure177()
    let v5 : JSX.Element = method5(v2, v3, v4)
    [|v5|]
and closure174 () () : (JSX.Element []) =
    let v0 : (unit -> (JSX.Element [])) = closure175()
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    [|v1|]
and closure172 () () : (JSX.Element []) =
    let v0 : string = "Box"
    let v1 : string = "@hope-ui/core"
    let v2 : JS.Function = import v0 v1
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure173()
    let v4 : (unit -> (JSX.Element [])) = closure174()
    let v5 : JSX.Element = method5(v2, v3, v4)
    [|v5|]
and closure171 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "Theme"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure172()
    let v74 : US9 = US9_1(v73)
    let v75 : string = "5px 6px"
    let v76 : US6 = US6_1(v75)
    let v77 : US11 = US11_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v76, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v77, v63, v64, v65, v66, v67, v68, v69)
and closure170 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure14()
    let v1 : US13 = US13_0
    let v2 : US13 = US13_0
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure171()
    let v4 : US15 = US15_2
    let v5 : JSX.Element = method26(v0, v1, v2, v3, v4)
    [|v5|]
and method49 () : JSX.Element =
    let v0 : (Mut1 -> JSX.Element) = closure7()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (JSX.Element [])) = closure170()
    method22(v0, v1, v2)
and closure169 () (v0 : Mut1) : JSX.Element =
    method49()
and closure184 () () : (JSX.Element []) =
    [||]
and closure168 () () : (JSX.Element []) =
    let v0 : (Mut1 -> JSX.Element) = closure169()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (JSX.Element [])) = closure184()
    let v3 : JSX.Element = method22(v0, v1, v2)
    [|v3|]
and closure167 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "Settings"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure168()
    let v74 : US9 = US9_1(v73)
    let v75 : US11 = US11_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure197 (v0 : Mut17) (v1 : obj) : unit =
    let v2 : string = v1?currentTarget?value
    let v3 : (US6 -> unit) = v0.l1
    let v4 : US6 = US6_1(v2)
    v3 v4
    ()
and closure196 (v0 : Mut17) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
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
    let v79 : (obj -> unit) = closure197(v0)
    let v80 : US12 = US12_1(v79)
    let v81 : string = "xs"
    let v82 : US6 = US6_1(v81)
    let v83 : string = "text"
    let v84 : US6 = US6_1(v83)
    let v85 : US14 = US14_1(v76)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v78, v42, v43, v80, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v82, v58, v59, v60, v61, v62, v63, v64, v84, v85, v67, v68, v69, v70)
and closure198 () () : (JSX.Element []) =
    [||]
and method52 (v0 : Mut17) : JSX.Element =
    let v1 : string = "Input"
    let v2 : string = "@hope-ui/core"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure196(v0)
    let v5 : (unit -> (JSX.Element [])) = closure198()
    method5(v3, v4, v5)
and closure195 () (v0 : Mut17) : JSX.Element =
    method52(v0)
and closure199 (v0 : (unit -> string)) () : US6 =
    let v1 : string = v0 ()
    US6_1(v1)
and closure200 (v0 : (string -> unit)) (v1 : US6) : unit =
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
and closure194 (v0 : (string -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : (Mut17 -> JSX.Element) = closure195()
    let v3 : (unit -> US6) = closure199(v1)
    let v4 : (US6 -> unit) = closure200(v0)
    let v5 : JSX.Element = method53(v2, v3, v4)
    [|v5|]
and closure193 (v0 : (string -> unit), v1 : (unit -> string)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = "Token"
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure194(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "3px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v78, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and closure202 (v0 : (string -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : (Mut17 -> JSX.Element) = closure195()
    let v3 : (unit -> US6) = closure199(v1)
    let v4 : (US6 -> unit) = closure200(v0)
    let v5 : JSX.Element = method53(v2, v3, v4)
    [|v5|]
and closure201 (v0 : (string -> unit), v1 : (unit -> string)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = "URL"
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure202(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "3px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v78, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and closure207 (v0 : Mut18) (v1 : obj) : unit =
    let v2 : int32 = v1?currentTarget?value
    let v3 : (US5 -> unit) = v0.l1
    let v4 : US5 = US5_1(v2)
    v3 v4
    ()
and closure206 (v0 : Mut18) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
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
    let v79 : (obj -> unit) = closure207(v0)
    let v80 : US12 = US12_1(v79)
    let v81 : string = "xs"
    let v82 : US6 = US6_1(v81)
    let v83 : string = "text"
    let v84 : US6 = US6_1(v83)
    let v85 : US14 = US14_1(v76)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v78, v42, v43, v80, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v82, v58, v59, v60, v61, v62, v63, v64, v84, v85, v67, v68, v69, v70)
and method54 (v0 : Mut18) : JSX.Element =
    let v1 : string = "Input"
    let v2 : string = "@hope-ui/core"
    let v3 : JS.Function = import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure206(v0)
    let v5 : (unit -> (JSX.Element [])) = closure198()
    method5(v3, v4, v5)
and closure205 () (v0 : Mut18) : JSX.Element =
    method54(v0)
and closure208 (v0 : (unit -> int32)) () : US5 =
    let v1 : int32 = v0 ()
    US5_1(v1)
and closure209 (v0 : (int32 -> unit)) (v1 : US5) : unit =
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
and closure204 (v0 : (int32 -> unit), v1 : (unit -> int32)) () : (JSX.Element []) =
    let v2 : (Mut18 -> JSX.Element) = closure205()
    let v3 : (unit -> US5) = closure208(v1)
    let v4 : (US5 -> unit) = closure209(v0)
    let v5 : JSX.Element = method55(v2, v3, v4)
    [|v5|]
and closure203 (v0 : (int32 -> unit), v1 : (unit -> int32)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = "Port"
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure204(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "3px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v78, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and closure192 (v0 : (string -> unit), v1 : (unit -> string), v2 : (string -> unit), v3 : (unit -> string), v4 : (int32 -> unit), v5 : (unit -> int32)) () : (JSX.Element []) =
    let v6 : (Mut3 -> JSX.Element) = closure14()
    let v7 : US13 = US13_0
    let v8 : US13 = US13_0
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure193(v0, v1)
    let v10 : US15 = US15_2
    let v11 : JSX.Element = method26(v6, v7, v8, v9, v10)
    let v12 : US13 = US13_0
    let v13 : US13 = US13_0
    let v14 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure201(v2, v3)
    let v15 : US15 = US15_2
    let v16 : JSX.Element = method26(v6, v12, v13, v14, v15)
    let v17 : US13 = US13_0
    let v18 : US13 = US13_0
    let v19 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure203(v4, v5)
    let v20 : US15 = US15_2
    let v21 : JSX.Element = method26(v6, v17, v18, v19, v20)
    [|v11; v16; v21|]
and method51 () : JSX.Element =
    let v108 : obj = emitJsExpr () "components_spi.state_context"
    let v109 : string = "useContext"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let struct (v112 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v113 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v114 : (unit -> int32), v115 : (int32 -> unit), v116 : (unit -> string), v117 : (string -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v121 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v122 : (unit -> (struct (US2 * obj * string) [])), v123 : ((struct (US2 * obj * string) []) -> unit), v124 : (unit -> (struct (Guid * obj) [])), v125 : ((struct (Guid * obj) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * int32) [])), v129 : ((struct (Guid * int32) []) -> unit), v130 : (unit -> US4), v131 : (US4 -> unit), v132 : (unit -> US5), v133 : (US5 -> unit)) = v111.Invoke v108 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v242 : obj = emitJsExpr () "components_spi.state_context"
    let v243 : JS.Function = import v109 v110
    let struct (v244 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v245 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v246 : (unit -> int32), v247 : (int32 -> unit), v248 : (unit -> string), v249 : (string -> unit), v250 : (unit -> string), v251 : (string -> unit), v252 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v253 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v254 : (unit -> (struct (US2 * obj * string) [])), v255 : ((struct (US2 * obj * string) []) -> unit), v256 : (unit -> (struct (Guid * obj) [])), v257 : ((struct (Guid * obj) []) -> unit), v258 : (unit -> (struct (Guid * obj) [])), v259 : ((struct (Guid * obj) []) -> unit), v260 : (unit -> (struct (Guid * int32) [])), v261 : ((struct (Guid * int32) []) -> unit), v262 : (unit -> US4), v263 : (US4 -> unit), v264 : (unit -> US5), v265 : (US5 -> unit)) = v243.Invoke v242 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v374 : obj = emitJsExpr () "components_spi.state_context"
    let v375 : JS.Function = import v109 v110
    let struct (v376 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v377 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v378 : (unit -> int32), v379 : (int32 -> unit), v380 : (unit -> string), v381 : (string -> unit), v382 : (unit -> string), v383 : (string -> unit), v384 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v385 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v386 : (unit -> (struct (US2 * obj * string) [])), v387 : ((struct (US2 * obj * string) []) -> unit), v388 : (unit -> (struct (Guid * obj) [])), v389 : ((struct (Guid * obj) []) -> unit), v390 : (unit -> (struct (Guid * obj) [])), v391 : ((struct (Guid * obj) []) -> unit), v392 : (unit -> (struct (Guid * int32) [])), v393 : ((struct (Guid * int32) []) -> unit), v394 : (unit -> US4), v395 : (US4 -> unit), v396 : (unit -> US5), v397 : (US5 -> unit)) = v375.Invoke v374 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v398 : (Mut1 -> JSX.Element) = closure7()
    let v399 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v400 : (unit -> (JSX.Element [])) = closure192(v117, v116, v251, v250, v379, v378)
    method22(v398, v399, v400)
and closure191 () (v0 : Mut1) : JSX.Element =
    method51()
and closure210 () () : (JSX.Element []) =
    [||]
and closure190 () () : (JSX.Element []) =
    let v0 : (Mut1 -> JSX.Element) = closure191()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (JSX.Element [])) = closure210()
    let v3 : JSX.Element = method22(v0, v1, v2)
    [|v3|]
and closure189 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "Connection"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure190()
    let v74 : US9 = US9_1(v73)
    let v75 : US11 = US11_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure222 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : US6 =
    let v8 : string = v2 ()
    US6_1(v8)
and closure223 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) (v8 : US6) : unit =
    let v11 : string =
        match v8 with
        | US6_0 -> (* None *)
            let v9 : string = ""
            v9
        | US6_1(v10) -> (* Some *)
            v10
    v3 v11
    ()
and closure221 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : (JSX.Element []) =
    let v8 : (Mut17 -> JSX.Element) = closure195()
    let v9 : (unit -> US6) = closure222(v0, v1, v2, v3, v4, v5, v6, v7)
    let v10 : (US6 -> unit) = closure223(v0, v1, v2, v3, v4, v5, v6, v7)
    let v11 : JSX.Element = method53(v8, v9, v10)
    [|v11|]
and closure220 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) struct (v8 : US6, v9 : US6, v10 : US6, v11 : US7, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US6, v17 : US6, v18 : US8, v19 : US9, v20 : US6, v21 : US6, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US10, v27 : US8, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US11, v35 : US6, v36 : US6, v37 : US6, v38 : US11, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US12, v50 : US13, v51 : US12, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US14, v69 : US6, v70 : US11, v71 : US6, v72 : US6, v73 : US14, v74 : US14, v75 : US6, v76 : US5, v77 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v78 : string = "Address"
    let v79 : JSX.Element = v78 |> unbox<JSX.Element>
    let v80 : JSX.Element = Html.fragment [ v79 ]
    let v81 : (unit -> (JSX.Element [])) = closure221(v0, v1, v2, v3, v4, v5, v6, v7)
    let v82 : US9 = US9_1(v81)
    let v83 : string = "3px"
    let v84 : US6 = US6_1(v83)
    let v85 : US11 = US11_1(v80)
    struct (v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v82, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v84, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v85, v71, v72, v73, v74, v75, v76, v77)
and closure226 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : US6 =
    let v8 : string = v6 ()
    US6_1(v8)
and closure227 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) (v8 : US6) : unit =
    let v11 : string =
        match v8 with
        | US6_0 -> (* None *)
            let v9 : string = ""
            v9
        | US6_1(v10) -> (* Some *)
            v10
    v7 v11
    ()
and closure225 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : (JSX.Element []) =
    let v8 : (Mut17 -> JSX.Element) = closure195()
    let v9 : (unit -> US6) = closure226(v0, v1, v2, v3, v4, v5, v6, v7)
    let v10 : (US6 -> unit) = closure227(v0, v1, v2, v3, v4, v5, v6, v7)
    let v11 : JSX.Element = method53(v8, v9, v10)
    [|v11|]
and closure224 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) struct (v8 : US6, v9 : US6, v10 : US6, v11 : US7, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US6, v17 : US6, v18 : US8, v19 : US9, v20 : US6, v21 : US6, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US10, v27 : US8, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US11, v35 : US6, v36 : US6, v37 : US6, v38 : US11, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US12, v50 : US13, v51 : US12, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US14, v69 : US6, v70 : US11, v71 : US6, v72 : US6, v73 : US14, v74 : US14, v75 : US6, v76 : US5, v77 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v78 : string = "Private Key"
    let v79 : JSX.Element = v78 |> unbox<JSX.Element>
    let v80 : JSX.Element = Html.fragment [ v79 ]
    let v81 : (unit -> (JSX.Element [])) = closure225(v0, v1, v2, v3, v4, v5, v6, v7)
    let v82 : US9 = US9_1(v81)
    let v83 : string = "3px"
    let v84 : US6 = US6_1(v83)
    let v85 : US11 = US11_1(v80)
    struct (v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v82, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v84, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v85, v71, v72, v73, v74, v75, v76, v77)
and closure219 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : (JSX.Element []) =
    let v8 : (Mut3 -> JSX.Element) = closure14()
    let v9 : US13 = US13_0
    let v10 : US13 = US13_0
    let v11 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure220(v0, v1, v2, v3, v4, v5, v6, v7)
    let v12 : US15 = US15_2
    let v13 : JSX.Element = method26(v8, v9, v10, v11, v12)
    let v14 : US13 = US13_0
    let v15 : US13 = US13_0
    let v16 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure224(v0, v1, v2, v3, v4, v5, v6, v7)
    let v17 : US15 = US15_2
    let v18 : JSX.Element = method26(v8, v14, v15, v16, v17)
    [|v13; v18|]
and closure218 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : (JSX.Element []) =
    let v8 : (Mut1 -> JSX.Element) = closure7()
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v10 : (unit -> (JSX.Element [])) = closure219(v0, v1, v2, v3, v4, v5, v6, v7)
    let v11 : JSX.Element = method22(v8, v9, v10)
    [|v11|]
and closure217 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) struct (v8 : US6, v9 : US6, v10 : US6, v11 : US7, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US6, v17 : US6, v18 : US8, v19 : US9, v20 : US6, v21 : US6, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US10, v27 : US8, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US11, v35 : US6, v36 : US6, v37 : US6, v38 : US11, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US12, v50 : US13, v51 : US12, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US14, v69 : US6, v70 : US11, v71 : US6, v72 : US6, v73 : US14, v74 : US14, v75 : US6, v76 : US5, v77 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
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
    let v87 : (unit -> (JSX.Element [])) = closure218(v0, v1, v2, v3, v4, v5, v6, v7)
    let v88 : US9 = US9_1(v87)
    let v89 : US11 = US11_1(v86)
    struct (v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v88, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v89, v71, v72, v73, v74, v75, v76, v77)
and closure216 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) (v8 : (unit -> int32)) : (JSX.Element []) =
    let v9 : (Mut3 -> JSX.Element) = closure14()
    let v10 : US13 = US13_0
    let v11 : US13 = US13_0
    let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure217(v0, v1, v2, v3, v4, v5, v6, v7)
    let v13 : US15 = US15_2
    let v14 : JSX.Element = method26(v9, v10, v11, v12, v13)
    [|v14|]
and closure215 () struct (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) : ((unit -> int32) -> (JSX.Element [])) =
    closure216(v0, v1, v2, v3, v4, v5, v6, v7)
and closure228 (v0 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (obj []) = v0 |> unbox<(obj [])>
    let v72 : US10 = US10_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v72, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure214 (v0 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []))) () : (JSX.Element []) =
    let v1 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) = v0 ()
    let v2 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) -> ((unit -> int32) -> (JSX.Element []))) = closure215()
    let v3 : (unit -> (JSX.Element [])) = emitJsExpr () $"(item: any, index: () => number) => {v2}(item)(index)"
    let v4 : string = "For"
    let v5 : string = "solid-js"
    let v6 : JS.Function = import v4 v5
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure228(v1)
    let v8 : JSX.Element = method5(v6, v7, v3)
    [|v8|]
and method56 () : JSX.Element =
    let v108 : obj = emitJsExpr () "components_spi.state_context"
    let v109 : string = "useContext"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let struct (v112 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v113 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v114 : (unit -> int32), v115 : (int32 -> unit), v116 : (unit -> string), v117 : (string -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v121 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v122 : (unit -> (struct (US2 * obj * string) [])), v123 : ((struct (US2 * obj * string) []) -> unit), v124 : (unit -> (struct (Guid * obj) [])), v125 : ((struct (Guid * obj) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * int32) [])), v129 : ((struct (Guid * int32) []) -> unit), v130 : (unit -> US4), v131 : (US4 -> unit), v132 : (unit -> US5), v133 : (US5 -> unit)) = v111.Invoke v108 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v134 : (Mut1 -> JSX.Element) = closure7()
    let v135 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v136 : (unit -> (JSX.Element [])) = closure214(v112)
    method22(v134, v135, v136)
and closure213 () (v0 : Mut1) : JSX.Element =
    method56()
and closure229 () () : (JSX.Element []) =
    [||]
and closure212 () () : (JSX.Element []) =
    let v0 : (Mut1 -> JSX.Element) = closure213()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (JSX.Element [])) = closure229()
    let v3 : JSX.Element = method22(v0, v1, v2)
    [|v3|]
and closure211 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "Accounts"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure212()
    let v74 : US9 = US9_1(v73)
    let v75 : US11 = US11_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure232 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
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
    let v81 : US11 = US11_1(v72)
    struct (v0, v1, v2, v3, v74, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v76, v21, v22, v23, v78, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v80, v59, v60, v61, v81, v63, v64, v65, v66, v67, v68, v69)
and closure233 () () : (JSX.Element []) =
    [||]
and closure231 () () : (JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/core"
    let v2 : JS.Function = import v0 v1
    let v3 : JS.Function = v2?iframe
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure232()
    let v5 : (unit -> (JSX.Element [])) = closure233()
    let v6 : JSX.Element = method5(v3, v4, v5)
    [|v6|]
and closure230 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "Testnet Bank Dispenser"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure231()
    let v74 : US9 = US9_1(v73)
    let v75 : US11 = US11_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure188 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure14()
    let v1 : US13 = US13_0
    let v2 : US13 = US13_0
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure189()
    let v4 : US15 = US15_2
    let v5 : JSX.Element = method26(v0, v1, v2, v3, v4)
    let v6 : US13 = US13_0
    let v7 : US13 = US13_0
    let v8 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure211()
    let v9 : US15 = US15_2
    let v10 : JSX.Element = method26(v0, v6, v7, v8, v9)
    let v11 : US13 = US13_0
    let v12 : US13 = US13_0
    let v13 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure230()
    let v14 : US15 = US15_0
    let v15 : JSX.Element = method26(v0, v11, v12, v13, v14)
    [|v5; v10; v15|]
and method50 () : JSX.Element =
    let v0 : (Mut1 -> JSX.Element) = closure7()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (JSX.Element [])) = closure188()
    method22(v0, v1, v2)
and closure187 () (v0 : Mut1) : JSX.Element =
    method50()
and closure234 () () : (JSX.Element []) =
    [||]
and closure186 () () : (JSX.Element []) =
    let v0 : (Mut1 -> JSX.Element) = closure187()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (JSX.Element [])) = closure234()
    let v3 : JSX.Element = method22(v0, v1, v2)
    [|v3|]
and closure185 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "Chain"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure186()
    let v74 : US9 = US9_1(v73)
    let v75 : string = "db"
    let v76 : US6 = US6_1(v75)
    let v77 : US11 = US11_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v76, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v77, v63, v64, v65, v66, v67, v68, v69)
and method61 (v0 : int32, v1 : Mut21) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure248 (v0 : Mut20, v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) () : US6 =
    let v2 : (struct ((US2 []) * int32 * US3 * string * string) []) = v1 ()
    let v3 : int32 = v2.Length
    let v4 : US6 = US6_0
    let v5 : Mut21 = {l0 = 0; l1 = v4} : Mut21
    while method61(v3, v5) do
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
                    | US3_2, US3_2 -> (* SignalRServer *)
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
and closure249 (v0 : Mut20, v1 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v2 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) (v3 : US6) : unit =
    let v4 : (struct ((US2 []) * int32 * US3 * string * string) []) = v2 ()
    let v5 : int32 = v4.Length
    let v6 : (struct ((US2 []) * int32 * US3 * string * string) []) = Array.zeroCreate<struct ((US2 []) * int32 * US3 * string * string)> (v5)
    let v7 : Mut6 = {l0 = 0} : Mut6
    while method21(v5, v7) do
        let v9 : int32 = v7.l0
        let struct (v10 : (US2 []), v11 : int32, v12 : US3, v13 : string, v14 : string) = v4.[int v9]
        let v15 : US3 = v0.l1
        let v16 : bool =
            match v12, v15 with
            | US3_0, US3_0 -> (* GunJsServer *)
                true
            | US3_1, US3_1 -> (* GunRsServer *)
                true
            | US3_2, US3_2 -> (* SignalRServer *)
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
and method60 (v0 : Mut20) : JSX.Element =
    let v109 : obj = emitJsExpr () "components_spi.state_context"
    let v110 : string = "useContext"
    let v111 : string = "solid-js"
    let v112 : JS.Function = import v110 v111
    let struct (v113 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v114 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v115 : (unit -> int32), v116 : (int32 -> unit), v117 : (unit -> string), v118 : (string -> unit), v119 : (unit -> string), v120 : (string -> unit), v121 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v122 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v123 : (unit -> (struct (US2 * obj * string) [])), v124 : ((struct (US2 * obj * string) []) -> unit), v125 : (unit -> (struct (Guid * obj) [])), v126 : ((struct (Guid * obj) []) -> unit), v127 : (unit -> (struct (Guid * obj) [])), v128 : ((struct (Guid * obj) []) -> unit), v129 : (unit -> (struct (Guid * int32) [])), v130 : ((struct (Guid * int32) []) -> unit), v131 : (unit -> US4), v132 : (US4 -> unit), v133 : (unit -> US5), v134 : (US5 -> unit)) = v112.Invoke v109 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v135 : (Mut17 -> JSX.Element) = closure195()
    let v136 : (unit -> US6) = closure248(v0, v121)
    let v137 : (US6 -> unit) = closure249(v0, v122, v121)
    method53(v135, v136, v137)
and closure247 () (v0 : Mut20) : JSX.Element =
    method60(v0)
and closure250 () struct (v0 : (US2 []), v1 : int32, v2 : US3, v3 : string, v4 : string) : US6 =
    US6_1(v3)
and closure252 (v0 : Mut19, v1 : (US2 []), v2 : int32, v3 : US3, v4 : string, v5 : string) (v6 : US6) : struct ((US2 []) * int32 * US3 * string * string) =
    let v7 : US3 = v0.l0
    let v10 : string =
        match v6 with
        | US6_0 -> (* None *)
            let v8 : string = ""
            v8
        | US6_1(v9) -> (* Some *)
            v9
    struct (v1, v2, v7, v10, v5)
and closure251 (v0 : Mut19) struct (v1 : (US2 []), v2 : int32, v3 : US3, v4 : string, v5 : string) : (US6 -> struct ((US2 []) * int32 * US3 * string * string)) =
    closure252(v0, v1, v2, v3, v4, v5)
and method62 (v0 : (Mut20 -> JSX.Element), v1 : (struct ((US2 []) * int32 * US3 * string * string) -> US6), v2 : US3, v3 : (struct ((US2 []) * int32 * US3 * string * string) -> (US6 -> struct ((US2 []) * int32 * US3 * string * string)))) : JSX.Element =
    let v4 : Mut20 = {l0 = v1; l1 = v2; l2 = v3} : Mut20
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure246 (v0 : Mut19) () : (JSX.Element []) =
    let v1 : (Mut20 -> JSX.Element) = closure247()
    let v2 : US3 = v0.l0
    let v3 : (struct ((US2 []) * int32 * US3 * string * string) -> US6) = closure250()
    let v4 : (struct ((US2 []) * int32 * US3 * string * string) -> (US6 -> struct ((US2 []) * int32 * US3 * string * string))) = closure251(v0)
    let v5 : JSX.Element = method62(v1, v3, v2, v4)
    [|v5|]
and closure245 (v0 : Mut19) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : string = "URL"
    let v72 : JSX.Element = v71 |> unbox<JSX.Element>
    let v73 : JSX.Element = Html.fragment [ v72 ]
    let v74 : (unit -> (JSX.Element [])) = closure246(v0)
    let v75 : US9 = US9_1(v74)
    let v76 : string = "3px"
    let v77 : US6 = US6_1(v76)
    let v78 : US11 = US11_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v75, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v77, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v78, v64, v65, v66, v67, v68, v69, v70)
and method64 (v0 : int32, v1 : Mut23) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure256 (v0 : Mut22, v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) () : US5 =
    let v2 : (struct ((US2 []) * int32 * US3 * string * string) []) = v1 ()
    let v3 : int32 = v2.Length
    let v4 : US5 = US5_0
    let v5 : Mut23 = {l0 = 0; l1 = v4} : Mut23
    while method64(v3, v5) do
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
                    | US3_2, US3_2 -> (* SignalRServer *)
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
and closure257 (v0 : Mut22, v1 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v2 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) (v3 : US5) : unit =
    let v4 : (struct ((US2 []) * int32 * US3 * string * string) []) = v2 ()
    let v5 : int32 = v4.Length
    let v6 : (struct ((US2 []) * int32 * US3 * string * string) []) = Array.zeroCreate<struct ((US2 []) * int32 * US3 * string * string)> (v5)
    let v7 : Mut6 = {l0 = 0} : Mut6
    while method21(v5, v7) do
        let v9 : int32 = v7.l0
        let struct (v10 : (US2 []), v11 : int32, v12 : US3, v13 : string, v14 : string) = v4.[int v9]
        let v15 : US3 = v0.l1
        let v16 : bool =
            match v12, v15 with
            | US3_0, US3_0 -> (* GunJsServer *)
                true
            | US3_1, US3_1 -> (* GunRsServer *)
                true
            | US3_2, US3_2 -> (* SignalRServer *)
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
and method63 (v0 : Mut22) : JSX.Element =
    let v109 : obj = emitJsExpr () "components_spi.state_context"
    let v110 : string = "useContext"
    let v111 : string = "solid-js"
    let v112 : JS.Function = import v110 v111
    let struct (v113 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v114 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v115 : (unit -> int32), v116 : (int32 -> unit), v117 : (unit -> string), v118 : (string -> unit), v119 : (unit -> string), v120 : (string -> unit), v121 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v122 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v123 : (unit -> (struct (US2 * obj * string) [])), v124 : ((struct (US2 * obj * string) []) -> unit), v125 : (unit -> (struct (Guid * obj) [])), v126 : ((struct (Guid * obj) []) -> unit), v127 : (unit -> (struct (Guid * obj) [])), v128 : ((struct (Guid * obj) []) -> unit), v129 : (unit -> (struct (Guid * int32) [])), v130 : ((struct (Guid * int32) []) -> unit), v131 : (unit -> US4), v132 : (US4 -> unit), v133 : (unit -> US5), v134 : (US5 -> unit)) = v112.Invoke v109 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v135 : (Mut18 -> JSX.Element) = closure205()
    let v136 : (unit -> US5) = closure256(v0, v121)
    let v137 : (US5 -> unit) = closure257(v0, v122, v121)
    method55(v135, v136, v137)
and closure255 () (v0 : Mut22) : JSX.Element =
    method63(v0)
and closure258 () struct (v0 : (US2 []), v1 : int32, v2 : US3, v3 : string, v4 : string) : US5 =
    US5_1(v1)
and closure260 (v0 : Mut19, v1 : (US2 []), v2 : int32, v3 : US3, v4 : string, v5 : string) (v6 : US5) : struct ((US2 []) * int32 * US3 * string * string) =
    let v7 : US3 = v0.l0
    let v9 : int32 =
        match v6 with
        | US5_0 -> (* None *)
            0
        | US5_1(v8) -> (* Some *)
            v8
    struct (v1, v9, v7, v4, v5)
and closure259 (v0 : Mut19) struct (v1 : (US2 []), v2 : int32, v3 : US3, v4 : string, v5 : string) : (US5 -> struct ((US2 []) * int32 * US3 * string * string)) =
    closure260(v0, v1, v2, v3, v4, v5)
and method65 (v0 : (Mut22 -> JSX.Element), v1 : (struct ((US2 []) * int32 * US3 * string * string) -> US5), v2 : US3, v3 : (struct ((US2 []) * int32 * US3 * string * string) -> (US5 -> struct ((US2 []) * int32 * US3 * string * string)))) : JSX.Element =
    let v4 : Mut22 = {l0 = v1; l1 = v2; l2 = v3} : Mut22
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v0, v4) |> unbox<JSX.Element>
    v8
and closure254 (v0 : Mut19) () : (JSX.Element []) =
    let v1 : (Mut22 -> JSX.Element) = closure255()
    let v2 : US3 = v0.l0
    let v3 : (struct ((US2 []) * int32 * US3 * string * string) -> US5) = closure258()
    let v4 : (struct ((US2 []) * int32 * US3 * string * string) -> (US5 -> struct ((US2 []) * int32 * US3 * string * string))) = closure259(v0)
    let v5 : JSX.Element = method65(v1, v3, v2, v4)
    [|v5|]
and closure253 (v0 : Mut19) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : string = "Port"
    let v72 : JSX.Element = v71 |> unbox<JSX.Element>
    let v73 : JSX.Element = Html.fragment [ v72 ]
    let v74 : (unit -> (JSX.Element [])) = closure254(v0)
    let v75 : US9 = US9_1(v74)
    let v76 : string = "3px"
    let v77 : US6 = US6_1(v76)
    let v78 : US11 = US11_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v75, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v77, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v78, v64, v65, v66, v67, v68, v69, v70)
and closure244 (v0 : Mut19) () : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure14()
    let v2 : US13 = US13_0
    let v3 : US13 = US13_0
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure245(v0)
    let v5 : US15 = US15_2
    let v6 : JSX.Element = method26(v1, v2, v3, v4, v5)
    let v7 : US13 = US13_0
    let v8 : US13 = US13_0
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure253(v0)
    let v10 : US15 = US15_2
    let v11 : JSX.Element = method26(v1, v7, v8, v9, v10)
    [|v6; v11|]
and method59 (v0 : Mut19) : JSX.Element =
    let v1 : (Mut1 -> JSX.Element) = closure7()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v3 : (unit -> (JSX.Element [])) = closure244(v0)
    method22(v1, v2, v3)
and closure243 () (v0 : Mut19) : JSX.Element =
    method59(v0)
and method66 (v0 : (Mut19 -> JSX.Element), v1 : US3) : JSX.Element =
    let v2 : Mut19 = {l0 = v1} : Mut19
    let v3 : string = "createComponent"
    let v4 : string = "solid-js"
    let v5 : JS.Function = import v3 v4
    let v6 : JSX.Element = v5.Invoke (v0, v2) |> unbox<JSX.Element>
    v6
and closure242 (v0 : Mut19) () : (JSX.Element []) =
    let v1 : (Mut19 -> JSX.Element) = closure243()
    let v2 : US3 = v0.l0
    let v3 : JSX.Element = method66(v1, v2)
    [|v3|]
and closure241 (v0 : Mut19) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : US3 = v0.l0
    let v75 : string =
        match v71 with
        | US3_0 -> (* GunJsServer *)
            let v72 : string = "Gun JavaScript"
            v72
        | US3_1 -> (* GunRsServer *)
            let v73 : string = "Gun Rust"
            v73
        | US3_2 -> (* SignalRServer *)
            let v74 : string = "SignalR"
            v74
    let v76 : JSX.Element = v75 |> unbox<JSX.Element>
    let v77 : JSX.Element = Html.fragment [ v76 ]
    let v78 : (unit -> (JSX.Element [])) = closure242(v0)
    let v79 : US9 = US9_1(v78)
    let v80 : US6 = US6_0
    let v81 : US11 = US11_1(v77)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v79, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v80, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v81, v64, v65, v66, v67, v68, v69, v70)
and closure266 (v0 : Mut24) () : (obj []) =
    let v1 : US3 = v0.l1
    let v5 : string =
        match v1 with
        | US3_0 -> (* GunJsServer *)
            let v2 : string = "Gun JavaScript"
            v2
        | US3_1 -> (* GunRsServer *)
            let v3 : string = "Gun Rust"
            v3
        | US3_2 -> (* SignalRServer *)
            let v4 : string = "SignalR"
            v4
    let v6 : string = "props.ServerType:"
    let v7 : obj = struct (v6, v5)
    let v8 : US2 = v0.l0
    let v13 : string =
        match v8 with
        | US2_0 -> (* GunJsClient *)
            let v9 : string = "Gun JavaScript"
            v9
        | US2_1 -> (* GunRsClient *)
            let v10 : string = "Gun Rust"
            v10
        | US2_2 -> (* Memory *)
            let v11 : string = "Memory"
            v11
        | US2_3 -> (* SignalRClient *)
            let v12 : string = "SignalR"
            v12
    let v14 : string = "props.ClientType:"
    let v15 : obj = struct (v14, v13)
    [|v7; v15|]
and method70 (v0 : US2, v1 : (US2 []), v2 : int32) : bool =
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
            | US2_3, US2_3 -> (* SignalRClient *)
                true
            | _ ->
                false
        if v6 then
            true
        else
            let v7 : int32 = v2 + 1
            method70(v0, v1, v7)
    else
        false
and method69 (v0 : Mut24, v1 : (struct ((US2 []) * int32 * US3 * string * string) []), v2 : int32) : bool =
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
            | US3_2, US3_2 -> (* SignalRServer *)
                true
            | _ ->
                false
        let v15 : bool =
            if v11 then
                let v12 : US2 = v0.l0
                let v13 : int32 = 0
                method70(v12, v5, v13)
            else
                false
        if v15 then
            true
        else
            let v16 : int32 = v2 + 1
            method69(v0, v1, v16)
    else
        false
and closure267 (v0 : Mut24, v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) () : bool =
    let v2 : (struct ((US2 []) * int32 * US3 * string * string) []) = v1 ()
    let v3 : int32 = 0
    method69(v0, v2, v3)
and method71 (v0 : int32, v1 : Mut25) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure268 (v0 : Mut24, v1 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v2 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) (v3 : bool) : unit =
    let v4 : (struct ((US2 []) * int32 * US3 * string * string) []) = v2 ()
    let v5 : int32 = v4.Length
    let v6 : (struct ((US2 []) * int32 * US3 * string * string) []) = Array.zeroCreate<struct ((US2 []) * int32 * US3 * string * string)> (v5)
    let v7 : Mut6 = {l0 = 0} : Mut6
    while method21(v5, v7) do
        let v9 : int32 = v7.l0
        let struct (v10 : (US2 []), v11 : int32, v12 : US3, v13 : string, v14 : string) = v4.[int v9]
        let v15 : US3 = v0.l1
        let v16 : bool =
            match v12, v15 with
            | US3_0, US3_0 -> (* GunJsServer *)
                true
            | US3_1, US3_1 -> (* GunRsServer *)
                true
            | US3_2, US3_2 -> (* SignalRServer *)
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
                        while method21(v21, v23) do
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
                        while method71(v33, v35) do
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
                                | US2_3, US2_3 -> (* SignalRClient *)
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
                        while method21(v45, v47) do
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
and closure270 (v0 : Mut24) () : (JSX.Element []) =
    let v1 : US2 = v0.l0
    let v6 : string =
        match v1 with
        | US2_0 -> (* GunJsClient *)
            let v2 : string = "Gun JavaScript"
            v2
        | US2_1 -> (* GunRsClient *)
            let v3 : string = "Gun Rust"
            v3
        | US2_2 -> (* Memory *)
            let v4 : string = "Memory"
            v4
        | US2_3 -> (* SignalRClient *)
            let v5 : string = "SignalR"
            v5
    let v7 : JSX.Element = v6 |> unbox<JSX.Element>
    let v8 : JSX.Element = Html.fragment [ v7 ]
    [|v8|]
and closure269 (v0 : Mut24) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : US2 = v0.l0
    let v76 : string =
        match v71 with
        | US2_0 -> (* GunJsClient *)
            let v72 : string = "gunjs"
            v72
        | US2_1 -> (* GunRsClient *)
            let v73 : string = "gunrs"
            v73
        | US2_2 -> (* Memory *)
            let v74 : string = "mem"
            v74
        | US2_3 -> (* SignalRClient *)
            let v75 : string = "signalr"
            v75
    let v77 : US3 = v0.l1
    let v81 : string =
        match v77 with
        | US3_0 -> (* GunJsServer *)
            let v78 : string = "gunjs"
            v78
        | US3_1 -> (* GunRsServer *)
            let v79 : string = "gunrs"
            v79
        | US3_2 -> (* SignalRServer *)
            let v80 : string = "signalr"
            v80
    let v82 : string = $"db-{v76}-{v81}"
    let v83 : (unit -> (JSX.Element [])) = closure270(v0)
    let v84 : US9 = US9_1(v83)
    let v85 : US6 = US6_1(v82)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v84, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v85, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and method68 (v0 : Mut24) : JSX.Element =
    let v109 : obj = emitJsExpr () "components_spi.state_context"
    let v110 : string = "useContext"
    let v111 : string = "solid-js"
    let v112 : JS.Function = import v110 v111
    let struct (v113 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v114 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v115 : (unit -> int32), v116 : (int32 -> unit), v117 : (unit -> string), v118 : (string -> unit), v119 : (unit -> string), v120 : (string -> unit), v121 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v122 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v123 : (unit -> (struct (US2 * obj * string) [])), v124 : ((struct (US2 * obj * string) []) -> unit), v125 : (unit -> (struct (Guid * obj) [])), v126 : ((struct (Guid * obj) []) -> unit), v127 : (unit -> (struct (Guid * obj) [])), v128 : ((struct (Guid * obj) []) -> unit), v129 : (unit -> (struct (Guid * int32) [])), v130 : ((struct (Guid * int32) []) -> unit), v131 : (unit -> US4), v132 : (US4 -> unit), v133 : (unit -> US5), v134 : (US5 -> unit)) = v112.Invoke v109 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v135 : (unit -> (obj [])) = closure266(v0)
    let v136 : string = "#666"
    let v137 : (US4 -> ((obj []) -> unit)) = method16(v135, v136)
    let v138 : US4 = US4_0
    let v139 : ((obj []) -> unit) = v137 v138
    let v140 : string = "> db_client ()"
    let v141 : obj = v140
    let v142 : (obj []) = [|v141|]
    v139 v142
    let v143 : (Mut4 -> JSX.Element) = closure21()
    let v144 : (unit -> bool) = closure267(v0, v121)
    let v145 : (bool -> unit) = closure268(v0, v122, v121)
    let v146 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure269(v0)
    method14(v143, v144, v145, v146)
and closure265 () (v0 : Mut24) : JSX.Element =
    method68(v0)
and method72 (v0 : (Mut24 -> JSX.Element), v1 : US2, v2 : US3) : JSX.Element =
    let v3 : Mut24 = {l0 = v1; l1 = v2} : Mut24
    let v4 : string = "createComponent"
    let v5 : string = "solid-js"
    let v6 : JS.Function = import v4 v5
    let v7 : JSX.Element = v6.Invoke (v0, v3) |> unbox<JSX.Element>
    v7
and closure264 (v0 : Mut19) () : (JSX.Element []) =
    let v1 : (Mut24 -> JSX.Element) = closure265()
    let v2 : US3 = v0.l0
    let v3 : US2 = US2_3
    let v4 : JSX.Element = method72(v1, v3, v2)
    [|v4|]
and closure263 (v0 : Mut19) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : string = "Clients"
    let v72 : JSX.Element = v71 |> unbox<JSX.Element>
    let v73 : JSX.Element = Html.fragment [ v72 ]
    let v74 : (unit -> (JSX.Element [])) = closure264(v0)
    let v75 : US9 = US9_1(v74)
    let v76 : US6 = US6_0
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v75, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v76, v29, v30, v31, v32, v33, v34, v78, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v79, v64, v65, v66, v67, v68, v69, v70)
and method67 (v0 : Mut19) : JSX.Element =
    let v1 : (Mut3 -> JSX.Element) = closure14()
    let v2 : US13 = US13_0
    let v3 : US13 = US13_0
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure263(v0)
    let v5 : US15 = US15_2
    method26(v1, v2, v3, v4, v5)
and closure262 () (v0 : Mut19) : JSX.Element =
    method67(v0)
and closure261 (v0 : Mut19) () : (JSX.Element []) =
    let v1 : (Mut19 -> JSX.Element) = closure262()
    let v2 : US3 = v0.l0
    let v3 : JSX.Element = method66(v1, v2)
    [|v3|]
and closure240 (v0 : Mut19) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (Mut3 -> JSX.Element) = closure14()
    let v72 : US13 = US13_0
    let v73 : US13 = US13_0
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure241(v0)
    let v75 : US15 = US15_2
    let v76 : JSX.Element = method26(v71, v72, v73, v74, v75)
    let v77 : (unit -> (JSX.Element [])) = closure261(v0)
    let v78 : US9 = US9_1(v77)
    let v79 : US6 = US6_0
    let v80 : string = "0"
    let v81 : US6 = US6_1(v80)
    let v82 : US6 = US6_1(v80)
    let v83 : US6 = US6_1(v80)
    let v84 : US11 = US11_1(v76)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v78, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v79, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v81, v82, v52, v83, v54, v55, v56, v57, v58, v59, v60, v61, v62, v84, v64, v65, v66, v67, v68, v69, v70)
and method58 (v0 : Mut19) : JSX.Element =
    let v1 : (Mut3 -> JSX.Element) = closure14()
    let v2 : US13 = US13_0
    let v3 : US13 = US13_0
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure240(v0)
    let v5 : US15 = US15_2
    method26(v1, v2, v3, v4, v5)
and closure239 () (v0 : Mut19) : JSX.Element =
    method58(v0)
and closure238 () () : (JSX.Element []) =
    let v0 : (Mut19 -> JSX.Element) = closure239()
    let v1 : US3 = US3_2
    let v2 : JSX.Element = method66(v0, v1)
    [|v2|]
and method57 () : JSX.Element =
    let v0 : (Mut1 -> JSX.Element) = closure7()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (JSX.Element [])) = closure238()
    method22(v0, v1, v2)
and closure237 () (v0 : Mut1) : JSX.Element =
    method57()
and closure271 () () : (JSX.Element []) =
    [||]
and closure236 () () : (JSX.Element []) =
    let v0 : (Mut1 -> JSX.Element) = closure237()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (JSX.Element [])) = closure271()
    let v3 : JSX.Element = method22(v0, v1, v2)
    [|v3|]
and closure235 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "Database"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure236()
    let v74 : US9 = US9_1(v73)
    let v75 : string = "db-connections"
    let v76 : US6 = US6_1(v75)
    let v77 : US11 = US11_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v76, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v77, v63, v64, v65, v66, v67, v68, v69)
and closure276 (v0 : (unit -> (struct (Guid * int32) []))) () : (obj []) =
    let v1 : (struct (Guid * int32) []) = v0 ()
    let v2 : string = "profile_tmp_counter:"
    let v3 : obj = struct (v2, v1)
    [|v3|]
and closure277 (v0 : (US4 -> ((obj []) -> unit))) () : unit =
    let v1 : US4 = US4_2
    let v2 : ((obj []) -> unit) = v0 v1
    let v3 : string = "> counter -> effect ()"
    let v4 : obj = v3
    let v5 : (obj []) = [|v4|]
    v2 v5
    ()
and closure278 (v0 : ((struct (Guid * int32) []) -> unit)) struct (v1 : (struct (Guid * int32) []), v2 : US2, v3 : Guid, v4 : int32) : unit =
    let v5 : (struct (Guid * int32) []) = [|struct (v3, v4)|]
    let v6 : int32 = v1.Length
    let v7 : int32 = v5.Length
    let v8 : int32 = v6 + v7
    let v9 : (struct (Guid * int32) []) = Array.zeroCreate<struct (Guid * int32)> (v8)
    let v10 : Mut6 = {l0 = 0} : Mut6
    while method21(v8, v10) do
        let v12 : int32 = v10.l0
        let v13 : bool = v12 < v6
        let struct (v19 : Guid, v20 : int32) =
            if v13 then
                let struct (v14 : Guid, v15 : int32) = v1.[int v12]
                struct (v14, v15)
            else
                let v16 : int32 = v12 - v6
                let struct (v17 : Guid, v18 : int32) = v5.[int v16]
                struct (v17, v18)
        v9.[int v12] <- struct (v19, v20)
        let v21 : int32 = v12 + 1
        v10.l0 <- v21
        ()
    v0 v9
    ()
and closure281 (v0 : (unit -> (struct (Guid * int32) [])), v1 : (int32 -> unit)) (v2 : (exn -> unit)) : unit =
    let v3 : (struct (Guid * int32) []) = v0 ()
    let v4 : int32 = v3.Length
    v1 v4
    ()
and closure280 (v0 : (unit -> (struct (Guid * int32) []))) (v1 : (int32 -> unit)) : ((exn -> unit) -> unit) =
    closure281(v0, v1)
and closure279 (v0 : (unit -> (struct (Guid * int32) []))) (v1 : obj) : JS.Promise<int32> =
    let v2 : ((int32 -> unit) -> ((exn -> unit) -> unit)) = closure280(v0)
    let v3 : JS.Promise<int32> = Promise.create v2
    v3
and method75 () : struct ((unit -> unit) * (unit -> unit)) =
    let v0 : string = "createSignal"
    let v1 : string = "solid-js"
    let v2 : JS.Function = import v0 v1
    let v3 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v4 : (unit -> unit) = v3.[0] |> unbox<unit -> unit>
    let v5 : (unit -> unit) = v3.[1] |> unbox<unit -> unit>
    struct (v4, v5)
and method76 (v0 : US16) : struct ((unit -> US16) * (US16 -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke v0 |> unbox<JS.Function[]>
    let v5 : (unit -> US16) = v4.[0] |> unbox<unit -> US16>
    let v6 : (US16 -> unit) = v4.[1] |> unbox<US16 -> unit>
    struct (v5, v6)
and method77 (v0 : (struct (US2 * int64 * string) [])) : struct ((unit -> (struct (US2 * int64 * string) [])) * ((struct (US2 * int64 * string) []) -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke v0 |> unbox<JS.Function[]>
    let v5 : (unit -> (struct (US2 * int64 * string) [])) = v4.[0] |> unbox<unit -> (struct (US2 * int64 * string) [])>
    let v6 : ((struct (US2 * int64 * string) []) -> unit) = v4.[1] |> unbox<(struct (US2 * int64 * string) []) -> unit>
    struct (v5, v6)
and closure282 (v0 : string, v1 : (unit -> (struct (Guid * int32) [])), v2 : (unit -> (struct (US2 * obj * string) [])), v3 : (unit -> unit), v4 : (unit -> unit), v5 : (unit -> US16), v6 : (unit -> (struct (US2 * int64 * string) []))) () : (obj []) =
    let v7 : string = "content_address:"
    let v8 : obj = struct (v7, v0)
    let v9 : (struct (Guid * int32) []) = v1 ()
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
    let v21 : (struct (string * int64) []) = Array.zeroCreate<struct (string * int64)> (v20)
    let v22 : Mut6 = {l0 = 0} : Mut6
    while method21(v20, v22) do
        let v24 : int32 = v22.l0
        let struct (v25 : US2, v26 : int64, v27 : string) = v19.[int v24]
        let v32 : string =
            match v25 with
            | US2_0 -> (* GunJsClient *)
                let v28 : string = "Gun JavaScript"
                v28
            | US2_1 -> (* GunRsClient *)
                let v29 : string = "Gun Rust"
                v29
            | US2_2 -> (* Memory *)
                let v30 : string = "Memory"
                v30
            | US2_3 -> (* SignalRClient *)
                let v31 : string = "SignalR"
                v31
        v21.[int v24] <- struct (v32, v26)
        let v33 : int32 = v24 + 1
        v22.l0 <- v33
        ()
    let v34 : string = "subscriptions:"
    let v35 : obj = struct (v34, v21)
    let v36 : (struct (US2 * obj * string) []) = v2 ()
    let v37 : int32 = v36.Length
    let v38 : (string []) = Array.zeroCreate<string> (v37)
    let v39 : Mut6 = {l0 = 0} : Mut6
    while method21(v37, v39) do
        let v41 : int32 = v39.l0
        let struct (v42 : US2, v43 : obj, v44 : string) = v36.[int v41]
        let v49 : string =
            match v42 with
            | US2_0 -> (* GunJsClient *)
                let v45 : string = "Gun JavaScript"
                v45
            | US2_1 -> (* GunRsClient *)
                let v46 : string = "Gun Rust"
                v46
            | US2_2 -> (* Memory *)
                let v47 : string = "Memory"
                v47
            | US2_3 -> (* SignalRClient *)
                let v48 : string = "SignalR"
                v48
        v38.[int v41] <- v49
        let v50 : int32 = v41 + 1
        v39.l0 <- v50
        ()
    let v51 : string = "db_connections:"
    let v52 : obj = struct (v51, v38)
    [|v8; v11; v13; v15; v18; v35; v52|]
and method78 (v0 : int32, v1 : Mut26) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure284 (v0 : string, v1 : US2) () : (obj []) =
    let v2 : string = "content_address:"
    let v3 : obj = struct (v2, v0)
    let v8 : string =
        match v1 with
        | US2_0 -> (* GunJsClient *)
            let v4 : string = "Gun JavaScript"
            v4
        | US2_1 -> (* GunRsClient *)
            let v5 : string = "Gun Rust"
            v5
        | US2_2 -> (* Memory *)
            let v6 : string = "Memory"
            v6
        | US2_3 -> (* SignalRClient *)
            let v7 : string = "SignalR"
            v7
    let v9 : string = "client_type:"
    let v10 : obj = struct (v9, v8)
    [|v3; v10|]
and closure287 () (v0 : Guid) : int64 =
    let v1 : string = v0.ToString ()
    let v2 : int64 = int64 $"{v1.[0..7]}{v1.[9..12]}{v1.[14..17]}{v1.[19..20]}"
    v2
and method81 (v0 : int32, v1 : Mut27) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method80 (v0 : string, v1 : (unit -> (struct (Guid * int32) [])), v2 : (struct ((struct (Guid * int32) []) * US2 * Guid * int32) -> unit), v3 : (US16 -> unit), v4 : (unit -> US16), v5 : (US4 -> ((obj []) -> unit)), v6 : US2, v7 : (struct (US2 * obj * string) []), v8 : int32, v9 : Guid) : unit =
    let v10 : US16 = v4 ()
    let v16 : bool =
        match v10 with
        | US16_0 -> (* None *)
            true
        | US16_1(v11, v12, v13) -> (* Some *)
            let v14 : (Guid -> int64) = closure287()
            let v15 : bool = v13 <> v8 && v14 v9 > v14 v12
            v15
    if v16 then
        let v17 : (struct (Guid * int32) []) = v1 ()
        let v18 : US4 = US4_2
        let v19 : ((obj []) -> unit) = v5 v18
        let v20 : string = "> use_fetch > on_value > set ()"
        let v21 : obj = v20
        let v22 : string = "old_value:"
        let v23 : obj = struct (v22, v17)
        let v28 : string =
            match v6 with
            | US2_0 -> (* GunJsClient *)
                let v24 : string = "Gun JavaScript"
                v24
            | US2_1 -> (* GunRsClient *)
                let v25 : string = "Gun Rust"
                v25
            | US2_2 -> (* Memory *)
                let v26 : string = "Memory"
                v26
            | US2_3 -> (* SignalRClient *)
                let v27 : string = "SignalR"
                v27
        let v29 : string = "client_type:"
        let v30 : obj = struct (v29, v28)
        let v31 : string = "new_guid':"
        let v32 : obj = struct (v31, v9)
        let v33 : string = "new_value_raw:"
        let v34 : obj = struct (v33, v8)
        let v35 : (obj []) = [|v21; v23; v30; v32; v34|]
        v19 v35
        v2 struct (v17, v6, v9, v8)
        let v36 : US16 = US16_1(v6, v9, v8)
        v3 v36
        let v37 : int32 = v7.Length
        let v38 : Mut6 = {l0 = 0} : Mut6
        while method21(v37, v38) do
            let v40 : int32 = v38.l0
            let struct (v41 : US2, v42 : obj, v43 : string) = v7.[int v40]
            let v44 : bool =
                match v41, v6 with
                | US2_0, US2_0 -> (* GunJsClient *)
                    true
                | US2_1, US2_1 -> (* GunRsClient *)
                    true
                | US2_2, US2_2 -> (* Memory *)
                    true
                | US2_3, US2_3 -> (* SignalRClient *)
                    true
                | _ ->
                    false
            let v45 : bool = v44 <> true
            if v45 then
                let v46 : US4 = US4_2
                let v47 : ((obj []) -> unit) = v5 v46
                let v48 : string = "> use_fetch > on_value > set () > db_put"
                let v49 : obj = v48
                let v50 : obj = struct (v22, v17)
                let v55 : string =
                    match v6 with
                    | US2_0 -> (* GunJsClient *)
                        let v51 : string = "Gun JavaScript"
                        v51
                    | US2_1 -> (* GunRsClient *)
                        let v52 : string = "Gun Rust"
                        v52
                    | US2_2 -> (* Memory *)
                        let v53 : string = "Memory"
                        v53
                    | US2_3 -> (* SignalRClient *)
                        let v54 : string = "SignalR"
                        v54
                let v56 : obj = struct (v29, v55)
                let v57 : obj = struct (v31, v9)
                let v58 : obj = struct (v33, v8)
                let v63 : string =
                    match v41 with
                    | US2_0 -> (* GunJsClient *)
                        let v59 : string = "Gun JavaScript"
                        v59
                    | US2_1 -> (* GunRsClient *)
                        let v60 : string = "Gun Rust"
                        v60
                    | US2_2 -> (* Memory *)
                        let v61 : string = "Memory"
                        v61
                    | US2_3 -> (* SignalRClient *)
                        let v62 : string = "SignalR"
                        v62
                let v64 : string = "connection_client_type:"
                let v65 : obj = struct (v64, v63)
                let v66 : (obj []) = [|v49; v50; v56; v57; v58; v65|]
                v47 v66
                match v41 with
                | US2_0 -> (* GunJsClient *)
                    let v67 : (string []) = v0.Split [| '/' |]
                    let v68 : (string -> obj) = v42?get
                    let v69 : string = "tictactoe_spiral"
                    let v70 : obj = v68 v69
                    let v71 : int32 = v67.Length
                    let v72 : Mut27 = {l0 = 0; l1 = v70} : Mut27
                    while method81(v71, v72) do
                        let v74 : int32 = v72.l0
                        let v75 : obj = v72.l1
                        let v76 : string = v67.[int v74]
                        let v77 : (string -> obj) = v75?get
                        let v78 : obj = v77 v76
                        let v79 : int32 = v74 + 1
                        v72.l0 <- v79
                        v72.l1 <- v78
                        ()
                    let v80 : obj = v72.l1
                    v80?put v8
                    ()
                | US2_1 -> (* GunRsClient *)
                    let v81 : (string []) = v0.Split [| '/' |]
                    let v82 : (string -> obj) = v42?get
                    let v83 : string = "tictactoe_spiral"
                    let v84 : obj = v82 v83
                    let v85 : int32 = v81.Length
                    let v86 : Mut27 = {l0 = 0; l1 = v84} : Mut27
                    while method81(v85, v86) do
                        let v88 : int32 = v86.l0
                        let v89 : obj = v86.l1
                        let v90 : string = v81.[int v88]
                        let v91 : (string -> obj) = v89?get
                        let v92 : obj = v91 v90
                        let v93 : int32 = v88 + 1
                        v86.l0 <- v93
                        v86.l1 <- v92
                        ()
                    let v94 : obj = v86.l1
                    v94?put v8
                    ()
                | US2_2 -> (* Memory *)
                    failwith<unit> "db_on Memory"
                | US2_3 -> (* SignalRClient *)
                    let v95 : string = v8.ToString ()
                    let v96 : string = "alias"
                    let v97 : UH1 = UH1_3(v96, v0, v95)
                    let v98 : obj = v97
                    let v99 : string = "send"
                    (v42?invoke : JS.Function).Invoke ($"{v99}", v98) |> ignore
                    ()
            let v100 : int32 = v40 + 1
            v38.l0 <- v100
            ()
        ()
and method79 (v0 : string, v1 : (unit -> (struct (Guid * int32) [])), v2 : (struct ((struct (Guid * int32) []) * US2 * Guid * int32) -> unit), v3 : (US16 -> unit), v4 : (unit -> US16), v5 : (US4 -> ((obj []) -> unit)), v6 : US2, v7 : (struct (US2 * obj * string) []), v8 : (US4 -> ((obj []) -> unit)), v9 : Guid, v10 : int32, v11 : obj) : unit =
    let v12 : US4 = US4_2
    let v13 : ((obj []) -> unit) = v8 v12
    let v14 : string = "> db_on > on_value ()"
    let v15 : obj = v14
    let v16 : string = "v:"
    let v17 : obj = struct (v16, v9, v10)
    let v18 : string = "k:"
    let v19 : obj = struct (v18, v11)
    let v20 : (obj []) = [|v15; v17; v19|]
    v13 v20
    method80(v0, v1, v2, v3, v4, v5, v6, v7, v10, v9)
and closure286 (v0 : string, v1 : (unit -> (struct (Guid * int32) [])), v2 : (struct ((struct (Guid * int32) []) * US2 * Guid * int32) -> unit), v3 : (US16 -> unit), v4 : (unit -> US16), v5 : (US4 -> ((obj []) -> unit)), v6 : US2, v7 : (struct (US2 * obj * string) []), v8 : (US4 -> ((obj []) -> unit)), v9 : Guid, v10 : int32) (v11 : obj) : unit =
    method79(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure285 (v0 : string, v1 : (unit -> (struct (Guid * int32) [])), v2 : (struct ((struct (Guid * int32) []) * US2 * Guid * int32) -> unit), v3 : (US16 -> unit), v4 : (unit -> US16), v5 : (US4 -> ((obj []) -> unit)), v6 : US2, v7 : (struct (US2 * obj * string) []), v8 : (US4 -> ((obj []) -> unit))) struct (v9 : Guid, v10 : int32) : (obj -> unit) =
    closure286(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
and closure288 (v0 : (US4 -> ((obj []) -> unit))) (v1 : obj) : unit =
    let v2 : US4 = US4_2
    let v3 : ((obj []) -> unit) = v0 v2
    let v4 : string = "> db_on > signalr on_value ()"
    let v5 : obj = v4
    let v6 : string = "_msg:"
    let v7 : obj = struct (v6, v1)
    let v8 : (obj []) = [|v5; v7|]
    v3 v8
    ()
and method82 (v0 : (struct (US2 * string) []), v1 : (struct (US2 * string) []), v2 : int32) : bool =
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
            | US2_3, US2_3 -> (* SignalRClient *)
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
            method82(v0, v1, v12)
        else
            false
    else
        true
and closure283 (v0 : string, v1 : (unit -> US4), v2 : ((struct (US2 * int64 * string) []) -> unit), v3 : (unit -> (struct (US2 * int64 * string) [])), v4 : (US4 -> ((obj []) -> unit)), v5 : (unit -> (struct (Guid * int32) [])), v6 : (struct ((struct (Guid * int32) []) * US2 * Guid * int32) -> unit), v7 : (US16 -> unit), v8 : (unit -> US16)) (v9 : (struct (US2 * obj * string) [])) : unit =
    let v10 : (struct (US2 * int64 * string) []) = v3 ()
    let v11 : int32 = v9.Length
    let v12 : (struct (US2 * int64 * string) []) = Array.zeroCreate<struct (US2 * int64 * string)> (v11)
    let v13 : Mut6 = {l0 = 0} : Mut6
    while method21(v11, v13) do
        let v15 : int32 = v13.l0
        let struct (v16 : US2, v17 : obj, v18 : string) = v9.[int v15]
        let v19 : int32 = v10.Length
        let v20 : US17 = US17_0
        let v21 : Mut26 = {l0 = 0; l1 = v20} : Mut26
        while method78(v19, v21) do
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
                        | US2_3, US2_3 -> (* SignalRClient *)
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
        let struct (v91 : US2, v92 : int64, v93 : string) =
            match v42 with
            | US17_0 -> (* None *)
                let v43 : (unit -> (obj [])) = closure284(v0, v16)
                let v44 : string = "#666"
                let v45 : (US4 -> ((obj []) -> unit)) = method17(v1, v43, v44)
                let v46 : US4 = US4_0
                let v47 : ((obj []) -> unit) = v45 v46
                let v48 : string = "> db_on ()"
                let v49 : obj = v48
                let v50 : (obj []) = [|v49|]
                v47 v50
                let v51 : (struct (Guid * int32) -> (obj -> unit)) = closure285(v0, v5, v6, v7, v8, v4, v16, v9, v45)
                let v52 : (struct (obj * int32) -> unit) = emitJsExpr () $"(v: any, k: any) => {v51}(v)(k)"
                let v87 : int64 =
                    match v16 with
                    | US2_0 -> (* GunJsClient *)
                        let v53 : (string []) = v0.Split [| '/' |]
                        let v54 : (string -> obj) = v17?get
                        let v55 : string = "tictactoe_spiral"
                        let v56 : obj = v54 v55
                        let v57 : int32 = v53.Length
                        let v58 : Mut27 = {l0 = 0; l1 = v56} : Mut27
                        while method81(v57, v58) do
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
                        v66?on v52
                        let v67 : int64 = DateTime.UtcNow.Ticks
                        v67
                    | US2_1 -> (* GunRsClient *)
                        let v68 : (string []) = v0.Split [| '/' |]
                        let v69 : (string -> obj) = v17?get
                        let v70 : string = "tictactoe_spiral"
                        let v71 : obj = v69 v70
                        let v72 : int32 = v68.Length
                        let v73 : Mut27 = {l0 = 0; l1 = v71} : Mut27
                        while method81(v72, v73) do
                            let v75 : int32 = v73.l0
                            let v76 : obj = v73.l1
                            let v77 : string = v68.[int v75]
                            let v78 : (string -> obj) = v76?get
                            let v79 : obj = v78 v77
                            let v80 : int32 = v75 + 1
                            v73.l0 <- v80
                            v73.l1 <- v79
                            ()
                        let v81 : obj = v73.l1
                        let v82 : int64 = v81?on v52
                        v82
                    | US2_2 -> (* Memory *)
                        failwith<int64> "db_on Memory"
                    | US2_3 -> (* SignalRClient *)
                        let v84 : string = "send"
                        let v85 : (obj -> unit) = closure288(v45)
                        (v17?on : JS.Function).Invoke ($"{v84}", v85) |> ignore
                        let v86 : int64 = DateTime.UtcNow.Ticks
                        v86
                struct (v16, v87, v18)
            | US17_1(v88, v89, v90) -> (* Some *)
                struct (v88, v89, v90)
        v12.[int v15] <- struct (v91, v92, v93)
        let v94 : int32 = v15 + 1
        v13.l0 <- v94
        ()
    let v95 : int32 = v10.Length
    let v96 : (struct (US2 * string) []) = Array.zeroCreate<struct (US2 * string)> (v95)
    let v97 : Mut6 = {l0 = 0} : Mut6
    while method21(v95, v97) do
        let v99 : int32 = v97.l0
        let struct (v100 : US2, v101 : int64, v102 : string) = v10.[int v99]
        v96.[int v99] <- struct (v100, v102)
        let v103 : int32 = v99 + 1
        v97.l0 <- v103
        ()
    let v104 : int32 = v12.Length
    let v105 : (struct (US2 * string) []) = Array.zeroCreate<struct (US2 * string)> (v104)
    let v106 : Mut6 = {l0 = 0} : Mut6
    while method21(v104, v106) do
        let v108 : int32 = v106.l0
        let struct (v109 : US2, v110 : int64, v111 : string) = v12.[int v108]
        v105.[int v108] <- struct (v109, v111)
        let v112 : int32 = v108 + 1
        v106.l0 <- v112
        ()
    let v113 : int32 = v96.Length
    let v114 : int32 = v105.Length
    let v115 : bool = v113 = v114
    let v116 : bool = v115 <> true
    let v119 : bool =
        if v116 then
            false
        else
            let v117 : int32 = 0
            method82(v96, v105, v117)
    let v120 : bool = v119 <> true
    if v120 then
        let v121 : US4 = US4_2
        let v122 : ((obj []) -> unit) = v4 v121
        let v123 : string = "> use_fetch > connections_change"
        let v124 : obj = v123
        let v125 : (struct (string * int64) []) = Array.zeroCreate<struct (string * int64)> (v104)
        let v126 : Mut6 = {l0 = 0} : Mut6
        while method21(v104, v126) do
            let v128 : int32 = v126.l0
            let struct (v129 : US2, v130 : int64, v131 : string) = v12.[int v128]
            let v136 : string =
                match v129 with
                | US2_0 -> (* GunJsClient *)
                    let v132 : string = "Gun JavaScript"
                    v132
                | US2_1 -> (* GunRsClient *)
                    let v133 : string = "Gun Rust"
                    v133
                | US2_2 -> (* Memory *)
                    let v134 : string = "Memory"
                    v134
                | US2_3 -> (* SignalRClient *)
                    let v135 : string = "SignalR"
                    v135
            v125.[int v128] <- struct (v136, v130)
            let v137 : int32 = v128 + 1
            v126.l0 <- v137
            ()
        let v138 : string = "new_subscriptions:"
        let v139 : obj = struct (v138, v125)
        let v140 : (obj []) = [|v124; v139|]
        v122 v140
        v2 v12
        ()
and closure289 (v0 : (unit -> (struct (US2 * obj * string) [])), v1 : ((struct (US2 * obj * string) []) -> unit)) () : unit =
    let v2 : (struct (US2 * obj * string) []) = v0 ()
    v1 v2
    ()
and closure290 (v0 : ((struct (US2 * obj * string) []) -> unit), v1 : string, v2 : (US4 -> ((obj []) -> unit))) () : unit =
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
and closure292 (v0 : string, v1 : (unit -> (struct (Guid * int32) [])), v2 : (struct ((struct (Guid * int32) []) * US2 * Guid * int32) -> unit), v3 : (US16 -> unit), v4 : (unit -> US16), v5 : (US4 -> ((obj []) -> unit)), v6 : (struct (US2 * obj * string) []), v7 : Guid) (v8 : int32) : unit =
    let v9 : US2 = US2_2
    method80(v0, v1, v2, v3, v4, v5, v9, v6, v8, v7)
and closure291 (v0 : (obj -> JS.Promise<int32>), v1 : (unit -> (struct (US2 * obj * string) [])), v2 : string, v3 : (unit -> (struct (Guid * int32) [])), v4 : (struct ((struct (Guid * int32) []) * US2 * Guid * int32) -> unit), v5 : (US16 -> unit), v6 : (unit -> US16), v7 : (US4 -> ((obj []) -> unit))) () : unit =
    let v8 : (struct (US2 * obj * string) []) = v1 ()
    let v9 : int64 = DateTime.UtcNow.Ticks
    let v10 : Guid = Guid.NewGuid ()
    let v11 : string = v10.ToString ()
    let v12 : string = v9.ToString ()
    let v13 : Guid = Guid $"{v12.[0..7]}-{v12.[8..11]}-{v12.[12..15]}-{v12.[16..17]}{v11.[21..]}"
    let v14 : obj = ()
    let v15 : JS.Promise<int32> = v0 v14
    let v16 : (int32 -> unit) = closure292(v2, v3, v4, v5, v6, v7, v8, v13)
    v15 |> Promise.iter v16
    ()
and closure293 (v0 : (unit -> (struct (US2 * obj * string) [])), v1 : (US4 -> ((obj []) -> unit)), v2 : string, v3 : (unit -> (struct (Guid * int32) [])), v4 : (struct ((struct (Guid * int32) []) * US2 * Guid * int32) -> unit), v5 : (US16 -> unit), v6 : (unit -> US16)) () : unit =
    let v7 : US4 = US4_2
    let v8 : ((obj []) -> unit) = v1 v7
    let v9 : string = ">> use_fetch clear ()"
    let v10 : obj = v9
    let v11 : (obj []) = [|v10|]
    v8 v11
    let v12 : (struct (US2 * obj * string) []) = v0 ()
    let v13 : int64 = DateTime.UtcNow.Ticks
    let v14 : Guid = Guid.NewGuid ()
    let v15 : string = v14.ToString ()
    let v16 : string = v13.ToString ()
    let v17 : Guid = Guid $"{v16.[0..7]}-{v16.[8..11]}-{v16.[12..15]}-{v16.[16..17]}{v15.[21..]}"
    let v18 : US2 = US2_2
    let v19 : int32 = emitJsExpr () "null"
    method80(v2, v3, v4, v5, v6, v1, v18, v12, v19, v17)
and method74 (v0 : string, v1 : (unit -> (struct (Guid * int32) [])), v2 : (struct ((struct (Guid * int32) []) * US2 * Guid * int32) -> unit), v3 : (obj -> JS.Promise<int32>)) : struct ((unit -> unit) * (unit -> unit)) =
    let v112 : obj = emitJsExpr () "components_spi.state_context"
    let v113 : string = "useContext"
    let v114 : string = "solid-js"
    let v115 : JS.Function = import v113 v114
    let struct (v116 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v117 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v118 : (unit -> int32), v119 : (int32 -> unit), v120 : (unit -> string), v121 : (string -> unit), v122 : (unit -> string), v123 : (string -> unit), v124 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v125 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v126 : (unit -> (struct (US2 * obj * string) [])), v127 : ((struct (US2 * obj * string) []) -> unit), v128 : (unit -> (struct (Guid * obj) [])), v129 : ((struct (Guid * obj) []) -> unit), v130 : (unit -> (struct (Guid * obj) [])), v131 : ((struct (Guid * obj) []) -> unit), v132 : (unit -> (struct (Guid * int32) [])), v133 : ((struct (Guid * int32) []) -> unit), v134 : (unit -> US4), v135 : (US4 -> unit), v136 : (unit -> US5), v137 : (US5 -> unit)) = v115.Invoke v112 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v246 : obj = emitJsExpr () "components_spi.state_context"
    let v247 : JS.Function = import v113 v114
    let struct (v248 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v249 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v250 : (unit -> int32), v251 : (int32 -> unit), v252 : (unit -> string), v253 : (string -> unit), v254 : (unit -> string), v255 : (string -> unit), v256 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v257 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v258 : (unit -> (struct (US2 * obj * string) [])), v259 : ((struct (US2 * obj * string) []) -> unit), v260 : (unit -> (struct (Guid * obj) [])), v261 : ((struct (Guid * obj) []) -> unit), v262 : (unit -> (struct (Guid * obj) [])), v263 : ((struct (Guid * obj) []) -> unit), v264 : (unit -> (struct (Guid * int32) [])), v265 : ((struct (Guid * int32) []) -> unit), v266 : (unit -> US4), v267 : (US4 -> unit), v268 : (unit -> US5), v269 : (US5 -> unit)) = v247.Invoke v246 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let struct (v270 : (unit -> unit), v271 : (unit -> unit)) = method75()
    let struct (v272 : (unit -> unit), v273 : (unit -> unit)) = method75()
    let v274 : US16 = US16_0
    let struct (v275 : (unit -> US16), v276 : (US16 -> unit)) = method76(v274)
    let v277 : (struct (US2 * int64 * string) []) = [||]
    let struct (v278 : (unit -> (struct (US2 * int64 * string) [])), v279 : ((struct (US2 * int64 * string) []) -> unit)) = method77(v277)
    let v280 : (uint8 []) = System.Text.Encoding.UTF8.GetBytes v0
    let v281 : int32 = v280.Length
    let v282 : Mut25 = {l0 = 0; l1 = 100000} : Mut25
    while method71(v281, v282) do
        let v284 : int32 = v282.l0
        let v285 : int32 = v282.l1
        let v286 : uint8 = v280.[int v284]
        let v287 : int32 = v286 |> unbox<int32>
        let v288 : int32 = v287 * 14
        let v289 : int32 = v285 + v288
        let v290 : int32 = v284 + 1
        v282.l0 <- v290
        v282.l1 <- v289
        ()
    let v291 : int32 = v282.l1
    let v292 : string = v291.ToString ()
    let v293 : string = $"#{v292}"
    let v294 : (unit -> (obj [])) = closure282(v0, v1, v258, v270, v272, v275, v278)
    let v295 : (US4 -> ((obj []) -> unit)) = method16(v294, v293)
    let v296 : US4 = US4_0
    let v297 : ((obj []) -> unit) = v295 v296
    let v298 : string = "> use_fetch ()"
    let v299 : obj = v298
    let v300 : (obj []) = [|v299|]
    v297 v300
    let v301 : string = "debounce"
    let v302 : string = "@solid-primitives/scheduled"
    let v303 : JS.Function = import v301 v302
    let v304 : ((struct (US2 * obj * string) []) -> unit) = closure283(v0, v134, v279, v278, v295, v1, v2, v276, v275)
    let v305 : ((struct (US2 * obj * string) []) -> unit) = v303.Invoke (v304, 2500) |> unbox<(struct (US2 * obj * string) []) -> unit>
    let v306 : string = "createEffect"
    let v307 : JS.Function = import v306 v114
    let v308 : (unit -> unit) = closure289(v258, v305)
    v307.Invoke v308 |> ignore
    let v309 : string = "onCleanup"
    let v310 : JS.Function = import v309 v114
    let v311 : (unit -> unit) = closure290(v305, v0, v295)
    v310.Invoke v311 |> ignore
    let v312 : (unit -> unit) = closure291(v3, v258, v0, v1, v2, v276, v275, v295)
    let v313 : (unit -> unit) = closure293(v258, v295, v0, v1, v2, v276, v275)
    struct (v312, v313)
and closure295 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "center"
    let v71 : string = "baseline"
    let v72 : string = method13(v71, v70)
    let v73 : string = "row"
    let v74 : string = "column"
    let v75 : string = method13(v74, v73)
    let v76 : string = "0"
    let v77 : string = "8px"
    let v78 : string = method13(v77, v76)
    let v79 : US6 = US6_1(v72)
    let v80 : US6 = US6_1(v75)
    let v81 : US6 = US6_1(v78)
    let v82 : string = "3px"
    let v83 : US6 = US6_1(v82)
    let v84 : string = "7px"
    let v85 : US6 = US6_1(v84)
    struct (v79, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v80, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v81, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v83, v49, v50, v51, v52, v53, v54, v55, v56, v85, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure297 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure298 () () : (JSX.Element []) =
    let v0 : string = "Counter"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure300 () () : JS.Function =
    let v0 : string = "BiRegularPlus"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure301 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v70, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure299 (v0 : (unit -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (Mut7 -> JSX.Element) = closure60()
    let v72 : (unit -> JS.Function) = closure300()
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure301()
    let v75 : JSX.Element = method48(v71, v72, v73, v74)
    let v76 : US11 = US11_1(v75)
    let v77 : US13 = US13_1(v0)
    let v78 : string = "10px"
    let v79 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v76, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v77, v44, v45, v46, v47, v48, v49, v50, v51, v79, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure302 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure304 () () : JS.Function =
    let v0 : string = "BiRegularMinus"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure305 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v70, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure303 (v0 : (unit -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (Mut7 -> JSX.Element) = closure60()
    let v72 : (unit -> JS.Function) = closure304()
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure305()
    let v75 : JSX.Element = method48(v71, v72, v73, v74)
    let v76 : US11 = US11_1(v75)
    let v77 : US13 = US13_1(v0)
    let v78 : string = "10px"
    let v79 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v76, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v77, v44, v45, v46, v47, v48, v49, v50, v51, v79, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure306 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure296 (v0 : (unit -> unit), v1 : (unit -> unit)) () : (JSX.Element []) =
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/core"
    let v4 : JS.Function = import v2 v3
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure297()
    let v6 : (unit -> (JSX.Element [])) = closure298()
    let v7 : JSX.Element = method5(v4, v5, v6)
    let v8 : (Mut1 -> JSX.Element) = closure47()
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure299(v1)
    let v10 : (unit -> (JSX.Element [])) = closure302()
    let v11 : JSX.Element = method22(v8, v9, v10)
    let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure303(v0)
    let v13 : (unit -> (JSX.Element [])) = closure306()
    let v14 : JSX.Element = method22(v8, v12, v13)
    [|v7; v11; v14|]
and method83 (v0 : int32, v1 : Mut28) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method84 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH2 = UH2_0(v2, v3, v1)
        method84(v4, v5)
    | UH2_1 -> (* Nil *)
        v1
and method86 (v0 : UH2, v1 : int32) : int32 =
    match v0 with
    | UH2_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method86(v4, v5)
    | UH2_1 -> (* Nil *)
        v1
and method87 (v0 : (struct (Guid * int32) []), v1 : UH2, v2 : int32) : int32 =
    match v1 with
    | UH2_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method87(v0, v5, v6)
    | UH2_1 -> (* Nil *)
        v2
and method85 (v0 : UH2) : (struct (Guid * int32) []) =
    let v1 : int32 = 0
    let v2 : int32 = method86(v0, v1)
    let v3 : (struct (Guid * int32) []) = Array.zeroCreate<struct (Guid * int32)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method87(v3, v0, v4)
    v3
and closure313 (v0 : int32, v1 : int32) () : (JSX.Element []) =
    let v2 : string = emitJsExpr v1 "JSON.stringify($0, null, 2)"
    let v3 : string = $"[{v0}={v2}]"
    let v4 : JSX.Element = v3 |> unbox<JSX.Element>
    let v5 : JSX.Element = Html.fragment [ v4 ]
    [|v5|]
and closure312 (v0 : int32, v1 : int32) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure313(v0, v1)
    let v8 : JSX.Element = method5(v5, v6, v7)
    [|v8|]
and closure311 (v0 : int32, v1 : int32, v2 : Guid) struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US6, v19 : US6, v20 : US6, v21 : US10, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US11, v30 : US6, v31 : US6, v32 : US6, v33 : US11, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US12, v45 : US13, v46 : US12, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US14, v64 : US6, v65 : US11, v66 : US6, v67 : US6, v68 : US14, v69 : US14, v70 : US6, v71 : US5, v72 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v73 : string = v2.ToString ()
    let v74 : JSX.Element = v73 |> unbox<JSX.Element>
    let v75 : JSX.Element = Html.fragment [ v74 ]
    let v76 : (unit -> (JSX.Element [])) = closure312(v0, v1)
    let v77 : US9 = US9_1(v76)
    let v78 : string = "3px"
    let v79 : US6 = US6_1(v78)
    let v80 : US11 = US11_1(v75)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v77, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v79, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v80, v66, v67, v68, v69, v70, v71, v72)
and closure310 (v0 : (unit -> struct (Guid * int32))) (v1 : int32) : (JSX.Element []) =
    let struct (v2 : Guid, v3 : int32) = v0 ()
    let v4 : (Mut3 -> JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure311(v1, v3, v2)
    let v8 : US15 = US15_2
    let v9 : JSX.Element = method26(v4, v5, v6, v7, v8)
    [|v9|]
and closure309 () (v0 : (unit -> struct (Guid * int32))) : (int32 -> (JSX.Element [])) =
    closure310(v0)
and closure314 (v0 : (struct (Guid * int32) [])) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (obj []) = v0 |> unbox<(obj [])>
    let v72 : US10 = US10_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v72, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure308 (v0 : (unit -> (struct (Guid * int32) []))) () : (JSX.Element []) =
    let v1 : (struct (Guid * int32) []) = v0 ()
    let v2 : int32 = v1.Length
    let v3 : UH2 = UH2_1
    let v4 : Mut28 = {l0 = 0; l1 = v3} : Mut28
    while method83(v2, v4) do
        let v6 : int32 = v4.l0
        let v7 : int32 =  -v6
        let v8 : int32 = v7 + v2
        let v9 : int32 = v8 - 1
        let v10 : UH2 = v4.l1
        let struct (v11 : Guid, v12 : int32) = v1.[int v9]
        let v13 : int32 = v6 + 1
        let v14 : UH2 = UH2_0(v11, v12, v10)
        v4.l0 <- v13
        v4.l1 <- v14
        ()
    let v15 : UH2 = v4.l1
    let v16 : UH2 = UH2_1
    let v17 : UH2 = method84(v15, v16)
    let v18 : (struct (Guid * int32) []) = method85(v17)
    let v19 : ((unit -> struct (Guid * int32)) -> (int32 -> (JSX.Element []))) = closure309()
    let v20 : (unit -> (JSX.Element [])) = emitJsExpr () $"(item: any, index: () => number) => {v19}(item)(index)"
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : JS.Function = import v21 v22
    let v24 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure314(v18)
    let v25 : JSX.Element = method5(v23, v24, v20)
    [|v25|]
and closure307 (v0 : (unit -> (struct (Guid * int32) []))) () : (JSX.Element []) =
    let v1 : (Mut1 -> JSX.Element) = closure7()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v3 : (unit -> (JSX.Element [])) = closure308(v0)
    let v4 : JSX.Element = method22(v1, v2, v3)
    [|v4|]
and closure294 (v0 : (unit -> (struct (Guid * int32) [])), v1 : (unit -> unit), v2 : (unit -> unit)) struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US6, v19 : US6, v20 : US6, v21 : US10, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US11, v30 : US6, v31 : US6, v32 : US6, v33 : US11, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US12, v45 : US13, v46 : US12, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US14, v64 : US6, v65 : US11, v66 : US6, v67 : US6, v68 : US14, v69 : US14, v70 : US6, v71 : US5, v72 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v73 : string = "Stack"
    let v74 : string = "@hope-ui/core"
    let v75 : JS.Function = import v73 v74
    let v76 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure295()
    let v77 : (unit -> (JSX.Element [])) = closure296(v1, v2)
    let v78 : JSX.Element = method5(v75, v76, v77)
    let v79 : (unit -> (JSX.Element [])) = closure307(v0)
    let v80 : US9 = US9_1(v79)
    let v81 : string = "counter"
    let v82 : US6 = US6_1(v81)
    let v83 : US11 = US11_1(v78)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v80, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v82, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v83, v66, v67, v68, v69, v70, v71, v72)
and method73 () : JSX.Element =
    let v108 : obj = emitJsExpr () "components_spi.state_context"
    let v109 : string = "useContext"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let struct (v112 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v113 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v114 : (unit -> int32), v115 : (int32 -> unit), v116 : (unit -> string), v117 : (string -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v121 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v122 : (unit -> (struct (US2 * obj * string) [])), v123 : ((struct (US2 * obj * string) []) -> unit), v124 : (unit -> (struct (Guid * obj) [])), v125 : ((struct (Guid * obj) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * int32) [])), v129 : ((struct (Guid * int32) []) -> unit), v130 : (unit -> US4), v131 : (US4 -> unit), v132 : (unit -> US5), v133 : (US5 -> unit)) = v111.Invoke v108 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v134 : (unit -> (obj [])) = closure276(v128)
    let v135 : string = "#666"
    let v136 : (US4 -> ((obj []) -> unit)) = method16(v134, v135)
    let v137 : US4 = US4_0
    let v138 : ((obj []) -> unit) = v136 v137
    let v139 : string = "> counter ()"
    let v140 : obj = v139
    let v141 : (obj []) = [|v140|]
    v138 v141
    let v142 : string = "createEffect"
    let v143 : JS.Function = import v142 v110
    let v144 : (unit -> unit) = closure277(v136)
    v143.Invoke v144 |> ignore
    let v145 : string = "profile/tmp/counter"
    let v146 : (struct ((struct (Guid * int32) []) * US2 * Guid * int32) -> unit) = closure278(v129)
    let v147 : (obj -> JS.Promise<int32>) = closure279(v128)
    let struct (v148 : (unit -> unit), v149 : (unit -> unit)) = method74(v145, v128, v146, v147)
    let v150 : (Mut3 -> JSX.Element) = closure14()
    let v151 : US13 = US13_0
    let v152 : US13 = US13_0
    let v153 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure294(v128, v149, v148)
    let v154 : US15 = US15_2
    method26(v150, v151, v152, v153, v154)
and closure275 () (v0 : Mut1) : JSX.Element =
    method73()
and closure315 () () : (JSX.Element []) =
    [||]
and closure317 (v0 : ((struct (Guid * obj) []) -> unit)) struct (v1 : (struct (Guid * obj) []), v2 : US2, v3 : Guid, v4 : (struct (Guid * obj) [])) : unit =
    v0 v4
    ()
and closure320 (v0 : (unit -> (struct (Guid * obj) [])), v1 : ((struct (Guid * obj) []) -> unit)) (v2 : (exn -> unit)) : unit =
    let v3 : (struct (Guid * obj) []) = v0 ()
    v1 v3
    ()
and closure319 (v0 : (unit -> (struct (Guid * obj) []))) (v1 : ((struct (Guid * obj) []) -> unit)) : ((exn -> unit) -> unit) =
    closure320(v0, v1)
and closure318 (v0 : (unit -> (struct (Guid * obj) []))) (v1 : obj) : JS.Promise<(struct (Guid * obj) [])> =
    let v2 : (((struct (Guid * obj) []) -> unit) -> ((exn -> unit) -> unit)) = closure319(v0)
    let v3 : JS.Promise<(struct (Guid * obj) [])> = Promise.create v2
    v3
and method90 (v0 : US18) : struct ((unit -> US18) * (US18 -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke v0 |> unbox<JS.Function[]>
    let v5 : (unit -> US18) = v4.[0] |> unbox<unit -> US18>
    let v6 : (US18 -> unit) = v4.[1] |> unbox<US18 -> unit>
    struct (v5, v6)
and closure321 (v0 : string, v1 : (unit -> (struct (Guid * obj) [])), v2 : (unit -> (struct (US2 * obj * string) [])), v3 : (unit -> unit), v4 : (unit -> unit), v5 : (unit -> US18), v6 : (unit -> (struct (US2 * int64 * string) []))) () : (obj []) =
    let v7 : string = "content_address:"
    let v8 : obj = struct (v7, v0)
    let v9 : (struct (Guid * obj) []) = v1 ()
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
    let v21 : (struct (string * int64) []) = Array.zeroCreate<struct (string * int64)> (v20)
    let v22 : Mut6 = {l0 = 0} : Mut6
    while method21(v20, v22) do
        let v24 : int32 = v22.l0
        let struct (v25 : US2, v26 : int64, v27 : string) = v19.[int v24]
        let v32 : string =
            match v25 with
            | US2_0 -> (* GunJsClient *)
                let v28 : string = "Gun JavaScript"
                v28
            | US2_1 -> (* GunRsClient *)
                let v29 : string = "Gun Rust"
                v29
            | US2_2 -> (* Memory *)
                let v30 : string = "Memory"
                v30
            | US2_3 -> (* SignalRClient *)
                let v31 : string = "SignalR"
                v31
        v21.[int v24] <- struct (v32, v26)
        let v33 : int32 = v24 + 1
        v22.l0 <- v33
        ()
    let v34 : string = "subscriptions:"
    let v35 : obj = struct (v34, v21)
    let v36 : (struct (US2 * obj * string) []) = v2 ()
    let v37 : int32 = v36.Length
    let v38 : (string []) = Array.zeroCreate<string> (v37)
    let v39 : Mut6 = {l0 = 0} : Mut6
    while method21(v37, v39) do
        let v41 : int32 = v39.l0
        let struct (v42 : US2, v43 : obj, v44 : string) = v36.[int v41]
        let v49 : string =
            match v42 with
            | US2_0 -> (* GunJsClient *)
                let v45 : string = "Gun JavaScript"
                v45
            | US2_1 -> (* GunRsClient *)
                let v46 : string = "Gun Rust"
                v46
            | US2_2 -> (* Memory *)
                let v47 : string = "Memory"
                v47
            | US2_3 -> (* SignalRClient *)
                let v48 : string = "SignalR"
                v48
        v38.[int v41] <- v49
        let v50 : int32 = v41 + 1
        v39.l0 <- v50
        ()
    let v51 : string = "db_connections:"
    let v52 : obj = struct (v51, v38)
    [|v8; v11; v13; v15; v18; v35; v52|]
and method92 (v0 : string, v1 : (unit -> (struct (Guid * obj) [])), v2 : (struct ((struct (Guid * obj) []) * US2 * Guid * (struct (Guid * obj) [])) -> unit), v3 : (US18 -> unit), v4 : (unit -> US18), v5 : (US4 -> ((obj []) -> unit)), v6 : US2, v7 : (struct (US2 * obj * string) []), v8 : (struct (Guid * obj) []), v9 : Guid) : unit =
    let v10 : US18 = v4 ()
    let v16 : bool =
        match v10 with
        | US18_0 -> (* None *)
            true
        | US18_1(v11, v12, v13) -> (* Some *)
            let v14 : (Guid -> int64) = closure287()
            let v15 : bool = v13 <> v8 && v14 v9 > v14 v12
            v15
    if v16 then
        let v17 : (struct (Guid * obj) []) = v1 ()
        let v18 : US4 = US4_2
        let v19 : ((obj []) -> unit) = v5 v18
        let v20 : string = "> use_fetch > on_value > set ()"
        let v21 : obj = v20
        let v22 : string = "old_value:"
        let v23 : obj = struct (v22, v17)
        let v28 : string =
            match v6 with
            | US2_0 -> (* GunJsClient *)
                let v24 : string = "Gun JavaScript"
                v24
            | US2_1 -> (* GunRsClient *)
                let v25 : string = "Gun Rust"
                v25
            | US2_2 -> (* Memory *)
                let v26 : string = "Memory"
                v26
            | US2_3 -> (* SignalRClient *)
                let v27 : string = "SignalR"
                v27
        let v29 : string = "client_type:"
        let v30 : obj = struct (v29, v28)
        let v31 : string = "new_guid':"
        let v32 : obj = struct (v31, v9)
        let v33 : string = "new_value_raw:"
        let v34 : obj = struct (v33, v8)
        let v35 : (obj []) = [|v21; v23; v30; v32; v34|]
        v19 v35
        v2 struct (v17, v6, v9, v8)
        let v36 : US18 = US18_1(v6, v9, v8)
        v3 v36
        let v37 : int32 = v7.Length
        let v38 : Mut6 = {l0 = 0} : Mut6
        while method21(v37, v38) do
            let v40 : int32 = v38.l0
            let struct (v41 : US2, v42 : obj, v43 : string) = v7.[int v40]
            let v44 : bool =
                match v41, v6 with
                | US2_0, US2_0 -> (* GunJsClient *)
                    true
                | US2_1, US2_1 -> (* GunRsClient *)
                    true
                | US2_2, US2_2 -> (* Memory *)
                    true
                | US2_3, US2_3 -> (* SignalRClient *)
                    true
                | _ ->
                    false
            let v45 : bool = v44 <> true
            if v45 then
                let v46 : US4 = US4_2
                let v47 : ((obj []) -> unit) = v5 v46
                let v48 : string = "> use_fetch > on_value > set () > db_put"
                let v49 : obj = v48
                let v50 : obj = struct (v22, v17)
                let v55 : string =
                    match v6 with
                    | US2_0 -> (* GunJsClient *)
                        let v51 : string = "Gun JavaScript"
                        v51
                    | US2_1 -> (* GunRsClient *)
                        let v52 : string = "Gun Rust"
                        v52
                    | US2_2 -> (* Memory *)
                        let v53 : string = "Memory"
                        v53
                    | US2_3 -> (* SignalRClient *)
                        let v54 : string = "SignalR"
                        v54
                let v56 : obj = struct (v29, v55)
                let v57 : obj = struct (v31, v9)
                let v58 : obj = struct (v33, v8)
                let v63 : string =
                    match v41 with
                    | US2_0 -> (* GunJsClient *)
                        let v59 : string = "Gun JavaScript"
                        v59
                    | US2_1 -> (* GunRsClient *)
                        let v60 : string = "Gun Rust"
                        v60
                    | US2_2 -> (* Memory *)
                        let v61 : string = "Memory"
                        v61
                    | US2_3 -> (* SignalRClient *)
                        let v62 : string = "SignalR"
                        v62
                let v64 : string = "connection_client_type:"
                let v65 : obj = struct (v64, v63)
                let v66 : (obj []) = [|v49; v50; v56; v57; v58; v65|]
                v47 v66
                match v41 with
                | US2_0 -> (* GunJsClient *)
                    let v67 : (string []) = v0.Split [| '/' |]
                    let v68 : (string -> obj) = v42?get
                    let v69 : string = "tictactoe_spiral"
                    let v70 : obj = v68 v69
                    let v71 : int32 = v67.Length
                    let v72 : Mut27 = {l0 = 0; l1 = v70} : Mut27
                    while method81(v71, v72) do
                        let v74 : int32 = v72.l0
                        let v75 : obj = v72.l1
                        let v76 : string = v67.[int v74]
                        let v77 : (string -> obj) = v75?get
                        let v78 : obj = v77 v76
                        let v79 : int32 = v74 + 1
                        v72.l0 <- v79
                        v72.l1 <- v78
                        ()
                    let v80 : obj = v72.l1
                    v80?put v8
                    ()
                | US2_1 -> (* GunRsClient *)
                    let v81 : (string []) = v0.Split [| '/' |]
                    let v82 : (string -> obj) = v42?get
                    let v83 : string = "tictactoe_spiral"
                    let v84 : obj = v82 v83
                    let v85 : int32 = v81.Length
                    let v86 : Mut27 = {l0 = 0; l1 = v84} : Mut27
                    while method81(v85, v86) do
                        let v88 : int32 = v86.l0
                        let v89 : obj = v86.l1
                        let v90 : string = v81.[int v88]
                        let v91 : (string -> obj) = v89?get
                        let v92 : obj = v91 v90
                        let v93 : int32 = v88 + 1
                        v86.l0 <- v93
                        v86.l1 <- v92
                        ()
                    let v94 : obj = v86.l1
                    v94?put v8
                    ()
                | US2_2 -> (* Memory *)
                    failwith<unit> "db_on Memory"
                | US2_3 -> (* SignalRClient *)
                    let v95 : string = v8.ToString ()
                    let v96 : string = "alias"
                    let v97 : UH1 = UH1_3(v96, v0, v95)
                    let v98 : obj = v97
                    let v99 : string = "send"
                    (v42?invoke : JS.Function).Invoke ($"{v99}", v98) |> ignore
                    ()
            let v100 : int32 = v40 + 1
            v38.l0 <- v100
            ()
        ()
and method91 (v0 : string, v1 : (unit -> (struct (Guid * obj) [])), v2 : (struct ((struct (Guid * obj) []) * US2 * Guid * (struct (Guid * obj) [])) -> unit), v3 : (US18 -> unit), v4 : (unit -> US18), v5 : (US4 -> ((obj []) -> unit)), v6 : US2, v7 : (struct (US2 * obj * string) []), v8 : (US4 -> ((obj []) -> unit)), v9 : Guid, v10 : (struct (Guid * obj) []), v11 : obj) : unit =
    let v12 : US4 = US4_2
    let v13 : ((obj []) -> unit) = v8 v12
    let v14 : string = "> db_on > on_value ()"
    let v15 : obj = v14
    let v16 : string = "v:"
    let v17 : obj = struct (v16, v9, v10)
    let v18 : string = "k:"
    let v19 : obj = struct (v18, v11)
    let v20 : (obj []) = [|v15; v17; v19|]
    v13 v20
    method92(v0, v1, v2, v3, v4, v5, v6, v7, v10, v9)
and closure324 (v0 : string, v1 : (unit -> (struct (Guid * obj) [])), v2 : (struct ((struct (Guid * obj) []) * US2 * Guid * (struct (Guid * obj) [])) -> unit), v3 : (US18 -> unit), v4 : (unit -> US18), v5 : (US4 -> ((obj []) -> unit)), v6 : US2, v7 : (struct (US2 * obj * string) []), v8 : (US4 -> ((obj []) -> unit)), v9 : Guid, v10 : (struct (Guid * obj) [])) (v11 : obj) : unit =
    method91(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure323 (v0 : string, v1 : (unit -> (struct (Guid * obj) [])), v2 : (struct ((struct (Guid * obj) []) * US2 * Guid * (struct (Guid * obj) [])) -> unit), v3 : (US18 -> unit), v4 : (unit -> US18), v5 : (US4 -> ((obj []) -> unit)), v6 : US2, v7 : (struct (US2 * obj * string) []), v8 : (US4 -> ((obj []) -> unit))) struct (v9 : Guid, v10 : (struct (Guid * obj) [])) : (obj -> unit) =
    closure324(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
and closure322 (v0 : string, v1 : (unit -> US4), v2 : ((struct (US2 * int64 * string) []) -> unit), v3 : (unit -> (struct (US2 * int64 * string) [])), v4 : (US4 -> ((obj []) -> unit)), v5 : (unit -> (struct (Guid * obj) [])), v6 : (struct ((struct (Guid * obj) []) * US2 * Guid * (struct (Guid * obj) [])) -> unit), v7 : (US18 -> unit), v8 : (unit -> US18)) (v9 : (struct (US2 * obj * string) [])) : unit =
    let v10 : (struct (US2 * int64 * string) []) = v3 ()
    let v11 : int32 = v9.Length
    let v12 : (struct (US2 * int64 * string) []) = Array.zeroCreate<struct (US2 * int64 * string)> (v11)
    let v13 : Mut6 = {l0 = 0} : Mut6
    while method21(v11, v13) do
        let v15 : int32 = v13.l0
        let struct (v16 : US2, v17 : obj, v18 : string) = v9.[int v15]
        let v19 : int32 = v10.Length
        let v20 : US17 = US17_0
        let v21 : Mut26 = {l0 = 0; l1 = v20} : Mut26
        while method78(v19, v21) do
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
                        | US2_3, US2_3 -> (* SignalRClient *)
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
        let struct (v91 : US2, v92 : int64, v93 : string) =
            match v42 with
            | US17_0 -> (* None *)
                let v43 : (unit -> (obj [])) = closure284(v0, v16)
                let v44 : string = "#666"
                let v45 : (US4 -> ((obj []) -> unit)) = method17(v1, v43, v44)
                let v46 : US4 = US4_0
                let v47 : ((obj []) -> unit) = v45 v46
                let v48 : string = "> db_on ()"
                let v49 : obj = v48
                let v50 : (obj []) = [|v49|]
                v47 v50
                let v51 : (struct (Guid * (struct (Guid * obj) [])) -> (obj -> unit)) = closure323(v0, v5, v6, v7, v8, v4, v16, v9, v45)
                let v52 : (struct (obj * int32) -> unit) = emitJsExpr () $"(v: any, k: any) => {v51}(v)(k)"
                let v87 : int64 =
                    match v16 with
                    | US2_0 -> (* GunJsClient *)
                        let v53 : (string []) = v0.Split [| '/' |]
                        let v54 : (string -> obj) = v17?get
                        let v55 : string = "tictactoe_spiral"
                        let v56 : obj = v54 v55
                        let v57 : int32 = v53.Length
                        let v58 : Mut27 = {l0 = 0; l1 = v56} : Mut27
                        while method81(v57, v58) do
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
                        v66?on v52
                        let v67 : int64 = DateTime.UtcNow.Ticks
                        v67
                    | US2_1 -> (* GunRsClient *)
                        let v68 : (string []) = v0.Split [| '/' |]
                        let v69 : (string -> obj) = v17?get
                        let v70 : string = "tictactoe_spiral"
                        let v71 : obj = v69 v70
                        let v72 : int32 = v68.Length
                        let v73 : Mut27 = {l0 = 0; l1 = v71} : Mut27
                        while method81(v72, v73) do
                            let v75 : int32 = v73.l0
                            let v76 : obj = v73.l1
                            let v77 : string = v68.[int v75]
                            let v78 : (string -> obj) = v76?get
                            let v79 : obj = v78 v77
                            let v80 : int32 = v75 + 1
                            v73.l0 <- v80
                            v73.l1 <- v79
                            ()
                        let v81 : obj = v73.l1
                        let v82 : int64 = v81?on v52
                        v82
                    | US2_2 -> (* Memory *)
                        failwith<int64> "db_on Memory"
                    | US2_3 -> (* SignalRClient *)
                        let v84 : string = "send"
                        let v85 : (obj -> unit) = closure288(v45)
                        (v17?on : JS.Function).Invoke ($"{v84}", v85) |> ignore
                        let v86 : int64 = DateTime.UtcNow.Ticks
                        v86
                struct (v16, v87, v18)
            | US17_1(v88, v89, v90) -> (* Some *)
                struct (v88, v89, v90)
        v12.[int v15] <- struct (v91, v92, v93)
        let v94 : int32 = v15 + 1
        v13.l0 <- v94
        ()
    let v95 : int32 = v10.Length
    let v96 : (struct (US2 * string) []) = Array.zeroCreate<struct (US2 * string)> (v95)
    let v97 : Mut6 = {l0 = 0} : Mut6
    while method21(v95, v97) do
        let v99 : int32 = v97.l0
        let struct (v100 : US2, v101 : int64, v102 : string) = v10.[int v99]
        v96.[int v99] <- struct (v100, v102)
        let v103 : int32 = v99 + 1
        v97.l0 <- v103
        ()
    let v104 : int32 = v12.Length
    let v105 : (struct (US2 * string) []) = Array.zeroCreate<struct (US2 * string)> (v104)
    let v106 : Mut6 = {l0 = 0} : Mut6
    while method21(v104, v106) do
        let v108 : int32 = v106.l0
        let struct (v109 : US2, v110 : int64, v111 : string) = v12.[int v108]
        v105.[int v108] <- struct (v109, v111)
        let v112 : int32 = v108 + 1
        v106.l0 <- v112
        ()
    let v113 : int32 = v96.Length
    let v114 : int32 = v105.Length
    let v115 : bool = v113 = v114
    let v116 : bool = v115 <> true
    let v119 : bool =
        if v116 then
            false
        else
            let v117 : int32 = 0
            method82(v96, v105, v117)
    let v120 : bool = v119 <> true
    if v120 then
        let v121 : US4 = US4_2
        let v122 : ((obj []) -> unit) = v4 v121
        let v123 : string = "> use_fetch > connections_change"
        let v124 : obj = v123
        let v125 : (struct (string * int64) []) = Array.zeroCreate<struct (string * int64)> (v104)
        let v126 : Mut6 = {l0 = 0} : Mut6
        while method21(v104, v126) do
            let v128 : int32 = v126.l0
            let struct (v129 : US2, v130 : int64, v131 : string) = v12.[int v128]
            let v136 : string =
                match v129 with
                | US2_0 -> (* GunJsClient *)
                    let v132 : string = "Gun JavaScript"
                    v132
                | US2_1 -> (* GunRsClient *)
                    let v133 : string = "Gun Rust"
                    v133
                | US2_2 -> (* Memory *)
                    let v134 : string = "Memory"
                    v134
                | US2_3 -> (* SignalRClient *)
                    let v135 : string = "SignalR"
                    v135
            v125.[int v128] <- struct (v136, v130)
            let v137 : int32 = v128 + 1
            v126.l0 <- v137
            ()
        let v138 : string = "new_subscriptions:"
        let v139 : obj = struct (v138, v125)
        let v140 : (obj []) = [|v124; v139|]
        v122 v140
        v2 v12
        ()
and closure326 (v0 : string, v1 : (unit -> (struct (Guid * obj) [])), v2 : (struct ((struct (Guid * obj) []) * US2 * Guid * (struct (Guid * obj) [])) -> unit), v3 : (US18 -> unit), v4 : (unit -> US18), v5 : (US4 -> ((obj []) -> unit)), v6 : (struct (US2 * obj * string) []), v7 : Guid) (v8 : (struct (Guid * obj) [])) : unit =
    let v9 : US2 = US2_2
    method92(v0, v1, v2, v3, v4, v5, v9, v6, v8, v7)
and closure325 (v0 : (obj -> JS.Promise<(struct (Guid * obj) [])>), v1 : (unit -> (struct (US2 * obj * string) [])), v2 : string, v3 : (unit -> (struct (Guid * obj) [])), v4 : (struct ((struct (Guid * obj) []) * US2 * Guid * (struct (Guid * obj) [])) -> unit), v5 : (US18 -> unit), v6 : (unit -> US18), v7 : (US4 -> ((obj []) -> unit))) () : unit =
    let v8 : (struct (US2 * obj * string) []) = v1 ()
    let v9 : int64 = DateTime.UtcNow.Ticks
    let v10 : Guid = Guid.NewGuid ()
    let v11 : string = v10.ToString ()
    let v12 : string = v9.ToString ()
    let v13 : Guid = Guid $"{v12.[0..7]}-{v12.[8..11]}-{v12.[12..15]}-{v12.[16..17]}{v11.[21..]}"
    let v14 : obj = ()
    let v15 : JS.Promise<(struct (Guid * obj) [])> = v0 v14
    let v16 : ((struct (Guid * obj) []) -> unit) = closure326(v2, v3, v4, v5, v6, v7, v8, v13)
    v15 |> Promise.iter v16
    ()
and closure327 (v0 : (unit -> (struct (US2 * obj * string) [])), v1 : (US4 -> ((obj []) -> unit)), v2 : string, v3 : (unit -> (struct (Guid * obj) [])), v4 : (struct ((struct (Guid * obj) []) * US2 * Guid * (struct (Guid * obj) [])) -> unit), v5 : (US18 -> unit), v6 : (unit -> US18)) () : unit =
    let v7 : US4 = US4_2
    let v8 : ((obj []) -> unit) = v1 v7
    let v9 : string = ">> use_fetch clear ()"
    let v10 : obj = v9
    let v11 : (obj []) = [|v10|]
    v8 v11
    let v12 : (struct (US2 * obj * string) []) = v0 ()
    let v13 : int64 = DateTime.UtcNow.Ticks
    let v14 : Guid = Guid.NewGuid ()
    let v15 : string = v14.ToString ()
    let v16 : string = v13.ToString ()
    let v17 : Guid = Guid $"{v16.[0..7]}-{v16.[8..11]}-{v16.[12..15]}-{v16.[16..17]}{v15.[21..]}"
    let v18 : US2 = US2_2
    let v19 : (struct (Guid * obj) []) = emitJsExpr () "null"
    method92(v2, v3, v4, v5, v6, v1, v18, v12, v19, v17)
and method89 (v0 : string, v1 : (unit -> (struct (Guid * obj) [])), v2 : (struct ((struct (Guid * obj) []) * US2 * Guid * (struct (Guid * obj) [])) -> unit), v3 : (obj -> JS.Promise<(struct (Guid * obj) [])>)) : struct ((unit -> unit) * (unit -> unit)) =
    let v112 : obj = emitJsExpr () "components_spi.state_context"
    let v113 : string = "useContext"
    let v114 : string = "solid-js"
    let v115 : JS.Function = import v113 v114
    let struct (v116 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v117 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v118 : (unit -> int32), v119 : (int32 -> unit), v120 : (unit -> string), v121 : (string -> unit), v122 : (unit -> string), v123 : (string -> unit), v124 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v125 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v126 : (unit -> (struct (US2 * obj * string) [])), v127 : ((struct (US2 * obj * string) []) -> unit), v128 : (unit -> (struct (Guid * obj) [])), v129 : ((struct (Guid * obj) []) -> unit), v130 : (unit -> (struct (Guid * obj) [])), v131 : ((struct (Guid * obj) []) -> unit), v132 : (unit -> (struct (Guid * int32) [])), v133 : ((struct (Guid * int32) []) -> unit), v134 : (unit -> US4), v135 : (US4 -> unit), v136 : (unit -> US5), v137 : (US5 -> unit)) = v115.Invoke v112 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v246 : obj = emitJsExpr () "components_spi.state_context"
    let v247 : JS.Function = import v113 v114
    let struct (v248 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v249 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v250 : (unit -> int32), v251 : (int32 -> unit), v252 : (unit -> string), v253 : (string -> unit), v254 : (unit -> string), v255 : (string -> unit), v256 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v257 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v258 : (unit -> (struct (US2 * obj * string) [])), v259 : ((struct (US2 * obj * string) []) -> unit), v260 : (unit -> (struct (Guid * obj) [])), v261 : ((struct (Guid * obj) []) -> unit), v262 : (unit -> (struct (Guid * obj) [])), v263 : ((struct (Guid * obj) []) -> unit), v264 : (unit -> (struct (Guid * int32) [])), v265 : ((struct (Guid * int32) []) -> unit), v266 : (unit -> US4), v267 : (US4 -> unit), v268 : (unit -> US5), v269 : (US5 -> unit)) = v247.Invoke v246 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let struct (v270 : (unit -> unit), v271 : (unit -> unit)) = method75()
    let struct (v272 : (unit -> unit), v273 : (unit -> unit)) = method75()
    let v274 : US18 = US18_0
    let struct (v275 : (unit -> US18), v276 : (US18 -> unit)) = method90(v274)
    let v277 : (struct (US2 * int64 * string) []) = [||]
    let struct (v278 : (unit -> (struct (US2 * int64 * string) [])), v279 : ((struct (US2 * int64 * string) []) -> unit)) = method77(v277)
    let v280 : (uint8 []) = System.Text.Encoding.UTF8.GetBytes v0
    let v281 : int32 = v280.Length
    let v282 : Mut25 = {l0 = 0; l1 = 100000} : Mut25
    while method71(v281, v282) do
        let v284 : int32 = v282.l0
        let v285 : int32 = v282.l1
        let v286 : uint8 = v280.[int v284]
        let v287 : int32 = v286 |> unbox<int32>
        let v288 : int32 = v287 * 14
        let v289 : int32 = v285 + v288
        let v290 : int32 = v284 + 1
        v282.l0 <- v290
        v282.l1 <- v289
        ()
    let v291 : int32 = v282.l1
    let v292 : string = v291.ToString ()
    let v293 : string = $"#{v292}"
    let v294 : (unit -> (obj [])) = closure321(v0, v1, v258, v270, v272, v275, v278)
    let v295 : (US4 -> ((obj []) -> unit)) = method16(v294, v293)
    let v296 : US4 = US4_0
    let v297 : ((obj []) -> unit) = v295 v296
    let v298 : string = "> use_fetch ()"
    let v299 : obj = v298
    let v300 : (obj []) = [|v299|]
    v297 v300
    let v301 : string = "debounce"
    let v302 : string = "@solid-primitives/scheduled"
    let v303 : JS.Function = import v301 v302
    let v304 : ((struct (US2 * obj * string) []) -> unit) = closure322(v0, v134, v279, v278, v295, v1, v2, v276, v275)
    let v305 : ((struct (US2 * obj * string) []) -> unit) = v303.Invoke (v304, 2500) |> unbox<(struct (US2 * obj * string) []) -> unit>
    let v306 : string = "createEffect"
    let v307 : JS.Function = import v306 v114
    let v308 : (unit -> unit) = closure289(v258, v305)
    v307.Invoke v308 |> ignore
    let v309 : string = "onCleanup"
    let v310 : JS.Function = import v309 v114
    let v311 : (unit -> unit) = closure290(v305, v0, v295)
    v310.Invoke v311 |> ignore
    let v312 : (unit -> unit) = closure325(v3, v258, v0, v1, v2, v276, v275, v295)
    let v313 : (unit -> unit) = closure327(v258, v295, v0, v1, v2, v276, v275)
    struct (v312, v313)
and closure329 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "center"
    let v71 : string = "baseline"
    let v72 : string = method13(v71, v70)
    let v73 : string = "row"
    let v74 : string = "column"
    let v75 : string = method13(v74, v73)
    let v76 : string = "0"
    let v77 : string = "8px"
    let v78 : string = method13(v77, v76)
    let v79 : US6 = US6_1(v72)
    let v80 : US6 = US6_1(v75)
    let v81 : US6 = US6_1(v78)
    let v82 : string = "3px"
    let v83 : US6 = US6_1(v82)
    let v84 : string = "7px"
    let v85 : US6 = US6_1(v84)
    struct (v79, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v80, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v81, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v83, v49, v50, v51, v52, v53, v54, v55, v56, v85, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure331 () () : (JSX.Element []) =
    let v0 : string = "Chain Status"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure333 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v70, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure332 (v0 : (unit -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (Mut7 -> JSX.Element) = closure60()
    let v72 : (unit -> JS.Function) = closure300()
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure333()
    let v75 : JSX.Element = method48(v71, v72, v73, v74)
    let v76 : US11 = US11_1(v75)
    let v77 : US13 = US13_1(v0)
    let v78 : string = "10px"
    let v79 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v76, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v77, v44, v45, v46, v47, v48, v49, v50, v51, v79, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure334 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure336 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v70, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure335 (v0 : (unit -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (Mut7 -> JSX.Element) = closure60()
    let v72 : (unit -> JS.Function) = closure304()
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure336()
    let v75 : JSX.Element = method48(v71, v72, v73, v74)
    let v76 : US11 = US11_1(v75)
    let v77 : US13 = US13_1(v0)
    let v78 : string = "10px"
    let v79 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v76, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v77, v44, v45, v46, v47, v48, v49, v50, v51, v79, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure337 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure330 (v0 : (unit -> unit), v1 : (unit -> unit)) () : (JSX.Element []) =
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/core"
    let v4 : JS.Function = import v2 v3
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v6 : (unit -> (JSX.Element [])) = closure331()
    let v7 : JSX.Element = method5(v4, v5, v6)
    let v8 : (Mut1 -> JSX.Element) = closure47()
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure332(v1)
    let v10 : (unit -> (JSX.Element [])) = closure334()
    let v11 : JSX.Element = method22(v8, v9, v10)
    let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure335(v0)
    let v13 : (unit -> (JSX.Element [])) = closure337()
    let v14 : JSX.Element = method22(v8, v12, v13)
    [|v7; v11; v14|]
and method93 (v0 : int32, v1 : Mut29) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method94 (v0 : UH3, v1 : UH3) : UH3 =
    match v0 with
    | UH3_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH3 = UH3_0(v2, v3, v1)
        method94(v4, v5)
    | UH3_1 -> (* Nil *)
        v1
and method96 (v0 : UH3, v1 : int32) : int32 =
    match v0 with
    | UH3_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method96(v4, v5)
    | UH3_1 -> (* Nil *)
        v1
and method97 (v0 : (struct (Guid * obj) []), v1 : UH3, v2 : int32) : int32 =
    match v1 with
    | UH3_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method97(v0, v5, v6)
    | UH3_1 -> (* Nil *)
        v2
and method95 (v0 : UH3) : (struct (Guid * obj) []) =
    let v1 : int32 = 0
    let v2 : int32 = method96(v0, v1)
    let v3 : (struct (Guid * obj) []) = Array.zeroCreate<struct (Guid * obj)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method97(v3, v0, v4)
    v3
and closure344 (v0 : (unit -> struct (Guid * obj))) () : (JSX.Element []) =
    let struct (v1 : Guid, v2 : obj) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = v3 |> unbox<JSX.Element>
    let v5 : JSX.Element = Html.fragment [ v4 ]
    [|v5|]
and closure343 (v0 : (unit -> struct (Guid * obj))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/core"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v6 : (unit -> (JSX.Element [])) = closure344(v0)
    let v7 : JSX.Element = method5(v4, v5, v6)
    [|v7|]
and closure342 (v0 : (unit -> struct (Guid * obj))) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let struct (v71 : Guid, v72 : obj) = v0 ()
    let v73 : string = v71.ToString ()
    let v74 : JSX.Element = v73 |> unbox<JSX.Element>
    let v75 : JSX.Element = Html.fragment [ v74 ]
    let v76 : (unit -> (JSX.Element [])) = closure343(v0)
    let v77 : US9 = US9_1(v76)
    let v78 : string = "3px"
    let v79 : US6 = US6_1(v78)
    let v80 : US11 = US11_1(v75)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v77, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v79, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v80, v64, v65, v66, v67, v68, v69, v70)
and closure341 (v0 : (unit -> struct (Guid * obj))) (v1 : int32) : (JSX.Element []) =
    let v2 : (Mut3 -> JSX.Element) = closure14()
    let v3 : US13 = US13_0
    let v4 : US13 = US13_0
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure342(v0)
    let v6 : US15 = US15_2
    let v7 : JSX.Element = method26(v2, v3, v4, v5, v6)
    [|v7|]
and closure340 () (v0 : (unit -> struct (Guid * obj))) : (int32 -> (JSX.Element [])) =
    closure341(v0)
and closure345 (v0 : (struct (Guid * obj) [])) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (obj []) = v0 |> unbox<(obj [])>
    let v72 : US10 = US10_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v72, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure339 (v0 : (unit -> (struct (Guid * obj) []))) () : (JSX.Element []) =
    let v1 : (struct (Guid * obj) []) = v0 ()
    let v2 : int32 = v1.Length
    let v3 : UH3 = UH3_1
    let v4 : Mut29 = {l0 = 0; l1 = v3} : Mut29
    while method93(v2, v4) do
        let v6 : int32 = v4.l0
        let v7 : int32 =  -v6
        let v8 : int32 = v7 + v2
        let v9 : int32 = v8 - 1
        let v10 : UH3 = v4.l1
        let struct (v11 : Guid, v12 : obj) = v1.[int v9]
        let v13 : int32 = v6 + 1
        let v14 : UH3 = UH3_0(v11, v12, v10)
        v4.l0 <- v13
        v4.l1 <- v14
        ()
    let v15 : UH3 = v4.l1
    let v16 : UH3 = UH3_1
    let v17 : UH3 = method94(v15, v16)
    let v18 : (struct (Guid * obj) []) = method95(v17)
    let v19 : ((unit -> struct (Guid * obj)) -> (int32 -> (JSX.Element []))) = closure340()
    let v20 : (unit -> (JSX.Element [])) = emitJsExpr () $"(item: any, index: () => number) => {v19}(item)(index)"
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : JS.Function = import v21 v22
    let v24 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure345(v18)
    let v25 : JSX.Element = method5(v23, v24, v20)
    [|v25|]
and closure338 (v0 : (unit -> (struct (Guid * obj) []))) () : (JSX.Element []) =
    let v1 : (Mut1 -> JSX.Element) = closure7()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v3 : (unit -> (JSX.Element [])) = closure339(v0)
    let v4 : JSX.Element = method22(v1, v2, v3)
    [|v4|]
and closure328 (v0 : (unit -> (struct (Guid * obj) [])), v1 : (unit -> unit), v2 : (unit -> unit)) struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US6, v19 : US6, v20 : US6, v21 : US10, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US11, v30 : US6, v31 : US6, v32 : US6, v33 : US11, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US12, v45 : US13, v46 : US12, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US14, v64 : US6, v65 : US11, v66 : US6, v67 : US6, v68 : US14, v69 : US14, v70 : US6, v71 : US5, v72 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v73 : string = "Stack"
    let v74 : string = "@hope-ui/core"
    let v75 : JS.Function = import v73 v74
    let v76 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure329()
    let v77 : (unit -> (JSX.Element [])) = closure330(v1, v2)
    let v78 : JSX.Element = method5(v75, v76, v77)
    let v79 : (unit -> (JSX.Element [])) = closure338(v0)
    let v80 : US9 = US9_1(v79)
    let v81 : string = "status"
    let v82 : US6 = US6_1(v81)
    let v83 : US11 = US11_1(v78)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v80, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v82, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v83, v66, v67, v68, v69, v70, v71, v72)
and method88 () : JSX.Element =
    let v108 : obj = emitJsExpr () "components_spi.state_context"
    let v109 : string = "useContext"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let struct (v112 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v113 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v114 : (unit -> int32), v115 : (int32 -> unit), v116 : (unit -> string), v117 : (string -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v121 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v122 : (unit -> (struct (US2 * obj * string) [])), v123 : ((struct (US2 * obj * string) []) -> unit), v124 : (unit -> (struct (Guid * obj) [])), v125 : ((struct (Guid * obj) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * int32) [])), v129 : ((struct (Guid * int32) []) -> unit), v130 : (unit -> US4), v131 : (US4 -> unit), v132 : (unit -> US5), v133 : (US5 -> unit)) = v111.Invoke v108 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v134 : string = "profile/tmp/chain_status"
    let v135 : (struct ((struct (Guid * obj) []) * US2 * Guid * (struct (Guid * obj) [])) -> unit) = closure317(v127)
    let v136 : (obj -> JS.Promise<(struct (Guid * obj) [])>) = closure318(v126)
    let struct (v137 : (unit -> unit), v138 : (unit -> unit)) = method89(v134, v126, v135, v136)
    let v139 : (Mut3 -> JSX.Element) = closure14()
    let v140 : US13 = US13_0
    let v141 : US13 = US13_0
    let v142 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure328(v126, v138, v137)
    let v143 : US15 = US15_2
    method26(v139, v140, v141, v142, v143)
and closure316 () (v0 : Mut1) : JSX.Element =
    method88()
and closure346 () () : (JSX.Element []) =
    [||]
and closure348 (v0 : ((struct (Guid * obj) []) -> unit)) struct (v1 : (struct (Guid * obj) []), v2 : US2, v3 : Guid, v4 : (struct (Guid * obj) [])) : unit =
    v0 v4
    ()
and closure351 (v0 : (unit -> (struct (Guid * obj) [])), v1 : ((struct (Guid * obj) []) -> unit)) (v2 : (exn -> unit)) : unit =
    let v3 : (struct (Guid * obj) []) = v0 ()
    v1 v3
    ()
and closure350 (v0 : (unit -> (struct (Guid * obj) []))) (v1 : ((struct (Guid * obj) []) -> unit)) : ((exn -> unit) -> unit) =
    closure351(v0, v1)
and closure349 (v0 : (unit -> (struct (Guid * obj) []))) (v1 : obj) : JS.Promise<(struct (Guid * obj) [])> =
    let v2 : (((struct (Guid * obj) []) -> unit) -> ((exn -> unit) -> unit)) = closure350(v0)
    let v3 : JS.Promise<(struct (Guid * obj) [])> = Promise.create v2
    v3
and closure353 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "center"
    let v71 : string = "baseline"
    let v72 : string = method13(v71, v70)
    let v73 : string = "row"
    let v74 : string = "column"
    let v75 : string = method13(v74, v73)
    let v76 : string = "0"
    let v77 : string = "8px"
    let v78 : string = method13(v77, v76)
    let v79 : US6 = US6_1(v72)
    let v80 : US6 = US6_1(v75)
    let v81 : US6 = US6_1(v78)
    let v82 : string = "3px"
    let v83 : US6 = US6_1(v82)
    let v84 : string = "7px"
    let v85 : US6 = US6_1(v84)
    struct (v79, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v80, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v81, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v83, v49, v50, v51, v52, v53, v54, v55, v56, v85, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure355 () () : (JSX.Element []) =
    let v0 : string = "Chain Deploy"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure357 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v70, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure356 (v0 : (unit -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (Mut7 -> JSX.Element) = closure60()
    let v72 : (unit -> JS.Function) = closure300()
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure357()
    let v75 : JSX.Element = method48(v71, v72, v73, v74)
    let v76 : US11 = US11_1(v75)
    let v77 : US13 = US13_1(v0)
    let v78 : string = "10px"
    let v79 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v76, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v77, v44, v45, v46, v47, v48, v49, v50, v51, v79, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure358 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure360 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v70, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure359 (v0 : (unit -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (Mut7 -> JSX.Element) = closure60()
    let v72 : (unit -> JS.Function) = closure304()
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure360()
    let v75 : JSX.Element = method48(v71, v72, v73, v74)
    let v76 : US11 = US11_1(v75)
    let v77 : US13 = US13_1(v0)
    let v78 : string = "10px"
    let v79 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v76, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v77, v44, v45, v46, v47, v48, v49, v50, v51, v79, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure361 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure354 (v0 : (unit -> unit), v1 : (unit -> unit)) () : (JSX.Element []) =
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/core"
    let v4 : JS.Function = import v2 v3
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v6 : (unit -> (JSX.Element [])) = closure355()
    let v7 : JSX.Element = method5(v4, v5, v6)
    let v8 : (Mut1 -> JSX.Element) = closure47()
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure356(v1)
    let v10 : (unit -> (JSX.Element [])) = closure358()
    let v11 : JSX.Element = method22(v8, v9, v10)
    let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure359(v0)
    let v13 : (unit -> (JSX.Element [])) = closure361()
    let v14 : JSX.Element = method22(v8, v12, v13)
    [|v7; v11; v14|]
and closure368 (v0 : (unit -> struct (Guid * obj))) () : (JSX.Element []) =
    let struct (v1 : Guid, v2 : obj) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = v3 |> unbox<JSX.Element>
    let v5 : JSX.Element = Html.fragment [ v4 ]
    [|v5|]
and closure367 (v0 : (unit -> struct (Guid * obj))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/core"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v6 : (unit -> (JSX.Element [])) = closure368(v0)
    let v7 : JSX.Element = method5(v4, v5, v6)
    [|v7|]
and closure366 (v0 : (unit -> struct (Guid * obj))) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let struct (v71 : Guid, v72 : obj) = v0 ()
    let v73 : string = v71.ToString ()
    let v74 : JSX.Element = v73 |> unbox<JSX.Element>
    let v75 : JSX.Element = Html.fragment [ v74 ]
    let v76 : (unit -> (JSX.Element [])) = closure367(v0)
    let v77 : US9 = US9_1(v76)
    let v78 : string = "3px"
    let v79 : US6 = US6_1(v78)
    let v80 : US11 = US11_1(v75)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v77, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v79, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v80, v64, v65, v66, v67, v68, v69, v70)
and closure365 (v0 : (unit -> struct (Guid * obj))) (v1 : int32) : (JSX.Element []) =
    let v2 : (Mut3 -> JSX.Element) = closure14()
    let v3 : US13 = US13_0
    let v4 : US13 = US13_0
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure366(v0)
    let v6 : US15 = US15_2
    let v7 : JSX.Element = method26(v2, v3, v4, v5, v6)
    [|v7|]
and closure364 () (v0 : (unit -> struct (Guid * obj))) : (int32 -> (JSX.Element [])) =
    closure365(v0)
and closure363 (v0 : (unit -> (struct (Guid * obj) []))) () : (JSX.Element []) =
    let v1 : (struct (Guid * obj) []) = v0 ()
    let v2 : int32 = v1.Length
    let v3 : UH3 = UH3_1
    let v4 : Mut29 = {l0 = 0; l1 = v3} : Mut29
    while method93(v2, v4) do
        let v6 : int32 = v4.l0
        let v7 : int32 =  -v6
        let v8 : int32 = v7 + v2
        let v9 : int32 = v8 - 1
        let v10 : UH3 = v4.l1
        let struct (v11 : Guid, v12 : obj) = v1.[int v9]
        let v13 : int32 = v6 + 1
        let v14 : UH3 = UH3_0(v11, v12, v10)
        v4.l0 <- v13
        v4.l1 <- v14
        ()
    let v15 : UH3 = v4.l1
    let v16 : UH3 = UH3_1
    let v17 : UH3 = method94(v15, v16)
    let v18 : (struct (Guid * obj) []) = method95(v17)
    let v19 : ((unit -> struct (Guid * obj)) -> (int32 -> (JSX.Element []))) = closure364()
    let v20 : (unit -> (JSX.Element [])) = emitJsExpr () $"(item: any, index: () => number) => {v19}(item)(index)"
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : JS.Function = import v21 v22
    let v24 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure345(v18)
    let v25 : JSX.Element = method5(v23, v24, v20)
    [|v25|]
and closure362 (v0 : (unit -> (struct (Guid * obj) []))) () : (JSX.Element []) =
    let v1 : (Mut1 -> JSX.Element) = closure7()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v3 : (unit -> (JSX.Element [])) = closure363(v0)
    let v4 : JSX.Element = method22(v1, v2, v3)
    [|v4|]
and closure352 (v0 : (unit -> (struct (Guid * obj) [])), v1 : (unit -> unit), v2 : (unit -> unit)) struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US6, v19 : US6, v20 : US6, v21 : US10, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US11, v30 : US6, v31 : US6, v32 : US6, v33 : US11, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US12, v45 : US13, v46 : US12, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US14, v64 : US6, v65 : US11, v66 : US6, v67 : US6, v68 : US14, v69 : US14, v70 : US6, v71 : US5, v72 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v73 : string = "Stack"
    let v74 : string = "@hope-ui/core"
    let v75 : JS.Function = import v73 v74
    let v76 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure353()
    let v77 : (unit -> (JSX.Element [])) = closure354(v1, v2)
    let v78 : JSX.Element = method5(v75, v76, v77)
    let v79 : (unit -> (JSX.Element [])) = closure362(v0)
    let v80 : US9 = US9_1(v79)
    let v81 : string = "deploy"
    let v82 : US6 = US6_1(v81)
    let v83 : US11 = US11_1(v78)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v80, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v82, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v83, v66, v67, v68, v69, v70, v71, v72)
and method98 () : JSX.Element =
    let v108 : obj = emitJsExpr () "components_spi.state_context"
    let v109 : string = "useContext"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let struct (v112 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v113 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v114 : (unit -> int32), v115 : (int32 -> unit), v116 : (unit -> string), v117 : (string -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v121 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v122 : (unit -> (struct (US2 * obj * string) [])), v123 : ((struct (US2 * obj * string) []) -> unit), v124 : (unit -> (struct (Guid * obj) [])), v125 : ((struct (Guid * obj) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * int32) [])), v129 : ((struct (Guid * int32) []) -> unit), v130 : (unit -> US4), v131 : (US4 -> unit), v132 : (unit -> US5), v133 : (US5 -> unit)) = v111.Invoke v108 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v134 : string = "profile/tmp/chain_deploy"
    let v135 : (struct ((struct (Guid * obj) []) * US2 * Guid * (struct (Guid * obj) [])) -> unit) = closure348(v125)
    let v136 : (obj -> JS.Promise<(struct (Guid * obj) [])>) = closure349(v124)
    let struct (v137 : (unit -> unit), v138 : (unit -> unit)) = method89(v134, v124, v135, v136)
    let v139 : (Mut3 -> JSX.Element) = closure14()
    let v140 : US13 = US13_0
    let v141 : US13 = US13_0
    let v142 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure352(v124, v138, v137)
    let v143 : US15 = US15_2
    method26(v139, v140, v141, v142, v143)
and closure347 () (v0 : Mut1) : JSX.Element =
    method98()
and closure369 () () : (JSX.Element []) =
    [||]
and closure274 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut1 -> JSX.Element) = closure275()
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure315()
    let v8 : JSX.Element = method22(v5, v6, v7)
    let v10 : bool = v2 = ""
    let v11 : bool = v10 <> true
    let v16 : JSX.Element =
        if v11 then
            let v12 : (Mut1 -> JSX.Element) = closure316()
            let v13 : (unit -> (JSX.Element [])) = closure346()
            method22(v12, v6, v13)
        else
            let v15 : JSX.Element = JS.undefined
            v15
    let v22 : JSX.Element =
        if v11 then
            let v18 : (Mut1 -> JSX.Element) = closure347()
            let v19 : (unit -> (JSX.Element [])) = closure369()
            method22(v18, v6, v19)
        else
            let v21 : JSX.Element = JS.undefined
            v21
    [|v8; v16; v22|]
and closure273 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut1 -> JSX.Element) = closure7()
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (JSX.Element [])) = closure274(v0, v1, v2, v3, v4)
    let v8 : JSX.Element = method22(v5, v6, v7)
    [|v8|]
and closure272 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) struct (v5 : US6, v6 : US6, v7 : US6, v8 : US7, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US8, v16 : US9, v17 : US6, v18 : US6, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US10, v24 : US8, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US11, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US12, v47 : US13, v48 : US12, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US14, v66 : US6, v67 : US11, v68 : US6, v69 : US6, v70 : US14, v71 : US14, v72 : US6, v73 : US5, v74 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v75 : string = "Profile"
    let v76 : JSX.Element = v75 |> unbox<JSX.Element>
    let v77 : JSX.Element = Html.fragment [ v76 ]
    let v78 : (unit -> (JSX.Element [])) = closure273(v0, v1, v2, v3, v4)
    let v79 : US9 = US9_1(v78)
    let v80 : US11 = US11_1(v77)
    struct (v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v79, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v80, v68, v69, v70, v71, v72, v73, v74)
and closure142 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut3 -> JSX.Element) = closure14()
    let v6 : US13 = US13_0
    let v7 : US13 = US13_0
    let v8 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure143()
    let v9 : US15 = US15_2
    let v10 : JSX.Element = method26(v5, v6, v7, v8, v9)
    let v11 : US13 = US13_0
    let v12 : US13 = US13_0
    let v13 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v14 : US15 = US15_2
    let v15 : JSX.Element = method26(v5, v11, v12, v13, v14)
    let v16 : US13 = US13_0
    let v17 : US13 = US13_0
    let v18 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure167()
    let v19 : US15 = US15_2
    let v20 : JSX.Element = method26(v5, v16, v17, v18, v19)
    let v21 : US13 = US13_0
    let v22 : US13 = US13_0
    let v23 : US15 = US15_2
    let v24 : JSX.Element = method26(v5, v21, v22, v13, v23)
    let v25 : US13 = US13_0
    let v26 : US13 = US13_0
    let v27 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure185()
    let v28 : US15 = US15_0
    let v29 : JSX.Element = method26(v5, v25, v26, v27, v28)
    let v30 : US13 = US13_0
    let v31 : US13 = US13_0
    let v32 : US15 = US15_2
    let v33 : JSX.Element = method26(v5, v30, v31, v13, v32)
    let v34 : US13 = US13_0
    let v35 : US13 = US13_0
    let v36 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure235()
    let v37 : US15 = US15_0
    let v38 : JSX.Element = method26(v5, v34, v35, v36, v37)
    let v39 : US13 = US13_0
    let v40 : US13 = US13_0
    let v41 : US15 = US15_2
    let v42 : JSX.Element = method26(v5, v39, v40, v13, v41)
    let v43 : US13 = US13_0
    let v44 : US13 = US13_0
    let v45 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure272(v0, v1, v2, v3, v4)
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
    let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure141()
    let v13 : (unit -> (JSX.Element [])) = closure142(v0, v1, v2, v3, v4)
    let v14 : JSX.Element = method22(v11, v12, v13)
    [|v10; v14|]
and method1 () : JSX.Element =
    let struct (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) = method2()
    let v5 : string = "Box"
    let v6 : string = "@hope-ui/core"
    let v7 : JS.Function = import v5 v6
    let v8 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure2()
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
and method100 (v0 : int32, v1 : Mut30) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method101 (v0 : int32, v1 : Mut31) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure373 () (v0 : obj) : obj =
    let v1 : string = "signalr withAutomaticReconnect nextRetryDelayInMilliseconds 2k"
    printfn $"%A{v1}"
    let v2 : obj = Some 2000 |> unbox
    v2
and method102 (v0 : int32, v1 : Mut32) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure372 (v0 : ((struct (US2 * obj * string) []) -> unit), v1 : (US4 -> ((obj []) -> unit))) struct (v2 : (struct ((US2 []) * int32 * US3 * string * string) []), v3 : (struct (US2 * obj * string) [])) : unit =
    let v4 : int32 = v2.Length
    let v5 : ((struct (US2 * obj * string) []) []) = Array.zeroCreate<(struct (US2 * obj * string) [])> (v4)
    let v6 : Mut6 = {l0 = 0} : Mut6
    while method21(v4, v6) do
        let v8 : int32 = v6.l0
        let struct (v9 : (US2 []), v10 : int32, v11 : US3, v12 : string, v13 : string) = v2.[int v8]
        let v14 : int32 = v9.Length
        let v15 : (struct (US2 * obj * string) []) = Array.zeroCreate<struct (US2 * obj * string)> (v14)
        let v16 : Mut6 = {l0 = 0} : Mut6
        while method21(v14, v16) do
            let v18 : int32 = v16.l0
            let v19 : US2 = v9.[int v18]
            let v20 : int32 = v3.Length
            let v21 : US19 = US19_0
            let v22 : Mut30 = {l0 = 0; l1 = v21} : Mut30
            while method100(v20, v22) do
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
                            | US2_3, US2_3 -> (* SignalRClient *)
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
            let struct (v115 : US2, v116 : obj, v117 : string) =
                match v43 with
                | US19_0 -> (* None *)
                    let v44 : US20 = US20_0
                    let v45 : Mut31 = {l0 = 0; l1 = v44} : Mut31
                    while method101(v4, v45) do
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
                                    | US3_2, US3_2 -> (* SignalRServer *)
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
                    let v111 : obj =
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
                        | US2_3 -> (* SignalRClient *)
                            let v98 : string = "HubConnectionBuilder"
                            let v99 : string = "@microsoft/signalr"
                            let v100 : JS.Function = import v98 v99
                            let v101 : obj = JS.undefined
                            let v102 : obj = createNew v100 v101
                            let v103 : string = "nextRetryDelayInMilliseconds"
                            let v104 : (obj -> obj) = closure373()
                            let v105 : (string * obj) = v103, v104
                            let v106 : ((string * obj) []) = [|v105|]
                            let v107 : obj = createObj v106
                            let v108 : obj = v102?withUrl v76
                            let v109 : obj = v108?withAutomaticReconnect v107
                            let v110 : obj = v109?build ()
                            v110?start () |> ignore
                            v110
                    struct (v19, v111, v76)
                | US19_1(v112, v113, v114) -> (* Some *)
                    struct (v112, v113, v114)
            v15.[int v18] <- struct (v115, v116, v117)
            let v118 : int32 = v18 + 1
            v16.l0 <- v118
            ()
        v5.[int v8] <- v15
        let v119 : int32 = v8 + 1
        v6.l0 <- v119
        ()
    let v120 : (struct (US2 * obj * string) []) = [||]
    let v121 : int32 = v5.Length
    let v122 : Mut32 = {l0 = 0; l1 = v120} : Mut32
    while method102(v121, v122) do
        let v124 : int32 = v122.l0
        let v125 : (struct (US2 * obj * string) []) = v122.l1
        let v126 : (struct (US2 * obj * string) []) = v5.[int v124]
        let v127 : int32 = v125.Length
        let v128 : int32 = v126.Length
        let v129 : int32 = v127 + v128
        let v130 : (struct (US2 * obj * string) []) = Array.zeroCreate<struct (US2 * obj * string)> (v129)
        let v131 : Mut6 = {l0 = 0} : Mut6
        while method21(v129, v131) do
            let v133 : int32 = v131.l0
            let v134 : bool = v133 < v127
            let struct (v142 : US2, v143 : obj, v144 : string) =
                if v134 then
                    let struct (v135 : US2, v136 : obj, v137 : string) = v125.[int v133]
                    struct (v135, v136, v137)
                else
                    let v138 : int32 = v133 - v127
                    let struct (v139 : US2, v140 : obj, v141 : string) = v126.[int v138]
                    struct (v139, v140, v141)
            v130.[int v133] <- struct (v142, v143, v144)
            let v145 : int32 = v133 + 1
            v131.l0 <- v145
            ()
        let v146 : int32 = v124 + 1
        v122.l0 <- v146
        v122.l1 <- v130
        ()
    let v147 : (struct (US2 * obj * string) []) = v122.l1
    let v148 : int32 = v3.Length
    let v149 : (struct (US2 * string) []) = Array.zeroCreate<struct (US2 * string)> (v148)
    let v150 : Mut6 = {l0 = 0} : Mut6
    while method21(v148, v150) do
        let v152 : int32 = v150.l0
        let struct (v153 : US2, v154 : obj, v155 : string) = v3.[int v152]
        v149.[int v152] <- struct (v153, v155)
        let v156 : int32 = v152 + 1
        v150.l0 <- v156
        ()
    let v157 : int32 = v147.Length
    let v158 : (struct (US2 * string) []) = Array.zeroCreate<struct (US2 * string)> (v157)
    let v159 : Mut6 = {l0 = 0} : Mut6
    while method21(v157, v159) do
        let v161 : int32 = v159.l0
        let struct (v162 : US2, v163 : obj, v164 : string) = v147.[int v161]
        v158.[int v161] <- struct (v162, v164)
        let v165 : int32 = v161 + 1
        v159.l0 <- v165
        ()
    let v166 : int32 = v149.Length
    let v167 : int32 = v158.Length
    let v168 : bool = v166 = v167
    let v169 : bool = v168 <> true
    let v172 : bool =
        if v169 then
            false
        else
            let v170 : int32 = 0
            method82(v149, v158, v170)
    let v173 : bool = v172 <> true
    if v173 then
        let v174 : US4 = US4_2
        let v175 : ((obj []) -> unit) = v1 v174
        let v176 : string = "> db_listener > effect"
        let v177 : obj = v176
        let v178 : string = "new_connections:"
        let v179 : obj = struct (v178, v147)
        let v180 : (obj []) = [|v177; v179|]
        v175 v180
        v0 v147
        ()
and closure374 (v0 : (unit -> (struct (US2 * obj * string) [])), v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v2 : (struct ((struct ((US2 []) * int32 * US3 * string * string) []) * (struct (US2 * obj * string) [])) -> unit)) () : unit =
    let v3 : (struct (US2 * obj * string) []) = v0 ()
    let v4 : (struct ((US2 []) * int32 * US3 * string * string) []) = v1 ()
    v2 struct (v4, v3)
    ()
and closure375 (v0 : (struct ((struct ((US2 []) * int32 * US3 * string * string) []) * (struct (US2 * obj * string) [])) -> unit)) () : unit =
    v0?clear ()
    ()
and method99 () : JSX.Element =
    let v108 : obj = emitJsExpr () "components_spi.state_context"
    let v109 : string = "useContext"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let struct (v112 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v113 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v114 : (unit -> int32), v115 : (int32 -> unit), v116 : (unit -> string), v117 : (string -> unit), v118 : (unit -> string), v119 : (string -> unit), v120 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v121 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v122 : (unit -> (struct (US2 * obj * string) [])), v123 : ((struct (US2 * obj * string) []) -> unit), v124 : (unit -> (struct (Guid * obj) [])), v125 : ((struct (Guid * obj) []) -> unit), v126 : (unit -> (struct (Guid * obj) [])), v127 : ((struct (Guid * obj) []) -> unit), v128 : (unit -> (struct (Guid * int32) [])), v129 : ((struct (Guid * int32) []) -> unit), v130 : (unit -> US4), v131 : (US4 -> unit), v132 : (unit -> US5), v133 : (US5 -> unit)) = v111.Invoke v108 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v242 : obj = emitJsExpr () "components_spi.state_context"
    let v243 : JS.Function = import v109 v110
    let struct (v244 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v245 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v246 : (unit -> int32), v247 : (int32 -> unit), v248 : (unit -> string), v249 : (string -> unit), v250 : (unit -> string), v251 : (string -> unit), v252 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v253 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v254 : (unit -> (struct (US2 * obj * string) [])), v255 : ((struct (US2 * obj * string) []) -> unit), v256 : (unit -> (struct (Guid * obj) [])), v257 : ((struct (Guid * obj) []) -> unit), v258 : (unit -> (struct (Guid * obj) [])), v259 : ((struct (Guid * obj) []) -> unit), v260 : (unit -> (struct (Guid * int32) [])), v261 : ((struct (Guid * int32) []) -> unit), v262 : (unit -> US4), v263 : (US4 -> unit), v264 : (unit -> US5), v265 : (US5 -> unit)) = v243.Invoke v242 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit) * (unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v266 : (unit -> (obj [])) = closure371(v122, v252)
    let v267 : string = "#cf1100"
    let v268 : (US4 -> ((obj []) -> unit)) = method16(v266, v267)
    let v269 : US4 = US4_0
    let v270 : ((obj []) -> unit) = v268 v269
    let v271 : string = "> db_listener ()"
    let v272 : obj = v271
    let v273 : (obj []) = [|v272|]
    v270 v273
    let v274 : string = "debounce"
    let v275 : string = "@solid-primitives/scheduled"
    let v276 : JS.Function = import v274 v275
    let v277 : (struct ((struct ((US2 []) * int32 * US3 * string * string) []) * (struct (US2 * obj * string) [])) -> unit) = closure372(v123, v268)
    let v278 : (struct ((struct ((US2 []) * int32 * US3 * string * string) []) * (struct (US2 * obj * string) [])) -> unit) = v276.Invoke (v277, 300) |> unbox<struct ((struct ((US2 []) * int32 * US3 * string * string) []) * (struct (US2 * obj * string) [])) -> unit>
    let v279 : string = "createEffect"
    let v280 : JS.Function = import v279 v110
    let v281 : (unit -> unit) = closure374(v122, v252, v278)
    v280.Invoke v281 |> ignore
    let v282 : string = "onCleanup"
    let v283 : JS.Function = import v282 v110
    let v284 : (unit -> unit) = closure375(v278)
    v283.Invoke v284 |> ignore
    let v285 : JSX.Element = JS.undefined
    v285
and closure370 () (v0 : Mut2) : JSX.Element =
    method99()
and method103 () : (struct (US0 * string * string * string) []) =
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
and method104 (v0 : US0) : struct ((unit -> US0) * (US0 -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke v0 |> unbox<JS.Function[]>
    let v5 : (unit -> US0) = v4.[0] |> unbox<unit -> US0>
    let v6 : (US0 -> unit) = v4.[1] |> unbox<US0 -> unit>
    struct (v5, v6)
and method105 (v0 : string) : struct ((unit -> string) * (string -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke v0 |> unbox<JS.Function[]>
    let v5 : (unit -> string) = v4.[0] |> unbox<unit -> string>
    let v6 : (string -> unit) = v4.[1] |> unbox<string -> unit>
    struct (v5, v6)
and method106 (v0 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) : struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke v0 |> unbox<JS.Function[]>
    let v5 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) = v4.[0] |> unbox<unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])>
    let v6 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) = v4.[1] |> unbox<(struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit>
    struct (v5, v6)
and method107 () : int32 =
    4001
and method108 (v0 : int32) : struct ((unit -> int32) * (int32 -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke v0 |> unbox<JS.Function[]>
    let v5 : (unit -> int32) = v4.[0] |> unbox<unit -> int32>
    let v6 : (int32 -> unit) = v4.[1] |> unbox<int32 -> unit>
    struct (v5, v6)
and method109 () : string =
    let v0 : string = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
    v0
and method110 () : string =
    let v0 : string = "http://localhost"
    v0
and method111 (v0 : (struct (US2 * obj * string) [])) : struct ((unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke v0 |> unbox<JS.Function[]>
    let v5 : (unit -> (struct (US2 * obj * string) [])) = v4.[0] |> unbox<unit -> (struct (US2 * obj * string) [])>
    let v6 : ((struct (US2 * obj * string) []) -> unit) = v4.[1] |> unbox<(struct (US2 * obj * string) []) -> unit>
    struct (v5, v6)
and method112 (v0 : (struct ((US2 []) * int32 * US3 * string * string) [])) : struct ((unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke v0 |> unbox<JS.Function[]>
    let v5 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) = v4.[0] |> unbox<unit -> (struct ((US2 []) * int32 * US3 * string * string) [])>
    let v6 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) = v4.[1] |> unbox<(struct ((US2 []) * int32 * US3 * string * string) []) -> unit>
    struct (v5, v6)
and method113 (v0 : US4) : struct ((unit -> US4) * (US4 -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke v0 |> unbox<JS.Function[]>
    let v5 : (unit -> US4) = v4.[0] |> unbox<unit -> US4>
    let v6 : (US4 -> unit) = v4.[1] |> unbox<US4 -> unit>
    struct (v5, v6)
and method114 (v0 : US5) : struct ((unit -> US5) * (US5 -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke v0 |> unbox<JS.Function[]>
    let v5 : (unit -> US5) = v4.[0] |> unbox<unit -> US5>
    let v6 : (US5 -> unit) = v4.[1] |> unbox<US5 -> unit>
    struct (v5, v6)
and method115 (v0 : (struct (Guid * int32) [])) : struct ((unit -> (struct (Guid * int32) [])) * ((struct (Guid * int32) []) -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke v0 |> unbox<JS.Function[]>
    let v5 : (unit -> (struct (Guid * int32) [])) = v4.[0] |> unbox<unit -> (struct (Guid * int32) [])>
    let v6 : ((struct (Guid * int32) []) -> unit) = v4.[1] |> unbox<(struct (Guid * int32) []) -> unit>
    struct (v5, v6)
and method116 (v0 : (struct (Guid * obj) [])) : struct ((unit -> (struct (Guid * obj) [])) * ((struct (Guid * obj) []) -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke v0 |> unbox<JS.Function[]>
    let v5 : (unit -> (struct (Guid * obj) [])) = v4.[0] |> unbox<unit -> (struct (Guid * obj) [])>
    let v6 : ((struct (Guid * obj) []) -> unit) = v4.[1] |> unbox<(struct (Guid * obj) []) -> unit>
    struct (v5, v6)
and closure376 () () : obj =
    let struct (v108 : string, v109 : obj, v110 : string, v111 : string, v112 : bool) = method2()
    let v113 : (struct (US0 * string * string * string) []) = method103()
    let v114 : int32 = v113.Length
    let v115 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) = Array.zeroCreate<struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit))> (v114)
    let v116 : Mut6 = {l0 = 0} : Mut6
    while method21(v114, v116) do
        let v118 : int32 = v116.l0
        let struct (v119 : US0, v120 : string, v121 : string, v122 : string) = v113.[int v118]
        let struct (v123 : (unit -> US0), v124 : (US0 -> unit)) = method104(v119)
        let struct (v125 : (unit -> string), v126 : (string -> unit)) = method105(v122)
        let struct (v127 : (unit -> string), v128 : (string -> unit)) = method105(v120)
        let struct (v129 : (unit -> string), v130 : (string -> unit)) = method105(v121)
        v115.[int v118] <- struct (v123, v124, v127, v128, v129, v130, v125, v126)
        let v131 : int32 = v118 + 1
        v116.l0 <- v131
        ()
    let struct (v132 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v133 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit)) = method106(v115)
    let v134 : bool = "" = v108
    let v136 : int32 =
        if v134 then
            method107()
        else
            80
    let struct (v137 : (unit -> int32), v138 : (int32 -> unit)) = method108(v136)
    let v139 : string = method109()
    let struct (v140 : (unit -> string), v141 : (string -> unit)) = method105(v139)
    let v144 : string =
        if v134 then
            method110()
        else
            let v143 : string = $"http://{v108}-4001.githubpreview.dev"
            v143
    let struct (v145 : (unit -> string), v146 : (string -> unit)) = method105(v144)
    let v147 : (struct (US2 * obj * string) []) = Array.zeroCreate<struct (US2 * obj * string)> (0)
    let struct (v148 : (unit -> (struct (US2 * obj * string) [])), v149 : ((struct (US2 * obj * string) []) -> unit)) = method111(v147)
    let v155 : string =
        if v134 then
            let v150 : string = "http://localhost"
            v150
        else
            let v151 : bool = true = v112
            if v151 then
                let v152 : string = "http://localhost"
                v152
            else
                let v153 : string = $"http://{v108}-9761.githubpreview.dev"
                v153
    let v160 : int32 =
        if v134 then
            let v156 : bool = true = v112
            if v156 then
                19761
            else
                let v157 : bool = false = v112
                if v157 then
                    9761
                else
                    80
        else
            80
    let v161 : (US2 []) = Array.zeroCreate<US2> (0)
    let v162 : US3 = US3_2
    let v163 : string = "peer"
    let v169 : string =
        if v134 then
            let v164 : string = "ws://localhost"
            v164
        else
            let v165 : bool = true = v112
            if v165 then
                let v166 : string = "ws://localhost"
                v166
            else
                let v167 : string = $"ws://{v108}-4944.githubpreview.dev"
                v167
    let v174 : int32 =
        if v134 then
            let v170 : bool = true = v112
            if v170 then
                14944
            else
                let v171 : bool = false = v112
                if v171 then
                    4944
                else
                    80
        else
            80
    let v175 : (US2 []) = Array.zeroCreate<US2> (0)
    let v176 : US3 = US3_1
    let v177 : string = "ws"
    let v183 : string =
        if v134 then
            let v178 : string = "wss://localhost"
            v178
        else
            let v179 : bool = true = v112
            if v179 then
                let v180 : string = "wss://localhost"
                v180
            else
                let v181 : string = $"ws://{v108}-8765.githubpreview.dev"
                v181
    let v188 : int32 =
        if v134 then
            let v184 : bool = true = v112
            if v184 then
                18765
            else
                let v185 : bool = false = v112
                if v185 then
                    8765
                else
                    80
        else
            80
    let v189 : (US2 []) = Array.zeroCreate<US2> (0)
    let v190 : US3 = US3_0
    let v191 : string = "gun"
    let v192 : (struct ((US2 []) * int32 * US3 * string * string) []) = [|struct (v161, v160, v162, v155, v163); struct (v175, v174, v176, v169, v177); struct (v189, v188, v190, v183, v191)|]
    let struct (v193 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v194 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit)) = method112(v192)
    let v195 : bool = "" = v110
    let v201 : US4 =
        if v195 then
            US4_0
        else
            let v197 : bool = true = v112
            if v197 then
                US4_0
            else
                US4_3
    let struct (v202 : (unit -> US4), v203 : (US4 -> unit)) = method113(v201)
    let v204 : US5 = US5_0
    let struct (v205 : (unit -> US5), v206 : (US5 -> unit)) = method114(v204)
    let v207 : (struct (Guid * int32) []) = Array.zeroCreate<struct (Guid * int32)> (0)
    let struct (v208 : (unit -> (struct (Guid * int32) [])), v209 : ((struct (Guid * int32) []) -> unit)) = method115(v207)
    let v210 : (struct (Guid * obj) []) = Array.zeroCreate<struct (Guid * obj)> (0)
    let struct (v211 : (unit -> (struct (Guid * obj) [])), v212 : ((struct (Guid * obj) []) -> unit)) = method116(v210)
    let v213 : (struct (Guid * obj) []) = Array.zeroCreate<struct (Guid * obj)> (0)
    let struct (v214 : (unit -> (struct (Guid * obj) [])), v215 : ((struct (Guid * obj) []) -> unit)) = method116(v213)
    let v216 : obj = struct (v132, v133, v137, v138, v140, v141, v145, v146, v193, v194, v148, v149, v214, v215, v211, v212, v208, v209, v202, v203, v205, v206)
    v216
let v0 : obj = JS.undefined
let v1 : Mut0 = {l0 = v0} : Mut0
let v72 : obj = emitJsExpr () "process.env"
let v73 : string = "env"
let v74 : (string * obj) = v73, v72
let v75 : ((string * obj) []) = [|v74|]
let v76 : obj = createObj v75
Browser.Dom.window?components_spi <- v76
let v77 : int32 = Random().Next ()
let v186 : obj = method0()
let v187 : string = "content"
let v188 : (Mut1 -> JSX.Element) = closure1()
let v189 : (string * obj) = v187, v188
let v190 : string = "db_listener"
let v191 : (Mut2 -> JSX.Element) = closure370()
let v192 : (string * obj) = v190, v191
let v193 : string = "run_id"
let v194 : (string * obj) = v193, v77
let v195 : string = "new_state_context_any"
let v196 : (unit -> obj) = closure376()
let v197 : (string * obj) = v195, v196
let v198 : string = "state_context"
let v199 : (string * obj) = v198, v186
let v200 : ((string * obj) []) = [|v189; v192; v194; v197; v199; v74|]
let v201 : obj = createObj v200
Browser.Dom.window?components_spi <- v201
v1.l0 <- v201
()
