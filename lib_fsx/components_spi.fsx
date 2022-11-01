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
and Mut3 = {mutable l0 : int32}
and Mut4 = {mutable l0 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)); mutable l1 : (unit -> JS.Function); mutable l2 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1))}
and [<Struct>] US11 =
    | US11_0
    | US11_1 of f1_0 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit))
and [<Struct>] US12 =
    | US12_0
    | US12_1
    | US12_2
and Mut5 = {mutable l0 : US11; mutable l1 : Mut2; mutable l2 : US12}
and Mut6 = {mutable l0 : bool; mutable l1 : bool; mutable l2 : US11; mutable l3 : Mut2}
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
let rec method0 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) : struct ((struct (string * string * string * string) []) * US0 * US1 * US1 * (struct (US2 * int32 * string * string) []) * (struct (US2 * US2) []) * (struct (int32 * obj) []) * (struct (int32 * obj) []) * (struct (int32 * int32) []) * US0) =
    let v5 : bool = "" = v0
    let v8 : string =
        if v5 then
            let v6 : string = "http://localhost"
            v6
        else
            let v7 : string = $"http://{v0}-4001.githubpreview.dev"
            v7
    let v9 : int32 =
        if v5 then
            4001
        else
            80
    let v10 : string = "4ZZJNAAPJGOUBHORYKX5DQSJJIMQLADNUIH7ONXZAVEZYZGOAM5CM7HV2M"
    let v11 : string = "admin"
    let v12 : string = "poem slush dry adult final thunder price pause concert topic mesh wild dry gate judge celery winter list promote clump country loan move about faith"
    let v13 : string = "OBVzhzxAK4ZPdaF1QbkXsd8hgRUPJeCfYFjFghgMGnLmcpaAD0mdQJ3Rwq/RwklKGQWAbaIP9zb5BUmcZM4DOg=="
    let v14 : string = "Q2MAJEB7HYFK42KSN2MY26PL3P5P7HVIGR22GDAGCJQUARDEIM4WLHSIFQ"
    let v15 : string = "x"
    let v16 : string = "crater dove click normal kitten aisle obvious error exotic lunar guard impact donkey gun lamp divide announce match cement excess piano turn fish above make"
    let v17 : string = "lHFQVWKpvRYU00yAQqHOHJegn5nvP0owYkroBFKr94qGmASQPz4KrmlSbpmNeevb+v+eqDR1owwGEmFARGRDOQ=="
    let v18 : string = "KVGJONR4BETXZ3AS224T4MAJATTSTQGVO3VC3YAGSWAYBVD7KPR23RKNBI"
    let v19 : string = "o"
    let v20 : string = "key churn alert mother lock run lyrics category office lamp silver nut cement pistol fury hollow faculty feed capable announce index cloth faint about bid"
    let v21 : string = "0DNKDAK5QfWuMCTMNJ+Re5mSlc7rbI0q1UOUYDmvPGpVTJc2PAknfOwS1rk+MAkE5ynA1XbqLeAGlYGA1H9T4w=="
    let v22 : (struct (string * string * string * string) []) = [|struct (v10, v11, v12, v13); struct (v14, v15, v16, v17); struct (v18, v19, v20, v21)|]
    let v23 : (struct (US2 * US2) []) = [||]
    let v29 : string =
        if v5 then
            let v24 : string = "ws://localhost"
            v24
        else
            let v25 : bool = true = v4
            if v25 then
                let v26 : string = "ws://localhost"
                v26
            else
                let v27 : string = $"ws://{v0}-4944.githubpreview.dev"
                v27
    let v34 : int32 =
        if v5 then
            let v30 : bool = true = v4
            if v30 then
                14944
            else
                let v31 : bool = false = v4
                if v31 then
                    4944
                else
                    80
        else
            80
    let v35 : US2 = US2_1
    let v36 : string = "ws"
    let v42 : string =
        if v5 then
            let v37 : string = "wss://localhost"
            v37
        else
            let v38 : bool = true = v4
            if v38 then
                let v39 : string = "wss://localhost"
                v39
            else
                let v40 : string = $"ws://{v0}-8765.githubpreview.dev"
                v40
    let v47 : int32 =
        if v5 then
            let v43 : bool = true = v4
            if v43 then
                18765
            else
                let v44 : bool = false = v4
                if v44 then
                    8765
                else
                    80
        else
            80
    let v48 : US2 = US2_0
    let v49 : string = "gun"
    let v50 : (struct (US2 * int32 * string * string) []) = [|struct (v35, v34, v29, v36); struct (v48, v47, v42, v49)|]
    let v51 : (struct (int32 * int32) []) = [||]
    let v52 : (struct (int32 * obj) []) = [||]
    let v53 : (struct (int32 * obj) []) = [||]
    let v54 : US0 = US0_1(v9)
    let v55 : string = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
    let v56 : US1 = US1_1(v55)
    let v57 : US1 = US1_1(v8)
    let v58 : US0 = US0_0
    struct (v22, v54, v56, v57, v50, v23, v53, v52, v51, v58)
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
and method3 (v0 : int32, v1 : string) : string =
    let v2 : int32 = String.length v1
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : string = $"0{v1}"
        method3(v0, v4)
    else
        v1
and closure3 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool, v5 : int64) struct (v6 : Mut1, v7 : Mut1, v8 : obj) : unit =
    let v9 : string = ">> db_listener store.on(@changed)"
    let v10 : obj = v9
    let v11 : string = "b_changed:"
    let v12 : obj = struct (v11, v7)
    let v13 : (obj []) = [|v10; v12|]
    let v14 : int64 = DateTime.UtcNow.Ticks / 1000L
    let v15 : int64 = v14 - v5
    let v16 : string = v15.ToString ()
    let v17 : int32 = 6
    let v18 : string = method3(v17, v16)
    let v19 : int32 = emitJsExpr () "components_spi.run_id"
    let v20 : string = $"[{v18}] {v19}"
    let v21 : string = JS.JSON.stringify v13
    let v22 : (obj []) = [||]
    let v23 : string = JS.JSON.stringify v22
    let struct (v29 : string, v30 : string, v31 : string, v32 : string, v33 : string) =
        if v4 then
            let v24 : string = ""
            struct (v20, v21, v23, v24, v24)
        else
            let v25 : string = $"{v20} %%c%%s %%c%%s"
            let v26 : string = "#cf1100"
            let v27 : string = $"font-weight: bold; color: {v26}"
            let v28 : string = "font-weight: bold; color: #444"
            struct (v25, v27, v21, v28, v23)
    emitJsExpr () $"console.log.apply(console, {struct (v29, v30, v31, v32, v33)})"
    let struct (v34 : (struct (US2 * int32 * string * string) []), v35 : (struct (US2 * US2) [])) = v7.l4, v7.l5
    let v36 : bool = emitJsExpr v35 "!$0"
    let v37 : bool = v36 = false
    let v42 : bool =
        if v37 then
            true
        else
            let struct (v38 : (struct (US2 * int32 * string * string) []), v39 : (struct (US2 * US2) [])) = v7.l4, v7.l5
            let v40 : bool = emitJsExpr v38 "!$0"
            let v41 : bool = v40 = false
            v41
    ()
and method2 (v0 : obj) : JSX.Element =
    let v1 : obj = emitJsExpr () "components_spi.env"
    let v2 : string = emitJsExpr v1 "$0.CODESPACE_NAME || \"\""
    let v3 : string = emitJsExpr v1 "$0.GITHUB_RUN_ID || \"\""
    let v4 : string = emitJsExpr v1 "$0.GITHUB_SHA || \"\""
    let v5 : obj = v1?IS_TEST
    let v6 : bool = emitJsExpr v5 "!$0"
    let v7 : bool = v6 = false
    let v8 : int64 = DateTime.UtcNow.Ticks / 1000L
    let v9 : string = "> db_listener ()"
    let v10 : obj = v9
    let v11 : (obj []) = [|v10|]
    let v12 : int64 = DateTime.UtcNow.Ticks / 1000L
    let v13 : int64 = v12 - v8
    let v14 : string = v13.ToString ()
    let v15 : int32 = 6
    let v16 : string = method3(v15, v14)
    let v17 : int32 = emitJsExpr () "components_spi.run_id"
    let v18 : string = $"[{v16}] {v17}"
    let v19 : string = JS.JSON.stringify v11
    let v20 : (obj []) = [||]
    let v21 : string = JS.JSON.stringify v20
    let struct (v27 : string, v28 : string, v29 : string, v30 : string, v31 : string) =
        if v7 then
            let v22 : string = ""
            struct (v18, v19, v21, v22, v22)
        else
            let v23 : string = $"{v18} %%c%%s %%c%%s"
            let v24 : string = "#cf1100"
            let v25 : string = $"font-weight: bold; color: {v24}"
            let v26 : string = "font-weight: bold; color: #444"
            struct (v23, v25, v19, v26, v21)
    emitJsExpr () $"console.log.apply(console, {struct (v27, v28, v29, v30, v31)})"
    let v32 : JS.Function = v0?on |> unbox<JS.Function>
    let v33 : (struct (Mut1 * Mut1 * obj) -> unit) = closure3(v2, v1, v3, v4, v7, v8)
    let v34 : JS.Function = emitJsExpr v33 "(...args: any[]) => $0(args)"
    let v35 : (unit -> unit) = v32.Invoke ("@changed", v34) |> unbox<unit -> unit>
    let v36 : string = "onCleanup"
    let v37 : string = "solid-js"
    let v38 : JS.Function = import v36 v37
    v38.Invoke v35 |> ignore
    let v39 : JSX.Element = Html.fragment []
    v39
and closure2 (v0 : obj) (v1 : Mut2) : JSX.Element =
    method2(v0)
and method5 () : struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) =
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
and method7 (v0 : US1, v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) : ((string * obj) []) =
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
    method8(v631)
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
    let struct (v8 : US1, v9 : US1, v10 : US3, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US4, v18 : US5, v19 : US1, v20 : US1, v21 : US4, v22 : US6, v23 : US1, v24 : US1, v25 : US1, v26 : US7, v27 : US4, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US8, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US9, v47 : US10, v48 : US9, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US8, v65 : US1, v66 : US1, v67 : US6, v68 : US1, v69 : US0, v70 : US1) = method5()
    let v71 : string = "$blackAlpha3"
    let v72 : US1 = US1_1(v71)
    let v73 : US5 = US5_1(v4)
    let v74 : string = "flex"
    let v75 : US1 = US1_1(v74)
    let v76 : string = "column"
    let v77 : US1 = US1_1(v76)
    let v78 : string = "-1px"
    let v79 : US1 = US1_1(v78)
    let v80 : ((string * obj) []) = method7(v8, v9, v10, v72, v12, v13, v14, v15, v16, v17, v73, v19, v20, v21, v22, v23, v24, v75, v26, v27, v28, v77, v30, v31, v32, v33, v34, v35, v36, v37, v38, v79, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
    let v81 : obj = createObj v80
    let v82 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    let v83 : string = "createComponent"
    let v84 : string = "solid-js"
    let v85 : JS.Function = import v83 v84
    let v86 : JSX.Element = v85.Invoke (v82, v81) |> unbox<JSX.Element>
    [|v86|]
and method6 (v0 : Mut2) : JSX.Element =
    let v1 : string = "Table"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method5()
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
    let v82 : ((string * obj) []) = method7(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v72, v15, v16, v17, v18, v19, v20, v74, v22, v23, v76, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v80, v81, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66)
    let v83 : obj = createObj v82
    let v84 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v85 : string = "createComponent"
    let v86 : string = "solid-js"
    let v87 : JS.Function = import v85 v86
    let v88 : JSX.Element = v87.Invoke (v84, v83) |> unbox<JSX.Element>
    v88
and closure6 () (v0 : Mut2) : JSX.Element =
    method6(v0)
and method14 (v0 : int32, v1 : Mut3) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method13 (v0 : Mut2, v1 : Mut2) : unit =
    let v2 : (string []) = JS.Constructors.Object.keys v0 |> unbox<string[]>
    let v3 : int32 = v2.Length
    let v4 : Mut3 = {l0 = 0} : Mut3
    while method14(v3, v4) do
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
and closure16 (v0 : Mut2) () : (JSX.Element []) =
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
and closure18 () () : (JSX.Element []) =
    [||]
and method15 (v0 : Mut4) : JSX.Element =
    let v1 : string = "Icon"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method5()
    let v67 : (unit -> JS.Function) = v0.l1
    let v68 : JS.Function = v67 ()
    let struct (v69 : US1, v70 : US1, v71 : US3, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US1, v77 : US1, v78 : US4, v79 : US5, v80 : US1, v81 : US1, v82 : US4, v83 : US6, v84 : US1, v85 : US1, v86 : US1, v87 : US7, v88 : US4, v89 : US1, v90 : US1, v91 : US1, v92 : US1, v93 : US1, v94 : US8, v95 : US1, v96 : US1, v97 : US1, v98 : US8, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US1, v105 : US1, v106 : US1, v107 : US9, v108 : US10, v109 : US9, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US8, v126 : US1, v127 : US1, v128 : US6, v129 : US1, v130 : US0, v131 : US1) = method5()
    let v132 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = v0.l0
    let v133 : string = "-12px"
    let v134 : US1 = US1_1(v133)
    let v135 : US1 = US1_1(v133)
    let v136 : string = "0.6"
    let v137 : US1 = US1_1(v136)
    let struct (v138 : US1, v139 : US1, v140 : US3, v141 : US1, v142 : US1, v143 : US1, v144 : US1, v145 : US1, v146 : US1, v147 : US4, v148 : US5, v149 : US1, v150 : US1, v151 : US4, v152 : US6, v153 : US1, v154 : US1, v155 : US1, v156 : US7, v157 : US4, v158 : US1, v159 : US1, v160 : US1, v161 : US1, v162 : US1, v163 : US8, v164 : US1, v165 : US1, v166 : US1, v167 : US8, v168 : US1, v169 : US1, v170 : US1, v171 : US1, v172 : US1, v173 : US1, v174 : US1, v175 : US1, v176 : US9, v177 : US10, v178 : US9, v179 : US1, v180 : US1, v181 : US1, v182 : US1, v183 : US1, v184 : US1, v185 : US1, v186 : US1, v187 : US1, v188 : US1, v189 : US1, v190 : US1, v191 : US1, v192 : US1, v193 : US1, v194 : US8, v195 : US1, v196 : US1, v197 : US6, v198 : US1, v199 : US0, v200 : US1) = v132 struct (v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v134, v103, v135, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v137)
    let v201 : ((string * obj) []) = method7(v138, v139, v140, v141, v142, v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200)
    let v202 : obj = createObj v201
    let v203 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = v0.l2
    let v204 : US3 = US3_1(v68)
    let v205 : US6 = US6_1(v202)
    let v206 : string = "14px"
    let v207 : US1 = US1_1(v206)
    let struct (v208 : US1, v209 : US1, v210 : US3, v211 : US1, v212 : US1, v213 : US1, v214 : US1, v215 : US1, v216 : US1, v217 : US4, v218 : US5, v219 : US1, v220 : US1, v221 : US4, v222 : US6, v223 : US1, v224 : US1, v225 : US1, v226 : US7, v227 : US4, v228 : US1, v229 : US1, v230 : US1, v231 : US1, v232 : US1, v233 : US8, v234 : US1, v235 : US1, v236 : US1, v237 : US8, v238 : US1, v239 : US1, v240 : US1, v241 : US1, v242 : US1, v243 : US1, v244 : US1, v245 : US1, v246 : US9, v247 : US10, v248 : US9, v249 : US1, v250 : US1, v251 : US1, v252 : US1, v253 : US1, v254 : US1, v255 : US1, v256 : US1, v257 : US1, v258 : US1, v259 : US1, v260 : US1, v261 : US1, v262 : US1, v263 : US1, v264 : US8, v265 : US1, v266 : US1, v267 : US6, v268 : US1, v269 : US0, v270 : US1) = v203 struct (v4, v5, v204, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v205, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v207, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66)
    let v271 : (unit -> (JSX.Element [])) = closure18()
    let v272 : US5 = US5_1(v271)
    let v273 : ((string * obj) []) = method7(v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v272, v219, v220, v221, v222, v223, v224, v225, v226, v227, v228, v229, v230, v231, v232, v233, v234, v235, v236, v237, v238, v239, v240, v241, v242, v243, v244, v245, v246, v247, v248, v249, v250, v251, v252, v253, v254, v255, v256, v257, v258, v259, v260, v261, v262, v263, v264, v265, v266, v267, v268, v269, v270)
    let v274 : obj = createObj v273
    let v275 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v276 : string = "createComponent"
    let v277 : string = "solid-js"
    let v278 : JS.Function = import v276 v277
    let v279 : JSX.Element = v278.Invoke (v275, v274) |> unbox<JSX.Element>
    v279
and closure17 () (v0 : Mut4) : JSX.Element =
    method15(v0)
and closure19 () struct (v0 : US1, v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) : struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) =
    let v63 : US1 = US1_0
    let v64 : string = "-13px"
    let v65 : US1 = US1_1(v64)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v63, v34, v65, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure20 () () : JS.Function =
    let v0 : string = "BiRegularLinkExternal"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure21 () struct (v0 : US1, v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) : struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) =
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure15 (v0 : Mut2) () : (JSX.Element []) =
    let v1 : string = "Anchor"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method5()
    let struct (v67 : US1, v68 : US1, v69 : US3, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US4, v77 : US5, v78 : US1, v79 : US1, v80 : US4, v81 : US6, v82 : US1, v83 : US1, v84 : US1, v85 : US7, v86 : US4, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US1, v92 : US8, v93 : US1, v94 : US1, v95 : US1, v96 : US8, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US1, v105 : US9, v106 : US10, v107 : US9, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US8, v124 : US1, v125 : US1, v126 : US6, v127 : US1, v128 : US0, v129 : US1) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61, v0.l62
    let v130 : Mut2 = {l0 = v67; l1 = v68; l2 = v69; l3 = v70; l4 = v71; l5 = v72; l6 = v73; l7 = v74; l8 = v75; l9 = v76; l10 = v77; l11 = v78; l12 = v79; l13 = v80; l14 = v81; l15 = v82; l16 = v83; l17 = v84; l18 = v85; l19 = v86; l20 = v87; l21 = v88; l22 = v89; l23 = v90; l24 = v91; l25 = v92; l26 = v93; l27 = v94; l28 = v95; l29 = v96; l30 = v97; l31 = v98; l32 = v99; l33 = v100; l34 = v101; l35 = v102; l36 = v103; l37 = v104; l38 = v105; l39 = v106; l40 = v107; l41 = v108; l42 = v109; l43 = v110; l44 = v111; l45 = v112; l46 = v113; l47 = v114; l48 = v115; l49 = v116; l50 = v117; l51 = v118; l52 = v119; l53 = v120; l54 = v121; l55 = v122; l56 = v123; l57 = v124; l58 = v125; l59 = v126; l60 = v127; l61 = v128; l62 = v129} : Mut2
    let v131 : US4 = US4_1(true)
    let v132 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v131; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65; l62 = v66} : Mut2
    method13(v132, v130)
    let struct (v133 : US1, v134 : US1, v135 : US3, v136 : US1, v137 : US1, v138 : US1, v139 : US1, v140 : US1, v141 : US1, v142 : US4, v143 : US5, v144 : US1, v145 : US1, v146 : US4, v147 : US6, v148 : US1, v149 : US1, v150 : US1, v151 : US7, v152 : US4, v153 : US1, v154 : US1, v155 : US1, v156 : US1, v157 : US1, v158 : US8, v159 : US1, v160 : US1, v161 : US1, v162 : US8, v163 : US1, v164 : US1, v165 : US1, v166 : US1, v167 : US1, v168 : US1, v169 : US1, v170 : US1, v171 : US9, v172 : US10, v173 : US9, v174 : US1, v175 : US1, v176 : US1, v177 : US1, v178 : US1, v179 : US1, v180 : US1, v181 : US1, v182 : US1, v183 : US1, v184 : US1, v185 : US1, v186 : US1, v187 : US1, v188 : US1, v189 : US8, v190 : US1, v191 : US1, v192 : US6, v193 : US1, v194 : US0, v195 : US1) = v132.l0, v132.l1, v132.l2, v132.l3, v132.l4, v132.l5, v132.l6, v132.l7, v132.l8, v132.l9, v132.l10, v132.l11, v132.l12, v132.l13, v132.l14, v132.l15, v132.l16, v132.l17, v132.l18, v132.l19, v132.l20, v132.l21, v132.l22, v132.l23, v132.l24, v132.l25, v132.l26, v132.l27, v132.l28, v132.l29, v132.l30, v132.l31, v132.l32, v132.l33, v132.l34, v132.l35, v132.l36, v132.l37, v132.l38, v132.l39, v132.l40, v132.l41, v132.l42, v132.l43, v132.l44, v132.l45, v132.l46, v132.l47, v132.l48, v132.l49, v132.l50, v132.l51, v132.l52, v132.l53, v132.l54, v132.l55, v132.l56, v132.l57, v132.l58, v132.l59, v132.l60, v132.l61, v132.l62
    let v196 : (unit -> (JSX.Element [])) = closure16(v0)
    let v197 : US5 = US5_1(v196)
    let v198 : ((string * obj) []) = method7(v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v197, v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195)
    let v199 : obj = createObj v198
    let v200 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v201 : string = "createComponent"
    let v202 : string = "solid-js"
    let v203 : JS.Function = import v201 v202
    let v204 : JSX.Element = v203.Invoke (v200, v199) |> unbox<JSX.Element>
    let v205 : string = "&nbsp;"
    let v206 : JSX.Element = Html.fragment [ v205 |> unbox<JSX.Element> ]
    let v207 : (Mut4 -> JSX.Element) = closure17()
    let v208 : (obj -> JSX.Element) = v207 |> unbox<obj -> JSX.Element>
    let v209 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = closure19()
    let v210 : (unit -> JS.Function) = closure20()
    let v211 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = closure21()
    let v212 : Mut4 = {l0 = v209; l1 = v210; l2 = v211} : Mut4
    let v213 : obj = v212
    let v214 : JS.Function = import v201 v202
    let v215 : JSX.Element = v214.Invoke (v208, v213) |> unbox<JSX.Element>
    [|v204; v206; v215|]
and method12 (v0 : Mut2) : JSX.Element =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method5()
    let v67 : (unit -> (JSX.Element [])) = closure15(v0)
    let v68 : US5 = US5_1(v67)
    let v69 : ((string * obj) []) = method7(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v68, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66)
    let v70 : obj = createObj v69
    let v71 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v72 : string = "createComponent"
    let v73 : string = "solid-js"
    let v74 : JS.Function = import v72 v73
    let v75 : JSX.Element = v74.Invoke (v71, v70) |> unbox<JSX.Element>
    v75
and closure14 () (v0 : Mut2) : JSX.Element =
    method12(v0)
and closure22 () () : (JSX.Element []) =
    [||]
and closure13 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure14()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure22()
    let v66 : US5 = US5_1(v65)
    let v67 : string = "https://github.com/fc1943s/tictactoe_spiral"
    let v68 : US1 = US1_1(v67)
    let v69 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v68; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v69, v65) "$0.children = $1"
    let v70 : obj = v69
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v1, v70) |> unbox<JSX.Element>
    [|v74|]
and method17 (v0 : string, v1 : string) : string =
    let v2 : string = {| ``@initial`` = v1; ``@sm`` = v0 |} |> unbox<string>
    v2
and closure27 (v0 : JSX.Element) () : (JSX.Element []) =
    [|v0|]
and closure26 (v0 : JSX.Element) () : (JSX.Element []) =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method5()
    let v67 : (unit -> (JSX.Element [])) = closure27(v0)
    let v68 : US5 = US5_1(v67)
    let v69 : string = "2px"
    let v70 : US1 = US1_1(v69)
    let v71 : ((string * obj) []) = method7(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v68, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v70, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66)
    let v72 : obj = createObj v71
    let v73 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v74 : string = "createComponent"
    let v75 : string = "solid-js"
    let v76 : JS.Function = import v74 v75
    let v77 : JSX.Element = v76.Invoke (v73, v72) |> unbox<JSX.Element>
    [|v77|]
and closure28 (v0 : (bool -> unit)) (v1 : obj) : unit =
    let v2 : bool = v1?target?checked
    v0 v2
    ()
and closure25 (v0 : Mut5, v1 : (bool -> unit), v2 : (unit -> bool), v3 : JSX.Element) () : (JSX.Element []) =
    let v4 : US12 = v0.l2
    let v175 : JSX.Element =
        match v4 with
        | US12_0 -> (* CheckDisabled *)
            let v5 : string = "Checkbox"
            let v6 : string = "@hope-ui/solid"
            let v7 : JS.Function = import v5 v6
            let struct (v8 : US1, v9 : US1, v10 : US3, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US4, v18 : US5, v19 : US1, v20 : US1, v21 : US4, v22 : US6, v23 : US1, v24 : US1, v25 : US1, v26 : US7, v27 : US4, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US8, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US9, v47 : US10, v48 : US9, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US8, v65 : US1, v66 : US1, v67 : US6, v68 : US1, v69 : US0, v70 : US1) = method5()
            let v71 : bool = v2 ()
            let v72 : US4 = US4_1(v71)
            let v73 : (unit -> (JSX.Element [])) = closure26(v3)
            let v74 : US5 = US5_1(v73)
            let v75 : string = "neutral"
            let v76 : US1 = US1_1(v75)
            let v77 : string = "2px"
            let v78 : US1 = US1_1(v77)
            let v79 : (obj -> unit) = closure28(v1)
            let v80 : US9 = US9_1(v79)
            let v81 : string = "sm"
            let v82 : US1 = US1_1(v81)
            let v83 : ((string * obj) []) = method7(v8, v9, v10, v11, v12, v13, v14, v15, v16, v72, v74, v19, v76, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v78, v41, v42, v43, v44, v45, v80, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v82, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
            let v84 : obj = createObj v83
            let v85 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
            let v86 : string = "createComponent"
            let v87 : string = "solid-js"
            let v88 : JS.Function = import v86 v87
            let v89 : JSX.Element = v88.Invoke (v85, v84) |> unbox<JSX.Element>
            v89
        | US12_1 -> (* CheckEnabled *)
            let v90 : string = "Checkbox"
            let v91 : string = "@hope-ui/solid"
            let v92 : JS.Function = import v90 v91
            let struct (v93 : US1, v94 : US1, v95 : US3, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US4, v103 : US5, v104 : US1, v105 : US1, v106 : US4, v107 : US6, v108 : US1, v109 : US1, v110 : US1, v111 : US7, v112 : US4, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US8, v119 : US1, v120 : US1, v121 : US1, v122 : US8, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US9, v132 : US10, v133 : US9, v134 : US1, v135 : US1, v136 : US1, v137 : US1, v138 : US1, v139 : US1, v140 : US1, v141 : US1, v142 : US1, v143 : US1, v144 : US1, v145 : US1, v146 : US1, v147 : US1, v148 : US1, v149 : US8, v150 : US1, v151 : US1, v152 : US6, v153 : US1, v154 : US0, v155 : US1) = method5()
            let v156 : bool = v2 ()
            let v157 : US4 = US4_1(v156)
            let v158 : (unit -> (JSX.Element [])) = closure26(v3)
            let v159 : US5 = US5_1(v158)
            let v160 : string = "neutral"
            let v161 : US1 = US1_1(v160)
            let v162 : string = "2px"
            let v163 : US1 = US1_1(v162)
            let v164 : (obj -> unit) = closure28(v1)
            let v165 : US9 = US9_1(v164)
            let v166 : string = "sm"
            let v167 : US1 = US1_1(v166)
            let v168 : ((string * obj) []) = method7(v93, v94, v95, v96, v97, v98, v99, v100, v101, v157, v159, v104, v161, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v163, v126, v127, v128, v129, v130, v165, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v143, v167, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155)
            let v169 : obj = createObj v168
            let v170 : (obj -> JSX.Element) = v92 |> unbox<obj -> JSX.Element>
            let v171 : string = "createComponent"
            let v172 : string = "solid-js"
            let v173 : JS.Function = import v171 v172
            let v174 : JSX.Element = v173.Invoke (v170, v169) |> unbox<JSX.Element>
            v174
        | US12_2 -> (* CheckHidden *)
            v3
    [|v175|]
and closure29 () () : (JSX.Element []) =
    let v0 : string = "&nbsp;"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure32 (v0 : (unit -> bool)) () : (obj []) =
    let v1 : bool = v0 ()
    let v2 : obj = v1
    [|v2|]
and closure33 (v0 : (bool -> unit), v1 : (unit -> bool)) () : unit =
    let v2 : bool = v1 ()
    if v2 then
        v0 false
        ()
and closure34 (v0 : Mut1, v1 : JS.Function) (v2 : (Mut1 -> (Mut1 -> unit))) : unit =
    let v3 : ((string * obj) []) = Array.zeroCreate<(string * obj)> (0)
    let v4 : obj = createObj v3
    let v5 : Mut1 = v4 |> unbox
    let v6 : (Mut1 -> unit) = v2 v0
    v6 v5
    let v7 : string = JS.JSON.stringify v5
    let v8 : string = "use_store dispatch"
    let v9 : string = "new_state(new):"
    printfn $"%A{struct (v8, v9, v7)}"
    let v10 : obj = v5
    v1.Invoke ("set", v10) |> ignore
    ()
and closure38 () () : (JSX.Element []) =
    [||]
and method19 (v0 : Mut2) : JSX.Element =
    let v1 : US5 = v0.l10
    let v4 : (unit -> (JSX.Element [])) =
        match v1 with
        | US5_0 -> (* None *)
            closure38()
        | US5_1(v3) -> (* Some *)
            v3
    let v5 : string = "Button"
    let v6 : string = "@hope-ui/solid"
    let v7 : JS.Function = import v5 v6
    let struct (v8 : US1, v9 : US1, v10 : US3, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US4, v18 : US5, v19 : US1, v20 : US1, v21 : US4, v22 : US6, v23 : US1, v24 : US1, v25 : US1, v26 : US7, v27 : US4, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US8, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US9, v47 : US10, v48 : US9, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US8, v65 : US1, v66 : US1, v67 : US6, v68 : US1, v69 : US0, v70 : US1) = method5()
    let struct (v71 : US1, v72 : US1, v73 : US3, v74 : US1, v75 : US1, v76 : US1, v77 : US1, v78 : US1, v79 : US1, v80 : US4, v81 : US5, v82 : US1, v83 : US1, v84 : US4, v85 : US6, v86 : US1, v87 : US1, v88 : US1, v89 : US7, v90 : US4, v91 : US1, v92 : US1, v93 : US1, v94 : US1, v95 : US1, v96 : US8, v97 : US1, v98 : US1, v99 : US1, v100 : US8, v101 : US1, v102 : US1, v103 : US1, v104 : US1, v105 : US1, v106 : US1, v107 : US1, v108 : US1, v109 : US9, v110 : US10, v111 : US9, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US8, v128 : US1, v129 : US1, v130 : US6, v131 : US1, v132 : US0, v133 : US1) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61, v0.l62
    let v134 : Mut2 = {l0 = v71; l1 = v72; l2 = v73; l3 = v74; l4 = v75; l5 = v76; l6 = v77; l7 = v78; l8 = v79; l9 = v80; l10 = v81; l11 = v82; l12 = v83; l13 = v84; l14 = v85; l15 = v86; l16 = v87; l17 = v88; l18 = v89; l19 = v90; l20 = v91; l21 = v92; l22 = v93; l23 = v94; l24 = v95; l25 = v96; l26 = v97; l27 = v98; l28 = v99; l29 = v100; l30 = v101; l31 = v102; l32 = v103; l33 = v104; l34 = v105; l35 = v106; l36 = v107; l37 = v108; l38 = v109; l39 = v110; l40 = v111; l41 = v112; l42 = v113; l43 = v114; l44 = v115; l45 = v116; l46 = v117; l47 = v118; l48 = v119; l49 = v120; l50 = v121; l51 = v122; l52 = v123; l53 = v124; l54 = v125; l55 = v126; l56 = v127; l57 = v128; l58 = v129; l59 = v130; l60 = v131; l61 = v132; l62 = v133} : Mut2
    let v135 : string = "neutral"
    let v136 : US1 = US1_1(v135)
    let v137 : US4 = US4_1(true)
    let v138 : string = "left"
    let v139 : US1 = US1_1(v138)
    let v140 : string = "xs"
    let v141 : US1 = US1_1(v140)
    let v142 : Mut2 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v18; l11 = v19; l12 = v136; l13 = v137; l14 = v22; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v34; l27 = v139; l28 = v36; l29 = v37; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50; l43 = v51; l44 = v52; l45 = v53; l46 = v54; l47 = v55; l48 = v56; l49 = v57; l50 = v58; l51 = v141; l52 = v60; l53 = v61; l54 = v62; l55 = v63; l56 = v64; l57 = v65; l58 = v66; l59 = v67; l60 = v68; l61 = v69; l62 = v70} : Mut2
    method13(v142, v134)
    let struct (v143 : US1, v144 : US1, v145 : US3, v146 : US1, v147 : US1, v148 : US1, v149 : US1, v150 : US1, v151 : US1, v152 : US4, v153 : US5, v154 : US1, v155 : US1, v156 : US4, v157 : US6, v158 : US1, v159 : US1, v160 : US1, v161 : US7, v162 : US4, v163 : US1, v164 : US1, v165 : US1, v166 : US1, v167 : US1, v168 : US8, v169 : US1, v170 : US1, v171 : US1, v172 : US8, v173 : US1, v174 : US1, v175 : US1, v176 : US1, v177 : US1, v178 : US1, v179 : US1, v180 : US1, v181 : US9, v182 : US10, v183 : US9, v184 : US1, v185 : US1, v186 : US1, v187 : US1, v188 : US1, v189 : US1, v190 : US1, v191 : US1, v192 : US1, v193 : US1, v194 : US1, v195 : US1, v196 : US1, v197 : US1, v198 : US1, v199 : US8, v200 : US1, v201 : US1, v202 : US6, v203 : US1, v204 : US0, v205 : US1) = v142.l0, v142.l1, v142.l2, v142.l3, v142.l4, v142.l5, v142.l6, v142.l7, v142.l8, v142.l9, v142.l10, v142.l11, v142.l12, v142.l13, v142.l14, v142.l15, v142.l16, v142.l17, v142.l18, v142.l19, v142.l20, v142.l21, v142.l22, v142.l23, v142.l24, v142.l25, v142.l26, v142.l27, v142.l28, v142.l29, v142.l30, v142.l31, v142.l32, v142.l33, v142.l34, v142.l35, v142.l36, v142.l37, v142.l38, v142.l39, v142.l40, v142.l41, v142.l42, v142.l43, v142.l44, v142.l45, v142.l46, v142.l47, v142.l48, v142.l49, v142.l50, v142.l51, v142.l52, v142.l53, v142.l54, v142.l55, v142.l56, v142.l57, v142.l58, v142.l59, v142.l60, v142.l61, v142.l62
    let v206 : US5 = US5_1(v4)
    let v207 : ((string * obj) []) = method7(v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v206, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205)
    let v208 : obj = createObj v207
    let v209 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    let v210 : string = "createComponent"
    let v211 : string = "solid-js"
    let v212 : JS.Function = import v210 v211
    let v213 : JSX.Element = v212.Invoke (v209, v208) |> unbox<JSX.Element>
    v213
and closure37 () (v0 : Mut2) : JSX.Element =
    method19(v0)
and closure39 () () : (JSX.Element []) =
    let v0 : string = "Load"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure40 (v0 : (bool -> unit), v1 : Mut6, v2 : Mut1, v3 : JS.Function) () : unit =
    let v4 : US11 = v1.l2
    match v4 with
    | US11_0 -> (* None *)
        ()
    | US11_1(v5) -> (* Some *)
        let v6 : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) = v5 v2
        let v7 : ((Mut1 -> (Mut1 -> unit)) -> unit) = closure34(v2, v3)
        v6 v7
        ()
    v0 true
    ()
and closure36 (v0 : (bool -> unit), v1 : Mut6, v2 : Mut1, v3 : JS.Function) () : (JSX.Element []) =
    let v4 : (Mut2 -> JSX.Element) = closure37()
    let v5 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let struct (v6 : US1, v7 : US1, v8 : US3, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US4, v16 : US5, v17 : US1, v18 : US1, v19 : US4, v20 : US6, v21 : US1, v22 : US1, v23 : US1, v24 : US7, v25 : US4, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US8, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US9, v45 : US10, v46 : US9, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US8, v63 : US1, v64 : US1, v65 : US6, v66 : US1, v67 : US0, v68 : US1) = method5()
    let v69 : (unit -> (JSX.Element [])) = closure39()
    let v70 : US5 = US5_1(v69)
    let v71 : (unit -> unit) = closure40(v0, v1, v2, v3)
    let v72 : US10 = US10_1(v71)
    let v73 : Mut2 = {l0 = v6; l1 = v7; l2 = v8; l3 = v9; l4 = v10; l5 = v11; l6 = v12; l7 = v13; l8 = v14; l9 = v15; l10 = v70; l11 = v17; l12 = v18; l13 = v19; l14 = v20; l15 = v21; l16 = v22; l17 = v23; l18 = v24; l19 = v25; l20 = v26; l21 = v27; l22 = v28; l23 = v29; l24 = v30; l25 = v31; l26 = v32; l27 = v33; l28 = v34; l29 = v35; l30 = v36; l31 = v37; l32 = v38; l33 = v39; l34 = v40; l35 = v41; l36 = v42; l37 = v43; l38 = v44; l39 = v72; l40 = v46; l41 = v47; l42 = v48; l43 = v49; l44 = v50; l45 = v51; l46 = v52; l47 = v53; l48 = v54; l49 = v55; l50 = v56; l51 = v57; l52 = v58; l53 = v59; l54 = v60; l55 = v61; l56 = v62; l57 = v63; l58 = v64; l59 = v65; l60 = v66; l61 = v67; l62 = v68} : Mut2
    emitJsExpr (v73, v69) "$0.children = $1"
    let v74 : obj = v73
    let v75 : string = "createComponent"
    let v76 : string = "solid-js"
    let v77 : JS.Function = import v75 v76
    let v78 : JSX.Element = v77.Invoke (v5, v74) |> unbox<JSX.Element>
    [|v78|]
and closure44 () () : JS.Function =
    let v0 : string = "BiRegularRefresh"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure45 () () : (JSX.Element []) =
    [||]
and closure46 (v0 : (bool -> unit)) () : unit =
    v0 true
    ()
and closure47 () () : JS.Function =
    let v0 : string = "BiRegularDownArrow"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure48 () () : JS.Function =
    let v0 : string = "BiRegularUpArrow"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure49 () () : (JSX.Element []) =
    [||]
and closure50 (v0 : Mut1, v1 : JS.Function, v2 : int32, v3 : (bool -> unit), v4 : (unit -> bool)) () : unit =
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
    let v13 : string = JS.JSON.stringify v9
    let v14 : string = "use_store dispatch"
    let v15 : string = "new_state(new):"
    printfn $"%A{struct (v14, v15, v13)}"
    let v16 : obj = v9
    v1.Invoke ("set", v16) |> ignore
    ()
and closure51 () () : JS.Function =
    let v0 : string = "BiRegularUndo"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure52 () () : (JSX.Element []) =
    [||]
and closure53 (v0 : (bool -> unit)) () : unit =
    v0 false
    ()
and closure43 (v0 : Mut1, v1 : JS.Function, v2 : int32, v3 : (bool -> unit), v4 : (bool -> unit), v5 : (bool -> unit), v6 : (unit -> bool)) () : (JSX.Element []) =
    let v7 : string = "IconButton"
    let v8 : string = "@hope-ui/solid"
    let v9 : JS.Function = import v7 v8
    let struct (v10 : US1, v11 : US1, v12 : US3, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US1, v18 : US1, v19 : US4, v20 : US5, v21 : US1, v22 : US1, v23 : US4, v24 : US6, v25 : US1, v26 : US1, v27 : US1, v28 : US7, v29 : US4, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US8, v36 : US1, v37 : US1, v38 : US1, v39 : US8, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US9, v49 : US10, v50 : US9, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US8, v67 : US1, v68 : US1, v69 : US6, v70 : US1, v71 : US0, v72 : US1) = method5()
    let v73 : (Mut4 -> JSX.Element) = closure17()
    let v74 : (obj -> JSX.Element) = v73 |> unbox<obj -> JSX.Element>
    let v75 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = closure21()
    let v76 : (unit -> JS.Function) = closure44()
    let v77 : Mut4 = {l0 = v75; l1 = v76; l2 = v75} : Mut4
    let v78 : obj = v77
    let v79 : string = "createComponent"
    let v80 : string = "solid-js"
    let v81 : JS.Function = import v79 v80
    let v82 : JSX.Element = v81.Invoke (v74, v78) |> unbox<JSX.Element>
    let v83 : string = "Refresh"
    let v84 : US1 = US1_1(v83)
    let v85 : (unit -> (JSX.Element [])) = closure45()
    let v86 : US5 = US5_1(v85)
    let v87 : string = "neutral"
    let v88 : US1 = US1_1(v87)
    let v89 : string = "20px"
    let v90 : US1 = US1_1(v89)
    let v91 : US8 = US8_1(v82)
    let v92 : (unit -> unit) = closure46(v4)
    let v93 : US10 = US10_1(v92)
    let v94 : string = "xs"
    let v95 : US1 = US1_1(v94)
    let v96 : ((string * obj) []) = method7(v10, v84, v12, v13, v14, v15, v16, v17, v18, v19, v86, v21, v88, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v90, v34, v91, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v93, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v95, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v97 : obj = createObj v96
    let v98 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    let v99 : JS.Function = import v79 v80
    let v100 : JSX.Element = v99.Invoke (v98, v97) |> unbox<JSX.Element>
    let v101 : JS.Function = import v7 v8
    let struct (v102 : US1, v103 : US1, v104 : US3, v105 : US1, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US4, v112 : US5, v113 : US1, v114 : US1, v115 : US4, v116 : US6, v117 : US1, v118 : US1, v119 : US1, v120 : US7, v121 : US4, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US8, v128 : US1, v129 : US1, v130 : US1, v131 : US8, v132 : US1, v133 : US1, v134 : US1, v135 : US1, v136 : US1, v137 : US1, v138 : US1, v139 : US1, v140 : US9, v141 : US10, v142 : US9, v143 : US1, v144 : US1, v145 : US1, v146 : US1, v147 : US1, v148 : US1, v149 : US1, v150 : US1, v151 : US1, v152 : US1, v153 : US1, v154 : US1, v155 : US1, v156 : US1, v157 : US1, v158 : US8, v159 : US1, v160 : US1, v161 : US6, v162 : US1, v163 : US0, v164 : US1) = method5()
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
            closure47()
        else
            closure48()
    let v173 : (obj -> JSX.Element) = v73 |> unbox<obj -> JSX.Element>
    let v174 : Mut4 = {l0 = v75; l1 = v172; l2 = v75} : Mut4
    let v175 : obj = v174
    let v176 : JS.Function = import v79 v80
    let v177 : JSX.Element = v176.Invoke (v173, v175) |> unbox<JSX.Element>
    let v178 : US1 = US1_1(v168)
    let v179 : (unit -> (JSX.Element [])) = closure49()
    let v180 : US5 = US5_1(v179)
    let v181 : US1 = US1_1(v87)
    let v182 : US1 = US1_1(v89)
    let v183 : US8 = US8_1(v177)
    let v184 : (unit -> unit) = closure50(v0, v1, v2, v5, v6)
    let v185 : US10 = US10_1(v184)
    let v186 : US1 = US1_1(v94)
    let v187 : ((string * obj) []) = method7(v102, v178, v104, v105, v106, v107, v108, v109, v110, v111, v180, v113, v181, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v182, v126, v183, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v185, v142, v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v186, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164)
    let v188 : obj = createObj v187
    let v189 : (obj -> JSX.Element) = v101 |> unbox<obj -> JSX.Element>
    let v190 : JS.Function = import v79 v80
    let v191 : JSX.Element = v190.Invoke (v189, v188) |> unbox<JSX.Element>
    let v192 : JS.Function = import v7 v8
    let struct (v193 : US1, v194 : US1, v195 : US3, v196 : US1, v197 : US1, v198 : US1, v199 : US1, v200 : US1, v201 : US1, v202 : US4, v203 : US5, v204 : US1, v205 : US1, v206 : US4, v207 : US6, v208 : US1, v209 : US1, v210 : US1, v211 : US7, v212 : US4, v213 : US1, v214 : US1, v215 : US1, v216 : US1, v217 : US1, v218 : US8, v219 : US1, v220 : US1, v221 : US1, v222 : US8, v223 : US1, v224 : US1, v225 : US1, v226 : US1, v227 : US1, v228 : US1, v229 : US1, v230 : US1, v231 : US9, v232 : US10, v233 : US9, v234 : US1, v235 : US1, v236 : US1, v237 : US1, v238 : US1, v239 : US1, v240 : US1, v241 : US1, v242 : US1, v243 : US1, v244 : US1, v245 : US1, v246 : US1, v247 : US1, v248 : US1, v249 : US8, v250 : US1, v251 : US1, v252 : US6, v253 : US1, v254 : US0, v255 : US1) = method5()
    let v256 : (obj -> JSX.Element) = v73 |> unbox<obj -> JSX.Element>
    let v257 : (unit -> JS.Function) = closure51()
    let v258 : Mut4 = {l0 = v75; l1 = v257; l2 = v75} : Mut4
    let v259 : obj = v258
    let v260 : JS.Function = import v79 v80
    let v261 : JSX.Element = v260.Invoke (v256, v259) |> unbox<JSX.Element>
    let v262 : string = "Unload"
    let v263 : US1 = US1_1(v262)
    let v264 : (unit -> (JSX.Element [])) = closure52()
    let v265 : US5 = US5_1(v264)
    let v266 : US1 = US1_1(v87)
    let v267 : US1 = US1_1(v89)
    let v268 : US8 = US8_1(v261)
    let v269 : (unit -> unit) = closure53(v3)
    let v270 : US10 = US10_1(v269)
    let v271 : US1 = US1_1(v94)
    let v272 : ((string * obj) []) = method7(v193, v263, v195, v196, v197, v198, v199, v200, v201, v202, v265, v204, v266, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v267, v217, v268, v219, v220, v221, v222, v223, v224, v225, v226, v227, v228, v229, v230, v231, v270, v233, v234, v235, v236, v237, v238, v239, v240, v241, v242, v243, v271, v245, v246, v247, v248, v249, v250, v251, v252, v253, v254, v255)
    let v273 : obj = createObj v272
    let v274 : (obj -> JSX.Element) = v192 |> unbox<obj -> JSX.Element>
    let v275 : JS.Function = import v79 v80
    let v276 : JSX.Element = v275.Invoke (v274, v273) |> unbox<JSX.Element>
    [|v100; v191; v276|]
and closure42 (v0 : Mut1, v1 : JS.Function, v2 : int32, v3 : (bool -> unit), v4 : (bool -> unit), v5 : (unit -> bool), v6 : (bool -> unit), v7 : (unit -> bool), v8 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v9 : string = "Stack"
    let v10 : string = "@hope-ui/solid"
    let v11 : JS.Function = import v9 v10
    let struct (v12 : US1, v13 : US1, v14 : US3, v15 : US1, v16 : US1, v17 : US1, v18 : US1, v19 : US1, v20 : US1, v21 : US4, v22 : US5, v23 : US1, v24 : US1, v25 : US4, v26 : US6, v27 : US1, v28 : US1, v29 : US1, v30 : US7, v31 : US4, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US8, v38 : US1, v39 : US1, v40 : US1, v41 : US8, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US9, v51 : US10, v52 : US9, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US1, v67 : US1, v68 : US8, v69 : US1, v70 : US1, v71 : US6, v72 : US1, v73 : US0, v74 : US1) = method5()
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
    let v85 : (unit -> (JSX.Element [])) = closure43(v0, v1, v2, v3, v4, v6, v7)
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
    let v98 : ((string * obj) []) = method7(v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v86, v23, v24, v25, v26, v27, v88, v84, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v90, v92, v63, v94, v65, v66, v67, v68, v95, v70, v71, v72, v97, v74)
    let v99 : obj = createObj v98
    let v100 : (obj -> JSX.Element) = v11 |> unbox<obj -> JSX.Element>
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
and closure41 (v0 : Mut2, v1 : Mut1, v2 : JS.Function, v3 : int32, v4 : (bool -> unit), v5 : (bool -> unit), v6 : (unit -> bool), v7 : (bool -> unit), v8 : (unit -> bool)) () : (JSX.Element []) =
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
            let struct (v15 : US1, v16 : US1, v17 : US3, v18 : US1, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US4, v25 : US5, v26 : US1, v27 : US1, v28 : US4, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US7, v34 : US4, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US8, v41 : US1, v42 : US1, v43 : US1, v44 : US8, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US9, v54 : US10, v55 : US9, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US1, v67 : US1, v68 : US1, v69 : US1, v70 : US1, v71 : US8, v72 : US1, v73 : US1, v74 : US6, v75 : US1, v76 : US0, v77 : US1) = method5()
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
            let v85 : (unit -> (JSX.Element [])) = closure42(v1, v2, v3, v4, v5, v6, v7, v8, v11)
            let v86 : US5 = US5_1(v85)
            let v87 : string = "flex"
            let v88 : US1 = US1_1(v87)
            let v89 : string = "1"
            let v90 : US1 = US1_1(v89)
            let v91 : ((string * obj) []) = method7(v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v86, v26, v27, v28, v29, v30, v31, v88, v33, v34, v90, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v84, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77)
            let v92 : obj = createObj v91
            let v93 : (obj -> JSX.Element) = v14 |> unbox<obj -> JSX.Element>
            let v94 : string = "createComponent"
            let v95 : string = "solid-js"
            let v96 : JS.Function = import v94 v95
            let v97 : JSX.Element = v96.Invoke (v93, v92) |> unbox<JSX.Element>
            v97
    [|v98|]
and closure35 (v0 : Mut2, v1 : Mut1, v2 : JS.Function, v3 : int32, v4 : (bool -> unit), v5 : (unit -> bool), v6 : (bool -> unit), v7 : (unit -> bool), v8 : (bool -> unit), v9 : (unit -> bool), v10 : Mut6) () : (JSX.Element []) =
    let v11 : bool = v5 ()
    let v12 : bool = v11 = false
    let v203 : JSX.Element =
        if v12 then
            let v13 : string = "Box"
            let v14 : string = "@hope-ui/solid"
            let v15 : JS.Function = import v13 v14
            let struct (v16 : US1, v17 : US1, v18 : US3, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US4, v26 : US5, v27 : US1, v28 : US1, v29 : US4, v30 : US6, v31 : US1, v32 : US1, v33 : US1, v34 : US7, v35 : US4, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US8, v42 : US1, v43 : US1, v44 : US1, v45 : US8, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US9, v55 : US10, v56 : US9, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US1, v67 : US1, v68 : US1, v69 : US1, v70 : US1, v71 : US1, v72 : US8, v73 : US1, v74 : US1, v75 : US6, v76 : US1, v77 : US0, v78 : US1) = method5()
            let v79 : (unit -> (JSX.Element [])) = closure36(v4, v10, v1, v2)
            let v80 : US5 = US5_1(v79)
            let v81 : string = "3px 0"
            let v82 : US1 = US1_1(v81)
            let v83 : ((string * obj) []) = method7(v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v80, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v82, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78)
            let v84 : obj = createObj v83
            let v85 : (obj -> JSX.Element) = v15 |> unbox<obj -> JSX.Element>
            let v86 : string = "createComponent"
            let v87 : string = "solid-js"
            let v88 : JS.Function = import v86 v87
            let v89 : JSX.Element = v88.Invoke (v85, v84) |> unbox<JSX.Element>
            v89
        else
            let v90 : string = "Box"
            let v91 : string = "@hope-ui/solid"
            let v92 : JS.Function = import v90 v91
            let struct (v93 : US1, v94 : US1, v95 : US3, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US4, v103 : US5, v104 : US1, v105 : US1, v106 : US4, v107 : US6, v108 : US1, v109 : US1, v110 : US1, v111 : US7, v112 : US4, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US8, v119 : US1, v120 : US1, v121 : US1, v122 : US8, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US9, v132 : US10, v133 : US9, v134 : US1, v135 : US1, v136 : US1, v137 : US1, v138 : US1, v139 : US1, v140 : US1, v141 : US1, v142 : US1, v143 : US1, v144 : US1, v145 : US1, v146 : US1, v147 : US1, v148 : US1, v149 : US8, v150 : US1, v151 : US1, v152 : US6, v153 : US1, v154 : US0, v155 : US1) = method5()
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
            let v190 : (unit -> (JSX.Element [])) = closure41(v0, v1, v2, v3, v4, v6, v7, v8, v9)
            let v191 : US5 = US5_1(v190)
            let v192 : string = "flex"
            let v193 : US1 = US1_1(v192)
            let v194 : string = "1"
            let v195 : US1 = US1_1(v194)
            let v196 : ((string * obj) []) = method7(v93, v94, v95, v189, v97, v98, v99, v100, v179, v102, v191, v104, v105, v106, v107, v108, v109, v193, v111, v112, v195, v114, v115, v116, v117, v118, v119, v120, v184, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v164, v174, v144, v145, v146, v147, v148, v149, v169, v151, v152, v153, v159, v155)
            let v197 : obj = createObj v196
            let v198 : (obj -> JSX.Element) = v92 |> unbox<obj -> JSX.Element>
            let v199 : string = "createComponent"
            let v200 : string = "solid-js"
            let v201 : JS.Function = import v199 v200
            let v202 : JSX.Element = v201.Invoke (v198, v197) |> unbox<JSX.Element>
            v202
    [|v203|]
and method18 (v0 : Mut6) : JSX.Element =
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
    let v27 : (unit -> (obj [])) = closure32(v18)
    let v28 : (unit -> unit) = closure33(v19, v18)
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
            let v37 : ((Mut1 -> (Mut1 -> unit)) -> unit) = closure34(v6, v7)
            v36 v37
            ()
    let v38 : string = "Box"
    let v39 : string = "@hope-ui/solid"
    let v40 : JS.Function = import v38 v39
    let struct (v41 : US1, v42 : US1, v43 : US3, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US4, v51 : US5, v52 : US1, v53 : US1, v54 : US4, v55 : US6, v56 : US1, v57 : US1, v58 : US1, v59 : US7, v60 : US4, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US8, v67 : US1, v68 : US1, v69 : US1, v70 : US8, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US1, v77 : US1, v78 : US1, v79 : US9, v80 : US10, v81 : US9, v82 : US1, v83 : US1, v84 : US1, v85 : US1, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US1, v92 : US1, v93 : US1, v94 : US1, v95 : US1, v96 : US1, v97 : US8, v98 : US1, v99 : US1, v100 : US6, v101 : US1, v102 : US0, v103 : US1) = method5()
    let v104 : US1 = v1.l26
    let v105 : (unit -> (JSX.Element [])) = closure35(v1, v6, v7, v8, v15, v14, v19, v18, v24, v23, v0)
    let v106 : US5 = US5_1(v105)
    let v107 : string = "flex"
    let v108 : US1 = US1_1(v107)
    let v109 : string = "1"
    let v110 : US1 = US1_1(v109)
    let v111 : ((string * obj) []) = method7(v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v106, v52, v53, v54, v55, v56, v57, v108, v59, v60, v110, v62, v63, v64, v65, v66, v104, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103)
    let v112 : obj = createObj v111
    let v113 : (obj -> JSX.Element) = v40 |> unbox<obj -> JSX.Element>
    let v114 : string = "createComponent"
    let v115 : JS.Function = import v114 v11
    let v116 : JSX.Element = v115.Invoke (v113, v112) |> unbox<JSX.Element>
    v116
and closure31 () (v0 : Mut6) : JSX.Element =
    method18(v0)
and closure30 (v0 : Mut5, v1 : (unit -> bool), v2 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v3 : US12 = v0.l2
    let v159 : JSX.Element =
        match v3 with
        | US12_0 -> (* CheckDisabled *)
            let v4 : bool = v1 ()
            if v4 then
                let v5 : US11 = v0.l0
                let struct (v6 : US1, v7 : US1, v8 : US3, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US4, v16 : US5, v17 : US1, v18 : US1, v19 : US4, v20 : US6, v21 : US1, v22 : US1, v23 : US1, v24 : US7, v25 : US4, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US8, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US9, v45 : US10, v46 : US9, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US8, v63 : US1, v64 : US1, v65 : US6, v66 : US1, v67 : US0, v68 : US1) = method5()
                let v69 : US5 = US5_1(v2)
                let v70 : Mut2 = {l0 = v6; l1 = v7; l2 = v8; l3 = v9; l4 = v10; l5 = v11; l6 = v12; l7 = v13; l8 = v14; l9 = v15; l10 = v69; l11 = v17; l12 = v18; l13 = v19; l14 = v20; l15 = v21; l16 = v22; l17 = v23; l18 = v24; l19 = v25; l20 = v26; l21 = v27; l22 = v28; l23 = v29; l24 = v30; l25 = v31; l26 = v32; l27 = v33; l28 = v34; l29 = v35; l30 = v36; l31 = v37; l32 = v38; l33 = v39; l34 = v40; l35 = v41; l36 = v42; l37 = v43; l38 = v44; l39 = v45; l40 = v46; l41 = v47; l42 = v48; l43 = v49; l44 = v50; l45 = v51; l46 = v52; l47 = v53; l48 = v54; l49 = v55; l50 = v56; l51 = v57; l52 = v58; l53 = v59; l54 = v60; l55 = v61; l56 = v62; l57 = v63; l58 = v64; l59 = v65; l60 = v66; l61 = v67; l62 = v68} : Mut2
                let v71 : (Mut6 -> JSX.Element) = closure31()
                let v72 : (obj -> JSX.Element) = v71 |> unbox<obj -> JSX.Element>
                let v73 : Mut6 = {l0 = true; l1 = false; l2 = v5; l3 = v70} : Mut6
                let v74 : obj = v73
                let v75 : string = "createComponent"
                let v76 : string = "solid-js"
                let v77 : JS.Function = import v75 v76
                let v78 : JSX.Element = v77.Invoke (v72, v74) |> unbox<JSX.Element>
                v78
            else
                let v79 : JSX.Element = Html.fragment []
                v79
        | US12_1 -> (* CheckEnabled *)
            let v81 : bool = v1 ()
            if v81 then
                let v82 : US11 = v0.l0
                let struct (v83 : US1, v84 : US1, v85 : US3, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US1, v92 : US4, v93 : US5, v94 : US1, v95 : US1, v96 : US4, v97 : US6, v98 : US1, v99 : US1, v100 : US1, v101 : US7, v102 : US4, v103 : US1, v104 : US1, v105 : US1, v106 : US1, v107 : US1, v108 : US8, v109 : US1, v110 : US1, v111 : US1, v112 : US8, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US9, v122 : US10, v123 : US9, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US1, v136 : US1, v137 : US1, v138 : US1, v139 : US8, v140 : US1, v141 : US1, v142 : US6, v143 : US1, v144 : US0, v145 : US1) = method5()
                let v146 : US5 = US5_1(v2)
                let v147 : Mut2 = {l0 = v83; l1 = v84; l2 = v85; l3 = v86; l4 = v87; l5 = v88; l6 = v89; l7 = v90; l8 = v91; l9 = v92; l10 = v146; l11 = v94; l12 = v95; l13 = v96; l14 = v97; l15 = v98; l16 = v99; l17 = v100; l18 = v101; l19 = v102; l20 = v103; l21 = v104; l22 = v105; l23 = v106; l24 = v107; l25 = v108; l26 = v109; l27 = v110; l28 = v111; l29 = v112; l30 = v113; l31 = v114; l32 = v115; l33 = v116; l34 = v117; l35 = v118; l36 = v119; l37 = v120; l38 = v121; l39 = v122; l40 = v123; l41 = v124; l42 = v125; l43 = v126; l44 = v127; l45 = v128; l46 = v129; l47 = v130; l48 = v131; l49 = v132; l50 = v133; l51 = v134; l52 = v135; l53 = v136; l54 = v137; l55 = v138; l56 = v139; l57 = v140; l58 = v141; l59 = v142; l60 = v143; l61 = v144; l62 = v145} : Mut2
                let v148 : (Mut6 -> JSX.Element) = closure31()
                let v149 : (obj -> JSX.Element) = v148 |> unbox<obj -> JSX.Element>
                let v150 : Mut6 = {l0 = true; l1 = false; l2 = v82; l3 = v147} : Mut6
                let v151 : obj = v150
                let v152 : string = "createComponent"
                let v153 : string = "solid-js"
                let v154 : JS.Function = import v152 v153
                let v155 : JSX.Element = v154.Invoke (v149, v151) |> unbox<JSX.Element>
                v155
            else
                let v156 : JSX.Element = Html.fragment []
                v156
        | US12_2 -> (* CheckHidden *)
            let v158 : JSX.Element = v2 |> unbox<JSX.Element>
            v158
    [|v159|]
and closure24 (v0 : Mut5, v1 : Mut2, v2 : (bool -> unit), v3 : (unit -> bool)) () : (JSX.Element []) =
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
            let struct (v10 : US1, v11 : US1, v12 : US3, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US1, v18 : US1, v19 : US4, v20 : US5, v21 : US1, v22 : US1, v23 : US4, v24 : US6, v25 : US1, v26 : US1, v27 : US1, v28 : US7, v29 : US4, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US8, v36 : US1, v37 : US1, v38 : US1, v39 : US8, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US9, v49 : US10, v50 : US9, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US8, v67 : US1, v68 : US1, v69 : US6, v70 : US1, v71 : US0, v72 : US1) = method5()
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
                    method17(v79, v78)
                else
                    let v81 : string = "0px !important"
                    v81
            let v83 : US1 = US1_1(v82)
            let v84 : string = "$neutral5"
            let v85 : US1 = US1_1(v84)
            let v86 : (unit -> (JSX.Element [])) = closure25(v0, v2, v3, v6)
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
            let v98 : ((string * obj) []) = method7(v10, v11, v12, v13, v14, v83, v85, v17, v18, v19, v87, v89, v22, v23, v24, v25, v26, v91, v28, v29, v30, v93, v95, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v97, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
            let v99 : obj = createObj v98
            let v100 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
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
            let struct (v110 : US1, v111 : US1, v112 : US3, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US4, v120 : US5, v121 : US1, v122 : US1, v123 : US4, v124 : US6, v125 : US1, v126 : US1, v127 : US1, v128 : US7, v129 : US4, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US8, v136 : US1, v137 : US1, v138 : US1, v139 : US8, v140 : US1, v141 : US1, v142 : US1, v143 : US1, v144 : US1, v145 : US1, v146 : US1, v147 : US1, v148 : US9, v149 : US10, v150 : US9, v151 : US1, v152 : US1, v153 : US1, v154 : US1, v155 : US1, v156 : US1, v157 : US1, v158 : US1, v159 : US1, v160 : US1, v161 : US1, v162 : US1, v163 : US1, v164 : US1, v165 : US1, v166 : US8, v167 : US1, v168 : US1, v169 : US6, v170 : US1, v171 : US0, v172 : US1) = method5()
            let v173 : string = "0"
            let v174 : US1 = US1_1(v173)
            let v175 : (unit -> (JSX.Element [])) = closure29()
            let v176 : US5 = US5_1(v175)
            let v177 : string = "9px"
            let v178 : US1 = US1_1(v177)
            let v179 : US1 = US1_1(v173)
            let v180 : ((string * obj) []) = method7(v110, v111, v112, v113, v174, v115, v116, v117, v118, v119, v176, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v178, v141, v142, v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v179, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172)
            let v181 : obj = createObj v180
            let v182 : (obj -> JSX.Element) = v109 |> unbox<obj -> JSX.Element>
            let v183 : string = "createComponent"
            let v184 : string = "solid-js"
            let v185 : JS.Function = import v183 v184
            let v186 : JSX.Element = v185.Invoke (v182, v181) |> unbox<JSX.Element>
            v186
        | US5_1(v187) -> (* Some *)
            let v188 : string = "Td"
            let v189 : string = "@hope-ui/solid"
            let v190 : JS.Function = import v188 v189
            let struct (v191 : US1, v192 : US1, v193 : US3, v194 : US1, v195 : US1, v196 : US1, v197 : US1, v198 : US1, v199 : US1, v200 : US4, v201 : US5, v202 : US1, v203 : US1, v204 : US4, v205 : US6, v206 : US1, v207 : US1, v208 : US1, v209 : US7, v210 : US4, v211 : US1, v212 : US1, v213 : US1, v214 : US1, v215 : US1, v216 : US8, v217 : US1, v218 : US1, v219 : US1, v220 : US8, v221 : US1, v222 : US1, v223 : US1, v224 : US1, v225 : US1, v226 : US1, v227 : US1, v228 : US1, v229 : US9, v230 : US10, v231 : US9, v232 : US1, v233 : US1, v234 : US1, v235 : US1, v236 : US1, v237 : US1, v238 : US1, v239 : US1, v240 : US1, v241 : US1, v242 : US1, v243 : US1, v244 : US1, v245 : US1, v246 : US1, v247 : US8, v248 : US1, v249 : US1, v250 : US6, v251 : US1, v252 : US0, v253 : US1) = method5()
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
            let v260 : (unit -> (JSX.Element [])) = closure30(v0, v3, v187)
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
            let v279 : ((string * obj) []) = method7(v191, v192, v193, v194, v259, v196, v197, v198, v199, v200, v261, v202, v203, v204, v205, v206, v207, v263, v209, v210, v265, v267, v269, v214, v215, v216, v217, v218, v219, v220, v271, v272, v223, v224, v225, v226, v274, v228, v229, v230, v231, v275, v233, v277, v278, v236, v237, v238, v239, v240, v241, v242, v243, v244, v245, v246, v247, v248, v249, v250, v251, v252, v253)
            let v280 : obj = createObj v279
            let v281 : (obj -> JSX.Element) = v190 |> unbox<obj -> JSX.Element>
            let v282 : string = "createComponent"
            let v283 : string = "solid-js"
            let v284 : JS.Function = import v282 v283
            let v285 : JSX.Element = v284.Invoke (v281, v280) |> unbox<JSX.Element>
            v285
    [|v105; v286|]
and method16 (v0 : Mut5) : JSX.Element =
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
    let struct (v15 : US1, v16 : US1, v17 : US3, v18 : US1, v19 : US1, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US4, v25 : US5, v26 : US1, v27 : US1, v28 : US4, v29 : US6, v30 : US1, v31 : US1, v32 : US1, v33 : US7, v34 : US4, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US8, v41 : US1, v42 : US1, v43 : US1, v44 : US8, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US9, v54 : US10, v55 : US9, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US1, v67 : US1, v68 : US1, v69 : US1, v70 : US1, v71 : US8, v72 : US1, v73 : US1, v74 : US6, v75 : US1, v76 : US0, v77 : US1) = method5()
    let v78 : US1 = v1.l26
    let v79 : string = "column"
    let v80 : string = "row"
    let v81 : string = method17(v80, v79)
    let v82 : string = "$neutral5"
    let v83 : US1 = US1_1(v82)
    let v84 : string = "1px 2px"
    let v85 : US1 = US1_1(v84)
    let v86 : (unit -> (JSX.Element [])) = closure24(v0, v1, v11, v10)
    let v87 : US5 = US5_1(v86)
    let v88 : string = "flex"
    let v89 : US1 = US1_1(v88)
    let v90 : string = "1"
    let v91 : US1 = US1_1(v90)
    let v92 : US1 = US1_1(v81)
    let v93 : ((string * obj) []) = method7(v15, v16, v17, v18, v19, v20, v83, v85, v23, v24, v87, v26, v27, v28, v29, v30, v31, v89, v33, v34, v91, v92, v37, v38, v39, v40, v78, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77)
    let v94 : obj = createObj v93
    let v95 : (obj -> JSX.Element) = v14 |> unbox<obj -> JSX.Element>
    let v96 : string = "createComponent"
    let v97 : JS.Function = import v96 v7
    let v98 : JSX.Element = v97.Invoke (v95, v94) |> unbox<JSX.Element>
    v98
and closure23 () (v0 : Mut5) : JSX.Element =
    method16(v0)
and closure54 (v0 : string) () : (JSX.Element []) =
    let v1 : (Mut2 -> JSX.Element) = closure14()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let struct (v3 : US1, v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = method5()
    let v66 : (unit -> (JSX.Element [])) = closure22()
    let v67 : US5 = US5_1(v66)
    let v68 : US1 = US1_1(v0)
    let v69 : Mut2 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v67; l11 = v14; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v68; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v47; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v59; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64; l62 = v65} : Mut2
    emitJsExpr (v69, v66) "$0.children = $1"
    let v70 : obj = v69
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v2, v70) |> unbox<JSX.Element>
    [|v74|]
and closure55 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure14()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure22()
    let v66 : US5 = US5_1(v65)
    let v67 : string = "https://fc1943s.github.io/tictactoe_spiral"
    let v68 : US1 = US1_1(v67)
    let v69 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v68; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v69, v65) "$0.children = $1"
    let v70 : obj = v69
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v1, v70) |> unbox<JSX.Element>
    [|v74|]
and closure56 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure14()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure22()
    let v66 : US5 = US5_1(v65)
    let v67 : string = "https://fc1943s.github.io/tictactoe_spiral/docs"
    let v68 : US1 = US1_1(v67)
    let v69 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v68; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v69, v65) "$0.children = $1"
    let v70 : obj = v69
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v1, v70) |> unbox<JSX.Element>
    [|v74|]
and closure12 (v0 : string) () : (JSX.Element []) =
    let v1 : bool = "" = v0
    let v159 : JSX.Element =
        if v1 then
            let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method5()
            let v65 : (unit -> (JSX.Element [])) = closure13()
            let v66 : US5 = US5_1(v65)
            let v67 : string = "1px 6px"
            let v68 : US1 = US1_1(v67)
            let v69 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v68; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
            let v70 : (Mut5 -> JSX.Element) = closure23()
            let v71 : (obj -> JSX.Element) = v70 |> unbox<obj -> JSX.Element>
            let v72 : US11 = US11_0
            let v73 : US12 = US12_2
            let v74 : Mut5 = {l0 = v72; l1 = v69; l2 = v73} : Mut5
            let v75 : obj = v74
            let v76 : string = "createComponent"
            let v77 : string = "solid-js"
            let v78 : JS.Function = import v76 v77
            let v79 : JSX.Element = v78.Invoke (v71, v75) |> unbox<JSX.Element>
            v79
        else
            let v80 : string = $"https://github.com/fc1943s/tictactoe_spiral/tree/{v0}"
            let struct (v81 : US1, v82 : US1, v83 : US3, v84 : US1, v85 : US1, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US4, v91 : US5, v92 : US1, v93 : US1, v94 : US4, v95 : US6, v96 : US1, v97 : US1, v98 : US1, v99 : US7, v100 : US4, v101 : US1, v102 : US1, v103 : US1, v104 : US1, v105 : US1, v106 : US8, v107 : US1, v108 : US1, v109 : US1, v110 : US8, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US9, v120 : US10, v121 : US9, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US1, v136 : US1, v137 : US8, v138 : US1, v139 : US1, v140 : US6, v141 : US1, v142 : US0, v143 : US1) = method5()
            let v144 : (unit -> (JSX.Element [])) = closure54(v80)
            let v145 : US5 = US5_1(v144)
            let v146 : string = "1px 6px"
            let v147 : US1 = US1_1(v146)
            let v148 : Mut2 = {l0 = v81; l1 = v82; l2 = v83; l3 = v84; l4 = v85; l5 = v86; l6 = v87; l7 = v88; l8 = v89; l9 = v90; l10 = v145; l11 = v92; l12 = v93; l13 = v94; l14 = v95; l15 = v96; l16 = v97; l17 = v98; l18 = v99; l19 = v100; l20 = v101; l21 = v102; l22 = v103; l23 = v104; l24 = v105; l25 = v106; l26 = v107; l27 = v108; l28 = v109; l29 = v110; l30 = v111; l31 = v112; l32 = v113; l33 = v114; l34 = v115; l35 = v116; l36 = v117; l37 = v118; l38 = v119; l39 = v120; l40 = v121; l41 = v122; l42 = v123; l43 = v124; l44 = v147; l45 = v126; l46 = v127; l47 = v128; l48 = v129; l49 = v130; l50 = v131; l51 = v132; l52 = v133; l53 = v134; l54 = v135; l55 = v136; l56 = v137; l57 = v138; l58 = v139; l59 = v140; l60 = v141; l61 = v142; l62 = v143} : Mut2
            let v149 : (Mut5 -> JSX.Element) = closure23()
            let v150 : (obj -> JSX.Element) = v149 |> unbox<obj -> JSX.Element>
            let v151 : US11 = US11_0
            let v152 : US12 = US12_2
            let v153 : Mut5 = {l0 = v151; l1 = v148; l2 = v152} : Mut5
            let v154 : obj = v153
            let v155 : string = "createComponent"
            let v156 : string = "solid-js"
            let v157 : JS.Function = import v155 v156
            let v158 : JSX.Element = v157.Invoke (v150, v154) |> unbox<JSX.Element>
            v158
    let struct (v160 : US1, v161 : US1, v162 : US3, v163 : US1, v164 : US1, v165 : US1, v166 : US1, v167 : US1, v168 : US1, v169 : US4, v170 : US5, v171 : US1, v172 : US1, v173 : US4, v174 : US6, v175 : US1, v176 : US1, v177 : US1, v178 : US7, v179 : US4, v180 : US1, v181 : US1, v182 : US1, v183 : US1, v184 : US1, v185 : US8, v186 : US1, v187 : US1, v188 : US1, v189 : US8, v190 : US1, v191 : US1, v192 : US1, v193 : US1, v194 : US1, v195 : US1, v196 : US1, v197 : US1, v198 : US9, v199 : US10, v200 : US9, v201 : US1, v202 : US1, v203 : US1, v204 : US1, v205 : US1, v206 : US1, v207 : US1, v208 : US1, v209 : US1, v210 : US1, v211 : US1, v212 : US1, v213 : US1, v214 : US1, v215 : US1, v216 : US8, v217 : US1, v218 : US1, v219 : US6, v220 : US1, v221 : US0, v222 : US1) = method5()
    let v223 : (unit -> (JSX.Element [])) = closure55()
    let v224 : US5 = US5_1(v223)
    let v225 : string = "1px 6px"
    let v226 : US1 = US1_1(v225)
    let v227 : Mut2 = {l0 = v160; l1 = v161; l2 = v162; l3 = v163; l4 = v164; l5 = v165; l6 = v166; l7 = v167; l8 = v168; l9 = v169; l10 = v224; l11 = v171; l12 = v172; l13 = v173; l14 = v174; l15 = v175; l16 = v176; l17 = v177; l18 = v178; l19 = v179; l20 = v180; l21 = v181; l22 = v182; l23 = v183; l24 = v184; l25 = v185; l26 = v186; l27 = v187; l28 = v188; l29 = v189; l30 = v190; l31 = v191; l32 = v192; l33 = v193; l34 = v194; l35 = v195; l36 = v196; l37 = v197; l38 = v198; l39 = v199; l40 = v200; l41 = v201; l42 = v202; l43 = v203; l44 = v226; l45 = v205; l46 = v206; l47 = v207; l48 = v208; l49 = v209; l50 = v210; l51 = v211; l52 = v212; l53 = v213; l54 = v214; l55 = v215; l56 = v216; l57 = v217; l58 = v218; l59 = v219; l60 = v220; l61 = v221; l62 = v222} : Mut2
    let v228 : (Mut5 -> JSX.Element) = closure23()
    let v229 : (obj -> JSX.Element) = v228 |> unbox<obj -> JSX.Element>
    let v230 : US11 = US11_0
    let v231 : US12 = US12_2
    let v232 : Mut5 = {l0 = v230; l1 = v227; l2 = v231} : Mut5
    let v233 : obj = v232
    let v234 : string = "createComponent"
    let v235 : string = "solid-js"
    let v236 : JS.Function = import v234 v235
    let v237 : JSX.Element = v236.Invoke (v229, v233) |> unbox<JSX.Element>
    let struct (v238 : US1, v239 : US1, v240 : US3, v241 : US1, v242 : US1, v243 : US1, v244 : US1, v245 : US1, v246 : US1, v247 : US4, v248 : US5, v249 : US1, v250 : US1, v251 : US4, v252 : US6, v253 : US1, v254 : US1, v255 : US1, v256 : US7, v257 : US4, v258 : US1, v259 : US1, v260 : US1, v261 : US1, v262 : US1, v263 : US8, v264 : US1, v265 : US1, v266 : US1, v267 : US8, v268 : US1, v269 : US1, v270 : US1, v271 : US1, v272 : US1, v273 : US1, v274 : US1, v275 : US1, v276 : US9, v277 : US10, v278 : US9, v279 : US1, v280 : US1, v281 : US1, v282 : US1, v283 : US1, v284 : US1, v285 : US1, v286 : US1, v287 : US1, v288 : US1, v289 : US1, v290 : US1, v291 : US1, v292 : US1, v293 : US1, v294 : US8, v295 : US1, v296 : US1, v297 : US6, v298 : US1, v299 : US0, v300 : US1) = method5()
    let v301 : (unit -> (JSX.Element [])) = closure56()
    let v302 : US5 = US5_1(v301)
    let v303 : US1 = US1_1(v225)
    let v304 : Mut2 = {l0 = v238; l1 = v239; l2 = v240; l3 = v241; l4 = v242; l5 = v243; l6 = v244; l7 = v245; l8 = v246; l9 = v247; l10 = v302; l11 = v249; l12 = v250; l13 = v251; l14 = v252; l15 = v253; l16 = v254; l17 = v255; l18 = v256; l19 = v257; l20 = v258; l21 = v259; l22 = v260; l23 = v261; l24 = v262; l25 = v263; l26 = v264; l27 = v265; l28 = v266; l29 = v267; l30 = v268; l31 = v269; l32 = v270; l33 = v271; l34 = v272; l35 = v273; l36 = v274; l37 = v275; l38 = v276; l39 = v277; l40 = v278; l41 = v279; l42 = v280; l43 = v281; l44 = v303; l45 = v283; l46 = v284; l47 = v285; l48 = v286; l49 = v287; l50 = v288; l51 = v289; l52 = v290; l53 = v291; l54 = v292; l55 = v293; l56 = v294; l57 = v295; l58 = v296; l59 = v297; l60 = v298; l61 = v299; l62 = v300} : Mut2
    let v305 : (obj -> JSX.Element) = v228 |> unbox<obj -> JSX.Element>
    let v306 : US11 = US11_0
    let v307 : US12 = US12_2
    let v308 : Mut5 = {l0 = v306; l1 = v304; l2 = v307} : Mut5
    let v309 : obj = v308
    let v310 : JS.Function = import v234 v235
    let v311 : JSX.Element = v310.Invoke (v305, v309) |> unbox<JSX.Element>
    [|v159; v237; v311|]
and method11 () : JSX.Element =
    let v0 : obj = emitJsExpr () "components_spi.env"
    let v1 : string = emitJsExpr v0 "$0.CODESPACE_NAME || \"\""
    let v2 : string = emitJsExpr v0 "$0.GITHUB_RUN_ID || \"\""
    let v3 : string = emitJsExpr v0 "$0.GITHUB_SHA || \"\""
    let v4 : obj = v0?IS_TEST
    let v5 : bool = emitJsExpr v4 "!$0"
    let v6 : bool = v5 = false
    let v7 : (Mut2 -> JSX.Element) = closure6()
    let v8 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    let struct (v9 : US1, v10 : US1, v11 : US3, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US1, v18 : US4, v19 : US5, v20 : US1, v21 : US1, v22 : US4, v23 : US6, v24 : US1, v25 : US1, v26 : US1, v27 : US7, v28 : US4, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US8, v35 : US1, v36 : US1, v37 : US1, v38 : US8, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US9, v48 : US10, v49 : US9, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US8, v66 : US1, v67 : US1, v68 : US6, v69 : US1, v70 : US0, v71 : US1) = method5()
    let v72 : (unit -> (JSX.Element [])) = closure12(v3)
    let v73 : US5 = US5_1(v72)
    let v74 : Mut2 = {l0 = v9; l1 = v10; l2 = v11; l3 = v12; l4 = v13; l5 = v14; l6 = v15; l7 = v16; l8 = v17; l9 = v18; l10 = v73; l11 = v20; l12 = v21; l13 = v22; l14 = v23; l15 = v24; l16 = v25; l17 = v26; l18 = v27; l19 = v28; l20 = v29; l21 = v30; l22 = v31; l23 = v32; l24 = v33; l25 = v34; l26 = v35; l27 = v36; l28 = v37; l29 = v38; l30 = v39; l31 = v40; l32 = v41; l33 = v42; l34 = v43; l35 = v44; l36 = v45; l37 = v46; l38 = v47; l39 = v48; l40 = v49; l41 = v50; l42 = v51; l43 = v52; l44 = v53; l45 = v54; l46 = v55; l47 = v56; l48 = v57; l49 = v58; l50 = v59; l51 = v60; l52 = v61; l53 = v62; l54 = v63; l55 = v64; l56 = v65; l57 = v66; l58 = v67; l59 = v68; l60 = v69; l61 = v70; l62 = v71} : Mut2
    emitJsExpr (v74, v72) "$0.children = $1"
    let v75 : obj = v74
    let v76 : string = "createComponent"
    let v77 : string = "solid-js"
    let v78 : JS.Function = import v76 v77
    let v79 : JSX.Element = v78.Invoke (v8, v75) |> unbox<JSX.Element>
    v79
and closure11 () (v0 : Mut2) : JSX.Element =
    method11()
and closure57 () () : (JSX.Element []) =
    [||]
and closure10 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure11()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure57()
    let v66 : US5 = US5_1(v65)
    let v67 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v67, v65) "$0.children = $1"
    let v68 : obj = v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v1, v68) |> unbox<JSX.Element>
    [|v72|]
and closure64 () () : (JSX.Element []) =
    let v0 : string = "Dark"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure65 () () : (JSX.Element []) =
    let v0 : string = "Light"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure63 () () : (JSX.Element []) =
    let v0 : string = "Radio"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US1, v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = method5()
    let v66 : string = "dark"
    let v67 : obj = v66
    let v68 : (unit -> (JSX.Element [])) = closure64()
    let v69 : US5 = US5_1(v68)
    let v70 : string = "neutral"
    let v71 : US1 = US1_1(v70)
    let v72 : string = "sm"
    let v73 : US1 = US1_1(v72)
    let v74 : US6 = US6_1(v67)
    let v75 : ((string * obj) []) = method7(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v69, v14, v71, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v73, v55, v56, v57, v58, v59, v60, v61, v74, v63, v64, v65)
    let v76 : obj = createObj v75
    let v77 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v78 : string = "createComponent"
    let v79 : string = "solid-js"
    let v80 : JS.Function = import v78 v79
    let v81 : JSX.Element = v80.Invoke (v77, v76) |> unbox<JSX.Element>
    let v82 : JS.Function = import v0 v1
    let struct (v83 : US1, v84 : US1, v85 : US3, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US1, v92 : US4, v93 : US5, v94 : US1, v95 : US1, v96 : US4, v97 : US6, v98 : US1, v99 : US1, v100 : US1, v101 : US7, v102 : US4, v103 : US1, v104 : US1, v105 : US1, v106 : US1, v107 : US1, v108 : US8, v109 : US1, v110 : US1, v111 : US1, v112 : US8, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US9, v122 : US10, v123 : US9, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US1, v136 : US1, v137 : US1, v138 : US1, v139 : US8, v140 : US1, v141 : US1, v142 : US6, v143 : US1, v144 : US0, v145 : US1) = method5()
    let v146 : string = "light"
    let v147 : obj = v146
    let v148 : (unit -> (JSX.Element [])) = closure65()
    let v149 : US5 = US5_1(v148)
    let v150 : US1 = US1_1(v70)
    let v151 : US1 = US1_1(v72)
    let v152 : US6 = US6_1(v147)
    let v153 : ((string * obj) []) = method7(v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v149, v94, v150, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v151, v135, v136, v137, v138, v139, v140, v141, v152, v143, v144, v145)
    let v154 : obj = createObj v153
    let v155 : (obj -> JSX.Element) = v82 |> unbox<obj -> JSX.Element>
    let v156 : JS.Function = import v78 v79
    let v157 : JSX.Element = v156.Invoke (v155, v154) |> unbox<JSX.Element>
    [|v81; v157|]
and closure62 () () : (JSX.Element []) =
    let v0 : string = "Stack"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US1, v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = method5()
    let v66 : (unit -> (JSX.Element [])) = closure63()
    let v67 : US5 = US5_1(v66)
    let v68 : string = "row"
    let v69 : US1 = US1_1(v68)
    let v70 : string = "$4"
    let v71 : US1 = US1_1(v70)
    let v72 : ((string * obj) []) = method7(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v67, v14, v15, v16, v17, v18, v69, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v71, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65)
    let v73 : obj = createObj v72
    let v74 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v75 : string = "createComponent"
    let v76 : string = "solid-js"
    let v77 : JS.Function = import v75 v76
    let v78 : JSX.Element = v77.Invoke (v74, v73) |> unbox<JSX.Element>
    [|v78|]
and closure66 (v0 : (unit -> unit)) (v1 : obj) : unit =
    v0 ()
    ()
and closure61 (v0 : (unit -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : string = "RadioGroup"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let struct (v5 : US1, v6 : US1, v7 : US3, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US4, v15 : US5, v16 : US1, v17 : US1, v18 : US4, v19 : US6, v20 : US1, v21 : US1, v22 : US1, v23 : US7, v24 : US4, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US8, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US9, v44 : US10, v45 : US9, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US8, v62 : US1, v63 : US1, v64 : US6, v65 : US1, v66 : US0, v67 : US1) = method5()
    let v68 : string = v1 ()
    let v69 : (unit -> (JSX.Element [])) = closure62()
    let v70 : US5 = US5_1(v69)
    let v71 : US1 = US1_1(v68)
    let v72 : (obj -> unit) = closure66(v0)
    let v73 : US9 = US9_1(v72)
    let v74 : ((string * obj) []) = method7(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v70, v16, v17, v18, v19, v71, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v73, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
    let v75 : obj = createObj v74
    let v76 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v77 : string = "createComponent"
    let v78 : string = "solid-js"
    let v79 : JS.Function = import v77 v78
    let v80 : JSX.Element = v79.Invoke (v76, v75) |> unbox<JSX.Element>
    [|v80|]
and closure60 (v0 : (unit -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method5()
    let v65 : string = "Theme"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : (unit -> (JSX.Element [])) = closure61(v0, v1)
    let v68 : US5 = US5_1(v67)
    let v69 : string = "5px 6px"
    let v70 : US1 = US1_1(v69)
    let v71 : US8 = US8_1(v66)
    let v72 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v68; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v70; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v71; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    let v73 : (Mut5 -> JSX.Element) = closure23()
    let v74 : (obj -> JSX.Element) = v73 |> unbox<obj -> JSX.Element>
    let v75 : US11 = US11_0
    let v76 : US12 = US12_2
    let v77 : Mut5 = {l0 = v75; l1 = v72; l2 = v76} : Mut5
    let v78 : obj = v77
    let v79 : string = "createComponent"
    let v80 : string = "solid-js"
    let v81 : JS.Function = import v79 v80
    let v82 : JSX.Element = v81.Invoke (v74, v78) |> unbox<JSX.Element>
    [|v82|]
and method20 () : JSX.Element =
    let v0 : string = "useColorMode"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : obj = v2.Invoke () |> unbox
    let v4 : (unit -> string) = v3?colorMode |> unbox
    let v5 : (unit -> unit) = v3?toggleColorMode |> unbox
    let v6 : (Mut2 -> JSX.Element) = closure6()
    let v7 : (obj -> JSX.Element) = v6 |> unbox<obj -> JSX.Element>
    let struct (v8 : US1, v9 : US1, v10 : US3, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US4, v18 : US5, v19 : US1, v20 : US1, v21 : US4, v22 : US6, v23 : US1, v24 : US1, v25 : US1, v26 : US7, v27 : US4, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US8, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US9, v47 : US10, v48 : US9, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US8, v65 : US1, v66 : US1, v67 : US6, v68 : US1, v69 : US0, v70 : US1) = method5()
    let v71 : (unit -> (JSX.Element [])) = closure60(v5, v4)
    let v72 : US5 = US5_1(v71)
    let v73 : Mut2 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v72; l11 = v19; l12 = v20; l13 = v21; l14 = v22; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v34; l27 = v35; l28 = v36; l29 = v37; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50; l43 = v51; l44 = v52; l45 = v53; l46 = v54; l47 = v55; l48 = v56; l49 = v57; l50 = v58; l51 = v59; l52 = v60; l53 = v61; l54 = v62; l55 = v63; l56 = v64; l57 = v65; l58 = v66; l59 = v67; l60 = v68; l61 = v69; l62 = v70} : Mut2
    emitJsExpr (v73, v71) "$0.children = $1"
    let v74 : obj = v73
    let v75 : string = "createComponent"
    let v76 : string = "solid-js"
    let v77 : JS.Function = import v75 v76
    let v78 : JSX.Element = v77.Invoke (v7, v74) |> unbox<JSX.Element>
    v78
and closure59 () (v0 : Mut2) : JSX.Element =
    method20()
and closure67 () () : (JSX.Element []) =
    [||]
and closure58 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure59()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure67()
    let v66 : US5 = US5_1(v65)
    let v67 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v67, v65) "$0.children = $1"
    let v68 : obj = v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v1, v68) |> unbox<JSX.Element>
    [|v72|]
and closure76 () () : (JSX.Element []) =
    [||]
and closure77 (v0 : Mut7, v1 : Mut1, v2 : JS.Function) (v3 : obj) : unit =
    let v4 : string = v3?currentTarget?value
    let v5 : ((string * obj) []) = Array.zeroCreate<(string * obj)> (0)
    let v6 : obj = createObj v5
    let v7 : Mut1 = v6 |> unbox
    let v8 : (Mut1 -> (Mut1 -> (US1 -> unit))) = v0.l1
    let v9 : (Mut1 -> (US1 -> unit)) = v8 v1
    let v10 : (US1 -> unit) = v9 v7
    let v11 : US1 = US1_1(v4)
    v10 v11
    let v12 : string = JS.JSON.stringify v7
    let v13 : string = "use_store dispatch"
    let v14 : string = "new_state(new):"
    printfn $"%A{struct (v13, v14, v12)}"
    let v15 : obj = v7
    v2.Invoke ("set", v15) |> ignore
    ()
and method23 (v0 : Mut7) : JSX.Element =
    let v1 : string = "useStoreon"
    let v2 : string = "@storeon/solidjs"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke () |> unbox<JS.Function[]>
    let v5 : Mut1 = v4.[0] |> unbox
    let v6 : JS.Function = v4.[1] |> unbox
    let v7 : string = "Input"
    let v8 : string = "@hope-ui/solid"
    let v9 : JS.Function = import v7 v8
    let struct (v10 : US1, v11 : US1, v12 : US3, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US1, v18 : US1, v19 : US4, v20 : US5, v21 : US1, v22 : US1, v23 : US4, v24 : US6, v25 : US1, v26 : US1, v27 : US1, v28 : US7, v29 : US4, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US8, v36 : US1, v37 : US1, v38 : US1, v39 : US8, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US9, v49 : US10, v50 : US9, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US8, v67 : US1, v68 : US1, v69 : US6, v70 : US1, v71 : US0, v72 : US1) = method5()
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
    let v79 : (unit -> (JSX.Element [])) = closure76()
    let v80 : US5 = US5_1(v79)
    let v81 : (obj -> unit) = closure77(v0, v5, v6)
    let v82 : US9 = US9_1(v81)
    let v83 : string = "xs"
    let v84 : US1 = US1_1(v83)
    let v85 : string = "text"
    let v86 : US1 = US1_1(v85)
    let v87 : US6 = US6_1(v78)
    let v88 : ((string * obj) []) = method7(v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v80, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v82, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v84, v62, v63, v64, v65, v66, v67, v86, v87, v70, v71, v72)
    let v89 : obj = createObj v88
    let v90 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    let v91 : string = "createComponent"
    let v92 : string = "solid-js"
    let v93 : JS.Function = import v91 v92
    let v94 : JSX.Element = v93.Invoke (v90, v89) |> unbox<JSX.Element>
    v94
and closure75 () (v0 : Mut7) : JSX.Element =
    method23(v0)
and closure78 () (v0 : Mut1) : US1 =
    let struct (v1 : (struct (string * string * string * string) []), v2 : US0, v3 : US1, v4 : US1) = v0.l0, v0.l1, v0.l2, v0.l3
    v3
and closure81 (v0 : Mut1) (v1 : US1) : unit =
    v0.l2 <- v1
    ()
and closure80 () (v0 : Mut1) : (US1 -> unit) =
    closure81(v0)
and closure79 () (v0 : Mut1) : (Mut1 -> (US1 -> unit)) =
    closure80()
and closure74 () () : (JSX.Element []) =
    let v0 : (Mut7 -> JSX.Element) = closure75()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : (Mut1 -> US1) = closure78()
    let v3 : (Mut1 -> (Mut1 -> (US1 -> unit))) = closure79()
    let v4 : Mut7 = {l0 = v2; l1 = v3} : Mut7
    let v5 : obj = v4
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v1, v5) |> unbox<JSX.Element>
    [|v9|]
and closure83 () (v0 : Mut1) : US1 =
    let struct (v1 : (struct (string * string * string * string) []), v2 : US0, v3 : US1, v4 : US1) = v0.l0, v0.l1, v0.l2, v0.l3
    v4
and closure86 (v0 : Mut1) (v1 : US1) : unit =
    v0.l3 <- v1
    ()
and closure85 () (v0 : Mut1) : (US1 -> unit) =
    closure86(v0)
and closure84 () (v0 : Mut1) : (Mut1 -> (US1 -> unit)) =
    closure85()
and closure82 () () : (JSX.Element []) =
    let v0 : (Mut7 -> JSX.Element) = closure75()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : (Mut1 -> US1) = closure83()
    let v3 : (Mut1 -> (Mut1 -> (US1 -> unit))) = closure84()
    let v4 : Mut7 = {l0 = v2; l1 = v3} : Mut7
    let v5 : obj = v4
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v1, v5) |> unbox<JSX.Element>
    [|v9|]
and closure89 (v0 : Mut8, v1 : Mut1, v2 : JS.Function) (v3 : obj) : unit =
    let v4 : int32 = v3?currentTarget?value
    let v5 : ((string * obj) []) = Array.zeroCreate<(string * obj)> (0)
    let v6 : obj = createObj v5
    let v7 : Mut1 = v6 |> unbox
    let v8 : (Mut1 -> (Mut1 -> (US0 -> unit))) = v0.l1
    let v9 : (Mut1 -> (US0 -> unit)) = v8 v1
    let v10 : (US0 -> unit) = v9 v7
    let v11 : US0 = US0_1(v4)
    v10 v11
    let v12 : string = JS.JSON.stringify v7
    let v13 : string = "use_store dispatch"
    let v14 : string = "new_state(new):"
    printfn $"%A{struct (v13, v14, v12)}"
    let v15 : obj = v7
    v2.Invoke ("set", v15) |> ignore
    ()
and method24 (v0 : Mut8) : JSX.Element =
    let v1 : string = "useStoreon"
    let v2 : string = "@storeon/solidjs"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke () |> unbox<JS.Function[]>
    let v5 : Mut1 = v4.[0] |> unbox
    let v6 : JS.Function = v4.[1] |> unbox
    let v7 : string = "Input"
    let v8 : string = "@hope-ui/solid"
    let v9 : JS.Function = import v7 v8
    let struct (v10 : US1, v11 : US1, v12 : US3, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US1, v18 : US1, v19 : US4, v20 : US5, v21 : US1, v22 : US1, v23 : US4, v24 : US6, v25 : US1, v26 : US1, v27 : US1, v28 : US7, v29 : US4, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US8, v36 : US1, v37 : US1, v38 : US1, v39 : US8, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US9, v49 : US10, v50 : US9, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US8, v67 : US1, v68 : US1, v69 : US6, v70 : US1, v71 : US0, v72 : US1) = method5()
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
    let v79 : (unit -> (JSX.Element [])) = closure76()
    let v80 : US5 = US5_1(v79)
    let v81 : (obj -> unit) = closure89(v0, v5, v6)
    let v82 : US9 = US9_1(v81)
    let v83 : string = "xs"
    let v84 : US1 = US1_1(v83)
    let v85 : string = "text"
    let v86 : US1 = US1_1(v85)
    let v87 : US6 = US6_1(v78)
    let v88 : ((string * obj) []) = method7(v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v80, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v82, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v84, v62, v63, v64, v65, v66, v67, v86, v87, v70, v71, v72)
    let v89 : obj = createObj v88
    let v90 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    let v91 : string = "createComponent"
    let v92 : string = "solid-js"
    let v93 : JS.Function = import v91 v92
    let v94 : JSX.Element = v93.Invoke (v90, v89) |> unbox<JSX.Element>
    v94
and closure88 () (v0 : Mut8) : JSX.Element =
    method24(v0)
and closure90 () (v0 : Mut1) : US0 =
    let struct (v1 : (struct (string * string * string * string) []), v2 : US0, v3 : US1, v4 : US1) = v0.l0, v0.l1, v0.l2, v0.l3
    v2
and closure93 (v0 : Mut1) (v1 : US0) : unit =
    v0.l1 <- v1
    ()
and closure92 () (v0 : Mut1) : (US0 -> unit) =
    closure93(v0)
and closure91 () (v0 : Mut1) : (Mut1 -> (US0 -> unit)) =
    closure92()
and closure87 () () : (JSX.Element []) =
    let v0 : (Mut8 -> JSX.Element) = closure88()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : (Mut1 -> US0) = closure90()
    let v3 : (Mut1 -> (Mut1 -> (US0 -> unit))) = closure91()
    let v4 : Mut8 = {l0 = v2; l1 = v3} : Mut8
    let v5 : obj = v4
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v1, v5) |> unbox<JSX.Element>
    [|v9|]
and closure73 () () : (JSX.Element []) =
    let struct (v0 : US1, v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) = method5()
    let v63 : string = "Token"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : (unit -> (JSX.Element [])) = closure74()
    let v66 : US5 = US5_1(v65)
    let v67 : string = "3px"
    let v68 : US1 = US1_1(v67)
    let v69 : US8 = US8_1(v64)
    let v70 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v66; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v68; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v69; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62} : Mut2
    let v71 : (Mut5 -> JSX.Element) = closure23()
    let v72 : (obj -> JSX.Element) = v71 |> unbox<obj -> JSX.Element>
    let v73 : US11 = US11_0
    let v74 : US12 = US12_2
    let v75 : Mut5 = {l0 = v73; l1 = v70; l2 = v74} : Mut5
    let v76 : obj = v75
    let v77 : string = "createComponent"
    let v78 : string = "solid-js"
    let v79 : JS.Function = import v77 v78
    let v80 : JSX.Element = v79.Invoke (v72, v76) |> unbox<JSX.Element>
    let struct (v81 : US1, v82 : US1, v83 : US3, v84 : US1, v85 : US1, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US4, v91 : US5, v92 : US1, v93 : US1, v94 : US4, v95 : US6, v96 : US1, v97 : US1, v98 : US1, v99 : US7, v100 : US4, v101 : US1, v102 : US1, v103 : US1, v104 : US1, v105 : US1, v106 : US8, v107 : US1, v108 : US1, v109 : US1, v110 : US8, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US9, v120 : US10, v121 : US9, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US1, v136 : US1, v137 : US8, v138 : US1, v139 : US1, v140 : US6, v141 : US1, v142 : US0, v143 : US1) = method5()
    let v144 : string = "URL"
    let v145 : JSX.Element = Html.fragment [ v144 |> unbox<JSX.Element> ]
    let v146 : (unit -> (JSX.Element [])) = closure82()
    let v147 : US5 = US5_1(v146)
    let v148 : US1 = US1_1(v67)
    let v149 : US8 = US8_1(v145)
    let v150 : Mut2 = {l0 = v81; l1 = v82; l2 = v83; l3 = v84; l4 = v85; l5 = v86; l6 = v87; l7 = v88; l8 = v89; l9 = v90; l10 = v147; l11 = v92; l12 = v93; l13 = v94; l14 = v95; l15 = v96; l16 = v97; l17 = v98; l18 = v99; l19 = v100; l20 = v101; l21 = v102; l22 = v103; l23 = v104; l24 = v105; l25 = v106; l26 = v107; l27 = v108; l28 = v109; l29 = v110; l30 = v111; l31 = v112; l32 = v113; l33 = v114; l34 = v115; l35 = v116; l36 = v117; l37 = v118; l38 = v119; l39 = v120; l40 = v121; l41 = v122; l42 = v123; l43 = v124; l44 = v148; l45 = v126; l46 = v127; l47 = v128; l48 = v129; l49 = v130; l50 = v131; l51 = v132; l52 = v133; l53 = v134; l54 = v135; l55 = v136; l56 = v149; l57 = v138; l58 = v139; l59 = v140; l60 = v141; l61 = v142; l62 = v143} : Mut2
    let v151 : (obj -> JSX.Element) = v71 |> unbox<obj -> JSX.Element>
    let v152 : US11 = US11_0
    let v153 : US12 = US12_2
    let v154 : Mut5 = {l0 = v152; l1 = v150; l2 = v153} : Mut5
    let v155 : obj = v154
    let v156 : JS.Function = import v77 v78
    let v157 : JSX.Element = v156.Invoke (v151, v155) |> unbox<JSX.Element>
    let struct (v158 : US1, v159 : US1, v160 : US3, v161 : US1, v162 : US1, v163 : US1, v164 : US1, v165 : US1, v166 : US1, v167 : US4, v168 : US5, v169 : US1, v170 : US1, v171 : US4, v172 : US6, v173 : US1, v174 : US1, v175 : US1, v176 : US7, v177 : US4, v178 : US1, v179 : US1, v180 : US1, v181 : US1, v182 : US1, v183 : US8, v184 : US1, v185 : US1, v186 : US1, v187 : US8, v188 : US1, v189 : US1, v190 : US1, v191 : US1, v192 : US1, v193 : US1, v194 : US1, v195 : US1, v196 : US9, v197 : US10, v198 : US9, v199 : US1, v200 : US1, v201 : US1, v202 : US1, v203 : US1, v204 : US1, v205 : US1, v206 : US1, v207 : US1, v208 : US1, v209 : US1, v210 : US1, v211 : US1, v212 : US1, v213 : US1, v214 : US8, v215 : US1, v216 : US1, v217 : US6, v218 : US1, v219 : US0, v220 : US1) = method5()
    let v221 : string = "Port"
    let v222 : JSX.Element = Html.fragment [ v221 |> unbox<JSX.Element> ]
    let v223 : (unit -> (JSX.Element [])) = closure87()
    let v224 : US5 = US5_1(v223)
    let v225 : US1 = US1_1(v67)
    let v226 : US8 = US8_1(v222)
    let v227 : Mut2 = {l0 = v158; l1 = v159; l2 = v160; l3 = v161; l4 = v162; l5 = v163; l6 = v164; l7 = v165; l8 = v166; l9 = v167; l10 = v224; l11 = v169; l12 = v170; l13 = v171; l14 = v172; l15 = v173; l16 = v174; l17 = v175; l18 = v176; l19 = v177; l20 = v178; l21 = v179; l22 = v180; l23 = v181; l24 = v182; l25 = v183; l26 = v184; l27 = v185; l28 = v186; l29 = v187; l30 = v188; l31 = v189; l32 = v190; l33 = v191; l34 = v192; l35 = v193; l36 = v194; l37 = v195; l38 = v196; l39 = v197; l40 = v198; l41 = v199; l42 = v200; l43 = v201; l44 = v225; l45 = v203; l46 = v204; l47 = v205; l48 = v206; l49 = v207; l50 = v208; l51 = v209; l52 = v210; l53 = v211; l54 = v212; l55 = v213; l56 = v226; l57 = v215; l58 = v216; l59 = v217; l60 = v218; l61 = v219; l62 = v220} : Mut2
    let v228 : (obj -> JSX.Element) = v71 |> unbox<obj -> JSX.Element>
    let v229 : US11 = US11_0
    let v230 : US12 = US12_2
    let v231 : Mut5 = {l0 = v229; l1 = v227; l2 = v230} : Mut5
    let v232 : obj = v231
    let v233 : JS.Function = import v77 v78
    let v234 : JSX.Element = v233.Invoke (v228, v232) |> unbox<JSX.Element>
    [|v80; v157; v234|]
and method22 () : JSX.Element =
    let v0 : (Mut2 -> JSX.Element) = closure6()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure73()
    let v66 : US5 = US5_1(v65)
    let v67 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v67, v65) "$0.children = $1"
    let v68 : obj = v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v1, v68) |> unbox<JSX.Element>
    v72
and closure72 () (v0 : Mut2) : JSX.Element =
    method22()
and closure94 () () : (JSX.Element []) =
    [||]
and closure71 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure72()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure94()
    let v66 : US5 = US5_1(v65)
    let v67 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v67, v65) "$0.children = $1"
    let v68 : obj = v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v1, v68) |> unbox<JSX.Element>
    [|v72|]
and closure102 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : US1 =
    US1_1(v0)
and closure105 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : Mut1, v5 : Mut1) (v6 : US1) : unit =
    let struct (v7 : (struct (string * string * string * string) []), v8 : US0, v9 : US1, v10 : US1) = v4.l0, v4.l1, v4.l2, v4.l3
    let v11 : int32 = v7.Length
    let v12 : (struct (string * string * string * string) []) = Array.zeroCreate<struct (string * string * string * string)> (v11)
    let v13 : Mut3 = {l0 = 0} : Mut3
    while method14(v11, v13) do
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
and closure104 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : Mut1) (v5 : Mut1) : (US1 -> unit) =
    closure105(v0, v1, v2, v3, v4, v5)
and closure103 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : (Mut1 -> (US1 -> unit)) =
    closure104(v0, v1, v2, v3, v4)
and closure101 (v0 : string, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut7 -> JSX.Element) = closure75()
    let v5 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v6 : (Mut1 -> US1) = closure102(v0, v1, v2, v3)
    let v7 : (Mut1 -> (Mut1 -> (US1 -> unit))) = closure103(v0, v1, v2, v3)
    let v8 : Mut7 = {l0 = v6; l1 = v7} : Mut7
    let v9 : obj = v8
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v5, v9) |> unbox<JSX.Element>
    [|v13|]
and closure107 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : US1 =
    US1_1(v3)
and closure110 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : Mut1, v5 : Mut1) (v6 : US1) : unit =
    let struct (v7 : (struct (string * string * string * string) []), v8 : US0, v9 : US1, v10 : US1) = v4.l0, v4.l1, v4.l2, v4.l3
    let v11 : int32 = v7.Length
    let v12 : (struct (string * string * string * string) []) = Array.zeroCreate<struct (string * string * string * string)> (v11)
    let v13 : Mut3 = {l0 = 0} : Mut3
    while method14(v11, v13) do
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
and closure109 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : Mut1) (v5 : Mut1) : (US1 -> unit) =
    closure110(v0, v1, v2, v3, v4, v5)
and closure108 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : (Mut1 -> (US1 -> unit)) =
    closure109(v0, v1, v2, v3, v4)
and closure106 (v0 : string, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut7 -> JSX.Element) = closure75()
    let v5 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v6 : (Mut1 -> US1) = closure107(v0, v1, v2, v3)
    let v7 : (Mut1 -> (Mut1 -> (US1 -> unit))) = closure108(v0, v1, v2, v3)
    let v8 : Mut7 = {l0 = v6; l1 = v7} : Mut7
    let v9 : obj = v8
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v5, v9) |> unbox<JSX.Element>
    [|v13|]
and closure100 (v0 : string, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method5()
    let v67 : string = "Address"
    let v68 : JSX.Element = Html.fragment [ v67 |> unbox<JSX.Element> ]
    let v69 : (unit -> (JSX.Element [])) = closure101(v0, v1, v2, v3)
    let v70 : US5 = US5_1(v69)
    let v71 : string = "3px"
    let v72 : US1 = US1_1(v71)
    let v73 : US8 = US8_1(v68)
    let v74 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v70; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v72; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v73; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65; l62 = v66} : Mut2
    let v75 : (Mut5 -> JSX.Element) = closure23()
    let v76 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    let v77 : US11 = US11_0
    let v78 : US12 = US12_2
    let v79 : Mut5 = {l0 = v77; l1 = v74; l2 = v78} : Mut5
    let v80 : obj = v79
    let v81 : string = "createComponent"
    let v82 : string = "solid-js"
    let v83 : JS.Function = import v81 v82
    let v84 : JSX.Element = v83.Invoke (v76, v80) |> unbox<JSX.Element>
    let struct (v85 : US1, v86 : US1, v87 : US3, v88 : US1, v89 : US1, v90 : US1, v91 : US1, v92 : US1, v93 : US1, v94 : US4, v95 : US5, v96 : US1, v97 : US1, v98 : US4, v99 : US6, v100 : US1, v101 : US1, v102 : US1, v103 : US7, v104 : US4, v105 : US1, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US8, v111 : US1, v112 : US1, v113 : US1, v114 : US8, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US9, v124 : US10, v125 : US9, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US1, v136 : US1, v137 : US1, v138 : US1, v139 : US1, v140 : US1, v141 : US8, v142 : US1, v143 : US1, v144 : US6, v145 : US1, v146 : US0, v147 : US1) = method5()
    let v148 : string = "Private Key"
    let v149 : JSX.Element = Html.fragment [ v148 |> unbox<JSX.Element> ]
    let v150 : (unit -> (JSX.Element [])) = closure106(v0, v1, v2, v3)
    let v151 : US5 = US5_1(v150)
    let v152 : US1 = US1_1(v71)
    let v153 : US8 = US8_1(v149)
    let v154 : Mut2 = {l0 = v85; l1 = v86; l2 = v87; l3 = v88; l4 = v89; l5 = v90; l6 = v91; l7 = v92; l8 = v93; l9 = v94; l10 = v151; l11 = v96; l12 = v97; l13 = v98; l14 = v99; l15 = v100; l16 = v101; l17 = v102; l18 = v103; l19 = v104; l20 = v105; l21 = v106; l22 = v107; l23 = v108; l24 = v109; l25 = v110; l26 = v111; l27 = v112; l28 = v113; l29 = v114; l30 = v115; l31 = v116; l32 = v117; l33 = v118; l34 = v119; l35 = v120; l36 = v121; l37 = v122; l38 = v123; l39 = v124; l40 = v125; l41 = v126; l42 = v127; l43 = v128; l44 = v152; l45 = v130; l46 = v131; l47 = v132; l48 = v133; l49 = v134; l50 = v135; l51 = v136; l52 = v137; l53 = v138; l54 = v139; l55 = v140; l56 = v153; l57 = v142; l58 = v143; l59 = v144; l60 = v145; l61 = v146; l62 = v147} : Mut2
    let v155 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    let v156 : US11 = US11_0
    let v157 : US12 = US12_2
    let v158 : Mut5 = {l0 = v156; l1 = v154; l2 = v157} : Mut5
    let v159 : obj = v158
    let v160 : JS.Function = import v81 v82
    let v161 : JSX.Element = v160.Invoke (v155, v159) |> unbox<JSX.Element>
    [|v84; v161|]
and closure99 (v0 : string, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut2 -> JSX.Element) = closure6()
    let v5 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let struct (v6 : US1, v7 : US1, v8 : US3, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US4, v16 : US5, v17 : US1, v18 : US1, v19 : US4, v20 : US6, v21 : US1, v22 : US1, v23 : US1, v24 : US7, v25 : US4, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US8, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US9, v45 : US10, v46 : US9, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US8, v63 : US1, v64 : US1, v65 : US6, v66 : US1, v67 : US0, v68 : US1) = method5()
    let v69 : (unit -> (JSX.Element [])) = closure100(v0, v1, v2, v3)
    let v70 : US5 = US5_1(v69)
    let v71 : Mut2 = {l0 = v6; l1 = v7; l2 = v8; l3 = v9; l4 = v10; l5 = v11; l6 = v12; l7 = v13; l8 = v14; l9 = v15; l10 = v70; l11 = v17; l12 = v18; l13 = v19; l14 = v20; l15 = v21; l16 = v22; l17 = v23; l18 = v24; l19 = v25; l20 = v26; l21 = v27; l22 = v28; l23 = v29; l24 = v30; l25 = v31; l26 = v32; l27 = v33; l28 = v34; l29 = v35; l30 = v36; l31 = v37; l32 = v38; l33 = v39; l34 = v40; l35 = v41; l36 = v42; l37 = v43; l38 = v44; l39 = v45; l40 = v46; l41 = v47; l42 = v48; l43 = v49; l44 = v50; l45 = v51; l46 = v52; l47 = v53; l48 = v54; l49 = v55; l50 = v56; l51 = v57; l52 = v58; l53 = v59; l54 = v60; l55 = v61; l56 = v62; l57 = v63; l58 = v64; l59 = v65; l60 = v66; l61 = v67; l62 = v68} : Mut2
    emitJsExpr (v71, v69) "$0.children = $1"
    let v72 : obj = v71
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v5, v72) |> unbox<JSX.Element>
    [|v76|]
and closure98 () struct (v0 : string, v1 : string, v2 : string, v3 : string) : (JSX.Element []) =
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method5()
    let v67 : JSX.Element = Html.fragment [ v1 |> unbox<JSX.Element> ]
    let v68 : (unit -> (JSX.Element [])) = closure99(v0, v1, v2, v3)
    let v69 : US5 = US5_1(v68)
    let v70 : US8 = US8_1(v67)
    let v71 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v69; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v23; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v70; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65; l62 = v66} : Mut2
    let v72 : (Mut5 -> JSX.Element) = closure23()
    let v73 : (obj -> JSX.Element) = v72 |> unbox<obj -> JSX.Element>
    let v74 : US11 = US11_0
    let v75 : US12 = US12_2
    let v76 : Mut5 = {l0 = v74; l1 = v71; l2 = v75} : Mut5
    let v77 : obj = v76
    let v78 : string = "createComponent"
    let v79 : string = "solid-js"
    let v80 : JS.Function = import v78 v79
    let v81 : JSX.Element = v80.Invoke (v73, v77) |> unbox<JSX.Element>
    [|v81|]
and closure97 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (string * string * string * string) []), v2 : US0, v3 : US1, v4 : US1) = v0.l0, v0.l1, v0.l2, v0.l3
    let v5 : string = "For"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (struct (string * string * string * string) -> (JSX.Element [])) = closure98()
    let v9 : (unit -> (JSX.Element [])) = v8 |> unbox
    let struct (v10 : US1, v11 : US1, v12 : US3, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US1, v18 : US1, v19 : US4, v20 : US5, v21 : US1, v22 : US1, v23 : US4, v24 : US6, v25 : US1, v26 : US1, v27 : US1, v28 : US7, v29 : US4, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US8, v36 : US1, v37 : US1, v38 : US1, v39 : US8, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US9, v49 : US10, v50 : US9, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US8, v67 : US1, v68 : US1, v69 : US6, v70 : US1, v71 : US0, v72 : US1) = method5()
    let v73 : (obj []) = v1 |> unbox<obj[]>
    let v74 : US5 = US5_1(v9)
    let v75 : US7 = US7_1(v73)
    let v76 : ((string * obj) []) = method7(v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v74, v21, v22, v23, v24, v25, v26, v27, v75, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v77 : obj = createObj v76
    let v78 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    let v79 : string = "createComponent"
    let v80 : JS.Function = import v79 v6
    let v81 : JSX.Element = v80.Invoke (v78, v77) |> unbox<JSX.Element>
    [|v81|]
and method25 () : JSX.Element =
    let v0 : string = "useStoreon"
    let v1 : string = "@storeon/solidjs"
    let v2 : JS.Function = import v0 v1
    let v3 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v4 : Mut1 = v3.[0] |> unbox
    let v5 : JS.Function = v3.[1] |> unbox
    let v6 : (Mut2 -> JSX.Element) = closure6()
    let v7 : (obj -> JSX.Element) = v6 |> unbox<obj -> JSX.Element>
    let struct (v8 : US1, v9 : US1, v10 : US3, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US4, v18 : US5, v19 : US1, v20 : US1, v21 : US4, v22 : US6, v23 : US1, v24 : US1, v25 : US1, v26 : US7, v27 : US4, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US8, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US9, v47 : US10, v48 : US9, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US8, v65 : US1, v66 : US1, v67 : US6, v68 : US1, v69 : US0, v70 : US1) = method5()
    let v71 : (unit -> (JSX.Element [])) = closure97(v4)
    let v72 : US5 = US5_1(v71)
    let v73 : Mut2 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v72; l11 = v19; l12 = v20; l13 = v21; l14 = v22; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v34; l27 = v35; l28 = v36; l29 = v37; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50; l43 = v51; l44 = v52; l45 = v53; l46 = v54; l47 = v55; l48 = v56; l49 = v57; l50 = v58; l51 = v59; l52 = v60; l53 = v61; l54 = v62; l55 = v63; l56 = v64; l57 = v65; l58 = v66; l59 = v67; l60 = v68; l61 = v69; l62 = v70} : Mut2
    emitJsExpr (v73, v71) "$0.children = $1"
    let v74 : obj = v73
    let v75 : string = "createComponent"
    let v76 : string = "solid-js"
    let v77 : JS.Function = import v75 v76
    let v78 : JSX.Element = v77.Invoke (v7, v74) |> unbox<JSX.Element>
    v78
and closure96 () (v0 : Mut2) : JSX.Element =
    method25()
and closure111 () () : (JSX.Element []) =
    [||]
and closure95 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure96()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure111()
    let v66 : US5 = US5_1(v65)
    let v67 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v67, v65) "$0.children = $1"
    let v68 : obj = v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v1, v68) |> unbox<JSX.Element>
    [|v72|]
and closure113 () () : (JSX.Element []) =
    [||]
and closure112 () () : (JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : JS.Function = v2?iframe
    let struct (v4 : US1, v5 : US1, v6 : US3, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US4, v14 : US5, v15 : US1, v16 : US1, v17 : US4, v18 : US6, v19 : US1, v20 : US1, v21 : US1, v22 : US7, v23 : US4, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US8, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US9, v43 : US10, v44 : US9, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US8, v61 : US1, v62 : US1, v63 : US6, v64 : US1, v65 : US0, v66 : US1) = method5()
    let v67 : string = "algorand testnet bank"
    let v68 : JSX.Element = Html.fragment [ v67 |> unbox<JSX.Element> ]
    let v69 : string = "#aaa"
    let v70 : US1 = US1_1(v69)
    let v71 : (unit -> (JSX.Element [])) = closure113()
    let v72 : US5 = US5_1(v71)
    let v73 : string = "1"
    let v74 : US1 = US1_1(v73)
    let v75 : string = "350px"
    let v76 : US1 = US1_1(v75)
    let v77 : string = "https://bank.testnet.algorand.network"
    let v78 : US1 = US1_1(v77)
    let v79 : US8 = US8_1(v68)
    let v80 : ((string * obj) []) = method7(v4, v5, v6, v70, v8, v9, v10, v11, v12, v13, v72, v15, v16, v17, v18, v19, v20, v21, v22, v23, v74, v25, v26, v76, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v78, v58, v59, v79, v61, v62, v63, v64, v65, v66)
    let v81 : obj = createObj v80
    let v82 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v83 : string = "createComponent"
    let v84 : string = "solid-js"
    let v85 : JS.Function = import v83 v84
    let v86 : JSX.Element = v85.Invoke (v82, v81) |> unbox<JSX.Element>
    [|v86|]
and closure70 () () : (JSX.Element []) =
    let struct (v0 : US1, v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) = method5()
    let v63 : string = "Connection"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : (unit -> (JSX.Element [])) = closure71()
    let v66 : US5 = US5_1(v65)
    let v67 : US8 = US8_1(v64)
    let v68 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v66; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v26; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v67; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62} : Mut2
    let v69 : (Mut5 -> JSX.Element) = closure23()
    let v70 : (obj -> JSX.Element) = v69 |> unbox<obj -> JSX.Element>
    let v71 : US11 = US11_0
    let v72 : US12 = US12_2
    let v73 : Mut5 = {l0 = v71; l1 = v68; l2 = v72} : Mut5
    let v74 : obj = v73
    let v75 : string = "createComponent"
    let v76 : string = "solid-js"
    let v77 : JS.Function = import v75 v76
    let v78 : JSX.Element = v77.Invoke (v70, v74) |> unbox<JSX.Element>
    let struct (v79 : US1, v80 : US1, v81 : US3, v82 : US1, v83 : US1, v84 : US1, v85 : US1, v86 : US1, v87 : US1, v88 : US4, v89 : US5, v90 : US1, v91 : US1, v92 : US4, v93 : US6, v94 : US1, v95 : US1, v96 : US1, v97 : US7, v98 : US4, v99 : US1, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US8, v105 : US1, v106 : US1, v107 : US1, v108 : US8, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US9, v118 : US10, v119 : US9, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US8, v136 : US1, v137 : US1, v138 : US6, v139 : US1, v140 : US0, v141 : US1) = method5()
    let v142 : string = "Accounts"
    let v143 : JSX.Element = Html.fragment [ v142 |> unbox<JSX.Element> ]
    let v144 : (unit -> (JSX.Element [])) = closure95()
    let v145 : US5 = US5_1(v144)
    let v146 : US8 = US8_1(v143)
    let v147 : Mut2 = {l0 = v79; l1 = v80; l2 = v81; l3 = v82; l4 = v83; l5 = v84; l6 = v85; l7 = v86; l8 = v87; l9 = v88; l10 = v145; l11 = v90; l12 = v91; l13 = v92; l14 = v93; l15 = v94; l16 = v95; l17 = v96; l18 = v97; l19 = v98; l20 = v99; l21 = v100; l22 = v101; l23 = v102; l24 = v103; l25 = v104; l26 = v105; l27 = v106; l28 = v107; l29 = v108; l30 = v109; l31 = v110; l32 = v111; l33 = v112; l34 = v113; l35 = v114; l36 = v115; l37 = v116; l38 = v117; l39 = v118; l40 = v119; l41 = v120; l42 = v121; l43 = v122; l44 = v123; l45 = v124; l46 = v125; l47 = v126; l48 = v127; l49 = v128; l50 = v129; l51 = v130; l52 = v131; l53 = v132; l54 = v133; l55 = v134; l56 = v146; l57 = v136; l58 = v137; l59 = v138; l60 = v139; l61 = v140; l62 = v141} : Mut2
    let v148 : (obj -> JSX.Element) = v69 |> unbox<obj -> JSX.Element>
    let v149 : US11 = US11_0
    let v150 : US12 = US12_2
    let v151 : Mut5 = {l0 = v149; l1 = v147; l2 = v150} : Mut5
    let v152 : obj = v151
    let v153 : JS.Function = import v75 v76
    let v154 : JSX.Element = v153.Invoke (v148, v152) |> unbox<JSX.Element>
    let struct (v155 : US1, v156 : US1, v157 : US3, v158 : US1, v159 : US1, v160 : US1, v161 : US1, v162 : US1, v163 : US1, v164 : US4, v165 : US5, v166 : US1, v167 : US1, v168 : US4, v169 : US6, v170 : US1, v171 : US1, v172 : US1, v173 : US7, v174 : US4, v175 : US1, v176 : US1, v177 : US1, v178 : US1, v179 : US1, v180 : US8, v181 : US1, v182 : US1, v183 : US1, v184 : US8, v185 : US1, v186 : US1, v187 : US1, v188 : US1, v189 : US1, v190 : US1, v191 : US1, v192 : US1, v193 : US9, v194 : US10, v195 : US9, v196 : US1, v197 : US1, v198 : US1, v199 : US1, v200 : US1, v201 : US1, v202 : US1, v203 : US1, v204 : US1, v205 : US1, v206 : US1, v207 : US1, v208 : US1, v209 : US1, v210 : US1, v211 : US8, v212 : US1, v213 : US1, v214 : US6, v215 : US1, v216 : US0, v217 : US1) = method5()
    let v218 : string = "Testnet Bank Dispenser"
    let v219 : JSX.Element = Html.fragment [ v218 |> unbox<JSX.Element> ]
    let v220 : (unit -> (JSX.Element [])) = closure112()
    let v221 : US5 = US5_1(v220)
    let v222 : US8 = US8_1(v219)
    let v223 : Mut2 = {l0 = v155; l1 = v156; l2 = v157; l3 = v158; l4 = v159; l5 = v160; l6 = v161; l7 = v162; l8 = v163; l9 = v164; l10 = v221; l11 = v166; l12 = v167; l13 = v168; l14 = v169; l15 = v170; l16 = v171; l17 = v172; l18 = v173; l19 = v174; l20 = v175; l21 = v176; l22 = v177; l23 = v178; l24 = v179; l25 = v180; l26 = v181; l27 = v182; l28 = v183; l29 = v184; l30 = v185; l31 = v186; l32 = v187; l33 = v188; l34 = v189; l35 = v190; l36 = v191; l37 = v192; l38 = v193; l39 = v194; l40 = v195; l41 = v196; l42 = v197; l43 = v198; l44 = v199; l45 = v200; l46 = v201; l47 = v202; l48 = v203; l49 = v204; l50 = v205; l51 = v206; l52 = v207; l53 = v208; l54 = v209; l55 = v210; l56 = v222; l57 = v212; l58 = v213; l59 = v214; l60 = v215; l61 = v216; l62 = v217} : Mut2
    let v224 : (obj -> JSX.Element) = v69 |> unbox<obj -> JSX.Element>
    let v225 : US11 = US11_0
    let v226 : US12 = US12_0
    let v227 : Mut5 = {l0 = v225; l1 = v223; l2 = v226} : Mut5
    let v228 : obj = v227
    let v229 : JS.Function = import v75 v76
    let v230 : JSX.Element = v229.Invoke (v224, v228) |> unbox<JSX.Element>
    [|v78; v154; v230|]
and method21 () : JSX.Element =
    let v0 : (Mut2 -> JSX.Element) = closure6()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure70()
    let v66 : US5 = US5_1(v65)
    let v67 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v67, v65) "$0.children = $1"
    let v68 : obj = v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v1, v68) |> unbox<JSX.Element>
    v72
and closure69 () (v0 : Mut2) : JSX.Element =
    method21()
and closure114 () () : (JSX.Element []) =
    [||]
and closure68 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure69()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure114()
    let v66 : US5 = US5_1(v65)
    let v67 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v67, v65) "$0.children = $1"
    let v68 : obj = v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v1, v68) |> unbox<JSX.Element>
    [|v72|]
and method29 (v0 : int32, v1 : Mut11) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure123 (v0 : Mut10) (v1 : Mut1) : US1 =
    let struct (v2 : (struct (US2 * int32 * string * string) []), v3 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let v4 : int32 = v2.Length
    let v5 : US1 = US1_0
    let v6 : Mut11 = {l0 = 0; l1 = v5} : Mut11
    while method29(v4, v6) do
        let v8 : int32 = v6.l0
        let v9 : int32 =  -v8
        let v10 : int32 = v9 + v4
        let v11 : int32 = v10 - 1
        let v12 : US1 = v6.l1
        let struct (v13 : US2, v14 : int32, v15 : string, v16 : string) = v2.[int v11]
        let v24 : US1 =
            match v12 with
            | US1_0 -> (* None *)
                let v17 : US2 = v0.l0
                let v18 : bool =
                    match v13, v17 with
                    | US2_0, US2_0 -> (* GunJs *)
                        true
                    | US2_1, US2_1 -> (* GunRs *)
                        true
                    | _ ->
                        false
                if v18 then
                    let v19 : (struct (US2 * int32 * string * string) -> US1) = v0.l1
                    let v20 : US1 = v19 struct (v13, v14, v15, v16)
                    v20
                else
                    US1_0
            | US1_1(v23) -> (* Some *)
                v12
        let v25 : int32 = v8 + 1
        v6.l0 <- v25
        v6.l1 <- v24
        ()
    let v26 : US1 = v6.l1
    v26
and method30 (v0 : int32, v1 : Mut12) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method31 () : struct (US2 * int32 * string * string) =
    let v0 : US2 = US2_1
    let v1 : string = ""
    struct (v0, 0, v1, v1)
and closure126 (v0 : Mut10, v1 : Mut1, v2 : Mut1) (v3 : US1) : unit =
    let struct (v4 : (struct (US2 * int32 * string * string) []), v5 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let struct (v6 : (struct (US2 * int32 * string * string) []), v7 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let v8 : int32 = v6.Length
    let v9 : US13 = US13_0
    let v10 : Mut12 = {l0 = 0; l1 = v9} : Mut12
    while method30(v8, v10) do
        let v12 : int32 = v10.l0
        let v13 : int32 =  -v12
        let v14 : int32 = v13 + v8
        let v15 : int32 = v14 - 1
        let v16 : US13 = v10.l1
        let struct (v17 : US2, v18 : int32, v19 : string, v20 : string) = v6.[int v15]
        let v30 : US13 =
            match v16 with
            | US13_0 -> (* None *)
                let v21 : US2 = v0.l0
                let v22 : bool =
                    match v17, v21 with
                    | US2_0, US2_0 -> (* GunJs *)
                        true
                    | US2_1, US2_1 -> (* GunRs *)
                        true
                    | _ ->
                        false
                if v22 then
                    US13_1(v17, v18, v19, v20)
                else
                    US13_0
            | US13_1(v26, v27, v28, v29) -> (* Some *)
                v16
        let v31 : int32 = v12 + 1
        v10.l0 <- v31
        v10.l1 <- v30
        ()
    let v32 : US13 = v10.l1
    let struct (v33 : US2, v34 : int32, v35 : string, v36 : string) = method31()
    let struct (v41 : US2, v42 : int32, v43 : string, v44 : string) =
        match v32 with
        | US13_0 -> (* None *)
            struct (v33, v34, v35, v36)
        | US13_1(v37, v38, v39, v40) -> (* Some *)
            struct (v37, v38, v39, v40)
    let v45 : (struct (US2 * int32 * string * string) -> (US1 -> struct (US2 * int32 * string * string))) = v0.l2
    let v46 : (US1 -> struct (US2 * int32 * string * string)) = v45 struct (v41, v42, v43, v44)
    let struct (v47 : US2, v48 : int32, v49 : string, v50 : string) = v46 v3
    let v51 : (struct (US2 * int32 * string * string) []) = [|struct (v47, v48, v49, v50)|]
    let v52 : int32 = v4.Length
    let v53 : int32 = v51.Length
    let v54 : int32 = v52 + v53
    let v55 : (struct (US2 * int32 * string * string) []) = Array.zeroCreate<struct (US2 * int32 * string * string)> (v54)
    let v56 : Mut3 = {l0 = 0} : Mut3
    while method14(v54, v56) do
        let v58 : int32 = v56.l0
        let v59 : bool = v58 < v52
        let struct (v69 : US2, v70 : int32, v71 : string, v72 : string) =
            if v59 then
                let struct (v60 : US2, v61 : int32, v62 : string, v63 : string) = v4.[int v58]
                struct (v60, v61, v62, v63)
            else
                let v64 : int32 = v58 - v52
                let struct (v65 : US2, v66 : int32, v67 : string, v68 : string) = v51.[int v64]
                struct (v65, v66, v67, v68)
        v55.[int v58] <- struct (v69, v70, v71, v72)
        let v73 : int32 = v58 + 1
        v56.l0 <- v73
        ()
    v2.l4 <- v55
    ()
and closure125 (v0 : Mut10, v1 : Mut1) (v2 : Mut1) : (US1 -> unit) =
    closure126(v0, v1, v2)
and closure124 (v0 : Mut10) (v1 : Mut1) : (Mut1 -> (US1 -> unit)) =
    closure125(v0, v1)
and method28 (v0 : Mut10) : JSX.Element =
    let v1 : (Mut7 -> JSX.Element) = closure75()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let v3 : (Mut1 -> US1) = closure123(v0)
    let v4 : (Mut1 -> (Mut1 -> (US1 -> unit))) = closure124(v0)
    let v5 : Mut7 = {l0 = v3; l1 = v4} : Mut7
    let v6 : obj = v5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v2, v6) |> unbox<JSX.Element>
    v10
and closure122 () (v0 : Mut10) : JSX.Element =
    method28(v0)
and closure127 () struct (v0 : US2, v1 : int32, v2 : string, v3 : string) : US1 =
    US1_1(v2)
and closure129 (v0 : Mut9, v1 : US2, v2 : int32, v3 : string, v4 : string) (v5 : US1) : struct (US2 * int32 * string * string) =
    let v6 : US2 = v0.l0
    let v9 : string =
        match v5 with
        | US1_0 -> (* None *)
            let v7 : string = ""
            v7
        | US1_1(v8) -> (* Some *)
            v8
    struct (v6, v2, v9, v4)
and closure128 (v0 : Mut9) struct (v1 : US2, v2 : int32, v3 : string, v4 : string) : (US1 -> struct (US2 * int32 * string * string)) =
    closure129(v0, v1, v2, v3, v4)
and closure121 (v0 : Mut9) () : (JSX.Element []) =
    let v1 : US2 = v0.l0
    let v2 : (Mut10 -> JSX.Element) = closure122()
    let v3 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v4 : (struct (US2 * int32 * string * string) -> US1) = closure127()
    let v5 : (struct (US2 * int32 * string * string) -> (US1 -> struct (US2 * int32 * string * string))) = closure128(v0)
    let v6 : Mut10 = {l0 = v1; l1 = v4; l2 = v5} : Mut10
    let v7 : obj = v6
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v3, v7) |> unbox<JSX.Element>
    [|v11|]
and method33 (v0 : int32, v1 : Mut14) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure132 (v0 : Mut13) (v1 : Mut1) : US0 =
    let struct (v2 : (struct (US2 * int32 * string * string) []), v3 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let v4 : int32 = v2.Length
    let v5 : US0 = US0_0
    let v6 : Mut14 = {l0 = 0; l1 = v5} : Mut14
    while method33(v4, v6) do
        let v8 : int32 = v6.l0
        let v9 : int32 =  -v8
        let v10 : int32 = v9 + v4
        let v11 : int32 = v10 - 1
        let v12 : US0 = v6.l1
        let struct (v13 : US2, v14 : int32, v15 : string, v16 : string) = v2.[int v11]
        let v24 : US0 =
            match v12 with
            | US0_0 -> (* None *)
                let v17 : US2 = v0.l0
                let v18 : bool =
                    match v13, v17 with
                    | US2_0, US2_0 -> (* GunJs *)
                        true
                    | US2_1, US2_1 -> (* GunRs *)
                        true
                    | _ ->
                        false
                if v18 then
                    let v19 : (struct (US2 * int32 * string * string) -> US0) = v0.l1
                    let v20 : US0 = v19 struct (v13, v14, v15, v16)
                    v20
                else
                    US0_0
            | US0_1(v23) -> (* Some *)
                v12
        let v25 : int32 = v8 + 1
        v6.l0 <- v25
        v6.l1 <- v24
        ()
    let v26 : US0 = v6.l1
    v26
and closure135 (v0 : Mut13, v1 : Mut1, v2 : Mut1) (v3 : US0) : unit =
    let struct (v4 : (struct (US2 * int32 * string * string) []), v5 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let struct (v6 : (struct (US2 * int32 * string * string) []), v7 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let v8 : int32 = v6.Length
    let v9 : US13 = US13_0
    let v10 : Mut12 = {l0 = 0; l1 = v9} : Mut12
    while method30(v8, v10) do
        let v12 : int32 = v10.l0
        let v13 : int32 =  -v12
        let v14 : int32 = v13 + v8
        let v15 : int32 = v14 - 1
        let v16 : US13 = v10.l1
        let struct (v17 : US2, v18 : int32, v19 : string, v20 : string) = v6.[int v15]
        let v30 : US13 =
            match v16 with
            | US13_0 -> (* None *)
                let v21 : US2 = v0.l0
                let v22 : bool =
                    match v17, v21 with
                    | US2_0, US2_0 -> (* GunJs *)
                        true
                    | US2_1, US2_1 -> (* GunRs *)
                        true
                    | _ ->
                        false
                if v22 then
                    US13_1(v17, v18, v19, v20)
                else
                    US13_0
            | US13_1(v26, v27, v28, v29) -> (* Some *)
                v16
        let v31 : int32 = v12 + 1
        v10.l0 <- v31
        v10.l1 <- v30
        ()
    let v32 : US13 = v10.l1
    let struct (v33 : US2, v34 : int32, v35 : string, v36 : string) = method31()
    let struct (v41 : US2, v42 : int32, v43 : string, v44 : string) =
        match v32 with
        | US13_0 -> (* None *)
            struct (v33, v34, v35, v36)
        | US13_1(v37, v38, v39, v40) -> (* Some *)
            struct (v37, v38, v39, v40)
    let v45 : (struct (US2 * int32 * string * string) -> (US0 -> struct (US2 * int32 * string * string))) = v0.l2
    let v46 : (US0 -> struct (US2 * int32 * string * string)) = v45 struct (v41, v42, v43, v44)
    let struct (v47 : US2, v48 : int32, v49 : string, v50 : string) = v46 v3
    let v51 : (struct (US2 * int32 * string * string) []) = [|struct (v47, v48, v49, v50)|]
    let v52 : int32 = v4.Length
    let v53 : int32 = v51.Length
    let v54 : int32 = v52 + v53
    let v55 : (struct (US2 * int32 * string * string) []) = Array.zeroCreate<struct (US2 * int32 * string * string)> (v54)
    let v56 : Mut3 = {l0 = 0} : Mut3
    while method14(v54, v56) do
        let v58 : int32 = v56.l0
        let v59 : bool = v58 < v52
        let struct (v69 : US2, v70 : int32, v71 : string, v72 : string) =
            if v59 then
                let struct (v60 : US2, v61 : int32, v62 : string, v63 : string) = v4.[int v58]
                struct (v60, v61, v62, v63)
            else
                let v64 : int32 = v58 - v52
                let struct (v65 : US2, v66 : int32, v67 : string, v68 : string) = v51.[int v64]
                struct (v65, v66, v67, v68)
        v55.[int v58] <- struct (v69, v70, v71, v72)
        let v73 : int32 = v58 + 1
        v56.l0 <- v73
        ()
    v2.l4 <- v55
    ()
and closure134 (v0 : Mut13, v1 : Mut1) (v2 : Mut1) : (US0 -> unit) =
    closure135(v0, v1, v2)
and closure133 (v0 : Mut13) (v1 : Mut1) : (Mut1 -> (US0 -> unit)) =
    closure134(v0, v1)
and method32 (v0 : Mut13) : JSX.Element =
    let v1 : (Mut8 -> JSX.Element) = closure88()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let v3 : (Mut1 -> US0) = closure132(v0)
    let v4 : (Mut1 -> (Mut1 -> (US0 -> unit))) = closure133(v0)
    let v5 : Mut8 = {l0 = v3; l1 = v4} : Mut8
    let v6 : obj = v5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v2, v6) |> unbox<JSX.Element>
    v10
and closure131 () (v0 : Mut13) : JSX.Element =
    method32(v0)
and closure136 () struct (v0 : US2, v1 : int32, v2 : string, v3 : string) : US0 =
    US0_1(v1)
and closure138 (v0 : Mut9, v1 : US2, v2 : int32, v3 : string, v4 : string) (v5 : US0) : struct (US2 * int32 * string * string) =
    let v6 : US2 = v0.l0
    let v8 : int32 =
        match v5 with
        | US0_0 -> (* None *)
            0
        | US0_1(v7) -> (* Some *)
            v7
    struct (v6, v8, v3, v4)
and closure137 (v0 : Mut9) struct (v1 : US2, v2 : int32, v3 : string, v4 : string) : (US0 -> struct (US2 * int32 * string * string)) =
    closure138(v0, v1, v2, v3, v4)
and closure130 (v0 : Mut9) () : (JSX.Element []) =
    let v1 : US2 = v0.l0
    let v2 : (Mut13 -> JSX.Element) = closure131()
    let v3 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v4 : (struct (US2 * int32 * string * string) -> US0) = closure136()
    let v5 : (struct (US2 * int32 * string * string) -> (US0 -> struct (US2 * int32 * string * string))) = closure137(v0)
    let v6 : Mut13 = {l0 = v1; l1 = v4; l2 = v5} : Mut13
    let v7 : obj = v6
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v3, v7) |> unbox<JSX.Element>
    [|v11|]
and closure120 (v0 : Mut9) () : (JSX.Element []) =
    let struct (v1 : US1, v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method5()
    let v64 : string = "URL"
    let v65 : JSX.Element = Html.fragment [ v64 |> unbox<JSX.Element> ]
    let v66 : (unit -> (JSX.Element [])) = closure121(v0)
    let v67 : US5 = US5_1(v66)
    let v68 : string = "3px"
    let v69 : US1 = US1_1(v68)
    let v70 : US8 = US8_1(v65)
    let v71 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v67; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v69; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v70; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63} : Mut2
    let v72 : (Mut5 -> JSX.Element) = closure23()
    let v73 : (obj -> JSX.Element) = v72 |> unbox<obj -> JSX.Element>
    let v74 : US11 = US11_0
    let v75 : US12 = US12_2
    let v76 : Mut5 = {l0 = v74; l1 = v71; l2 = v75} : Mut5
    let v77 : obj = v76
    let v78 : string = "createComponent"
    let v79 : string = "solid-js"
    let v80 : JS.Function = import v78 v79
    let v81 : JSX.Element = v80.Invoke (v73, v77) |> unbox<JSX.Element>
    let struct (v82 : US1, v83 : US1, v84 : US3, v85 : US1, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US4, v92 : US5, v93 : US1, v94 : US1, v95 : US4, v96 : US6, v97 : US1, v98 : US1, v99 : US1, v100 : US7, v101 : US4, v102 : US1, v103 : US1, v104 : US1, v105 : US1, v106 : US1, v107 : US8, v108 : US1, v109 : US1, v110 : US1, v111 : US8, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US9, v121 : US10, v122 : US9, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US1, v136 : US1, v137 : US1, v138 : US8, v139 : US1, v140 : US1, v141 : US6, v142 : US1, v143 : US0, v144 : US1) = method5()
    let v145 : string = "Port"
    let v146 : JSX.Element = Html.fragment [ v145 |> unbox<JSX.Element> ]
    let v147 : (unit -> (JSX.Element [])) = closure130(v0)
    let v148 : US5 = US5_1(v147)
    let v149 : US1 = US1_1(v68)
    let v150 : US8 = US8_1(v146)
    let v151 : Mut2 = {l0 = v82; l1 = v83; l2 = v84; l3 = v85; l4 = v86; l5 = v87; l6 = v88; l7 = v89; l8 = v90; l9 = v91; l10 = v148; l11 = v93; l12 = v94; l13 = v95; l14 = v96; l15 = v97; l16 = v98; l17 = v99; l18 = v100; l19 = v101; l20 = v102; l21 = v103; l22 = v104; l23 = v105; l24 = v106; l25 = v107; l26 = v108; l27 = v109; l28 = v110; l29 = v111; l30 = v112; l31 = v113; l32 = v114; l33 = v115; l34 = v116; l35 = v117; l36 = v118; l37 = v119; l38 = v120; l39 = v121; l40 = v122; l41 = v123; l42 = v124; l43 = v125; l44 = v149; l45 = v127; l46 = v128; l47 = v129; l48 = v130; l49 = v131; l50 = v132; l51 = v133; l52 = v134; l53 = v135; l54 = v136; l55 = v137; l56 = v150; l57 = v139; l58 = v140; l59 = v141; l60 = v142; l61 = v143; l62 = v144} : Mut2
    let v152 : (obj -> JSX.Element) = v72 |> unbox<obj -> JSX.Element>
    let v153 : US11 = US11_0
    let v154 : US12 = US12_2
    let v155 : Mut5 = {l0 = v153; l1 = v151; l2 = v154} : Mut5
    let v156 : obj = v155
    let v157 : JS.Function = import v78 v79
    let v158 : JSX.Element = v157.Invoke (v152, v156) |> unbox<JSX.Element>
    [|v81; v158|]
and method27 (v0 : Mut9) : JSX.Element =
    let v1 : (Mut2 -> JSX.Element) = closure6()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let struct (v3 : US1, v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = method5()
    let v66 : (unit -> (JSX.Element [])) = closure120(v0)
    let v67 : US5 = US5_1(v66)
    let v68 : Mut2 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v67; l11 = v14; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v47; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v59; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64; l62 = v65} : Mut2
    emitJsExpr (v68, v66) "$0.children = $1"
    let v69 : obj = v68
    let v70 : string = "createComponent"
    let v71 : string = "solid-js"
    let v72 : JS.Function = import v70 v71
    let v73 : JSX.Element = v72.Invoke (v2, v69) |> unbox<JSX.Element>
    v73
and closure119 () (v0 : Mut9) : JSX.Element =
    method27(v0)
and closure118 () () : (JSX.Element []) =
    let v0 : (Mut9 -> JSX.Element) = closure119()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : US2 = US2_1
    let v3 : Mut9 = {l0 = v2} : Mut9
    let v4 : obj = v3
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v1, v4) |> unbox<JSX.Element>
    [|v8|]
and closure142 (v0 : Mut1) (v1 : Mut1) : unit =
    let v2 : string = JS.JSON.stringify v0
    let v3 : string = JS.JSON.stringify v1
    let struct (v4 : (struct (US2 * int32 * string * string) []), v5 : (struct (US2 * US2) [])) = v1.l4, v1.l5
    let v6 : string = JS.JSON.stringify v5
    let v7 : string = "database row on_load"
    let v8 : string = "old_state:"
    let v9 : string = "state:"
    let v10 : string = "state.db.status:"
    printfn $"%A{struct (v7, v8, v2, v9, v3, v10, v6)}"
    let struct (v11 : (struct (US2 * int32 * string * string) []), v12 : (struct (US2 * US2) [])) = v0.l4, v0.l5
    let v13 : US2 = US2_1
    let v14 : US2 = US2_1
    let v15 : (struct (US2 * US2) []) = [|struct (v13, v14)|]
    let v16 : int32 = v12.Length
    let v17 : int32 = v15.Length
    let v18 : int32 = v16 + v17
    let v19 : (struct (US2 * US2) []) = Array.zeroCreate<struct (US2 * US2)> (v18)
    let v20 : Mut3 = {l0 = 0} : Mut3
    while method14(v18, v20) do
        let v22 : int32 = v20.l0
        let v23 : bool = v22 < v16
        let struct (v29 : US2, v30 : US2) =
            if v23 then
                let struct (v24 : US2, v25 : US2) = v12.[int v22]
                struct (v24, v25)
            else
                let v26 : int32 = v22 - v16
                let struct (v27 : US2, v28 : US2) = v15.[int v26]
                struct (v27, v28)
        v19.[int v22] <- struct (v29, v30)
        let v31 : int32 = v22 + 1
        v20.l0 <- v31
        ()
    v1.l5 <- v19
    ()
and closure141 () (v0 : Mut1) : (Mut1 -> unit) =
    closure142(v0)
and closure140 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure141()
    v0 v1
    ()
and closure139 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure140()
and closure143 () () : (JSX.Element []) =
    let v0 : (Mut9 -> JSX.Element) = closure119()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : US2 = US2_0
    let v3 : Mut9 = {l0 = v2} : Mut9
    let v4 : obj = v3
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v1, v4) |> unbox<JSX.Element>
    [|v8|]
and closure147 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US2 * int32 * string * string) []), v3 : (struct (US2 * US2) [])) = v0.l4, v0.l5
    let v4 : US2 = US2_1
    let v5 : US2 = US2_0
    let v6 : (struct (US2 * US2) []) = [|struct (v4, v5)|]
    let v7 : int32 = v3.Length
    let v8 : int32 = v6.Length
    let v9 : int32 = v7 + v8
    let v10 : (struct (US2 * US2) []) = Array.zeroCreate<struct (US2 * US2)> (v9)
    let v11 : Mut3 = {l0 = 0} : Mut3
    while method14(v9, v11) do
        let v13 : int32 = v11.l0
        let v14 : bool = v13 < v7
        let struct (v20 : US2, v21 : US2) =
            if v14 then
                let struct (v15 : US2, v16 : US2) = v3.[int v13]
                struct (v15, v16)
            else
                let v17 : int32 = v13 - v7
                let struct (v18 : US2, v19 : US2) = v6.[int v17]
                struct (v18, v19)
        v10.[int v13] <- struct (v20, v21)
        let v22 : int32 = v13 + 1
        v11.l0 <- v22
        ()
    v1.l5 <- v10
    ()
and closure146 () (v0 : Mut1) : (Mut1 -> unit) =
    closure147(v0)
and closure145 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure146()
    v0 v1
    ()
and closure144 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure145()
and closure148 () () : (JSX.Element []) =
    let v0 : (Mut9 -> JSX.Element) = closure119()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : US2 = US2_0
    let v3 : Mut9 = {l0 = v2} : Mut9
    let v4 : obj = v3
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v1, v4) |> unbox<JSX.Element>
    [|v8|]
and closure152 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US2 * int32 * string * string) []), v3 : (struct (US2 * US2) [])) = v0.l4, v0.l5
    let v4 : US2 = US2_0
    let v5 : US2 = US2_0
    let v6 : (struct (US2 * US2) []) = [|struct (v4, v5)|]
    let v7 : int32 = v3.Length
    let v8 : int32 = v6.Length
    let v9 : int32 = v7 + v8
    let v10 : (struct (US2 * US2) []) = Array.zeroCreate<struct (US2 * US2)> (v9)
    let v11 : Mut3 = {l0 = 0} : Mut3
    while method14(v9, v11) do
        let v13 : int32 = v11.l0
        let v14 : bool = v13 < v7
        let struct (v20 : US2, v21 : US2) =
            if v14 then
                let struct (v15 : US2, v16 : US2) = v3.[int v13]
                struct (v15, v16)
            else
                let v17 : int32 = v13 - v7
                let struct (v18 : US2, v19 : US2) = v6.[int v17]
                struct (v18, v19)
        v10.[int v13] <- struct (v20, v21)
        let v22 : int32 = v13 + 1
        v11.l0 <- v22
        ()
    v1.l5 <- v10
    ()
and closure151 () (v0 : Mut1) : (Mut1 -> unit) =
    closure152(v0)
and closure150 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure151()
    v0 v1
    ()
and closure149 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure150()
and closure153 () () : (JSX.Element []) =
    let v0 : (Mut9 -> JSX.Element) = closure119()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : US2 = US2_1
    let v3 : Mut9 = {l0 = v2} : Mut9
    let v4 : obj = v3
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v1, v4) |> unbox<JSX.Element>
    [|v8|]
and closure157 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US2 * int32 * string * string) []), v3 : (struct (US2 * US2) [])) = v0.l4, v0.l5
    let v4 : US2 = US2_0
    let v5 : US2 = US2_1
    let v6 : (struct (US2 * US2) []) = [|struct (v4, v5)|]
    let v7 : int32 = v3.Length
    let v8 : int32 = v6.Length
    let v9 : int32 = v7 + v8
    let v10 : (struct (US2 * US2) []) = Array.zeroCreate<struct (US2 * US2)> (v9)
    let v11 : Mut3 = {l0 = 0} : Mut3
    while method14(v9, v11) do
        let v13 : int32 = v11.l0
        let v14 : bool = v13 < v7
        let struct (v20 : US2, v21 : US2) =
            if v14 then
                let struct (v15 : US2, v16 : US2) = v3.[int v13]
                struct (v15, v16)
            else
                let v17 : int32 = v13 - v7
                let struct (v18 : US2, v19 : US2) = v6.[int v17]
                struct (v18, v19)
        v10.[int v13] <- struct (v20, v21)
        let v22 : int32 = v13 + 1
        v11.l0 <- v22
        ()
    v1.l5 <- v10
    ()
and closure156 () (v0 : Mut1) : (Mut1 -> unit) =
    closure157(v0)
and closure155 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure156()
    v0 v1
    ()
and closure154 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure155()
and closure117 () () : (JSX.Element []) =
    let struct (v0 : US1, v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) = method5()
    let v63 : string = "Rust -{'>'} Rust"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : (unit -> (JSX.Element [])) = closure118()
    let v66 : US5 = US5_1(v65)
    let v67 : string = "db-gun-rs-rs"
    let v68 : US1 = US1_1(v67)
    let v69 : US8 = US8_1(v64)
    let v70 : Mut2 = {l0 = v0; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = v5; l6 = v6; l7 = v7; l8 = v8; l9 = v9; l10 = v66; l11 = v11; l12 = v12; l13 = v13; l14 = v14; l15 = v15; l16 = v16; l17 = v17; l18 = v18; l19 = v19; l20 = v20; l21 = v21; l22 = v22; l23 = v23; l24 = v24; l25 = v25; l26 = v68; l27 = v27; l28 = v28; l29 = v29; l30 = v30; l31 = v31; l32 = v32; l33 = v33; l34 = v34; l35 = v35; l36 = v36; l37 = v37; l38 = v38; l39 = v39; l40 = v40; l41 = v41; l42 = v42; l43 = v43; l44 = v44; l45 = v45; l46 = v46; l47 = v47; l48 = v48; l49 = v49; l50 = v50; l51 = v51; l52 = v52; l53 = v53; l54 = v54; l55 = v55; l56 = v69; l57 = v57; l58 = v58; l59 = v59; l60 = v60; l61 = v61; l62 = v62} : Mut2
    let v71 : (Mut5 -> JSX.Element) = closure23()
    let v72 : (obj -> JSX.Element) = v71 |> unbox<obj -> JSX.Element>
    let v73 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure139()
    let v74 : US11 = US11_1(v73)
    let v75 : US12 = US12_0
    let v76 : Mut5 = {l0 = v74; l1 = v70; l2 = v75} : Mut5
    let v77 : obj = v76
    let v78 : string = "createComponent"
    let v79 : string = "solid-js"
    let v80 : JS.Function = import v78 v79
    let v81 : JSX.Element = v80.Invoke (v72, v77) |> unbox<JSX.Element>
    let struct (v82 : US1, v83 : US1, v84 : US3, v85 : US1, v86 : US1, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US4, v92 : US5, v93 : US1, v94 : US1, v95 : US4, v96 : US6, v97 : US1, v98 : US1, v99 : US1, v100 : US7, v101 : US4, v102 : US1, v103 : US1, v104 : US1, v105 : US1, v106 : US1, v107 : US8, v108 : US1, v109 : US1, v110 : US1, v111 : US8, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US9, v121 : US10, v122 : US9, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US1, v136 : US1, v137 : US1, v138 : US8, v139 : US1, v140 : US1, v141 : US6, v142 : US1, v143 : US0, v144 : US1) = method5()
    let v145 : string = "Rust -{'>'} JavaScript"
    let v146 : JSX.Element = Html.fragment [ v145 |> unbox<JSX.Element> ]
    let v147 : (unit -> (JSX.Element [])) = closure143()
    let v148 : US5 = US5_1(v147)
    let v149 : string = "db-gun-rs-js"
    let v150 : US1 = US1_1(v149)
    let v151 : US8 = US8_1(v146)
    let v152 : Mut2 = {l0 = v82; l1 = v83; l2 = v84; l3 = v85; l4 = v86; l5 = v87; l6 = v88; l7 = v89; l8 = v90; l9 = v91; l10 = v148; l11 = v93; l12 = v94; l13 = v95; l14 = v96; l15 = v97; l16 = v98; l17 = v99; l18 = v100; l19 = v101; l20 = v102; l21 = v103; l22 = v104; l23 = v105; l24 = v106; l25 = v107; l26 = v150; l27 = v109; l28 = v110; l29 = v111; l30 = v112; l31 = v113; l32 = v114; l33 = v115; l34 = v116; l35 = v117; l36 = v118; l37 = v119; l38 = v120; l39 = v121; l40 = v122; l41 = v123; l42 = v124; l43 = v125; l44 = v126; l45 = v127; l46 = v128; l47 = v129; l48 = v130; l49 = v131; l50 = v132; l51 = v133; l52 = v134; l53 = v135; l54 = v136; l55 = v137; l56 = v151; l57 = v139; l58 = v140; l59 = v141; l60 = v142; l61 = v143; l62 = v144} : Mut2
    let v153 : (obj -> JSX.Element) = v71 |> unbox<obj -> JSX.Element>
    let v154 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure144()
    let v155 : US11 = US11_1(v154)
    let v156 : US12 = US12_0
    let v157 : Mut5 = {l0 = v155; l1 = v152; l2 = v156} : Mut5
    let v158 : obj = v157
    let v159 : JS.Function = import v78 v79
    let v160 : JSX.Element = v159.Invoke (v153, v158) |> unbox<JSX.Element>
    let struct (v161 : US1, v162 : US1, v163 : US3, v164 : US1, v165 : US1, v166 : US1, v167 : US1, v168 : US1, v169 : US1, v170 : US4, v171 : US5, v172 : US1, v173 : US1, v174 : US4, v175 : US6, v176 : US1, v177 : US1, v178 : US1, v179 : US7, v180 : US4, v181 : US1, v182 : US1, v183 : US1, v184 : US1, v185 : US1, v186 : US8, v187 : US1, v188 : US1, v189 : US1, v190 : US8, v191 : US1, v192 : US1, v193 : US1, v194 : US1, v195 : US1, v196 : US1, v197 : US1, v198 : US1, v199 : US9, v200 : US10, v201 : US9, v202 : US1, v203 : US1, v204 : US1, v205 : US1, v206 : US1, v207 : US1, v208 : US1, v209 : US1, v210 : US1, v211 : US1, v212 : US1, v213 : US1, v214 : US1, v215 : US1, v216 : US1, v217 : US8, v218 : US1, v219 : US1, v220 : US6, v221 : US1, v222 : US0, v223 : US1) = method5()
    let v224 : string = "JavaScript -{'>'} JavaScript"
    let v225 : JSX.Element = Html.fragment [ v224 |> unbox<JSX.Element> ]
    let v226 : (unit -> (JSX.Element [])) = closure148()
    let v227 : US5 = US5_1(v226)
    let v228 : string = "db-gun-js-js"
    let v229 : US1 = US1_1(v228)
    let v230 : US8 = US8_1(v225)
    let v231 : Mut2 = {l0 = v161; l1 = v162; l2 = v163; l3 = v164; l4 = v165; l5 = v166; l6 = v167; l7 = v168; l8 = v169; l9 = v170; l10 = v227; l11 = v172; l12 = v173; l13 = v174; l14 = v175; l15 = v176; l16 = v177; l17 = v178; l18 = v179; l19 = v180; l20 = v181; l21 = v182; l22 = v183; l23 = v184; l24 = v185; l25 = v186; l26 = v229; l27 = v188; l28 = v189; l29 = v190; l30 = v191; l31 = v192; l32 = v193; l33 = v194; l34 = v195; l35 = v196; l36 = v197; l37 = v198; l38 = v199; l39 = v200; l40 = v201; l41 = v202; l42 = v203; l43 = v204; l44 = v205; l45 = v206; l46 = v207; l47 = v208; l48 = v209; l49 = v210; l50 = v211; l51 = v212; l52 = v213; l53 = v214; l54 = v215; l55 = v216; l56 = v230; l57 = v218; l58 = v219; l59 = v220; l60 = v221; l61 = v222; l62 = v223} : Mut2
    let v232 : (obj -> JSX.Element) = v71 |> unbox<obj -> JSX.Element>
    let v233 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure149()
    let v234 : US11 = US11_1(v233)
    let v235 : US12 = US12_0
    let v236 : Mut5 = {l0 = v234; l1 = v231; l2 = v235} : Mut5
    let v237 : obj = v236
    let v238 : JS.Function = import v78 v79
    let v239 : JSX.Element = v238.Invoke (v232, v237) |> unbox<JSX.Element>
    let struct (v240 : US1, v241 : US1, v242 : US3, v243 : US1, v244 : US1, v245 : US1, v246 : US1, v247 : US1, v248 : US1, v249 : US4, v250 : US5, v251 : US1, v252 : US1, v253 : US4, v254 : US6, v255 : US1, v256 : US1, v257 : US1, v258 : US7, v259 : US4, v260 : US1, v261 : US1, v262 : US1, v263 : US1, v264 : US1, v265 : US8, v266 : US1, v267 : US1, v268 : US1, v269 : US8, v270 : US1, v271 : US1, v272 : US1, v273 : US1, v274 : US1, v275 : US1, v276 : US1, v277 : US1, v278 : US9, v279 : US10, v280 : US9, v281 : US1, v282 : US1, v283 : US1, v284 : US1, v285 : US1, v286 : US1, v287 : US1, v288 : US1, v289 : US1, v290 : US1, v291 : US1, v292 : US1, v293 : US1, v294 : US1, v295 : US1, v296 : US8, v297 : US1, v298 : US1, v299 : US6, v300 : US1, v301 : US0, v302 : US1) = method5()
    let v303 : string = "JavaScript -{'>'} Rust"
    let v304 : JSX.Element = Html.fragment [ v303 |> unbox<JSX.Element> ]
    let v305 : (unit -> (JSX.Element [])) = closure153()
    let v306 : US5 = US5_1(v305)
    let v307 : string = "db-gun-js-rs"
    let v308 : US1 = US1_1(v307)
    let v309 : US8 = US8_1(v304)
    let v310 : Mut2 = {l0 = v240; l1 = v241; l2 = v242; l3 = v243; l4 = v244; l5 = v245; l6 = v246; l7 = v247; l8 = v248; l9 = v249; l10 = v306; l11 = v251; l12 = v252; l13 = v253; l14 = v254; l15 = v255; l16 = v256; l17 = v257; l18 = v258; l19 = v259; l20 = v260; l21 = v261; l22 = v262; l23 = v263; l24 = v264; l25 = v265; l26 = v308; l27 = v267; l28 = v268; l29 = v269; l30 = v270; l31 = v271; l32 = v272; l33 = v273; l34 = v274; l35 = v275; l36 = v276; l37 = v277; l38 = v278; l39 = v279; l40 = v280; l41 = v281; l42 = v282; l43 = v283; l44 = v284; l45 = v285; l46 = v286; l47 = v287; l48 = v288; l49 = v289; l50 = v290; l51 = v291; l52 = v292; l53 = v293; l54 = v294; l55 = v295; l56 = v309; l57 = v297; l58 = v298; l59 = v299; l60 = v300; l61 = v301; l62 = v302} : Mut2
    let v311 : (obj -> JSX.Element) = v71 |> unbox<obj -> JSX.Element>
    let v312 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure154()
    let v313 : US11 = US11_1(v312)
    let v314 : US12 = US12_0
    let v315 : Mut5 = {l0 = v313; l1 = v310; l2 = v314} : Mut5
    let v316 : obj = v315
    let v317 : JS.Function = import v78 v79
    let v318 : JSX.Element = v317.Invoke (v311, v316) |> unbox<JSX.Element>
    [|v81; v160; v239; v318|]
and method26 () : JSX.Element =
    let v0 : (Mut2 -> JSX.Element) = closure6()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure117()
    let v66 : US5 = US5_1(v65)
    let v67 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v67, v65) "$0.children = $1"
    let v68 : obj = v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v1, v68) |> unbox<JSX.Element>
    v72
and closure116 () (v0 : Mut2) : JSX.Element =
    method26()
and closure158 () () : (JSX.Element []) =
    [||]
and closure115 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure116()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US1, v3 : US1, v4 : US3, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US4, v12 : US5, v13 : US1, v14 : US1, v15 : US4, v16 : US6, v17 : US1, v18 : US1, v19 : US1, v20 : US7, v21 : US4, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US8, v28 : US1, v29 : US1, v30 : US1, v31 : US8, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US9, v41 : US10, v42 : US9, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US8, v59 : US1, v60 : US1, v61 : US6, v62 : US1, v63 : US0, v64 : US1) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure158()
    let v66 : US5 = US5_1(v65)
    let v67 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v67, v65) "$0.children = $1"
    let v68 : obj = v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v1, v68) |> unbox<JSX.Element>
    [|v72|]
and closure163 () () : (JSX.Element []) =
    let v0 : string = "Counter"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure164 () struct (v0 : US1, v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) : struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) =
    let v63 : US1 = US1_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v63, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure165 () () : JS.Function =
    let v0 : string = "BiRegularPlus"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure166 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure167 () () : unit =
    let v0 : string = "use_fetch request."
    let v1 : string = "content_address:"
    let v2 : string = "profile/tmp/counter"
    printfn $"%A{struct (v0, v1, v2)}"
    ()
and closure168 () struct (v0 : US1, v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) : struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) =
    let v63 : US1 = US1_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v63, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure169 () () : JS.Function =
    let v0 : string = "BiRegularMinus"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure170 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure171 () () : unit =
    let v0 : string = "use_fetch clear."
    let v1 : string = "content_address:"
    let v2 : string = "profile/tmp/counter"
    printfn $"%A{struct (v0, v1, v2)}"
    ()
and closure162 () () : (JSX.Element []) =
    let v0 : string = "Box"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US1, v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = method5()
    let v66 : (unit -> (JSX.Element [])) = closure163()
    let v67 : US5 = US5_1(v66)
    let v68 : ((string * obj) []) = method7(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v67, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65)
    let v69 : obj = createObj v68
    let v70 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v70, v69) |> unbox<JSX.Element>
    let v75 : (Mut2 -> JSX.Element) = closure37()
    let v76 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    let struct (v77 : US1, v78 : US1, v79 : US3, v80 : US1, v81 : US1, v82 : US1, v83 : US1, v84 : US1, v85 : US1, v86 : US4, v87 : US5, v88 : US1, v89 : US1, v90 : US4, v91 : US6, v92 : US1, v93 : US1, v94 : US1, v95 : US7, v96 : US4, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US8, v103 : US1, v104 : US1, v105 : US1, v106 : US8, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US9, v116 : US10, v117 : US9, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US8, v134 : US1, v135 : US1, v136 : US6, v137 : US1, v138 : US0, v139 : US1) = method5()
    let v140 : (Mut4 -> JSX.Element) = closure17()
    let v141 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    let v142 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = closure164()
    let v143 : (unit -> JS.Function) = closure165()
    let v144 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = closure21()
    let v145 : Mut4 = {l0 = v142; l1 = v143; l2 = v144} : Mut4
    let v146 : obj = v145
    let v147 : JS.Function = import v71 v72
    let v148 : JSX.Element = v147.Invoke (v141, v146) |> unbox<JSX.Element>
    let v149 : (unit -> (JSX.Element [])) = closure166()
    let v150 : US5 = US5_1(v149)
    let v151 : US8 = US8_1(v148)
    let v152 : (unit -> unit) = closure167()
    let v153 : US10 = US10_1(v152)
    let v154 : string = "10px"
    let v155 : US1 = US1_1(v154)
    let v156 : Mut2 = {l0 = v77; l1 = v78; l2 = v79; l3 = v80; l4 = v81; l5 = v82; l6 = v83; l7 = v84; l8 = v85; l9 = v86; l10 = v150; l11 = v88; l12 = v89; l13 = v90; l14 = v91; l15 = v92; l16 = v93; l17 = v94; l18 = v95; l19 = v96; l20 = v97; l21 = v98; l22 = v99; l23 = v100; l24 = v101; l25 = v102; l26 = v103; l27 = v104; l28 = v105; l29 = v151; l30 = v107; l31 = v108; l32 = v109; l33 = v110; l34 = v111; l35 = v112; l36 = v113; l37 = v114; l38 = v115; l39 = v153; l40 = v117; l41 = v118; l42 = v119; l43 = v120; l44 = v121; l45 = v122; l46 = v123; l47 = v155; l48 = v125; l49 = v126; l50 = v127; l51 = v128; l52 = v129; l53 = v130; l54 = v131; l55 = v132; l56 = v133; l57 = v134; l58 = v135; l59 = v136; l60 = v137; l61 = v138; l62 = v139} : Mut2
    emitJsExpr (v156, v149) "$0.children = $1"
    let v157 : obj = v156
    let v158 : JS.Function = import v71 v72
    let v159 : JSX.Element = v158.Invoke (v76, v157) |> unbox<JSX.Element>
    let v160 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    let struct (v161 : US1, v162 : US1, v163 : US3, v164 : US1, v165 : US1, v166 : US1, v167 : US1, v168 : US1, v169 : US1, v170 : US4, v171 : US5, v172 : US1, v173 : US1, v174 : US4, v175 : US6, v176 : US1, v177 : US1, v178 : US1, v179 : US7, v180 : US4, v181 : US1, v182 : US1, v183 : US1, v184 : US1, v185 : US1, v186 : US8, v187 : US1, v188 : US1, v189 : US1, v190 : US8, v191 : US1, v192 : US1, v193 : US1, v194 : US1, v195 : US1, v196 : US1, v197 : US1, v198 : US1, v199 : US9, v200 : US10, v201 : US9, v202 : US1, v203 : US1, v204 : US1, v205 : US1, v206 : US1, v207 : US1, v208 : US1, v209 : US1, v210 : US1, v211 : US1, v212 : US1, v213 : US1, v214 : US1, v215 : US1, v216 : US1, v217 : US8, v218 : US1, v219 : US1, v220 : US6, v221 : US1, v222 : US0, v223 : US1) = method5()
    let v224 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    let v225 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = closure168()
    let v226 : (unit -> JS.Function) = closure169()
    let v227 : Mut4 = {l0 = v225; l1 = v226; l2 = v144} : Mut4
    let v228 : obj = v227
    let v229 : JS.Function = import v71 v72
    let v230 : JSX.Element = v229.Invoke (v224, v228) |> unbox<JSX.Element>
    let v231 : (unit -> (JSX.Element [])) = closure170()
    let v232 : US5 = US5_1(v231)
    let v233 : US8 = US8_1(v230)
    let v234 : (unit -> unit) = closure171()
    let v235 : US10 = US10_1(v234)
    let v236 : US1 = US1_1(v154)
    let v237 : Mut2 = {l0 = v161; l1 = v162; l2 = v163; l3 = v164; l4 = v165; l5 = v166; l6 = v167; l7 = v168; l8 = v169; l9 = v170; l10 = v232; l11 = v172; l12 = v173; l13 = v174; l14 = v175; l15 = v176; l16 = v177; l17 = v178; l18 = v179; l19 = v180; l20 = v181; l21 = v182; l22 = v183; l23 = v184; l24 = v185; l25 = v186; l26 = v187; l27 = v188; l28 = v189; l29 = v233; l30 = v191; l31 = v192; l32 = v193; l33 = v194; l34 = v195; l35 = v196; l36 = v197; l37 = v198; l38 = v199; l39 = v235; l40 = v201; l41 = v202; l42 = v203; l43 = v204; l44 = v205; l45 = v206; l46 = v207; l47 = v236; l48 = v209; l49 = v210; l50 = v211; l51 = v212; l52 = v213; l53 = v214; l54 = v215; l55 = v216; l56 = v217; l57 = v218; l58 = v219; l59 = v220; l60 = v221; l61 = v222; l62 = v223} : Mut2
    emitJsExpr (v237, v231) "$0.children = $1"
    let v238 : obj = v237
    let v239 : JS.Function = import v71 v72
    let v240 : JSX.Element = v239.Invoke (v160, v238) |> unbox<JSX.Element>
    [|v74; v159; v240|]
and method35 (v0 : int32, v1 : Mut15) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method36 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH1 = UH1_0(v2, v3, v1)
        method36(v4, v5)
    | UH1_1 -> (* Nil *)
        v1
and method38 (v0 : UH1, v1 : int32) : int32 =
    match v0 with
    | UH1_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method38(v4, v5)
    | UH1_1 -> (* Nil *)
        v1
and method39 (v0 : (struct (int32 * int32) []), v1 : UH1, v2 : int32) : int32 =
    match v1 with
    | UH1_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method39(v0, v5, v6)
    | UH1_1 -> (* Nil *)
        v2
and method37 (v0 : UH1) : (struct (int32 * int32) []) =
    let v1 : int32 = 0
    let v2 : int32 = method38(v0, v1)
    let v3 : (struct (int32 * int32) []) = Array.zeroCreate<struct (int32 * int32)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method39(v3, v0, v4)
    v3
and closure176 (v0 : (unit -> struct (int32 * int32))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : int32) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = Html.fragment [ v3 |> unbox<JSX.Element> ]
    [|v4|]
and closure175 (v0 : (unit -> struct (int32 * int32))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US1, v6 : US1, v7 : US3, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US4, v15 : US5, v16 : US1, v17 : US1, v18 : US4, v19 : US6, v20 : US1, v21 : US1, v22 : US1, v23 : US7, v24 : US4, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US8, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US9, v44 : US10, v45 : US9, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US8, v62 : US1, v63 : US1, v64 : US6, v65 : US1, v66 : US0, v67 : US1) = method5()
    let v68 : (unit -> (JSX.Element [])) = closure176(v0)
    let v69 : US5 = US5_1(v68)
    let v70 : ((string * obj) []) = method7(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v69, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
    let v71 : obj = createObj v70
    let v72 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v72, v71) |> unbox<JSX.Element>
    [|v76|]
and closure174 () (v0 : (unit -> struct (int32 * int32))) : (JSX.Element []) =
    let struct (v1 : US1, v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method5()
    let struct (v64 : int32, v65 : int32) = v0 ()
    let v66 : string = v64.ToString ()
    let v67 : JSX.Element = Html.fragment [ v66 |> unbox<JSX.Element> ]
    let v68 : (unit -> (JSX.Element [])) = closure175(v0)
    let v69 : US5 = US5_1(v68)
    let v70 : string = "3px"
    let v71 : US1 = US1_1(v70)
    let v72 : US8 = US8_1(v67)
    let v73 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v69; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v71; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v72; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63} : Mut2
    let v74 : (Mut5 -> JSX.Element) = closure23()
    let v75 : (obj -> JSX.Element) = v74 |> unbox<obj -> JSX.Element>
    let v76 : US11 = US11_0
    let v77 : US12 = US12_2
    let v78 : Mut5 = {l0 = v76; l1 = v73; l2 = v77} : Mut5
    let v79 : obj = v78
    let v80 : string = "createComponent"
    let v81 : string = "solid-js"
    let v82 : JS.Function = import v80 v81
    let v83 : JSX.Element = v82.Invoke (v75, v79) |> unbox<JSX.Element>
    [|v83|]
and closure173 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (int32 * obj) []), v2 : (struct (int32 * obj) []), v3 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v4 : int32 = v3.Length
    let v5 : UH1 = UH1_1
    let v6 : Mut15 = {l0 = 0; l1 = v5} : Mut15
    while method35(v4, v6) do
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
    let v19 : UH1 = method36(v17, v18)
    let v20 : (struct (int32 * int32) []) = method37(v19)
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : JS.Function = import v21 v22
    let v24 : ((unit -> struct (int32 * int32)) -> (JSX.Element [])) = closure174()
    let v25 : (unit -> (JSX.Element [])) = v24 |> unbox
    let struct (v26 : US1, v27 : US1, v28 : US3, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US4, v36 : US5, v37 : US1, v38 : US1, v39 : US4, v40 : US6, v41 : US1, v42 : US1, v43 : US1, v44 : US7, v45 : US4, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US8, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US9, v65 : US10, v66 : US9, v67 : US1, v68 : US1, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US1, v77 : US1, v78 : US1, v79 : US1, v80 : US1, v81 : US1, v82 : US8, v83 : US1, v84 : US1, v85 : US6, v86 : US1, v87 : US0, v88 : US1) = method5()
    let v89 : (obj []) = v20 |> unbox<obj[]>
    let v90 : US5 = US5_1(v25)
    let v91 : US7 = US7_1(v89)
    let v92 : ((string * obj) []) = method7(v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v90, v37, v38, v39, v40, v41, v42, v43, v91, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88)
    let v93 : obj = createObj v92
    let v94 : (obj -> JSX.Element) = v23 |> unbox<obj -> JSX.Element>
    let v95 : string = "createComponent"
    let v96 : JS.Function = import v95 v22
    let v97 : JSX.Element = v96.Invoke (v94, v93) |> unbox<JSX.Element>
    [|v97|]
and closure172 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : (Mut2 -> JSX.Element) = closure6()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let struct (v3 : US1, v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = method5()
    let v66 : (unit -> (JSX.Element [])) = closure173(v0)
    let v67 : US5 = US5_1(v66)
    let v68 : Mut2 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v67; l11 = v14; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v47; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v59; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64; l62 = v65} : Mut2
    emitJsExpr (v68, v66) "$0.children = $1"
    let v69 : obj = v68
    let v70 : string = "createComponent"
    let v71 : string = "solid-js"
    let v72 : JS.Function = import v70 v71
    let v73 : JSX.Element = v72.Invoke (v2, v69) |> unbox<JSX.Element>
    [|v73|]
and method34 () : JSX.Element =
    let v0 : string = "useStoreon"
    let v1 : string = "@storeon/solidjs"
    let v2 : JS.Function = import v0 v1
    let v3 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v4 : Mut1 = v3.[0] |> unbox
    let v5 : JS.Function = v3.[1] |> unbox
    let struct (v6 : (struct (int32 * obj) []), v7 : (struct (int32 * obj) []), v8 : (struct (int32 * int32) [])) = v4.l6, v4.l7, v4.l8
    let struct (v9 : US1, v10 : US1, v11 : US3, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US1, v18 : US4, v19 : US5, v20 : US1, v21 : US1, v22 : US4, v23 : US6, v24 : US1, v25 : US1, v26 : US1, v27 : US7, v28 : US4, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US8, v35 : US1, v36 : US1, v37 : US1, v38 : US8, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US9, v48 : US10, v49 : US9, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US8, v66 : US1, v67 : US1, v68 : US6, v69 : US1, v70 : US0, v71 : US1) = method5()
    let v72 : string = "Stack"
    let v73 : string = "@hope-ui/solid"
    let v74 : JS.Function = import v72 v73
    let struct (v75 : US1, v76 : US1, v77 : US3, v78 : US1, v79 : US1, v80 : US1, v81 : US1, v82 : US1, v83 : US1, v84 : US4, v85 : US5, v86 : US1, v87 : US1, v88 : US4, v89 : US6, v90 : US1, v91 : US1, v92 : US1, v93 : US7, v94 : US4, v95 : US1, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US8, v101 : US1, v102 : US1, v103 : US1, v104 : US8, v105 : US1, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US9, v114 : US10, v115 : US9, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US8, v132 : US1, v133 : US1, v134 : US6, v135 : US1, v136 : US0, v137 : US1) = method5()
    let v138 : string = "row"
    let v139 : string = "column"
    let v140 : string = method17(v139, v138)
    let v141 : string = "0"
    let v142 : string = "8px"
    let v143 : string = method17(v142, v141)
    let v144 : string = "start"
    let v145 : US1 = US1_1(v144)
    let v146 : (unit -> (JSX.Element [])) = closure162()
    let v147 : US5 = US5_1(v146)
    let v148 : US1 = US1_1(v140)
    let v149 : US1 = US1_1(v143)
    let v150 : string = "3px"
    let v151 : US1 = US1_1(v150)
    let v152 : string = "7px"
    let v153 : US1 = US1_1(v152)
    let v154 : ((string * obj) []) = method7(v145, v76, v77, v78, v79, v80, v81, v82, v83, v84, v147, v86, v87, v88, v89, v90, v148, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v149, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v151, v120, v121, v122, v123, v124, v125, v126, v153, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137)
    let v155 : obj = createObj v154
    let v156 : (obj -> JSX.Element) = v74 |> unbox<obj -> JSX.Element>
    let v157 : string = "createComponent"
    let v158 : string = "solid-js"
    let v159 : JS.Function = import v157 v158
    let v160 : JSX.Element = v159.Invoke (v156, v155) |> unbox<JSX.Element>
    let v161 : (unit -> (JSX.Element [])) = closure172(v4)
    let v162 : US5 = US5_1(v161)
    let v163 : string = "counter"
    let v164 : US1 = US1_1(v163)
    let v165 : US8 = US8_1(v160)
    let v166 : Mut2 = {l0 = v9; l1 = v10; l2 = v11; l3 = v12; l4 = v13; l5 = v14; l6 = v15; l7 = v16; l8 = v17; l9 = v18; l10 = v162; l11 = v20; l12 = v21; l13 = v22; l14 = v23; l15 = v24; l16 = v25; l17 = v26; l18 = v27; l19 = v28; l20 = v29; l21 = v30; l22 = v31; l23 = v32; l24 = v33; l25 = v34; l26 = v164; l27 = v36; l28 = v37; l29 = v38; l30 = v39; l31 = v40; l32 = v41; l33 = v42; l34 = v43; l35 = v44; l36 = v45; l37 = v46; l38 = v47; l39 = v48; l40 = v49; l41 = v50; l42 = v51; l43 = v52; l44 = v53; l45 = v54; l46 = v55; l47 = v56; l48 = v57; l49 = v58; l50 = v59; l51 = v60; l52 = v61; l53 = v62; l54 = v63; l55 = v64; l56 = v165; l57 = v66; l58 = v67; l59 = v68; l60 = v69; l61 = v70; l62 = v71} : Mut2
    let v167 : (Mut5 -> JSX.Element) = closure23()
    let v168 : (obj -> JSX.Element) = v167 |> unbox<obj -> JSX.Element>
    let v169 : US11 = US11_0
    let v170 : US12 = US12_2
    let v171 : Mut5 = {l0 = v169; l1 = v166; l2 = v170} : Mut5
    let v172 : obj = v171
    let v173 : JS.Function = import v157 v158
    let v174 : JSX.Element = v173.Invoke (v168, v172) |> unbox<JSX.Element>
    v174
and closure161 () (v0 : Mut2) : JSX.Element =
    method34()
and closure177 () () : (JSX.Element []) =
    [||]
and closure180 () () : (JSX.Element []) =
    let v0 : string = "Chain Status"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure181 () struct (v0 : US1, v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) : struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) =
    let v63 : US1 = US1_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v63, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure182 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure183 () () : unit =
    let v0 : string = "use_fetch request."
    let v1 : string = "content_address:"
    let v2 : string = "profile/tmp/chain_status"
    printfn $"%A{struct (v0, v1, v2)}"
    ()
and closure184 () struct (v0 : US1, v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) : struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) =
    let v63 : US1 = US1_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v63, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure185 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure186 () () : unit =
    let v0 : string = "use_fetch clear."
    let v1 : string = "content_address:"
    let v2 : string = "profile/tmp/chain_status"
    printfn $"%A{struct (v0, v1, v2)}"
    ()
and closure179 () () : (JSX.Element []) =
    let v0 : string = "Box"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US1, v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = method5()
    let v66 : (unit -> (JSX.Element [])) = closure180()
    let v67 : US5 = US5_1(v66)
    let v68 : ((string * obj) []) = method7(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v67, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65)
    let v69 : obj = createObj v68
    let v70 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v70, v69) |> unbox<JSX.Element>
    let v75 : (Mut2 -> JSX.Element) = closure37()
    let v76 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    let struct (v77 : US1, v78 : US1, v79 : US3, v80 : US1, v81 : US1, v82 : US1, v83 : US1, v84 : US1, v85 : US1, v86 : US4, v87 : US5, v88 : US1, v89 : US1, v90 : US4, v91 : US6, v92 : US1, v93 : US1, v94 : US1, v95 : US7, v96 : US4, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US8, v103 : US1, v104 : US1, v105 : US1, v106 : US8, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US9, v116 : US10, v117 : US9, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US8, v134 : US1, v135 : US1, v136 : US6, v137 : US1, v138 : US0, v139 : US1) = method5()
    let v140 : (Mut4 -> JSX.Element) = closure17()
    let v141 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    let v142 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = closure181()
    let v143 : (unit -> JS.Function) = closure165()
    let v144 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = closure21()
    let v145 : Mut4 = {l0 = v142; l1 = v143; l2 = v144} : Mut4
    let v146 : obj = v145
    let v147 : JS.Function = import v71 v72
    let v148 : JSX.Element = v147.Invoke (v141, v146) |> unbox<JSX.Element>
    let v149 : (unit -> (JSX.Element [])) = closure182()
    let v150 : US5 = US5_1(v149)
    let v151 : US8 = US8_1(v148)
    let v152 : (unit -> unit) = closure183()
    let v153 : US10 = US10_1(v152)
    let v154 : string = "10px"
    let v155 : US1 = US1_1(v154)
    let v156 : Mut2 = {l0 = v77; l1 = v78; l2 = v79; l3 = v80; l4 = v81; l5 = v82; l6 = v83; l7 = v84; l8 = v85; l9 = v86; l10 = v150; l11 = v88; l12 = v89; l13 = v90; l14 = v91; l15 = v92; l16 = v93; l17 = v94; l18 = v95; l19 = v96; l20 = v97; l21 = v98; l22 = v99; l23 = v100; l24 = v101; l25 = v102; l26 = v103; l27 = v104; l28 = v105; l29 = v151; l30 = v107; l31 = v108; l32 = v109; l33 = v110; l34 = v111; l35 = v112; l36 = v113; l37 = v114; l38 = v115; l39 = v153; l40 = v117; l41 = v118; l42 = v119; l43 = v120; l44 = v121; l45 = v122; l46 = v123; l47 = v155; l48 = v125; l49 = v126; l50 = v127; l51 = v128; l52 = v129; l53 = v130; l54 = v131; l55 = v132; l56 = v133; l57 = v134; l58 = v135; l59 = v136; l60 = v137; l61 = v138; l62 = v139} : Mut2
    emitJsExpr (v156, v149) "$0.children = $1"
    let v157 : obj = v156
    let v158 : JS.Function = import v71 v72
    let v159 : JSX.Element = v158.Invoke (v76, v157) |> unbox<JSX.Element>
    let v160 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    let struct (v161 : US1, v162 : US1, v163 : US3, v164 : US1, v165 : US1, v166 : US1, v167 : US1, v168 : US1, v169 : US1, v170 : US4, v171 : US5, v172 : US1, v173 : US1, v174 : US4, v175 : US6, v176 : US1, v177 : US1, v178 : US1, v179 : US7, v180 : US4, v181 : US1, v182 : US1, v183 : US1, v184 : US1, v185 : US1, v186 : US8, v187 : US1, v188 : US1, v189 : US1, v190 : US8, v191 : US1, v192 : US1, v193 : US1, v194 : US1, v195 : US1, v196 : US1, v197 : US1, v198 : US1, v199 : US9, v200 : US10, v201 : US9, v202 : US1, v203 : US1, v204 : US1, v205 : US1, v206 : US1, v207 : US1, v208 : US1, v209 : US1, v210 : US1, v211 : US1, v212 : US1, v213 : US1, v214 : US1, v215 : US1, v216 : US1, v217 : US8, v218 : US1, v219 : US1, v220 : US6, v221 : US1, v222 : US0, v223 : US1) = method5()
    let v224 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    let v225 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = closure184()
    let v226 : (unit -> JS.Function) = closure169()
    let v227 : Mut4 = {l0 = v225; l1 = v226; l2 = v144} : Mut4
    let v228 : obj = v227
    let v229 : JS.Function = import v71 v72
    let v230 : JSX.Element = v229.Invoke (v224, v228) |> unbox<JSX.Element>
    let v231 : (unit -> (JSX.Element [])) = closure185()
    let v232 : US5 = US5_1(v231)
    let v233 : US8 = US8_1(v230)
    let v234 : (unit -> unit) = closure186()
    let v235 : US10 = US10_1(v234)
    let v236 : US1 = US1_1(v154)
    let v237 : Mut2 = {l0 = v161; l1 = v162; l2 = v163; l3 = v164; l4 = v165; l5 = v166; l6 = v167; l7 = v168; l8 = v169; l9 = v170; l10 = v232; l11 = v172; l12 = v173; l13 = v174; l14 = v175; l15 = v176; l16 = v177; l17 = v178; l18 = v179; l19 = v180; l20 = v181; l21 = v182; l22 = v183; l23 = v184; l24 = v185; l25 = v186; l26 = v187; l27 = v188; l28 = v189; l29 = v233; l30 = v191; l31 = v192; l32 = v193; l33 = v194; l34 = v195; l35 = v196; l36 = v197; l37 = v198; l38 = v199; l39 = v235; l40 = v201; l41 = v202; l42 = v203; l43 = v204; l44 = v205; l45 = v206; l46 = v207; l47 = v236; l48 = v209; l49 = v210; l50 = v211; l51 = v212; l52 = v213; l53 = v214; l54 = v215; l55 = v216; l56 = v217; l57 = v218; l58 = v219; l59 = v220; l60 = v221; l61 = v222; l62 = v223} : Mut2
    emitJsExpr (v237, v231) "$0.children = $1"
    let v238 : obj = v237
    let v239 : JS.Function = import v71 v72
    let v240 : JSX.Element = v239.Invoke (v160, v238) |> unbox<JSX.Element>
    [|v74; v159; v240|]
and method41 (v0 : int32, v1 : Mut16) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method42 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH2 = UH2_0(v2, v3, v1)
        method42(v4, v5)
    | UH2_1 -> (* Nil *)
        v1
and method44 (v0 : UH2, v1 : int32) : int32 =
    match v0 with
    | UH2_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method44(v4, v5)
    | UH2_1 -> (* Nil *)
        v1
and method45 (v0 : (struct (int32 * obj) []), v1 : UH2, v2 : int32) : int32 =
    match v1 with
    | UH2_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method45(v0, v5, v6)
    | UH2_1 -> (* Nil *)
        v2
and method43 (v0 : UH2) : (struct (int32 * obj) []) =
    let v1 : int32 = 0
    let v2 : int32 = method44(v0, v1)
    let v3 : (struct (int32 * obj) []) = Array.zeroCreate<struct (int32 * obj)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method45(v3, v0, v4)
    v3
and closure191 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : obj) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = Html.fragment [ v3 |> unbox<JSX.Element> ]
    [|v4|]
and closure190 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US1, v6 : US1, v7 : US3, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US4, v15 : US5, v16 : US1, v17 : US1, v18 : US4, v19 : US6, v20 : US1, v21 : US1, v22 : US1, v23 : US7, v24 : US4, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US8, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US9, v44 : US10, v45 : US9, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US8, v62 : US1, v63 : US1, v64 : US6, v65 : US1, v66 : US0, v67 : US1) = method5()
    let v68 : (unit -> (JSX.Element [])) = closure191(v0)
    let v69 : US5 = US5_1(v68)
    let v70 : ((string * obj) []) = method7(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v69, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
    let v71 : obj = createObj v70
    let v72 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v72, v71) |> unbox<JSX.Element>
    [|v76|]
and closure189 () (v0 : (unit -> struct (int32 * obj))) : (JSX.Element []) =
    let struct (v1 : US1, v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method5()
    let struct (v64 : int32, v65 : obj) = v0 ()
    let v66 : string = v64.ToString ()
    let v67 : JSX.Element = Html.fragment [ v66 |> unbox<JSX.Element> ]
    let v68 : (unit -> (JSX.Element [])) = closure190(v0)
    let v69 : US5 = US5_1(v68)
    let v70 : string = "3px"
    let v71 : US1 = US1_1(v70)
    let v72 : US8 = US8_1(v67)
    let v73 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v69; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v71; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v72; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63} : Mut2
    let v74 : (Mut5 -> JSX.Element) = closure23()
    let v75 : (obj -> JSX.Element) = v74 |> unbox<obj -> JSX.Element>
    let v76 : US11 = US11_0
    let v77 : US12 = US12_2
    let v78 : Mut5 = {l0 = v76; l1 = v73; l2 = v77} : Mut5
    let v79 : obj = v78
    let v80 : string = "createComponent"
    let v81 : string = "solid-js"
    let v82 : JS.Function = import v80 v81
    let v83 : JSX.Element = v82.Invoke (v75, v79) |> unbox<JSX.Element>
    [|v83|]
and closure188 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (int32 * obj) []), v2 : (struct (int32 * obj) []), v3 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v4 : int32 = v2.Length
    let v5 : UH2 = UH2_1
    let v6 : Mut16 = {l0 = 0; l1 = v5} : Mut16
    while method41(v4, v6) do
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
    let v19 : UH2 = method42(v17, v18)
    let v20 : (struct (int32 * obj) []) = method43(v19)
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : JS.Function = import v21 v22
    let v24 : ((unit -> struct (int32 * obj)) -> (JSX.Element [])) = closure189()
    let v25 : (unit -> (JSX.Element [])) = v24 |> unbox
    let struct (v26 : US1, v27 : US1, v28 : US3, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US4, v36 : US5, v37 : US1, v38 : US1, v39 : US4, v40 : US6, v41 : US1, v42 : US1, v43 : US1, v44 : US7, v45 : US4, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US8, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US9, v65 : US10, v66 : US9, v67 : US1, v68 : US1, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US1, v77 : US1, v78 : US1, v79 : US1, v80 : US1, v81 : US1, v82 : US8, v83 : US1, v84 : US1, v85 : US6, v86 : US1, v87 : US0, v88 : US1) = method5()
    let v89 : (obj []) = v20 |> unbox<obj[]>
    let v90 : US5 = US5_1(v25)
    let v91 : US7 = US7_1(v89)
    let v92 : ((string * obj) []) = method7(v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v90, v37, v38, v39, v40, v41, v42, v43, v91, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88)
    let v93 : obj = createObj v92
    let v94 : (obj -> JSX.Element) = v23 |> unbox<obj -> JSX.Element>
    let v95 : string = "createComponent"
    let v96 : JS.Function = import v95 v22
    let v97 : JSX.Element = v96.Invoke (v94, v93) |> unbox<JSX.Element>
    [|v97|]
and closure187 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : (Mut2 -> JSX.Element) = closure6()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let struct (v3 : US1, v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = method5()
    let v66 : (unit -> (JSX.Element [])) = closure188(v0)
    let v67 : US5 = US5_1(v66)
    let v68 : Mut2 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v67; l11 = v14; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v47; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v59; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64; l62 = v65} : Mut2
    emitJsExpr (v68, v66) "$0.children = $1"
    let v69 : obj = v68
    let v70 : string = "createComponent"
    let v71 : string = "solid-js"
    let v72 : JS.Function = import v70 v71
    let v73 : JSX.Element = v72.Invoke (v2, v69) |> unbox<JSX.Element>
    [|v73|]
and method40 () : JSX.Element =
    let v0 : string = "useStoreon"
    let v1 : string = "@storeon/solidjs"
    let v2 : JS.Function = import v0 v1
    let v3 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v4 : Mut1 = v3.[0] |> unbox
    let v5 : JS.Function = v3.[1] |> unbox
    let struct (v6 : (struct (int32 * obj) []), v7 : (struct (int32 * obj) []), v8 : (struct (int32 * int32) [])) = v4.l6, v4.l7, v4.l8
    let struct (v9 : US1, v10 : US1, v11 : US3, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US1, v18 : US4, v19 : US5, v20 : US1, v21 : US1, v22 : US4, v23 : US6, v24 : US1, v25 : US1, v26 : US1, v27 : US7, v28 : US4, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US8, v35 : US1, v36 : US1, v37 : US1, v38 : US8, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US9, v48 : US10, v49 : US9, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US8, v66 : US1, v67 : US1, v68 : US6, v69 : US1, v70 : US0, v71 : US1) = method5()
    let v72 : string = "Stack"
    let v73 : string = "@hope-ui/solid"
    let v74 : JS.Function = import v72 v73
    let struct (v75 : US1, v76 : US1, v77 : US3, v78 : US1, v79 : US1, v80 : US1, v81 : US1, v82 : US1, v83 : US1, v84 : US4, v85 : US5, v86 : US1, v87 : US1, v88 : US4, v89 : US6, v90 : US1, v91 : US1, v92 : US1, v93 : US7, v94 : US4, v95 : US1, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US8, v101 : US1, v102 : US1, v103 : US1, v104 : US8, v105 : US1, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US9, v114 : US10, v115 : US9, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US8, v132 : US1, v133 : US1, v134 : US6, v135 : US1, v136 : US0, v137 : US1) = method5()
    let v138 : string = "row"
    let v139 : string = "column"
    let v140 : string = method17(v139, v138)
    let v141 : string = "0"
    let v142 : string = "8px"
    let v143 : string = method17(v142, v141)
    let v144 : string = "start"
    let v145 : US1 = US1_1(v144)
    let v146 : (unit -> (JSX.Element [])) = closure179()
    let v147 : US5 = US5_1(v146)
    let v148 : US1 = US1_1(v140)
    let v149 : US1 = US1_1(v143)
    let v150 : string = "3px"
    let v151 : US1 = US1_1(v150)
    let v152 : string = "7px"
    let v153 : US1 = US1_1(v152)
    let v154 : ((string * obj) []) = method7(v145, v76, v77, v78, v79, v80, v81, v82, v83, v84, v147, v86, v87, v88, v89, v90, v148, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v149, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v151, v120, v121, v122, v123, v124, v125, v126, v153, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137)
    let v155 : obj = createObj v154
    let v156 : (obj -> JSX.Element) = v74 |> unbox<obj -> JSX.Element>
    let v157 : string = "createComponent"
    let v158 : string = "solid-js"
    let v159 : JS.Function = import v157 v158
    let v160 : JSX.Element = v159.Invoke (v156, v155) |> unbox<JSX.Element>
    let v161 : (unit -> (JSX.Element [])) = closure187(v4)
    let v162 : US5 = US5_1(v161)
    let v163 : string = "status"
    let v164 : US1 = US1_1(v163)
    let v165 : US8 = US8_1(v160)
    let v166 : Mut2 = {l0 = v9; l1 = v10; l2 = v11; l3 = v12; l4 = v13; l5 = v14; l6 = v15; l7 = v16; l8 = v17; l9 = v18; l10 = v162; l11 = v20; l12 = v21; l13 = v22; l14 = v23; l15 = v24; l16 = v25; l17 = v26; l18 = v27; l19 = v28; l20 = v29; l21 = v30; l22 = v31; l23 = v32; l24 = v33; l25 = v34; l26 = v164; l27 = v36; l28 = v37; l29 = v38; l30 = v39; l31 = v40; l32 = v41; l33 = v42; l34 = v43; l35 = v44; l36 = v45; l37 = v46; l38 = v47; l39 = v48; l40 = v49; l41 = v50; l42 = v51; l43 = v52; l44 = v53; l45 = v54; l46 = v55; l47 = v56; l48 = v57; l49 = v58; l50 = v59; l51 = v60; l52 = v61; l53 = v62; l54 = v63; l55 = v64; l56 = v165; l57 = v66; l58 = v67; l59 = v68; l60 = v69; l61 = v70; l62 = v71} : Mut2
    let v167 : (Mut5 -> JSX.Element) = closure23()
    let v168 : (obj -> JSX.Element) = v167 |> unbox<obj -> JSX.Element>
    let v169 : US11 = US11_0
    let v170 : US12 = US12_2
    let v171 : Mut5 = {l0 = v169; l1 = v166; l2 = v170} : Mut5
    let v172 : obj = v171
    let v173 : JS.Function = import v157 v158
    let v174 : JSX.Element = v173.Invoke (v168, v172) |> unbox<JSX.Element>
    v174
and closure178 () (v0 : Mut2) : JSX.Element =
    method40()
and closure192 () () : (JSX.Element []) =
    [||]
and closure195 () () : (JSX.Element []) =
    let v0 : string = "Chain Deploy"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure196 () struct (v0 : US1, v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) : struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) =
    let v63 : US1 = US1_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v63, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure197 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure198 () () : unit =
    let v0 : string = "use_fetch request."
    let v1 : string = "content_address:"
    let v2 : string = "profile/tmp/chain_deploy"
    printfn $"%A{struct (v0, v1, v2)}"
    ()
and closure199 () struct (v0 : US1, v1 : US1, v2 : US3, v3 : US1, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US4, v10 : US5, v11 : US1, v12 : US1, v13 : US4, v14 : US6, v15 : US1, v16 : US1, v17 : US1, v18 : US7, v19 : US4, v20 : US1, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US8, v26 : US1, v27 : US1, v28 : US1, v29 : US8, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US9, v39 : US10, v40 : US9, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US8, v57 : US1, v58 : US1, v59 : US6, v60 : US1, v61 : US0, v62 : US1) : struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) =
    let v63 : US1 = US1_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v63, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure200 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure201 () () : unit =
    let v0 : string = "use_fetch clear."
    let v1 : string = "content_address:"
    let v2 : string = "profile/tmp/chain_deploy"
    printfn $"%A{struct (v0, v1, v2)}"
    ()
and closure194 () () : (JSX.Element []) =
    let v0 : string = "Box"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US1, v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = method5()
    let v66 : (unit -> (JSX.Element [])) = closure195()
    let v67 : US5 = US5_1(v66)
    let v68 : ((string * obj) []) = method7(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v67, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65)
    let v69 : obj = createObj v68
    let v70 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v70, v69) |> unbox<JSX.Element>
    let v75 : (Mut2 -> JSX.Element) = closure37()
    let v76 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    let struct (v77 : US1, v78 : US1, v79 : US3, v80 : US1, v81 : US1, v82 : US1, v83 : US1, v84 : US1, v85 : US1, v86 : US4, v87 : US5, v88 : US1, v89 : US1, v90 : US4, v91 : US6, v92 : US1, v93 : US1, v94 : US1, v95 : US7, v96 : US4, v97 : US1, v98 : US1, v99 : US1, v100 : US1, v101 : US1, v102 : US8, v103 : US1, v104 : US1, v105 : US1, v106 : US8, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US9, v116 : US10, v117 : US9, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US8, v134 : US1, v135 : US1, v136 : US6, v137 : US1, v138 : US0, v139 : US1) = method5()
    let v140 : (Mut4 -> JSX.Element) = closure17()
    let v141 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    let v142 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = closure196()
    let v143 : (unit -> JS.Function) = closure165()
    let v144 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = closure21()
    let v145 : Mut4 = {l0 = v142; l1 = v143; l2 = v144} : Mut4
    let v146 : obj = v145
    let v147 : JS.Function = import v71 v72
    let v148 : JSX.Element = v147.Invoke (v141, v146) |> unbox<JSX.Element>
    let v149 : (unit -> (JSX.Element [])) = closure197()
    let v150 : US5 = US5_1(v149)
    let v151 : US8 = US8_1(v148)
    let v152 : (unit -> unit) = closure198()
    let v153 : US10 = US10_1(v152)
    let v154 : string = "10px"
    let v155 : US1 = US1_1(v154)
    let v156 : Mut2 = {l0 = v77; l1 = v78; l2 = v79; l3 = v80; l4 = v81; l5 = v82; l6 = v83; l7 = v84; l8 = v85; l9 = v86; l10 = v150; l11 = v88; l12 = v89; l13 = v90; l14 = v91; l15 = v92; l16 = v93; l17 = v94; l18 = v95; l19 = v96; l20 = v97; l21 = v98; l22 = v99; l23 = v100; l24 = v101; l25 = v102; l26 = v103; l27 = v104; l28 = v105; l29 = v151; l30 = v107; l31 = v108; l32 = v109; l33 = v110; l34 = v111; l35 = v112; l36 = v113; l37 = v114; l38 = v115; l39 = v153; l40 = v117; l41 = v118; l42 = v119; l43 = v120; l44 = v121; l45 = v122; l46 = v123; l47 = v155; l48 = v125; l49 = v126; l50 = v127; l51 = v128; l52 = v129; l53 = v130; l54 = v131; l55 = v132; l56 = v133; l57 = v134; l58 = v135; l59 = v136; l60 = v137; l61 = v138; l62 = v139} : Mut2
    emitJsExpr (v156, v149) "$0.children = $1"
    let v157 : obj = v156
    let v158 : JS.Function = import v71 v72
    let v159 : JSX.Element = v158.Invoke (v76, v157) |> unbox<JSX.Element>
    let v160 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    let struct (v161 : US1, v162 : US1, v163 : US3, v164 : US1, v165 : US1, v166 : US1, v167 : US1, v168 : US1, v169 : US1, v170 : US4, v171 : US5, v172 : US1, v173 : US1, v174 : US4, v175 : US6, v176 : US1, v177 : US1, v178 : US1, v179 : US7, v180 : US4, v181 : US1, v182 : US1, v183 : US1, v184 : US1, v185 : US1, v186 : US8, v187 : US1, v188 : US1, v189 : US1, v190 : US8, v191 : US1, v192 : US1, v193 : US1, v194 : US1, v195 : US1, v196 : US1, v197 : US1, v198 : US1, v199 : US9, v200 : US10, v201 : US9, v202 : US1, v203 : US1, v204 : US1, v205 : US1, v206 : US1, v207 : US1, v208 : US1, v209 : US1, v210 : US1, v211 : US1, v212 : US1, v213 : US1, v214 : US1, v215 : US1, v216 : US1, v217 : US8, v218 : US1, v219 : US1, v220 : US6, v221 : US1, v222 : US0, v223 : US1) = method5()
    let v224 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    let v225 : (struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1) -> struct (US1 * US1 * US3 * US1 * US1 * US1 * US1 * US1 * US1 * US4 * US5 * US1 * US1 * US4 * US6 * US1 * US1 * US1 * US7 * US4 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US8 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US9 * US10 * US9 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US1 * US8 * US1 * US1 * US6 * US1 * US0 * US1)) = closure199()
    let v226 : (unit -> JS.Function) = closure169()
    let v227 : Mut4 = {l0 = v225; l1 = v226; l2 = v144} : Mut4
    let v228 : obj = v227
    let v229 : JS.Function = import v71 v72
    let v230 : JSX.Element = v229.Invoke (v224, v228) |> unbox<JSX.Element>
    let v231 : (unit -> (JSX.Element [])) = closure200()
    let v232 : US5 = US5_1(v231)
    let v233 : US8 = US8_1(v230)
    let v234 : (unit -> unit) = closure201()
    let v235 : US10 = US10_1(v234)
    let v236 : US1 = US1_1(v154)
    let v237 : Mut2 = {l0 = v161; l1 = v162; l2 = v163; l3 = v164; l4 = v165; l5 = v166; l6 = v167; l7 = v168; l8 = v169; l9 = v170; l10 = v232; l11 = v172; l12 = v173; l13 = v174; l14 = v175; l15 = v176; l16 = v177; l17 = v178; l18 = v179; l19 = v180; l20 = v181; l21 = v182; l22 = v183; l23 = v184; l24 = v185; l25 = v186; l26 = v187; l27 = v188; l28 = v189; l29 = v233; l30 = v191; l31 = v192; l32 = v193; l33 = v194; l34 = v195; l35 = v196; l36 = v197; l37 = v198; l38 = v199; l39 = v235; l40 = v201; l41 = v202; l42 = v203; l43 = v204; l44 = v205; l45 = v206; l46 = v207; l47 = v236; l48 = v209; l49 = v210; l50 = v211; l51 = v212; l52 = v213; l53 = v214; l54 = v215; l55 = v216; l56 = v217; l57 = v218; l58 = v219; l59 = v220; l60 = v221; l61 = v222; l62 = v223} : Mut2
    emitJsExpr (v237, v231) "$0.children = $1"
    let v238 : obj = v237
    let v239 : JS.Function = import v71 v72
    let v240 : JSX.Element = v239.Invoke (v160, v238) |> unbox<JSX.Element>
    [|v74; v159; v240|]
and closure206 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : obj) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = Html.fragment [ v3 |> unbox<JSX.Element> ]
    [|v4|]
and closure205 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US1, v6 : US1, v7 : US3, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US4, v15 : US5, v16 : US1, v17 : US1, v18 : US4, v19 : US6, v20 : US1, v21 : US1, v22 : US1, v23 : US7, v24 : US4, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US8, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US9, v44 : US10, v45 : US9, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US8, v62 : US1, v63 : US1, v64 : US6, v65 : US1, v66 : US0, v67 : US1) = method5()
    let v68 : (unit -> (JSX.Element [])) = closure206(v0)
    let v69 : US5 = US5_1(v68)
    let v70 : ((string * obj) []) = method7(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v69, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
    let v71 : obj = createObj v70
    let v72 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v72, v71) |> unbox<JSX.Element>
    [|v76|]
and closure204 () (v0 : (unit -> struct (int32 * obj))) : (JSX.Element []) =
    let struct (v1 : US1, v2 : US1, v3 : US3, v4 : US1, v5 : US1, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US4, v11 : US5, v12 : US1, v13 : US1, v14 : US4, v15 : US6, v16 : US1, v17 : US1, v18 : US1, v19 : US7, v20 : US4, v21 : US1, v22 : US1, v23 : US1, v24 : US1, v25 : US1, v26 : US8, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US9, v40 : US10, v41 : US9, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US8, v58 : US1, v59 : US1, v60 : US6, v61 : US1, v62 : US0, v63 : US1) = method5()
    let struct (v64 : int32, v65 : obj) = v0 ()
    let v66 : string = v64.ToString ()
    let v67 : JSX.Element = Html.fragment [ v66 |> unbox<JSX.Element> ]
    let v68 : (unit -> (JSX.Element [])) = closure205(v0)
    let v69 : US5 = US5_1(v68)
    let v70 : string = "3px"
    let v71 : US1 = US1_1(v70)
    let v72 : US8 = US8_1(v67)
    let v73 : Mut2 = {l0 = v1; l1 = v2; l2 = v3; l3 = v4; l4 = v5; l5 = v6; l6 = v7; l7 = v8; l8 = v9; l9 = v10; l10 = v69; l11 = v12; l12 = v13; l13 = v14; l14 = v15; l15 = v16; l16 = v17; l17 = v18; l18 = v19; l19 = v20; l20 = v21; l21 = v22; l22 = v23; l23 = v24; l24 = v25; l25 = v26; l26 = v27; l27 = v28; l28 = v29; l29 = v30; l30 = v31; l31 = v32; l32 = v33; l33 = v34; l34 = v35; l35 = v36; l36 = v37; l37 = v38; l38 = v39; l39 = v40; l40 = v41; l41 = v42; l42 = v43; l43 = v44; l44 = v71; l45 = v46; l46 = v47; l47 = v48; l48 = v49; l49 = v50; l50 = v51; l51 = v52; l52 = v53; l53 = v54; l54 = v55; l55 = v56; l56 = v72; l57 = v58; l58 = v59; l59 = v60; l60 = v61; l61 = v62; l62 = v63} : Mut2
    let v74 : (Mut5 -> JSX.Element) = closure23()
    let v75 : (obj -> JSX.Element) = v74 |> unbox<obj -> JSX.Element>
    let v76 : US11 = US11_0
    let v77 : US12 = US12_2
    let v78 : Mut5 = {l0 = v76; l1 = v73; l2 = v77} : Mut5
    let v79 : obj = v78
    let v80 : string = "createComponent"
    let v81 : string = "solid-js"
    let v82 : JS.Function = import v80 v81
    let v83 : JSX.Element = v82.Invoke (v75, v79) |> unbox<JSX.Element>
    [|v83|]
and closure203 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (int32 * obj) []), v2 : (struct (int32 * obj) []), v3 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v4 : int32 = v1.Length
    let v5 : UH2 = UH2_1
    let v6 : Mut16 = {l0 = 0; l1 = v5} : Mut16
    while method41(v4, v6) do
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
    let v19 : UH2 = method42(v17, v18)
    let v20 : (struct (int32 * obj) []) = method43(v19)
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : JS.Function = import v21 v22
    let v24 : ((unit -> struct (int32 * obj)) -> (JSX.Element [])) = closure204()
    let v25 : (unit -> (JSX.Element [])) = v24 |> unbox
    let struct (v26 : US1, v27 : US1, v28 : US3, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US4, v36 : US5, v37 : US1, v38 : US1, v39 : US4, v40 : US6, v41 : US1, v42 : US1, v43 : US1, v44 : US7, v45 : US4, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US8, v52 : US1, v53 : US1, v54 : US1, v55 : US8, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US9, v65 : US10, v66 : US9, v67 : US1, v68 : US1, v69 : US1, v70 : US1, v71 : US1, v72 : US1, v73 : US1, v74 : US1, v75 : US1, v76 : US1, v77 : US1, v78 : US1, v79 : US1, v80 : US1, v81 : US1, v82 : US8, v83 : US1, v84 : US1, v85 : US6, v86 : US1, v87 : US0, v88 : US1) = method5()
    let v89 : (obj []) = v20 |> unbox<obj[]>
    let v90 : US5 = US5_1(v25)
    let v91 : US7 = US7_1(v89)
    let v92 : ((string * obj) []) = method7(v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v90, v37, v38, v39, v40, v41, v42, v43, v91, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88)
    let v93 : obj = createObj v92
    let v94 : (obj -> JSX.Element) = v23 |> unbox<obj -> JSX.Element>
    let v95 : string = "createComponent"
    let v96 : JS.Function = import v95 v22
    let v97 : JSX.Element = v96.Invoke (v94, v93) |> unbox<JSX.Element>
    [|v97|]
and closure202 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : (Mut2 -> JSX.Element) = closure6()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let struct (v3 : US1, v4 : US1, v5 : US3, v6 : US1, v7 : US1, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US4, v13 : US5, v14 : US1, v15 : US1, v16 : US4, v17 : US6, v18 : US1, v19 : US1, v20 : US1, v21 : US7, v22 : US4, v23 : US1, v24 : US1, v25 : US1, v26 : US1, v27 : US1, v28 : US8, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US9, v42 : US10, v43 : US9, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US8, v60 : US1, v61 : US1, v62 : US6, v63 : US1, v64 : US0, v65 : US1) = method5()
    let v66 : (unit -> (JSX.Element [])) = closure203(v0)
    let v67 : US5 = US5_1(v66)
    let v68 : Mut2 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v67; l11 = v14; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v47; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v59; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64; l62 = v65} : Mut2
    emitJsExpr (v68, v66) "$0.children = $1"
    let v69 : obj = v68
    let v70 : string = "createComponent"
    let v71 : string = "solid-js"
    let v72 : JS.Function = import v70 v71
    let v73 : JSX.Element = v72.Invoke (v2, v69) |> unbox<JSX.Element>
    [|v73|]
and method46 () : JSX.Element =
    let v0 : string = "useStoreon"
    let v1 : string = "@storeon/solidjs"
    let v2 : JS.Function = import v0 v1
    let v3 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v4 : Mut1 = v3.[0] |> unbox
    let v5 : JS.Function = v3.[1] |> unbox
    let struct (v6 : (struct (int32 * obj) []), v7 : (struct (int32 * obj) []), v8 : (struct (int32 * int32) [])) = v4.l6, v4.l7, v4.l8
    let struct (v9 : US1, v10 : US1, v11 : US3, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US1, v18 : US4, v19 : US5, v20 : US1, v21 : US1, v22 : US4, v23 : US6, v24 : US1, v25 : US1, v26 : US1, v27 : US7, v28 : US4, v29 : US1, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US8, v35 : US1, v36 : US1, v37 : US1, v38 : US8, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US9, v48 : US10, v49 : US9, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US8, v66 : US1, v67 : US1, v68 : US6, v69 : US1, v70 : US0, v71 : US1) = method5()
    let v72 : string = "Stack"
    let v73 : string = "@hope-ui/solid"
    let v74 : JS.Function = import v72 v73
    let struct (v75 : US1, v76 : US1, v77 : US3, v78 : US1, v79 : US1, v80 : US1, v81 : US1, v82 : US1, v83 : US1, v84 : US4, v85 : US5, v86 : US1, v87 : US1, v88 : US4, v89 : US6, v90 : US1, v91 : US1, v92 : US1, v93 : US7, v94 : US4, v95 : US1, v96 : US1, v97 : US1, v98 : US1, v99 : US1, v100 : US8, v101 : US1, v102 : US1, v103 : US1, v104 : US8, v105 : US1, v106 : US1, v107 : US1, v108 : US1, v109 : US1, v110 : US1, v111 : US1, v112 : US1, v113 : US9, v114 : US10, v115 : US9, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US8, v132 : US1, v133 : US1, v134 : US6, v135 : US1, v136 : US0, v137 : US1) = method5()
    let v138 : string = "row"
    let v139 : string = "column"
    let v140 : string = method17(v139, v138)
    let v141 : string = "0"
    let v142 : string = "8px"
    let v143 : string = method17(v142, v141)
    let v144 : string = "start"
    let v145 : US1 = US1_1(v144)
    let v146 : (unit -> (JSX.Element [])) = closure194()
    let v147 : US5 = US5_1(v146)
    let v148 : US1 = US1_1(v140)
    let v149 : US1 = US1_1(v143)
    let v150 : string = "3px"
    let v151 : US1 = US1_1(v150)
    let v152 : string = "7px"
    let v153 : US1 = US1_1(v152)
    let v154 : ((string * obj) []) = method7(v145, v76, v77, v78, v79, v80, v81, v82, v83, v84, v147, v86, v87, v88, v89, v90, v148, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v149, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v151, v120, v121, v122, v123, v124, v125, v126, v153, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137)
    let v155 : obj = createObj v154
    let v156 : (obj -> JSX.Element) = v74 |> unbox<obj -> JSX.Element>
    let v157 : string = "createComponent"
    let v158 : string = "solid-js"
    let v159 : JS.Function = import v157 v158
    let v160 : JSX.Element = v159.Invoke (v156, v155) |> unbox<JSX.Element>
    let v161 : (unit -> (JSX.Element [])) = closure202(v4)
    let v162 : US5 = US5_1(v161)
    let v163 : string = "deploy"
    let v164 : US1 = US1_1(v163)
    let v165 : US8 = US8_1(v160)
    let v166 : Mut2 = {l0 = v9; l1 = v10; l2 = v11; l3 = v12; l4 = v13; l5 = v14; l6 = v15; l7 = v16; l8 = v17; l9 = v18; l10 = v162; l11 = v20; l12 = v21; l13 = v22; l14 = v23; l15 = v24; l16 = v25; l17 = v26; l18 = v27; l19 = v28; l20 = v29; l21 = v30; l22 = v31; l23 = v32; l24 = v33; l25 = v34; l26 = v164; l27 = v36; l28 = v37; l29 = v38; l30 = v39; l31 = v40; l32 = v41; l33 = v42; l34 = v43; l35 = v44; l36 = v45; l37 = v46; l38 = v47; l39 = v48; l40 = v49; l41 = v50; l42 = v51; l43 = v52; l44 = v53; l45 = v54; l46 = v55; l47 = v56; l48 = v57; l49 = v58; l50 = v59; l51 = v60; l52 = v61; l53 = v62; l54 = v63; l55 = v64; l56 = v165; l57 = v66; l58 = v67; l59 = v68; l60 = v69; l61 = v70; l62 = v71} : Mut2
    let v167 : (Mut5 -> JSX.Element) = closure23()
    let v168 : (obj -> JSX.Element) = v167 |> unbox<obj -> JSX.Element>
    let v169 : US11 = US11_0
    let v170 : US12 = US12_2
    let v171 : Mut5 = {l0 = v169; l1 = v166; l2 = v170} : Mut5
    let v172 : obj = v171
    let v173 : JS.Function = import v157 v158
    let v174 : JSX.Element = v173.Invoke (v168, v172) |> unbox<JSX.Element>
    v174
and closure193 () (v0 : Mut2) : JSX.Element =
    method46()
and closure207 () () : (JSX.Element []) =
    [||]
and closure160 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut2 -> JSX.Element) = closure161()
    let v6 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let struct (v7 : US1, v8 : US1, v9 : US3, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US4, v17 : US5, v18 : US1, v19 : US1, v20 : US4, v21 : US6, v22 : US1, v23 : US1, v24 : US1, v25 : US7, v26 : US4, v27 : US1, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US8, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US9, v46 : US10, v47 : US9, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US8, v64 : US1, v65 : US1, v66 : US6, v67 : US1, v68 : US0, v69 : US1) = method5()
    let v70 : (unit -> (JSX.Element [])) = closure177()
    let v71 : US5 = US5_1(v70)
    let v72 : Mut2 = {l0 = v7; l1 = v8; l2 = v9; l3 = v10; l4 = v11; l5 = v12; l6 = v13; l7 = v14; l8 = v15; l9 = v16; l10 = v71; l11 = v18; l12 = v19; l13 = v20; l14 = v21; l15 = v22; l16 = v23; l17 = v24; l18 = v25; l19 = v26; l20 = v27; l21 = v28; l22 = v29; l23 = v30; l24 = v31; l25 = v32; l26 = v33; l27 = v34; l28 = v35; l29 = v36; l30 = v37; l31 = v38; l32 = v39; l33 = v40; l34 = v41; l35 = v42; l36 = v43; l37 = v44; l38 = v45; l39 = v46; l40 = v47; l41 = v48; l42 = v49; l43 = v50; l44 = v51; l45 = v52; l46 = v53; l47 = v54; l48 = v55; l49 = v56; l50 = v57; l51 = v58; l52 = v59; l53 = v60; l54 = v61; l55 = v62; l56 = v63; l57 = v64; l58 = v65; l59 = v66; l60 = v67; l61 = v68; l62 = v69} : Mut2
    emitJsExpr (v72, v70) "$0.children = $1"
    let v73 : obj = v72
    let v74 : string = "createComponent"
    let v75 : string = "solid-js"
    let v76 : JS.Function = import v74 v75
    let v77 : JSX.Element = v76.Invoke (v6, v73) |> unbox<JSX.Element>
    let v78 : (Mut2 -> JSX.Element) = closure178()
    let v79 : (obj -> JSX.Element) = v78 |> unbox<obj -> JSX.Element>
    let struct (v80 : US1, v81 : US1, v82 : US3, v83 : US1, v84 : US1, v85 : US1, v86 : US1, v87 : US1, v88 : US1, v89 : US4, v90 : US5, v91 : US1, v92 : US1, v93 : US4, v94 : US6, v95 : US1, v96 : US1, v97 : US1, v98 : US7, v99 : US4, v100 : US1, v101 : US1, v102 : US1, v103 : US1, v104 : US1, v105 : US8, v106 : US1, v107 : US1, v108 : US1, v109 : US8, v110 : US1, v111 : US1, v112 : US1, v113 : US1, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US9, v119 : US10, v120 : US9, v121 : US1, v122 : US1, v123 : US1, v124 : US1, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US1, v136 : US8, v137 : US1, v138 : US1, v139 : US6, v140 : US1, v141 : US0, v142 : US1) = method5()
    let v143 : (unit -> (JSX.Element [])) = closure192()
    let v144 : US5 = US5_1(v143)
    let v145 : Mut2 = {l0 = v80; l1 = v81; l2 = v82; l3 = v83; l4 = v84; l5 = v85; l6 = v86; l7 = v87; l8 = v88; l9 = v89; l10 = v144; l11 = v91; l12 = v92; l13 = v93; l14 = v94; l15 = v95; l16 = v96; l17 = v97; l18 = v98; l19 = v99; l20 = v100; l21 = v101; l22 = v102; l23 = v103; l24 = v104; l25 = v105; l26 = v106; l27 = v107; l28 = v108; l29 = v109; l30 = v110; l31 = v111; l32 = v112; l33 = v113; l34 = v114; l35 = v115; l36 = v116; l37 = v117; l38 = v118; l39 = v119; l40 = v120; l41 = v121; l42 = v122; l43 = v123; l44 = v124; l45 = v125; l46 = v126; l47 = v127; l48 = v128; l49 = v129; l50 = v130; l51 = v131; l52 = v132; l53 = v133; l54 = v134; l55 = v135; l56 = v136; l57 = v137; l58 = v138; l59 = v139; l60 = v140; l61 = v141; l62 = v142} : Mut2
    emitJsExpr (v145, v143) "$0.children = $1"
    let v146 : obj = v145
    let v147 : JS.Function = import v74 v75
    let v148 : JSX.Element = v147.Invoke (v79, v146) |> unbox<JSX.Element>
    let v150 : bool = v2 = ""
    let v151 : bool = v150 <> true
    let v153 : JSX.Element =
        if v151 then
            v148
        else
            let v152 : JSX.Element = Html.fragment []
            v152
    let v154 : (Mut2 -> JSX.Element) = closure193()
    let v155 : (obj -> JSX.Element) = v154 |> unbox<obj -> JSX.Element>
    let struct (v156 : US1, v157 : US1, v158 : US3, v159 : US1, v160 : US1, v161 : US1, v162 : US1, v163 : US1, v164 : US1, v165 : US4, v166 : US5, v167 : US1, v168 : US1, v169 : US4, v170 : US6, v171 : US1, v172 : US1, v173 : US1, v174 : US7, v175 : US4, v176 : US1, v177 : US1, v178 : US1, v179 : US1, v180 : US1, v181 : US8, v182 : US1, v183 : US1, v184 : US1, v185 : US8, v186 : US1, v187 : US1, v188 : US1, v189 : US1, v190 : US1, v191 : US1, v192 : US1, v193 : US1, v194 : US9, v195 : US10, v196 : US9, v197 : US1, v198 : US1, v199 : US1, v200 : US1, v201 : US1, v202 : US1, v203 : US1, v204 : US1, v205 : US1, v206 : US1, v207 : US1, v208 : US1, v209 : US1, v210 : US1, v211 : US1, v212 : US8, v213 : US1, v214 : US1, v215 : US6, v216 : US1, v217 : US0, v218 : US1) = method5()
    let v219 : (unit -> (JSX.Element [])) = closure207()
    let v220 : US5 = US5_1(v219)
    let v221 : Mut2 = {l0 = v156; l1 = v157; l2 = v158; l3 = v159; l4 = v160; l5 = v161; l6 = v162; l7 = v163; l8 = v164; l9 = v165; l10 = v220; l11 = v167; l12 = v168; l13 = v169; l14 = v170; l15 = v171; l16 = v172; l17 = v173; l18 = v174; l19 = v175; l20 = v176; l21 = v177; l22 = v178; l23 = v179; l24 = v180; l25 = v181; l26 = v182; l27 = v183; l28 = v184; l29 = v185; l30 = v186; l31 = v187; l32 = v188; l33 = v189; l34 = v190; l35 = v191; l36 = v192; l37 = v193; l38 = v194; l39 = v195; l40 = v196; l41 = v197; l42 = v198; l43 = v199; l44 = v200; l45 = v201; l46 = v202; l47 = v203; l48 = v204; l49 = v205; l50 = v206; l51 = v207; l52 = v208; l53 = v209; l54 = v210; l55 = v211; l56 = v212; l57 = v213; l58 = v214; l59 = v215; l60 = v216; l61 = v217; l62 = v218} : Mut2
    emitJsExpr (v221, v219) "$0.children = $1"
    let v222 : obj = v221
    let v223 : JS.Function = import v74 v75
    let v224 : JSX.Element = v223.Invoke (v155, v222) |> unbox<JSX.Element>
    let v227 : JSX.Element =
        if v151 then
            v224
        else
            let v226 : JSX.Element = Html.fragment []
            v226
    [|v77; v153; v227|]
and closure159 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut2 -> JSX.Element) = closure6()
    let v6 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let struct (v7 : US1, v8 : US1, v9 : US3, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US4, v17 : US5, v18 : US1, v19 : US1, v20 : US4, v21 : US6, v22 : US1, v23 : US1, v24 : US1, v25 : US7, v26 : US4, v27 : US1, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US8, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US9, v46 : US10, v47 : US9, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US8, v64 : US1, v65 : US1, v66 : US6, v67 : US1, v68 : US0, v69 : US1) = method5()
    let v70 : (unit -> (JSX.Element [])) = closure160(v0, v1, v2, v3, v4)
    let v71 : US5 = US5_1(v70)
    let v72 : Mut2 = {l0 = v7; l1 = v8; l2 = v9; l3 = v10; l4 = v11; l5 = v12; l6 = v13; l7 = v14; l8 = v15; l9 = v16; l10 = v71; l11 = v18; l12 = v19; l13 = v20; l14 = v21; l15 = v22; l16 = v23; l17 = v24; l18 = v25; l19 = v26; l20 = v27; l21 = v28; l22 = v29; l23 = v30; l24 = v31; l25 = v32; l26 = v33; l27 = v34; l28 = v35; l29 = v36; l30 = v37; l31 = v38; l32 = v39; l33 = v40; l34 = v41; l35 = v42; l36 = v43; l37 = v44; l38 = v45; l39 = v46; l40 = v47; l41 = v48; l42 = v49; l43 = v50; l44 = v51; l45 = v52; l46 = v53; l47 = v54; l48 = v55; l49 = v56; l50 = v57; l51 = v58; l52 = v59; l53 = v60; l54 = v61; l55 = v62; l56 = v63; l57 = v64; l58 = v65; l59 = v66; l60 = v67; l61 = v68; l62 = v69} : Mut2
    emitJsExpr (v72, v70) "$0.children = $1"
    let v73 : obj = v72
    let v74 : string = "createComponent"
    let v75 : string = "solid-js"
    let v76 : JS.Function = import v74 v75
    let v77 : JSX.Element = v76.Invoke (v6, v73) |> unbox<JSX.Element>
    [|v77|]
and closure9 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let struct (v5 : US1, v6 : US1, v7 : US3, v8 : US1, v9 : US1, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US4, v15 : US5, v16 : US1, v17 : US1, v18 : US4, v19 : US6, v20 : US1, v21 : US1, v22 : US1, v23 : US7, v24 : US4, v25 : US1, v26 : US1, v27 : US1, v28 : US1, v29 : US1, v30 : US8, v31 : US1, v32 : US1, v33 : US1, v34 : US8, v35 : US1, v36 : US1, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US9, v44 : US10, v45 : US9, v46 : US1, v47 : US1, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US8, v62 : US1, v63 : US1, v64 : US6, v65 : US1, v66 : US0, v67 : US1) = method5()
    let v68 : string = "Links"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure10()
    let v71 : US5 = US5_1(v70)
    let v72 : US8 = US8_1(v69)
    let v73 : Mut2 = {l0 = v5; l1 = v6; l2 = v7; l3 = v8; l4 = v9; l5 = v10; l6 = v11; l7 = v12; l8 = v13; l9 = v14; l10 = v71; l11 = v16; l12 = v17; l13 = v18; l14 = v19; l15 = v20; l16 = v21; l17 = v22; l18 = v23; l19 = v24; l20 = v25; l21 = v26; l22 = v27; l23 = v28; l24 = v29; l25 = v30; l26 = v31; l27 = v32; l28 = v33; l29 = v34; l30 = v35; l31 = v36; l32 = v37; l33 = v38; l34 = v39; l35 = v40; l36 = v41; l37 = v42; l38 = v43; l39 = v44; l40 = v45; l41 = v46; l42 = v47; l43 = v48; l44 = v49; l45 = v50; l46 = v51; l47 = v52; l48 = v53; l49 = v54; l50 = v55; l51 = v56; l52 = v57; l53 = v58; l54 = v59; l55 = v60; l56 = v72; l57 = v62; l58 = v63; l59 = v64; l60 = v65; l61 = v66; l62 = v67} : Mut2
    let v74 : (Mut5 -> JSX.Element) = closure23()
    let v75 : (obj -> JSX.Element) = v74 |> unbox<obj -> JSX.Element>
    let v76 : US11 = US11_0
    let v77 : US12 = US12_2
    let v78 : Mut5 = {l0 = v76; l1 = v73; l2 = v77} : Mut5
    let v79 : obj = v78
    let v80 : string = "createComponent"
    let v81 : string = "solid-js"
    let v82 : JS.Function = import v80 v81
    let v83 : JSX.Element = v82.Invoke (v75, v79) |> unbox<JSX.Element>
    let struct (v84 : US1, v85 : US1, v86 : US3, v87 : US1, v88 : US1, v89 : US1, v90 : US1, v91 : US1, v92 : US1, v93 : US4, v94 : US5, v95 : US1, v96 : US1, v97 : US4, v98 : US6, v99 : US1, v100 : US1, v101 : US1, v102 : US7, v103 : US4, v104 : US1, v105 : US1, v106 : US1, v107 : US1, v108 : US1, v109 : US8, v110 : US1, v111 : US1, v112 : US1, v113 : US8, v114 : US1, v115 : US1, v116 : US1, v117 : US1, v118 : US1, v119 : US1, v120 : US1, v121 : US1, v122 : US9, v123 : US10, v124 : US9, v125 : US1, v126 : US1, v127 : US1, v128 : US1, v129 : US1, v130 : US1, v131 : US1, v132 : US1, v133 : US1, v134 : US1, v135 : US1, v136 : US1, v137 : US1, v138 : US1, v139 : US1, v140 : US8, v141 : US1, v142 : US1, v143 : US6, v144 : US1, v145 : US0, v146 : US1) = method5()
    let v147 : Mut2 = {l0 = v84; l1 = v85; l2 = v86; l3 = v87; l4 = v88; l5 = v89; l6 = v90; l7 = v91; l8 = v92; l9 = v93; l10 = v94; l11 = v95; l12 = v96; l13 = v97; l14 = v98; l15 = v99; l16 = v100; l17 = v101; l18 = v102; l19 = v103; l20 = v104; l21 = v105; l22 = v106; l23 = v107; l24 = v108; l25 = v109; l26 = v110; l27 = v111; l28 = v112; l29 = v113; l30 = v114; l31 = v115; l32 = v116; l33 = v117; l34 = v118; l35 = v119; l36 = v120; l37 = v121; l38 = v122; l39 = v123; l40 = v124; l41 = v125; l42 = v126; l43 = v127; l44 = v128; l45 = v129; l46 = v130; l47 = v131; l48 = v132; l49 = v133; l50 = v134; l51 = v135; l52 = v136; l53 = v137; l54 = v138; l55 = v139; l56 = v140; l57 = v141; l58 = v142; l59 = v143; l60 = v144; l61 = v145; l62 = v146} : Mut2
    let v148 : (obj -> JSX.Element) = v74 |> unbox<obj -> JSX.Element>
    let v149 : US11 = US11_0
    let v150 : US12 = US12_2
    let v151 : Mut5 = {l0 = v149; l1 = v147; l2 = v150} : Mut5
    let v152 : obj = v151
    let v153 : JS.Function = import v80 v81
    let v154 : JSX.Element = v153.Invoke (v148, v152) |> unbox<JSX.Element>
    let struct (v155 : US1, v156 : US1, v157 : US3, v158 : US1, v159 : US1, v160 : US1, v161 : US1, v162 : US1, v163 : US1, v164 : US4, v165 : US5, v166 : US1, v167 : US1, v168 : US4, v169 : US6, v170 : US1, v171 : US1, v172 : US1, v173 : US7, v174 : US4, v175 : US1, v176 : US1, v177 : US1, v178 : US1, v179 : US1, v180 : US8, v181 : US1, v182 : US1, v183 : US1, v184 : US8, v185 : US1, v186 : US1, v187 : US1, v188 : US1, v189 : US1, v190 : US1, v191 : US1, v192 : US1, v193 : US9, v194 : US10, v195 : US9, v196 : US1, v197 : US1, v198 : US1, v199 : US1, v200 : US1, v201 : US1, v202 : US1, v203 : US1, v204 : US1, v205 : US1, v206 : US1, v207 : US1, v208 : US1, v209 : US1, v210 : US1, v211 : US8, v212 : US1, v213 : US1, v214 : US6, v215 : US1, v216 : US0, v217 : US1) = method5()
    let v218 : string = "Settings"
    let v219 : JSX.Element = Html.fragment [ v218 |> unbox<JSX.Element> ]
    let v220 : (unit -> (JSX.Element [])) = closure58()
    let v221 : US5 = US5_1(v220)
    let v222 : US8 = US8_1(v219)
    let v223 : Mut2 = {l0 = v155; l1 = v156; l2 = v157; l3 = v158; l4 = v159; l5 = v160; l6 = v161; l7 = v162; l8 = v163; l9 = v164; l10 = v221; l11 = v166; l12 = v167; l13 = v168; l14 = v169; l15 = v170; l16 = v171; l17 = v172; l18 = v173; l19 = v174; l20 = v175; l21 = v176; l22 = v177; l23 = v178; l24 = v179; l25 = v180; l26 = v181; l27 = v182; l28 = v183; l29 = v184; l30 = v185; l31 = v186; l32 = v187; l33 = v188; l34 = v189; l35 = v190; l36 = v191; l37 = v192; l38 = v193; l39 = v194; l40 = v195; l41 = v196; l42 = v197; l43 = v198; l44 = v199; l45 = v200; l46 = v201; l47 = v202; l48 = v203; l49 = v204; l50 = v205; l51 = v206; l52 = v207; l53 = v208; l54 = v209; l55 = v210; l56 = v222; l57 = v212; l58 = v213; l59 = v214; l60 = v215; l61 = v216; l62 = v217} : Mut2
    let v224 : (obj -> JSX.Element) = v74 |> unbox<obj -> JSX.Element>
    let v225 : US11 = US11_0
    let v226 : US12 = US12_2
    let v227 : Mut5 = {l0 = v225; l1 = v223; l2 = v226} : Mut5
    let v228 : obj = v227
    let v229 : JS.Function = import v80 v81
    let v230 : JSX.Element = v229.Invoke (v224, v228) |> unbox<JSX.Element>
    let struct (v231 : US1, v232 : US1, v233 : US3, v234 : US1, v235 : US1, v236 : US1, v237 : US1, v238 : US1, v239 : US1, v240 : US4, v241 : US5, v242 : US1, v243 : US1, v244 : US4, v245 : US6, v246 : US1, v247 : US1, v248 : US1, v249 : US7, v250 : US4, v251 : US1, v252 : US1, v253 : US1, v254 : US1, v255 : US1, v256 : US8, v257 : US1, v258 : US1, v259 : US1, v260 : US8, v261 : US1, v262 : US1, v263 : US1, v264 : US1, v265 : US1, v266 : US1, v267 : US1, v268 : US1, v269 : US9, v270 : US10, v271 : US9, v272 : US1, v273 : US1, v274 : US1, v275 : US1, v276 : US1, v277 : US1, v278 : US1, v279 : US1, v280 : US1, v281 : US1, v282 : US1, v283 : US1, v284 : US1, v285 : US1, v286 : US1, v287 : US8, v288 : US1, v289 : US1, v290 : US6, v291 : US1, v292 : US0, v293 : US1) = method5()
    let v294 : Mut2 = {l0 = v231; l1 = v232; l2 = v233; l3 = v234; l4 = v235; l5 = v236; l6 = v237; l7 = v238; l8 = v239; l9 = v240; l10 = v241; l11 = v242; l12 = v243; l13 = v244; l14 = v245; l15 = v246; l16 = v247; l17 = v248; l18 = v249; l19 = v250; l20 = v251; l21 = v252; l22 = v253; l23 = v254; l24 = v255; l25 = v256; l26 = v257; l27 = v258; l28 = v259; l29 = v260; l30 = v261; l31 = v262; l32 = v263; l33 = v264; l34 = v265; l35 = v266; l36 = v267; l37 = v268; l38 = v269; l39 = v270; l40 = v271; l41 = v272; l42 = v273; l43 = v274; l44 = v275; l45 = v276; l46 = v277; l47 = v278; l48 = v279; l49 = v280; l50 = v281; l51 = v282; l52 = v283; l53 = v284; l54 = v285; l55 = v286; l56 = v287; l57 = v288; l58 = v289; l59 = v290; l60 = v291; l61 = v292; l62 = v293} : Mut2
    let v295 : (obj -> JSX.Element) = v74 |> unbox<obj -> JSX.Element>
    let v296 : US11 = US11_0
    let v297 : US12 = US12_2
    let v298 : Mut5 = {l0 = v296; l1 = v294; l2 = v297} : Mut5
    let v299 : obj = v298
    let v300 : JS.Function = import v80 v81
    let v301 : JSX.Element = v300.Invoke (v295, v299) |> unbox<JSX.Element>
    let struct (v302 : US1, v303 : US1, v304 : US3, v305 : US1, v306 : US1, v307 : US1, v308 : US1, v309 : US1, v310 : US1, v311 : US4, v312 : US5, v313 : US1, v314 : US1, v315 : US4, v316 : US6, v317 : US1, v318 : US1, v319 : US1, v320 : US7, v321 : US4, v322 : US1, v323 : US1, v324 : US1, v325 : US1, v326 : US1, v327 : US8, v328 : US1, v329 : US1, v330 : US1, v331 : US8, v332 : US1, v333 : US1, v334 : US1, v335 : US1, v336 : US1, v337 : US1, v338 : US1, v339 : US1, v340 : US9, v341 : US10, v342 : US9, v343 : US1, v344 : US1, v345 : US1, v346 : US1, v347 : US1, v348 : US1, v349 : US1, v350 : US1, v351 : US1, v352 : US1, v353 : US1, v354 : US1, v355 : US1, v356 : US1, v357 : US1, v358 : US8, v359 : US1, v360 : US1, v361 : US6, v362 : US1, v363 : US0, v364 : US1) = method5()
    let v365 : string = "Chain"
    let v366 : JSX.Element = Html.fragment [ v365 |> unbox<JSX.Element> ]
    let v367 : (unit -> (JSX.Element [])) = closure68()
    let v368 : US5 = US5_1(v367)
    let v369 : string = "db"
    let v370 : US1 = US1_1(v369)
    let v371 : US8 = US8_1(v366)
    let v372 : Mut2 = {l0 = v302; l1 = v303; l2 = v304; l3 = v305; l4 = v306; l5 = v307; l6 = v308; l7 = v309; l8 = v310; l9 = v311; l10 = v368; l11 = v313; l12 = v314; l13 = v315; l14 = v316; l15 = v317; l16 = v318; l17 = v319; l18 = v320; l19 = v321; l20 = v322; l21 = v323; l22 = v324; l23 = v325; l24 = v326; l25 = v327; l26 = v370; l27 = v329; l28 = v330; l29 = v331; l30 = v332; l31 = v333; l32 = v334; l33 = v335; l34 = v336; l35 = v337; l36 = v338; l37 = v339; l38 = v340; l39 = v341; l40 = v342; l41 = v343; l42 = v344; l43 = v345; l44 = v346; l45 = v347; l46 = v348; l47 = v349; l48 = v350; l49 = v351; l50 = v352; l51 = v353; l52 = v354; l53 = v355; l54 = v356; l55 = v357; l56 = v371; l57 = v359; l58 = v360; l59 = v361; l60 = v362; l61 = v363; l62 = v364} : Mut2
    let v373 : (obj -> JSX.Element) = v74 |> unbox<obj -> JSX.Element>
    let v374 : US11 = US11_0
    let v375 : US12 = US12_0
    let v376 : Mut5 = {l0 = v374; l1 = v372; l2 = v375} : Mut5
    let v377 : obj = v376
    let v378 : JS.Function = import v80 v81
    let v379 : JSX.Element = v378.Invoke (v373, v377) |> unbox<JSX.Element>
    let struct (v380 : US1, v381 : US1, v382 : US3, v383 : US1, v384 : US1, v385 : US1, v386 : US1, v387 : US1, v388 : US1, v389 : US4, v390 : US5, v391 : US1, v392 : US1, v393 : US4, v394 : US6, v395 : US1, v396 : US1, v397 : US1, v398 : US7, v399 : US4, v400 : US1, v401 : US1, v402 : US1, v403 : US1, v404 : US1, v405 : US8, v406 : US1, v407 : US1, v408 : US1, v409 : US8, v410 : US1, v411 : US1, v412 : US1, v413 : US1, v414 : US1, v415 : US1, v416 : US1, v417 : US1, v418 : US9, v419 : US10, v420 : US9, v421 : US1, v422 : US1, v423 : US1, v424 : US1, v425 : US1, v426 : US1, v427 : US1, v428 : US1, v429 : US1, v430 : US1, v431 : US1, v432 : US1, v433 : US1, v434 : US1, v435 : US1, v436 : US8, v437 : US1, v438 : US1, v439 : US6, v440 : US1, v441 : US0, v442 : US1) = method5()
    let v443 : Mut2 = {l0 = v380; l1 = v381; l2 = v382; l3 = v383; l4 = v384; l5 = v385; l6 = v386; l7 = v387; l8 = v388; l9 = v389; l10 = v390; l11 = v391; l12 = v392; l13 = v393; l14 = v394; l15 = v395; l16 = v396; l17 = v397; l18 = v398; l19 = v399; l20 = v400; l21 = v401; l22 = v402; l23 = v403; l24 = v404; l25 = v405; l26 = v406; l27 = v407; l28 = v408; l29 = v409; l30 = v410; l31 = v411; l32 = v412; l33 = v413; l34 = v414; l35 = v415; l36 = v416; l37 = v417; l38 = v418; l39 = v419; l40 = v420; l41 = v421; l42 = v422; l43 = v423; l44 = v424; l45 = v425; l46 = v426; l47 = v427; l48 = v428; l49 = v429; l50 = v430; l51 = v431; l52 = v432; l53 = v433; l54 = v434; l55 = v435; l56 = v436; l57 = v437; l58 = v438; l59 = v439; l60 = v440; l61 = v441; l62 = v442} : Mut2
    let v444 : (obj -> JSX.Element) = v74 |> unbox<obj -> JSX.Element>
    let v445 : US11 = US11_0
    let v446 : US12 = US12_2
    let v447 : Mut5 = {l0 = v445; l1 = v443; l2 = v446} : Mut5
    let v448 : obj = v447
    let v449 : JS.Function = import v80 v81
    let v450 : JSX.Element = v449.Invoke (v444, v448) |> unbox<JSX.Element>
    let struct (v451 : US1, v452 : US1, v453 : US3, v454 : US1, v455 : US1, v456 : US1, v457 : US1, v458 : US1, v459 : US1, v460 : US4, v461 : US5, v462 : US1, v463 : US1, v464 : US4, v465 : US6, v466 : US1, v467 : US1, v468 : US1, v469 : US7, v470 : US4, v471 : US1, v472 : US1, v473 : US1, v474 : US1, v475 : US1, v476 : US8, v477 : US1, v478 : US1, v479 : US1, v480 : US8, v481 : US1, v482 : US1, v483 : US1, v484 : US1, v485 : US1, v486 : US1, v487 : US1, v488 : US1, v489 : US9, v490 : US10, v491 : US9, v492 : US1, v493 : US1, v494 : US1, v495 : US1, v496 : US1, v497 : US1, v498 : US1, v499 : US1, v500 : US1, v501 : US1, v502 : US1, v503 : US1, v504 : US1, v505 : US1, v506 : US1, v507 : US8, v508 : US1, v509 : US1, v510 : US6, v511 : US1, v512 : US0, v513 : US1) = method5()
    let v514 : string = "Database"
    let v515 : JSX.Element = Html.fragment [ v514 |> unbox<JSX.Element> ]
    let v516 : (unit -> (JSX.Element [])) = closure115()
    let v517 : US5 = US5_1(v516)
    let v518 : US1 = US1_1(v369)
    let v519 : US8 = US8_1(v515)
    let v520 : Mut2 = {l0 = v451; l1 = v452; l2 = v453; l3 = v454; l4 = v455; l5 = v456; l6 = v457; l7 = v458; l8 = v459; l9 = v460; l10 = v517; l11 = v462; l12 = v463; l13 = v464; l14 = v465; l15 = v466; l16 = v467; l17 = v468; l18 = v469; l19 = v470; l20 = v471; l21 = v472; l22 = v473; l23 = v474; l24 = v475; l25 = v476; l26 = v518; l27 = v478; l28 = v479; l29 = v480; l30 = v481; l31 = v482; l32 = v483; l33 = v484; l34 = v485; l35 = v486; l36 = v487; l37 = v488; l38 = v489; l39 = v490; l40 = v491; l41 = v492; l42 = v493; l43 = v494; l44 = v495; l45 = v496; l46 = v497; l47 = v498; l48 = v499; l49 = v500; l50 = v501; l51 = v502; l52 = v503; l53 = v504; l54 = v505; l55 = v506; l56 = v519; l57 = v508; l58 = v509; l59 = v510; l60 = v511; l61 = v512; l62 = v513} : Mut2
    let v521 : (obj -> JSX.Element) = v74 |> unbox<obj -> JSX.Element>
    let v522 : US11 = US11_0
    let v523 : US12 = US12_0
    let v524 : Mut5 = {l0 = v522; l1 = v520; l2 = v523} : Mut5
    let v525 : obj = v524
    let v526 : JS.Function = import v80 v81
    let v527 : JSX.Element = v526.Invoke (v521, v525) |> unbox<JSX.Element>
    let struct (v528 : US1, v529 : US1, v530 : US3, v531 : US1, v532 : US1, v533 : US1, v534 : US1, v535 : US1, v536 : US1, v537 : US4, v538 : US5, v539 : US1, v540 : US1, v541 : US4, v542 : US6, v543 : US1, v544 : US1, v545 : US1, v546 : US7, v547 : US4, v548 : US1, v549 : US1, v550 : US1, v551 : US1, v552 : US1, v553 : US8, v554 : US1, v555 : US1, v556 : US1, v557 : US8, v558 : US1, v559 : US1, v560 : US1, v561 : US1, v562 : US1, v563 : US1, v564 : US1, v565 : US1, v566 : US9, v567 : US10, v568 : US9, v569 : US1, v570 : US1, v571 : US1, v572 : US1, v573 : US1, v574 : US1, v575 : US1, v576 : US1, v577 : US1, v578 : US1, v579 : US1, v580 : US1, v581 : US1, v582 : US1, v583 : US1, v584 : US8, v585 : US1, v586 : US1, v587 : US6, v588 : US1, v589 : US0, v590 : US1) = method5()
    let v591 : Mut2 = {l0 = v528; l1 = v529; l2 = v530; l3 = v531; l4 = v532; l5 = v533; l6 = v534; l7 = v535; l8 = v536; l9 = v537; l10 = v538; l11 = v539; l12 = v540; l13 = v541; l14 = v542; l15 = v543; l16 = v544; l17 = v545; l18 = v546; l19 = v547; l20 = v548; l21 = v549; l22 = v550; l23 = v551; l24 = v552; l25 = v553; l26 = v554; l27 = v555; l28 = v556; l29 = v557; l30 = v558; l31 = v559; l32 = v560; l33 = v561; l34 = v562; l35 = v563; l36 = v564; l37 = v565; l38 = v566; l39 = v567; l40 = v568; l41 = v569; l42 = v570; l43 = v571; l44 = v572; l45 = v573; l46 = v574; l47 = v575; l48 = v576; l49 = v577; l50 = v578; l51 = v579; l52 = v580; l53 = v581; l54 = v582; l55 = v583; l56 = v584; l57 = v585; l58 = v586; l59 = v587; l60 = v588; l61 = v589; l62 = v590} : Mut2
    let v592 : (obj -> JSX.Element) = v74 |> unbox<obj -> JSX.Element>
    let v593 : US11 = US11_0
    let v594 : US12 = US12_2
    let v595 : Mut5 = {l0 = v593; l1 = v591; l2 = v594} : Mut5
    let v596 : obj = v595
    let v597 : JS.Function = import v80 v81
    let v598 : JSX.Element = v597.Invoke (v592, v596) |> unbox<JSX.Element>
    let struct (v599 : US1, v600 : US1, v601 : US3, v602 : US1, v603 : US1, v604 : US1, v605 : US1, v606 : US1, v607 : US1, v608 : US4, v609 : US5, v610 : US1, v611 : US1, v612 : US4, v613 : US6, v614 : US1, v615 : US1, v616 : US1, v617 : US7, v618 : US4, v619 : US1, v620 : US1, v621 : US1, v622 : US1, v623 : US1, v624 : US8, v625 : US1, v626 : US1, v627 : US1, v628 : US8, v629 : US1, v630 : US1, v631 : US1, v632 : US1, v633 : US1, v634 : US1, v635 : US1, v636 : US1, v637 : US9, v638 : US10, v639 : US9, v640 : US1, v641 : US1, v642 : US1, v643 : US1, v644 : US1, v645 : US1, v646 : US1, v647 : US1, v648 : US1, v649 : US1, v650 : US1, v651 : US1, v652 : US1, v653 : US1, v654 : US1, v655 : US8, v656 : US1, v657 : US1, v658 : US6, v659 : US1, v660 : US0, v661 : US1) = method5()
    let v662 : string = "Profile"
    let v663 : JSX.Element = Html.fragment [ v662 |> unbox<JSX.Element> ]
    let v664 : (unit -> (JSX.Element [])) = closure159(v0, v1, v2, v3, v4)
    let v665 : US5 = US5_1(v664)
    let v666 : US8 = US8_1(v663)
    let v667 : Mut2 = {l0 = v599; l1 = v600; l2 = v601; l3 = v602; l4 = v603; l5 = v604; l6 = v605; l7 = v606; l8 = v607; l9 = v608; l10 = v665; l11 = v610; l12 = v611; l13 = v612; l14 = v613; l15 = v614; l16 = v615; l17 = v616; l18 = v617; l19 = v618; l20 = v619; l21 = v620; l22 = v621; l23 = v622; l24 = v623; l25 = v624; l26 = v625; l27 = v626; l28 = v627; l29 = v628; l30 = v629; l31 = v630; l32 = v631; l33 = v632; l34 = v633; l35 = v634; l36 = v635; l37 = v636; l38 = v637; l39 = v638; l40 = v639; l41 = v640; l42 = v641; l43 = v642; l44 = v643; l45 = v644; l46 = v645; l47 = v646; l48 = v647; l49 = v648; l50 = v649; l51 = v650; l52 = v651; l53 = v652; l54 = v653; l55 = v654; l56 = v666; l57 = v656; l58 = v657; l59 = v658; l60 = v659; l61 = v660; l62 = v661} : Mut2
    let v668 : (obj -> JSX.Element) = v74 |> unbox<obj -> JSX.Element>
    let v669 : US11 = US11_0
    let v670 : US12 = US12_2
    let v671 : Mut5 = {l0 = v669; l1 = v667; l2 = v670} : Mut5
    let v672 : obj = v671
    let v673 : JS.Function = import v80 v81
    let v674 : JSX.Element = v673.Invoke (v668, v672) |> unbox<JSX.Element>
    [|v83; v154; v230; v301; v379; v450; v527; v598; v674|]
and closure5 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut2 -> JSX.Element) = closure6()
    let v6 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let struct (v7 : US1, v8 : US1, v9 : US3, v10 : US1, v11 : US1, v12 : US1, v13 : US1, v14 : US1, v15 : US1, v16 : US4, v17 : US5, v18 : US1, v19 : US1, v20 : US4, v21 : US6, v22 : US1, v23 : US1, v24 : US1, v25 : US7, v26 : US4, v27 : US1, v28 : US1, v29 : US1, v30 : US1, v31 : US1, v32 : US8, v33 : US1, v34 : US1, v35 : US1, v36 : US8, v37 : US1, v38 : US1, v39 : US1, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US9, v46 : US10, v47 : US9, v48 : US1, v49 : US1, v50 : US1, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US8, v64 : US1, v65 : US1, v66 : US6, v67 : US1, v68 : US0, v69 : US1) = method5()
    let v70 : (unit -> (JSX.Element [])) = closure9(v0, v1, v2, v3, v4)
    let v71 : US5 = US5_1(v70)
    let v72 : string = "flex"
    let v73 : US1 = US1_1(v72)
    let v74 : string = "1"
    let v75 : US1 = US1_1(v74)
    let v76 : string = "column"
    let v77 : US1 = US1_1(v76)
    let v78 : string = "hidden"
    let v79 : US1 = US1_1(v78)
    let v80 : string = "auto"
    let v81 : US1 = US1_1(v80)
    let v82 : Mut2 = {l0 = v7; l1 = v8; l2 = v9; l3 = v10; l4 = v11; l5 = v12; l6 = v13; l7 = v14; l8 = v15; l9 = v16; l10 = v71; l11 = v18; l12 = v19; l13 = v20; l14 = v21; l15 = v22; l16 = v23; l17 = v73; l18 = v25; l19 = v26; l20 = v75; l21 = v77; l22 = v29; l23 = v30; l24 = v31; l25 = v32; l26 = v33; l27 = v34; l28 = v35; l29 = v36; l30 = v37; l31 = v38; l32 = v39; l33 = v40; l34 = v41; l35 = v42; l36 = v43; l37 = v44; l38 = v45; l39 = v46; l40 = v47; l41 = v48; l42 = v79; l43 = v81; l44 = v51; l45 = v52; l46 = v53; l47 = v54; l48 = v55; l49 = v56; l50 = v57; l51 = v58; l52 = v59; l53 = v60; l54 = v61; l55 = v62; l56 = v63; l57 = v64; l58 = v65; l59 = v66; l60 = v67; l61 = v68; l62 = v69} : Mut2
    emitJsExpr (v82, v70) "$0.children = $1"
    let v83 : obj = v82
    let v84 : string = "createComponent"
    let v85 : string = "solid-js"
    let v86 : JS.Function = import v84 v85
    let v87 : JSX.Element = v86.Invoke (v6, v83) |> unbox<JSX.Element>
    [|v87|]
and method4 () : JSX.Element =
    let v0 : obj = emitJsExpr () "components_spi.env"
    let v1 : string = emitJsExpr v0 "$0.CODESPACE_NAME || \"\""
    let v2 : string = emitJsExpr v0 "$0.GITHUB_RUN_ID || \"\""
    let v3 : string = emitJsExpr v0 "$0.GITHUB_SHA || \"\""
    let v4 : obj = v0?IS_TEST
    let v5 : bool = emitJsExpr v4 "!$0"
    let v6 : bool = v5 = false
    let v7 : string = "Box"
    let v8 : string = "@hope-ui/solid"
    let v9 : JS.Function = import v7 v8
    let struct (v10 : US1, v11 : US1, v12 : US3, v13 : US1, v14 : US1, v15 : US1, v16 : US1, v17 : US1, v18 : US1, v19 : US4, v20 : US5, v21 : US1, v22 : US1, v23 : US4, v24 : US6, v25 : US1, v26 : US1, v27 : US1, v28 : US7, v29 : US4, v30 : US1, v31 : US1, v32 : US1, v33 : US1, v34 : US1, v35 : US8, v36 : US1, v37 : US1, v38 : US1, v39 : US8, v40 : US1, v41 : US1, v42 : US1, v43 : US1, v44 : US1, v45 : US1, v46 : US1, v47 : US1, v48 : US9, v49 : US10, v50 : US9, v51 : US1, v52 : US1, v53 : US1, v54 : US1, v55 : US1, v56 : US1, v57 : US1, v58 : US1, v59 : US1, v60 : US1, v61 : US1, v62 : US1, v63 : US1, v64 : US1, v65 : US1, v66 : US8, v67 : US1, v68 : US1, v69 : US6, v70 : US1, v71 : US0, v72 : US1) = method5()
    let v73 : string = "$bg"
    let v74 : US1 = US1_1(v73)
    let v75 : (unit -> (JSX.Element [])) = closure5(v1, v0, v2, v3, v6)
    let v76 : US5 = US5_1(v75)
    let v77 : string = "$text1"
    let v78 : US1 = US1_1(v77)
    let v79 : string = "flex"
    let v80 : US1 = US1_1(v79)
    let v81 : string = "1"
    let v82 : US1 = US1_1(v81)
    let v83 : string = "column"
    let v84 : US1 = US1_1(v83)
    let v85 : string = "$sm"
    let v86 : US1 = US1_1(v85)
    let v87 : string = "100vh"
    let v88 : US1 = US1_1(v87)
    let v89 : string = "100vw"
    let v90 : US1 = US1_1(v89)
    let v91 : string = "1px"
    let v92 : US1 = US1_1(v91)
    let v93 : ((string * obj) []) = method7(v10, v11, v12, v74, v14, v15, v16, v17, v18, v19, v76, v78, v22, v23, v24, v25, v26, v80, v28, v29, v82, v84, v86, v88, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v90, v48, v49, v50, v51, v52, v53, v92, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v94 : obj = createObj v93
    let v95 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    let v96 : string = "createComponent"
    let v97 : string = "solid-js"
    let v98 : JS.Function = import v96 v97
    let v99 : JSX.Element = v98.Invoke (v95, v94) |> unbox<JSX.Element>
    v99
and closure4 () (v0 : Mut2) : JSX.Element =
    method4()
let v0 : obj = JS.undefined
let v1 : Mut0 = {l0 = v0} : Mut0
let v65 : obj = emitJsExpr () "process.env"
let v66 : string = "env"
let v67 : (string * obj) = v66, v65
let v68 : ((string * obj) []) = [|v67|]
let v69 : obj = createObj v68
Browser.Dom.window?components_spi <- v69
let v70 : obj = emitJsExpr () "components_spi.env"
let v71 : string = emitJsExpr v70 "$0.CODESPACE_NAME || \"\""
let v72 : string = emitJsExpr v70 "$0.GITHUB_RUN_ID || \"\""
let v73 : string = emitJsExpr v70 "$0.GITHUB_SHA || \"\""
let v74 : obj = v70?IS_TEST
let v75 : bool = emitJsExpr v74 "!$0"
let v76 : bool = v75 = false
let struct (v77 : (struct (string * string * string * string) []), v78 : US0, v79 : US1, v80 : US1, v81 : (struct (US2 * int32 * string * string) []), v82 : (struct (US2 * US2) []), v83 : (struct (int32 * obj) []), v84 : (struct (int32 * obj) []), v85 : (struct (int32 * int32) []), v86 : US0) = method0(v71, v70, v72, v73, v76)
let v87 : Mut1 = {l0 = v77; l1 = v78; l2 = v79; l3 = v80; l4 = v81; l5 = v82; l6 = v83; l7 = v84; l8 = v85; l9 = v86} : Mut1
let v88 : obj = v87
let v89 : (obj -> obj) = method1()
let v90 : obj = v89 v88
let v91 : int32 = Random().Next ()
let v92 : string = "db_listener"
let v93 : (Mut2 -> JSX.Element) = closure2(v90)
let v94 : (string * obj) = v92, v93
let v95 : string = "content"
let v96 : (Mut2 -> JSX.Element) = closure4()
let v97 : (string * obj) = v95, v96
let v98 : string = "store"
let v99 : (string * obj) = v98, v90
let v100 : string = "run_id"
let v101 : (string * obj) = v100, v91
let v102 : ((string * obj) []) = [|v94; v97; v99; v101; v67|]
let v103 : obj = createObj v102
Browser.Dom.window?components_spi <- v103
v1.l0 <- v103
()
