#r "nuget: Feliz.JSX.Solid, 1.0.0-beta-001"
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
and Mut3 = {mutable l0 : int32}
and UH0 =
    | UH0_0 of (string * obj) * UH0
    | UH0_1
and [<Struct>] US15 =
    | US15_0
    | US15_1
    | US15_2
and Mut4 = {mutable l0 : US14; mutable l1 : US14; mutable l2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)); mutable l3 : US15}
and Mut5 = {mutable l0 : (unit -> bool); mutable l1 : (bool -> unit); mutable l2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6))}
and Mut6 = {mutable l0 : bool; mutable l1 : bool; mutable l2 : US14; mutable l3 : US14; mutable l4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6))}
and Mut7 = {mutable l0 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)); mutable l1 : (unit -> JS.Function); mutable l2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6))}
and Mut8 = {mutable l0 : (string -> obj); mutable l1 : (unit -> struct ((unit -> string) * (string -> unit))); mutable l2 : string}
and Mut9 = {mutable l0 : (int32 -> obj); mutable l1 : (unit -> struct ((unit -> int32) * (int32 -> unit))); mutable l2 : string}
and Mut10 = {mutable l0 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit))); mutable l2 : string}
and Mut11 = {mutable l0 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit))); mutable l2 : string}
and Mut12 = {mutable l0 : (US4 -> obj); mutable l1 : (unit -> struct ((unit -> US4) * (US4 -> unit))); mutable l2 : string}
and Mut13 = {mutable l0 : (US5 -> obj); mutable l1 : (unit -> struct ((unit -> US5) * (US5 -> unit))); mutable l2 : string}
and Mut14 = {mutable l0 : ((struct (int32 * int32) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit))); mutable l2 : string}
and Mut15 = {mutable l0 : ((struct (int32 * obj) []) -> obj); mutable l1 : (unit -> struct ((unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit))); mutable l2 : string}
and Mut16 = {mutable l0 : (unit -> US6); mutable l1 : (US6 -> unit)}
and Mut17 = {mutable l0 : (unit -> US5); mutable l1 : (US5 -> unit)}
and Mut18 = {mutable l0 : US3}
and Mut19 = {mutable l0 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) -> US6); mutable l1 : US3; mutable l2 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) -> (US6 -> struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string)))}
and Mut20 = {mutable l0 : int32; mutable l1 : US6}
and Mut21 = {mutable l0 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) -> US5); mutable l1 : US3; mutable l2 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) -> (US5 -> struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string)))}
and Mut22 = {mutable l0 : int32; mutable l1 : US5}
and Mut23 = {mutable l0 : int32; mutable l1 : int32}
and UH1 =
    | UH1_0 of int32 * int32 * UH1
    | UH1_1
and Mut24 = {mutable l0 : int32; mutable l1 : UH1}
and UH2 =
    | UH2_0 of int32 * obj * UH2
    | UH2_1
and Mut25 = {mutable l0 : int32; mutable l1 : UH2}
let rec method0 () : obj =
    let v0 : string = "createContext"
    let v1 : string = "solid-js"
    let v2 : JS.Function = import v0 v1
    let v3 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))) = fun () -> JS.undefined
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
and method3 () : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
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
and method5 (v0 : int32, v1 : Mut3) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure10 () () : (JSX.Element []) =
    [||]
and closure11 (v0 : (US4 -> unit)) (v1 : obj) : unit =
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
and closure15 (v0 : obj) () : (JSX.Element []) =
    let v1 : string = v0.ToString ()
    let v2 : JSX.Element = v1 |> unbox<JSX.Element>
    let v3 : JSX.Element = Html.fragment [ v2 ]
    [|v3|]
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
and closure14 () (v0 : obj) : (JSX.Element []) =
    let v1 : string = "SimpleOption"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US6, v5 : US6, v6 : US6, v7 : US7, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US8, v15 : US9, v16 : US6, v17 : US6, v18 : US8, v19 : US10, v20 : US6, v21 : US6, v22 : US6, v23 : US11, v24 : US8, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US13, v47 : US14, v48 : US13, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US12, v67 : US6, v68 : US6, v69 : US10, v70 : US10, v71 : US6, v72 : US5, v73 : US6) = method3()
    let v81 : US9 =
        match v15 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v75) -> (* Some *)
            let v76 : string = "children"
            let v77 : string = "solid-js"
            let v78 : JS.Function = import v76 v77
            let v79 : (unit -> (JSX.Element [])) = v78.Invoke v75 |> unbox<unit -> JSX.Element[]>
            US9_1(v79)
    let v84 : (unit -> (JSX.Element [])) =
        match v81 with
        | US9_0 -> (* None *)
            closure15(v0)
        | US9_1(v83) -> (* Some *)
            v83
    let v85 : US9 = US9_1(v84)
    let v86 : US10 = US10_1(v0)
    let v87 : ((string * obj) []) = method7(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v85, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v86, v70, v71, v72, v73)
    let v88 : obj = createObj v87
    let v89 : (unit -> (JSX.Element [])) = closure15(v0)
    emitJsExpr (v88, v89) "$0.children = $1"
    let v90 : (obj -> JSX.Element) = v3 |> unbox<(obj -> JSX.Element)>
    let v91 : string = "createComponent"
    let v92 : string = "solid-js"
    let v93 : JS.Function = import v91 v92
    let v94 : JSX.Element = v93.Invoke (v90, v88) |> unbox<JSX.Element>
    [|v94|]
and closure13 (v0 : Mut1) () : (JSX.Element []) =
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
    let v8 : (obj -> (JSX.Element [])) = closure14()
    let v9 : (unit -> (JSX.Element [])) = v8 |> unbox
    let struct (v10 : US6, v11 : US6, v12 : US6, v13 : US7, v14 : US6, v15 : US6, v16 : US6, v17 : US6, v18 : US6, v19 : US6, v20 : US8, v21 : US9, v22 : US6, v23 : US6, v24 : US8, v25 : US10, v26 : US6, v27 : US6, v28 : US6, v29 : US11, v30 : US8, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US12, v38 : US6, v39 : US6, v40 : US6, v41 : US12, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US13, v53 : US14, v54 : US13, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US6, v69 : US6, v70 : US6, v71 : US6, v72 : US12, v73 : US6, v74 : US6, v75 : US10, v76 : US10, v77 : US6, v78 : US5, v79 : US6) = method3()
    let v80 : (obj []) = v4 |> unbox<obj[]>
    let v87 : US9 =
        match v21 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v82) -> (* Some *)
            let v83 : string = "children"
            let v84 : JS.Function = import v83 v6
            let v85 : (unit -> (JSX.Element [])) = v84.Invoke v82 |> unbox<unit -> JSX.Element[]>
            US9_1(v85)
    let v89 : (unit -> (JSX.Element [])) =
        match v87 with
        | US9_0 -> (* None *)
            v9
        | US9_1(v88) -> (* Some *)
            v88
    let v90 : US9 = US9_1(v89)
    let v91 : US11 = US11_1(v80)
    let v92 : ((string * obj) []) = method7(v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v90, v22, v23, v24, v25, v26, v27, v28, v91, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79)
    let v93 : obj = createObj v92
    emitJsExpr (v93, v9) "$0.children = $1"
    let v94 : (obj -> JSX.Element) = v7 |> unbox<(obj -> JSX.Element)>
    let v95 : string = "createComponent"
    let v96 : JS.Function = import v95 v6
    let v97 : JSX.Element = v96.Invoke (v94, v93) |> unbox<JSX.Element>
    [|v97|]
and method6 (v0 : Mut1) : JSX.Element =
    let v1 : string = "SimpleSelect"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US6, v5 : US6, v6 : US6, v7 : US7, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US8, v15 : US9, v16 : US6, v17 : US6, v18 : US8, v19 : US10, v20 : US6, v21 : US6, v22 : US6, v23 : US11, v24 : US8, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US13, v47 : US14, v48 : US13, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US12, v67 : US6, v68 : US6, v69 : US10, v70 : US10, v71 : US6, v72 : US5, v73 : US6) = method3()
    let v74 : US6 = v0.l37
    let v75 : US6 = v0.l54
    let v76 : US13 = v0.l42
    let v77 : US10 = v0.l65
    let v85 : US9 =
        match v15 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v79) -> (* Some *)
            let v80 : string = "children"
            let v81 : string = "solid-js"
            let v82 : JS.Function = import v80 v81
            let v83 : (unit -> (JSX.Element [])) = v82.Invoke v79 |> unbox<unit -> JSX.Element[]>
            US9_1(v83)
    let v88 : (unit -> (JSX.Element [])) =
        match v85 with
        | US9_0 -> (* None *)
            closure13(v0)
        | US9_1(v87) -> (* Some *)
            v87
    let v89 : US9 = US9_1(v88)
    let v90 : string = "xs"
    let v91 : US6 = US6_1(v90)
    let v92 : ((string * obj) []) = method7(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v89, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v74, v42, v43, v44, v45, v76, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v75, v59, v60, v91, v62, v63, v64, v65, v66, v67, v68, v77, v70, v71, v72, v73)
    let v93 : obj = createObj v92
    let v94 : (unit -> (JSX.Element [])) = closure13(v0)
    emitJsExpr (v93, v94) "$0.children = $1"
    let v95 : (obj -> JSX.Element) = v3 |> unbox<(obj -> JSX.Element)>
    let v96 : string = "createComponent"
    let v97 : string = "solid-js"
    let v98 : JS.Function = import v96 v97
    let v99 : JSX.Element = v98.Invoke (v95, v93) |> unbox<JSX.Element>
    v99
and closure12 () (v0 : Mut1) : JSX.Element =
    method6(v0)
and closure9 (v0 : (US4 -> unit), v1 : (unit -> US4)) () : (JSX.Element []) =
    let struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) = method3()
    let v72 : US4 = US4_0
    let v73 : US4 = US4_2
    let v74 : US4 = US4_3
    let v75 : US4 = US4_1
    let v76 : (US4 []) = [|v72; v73; v74; v75|]
    let v77 : int32 = v76.Length
    let v78 : (string []) = Array.zeroCreate<string> (v77)
    let v79 : Mut3 = {l0 = 0} : Mut3
    while method5(v77, v79) do
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
    let v91 : Mut3 = {l0 = 0} : Mut3
    while method5(v89, v91) do
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
    let v111 : US9 =
        match v13 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v105) -> (* Some *)
            let v106 : string = "children"
            let v107 : string = "solid-js"
            let v108 : JS.Function = import v106 v107
            let v109 : (unit -> (JSX.Element [])) = v108.Invoke v105 |> unbox<unit -> JSX.Element[]>
            US9_1(v109)
    let v114 : (unit -> (JSX.Element [])) =
        match v111 with
        | US9_0 -> (* None *)
            closure10()
        | US9_1(v113) -> (* Some *)
            v113
    let v115 : US9 = US9_1(v114)
    let v116 : US11 = US11_1(v90)
    let v117 : string = "2px"
    let v118 : US6 = US6_1(v117)
    let v119 : (obj -> unit) = closure11(v0)
    let v120 : US13 = US13_1(v119)
    let v121 : US10 = US10_1(v103)
    let v122 : Mut1 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v115; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v116; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v118; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v120; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66; l65 = v121; l66 = v68; l67 = v69; l68 = v70; l69 = v71} : Mut1
    let v123 : (unit -> (JSX.Element [])) = closure10()
    emitJsExpr (v122, v123) "$0.children = $1"
    let v124 : string = "createComponent"
    let v125 : string = "solid-js"
    let v126 : JS.Function = import v124 v125
    let v127 : (Mut1 -> JSX.Element) = closure12()
    let v128 : JSX.Element = v126.Invoke (v127, v122) |> unbox<JSX.Element>
    [|v128|]
and closure8 (v0 : (US4 -> unit), v1 : (unit -> US4)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = "Log Level"
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure9(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v77, v65, v66, v67, v68, v69, v70, v71)
and method12 (v0 : string, v1 : string) : string =
    let v2 : string = {| ``@initial`` = v1; ``@sm`` = v0 |} |> unbox<string>
    v2
and closure21 (v0 : JSX.Element) () : (JSX.Element []) =
    [|v0|]
and closure20 (v0 : JSX.Element) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (unit -> (JSX.Element [])) = closure21(v0)
    let v72 : US9 = US9_1(v71)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v72, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure24 () () : (JSX.Element []) =
    [||]
and closure23 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) () : (JSX.Element []) =
    let v70 : string = "Box"
    let v71 : string = "@hope-ui/solid"
    let v72 : JS.Function = import v70 v71
    let v75 : (unit -> (JSX.Element [])) =
        match v11 with
        | US9_0 -> (* None *)
            closure24()
        | US9_1(v74) -> (* Some *)
            v74
    let struct (v76 : US6, v77 : US6, v78 : US6, v79 : US7, v80 : US6, v81 : US6, v82 : US6, v83 : US6, v84 : US6, v85 : US6, v86 : US8, v87 : US9, v88 : US6, v89 : US6, v90 : US8, v91 : US10, v92 : US6, v93 : US6, v94 : US6, v95 : US11, v96 : US8, v97 : US6, v98 : US6, v99 : US6, v100 : US6, v101 : US6, v102 : US6, v103 : US12, v104 : US6, v105 : US6, v106 : US6, v107 : US12, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US6, v115 : US6, v116 : US6, v117 : US6, v118 : US13, v119 : US14, v120 : US13, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US6, v135 : US6, v136 : US6, v137 : US6, v138 : US12, v139 : US6, v140 : US6, v141 : US10, v142 : US10, v143 : US6, v144 : US5, v145 : US6) = method3()
    let v153 : US9 =
        match v87 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v147) -> (* Some *)
            let v148 : string = "children"
            let v149 : string = "solid-js"
            let v150 : JS.Function = import v148 v149
            let v151 : (unit -> (JSX.Element [])) = v150.Invoke v147 |> unbox<unit -> JSX.Element[]>
            US9_1(v151)
    let v155 : (unit -> (JSX.Element [])) =
        match v153 with
        | US9_0 -> (* None *)
            v75
        | US9_1(v154) -> (* Some *)
            v154
    let v156 : US9 = US9_1(v155)
    let v157 : string = "2px"
    let v158 : US6 = US6_1(v157)
    let v159 : ((string * obj) []) = method7(v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v156, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v158, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v143, v144, v145)
    let v160 : obj = createObj v159
    emitJsExpr (v160, v75) "$0.children = $1"
    let v161 : (obj -> JSX.Element) = v72 |> unbox<(obj -> JSX.Element)>
    let v162 : string = "createComponent"
    let v163 : string = "solid-js"
    let v164 : JS.Function = import v162 v163
    let v165 : JSX.Element = v164.Invoke (v161, v160) |> unbox<JSX.Element>
    [|v165|]
and closure25 (v0 : Mut5) (v1 : obj) : unit =
    let v2 : bool = v1?target?checked
    let v3 : (bool -> unit) = v0.l1
    v3 v2
    ()
and closure22 () (v0 : Mut5) : JSX.Element =
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = v0.l2
    let struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) = method3()
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
    let struct (v153 : US6, v154 : US6, v155 : US6, v156 : US7, v157 : US6, v158 : US6, v159 : US6, v160 : US6, v161 : US6, v162 : US6, v163 : US8, v164 : US9, v165 : US6, v166 : US6, v167 : US8, v168 : US10, v169 : US6, v170 : US6, v171 : US6, v172 : US11, v173 : US8, v174 : US6, v175 : US6, v176 : US6, v177 : US6, v178 : US6, v179 : US6, v180 : US12, v181 : US6, v182 : US6, v183 : US6, v184 : US12, v185 : US6, v186 : US6, v187 : US6, v188 : US6, v189 : US6, v190 : US6, v191 : US6, v192 : US6, v193 : US6, v194 : US6, v195 : US13, v196 : US14, v197 : US13, v198 : US6, v199 : US6, v200 : US6, v201 : US6, v202 : US6, v203 : US6, v204 : US6, v205 : US6, v206 : US6, v207 : US6, v208 : US6, v209 : US6, v210 : US6, v211 : US6, v212 : US6, v213 : US6, v214 : US6, v215 : US12, v216 : US6, v217 : US6, v218 : US10, v219 : US10, v220 : US6, v221 : US5, v222 : US6) = method3()
    let v223 : (unit -> bool) = v0.l0
    let v224 : bool = v223 ()
    let v232 : US9 =
        match v164 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v226) -> (* Some *)
            let v227 : string = "children"
            let v228 : string = "solid-js"
            let v229 : JS.Function = import v227 v228
            let v230 : (unit -> (JSX.Element [])) = v229.Invoke v226 |> unbox<unit -> JSX.Element[]>
            US9_1(v230)
    let v235 : (unit -> (JSX.Element [])) =
        match v232 with
        | US9_0 -> (* None *)
            closure23(v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141)
        | US9_1(v234) -> (* Some *)
            v234
    let v236 : US8 = US8_1(v224)
    let v237 : US9 = US9_1(v235)
    let v238 : string = "neutral"
    let v239 : US6 = US6_1(v238)
    let v240 : string = "3px"
    let v241 : US6 = US6_1(v240)
    let v242 : (obj -> unit) = closure25(v0)
    let v243 : US13 = US13_1(v242)
    let v244 : string = "sm"
    let v245 : US6 = US6_1(v244)
    let v246 : ((string * obj) []) = method7(v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v236, v237, v165, v239, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v241, v191, v192, v193, v194, v243, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v245, v211, v212, v213, v214, v215, v216, v217, v218, v219, v220, v221, v222)
    let v247 : obj = createObj v246
    let v248 : (unit -> (JSX.Element [])) = closure23(v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141)
    emitJsExpr (v247, v248) "$0.children = $1"
    let v249 : (obj -> JSX.Element) = v152 |> unbox<(obj -> JSX.Element)>
    let v250 : string = "createComponent"
    let v251 : string = "solid-js"
    let v252 : JS.Function = import v250 v251
    let v253 : JSX.Element = v252.Invoke (v249, v247) |> unbox<JSX.Element>
    v253
and closure19 (v0 : Mut4, v1 : (bool -> unit), v2 : (unit -> bool), v3 : JSX.Element) () : (JSX.Element []) =
    let v4 : US15 = v0.l3
    let v19 : JSX.Element =
        match v4 with
        | US15_0 -> (* CheckDisabled *)
            let v5 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure20(v3)
            let v6 : Mut5 = {l0 = v2; l1 = v1; l2 = v5} : Mut5
            let v7 : string = "createComponent"
            let v8 : string = "solid-js"
            let v9 : JS.Function = import v7 v8
            let v10 : (Mut5 -> JSX.Element) = closure22()
            let v11 : JSX.Element = v9.Invoke (v10, v6) |> unbox<JSX.Element>
            v11
        | US15_1 -> (* CheckEnabled *)
            let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure20(v3)
            let v13 : Mut5 = {l0 = v2; l1 = v1; l2 = v12} : Mut5
            let v14 : string = "createComponent"
            let v15 : string = "solid-js"
            let v16 : JS.Function = import v14 v15
            let v17 : (Mut5 -> JSX.Element) = closure22()
            let v18 : JSX.Element = v16.Invoke (v17, v13) |> unbox<JSX.Element>
            v18
        | US15_2 -> (* CheckHidden *)
            v3
    [|v19|]
and closure18 (v0 : Mut4, v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6, v71 : (bool -> unit), v72 : (unit -> bool), v73 : JSX.Element) () : (JSX.Element []) =
    let v74 : string = "Box"
    let v75 : string = "@hope-ui/solid"
    let v76 : JS.Function = import v74 v75
    let struct (v77 : US6, v78 : US6, v79 : US6, v80 : US7, v81 : US6, v82 : US6, v83 : US6, v84 : US6, v85 : US6, v86 : US6, v87 : US8, v88 : US9, v89 : US6, v90 : US6, v91 : US8, v92 : US10, v93 : US6, v94 : US6, v95 : US6, v96 : US11, v97 : US8, v98 : US6, v99 : US6, v100 : US6, v101 : US6, v102 : US6, v103 : US6, v104 : US12, v105 : US6, v106 : US6, v107 : US6, v108 : US12, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US6, v115 : US6, v116 : US6, v117 : US6, v118 : US6, v119 : US13, v120 : US14, v121 : US13, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US6, v135 : US6, v136 : US6, v137 : US6, v138 : US6, v139 : US12, v140 : US6, v141 : US6, v142 : US10, v143 : US10, v144 : US6, v145 : US5, v146 : US6) = method3()
    let v149 : string =
        match v52 with
        | US6_0 -> (* None *)
            let v147 : string = "8px"
            v147
        | US6_1(v148) -> (* Some *)
            v148
    let v157 : US9 =
        match v88 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v151) -> (* Some *)
            let v152 : string = "children"
            let v153 : string = "solid-js"
            let v154 : JS.Function = import v152 v153
            let v155 : (unit -> (JSX.Element [])) = v154.Invoke v151 |> unbox<unit -> JSX.Element[]>
            US9_1(v155)
    let v160 : (unit -> (JSX.Element [])) =
        match v157 with
        | US9_0 -> (* None *)
            closure19(v0, v71, v72, v73)
        | US9_1(v159) -> (* Some *)
            v159
    let v161 : US9 = US9_1(v160)
    let v162 : US6 = US6_1(v149)
    let v163 : ((string * obj) []) = method7(v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v161, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v162, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v143, v144, v145, v146)
    let v164 : obj = createObj v163
    let v165 : (unit -> (JSX.Element [])) = closure19(v0, v71, v72, v73)
    emitJsExpr (v164, v165) "$0.children = $1"
    let v166 : (obj -> JSX.Element) = v76 |> unbox<(obj -> JSX.Element)>
    let v167 : string = "createComponent"
    let v168 : string = "solid-js"
    let v169 : JS.Function = import v167 v168
    let v170 : JSX.Element = v169.Invoke (v166, v164) |> unbox<JSX.Element>
    [|v170|]
and closure26 () () : (JSX.Element []) =
    let v0 : string = "&nbsp;"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure28 (v0 : (unit -> (JSX.Element []))) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : US9 = US9_1(v0)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v71, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure30 (v0 : int32, v1 : (unit -> string), v2 : (unit -> US4), v3 : (unit -> US5)) () : (obj []) =
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
and method16 (v0 : int32, v1 : string) : string =
    let v2 : int32 = String.length v1
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : string = $"0{v1}"
        method16(v0, v4)
    else
        v1
and closure32 (v0 : (unit -> US4), v1 : (unit -> (obj [])), v2 : string, v3 : string, v4 : obj, v5 : string, v6 : string, v7 : bool, v8 : int64, v9 : US4) (v10 : (obj [])) : unit =
    let v11 : US4 = v0 ()
    let v12 : int32 = (fst (Reflection.FSharpValue.GetUnionFields(v11, typeof<US4>))).Tag
    let v13 : int32 = (fst (Reflection.FSharpValue.GetUnionFields(v9, typeof<US4>))).Tag
    let v14 : bool = v12 <= v13
    if v14 then
        let v15 : int64 = DateTime.UtcNow.Ticks / 1000L
        let v16 : int64 = v15 - v8
        let v17 : string = v16.ToString ()
        let v18 : int32 = 6
        let v19 : string = method16(v18, v17)
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
and closure31 (v0 : (unit -> US4), v1 : (unit -> (obj [])), v2 : string, v3 : string, v4 : obj, v5 : string, v6 : string, v7 : bool, v8 : int64) (v9 : US4) : ((obj []) -> unit) =
    closure32(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9)
and method15 (v0 : (unit -> US4), v1 : (unit -> (obj [])), v2 : string) : (US4 -> ((obj []) -> unit)) =
    let struct (v3 : string, v4 : obj, v5 : string, v6 : string, v7 : bool) = method2()
    let v8 : int64 = DateTime.UtcNow.Ticks / 1000L
    closure31(v0, v1, v2, v3, v4, v5, v6, v7, v8)
and method14 (v0 : (unit -> (obj [])), v1 : string) : (US4 -> ((obj []) -> unit)) =
    let v125 : obj = emitJsExpr () "components_spi.state_context"
    let v126 : string = "useContext"
    let v127 : string = "solid-js"
    let v128 : JS.Function = import v126 v127
    let struct (v129 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v130 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v131 : (unit -> int32), v132 : (int32 -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> string), v136 : (string -> unit), v137 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v138 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v139 : (unit -> (struct (US2 * (int32 [])) [])), v140 : ((struct (US2 * (int32 [])) []) -> unit), v141 : (unit -> (struct (int32 * obj) [])), v142 : ((struct (int32 * obj) []) -> unit), v143 : (unit -> (struct (int32 * obj) [])), v144 : ((struct (int32 * obj) []) -> unit), v145 : (unit -> (struct (int32 * int32) [])), v146 : ((struct (int32 * int32) []) -> unit), v147 : (unit -> US4), v148 : (US4 -> unit), v149 : (unit -> US5), v150 : (US5 -> unit)) = v128.Invoke v125 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    method15(v147, v0, v1)
and closure33 (v0 : Mut6, v1 : int32, v2 : (US5 -> unit)) () : unit =
    let v3 : bool = v0.l1
    if v3 then
        let v4 : US5 = US5_1(v1)
        v2 v4
        ()
and method17 (v0 : (unit -> unit)) : unit =
    let v1 : string = "createEffect"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    v3.Invoke v0 |> ignore
    ()
and closure34 (v0 : (bool -> unit), v1 : (unit -> bool)) () : unit =
    let v2 : bool = v1 ()
    if v2 then
        v0 false
        ()
and closure35 (v0 : Mut6) () : unit =
    let v1 : US14 = v0.l3
    match v1 with
    | US14_0 -> (* None *)
        ()
    | US14_1(v2) -> (* Some *)
        v2 ()
        ()
and method18 (v0 : (unit -> unit)) : unit =
    let v1 : string = "onCleanup"
    let v2 : string = "solid-js"
    let v3 : JS.Function = import v1 v2
    v3.Invoke v0 |> ignore
    ()
and closure38 () () : (JSX.Element []) =
    let v0 : string = "Load"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure39 (v0 : (bool -> unit), v1 : Mut6) () : unit =
    let v2 : US14 = v1.l2
    match v2 with
    | US14_0 -> (* None *)
        ()
    | US14_1(v3) -> (* Some *)
        v3 ()
        ()
    v0 true
    ()
and closure41 () () : (JSX.Element []) =
    [||]
and method20 (v0 : Mut1, v1 : Mut1) : unit =
    let v2 : (string []) = JS.Constructors.Object.keys v0 |> unbox<string[]>
    let v3 : int32 = v2.Length
    let v4 : Mut3 = {l0 = 0} : Mut3
    while method5(v3, v4) do
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
and method19 (v0 : Mut1) : JSX.Element =
    let v1 : string = "Button"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : US9 = v0.l11
    let v7 : (unit -> (JSX.Element [])) =
        match v4 with
        | US9_0 -> (* None *)
            closure41()
        | US9_1(v6) -> (* Some *)
            v6
    let struct (v8 : US6, v9 : US6, v10 : US6, v11 : US7, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US6, v17 : US6, v18 : US8, v19 : US9, v20 : US6, v21 : US6, v22 : US8, v23 : US10, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US8, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US12, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US13, v51 : US14, v52 : US13, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US6, v69 : US6, v70 : US12, v71 : US6, v72 : US6, v73 : US10, v74 : US10, v75 : US6, v76 : US5, v77 : US6) = method3()
    let struct (v78 : US6, v79 : US6, v80 : US6, v81 : US7, v82 : US6, v83 : US6, v84 : US6, v85 : US6, v86 : US6, v87 : US6, v88 : US8, v89 : US9, v90 : US6, v91 : US6, v92 : US8, v93 : US10, v94 : US6, v95 : US6, v96 : US6, v97 : US11, v98 : US8, v99 : US6, v100 : US6, v101 : US6, v102 : US6, v103 : US6, v104 : US6, v105 : US12, v106 : US6, v107 : US6, v108 : US6, v109 : US12, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US6, v115 : US6, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US13, v121 : US14, v122 : US13, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US6, v135 : US6, v136 : US6, v137 : US6, v138 : US6, v139 : US6, v140 : US12, v141 : US6, v142 : US6, v143 : US10, v144 : US10, v145 : US6, v146 : US5, v147 : US6) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61, v0.l62, v0.l63, v0.l64, v0.l65, v0.l66, v0.l67, v0.l68, v0.l69
    let v148 : Mut1 = {l0 = v78; l1 = v79; l2 = v80; l3 = v81; l4 = v82; l5 = v83; l6 = v84; l7 = v85; l8 = v86; l9 = v87; l10 = v88; l11 = v89; l12 = v90; l13 = v91; l14 = v92; l15 = v93; l16 = v94; l17 = v95; l18 = v96; l19 = v97; l20 = v98; l21 = v99; l22 = v100; l23 = v101; l24 = v102; l25 = v103; l26 = v104; l27 = v105; l28 = v106; l29 = v107; l30 = v108; l31 = v109; l32 = v110; l33 = v111; l34 = v112; l35 = v113; l36 = v114; l37 = v115; l38 = v116; l39 = v117; l40 = v118; l41 = v119; l42 = v120; l43 = v121; l44 = v122; l45 = v123; l46 = v124; l47 = v125; l48 = v126; l49 = v127; l50 = v128; l51 = v129; l52 = v130; l53 = v131; l54 = v132; l55 = v133; l56 = v134; l57 = v135; l58 = v136; l59 = v137; l60 = v138; l61 = v139; l62 = v140; l63 = v141; l64 = v142; l65 = v143; l66 = v144; l67 = v145; l68 = v146; l69 = v147} : Mut1
    let v149 : string = "neutral"
    let v150 : US6 = US6_1(v149)
    let v151 : US8 = US8_1(true)
    let v152 : string = "left"
    let v153 : US6 = US6_1(v152)
    let v154 : string = "xs"
    let v155 : US6 = US6_1(v154)
    let v156 : Mut1 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v18; l11 = v19; l12 = v20; l13 = v150; l14 = v151; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v34; l27 = v35; l28 = v36; l29 = v153; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50; l43 = v51; l44 = v52; l45 = v53; l46 = v54; l47 = v55; l48 = v56; l49 = v57; l50 = v58; l51 = v59; l52 = v60; l53 = v61; l54 = v62; l55 = v63; l56 = v64; l57 = v155; l58 = v66; l59 = v67; l60 = v68; l61 = v69; l62 = v70; l63 = v71; l64 = v72; l65 = v73; l66 = v74; l67 = v75; l68 = v76; l69 = v77} : Mut1
    method20(v156, v148)
    let struct (v157 : US6, v158 : US6, v159 : US6, v160 : US7, v161 : US6, v162 : US6, v163 : US6, v164 : US6, v165 : US6, v166 : US6, v167 : US8, v168 : US9, v169 : US6, v170 : US6, v171 : US8, v172 : US10, v173 : US6, v174 : US6, v175 : US6, v176 : US11, v177 : US8, v178 : US6, v179 : US6, v180 : US6, v181 : US6, v182 : US6, v183 : US6, v184 : US12, v185 : US6, v186 : US6, v187 : US6, v188 : US12, v189 : US6, v190 : US6, v191 : US6, v192 : US6, v193 : US6, v194 : US6, v195 : US6, v196 : US6, v197 : US6, v198 : US6, v199 : US13, v200 : US14, v201 : US13, v202 : US6, v203 : US6, v204 : US6, v205 : US6, v206 : US6, v207 : US6, v208 : US6, v209 : US6, v210 : US6, v211 : US6, v212 : US6, v213 : US6, v214 : US6, v215 : US6, v216 : US6, v217 : US6, v218 : US6, v219 : US12, v220 : US6, v221 : US6, v222 : US10, v223 : US10, v224 : US6, v225 : US5, v226 : US6) = v156.l0, v156.l1, v156.l2, v156.l3, v156.l4, v156.l5, v156.l6, v156.l7, v156.l8, v156.l9, v156.l10, v156.l11, v156.l12, v156.l13, v156.l14, v156.l15, v156.l16, v156.l17, v156.l18, v156.l19, v156.l20, v156.l21, v156.l22, v156.l23, v156.l24, v156.l25, v156.l26, v156.l27, v156.l28, v156.l29, v156.l30, v156.l31, v156.l32, v156.l33, v156.l34, v156.l35, v156.l36, v156.l37, v156.l38, v156.l39, v156.l40, v156.l41, v156.l42, v156.l43, v156.l44, v156.l45, v156.l46, v156.l47, v156.l48, v156.l49, v156.l50, v156.l51, v156.l52, v156.l53, v156.l54, v156.l55, v156.l56, v156.l57, v156.l58, v156.l59, v156.l60, v156.l61, v156.l62, v156.l63, v156.l64, v156.l65, v156.l66, v156.l67, v156.l68, v156.l69
    let v234 : US9 =
        match v168 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v228) -> (* Some *)
            let v229 : string = "children"
            let v230 : string = "solid-js"
            let v231 : JS.Function = import v229 v230
            let v232 : (unit -> (JSX.Element [])) = v231.Invoke v228 |> unbox<unit -> JSX.Element[]>
            US9_1(v232)
    let v236 : (unit -> (JSX.Element [])) =
        match v234 with
        | US9_0 -> (* None *)
            v7
        | US9_1(v235) -> (* Some *)
            v235
    let v237 : US9 = US9_1(v236)
    let v238 : ((string * obj) []) = method7(v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v237, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v220, v221, v222, v223, v224, v225, v226)
    let v239 : obj = createObj v238
    emitJsExpr (v239, v7) "$0.children = $1"
    let v240 : (obj -> JSX.Element) = v3 |> unbox<(obj -> JSX.Element)>
    let v241 : string = "createComponent"
    let v242 : string = "solid-js"
    let v243 : JS.Function = import v241 v242
    let v244 : JSX.Element = v243.Invoke (v240, v239) |> unbox<JSX.Element>
    v244
and closure40 () (v0 : Mut1) : JSX.Element =
    method19(v0)
and closure37 (v0 : (bool -> unit), v1 : Mut6) () : (JSX.Element []) =
    let struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) = method3()
    let v79 : US9 =
        match v13 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v73) -> (* Some *)
            let v74 : string = "children"
            let v75 : string = "solid-js"
            let v76 : JS.Function = import v74 v75
            let v77 : (unit -> (JSX.Element [])) = v76.Invoke v73 |> unbox<unit -> JSX.Element[]>
            US9_1(v77)
    let v82 : (unit -> (JSX.Element [])) =
        match v79 with
        | US9_0 -> (* None *)
            closure38()
        | US9_1(v81) -> (* Some *)
            v81
    let v83 : US9 = US9_1(v82)
    let v84 : (unit -> unit) = closure39(v0, v1)
    let v85 : US14 = US14_1(v84)
    let v86 : Mut1 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v83; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v85; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66; l65 = v67; l66 = v68; l67 = v69; l68 = v70; l69 = v71} : Mut1
    let v87 : (unit -> (JSX.Element [])) = closure38()
    emitJsExpr (v86, v87) "$0.children = $1"
    let v88 : string = "createComponent"
    let v89 : string = "solid-js"
    let v90 : JS.Function = import v88 v89
    let v91 : (Mut1 -> JSX.Element) = closure40()
    let v92 : JSX.Element = v90.Invoke (v91, v86) |> unbox<JSX.Element>
    [|v92|]
and closure45 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure46 () () : JS.Function =
    let v0 : string = "BiRegularRefresh"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure48 () () : (JSX.Element []) =
    [||]
and method21 (v0 : Mut7) : JSX.Element =
    let v1 : string = "Icon"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US6, v5 : US6, v6 : US6, v7 : US7, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US8, v15 : US9, v16 : US6, v17 : US6, v18 : US8, v19 : US10, v20 : US6, v21 : US6, v22 : US6, v23 : US11, v24 : US8, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US13, v47 : US14, v48 : US13, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US12, v67 : US6, v68 : US6, v69 : US10, v70 : US10, v71 : US6, v72 : US5, v73 : US6) = method3()
    let v74 : (unit -> JS.Function) = v0.l1
    let v75 : JS.Function = v74 ()
    let struct (v76 : US6, v77 : US6, v78 : US6, v79 : US7, v80 : US6, v81 : US6, v82 : US6, v83 : US6, v84 : US6, v85 : US6, v86 : US8, v87 : US9, v88 : US6, v89 : US6, v90 : US8, v91 : US10, v92 : US6, v93 : US6, v94 : US6, v95 : US11, v96 : US8, v97 : US6, v98 : US6, v99 : US6, v100 : US6, v101 : US6, v102 : US6, v103 : US12, v104 : US6, v105 : US6, v106 : US6, v107 : US12, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US6, v115 : US6, v116 : US6, v117 : US6, v118 : US13, v119 : US14, v120 : US13, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US6, v135 : US6, v136 : US6, v137 : US6, v138 : US12, v139 : US6, v140 : US6, v141 : US10, v142 : US10, v143 : US6, v144 : US5, v145 : US6) = method3()
    let v153 : US9 =
        match v87 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v147) -> (* Some *)
            let v148 : string = "children"
            let v149 : string = "solid-js"
            let v150 : JS.Function = import v148 v149
            let v151 : (unit -> (JSX.Element [])) = v150.Invoke v147 |> unbox<unit -> JSX.Element[]>
            US9_1(v151)
    let v154 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = v0.l0
    let v155 : string = "-12px"
    let v156 : US6 = US6_1(v155)
    let v157 : US6 = US6_1(v155)
    let v158 : string = "0.6"
    let v159 : US6 = US6_1(v158)
    let struct (v160 : US6, v161 : US6, v162 : US6, v163 : US7, v164 : US6, v165 : US6, v166 : US6, v167 : US6, v168 : US6, v169 : US6, v170 : US8, v171 : US9, v172 : US6, v173 : US6, v174 : US8, v175 : US10, v176 : US6, v177 : US6, v178 : US6, v179 : US11, v180 : US8, v181 : US6, v182 : US6, v183 : US6, v184 : US6, v185 : US6, v186 : US6, v187 : US12, v188 : US6, v189 : US6, v190 : US6, v191 : US12, v192 : US6, v193 : US6, v194 : US6, v195 : US6, v196 : US6, v197 : US6, v198 : US6, v199 : US6, v200 : US6, v201 : US6, v202 : US13, v203 : US14, v204 : US13, v205 : US6, v206 : US6, v207 : US6, v208 : US6, v209 : US6, v210 : US6, v211 : US6, v212 : US6, v213 : US6, v214 : US6, v215 : US6, v216 : US6, v217 : US6, v218 : US6, v219 : US6, v220 : US6, v221 : US6, v222 : US12, v223 : US6, v224 : US6, v225 : US10, v226 : US10, v227 : US6, v228 : US5, v229 : US6) = v154 struct (v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v153, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v156, v112, v157, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v143, v144, v159)
    let v230 : ((string * obj) []) = method7(v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v220, v221, v222, v223, v224, v225, v226, v227, v228, v229)
    let v231 : obj = createObj v230
    let v232 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = v0.l2
    let v233 : US7 = US7_1(v75)
    let v234 : US10 = US10_1(v231)
    let v235 : string = "14px"
    let v236 : US6 = US6_1(v235)
    let struct (v237 : US6, v238 : US6, v239 : US6, v240 : US7, v241 : US6, v242 : US6, v243 : US6, v244 : US6, v245 : US6, v246 : US6, v247 : US8, v248 : US9, v249 : US6, v250 : US6, v251 : US8, v252 : US10, v253 : US6, v254 : US6, v255 : US6, v256 : US11, v257 : US8, v258 : US6, v259 : US6, v260 : US6, v261 : US6, v262 : US6, v263 : US6, v264 : US12, v265 : US6, v266 : US6, v267 : US6, v268 : US12, v269 : US6, v270 : US6, v271 : US6, v272 : US6, v273 : US6, v274 : US6, v275 : US6, v276 : US6, v277 : US6, v278 : US6, v279 : US13, v280 : US14, v281 : US13, v282 : US6, v283 : US6, v284 : US6, v285 : US6, v286 : US6, v287 : US6, v288 : US6, v289 : US6, v290 : US6, v291 : US6, v292 : US6, v293 : US6, v294 : US6, v295 : US6, v296 : US6, v297 : US6, v298 : US6, v299 : US12, v300 : US6, v301 : US6, v302 : US10, v303 : US10, v304 : US6, v305 : US5, v306 : US6) = v232 struct (v4, v5, v6, v233, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v234, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v236, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73)
    let v314 : US9 =
        match v248 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v308) -> (* Some *)
            let v309 : string = "children"
            let v310 : string = "solid-js"
            let v311 : JS.Function = import v309 v310
            let v312 : (unit -> (JSX.Element [])) = v311.Invoke v308 |> unbox<unit -> JSX.Element[]>
            US9_1(v312)
    let v317 : (unit -> (JSX.Element [])) =
        match v314 with
        | US9_0 -> (* None *)
            closure48()
        | US9_1(v316) -> (* Some *)
            v316
    let v318 : US9 = US9_1(v317)
    let v319 : ((string * obj) []) = method7(v237, v238, v239, v240, v241, v242, v243, v244, v245, v246, v247, v318, v249, v250, v251, v252, v253, v254, v255, v256, v257, v258, v259, v260, v261, v262, v263, v264, v265, v266, v267, v268, v269, v270, v271, v272, v273, v274, v275, v276, v277, v278, v279, v280, v281, v282, v283, v284, v285, v286, v287, v288, v289, v290, v291, v292, v293, v294, v295, v296, v297, v298, v299, v300, v301, v302, v303, v304, v305, v306)
    let v320 : obj = createObj v319
    let v321 : (unit -> (JSX.Element [])) = closure48()
    emitJsExpr (v320, v321) "$0.children = $1"
    let v322 : (obj -> JSX.Element) = v3 |> unbox<(obj -> JSX.Element)>
    let v323 : string = "createComponent"
    let v324 : string = "solid-js"
    let v325 : JS.Function = import v323 v324
    let v326 : JSX.Element = v325.Invoke (v322, v320) |> unbox<JSX.Element>
    v326
and closure47 () (v0 : Mut7) : JSX.Element =
    method21(v0)
and closure49 () () : (JSX.Element []) =
    [||]
and closure50 (v0 : (bool -> unit)) () : unit =
    v0 true
    ()
and closure51 () () : JS.Function =
    let v0 : string = "BiRegularDownArrow"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure52 () () : JS.Function =
    let v0 : string = "BiRegularUpArrow"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure53 () () : (JSX.Element []) =
    [||]
and closure54 (v0 : int32, v1 : (US5 -> unit), v2 : (unit -> US5)) () : unit =
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
and closure55 () () : JS.Function =
    let v0 : string = "BiRegularUndo"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure56 () () : (JSX.Element []) =
    [||]
and closure57 (v0 : (bool -> unit), v1 : Mut6) () : unit =
    let v2 : US14 = v1.l3
    match v2 with
    | US14_0 -> (* None *)
        ()
    | US14_1(v3) -> (* Some *)
        v3 ()
        ()
    v0 false
    ()
and closure44 (v0 : int32, v1 : (US5 -> unit), v2 : (bool -> unit), v3 : (bool -> unit), v4 : Mut6, v5 : (unit -> US5)) () : (JSX.Element []) =
    let v6 : string = "IconButton"
    let v7 : string = "@hope-ui/solid"
    let v8 : JS.Function = import v6 v7
    let struct (v9 : US6, v10 : US6, v11 : US6, v12 : US7, v13 : US6, v14 : US6, v15 : US6, v16 : US6, v17 : US6, v18 : US6, v19 : US8, v20 : US9, v21 : US6, v22 : US6, v23 : US8, v24 : US10, v25 : US6, v26 : US6, v27 : US6, v28 : US11, v29 : US8, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US12, v37 : US6, v38 : US6, v39 : US6, v40 : US12, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US13, v52 : US14, v53 : US13, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US6, v69 : US6, v70 : US6, v71 : US12, v72 : US6, v73 : US6, v74 : US10, v75 : US10, v76 : US6, v77 : US5, v78 : US6) = method3()
    let v79 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure45()
    let v80 : (unit -> JS.Function) = closure46()
    let v81 : Mut7 = {l0 = v79; l1 = v80; l2 = v79} : Mut7
    let v82 : string = "createComponent"
    let v83 : string = "solid-js"
    let v84 : JS.Function = import v82 v83
    let v85 : (Mut7 -> JSX.Element) = closure47()
    let v86 : JSX.Element = v84.Invoke (v85, v81) |> unbox<JSX.Element>
    let v93 : US9 =
        match v20 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v88) -> (* Some *)
            let v89 : string = "children"
            let v90 : JS.Function = import v89 v83
            let v91 : (unit -> (JSX.Element [])) = v90.Invoke v88 |> unbox<unit -> JSX.Element[]>
            US9_1(v91)
    let v96 : (unit -> (JSX.Element [])) =
        match v93 with
        | US9_0 -> (* None *)
            closure49()
        | US9_1(v95) -> (* Some *)
            v95
    let v97 : string = "Refresh"
    let v98 : US6 = US6_1(v97)
    let v99 : US9 = US9_1(v96)
    let v100 : string = "neutral"
    let v101 : US6 = US6_1(v100)
    let v102 : string = "20px"
    let v103 : US6 = US6_1(v102)
    let v104 : US12 = US12_1(v86)
    let v105 : (unit -> unit) = closure50(v3)
    let v106 : US14 = US14_1(v105)
    let v107 : string = "xs"
    let v108 : US6 = US6_1(v107)
    let v109 : ((string * obj) []) = method7(v9, v10, v98, v12, v13, v14, v15, v16, v17, v18, v19, v99, v21, v101, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v103, v35, v104, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v106, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v108, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78)
    let v110 : obj = createObj v109
    let v111 : (unit -> (JSX.Element [])) = closure49()
    emitJsExpr (v110, v111) "$0.children = $1"
    let v112 : (obj -> JSX.Element) = v8 |> unbox<(obj -> JSX.Element)>
    let v113 : JS.Function = import v82 v83
    let v114 : JSX.Element = v113.Invoke (v112, v110) |> unbox<JSX.Element>
    let v115 : JS.Function = import v6 v7
    let struct (v116 : US6, v117 : US6, v118 : US6, v119 : US7, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US8, v127 : US9, v128 : US6, v129 : US6, v130 : US8, v131 : US10, v132 : US6, v133 : US6, v134 : US6, v135 : US11, v136 : US8, v137 : US6, v138 : US6, v139 : US6, v140 : US6, v141 : US6, v142 : US6, v143 : US12, v144 : US6, v145 : US6, v146 : US6, v147 : US12, v148 : US6, v149 : US6, v150 : US6, v151 : US6, v152 : US6, v153 : US6, v154 : US6, v155 : US6, v156 : US6, v157 : US6, v158 : US13, v159 : US14, v160 : US13, v161 : US6, v162 : US6, v163 : US6, v164 : US6, v165 : US6, v166 : US6, v167 : US6, v168 : US6, v169 : US6, v170 : US6, v171 : US6, v172 : US6, v173 : US6, v174 : US6, v175 : US6, v176 : US6, v177 : US6, v178 : US12, v179 : US6, v180 : US6, v181 : US10, v182 : US10, v183 : US6, v184 : US5, v185 : US6) = method3()
    let v186 : US5 = v5 ()
    let v190 : bool =
        match v186 with
        | US5_1(v188) -> (* Some *)
            let v189 : bool = v188 = v0
            v189
        | _ ->
            false
    let v193 : string =
        if v190 then
            let v191 : string = "Restore"
            v191
        else
            let v192 : string = "Maximize"
            v192
    let v194 : US5 = v5 ()
    let v198 : bool =
        match v194 with
        | US5_1(v196) -> (* Some *)
            let v197 : bool = v196 = v0
            v197
        | _ ->
            false
    let v201 : (unit -> JS.Function) =
        if v198 then
            closure51()
        else
            closure52()
    let v202 : Mut7 = {l0 = v79; l1 = v201; l2 = v79} : Mut7
    let v203 : JS.Function = import v82 v83
    let v204 : JSX.Element = v203.Invoke (v85, v202) |> unbox<JSX.Element>
    let v211 : US9 =
        match v127 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v206) -> (* Some *)
            let v207 : string = "children"
            let v208 : JS.Function = import v207 v83
            let v209 : (unit -> (JSX.Element [])) = v208.Invoke v206 |> unbox<unit -> JSX.Element[]>
            US9_1(v209)
    let v214 : (unit -> (JSX.Element [])) =
        match v211 with
        | US9_0 -> (* None *)
            closure53()
        | US9_1(v213) -> (* Some *)
            v213
    let v215 : US6 = US6_1(v193)
    let v216 : US9 = US9_1(v214)
    let v217 : US6 = US6_1(v100)
    let v218 : US6 = US6_1(v102)
    let v219 : US12 = US12_1(v204)
    let v220 : (unit -> unit) = closure54(v0, v1, v5)
    let v221 : US14 = US14_1(v220)
    let v222 : US6 = US6_1(v107)
    let v223 : ((string * obj) []) = method7(v116, v117, v215, v119, v120, v121, v122, v123, v124, v125, v126, v216, v128, v217, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v218, v142, v219, v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v221, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v222, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185)
    let v224 : obj = createObj v223
    let v225 : (unit -> (JSX.Element [])) = closure53()
    emitJsExpr (v224, v225) "$0.children = $1"
    let v226 : (obj -> JSX.Element) = v115 |> unbox<(obj -> JSX.Element)>
    let v227 : JS.Function = import v82 v83
    let v228 : JSX.Element = v227.Invoke (v226, v224) |> unbox<JSX.Element>
    let v229 : JS.Function = import v6 v7
    let struct (v230 : US6, v231 : US6, v232 : US6, v233 : US7, v234 : US6, v235 : US6, v236 : US6, v237 : US6, v238 : US6, v239 : US6, v240 : US8, v241 : US9, v242 : US6, v243 : US6, v244 : US8, v245 : US10, v246 : US6, v247 : US6, v248 : US6, v249 : US11, v250 : US8, v251 : US6, v252 : US6, v253 : US6, v254 : US6, v255 : US6, v256 : US6, v257 : US12, v258 : US6, v259 : US6, v260 : US6, v261 : US12, v262 : US6, v263 : US6, v264 : US6, v265 : US6, v266 : US6, v267 : US6, v268 : US6, v269 : US6, v270 : US6, v271 : US6, v272 : US13, v273 : US14, v274 : US13, v275 : US6, v276 : US6, v277 : US6, v278 : US6, v279 : US6, v280 : US6, v281 : US6, v282 : US6, v283 : US6, v284 : US6, v285 : US6, v286 : US6, v287 : US6, v288 : US6, v289 : US6, v290 : US6, v291 : US6, v292 : US12, v293 : US6, v294 : US6, v295 : US10, v296 : US10, v297 : US6, v298 : US5, v299 : US6) = method3()
    let v300 : (unit -> JS.Function) = closure55()
    let v301 : Mut7 = {l0 = v79; l1 = v300; l2 = v79} : Mut7
    let v302 : JS.Function = import v82 v83
    let v303 : JSX.Element = v302.Invoke (v85, v301) |> unbox<JSX.Element>
    let v310 : US9 =
        match v241 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v305) -> (* Some *)
            let v306 : string = "children"
            let v307 : JS.Function = import v306 v83
            let v308 : (unit -> (JSX.Element [])) = v307.Invoke v305 |> unbox<unit -> JSX.Element[]>
            US9_1(v308)
    let v313 : (unit -> (JSX.Element [])) =
        match v310 with
        | US9_0 -> (* None *)
            closure56()
        | US9_1(v312) -> (* Some *)
            v312
    let v314 : string = "Unload"
    let v315 : US6 = US6_1(v314)
    let v316 : US9 = US9_1(v313)
    let v317 : US6 = US6_1(v100)
    let v318 : US6 = US6_1(v102)
    let v319 : US12 = US12_1(v303)
    let v320 : (unit -> unit) = closure57(v2, v4)
    let v321 : US14 = US14_1(v320)
    let v322 : US6 = US6_1(v107)
    let v323 : ((string * obj) []) = method7(v230, v231, v315, v233, v234, v235, v236, v237, v238, v239, v240, v316, v242, v317, v244, v245, v246, v247, v248, v249, v250, v251, v252, v253, v254, v318, v256, v319, v258, v259, v260, v261, v262, v263, v264, v265, v266, v267, v268, v269, v270, v271, v272, v321, v274, v275, v276, v277, v278, v279, v280, v281, v282, v283, v284, v285, v286, v322, v288, v289, v290, v291, v292, v293, v294, v295, v296, v297, v298, v299)
    let v324 : obj = createObj v323
    let v325 : (unit -> (JSX.Element [])) = closure56()
    emitJsExpr (v324, v325) "$0.children = $1"
    let v326 : (obj -> JSX.Element) = v229 |> unbox<(obj -> JSX.Element)>
    let v327 : JS.Function = import v82 v83
    let v328 : JSX.Element = v327.Invoke (v326, v324) |> unbox<JSX.Element>
    [|v114; v228; v328|]
and closure43 (v0 : int32, v1 : (US5 -> unit), v2 : (unit -> US5), v3 : (bool -> unit), v4 : (bool -> unit), v5 : (unit -> bool), v6 : Mut6, v7 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v8 : string = "Stack"
    let v9 : string = "@hope-ui/solid"
    let v10 : JS.Function = import v8 v9
    let struct (v11 : US6, v12 : US6, v13 : US6, v14 : US7, v15 : US6, v16 : US6, v17 : US6, v18 : US6, v19 : US6, v20 : US6, v21 : US8, v22 : US9, v23 : US6, v24 : US6, v25 : US8, v26 : US10, v27 : US6, v28 : US6, v29 : US6, v30 : US11, v31 : US8, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US12, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US13, v54 : US14, v55 : US13, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US6, v69 : US6, v70 : US6, v71 : US6, v72 : US6, v73 : US12, v74 : US6, v75 : US6, v76 : US10, v77 : US10, v78 : US6, v79 : US5, v80 : US6) = method3()
    let v81 : US5 = v2 ()
    let v90 : US6 =
        match v81 with
        | US5_0 -> (* None *)
            US6_0
        | US5_1(v83) -> (* Some *)
            let v84 : bool = v83 = v0
            let v85 : bool = v84 <> true
            if v85 then
                let v86 : string = "none"
                US6_1(v86)
            else
                US6_0
    let v98 : US9 =
        match v22 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v92) -> (* Some *)
            let v93 : string = "children"
            let v94 : string = "solid-js"
            let v95 : JS.Function = import v93 v94
            let v96 : (unit -> (JSX.Element [])) = v95.Invoke v92 |> unbox<unit -> JSX.Element[]>
            US9_1(v96)
    let v101 : (unit -> (JSX.Element [])) =
        match v98 with
        | US9_0 -> (* None *)
            closure44(v0, v1, v3, v4, v6, v2)
        | US9_1(v100) -> (* Some *)
            v100
    let v102 : US9 = US9_1(v101)
    let v103 : string = "row"
    let v104 : US6 = US6_1(v103)
    let v105 : string = "absolute"
    let v106 : US6 = US6_1(v105)
    let v107 : string = "6px"
    let v108 : US6 = US6_1(v107)
    let v109 : string = "3px"
    let v110 : US6 = US6_1(v109)
    let v111 : US6 = US6_1(v107)
    let v112 : int32 = 2
    let v113 : US5 = US5_1(v112)
    let v114 : ((string * obj) []) = method7(v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v102, v23, v24, v25, v26, v27, v104, v90, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v106, v108, v68, v110, v70, v71, v72, v73, v111, v75, v76, v77, v78, v113, v80)
    let v115 : obj = createObj v114
    let v116 : (unit -> (JSX.Element [])) = closure44(v0, v1, v3, v4, v6, v2)
    emitJsExpr (v115, v116) "$0.children = $1"
    let v117 : (obj -> JSX.Element) = v10 |> unbox<(obj -> JSX.Element)>
    let v118 : string = "createComponent"
    let v119 : string = "solid-js"
    let v120 : JS.Function = import v118 v119
    let v121 : JSX.Element = v120.Invoke (v117, v115) |> unbox<JSX.Element>
    let v122 : bool = v5 ()
    let v125 : JSX.Element =
        if v122 then
            let v123 : JSX.Element = JS.undefined
            v123
        else
            let v124 : JSX.Element = v7 |> unbox<JSX.Element>
            v124
    [|v121; v125|]
and closure42 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6, v70 : int32, v71 : (US5 -> unit), v72 : (unit -> US5), v73 : (bool -> unit), v74 : (bool -> unit), v75 : (unit -> bool), v76 : Mut6) () : (JSX.Element []) =
    let v183 : JSX.Element =
        match v11 with
        | US9_0 -> (* None *)
            let v77 : JSX.Element = JS.undefined
            v77
        | US9_1(v78) -> (* Some *)
            let v79 : string = "Box"
            let v80 : string = "@hope-ui/solid"
            let v81 : JS.Function = import v79 v80
            let struct (v82 : US6, v83 : US6, v84 : US6, v85 : US7, v86 : US6, v87 : US6, v88 : US6, v89 : US6, v90 : US6, v91 : US6, v92 : US8, v93 : US9, v94 : US6, v95 : US6, v96 : US8, v97 : US10, v98 : US6, v99 : US6, v100 : US6, v101 : US11, v102 : US8, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US12, v110 : US6, v111 : US6, v112 : US6, v113 : US12, v114 : US6, v115 : US6, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US13, v125 : US14, v126 : US13, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US6, v135 : US6, v136 : US6, v137 : US6, v138 : US6, v139 : US6, v140 : US6, v141 : US6, v142 : US6, v143 : US6, v144 : US12, v145 : US6, v146 : US6, v147 : US10, v148 : US10, v149 : US6, v150 : US5, v151 : US6) = method3()
            let v152 : US5 = v72 ()
            let v154 : bool =
                match v152 with
                | US5_0 -> (* None *)
                    true
                | _ ->
                    false
            let v158 : US6 =
                if v154 then
                    let v155 : string = "relative"
                    US6_1(v155)
                else
                    US6_0
            let v166 : US9 =
                match v93 with
                | US9_0 -> (* None *)
                    US9_0
                | US9_1(v160) -> (* Some *)
                    let v161 : string = "children"
                    let v162 : string = "solid-js"
                    let v163 : JS.Function = import v161 v162
                    let v164 : (unit -> (JSX.Element [])) = v163.Invoke v160 |> unbox<unit -> JSX.Element[]>
                    US9_1(v164)
            let v169 : (unit -> (JSX.Element [])) =
                match v166 with
                | US9_0 -> (* None *)
                    closure43(v70, v71, v72, v73, v74, v75, v76, v78)
                | US9_1(v168) -> (* Some *)
                    v168
            let v170 : US9 = US9_1(v169)
            let v171 : string = "flex"
            let v172 : US6 = US6_1(v171)
            let v173 : string = "1"
            let v174 : US6 = US6_1(v173)
            let v175 : ((string * obj) []) = method7(v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v170, v94, v95, v96, v97, v98, v99, v172, v101, v102, v174, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v158, v138, v139, v140, v141, v142, v143, v144, v145, v146, v147, v148, v149, v150, v151)
            let v176 : obj = createObj v175
            let v177 : (unit -> (JSX.Element [])) = closure43(v70, v71, v72, v73, v74, v75, v76, v78)
            emitJsExpr (v176, v177) "$0.children = $1"
            let v178 : (obj -> JSX.Element) = v81 |> unbox<(obj -> JSX.Element)>
            let v179 : string = "createComponent"
            let v180 : string = "solid-js"
            let v181 : JS.Function = import v179 v180
            let v182 : JSX.Element = v181.Invoke (v178, v176) |> unbox<JSX.Element>
            v182
    [|v183|]
and closure36 (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6, v70 : int32, v71 : (US5 -> unit), v72 : (unit -> US5), v73 : (bool -> unit), v74 : (unit -> bool), v75 : (bool -> unit), v76 : (unit -> bool), v77 : Mut6) () : (JSX.Element []) =
    let v78 : bool = v74 ()
    let v79 : bool = v78 = false
    let v334 : JSX.Element =
        if v79 then
            let v80 : string = "Box"
            let v81 : string = "@hope-ui/solid"
            let v82 : JS.Function = import v80 v81
            let struct (v83 : US6, v84 : US6, v85 : US6, v86 : US7, v87 : US6, v88 : US6, v89 : US6, v90 : US6, v91 : US6, v92 : US6, v93 : US8, v94 : US9, v95 : US6, v96 : US6, v97 : US8, v98 : US10, v99 : US6, v100 : US6, v101 : US6, v102 : US11, v103 : US8, v104 : US6, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US12, v111 : US6, v112 : US6, v113 : US6, v114 : US12, v115 : US6, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US13, v126 : US14, v127 : US13, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US6, v135 : US6, v136 : US6, v137 : US6, v138 : US6, v139 : US6, v140 : US6, v141 : US6, v142 : US6, v143 : US6, v144 : US6, v145 : US12, v146 : US6, v147 : US6, v148 : US10, v149 : US10, v150 : US6, v151 : US5, v152 : US6) = method3()
            let v160 : US9 =
                match v94 with
                | US9_0 -> (* None *)
                    US9_0
                | US9_1(v154) -> (* Some *)
                    let v155 : string = "children"
                    let v156 : string = "solid-js"
                    let v157 : JS.Function = import v155 v156
                    let v158 : (unit -> (JSX.Element [])) = v157.Invoke v154 |> unbox<unit -> JSX.Element[]>
                    US9_1(v158)
            let v163 : (unit -> (JSX.Element [])) =
                match v160 with
                | US9_0 -> (* None *)
                    closure37(v73, v77)
                | US9_1(v162) -> (* Some *)
                    v162
            let v164 : US9 = US9_1(v163)
            let v165 : string = "3px 0"
            let v166 : US6 = US6_1(v165)
            let v167 : ((string * obj) []) = method7(v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v164, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v166, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v143, v144, v145, v146, v147, v148, v149, v150, v151, v152)
            let v168 : obj = createObj v167
            let v169 : (unit -> (JSX.Element [])) = closure37(v73, v77)
            emitJsExpr (v168, v169) "$0.children = $1"
            let v170 : (obj -> JSX.Element) = v82 |> unbox<(obj -> JSX.Element)>
            let v171 : string = "createComponent"
            let v172 : string = "solid-js"
            let v173 : JS.Function = import v171 v172
            let v174 : JSX.Element = v173.Invoke (v170, v168) |> unbox<JSX.Element>
            v174
        else
            let v175 : string = "Box"
            let v176 : string = "@hope-ui/solid"
            let v177 : JS.Function = import v175 v176
            let struct (v178 : US6, v179 : US6, v180 : US6, v181 : US7, v182 : US6, v183 : US6, v184 : US6, v185 : US6, v186 : US6, v187 : US6, v188 : US8, v189 : US9, v190 : US6, v191 : US6, v192 : US8, v193 : US10, v194 : US6, v195 : US6, v196 : US6, v197 : US11, v198 : US8, v199 : US6, v200 : US6, v201 : US6, v202 : US6, v203 : US6, v204 : US6, v205 : US12, v206 : US6, v207 : US6, v208 : US6, v209 : US12, v210 : US6, v211 : US6, v212 : US6, v213 : US6, v214 : US6, v215 : US6, v216 : US6, v217 : US6, v218 : US6, v219 : US6, v220 : US13, v221 : US14, v222 : US13, v223 : US6, v224 : US6, v225 : US6, v226 : US6, v227 : US6, v228 : US6, v229 : US6, v230 : US6, v231 : US6, v232 : US6, v233 : US6, v234 : US6, v235 : US6, v236 : US6, v237 : US6, v238 : US6, v239 : US6, v240 : US12, v241 : US6, v242 : US6, v243 : US10, v244 : US10, v245 : US6, v246 : US5, v247 : US6) = method3()
            let v248 : US5 = v72 ()
            let v252 : bool =
                match v248 with
                | US5_1(v250) -> (* Some *)
                    let v251 : bool = v250 = v70
                    v251
                | _ ->
                    false
            let v256 : US6 =
                if v252 then
                    let v253 : string = "$bg"
                    US6_1(v253)
                else
                    US6_0
            let v257 : US5 = v72 ()
            let v261 : bool =
                match v257 with
                | US5_1(v259) -> (* Some *)
                    let v260 : bool = v259 = v70
                    v260
                | _ ->
                    false
            let v265 : US6 =
                if v261 then
                    let v262 : string = "0"
                    US6_1(v262)
                else
                    US6_0
            let v266 : US5 = v72 ()
            let v270 : bool =
                match v266 with
                | US5_1(v268) -> (* Some *)
                    let v269 : bool = v268 = v70
                    v269
                | _ ->
                    false
            let v274 : US6 =
                if v270 then
                    let v271 : string = "0"
                    US6_1(v271)
                else
                    US6_0
            let v275 : US5 = v72 ()
            let v279 : bool =
                match v275 with
                | US5_1(v277) -> (* Some *)
                    let v278 : bool = v277 = v70
                    v278
                | _ ->
                    false
            let v283 : US6 =
                if v279 then
                    let v280 : string = "fixed"
                    US6_1(v280)
                else
                    US6_0
            let v284 : US5 = v72 ()
            let v288 : bool =
                match v284 with
                | US5_1(v286) -> (* Some *)
                    let v287 : bool = v286 = v70
                    v287
                | _ ->
                    false
            let v292 : US6 =
                if v288 then
                    let v289 : string = "0"
                    US6_1(v289)
                else
                    US6_0
            let v293 : US5 = v72 ()
            let v297 : bool =
                match v293 with
                | US5_1(v295) -> (* Some *)
                    let v296 : bool = v295 = v70
                    v296
                | _ ->
                    false
            let v301 : US6 =
                if v297 then
                    let v298 : string = "0"
                    US6_1(v298)
                else
                    US6_0
            let v302 : US5 = v72 ()
            let v306 : bool =
                match v302 with
                | US5_1(v304) -> (* Some *)
                    let v305 : bool = v304 = v70
                    v305
                | _ ->
                    false
            let v309 : US5 =
                if v306 then
                    US5_1(1)
                else
                    US5_0
            let v317 : US9 =
                match v189 with
                | US9_0 -> (* None *)
                    US9_0
                | US9_1(v311) -> (* Some *)
                    let v312 : string = "children"
                    let v313 : string = "solid-js"
                    let v314 : JS.Function = import v312 v313
                    let v315 : (unit -> (JSX.Element [])) = v314.Invoke v311 |> unbox<unit -> JSX.Element[]>
                    US9_1(v315)
            let v320 : (unit -> (JSX.Element [])) =
                match v317 with
                | US9_0 -> (* None *)
                    closure42(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v75, v76, v77)
                | US9_1(v319) -> (* Some *)
                    v319
            let v321 : US9 = US9_1(v320)
            let v322 : string = "flex"
            let v323 : US6 = US6_1(v322)
            let v324 : string = "1"
            let v325 : US6 = US6_1(v324)
            let v326 : ((string * obj) []) = method7(v178, v179, v180, v181, v256, v183, v184, v185, v186, v265, v188, v321, v190, v191, v192, v193, v194, v195, v323, v197, v198, v325, v200, v201, v202, v203, v204, v205, v206, v207, v274, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v220, v221, v222, v223, v224, v225, v226, v227, v228, v229, v230, v231, v232, v283, v292, v235, v236, v237, v238, v239, v240, v301, v242, v243, v244, v245, v309, v247)
            let v327 : obj = createObj v326
            let v328 : (unit -> (JSX.Element [])) = closure42(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v75, v76, v77)
            emitJsExpr (v327, v328) "$0.children = $1"
            let v329 : (obj -> JSX.Element) = v177 |> unbox<(obj -> JSX.Element)>
            let v330 : string = "createComponent"
            let v331 : string = "solid-js"
            let v332 : JS.Function = import v330 v331
            let v333 : JSX.Element = v332.Invoke (v329, v327) |> unbox<JSX.Element>
            v333
    [|v334|]
and method13 (v0 : Mut6) : JSX.Element =
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = v0.l4
    let struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) = method3()
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
    let v274 : obj = emitJsExpr () "components_spi.state_context"
    let v275 : string = "useContext"
    let v276 : string = "solid-js"
    let v277 : JS.Function = import v275 v276
    let struct (v278 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v279 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v280 : (unit -> int32), v281 : (int32 -> unit), v282 : (unit -> string), v283 : (string -> unit), v284 : (unit -> string), v285 : (string -> unit), v286 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v287 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v288 : (unit -> (struct (US2 * (int32 [])) [])), v289 : ((struct (US2 * (int32 [])) []) -> unit), v290 : (unit -> (struct (int32 * obj) [])), v291 : ((struct (int32 * obj) []) -> unit), v292 : (unit -> (struct (int32 * obj) [])), v293 : ((struct (int32 * obj) []) -> unit), v294 : (unit -> (struct (int32 * int32) [])), v295 : ((struct (int32 * int32) []) -> unit), v296 : (unit -> US4), v297 : (US4 -> unit), v298 : (unit -> US5), v299 : (US5 -> unit)) = v277.Invoke v274 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v422 : obj = emitJsExpr () "components_spi.state_context"
    let v423 : JS.Function = import v275 v276
    let struct (v424 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v425 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v426 : (unit -> int32), v427 : (int32 -> unit), v428 : (unit -> string), v429 : (string -> unit), v430 : (unit -> string), v431 : (string -> unit), v432 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v433 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v434 : (unit -> (struct (US2 * (int32 [])) [])), v435 : ((struct (US2 * (int32 [])) []) -> unit), v436 : (unit -> (struct (int32 * obj) [])), v437 : ((struct (int32 * obj) []) -> unit), v438 : (unit -> (struct (int32 * obj) [])), v439 : ((struct (int32 * obj) []) -> unit), v440 : (unit -> (struct (int32 * int32) [])), v441 : ((struct (int32 * int32) []) -> unit), v442 : (unit -> US4), v443 : (US4 -> unit), v444 : (unit -> US5), v445 : (US5 -> unit)) = v423.Invoke v422 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v568 : obj = emitJsExpr () "components_spi.state_context"
    let v569 : JS.Function = import v275 v276
    let struct (v570 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v571 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v572 : (unit -> int32), v573 : (int32 -> unit), v574 : (unit -> string), v575 : (string -> unit), v576 : (unit -> string), v577 : (string -> unit), v578 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v579 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v580 : (unit -> (struct (US2 * (int32 [])) [])), v581 : ((struct (US2 * (int32 [])) []) -> unit), v582 : (unit -> (struct (int32 * obj) [])), v583 : ((struct (int32 * obj) []) -> unit), v584 : (unit -> (struct (int32 * obj) [])), v585 : ((struct (int32 * obj) []) -> unit), v586 : (unit -> (struct (int32 * int32) [])), v587 : ((struct (int32 * int32) []) -> unit), v588 : (unit -> US4), v589 : (US4 -> unit), v590 : (unit -> US5), v591 : (US5 -> unit)) = v569.Invoke v568 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v592 : (unit -> (obj [])) = closure30(v150, v282, v442, v590)
    let v593 : string = "#de884c"
    let v594 : (US4 -> ((obj []) -> unit)) = method14(v592, v593)
    let v595 : US4 = US4_0
    let v596 : ((obj []) -> unit) = v594 v595
    let v597 : string = "> loader ()"
    let v598 : obj = v597
    let v599 : (obj []) = [|v598|]
    v596 v599
    let v600 : bool = v0.l0
    let v601 : string = "createSignal"
    let v602 : JS.Function = import v601 v276
    let v603 : (JS.Function []) = v602.Invoke v600 |> unbox<JS.Function[]>
    let v604 : (unit -> bool) = v603.[0] |> unbox
    let v605 : (bool -> unit) = v603.[1] |> unbox
    let v606 : JS.Function = import v601 v276
    let v607 : (JS.Function []) = v606.Invoke false |> unbox<JS.Function[]>
    let v608 : (unit -> bool) = v607.[0] |> unbox
    let v609 : (bool -> unit) = v607.[1] |> unbox
    let v610 : (unit -> unit) = closure33(v0, v150, v591)
    method17(v610)
    let v611 : (unit -> unit) = closure34(v609, v608)
    method17(v611)
    let v612 : (unit -> unit) = closure35(v0)
    method18(v612)
    let v613 : bool = v0.l0
    let v614 : bool = v613 = true
    if v614 then
        let v615 : US14 = v0.l2
        match v615 with
        | US14_0 -> (* None *)
            ()
        | US14_1(v616) -> (* Some *)
            v616 ()
            ()
    let v617 : string = "Box"
    let v618 : string = "@hope-ui/solid"
    let v619 : JS.Function = import v617 v618
    let struct (v620 : US6, v621 : US6, v622 : US6, v623 : US7, v624 : US6, v625 : US6, v626 : US6, v627 : US6, v628 : US6, v629 : US6, v630 : US8, v631 : US9, v632 : US6, v633 : US6, v634 : US8, v635 : US10, v636 : US6, v637 : US6, v638 : US6, v639 : US11, v640 : US8, v641 : US6, v642 : US6, v643 : US6, v644 : US6, v645 : US6, v646 : US6, v647 : US12, v648 : US6, v649 : US6, v650 : US6, v651 : US12, v652 : US6, v653 : US6, v654 : US6, v655 : US6, v656 : US6, v657 : US6, v658 : US6, v659 : US6, v660 : US6, v661 : US6, v662 : US13, v663 : US14, v664 : US13, v665 : US6, v666 : US6, v667 : US6, v668 : US6, v669 : US6, v670 : US6, v671 : US6, v672 : US6, v673 : US6, v674 : US6, v675 : US6, v676 : US6, v677 : US6, v678 : US6, v679 : US6, v680 : US6, v681 : US6, v682 : US12, v683 : US6, v684 : US6, v685 : US10, v686 : US10, v687 : US6, v688 : US5, v689 : US6) = method3()
    let v696 : US9 =
        match v631 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v691) -> (* Some *)
            let v692 : string = "children"
            let v693 : JS.Function = import v692 v276
            let v694 : (unit -> (JSX.Element [])) = v693.Invoke v691 |> unbox<unit -> JSX.Element[]>
            US9_1(v694)
    let v699 : (unit -> (JSX.Element [])) =
        match v696 with
        | US9_0 -> (* None *)
            closure36(v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v150, v591, v590, v605, v604, v609, v608, v0)
        | US9_1(v698) -> (* Some *)
            v698
    let v700 : US9 = US9_1(v699)
    let v701 : string = "flex"
    let v702 : US6 = US6_1(v701)
    let v703 : string = "1"
    let v704 : US6 = US6_1(v703)
    let v705 : ((string * obj) []) = method7(v620, v621, v622, v623, v624, v625, v626, v627, v628, v629, v630, v700, v632, v633, v634, v635, v636, v637, v702, v639, v640, v704, v642, v643, v644, v645, v646, v647, v100, v649, v650, v651, v652, v653, v654, v655, v656, v657, v658, v659, v660, v661, v662, v663, v664, v665, v666, v667, v668, v669, v670, v671, v672, v673, v674, v675, v676, v677, v678, v679, v680, v681, v682, v683, v684, v685, v686, v687, v688, v689)
    let v706 : obj = createObj v705
    let v707 : (unit -> (JSX.Element [])) = closure36(v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v150, v591, v590, v605, v604, v609, v608, v0)
    emitJsExpr (v706, v707) "$0.children = $1"
    let v708 : (obj -> JSX.Element) = v619 |> unbox<(obj -> JSX.Element)>
    let v709 : string = "createComponent"
    let v710 : JS.Function = import v709 v276
    let v711 : JSX.Element = v710.Invoke (v708, v706) |> unbox<JSX.Element>
    v711
and closure29 () (v0 : Mut6) : JSX.Element =
    method13(v0)
and closure27 (v0 : Mut4, v1 : (unit -> bool), v2 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v3 : US15 = v0.l3
    let v29 : JSX.Element =
        match v3 with
        | US15_0 -> (* CheckDisabled *)
            let v4 : bool = v1 ()
            if v4 then
                let v5 : US14 = v0.l0
                let v6 : US14 = v0.l1
                let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure28(v2)
                let v8 : Mut6 = {l0 = true; l1 = false; l2 = v5; l3 = v6; l4 = v7} : Mut6
                let v9 : string = "createComponent"
                let v10 : string = "solid-js"
                let v11 : JS.Function = import v9 v10
                let v12 : (Mut6 -> JSX.Element) = closure29()
                let v13 : JSX.Element = v11.Invoke (v12, v8) |> unbox<JSX.Element>
                v13
            else
                let v14 : JSX.Element = JS.undefined
                v14
        | US15_1 -> (* CheckEnabled *)
            let v16 : bool = v1 ()
            if v16 then
                let v17 : US14 = v0.l0
                let v18 : US14 = v0.l1
                let v19 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure28(v2)
                let v20 : Mut6 = {l0 = true; l1 = false; l2 = v17; l3 = v18; l4 = v19} : Mut6
                let v21 : string = "createComponent"
                let v22 : string = "solid-js"
                let v23 : JS.Function = import v21 v22
                let v24 : (Mut6 -> JSX.Element) = closure29()
                let v25 : JSX.Element = v23.Invoke (v24, v20) |> unbox<JSX.Element>
                v25
            else
                let v26 : JSX.Element = JS.undefined
                v26
        | US15_2 -> (* CheckHidden *)
            let v28 : JSX.Element = v2 |> unbox<JSX.Element>
            v28
    [|v29|]
and closure17 (v0 : Mut4, v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6, v71 : (bool -> unit), v72 : (unit -> bool)) () : (JSX.Element []) =
    let v203 : JSX.Element =
        match v63 with
        | US12_0 -> (* None *)
            let v73 : JSX.Element = JS.undefined
            v73
        | US12_1(v74) -> (* Some *)
            let v75 : string = "Td"
            let v76 : string = "@hope-ui/solid"
            let v77 : JS.Function = import v75 v76
            let struct (v78 : US6, v79 : US6, v80 : US6, v81 : US7, v82 : US6, v83 : US6, v84 : US6, v85 : US6, v86 : US6, v87 : US6, v88 : US8, v89 : US9, v90 : US6, v91 : US6, v92 : US8, v93 : US10, v94 : US6, v95 : US6, v96 : US6, v97 : US11, v98 : US8, v99 : US6, v100 : US6, v101 : US6, v102 : US6, v103 : US6, v104 : US6, v105 : US12, v106 : US6, v107 : US6, v108 : US6, v109 : US12, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US6, v115 : US6, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US13, v121 : US14, v122 : US13, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US6, v135 : US6, v136 : US6, v137 : US6, v138 : US6, v139 : US6, v140 : US12, v141 : US6, v142 : US6, v143 : US10, v144 : US10, v145 : US6, v146 : US5, v147 : US6) = method3()
            let v148 : US15 = v0.l3
            let v150 : bool =
                match v148 with
                | US15_2 -> (* CheckHidden *)
                    true
                | _ ->
                    false
            let v152 : bool =
                if v150 then
                    true
                else
                    let v151 : bool = v72 ()
                    v151
            let v157 : string =
                if v152 then
                    let v153 : string = JS.undefined
                    let v154 : string = "0px !important"
                    method12(v154, v153)
                else
                    let v156 : string = "0px !important"
                    v156
            let v160 : string =
                match v25 with
                | US6_0 -> (* None *)
                    let v158 : string = "$sm"
                    v158
                | US6_1(v159) -> (* Some *)
                    v159
            let v167 : string =
                match v52 with
                | US6_0 -> (* None *)
                    let v161 : string = "0 20px 0 0"
                    v161
                | US6_1(v162) -> (* Some *)
                    let v163 : bool = "0" = v162
                    if v163 then
                        let v164 : string = "0"
                        v164
                    else
                        let v165 : string = "0 20px 0 0"
                        v165
            let v168 : string = "0"
            let v169 : string = method12(v167, v168)
            let v177 : US9 =
                match v89 with
                | US9_0 -> (* None *)
                    US9_0
                | US9_1(v171) -> (* Some *)
                    let v172 : string = "children"
                    let v173 : string = "solid-js"
                    let v174 : JS.Function = import v172 v173
                    let v175 : (unit -> (JSX.Element [])) = v174.Invoke v171 |> unbox<unit -> JSX.Element[]>
                    US9_1(v175)
            let v180 : (unit -> (JSX.Element [])) =
                match v177 with
                | US9_0 -> (* None *)
                    closure18(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v74)
                | US9_1(v179) -> (* Some *)
                    v179
            let v181 : US6 = US6_1(v157)
            let v182 : string = "$neutral5"
            let v183 : US6 = US6_1(v182)
            let v184 : US9 = US9_1(v180)
            let v185 : string = "$neutral11"
            let v186 : US6 = US6_1(v185)
            let v187 : string = "flex"
            let v188 : US6 = US6_1(v187)
            let v189 : string = "column"
            let v190 : US6 = US6_1(v189)
            let v191 : US6 = US6_1(v160)
            let v192 : string = "center"
            let v193 : US6 = US6_1(v192)
            let v194 : US6 = US6_1(v169)
            let v195 : ((string * obj) []) = method7(v78, v79, v80, v81, v82, v83, v181, v183, v86, v87, v88, v184, v186, v91, v92, v93, v94, v95, v188, v97, v98, v99, v190, v101, v191, v103, v104, v105, v106, v193, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v194, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v143, v144, v145, v146, v147)
            let v196 : obj = createObj v195
            let v197 : (unit -> (JSX.Element [])) = closure18(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v74)
            emitJsExpr (v196, v197) "$0.children = $1"
            let v198 : (obj -> JSX.Element) = v77 |> unbox<(obj -> JSX.Element)>
            let v199 : string = "createComponent"
            let v200 : string = "solid-js"
            let v201 : JS.Function = import v199 v200
            let v202 : JSX.Element = v201.Invoke (v198, v196) |> unbox<JSX.Element>
            v202
    let v431 : JSX.Element =
        match v12 with
        | US9_0 -> (* None *)
            let v204 : string = "Td"
            let v205 : string = "@hope-ui/solid"
            let v206 : JS.Function = import v204 v205
            let struct (v207 : US6, v208 : US6, v209 : US6, v210 : US7, v211 : US6, v212 : US6, v213 : US6, v214 : US6, v215 : US6, v216 : US6, v217 : US8, v218 : US9, v219 : US6, v220 : US6, v221 : US8, v222 : US10, v223 : US6, v224 : US6, v225 : US6, v226 : US11, v227 : US8, v228 : US6, v229 : US6, v230 : US6, v231 : US6, v232 : US6, v233 : US6, v234 : US12, v235 : US6, v236 : US6, v237 : US6, v238 : US12, v239 : US6, v240 : US6, v241 : US6, v242 : US6, v243 : US6, v244 : US6, v245 : US6, v246 : US6, v247 : US6, v248 : US6, v249 : US13, v250 : US14, v251 : US13, v252 : US6, v253 : US6, v254 : US6, v255 : US6, v256 : US6, v257 : US6, v258 : US6, v259 : US6, v260 : US6, v261 : US6, v262 : US6, v263 : US6, v264 : US6, v265 : US6, v266 : US6, v267 : US6, v268 : US6, v269 : US12, v270 : US6, v271 : US6, v272 : US10, v273 : US10, v274 : US6, v275 : US5, v276 : US6) = method3()
            let v284 : US9 =
                match v218 with
                | US9_0 -> (* None *)
                    US9_0
                | US9_1(v278) -> (* Some *)
                    let v279 : string = "children"
                    let v280 : string = "solid-js"
                    let v281 : JS.Function = import v279 v280
                    let v282 : (unit -> (JSX.Element [])) = v281.Invoke v278 |> unbox<unit -> JSX.Element[]>
                    US9_1(v282)
            let v287 : (unit -> (JSX.Element [])) =
                match v284 with
                | US9_0 -> (* None *)
                    closure26()
                | US9_1(v286) -> (* Some *)
                    v286
            let v288 : string = "0"
            let v289 : US6 = US6_1(v288)
            let v290 : US9 = US9_1(v287)
            let v291 : string = "9px"
            let v292 : US6 = US6_1(v291)
            let v293 : US6 = US6_1(v288)
            let v294 : ((string * obj) []) = method7(v207, v208, v209, v210, v211, v289, v213, v214, v215, v216, v217, v290, v219, v220, v221, v222, v223, v224, v225, v226, v227, v228, v229, v230, v231, v232, v233, v234, v235, v236, v237, v238, v292, v240, v241, v242, v243, v244, v245, v246, v247, v248, v249, v250, v251, v252, v253, v254, v255, v293, v257, v258, v259, v260, v261, v262, v263, v264, v265, v266, v267, v268, v269, v270, v271, v272, v273, v274, v275, v276)
            let v295 : obj = createObj v294
            let v296 : (unit -> (JSX.Element [])) = closure26()
            emitJsExpr (v295, v296) "$0.children = $1"
            let v297 : (obj -> JSX.Element) = v206 |> unbox<(obj -> JSX.Element)>
            let v298 : string = "createComponent"
            let v299 : string = "solid-js"
            let v300 : JS.Function = import v298 v299
            let v301 : JSX.Element = v300.Invoke (v297, v295) |> unbox<JSX.Element>
            v301
        | US9_1(v302) -> (* Some *)
            let v303 : string = "Td"
            let v304 : string = "@hope-ui/solid"
            let v305 : JS.Function = import v303 v304
            let struct (v306 : US6, v307 : US6, v308 : US6, v309 : US7, v310 : US6, v311 : US6, v312 : US6, v313 : US6, v314 : US6, v315 : US6, v316 : US8, v317 : US9, v318 : US6, v319 : US6, v320 : US8, v321 : US10, v322 : US6, v323 : US6, v324 : US6, v325 : US11, v326 : US8, v327 : US6, v328 : US6, v329 : US6, v330 : US6, v331 : US6, v332 : US6, v333 : US12, v334 : US6, v335 : US6, v336 : US6, v337 : US12, v338 : US6, v339 : US6, v340 : US6, v341 : US6, v342 : US6, v343 : US6, v344 : US6, v345 : US6, v346 : US6, v347 : US6, v348 : US13, v349 : US14, v350 : US13, v351 : US6, v352 : US6, v353 : US6, v354 : US6, v355 : US6, v356 : US6, v357 : US6, v358 : US6, v359 : US6, v360 : US6, v361 : US6, v362 : US6, v363 : US6, v364 : US6, v365 : US6, v366 : US6, v367 : US6, v368 : US12, v369 : US6, v370 : US6, v371 : US10, v372 : US10, v373 : US6, v374 : US5, v375 : US6) = method3()
            let v378 : string =
                match v25 with
                | US6_0 -> (* None *)
                    let v376 : string = "$sm"
                    v376
                | US6_1(v377) -> (* Some *)
                    v377
            let v381 : string =
                match v36 with
                | US6_0 -> (* None *)
                    let v379 : string = "0"
                    v379
                | US6_1(v380) -> (* Some *)
                    v380
            let v384 : string =
                match v35 with
                | US6_0 -> (* None *)
                    let v382 : string = "0"
                    v382
                | US6_1(v383) -> (* Some *)
                    v383
            let v387 : string =
                match v50 with
                | US6_0 -> (* None *)
                    let v385 : string = "0"
                    v385
                | US6_1(v386) -> (* Some *)
                    v386
            let v395 : US9 =
                match v317 with
                | US9_0 -> (* None *)
                    US9_0
                | US9_1(v389) -> (* Some *)
                    let v390 : string = "children"
                    let v391 : string = "solid-js"
                    let v392 : JS.Function = import v390 v391
                    let v393 : (unit -> (JSX.Element [])) = v392.Invoke v389 |> unbox<unit -> JSX.Element[]>
                    US9_1(v393)
            let v398 : (unit -> (JSX.Element [])) =
                match v395 with
                | US9_0 -> (* None *)
                    closure27(v0, v72, v302)
                | US9_1(v397) -> (* Some *)
                    v397
            let v399 : string = "0"
            let v400 : US6 = US6_1(v399)
            let v401 : US9 = US9_1(v398)
            let v402 : string = "flex"
            let v403 : US6 = US6_1(v402)
            let v404 : string = "6"
            let v405 : US6 = US6_1(v404)
            let v406 : string = "column"
            let v407 : US6 = US6_1(v406)
            let v408 : US6 = US6_1(v378)
            let v409 : string = "center"
            let v410 : US6 = US6_1(v409)
            let v411 : string = "$base"
            let v412 : US6 = US6_1(v411)
            let v413 : US6 = US6_1(v384)
            let v414 : US6 = US6_1(v381)
            let v415 : US6 = US6_1(v399)
            let v416 : US6 = US6_1(v399)
            let v417 : string = "85vh"
            let v418 : US6 = US6_1(v417)
            let v419 : US6 = US6_1(v399)
            let v420 : string = "auto"
            let v421 : US6 = US6_1(v420)
            let v422 : US6 = US6_1(v387)
            let v423 : ((string * obj) []) = method7(v306, v307, v308, v309, v310, v400, v312, v313, v314, v315, v316, v401, v318, v319, v320, v321, v322, v323, v403, v325, v326, v405, v407, v329, v408, v331, v332, v333, v334, v410, v336, v337, v412, v339, v413, v414, v415, v416, v418, v345, v346, v347, v348, v349, v350, v419, v352, v353, v421, v422, v356, v357, v358, v359, v360, v361, v362, v363, v364, v365, v366, v367, v368, v369, v370, v371, v372, v373, v374, v375)
            let v424 : obj = createObj v423
            let v425 : (unit -> (JSX.Element [])) = closure27(v0, v72, v302)
            emitJsExpr (v424, v425) "$0.children = $1"
            let v426 : (obj -> JSX.Element) = v305 |> unbox<(obj -> JSX.Element)>
            let v427 : string = "createComponent"
            let v428 : string = "solid-js"
            let v429 : JS.Function = import v427 v428
            let v430 : JSX.Element = v429.Invoke (v426, v424) |> unbox<JSX.Element>
            v430
    [|v203; v431|]
and method11 (v0 : Mut4) : JSX.Element =
    let v1 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = v0.l2
    let struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) = method3()
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
    let struct (v163 : US6, v164 : US6, v165 : US6, v166 : US7, v167 : US6, v168 : US6, v169 : US6, v170 : US6, v171 : US6, v172 : US6, v173 : US8, v174 : US9, v175 : US6, v176 : US6, v177 : US8, v178 : US10, v179 : US6, v180 : US6, v181 : US6, v182 : US11, v183 : US8, v184 : US6, v185 : US6, v186 : US6, v187 : US6, v188 : US6, v189 : US6, v190 : US12, v191 : US6, v192 : US6, v193 : US6, v194 : US12, v195 : US6, v196 : US6, v197 : US6, v198 : US6, v199 : US6, v200 : US6, v201 : US6, v202 : US6, v203 : US6, v204 : US6, v205 : US13, v206 : US14, v207 : US13, v208 : US6, v209 : US6, v210 : US6, v211 : US6, v212 : US6, v213 : US6, v214 : US6, v215 : US6, v216 : US6, v217 : US6, v218 : US6, v219 : US6, v220 : US6, v221 : US6, v222 : US6, v223 : US6, v224 : US6, v225 : US12, v226 : US6, v227 : US6, v228 : US10, v229 : US10, v230 : US6, v231 : US5, v232 : US6) = method3()
    let v233 : string = "column"
    let v234 : string = "row"
    let v235 : string = method12(v234, v233)
    let v242 : US9 =
        match v174 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v237) -> (* Some *)
            let v238 : string = "children"
            let v239 : JS.Function = import v238 v155
            let v240 : (unit -> (JSX.Element [])) = v239.Invoke v237 |> unbox<unit -> JSX.Element[]>
            US9_1(v240)
    let v245 : (unit -> (JSX.Element [])) =
        match v242 with
        | US9_0 -> (* None *)
            closure17(v0, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v159, v158)
        | US9_1(v244) -> (* Some *)
            v244
    let v246 : string = "$neutral5"
    let v247 : US6 = US6_1(v246)
    let v248 : string = "1px 1px"
    let v249 : US6 = US6_1(v248)
    let v250 : US9 = US9_1(v245)
    let v251 : string = "flex"
    let v252 : US6 = US6_1(v251)
    let v253 : string = "1"
    let v254 : US6 = US6_1(v253)
    let v255 : US6 = US6_1(v235)
    let v256 : ((string * obj) []) = method7(v163, v164, v165, v166, v167, v168, v169, v247, v249, v172, v173, v250, v175, v176, v177, v178, v179, v180, v252, v182, v183, v254, v255, v186, v187, v188, v189, v190, v100, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v220, v221, v222, v223, v224, v225, v226, v227, v228, v229, v230, v231, v232)
    let v257 : obj = createObj v256
    let v258 : (unit -> (JSX.Element [])) = closure17(v0, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v149, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v159, v158)
    emitJsExpr (v257, v258) "$0.children = $1"
    let v259 : (obj -> JSX.Element) = v162 |> unbox<(obj -> JSX.Element)>
    let v260 : string = "createComponent"
    let v261 : JS.Function = import v260 v155
    let v262 : JSX.Element = v261.Invoke (v259, v257) |> unbox<JSX.Element>
    v262
and closure16 () (v0 : Mut4) : JSX.Element =
    method11(v0)
and closure61 () (v0 : string) : obj =
    let v1 : obj = v0
    v1
and closure62 () () : struct ((unit -> string) * (string -> unit)) =
    let v123 : obj = emitJsExpr () "components_spi.state_context"
    let v124 : string = "useContext"
    let v125 : string = "solid-js"
    let v126 : JS.Function = import v124 v125
    let struct (v127 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v128 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v129 : (unit -> int32), v130 : (int32 -> unit), v131 : (unit -> string), v132 : (string -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v136 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v137 : (unit -> (struct (US2 * (int32 [])) [])), v138 : ((struct (US2 * (int32 [])) []) -> unit), v139 : (unit -> (struct (int32 * obj) [])), v140 : ((struct (int32 * obj) []) -> unit), v141 : (unit -> (struct (int32 * obj) [])), v142 : ((struct (int32 * obj) []) -> unit), v143 : (unit -> (struct (int32 * int32) [])), v144 : ((struct (int32 * int32) []) -> unit), v145 : (unit -> US4), v146 : (US4 -> unit), v147 : (unit -> US5), v148 : (US5 -> unit)) = v126.Invoke v123 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v131, v132)
and closure66 (v0 : Mut8, v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : string = v1 ()
    let v3 : (string -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure65 (v0 : Mut8, v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let struct (v6 : US6, v7 : US6, v8 : US6, v9 : US7, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US8, v17 : US9, v18 : US6, v19 : US6, v20 : US8, v21 : US10, v22 : US6, v23 : US6, v24 : US6, v25 : US11, v26 : US8, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US12, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US13, v49 : US14, v50 : US13, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US12, v69 : US6, v70 : US6, v71 : US10, v72 : US10, v73 : US6, v74 : US5, v75 : US6) = method3()
    let v83 : US9 =
        match v17 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v77) -> (* Some *)
            let v78 : string = "children"
            let v79 : string = "solid-js"
            let v80 : JS.Function = import v78 v79
            let v81 : (unit -> (JSX.Element [])) = v80.Invoke v77 |> unbox<unit -> JSX.Element[]>
            US9_1(v81)
    let v86 : (unit -> (JSX.Element [])) =
        match v83 with
        | US9_0 -> (* None *)
            closure66(v0, v1)
        | US9_1(v85) -> (* Some *)
            v85
    let v87 : US9 = US9_1(v86)
    let v88 : ((string * obj) []) = method7(v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v87, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75)
    let v89 : obj = createObj v88
    let v90 : (unit -> (JSX.Element [])) = closure66(v0, v1)
    emitJsExpr (v89, v90) "$0.children = $1"
    let v91 : (obj -> JSX.Element) = v5 |> unbox<(obj -> JSX.Element)>
    let v92 : string = "createComponent"
    let v93 : string = "solid-js"
    let v94 : JS.Function = import v92 v93
    let v95 : JSX.Element = v94.Invoke (v91, v89) |> unbox<JSX.Element>
    [|v95|]
and closure64 (v0 : Mut8, v1 : (unit -> string)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure65(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v78, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method22 (v0 : Mut8) : JSX.Element =
    let v1 : (unit -> struct ((unit -> string) * (string -> unit))) = v0.l1
    let struct (v2 : (unit -> string), v3 : (string -> unit)) = v1 ()
    let v4 : US14 = US14_0
    let v5 : US14 = US14_0
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure64(v0, v2)
    let v7 : US15 = US15_2
    let v8 : Mut4 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7} : Mut4
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : (Mut4 -> JSX.Element) = closure16()
    let v13 : JSX.Element = v11.Invoke (v12, v8) |> unbox<JSX.Element>
    v13
and closure63 () (v0 : Mut8) : JSX.Element =
    method22(v0)
and closure67 () () : struct ((unit -> string) * (string -> unit)) =
    let v123 : obj = emitJsExpr () "components_spi.state_context"
    let v124 : string = "useContext"
    let v125 : string = "solid-js"
    let v126 : JS.Function = import v124 v125
    let struct (v127 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v128 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v129 : (unit -> int32), v130 : (int32 -> unit), v131 : (unit -> string), v132 : (string -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v136 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v137 : (unit -> (struct (US2 * (int32 [])) [])), v138 : ((struct (US2 * (int32 [])) []) -> unit), v139 : (unit -> (struct (int32 * obj) [])), v140 : ((struct (int32 * obj) []) -> unit), v141 : (unit -> (struct (int32 * obj) [])), v142 : ((struct (int32 * obj) []) -> unit), v143 : (unit -> (struct (int32 * int32) [])), v144 : ((struct (int32 * int32) []) -> unit), v145 : (unit -> US4), v146 : (US4 -> unit), v147 : (unit -> US5), v148 : (US5 -> unit)) = v126.Invoke v123 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v133, v134)
and closure68 () (v0 : int32) : obj =
    let v1 : obj = v0
    v1
and closure69 () () : struct ((unit -> int32) * (int32 -> unit)) =
    let v123 : obj = emitJsExpr () "components_spi.state_context"
    let v124 : string = "useContext"
    let v125 : string = "solid-js"
    let v126 : JS.Function = import v124 v125
    let struct (v127 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v128 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v129 : (unit -> int32), v130 : (int32 -> unit), v131 : (unit -> string), v132 : (string -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v136 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v137 : (unit -> (struct (US2 * (int32 [])) [])), v138 : ((struct (US2 * (int32 [])) []) -> unit), v139 : (unit -> (struct (int32 * obj) [])), v140 : ((struct (int32 * obj) []) -> unit), v141 : (unit -> (struct (int32 * obj) [])), v142 : ((struct (int32 * obj) []) -> unit), v143 : (unit -> (struct (int32 * int32) [])), v144 : ((struct (int32 * int32) []) -> unit), v145 : (unit -> US4), v146 : (US4 -> unit), v147 : (unit -> US5), v148 : (US5 -> unit)) = v126.Invoke v123 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v129, v130)
and closure73 (v0 : Mut9, v1 : (unit -> int32)) () : (JSX.Element []) =
    let v2 : int32 = v1 ()
    let v3 : (int32 -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure72 (v0 : Mut9, v1 : (unit -> int32)) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let struct (v6 : US6, v7 : US6, v8 : US6, v9 : US7, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US8, v17 : US9, v18 : US6, v19 : US6, v20 : US8, v21 : US10, v22 : US6, v23 : US6, v24 : US6, v25 : US11, v26 : US8, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US12, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US13, v49 : US14, v50 : US13, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US12, v69 : US6, v70 : US6, v71 : US10, v72 : US10, v73 : US6, v74 : US5, v75 : US6) = method3()
    let v83 : US9 =
        match v17 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v77) -> (* Some *)
            let v78 : string = "children"
            let v79 : string = "solid-js"
            let v80 : JS.Function = import v78 v79
            let v81 : (unit -> (JSX.Element [])) = v80.Invoke v77 |> unbox<unit -> JSX.Element[]>
            US9_1(v81)
    let v86 : (unit -> (JSX.Element [])) =
        match v83 with
        | US9_0 -> (* None *)
            closure73(v0, v1)
        | US9_1(v85) -> (* Some *)
            v85
    let v87 : US9 = US9_1(v86)
    let v88 : ((string * obj) []) = method7(v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v87, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75)
    let v89 : obj = createObj v88
    let v90 : (unit -> (JSX.Element [])) = closure73(v0, v1)
    emitJsExpr (v89, v90) "$0.children = $1"
    let v91 : (obj -> JSX.Element) = v5 |> unbox<(obj -> JSX.Element)>
    let v92 : string = "createComponent"
    let v93 : string = "solid-js"
    let v94 : JS.Function = import v92 v93
    let v95 : JSX.Element = v94.Invoke (v91, v89) |> unbox<JSX.Element>
    [|v95|]
and closure71 (v0 : Mut9, v1 : (unit -> int32)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure72(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v78, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method23 (v0 : Mut9) : JSX.Element =
    let v1 : (unit -> struct ((unit -> int32) * (int32 -> unit))) = v0.l1
    let struct (v2 : (unit -> int32), v3 : (int32 -> unit)) = v1 ()
    let v4 : US14 = US14_0
    let v5 : US14 = US14_0
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure71(v0, v2)
    let v7 : US15 = US15_2
    let v8 : Mut4 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7} : Mut4
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : (Mut4 -> JSX.Element) = closure16()
    let v13 : JSX.Element = v11.Invoke (v12, v8) |> unbox<JSX.Element>
    v13
and closure70 () (v0 : Mut9) : JSX.Element =
    method23(v0)
and closure74 () (v0 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) : obj =
    let v1 : int32 = v0.Length
    let v2 : (struct (US0 * string * string * string) []) = Array.zeroCreate<struct (US0 * string * string * string)> (v1)
    let v3 : Mut3 = {l0 = 0} : Mut3
    while method5(v1, v3) do
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
and closure75 () () : struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit)) =
    let v123 : obj = emitJsExpr () "components_spi.state_context"
    let v124 : string = "useContext"
    let v125 : string = "solid-js"
    let v126 : JS.Function = import v124 v125
    let struct (v127 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v128 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v129 : (unit -> int32), v130 : (int32 -> unit), v131 : (unit -> string), v132 : (string -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v136 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v137 : (unit -> (struct (US2 * (int32 [])) [])), v138 : ((struct (US2 * (int32 [])) []) -> unit), v139 : (unit -> (struct (int32 * obj) [])), v140 : ((struct (int32 * obj) []) -> unit), v141 : (unit -> (struct (int32 * obj) [])), v142 : ((struct (int32 * obj) []) -> unit), v143 : (unit -> (struct (int32 * int32) [])), v144 : ((struct (int32 * int32) []) -> unit), v145 : (unit -> US4), v146 : (US4 -> unit), v147 : (unit -> US5), v148 : (US5 -> unit)) = v126.Invoke v123 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v127, v128)
and closure79 (v0 : Mut10, v1 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []))) () : (JSX.Element []) =
    let v2 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) = v1 ()
    let v3 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure78 (v0 : Mut10, v1 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []))) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let struct (v6 : US6, v7 : US6, v8 : US6, v9 : US7, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US8, v17 : US9, v18 : US6, v19 : US6, v20 : US8, v21 : US10, v22 : US6, v23 : US6, v24 : US6, v25 : US11, v26 : US8, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US12, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US13, v49 : US14, v50 : US13, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US12, v69 : US6, v70 : US6, v71 : US10, v72 : US10, v73 : US6, v74 : US5, v75 : US6) = method3()
    let v83 : US9 =
        match v17 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v77) -> (* Some *)
            let v78 : string = "children"
            let v79 : string = "solid-js"
            let v80 : JS.Function = import v78 v79
            let v81 : (unit -> (JSX.Element [])) = v80.Invoke v77 |> unbox<unit -> JSX.Element[]>
            US9_1(v81)
    let v86 : (unit -> (JSX.Element [])) =
        match v83 with
        | US9_0 -> (* None *)
            closure79(v0, v1)
        | US9_1(v85) -> (* Some *)
            v85
    let v87 : US9 = US9_1(v86)
    let v88 : ((string * obj) []) = method7(v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v87, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75)
    let v89 : obj = createObj v88
    let v90 : (unit -> (JSX.Element [])) = closure79(v0, v1)
    emitJsExpr (v89, v90) "$0.children = $1"
    let v91 : (obj -> JSX.Element) = v5 |> unbox<(obj -> JSX.Element)>
    let v92 : string = "createComponent"
    let v93 : string = "solid-js"
    let v94 : JS.Function = import v92 v93
    let v95 : JSX.Element = v94.Invoke (v91, v89) |> unbox<JSX.Element>
    [|v95|]
and closure77 (v0 : Mut10, v1 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure78(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v78, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method24 (v0 : Mut10) : JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v3 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit)) = v1 ()
    let v4 : US14 = US14_0
    let v5 : US14 = US14_0
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure77(v0, v2)
    let v7 : US15 = US15_2
    let v8 : Mut4 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7} : Mut4
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : (Mut4 -> JSX.Element) = closure16()
    let v13 : JSX.Element = v11.Invoke (v12, v8) |> unbox<JSX.Element>
    v13
and closure76 () (v0 : Mut10) : JSX.Element =
    method24(v0)
and closure80 () (v0 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) : obj =
    let v1 : obj = v0
    v1
and closure81 () () : struct ((unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit)) =
    let v123 : obj = emitJsExpr () "components_spi.state_context"
    let v124 : string = "useContext"
    let v125 : string = "solid-js"
    let v126 : JS.Function = import v124 v125
    let struct (v127 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v128 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v129 : (unit -> int32), v130 : (int32 -> unit), v131 : (unit -> string), v132 : (string -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v136 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v137 : (unit -> (struct (US2 * (int32 [])) [])), v138 : ((struct (US2 * (int32 [])) []) -> unit), v139 : (unit -> (struct (int32 * obj) [])), v140 : ((struct (int32 * obj) []) -> unit), v141 : (unit -> (struct (int32 * obj) [])), v142 : ((struct (int32 * obj) []) -> unit), v143 : (unit -> (struct (int32 * int32) [])), v144 : ((struct (int32 * int32) []) -> unit), v145 : (unit -> US4), v146 : (US4 -> unit), v147 : (unit -> US5), v148 : (US5 -> unit)) = v126.Invoke v123 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v135, v136)
and closure85 (v0 : Mut11, v1 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []))) () : (JSX.Element []) =
    let v2 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) = v1 ()
    let v3 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure84 (v0 : Mut11, v1 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []))) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let struct (v6 : US6, v7 : US6, v8 : US6, v9 : US7, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US8, v17 : US9, v18 : US6, v19 : US6, v20 : US8, v21 : US10, v22 : US6, v23 : US6, v24 : US6, v25 : US11, v26 : US8, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US12, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US13, v49 : US14, v50 : US13, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US12, v69 : US6, v70 : US6, v71 : US10, v72 : US10, v73 : US6, v74 : US5, v75 : US6) = method3()
    let v83 : US9 =
        match v17 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v77) -> (* Some *)
            let v78 : string = "children"
            let v79 : string = "solid-js"
            let v80 : JS.Function = import v78 v79
            let v81 : (unit -> (JSX.Element [])) = v80.Invoke v77 |> unbox<unit -> JSX.Element[]>
            US9_1(v81)
    let v86 : (unit -> (JSX.Element [])) =
        match v83 with
        | US9_0 -> (* None *)
            closure85(v0, v1)
        | US9_1(v85) -> (* Some *)
            v85
    let v87 : US9 = US9_1(v86)
    let v88 : ((string * obj) []) = method7(v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v87, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75)
    let v89 : obj = createObj v88
    let v90 : (unit -> (JSX.Element [])) = closure85(v0, v1)
    emitJsExpr (v89, v90) "$0.children = $1"
    let v91 : (obj -> JSX.Element) = v5 |> unbox<(obj -> JSX.Element)>
    let v92 : string = "createComponent"
    let v93 : string = "solid-js"
    let v94 : JS.Function = import v92 v93
    let v95 : JSX.Element = v94.Invoke (v91, v89) |> unbox<JSX.Element>
    [|v95|]
and closure83 (v0 : Mut11, v1 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure84(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v78, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method25 (v0 : Mut11) : JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v3 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit)) = v1 ()
    let v4 : US14 = US14_0
    let v5 : US14 = US14_0
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure83(v0, v2)
    let v7 : US15 = US15_2
    let v8 : Mut4 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7} : Mut4
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : (Mut4 -> JSX.Element) = closure16()
    let v13 : JSX.Element = v11.Invoke (v12, v8) |> unbox<JSX.Element>
    v13
and closure82 () (v0 : Mut11) : JSX.Element =
    method25(v0)
and closure86 () (v0 : US4) : obj =
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
and closure87 () () : struct ((unit -> US4) * (US4 -> unit)) =
    let v123 : obj = emitJsExpr () "components_spi.state_context"
    let v124 : string = "useContext"
    let v125 : string = "solid-js"
    let v126 : JS.Function = import v124 v125
    let struct (v127 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v128 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v129 : (unit -> int32), v130 : (int32 -> unit), v131 : (unit -> string), v132 : (string -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v136 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v137 : (unit -> (struct (US2 * (int32 [])) [])), v138 : ((struct (US2 * (int32 [])) []) -> unit), v139 : (unit -> (struct (int32 * obj) [])), v140 : ((struct (int32 * obj) []) -> unit), v141 : (unit -> (struct (int32 * obj) [])), v142 : ((struct (int32 * obj) []) -> unit), v143 : (unit -> (struct (int32 * int32) [])), v144 : ((struct (int32 * int32) []) -> unit), v145 : (unit -> US4), v146 : (US4 -> unit), v147 : (unit -> US5), v148 : (US5 -> unit)) = v126.Invoke v123 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v145, v146)
and closure91 (v0 : Mut12, v1 : (unit -> US4)) () : (JSX.Element []) =
    let v2 : US4 = v1 ()
    let v3 : (US4 -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure90 (v0 : Mut12, v1 : (unit -> US4)) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let struct (v6 : US6, v7 : US6, v8 : US6, v9 : US7, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US8, v17 : US9, v18 : US6, v19 : US6, v20 : US8, v21 : US10, v22 : US6, v23 : US6, v24 : US6, v25 : US11, v26 : US8, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US12, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US13, v49 : US14, v50 : US13, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US12, v69 : US6, v70 : US6, v71 : US10, v72 : US10, v73 : US6, v74 : US5, v75 : US6) = method3()
    let v83 : US9 =
        match v17 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v77) -> (* Some *)
            let v78 : string = "children"
            let v79 : string = "solid-js"
            let v80 : JS.Function = import v78 v79
            let v81 : (unit -> (JSX.Element [])) = v80.Invoke v77 |> unbox<unit -> JSX.Element[]>
            US9_1(v81)
    let v86 : (unit -> (JSX.Element [])) =
        match v83 with
        | US9_0 -> (* None *)
            closure91(v0, v1)
        | US9_1(v85) -> (* Some *)
            v85
    let v87 : US9 = US9_1(v86)
    let v88 : ((string * obj) []) = method7(v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v87, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75)
    let v89 : obj = createObj v88
    let v90 : (unit -> (JSX.Element [])) = closure91(v0, v1)
    emitJsExpr (v89, v90) "$0.children = $1"
    let v91 : (obj -> JSX.Element) = v5 |> unbox<(obj -> JSX.Element)>
    let v92 : string = "createComponent"
    let v93 : string = "solid-js"
    let v94 : JS.Function = import v92 v93
    let v95 : JSX.Element = v94.Invoke (v91, v89) |> unbox<JSX.Element>
    [|v95|]
and closure89 (v0 : Mut12, v1 : (unit -> US4)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure90(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v78, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method26 (v0 : Mut12) : JSX.Element =
    let v1 : (unit -> struct ((unit -> US4) * (US4 -> unit))) = v0.l1
    let struct (v2 : (unit -> US4), v3 : (US4 -> unit)) = v1 ()
    let v4 : US14 = US14_0
    let v5 : US14 = US14_0
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure89(v0, v2)
    let v7 : US15 = US15_2
    let v8 : Mut4 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7} : Mut4
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : (Mut4 -> JSX.Element) = closure16()
    let v13 : JSX.Element = v11.Invoke (v12, v8) |> unbox<JSX.Element>
    v13
and closure88 () (v0 : Mut12) : JSX.Element =
    method26(v0)
and closure92 () (v0 : US5) : obj =
    let v1 : obj = v0
    v1
and closure93 () () : struct ((unit -> US5) * (US5 -> unit)) =
    let v123 : obj = emitJsExpr () "components_spi.state_context"
    let v124 : string = "useContext"
    let v125 : string = "solid-js"
    let v126 : JS.Function = import v124 v125
    let struct (v127 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v128 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v129 : (unit -> int32), v130 : (int32 -> unit), v131 : (unit -> string), v132 : (string -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v136 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v137 : (unit -> (struct (US2 * (int32 [])) [])), v138 : ((struct (US2 * (int32 [])) []) -> unit), v139 : (unit -> (struct (int32 * obj) [])), v140 : ((struct (int32 * obj) []) -> unit), v141 : (unit -> (struct (int32 * obj) [])), v142 : ((struct (int32 * obj) []) -> unit), v143 : (unit -> (struct (int32 * int32) [])), v144 : ((struct (int32 * int32) []) -> unit), v145 : (unit -> US4), v146 : (US4 -> unit), v147 : (unit -> US5), v148 : (US5 -> unit)) = v126.Invoke v123 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v147, v148)
and closure97 (v0 : Mut13, v1 : (unit -> US5)) () : (JSX.Element []) =
    let v2 : US5 = v1 ()
    let v3 : (US5 -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure96 (v0 : Mut13, v1 : (unit -> US5)) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let struct (v6 : US6, v7 : US6, v8 : US6, v9 : US7, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US8, v17 : US9, v18 : US6, v19 : US6, v20 : US8, v21 : US10, v22 : US6, v23 : US6, v24 : US6, v25 : US11, v26 : US8, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US12, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US13, v49 : US14, v50 : US13, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US12, v69 : US6, v70 : US6, v71 : US10, v72 : US10, v73 : US6, v74 : US5, v75 : US6) = method3()
    let v83 : US9 =
        match v17 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v77) -> (* Some *)
            let v78 : string = "children"
            let v79 : string = "solid-js"
            let v80 : JS.Function = import v78 v79
            let v81 : (unit -> (JSX.Element [])) = v80.Invoke v77 |> unbox<unit -> JSX.Element[]>
            US9_1(v81)
    let v86 : (unit -> (JSX.Element [])) =
        match v83 with
        | US9_0 -> (* None *)
            closure97(v0, v1)
        | US9_1(v85) -> (* Some *)
            v85
    let v87 : US9 = US9_1(v86)
    let v88 : ((string * obj) []) = method7(v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v87, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75)
    let v89 : obj = createObj v88
    let v90 : (unit -> (JSX.Element [])) = closure97(v0, v1)
    emitJsExpr (v89, v90) "$0.children = $1"
    let v91 : (obj -> JSX.Element) = v5 |> unbox<(obj -> JSX.Element)>
    let v92 : string = "createComponent"
    let v93 : string = "solid-js"
    let v94 : JS.Function = import v92 v93
    let v95 : JSX.Element = v94.Invoke (v91, v89) |> unbox<JSX.Element>
    [|v95|]
and closure95 (v0 : Mut13, v1 : (unit -> US5)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure96(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v78, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method27 (v0 : Mut13) : JSX.Element =
    let v1 : (unit -> struct ((unit -> US5) * (US5 -> unit))) = v0.l1
    let struct (v2 : (unit -> US5), v3 : (US5 -> unit)) = v1 ()
    let v4 : US14 = US14_0
    let v5 : US14 = US14_0
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure95(v0, v2)
    let v7 : US15 = US15_2
    let v8 : Mut4 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7} : Mut4
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : (Mut4 -> JSX.Element) = closure16()
    let v13 : JSX.Element = v11.Invoke (v12, v8) |> unbox<JSX.Element>
    v13
and closure94 () (v0 : Mut13) : JSX.Element =
    method27(v0)
and closure98 () (v0 : (struct (int32 * int32) [])) : obj =
    let v1 : obj = v0
    v1
and closure99 () () : struct ((unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit)) =
    let v123 : obj = emitJsExpr () "components_spi.state_context"
    let v124 : string = "useContext"
    let v125 : string = "solid-js"
    let v126 : JS.Function = import v124 v125
    let struct (v127 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v128 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v129 : (unit -> int32), v130 : (int32 -> unit), v131 : (unit -> string), v132 : (string -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v136 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v137 : (unit -> (struct (US2 * (int32 [])) [])), v138 : ((struct (US2 * (int32 [])) []) -> unit), v139 : (unit -> (struct (int32 * obj) [])), v140 : ((struct (int32 * obj) []) -> unit), v141 : (unit -> (struct (int32 * obj) [])), v142 : ((struct (int32 * obj) []) -> unit), v143 : (unit -> (struct (int32 * int32) [])), v144 : ((struct (int32 * int32) []) -> unit), v145 : (unit -> US4), v146 : (US4 -> unit), v147 : (unit -> US5), v148 : (US5 -> unit)) = v126.Invoke v123 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v143, v144)
and closure103 (v0 : Mut14, v1 : (unit -> (struct (int32 * int32) []))) () : (JSX.Element []) =
    let v2 : (struct (int32 * int32) []) = v1 ()
    let v3 : ((struct (int32 * int32) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure102 (v0 : Mut14, v1 : (unit -> (struct (int32 * int32) []))) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let struct (v6 : US6, v7 : US6, v8 : US6, v9 : US7, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US8, v17 : US9, v18 : US6, v19 : US6, v20 : US8, v21 : US10, v22 : US6, v23 : US6, v24 : US6, v25 : US11, v26 : US8, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US12, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US13, v49 : US14, v50 : US13, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US12, v69 : US6, v70 : US6, v71 : US10, v72 : US10, v73 : US6, v74 : US5, v75 : US6) = method3()
    let v83 : US9 =
        match v17 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v77) -> (* Some *)
            let v78 : string = "children"
            let v79 : string = "solid-js"
            let v80 : JS.Function = import v78 v79
            let v81 : (unit -> (JSX.Element [])) = v80.Invoke v77 |> unbox<unit -> JSX.Element[]>
            US9_1(v81)
    let v86 : (unit -> (JSX.Element [])) =
        match v83 with
        | US9_0 -> (* None *)
            closure103(v0, v1)
        | US9_1(v85) -> (* Some *)
            v85
    let v87 : US9 = US9_1(v86)
    let v88 : ((string * obj) []) = method7(v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v87, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75)
    let v89 : obj = createObj v88
    let v90 : (unit -> (JSX.Element [])) = closure103(v0, v1)
    emitJsExpr (v89, v90) "$0.children = $1"
    let v91 : (obj -> JSX.Element) = v5 |> unbox<(obj -> JSX.Element)>
    let v92 : string = "createComponent"
    let v93 : string = "solid-js"
    let v94 : JS.Function = import v92 v93
    let v95 : JSX.Element = v94.Invoke (v91, v89) |> unbox<JSX.Element>
    [|v95|]
and closure101 (v0 : Mut14, v1 : (unit -> (struct (int32 * int32) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure102(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v78, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method28 (v0 : Mut14) : JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct (int32 * int32) [])), v3 : ((struct (int32 * int32) []) -> unit)) = v1 ()
    let v4 : US14 = US14_0
    let v5 : US14 = US14_0
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure101(v0, v2)
    let v7 : US15 = US15_2
    let v8 : Mut4 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7} : Mut4
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : (Mut4 -> JSX.Element) = closure16()
    let v13 : JSX.Element = v11.Invoke (v12, v8) |> unbox<JSX.Element>
    v13
and closure100 () (v0 : Mut14) : JSX.Element =
    method28(v0)
and closure104 () (v0 : (struct (int32 * obj) [])) : obj =
    let v1 : obj = v0
    v1
and closure105 () () : struct ((unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit)) =
    let v123 : obj = emitJsExpr () "components_spi.state_context"
    let v124 : string = "useContext"
    let v125 : string = "solid-js"
    let v126 : JS.Function = import v124 v125
    let struct (v127 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v128 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v129 : (unit -> int32), v130 : (int32 -> unit), v131 : (unit -> string), v132 : (string -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v136 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v137 : (unit -> (struct (US2 * (int32 [])) [])), v138 : ((struct (US2 * (int32 [])) []) -> unit), v139 : (unit -> (struct (int32 * obj) [])), v140 : ((struct (int32 * obj) []) -> unit), v141 : (unit -> (struct (int32 * obj) [])), v142 : ((struct (int32 * obj) []) -> unit), v143 : (unit -> (struct (int32 * int32) [])), v144 : ((struct (int32 * int32) []) -> unit), v145 : (unit -> US4), v146 : (US4 -> unit), v147 : (unit -> US5), v148 : (US5 -> unit)) = v126.Invoke v123 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v141, v142)
and closure109 (v0 : Mut15, v1 : (unit -> (struct (int32 * obj) []))) () : (JSX.Element []) =
    let v2 : (struct (int32 * obj) []) = v1 ()
    let v3 : ((struct (int32 * obj) []) -> obj) = v0.l0
    let v4 : obj = v3 v2
    let v5 : string = emitJsExpr v4 "JSON.stringify($0, null, 2)"
    let v6 : JSX.Element = v5 |> unbox<JSX.Element>
    let v7 : JSX.Element = Html.fragment [ v6 ]
    [|v7|]
and closure108 (v0 : Mut15, v1 : (unit -> (struct (int32 * obj) []))) () : (JSX.Element []) =
    let v2 : string = "hope"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let v5 : JS.Function = v4?pre
    let struct (v6 : US6, v7 : US6, v8 : US6, v9 : US7, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US8, v17 : US9, v18 : US6, v19 : US6, v20 : US8, v21 : US10, v22 : US6, v23 : US6, v24 : US6, v25 : US11, v26 : US8, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US12, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US13, v49 : US14, v50 : US13, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US12, v69 : US6, v70 : US6, v71 : US10, v72 : US10, v73 : US6, v74 : US5, v75 : US6) = method3()
    let v83 : US9 =
        match v17 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v77) -> (* Some *)
            let v78 : string = "children"
            let v79 : string = "solid-js"
            let v80 : JS.Function = import v78 v79
            let v81 : (unit -> (JSX.Element [])) = v80.Invoke v77 |> unbox<unit -> JSX.Element[]>
            US9_1(v81)
    let v86 : (unit -> (JSX.Element [])) =
        match v83 with
        | US9_0 -> (* None *)
            closure109(v0, v1)
        | US9_1(v85) -> (* Some *)
            v85
    let v87 : US9 = US9_1(v86)
    let v88 : ((string * obj) []) = method7(v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v87, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75)
    let v89 : obj = createObj v88
    let v90 : (unit -> (JSX.Element [])) = closure109(v0, v1)
    emitJsExpr (v89, v90) "$0.children = $1"
    let v91 : (obj -> JSX.Element) = v5 |> unbox<(obj -> JSX.Element)>
    let v92 : string = "createComponent"
    let v93 : string = "solid-js"
    let v94 : JS.Function = import v92 v93
    let v95 : JSX.Element = v94.Invoke (v91, v89) |> unbox<JSX.Element>
    [|v95|]
and closure107 (v0 : Mut15, v1 : (unit -> (struct (int32 * obj) []))) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = v0.l2
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure108(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "8px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v78, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and method29 (v0 : Mut15) : JSX.Element =
    let v1 : (unit -> struct ((unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit))) = v0.l1
    let struct (v2 : (unit -> (struct (int32 * obj) [])), v3 : ((struct (int32 * obj) []) -> unit)) = v1 ()
    let v4 : US14 = US14_0
    let v5 : US14 = US14_0
    let v6 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure107(v0, v2)
    let v7 : US15 = US15_2
    let v8 : Mut4 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7} : Mut4
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : (Mut4 -> JSX.Element) = closure16()
    let v13 : JSX.Element = v11.Invoke (v12, v8) |> unbox<JSX.Element>
    v13
and closure106 () (v0 : Mut15) : JSX.Element =
    method29(v0)
and closure110 () () : struct ((unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit)) =
    let v123 : obj = emitJsExpr () "components_spi.state_context"
    let v124 : string = "useContext"
    let v125 : string = "solid-js"
    let v126 : JS.Function = import v124 v125
    let struct (v127 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v128 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v129 : (unit -> int32), v130 : (int32 -> unit), v131 : (unit -> string), v132 : (string -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v136 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v137 : (unit -> (struct (US2 * (int32 [])) [])), v138 : ((struct (US2 * (int32 [])) []) -> unit), v139 : (unit -> (struct (int32 * obj) [])), v140 : ((struct (int32 * obj) []) -> unit), v141 : (unit -> (struct (int32 * obj) [])), v142 : ((struct (int32 * obj) []) -> unit), v143 : (unit -> (struct (int32 * int32) [])), v144 : ((struct (int32 * int32) []) -> unit), v145 : (unit -> US4), v146 : (US4 -> unit), v147 : (unit -> US5), v148 : (US5 -> unit)) = v126.Invoke v123 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    struct (v139, v140)
and closure60 () () : (JSX.Element []) =
    let v0 : (string -> obj) = closure61()
    let v1 : (unit -> struct ((unit -> string) * (string -> unit))) = closure62()
    let v2 : string = "chain.token"
    let v3 : Mut8 = {l0 = v0; l1 = v1; l2 = v2} : Mut8
    let v4 : string = "createComponent"
    let v5 : string = "solid-js"
    let v6 : JS.Function = import v4 v5
    let v7 : (Mut8 -> JSX.Element) = closure63()
    let v8 : JSX.Element = v6.Invoke (v7, v3) |> unbox<JSX.Element>
    let v9 : (unit -> struct ((unit -> string) * (string -> unit))) = closure67()
    let v10 : string = "chain.url"
    let v11 : Mut8 = {l0 = v0; l1 = v9; l2 = v10} : Mut8
    let v12 : JS.Function = import v4 v5
    let v13 : JSX.Element = v12.Invoke (v7, v11) |> unbox<JSX.Element>
    let v14 : (int32 -> obj) = closure68()
    let v15 : (unit -> struct ((unit -> int32) * (int32 -> unit))) = closure69()
    let v16 : string = "chain.port"
    let v17 : Mut9 = {l0 = v14; l1 = v15; l2 = v16} : Mut9
    let v18 : JS.Function = import v4 v5
    let v19 : (Mut9 -> JSX.Element) = closure70()
    let v20 : JSX.Element = v18.Invoke (v19, v17) |> unbox<JSX.Element>
    let v21 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> obj) = closure74()
    let v22 : (unit -> struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit))) = closure75()
    let v23 : string = "chain.accounts"
    let v24 : Mut10 = {l0 = v21; l1 = v22; l2 = v23} : Mut10
    let v25 : JS.Function = import v4 v5
    let v26 : (Mut10 -> JSX.Element) = closure76()
    let v27 : JSX.Element = v25.Invoke (v26, v24) |> unbox<JSX.Element>
    let v28 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> obj) = closure80()
    let v29 : (unit -> struct ((unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit))) = closure81()
    let v30 : string = "db.connection"
    let v31 : Mut11 = {l0 = v28; l1 = v29; l2 = v30} : Mut11
    let v32 : JS.Function = import v4 v5
    let v33 : (Mut11 -> JSX.Element) = closure82()
    let v34 : JSX.Element = v32.Invoke (v33, v31) |> unbox<JSX.Element>
    let v35 : (US4 -> obj) = closure86()
    let v36 : (unit -> struct ((unit -> US4) * (US4 -> unit))) = closure87()
    let v37 : string = "settings.log_level"
    let v38 : Mut12 = {l0 = v35; l1 = v36; l2 = v37} : Mut12
    let v39 : JS.Function = import v4 v5
    let v40 : (Mut12 -> JSX.Element) = closure88()
    let v41 : JSX.Element = v39.Invoke (v40, v38) |> unbox<JSX.Element>
    let v42 : (US5 -> obj) = closure92()
    let v43 : (unit -> struct ((unit -> US5) * (US5 -> unit))) = closure93()
    let v44 : string = "settings.ui.modal"
    let v45 : Mut13 = {l0 = v42; l1 = v43; l2 = v44} : Mut13
    let v46 : JS.Function = import v4 v5
    let v47 : (Mut13 -> JSX.Element) = closure94()
    let v48 : JSX.Element = v46.Invoke (v47, v45) |> unbox<JSX.Element>
    let v49 : ((struct (int32 * int32) []) -> obj) = closure98()
    let v50 : (unit -> struct ((unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit))) = closure99()
    let v51 : string = "profile.tmp.counter"
    let v52 : Mut14 = {l0 = v49; l1 = v50; l2 = v51} : Mut14
    let v53 : JS.Function = import v4 v5
    let v54 : (Mut14 -> JSX.Element) = closure100()
    let v55 : JSX.Element = v53.Invoke (v54, v52) |> unbox<JSX.Element>
    let v56 : ((struct (int32 * obj) []) -> obj) = closure104()
    let v57 : (unit -> struct ((unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit))) = closure105()
    let v58 : string = "profile.tmp.chain_status"
    let v59 : Mut15 = {l0 = v56; l1 = v57; l2 = v58} : Mut15
    let v60 : JS.Function = import v4 v5
    let v61 : (Mut15 -> JSX.Element) = closure106()
    let v62 : JSX.Element = v60.Invoke (v61, v59) |> unbox<JSX.Element>
    let v63 : (unit -> struct ((unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit))) = closure110()
    let v64 : string = "profile.tmp.chain_deploy"
    let v65 : Mut15 = {l0 = v56; l1 = v63; l2 = v64} : Mut15
    let v66 : JS.Function = import v4 v5
    let v67 : JSX.Element = v66.Invoke (v61, v65) |> unbox<JSX.Element>
    [|v8; v13; v20; v27; v34; v41; v48; v55; v62; v67|]
and closure59 () () : (JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : JS.Function = v2?pre
    let struct (v4 : US6, v5 : US6, v6 : US6, v7 : US7, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US8, v15 : US9, v16 : US6, v17 : US6, v18 : US8, v19 : US10, v20 : US6, v21 : US6, v22 : US6, v23 : US11, v24 : US8, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US13, v47 : US14, v48 : US13, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US12, v67 : US6, v68 : US6, v69 : US10, v70 : US10, v71 : US6, v72 : US5, v73 : US6) = method3()
    let v81 : US9 =
        match v15 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v75) -> (* Some *)
            let v76 : string = "children"
            let v77 : string = "solid-js"
            let v78 : JS.Function = import v76 v77
            let v79 : (unit -> (JSX.Element [])) = v78.Invoke v75 |> unbox<unit -> JSX.Element[]>
            US9_1(v79)
    let v84 : (unit -> (JSX.Element [])) =
        match v81 with
        | US9_0 -> (* None *)
            closure60()
        | US9_1(v83) -> (* Some *)
            v83
    let v85 : US9 = US9_1(v84)
    let v86 : string = "8px"
    let v87 : US6 = US6_1(v86)
    let v88 : ((string * obj) []) = method7(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v85, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v87, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73)
    let v89 : obj = createObj v88
    let v90 : (unit -> (JSX.Element [])) = closure60()
    emitJsExpr (v89, v90) "$0.children = $1"
    let v91 : (obj -> JSX.Element) = v3 |> unbox<(obj -> JSX.Element)>
    let v92 : string = "createComponent"
    let v93 : string = "solid-js"
    let v94 : JS.Function = import v92 v93
    let v95 : JSX.Element = v94.Invoke (v91, v89) |> unbox<JSX.Element>
    [|v95|]
and closure58 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "State"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure59()
    let v74 : US9 = US9_1(v73)
    let v75 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure7 (v0 : (US4 -> unit), v1 : (unit -> US4)) () : (JSX.Element []) =
    let v2 : US14 = US14_0
    let v3 : US14 = US14_0
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure8(v0, v1)
    let v5 : US15 = US15_2
    let v6 : Mut4 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5} : Mut4
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : (Mut4 -> JSX.Element) = closure16()
    let v11 : JSX.Element = v9.Invoke (v10, v6) |> unbox<JSX.Element>
    let v12 : US14 = US14_0
    let v13 : US14 = US14_0
    let v14 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure58()
    let v15 : US15 = US15_2
    let v16 : Mut4 = {l0 = v12; l1 = v13; l2 = v14; l3 = v15} : Mut4
    let v17 : JS.Function = import v7 v8
    let v18 : JSX.Element = v17.Invoke (v10, v16) |> unbox<JSX.Element>
    [|v11; v18|]
and closure113 () () : (JSX.Element []) =
    [||]
and closure112 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : string = "Tbody"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : US9 = v0.l11
    let v7 : (unit -> (JSX.Element [])) =
        match v4 with
        | US9_0 -> (* None *)
            closure113()
        | US9_1(v6) -> (* Some *)
            v6
    let struct (v8 : US6, v9 : US6, v10 : US6, v11 : US7, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US6, v17 : US6, v18 : US8, v19 : US9, v20 : US6, v21 : US6, v22 : US8, v23 : US10, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US8, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US12, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US13, v51 : US14, v52 : US13, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US6, v69 : US6, v70 : US12, v71 : US6, v72 : US6, v73 : US10, v74 : US10, v75 : US6, v76 : US5, v77 : US6) = method3()
    let v85 : US9 =
        match v19 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v79) -> (* Some *)
            let v80 : string = "children"
            let v81 : string = "solid-js"
            let v82 : JS.Function = import v80 v81
            let v83 : (unit -> (JSX.Element [])) = v82.Invoke v79 |> unbox<unit -> JSX.Element[]>
            US9_1(v83)
    let v87 : (unit -> (JSX.Element [])) =
        match v85 with
        | US9_0 -> (* None *)
            v7
        | US9_1(v86) -> (* Some *)
            v86
    let v88 : string = "$blackAlpha7"
    let v89 : US6 = US6_1(v88)
    let v90 : US9 = US9_1(v87)
    let v91 : string = "flex"
    let v92 : US6 = US6_1(v91)
    let v93 : string = "column"
    let v94 : US6 = US6_1(v93)
    let v95 : string = "-1px"
    let v96 : US6 = US6_1(v95)
    let v97 : ((string * obj) []) = method7(v8, v9, v10, v11, v89, v13, v14, v15, v16, v17, v18, v90, v20, v21, v22, v23, v24, v25, v92, v27, v28, v29, v94, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v96, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77)
    let v98 : obj = createObj v97
    emitJsExpr (v98, v7) "$0.children = $1"
    let v99 : (obj -> JSX.Element) = v3 |> unbox<(obj -> JSX.Element)>
    let v100 : string = "createComponent"
    let v101 : string = "solid-js"
    let v102 : JS.Function = import v100 v101
    let v103 : JSX.Element = v102.Invoke (v99, v98) |> unbox<JSX.Element>
    [|v103|]
and method30 (v0 : Mut1) : JSX.Element =
    let v1 : string = "Table"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US6, v5 : US6, v6 : US6, v7 : US7, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US8, v15 : US9, v16 : US6, v17 : US6, v18 : US8, v19 : US10, v20 : US6, v21 : US6, v22 : US6, v23 : US11, v24 : US8, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US13, v47 : US14, v48 : US13, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US12, v67 : US6, v68 : US6, v69 : US10, v70 : US10, v71 : US6, v72 : US5, v73 : US6) = method3()
    let v74 : US6 = v0.l48
    let v77 : string =
        match v74 with
        | US6_0 -> (* None *)
            let v75 : string = "hidden"
            v75
        | US6_1(v76) -> (* Some *)
            v76
    let v85 : US9 =
        match v15 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v79) -> (* Some *)
            let v80 : string = "children"
            let v81 : string = "solid-js"
            let v82 : JS.Function = import v80 v81
            let v83 : (unit -> (JSX.Element [])) = v82.Invoke v79 |> unbox<unit -> JSX.Element[]>
            US9_1(v83)
    let v88 : (unit -> (JSX.Element [])) =
        match v85 with
        | US9_0 -> (* None *)
            closure112(v0)
        | US9_1(v87) -> (* Some *)
            v87
    let v89 : US9 = US9_1(v88)
    let v90 : string = "flex"
    let v91 : US6 = US6_1(v90)
    let v92 : string = "1"
    let v93 : US6 = US6_1(v92)
    let v94 : string = "column"
    let v95 : US6 = US6_1(v94)
    let v96 : string = "hidden"
    let v97 : US6 = US6_1(v96)
    let v98 : US6 = US6_1(v77)
    let v99 : ((string * obj) []) = method7(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v89, v16, v17, v18, v19, v20, v21, v91, v23, v24, v93, v95, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v97, v98, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73)
    let v100 : obj = createObj v99
    let v101 : (unit -> (JSX.Element [])) = closure112(v0)
    emitJsExpr (v100, v101) "$0.children = $1"
    let v102 : (obj -> JSX.Element) = v3 |> unbox<(obj -> JSX.Element)>
    let v103 : string = "createComponent"
    let v104 : string = "solid-js"
    let v105 : JS.Function = import v103 v104
    let v106 : JSX.Element = v105.Invoke (v102, v100) |> unbox<JSX.Element>
    v106
and closure111 () (v0 : Mut1) : JSX.Element =
    method30(v0)
and closure6 (v0 : (US4 -> unit), v1 : (unit -> US4)) () : (JSX.Element []) =
    let struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) = method3()
    let v79 : US9 =
        match v13 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v73) -> (* Some *)
            let v74 : string = "children"
            let v75 : string = "solid-js"
            let v76 : JS.Function = import v74 v75
            let v77 : (unit -> (JSX.Element [])) = v76.Invoke v73 |> unbox<unit -> JSX.Element[]>
            US9_1(v77)
    let v82 : (unit -> (JSX.Element [])) =
        match v79 with
        | US9_0 -> (* None *)
            closure7(v0, v1)
        | US9_1(v81) -> (* Some *)
            v81
    let v83 : US9 = US9_1(v82)
    let v84 : Mut1 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v83; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66; l65 = v67; l66 = v68; l67 = v69; l68 = v70; l69 = v71} : Mut1
    let v85 : (unit -> (JSX.Element [])) = closure7(v0, v1)
    emitJsExpr (v84, v85) "$0.children = $1"
    let v86 : string = "createComponent"
    let v87 : string = "solid-js"
    let v88 : JS.Function = import v86 v87
    let v89 : (Mut1 -> JSX.Element) = closure111()
    let v90 : JSX.Element = v88.Invoke (v89, v84) |> unbox<JSX.Element>
    [|v90|]
and closure5 (v0 : (US4 -> unit), v1 : (unit -> US4)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = "Debug"
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure6(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v77, v65, v66, v67, v68, v69, v70, v71)
and closure4 (v0 : (US4 -> unit), v1 : (unit -> US4)) () : (JSX.Element []) =
    let v2 : US14 = US14_0
    let v3 : US14 = US14_0
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure5(v0, v1)
    let v5 : US15 = US15_0
    let v6 : Mut4 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5} : Mut4
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : (Mut4 -> JSX.Element) = closure16()
    let v11 : JSX.Element = v9.Invoke (v10, v6) |> unbox<JSX.Element>
    [|v11|]
and closure3 (v0 : (US4 -> unit), v1 : (unit -> US4)) () : (JSX.Element []) =
    let struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) = method3()
    let v79 : US9 =
        match v13 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v73) -> (* Some *)
            let v74 : string = "children"
            let v75 : string = "solid-js"
            let v76 : JS.Function = import v74 v75
            let v77 : (unit -> (JSX.Element [])) = v76.Invoke v73 |> unbox<unit -> JSX.Element[]>
            US9_1(v77)
    let v82 : (unit -> (JSX.Element [])) =
        match v79 with
        | US9_0 -> (* None *)
            closure4(v0, v1)
        | US9_1(v81) -> (* Some *)
            v81
    let v83 : US9 = US9_1(v82)
    let v84 : Mut1 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v83; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66; l65 = v67; l66 = v68; l67 = v69; l68 = v70; l69 = v71} : Mut1
    let v85 : (unit -> (JSX.Element [])) = closure4(v0, v1)
    emitJsExpr (v84, v85) "$0.children = $1"
    let v86 : string = "createComponent"
    let v87 : string = "solid-js"
    let v88 : JS.Function = import v86 v87
    let v89 : (Mut1 -> JSX.Element) = closure111()
    let v90 : JSX.Element = v88.Invoke (v89, v84) |> unbox<JSX.Element>
    [|v90|]
and method4 () : JSX.Element =
    let v123 : obj = emitJsExpr () "components_spi.state_context"
    let v124 : string = "useContext"
    let v125 : string = "solid-js"
    let v126 : JS.Function = import v124 v125
    let struct (v127 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v128 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v129 : (unit -> int32), v130 : (int32 -> unit), v131 : (unit -> string), v132 : (string -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v136 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v137 : (unit -> (struct (US2 * (int32 [])) [])), v138 : ((struct (US2 * (int32 [])) []) -> unit), v139 : (unit -> (struct (int32 * obj) [])), v140 : ((struct (int32 * obj) []) -> unit), v141 : (unit -> (struct (int32 * obj) [])), v142 : ((struct (int32 * obj) []) -> unit), v143 : (unit -> (struct (int32 * int32) [])), v144 : ((struct (int32 * int32) []) -> unit), v145 : (unit -> US4), v146 : (US4 -> unit), v147 : (unit -> US5), v148 : (US5 -> unit)) = v126.Invoke v123 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v149 : string = "Box"
    let v150 : string = "@hope-ui/solid"
    let v151 : JS.Function = import v149 v150
    let struct (v152 : US6, v153 : US6, v154 : US6, v155 : US7, v156 : US6, v157 : US6, v158 : US6, v159 : US6, v160 : US6, v161 : US6, v162 : US8, v163 : US9, v164 : US6, v165 : US6, v166 : US8, v167 : US10, v168 : US6, v169 : US6, v170 : US6, v171 : US11, v172 : US8, v173 : US6, v174 : US6, v175 : US6, v176 : US6, v177 : US6, v178 : US6, v179 : US12, v180 : US6, v181 : US6, v182 : US6, v183 : US12, v184 : US6, v185 : US6, v186 : US6, v187 : US6, v188 : US6, v189 : US6, v190 : US6, v191 : US6, v192 : US6, v193 : US6, v194 : US13, v195 : US14, v196 : US13, v197 : US6, v198 : US6, v199 : US6, v200 : US6, v201 : US6, v202 : US6, v203 : US6, v204 : US6, v205 : US6, v206 : US6, v207 : US6, v208 : US6, v209 : US6, v210 : US6, v211 : US6, v212 : US6, v213 : US6, v214 : US12, v215 : US6, v216 : US6, v217 : US10, v218 : US10, v219 : US6, v220 : US5, v221 : US6) = method3()
    let v228 : US9 =
        match v163 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v223) -> (* Some *)
            let v224 : string = "children"
            let v225 : JS.Function = import v224 v125
            let v226 : (unit -> (JSX.Element [])) = v225.Invoke v223 |> unbox<unit -> JSX.Element[]>
            US9_1(v226)
    let v231 : (unit -> (JSX.Element [])) =
        match v228 with
        | US9_0 -> (* None *)
            closure3(v146, v145)
        | US9_1(v230) -> (* Some *)
            v230
    let v232 : string = "$blackAlpha12"
    let v233 : US6 = US6_1(v232)
    let v234 : string = "0"
    let v235 : US6 = US6_1(v234)
    let v236 : US9 = US9_1(v231)
    let v237 : string = "flex"
    let v238 : US6 = US6_1(v237)
    let v239 : string = "column"
    let v240 : US6 = US6_1(v239)
    let v241 : string = "80vh"
    let v242 : US6 = US6_1(v241)
    let v243 : string = "50vw"
    let v244 : US6 = US6_1(v243)
    let v245 : string = "auto"
    let v246 : US6 = US6_1(v245)
    let v247 : string = "absolute"
    let v248 : US6 = US6_1(v247)
    let v249 : US6 = US6_1(v234)
    let v250 : int32 = 2
    let v251 : US5 = US5_1(v250)
    let v252 : ((string * obj) []) = method7(v152, v153, v154, v155, v233, v157, v158, v159, v160, v235, v162, v236, v164, v165, v166, v167, v168, v169, v238, v171, v172, v173, v240, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v242, v244, v192, v193, v194, v195, v196, v197, v246, v199, v200, v201, v202, v203, v204, v205, v206, v248, v249, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v251, v221)
    let v253 : obj = createObj v252
    let v254 : (unit -> (JSX.Element [])) = closure3(v146, v145)
    emitJsExpr (v253, v254) "$0.children = $1"
    let v255 : (obj -> JSX.Element) = v151 |> unbox<(obj -> JSX.Element)>
    let v256 : string = "createComponent"
    let v257 : JS.Function = import v256 v125
    let v258 : JSX.Element = v257.Invoke (v255, v253) |> unbox<JSX.Element>
    v258
and closure2 () (v0 : Mut2) : JSX.Element =
    method4()
and closure117 () () : (JSX.Element []) =
    [||]
and closure122 () () : (JSX.Element []) =
    [||]
and closure125 (v0 : Mut1) () : (JSX.Element []) =
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
and closure126 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    let v71 : string = "-13px"
    let v72 : US6 = US6_1(v71)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v70, v36, v72, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure127 () () : JS.Function =
    let v0 : string = "BiRegularLinkExternal"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure124 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : string = "Anchor"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US6, v5 : US6, v6 : US6, v7 : US7, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US8, v15 : US9, v16 : US6, v17 : US6, v18 : US8, v19 : US10, v20 : US6, v21 : US6, v22 : US6, v23 : US11, v24 : US8, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US13, v47 : US14, v48 : US13, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US12, v67 : US6, v68 : US6, v69 : US10, v70 : US10, v71 : US6, v72 : US5, v73 : US6) = method3()
    let struct (v74 : US6, v75 : US6, v76 : US6, v77 : US7, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US6, v83 : US6, v84 : US8, v85 : US9, v86 : US6, v87 : US6, v88 : US8, v89 : US10, v90 : US6, v91 : US6, v92 : US6, v93 : US11, v94 : US8, v95 : US6, v96 : US6, v97 : US6, v98 : US6, v99 : US6, v100 : US6, v101 : US12, v102 : US6, v103 : US6, v104 : US6, v105 : US12, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US6, v115 : US6, v116 : US13, v117 : US14, v118 : US13, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US6, v135 : US6, v136 : US12, v137 : US6, v138 : US6, v139 : US10, v140 : US10, v141 : US6, v142 : US5, v143 : US6) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61, v0.l62, v0.l63, v0.l64, v0.l65, v0.l66, v0.l67, v0.l68, v0.l69
    let v144 : Mut1 = {l0 = v74; l1 = v75; l2 = v76; l3 = v77; l4 = v78; l5 = v79; l6 = v80; l7 = v81; l8 = v82; l9 = v83; l10 = v84; l11 = v85; l12 = v86; l13 = v87; l14 = v88; l15 = v89; l16 = v90; l17 = v91; l18 = v92; l19 = v93; l20 = v94; l21 = v95; l22 = v96; l23 = v97; l24 = v98; l25 = v99; l26 = v100; l27 = v101; l28 = v102; l29 = v103; l30 = v104; l31 = v105; l32 = v106; l33 = v107; l34 = v108; l35 = v109; l36 = v110; l37 = v111; l38 = v112; l39 = v113; l40 = v114; l41 = v115; l42 = v116; l43 = v117; l44 = v118; l45 = v119; l46 = v120; l47 = v121; l48 = v122; l49 = v123; l50 = v124; l51 = v125; l52 = v126; l53 = v127; l54 = v128; l55 = v129; l56 = v130; l57 = v131; l58 = v132; l59 = v133; l60 = v134; l61 = v135; l62 = v136; l63 = v137; l64 = v138; l65 = v139; l66 = v140; l67 = v141; l68 = v142; l69 = v143} : Mut1
    let v145 : US8 = US8_1(true)
    let v146 : Mut1 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v145; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65; l62 = v66; l63 = v67; l64 = v68; l65 = v69; l66 = v70; l67 = v71; l68 = v72; l69 = v73} : Mut1
    method20(v146, v144)
    let struct (v147 : US6, v148 : US6, v149 : US6, v150 : US7, v151 : US6, v152 : US6, v153 : US6, v154 : US6, v155 : US6, v156 : US6, v157 : US8, v158 : US9, v159 : US6, v160 : US6, v161 : US8, v162 : US10, v163 : US6, v164 : US6, v165 : US6, v166 : US11, v167 : US8, v168 : US6, v169 : US6, v170 : US6, v171 : US6, v172 : US6, v173 : US6, v174 : US12, v175 : US6, v176 : US6, v177 : US6, v178 : US12, v179 : US6, v180 : US6, v181 : US6, v182 : US6, v183 : US6, v184 : US6, v185 : US6, v186 : US6, v187 : US6, v188 : US6, v189 : US13, v190 : US14, v191 : US13, v192 : US6, v193 : US6, v194 : US6, v195 : US6, v196 : US6, v197 : US6, v198 : US6, v199 : US6, v200 : US6, v201 : US6, v202 : US6, v203 : US6, v204 : US6, v205 : US6, v206 : US6, v207 : US6, v208 : US6, v209 : US12, v210 : US6, v211 : US6, v212 : US10, v213 : US10, v214 : US6, v215 : US5, v216 : US6) = v146.l0, v146.l1, v146.l2, v146.l3, v146.l4, v146.l5, v146.l6, v146.l7, v146.l8, v146.l9, v146.l10, v146.l11, v146.l12, v146.l13, v146.l14, v146.l15, v146.l16, v146.l17, v146.l18, v146.l19, v146.l20, v146.l21, v146.l22, v146.l23, v146.l24, v146.l25, v146.l26, v146.l27, v146.l28, v146.l29, v146.l30, v146.l31, v146.l32, v146.l33, v146.l34, v146.l35, v146.l36, v146.l37, v146.l38, v146.l39, v146.l40, v146.l41, v146.l42, v146.l43, v146.l44, v146.l45, v146.l46, v146.l47, v146.l48, v146.l49, v146.l50, v146.l51, v146.l52, v146.l53, v146.l54, v146.l55, v146.l56, v146.l57, v146.l58, v146.l59, v146.l60, v146.l61, v146.l62, v146.l63, v146.l64, v146.l65, v146.l66, v146.l67, v146.l68, v146.l69
    let v224 : US9 =
        match v158 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v218) -> (* Some *)
            let v219 : string = "children"
            let v220 : string = "solid-js"
            let v221 : JS.Function = import v219 v220
            let v222 : (unit -> (JSX.Element [])) = v221.Invoke v218 |> unbox<unit -> JSX.Element[]>
            US9_1(v222)
    let v227 : (unit -> (JSX.Element [])) =
        match v224 with
        | US9_0 -> (* None *)
            closure125(v0)
        | US9_1(v226) -> (* Some *)
            v226
    let v228 : US9 = US9_1(v227)
    let v229 : ((string * obj) []) = method7(v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v228, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216)
    let v230 : obj = createObj v229
    let v231 : (unit -> (JSX.Element [])) = closure125(v0)
    emitJsExpr (v230, v231) "$0.children = $1"
    let v232 : (obj -> JSX.Element) = v3 |> unbox<(obj -> JSX.Element)>
    let v233 : string = "createComponent"
    let v234 : string = "solid-js"
    let v235 : JS.Function = import v233 v234
    let v236 : JSX.Element = v235.Invoke (v232, v230) |> unbox<JSX.Element>
    let v237 : string = "&nbsp;"
    let v238 : JSX.Element = v237 |> unbox<JSX.Element>
    let v239 : JSX.Element = Html.fragment [ v238 ]
    let v240 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure126()
    let v241 : (unit -> JS.Function) = closure127()
    let v242 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure45()
    let v243 : Mut7 = {l0 = v240; l1 = v241; l2 = v242} : Mut7
    let v244 : JS.Function = import v233 v234
    let v245 : (Mut7 -> JSX.Element) = closure47()
    let v246 : JSX.Element = v244.Invoke (v245, v243) |> unbox<JSX.Element>
    [|v236; v239; v246|]
and method32 (v0 : Mut1) : JSX.Element =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US6, v5 : US6, v6 : US6, v7 : US7, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US8, v15 : US9, v16 : US6, v17 : US6, v18 : US8, v19 : US10, v20 : US6, v21 : US6, v22 : US6, v23 : US11, v24 : US8, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US13, v47 : US14, v48 : US13, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US12, v67 : US6, v68 : US6, v69 : US10, v70 : US10, v71 : US6, v72 : US5, v73 : US6) = method3()
    let v81 : US9 =
        match v15 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v75) -> (* Some *)
            let v76 : string = "children"
            let v77 : string = "solid-js"
            let v78 : JS.Function = import v76 v77
            let v79 : (unit -> (JSX.Element [])) = v78.Invoke v75 |> unbox<unit -> JSX.Element[]>
            US9_1(v79)
    let v84 : (unit -> (JSX.Element [])) =
        match v81 with
        | US9_0 -> (* None *)
            closure124(v0)
        | US9_1(v83) -> (* Some *)
            v83
    let v85 : US9 = US9_1(v84)
    let v86 : ((string * obj) []) = method7(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v85, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73)
    let v87 : obj = createObj v86
    let v88 : (unit -> (JSX.Element [])) = closure124(v0)
    emitJsExpr (v87, v88) "$0.children = $1"
    let v89 : (obj -> JSX.Element) = v3 |> unbox<(obj -> JSX.Element)>
    let v90 : string = "createComponent"
    let v91 : string = "solid-js"
    let v92 : JS.Function = import v90 v91
    let v93 : JSX.Element = v92.Invoke (v89, v87) |> unbox<JSX.Element>
    v93
and closure123 () (v0 : Mut1) : JSX.Element =
    method32(v0)
and closure121 () () : (JSX.Element []) =
    let struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) = method3()
    let v77 : US9 =
        match v11 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v71) -> (* Some *)
            let v72 : string = "children"
            let v73 : string = "solid-js"
            let v74 : JS.Function = import v72 v73
            let v75 : (unit -> (JSX.Element [])) = v74.Invoke v71 |> unbox<unit -> JSX.Element[]>
            US9_1(v75)
    let v80 : (unit -> (JSX.Element [])) =
        match v77 with
        | US9_0 -> (* None *)
            closure122()
        | US9_1(v79) -> (* Some *)
            v79
    let v81 : US9 = US9_1(v80)
    let v82 : string = "https://github.com/fc1943s/tictactoe_spiral"
    let v83 : US6 = US6_1(v82)
    let v84 : Mut1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v81; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v83; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67; l68 = v68; l69 = v69} : Mut1
    let v85 : (unit -> (JSX.Element [])) = closure122()
    emitJsExpr (v84, v85) "$0.children = $1"
    let v86 : string = "createComponent"
    let v87 : string = "solid-js"
    let v88 : JS.Function = import v86 v87
    let v89 : (Mut1 -> JSX.Element) = closure123()
    let v90 : JSX.Element = v88.Invoke (v89, v84) |> unbox<JSX.Element>
    [|v90|]
and closure120 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : (unit -> (JSX.Element [])) = closure121()
    let v71 : US9 = US9_1(v70)
    let v72 : string = "1px 6px"
    let v73 : US6 = US6_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v73, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure129 (v0 : string) () : (JSX.Element []) =
    let struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) = method3()
    let v78 : US9 =
        match v12 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v72) -> (* Some *)
            let v73 : string = "children"
            let v74 : string = "solid-js"
            let v75 : JS.Function = import v73 v74
            let v76 : (unit -> (JSX.Element [])) = v75.Invoke v72 |> unbox<unit -> JSX.Element[]>
            US9_1(v76)
    let v81 : (unit -> (JSX.Element [])) =
        match v78 with
        | US9_0 -> (* None *)
            closure122()
        | US9_1(v80) -> (* Some *)
            v80
    let v82 : US9 = US9_1(v81)
    let v83 : US6 = US6_1(v0)
    let v84 : Mut1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v82; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v83; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63; l63 = v64; l64 = v65; l65 = v66; l66 = v67; l67 = v68; l68 = v69; l69 = v70} : Mut1
    let v85 : (unit -> (JSX.Element [])) = closure122()
    emitJsExpr (v84, v85) "$0.children = $1"
    let v86 : string = "createComponent"
    let v87 : string = "solid-js"
    let v88 : JS.Function = import v86 v87
    let v89 : (Mut1 -> JSX.Element) = closure123()
    let v90 : JSX.Element = v88.Invoke (v89, v84) |> unbox<JSX.Element>
    [|v90|]
and closure128 (v0 : string) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : (unit -> (JSX.Element [])) = closure129(v0)
    let v72 : US9 = US9_1(v71)
    let v73 : string = "1px 6px"
    let v74 : US6 = US6_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v72, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v74, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
and closure131 () () : (JSX.Element []) =
    let struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) = method3()
    let v77 : US9 =
        match v11 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v71) -> (* Some *)
            let v72 : string = "children"
            let v73 : string = "solid-js"
            let v74 : JS.Function = import v72 v73
            let v75 : (unit -> (JSX.Element [])) = v74.Invoke v71 |> unbox<unit -> JSX.Element[]>
            US9_1(v75)
    let v80 : (unit -> (JSX.Element [])) =
        match v77 with
        | US9_0 -> (* None *)
            closure122()
        | US9_1(v79) -> (* Some *)
            v79
    let v81 : US9 = US9_1(v80)
    let v82 : string = "https://fc1943s.github.io/tictactoe_spiral"
    let v83 : US6 = US6_1(v82)
    let v84 : Mut1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v81; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v83; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67; l68 = v68; l69 = v69} : Mut1
    let v85 : (unit -> (JSX.Element [])) = closure122()
    emitJsExpr (v84, v85) "$0.children = $1"
    let v86 : string = "createComponent"
    let v87 : string = "solid-js"
    let v88 : JS.Function = import v86 v87
    let v89 : (Mut1 -> JSX.Element) = closure123()
    let v90 : JSX.Element = v88.Invoke (v89, v84) |> unbox<JSX.Element>
    [|v90|]
and closure130 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : (unit -> (JSX.Element [])) = closure131()
    let v71 : US9 = US9_1(v70)
    let v72 : string = "1px 6px"
    let v73 : US6 = US6_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v73, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure133 () () : (JSX.Element []) =
    let struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) = method3()
    let v77 : US9 =
        match v11 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v71) -> (* Some *)
            let v72 : string = "children"
            let v73 : string = "solid-js"
            let v74 : JS.Function = import v72 v73
            let v75 : (unit -> (JSX.Element [])) = v74.Invoke v71 |> unbox<unit -> JSX.Element[]>
            US9_1(v75)
    let v80 : (unit -> (JSX.Element [])) =
        match v77 with
        | US9_0 -> (* None *)
            closure122()
        | US9_1(v79) -> (* Some *)
            v79
    let v81 : US9 = US9_1(v80)
    let v82 : string = "https://fc1943s.github.io/tictactoe_spiral/docs"
    let v83 : US6 = US6_1(v82)
    let v84 : Mut1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v81; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v83; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67; l68 = v68; l69 = v69} : Mut1
    let v85 : (unit -> (JSX.Element [])) = closure122()
    emitJsExpr (v84, v85) "$0.children = $1"
    let v86 : string = "createComponent"
    let v87 : string = "solid-js"
    let v88 : JS.Function = import v86 v87
    let v89 : (Mut1 -> JSX.Element) = closure123()
    let v90 : JSX.Element = v88.Invoke (v89, v84) |> unbox<JSX.Element>
    [|v90|]
and closure132 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : (unit -> (JSX.Element [])) = closure133()
    let v71 : US9 = US9_1(v70)
    let v72 : string = "1px 6px"
    let v73 : US6 = US6_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v73, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure119 (v0 : string) () : (JSX.Element []) =
    let v1 : bool = "" = v0
    let v23 : JSX.Element =
        if v1 then
            let v2 : US14 = US14_0
            let v3 : US14 = US14_0
            let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure120()
            let v5 : US15 = US15_2
            let v6 : Mut4 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5} : Mut4
            let v7 : string = "createComponent"
            let v8 : string = "solid-js"
            let v9 : JS.Function = import v7 v8
            let v10 : (Mut4 -> JSX.Element) = closure16()
            let v11 : JSX.Element = v9.Invoke (v10, v6) |> unbox<JSX.Element>
            v11
        else
            let v12 : string = $"https://github.com/fc1943s/tictactoe_spiral/tree/{v0}"
            let v13 : US14 = US14_0
            let v14 : US14 = US14_0
            let v15 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure128(v12)
            let v16 : US15 = US15_2
            let v17 : Mut4 = {l0 = v13; l1 = v14; l2 = v15; l3 = v16} : Mut4
            let v18 : string = "createComponent"
            let v19 : string = "solid-js"
            let v20 : JS.Function = import v18 v19
            let v21 : (Mut4 -> JSX.Element) = closure16()
            let v22 : JSX.Element = v20.Invoke (v21, v17) |> unbox<JSX.Element>
            v22
    let v24 : US14 = US14_0
    let v25 : US14 = US14_0
    let v26 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure130()
    let v27 : US15 = US15_2
    let v28 : Mut4 = {l0 = v24; l1 = v25; l2 = v26; l3 = v27} : Mut4
    let v29 : string = "createComponent"
    let v30 : string = "solid-js"
    let v31 : JS.Function = import v29 v30
    let v32 : (Mut4 -> JSX.Element) = closure16()
    let v33 : JSX.Element = v31.Invoke (v32, v28) |> unbox<JSX.Element>
    let v34 : US14 = US14_0
    let v35 : US14 = US14_0
    let v36 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure132()
    let v37 : US15 = US15_2
    let v38 : Mut4 = {l0 = v34; l1 = v35; l2 = v36; l3 = v37} : Mut4
    let v39 : JS.Function = import v29 v30
    let v40 : JSX.Element = v39.Invoke (v32, v38) |> unbox<JSX.Element>
    [|v23; v33; v40|]
and method31 () : JSX.Element =
    let struct (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) = method2()
    let struct (v5 : US6, v6 : US6, v7 : US6, v8 : US7, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US8, v16 : US9, v17 : US6, v18 : US6, v19 : US8, v20 : US10, v21 : US6, v22 : US6, v23 : US6, v24 : US11, v25 : US8, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US12, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US13, v48 : US14, v49 : US13, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US12, v68 : US6, v69 : US6, v70 : US10, v71 : US10, v72 : US6, v73 : US5, v74 : US6) = method3()
    let v82 : US9 =
        match v16 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v76) -> (* Some *)
            let v77 : string = "children"
            let v78 : string = "solid-js"
            let v79 : JS.Function = import v77 v78
            let v80 : (unit -> (JSX.Element [])) = v79.Invoke v76 |> unbox<unit -> JSX.Element[]>
            US9_1(v80)
    let v85 : (unit -> (JSX.Element [])) =
        match v82 with
        | US9_0 -> (* None *)
            closure119(v3)
        | US9_1(v84) -> (* Some *)
            v84
    let v86 : US9 = US9_1(v85)
    let v87 : Mut1 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v15; l11 = v86; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v61; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66; l62 = v67; l63 = v68; l64 = v69; l65 = v70; l66 = v71; l67 = v72; l68 = v73; l69 = v74} : Mut1
    let v88 : (unit -> (JSX.Element [])) = closure119(v3)
    emitJsExpr (v87, v88) "$0.children = $1"
    let v89 : string = "createComponent"
    let v90 : string = "solid-js"
    let v91 : JS.Function = import v89 v90
    let v92 : (Mut1 -> JSX.Element) = closure111()
    let v93 : JSX.Element = v91.Invoke (v92, v87) |> unbox<JSX.Element>
    v93
and closure118 () (v0 : Mut1) : JSX.Element =
    method31()
and closure116 () () : (JSX.Element []) =
    let struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) = method3()
    let v77 : US9 =
        match v11 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v71) -> (* Some *)
            let v72 : string = "children"
            let v73 : string = "solid-js"
            let v74 : JS.Function = import v72 v73
            let v75 : (unit -> (JSX.Element [])) = v74.Invoke v71 |> unbox<unit -> JSX.Element[]>
            US9_1(v75)
    let v80 : (unit -> (JSX.Element [])) =
        match v77 with
        | US9_0 -> (* None *)
            closure117()
        | US9_1(v79) -> (* Some *)
            v79
    let v81 : US9 = US9_1(v80)
    let v82 : Mut1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v81; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67; l68 = v68; l69 = v69} : Mut1
    let v83 : (unit -> (JSX.Element [])) = closure117()
    emitJsExpr (v82, v83) "$0.children = $1"
    let v84 : string = "createComponent"
    let v85 : string = "solid-js"
    let v86 : JS.Function = import v84 v85
    let v87 : (Mut1 -> JSX.Element) = closure118()
    let v88 : JSX.Element = v86.Invoke (v87, v82) |> unbox<JSX.Element>
    [|v88|]
and closure115 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Links"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure116()
    let v74 : US9 = US9_1(v73)
    let v75 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure136 () () : (JSX.Element []) =
    [||]
and method34 () : struct ((unit -> string) * (unit -> unit)) =
    let v0 : string = "useColorMode"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : obj = v2.Invoke () |> unbox
    let v4 : (unit -> string) = v3?colorMode |> unbox
    let v5 : (unit -> unit) = v3?toggleColorMode |> unbox
    struct (v4, v5)
and closure143 () () : (JSX.Element []) =
    let v0 : string = "Dark"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure144 () () : (JSX.Element []) =
    let v0 : string = "Light"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure142 () () : (JSX.Element []) =
    let v0 : string = "Radio"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US10, v19 : US6, v20 : US6, v21 : US6, v22 : US11, v23 : US8, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US12, v31 : US6, v32 : US6, v33 : US6, v34 : US12, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US13, v46 : US14, v47 : US13, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US12, v66 : US6, v67 : US6, v68 : US10, v69 : US10, v70 : US6, v71 : US5, v72 : US6) = method3()
    let v73 : string = "dark"
    let v74 : obj = v73
    let v82 : US9 =
        match v14 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v76) -> (* Some *)
            let v77 : string = "children"
            let v78 : string = "solid-js"
            let v79 : JS.Function = import v77 v78
            let v80 : (unit -> (JSX.Element [])) = v79.Invoke v76 |> unbox<unit -> JSX.Element[]>
            US9_1(v80)
    let v85 : (unit -> (JSX.Element [])) =
        match v82 with
        | US9_0 -> (* None *)
            closure143()
        | US9_1(v84) -> (* Some *)
            v84
    let v86 : US9 = US9_1(v85)
    let v87 : string = "neutral"
    let v88 : US6 = US6_1(v87)
    let v89 : string = "sm"
    let v90 : US6 = US6_1(v89)
    let v91 : US10 = US10_1(v74)
    let v92 : ((string * obj) []) = method7(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v86, v15, v88, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v90, v61, v62, v63, v64, v65, v66, v67, v91, v69, v70, v71, v72)
    let v93 : obj = createObj v92
    let v94 : (unit -> (JSX.Element [])) = closure143()
    emitJsExpr (v93, v94) "$0.children = $1"
    let v95 : (obj -> JSX.Element) = v2 |> unbox<(obj -> JSX.Element)>
    let v96 : string = "createComponent"
    let v97 : string = "solid-js"
    let v98 : JS.Function = import v96 v97
    let v99 : JSX.Element = v98.Invoke (v95, v93) |> unbox<JSX.Element>
    let v100 : JS.Function = import v0 v1
    let struct (v101 : US6, v102 : US6, v103 : US6, v104 : US7, v105 : US6, v106 : US6, v107 : US6, v108 : US6, v109 : US6, v110 : US6, v111 : US8, v112 : US9, v113 : US6, v114 : US6, v115 : US8, v116 : US10, v117 : US6, v118 : US6, v119 : US6, v120 : US11, v121 : US8, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US12, v129 : US6, v130 : US6, v131 : US6, v132 : US12, v133 : US6, v134 : US6, v135 : US6, v136 : US6, v137 : US6, v138 : US6, v139 : US6, v140 : US6, v141 : US6, v142 : US6, v143 : US13, v144 : US14, v145 : US13, v146 : US6, v147 : US6, v148 : US6, v149 : US6, v150 : US6, v151 : US6, v152 : US6, v153 : US6, v154 : US6, v155 : US6, v156 : US6, v157 : US6, v158 : US6, v159 : US6, v160 : US6, v161 : US6, v162 : US6, v163 : US12, v164 : US6, v165 : US6, v166 : US10, v167 : US10, v168 : US6, v169 : US5, v170 : US6) = method3()
    let v171 : string = "light"
    let v172 : obj = v171
    let v179 : US9 =
        match v112 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v174) -> (* Some *)
            let v175 : string = "children"
            let v176 : JS.Function = import v175 v97
            let v177 : (unit -> (JSX.Element [])) = v176.Invoke v174 |> unbox<unit -> JSX.Element[]>
            US9_1(v177)
    let v182 : (unit -> (JSX.Element [])) =
        match v179 with
        | US9_0 -> (* None *)
            closure144()
        | US9_1(v181) -> (* Some *)
            v181
    let v183 : US9 = US9_1(v182)
    let v184 : US6 = US6_1(v87)
    let v185 : US6 = US6_1(v89)
    let v186 : US10 = US10_1(v172)
    let v187 : ((string * obj) []) = method7(v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v183, v113, v184, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v185, v159, v160, v161, v162, v163, v164, v165, v186, v167, v168, v169, v170)
    let v188 : obj = createObj v187
    let v189 : (unit -> (JSX.Element [])) = closure144()
    emitJsExpr (v188, v189) "$0.children = $1"
    let v190 : (obj -> JSX.Element) = v100 |> unbox<(obj -> JSX.Element)>
    let v191 : JS.Function = import v96 v97
    let v192 : JSX.Element = v191.Invoke (v190, v188) |> unbox<JSX.Element>
    [|v99; v192|]
and closure141 () () : (JSX.Element []) =
    let v0 : string = "Stack"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US10, v19 : US6, v20 : US6, v21 : US6, v22 : US11, v23 : US8, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US12, v31 : US6, v32 : US6, v33 : US6, v34 : US12, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US13, v46 : US14, v47 : US13, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US12, v66 : US6, v67 : US6, v68 : US10, v69 : US10, v70 : US6, v71 : US5, v72 : US6) = method3()
    let v80 : US9 =
        match v14 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v74) -> (* Some *)
            let v75 : string = "children"
            let v76 : string = "solid-js"
            let v77 : JS.Function = import v75 v76
            let v78 : (unit -> (JSX.Element [])) = v77.Invoke v74 |> unbox<unit -> JSX.Element[]>
            US9_1(v78)
    let v83 : (unit -> (JSX.Element [])) =
        match v80 with
        | US9_0 -> (* None *)
            closure142()
        | US9_1(v82) -> (* Some *)
            v82
    let v84 : US9 = US9_1(v83)
    let v85 : string = "row"
    let v86 : US6 = US6_1(v85)
    let v87 : string = "$4"
    let v88 : US6 = US6_1(v87)
    let v89 : ((string * obj) []) = method7(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v84, v15, v16, v17, v18, v19, v86, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v88, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v90 : obj = createObj v89
    let v91 : (unit -> (JSX.Element [])) = closure142()
    emitJsExpr (v90, v91) "$0.children = $1"
    let v92 : (obj -> JSX.Element) = v2 |> unbox<(obj -> JSX.Element)>
    let v93 : string = "createComponent"
    let v94 : string = "solid-js"
    let v95 : JS.Function = import v93 v94
    let v96 : JSX.Element = v95.Invoke (v92, v90) |> unbox<JSX.Element>
    [|v96|]
and closure145 (v0 : (unit -> unit)) (v1 : obj) : unit =
    v0 ()
    ()
and closure140 (v0 : (unit -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : string = "RadioGroup"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let struct (v5 : US6, v6 : US6, v7 : US6, v8 : US7, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US8, v16 : US9, v17 : US6, v18 : US6, v19 : US8, v20 : US10, v21 : US6, v22 : US6, v23 : US6, v24 : US11, v25 : US8, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US12, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US13, v48 : US14, v49 : US13, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US12, v68 : US6, v69 : US6, v70 : US10, v71 : US10, v72 : US6, v73 : US5, v74 : US6) = method3()
    let v75 : string = v1 ()
    let v83 : US9 =
        match v16 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v77) -> (* Some *)
            let v78 : string = "children"
            let v79 : string = "solid-js"
            let v80 : JS.Function = import v78 v79
            let v81 : (unit -> (JSX.Element [])) = v80.Invoke v77 |> unbox<unit -> JSX.Element[]>
            US9_1(v81)
    let v86 : (unit -> (JSX.Element [])) =
        match v83 with
        | US9_0 -> (* None *)
            closure141()
        | US9_1(v85) -> (* Some *)
            v85
    let v87 : US9 = US9_1(v86)
    let v88 : US6 = US6_1(v75)
    let v89 : (obj -> unit) = closure145(v0)
    let v90 : US13 = US13_1(v89)
    let v91 : ((string * obj) []) = method7(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v87, v17, v18, v19, v20, v88, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v90, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74)
    let v92 : obj = createObj v91
    let v93 : (unit -> (JSX.Element [])) = closure141()
    emitJsExpr (v92, v93) "$0.children = $1"
    let v94 : (obj -> JSX.Element) = v4 |> unbox<(obj -> JSX.Element)>
    let v95 : string = "createComponent"
    let v96 : string = "solid-js"
    let v97 : JS.Function = import v95 v96
    let v98 : JSX.Element = v97.Invoke (v94, v92) |> unbox<JSX.Element>
    [|v98|]
and closure139 (v0 : (unit -> unit), v1 : (unit -> string)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = "Theme"
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure140(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "5px 6px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v78, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and closure138 (v0 : (unit -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : US14 = US14_0
    let v3 : US14 = US14_0
    let v4 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure139(v0, v1)
    let v5 : US15 = US15_2
    let v6 : Mut4 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5} : Mut4
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : (Mut4 -> JSX.Element) = closure16()
    let v11 : JSX.Element = v9.Invoke (v10, v6) |> unbox<JSX.Element>
    [|v11|]
and method33 () : JSX.Element =
    let struct (v0 : (unit -> string), v1 : (unit -> unit)) = method34()
    let struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) = method3()
    let v79 : US9 =
        match v13 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v73) -> (* Some *)
            let v74 : string = "children"
            let v75 : string = "solid-js"
            let v76 : JS.Function = import v74 v75
            let v77 : (unit -> (JSX.Element [])) = v76.Invoke v73 |> unbox<unit -> JSX.Element[]>
            US9_1(v77)
    let v82 : (unit -> (JSX.Element [])) =
        match v79 with
        | US9_0 -> (* None *)
            closure138(v1, v0)
        | US9_1(v81) -> (* Some *)
            v81
    let v83 : US9 = US9_1(v82)
    let v84 : Mut1 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v83; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64; l63 = v65; l64 = v66; l65 = v67; l66 = v68; l67 = v69; l68 = v70; l69 = v71} : Mut1
    let v85 : (unit -> (JSX.Element [])) = closure138(v1, v0)
    emitJsExpr (v84, v85) "$0.children = $1"
    let v86 : string = "createComponent"
    let v87 : string = "solid-js"
    let v88 : JS.Function = import v86 v87
    let v89 : (Mut1 -> JSX.Element) = closure111()
    let v90 : JSX.Element = v88.Invoke (v89, v84) |> unbox<JSX.Element>
    v90
and closure137 () (v0 : Mut1) : JSX.Element =
    method33()
and closure135 () () : (JSX.Element []) =
    let struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) = method3()
    let v77 : US9 =
        match v11 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v71) -> (* Some *)
            let v72 : string = "children"
            let v73 : string = "solid-js"
            let v74 : JS.Function = import v72 v73
            let v75 : (unit -> (JSX.Element [])) = v74.Invoke v71 |> unbox<unit -> JSX.Element[]>
            US9_1(v75)
    let v80 : (unit -> (JSX.Element [])) =
        match v77 with
        | US9_0 -> (* None *)
            closure136()
        | US9_1(v79) -> (* Some *)
            v79
    let v81 : US9 = US9_1(v80)
    let v82 : Mut1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v81; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67; l68 = v68; l69 = v69} : Mut1
    let v83 : (unit -> (JSX.Element [])) = closure136()
    emitJsExpr (v82, v83) "$0.children = $1"
    let v84 : string = "createComponent"
    let v85 : string = "solid-js"
    let v86 : JS.Function = import v84 v85
    let v87 : (Mut1 -> JSX.Element) = closure137()
    let v88 : JSX.Element = v86.Invoke (v87, v82) |> unbox<JSX.Element>
    [|v88|]
and closure134 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Settings"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure135()
    let v74 : US9 = US9_1(v73)
    let v75 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure148 () () : (JSX.Element []) =
    [||]
and closure153 () () : (JSX.Element []) =
    [||]
and closure158 (v0 : (unit -> string)) () : US6 =
    let v1 : string = v0 ()
    US6_1(v1)
and closure159 (v0 : (string -> unit)) (v1 : US6) : unit =
    let v4 : string =
        match v1 with
        | US6_0 -> (* None *)
            failwith<string> "Option does not have a value."
        | US6_1(v3) -> (* Some *)
            v3
    v0 v4
    ()
and closure161 () () : (JSX.Element []) =
    [||]
and closure162 (v0 : Mut16) (v1 : obj) : unit =
    let v2 : string = v1?currentTarget?value
    let v3 : (US6 -> unit) = v0.l1
    let v4 : US6 = US6_1(v2)
    v3 v4
    ()
and method37 (v0 : Mut16) : JSX.Element =
    let v1 : string = "Input"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US6, v5 : US6, v6 : US6, v7 : US7, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US8, v15 : US9, v16 : US6, v17 : US6, v18 : US8, v19 : US10, v20 : US6, v21 : US6, v22 : US6, v23 : US11, v24 : US8, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US13, v47 : US14, v48 : US13, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US12, v67 : US6, v68 : US6, v69 : US10, v70 : US10, v71 : US6, v72 : US5, v73 : US6) = method3()
    let v74 : (unit -> US6) = v0.l0
    let v75 : US6 = v74 ()
    let v76 : string = JS.undefined
    let v78 : string =
        match v75 with
        | US6_0 -> (* None *)
            v76
        | US6_1(v77) -> (* Some *)
            v77
    let v79 : obj = v78
    let v87 : US9 =
        match v15 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v81) -> (* Some *)
            let v82 : string = "children"
            let v83 : string = "solid-js"
            let v84 : JS.Function = import v82 v83
            let v85 : (unit -> (JSX.Element [])) = v84.Invoke v81 |> unbox<unit -> JSX.Element[]>
            US9_1(v85)
    let v90 : (unit -> (JSX.Element [])) =
        match v87 with
        | US9_0 -> (* None *)
            closure161()
        | US9_1(v89) -> (* Some *)
            v89
    let v91 : US9 = US9_1(v90)
    let v92 : string = "15vw"
    let v93 : US6 = US6_1(v92)
    let v94 : (obj -> unit) = closure162(v0)
    let v95 : US13 = US13_1(v94)
    let v96 : string = "xs"
    let v97 : US6 = US6_1(v96)
    let v98 : string = "text"
    let v99 : US6 = US6_1(v98)
    let v100 : US10 = US10_1(v79)
    let v101 : ((string * obj) []) = method7(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v91, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v93, v46, v47, v95, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v97, v62, v63, v64, v65, v66, v67, v99, v100, v70, v71, v72, v73)
    let v102 : obj = createObj v101
    let v103 : (unit -> (JSX.Element [])) = closure161()
    emitJsExpr (v102, v103) "$0.children = $1"
    let v104 : (obj -> JSX.Element) = v3 |> unbox<(obj -> JSX.Element)>
    let v105 : string = "createComponent"
    let v106 : string = "solid-js"
    let v107 : JS.Function = import v105 v106
    let v108 : JSX.Element = v107.Invoke (v104, v102) |> unbox<JSX.Element>
    v108
and closure160 () (v0 : Mut16) : JSX.Element =
    method37(v0)
and closure157 (v0 : (string -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : (unit -> US6) = closure158(v1)
    let v3 : (US6 -> unit) = closure159(v0)
    let v4 : Mut16 = {l0 = v2; l1 = v3} : Mut16
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (Mut16 -> JSX.Element) = closure160()
    let v9 : JSX.Element = v7.Invoke (v8, v4) |> unbox<JSX.Element>
    [|v9|]
and closure156 (v0 : (string -> unit), v1 : (unit -> string)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = "Token"
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure157(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "3px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v78, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and closure164 (v0 : (string -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : (unit -> US6) = closure158(v1)
    let v3 : (US6 -> unit) = closure159(v0)
    let v4 : Mut16 = {l0 = v2; l1 = v3} : Mut16
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (Mut16 -> JSX.Element) = closure160()
    let v9 : JSX.Element = v7.Invoke (v8, v4) |> unbox<JSX.Element>
    [|v9|]
and closure163 (v0 : (string -> unit), v1 : (unit -> string)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = "URL"
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure164(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "3px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v78, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and closure167 (v0 : (unit -> int32)) () : US5 =
    let v1 : int32 = v0 ()
    US5_1(v1)
and closure168 (v0 : (int32 -> unit)) (v1 : US5) : unit =
    let v4 : int32 =
        match v1 with
        | US5_0 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US5_1(v3) -> (* Some *)
            v3
    v0 v4
    ()
and closure170 (v0 : Mut17) (v1 : obj) : unit =
    let v2 : int32 = v1?currentTarget?value
    let v3 : (US5 -> unit) = v0.l1
    let v4 : US5 = US5_1(v2)
    v3 v4
    ()
and method38 (v0 : Mut17) : JSX.Element =
    let v1 : string = "Input"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US6, v5 : US6, v6 : US6, v7 : US7, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US8, v15 : US9, v16 : US6, v17 : US6, v18 : US8, v19 : US10, v20 : US6, v21 : US6, v22 : US6, v23 : US11, v24 : US8, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US13, v47 : US14, v48 : US13, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US12, v67 : US6, v68 : US6, v69 : US10, v70 : US10, v71 : US6, v72 : US5, v73 : US6) = method3()
    let v74 : (unit -> US5) = v0.l0
    let v75 : US5 = v74 ()
    let v76 : int32 = JS.undefined
    let v78 : int32 =
        match v75 with
        | US5_0 -> (* None *)
            v76
        | US5_1(v77) -> (* Some *)
            v77
    let v79 : obj = v78
    let v87 : US9 =
        match v15 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v81) -> (* Some *)
            let v82 : string = "children"
            let v83 : string = "solid-js"
            let v84 : JS.Function = import v82 v83
            let v85 : (unit -> (JSX.Element [])) = v84.Invoke v81 |> unbox<unit -> JSX.Element[]>
            US9_1(v85)
    let v90 : (unit -> (JSX.Element [])) =
        match v87 with
        | US9_0 -> (* None *)
            closure161()
        | US9_1(v89) -> (* Some *)
            v89
    let v91 : US9 = US9_1(v90)
    let v92 : string = "15vw"
    let v93 : US6 = US6_1(v92)
    let v94 : (obj -> unit) = closure170(v0)
    let v95 : US13 = US13_1(v94)
    let v96 : string = "xs"
    let v97 : US6 = US6_1(v96)
    let v98 : string = "text"
    let v99 : US6 = US6_1(v98)
    let v100 : US10 = US10_1(v79)
    let v101 : ((string * obj) []) = method7(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v91, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v93, v46, v47, v95, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v97, v62, v63, v64, v65, v66, v67, v99, v100, v70, v71, v72, v73)
    let v102 : obj = createObj v101
    let v103 : (unit -> (JSX.Element [])) = closure161()
    emitJsExpr (v102, v103) "$0.children = $1"
    let v104 : (obj -> JSX.Element) = v3 |> unbox<(obj -> JSX.Element)>
    let v105 : string = "createComponent"
    let v106 : string = "solid-js"
    let v107 : JS.Function = import v105 v106
    let v108 : JSX.Element = v107.Invoke (v104, v102) |> unbox<JSX.Element>
    v108
and closure169 () (v0 : Mut17) : JSX.Element =
    method38(v0)
and closure166 (v0 : (int32 -> unit), v1 : (unit -> int32)) () : (JSX.Element []) =
    let v2 : (unit -> US5) = closure167(v1)
    let v3 : (US5 -> unit) = closure168(v0)
    let v4 : Mut17 = {l0 = v2; l1 = v3} : Mut17
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (Mut17 -> JSX.Element) = closure169()
    let v9 : JSX.Element = v7.Invoke (v8, v4) |> unbox<JSX.Element>
    [|v9|]
and closure165 (v0 : (int32 -> unit), v1 : (unit -> int32)) struct (v2 : US6, v3 : US6, v4 : US6, v5 : US7, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US8, v13 : US9, v14 : US6, v15 : US6, v16 : US8, v17 : US10, v18 : US6, v19 : US6, v20 : US6, v21 : US11, v22 : US8, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US12, v30 : US6, v31 : US6, v32 : US6, v33 : US12, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US13, v45 : US14, v46 : US13, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US12, v65 : US6, v66 : US6, v67 : US10, v68 : US10, v69 : US6, v70 : US5, v71 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v72 : string = "Port"
    let v73 : JSX.Element = v72 |> unbox<JSX.Element>
    let v74 : JSX.Element = Html.fragment [ v73 ]
    let v75 : (unit -> (JSX.Element [])) = closure166(v0, v1)
    let v76 : US9 = US9_1(v75)
    let v77 : string = "3px"
    let v78 : US6 = US6_1(v77)
    let v79 : US12 = US12_1(v74)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v76, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v78, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v79, v65, v66, v67, v68, v69, v70, v71)
and closure155 (v0 : (string -> unit), v1 : (unit -> string), v2 : (string -> unit), v3 : (unit -> string), v4 : (int32 -> unit), v5 : (unit -> int32)) () : (JSX.Element []) =
    let v6 : US14 = US14_0
    let v7 : US14 = US14_0
    let v8 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure156(v0, v1)
    let v9 : US15 = US15_2
    let v10 : Mut4 = {l0 = v6; l1 = v7; l2 = v8; l3 = v9} : Mut4
    let v11 : string = "createComponent"
    let v12 : string = "solid-js"
    let v13 : JS.Function = import v11 v12
    let v14 : (Mut4 -> JSX.Element) = closure16()
    let v15 : JSX.Element = v13.Invoke (v14, v10) |> unbox<JSX.Element>
    let v16 : US14 = US14_0
    let v17 : US14 = US14_0
    let v18 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure163(v2, v3)
    let v19 : US15 = US15_2
    let v20 : Mut4 = {l0 = v16; l1 = v17; l2 = v18; l3 = v19} : Mut4
    let v21 : JS.Function = import v11 v12
    let v22 : JSX.Element = v21.Invoke (v14, v20) |> unbox<JSX.Element>
    let v23 : US14 = US14_0
    let v24 : US14 = US14_0
    let v25 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure165(v4, v5)
    let v26 : US15 = US15_2
    let v27 : Mut4 = {l0 = v23; l1 = v24; l2 = v25; l3 = v26} : Mut4
    let v28 : JS.Function = import v11 v12
    let v29 : JSX.Element = v28.Invoke (v14, v27) |> unbox<JSX.Element>
    [|v15; v22; v29|]
and method36 () : JSX.Element =
    let v123 : obj = emitJsExpr () "components_spi.state_context"
    let v124 : string = "useContext"
    let v125 : string = "solid-js"
    let v126 : JS.Function = import v124 v125
    let struct (v127 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v128 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v129 : (unit -> int32), v130 : (int32 -> unit), v131 : (unit -> string), v132 : (string -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v136 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v137 : (unit -> (struct (US2 * (int32 [])) [])), v138 : ((struct (US2 * (int32 [])) []) -> unit), v139 : (unit -> (struct (int32 * obj) [])), v140 : ((struct (int32 * obj) []) -> unit), v141 : (unit -> (struct (int32 * obj) [])), v142 : ((struct (int32 * obj) []) -> unit), v143 : (unit -> (struct (int32 * int32) [])), v144 : ((struct (int32 * int32) []) -> unit), v145 : (unit -> US4), v146 : (US4 -> unit), v147 : (unit -> US5), v148 : (US5 -> unit)) = v126.Invoke v123 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v271 : obj = emitJsExpr () "components_spi.state_context"
    let v272 : JS.Function = import v124 v125
    let struct (v273 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v274 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v275 : (unit -> int32), v276 : (int32 -> unit), v277 : (unit -> string), v278 : (string -> unit), v279 : (unit -> string), v280 : (string -> unit), v281 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v282 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v283 : (unit -> (struct (US2 * (int32 [])) [])), v284 : ((struct (US2 * (int32 [])) []) -> unit), v285 : (unit -> (struct (int32 * obj) [])), v286 : ((struct (int32 * obj) []) -> unit), v287 : (unit -> (struct (int32 * obj) [])), v288 : ((struct (int32 * obj) []) -> unit), v289 : (unit -> (struct (int32 * int32) [])), v290 : ((struct (int32 * int32) []) -> unit), v291 : (unit -> US4), v292 : (US4 -> unit), v293 : (unit -> US5), v294 : (US5 -> unit)) = v272.Invoke v271 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v417 : obj = emitJsExpr () "components_spi.state_context"
    let v418 : JS.Function = import v124 v125
    let struct (v419 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v420 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v421 : (unit -> int32), v422 : (int32 -> unit), v423 : (unit -> string), v424 : (string -> unit), v425 : (unit -> string), v426 : (string -> unit), v427 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v428 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v429 : (unit -> (struct (US2 * (int32 [])) [])), v430 : ((struct (US2 * (int32 [])) []) -> unit), v431 : (unit -> (struct (int32 * obj) [])), v432 : ((struct (int32 * obj) []) -> unit), v433 : (unit -> (struct (int32 * obj) [])), v434 : ((struct (int32 * obj) []) -> unit), v435 : (unit -> (struct (int32 * int32) [])), v436 : ((struct (int32 * int32) []) -> unit), v437 : (unit -> US4), v438 : (US4 -> unit), v439 : (unit -> US5), v440 : (US5 -> unit)) = v418.Invoke v417 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let struct (v441 : US6, v442 : US6, v443 : US6, v444 : US7, v445 : US6, v446 : US6, v447 : US6, v448 : US6, v449 : US6, v450 : US6, v451 : US8, v452 : US9, v453 : US6, v454 : US6, v455 : US8, v456 : US10, v457 : US6, v458 : US6, v459 : US6, v460 : US11, v461 : US8, v462 : US6, v463 : US6, v464 : US6, v465 : US6, v466 : US6, v467 : US6, v468 : US12, v469 : US6, v470 : US6, v471 : US6, v472 : US12, v473 : US6, v474 : US6, v475 : US6, v476 : US6, v477 : US6, v478 : US6, v479 : US6, v480 : US6, v481 : US6, v482 : US6, v483 : US13, v484 : US14, v485 : US13, v486 : US6, v487 : US6, v488 : US6, v489 : US6, v490 : US6, v491 : US6, v492 : US6, v493 : US6, v494 : US6, v495 : US6, v496 : US6, v497 : US6, v498 : US6, v499 : US6, v500 : US6, v501 : US6, v502 : US6, v503 : US12, v504 : US6, v505 : US6, v506 : US10, v507 : US10, v508 : US6, v509 : US5, v510 : US6) = method3()
    let v517 : US9 =
        match v452 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v512) -> (* Some *)
            let v513 : string = "children"
            let v514 : JS.Function = import v513 v125
            let v515 : (unit -> (JSX.Element [])) = v514.Invoke v512 |> unbox<unit -> JSX.Element[]>
            US9_1(v515)
    let v520 : (unit -> (JSX.Element [])) =
        match v517 with
        | US9_0 -> (* None *)
            closure155(v132, v131, v280, v279, v422, v421)
        | US9_1(v519) -> (* Some *)
            v519
    let v521 : US9 = US9_1(v520)
    let v522 : Mut1 = {l0 = v441; l1 = v442; l2 = v443; l3 = v444; l4 = v445; l5 = v446; l6 = v447; l7 = v448; l8 = v449; l9 = v450; l10 = v451; l11 = v521; l12 = v453; l13 = v454; l14 = v455; l15 = v456; l16 = v457; l17 = v458; l18 = v459; l19 = v460; l20 = v461; l21 = v462; l22 = v463; l23 = v464; l24 = v465; l25 = v466; l26 = v467; l27 = v468; l28 = v469; l29 = v470; l30 = v471; l31 = v472; l32 = v473; l33 = v474; l34 = v475; l35 = v476; l36 = v477; l37 = v478; l38 = v479; l39 = v480; l40 = v481; l41 = v482; l42 = v483; l43 = v484; l44 = v485; l45 = v486; l46 = v487; l47 = v488; l48 = v489; l49 = v490; l50 = v491; l51 = v492; l52 = v493; l53 = v494; l54 = v495; l55 = v496; l56 = v497; l57 = v498; l58 = v499; l59 = v500; l60 = v501; l61 = v502; l62 = v503; l63 = v504; l64 = v505; l65 = v506; l66 = v507; l67 = v508; l68 = v509; l69 = v510} : Mut1
    let v523 : (unit -> (JSX.Element [])) = closure155(v132, v131, v280, v279, v422, v421)
    emitJsExpr (v522, v523) "$0.children = $1"
    let v524 : string = "createComponent"
    let v525 : JS.Function = import v524 v125
    let v526 : (Mut1 -> JSX.Element) = closure111()
    let v527 : JSX.Element = v525.Invoke (v526, v522) |> unbox<JSX.Element>
    v527
and closure154 () (v0 : Mut1) : JSX.Element =
    method36()
and closure152 () () : (JSX.Element []) =
    let struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) = method3()
    let v77 : US9 =
        match v11 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v71) -> (* Some *)
            let v72 : string = "children"
            let v73 : string = "solid-js"
            let v74 : JS.Function = import v72 v73
            let v75 : (unit -> (JSX.Element [])) = v74.Invoke v71 |> unbox<unit -> JSX.Element[]>
            US9_1(v75)
    let v80 : (unit -> (JSX.Element [])) =
        match v77 with
        | US9_0 -> (* None *)
            closure153()
        | US9_1(v79) -> (* Some *)
            v79
    let v81 : US9 = US9_1(v80)
    let v82 : Mut1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v81; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67; l68 = v68; l69 = v69} : Mut1
    let v83 : (unit -> (JSX.Element [])) = closure153()
    emitJsExpr (v82, v83) "$0.children = $1"
    let v84 : string = "createComponent"
    let v85 : string = "solid-js"
    let v86 : JS.Function = import v84 v85
    let v87 : (Mut1 -> JSX.Element) = closure154()
    let v88 : JSX.Element = v86.Invoke (v87, v82) |> unbox<JSX.Element>
    [|v88|]
and closure151 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Connection"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure152()
    let v74 : US9 = US9_1(v73)
    let v75 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure173 () () : (JSX.Element []) =
    [||]
and closure182 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : US6 =
    let v8 : string = v2 ()
    US6_1(v8)
and closure183 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) (v8 : US6) : unit =
    let v11 : string =
        match v8 with
        | US6_0 -> (* None *)
            let v9 : string = ""
            v9
        | US6_1(v10) -> (* Some *)
            v10
    v3 v11
    ()
and closure181 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : (JSX.Element []) =
    let v8 : (unit -> US6) = closure182(v0, v1, v2, v3, v4, v5, v6, v7)
    let v9 : (US6 -> unit) = closure183(v0, v1, v2, v3, v4, v5, v6, v7)
    let v10 : Mut16 = {l0 = v8; l1 = v9} : Mut16
    let v11 : string = "createComponent"
    let v12 : string = "solid-js"
    let v13 : JS.Function = import v11 v12
    let v14 : (Mut16 -> JSX.Element) = closure160()
    let v15 : JSX.Element = v13.Invoke (v14, v10) |> unbox<JSX.Element>
    [|v15|]
and closure180 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) struct (v8 : US6, v9 : US6, v10 : US6, v11 : US7, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US6, v17 : US6, v18 : US8, v19 : US9, v20 : US6, v21 : US6, v22 : US8, v23 : US10, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US8, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US12, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US13, v51 : US14, v52 : US13, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US6, v69 : US6, v70 : US12, v71 : US6, v72 : US6, v73 : US10, v74 : US10, v75 : US6, v76 : US5, v77 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v78 : string = "Address"
    let v79 : JSX.Element = v78 |> unbox<JSX.Element>
    let v80 : JSX.Element = Html.fragment [ v79 ]
    let v81 : (unit -> (JSX.Element [])) = closure181(v0, v1, v2, v3, v4, v5, v6, v7)
    let v82 : US9 = US9_1(v81)
    let v83 : string = "3px"
    let v84 : US6 = US6_1(v83)
    let v85 : US12 = US12_1(v80)
    struct (v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v82, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v84, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v85, v71, v72, v73, v74, v75, v76, v77)
and closure186 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : US6 =
    let v8 : string = v6 ()
    US6_1(v8)
and closure187 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) (v8 : US6) : unit =
    let v11 : string =
        match v8 with
        | US6_0 -> (* None *)
            let v9 : string = ""
            v9
        | US6_1(v10) -> (* Some *)
            v10
    v7 v11
    ()
and closure185 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : (JSX.Element []) =
    let v8 : (unit -> US6) = closure186(v0, v1, v2, v3, v4, v5, v6, v7)
    let v9 : (US6 -> unit) = closure187(v0, v1, v2, v3, v4, v5, v6, v7)
    let v10 : Mut16 = {l0 = v8; l1 = v9} : Mut16
    let v11 : string = "createComponent"
    let v12 : string = "solid-js"
    let v13 : JS.Function = import v11 v12
    let v14 : (Mut16 -> JSX.Element) = closure160()
    let v15 : JSX.Element = v13.Invoke (v14, v10) |> unbox<JSX.Element>
    [|v15|]
and closure184 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) struct (v8 : US6, v9 : US6, v10 : US6, v11 : US7, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US6, v17 : US6, v18 : US8, v19 : US9, v20 : US6, v21 : US6, v22 : US8, v23 : US10, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US8, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US12, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US13, v51 : US14, v52 : US13, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US6, v69 : US6, v70 : US12, v71 : US6, v72 : US6, v73 : US10, v74 : US10, v75 : US6, v76 : US5, v77 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v78 : string = "Private Key"
    let v79 : JSX.Element = v78 |> unbox<JSX.Element>
    let v80 : JSX.Element = Html.fragment [ v79 ]
    let v81 : (unit -> (JSX.Element [])) = closure185(v0, v1, v2, v3, v4, v5, v6, v7)
    let v82 : US9 = US9_1(v81)
    let v83 : string = "3px"
    let v84 : US6 = US6_1(v83)
    let v85 : US12 = US12_1(v80)
    struct (v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v82, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v84, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v85, v71, v72, v73, v74, v75, v76, v77)
and closure179 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : (JSX.Element []) =
    let v8 : US14 = US14_0
    let v9 : US14 = US14_0
    let v10 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure180(v0, v1, v2, v3, v4, v5, v6, v7)
    let v11 : US15 = US15_2
    let v12 : Mut4 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11} : Mut4
    let v13 : string = "createComponent"
    let v14 : string = "solid-js"
    let v15 : JS.Function = import v13 v14
    let v16 : (Mut4 -> JSX.Element) = closure16()
    let v17 : JSX.Element = v15.Invoke (v16, v12) |> unbox<JSX.Element>
    let v18 : US14 = US14_0
    let v19 : US14 = US14_0
    let v20 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure184(v0, v1, v2, v3, v4, v5, v6, v7)
    let v21 : US15 = US15_2
    let v22 : Mut4 = {l0 = v18; l1 = v19; l2 = v20; l3 = v21} : Mut4
    let v23 : JS.Function = import v13 v14
    let v24 : JSX.Element = v23.Invoke (v16, v22) |> unbox<JSX.Element>
    [|v17; v24|]
and closure178 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) () : (JSX.Element []) =
    let struct (v8 : US6, v9 : US6, v10 : US6, v11 : US7, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US6, v17 : US6, v18 : US8, v19 : US9, v20 : US6, v21 : US6, v22 : US8, v23 : US10, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US8, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US12, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US13, v51 : US14, v52 : US13, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US6, v69 : US6, v70 : US12, v71 : US6, v72 : US6, v73 : US10, v74 : US10, v75 : US6, v76 : US5, v77 : US6) = method3()
    let v85 : US9 =
        match v19 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v79) -> (* Some *)
            let v80 : string = "children"
            let v81 : string = "solid-js"
            let v82 : JS.Function = import v80 v81
            let v83 : (unit -> (JSX.Element [])) = v82.Invoke v79 |> unbox<unit -> JSX.Element[]>
            US9_1(v83)
    let v88 : (unit -> (JSX.Element [])) =
        match v85 with
        | US9_0 -> (* None *)
            closure179(v0, v1, v2, v3, v4, v5, v6, v7)
        | US9_1(v87) -> (* Some *)
            v87
    let v89 : US9 = US9_1(v88)
    let v90 : Mut1 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v18; l11 = v89; l12 = v20; l13 = v21; l14 = v22; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v34; l27 = v35; l28 = v36; l29 = v37; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50; l43 = v51; l44 = v52; l45 = v53; l46 = v54; l47 = v55; l48 = v56; l49 = v57; l50 = v58; l51 = v59; l52 = v60; l53 = v61; l54 = v62; l55 = v63; l56 = v64; l57 = v65; l58 = v66; l59 = v67; l60 = v68; l61 = v69; l62 = v70; l63 = v71; l64 = v72; l65 = v73; l66 = v74; l67 = v75; l68 = v76; l69 = v77} : Mut1
    let v91 : (unit -> (JSX.Element [])) = closure179(v0, v1, v2, v3, v4, v5, v6, v7)
    emitJsExpr (v90, v91) "$0.children = $1"
    let v92 : string = "createComponent"
    let v93 : string = "solid-js"
    let v94 : JS.Function = import v92 v93
    let v95 : (Mut1 -> JSX.Element) = closure111()
    let v96 : JSX.Element = v94.Invoke (v95, v90) |> unbox<JSX.Element>
    [|v96|]
and closure177 (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) struct (v8 : US6, v9 : US6, v10 : US6, v11 : US7, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US6, v17 : US6, v18 : US8, v19 : US9, v20 : US6, v21 : US6, v22 : US8, v23 : US10, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US8, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US12, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US13, v51 : US14, v52 : US13, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US6, v69 : US6, v70 : US12, v71 : US6, v72 : US6, v73 : US10, v74 : US10, v75 : US6, v76 : US5, v77 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
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
    let v87 : (unit -> (JSX.Element [])) = closure178(v0, v1, v2, v3, v4, v5, v6, v7)
    let v88 : US9 = US9_1(v87)
    let v89 : US12 = US12_1(v86)
    struct (v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v88, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v89, v71, v72, v73, v74, v75, v76, v77)
and closure176 () struct (v0 : (unit -> US0), v1 : (US0 -> unit), v2 : (unit -> string), v3 : (string -> unit), v4 : (unit -> string), v5 : (string -> unit), v6 : (unit -> string), v7 : (string -> unit)) : (JSX.Element []) =
    let v8 : US14 = US14_0
    let v9 : US14 = US14_0
    let v10 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure177(v0, v1, v2, v3, v4, v5, v6, v7)
    let v11 : US15 = US15_2
    let v12 : Mut4 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11} : Mut4
    let v13 : string = "createComponent"
    let v14 : string = "solid-js"
    let v15 : JS.Function = import v13 v14
    let v16 : (Mut4 -> JSX.Element) = closure16()
    let v17 : JSX.Element = v15.Invoke (v16, v12) |> unbox<JSX.Element>
    [|v17|]
and closure175 (v0 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []))) () : (JSX.Element []) =
    let v1 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) = v0 ()
    let v2 : string = "For"
    let v3 : string = "solid-js"
    let v4 : JS.Function = import v2 v3
    let v5 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) -> (JSX.Element [])) = closure176()
    let v6 : (unit -> (JSX.Element [])) = v5 |> unbox
    let struct (v7 : US6, v8 : US6, v9 : US6, v10 : US7, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US6, v17 : US8, v18 : US9, v19 : US6, v20 : US6, v21 : US8, v22 : US10, v23 : US6, v24 : US6, v25 : US6, v26 : US11, v27 : US8, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US12, v35 : US6, v36 : US6, v37 : US6, v38 : US12, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US13, v50 : US14, v51 : US13, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US6, v69 : US12, v70 : US6, v71 : US6, v72 : US10, v73 : US10, v74 : US6, v75 : US5, v76 : US6) = method3()
    let v77 : (obj []) = v1 |> unbox<obj[]>
    let v84 : US9 =
        match v18 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v79) -> (* Some *)
            let v80 : string = "children"
            let v81 : JS.Function = import v80 v3
            let v82 : (unit -> (JSX.Element [])) = v81.Invoke v79 |> unbox<unit -> JSX.Element[]>
            US9_1(v82)
    let v86 : (unit -> (JSX.Element [])) =
        match v84 with
        | US9_0 -> (* None *)
            v6
        | US9_1(v85) -> (* Some *)
            v85
    let v87 : US9 = US9_1(v86)
    let v88 : US11 = US11_1(v77)
    let v89 : ((string * obj) []) = method7(v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v87, v19, v20, v21, v22, v23, v24, v25, v88, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76)
    let v90 : obj = createObj v89
    emitJsExpr (v90, v6) "$0.children = $1"
    let v91 : (obj -> JSX.Element) = v4 |> unbox<(obj -> JSX.Element)>
    let v92 : string = "createComponent"
    let v93 : JS.Function = import v92 v3
    let v94 : JSX.Element = v93.Invoke (v91, v90) |> unbox<JSX.Element>
    [|v94|]
and method39 () : JSX.Element =
    let v123 : obj = emitJsExpr () "components_spi.state_context"
    let v124 : string = "useContext"
    let v125 : string = "solid-js"
    let v126 : JS.Function = import v124 v125
    let struct (v127 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v128 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v129 : (unit -> int32), v130 : (int32 -> unit), v131 : (unit -> string), v132 : (string -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v136 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v137 : (unit -> (struct (US2 * (int32 [])) [])), v138 : ((struct (US2 * (int32 [])) []) -> unit), v139 : (unit -> (struct (int32 * obj) [])), v140 : ((struct (int32 * obj) []) -> unit), v141 : (unit -> (struct (int32 * obj) [])), v142 : ((struct (int32 * obj) []) -> unit), v143 : (unit -> (struct (int32 * int32) [])), v144 : ((struct (int32 * int32) []) -> unit), v145 : (unit -> US4), v146 : (US4 -> unit), v147 : (unit -> US5), v148 : (US5 -> unit)) = v126.Invoke v123 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let struct (v149 : US6, v150 : US6, v151 : US6, v152 : US7, v153 : US6, v154 : US6, v155 : US6, v156 : US6, v157 : US6, v158 : US6, v159 : US8, v160 : US9, v161 : US6, v162 : US6, v163 : US8, v164 : US10, v165 : US6, v166 : US6, v167 : US6, v168 : US11, v169 : US8, v170 : US6, v171 : US6, v172 : US6, v173 : US6, v174 : US6, v175 : US6, v176 : US12, v177 : US6, v178 : US6, v179 : US6, v180 : US12, v181 : US6, v182 : US6, v183 : US6, v184 : US6, v185 : US6, v186 : US6, v187 : US6, v188 : US6, v189 : US6, v190 : US6, v191 : US13, v192 : US14, v193 : US13, v194 : US6, v195 : US6, v196 : US6, v197 : US6, v198 : US6, v199 : US6, v200 : US6, v201 : US6, v202 : US6, v203 : US6, v204 : US6, v205 : US6, v206 : US6, v207 : US6, v208 : US6, v209 : US6, v210 : US6, v211 : US12, v212 : US6, v213 : US6, v214 : US10, v215 : US10, v216 : US6, v217 : US5, v218 : US6) = method3()
    let v225 : US9 =
        match v160 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v220) -> (* Some *)
            let v221 : string = "children"
            let v222 : JS.Function = import v221 v125
            let v223 : (unit -> (JSX.Element [])) = v222.Invoke v220 |> unbox<unit -> JSX.Element[]>
            US9_1(v223)
    let v228 : (unit -> (JSX.Element [])) =
        match v225 with
        | US9_0 -> (* None *)
            closure175(v127)
        | US9_1(v227) -> (* Some *)
            v227
    let v229 : US9 = US9_1(v228)
    let v230 : Mut1 = {l0 = v149; l1 = v150; l2 = v151; l3 = v152; l4 = v153; l5 = v154; l6 = v155; l7 = v156; l8 = v157; l9 = v158; l10 = v159; l11 = v229; l12 = v161; l13 = v162; l14 = v163; l15 = v164; l16 = v165; l17 = v166; l18 = v167; l19 = v168; l20 = v169; l21 = v170; l22 = v171; l23 = v172; l24 = v173; l25 = v174; l26 = v175; l27 = v176; l28 = v177; l29 = v178; l30 = v179; l31 = v180; l32 = v181; l33 = v182; l34 = v183; l35 = v184; l36 = v185; l37 = v186; l38 = v187; l39 = v188; l40 = v189; l41 = v190; l42 = v191; l43 = v192; l44 = v193; l45 = v194; l46 = v195; l47 = v196; l48 = v197; l49 = v198; l50 = v199; l51 = v200; l52 = v201; l53 = v202; l54 = v203; l55 = v204; l56 = v205; l57 = v206; l58 = v207; l59 = v208; l60 = v209; l61 = v210; l62 = v211; l63 = v212; l64 = v213; l65 = v214; l66 = v215; l67 = v216; l68 = v217; l69 = v218} : Mut1
    let v231 : (unit -> (JSX.Element [])) = closure175(v127)
    emitJsExpr (v230, v231) "$0.children = $1"
    let v232 : string = "createComponent"
    let v233 : JS.Function = import v232 v125
    let v234 : (Mut1 -> JSX.Element) = closure111()
    let v235 : JSX.Element = v233.Invoke (v234, v230) |> unbox<JSX.Element>
    v235
and closure174 () (v0 : Mut1) : JSX.Element =
    method39()
and closure172 () () : (JSX.Element []) =
    let struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) = method3()
    let v77 : US9 =
        match v11 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v71) -> (* Some *)
            let v72 : string = "children"
            let v73 : string = "solid-js"
            let v74 : JS.Function = import v72 v73
            let v75 : (unit -> (JSX.Element [])) = v74.Invoke v71 |> unbox<unit -> JSX.Element[]>
            US9_1(v75)
    let v80 : (unit -> (JSX.Element [])) =
        match v77 with
        | US9_0 -> (* None *)
            closure173()
        | US9_1(v79) -> (* Some *)
            v79
    let v81 : US9 = US9_1(v80)
    let v82 : Mut1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v81; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67; l68 = v68; l69 = v69} : Mut1
    let v83 : (unit -> (JSX.Element [])) = closure173()
    emitJsExpr (v82, v83) "$0.children = $1"
    let v84 : string = "createComponent"
    let v85 : string = "solid-js"
    let v86 : JS.Function = import v84 v85
    let v87 : (Mut1 -> JSX.Element) = closure174()
    let v88 : JSX.Element = v86.Invoke (v87, v82) |> unbox<JSX.Element>
    [|v88|]
and closure171 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Accounts"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure172()
    let v74 : US9 = US9_1(v73)
    let v75 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure190 () () : (JSX.Element []) =
    [||]
and closure189 () () : (JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : JS.Function = v2?iframe
    let struct (v4 : US6, v5 : US6, v6 : US6, v7 : US7, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US8, v15 : US9, v16 : US6, v17 : US6, v18 : US8, v19 : US10, v20 : US6, v21 : US6, v22 : US6, v23 : US11, v24 : US8, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US13, v47 : US14, v48 : US13, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US12, v67 : US6, v68 : US6, v69 : US10, v70 : US10, v71 : US6, v72 : US5, v73 : US6) = method3()
    let v74 : string = "algorand testnet bank"
    let v75 : JSX.Element = v74 |> unbox<JSX.Element>
    let v76 : JSX.Element = Html.fragment [ v75 ]
    let v84 : US9 =
        match v15 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v78) -> (* Some *)
            let v79 : string = "children"
            let v80 : string = "solid-js"
            let v81 : JS.Function = import v79 v80
            let v82 : (unit -> (JSX.Element [])) = v81.Invoke v78 |> unbox<unit -> JSX.Element[]>
            US9_1(v82)
    let v87 : (unit -> (JSX.Element [])) =
        match v84 with
        | US9_0 -> (* None *)
            closure190()
        | US9_1(v86) -> (* Some *)
            v86
    let v88 : string = "#aaa"
    let v89 : US6 = US6_1(v88)
    let v90 : US9 = US9_1(v87)
    let v91 : string = "1"
    let v92 : US6 = US6_1(v91)
    let v93 : string = "350px"
    let v94 : US6 = US6_1(v93)
    let v95 : string = "https://bank.testnet.algorand.network"
    let v96 : US6 = US6_1(v95)
    let v97 : US12 = US12_1(v76)
    let v98 : ((string * obj) []) = method7(v4, v5, v6, v7, v89, v9, v10, v11, v12, v13, v14, v90, v16, v17, v18, v19, v20, v21, v22, v23, v24, v92, v26, v27, v28, v94, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v96, v64, v65, v97, v67, v68, v69, v70, v71, v72, v73)
    let v99 : obj = createObj v98
    let v100 : (unit -> (JSX.Element [])) = closure190()
    emitJsExpr (v99, v100) "$0.children = $1"
    let v101 : (obj -> JSX.Element) = v3 |> unbox<(obj -> JSX.Element)>
    let v102 : string = "createComponent"
    let v103 : string = "solid-js"
    let v104 : JS.Function = import v102 v103
    let v105 : JSX.Element = v104.Invoke (v101, v99) |> unbox<JSX.Element>
    [|v105|]
and closure188 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Testnet Bank Dispenser"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure189()
    let v74 : US9 = US9_1(v73)
    let v75 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v75, v63, v64, v65, v66, v67, v68, v69)
and closure150 () () : (JSX.Element []) =
    let v0 : US14 = US14_0
    let v1 : US14 = US14_0
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure151()
    let v3 : US15 = US15_2
    let v4 : Mut4 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3} : Mut4
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (Mut4 -> JSX.Element) = closure16()
    let v9 : JSX.Element = v7.Invoke (v8, v4) |> unbox<JSX.Element>
    let v10 : US14 = US14_0
    let v11 : US14 = US14_0
    let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure171()
    let v13 : US15 = US15_2
    let v14 : Mut4 = {l0 = v10; l1 = v11; l2 = v12; l3 = v13} : Mut4
    let v15 : JS.Function = import v5 v6
    let v16 : JSX.Element = v15.Invoke (v8, v14) |> unbox<JSX.Element>
    let v17 : US14 = US14_0
    let v18 : US14 = US14_0
    let v19 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure188()
    let v20 : US15 = US15_0
    let v21 : Mut4 = {l0 = v17; l1 = v18; l2 = v19; l3 = v20} : Mut4
    let v22 : JS.Function = import v5 v6
    let v23 : JSX.Element = v22.Invoke (v8, v21) |> unbox<JSX.Element>
    [|v9; v16; v23|]
and method35 () : JSX.Element =
    let struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) = method3()
    let v77 : US9 =
        match v11 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v71) -> (* Some *)
            let v72 : string = "children"
            let v73 : string = "solid-js"
            let v74 : JS.Function = import v72 v73
            let v75 : (unit -> (JSX.Element [])) = v74.Invoke v71 |> unbox<unit -> JSX.Element[]>
            US9_1(v75)
    let v80 : (unit -> (JSX.Element [])) =
        match v77 with
        | US9_0 -> (* None *)
            closure150()
        | US9_1(v79) -> (* Some *)
            v79
    let v81 : US9 = US9_1(v80)
    let v82 : Mut1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v81; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67; l68 = v68; l69 = v69} : Mut1
    let v83 : (unit -> (JSX.Element [])) = closure150()
    emitJsExpr (v82, v83) "$0.children = $1"
    let v84 : string = "createComponent"
    let v85 : string = "solid-js"
    let v86 : JS.Function = import v84 v85
    let v87 : (Mut1 -> JSX.Element) = closure111()
    let v88 : JSX.Element = v86.Invoke (v87, v82) |> unbox<JSX.Element>
    v88
and closure149 () (v0 : Mut1) : JSX.Element =
    method35()
and closure147 () () : (JSX.Element []) =
    let struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) = method3()
    let v77 : US9 =
        match v11 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v71) -> (* Some *)
            let v72 : string = "children"
            let v73 : string = "solid-js"
            let v74 : JS.Function = import v72 v73
            let v75 : (unit -> (JSX.Element [])) = v74.Invoke v71 |> unbox<unit -> JSX.Element[]>
            US9_1(v75)
    let v80 : (unit -> (JSX.Element [])) =
        match v77 with
        | US9_0 -> (* None *)
            closure148()
        | US9_1(v79) -> (* Some *)
            v79
    let v81 : US9 = US9_1(v80)
    let v82 : Mut1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v81; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67; l68 = v68; l69 = v69} : Mut1
    let v83 : (unit -> (JSX.Element [])) = closure148()
    emitJsExpr (v82, v83) "$0.children = $1"
    let v84 : string = "createComponent"
    let v85 : string = "solid-js"
    let v86 : JS.Function = import v84 v85
    let v87 : (Mut1 -> JSX.Element) = closure149()
    let v88 : JSX.Element = v86.Invoke (v87, v82) |> unbox<JSX.Element>
    [|v88|]
and closure146 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Chain"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure147()
    let v74 : US9 = US9_1(v73)
    let v75 : string = "db"
    let v76 : US6 = US6_1(v75)
    let v77 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v76, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v77, v63, v64, v65, v66, v67, v68, v69)
and closure193 () () : (JSX.Element []) =
    [||]
and closure203 () struct (v0 : (struct (US2 * (int32 [])) []), v1 : int32, v2 : US3, v3 : string, v4 : string) : US6 =
    US6_1(v3)
and closure205 (v0 : Mut18, v1 : (struct (US2 * (int32 [])) []), v2 : int32, v3 : US3, v4 : string, v5 : string) (v6 : US6) : struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) =
    let v7 : US3 = v0.l0
    let v10 : string =
        match v6 with
        | US6_0 -> (* None *)
            let v8 : string = ""
            v8
        | US6_1(v9) -> (* Some *)
            v9
    struct (v1, v2, v7, v10, v5)
and closure204 (v0 : Mut18) struct (v1 : (struct (US2 * (int32 [])) []), v2 : int32, v3 : US3, v4 : string, v5 : string) : (US6 -> struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string)) =
    closure205(v0, v1, v2, v3, v4, v5)
and method43 (v0 : int32, v1 : Mut20) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure207 (v0 : Mut19, v1 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []))) () : US6 =
    let v2 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) = v1 ()
    let v3 : int32 = v2.Length
    let v4 : US6 = US6_0
    let v5 : Mut20 = {l0 = 0; l1 = v4} : Mut20
    while method43(v3, v5) do
        let v7 : int32 = v5.l0
        let v8 : int32 =  -v7
        let v9 : int32 = v8 + v3
        let v10 : int32 = v9 - 1
        let v11 : US6 = v5.l1
        let struct (v12 : (struct (US2 * (int32 [])) []), v13 : int32, v14 : US3, v15 : string, v16 : string) = v2.[int v10]
        let v24 : US6 =
            match v11 with
            | US6_0 -> (* None *)
                let v17 : US3 = v0.l1
                let v18 : bool =
                    match v14, v17 with
                    | US3_0, US3_0 -> (* GunJs *)
                        true
                    | US3_1, US3_1 -> (* GunRs *)
                        true
                    | _ ->
                        false
                if v18 then
                    let v19 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) -> US6) = v0.l0
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
and closure208 (v0 : Mut19, v1 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v2 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []))) (v3 : US6) : unit =
    let v4 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) = v2 ()
    let v5 : int32 = v4.Length
    let v6 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) = Array.zeroCreate<struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string)> (v5)
    let v7 : Mut3 = {l0 = 0} : Mut3
    while method5(v5, v7) do
        let v9 : int32 = v7.l0
        let struct (v10 : (struct (US2 * (int32 [])) []), v11 : int32, v12 : US3, v13 : string, v14 : string) = v4.[int v9]
        let v15 : US3 = v0.l1
        let v16 : bool =
            match v12, v15 with
            | US3_0, US3_0 -> (* GunJs *)
                true
            | US3_1, US3_1 -> (* GunRs *)
                true
            | _ ->
                false
        let struct (v24 : (struct (US2 * (int32 [])) []), v25 : int32, v26 : US3, v27 : string, v28 : string) =
            if v16 then
                let v17 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) -> (US6 -> struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string))) = v0.l2
                let v18 : (US6 -> struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string)) = v17 struct (v10, v11, v12, v13, v14)
                let struct (v19 : (struct (US2 * (int32 [])) []), v20 : int32, v21 : US3, v22 : string, v23 : string) = v18 v3
                struct (v19, v20, v21, v22, v23)
            else
                struct (v10, v11, v12, v13, v14)
        v6.[int v9] <- struct (v24, v25, v26, v27, v28)
        let v29 : int32 = v9 + 1
        v7.l0 <- v29
        ()
    v1 v6
    ()
and method42 (v0 : Mut19) : JSX.Element =
    let v124 : obj = emitJsExpr () "components_spi.state_context"
    let v125 : string = "useContext"
    let v126 : string = "solid-js"
    let v127 : JS.Function = import v125 v126
    let struct (v128 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v129 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v130 : (unit -> int32), v131 : (int32 -> unit), v132 : (unit -> string), v133 : (string -> unit), v134 : (unit -> string), v135 : (string -> unit), v136 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v137 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v138 : (unit -> (struct (US2 * (int32 [])) [])), v139 : ((struct (US2 * (int32 [])) []) -> unit), v140 : (unit -> (struct (int32 * obj) [])), v141 : ((struct (int32 * obj) []) -> unit), v142 : (unit -> (struct (int32 * obj) [])), v143 : ((struct (int32 * obj) []) -> unit), v144 : (unit -> (struct (int32 * int32) [])), v145 : ((struct (int32 * int32) []) -> unit), v146 : (unit -> US4), v147 : (US4 -> unit), v148 : (unit -> US5), v149 : (US5 -> unit)) = v127.Invoke v124 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v150 : (unit -> US6) = closure207(v0, v136)
    let v151 : (US6 -> unit) = closure208(v0, v137, v136)
    let v152 : Mut16 = {l0 = v150; l1 = v151} : Mut16
    let v153 : string = "createComponent"
    let v154 : JS.Function = import v153 v126
    let v155 : (Mut16 -> JSX.Element) = closure160()
    let v156 : JSX.Element = v154.Invoke (v155, v152) |> unbox<JSX.Element>
    v156
and closure206 () (v0 : Mut19) : JSX.Element =
    method42(v0)
and closure202 (v0 : Mut18) () : (JSX.Element []) =
    let v1 : US3 = v0.l0
    let v2 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) -> US6) = closure203()
    let v3 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) -> (US6 -> struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string))) = closure204(v0)
    let v4 : Mut19 = {l0 = v2; l1 = v1; l2 = v3} : Mut19
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (Mut19 -> JSX.Element) = closure206()
    let v9 : JSX.Element = v7.Invoke (v8, v4) |> unbox<JSX.Element>
    [|v9|]
and closure201 (v0 : Mut18) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : string = "URL"
    let v72 : JSX.Element = v71 |> unbox<JSX.Element>
    let v73 : JSX.Element = Html.fragment [ v72 ]
    let v74 : (unit -> (JSX.Element [])) = closure202(v0)
    let v75 : US9 = US9_1(v74)
    let v76 : string = "3px"
    let v77 : US6 = US6_1(v76)
    let v78 : US12 = US12_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v75, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v77, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v78, v64, v65, v66, v67, v68, v69, v70)
and closure211 () struct (v0 : (struct (US2 * (int32 [])) []), v1 : int32, v2 : US3, v3 : string, v4 : string) : US5 =
    US5_1(v1)
and closure213 (v0 : Mut18, v1 : (struct (US2 * (int32 [])) []), v2 : int32, v3 : US3, v4 : string, v5 : string) (v6 : US5) : struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) =
    let v7 : US3 = v0.l0
    let v9 : int32 =
        match v6 with
        | US5_0 -> (* None *)
            0
        | US5_1(v8) -> (* Some *)
            v8
    struct (v1, v9, v7, v4, v5)
and closure212 (v0 : Mut18) struct (v1 : (struct (US2 * (int32 [])) []), v2 : int32, v3 : US3, v4 : string, v5 : string) : (US5 -> struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string)) =
    closure213(v0, v1, v2, v3, v4, v5)
and method45 (v0 : int32, v1 : Mut22) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure215 (v0 : Mut21, v1 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []))) () : US5 =
    let v2 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) = v1 ()
    let v3 : int32 = v2.Length
    let v4 : US5 = US5_0
    let v5 : Mut22 = {l0 = 0; l1 = v4} : Mut22
    while method45(v3, v5) do
        let v7 : int32 = v5.l0
        let v8 : int32 =  -v7
        let v9 : int32 = v8 + v3
        let v10 : int32 = v9 - 1
        let v11 : US5 = v5.l1
        let struct (v12 : (struct (US2 * (int32 [])) []), v13 : int32, v14 : US3, v15 : string, v16 : string) = v2.[int v10]
        let v24 : US5 =
            match v11 with
            | US5_0 -> (* None *)
                let v17 : US3 = v0.l1
                let v18 : bool =
                    match v14, v17 with
                    | US3_0, US3_0 -> (* GunJs *)
                        true
                    | US3_1, US3_1 -> (* GunRs *)
                        true
                    | _ ->
                        false
                if v18 then
                    let v19 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) -> US5) = v0.l0
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
and closure216 (v0 : Mut21, v1 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v2 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []))) (v3 : US5) : unit =
    let v4 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) = v2 ()
    let v5 : int32 = v4.Length
    let v6 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) = Array.zeroCreate<struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string)> (v5)
    let v7 : Mut3 = {l0 = 0} : Mut3
    while method5(v5, v7) do
        let v9 : int32 = v7.l0
        let struct (v10 : (struct (US2 * (int32 [])) []), v11 : int32, v12 : US3, v13 : string, v14 : string) = v4.[int v9]
        let v15 : US3 = v0.l1
        let v16 : bool =
            match v12, v15 with
            | US3_0, US3_0 -> (* GunJs *)
                true
            | US3_1, US3_1 -> (* GunRs *)
                true
            | _ ->
                false
        let struct (v24 : (struct (US2 * (int32 [])) []), v25 : int32, v26 : US3, v27 : string, v28 : string) =
            if v16 then
                let v17 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) -> (US5 -> struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string))) = v0.l2
                let v18 : (US5 -> struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string)) = v17 struct (v10, v11, v12, v13, v14)
                let struct (v19 : (struct (US2 * (int32 [])) []), v20 : int32, v21 : US3, v22 : string, v23 : string) = v18 v3
                struct (v19, v20, v21, v22, v23)
            else
                struct (v10, v11, v12, v13, v14)
        v6.[int v9] <- struct (v24, v25, v26, v27, v28)
        let v29 : int32 = v9 + 1
        v7.l0 <- v29
        ()
    v1 v6
    ()
and method44 (v0 : Mut21) : JSX.Element =
    let v124 : obj = emitJsExpr () "components_spi.state_context"
    let v125 : string = "useContext"
    let v126 : string = "solid-js"
    let v127 : JS.Function = import v125 v126
    let struct (v128 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v129 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v130 : (unit -> int32), v131 : (int32 -> unit), v132 : (unit -> string), v133 : (string -> unit), v134 : (unit -> string), v135 : (string -> unit), v136 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v137 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v138 : (unit -> (struct (US2 * (int32 [])) [])), v139 : ((struct (US2 * (int32 [])) []) -> unit), v140 : (unit -> (struct (int32 * obj) [])), v141 : ((struct (int32 * obj) []) -> unit), v142 : (unit -> (struct (int32 * obj) [])), v143 : ((struct (int32 * obj) []) -> unit), v144 : (unit -> (struct (int32 * int32) [])), v145 : ((struct (int32 * int32) []) -> unit), v146 : (unit -> US4), v147 : (US4 -> unit), v148 : (unit -> US5), v149 : (US5 -> unit)) = v127.Invoke v124 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v150 : (unit -> US5) = closure215(v0, v136)
    let v151 : (US5 -> unit) = closure216(v0, v137, v136)
    let v152 : Mut17 = {l0 = v150; l1 = v151} : Mut17
    let v153 : string = "createComponent"
    let v154 : JS.Function = import v153 v126
    let v155 : (Mut17 -> JSX.Element) = closure169()
    let v156 : JSX.Element = v154.Invoke (v155, v152) |> unbox<JSX.Element>
    v156
and closure214 () (v0 : Mut21) : JSX.Element =
    method44(v0)
and closure210 (v0 : Mut18) () : (JSX.Element []) =
    let v1 : US3 = v0.l0
    let v2 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) -> US5) = closure211()
    let v3 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) -> (US5 -> struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string))) = closure212(v0)
    let v4 : Mut21 = {l0 = v2; l1 = v1; l2 = v3} : Mut21
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (Mut21 -> JSX.Element) = closure214()
    let v9 : JSX.Element = v7.Invoke (v8, v4) |> unbox<JSX.Element>
    [|v9|]
and closure209 (v0 : Mut18) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v71 : string = "Port"
    let v72 : JSX.Element = v71 |> unbox<JSX.Element>
    let v73 : JSX.Element = Html.fragment [ v72 ]
    let v74 : (unit -> (JSX.Element [])) = closure210(v0)
    let v75 : US9 = US9_1(v74)
    let v76 : string = "3px"
    let v77 : US6 = US6_1(v76)
    let v78 : US12 = US12_1(v73)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v75, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v77, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v78, v64, v65, v66, v67, v68, v69, v70)
and closure200 (v0 : Mut18) () : (JSX.Element []) =
    let v1 : US14 = US14_0
    let v2 : US14 = US14_0
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure201(v0)
    let v4 : US15 = US15_2
    let v5 : Mut4 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4} : Mut4
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : (Mut4 -> JSX.Element) = closure16()
    let v10 : JSX.Element = v8.Invoke (v9, v5) |> unbox<JSX.Element>
    let v11 : US14 = US14_0
    let v12 : US14 = US14_0
    let v13 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure209(v0)
    let v14 : US15 = US15_2
    let v15 : Mut4 = {l0 = v11; l1 = v12; l2 = v13; l3 = v14} : Mut4
    let v16 : JS.Function = import v6 v7
    let v17 : JSX.Element = v16.Invoke (v9, v15) |> unbox<JSX.Element>
    [|v10; v17|]
and method41 (v0 : Mut18) : JSX.Element =
    let struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) = method3()
    let v78 : US9 =
        match v12 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v72) -> (* Some *)
            let v73 : string = "children"
            let v74 : string = "solid-js"
            let v75 : JS.Function = import v73 v74
            let v76 : (unit -> (JSX.Element [])) = v75.Invoke v72 |> unbox<unit -> JSX.Element[]>
            US9_1(v76)
    let v81 : (unit -> (JSX.Element [])) =
        match v78 with
        | US9_0 -> (* None *)
            closure200(v0)
        | US9_1(v80) -> (* Some *)
            v80
    let v82 : US9 = US9_1(v81)
    let v83 : Mut1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v82; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63; l63 = v64; l64 = v65; l65 = v66; l66 = v67; l67 = v68; l68 = v69; l69 = v70} : Mut1
    let v84 : (unit -> (JSX.Element [])) = closure200(v0)
    emitJsExpr (v83, v84) "$0.children = $1"
    let v85 : string = "createComponent"
    let v86 : string = "solid-js"
    let v87 : JS.Function = import v85 v86
    let v88 : (Mut1 -> JSX.Element) = closure111()
    let v89 : JSX.Element = v87.Invoke (v88, v83) |> unbox<JSX.Element>
    v89
and closure199 () (v0 : Mut18) : JSX.Element =
    method41(v0)
and closure198 () () : (JSX.Element []) =
    let v0 : US3 = US3_1
    let v1 : Mut18 = {l0 = v0} : Mut18
    let v2 : string = "createComponent"
    let v3 : string = "solid-js"
    let v4 : JS.Function = import v2 v3
    let v5 : (Mut18 -> JSX.Element) = closure199()
    let v6 : JSX.Element = v4.Invoke (v5, v1) |> unbox<JSX.Element>
    [|v6|]
and closure197 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Gun Rust"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure198()
    let v74 : US9 = US9_1(v73)
    let v75 : US6 = US6_0
    let v76 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v75, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v76, v63, v64, v65, v66, v67, v68, v69)
and closure220 () () : bool =
    false
and closure221 () (v0 : bool) : unit =
    ()
and closure223 () () : (JSX.Element []) =
    let v0 : string = "Gun Rust"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure222 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : (unit -> (JSX.Element [])) = closure223()
    let v71 : US9 = US9_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure224 () () : bool =
    false
and closure225 () (v0 : bool) : unit =
    ()
and closure227 () () : (JSX.Element []) =
    let v0 : string = "Gun JavaScript"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure226 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : (unit -> (JSX.Element [])) = closure227()
    let v71 : US9 = US9_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure219 () () : (JSX.Element []) =
    let v0 : (unit -> bool) = closure220()
    let v1 : (bool -> unit) = closure221()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure222()
    let v3 : Mut5 = {l0 = v0; l1 = v1; l2 = v2} : Mut5
    let v4 : string = "createComponent"
    let v5 : string = "solid-js"
    let v6 : JS.Function = import v4 v5
    let v7 : (Mut5 -> JSX.Element) = closure22()
    let v8 : JSX.Element = v6.Invoke (v7, v3) |> unbox<JSX.Element>
    let v9 : (unit -> bool) = closure224()
    let v10 : (bool -> unit) = closure225()
    let v11 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure226()
    let v12 : Mut5 = {l0 = v9; l1 = v10; l2 = v11} : Mut5
    let v13 : JS.Function = import v4 v5
    let v14 : JSX.Element = v13.Invoke (v7, v12) |> unbox<JSX.Element>
    [|v8; v14|]
and closure218 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Clients"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure219()
    let v74 : US9 = US9_1(v73)
    let v75 : US6 = US6_0
    let v76 : string = "4px"
    let v77 : US6 = US6_1(v76)
    let v78 : string = "8px"
    let v79 : US6 = US6_1(v78)
    let v80 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v75, v29, v30, v31, v32, v33, v77, v79, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v80, v63, v64, v65, v66, v67, v68, v69)
and closure217 () () : (JSX.Element []) =
    let v0 : US14 = US14_0
    let v1 : US14 = US14_0
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure218()
    let v3 : US15 = US15_2
    let v4 : Mut4 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3} : Mut4
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (Mut4 -> JSX.Element) = closure16()
    let v9 : JSX.Element = v7.Invoke (v8, v4) |> unbox<JSX.Element>
    [|v9|]
and closure196 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : US14 = US14_0
    let v71 : US14 = US14_0
    let v72 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure197()
    let v73 : US15 = US15_2
    let v74 : Mut4 = {l0 = v70; l1 = v71; l2 = v72; l3 = v73} : Mut4
    let v75 : string = "createComponent"
    let v76 : string = "solid-js"
    let v77 : JS.Function = import v75 v76
    let v78 : (Mut4 -> JSX.Element) = closure16()
    let v79 : JSX.Element = v77.Invoke (v78, v74) |> unbox<JSX.Element>
    let v80 : (unit -> (JSX.Element [])) = closure217()
    let v81 : US9 = US9_1(v80)
    let v82 : US6 = US6_0
    let v83 : string = "0"
    let v84 : US6 = US6_1(v83)
    let v85 : US12 = US12_1(v79)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v81, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v82, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v84, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v85, v63, v64, v65, v66, v67, v68, v69)
and closure230 () () : (JSX.Element []) =
    let v0 : US3 = US3_0
    let v1 : Mut18 = {l0 = v0} : Mut18
    let v2 : string = "createComponent"
    let v3 : string = "solid-js"
    let v4 : JS.Function = import v2 v3
    let v5 : (Mut18 -> JSX.Element) = closure199()
    let v6 : JSX.Element = v4.Invoke (v5, v1) |> unbox<JSX.Element>
    [|v6|]
and closure229 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Gun JavaScript"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure230()
    let v74 : US9 = US9_1(v73)
    let v75 : US6 = US6_0
    let v76 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v75, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v76, v63, v64, v65, v66, v67, v68, v69)
and closure234 () () : bool =
    false
and closure235 () (v0 : bool) : unit =
    ()
and closure237 () () : (JSX.Element []) =
    let v0 : string = "Gun Rust"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure236 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : (unit -> (JSX.Element [])) = closure237()
    let v71 : US9 = US9_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure238 () () : bool =
    false
and closure239 () (v0 : bool) : unit =
    ()
and closure241 () () : (JSX.Element []) =
    let v0 : string = "Gun JavaScript"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure240 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : (unit -> (JSX.Element [])) = closure241()
    let v71 : US9 = US9_1(v70)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v71, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure233 () () : (JSX.Element []) =
    let v0 : (unit -> bool) = closure234()
    let v1 : (bool -> unit) = closure235()
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure236()
    let v3 : Mut5 = {l0 = v0; l1 = v1; l2 = v2} : Mut5
    let v4 : string = "createComponent"
    let v5 : string = "solid-js"
    let v6 : JS.Function = import v4 v5
    let v7 : (Mut5 -> JSX.Element) = closure22()
    let v8 : JSX.Element = v6.Invoke (v7, v3) |> unbox<JSX.Element>
    let v9 : (unit -> bool) = closure238()
    let v10 : (bool -> unit) = closure239()
    let v11 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure240()
    let v12 : Mut5 = {l0 = v9; l1 = v10; l2 = v11} : Mut5
    let v13 : JS.Function = import v4 v5
    let v14 : JSX.Element = v13.Invoke (v7, v12) |> unbox<JSX.Element>
    [|v8; v14|]
and closure232 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Clients"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure233()
    let v74 : US9 = US9_1(v73)
    let v75 : US6 = US6_0
    let v76 : string = "4px"
    let v77 : US6 = US6_1(v76)
    let v78 : string = "8px"
    let v79 : US6 = US6_1(v78)
    let v80 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v75, v29, v30, v31, v32, v33, v77, v79, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v80, v63, v64, v65, v66, v67, v68, v69)
and closure231 () () : (JSX.Element []) =
    let v0 : US14 = US14_0
    let v1 : US14 = US14_0
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure232()
    let v3 : US15 = US15_2
    let v4 : Mut4 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3} : Mut4
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (Mut4 -> JSX.Element) = closure16()
    let v9 : JSX.Element = v7.Invoke (v8, v4) |> unbox<JSX.Element>
    [|v9|]
and closure228 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : US14 = US14_0
    let v71 : US14 = US14_0
    let v72 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure229()
    let v73 : US15 = US15_2
    let v74 : Mut4 = {l0 = v70; l1 = v71; l2 = v72; l3 = v73} : Mut4
    let v75 : string = "createComponent"
    let v76 : string = "solid-js"
    let v77 : JS.Function = import v75 v76
    let v78 : (Mut4 -> JSX.Element) = closure16()
    let v79 : JSX.Element = v77.Invoke (v78, v74) |> unbox<JSX.Element>
    let v80 : (unit -> (JSX.Element [])) = closure231()
    let v81 : US9 = US9_1(v80)
    let v82 : US6 = US6_0
    let v83 : string = "0"
    let v84 : US6 = US6_1(v83)
    let v85 : US12 = US12_1(v79)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v81, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v82, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v84, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v85, v63, v64, v65, v66, v67, v68, v69)
and closure195 () () : (JSX.Element []) =
    let v0 : US14 = US14_0
    let v1 : US14 = US14_0
    let v2 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure196()
    let v3 : US15 = US15_2
    let v4 : Mut4 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3} : Mut4
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (Mut4 -> JSX.Element) = closure16()
    let v9 : JSX.Element = v7.Invoke (v8, v4) |> unbox<JSX.Element>
    let v10 : US14 = US14_0
    let v11 : US14 = US14_0
    let v12 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure228()
    let v13 : US15 = US15_2
    let v14 : Mut4 = {l0 = v10; l1 = v11; l2 = v12; l3 = v13} : Mut4
    let v15 : JS.Function = import v5 v6
    let v16 : JSX.Element = v15.Invoke (v8, v14) |> unbox<JSX.Element>
    [|v9; v16|]
and method40 () : JSX.Element =
    let struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) = method3()
    let v77 : US9 =
        match v11 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v71) -> (* Some *)
            let v72 : string = "children"
            let v73 : string = "solid-js"
            let v74 : JS.Function = import v72 v73
            let v75 : (unit -> (JSX.Element [])) = v74.Invoke v71 |> unbox<unit -> JSX.Element[]>
            US9_1(v75)
    let v80 : (unit -> (JSX.Element [])) =
        match v77 with
        | US9_0 -> (* None *)
            closure195()
        | US9_1(v79) -> (* Some *)
            v79
    let v81 : US9 = US9_1(v80)
    let v82 : Mut1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v81; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67; l68 = v68; l69 = v69} : Mut1
    let v83 : (unit -> (JSX.Element [])) = closure195()
    emitJsExpr (v82, v83) "$0.children = $1"
    let v84 : string = "createComponent"
    let v85 : string = "solid-js"
    let v86 : JS.Function = import v84 v85
    let v87 : (Mut1 -> JSX.Element) = closure111()
    let v88 : JSX.Element = v86.Invoke (v87, v82) |> unbox<JSX.Element>
    v88
and closure194 () (v0 : Mut1) : JSX.Element =
    method40()
and closure192 () () : (JSX.Element []) =
    let struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) = method3()
    let v77 : US9 =
        match v11 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v71) -> (* Some *)
            let v72 : string = "children"
            let v73 : string = "solid-js"
            let v74 : JS.Function = import v72 v73
            let v75 : (unit -> (JSX.Element [])) = v74.Invoke v71 |> unbox<unit -> JSX.Element[]>
            US9_1(v75)
    let v80 : (unit -> (JSX.Element [])) =
        match v77 with
        | US9_0 -> (* None *)
            closure193()
        | US9_1(v79) -> (* Some *)
            v79
    let v81 : US9 = US9_1(v80)
    let v82 : Mut1 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v10; l11 = v81; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v56; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62; l63 = v63; l64 = v64; l65 = v65; l66 = v66; l67 = v67; l68 = v68; l69 = v69} : Mut1
    let v83 : (unit -> (JSX.Element [])) = closure193()
    emitJsExpr (v82, v83) "$0.children = $1"
    let v84 : string = "createComponent"
    let v85 : string = "solid-js"
    let v86 : JS.Function = import v84 v85
    let v87 : (Mut1 -> JSX.Element) = closure194()
    let v88 : JSX.Element = v86.Invoke (v87, v82) |> unbox<JSX.Element>
    [|v88|]
and closure191 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : string = "Database"
    let v71 : JSX.Element = v70 |> unbox<JSX.Element>
    let v72 : JSX.Element = Html.fragment [ v71 ]
    let v73 : (unit -> (JSX.Element [])) = closure192()
    let v74 : US9 = US9_1(v73)
    let v75 : string = "db"
    let v76 : US6 = US6_1(v75)
    let v77 : US12 = US12_1(v72)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v74, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v76, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v77, v63, v64, v65, v66, v67, v68, v69)
and closure245 () () : (JSX.Element []) =
    [||]
and closure249 (v0 : ((struct (int32 * int32) []) -> unit)) (v1 : (struct (int32 * int32) [])) : unit =
    v0 v1
    ()
and closure248 (v0 : ((struct (int32 * int32) []) -> unit)) () : ((struct (int32 * int32) []) -> unit) =
    closure249(v0)
and closure247 (v0 : ((struct (int32 * int32) []) -> unit)) () : (unit -> ((struct (int32 * int32) []) -> unit)) =
    closure248(v0)
and method47 (v0 : int32, v1 : Mut23) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure250 (v0 : (unit -> (struct (int32 * int32) []))) (v1 : obj) : int32 =
    let v2 : (struct (int32 * int32) []) = v0 ()
    let v3 : int32 = v2.Length
    let v4 : Mut23 = {l0 = 0; l1 = 0} : Mut23
    while method47(v3, v4) do
        let v6 : int32 = v4.l0
        let v7 : int32 = v4.l1
        let struct (v8 : int32, v9 : int32) = v2.[int v6]
        let v10 : int32 = v7 + 1
        let v11 : int32 = v6 + 1
        v4.l0 <- v11
        v4.l1 <- v10
        ()
    let v12 : int32 = v4.l1
    v12
and closure251 (v0 : string, v1 : (struct (int32 * int32) []), v2 : (unit -> unit), v3 : (unit -> unit), v4 : (unit -> unit), v5 : (unit -> unit)) () : (obj []) =
    let v6 : string = "content_address:"
    let v7 : obj = struct (v6, v0)
    let v8 : string = "proxy:"
    let v9 : obj = struct (v8, v1)
    let v10 : string = "events:"
    let v11 : obj = struct (v10, v2)
    let v12 : string = "timers:"
    let v13 : obj = struct (v12, v3)
    let v14 : string = "values:"
    let v15 : obj = struct (v14, v4)
    let v16 : string = "subscriptions:"
    let v17 : obj = struct (v16, v5)
    [|v7; v9; v11; v13; v15; v17|]
and closure252 (v0 : string, v1 : (US4 -> ((obj []) -> unit))) () : unit =
    let v2 : US4 = US4_0
    let v3 : ((obj []) -> unit) = v1 v2
    let v4 : string = "> use_fetch > unsubscribe () [1]"
    let v5 : obj = v4
    let v6 : (obj []) = [|v5|]
    v3 v6
    let v7 : string = "db_off"
    printfn $"%A{struct (v7, v0)}"
    ()
and closure253 (v0 : (US4 -> ((obj []) -> unit))) () : unit =
    let v1 : US4 = US4_2
    let v2 : ((obj []) -> unit) = v0 v1
    let v3 : string = ">> use_fetch request()"
    let v4 : obj = v3
    let v5 : (obj []) = [|v4|]
    v2 v5
    ()
and closure254 (v0 : (US4 -> ((obj []) -> unit))) () : unit =
    let v1 : US4 = US4_2
    let v2 : ((obj []) -> unit) = v0 v1
    let v3 : string = ">> use_fetch clear()"
    let v4 : obj = v3
    let v5 : (obj []) = [|v4|]
    v2 v5
    ()
and method48 (v0 : string, v1 : (struct (int32 * int32) [])) : struct ((unit -> unit) * (unit -> unit)) =
    let v2 : string = "createSignal"
    let v3 : string = "solid-js"
    let v4 : JS.Function = import v2 v3
    let v5 : (JS.Function []) = v4.Invoke () |> unbox<JS.Function[]>
    let v6 : (unit -> unit) = v5.[0] |> unbox
    let v7 : (unit -> unit) = v5.[1] |> unbox
    let v8 : JS.Function = import v2 v3
    let v9 : (JS.Function []) = v8.Invoke () |> unbox<JS.Function[]>
    let v10 : (unit -> unit) = v9.[0] |> unbox
    let v11 : (unit -> unit) = v9.[1] |> unbox
    let v12 : JS.Function = import v2 v3
    let v13 : (JS.Function []) = v12.Invoke () |> unbox<JS.Function[]>
    let v14 : (unit -> unit) = v13.[0] |> unbox
    let v15 : (unit -> unit) = v13.[1] |> unbox
    let v16 : JS.Function = import v2 v3
    let v17 : (JS.Function []) = v16.Invoke () |> unbox<JS.Function[]>
    let v18 : (unit -> unit) = v17.[0] |> unbox
    let v19 : (unit -> unit) = v17.[1] |> unbox
    let v20 : (uint8 []) = System.Text.Encoding.UTF8.GetBytes v0
    let v21 : int32 = v20.Length
    let v22 : Mut23 = {l0 = 0; l1 = 100000} : Mut23
    while method47(v21, v22) do
        let v24 : int32 = v22.l0
        let v25 : int32 = v22.l1
        let v26 : uint8 = v20.[int v24]
        let v27 : int32 = v26 |> unbox<int32>
        let v28 : int32 = v27 * 14
        let v29 : int32 = v25 + v28
        let v30 : int32 = v24 + 1
        v22.l0 <- v30
        v22.l1 <- v29
        ()
    let v31 : int32 = v22.l1
    let v32 : string = v31.ToString ()
    let v33 : string = $"#{v32}"
    let v34 : (unit -> (obj [])) = closure251(v0, v1, v6, v10, v14, v18)
    let v35 : (US4 -> ((obj []) -> unit)) = method14(v34, v33)
    let v36 : US4 = US4_0
    let v37 : ((obj []) -> unit) = v35 v36
    let v38 : string = "> use_fetch ()"
    let v39 : obj = v38
    let v40 : (obj []) = [|v39|]
    v37 v40
    let v41 : (unit -> unit) = closure252(v0, v35)
    method18(v41)
    let v42 : (unit -> unit) = closure253(v35)
    let v43 : (unit -> unit) = closure254(v35)
    struct (v42, v43)
and closure257 () () : (JSX.Element []) =
    let v0 : string = "Counter"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure258 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v70, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure259 () () : JS.Function =
    let v0 : string = "BiRegularPlus"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure260 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure261 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v70, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure262 () () : JS.Function =
    let v0 : string = "BiRegularMinus"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure263 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure256 (v0 : (unit -> unit), v1 : (unit -> unit)) () : (JSX.Element []) =
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let struct (v5 : US6, v6 : US6, v7 : US6, v8 : US7, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US8, v16 : US9, v17 : US6, v18 : US6, v19 : US8, v20 : US10, v21 : US6, v22 : US6, v23 : US6, v24 : US11, v25 : US8, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US12, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US13, v48 : US14, v49 : US13, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US12, v68 : US6, v69 : US6, v70 : US10, v71 : US10, v72 : US6, v73 : US5, v74 : US6) = method3()
    let v82 : US9 =
        match v16 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v76) -> (* Some *)
            let v77 : string = "children"
            let v78 : string = "solid-js"
            let v79 : JS.Function = import v77 v78
            let v80 : (unit -> (JSX.Element [])) = v79.Invoke v76 |> unbox<unit -> JSX.Element[]>
            US9_1(v80)
    let v85 : (unit -> (JSX.Element [])) =
        match v82 with
        | US9_0 -> (* None *)
            closure257()
        | US9_1(v84) -> (* Some *)
            v84
    let v86 : US9 = US9_1(v85)
    let v87 : ((string * obj) []) = method7(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v86, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74)
    let v88 : obj = createObj v87
    let v89 : (unit -> (JSX.Element [])) = closure257()
    emitJsExpr (v88, v89) "$0.children = $1"
    let v90 : (obj -> JSX.Element) = v4 |> unbox<(obj -> JSX.Element)>
    let v91 : string = "createComponent"
    let v92 : string = "solid-js"
    let v93 : JS.Function = import v91 v92
    let v94 : JSX.Element = v93.Invoke (v90, v88) |> unbox<JSX.Element>
    let struct (v95 : US6, v96 : US6, v97 : US6, v98 : US7, v99 : US6, v100 : US6, v101 : US6, v102 : US6, v103 : US6, v104 : US6, v105 : US8, v106 : US9, v107 : US6, v108 : US6, v109 : US8, v110 : US10, v111 : US6, v112 : US6, v113 : US6, v114 : US11, v115 : US8, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US12, v123 : US6, v124 : US6, v125 : US6, v126 : US12, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US6, v135 : US6, v136 : US6, v137 : US13, v138 : US14, v139 : US13, v140 : US6, v141 : US6, v142 : US6, v143 : US6, v144 : US6, v145 : US6, v146 : US6, v147 : US6, v148 : US6, v149 : US6, v150 : US6, v151 : US6, v152 : US6, v153 : US6, v154 : US6, v155 : US6, v156 : US6, v157 : US12, v158 : US6, v159 : US6, v160 : US10, v161 : US10, v162 : US6, v163 : US5, v164 : US6) = method3()
    let v165 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure258()
    let v166 : (unit -> JS.Function) = closure259()
    let v167 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure45()
    let v168 : Mut7 = {l0 = v165; l1 = v166; l2 = v167} : Mut7
    let v169 : JS.Function = import v91 v92
    let v170 : (Mut7 -> JSX.Element) = closure47()
    let v171 : JSX.Element = v169.Invoke (v170, v168) |> unbox<JSX.Element>
    let v178 : US9 =
        match v106 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v173) -> (* Some *)
            let v174 : string = "children"
            let v175 : JS.Function = import v174 v92
            let v176 : (unit -> (JSX.Element [])) = v175.Invoke v173 |> unbox<unit -> JSX.Element[]>
            US9_1(v176)
    let v181 : (unit -> (JSX.Element [])) =
        match v178 with
        | US9_0 -> (* None *)
            closure260()
        | US9_1(v180) -> (* Some *)
            v180
    let v182 : US9 = US9_1(v181)
    let v183 : US12 = US12_1(v171)
    let v184 : US14 = US14_1(v1)
    let v185 : string = "10px"
    let v186 : US6 = US6_1(v185)
    let v187 : Mut1 = {l0 = v95; l1 = v96; l2 = v97; l3 = v98; l4 = v99; l5 = v100; l6 = v101; l7 = v102; l8 = v103; l9 = v104; l10 = v105; l11 = v182; l12 = v107; l13 = v108; l14 = v109; l15 = v110; l16 = v111; l17 = v112; l18 = v113; l19 = v114; l20 = v115; l21 = v116; l22 = v117; l23 = v118; l24 = v119; l25 = v120; l26 = v121; l27 = v122; l28 = v123; l29 = v124; l30 = v125; l31 = v183; l32 = v127; l33 = v128; l34 = v129; l35 = v130; l36 = v131; l37 = v132; l38 = v133; l39 = v134; l40 = v135; l41 = v136; l42 = v137; l43 = v184; l44 = v139; l45 = v140; l46 = v141; l47 = v142; l48 = v143; l49 = v144; l50 = v145; l51 = v146; l52 = v186; l53 = v148; l54 = v149; l55 = v150; l56 = v151; l57 = v152; l58 = v153; l59 = v154; l60 = v155; l61 = v156; l62 = v157; l63 = v158; l64 = v159; l65 = v160; l66 = v161; l67 = v162; l68 = v163; l69 = v164} : Mut1
    let v188 : (unit -> (JSX.Element [])) = closure260()
    emitJsExpr (v187, v188) "$0.children = $1"
    let v189 : JS.Function = import v91 v92
    let v190 : (Mut1 -> JSX.Element) = closure40()
    let v191 : JSX.Element = v189.Invoke (v190, v187) |> unbox<JSX.Element>
    let struct (v192 : US6, v193 : US6, v194 : US6, v195 : US7, v196 : US6, v197 : US6, v198 : US6, v199 : US6, v200 : US6, v201 : US6, v202 : US8, v203 : US9, v204 : US6, v205 : US6, v206 : US8, v207 : US10, v208 : US6, v209 : US6, v210 : US6, v211 : US11, v212 : US8, v213 : US6, v214 : US6, v215 : US6, v216 : US6, v217 : US6, v218 : US6, v219 : US12, v220 : US6, v221 : US6, v222 : US6, v223 : US12, v224 : US6, v225 : US6, v226 : US6, v227 : US6, v228 : US6, v229 : US6, v230 : US6, v231 : US6, v232 : US6, v233 : US6, v234 : US13, v235 : US14, v236 : US13, v237 : US6, v238 : US6, v239 : US6, v240 : US6, v241 : US6, v242 : US6, v243 : US6, v244 : US6, v245 : US6, v246 : US6, v247 : US6, v248 : US6, v249 : US6, v250 : US6, v251 : US6, v252 : US6, v253 : US6, v254 : US12, v255 : US6, v256 : US6, v257 : US10, v258 : US10, v259 : US6, v260 : US5, v261 : US6) = method3()
    let v262 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure261()
    let v263 : (unit -> JS.Function) = closure262()
    let v264 : Mut7 = {l0 = v262; l1 = v263; l2 = v167} : Mut7
    let v265 : JS.Function = import v91 v92
    let v266 : JSX.Element = v265.Invoke (v170, v264) |> unbox<JSX.Element>
    let v273 : US9 =
        match v203 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v268) -> (* Some *)
            let v269 : string = "children"
            let v270 : JS.Function = import v269 v92
            let v271 : (unit -> (JSX.Element [])) = v270.Invoke v268 |> unbox<unit -> JSX.Element[]>
            US9_1(v271)
    let v276 : (unit -> (JSX.Element [])) =
        match v273 with
        | US9_0 -> (* None *)
            closure263()
        | US9_1(v275) -> (* Some *)
            v275
    let v277 : US9 = US9_1(v276)
    let v278 : US12 = US12_1(v266)
    let v279 : US14 = US14_1(v0)
    let v280 : US6 = US6_1(v185)
    let v281 : Mut1 = {l0 = v192; l1 = v193; l2 = v194; l3 = v195; l4 = v196; l5 = v197; l6 = v198; l7 = v199; l8 = v200; l9 = v201; l10 = v202; l11 = v277; l12 = v204; l13 = v205; l14 = v206; l15 = v207; l16 = v208; l17 = v209; l18 = v210; l19 = v211; l20 = v212; l21 = v213; l22 = v214; l23 = v215; l24 = v216; l25 = v217; l26 = v218; l27 = v219; l28 = v220; l29 = v221; l30 = v222; l31 = v278; l32 = v224; l33 = v225; l34 = v226; l35 = v227; l36 = v228; l37 = v229; l38 = v230; l39 = v231; l40 = v232; l41 = v233; l42 = v234; l43 = v279; l44 = v236; l45 = v237; l46 = v238; l47 = v239; l48 = v240; l49 = v241; l50 = v242; l51 = v243; l52 = v280; l53 = v245; l54 = v246; l55 = v247; l56 = v248; l57 = v249; l58 = v250; l59 = v251; l60 = v252; l61 = v253; l62 = v254; l63 = v255; l64 = v256; l65 = v257; l66 = v258; l67 = v259; l68 = v260; l69 = v261} : Mut1
    let v282 : (unit -> (JSX.Element [])) = closure263()
    emitJsExpr (v281, v282) "$0.children = $1"
    let v283 : JS.Function = import v91 v92
    let v284 : JSX.Element = v283.Invoke (v190, v281) |> unbox<JSX.Element>
    [|v94; v191; v284|]
and method49 (v0 : int32, v1 : Mut24) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method50 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH1 = UH1_0(v2, v3, v1)
        method50(v4, v5)
    | UH1_1 -> (* Nil *)
        v1
and method52 (v0 : UH1, v1 : int32) : int32 =
    match v0 with
    | UH1_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method52(v4, v5)
    | UH1_1 -> (* Nil *)
        v1
and method53 (v0 : (struct (int32 * int32) []), v1 : UH1, v2 : int32) : int32 =
    match v1 with
    | UH1_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method53(v0, v5, v6)
    | UH1_1 -> (* Nil *)
        v2
and method51 (v0 : UH1) : (struct (int32 * int32) []) =
    let v1 : int32 = 0
    let v2 : int32 = method52(v0, v1)
    let v3 : (struct (int32 * int32) []) = Array.zeroCreate<struct (int32 * int32)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method53(v3, v0, v4)
    v3
and closure269 (v0 : (unit -> struct (int32 * int32))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : int32) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = v3 |> unbox<JSX.Element>
    let v5 : JSX.Element = Html.fragment [ v4 ]
    [|v5|]
and closure268 (v0 : (unit -> struct (int32 * int32))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US6, v6 : US6, v7 : US6, v8 : US7, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US8, v16 : US9, v17 : US6, v18 : US6, v19 : US8, v20 : US10, v21 : US6, v22 : US6, v23 : US6, v24 : US11, v25 : US8, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US12, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US13, v48 : US14, v49 : US13, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US12, v68 : US6, v69 : US6, v70 : US10, v71 : US10, v72 : US6, v73 : US5, v74 : US6) = method3()
    let v82 : US9 =
        match v16 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v76) -> (* Some *)
            let v77 : string = "children"
            let v78 : string = "solid-js"
            let v79 : JS.Function = import v77 v78
            let v80 : (unit -> (JSX.Element [])) = v79.Invoke v76 |> unbox<unit -> JSX.Element[]>
            US9_1(v80)
    let v85 : (unit -> (JSX.Element [])) =
        match v82 with
        | US9_0 -> (* None *)
            closure269(v0)
        | US9_1(v84) -> (* Some *)
            v84
    let v86 : US9 = US9_1(v85)
    let v87 : ((string * obj) []) = method7(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v86, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74)
    let v88 : obj = createObj v87
    let v89 : (unit -> (JSX.Element [])) = closure269(v0)
    emitJsExpr (v88, v89) "$0.children = $1"
    let v90 : (obj -> JSX.Element) = v4 |> unbox<(obj -> JSX.Element)>
    let v91 : string = "createComponent"
    let v92 : string = "solid-js"
    let v93 : JS.Function = import v91 v92
    let v94 : JSX.Element = v93.Invoke (v90, v88) |> unbox<JSX.Element>
    [|v94|]
and closure267 (v0 : (unit -> struct (int32 * int32))) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let struct (v71 : int32, v72 : int32) = v0 ()
    let v73 : string = v71.ToString ()
    let v74 : JSX.Element = v73 |> unbox<JSX.Element>
    let v75 : JSX.Element = Html.fragment [ v74 ]
    let v76 : (unit -> (JSX.Element [])) = closure268(v0)
    let v77 : US9 = US9_1(v76)
    let v78 : string = "3px"
    let v79 : US6 = US6_1(v78)
    let v80 : US12 = US12_1(v75)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v77, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v79, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v80, v64, v65, v66, v67, v68, v69, v70)
and closure266 () (v0 : (unit -> struct (int32 * int32))) : (JSX.Element []) =
    let v1 : US14 = US14_0
    let v2 : US14 = US14_0
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure267(v0)
    let v4 : US15 = US15_2
    let v5 : Mut4 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4} : Mut4
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : (Mut4 -> JSX.Element) = closure16()
    let v10 : JSX.Element = v8.Invoke (v9, v5) |> unbox<JSX.Element>
    [|v10|]
and closure265 (v0 : (unit -> (struct (int32 * int32) []))) () : (JSX.Element []) =
    let v1 : (struct (int32 * int32) []) = v0 ()
    let v2 : int32 = v1.Length
    let v3 : UH1 = UH1_1
    let v4 : Mut24 = {l0 = 0; l1 = v3} : Mut24
    while method49(v2, v4) do
        let v6 : int32 = v4.l0
        let v7 : int32 =  -v6
        let v8 : int32 = v7 + v2
        let v9 : int32 = v8 - 1
        let v10 : UH1 = v4.l1
        let struct (v11 : int32, v12 : int32) = v1.[int v9]
        let v13 : int32 = v6 + 1
        let v14 : UH1 = UH1_0(v11, v12, v10)
        v4.l0 <- v13
        v4.l1 <- v14
        ()
    let v15 : UH1 = v4.l1
    let v16 : UH1 = UH1_1
    let v17 : UH1 = method50(v15, v16)
    let v18 : (struct (int32 * int32) []) = method51(v17)
    let v19 : string = "Index"
    let v20 : string = "solid-js"
    let v21 : JS.Function = import v19 v20
    let v22 : ((unit -> struct (int32 * int32)) -> (JSX.Element [])) = closure266()
    let v23 : (unit -> (JSX.Element [])) = v22 |> unbox
    let struct (v24 : US6, v25 : US6, v26 : US6, v27 : US7, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US8, v35 : US9, v36 : US6, v37 : US6, v38 : US8, v39 : US10, v40 : US6, v41 : US6, v42 : US6, v43 : US11, v44 : US8, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US12, v52 : US6, v53 : US6, v54 : US6, v55 : US12, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US13, v67 : US14, v68 : US13, v69 : US6, v70 : US6, v71 : US6, v72 : US6, v73 : US6, v74 : US6, v75 : US6, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US6, v83 : US6, v84 : US6, v85 : US6, v86 : US12, v87 : US6, v88 : US6, v89 : US10, v90 : US10, v91 : US6, v92 : US5, v93 : US6) = method3()
    let v94 : (obj []) = v18 |> unbox<obj[]>
    let v101 : US9 =
        match v35 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v96) -> (* Some *)
            let v97 : string = "children"
            let v98 : JS.Function = import v97 v20
            let v99 : (unit -> (JSX.Element [])) = v98.Invoke v96 |> unbox<unit -> JSX.Element[]>
            US9_1(v99)
    let v103 : (unit -> (JSX.Element [])) =
        match v101 with
        | US9_0 -> (* None *)
            v23
        | US9_1(v102) -> (* Some *)
            v102
    let v104 : US9 = US9_1(v103)
    let v105 : US11 = US11_1(v94)
    let v106 : ((string * obj) []) = method7(v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v104, v36, v37, v38, v39, v40, v41, v42, v105, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93)
    let v107 : obj = createObj v106
    emitJsExpr (v107, v23) "$0.children = $1"
    let v108 : (obj -> JSX.Element) = v21 |> unbox<(obj -> JSX.Element)>
    let v109 : string = "createComponent"
    let v110 : JS.Function = import v109 v20
    let v111 : JSX.Element = v110.Invoke (v108, v107) |> unbox<JSX.Element>
    [|v111|]
and closure264 (v0 : (unit -> (struct (int32 * int32) []))) () : (JSX.Element []) =
    let struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) = method3()
    let v78 : US9 =
        match v12 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v72) -> (* Some *)
            let v73 : string = "children"
            let v74 : string = "solid-js"
            let v75 : JS.Function = import v73 v74
            let v76 : (unit -> (JSX.Element [])) = v75.Invoke v72 |> unbox<unit -> JSX.Element[]>
            US9_1(v76)
    let v81 : (unit -> (JSX.Element [])) =
        match v78 with
        | US9_0 -> (* None *)
            closure265(v0)
        | US9_1(v80) -> (* Some *)
            v80
    let v82 : US9 = US9_1(v81)
    let v83 : Mut1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v82; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63; l63 = v64; l64 = v65; l65 = v66; l66 = v67; l67 = v68; l68 = v69; l69 = v70} : Mut1
    let v84 : (unit -> (JSX.Element [])) = closure265(v0)
    emitJsExpr (v83, v84) "$0.children = $1"
    let v85 : string = "createComponent"
    let v86 : string = "solid-js"
    let v87 : JS.Function = import v85 v86
    let v88 : (Mut1 -> JSX.Element) = closure111()
    let v89 : JSX.Element = v87.Invoke (v88, v83) |> unbox<JSX.Element>
    [|v89|]
and closure255 (v0 : (unit -> (struct (int32 * int32) [])), v1 : (unit -> unit), v2 : (unit -> unit)) struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US10, v19 : US6, v20 : US6, v21 : US6, v22 : US11, v23 : US8, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US12, v31 : US6, v32 : US6, v33 : US6, v34 : US12, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US13, v46 : US14, v47 : US13, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US12, v66 : US6, v67 : US6, v68 : US10, v69 : US10, v70 : US6, v71 : US5, v72 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v73 : string = "Stack"
    let v74 : string = "@hope-ui/solid"
    let v75 : JS.Function = import v73 v74
    let struct (v76 : US6, v77 : US6, v78 : US6, v79 : US7, v80 : US6, v81 : US6, v82 : US6, v83 : US6, v84 : US6, v85 : US6, v86 : US8, v87 : US9, v88 : US6, v89 : US6, v90 : US8, v91 : US10, v92 : US6, v93 : US6, v94 : US6, v95 : US11, v96 : US8, v97 : US6, v98 : US6, v99 : US6, v100 : US6, v101 : US6, v102 : US6, v103 : US12, v104 : US6, v105 : US6, v106 : US6, v107 : US12, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US6, v115 : US6, v116 : US6, v117 : US6, v118 : US13, v119 : US14, v120 : US13, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US6, v135 : US6, v136 : US6, v137 : US6, v138 : US12, v139 : US6, v140 : US6, v141 : US10, v142 : US10, v143 : US6, v144 : US5, v145 : US6) = method3()
    let v146 : string = "row"
    let v147 : string = "column"
    let v148 : string = method12(v147, v146)
    let v149 : string = "0"
    let v150 : string = "8px"
    let v151 : string = method12(v150, v149)
    let v159 : US9 =
        match v87 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v153) -> (* Some *)
            let v154 : string = "children"
            let v155 : string = "solid-js"
            let v156 : JS.Function = import v154 v155
            let v157 : (unit -> (JSX.Element [])) = v156.Invoke v153 |> unbox<unit -> JSX.Element[]>
            US9_1(v157)
    let v162 : (unit -> (JSX.Element [])) =
        match v159 with
        | US9_0 -> (* None *)
            closure256(v1, v2)
        | US9_1(v161) -> (* Some *)
            v161
    let v163 : string = "start"
    let v164 : US6 = US6_1(v163)
    let v165 : US9 = US9_1(v162)
    let v166 : US6 = US6_1(v148)
    let v167 : US6 = US6_1(v151)
    let v168 : string = "3px"
    let v169 : US6 = US6_1(v168)
    let v170 : string = "7px"
    let v171 : US6 = US6_1(v170)
    let v172 : ((string * obj) []) = method7(v164, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v165, v88, v89, v90, v91, v92, v166, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v167, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v169, v126, v127, v128, v129, v130, v131, v132, v133, v171, v135, v136, v137, v138, v139, v140, v141, v142, v143, v144, v145)
    let v173 : obj = createObj v172
    let v174 : (unit -> (JSX.Element [])) = closure256(v1, v2)
    emitJsExpr (v173, v174) "$0.children = $1"
    let v175 : (obj -> JSX.Element) = v75 |> unbox<(obj -> JSX.Element)>
    let v176 : string = "createComponent"
    let v177 : string = "solid-js"
    let v178 : JS.Function = import v176 v177
    let v179 : JSX.Element = v178.Invoke (v175, v173) |> unbox<JSX.Element>
    let v180 : (unit -> (JSX.Element [])) = closure264(v0)
    let v181 : US9 = US9_1(v180)
    let v182 : string = "counter"
    let v183 : US6 = US6_1(v182)
    let v184 : US12 = US12_1(v179)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v181, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v183, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v184, v66, v67, v68, v69, v70, v71, v72)
and method46 () : JSX.Element =
    let v123 : obj = emitJsExpr () "components_spi.state_context"
    let v124 : string = "useContext"
    let v125 : string = "solid-js"
    let v126 : JS.Function = import v124 v125
    let struct (v127 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v128 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v129 : (unit -> int32), v130 : (int32 -> unit), v131 : (unit -> string), v132 : (string -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v136 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v137 : (unit -> (struct (US2 * (int32 [])) [])), v138 : ((struct (US2 * (int32 [])) []) -> unit), v139 : (unit -> (struct (int32 * obj) [])), v140 : ((struct (int32 * obj) []) -> unit), v141 : (unit -> (struct (int32 * obj) [])), v142 : ((struct (int32 * obj) []) -> unit), v143 : (unit -> (struct (int32 * int32) [])), v144 : ((struct (int32 * int32) []) -> unit), v145 : (unit -> US4), v146 : (US4 -> unit), v147 : (unit -> US5), v148 : (US5 -> unit)) = v126.Invoke v123 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v149 : string = "profile/tmp/counter"
    let v150 : (struct (int32 * int32) []) = v143 ()
    let v151 : (unit -> (unit -> ((struct (int32 * int32) []) -> unit))) = closure247(v144)
    let v152 : (obj -> int32) = closure250(v143)
    let struct (v153 : (unit -> unit), v154 : (unit -> unit)) = method48(v149, v150)
    let v155 : US14 = US14_0
    let v156 : US14 = US14_0
    let v157 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure255(v143, v154, v153)
    let v158 : US15 = US15_2
    let v159 : Mut4 = {l0 = v155; l1 = v156; l2 = v157; l3 = v158} : Mut4
    let v160 : string = "createComponent"
    let v161 : JS.Function = import v160 v125
    let v162 : (Mut4 -> JSX.Element) = closure16()
    let v163 : JSX.Element = v161.Invoke (v162, v159) |> unbox<JSX.Element>
    v163
and closure246 () (v0 : Mut1) : JSX.Element =
    method46()
and closure270 () () : (JSX.Element []) =
    [||]
and closure274 (v0 : ((struct (int32 * obj) []) -> unit)) (v1 : (struct (int32 * obj) [])) : unit =
    v0 v1
    ()
and closure273 (v0 : ((struct (int32 * obj) []) -> unit)) () : ((struct (int32 * obj) []) -> unit) =
    closure274(v0)
and closure272 (v0 : ((struct (int32 * obj) []) -> unit)) () : (unit -> ((struct (int32 * obj) []) -> unit)) =
    closure273(v0)
and closure275 () (v0 : obj) : obj =
    let v1 : obj = "status"
    v1
and closure276 (v0 : string, v1 : (struct (int32 * obj) []), v2 : (unit -> unit), v3 : (unit -> unit), v4 : (unit -> unit), v5 : (unit -> unit)) () : (obj []) =
    let v6 : string = "content_address:"
    let v7 : obj = struct (v6, v0)
    let v8 : string = "proxy:"
    let v9 : obj = struct (v8, v1)
    let v10 : string = "events:"
    let v11 : obj = struct (v10, v2)
    let v12 : string = "timers:"
    let v13 : obj = struct (v12, v3)
    let v14 : string = "values:"
    let v15 : obj = struct (v14, v4)
    let v16 : string = "subscriptions:"
    let v17 : obj = struct (v16, v5)
    [|v7; v9; v11; v13; v15; v17|]
and method55 (v0 : string, v1 : (struct (int32 * obj) [])) : struct ((unit -> unit) * (unit -> unit)) =
    let v2 : string = "createSignal"
    let v3 : string = "solid-js"
    let v4 : JS.Function = import v2 v3
    let v5 : (JS.Function []) = v4.Invoke () |> unbox<JS.Function[]>
    let v6 : (unit -> unit) = v5.[0] |> unbox
    let v7 : (unit -> unit) = v5.[1] |> unbox
    let v8 : JS.Function = import v2 v3
    let v9 : (JS.Function []) = v8.Invoke () |> unbox<JS.Function[]>
    let v10 : (unit -> unit) = v9.[0] |> unbox
    let v11 : (unit -> unit) = v9.[1] |> unbox
    let v12 : JS.Function = import v2 v3
    let v13 : (JS.Function []) = v12.Invoke () |> unbox<JS.Function[]>
    let v14 : (unit -> unit) = v13.[0] |> unbox
    let v15 : (unit -> unit) = v13.[1] |> unbox
    let v16 : JS.Function = import v2 v3
    let v17 : (JS.Function []) = v16.Invoke () |> unbox<JS.Function[]>
    let v18 : (unit -> unit) = v17.[0] |> unbox
    let v19 : (unit -> unit) = v17.[1] |> unbox
    let v20 : (uint8 []) = System.Text.Encoding.UTF8.GetBytes v0
    let v21 : int32 = v20.Length
    let v22 : Mut23 = {l0 = 0; l1 = 100000} : Mut23
    while method47(v21, v22) do
        let v24 : int32 = v22.l0
        let v25 : int32 = v22.l1
        let v26 : uint8 = v20.[int v24]
        let v27 : int32 = v26 |> unbox<int32>
        let v28 : int32 = v27 * 14
        let v29 : int32 = v25 + v28
        let v30 : int32 = v24 + 1
        v22.l0 <- v30
        v22.l1 <- v29
        ()
    let v31 : int32 = v22.l1
    let v32 : string = v31.ToString ()
    let v33 : string = $"#{v32}"
    let v34 : (unit -> (obj [])) = closure276(v0, v1, v6, v10, v14, v18)
    let v35 : (US4 -> ((obj []) -> unit)) = method14(v34, v33)
    let v36 : US4 = US4_0
    let v37 : ((obj []) -> unit) = v35 v36
    let v38 : string = "> use_fetch ()"
    let v39 : obj = v38
    let v40 : (obj []) = [|v39|]
    v37 v40
    let v41 : (unit -> unit) = closure252(v0, v35)
    method18(v41)
    let v42 : (unit -> unit) = closure253(v35)
    let v43 : (unit -> unit) = closure254(v35)
    struct (v42, v43)
and closure279 () () : (JSX.Element []) =
    let v0 : string = "Chain Status"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure280 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v70, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure281 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure282 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v70, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure283 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure278 (v0 : (unit -> unit), v1 : (unit -> unit)) () : (JSX.Element []) =
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let struct (v5 : US6, v6 : US6, v7 : US6, v8 : US7, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US8, v16 : US9, v17 : US6, v18 : US6, v19 : US8, v20 : US10, v21 : US6, v22 : US6, v23 : US6, v24 : US11, v25 : US8, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US12, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US13, v48 : US14, v49 : US13, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US12, v68 : US6, v69 : US6, v70 : US10, v71 : US10, v72 : US6, v73 : US5, v74 : US6) = method3()
    let v82 : US9 =
        match v16 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v76) -> (* Some *)
            let v77 : string = "children"
            let v78 : string = "solid-js"
            let v79 : JS.Function = import v77 v78
            let v80 : (unit -> (JSX.Element [])) = v79.Invoke v76 |> unbox<unit -> JSX.Element[]>
            US9_1(v80)
    let v85 : (unit -> (JSX.Element [])) =
        match v82 with
        | US9_0 -> (* None *)
            closure279()
        | US9_1(v84) -> (* Some *)
            v84
    let v86 : US9 = US9_1(v85)
    let v87 : ((string * obj) []) = method7(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v86, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74)
    let v88 : obj = createObj v87
    let v89 : (unit -> (JSX.Element [])) = closure279()
    emitJsExpr (v88, v89) "$0.children = $1"
    let v90 : (obj -> JSX.Element) = v4 |> unbox<(obj -> JSX.Element)>
    let v91 : string = "createComponent"
    let v92 : string = "solid-js"
    let v93 : JS.Function = import v91 v92
    let v94 : JSX.Element = v93.Invoke (v90, v88) |> unbox<JSX.Element>
    let struct (v95 : US6, v96 : US6, v97 : US6, v98 : US7, v99 : US6, v100 : US6, v101 : US6, v102 : US6, v103 : US6, v104 : US6, v105 : US8, v106 : US9, v107 : US6, v108 : US6, v109 : US8, v110 : US10, v111 : US6, v112 : US6, v113 : US6, v114 : US11, v115 : US8, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US12, v123 : US6, v124 : US6, v125 : US6, v126 : US12, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US6, v135 : US6, v136 : US6, v137 : US13, v138 : US14, v139 : US13, v140 : US6, v141 : US6, v142 : US6, v143 : US6, v144 : US6, v145 : US6, v146 : US6, v147 : US6, v148 : US6, v149 : US6, v150 : US6, v151 : US6, v152 : US6, v153 : US6, v154 : US6, v155 : US6, v156 : US6, v157 : US12, v158 : US6, v159 : US6, v160 : US10, v161 : US10, v162 : US6, v163 : US5, v164 : US6) = method3()
    let v165 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure280()
    let v166 : (unit -> JS.Function) = closure259()
    let v167 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure45()
    let v168 : Mut7 = {l0 = v165; l1 = v166; l2 = v167} : Mut7
    let v169 : JS.Function = import v91 v92
    let v170 : (Mut7 -> JSX.Element) = closure47()
    let v171 : JSX.Element = v169.Invoke (v170, v168) |> unbox<JSX.Element>
    let v178 : US9 =
        match v106 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v173) -> (* Some *)
            let v174 : string = "children"
            let v175 : JS.Function = import v174 v92
            let v176 : (unit -> (JSX.Element [])) = v175.Invoke v173 |> unbox<unit -> JSX.Element[]>
            US9_1(v176)
    let v181 : (unit -> (JSX.Element [])) =
        match v178 with
        | US9_0 -> (* None *)
            closure281()
        | US9_1(v180) -> (* Some *)
            v180
    let v182 : US9 = US9_1(v181)
    let v183 : US12 = US12_1(v171)
    let v184 : US14 = US14_1(v1)
    let v185 : string = "10px"
    let v186 : US6 = US6_1(v185)
    let v187 : Mut1 = {l0 = v95; l1 = v96; l2 = v97; l3 = v98; l4 = v99; l5 = v100; l6 = v101; l7 = v102; l8 = v103; l9 = v104; l10 = v105; l11 = v182; l12 = v107; l13 = v108; l14 = v109; l15 = v110; l16 = v111; l17 = v112; l18 = v113; l19 = v114; l20 = v115; l21 = v116; l22 = v117; l23 = v118; l24 = v119; l25 = v120; l26 = v121; l27 = v122; l28 = v123; l29 = v124; l30 = v125; l31 = v183; l32 = v127; l33 = v128; l34 = v129; l35 = v130; l36 = v131; l37 = v132; l38 = v133; l39 = v134; l40 = v135; l41 = v136; l42 = v137; l43 = v184; l44 = v139; l45 = v140; l46 = v141; l47 = v142; l48 = v143; l49 = v144; l50 = v145; l51 = v146; l52 = v186; l53 = v148; l54 = v149; l55 = v150; l56 = v151; l57 = v152; l58 = v153; l59 = v154; l60 = v155; l61 = v156; l62 = v157; l63 = v158; l64 = v159; l65 = v160; l66 = v161; l67 = v162; l68 = v163; l69 = v164} : Mut1
    let v188 : (unit -> (JSX.Element [])) = closure281()
    emitJsExpr (v187, v188) "$0.children = $1"
    let v189 : JS.Function = import v91 v92
    let v190 : (Mut1 -> JSX.Element) = closure40()
    let v191 : JSX.Element = v189.Invoke (v190, v187) |> unbox<JSX.Element>
    let struct (v192 : US6, v193 : US6, v194 : US6, v195 : US7, v196 : US6, v197 : US6, v198 : US6, v199 : US6, v200 : US6, v201 : US6, v202 : US8, v203 : US9, v204 : US6, v205 : US6, v206 : US8, v207 : US10, v208 : US6, v209 : US6, v210 : US6, v211 : US11, v212 : US8, v213 : US6, v214 : US6, v215 : US6, v216 : US6, v217 : US6, v218 : US6, v219 : US12, v220 : US6, v221 : US6, v222 : US6, v223 : US12, v224 : US6, v225 : US6, v226 : US6, v227 : US6, v228 : US6, v229 : US6, v230 : US6, v231 : US6, v232 : US6, v233 : US6, v234 : US13, v235 : US14, v236 : US13, v237 : US6, v238 : US6, v239 : US6, v240 : US6, v241 : US6, v242 : US6, v243 : US6, v244 : US6, v245 : US6, v246 : US6, v247 : US6, v248 : US6, v249 : US6, v250 : US6, v251 : US6, v252 : US6, v253 : US6, v254 : US12, v255 : US6, v256 : US6, v257 : US10, v258 : US10, v259 : US6, v260 : US5, v261 : US6) = method3()
    let v262 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure282()
    let v263 : (unit -> JS.Function) = closure262()
    let v264 : Mut7 = {l0 = v262; l1 = v263; l2 = v167} : Mut7
    let v265 : JS.Function = import v91 v92
    let v266 : JSX.Element = v265.Invoke (v170, v264) |> unbox<JSX.Element>
    let v273 : US9 =
        match v203 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v268) -> (* Some *)
            let v269 : string = "children"
            let v270 : JS.Function = import v269 v92
            let v271 : (unit -> (JSX.Element [])) = v270.Invoke v268 |> unbox<unit -> JSX.Element[]>
            US9_1(v271)
    let v276 : (unit -> (JSX.Element [])) =
        match v273 with
        | US9_0 -> (* None *)
            closure283()
        | US9_1(v275) -> (* Some *)
            v275
    let v277 : US9 = US9_1(v276)
    let v278 : US12 = US12_1(v266)
    let v279 : US14 = US14_1(v0)
    let v280 : US6 = US6_1(v185)
    let v281 : Mut1 = {l0 = v192; l1 = v193; l2 = v194; l3 = v195; l4 = v196; l5 = v197; l6 = v198; l7 = v199; l8 = v200; l9 = v201; l10 = v202; l11 = v277; l12 = v204; l13 = v205; l14 = v206; l15 = v207; l16 = v208; l17 = v209; l18 = v210; l19 = v211; l20 = v212; l21 = v213; l22 = v214; l23 = v215; l24 = v216; l25 = v217; l26 = v218; l27 = v219; l28 = v220; l29 = v221; l30 = v222; l31 = v278; l32 = v224; l33 = v225; l34 = v226; l35 = v227; l36 = v228; l37 = v229; l38 = v230; l39 = v231; l40 = v232; l41 = v233; l42 = v234; l43 = v279; l44 = v236; l45 = v237; l46 = v238; l47 = v239; l48 = v240; l49 = v241; l50 = v242; l51 = v243; l52 = v280; l53 = v245; l54 = v246; l55 = v247; l56 = v248; l57 = v249; l58 = v250; l59 = v251; l60 = v252; l61 = v253; l62 = v254; l63 = v255; l64 = v256; l65 = v257; l66 = v258; l67 = v259; l68 = v260; l69 = v261} : Mut1
    let v282 : (unit -> (JSX.Element [])) = closure283()
    emitJsExpr (v281, v282) "$0.children = $1"
    let v283 : JS.Function = import v91 v92
    let v284 : JSX.Element = v283.Invoke (v190, v281) |> unbox<JSX.Element>
    [|v94; v191; v284|]
and method56 (v0 : int32, v1 : Mut25) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method57 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH2 = UH2_0(v2, v3, v1)
        method57(v4, v5)
    | UH2_1 -> (* Nil *)
        v1
and method59 (v0 : UH2, v1 : int32) : int32 =
    match v0 with
    | UH2_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method59(v4, v5)
    | UH2_1 -> (* Nil *)
        v1
and method60 (v0 : (struct (int32 * obj) []), v1 : UH2, v2 : int32) : int32 =
    match v1 with
    | UH2_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method60(v0, v5, v6)
    | UH2_1 -> (* Nil *)
        v2
and method58 (v0 : UH2) : (struct (int32 * obj) []) =
    let v1 : int32 = 0
    let v2 : int32 = method59(v0, v1)
    let v3 : (struct (int32 * obj) []) = Array.zeroCreate<struct (int32 * obj)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method60(v3, v0, v4)
    v3
and closure289 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : obj) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = v3 |> unbox<JSX.Element>
    let v5 : JSX.Element = Html.fragment [ v4 ]
    [|v5|]
and closure288 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US6, v6 : US6, v7 : US6, v8 : US7, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US8, v16 : US9, v17 : US6, v18 : US6, v19 : US8, v20 : US10, v21 : US6, v22 : US6, v23 : US6, v24 : US11, v25 : US8, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US12, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US13, v48 : US14, v49 : US13, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US12, v68 : US6, v69 : US6, v70 : US10, v71 : US10, v72 : US6, v73 : US5, v74 : US6) = method3()
    let v82 : US9 =
        match v16 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v76) -> (* Some *)
            let v77 : string = "children"
            let v78 : string = "solid-js"
            let v79 : JS.Function = import v77 v78
            let v80 : (unit -> (JSX.Element [])) = v79.Invoke v76 |> unbox<unit -> JSX.Element[]>
            US9_1(v80)
    let v85 : (unit -> (JSX.Element [])) =
        match v82 with
        | US9_0 -> (* None *)
            closure289(v0)
        | US9_1(v84) -> (* Some *)
            v84
    let v86 : US9 = US9_1(v85)
    let v87 : ((string * obj) []) = method7(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v86, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74)
    let v88 : obj = createObj v87
    let v89 : (unit -> (JSX.Element [])) = closure289(v0)
    emitJsExpr (v88, v89) "$0.children = $1"
    let v90 : (obj -> JSX.Element) = v4 |> unbox<(obj -> JSX.Element)>
    let v91 : string = "createComponent"
    let v92 : string = "solid-js"
    let v93 : JS.Function = import v91 v92
    let v94 : JSX.Element = v93.Invoke (v90, v88) |> unbox<JSX.Element>
    [|v94|]
and closure287 (v0 : (unit -> struct (int32 * obj))) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let struct (v71 : int32, v72 : obj) = v0 ()
    let v73 : string = v71.ToString ()
    let v74 : JSX.Element = v73 |> unbox<JSX.Element>
    let v75 : JSX.Element = Html.fragment [ v74 ]
    let v76 : (unit -> (JSX.Element [])) = closure288(v0)
    let v77 : US9 = US9_1(v76)
    let v78 : string = "3px"
    let v79 : US6 = US6_1(v78)
    let v80 : US12 = US12_1(v75)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v77, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v79, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v80, v64, v65, v66, v67, v68, v69, v70)
and closure286 () (v0 : (unit -> struct (int32 * obj))) : (JSX.Element []) =
    let v1 : US14 = US14_0
    let v2 : US14 = US14_0
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure287(v0)
    let v4 : US15 = US15_2
    let v5 : Mut4 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4} : Mut4
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : (Mut4 -> JSX.Element) = closure16()
    let v10 : JSX.Element = v8.Invoke (v9, v5) |> unbox<JSX.Element>
    [|v10|]
and closure285 (v0 : (unit -> (struct (int32 * obj) []))) () : (JSX.Element []) =
    let v1 : (struct (int32 * obj) []) = v0 ()
    let v2 : int32 = v1.Length
    let v3 : UH2 = UH2_1
    let v4 : Mut25 = {l0 = 0; l1 = v3} : Mut25
    while method56(v2, v4) do
        let v6 : int32 = v4.l0
        let v7 : int32 =  -v6
        let v8 : int32 = v7 + v2
        let v9 : int32 = v8 - 1
        let v10 : UH2 = v4.l1
        let struct (v11 : int32, v12 : obj) = v1.[int v9]
        let v13 : int32 = v6 + 1
        let v14 : UH2 = UH2_0(v11, v12, v10)
        v4.l0 <- v13
        v4.l1 <- v14
        ()
    let v15 : UH2 = v4.l1
    let v16 : UH2 = UH2_1
    let v17 : UH2 = method57(v15, v16)
    let v18 : (struct (int32 * obj) []) = method58(v17)
    let v19 : string = "Index"
    let v20 : string = "solid-js"
    let v21 : JS.Function = import v19 v20
    let v22 : ((unit -> struct (int32 * obj)) -> (JSX.Element [])) = closure286()
    let v23 : (unit -> (JSX.Element [])) = v22 |> unbox
    let struct (v24 : US6, v25 : US6, v26 : US6, v27 : US7, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US8, v35 : US9, v36 : US6, v37 : US6, v38 : US8, v39 : US10, v40 : US6, v41 : US6, v42 : US6, v43 : US11, v44 : US8, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US12, v52 : US6, v53 : US6, v54 : US6, v55 : US12, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US13, v67 : US14, v68 : US13, v69 : US6, v70 : US6, v71 : US6, v72 : US6, v73 : US6, v74 : US6, v75 : US6, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US6, v83 : US6, v84 : US6, v85 : US6, v86 : US12, v87 : US6, v88 : US6, v89 : US10, v90 : US10, v91 : US6, v92 : US5, v93 : US6) = method3()
    let v94 : (obj []) = v18 |> unbox<obj[]>
    let v101 : US9 =
        match v35 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v96) -> (* Some *)
            let v97 : string = "children"
            let v98 : JS.Function = import v97 v20
            let v99 : (unit -> (JSX.Element [])) = v98.Invoke v96 |> unbox<unit -> JSX.Element[]>
            US9_1(v99)
    let v103 : (unit -> (JSX.Element [])) =
        match v101 with
        | US9_0 -> (* None *)
            v23
        | US9_1(v102) -> (* Some *)
            v102
    let v104 : US9 = US9_1(v103)
    let v105 : US11 = US11_1(v94)
    let v106 : ((string * obj) []) = method7(v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v104, v36, v37, v38, v39, v40, v41, v42, v105, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93)
    let v107 : obj = createObj v106
    emitJsExpr (v107, v23) "$0.children = $1"
    let v108 : (obj -> JSX.Element) = v21 |> unbox<(obj -> JSX.Element)>
    let v109 : string = "createComponent"
    let v110 : JS.Function = import v109 v20
    let v111 : JSX.Element = v110.Invoke (v108, v107) |> unbox<JSX.Element>
    [|v111|]
and closure284 (v0 : (unit -> (struct (int32 * obj) []))) () : (JSX.Element []) =
    let struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) = method3()
    let v78 : US9 =
        match v12 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v72) -> (* Some *)
            let v73 : string = "children"
            let v74 : string = "solid-js"
            let v75 : JS.Function = import v73 v74
            let v76 : (unit -> (JSX.Element [])) = v75.Invoke v72 |> unbox<unit -> JSX.Element[]>
            US9_1(v76)
    let v81 : (unit -> (JSX.Element [])) =
        match v78 with
        | US9_0 -> (* None *)
            closure285(v0)
        | US9_1(v80) -> (* Some *)
            v80
    let v82 : US9 = US9_1(v81)
    let v83 : Mut1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v82; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63; l63 = v64; l64 = v65; l65 = v66; l66 = v67; l67 = v68; l68 = v69; l69 = v70} : Mut1
    let v84 : (unit -> (JSX.Element [])) = closure285(v0)
    emitJsExpr (v83, v84) "$0.children = $1"
    let v85 : string = "createComponent"
    let v86 : string = "solid-js"
    let v87 : JS.Function = import v85 v86
    let v88 : (Mut1 -> JSX.Element) = closure111()
    let v89 : JSX.Element = v87.Invoke (v88, v83) |> unbox<JSX.Element>
    [|v89|]
and closure277 (v0 : (unit -> (struct (int32 * obj) [])), v1 : (unit -> unit), v2 : (unit -> unit)) struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US10, v19 : US6, v20 : US6, v21 : US6, v22 : US11, v23 : US8, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US12, v31 : US6, v32 : US6, v33 : US6, v34 : US12, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US13, v46 : US14, v47 : US13, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US12, v66 : US6, v67 : US6, v68 : US10, v69 : US10, v70 : US6, v71 : US5, v72 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v73 : string = "Stack"
    let v74 : string = "@hope-ui/solid"
    let v75 : JS.Function = import v73 v74
    let struct (v76 : US6, v77 : US6, v78 : US6, v79 : US7, v80 : US6, v81 : US6, v82 : US6, v83 : US6, v84 : US6, v85 : US6, v86 : US8, v87 : US9, v88 : US6, v89 : US6, v90 : US8, v91 : US10, v92 : US6, v93 : US6, v94 : US6, v95 : US11, v96 : US8, v97 : US6, v98 : US6, v99 : US6, v100 : US6, v101 : US6, v102 : US6, v103 : US12, v104 : US6, v105 : US6, v106 : US6, v107 : US12, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US6, v115 : US6, v116 : US6, v117 : US6, v118 : US13, v119 : US14, v120 : US13, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US6, v135 : US6, v136 : US6, v137 : US6, v138 : US12, v139 : US6, v140 : US6, v141 : US10, v142 : US10, v143 : US6, v144 : US5, v145 : US6) = method3()
    let v146 : string = "row"
    let v147 : string = "column"
    let v148 : string = method12(v147, v146)
    let v149 : string = "0"
    let v150 : string = "8px"
    let v151 : string = method12(v150, v149)
    let v159 : US9 =
        match v87 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v153) -> (* Some *)
            let v154 : string = "children"
            let v155 : string = "solid-js"
            let v156 : JS.Function = import v154 v155
            let v157 : (unit -> (JSX.Element [])) = v156.Invoke v153 |> unbox<unit -> JSX.Element[]>
            US9_1(v157)
    let v162 : (unit -> (JSX.Element [])) =
        match v159 with
        | US9_0 -> (* None *)
            closure278(v1, v2)
        | US9_1(v161) -> (* Some *)
            v161
    let v163 : string = "start"
    let v164 : US6 = US6_1(v163)
    let v165 : US9 = US9_1(v162)
    let v166 : US6 = US6_1(v148)
    let v167 : US6 = US6_1(v151)
    let v168 : string = "3px"
    let v169 : US6 = US6_1(v168)
    let v170 : string = "7px"
    let v171 : US6 = US6_1(v170)
    let v172 : ((string * obj) []) = method7(v164, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v165, v88, v89, v90, v91, v92, v166, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v167, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v169, v126, v127, v128, v129, v130, v131, v132, v133, v171, v135, v136, v137, v138, v139, v140, v141, v142, v143, v144, v145)
    let v173 : obj = createObj v172
    let v174 : (unit -> (JSX.Element [])) = closure278(v1, v2)
    emitJsExpr (v173, v174) "$0.children = $1"
    let v175 : (obj -> JSX.Element) = v75 |> unbox<(obj -> JSX.Element)>
    let v176 : string = "createComponent"
    let v177 : string = "solid-js"
    let v178 : JS.Function = import v176 v177
    let v179 : JSX.Element = v178.Invoke (v175, v173) |> unbox<JSX.Element>
    let v180 : (unit -> (JSX.Element [])) = closure284(v0)
    let v181 : US9 = US9_1(v180)
    let v182 : string = "status"
    let v183 : US6 = US6_1(v182)
    let v184 : US12 = US12_1(v179)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v181, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v183, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v184, v66, v67, v68, v69, v70, v71, v72)
and method54 () : JSX.Element =
    let v123 : obj = emitJsExpr () "components_spi.state_context"
    let v124 : string = "useContext"
    let v125 : string = "solid-js"
    let v126 : JS.Function = import v124 v125
    let struct (v127 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v128 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v129 : (unit -> int32), v130 : (int32 -> unit), v131 : (unit -> string), v132 : (string -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v136 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v137 : (unit -> (struct (US2 * (int32 [])) [])), v138 : ((struct (US2 * (int32 [])) []) -> unit), v139 : (unit -> (struct (int32 * obj) [])), v140 : ((struct (int32 * obj) []) -> unit), v141 : (unit -> (struct (int32 * obj) [])), v142 : ((struct (int32 * obj) []) -> unit), v143 : (unit -> (struct (int32 * int32) [])), v144 : ((struct (int32 * int32) []) -> unit), v145 : (unit -> US4), v146 : (US4 -> unit), v147 : (unit -> US5), v148 : (US5 -> unit)) = v126.Invoke v123 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v149 : string = "profile/tmp/chain_status"
    let v150 : (struct (int32 * obj) []) = v141 ()
    let v151 : (unit -> (unit -> ((struct (int32 * obj) []) -> unit))) = closure272(v142)
    let v152 : (obj -> obj) = closure275()
    let struct (v153 : (unit -> unit), v154 : (unit -> unit)) = method55(v149, v150)
    let v155 : US14 = US14_0
    let v156 : US14 = US14_0
    let v157 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure277(v141, v154, v153)
    let v158 : US15 = US15_2
    let v159 : Mut4 = {l0 = v155; l1 = v156; l2 = v157; l3 = v158} : Mut4
    let v160 : string = "createComponent"
    let v161 : JS.Function = import v160 v125
    let v162 : (Mut4 -> JSX.Element) = closure16()
    let v163 : JSX.Element = v161.Invoke (v162, v159) |> unbox<JSX.Element>
    v163
and closure271 () (v0 : Mut1) : JSX.Element =
    method54()
and closure290 () () : (JSX.Element []) =
    [||]
and closure294 (v0 : ((struct (int32 * obj) []) -> unit)) (v1 : (struct (int32 * obj) [])) : unit =
    v0 v1
    ()
and closure293 (v0 : ((struct (int32 * obj) []) -> unit)) () : ((struct (int32 * obj) []) -> unit) =
    closure294(v0)
and closure292 (v0 : ((struct (int32 * obj) []) -> unit)) () : (unit -> ((struct (int32 * obj) []) -> unit)) =
    closure293(v0)
and closure295 () (v0 : obj) : obj =
    let v1 : obj = ()
    v1
and closure298 () () : (JSX.Element []) =
    let v0 : string = "Chain Deploy"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure299 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v70, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure300 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure301 () struct (v0 : US6, v1 : US6, v2 : US6, v3 : US7, v4 : US6, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US8, v11 : US9, v12 : US6, v13 : US6, v14 : US8, v15 : US10, v16 : US6, v17 : US6, v18 : US6, v19 : US11, v20 : US8, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US12, v28 : US6, v29 : US6, v30 : US6, v31 : US12, v32 : US6, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US13, v43 : US14, v44 : US13, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US12, v63 : US6, v64 : US6, v65 : US10, v66 : US10, v67 : US6, v68 : US5, v69 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v70 : US6 = US6_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v70, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
and closure302 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = v0 |> unbox<JSX.Element>
    let v2 : JSX.Element = Html.fragment [ v1 ]
    [|v2|]
and closure297 (v0 : (unit -> unit), v1 : (unit -> unit)) () : (JSX.Element []) =
    let v2 : string = "Box"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let struct (v5 : US6, v6 : US6, v7 : US6, v8 : US7, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US8, v16 : US9, v17 : US6, v18 : US6, v19 : US8, v20 : US10, v21 : US6, v22 : US6, v23 : US6, v24 : US11, v25 : US8, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US12, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US13, v48 : US14, v49 : US13, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US12, v68 : US6, v69 : US6, v70 : US10, v71 : US10, v72 : US6, v73 : US5, v74 : US6) = method3()
    let v82 : US9 =
        match v16 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v76) -> (* Some *)
            let v77 : string = "children"
            let v78 : string = "solid-js"
            let v79 : JS.Function = import v77 v78
            let v80 : (unit -> (JSX.Element [])) = v79.Invoke v76 |> unbox<unit -> JSX.Element[]>
            US9_1(v80)
    let v85 : (unit -> (JSX.Element [])) =
        match v82 with
        | US9_0 -> (* None *)
            closure298()
        | US9_1(v84) -> (* Some *)
            v84
    let v86 : US9 = US9_1(v85)
    let v87 : ((string * obj) []) = method7(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v86, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74)
    let v88 : obj = createObj v87
    let v89 : (unit -> (JSX.Element [])) = closure298()
    emitJsExpr (v88, v89) "$0.children = $1"
    let v90 : (obj -> JSX.Element) = v4 |> unbox<(obj -> JSX.Element)>
    let v91 : string = "createComponent"
    let v92 : string = "solid-js"
    let v93 : JS.Function = import v91 v92
    let v94 : JSX.Element = v93.Invoke (v90, v88) |> unbox<JSX.Element>
    let struct (v95 : US6, v96 : US6, v97 : US6, v98 : US7, v99 : US6, v100 : US6, v101 : US6, v102 : US6, v103 : US6, v104 : US6, v105 : US8, v106 : US9, v107 : US6, v108 : US6, v109 : US8, v110 : US10, v111 : US6, v112 : US6, v113 : US6, v114 : US11, v115 : US8, v116 : US6, v117 : US6, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US12, v123 : US6, v124 : US6, v125 : US6, v126 : US12, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US6, v135 : US6, v136 : US6, v137 : US13, v138 : US14, v139 : US13, v140 : US6, v141 : US6, v142 : US6, v143 : US6, v144 : US6, v145 : US6, v146 : US6, v147 : US6, v148 : US6, v149 : US6, v150 : US6, v151 : US6, v152 : US6, v153 : US6, v154 : US6, v155 : US6, v156 : US6, v157 : US12, v158 : US6, v159 : US6, v160 : US10, v161 : US10, v162 : US6, v163 : US5, v164 : US6) = method3()
    let v165 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure299()
    let v166 : (unit -> JS.Function) = closure259()
    let v167 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure45()
    let v168 : Mut7 = {l0 = v165; l1 = v166; l2 = v167} : Mut7
    let v169 : JS.Function = import v91 v92
    let v170 : (Mut7 -> JSX.Element) = closure47()
    let v171 : JSX.Element = v169.Invoke (v170, v168) |> unbox<JSX.Element>
    let v178 : US9 =
        match v106 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v173) -> (* Some *)
            let v174 : string = "children"
            let v175 : JS.Function = import v174 v92
            let v176 : (unit -> (JSX.Element [])) = v175.Invoke v173 |> unbox<unit -> JSX.Element[]>
            US9_1(v176)
    let v181 : (unit -> (JSX.Element [])) =
        match v178 with
        | US9_0 -> (* None *)
            closure300()
        | US9_1(v180) -> (* Some *)
            v180
    let v182 : US9 = US9_1(v181)
    let v183 : US12 = US12_1(v171)
    let v184 : US14 = US14_1(v1)
    let v185 : string = "10px"
    let v186 : US6 = US6_1(v185)
    let v187 : Mut1 = {l0 = v95; l1 = v96; l2 = v97; l3 = v98; l4 = v99; l5 = v100; l6 = v101; l7 = v102; l8 = v103; l9 = v104; l10 = v105; l11 = v182; l12 = v107; l13 = v108; l14 = v109; l15 = v110; l16 = v111; l17 = v112; l18 = v113; l19 = v114; l20 = v115; l21 = v116; l22 = v117; l23 = v118; l24 = v119; l25 = v120; l26 = v121; l27 = v122; l28 = v123; l29 = v124; l30 = v125; l31 = v183; l32 = v127; l33 = v128; l34 = v129; l35 = v130; l36 = v131; l37 = v132; l38 = v133; l39 = v134; l40 = v135; l41 = v136; l42 = v137; l43 = v184; l44 = v139; l45 = v140; l46 = v141; l47 = v142; l48 = v143; l49 = v144; l50 = v145; l51 = v146; l52 = v186; l53 = v148; l54 = v149; l55 = v150; l56 = v151; l57 = v152; l58 = v153; l59 = v154; l60 = v155; l61 = v156; l62 = v157; l63 = v158; l64 = v159; l65 = v160; l66 = v161; l67 = v162; l68 = v163; l69 = v164} : Mut1
    let v188 : (unit -> (JSX.Element [])) = closure300()
    emitJsExpr (v187, v188) "$0.children = $1"
    let v189 : JS.Function = import v91 v92
    let v190 : (Mut1 -> JSX.Element) = closure40()
    let v191 : JSX.Element = v189.Invoke (v190, v187) |> unbox<JSX.Element>
    let struct (v192 : US6, v193 : US6, v194 : US6, v195 : US7, v196 : US6, v197 : US6, v198 : US6, v199 : US6, v200 : US6, v201 : US6, v202 : US8, v203 : US9, v204 : US6, v205 : US6, v206 : US8, v207 : US10, v208 : US6, v209 : US6, v210 : US6, v211 : US11, v212 : US8, v213 : US6, v214 : US6, v215 : US6, v216 : US6, v217 : US6, v218 : US6, v219 : US12, v220 : US6, v221 : US6, v222 : US6, v223 : US12, v224 : US6, v225 : US6, v226 : US6, v227 : US6, v228 : US6, v229 : US6, v230 : US6, v231 : US6, v232 : US6, v233 : US6, v234 : US13, v235 : US14, v236 : US13, v237 : US6, v238 : US6, v239 : US6, v240 : US6, v241 : US6, v242 : US6, v243 : US6, v244 : US6, v245 : US6, v246 : US6, v247 : US6, v248 : US6, v249 : US6, v250 : US6, v251 : US6, v252 : US6, v253 : US6, v254 : US12, v255 : US6, v256 : US6, v257 : US10, v258 : US10, v259 : US6, v260 : US5, v261 : US6) = method3()
    let v262 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure301()
    let v263 : (unit -> JS.Function) = closure262()
    let v264 : Mut7 = {l0 = v262; l1 = v263; l2 = v167} : Mut7
    let v265 : JS.Function = import v91 v92
    let v266 : JSX.Element = v265.Invoke (v170, v264) |> unbox<JSX.Element>
    let v273 : US9 =
        match v203 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v268) -> (* Some *)
            let v269 : string = "children"
            let v270 : JS.Function = import v269 v92
            let v271 : (unit -> (JSX.Element [])) = v270.Invoke v268 |> unbox<unit -> JSX.Element[]>
            US9_1(v271)
    let v276 : (unit -> (JSX.Element [])) =
        match v273 with
        | US9_0 -> (* None *)
            closure302()
        | US9_1(v275) -> (* Some *)
            v275
    let v277 : US9 = US9_1(v276)
    let v278 : US12 = US12_1(v266)
    let v279 : US14 = US14_1(v0)
    let v280 : US6 = US6_1(v185)
    let v281 : Mut1 = {l0 = v192; l1 = v193; l2 = v194; l3 = v195; l4 = v196; l5 = v197; l6 = v198; l7 = v199; l8 = v200; l9 = v201; l10 = v202; l11 = v277; l12 = v204; l13 = v205; l14 = v206; l15 = v207; l16 = v208; l17 = v209; l18 = v210; l19 = v211; l20 = v212; l21 = v213; l22 = v214; l23 = v215; l24 = v216; l25 = v217; l26 = v218; l27 = v219; l28 = v220; l29 = v221; l30 = v222; l31 = v278; l32 = v224; l33 = v225; l34 = v226; l35 = v227; l36 = v228; l37 = v229; l38 = v230; l39 = v231; l40 = v232; l41 = v233; l42 = v234; l43 = v279; l44 = v236; l45 = v237; l46 = v238; l47 = v239; l48 = v240; l49 = v241; l50 = v242; l51 = v243; l52 = v280; l53 = v245; l54 = v246; l55 = v247; l56 = v248; l57 = v249; l58 = v250; l59 = v251; l60 = v252; l61 = v253; l62 = v254; l63 = v255; l64 = v256; l65 = v257; l66 = v258; l67 = v259; l68 = v260; l69 = v261} : Mut1
    let v282 : (unit -> (JSX.Element [])) = closure302()
    emitJsExpr (v281, v282) "$0.children = $1"
    let v283 : JS.Function = import v91 v92
    let v284 : JSX.Element = v283.Invoke (v190, v281) |> unbox<JSX.Element>
    [|v94; v191; v284|]
and closure308 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : obj) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = v3 |> unbox<JSX.Element>
    let v5 : JSX.Element = Html.fragment [ v4 ]
    [|v5|]
and closure307 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US6, v6 : US6, v7 : US6, v8 : US7, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US8, v16 : US9, v17 : US6, v18 : US6, v19 : US8, v20 : US10, v21 : US6, v22 : US6, v23 : US6, v24 : US11, v25 : US8, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US12, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US13, v48 : US14, v49 : US13, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US12, v68 : US6, v69 : US6, v70 : US10, v71 : US10, v72 : US6, v73 : US5, v74 : US6) = method3()
    let v82 : US9 =
        match v16 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v76) -> (* Some *)
            let v77 : string = "children"
            let v78 : string = "solid-js"
            let v79 : JS.Function = import v77 v78
            let v80 : (unit -> (JSX.Element [])) = v79.Invoke v76 |> unbox<unit -> JSX.Element[]>
            US9_1(v80)
    let v85 : (unit -> (JSX.Element [])) =
        match v82 with
        | US9_0 -> (* None *)
            closure308(v0)
        | US9_1(v84) -> (* Some *)
            v84
    let v86 : US9 = US9_1(v85)
    let v87 : ((string * obj) []) = method7(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v86, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74)
    let v88 : obj = createObj v87
    let v89 : (unit -> (JSX.Element [])) = closure308(v0)
    emitJsExpr (v88, v89) "$0.children = $1"
    let v90 : (obj -> JSX.Element) = v4 |> unbox<(obj -> JSX.Element)>
    let v91 : string = "createComponent"
    let v92 : string = "solid-js"
    let v93 : JS.Function = import v91 v92
    let v94 : JSX.Element = v93.Invoke (v90, v88) |> unbox<JSX.Element>
    [|v94|]
and closure306 (v0 : (unit -> struct (int32 * obj))) struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let struct (v71 : int32, v72 : obj) = v0 ()
    let v73 : string = v71.ToString ()
    let v74 : JSX.Element = v73 |> unbox<JSX.Element>
    let v75 : JSX.Element = Html.fragment [ v74 ]
    let v76 : (unit -> (JSX.Element [])) = closure307(v0)
    let v77 : US9 = US9_1(v76)
    let v78 : string = "3px"
    let v79 : US6 = US6_1(v78)
    let v80 : US12 = US12_1(v75)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v77, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v79, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v80, v64, v65, v66, v67, v68, v69, v70)
and closure305 () (v0 : (unit -> struct (int32 * obj))) : (JSX.Element []) =
    let v1 : US14 = US14_0
    let v2 : US14 = US14_0
    let v3 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure306(v0)
    let v4 : US15 = US15_2
    let v5 : Mut4 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4} : Mut4
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : (Mut4 -> JSX.Element) = closure16()
    let v10 : JSX.Element = v8.Invoke (v9, v5) |> unbox<JSX.Element>
    [|v10|]
and closure304 (v0 : (unit -> (struct (int32 * obj) []))) () : (JSX.Element []) =
    let v1 : (struct (int32 * obj) []) = v0 ()
    let v2 : int32 = v1.Length
    let v3 : UH2 = UH2_1
    let v4 : Mut25 = {l0 = 0; l1 = v3} : Mut25
    while method56(v2, v4) do
        let v6 : int32 = v4.l0
        let v7 : int32 =  -v6
        let v8 : int32 = v7 + v2
        let v9 : int32 = v8 - 1
        let v10 : UH2 = v4.l1
        let struct (v11 : int32, v12 : obj) = v1.[int v9]
        let v13 : int32 = v6 + 1
        let v14 : UH2 = UH2_0(v11, v12, v10)
        v4.l0 <- v13
        v4.l1 <- v14
        ()
    let v15 : UH2 = v4.l1
    let v16 : UH2 = UH2_1
    let v17 : UH2 = method57(v15, v16)
    let v18 : (struct (int32 * obj) []) = method58(v17)
    let v19 : string = "Index"
    let v20 : string = "solid-js"
    let v21 : JS.Function = import v19 v20
    let v22 : ((unit -> struct (int32 * obj)) -> (JSX.Element [])) = closure305()
    let v23 : (unit -> (JSX.Element [])) = v22 |> unbox
    let struct (v24 : US6, v25 : US6, v26 : US6, v27 : US7, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US8, v35 : US9, v36 : US6, v37 : US6, v38 : US8, v39 : US10, v40 : US6, v41 : US6, v42 : US6, v43 : US11, v44 : US8, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US12, v52 : US6, v53 : US6, v54 : US6, v55 : US12, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US13, v67 : US14, v68 : US13, v69 : US6, v70 : US6, v71 : US6, v72 : US6, v73 : US6, v74 : US6, v75 : US6, v76 : US6, v77 : US6, v78 : US6, v79 : US6, v80 : US6, v81 : US6, v82 : US6, v83 : US6, v84 : US6, v85 : US6, v86 : US12, v87 : US6, v88 : US6, v89 : US10, v90 : US10, v91 : US6, v92 : US5, v93 : US6) = method3()
    let v94 : (obj []) = v18 |> unbox<obj[]>
    let v101 : US9 =
        match v35 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v96) -> (* Some *)
            let v97 : string = "children"
            let v98 : JS.Function = import v97 v20
            let v99 : (unit -> (JSX.Element [])) = v98.Invoke v96 |> unbox<unit -> JSX.Element[]>
            US9_1(v99)
    let v103 : (unit -> (JSX.Element [])) =
        match v101 with
        | US9_0 -> (* None *)
            v23
        | US9_1(v102) -> (* Some *)
            v102
    let v104 : US9 = US9_1(v103)
    let v105 : US11 = US11_1(v94)
    let v106 : ((string * obj) []) = method7(v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v104, v36, v37, v38, v39, v40, v41, v42, v105, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93)
    let v107 : obj = createObj v106
    emitJsExpr (v107, v23) "$0.children = $1"
    let v108 : (obj -> JSX.Element) = v21 |> unbox<(obj -> JSX.Element)>
    let v109 : string = "createComponent"
    let v110 : JS.Function = import v109 v20
    let v111 : JSX.Element = v110.Invoke (v108, v107) |> unbox<JSX.Element>
    [|v111|]
and closure303 (v0 : (unit -> (struct (int32 * obj) []))) () : (JSX.Element []) =
    let struct (v1 : US6, v2 : US6, v3 : US6, v4 : US7, v5 : US6, v6 : US6, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US8, v12 : US9, v13 : US6, v14 : US6, v15 : US8, v16 : US10, v17 : US6, v18 : US6, v19 : US6, v20 : US11, v21 : US8, v22 : US6, v23 : US6, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US12, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US13, v44 : US14, v45 : US13, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US12, v64 : US6, v65 : US6, v66 : US10, v67 : US10, v68 : US6, v69 : US5, v70 : US6) = method3()
    let v78 : US9 =
        match v12 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v72) -> (* Some *)
            let v73 : string = "children"
            let v74 : string = "solid-js"
            let v75 : JS.Function = import v73 v74
            let v76 : (unit -> (JSX.Element [])) = v75.Invoke v72 |> unbox<unit -> JSX.Element[]>
            US9_1(v76)
    let v81 : (unit -> (JSX.Element [])) =
        match v78 with
        | US9_0 -> (* None *)
            closure304(v0)
        | US9_1(v80) -> (* Some *)
            v80
    let v82 : US9 = US9_1(v81)
    let v83 : Mut1 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v82; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63; l63 = v64; l64 = v65; l65 = v66; l66 = v67; l67 = v68; l68 = v69; l69 = v70} : Mut1
    let v84 : (unit -> (JSX.Element [])) = closure304(v0)
    emitJsExpr (v83, v84) "$0.children = $1"
    let v85 : string = "createComponent"
    let v86 : string = "solid-js"
    let v87 : JS.Function = import v85 v86
    let v88 : (Mut1 -> JSX.Element) = closure111()
    let v89 : JSX.Element = v87.Invoke (v88, v83) |> unbox<JSX.Element>
    [|v89|]
and closure296 (v0 : (unit -> (struct (int32 * obj) [])), v1 : (unit -> unit), v2 : (unit -> unit)) struct (v3 : US6, v4 : US6, v5 : US6, v6 : US7, v7 : US6, v8 : US6, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US8, v14 : US9, v15 : US6, v16 : US6, v17 : US8, v18 : US10, v19 : US6, v20 : US6, v21 : US6, v22 : US11, v23 : US8, v24 : US6, v25 : US6, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US12, v31 : US6, v32 : US6, v33 : US6, v34 : US12, v35 : US6, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US13, v46 : US14, v47 : US13, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US12, v66 : US6, v67 : US6, v68 : US10, v69 : US10, v70 : US6, v71 : US5, v72 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v73 : string = "Stack"
    let v74 : string = "@hope-ui/solid"
    let v75 : JS.Function = import v73 v74
    let struct (v76 : US6, v77 : US6, v78 : US6, v79 : US7, v80 : US6, v81 : US6, v82 : US6, v83 : US6, v84 : US6, v85 : US6, v86 : US8, v87 : US9, v88 : US6, v89 : US6, v90 : US8, v91 : US10, v92 : US6, v93 : US6, v94 : US6, v95 : US11, v96 : US8, v97 : US6, v98 : US6, v99 : US6, v100 : US6, v101 : US6, v102 : US6, v103 : US12, v104 : US6, v105 : US6, v106 : US6, v107 : US12, v108 : US6, v109 : US6, v110 : US6, v111 : US6, v112 : US6, v113 : US6, v114 : US6, v115 : US6, v116 : US6, v117 : US6, v118 : US13, v119 : US14, v120 : US13, v121 : US6, v122 : US6, v123 : US6, v124 : US6, v125 : US6, v126 : US6, v127 : US6, v128 : US6, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US6, v135 : US6, v136 : US6, v137 : US6, v138 : US12, v139 : US6, v140 : US6, v141 : US10, v142 : US10, v143 : US6, v144 : US5, v145 : US6) = method3()
    let v146 : string = "row"
    let v147 : string = "column"
    let v148 : string = method12(v147, v146)
    let v149 : string = "0"
    let v150 : string = "8px"
    let v151 : string = method12(v150, v149)
    let v159 : US9 =
        match v87 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v153) -> (* Some *)
            let v154 : string = "children"
            let v155 : string = "solid-js"
            let v156 : JS.Function = import v154 v155
            let v157 : (unit -> (JSX.Element [])) = v156.Invoke v153 |> unbox<unit -> JSX.Element[]>
            US9_1(v157)
    let v162 : (unit -> (JSX.Element [])) =
        match v159 with
        | US9_0 -> (* None *)
            closure297(v1, v2)
        | US9_1(v161) -> (* Some *)
            v161
    let v163 : string = "start"
    let v164 : US6 = US6_1(v163)
    let v165 : US9 = US9_1(v162)
    let v166 : US6 = US6_1(v148)
    let v167 : US6 = US6_1(v151)
    let v168 : string = "3px"
    let v169 : US6 = US6_1(v168)
    let v170 : string = "7px"
    let v171 : US6 = US6_1(v170)
    let v172 : ((string * obj) []) = method7(v164, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v165, v88, v89, v90, v91, v92, v166, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v167, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v169, v126, v127, v128, v129, v130, v131, v132, v133, v171, v135, v136, v137, v138, v139, v140, v141, v142, v143, v144, v145)
    let v173 : obj = createObj v172
    let v174 : (unit -> (JSX.Element [])) = closure297(v1, v2)
    emitJsExpr (v173, v174) "$0.children = $1"
    let v175 : (obj -> JSX.Element) = v75 |> unbox<(obj -> JSX.Element)>
    let v176 : string = "createComponent"
    let v177 : string = "solid-js"
    let v178 : JS.Function = import v176 v177
    let v179 : JSX.Element = v178.Invoke (v175, v173) |> unbox<JSX.Element>
    let v180 : (unit -> (JSX.Element [])) = closure303(v0)
    let v181 : US9 = US9_1(v180)
    let v182 : string = "deploy"
    let v183 : US6 = US6_1(v182)
    let v184 : US12 = US12_1(v179)
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v181, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v183, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v184, v66, v67, v68, v69, v70, v71, v72)
and method61 () : JSX.Element =
    let v123 : obj = emitJsExpr () "components_spi.state_context"
    let v124 : string = "useContext"
    let v125 : string = "solid-js"
    let v126 : JS.Function = import v124 v125
    let struct (v127 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])), v128 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit), v129 : (unit -> int32), v130 : (int32 -> unit), v131 : (unit -> string), v132 : (string -> unit), v133 : (unit -> string), v134 : (string -> unit), v135 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])), v136 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit), v137 : (unit -> (struct (US2 * (int32 [])) [])), v138 : ((struct (US2 * (int32 [])) []) -> unit), v139 : (unit -> (struct (int32 * obj) [])), v140 : ((struct (int32 * obj) []) -> unit), v141 : (unit -> (struct (int32 * obj) [])), v142 : ((struct (int32 * obj) []) -> unit), v143 : (unit -> (struct (int32 * int32) [])), v144 : ((struct (int32 * int32) []) -> unit), v145 : (unit -> US4), v146 : (US4 -> unit), v147 : (unit -> US5), v148 : (US5 -> unit)) = v126.Invoke v123 |> unbox<struct ((unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) * ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) * (unit -> int32) * (int32 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) * ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) * (unit -> (struct (US2 * (int32 [])) [])) * ((struct (US2 * (int32 [])) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * obj) [])) * ((struct (int32 * obj) []) -> unit) * (unit -> (struct (int32 * int32) [])) * ((struct (int32 * int32) []) -> unit) * (unit -> US4) * (US4 -> unit) * (unit -> US5) * (US5 -> unit))>
    let v149 : string = "profile/tmp/chain_deploy"
    let v150 : (struct (int32 * obj) []) = v139 ()
    let v151 : (unit -> (unit -> ((struct (int32 * obj) []) -> unit))) = closure292(v140)
    let v152 : (obj -> obj) = closure295()
    let struct (v153 : (unit -> unit), v154 : (unit -> unit)) = method55(v149, v150)
    let v155 : US14 = US14_0
    let v156 : US14 = US14_0
    let v157 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure296(v139, v154, v153)
    let v158 : US15 = US15_2
    let v159 : Mut4 = {l0 = v155; l1 = v156; l2 = v157; l3 = v158} : Mut4
    let v160 : string = "createComponent"
    let v161 : JS.Function = import v160 v125
    let v162 : (Mut4 -> JSX.Element) = closure16()
    let v163 : JSX.Element = v161.Invoke (v162, v159) |> unbox<JSX.Element>
    v163
and closure291 () (v0 : Mut1) : JSX.Element =
    method61()
and closure244 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let struct (v5 : US6, v6 : US6, v7 : US6, v8 : US7, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US8, v16 : US9, v17 : US6, v18 : US6, v19 : US8, v20 : US10, v21 : US6, v22 : US6, v23 : US6, v24 : US11, v25 : US8, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US12, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US13, v48 : US14, v49 : US13, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US12, v68 : US6, v69 : US6, v70 : US10, v71 : US10, v72 : US6, v73 : US5, v74 : US6) = method3()
    let v82 : US9 =
        match v16 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v76) -> (* Some *)
            let v77 : string = "children"
            let v78 : string = "solid-js"
            let v79 : JS.Function = import v77 v78
            let v80 : (unit -> (JSX.Element [])) = v79.Invoke v76 |> unbox<unit -> JSX.Element[]>
            US9_1(v80)
    let v85 : (unit -> (JSX.Element [])) =
        match v82 with
        | US9_0 -> (* None *)
            closure245()
        | US9_1(v84) -> (* Some *)
            v84
    let v86 : US9 = US9_1(v85)
    let v87 : Mut1 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v15; l11 = v86; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v61; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66; l62 = v67; l63 = v68; l64 = v69; l65 = v70; l66 = v71; l67 = v72; l68 = v73; l69 = v74} : Mut1
    let v88 : (unit -> (JSX.Element [])) = closure245()
    emitJsExpr (v87, v88) "$0.children = $1"
    let v89 : string = "createComponent"
    let v90 : string = "solid-js"
    let v91 : JS.Function = import v89 v90
    let v92 : (Mut1 -> JSX.Element) = closure246()
    let v93 : JSX.Element = v91.Invoke (v92, v87) |> unbox<JSX.Element>
    let v95 : bool = v2 = ""
    let v96 : bool = v95 <> true
    let v184 : JSX.Element =
        if v96 then
            let struct (v97 : US6, v98 : US6, v99 : US6, v100 : US7, v101 : US6, v102 : US6, v103 : US6, v104 : US6, v105 : US6, v106 : US6, v107 : US8, v108 : US9, v109 : US6, v110 : US6, v111 : US8, v112 : US10, v113 : US6, v114 : US6, v115 : US6, v116 : US11, v117 : US8, v118 : US6, v119 : US6, v120 : US6, v121 : US6, v122 : US6, v123 : US6, v124 : US12, v125 : US6, v126 : US6, v127 : US6, v128 : US12, v129 : US6, v130 : US6, v131 : US6, v132 : US6, v133 : US6, v134 : US6, v135 : US6, v136 : US6, v137 : US6, v138 : US6, v139 : US13, v140 : US14, v141 : US13, v142 : US6, v143 : US6, v144 : US6, v145 : US6, v146 : US6, v147 : US6, v148 : US6, v149 : US6, v150 : US6, v151 : US6, v152 : US6, v153 : US6, v154 : US6, v155 : US6, v156 : US6, v157 : US6, v158 : US6, v159 : US12, v160 : US6, v161 : US6, v162 : US10, v163 : US10, v164 : US6, v165 : US5, v166 : US6) = method3()
            let v173 : US9 =
                match v108 with
                | US9_0 -> (* None *)
                    US9_0
                | US9_1(v168) -> (* Some *)
                    let v169 : string = "children"
                    let v170 : JS.Function = import v169 v90
                    let v171 : (unit -> (JSX.Element [])) = v170.Invoke v168 |> unbox<unit -> JSX.Element[]>
                    US9_1(v171)
            let v176 : (unit -> (JSX.Element [])) =
                match v173 with
                | US9_0 -> (* None *)
                    closure270()
                | US9_1(v175) -> (* Some *)
                    v175
            let v177 : US9 = US9_1(v176)
            let v178 : Mut1 = {l0 = v97; l1 = v98; l2 = v99; l3 = v100; l4 = v101; l5 = v102; l6 = v103; l7 = v104; l8 = v105; l9 = v106; l10 = v107; l11 = v177; l12 = v109; l13 = v110; l14 = v111; l15 = v112; l16 = v113; l17 = v114; l18 = v115; l19 = v116; l20 = v117; l21 = v118; l22 = v119; l23 = v120; l24 = v121; l25 = v122; l26 = v123; l27 = v124; l28 = v125; l29 = v126; l30 = v127; l31 = v128; l32 = v129; l33 = v130; l34 = v131; l35 = v132; l36 = v133; l37 = v134; l38 = v135; l39 = v136; l40 = v137; l41 = v138; l42 = v139; l43 = v140; l44 = v141; l45 = v142; l46 = v143; l47 = v144; l48 = v145; l49 = v146; l50 = v147; l51 = v148; l52 = v149; l53 = v150; l54 = v151; l55 = v152; l56 = v153; l57 = v154; l58 = v155; l59 = v156; l60 = v157; l61 = v158; l62 = v159; l63 = v160; l64 = v161; l65 = v162; l66 = v163; l67 = v164; l68 = v165; l69 = v166} : Mut1
            let v179 : (unit -> (JSX.Element [])) = closure270()
            emitJsExpr (v178, v179) "$0.children = $1"
            let v180 : JS.Function = import v89 v90
            let v181 : (Mut1 -> JSX.Element) = closure271()
            let v182 : JSX.Element = v180.Invoke (v181, v178) |> unbox<JSX.Element>
            v182
        else
            let v183 : JSX.Element = JS.undefined
            v183
    let v273 : JSX.Element =
        if v96 then
            let struct (v186 : US6, v187 : US6, v188 : US6, v189 : US7, v190 : US6, v191 : US6, v192 : US6, v193 : US6, v194 : US6, v195 : US6, v196 : US8, v197 : US9, v198 : US6, v199 : US6, v200 : US8, v201 : US10, v202 : US6, v203 : US6, v204 : US6, v205 : US11, v206 : US8, v207 : US6, v208 : US6, v209 : US6, v210 : US6, v211 : US6, v212 : US6, v213 : US12, v214 : US6, v215 : US6, v216 : US6, v217 : US12, v218 : US6, v219 : US6, v220 : US6, v221 : US6, v222 : US6, v223 : US6, v224 : US6, v225 : US6, v226 : US6, v227 : US6, v228 : US13, v229 : US14, v230 : US13, v231 : US6, v232 : US6, v233 : US6, v234 : US6, v235 : US6, v236 : US6, v237 : US6, v238 : US6, v239 : US6, v240 : US6, v241 : US6, v242 : US6, v243 : US6, v244 : US6, v245 : US6, v246 : US6, v247 : US6, v248 : US12, v249 : US6, v250 : US6, v251 : US10, v252 : US10, v253 : US6, v254 : US5, v255 : US6) = method3()
            let v262 : US9 =
                match v197 with
                | US9_0 -> (* None *)
                    US9_0
                | US9_1(v257) -> (* Some *)
                    let v258 : string = "children"
                    let v259 : JS.Function = import v258 v90
                    let v260 : (unit -> (JSX.Element [])) = v259.Invoke v257 |> unbox<unit -> JSX.Element[]>
                    US9_1(v260)
            let v265 : (unit -> (JSX.Element [])) =
                match v262 with
                | US9_0 -> (* None *)
                    closure290()
                | US9_1(v264) -> (* Some *)
                    v264
            let v266 : US9 = US9_1(v265)
            let v267 : Mut1 = {l0 = v186; l1 = v187; l2 = v188; l3 = v189; l4 = v190; l5 = v191; l6 = v192; l7 = v193; l8 = v194; l9 = v195; l10 = v196; l11 = v266; l12 = v198; l13 = v199; l14 = v200; l15 = v201; l16 = v202; l17 = v203; l18 = v204; l19 = v205; l20 = v206; l21 = v207; l22 = v208; l23 = v209; l24 = v210; l25 = v211; l26 = v212; l27 = v213; l28 = v214; l29 = v215; l30 = v216; l31 = v217; l32 = v218; l33 = v219; l34 = v220; l35 = v221; l36 = v222; l37 = v223; l38 = v224; l39 = v225; l40 = v226; l41 = v227; l42 = v228; l43 = v229; l44 = v230; l45 = v231; l46 = v232; l47 = v233; l48 = v234; l49 = v235; l50 = v236; l51 = v237; l52 = v238; l53 = v239; l54 = v240; l55 = v241; l56 = v242; l57 = v243; l58 = v244; l59 = v245; l60 = v246; l61 = v247; l62 = v248; l63 = v249; l64 = v250; l65 = v251; l66 = v252; l67 = v253; l68 = v254; l69 = v255} : Mut1
            let v268 : (unit -> (JSX.Element [])) = closure290()
            emitJsExpr (v267, v268) "$0.children = $1"
            let v269 : JS.Function = import v89 v90
            let v270 : (Mut1 -> JSX.Element) = closure291()
            let v271 : JSX.Element = v269.Invoke (v270, v267) |> unbox<JSX.Element>
            v271
        else
            let v272 : JSX.Element = JS.undefined
            v272
    [|v93; v184; v273|]
and closure243 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let struct (v5 : US6, v6 : US6, v7 : US6, v8 : US7, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US8, v16 : US9, v17 : US6, v18 : US6, v19 : US8, v20 : US10, v21 : US6, v22 : US6, v23 : US6, v24 : US11, v25 : US8, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US12, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US13, v48 : US14, v49 : US13, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US12, v68 : US6, v69 : US6, v70 : US10, v71 : US10, v72 : US6, v73 : US5, v74 : US6) = method3()
    let v82 : US9 =
        match v16 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v76) -> (* Some *)
            let v77 : string = "children"
            let v78 : string = "solid-js"
            let v79 : JS.Function = import v77 v78
            let v80 : (unit -> (JSX.Element [])) = v79.Invoke v76 |> unbox<unit -> JSX.Element[]>
            US9_1(v80)
    let v85 : (unit -> (JSX.Element [])) =
        match v82 with
        | US9_0 -> (* None *)
            closure244(v0, v1, v2, v3, v4)
        | US9_1(v84) -> (* Some *)
            v84
    let v86 : US9 = US9_1(v85)
    let v87 : Mut1 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v15; l11 = v86; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v61; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66; l62 = v67; l63 = v68; l64 = v69; l65 = v70; l66 = v71; l67 = v72; l68 = v73; l69 = v74} : Mut1
    let v88 : (unit -> (JSX.Element [])) = closure244(v0, v1, v2, v3, v4)
    emitJsExpr (v87, v88) "$0.children = $1"
    let v89 : string = "createComponent"
    let v90 : string = "solid-js"
    let v91 : JS.Function = import v89 v90
    let v92 : (Mut1 -> JSX.Element) = closure111()
    let v93 : JSX.Element = v91.Invoke (v92, v87) |> unbox<JSX.Element>
    [|v93|]
and closure242 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) struct (v5 : US6, v6 : US6, v7 : US6, v8 : US7, v9 : US6, v10 : US6, v11 : US6, v12 : US6, v13 : US6, v14 : US6, v15 : US8, v16 : US9, v17 : US6, v18 : US6, v19 : US8, v20 : US10, v21 : US6, v22 : US6, v23 : US6, v24 : US11, v25 : US8, v26 : US6, v27 : US6, v28 : US6, v29 : US6, v30 : US6, v31 : US6, v32 : US12, v33 : US6, v34 : US6, v35 : US6, v36 : US12, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US13, v48 : US14, v49 : US13, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US12, v68 : US6, v69 : US6, v70 : US10, v71 : US10, v72 : US6, v73 : US5, v74 : US6) : struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) =
    let v75 : string = "Profile"
    let v76 : JSX.Element = v75 |> unbox<JSX.Element>
    let v77 : JSX.Element = Html.fragment [ v76 ]
    let v78 : (unit -> (JSX.Element [])) = closure243(v0, v1, v2, v3, v4)
    let v79 : US9 = US9_1(v78)
    let v80 : US12 = US12_1(v77)
    struct (v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v79, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v80, v68, v69, v70, v71, v72, v73, v74)
and closure114 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : US14 = US14_0
    let v6 : US14 = US14_0
    let v7 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure115()
    let v8 : US15 = US15_2
    let v9 : Mut4 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8} : Mut4
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : (Mut4 -> JSX.Element) = closure16()
    let v14 : JSX.Element = v12.Invoke (v13, v9) |> unbox<JSX.Element>
    let v15 : US14 = US14_0
    let v16 : US14 = US14_0
    let v17 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure45()
    let v18 : US15 = US15_2
    let v19 : Mut4 = {l0 = v15; l1 = v16; l2 = v17; l3 = v18} : Mut4
    let v20 : JS.Function = import v10 v11
    let v21 : JSX.Element = v20.Invoke (v13, v19) |> unbox<JSX.Element>
    let v22 : US14 = US14_0
    let v23 : US14 = US14_0
    let v24 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure134()
    let v25 : US15 = US15_2
    let v26 : Mut4 = {l0 = v22; l1 = v23; l2 = v24; l3 = v25} : Mut4
    let v27 : JS.Function = import v10 v11
    let v28 : JSX.Element = v27.Invoke (v13, v26) |> unbox<JSX.Element>
    let v29 : US14 = US14_0
    let v30 : US14 = US14_0
    let v31 : US15 = US15_2
    let v32 : Mut4 = {l0 = v29; l1 = v30; l2 = v17; l3 = v31} : Mut4
    let v33 : JS.Function = import v10 v11
    let v34 : JSX.Element = v33.Invoke (v13, v32) |> unbox<JSX.Element>
    let v35 : US14 = US14_0
    let v36 : US14 = US14_0
    let v37 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure146()
    let v38 : US15 = US15_0
    let v39 : Mut4 = {l0 = v35; l1 = v36; l2 = v37; l3 = v38} : Mut4
    let v40 : JS.Function = import v10 v11
    let v41 : JSX.Element = v40.Invoke (v13, v39) |> unbox<JSX.Element>
    let v42 : US14 = US14_0
    let v43 : US14 = US14_0
    let v44 : US15 = US15_2
    let v45 : Mut4 = {l0 = v42; l1 = v43; l2 = v17; l3 = v44} : Mut4
    let v46 : JS.Function = import v10 v11
    let v47 : JSX.Element = v46.Invoke (v13, v45) |> unbox<JSX.Element>
    let v48 : US14 = US14_0
    let v49 : US14 = US14_0
    let v50 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure191()
    let v51 : US15 = US15_0
    let v52 : Mut4 = {l0 = v48; l1 = v49; l2 = v50; l3 = v51} : Mut4
    let v53 : JS.Function = import v10 v11
    let v54 : JSX.Element = v53.Invoke (v13, v52) |> unbox<JSX.Element>
    let v55 : US14 = US14_0
    let v56 : US14 = US14_0
    let v57 : US15 = US15_2
    let v58 : Mut4 = {l0 = v55; l1 = v56; l2 = v17; l3 = v57} : Mut4
    let v59 : JS.Function = import v10 v11
    let v60 : JSX.Element = v59.Invoke (v13, v58) |> unbox<JSX.Element>
    let v61 : US14 = US14_0
    let v62 : US14 = US14_0
    let v63 : (struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6) -> struct (US6 * US6 * US6 * US7 * US6 * US6 * US6 * US6 * US6 * US6 * US8 * US9 * US6 * US6 * US8 * US10 * US6 * US6 * US6 * US11 * US8 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US12 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US13 * US14 * US13 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US6 * US12 * US6 * US6 * US10 * US10 * US6 * US5 * US6)) = closure242(v0, v1, v2, v3, v4)
    let v64 : US15 = US15_2
    let v65 : Mut4 = {l0 = v61; l1 = v62; l2 = v63; l3 = v64} : Mut4
    let v66 : JS.Function = import v10 v11
    let v67 : JSX.Element = v66.Invoke (v13, v65) |> unbox<JSX.Element>
    [|v14; v21; v28; v34; v41; v47; v54; v60; v67|]
and closure1 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v6 : bool = v2 = ""
    let v14 : JSX.Element =
        if v6 then
            let v7 : Mut2 = Mut2()
            let v8 : string = "createComponent"
            let v9 : string = "solid-js"
            let v10 : JS.Function = import v8 v9
            let v11 : (Mut2 -> JSX.Element) = closure2()
            let v12 : JSX.Element = v10.Invoke (v11, v7) |> unbox<JSX.Element>
            v12
        else
            let v13 : JSX.Element = JS.undefined
            v13
    let struct (v15 : US6, v16 : US6, v17 : US6, v18 : US7, v19 : US6, v20 : US6, v21 : US6, v22 : US6, v23 : US6, v24 : US6, v25 : US8, v26 : US9, v27 : US6, v28 : US6, v29 : US8, v30 : US10, v31 : US6, v32 : US6, v33 : US6, v34 : US11, v35 : US8, v36 : US6, v37 : US6, v38 : US6, v39 : US6, v40 : US6, v41 : US6, v42 : US12, v43 : US6, v44 : US6, v45 : US6, v46 : US12, v47 : US6, v48 : US6, v49 : US6, v50 : US6, v51 : US6, v52 : US6, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US13, v58 : US14, v59 : US13, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US6, v69 : US6, v70 : US6, v71 : US6, v72 : US6, v73 : US6, v74 : US6, v75 : US6, v76 : US6, v77 : US12, v78 : US6, v79 : US6, v80 : US10, v81 : US10, v82 : US6, v83 : US5, v84 : US6) = method3()
    let v92 : US9 =
        match v26 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v86) -> (* Some *)
            let v87 : string = "children"
            let v88 : string = "solid-js"
            let v89 : JS.Function = import v87 v88
            let v90 : (unit -> (JSX.Element [])) = v89.Invoke v86 |> unbox<unit -> JSX.Element[]>
            US9_1(v90)
    let v95 : (unit -> (JSX.Element [])) =
        match v92 with
        | US9_0 -> (* None *)
            closure114(v0, v1, v2, v3, v4)
        | US9_1(v94) -> (* Some *)
            v94
    let v96 : US9 = US9_1(v95)
    let v97 : string = "flex"
    let v98 : US6 = US6_1(v97)
    let v99 : string = "1"
    let v100 : US6 = US6_1(v99)
    let v101 : string = "column"
    let v102 : US6 = US6_1(v101)
    let v103 : string = "hidden"
    let v104 : US6 = US6_1(v103)
    let v105 : string = "auto"
    let v106 : US6 = US6_1(v105)
    let v107 : Mut1 = {l0 = v15; l1 = v16; l2 = v17; l3 = v18; l4 = v19; l5 = v20; l6 = v21; l7 = v22; l8 = v23; l9 = v24; l10 = v25; l11 = v96; l12 = v27; l13 = v28; l14 = v29; l15 = v30; l16 = v31; l17 = v32; l18 = v98; l19 = v34; l20 = v35; l21 = v100; l22 = v102; l23 = v38; l24 = v39; l25 = v40; l26 = v41; l27 = v42; l28 = v43; l29 = v44; l30 = v45; l31 = v46; l32 = v47; l33 = v48; l34 = v49; l35 = v50; l36 = v51; l37 = v52; l38 = v53; l39 = v54; l40 = v55; l41 = v56; l42 = v57; l43 = v58; l44 = v59; l45 = v60; l46 = v61; l47 = v104; l48 = v106; l49 = v64; l50 = v65; l51 = v66; l52 = v67; l53 = v68; l54 = v69; l55 = v70; l56 = v71; l57 = v72; l58 = v73; l59 = v74; l60 = v75; l61 = v76; l62 = v77; l63 = v78; l64 = v79; l65 = v80; l66 = v81; l67 = v82; l68 = v83; l69 = v84} : Mut1
    let v108 : (unit -> (JSX.Element [])) = closure114(v0, v1, v2, v3, v4)
    emitJsExpr (v107, v108) "$0.children = $1"
    let v109 : string = "createComponent"
    let v110 : string = "solid-js"
    let v111 : JS.Function = import v109 v110
    let v112 : (Mut1 -> JSX.Element) = closure111()
    let v113 : JSX.Element = v111.Invoke (v112, v107) |> unbox<JSX.Element>
    [|v14; v113|]
and method1 () : JSX.Element =
    let struct (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) = method2()
    let v5 : string = "Box"
    let v6 : string = "@hope-ui/solid"
    let v7 : JS.Function = import v5 v6
    let struct (v8 : US6, v9 : US6, v10 : US6, v11 : US7, v12 : US6, v13 : US6, v14 : US6, v15 : US6, v16 : US6, v17 : US6, v18 : US8, v19 : US9, v20 : US6, v21 : US6, v22 : US8, v23 : US10, v24 : US6, v25 : US6, v26 : US6, v27 : US11, v28 : US8, v29 : US6, v30 : US6, v31 : US6, v32 : US6, v33 : US6, v34 : US6, v35 : US12, v36 : US6, v37 : US6, v38 : US6, v39 : US12, v40 : US6, v41 : US6, v42 : US6, v43 : US6, v44 : US6, v45 : US6, v46 : US6, v47 : US6, v48 : US6, v49 : US6, v50 : US13, v51 : US14, v52 : US13, v53 : US6, v54 : US6, v55 : US6, v56 : US6, v57 : US6, v58 : US6, v59 : US6, v60 : US6, v61 : US6, v62 : US6, v63 : US6, v64 : US6, v65 : US6, v66 : US6, v67 : US6, v68 : US6, v69 : US6, v70 : US12, v71 : US6, v72 : US6, v73 : US10, v74 : US10, v75 : US6, v76 : US5, v77 : US6) = method3()
    let v85 : US9 =
        match v19 with
        | US9_0 -> (* None *)
            US9_0
        | US9_1(v79) -> (* Some *)
            let v80 : string = "children"
            let v81 : string = "solid-js"
            let v82 : JS.Function = import v80 v81
            let v83 : (unit -> (JSX.Element [])) = v82.Invoke v79 |> unbox<unit -> JSX.Element[]>
            US9_1(v83)
    let v88 : (unit -> (JSX.Element [])) =
        match v85 with
        | US9_0 -> (* None *)
            closure1(v0, v1, v2, v3, v4)
        | US9_1(v87) -> (* Some *)
            v87
    let v89 : string = "$bg"
    let v90 : US6 = US6_1(v89)
    let v91 : US9 = US9_1(v88)
    let v92 : string = "$text1"
    let v93 : US6 = US6_1(v92)
    let v94 : string = "flex"
    let v95 : US6 = US6_1(v94)
    let v96 : string = "1"
    let v97 : US6 = US6_1(v96)
    let v98 : string = "column"
    let v99 : US6 = US6_1(v98)
    let v100 : string = "$sm"
    let v101 : US6 = US6_1(v100)
    let v102 : string = "100vh"
    let v103 : US6 = US6_1(v102)
    let v104 : string = "100vw"
    let v105 : US6 = US6_1(v104)
    let v106 : string = "1px"
    let v107 : US6 = US6_1(v106)
    let v108 : ((string * obj) []) = method7(v8, v9, v10, v11, v90, v13, v14, v15, v16, v17, v18, v91, v93, v21, v22, v23, v24, v25, v95, v27, v28, v97, v99, v31, v101, v103, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v105, v48, v49, v50, v51, v52, v53, v54, v55, v56, v107, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77)
    let v109 : obj = createObj v108
    let v110 : (unit -> (JSX.Element [])) = closure1(v0, v1, v2, v3, v4)
    emitJsExpr (v109, v110) "$0.children = $1"
    let v111 : (obj -> JSX.Element) = v7 |> unbox<(obj -> JSX.Element)>
    let v112 : string = "createComponent"
    let v113 : string = "solid-js"
    let v114 : JS.Function = import v112 v113
    let v115 : JSX.Element = v114.Invoke (v111, v109) |> unbox<JSX.Element>
    v115
and closure0 () (v0 : Mut1) : JSX.Element =
    method1()
and closure310 () () : (obj []) =
    [||]
and method62 () : JSX.Element =
    let v0 : (unit -> (obj [])) = closure310()
    let v1 : string = "#cf1100"
    let v2 : (US4 -> ((obj []) -> unit)) = method14(v0, v1)
    let v3 : US4 = US4_0
    let v4 : ((obj []) -> unit) = v2 v3
    let v5 : string = "> db_listener ()"
    let v6 : obj = v5
    let v7 : (obj []) = [|v6|]
    v4 v7
    let v8 : JSX.Element = JS.undefined
    v8
and closure309 () (v0 : Mut2) : JSX.Element =
    method62()
and method63 () : string =
    let v0 : string = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
    v0
and method64 () : string =
    let v0 : string = "http://localhost"
    v0
and method65 () : int32 =
    4001
and method66 () : (struct (US0 * string * string * string) []) =
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
and closure311 () () : obj =
    let struct (v123 : string, v124 : obj, v125 : string, v126 : string, v127 : bool) = method2()
    let v128 : string = method63()
    let v129 : string = "createSignal"
    let v130 : string = "solid-js"
    let v131 : JS.Function = import v129 v130
    let v132 : (JS.Function []) = v131.Invoke v128 |> unbox<JS.Function[]>
    let v133 : (unit -> string) = v132.[0] |> unbox
    let v134 : (string -> unit) = v132.[1] |> unbox
    let v135 : bool = "" = v123
    let v138 : string =
        if v135 then
            method64()
        else
            let v137 : string = $"http://{v123}-4001.githubpreview.dev"
            v137
    let v139 : JS.Function = import v129 v130
    let v140 : (JS.Function []) = v139.Invoke v138 |> unbox<JS.Function[]>
    let v141 : (unit -> string) = v140.[0] |> unbox
    let v142 : (string -> unit) = v140.[1] |> unbox
    let v144 : int32 =
        if v135 then
            method65()
        else
            80
    let v145 : JS.Function = import v129 v130
    let v146 : (JS.Function []) = v145.Invoke v144 |> unbox<JS.Function[]>
    let v147 : (unit -> int32) = v146.[0] |> unbox
    let v148 : (int32 -> unit) = v146.[1] |> unbox
    let v149 : (struct (US0 * string * string * string) []) = method66()
    let v150 : int32 = v149.Length
    let v151 : (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) = Array.zeroCreate<struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit))> (v150)
    let v152 : Mut3 = {l0 = 0} : Mut3
    while method5(v150, v152) do
        let v154 : int32 = v152.l0
        let struct (v155 : US0, v156 : string, v157 : string, v158 : string) = v149.[int v154]
        let v159 : JS.Function = import v129 v130
        let v160 : (JS.Function []) = v159.Invoke v155 |> unbox<JS.Function[]>
        let v161 : (unit -> US0) = v160.[0] |> unbox
        let v162 : (US0 -> unit) = v160.[1] |> unbox
        let v163 : JS.Function = import v129 v130
        let v164 : (JS.Function []) = v163.Invoke v158 |> unbox<JS.Function[]>
        let v165 : (unit -> string) = v164.[0] |> unbox
        let v166 : (string -> unit) = v164.[1] |> unbox
        let v167 : JS.Function = import v129 v130
        let v168 : (JS.Function []) = v167.Invoke v156 |> unbox<JS.Function[]>
        let v169 : (unit -> string) = v168.[0] |> unbox
        let v170 : (string -> unit) = v168.[1] |> unbox
        let v171 : JS.Function = import v129 v130
        let v172 : (JS.Function []) = v171.Invoke v157 |> unbox<JS.Function[]>
        let v173 : (unit -> string) = v172.[0] |> unbox
        let v174 : (string -> unit) = v172.[1] |> unbox
        v151.[int v154] <- struct (v161, v162, v169, v170, v173, v174, v165, v166)
        let v175 : int32 = v154 + 1
        v152.l0 <- v175
        ()
    let v176 : JS.Function = import v129 v130
    let v177 : (JS.Function []) = v176.Invoke v151 |> unbox<JS.Function[]>
    let v178 : (unit -> (struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) [])) = v177.[0] |> unbox
    let v179 : ((struct ((unit -> US0) * (US0 -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit) * (unit -> string) * (string -> unit)) []) -> unit) = v177.[1] |> unbox
    let v185 : string =
        if v135 then
            let v180 : string = "ws://localhost"
            v180
        else
            let v181 : bool = true = v127
            if v181 then
                let v182 : string = "ws://localhost"
                v182
            else
                let v183 : string = $"ws://{v123}-4944.githubpreview.dev"
                v183
    let v190 : int32 =
        if v135 then
            let v186 : bool = true = v127
            if v186 then
                14944
            else
                let v187 : bool = false = v127
                if v187 then
                    4944
                else
                    80
        else
            80
    let v191 : (struct (US2 * (int32 [])) []) = Array.zeroCreate<struct (US2 * (int32 []))> (0)
    let v192 : US3 = US3_1
    let v193 : string = "ws"
    let v199 : string =
        if v135 then
            let v194 : string = "wss://localhost"
            v194
        else
            let v195 : bool = true = v127
            if v195 then
                let v196 : string = "wss://localhost"
                v196
            else
                let v197 : string = $"ws://{v123}-8765.githubpreview.dev"
                v197
    let v204 : int32 =
        if v135 then
            let v200 : bool = true = v127
            if v200 then
                18765
            else
                let v201 : bool = false = v127
                if v201 then
                    8765
                else
                    80
        else
            80
    let v205 : (struct (US2 * (int32 [])) []) = Array.zeroCreate<struct (US2 * (int32 []))> (0)
    let v206 : US3 = US3_0
    let v207 : string = "gun"
    let v208 : (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) = [|struct (v191, v190, v192, v185, v193); struct (v205, v204, v206, v199, v207)|]
    let v209 : JS.Function = import v129 v130
    let v210 : (JS.Function []) = v209.Invoke v208 |> unbox<JS.Function[]>
    let v211 : (unit -> (struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) [])) = v210.[0] |> unbox
    let v212 : ((struct ((struct (US2 * (int32 [])) []) * int32 * US3 * string * string) []) -> unit) = v210.[1] |> unbox
    let v213 : (struct (US2 * (int32 [])) []) = Array.zeroCreate<struct (US2 * (int32 []))> (0)
    let v214 : JS.Function = import v129 v130
    let v215 : (JS.Function []) = v214.Invoke v213 |> unbox<JS.Function[]>
    let v216 : (unit -> (struct (US2 * (int32 [])) [])) = v215.[0] |> unbox
    let v217 : ((struct (US2 * (int32 [])) []) -> unit) = v215.[1] |> unbox
    let v218 : bool = "" = v125
    let v221 : US4 =
        if v218 then
            US4_2
        else
            US4_3
    let v222 : JS.Function = import v129 v130
    let v223 : (JS.Function []) = v222.Invoke v221 |> unbox<JS.Function[]>
    let v224 : (unit -> US4) = v223.[0] |> unbox
    let v225 : (US4 -> unit) = v223.[1] |> unbox
    let v226 : JS.Function = import v129 v130
    let v227 : US5 = US5_0
    let v228 : (JS.Function []) = v226.Invoke v227 |> unbox<JS.Function[]>
    let v229 : (unit -> US5) = v228.[0] |> unbox
    let v230 : (US5 -> unit) = v228.[1] |> unbox
    let v231 : (struct (int32 * int32) []) = Array.zeroCreate<struct (int32 * int32)> (0)
    let v232 : JS.Function = import v129 v130
    let v233 : (JS.Function []) = v232.Invoke v231 |> unbox<JS.Function[]>
    let v234 : (unit -> (struct (int32 * int32) [])) = v233.[0] |> unbox
    let v235 : ((struct (int32 * int32) []) -> unit) = v233.[1] |> unbox
    let v236 : (struct (int32 * obj) []) = Array.zeroCreate<struct (int32 * obj)> (0)
    let v237 : JS.Function = import v129 v130
    let v238 : (JS.Function []) = v237.Invoke v236 |> unbox<JS.Function[]>
    let v239 : (unit -> (struct (int32 * obj) [])) = v238.[0] |> unbox
    let v240 : ((struct (int32 * obj) []) -> unit) = v238.[1] |> unbox
    let v241 : (struct (int32 * obj) []) = Array.zeroCreate<struct (int32 * obj)> (0)
    let v242 : JS.Function = import v129 v130
    let v243 : (JS.Function []) = v242.Invoke v241 |> unbox<JS.Function[]>
    let v244 : (unit -> (struct (int32 * obj) [])) = v243.[0] |> unbox
    let v245 : ((struct (int32 * obj) []) -> unit) = v243.[1] |> unbox
    let v246 : obj = struct (v178, v179, v147, v148, v133, v134, v141, v142, v211, v212, v216, v217, v244, v245, v239, v240, v234, v235, v224, v225, v229, v230)
    v246
let v0 : obj = JS.undefined
let v1 : Mut0 = {l0 = v0} : Mut0
let v72 : obj = emitJsExpr () "process.env"
let v73 : string = "env"
let v74 : (string * obj) = v73, v72
let v75 : ((string * obj) []) = [|v74|]
let v76 : obj = createObj v75
Browser.Dom.window?components_spi <- v76
let v77 : int32 = Random().Next ()
let v201 : obj = method0()
let v202 : string = "content"
let v203 : (Mut1 -> JSX.Element) = closure0()
let v204 : (string * obj) = v202, v203
let v205 : string = "db_listener"
let v206 : (Mut2 -> JSX.Element) = closure309()
let v207 : (string * obj) = v205, v206
let v208 : string = "run_id"
let v209 : (string * obj) = v208, v77
let v210 : string = "new_state_context_any"
let v211 : (unit -> obj) = closure311()
let v212 : (string * obj) = v210, v211
let v213 : string = "state_context"
let v214 : (string * obj) = v213, v201
let v215 : ((string * obj) []) = [|v204; v207; v209; v212; v214; v74|]
let v216 : obj = createObj v215
Browser.Dom.window?components_spi <- v216
v1.l0 <- v216
()
