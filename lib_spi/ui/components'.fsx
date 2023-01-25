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
    | US4_4
and [<Struct>] US5 =
    | US5_0
    | US5_1 of f1_0 : int32
and UH0 =
    | UH0_0 of string
    | UH0_1 of string * string
    | UH0_2 of string * string
    | UH0_3 of string * string * string
and [<Struct>] US6 =
    | US6_0
    | US6_1 of f1_0 : string
and UH1 =
    | UH1_0
    | UH1_1 of US6
    | UH1_2 of string * string * US6
    | UH1_3 of (string [])
    | UH1_4 of string * string * (string []) * (string [])
    | UH1_5 of bool
and [<Struct>] US7 =
    | US7_0
    | US7_1 of f1_0 : Fable.Core.JS.Function
and [<Struct>] US8 =
    | US8_0
    | US8_1 of f1_0 : bool
and [<Struct>] US9 =
    | US9_0
    | US9_1 of f1_0 : (unit -> (Fable.Core.JSX.Element []))
and [<Struct>] US10 =
    | US10_0
    | US10_1 of f1_0 : (obj [])
and [<Struct>] US11 =
    | US11_0
    | US11_1 of f1_0 : Fable.Core.JSX.Element
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
and UH2 =
    | UH2_0 of (string * obj) * UH2
    | UH2_1
and [<Struct>] US15 =
    | US15_0
    | US15_1
    | US15_2
and Mut3 = {mutable l0 : US13; mutable l1 : US13; mutable l2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)); mutable l3 : US15}
and Mut4 = {mutable l0 : (unit -> bool); mutable l1 : (bool -> unit); mutable l2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6))}
and Mut5 = {mutable l0 : bool; mutable l1 : bool; mutable l2 : US13; mutable l3 : US13; mutable l4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6))}
and Mut6 = {mutable l0 : int32}
and Mut7 = {mutable l0 : (unit -> Fable.Core.JS.Function); mutable l1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)); mutable l2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6))}
and Mut8 = {mutable l0 : (string -> obj); mutable l1 : (unit -> struct ((unit -> string) * (string -> unit))); mutable l2 : string}
and Mut9 = {mutable l0 : (int32 -> obj); mutable l1 : (unit -> struct ((unit -> int32) * (int32 -> unit))); mutable l2 : string}
and Mut10 = {mutable l0 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit))); mutable l2 : string}
and Mut11 = {mutable l0 : ((struct (US2 * obj * string) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit))); mutable l2 : string}
and Mut12 = {mutable l0 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit))); mutable l2 : string}
and Mut13 = {mutable l0 : (US4 -> obj); mutable l1 : (unit -> struct ((unit -> US4) * (US4 -> unit))); mutable l2 : string}
and Mut14 = {mutable l0 : (US5 -> obj); mutable l1 : (unit -> struct ((unit -> US5) * (US5 -> unit))); mutable l2 : string}
and Mut15 = {mutable l0 : ((struct (System.Guid * int32) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit))); mutable l2 : string}
and Mut16 = {mutable l0 : ((struct (System.Guid * obj) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit))); mutable l2 : string}
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
    | US16_1 of f1_0 : US2 * f1_1 : System.Guid * f1_2 : int32
and [<Struct>] US17 =
    | US17_0 of f0_0 : System.IDisposable
    | US17_1 of f1_0 : int64
and [<Struct>] US18 =
    | US18_0
    | US18_1 of f1_0 : US2 * f1_1 : Fable.Core.JS.Promise<US17> * f1_2 : string
and Mut26 = {mutable l0 : int32; mutable l1 : US18}
and Mut27 = {mutable l0 : int32; mutable l1 : obj}
and UH3 =
    | UH3_0 of System.Guid * int32 * UH3
    | UH3_1
and Mut28 = {mutable l0 : int32; mutable l1 : UH3}
and [<Struct>] US19 =
    | US19_0
    | US19_1 of f1_0 : US2 * f1_1 : System.Guid * f1_2 : (struct (System.Guid * obj) [])
and UH4 =
    | UH4_0 of System.Guid * obj * UH4
    | UH4_1
and Mut29 = {mutable l0 : int32; mutable l1 : UH4}
and [<Struct>] US20 =
    | US20_0
    | US20_1 of f1_0 : US2 * f1_1 : obj * f1_2 : string
and Mut30 = {mutable l0 : int32; mutable l1 : US20}
and [<Struct>] US21 =
    | US21_0
    | US21_1 of f1_0 : (US2 []) * f1_1 : int32 * f1_2 : US3 * f1_3 : string * f1_4 : string
and Mut31 = {mutable l0 : int32; mutable l1 : US21}
and Mut32 = {mutable l0 : int32; mutable l1 : (struct (US2 * obj * string) [])}
let rec closure0 () () : struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit)) =
    let struct (v0 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v1 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v2 : (unit -> int32), v3 : (int32 -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit), v8 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v9 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v10 : (unit -> (struct (US2 * obj * string) [])), v11 : ((struct (US2 * obj * string) []) -> unit), v12 : (unit -> (struct (System.Guid * obj) [])), v13 : ((struct (System.Guid * obj) []) -> unit), v14 : (unit -> (struct (System.Guid * obj) [])), v15 : ((struct (System.Guid * obj) []) -> unit), v16 : (unit -> (struct (System.Guid * int32) [])), v17 : ((struct (System.Guid * int32) []) -> unit), v18 : (unit -> US4), v19 : (US4 -> unit), v20 : (unit -> US5), v21 : (US5 -> unit)) = Fable.Core.JS.undefined
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21)
and method0 () : obj =
    let v0 : string = "createContext"
    let v1 : string = "solid-js"
    let v2 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v0 v1
    let v3 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))) = closure0()
    let v4 : obj = Fable.Core.JsInterop.emitJsExpr () $"{v2}<ReturnType<typeof {v3}>>()"
    v4
and method2 () : struct (string * obj * string * string * bool) =
    let v0 : obj = Fable.Core.JsInterop.emitJsExpr () "components.env"
    let v1 : string = Fable.Core.JsInterop.emitJsExpr v0 "$0.CODESPACE_NAME || \"\""
    let v2 : string = Fable.Core.JsInterop.emitJsExpr v0 "$0.GITHUB_RUN_ID || \"\""
    let v3 : string = Fable.Core.JsInterop.emitJsExpr v0 "$0.GITHUB_SHA || \"\""
    let v4 : string = "IS_TEST"
    let v5 : obj = (Fable.Core.JsInterop.(?)) v0 v4
    let v6 : bool = Fable.Core.JsInterop.emitJsExpr v5 "!$0"
    let v7 : bool = v6 = false
    struct (v1, v0, v2, v3, v7)
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
    let v75 : string =
        match v71 with
        | US6_0 -> (* None *)
            let v73 : string = "hidden"
            v73
        | US6_1(v72) -> (* Some *)
            v72
    let v76 : US6 = v0.l47
    let v80 : string =
        match v76 with
        | US6_0 -> (* None *)
            let v78 : string = "hidden"
            v78
        | US6_1(v77) -> (* Some *)
            v77
    let v81 : string = "flex"
    let v82 : US6 = US6_1(v81)
    let v83 : string = "1"
    let v84 : US6 = US6_1(v83)
    let v85 : string = "column"
    let v86 : US6 = US6_1(v85)
    let v87 : US6 = US6_1(v75)
    let v88 : US6 = US6_1(v80)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v82, v19, v20, v84, v86, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v87, v88, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
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
and closure11 () () : (Fable.Core.JSX.Element []) =
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
and method9 (v0 : UH2, v1 : int32) : int32 =
    match v0 with
    | UH2_0(v2, v3) -> (* Cons *)
        let v4 : int32 = v1 + 1
        method9(v3, v4)
    | UH2_1 -> (* Nil *)
        v1
and method10 (v0 : ((string * obj) []), v1 : UH2, v2 : int32) : int32 =
    match v1 with
    | UH2_0(v3, v4) -> (* Cons *)
        v0.[int v2] <- v3
        let v5 : int32 = v2 + 1
        method10(v0, v4, v5)
    | UH2_1 -> (* Nil *)
        v2
and method8 (v0 : UH2) : ((string * obj) []) =
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
    let v74 : bool = Fable.Core.JsInterop.emitJsExpr v73 "!$0"
    let v80 : UH2 =
        if v74 then
            UH2_1
        else
            let v76 : string = "alignItems"
            let v77 : (string * obj) = v76, v73
            let v78 : UH2 = UH2_1
            UH2_0(v77, v78)
    let v84 : obj =
        match v1 with
        | US6_0 -> (* None *)
            let v81 : obj = ()
            v81
        | US6_1(v82) -> (* Some *)
            let v83 : obj = v82
            v83
    let v85 : bool = Fable.Core.JsInterop.emitJsExpr v84 "!$0"
    let v89 : UH2 =
        if v85 then
            v80
        else
            let v86 : string = "alignSelf"
            let v87 : (string * obj) = v86, v84
            UH2_0(v87, v80)
    let v93 : obj =
        match v2 with
        | US6_0 -> (* None *)
            let v90 : obj = ()
            v90
        | US6_1(v91) -> (* Some *)
            let v92 : obj = v91
            v92
    let v94 : bool = Fable.Core.JsInterop.emitJsExpr v93 "!$0"
    let v98 : UH2 =
        if v94 then
            v89
        else
            let v95 : string = "aria-label"
            let v96 : (string * obj) = v95, v93
            UH2_0(v96, v89)
    let v102 : obj =
        match v3 with
        | US7_0 -> (* None *)
            let v99 : obj = ()
            v99
        | US7_1(v100) -> (* Some *)
            let v101 : obj = v100
            v101
    let v103 : bool = Fable.Core.JsInterop.emitJsExpr v102 "!$0"
    let v107 : UH2 =
        if v103 then
            v98
        else
            let v104 : string = "as"
            let v105 : (string * obj) = v104, v102
            UH2_0(v105, v98)
    let v111 : obj =
        match v4 with
        | US6_0 -> (* None *)
            let v108 : obj = ()
            v108
        | US6_1(v109) -> (* Some *)
            let v110 : obj = v109
            v110
    let v112 : bool = Fable.Core.JsInterop.emitJsExpr v111 "!$0"
    let v116 : UH2 =
        if v112 then
            v107
        else
            let v113 : string = "backgroundColor"
            let v114 : (string * obj) = v113, v111
            UH2_0(v114, v107)
    let v120 : obj =
        match v5 with
        | US6_0 -> (* None *)
            let v117 : obj = ()
            v117
        | US6_1(v118) -> (* Some *)
            let v119 : obj = v118
            v119
    let v121 : bool = Fable.Core.JsInterop.emitJsExpr v120 "!$0"
    let v125 : UH2 =
        if v121 then
            v116
        else
            let v122 : string = "border"
            let v123 : (string * obj) = v122, v120
            UH2_0(v123, v116)
    let v129 : obj =
        match v6 with
        | US6_0 -> (* None *)
            let v126 : obj = ()
            v126
        | US6_1(v127) -> (* Some *)
            let v128 : obj = v127
            v128
    let v130 : bool = Fable.Core.JsInterop.emitJsExpr v129 "!$0"
    let v134 : UH2 =
        if v130 then
            v125
        else
            let v131 : string = "borderBottomWidth"
            let v132 : (string * obj) = v131, v129
            UH2_0(v132, v125)
    let v138 : obj =
        match v7 with
        | US6_0 -> (* None *)
            let v135 : obj = ()
            v135
        | US6_1(v136) -> (* Some *)
            let v137 : obj = v136
            v137
    let v139 : bool = Fable.Core.JsInterop.emitJsExpr v138 "!$0"
    let v143 : UH2 =
        if v139 then
            v134
        else
            let v140 : string = "borderColor"
            let v141 : (string * obj) = v140, v138
            UH2_0(v141, v134)
    let v147 : obj =
        match v8 with
        | US6_0 -> (* None *)
            let v144 : obj = ()
            v144
        | US6_1(v145) -> (* Some *)
            let v146 : obj = v145
            v146
    let v148 : bool = Fable.Core.JsInterop.emitJsExpr v147 "!$0"
    let v152 : UH2 =
        if v148 then
            v143
        else
            let v149 : string = "borderWidth"
            let v150 : (string * obj) = v149, v147
            UH2_0(v150, v143)
    let v156 : obj =
        match v9 with
        | US6_0 -> (* None *)
            let v153 : obj = ()
            v153
        | US6_1(v154) -> (* Some *)
            let v155 : obj = v154
            v155
    let v157 : bool = Fable.Core.JsInterop.emitJsExpr v156 "!$0"
    let v161 : UH2 =
        if v157 then
            v152
        else
            let v158 : string = "bottom"
            let v159 : (string * obj) = v158, v156
            UH2_0(v159, v152)
    let v165 : obj =
        match v10 with
        | US8_0 -> (* None *)
            let v162 : obj = ()
            v162
        | US8_1(v163) -> (* Some *)
            let v164 : obj = v163
            v164
    let v166 : bool = Fable.Core.JsInterop.emitJsExpr v165 "!$0"
    let v170 : UH2 =
        if v166 then
            v161
        else
            let v167 : string = "checked"
            let v168 : (string * obj) = v167, v165
            UH2_0(v168, v161)
    let v174 : obj =
        match v11 with
        | US9_0 -> (* None *)
            let v171 : obj = ()
            v171
        | US9_1(v172) -> (* Some *)
            let v173 : obj = v172
            v173
    let v175 : bool = Fable.Core.JsInterop.emitJsExpr v174 "!$0"
    let v179 : UH2 =
        if v175 then
            v170
        else
            let v176 : string = "children"
            let v177 : (string * obj) = v176, v174
            UH2_0(v177, v170)
    let v183 : obj =
        match v12 with
        | US6_0 -> (* None *)
            let v180 : obj = ()
            v180
        | US6_1(v181) -> (* Some *)
            let v182 : obj = v181
            v182
    let v184 : bool = Fable.Core.JsInterop.emitJsExpr v183 "!$0"
    let v188 : UH2 =
        if v184 then
            v179
        else
            let v185 : string = "color"
            let v186 : (string * obj) = v185, v183
            UH2_0(v186, v179)
    let v192 : obj =
        match v13 with
        | US6_0 -> (* None *)
            let v189 : obj = ()
            v189
        | US6_1(v190) -> (* Some *)
            let v191 : obj = v190
            v191
    let v193 : bool = Fable.Core.JsInterop.emitJsExpr v192 "!$0"
    let v197 : UH2 =
        if v193 then
            v188
        else
            let v194 : string = "colorScheme"
            let v195 : (string * obj) = v194, v192
            UH2_0(v195, v188)
    let v201 : obj =
        match v14 with
        | US8_0 -> (* None *)
            let v198 : obj = ()
            v198
        | US8_1(v199) -> (* Some *)
            let v200 : obj = v199
            v200
    let v202 : bool = Fable.Core.JsInterop.emitJsExpr v201 "!$0"
    let v206 : UH2 =
        if v202 then
            v197
        else
            let v203 : string = "compact"
            let v204 : (string * obj) = v203, v201
            UH2_0(v204, v197)
    let v210 : obj =
        match v15 with
        | US6_0 -> (* None *)
            let v207 : obj = ()
            v207
        | US6_1(v208) -> (* Some *)
            let v209 : obj = v208
            v209
    let v211 : bool = Fable.Core.JsInterop.emitJsExpr v210 "!$0"
    let v215 : UH2 =
        if v211 then
            v206
        else
            let v212 : string = "defaultValue"
            let v213 : (string * obj) = v212, v210
            UH2_0(v213, v206)
    let v219 : obj =
        match v16 with
        | US6_0 -> (* None *)
            let v216 : obj = ()
            v216
        | US6_1(v217) -> (* Some *)
            let v218 : obj = v217
            v218
    let v220 : bool = Fable.Core.JsInterop.emitJsExpr v219 "!$0"
    let v224 : UH2 =
        if v220 then
            v215
        else
            let v221 : string = "direction"
            let v222 : (string * obj) = v221, v219
            UH2_0(v222, v215)
    let v228 : obj =
        match v17 with
        | US6_0 -> (* None *)
            let v225 : obj = ()
            v225
        | US6_1(v226) -> (* Some *)
            let v227 : obj = v226
            v227
    let v229 : bool = Fable.Core.JsInterop.emitJsExpr v228 "!$0"
    let v233 : UH2 =
        if v229 then
            v224
        else
            let v230 : string = "display"
            let v231 : (string * obj) = v230, v228
            UH2_0(v231, v224)
    let v237 : obj =
        match v18 with
        | US10_0 -> (* None *)
            let v234 : obj = ()
            v234
        | US10_1(v235) -> (* Some *)
            let v236 : obj = v235
            v236
    let v238 : bool = Fable.Core.JsInterop.emitJsExpr v237 "!$0"
    let v242 : UH2 =
        if v238 then
            v233
        else
            let v239 : string = "each"
            let v240 : (string * obj) = v239, v237
            UH2_0(v240, v233)
    let v246 : obj =
        match v19 with
        | US8_0 -> (* None *)
            let v243 : obj = ()
            v243
        | US8_1(v244) -> (* Some *)
            let v245 : obj = v244
            v245
    let v247 : bool = Fable.Core.JsInterop.emitJsExpr v246 "!$0"
    let v251 : UH2 =
        if v247 then
            v242
        else
            let v248 : string = "external"
            let v249 : (string * obj) = v248, v246
            UH2_0(v249, v242)
    let v255 : obj =
        match v20 with
        | US6_0 -> (* None *)
            let v252 : obj = ()
            v252
        | US6_1(v253) -> (* Some *)
            let v254 : obj = v253
            v254
    let v256 : bool = Fable.Core.JsInterop.emitJsExpr v255 "!$0"
    let v260 : UH2 =
        if v256 then
            v251
        else
            let v257 : string = "flex"
            let v258 : (string * obj) = v257, v255
            UH2_0(v258, v251)
    let v264 : obj =
        match v21 with
        | US6_0 -> (* None *)
            let v261 : obj = ()
            v261
        | US6_1(v262) -> (* Some *)
            let v263 : obj = v262
            v263
    let v265 : bool = Fable.Core.JsInterop.emitJsExpr v264 "!$0"
    let v269 : UH2 =
        if v265 then
            v260
        else
            let v266 : string = "flexDirection"
            let v267 : (string * obj) = v266, v264
            UH2_0(v267, v260)
    let v273 : obj =
        match v22 with
        | US6_0 -> (* None *)
            let v270 : obj = ()
            v270
        | US6_1(v271) -> (* Some *)
            let v272 : obj = v271
            v272
    let v274 : bool = Fable.Core.JsInterop.emitJsExpr v273 "!$0"
    let v278 : UH2 =
        if v274 then
            v269
        else
            let v275 : string = "flexFlow"
            let v276 : (string * obj) = v275, v273
            UH2_0(v276, v269)
    let v282 : obj =
        match v23 with
        | US6_0 -> (* None *)
            let v279 : obj = ()
            v279
        | US6_1(v280) -> (* Some *)
            let v281 : obj = v280
            v281
    let v283 : bool = Fable.Core.JsInterop.emitJsExpr v282 "!$0"
    let v287 : UH2 =
        if v283 then
            v278
        else
            let v284 : string = "fontSize"
            let v285 : (string * obj) = v284, v282
            UH2_0(v285, v278)
    let v291 : obj =
        match v24 with
        | US6_0 -> (* None *)
            let v288 : obj = ()
            v288
        | US6_1(v289) -> (* Some *)
            let v290 : obj = v289
            v290
    let v292 : bool = Fable.Core.JsInterop.emitJsExpr v291 "!$0"
    let v296 : UH2 =
        if v292 then
            v287
        else
            let v293 : string = "height"
            let v294 : (string * obj) = v293, v291
            UH2_0(v294, v287)
    let v300 : obj =
        match v25 with
        | US6_0 -> (* None *)
            let v297 : obj = ()
            v297
        | US6_1(v298) -> (* Some *)
            let v299 : obj = v298
            v299
    let v301 : bool = Fable.Core.JsInterop.emitJsExpr v300 "!$0"
    let v305 : UH2 =
        if v301 then
            v296
        else
            let v302 : string = "href"
            let v303 : (string * obj) = v302, v300
            UH2_0(v303, v296)
    let v309 : obj =
        match v26 with
        | US11_0 -> (* None *)
            let v306 : obj = ()
            v306
        | US11_1(v307) -> (* Some *)
            let v308 : obj = v307
            v308
    let v310 : bool = Fable.Core.JsInterop.emitJsExpr v309 "!$0"
    let v314 : UH2 =
        if v310 then
            v305
        else
            let v311 : string = "icon"
            let v312 : (string * obj) = v311, v309
            UH2_0(v312, v305)
    let v318 : obj =
        match v27 with
        | US6_0 -> (* None *)
            let v315 : obj = ()
            v315
        | US6_1(v316) -> (* Some *)
            let v317 : obj = v316
            v317
    let v319 : bool = Fable.Core.JsInterop.emitJsExpr v318 "!$0"
    let v323 : UH2 =
        if v319 then
            v314
        else
            let v320 : string = "id"
            let v321 : (string * obj) = v320, v318
            UH2_0(v321, v314)
    let v327 : obj =
        match v28 with
        | US6_0 -> (* None *)
            let v324 : obj = ()
            v324
        | US6_1(v325) -> (* Some *)
            let v326 : obj = v325
            v326
    let v328 : bool = Fable.Core.JsInterop.emitJsExpr v327 "!$0"
    let v332 : UH2 =
        if v328 then
            v323
        else
            let v329 : string = "justifyContent"
            let v330 : (string * obj) = v329, v327
            UH2_0(v330, v323)
    let v336 : obj =
        match v29 with
        | US6_0 -> (* None *)
            let v333 : obj = ()
            v333
        | US6_1(v334) -> (* Some *)
            let v335 : obj = v334
            v335
    let v337 : bool = Fable.Core.JsInterop.emitJsExpr v336 "!$0"
    let v341 : UH2 =
        if v337 then
            v332
        else
            let v338 : string = "left"
            let v339 : (string * obj) = v338, v336
            UH2_0(v339, v332)
    let v345 : obj =
        match v30 with
        | US11_0 -> (* None *)
            let v342 : obj = ()
            v342
        | US11_1(v343) -> (* Some *)
            let v344 : obj = v343
            v344
    let v346 : bool = Fable.Core.JsInterop.emitJsExpr v345 "!$0"
    let v350 : UH2 =
        if v346 then
            v341
        else
            let v347 : string = "leftIcon"
            let v348 : (string * obj) = v347, v345
            UH2_0(v348, v341)
    let v354 : obj =
        match v31 with
        | US6_0 -> (* None *)
            let v351 : obj = ()
            v351
        | US6_1(v352) -> (* Some *)
            let v353 : obj = v352
            v353
    let v355 : bool = Fable.Core.JsInterop.emitJsExpr v354 "!$0"
    let v359 : UH2 =
        if v355 then
            v350
        else
            let v356 : string = "lineHeight"
            let v357 : (string * obj) = v356, v354
            UH2_0(v357, v350)
    let v363 : obj =
        match v32 with
        | US6_0 -> (* None *)
            let v360 : obj = ()
            v360
        | US6_1(v361) -> (* Some *)
            let v362 : obj = v361
            v362
    let v364 : bool = Fable.Core.JsInterop.emitJsExpr v363 "!$0"
    let v368 : UH2 =
        if v364 then
            v359
        else
            let v365 : string = "margin"
            let v366 : (string * obj) = v365, v363
            UH2_0(v366, v359)
    let v372 : obj =
        match v33 with
        | US6_0 -> (* None *)
            let v369 : obj = ()
            v369
        | US6_1(v370) -> (* Some *)
            let v371 : obj = v370
            v371
    let v373 : bool = Fable.Core.JsInterop.emitJsExpr v372 "!$0"
    let v377 : UH2 =
        if v373 then
            v368
        else
            let v374 : string = "marginBottom"
            let v375 : (string * obj) = v374, v372
            UH2_0(v375, v368)
    let v381 : obj =
        match v34 with
        | US6_0 -> (* None *)
            let v378 : obj = ()
            v378
        | US6_1(v379) -> (* Some *)
            let v380 : obj = v379
            v380
    let v382 : bool = Fable.Core.JsInterop.emitJsExpr v381 "!$0"
    let v386 : UH2 =
        if v382 then
            v377
        else
            let v383 : string = "marginLeft"
            let v384 : (string * obj) = v383, v381
            UH2_0(v384, v377)
    let v390 : obj =
        match v35 with
        | US6_0 -> (* None *)
            let v387 : obj = ()
            v387
        | US6_1(v388) -> (* Some *)
            let v389 : obj = v388
            v389
    let v391 : bool = Fable.Core.JsInterop.emitJsExpr v390 "!$0"
    let v395 : UH2 =
        if v391 then
            v386
        else
            let v392 : string = "marginRight"
            let v393 : (string * obj) = v392, v390
            UH2_0(v393, v386)
    let v399 : obj =
        match v36 with
        | US6_0 -> (* None *)
            let v396 : obj = ()
            v396
        | US6_1(v397) -> (* Some *)
            let v398 : obj = v397
            v398
    let v400 : bool = Fable.Core.JsInterop.emitJsExpr v399 "!$0"
    let v404 : UH2 =
        if v400 then
            v395
        else
            let v401 : string = "marginTop"
            let v402 : (string * obj) = v401, v399
            UH2_0(v402, v395)
    let v408 : obj =
        match v37 with
        | US6_0 -> (* None *)
            let v405 : obj = ()
            v405
        | US6_1(v406) -> (* Some *)
            let v407 : obj = v406
            v407
    let v409 : bool = Fable.Core.JsInterop.emitJsExpr v408 "!$0"
    let v413 : UH2 =
        if v409 then
            v404
        else
            let v410 : string = "maxHeight"
            let v411 : (string * obj) = v410, v408
            UH2_0(v411, v404)
    let v417 : obj =
        match v38 with
        | US6_0 -> (* None *)
            let v414 : obj = ()
            v414
        | US6_1(v415) -> (* Some *)
            let v416 : obj = v415
            v416
    let v418 : bool = Fable.Core.JsInterop.emitJsExpr v417 "!$0"
    let v422 : UH2 =
        if v418 then
            v413
        else
            let v419 : string = "maxWidth"
            let v420 : (string * obj) = v419, v417
            UH2_0(v420, v413)
    let v426 : obj =
        match v39 with
        | US6_0 -> (* None *)
            let v423 : obj = ()
            v423
        | US6_1(v424) -> (* Some *)
            let v425 : obj = v424
            v425
    let v427 : bool = Fable.Core.JsInterop.emitJsExpr v426 "!$0"
    let v431 : UH2 =
        if v427 then
            v422
        else
            let v428 : string = "minHeight"
            let v429 : (string * obj) = v428, v426
            UH2_0(v429, v422)
    let v435 : obj =
        match v40 with
        | US6_0 -> (* None *)
            let v432 : obj = ()
            v432
        | US6_1(v433) -> (* Some *)
            let v434 : obj = v433
            v434
    let v436 : bool = Fable.Core.JsInterop.emitJsExpr v435 "!$0"
    let v440 : UH2 =
        if v436 then
            v431
        else
            let v437 : string = "minWidth"
            let v438 : (string * obj) = v437, v435
            UH2_0(v438, v431)
    let v444 : obj =
        match v41 with
        | US12_0 -> (* None *)
            let v441 : obj = ()
            v441
        | US12_1(v442) -> (* Some *)
            let v443 : obj = v442
            v443
    let v445 : bool = Fable.Core.JsInterop.emitJsExpr v444 "!$0"
    let v449 : UH2 =
        if v445 then
            v440
        else
            let v446 : string = "onChange"
            let v447 : (string * obj) = v446, v444
            UH2_0(v447, v440)
    let v453 : obj =
        match v42 with
        | US13_0 -> (* None *)
            let v450 : obj = ()
            v450
        | US13_1(v451) -> (* Some *)
            let v452 : obj = v451
            v452
    let v454 : bool = Fable.Core.JsInterop.emitJsExpr v453 "!$0"
    let v458 : UH2 =
        if v454 then
            v449
        else
            let v455 : string = "onClick"
            let v456 : (string * obj) = v455, v453
            UH2_0(v456, v449)
    let v462 : obj =
        match v43 with
        | US12_0 -> (* None *)
            let v459 : obj = ()
            v459
        | US12_1(v460) -> (* Some *)
            let v461 : obj = v460
            v461
    let v463 : bool = Fable.Core.JsInterop.emitJsExpr v462 "!$0"
    let v467 : UH2 =
        if v463 then
            v458
        else
            let v464 : string = "onInput"
            let v465 : (string * obj) = v464, v462
            UH2_0(v465, v458)
    let v471 : obj =
        match v44 with
        | US6_0 -> (* None *)
            let v468 : obj = ()
            v468
        | US6_1(v469) -> (* Some *)
            let v470 : obj = v469
            v470
    let v472 : bool = Fable.Core.JsInterop.emitJsExpr v471 "!$0"
    let v476 : UH2 =
        if v472 then
            v467
        else
            let v473 : string = "outline"
            let v474 : (string * obj) = v473, v471
            UH2_0(v474, v467)
    let v480 : obj =
        match v45 with
        | US6_0 -> (* None *)
            let v477 : obj = ()
            v477
        | US6_1(v478) -> (* Some *)
            let v479 : obj = v478
            v479
    let v481 : bool = Fable.Core.JsInterop.emitJsExpr v480 "!$0"
    let v485 : UH2 =
        if v481 then
            v476
        else
            let v482 : string = "overflow"
            let v483 : (string * obj) = v482, v480
            UH2_0(v483, v476)
    let v489 : obj =
        match v46 with
        | US6_0 -> (* None *)
            let v486 : obj = ()
            v486
        | US6_1(v487) -> (* Some *)
            let v488 : obj = v487
            v488
    let v490 : bool = Fable.Core.JsInterop.emitJsExpr v489 "!$0"
    let v494 : UH2 =
        if v490 then
            v485
        else
            let v491 : string = "overflowX"
            let v492 : (string * obj) = v491, v489
            UH2_0(v492, v485)
    let v498 : obj =
        match v47 with
        | US6_0 -> (* None *)
            let v495 : obj = ()
            v495
        | US6_1(v496) -> (* Some *)
            let v497 : obj = v496
            v497
    let v499 : bool = Fable.Core.JsInterop.emitJsExpr v498 "!$0"
    let v503 : UH2 =
        if v499 then
            v494
        else
            let v500 : string = "overflowY"
            let v501 : (string * obj) = v500, v498
            UH2_0(v501, v494)
    let v507 : obj =
        match v48 with
        | US6_0 -> (* None *)
            let v504 : obj = ()
            v504
        | US6_1(v505) -> (* Some *)
            let v506 : obj = v505
            v506
    let v508 : bool = Fable.Core.JsInterop.emitJsExpr v507 "!$0"
    let v512 : UH2 =
        if v508 then
            v503
        else
            let v509 : string = "padding"
            let v510 : (string * obj) = v509, v507
            UH2_0(v510, v503)
    let v516 : obj =
        match v49 with
        | US6_0 -> (* None *)
            let v513 : obj = ()
            v513
        | US6_1(v514) -> (* Some *)
            let v515 : obj = v514
            v515
    let v517 : bool = Fable.Core.JsInterop.emitJsExpr v516 "!$0"
    let v521 : UH2 =
        if v517 then
            v512
        else
            let v518 : string = "paddingBottom"
            let v519 : (string * obj) = v518, v516
            UH2_0(v519, v512)
    let v525 : obj =
        match v50 with
        | US6_0 -> (* None *)
            let v522 : obj = ()
            v522
        | US6_1(v523) -> (* Some *)
            let v524 : obj = v523
            v524
    let v526 : bool = Fable.Core.JsInterop.emitJsExpr v525 "!$0"
    let v530 : UH2 =
        if v526 then
            v521
        else
            let v527 : string = "paddingLeft"
            let v528 : (string * obj) = v527, v525
            UH2_0(v528, v521)
    let v534 : obj =
        match v51 with
        | US6_0 -> (* None *)
            let v531 : obj = ()
            v531
        | US6_1(v532) -> (* Some *)
            let v533 : obj = v532
            v533
    let v535 : bool = Fable.Core.JsInterop.emitJsExpr v534 "!$0"
    let v539 : UH2 =
        if v535 then
            v530
        else
            let v536 : string = "paddingRight"
            let v537 : (string * obj) = v536, v534
            UH2_0(v537, v530)
    let v543 : obj =
        match v52 with
        | US6_0 -> (* None *)
            let v540 : obj = ()
            v540
        | US6_1(v541) -> (* Some *)
            let v542 : obj = v541
            v542
    let v544 : bool = Fable.Core.JsInterop.emitJsExpr v543 "!$0"
    let v548 : UH2 =
        if v544 then
            v539
        else
            let v545 : string = "paddingTop"
            let v546 : (string * obj) = v545, v543
            UH2_0(v546, v539)
    let v552 : obj =
        match v53 with
        | US6_0 -> (* None *)
            let v549 : obj = ()
            v549
        | US6_1(v550) -> (* Some *)
            let v551 : obj = v550
            v551
    let v553 : bool = Fable.Core.JsInterop.emitJsExpr v552 "!$0"
    let v557 : UH2 =
        if v553 then
            v548
        else
            let v554 : string = "placeholder"
            let v555 : (string * obj) = v554, v552
            UH2_0(v555, v548)
    let v561 : obj =
        match v54 with
        | US6_0 -> (* None *)
            let v558 : obj = ()
            v558
        | US6_1(v559) -> (* Some *)
            let v560 : obj = v559
            v560
    let v562 : bool = Fable.Core.JsInterop.emitJsExpr v561 "!$0"
    let v566 : UH2 =
        if v562 then
            v557
        else
            let v563 : string = "position"
            let v564 : (string * obj) = v563, v561
            UH2_0(v564, v557)
    let v570 : obj =
        match v55 with
        | US6_0 -> (* None *)
            let v567 : obj = ()
            v567
        | US6_1(v568) -> (* Some *)
            let v569 : obj = v568
            v569
    let v571 : bool = Fable.Core.JsInterop.emitJsExpr v570 "!$0"
    let v575 : UH2 =
        if v571 then
            v566
        else
            let v572 : string = "right"
            let v573 : (string * obj) = v572, v570
            UH2_0(v573, v566)
    let v579 : obj =
        match v56 with
        | US6_0 -> (* None *)
            let v576 : obj = ()
            v576
        | US6_1(v577) -> (* Some *)
            let v578 : obj = v577
            v578
    let v580 : bool = Fable.Core.JsInterop.emitJsExpr v579 "!$0"
    let v584 : UH2 =
        if v580 then
            v575
        else
            let v581 : string = "size"
            let v582 : (string * obj) = v581, v579
            UH2_0(v582, v575)
    let v588 : obj =
        match v57 with
        | US6_0 -> (* None *)
            let v585 : obj = ()
            v585
        | US6_1(v586) -> (* Some *)
            let v587 : obj = v586
            v587
    let v589 : bool = Fable.Core.JsInterop.emitJsExpr v588 "!$0"
    let v593 : UH2 =
        if v589 then
            v584
        else
            let v590 : string = "spacing"
            let v591 : (string * obj) = v590, v588
            UH2_0(v591, v584)
    let v597 : obj =
        match v58 with
        | US6_0 -> (* None *)
            let v594 : obj = ()
            v594
        | US6_1(v595) -> (* Some *)
            let v596 : obj = v595
            v596
    let v598 : bool = Fable.Core.JsInterop.emitJsExpr v597 "!$0"
    let v602 : UH2 =
        if v598 then
            v593
        else
            let v599 : string = "src"
            let v600 : (string * obj) = v599, v597
            UH2_0(v600, v593)
    let v606 : obj =
        match v59 with
        | US6_0 -> (* None *)
            let v603 : obj = ()
            v603
        | US6_1(v604) -> (* Some *)
            let v605 : obj = v604
            v605
    let v607 : bool = Fable.Core.JsInterop.emitJsExpr v606 "!$0"
    let v611 : UH2 =
        if v607 then
            v602
        else
            let v608 : string = "striped"
            let v609 : (string * obj) = v608, v606
            UH2_0(v609, v602)
    let v615 : obj =
        match v60 with
        | US14_0 -> (* None *)
            let v612 : obj = ()
            v612
        | US14_1(v613) -> (* Some *)
            let v614 : obj = v613
            v614
    let v616 : bool = Fable.Core.JsInterop.emitJsExpr v615 "!$0"
    let v620 : UH2 =
        if v616 then
            v611
        else
            let v617 : string = "sx"
            let v618 : (string * obj) = v617, v615
            UH2_0(v618, v611)
    let v624 : obj =
        match v61 with
        | US6_0 -> (* None *)
            let v621 : obj = ()
            v621
        | US6_1(v622) -> (* Some *)
            let v623 : obj = v622
            v623
    let v625 : bool = Fable.Core.JsInterop.emitJsExpr v624 "!$0"
    let v629 : UH2 =
        if v625 then
            v620
        else
            let v626 : string = "thickness"
            let v627 : (string * obj) = v626, v624
            UH2_0(v627, v620)
    let v633 : obj =
        match v62 with
        | US11_0 -> (* None *)
            let v630 : obj = ()
            v630
        | US11_1(v631) -> (* Some *)
            let v632 : obj = v631
            v632
    let v634 : bool = Fable.Core.JsInterop.emitJsExpr v633 "!$0"
    let v638 : UH2 =
        if v634 then
            v629
        else
            let v635 : string = "title"
            let v636 : (string * obj) = v635, v633
            UH2_0(v636, v629)
    let v642 : obj =
        match v63 with
        | US6_0 -> (* None *)
            let v639 : obj = ()
            v639
        | US6_1(v640) -> (* Some *)
            let v641 : obj = v640
            v641
    let v643 : bool = Fable.Core.JsInterop.emitJsExpr v642 "!$0"
    let v647 : UH2 =
        if v643 then
            v638
        else
            let v644 : string = "top"
            let v645 : (string * obj) = v644, v642
            UH2_0(v645, v638)
    let v651 : obj =
        match v64 with
        | US6_0 -> (* None *)
            let v648 : obj = ()
            v648
        | US6_1(v649) -> (* Some *)
            let v650 : obj = v649
            v650
    let v652 : bool = Fable.Core.JsInterop.emitJsExpr v651 "!$0"
    let v656 : UH2 =
        if v652 then
            v647
        else
            let v653 : string = "type"
            let v654 : (string * obj) = v653, v651
            UH2_0(v654, v647)
    let v660 : obj =
        match v65 with
        | US14_0 -> (* None *)
            let v657 : obj = ()
            v657
        | US14_1(v658) -> (* Some *)
            let v659 : obj = v658
            v659
    let v661 : bool = Fable.Core.JsInterop.emitJsExpr v660 "!$0"
    let v665 : UH2 =
        if v661 then
            v656
        else
            let v662 : string = "value"
            let v663 : (string * obj) = v662, v660
            UH2_0(v663, v656)
    let v669 : obj =
        match v66 with
        | US14_0 -> (* None *)
            let v666 : obj = ()
            v666
        | US14_1(v667) -> (* Some *)
            let v668 : obj = v667
            v668
    let v670 : bool = Fable.Core.JsInterop.emitJsExpr v669 "!$0"
    let v674 : UH2 =
        if v670 then
            v665
        else
            let v671 : string = "when"
            let v672 : (string * obj) = v671, v669
            UH2_0(v672, v665)
    let v678 : obj =
        match v67 with
        | US6_0 -> (* None *)
            let v675 : obj = ()
            v675
        | US6_1(v676) -> (* Some *)
            let v677 : obj = v676
            v677
    let v679 : bool = Fable.Core.JsInterop.emitJsExpr v678 "!$0"
    let v683 : UH2 =
        if v679 then
            v674
        else
            let v680 : string = "width"
            let v681 : (string * obj) = v680, v678
            UH2_0(v681, v674)
    let v687 : obj =
        match v68 with
        | US5_0 -> (* None *)
            let v684 : obj = ()
            v684
        | US5_1(v685) -> (* Some *)
            let v686 : obj = v685
            v686
    let v688 : bool = Fable.Core.JsInterop.emitJsExpr v687 "!$0"
    let v692 : UH2 =
        if v688 then
            v683
        else
            let v689 : string = "zIndex"
            let v690 : (string * obj) = v689, v687
            UH2_0(v690, v683)
    let v696 : obj =
        match v69 with
        | US6_0 -> (* None *)
            let v693 : obj = ()
            v693
        | US6_1(v694) -> (* Some *)
            let v695 : obj = v694
            v695
    let v697 : bool = Fable.Core.JsInterop.emitJsExpr v696 "!$0"
    let v701 : UH2 =
        if v697 then
            v692
        else
            let v698 : string = "zoom"
            let v699 : (string * obj) = v698, v696
            UH2_0(v699, v692)
    method8(v701)
and method5 (v0 : Fable.Core.JS.Function, v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)), v2 : (unit -> (Fable.Core.JSX.Element []))) : Fable.Core.JSX.Element =
    let struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US6, v19 : US6, v20 : US6, v21 : US10, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US11, v30 : US6, v31 : US6, v32 : US6, v33 : US11, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US12, v45 : US13, v46 : US12, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US14, v64 : US6, v65 : US11, v66 : US6, v67 : US6, v68 : US14, v69 : US14, v70 : US6, v71 : US5, v72 : US6) = method6()
    let struct (v73 : US6, v74 : US6, v75 : US6, v76 : US7, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US6, v83 : US8, v84 : US9, v85 : US6, v86 : US6, v87 : US8, v88 : US6, v89 : US6, v90 : US6, v91 : US10, v92 : US8, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US6, v99 : US11, v100 : US6, v101 : US6, v102 : US6, v103 : US11, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US12, v115 : US13, v116 : US12, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US14, v134 : US6, v135 : US11, v136 : US6, v137 : US6, v138 : US14, v139 : US14, v140 : US6, v141 : US5, v142 : US6) = v1 struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v151 : US9 =
        match v84 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v143) -> (* Some *)
            let v144 : string = "children"
            let v145 : string = "solid-js"
            let v146 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v144 v145
            let v147 : (unit -> (Fable.Core.JSX.Element [])) = v146.Invoke v143 |> unbox<unit -> Fable.Core.JSX.Element[]>
            US9_1(v147)
    let v154 : (unit -> (Fable.Core.JSX.Element [])) =
        match v151 with
        | US9_0 -> (* None *)
            v2
        | US9_1(v152) -> (* Some *)
            v152
    let v155 : US9 = US9_1(v154)
    let v156 : ((string * obj) []) = method7(v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v155, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142)
    let v157 : obj = Fable.Core.JsInterop.createObj v156
    Fable.Core.JsInterop.emitJsExpr (v157, v2) "$0.children = $1"
    let v158 : (obj -> Fable.Core.JSX.Element) = v0 |> unbox<(obj -> Fable.Core.JSX.Element)>
    let v159 : string = "createComponent"
    let v160 : string = "solid-js"
    let v161 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v159 v160
    let v162 : Fable.Core.JSX.Element = v161.Invoke (v158, v157) |> unbox<Fable.Core.JSX.Element>
    v162
and closure9 (v0 : Mut1) () : (Fable.Core.JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/core"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : obj = v3
    let v5 : string = "tbody"
    let v6 : obj = (Fable.Core.JsInterop.(?)) v4 v5
    let v7 : Fable.Core.JS.Function = v6 |> unbox<Fable.Core.JS.Function>
    let v8 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure10()
    let v9 : US9 = v0.l11
    let v13 : (unit -> (Fable.Core.JSX.Element [])) =
        match v9 with
        | US9_0 -> (* None *)
            closure11()
        | US9_1(v10) -> (* Some *)
            v10
    let v14 : Fable.Core.JSX.Element = method5(v7, v8, v13)
    [|v14|]
and method4 (v0 : Mut1) : Fable.Core.JSX.Element =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/core"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : obj = v3
    let v5 : string = "table"
    let v6 : obj = (Fable.Core.JsInterop.(?)) v4 v5
    let v7 : Fable.Core.JS.Function = v6 |> unbox<Fable.Core.JS.Function>
    let v8 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure8(v0)
    let v9 : (unit -> (Fable.Core.JSX.Element [])) = closure9(v0)
    method5(v7, v8, v9)
and closure7 () (v0 : Mut1) : Fable.Core.JSX.Element =
    method4(v0)
and closure12 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and method12 (v0 : bool) : struct ((unit -> bool) * (bool -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (Fable.Core.JS.Function []) = v3.Invoke v0 |> unbox<Fable.Core.JS.Function[]>
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
            v71 ()
    let v151 : string =
        if v146 then
            let v147 : string = Fable.Core.JS.undefined
            let v148 : string = "0px !important"
            method13(v148, v147)
        else
            let v150 : string = "0px !important"
            v150
    let v155 : string =
        match v24 with
        | US6_0 -> (* None *)
            let v153 : string = "sm"
            v153
        | US6_1(v152) -> (* Some *)
            v152
    let v159 : string =
        match v52 with
        | US6_0 -> (* None *)
            let v157 : string = "0"
            v157
        | US6_1(v156) -> (* Some *)
            v156
    let v166 : string =
        match v51 with
        | US6_1(v160) -> (* Some *)
            let v161 : bool = "0" = v160
            if v161 then
                let v162 : string = "0"
                v162
            else
                let v163 : string = "15px"
                v163
        | _ ->
            let v165 : string = "15px"
            v165
    let v167 : string = method13(v166, v159)
    let v168 : US6 = US6_1(v151)
    let v169 : string = "neutral.500"
    let v170 : US6 = US6_1(v169)
    let v171 : string = "neutral.400"
    let v172 : US6 = US6_1(v171)
    let v173 : string = "flex"
    let v174 : US6 = US6_1(v173)
    let v175 : string = "column"
    let v176 : US6 = US6_1(v175)
    let v177 : US6 = US6_1(v155)
    let v178 : string = "0"
    let v179 : US6 = US6_1(v178)
    let v180 : US6 = US6_1(v178)
    let v181 : US6 = US6_1(v167)
    let v182 : US6 = US6_1(v178)
    struct (v72, v73, v74, v75, v76, v77, v168, v170, v80, v81, v82, v83, v172, v85, v86, v87, v88, v174, v90, v91, v92, v176, v94, v177, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v179, v180, v181, v182, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141)
and closure19 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) struct (v70 : US6, v71 : US6, v72 : US6, v73 : US7, v74 : US6, v75 : US6, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US8, v81 : US9, v82 : US6, v83 : US6, v84 : US8, v85 : US6, v86 : US6, v87 : US6, v88 : US10, v89 : US8, v90 : US6, v91 : US6, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US11, v97 : US6, v98 : US6, v99 : US6, v100 : US11, v101 : US6, v102 : US6, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US12, v112 : US13, v113 : US12, v114 : US6, v115 : US6, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US14, v131 : US6, v132 : US11, v133 : US6, v134 : US6, v135 : US14, v136 : US14, v137 : US6, v138 : US5, v139 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v143 : string =
        match v52 with
        | US6_0 -> (* None *)
            let v141 : string = "4px"
            v141
        | US6_1(v140) -> (* Some *)
            v140
    let v147 : string =
        match v49 with
        | US6_0 -> (* None *)
            let v145 : string = "2px"
            v145
        | US6_1(v144) -> (* Some *)
            v144
    let v151 : string =
        match v50 with
        | US6_0 -> (* None *)
            let v149 : string = "8px"
            v149
        | US6_1(v148) -> (* Some *)
            v148
    let v152 : US6 = US6_1(v147)
    let v153 : US6 = US6_1(v151)
    let v154 : US6 = US6_1(v143)
    struct (v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v152, v153, v121, v154, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139)
and closure22 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "flex"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v71, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure25 (v0 : Mut4) (v1 : obj) : unit =
    let v2 : string = "target"
    let v3 : obj = (Fable.Core.JsInterop.(?)) v1 v2
    let v4 : string = "checked"
    let v5 : obj = (Fable.Core.JsInterop.(?)) v3 v4
    let v6 : bool = v5 |> unbox<bool>
    let v7 : (bool -> unit) = v0.l1
    v7 v6
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
and closure26 () () : (Fable.Core.JSX.Element []) =
    [||]
and closure28 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "1.5px"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v71, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure29 () () : (Fable.Core.JSX.Element []) =
    [||]
and closure27 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) () : (Fable.Core.JSX.Element []) =
    let v70 : string = "Box"
    let v71 : string = "@hope-ui/core"
    let v72 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v70 v71
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure28()
    let v77 : (unit -> (Fable.Core.JSX.Element [])) =
        match v11 with
        | US9_0 -> (* None *)
            closure29()
        | US9_1(v74) -> (* Some *)
            v74
    let v78 : Fable.Core.JSX.Element = method5(v72, v73, v77)
    [|v78|]
and closure23 (v0 : Mut4, v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) () : (Fable.Core.JSX.Element []) =
    let v71 : string = "hope"
    let v72 : string = "@hope-ui/core"
    let v73 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v71 v72
    let v74 : obj = v73
    let v75 : string = "input"
    let v76 : obj = (Fable.Core.JsInterop.(?)) v74 v75
    let v77 : Fable.Core.JS.Function = v76 |> unbox<Fable.Core.JS.Function>
    let v78 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure24(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
    let v79 : (unit -> (Fable.Core.JSX.Element [])) = closure26()
    let v80 : Fable.Core.JSX.Element = method5(v77, v78, v79)
    let v81 : string = "&nbsp;"
    let v82 : Fable.Core.JSX.Element = v81 |> unbox<Fable.Core.JSX.Element>
    let v83 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v82 ]
    let v84 : (unit -> (Fable.Core.JSX.Element [])) = closure27(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
    let v85 : Fable.Core.JSX.Element = v84 |> unbox<Fable.Core.JSX.Element>
    [|v80; v83; v85|]
and closure21 () (v0 : Mut4) : Fable.Core.JSX.Element =
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = v0.l2
    let struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) = method6()
    let struct (v72 : US6, v73 : US6, v74 : US6, v75 : US7, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US8, v83 : US9, v84 : US6, v85 : US6, v86 : US8, v87 : US6, v88 : US6, v89 : US6, v90 : US10, v91 : US8, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US11, v99 : US6, v100 : US6, v101 : US6, v102 : US11, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US12, v114 : US13, v115 : US12, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US14, v133 : US6, v134 : US11, v135 : US6, v136 : US6, v137 : US14, v138 : US14, v139 : US6, v140 : US5, v141 : US6) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
    let v150 : US9 =
        match v83 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v142) -> (* Some *)
            let v143 : string = "children"
            let v144 : string = "solid-js"
            let v145 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v143 v144
            let v146 : (unit -> (Fable.Core.JSX.Element [])) = v145.Invoke v142 |> unbox<unit -> Fable.Core.JSX.Element[]>
            US9_1(v146)
    let v151 : string = "Box"
    let v152 : string = "@hope-ui/core"
    let v153 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v151 v152
    let v154 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure22()
    let v155 : (unit -> (Fable.Core.JSX.Element [])) = closure23(v0, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v150, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141)
    method5(v153, v154, v155)
and closure31 (v0 : Fable.Core.JSX.Element) () : (Fable.Core.JSX.Element []) =
    [|v0|]
and closure30 (v0 : Fable.Core.JSX.Element) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (unit -> (Fable.Core.JSX.Element [])) = closure31(v0)
    let v72 : US9 = US9_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v72, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and method14 (v0 : (Mut4 -> Fable.Core.JSX.Element), v1 : (unit -> bool), v2 : (bool -> unit), v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6))) : Fable.Core.JSX.Element =
    let v4 : Mut4 = {l0 = v1; l1 = v2; l2 = v3} : Mut4
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v5 v6
    let v8 : Fable.Core.JSX.Element = v7.Invoke (v0, v4) |> unbox<Fable.Core.JSX.Element>
    v8
and closure20 (v0 : Mut3, v1 : (bool -> unit), v2 : (unit -> bool), v3 : Fable.Core.JSX.Element) () : (Fable.Core.JSX.Element []) =
    let v4 : US15 = v0.l3
    let v8 : Fable.Core.JSX.Element =
        match v4 with
        | US15_2 -> (* CheckHidden *)
            v3
        | _ ->
            let v5 : (Mut4 -> Fable.Core.JSX.Element) = closure21()
            let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure30(v3)
            method14(v5, v2, v1, v6)
    [|v8|]
and closure18 (v0 : Mut3, v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6, v71 : (bool -> unit), v72 : (unit -> bool), v73 : Fable.Core.JSX.Element) () : (Fable.Core.JSX.Element []) =
    let v74 : string = "Box"
    let v75 : string = "@hope-ui/core"
    let v76 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v74 v75
    let v77 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure19(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
    let v78 : (unit -> (Fable.Core.JSX.Element [])) = closure20(v0, v71, v72, v73)
    let v79 : Fable.Core.JSX.Element = method5(v76, v77, v78)
    [|v79|]
and closure32 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "0"
    let v71 : US6 = US6_1(v70)
    let v72 : string = "9px"
    let v73 : US6 = US6_1(v72)
    let v74 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v71, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v73, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v74, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure33 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "&nbsp;"
    let v1 : Fable.Core.JSX.Element = v0 |> unbox<Fable.Core.JSX.Element>
    let v2 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v1 ]
    [|v2|]
and closure34 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) struct (v70 : US6, v71 : US6, v72 : US6, v73 : US7, v74 : US6, v75 : US6, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US8, v81 : US9, v82 : US6, v83 : US6, v84 : US8, v85 : US6, v86 : US6, v87 : US6, v88 : US10, v89 : US8, v90 : US6, v91 : US6, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US11, v97 : US6, v98 : US6, v99 : US6, v100 : US11, v101 : US6, v102 : US6, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US12, v112 : US13, v113 : US12, v114 : US6, v115 : US6, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US14, v131 : US6, v132 : US11, v133 : US6, v134 : US6, v135 : US14, v136 : US14, v137 : US6, v138 : US5, v139 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v143 : string =
        match v23 with
        | US6_0 -> (* None *)
            let v141 : string = "sm"
            v141
        | US6_1(v140) -> (* Some *)
            v140
    let v147 : string =
        match v28 with
        | US6_0 -> (* None *)
            let v145 : string = "center"
            v145
        | US6_1(v144) -> (* Some *)
            v144
    let v151 : string =
        match v34 with
        | US6_0 -> (* None *)
            let v149 : string = "0"
            v149
        | US6_1(v148) -> (* Some *)
            v148
    let v155 : string =
        match v33 with
        | US6_0 -> (* None *)
            let v153 : string = "0"
            v153
        | US6_1(v152) -> (* Some *)
            v152
    let v159 : string =
        match v48 with
        | US6_0 -> (* None *)
            let v157 : string = "0"
            v157
        | US6_1(v156) -> (* Some *)
            v156
    let v160 : string = "0"
    let v161 : US6 = US6_1(v160)
    let v162 : string = "flex"
    let v163 : US6 = US6_1(v162)
    let v164 : string = "6"
    let v165 : US6 = US6_1(v164)
    let v166 : string = "column"
    let v167 : US6 = US6_1(v166)
    let v168 : US6 = US6_1(v143)
    let v169 : US6 = US6_1(v147)
    let v170 : string = "base"
    let v171 : US6 = US6_1(v170)
    let v172 : US6 = US6_1(v155)
    let v173 : US6 = US6_1(v151)
    let v174 : US6 = US6_1(v160)
    let v175 : US6 = US6_1(v160)
    let v176 : string = "85vh"
    let v177 : US6 = US6_1(v176)
    let v178 : US6 = US6_1(v160)
    let v179 : string = "auto"
    let v180 : US6 = US6_1(v179)
    let v181 : US6 = US6_1(v159)
    struct (v70, v71, v72, v73, v74, v161, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v163, v88, v89, v165, v167, v92, v168, v94, v95, v96, v97, v169, v99, v100, v171, v102, v172, v173, v174, v175, v177, v108, v109, v110, v111, v112, v113, v178, v180, v116, v117, v181, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139)
and closure37 (v0 : int32, v1 : (unit -> string), v2 : (unit -> US4), v3 : (unit -> US5)) () : (obj []) =
    let v4 : string = "loader_id"
    let v5 : obj = struct (v4, v0)
    let v6 : string = v1 ()
    let v7 : string = "chain_token"
    let v8 : obj = struct (v7, v6)
    let v9 : US4 = v2 ()
    let v18 : string =
        match v9 with
        | US4_0 -> (* Debug *)
            let v10 : string = "Debug"
            v10
        | US4_1 -> (* Error *)
            let v13 : string = "Error"
            v13
        | US4_2 -> (* Info *)
            let v11 : string = "Info"
            v11
        | US4_4 -> (* Warn *)
            let v12 : string = "Warn"
            v12
        | _ ->
            let v14 : string = "Error"
            v14
    let v19 : string = "log_level"
    let v20 : obj = struct (v19, v18)
    let v21 : US5 = v3 ()
    let v22 : string = "ui_modal"
    let v23 : obj = struct (v22, v21)
    [|v5; v8; v20; v23|]
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
        let v15 : int64 = System.DateTime.UtcNow.Ticks
        let v16 : int64 = v15 - v8
        let v17 : string = (v16).ToString ()
        let v18 : int32 = 6
        let v19 : string = method18(v18, v17)
        let v20 : int32 = Fable.Core.JsInterop.emitJsExpr () "components.run_id"
        let v21 : string = "timestamp"
        let v22 : obj = struct (v21, v19)
        let v23 : string = "run_id"
        let v24 : obj = struct (v23, v20)
        let v25 : (obj []) = [|v22; v24|]
        let v26 : (obj []) = v1 ()
        let v27 : string = Fable.Core.JS.JSON.stringify v26
        let v28 : string = Fable.Core.JS.JSON.stringify v10
        let v29 : string = Fable.Core.JS.JSON.stringify v25
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
        Fable.Core.JsInterop.emitJsExpr () $"console.log.apply(console, {struct (v35, v36, v37, v38, v39)})"
        ()
and closure38 (v0 : (unit -> US4), v1 : (unit -> (obj [])), v2 : string, v3 : string, v4 : obj, v5 : string, v6 : string, v7 : bool, v8 : int64) (v9 : US4) : ((obj []) -> unit) =
    closure39(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9)
and method17 (v0 : (unit -> US4), v1 : (unit -> (obj [])), v2 : string) : (US4 -> ((obj []) -> unit)) =
    let struct (v3 : string, v4 : obj, v5 : string, v6 : string, v7 : bool) = method2()
    let v8 : int64 = System.DateTime.UtcNow.Ticks
    closure38(v0, v1, v2, v3, v4, v5, v6, v7, v8)
and method16 (v0 : (unit -> (obj [])), v1 : string) : (US4 -> ((obj []) -> unit)) =
    let v97 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v98 : string = "useContext"
    let v99 : string = "solid-js"
    let v100 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v98 v99
    let struct (v101 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v102 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v103 : (unit -> int32), v104 : (int32 -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> string), v108 : (string -> unit), v109 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v110 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v111 : (unit -> (struct (US2 * obj * string) [])), v112 : ((struct (US2 * obj * string) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * obj) [])), v116 : ((struct (System.Guid * obj) []) -> unit), v117 : (unit -> (struct (System.Guid * int32) [])), v118 : ((struct (System.Guid * int32) []) -> unit), v119 : (unit -> US4), v120 : (US4 -> unit), v121 : (unit -> US5), v122 : (US5 -> unit)) = v100.Invoke v97 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    method17(v119, v0, v1)
and closure40 (v0 : Mut5, v1 : int32, v2 : (US5 -> unit)) () : unit =
    let v3 : bool = v0.l1
    if v3 then
        let v4 : US5 = US5_1(v1)
        v2 v4
and closure41 (v0 : (bool -> unit), v1 : (unit -> bool)) () : unit =
    let v2 : bool = v1 ()
    if v2 then
        v0 false
and closure42 (v0 : Mut5) () : unit =
    let v1 : US13 = v0.l3
    match v1 with
    | US13_0 -> (* None *)
        ()
    | US13_1(v2) -> (* Some *)
        v2 ()
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
    let v2 : (string []) = Fable.Core.JS.Constructors.Object.keys v0 |> unbox<string[]>
    let v3 : int32 = v2.Length
    let v4 : Mut6 = {l0 = 0} : Mut6
    while method21(v3, v4) do
        let v6 : int32 = v4.l0
        let v7 : string = v2.[int v6]
        let v8 : bool = Fable.Core.JsInterop.emitJsExpr (v1, v7) "!!$0[$1].tag"
        if v8 then
            Fable.Core.JsInterop.emitJsExpr (v0, v7, v1) "$0[$1] = $2[$1]"
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
and closure49 () () : (Fable.Core.JSX.Element []) =
    [||]
and method19 (v0 : Mut1) : Fable.Core.JSX.Element =
    let v1 : string = "Button"
    let v2 : string = "@hope-ui/core"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure48(v0)
    let v5 : US9 = v0.l11
    let v9 : (unit -> (Fable.Core.JSX.Element [])) =
        match v5 with
        | US9_0 -> (* None *)
            closure49()
        | US9_1(v6) -> (* Some *)
            v6
    method5(v3, v4, v9)
and closure47 () (v0 : Mut1) : Fable.Core.JSX.Element =
    method19(v0)
and closure51 (v0 : (bool -> unit), v1 : Mut5) () : unit =
    let v2 : US13 = v1.l2
    match v2 with
    | US13_0 -> (* None *)
        ()
    | US13_1(v3) -> (* Some *)
        v3 ()
    v0 true
and closure50 (v0 : (bool -> unit), v1 : Mut5) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : (unit -> unit) = closure51(v0, v1)
    let v73 : US13 = US13_1(v72)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v73, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
and closure52 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "Load"
    let v1 : Fable.Core.JSX.Element = v0 |> unbox<Fable.Core.JSX.Element>
    let v2 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v1 ]
    [|v2|]
and method22 (v0 : (Mut1 -> Fable.Core.JSX.Element), v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)), v2 : (unit -> (Fable.Core.JSX.Element []))) : Fable.Core.JSX.Element =
    let struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US6, v19 : US6, v20 : US6, v21 : US10, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US11, v30 : US6, v31 : US6, v32 : US6, v33 : US11, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US12, v45 : US13, v46 : US12, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US14, v64 : US6, v65 : US11, v66 : US6, v67 : US6, v68 : US14, v69 : US14, v70 : US6, v71 : US5, v72 : US6) = method6()
    let struct (v73 : US6, v74 : US6, v75 : US6, v76 : US7, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US6, v83 : US8, v84 : US9, v85 : US6, v86 : US6, v87 : US8, v88 : US6, v89 : US6, v90 : US6, v91 : US10, v92 : US8, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US6, v99 : US11, v100 : US6, v101 : US6, v102 : US6, v103 : US11, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US12, v115 : US13, v116 : US12, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US14, v134 : US6, v135 : US11, v136 : US6, v137 : US6, v138 : US14, v139 : US14, v140 : US6, v141 : US5, v142 : US6) = v1 struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v151 : US9 =
        match v84 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v143) -> (* Some *)
            let v144 : string = "children"
            let v145 : string = "solid-js"
            let v146 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v144 v145
            let v147 : (unit -> (Fable.Core.JSX.Element [])) = v146.Invoke v143 |> unbox<unit -> Fable.Core.JSX.Element[]>
            US9_1(v147)
    let v154 : (unit -> (Fable.Core.JSX.Element [])) =
        match v151 with
        | US9_0 -> (* None *)
            v2
        | US9_1(v152) -> (* Some *)
            v152
    let v155 : US9 = US9_1(v154)
    let v156 : Mut1 = {l0 = v73; l1 = v74; l2 = v75; l3 = v76; l4 = v77; l5 = v78; l6 = v79; l7 = v80; l8 = v81; l9 = v82; l10 = v83; l11 = v155; l12 = v85; l13 = v86; l14 = v87; l15 = v88; l16 = v89; l17 = v90; l18 = v91; l19 = v92; l20 = v93; l21 = v94; l22 = v95; l23 = v96; l24 = v97; l25 = v98; l26 = v99; l27 = v100; l28 = v101; l29 = v102; l30 = v103; l31 = v104; l32 = v105; l33 = v106; l34 = v107; l35 = v108; l36 = v109; l37 = v110; l38 = v111; l39 = v112; l40 = v113; l41 = v114; l42 = v115; l43 = v116; l44 = v117; l45 = v118; l46 = v119; l47 = v120; l48 = v121; l49 = v122; l50 = v123; l51 = v124; l52 = v125; l53 = v126; l54 = v127; l55 = v128; l56 = v129; l57 = v130; l58 = v131; l59 = v132; l60 = v133; l61 = v134; l62 = v135; l63 = v136; l64 = v137; l65 = v138; l66 = v139; l67 = v140; l68 = v141; l69 = v142} : Mut1
    Fable.Core.JsInterop.emitJsExpr (v156, v2) "$0.children = $1"
    let v157 : string = "createComponent"
    let v158 : string = "solid-js"
    let v159 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v157 v158
    let v160 : Fable.Core.JSX.Element = v159.Invoke (v0, v156) |> unbox<Fable.Core.JSX.Element>
    v160
and closure46 (v0 : (bool -> unit), v1 : Mut5) () : (Fable.Core.JSX.Element []) =
    let v2 : (Mut1 -> Fable.Core.JSX.Element) = closure47()
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure50(v0, v1)
    let v4 : (unit -> (Fable.Core.JSX.Element [])) = closure52()
    let v5 : Fable.Core.JSX.Element = method22(v2, v3, v4)
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
        | US5_1(v73) -> (* Some *)
            let v74 : bool = v73 = v0
            let v75 : bool = v74 <> true
            if v75 then
                let v76 : string = "none"
                US6_1(v76)
            else
                US6_0
        | _ ->
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
    let v71 : (unit -> Fable.Core.JS.Function) = v0.l0
    let v72 : Fable.Core.JS.Function = v71 ()
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = v0.l1
    let v74 : US7 = US7_1(v72)
    let v75 : string = "14px"
    let v76 : US6 = US6_1(v75)
    let v77 : US14 = US14_0
    v73 struct (v1, v2, v3, v74, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v76, v58, v59, v60, v77, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure62 () () : (Fable.Core.JSX.Element []) =
    [||]
and method23 (v0 : Mut7) : Fable.Core.JSX.Element =
    let v1 : string = "Icon"
    let v2 : string = "@hope-ui/core"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure61(v0)
    let v5 : (unit -> (Fable.Core.JSX.Element [])) = closure62()
    method5(v3, v4, v5)
and closure60 () (v0 : Mut7) : Fable.Core.JSX.Element =
    method23(v0)
and closure63 () () : Fable.Core.JS.Function =
    let v0 : string = "BiRegularRefresh"
    let v1 : string = "solid-icons/bi"
    let v2 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v0 v1
    v2
and method24 (v0 : (Mut7 -> Fable.Core.JSX.Element), v1 : (unit -> Fable.Core.JS.Function), v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6))) : Fable.Core.JSX.Element =
    let v3 : Mut7 = {l0 = v1; l1 = v2; l2 = v2} : Mut7
    let v4 : string = "createComponent"
    let v5 : string = "solid-js"
    let v6 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v4 v5
    let v7 : Fable.Core.JSX.Element = v6.Invoke (v0, v3) |> unbox<Fable.Core.JSX.Element>
    v7
and closure64 (v0 : (bool -> unit)) () : unit =
    v0 true
and closure59 (v0 : (bool -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (Mut7 -> Fable.Core.JSX.Element) = closure60()
    let v72 : (unit -> Fable.Core.JS.Function) = closure63()
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v74 : Fable.Core.JSX.Element = method24(v71, v72, v73)
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
and closure65 () () : (Fable.Core.JSX.Element []) =
    [||]
and closure67 () () : Fable.Core.JS.Function =
    let v0 : string = "BiRegularDownArrow"
    let v1 : string = "solid-icons/bi"
    let v2 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v0 v1
    v2
and closure68 () () : Fable.Core.JS.Function =
    let v0 : string = "BiRegularUpArrow"
    let v1 : string = "solid-icons/bi"
    let v2 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v0 v1
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
    let v81 : (Mut7 -> Fable.Core.JSX.Element) = closure60()
    let v82 : US5 = v2 ()
    let v86 : bool =
        match v82 with
        | US5_1(v84) -> (* Some *)
            let v85 : bool = v84 = v0
            v85
        | _ ->
            false
    let v89 : (unit -> Fable.Core.JS.Function) =
        if v86 then
            closure67()
        else
            closure68()
    let v90 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v91 : Fable.Core.JSX.Element = method24(v81, v89, v90)
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
and closure70 () () : (Fable.Core.JSX.Element []) =
    [||]
and closure72 () () : Fable.Core.JS.Function =
    let v0 : string = "BiRegularUndo"
    let v1 : string = "solid-icons/bi"
    let v2 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v0 v1
    v2
and closure73 (v0 : (bool -> unit), v1 : Mut5) () : unit =
    let v2 : US13 = v1.l3
    match v2 with
    | US13_0 -> (* None *)
        ()
    | US13_1(v3) -> (* Some *)
        v3 ()
    v0 false
and closure71 (v0 : (bool -> unit), v1 : Mut5) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : (Mut7 -> Fable.Core.JSX.Element) = closure60()
    let v73 : (unit -> Fable.Core.JS.Function) = closure72()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v75 : Fable.Core.JSX.Element = method24(v72, v73, v74)
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
and closure74 () () : (Fable.Core.JSX.Element []) =
    [||]
and closure58 (v0 : int32, v1 : (US5 -> unit), v2 : (bool -> unit), v3 : (bool -> unit), v4 : Mut5, v5 : (unit -> US5)) () : (Fable.Core.JSX.Element []) =
    let v6 : string = "IconButton"
    let v7 : string = "@hope-ui/core"
    let v8 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v6 v7
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure59(v3)
    let v10 : (unit -> (Fable.Core.JSX.Element [])) = closure65()
    let v11 : Fable.Core.JSX.Element = method5(v8, v9, v10)
    let v12 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v6 v7
    let v13 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure66(v0, v1, v5)
    let v14 : (unit -> (Fable.Core.JSX.Element [])) = closure70()
    let v15 : Fable.Core.JSX.Element = method5(v12, v13, v14)
    let v16 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v6 v7
    let v17 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure71(v2, v4)
    let v18 : (unit -> (Fable.Core.JSX.Element [])) = closure74()
    let v19 : Fable.Core.JSX.Element = method5(v16, v17, v18)
    [|v11; v15; v19|]
and closure56 (v0 : int32, v1 : (US5 -> unit), v2 : (unit -> US5), v3 : (bool -> unit), v4 : (bool -> unit), v5 : (unit -> bool), v6 : Mut5, v7 : (unit -> (Fable.Core.JSX.Element []))) () : (Fable.Core.JSX.Element []) =
    let v8 : string = "Stack"
    let v9 : string = "@hope-ui/core"
    let v10 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v8 v9
    let v11 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure57(v0, v2)
    let v12 : (unit -> (Fable.Core.JSX.Element [])) = closure58(v0, v1, v3, v4, v6, v2)
    let v13 : Fable.Core.JSX.Element = method5(v10, v11, v12)
    let v14 : bool = v5 ()
    let v17 : Fable.Core.JSX.Element =
        if v14 then
            let v15 : Fable.Core.JSX.Element = Fable.Core.JS.undefined
            v15
        else
            let v16 : Fable.Core.JSX.Element = v7 |> unbox<Fable.Core.JSX.Element>
            v16
    [|v13; v17|]
and closure54 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6, v70 : int32, v71 : (US5 -> unit), v72 : (unit -> US5), v73 : (bool -> unit), v74 : (bool -> unit), v75 : (unit -> bool), v76 : Mut5) () : (Fable.Core.JSX.Element []) =
    let v86 : Fable.Core.JSX.Element =
        match v11 with
        | US9_0 -> (* None *)
            let v84 : Fable.Core.JSX.Element = Fable.Core.JS.undefined
            v84
        | US9_1(v77) -> (* Some *)
            let v78 : string = "Box"
            let v79 : string = "@hope-ui/core"
            let v80 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v78 v79
            let v81 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure55(v72)
            let v82 : (unit -> (Fable.Core.JSX.Element [])) = closure56(v70, v71, v72, v73, v74, v75, v76, v77)
            method5(v80, v81, v82)
    [|v86|]
and closure44 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6, v70 : int32, v71 : (US5 -> unit), v72 : (unit -> US5), v73 : (bool -> unit), v74 : (unit -> bool), v75 : (bool -> unit), v76 : (unit -> bool), v77 : Mut5) () : (Fable.Core.JSX.Element []) =
    let v78 : bool = v74 ()
    let v79 : bool = v78 = false
    let v92 : Fable.Core.JSX.Element =
        if v79 then
            let v80 : string = "Box"
            let v81 : string = "@hope-ui/core"
            let v82 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v80 v81
            let v83 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure45()
            let v84 : (unit -> (Fable.Core.JSX.Element [])) = closure46(v73, v77)
            method5(v82, v83, v84)
        else
            let v86 : string = "Box"
            let v87 : string = "@hope-ui/core"
            let v88 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v86 v87
            let v89 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure53(v70, v72)
            let v90 : (unit -> (Fable.Core.JSX.Element [])) = closure54(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v75, v76, v77)
            method5(v88, v89, v90)
    [|v92|]
and method15 (v0 : Mut5) : Fable.Core.JSX.Element =
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = v0.l4
    let struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) = method6()
    let struct (v72 : US6, v73 : US6, v74 : US6, v75 : US7, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US8, v83 : US9, v84 : US6, v85 : US6, v86 : US8, v87 : US6, v88 : US6, v89 : US6, v90 : US10, v91 : US8, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US11, v99 : US6, v100 : US6, v101 : US6, v102 : US11, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US12, v114 : US13, v115 : US12, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US14, v133 : US6, v134 : US11, v135 : US6, v136 : US6, v137 : US14, v138 : US14, v139 : US6, v140 : US5, v141 : US6) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
    let v150 : US9 =
        match v83 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v142) -> (* Some *)
            let v143 : string = "children"
            let v144 : string = "solid-js"
            let v145 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v143 v144
            let v146 : (unit -> (Fable.Core.JSX.Element [])) = v145.Invoke v142 |> unbox<unit -> Fable.Core.JSX.Element[]>
            US9_1(v146)
    let v151 : int32 = System.Random().Next ()
    let v247 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v248 : string = "useContext"
    let v249 : string = "solid-js"
    let v250 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v248 v249
    let struct (v251 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v252 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v253 : (unit -> int32), v254 : (int32 -> unit), v255 : (unit -> string), v256 : (string -> unit), v257 : (unit -> string), v258 : (string -> unit), v259 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v260 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v261 : (unit -> (struct (US2 * obj * string) [])), v262 : ((struct (US2 * obj * string) []) -> unit), v263 : (unit -> (struct (System.Guid * obj) [])), v264 : ((struct (System.Guid * obj) []) -> unit), v265 : (unit -> (struct (System.Guid * obj) [])), v266 : ((struct (System.Guid * obj) []) -> unit), v267 : (unit -> (struct (System.Guid * int32) [])), v268 : ((struct (System.Guid * int32) []) -> unit), v269 : (unit -> US4), v270 : (US4 -> unit), v271 : (unit -> US5), v272 : (US5 -> unit)) = v250.Invoke v247 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v368 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v369 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v248 v249
    let struct (v370 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v371 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v372 : (unit -> int32), v373 : (int32 -> unit), v374 : (unit -> string), v375 : (string -> unit), v376 : (unit -> string), v377 : (string -> unit), v378 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v379 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v380 : (unit -> (struct (US2 * obj * string) [])), v381 : ((struct (US2 * obj * string) []) -> unit), v382 : (unit -> (struct (System.Guid * obj) [])), v383 : ((struct (System.Guid * obj) []) -> unit), v384 : (unit -> (struct (System.Guid * obj) [])), v385 : ((struct (System.Guid * obj) []) -> unit), v386 : (unit -> (struct (System.Guid * int32) [])), v387 : ((struct (System.Guid * int32) []) -> unit), v388 : (unit -> US4), v389 : (US4 -> unit), v390 : (unit -> US5), v391 : (US5 -> unit)) = v369.Invoke v368 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v487 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v488 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v248 v249
    let struct (v489 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v490 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v491 : (unit -> int32), v492 : (int32 -> unit), v493 : (unit -> string), v494 : (string -> unit), v495 : (unit -> string), v496 : (string -> unit), v497 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v498 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v499 : (unit -> (struct (US2 * obj * string) [])), v500 : ((struct (US2 * obj * string) []) -> unit), v501 : (unit -> (struct (System.Guid * obj) [])), v502 : ((struct (System.Guid * obj) []) -> unit), v503 : (unit -> (struct (System.Guid * obj) [])), v504 : ((struct (System.Guid * obj) []) -> unit), v505 : (unit -> (struct (System.Guid * int32) [])), v506 : ((struct (System.Guid * int32) []) -> unit), v507 : (unit -> US4), v508 : (US4 -> unit), v509 : (unit -> US5), v510 : (US5 -> unit)) = v488.Invoke v487 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v511 : (unit -> (obj [])) = closure37(v151, v255, v388, v509)
    let v512 : string = "#de884c"
    let v513 : (US4 -> ((obj []) -> unit)) = method16(v511, v512)
    let v514 : US4 = US4_0
    let v515 : ((obj []) -> unit) = v513 v514
    let v516 : string = "> loader ()"
    let v517 : obj = v516
    let v518 : (obj []) = [|v517|]
    v515 v518
    let v519 : bool = v0.l0
    let struct (v520 : (unit -> bool), v521 : (bool -> unit)) = method12(v519)
    let v522 : bool = false
    let struct (v523 : (unit -> bool), v524 : (bool -> unit)) = method12(v522)
    let v525 : string = "createEffect"
    let v526 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v525 v249
    let v527 : (unit -> unit) = closure40(v0, v151, v510)
    v526.Invoke v527 |> ignore
    let v528 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v525 v249
    let v529 : (unit -> unit) = closure41(v524, v523)
    v528.Invoke v529 |> ignore
    let v530 : string = "onCleanup"
    let v531 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v530 v249
    let v532 : (unit -> unit) = closure42(v0)
    v531.Invoke v532 |> ignore
    let v533 : bool = v0.l0
    if v533 then
        let v534 : US13 = v0.l2
        match v534 with
        | US13_0 -> (* None *)
            ()
        | US13_1(v535) -> (* Some *)
            v535 ()
    let v536 : string = "Box"
    let v537 : string = "@hope-ui/core"
    let v538 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v536 v537
    let v539 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure43(v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v150, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141)
    let v540 : (unit -> (Fable.Core.JSX.Element [])) = closure44(v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v150, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v151, v510, v509, v521, v520, v524, v523, v0)
    method5(v538, v539, v540)
and closure36 () (v0 : Mut5) : Fable.Core.JSX.Element =
    method15(v0)
and closure75 (v0 : (unit -> (Fable.Core.JSX.Element []))) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : US9 = US9_1(v0)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v71, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and method25 (v0 : (Mut5 -> Fable.Core.JSX.Element), v1 : bool, v2 : bool, v3 : US13, v4 : US13, v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6))) : Fable.Core.JSX.Element =
    let v6 : Mut5 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5} : Mut5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v7 v8
    let v10 : Fable.Core.JSX.Element = v9.Invoke (v0, v6) |> unbox<Fable.Core.JSX.Element>
    v10
and closure35 (v0 : Mut3, v1 : (unit -> bool), v2 : (unit -> (Fable.Core.JSX.Element []))) () : (Fable.Core.JSX.Element []) =
    let v3 : US15 = v0.l3
    let v15 : Fable.Core.JSX.Element =
        match v3 with
        | US15_2 -> (* CheckHidden *)
            let v4 : Fable.Core.JSX.Element = v2 |> unbox<Fable.Core.JSX.Element>
            v4
        | _ ->
            let v5 : bool = v1 ()
            if v5 then
                let v6 : (Mut5 -> Fable.Core.JSX.Element) = closure36()
                let v7 : US13 = v0.l0
                let v8 : US13 = v0.l1
                let v9 : bool = true
                let v10 : bool = false
                let v11 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure75(v2)
                method25(v6, v9, v10, v7, v8, v11)
            else
                let v13 : Fable.Core.JSX.Element = Fable.Core.JS.undefined
                v13
    [|v15|]
and closure16 (v0 : Mut3, v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6, v71 : (bool -> unit), v72 : (unit -> bool)) () : (Fable.Core.JSX.Element []) =
    let v86 : Fable.Core.JSX.Element =
        match v63 with
        | US11_0 -> (* None *)
            let v84 : Fable.Core.JSX.Element = Fable.Core.JS.undefined
            v84
        | US11_1(v73) -> (* Some *)
            let v74 : string = "hope"
            let v75 : string = "@hope-ui/core"
            let v76 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v74 v75
            let v77 : obj = v76
            let v78 : string = "td"
            let v79 : obj = (Fable.Core.JsInterop.(?)) v77 v78
            let v80 : Fable.Core.JS.Function = v79 |> unbox<Fable.Core.JS.Function>
            let v81 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure17(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v72)
            let v82 : (unit -> (Fable.Core.JSX.Element [])) = closure18(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73)
            method5(v80, v81, v82)
    let v109 : Fable.Core.JSX.Element =
        match v12 with
        | US9_0 -> (* None *)
            let v98 : string = "hope"
            let v99 : string = "@hope-ui/core"
            let v100 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v98 v99
            let v101 : obj = v100
            let v102 : string = "td"
            let v103 : obj = (Fable.Core.JsInterop.(?)) v101 v102
            let v104 : Fable.Core.JS.Function = v103 |> unbox<Fable.Core.JS.Function>
            let v105 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure32()
            let v106 : (unit -> (Fable.Core.JSX.Element [])) = closure33()
            method5(v104, v105, v106)
        | US9_1(v87) -> (* Some *)
            let v88 : string = "hope"
            let v89 : string = "@hope-ui/core"
            let v90 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v88 v89
            let v91 : obj = v90
            let v92 : string = "td"
            let v93 : obj = (Fable.Core.JsInterop.(?)) v91 v92
            let v94 : Fable.Core.JS.Function = v93 |> unbox<Fable.Core.JS.Function>
            let v95 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure34(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
            let v96 : (unit -> (Fable.Core.JSX.Element [])) = closure35(v0, v72, v87)
            method5(v94, v95, v96)
    [|v86; v109|]
and method11 (v0 : Mut3) : Fable.Core.JSX.Element =
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = v0.l2
    let struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) = method6()
    let struct (v72 : US6, v73 : US6, v74 : US6, v75 : US7, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US8, v83 : US9, v84 : US6, v85 : US6, v86 : US8, v87 : US6, v88 : US6, v89 : US6, v90 : US10, v91 : US8, v92 : US6, v93 : US6, v94 : US6, v95 : US6, v96 : US6, v97 : US6, v98 : US11, v99 : US6, v100 : US6, v101 : US6, v102 : US11, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US12, v114 : US13, v115 : US12, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US14, v133 : US6, v134 : US11, v135 : US6, v136 : US6, v137 : US14, v138 : US14, v139 : US6, v140 : US5, v141 : US6) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71)
    let v150 : US9 =
        match v83 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v142) -> (* Some *)
            let v143 : string = "children"
            let v144 : string = "solid-js"
            let v145 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v143 v144
            let v146 : (unit -> (Fable.Core.JSX.Element [])) = v145.Invoke v142 |> unbox<unit -> Fable.Core.JSX.Element[]>
            US9_1(v146)
    let v151 : US15 = v0.l3
    let v153 : bool =
        match v151 with
        | US15_0 -> (* CheckDisabled *)
            true
        | _ ->
            false
    let v154 : bool = v153 <> true
    let struct (v155 : (unit -> bool), v156 : (bool -> unit)) = method12(v154)
    let v157 : string = "hope"
    let v158 : string = "@hope-ui/core"
    let v159 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v157 v158
    let v160 : obj = v159
    let v161 : string = "tr"
    let v162 : obj = (Fable.Core.JsInterop.(?)) v160 v161
    let v163 : Fable.Core.JS.Function = v162 |> unbox<Fable.Core.JS.Function>
    let v164 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure15(v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v150, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141)
    let v165 : (unit -> (Fable.Core.JSX.Element [])) = closure16(v0, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v150, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v156, v155)
    method5(v163, v164, v165)
and closure14 () (v0 : Mut3) : Fable.Core.JSX.Element =
    method11(v0)
and closure80 (v0 : (unit -> US4)) () : (Fable.Core.JSX.Element []) =
    let v1 : US4 = v0 ()
    let v10 : string =
        match v1 with
        | US4_0 -> (* Debug *)
            let v2 : string = "Debug"
            v2
        | US4_1 -> (* Error *)
            let v5 : string = "Error"
            v5
        | US4_2 -> (* Info *)
            let v3 : string = "Info"
            v3
        | US4_4 -> (* Warn *)
            let v4 : string = "Warn"
            v4
        | _ ->
            let v6 : string = "Error"
            v6
    let v11 : Fable.Core.JSX.Element = v10 |> unbox<Fable.Core.JSX.Element>
    let v12 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v11 ]
    [|v12|]
and closure79 (v0 : (unit -> US4)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : string = "Log Level"
    let v72 : Fable.Core.JSX.Element = v71 |> unbox<Fable.Core.JSX.Element>
    let v73 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v72 ]
    let v74 : (unit -> (Fable.Core.JSX.Element [])) = closure80(v0)
    let v75 : US9 = US9_1(v74)
    let v76 : US11 = US11_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v75, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v76, v64, v65, v66, v67, v68, v69, v70)
and method26 (v0 : (Mut3 -> Fable.Core.JSX.Element), v1 : US13, v2 : US13, v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)), v4 : US15) : Fable.Core.JSX.Element =
    let v5 : Mut3 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4} : Mut3
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v6 v7
    let v9 : Fable.Core.JSX.Element = v8.Invoke (v0, v5) |> unbox<Fable.Core.JSX.Element>
    v9
and closure83 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "8px"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v71, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure88 (v0 : Mut8, v1 : (unit -> string)) () : (Fable.Core.JSX.Element []) =
    let v2 : string = v1 ()
    let v3 : (string -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = Fable.Core.JsInterop.emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : Fable.Core.JSX.Element = v5 |> unbox<Fable.Core.JSX.Element>
    let v7 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v6 ]
    [|v7|]
and closure87 (v0 : Mut8, v1 : (unit -> string)) () : (Fable.Core.JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v2 v3
    let v5 : obj = v4
    let v6 : string = "pre"
    let v7 : obj = (Fable.Core.JsInterop.(?)) v5 v6
    let v8 : Fable.Core.JS.Function = v7 |> unbox<Fable.Core.JS.Function>
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v10 : (unit -> (Fable.Core.JSX.Element [])) = closure88(v0, v1)
    let v11 : Fable.Core.JSX.Element = method5(v8, v9, v10)
    [|v11|]
and closure86 (v0 : Mut8, v1 : (unit -> string)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : Fable.Core.JSX.Element = v72 |> unbox<Fable.Core.JSX.Element>
    let v74 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v73 ]
    let v75 : (unit -> (Fable.Core.JSX.Element [])) = closure87(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method27 (v0 : Mut8) : Fable.Core.JSX.Element =
    let v1 : (unit -> struct ((unit -> string) * (string -> unit))) = v0.l1
    let struct (v2 : (unit -> string), v3 : (string -> unit)) = v1 ()
    let v4 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure86(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure85 () (v0 : Mut8) : Fable.Core.JSX.Element =
    method27(v0)
and closure89 () (v0 : string) : obj =
    let v1 : obj = v0
    v1
and closure90 () () : struct ((unit -> string) * (string -> unit)) =
    let v95 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v96 : string = "useContext"
    let v97 : string = "solid-js"
    let v98 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v99 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v100 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v101 : (unit -> int32), v102 : (int32 -> unit), v103 : (unit -> string), v104 : (string -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v108 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v109 : (unit -> (struct (US2 * obj * string) [])), v110 : ((struct (US2 * obj * string) []) -> unit), v111 : (unit -> (struct (System.Guid * obj) [])), v112 : ((struct (System.Guid * obj) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * int32) [])), v116 : ((struct (System.Guid * int32) []) -> unit), v117 : (unit -> US4), v118 : (US4 -> unit), v119 : (unit -> US5), v120 : (US5 -> unit)) = v98.Invoke v95 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v103, v104)
and method28 (v0 : (Mut8 -> Fable.Core.JSX.Element), v1 : (string -> obj), v2 : (unit -> struct ((unit -> string) * (string -> unit))), v3 : string) : Fable.Core.JSX.Element =
    let v4 : Mut8 = {l0 = v1; l1 = v2; l2 = v3} : Mut8
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v5 v6
    let v8 : Fable.Core.JSX.Element = v7.Invoke (v0, v4) |> unbox<Fable.Core.JSX.Element>
    v8
and closure91 () () : struct ((unit -> string) * (string -> unit)) =
    let v95 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v96 : string = "useContext"
    let v97 : string = "solid-js"
    let v98 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v99 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v100 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v101 : (unit -> int32), v102 : (int32 -> unit), v103 : (unit -> string), v104 : (string -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v108 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v109 : (unit -> (struct (US2 * obj * string) [])), v110 : ((struct (US2 * obj * string) []) -> unit), v111 : (unit -> (struct (System.Guid * obj) [])), v112 : ((struct (System.Guid * obj) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * int32) [])), v116 : ((struct (System.Guid * int32) []) -> unit), v117 : (unit -> US4), v118 : (US4 -> unit), v119 : (unit -> US5), v120 : (US5 -> unit)) = v98.Invoke v95 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v105, v106)
and closure95 (v0 : Mut9, v1 : (unit -> int32)) () : (Fable.Core.JSX.Element []) =
    let v2 : int32 = v1 ()
    let v3 : (int32 -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = Fable.Core.JsInterop.emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : Fable.Core.JSX.Element = v5 |> unbox<Fable.Core.JSX.Element>
    let v7 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v6 ]
    [|v7|]
and closure94 (v0 : Mut9, v1 : (unit -> int32)) () : (Fable.Core.JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v2 v3
    let v5 : obj = v4
    let v6 : string = "pre"
    let v7 : obj = (Fable.Core.JsInterop.(?)) v5 v6
    let v8 : Fable.Core.JS.Function = v7 |> unbox<Fable.Core.JS.Function>
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v10 : (unit -> (Fable.Core.JSX.Element [])) = closure95(v0, v1)
    let v11 : Fable.Core.JSX.Element = method5(v8, v9, v10)
    [|v11|]
and closure93 (v0 : Mut9, v1 : (unit -> int32)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : Fable.Core.JSX.Element = v72 |> unbox<Fable.Core.JSX.Element>
    let v74 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v73 ]
    let v75 : (unit -> (Fable.Core.JSX.Element [])) = closure94(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method29 (v0 : Mut9) : Fable.Core.JSX.Element =
    let v1 : (unit -> struct ((unit -> int32) * (int32 -> unit))) = v0.l1
    let struct (v2 : (unit -> int32), v3 : (int32 -> unit)) = v1 ()
    let v4 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure93(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure92 () (v0 : Mut9) : Fable.Core.JSX.Element =
    method29(v0)
and closure96 () (v0 : int32) : obj =
    let v1 : obj = v0
    v1
and closure97 () () : struct ((unit -> int32) * (int32 -> unit)) =
    let v95 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v96 : string = "useContext"
    let v97 : string = "solid-js"
    let v98 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v99 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v100 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v101 : (unit -> int32), v102 : (int32 -> unit), v103 : (unit -> string), v104 : (string -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v108 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v109 : (unit -> (struct (US2 * obj * string) [])), v110 : ((struct (US2 * obj * string) []) -> unit), v111 : (unit -> (struct (System.Guid * obj) [])), v112 : ((struct (System.Guid * obj) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * int32) [])), v116 : ((struct (System.Guid * int32) []) -> unit), v117 : (unit -> US4), v118 : (US4 -> unit), v119 : (unit -> US5), v120 : (US5 -> unit)) = v98.Invoke v95 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v101, v102)
and method30 (v0 : (Mut9 -> Fable.Core.JSX.Element), v1 : (int32 -> obj), v2 : (unit -> struct ((unit -> int32) * (int32 -> unit))), v3 : string) : Fable.Core.JSX.Element =
    let v4 : Mut9 = {l0 = v1; l1 = v2; l2 = v3} : Mut9
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v5 v6
    let v8 : Fable.Core.JSX.Element = v7.Invoke (v0, v4) |> unbox<Fable.Core.JSX.Element>
    v8
and closure101 (v0 : Mut10, v1 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []))) () : (Fable.Core.JSX.Element []) =
    let v2 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) = v1 ()
    let v3 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = Fable.Core.JsInterop.emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : Fable.Core.JSX.Element = v5 |> unbox<Fable.Core.JSX.Element>
    let v7 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v6 ]
    [|v7|]
and closure100 (v0 : Mut10, v1 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []))) () : (Fable.Core.JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v2 v3
    let v5 : obj = v4
    let v6 : string = "pre"
    let v7 : obj = (Fable.Core.JsInterop.(?)) v5 v6
    let v8 : Fable.Core.JS.Function = v7 |> unbox<Fable.Core.JS.Function>
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v10 : (unit -> (Fable.Core.JSX.Element [])) = closure101(v0, v1)
    let v11 : Fable.Core.JSX.Element = method5(v8, v9, v10)
    [|v11|]
and closure99 (v0 : Mut10, v1 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : Fable.Core.JSX.Element = v72 |> unbox<Fable.Core.JSX.Element>
    let v74 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v73 ]
    let v75 : (unit -> (Fable.Core.JSX.Element [])) = closure100(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method31 (v0 : Mut10) : Fable.Core.JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v3 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit)) = v1 ()
    let v4 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure99(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure98 () (v0 : Mut10) : Fable.Core.JSX.Element =
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
    let v95 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v96 : string = "useContext"
    let v97 : string = "solid-js"
    let v98 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v99 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v100 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v101 : (unit -> int32), v102 : (int32 -> unit), v103 : (unit -> string), v104 : (string -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v108 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v109 : (unit -> (struct (US2 * obj * string) [])), v110 : ((struct (US2 * obj * string) []) -> unit), v111 : (unit -> (struct (System.Guid * obj) [])), v112 : ((struct (System.Guid * obj) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * int32) [])), v116 : ((struct (System.Guid * int32) []) -> unit), v117 : (unit -> US4), v118 : (US4 -> unit), v119 : (unit -> US5), v120 : (US5 -> unit)) = v98.Invoke v95 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v99, v100)
and method32 (v0 : (Mut10 -> Fable.Core.JSX.Element), v1 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> obj), v2 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit))), v3 : string) : Fable.Core.JSX.Element =
    let v4 : Mut10 = {l0 = v1; l1 = v2; l2 = v3} : Mut10
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v5 v6
    let v8 : Fable.Core.JSX.Element = v7.Invoke (v0, v4) |> unbox<Fable.Core.JSX.Element>
    v8
and closure107 (v0 : Mut11, v1 : (unit -> (struct (US2 * obj * string) []))) () : (Fable.Core.JSX.Element []) =
    let v2 : (struct (US2 * obj * string) []) = v1 ()
    let v3 : ((struct (US2 * obj * string) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = Fable.Core.JsInterop.emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : Fable.Core.JSX.Element = v5 |> unbox<Fable.Core.JSX.Element>
    let v7 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v6 ]
    [|v7|]
and closure106 (v0 : Mut11, v1 : (unit -> (struct (US2 * obj * string) []))) () : (Fable.Core.JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v2 v3
    let v5 : obj = v4
    let v6 : string = "pre"
    let v7 : obj = (Fable.Core.JsInterop.(?)) v5 v6
    let v8 : Fable.Core.JS.Function = v7 |> unbox<Fable.Core.JS.Function>
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v10 : (unit -> (Fable.Core.JSX.Element [])) = closure107(v0, v1)
    let v11 : Fable.Core.JSX.Element = method5(v8, v9, v10)
    [|v11|]
and closure105 (v0 : Mut11, v1 : (unit -> (struct (US2 * obj * string) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : Fable.Core.JSX.Element = v72 |> unbox<Fable.Core.JSX.Element>
    let v74 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v73 ]
    let v75 : (unit -> (Fable.Core.JSX.Element [])) = closure106(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method33 (v0 : Mut11) : Fable.Core.JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct (US2 * obj * string) [])), v3 : ((struct (US2 * obj * string) []) -> unit)) = v1 ()
    let v4 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure105(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure104 () (v0 : Mut11) : Fable.Core.JSX.Element =
    method33(v0)
and closure108 () (v0 : (struct (US2 * obj * string) [])) : obj =
    let v1 : obj = v0
    v1
and closure109 () () : struct ((unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit)) =
    let v95 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v96 : string = "useContext"
    let v97 : string = "solid-js"
    let v98 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v99 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v100 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v101 : (unit -> int32), v102 : (int32 -> unit), v103 : (unit -> string), v104 : (string -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v108 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v109 : (unit -> (struct (US2 * obj * string) [])), v110 : ((struct (US2 * obj * string) []) -> unit), v111 : (unit -> (struct (System.Guid * obj) [])), v112 : ((struct (System.Guid * obj) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * int32) [])), v116 : ((struct (System.Guid * int32) []) -> unit), v117 : (unit -> US4), v118 : (US4 -> unit), v119 : (unit -> US5), v120 : (US5 -> unit)) = v98.Invoke v95 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v109, v110)
and method34 (v0 : (Mut11 -> Fable.Core.JSX.Element), v1 : ((struct (US2 * obj * string) []) -> obj), v2 : (unit -> struct ((unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit))), v3 : string) : Fable.Core.JSX.Element =
    let v4 : Mut11 = {l0 = v1; l1 = v2; l2 = v3} : Mut11
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v5 v6
    let v8 : Fable.Core.JSX.Element = v7.Invoke (v0, v4) |> unbox<Fable.Core.JSX.Element>
    v8
and closure113 (v0 : Mut12, v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) () : (Fable.Core.JSX.Element []) =
    let v2 : (struct ((US2 []) * int32 * US3 * string * string) []) = v1 ()
    let v3 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = Fable.Core.JsInterop.emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : Fable.Core.JSX.Element = v5 |> unbox<Fable.Core.JSX.Element>
    let v7 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v6 ]
    [|v7|]
and closure112 (v0 : Mut12, v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) () : (Fable.Core.JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v2 v3
    let v5 : obj = v4
    let v6 : string = "pre"
    let v7 : obj = (Fable.Core.JsInterop.(?)) v5 v6
    let v8 : Fable.Core.JS.Function = v7 |> unbox<Fable.Core.JS.Function>
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v10 : (unit -> (Fable.Core.JSX.Element [])) = closure113(v0, v1)
    let v11 : Fable.Core.JSX.Element = method5(v8, v9, v10)
    [|v11|]
and closure111 (v0 : Mut12, v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : Fable.Core.JSX.Element = v72 |> unbox<Fable.Core.JSX.Element>
    let v74 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v73 ]
    let v75 : (unit -> (Fable.Core.JSX.Element [])) = closure112(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method35 (v0 : Mut12) : Fable.Core.JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v3 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit)) = v1 ()
    let v4 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure111(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure110 () (v0 : Mut12) : Fable.Core.JSX.Element =
    method35(v0)
and closure114 () (v0 : (struct ((US2 []) * int32 * US3 * string * string) [])) : obj =
    let v1 : obj = v0
    v1
and closure115 () () : struct ((unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit)) =
    let v95 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v96 : string = "useContext"
    let v97 : string = "solid-js"
    let v98 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v99 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v100 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v101 : (unit -> int32), v102 : (int32 -> unit), v103 : (unit -> string), v104 : (string -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v108 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v109 : (unit -> (struct (US2 * obj * string) [])), v110 : ((struct (US2 * obj * string) []) -> unit), v111 : (unit -> (struct (System.Guid * obj) [])), v112 : ((struct (System.Guid * obj) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * int32) [])), v116 : ((struct (System.Guid * int32) []) -> unit), v117 : (unit -> US4), v118 : (US4 -> unit), v119 : (unit -> US5), v120 : (US5 -> unit)) = v98.Invoke v95 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v107, v108)
and method36 (v0 : (Mut12 -> Fable.Core.JSX.Element), v1 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> obj), v2 : (unit -> struct ((unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit))), v3 : string) : Fable.Core.JSX.Element =
    let v4 : Mut12 = {l0 = v1; l1 = v2; l2 = v3} : Mut12
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v5 v6
    let v8 : Fable.Core.JSX.Element = v7.Invoke (v0, v4) |> unbox<Fable.Core.JSX.Element>
    v8
and closure119 (v0 : Mut13, v1 : (unit -> US4)) () : (Fable.Core.JSX.Element []) =
    let v2 : US4 = v1 ()
    let v3 : (US4 -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = Fable.Core.JsInterop.emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : Fable.Core.JSX.Element = v5 |> unbox<Fable.Core.JSX.Element>
    let v7 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v6 ]
    [|v7|]
and closure118 (v0 : Mut13, v1 : (unit -> US4)) () : (Fable.Core.JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v2 v3
    let v5 : obj = v4
    let v6 : string = "pre"
    let v7 : obj = (Fable.Core.JsInterop.(?)) v5 v6
    let v8 : Fable.Core.JS.Function = v7 |> unbox<Fable.Core.JS.Function>
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v10 : (unit -> (Fable.Core.JSX.Element [])) = closure119(v0, v1)
    let v11 : Fable.Core.JSX.Element = method5(v8, v9, v10)
    [|v11|]
and closure117 (v0 : Mut13, v1 : (unit -> US4)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : Fable.Core.JSX.Element = v72 |> unbox<Fable.Core.JSX.Element>
    let v74 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v73 ]
    let v75 : (unit -> (Fable.Core.JSX.Element [])) = closure118(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method37 (v0 : Mut13) : Fable.Core.JSX.Element =
    let v1 : (unit -> struct ((unit -> US4) * (US4 -> unit))) = v0.l1
    let struct (v2 : (unit -> US4), v3 : (US4 -> unit)) = v1 ()
    let v4 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure117(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure116 () (v0 : Mut13) : Fable.Core.JSX.Element =
    method37(v0)
and closure120 () (v0 : US4) : obj =
    let v9 : string =
        match v0 with
        | US4_0 -> (* Debug *)
            let v1 : string = "Debug"
            v1
        | US4_1 -> (* Error *)
            let v4 : string = "Error"
            v4
        | US4_2 -> (* Info *)
            let v2 : string = "Info"
            v2
        | US4_4 -> (* Warn *)
            let v3 : string = "Warn"
            v3
        | _ ->
            let v5 : string = "Error"
            v5
    let v10 : obj = v9
    v10
and closure121 () () : struct ((unit -> US4) * (US4 -> unit)) =
    let v95 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v96 : string = "useContext"
    let v97 : string = "solid-js"
    let v98 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v99 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v100 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v101 : (unit -> int32), v102 : (int32 -> unit), v103 : (unit -> string), v104 : (string -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v108 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v109 : (unit -> (struct (US2 * obj * string) [])), v110 : ((struct (US2 * obj * string) []) -> unit), v111 : (unit -> (struct (System.Guid * obj) [])), v112 : ((struct (System.Guid * obj) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * int32) [])), v116 : ((struct (System.Guid * int32) []) -> unit), v117 : (unit -> US4), v118 : (US4 -> unit), v119 : (unit -> US5), v120 : (US5 -> unit)) = v98.Invoke v95 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v117, v118)
and method38 (v0 : (Mut13 -> Fable.Core.JSX.Element), v1 : (US4 -> obj), v2 : (unit -> struct ((unit -> US4) * (US4 -> unit))), v3 : string) : Fable.Core.JSX.Element =
    let v4 : Mut13 = {l0 = v1; l1 = v2; l2 = v3} : Mut13
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v5 v6
    let v8 : Fable.Core.JSX.Element = v7.Invoke (v0, v4) |> unbox<Fable.Core.JSX.Element>
    v8
and closure125 (v0 : Mut14, v1 : (unit -> US5)) () : (Fable.Core.JSX.Element []) =
    let v2 : US5 = v1 ()
    let v3 : (US5 -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = Fable.Core.JsInterop.emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : Fable.Core.JSX.Element = v5 |> unbox<Fable.Core.JSX.Element>
    let v7 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v6 ]
    [|v7|]
and closure124 (v0 : Mut14, v1 : (unit -> US5)) () : (Fable.Core.JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v2 v3
    let v5 : obj = v4
    let v6 : string = "pre"
    let v7 : obj = (Fable.Core.JsInterop.(?)) v5 v6
    let v8 : Fable.Core.JS.Function = v7 |> unbox<Fable.Core.JS.Function>
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v10 : (unit -> (Fable.Core.JSX.Element [])) = closure125(v0, v1)
    let v11 : Fable.Core.JSX.Element = method5(v8, v9, v10)
    [|v11|]
and closure123 (v0 : Mut14, v1 : (unit -> US5)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : Fable.Core.JSX.Element = v72 |> unbox<Fable.Core.JSX.Element>
    let v74 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v73 ]
    let v75 : (unit -> (Fable.Core.JSX.Element [])) = closure124(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method39 (v0 : Mut14) : Fable.Core.JSX.Element =
    let v1 : (unit -> struct ((unit -> US5) * (US5 -> unit))) = v0.l1
    let struct (v2 : (unit -> US5), v3 : (US5 -> unit)) = v1 ()
    let v4 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure123(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure122 () (v0 : Mut14) : Fable.Core.JSX.Element =
    method39(v0)
and closure126 () (v0 : US5) : obj =
    let v1 : obj = v0
    v1
and closure127 () () : struct ((unit -> US5) * (US5 -> unit)) =
    let v95 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v96 : string = "useContext"
    let v97 : string = "solid-js"
    let v98 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v99 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v100 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v101 : (unit -> int32), v102 : (int32 -> unit), v103 : (unit -> string), v104 : (string -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v108 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v109 : (unit -> (struct (US2 * obj * string) [])), v110 : ((struct (US2 * obj * string) []) -> unit), v111 : (unit -> (struct (System.Guid * obj) [])), v112 : ((struct (System.Guid * obj) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * int32) [])), v116 : ((struct (System.Guid * int32) []) -> unit), v117 : (unit -> US4), v118 : (US4 -> unit), v119 : (unit -> US5), v120 : (US5 -> unit)) = v98.Invoke v95 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v119, v120)
and method40 (v0 : (Mut14 -> Fable.Core.JSX.Element), v1 : (US5 -> obj), v2 : (unit -> struct ((unit -> US5) * (US5 -> unit))), v3 : string) : Fable.Core.JSX.Element =
    let v4 : Mut14 = {l0 = v1; l1 = v2; l2 = v3} : Mut14
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v5 v6
    let v8 : Fable.Core.JSX.Element = v7.Invoke (v0, v4) |> unbox<Fable.Core.JSX.Element>
    v8
and closure131 (v0 : Mut15, v1 : (unit -> (struct (System.Guid * int32) []))) () : (Fable.Core.JSX.Element []) =
    let v2 : (struct (System.Guid * int32) []) = v1 ()
    let v3 : ((struct (System.Guid * int32) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = Fable.Core.JsInterop.emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : Fable.Core.JSX.Element = v5 |> unbox<Fable.Core.JSX.Element>
    let v7 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v6 ]
    [|v7|]
and closure130 (v0 : Mut15, v1 : (unit -> (struct (System.Guid * int32) []))) () : (Fable.Core.JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v2 v3
    let v5 : obj = v4
    let v6 : string = "pre"
    let v7 : obj = (Fable.Core.JsInterop.(?)) v5 v6
    let v8 : Fable.Core.JS.Function = v7 |> unbox<Fable.Core.JS.Function>
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v10 : (unit -> (Fable.Core.JSX.Element [])) = closure131(v0, v1)
    let v11 : Fable.Core.JSX.Element = method5(v8, v9, v10)
    [|v11|]
and closure129 (v0 : Mut15, v1 : (unit -> (struct (System.Guid * int32) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : Fable.Core.JSX.Element = v72 |> unbox<Fable.Core.JSX.Element>
    let v74 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v73 ]
    let v75 : (unit -> (Fable.Core.JSX.Element [])) = closure130(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method41 (v0 : Mut15) : Fable.Core.JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct (System.Guid * int32) [])), v3 : ((struct (System.Guid * int32) []) -> unit)) = v1 ()
    let v4 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure129(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure128 () (v0 : Mut15) : Fable.Core.JSX.Element =
    method41(v0)
and closure132 () (v0 : (struct (System.Guid * int32) [])) : obj =
    let v1 : obj = v0
    v1
and closure133 () () : struct ((unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit)) =
    let v95 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v96 : string = "useContext"
    let v97 : string = "solid-js"
    let v98 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v99 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v100 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v101 : (unit -> int32), v102 : (int32 -> unit), v103 : (unit -> string), v104 : (string -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v108 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v109 : (unit -> (struct (US2 * obj * string) [])), v110 : ((struct (US2 * obj * string) []) -> unit), v111 : (unit -> (struct (System.Guid * obj) [])), v112 : ((struct (System.Guid * obj) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * int32) [])), v116 : ((struct (System.Guid * int32) []) -> unit), v117 : (unit -> US4), v118 : (US4 -> unit), v119 : (unit -> US5), v120 : (US5 -> unit)) = v98.Invoke v95 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v115, v116)
and method42 (v0 : (Mut15 -> Fable.Core.JSX.Element), v1 : ((struct (System.Guid * int32) []) -> obj), v2 : (unit -> struct ((unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit))), v3 : string) : Fable.Core.JSX.Element =
    let v4 : Mut15 = {l0 = v1; l1 = v2; l2 = v3} : Mut15
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v5 v6
    let v8 : Fable.Core.JSX.Element = v7.Invoke (v0, v4) |> unbox<Fable.Core.JSX.Element>
    v8
and closure137 (v0 : Mut16, v1 : (unit -> (struct (System.Guid * obj) []))) () : (Fable.Core.JSX.Element []) =
    let v2 : (struct (System.Guid * obj) []) = v1 ()
    let v3 : ((struct (System.Guid * obj) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = Fable.Core.JsInterop.emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : Fable.Core.JSX.Element = v5 |> unbox<Fable.Core.JSX.Element>
    let v7 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v6 ]
    [|v7|]
and closure136 (v0 : Mut16, v1 : (unit -> (struct (System.Guid * obj) []))) () : (Fable.Core.JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v2 v3
    let v5 : obj = v4
    let v6 : string = "pre"
    let v7 : obj = (Fable.Core.JsInterop.(?)) v5 v6
    let v8 : Fable.Core.JS.Function = v7 |> unbox<Fable.Core.JS.Function>
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v10 : (unit -> (Fable.Core.JSX.Element [])) = closure137(v0, v1)
    let v11 : Fable.Core.JSX.Element = method5(v8, v9, v10)
    [|v11|]
and closure135 (v0 : Mut16, v1 : (unit -> (struct (System.Guid * obj) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : Fable.Core.JSX.Element = v72 |> unbox<Fable.Core.JSX.Element>
    let v74 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v73 ]
    let v75 : (unit -> (Fable.Core.JSX.Element [])) = closure136(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method43 (v0 : Mut16) : Fable.Core.JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct (System.Guid * obj) [])), v3 : ((struct (System.Guid * obj) []) -> unit)) = v1 ()
    let v4 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure135(v0, v2)
    let v8 : US15 = US15_2
    method26(v4, v5, v6, v7, v8)
and closure134 () (v0 : Mut16) : Fable.Core.JSX.Element =
    method43(v0)
and closure138 () (v0 : (struct (System.Guid * obj) [])) : obj =
    let v1 : obj = v0
    v1
and closure139 () () : struct ((unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit)) =
    let v95 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v96 : string = "useContext"
    let v97 : string = "solid-js"
    let v98 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v99 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v100 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v101 : (unit -> int32), v102 : (int32 -> unit), v103 : (unit -> string), v104 : (string -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v108 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v109 : (unit -> (struct (US2 * obj * string) [])), v110 : ((struct (US2 * obj * string) []) -> unit), v111 : (unit -> (struct (System.Guid * obj) [])), v112 : ((struct (System.Guid * obj) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * int32) [])), v116 : ((struct (System.Guid * int32) []) -> unit), v117 : (unit -> US4), v118 : (US4 -> unit), v119 : (unit -> US5), v120 : (US5 -> unit)) = v98.Invoke v95 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v113, v114)
and method44 (v0 : (Mut16 -> Fable.Core.JSX.Element), v1 : ((struct (System.Guid * obj) []) -> obj), v2 : (unit -> struct ((unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit))), v3 : string) : Fable.Core.JSX.Element =
    let v4 : Mut16 = {l0 = v1; l1 = v2; l2 = v3} : Mut16
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v5 v6
    let v8 : Fable.Core.JSX.Element = v7.Invoke (v0, v4) |> unbox<Fable.Core.JSX.Element>
    v8
and closure140 () () : struct ((unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit)) =
    let v95 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v96 : string = "useContext"
    let v97 : string = "solid-js"
    let v98 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v99 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v100 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v101 : (unit -> int32), v102 : (int32 -> unit), v103 : (unit -> string), v104 : (string -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v108 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v109 : (unit -> (struct (US2 * obj * string) [])), v110 : ((struct (US2 * obj * string) []) -> unit), v111 : (unit -> (struct (System.Guid * obj) [])), v112 : ((struct (System.Guid * obj) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * int32) [])), v116 : ((struct (System.Guid * int32) []) -> unit), v117 : (unit -> US4), v118 : (US4 -> unit), v119 : (unit -> US5), v120 : (US5 -> unit)) = v98.Invoke v95 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v111, v112)
and closure84 () () : (Fable.Core.JSX.Element []) =
    let v0 : (Mut8 -> Fable.Core.JSX.Element) = closure85()
    let v1 : (string -> obj) = closure89()
    let v2 : (unit -> struct ((unit -> string) * (string -> unit))) = closure90()
    let v3 : string = "chain.token"
    let v4 : Fable.Core.JSX.Element = method28(v0, v1, v2, v3)
    let v5 : (unit -> struct ((unit -> string) * (string -> unit))) = closure91()
    let v6 : string = "chain.url"
    let v7 : Fable.Core.JSX.Element = method28(v0, v1, v5, v6)
    let v8 : (Mut9 -> Fable.Core.JSX.Element) = closure92()
    let v9 : (int32 -> obj) = closure96()
    let v10 : (unit -> struct ((unit -> int32) * (int32 -> unit))) = closure97()
    let v11 : string = "chain.port"
    let v12 : Fable.Core.JSX.Element = method30(v8, v9, v10, v11)
    let v13 : (Mut10 -> Fable.Core.JSX.Element) = closure98()
    let v14 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> obj) = closure102()
    let v15 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit))) = closure103()
    let v16 : string = "chain.accounts"
    let v17 : Fable.Core.JSX.Element = method32(v13, v14, v15, v16)
    let v18 : (Mut11 -> Fable.Core.JSX.Element) = closure104()
    let v19 : ((struct (US2 * obj * string) []) -> obj) = closure108()
    let v20 : (unit -> struct ((unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit))) = closure109()
    let v21 : string = "db.connections"
    let v22 : Fable.Core.JSX.Element = method34(v18, v19, v20, v21)
    let v23 : (Mut12 -> Fable.Core.JSX.Element) = closure110()
    let v24 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> obj) = closure114()
    let v25 : (unit -> struct ((unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit))) = closure115()
    let v26 : string = "db.connection_options"
    let v27 : Fable.Core.JSX.Element = method36(v23, v24, v25, v26)
    let v28 : (Mut13 -> Fable.Core.JSX.Element) = closure116()
    let v29 : (US4 -> obj) = closure120()
    let v30 : (unit -> struct ((unit -> US4) * (US4 -> unit))) = closure121()
    let v31 : string = "settings.log_level"
    let v32 : Fable.Core.JSX.Element = method38(v28, v29, v30, v31)
    let v33 : (Mut14 -> Fable.Core.JSX.Element) = closure122()
    let v34 : (US5 -> obj) = closure126()
    let v35 : (unit -> struct ((unit -> US5) * (US5 -> unit))) = closure127()
    let v36 : string = "settings.ui.modal"
    let v37 : Fable.Core.JSX.Element = method40(v33, v34, v35, v36)
    let v38 : (Mut15 -> Fable.Core.JSX.Element) = closure128()
    let v39 : ((struct (System.Guid * int32) []) -> obj) = closure132()
    let v40 : (unit -> struct ((unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit))) = closure133()
    let v41 : string = "profile.tmp.counter"
    let v42 : Fable.Core.JSX.Element = method42(v38, v39, v40, v41)
    let v43 : (Mut16 -> Fable.Core.JSX.Element) = closure134()
    let v44 : ((struct (System.Guid * obj) []) -> obj) = closure138()
    let v45 : (unit -> struct ((unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit))) = closure139()
    let v46 : string = "profile.tmp.chain_status"
    let v47 : Fable.Core.JSX.Element = method44(v43, v44, v45, v46)
    let v48 : (unit -> struct ((unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit))) = closure140()
    let v49 : string = "profile.tmp.chain_deploy"
    let v50 : Fable.Core.JSX.Element = method44(v43, v44, v48, v49)
    [|v4; v7; v12; v17; v22; v27; v32; v37; v42; v47; v50|]
and closure82 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/core"
    let v2 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v0 v1
    let v3 : obj = v2
    let v4 : string = "pre"
    let v5 : obj = (Fable.Core.JsInterop.(?)) v3 v4
    let v6 : Fable.Core.JS.Function = v5 |> unbox<Fable.Core.JS.Function>
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure83()
    let v8 : (unit -> (Fable.Core.JSX.Element [])) = closure84()
    let v9 : Fable.Core.JSX.Element = method5(v6, v7, v8)
    [|v9|]
and closure81 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "State"
    let v71 : Fable.Core.JSX.Element = v70 |> unbox<Fable.Core.JSX.Element>
    let v72 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v71 ]
    let v73 : (unit -> (Fable.Core.JSX.Element [])) = closure82()
    let v74 : US9 = US9_1(v73)
    let v75 : string = "flex-start"
    let v76 : US6 = US6_1(v75)
    let v77 : US11 = US11_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v76, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v77, v63, v64, v65, v66, v67, v68, v69)
and closure78 (v0 : (unit -> US4)) () : (Fable.Core.JSX.Element []) =
    let v1 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v2 : US13 = US13_0
    let v3 : US13 = US13_0
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure79(v0)
    let v5 : US15 = US15_2
    let v6 : Fable.Core.JSX.Element = method26(v1, v2, v3, v4, v5)
    let v7 : US13 = US13_0
    let v8 : US13 = US13_0
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure81()
    let v10 : US15 = US15_2
    let v11 : Fable.Core.JSX.Element = method26(v1, v7, v8, v9, v10)
    [|v6; v11|]
and closure77 (v0 : (unit -> US4)) () : (Fable.Core.JSX.Element []) =
    let v1 : (Mut1 -> Fable.Core.JSX.Element) = closure7()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v3 : (unit -> (Fable.Core.JSX.Element [])) = closure78(v0)
    let v4 : Fable.Core.JSX.Element = method22(v1, v2, v3)
    [|v4|]
and closure76 (v0 : (unit -> US4)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : string = "Debug"
    let v72 : Fable.Core.JSX.Element = v71 |> unbox<Fable.Core.JSX.Element>
    let v73 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v72 ]
    let v74 : (unit -> (Fable.Core.JSX.Element [])) = closure77(v0)
    let v75 : US9 = US9_1(v74)
    let v76 : string = "flex-start"
    let v77 : US6 = US6_1(v76)
    let v78 : string = "15px"
    let v79 : US6 = US6_1(v78)
    let v80 : US11 = US11_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v75, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v77, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v79, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v80, v64, v65, v66, v67, v68, v69, v70)
and closure13 (v0 : (unit -> US4)) () : (Fable.Core.JSX.Element []) =
    let v1 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v2 : US13 = US13_0
    let v3 : US13 = US13_0
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure76(v0)
    let v5 : US15 = US15_0
    let v6 : Fable.Core.JSX.Element = method26(v1, v2, v3, v4, v5)
    [|v6|]
and closure6 (v0 : (unit -> US4)) () : (Fable.Core.JSX.Element []) =
    let v1 : (Mut1 -> Fable.Core.JSX.Element) = closure7()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v3 : (unit -> (Fable.Core.JSX.Element [])) = closure13(v0)
    let v4 : Fable.Core.JSX.Element = method22(v1, v2, v3)
    [|v4|]
and method3 () : Fable.Core.JSX.Element =
    let v95 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v96 : string = "useContext"
    let v97 : string = "solid-js"
    let v98 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v99 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v100 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v101 : (unit -> int32), v102 : (int32 -> unit), v103 : (unit -> string), v104 : (string -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v108 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v109 : (unit -> (struct (US2 * obj * string) [])), v110 : ((struct (US2 * obj * string) []) -> unit), v111 : (unit -> (struct (System.Guid * obj) [])), v112 : ((struct (System.Guid * obj) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * int32) [])), v116 : ((struct (System.Guid * int32) []) -> unit), v117 : (unit -> US4), v118 : (US4 -> unit), v119 : (unit -> US5), v120 : (US5 -> unit)) = v98.Invoke v95 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v121 : string = "Box"
    let v122 : string = "@hope-ui/core"
    let v123 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v121 v122
    let v124 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure5()
    let v125 : (unit -> (Fable.Core.JSX.Element [])) = closure6(v117)
    method5(v123, v124, v125)
and closure4 () (v0 : Mut2) : Fable.Core.JSX.Element =
    method3()
and method45 (v0 : (Mut2 -> Fable.Core.JSX.Element)) : Fable.Core.JSX.Element =
    let v1 : Mut2 = Mut2()
    let v2 : string = "createComponent"
    let v3 : string = "solid-js"
    let v4 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v2 v3
    let v5 : Fable.Core.JSX.Element = v4.Invoke (v0, v1) |> unbox<Fable.Core.JSX.Element>
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
and closure152 (v0 : Mut1) () : (Fable.Core.JSX.Element []) =
    let v1 : US6 = v0.l25
    let v5 : string =
        match v1 with
        | US6_0 -> (* None *)
            let v3 : string = ""
            v3
        | US6_1(v2) -> (* Some *)
            v2
    let v6 : Fable.Core.JSX.Element = v5 |> unbox<Fable.Core.JSX.Element>
    let v7 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v6 ]
    [|v7|]
and closure153 () () : Fable.Core.JS.Function =
    let v0 : string = "BiRegularLinkExternal"
    let v1 : string = "solid-icons/bi"
    let v2 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v0 v1
    v2
and closure154 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    let v71 : string = "-13px"
    let v72 : US6 = US6_1(v71)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v70, v35, v72, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and method48 (v0 : (Mut7 -> Fable.Core.JSX.Element), v1 : (unit -> Fable.Core.JS.Function), v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)), v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6))) : Fable.Core.JSX.Element =
    let v4 : Mut7 = {l0 = v1; l1 = v2; l2 = v3} : Mut7
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v5 v6
    let v8 : Fable.Core.JSX.Element = v7.Invoke (v0, v4) |> unbox<Fable.Core.JSX.Element>
    v8
and closure150 (v0 : Mut1) () : (Fable.Core.JSX.Element []) =
    let v1 : string = "Anchor"
    let v2 : string = "@hope-ui/core"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure151(v0)
    let v5 : (unit -> (Fable.Core.JSX.Element [])) = closure152(v0)
    let v6 : Fable.Core.JSX.Element = method5(v3, v4, v5)
    let v7 : string = "&nbsp;"
    let v8 : Fable.Core.JSX.Element = v7 |> unbox<Fable.Core.JSX.Element>
    let v9 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v8 ]
    let v10 : (Mut7 -> Fable.Core.JSX.Element) = closure60()
    let v11 : (unit -> Fable.Core.JS.Function) = closure153()
    let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v13 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure154()
    let v14 : Fable.Core.JSX.Element = method48(v10, v11, v12, v13)
    [|v6; v9; v14|]
and method47 (v0 : Mut1) : Fable.Core.JSX.Element =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/core"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v5 : (unit -> (Fable.Core.JSX.Element [])) = closure150(v0)
    method5(v3, v4, v5)
and closure149 () (v0 : Mut1) : Fable.Core.JSX.Element =
    method47(v0)
and closure155 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "https://github.com/fc1943s/tictactoe"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v71, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure156 () () : (Fable.Core.JSX.Element []) =
    [||]
and closure148 () () : (Fable.Core.JSX.Element []) =
    let v0 : (Mut1 -> Fable.Core.JSX.Element) = closure149()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure155()
    let v2 : (unit -> (Fable.Core.JSX.Element [])) = closure156()
    let v3 : Fable.Core.JSX.Element = method22(v0, v1, v2)
    [|v3|]
and closure147 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : (unit -> (Fable.Core.JSX.Element [])) = closure148()
    let v71 : US9 = US9_1(v70)
    let v72 : string = "1px 6px"
    let v73 : US6 = US6_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v73, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure159 (v0 : string) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : US6 = US6_1(v0)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v71, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure158 (v0 : string) () : (Fable.Core.JSX.Element []) =
    let v1 : (Mut1 -> Fable.Core.JSX.Element) = closure149()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure159(v0)
    let v3 : (unit -> (Fable.Core.JSX.Element [])) = closure156()
    let v4 : Fable.Core.JSX.Element = method22(v1, v2, v3)
    [|v4|]
and closure157 (v0 : string) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (unit -> (Fable.Core.JSX.Element [])) = closure158(v0)
    let v72 : US9 = US9_1(v71)
    let v73 : string = "1px 6px"
    let v74 : US6 = US6_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v72, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v74, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure162 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "https://fc1943s.github.io/tictactoe"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v71, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure161 () () : (Fable.Core.JSX.Element []) =
    let v0 : (Mut1 -> Fable.Core.JSX.Element) = closure149()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure162()
    let v2 : (unit -> (Fable.Core.JSX.Element [])) = closure156()
    let v3 : Fable.Core.JSX.Element = method22(v0, v1, v2)
    [|v3|]
and closure160 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : (unit -> (Fable.Core.JSX.Element [])) = closure161()
    let v71 : US9 = US9_1(v70)
    let v72 : string = "1px 6px"
    let v73 : US6 = US6_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v73, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure165 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "https://fc1943s.github.io/tictactoe/docs"
    let v71 : US6 = US6_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v71, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure164 () () : (Fable.Core.JSX.Element []) =
    let v0 : (Mut1 -> Fable.Core.JSX.Element) = closure149()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure165()
    let v2 : (unit -> (Fable.Core.JSX.Element [])) = closure156()
    let v3 : Fable.Core.JSX.Element = method22(v0, v1, v2)
    [|v3|]
and closure163 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : (unit -> (Fable.Core.JSX.Element [])) = closure164()
    let v71 : US9 = US9_1(v70)
    let v72 : string = "1px 6px"
    let v73 : US6 = US6_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v73, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure146 (v0 : string) () : (Fable.Core.JSX.Element []) =
    let v1 : bool = "" = v0
    let v15 : Fable.Core.JSX.Element =
        if v1 then
            let v2 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
            let v3 : US13 = US13_0
            let v4 : US13 = US13_0
            let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure147()
            let v6 : US15 = US15_2
            method26(v2, v3, v4, v5, v6)
        else
            let v8 : string = $"https://github.com/fc1943s/tictactoe/tree/{v0}"
            let v9 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
            let v10 : US13 = US13_0
            let v11 : US13 = US13_0
            let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure157(v8)
            let v13 : US15 = US15_2
            method26(v9, v10, v11, v12, v13)
    let v16 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v17 : US13 = US13_0
    let v18 : US13 = US13_0
    let v19 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure160()
    let v20 : US15 = US15_2
    let v21 : Fable.Core.JSX.Element = method26(v16, v17, v18, v19, v20)
    let v22 : US13 = US13_0
    let v23 : US13 = US13_0
    let v24 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure163()
    let v25 : US15 = US15_2
    let v26 : Fable.Core.JSX.Element = method26(v16, v22, v23, v24, v25)
    [|v15; v21; v26|]
and method46 () : Fable.Core.JSX.Element =
    let struct (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) = method2()
    let v5 : (Mut1 -> Fable.Core.JSX.Element) = closure7()
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (Fable.Core.JSX.Element [])) = closure146(v3)
    method22(v5, v6, v7)
and closure145 () (v0 : Mut1) : Fable.Core.JSX.Element =
    method46()
and closure166 () () : (Fable.Core.JSX.Element []) =
    [||]
and closure144 () () : (Fable.Core.JSX.Element []) =
    let v0 : (Mut1 -> Fable.Core.JSX.Element) = closure145()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (Fable.Core.JSX.Element [])) = closure166()
    let v3 : Fable.Core.JSX.Element = method22(v0, v1, v2)
    [|v3|]
and closure143 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "Links"
    let v71 : Fable.Core.JSX.Element = v70 |> unbox<Fable.Core.JSX.Element>
    let v72 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v71 ]
    let v73 : (unit -> (Fable.Core.JSX.Element [])) = closure144()
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
and closure180 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "Dark"
    let v1 : Fable.Core.JSX.Element = v0 |> unbox<Fable.Core.JSX.Element>
    let v2 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v1 ]
    [|v2|]
and closure178 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/core"
    let v2 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v0 v1
    let v3 : obj = v2
    let v4 : string = "input"
    let v5 : obj = (Fable.Core.JsInterop.(?)) v3 v4
    let v6 : Fable.Core.JS.Function = v5 |> unbox<Fable.Core.JS.Function>
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure179()
    let v8 : (unit -> (Fable.Core.JSX.Element [])) = closure26()
    let v9 : Fable.Core.JSX.Element = method5(v6, v7, v8)
    let v10 : string = "&nbsp;"
    let v11 : Fable.Core.JSX.Element = v10 |> unbox<Fable.Core.JSX.Element>
    let v12 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v11 ]
    let v13 : (unit -> (Fable.Core.JSX.Element [])) = closure180()
    let v14 : Fable.Core.JSX.Element = v13 |> unbox<Fable.Core.JSX.Element>
    [|v9; v12; v14|]
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
and closure183 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "Light"
    let v1 : Fable.Core.JSX.Element = v0 |> unbox<Fable.Core.JSX.Element>
    let v2 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v1 ]
    [|v2|]
and closure181 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/core"
    let v2 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v0 v1
    let v3 : obj = v2
    let v4 : string = "input"
    let v5 : obj = (Fable.Core.JsInterop.(?)) v3 v4
    let v6 : Fable.Core.JS.Function = v5 |> unbox<Fable.Core.JS.Function>
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure182()
    let v8 : (unit -> (Fable.Core.JSX.Element [])) = closure26()
    let v9 : Fable.Core.JSX.Element = method5(v6, v7, v8)
    let v10 : string = "&nbsp;"
    let v11 : Fable.Core.JSX.Element = v10 |> unbox<Fable.Core.JSX.Element>
    let v12 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v11 ]
    let v13 : (unit -> (Fable.Core.JSX.Element [])) = closure183()
    let v14 : Fable.Core.JSX.Element = v13 |> unbox<Fable.Core.JSX.Element>
    [|v9; v12; v14|]
and closure177 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "Box"
    let v1 : string = "@hope-ui/core"
    let v2 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v0 v1
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure22()
    let v4 : (unit -> (Fable.Core.JSX.Element [])) = closure178()
    let v5 : Fable.Core.JSX.Element = method5(v2, v3, v4)
    let v6 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v0 v1
    let v7 : (unit -> (Fable.Core.JSX.Element [])) = closure181()
    let v8 : Fable.Core.JSX.Element = method5(v6, v3, v7)
    [|v5; v8|]
and closure175 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "Stack"
    let v1 : string = "@hope-ui/core"
    let v2 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v0 v1
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure176()
    let v4 : (unit -> (Fable.Core.JSX.Element [])) = closure177()
    let v5 : Fable.Core.JSX.Element = method5(v2, v3, v4)
    [|v5|]
and closure174 () () : (Fable.Core.JSX.Element []) =
    let v0 : (unit -> (Fable.Core.JSX.Element [])) = closure175()
    let v1 : Fable.Core.JSX.Element = v0 |> unbox<Fable.Core.JSX.Element>
    [|v1|]
and closure172 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "Box"
    let v1 : string = "@hope-ui/core"
    let v2 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v0 v1
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure173()
    let v4 : (unit -> (Fable.Core.JSX.Element [])) = closure174()
    let v5 : Fable.Core.JSX.Element = method5(v2, v3, v4)
    [|v5|]
and closure171 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "Theme"
    let v71 : Fable.Core.JSX.Element = v70 |> unbox<Fable.Core.JSX.Element>
    let v72 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v71 ]
    let v73 : (unit -> (Fable.Core.JSX.Element [])) = closure172()
    let v74 : US9 = US9_1(v73)
    let v75 : string = "5px 6px"
    let v76 : US6 = US6_1(v75)
    let v77 : US11 = US11_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v76, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v77, v63, v64, v65, v66, v67, v68, v69)
and closure170 () () : (Fable.Core.JSX.Element []) =
    let v0 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v1 : US13 = US13_0
    let v2 : US13 = US13_0
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure171()
    let v4 : US15 = US15_2
    let v5 : Fable.Core.JSX.Element = method26(v0, v1, v2, v3, v4)
    [|v5|]
and method49 () : Fable.Core.JSX.Element =
    let v0 : (Mut1 -> Fable.Core.JSX.Element) = closure7()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (Fable.Core.JSX.Element [])) = closure170()
    method22(v0, v1, v2)
and closure169 () (v0 : Mut1) : Fable.Core.JSX.Element =
    method49()
and closure184 () () : (Fable.Core.JSX.Element []) =
    [||]
and closure168 () () : (Fable.Core.JSX.Element []) =
    let v0 : (Mut1 -> Fable.Core.JSX.Element) = closure169()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (Fable.Core.JSX.Element [])) = closure184()
    let v3 : Fable.Core.JSX.Element = method22(v0, v1, v2)
    [|v3|]
and closure167 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "Settings"
    let v71 : Fable.Core.JSX.Element = v70 |> unbox<Fable.Core.JSX.Element>
    let v72 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v71 ]
    let v73 : (unit -> (Fable.Core.JSX.Element [])) = closure168()
    let v74 : US9 = US9_1(v73)
    let v75 : US11 = US11_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure197 (v0 : Mut17) (v1 : obj) : unit =
    let v2 : string = "currentTarget"
    let v3 : obj = (Fable.Core.JsInterop.(?)) v1 v2
    let v4 : string = "value"
    let v5 : obj = (Fable.Core.JsInterop.(?)) v3 v4
    let v6 : string = v5 |> unbox<string>
    let v7 : (US6 -> unit) = v0.l1
    let v8 : US6 = US6_1(v6)
    v7 v8
and closure196 (v0 : Mut17) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (unit -> US6) = v0.l0
    let v72 : US6 = v71 ()
    let v73 : string = Fable.Core.JS.undefined
    let v76 : string =
        match v72 with
        | US6_0 -> (* None *)
            v73
        | US6_1(v74) -> (* Some *)
            v74
    let v77 : obj = v76
    let v78 : string = "15vw"
    let v79 : US6 = US6_1(v78)
    let v80 : (obj -> unit) = closure197(v0)
    let v81 : US12 = US12_1(v80)
    let v82 : string = "xs"
    let v83 : US6 = US6_1(v82)
    let v84 : string = "text"
    let v85 : US6 = US6_1(v84)
    let v86 : US14 = US14_1(v77)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v79, v42, v43, v81, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v83, v58, v59, v60, v61, v62, v63, v64, v85, v86, v67, v68, v69, v70)
and closure198 () () : (Fable.Core.JSX.Element []) =
    [||]
and method52 (v0 : Mut17) : Fable.Core.JSX.Element =
    let v1 : string = "Input"
    let v2 : string = "@hope-ui/core"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure196(v0)
    let v5 : (unit -> (Fable.Core.JSX.Element [])) = closure198()
    method5(v3, v4, v5)
and closure195 () (v0 : Mut17) : Fable.Core.JSX.Element =
    method52(v0)
and closure199 (v0 : (unit -> string)) () : US6 =
    let v1 : string = v0 ()
    US6_1(v1)
and closure200 (v0 : (string -> unit)) (v1 : US6) : unit =
    let v5 : string =
        match v1 with
        | US6_0 -> (* None *)
            failwith<string> "Option does not have a value."
        | US6_1(v2) -> (* Some *)
            v2
    v0 v5
and method53 (v0 : (Mut17 -> Fable.Core.JSX.Element), v1 : (unit -> US6), v2 : (US6 -> unit)) : Fable.Core.JSX.Element =
    let v3 : Mut17 = {l0 = v1; l1 = v2} : Mut17
    let v4 : string = "createComponent"
    let v5 : string = "solid-js"
    let v6 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v4 v5
    let v7 : Fable.Core.JSX.Element = v6.Invoke (v0, v3) |> unbox<Fable.Core.JSX.Element>
    v7
and closure194 (v0 : (string -> unit), v1 : (unit -> string)) () : (Fable.Core.JSX.Element []) =
    let v2 : (Mut17 -> Fable.Core.JSX.Element) = closure195()
    let v3 : (unit -> US6) = closure199(v1)
    let v4 : (US6 -> unit) = closure200(v0)
    let v5 : Fable.Core.JSX.Element = method53(v2, v3, v4)
    [|v5|]
and closure193 (v0 : (string -> unit), v1 : (unit -> string)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = "Token"
    let v73 : Fable.Core.JSX.Element = v72 |> unbox<Fable.Core.JSX.Element>
    let v74 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v73 ]
    let v75 : (unit -> (Fable.Core.JSX.Element [])) = closure194(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "3px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v78, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and closure202 (v0 : (string -> unit), v1 : (unit -> string)) () : (Fable.Core.JSX.Element []) =
    let v2 : (Mut17 -> Fable.Core.JSX.Element) = closure195()
    let v3 : (unit -> US6) = closure199(v1)
    let v4 : (US6 -> unit) = closure200(v0)
    let v5 : Fable.Core.JSX.Element = method53(v2, v3, v4)
    [|v5|]
and closure201 (v0 : (string -> unit), v1 : (unit -> string)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = "URL"
    let v73 : Fable.Core.JSX.Element = v72 |> unbox<Fable.Core.JSX.Element>
    let v74 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v73 ]
    let v75 : (unit -> (Fable.Core.JSX.Element [])) = closure202(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "3px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v78, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and closure207 (v0 : Mut18) (v1 : obj) : unit =
    let v2 : string = "currentTarget"
    let v3 : obj = (Fable.Core.JsInterop.(?)) v1 v2
    let v4 : string = "value"
    let v5 : obj = (Fable.Core.JsInterop.(?)) v3 v4
    let v6 : int32 = v5 |> unbox<int32>
    let v7 : (US5 -> unit) = v0.l1
    let v8 : US5 = US5_1(v6)
    v7 v8
and closure206 (v0 : Mut18) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (unit -> US5) = v0.l0
    let v72 : US5 = v71 ()
    let v73 : int32 = Fable.Core.JS.undefined
    let v76 : int32 =
        match v72 with
        | US5_0 -> (* None *)
            v73
        | US5_1(v74) -> (* Some *)
            v74
    let v77 : obj = v76
    let v78 : string = "15vw"
    let v79 : US6 = US6_1(v78)
    let v80 : (obj -> unit) = closure207(v0)
    let v81 : US12 = US12_1(v80)
    let v82 : string = "xs"
    let v83 : US6 = US6_1(v82)
    let v84 : string = "text"
    let v85 : US6 = US6_1(v84)
    let v86 : US14 = US14_1(v77)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v79, v42, v43, v81, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v83, v58, v59, v60, v61, v62, v63, v64, v85, v86, v67, v68, v69, v70)
and method54 (v0 : Mut18) : Fable.Core.JSX.Element =
    let v1 : string = "Input"
    let v2 : string = "@hope-ui/core"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure206(v0)
    let v5 : (unit -> (Fable.Core.JSX.Element [])) = closure198()
    method5(v3, v4, v5)
and closure205 () (v0 : Mut18) : Fable.Core.JSX.Element =
    method54(v0)
and closure208 (v0 : (unit -> int32)) () : US5 =
    let v1 : int32 = v0 ()
    US5_1(v1)
and closure209 (v0 : (int32 -> unit)) (v1 : US5) : unit =
    let v5 : int32 =
        match v1 with
        | US5_0 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US5_1(v2) -> (* Some *)
            v2
    v0 v5
and method55 (v0 : (Mut18 -> Fable.Core.JSX.Element), v1 : (unit -> US5), v2 : (US5 -> unit)) : Fable.Core.JSX.Element =
    let v3 : Mut18 = {l0 = v1; l1 = v2} : Mut18
    let v4 : string = "createComponent"
    let v5 : string = "solid-js"
    let v6 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v4 v5
    let v7 : Fable.Core.JSX.Element = v6.Invoke (v0, v3) |> unbox<Fable.Core.JSX.Element>
    v7
and closure204 (v0 : (int32 -> unit), v1 : (unit -> int32)) () : (Fable.Core.JSX.Element []) =
    let v2 : (Mut18 -> Fable.Core.JSX.Element) = closure205()
    let v3 : (unit -> US5) = closure208(v1)
    let v4 : (US5 -> unit) = closure209(v0)
    let v5 : Fable.Core.JSX.Element = method55(v2, v3, v4)
    [|v5|]
and closure203 (v0 : (int32 -> unit), v1 : (unit -> int32)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US6, v18 : US6, v19 : US6, v20 : US10, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US6, v30 : US6, v31 : US6, v32 : US11, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US12, v44 : US13, v45 : US12, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US14, v63 : US6, v64 : US11, v65 : US6, v66 : US6, v67 : US14, v68 : US14, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v72 : string = "Port"
    let v73 : Fable.Core.JSX.Element = v72 |> unbox<Fable.Core.JSX.Element>
    let v74 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v73 ]
    let v75 : (unit -> (Fable.Core.JSX.Element [])) = closure204(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "3px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v78, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and closure192 (v0 : (string -> unit), v1 : (unit -> string), v2 : (string -> unit), v3 : (unit -> string), v4 : (int32 -> unit), v5 : (unit -> int32)) () : (Fable.Core.JSX.Element []) =
    let v6 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v7 : US13 = US13_0
    let v8 : US13 = US13_0
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure193(v0, v1)
    let v10 : US15 = US15_2
    let v11 : Fable.Core.JSX.Element = method26(v6, v7, v8, v9, v10)
    let v12 : US13 = US13_0
    let v13 : US13 = US13_0
    let v14 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure201(v2, v3)
    let v15 : US15 = US15_2
    let v16 : Fable.Core.JSX.Element = method26(v6, v12, v13, v14, v15)
    let v17 : US13 = US13_0
    let v18 : US13 = US13_0
    let v19 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure203(v4, v5)
    let v20 : US15 = US15_2
    let v21 : Fable.Core.JSX.Element = method26(v6, v17, v18, v19, v20)
    [|v11; v16; v21|]
and method51 () : Fable.Core.JSX.Element =
    let v95 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v96 : string = "useContext"
    let v97 : string = "solid-js"
    let v98 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v99 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v100 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v101 : (unit -> int32), v102 : (int32 -> unit), v103 : (unit -> string), v104 : (string -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v108 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v109 : (unit -> (struct (US2 * obj * string) [])), v110 : ((struct (US2 * obj * string) []) -> unit), v111 : (unit -> (struct (System.Guid * obj) [])), v112 : ((struct (System.Guid * obj) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * int32) [])), v116 : ((struct (System.Guid * int32) []) -> unit), v117 : (unit -> US4), v118 : (US4 -> unit), v119 : (unit -> US5), v120 : (US5 -> unit)) = v98.Invoke v95 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v216 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v217 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v218 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v219 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v220 : (unit -> int32), v221 : (int32 -> unit), v222 : (unit -> string), v223 : (string -> unit), v224 : (unit -> string), v225 : (string -> unit), v226 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v227 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v228 : (unit -> (struct (US2 * obj * string) [])), v229 : ((struct (US2 * obj * string) []) -> unit), v230 : (unit -> (struct (System.Guid * obj) [])), v231 : ((struct (System.Guid * obj) []) -> unit), v232 : (unit -> (struct (System.Guid * obj) [])), v233 : ((struct (System.Guid * obj) []) -> unit), v234 : (unit -> (struct (System.Guid * int32) [])), v235 : ((struct (System.Guid * int32) []) -> unit), v236 : (unit -> US4), v237 : (US4 -> unit), v238 : (unit -> US5), v239 : (US5 -> unit)) = v217.Invoke v216 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v335 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v336 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v337 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v338 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v339 : (unit -> int32), v340 : (int32 -> unit), v341 : (unit -> string), v342 : (string -> unit), v343 : (unit -> string), v344 : (string -> unit), v345 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v346 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v347 : (unit -> (struct (US2 * obj * string) [])), v348 : ((struct (US2 * obj * string) []) -> unit), v349 : (unit -> (struct (System.Guid * obj) [])), v350 : ((struct (System.Guid * obj) []) -> unit), v351 : (unit -> (struct (System.Guid * obj) [])), v352 : ((struct (System.Guid * obj) []) -> unit), v353 : (unit -> (struct (System.Guid * int32) [])), v354 : ((struct (System.Guid * int32) []) -> unit), v355 : (unit -> US4), v356 : (US4 -> unit), v357 : (unit -> US5), v358 : (US5 -> unit)) = v336.Invoke v335 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v359 : (Mut1 -> Fable.Core.JSX.Element) = closure7()
    let v360 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v361 : (unit -> (Fable.Core.JSX.Element [])) = closure192(v104, v103, v225, v224, v340, v339)
    method22(v359, v360, v361)
and closure191 () (v0 : Mut1) : Fable.Core.JSX.Element =
    method51()
and closure210 () () : (Fable.Core.JSX.Element []) =
    [||]
and closure190 () () : (Fable.Core.JSX.Element []) =
    let v0 : (Mut1 -> Fable.Core.JSX.Element) = closure191()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (Fable.Core.JSX.Element [])) = closure210()
    let v3 : Fable.Core.JSX.Element = method22(v0, v1, v2)
    [|v3|]
and closure189 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "Connection"
    let v71 : Fable.Core.JSX.Element = v70 |> unbox<Fable.Core.JSX.Element>
    let v72 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v71 ]
    let v73 : (unit -> (Fable.Core.JSX.Element [])) = closure190()
    let v74 : US9 = US9_1(v73)
    let v75 : US11 = US11_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure222 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : US6 =
    let v8 : string = v2 ()
    US6_1(v8)
and closure223 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) (v8 : US6) : unit =
    let v12 : string =
        match v8 with
        | US6_0 -> (* None *)
            let v10 : string = ""
            v10
        | US6_1(v9) -> (* Some *)
            v9
    v3 v12
and closure221 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : (Fable.Core.JSX.Element []) =
    let v8 : (Mut17 -> Fable.Core.JSX.Element) = closure195()
    let v9 : (unit -> US6) = closure222(v0, v1, v2, v3, v4, v5, v6, v7)
    let v10 : (US6 -> unit) = closure223(v0, v1, v2, v3, v4, v5, v6, v7)
    let v11 : Fable.Core.JSX.Element = method53(v8, v9, v10)
    [|v11|]
and closure220 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) struct (v8 : US6, v9 : US6, v10 : US6, v11 : US7, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US6, v17 : US6, v18 : US8, v19 : US9, v20 : US6, v21 : US6, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US10, v27 : US8, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US11, v35 : US6, v36 : US6, v37 : US6, v38 : US11, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US12, v50 : US13, v51 : US12, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US14, v69 : US6, v70 : US11, v71 : US6, v72 : US6, v73 : US14, v74 : US14, v75 : US6, v76 : US5, v77 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v78 : string = "Address"
    let v79 : Fable.Core.JSX.Element = v78 |> unbox<Fable.Core.JSX.Element>
    let v80 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v79 ]
    let v81 : (unit -> (Fable.Core.JSX.Element [])) = closure221(v0, v1, v2, v3, v4, v5, v6, v7)
    let v82 : US9 = US9_1(v81)
    let v83 : string = "3px"
    let v84 : US6 = US6_1(v83)
    let v85 : US11 = US11_1(v80)
    struct (v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v82, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v84, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v85, v71, v72, v73, v74, v75, v76, v77)
and closure226 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : US6 =
    let v8 : string = v6 ()
    US6_1(v8)
and closure227 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) (v8 : US6) : unit =
    let v12 : string =
        match v8 with
        | US6_0 -> (* None *)
            let v10 : string = ""
            v10
        | US6_1(v9) -> (* Some *)
            v9
    v7 v12
and closure225 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : (Fable.Core.JSX.Element []) =
    let v8 : (Mut17 -> Fable.Core.JSX.Element) = closure195()
    let v9 : (unit -> US6) = closure226(v0, v1, v2, v3, v4, v5, v6, v7)
    let v10 : (US6 -> unit) = closure227(v0, v1, v2, v3, v4, v5, v6, v7)
    let v11 : Fable.Core.JSX.Element = method53(v8, v9, v10)
    [|v11|]
and closure224 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) struct (v8 : US6, v9 : US6, v10 : US6, v11 : US7, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US6, v17 : US6, v18 : US8, v19 : US9, v20 : US6, v21 : US6, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US10, v27 : US8, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US11, v35 : US6, v36 : US6, v37 : US6, v38 : US11, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US12, v50 : US13, v51 : US12, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US14, v69 : US6, v70 : US11, v71 : US6, v72 : US6, v73 : US14, v74 : US14, v75 : US6, v76 : US5, v77 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v78 : string = "Private Key"
    let v79 : Fable.Core.JSX.Element = v78 |> unbox<Fable.Core.JSX.Element>
    let v80 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v79 ]
    let v81 : (unit -> (Fable.Core.JSX.Element [])) = closure225(v0, v1, v2, v3, v4, v5, v6, v7)
    let v82 : US9 = US9_1(v81)
    let v83 : string = "3px"
    let v84 : US6 = US6_1(v83)
    let v85 : US11 = US11_1(v80)
    struct (v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v82, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v84, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v85, v71, v72, v73, v74, v75, v76, v77)
and closure219 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : (Fable.Core.JSX.Element []) =
    let v8 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v9 : US13 = US13_0
    let v10 : US13 = US13_0
    let v11 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure220(v0, v1, v2, v3, v4, v5, v6, v7)
    let v12 : US15 = US15_2
    let v13 : Fable.Core.JSX.Element = method26(v8, v9, v10, v11, v12)
    let v14 : US13 = US13_0
    let v15 : US13 = US13_0
    let v16 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure224(v0, v1, v2, v3, v4, v5, v6, v7)
    let v17 : US15 = US15_2
    let v18 : Fable.Core.JSX.Element = method26(v8, v14, v15, v16, v17)
    [|v13; v18|]
and closure218 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : (Fable.Core.JSX.Element []) =
    let v8 : (Mut1 -> Fable.Core.JSX.Element) = closure7()
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v10 : (unit -> (Fable.Core.JSX.Element [])) = closure219(v0, v1, v2, v3, v4, v5, v6, v7)
    let v11 : Fable.Core.JSX.Element = method22(v8, v9, v10)
    [|v11|]
and closure217 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) struct (v8 : US6, v9 : US6, v10 : US6, v11 : US7, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US6, v17 : US6, v18 : US8, v19 : US9, v20 : US6, v21 : US6, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US10, v27 : US8, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US11, v35 : US6, v36 : US6, v37 : US6, v38 : US11, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US12, v50 : US13, v51 : US12, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US14, v69 : US6, v70 : US11, v71 : US6, v72 : US6, v73 : US14, v74 : US14, v75 : US6, v76 : US5, v77 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v78 : US0 = v0 ()
    let v86 : string =
        match v78 with
        | US0_0 -> (* Admin *)
            let v79 : string = "admin"
            v79
        | US0_1(v80) -> (* Player *)
            match v80 with
            | US1_0 -> (* O *)
                let v82 : string = "o"
                v82
            | US1_1 -> (* X *)
                let v81 : string = "x"
                v81
    let v87 : Fable.Core.JSX.Element = v86 |> unbox<Fable.Core.JSX.Element>
    let v88 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v87 ]
    let v89 : (unit -> (Fable.Core.JSX.Element [])) = closure218(v0, v1, v2, v3, v4, v5, v6, v7)
    let v90 : US9 = US9_1(v89)
    let v91 : US11 = US11_1(v88)
    struct (v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v90, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v91, v71, v72, v73, v74, v75, v76, v77)
and closure216 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) (v8 : (unit -> int32)) : (Fable.Core.JSX.Element []) =
    let v9 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v10 : US13 = US13_0
    let v11 : US13 = US13_0
    let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure217(v0, v1, v2, v3, v4, v5, v6, v7)
    let v13 : US15 = US15_2
    let v14 : Fable.Core.JSX.Element = method26(v9, v10, v11, v12, v13)
    [|v14|]
and closure215 () struct (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) : ((unit -> int32) -> (Fable.Core.JSX.Element [])) =
    closure216(v0, v1, v2, v3, v4, v5, v6, v7)
and closure228 (v0 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (obj []) = v0 |> unbox<(obj [])>
    let v72 : US10 = US10_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v72, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure214 (v0 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []))) () : (Fable.Core.JSX.Element []) =
    let v1 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) = v0 ()
    let v2 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) -> ((unit -> int32) -> (Fable.Core.JSX.Element []))) = closure215()
    let v3 : (unit -> (Fable.Core.JSX.Element [])) = Fable.Core.JsInterop.emitJsExpr () $"(item: any, index: () => number) => {v2}(item)(index)"
    let v4 : string = "For"
    let v5 : string = "solid-js"
    let v6 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v4 v5
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure228(v1)
    let v8 : Fable.Core.JSX.Element = method5(v6, v7, v3)
    [|v8|]
and method56 () : Fable.Core.JSX.Element =
    let v95 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v96 : string = "useContext"
    let v97 : string = "solid-js"
    let v98 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v99 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v100 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v101 : (unit -> int32), v102 : (int32 -> unit), v103 : (unit -> string), v104 : (string -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v108 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v109 : (unit -> (struct (US2 * obj * string) [])), v110 : ((struct (US2 * obj * string) []) -> unit), v111 : (unit -> (struct (System.Guid * obj) [])), v112 : ((struct (System.Guid * obj) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * int32) [])), v116 : ((struct (System.Guid * int32) []) -> unit), v117 : (unit -> US4), v118 : (US4 -> unit), v119 : (unit -> US5), v120 : (US5 -> unit)) = v98.Invoke v95 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v121 : (Mut1 -> Fable.Core.JSX.Element) = closure7()
    let v122 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v123 : (unit -> (Fable.Core.JSX.Element [])) = closure214(v99)
    method22(v121, v122, v123)
and closure213 () (v0 : Mut1) : Fable.Core.JSX.Element =
    method56()
and closure229 () () : (Fable.Core.JSX.Element []) =
    [||]
and closure212 () () : (Fable.Core.JSX.Element []) =
    let v0 : (Mut1 -> Fable.Core.JSX.Element) = closure213()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (Fable.Core.JSX.Element [])) = closure229()
    let v3 : Fable.Core.JSX.Element = method22(v0, v1, v2)
    [|v3|]
and closure211 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "Accounts"
    let v71 : Fable.Core.JSX.Element = v70 |> unbox<Fable.Core.JSX.Element>
    let v72 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v71 ]
    let v73 : (unit -> (Fable.Core.JSX.Element [])) = closure212()
    let v74 : US9 = US9_1(v73)
    let v75 : US11 = US11_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure232 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "algorand testnet bank"
    let v71 : Fable.Core.JSX.Element = v70 |> unbox<Fable.Core.JSX.Element>
    let v72 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v71 ]
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
and closure233 () () : (Fable.Core.JSX.Element []) =
    [||]
and closure231 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/core"
    let v2 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v0 v1
    let v3 : obj = v2
    let v4 : string = "iframe"
    let v5 : obj = (Fable.Core.JsInterop.(?)) v3 v4
    let v6 : Fable.Core.JS.Function = v5 |> unbox<Fable.Core.JS.Function>
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure232()
    let v8 : (unit -> (Fable.Core.JSX.Element [])) = closure233()
    let v9 : Fable.Core.JSX.Element = method5(v6, v7, v8)
    [|v9|]
and closure230 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "Testnet Bank Dispenser"
    let v71 : Fable.Core.JSX.Element = v70 |> unbox<Fable.Core.JSX.Element>
    let v72 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v71 ]
    let v73 : (unit -> (Fable.Core.JSX.Element [])) = closure231()
    let v74 : US9 = US9_1(v73)
    let v75 : US11 = US11_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure188 () () : (Fable.Core.JSX.Element []) =
    let v0 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v1 : US13 = US13_0
    let v2 : US13 = US13_0
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure189()
    let v4 : US15 = US15_2
    let v5 : Fable.Core.JSX.Element = method26(v0, v1, v2, v3, v4)
    let v6 : US13 = US13_0
    let v7 : US13 = US13_0
    let v8 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure211()
    let v9 : US15 = US15_2
    let v10 : Fable.Core.JSX.Element = method26(v0, v6, v7, v8, v9)
    let v11 : US13 = US13_0
    let v12 : US13 = US13_0
    let v13 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure230()
    let v14 : US15 = US15_0
    let v15 : Fable.Core.JSX.Element = method26(v0, v11, v12, v13, v14)
    [|v5; v10; v15|]
and method50 () : Fable.Core.JSX.Element =
    let v0 : (Mut1 -> Fable.Core.JSX.Element) = closure7()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (Fable.Core.JSX.Element [])) = closure188()
    method22(v0, v1, v2)
and closure187 () (v0 : Mut1) : Fable.Core.JSX.Element =
    method50()
and closure234 () () : (Fable.Core.JSX.Element []) =
    [||]
and closure186 () () : (Fable.Core.JSX.Element []) =
    let v0 : (Mut1 -> Fable.Core.JSX.Element) = closure187()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (Fable.Core.JSX.Element [])) = closure234()
    let v3 : Fable.Core.JSX.Element = method22(v0, v1, v2)
    [|v3|]
and closure185 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "Chain"
    let v71 : Fable.Core.JSX.Element = v70 |> unbox<Fable.Core.JSX.Element>
    let v72 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v71 ]
    let v73 : (unit -> (Fable.Core.JSX.Element [])) = closure186()
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
        let v23 : US6 =
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
                    v19 struct (v12, v13, v14, v15, v16)
                else
                    US6_0
            | _ ->
                v11
        let v24 : int32 = v7 + 1
        v5.l0 <- v24
        v5.l1 <- v23
        ()
    let v25 : US6 = v5.l1
    v25
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
                v18 v3
            else
                struct (v10, v11, v12, v13, v14)
        v6.[int v9] <- struct (v24, v25, v26, v27, v28)
        let v29 : int32 = v9 + 1
        v7.l0 <- v29
        ()
    v1 v6
and method60 (v0 : Mut20) : Fable.Core.JSX.Element =
    let v96 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v97 : string = "useContext"
    let v98 : string = "solid-js"
    let v99 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v97 v98
    let struct (v100 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v101 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v102 : (unit -> int32), v103 : (int32 -> unit), v104 : (unit -> string), v105 : (string -> unit), v106 : (unit -> string), v107 : (string -> unit), v108 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v109 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v110 : (unit -> (struct (US2 * obj * string) [])), v111 : ((struct (US2 * obj * string) []) -> unit), v112 : (unit -> (struct (System.Guid * obj) [])), v113 : ((struct (System.Guid * obj) []) -> unit), v114 : (unit -> (struct (System.Guid * obj) [])), v115 : ((struct (System.Guid * obj) []) -> unit), v116 : (unit -> (struct (System.Guid * int32) [])), v117 : ((struct (System.Guid * int32) []) -> unit), v118 : (unit -> US4), v119 : (US4 -> unit), v120 : (unit -> US5), v121 : (US5 -> unit)) = v99.Invoke v96 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v122 : (Mut17 -> Fable.Core.JSX.Element) = closure195()
    let v123 : (unit -> US6) = closure248(v0, v108)
    let v124 : (US6 -> unit) = closure249(v0, v109, v108)
    method53(v122, v123, v124)
and closure247 () (v0 : Mut20) : Fable.Core.JSX.Element =
    method60(v0)
and closure250 () struct (v0 : (US2 []), v1 : int32, v2 : US3, v3 : string, v4 : string) : US6 =
    US6_1(v3)
and closure252 (v0 : Mut19, v1 : (US2 []), v2 : int32, v3 : US3, v4 : string, v5 : string) (v6 : US6) : struct ((US2 []) * int32 * US3 * string * string) =
    let v7 : US3 = v0.l0
    let v11 : string =
        match v6 with
        | US6_0 -> (* None *)
            let v9 : string = ""
            v9
        | US6_1(v8) -> (* Some *)
            v8
    struct (v1, v2, v7, v11, v5)
and closure251 (v0 : Mut19) struct (v1 : (US2 []), v2 : int32, v3 : US3, v4 : string, v5 : string) : (US6 -> struct ((US2 []) * int32 * US3 * string * string)) =
    closure252(v0, v1, v2, v3, v4, v5)
and method62 (v0 : (Mut20 -> Fable.Core.JSX.Element), v1 : (struct ((US2 []) * int32 * US3 * string * string) -> US6), v2 : US3, v3 : (struct ((US2 []) * int32 * US3 * string * string) -> (US6 -> struct ((US2 []) * int32 * US3 * string * string)))) : Fable.Core.JSX.Element =
    let v4 : Mut20 = {l0 = v1; l1 = v2; l2 = v3} : Mut20
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v5 v6
    let v8 : Fable.Core.JSX.Element = v7.Invoke (v0, v4) |> unbox<Fable.Core.JSX.Element>
    v8
and closure246 (v0 : Mut19) () : (Fable.Core.JSX.Element []) =
    let v1 : (Mut20 -> Fable.Core.JSX.Element) = closure247()
    let v2 : US3 = v0.l0
    let v3 : (struct ((US2 []) * int32 * US3 * string * string) -> US6) = closure250()
    let v4 : (struct ((US2 []) * int32 * US3 * string * string) -> (US6 -> struct ((US2 []) * int32 * US3 * string * string))) = closure251(v0)
    let v5 : Fable.Core.JSX.Element = method62(v1, v3, v2, v4)
    [|v5|]
and closure245 (v0 : Mut19) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : string = "URL"
    let v72 : Fable.Core.JSX.Element = v71 |> unbox<Fable.Core.JSX.Element>
    let v73 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v72 ]
    let v74 : (unit -> (Fable.Core.JSX.Element [])) = closure246(v0)
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
        let v23 : US5 =
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
                    v19 struct (v12, v13, v14, v15, v16)
                else
                    US5_0
            | _ ->
                v11
        let v24 : int32 = v7 + 1
        v5.l0 <- v24
        v5.l1 <- v23
        ()
    let v25 : US5 = v5.l1
    v25
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
                v18 v3
            else
                struct (v10, v11, v12, v13, v14)
        v6.[int v9] <- struct (v24, v25, v26, v27, v28)
        let v29 : int32 = v9 + 1
        v7.l0 <- v29
        ()
    v1 v6
and method63 (v0 : Mut22) : Fable.Core.JSX.Element =
    let v96 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v97 : string = "useContext"
    let v98 : string = "solid-js"
    let v99 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v97 v98
    let struct (v100 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v101 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v102 : (unit -> int32), v103 : (int32 -> unit), v104 : (unit -> string), v105 : (string -> unit), v106 : (unit -> string), v107 : (string -> unit), v108 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v109 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v110 : (unit -> (struct (US2 * obj * string) [])), v111 : ((struct (US2 * obj * string) []) -> unit), v112 : (unit -> (struct (System.Guid * obj) [])), v113 : ((struct (System.Guid * obj) []) -> unit), v114 : (unit -> (struct (System.Guid * obj) [])), v115 : ((struct (System.Guid * obj) []) -> unit), v116 : (unit -> (struct (System.Guid * int32) [])), v117 : ((struct (System.Guid * int32) []) -> unit), v118 : (unit -> US4), v119 : (US4 -> unit), v120 : (unit -> US5), v121 : (US5 -> unit)) = v99.Invoke v96 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v122 : (Mut18 -> Fable.Core.JSX.Element) = closure205()
    let v123 : (unit -> US5) = closure256(v0, v108)
    let v124 : (US5 -> unit) = closure257(v0, v109, v108)
    method55(v122, v123, v124)
and closure255 () (v0 : Mut22) : Fable.Core.JSX.Element =
    method63(v0)
and closure258 () struct (v0 : (US2 []), v1 : int32, v2 : US3, v3 : string, v4 : string) : US5 =
    US5_1(v1)
and closure260 (v0 : Mut19, v1 : (US2 []), v2 : int32, v3 : US3, v4 : string, v5 : string) (v6 : US5) : struct ((US2 []) * int32 * US3 * string * string) =
    let v7 : US3 = v0.l0
    let v10 : int32 =
        match v6 with
        | US5_0 -> (* None *)
            0
        | US5_1(v8) -> (* Some *)
            v8
    struct (v1, v10, v7, v4, v5)
and closure259 (v0 : Mut19) struct (v1 : (US2 []), v2 : int32, v3 : US3, v4 : string, v5 : string) : (US5 -> struct ((US2 []) * int32 * US3 * string * string)) =
    closure260(v0, v1, v2, v3, v4, v5)
and method65 (v0 : (Mut22 -> Fable.Core.JSX.Element), v1 : (struct ((US2 []) * int32 * US3 * string * string) -> US5), v2 : US3, v3 : (struct ((US2 []) * int32 * US3 * string * string) -> (US5 -> struct ((US2 []) * int32 * US3 * string * string)))) : Fable.Core.JSX.Element =
    let v4 : Mut22 = {l0 = v1; l1 = v2; l2 = v3} : Mut22
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v5 v6
    let v8 : Fable.Core.JSX.Element = v7.Invoke (v0, v4) |> unbox<Fable.Core.JSX.Element>
    v8
and closure254 (v0 : Mut19) () : (Fable.Core.JSX.Element []) =
    let v1 : (Mut22 -> Fable.Core.JSX.Element) = closure255()
    let v2 : US3 = v0.l0
    let v3 : (struct ((US2 []) * int32 * US3 * string * string) -> US5) = closure258()
    let v4 : (struct ((US2 []) * int32 * US3 * string * string) -> (US5 -> struct ((US2 []) * int32 * US3 * string * string))) = closure259(v0)
    let v5 : Fable.Core.JSX.Element = method65(v1, v3, v2, v4)
    [|v5|]
and closure253 (v0 : Mut19) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : string = "Port"
    let v72 : Fable.Core.JSX.Element = v71 |> unbox<Fable.Core.JSX.Element>
    let v73 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v72 ]
    let v74 : (unit -> (Fable.Core.JSX.Element [])) = closure254(v0)
    let v75 : US9 = US9_1(v74)
    let v76 : string = "3px"
    let v77 : US6 = US6_1(v76)
    let v78 : US11 = US11_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v75, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v77, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v78, v64, v65, v66, v67, v68, v69, v70)
and closure244 (v0 : Mut19) () : (Fable.Core.JSX.Element []) =
    let v1 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v2 : US13 = US13_0
    let v3 : US13 = US13_0
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure245(v0)
    let v5 : US15 = US15_2
    let v6 : Fable.Core.JSX.Element = method26(v1, v2, v3, v4, v5)
    let v7 : US13 = US13_0
    let v8 : US13 = US13_0
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure253(v0)
    let v10 : US15 = US15_2
    let v11 : Fable.Core.JSX.Element = method26(v1, v7, v8, v9, v10)
    [|v6; v11|]
and method59 (v0 : Mut19) : Fable.Core.JSX.Element =
    let v1 : (Mut1 -> Fable.Core.JSX.Element) = closure7()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v3 : (unit -> (Fable.Core.JSX.Element [])) = closure244(v0)
    method22(v1, v2, v3)
and closure243 () (v0 : Mut19) : Fable.Core.JSX.Element =
    method59(v0)
and method66 (v0 : (Mut19 -> Fable.Core.JSX.Element), v1 : US3) : Fable.Core.JSX.Element =
    let v2 : Mut19 = {l0 = v1} : Mut19
    let v3 : string = "createComponent"
    let v4 : string = "solid-js"
    let v5 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v3 v4
    let v6 : Fable.Core.JSX.Element = v5.Invoke (v0, v2) |> unbox<Fable.Core.JSX.Element>
    v6
and closure242 (v0 : Mut19) () : (Fable.Core.JSX.Element []) =
    let v1 : (Mut19 -> Fable.Core.JSX.Element) = closure243()
    let v2 : US3 = v0.l0
    let v3 : Fable.Core.JSX.Element = method66(v1, v2)
    [|v3|]
and closure241 (v0 : Mut19) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : US3 = v0.l0
    let v77 : string =
        match v71 with
        | US3_0 -> (* GunJsServer *)
            let v74 : string = "Gun JavaScript"
            v74
        | US3_1 -> (* GunRsServer *)
            let v73 : string = "Gun Rust"
            v73
        | US3_2 -> (* SignalRServer *)
            let v72 : string = "SignalR"
            v72
    let v78 : Fable.Core.JSX.Element = v77 |> unbox<Fable.Core.JSX.Element>
    let v79 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v78 ]
    let v80 : (unit -> (Fable.Core.JSX.Element [])) = closure242(v0)
    let v81 : US9 = US9_1(v80)
    let v82 : US6 = US6_0
    let v83 : US11 = US11_1(v79)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v81, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v82, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v83, v64, v65, v66, v67, v68, v69, v70)
and closure266 (v0 : Mut24) () : (obj []) =
    let v1 : US3 = v0.l1
    let v7 : string =
        match v1 with
        | US3_0 -> (* GunJsServer *)
            let v4 : string = "Gun JavaScript"
            v4
        | US3_1 -> (* GunRsServer *)
            let v3 : string = "Gun Rust"
            v3
        | US3_2 -> (* SignalRServer *)
            let v2 : string = "SignalR"
            v2
    let v8 : string = "props.ServerType"
    let v9 : obj = struct (v8, v7)
    let v10 : US2 = v0.l0
    let v18 : string =
        match v10 with
        | US2_0 -> (* GunJsClient *)
            let v13 : string = "Gun JavaScript"
            v13
        | US2_1 -> (* GunRsClient *)
            let v12 : string = "Gun Rust"
            v12
        | US2_2 -> (* Memory *)
            let v14 : string = "Memory"
            v14
        | US2_3 -> (* SignalRClient *)
            let v11 : string = "SignalR"
            v11
    let v19 : string = "props.ClientType"
    let v20 : obj = struct (v19, v18)
    [|v9; v20|]
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
and closure270 (v0 : Mut24) () : (Fable.Core.JSX.Element []) =
    let v1 : US2 = v0.l0
    let v9 : string =
        match v1 with
        | US2_0 -> (* GunJsClient *)
            let v4 : string = "Gun JavaScript"
            v4
        | US2_1 -> (* GunRsClient *)
            let v3 : string = "Gun Rust"
            v3
        | US2_2 -> (* Memory *)
            let v5 : string = "Memory"
            v5
        | US2_3 -> (* SignalRClient *)
            let v2 : string = "SignalR"
            v2
    let v10 : Fable.Core.JSX.Element = v9 |> unbox<Fable.Core.JSX.Element>
    let v11 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v10 ]
    [|v11|]
and closure269 (v0 : Mut24) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : US2 = v0.l0
    let v79 : string =
        match v71 with
        | US2_0 -> (* GunJsClient *)
            let v74 : string = "gunjs"
            v74
        | US2_1 -> (* GunRsClient *)
            let v73 : string = "gunrs"
            v73
        | US2_2 -> (* Memory *)
            let v75 : string = "mem"
            v75
        | US2_3 -> (* SignalRClient *)
            let v72 : string = "signalr"
            v72
    let v80 : US3 = v0.l1
    let v86 : string =
        match v80 with
        | US3_0 -> (* GunJsServer *)
            let v83 : string = "gunjs"
            v83
        | US3_1 -> (* GunRsServer *)
            let v82 : string = "gunrs"
            v82
        | US3_2 -> (* SignalRServer *)
            let v81 : string = "signalr"
            v81
    let v87 : string = $"db-{v79}-{v86}"
    let v88 : (unit -> (Fable.Core.JSX.Element [])) = closure270(v0)
    let v89 : US9 = US9_1(v88)
    let v90 : US6 = US6_1(v87)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v89, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v90, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and method68 (v0 : Mut24) : Fable.Core.JSX.Element =
    let v96 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v97 : string = "useContext"
    let v98 : string = "solid-js"
    let v99 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v97 v98
    let struct (v100 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v101 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v102 : (unit -> int32), v103 : (int32 -> unit), v104 : (unit -> string), v105 : (string -> unit), v106 : (unit -> string), v107 : (string -> unit), v108 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v109 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v110 : (unit -> (struct (US2 * obj * string) [])), v111 : ((struct (US2 * obj * string) []) -> unit), v112 : (unit -> (struct (System.Guid * obj) [])), v113 : ((struct (System.Guid * obj) []) -> unit), v114 : (unit -> (struct (System.Guid * obj) [])), v115 : ((struct (System.Guid * obj) []) -> unit), v116 : (unit -> (struct (System.Guid * int32) [])), v117 : ((struct (System.Guid * int32) []) -> unit), v118 : (unit -> US4), v119 : (US4 -> unit), v120 : (unit -> US5), v121 : (US5 -> unit)) = v99.Invoke v96 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v122 : (unit -> (obj [])) = closure266(v0)
    let v123 : string = "#666"
    let v124 : (US4 -> ((obj []) -> unit)) = method16(v122, v123)
    let v125 : US4 = US4_0
    let v126 : ((obj []) -> unit) = v124 v125
    let v127 : string = "> db_client ()"
    let v128 : obj = v127
    let v129 : (obj []) = [|v128|]
    v126 v129
    let v130 : (Mut4 -> Fable.Core.JSX.Element) = closure21()
    let v131 : (unit -> bool) = closure267(v0, v108)
    let v132 : (bool -> unit) = closure268(v0, v109, v108)
    let v133 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure269(v0)
    method14(v130, v131, v132, v133)
and closure265 () (v0 : Mut24) : Fable.Core.JSX.Element =
    method68(v0)
and method72 (v0 : (Mut24 -> Fable.Core.JSX.Element), v1 : US2, v2 : US3) : Fable.Core.JSX.Element =
    let v3 : Mut24 = {l0 = v1; l1 = v2} : Mut24
    let v4 : string = "createComponent"
    let v5 : string = "solid-js"
    let v6 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v4 v5
    let v7 : Fable.Core.JSX.Element = v6.Invoke (v0, v3) |> unbox<Fable.Core.JSX.Element>
    v7
and closure264 (v0 : Mut19) () : (Fable.Core.JSX.Element []) =
    let v1 : (Mut24 -> Fable.Core.JSX.Element) = closure265()
    let v2 : US3 = v0.l0
    let v3 : US2 = US2_3
    let v4 : Fable.Core.JSX.Element = method72(v1, v3, v2)
    [|v4|]
and closure263 (v0 : Mut19) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : string = "Clients"
    let v72 : Fable.Core.JSX.Element = v71 |> unbox<Fable.Core.JSX.Element>
    let v73 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v72 ]
    let v74 : (unit -> (Fable.Core.JSX.Element [])) = closure264(v0)
    let v75 : US9 = US9_1(v74)
    let v76 : US6 = US6_0
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US11 = US11_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v75, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v76, v29, v30, v31, v32, v33, v34, v78, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v79, v64, v65, v66, v67, v68, v69, v70)
and method67 (v0 : Mut19) : Fable.Core.JSX.Element =
    let v1 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v2 : US13 = US13_0
    let v3 : US13 = US13_0
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure263(v0)
    let v5 : US15 = US15_2
    method26(v1, v2, v3, v4, v5)
and closure262 () (v0 : Mut19) : Fable.Core.JSX.Element =
    method67(v0)
and closure261 (v0 : Mut19) () : (Fable.Core.JSX.Element []) =
    let v1 : (Mut19 -> Fable.Core.JSX.Element) = closure262()
    let v2 : US3 = v0.l0
    let v3 : Fable.Core.JSX.Element = method66(v1, v2)
    [|v3|]
and closure240 (v0 : Mut19) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v72 : US13 = US13_0
    let v73 : US13 = US13_0
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure241(v0)
    let v75 : US15 = US15_2
    let v76 : Fable.Core.JSX.Element = method26(v71, v72, v73, v74, v75)
    let v77 : (unit -> (Fable.Core.JSX.Element [])) = closure261(v0)
    let v78 : US9 = US9_1(v77)
    let v79 : US6 = US6_0
    let v80 : string = "0"
    let v81 : US6 = US6_1(v80)
    let v82 : US6 = US6_1(v80)
    let v83 : US6 = US6_1(v80)
    let v84 : US11 = US11_1(v76)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v78, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v79, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v81, v82, v52, v83, v54, v55, v56, v57, v58, v59, v60, v61, v62, v84, v64, v65, v66, v67, v68, v69, v70)
and method58 (v0 : Mut19) : Fable.Core.JSX.Element =
    let v1 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v2 : US13 = US13_0
    let v3 : US13 = US13_0
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure240(v0)
    let v5 : US15 = US15_2
    method26(v1, v2, v3, v4, v5)
and closure239 () (v0 : Mut19) : Fable.Core.JSX.Element =
    method58(v0)
and closure238 () () : (Fable.Core.JSX.Element []) =
    let v0 : (Mut19 -> Fable.Core.JSX.Element) = closure239()
    let v1 : US3 = US3_2
    let v2 : Fable.Core.JSX.Element = method66(v0, v1)
    [|v2|]
and method57 () : Fable.Core.JSX.Element =
    let v0 : (Mut1 -> Fable.Core.JSX.Element) = closure7()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (Fable.Core.JSX.Element [])) = closure238()
    method22(v0, v1, v2)
and closure237 () (v0 : Mut1) : Fable.Core.JSX.Element =
    method57()
and closure271 () () : (Fable.Core.JSX.Element []) =
    [||]
and closure236 () () : (Fable.Core.JSX.Element []) =
    let v0 : (Mut1 -> Fable.Core.JSX.Element) = closure237()
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v2 : (unit -> (Fable.Core.JSX.Element [])) = closure271()
    let v3 : Fable.Core.JSX.Element = method22(v0, v1, v2)
    [|v3|]
and closure235 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : string = "Database"
    let v71 : Fable.Core.JSX.Element = v70 |> unbox<Fable.Core.JSX.Element>
    let v72 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v71 ]
    let v73 : (unit -> (Fable.Core.JSX.Element [])) = closure236()
    let v74 : US9 = US9_1(v73)
    let v75 : string = "db-connections"
    let v76 : US6 = US6_1(v75)
    let v77 : US11 = US11_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v76, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v77, v63, v64, v65, v66, v67, v68, v69)
and closure276 (v0 : (unit -> (struct (System.Guid * int32) []))) () : (obj []) =
    let v1 : (struct (System.Guid * int32) []) = v0 ()
    let v2 : string = "profile_tmp_counter"
    let v3 : obj = struct (v2, v1)
    [|v3|]
and closure277 (v0 : (US4 -> ((obj []) -> unit))) () : unit =
    let v1 : US4 = US4_2
    let v2 : ((obj []) -> unit) = v0 v1
    let v3 : string = "> counter -> effect ()"
    let v4 : obj = v3
    let v5 : (obj []) = [|v4|]
    v2 v5
and closure278 (v0 : ((struct (System.Guid * int32) []) -> unit)) struct (v1 : (struct (System.Guid * int32) []), v2 : US2, v3 : System.Guid, v4 : int32) : unit =
    let v5 : (struct (System.Guid * int32) []) = [|struct (v3, v4)|]
    let v6 : int32 = v1.Length
    let v7 : int32 = v5.Length
    let v8 : int32 = v6 + v7
    let v9 : (struct (System.Guid * int32) []) = Array.zeroCreate<struct (System.Guid * int32)> (v8)
    let v10 : Mut6 = {l0 = 0} : Mut6
    while method21(v8, v10) do
        let v12 : int32 = v10.l0
        let v13 : bool = v12 < v6
        let struct (v19 : System.Guid, v20 : int32) =
            if v13 then
                let struct (v14 : System.Guid, v15 : int32) = v1.[int v12]
                struct (v14, v15)
            else
                let v16 : int32 = v12 - v6
                let struct (v17 : System.Guid, v18 : int32) = v5.[int v16]
                struct (v17, v18)
        v9.[int v12] <- struct (v19, v20)
        let v21 : int32 = v12 + 1
        v10.l0 <- v21
        ()
    v0 v9
and closure281 (v0 : (unit -> (struct (System.Guid * int32) [])), v1 : (int32 -> unit)) (v2 : (exn -> unit)) : unit =
    let v3 : (struct (System.Guid * int32) []) = v0 ()
    let v4 : int32 = v3.Length
    v1 v4
and closure280 (v0 : (unit -> (struct (System.Guid * int32) []))) (v1 : (int32 -> unit)) : ((exn -> unit) -> unit) =
    closure281(v0, v1)
and closure279 (v0 : (unit -> (struct (System.Guid * int32) []))) (v1 : obj) : Fable.Core.JS.Promise<int32> =
    let v2 : ((int32 -> unit) -> ((exn -> unit) -> unit)) = closure280(v0)
    let v3 : Fable.Core.JS.Promise<int32> = Promise.create v2
    v3
and method75 () : struct ((unit -> unit) * (unit -> unit)) =
    let v0 : string = "createSignal"
    let v1 : string = "solid-js"
    let v2 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v0 v1
    let v3 : (Fable.Core.JS.Function []) = v2.Invoke () |> unbox<Fable.Core.JS.Function[]>
    let v4 : (unit -> unit) = v3.[0] |> unbox<unit -> unit>
    let v5 : (unit -> unit) = v3.[1] |> unbox<unit -> unit>
    struct (v4, v5)
and method76 (v0 : US16) : struct ((unit -> US16) * (US16 -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (Fable.Core.JS.Function []) = v3.Invoke v0 |> unbox<Fable.Core.JS.Function[]>
    let v5 : (unit -> US16) = v4.[0] |> unbox<unit -> US16>
    let v6 : (US16 -> unit) = v4.[1] |> unbox<US16 -> unit>
    struct (v5, v6)
and method77 (v0 : (struct (US2 * Fable.Core.JS.Promise<US17> * string) [])) : struct ((unit -> (struct (US2 * Fable.Core.JS.Promise<US17> * string) [])) * ((struct (US2 * Fable.Core.JS.Promise<US17> * string) []) -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (Fable.Core.JS.Function []) = v3.Invoke v0 |> unbox<Fable.Core.JS.Function[]>
    let v5 : (unit -> (struct (US2 * Fable.Core.JS.Promise<US17> * string) [])) = v4.[0] |> unbox<unit -> (struct (US2 * Fable.Core.JS.Promise<US17> * string) [])>
    let v6 : ((struct (US2 * Fable.Core.JS.Promise<US17> * string) []) -> unit) = v4.[1] |> unbox<(struct (US2 * Fable.Core.JS.Promise<US17> * string) []) -> unit>
    struct (v5, v6)
and closure282 (v0 : string, v1 : (unit -> (struct (System.Guid * int32) [])), v2 : (unit -> (struct (US2 * obj * string) [])), v3 : (unit -> unit), v4 : (unit -> unit), v5 : (unit -> US16), v6 : (unit -> (struct (US2 * Fable.Core.JS.Promise<US17> * string) []))) () : (obj []) =
    let v7 : string = "content_address"
    let v8 : obj = struct (v7, v0)
    let v9 : (struct (System.Guid * int32) []) = v1 ()
    let v10 : string = "getter"
    let v11 : obj = struct (v10, v9)
    v3 ()
    let v12 : string = "events"
    let v13 : obj = v12
    v4 ()
    let v14 : string = "timers"
    let v15 : obj = v14
    let v16 : US16 = v5 ()
    let v17 : string = "value"
    let v18 : obj = struct (v17, v16)
    let v19 : (struct (US2 * Fable.Core.JS.Promise<US17> * string) []) = v6 ()
    let v20 : int32 = v19.Length
    let v21 : (struct (string * Fable.Core.JS.Promise<US17>) []) = Array.zeroCreate<struct (string * Fable.Core.JS.Promise<US17>)> (v20)
    let v22 : Mut6 = {l0 = 0} : Mut6
    while method21(v20, v22) do
        let v24 : int32 = v22.l0
        let struct (v25 : US2, v26 : Fable.Core.JS.Promise<US17>, v27 : string) = v19.[int v24]
        let v35 : string =
            match v25 with
            | US2_0 -> (* GunJsClient *)
                let v30 : string = "Gun JavaScript"
                v30
            | US2_1 -> (* GunRsClient *)
                let v29 : string = "Gun Rust"
                v29
            | US2_2 -> (* Memory *)
                let v31 : string = "Memory"
                v31
            | US2_3 -> (* SignalRClient *)
                let v28 : string = "SignalR"
                v28
        v21.[int v24] <- struct (v35, v26)
        let v36 : int32 = v24 + 1
        v22.l0 <- v36
        ()
    let v37 : string = "subscriptions"
    let v38 : obj = struct (v37, v21)
    let v39 : (struct (US2 * obj * string) []) = v2 ()
    let v40 : int32 = v39.Length
    let v41 : (string []) = Array.zeroCreate<string> (v40)
    let v42 : Mut6 = {l0 = 0} : Mut6
    while method21(v40, v42) do
        let v44 : int32 = v42.l0
        let struct (v45 : US2, v46 : obj, v47 : string) = v39.[int v44]
        let v55 : string =
            match v45 with
            | US2_0 -> (* GunJsClient *)
                let v50 : string = "Gun JavaScript"
                v50
            | US2_1 -> (* GunRsClient *)
                let v49 : string = "Gun Rust"
                v49
            | US2_2 -> (* Memory *)
                let v51 : string = "Memory"
                v51
            | US2_3 -> (* SignalRClient *)
                let v48 : string = "SignalR"
                v48
        v41.[int v44] <- v55
        let v56 : int32 = v44 + 1
        v42.l0 <- v56
        ()
    let v57 : string = "db_connections"
    let v58 : obj = struct (v57, v41)
    [|v8; v11; v13; v15; v18; v38; v58|]
and method78 (v0 : int32, v1 : Mut26) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure284 (v0 : string, v1 : US2) () : (obj []) =
    let v2 : string = "content_address"
    let v3 : obj = struct (v2, v0)
    let v11 : string =
        match v1 with
        | US2_0 -> (* GunJsClient *)
            let v6 : string = "Gun JavaScript"
            v6
        | US2_1 -> (* GunRsClient *)
            let v5 : string = "Gun Rust"
            v5
        | US2_2 -> (* Memory *)
            let v7 : string = "Memory"
            v7
        | US2_3 -> (* SignalRClient *)
            let v4 : string = "SignalR"
            v4
    let v12 : string = "client_type"
    let v13 : obj = struct (v12, v11)
    [|v3; v13|]
and closure287 () (v0 : System.Guid) : int64 =
    let v1 : string = (v0).ToString ()
    let v2 : int64 = int64 $"{v1.[0..7]}{v1.[9..12]}{v1.[14..17]}{v1.[19..20]}"
    v2
and closure288 (v0 : US2, v1 : string, v2 : int32) () : (obj []) =
    let v3 : string = "content_address"
    let v4 : obj = struct (v3, v1)
    let v12 : string =
        match v0 with
        | US2_0 -> (* GunJsClient *)
            let v7 : string = "Gun JavaScript"
            v7
        | US2_1 -> (* GunRsClient *)
            let v6 : string = "Gun Rust"
            v6
        | US2_2 -> (* Memory *)
            let v8 : string = "Memory"
            v8
        | US2_3 -> (* SignalRClient *)
            let v5 : string = "SignalR"
            v5
    let v13 : string = "client_type"
    let v14 : obj = struct (v13, v12)
    let v15 : string = "new_value"
    let v16 : obj = struct (v15, v2)
    [|v4; v14; v16|]
and method80 (v0 : int32, v1 : Mut27) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure289 (v0 : (US4 -> ((obj []) -> unit))) (v1 : UH1) : unit =
    let v2 : US4 = US4_2
    let v3 : ((obj []) -> unit) = v0 v2
    let v4 : string = "> db_put > response' ()"
    let v5 : obj = v4
    let v6 : string = Fable.Core.JS.JSON.stringify v1
    let v7 : string = "response'"
    let v8 : obj = struct (v7, v6)
    let v9 : (obj []) = [|v5; v8|]
    v3 v9
and method79 (v0 : string, v1 : (unit -> (struct (System.Guid * int32) [])), v2 : (struct ((struct (System.Guid * int32) []) * US2 * System.Guid * int32) -> unit), v3 : (unit -> US4), v4 : (US16 -> unit), v5 : (unit -> US16), v6 : (US4 -> ((obj []) -> unit)), v7 : US2, v8 : (struct (US2 * obj * string) []), v9 : int32, v10 : System.Guid) : unit =
    let v11 : US16 = v5 ()
    let v18 : bool =
        match v11 with
        | US16_0 -> (* None *)
            true
        | US16_1(v12, v13, v14) -> (* Some *)
            let v15 : (System.Guid -> int64) = closure287()
            let v16 : bool = v14 <> v9 && v15 v10 > v15 v13
            v16
    if v18 then
        let v19 : (struct (System.Guid * int32) []) = v1 ()
        let v20 : US4 = US4_2
        let v21 : ((obj []) -> unit) = v6 v20
        let v22 : string = "> use_fetch > on_value > set ()"
        let v23 : obj = v22
        let v24 : string = "old_value"
        let v25 : obj = struct (v24, v19)
        let v33 : string =
            match v7 with
            | US2_0 -> (* GunJsClient *)
                let v28 : string = "Gun JavaScript"
                v28
            | US2_1 -> (* GunRsClient *)
                let v27 : string = "Gun Rust"
                v27
            | US2_2 -> (* Memory *)
                let v29 : string = "Memory"
                v29
            | US2_3 -> (* SignalRClient *)
                let v26 : string = "SignalR"
                v26
        let v34 : string = "client_type"
        let v35 : obj = struct (v34, v33)
        let v36 : string = "new_guid'"
        let v37 : obj = struct (v36, v10)
        let v38 : string = "new_value_raw"
        let v39 : obj = struct (v38, v9)
        let v40 : (obj []) = [|v23; v25; v35; v37; v39|]
        v21 v40
        v2 struct (v19, v7, v10, v9)
        let v41 : US16 = US16_1(v7, v10, v9)
        v4 v41
        let v42 : int32 = v8.Length
        let v43 : Mut6 = {l0 = 0} : Mut6
        while method21(v42, v43) do
            let v45 : int32 = v43.l0
            let struct (v46 : US2, v47 : obj, v48 : string) = v8.[int v45]
            let v49 : bool =
                match v46, v7 with
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
            let v50 : bool = v49 <> true
            if v50 then
                let v51 : US4 = US4_2
                let v52 : ((obj []) -> unit) = v6 v51
                let v53 : string = "> use_fetch > on_value > set () > db_put"
                let v54 : obj = v53
                let v55 : obj = struct (v24, v19)
                let v63 : string =
                    match v7 with
                    | US2_0 -> (* GunJsClient *)
                        let v58 : string = "Gun JavaScript"
                        v58
                    | US2_1 -> (* GunRsClient *)
                        let v57 : string = "Gun Rust"
                        v57
                    | US2_2 -> (* Memory *)
                        let v59 : string = "Memory"
                        v59
                    | US2_3 -> (* SignalRClient *)
                        let v56 : string = "SignalR"
                        v56
                let v64 : obj = struct (v34, v63)
                let v65 : obj = struct (v36, v10)
                let v66 : obj = struct (v38, v9)
                let v74 : string =
                    match v46 with
                    | US2_0 -> (* GunJsClient *)
                        let v69 : string = "Gun JavaScript"
                        v69
                    | US2_1 -> (* GunRsClient *)
                        let v68 : string = "Gun Rust"
                        v68
                    | US2_2 -> (* Memory *)
                        let v70 : string = "Memory"
                        v70
                    | US2_3 -> (* SignalRClient *)
                        let v67 : string = "SignalR"
                        v67
                let v75 : string = "connection_client_type"
                let v76 : obj = struct (v75, v74)
                let v77 : (obj []) = [|v54; v55; v64; v65; v66; v76|]
                v52 v77
                let v78 : (unit -> (obj [])) = closure288(v46, v0, v9)
                let v79 : string = "#666"
                let v80 : (US4 -> ((obj []) -> unit)) = method17(v3, v78, v79)
                let v81 : US4 = US4_0
                let v82 : ((obj []) -> unit) = v80 v81
                let v83 : string = "> db_put ()"
                let v84 : obj = v83
                let v85 : (obj []) = [|v84|]
                v82 v85
                match v46 with
                | US2_0 -> (* GunJsClient *)
                    let v112 : (string []) = v0.Split [| '/' |]
                    let v113 : string = "get"
                    let v114 : obj = (Fable.Core.JsInterop.(?)) v47 v113
                    let v115 : (string -> obj) = v114 |> unbox<(string -> obj)>
                    let v116 : string = "tictactoe"
                    let v117 : obj = v115 v116
                    let v118 : int32 = v112.Length
                    let v119 : Mut27 = {l0 = 0; l1 = v117} : Mut27
                    while method80(v118, v119) do
                        let v121 : int32 = v119.l0
                        let v122 : obj = v119.l1
                        let v123 : string = v112.[int v121]
                        let v124 : obj = (Fable.Core.JsInterop.(?)) v122 v113
                        let v125 : (string -> obj) = v124 |> unbox<(string -> obj)>
                        let v126 : obj = v125 v123
                        let v127 : int32 = v121 + 1
                        v119.l0 <- v127
                        v119.l1 <- v126
                        ()
                    let v128 : obj = v119.l1
                    let v129 : string = "put"
                    let v130 : obj = (Fable.Core.JsInterop.(?)) v128 v129
                    let v131 : (int32 -> unit) = v130 |> unbox<(int32 -> unit)>
                    v131 v9
                | US2_1 -> (* GunRsClient *)
                    let v92 : (string []) = v0.Split [| '/' |]
                    let v93 : string = "get"
                    let v94 : obj = (Fable.Core.JsInterop.(?)) v47 v93
                    let v95 : (string -> obj) = v94 |> unbox<(string -> obj)>
                    let v96 : string = "tictactoe"
                    let v97 : obj = v95 v96
                    let v98 : int32 = v92.Length
                    let v99 : Mut27 = {l0 = 0; l1 = v97} : Mut27
                    while method80(v98, v99) do
                        let v101 : int32 = v99.l0
                        let v102 : obj = v99.l1
                        let v103 : string = v92.[int v101]
                        let v104 : obj = (Fable.Core.JsInterop.(?)) v102 v93
                        let v105 : (string -> obj) = v104 |> unbox<(string -> obj)>
                        let v106 : obj = v105 v103
                        let v107 : int32 = v101 + 1
                        v99.l0 <- v107
                        v99.l1 <- v106
                        ()
                    let v108 : obj = v99.l1
                    let v109 : string = "put"
                    let v110 : obj = (Fable.Core.JsInterop.(?)) v108 v109
                    let v111 : (int32 -> unit) = v110 |> unbox<(int32 -> unit)>
                    v111 v9
                | US2_2 -> (* Memory *)
                    failwith<unit> "db_on Memory"
                | US2_3 -> (* SignalRClient *)
                    let v86 : string = v9 |> unbox<string>
                    let v87 : Fable.SignalR.HubConnection<UH0, UH0, unit, UH1, UH1> = v47 |> unbox<Fable.SignalR.HubConnection<UH0, UH0, unit, UH1, UH1>>
                    let v88 : string = "alias"
                    let v89 : UH0 = UH0_3(v88, v0, v86)
                    let v90 : Fable.Core.JS.Promise<UH1> = v87.invokeAsPromise v89
                    let v91 : (UH1 -> unit) = closure289(v80)
                    v90 |> Promise.iter v91
                    ()
            let v132 : int32 = v45 + 1
            v43.l0 <- v132
            ()
        ()
and closure286 (v0 : string, v1 : (unit -> (struct (System.Guid * int32) [])), v2 : (struct ((struct (System.Guid * int32) []) * US2 * System.Guid * int32) -> unit), v3 : (unit -> US4), v4 : (US16 -> unit), v5 : (unit -> US16), v6 : (US4 -> ((obj []) -> unit)), v7 : US2, v8 : (struct (US2 * obj * string) []), v9 : (US4 -> ((obj []) -> unit)), v10 : System.Guid, v11 : int32) (v12 : obj) : unit =
    let v13 : US4 = US4_2
    let v14 : ((obj []) -> unit) = v9 v13
    let v15 : string = "> db_on > on_value ()"
    let v16 : obj = v15
    let v17 : string = "v"
    let v18 : obj = struct (v17, v10, v11)
    let v19 : string = "k"
    let v20 : obj = struct (v19, v12)
    let v21 : (obj []) = [|v16; v18; v20|]
    v14 v21
    method79(v0, v1, v2, v3, v4, v5, v6, v7, v8, v11, v10)
and closure285 (v0 : string, v1 : (unit -> (struct (System.Guid * int32) [])), v2 : (struct ((struct (System.Guid * int32) []) * US2 * System.Guid * int32) -> unit), v3 : (unit -> US4), v4 : (US16 -> unit), v5 : (unit -> US16), v6 : (US4 -> ((obj []) -> unit)), v7 : US2, v8 : (struct (US2 * obj * string) []), v9 : (US4 -> ((obj []) -> unit))) struct (v10 : System.Guid, v11 : int32) : (obj -> unit) =
    closure286(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure291 (v0 : (US4 -> ((obj []) -> unit))) (v1 : UH1) : unit =
    let v2 : US4 = US4_2
    let v3 : ((obj []) -> unit) = v0 v2
    let v4 : string = "> db_on > stream next ()"
    let v5 : obj = v4
    let v6 : string = "msg"
    let v7 : obj = struct (v6, v1)
    let v8 : (obj []) = [|v5; v7|]
    v3 v8
and closure292 (v0 : (US4 -> ((obj []) -> unit))) () : unit =
    let v1 : US4 = US4_2
    let v2 : ((obj []) -> unit) = v0 v1
    let v3 : string = "> db_on > stream complete ()"
    let v4 : obj = v3
    let v5 : (obj []) = [|v4|]
    v2 v5
and closure293 (v0 : (US4 -> ((obj []) -> unit))) (v1 : obj) : unit =
    let v2 : US4 = US4_2
    let v3 : ((obj []) -> unit) = v0 v2
    let v4 : string = "> db_on > stream err ()"
    let v5 : obj = v4
    let v6 : string = Fable.Core.JS.JSON.stringify v1
    let v7 : string = "err"
    let v8 : obj = struct (v7, v6)
    let v9 : (obj []) = [|v5; v8|]
    v3 v9
and closure290 (v0 : (US4 -> ((obj []) -> unit))) (v1 : Fable.SignalR.StreamResult<UH1>) : US17 =
    let v2 : (UH1 -> unit) = closure291(v0)
    let v3 : obj = v2
    let v4 : string = "next"
    let v5 : (string * obj) = v4, v3
    let v6 : (unit -> unit) = closure292(v0)
    let v7 : obj = v6
    let v8 : string = "complete"
    let v9 : (string * obj) = v8, v7
    let v10 : (obj -> unit) = closure293(v0)
    let v11 : obj = v10
    let v12 : string = "error"
    let v13 : (string * obj) = v12, v11
    let v14 : ((string * obj) []) = [|v5; v9; v13|]
    let v15 : obj = Fable.Core.JsInterop.createObj v14
    let v16 : Fable.SignalR.IStreamSubscriber<UH1> = v15 |> unbox<Fable.SignalR.IStreamSubscriber<UH1>>
    let v17 : System.IDisposable = v1.subscribe v16
    let v18 : US4 = US4_2
    let v19 : ((obj []) -> unit) = v0 v18
    let v20 : string = "> db_on > streamFrom subscribe ()"
    let v21 : obj = v20
    let v22 : string = Fable.Core.JS.JSON.stringify v1
    let v23 : string = "stream"
    let v24 : obj = struct (v23, v22)
    let v25 : string = "subscription (IDisposable)"
    let v26 : obj = struct (v25, v17)
    let v27 : (obj []) = [|v21; v24; v26|]
    v19 v27
    US17_0(v17)
and method81 (v0 : (struct (US2 * string) []), v1 : (struct (US2 * string) []), v2 : int32) : bool =
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
            method81(v0, v1, v12)
        else
            false
    else
        true
and closure283 (v0 : string, v1 : (unit -> US4), v2 : ((struct (US2 * Fable.Core.JS.Promise<US17> * string) []) -> unit), v3 : (unit -> (struct (US2 * Fable.Core.JS.Promise<US17> * string) [])), v4 : (US4 -> ((obj []) -> unit)), v5 : (unit -> (struct (System.Guid * int32) [])), v6 : (struct ((struct (System.Guid * int32) []) * US2 * System.Guid * int32) -> unit), v7 : (US16 -> unit), v8 : (unit -> US16)) (v9 : (struct (US2 * obj * string) [])) : unit =
    let v10 : (struct (US2 * Fable.Core.JS.Promise<US17> * string) []) = v3 ()
    let v11 : int32 = v9.Length
    let v12 : (struct (US2 * Fable.Core.JS.Promise<US17> * string) []) = Array.zeroCreate<struct (US2 * Fable.Core.JS.Promise<US17> * string)> (v11)
    let v13 : Mut6 = {l0 = 0} : Mut6
    while method21(v11, v13) do
        let v15 : int32 = v13.l0
        let struct (v16 : US2, v17 : obj, v18 : string) = v9.[int v15]
        let v19 : int32 = v10.Length
        let v20 : US18 = US18_0
        let v21 : Mut26 = {l0 = 0; l1 = v20} : Mut26
        while method78(v19, v21) do
            let v23 : int32 = v21.l0
            let v24 : int32 =  -v23
            let v25 : int32 = v24 + v19
            let v26 : int32 = v25 - 1
            let v27 : US18 = v21.l1
            let struct (v28 : US2, v29 : Fable.Core.JS.Promise<US17>, v30 : string) = v10.[int v26]
            let v37 : US18 =
                match v27 with
                | US18_0 -> (* None *)
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
                        US18_1(v28, v29, v30)
                    else
                        US18_0
                | _ ->
                    v27
            let v38 : int32 = v23 + 1
            v21.l0 <- v38
            v21.l1 <- v37
            ()
        let v39 : US18 = v21.l1
        let struct (v113 : US2, v114 : Fable.Core.JS.Promise<US17>, v115 : string) =
            match v39 with
            | US18_0 -> (* None *)
                let v43 : (unit -> (obj [])) = closure284(v0, v16)
                let v44 : string = "#666"
                let v45 : (US4 -> ((obj []) -> unit)) = method17(v1, v43, v44)
                let v46 : US4 = US4_0
                let v47 : ((obj []) -> unit) = v45 v46
                let v48 : string = "> db_on ()"
                let v49 : obj = v48
                let v50 : (obj []) = [|v49|]
                v47 v50
                let v51 : (struct (System.Guid * int32) -> (obj -> unit)) = closure285(v0, v5, v6, v1, v7, v8, v4, v16, v9, v45)
                let v52 : (struct (obj * int32) -> unit) = Fable.Core.JsInterop.emitJsExpr () $"(v: any, k: any) => {v51}(v)(k)"
                let v109 : Fable.Core.JS.Promise<US17> =
                    match v16 with
                    | US2_0 -> (* GunJsClient *)
                        let v82 : (string []) = v0.Split [| '/' |]
                        let v83 : string = "get"
                        let v84 : obj = (Fable.Core.JsInterop.(?)) v17 v83
                        let v85 : (string -> obj) = v84 |> unbox<(string -> obj)>
                        let v86 : string = "tictactoe"
                        let v87 : obj = v85 v86
                        let v88 : int32 = v82.Length
                        let v89 : Mut27 = {l0 = 0; l1 = v87} : Mut27
                        while method80(v88, v89) do
                            let v91 : int32 = v89.l0
                            let v92 : obj = v89.l1
                            let v93 : string = v82.[int v91]
                            let v94 : obj = (Fable.Core.JsInterop.(?)) v92 v83
                            let v95 : (string -> obj) = v94 |> unbox<(string -> obj)>
                            let v96 : obj = v95 v93
                            let v97 : int32 = v91 + 1
                            v89.l0 <- v97
                            v89.l1 <- v96
                            ()
                        let v98 : obj = v89.l1
                        let v99 : string = "on"
                        let v100 : obj = (Fable.Core.JsInterop.(?)) v98 v99
                        let v101 : ((struct (obj * int32) -> unit) -> unit) = v100 |> unbox<((struct (obj * int32) -> unit) -> unit)>
                        v101 v52
                        let v102 : int64 = System.DateTime.UtcNow.Ticks
                        let v103 : US17 = US17_1(v102)
                        let v104 : Fable.Core.JS.Promise<US17> = Promise.lift v103
                        v104
                    | US2_1 -> (* GunRsClient *)
                        let v59 : (string []) = v0.Split [| '/' |]
                        let v60 : string = "get"
                        let v61 : obj = (Fable.Core.JsInterop.(?)) v17 v60
                        let v62 : (string -> obj) = v61 |> unbox<(string -> obj)>
                        let v63 : string = "tictactoe"
                        let v64 : obj = v62 v63
                        let v65 : int32 = v59.Length
                        let v66 : Mut27 = {l0 = 0; l1 = v64} : Mut27
                        while method80(v65, v66) do
                            let v68 : int32 = v66.l0
                            let v69 : obj = v66.l1
                            let v70 : string = v59.[int v68]
                            let v71 : obj = (Fable.Core.JsInterop.(?)) v69 v60
                            let v72 : (string -> obj) = v71 |> unbox<(string -> obj)>
                            let v73 : obj = v72 v70
                            let v74 : int32 = v68 + 1
                            v66.l0 <- v74
                            v66.l1 <- v73
                            ()
                        let v75 : obj = v66.l1
                        let v76 : string = "on"
                        let v77 : obj = (Fable.Core.JsInterop.(?)) v75 v76
                        let v78 : ((struct (obj * int32) -> unit) -> int64) = v77 |> unbox<((struct (obj * int32) -> unit) -> int64)>
                        let v79 : int64 = v78 v52
                        let v80 : US17 = US17_1(v79)
                        let v81 : Fable.Core.JS.Promise<US17> = Promise.lift v80
                        v81
                    | US2_2 -> (* Memory *)
                        failwith<Fable.Core.JS.Promise<US17>> "db_on Memory"
                    | US2_3 -> (* SignalRClient *)
                        let v53 : Fable.SignalR.HubConnection<UH0, UH0, unit, UH1, UH1> = v17 |> unbox<Fable.SignalR.HubConnection<UH0, UH0, unit, UH1, UH1>>
                        let v54 : string = "alias"
                        let v55 : UH0 = UH0_1(v54, v0)
                        let v56 : Fable.Core.JS.Promise<Fable.SignalR.StreamResult<UH1>> = v53.streamFromAsPromise v55
                        let v57 : (Fable.SignalR.StreamResult<UH1> -> US17) = closure290(v45)
                        let v58 : Fable.Core.JS.Promise<US17> = v56 |> Promise.map v57
                        v58
                struct (v16, v109, v18)
            | US18_1(v40, v41, v42) -> (* Some *)
                struct (v40, v41, v42)
        v12.[int v15] <- struct (v113, v114, v115)
        let v116 : int32 = v15 + 1
        v13.l0 <- v116
        ()
    let v117 : int32 = v10.Length
    let v118 : (struct (US2 * string) []) = Array.zeroCreate<struct (US2 * string)> (v117)
    let v119 : Mut6 = {l0 = 0} : Mut6
    while method21(v117, v119) do
        let v121 : int32 = v119.l0
        let struct (v122 : US2, v123 : Fable.Core.JS.Promise<US17>, v124 : string) = v10.[int v121]
        v118.[int v121] <- struct (v122, v124)
        let v125 : int32 = v121 + 1
        v119.l0 <- v125
        ()
    let v126 : int32 = v12.Length
    let v127 : (struct (US2 * string) []) = Array.zeroCreate<struct (US2 * string)> (v126)
    let v128 : Mut6 = {l0 = 0} : Mut6
    while method21(v126, v128) do
        let v130 : int32 = v128.l0
        let struct (v131 : US2, v132 : Fable.Core.JS.Promise<US17>, v133 : string) = v12.[int v130]
        v127.[int v130] <- struct (v131, v133)
        let v134 : int32 = v130 + 1
        v128.l0 <- v134
        ()
    let v135 : int32 = v118.Length
    let v136 : int32 = v127.Length
    let v137 : bool = v135 = v136
    let v138 : bool = v137 <> true
    let v141 : bool =
        if v138 then
            false
        else
            let v139 : int32 = 0
            method81(v118, v127, v139)
    let v142 : bool = v141 <> true
    if v142 then
        let v143 : US4 = US4_2
        let v144 : ((obj []) -> unit) = v4 v143
        let v145 : string = "> use_fetch > connections_change"
        let v146 : obj = v145
        let v147 : (struct (string * Fable.Core.JS.Promise<US17>) []) = Array.zeroCreate<struct (string * Fable.Core.JS.Promise<US17>)> (v126)
        let v148 : Mut6 = {l0 = 0} : Mut6
        while method21(v126, v148) do
            let v150 : int32 = v148.l0
            let struct (v151 : US2, v152 : Fable.Core.JS.Promise<US17>, v153 : string) = v12.[int v150]
            let v161 : string =
                match v151 with
                | US2_0 -> (* GunJsClient *)
                    let v156 : string = "Gun JavaScript"
                    v156
                | US2_1 -> (* GunRsClient *)
                    let v155 : string = "Gun Rust"
                    v155
                | US2_2 -> (* Memory *)
                    let v157 : string = "Memory"
                    v157
                | US2_3 -> (* SignalRClient *)
                    let v154 : string = "SignalR"
                    v154
            v147.[int v150] <- struct (v161, v152)
            let v162 : int32 = v150 + 1
            v148.l0 <- v162
            ()
        let v163 : string = "new_subscriptions"
        let v164 : obj = struct (v163, v147)
        let v165 : (obj []) = [|v146; v164|]
        v144 v165
        v2 v12
and closure294 (v0 : (unit -> (struct (US2 * obj * string) [])), v1 : ((struct (US2 * obj * string) []) -> unit)) () : unit =
    let v2 : (struct (US2 * obj * string) []) = v0 ()
    v1 v2
and closure296 (v0 : string) () : (obj []) =
    let v1 : string = "content_address"
    let v2 : obj = struct (v1, v0)
    [|v2|]
and closure295 (v0 : ((struct (US2 * obj * string) []) -> unit), v1 : string, v2 : (unit -> US4), v3 : (US4 -> ((obj []) -> unit))) () : unit =
    let v4 : obj = v0
    let v5 : string = "clear"
    let v6 : obj = (Fable.Core.JsInterop.(?)) v4 v5
    let v7 : (unit -> unit) = v6 |> unbox<(unit -> unit)>
    v7 ()
    let v8 : US4 = US4_0
    let v9 : ((obj []) -> unit) = v3 v8
    let v10 : string = "> use_fetch > unsubscribe () [1]"
    let v11 : obj = v10
    let v12 : (obj []) = [|v11|]
    v9 v12
    let v13 : (unit -> (obj [])) = closure296(v1)
    let v14 : string = "#666"
    let v15 : (US4 -> ((obj []) -> unit)) = method17(v2, v13, v14)
    let v16 : US4 = US4_0
    let v17 : ((obj []) -> unit) = v15 v16
    let v18 : string = "> db_off ()"
    let v19 : obj = v18
    let v20 : (obj []) = [|v19|]
    v17 v20
and closure298 (v0 : string, v1 : (unit -> (struct (System.Guid * int32) [])), v2 : (struct ((struct (System.Guid * int32) []) * US2 * System.Guid * int32) -> unit), v3 : (unit -> US4), v4 : (US16 -> unit), v5 : (unit -> US16), v6 : (US4 -> ((obj []) -> unit)), v7 : (struct (US2 * obj * string) []), v8 : System.Guid) (v9 : int32) : unit =
    let v10 : US2 = US2_2
    method79(v0, v1, v2, v3, v4, v5, v6, v10, v7, v9, v8)
and closure297 (v0 : (obj -> Fable.Core.JS.Promise<int32>), v1 : (unit -> (struct (US2 * obj * string) [])), v2 : string, v3 : (unit -> (struct (System.Guid * int32) [])), v4 : (struct ((struct (System.Guid * int32) []) * US2 * System.Guid * int32) -> unit), v5 : (unit -> US4), v6 : (US16 -> unit), v7 : (unit -> US16), v8 : (US4 -> ((obj []) -> unit))) () : unit =
    let v9 : (struct (US2 * obj * string) []) = v1 ()
    let v10 : int64 = System.DateTime.UtcNow.Ticks
    let v11 : System.Guid = System.Guid.NewGuid ()
    let v12 : string = (v11).ToString ()
    let v13 : string = (v10).ToString ()
    let v14 : System.Guid = System.Guid $"{v13.[0..7]}-{v13.[8..11]}-{v13.[12..15]}-{v13.[16..17]}{v12.[21..]}"
    let v15 : obj = ()
    let v16 : Fable.Core.JS.Promise<int32> = v0 v15
    let v17 : (int32 -> unit) = closure298(v2, v3, v4, v5, v6, v7, v8, v9, v14)
    v16 |> Promise.iter v17
    ()
and closure299 (v0 : (unit -> (struct (US2 * obj * string) [])), v1 : (US4 -> ((obj []) -> unit)), v2 : string, v3 : (unit -> (struct (System.Guid * int32) [])), v4 : (struct ((struct (System.Guid * int32) []) * US2 * System.Guid * int32) -> unit), v5 : (unit -> US4), v6 : (US16 -> unit), v7 : (unit -> US16)) () : unit =
    let v8 : US4 = US4_2
    let v9 : ((obj []) -> unit) = v1 v8
    let v10 : string = ">> use_fetch clear ()"
    let v11 : obj = v10
    let v12 : (obj []) = [|v11|]
    v9 v12
    let v13 : (struct (US2 * obj * string) []) = v0 ()
    let v14 : int64 = System.DateTime.UtcNow.Ticks
    let v15 : System.Guid = System.Guid.NewGuid ()
    let v16 : string = (v15).ToString ()
    let v17 : string = (v14).ToString ()
    let v18 : System.Guid = System.Guid $"{v17.[0..7]}-{v17.[8..11]}-{v17.[12..15]}-{v17.[16..17]}{v16.[21..]}"
    let v19 : US2 = US2_2
    let v20 : int32 = Fable.Core.JsInterop.emitJsExpr () "null"
    method79(v2, v3, v4, v5, v6, v7, v1, v19, v13, v20, v18)
and method74 (v0 : string, v1 : (unit -> (struct (System.Guid * int32) [])), v2 : (struct ((struct (System.Guid * int32) []) * US2 * System.Guid * int32) -> unit), v3 : (obj -> Fable.Core.JS.Promise<int32>)) : struct ((unit -> unit) * (unit -> unit)) =
    let v99 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v100 : string = "useContext"
    let v101 : string = "solid-js"
    let v102 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v100 v101
    let struct (v103 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v104 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v105 : (unit -> int32), v106 : (int32 -> unit), v107 : (unit -> string), v108 : (string -> unit), v109 : (unit -> string), v110 : (string -> unit), v111 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v112 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v113 : (unit -> (struct (US2 * obj * string) [])), v114 : ((struct (US2 * obj * string) []) -> unit), v115 : (unit -> (struct (System.Guid * obj) [])), v116 : ((struct (System.Guid * obj) []) -> unit), v117 : (unit -> (struct (System.Guid * obj) [])), v118 : ((struct (System.Guid * obj) []) -> unit), v119 : (unit -> (struct (System.Guid * int32) [])), v120 : ((struct (System.Guid * int32) []) -> unit), v121 : (unit -> US4), v122 : (US4 -> unit), v123 : (unit -> US5), v124 : (US5 -> unit)) = v102.Invoke v99 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v220 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v221 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v100 v101
    let struct (v222 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v223 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v224 : (unit -> int32), v225 : (int32 -> unit), v226 : (unit -> string), v227 : (string -> unit), v228 : (unit -> string), v229 : (string -> unit), v230 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v231 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v232 : (unit -> (struct (US2 * obj * string) [])), v233 : ((struct (US2 * obj * string) []) -> unit), v234 : (unit -> (struct (System.Guid * obj) [])), v235 : ((struct (System.Guid * obj) []) -> unit), v236 : (unit -> (struct (System.Guid * obj) [])), v237 : ((struct (System.Guid * obj) []) -> unit), v238 : (unit -> (struct (System.Guid * int32) [])), v239 : ((struct (System.Guid * int32) []) -> unit), v240 : (unit -> US4), v241 : (US4 -> unit), v242 : (unit -> US5), v243 : (US5 -> unit)) = v221.Invoke v220 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let struct (v244 : (unit -> unit), v245 : (unit -> unit)) = method75()
    let struct (v246 : (unit -> unit), v247 : (unit -> unit)) = method75()
    let v248 : US16 = US16_0
    let struct (v249 : (unit -> US16), v250 : (US16 -> unit)) = method76(v248)
    let v251 : (struct (US2 * Fable.Core.JS.Promise<US17> * string) []) = [||]
    let struct (v252 : (unit -> (struct (US2 * Fable.Core.JS.Promise<US17> * string) [])), v253 : ((struct (US2 * Fable.Core.JS.Promise<US17> * string) []) -> unit)) = method77(v251)
    let v254 : (uint8 []) = System.Text.Encoding.UTF8.GetBytes v0
    let v255 : int32 = v254.Length
    let v256 : Mut25 = {l0 = 0; l1 = 100000} : Mut25
    while method71(v255, v256) do
        let v258 : int32 = v256.l0
        let v259 : int32 = v256.l1
        let v260 : uint8 = v254.[int v258]
        let v261 : int32 = v260 |> unbox<int32>
        let v262 : int32 = v261 * 14
        let v263 : int32 = v259 + v262
        let v264 : int32 = v258 + 1
        v256.l0 <- v264
        v256.l1 <- v263
        ()
    let v265 : int32 = v256.l1
    let v266 : string = (v265).ToString ()
    let v267 : string = $"#{v266}"
    let v268 : (unit -> (obj [])) = closure282(v0, v1, v232, v244, v246, v249, v252)
    let v269 : (US4 -> ((obj []) -> unit)) = method16(v268, v267)
    let v270 : US4 = US4_0
    let v271 : ((obj []) -> unit) = v269 v270
    let v272 : string = "> use_fetch ()"
    let v273 : obj = v272
    let v274 : (obj []) = [|v273|]
    v271 v274
    let v275 : string = "debounce"
    let v276 : string = "@solid-primitives/scheduled"
    let v277 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v275 v276
    let v278 : ((struct (US2 * obj * string) []) -> unit) = closure283(v0, v121, v253, v252, v269, v1, v2, v250, v249)
    let v279 : ((struct (US2 * obj * string) []) -> unit) = v277.Invoke (v278, 2500) |> unbox<(struct (US2 * obj * string) []) -> unit>
    let v280 : string = "createEffect"
    let v281 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v280 v101
    let v282 : (unit -> unit) = closure294(v232, v279)
    v281.Invoke v282 |> ignore
    let v283 : string = "onCleanup"
    let v284 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v283 v101
    let v285 : (unit -> unit) = closure295(v279, v0, v121, v269)
    v284.Invoke v285 |> ignore
    let v286 : (unit -> unit) = closure297(v3, v232, v0, v1, v2, v121, v250, v249, v269)
    let v287 : (unit -> unit) = closure299(v232, v269, v0, v1, v2, v121, v250, v249)
    struct (v286, v287)
and closure301 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
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
and closure303 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure304 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "Counter"
    let v1 : Fable.Core.JSX.Element = v0 |> unbox<Fable.Core.JSX.Element>
    let v2 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v1 ]
    [|v2|]
and closure306 () () : Fable.Core.JS.Function =
    let v0 : string = "BiRegularPlus"
    let v1 : string = "solid-icons/bi"
    let v2 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v0 v1
    v2
and closure307 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v70, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure305 (v0 : (unit -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (Mut7 -> Fable.Core.JSX.Element) = closure60()
    let v72 : (unit -> Fable.Core.JS.Function) = closure306()
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure307()
    let v75 : Fable.Core.JSX.Element = method48(v71, v72, v73, v74)
    let v76 : US11 = US11_1(v75)
    let v77 : US13 = US13_1(v0)
    let v78 : string = "10px"
    let v79 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v76, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v77, v44, v45, v46, v47, v48, v49, v50, v51, v79, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure308 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "Request"
    let v1 : Fable.Core.JSX.Element = v0 |> unbox<Fable.Core.JSX.Element>
    let v2 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v1 ]
    [|v2|]
and closure310 () () : Fable.Core.JS.Function =
    let v0 : string = "BiRegularMinus"
    let v1 : string = "solid-icons/bi"
    let v2 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v0 v1
    v2
and closure311 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v70, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure309 (v0 : (unit -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (Mut7 -> Fable.Core.JSX.Element) = closure60()
    let v72 : (unit -> Fable.Core.JS.Function) = closure310()
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure311()
    let v75 : Fable.Core.JSX.Element = method48(v71, v72, v73, v74)
    let v76 : US11 = US11_1(v75)
    let v77 : US13 = US13_1(v0)
    let v78 : string = "10px"
    let v79 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v76, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v77, v44, v45, v46, v47, v48, v49, v50, v51, v79, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure312 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : Fable.Core.JSX.Element = v0 |> unbox<Fable.Core.JSX.Element>
    let v2 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v1 ]
    [|v2|]
and closure302 (v0 : (unit -> unit), v1 : (unit -> unit)) () : (Fable.Core.JSX.Element []) =
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/core"
    let v4 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v2 v3
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure303()
    let v6 : (unit -> (Fable.Core.JSX.Element [])) = closure304()
    let v7 : Fable.Core.JSX.Element = method5(v4, v5, v6)
    let v8 : (Mut1 -> Fable.Core.JSX.Element) = closure47()
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure305(v1)
    let v10 : (unit -> (Fable.Core.JSX.Element [])) = closure308()
    let v11 : Fable.Core.JSX.Element = method22(v8, v9, v10)
    let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure309(v0)
    let v13 : (unit -> (Fable.Core.JSX.Element [])) = closure312()
    let v14 : Fable.Core.JSX.Element = method22(v8, v12, v13)
    [|v7; v11; v14|]
and method82 (v0 : int32, v1 : Mut28) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method83 (v0 : UH3, v1 : UH3) : UH3 =
    match v0 with
    | UH3_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH3 = UH3_0(v2, v3, v1)
        method83(v4, v5)
    | UH3_1 -> (* Nil *)
        v1
and method85 (v0 : UH3, v1 : int32) : int32 =
    match v0 with
    | UH3_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method85(v4, v5)
    | UH3_1 -> (* Nil *)
        v1
and method86 (v0 : (struct (System.Guid * int32) []), v1 : UH3, v2 : int32) : int32 =
    match v1 with
    | UH3_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method86(v0, v5, v6)
    | UH3_1 -> (* Nil *)
        v2
and method84 (v0 : UH3) : (struct (System.Guid * int32) []) =
    let v1 : int32 = 0
    let v2 : int32 = method85(v0, v1)
    let v3 : (struct (System.Guid * int32) []) = Array.zeroCreate<struct (System.Guid * int32)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method86(v3, v0, v4)
    v3
and closure319 (v0 : int32, v1 : int32) () : (Fable.Core.JSX.Element []) =
    let v2 : string = Fable.Core.JsInterop.emitJsExpr v1 "JSON.stringify($0, null, 2)"
    let v3 : string = $"[{v0}={v2}]"
    let v4 : Fable.Core.JSX.Element = v3 |> unbox<Fable.Core.JSX.Element>
    let v5 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v4 ]
    [|v5|]
and closure318 (v0 : int32, v1 : int32) () : (Fable.Core.JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/core"
    let v4 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v2 v3
    let v5 : obj = v4
    let v6 : string = "pre"
    let v7 : obj = (Fable.Core.JsInterop.(?)) v5 v6
    let v8 : Fable.Core.JS.Function = v7 |> unbox<Fable.Core.JS.Function>
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v10 : (unit -> (Fable.Core.JSX.Element [])) = closure319(v0, v1)
    let v11 : Fable.Core.JSX.Element = method5(v8, v9, v10)
    [|v11|]
and closure317 (v0 : int32, v1 : int32, v2 : System.Guid) struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US6, v19 : US6, v20 : US6, v21 : US10, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US11, v30 : US6, v31 : US6, v32 : US6, v33 : US11, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US12, v45 : US13, v46 : US12, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US14, v64 : US6, v65 : US11, v66 : US6, v67 : US6, v68 : US14, v69 : US14, v70 : US6, v71 : US5, v72 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v73 : string = (v2).ToString ()
    let v74 : Fable.Core.JSX.Element = v73 |> unbox<Fable.Core.JSX.Element>
    let v75 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v74 ]
    let v76 : (unit -> (Fable.Core.JSX.Element [])) = closure318(v0, v1)
    let v77 : US9 = US9_1(v76)
    let v78 : string = "3px"
    let v79 : US6 = US6_1(v78)
    let v80 : US11 = US11_1(v75)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v77, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v79, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v80, v66, v67, v68, v69, v70, v71, v72)
and closure316 (v0 : (unit -> struct (System.Guid * int32))) (v1 : int32) : (Fable.Core.JSX.Element []) =
    let struct (v2 : System.Guid, v3 : int32) = v0 ()
    let v4 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v5 : US13 = US13_0
    let v6 : US13 = US13_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure317(v1, v3, v2)
    let v8 : US15 = US15_2
    let v9 : Fable.Core.JSX.Element = method26(v4, v5, v6, v7, v8)
    [|v9|]
and closure315 () (v0 : (unit -> struct (System.Guid * int32))) : (int32 -> (Fable.Core.JSX.Element [])) =
    closure316(v0)
and closure320 (v0 : (struct (System.Guid * int32) [])) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (obj []) = v0 |> unbox<(obj [])>
    let v72 : US10 = US10_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v72, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure314 (v0 : (unit -> (struct (System.Guid * int32) []))) () : (Fable.Core.JSX.Element []) =
    let v1 : (struct (System.Guid * int32) []) = v0 ()
    let v2 : int32 = v1.Length
    let v3 : UH3 = UH3_1
    let v4 : Mut28 = {l0 = 0; l1 = v3} : Mut28
    while method82(v2, v4) do
        let v6 : int32 = v4.l0
        let v7 : int32 =  -v6
        let v8 : int32 = v7 + v2
        let v9 : int32 = v8 - 1
        let v10 : UH3 = v4.l1
        let struct (v11 : System.Guid, v12 : int32) = v1.[int v9]
        let v13 : int32 = v6 + 1
        let v14 : UH3 = UH3_0(v11, v12, v10)
        v4.l0 <- v13
        v4.l1 <- v14
        ()
    let v15 : UH3 = v4.l1
    let v16 : UH3 = UH3_1
    let v17 : UH3 = method83(v15, v16)
    let v18 : (struct (System.Guid * int32) []) = method84(v17)
    let v19 : ((unit -> struct (System.Guid * int32)) -> (int32 -> (Fable.Core.JSX.Element []))) = closure315()
    let v20 : (unit -> (Fable.Core.JSX.Element [])) = Fable.Core.JsInterop.emitJsExpr () $"(item: any, index: () => number) => {v19}(item)(index)"
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v21 v22
    let v24 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure320(v18)
    let v25 : Fable.Core.JSX.Element = method5(v23, v24, v20)
    [|v25|]
and closure313 (v0 : (unit -> (struct (System.Guid * int32) []))) () : (Fable.Core.JSX.Element []) =
    let v1 : (Mut1 -> Fable.Core.JSX.Element) = closure7()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v3 : (unit -> (Fable.Core.JSX.Element [])) = closure314(v0)
    let v4 : Fable.Core.JSX.Element = method22(v1, v2, v3)
    [|v4|]
and closure300 (v0 : (unit -> (struct (System.Guid * int32) [])), v1 : (unit -> unit), v2 : (unit -> unit)) struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US6, v19 : US6, v20 : US6, v21 : US10, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US11, v30 : US6, v31 : US6, v32 : US6, v33 : US11, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US12, v45 : US13, v46 : US12, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US14, v64 : US6, v65 : US11, v66 : US6, v67 : US6, v68 : US14, v69 : US14, v70 : US6, v71 : US5, v72 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v73 : string = "Stack"
    let v74 : string = "@hope-ui/core"
    let v75 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v73 v74
    let v76 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure301()
    let v77 : (unit -> (Fable.Core.JSX.Element [])) = closure302(v1, v2)
    let v78 : Fable.Core.JSX.Element = method5(v75, v76, v77)
    let v79 : (unit -> (Fable.Core.JSX.Element [])) = closure313(v0)
    let v80 : US9 = US9_1(v79)
    let v81 : string = "counter"
    let v82 : US6 = US6_1(v81)
    let v83 : US11 = US11_1(v78)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v80, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v82, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v83, v66, v67, v68, v69, v70, v71, v72)
and method73 () : Fable.Core.JSX.Element =
    let v95 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v96 : string = "useContext"
    let v97 : string = "solid-js"
    let v98 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v99 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v100 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v101 : (unit -> int32), v102 : (int32 -> unit), v103 : (unit -> string), v104 : (string -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v108 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v109 : (unit -> (struct (US2 * obj * string) [])), v110 : ((struct (US2 * obj * string) []) -> unit), v111 : (unit -> (struct (System.Guid * obj) [])), v112 : ((struct (System.Guid * obj) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * int32) [])), v116 : ((struct (System.Guid * int32) []) -> unit), v117 : (unit -> US4), v118 : (US4 -> unit), v119 : (unit -> US5), v120 : (US5 -> unit)) = v98.Invoke v95 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v121 : (unit -> (obj [])) = closure276(v115)
    let v122 : string = "#666"
    let v123 : (US4 -> ((obj []) -> unit)) = method16(v121, v122)
    let v124 : US4 = US4_0
    let v125 : ((obj []) -> unit) = v123 v124
    let v126 : string = "> counter ()"
    let v127 : obj = v126
    let v128 : (obj []) = [|v127|]
    v125 v128
    let v129 : string = "createEffect"
    let v130 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v129 v97
    let v131 : (unit -> unit) = closure277(v123)
    v130.Invoke v131 |> ignore
    let v132 : string = "profile/tmp/counter"
    let v133 : (struct ((struct (System.Guid * int32) []) * US2 * System.Guid * int32) -> unit) = closure278(v116)
    let v134 : (obj -> Fable.Core.JS.Promise<int32>) = closure279(v115)
    let struct (v135 : (unit -> unit), v136 : (unit -> unit)) = method74(v132, v115, v133, v134)
    let v137 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v138 : US13 = US13_0
    let v139 : US13 = US13_0
    let v140 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure300(v115, v136, v135)
    let v141 : US15 = US15_2
    method26(v137, v138, v139, v140, v141)
and closure275 () (v0 : Mut1) : Fable.Core.JSX.Element =
    method73()
and closure321 () () : (Fable.Core.JSX.Element []) =
    [||]
and closure323 (v0 : ((struct (System.Guid * obj) []) -> unit)) struct (v1 : (struct (System.Guid * obj) []), v2 : US2, v3 : System.Guid, v4 : (struct (System.Guid * obj) [])) : unit =
    v0 v4
and closure326 (v0 : (unit -> (struct (System.Guid * obj) [])), v1 : ((struct (System.Guid * obj) []) -> unit)) (v2 : (exn -> unit)) : unit =
    let v3 : (struct (System.Guid * obj) []) = v0 ()
    v1 v3
and closure325 (v0 : (unit -> (struct (System.Guid * obj) []))) (v1 : ((struct (System.Guid * obj) []) -> unit)) : ((exn -> unit) -> unit) =
    closure326(v0, v1)
and closure324 (v0 : (unit -> (struct (System.Guid * obj) []))) (v1 : obj) : Fable.Core.JS.Promise<(struct (System.Guid * obj) [])> =
    let v2 : (((struct (System.Guid * obj) []) -> unit) -> ((exn -> unit) -> unit)) = closure325(v0)
    let v3 : Fable.Core.JS.Promise<(struct (System.Guid * obj) [])> = Promise.create v2
    v3
and method89 (v0 : US19) : struct ((unit -> US19) * (US19 -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (Fable.Core.JS.Function []) = v3.Invoke v0 |> unbox<Fable.Core.JS.Function[]>
    let v5 : (unit -> US19) = v4.[0] |> unbox<unit -> US19>
    let v6 : (US19 -> unit) = v4.[1] |> unbox<US19 -> unit>
    struct (v5, v6)
and closure327 (v0 : string, v1 : (unit -> (struct (System.Guid * obj) [])), v2 : (unit -> (struct (US2 * obj * string) [])), v3 : (unit -> unit), v4 : (unit -> unit), v5 : (unit -> US19), v6 : (unit -> (struct (US2 * Fable.Core.JS.Promise<US17> * string) []))) () : (obj []) =
    let v7 : string = "content_address"
    let v8 : obj = struct (v7, v0)
    let v9 : (struct (System.Guid * obj) []) = v1 ()
    let v10 : string = "getter"
    let v11 : obj = struct (v10, v9)
    v3 ()
    let v12 : string = "events"
    let v13 : obj = v12
    v4 ()
    let v14 : string = "timers"
    let v15 : obj = v14
    let v16 : US19 = v5 ()
    let v17 : string = "value"
    let v18 : obj = struct (v17, v16)
    let v19 : (struct (US2 * Fable.Core.JS.Promise<US17> * string) []) = v6 ()
    let v20 : int32 = v19.Length
    let v21 : (struct (string * Fable.Core.JS.Promise<US17>) []) = Array.zeroCreate<struct (string * Fable.Core.JS.Promise<US17>)> (v20)
    let v22 : Mut6 = {l0 = 0} : Mut6
    while method21(v20, v22) do
        let v24 : int32 = v22.l0
        let struct (v25 : US2, v26 : Fable.Core.JS.Promise<US17>, v27 : string) = v19.[int v24]
        let v35 : string =
            match v25 with
            | US2_0 -> (* GunJsClient *)
                let v30 : string = "Gun JavaScript"
                v30
            | US2_1 -> (* GunRsClient *)
                let v29 : string = "Gun Rust"
                v29
            | US2_2 -> (* Memory *)
                let v31 : string = "Memory"
                v31
            | US2_3 -> (* SignalRClient *)
                let v28 : string = "SignalR"
                v28
        v21.[int v24] <- struct (v35, v26)
        let v36 : int32 = v24 + 1
        v22.l0 <- v36
        ()
    let v37 : string = "subscriptions"
    let v38 : obj = struct (v37, v21)
    let v39 : (struct (US2 * obj * string) []) = v2 ()
    let v40 : int32 = v39.Length
    let v41 : (string []) = Array.zeroCreate<string> (v40)
    let v42 : Mut6 = {l0 = 0} : Mut6
    while method21(v40, v42) do
        let v44 : int32 = v42.l0
        let struct (v45 : US2, v46 : obj, v47 : string) = v39.[int v44]
        let v55 : string =
            match v45 with
            | US2_0 -> (* GunJsClient *)
                let v50 : string = "Gun JavaScript"
                v50
            | US2_1 -> (* GunRsClient *)
                let v49 : string = "Gun Rust"
                v49
            | US2_2 -> (* Memory *)
                let v51 : string = "Memory"
                v51
            | US2_3 -> (* SignalRClient *)
                let v48 : string = "SignalR"
                v48
        v41.[int v44] <- v55
        let v56 : int32 = v44 + 1
        v42.l0 <- v56
        ()
    let v57 : string = "db_connections"
    let v58 : obj = struct (v57, v41)
    [|v8; v11; v13; v15; v18; v38; v58|]
and closure331 (v0 : US2, v1 : string, v2 : (struct (System.Guid * obj) [])) () : (obj []) =
    let v3 : string = "content_address"
    let v4 : obj = struct (v3, v1)
    let v12 : string =
        match v0 with
        | US2_0 -> (* GunJsClient *)
            let v7 : string = "Gun JavaScript"
            v7
        | US2_1 -> (* GunRsClient *)
            let v6 : string = "Gun Rust"
            v6
        | US2_2 -> (* Memory *)
            let v8 : string = "Memory"
            v8
        | US2_3 -> (* SignalRClient *)
            let v5 : string = "SignalR"
            v5
    let v13 : string = "client_type"
    let v14 : obj = struct (v13, v12)
    let v15 : string = "new_value"
    let v16 : obj = struct (v15, v2)
    [|v4; v14; v16|]
and method90 (v0 : string, v1 : (unit -> (struct (System.Guid * obj) [])), v2 : (struct ((struct (System.Guid * obj) []) * US2 * System.Guid * (struct (System.Guid * obj) [])) -> unit), v3 : (unit -> US4), v4 : (US19 -> unit), v5 : (unit -> US19), v6 : (US4 -> ((obj []) -> unit)), v7 : US2, v8 : (struct (US2 * obj * string) []), v9 : (struct (System.Guid * obj) []), v10 : System.Guid) : unit =
    let v11 : US19 = v5 ()
    let v18 : bool =
        match v11 with
        | US19_0 -> (* None *)
            true
        | US19_1(v12, v13, v14) -> (* Some *)
            let v15 : (System.Guid -> int64) = closure287()
            let v16 : bool = v14 <> v9 && v15 v10 > v15 v13
            v16
    if v18 then
        let v19 : (struct (System.Guid * obj) []) = v1 ()
        let v20 : US4 = US4_2
        let v21 : ((obj []) -> unit) = v6 v20
        let v22 : string = "> use_fetch > on_value > set ()"
        let v23 : obj = v22
        let v24 : string = "old_value"
        let v25 : obj = struct (v24, v19)
        let v33 : string =
            match v7 with
            | US2_0 -> (* GunJsClient *)
                let v28 : string = "Gun JavaScript"
                v28
            | US2_1 -> (* GunRsClient *)
                let v27 : string = "Gun Rust"
                v27
            | US2_2 -> (* Memory *)
                let v29 : string = "Memory"
                v29
            | US2_3 -> (* SignalRClient *)
                let v26 : string = "SignalR"
                v26
        let v34 : string = "client_type"
        let v35 : obj = struct (v34, v33)
        let v36 : string = "new_guid'"
        let v37 : obj = struct (v36, v10)
        let v38 : string = "new_value_raw"
        let v39 : obj = struct (v38, v9)
        let v40 : (obj []) = [|v23; v25; v35; v37; v39|]
        v21 v40
        v2 struct (v19, v7, v10, v9)
        let v41 : US19 = US19_1(v7, v10, v9)
        v4 v41
        let v42 : int32 = v8.Length
        let v43 : Mut6 = {l0 = 0} : Mut6
        while method21(v42, v43) do
            let v45 : int32 = v43.l0
            let struct (v46 : US2, v47 : obj, v48 : string) = v8.[int v45]
            let v49 : bool =
                match v46, v7 with
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
            let v50 : bool = v49 <> true
            if v50 then
                let v51 : US4 = US4_2
                let v52 : ((obj []) -> unit) = v6 v51
                let v53 : string = "> use_fetch > on_value > set () > db_put"
                let v54 : obj = v53
                let v55 : obj = struct (v24, v19)
                let v63 : string =
                    match v7 with
                    | US2_0 -> (* GunJsClient *)
                        let v58 : string = "Gun JavaScript"
                        v58
                    | US2_1 -> (* GunRsClient *)
                        let v57 : string = "Gun Rust"
                        v57
                    | US2_2 -> (* Memory *)
                        let v59 : string = "Memory"
                        v59
                    | US2_3 -> (* SignalRClient *)
                        let v56 : string = "SignalR"
                        v56
                let v64 : obj = struct (v34, v63)
                let v65 : obj = struct (v36, v10)
                let v66 : obj = struct (v38, v9)
                let v74 : string =
                    match v46 with
                    | US2_0 -> (* GunJsClient *)
                        let v69 : string = "Gun JavaScript"
                        v69
                    | US2_1 -> (* GunRsClient *)
                        let v68 : string = "Gun Rust"
                        v68
                    | US2_2 -> (* Memory *)
                        let v70 : string = "Memory"
                        v70
                    | US2_3 -> (* SignalRClient *)
                        let v67 : string = "SignalR"
                        v67
                let v75 : string = "connection_client_type"
                let v76 : obj = struct (v75, v74)
                let v77 : (obj []) = [|v54; v55; v64; v65; v66; v76|]
                v52 v77
                let v78 : (unit -> (obj [])) = closure331(v46, v0, v9)
                let v79 : string = "#666"
                let v80 : (US4 -> ((obj []) -> unit)) = method17(v3, v78, v79)
                let v81 : US4 = US4_0
                let v82 : ((obj []) -> unit) = v80 v81
                let v83 : string = "> db_put ()"
                let v84 : obj = v83
                let v85 : (obj []) = [|v84|]
                v82 v85
                match v46 with
                | US2_0 -> (* GunJsClient *)
                    let v112 : (string []) = v0.Split [| '/' |]
                    let v113 : string = "get"
                    let v114 : obj = (Fable.Core.JsInterop.(?)) v47 v113
                    let v115 : (string -> obj) = v114 |> unbox<(string -> obj)>
                    let v116 : string = "tictactoe"
                    let v117 : obj = v115 v116
                    let v118 : int32 = v112.Length
                    let v119 : Mut27 = {l0 = 0; l1 = v117} : Mut27
                    while method80(v118, v119) do
                        let v121 : int32 = v119.l0
                        let v122 : obj = v119.l1
                        let v123 : string = v112.[int v121]
                        let v124 : obj = (Fable.Core.JsInterop.(?)) v122 v113
                        let v125 : (string -> obj) = v124 |> unbox<(string -> obj)>
                        let v126 : obj = v125 v123
                        let v127 : int32 = v121 + 1
                        v119.l0 <- v127
                        v119.l1 <- v126
                        ()
                    let v128 : obj = v119.l1
                    let v129 : string = "put"
                    let v130 : obj = (Fable.Core.JsInterop.(?)) v128 v129
                    let v131 : ((struct (System.Guid * obj) []) -> unit) = v130 |> unbox<((struct (System.Guid * obj) []) -> unit)>
                    v131 v9
                | US2_1 -> (* GunRsClient *)
                    let v92 : (string []) = v0.Split [| '/' |]
                    let v93 : string = "get"
                    let v94 : obj = (Fable.Core.JsInterop.(?)) v47 v93
                    let v95 : (string -> obj) = v94 |> unbox<(string -> obj)>
                    let v96 : string = "tictactoe"
                    let v97 : obj = v95 v96
                    let v98 : int32 = v92.Length
                    let v99 : Mut27 = {l0 = 0; l1 = v97} : Mut27
                    while method80(v98, v99) do
                        let v101 : int32 = v99.l0
                        let v102 : obj = v99.l1
                        let v103 : string = v92.[int v101]
                        let v104 : obj = (Fable.Core.JsInterop.(?)) v102 v93
                        let v105 : (string -> obj) = v104 |> unbox<(string -> obj)>
                        let v106 : obj = v105 v103
                        let v107 : int32 = v101 + 1
                        v99.l0 <- v107
                        v99.l1 <- v106
                        ()
                    let v108 : obj = v99.l1
                    let v109 : string = "put"
                    let v110 : obj = (Fable.Core.JsInterop.(?)) v108 v109
                    let v111 : ((struct (System.Guid * obj) []) -> unit) = v110 |> unbox<((struct (System.Guid * obj) []) -> unit)>
                    v111 v9
                | US2_2 -> (* Memory *)
                    failwith<unit> "db_on Memory"
                | US2_3 -> (* SignalRClient *)
                    let v86 : string = v9 |> unbox<string>
                    let v87 : Fable.SignalR.HubConnection<UH0, UH0, unit, UH1, UH1> = v47 |> unbox<Fable.SignalR.HubConnection<UH0, UH0, unit, UH1, UH1>>
                    let v88 : string = "alias"
                    let v89 : UH0 = UH0_3(v88, v0, v86)
                    let v90 : Fable.Core.JS.Promise<UH1> = v87.invokeAsPromise v89
                    let v91 : (UH1 -> unit) = closure289(v80)
                    v90 |> Promise.iter v91
                    ()
            let v132 : int32 = v45 + 1
            v43.l0 <- v132
            ()
        ()
and closure330 (v0 : string, v1 : (unit -> (struct (System.Guid * obj) [])), v2 : (struct ((struct (System.Guid * obj) []) * US2 * System.Guid * (struct (System.Guid * obj) [])) -> unit), v3 : (unit -> US4), v4 : (US19 -> unit), v5 : (unit -> US19), v6 : (US4 -> ((obj []) -> unit)), v7 : US2, v8 : (struct (US2 * obj * string) []), v9 : (US4 -> ((obj []) -> unit)), v10 : System.Guid, v11 : (struct (System.Guid * obj) [])) (v12 : obj) : unit =
    let v13 : US4 = US4_2
    let v14 : ((obj []) -> unit) = v9 v13
    let v15 : string = "> db_on > on_value ()"
    let v16 : obj = v15
    let v17 : string = "v"
    let v18 : obj = struct (v17, v10, v11)
    let v19 : string = "k"
    let v20 : obj = struct (v19, v12)
    let v21 : (obj []) = [|v16; v18; v20|]
    v14 v21
    method90(v0, v1, v2, v3, v4, v5, v6, v7, v8, v11, v10)
and closure329 (v0 : string, v1 : (unit -> (struct (System.Guid * obj) [])), v2 : (struct ((struct (System.Guid * obj) []) * US2 * System.Guid * (struct (System.Guid * obj) [])) -> unit), v3 : (unit -> US4), v4 : (US19 -> unit), v5 : (unit -> US19), v6 : (US4 -> ((obj []) -> unit)), v7 : US2, v8 : (struct (US2 * obj * string) []), v9 : (US4 -> ((obj []) -> unit))) struct (v10 : System.Guid, v11 : (struct (System.Guid * obj) [])) : (obj -> unit) =
    closure330(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure328 (v0 : string, v1 : (unit -> US4), v2 : ((struct (US2 * Fable.Core.JS.Promise<US17> * string) []) -> unit), v3 : (unit -> (struct (US2 * Fable.Core.JS.Promise<US17> * string) [])), v4 : (US4 -> ((obj []) -> unit)), v5 : (unit -> (struct (System.Guid * obj) [])), v6 : (struct ((struct (System.Guid * obj) []) * US2 * System.Guid * (struct (System.Guid * obj) [])) -> unit), v7 : (US19 -> unit), v8 : (unit -> US19)) (v9 : (struct (US2 * obj * string) [])) : unit =
    let v10 : (struct (US2 * Fable.Core.JS.Promise<US17> * string) []) = v3 ()
    let v11 : int32 = v9.Length
    let v12 : (struct (US2 * Fable.Core.JS.Promise<US17> * string) []) = Array.zeroCreate<struct (US2 * Fable.Core.JS.Promise<US17> * string)> (v11)
    let v13 : Mut6 = {l0 = 0} : Mut6
    while method21(v11, v13) do
        let v15 : int32 = v13.l0
        let struct (v16 : US2, v17 : obj, v18 : string) = v9.[int v15]
        let v19 : int32 = v10.Length
        let v20 : US18 = US18_0
        let v21 : Mut26 = {l0 = 0; l1 = v20} : Mut26
        while method78(v19, v21) do
            let v23 : int32 = v21.l0
            let v24 : int32 =  -v23
            let v25 : int32 = v24 + v19
            let v26 : int32 = v25 - 1
            let v27 : US18 = v21.l1
            let struct (v28 : US2, v29 : Fable.Core.JS.Promise<US17>, v30 : string) = v10.[int v26]
            let v37 : US18 =
                match v27 with
                | US18_0 -> (* None *)
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
                        US18_1(v28, v29, v30)
                    else
                        US18_0
                | _ ->
                    v27
            let v38 : int32 = v23 + 1
            v21.l0 <- v38
            v21.l1 <- v37
            ()
        let v39 : US18 = v21.l1
        let struct (v113 : US2, v114 : Fable.Core.JS.Promise<US17>, v115 : string) =
            match v39 with
            | US18_0 -> (* None *)
                let v43 : (unit -> (obj [])) = closure284(v0, v16)
                let v44 : string = "#666"
                let v45 : (US4 -> ((obj []) -> unit)) = method17(v1, v43, v44)
                let v46 : US4 = US4_0
                let v47 : ((obj []) -> unit) = v45 v46
                let v48 : string = "> db_on ()"
                let v49 : obj = v48
                let v50 : (obj []) = [|v49|]
                v47 v50
                let v51 : (struct (System.Guid * (struct (System.Guid * obj) [])) -> (obj -> unit)) = closure329(v0, v5, v6, v1, v7, v8, v4, v16, v9, v45)
                let v52 : (struct (obj * int32) -> unit) = Fable.Core.JsInterop.emitJsExpr () $"(v: any, k: any) => {v51}(v)(k)"
                let v109 : Fable.Core.JS.Promise<US17> =
                    match v16 with
                    | US2_0 -> (* GunJsClient *)
                        let v82 : (string []) = v0.Split [| '/' |]
                        let v83 : string = "get"
                        let v84 : obj = (Fable.Core.JsInterop.(?)) v17 v83
                        let v85 : (string -> obj) = v84 |> unbox<(string -> obj)>
                        let v86 : string = "tictactoe"
                        let v87 : obj = v85 v86
                        let v88 : int32 = v82.Length
                        let v89 : Mut27 = {l0 = 0; l1 = v87} : Mut27
                        while method80(v88, v89) do
                            let v91 : int32 = v89.l0
                            let v92 : obj = v89.l1
                            let v93 : string = v82.[int v91]
                            let v94 : obj = (Fable.Core.JsInterop.(?)) v92 v83
                            let v95 : (string -> obj) = v94 |> unbox<(string -> obj)>
                            let v96 : obj = v95 v93
                            let v97 : int32 = v91 + 1
                            v89.l0 <- v97
                            v89.l1 <- v96
                            ()
                        let v98 : obj = v89.l1
                        let v99 : string = "on"
                        let v100 : obj = (Fable.Core.JsInterop.(?)) v98 v99
                        let v101 : ((struct (obj * int32) -> unit) -> unit) = v100 |> unbox<((struct (obj * int32) -> unit) -> unit)>
                        v101 v52
                        let v102 : int64 = System.DateTime.UtcNow.Ticks
                        let v103 : US17 = US17_1(v102)
                        let v104 : Fable.Core.JS.Promise<US17> = Promise.lift v103
                        v104
                    | US2_1 -> (* GunRsClient *)
                        let v59 : (string []) = v0.Split [| '/' |]
                        let v60 : string = "get"
                        let v61 : obj = (Fable.Core.JsInterop.(?)) v17 v60
                        let v62 : (string -> obj) = v61 |> unbox<(string -> obj)>
                        let v63 : string = "tictactoe"
                        let v64 : obj = v62 v63
                        let v65 : int32 = v59.Length
                        let v66 : Mut27 = {l0 = 0; l1 = v64} : Mut27
                        while method80(v65, v66) do
                            let v68 : int32 = v66.l0
                            let v69 : obj = v66.l1
                            let v70 : string = v59.[int v68]
                            let v71 : obj = (Fable.Core.JsInterop.(?)) v69 v60
                            let v72 : (string -> obj) = v71 |> unbox<(string -> obj)>
                            let v73 : obj = v72 v70
                            let v74 : int32 = v68 + 1
                            v66.l0 <- v74
                            v66.l1 <- v73
                            ()
                        let v75 : obj = v66.l1
                        let v76 : string = "on"
                        let v77 : obj = (Fable.Core.JsInterop.(?)) v75 v76
                        let v78 : ((struct (obj * int32) -> unit) -> int64) = v77 |> unbox<((struct (obj * int32) -> unit) -> int64)>
                        let v79 : int64 = v78 v52
                        let v80 : US17 = US17_1(v79)
                        let v81 : Fable.Core.JS.Promise<US17> = Promise.lift v80
                        v81
                    | US2_2 -> (* Memory *)
                        failwith<Fable.Core.JS.Promise<US17>> "db_on Memory"
                    | US2_3 -> (* SignalRClient *)
                        let v53 : Fable.SignalR.HubConnection<UH0, UH0, unit, UH1, UH1> = v17 |> unbox<Fable.SignalR.HubConnection<UH0, UH0, unit, UH1, UH1>>
                        let v54 : string = "alias"
                        let v55 : UH0 = UH0_1(v54, v0)
                        let v56 : Fable.Core.JS.Promise<Fable.SignalR.StreamResult<UH1>> = v53.streamFromAsPromise v55
                        let v57 : (Fable.SignalR.StreamResult<UH1> -> US17) = closure290(v45)
                        let v58 : Fable.Core.JS.Promise<US17> = v56 |> Promise.map v57
                        v58
                struct (v16, v109, v18)
            | US18_1(v40, v41, v42) -> (* Some *)
                struct (v40, v41, v42)
        v12.[int v15] <- struct (v113, v114, v115)
        let v116 : int32 = v15 + 1
        v13.l0 <- v116
        ()
    let v117 : int32 = v10.Length
    let v118 : (struct (US2 * string) []) = Array.zeroCreate<struct (US2 * string)> (v117)
    let v119 : Mut6 = {l0 = 0} : Mut6
    while method21(v117, v119) do
        let v121 : int32 = v119.l0
        let struct (v122 : US2, v123 : Fable.Core.JS.Promise<US17>, v124 : string) = v10.[int v121]
        v118.[int v121] <- struct (v122, v124)
        let v125 : int32 = v121 + 1
        v119.l0 <- v125
        ()
    let v126 : int32 = v12.Length
    let v127 : (struct (US2 * string) []) = Array.zeroCreate<struct (US2 * string)> (v126)
    let v128 : Mut6 = {l0 = 0} : Mut6
    while method21(v126, v128) do
        let v130 : int32 = v128.l0
        let struct (v131 : US2, v132 : Fable.Core.JS.Promise<US17>, v133 : string) = v12.[int v130]
        v127.[int v130] <- struct (v131, v133)
        let v134 : int32 = v130 + 1
        v128.l0 <- v134
        ()
    let v135 : int32 = v118.Length
    let v136 : int32 = v127.Length
    let v137 : bool = v135 = v136
    let v138 : bool = v137 <> true
    let v141 : bool =
        if v138 then
            false
        else
            let v139 : int32 = 0
            method81(v118, v127, v139)
    let v142 : bool = v141 <> true
    if v142 then
        let v143 : US4 = US4_2
        let v144 : ((obj []) -> unit) = v4 v143
        let v145 : string = "> use_fetch > connections_change"
        let v146 : obj = v145
        let v147 : (struct (string * Fable.Core.JS.Promise<US17>) []) = Array.zeroCreate<struct (string * Fable.Core.JS.Promise<US17>)> (v126)
        let v148 : Mut6 = {l0 = 0} : Mut6
        while method21(v126, v148) do
            let v150 : int32 = v148.l0
            let struct (v151 : US2, v152 : Fable.Core.JS.Promise<US17>, v153 : string) = v12.[int v150]
            let v161 : string =
                match v151 with
                | US2_0 -> (* GunJsClient *)
                    let v156 : string = "Gun JavaScript"
                    v156
                | US2_1 -> (* GunRsClient *)
                    let v155 : string = "Gun Rust"
                    v155
                | US2_2 -> (* Memory *)
                    let v157 : string = "Memory"
                    v157
                | US2_3 -> (* SignalRClient *)
                    let v154 : string = "SignalR"
                    v154
            v147.[int v150] <- struct (v161, v152)
            let v162 : int32 = v150 + 1
            v148.l0 <- v162
            ()
        let v163 : string = "new_subscriptions"
        let v164 : obj = struct (v163, v147)
        let v165 : (obj []) = [|v146; v164|]
        v144 v165
        v2 v12
and closure333 (v0 : string, v1 : (unit -> (struct (System.Guid * obj) [])), v2 : (struct ((struct (System.Guid * obj) []) * US2 * System.Guid * (struct (System.Guid * obj) [])) -> unit), v3 : (unit -> US4), v4 : (US19 -> unit), v5 : (unit -> US19), v6 : (US4 -> ((obj []) -> unit)), v7 : (struct (US2 * obj * string) []), v8 : System.Guid) (v9 : (struct (System.Guid * obj) [])) : unit =
    let v10 : US2 = US2_2
    method90(v0, v1, v2, v3, v4, v5, v6, v10, v7, v9, v8)
and closure332 (v0 : (obj -> Fable.Core.JS.Promise<(struct (System.Guid * obj) [])>), v1 : (unit -> (struct (US2 * obj * string) [])), v2 : string, v3 : (unit -> (struct (System.Guid * obj) [])), v4 : (struct ((struct (System.Guid * obj) []) * US2 * System.Guid * (struct (System.Guid * obj) [])) -> unit), v5 : (unit -> US4), v6 : (US19 -> unit), v7 : (unit -> US19), v8 : (US4 -> ((obj []) -> unit))) () : unit =
    let v9 : (struct (US2 * obj * string) []) = v1 ()
    let v10 : int64 = System.DateTime.UtcNow.Ticks
    let v11 : System.Guid = System.Guid.NewGuid ()
    let v12 : string = (v11).ToString ()
    let v13 : string = (v10).ToString ()
    let v14 : System.Guid = System.Guid $"{v13.[0..7]}-{v13.[8..11]}-{v13.[12..15]}-{v13.[16..17]}{v12.[21..]}"
    let v15 : obj = ()
    let v16 : Fable.Core.JS.Promise<(struct (System.Guid * obj) [])> = v0 v15
    let v17 : ((struct (System.Guid * obj) []) -> unit) = closure333(v2, v3, v4, v5, v6, v7, v8, v9, v14)
    v16 |> Promise.iter v17
    ()
and closure334 (v0 : (unit -> (struct (US2 * obj * string) [])), v1 : (US4 -> ((obj []) -> unit)), v2 : string, v3 : (unit -> (struct (System.Guid * obj) [])), v4 : (struct ((struct (System.Guid * obj) []) * US2 * System.Guid * (struct (System.Guid * obj) [])) -> unit), v5 : (unit -> US4), v6 : (US19 -> unit), v7 : (unit -> US19)) () : unit =
    let v8 : US4 = US4_2
    let v9 : ((obj []) -> unit) = v1 v8
    let v10 : string = ">> use_fetch clear ()"
    let v11 : obj = v10
    let v12 : (obj []) = [|v11|]
    v9 v12
    let v13 : (struct (US2 * obj * string) []) = v0 ()
    let v14 : int64 = System.DateTime.UtcNow.Ticks
    let v15 : System.Guid = System.Guid.NewGuid ()
    let v16 : string = (v15).ToString ()
    let v17 : string = (v14).ToString ()
    let v18 : System.Guid = System.Guid $"{v17.[0..7]}-{v17.[8..11]}-{v17.[12..15]}-{v17.[16..17]}{v16.[21..]}"
    let v19 : US2 = US2_2
    let v20 : (struct (System.Guid * obj) []) = Fable.Core.JsInterop.emitJsExpr () "null"
    method90(v2, v3, v4, v5, v6, v7, v1, v19, v13, v20, v18)
and method88 (v0 : string, v1 : (unit -> (struct (System.Guid * obj) [])), v2 : (struct ((struct (System.Guid * obj) []) * US2 * System.Guid * (struct (System.Guid * obj) [])) -> unit), v3 : (obj -> Fable.Core.JS.Promise<(struct (System.Guid * obj) [])>)) : struct ((unit -> unit) * (unit -> unit)) =
    let v99 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v100 : string = "useContext"
    let v101 : string = "solid-js"
    let v102 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v100 v101
    let struct (v103 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v104 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v105 : (unit -> int32), v106 : (int32 -> unit), v107 : (unit -> string), v108 : (string -> unit), v109 : (unit -> string), v110 : (string -> unit), v111 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v112 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v113 : (unit -> (struct (US2 * obj * string) [])), v114 : ((struct (US2 * obj * string) []) -> unit), v115 : (unit -> (struct (System.Guid * obj) [])), v116 : ((struct (System.Guid * obj) []) -> unit), v117 : (unit -> (struct (System.Guid * obj) [])), v118 : ((struct (System.Guid * obj) []) -> unit), v119 : (unit -> (struct (System.Guid * int32) [])), v120 : ((struct (System.Guid * int32) []) -> unit), v121 : (unit -> US4), v122 : (US4 -> unit), v123 : (unit -> US5), v124 : (US5 -> unit)) = v102.Invoke v99 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v220 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v221 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v100 v101
    let struct (v222 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v223 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v224 : (unit -> int32), v225 : (int32 -> unit), v226 : (unit -> string), v227 : (string -> unit), v228 : (unit -> string), v229 : (string -> unit), v230 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v231 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v232 : (unit -> (struct (US2 * obj * string) [])), v233 : ((struct (US2 * obj * string) []) -> unit), v234 : (unit -> (struct (System.Guid * obj) [])), v235 : ((struct (System.Guid * obj) []) -> unit), v236 : (unit -> (struct (System.Guid * obj) [])), v237 : ((struct (System.Guid * obj) []) -> unit), v238 : (unit -> (struct (System.Guid * int32) [])), v239 : ((struct (System.Guid * int32) []) -> unit), v240 : (unit -> US4), v241 : (US4 -> unit), v242 : (unit -> US5), v243 : (US5 -> unit)) = v221.Invoke v220 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let struct (v244 : (unit -> unit), v245 : (unit -> unit)) = method75()
    let struct (v246 : (unit -> unit), v247 : (unit -> unit)) = method75()
    let v248 : US19 = US19_0
    let struct (v249 : (unit -> US19), v250 : (US19 -> unit)) = method89(v248)
    let v251 : (struct (US2 * Fable.Core.JS.Promise<US17> * string) []) = [||]
    let struct (v252 : (unit -> (struct (US2 * Fable.Core.JS.Promise<US17> * string) [])), v253 : ((struct (US2 * Fable.Core.JS.Promise<US17> * string) []) -> unit)) = method77(v251)
    let v254 : (uint8 []) = System.Text.Encoding.UTF8.GetBytes v0
    let v255 : int32 = v254.Length
    let v256 : Mut25 = {l0 = 0; l1 = 100000} : Mut25
    while method71(v255, v256) do
        let v258 : int32 = v256.l0
        let v259 : int32 = v256.l1
        let v260 : uint8 = v254.[int v258]
        let v261 : int32 = v260 |> unbox<int32>
        let v262 : int32 = v261 * 14
        let v263 : int32 = v259 + v262
        let v264 : int32 = v258 + 1
        v256.l0 <- v264
        v256.l1 <- v263
        ()
    let v265 : int32 = v256.l1
    let v266 : string = (v265).ToString ()
    let v267 : string = $"#{v266}"
    let v268 : (unit -> (obj [])) = closure327(v0, v1, v232, v244, v246, v249, v252)
    let v269 : (US4 -> ((obj []) -> unit)) = method16(v268, v267)
    let v270 : US4 = US4_0
    let v271 : ((obj []) -> unit) = v269 v270
    let v272 : string = "> use_fetch ()"
    let v273 : obj = v272
    let v274 : (obj []) = [|v273|]
    v271 v274
    let v275 : string = "debounce"
    let v276 : string = "@solid-primitives/scheduled"
    let v277 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v275 v276
    let v278 : ((struct (US2 * obj * string) []) -> unit) = closure328(v0, v121, v253, v252, v269, v1, v2, v250, v249)
    let v279 : ((struct (US2 * obj * string) []) -> unit) = v277.Invoke (v278, 2500) |> unbox<(struct (US2 * obj * string) []) -> unit>
    let v280 : string = "createEffect"
    let v281 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v280 v101
    let v282 : (unit -> unit) = closure294(v232, v279)
    v281.Invoke v282 |> ignore
    let v283 : string = "onCleanup"
    let v284 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v283 v101
    let v285 : (unit -> unit) = closure295(v279, v0, v121, v269)
    v284.Invoke v285 |> ignore
    let v286 : (unit -> unit) = closure332(v3, v232, v0, v1, v2, v121, v250, v249, v269)
    let v287 : (unit -> unit) = closure334(v232, v269, v0, v1, v2, v121, v250, v249)
    struct (v286, v287)
and closure336 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
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
and closure338 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "Chain Status"
    let v1 : Fable.Core.JSX.Element = v0 |> unbox<Fable.Core.JSX.Element>
    let v2 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v1 ]
    [|v2|]
and closure340 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v70, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure339 (v0 : (unit -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (Mut7 -> Fable.Core.JSX.Element) = closure60()
    let v72 : (unit -> Fable.Core.JS.Function) = closure306()
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure340()
    let v75 : Fable.Core.JSX.Element = method48(v71, v72, v73, v74)
    let v76 : US11 = US11_1(v75)
    let v77 : US13 = US13_1(v0)
    let v78 : string = "10px"
    let v79 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v76, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v77, v44, v45, v46, v47, v48, v49, v50, v51, v79, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure341 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "Request"
    let v1 : Fable.Core.JSX.Element = v0 |> unbox<Fable.Core.JSX.Element>
    let v2 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v1 ]
    [|v2|]
and closure343 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v70, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure342 (v0 : (unit -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (Mut7 -> Fable.Core.JSX.Element) = closure60()
    let v72 : (unit -> Fable.Core.JS.Function) = closure310()
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure343()
    let v75 : Fable.Core.JSX.Element = method48(v71, v72, v73, v74)
    let v76 : US11 = US11_1(v75)
    let v77 : US13 = US13_1(v0)
    let v78 : string = "10px"
    let v79 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v76, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v77, v44, v45, v46, v47, v48, v49, v50, v51, v79, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure344 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : Fable.Core.JSX.Element = v0 |> unbox<Fable.Core.JSX.Element>
    let v2 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v1 ]
    [|v2|]
and closure337 (v0 : (unit -> unit), v1 : (unit -> unit)) () : (Fable.Core.JSX.Element []) =
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/core"
    let v4 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v2 v3
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v6 : (unit -> (Fable.Core.JSX.Element [])) = closure338()
    let v7 : Fable.Core.JSX.Element = method5(v4, v5, v6)
    let v8 : (Mut1 -> Fable.Core.JSX.Element) = closure47()
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure339(v1)
    let v10 : (unit -> (Fable.Core.JSX.Element [])) = closure341()
    let v11 : Fable.Core.JSX.Element = method22(v8, v9, v10)
    let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure342(v0)
    let v13 : (unit -> (Fable.Core.JSX.Element [])) = closure344()
    let v14 : Fable.Core.JSX.Element = method22(v8, v12, v13)
    [|v7; v11; v14|]
and method91 (v0 : int32, v1 : Mut29) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method92 (v0 : UH4, v1 : UH4) : UH4 =
    match v0 with
    | UH4_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH4 = UH4_0(v2, v3, v1)
        method92(v4, v5)
    | UH4_1 -> (* Nil *)
        v1
and method94 (v0 : UH4, v1 : int32) : int32 =
    match v0 with
    | UH4_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method94(v4, v5)
    | UH4_1 -> (* Nil *)
        v1
and method95 (v0 : (struct (System.Guid * obj) []), v1 : UH4, v2 : int32) : int32 =
    match v1 with
    | UH4_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method95(v0, v5, v6)
    | UH4_1 -> (* Nil *)
        v2
and method93 (v0 : UH4) : (struct (System.Guid * obj) []) =
    let v1 : int32 = 0
    let v2 : int32 = method94(v0, v1)
    let v3 : (struct (System.Guid * obj) []) = Array.zeroCreate<struct (System.Guid * obj)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method95(v3, v0, v4)
    v3
and closure351 (v0 : (unit -> struct (System.Guid * obj))) () : (Fable.Core.JSX.Element []) =
    let struct (v1 : System.Guid, v2 : obj) = v0 ()
    let v3 : string = Fable.Core.JsInterop.emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : Fable.Core.JSX.Element = v3 |> unbox<Fable.Core.JSX.Element>
    let v5 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v4 ]
    [|v5|]
and closure350 (v0 : (unit -> struct (System.Guid * obj))) () : (Fable.Core.JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/core"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : obj = v3
    let v5 : string = "pre"
    let v6 : obj = (Fable.Core.JsInterop.(?)) v4 v5
    let v7 : Fable.Core.JS.Function = v6 |> unbox<Fable.Core.JS.Function>
    let v8 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v9 : (unit -> (Fable.Core.JSX.Element [])) = closure351(v0)
    let v10 : Fable.Core.JSX.Element = method5(v7, v8, v9)
    [|v10|]
and closure349 (v0 : (unit -> struct (System.Guid * obj))) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let struct (v71 : System.Guid, v72 : obj) = v0 ()
    let v73 : string = (v71).ToString ()
    let v74 : Fable.Core.JSX.Element = v73 |> unbox<Fable.Core.JSX.Element>
    let v75 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v74 ]
    let v76 : (unit -> (Fable.Core.JSX.Element [])) = closure350(v0)
    let v77 : US9 = US9_1(v76)
    let v78 : string = "3px"
    let v79 : US6 = US6_1(v78)
    let v80 : US11 = US11_1(v75)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v77, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v79, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v80, v64, v65, v66, v67, v68, v69, v70)
and closure348 (v0 : (unit -> struct (System.Guid * obj))) (v1 : int32) : (Fable.Core.JSX.Element []) =
    let v2 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v3 : US13 = US13_0
    let v4 : US13 = US13_0
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure349(v0)
    let v6 : US15 = US15_2
    let v7 : Fable.Core.JSX.Element = method26(v2, v3, v4, v5, v6)
    [|v7|]
and closure347 () (v0 : (unit -> struct (System.Guid * obj))) : (int32 -> (Fable.Core.JSX.Element [])) =
    closure348(v0)
and closure352 (v0 : (struct (System.Guid * obj) [])) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (obj []) = v0 |> unbox<(obj [])>
    let v72 : US10 = US10_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v72, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure346 (v0 : (unit -> (struct (System.Guid * obj) []))) () : (Fable.Core.JSX.Element []) =
    let v1 : (struct (System.Guid * obj) []) = v0 ()
    let v2 : int32 = v1.Length
    let v3 : UH4 = UH4_1
    let v4 : Mut29 = {l0 = 0; l1 = v3} : Mut29
    while method91(v2, v4) do
        let v6 : int32 = v4.l0
        let v7 : int32 =  -v6
        let v8 : int32 = v7 + v2
        let v9 : int32 = v8 - 1
        let v10 : UH4 = v4.l1
        let struct (v11 : System.Guid, v12 : obj) = v1.[int v9]
        let v13 : int32 = v6 + 1
        let v14 : UH4 = UH4_0(v11, v12, v10)
        v4.l0 <- v13
        v4.l1 <- v14
        ()
    let v15 : UH4 = v4.l1
    let v16 : UH4 = UH4_1
    let v17 : UH4 = method92(v15, v16)
    let v18 : (struct (System.Guid * obj) []) = method93(v17)
    let v19 : ((unit -> struct (System.Guid * obj)) -> (int32 -> (Fable.Core.JSX.Element []))) = closure347()
    let v20 : (unit -> (Fable.Core.JSX.Element [])) = Fable.Core.JsInterop.emitJsExpr () $"(item: any, index: () => number) => {v19}(item)(index)"
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v21 v22
    let v24 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure352(v18)
    let v25 : Fable.Core.JSX.Element = method5(v23, v24, v20)
    [|v25|]
and closure345 (v0 : (unit -> (struct (System.Guid * obj) []))) () : (Fable.Core.JSX.Element []) =
    let v1 : (Mut1 -> Fable.Core.JSX.Element) = closure7()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v3 : (unit -> (Fable.Core.JSX.Element [])) = closure346(v0)
    let v4 : Fable.Core.JSX.Element = method22(v1, v2, v3)
    [|v4|]
and closure335 (v0 : (unit -> (struct (System.Guid * obj) [])), v1 : (unit -> unit), v2 : (unit -> unit)) struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US6, v19 : US6, v20 : US6, v21 : US10, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US11, v30 : US6, v31 : US6, v32 : US6, v33 : US11, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US12, v45 : US13, v46 : US12, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US14, v64 : US6, v65 : US11, v66 : US6, v67 : US6, v68 : US14, v69 : US14, v70 : US6, v71 : US5, v72 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v73 : string = "Stack"
    let v74 : string = "@hope-ui/core"
    let v75 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v73 v74
    let v76 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure336()
    let v77 : (unit -> (Fable.Core.JSX.Element [])) = closure337(v1, v2)
    let v78 : Fable.Core.JSX.Element = method5(v75, v76, v77)
    let v79 : (unit -> (Fable.Core.JSX.Element [])) = closure345(v0)
    let v80 : US9 = US9_1(v79)
    let v81 : string = "status"
    let v82 : US6 = US6_1(v81)
    let v83 : US11 = US11_1(v78)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v80, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v82, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v83, v66, v67, v68, v69, v70, v71, v72)
and method87 () : Fable.Core.JSX.Element =
    let v95 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v96 : string = "useContext"
    let v97 : string = "solid-js"
    let v98 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v99 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v100 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v101 : (unit -> int32), v102 : (int32 -> unit), v103 : (unit -> string), v104 : (string -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v108 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v109 : (unit -> (struct (US2 * obj * string) [])), v110 : ((struct (US2 * obj * string) []) -> unit), v111 : (unit -> (struct (System.Guid * obj) [])), v112 : ((struct (System.Guid * obj) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * int32) [])), v116 : ((struct (System.Guid * int32) []) -> unit), v117 : (unit -> US4), v118 : (US4 -> unit), v119 : (unit -> US5), v120 : (US5 -> unit)) = v98.Invoke v95 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v121 : string = "profile/tmp/chain_status"
    let v122 : (struct ((struct (System.Guid * obj) []) * US2 * System.Guid * (struct (System.Guid * obj) [])) -> unit) = closure323(v114)
    let v123 : (obj -> Fable.Core.JS.Promise<(struct (System.Guid * obj) [])>) = closure324(v113)
    let struct (v124 : (unit -> unit), v125 : (unit -> unit)) = method88(v121, v113, v122, v123)
    let v126 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v127 : US13 = US13_0
    let v128 : US13 = US13_0
    let v129 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure335(v113, v125, v124)
    let v130 : US15 = US15_2
    method26(v126, v127, v128, v129, v130)
and closure322 () (v0 : Mut1) : Fable.Core.JSX.Element =
    method87()
and closure353 () () : (Fable.Core.JSX.Element []) =
    [||]
and closure355 (v0 : ((struct (System.Guid * obj) []) -> unit)) struct (v1 : (struct (System.Guid * obj) []), v2 : US2, v3 : System.Guid, v4 : (struct (System.Guid * obj) [])) : unit =
    v0 v4
and closure358 (v0 : (unit -> (struct (System.Guid * obj) [])), v1 : ((struct (System.Guid * obj) []) -> unit)) (v2 : (exn -> unit)) : unit =
    let v3 : (struct (System.Guid * obj) []) = v0 ()
    v1 v3
and closure357 (v0 : (unit -> (struct (System.Guid * obj) []))) (v1 : ((struct (System.Guid * obj) []) -> unit)) : ((exn -> unit) -> unit) =
    closure358(v0, v1)
and closure356 (v0 : (unit -> (struct (System.Guid * obj) []))) (v1 : obj) : Fable.Core.JS.Promise<(struct (System.Guid * obj) [])> =
    let v2 : (((struct (System.Guid * obj) []) -> unit) -> ((exn -> unit) -> unit)) = closure357(v0)
    let v3 : Fable.Core.JS.Promise<(struct (System.Guid * obj) [])> = Promise.create v2
    v3
and closure360 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
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
and closure362 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "Chain Deploy"
    let v1 : Fable.Core.JSX.Element = v0 |> unbox<Fable.Core.JSX.Element>
    let v2 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v1 ]
    [|v2|]
and closure364 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v70, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure363 (v0 : (unit -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (Mut7 -> Fable.Core.JSX.Element) = closure60()
    let v72 : (unit -> Fable.Core.JS.Function) = closure306()
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure364()
    let v75 : Fable.Core.JSX.Element = method48(v71, v72, v73, v74)
    let v76 : US11 = US11_1(v75)
    let v77 : US13 = US13_1(v0)
    let v78 : string = "10px"
    let v79 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v76, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v77, v44, v45, v46, v47, v48, v49, v50, v51, v79, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure365 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "Request"
    let v1 : Fable.Core.JSX.Element = v0 |> unbox<Fable.Core.JSX.Element>
    let v2 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v1 ]
    [|v2|]
and closure367 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US6, v16 : US6, v17 : US6, v18 : US10, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US13, v43 : US12, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US14, v61 : US6, v62 : US11, v63 : US6, v64 : US6, v65 : US14, v66 : US14, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v70, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure366 (v0 : (unit -> unit)) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v71 : (Mut7 -> Fable.Core.JSX.Element) = closure60()
    let v72 : (unit -> Fable.Core.JS.Function) = closure310()
    let v73 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v74 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure367()
    let v75 : Fable.Core.JSX.Element = method48(v71, v72, v73, v74)
    let v76 : US11 = US11_1(v75)
    let v77 : US13 = US13_1(v0)
    let v78 : string = "10px"
    let v79 : US6 = US6_1(v78)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v76, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v77, v44, v45, v46, v47, v48, v49, v50, v51, v79, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure368 () () : (Fable.Core.JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : Fable.Core.JSX.Element = v0 |> unbox<Fable.Core.JSX.Element>
    let v2 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v1 ]
    [|v2|]
and closure361 (v0 : (unit -> unit), v1 : (unit -> unit)) () : (Fable.Core.JSX.Element []) =
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/core"
    let v4 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v2 v3
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v6 : (unit -> (Fable.Core.JSX.Element [])) = closure362()
    let v7 : Fable.Core.JSX.Element = method5(v4, v5, v6)
    let v8 : (Mut1 -> Fable.Core.JSX.Element) = closure47()
    let v9 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure363(v1)
    let v10 : (unit -> (Fable.Core.JSX.Element [])) = closure365()
    let v11 : Fable.Core.JSX.Element = method22(v8, v9, v10)
    let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure366(v0)
    let v13 : (unit -> (Fable.Core.JSX.Element [])) = closure368()
    let v14 : Fable.Core.JSX.Element = method22(v8, v12, v13)
    [|v7; v11; v14|]
and closure375 (v0 : (unit -> struct (System.Guid * obj))) () : (Fable.Core.JSX.Element []) =
    let struct (v1 : System.Guid, v2 : obj) = v0 ()
    let v3 : string = Fable.Core.JsInterop.emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : Fable.Core.JSX.Element = v3 |> unbox<Fable.Core.JSX.Element>
    let v5 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v4 ]
    [|v5|]
and closure374 (v0 : (unit -> struct (System.Guid * obj))) () : (Fable.Core.JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/core"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : obj = v3
    let v5 : string = "pre"
    let v6 : obj = (Fable.Core.JsInterop.(?)) v4 v5
    let v7 : Fable.Core.JS.Function = v6 |> unbox<Fable.Core.JS.Function>
    let v8 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v9 : (unit -> (Fable.Core.JSX.Element [])) = closure375(v0)
    let v10 : Fable.Core.JSX.Element = method5(v7, v8, v9)
    [|v10|]
and closure373 (v0 : (unit -> struct (System.Guid * obj))) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US6, v17 : US6, v18 : US6, v19 : US10, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US13, v44 : US12, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US14, v62 : US6, v63 : US11, v64 : US6, v65 : US6, v66 : US14, v67 : US14, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let struct (v71 : System.Guid, v72 : obj) = v0 ()
    let v73 : string = (v71).ToString ()
    let v74 : Fable.Core.JSX.Element = v73 |> unbox<Fable.Core.JSX.Element>
    let v75 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v74 ]
    let v76 : (unit -> (Fable.Core.JSX.Element [])) = closure374(v0)
    let v77 : US9 = US9_1(v76)
    let v78 : string = "3px"
    let v79 : US6 = US6_1(v78)
    let v80 : US11 = US11_1(v75)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v77, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v79, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v80, v64, v65, v66, v67, v68, v69, v70)
and closure372 (v0 : (unit -> struct (System.Guid * obj))) (v1 : int32) : (Fable.Core.JSX.Element []) =
    let v2 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v3 : US13 = US13_0
    let v4 : US13 = US13_0
    let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure373(v0)
    let v6 : US15 = US15_2
    let v7 : Fable.Core.JSX.Element = method26(v2, v3, v4, v5, v6)
    [|v7|]
and closure371 () (v0 : (unit -> struct (System.Guid * obj))) : (int32 -> (Fable.Core.JSX.Element [])) =
    closure372(v0)
and closure370 (v0 : (unit -> (struct (System.Guid * obj) []))) () : (Fable.Core.JSX.Element []) =
    let v1 : (struct (System.Guid * obj) []) = v0 ()
    let v2 : int32 = v1.Length
    let v3 : UH4 = UH4_1
    let v4 : Mut29 = {l0 = 0; l1 = v3} : Mut29
    while method91(v2, v4) do
        let v6 : int32 = v4.l0
        let v7 : int32 =  -v6
        let v8 : int32 = v7 + v2
        let v9 : int32 = v8 - 1
        let v10 : UH4 = v4.l1
        let struct (v11 : System.Guid, v12 : obj) = v1.[int v9]
        let v13 : int32 = v6 + 1
        let v14 : UH4 = UH4_0(v11, v12, v10)
        v4.l0 <- v13
        v4.l1 <- v14
        ()
    let v15 : UH4 = v4.l1
    let v16 : UH4 = UH4_1
    let v17 : UH4 = method92(v15, v16)
    let v18 : (struct (System.Guid * obj) []) = method93(v17)
    let v19 : ((unit -> struct (System.Guid * obj)) -> (int32 -> (Fable.Core.JSX.Element []))) = closure371()
    let v20 : (unit -> (Fable.Core.JSX.Element [])) = Fable.Core.JsInterop.emitJsExpr () $"(item: any, index: () => number) => {v19}(item)(index)"
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v21 v22
    let v24 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure352(v18)
    let v25 : Fable.Core.JSX.Element = method5(v23, v24, v20)
    [|v25|]
and closure369 (v0 : (unit -> (struct (System.Guid * obj) []))) () : (Fable.Core.JSX.Element []) =
    let v1 : (Mut1 -> Fable.Core.JSX.Element) = closure7()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v3 : (unit -> (Fable.Core.JSX.Element [])) = closure370(v0)
    let v4 : Fable.Core.JSX.Element = method22(v1, v2, v3)
    [|v4|]
and closure359 (v0 : (unit -> (struct (System.Guid * obj) [])), v1 : (unit -> unit), v2 : (unit -> unit)) struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US6, v19 : US6, v20 : US6, v21 : US10, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US11, v30 : US6, v31 : US6, v32 : US6, v33 : US11, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US12, v45 : US13, v46 : US12, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US14, v64 : US6, v65 : US11, v66 : US6, v67 : US6, v68 : US14, v69 : US14, v70 : US6, v71 : US5, v72 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v73 : string = "Stack"
    let v74 : string = "@hope-ui/core"
    let v75 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v73 v74
    let v76 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure360()
    let v77 : (unit -> (Fable.Core.JSX.Element [])) = closure361(v1, v2)
    let v78 : Fable.Core.JSX.Element = method5(v75, v76, v77)
    let v79 : (unit -> (Fable.Core.JSX.Element [])) = closure369(v0)
    let v80 : US9 = US9_1(v79)
    let v81 : string = "deploy"
    let v82 : US6 = US6_1(v81)
    let v83 : US11 = US11_1(v78)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v80, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v82, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v83, v66, v67, v68, v69, v70, v71, v72)
and method96 () : Fable.Core.JSX.Element =
    let v95 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v96 : string = "useContext"
    let v97 : string = "solid-js"
    let v98 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v99 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v100 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v101 : (unit -> int32), v102 : (int32 -> unit), v103 : (unit -> string), v104 : (string -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v108 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v109 : (unit -> (struct (US2 * obj * string) [])), v110 : ((struct (US2 * obj * string) []) -> unit), v111 : (unit -> (struct (System.Guid * obj) [])), v112 : ((struct (System.Guid * obj) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * int32) [])), v116 : ((struct (System.Guid * int32) []) -> unit), v117 : (unit -> US4), v118 : (US4 -> unit), v119 : (unit -> US5), v120 : (US5 -> unit)) = v98.Invoke v95 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v121 : string = "profile/tmp/chain_deploy"
    let v122 : (struct ((struct (System.Guid * obj) []) * US2 * System.Guid * (struct (System.Guid * obj) [])) -> unit) = closure355(v112)
    let v123 : (obj -> Fable.Core.JS.Promise<(struct (System.Guid * obj) [])>) = closure356(v111)
    let struct (v124 : (unit -> unit), v125 : (unit -> unit)) = method88(v121, v111, v122, v123)
    let v126 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v127 : US13 = US13_0
    let v128 : US13 = US13_0
    let v129 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure359(v111, v125, v124)
    let v130 : US15 = US15_2
    method26(v126, v127, v128, v129, v130)
and closure354 () (v0 : Mut1) : Fable.Core.JSX.Element =
    method96()
and closure376 () () : (Fable.Core.JSX.Element []) =
    [||]
and closure274 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (Fable.Core.JSX.Element []) =
    let v5 : (Mut1 -> Fable.Core.JSX.Element) = closure275()
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (Fable.Core.JSX.Element [])) = closure321()
    let v8 : Fable.Core.JSX.Element = method22(v5, v6, v7)
    let v10 : bool = v2 = ""
    let v11 : bool = v10 <> true
    let v16 : Fable.Core.JSX.Element =
        if v11 then
            let v12 : (Mut1 -> Fable.Core.JSX.Element) = closure322()
            let v13 : (unit -> (Fable.Core.JSX.Element [])) = closure353()
            method22(v12, v6, v13)
        else
            let v15 : Fable.Core.JSX.Element = Fable.Core.JS.undefined
            v15
    let v22 : Fable.Core.JSX.Element =
        if v11 then
            let v18 : (Mut1 -> Fable.Core.JSX.Element) = closure354()
            let v19 : (unit -> (Fable.Core.JSX.Element [])) = closure376()
            method22(v18, v6, v19)
        else
            let v21 : Fable.Core.JSX.Element = Fable.Core.JS.undefined
            v21
    [|v8; v16; v22|]
and closure273 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (Fable.Core.JSX.Element []) =
    let v5 : (Mut1 -> Fable.Core.JSX.Element) = closure7()
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v7 : (unit -> (Fable.Core.JSX.Element [])) = closure274(v0, v1, v2, v3, v4)
    let v8 : Fable.Core.JSX.Element = method22(v5, v6, v7)
    [|v8|]
and closure272 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) struct (v5 : US6, v6 : US6, v7 : US6, v8 : US7, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US8, v16 : US9, v17 : US6, v18 : US6, v19 : US8, v20 : US6, v21 : US6, v22 : US6, v23 : US10, v24 : US8, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US11, v32 : US6, v33 : US6, v34 : US6, v35 : US11, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US12, v47 : US13, v48 : US12, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US14, v66 : US6, v67 : US11, v68 : US6, v69 : US6, v70 : US14, v71 : US14, v72 : US6, v73 : US5, v74 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) =
    let v75 : string = "Profile"
    let v76 : Fable.Core.JSX.Element = v75 |> unbox<Fable.Core.JSX.Element>
    let v77 : Fable.Core.JSX.Element = Feliz.JSX.Solid.Html.fragment [ v76 ]
    let v78 : (unit -> (Fable.Core.JSX.Element [])) = closure273(v0, v1, v2, v3, v4)
    let v79 : US9 = US9_1(v78)
    let v80 : US11 = US11_1(v77)
    struct (v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v79, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v80, v68, v69, v70, v71, v72, v73, v74)
and closure142 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (Fable.Core.JSX.Element []) =
    let v5 : (Mut3 -> Fable.Core.JSX.Element) = closure14()
    let v6 : US13 = US13_0
    let v7 : US13 = US13_0
    let v8 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure143()
    let v9 : US15 = US15_2
    let v10 : Fable.Core.JSX.Element = method26(v5, v6, v7, v8, v9)
    let v11 : US13 = US13_0
    let v12 : US13 = US13_0
    let v13 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure12()
    let v14 : US15 = US15_2
    let v15 : Fable.Core.JSX.Element = method26(v5, v11, v12, v13, v14)
    let v16 : US13 = US13_0
    let v17 : US13 = US13_0
    let v18 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure167()
    let v19 : US15 = US15_2
    let v20 : Fable.Core.JSX.Element = method26(v5, v16, v17, v18, v19)
    let v21 : US13 = US13_0
    let v22 : US13 = US13_0
    let v23 : US15 = US15_2
    let v24 : Fable.Core.JSX.Element = method26(v5, v21, v22, v13, v23)
    let v25 : US13 = US13_0
    let v26 : US13 = US13_0
    let v27 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure185()
    let v28 : US15 = US15_0
    let v29 : Fable.Core.JSX.Element = method26(v5, v25, v26, v27, v28)
    let v30 : US13 = US13_0
    let v31 : US13 = US13_0
    let v32 : US15 = US15_2
    let v33 : Fable.Core.JSX.Element = method26(v5, v30, v31, v13, v32)
    let v34 : US13 = US13_0
    let v35 : US13 = US13_0
    let v36 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure235()
    let v37 : US15 = US15_0
    let v38 : Fable.Core.JSX.Element = method26(v5, v34, v35, v36, v37)
    let v39 : US13 = US13_0
    let v40 : US13 = US13_0
    let v41 : US15 = US15_2
    let v42 : Fable.Core.JSX.Element = method26(v5, v39, v40, v13, v41)
    let v43 : US13 = US13_0
    let v44 : US13 = US13_0
    let v45 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure272(v0, v1, v2, v3, v4)
    let v46 : US15 = US15_2
    let v47 : Fable.Core.JSX.Element = method26(v5, v43, v44, v45, v46)
    [|v10; v15; v20; v24; v29; v33; v38; v42; v47|]
and closure3 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (Fable.Core.JSX.Element []) =
    let v6 : bool = v2 = ""
    let v10 : Fable.Core.JSX.Element =
        if v6 then
            let v7 : (Mut2 -> Fable.Core.JSX.Element) = closure4()
            method45(v7)
        else
            let v9 : Fable.Core.JSX.Element = Fable.Core.JS.undefined
            v9
    let v11 : (Mut1 -> Fable.Core.JSX.Element) = closure7()
    let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure141()
    let v13 : (unit -> (Fable.Core.JSX.Element [])) = closure142(v0, v1, v2, v3, v4)
    let v14 : Fable.Core.JSX.Element = method22(v11, v12, v13)
    [|v10; v14|]
and method1 () : Fable.Core.JSX.Element =
    let struct (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) = method2()
    let v5 : string = "Box"
    let v6 : string = "@hope-ui/core"
    let v7 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v5 v6
    let v8 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US6 * US6 * US6 * US10 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US11 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US13 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US14 * US6 * US11 * US6 * US6 * US14 * US14 * US6 * US5 * US6)) = closure2()
    let v9 : (unit -> (Fable.Core.JSX.Element [])) = closure3(v0, v1, v2, v3, v4)
    method5(v7, v8, v9)
and closure1 () (v0 : Mut1) : Fable.Core.JSX.Element =
    method1()
and closure378 (v0 : (unit -> (struct (US2 * obj * string) [])), v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) []))) () : (obj []) =
    let v2 : (struct ((US2 []) * int32 * US3 * string * string) []) = v1 ()
    let v3 : string = "db_connection_options"
    let v4 : obj = struct (v3, v2)
    let v5 : (struct (US2 * obj * string) []) = v0 ()
    let v6 : string = "db_connections"
    let v7 : obj = struct (v6, v5)
    [|v4; v7|]
and method98 (v0 : int32, v1 : Mut30) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method99 (v0 : int32, v1 : Mut31) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure383 () () : (obj []) =
    [||]
and closure384 (v0 : (US4 -> ((obj []) -> unit))) (v1 : obj) : obj =
    let v2 : US4 = US4_2
    let v3 : ((obj []) -> unit) = v0 v2
    let v4 : string = "> hub_on_connect -> automatic reconnect ()"
    let v5 : obj = v4
    let v6 : string = "delay"
    let v7 : obj = struct (v6, 2000)
    let v8 : (obj []) = [|v5; v7|]
    v3 v8
    let v9 : obj = Some 2000 |> unbox
    v9
and closure385 (v0 : (US4 -> ((obj []) -> unit))) (v1 : obj) : unit =
    let v2 : US4 = US4_2
    let v3 : ((obj []) -> unit) = v0 v2
    let v4 : string = "> hub_on_connect -> on_reconnecting ()"
    let v5 : obj = v4
    let v6 : string = "ex"
    let v7 : obj = struct (v6, v1)
    let v8 : (obj []) = [|v5; v7|]
    v3 v8
and closure386 (v0 : (US4 -> ((obj []) -> unit))) (v1 : obj) : unit =
    let v2 : US4 = US4_2
    let v3 : ((obj []) -> unit) = v0 v2
    let v4 : string = "> hub_on_connect -> on_reconnected ()"
    let v5 : obj = v4
    let v6 : string = "ex"
    let v7 : obj = struct (v6, v1)
    let v8 : (obj []) = [|v5; v7|]
    v3 v8
and closure387 (v0 : (US4 -> ((obj []) -> unit))) (v1 : obj) : unit =
    let v2 : US4 = US4_2
    let v3 : ((obj []) -> unit) = v0 v2
    let v4 : string = "> hub_on_connect -> on_close ()"
    let v5 : obj = v4
    let v6 : string = "ex"
    let v7 : obj = struct (v6, v1)
    let v8 : (obj []) = [|v5; v7|]
    v3 v8
and closure388 (v0 : (US4 -> ((obj []) -> unit))) (v1 : UH1) : unit =
    let v2 : US4 = US4_2
    let v3 : ((obj []) -> unit) = v0 v2
    let v4 : string = "> hub_on_connect -> on_message ()"
    let v5 : obj = v4
    let v6 : string = "msg"
    let v7 : obj = struct (v6, v1)
    let v8 : (obj []) = [|v5; v7|]
    v3 v8
and closure382 (v0 : (unit -> US4), v1 : string) (v2 : Fable.SignalR.HubConnectionBuilder<UH0, UH0, unit, UH1, UH1>) : Fable.SignalR.HubConnectionBuilder<UH0, UH0, unit, UH1, UH1> =
    let v3 : (unit -> (obj [])) = closure383()
    let v4 : string = "#666"
    let v5 : (US4 -> ((obj []) -> unit)) = method17(v0, v3, v4)
    let v6 : US4 = US4_0
    let v7 : ((obj []) -> unit) = v5 v6
    let v8 : string = "> hub_on_connect ()"
    let v9 : obj = v8
    let v10 : (obj []) = [|v9|]
    v7 v10
    let v11 : (obj -> obj) = closure384(v5)
    let v12 : obj = v11
    let v13 : string = "nextRetryDelayInMilliseconds"
    let v14 : (string * obj) = v13, v12
    let v15 : ((string * obj) []) = [|v14|]
    let v16 : obj = Fable.Core.JsInterop.createObj v15
    let v17 : Fable.SignalR.RetryPolicy = v16 |> unbox<Fable.SignalR.RetryPolicy>
    let v18 : Fable.SignalR.HubConnectionBuilder<UH0, UH0, unit, UH1, UH1> = v2.withUrl v1
    let v19 : Fable.SignalR.HubConnectionBuilder<UH0, UH0, unit, UH1, UH1> = v18.withAutomaticReconnect v17
    let v20 : (obj -> unit) = closure385(v5)
    let v21 : Fable.SignalR.HubConnectionBuilder<UH0, UH0, unit, UH1, UH1> = v19.onReconnecting v20
    let v22 : (obj -> unit) = closure386(v5)
    let v23 : Fable.SignalR.HubConnectionBuilder<UH0, UH0, unit, UH1, UH1> = v21.onReconnected v22
    let v24 : (obj -> unit) = closure387(v5)
    let v25 : Fable.SignalR.HubConnectionBuilder<UH0, UH0, unit, UH1, UH1> = v23.onClose v24
    let v26 : Fable.SignalR.LogLevel = Fable.SignalR.LogLevel.Trace
    let v27 : Fable.SignalR.HubConnectionBuilder<UH0, UH0, unit, UH1, UH1> = v25.configureLogging v26
    let v28 : (UH1 -> unit) = closure388(v5)
    let v29 : Fable.SignalR.HubConnectionBuilder<UH0, UH0, unit, UH1, UH1> = v27.onMessage v28
    v29
and closure381 (v0 : (unit -> US4)) (v1 : string) : (Fable.SignalR.HubConnectionBuilder<UH0, UH0, unit, UH1, UH1> -> Fable.SignalR.HubConnectionBuilder<UH0, UH0, unit, UH1, UH1>) =
    closure382(v0, v1)
and closure380 () (v0 : (unit -> US4)) : (string -> (Fable.SignalR.HubConnectionBuilder<UH0, UH0, unit, UH1, UH1> -> Fable.SignalR.HubConnectionBuilder<UH0, UH0, unit, UH1, UH1>)) =
    closure381(v0)
and method100 (v0 : int32, v1 : Mut32) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure379 (v0 : (unit -> US4), v1 : ((struct (US2 * obj * string) []) -> unit), v2 : (US4 -> ((obj []) -> unit))) struct (v3 : (struct ((US2 []) * int32 * US3 * string * string) []), v4 : (struct (US2 * obj * string) [])) : unit =
    let v5 : int32 = v3.Length
    let v6 : ((struct (US2 * obj * string) []) []) = Array.zeroCreate<(struct (US2 * obj * string) [])> (v5)
    let v7 : Mut6 = {l0 = 0} : Mut6
    while method21(v5, v7) do
        let v9 : int32 = v7.l0
        let struct (v10 : (US2 []), v11 : int32, v12 : US3, v13 : string, v14 : string) = v3.[int v9]
        let v15 : int32 = v10.Length
        let v16 : (struct (US2 * obj * string) []) = Array.zeroCreate<struct (US2 * obj * string)> (v15)
        let v17 : Mut6 = {l0 = 0} : Mut6
        while method21(v15, v17) do
            let v19 : int32 = v17.l0
            let v20 : US2 = v10.[int v19]
            let v21 : int32 = v4.Length
            let v22 : US20 = US20_0
            let v23 : Mut30 = {l0 = 0; l1 = v22} : Mut30
            while method98(v21, v23) do
                let v25 : int32 = v23.l0
                let v26 : int32 =  -v25
                let v27 : int32 = v26 + v21
                let v28 : int32 = v27 - 1
                let v29 : US20 = v23.l1
                let struct (v30 : US2, v31 : obj, v32 : string) = v4.[int v28]
                let v39 : US20 =
                    match v29 with
                    | US20_0 -> (* None *)
                        let v33 : bool =
                            match v30, v20 with
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
                        let v35 : bool =
                            if v33 then
                                let v34 : bool = v32 = v13
                                v34
                            else
                                false
                        if v35 then
                            US20_1(v30, v31, v32)
                        else
                            US20_0
                    | _ ->
                        v29
                let v40 : int32 = v25 + 1
                v23.l0 <- v40
                v23.l1 <- v39
                ()
            let v41 : US20 = v23.l1
            let struct (v108 : US2, v109 : obj, v110 : string) =
                match v41 with
                | US20_0 -> (* None *)
                    let v45 : US21 = US21_0
                    let v46 : Mut31 = {l0 = 0; l1 = v45} : Mut31
                    while method99(v5, v46) do
                        let v48 : int32 = v46.l0
                        let v49 : int32 =  -v48
                        let v50 : int32 = v49 + v5
                        let v51 : int32 = v50 - 1
                        let v52 : US21 = v46.l1
                        let struct (v53 : (US2 []), v54 : int32, v55 : US3, v56 : string, v57 : string) = v3.[int v51]
                        let v62 : US21 =
                            match v52 with
                            | US21_0 -> (* None *)
                                let v58 : bool =
                                    match v55, v12 with
                                    | US3_0, US3_0 -> (* GunJsServer *)
                                        true
                                    | US3_1, US3_1 -> (* GunRsServer *)
                                        true
                                    | US3_2, US3_2 -> (* SignalRServer *)
                                        true
                                    | _ ->
                                        false
                                if v58 then
                                    US21_1(v53, v54, v55, v56, v57)
                                else
                                    US21_0
                            | _ ->
                                v52
                        let v63 : int32 = v48 + 1
                        v46.l0 <- v63
                        v46.l1 <- v62
                        ()
                    let v64 : US21 = v46.l1
                    let v73 : string =
                        match v64 with
                        | US21_0 -> (* None *)
                            let v71 : string = ""
                            v71
                        | US21_1(v65, v66, v67, v68, v69) -> (* Some *)
                            let v70 : string = $"{v68}:{v66}/{v69}"
                            v70
                    let v104 : obj =
                        match v20 with
                        | US2_0 -> (* GunJsClient *)
                            let v82 : string = "gun/gun"
                            let v83 : Fable.Core.JS.Function = Fable.Core.JsInterop.importDefault v82
                            let v84 : string = "gun/lib/radix"
                            Fable.Core.JsInterop.importSideEffects v84
                            let v85 : string = "gun/lib/radisk"
                            Fable.Core.JsInterop.importSideEffects v85
                            let v86 : string = "gun/lib/store"
                            Fable.Core.JsInterop.importSideEffects v86
                            let v87 : string = "gun/lib/rindexed"
                            Fable.Core.JsInterop.importSideEffects v87
                            let v88 : obj = v73
                            let v89 : string = "url"
                            let v90 : (string * obj) = v89, v88
                            let v91 : obj = false
                            let v92 : string = "localStorage"
                            let v93 : (string * obj) = v92, v91
                            let v94 : obj = true
                            let v95 : string = "radisk"
                            let v96 : (string * obj) = v95, v94
                            let v97 : ((string * obj) []) = [|v90; v93; v96|]
                            let v98 : obj = Fable.Core.JsInterop.createObj v97
                            let v99 : obj = Fable.Core.JsInterop.createNew v83 v98
                            v99
                        | US2_1 -> (* GunRsClient *)
                            let v77 : string = "Node"
                            let v78 : string = "rusty-gun"
                            let v79 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v77 v78
                            let v80 : obj = v73
                            let v81 : obj = Fable.Core.JsInterop.createNew v79 v80
                            v81
                        | US2_2 -> (* Memory *)
                            failwith<obj> "new_db Memory"
                        | US2_3 -> (* SignalRClient *)
                            let v74 : ((unit -> US4) -> (string -> (Fable.SignalR.HubConnectionBuilder<UH0, UH0, unit, UH1, UH1> -> Fable.SignalR.HubConnectionBuilder<UH0, UH0, unit, UH1, UH1>))) = closure380()
                            let v75 : Fable.SignalR.HubConnection<UH0, UH0, unit, UH1, UH1> = Fable.SignalR.SignalR.connect<UH0, UH0, unit, UH1, UH1> ((v74 v0 v73) |> unbox) |> unbox
                            v75.startNow ()
                            let v76 : obj = v75
                            v76
                    struct (v20, v104, v73)
                | US20_1(v42, v43, v44) -> (* Some *)
                    struct (v42, v43, v44)
            v16.[int v19] <- struct (v108, v109, v110)
            let v111 : int32 = v19 + 1
            v17.l0 <- v111
            ()
        v6.[int v9] <- v16
        let v112 : int32 = v9 + 1
        v7.l0 <- v112
        ()
    let v113 : (struct (US2 * obj * string) []) = [||]
    let v114 : int32 = v6.Length
    let v115 : Mut32 = {l0 = 0; l1 = v113} : Mut32
    while method100(v114, v115) do
        let v117 : int32 = v115.l0
        let v118 : (struct (US2 * obj * string) []) = v115.l1
        let v119 : (struct (US2 * obj * string) []) = v6.[int v117]
        let v120 : int32 = v118.Length
        let v121 : int32 = v119.Length
        let v122 : int32 = v120 + v121
        let v123 : (struct (US2 * obj * string) []) = Array.zeroCreate<struct (US2 * obj * string)> (v122)
        let v124 : Mut6 = {l0 = 0} : Mut6
        while method21(v122, v124) do
            let v126 : int32 = v124.l0
            let v127 : bool = v126 < v120
            let struct (v135 : US2, v136 : obj, v137 : string) =
                if v127 then
                    let struct (v128 : US2, v129 : obj, v130 : string) = v118.[int v126]
                    struct (v128, v129, v130)
                else
                    let v131 : int32 = v126 - v120
                    let struct (v132 : US2, v133 : obj, v134 : string) = v119.[int v131]
                    struct (v132, v133, v134)
            v123.[int v126] <- struct (v135, v136, v137)
            let v138 : int32 = v126 + 1
            v124.l0 <- v138
            ()
        let v139 : int32 = v117 + 1
        v115.l0 <- v139
        v115.l1 <- v123
        ()
    let v140 : (struct (US2 * obj * string) []) = v115.l1
    let v141 : int32 = v4.Length
    let v142 : (struct (US2 * string) []) = Array.zeroCreate<struct (US2 * string)> (v141)
    let v143 : Mut6 = {l0 = 0} : Mut6
    while method21(v141, v143) do
        let v145 : int32 = v143.l0
        let struct (v146 : US2, v147 : obj, v148 : string) = v4.[int v145]
        v142.[int v145] <- struct (v146, v148)
        let v149 : int32 = v145 + 1
        v143.l0 <- v149
        ()
    let v150 : int32 = v140.Length
    let v151 : (struct (US2 * string) []) = Array.zeroCreate<struct (US2 * string)> (v150)
    let v152 : Mut6 = {l0 = 0} : Mut6
    while method21(v150, v152) do
        let v154 : int32 = v152.l0
        let struct (v155 : US2, v156 : obj, v157 : string) = v140.[int v154]
        v151.[int v154] <- struct (v155, v157)
        let v158 : int32 = v154 + 1
        v152.l0 <- v158
        ()
    let v159 : int32 = v142.Length
    let v160 : int32 = v151.Length
    let v161 : bool = v159 = v160
    let v162 : bool = v161 <> true
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = 0
            method81(v142, v151, v163)
    let v166 : bool = v165 <> true
    if v166 then
        let v167 : US4 = US4_2
        let v168 : ((obj []) -> unit) = v2 v167
        let v169 : string = "> db_listener > effect"
        let v170 : obj = v169
        let v171 : string = "new_connections"
        let v172 : obj = struct (v171, v140)
        let v173 : (obj []) = [|v170; v172|]
        v168 v173
        v1 v140
and closure389 (v0 : (unit -> (struct (US2 * obj * string) [])), v1 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v2 : (struct ((struct ((US2 []) * int32 * US3 * string * string) []) * (struct (US2 * obj * string) [])) -> unit)) () : unit =
    let v3 : (struct (US2 * obj * string) []) = v0 ()
    let v4 : (struct ((US2 []) * int32 * US3 * string * string) []) = v1 ()
    v2 struct (v4, v3)
and closure390 (v0 : (struct ((struct ((US2 []) * int32 * US3 * string * string) []) * (struct (US2 * obj * string) [])) -> unit)) () : unit =
    let v1 : obj = v0
    let v2 : string = "clear"
    let v3 : obj = (Fable.Core.JsInterop.(?)) v1 v2
    let v4 : (unit -> unit) = v3 |> unbox<(unit -> unit)>
    v4 ()
and method97 () : Fable.Core.JSX.Element =
    let v95 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v96 : string = "useContext"
    let v97 : string = "solid-js"
    let v98 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v99 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v100 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v101 : (unit -> int32), v102 : (int32 -> unit), v103 : (unit -> string), v104 : (string -> unit), v105 : (unit -> string), v106 : (string -> unit), v107 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v108 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v109 : (unit -> (struct (US2 * obj * string) [])), v110 : ((struct (US2 * obj * string) []) -> unit), v111 : (unit -> (struct (System.Guid * obj) [])), v112 : ((struct (System.Guid * obj) []) -> unit), v113 : (unit -> (struct (System.Guid * obj) [])), v114 : ((struct (System.Guid * obj) []) -> unit), v115 : (unit -> (struct (System.Guid * int32) [])), v116 : ((struct (System.Guid * int32) []) -> unit), v117 : (unit -> US4), v118 : (US4 -> unit), v119 : (unit -> US5), v120 : (US5 -> unit)) = v98.Invoke v95 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v216 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v217 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v218 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v219 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v220 : (unit -> int32), v221 : (int32 -> unit), v222 : (unit -> string), v223 : (string -> unit), v224 : (unit -> string), v225 : (string -> unit), v226 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v227 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v228 : (unit -> (struct (US2 * obj * string) [])), v229 : ((struct (US2 * obj * string) []) -> unit), v230 : (unit -> (struct (System.Guid * obj) [])), v231 : ((struct (System.Guid * obj) []) -> unit), v232 : (unit -> (struct (System.Guid * obj) [])), v233 : ((struct (System.Guid * obj) []) -> unit), v234 : (unit -> (struct (System.Guid * int32) [])), v235 : ((struct (System.Guid * int32) []) -> unit), v236 : (unit -> US4), v237 : (US4 -> unit), v238 : (unit -> US5), v239 : (US5 -> unit)) = v217.Invoke v216 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v335 : obj = Fable.Core.JsInterop.emitJsExpr () "components.state_context"
    let v336 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v96 v97
    let struct (v337 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v338 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v339 : (unit -> int32), v340 : (int32 -> unit), v341 : (unit -> string), v342 : (string -> unit), v343 : (unit -> string), v344 : (string -> unit), v345 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v346 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit), v347 : (unit -> (struct (US2 * obj * string) [])), v348 : ((struct (US2 * obj * string) []) -> unit), v349 : (unit -> (struct (System.Guid * obj) [])), v350 : ((struct (System.Guid * obj) []) -> unit), v351 : (unit -> (struct (System.Guid * obj) [])), v352 : ((struct (System.Guid * obj) []) -> unit), v353 : (unit -> (struct (System.Guid * int32) [])), v354 : ((struct (System.Guid * int32) []) -> unit), v355 : (unit -> US4), v356 : (US4 -> unit), v357 : (unit -> US5), v358 : (US5 -> unit)) = v336.Invoke v335 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit) * (unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v359 : (unit -> (obj [])) = closure378(v228, v345)
    let v360 : string = "#cf1100"
    let v361 : (US4 -> ((obj []) -> unit)) = method16(v359, v360)
    let v362 : US4 = US4_0
    let v363 : ((obj []) -> unit) = v361 v362
    let v364 : string = "> db_listener ()"
    let v365 : obj = v364
    let v366 : (obj []) = [|v365|]
    v363 v366
    let v367 : string = "debounce"
    let v368 : string = "@solid-primitives/scheduled"
    let v369 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v367 v368
    let v370 : (struct ((struct ((US2 []) * int32 * US3 * string * string) []) * (struct (US2 * obj * string) [])) -> unit) = closure379(v117, v229, v361)
    let v371 : (struct ((struct ((US2 []) * int32 * US3 * string * string) []) * (struct (US2 * obj * string) [])) -> unit) = v369.Invoke (v370, 300) |> unbox<struct ((struct ((US2 []) * int32 * US3 * string * string) []) * (struct (US2 * obj * string) [])) -> unit>
    let v372 : string = "createEffect"
    let v373 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v372 v97
    let v374 : (unit -> unit) = closure389(v228, v345, v371)
    v373.Invoke v374 |> ignore
    let v375 : string = "onCleanup"
    let v376 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v375 v97
    let v377 : (unit -> unit) = closure390(v371)
    v376.Invoke v377 |> ignore
    let v378 : Fable.Core.JSX.Element = Fable.Core.JS.undefined
    v378
and closure377 () (v0 : Mut2) : Fable.Core.JSX.Element =
    method97()
and method101 () : (struct (US0 * string * string * string) []) =
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
and method102 (v0 : US0) : struct ((unit -> US0) * (US0 -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (Fable.Core.JS.Function []) = v3.Invoke v0 |> unbox<Fable.Core.JS.Function[]>
    let v5 : (unit -> US0) = v4.[0] |> unbox<unit -> US0>
    let v6 : (US0 -> unit) = v4.[1] |> unbox<US0 -> unit>
    struct (v5, v6)
and method103 (v0 : string) : struct ((unit -> string) * (string -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (Fable.Core.JS.Function []) = v3.Invoke v0 |> unbox<Fable.Core.JS.Function[]>
    let v5 : (unit -> string) = v4.[0] |> unbox<unit -> string>
    let v6 : (string -> unit) = v4.[1] |> unbox<string -> unit>
    struct (v5, v6)
and method104 (v0 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) : struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (Fable.Core.JS.Function []) = v3.Invoke v0 |> unbox<Fable.Core.JS.Function[]>
    let v5 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) = v4.[0] |> unbox<unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])>
    let v6 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) = v4.[1] |> unbox<(struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit>
    struct (v5, v6)
and method105 () : int32 =
    4001
and method106 (v0 : int32) : struct ((unit -> int32) * (int32 -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (Fable.Core.JS.Function []) = v3.Invoke v0 |> unbox<Fable.Core.JS.Function[]>
    let v5 : (unit -> int32) = v4.[0] |> unbox<unit -> int32>
    let v6 : (int32 -> unit) = v4.[1] |> unbox<int32 -> unit>
    struct (v5, v6)
and method107 () : string =
    let v0 : string = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
    v0
and method108 () : string =
    let v0 : string = "http://localhost"
    v0
and method109 (v0 : (struct (US2 * obj * string) [])) : struct ((unit -> (struct (US2 * obj * string) [])) * ((struct (US2 * obj * string) []) -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (Fable.Core.JS.Function []) = v3.Invoke v0 |> unbox<Fable.Core.JS.Function[]>
    let v5 : (unit -> (struct (US2 * obj * string) [])) = v4.[0] |> unbox<unit -> (struct (US2 * obj * string) [])>
    let v6 : ((struct (US2 * obj * string) []) -> unit) = v4.[1] |> unbox<(struct (US2 * obj * string) []) -> unit>
    struct (v5, v6)
and method110 (v0 : (struct ((US2 []) * int32 * US3 * string * string) [])) : struct ((unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) * ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (Fable.Core.JS.Function []) = v3.Invoke v0 |> unbox<Fable.Core.JS.Function[]>
    let v5 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])) = v4.[0] |> unbox<unit -> (struct ((US2 []) * int32 * US3 * string * string) [])>
    let v6 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit) = v4.[1] |> unbox<(struct ((US2 []) * int32 * US3 * string * string) []) -> unit>
    struct (v5, v6)
and method111 (v0 : US4) : struct ((unit -> US4) * (US4 -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (Fable.Core.JS.Function []) = v3.Invoke v0 |> unbox<Fable.Core.JS.Function[]>
    let v5 : (unit -> US4) = v4.[0] |> unbox<unit -> US4>
    let v6 : (US4 -> unit) = v4.[1] |> unbox<US4 -> unit>
    struct (v5, v6)
and method112 (v0 : US5) : struct ((unit -> US5) * (US5 -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (Fable.Core.JS.Function []) = v3.Invoke v0 |> unbox<Fable.Core.JS.Function[]>
    let v5 : (unit -> US5) = v4.[0] |> unbox<unit -> US5>
    let v6 : (US5 -> unit) = v4.[1] |> unbox<US5 -> unit>
    struct (v5, v6)
and method113 (v0 : (struct (System.Guid * int32) [])) : struct ((unit -> (struct (System.Guid * int32) [])) * ((struct (System.Guid * int32) []) -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (Fable.Core.JS.Function []) = v3.Invoke v0 |> unbox<Fable.Core.JS.Function[]>
    let v5 : (unit -> (struct (System.Guid * int32) [])) = v4.[0] |> unbox<unit -> (struct (System.Guid * int32) [])>
    let v6 : ((struct (System.Guid * int32) []) -> unit) = v4.[1] |> unbox<(struct (System.Guid * int32) []) -> unit>
    struct (v5, v6)
and method114 (v0 : (struct (System.Guid * obj) [])) : struct ((unit -> (struct (System.Guid * obj) [])) * ((struct (System.Guid * obj) []) -> unit)) =
    let v1 : string = "createSignal"
    let v2 : string = "solid-js"
    let v3 : Fable.Core.JS.Function = Fable.Core.JsInterop.import v1 v2
    let v4 : (Fable.Core.JS.Function []) = v3.Invoke v0 |> unbox<Fable.Core.JS.Function[]>
    let v5 : (unit -> (struct (System.Guid * obj) [])) = v4.[0] |> unbox<unit -> (struct (System.Guid * obj) [])>
    let v6 : ((struct (System.Guid * obj) []) -> unit) = v4.[1] |> unbox<(struct (System.Guid * obj) []) -> unit>
    struct (v5, v6)
and closure391 () () : obj =
    let struct (v95 : string, v96 : obj, v97 : string, v98 : string, v99 : bool) = method2()
    let v100 : (struct (US0 * string * string * string) []) = method101()
    let v101 : int32 = v100.Length
    let v102 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) = Array.zeroCreate<struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit))> (v101)
    let v103 : Mut6 = {l0 = 0} : Mut6
    while method21(v101, v103) do
        let v105 : int32 = v103.l0
        let struct (v106 : US0, v107 : string, v108 : string, v109 : string) = v100.[int v105]
        let struct (v110 : (unit -> US0), v111 : (US0 -> unit)) = method102(v106)
        let struct (v112 : (unit -> string), v113 : (string -> unit)) = method103(v109)
        let struct (v114 : (unit -> string), v115 : (string -> unit)) = method103(v107)
        let struct (v116 : (unit -> string), v117 : (string -> unit)) = method103(v108)
        v102.[int v105] <- struct (v110, v111, v114, v115, v116, v117, v112, v113)
        let v118 : int32 = v105 + 1
        v103.l0 <- v118
        ()
    let struct (v119 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v120 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit)) = method104(v102)
    let v121 : bool = "" = v95
    let v123 : int32 =
        if v121 then
            method105()
        else
            80
    let struct (v124 : (unit -> int32), v125 : (int32 -> unit)) = method106(v123)
    let v126 : string = method107()
    let struct (v127 : (unit -> string), v128 : (string -> unit)) = method103(v126)
    let v131 : string =
        if v121 then
            method108()
        else
            let v130 : string = $"http://{v95}-4001.githubpreview.dev"
            v130
    let struct (v132 : (unit -> string), v133 : (string -> unit)) = method103(v131)
    let v134 : (struct (US2 * obj * string) []) = Array.zeroCreate<struct (US2 * obj * string)> (0)
    let struct (v135 : (unit -> (struct (US2 * obj * string) [])), v136 : ((struct (US2 * obj * string) []) -> unit)) = method109(v134)
    let v141 : string =
        if v121 then
            let v137 : string = "http://localhost"
            v137
        else
            if v99 then
                let v138 : string = "http://localhost"
                v138
            else
                let v139 : string = $"http://{v95}-9761.githubpreview.dev"
                v139
    let v143 : int32 =
        if v121 then
            if v99 then
                19761
            else
                9761
        else
            80
    let v144 : (US2 []) = Array.zeroCreate<US2> (0)
    let v145 : US3 = US3_2
    let v146 : string = "peer"
    let v151 : string =
        if v121 then
            let v147 : string = "ws://localhost"
            v147
        else
            if v99 then
                let v148 : string = "ws://localhost"
                v148
            else
                let v149 : string = $"ws://{v95}-4944.githubpreview.dev"
                v149
    let v153 : int32 =
        if v121 then
            if v99 then
                14944
            else
                4944
        else
            80
    let v154 : (US2 []) = Array.zeroCreate<US2> (0)
    let v155 : US3 = US3_1
    let v156 : string = "ws"
    let v161 : string =
        if v121 then
            let v157 : string = "wss://localhost"
            v157
        else
            if v99 then
                let v158 : string = "wss://localhost"
                v158
            else
                let v159 : string = $"ws://{v95}-8765.githubpreview.dev"
                v159
    let v163 : int32 =
        if v121 then
            if v99 then
                18765
            else
                8765
        else
            80
    let v164 : (US2 []) = Array.zeroCreate<US2> (0)
    let v165 : US3 = US3_0
    let v166 : string = "gun"
    let v167 : (struct ((US2 []) * int32 * US3 * string * string) []) = [|struct (v144, v143, v145, v141, v146); struct (v154, v153, v155, v151, v156); struct (v164, v163, v165, v161, v166)|]
    let struct (v168 : (unit -> (struct ((US2 []) * int32 * US3 * string * string) [])), v169 : ((struct ((US2 []) * int32 * US3 * string * string) []) -> unit)) = method110(v167)
    let v170 : bool = "" = v97
    let v175 : US4 =
        if v170 then
            US4_0
        else
            if v99 then
                US4_0
            else
                US4_4
    let struct (v176 : (unit -> US4), v177 : (US4 -> unit)) = method111(v175)
    let v178 : US5 = US5_0
    let struct (v179 : (unit -> US5), v180 : (US5 -> unit)) = method112(v178)
    let v181 : (struct (System.Guid * int32) []) = Array.zeroCreate<struct (System.Guid * int32)> (0)
    let struct (v182 : (unit -> (struct (System.Guid * int32) [])), v183 : ((struct (System.Guid * int32) []) -> unit)) = method113(v181)
    let v184 : (struct (System.Guid * obj) []) = Array.zeroCreate<struct (System.Guid * obj)> (0)
    let struct (v185 : (unit -> (struct (System.Guid * obj) [])), v186 : ((struct (System.Guid * obj) []) -> unit)) = method114(v184)
    let v187 : (struct (System.Guid * obj) []) = Array.zeroCreate<struct (System.Guid * obj)> (0)
    let struct (v188 : (unit -> (struct (System.Guid * obj) [])), v189 : ((struct (System.Guid * obj) []) -> unit)) = method114(v187)
    let v190 : obj = struct (v119, v120, v124, v125, v127, v128, v132, v133, v168, v169, v135, v136, v188, v189, v185, v186, v182, v183, v176, v177, v179, v180)
    v190
let (?), (?<-) = Fable.Core.JsInterop.(?), Fable.Core.JsInterop.(?<-)
let v0 : obj = Fable.Core.JS.undefined
let v1 : Mut0 = {l0 = v0} : Mut0
let v72 : obj = Fable.Core.JsInterop.emitJsExpr () "process.env"
let v73 : string = "env"
let v74 : (string * obj) = v73, v72
let v75 : ((string * obj) []) = [|v74|]
let v76 : obj = Fable.Core.JsInterop.createObj v75
Browser.Dom.window?components <- v76
let v77 : int32 = System.Random().Next ()
let v173 : obj = method0()
let v174 : UH0 = null |> unbox<UH0>
let v175 : UH1 = null |> unbox<UH1>
let v176 : (Mut1 -> Fable.Core.JSX.Element) = closure1()
let v177 : obj = v176
let v178 : string = "content"
let v179 : (string * obj) = v178, v177
let v180 : (Mut2 -> Fable.Core.JSX.Element) = closure377()
let v181 : obj = v180
let v182 : string = "db_listener"
let v183 : (string * obj) = v182, v181
let v184 : obj = v77
let v185 : string = "run_id"
let v186 : (string * obj) = v185, v184
let v187 : (unit -> obj) = closure391()
let v188 : obj = v187
let v189 : string = "new_state_context_any"
let v190 : (string * obj) = v189, v188
let v191 : string = "state_context"
let v192 : (string * obj) = v191, v173
let v193 : ((string * obj) []) = [|v179; v183; v186; v190; v192; v74|]
let v194 : obj = Fable.Core.JsInterop.createObj v193
Browser.Dom.window?components <- v194
v1.l0 <- v194
()
