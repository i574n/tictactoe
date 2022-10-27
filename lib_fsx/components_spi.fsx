#r "nuget: Feliz.JSX.Solid, 1.0.0-beta-001"
open System
open Fable.Core
open Fable.Core.JsInterop
open Feliz.JSX.Solid

type Mut0 = {mutable l0 : obj}
and [<Struct>] US0 =
    | US0_0
    | US0_1 of f1_0 : int32
and [<Struct>] US1 =
    | US1_0
    | US1_1 of f1_0 : string
and [<Struct>] US2 =
    | US2_0
    | US2_1
and Mut1 = {mutable l0 : (struct (string * string * string * string) []); mutable l1 : US0; mutable l2 : US1; mutable l3 : US1; mutable l4 : (struct (US2 * int32 * string * string) []); mutable l5 : (struct (US2 * US2) []); mutable l6 : (struct (int32 * obj) []); mutable l7 : (struct (int32 * obj) []); mutable l8 : (struct (int32 * int32) []); mutable l9 : US0}
and [<Struct>] US3 =
    | US3_0
    | US3_1 of f1_0 : JS.Function
and [<Struct>] US4 =
    | US4_0
    | US4_1 of f1_0 : bool
and [<Struct>] US5 =
    | US5_0
    | US5_1 of f1_0 : (unit -> (JSX.Element []))
and [<Struct>] US6 =
    | US6_0
    | US6_1 of f1_0 : obj
and [<Struct>] US7 =
    | US7_0
    | US7_1 of f1_0 : (obj [])
and [<Struct>] US8 =
    | US8_0
    | US8_1 of f1_0 : JSX.Element
and [<Struct>] US9 =
    | US9_0
    | US9_1 of f1_0 : (obj -> unit)
and [<Struct>] US10 =
    | US10_0
    | US10_1 of f1_0 : (unit -> unit)
and Mut2 = {mutable l0 : US1; mutable l1 : US1; mutable l2 : US3; mutable l3 : US1; mutable l4 : US1; mutable l5 : US1; mutable l6 : US1; mutable l7 : US1; mutable l8 : US1; mutable l9 : US4; mutable l10 : US5; mutable l11 : US1; mutable l12 : US1; mutable l13 : US4; mutable l14 : US6; mutable l15 : US1; mutable l16 : US1; mutable l17 : US1; mutable l18 : US7; mutable l19 : US4; mutable l20 : US1; mutable l21 : US1; mutable l22 : US1; mutable l23 : US1; mutable l24 : US1; mutable l25 : US8; mutable l26 : US1; mutable l27 : US1; mutable l28 : US1; mutable l29 : US8; mutable l30 : US1; mutable l31 : US1; mutable l32 : US1; mutable l33 : US1; mutable l34 : US1; mutable l35 : US1; mutable l36 : US1; mutable l37 : US1; mutable l38 : US9; mutable l39 : US10; mutable l40 : US9; mutable l41 : US1; mutable l42 : US1; mutable l43 : US1; mutable l44 : US1; mutable l45 : US1; mutable l46 : US1; mutable l47 : US1; mutable l48 : US1; mutable l49 : US1; mutable l50 : US1; mutable l51 : US1; mutable l52 : US1; mutable l53 : US1; mutable l54 : US1; mutable l55 : US1; mutable l56 : US8; mutable l57 : US1; mutable l58 : US1; mutable l59 : US6; mutable l60 : US1; mutable l61 : US0; mutable l62 : US1}
and UH0 =
    | UH0_0 of (string * obj) * UH0
    | UH0_1
and [<Struct>] US11 =
    | US11_0
    | US11_1 of f1_0 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit))
and [<Struct>] US12 =
    | US12_0
    | US12_1
    | US12_2
and Mut3 = {mutable l0 : US11; mutable l1 : Mut2; mutable l2 : US12}
and Mut4 = {mutable l0 : bool; mutable l1 : bool; mutable l2 : US11; mutable l3 : Mut2}
and Mut5 = {mutable l0 : int32}
and Mut6 = {mutable l0 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)); mutable l1 : (unit -> JS.Function); mutable l2 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1))}
and Mut7 = {mutable l0 : (Mut1 -> US1); mutable l1 : (Mut1 -> (Mut1 -> (US1 -> unit)))}
and Mut8 = {mutable l0 : (Mut1 -> US0); mutable l1 : (Mut1 -> (Mut1 -> (US0 -> unit)))}
and Mut9 = {mutable l0 : US2}
and Mut10 = {mutable l0 : US2; mutable l1 : (struct (US2 * int32 * string * string) -> US1); mutable l2 : (struct (US2 * int32 * string * string) -> (US1 -> struct (US2 * int32 * string * string)))}
and Mut11 = {mutable l0 : int32; mutable l1 : US1}
and [<Struct>] US13 =
    | US13_0
    | US13_1 of f1_0 : US2 * f1_1 : int32 * f1_2 : string * f1_3 : string
and Mut12 = {mutable l0 : int32; mutable l1 : US13}
and Mut13 = {mutable l0 : US2; mutable l1 : (struct (US2 * int32 * string * string) -> US0); mutable l2 : (struct (US2 * int32 * string * string) -> (US0 -> struct (US2 * int32 * string * string)))}
and Mut14 = {mutable l0 : int32; mutable l1 : US0}
and UH1 =
    | UH1_0 of int32 * int32 * UH1
    | UH1_1
and Mut15 = {mutable l0 : int32; mutable l1 : UH1}
and UH2 =
    | UH2_0 of int32 * obj * UH2
    | UH2_1
and Mut16 = {mutable l0 : int32; mutable l1 : UH2}
let rec method0 () : struct ((struct (string * string * string * string) []) * US0 * US1 * US1 * (struct (US2 * int32 * string * string) []) * (struct (US2 * US2) []) * (struct (int32 * obj) []) * (struct (int32 * obj) []) * (struct (int32 * int32) []) * US0) =
    let v0 : string = "4ZZJNAAPJGOUBHORYKX5DQSJJIMQLADNUIH7ONXZAVEZYZGOAM5CM7HV2M"
    let v1 : string = "admin"
    let v2 : string = "poem slush dry adult final thunder price pause concert topic mesh wild dry gate judge celery winter list promote clump country loan move about faith"
    let v3 : string = "OBVzhzxAK4ZPdaF1QbkXsd8hgRUPJeCfYFjFghgMGnLmcpaAD0mdQJ3Rwq/RwklKGQWAbaIP9zb5BUmcZM4DOg=="
    let v4 : string = "Q2MAJEB7HYFK42KSN2MY26PL3P5P7HVIGR22GDAGCJQUARDEIM4WLHSIFQ"
    let v5 : string = "x"
    let v6 : string = "crater dove click normal kitten aisle obvious error exotic lunar guard impact donkey gun lamp divide announce match cement excess piano turn fish above make"
    let v7 : string = "lHFQVWKpvRYU00yAQqHOHJegn5nvP0owYkroBFKr94qGmASQPz4KrmlSbpmNeevb+v+eqDR1owwGEmFARGRDOQ=="
    let v8 : string = "KVGJONR4BETXZ3AS224T4MAJATTSTQGVO3VC3YAGSWAYBVD7KPR23RKNBI"
    let v9 : string = "o"
    let v10 : string = "key churn alert mother lock run lyrics category office lamp silver nut cement pistol fury hollow faculty feed capable announce index cloth faint about bid"
    let v11 : string = "0DNKDAK5QfWuMCTMNJ+Re5mSlc7rbI0q1UOUYDmvPGpVTJc2PAknfOwS1rk+MAkE5ynA1XbqLeAGlYGA1H9T4w=="
    let v12 : (struct (string * string * string * string) []) = [|struct (v0, v1, v2, v3); struct (v4, v5, v6, v7); struct (v8, v9, v10, v11)|]
    let v13 : (struct (US2 * US2) []) = [||]
    let v14 : (struct (US2 * int32 * string * string) []) = [||]
    let v15 : (struct (int32 * int32) []) = [||]
    let v16 : (struct (int32 * obj) []) = [||]
    let v17 : (struct (int32 * obj) []) = [||]
    let v18 : US0 = US0_1(4001)
    let v19 : string = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
    let v20 : US1 = US1_1(v19)
    let v21 : string = "http://localhost"
    let v22 : US1 = US1_1(v21)
    let v23 : US0 = US0_0
    struct (v12, v18, v20, v22, v14, v13, v17, v16, v15, v23)
and closure1 (v0 : obj) (v1 : obj) : unit =
    let v2 : JS.Function = v1?on |> unbox<JS.Function>
    v2.Invoke ("@init", fun () -> v0) |> ignore
    v2.Invoke ("set", emitJsExpr () "(_: any, state: any) => state") |> ignore
    ()
and closure0 () (v0 : obj) : obj =
    let v1 : string = "createStoreon"
    let v2 : string = "storeon"
    let v3 : JS.Function = import v1 v2
    let v4 : (obj -> unit) = closure1(v0)
    let v5 : obj = v3.Invoke [| v4 |]
    v5
and method1 () : (obj -> obj) =
    closure0()
and method2 () : struct (obj * string * bool) =
    let v0 : obj = emitJsExpr () "components_spi.env"
    let v1 : string = v0?GITHUB_RUN_ID
    let v2 : obj = v0?IS_TEST
    let v3 : bool = emitJsExpr v2 "!$0"
    let v4 : bool = v3 = false
    struct (v0, v1, v4)
and method3 (v0 : int32, v1 : string) : string =
    let v2 : int32 = String.length v1
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : string = $"0{v1}"
        method3(v0, v4)
    else
        v1
and closure3 (v0 : obj, v1 : string, v2 : bool, v3 : int64) struct (v4 : Mut1, v5 : Mut1, v6 : obj) : unit =
    let v7 : string = ">> db_listener store.on(@changed)"
    let v8 : obj = v7
    let v9 : string = "b_changed:"
    let v10 : obj = struct (v9, v5)
    let v11 : (obj []) = [|v8; v10|]
    let v12 : int64 = DateTime.UtcNow.Ticks / 1000L
    let v13 : int64 = v12 - v3
    let v14 : string = v13.ToString ()
    let v15 : int32 = 6
    let v16 : string = method3(v15, v14)
    let v17 : int32 = emitJsExpr () "components_spi.run_id"
    let v18 : string = $"[{v16}] {v17}"
    let v19 : string = JS.JSON.stringify v11
    let v20 : (obj []) = [||]
    let v21 : string = JS.JSON.stringify v20
    let struct (v27 : string, v28 : string, v29 : string, v30 : string, v31 : string) =
        if v2 then
            let v22 : string = ""
            struct (v18, v19, v21, v22, v22)
        else
            let v23 : string = $"{v18} %%c%%s %%c%%s"
            let v24 : string = "#cf1100"
            let v25 : string = $"font-weight: bold; color: {v24}"
            let v26 : string = "font-weight: bold; color: #444"
            struct (v23, v25, v19, v26, v21)
    emitJsExpr () $"console.log.apply(console, {struct (v27, v28, v29, v30, v31)})"
    let struct (v32 : (struct (US2 * int32 * string * string) []), v33 : (struct (US2 * US2) [])) = v5.l4, v5.l5
    let v34 : bool = emitJsExpr v33 "!$0"
    let v35 : bool = v34 = false
    let v40 : bool =
        if v35 then
            true
        else
            let struct (v36 : (struct (US2 * int32 * string * string) []), v37 : (struct (US2 * US2) [])) = v5.l4, v5.l5
            let v38 : bool = emitJsExpr v36 "!$0"
            let v39 : bool = v38 = false
            v39
    ()
and closure2 (v0 : obj) (v1 : Mut2) : JSX.Element =
    let struct (v2 : obj, v3 : string, v4 : bool) = method2()
    let v5 : int64 = DateTime.UtcNow.Ticks / 1000L
    let v6 : string = "> db_listener ()"
    let v7 : obj = v6
    let v8 : (obj []) = [|v7|]
    let v9 : int64 = DateTime.UtcNow.Ticks / 1000L
    let v10 : int64 = v9 - v5
    let v11 : string = v10.ToString ()
    let v12 : int32 = 6
    let v13 : string = method3(v12, v11)
    let v14 : int32 = emitJsExpr () "components_spi.run_id"
    let v15 : string = $"[{v13}] {v14}"
    let v16 : string = JS.JSON.stringify v8
    let v17 : (obj []) = [||]
    let v18 : string = JS.JSON.stringify v17
    let struct (v24 : string, v25 : string, v26 : string, v27 : string, v28 : string) =
        if v4 then
            let v19 : string = ""
            struct (v15, v16, v18, v19, v19)
        else
            let v20 : string = $"{v15} %%c%%s %%c%%s"
            let v21 : string = "#cf1100"
            let v22 : string = $"font-weight: bold; color: {v21}"
            let v23 : string = "font-weight: bold; color: #444"
            struct (v20, v22, v16, v23, v18)
    emitJsExpr () $"console.log.apply(console, {struct (v24, v25, v26, v27, v28)})"
    let v29 : JS.Function = v0?on |> unbox<JS.Function>
    let v30 : (struct (Mut1 * Mut1 * obj) -> unit) = closure3(v2, v3, v4, v5)
    let v31 : JS.Function = emitJsExpr v30 "(...args: any[]) => $0(args)"
    let v32 : (unit -> unit) = v29.Invoke ("@changed", v31) |> unbox<unit -> unit>
    let v33 : string = "onCleanup"
    let v34 : string = "solid-js"
    let v35 : JS.Function = import v33 v34
    v35.Invoke v32 |> ignore
    let v36 : JSX.Element = Html.fragment []
    v36
and method4 () : struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) =
    let v0 : US1 = US1_0
    let v1 : US1 = US1_0
    let v2 : US3 = US3_0
    let v3 : US1 = US1_0
    let v4 : US1 = US1_0
    let v5 : US1 = US1_0
    let v6 : US1 = US1_0
    let v7 : US1 = US1_0
    let v8 : US1 = US1_0
    let v9 : US4 = US4_0
    let v10 : US5 = US5_0
    let v11 : US1 = US1_0
    let v12 : US1 = US1_0
    let v13 : US4 = US4_0
    let v14 : US6 = US6_0
    let v15 : US1 = US1_0
    let v16 : US1 = US1_0
    let v17 : US1 = US1_0
    let v18 : US7 = US7_0
    let v19 : US4 = US4_0
    let v20 : US1 = US1_0
    let v21 : US1 = US1_0
    let v22 : US1 = US1_0
    let v23 : US1 = US1_0
    let v24 : US1 = US1_0
    let v25 : US8 = US8_0
    let v26 : US1 = US1_0
    let v27 : US1 = US1_0
    let v28 : US1 = US1_0
    let v29 : US8 = US8_0
    let v30 : US1 = US1_0
    let v31 : US1 = US1_0
    let v32 : US1 = US1_0
    let v33 : US1 = US1_0
    let v34 : US1 = US1_0
    let v35 : US1 = US1_0
    let v36 : US1 = US1_0
    let v37 : US1 = US1_0
    let v38 : US9 = US9_0
    let v39 : US10 = US10_0
    let v40 : US9 = US9_0
    let v41 : US1 = US1_0
    let v42 : US1 = US1_0
    let v43 : US1 = US1_0
    let v44 : US1 = US1_0
    let v45 : US1 = US1_0
    let v46 : US1 = US1_0
    let v47 : US1 = US1_0
    let v48 : US1 = US1_0
    let v49 : US1 = US1_0
    let v50 : US1 = US1_0
    let v51 : US1 = US1_0
    let v52 : US1 = US1_0
    let v53 : US1 = US1_0
    let v54 : US1 = US1_0
    let v55 : US1 = US1_0
    let v56 : US8 = US8_0
    let v57 : US1 = US1_0
    let v58 : US1 = US1_0
    let v59 : US6 = US6_0
    let v60 : US1 = US1_0
    let v61 : US0 = US0_0
    let v62 : US1 = US1_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure8 () () : (JSX.Element []) =
    [||]
and method8 (v0 : UH0, v1 : int32) : int32 =
    match v0 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : int32 = v1 + 1
        method8(v3, v4)
    | UH0_1 -> (* Nil *)
        v1
and method9 (v0 : ((string * obj) []), v1 : UH0, v2 : int32) : int32 =
    match v1 with
    | UH0_0(v3, v4) -> (* Cons *)
        v0.[int v2] <- v3
        let v5 : int32 = v2 + 1
        method9(v0, v4, v5)
    | UH0_1 -> (* Nil *)
        v2
and method7 (v0 : UH0) : ((string * obj) []) =
    let v1 : int32 = 0
    let v2 : int32 = method8(v0, v1)
    let v3 : ((string * obj) []) = Array.zeroCreate<(string * obj)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method9(v3, v0, v4)
    v3
and method6 (v0 : US1, v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) : ((string * obj) []) =
    let v66 : obj =
        match v0 with
        | US1_0 -> (* None *)
            let v63 : obj = ()
            v63
        | US1_1(v64) -> (* Some *)
            let v65 : obj = v64
            v65
    let v67 : bool = emitJsExpr v66 "!$0"
    let v73 : UH0 =
        if v67 then
            UH0_1
        else
            let v69 : string = "alignItems"
            let v70 : (string * obj) = v69, v66
            let v71 : UH0 = UH0_1
            UH0_0(v70, v71)
    let v77 : obj =
        match v1 with
        | US1_0 -> (* None *)
            let v74 : obj = ()
            v74
        | US1_1(v75) -> (* Some *)
            let v76 : obj = v75
            v76
    let v78 : bool = emitJsExpr v77 "!$0"
    let v82 : UH0 =
        if v78 then
            v73
        else
            let v79 : string = "aria-label"
            let v80 : (string * obj) = v79, v77
            UH0_0(v80, v73)
    let v86 : obj =
        match v2 with
        | US3_0 -> (* None *)
            let v83 : obj = ()
            v83
        | US3_1(v84) -> (* Some *)
            let v85 : obj = v84
            v85
    let v87 : bool = emitJsExpr v86 "!$0"
    let v91 : UH0 =
        if v87 then
            v82
        else
            let v88 : string = "as"
            let v89 : (string * obj) = v88, v86
            UH0_0(v89, v82)
    let v95 : obj =
        match v3 with
        | US1_0 -> (* None *)
            let v92 : obj = ()
            v92
        | US1_1(v93) -> (* Some *)
            let v94 : obj = v93
            v94
    let v96 : bool = emitJsExpr v95 "!$0"
    let v100 : UH0 =
        if v96 then
            v91
        else
            let v97 : string = "backgroundColor"
            let v98 : (string * obj) = v97, v95
            UH0_0(v98, v91)
    let v104 : obj =
        match v4 with
        | US1_0 -> (* None *)
            let v101 : obj = ()
            v101
        | US1_1(v102) -> (* Some *)
            let v103 : obj = v102
            v103
    let v105 : bool = emitJsExpr v104 "!$0"
    let v109 : UH0 =
        if v105 then
            v100
        else
            let v106 : string = "border"
            let v107 : (string * obj) = v106, v104
            UH0_0(v107, v100)
    let v113 : obj =
        match v5 with
        | US1_0 -> (* None *)
            let v110 : obj = ()
            v110
        | US1_1(v111) -> (* Some *)
            let v112 : obj = v111
            v112
    let v114 : bool = emitJsExpr v113 "!$0"
    let v118 : UH0 =
        if v114 then
            v109
        else
            let v115 : string = "borderBottomWidth"
            let v116 : (string * obj) = v115, v113
            UH0_0(v116, v109)
    let v122 : obj =
        match v6 with
        | US1_0 -> (* None *)
            let v119 : obj = ()
            v119
        | US1_1(v120) -> (* Some *)
            let v121 : obj = v120
            v121
    let v123 : bool = emitJsExpr v122 "!$0"
    let v127 : UH0 =
        if v123 then
            v118
        else
            let v124 : string = "borderColor"
            let v125 : (string * obj) = v124, v122
            UH0_0(v125, v118)
    let v131 : obj =
        match v7 with
        | US1_0 -> (* None *)
            let v128 : obj = ()
            v128
        | US1_1(v129) -> (* Some *)
            let v130 : obj = v129
            v130
    let v132 : bool = emitJsExpr v131 "!$0"
    let v136 : UH0 =
        if v132 then
            v127
        else
            let v133 : string = "borderWidth"
            let v134 : (string * obj) = v133, v131
            UH0_0(v134, v127)
    let v140 : obj =
        match v8 with
        | US1_0 -> (* None *)
            let v137 : obj = ()
            v137
        | US1_1(v138) -> (* Some *)
            let v139 : obj = v138
            v139
    let v141 : bool = emitJsExpr v140 "!$0"
    let v145 : UH0 =
        if v141 then
            v136
        else
            let v142 : string = "bottom"
            let v143 : (string * obj) = v142, v140
            UH0_0(v143, v136)
    let v149 : obj =
        match v9 with
        | US4_0 -> (* None *)
            let v146 : obj = ()
            v146
        | US4_1(v147) -> (* Some *)
            let v148 : obj = v147
            v148
    let v150 : bool = emitJsExpr v149 "!$0"
    let v154 : UH0 =
        if v150 then
            v145
        else
            let v151 : string = "checked"
            let v152 : (string * obj) = v151, v149
            UH0_0(v152, v145)
    let v158 : obj =
        match v10 with
        | US5_0 -> (* None *)
            let v155 : obj = ()
            v155
        | US5_1(v156) -> (* Some *)
            let v157 : obj = v156
            v157
    let v159 : bool = emitJsExpr v158 "!$0"
    let v163 : UH0 =
        if v159 then
            v154
        else
            let v160 : string = "children"
            let v161 : (string * obj) = v160, v158
            UH0_0(v161, v154)
    let v167 : obj =
        match v11 with
        | US1_0 -> (* None *)
            let v164 : obj = ()
            v164
        | US1_1(v165) -> (* Some *)
            let v166 : obj = v165
            v166
    let v168 : bool = emitJsExpr v167 "!$0"
    let v172 : UH0 =
        if v168 then
            v163
        else
            let v169 : string = "color"
            let v170 : (string * obj) = v169, v167
            UH0_0(v170, v163)
    let v176 : obj =
        match v12 with
        | US1_0 -> (* None *)
            let v173 : obj = ()
            v173
        | US1_1(v174) -> (* Some *)
            let v175 : obj = v174
            v175
    let v177 : bool = emitJsExpr v176 "!$0"
    let v181 : UH0 =
        if v177 then
            v172
        else
            let v178 : string = "colorScheme"
            let v179 : (string * obj) = v178, v176
            UH0_0(v179, v172)
    let v185 : obj =
        match v13 with
        | US4_0 -> (* None *)
            let v182 : obj = ()
            v182
        | US4_1(v183) -> (* Some *)
            let v184 : obj = v183
            v184
    let v186 : bool = emitJsExpr v185 "!$0"
    let v190 : UH0 =
        if v186 then
            v181
        else
            let v187 : string = "compact"
            let v188 : (string * obj) = v187, v185
            UH0_0(v188, v181)
    let v194 : obj =
        match v14 with
        | US6_0 -> (* None *)
            let v191 : obj = ()
            v191
        | US6_1(v192) -> (* Some *)
            let v193 : obj = v192
            v193
    let v195 : bool = emitJsExpr v194 "!$0"
    let v199 : UH0 =
        if v195 then
            v190
        else
            let v196 : string = "css"
            let v197 : (string * obj) = v196, v194
            UH0_0(v197, v190)
    let v203 : obj =
        match v15 with
        | US1_0 -> (* None *)
            let v200 : obj = ()
            v200
        | US1_1(v201) -> (* Some *)
            let v202 : obj = v201
            v202
    let v204 : bool = emitJsExpr v203 "!$0"
    let v208 : UH0 =
        if v204 then
            v199
        else
            let v205 : string = "defaultValue"
            let v206 : (string * obj) = v205, v203
            UH0_0(v206, v199)
    let v212 : obj =
        match v16 with
        | US1_0 -> (* None *)
            let v209 : obj = ()
            v209
        | US1_1(v210) -> (* Some *)
            let v211 : obj = v210
            v211
    let v213 : bool = emitJsExpr v212 "!$0"
    let v217 : UH0 =
        if v213 then
            v208
        else
            let v214 : string = "direction"
            let v215 : (string * obj) = v214, v212
            UH0_0(v215, v208)
    let v221 : obj =
        match v17 with
        | US1_0 -> (* None *)
            let v218 : obj = ()
            v218
        | US1_1(v219) -> (* Some *)
            let v220 : obj = v219
            v220
    let v222 : bool = emitJsExpr v221 "!$0"
    let v226 : UH0 =
        if v222 then
            v217
        else
            let v223 : string = "display"
            let v224 : (string * obj) = v223, v221
            UH0_0(v224, v217)
    let v230 : obj =
        match v18 with
        | US7_0 -> (* None *)
            let v227 : obj = ()
            v227
        | US7_1(v228) -> (* Some *)
            let v229 : obj = v228
            v229
    let v231 : bool = emitJsExpr v230 "!$0"
    let v235 : UH0 =
        if v231 then
            v226
        else
            let v232 : string = "each"
            let v233 : (string * obj) = v232, v230
            UH0_0(v233, v226)
    let v239 : obj =
        match v19 with
        | US4_0 -> (* None *)
            let v236 : obj = ()
            v236
        | US4_1(v237) -> (* Some *)
            let v238 : obj = v237
            v238
    let v240 : bool = emitJsExpr v239 "!$0"
    let v244 : UH0 =
        if v240 then
            v235
        else
            let v241 : string = "external"
            let v242 : (string * obj) = v241, v239
            UH0_0(v242, v235)
    let v248 : obj =
        match v20 with
        | US1_0 -> (* None *)
            let v245 : obj = ()
            v245
        | US1_1(v246) -> (* Some *)
            let v247 : obj = v246
            v247
    let v249 : bool = emitJsExpr v248 "!$0"
    let v253 : UH0 =
        if v249 then
            v244
        else
            let v250 : string = "flex"
            let v251 : (string * obj) = v250, v248
            UH0_0(v251, v244)
    let v257 : obj =
        match v21 with
        | US1_0 -> (* None *)
            let v254 : obj = ()
            v254
        | US1_1(v255) -> (* Some *)
            let v256 : obj = v255
            v256
    let v258 : bool = emitJsExpr v257 "!$0"
    let v262 : UH0 =
        if v258 then
            v253
        else
            let v259 : string = "flexDirection"
            let v260 : (string * obj) = v259, v257
            UH0_0(v260, v253)
    let v266 : obj =
        match v22 with
        | US1_0 -> (* None *)
            let v263 : obj = ()
            v263
        | US1_1(v264) -> (* Some *)
            let v265 : obj = v264
            v265
    let v267 : bool = emitJsExpr v266 "!$0"
    let v271 : UH0 =
        if v267 then
            v262
        else
            let v268 : string = "fontSize"
            let v269 : (string * obj) = v268, v266
            UH0_0(v269, v262)
    let v275 : obj =
        match v23 with
        | US1_0 -> (* None *)
            let v272 : obj = ()
            v272
        | US1_1(v273) -> (* Some *)
            let v274 : obj = v273
            v274
    let v276 : bool = emitJsExpr v275 "!$0"
    let v280 : UH0 =
        if v276 then
            v271
        else
            let v277 : string = "height"
            let v278 : (string * obj) = v277, v275
            UH0_0(v278, v271)
    let v284 : obj =
        match v24 with
        | US1_0 -> (* None *)
            let v281 : obj = ()
            v281
        | US1_1(v282) -> (* Some *)
            let v283 : obj = v282
            v283
    let v285 : bool = emitJsExpr v284 "!$0"
    let v289 : UH0 =
        if v285 then
            v280
        else
            let v286 : string = "href"
            let v287 : (string * obj) = v286, v284
            UH0_0(v287, v280)
    let v293 : obj =
        match v25 with
        | US8_0 -> (* None *)
            let v290 : obj = ()
            v290
        | US8_1(v291) -> (* Some *)
            let v292 : obj = v291
            v292
    let v294 : bool = emitJsExpr v293 "!$0"
    let v298 : UH0 =
        if v294 then
            v289
        else
            let v295 : string = "icon"
            let v296 : (string * obj) = v295, v293
            UH0_0(v296, v289)
    let v302 : obj =
        match v26 with
        | US1_0 -> (* None *)
            let v299 : obj = ()
            v299
        | US1_1(v300) -> (* Some *)
            let v301 : obj = v300
            v301
    let v303 : bool = emitJsExpr v302 "!$0"
    let v307 : UH0 =
        if v303 then
            v298
        else
            let v304 : string = "id"
            let v305 : (string * obj) = v304, v302
            UH0_0(v305, v298)
    let v311 : obj =
        match v27 with
        | US1_0 -> (* None *)
            let v308 : obj = ()
            v308
        | US1_1(v309) -> (* Some *)
            let v310 : obj = v309
            v310
    let v312 : bool = emitJsExpr v311 "!$0"
    let v316 : UH0 =
        if v312 then
            v307
        else
            let v313 : string = "justifyContent"
            let v314 : (string * obj) = v313, v311
            UH0_0(v314, v307)
    let v320 : obj =
        match v28 with
        | US1_0 -> (* None *)
            let v317 : obj = ()
            v317
        | US1_1(v318) -> (* Some *)
            let v319 : obj = v318
            v319
    let v321 : bool = emitJsExpr v320 "!$0"
    let v325 : UH0 =
        if v321 then
            v316
        else
            let v322 : string = "left"
            let v323 : (string * obj) = v322, v320
            UH0_0(v323, v316)
    let v329 : obj =
        match v29 with
        | US8_0 -> (* None *)
            let v326 : obj = ()
            v326
        | US8_1(v327) -> (* Some *)
            let v328 : obj = v327
            v328
    let v330 : bool = emitJsExpr v329 "!$0"
    let v334 : UH0 =
        if v330 then
            v325
        else
            let v331 : string = "leftIcon"
            let v332 : (string * obj) = v331, v329
            UH0_0(v332, v325)
    let v338 : obj =
        match v30 with
        | US1_0 -> (* None *)
            let v335 : obj = ()
            v335
        | US1_1(v336) -> (* Some *)
            let v337 : obj = v336
            v337
    let v339 : bool = emitJsExpr v338 "!$0"
    let v343 : UH0 =
        if v339 then
            v334
        else
            let v340 : string = "lineHeight"
            let v341 : (string * obj) = v340, v338
            UH0_0(v341, v334)
    let v347 : obj =
        match v31 with
        | US1_0 -> (* None *)
            let v344 : obj = ()
            v344
        | US1_1(v345) -> (* Some *)
            let v346 : obj = v345
            v346
    let v348 : bool = emitJsExpr v347 "!$0"
    let v352 : UH0 =
        if v348 then
            v343
        else
            let v349 : string = "margin"
            let v350 : (string * obj) = v349, v347
            UH0_0(v350, v343)
    let v356 : obj =
        match v32 with
        | US1_0 -> (* None *)
            let v353 : obj = ()
            v353
        | US1_1(v354) -> (* Some *)
            let v355 : obj = v354
            v355
    let v357 : bool = emitJsExpr v356 "!$0"
    let v361 : UH0 =
        if v357 then
            v352
        else
            let v358 : string = "marginBottom"
            let v359 : (string * obj) = v358, v356
            UH0_0(v359, v352)
    let v365 : obj =
        match v33 with
        | US1_0 -> (* None *)
            let v362 : obj = ()
            v362
        | US1_1(v363) -> (* Some *)
            let v364 : obj = v363
            v364
    let v366 : bool = emitJsExpr v365 "!$0"
    let v370 : UH0 =
        if v366 then
            v361
        else
            let v367 : string = "marginLeft"
            let v368 : (string * obj) = v367, v365
            UH0_0(v368, v361)
    let v374 : obj =
        match v34 with
        | US1_0 -> (* None *)
            let v371 : obj = ()
            v371
        | US1_1(v372) -> (* Some *)
            let v373 : obj = v372
            v373
    let v375 : bool = emitJsExpr v374 "!$0"
    let v379 : UH0 =
        if v375 then
            v370
        else
            let v376 : string = "marginRight"
            let v377 : (string * obj) = v376, v374
            UH0_0(v377, v370)
    let v383 : obj =
        match v35 with
        | US1_0 -> (* None *)
            let v380 : obj = ()
            v380
        | US1_1(v381) -> (* Some *)
            let v382 : obj = v381
            v382
    let v384 : bool = emitJsExpr v383 "!$0"
    let v388 : UH0 =
        if v384 then
            v379
        else
            let v385 : string = "marginTop"
            let v386 : (string * obj) = v385, v383
            UH0_0(v386, v379)
    let v392 : obj =
        match v36 with
        | US1_0 -> (* None *)
            let v389 : obj = ()
            v389
        | US1_1(v390) -> (* Some *)
            let v391 : obj = v390
            v391
    let v393 : bool = emitJsExpr v392 "!$0"
    let v397 : UH0 =
        if v393 then
            v388
        else
            let v394 : string = "maxHeight"
            let v395 : (string * obj) = v394, v392
            UH0_0(v395, v388)
    let v401 : obj =
        match v37 with
        | US1_0 -> (* None *)
            let v398 : obj = ()
            v398
        | US1_1(v399) -> (* Some *)
            let v400 : obj = v399
            v400
    let v402 : bool = emitJsExpr v401 "!$0"
    let v406 : UH0 =
        if v402 then
            v397
        else
            let v403 : string = "maxWidth"
            let v404 : (string * obj) = v403, v401
            UH0_0(v404, v397)
    let v410 : obj =
        match v38 with
        | US9_0 -> (* None *)
            let v407 : obj = ()
            v407
        | US9_1(v408) -> (* Some *)
            let v409 : obj = v408
            v409
    let v411 : bool = emitJsExpr v410 "!$0"
    let v415 : UH0 =
        if v411 then
            v406
        else
            let v412 : string = "onChange"
            let v413 : (string * obj) = v412, v410
            UH0_0(v413, v406)
    let v419 : obj =
        match v39 with
        | US10_0 -> (* None *)
            let v416 : obj = ()
            v416
        | US10_1(v417) -> (* Some *)
            let v418 : obj = v417
            v418
    let v420 : bool = emitJsExpr v419 "!$0"
    let v424 : UH0 =
        if v420 then
            v415
        else
            let v421 : string = "onClick"
            let v422 : (string * obj) = v421, v419
            UH0_0(v422, v415)
    let v428 : obj =
        match v40 with
        | US9_0 -> (* None *)
            let v425 : obj = ()
            v425
        | US9_1(v426) -> (* Some *)
            let v427 : obj = v426
            v427
    let v429 : bool = emitJsExpr v428 "!$0"
    let v433 : UH0 =
        if v429 then
            v424
        else
            let v430 : string = "onInput"
            let v431 : (string * obj) = v430, v428
            UH0_0(v431, v424)
    let v437 : obj =
        match v41 with
        | US1_0 -> (* None *)
            let v434 : obj = ()
            v434
        | US1_1(v435) -> (* Some *)
            let v436 : obj = v435
            v436
    let v438 : bool = emitJsExpr v437 "!$0"
    let v442 : UH0 =
        if v438 then
            v433
        else
            let v439 : string = "outline"
            let v440 : (string * obj) = v439, v437
            UH0_0(v440, v433)
    let v446 : obj =
        match v42 with
        | US1_0 -> (* None *)
            let v443 : obj = ()
            v443
        | US1_1(v444) -> (* Some *)
            let v445 : obj = v444
            v445
    let v447 : bool = emitJsExpr v446 "!$0"
    let v451 : UH0 =
        if v447 then
            v442
        else
            let v448 : string = "overflowX"
            let v449 : (string * obj) = v448, v446
            UH0_0(v449, v442)
    let v455 : obj =
        match v43 with
        | US1_0 -> (* None *)
            let v452 : obj = ()
            v452
        | US1_1(v453) -> (* Some *)
            let v454 : obj = v453
            v454
    let v456 : bool = emitJsExpr v455 "!$0"
    let v460 : UH0 =
        if v456 then
            v451
        else
            let v457 : string = "overflowY"
            let v458 : (string * obj) = v457, v455
            UH0_0(v458, v451)
    let v464 : obj =
        match v44 with
        | US1_0 -> (* None *)
            let v461 : obj = ()
            v461
        | US1_1(v462) -> (* Some *)
            let v463 : obj = v462
            v463
    let v465 : bool = emitJsExpr v464 "!$0"
    let v469 : UH0 =
        if v465 then
            v460
        else
            let v466 : string = "padding"
            let v467 : (string * obj) = v466, v464
            UH0_0(v467, v460)
    let v473 : obj =
        match v45 with
        | US1_0 -> (* None *)
            let v470 : obj = ()
            v470
        | US1_1(v471) -> (* Some *)
            let v472 : obj = v471
            v472
    let v474 : bool = emitJsExpr v473 "!$0"
    let v478 : UH0 =
        if v474 then
            v469
        else
            let v475 : string = "paddingBottom"
            let v476 : (string * obj) = v475, v473
            UH0_0(v476, v469)
    let v482 : obj =
        match v46 with
        | US1_0 -> (* None *)
            let v479 : obj = ()
            v479
        | US1_1(v480) -> (* Some *)
            let v481 : obj = v480
            v481
    let v483 : bool = emitJsExpr v482 "!$0"
    let v487 : UH0 =
        if v483 then
            v478
        else
            let v484 : string = "paddingLeft"
            let v485 : (string * obj) = v484, v482
            UH0_0(v485, v478)
    let v491 : obj =
        match v47 with
        | US1_0 -> (* None *)
            let v488 : obj = ()
            v488
        | US1_1(v489) -> (* Some *)
            let v490 : obj = v489
            v490
    let v492 : bool = emitJsExpr v491 "!$0"
    let v496 : UH0 =
        if v492 then
            v487
        else
            let v493 : string = "paddingRight"
            let v494 : (string * obj) = v493, v491
            UH0_0(v494, v487)
    let v500 : obj =
        match v48 with
        | US1_0 -> (* None *)
            let v497 : obj = ()
            v497
        | US1_1(v498) -> (* Some *)
            let v499 : obj = v498
            v499
    let v501 : bool = emitJsExpr v500 "!$0"
    let v505 : UH0 =
        if v501 then
            v496
        else
            let v502 : string = "paddingTop"
            let v503 : (string * obj) = v502, v500
            UH0_0(v503, v496)
    let v509 : obj =
        match v49 with
        | US1_0 -> (* None *)
            let v506 : obj = ()
            v506
        | US1_1(v507) -> (* Some *)
            let v508 : obj = v507
            v508
    let v510 : bool = emitJsExpr v509 "!$0"
    let v514 : UH0 =
        if v510 then
            v505
        else
            let v511 : string = "position"
            let v512 : (string * obj) = v511, v509
            UH0_0(v512, v505)
    let v518 : obj =
        match v50 with
        | US1_0 -> (* None *)
            let v515 : obj = ()
            v515
        | US1_1(v516) -> (* Some *)
            let v517 : obj = v516
            v517
    let v519 : bool = emitJsExpr v518 "!$0"
    let v523 : UH0 =
        if v519 then
            v514
        else
            let v520 : string = "right"
            let v521 : (string * obj) = v520, v518
            UH0_0(v521, v514)
    let v527 : obj =
        match v51 with
        | US1_0 -> (* None *)
            let v524 : obj = ()
            v524
        | US1_1(v525) -> (* Some *)
            let v526 : obj = v525
            v526
    let v528 : bool = emitJsExpr v527 "!$0"
    let v532 : UH0 =
        if v528 then
            v523
        else
            let v529 : string = "size"
            let v530 : (string * obj) = v529, v527
            UH0_0(v530, v523)
    let v536 : obj =
        match v52 with
        | US1_0 -> (* None *)
            let v533 : obj = ()
            v533
        | US1_1(v534) -> (* Some *)
            let v535 : obj = v534
            v535
    let v537 : bool = emitJsExpr v536 "!$0"
    let v541 : UH0 =
        if v537 then
            v532
        else
            let v538 : string = "spacing"
            let v539 : (string * obj) = v538, v536
            UH0_0(v539, v532)
    let v545 : obj =
        match v53 with
        | US1_0 -> (* None *)
            let v542 : obj = ()
            v542
        | US1_1(v543) -> (* Some *)
            let v544 : obj = v543
            v544
    let v546 : bool = emitJsExpr v545 "!$0"
    let v550 : UH0 =
        if v546 then
            v541
        else
            let v547 : string = "src"
            let v548 : (string * obj) = v547, v545
            UH0_0(v548, v541)
    let v554 : obj =
        match v54 with
        | US1_0 -> (* None *)
            let v551 : obj = ()
            v551
        | US1_1(v552) -> (* Some *)
            let v553 : obj = v552
            v553
    let v555 : bool = emitJsExpr v554 "!$0"
    let v559 : UH0 =
        if v555 then
            v550
        else
            let v556 : string = "striped"
            let v557 : (string * obj) = v556, v554
            UH0_0(v557, v550)
    let v563 : obj =
        match v55 with
        | US1_0 -> (* None *)
            let v560 : obj = ()
            v560
        | US1_1(v561) -> (* Some *)
            let v562 : obj = v561
            v562
    let v564 : bool = emitJsExpr v563 "!$0"
    let v568 : UH0 =
        if v564 then
            v559
        else
            let v565 : string = "thickness"
            let v566 : (string * obj) = v565, v563
            UH0_0(v566, v559)
    let v572 : obj =
        match v56 with
        | US8_0 -> (* None *)
            let v569 : obj = ()
            v569
        | US8_1(v570) -> (* Some *)
            let v571 : obj = v570
            v571
    let v573 : bool = emitJsExpr v572 "!$0"
    let v577 : UH0 =
        if v573 then
            v568
        else
            let v574 : string = "title"
            let v575 : (string * obj) = v574, v572
            UH0_0(v575, v568)
    let v581 : obj =
        match v57 with
        | US1_0 -> (* None *)
            let v578 : obj = ()
            v578
        | US1_1(v579) -> (* Some *)
            let v580 : obj = v579
            v580
    let v582 : bool = emitJsExpr v581 "!$0"
    let v586 : UH0 =
        if v582 then
            v577
        else
            let v583 : string = "top"
            let v584 : (string * obj) = v583, v581
            UH0_0(v584, v577)
    let v590 : obj =
        match v58 with
        | US1_0 -> (* None *)
            let v587 : obj = ()
            v587
        | US1_1(v588) -> (* Some *)
            let v589 : obj = v588
            v589
    let v591 : bool = emitJsExpr v590 "!$0"
    let v595 : UH0 =
        if v591 then
            v586
        else
            let v592 : string = "type"
            let v593 : (string * obj) = v592, v590
            UH0_0(v593, v586)
    let v599 : obj =
        match v59 with
        | US6_0 -> (* None *)
            let v596 : obj = ()
            v596
        | US6_1(v597) -> (* Some *)
            let v598 : obj = v597
            v598
    let v600 : bool = emitJsExpr v599 "!$0"
    let v604 : UH0 =
        if v600 then
            v595
        else
            let v601 : string = "value"
            let v602 : (string * obj) = v601, v599
            UH0_0(v602, v595)
    let v608 : obj =
        match v60 with
        | US1_0 -> (* None *)
            let v605 : obj = ()
            v605
        | US1_1(v606) -> (* Some *)
            let v607 : obj = v606
            v607
    let v609 : bool = emitJsExpr v608 "!$0"
    let v613 : UH0 =
        if v609 then
            v604
        else
            let v610 : string = "width"
            let v611 : (string * obj) = v610, v608
            UH0_0(v611, v604)
    let v617 : obj =
        match v61 with
        | US0_0 -> (* None *)
            let v614 : obj = ()
            v614
        | US0_1(v615) -> (* Some *)
            let v616 : obj = v615
            v616
    let v618 : bool = emitJsExpr v617 "!$0"
    let v622 : UH0 =
        if v618 then
            v613
        else
            let v619 : string = "zIndex"
            let v620 : (string * obj) = v619, v617
            UH0_0(v620, v613)
    let v626 : obj =
        match v62 with
        | US1_0 -> (* None *)
            let v623 : obj = ()
            v623
        | US1_1(v624) -> (* Some *)
            let v625 : obj = v624
            v625
    let v627 : bool = emitJsExpr v626 "!$0"
    let v631 : UH0 =
        if v627 then
            v622
        else
            let v628 : string = "zoom"
            let v629 : (string * obj) = v628, v626
            UH0_0(v629, v622)
    method7(v631)
and method5 (v0 : US1, v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) : ((string * obj) []) =
    method6(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure7 (v0 : Mut2) () : (JSX.Element []) =
    let v1 : US5 = v0.l10
    let v4 : (unit -> (JSX.Element [])) =
        match v1 with
        | US5_0 -> (* None *)
            closure8()
        | US5_1(v3) -> (* Some *)
            v3
    let v5 : string = "Tbody"
    let v6 : string = "@hope-ui/solid"
    let v7 : JS.Function = import v5 v6
    let struct (v8 : US1, v9 : US1, v10 : US3, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US4, v18 : US5, v19 : US1, v20 : US1, v21 : US4, v22 : US6, v23 : US1, v24 : US1, v25 : US1, v26 : US7, v27 : US4, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US8, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US9, v47 : US10, v48 : US9, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US8, v65 : US1, v66 : US1, v67 : US6, v68 : US1, v69 : US0, v70 : US1) = method4()
    let v71 : string = "$blackAlpha3"
    let v72 : US1 = US1_1(v71)
    let v73 : US5 = US5_1(v4)
    let v74 : string = "flex"
    let v75 : US1 = US1_1(v74)
    let v76 : string = "column"
    let v77 : US1 = US1_1(v76)
    let v78 : string = "-1px"
    let v79 : US1 = US1_1(v78)
    let v80 : ((string * obj) []) = method5(v8, v9, v10, v72, v12, v13, v14, v15, v16, v17, v73, v19, v20, v21, v22, v23, v24, v75, v26, v27, v28, v77, v30, v31, v32, v33, v34, v35, v36, v37, v38, v79, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
    let v81 : obj = createObj v80
    let v82 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v83 : string = "createComponent"
    let v84 : string = "solid-js"
    let v85 : JS.Function = import v83 v84
    let v86 : JSX.Element = v85.Invoke (v82, v81) |> unbox<JSX.Element>
    [|v86|]
and closure6 () (v0 : Mut2) : JSX.Element =
    let v1 : string = "Table"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method4()
    let v67 : US1 = v0.l43
    let v70 : string =
        match v67 with
        | US1_0 -> (* None *)
            let v68 : string = "hidden"
            v68
        | US1_1(v69) -> (* Some *)
            v69
    let v71 : (unit -> (JSX.Element [])) = closure7(v0)
    let v72 : US5 = US5_1(v71)
    let v73 : string = "flex"
    let v74 : US1 = US1_1(v73)
    let v75 : string = "1"
    let v76 : US1 = US1_1(v75)
    let v77 : string = "column"
    let v78 : US1 = US1_1(v77)
    let v79 : string = "hidden"
    let v80 : US1 = US1_1(v79)
    let v81 : US1 = US1_1(v70)
    let v82 : ((string * obj) []) = method5(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v72, v15, v16, v17, v18, v19, v20, v74, v22, v23, v76, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v80, v81, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66)
    let v83 : obj = createObj v82
    let v84 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v85 : string = "createComponent"
    let v86 : string = "solid-js"
    let v87 : JS.Function = import v85 v86
    let v88 : JSX.Element = v87.Invoke (v84, v83) |> unbox<JSX.Element>
    v88
and method10 (v0 : string, v1 : string) : string =
    let v2 : string = {| ``@initial`` = v1; ``@sm`` = v0 |} |> unbox<string>
    v2
and closure14 (v0 : JSX.Element) () : (JSX.Element []) =
    [|v0|]
and closure13 (v0 : JSX.Element) () : (JSX.Element []) =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method4()
    let v67 : (unit -> (JSX.Element [])) = closure14(v0)
    let v68 : US5 = US5_1(v67)
    let v69 : string = "2px"
    let v70 : US1 = US1_1(v69)
    let v71 : ((string * obj) []) = method5(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v68, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v70, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66)
    let v72 : obj = createObj v71
    let v73 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v74 : string = "createComponent"
    let v75 : string = "solid-js"
    let v76 : JS.Function = import v74 v75
    let v77 : JSX.Element = v76.Invoke (v73, v72) |> unbox<JSX.Element>
    [|v77|]
and closure15 (v0 : (bool -> unit)) (v1 : obj) : unit =
    let v2 : bool = v1?target?checked
    v0 v2
    ()
and closure12 (v0 : Mut3, v1 : (bool -> unit), v2 : (unit -> bool), v3 : JSX.Element) () : (JSX.Element []) =
    let v4 : US12 = v0.l2
    let v175 : JSX.Element =
        match v4 with
        | US12_0 -> (* CheckDisabled *)
            let v5 : string = "Checkbox"
            let v6 : string = "@hope-ui/solid"
            let v7 : JS.Function = import v5 v6
            let struct (v8 : US1, v9 : US1, v10 : US3, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US4, v18 : US5, v19 : US1, v20 : US1, v21 : US4, v22 : US6, v23 : US1, v24 : US1, v25 : US1, v26 : US7, v27 : US4, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US8, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US9, v47 : US10, v48 : US9, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US8, v65 : US1, v66 : US1, v67 : US6, v68 : US1, v69 : US0, v70 : US1) = method4()
            let v71 : bool = v2 ()
            let v72 : US4 = US4_1(v71)
            let v73 : (unit -> (JSX.Element [])) = closure13(v3)
            let v74 : US5 = US5_1(v73)
            let v75 : string = "neutral"
            let v76 : US1 = US1_1(v75)
            let v77 : string = "2px"
            let v78 : US1 = US1_1(v77)
            let v79 : (obj -> unit) = closure15(v1)
            let v80 : US9 = US9_1(v79)
            let v81 : string = "sm"
            let v82 : US1 = US1_1(v81)
            let v83 : ((string * obj) []) = method5(v8, v9, v10, v11, v12, v13, v14, v15, v16, v72, v74, v19, v76, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v78, v41, v42, v43, v44, v45, v80, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v82, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
            let v84 : obj = createObj v83
            let v85 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
            "create_native_component -> create_component'" |> ignore
            let v86 : string = "createComponent"
            let v87 : string = "solid-js"
            let v88 : JS.Function = import v86 v87
            let v89 : JSX.Element = v88.Invoke (v85, v84) |> unbox<JSX.Element>
            v89
        | US12_1 -> (* CheckEnabled *)
            let v90 : string = "Checkbox"
            let v91 : string = "@hope-ui/solid"
            let v92 : JS.Function = import v90 v91
            let struct (v93 : US1, v94 : US1, v95 : US3, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US4, v103 : US5, v104 : US1, v105 : US1, v106 : US4, v107 : US6, v108 : US1, v109 : US1, v110 : US1, v111 : US7, v112 : US4, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US8, v119 : US1, v120 : US1, v121 : US1, v122 : US8, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US9, v132 : US10, v133 : US9, v134 : US1, v135 : US1, v136 : US1, v137 : US1, v138 : US1, v139 : US1, v140 : US1, v141 : US1, v142 : US1, v143 : US1, v144 : US1, v145 : US1, v146 : US1, v147 : US1, v148 : US1, v149 : US8, v150 : US1, v151 : US1, v152 : US6, v153 : US1, v154 : US0, v155 : US1) = method4()
            let v156 : bool = v2 ()
            let v157 : US4 = US4_1(v156)
            let v158 : (unit -> (JSX.Element [])) = closure13(v3)
            let v159 : US5 = US5_1(v158)
            let v160 : string = "neutral"
            let v161 : US1 = US1_1(v160)
            let v162 : string = "2px"
            let v163 : US1 = US1_1(v162)
            let v164 : (obj -> unit) = closure15(v1)
            let v165 : US9 = US9_1(v164)
            let v166 : string = "sm"
            let v167 : US1 = US1_1(v166)
            let v168 : ((string * obj) []) = method5(v93, v94, v95, v96, v97, v98, v99, v100, v101, v157, v159, v104, v161, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v163, v126, v127, v128, v129, v130, v165, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v143, v167, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155)
            let v169 : obj = createObj v168
            let v170 : (obj -> JSX.Element) = v92 |> unbox<obj -> JSX.Element>
            "create_native_component -> create_component'" |> ignore
            let v171 : string = "createComponent"
            let v172 : string = "solid-js"
            let v173 : JS.Function = import v171 v172
            let v174 : JSX.Element = v173.Invoke (v170, v169) |> unbox<JSX.Element>
            v174
        | US12_2 -> (* CheckHidden *)
            v3
    [|v175|]
and closure16 () () : (JSX.Element []) =
    let v0 : string = "&nbsp;"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure19 (v0 : (unit -> bool)) () : (obj []) =
    let v1 : bool = v0 ()
    let v2 : obj = v1
    [|v2|]
and closure20 (v0 : (bool -> unit), v1 : (unit -> bool)) () : unit =
    let v2 : bool = v1 ()
    if v2 then
        v0 false
        ()
and closure21 (v0 : Mut1, v1 : JS.Function) (v2 : (Mut1 -> (Mut1 -> unit))) : unit =
    let v3 : ((string * obj) []) = Array.zeroCreate<(string * obj)> (0)
    let v4 : obj = createObj v3
    let v5 : Mut1 = v4 |> unbox
    let v6 : (Mut1 -> unit) = v2 v0
    v6 v5
    let v7 : obj = v5
    v1.Invoke ("set", v7) |> ignore
    ()
and method12 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method11 (v0 : Mut2, v1 : Mut2) : unit =
    let v2 : (string []) = JS.Constructors.Object.keys v0 |> unbox<string[]>
    let v3 : int32 = v2.Length
    let v4 : Mut5 = {l0 = 0} : Mut5
    while method12(v3, v4) do
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
and closure25 () () : (JSX.Element []) =
    [||]
and closure24 () (v0 : Mut2) : JSX.Element =
    let v1 : string = "Button"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method4()
    let struct (v67 : US1, v68 : US1, v69 : US3, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US4, v77 : US5, v78 : US1, v79 : US1, v80 : US4, v81 : US6, v82 : US1, v83 : US1, v84 : US1, v85 : US7, v86 : US4, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US1, v92 : US8, v93 : US1, v94 : US1, v95 : US1, v96 : US8, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US1, v105 : US9, v106 : US10, v107 : US9, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US8, v124 : US1, v125 : US1, v126 : US6, v127 : US1, v128 : US0, v129 : US1) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61, v0.l62
    let v130 : Mut2 = {l0 = v67; l1 = v68; l2 = v69; l3 = v70; l4 = v71; l5 = v72; l6 = v73; l7 = v74; l8 = v75; l9 = v76; l10 = v77; l11 = v78; l12 = v79; l13 = v80; l14 = v81; l15 = v82; l16 = v83; l17 = v84; l18 = v85; l19 = v86; l20 = v87; l21 = v88; l22 = v89; l23 = v90; l24 = v91; l25 = v92; l26 = v93; l27 = v94; l28 = v95; l29 = v96; l30 = v97; l31 = v98; l32 = v99; l33 = v100; l34 = v101; l35 = v102; l36 = v103; l37 = v104; l38 = v105; l39 = v106; l40 = v107; l41 = v108; l42 = v109; l43 = v110; l44 = v111; l45 = v112; l46 = v113; l47 = v114; l48 = v115; l49 = v116; l50 = v117; l51 = v118; l52 = v119; l53 = v120; l54 = v121; l55 = v122; l56 = v123; l57 = v124; l58 = v125; l59 = v126; l60 = v127; l61 = v128; l62 = v129} : Mut2
    let v131 : string = "neutral"
    let v132 : US1 = US1_1(v131)
    let v133 : US4 = US4_1(true)
    let v134 : string = "left"
    let v135 : US1 = US1_1(v134)
    let v136 : string = "xs"
    let v137 : US1 = US1_1(v136)
    let v138 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v132; l13 = v133; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v135; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v137; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65; l62 = v66} : Mut2
    method11(v138, v130)
    let struct (v139 : US1, v140 : US1, v141 : US3, v142 : US1, v143 : US1, v144 : US1, v145 : US1, v146 : US1, v147 : US1, v148 : US4, v149 : US5, v150 : US1, v151 : US1, v152 : US4, v153 : US6, v154 : US1, v155 : US1, v156 : US1, v157 : US7, v158 : US4, v159 : US1, v160 : US1, v161 : US1, v162 : US1, v163 : US1, v164 : US8, v165 : US1, v166 : US1, v167 : US1, v168 : US8, v169 : US1, v170 : US1, v171 : US1, v172 : US1, v173 : US1, v174 : US1, v175 : US1, v176 : US1, v177 : US9, v178 : US10, v179 : US9, v180 : US1, v181 : US1, v182 : US1, v183 : US1, v184 : US1, v185 : US1, v186 : US1, v187 : US1, v188 : US1, v189 : US1, v190 : US1, v191 : US1, v192 : US1, v193 : US1, v194 : US1, v195 : US8, v196 : US1, v197 : US1, v198 : US6, v199 : US1, v200 : US0, v201 : US1) = v138.l0, v138.l1, v138.l2, v138.l3, v138.l4, v138.l5, v138.l6, v138.l7, v138.l8, v138.l9, v138.l10, v138.l11, v138.l12, v138.l13, v138.l14, v138.l15, v138.l16, v138.l17, v138.l18, v138.l19, v138.l20, v138.l21, v138.l22, v138.l23, v138.l24, v138.l25, v138.l26, v138.l27, v138.l28, v138.l29, v138.l30, v138.l31, v138.l32, v138.l33, v138.l34, v138.l35, v138.l36, v138.l37, v138.l38, v138.l39, v138.l40, v138.l41, v138.l42, v138.l43, v138.l44, v138.l45, v138.l46, v138.l47, v138.l48, v138.l49, v138.l50, v138.l51, v138.l52, v138.l53, v138.l54, v138.l55, v138.l56, v138.l57, v138.l58, v138.l59, v138.l60, v138.l61, v138.l62
    let v202 : (unit -> (JSX.Element [])) = closure25()
    let v203 : US5 = US5_1(v202)
    let v204 : ((string * obj) []) = method5(v139, v140, v141, v142, v143, v144, v145, v146, v147, v148, v203, v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201)
    let v205 : obj = createObj v204
    let v206 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v207 : string = "createComponent"
    let v208 : string = "solid-js"
    let v209 : JS.Function = import v207 v208
    let v210 : JSX.Element = v209.Invoke (v206, v205) |> unbox<JSX.Element>
    v210
and closure26 (v0 : (bool -> unit), v1 : Mut4, v2 : Mut1, v3 : JS.Function) () : unit =
    let v4 : US11 = v1.l2
    match v4 with
    | US11_0 -> (* None *)
        ()
    | US11_1(v5) -> (* Some *)
        let v6 : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) = v5 v2
        let v7 : ((Mut1 -> (Mut1 -> unit)) -> unit) = closure21(v2, v3)
        v6 v7
        ()
    v0 true
    ()
and closure27 () () : (JSX.Element []) =
    let v0 : string = "Load"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure23 (v0 : (bool -> unit), v1 : Mut4, v2 : Mut1, v3 : JS.Function) () : (JSX.Element []) =
    let v4 : (Mut2 -> JSX.Element) = closure24()
    let struct (v5 : US1, v6 : US1, v7 : US3, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US4, v15 : US5, v16 : US1, v17 : US1, v18 : US4, v19 : US6, v20 : US1, v21 : US1, v22 : US1, v23 : US7, v24 : US4, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US8, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US9, v44 : US10, v45 : US9, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US8, v62 : US1, v63 : US1, v64 : US6, v65 : US1, v66 : US0, v67 : US1) = method4()
    let v68 : Mut2 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v15; l11 = v16; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v61; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66; l62 = v67} : Mut2
    let v69 : (unit -> unit) = closure26(v0, v1, v2, v3)
    let v70 : US10 = US10_1(v69)
    v68.l39 <- v70
    let struct (v71 : US1, v72 : US1, v73 : US3, v74 : US1, v75 : US1, v76 : US1, v77 : US1, v78 : US1, v79 : US1, v80 : US4, v81 : US5, v82 : US1, v83 : US1, v84 : US4, v85 : US6, v86 : US1, v87 : US1, v88 : US1, v89 : US7, v90 : US4, v91 : US1, v92 : US1, v93 : US1, v94 : US1, v95 : US1, v96 : US8, v97 : US1, v98 : US1, v99 : US1, v100 : US8, v101 : US1, v102 : US1, v103 : US1, v104 : US1, v105 : US1, v106 : US1, v107 : US1, v108 : US1, v109 : US9, v110 : US10, v111 : US9, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US8, v128 : US1, v129 : US1, v130 : US6, v131 : US1, v132 : US0, v133 : US1) = v68.l0, v68.l1, v68.l2, v68.l3, v68.l4, v68.l5, v68.l6, v68.l7, v68.l8, v68.l9, v68.l10, v68.l11, v68.l12, v68.l13, v68.l14, v68.l15, v68.l16, v68.l17, v68.l18, v68.l19, v68.l20, v68.l21, v68.l22, v68.l23, v68.l24, v68.l25, v68.l26, v68.l27, v68.l28, v68.l29, v68.l30, v68.l31, v68.l32, v68.l33, v68.l34, v68.l35, v68.l36, v68.l37, v68.l38, v68.l39, v68.l40, v68.l41, v68.l42, v68.l43, v68.l44, v68.l45, v68.l46, v68.l47, v68.l48, v68.l49, v68.l50, v68.l51, v68.l52, v68.l53, v68.l54, v68.l55, v68.l56, v68.l57, v68.l58, v68.l59, v68.l60, v68.l61, v68.l62
    let v134 : (unit -> (JSX.Element [])) = closure27()
    let v135 : US5 = US5_1(v134)
    emitJsExpr (struct (v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v135, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133), v134) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v136 : US5 = US5_1(v134)
    let v137 : Mut2 = {l0 = v71; l1 = v72; l2 = v73; l3 = v74; l4 = v75; l5 = v76; l6 = v77; l7 = v78; l8 = v79; l9 = v80; l10 = v136; l11 = v82; l12 = v83; l13 = v84; l14 = v85; l15 = v86; l16 = v87; l17 = v88; l18 = v89; l19 = v90; l20 = v91; l21 = v92; l22 = v93; l23 = v94; l24 = v95; l25 = v96; l26 = v97; l27 = v98; l28 = v99; l29 = v100; l30 = v101; l31 = v102; l32 = v103; l33 = v104; l34 = v105; l35 = v106; l36 = v107; l37 = v108; l38 = v109; l39 = v110; l40 = v111; l41 = v112; l42 = v113; l43 = v114; l44 = v115; l45 = v116; l46 = v117; l47 = v118; l48 = v119; l49 = v120; l50 = v121; l51 = v122; l52 = v123; l53 = v124; l54 = v125; l55 = v126; l56 = v127; l57 = v128; l58 = v129; l59 = v130; l60 = v131; l61 = v132; l62 = v133} : Mut2
    let v138 : obj = v137
    let v139 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v140 : string = "createComponent"
    let v141 : string = "solid-js"
    let v142 : JS.Function = import v140 v141
    let v143 : JSX.Element = v142.Invoke (v139, v138) |> unbox<JSX.Element>
    [|v143|]
and closure32 () () : (JSX.Element []) =
    [||]
and closure31 () (v0 : Mut6) : JSX.Element =
    let v1 : string = "Icon"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method4()
    let v67 : (unit -> JS.Function) = v0.l1
    let v68 : JS.Function = v67 ()
    let struct (v69 : US1, v70 : US1, v71 : US3, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US1, v77 : US1, v78 : US4, v79 : US5, v80 : US1, v81 : US1, v82 : US4, v83 : US6, v84 : US1, v85 : US1, v86 : US1, v87 : US7, v88 : US4, v89 : US1, v90 : US1, v91 : US1, v92 : US1, v93 : US1, v94 : US8, v95 : US1, v96 : US1, v97 : US1, v98 : US8, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US1, v105 : US1, v106 : US1, v107 : US9, v108 : US10, v109 : US9, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US8, v126 : US1, v127 : US1, v128 : US6, v129 : US1, v130 : US0, v131 : US1) = method4()
    let v132 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = v0.l0
    let v133 : string = "-12px"
    let v134 : US1 = US1_1(v133)
    let v135 : US1 = US1_1(v133)
    let v136 : string = "0.6"
    let v137 : US1 = US1_1(v136)
    let struct (v138 : US1, v139 : US1, v140 : US3, v141 : US1, v142 : US1, v143 : US1, v144 : US1, v145 : US1, v146 : US1, v147 : US4, v148 : US5, v149 : US1, v150 : US1, v151 : US4, v152 : US6, v153 : US1, v154 : US1, v155 : US1, v156 : US7, v157 : US4, v158 : US1, v159 : US1, v160 : US1, v161 : US1, v162 : US1, v163 : US8, v164 : US1, v165 : US1, v166 : US1, v167 : US8, v168 : US1, v169 : US1, v170 : US1, v171 : US1, v172 : US1, v173 : US1, v174 : US1, v175 : US1, v176 : US9, v177 : US10, v178 : US9, v179 : US1, v180 : US1, v181 : US1, v182 : US1, v183 : US1, v184 : US1, v185 : US1, v186 : US1, v187 : US1, v188 : US1, v189 : US1, v190 : US1, v191 : US1, v192 : US1, v193 : US1, v194 : US8, v195 : US1, v196 : US1, v197 : US6, v198 : US1, v199 : US0, v200 : US1) = v132 struct (v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v134, v103, v135, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v137)
    let v201 : ((string * obj) []) = method5(v138, v139, v140, v141, v142, v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200)
    let v202 : obj = createObj v201
    let v203 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = v0.l2
    let v204 : US3 = US3_1(v68)
    let v205 : US6 = US6_1(v202)
    let v206 : string = "14px"
    let v207 : US1 = US1_1(v206)
    let struct (v208 : US1, v209 : US1, v210 : US3, v211 : US1, v212 : US1, v213 : US1, v214 : US1, v215 : US1, v216 : US1, v217 : US4, v218 : US5, v219 : US1, v220 : US1, v221 : US4, v222 : US6, v223 : US1, v224 : US1, v225 : US1, v226 : US7, v227 : US4, v228 : US1, v229 : US1, v230 : US1, v231 : US1, v232 : US1, v233 : US8, v234 : US1, v235 : US1, v236 : US1, v237 : US8, v238 : US1, v239 : US1, v240 : US1, v241 : US1, v242 : US1, v243 : US1, v244 : US1, v245 : US1, v246 : US9, v247 : US10, v248 : US9, v249 : US1, v250 : US1, v251 : US1, v252 : US1, v253 : US1, v254 : US1, v255 : US1, v256 : US1, v257 : US1, v258 : US1, v259 : US1, v260 : US1, v261 : US1, v262 : US1, v263 : US1, v264 : US8, v265 : US1, v266 : US1, v267 : US6, v268 : US1, v269 : US0, v270 : US1) = v203 struct (v4, v5, v204, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v205, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v207, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66)
    let v271 : (unit -> (JSX.Element [])) = closure32()
    let v272 : US5 = US5_1(v271)
    let v273 : ((string * obj) []) = method5(v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v272, v219, v220, v221, v222, v223, v224, v225, v226, v227, v228, v229, v230, v231, v232, v233, v234, v235, v236, v237, v238, v239, v240, v241, v242, v243, v244, v245, v246, v247, v248, v249, v250, v251, v252, v253, v254, v255, v256, v257, v258, v259, v260, v261, v262, v263, v264, v265, v266, v267, v268, v269, v270)
    let v274 : obj = createObj v273
    let v275 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v276 : string = "createComponent"
    let v277 : string = "solid-js"
    let v278 : JS.Function = import v276 v277
    let v279 : JSX.Element = v278.Invoke (v275, v274) |> unbox<JSX.Element>
    v279
and closure33 () struct (v0 : US1, v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) : struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) =
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure34 () () : JS.Function =
    let v0 : string = "BiRegularRefresh"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure35 () () : (JSX.Element []) =
    [||]
and closure36 (v0 : (bool -> unit)) () : unit =
    v0 true
    ()
and closure37 () () : JS.Function =
    let v0 : string = "BiRegularDownArrow"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure38 () () : JS.Function =
    let v0 : string = "BiRegularUpArrow"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure39 () () : (JSX.Element []) =
    [||]
and closure40 (v0 : Mut1, v1 : JS.Function, v2 : int32, v3 : (bool -> unit), v4 : (unit -> bool)) () : unit =
    let v5 : bool = v4 ()
    let v6 : bool = v5 = false
    v3 v6
    let v7 : ((string * obj) []) = Array.zeroCreate<(string * obj)> (0)
    let v8 : obj = createObj v7
    let v9 : Mut1 = v8 |> unbox
    let v12 : US0 =
        if v6 then
            US0_1(v2)
        else
            US0_0
    v9.l9 <- v12
    let v13 : obj = v9
    v1.Invoke ("set", v13) |> ignore
    ()
and closure41 () () : JS.Function =
    let v0 : string = "BiRegularUndo"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure42 () () : (JSX.Element []) =
    [||]
and closure43 (v0 : (bool -> unit)) () : unit =
    v0 false
    ()
and closure30 (v0 : Mut1, v1 : JS.Function, v2 : int32, v3 : (bool -> unit), v4 : (bool -> unit), v5 : (bool -> unit), v6 : (unit -> bool)) () : (JSX.Element []) =
    let v7 : string = "IconButton"
    let v8 : string = "@hope-ui/solid"
    let v9 : JS.Function = import v7 v8
    let struct (v10 : US1, v11 : US1, v12 : US3, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US1, v18 : US1, v19 : US4, v20 : US5, v21 : US1, v22 : US1, v23 : US4, v24 : US6, v25 : US1, v26 : US1, v27 : US1, v28 : US7, v29 : US4, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US8, v36 : US1, v37 : US1, v38 : US1, v39 : US8, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US9, v49 : US10, v50 : US9, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US8, v67 : US1, v68 : US1, v69 : US6, v70 : US1, v71 : US0, v72 : US1) = method4()
    let v73 : (Mut6 -> JSX.Element) = closure31()
    let v74 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = closure33()
    let v75 : (unit -> JS.Function) = closure34()
    let v76 : Mut6 = {l0 = v74; l1 = v75; l2 = v74} : Mut6
    let v77 : obj = v76
    let v78 : (obj -> JSX.Element) = v73 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v79 : string = "createComponent"
    let v80 : string = "solid-js"
    let v81 : JS.Function = import v79 v80
    let v82 : JSX.Element = v81.Invoke (v78, v77) |> unbox<JSX.Element>
    let v83 : string = "Refresh"
    let v84 : US1 = US1_1(v83)
    let v85 : (unit -> (JSX.Element [])) = closure35()
    let v86 : US5 = US5_1(v85)
    let v87 : string = "neutral"
    let v88 : US1 = US1_1(v87)
    let v89 : string = "20px"
    let v90 : US1 = US1_1(v89)
    let v91 : US8 = US8_1(v82)
    let v92 : (unit -> unit) = closure36(v4)
    let v93 : US10 = US10_1(v92)
    let v94 : string = "xs"
    let v95 : US1 = US1_1(v94)
    let v96 : ((string * obj) []) = method5(v10, v84, v12, v13, v14, v15, v16, v17, v18, v19, v86, v21, v88, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v90, v34, v91, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v93, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v95, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v97 : obj = createObj v96
    let v98 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v99 : JS.Function = import v79 v80
    let v100 : JSX.Element = v99.Invoke (v98, v97) |> unbox<JSX.Element>
    let v101 : JS.Function = import v7 v8
    let struct (v102 : US1, v103 : US1, v104 : US3, v105 : US1, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US4, v112 : US5, v113 : US1, v114 : US1, v115 : US4, v116 : US6, v117 : US1, v118 : US1, v119 : US1, v120 : US7, v121 : US4, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US8, v128 : US1, v129 : US1, v130 : US1, v131 : US8, v132 : US1, v133 : US1, v134 : US1, v135 : US1, v136 : US1, v137 : US1, v138 : US1, v139 : US1, v140 : US9, v141 : US10, v142 : US9, v143 : US1, v144 : US1, v145 : US1, v146 : US1, v147 : US1, v148 : US1, v149 : US1, v150 : US1, v151 : US1, v152 : US1, v153 : US1, v154 : US1, v155 : US1, v156 : US1, v157 : US1, v158 : US8, v159 : US1, v160 : US1, v161 : US6, v162 : US1, v163 : US0, v164 : US1) = method4()
    let v165 : bool = v6 ()
    let v168 : string =
        if v165 then
            let v166 : string = "Restore"
            v166
        else
            let v167 : string = "Maximize"
            v167
    let v169 : bool = v6 ()
    let v172 : (unit -> JS.Function) =
        if v169 then
            closure37()
        else
            closure38()
    let v173 : Mut6 = {l0 = v74; l1 = v172; l2 = v74} : Mut6
    let v174 : obj = v173
    let v175 : (obj -> JSX.Element) = v73 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v176 : JS.Function = import v79 v80
    let v177 : JSX.Element = v176.Invoke (v175, v174) |> unbox<JSX.Element>
    let v178 : US1 = US1_1(v168)
    let v179 : (unit -> (JSX.Element [])) = closure39()
    let v180 : US5 = US5_1(v179)
    let v181 : US1 = US1_1(v87)
    let v182 : US1 = US1_1(v89)
    let v183 : US8 = US8_1(v177)
    let v184 : (unit -> unit) = closure40(v0, v1, v2, v5, v6)
    let v185 : US10 = US10_1(v184)
    let v186 : US1 = US1_1(v94)
    let v187 : ((string * obj) []) = method5(v102, v178, v104, v105, v106, v107, v108, v109, v110, v111, v180, v113, v181, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v182, v126, v183, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v185, v142, v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v186, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164)
    let v188 : obj = createObj v187
    let v189 : (obj -> JSX.Element) = v101 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v190 : JS.Function = import v79 v80
    let v191 : JSX.Element = v190.Invoke (v189, v188) |> unbox<JSX.Element>
    let v192 : JS.Function = import v7 v8
    let struct (v193 : US1, v194 : US1, v195 : US3, v196 : US1, v197 : US1, v198 : US1, v199 : US1, v200 : US1, v201 : US1, v202 : US4, v203 : US5, v204 : US1, v205 : US1, v206 : US4, v207 : US6, v208 : US1, v209 : US1, v210 : US1, v211 : US7, v212 : US4, v213 : US1, v214 : US1, v215 : US1, v216 : US1, v217 : US1, v218 : US8, v219 : US1, v220 : US1, v221 : US1, v222 : US8, v223 : US1, v224 : US1, v225 : US1, v226 : US1, v227 : US1, v228 : US1, v229 : US1, v230 : US1, v231 : US9, v232 : US10, v233 : US9, v234 : US1, v235 : US1, v236 : US1, v237 : US1, v238 : US1, v239 : US1, v240 : US1, v241 : US1, v242 : US1, v243 : US1, v244 : US1, v245 : US1, v246 : US1, v247 : US1, v248 : US1, v249 : US8, v250 : US1, v251 : US1, v252 : US6, v253 : US1, v254 : US0, v255 : US1) = method4()
    let v256 : (unit -> JS.Function) = closure41()
    let v257 : Mut6 = {l0 = v74; l1 = v256; l2 = v74} : Mut6
    let v258 : obj = v257
    let v259 : (obj -> JSX.Element) = v73 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v260 : JS.Function = import v79 v80
    let v261 : JSX.Element = v260.Invoke (v259, v258) |> unbox<JSX.Element>
    let v262 : string = "Unload"
    let v263 : US1 = US1_1(v262)
    let v264 : (unit -> (JSX.Element [])) = closure42()
    let v265 : US5 = US5_1(v264)
    let v266 : US1 = US1_1(v87)
    let v267 : US1 = US1_1(v89)
    let v268 : US8 = US8_1(v261)
    let v269 : (unit -> unit) = closure43(v3)
    let v270 : US10 = US10_1(v269)
    let v271 : US1 = US1_1(v94)
    let v272 : ((string * obj) []) = method5(v193, v263, v195, v196, v197, v198, v199, v200, v201, v202, v265, v204, v266, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v267, v217, v268, v219, v220, v221, v222, v223, v224, v225, v226, v227, v228, v229, v230, v231, v270, v233, v234, v235, v236, v237, v238, v239, v240, v241, v242, v243, v271, v245, v246, v247, v248, v249, v250, v251, v252, v253, v254, v255)
    let v273 : obj = createObj v272
    let v274 : (obj -> JSX.Element) = v192 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v275 : JS.Function = import v79 v80
    let v276 : JSX.Element = v275.Invoke (v274, v273) |> unbox<JSX.Element>
    [|v100; v191; v276|]
and closure29 (v0 : Mut1, v1 : JS.Function, v2 : int32, v3 : (bool -> unit), v4 : (bool -> unit), v5 : (unit -> bool), v6 : (bool -> unit), v7 : (unit -> bool), v8 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v9 : string = "Stack"
    let v10 : string = "@hope-ui/solid"
    let v11 : JS.Function = import v9 v10
    let struct (v12 : US1, v13 : US1, v14 : US3, v15 : US1, v16 : US1, v17 : US1, v18 : US1, v19 : US1, v20 : US1, v21 : US4, v22 : US5, v23 : US1, v24 : US1, v25 : US4, v26 : US6, v27 : US1, v28 : US1, v29 : US1, v30 : US7, v31 : US4, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US8, v38 : US1, v39 : US1, v40 : US1, v41 : US8, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US9, v51 : US10, v52 : US9, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US1, v67 : US1, v68 : US8, v69 : US1, v70 : US1, v71 : US6, v72 : US1, v73 : US0, v74 : US1) = method4()
    let v75 : US0 = v0.l9
    let v84 : US1 =
        match v75 with
        | US0_0 -> (* None *)
            US1_0
        | US0_1(v77) -> (* Some *)
            let v78 : bool = v77 = v2
            let v79 : bool = v78 <> true
            if v79 then
                let v80 : string = "none"
                US1_1(v80)
            else
                US1_0
    let v85 : (unit -> (JSX.Element [])) = closure30(v0, v1, v2, v3, v4, v6, v7)
    let v86 : US5 = US5_1(v85)
    let v87 : string = "row"
    let v88 : US1 = US1_1(v87)
    let v89 : string = "absolute"
    let v90 : US1 = US1_1(v89)
    let v91 : string = "6px"
    let v92 : US1 = US1_1(v91)
    let v93 : string = "3px"
    let v94 : US1 = US1_1(v93)
    let v95 : US1 = US1_1(v91)
    let v96 : int32 = 1
    let v97 : US0 = US0_1(v96)
    let v98 : ((string * obj) []) = method5(v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v86, v23, v24, v25, v26, v27, v88, v84, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v90, v92, v63, v94, v65, v66, v67, v68, v95, v70, v71, v72, v97, v74)
    let v99 : obj = createObj v98
    let v100 : (obj -> JSX.Element) = v11 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v101 : string = "createComponent"
    let v102 : string = "solid-js"
    let v103 : JS.Function = import v101 v102
    let v104 : JSX.Element = v103.Invoke (v100, v99) |> unbox<JSX.Element>
    let v105 : bool = v5 ()
    let v108 : JSX.Element =
        if v105 then
            let v106 : JSX.Element = Html.fragment []
            v106
        else
            let v107 : JSX.Element = v8 |> unbox<JSX.Element>
            v107
    [|v104; v108|]
and closure28 (v0 : Mut2, v1 : Mut1, v2 : JS.Function, v3 : int32, v4 : (bool -> unit), v5 : (bool -> unit), v6 : (unit -> bool), v7 : (bool -> unit), v8 : (unit -> bool)) () : (JSX.Element []) =
    let v9 : US5 = v0.l10
    let v98 : JSX.Element =
        match v9 with
        | US5_0 -> (* None *)
            let v10 : JSX.Element = Html.fragment []
            v10
        | US5_1(v11) -> (* Some *)
            let v12 : string = "Box"
            let v13 : string = "@hope-ui/solid"
            let v14 : JS.Function = import v12 v13
            let struct (v15 : US1, v16 : US1, v17 : US3, v18 : US1, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US4, v25 : US5, v26 : US1, v27 : US1, v28 : US4, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US7, v34 : US4, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US8, v41 : US1, v42 : US1, v43 : US1, v44 : US8, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US9, v54 : US10, v55 : US9, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US1, v67 : US1, v68 : US1, v69 : US1, v70 : US1, v71 : US8, v72 : US1, v73 : US1, v74 : US6, v75 : US1, v76 : US0, v77 : US1) = method4()
            let v78 : US0 = v1.l9
            let v80 : bool =
                match v78 with
                | US0_0 -> (* None *)
                    true
                | _ ->
                    false
            let v84 : US1 =
                if v80 then
                    let v81 : string = "relative"
                    US1_1(v81)
                else
                    US1_0
            let v85 : (unit -> (JSX.Element [])) = closure29(v1, v2, v3, v4, v5, v6, v7, v8, v11)
            let v86 : US5 = US5_1(v85)
            let v87 : string = "flex"
            let v88 : US1 = US1_1(v87)
            let v89 : string = "1"
            let v90 : US1 = US1_1(v89)
            let v91 : ((string * obj) []) = method5(v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v86, v26, v27, v28, v29, v30, v31, v88, v33, v34, v90, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v84, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77)
            let v92 : obj = createObj v91
            let v93 : (obj -> JSX.Element) = v14 |> unbox<obj -> JSX.Element>
            "create_native_component -> create_component'" |> ignore
            let v94 : string = "createComponent"
            let v95 : string = "solid-js"
            let v96 : JS.Function = import v94 v95
            let v97 : JSX.Element = v96.Invoke (v93, v92) |> unbox<JSX.Element>
            v97
    [|v98|]
and closure22 (v0 : Mut2, v1 : Mut1, v2 : JS.Function, v3 : int32, v4 : (bool -> unit), v5 : (unit -> bool), v6 : (bool -> unit), v7 : (unit -> bool), v8 : (bool -> unit), v9 : (unit -> bool), v10 : Mut4) () : (JSX.Element []) =
    let v11 : bool = v5 ()
    let v12 : bool = v11 = false
    let v203 : JSX.Element =
        if v12 then
            let v13 : string = "Box"
            let v14 : string = "@hope-ui/solid"
            let v15 : JS.Function = import v13 v14
            let struct (v16 : US1, v17 : US1, v18 : US3, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US4, v26 : US5, v27 : US1, v28 : US1, v29 : US4, v30 : US6, v31 : US1, v32 : US1, v33 : US1, v34 : US7, v35 : US4, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US8, v42 : US1, v43 : US1, v44 : US1, v45 : US8, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US9, v55 : US10, v56 : US9, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US1, v67 : US1, v68 : US1, v69 : US1, v70 : US1, v71 : US1, v72 : US8, v73 : US1, v74 : US1, v75 : US6, v76 : US1, v77 : US0, v78 : US1) = method4()
            let v79 : (unit -> (JSX.Element [])) = closure23(v4, v10, v1, v2)
            let v80 : US5 = US5_1(v79)
            let v81 : string = "3px 0"
            let v82 : US1 = US1_1(v81)
            let v83 : ((string * obj) []) = method5(v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v80, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v82, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78)
            let v84 : obj = createObj v83
            let v85 : (obj -> JSX.Element) = v15 |> unbox<obj -> JSX.Element>
            "create_native_component -> create_component'" |> ignore
            let v86 : string = "createComponent"
            let v87 : string = "solid-js"
            let v88 : JS.Function = import v86 v87
            let v89 : JSX.Element = v88.Invoke (v85, v84) |> unbox<JSX.Element>
            v89
        else
            let v90 : string = "Box"
            let v91 : string = "@hope-ui/solid"
            let v92 : JS.Function = import v90 v91
            let struct (v93 : US1, v94 : US1, v95 : US3, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US4, v103 : US5, v104 : US1, v105 : US1, v106 : US4, v107 : US6, v108 : US1, v109 : US1, v110 : US1, v111 : US7, v112 : US4, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US8, v119 : US1, v120 : US1, v121 : US1, v122 : US8, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US9, v132 : US10, v133 : US9, v134 : US1, v135 : US1, v136 : US1, v137 : US1, v138 : US1, v139 : US1, v140 : US1, v141 : US1, v142 : US1, v143 : US1, v144 : US1, v145 : US1, v146 : US1, v147 : US1, v148 : US1, v149 : US8, v150 : US1, v151 : US1, v152 : US6, v153 : US1, v154 : US0, v155 : US1) = method4()
            let v156 : bool = v9 ()
            let v159 : US0 =
                if v156 then
                    US0_1(1)
                else
                    US0_0
            let v160 : bool = v9 ()
            let v164 : US1 =
                if v160 then
                    let v161 : string = "absolute"
                    US1_1(v161)
                else
                    US1_0
            let v165 : bool = v9 ()
            let v169 : US1 =
                if v165 then
                    let v166 : string = "0"
                    US1_1(v166)
                else
                    US1_0
            let v170 : bool = v9 ()
            let v174 : US1 =
                if v170 then
                    let v171 : string = "0"
                    US1_1(v171)
                else
                    US1_0
            let v175 : bool = v9 ()
            let v179 : US1 =
                if v175 then
                    let v176 : string = "0"
                    US1_1(v176)
                else
                    US1_0
            let v180 : bool = v9 ()
            let v184 : US1 =
                if v180 then
                    let v181 : string = "0"
                    US1_1(v181)
                else
                    US1_0
            let v185 : bool = v9 ()
            let v189 : US1 =
                if v185 then
                    let v186 : string = "$bg"
                    US1_1(v186)
                else
                    US1_0
            let v190 : (unit -> (JSX.Element [])) = closure28(v0, v1, v2, v3, v4, v6, v7, v8, v9)
            let v191 : US5 = US5_1(v190)
            let v192 : string = "flex"
            let v193 : US1 = US1_1(v192)
            let v194 : string = "1"
            let v195 : US1 = US1_1(v194)
            let v196 : ((string * obj) []) = method5(v93, v94, v95, v189, v97, v98, v99, v100, v179, v102, v191, v104, v105, v106, v107, v108, v109, v193, v111, v112, v195, v114, v115, v116, v117, v118, v119, v120, v184, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v164, v174, v144, v145, v146, v147, v148, v149, v169, v151, v152, v153, v159, v155)
            let v197 : obj = createObj v196
            let v198 : (obj -> JSX.Element) = v92 |> unbox<obj -> JSX.Element>
            "create_native_component -> create_component'" |> ignore
            let v199 : string = "createComponent"
            let v200 : string = "solid-js"
            let v201 : JS.Function = import v199 v200
            let v202 : JSX.Element = v201.Invoke (v198, v197) |> unbox<JSX.Element>
            v202
    [|v203|]
and closure18 () (v0 : Mut4) : JSX.Element =
    let v1 : Mut2 = v0.l3
    let v2 : string = "useStoreon"
    let v3 : string = "@storeon/solidjs"
    let v4 : JS.Function = import v2 v3
    let v5 : (JS.Function []) = v4.Invoke () |> unbox<JS.Function[]>
    let v6 : Mut1 = v5.[0] |> unbox
    let v7 : JS.Function = v5.[1] |> unbox
    let v8 : int32 = Random().Next ()
    let v9 : bool = v0.l0
    let v10 : string = "createSignal"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : (JS.Function []) = v12.Invoke v9 |> unbox<JS.Function[]>
    let v14 : (unit -> bool) = v13.[0] |> unbox
    let v15 : (bool -> unit) = v13.[1] |> unbox
    let v16 : JS.Function = import v10 v11
    let v17 : (JS.Function []) = v16.Invoke false |> unbox<JS.Function[]>
    let v18 : (unit -> bool) = v17.[0] |> unbox
    let v19 : (bool -> unit) = v17.[1] |> unbox
    let v20 : bool = v0.l1
    let v21 : JS.Function = import v10 v11
    let v22 : (JS.Function []) = v21.Invoke v20 |> unbox<JS.Function[]>
    let v23 : (unit -> bool) = v22.[0] |> unbox
    let v24 : (bool -> unit) = v22.[1] |> unbox
    let v25 : string = "on"
    let v26 : JS.Function = import v25 v11
    let v27 : (unit -> (obj [])) = closure19(v18)
    let v28 : (unit -> unit) = closure20(v19, v18)
    let v29 : JS.Function = v26.Invoke (v27, v28) |> unbox<JS.Function>
    let v30 : string = "createEffect"
    let v31 : JS.Function = import v30 v11
    v31.Invoke v29 |> ignore
    let v32 : bool = v0.l0
    let v33 : bool = v32 = true
    if v33 then
        let v34 : US11 = v0.l2
        match v34 with
        | US11_0 -> (* None *)
            ()
        | US11_1(v35) -> (* Some *)
            let v36 : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) = v35 v6
            let v37 : ((Mut1 -> (Mut1 -> unit)) -> unit) = closure21(v6, v7)
            v36 v37
            ()
    let v38 : string = "Box"
    let v39 : string = "@hope-ui/solid"
    let v40 : JS.Function = import v38 v39
    let struct (v41 : US1, v42 : US1, v43 : US3, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US4, v51 : US5, v52 : US1, v53 : US1, v54 : US4, v55 : US6, v56 : US1, v57 : US1, v58 : US1, v59 : US7, v60 : US4, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US8, v67 : US1, v68 : US1, v69 : US1, v70 : US8, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US1, v77 : US1, v78 : US1, v79 : US9, v80 : US10, v81 : US9, v82 : US1, v83 : US1, v84 : US1, v85 : US1, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US1, v92 : US1, v93 : US1, v94 : US1, v95 : US1, v96 : US1, v97 : US8, v98 : US1, v99 : US1, v100 : US6, v101 : US1, v102 : US0, v103 : US1) = method4()
    let v104 : US1 = v1.l26
    let v105 : (unit -> (JSX.Element [])) = closure22(v1, v6, v7, v8, v15, v14, v19, v18, v24, v23, v0)
    let v106 : US5 = US5_1(v105)
    let v107 : string = "flex"
    let v108 : US1 = US1_1(v107)
    let v109 : string = "1"
    let v110 : US1 = US1_1(v109)
    let v111 : ((string * obj) []) = method5(v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v106, v52, v53, v54, v55, v56, v57, v108, v59, v60, v110, v62, v63, v64, v65, v66, v104, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103)
    let v112 : obj = createObj v111
    let v113 : (obj -> JSX.Element) = v40 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v114 : string = "createComponent"
    let v115 : JS.Function = import v114 v11
    let v116 : JSX.Element = v115.Invoke (v113, v112) |> unbox<JSX.Element>
    v116
and closure17 (v0 : Mut3, v1 : (unit -> bool), v2 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v3 : US12 = v0.l2
    let v159 : JSX.Element =
        match v3 with
        | US12_0 -> (* CheckDisabled *)
            let v4 : bool = v1 ()
            if v4 then
                let v5 : (Mut4 -> JSX.Element) = closure18()
                let v6 : US11 = v0.l0
                let struct (v7 : US1, v8 : US1, v9 : US3, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US4, v17 : US5, v18 : US1, v19 : US1, v20 : US4, v21 : US6, v22 : US1, v23 : US1, v24 : US1, v25 : US7, v26 : US4, v27 : US1, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US8, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US9, v46 : US10, v47 : US9, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US8, v64 : US1, v65 : US1, v66 : US6, v67 : US1, v68 : US0, v69 : US1) = method4()
                let v70 : US5 = US5_1(v2)
                let v71 : Mut2 = {l0 = v7; l1 = v8; l2 = v9; l3 = v10; l4 = v11; l5 = v12; l6 = v13; l7 = v14; l8 = v15; l9 = v16; l10 = v70; l11 = v18; l12 = v19; l13 = v20; l14 = v21; l15 = v22; l16 = v23; l17 = v24; l18 = v25; l19 = v26; l20 = v27; l21 = v28; l22 = v29; l23 = v30; l24 = v31; l25 = v32; l26 = v33; l27 = v34; l28 = v35; l29 = v36; l30 = v37; l31 = v38; l32 = v39; l33 = v40; l34 = v41; l35 = v42; l36 = v43; l37 = v44; l38 = v45; l39 = v46; l40 = v47; l41 = v48; l42 = v49; l43 = v50; l44 = v51; l45 = v52; l46 = v53; l47 = v54; l48 = v55; l49 = v56; l50 = v57; l51 = v58; l52 = v59; l53 = v60; l54 = v61; l55 = v62; l56 = v63; l57 = v64; l58 = v65; l59 = v66; l60 = v67; l61 = v68; l62 = v69} : Mut2
                let v72 : Mut4 = {l0 = true; l1 = false; l2 = v6; l3 = v71} : Mut4
                let v73 : obj = v72
                let v74 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
                "create_custom_component -> create_component'" |> ignore
                let v75 : string = "createComponent"
                let v76 : string = "solid-js"
                let v77 : JS.Function = import v75 v76
                let v78 : JSX.Element = v77.Invoke (v74, v73) |> unbox<JSX.Element>
                v78
            else
                let v79 : JSX.Element = Html.fragment []
                v79
        | US12_1 -> (* CheckEnabled *)
            let v81 : bool = v1 ()
            if v81 then
                let v82 : (Mut4 -> JSX.Element) = closure18()
                let v83 : US11 = v0.l0
                let struct (v84 : US1, v85 : US1, v86 : US3, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US1, v92 : US1, v93 : US4, v94 : US5, v95 : US1, v96 : US1, v97 : US4, v98 : US6, v99 : US1, v100 : US1, v101 : US1, v102 : US7, v103 : US4, v104 : US1, v105 : US1, v106 : US1, v107 : US1, v108 : US1, v109 : US8, v110 : US1, v111 : US1, v112 : US1, v113 : US8, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US9, v123 : US10, v124 : US9, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US1, v136 : US1, v137 : US1, v138 : US1, v139 : US1, v140 : US8, v141 : US1, v142 : US1, v143 : US6, v144 : US1, v145 : US0, v146 : US1) = method4()
                let v147 : US5 = US5_1(v2)
                let v148 : Mut2 = {l0 = v84; l1 = v85; l2 = v86; l3 = v87; l4 = v88; l5 = v89; l6 = v90; l7 = v91; l8 = v92; l9 = v93; l10 = v147; l11 = v95; l12 = v96; l13 = v97; l14 = v98; l15 = v99; l16 = v100; l17 = v101; l18 = v102; l19 = v103; l20 = v104; l21 = v105; l22 = v106; l23 = v107; l24 = v108; l25 = v109; l26 = v110; l27 = v111; l28 = v112; l29 = v113; l30 = v114; l31 = v115; l32 = v116; l33 = v117; l34 = v118; l35 = v119; l36 = v120; l37 = v121; l38 = v122; l39 = v123; l40 = v124; l41 = v125; l42 = v126; l43 = v127; l44 = v128; l45 = v129; l46 = v130; l47 = v131; l48 = v132; l49 = v133; l50 = v134; l51 = v135; l52 = v136; l53 = v137; l54 = v138; l55 = v139; l56 = v140; l57 = v141; l58 = v142; l59 = v143; l60 = v144; l61 = v145; l62 = v146} : Mut2
                let v149 : Mut4 = {l0 = true; l1 = false; l2 = v83; l3 = v148} : Mut4
                let v150 : obj = v149
                let v151 : (obj -> JSX.Element) = v82 |> unbox<obj -> JSX.Element>
                "create_custom_component -> create_component'" |> ignore
                let v152 : string = "createComponent"
                let v153 : string = "solid-js"
                let v154 : JS.Function = import v152 v153
                let v155 : JSX.Element = v154.Invoke (v151, v150) |> unbox<JSX.Element>
                v155
            else
                let v156 : JSX.Element = Html.fragment []
                v156
        | US12_2 -> (* CheckHidden *)
            let v158 : JSX.Element = v2 |> unbox<JSX.Element>
            v158
    [|v159|]
and closure11 (v0 : Mut3, v1 : Mut2, v2 : (bool -> unit), v3 : (unit -> bool)) () : (JSX.Element []) =
    let v4 : US8 = v1.l56
    let v105 : JSX.Element =
        match v4 with
        | US8_0 -> (* None *)
            let v5 : JSX.Element = Html.fragment []
            v5
        | US8_1(v6) -> (* Some *)
            let v7 : string = "Td"
            let v8 : string = "@hope-ui/solid"
            let v9 : JS.Function = import v7 v8
            let struct (v10 : US1, v11 : US1, v12 : US3, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US1, v18 : US1, v19 : US4, v20 : US5, v21 : US1, v22 : US1, v23 : US4, v24 : US6, v25 : US1, v26 : US1, v27 : US1, v28 : US7, v29 : US4, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US8, v36 : US1, v37 : US1, v38 : US1, v39 : US8, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US9, v49 : US10, v50 : US9, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US8, v67 : US1, v68 : US1, v69 : US6, v70 : US1, v71 : US0, v72 : US1) = method4()
            let v73 : US12 = v0.l2
            let v75 : bool =
                match v73 with
                | US12_2 -> (* CheckHidden *)
                    true
                | _ ->
                    false
            let v77 : bool =
                if v75 then
                    true
                else
                    let v76 : bool = v3 ()
                    v76
            let v82 : string =
                if v77 then
                    let v78 : string = "2px !important"
                    let v79 : string = "0px !important"
                    method10(v79, v78)
                else
                    let v81 : string = "0px !important"
                    v81
            let v83 : US1 = US1_1(v82)
            let v84 : string = "$neutral5"
            let v85 : US1 = US1_1(v84)
            let v86 : (unit -> (JSX.Element [])) = closure12(v0, v2, v3, v6)
            let v87 : US5 = US5_1(v86)
            let v88 : string = "$neutral9"
            let v89 : US1 = US1_1(v88)
            let v90 : string = "flex"
            let v91 : US1 = US1_1(v90)
            let v92 : string = "column"
            let v93 : US1 = US1_1(v92)
            let v94 : string = "$sm"
            let v95 : US1 = US1_1(v94)
            let v96 : string = "3px 20px 0 8px"
            let v97 : US1 = US1_1(v96)
            let v98 : ((string * obj) []) = method5(v10, v11, v12, v13, v14, v83, v85, v17, v18, v19, v87, v89, v22, v23, v24, v25, v26, v91, v28, v29, v30, v93, v95, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v97, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
            let v99 : obj = createObj v98
            let v100 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
            "create_native_component -> create_component'" |> ignore
            let v101 : string = "createComponent"
            let v102 : string = "solid-js"
            let v103 : JS.Function = import v101 v102
            let v104 : JSX.Element = v103.Invoke (v100, v99) |> unbox<JSX.Element>
            v104
    let v106 : US5 = v1.l10
    let v286 : JSX.Element =
        match v106 with
        | US5_0 -> (* None *)
            let v107 : string = "Td"
            let v108 : string = "@hope-ui/solid"
            let v109 : JS.Function = import v107 v108
            let struct (v110 : US1, v111 : US1, v112 : US3, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US4, v120 : US5, v121 : US1, v122 : US1, v123 : US4, v124 : US6, v125 : US1, v126 : US1, v127 : US1, v128 : US7, v129 : US4, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US8, v136 : US1, v137 : US1, v138 : US1, v139 : US8, v140 : US1, v141 : US1, v142 : US1, v143 : US1, v144 : US1, v145 : US1, v146 : US1, v147 : US1, v148 : US9, v149 : US10, v150 : US9, v151 : US1, v152 : US1, v153 : US1, v154 : US1, v155 : US1, v156 : US1, v157 : US1, v158 : US1, v159 : US1, v160 : US1, v161 : US1, v162 : US1, v163 : US1, v164 : US1, v165 : US1, v166 : US8, v167 : US1, v168 : US1, v169 : US6, v170 : US1, v171 : US0, v172 : US1) = method4()
            let v173 : string = "0"
            let v174 : US1 = US1_1(v173)
            let v175 : (unit -> (JSX.Element [])) = closure16()
            let v176 : US5 = US5_1(v175)
            let v177 : string = "9px"
            let v178 : US1 = US1_1(v177)
            let v179 : US1 = US1_1(v173)
            let v180 : ((string * obj) []) = method5(v110, v111, v112, v113, v174, v115, v116, v117, v118, v119, v176, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v178, v141, v142, v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v179, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172)
            let v181 : obj = createObj v180
            let v182 : (obj -> JSX.Element) = v109 |> unbox<obj -> JSX.Element>
            "create_native_component -> create_component'" |> ignore
            let v183 : string = "createComponent"
            let v184 : string = "solid-js"
            let v185 : JS.Function = import v183 v184
            let v186 : JSX.Element = v185.Invoke (v182, v181) |> unbox<JSX.Element>
            v186
        | US5_1(v187) -> (* Some *)
            let v188 : string = "Td"
            let v189 : string = "@hope-ui/solid"
            let v190 : JS.Function = import v188 v189
            let struct (v191 : US1, v192 : US1, v193 : US3, v194 : US1, v195 : US1, v196 : US1, v197 : US1, v198 : US1, v199 : US1, v200 : US4, v201 : US5, v202 : US1, v203 : US1, v204 : US4, v205 : US6, v206 : US1, v207 : US1, v208 : US1, v209 : US7, v210 : US4, v211 : US1, v212 : US1, v213 : US1, v214 : US1, v215 : US1, v216 : US8, v217 : US1, v218 : US1, v219 : US1, v220 : US8, v221 : US1, v222 : US1, v223 : US1, v224 : US1, v225 : US1, v226 : US1, v227 : US1, v228 : US1, v229 : US9, v230 : US10, v231 : US9, v232 : US1, v233 : US1, v234 : US1, v235 : US1, v236 : US1, v237 : US1, v238 : US1, v239 : US1, v240 : US1, v241 : US1, v242 : US1, v243 : US1, v244 : US1, v245 : US1, v246 : US1, v247 : US8, v248 : US1, v249 : US1, v250 : US6, v251 : US1, v252 : US0, v253 : US1) = method4()
            let v254 : US1 = v1.l44
            let v257 : string =
                match v254 with
                | US1_0 -> (* None *)
                    let v255 : string = "0"
                    v255
                | US1_1(v256) -> (* Some *)
                    v256
            let v258 : string = "0"
            let v259 : US1 = US1_1(v258)
            let v260 : (unit -> (JSX.Element [])) = closure17(v0, v3, v187)
            let v261 : US5 = US5_1(v260)
            let v262 : string = "flex"
            let v263 : US1 = US1_1(v262)
            let v264 : string = "6"
            let v265 : US1 = US1_1(v264)
            let v266 : string = "column"
            let v267 : US1 = US1_1(v266)
            let v268 : string = "$sm"
            let v269 : US1 = US1_1(v268)
            let v270 : string = "$base"
            let v271 : US1 = US1_1(v270)
            let v272 : US1 = US1_1(v258)
            let v273 : string = "85vh"
            let v274 : US1 = US1_1(v273)
            let v275 : US1 = US1_1(v258)
            let v276 : string = "auto"
            let v277 : US1 = US1_1(v276)
            let v278 : US1 = US1_1(v257)
            let v279 : ((string * obj) []) = method5(v191, v192, v193, v194, v259, v196, v197, v198, v199, v200, v261, v202, v203, v204, v205, v206, v207, v263, v209, v210, v265, v267, v269, v214, v215, v216, v217, v218, v219, v220, v271, v272, v223, v224, v225, v226, v274, v228, v229, v230, v231, v275, v233, v277, v278, v236, v237, v238, v239, v240, v241, v242, v243, v244, v245, v246, v247, v248, v249, v250, v251, v252, v253)
            let v280 : obj = createObj v279
            let v281 : (obj -> JSX.Element) = v190 |> unbox<obj -> JSX.Element>
            "create_native_component -> create_component'" |> ignore
            let v282 : string = "createComponent"
            let v283 : string = "solid-js"
            let v284 : JS.Function = import v282 v283
            let v285 : JSX.Element = v284.Invoke (v281, v280) |> unbox<JSX.Element>
            v285
    [|v105; v286|]
and closure10 () (v0 : Mut3) : JSX.Element =
    let v1 : Mut2 = v0.l1
    let v2 : US12 = v0.l2
    let v4 : bool =
        match v2 with
        | US12_0 -> (* CheckDisabled *)
            true
        | _ ->
            false
    let v5 : bool = v4 <> true
    let v6 : string = "createSignal"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : (JS.Function []) = v8.Invoke v5 |> unbox<JS.Function[]>
    let v10 : (unit -> bool) = v9.[0] |> unbox
    let v11 : (bool -> unit) = v9.[1] |> unbox
    let v12 : string = "Tr"
    let v13 : string = "@hope-ui/solid"
    let v14 : JS.Function = import v12 v13
    let struct (v15 : US1, v16 : US1, v17 : US3, v18 : US1, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US4, v25 : US5, v26 : US1, v27 : US1, v28 : US4, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US7, v34 : US4, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US8, v41 : US1, v42 : US1, v43 : US1, v44 : US8, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US9, v54 : US10, v55 : US9, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US1, v67 : US1, v68 : US1, v69 : US1, v70 : US1, v71 : US8, v72 : US1, v73 : US1, v74 : US6, v75 : US1, v76 : US0, v77 : US1) = method4()
    let v78 : US1 = v1.l26
    let v79 : string = "column"
    let v80 : string = "row"
    let v81 : string = method10(v80, v79)
    let v82 : string = "$neutral5"
    let v83 : US1 = US1_1(v82)
    let v84 : string = "1px 2px"
    let v85 : US1 = US1_1(v84)
    let v86 : (unit -> (JSX.Element [])) = closure11(v0, v1, v11, v10)
    let v87 : US5 = US5_1(v86)
    let v88 : string = "flex"
    let v89 : US1 = US1_1(v88)
    let v90 : string = "1"
    let v91 : US1 = US1_1(v90)
    let v92 : US1 = US1_1(v81)
    let v93 : ((string * obj) []) = method5(v15, v16, v17, v18, v19, v20, v83, v85, v23, v24, v87, v26, v27, v28, v29, v30, v31, v89, v33, v34, v91, v92, v37, v38, v39, v40, v78, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77)
    let v94 : obj = createObj v93
    let v95 : (obj -> JSX.Element) = v14 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v96 : string = "createComponent"
    let v97 : JS.Function = import v96 v7
    let v98 : JSX.Element = v97.Invoke (v95, v94) |> unbox<JSX.Element>
    v98
and closure50 (v0 : Mut2) () : (JSX.Element []) =
    let v1 : US1 = v0.l24
    let v4 : string =
        match v1 with
        | US1_0 -> (* None *)
            let v2 : string = ""
            v2
        | US1_1(v3) -> (* Some *)
            v3
    let v5 : JSX.Element = Html.fragment [ v4 |> unbox<JSX.Element> ]
    [|v5|]
and closure51 () struct (v0 : US1, v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) : struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) =
    let v63 : US1 = US1_0
    let v64 : string = "-13px"
    let v65 : US1 = US1_1(v64)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v63, v34, v65, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure52 () () : JS.Function =
    let v0 : string = "BiRegularLinkExternal"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure49 (v0 : Mut2) () : (JSX.Element []) =
    let v1 : string = "Anchor"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method4()
    let struct (v67 : US1, v68 : US1, v69 : US3, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US4, v77 : US5, v78 : US1, v79 : US1, v80 : US4, v81 : US6, v82 : US1, v83 : US1, v84 : US1, v85 : US7, v86 : US4, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US1, v92 : US8, v93 : US1, v94 : US1, v95 : US1, v96 : US8, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US1, v105 : US9, v106 : US10, v107 : US9, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US8, v124 : US1, v125 : US1, v126 : US6, v127 : US1, v128 : US0, v129 : US1) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61, v0.l62
    let v130 : Mut2 = {l0 = v67; l1 = v68; l2 = v69; l3 = v70; l4 = v71; l5 = v72; l6 = v73; l7 = v74; l8 = v75; l9 = v76; l10 = v77; l11 = v78; l12 = v79; l13 = v80; l14 = v81; l15 = v82; l16 = v83; l17 = v84; l18 = v85; l19 = v86; l20 = v87; l21 = v88; l22 = v89; l23 = v90; l24 = v91; l25 = v92; l26 = v93; l27 = v94; l28 = v95; l29 = v96; l30 = v97; l31 = v98; l32 = v99; l33 = v100; l34 = v101; l35 = v102; l36 = v103; l37 = v104; l38 = v105; l39 = v106; l40 = v107; l41 = v108; l42 = v109; l43 = v110; l44 = v111; l45 = v112; l46 = v113; l47 = v114; l48 = v115; l49 = v116; l50 = v117; l51 = v118; l52 = v119; l53 = v120; l54 = v121; l55 = v122; l56 = v123; l57 = v124; l58 = v125; l59 = v126; l60 = v127; l61 = v128; l62 = v129} : Mut2
    let v131 : US4 = US4_1(true)
    let v132 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v131; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65; l62 = v66} : Mut2
    method11(v132, v130)
    let struct (v133 : US1, v134 : US1, v135 : US3, v136 : US1, v137 : US1, v138 : US1, v139 : US1, v140 : US1, v141 : US1, v142 : US4, v143 : US5, v144 : US1, v145 : US1, v146 : US4, v147 : US6, v148 : US1, v149 : US1, v150 : US1, v151 : US7, v152 : US4, v153 : US1, v154 : US1, v155 : US1, v156 : US1, v157 : US1, v158 : US8, v159 : US1, v160 : US1, v161 : US1, v162 : US8, v163 : US1, v164 : US1, v165 : US1, v166 : US1, v167 : US1, v168 : US1, v169 : US1, v170 : US1, v171 : US9, v172 : US10, v173 : US9, v174 : US1, v175 : US1, v176 : US1, v177 : US1, v178 : US1, v179 : US1, v180 : US1, v181 : US1, v182 : US1, v183 : US1, v184 : US1, v185 : US1, v186 : US1, v187 : US1, v188 : US1, v189 : US8, v190 : US1, v191 : US1, v192 : US6, v193 : US1, v194 : US0, v195 : US1) = v132.l0, v132.l1, v132.l2, v132.l3, v132.l4, v132.l5, v132.l6, v132.l7, v132.l8, v132.l9, v132.l10, v132.l11, v132.l12, v132.l13, v132.l14, v132.l15, v132.l16, v132.l17, v132.l18, v132.l19, v132.l20, v132.l21, v132.l22, v132.l23, v132.l24, v132.l25, v132.l26, v132.l27, v132.l28, v132.l29, v132.l30, v132.l31, v132.l32, v132.l33, v132.l34, v132.l35, v132.l36, v132.l37, v132.l38, v132.l39, v132.l40, v132.l41, v132.l42, v132.l43, v132.l44, v132.l45, v132.l46, v132.l47, v132.l48, v132.l49, v132.l50, v132.l51, v132.l52, v132.l53, v132.l54, v132.l55, v132.l56, v132.l57, v132.l58, v132.l59, v132.l60, v132.l61, v132.l62
    let v196 : (unit -> (JSX.Element [])) = closure50(v0)
    let v197 : US5 = US5_1(v196)
    let v198 : ((string * obj) []) = method5(v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v197, v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195)
    let v199 : obj = createObj v198
    let v200 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v201 : string = "createComponent"
    let v202 : string = "solid-js"
    let v203 : JS.Function = import v201 v202
    let v204 : JSX.Element = v203.Invoke (v200, v199) |> unbox<JSX.Element>
    let v205 : string = "&nbsp;"
    let v206 : JSX.Element = Html.fragment [ v205 |> unbox<JSX.Element> ]
    let v207 : (Mut6 -> JSX.Element) = closure31()
    let v208 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = closure51()
    let v209 : (unit -> JS.Function) = closure52()
    let v210 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = closure33()
    let v211 : Mut6 = {l0 = v208; l1 = v209; l2 = v210} : Mut6
    let v212 : obj = v211
    let v213 : (obj -> JSX.Element) = v207 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v214 : JS.Function = import v201 v202
    let v215 : JSX.Element = v214.Invoke (v213, v212) |> unbox<JSX.Element>
    [|v204; v206; v215|]
and closure48 () (v0 : Mut2) : JSX.Element =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method4()
    let v67 : (unit -> (JSX.Element [])) = closure49(v0)
    let v68 : US5 = US5_1(v67)
    let v69 : ((string * obj) []) = method5(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v68, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66)
    let v70 : obj = createObj v69
    let v71 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v72 : string = "createComponent"
    let v73 : string = "solid-js"
    let v74 : JS.Function = import v72 v73
    let v75 : JSX.Element = v74.Invoke (v71, v70) |> unbox<JSX.Element>
    v75
and closure53 () () : (JSX.Element []) =
    [||]
and closure47 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure48()
    let struct (v1 : US1, v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method4()
    let v64 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63} : Mut2
    let v65 : string = "https://github.com/fc1943s/tictactoe_spiral"
    let v66 : US1 = US1_1(v65)
    v64.l24 <- v66
    let struct (v67 : US1, v68 : US1, v69 : US3, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US4, v77 : US5, v78 : US1, v79 : US1, v80 : US4, v81 : US6, v82 : US1, v83 : US1, v84 : US1, v85 : US7, v86 : US4, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US1, v92 : US8, v93 : US1, v94 : US1, v95 : US1, v96 : US8, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US1, v105 : US9, v106 : US10, v107 : US9, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US8, v124 : US1, v125 : US1, v126 : US6, v127 : US1, v128 : US0, v129 : US1) = v64.l0, v64.l1, v64.l2, v64.l3, v64.l4, v64.l5, v64.l6, v64.l7, v64.l8, v64.l9, v64.l10, v64.l11, v64.l12, v64.l13, v64.l14, v64.l15, v64.l16, v64.l17, v64.l18, v64.l19, v64.l20, v64.l21, v64.l22, v64.l23, v64.l24, v64.l25, v64.l26, v64.l27, v64.l28, v64.l29, v64.l30, v64.l31, v64.l32, v64.l33, v64.l34, v64.l35, v64.l36, v64.l37, v64.l38, v64.l39, v64.l40, v64.l41, v64.l42, v64.l43, v64.l44, v64.l45, v64.l46, v64.l47, v64.l48, v64.l49, v64.l50, v64.l51, v64.l52, v64.l53, v64.l54, v64.l55, v64.l56, v64.l57, v64.l58, v64.l59, v64.l60, v64.l61, v64.l62
    let v130 : (unit -> (JSX.Element [])) = closure53()
    let v131 : US5 = US5_1(v130)
    emitJsExpr (struct (v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v131, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129), v130) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v132 : US5 = US5_1(v130)
    let v133 : Mut2 = {l0 = v67; l1 = v68; l2 = v69; l3 = v70; l4 = v71; l5 = v72; l6 = v73; l7 = v74; l8 = v75; l9 = v76; l10 = v132; l11 = v78; l12 = v79; l13 = v80; l14 = v81; l15 = v82; l16 = v83; l17 = v84; l18 = v85; l19 = v86; l20 = v87; l21 = v88; l22 = v89; l23 = v90; l24 = v91; l25 = v92; l26 = v93; l27 = v94; l28 = v95; l29 = v96; l30 = v97; l31 = v98; l32 = v99; l33 = v100; l34 = v101; l35 = v102; l36 = v103; l37 = v104; l38 = v105; l39 = v106; l40 = v107; l41 = v108; l42 = v109; l43 = v110; l44 = v111; l45 = v112; l46 = v113; l47 = v114; l48 = v115; l49 = v116; l50 = v117; l51 = v118; l52 = v119; l53 = v120; l54 = v121; l55 = v122; l56 = v123; l57 = v124; l58 = v125; l59 = v126; l60 = v127; l61 = v128; l62 = v129} : Mut2
    let v134 : obj = v133
    let v135 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v136 : string = "createComponent"
    let v137 : string = "solid-js"
    let v138 : JS.Function = import v136 v137
    let v139 : JSX.Element = v138.Invoke (v135, v134) |> unbox<JSX.Element>
    [|v139|]
and closure54 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure48()
    let struct (v1 : US1, v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method4()
    let v64 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63} : Mut2
    let v65 : string = "https://fc1943s.github.io/tictactoe_spiral"
    let v66 : US1 = US1_1(v65)
    v64.l24 <- v66
    let struct (v67 : US1, v68 : US1, v69 : US3, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US4, v77 : US5, v78 : US1, v79 : US1, v80 : US4, v81 : US6, v82 : US1, v83 : US1, v84 : US1, v85 : US7, v86 : US4, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US1, v92 : US8, v93 : US1, v94 : US1, v95 : US1, v96 : US8, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US1, v105 : US9, v106 : US10, v107 : US9, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US8, v124 : US1, v125 : US1, v126 : US6, v127 : US1, v128 : US0, v129 : US1) = v64.l0, v64.l1, v64.l2, v64.l3, v64.l4, v64.l5, v64.l6, v64.l7, v64.l8, v64.l9, v64.l10, v64.l11, v64.l12, v64.l13, v64.l14, v64.l15, v64.l16, v64.l17, v64.l18, v64.l19, v64.l20, v64.l21, v64.l22, v64.l23, v64.l24, v64.l25, v64.l26, v64.l27, v64.l28, v64.l29, v64.l30, v64.l31, v64.l32, v64.l33, v64.l34, v64.l35, v64.l36, v64.l37, v64.l38, v64.l39, v64.l40, v64.l41, v64.l42, v64.l43, v64.l44, v64.l45, v64.l46, v64.l47, v64.l48, v64.l49, v64.l50, v64.l51, v64.l52, v64.l53, v64.l54, v64.l55, v64.l56, v64.l57, v64.l58, v64.l59, v64.l60, v64.l61, v64.l62
    let v130 : (unit -> (JSX.Element [])) = closure53()
    let v131 : US5 = US5_1(v130)
    emitJsExpr (struct (v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v131, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129), v130) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v132 : US5 = US5_1(v130)
    let v133 : Mut2 = {l0 = v67; l1 = v68; l2 = v69; l3 = v70; l4 = v71; l5 = v72; l6 = v73; l7 = v74; l8 = v75; l9 = v76; l10 = v132; l11 = v78; l12 = v79; l13 = v80; l14 = v81; l15 = v82; l16 = v83; l17 = v84; l18 = v85; l19 = v86; l20 = v87; l21 = v88; l22 = v89; l23 = v90; l24 = v91; l25 = v92; l26 = v93; l27 = v94; l28 = v95; l29 = v96; l30 = v97; l31 = v98; l32 = v99; l33 = v100; l34 = v101; l35 = v102; l36 = v103; l37 = v104; l38 = v105; l39 = v106; l40 = v107; l41 = v108; l42 = v109; l43 = v110; l44 = v111; l45 = v112; l46 = v113; l47 = v114; l48 = v115; l49 = v116; l50 = v117; l51 = v118; l52 = v119; l53 = v120; l54 = v121; l55 = v122; l56 = v123; l57 = v124; l58 = v125; l59 = v126; l60 = v127; l61 = v128; l62 = v129} : Mut2
    let v134 : obj = v133
    let v135 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v136 : string = "createComponent"
    let v137 : string = "solid-js"
    let v138 : JS.Function = import v136 v137
    let v139 : JSX.Element = v138.Invoke (v135, v134) |> unbox<JSX.Element>
    [|v139|]
and closure55 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure48()
    let struct (v1 : US1, v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method4()
    let v64 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63} : Mut2
    let v65 : string = "https://fc1943s.github.io/tictactoe_spiral/docs"
    let v66 : US1 = US1_1(v65)
    v64.l24 <- v66
    let struct (v67 : US1, v68 : US1, v69 : US3, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US4, v77 : US5, v78 : US1, v79 : US1, v80 : US4, v81 : US6, v82 : US1, v83 : US1, v84 : US1, v85 : US7, v86 : US4, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US1, v92 : US8, v93 : US1, v94 : US1, v95 : US1, v96 : US8, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US1, v105 : US9, v106 : US10, v107 : US9, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US8, v124 : US1, v125 : US1, v126 : US6, v127 : US1, v128 : US0, v129 : US1) = v64.l0, v64.l1, v64.l2, v64.l3, v64.l4, v64.l5, v64.l6, v64.l7, v64.l8, v64.l9, v64.l10, v64.l11, v64.l12, v64.l13, v64.l14, v64.l15, v64.l16, v64.l17, v64.l18, v64.l19, v64.l20, v64.l21, v64.l22, v64.l23, v64.l24, v64.l25, v64.l26, v64.l27, v64.l28, v64.l29, v64.l30, v64.l31, v64.l32, v64.l33, v64.l34, v64.l35, v64.l36, v64.l37, v64.l38, v64.l39, v64.l40, v64.l41, v64.l42, v64.l43, v64.l44, v64.l45, v64.l46, v64.l47, v64.l48, v64.l49, v64.l50, v64.l51, v64.l52, v64.l53, v64.l54, v64.l55, v64.l56, v64.l57, v64.l58, v64.l59, v64.l60, v64.l61, v64.l62
    let v130 : (unit -> (JSX.Element [])) = closure53()
    let v131 : US5 = US5_1(v130)
    emitJsExpr (struct (v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v131, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129), v130) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v132 : US5 = US5_1(v130)
    let v133 : Mut2 = {l0 = v67; l1 = v68; l2 = v69; l3 = v70; l4 = v71; l5 = v72; l6 = v73; l7 = v74; l8 = v75; l9 = v76; l10 = v132; l11 = v78; l12 = v79; l13 = v80; l14 = v81; l15 = v82; l16 = v83; l17 = v84; l18 = v85; l19 = v86; l20 = v87; l21 = v88; l22 = v89; l23 = v90; l24 = v91; l25 = v92; l26 = v93; l27 = v94; l28 = v95; l29 = v96; l30 = v97; l31 = v98; l32 = v99; l33 = v100; l34 = v101; l35 = v102; l36 = v103; l37 = v104; l38 = v105; l39 = v106; l40 = v107; l41 = v108; l42 = v109; l43 = v110; l44 = v111; l45 = v112; l46 = v113; l47 = v114; l48 = v115; l49 = v116; l50 = v117; l51 = v118; l52 = v119; l53 = v120; l54 = v121; l55 = v122; l56 = v123; l57 = v124; l58 = v125; l59 = v126; l60 = v127; l61 = v128; l62 = v129} : Mut2
    let v134 : obj = v133
    let v135 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v136 : string = "createComponent"
    let v137 : string = "solid-js"
    let v138 : JS.Function = import v136 v137
    let v139 : JSX.Element = v138.Invoke (v135, v134) |> unbox<JSX.Element>
    [|v139|]
and closure46 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure10()
    let struct (v1 : US1, v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method4()
    let v64 : (unit -> (JSX.Element [])) = closure47()
    let v65 : US5 = US5_1(v64)
    let v66 : string = "1px 6px"
    let v67 : US1 = US1_1(v66)
    let v68 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v65; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v67; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63} : Mut2
    let v69 : US11 = US11_0
    let v70 : US12 = US12_2
    let v71 : Mut3 = {l0 = v69; l1 = v68; l2 = v70} : Mut3
    let v72 : obj = v71
    let v73 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v74 : string = "createComponent"
    let v75 : string = "solid-js"
    let v76 : JS.Function = import v74 v75
    let v77 : JSX.Element = v76.Invoke (v73, v72) |> unbox<JSX.Element>
    let struct (v78 : US1, v79 : US1, v80 : US3, v81 : US1, v82 : US1, v83 : US1, v84 : US1, v85 : US1, v86 : US1, v87 : US4, v88 : US5, v89 : US1, v90 : US1, v91 : US4, v92 : US6, v93 : US1, v94 : US1, v95 : US1, v96 : US7, v97 : US4, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US8, v104 : US1, v105 : US1, v106 : US1, v107 : US8, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US9, v117 : US10, v118 : US9, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US8, v135 : US1, v136 : US1, v137 : US6, v138 : US1, v139 : US0, v140 : US1) = method4()
    let v141 : (unit -> (JSX.Element [])) = closure54()
    let v142 : US5 = US5_1(v141)
    let v143 : US1 = US1_1(v66)
    let v144 : Mut2 = {l0 = v78; l1 = v79; l2 = v80; l3 = v81; l4 = v82; l5 = v83; l6 = v84; l7 = v85; l8 = v86; l9 = v87; l10 = v142; l11 = v89; l12 = v90; l13 = v91; l14 = v92; l15 = v93; l16 = v94; l17 = v95; l18 = v96; l19 = v97; l20 = v98; l21 = v99; l22 = v100; l23 = v101; l24 = v102; l25 = v103; l26 = v104; l27 = v105; l28 = v106; l29 = v107; l30 = v108; l31 = v109; l32 = v110; l33 = v111; l34 = v112; l35 = v113; l36 = v114; l37 = v115; l38 = v116; l39 = v117; l40 = v118; l41 = v119; l42 = v120; l43 = v121; l44 = v143; l45 = v123; l46 = v124; l47 = v125; l48 = v126; l49 = v127; l50 = v128; l51 = v129; l52 = v130; l53 = v131; l54 = v132; l55 = v133; l56 = v134; l57 = v135; l58 = v136; l59 = v137; l60 = v138; l61 = v139; l62 = v140} : Mut2
    let v145 : US11 = US11_0
    let v146 : US12 = US12_2
    let v147 : Mut3 = {l0 = v145; l1 = v144; l2 = v146} : Mut3
    let v148 : obj = v147
    let v149 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v150 : JS.Function = import v74 v75
    let v151 : JSX.Element = v150.Invoke (v149, v148) |> unbox<JSX.Element>
    let struct (v152 : US1, v153 : US1, v154 : US3, v155 : US1, v156 : US1, v157 : US1, v158 : US1, v159 : US1, v160 : US1, v161 : US4, v162 : US5, v163 : US1, v164 : US1, v165 : US4, v166 : US6, v167 : US1, v168 : US1, v169 : US1, v170 : US7, v171 : US4, v172 : US1, v173 : US1, v174 : US1, v175 : US1, v176 : US1, v177 : US8, v178 : US1, v179 : US1, v180 : US1, v181 : US8, v182 : US1, v183 : US1, v184 : US1, v185 : US1, v186 : US1, v187 : US1, v188 : US1, v189 : US1, v190 : US9, v191 : US10, v192 : US9, v193 : US1, v194 : US1, v195 : US1, v196 : US1, v197 : US1, v198 : US1, v199 : US1, v200 : US1, v201 : US1, v202 : US1, v203 : US1, v204 : US1, v205 : US1, v206 : US1, v207 : US1, v208 : US8, v209 : US1, v210 : US1, v211 : US6, v212 : US1, v213 : US0, v214 : US1) = method4()
    let v215 : (unit -> (JSX.Element [])) = closure55()
    let v216 : US5 = US5_1(v215)
    let v217 : US1 = US1_1(v66)
    let v218 : Mut2 = {l0 = v152; l1 = v153; l2 = v154; l3 = v155; l4 = v156; l5 = v157; l6 = v158; l7 = v159; l8 = v160; l9 = v161; l10 = v216; l11 = v163; l12 = v164; l13 = v165; l14 = v166; l15 = v167; l16 = v168; l17 = v169; l18 = v170; l19 = v171; l20 = v172; l21 = v173; l22 = v174; l23 = v175; l24 = v176; l25 = v177; l26 = v178; l27 = v179; l28 = v180; l29 = v181; l30 = v182; l31 = v183; l32 = v184; l33 = v185; l34 = v186; l35 = v187; l36 = v188; l37 = v189; l38 = v190; l39 = v191; l40 = v192; l41 = v193; l42 = v194; l43 = v195; l44 = v217; l45 = v197; l46 = v198; l47 = v199; l48 = v200; l49 = v201; l50 = v202; l51 = v203; l52 = v204; l53 = v205; l54 = v206; l55 = v207; l56 = v208; l57 = v209; l58 = v210; l59 = v211; l60 = v212; l61 = v213; l62 = v214} : Mut2
    let v219 : US11 = US11_0
    let v220 : US12 = US12_2
    let v221 : Mut3 = {l0 = v219; l1 = v218; l2 = v220} : Mut3
    let v222 : obj = v221
    let v223 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v224 : JS.Function = import v74 v75
    let v225 : JSX.Element = v224.Invoke (v223, v222) |> unbox<JSX.Element>
    [|v77; v151; v225|]
and closure45 () (v0 : Mut2) : JSX.Element =
    let v1 : (Mut2 -> JSX.Element) = closure6()
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method4()
    let v65 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    let struct (v66 : US1, v67 : US1, v68 : US3, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US4, v76 : US5, v77 : US1, v78 : US1, v79 : US4, v80 : US6, v81 : US1, v82 : US1, v83 : US1, v84 : US7, v85 : US4, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US8, v92 : US1, v93 : US1, v94 : US1, v95 : US8, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US9, v105 : US10, v106 : US9, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US8, v123 : US1, v124 : US1, v125 : US6, v126 : US1, v127 : US0, v128 : US1) = v65.l0, v65.l1, v65.l2, v65.l3, v65.l4, v65.l5, v65.l6, v65.l7, v65.l8, v65.l9, v65.l10, v65.l11, v65.l12, v65.l13, v65.l14, v65.l15, v65.l16, v65.l17, v65.l18, v65.l19, v65.l20, v65.l21, v65.l22, v65.l23, v65.l24, v65.l25, v65.l26, v65.l27, v65.l28, v65.l29, v65.l30, v65.l31, v65.l32, v65.l33, v65.l34, v65.l35, v65.l36, v65.l37, v65.l38, v65.l39, v65.l40, v65.l41, v65.l42, v65.l43, v65.l44, v65.l45, v65.l46, v65.l47, v65.l48, v65.l49, v65.l50, v65.l51, v65.l52, v65.l53, v65.l54, v65.l55, v65.l56, v65.l57, v65.l58, v65.l59, v65.l60, v65.l61, v65.l62
    let v129 : (unit -> (JSX.Element [])) = closure46()
    let v130 : US5 = US5_1(v129)
    emitJsExpr (struct (v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v130, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128), v129) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v131 : US5 = US5_1(v129)
    let v132 : Mut2 = {l0 = v66; l1 = v67; l2 = v68; l3 = v69; l4 = v70; l5 = v71; l6 = v72; l7 = v73; l8 = v74; l9 = v75; l10 = v131; l11 = v77; l12 = v78; l13 = v79; l14 = v80; l15 = v81; l16 = v82; l17 = v83; l18 = v84; l19 = v85; l20 = v86; l21 = v87; l22 = v88; l23 = v89; l24 = v90; l25 = v91; l26 = v92; l27 = v93; l28 = v94; l29 = v95; l30 = v96; l31 = v97; l32 = v98; l33 = v99; l34 = v100; l35 = v101; l36 = v102; l37 = v103; l38 = v104; l39 = v105; l40 = v106; l41 = v107; l42 = v108; l43 = v109; l44 = v110; l45 = v111; l46 = v112; l47 = v113; l48 = v114; l49 = v115; l50 = v116; l51 = v117; l52 = v118; l53 = v119; l54 = v120; l55 = v121; l56 = v122; l57 = v123; l58 = v124; l59 = v125; l60 = v126; l61 = v127; l62 = v128} : Mut2
    let v133 : obj = v132
    let v134 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v135 : string = "createComponent"
    let v136 : string = "solid-js"
    let v137 : JS.Function = import v135 v136
    let v138 : JSX.Element = v137.Invoke (v134, v133) |> unbox<JSX.Element>
    v138
and closure56 () () : (JSX.Element []) =
    [||]
and closure44 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure45()
    let struct (v1 : US1, v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method4()
    let v64 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63} : Mut2
    let struct (v65 : US1, v66 : US1, v67 : US3, v68 : US1, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US4, v75 : US5, v76 : US1, v77 : US1, v78 : US4, v79 : US6, v80 : US1, v81 : US1, v82 : US1, v83 : US7, v84 : US4, v85 : US1, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US8, v91 : US1, v92 : US1, v93 : US1, v94 : US8, v95 : US1, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US9, v104 : US10, v105 : US9, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US8, v122 : US1, v123 : US1, v124 : US6, v125 : US1, v126 : US0, v127 : US1) = v64.l0, v64.l1, v64.l2, v64.l3, v64.l4, v64.l5, v64.l6, v64.l7, v64.l8, v64.l9, v64.l10, v64.l11, v64.l12, v64.l13, v64.l14, v64.l15, v64.l16, v64.l17, v64.l18, v64.l19, v64.l20, v64.l21, v64.l22, v64.l23, v64.l24, v64.l25, v64.l26, v64.l27, v64.l28, v64.l29, v64.l30, v64.l31, v64.l32, v64.l33, v64.l34, v64.l35, v64.l36, v64.l37, v64.l38, v64.l39, v64.l40, v64.l41, v64.l42, v64.l43, v64.l44, v64.l45, v64.l46, v64.l47, v64.l48, v64.l49, v64.l50, v64.l51, v64.l52, v64.l53, v64.l54, v64.l55, v64.l56, v64.l57, v64.l58, v64.l59, v64.l60, v64.l61, v64.l62
    let v128 : (unit -> (JSX.Element [])) = closure56()
    let v129 : US5 = US5_1(v128)
    emitJsExpr (struct (v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v129, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127), v128) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v130 : US5 = US5_1(v128)
    let v131 : Mut2 = {l0 = v65; l1 = v66; l2 = v67; l3 = v68; l4 = v69; l5 = v70; l6 = v71; l7 = v72; l8 = v73; l9 = v74; l10 = v130; l11 = v76; l12 = v77; l13 = v78; l14 = v79; l15 = v80; l16 = v81; l17 = v82; l18 = v83; l19 = v84; l20 = v85; l21 = v86; l22 = v87; l23 = v88; l24 = v89; l25 = v90; l26 = v91; l27 = v92; l28 = v93; l29 = v94; l30 = v95; l31 = v96; l32 = v97; l33 = v98; l34 = v99; l35 = v100; l36 = v101; l37 = v102; l38 = v103; l39 = v104; l40 = v105; l41 = v106; l42 = v107; l43 = v108; l44 = v109; l45 = v110; l46 = v111; l47 = v112; l48 = v113; l49 = v114; l50 = v115; l51 = v116; l52 = v117; l53 = v118; l54 = v119; l55 = v120; l56 = v121; l57 = v122; l58 = v123; l59 = v124; l60 = v125; l61 = v126; l62 = v127} : Mut2
    let v132 : obj = v131
    let v133 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v134 : string = "createComponent"
    let v135 : string = "solid-js"
    let v136 : JS.Function = import v134 v135
    let v137 : JSX.Element = v136.Invoke (v133, v132) |> unbox<JSX.Element>
    [|v137|]
and closure63 () () : (JSX.Element []) =
    let v0 : string = "Dark"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure64 () () : (JSX.Element []) =
    let v0 : string = "Light"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure62 () () : (JSX.Element []) =
    let v0 : string = "Radio"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US1, v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = method4()
    let v66 : string = "dark"
    let v67 : obj = v66
    let v68 : (unit -> (JSX.Element [])) = closure63()
    let v69 : US5 = US5_1(v68)
    let v70 : string = "neutral"
    let v71 : US1 = US1_1(v70)
    let v72 : string = "sm"
    let v73 : US1 = US1_1(v72)
    let v74 : US6 = US6_1(v67)
    let v75 : ((string * obj) []) = method5(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v69, v14, v71, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v73, v55, v56, v57, v58, v59, v60, v61, v74, v63, v64, v65)
    let v76 : obj = createObj v75
    let v77 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v78 : string = "createComponent"
    let v79 : string = "solid-js"
    let v80 : JS.Function = import v78 v79
    let v81 : JSX.Element = v80.Invoke (v77, v76) |> unbox<JSX.Element>
    let v82 : JS.Function = import v0 v1
    let struct (v83 : US1, v84 : US1, v85 : US3, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US1, v92 : US4, v93 : US5, v94 : US1, v95 : US1, v96 : US4, v97 : US6, v98 : US1, v99 : US1, v100 : US1, v101 : US7, v102 : US4, v103 : US1, v104 : US1, v105 : US1, v106 : US1, v107 : US1, v108 : US8, v109 : US1, v110 : US1, v111 : US1, v112 : US8, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US9, v122 : US10, v123 : US9, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US1, v136 : US1, v137 : US1, v138 : US1, v139 : US8, v140 : US1, v141 : US1, v142 : US6, v143 : US1, v144 : US0, v145 : US1) = method4()
    let v146 : string = "light"
    let v147 : obj = v146
    let v148 : (unit -> (JSX.Element [])) = closure64()
    let v149 : US5 = US5_1(v148)
    let v150 : US1 = US1_1(v70)
    let v151 : US1 = US1_1(v72)
    let v152 : US6 = US6_1(v147)
    let v153 : ((string * obj) []) = method5(v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v149, v94, v150, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v151, v135, v136, v137, v138, v139, v140, v141, v152, v143, v144, v145)
    let v154 : obj = createObj v153
    let v155 : (obj -> JSX.Element) = v82 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v156 : JS.Function = import v78 v79
    let v157 : JSX.Element = v156.Invoke (v155, v154) |> unbox<JSX.Element>
    [|v81; v157|]
and closure61 () () : (JSX.Element []) =
    let v0 : string = "Stack"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US1, v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = method4()
    let v66 : (unit -> (JSX.Element [])) = closure62()
    let v67 : US5 = US5_1(v66)
    let v68 : string = "row"
    let v69 : US1 = US1_1(v68)
    let v70 : string = "$4"
    let v71 : US1 = US1_1(v70)
    let v72 : ((string * obj) []) = method5(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v67, v14, v15, v16, v17, v18, v69, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v71, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65)
    let v73 : obj = createObj v72
    let v74 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v75 : string = "createComponent"
    let v76 : string = "solid-js"
    let v77 : JS.Function = import v75 v76
    let v78 : JSX.Element = v77.Invoke (v74, v73) |> unbox<JSX.Element>
    [|v78|]
and closure65 (v0 : (unit -> unit)) (v1 : obj) : unit =
    v0 ()
    ()
and closure60 (v0 : (unit -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : string = "RadioGroup"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let struct (v5 : US1, v6 : US1, v7 : US3, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US4, v15 : US5, v16 : US1, v17 : US1, v18 : US4, v19 : US6, v20 : US1, v21 : US1, v22 : US1, v23 : US7, v24 : US4, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US8, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US9, v44 : US10, v45 : US9, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US8, v62 : US1, v63 : US1, v64 : US6, v65 : US1, v66 : US0, v67 : US1) = method4()
    let v68 : string = v1 ()
    let v69 : (unit -> (JSX.Element [])) = closure61()
    let v70 : US5 = US5_1(v69)
    let v71 : US1 = US1_1(v68)
    let v72 : (obj -> unit) = closure65(v0)
    let v73 : US9 = US9_1(v72)
    let v74 : ((string * obj) []) = method5(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v70, v16, v17, v18, v19, v71, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v73, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
    let v75 : obj = createObj v74
    let v76 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v77 : string = "createComponent"
    let v78 : string = "solid-js"
    let v79 : JS.Function = import v77 v78
    let v80 : JSX.Element = v79.Invoke (v76, v75) |> unbox<JSX.Element>
    [|v80|]
and closure59 (v0 : (unit -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : (Mut3 -> JSX.Element) = closure10()
    let struct (v3 : US1, v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = method4()
    let v66 : string = "Theme"
    let v67 : JSX.Element = Html.fragment [ v66 |> unbox<JSX.Element> ]
    let v68 : (unit -> (JSX.Element [])) = closure60(v0, v1)
    let v69 : US5 = US5_1(v68)
    let v70 : string = "5px 6px"
    let v71 : US1 = US1_1(v70)
    let v72 : US8 = US8_1(v67)
    let v73 : Mut2 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v69; l11 = v14; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v71; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v72; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64; l62 = v65} : Mut2
    let v74 : US11 = US11_0
    let v75 : US12 = US12_2
    let v76 : Mut3 = {l0 = v74; l1 = v73; l2 = v75} : Mut3
    let v77 : obj = v76
    let v78 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v79 : string = "createComponent"
    let v80 : string = "solid-js"
    let v81 : JS.Function = import v79 v80
    let v82 : JSX.Element = v81.Invoke (v78, v77) |> unbox<JSX.Element>
    [|v82|]
and closure58 () (v0 : Mut2) : JSX.Element =
    let v1 : string = "useColorMode"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : obj = v3.Invoke () |> unbox
    let v5 : (unit -> string) = v4?colorMode |> unbox
    let v6 : (unit -> unit) = v4?toggleColorMode |> unbox
    let v7 : (Mut2 -> JSX.Element) = closure6()
    let struct (v8 : US1, v9 : US1, v10 : US3, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US4, v18 : US5, v19 : US1, v20 : US1, v21 : US4, v22 : US6, v23 : US1, v24 : US1, v25 : US1, v26 : US7, v27 : US4, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US8, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US9, v47 : US10, v48 : US9, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US8, v65 : US1, v66 : US1, v67 : US6, v68 : US1, v69 : US0, v70 : US1) = method4()
    let v71 : Mut2 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v18; l11 = v19; l12 = v20; l13 = v21; l14 = v22; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v34; l27 = v35; l28 = v36; l29 = v37; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50; l43 = v51; l44 = v52; l45 = v53; l46 = v54; l47 = v55; l48 = v56; l49 = v57; l50 = v58; l51 = v59; l52 = v60; l53 = v61; l54 = v62; l55 = v63; l56 = v64; l57 = v65; l58 = v66; l59 = v67; l60 = v68; l61 = v69; l62 = v70} : Mut2
    let struct (v72 : US1, v73 : US1, v74 : US3, v75 : US1, v76 : US1, v77 : US1, v78 : US1, v79 : US1, v80 : US1, v81 : US4, v82 : US5, v83 : US1, v84 : US1, v85 : US4, v86 : US6, v87 : US1, v88 : US1, v89 : US1, v90 : US7, v91 : US4, v92 : US1, v93 : US1, v94 : US1, v95 : US1, v96 : US1, v97 : US8, v98 : US1, v99 : US1, v100 : US1, v101 : US8, v102 : US1, v103 : US1, v104 : US1, v105 : US1, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US9, v111 : US10, v112 : US9, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US8, v129 : US1, v130 : US1, v131 : US6, v132 : US1, v133 : US0, v134 : US1) = v71.l0, v71.l1, v71.l2, v71.l3, v71.l4, v71.l5, v71.l6, v71.l7, v71.l8, v71.l9, v71.l10, v71.l11, v71.l12, v71.l13, v71.l14, v71.l15, v71.l16, v71.l17, v71.l18, v71.l19, v71.l20, v71.l21, v71.l22, v71.l23, v71.l24, v71.l25, v71.l26, v71.l27, v71.l28, v71.l29, v71.l30, v71.l31, v71.l32, v71.l33, v71.l34, v71.l35, v71.l36, v71.l37, v71.l38, v71.l39, v71.l40, v71.l41, v71.l42, v71.l43, v71.l44, v71.l45, v71.l46, v71.l47, v71.l48, v71.l49, v71.l50, v71.l51, v71.l52, v71.l53, v71.l54, v71.l55, v71.l56, v71.l57, v71.l58, v71.l59, v71.l60, v71.l61, v71.l62
    let v135 : (unit -> (JSX.Element [])) = closure59(v6, v5)
    let v136 : US5 = US5_1(v135)
    emitJsExpr (struct (v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v136, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134), v135) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v137 : US5 = US5_1(v135)
    let v138 : Mut2 = {l0 = v72; l1 = v73; l2 = v74; l3 = v75; l4 = v76; l5 = v77; l6 = v78; l7 = v79; l8 = v80; l9 = v81; l10 = v137; l11 = v83; l12 = v84; l13 = v85; l14 = v86; l15 = v87; l16 = v88; l17 = v89; l18 = v90; l19 = v91; l20 = v92; l21 = v93; l22 = v94; l23 = v95; l24 = v96; l25 = v97; l26 = v98; l27 = v99; l28 = v100; l29 = v101; l30 = v102; l31 = v103; l32 = v104; l33 = v105; l34 = v106; l35 = v107; l36 = v108; l37 = v109; l38 = v110; l39 = v111; l40 = v112; l41 = v113; l42 = v114; l43 = v115; l44 = v116; l45 = v117; l46 = v118; l47 = v119; l48 = v120; l49 = v121; l50 = v122; l51 = v123; l52 = v124; l53 = v125; l54 = v126; l55 = v127; l56 = v128; l57 = v129; l58 = v130; l59 = v131; l60 = v132; l61 = v133; l62 = v134} : Mut2
    let v139 : obj = v138
    let v140 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v141 : string = "createComponent"
    let v142 : string = "solid-js"
    let v143 : JS.Function = import v141 v142
    let v144 : JSX.Element = v143.Invoke (v140, v139) |> unbox<JSX.Element>
    v144
and closure66 () () : (JSX.Element []) =
    [||]
and closure57 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure58()
    let struct (v1 : US1, v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method4()
    let v64 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63} : Mut2
    let struct (v65 : US1, v66 : US1, v67 : US3, v68 : US1, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US4, v75 : US5, v76 : US1, v77 : US1, v78 : US4, v79 : US6, v80 : US1, v81 : US1, v82 : US1, v83 : US7, v84 : US4, v85 : US1, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US8, v91 : US1, v92 : US1, v93 : US1, v94 : US8, v95 : US1, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US9, v104 : US10, v105 : US9, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US8, v122 : US1, v123 : US1, v124 : US6, v125 : US1, v126 : US0, v127 : US1) = v64.l0, v64.l1, v64.l2, v64.l3, v64.l4, v64.l5, v64.l6, v64.l7, v64.l8, v64.l9, v64.l10, v64.l11, v64.l12, v64.l13, v64.l14, v64.l15, v64.l16, v64.l17, v64.l18, v64.l19, v64.l20, v64.l21, v64.l22, v64.l23, v64.l24, v64.l25, v64.l26, v64.l27, v64.l28, v64.l29, v64.l30, v64.l31, v64.l32, v64.l33, v64.l34, v64.l35, v64.l36, v64.l37, v64.l38, v64.l39, v64.l40, v64.l41, v64.l42, v64.l43, v64.l44, v64.l45, v64.l46, v64.l47, v64.l48, v64.l49, v64.l50, v64.l51, v64.l52, v64.l53, v64.l54, v64.l55, v64.l56, v64.l57, v64.l58, v64.l59, v64.l60, v64.l61, v64.l62
    let v128 : (unit -> (JSX.Element [])) = closure66()
    let v129 : US5 = US5_1(v128)
    emitJsExpr (struct (v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v129, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127), v128) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v130 : US5 = US5_1(v128)
    let v131 : Mut2 = {l0 = v65; l1 = v66; l2 = v67; l3 = v68; l4 = v69; l5 = v70; l6 = v71; l7 = v72; l8 = v73; l9 = v74; l10 = v130; l11 = v76; l12 = v77; l13 = v78; l14 = v79; l15 = v80; l16 = v81; l17 = v82; l18 = v83; l19 = v84; l20 = v85; l21 = v86; l22 = v87; l23 = v88; l24 = v89; l25 = v90; l26 = v91; l27 = v92; l28 = v93; l29 = v94; l30 = v95; l31 = v96; l32 = v97; l33 = v98; l34 = v99; l35 = v100; l36 = v101; l37 = v102; l38 = v103; l39 = v104; l40 = v105; l41 = v106; l42 = v107; l43 = v108; l44 = v109; l45 = v110; l46 = v111; l47 = v112; l48 = v113; l49 = v114; l50 = v115; l51 = v116; l52 = v117; l53 = v118; l54 = v119; l55 = v120; l56 = v121; l57 = v122; l58 = v123; l59 = v124; l60 = v125; l61 = v126; l62 = v127} : Mut2
    let v132 : obj = v131
    let v133 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v134 : string = "createComponent"
    let v135 : string = "solid-js"
    let v136 : JS.Function = import v134 v135
    let v137 : JSX.Element = v136.Invoke (v133, v132) |> unbox<JSX.Element>
    [|v137|]
and closure75 () () : (JSX.Element []) =
    [||]
and closure76 (v0 : Mut7, v1 : Mut1, v2 : JS.Function) (v3 : obj) : unit =
    let v4 : string = v3?currentTarget?value
    let v5 : ((string * obj) []) = Array.zeroCreate<(string * obj)> (0)
    let v6 : obj = createObj v5
    let v7 : Mut1 = v6 |> unbox
    let v8 : (Mut1 -> (Mut1 -> (US1 -> unit))) = v0.l1
    let v9 : (Mut1 -> (US1 -> unit)) = v8 v1
    let v10 : (US1 -> unit) = v9 v7
    let v11 : US1 = US1_1(v4)
    v10 v11
    let v12 : obj = v7
    v2.Invoke ("set", v12) |> ignore
    ()
and closure74 () (v0 : Mut7) : JSX.Element =
    let v1 : string = "useStoreon"
    let v2 : string = "@storeon/solidjs"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke () |> unbox<JS.Function[]>
    let v5 : Mut1 = v4.[0] |> unbox
    let v6 : JS.Function = v4.[1] |> unbox
    let v7 : string = "Input"
    let v8 : string = "@hope-ui/solid"
    let v9 : JS.Function = import v7 v8
    let struct (v10 : US1, v11 : US1, v12 : US3, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US1, v18 : US1, v19 : US4, v20 : US5, v21 : US1, v22 : US1, v23 : US4, v24 : US6, v25 : US1, v26 : US1, v27 : US1, v28 : US7, v29 : US4, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US8, v36 : US1, v37 : US1, v38 : US1, v39 : US8, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US9, v49 : US10, v50 : US9, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US8, v67 : US1, v68 : US1, v69 : US6, v70 : US1, v71 : US0, v72 : US1) = method4()
    let v73 : (Mut1 -> US1) = v0.l0
    let v74 : US1 = v73 v5
    let v75 : string = JS.undefined
    let v77 : string =
        match v74 with
        | US1_0 -> (* None *)
            v75
        | US1_1(v76) -> (* Some *)
            v76
    let v78 : obj = v77
    let v79 : (unit -> (JSX.Element [])) = closure75()
    let v80 : US5 = US5_1(v79)
    let v81 : (obj -> unit) = closure76(v0, v5, v6)
    let v82 : US9 = US9_1(v81)
    let v83 : string = "xs"
    let v84 : US1 = US1_1(v83)
    let v85 : string = "text"
    let v86 : US1 = US1_1(v85)
    let v87 : US6 = US6_1(v78)
    let v88 : ((string * obj) []) = method5(v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v80, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v82, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v84, v62, v63, v64, v65, v66, v67, v86, v87, v70, v71, v72)
    let v89 : obj = createObj v88
    let v90 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v91 : string = "createComponent"
    let v92 : string = "solid-js"
    let v93 : JS.Function = import v91 v92
    let v94 : JSX.Element = v93.Invoke (v90, v89) |> unbox<JSX.Element>
    v94
and closure77 () (v0 : Mut1) : US1 =
    let struct (v1 : (struct (string * string * string * string) []), v2 : US0, v3 : US1, v4 : US1) = v0.l0, v0.l1, v0.l2, v0.l3
    v3
and closure80 (v0 : Mut1) (v1 : US1) : unit =
    v0.l2 <- v1
    ()
and closure79 () (v0 : Mut1) : (US1 -> unit) =
    closure80(v0)
and closure78 () (v0 : Mut1) : (Mut1 -> (US1 -> unit)) =
    closure79()
and closure73 () () : (JSX.Element []) =
    let v0 : (Mut7 -> JSX.Element) = closure74()
    let v1 : (Mut1 -> US1) = closure77()
    let v2 : (Mut1 -> (Mut1 -> (US1 -> unit))) = closure78()
    let v3 : Mut7 = {l0 = v1; l1 = v2} : Mut7
    let v4 : obj = v3
    let v5 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v5, v4) |> unbox<JSX.Element>
    [|v9|]
and closure82 () (v0 : Mut1) : US1 =
    let struct (v1 : (struct (string * string * string * string) []), v2 : US0, v3 : US1, v4 : US1) = v0.l0, v0.l1, v0.l2, v0.l3
    v4
and closure85 (v0 : Mut1) (v1 : US1) : unit =
    v0.l3 <- v1
    ()
and closure84 () (v0 : Mut1) : (US1 -> unit) =
    closure85(v0)
and closure83 () (v0 : Mut1) : (Mut1 -> (US1 -> unit)) =
    closure84()
and closure81 () () : (JSX.Element []) =
    let v0 : (Mut7 -> JSX.Element) = closure74()
    let v1 : (Mut1 -> US1) = closure82()
    let v2 : (Mut1 -> (Mut1 -> (US1 -> unit))) = closure83()
    let v3 : Mut7 = {l0 = v1; l1 = v2} : Mut7
    let v4 : obj = v3
    let v5 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v5, v4) |> unbox<JSX.Element>
    [|v9|]
and closure88 (v0 : Mut8, v1 : Mut1, v2 : JS.Function) (v3 : obj) : unit =
    let v4 : int32 = v3?currentTarget?value
    let v5 : ((string * obj) []) = Array.zeroCreate<(string * obj)> (0)
    let v6 : obj = createObj v5
    let v7 : Mut1 = v6 |> unbox
    let v8 : (Mut1 -> (Mut1 -> (US0 -> unit))) = v0.l1
    let v9 : (Mut1 -> (US0 -> unit)) = v8 v1
    let v10 : (US0 -> unit) = v9 v7
    let v11 : US0 = US0_1(v4)
    v10 v11
    let v12 : obj = v7
    v2.Invoke ("set", v12) |> ignore
    ()
and closure87 () (v0 : Mut8) : JSX.Element =
    let v1 : string = "useStoreon"
    let v2 : string = "@storeon/solidjs"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke () |> unbox<JS.Function[]>
    let v5 : Mut1 = v4.[0] |> unbox
    let v6 : JS.Function = v4.[1] |> unbox
    let v7 : string = "Input"
    let v8 : string = "@hope-ui/solid"
    let v9 : JS.Function = import v7 v8
    let struct (v10 : US1, v11 : US1, v12 : US3, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US1, v18 : US1, v19 : US4, v20 : US5, v21 : US1, v22 : US1, v23 : US4, v24 : US6, v25 : US1, v26 : US1, v27 : US1, v28 : US7, v29 : US4, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US8, v36 : US1, v37 : US1, v38 : US1, v39 : US8, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US9, v49 : US10, v50 : US9, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US8, v67 : US1, v68 : US1, v69 : US6, v70 : US1, v71 : US0, v72 : US1) = method4()
    let v73 : (Mut1 -> US0) = v0.l0
    let v74 : US0 = v73 v5
    let v75 : int32 = JS.undefined
    let v77 : int32 =
        match v74 with
        | US0_0 -> (* None *)
            v75
        | US0_1(v76) -> (* Some *)
            v76
    let v78 : obj = v77
    let v79 : (unit -> (JSX.Element [])) = closure75()
    let v80 : US5 = US5_1(v79)
    let v81 : (obj -> unit) = closure88(v0, v5, v6)
    let v82 : US9 = US9_1(v81)
    let v83 : string = "xs"
    let v84 : US1 = US1_1(v83)
    let v85 : string = "text"
    let v86 : US1 = US1_1(v85)
    let v87 : US6 = US6_1(v78)
    let v88 : ((string * obj) []) = method5(v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v80, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v82, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v84, v62, v63, v64, v65, v66, v67, v86, v87, v70, v71, v72)
    let v89 : obj = createObj v88
    let v90 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v91 : string = "createComponent"
    let v92 : string = "solid-js"
    let v93 : JS.Function = import v91 v92
    let v94 : JSX.Element = v93.Invoke (v90, v89) |> unbox<JSX.Element>
    v94
and closure89 () (v0 : Mut1) : US0 =
    let struct (v1 : (struct (string * string * string * string) []), v2 : US0, v3 : US1, v4 : US1) = v0.l0, v0.l1, v0.l2, v0.l3
    v2
and closure92 (v0 : Mut1) (v1 : US0) : unit =
    v0.l1 <- v1
    ()
and closure91 () (v0 : Mut1) : (US0 -> unit) =
    closure92(v0)
and closure90 () (v0 : Mut1) : (Mut1 -> (US0 -> unit)) =
    closure91()
and closure86 () () : (JSX.Element []) =
    let v0 : (Mut8 -> JSX.Element) = closure87()
    let v1 : (Mut1 -> US0) = closure89()
    let v2 : (Mut1 -> (Mut1 -> (US0 -> unit))) = closure90()
    let v3 : Mut8 = {l0 = v1; l1 = v2} : Mut8
    let v4 : obj = v3
    let v5 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v5, v4) |> unbox<JSX.Element>
    [|v9|]
and closure72 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure10()
    let struct (v1 : US1, v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method4()
    let v64 : string = "Token"
    let v65 : JSX.Element = Html.fragment [ v64 |> unbox<JSX.Element> ]
    let v66 : (unit -> (JSX.Element [])) = closure73()
    let v67 : US5 = US5_1(v66)
    let v68 : string = "3px"
    let v69 : US1 = US1_1(v68)
    let v70 : US8 = US8_1(v65)
    let v71 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v67; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v69; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v70; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63} : Mut2
    let v72 : US11 = US11_0
    let v73 : US12 = US12_2
    let v74 : Mut3 = {l0 = v72; l1 = v71; l2 = v73} : Mut3
    let v75 : obj = v74
    let v76 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v77 : string = "createComponent"
    let v78 : string = "solid-js"
    let v79 : JS.Function = import v77 v78
    let v80 : JSX.Element = v79.Invoke (v76, v75) |> unbox<JSX.Element>
    let struct (v81 : US1, v82 : US1, v83 : US3, v84 : US1, v85 : US1, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US4, v91 : US5, v92 : US1, v93 : US1, v94 : US4, v95 : US6, v96 : US1, v97 : US1, v98 : US1, v99 : US7, v100 : US4, v101 : US1, v102 : US1, v103 : US1, v104 : US1, v105 : US1, v106 : US8, v107 : US1, v108 : US1, v109 : US1, v110 : US8, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US9, v120 : US10, v121 : US9, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US1, v136 : US1, v137 : US8, v138 : US1, v139 : US1, v140 : US6, v141 : US1, v142 : US0, v143 : US1) = method4()
    let v144 : string = "URL"
    let v145 : JSX.Element = Html.fragment [ v144 |> unbox<JSX.Element> ]
    let v146 : (unit -> (JSX.Element [])) = closure81()
    let v147 : US5 = US5_1(v146)
    let v148 : US1 = US1_1(v68)
    let v149 : US8 = US8_1(v145)
    let v150 : Mut2 = {l0 = v81; l1 = v82; l2 = v83; l3 = v84; l4 = v85; l5 = v86; l6 = v87; l7 = v88; l8 = v89; l9 = v90; l10 = v147; l11 = v92; l12 = v93; l13 = v94; l14 = v95; l15 = v96; l16 = v97; l17 = v98; l18 = v99; l19 = v100; l20 = v101; l21 = v102; l22 = v103; l23 = v104; l24 = v105; l25 = v106; l26 = v107; l27 = v108; l28 = v109; l29 = v110; l30 = v111; l31 = v112; l32 = v113; l33 = v114; l34 = v115; l35 = v116; l36 = v117; l37 = v118; l38 = v119; l39 = v120; l40 = v121; l41 = v122; l42 = v123; l43 = v124; l44 = v148; l45 = v126; l46 = v127; l47 = v128; l48 = v129; l49 = v130; l50 = v131; l51 = v132; l52 = v133; l53 = v134; l54 = v135; l55 = v136; l56 = v149; l57 = v138; l58 = v139; l59 = v140; l60 = v141; l61 = v142; l62 = v143} : Mut2
    let v151 : US11 = US11_0
    let v152 : US12 = US12_2
    let v153 : Mut3 = {l0 = v151; l1 = v150; l2 = v152} : Mut3
    let v154 : obj = v153
    let v155 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v156 : JS.Function = import v77 v78
    let v157 : JSX.Element = v156.Invoke (v155, v154) |> unbox<JSX.Element>
    let struct (v158 : US1, v159 : US1, v160 : US3, v161 : US1, v162 : US1, v163 : US1, v164 : US1, v165 : US1, v166 : US1, v167 : US4, v168 : US5, v169 : US1, v170 : US1, v171 : US4, v172 : US6, v173 : US1, v174 : US1, v175 : US1, v176 : US7, v177 : US4, v178 : US1, v179 : US1, v180 : US1, v181 : US1, v182 : US1, v183 : US8, v184 : US1, v185 : US1, v186 : US1, v187 : US8, v188 : US1, v189 : US1, v190 : US1, v191 : US1, v192 : US1, v193 : US1, v194 : US1, v195 : US1, v196 : US9, v197 : US10, v198 : US9, v199 : US1, v200 : US1, v201 : US1, v202 : US1, v203 : US1, v204 : US1, v205 : US1, v206 : US1, v207 : US1, v208 : US1, v209 : US1, v210 : US1, v211 : US1, v212 : US1, v213 : US1, v214 : US8, v215 : US1, v216 : US1, v217 : US6, v218 : US1, v219 : US0, v220 : US1) = method4()
    let v221 : string = "Port"
    let v222 : JSX.Element = Html.fragment [ v221 |> unbox<JSX.Element> ]
    let v223 : (unit -> (JSX.Element [])) = closure86()
    let v224 : US5 = US5_1(v223)
    let v225 : US1 = US1_1(v68)
    let v226 : US8 = US8_1(v222)
    let v227 : Mut2 = {l0 = v158; l1 = v159; l2 = v160; l3 = v161; l4 = v162; l5 = v163; l6 = v164; l7 = v165; l8 = v166; l9 = v167; l10 = v224; l11 = v169; l12 = v170; l13 = v171; l14 = v172; l15 = v173; l16 = v174; l17 = v175; l18 = v176; l19 = v177; l20 = v178; l21 = v179; l22 = v180; l23 = v181; l24 = v182; l25 = v183; l26 = v184; l27 = v185; l28 = v186; l29 = v187; l30 = v188; l31 = v189; l32 = v190; l33 = v191; l34 = v192; l35 = v193; l36 = v194; l37 = v195; l38 = v196; l39 = v197; l40 = v198; l41 = v199; l42 = v200; l43 = v201; l44 = v225; l45 = v203; l46 = v204; l47 = v205; l48 = v206; l49 = v207; l50 = v208; l51 = v209; l52 = v210; l53 = v211; l54 = v212; l55 = v213; l56 = v226; l57 = v215; l58 = v216; l59 = v217; l60 = v218; l61 = v219; l62 = v220} : Mut2
    let v228 : US11 = US11_0
    let v229 : US12 = US12_2
    let v230 : Mut3 = {l0 = v228; l1 = v227; l2 = v229} : Mut3
    let v231 : obj = v230
    let v232 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v233 : JS.Function = import v77 v78
    let v234 : JSX.Element = v233.Invoke (v232, v231) |> unbox<JSX.Element>
    [|v80; v157; v234|]
and closure71 () (v0 : Mut2) : JSX.Element =
    let v1 : (Mut2 -> JSX.Element) = closure6()
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method4()
    let v65 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    let struct (v66 : US1, v67 : US1, v68 : US3, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US4, v76 : US5, v77 : US1, v78 : US1, v79 : US4, v80 : US6, v81 : US1, v82 : US1, v83 : US1, v84 : US7, v85 : US4, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US8, v92 : US1, v93 : US1, v94 : US1, v95 : US8, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US9, v105 : US10, v106 : US9, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US8, v123 : US1, v124 : US1, v125 : US6, v126 : US1, v127 : US0, v128 : US1) = v65.l0, v65.l1, v65.l2, v65.l3, v65.l4, v65.l5, v65.l6, v65.l7, v65.l8, v65.l9, v65.l10, v65.l11, v65.l12, v65.l13, v65.l14, v65.l15, v65.l16, v65.l17, v65.l18, v65.l19, v65.l20, v65.l21, v65.l22, v65.l23, v65.l24, v65.l25, v65.l26, v65.l27, v65.l28, v65.l29, v65.l30, v65.l31, v65.l32, v65.l33, v65.l34, v65.l35, v65.l36, v65.l37, v65.l38, v65.l39, v65.l40, v65.l41, v65.l42, v65.l43, v65.l44, v65.l45, v65.l46, v65.l47, v65.l48, v65.l49, v65.l50, v65.l51, v65.l52, v65.l53, v65.l54, v65.l55, v65.l56, v65.l57, v65.l58, v65.l59, v65.l60, v65.l61, v65.l62
    let v129 : (unit -> (JSX.Element [])) = closure72()
    let v130 : US5 = US5_1(v129)
    emitJsExpr (struct (v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v130, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128), v129) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v131 : US5 = US5_1(v129)
    let v132 : Mut2 = {l0 = v66; l1 = v67; l2 = v68; l3 = v69; l4 = v70; l5 = v71; l6 = v72; l7 = v73; l8 = v74; l9 = v75; l10 = v131; l11 = v77; l12 = v78; l13 = v79; l14 = v80; l15 = v81; l16 = v82; l17 = v83; l18 = v84; l19 = v85; l20 = v86; l21 = v87; l22 = v88; l23 = v89; l24 = v90; l25 = v91; l26 = v92; l27 = v93; l28 = v94; l29 = v95; l30 = v96; l31 = v97; l32 = v98; l33 = v99; l34 = v100; l35 = v101; l36 = v102; l37 = v103; l38 = v104; l39 = v105; l40 = v106; l41 = v107; l42 = v108; l43 = v109; l44 = v110; l45 = v111; l46 = v112; l47 = v113; l48 = v114; l49 = v115; l50 = v116; l51 = v117; l52 = v118; l53 = v119; l54 = v120; l55 = v121; l56 = v122; l57 = v123; l58 = v124; l59 = v125; l60 = v126; l61 = v127; l62 = v128} : Mut2
    let v133 : obj = v132
    let v134 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v135 : string = "createComponent"
    let v136 : string = "solid-js"
    let v137 : JS.Function = import v135 v136
    let v138 : JSX.Element = v137.Invoke (v134, v133) |> unbox<JSX.Element>
    v138
and closure93 () () : (JSX.Element []) =
    [||]
and closure70 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure71()
    let struct (v1 : US1, v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method4()
    let v64 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63} : Mut2
    let struct (v65 : US1, v66 : US1, v67 : US3, v68 : US1, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US4, v75 : US5, v76 : US1, v77 : US1, v78 : US4, v79 : US6, v80 : US1, v81 : US1, v82 : US1, v83 : US7, v84 : US4, v85 : US1, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US8, v91 : US1, v92 : US1, v93 : US1, v94 : US8, v95 : US1, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US9, v104 : US10, v105 : US9, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US8, v122 : US1, v123 : US1, v124 : US6, v125 : US1, v126 : US0, v127 : US1) = v64.l0, v64.l1, v64.l2, v64.l3, v64.l4, v64.l5, v64.l6, v64.l7, v64.l8, v64.l9, v64.l10, v64.l11, v64.l12, v64.l13, v64.l14, v64.l15, v64.l16, v64.l17, v64.l18, v64.l19, v64.l20, v64.l21, v64.l22, v64.l23, v64.l24, v64.l25, v64.l26, v64.l27, v64.l28, v64.l29, v64.l30, v64.l31, v64.l32, v64.l33, v64.l34, v64.l35, v64.l36, v64.l37, v64.l38, v64.l39, v64.l40, v64.l41, v64.l42, v64.l43, v64.l44, v64.l45, v64.l46, v64.l47, v64.l48, v64.l49, v64.l50, v64.l51, v64.l52, v64.l53, v64.l54, v64.l55, v64.l56, v64.l57, v64.l58, v64.l59, v64.l60, v64.l61, v64.l62
    let v128 : (unit -> (JSX.Element [])) = closure93()
    let v129 : US5 = US5_1(v128)
    emitJsExpr (struct (v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v129, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127), v128) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v130 : US5 = US5_1(v128)
    let v131 : Mut2 = {l0 = v65; l1 = v66; l2 = v67; l3 = v68; l4 = v69; l5 = v70; l6 = v71; l7 = v72; l8 = v73; l9 = v74; l10 = v130; l11 = v76; l12 = v77; l13 = v78; l14 = v79; l15 = v80; l16 = v81; l17 = v82; l18 = v83; l19 = v84; l20 = v85; l21 = v86; l22 = v87; l23 = v88; l24 = v89; l25 = v90; l26 = v91; l27 = v92; l28 = v93; l29 = v94; l30 = v95; l31 = v96; l32 = v97; l33 = v98; l34 = v99; l35 = v100; l36 = v101; l37 = v102; l38 = v103; l39 = v104; l40 = v105; l41 = v106; l42 = v107; l43 = v108; l44 = v109; l45 = v110; l46 = v111; l47 = v112; l48 = v113; l49 = v114; l50 = v115; l51 = v116; l52 = v117; l53 = v118; l54 = v119; l55 = v120; l56 = v121; l57 = v122; l58 = v123; l59 = v124; l60 = v125; l61 = v126; l62 = v127} : Mut2
    let v132 : obj = v131
    let v133 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v134 : string = "createComponent"
    let v135 : string = "solid-js"
    let v136 : JS.Function = import v134 v135
    let v137 : JSX.Element = v136.Invoke (v133, v132) |> unbox<JSX.Element>
    [|v137|]
and closure101 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : US1 =
    US1_1(v0)
and closure104 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : Mut1, v5 : Mut1) (v6 : US1) : unit =
    let struct (v7 : (struct (string * string * string * string) []), v8 : US0, v9 : US1, v10 : US1) = v4.l0, v4.l1, v4.l2, v4.l3
    let v11 : int32 = v7.Length
    let v12 : (struct (string * string * string * string) []) = Array.zeroCreate<struct (string * string * string * string)> (v11)
    let v13 : Mut5 = {l0 = 0} : Mut5
    while method12(v11, v13) do
        let v15 : int32 = v13.l0
        let struct (v16 : string, v17 : string, v18 : string, v19 : string) = v7.[int v15]
        let v20 : bool = v17 = v1
        let struct (v24 : string, v25 : string, v26 : string, v27 : string) =
            if v20 then
                let v23 : string =
                    match v6 with
                    | US1_0 -> (* None *)
                        let v21 : string = ""
                        v21
                    | US1_1(v22) -> (* Some *)
                        v22
                struct (v23, v17, v18, v19)
            else
                struct (v16, v17, v18, v19)
        v12.[int v15] <- struct (v24, v25, v26, v27)
        let v28 : int32 = v15 + 1
        v13.l0 <- v28
        ()
    v5.l0 <- v12
    ()
and closure103 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : Mut1) (v5 : Mut1) : (US1 -> unit) =
    closure104(v0, v1, v2, v3, v4, v5)
and closure102 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : (Mut1 -> (US1 -> unit)) =
    closure103(v0, v1, v2, v3, v4)
and closure100 (v0 : string, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut7 -> JSX.Element) = closure74()
    let v5 : (Mut1 -> US1) = closure101(v0, v1, v2, v3)
    let v6 : (Mut1 -> (Mut1 -> (US1 -> unit))) = closure102(v0, v1, v2, v3)
    let v7 : Mut7 = {l0 = v5; l1 = v6} : Mut7
    let v8 : obj = v7
    let v9 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v9, v8) |> unbox<JSX.Element>
    [|v13|]
and closure106 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : US1 =
    US1_1(v3)
and closure109 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : Mut1, v5 : Mut1) (v6 : US1) : unit =
    let struct (v7 : (struct (string * string * string * string) []), v8 : US0, v9 : US1, v10 : US1) = v4.l0, v4.l1, v4.l2, v4.l3
    let v11 : int32 = v7.Length
    let v12 : (struct (string * string * string * string) []) = Array.zeroCreate<struct (string * string * string * string)> (v11)
    let v13 : Mut5 = {l0 = 0} : Mut5
    while method12(v11, v13) do
        let v15 : int32 = v13.l0
        let struct (v16 : string, v17 : string, v18 : string, v19 : string) = v7.[int v15]
        let v20 : bool = v17 = v1
        let struct (v24 : string, v25 : string, v26 : string, v27 : string) =
            if v20 then
                let v23 : string =
                    match v6 with
                    | US1_0 -> (* None *)
                        let v21 : string = ""
                        v21
                    | US1_1(v22) -> (* Some *)
                        v22
                struct (v16, v17, v18, v23)
            else
                struct (v16, v17, v18, v19)
        v12.[int v15] <- struct (v24, v25, v26, v27)
        let v28 : int32 = v15 + 1
        v13.l0 <- v28
        ()
    v5.l0 <- v12
    ()
and closure108 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : Mut1) (v5 : Mut1) : (US1 -> unit) =
    closure109(v0, v1, v2, v3, v4, v5)
and closure107 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : (Mut1 -> (US1 -> unit)) =
    closure108(v0, v1, v2, v3, v4)
and closure105 (v0 : string, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut7 -> JSX.Element) = closure74()
    let v5 : (Mut1 -> US1) = closure106(v0, v1, v2, v3)
    let v6 : (Mut1 -> (Mut1 -> (US1 -> unit))) = closure107(v0, v1, v2, v3)
    let v7 : Mut7 = {l0 = v5; l1 = v6} : Mut7
    let v8 : obj = v7
    let v9 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v9, v8) |> unbox<JSX.Element>
    [|v13|]
and closure99 (v0 : string, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut3 -> JSX.Element) = closure10()
    let struct (v5 : US1, v6 : US1, v7 : US3, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US4, v15 : US5, v16 : US1, v17 : US1, v18 : US4, v19 : US6, v20 : US1, v21 : US1, v22 : US1, v23 : US7, v24 : US4, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US8, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US9, v44 : US10, v45 : US9, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US8, v62 : US1, v63 : US1, v64 : US6, v65 : US1, v66 : US0, v67 : US1) = method4()
    let v68 : string = "Address"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure100(v0, v1, v2, v3)
    let v71 : US5 = US5_1(v70)
    let v72 : string = "3px"
    let v73 : US1 = US1_1(v72)
    let v74 : US8 = US8_1(v69)
    let v75 : Mut2 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v71; l11 = v16; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v73; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v74; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66; l62 = v67} : Mut2
    let v76 : US11 = US11_0
    let v77 : US12 = US12_2
    let v78 : Mut3 = {l0 = v76; l1 = v75; l2 = v77} : Mut3
    let v79 : obj = v78
    let v80 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v81 : string = "createComponent"
    let v82 : string = "solid-js"
    let v83 : JS.Function = import v81 v82
    let v84 : JSX.Element = v83.Invoke (v80, v79) |> unbox<JSX.Element>
    let struct (v85 : US1, v86 : US1, v87 : US3, v88 : US1, v89 : US1, v90 : US1, v91 : US1, v92 : US1, v93 : US1, v94 : US4, v95 : US5, v96 : US1, v97 : US1, v98 : US4, v99 : US6, v100 : US1, v101 : US1, v102 : US1, v103 : US7, v104 : US4, v105 : US1, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US8, v111 : US1, v112 : US1, v113 : US1, v114 : US8, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US9, v124 : US10, v125 : US9, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US1, v136 : US1, v137 : US1, v138 : US1, v139 : US1, v140 : US1, v141 : US8, v142 : US1, v143 : US1, v144 : US6, v145 : US1, v146 : US0, v147 : US1) = method4()
    let v148 : string = "Private Key"
    let v149 : JSX.Element = Html.fragment [ v148 |> unbox<JSX.Element> ]
    let v150 : (unit -> (JSX.Element [])) = closure105(v0, v1, v2, v3)
    let v151 : US5 = US5_1(v150)
    let v152 : US1 = US1_1(v72)
    let v153 : US8 = US8_1(v149)
    let v154 : Mut2 = {l0 = v85; l1 = v86; l2 = v87; l3 = v88; l4 = v89; l5 = v90; l6 = v91; l7 = v92; l8 = v93; l9 = v94; l10 = v151; l11 = v96; l12 = v97; l13 = v98; l14 = v99; l15 = v100; l16 = v101; l17 = v102; l18 = v103; l19 = v104; l20 = v105; l21 = v106; l22 = v107; l23 = v108; l24 = v109; l25 = v110; l26 = v111; l27 = v112; l28 = v113; l29 = v114; l30 = v115; l31 = v116; l32 = v117; l33 = v118; l34 = v119; l35 = v120; l36 = v121; l37 = v122; l38 = v123; l39 = v124; l40 = v125; l41 = v126; l42 = v127; l43 = v128; l44 = v152; l45 = v130; l46 = v131; l47 = v132; l48 = v133; l49 = v134; l50 = v135; l51 = v136; l52 = v137; l53 = v138; l54 = v139; l55 = v140; l56 = v153; l57 = v142; l58 = v143; l59 = v144; l60 = v145; l61 = v146; l62 = v147} : Mut2
    let v155 : US11 = US11_0
    let v156 : US12 = US12_2
    let v157 : Mut3 = {l0 = v155; l1 = v154; l2 = v156} : Mut3
    let v158 : obj = v157
    let v159 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v160 : JS.Function = import v81 v82
    let v161 : JSX.Element = v160.Invoke (v159, v158) |> unbox<JSX.Element>
    [|v84; v161|]
and closure98 (v0 : string, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut2 -> JSX.Element) = closure6()
    let struct (v5 : US1, v6 : US1, v7 : US3, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US4, v15 : US5, v16 : US1, v17 : US1, v18 : US4, v19 : US6, v20 : US1, v21 : US1, v22 : US1, v23 : US7, v24 : US4, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US8, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US9, v44 : US10, v45 : US9, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US8, v62 : US1, v63 : US1, v64 : US6, v65 : US1, v66 : US0, v67 : US1) = method4()
    let v68 : Mut2 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v15; l11 = v16; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v61; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66; l62 = v67} : Mut2
    let struct (v69 : US1, v70 : US1, v71 : US3, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US1, v77 : US1, v78 : US4, v79 : US5, v80 : US1, v81 : US1, v82 : US4, v83 : US6, v84 : US1, v85 : US1, v86 : US1, v87 : US7, v88 : US4, v89 : US1, v90 : US1, v91 : US1, v92 : US1, v93 : US1, v94 : US8, v95 : US1, v96 : US1, v97 : US1, v98 : US8, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US1, v105 : US1, v106 : US1, v107 : US9, v108 : US10, v109 : US9, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US8, v126 : US1, v127 : US1, v128 : US6, v129 : US1, v130 : US0, v131 : US1) = v68.l0, v68.l1, v68.l2, v68.l3, v68.l4, v68.l5, v68.l6, v68.l7, v68.l8, v68.l9, v68.l10, v68.l11, v68.l12, v68.l13, v68.l14, v68.l15, v68.l16, v68.l17, v68.l18, v68.l19, v68.l20, v68.l21, v68.l22, v68.l23, v68.l24, v68.l25, v68.l26, v68.l27, v68.l28, v68.l29, v68.l30, v68.l31, v68.l32, v68.l33, v68.l34, v68.l35, v68.l36, v68.l37, v68.l38, v68.l39, v68.l40, v68.l41, v68.l42, v68.l43, v68.l44, v68.l45, v68.l46, v68.l47, v68.l48, v68.l49, v68.l50, v68.l51, v68.l52, v68.l53, v68.l54, v68.l55, v68.l56, v68.l57, v68.l58, v68.l59, v68.l60, v68.l61, v68.l62
    let v132 : (unit -> (JSX.Element [])) = closure99(v0, v1, v2, v3)
    let v133 : US5 = US5_1(v132)
    emitJsExpr (struct (v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v133, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131), v132) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v134 : US5 = US5_1(v132)
    let v135 : Mut2 = {l0 = v69; l1 = v70; l2 = v71; l3 = v72; l4 = v73; l5 = v74; l6 = v75; l7 = v76; l8 = v77; l9 = v78; l10 = v134; l11 = v80; l12 = v81; l13 = v82; l14 = v83; l15 = v84; l16 = v85; l17 = v86; l18 = v87; l19 = v88; l20 = v89; l21 = v90; l22 = v91; l23 = v92; l24 = v93; l25 = v94; l26 = v95; l27 = v96; l28 = v97; l29 = v98; l30 = v99; l31 = v100; l32 = v101; l33 = v102; l34 = v103; l35 = v104; l36 = v105; l37 = v106; l38 = v107; l39 = v108; l40 = v109; l41 = v110; l42 = v111; l43 = v112; l44 = v113; l45 = v114; l46 = v115; l47 = v116; l48 = v117; l49 = v118; l50 = v119; l51 = v120; l52 = v121; l53 = v122; l54 = v123; l55 = v124; l56 = v125; l57 = v126; l58 = v127; l59 = v128; l60 = v129; l61 = v130; l62 = v131} : Mut2
    let v136 : obj = v135
    let v137 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v138 : string = "createComponent"
    let v139 : string = "solid-js"
    let v140 : JS.Function = import v138 v139
    let v141 : JSX.Element = v140.Invoke (v137, v136) |> unbox<JSX.Element>
    [|v141|]
and closure97 () struct (v0 : string, v1 : string, v2 : string, v3 : string) : (JSX.Element []) =
    let v4 : (Mut3 -> JSX.Element) = closure10()
    let struct (v5 : US1, v6 : US1, v7 : US3, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US4, v15 : US5, v16 : US1, v17 : US1, v18 : US4, v19 : US6, v20 : US1, v21 : US1, v22 : US1, v23 : US7, v24 : US4, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US8, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US9, v44 : US10, v45 : US9, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US8, v62 : US1, v63 : US1, v64 : US6, v65 : US1, v66 : US0, v67 : US1) = method4()
    let v68 : JSX.Element = Html.fragment [ v1 |> unbox<JSX.Element> ]
    let v69 : (unit -> (JSX.Element [])) = closure98(v0, v1, v2, v3)
    let v70 : US5 = US5_1(v69)
    let v71 : US8 = US8_1(v68)
    let v72 : Mut2 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v70; l11 = v16; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v71; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66; l62 = v67} : Mut2
    let v73 : US11 = US11_0
    let v74 : US12 = US12_2
    let v75 : Mut3 = {l0 = v73; l1 = v72; l2 = v74} : Mut3
    let v76 : obj = v75
    let v77 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v78 : string = "createComponent"
    let v79 : string = "solid-js"
    let v80 : JS.Function = import v78 v79
    let v81 : JSX.Element = v80.Invoke (v77, v76) |> unbox<JSX.Element>
    [|v81|]
and closure96 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (string * string * string * string) []), v2 : US0, v3 : US1, v4 : US1) = v0.l0, v0.l1, v0.l2, v0.l3
    let v5 : string = "For"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (struct (string * string * string * string) -> (JSX.Element [])) = closure97()
    let v9 : (unit -> (JSX.Element [])) = v8 |> unbox
    let struct (v10 : US1, v11 : US1, v12 : US3, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US1, v18 : US1, v19 : US4, v20 : US5, v21 : US1, v22 : US1, v23 : US4, v24 : US6, v25 : US1, v26 : US1, v27 : US1, v28 : US7, v29 : US4, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US8, v36 : US1, v37 : US1, v38 : US1, v39 : US8, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US9, v49 : US10, v50 : US9, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US8, v67 : US1, v68 : US1, v69 : US6, v70 : US1, v71 : US0, v72 : US1) = method4()
    let v74 : (struct (string * string * string * string) []) = [||]
    let v75 : int32 = v1.Length
    let v76 : (obj []) = Array.zeroCreate<obj> (v75)
    let v77 : Mut5 = {l0 = 0} : Mut5
    while method12(v75, v77) do
        let v79 : int32 = v77.l0
        let struct (v80 : string, v81 : string, v82 : string, v83 : string) = v1.[int v79]
        let v84 : obj = struct (v80, v81, v82, v83)
        v76.[int v79] <- v84
        let v85 : int32 = v79 + 1
        v77.l0 <- v85
        ()
    let v86 : US5 = US5_1(v9)
    let v87 : US7 = US7_1(v76)
    let v88 : ((string * obj) []) = method5(v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v86, v21, v22, v23, v24, v25, v26, v27, v87, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v89 : obj = createObj v88
    let v90 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v91 : string = "createComponent"
    let v92 : JS.Function = import v91 v6
    let v93 : JSX.Element = v92.Invoke (v90, v89) |> unbox<JSX.Element>
    [|v93|]
and closure95 () (v0 : Mut2) : JSX.Element =
    let v1 : string = "useStoreon"
    let v2 : string = "@storeon/solidjs"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke () |> unbox<JS.Function[]>
    let v5 : Mut1 = v4.[0] |> unbox
    let v6 : JS.Function = v4.[1] |> unbox
    let v7 : (Mut2 -> JSX.Element) = closure6()
    let struct (v8 : US1, v9 : US1, v10 : US3, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US4, v18 : US5, v19 : US1, v20 : US1, v21 : US4, v22 : US6, v23 : US1, v24 : US1, v25 : US1, v26 : US7, v27 : US4, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US8, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US9, v47 : US10, v48 : US9, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US8, v65 : US1, v66 : US1, v67 : US6, v68 : US1, v69 : US0, v70 : US1) = method4()
    let v71 : Mut2 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v18; l11 = v19; l12 = v20; l13 = v21; l14 = v22; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v34; l27 = v35; l28 = v36; l29 = v37; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50; l43 = v51; l44 = v52; l45 = v53; l46 = v54; l47 = v55; l48 = v56; l49 = v57; l50 = v58; l51 = v59; l52 = v60; l53 = v61; l54 = v62; l55 = v63; l56 = v64; l57 = v65; l58 = v66; l59 = v67; l60 = v68; l61 = v69; l62 = v70} : Mut2
    let struct (v72 : US1, v73 : US1, v74 : US3, v75 : US1, v76 : US1, v77 : US1, v78 : US1, v79 : US1, v80 : US1, v81 : US4, v82 : US5, v83 : US1, v84 : US1, v85 : US4, v86 : US6, v87 : US1, v88 : US1, v89 : US1, v90 : US7, v91 : US4, v92 : US1, v93 : US1, v94 : US1, v95 : US1, v96 : US1, v97 : US8, v98 : US1, v99 : US1, v100 : US1, v101 : US8, v102 : US1, v103 : US1, v104 : US1, v105 : US1, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US9, v111 : US10, v112 : US9, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US8, v129 : US1, v130 : US1, v131 : US6, v132 : US1, v133 : US0, v134 : US1) = v71.l0, v71.l1, v71.l2, v71.l3, v71.l4, v71.l5, v71.l6, v71.l7, v71.l8, v71.l9, v71.l10, v71.l11, v71.l12, v71.l13, v71.l14, v71.l15, v71.l16, v71.l17, v71.l18, v71.l19, v71.l20, v71.l21, v71.l22, v71.l23, v71.l24, v71.l25, v71.l26, v71.l27, v71.l28, v71.l29, v71.l30, v71.l31, v71.l32, v71.l33, v71.l34, v71.l35, v71.l36, v71.l37, v71.l38, v71.l39, v71.l40, v71.l41, v71.l42, v71.l43, v71.l44, v71.l45, v71.l46, v71.l47, v71.l48, v71.l49, v71.l50, v71.l51, v71.l52, v71.l53, v71.l54, v71.l55, v71.l56, v71.l57, v71.l58, v71.l59, v71.l60, v71.l61, v71.l62
    let v135 : (unit -> (JSX.Element [])) = closure96(v5)
    let v136 : US5 = US5_1(v135)
    emitJsExpr (struct (v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v136, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134), v135) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v137 : US5 = US5_1(v135)
    let v138 : Mut2 = {l0 = v72; l1 = v73; l2 = v74; l3 = v75; l4 = v76; l5 = v77; l6 = v78; l7 = v79; l8 = v80; l9 = v81; l10 = v137; l11 = v83; l12 = v84; l13 = v85; l14 = v86; l15 = v87; l16 = v88; l17 = v89; l18 = v90; l19 = v91; l20 = v92; l21 = v93; l22 = v94; l23 = v95; l24 = v96; l25 = v97; l26 = v98; l27 = v99; l28 = v100; l29 = v101; l30 = v102; l31 = v103; l32 = v104; l33 = v105; l34 = v106; l35 = v107; l36 = v108; l37 = v109; l38 = v110; l39 = v111; l40 = v112; l41 = v113; l42 = v114; l43 = v115; l44 = v116; l45 = v117; l46 = v118; l47 = v119; l48 = v120; l49 = v121; l50 = v122; l51 = v123; l52 = v124; l53 = v125; l54 = v126; l55 = v127; l56 = v128; l57 = v129; l58 = v130; l59 = v131; l60 = v132; l61 = v133; l62 = v134} : Mut2
    let v139 : obj = v138
    let v140 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v141 : string = "createComponent"
    let v142 : string = "solid-js"
    let v143 : JS.Function = import v141 v142
    let v144 : JSX.Element = v143.Invoke (v140, v139) |> unbox<JSX.Element>
    v144
and closure110 () () : (JSX.Element []) =
    [||]
and closure94 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure95()
    let struct (v1 : US1, v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method4()
    let v64 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63} : Mut2
    let struct (v65 : US1, v66 : US1, v67 : US3, v68 : US1, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US4, v75 : US5, v76 : US1, v77 : US1, v78 : US4, v79 : US6, v80 : US1, v81 : US1, v82 : US1, v83 : US7, v84 : US4, v85 : US1, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US8, v91 : US1, v92 : US1, v93 : US1, v94 : US8, v95 : US1, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US9, v104 : US10, v105 : US9, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US8, v122 : US1, v123 : US1, v124 : US6, v125 : US1, v126 : US0, v127 : US1) = v64.l0, v64.l1, v64.l2, v64.l3, v64.l4, v64.l5, v64.l6, v64.l7, v64.l8, v64.l9, v64.l10, v64.l11, v64.l12, v64.l13, v64.l14, v64.l15, v64.l16, v64.l17, v64.l18, v64.l19, v64.l20, v64.l21, v64.l22, v64.l23, v64.l24, v64.l25, v64.l26, v64.l27, v64.l28, v64.l29, v64.l30, v64.l31, v64.l32, v64.l33, v64.l34, v64.l35, v64.l36, v64.l37, v64.l38, v64.l39, v64.l40, v64.l41, v64.l42, v64.l43, v64.l44, v64.l45, v64.l46, v64.l47, v64.l48, v64.l49, v64.l50, v64.l51, v64.l52, v64.l53, v64.l54, v64.l55, v64.l56, v64.l57, v64.l58, v64.l59, v64.l60, v64.l61, v64.l62
    let v128 : (unit -> (JSX.Element [])) = closure110()
    let v129 : US5 = US5_1(v128)
    emitJsExpr (struct (v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v129, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127), v128) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v130 : US5 = US5_1(v128)
    let v131 : Mut2 = {l0 = v65; l1 = v66; l2 = v67; l3 = v68; l4 = v69; l5 = v70; l6 = v71; l7 = v72; l8 = v73; l9 = v74; l10 = v130; l11 = v76; l12 = v77; l13 = v78; l14 = v79; l15 = v80; l16 = v81; l17 = v82; l18 = v83; l19 = v84; l20 = v85; l21 = v86; l22 = v87; l23 = v88; l24 = v89; l25 = v90; l26 = v91; l27 = v92; l28 = v93; l29 = v94; l30 = v95; l31 = v96; l32 = v97; l33 = v98; l34 = v99; l35 = v100; l36 = v101; l37 = v102; l38 = v103; l39 = v104; l40 = v105; l41 = v106; l42 = v107; l43 = v108; l44 = v109; l45 = v110; l46 = v111; l47 = v112; l48 = v113; l49 = v114; l50 = v115; l51 = v116; l52 = v117; l53 = v118; l54 = v119; l55 = v120; l56 = v121; l57 = v122; l58 = v123; l59 = v124; l60 = v125; l61 = v126; l62 = v127} : Mut2
    let v132 : obj = v131
    let v133 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v134 : string = "createComponent"
    let v135 : string = "solid-js"
    let v136 : JS.Function = import v134 v135
    let v137 : JSX.Element = v136.Invoke (v133, v132) |> unbox<JSX.Element>
    [|v137|]
and closure112 () () : (JSX.Element []) =
    [||]
and closure111 () () : (JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : JS.Function = v2?iframe
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method4()
    let v67 : string = "algorand testnet bank"
    let v68 : JSX.Element = Html.fragment [ v67 |> unbox<JSX.Element> ]
    let v69 : string = "#aaa"
    let v70 : US1 = US1_1(v69)
    let v71 : (unit -> (JSX.Element [])) = closure112()
    let v72 : US5 = US5_1(v71)
    let v73 : string = "1"
    let v74 : US1 = US1_1(v73)
    let v75 : string = "350px"
    let v76 : US1 = US1_1(v75)
    let v77 : string = "https://bank.testnet.algorand.network"
    let v78 : US1 = US1_1(v77)
    let v79 : US8 = US8_1(v68)
    let v80 : ((string * obj) []) = method5(v4, v5, v6, v70, v8, v9, v10, v11, v12, v13, v72, v15, v16, v17, v18, v19, v20, v21, v22, v23, v74, v25, v26, v76, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v78, v58, v59, v79, v61, v62, v63, v64, v65, v66)
    let v81 : obj = createObj v80
    let v82 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v83 : string = "createComponent"
    let v84 : string = "solid-js"
    let v85 : JS.Function = import v83 v84
    let v86 : JSX.Element = v85.Invoke (v82, v81) |> unbox<JSX.Element>
    [|v86|]
and closure69 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure10()
    let struct (v1 : US1, v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method4()
    let v64 : string = "Connection"
    let v65 : JSX.Element = Html.fragment [ v64 |> unbox<JSX.Element> ]
    let v66 : (unit -> (JSX.Element [])) = closure70()
    let v67 : US5 = US5_1(v66)
    let v68 : US8 = US8_1(v65)
    let v69 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v67; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v68; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63} : Mut2
    let v70 : US11 = US11_0
    let v71 : US12 = US12_2
    let v72 : Mut3 = {l0 = v70; l1 = v69; l2 = v71} : Mut3
    let v73 : obj = v72
    let v74 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v75 : string = "createComponent"
    let v76 : string = "solid-js"
    let v77 : JS.Function = import v75 v76
    let v78 : JSX.Element = v77.Invoke (v74, v73) |> unbox<JSX.Element>
    let struct (v79 : US1, v80 : US1, v81 : US3, v82 : US1, v83 : US1, v84 : US1, v85 : US1, v86 : US1, v87 : US1, v88 : US4, v89 : US5, v90 : US1, v91 : US1, v92 : US4, v93 : US6, v94 : US1, v95 : US1, v96 : US1, v97 : US7, v98 : US4, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US8, v105 : US1, v106 : US1, v107 : US1, v108 : US8, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US9, v118 : US10, v119 : US9, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US8, v136 : US1, v137 : US1, v138 : US6, v139 : US1, v140 : US0, v141 : US1) = method4()
    let v142 : string = "Accounts"
    let v143 : JSX.Element = Html.fragment [ v142 |> unbox<JSX.Element> ]
    let v144 : (unit -> (JSX.Element [])) = closure94()
    let v145 : US5 = US5_1(v144)
    let v146 : US8 = US8_1(v143)
    let v147 : Mut2 = {l0 = v79; l1 = v80; l2 = v81; l3 = v82; l4 = v83; l5 = v84; l6 = v85; l7 = v86; l8 = v87; l9 = v88; l10 = v145; l11 = v90; l12 = v91; l13 = v92; l14 = v93; l15 = v94; l16 = v95; l17 = v96; l18 = v97; l19 = v98; l20 = v99; l21 = v100; l22 = v101; l23 = v102; l24 = v103; l25 = v104; l26 = v105; l27 = v106; l28 = v107; l29 = v108; l30 = v109; l31 = v110; l32 = v111; l33 = v112; l34 = v113; l35 = v114; l36 = v115; l37 = v116; l38 = v117; l39 = v118; l40 = v119; l41 = v120; l42 = v121; l43 = v122; l44 = v123; l45 = v124; l46 = v125; l47 = v126; l48 = v127; l49 = v128; l50 = v129; l51 = v130; l52 = v131; l53 = v132; l54 = v133; l55 = v134; l56 = v146; l57 = v136; l58 = v137; l59 = v138; l60 = v139; l61 = v140; l62 = v141} : Mut2
    let v148 : US11 = US11_0
    let v149 : US12 = US12_2
    let v150 : Mut3 = {l0 = v148; l1 = v147; l2 = v149} : Mut3
    let v151 : obj = v150
    let v152 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v153 : JS.Function = import v75 v76
    let v154 : JSX.Element = v153.Invoke (v152, v151) |> unbox<JSX.Element>
    let struct (v155 : US1, v156 : US1, v157 : US3, v158 : US1, v159 : US1, v160 : US1, v161 : US1, v162 : US1, v163 : US1, v164 : US4, v165 : US5, v166 : US1, v167 : US1, v168 : US4, v169 : US6, v170 : US1, v171 : US1, v172 : US1, v173 : US7, v174 : US4, v175 : US1, v176 : US1, v177 : US1, v178 : US1, v179 : US1, v180 : US8, v181 : US1, v182 : US1, v183 : US1, v184 : US8, v185 : US1, v186 : US1, v187 : US1, v188 : US1, v189 : US1, v190 : US1, v191 : US1, v192 : US1, v193 : US9, v194 : US10, v195 : US9, v196 : US1, v197 : US1, v198 : US1, v199 : US1, v200 : US1, v201 : US1, v202 : US1, v203 : US1, v204 : US1, v205 : US1, v206 : US1, v207 : US1, v208 : US1, v209 : US1, v210 : US1, v211 : US8, v212 : US1, v213 : US1, v214 : US6, v215 : US1, v216 : US0, v217 : US1) = method4()
    let v218 : string = "Testnet Bank Dispenser"
    let v219 : JSX.Element = Html.fragment [ v218 |> unbox<JSX.Element> ]
    let v220 : (unit -> (JSX.Element [])) = closure111()
    let v221 : US5 = US5_1(v220)
    let v222 : US8 = US8_1(v219)
    let v223 : Mut2 = {l0 = v155; l1 = v156; l2 = v157; l3 = v158; l4 = v159; l5 = v160; l6 = v161; l7 = v162; l8 = v163; l9 = v164; l10 = v221; l11 = v166; l12 = v167; l13 = v168; l14 = v169; l15 = v170; l16 = v171; l17 = v172; l18 = v173; l19 = v174; l20 = v175; l21 = v176; l22 = v177; l23 = v178; l24 = v179; l25 = v180; l26 = v181; l27 = v182; l28 = v183; l29 = v184; l30 = v185; l31 = v186; l32 = v187; l33 = v188; l34 = v189; l35 = v190; l36 = v191; l37 = v192; l38 = v193; l39 = v194; l40 = v195; l41 = v196; l42 = v197; l43 = v198; l44 = v199; l45 = v200; l46 = v201; l47 = v202; l48 = v203; l49 = v204; l50 = v205; l51 = v206; l52 = v207; l53 = v208; l54 = v209; l55 = v210; l56 = v222; l57 = v212; l58 = v213; l59 = v214; l60 = v215; l61 = v216; l62 = v217} : Mut2
    let v224 : US11 = US11_0
    let v225 : US12 = US12_0
    let v226 : Mut3 = {l0 = v224; l1 = v223; l2 = v225} : Mut3
    let v227 : obj = v226
    let v228 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v229 : JS.Function = import v75 v76
    let v230 : JSX.Element = v229.Invoke (v228, v227) |> unbox<JSX.Element>
    [|v78; v154; v230|]
and closure68 () (v0 : Mut2) : JSX.Element =
    let v1 : (Mut2 -> JSX.Element) = closure6()
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method4()
    let v65 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    let struct (v66 : US1, v67 : US1, v68 : US3, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US4, v76 : US5, v77 : US1, v78 : US1, v79 : US4, v80 : US6, v81 : US1, v82 : US1, v83 : US1, v84 : US7, v85 : US4, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US8, v92 : US1, v93 : US1, v94 : US1, v95 : US8, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US9, v105 : US10, v106 : US9, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US8, v123 : US1, v124 : US1, v125 : US6, v126 : US1, v127 : US0, v128 : US1) = v65.l0, v65.l1, v65.l2, v65.l3, v65.l4, v65.l5, v65.l6, v65.l7, v65.l8, v65.l9, v65.l10, v65.l11, v65.l12, v65.l13, v65.l14, v65.l15, v65.l16, v65.l17, v65.l18, v65.l19, v65.l20, v65.l21, v65.l22, v65.l23, v65.l24, v65.l25, v65.l26, v65.l27, v65.l28, v65.l29, v65.l30, v65.l31, v65.l32, v65.l33, v65.l34, v65.l35, v65.l36, v65.l37, v65.l38, v65.l39, v65.l40, v65.l41, v65.l42, v65.l43, v65.l44, v65.l45, v65.l46, v65.l47, v65.l48, v65.l49, v65.l50, v65.l51, v65.l52, v65.l53, v65.l54, v65.l55, v65.l56, v65.l57, v65.l58, v65.l59, v65.l60, v65.l61, v65.l62
    let v129 : (unit -> (JSX.Element [])) = closure69()
    let v130 : US5 = US5_1(v129)
    emitJsExpr (struct (v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v130, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128), v129) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v131 : US5 = US5_1(v129)
    let v132 : Mut2 = {l0 = v66; l1 = v67; l2 = v68; l3 = v69; l4 = v70; l5 = v71; l6 = v72; l7 = v73; l8 = v74; l9 = v75; l10 = v131; l11 = v77; l12 = v78; l13 = v79; l14 = v80; l15 = v81; l16 = v82; l17 = v83; l18 = v84; l19 = v85; l20 = v86; l21 = v87; l22 = v88; l23 = v89; l24 = v90; l25 = v91; l26 = v92; l27 = v93; l28 = v94; l29 = v95; l30 = v96; l31 = v97; l32 = v98; l33 = v99; l34 = v100; l35 = v101; l36 = v102; l37 = v103; l38 = v104; l39 = v105; l40 = v106; l41 = v107; l42 = v108; l43 = v109; l44 = v110; l45 = v111; l46 = v112; l47 = v113; l48 = v114; l49 = v115; l50 = v116; l51 = v117; l52 = v118; l53 = v119; l54 = v120; l55 = v121; l56 = v122; l57 = v123; l58 = v124; l59 = v125; l60 = v126; l61 = v127; l62 = v128} : Mut2
    let v133 : obj = v132
    let v134 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v135 : string = "createComponent"
    let v136 : string = "solid-js"
    let v137 : JS.Function = import v135 v136
    let v138 : JSX.Element = v137.Invoke (v134, v133) |> unbox<JSX.Element>
    v138
and closure113 () () : (JSX.Element []) =
    [||]
and closure67 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure68()
    let struct (v1 : US1, v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method4()
    let v64 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63} : Mut2
    let struct (v65 : US1, v66 : US1, v67 : US3, v68 : US1, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US4, v75 : US5, v76 : US1, v77 : US1, v78 : US4, v79 : US6, v80 : US1, v81 : US1, v82 : US1, v83 : US7, v84 : US4, v85 : US1, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US8, v91 : US1, v92 : US1, v93 : US1, v94 : US8, v95 : US1, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US9, v104 : US10, v105 : US9, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US8, v122 : US1, v123 : US1, v124 : US6, v125 : US1, v126 : US0, v127 : US1) = v64.l0, v64.l1, v64.l2, v64.l3, v64.l4, v64.l5, v64.l6, v64.l7, v64.l8, v64.l9, v64.l10, v64.l11, v64.l12, v64.l13, v64.l14, v64.l15, v64.l16, v64.l17, v64.l18, v64.l19, v64.l20, v64.l21, v64.l22, v64.l23, v64.l24, v64.l25, v64.l26, v64.l27, v64.l28, v64.l29, v64.l30, v64.l31, v64.l32, v64.l33, v64.l34, v64.l35, v64.l36, v64.l37, v64.l38, v64.l39, v64.l40, v64.l41, v64.l42, v64.l43, v64.l44, v64.l45, v64.l46, v64.l47, v64.l48, v64.l49, v64.l50, v64.l51, v64.l52, v64.l53, v64.l54, v64.l55, v64.l56, v64.l57, v64.l58, v64.l59, v64.l60, v64.l61, v64.l62
    let v128 : (unit -> (JSX.Element [])) = closure113()
    let v129 : US5 = US5_1(v128)
    emitJsExpr (struct (v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v129, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127), v128) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v130 : US5 = US5_1(v128)
    let v131 : Mut2 = {l0 = v65; l1 = v66; l2 = v67; l3 = v68; l4 = v69; l5 = v70; l6 = v71; l7 = v72; l8 = v73; l9 = v74; l10 = v130; l11 = v76; l12 = v77; l13 = v78; l14 = v79; l15 = v80; l16 = v81; l17 = v82; l18 = v83; l19 = v84; l20 = v85; l21 = v86; l22 = v87; l23 = v88; l24 = v89; l25 = v90; l26 = v91; l27 = v92; l28 = v93; l29 = v94; l30 = v95; l31 = v96; l32 = v97; l33 = v98; l34 = v99; l35 = v100; l36 = v101; l37 = v102; l38 = v103; l39 = v104; l40 = v105; l41 = v106; l42 = v107; l43 = v108; l44 = v109; l45 = v110; l46 = v111; l47 = v112; l48 = v113; l49 = v114; l50 = v115; l51 = v116; l52 = v117; l53 = v118; l54 = v119; l55 = v120; l56 = v121; l57 = v122; l58 = v123; l59 = v124; l60 = v125; l61 = v126; l62 = v127} : Mut2
    let v132 : obj = v131
    let v133 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v134 : string = "createComponent"
    let v135 : string = "solid-js"
    let v136 : JS.Function = import v134 v135
    let v137 : JSX.Element = v136.Invoke (v133, v132) |> unbox<JSX.Element>
    [|v137|]
and method13 (v0 : int32, v1 : Mut11) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure122 (v0 : Mut10) (v1 : Mut1) : US1 =
    let struct (v2 : (struct (US2 * int32 * string * string) []), v3 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let v4 : (struct (US2 * int32 * string * string) -> US1) = v0.l1
    let v5 : int32 = v2.Length
    let v6 : US1 = US1_0
    let v7 : Mut11 = {l0 = 0; l1 = v6} : Mut11
    while method13(v5, v7) do
        let v9 : int32 = v7.l0
        let v10 : int32 =  -v9
        let v11 : int32 = v10 + v5
        let v12 : int32 = v11 - 1
        let v13 : US1 = v7.l1
        let struct (v14 : US2, v15 : int32, v16 : string, v17 : string) = v2.[int v12]
        let v20 : US1 =
            match v13 with
            | US1_0 -> (* None *)
                let v18 : US1 = v4 struct (v14, v15, v16, v17)
                v18
            | US1_1(v19) -> (* Some *)
                v13
        let v21 : int32 = v9 + 1
        v7.l0 <- v21
        v7.l1 <- v20
        ()
    let v22 : US1 = v7.l1
    v22
and method14 (v0 : int32, v1 : Mut12) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method15 () : struct (US2 * int32 * string * string) =
    let v0 : US2 = US2_1
    let v1 : string = ""
    struct (v0, 0, v1, v1)
and closure125 (v0 : Mut10, v1 : Mut1) (v2 : US1) : unit =
    let struct (v3 : (struct (US2 * int32 * string * string) []), v4 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let struct (v5 : (struct (US2 * int32 * string * string) []), v6 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let v7 : int32 = v5.Length
    let v8 : US13 = US13_0
    let v9 : Mut12 = {l0 = 0; l1 = v8} : Mut12
    while method14(v7, v9) do
        let v11 : int32 = v9.l0
        let v12 : int32 =  -v11
        let v13 : int32 = v12 + v7
        let v14 : int32 = v13 - 1
        let v15 : US13 = v9.l1
        let struct (v16 : US2, v17 : int32, v18 : string, v19 : string) = v5.[int v14]
        let v29 : US13 =
            match v15 with
            | US13_0 -> (* None *)
                let v20 : US2 = v0.l0
                let v21 : bool =
                    match v16, v20 with
                    | US2_0, US2_0 -> (* GunJs *)
                        true
                    | US2_1, US2_1 -> (* GunRs *)
                        true
                    | _ ->
                        false
                if v21 then
                    US13_1(v16, v17, v18, v19)
                else
                    US13_0
            | US13_1(v25, v26, v27, v28) -> (* Some *)
                v15
        let v30 : int32 = v11 + 1
        v9.l0 <- v30
        v9.l1 <- v29
        ()
    let v31 : US13 = v9.l1
    let struct (v32 : US2, v33 : int32, v34 : string, v35 : string) = method15()
    let struct (v40 : US2, v41 : int32, v42 : string, v43 : string) =
        match v31 with
        | US13_0 -> (* None *)
            struct (v32, v33, v34, v35)
        | US13_1(v36, v37, v38, v39) -> (* Some *)
            struct (v36, v37, v38, v39)
    let v44 : (struct (US2 * int32 * string * string) -> (US1 -> struct (US2 * int32 * string * string))) = v0.l2
    let v45 : (US1 -> struct (US2 * int32 * string * string)) = v44 struct (v40, v41, v42, v43)
    let struct (v46 : US2, v47 : int32, v48 : string, v49 : string) = v45 v2
    let v50 : (struct (US2 * int32 * string * string) []) = [|struct (v46, v47, v48, v49)|]
    let v51 : int32 = v3.Length
    let v52 : int32 = v50.Length
    let v53 : int32 = v51 + v52
    let v54 : (struct (US2 * int32 * string * string) []) = Array.zeroCreate<struct (US2 * int32 * string * string)> (v53)
    let v55 : Mut5 = {l0 = 0} : Mut5
    while method12(v53, v55) do
        let v57 : int32 = v55.l0
        let v58 : bool = v57 < v51
        let struct (v68 : US2, v69 : int32, v70 : string, v71 : string) =
            if v58 then
                let struct (v59 : US2, v60 : int32, v61 : string, v62 : string) = v3.[int v57]
                struct (v59, v60, v61, v62)
            else
                let v63 : int32 = v57 - v51
                let struct (v64 : US2, v65 : int32, v66 : string, v67 : string) = v50.[int v63]
                struct (v64, v65, v66, v67)
        v54.[int v57] <- struct (v68, v69, v70, v71)
        let v72 : int32 = v57 + 1
        v55.l0 <- v72
        ()
    v1.l4 <- v54
    ()
and closure124 (v0 : Mut10) (v1 : Mut1) : (US1 -> unit) =
    closure125(v0, v1)
and closure123 (v0 : Mut10) (v1 : Mut1) : (Mut1 -> (US1 -> unit)) =
    closure124(v0)
and closure121 () (v0 : Mut10) : JSX.Element =
    let v1 : (Mut7 -> JSX.Element) = closure74()
    let v2 : (Mut1 -> US1) = closure122(v0)
    let v3 : (Mut1 -> (Mut1 -> (US1 -> unit))) = closure123(v0)
    let v4 : Mut7 = {l0 = v2; l1 = v3} : Mut7
    let v5 : obj = v4
    let v6 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v6, v5) |> unbox<JSX.Element>
    v10
and closure126 () struct (v0 : US2, v1 : int32, v2 : string, v3 : string) : US1 =
    US1_1(v2)
and closure128 (v0 : Mut9, v1 : US2, v2 : int32, v3 : string, v4 : string) (v5 : US1) : struct (US2 * int32 * string * string) =
    let v6 : US2 = v0.l0
    let v9 : string =
        match v5 with
        | US1_0 -> (* None *)
            let v7 : string = ""
            v7
        | US1_1(v8) -> (* Some *)
            v8
    struct (v6, v2, v9, v4)
and closure127 (v0 : Mut9) struct (v1 : US2, v2 : int32, v3 : string, v4 : string) : (US1 -> struct (US2 * int32 * string * string)) =
    closure128(v0, v1, v2, v3, v4)
and closure120 (v0 : Mut9) () : (JSX.Element []) =
    let v1 : (Mut10 -> JSX.Element) = closure121()
    let v2 : US2 = v0.l0
    let v3 : (struct (US2 * int32 * string * string) -> US1) = closure126()
    let v4 : (struct (US2 * int32 * string * string) -> (US1 -> struct (US2 * int32 * string * string))) = closure127(v0)
    let v5 : Mut10 = {l0 = v2; l1 = v3; l2 = v4} : Mut10
    let v6 : obj = v5
    let v7 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v7, v6) |> unbox<JSX.Element>
    [|v11|]
and method16 (v0 : int32, v1 : Mut14) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure131 (v0 : Mut13) (v1 : Mut1) : US0 =
    let struct (v2 : (struct (US2 * int32 * string * string) []), v3 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let v4 : (struct (US2 * int32 * string * string) -> US0) = v0.l1
    let v5 : int32 = v2.Length
    let v6 : US0 = US0_0
    let v7 : Mut14 = {l0 = 0; l1 = v6} : Mut14
    while method16(v5, v7) do
        let v9 : int32 = v7.l0
        let v10 : int32 =  -v9
        let v11 : int32 = v10 + v5
        let v12 : int32 = v11 - 1
        let v13 : US0 = v7.l1
        let struct (v14 : US2, v15 : int32, v16 : string, v17 : string) = v2.[int v12]
        let v20 : US0 =
            match v13 with
            | US0_0 -> (* None *)
                let v18 : US0 = v4 struct (v14, v15, v16, v17)
                v18
            | US0_1(v19) -> (* Some *)
                v13
        let v21 : int32 = v9 + 1
        v7.l0 <- v21
        v7.l1 <- v20
        ()
    let v22 : US0 = v7.l1
    v22
and closure134 (v0 : Mut13, v1 : Mut1) (v2 : US0) : unit =
    let struct (v3 : (struct (US2 * int32 * string * string) []), v4 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let struct (v5 : (struct (US2 * int32 * string * string) []), v6 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let v7 : int32 = v5.Length
    let v8 : US13 = US13_0
    let v9 : Mut12 = {l0 = 0; l1 = v8} : Mut12
    while method14(v7, v9) do
        let v11 : int32 = v9.l0
        let v12 : int32 =  -v11
        let v13 : int32 = v12 + v7
        let v14 : int32 = v13 - 1
        let v15 : US13 = v9.l1
        let struct (v16 : US2, v17 : int32, v18 : string, v19 : string) = v5.[int v14]
        let v29 : US13 =
            match v15 with
            | US13_0 -> (* None *)
                let v20 : US2 = v0.l0
                let v21 : bool =
                    match v16, v20 with
                    | US2_0, US2_0 -> (* GunJs *)
                        true
                    | US2_1, US2_1 -> (* GunRs *)
                        true
                    | _ ->
                        false
                if v21 then
                    US13_1(v16, v17, v18, v19)
                else
                    US13_0
            | US13_1(v25, v26, v27, v28) -> (* Some *)
                v15
        let v30 : int32 = v11 + 1
        v9.l0 <- v30
        v9.l1 <- v29
        ()
    let v31 : US13 = v9.l1
    let struct (v32 : US2, v33 : int32, v34 : string, v35 : string) = method15()
    let struct (v40 : US2, v41 : int32, v42 : string, v43 : string) =
        match v31 with
        | US13_0 -> (* None *)
            struct (v32, v33, v34, v35)
        | US13_1(v36, v37, v38, v39) -> (* Some *)
            struct (v36, v37, v38, v39)
    let v44 : (struct (US2 * int32 * string * string) -> (US0 -> struct (US2 * int32 * string * string))) = v0.l2
    let v45 : (US0 -> struct (US2 * int32 * string * string)) = v44 struct (v40, v41, v42, v43)
    let struct (v46 : US2, v47 : int32, v48 : string, v49 : string) = v45 v2
    let v50 : (struct (US2 * int32 * string * string) []) = [|struct (v46, v47, v48, v49)|]
    let v51 : int32 = v3.Length
    let v52 : int32 = v50.Length
    let v53 : int32 = v51 + v52
    let v54 : (struct (US2 * int32 * string * string) []) = Array.zeroCreate<struct (US2 * int32 * string * string)> (v53)
    let v55 : Mut5 = {l0 = 0} : Mut5
    while method12(v53, v55) do
        let v57 : int32 = v55.l0
        let v58 : bool = v57 < v51
        let struct (v68 : US2, v69 : int32, v70 : string, v71 : string) =
            if v58 then
                let struct (v59 : US2, v60 : int32, v61 : string, v62 : string) = v3.[int v57]
                struct (v59, v60, v61, v62)
            else
                let v63 : int32 = v57 - v51
                let struct (v64 : US2, v65 : int32, v66 : string, v67 : string) = v50.[int v63]
                struct (v64, v65, v66, v67)
        v54.[int v57] <- struct (v68, v69, v70, v71)
        let v72 : int32 = v57 + 1
        v55.l0 <- v72
        ()
    v1.l4 <- v54
    ()
and closure133 (v0 : Mut13) (v1 : Mut1) : (US0 -> unit) =
    closure134(v0, v1)
and closure132 (v0 : Mut13) (v1 : Mut1) : (Mut1 -> (US0 -> unit)) =
    closure133(v0)
and closure130 () (v0 : Mut13) : JSX.Element =
    let v1 : (Mut8 -> JSX.Element) = closure87()
    let v2 : (Mut1 -> US0) = closure131(v0)
    let v3 : (Mut1 -> (Mut1 -> (US0 -> unit))) = closure132(v0)
    let v4 : Mut8 = {l0 = v2; l1 = v3} : Mut8
    let v5 : obj = v4
    let v6 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v6, v5) |> unbox<JSX.Element>
    v10
and closure135 () struct (v0 : US2, v1 : int32, v2 : string, v3 : string) : US0 =
    US0_1(v1)
and closure137 (v0 : Mut9, v1 : US2, v2 : int32, v3 : string, v4 : string) (v5 : US0) : struct (US2 * int32 * string * string) =
    let v6 : US2 = v0.l0
    let v8 : int32 =
        match v5 with
        | US0_0 -> (* None *)
            0
        | US0_1(v7) -> (* Some *)
            v7
    struct (v6, v8, v3, v4)
and closure136 (v0 : Mut9) struct (v1 : US2, v2 : int32, v3 : string, v4 : string) : (US0 -> struct (US2 * int32 * string * string)) =
    closure137(v0, v1, v2, v3, v4)
and closure129 (v0 : Mut9) () : (JSX.Element []) =
    let v1 : (Mut13 -> JSX.Element) = closure130()
    let v2 : US2 = v0.l0
    let v3 : (struct (US2 * int32 * string * string) -> US0) = closure135()
    let v4 : (struct (US2 * int32 * string * string) -> (US0 -> struct (US2 * int32 * string * string))) = closure136(v0)
    let v5 : Mut13 = {l0 = v2; l1 = v3; l2 = v4} : Mut13
    let v6 : obj = v5
    let v7 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v7, v6) |> unbox<JSX.Element>
    [|v11|]
and closure119 (v0 : Mut9) () : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure10()
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method4()
    let v65 : string = "URL"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : (unit -> (JSX.Element [])) = closure120(v0)
    let v68 : US5 = US5_1(v67)
    let v69 : string = "3px"
    let v70 : US1 = US1_1(v69)
    let v71 : US8 = US8_1(v66)
    let v72 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v68; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v70; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v71; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    let v73 : US11 = US11_0
    let v74 : US12 = US12_2
    let v75 : Mut3 = {l0 = v73; l1 = v72; l2 = v74} : Mut3
    let v76 : obj = v75
    let v77 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v78 : string = "createComponent"
    let v79 : string = "solid-js"
    let v80 : JS.Function = import v78 v79
    let v81 : JSX.Element = v80.Invoke (v77, v76) |> unbox<JSX.Element>
    let struct (v82 : US1, v83 : US1, v84 : US3, v85 : US1, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US4, v92 : US5, v93 : US1, v94 : US1, v95 : US4, v96 : US6, v97 : US1, v98 : US1, v99 : US1, v100 : US7, v101 : US4, v102 : US1, v103 : US1, v104 : US1, v105 : US1, v106 : US1, v107 : US8, v108 : US1, v109 : US1, v110 : US1, v111 : US8, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US9, v121 : US10, v122 : US9, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US1, v136 : US1, v137 : US1, v138 : US8, v139 : US1, v140 : US1, v141 : US6, v142 : US1, v143 : US0, v144 : US1) = method4()
    let v145 : string = "Port"
    let v146 : JSX.Element = Html.fragment [ v145 |> unbox<JSX.Element> ]
    let v147 : (unit -> (JSX.Element [])) = closure129(v0)
    let v148 : US5 = US5_1(v147)
    let v149 : US1 = US1_1(v69)
    let v150 : US8 = US8_1(v146)
    let v151 : Mut2 = {l0 = v82; l1 = v83; l2 = v84; l3 = v85; l4 = v86; l5 = v87; l6 = v88; l7 = v89; l8 = v90; l9 = v91; l10 = v148; l11 = v93; l12 = v94; l13 = v95; l14 = v96; l15 = v97; l16 = v98; l17 = v99; l18 = v100; l19 = v101; l20 = v102; l21 = v103; l22 = v104; l23 = v105; l24 = v106; l25 = v107; l26 = v108; l27 = v109; l28 = v110; l29 = v111; l30 = v112; l31 = v113; l32 = v114; l33 = v115; l34 = v116; l35 = v117; l36 = v118; l37 = v119; l38 = v120; l39 = v121; l40 = v122; l41 = v123; l42 = v124; l43 = v125; l44 = v149; l45 = v127; l46 = v128; l47 = v129; l48 = v130; l49 = v131; l50 = v132; l51 = v133; l52 = v134; l53 = v135; l54 = v136; l55 = v137; l56 = v150; l57 = v139; l58 = v140; l59 = v141; l60 = v142; l61 = v143; l62 = v144} : Mut2
    let v152 : US11 = US11_0
    let v153 : US12 = US12_2
    let v154 : Mut3 = {l0 = v152; l1 = v151; l2 = v153} : Mut3
    let v155 : obj = v154
    let v156 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v157 : JS.Function = import v78 v79
    let v158 : JSX.Element = v157.Invoke (v156, v155) |> unbox<JSX.Element>
    [|v81; v158|]
and closure118 () (v0 : Mut9) : JSX.Element =
    let v1 : (Mut2 -> JSX.Element) = closure6()
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method4()
    let v65 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    let struct (v66 : US1, v67 : US1, v68 : US3, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US4, v76 : US5, v77 : US1, v78 : US1, v79 : US4, v80 : US6, v81 : US1, v82 : US1, v83 : US1, v84 : US7, v85 : US4, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US8, v92 : US1, v93 : US1, v94 : US1, v95 : US8, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US9, v105 : US10, v106 : US9, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US8, v123 : US1, v124 : US1, v125 : US6, v126 : US1, v127 : US0, v128 : US1) = v65.l0, v65.l1, v65.l2, v65.l3, v65.l4, v65.l5, v65.l6, v65.l7, v65.l8, v65.l9, v65.l10, v65.l11, v65.l12, v65.l13, v65.l14, v65.l15, v65.l16, v65.l17, v65.l18, v65.l19, v65.l20, v65.l21, v65.l22, v65.l23, v65.l24, v65.l25, v65.l26, v65.l27, v65.l28, v65.l29, v65.l30, v65.l31, v65.l32, v65.l33, v65.l34, v65.l35, v65.l36, v65.l37, v65.l38, v65.l39, v65.l40, v65.l41, v65.l42, v65.l43, v65.l44, v65.l45, v65.l46, v65.l47, v65.l48, v65.l49, v65.l50, v65.l51, v65.l52, v65.l53, v65.l54, v65.l55, v65.l56, v65.l57, v65.l58, v65.l59, v65.l60, v65.l61, v65.l62
    let v129 : (unit -> (JSX.Element [])) = closure119(v0)
    let v130 : US5 = US5_1(v129)
    emitJsExpr (struct (v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v130, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128), v129) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v131 : US5 = US5_1(v129)
    let v132 : Mut2 = {l0 = v66; l1 = v67; l2 = v68; l3 = v69; l4 = v70; l5 = v71; l6 = v72; l7 = v73; l8 = v74; l9 = v75; l10 = v131; l11 = v77; l12 = v78; l13 = v79; l14 = v80; l15 = v81; l16 = v82; l17 = v83; l18 = v84; l19 = v85; l20 = v86; l21 = v87; l22 = v88; l23 = v89; l24 = v90; l25 = v91; l26 = v92; l27 = v93; l28 = v94; l29 = v95; l30 = v96; l31 = v97; l32 = v98; l33 = v99; l34 = v100; l35 = v101; l36 = v102; l37 = v103; l38 = v104; l39 = v105; l40 = v106; l41 = v107; l42 = v108; l43 = v109; l44 = v110; l45 = v111; l46 = v112; l47 = v113; l48 = v114; l49 = v115; l50 = v116; l51 = v117; l52 = v118; l53 = v119; l54 = v120; l55 = v121; l56 = v122; l57 = v123; l58 = v124; l59 = v125; l60 = v126; l61 = v127; l62 = v128} : Mut2
    let v133 : obj = v132
    let v134 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v135 : string = "createComponent"
    let v136 : string = "solid-js"
    let v137 : JS.Function = import v135 v136
    let v138 : JSX.Element = v137.Invoke (v134, v133) |> unbox<JSX.Element>
    v138
and closure117 () () : (JSX.Element []) =
    let v0 : (Mut9 -> JSX.Element) = closure118()
    let v1 : US2 = US2_1
    let v2 : Mut9 = {l0 = v1} : Mut9
    let v3 : obj = v2
    let v4 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v4, v3) |> unbox<JSX.Element>
    [|v8|]
and closure141 () (v0 : Mut1) : unit =
    let struct (v1 : (struct (US2 * int32 * string * string) []), v2 : (struct (US2 * US2) [])) = v0.l4, v0.l5
    let v3 : US2 = US2_1
    let v4 : US2 = US2_1
    let v5 : (struct (US2 * US2) []) = [|struct (v3, v4)|]
    let v6 : int32 = v2.Length
    let v7 : int32 = v5.Length
    let v8 : int32 = v6 + v7
    let v9 : (struct (US2 * US2) []) = Array.zeroCreate<struct (US2 * US2)> (v8)
    let v10 : Mut5 = {l0 = 0} : Mut5
    while method12(v8, v10) do
        let v12 : int32 = v10.l0
        let v13 : bool = v12 < v6
        let struct (v19 : US2, v20 : US2) =
            if v13 then
                let struct (v14 : US2, v15 : US2) = v2.[int v12]
                struct (v14, v15)
            else
                let v16 : int32 = v12 - v6
                let struct (v17 : US2, v18 : US2) = v5.[int v16]
                struct (v17, v18)
        v9.[int v12] <- struct (v19, v20)
        let v21 : int32 = v12 + 1
        v10.l0 <- v21
        ()
    v0.l5 <- v9
    ()
and closure140 () (v0 : Mut1) : (Mut1 -> unit) =
    closure141()
and closure139 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure140()
    v0 v1
    ()
and closure138 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure139()
and closure142 () () : (JSX.Element []) =
    let v0 : (Mut9 -> JSX.Element) = closure118()
    let v1 : US2 = US2_0
    let v2 : Mut9 = {l0 = v1} : Mut9
    let v3 : obj = v2
    let v4 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v4, v3) |> unbox<JSX.Element>
    [|v8|]
and closure146 () (v0 : Mut1) : unit =
    let struct (v1 : (struct (US2 * int32 * string * string) []), v2 : (struct (US2 * US2) [])) = v0.l4, v0.l5
    let v3 : US2 = US2_1
    let v4 : US2 = US2_0
    let v5 : (struct (US2 * US2) []) = [|struct (v3, v4)|]
    let v6 : int32 = v2.Length
    let v7 : int32 = v5.Length
    let v8 : int32 = v6 + v7
    let v9 : (struct (US2 * US2) []) = Array.zeroCreate<struct (US2 * US2)> (v8)
    let v10 : Mut5 = {l0 = 0} : Mut5
    while method12(v8, v10) do
        let v12 : int32 = v10.l0
        let v13 : bool = v12 < v6
        let struct (v19 : US2, v20 : US2) =
            if v13 then
                let struct (v14 : US2, v15 : US2) = v2.[int v12]
                struct (v14, v15)
            else
                let v16 : int32 = v12 - v6
                let struct (v17 : US2, v18 : US2) = v5.[int v16]
                struct (v17, v18)
        v9.[int v12] <- struct (v19, v20)
        let v21 : int32 = v12 + 1
        v10.l0 <- v21
        ()
    v0.l5 <- v9
    ()
and closure145 () (v0 : Mut1) : (Mut1 -> unit) =
    closure146()
and closure144 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure145()
    v0 v1
    ()
and closure143 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure144()
and closure147 () () : (JSX.Element []) =
    let v0 : (Mut9 -> JSX.Element) = closure118()
    let v1 : US2 = US2_0
    let v2 : Mut9 = {l0 = v1} : Mut9
    let v3 : obj = v2
    let v4 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v4, v3) |> unbox<JSX.Element>
    [|v8|]
and closure151 () (v0 : Mut1) : unit =
    let struct (v1 : (struct (US2 * int32 * string * string) []), v2 : (struct (US2 * US2) [])) = v0.l4, v0.l5
    let v3 : US2 = US2_0
    let v4 : US2 = US2_0
    let v5 : (struct (US2 * US2) []) = [|struct (v3, v4)|]
    let v6 : int32 = v2.Length
    let v7 : int32 = v5.Length
    let v8 : int32 = v6 + v7
    let v9 : (struct (US2 * US2) []) = Array.zeroCreate<struct (US2 * US2)> (v8)
    let v10 : Mut5 = {l0 = 0} : Mut5
    while method12(v8, v10) do
        let v12 : int32 = v10.l0
        let v13 : bool = v12 < v6
        let struct (v19 : US2, v20 : US2) =
            if v13 then
                let struct (v14 : US2, v15 : US2) = v2.[int v12]
                struct (v14, v15)
            else
                let v16 : int32 = v12 - v6
                let struct (v17 : US2, v18 : US2) = v5.[int v16]
                struct (v17, v18)
        v9.[int v12] <- struct (v19, v20)
        let v21 : int32 = v12 + 1
        v10.l0 <- v21
        ()
    v0.l5 <- v9
    ()
and closure150 () (v0 : Mut1) : (Mut1 -> unit) =
    closure151()
and closure149 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure150()
    v0 v1
    ()
and closure148 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure149()
and closure152 () () : (JSX.Element []) =
    let v0 : (Mut9 -> JSX.Element) = closure118()
    let v1 : US2 = US2_1
    let v2 : Mut9 = {l0 = v1} : Mut9
    let v3 : obj = v2
    let v4 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v4, v3) |> unbox<JSX.Element>
    [|v8|]
and closure156 () (v0 : Mut1) : unit =
    let struct (v1 : (struct (US2 * int32 * string * string) []), v2 : (struct (US2 * US2) [])) = v0.l4, v0.l5
    let v3 : US2 = US2_0
    let v4 : US2 = US2_1
    let v5 : (struct (US2 * US2) []) = [|struct (v3, v4)|]
    let v6 : int32 = v2.Length
    let v7 : int32 = v5.Length
    let v8 : int32 = v6 + v7
    let v9 : (struct (US2 * US2) []) = Array.zeroCreate<struct (US2 * US2)> (v8)
    let v10 : Mut5 = {l0 = 0} : Mut5
    while method12(v8, v10) do
        let v12 : int32 = v10.l0
        let v13 : bool = v12 < v6
        let struct (v19 : US2, v20 : US2) =
            if v13 then
                let struct (v14 : US2, v15 : US2) = v2.[int v12]
                struct (v14, v15)
            else
                let v16 : int32 = v12 - v6
                let struct (v17 : US2, v18 : US2) = v5.[int v16]
                struct (v17, v18)
        v9.[int v12] <- struct (v19, v20)
        let v21 : int32 = v12 + 1
        v10.l0 <- v21
        ()
    v0.l5 <- v9
    ()
and closure155 () (v0 : Mut1) : (Mut1 -> unit) =
    closure156()
and closure154 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure155()
    v0 v1
    ()
and closure153 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure154()
and closure116 () () : (JSX.Element []) =
    let v0 : (Mut3 -> JSX.Element) = closure10()
    let struct (v1 : US1, v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method4()
    let v64 : string = "Rust -> Rust"
    let v65 : JSX.Element = Html.fragment [ v64 |> unbox<JSX.Element> ]
    let v66 : (unit -> (JSX.Element [])) = closure117()
    let v67 : US5 = US5_1(v66)
    let v68 : string = "db-gun-rs-rs"
    let v69 : US1 = US1_1(v68)
    let v70 : US8 = US8_1(v65)
    let v71 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v67; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v69; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v70; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63} : Mut2
    let v72 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure138()
    let v73 : US11 = US11_1(v72)
    let v74 : US12 = US12_0
    let v75 : Mut3 = {l0 = v73; l1 = v71; l2 = v74} : Mut3
    let v76 : obj = v75
    let v77 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v78 : string = "createComponent"
    let v79 : string = "solid-js"
    let v80 : JS.Function = import v78 v79
    let v81 : JSX.Element = v80.Invoke (v77, v76) |> unbox<JSX.Element>
    let struct (v82 : US1, v83 : US1, v84 : US3, v85 : US1, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US4, v92 : US5, v93 : US1, v94 : US1, v95 : US4, v96 : US6, v97 : US1, v98 : US1, v99 : US1, v100 : US7, v101 : US4, v102 : US1, v103 : US1, v104 : US1, v105 : US1, v106 : US1, v107 : US8, v108 : US1, v109 : US1, v110 : US1, v111 : US8, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US9, v121 : US10, v122 : US9, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US1, v136 : US1, v137 : US1, v138 : US8, v139 : US1, v140 : US1, v141 : US6, v142 : US1, v143 : US0, v144 : US1) = method4()
    let v145 : string = "Rust -> JavaScript"
    let v146 : JSX.Element = Html.fragment [ v145 |> unbox<JSX.Element> ]
    let v147 : (unit -> (JSX.Element [])) = closure142()
    let v148 : US5 = US5_1(v147)
    let v149 : string = "db-gun-rs-js"
    let v150 : US1 = US1_1(v149)
    let v151 : US8 = US8_1(v146)
    let v152 : Mut2 = {l0 = v82; l1 = v83; l2 = v84; l3 = v85; l4 = v86; l5 = v87; l6 = v88; l7 = v89; l8 = v90; l9 = v91; l10 = v148; l11 = v93; l12 = v94; l13 = v95; l14 = v96; l15 = v97; l16 = v98; l17 = v99; l18 = v100; l19 = v101; l20 = v102; l21 = v103; l22 = v104; l23 = v105; l24 = v106; l25 = v107; l26 = v150; l27 = v109; l28 = v110; l29 = v111; l30 = v112; l31 = v113; l32 = v114; l33 = v115; l34 = v116; l35 = v117; l36 = v118; l37 = v119; l38 = v120; l39 = v121; l40 = v122; l41 = v123; l42 = v124; l43 = v125; l44 = v126; l45 = v127; l46 = v128; l47 = v129; l48 = v130; l49 = v131; l50 = v132; l51 = v133; l52 = v134; l53 = v135; l54 = v136; l55 = v137; l56 = v151; l57 = v139; l58 = v140; l59 = v141; l60 = v142; l61 = v143; l62 = v144} : Mut2
    let v153 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure143()
    let v154 : US11 = US11_1(v153)
    let v155 : US12 = US12_0
    let v156 : Mut3 = {l0 = v154; l1 = v152; l2 = v155} : Mut3
    let v157 : obj = v156
    let v158 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v159 : JS.Function = import v78 v79
    let v160 : JSX.Element = v159.Invoke (v158, v157) |> unbox<JSX.Element>
    let struct (v161 : US1, v162 : US1, v163 : US3, v164 : US1, v165 : US1, v166 : US1, v167 : US1, v168 : US1, v169 : US1, v170 : US4, v171 : US5, v172 : US1, v173 : US1, v174 : US4, v175 : US6, v176 : US1, v177 : US1, v178 : US1, v179 : US7, v180 : US4, v181 : US1, v182 : US1, v183 : US1, v184 : US1, v185 : US1, v186 : US8, v187 : US1, v188 : US1, v189 : US1, v190 : US8, v191 : US1, v192 : US1, v193 : US1, v194 : US1, v195 : US1, v196 : US1, v197 : US1, v198 : US1, v199 : US9, v200 : US10, v201 : US9, v202 : US1, v203 : US1, v204 : US1, v205 : US1, v206 : US1, v207 : US1, v208 : US1, v209 : US1, v210 : US1, v211 : US1, v212 : US1, v213 : US1, v214 : US1, v215 : US1, v216 : US1, v217 : US8, v218 : US1, v219 : US1, v220 : US6, v221 : US1, v222 : US0, v223 : US1) = method4()
    let v224 : string = "JavaScript -> JavaScript"
    let v225 : JSX.Element = Html.fragment [ v224 |> unbox<JSX.Element> ]
    let v226 : (unit -> (JSX.Element [])) = closure147()
    let v227 : US5 = US5_1(v226)
    let v228 : string = "db-gun-js-js"
    let v229 : US1 = US1_1(v228)
    let v230 : US8 = US8_1(v225)
    let v231 : Mut2 = {l0 = v161; l1 = v162; l2 = v163; l3 = v164; l4 = v165; l5 = v166; l6 = v167; l7 = v168; l8 = v169; l9 = v170; l10 = v227; l11 = v172; l12 = v173; l13 = v174; l14 = v175; l15 = v176; l16 = v177; l17 = v178; l18 = v179; l19 = v180; l20 = v181; l21 = v182; l22 = v183; l23 = v184; l24 = v185; l25 = v186; l26 = v229; l27 = v188; l28 = v189; l29 = v190; l30 = v191; l31 = v192; l32 = v193; l33 = v194; l34 = v195; l35 = v196; l36 = v197; l37 = v198; l38 = v199; l39 = v200; l40 = v201; l41 = v202; l42 = v203; l43 = v204; l44 = v205; l45 = v206; l46 = v207; l47 = v208; l48 = v209; l49 = v210; l50 = v211; l51 = v212; l52 = v213; l53 = v214; l54 = v215; l55 = v216; l56 = v230; l57 = v218; l58 = v219; l59 = v220; l60 = v221; l61 = v222; l62 = v223} : Mut2
    let v232 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure148()
    let v233 : US11 = US11_1(v232)
    let v234 : US12 = US12_0
    let v235 : Mut3 = {l0 = v233; l1 = v231; l2 = v234} : Mut3
    let v236 : obj = v235
    let v237 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v238 : JS.Function = import v78 v79
    let v239 : JSX.Element = v238.Invoke (v237, v236) |> unbox<JSX.Element>
    let struct (v240 : US1, v241 : US1, v242 : US3, v243 : US1, v244 : US1, v245 : US1, v246 : US1, v247 : US1, v248 : US1, v249 : US4, v250 : US5, v251 : US1, v252 : US1, v253 : US4, v254 : US6, v255 : US1, v256 : US1, v257 : US1, v258 : US7, v259 : US4, v260 : US1, v261 : US1, v262 : US1, v263 : US1, v264 : US1, v265 : US8, v266 : US1, v267 : US1, v268 : US1, v269 : US8, v270 : US1, v271 : US1, v272 : US1, v273 : US1, v274 : US1, v275 : US1, v276 : US1, v277 : US1, v278 : US9, v279 : US10, v280 : US9, v281 : US1, v282 : US1, v283 : US1, v284 : US1, v285 : US1, v286 : US1, v287 : US1, v288 : US1, v289 : US1, v290 : US1, v291 : US1, v292 : US1, v293 : US1, v294 : US1, v295 : US1, v296 : US8, v297 : US1, v298 : US1, v299 : US6, v300 : US1, v301 : US0, v302 : US1) = method4()
    let v303 : string = "JavaScript -> Rust"
    let v304 : JSX.Element = Html.fragment [ v303 |> unbox<JSX.Element> ]
    let v305 : (unit -> (JSX.Element [])) = closure152()
    let v306 : US5 = US5_1(v305)
    let v307 : string = "db-gun-js-rs"
    let v308 : US1 = US1_1(v307)
    let v309 : US8 = US8_1(v304)
    let v310 : Mut2 = {l0 = v240; l1 = v241; l2 = v242; l3 = v243; l4 = v244; l5 = v245; l6 = v246; l7 = v247; l8 = v248; l9 = v249; l10 = v306; l11 = v251; l12 = v252; l13 = v253; l14 = v254; l15 = v255; l16 = v256; l17 = v257; l18 = v258; l19 = v259; l20 = v260; l21 = v261; l22 = v262; l23 = v263; l24 = v264; l25 = v265; l26 = v308; l27 = v267; l28 = v268; l29 = v269; l30 = v270; l31 = v271; l32 = v272; l33 = v273; l34 = v274; l35 = v275; l36 = v276; l37 = v277; l38 = v278; l39 = v279; l40 = v280; l41 = v281; l42 = v282; l43 = v283; l44 = v284; l45 = v285; l46 = v286; l47 = v287; l48 = v288; l49 = v289; l50 = v290; l51 = v291; l52 = v292; l53 = v293; l54 = v294; l55 = v295; l56 = v309; l57 = v297; l58 = v298; l59 = v299; l60 = v300; l61 = v301; l62 = v302} : Mut2
    let v311 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure153()
    let v312 : US11 = US11_1(v311)
    let v313 : US12 = US12_0
    let v314 : Mut3 = {l0 = v312; l1 = v310; l2 = v313} : Mut3
    let v315 : obj = v314
    let v316 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v317 : JS.Function = import v78 v79
    let v318 : JSX.Element = v317.Invoke (v316, v315) |> unbox<JSX.Element>
    [|v81; v160; v239; v318|]
and closure115 () (v0 : Mut2) : JSX.Element =
    let v1 : (Mut2 -> JSX.Element) = closure6()
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method4()
    let v65 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    let struct (v66 : US1, v67 : US1, v68 : US3, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US4, v76 : US5, v77 : US1, v78 : US1, v79 : US4, v80 : US6, v81 : US1, v82 : US1, v83 : US1, v84 : US7, v85 : US4, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US8, v92 : US1, v93 : US1, v94 : US1, v95 : US8, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US9, v105 : US10, v106 : US9, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US8, v123 : US1, v124 : US1, v125 : US6, v126 : US1, v127 : US0, v128 : US1) = v65.l0, v65.l1, v65.l2, v65.l3, v65.l4, v65.l5, v65.l6, v65.l7, v65.l8, v65.l9, v65.l10, v65.l11, v65.l12, v65.l13, v65.l14, v65.l15, v65.l16, v65.l17, v65.l18, v65.l19, v65.l20, v65.l21, v65.l22, v65.l23, v65.l24, v65.l25, v65.l26, v65.l27, v65.l28, v65.l29, v65.l30, v65.l31, v65.l32, v65.l33, v65.l34, v65.l35, v65.l36, v65.l37, v65.l38, v65.l39, v65.l40, v65.l41, v65.l42, v65.l43, v65.l44, v65.l45, v65.l46, v65.l47, v65.l48, v65.l49, v65.l50, v65.l51, v65.l52, v65.l53, v65.l54, v65.l55, v65.l56, v65.l57, v65.l58, v65.l59, v65.l60, v65.l61, v65.l62
    let v129 : (unit -> (JSX.Element [])) = closure116()
    let v130 : US5 = US5_1(v129)
    emitJsExpr (struct (v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v130, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128), v129) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v131 : US5 = US5_1(v129)
    let v132 : Mut2 = {l0 = v66; l1 = v67; l2 = v68; l3 = v69; l4 = v70; l5 = v71; l6 = v72; l7 = v73; l8 = v74; l9 = v75; l10 = v131; l11 = v77; l12 = v78; l13 = v79; l14 = v80; l15 = v81; l16 = v82; l17 = v83; l18 = v84; l19 = v85; l20 = v86; l21 = v87; l22 = v88; l23 = v89; l24 = v90; l25 = v91; l26 = v92; l27 = v93; l28 = v94; l29 = v95; l30 = v96; l31 = v97; l32 = v98; l33 = v99; l34 = v100; l35 = v101; l36 = v102; l37 = v103; l38 = v104; l39 = v105; l40 = v106; l41 = v107; l42 = v108; l43 = v109; l44 = v110; l45 = v111; l46 = v112; l47 = v113; l48 = v114; l49 = v115; l50 = v116; l51 = v117; l52 = v118; l53 = v119; l54 = v120; l55 = v121; l56 = v122; l57 = v123; l58 = v124; l59 = v125; l60 = v126; l61 = v127; l62 = v128} : Mut2
    let v133 : obj = v132
    let v134 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v135 : string = "createComponent"
    let v136 : string = "solid-js"
    let v137 : JS.Function = import v135 v136
    let v138 : JSX.Element = v137.Invoke (v134, v133) |> unbox<JSX.Element>
    v138
and closure157 () () : (JSX.Element []) =
    [||]
and closure114 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure115()
    let struct (v1 : US1, v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method4()
    let v64 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v11; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v45; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v57; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63} : Mut2
    let struct (v65 : US1, v66 : US1, v67 : US3, v68 : US1, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US4, v75 : US5, v76 : US1, v77 : US1, v78 : US4, v79 : US6, v80 : US1, v81 : US1, v82 : US1, v83 : US7, v84 : US4, v85 : US1, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US8, v91 : US1, v92 : US1, v93 : US1, v94 : US8, v95 : US1, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US9, v104 : US10, v105 : US9, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US8, v122 : US1, v123 : US1, v124 : US6, v125 : US1, v126 : US0, v127 : US1) = v64.l0, v64.l1, v64.l2, v64.l3, v64.l4, v64.l5, v64.l6, v64.l7, v64.l8, v64.l9, v64.l10, v64.l11, v64.l12, v64.l13, v64.l14, v64.l15, v64.l16, v64.l17, v64.l18, v64.l19, v64.l20, v64.l21, v64.l22, v64.l23, v64.l24, v64.l25, v64.l26, v64.l27, v64.l28, v64.l29, v64.l30, v64.l31, v64.l32, v64.l33, v64.l34, v64.l35, v64.l36, v64.l37, v64.l38, v64.l39, v64.l40, v64.l41, v64.l42, v64.l43, v64.l44, v64.l45, v64.l46, v64.l47, v64.l48, v64.l49, v64.l50, v64.l51, v64.l52, v64.l53, v64.l54, v64.l55, v64.l56, v64.l57, v64.l58, v64.l59, v64.l60, v64.l61, v64.l62
    let v128 : (unit -> (JSX.Element [])) = closure157()
    let v129 : US5 = US5_1(v128)
    emitJsExpr (struct (v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v129, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127), v128) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v130 : US5 = US5_1(v128)
    let v131 : Mut2 = {l0 = v65; l1 = v66; l2 = v67; l3 = v68; l4 = v69; l5 = v70; l6 = v71; l7 = v72; l8 = v73; l9 = v74; l10 = v130; l11 = v76; l12 = v77; l13 = v78; l14 = v79; l15 = v80; l16 = v81; l17 = v82; l18 = v83; l19 = v84; l20 = v85; l21 = v86; l22 = v87; l23 = v88; l24 = v89; l25 = v90; l26 = v91; l27 = v92; l28 = v93; l29 = v94; l30 = v95; l31 = v96; l32 = v97; l33 = v98; l34 = v99; l35 = v100; l36 = v101; l37 = v102; l38 = v103; l39 = v104; l40 = v105; l41 = v106; l42 = v107; l43 = v108; l44 = v109; l45 = v110; l46 = v111; l47 = v112; l48 = v113; l49 = v114; l50 = v115; l51 = v116; l52 = v117; l53 = v118; l54 = v119; l55 = v120; l56 = v121; l57 = v122; l58 = v123; l59 = v124; l60 = v125; l61 = v126; l62 = v127} : Mut2
    let v132 : obj = v131
    let v133 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v134 : string = "createComponent"
    let v135 : string = "solid-js"
    let v136 : JS.Function = import v134 v135
    let v137 : JSX.Element = v136.Invoke (v133, v132) |> unbox<JSX.Element>
    [|v137|]
and closure162 () () : (JSX.Element []) =
    let v0 : string = "Counter"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure163 () () : JS.Function =
    let v0 : string = "BiRegularPlus"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure164 () () : unit =
    ()
and closure165 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure166 () () : JS.Function =
    let v0 : string = "BiRegularMinus"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure167 () () : unit =
    ()
and closure168 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure161 () () : (JSX.Element []) =
    let v0 : string = "Box"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US1, v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = method4()
    let v66 : (unit -> (JSX.Element [])) = closure162()
    let v67 : US5 = US5_1(v66)
    let v68 : ((string * obj) []) = method5(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v67, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65)
    let v69 : obj = createObj v68
    let v70 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v70, v69) |> unbox<JSX.Element>
    let v75 : (Mut2 -> JSX.Element) = closure24()
    let struct (v76 : US1, v77 : US1, v78 : US3, v79 : US1, v80 : US1, v81 : US1, v82 : US1, v83 : US1, v84 : US1, v85 : US4, v86 : US5, v87 : US1, v88 : US1, v89 : US4, v90 : US6, v91 : US1, v92 : US1, v93 : US1, v94 : US7, v95 : US4, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US8, v102 : US1, v103 : US1, v104 : US1, v105 : US8, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US9, v115 : US10, v116 : US9, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US8, v133 : US1, v134 : US1, v135 : US6, v136 : US1, v137 : US0, v138 : US1) = method4()
    let v139 : Mut2 = {l0 = v76; l1 = v77; l2 = v78; l3 = v79; l4 = v80; l5 = v81; l6 = v82; l7 = v83; l8 = v84; l9 = v85; l10 = v86; l11 = v87; l12 = v88; l13 = v89; l14 = v90; l15 = v91; l16 = v92; l17 = v93; l18 = v94; l19 = v95; l20 = v96; l21 = v97; l22 = v98; l23 = v99; l24 = v100; l25 = v101; l26 = v102; l27 = v103; l28 = v104; l29 = v105; l30 = v106; l31 = v107; l32 = v108; l33 = v109; l34 = v110; l35 = v111; l36 = v112; l37 = v113; l38 = v114; l39 = v115; l40 = v116; l41 = v117; l42 = v118; l43 = v119; l44 = v120; l45 = v121; l46 = v122; l47 = v123; l48 = v124; l49 = v125; l50 = v126; l51 = v127; l52 = v128; l53 = v129; l54 = v130; l55 = v131; l56 = v132; l57 = v133; l58 = v134; l59 = v135; l60 = v136; l61 = v137; l62 = v138} : Mut2
    let v140 : (Mut6 -> JSX.Element) = closure31()
    let v141 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = closure33()
    let v142 : (unit -> JS.Function) = closure163()
    let v143 : Mut6 = {l0 = v141; l1 = v142; l2 = v141} : Mut6
    let v144 : obj = v143
    let v145 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v146 : JS.Function = import v71 v72
    let v147 : JSX.Element = v146.Invoke (v145, v144) |> unbox<JSX.Element>
    let v148 : US8 = US8_1(v147)
    v139.l29 <- v148
    let v149 : string = "10px"
    let v150 : US1 = US1_1(v149)
    v139.l47 <- v150
    let v151 : (unit -> unit) = closure164()
    let v152 : US10 = US10_1(v151)
    v139.l39 <- v152
    let struct (v153 : US1, v154 : US1, v155 : US3, v156 : US1, v157 : US1, v158 : US1, v159 : US1, v160 : US1, v161 : US1, v162 : US4, v163 : US5, v164 : US1, v165 : US1, v166 : US4, v167 : US6, v168 : US1, v169 : US1, v170 : US1, v171 : US7, v172 : US4, v173 : US1, v174 : US1, v175 : US1, v176 : US1, v177 : US1, v178 : US8, v179 : US1, v180 : US1, v181 : US1, v182 : US8, v183 : US1, v184 : US1, v185 : US1, v186 : US1, v187 : US1, v188 : US1, v189 : US1, v190 : US1, v191 : US9, v192 : US10, v193 : US9, v194 : US1, v195 : US1, v196 : US1, v197 : US1, v198 : US1, v199 : US1, v200 : US1, v201 : US1, v202 : US1, v203 : US1, v204 : US1, v205 : US1, v206 : US1, v207 : US1, v208 : US1, v209 : US8, v210 : US1, v211 : US1, v212 : US6, v213 : US1, v214 : US0, v215 : US1) = v139.l0, v139.l1, v139.l2, v139.l3, v139.l4, v139.l5, v139.l6, v139.l7, v139.l8, v139.l9, v139.l10, v139.l11, v139.l12, v139.l13, v139.l14, v139.l15, v139.l16, v139.l17, v139.l18, v139.l19, v139.l20, v139.l21, v139.l22, v139.l23, v139.l24, v139.l25, v139.l26, v139.l27, v139.l28, v139.l29, v139.l30, v139.l31, v139.l32, v139.l33, v139.l34, v139.l35, v139.l36, v139.l37, v139.l38, v139.l39, v139.l40, v139.l41, v139.l42, v139.l43, v139.l44, v139.l45, v139.l46, v139.l47, v139.l48, v139.l49, v139.l50, v139.l51, v139.l52, v139.l53, v139.l54, v139.l55, v139.l56, v139.l57, v139.l58, v139.l59, v139.l60, v139.l61, v139.l62
    let v216 : (unit -> (JSX.Element [])) = closure165()
    let v217 : US5 = US5_1(v216)
    emitJsExpr (struct (v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v217, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215), v216) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v218 : US5 = US5_1(v216)
    let v219 : Mut2 = {l0 = v153; l1 = v154; l2 = v155; l3 = v156; l4 = v157; l5 = v158; l6 = v159; l7 = v160; l8 = v161; l9 = v162; l10 = v218; l11 = v164; l12 = v165; l13 = v166; l14 = v167; l15 = v168; l16 = v169; l17 = v170; l18 = v171; l19 = v172; l20 = v173; l21 = v174; l22 = v175; l23 = v176; l24 = v177; l25 = v178; l26 = v179; l27 = v180; l28 = v181; l29 = v182; l30 = v183; l31 = v184; l32 = v185; l33 = v186; l34 = v187; l35 = v188; l36 = v189; l37 = v190; l38 = v191; l39 = v192; l40 = v193; l41 = v194; l42 = v195; l43 = v196; l44 = v197; l45 = v198; l46 = v199; l47 = v200; l48 = v201; l49 = v202; l50 = v203; l51 = v204; l52 = v205; l53 = v206; l54 = v207; l55 = v208; l56 = v209; l57 = v210; l58 = v211; l59 = v212; l60 = v213; l61 = v214; l62 = v215} : Mut2
    let v220 : obj = v219
    let v221 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v222 : JS.Function = import v71 v72
    let v223 : JSX.Element = v222.Invoke (v221, v220) |> unbox<JSX.Element>
    let struct (v224 : US1, v225 : US1, v226 : US3, v227 : US1, v228 : US1, v229 : US1, v230 : US1, v231 : US1, v232 : US1, v233 : US4, v234 : US5, v235 : US1, v236 : US1, v237 : US4, v238 : US6, v239 : US1, v240 : US1, v241 : US1, v242 : US7, v243 : US4, v244 : US1, v245 : US1, v246 : US1, v247 : US1, v248 : US1, v249 : US8, v250 : US1, v251 : US1, v252 : US1, v253 : US8, v254 : US1, v255 : US1, v256 : US1, v257 : US1, v258 : US1, v259 : US1, v260 : US1, v261 : US1, v262 : US9, v263 : US10, v264 : US9, v265 : US1, v266 : US1, v267 : US1, v268 : US1, v269 : US1, v270 : US1, v271 : US1, v272 : US1, v273 : US1, v274 : US1, v275 : US1, v276 : US1, v277 : US1, v278 : US1, v279 : US1, v280 : US8, v281 : US1, v282 : US1, v283 : US6, v284 : US1, v285 : US0, v286 : US1) = method4()
    let v287 : Mut2 = {l0 = v224; l1 = v225; l2 = v226; l3 = v227; l4 = v228; l5 = v229; l6 = v230; l7 = v231; l8 = v232; l9 = v233; l10 = v234; l11 = v235; l12 = v236; l13 = v237; l14 = v238; l15 = v239; l16 = v240; l17 = v241; l18 = v242; l19 = v243; l20 = v244; l21 = v245; l22 = v246; l23 = v247; l24 = v248; l25 = v249; l26 = v250; l27 = v251; l28 = v252; l29 = v253; l30 = v254; l31 = v255; l32 = v256; l33 = v257; l34 = v258; l35 = v259; l36 = v260; l37 = v261; l38 = v262; l39 = v263; l40 = v264; l41 = v265; l42 = v266; l43 = v267; l44 = v268; l45 = v269; l46 = v270; l47 = v271; l48 = v272; l49 = v273; l50 = v274; l51 = v275; l52 = v276; l53 = v277; l54 = v278; l55 = v279; l56 = v280; l57 = v281; l58 = v282; l59 = v283; l60 = v284; l61 = v285; l62 = v286} : Mut2
    let v288 : (unit -> JS.Function) = closure166()
    let v289 : Mut6 = {l0 = v141; l1 = v288; l2 = v141} : Mut6
    let v290 : obj = v289
    let v291 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v292 : JS.Function = import v71 v72
    let v293 : JSX.Element = v292.Invoke (v291, v290) |> unbox<JSX.Element>
    let v294 : US8 = US8_1(v293)
    v287.l29 <- v294
    let v295 : US1 = US1_1(v149)
    v287.l47 <- v295
    let v296 : (unit -> unit) = closure167()
    let v297 : US10 = US10_1(v296)
    v287.l39 <- v297
    let struct (v298 : US1, v299 : US1, v300 : US3, v301 : US1, v302 : US1, v303 : US1, v304 : US1, v305 : US1, v306 : US1, v307 : US4, v308 : US5, v309 : US1, v310 : US1, v311 : US4, v312 : US6, v313 : US1, v314 : US1, v315 : US1, v316 : US7, v317 : US4, v318 : US1, v319 : US1, v320 : US1, v321 : US1, v322 : US1, v323 : US8, v324 : US1, v325 : US1, v326 : US1, v327 : US8, v328 : US1, v329 : US1, v330 : US1, v331 : US1, v332 : US1, v333 : US1, v334 : US1, v335 : US1, v336 : US9, v337 : US10, v338 : US9, v339 : US1, v340 : US1, v341 : US1, v342 : US1, v343 : US1, v344 : US1, v345 : US1, v346 : US1, v347 : US1, v348 : US1, v349 : US1, v350 : US1, v351 : US1, v352 : US1, v353 : US1, v354 : US8, v355 : US1, v356 : US1, v357 : US6, v358 : US1, v359 : US0, v360 : US1) = v287.l0, v287.l1, v287.l2, v287.l3, v287.l4, v287.l5, v287.l6, v287.l7, v287.l8, v287.l9, v287.l10, v287.l11, v287.l12, v287.l13, v287.l14, v287.l15, v287.l16, v287.l17, v287.l18, v287.l19, v287.l20, v287.l21, v287.l22, v287.l23, v287.l24, v287.l25, v287.l26, v287.l27, v287.l28, v287.l29, v287.l30, v287.l31, v287.l32, v287.l33, v287.l34, v287.l35, v287.l36, v287.l37, v287.l38, v287.l39, v287.l40, v287.l41, v287.l42, v287.l43, v287.l44, v287.l45, v287.l46, v287.l47, v287.l48, v287.l49, v287.l50, v287.l51, v287.l52, v287.l53, v287.l54, v287.l55, v287.l56, v287.l57, v287.l58, v287.l59, v287.l60, v287.l61, v287.l62
    let v361 : (unit -> (JSX.Element [])) = closure168()
    let v362 : US5 = US5_1(v361)
    emitJsExpr (struct (v298, v299, v300, v301, v302, v303, v304, v305, v306, v307, v362, v309, v310, v311, v312, v313, v314, v315, v316, v317, v318, v319, v320, v321, v322, v323, v324, v325, v326, v327, v328, v329, v330, v331, v332, v333, v334, v335, v336, v337, v338, v339, v340, v341, v342, v343, v344, v345, v346, v347, v348, v349, v350, v351, v352, v353, v354, v355, v356, v357, v358, v359, v360), v361) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v363 : US5 = US5_1(v361)
    let v364 : Mut2 = {l0 = v298; l1 = v299; l2 = v300; l3 = v301; l4 = v302; l5 = v303; l6 = v304; l7 = v305; l8 = v306; l9 = v307; l10 = v363; l11 = v309; l12 = v310; l13 = v311; l14 = v312; l15 = v313; l16 = v314; l17 = v315; l18 = v316; l19 = v317; l20 = v318; l21 = v319; l22 = v320; l23 = v321; l24 = v322; l25 = v323; l26 = v324; l27 = v325; l28 = v326; l29 = v327; l30 = v328; l31 = v329; l32 = v330; l33 = v331; l34 = v332; l35 = v333; l36 = v334; l37 = v335; l38 = v336; l39 = v337; l40 = v338; l41 = v339; l42 = v340; l43 = v341; l44 = v342; l45 = v343; l46 = v344; l47 = v345; l48 = v346; l49 = v347; l50 = v348; l51 = v349; l52 = v350; l53 = v351; l54 = v352; l55 = v353; l56 = v354; l57 = v355; l58 = v356; l59 = v357; l60 = v358; l61 = v359; l62 = v360} : Mut2
    let v365 : obj = v364
    let v366 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v367 : JS.Function = import v71 v72
    let v368 : JSX.Element = v367.Invoke (v366, v365) |> unbox<JSX.Element>
    [|v74; v223; v368|]
and method17 (v0 : int32, v1 : Mut15) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method18 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH1 = UH1_0(v2, v3, v1)
        method18(v4, v5)
    | UH1_1 -> (* Nil *)
        v1
and method20 (v0 : UH1, v1 : int32) : int32 =
    match v0 with
    | UH1_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method20(v4, v5)
    | UH1_1 -> (* Nil *)
        v1
and method21 (v0 : (struct (int32 * int32) []), v1 : UH1, v2 : int32) : int32 =
    match v1 with
    | UH1_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method21(v0, v5, v6)
    | UH1_1 -> (* Nil *)
        v2
and method19 (v0 : UH1) : (struct (int32 * int32) []) =
    let v1 : int32 = 0
    let v2 : int32 = method20(v0, v1)
    let v3 : (struct (int32 * int32) []) = Array.zeroCreate<struct (int32 * int32)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method21(v3, v0, v4)
    v3
and closure173 (v0 : (unit -> struct (int32 * int32))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : int32) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = Html.fragment [ v3 |> unbox<JSX.Element> ]
    [|v4|]
and closure172 (v0 : (unit -> struct (int32 * int32))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US1, v6 : US1, v7 : US3, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US4, v15 : US5, v16 : US1, v17 : US1, v18 : US4, v19 : US6, v20 : US1, v21 : US1, v22 : US1, v23 : US7, v24 : US4, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US8, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US9, v44 : US10, v45 : US9, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US8, v62 : US1, v63 : US1, v64 : US6, v65 : US1, v66 : US0, v67 : US1) = method4()
    let v68 : (unit -> (JSX.Element [])) = closure173(v0)
    let v69 : US5 = US5_1(v68)
    let v70 : ((string * obj) []) = method5(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v69, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
    let v71 : obj = createObj v70
    let v72 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v72, v71) |> unbox<JSX.Element>
    [|v76|]
and closure171 () (v0 : (unit -> struct (int32 * int32))) : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure10()
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method4()
    let struct (v65 : int32, v66 : int32) = v0 ()
    let v67 : string = v65.ToString ()
    let v68 : JSX.Element = Html.fragment [ v67 |> unbox<JSX.Element> ]
    let v69 : (unit -> (JSX.Element [])) = closure172(v0)
    let v70 : US5 = US5_1(v69)
    let v71 : string = "3px"
    let v72 : US1 = US1_1(v71)
    let v73 : US8 = US8_1(v68)
    let v74 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v70; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v72; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v73; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    let v75 : US11 = US11_0
    let v76 : US12 = US12_2
    let v77 : Mut3 = {l0 = v75; l1 = v74; l2 = v76} : Mut3
    let v78 : obj = v77
    let v79 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v80 : string = "createComponent"
    let v81 : string = "solid-js"
    let v82 : JS.Function = import v80 v81
    let v83 : JSX.Element = v82.Invoke (v79, v78) |> unbox<JSX.Element>
    [|v83|]
and closure170 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (int32 * obj) []), v2 : (struct (int32 * obj) []), v3 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v4 : int32 = v3.Length
    let v5 : UH1 = UH1_1
    let v6 : Mut15 = {l0 = 0; l1 = v5} : Mut15
    while method17(v4, v6) do
        let v8 : int32 = v6.l0
        let v9 : int32 =  -v8
        let v10 : int32 = v9 + v4
        let v11 : int32 = v10 - 1
        let v12 : UH1 = v6.l1
        let struct (v13 : int32, v14 : int32) = v3.[int v11]
        let v15 : int32 = v8 + 1
        let v16 : UH1 = UH1_0(v13, v14, v12)
        v6.l0 <- v15
        v6.l1 <- v16
        ()
    let v17 : UH1 = v6.l1
    let v18 : UH1 = UH1_1
    let v19 : UH1 = method18(v17, v18)
    let v20 : (struct (int32 * int32) []) = method19(v19)
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : JS.Function = import v21 v22
    let v24 : ((unit -> struct (int32 * int32)) -> (JSX.Element [])) = closure171()
    let v25 : (unit -> (JSX.Element [])) = v24 |> unbox
    let struct (v26 : US1, v27 : US1, v28 : US3, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US4, v36 : US5, v37 : US1, v38 : US1, v39 : US4, v40 : US6, v41 : US1, v42 : US1, v43 : US1, v44 : US7, v45 : US4, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US8, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US9, v65 : US10, v66 : US9, v67 : US1, v68 : US1, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US1, v77 : US1, v78 : US1, v79 : US1, v80 : US1, v81 : US1, v82 : US8, v83 : US1, v84 : US1, v85 : US6, v86 : US1, v87 : US0, v88 : US1) = method4()
    let v90 : (struct (int32 * int32) []) = [||]
    let v91 : int32 = v20.Length
    let v92 : (obj []) = Array.zeroCreate<obj> (v91)
    let v93 : Mut5 = {l0 = 0} : Mut5
    while method12(v91, v93) do
        let v95 : int32 = v93.l0
        let struct (v96 : int32, v97 : int32) = v20.[int v95]
        let v98 : obj = struct (v96, v97)
        v92.[int v95] <- v98
        let v99 : int32 = v95 + 1
        v93.l0 <- v99
        ()
    let v100 : US5 = US5_1(v25)
    let v101 : US7 = US7_1(v92)
    let v102 : ((string * obj) []) = method5(v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v100, v37, v38, v39, v40, v41, v42, v43, v101, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88)
    let v103 : obj = createObj v102
    let v104 : (obj -> JSX.Element) = v23 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v105 : string = "createComponent"
    let v106 : JS.Function = import v105 v22
    let v107 : JSX.Element = v106.Invoke (v104, v103) |> unbox<JSX.Element>
    [|v107|]
and closure169 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : (Mut2 -> JSX.Element) = closure6()
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method4()
    let v65 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    let struct (v66 : US1, v67 : US1, v68 : US3, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US4, v76 : US5, v77 : US1, v78 : US1, v79 : US4, v80 : US6, v81 : US1, v82 : US1, v83 : US1, v84 : US7, v85 : US4, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US8, v92 : US1, v93 : US1, v94 : US1, v95 : US8, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US9, v105 : US10, v106 : US9, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US8, v123 : US1, v124 : US1, v125 : US6, v126 : US1, v127 : US0, v128 : US1) = v65.l0, v65.l1, v65.l2, v65.l3, v65.l4, v65.l5, v65.l6, v65.l7, v65.l8, v65.l9, v65.l10, v65.l11, v65.l12, v65.l13, v65.l14, v65.l15, v65.l16, v65.l17, v65.l18, v65.l19, v65.l20, v65.l21, v65.l22, v65.l23, v65.l24, v65.l25, v65.l26, v65.l27, v65.l28, v65.l29, v65.l30, v65.l31, v65.l32, v65.l33, v65.l34, v65.l35, v65.l36, v65.l37, v65.l38, v65.l39, v65.l40, v65.l41, v65.l42, v65.l43, v65.l44, v65.l45, v65.l46, v65.l47, v65.l48, v65.l49, v65.l50, v65.l51, v65.l52, v65.l53, v65.l54, v65.l55, v65.l56, v65.l57, v65.l58, v65.l59, v65.l60, v65.l61, v65.l62
    let v129 : (unit -> (JSX.Element [])) = closure170(v0)
    let v130 : US5 = US5_1(v129)
    emitJsExpr (struct (v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v130, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128), v129) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v131 : US5 = US5_1(v129)
    let v132 : Mut2 = {l0 = v66; l1 = v67; l2 = v68; l3 = v69; l4 = v70; l5 = v71; l6 = v72; l7 = v73; l8 = v74; l9 = v75; l10 = v131; l11 = v77; l12 = v78; l13 = v79; l14 = v80; l15 = v81; l16 = v82; l17 = v83; l18 = v84; l19 = v85; l20 = v86; l21 = v87; l22 = v88; l23 = v89; l24 = v90; l25 = v91; l26 = v92; l27 = v93; l28 = v94; l29 = v95; l30 = v96; l31 = v97; l32 = v98; l33 = v99; l34 = v100; l35 = v101; l36 = v102; l37 = v103; l38 = v104; l39 = v105; l40 = v106; l41 = v107; l42 = v108; l43 = v109; l44 = v110; l45 = v111; l46 = v112; l47 = v113; l48 = v114; l49 = v115; l50 = v116; l51 = v117; l52 = v118; l53 = v119; l54 = v120; l55 = v121; l56 = v122; l57 = v123; l58 = v124; l59 = v125; l60 = v126; l61 = v127; l62 = v128} : Mut2
    let v133 : obj = v132
    let v134 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v135 : string = "createComponent"
    let v136 : string = "solid-js"
    let v137 : JS.Function = import v135 v136
    let v138 : JSX.Element = v137.Invoke (v134, v133) |> unbox<JSX.Element>
    [|v138|]
and closure160 () (v0 : Mut2) : JSX.Element =
    let v1 : string = "useStoreon"
    let v2 : string = "@storeon/solidjs"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke () |> unbox<JS.Function[]>
    let v5 : Mut1 = v4.[0] |> unbox
    let v6 : JS.Function = v4.[1] |> unbox
    let v7 : (Mut3 -> JSX.Element) = closure10()
    let struct (v8 : US1, v9 : US1, v10 : US3, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US4, v18 : US5, v19 : US1, v20 : US1, v21 : US4, v22 : US6, v23 : US1, v24 : US1, v25 : US1, v26 : US7, v27 : US4, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US8, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US9, v47 : US10, v48 : US9, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US8, v65 : US1, v66 : US1, v67 : US6, v68 : US1, v69 : US0, v70 : US1) = method4()
    let v71 : string = "Stack"
    let v72 : string = "@hope-ui/solid"
    let v73 : JS.Function = import v71 v72
    let struct (v74 : US1, v75 : US1, v76 : US3, v77 : US1, v78 : US1, v79 : US1, v80 : US1, v81 : US1, v82 : US1, v83 : US4, v84 : US5, v85 : US1, v86 : US1, v87 : US4, v88 : US6, v89 : US1, v90 : US1, v91 : US1, v92 : US7, v93 : US4, v94 : US1, v95 : US1, v96 : US1, v97 : US1, v98 : US1, v99 : US8, v100 : US1, v101 : US1, v102 : US1, v103 : US8, v104 : US1, v105 : US1, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US9, v113 : US10, v114 : US9, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US8, v131 : US1, v132 : US1, v133 : US6, v134 : US1, v135 : US0, v136 : US1) = method4()
    let v137 : string = "row"
    let v138 : string = "column"
    let v139 : string = method10(v138, v137)
    let v140 : string = "0"
    let v141 : string = "8px"
    let v142 : string = method10(v141, v140)
    let v143 : string = "start"
    let v144 : US1 = US1_1(v143)
    let v145 : (unit -> (JSX.Element [])) = closure161()
    let v146 : US5 = US5_1(v145)
    let v147 : US1 = US1_1(v139)
    let v148 : US1 = US1_1(v142)
    let v149 : string = "3px"
    let v150 : US1 = US1_1(v149)
    let v151 : string = "7px"
    let v152 : US1 = US1_1(v151)
    let v153 : ((string * obj) []) = method5(v144, v75, v76, v77, v78, v79, v80, v81, v82, v83, v146, v85, v86, v87, v88, v89, v147, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v148, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v150, v119, v120, v121, v122, v123, v124, v125, v152, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136)
    let v154 : obj = createObj v153
    let v155 : (obj -> JSX.Element) = v73 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v156 : string = "createComponent"
    let v157 : string = "solid-js"
    let v158 : JS.Function = import v156 v157
    let v159 : JSX.Element = v158.Invoke (v155, v154) |> unbox<JSX.Element>
    let v160 : (unit -> (JSX.Element [])) = closure169(v5)
    let v161 : US5 = US5_1(v160)
    let v162 : string = "counter"
    let v163 : US1 = US1_1(v162)
    let v164 : US8 = US8_1(v159)
    let v165 : Mut2 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v161; l11 = v19; l12 = v20; l13 = v21; l14 = v22; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v163; l27 = v35; l28 = v36; l29 = v37; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50; l43 = v51; l44 = v52; l45 = v53; l46 = v54; l47 = v55; l48 = v56; l49 = v57; l50 = v58; l51 = v59; l52 = v60; l53 = v61; l54 = v62; l55 = v63; l56 = v164; l57 = v65; l58 = v66; l59 = v67; l60 = v68; l61 = v69; l62 = v70} : Mut2
    let v166 : US11 = US11_0
    let v167 : US12 = US12_2
    let v168 : Mut3 = {l0 = v166; l1 = v165; l2 = v167} : Mut3
    let v169 : obj = v168
    let v170 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v171 : JS.Function = import v156 v157
    let v172 : JSX.Element = v171.Invoke (v170, v169) |> unbox<JSX.Element>
    v172
and closure174 () () : (JSX.Element []) =
    [||]
and closure177 () () : (JSX.Element []) =
    let v0 : string = "Chain Status"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure178 () () : unit =
    ()
and closure179 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure180 () () : unit =
    ()
and closure181 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure176 () () : (JSX.Element []) =
    let v0 : string = "Box"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US1, v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = method4()
    let v66 : (unit -> (JSX.Element [])) = closure177()
    let v67 : US5 = US5_1(v66)
    let v68 : ((string * obj) []) = method5(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v67, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65)
    let v69 : obj = createObj v68
    let v70 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v70, v69) |> unbox<JSX.Element>
    let v75 : (Mut2 -> JSX.Element) = closure24()
    let struct (v76 : US1, v77 : US1, v78 : US3, v79 : US1, v80 : US1, v81 : US1, v82 : US1, v83 : US1, v84 : US1, v85 : US4, v86 : US5, v87 : US1, v88 : US1, v89 : US4, v90 : US6, v91 : US1, v92 : US1, v93 : US1, v94 : US7, v95 : US4, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US8, v102 : US1, v103 : US1, v104 : US1, v105 : US8, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US9, v115 : US10, v116 : US9, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US8, v133 : US1, v134 : US1, v135 : US6, v136 : US1, v137 : US0, v138 : US1) = method4()
    let v139 : Mut2 = {l0 = v76; l1 = v77; l2 = v78; l3 = v79; l4 = v80; l5 = v81; l6 = v82; l7 = v83; l8 = v84; l9 = v85; l10 = v86; l11 = v87; l12 = v88; l13 = v89; l14 = v90; l15 = v91; l16 = v92; l17 = v93; l18 = v94; l19 = v95; l20 = v96; l21 = v97; l22 = v98; l23 = v99; l24 = v100; l25 = v101; l26 = v102; l27 = v103; l28 = v104; l29 = v105; l30 = v106; l31 = v107; l32 = v108; l33 = v109; l34 = v110; l35 = v111; l36 = v112; l37 = v113; l38 = v114; l39 = v115; l40 = v116; l41 = v117; l42 = v118; l43 = v119; l44 = v120; l45 = v121; l46 = v122; l47 = v123; l48 = v124; l49 = v125; l50 = v126; l51 = v127; l52 = v128; l53 = v129; l54 = v130; l55 = v131; l56 = v132; l57 = v133; l58 = v134; l59 = v135; l60 = v136; l61 = v137; l62 = v138} : Mut2
    let v140 : (Mut6 -> JSX.Element) = closure31()
    let v141 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = closure33()
    let v142 : (unit -> JS.Function) = closure163()
    let v143 : Mut6 = {l0 = v141; l1 = v142; l2 = v141} : Mut6
    let v144 : obj = v143
    let v145 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v146 : JS.Function = import v71 v72
    let v147 : JSX.Element = v146.Invoke (v145, v144) |> unbox<JSX.Element>
    let v148 : US8 = US8_1(v147)
    v139.l29 <- v148
    let v149 : string = "10px"
    let v150 : US1 = US1_1(v149)
    v139.l47 <- v150
    let v151 : (unit -> unit) = closure178()
    let v152 : US10 = US10_1(v151)
    v139.l39 <- v152
    let struct (v153 : US1, v154 : US1, v155 : US3, v156 : US1, v157 : US1, v158 : US1, v159 : US1, v160 : US1, v161 : US1, v162 : US4, v163 : US5, v164 : US1, v165 : US1, v166 : US4, v167 : US6, v168 : US1, v169 : US1, v170 : US1, v171 : US7, v172 : US4, v173 : US1, v174 : US1, v175 : US1, v176 : US1, v177 : US1, v178 : US8, v179 : US1, v180 : US1, v181 : US1, v182 : US8, v183 : US1, v184 : US1, v185 : US1, v186 : US1, v187 : US1, v188 : US1, v189 : US1, v190 : US1, v191 : US9, v192 : US10, v193 : US9, v194 : US1, v195 : US1, v196 : US1, v197 : US1, v198 : US1, v199 : US1, v200 : US1, v201 : US1, v202 : US1, v203 : US1, v204 : US1, v205 : US1, v206 : US1, v207 : US1, v208 : US1, v209 : US8, v210 : US1, v211 : US1, v212 : US6, v213 : US1, v214 : US0, v215 : US1) = v139.l0, v139.l1, v139.l2, v139.l3, v139.l4, v139.l5, v139.l6, v139.l7, v139.l8, v139.l9, v139.l10, v139.l11, v139.l12, v139.l13, v139.l14, v139.l15, v139.l16, v139.l17, v139.l18, v139.l19, v139.l20, v139.l21, v139.l22, v139.l23, v139.l24, v139.l25, v139.l26, v139.l27, v139.l28, v139.l29, v139.l30, v139.l31, v139.l32, v139.l33, v139.l34, v139.l35, v139.l36, v139.l37, v139.l38, v139.l39, v139.l40, v139.l41, v139.l42, v139.l43, v139.l44, v139.l45, v139.l46, v139.l47, v139.l48, v139.l49, v139.l50, v139.l51, v139.l52, v139.l53, v139.l54, v139.l55, v139.l56, v139.l57, v139.l58, v139.l59, v139.l60, v139.l61, v139.l62
    let v216 : (unit -> (JSX.Element [])) = closure179()
    let v217 : US5 = US5_1(v216)
    emitJsExpr (struct (v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v217, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215), v216) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v218 : US5 = US5_1(v216)
    let v219 : Mut2 = {l0 = v153; l1 = v154; l2 = v155; l3 = v156; l4 = v157; l5 = v158; l6 = v159; l7 = v160; l8 = v161; l9 = v162; l10 = v218; l11 = v164; l12 = v165; l13 = v166; l14 = v167; l15 = v168; l16 = v169; l17 = v170; l18 = v171; l19 = v172; l20 = v173; l21 = v174; l22 = v175; l23 = v176; l24 = v177; l25 = v178; l26 = v179; l27 = v180; l28 = v181; l29 = v182; l30 = v183; l31 = v184; l32 = v185; l33 = v186; l34 = v187; l35 = v188; l36 = v189; l37 = v190; l38 = v191; l39 = v192; l40 = v193; l41 = v194; l42 = v195; l43 = v196; l44 = v197; l45 = v198; l46 = v199; l47 = v200; l48 = v201; l49 = v202; l50 = v203; l51 = v204; l52 = v205; l53 = v206; l54 = v207; l55 = v208; l56 = v209; l57 = v210; l58 = v211; l59 = v212; l60 = v213; l61 = v214; l62 = v215} : Mut2
    let v220 : obj = v219
    let v221 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v222 : JS.Function = import v71 v72
    let v223 : JSX.Element = v222.Invoke (v221, v220) |> unbox<JSX.Element>
    let struct (v224 : US1, v225 : US1, v226 : US3, v227 : US1, v228 : US1, v229 : US1, v230 : US1, v231 : US1, v232 : US1, v233 : US4, v234 : US5, v235 : US1, v236 : US1, v237 : US4, v238 : US6, v239 : US1, v240 : US1, v241 : US1, v242 : US7, v243 : US4, v244 : US1, v245 : US1, v246 : US1, v247 : US1, v248 : US1, v249 : US8, v250 : US1, v251 : US1, v252 : US1, v253 : US8, v254 : US1, v255 : US1, v256 : US1, v257 : US1, v258 : US1, v259 : US1, v260 : US1, v261 : US1, v262 : US9, v263 : US10, v264 : US9, v265 : US1, v266 : US1, v267 : US1, v268 : US1, v269 : US1, v270 : US1, v271 : US1, v272 : US1, v273 : US1, v274 : US1, v275 : US1, v276 : US1, v277 : US1, v278 : US1, v279 : US1, v280 : US8, v281 : US1, v282 : US1, v283 : US6, v284 : US1, v285 : US0, v286 : US1) = method4()
    let v287 : Mut2 = {l0 = v224; l1 = v225; l2 = v226; l3 = v227; l4 = v228; l5 = v229; l6 = v230; l7 = v231; l8 = v232; l9 = v233; l10 = v234; l11 = v235; l12 = v236; l13 = v237; l14 = v238; l15 = v239; l16 = v240; l17 = v241; l18 = v242; l19 = v243; l20 = v244; l21 = v245; l22 = v246; l23 = v247; l24 = v248; l25 = v249; l26 = v250; l27 = v251; l28 = v252; l29 = v253; l30 = v254; l31 = v255; l32 = v256; l33 = v257; l34 = v258; l35 = v259; l36 = v260; l37 = v261; l38 = v262; l39 = v263; l40 = v264; l41 = v265; l42 = v266; l43 = v267; l44 = v268; l45 = v269; l46 = v270; l47 = v271; l48 = v272; l49 = v273; l50 = v274; l51 = v275; l52 = v276; l53 = v277; l54 = v278; l55 = v279; l56 = v280; l57 = v281; l58 = v282; l59 = v283; l60 = v284; l61 = v285; l62 = v286} : Mut2
    let v288 : (unit -> JS.Function) = closure166()
    let v289 : Mut6 = {l0 = v141; l1 = v288; l2 = v141} : Mut6
    let v290 : obj = v289
    let v291 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v292 : JS.Function = import v71 v72
    let v293 : JSX.Element = v292.Invoke (v291, v290) |> unbox<JSX.Element>
    let v294 : US8 = US8_1(v293)
    v287.l29 <- v294
    let v295 : US1 = US1_1(v149)
    v287.l47 <- v295
    let v296 : (unit -> unit) = closure180()
    let v297 : US10 = US10_1(v296)
    v287.l39 <- v297
    let struct (v298 : US1, v299 : US1, v300 : US3, v301 : US1, v302 : US1, v303 : US1, v304 : US1, v305 : US1, v306 : US1, v307 : US4, v308 : US5, v309 : US1, v310 : US1, v311 : US4, v312 : US6, v313 : US1, v314 : US1, v315 : US1, v316 : US7, v317 : US4, v318 : US1, v319 : US1, v320 : US1, v321 : US1, v322 : US1, v323 : US8, v324 : US1, v325 : US1, v326 : US1, v327 : US8, v328 : US1, v329 : US1, v330 : US1, v331 : US1, v332 : US1, v333 : US1, v334 : US1, v335 : US1, v336 : US9, v337 : US10, v338 : US9, v339 : US1, v340 : US1, v341 : US1, v342 : US1, v343 : US1, v344 : US1, v345 : US1, v346 : US1, v347 : US1, v348 : US1, v349 : US1, v350 : US1, v351 : US1, v352 : US1, v353 : US1, v354 : US8, v355 : US1, v356 : US1, v357 : US6, v358 : US1, v359 : US0, v360 : US1) = v287.l0, v287.l1, v287.l2, v287.l3, v287.l4, v287.l5, v287.l6, v287.l7, v287.l8, v287.l9, v287.l10, v287.l11, v287.l12, v287.l13, v287.l14, v287.l15, v287.l16, v287.l17, v287.l18, v287.l19, v287.l20, v287.l21, v287.l22, v287.l23, v287.l24, v287.l25, v287.l26, v287.l27, v287.l28, v287.l29, v287.l30, v287.l31, v287.l32, v287.l33, v287.l34, v287.l35, v287.l36, v287.l37, v287.l38, v287.l39, v287.l40, v287.l41, v287.l42, v287.l43, v287.l44, v287.l45, v287.l46, v287.l47, v287.l48, v287.l49, v287.l50, v287.l51, v287.l52, v287.l53, v287.l54, v287.l55, v287.l56, v287.l57, v287.l58, v287.l59, v287.l60, v287.l61, v287.l62
    let v361 : (unit -> (JSX.Element [])) = closure181()
    let v362 : US5 = US5_1(v361)
    emitJsExpr (struct (v298, v299, v300, v301, v302, v303, v304, v305, v306, v307, v362, v309, v310, v311, v312, v313, v314, v315, v316, v317, v318, v319, v320, v321, v322, v323, v324, v325, v326, v327, v328, v329, v330, v331, v332, v333, v334, v335, v336, v337, v338, v339, v340, v341, v342, v343, v344, v345, v346, v347, v348, v349, v350, v351, v352, v353, v354, v355, v356, v357, v358, v359, v360), v361) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v363 : US5 = US5_1(v361)
    let v364 : Mut2 = {l0 = v298; l1 = v299; l2 = v300; l3 = v301; l4 = v302; l5 = v303; l6 = v304; l7 = v305; l8 = v306; l9 = v307; l10 = v363; l11 = v309; l12 = v310; l13 = v311; l14 = v312; l15 = v313; l16 = v314; l17 = v315; l18 = v316; l19 = v317; l20 = v318; l21 = v319; l22 = v320; l23 = v321; l24 = v322; l25 = v323; l26 = v324; l27 = v325; l28 = v326; l29 = v327; l30 = v328; l31 = v329; l32 = v330; l33 = v331; l34 = v332; l35 = v333; l36 = v334; l37 = v335; l38 = v336; l39 = v337; l40 = v338; l41 = v339; l42 = v340; l43 = v341; l44 = v342; l45 = v343; l46 = v344; l47 = v345; l48 = v346; l49 = v347; l50 = v348; l51 = v349; l52 = v350; l53 = v351; l54 = v352; l55 = v353; l56 = v354; l57 = v355; l58 = v356; l59 = v357; l60 = v358; l61 = v359; l62 = v360} : Mut2
    let v365 : obj = v364
    let v366 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v367 : JS.Function = import v71 v72
    let v368 : JSX.Element = v367.Invoke (v366, v365) |> unbox<JSX.Element>
    [|v74; v223; v368|]
and method22 (v0 : int32, v1 : Mut16) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method23 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH2 = UH2_0(v2, v3, v1)
        method23(v4, v5)
    | UH2_1 -> (* Nil *)
        v1
and method25 (v0 : UH2, v1 : int32) : int32 =
    match v0 with
    | UH2_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method25(v4, v5)
    | UH2_1 -> (* Nil *)
        v1
and method26 (v0 : (struct (int32 * obj) []), v1 : UH2, v2 : int32) : int32 =
    match v1 with
    | UH2_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method26(v0, v5, v6)
    | UH2_1 -> (* Nil *)
        v2
and method24 (v0 : UH2) : (struct (int32 * obj) []) =
    let v1 : int32 = 0
    let v2 : int32 = method25(v0, v1)
    let v3 : (struct (int32 * obj) []) = Array.zeroCreate<struct (int32 * obj)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method26(v3, v0, v4)
    v3
and closure186 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : obj) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = Html.fragment [ v3 |> unbox<JSX.Element> ]
    [|v4|]
and closure185 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US1, v6 : US1, v7 : US3, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US4, v15 : US5, v16 : US1, v17 : US1, v18 : US4, v19 : US6, v20 : US1, v21 : US1, v22 : US1, v23 : US7, v24 : US4, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US8, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US9, v44 : US10, v45 : US9, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US8, v62 : US1, v63 : US1, v64 : US6, v65 : US1, v66 : US0, v67 : US1) = method4()
    let v68 : (unit -> (JSX.Element [])) = closure186(v0)
    let v69 : US5 = US5_1(v68)
    let v70 : ((string * obj) []) = method5(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v69, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
    let v71 : obj = createObj v70
    let v72 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v72, v71) |> unbox<JSX.Element>
    [|v76|]
and closure184 () (v0 : (unit -> struct (int32 * obj))) : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure10()
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method4()
    let struct (v65 : int32, v66 : obj) = v0 ()
    let v67 : string = v65.ToString ()
    let v68 : JSX.Element = Html.fragment [ v67 |> unbox<JSX.Element> ]
    let v69 : (unit -> (JSX.Element [])) = closure185(v0)
    let v70 : US5 = US5_1(v69)
    let v71 : string = "3px"
    let v72 : US1 = US1_1(v71)
    let v73 : US8 = US8_1(v68)
    let v74 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v70; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v72; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v73; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    let v75 : US11 = US11_0
    let v76 : US12 = US12_2
    let v77 : Mut3 = {l0 = v75; l1 = v74; l2 = v76} : Mut3
    let v78 : obj = v77
    let v79 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v80 : string = "createComponent"
    let v81 : string = "solid-js"
    let v82 : JS.Function = import v80 v81
    let v83 : JSX.Element = v82.Invoke (v79, v78) |> unbox<JSX.Element>
    [|v83|]
and closure183 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (int32 * obj) []), v2 : (struct (int32 * obj) []), v3 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v4 : int32 = v2.Length
    let v5 : UH2 = UH2_1
    let v6 : Mut16 = {l0 = 0; l1 = v5} : Mut16
    while method22(v4, v6) do
        let v8 : int32 = v6.l0
        let v9 : int32 =  -v8
        let v10 : int32 = v9 + v4
        let v11 : int32 = v10 - 1
        let v12 : UH2 = v6.l1
        let struct (v13 : int32, v14 : obj) = v2.[int v11]
        let v15 : int32 = v8 + 1
        let v16 : UH2 = UH2_0(v13, v14, v12)
        v6.l0 <- v15
        v6.l1 <- v16
        ()
    let v17 : UH2 = v6.l1
    let v18 : UH2 = UH2_1
    let v19 : UH2 = method23(v17, v18)
    let v20 : (struct (int32 * obj) []) = method24(v19)
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : JS.Function = import v21 v22
    let v24 : ((unit -> struct (int32 * obj)) -> (JSX.Element [])) = closure184()
    let v25 : (unit -> (JSX.Element [])) = v24 |> unbox
    let struct (v26 : US1, v27 : US1, v28 : US3, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US4, v36 : US5, v37 : US1, v38 : US1, v39 : US4, v40 : US6, v41 : US1, v42 : US1, v43 : US1, v44 : US7, v45 : US4, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US8, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US9, v65 : US10, v66 : US9, v67 : US1, v68 : US1, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US1, v77 : US1, v78 : US1, v79 : US1, v80 : US1, v81 : US1, v82 : US8, v83 : US1, v84 : US1, v85 : US6, v86 : US1, v87 : US0, v88 : US1) = method4()
    let v90 : (struct (int32 * obj) []) = [||]
    let v91 : int32 = v20.Length
    let v92 : (obj []) = Array.zeroCreate<obj> (v91)
    let v93 : Mut5 = {l0 = 0} : Mut5
    while method12(v91, v93) do
        let v95 : int32 = v93.l0
        let struct (v96 : int32, v97 : obj) = v20.[int v95]
        let v98 : obj = struct (v96, v97)
        v92.[int v95] <- v98
        let v99 : int32 = v95 + 1
        v93.l0 <- v99
        ()
    let v100 : US5 = US5_1(v25)
    let v101 : US7 = US7_1(v92)
    let v102 : ((string * obj) []) = method5(v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v100, v37, v38, v39, v40, v41, v42, v43, v101, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88)
    let v103 : obj = createObj v102
    let v104 : (obj -> JSX.Element) = v23 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v105 : string = "createComponent"
    let v106 : JS.Function = import v105 v22
    let v107 : JSX.Element = v106.Invoke (v104, v103) |> unbox<JSX.Element>
    [|v107|]
and closure182 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : (Mut2 -> JSX.Element) = closure6()
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method4()
    let v65 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    let struct (v66 : US1, v67 : US1, v68 : US3, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US4, v76 : US5, v77 : US1, v78 : US1, v79 : US4, v80 : US6, v81 : US1, v82 : US1, v83 : US1, v84 : US7, v85 : US4, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US8, v92 : US1, v93 : US1, v94 : US1, v95 : US8, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US9, v105 : US10, v106 : US9, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US8, v123 : US1, v124 : US1, v125 : US6, v126 : US1, v127 : US0, v128 : US1) = v65.l0, v65.l1, v65.l2, v65.l3, v65.l4, v65.l5, v65.l6, v65.l7, v65.l8, v65.l9, v65.l10, v65.l11, v65.l12, v65.l13, v65.l14, v65.l15, v65.l16, v65.l17, v65.l18, v65.l19, v65.l20, v65.l21, v65.l22, v65.l23, v65.l24, v65.l25, v65.l26, v65.l27, v65.l28, v65.l29, v65.l30, v65.l31, v65.l32, v65.l33, v65.l34, v65.l35, v65.l36, v65.l37, v65.l38, v65.l39, v65.l40, v65.l41, v65.l42, v65.l43, v65.l44, v65.l45, v65.l46, v65.l47, v65.l48, v65.l49, v65.l50, v65.l51, v65.l52, v65.l53, v65.l54, v65.l55, v65.l56, v65.l57, v65.l58, v65.l59, v65.l60, v65.l61, v65.l62
    let v129 : (unit -> (JSX.Element [])) = closure183(v0)
    let v130 : US5 = US5_1(v129)
    emitJsExpr (struct (v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v130, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128), v129) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v131 : US5 = US5_1(v129)
    let v132 : Mut2 = {l0 = v66; l1 = v67; l2 = v68; l3 = v69; l4 = v70; l5 = v71; l6 = v72; l7 = v73; l8 = v74; l9 = v75; l10 = v131; l11 = v77; l12 = v78; l13 = v79; l14 = v80; l15 = v81; l16 = v82; l17 = v83; l18 = v84; l19 = v85; l20 = v86; l21 = v87; l22 = v88; l23 = v89; l24 = v90; l25 = v91; l26 = v92; l27 = v93; l28 = v94; l29 = v95; l30 = v96; l31 = v97; l32 = v98; l33 = v99; l34 = v100; l35 = v101; l36 = v102; l37 = v103; l38 = v104; l39 = v105; l40 = v106; l41 = v107; l42 = v108; l43 = v109; l44 = v110; l45 = v111; l46 = v112; l47 = v113; l48 = v114; l49 = v115; l50 = v116; l51 = v117; l52 = v118; l53 = v119; l54 = v120; l55 = v121; l56 = v122; l57 = v123; l58 = v124; l59 = v125; l60 = v126; l61 = v127; l62 = v128} : Mut2
    let v133 : obj = v132
    let v134 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v135 : string = "createComponent"
    let v136 : string = "solid-js"
    let v137 : JS.Function = import v135 v136
    let v138 : JSX.Element = v137.Invoke (v134, v133) |> unbox<JSX.Element>
    [|v138|]
and closure175 () (v0 : Mut2) : JSX.Element =
    let v1 : string = "useStoreon"
    let v2 : string = "@storeon/solidjs"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke () |> unbox<JS.Function[]>
    let v5 : Mut1 = v4.[0] |> unbox
    let v6 : JS.Function = v4.[1] |> unbox
    let v7 : (Mut3 -> JSX.Element) = closure10()
    let struct (v8 : US1, v9 : US1, v10 : US3, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US4, v18 : US5, v19 : US1, v20 : US1, v21 : US4, v22 : US6, v23 : US1, v24 : US1, v25 : US1, v26 : US7, v27 : US4, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US8, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US9, v47 : US10, v48 : US9, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US8, v65 : US1, v66 : US1, v67 : US6, v68 : US1, v69 : US0, v70 : US1) = method4()
    let v71 : string = "Stack"
    let v72 : string = "@hope-ui/solid"
    let v73 : JS.Function = import v71 v72
    let struct (v74 : US1, v75 : US1, v76 : US3, v77 : US1, v78 : US1, v79 : US1, v80 : US1, v81 : US1, v82 : US1, v83 : US4, v84 : US5, v85 : US1, v86 : US1, v87 : US4, v88 : US6, v89 : US1, v90 : US1, v91 : US1, v92 : US7, v93 : US4, v94 : US1, v95 : US1, v96 : US1, v97 : US1, v98 : US1, v99 : US8, v100 : US1, v101 : US1, v102 : US1, v103 : US8, v104 : US1, v105 : US1, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US9, v113 : US10, v114 : US9, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US8, v131 : US1, v132 : US1, v133 : US6, v134 : US1, v135 : US0, v136 : US1) = method4()
    let v137 : string = "row"
    let v138 : string = "column"
    let v139 : string = method10(v138, v137)
    let v140 : string = "0"
    let v141 : string = "8px"
    let v142 : string = method10(v141, v140)
    let v143 : string = "start"
    let v144 : US1 = US1_1(v143)
    let v145 : (unit -> (JSX.Element [])) = closure176()
    let v146 : US5 = US5_1(v145)
    let v147 : US1 = US1_1(v139)
    let v148 : US1 = US1_1(v142)
    let v149 : string = "3px"
    let v150 : US1 = US1_1(v149)
    let v151 : string = "7px"
    let v152 : US1 = US1_1(v151)
    let v153 : ((string * obj) []) = method5(v144, v75, v76, v77, v78, v79, v80, v81, v82, v83, v146, v85, v86, v87, v88, v89, v147, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v148, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v150, v119, v120, v121, v122, v123, v124, v125, v152, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136)
    let v154 : obj = createObj v153
    let v155 : (obj -> JSX.Element) = v73 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v156 : string = "createComponent"
    let v157 : string = "solid-js"
    let v158 : JS.Function = import v156 v157
    let v159 : JSX.Element = v158.Invoke (v155, v154) |> unbox<JSX.Element>
    let v160 : (unit -> (JSX.Element [])) = closure182(v5)
    let v161 : US5 = US5_1(v160)
    let v162 : string = "status"
    let v163 : US1 = US1_1(v162)
    let v164 : US8 = US8_1(v159)
    let v165 : Mut2 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v161; l11 = v19; l12 = v20; l13 = v21; l14 = v22; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v163; l27 = v35; l28 = v36; l29 = v37; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50; l43 = v51; l44 = v52; l45 = v53; l46 = v54; l47 = v55; l48 = v56; l49 = v57; l50 = v58; l51 = v59; l52 = v60; l53 = v61; l54 = v62; l55 = v63; l56 = v164; l57 = v65; l58 = v66; l59 = v67; l60 = v68; l61 = v69; l62 = v70} : Mut2
    let v166 : US11 = US11_0
    let v167 : US12 = US12_2
    let v168 : Mut3 = {l0 = v166; l1 = v165; l2 = v167} : Mut3
    let v169 : obj = v168
    let v170 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v171 : JS.Function = import v156 v157
    let v172 : JSX.Element = v171.Invoke (v170, v169) |> unbox<JSX.Element>
    v172
and closure187 () () : (JSX.Element []) =
    [||]
and closure190 () () : (JSX.Element []) =
    let v0 : string = "Chain Deploy"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure191 () () : unit =
    ()
and closure192 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure193 () () : unit =
    ()
and closure194 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure189 () () : (JSX.Element []) =
    let v0 : string = "Box"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US1, v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = method4()
    let v66 : (unit -> (JSX.Element [])) = closure190()
    let v67 : US5 = US5_1(v66)
    let v68 : ((string * obj) []) = method5(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v67, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65)
    let v69 : obj = createObj v68
    let v70 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v70, v69) |> unbox<JSX.Element>
    let v75 : (Mut2 -> JSX.Element) = closure24()
    let struct (v76 : US1, v77 : US1, v78 : US3, v79 : US1, v80 : US1, v81 : US1, v82 : US1, v83 : US1, v84 : US1, v85 : US4, v86 : US5, v87 : US1, v88 : US1, v89 : US4, v90 : US6, v91 : US1, v92 : US1, v93 : US1, v94 : US7, v95 : US4, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US8, v102 : US1, v103 : US1, v104 : US1, v105 : US8, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US9, v115 : US10, v116 : US9, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US8, v133 : US1, v134 : US1, v135 : US6, v136 : US1, v137 : US0, v138 : US1) = method4()
    let v139 : Mut2 = {l0 = v76; l1 = v77; l2 = v78; l3 = v79; l4 = v80; l5 = v81; l6 = v82; l7 = v83; l8 = v84; l9 = v85; l10 = v86; l11 = v87; l12 = v88; l13 = v89; l14 = v90; l15 = v91; l16 = v92; l17 = v93; l18 = v94; l19 = v95; l20 = v96; l21 = v97; l22 = v98; l23 = v99; l24 = v100; l25 = v101; l26 = v102; l27 = v103; l28 = v104; l29 = v105; l30 = v106; l31 = v107; l32 = v108; l33 = v109; l34 = v110; l35 = v111; l36 = v112; l37 = v113; l38 = v114; l39 = v115; l40 = v116; l41 = v117; l42 = v118; l43 = v119; l44 = v120; l45 = v121; l46 = v122; l47 = v123; l48 = v124; l49 = v125; l50 = v126; l51 = v127; l52 = v128; l53 = v129; l54 = v130; l55 = v131; l56 = v132; l57 = v133; l58 = v134; l59 = v135; l60 = v136; l61 = v137; l62 = v138} : Mut2
    let v140 : (Mut6 -> JSX.Element) = closure31()
    let v141 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = closure33()
    let v142 : (unit -> JS.Function) = closure163()
    let v143 : Mut6 = {l0 = v141; l1 = v142; l2 = v141} : Mut6
    let v144 : obj = v143
    let v145 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v146 : JS.Function = import v71 v72
    let v147 : JSX.Element = v146.Invoke (v145, v144) |> unbox<JSX.Element>
    let v148 : US8 = US8_1(v147)
    v139.l29 <- v148
    let v149 : string = "10px"
    let v150 : US1 = US1_1(v149)
    v139.l47 <- v150
    let v151 : (unit -> unit) = closure191()
    let v152 : US10 = US10_1(v151)
    v139.l39 <- v152
    let struct (v153 : US1, v154 : US1, v155 : US3, v156 : US1, v157 : US1, v158 : US1, v159 : US1, v160 : US1, v161 : US1, v162 : US4, v163 : US5, v164 : US1, v165 : US1, v166 : US4, v167 : US6, v168 : US1, v169 : US1, v170 : US1, v171 : US7, v172 : US4, v173 : US1, v174 : US1, v175 : US1, v176 : US1, v177 : US1, v178 : US8, v179 : US1, v180 : US1, v181 : US1, v182 : US8, v183 : US1, v184 : US1, v185 : US1, v186 : US1, v187 : US1, v188 : US1, v189 : US1, v190 : US1, v191 : US9, v192 : US10, v193 : US9, v194 : US1, v195 : US1, v196 : US1, v197 : US1, v198 : US1, v199 : US1, v200 : US1, v201 : US1, v202 : US1, v203 : US1, v204 : US1, v205 : US1, v206 : US1, v207 : US1, v208 : US1, v209 : US8, v210 : US1, v211 : US1, v212 : US6, v213 : US1, v214 : US0, v215 : US1) = v139.l0, v139.l1, v139.l2, v139.l3, v139.l4, v139.l5, v139.l6, v139.l7, v139.l8, v139.l9, v139.l10, v139.l11, v139.l12, v139.l13, v139.l14, v139.l15, v139.l16, v139.l17, v139.l18, v139.l19, v139.l20, v139.l21, v139.l22, v139.l23, v139.l24, v139.l25, v139.l26, v139.l27, v139.l28, v139.l29, v139.l30, v139.l31, v139.l32, v139.l33, v139.l34, v139.l35, v139.l36, v139.l37, v139.l38, v139.l39, v139.l40, v139.l41, v139.l42, v139.l43, v139.l44, v139.l45, v139.l46, v139.l47, v139.l48, v139.l49, v139.l50, v139.l51, v139.l52, v139.l53, v139.l54, v139.l55, v139.l56, v139.l57, v139.l58, v139.l59, v139.l60, v139.l61, v139.l62
    let v216 : (unit -> (JSX.Element [])) = closure192()
    let v217 : US5 = US5_1(v216)
    emitJsExpr (struct (v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v217, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215), v216) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v218 : US5 = US5_1(v216)
    let v219 : Mut2 = {l0 = v153; l1 = v154; l2 = v155; l3 = v156; l4 = v157; l5 = v158; l6 = v159; l7 = v160; l8 = v161; l9 = v162; l10 = v218; l11 = v164; l12 = v165; l13 = v166; l14 = v167; l15 = v168; l16 = v169; l17 = v170; l18 = v171; l19 = v172; l20 = v173; l21 = v174; l22 = v175; l23 = v176; l24 = v177; l25 = v178; l26 = v179; l27 = v180; l28 = v181; l29 = v182; l30 = v183; l31 = v184; l32 = v185; l33 = v186; l34 = v187; l35 = v188; l36 = v189; l37 = v190; l38 = v191; l39 = v192; l40 = v193; l41 = v194; l42 = v195; l43 = v196; l44 = v197; l45 = v198; l46 = v199; l47 = v200; l48 = v201; l49 = v202; l50 = v203; l51 = v204; l52 = v205; l53 = v206; l54 = v207; l55 = v208; l56 = v209; l57 = v210; l58 = v211; l59 = v212; l60 = v213; l61 = v214; l62 = v215} : Mut2
    let v220 : obj = v219
    let v221 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v222 : JS.Function = import v71 v72
    let v223 : JSX.Element = v222.Invoke (v221, v220) |> unbox<JSX.Element>
    let struct (v224 : US1, v225 : US1, v226 : US3, v227 : US1, v228 : US1, v229 : US1, v230 : US1, v231 : US1, v232 : US1, v233 : US4, v234 : US5, v235 : US1, v236 : US1, v237 : US4, v238 : US6, v239 : US1, v240 : US1, v241 : US1, v242 : US7, v243 : US4, v244 : US1, v245 : US1, v246 : US1, v247 : US1, v248 : US1, v249 : US8, v250 : US1, v251 : US1, v252 : US1, v253 : US8, v254 : US1, v255 : US1, v256 : US1, v257 : US1, v258 : US1, v259 : US1, v260 : US1, v261 : US1, v262 : US9, v263 : US10, v264 : US9, v265 : US1, v266 : US1, v267 : US1, v268 : US1, v269 : US1, v270 : US1, v271 : US1, v272 : US1, v273 : US1, v274 : US1, v275 : US1, v276 : US1, v277 : US1, v278 : US1, v279 : US1, v280 : US8, v281 : US1, v282 : US1, v283 : US6, v284 : US1, v285 : US0, v286 : US1) = method4()
    let v287 : Mut2 = {l0 = v224; l1 = v225; l2 = v226; l3 = v227; l4 = v228; l5 = v229; l6 = v230; l7 = v231; l8 = v232; l9 = v233; l10 = v234; l11 = v235; l12 = v236; l13 = v237; l14 = v238; l15 = v239; l16 = v240; l17 = v241; l18 = v242; l19 = v243; l20 = v244; l21 = v245; l22 = v246; l23 = v247; l24 = v248; l25 = v249; l26 = v250; l27 = v251; l28 = v252; l29 = v253; l30 = v254; l31 = v255; l32 = v256; l33 = v257; l34 = v258; l35 = v259; l36 = v260; l37 = v261; l38 = v262; l39 = v263; l40 = v264; l41 = v265; l42 = v266; l43 = v267; l44 = v268; l45 = v269; l46 = v270; l47 = v271; l48 = v272; l49 = v273; l50 = v274; l51 = v275; l52 = v276; l53 = v277; l54 = v278; l55 = v279; l56 = v280; l57 = v281; l58 = v282; l59 = v283; l60 = v284; l61 = v285; l62 = v286} : Mut2
    let v288 : (unit -> JS.Function) = closure166()
    let v289 : Mut6 = {l0 = v141; l1 = v288; l2 = v141} : Mut6
    let v290 : obj = v289
    let v291 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v292 : JS.Function = import v71 v72
    let v293 : JSX.Element = v292.Invoke (v291, v290) |> unbox<JSX.Element>
    let v294 : US8 = US8_1(v293)
    v287.l29 <- v294
    let v295 : US1 = US1_1(v149)
    v287.l47 <- v295
    let v296 : (unit -> unit) = closure193()
    let v297 : US10 = US10_1(v296)
    v287.l39 <- v297
    let struct (v298 : US1, v299 : US1, v300 : US3, v301 : US1, v302 : US1, v303 : US1, v304 : US1, v305 : US1, v306 : US1, v307 : US4, v308 : US5, v309 : US1, v310 : US1, v311 : US4, v312 : US6, v313 : US1, v314 : US1, v315 : US1, v316 : US7, v317 : US4, v318 : US1, v319 : US1, v320 : US1, v321 : US1, v322 : US1, v323 : US8, v324 : US1, v325 : US1, v326 : US1, v327 : US8, v328 : US1, v329 : US1, v330 : US1, v331 : US1, v332 : US1, v333 : US1, v334 : US1, v335 : US1, v336 : US9, v337 : US10, v338 : US9, v339 : US1, v340 : US1, v341 : US1, v342 : US1, v343 : US1, v344 : US1, v345 : US1, v346 : US1, v347 : US1, v348 : US1, v349 : US1, v350 : US1, v351 : US1, v352 : US1, v353 : US1, v354 : US8, v355 : US1, v356 : US1, v357 : US6, v358 : US1, v359 : US0, v360 : US1) = v287.l0, v287.l1, v287.l2, v287.l3, v287.l4, v287.l5, v287.l6, v287.l7, v287.l8, v287.l9, v287.l10, v287.l11, v287.l12, v287.l13, v287.l14, v287.l15, v287.l16, v287.l17, v287.l18, v287.l19, v287.l20, v287.l21, v287.l22, v287.l23, v287.l24, v287.l25, v287.l26, v287.l27, v287.l28, v287.l29, v287.l30, v287.l31, v287.l32, v287.l33, v287.l34, v287.l35, v287.l36, v287.l37, v287.l38, v287.l39, v287.l40, v287.l41, v287.l42, v287.l43, v287.l44, v287.l45, v287.l46, v287.l47, v287.l48, v287.l49, v287.l50, v287.l51, v287.l52, v287.l53, v287.l54, v287.l55, v287.l56, v287.l57, v287.l58, v287.l59, v287.l60, v287.l61, v287.l62
    let v361 : (unit -> (JSX.Element [])) = closure194()
    let v362 : US5 = US5_1(v361)
    emitJsExpr (struct (v298, v299, v300, v301, v302, v303, v304, v305, v306, v307, v362, v309, v310, v311, v312, v313, v314, v315, v316, v317, v318, v319, v320, v321, v322, v323, v324, v325, v326, v327, v328, v329, v330, v331, v332, v333, v334, v335, v336, v337, v338, v339, v340, v341, v342, v343, v344, v345, v346, v347, v348, v349, v350, v351, v352, v353, v354, v355, v356, v357, v358, v359, v360), v361) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v363 : US5 = US5_1(v361)
    let v364 : Mut2 = {l0 = v298; l1 = v299; l2 = v300; l3 = v301; l4 = v302; l5 = v303; l6 = v304; l7 = v305; l8 = v306; l9 = v307; l10 = v363; l11 = v309; l12 = v310; l13 = v311; l14 = v312; l15 = v313; l16 = v314; l17 = v315; l18 = v316; l19 = v317; l20 = v318; l21 = v319; l22 = v320; l23 = v321; l24 = v322; l25 = v323; l26 = v324; l27 = v325; l28 = v326; l29 = v327; l30 = v328; l31 = v329; l32 = v330; l33 = v331; l34 = v332; l35 = v333; l36 = v334; l37 = v335; l38 = v336; l39 = v337; l40 = v338; l41 = v339; l42 = v340; l43 = v341; l44 = v342; l45 = v343; l46 = v344; l47 = v345; l48 = v346; l49 = v347; l50 = v348; l51 = v349; l52 = v350; l53 = v351; l54 = v352; l55 = v353; l56 = v354; l57 = v355; l58 = v356; l59 = v357; l60 = v358; l61 = v359; l62 = v360} : Mut2
    let v365 : obj = v364
    let v366 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v367 : JS.Function = import v71 v72
    let v368 : JSX.Element = v367.Invoke (v366, v365) |> unbox<JSX.Element>
    [|v74; v223; v368|]
and closure199 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : obj) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = Html.fragment [ v3 |> unbox<JSX.Element> ]
    [|v4|]
and closure198 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US1, v6 : US1, v7 : US3, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US4, v15 : US5, v16 : US1, v17 : US1, v18 : US4, v19 : US6, v20 : US1, v21 : US1, v22 : US1, v23 : US7, v24 : US4, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US8, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US9, v44 : US10, v45 : US9, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US8, v62 : US1, v63 : US1, v64 : US6, v65 : US1, v66 : US0, v67 : US1) = method4()
    let v68 : (unit -> (JSX.Element [])) = closure199(v0)
    let v69 : US5 = US5_1(v68)
    let v70 : ((string * obj) []) = method5(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v69, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
    let v71 : obj = createObj v70
    let v72 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v72, v71) |> unbox<JSX.Element>
    [|v76|]
and closure197 () (v0 : (unit -> struct (int32 * obj))) : (JSX.Element []) =
    let v1 : (Mut3 -> JSX.Element) = closure10()
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method4()
    let struct (v65 : int32, v66 : obj) = v0 ()
    let v67 : string = v65.ToString ()
    let v68 : JSX.Element = Html.fragment [ v67 |> unbox<JSX.Element> ]
    let v69 : (unit -> (JSX.Element [])) = closure198(v0)
    let v70 : US5 = US5_1(v69)
    let v71 : string = "3px"
    let v72 : US1 = US1_1(v71)
    let v73 : US8 = US8_1(v68)
    let v74 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v70; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v72; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v73; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    let v75 : US11 = US11_0
    let v76 : US12 = US12_2
    let v77 : Mut3 = {l0 = v75; l1 = v74; l2 = v76} : Mut3
    let v78 : obj = v77
    let v79 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v80 : string = "createComponent"
    let v81 : string = "solid-js"
    let v82 : JS.Function = import v80 v81
    let v83 : JSX.Element = v82.Invoke (v79, v78) |> unbox<JSX.Element>
    [|v83|]
and closure196 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (int32 * obj) []), v2 : (struct (int32 * obj) []), v3 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v4 : int32 = v1.Length
    let v5 : UH2 = UH2_1
    let v6 : Mut16 = {l0 = 0; l1 = v5} : Mut16
    while method22(v4, v6) do
        let v8 : int32 = v6.l0
        let v9 : int32 =  -v8
        let v10 : int32 = v9 + v4
        let v11 : int32 = v10 - 1
        let v12 : UH2 = v6.l1
        let struct (v13 : int32, v14 : obj) = v1.[int v11]
        let v15 : int32 = v8 + 1
        let v16 : UH2 = UH2_0(v13, v14, v12)
        v6.l0 <- v15
        v6.l1 <- v16
        ()
    let v17 : UH2 = v6.l1
    let v18 : UH2 = UH2_1
    let v19 : UH2 = method23(v17, v18)
    let v20 : (struct (int32 * obj) []) = method24(v19)
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : JS.Function = import v21 v22
    let v24 : ((unit -> struct (int32 * obj)) -> (JSX.Element [])) = closure197()
    let v25 : (unit -> (JSX.Element [])) = v24 |> unbox
    let struct (v26 : US1, v27 : US1, v28 : US3, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US4, v36 : US5, v37 : US1, v38 : US1, v39 : US4, v40 : US6, v41 : US1, v42 : US1, v43 : US1, v44 : US7, v45 : US4, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US8, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US9, v65 : US10, v66 : US9, v67 : US1, v68 : US1, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US1, v77 : US1, v78 : US1, v79 : US1, v80 : US1, v81 : US1, v82 : US8, v83 : US1, v84 : US1, v85 : US6, v86 : US1, v87 : US0, v88 : US1) = method4()
    let v90 : (struct (int32 * obj) []) = [||]
    let v91 : int32 = v20.Length
    let v92 : (obj []) = Array.zeroCreate<obj> (v91)
    let v93 : Mut5 = {l0 = 0} : Mut5
    while method12(v91, v93) do
        let v95 : int32 = v93.l0
        let struct (v96 : int32, v97 : obj) = v20.[int v95]
        let v98 : obj = struct (v96, v97)
        v92.[int v95] <- v98
        let v99 : int32 = v95 + 1
        v93.l0 <- v99
        ()
    let v100 : US5 = US5_1(v25)
    let v101 : US7 = US7_1(v92)
    let v102 : ((string * obj) []) = method5(v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v100, v37, v38, v39, v40, v41, v42, v43, v101, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88)
    let v103 : obj = createObj v102
    let v104 : (obj -> JSX.Element) = v23 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v105 : string = "createComponent"
    let v106 : JS.Function = import v105 v22
    let v107 : JSX.Element = v106.Invoke (v104, v103) |> unbox<JSX.Element>
    [|v107|]
and closure195 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : (Mut2 -> JSX.Element) = closure6()
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method4()
    let v65 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v12; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    let struct (v66 : US1, v67 : US1, v68 : US3, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US4, v76 : US5, v77 : US1, v78 : US1, v79 : US4, v80 : US6, v81 : US1, v82 : US1, v83 : US1, v84 : US7, v85 : US4, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US8, v92 : US1, v93 : US1, v94 : US1, v95 : US8, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US9, v105 : US10, v106 : US9, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US8, v123 : US1, v124 : US1, v125 : US6, v126 : US1, v127 : US0, v128 : US1) = v65.l0, v65.l1, v65.l2, v65.l3, v65.l4, v65.l5, v65.l6, v65.l7, v65.l8, v65.l9, v65.l10, v65.l11, v65.l12, v65.l13, v65.l14, v65.l15, v65.l16, v65.l17, v65.l18, v65.l19, v65.l20, v65.l21, v65.l22, v65.l23, v65.l24, v65.l25, v65.l26, v65.l27, v65.l28, v65.l29, v65.l30, v65.l31, v65.l32, v65.l33, v65.l34, v65.l35, v65.l36, v65.l37, v65.l38, v65.l39, v65.l40, v65.l41, v65.l42, v65.l43, v65.l44, v65.l45, v65.l46, v65.l47, v65.l48, v65.l49, v65.l50, v65.l51, v65.l52, v65.l53, v65.l54, v65.l55, v65.l56, v65.l57, v65.l58, v65.l59, v65.l60, v65.l61, v65.l62
    let v129 : (unit -> (JSX.Element [])) = closure196(v0)
    let v130 : US5 = US5_1(v129)
    emitJsExpr (struct (v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v130, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128), v129) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v131 : US5 = US5_1(v129)
    let v132 : Mut2 = {l0 = v66; l1 = v67; l2 = v68; l3 = v69; l4 = v70; l5 = v71; l6 = v72; l7 = v73; l8 = v74; l9 = v75; l10 = v131; l11 = v77; l12 = v78; l13 = v79; l14 = v80; l15 = v81; l16 = v82; l17 = v83; l18 = v84; l19 = v85; l20 = v86; l21 = v87; l22 = v88; l23 = v89; l24 = v90; l25 = v91; l26 = v92; l27 = v93; l28 = v94; l29 = v95; l30 = v96; l31 = v97; l32 = v98; l33 = v99; l34 = v100; l35 = v101; l36 = v102; l37 = v103; l38 = v104; l39 = v105; l40 = v106; l41 = v107; l42 = v108; l43 = v109; l44 = v110; l45 = v111; l46 = v112; l47 = v113; l48 = v114; l49 = v115; l50 = v116; l51 = v117; l52 = v118; l53 = v119; l54 = v120; l55 = v121; l56 = v122; l57 = v123; l58 = v124; l59 = v125; l60 = v126; l61 = v127; l62 = v128} : Mut2
    let v133 : obj = v132
    let v134 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v135 : string = "createComponent"
    let v136 : string = "solid-js"
    let v137 : JS.Function = import v135 v136
    let v138 : JSX.Element = v137.Invoke (v134, v133) |> unbox<JSX.Element>
    [|v138|]
and closure188 () (v0 : Mut2) : JSX.Element =
    let v1 : string = "useStoreon"
    let v2 : string = "@storeon/solidjs"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke () |> unbox<JS.Function[]>
    let v5 : Mut1 = v4.[0] |> unbox
    let v6 : JS.Function = v4.[1] |> unbox
    let v7 : (Mut3 -> JSX.Element) = closure10()
    let struct (v8 : US1, v9 : US1, v10 : US3, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US4, v18 : US5, v19 : US1, v20 : US1, v21 : US4, v22 : US6, v23 : US1, v24 : US1, v25 : US1, v26 : US7, v27 : US4, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US8, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US9, v47 : US10, v48 : US9, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US8, v65 : US1, v66 : US1, v67 : US6, v68 : US1, v69 : US0, v70 : US1) = method4()
    let v71 : string = "Stack"
    let v72 : string = "@hope-ui/solid"
    let v73 : JS.Function = import v71 v72
    let struct (v74 : US1, v75 : US1, v76 : US3, v77 : US1, v78 : US1, v79 : US1, v80 : US1, v81 : US1, v82 : US1, v83 : US4, v84 : US5, v85 : US1, v86 : US1, v87 : US4, v88 : US6, v89 : US1, v90 : US1, v91 : US1, v92 : US7, v93 : US4, v94 : US1, v95 : US1, v96 : US1, v97 : US1, v98 : US1, v99 : US8, v100 : US1, v101 : US1, v102 : US1, v103 : US8, v104 : US1, v105 : US1, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US9, v113 : US10, v114 : US9, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US8, v131 : US1, v132 : US1, v133 : US6, v134 : US1, v135 : US0, v136 : US1) = method4()
    let v137 : string = "row"
    let v138 : string = "column"
    let v139 : string = method10(v138, v137)
    let v140 : string = "0"
    let v141 : string = "8px"
    let v142 : string = method10(v141, v140)
    let v143 : string = "start"
    let v144 : US1 = US1_1(v143)
    let v145 : (unit -> (JSX.Element [])) = closure189()
    let v146 : US5 = US5_1(v145)
    let v147 : US1 = US1_1(v139)
    let v148 : US1 = US1_1(v142)
    let v149 : string = "3px"
    let v150 : US1 = US1_1(v149)
    let v151 : string = "7px"
    let v152 : US1 = US1_1(v151)
    let v153 : ((string * obj) []) = method5(v144, v75, v76, v77, v78, v79, v80, v81, v82, v83, v146, v85, v86, v87, v88, v89, v147, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v148, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v150, v119, v120, v121, v122, v123, v124, v125, v152, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136)
    let v154 : obj = createObj v153
    let v155 : (obj -> JSX.Element) = v73 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v156 : string = "createComponent"
    let v157 : string = "solid-js"
    let v158 : JS.Function = import v156 v157
    let v159 : JSX.Element = v158.Invoke (v155, v154) |> unbox<JSX.Element>
    let v160 : (unit -> (JSX.Element [])) = closure195(v5)
    let v161 : US5 = US5_1(v160)
    let v162 : string = "deploy"
    let v163 : US1 = US1_1(v162)
    let v164 : US8 = US8_1(v159)
    let v165 : Mut2 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v161; l11 = v19; l12 = v20; l13 = v21; l14 = v22; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v163; l27 = v35; l28 = v36; l29 = v37; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50; l43 = v51; l44 = v52; l45 = v53; l46 = v54; l47 = v55; l48 = v56; l49 = v57; l50 = v58; l51 = v59; l52 = v60; l53 = v61; l54 = v62; l55 = v63; l56 = v164; l57 = v65; l58 = v66; l59 = v67; l60 = v68; l61 = v69; l62 = v70} : Mut2
    let v166 : US11 = US11_0
    let v167 : US12 = US12_2
    let v168 : Mut3 = {l0 = v166; l1 = v165; l2 = v167} : Mut3
    let v169 : obj = v168
    let v170 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v171 : JS.Function = import v156 v157
    let v172 : JSX.Element = v171.Invoke (v170, v169) |> unbox<JSX.Element>
    v172
and closure200 () () : (JSX.Element []) =
    [||]
and closure159 (v0 : obj, v1 : string, v2 : bool) () : (JSX.Element []) =
    let v3 : (Mut2 -> JSX.Element) = closure160()
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method4()
    let v67 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65; l62 = v66} : Mut2
    let struct (v68 : US1, v69 : US1, v70 : US3, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US1, v77 : US4, v78 : US5, v79 : US1, v80 : US1, v81 : US4, v82 : US6, v83 : US1, v84 : US1, v85 : US1, v86 : US7, v87 : US4, v88 : US1, v89 : US1, v90 : US1, v91 : US1, v92 : US1, v93 : US8, v94 : US1, v95 : US1, v96 : US1, v97 : US8, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US1, v105 : US1, v106 : US9, v107 : US10, v108 : US9, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US8, v125 : US1, v126 : US1, v127 : US6, v128 : US1, v129 : US0, v130 : US1) = v67.l0, v67.l1, v67.l2, v67.l3, v67.l4, v67.l5, v67.l6, v67.l7, v67.l8, v67.l9, v67.l10, v67.l11, v67.l12, v67.l13, v67.l14, v67.l15, v67.l16, v67.l17, v67.l18, v67.l19, v67.l20, v67.l21, v67.l22, v67.l23, v67.l24, v67.l25, v67.l26, v67.l27, v67.l28, v67.l29, v67.l30, v67.l31, v67.l32, v67.l33, v67.l34, v67.l35, v67.l36, v67.l37, v67.l38, v67.l39, v67.l40, v67.l41, v67.l42, v67.l43, v67.l44, v67.l45, v67.l46, v67.l47, v67.l48, v67.l49, v67.l50, v67.l51, v67.l52, v67.l53, v67.l54, v67.l55, v67.l56, v67.l57, v67.l58, v67.l59, v67.l60, v67.l61, v67.l62
    let v131 : (unit -> (JSX.Element [])) = closure174()
    let v132 : US5 = US5_1(v131)
    emitJsExpr (struct (v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v132, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130), v131) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v133 : US5 = US5_1(v131)
    let v134 : Mut2 = {l0 = v68; l1 = v69; l2 = v70; l3 = v71; l4 = v72; l5 = v73; l6 = v74; l7 = v75; l8 = v76; l9 = v77; l10 = v133; l11 = v79; l12 = v80; l13 = v81; l14 = v82; l15 = v83; l16 = v84; l17 = v85; l18 = v86; l19 = v87; l20 = v88; l21 = v89; l22 = v90; l23 = v91; l24 = v92; l25 = v93; l26 = v94; l27 = v95; l28 = v96; l29 = v97; l30 = v98; l31 = v99; l32 = v100; l33 = v101; l34 = v102; l35 = v103; l36 = v104; l37 = v105; l38 = v106; l39 = v107; l40 = v108; l41 = v109; l42 = v110; l43 = v111; l44 = v112; l45 = v113; l46 = v114; l47 = v115; l48 = v116; l49 = v117; l50 = v118; l51 = v119; l52 = v120; l53 = v121; l54 = v122; l55 = v123; l56 = v124; l57 = v125; l58 = v126; l59 = v127; l60 = v128; l61 = v129; l62 = v130} : Mut2
    let v135 : obj = v134
    let v136 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v137 : string = "createComponent"
    let v138 : string = "solid-js"
    let v139 : JS.Function = import v137 v138
    let v140 : JSX.Element = v139.Invoke (v136, v135) |> unbox<JSX.Element>
    let v141 : (Mut2 -> JSX.Element) = closure175()
    let struct (v142 : US1, v143 : US1, v144 : US3, v145 : US1, v146 : US1, v147 : US1, v148 : US1, v149 : US1, v150 : US1, v151 : US4, v152 : US5, v153 : US1, v154 : US1, v155 : US4, v156 : US6, v157 : US1, v158 : US1, v159 : US1, v160 : US7, v161 : US4, v162 : US1, v163 : US1, v164 : US1, v165 : US1, v166 : US1, v167 : US8, v168 : US1, v169 : US1, v170 : US1, v171 : US8, v172 : US1, v173 : US1, v174 : US1, v175 : US1, v176 : US1, v177 : US1, v178 : US1, v179 : US1, v180 : US9, v181 : US10, v182 : US9, v183 : US1, v184 : US1, v185 : US1, v186 : US1, v187 : US1, v188 : US1, v189 : US1, v190 : US1, v191 : US1, v192 : US1, v193 : US1, v194 : US1, v195 : US1, v196 : US1, v197 : US1, v198 : US8, v199 : US1, v200 : US1, v201 : US6, v202 : US1, v203 : US0, v204 : US1) = method4()
    let v205 : Mut2 = {l0 = v142; l1 = v143; l2 = v144; l3 = v145; l4 = v146; l5 = v147; l6 = v148; l7 = v149; l8 = v150; l9 = v151; l10 = v152; l11 = v153; l12 = v154; l13 = v155; l14 = v156; l15 = v157; l16 = v158; l17 = v159; l18 = v160; l19 = v161; l20 = v162; l21 = v163; l22 = v164; l23 = v165; l24 = v166; l25 = v167; l26 = v168; l27 = v169; l28 = v170; l29 = v171; l30 = v172; l31 = v173; l32 = v174; l33 = v175; l34 = v176; l35 = v177; l36 = v178; l37 = v179; l38 = v180; l39 = v181; l40 = v182; l41 = v183; l42 = v184; l43 = v185; l44 = v186; l45 = v187; l46 = v188; l47 = v189; l48 = v190; l49 = v191; l50 = v192; l51 = v193; l52 = v194; l53 = v195; l54 = v196; l55 = v197; l56 = v198; l57 = v199; l58 = v200; l59 = v201; l60 = v202; l61 = v203; l62 = v204} : Mut2
    let struct (v206 : US1, v207 : US1, v208 : US3, v209 : US1, v210 : US1, v211 : US1, v212 : US1, v213 : US1, v214 : US1, v215 : US4, v216 : US5, v217 : US1, v218 : US1, v219 : US4, v220 : US6, v221 : US1, v222 : US1, v223 : US1, v224 : US7, v225 : US4, v226 : US1, v227 : US1, v228 : US1, v229 : US1, v230 : US1, v231 : US8, v232 : US1, v233 : US1, v234 : US1, v235 : US8, v236 : US1, v237 : US1, v238 : US1, v239 : US1, v240 : US1, v241 : US1, v242 : US1, v243 : US1, v244 : US9, v245 : US10, v246 : US9, v247 : US1, v248 : US1, v249 : US1, v250 : US1, v251 : US1, v252 : US1, v253 : US1, v254 : US1, v255 : US1, v256 : US1, v257 : US1, v258 : US1, v259 : US1, v260 : US1, v261 : US1, v262 : US8, v263 : US1, v264 : US1, v265 : US6, v266 : US1, v267 : US0, v268 : US1) = v205.l0, v205.l1, v205.l2, v205.l3, v205.l4, v205.l5, v205.l6, v205.l7, v205.l8, v205.l9, v205.l10, v205.l11, v205.l12, v205.l13, v205.l14, v205.l15, v205.l16, v205.l17, v205.l18, v205.l19, v205.l20, v205.l21, v205.l22, v205.l23, v205.l24, v205.l25, v205.l26, v205.l27, v205.l28, v205.l29, v205.l30, v205.l31, v205.l32, v205.l33, v205.l34, v205.l35, v205.l36, v205.l37, v205.l38, v205.l39, v205.l40, v205.l41, v205.l42, v205.l43, v205.l44, v205.l45, v205.l46, v205.l47, v205.l48, v205.l49, v205.l50, v205.l51, v205.l52, v205.l53, v205.l54, v205.l55, v205.l56, v205.l57, v205.l58, v205.l59, v205.l60, v205.l61, v205.l62
    let v269 : (unit -> (JSX.Element [])) = closure187()
    let v270 : US5 = US5_1(v269)
    emitJsExpr (struct (v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v270, v217, v218, v219, v220, v221, v222, v223, v224, v225, v226, v227, v228, v229, v230, v231, v232, v233, v234, v235, v236, v237, v238, v239, v240, v241, v242, v243, v244, v245, v246, v247, v248, v249, v250, v251, v252, v253, v254, v255, v256, v257, v258, v259, v260, v261, v262, v263, v264, v265, v266, v267, v268), v269) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v271 : US5 = US5_1(v269)
    let v272 : Mut2 = {l0 = v206; l1 = v207; l2 = v208; l3 = v209; l4 = v210; l5 = v211; l6 = v212; l7 = v213; l8 = v214; l9 = v215; l10 = v271; l11 = v217; l12 = v218; l13 = v219; l14 = v220; l15 = v221; l16 = v222; l17 = v223; l18 = v224; l19 = v225; l20 = v226; l21 = v227; l22 = v228; l23 = v229; l24 = v230; l25 = v231; l26 = v232; l27 = v233; l28 = v234; l29 = v235; l30 = v236; l31 = v237; l32 = v238; l33 = v239; l34 = v240; l35 = v241; l36 = v242; l37 = v243; l38 = v244; l39 = v245; l40 = v246; l41 = v247; l42 = v248; l43 = v249; l44 = v250; l45 = v251; l46 = v252; l47 = v253; l48 = v254; l49 = v255; l50 = v256; l51 = v257; l52 = v258; l53 = v259; l54 = v260; l55 = v261; l56 = v262; l57 = v263; l58 = v264; l59 = v265; l60 = v266; l61 = v267; l62 = v268} : Mut2
    let v273 : obj = v272
    let v274 : (obj -> JSX.Element) = v141 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v275 : JS.Function = import v137 v138
    let v276 : JSX.Element = v275.Invoke (v274, v273) |> unbox<JSX.Element>
    let v278 : bool = v1 = ""
    let v279 : bool = v278 <> true
    let v281 : JSX.Element =
        if v279 then
            v276
        else
            let v280 : JSX.Element = Html.fragment []
            v280
    let v282 : (Mut2 -> JSX.Element) = closure188()
    let struct (v283 : US1, v284 : US1, v285 : US3, v286 : US1, v287 : US1, v288 : US1, v289 : US1, v290 : US1, v291 : US1, v292 : US4, v293 : US5, v294 : US1, v295 : US1, v296 : US4, v297 : US6, v298 : US1, v299 : US1, v300 : US1, v301 : US7, v302 : US4, v303 : US1, v304 : US1, v305 : US1, v306 : US1, v307 : US1, v308 : US8, v309 : US1, v310 : US1, v311 : US1, v312 : US8, v313 : US1, v314 : US1, v315 : US1, v316 : US1, v317 : US1, v318 : US1, v319 : US1, v320 : US1, v321 : US9, v322 : US10, v323 : US9, v324 : US1, v325 : US1, v326 : US1, v327 : US1, v328 : US1, v329 : US1, v330 : US1, v331 : US1, v332 : US1, v333 : US1, v334 : US1, v335 : US1, v336 : US1, v337 : US1, v338 : US1, v339 : US8, v340 : US1, v341 : US1, v342 : US6, v343 : US1, v344 : US0, v345 : US1) = method4()
    let v346 : Mut2 = {l0 = v283; l1 = v284; l2 = v285; l3 = v286; l4 = v287; l5 = v288; l6 = v289; l7 = v290; l8 = v291; l9 = v292; l10 = v293; l11 = v294; l12 = v295; l13 = v296; l14 = v297; l15 = v298; l16 = v299; l17 = v300; l18 = v301; l19 = v302; l20 = v303; l21 = v304; l22 = v305; l23 = v306; l24 = v307; l25 = v308; l26 = v309; l27 = v310; l28 = v311; l29 = v312; l30 = v313; l31 = v314; l32 = v315; l33 = v316; l34 = v317; l35 = v318; l36 = v319; l37 = v320; l38 = v321; l39 = v322; l40 = v323; l41 = v324; l42 = v325; l43 = v326; l44 = v327; l45 = v328; l46 = v329; l47 = v330; l48 = v331; l49 = v332; l50 = v333; l51 = v334; l52 = v335; l53 = v336; l54 = v337; l55 = v338; l56 = v339; l57 = v340; l58 = v341; l59 = v342; l60 = v343; l61 = v344; l62 = v345} : Mut2
    let struct (v347 : US1, v348 : US1, v349 : US3, v350 : US1, v351 : US1, v352 : US1, v353 : US1, v354 : US1, v355 : US1, v356 : US4, v357 : US5, v358 : US1, v359 : US1, v360 : US4, v361 : US6, v362 : US1, v363 : US1, v364 : US1, v365 : US7, v366 : US4, v367 : US1, v368 : US1, v369 : US1, v370 : US1, v371 : US1, v372 : US8, v373 : US1, v374 : US1, v375 : US1, v376 : US8, v377 : US1, v378 : US1, v379 : US1, v380 : US1, v381 : US1, v382 : US1, v383 : US1, v384 : US1, v385 : US9, v386 : US10, v387 : US9, v388 : US1, v389 : US1, v390 : US1, v391 : US1, v392 : US1, v393 : US1, v394 : US1, v395 : US1, v396 : US1, v397 : US1, v398 : US1, v399 : US1, v400 : US1, v401 : US1, v402 : US1, v403 : US8, v404 : US1, v405 : US1, v406 : US6, v407 : US1, v408 : US0, v409 : US1) = v346.l0, v346.l1, v346.l2, v346.l3, v346.l4, v346.l5, v346.l6, v346.l7, v346.l8, v346.l9, v346.l10, v346.l11, v346.l12, v346.l13, v346.l14, v346.l15, v346.l16, v346.l17, v346.l18, v346.l19, v346.l20, v346.l21, v346.l22, v346.l23, v346.l24, v346.l25, v346.l26, v346.l27, v346.l28, v346.l29, v346.l30, v346.l31, v346.l32, v346.l33, v346.l34, v346.l35, v346.l36, v346.l37, v346.l38, v346.l39, v346.l40, v346.l41, v346.l42, v346.l43, v346.l44, v346.l45, v346.l46, v346.l47, v346.l48, v346.l49, v346.l50, v346.l51, v346.l52, v346.l53, v346.l54, v346.l55, v346.l56, v346.l57, v346.l58, v346.l59, v346.l60, v346.l61, v346.l62
    let v410 : (unit -> (JSX.Element [])) = closure200()
    let v411 : US5 = US5_1(v410)
    emitJsExpr (struct (v347, v348, v349, v350, v351, v352, v353, v354, v355, v356, v411, v358, v359, v360, v361, v362, v363, v364, v365, v366, v367, v368, v369, v370, v371, v372, v373, v374, v375, v376, v377, v378, v379, v380, v381, v382, v383, v384, v385, v386, v387, v388, v389, v390, v391, v392, v393, v394, v395, v396, v397, v398, v399, v400, v401, v402, v403, v404, v405, v406, v407, v408, v409), v410) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v412 : US5 = US5_1(v410)
    let v413 : Mut2 = {l0 = v347; l1 = v348; l2 = v349; l3 = v350; l4 = v351; l5 = v352; l6 = v353; l7 = v354; l8 = v355; l9 = v356; l10 = v412; l11 = v358; l12 = v359; l13 = v360; l14 = v361; l15 = v362; l16 = v363; l17 = v364; l18 = v365; l19 = v366; l20 = v367; l21 = v368; l22 = v369; l23 = v370; l24 = v371; l25 = v372; l26 = v373; l27 = v374; l28 = v375; l29 = v376; l30 = v377; l31 = v378; l32 = v379; l33 = v380; l34 = v381; l35 = v382; l36 = v383; l37 = v384; l38 = v385; l39 = v386; l40 = v387; l41 = v388; l42 = v389; l43 = v390; l44 = v391; l45 = v392; l46 = v393; l47 = v394; l48 = v395; l49 = v396; l50 = v397; l51 = v398; l52 = v399; l53 = v400; l54 = v401; l55 = v402; l56 = v403; l57 = v404; l58 = v405; l59 = v406; l60 = v407; l61 = v408; l62 = v409} : Mut2
    let v414 : obj = v413
    let v415 : (obj -> JSX.Element) = v282 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v416 : JS.Function = import v137 v138
    let v417 : JSX.Element = v416.Invoke (v415, v414) |> unbox<JSX.Element>
    let v420 : JSX.Element =
        if v279 then
            v417
        else
            let v419 : JSX.Element = Html.fragment []
            v419
    [|v140; v281; v420|]
and closure158 (v0 : obj, v1 : string, v2 : bool) () : (JSX.Element []) =
    let v3 : (Mut2 -> JSX.Element) = closure6()
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method4()
    let v67 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65; l62 = v66} : Mut2
    let struct (v68 : US1, v69 : US1, v70 : US3, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US1, v77 : US4, v78 : US5, v79 : US1, v80 : US1, v81 : US4, v82 : US6, v83 : US1, v84 : US1, v85 : US1, v86 : US7, v87 : US4, v88 : US1, v89 : US1, v90 : US1, v91 : US1, v92 : US1, v93 : US8, v94 : US1, v95 : US1, v96 : US1, v97 : US8, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US1, v105 : US1, v106 : US9, v107 : US10, v108 : US9, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US8, v125 : US1, v126 : US1, v127 : US6, v128 : US1, v129 : US0, v130 : US1) = v67.l0, v67.l1, v67.l2, v67.l3, v67.l4, v67.l5, v67.l6, v67.l7, v67.l8, v67.l9, v67.l10, v67.l11, v67.l12, v67.l13, v67.l14, v67.l15, v67.l16, v67.l17, v67.l18, v67.l19, v67.l20, v67.l21, v67.l22, v67.l23, v67.l24, v67.l25, v67.l26, v67.l27, v67.l28, v67.l29, v67.l30, v67.l31, v67.l32, v67.l33, v67.l34, v67.l35, v67.l36, v67.l37, v67.l38, v67.l39, v67.l40, v67.l41, v67.l42, v67.l43, v67.l44, v67.l45, v67.l46, v67.l47, v67.l48, v67.l49, v67.l50, v67.l51, v67.l52, v67.l53, v67.l54, v67.l55, v67.l56, v67.l57, v67.l58, v67.l59, v67.l60, v67.l61, v67.l62
    let v131 : (unit -> (JSX.Element [])) = closure159(v0, v1, v2)
    let v132 : US5 = US5_1(v131)
    emitJsExpr (struct (v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v132, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130), v131) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v133 : US5 = US5_1(v131)
    let v134 : Mut2 = {l0 = v68; l1 = v69; l2 = v70; l3 = v71; l4 = v72; l5 = v73; l6 = v74; l7 = v75; l8 = v76; l9 = v77; l10 = v133; l11 = v79; l12 = v80; l13 = v81; l14 = v82; l15 = v83; l16 = v84; l17 = v85; l18 = v86; l19 = v87; l20 = v88; l21 = v89; l22 = v90; l23 = v91; l24 = v92; l25 = v93; l26 = v94; l27 = v95; l28 = v96; l29 = v97; l30 = v98; l31 = v99; l32 = v100; l33 = v101; l34 = v102; l35 = v103; l36 = v104; l37 = v105; l38 = v106; l39 = v107; l40 = v108; l41 = v109; l42 = v110; l43 = v111; l44 = v112; l45 = v113; l46 = v114; l47 = v115; l48 = v116; l49 = v117; l50 = v118; l51 = v119; l52 = v120; l53 = v121; l54 = v122; l55 = v123; l56 = v124; l57 = v125; l58 = v126; l59 = v127; l60 = v128; l61 = v129; l62 = v130} : Mut2
    let v135 : obj = v134
    let v136 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v137 : string = "createComponent"
    let v138 : string = "solid-js"
    let v139 : JS.Function = import v137 v138
    let v140 : JSX.Element = v139.Invoke (v136, v135) |> unbox<JSX.Element>
    [|v140|]
and closure9 (v0 : obj, v1 : string, v2 : bool) () : (JSX.Element []) =
    let v3 : (Mut3 -> JSX.Element) = closure10()
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method4()
    let v67 : string = "Links"
    let v68 : JSX.Element = Html.fragment [ v67 |> unbox<JSX.Element> ]
    let v69 : (unit -> (JSX.Element [])) = closure44()
    let v70 : US5 = US5_1(v69)
    let v71 : US8 = US8_1(v68)
    let v72 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v70; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v71; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65; l62 = v66} : Mut2
    let v73 : US11 = US11_0
    let v74 : US12 = US12_2
    let v75 : Mut3 = {l0 = v73; l1 = v72; l2 = v74} : Mut3
    let v76 : obj = v75
    let v77 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v78 : string = "createComponent"
    let v79 : string = "solid-js"
    let v80 : JS.Function = import v78 v79
    let v81 : JSX.Element = v80.Invoke (v77, v76) |> unbox<JSX.Element>
    let struct (v82 : US1, v83 : US1, v84 : US3, v85 : US1, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US4, v92 : US5, v93 : US1, v94 : US1, v95 : US4, v96 : US6, v97 : US1, v98 : US1, v99 : US1, v100 : US7, v101 : US4, v102 : US1, v103 : US1, v104 : US1, v105 : US1, v106 : US1, v107 : US8, v108 : US1, v109 : US1, v110 : US1, v111 : US8, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US9, v121 : US10, v122 : US9, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US1, v136 : US1, v137 : US1, v138 : US8, v139 : US1, v140 : US1, v141 : US6, v142 : US1, v143 : US0, v144 : US1) = method4()
    let v145 : Mut2 = {l0 = v82; l1 = v83; l2 = v84; l3 = v85; l4 = v86; l5 = v87; l6 = v88; l7 = v89; l8 = v90; l9 = v91; l10 = v92; l11 = v93; l12 = v94; l13 = v95; l14 = v96; l15 = v97; l16 = v98; l17 = v99; l18 = v100; l19 = v101; l20 = v102; l21 = v103; l22 = v104; l23 = v105; l24 = v106; l25 = v107; l26 = v108; l27 = v109; l28 = v110; l29 = v111; l30 = v112; l31 = v113; l32 = v114; l33 = v115; l34 = v116; l35 = v117; l36 = v118; l37 = v119; l38 = v120; l39 = v121; l40 = v122; l41 = v123; l42 = v124; l43 = v125; l44 = v126; l45 = v127; l46 = v128; l47 = v129; l48 = v130; l49 = v131; l50 = v132; l51 = v133; l52 = v134; l53 = v135; l54 = v136; l55 = v137; l56 = v138; l57 = v139; l58 = v140; l59 = v141; l60 = v142; l61 = v143; l62 = v144} : Mut2
    let v146 : US11 = US11_0
    let v147 : US12 = US12_2
    let v148 : Mut3 = {l0 = v146; l1 = v145; l2 = v147} : Mut3
    let v149 : obj = v148
    let v150 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v151 : JS.Function = import v78 v79
    let v152 : JSX.Element = v151.Invoke (v150, v149) |> unbox<JSX.Element>
    let struct (v153 : US1, v154 : US1, v155 : US3, v156 : US1, v157 : US1, v158 : US1, v159 : US1, v160 : US1, v161 : US1, v162 : US4, v163 : US5, v164 : US1, v165 : US1, v166 : US4, v167 : US6, v168 : US1, v169 : US1, v170 : US1, v171 : US7, v172 : US4, v173 : US1, v174 : US1, v175 : US1, v176 : US1, v177 : US1, v178 : US8, v179 : US1, v180 : US1, v181 : US1, v182 : US8, v183 : US1, v184 : US1, v185 : US1, v186 : US1, v187 : US1, v188 : US1, v189 : US1, v190 : US1, v191 : US9, v192 : US10, v193 : US9, v194 : US1, v195 : US1, v196 : US1, v197 : US1, v198 : US1, v199 : US1, v200 : US1, v201 : US1, v202 : US1, v203 : US1, v204 : US1, v205 : US1, v206 : US1, v207 : US1, v208 : US1, v209 : US8, v210 : US1, v211 : US1, v212 : US6, v213 : US1, v214 : US0, v215 : US1) = method4()
    let v216 : string = "Settings"
    let v217 : JSX.Element = Html.fragment [ v216 |> unbox<JSX.Element> ]
    let v218 : (unit -> (JSX.Element [])) = closure57()
    let v219 : US5 = US5_1(v218)
    let v220 : US8 = US8_1(v217)
    let v221 : Mut2 = {l0 = v153; l1 = v154; l2 = v155; l3 = v156; l4 = v157; l5 = v158; l6 = v159; l7 = v160; l8 = v161; l9 = v162; l10 = v219; l11 = v164; l12 = v165; l13 = v166; l14 = v167; l15 = v168; l16 = v169; l17 = v170; l18 = v171; l19 = v172; l20 = v173; l21 = v174; l22 = v175; l23 = v176; l24 = v177; l25 = v178; l26 = v179; l27 = v180; l28 = v181; l29 = v182; l30 = v183; l31 = v184; l32 = v185; l33 = v186; l34 = v187; l35 = v188; l36 = v189; l37 = v190; l38 = v191; l39 = v192; l40 = v193; l41 = v194; l42 = v195; l43 = v196; l44 = v197; l45 = v198; l46 = v199; l47 = v200; l48 = v201; l49 = v202; l50 = v203; l51 = v204; l52 = v205; l53 = v206; l54 = v207; l55 = v208; l56 = v220; l57 = v210; l58 = v211; l59 = v212; l60 = v213; l61 = v214; l62 = v215} : Mut2
    let v222 : US11 = US11_0
    let v223 : US12 = US12_2
    let v224 : Mut3 = {l0 = v222; l1 = v221; l2 = v223} : Mut3
    let v225 : obj = v224
    let v226 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v227 : JS.Function = import v78 v79
    let v228 : JSX.Element = v227.Invoke (v226, v225) |> unbox<JSX.Element>
    let struct (v229 : US1, v230 : US1, v231 : US3, v232 : US1, v233 : US1, v234 : US1, v235 : US1, v236 : US1, v237 : US1, v238 : US4, v239 : US5, v240 : US1, v241 : US1, v242 : US4, v243 : US6, v244 : US1, v245 : US1, v246 : US1, v247 : US7, v248 : US4, v249 : US1, v250 : US1, v251 : US1, v252 : US1, v253 : US1, v254 : US8, v255 : US1, v256 : US1, v257 : US1, v258 : US8, v259 : US1, v260 : US1, v261 : US1, v262 : US1, v263 : US1, v264 : US1, v265 : US1, v266 : US1, v267 : US9, v268 : US10, v269 : US9, v270 : US1, v271 : US1, v272 : US1, v273 : US1, v274 : US1, v275 : US1, v276 : US1, v277 : US1, v278 : US1, v279 : US1, v280 : US1, v281 : US1, v282 : US1, v283 : US1, v284 : US1, v285 : US8, v286 : US1, v287 : US1, v288 : US6, v289 : US1, v290 : US0, v291 : US1) = method4()
    let v292 : Mut2 = {l0 = v229; l1 = v230; l2 = v231; l3 = v232; l4 = v233; l5 = v234; l6 = v235; l7 = v236; l8 = v237; l9 = v238; l10 = v239; l11 = v240; l12 = v241; l13 = v242; l14 = v243; l15 = v244; l16 = v245; l17 = v246; l18 = v247; l19 = v248; l20 = v249; l21 = v250; l22 = v251; l23 = v252; l24 = v253; l25 = v254; l26 = v255; l27 = v256; l28 = v257; l29 = v258; l30 = v259; l31 = v260; l32 = v261; l33 = v262; l34 = v263; l35 = v264; l36 = v265; l37 = v266; l38 = v267; l39 = v268; l40 = v269; l41 = v270; l42 = v271; l43 = v272; l44 = v273; l45 = v274; l46 = v275; l47 = v276; l48 = v277; l49 = v278; l50 = v279; l51 = v280; l52 = v281; l53 = v282; l54 = v283; l55 = v284; l56 = v285; l57 = v286; l58 = v287; l59 = v288; l60 = v289; l61 = v290; l62 = v291} : Mut2
    let v293 : US11 = US11_0
    let v294 : US12 = US12_2
    let v295 : Mut3 = {l0 = v293; l1 = v292; l2 = v294} : Mut3
    let v296 : obj = v295
    let v297 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v298 : JS.Function = import v78 v79
    let v299 : JSX.Element = v298.Invoke (v297, v296) |> unbox<JSX.Element>
    let struct (v300 : US1, v301 : US1, v302 : US3, v303 : US1, v304 : US1, v305 : US1, v306 : US1, v307 : US1, v308 : US1, v309 : US4, v310 : US5, v311 : US1, v312 : US1, v313 : US4, v314 : US6, v315 : US1, v316 : US1, v317 : US1, v318 : US7, v319 : US4, v320 : US1, v321 : US1, v322 : US1, v323 : US1, v324 : US1, v325 : US8, v326 : US1, v327 : US1, v328 : US1, v329 : US8, v330 : US1, v331 : US1, v332 : US1, v333 : US1, v334 : US1, v335 : US1, v336 : US1, v337 : US1, v338 : US9, v339 : US10, v340 : US9, v341 : US1, v342 : US1, v343 : US1, v344 : US1, v345 : US1, v346 : US1, v347 : US1, v348 : US1, v349 : US1, v350 : US1, v351 : US1, v352 : US1, v353 : US1, v354 : US1, v355 : US1, v356 : US8, v357 : US1, v358 : US1, v359 : US6, v360 : US1, v361 : US0, v362 : US1) = method4()
    let v363 : string = "Chain"
    let v364 : JSX.Element = Html.fragment [ v363 |> unbox<JSX.Element> ]
    let v365 : (unit -> (JSX.Element [])) = closure67()
    let v366 : US5 = US5_1(v365)
    let v367 : string = "db"
    let v368 : US1 = US1_1(v367)
    let v369 : US8 = US8_1(v364)
    let v370 : Mut2 = {l0 = v300; l1 = v301; l2 = v302; l3 = v303; l4 = v304; l5 = v305; l6 = v306; l7 = v307; l8 = v308; l9 = v309; l10 = v366; l11 = v311; l12 = v312; l13 = v313; l14 = v314; l15 = v315; l16 = v316; l17 = v317; l18 = v318; l19 = v319; l20 = v320; l21 = v321; l22 = v322; l23 = v323; l24 = v324; l25 = v325; l26 = v368; l27 = v327; l28 = v328; l29 = v329; l30 = v330; l31 = v331; l32 = v332; l33 = v333; l34 = v334; l35 = v335; l36 = v336; l37 = v337; l38 = v338; l39 = v339; l40 = v340; l41 = v341; l42 = v342; l43 = v343; l44 = v344; l45 = v345; l46 = v346; l47 = v347; l48 = v348; l49 = v349; l50 = v350; l51 = v351; l52 = v352; l53 = v353; l54 = v354; l55 = v355; l56 = v369; l57 = v357; l58 = v358; l59 = v359; l60 = v360; l61 = v361; l62 = v362} : Mut2
    let v371 : US11 = US11_0
    let v372 : US12 = US12_0
    let v373 : Mut3 = {l0 = v371; l1 = v370; l2 = v372} : Mut3
    let v374 : obj = v373
    let v375 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v376 : JS.Function = import v78 v79
    let v377 : JSX.Element = v376.Invoke (v375, v374) |> unbox<JSX.Element>
    let struct (v378 : US1, v379 : US1, v380 : US3, v381 : US1, v382 : US1, v383 : US1, v384 : US1, v385 : US1, v386 : US1, v387 : US4, v388 : US5, v389 : US1, v390 : US1, v391 : US4, v392 : US6, v393 : US1, v394 : US1, v395 : US1, v396 : US7, v397 : US4, v398 : US1, v399 : US1, v400 : US1, v401 : US1, v402 : US1, v403 : US8, v404 : US1, v405 : US1, v406 : US1, v407 : US8, v408 : US1, v409 : US1, v410 : US1, v411 : US1, v412 : US1, v413 : US1, v414 : US1, v415 : US1, v416 : US9, v417 : US10, v418 : US9, v419 : US1, v420 : US1, v421 : US1, v422 : US1, v423 : US1, v424 : US1, v425 : US1, v426 : US1, v427 : US1, v428 : US1, v429 : US1, v430 : US1, v431 : US1, v432 : US1, v433 : US1, v434 : US8, v435 : US1, v436 : US1, v437 : US6, v438 : US1, v439 : US0, v440 : US1) = method4()
    let v441 : Mut2 = {l0 = v378; l1 = v379; l2 = v380; l3 = v381; l4 = v382; l5 = v383; l6 = v384; l7 = v385; l8 = v386; l9 = v387; l10 = v388; l11 = v389; l12 = v390; l13 = v391; l14 = v392; l15 = v393; l16 = v394; l17 = v395; l18 = v396; l19 = v397; l20 = v398; l21 = v399; l22 = v400; l23 = v401; l24 = v402; l25 = v403; l26 = v404; l27 = v405; l28 = v406; l29 = v407; l30 = v408; l31 = v409; l32 = v410; l33 = v411; l34 = v412; l35 = v413; l36 = v414; l37 = v415; l38 = v416; l39 = v417; l40 = v418; l41 = v419; l42 = v420; l43 = v421; l44 = v422; l45 = v423; l46 = v424; l47 = v425; l48 = v426; l49 = v427; l50 = v428; l51 = v429; l52 = v430; l53 = v431; l54 = v432; l55 = v433; l56 = v434; l57 = v435; l58 = v436; l59 = v437; l60 = v438; l61 = v439; l62 = v440} : Mut2
    let v442 : US11 = US11_0
    let v443 : US12 = US12_2
    let v444 : Mut3 = {l0 = v442; l1 = v441; l2 = v443} : Mut3
    let v445 : obj = v444
    let v446 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v447 : JS.Function = import v78 v79
    let v448 : JSX.Element = v447.Invoke (v446, v445) |> unbox<JSX.Element>
    let struct (v449 : US1, v450 : US1, v451 : US3, v452 : US1, v453 : US1, v454 : US1, v455 : US1, v456 : US1, v457 : US1, v458 : US4, v459 : US5, v460 : US1, v461 : US1, v462 : US4, v463 : US6, v464 : US1, v465 : US1, v466 : US1, v467 : US7, v468 : US4, v469 : US1, v470 : US1, v471 : US1, v472 : US1, v473 : US1, v474 : US8, v475 : US1, v476 : US1, v477 : US1, v478 : US8, v479 : US1, v480 : US1, v481 : US1, v482 : US1, v483 : US1, v484 : US1, v485 : US1, v486 : US1, v487 : US9, v488 : US10, v489 : US9, v490 : US1, v491 : US1, v492 : US1, v493 : US1, v494 : US1, v495 : US1, v496 : US1, v497 : US1, v498 : US1, v499 : US1, v500 : US1, v501 : US1, v502 : US1, v503 : US1, v504 : US1, v505 : US8, v506 : US1, v507 : US1, v508 : US6, v509 : US1, v510 : US0, v511 : US1) = method4()
    let v512 : string = "Database"
    let v513 : JSX.Element = Html.fragment [ v512 |> unbox<JSX.Element> ]
    let v514 : (unit -> (JSX.Element [])) = closure114()
    let v515 : US5 = US5_1(v514)
    let v516 : US1 = US1_1(v367)
    let v517 : US8 = US8_1(v513)
    let v518 : Mut2 = {l0 = v449; l1 = v450; l2 = v451; l3 = v452; l4 = v453; l5 = v454; l6 = v455; l7 = v456; l8 = v457; l9 = v458; l10 = v515; l11 = v460; l12 = v461; l13 = v462; l14 = v463; l15 = v464; l16 = v465; l17 = v466; l18 = v467; l19 = v468; l20 = v469; l21 = v470; l22 = v471; l23 = v472; l24 = v473; l25 = v474; l26 = v516; l27 = v476; l28 = v477; l29 = v478; l30 = v479; l31 = v480; l32 = v481; l33 = v482; l34 = v483; l35 = v484; l36 = v485; l37 = v486; l38 = v487; l39 = v488; l40 = v489; l41 = v490; l42 = v491; l43 = v492; l44 = v493; l45 = v494; l46 = v495; l47 = v496; l48 = v497; l49 = v498; l50 = v499; l51 = v500; l52 = v501; l53 = v502; l54 = v503; l55 = v504; l56 = v517; l57 = v506; l58 = v507; l59 = v508; l60 = v509; l61 = v510; l62 = v511} : Mut2
    let v519 : US11 = US11_0
    let v520 : US12 = US12_0
    let v521 : Mut3 = {l0 = v519; l1 = v518; l2 = v520} : Mut3
    let v522 : obj = v521
    let v523 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v524 : JS.Function = import v78 v79
    let v525 : JSX.Element = v524.Invoke (v523, v522) |> unbox<JSX.Element>
    let struct (v526 : US1, v527 : US1, v528 : US3, v529 : US1, v530 : US1, v531 : US1, v532 : US1, v533 : US1, v534 : US1, v535 : US4, v536 : US5, v537 : US1, v538 : US1, v539 : US4, v540 : US6, v541 : US1, v542 : US1, v543 : US1, v544 : US7, v545 : US4, v546 : US1, v547 : US1, v548 : US1, v549 : US1, v550 : US1, v551 : US8, v552 : US1, v553 : US1, v554 : US1, v555 : US8, v556 : US1, v557 : US1, v558 : US1, v559 : US1, v560 : US1, v561 : US1, v562 : US1, v563 : US1, v564 : US9, v565 : US10, v566 : US9, v567 : US1, v568 : US1, v569 : US1, v570 : US1, v571 : US1, v572 : US1, v573 : US1, v574 : US1, v575 : US1, v576 : US1, v577 : US1, v578 : US1, v579 : US1, v580 : US1, v581 : US1, v582 : US8, v583 : US1, v584 : US1, v585 : US6, v586 : US1, v587 : US0, v588 : US1) = method4()
    let v589 : Mut2 = {l0 = v526; l1 = v527; l2 = v528; l3 = v529; l4 = v530; l5 = v531; l6 = v532; l7 = v533; l8 = v534; l9 = v535; l10 = v536; l11 = v537; l12 = v538; l13 = v539; l14 = v540; l15 = v541; l16 = v542; l17 = v543; l18 = v544; l19 = v545; l20 = v546; l21 = v547; l22 = v548; l23 = v549; l24 = v550; l25 = v551; l26 = v552; l27 = v553; l28 = v554; l29 = v555; l30 = v556; l31 = v557; l32 = v558; l33 = v559; l34 = v560; l35 = v561; l36 = v562; l37 = v563; l38 = v564; l39 = v565; l40 = v566; l41 = v567; l42 = v568; l43 = v569; l44 = v570; l45 = v571; l46 = v572; l47 = v573; l48 = v574; l49 = v575; l50 = v576; l51 = v577; l52 = v578; l53 = v579; l54 = v580; l55 = v581; l56 = v582; l57 = v583; l58 = v584; l59 = v585; l60 = v586; l61 = v587; l62 = v588} : Mut2
    let v590 : US11 = US11_0
    let v591 : US12 = US12_2
    let v592 : Mut3 = {l0 = v590; l1 = v589; l2 = v591} : Mut3
    let v593 : obj = v592
    let v594 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v595 : JS.Function = import v78 v79
    let v596 : JSX.Element = v595.Invoke (v594, v593) |> unbox<JSX.Element>
    let struct (v597 : US1, v598 : US1, v599 : US3, v600 : US1, v601 : US1, v602 : US1, v603 : US1, v604 : US1, v605 : US1, v606 : US4, v607 : US5, v608 : US1, v609 : US1, v610 : US4, v611 : US6, v612 : US1, v613 : US1, v614 : US1, v615 : US7, v616 : US4, v617 : US1, v618 : US1, v619 : US1, v620 : US1, v621 : US1, v622 : US8, v623 : US1, v624 : US1, v625 : US1, v626 : US8, v627 : US1, v628 : US1, v629 : US1, v630 : US1, v631 : US1, v632 : US1, v633 : US1, v634 : US1, v635 : US9, v636 : US10, v637 : US9, v638 : US1, v639 : US1, v640 : US1, v641 : US1, v642 : US1, v643 : US1, v644 : US1, v645 : US1, v646 : US1, v647 : US1, v648 : US1, v649 : US1, v650 : US1, v651 : US1, v652 : US1, v653 : US8, v654 : US1, v655 : US1, v656 : US6, v657 : US1, v658 : US0, v659 : US1) = method4()
    let v660 : string = "Profile"
    let v661 : JSX.Element = Html.fragment [ v660 |> unbox<JSX.Element> ]
    let v662 : (unit -> (JSX.Element [])) = closure158(v0, v1, v2)
    let v663 : US5 = US5_1(v662)
    let v664 : US8 = US8_1(v661)
    let v665 : Mut2 = {l0 = v597; l1 = v598; l2 = v599; l3 = v600; l4 = v601; l5 = v602; l6 = v603; l7 = v604; l8 = v605; l9 = v606; l10 = v663; l11 = v608; l12 = v609; l13 = v610; l14 = v611; l15 = v612; l16 = v613; l17 = v614; l18 = v615; l19 = v616; l20 = v617; l21 = v618; l22 = v619; l23 = v620; l24 = v621; l25 = v622; l26 = v623; l27 = v624; l28 = v625; l29 = v626; l30 = v627; l31 = v628; l32 = v629; l33 = v630; l34 = v631; l35 = v632; l36 = v633; l37 = v634; l38 = v635; l39 = v636; l40 = v637; l41 = v638; l42 = v639; l43 = v640; l44 = v641; l45 = v642; l46 = v643; l47 = v644; l48 = v645; l49 = v646; l50 = v647; l51 = v648; l52 = v649; l53 = v650; l54 = v651; l55 = v652; l56 = v664; l57 = v654; l58 = v655; l59 = v656; l60 = v657; l61 = v658; l62 = v659} : Mut2
    let v666 : US11 = US11_0
    let v667 : US12 = US12_2
    let v668 : Mut3 = {l0 = v666; l1 = v665; l2 = v667} : Mut3
    let v669 : obj = v668
    let v670 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v671 : JS.Function = import v78 v79
    let v672 : JSX.Element = v671.Invoke (v670, v669) |> unbox<JSX.Element>
    [|v81; v152; v228; v299; v377; v448; v525; v596; v672|]
and closure5 (v0 : obj, v1 : string, v2 : bool) () : (JSX.Element []) =
    let v3 : (Mut2 -> JSX.Element) = closure6()
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method4()
    let v67 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65; l62 = v66} : Mut2
    let v68 : string = "flex"
    let v69 : US1 = US1_1(v68)
    v67.l17 <- v69
    let v70 : string = "1"
    let v71 : US1 = US1_1(v70)
    v67.l20 <- v71
    let v72 : string = "column"
    let v73 : US1 = US1_1(v72)
    v67.l21 <- v73
    let v74 : string = "auto"
    let v75 : US1 = US1_1(v74)
    v67.l43 <- v75
    let v76 : string = "hidden"
    let v77 : US1 = US1_1(v76)
    v67.l42 <- v77
    let struct (v78 : US1, v79 : US1, v80 : US3, v81 : US1, v82 : US1, v83 : US1, v84 : US1, v85 : US1, v86 : US1, v87 : US4, v88 : US5, v89 : US1, v90 : US1, v91 : US4, v92 : US6, v93 : US1, v94 : US1, v95 : US1, v96 : US7, v97 : US4, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US8, v104 : US1, v105 : US1, v106 : US1, v107 : US8, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US9, v117 : US10, v118 : US9, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US8, v135 : US1, v136 : US1, v137 : US6, v138 : US1, v139 : US0, v140 : US1) = v67.l0, v67.l1, v67.l2, v67.l3, v67.l4, v67.l5, v67.l6, v67.l7, v67.l8, v67.l9, v67.l10, v67.l11, v67.l12, v67.l13, v67.l14, v67.l15, v67.l16, v67.l17, v67.l18, v67.l19, v67.l20, v67.l21, v67.l22, v67.l23, v67.l24, v67.l25, v67.l26, v67.l27, v67.l28, v67.l29, v67.l30, v67.l31, v67.l32, v67.l33, v67.l34, v67.l35, v67.l36, v67.l37, v67.l38, v67.l39, v67.l40, v67.l41, v67.l42, v67.l43, v67.l44, v67.l45, v67.l46, v67.l47, v67.l48, v67.l49, v67.l50, v67.l51, v67.l52, v67.l53, v67.l54, v67.l55, v67.l56, v67.l57, v67.l58, v67.l59, v67.l60, v67.l61, v67.l62
    let v141 : (unit -> (JSX.Element [])) = closure9(v0, v1, v2)
    let v142 : US5 = US5_1(v141)
    emitJsExpr (struct (v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v142, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140), v141) "$0.children = $1"
    "create_component -> create_custom_component" |> ignore
    let v143 : US5 = US5_1(v141)
    let v144 : Mut2 = {l0 = v78; l1 = v79; l2 = v80; l3 = v81; l4 = v82; l5 = v83; l6 = v84; l7 = v85; l8 = v86; l9 = v87; l10 = v143; l11 = v89; l12 = v90; l13 = v91; l14 = v92; l15 = v93; l16 = v94; l17 = v95; l18 = v96; l19 = v97; l20 = v98; l21 = v99; l22 = v100; l23 = v101; l24 = v102; l25 = v103; l26 = v104; l27 = v105; l28 = v106; l29 = v107; l30 = v108; l31 = v109; l32 = v110; l33 = v111; l34 = v112; l35 = v113; l36 = v114; l37 = v115; l38 = v116; l39 = v117; l40 = v118; l41 = v119; l42 = v120; l43 = v121; l44 = v122; l45 = v123; l46 = v124; l47 = v125; l48 = v126; l49 = v127; l50 = v128; l51 = v129; l52 = v130; l53 = v131; l54 = v132; l55 = v133; l56 = v134; l57 = v135; l58 = v136; l59 = v137; l60 = v138; l61 = v139; l62 = v140} : Mut2
    let v145 : obj = v144
    let v146 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    "create_custom_component -> create_component'" |> ignore
    let v147 : string = "createComponent"
    let v148 : string = "solid-js"
    let v149 : JS.Function = import v147 v148
    let v150 : JSX.Element = v149.Invoke (v146, v145) |> unbox<JSX.Element>
    [|v150|]
and closure4 () (v0 : Mut2) : JSX.Element =
    let struct (v1 : obj, v2 : string, v3 : bool) = method2()
    let v4 : string = "Box"
    let v5 : string = "@hope-ui/solid"
    let v6 : JS.Function = import v4 v5
    let struct (v7 : US1, v8 : US1, v9 : US3, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US4, v17 : US5, v18 : US1, v19 : US1, v20 : US4, v21 : US6, v22 : US1, v23 : US1, v24 : US1, v25 : US7, v26 : US4, v27 : US1, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US8, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US9, v46 : US10, v47 : US9, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US8, v64 : US1, v65 : US1, v66 : US6, v67 : US1, v68 : US0, v69 : US1) = method4()
    let v70 : string = "$bg"
    let v71 : US1 = US1_1(v70)
    let v72 : (unit -> (JSX.Element [])) = closure5(v1, v2, v3)
    let v73 : US5 = US5_1(v72)
    let v74 : string = "$text1"
    let v75 : US1 = US1_1(v74)
    let v76 : string = "flex"
    let v77 : US1 = US1_1(v76)
    let v78 : string = "1"
    let v79 : US1 = US1_1(v78)
    let v80 : string = "column"
    let v81 : US1 = US1_1(v80)
    let v82 : string = "$sm"
    let v83 : US1 = US1_1(v82)
    let v84 : string = "100vh"
    let v85 : US1 = US1_1(v84)
    let v86 : string = "100vw"
    let v87 : US1 = US1_1(v86)
    let v88 : string = "1px"
    let v89 : US1 = US1_1(v88)
    let v90 : ((string * obj) []) = method5(v7, v8, v9, v71, v11, v12, v13, v14, v15, v16, v73, v75, v19, v20, v21, v22, v23, v77, v25, v26, v79, v81, v83, v85, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v87, v45, v46, v47, v48, v49, v50, v89, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69)
    let v91 : obj = createObj v90
    let v92 : (obj -> JSX.Element) = v6 |> unbox<obj -> JSX.Element>
    "create_native_component -> create_component'" |> ignore
    let v93 : string = "createComponent"
    let v94 : string = "solid-js"
    let v95 : JS.Function = import v93 v94
    let v96 : JSX.Element = v95.Invoke (v92, v91) |> unbox<JSX.Element>
    v96
let v0 : obj = JS.undefined
let v1 : Mut0 = {l0 = v0} : Mut0
let struct (v65 : (struct (string * string * string * string) []), v66 : US0, v67 : US1, v68 : US1, v69 : (struct (US2 * int32 * string * string) []), v70 : (struct (US2 * US2) []), v71 : (struct (int32 * obj) []), v72 : (struct (int32 * obj) []), v73 : (struct (int32 * int32) []), v74 : US0) = method0()
let v75 : Mut1 = {l0 = v65; l1 = v66; l2 = v67; l3 = v68; l4 = v69; l5 = v70; l6 = v71; l7 = v72; l8 = v73; l9 = v74} : Mut1
let v76 : obj = v75
let v77 : (obj -> obj) = method1()
let v78 : obj = v77 v76
let v79 : int32 = Random().Next ()
let v80 : string = "db_listener"
let v81 : (Mut2 -> JSX.Element) = closure2(v78)
let v82 : (string * obj) = v80, v81
let v83 : string = "content"
let v84 : (Mut2 -> JSX.Element) = closure4()
let v85 : (string * obj) = v83, v84
let v86 : string = "store"
let v87 : (string * obj) = v86, v78
let v88 : string = "run_id"
let v89 : (string * obj) = v88, v79
let v90 : obj = emitJsExpr () "process.env"
let v91 : string = "env"
let v92 : (string * obj) = v91, v90
let v93 : ((string * obj) []) = [|v82; v85; v87; v89; v92|]
let v94 : obj = createObj v93
v1.l0 <- v94
Browser.Dom.window?components_spi <- v94
()
