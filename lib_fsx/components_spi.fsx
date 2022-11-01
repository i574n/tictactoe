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
    | US2_1 of f1_0 : int32
and [<Struct>] US3 =
    | US3_0
    | US3_1 of f1_0 : string
and [<Struct>] US4 =
    | US4_0
    | US4_1
and Mut1 = {mutable l0 : (struct (US0 * string * string * string) []); mutable l1 : US2; mutable l2 : US3; mutable l3 : US3; mutable l4 : (struct (US4 * int32 * string * string) []); mutable l5 : (struct (US4 * US4) []); mutable l6 : (struct (int32 * obj) []); mutable l7 : (struct (int32 * obj) []); mutable l8 : (struct (int32 * int32) []); mutable l9 : US2}
and [<Struct>] US5 =
    | US5_0
    | US5_1 of f1_0 : JS.Function
and [<Struct>] US6 =
    | US6_0
    | US6_1 of f1_0 : bool
and [<Struct>] US7 =
    | US7_0
    | US7_1 of f1_0 : (unit -> (JSX.Element []))
and [<Struct>] US8 =
    | US8_0
    | US8_1 of f1_0 : obj
and [<Struct>] US9 =
    | US9_0
    | US9_1 of f1_0 : (obj [])
and [<Struct>] US10 =
    | US10_0
    | US10_1 of f1_0 : JSX.Element
and [<Struct>] US11 =
    | US11_0
    | US11_1 of f1_0 : (obj -> unit)
and [<Struct>] US12 =
    | US12_0
    | US12_1 of f1_0 : (unit -> unit)
and Mut2 = {mutable l0 : US3; mutable l1 : US3; mutable l2 : US5; mutable l3 : US3; mutable l4 : US3; mutable l5 : US3; mutable l6 : US3; mutable l7 : US3; mutable l8 : US3; mutable l9 : US6; mutable l10 : US7; mutable l11 : US3; mutable l12 : US3; mutable l13 : US6; mutable l14 : US8; mutable l15 : US3; mutable l16 : US3; mutable l17 : US3; mutable l18 : US9; mutable l19 : US6; mutable l20 : US3; mutable l21 : US3; mutable l22 : US3; mutable l23 : US3; mutable l24 : US3; mutable l25 : US10; mutable l26 : US3; mutable l27 : US3; mutable l28 : US3; mutable l29 : US10; mutable l30 : US3; mutable l31 : US3; mutable l32 : US3; mutable l33 : US3; mutable l34 : US3; mutable l35 : US3; mutable l36 : US3; mutable l37 : US3; mutable l38 : US11; mutable l39 : US12; mutable l40 : US11; mutable l41 : US3; mutable l42 : US3; mutable l43 : US3; mutable l44 : US3; mutable l45 : US3; mutable l46 : US3; mutable l47 : US3; mutable l48 : US3; mutable l49 : US3; mutable l50 : US3; mutable l51 : US3; mutable l52 : US3; mutable l53 : US3; mutable l54 : US3; mutable l55 : US3; mutable l56 : US10; mutable l57 : US3; mutable l58 : US3; mutable l59 : US8; mutable l60 : US3; mutable l61 : US2; mutable l62 : US3}
and Mut3() = class end
and UH0 =
    | UH0_0 of (string * obj) * UH0
    | UH0_1
and [<Struct>] US13 =
    | US13_0
    | US13_1 of f1_0 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit))
and [<Struct>] US14 =
    | US14_0
    | US14_1
    | US14_2
and Mut4 = {mutable l0 : US13; mutable l1 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)); mutable l2 : US14}
and Mut5 = {mutable l0 : bool; mutable l1 : bool; mutable l2 : US13; mutable l3 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3))}
and Mut6 = {mutable l0 : int32}
and Mut7 = {mutable l0 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)); mutable l1 : (unit -> JS.Function); mutable l2 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3))}
and Mut8 = {mutable l0 : (Mut1 -> US3); mutable l1 : (Mut1 -> (Mut1 -> (US3 -> unit)))}
and Mut9 = {mutable l0 : (Mut1 -> US2); mutable l1 : (Mut1 -> (Mut1 -> (US2 -> unit)))}
and Mut10 = {mutable l0 : US4}
and Mut11 = {mutable l0 : US4; mutable l1 : (struct (US4 * int32 * string * string) -> US3); mutable l2 : (struct (US4 * int32 * string * string) -> (US3 -> struct (US4 * int32 * string * string)))}
and Mut12 = {mutable l0 : int32; mutable l1 : US3}
and [<Struct>] US15 =
    | US15_0
    | US15_1 of f1_0 : US4 * f1_1 : int32 * f1_2 : string * f1_3 : string
and Mut13 = {mutable l0 : int32; mutable l1 : US15}
and Mut14 = {mutable l0 : US4; mutable l1 : (struct (US4 * int32 * string * string) -> US2); mutable l2 : (struct (US4 * int32 * string * string) -> (US2 -> struct (US4 * int32 * string * string)))}
and Mut15 = {mutable l0 : int32; mutable l1 : US2}
and UH1 =
    | UH1_0 of int32 * int32 * UH1
    | UH1_1
and Mut16 = {mutable l0 : int32; mutable l1 : UH1}
and UH2 =
    | UH2_0 of int32 * obj * UH2
    | UH2_1
and Mut17 = {mutable l0 : int32; mutable l1 : UH2}
let rec method0 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) : struct ((struct (US0 * string * string * string) []) * US2 * US3 * US3 * (struct (US4 * int32 * string * string) []) * (struct (US4 * US4) []) * (struct (int32 * obj) []) * (struct (int32 * obj) []) * (struct (int32 * int32) []) * US2) =
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
    let v10 : US0 = US0_0
    let v11 : string = "4ZZJNAAPJGOUBHORYKX5DQSJJIMQLADNUIH7ONXZAVEZYZGOAM5CM7HV2M"
    let v12 : string = "poem slush dry adult final thunder price pause concert topic mesh wild dry gate judge celery winter list promote clump country loan move about faith"
    let v13 : string = "OBVzhzxAK4ZPdaF1QbkXsd8hgRUPJeCfYFjFghgMGnLmcpaAD0mdQJ3Rwq/RwklKGQWAbaIP9zb5BUmcZM4DOg=="
    let v14 : US1 = US1_1
    let v15 : US0 = US0_1(v14)
    let v16 : string = "Q2MAJEB7HYFK42KSN2MY26PL3P5P7HVIGR22GDAGCJQUARDEIM4WLHSIFQ"
    let v17 : string = "crater dove click normal kitten aisle obvious error exotic lunar guard impact donkey gun lamp divide announce match cement excess piano turn fish above make"
    let v18 : string = "lHFQVWKpvRYU00yAQqHOHJegn5nvP0owYkroBFKr94qGmASQPz4KrmlSbpmNeevb+v+eqDR1owwGEmFARGRDOQ=="
    let v19 : US1 = US1_0
    let v20 : US0 = US0_1(v19)
    let v21 : string = "KVGJONR4BETXZ3AS224T4MAJATTSTQGVO3VC3YAGSWAYBVD7KPR23RKNBI"
    let v22 : string = "key churn alert mother lock run lyrics category office lamp silver nut cement pistol fury hollow faculty feed capable announce index cloth faint about bid"
    let v23 : string = "0DNKDAK5QfWuMCTMNJ+Re5mSlc7rbI0q1UOUYDmvPGpVTJc2PAknfOwS1rk+MAkE5ynA1XbqLeAGlYGA1H9T4w=="
    let v24 : (struct (US0 * string * string * string) []) = [|struct (v10, v11, v12, v13); struct (v15, v16, v17, v18); struct (v20, v21, v22, v23)|]
    let v25 : (struct (US4 * US4) []) = [||]
    let v31 : string =
        if v5 then
            let v26 : string = "ws://localhost"
            v26
        else
            let v27 : bool = true = v4
            if v27 then
                let v28 : string = "ws://localhost"
                v28
            else
                let v29 : string = $"ws://{v0}-4944.githubpreview.dev"
                v29
    let v36 : int32 =
        if v5 then
            let v32 : bool = true = v4
            if v32 then
                14944
            else
                let v33 : bool = false = v4
                if v33 then
                    4944
                else
                    80
        else
            80
    let v37 : US4 = US4_1
    let v38 : string = "ws"
    let v44 : string =
        if v5 then
            let v39 : string = "wss://localhost"
            v39
        else
            let v40 : bool = true = v4
            if v40 then
                let v41 : string = "wss://localhost"
                v41
            else
                let v42 : string = $"ws://{v0}-8765.githubpreview.dev"
                v42
    let v49 : int32 =
        if v5 then
            let v45 : bool = true = v4
            if v45 then
                18765
            else
                let v46 : bool = false = v4
                if v46 then
                    8765
                else
                    80
        else
            80
    let v50 : US4 = US4_0
    let v51 : string = "gun"
    let v52 : (struct (US4 * int32 * string * string) []) = [|struct (v37, v36, v31, v38); struct (v50, v49, v44, v51)|]
    let v53 : (struct (int32 * int32) []) = [||]
    let v54 : (struct (int32 * obj) []) = [||]
    let v55 : (struct (int32 * obj) []) = [||]
    let v56 : US2 = US2_1(v9)
    let v57 : string = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
    let v58 : US3 = US3_1(v57)
    let v59 : US3 = US3_1(v8)
    let v60 : US2 = US2_0
    struct (v24, v56, v58, v59, v52, v25, v55, v54, v53, v60)
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
    let struct (v34 : (struct (US4 * int32 * string * string) []), v35 : (struct (US4 * US4) [])) = v7.l4, v7.l5
    let v36 : bool = emitJsExpr v35 "!$0"
    let v37 : bool = v36 = false
    let v42 : bool =
        if v37 then
            true
        else
            let struct (v38 : (struct (US4 * int32 * string * string) []), v39 : (struct (US4 * US4) [])) = v7.l4, v7.l5
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
and method5 () : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v0 : US3 = US3_0
    let v1 : US3 = US3_0
    let v2 : US5 = US5_0
    let v3 : US3 = US3_0
    let v4 : US3 = US3_0
    let v5 : US3 = US3_0
    let v6 : US3 = US3_0
    let v7 : US3 = US3_0
    let v8 : US3 = US3_0
    let v9 : US6 = US6_0
    let v10 : US7 = US7_0
    let v11 : US3 = US3_0
    let v12 : US3 = US3_0
    let v13 : US6 = US6_0
    let v14 : US8 = US8_0
    let v15 : US3 = US3_0
    let v16 : US3 = US3_0
    let v17 : US3 = US3_0
    let v18 : US9 = US9_0
    let v19 : US6 = US6_0
    let v20 : US3 = US3_0
    let v21 : US3 = US3_0
    let v22 : US3 = US3_0
    let v23 : US3 = US3_0
    let v24 : US3 = US3_0
    let v25 : US10 = US10_0
    let v26 : US3 = US3_0
    let v27 : US3 = US3_0
    let v28 : US3 = US3_0
    let v29 : US10 = US10_0
    let v30 : US3 = US3_0
    let v31 : US3 = US3_0
    let v32 : US3 = US3_0
    let v33 : US3 = US3_0
    let v34 : US3 = US3_0
    let v35 : US3 = US3_0
    let v36 : US3 = US3_0
    let v37 : US3 = US3_0
    let v38 : US11 = US11_0
    let v39 : US12 = US12_0
    let v40 : US11 = US11_0
    let v41 : US3 = US3_0
    let v42 : US3 = US3_0
    let v43 : US3 = US3_0
    let v44 : US3 = US3_0
    let v45 : US3 = US3_0
    let v46 : US3 = US3_0
    let v47 : US3 = US3_0
    let v48 : US3 = US3_0
    let v49 : US3 = US3_0
    let v50 : US3 = US3_0
    let v51 : US3 = US3_0
    let v52 : US3 = US3_0
    let v53 : US3 = US3_0
    let v54 : US3 = US3_0
    let v55 : US3 = US3_0
    let v56 : US10 = US10_0
    let v57 : US3 = US3_0
    let v58 : US3 = US3_0
    let v59 : US8 = US8_0
    let v60 : US3 = US3_0
    let v61 : US2 = US2_0
    let v62 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure8 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : string = emitJsExpr v0 "JSON.stringify($0, null, 2)"
    let v2 : JSX.Element = Html.fragment [ v1 |> unbox<JSX.Element> ]
    [|v2|]
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
and method7 (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : ((string * obj) []) =
    let v66 : obj =
        match v0 with
        | US3_0 -> (* None *)
            let v63 : obj = ()
            v63
        | US3_1(v64) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v74 : obj = ()
            v74
        | US3_1(v75) -> (* Some *)
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
        | US5_0 -> (* None *)
            let v83 : obj = ()
            v83
        | US5_1(v84) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v92 : obj = ()
            v92
        | US3_1(v93) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v101 : obj = ()
            v101
        | US3_1(v102) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v110 : obj = ()
            v110
        | US3_1(v111) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v119 : obj = ()
            v119
        | US3_1(v120) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v128 : obj = ()
            v128
        | US3_1(v129) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v137 : obj = ()
            v137
        | US3_1(v138) -> (* Some *)
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
        | US6_0 -> (* None *)
            let v146 : obj = ()
            v146
        | US6_1(v147) -> (* Some *)
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
        | US7_0 -> (* None *)
            let v155 : obj = ()
            v155
        | US7_1(v156) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v164 : obj = ()
            v164
        | US3_1(v165) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v173 : obj = ()
            v173
        | US3_1(v174) -> (* Some *)
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
        | US6_0 -> (* None *)
            let v182 : obj = ()
            v182
        | US6_1(v183) -> (* Some *)
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
        | US8_0 -> (* None *)
            let v191 : obj = ()
            v191
        | US8_1(v192) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v200 : obj = ()
            v200
        | US3_1(v201) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v209 : obj = ()
            v209
        | US3_1(v210) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v218 : obj = ()
            v218
        | US3_1(v219) -> (* Some *)
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
        | US9_0 -> (* None *)
            let v227 : obj = ()
            v227
        | US9_1(v228) -> (* Some *)
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
        | US6_0 -> (* None *)
            let v236 : obj = ()
            v236
        | US6_1(v237) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v245 : obj = ()
            v245
        | US3_1(v246) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v254 : obj = ()
            v254
        | US3_1(v255) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v263 : obj = ()
            v263
        | US3_1(v264) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v272 : obj = ()
            v272
        | US3_1(v273) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v281 : obj = ()
            v281
        | US3_1(v282) -> (* Some *)
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
        | US10_0 -> (* None *)
            let v290 : obj = ()
            v290
        | US10_1(v291) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v299 : obj = ()
            v299
        | US3_1(v300) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v308 : obj = ()
            v308
        | US3_1(v309) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v317 : obj = ()
            v317
        | US3_1(v318) -> (* Some *)
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
        | US10_0 -> (* None *)
            let v326 : obj = ()
            v326
        | US10_1(v327) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v335 : obj = ()
            v335
        | US3_1(v336) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v344 : obj = ()
            v344
        | US3_1(v345) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v353 : obj = ()
            v353
        | US3_1(v354) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v362 : obj = ()
            v362
        | US3_1(v363) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v371 : obj = ()
            v371
        | US3_1(v372) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v380 : obj = ()
            v380
        | US3_1(v381) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v389 : obj = ()
            v389
        | US3_1(v390) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v398 : obj = ()
            v398
        | US3_1(v399) -> (* Some *)
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
        | US11_0 -> (* None *)
            let v407 : obj = ()
            v407
        | US11_1(v408) -> (* Some *)
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
        | US12_0 -> (* None *)
            let v416 : obj = ()
            v416
        | US12_1(v417) -> (* Some *)
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
        | US11_0 -> (* None *)
            let v425 : obj = ()
            v425
        | US11_1(v426) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v434 : obj = ()
            v434
        | US3_1(v435) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v443 : obj = ()
            v443
        | US3_1(v444) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v452 : obj = ()
            v452
        | US3_1(v453) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v461 : obj = ()
            v461
        | US3_1(v462) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v470 : obj = ()
            v470
        | US3_1(v471) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v479 : obj = ()
            v479
        | US3_1(v480) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v488 : obj = ()
            v488
        | US3_1(v489) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v497 : obj = ()
            v497
        | US3_1(v498) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v506 : obj = ()
            v506
        | US3_1(v507) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v515 : obj = ()
            v515
        | US3_1(v516) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v524 : obj = ()
            v524
        | US3_1(v525) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v533 : obj = ()
            v533
        | US3_1(v534) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v542 : obj = ()
            v542
        | US3_1(v543) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v551 : obj = ()
            v551
        | US3_1(v552) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v560 : obj = ()
            v560
        | US3_1(v561) -> (* Some *)
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
        | US10_0 -> (* None *)
            let v569 : obj = ()
            v569
        | US10_1(v570) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v578 : obj = ()
            v578
        | US3_1(v579) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v587 : obj = ()
            v587
        | US3_1(v588) -> (* Some *)
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
        | US8_0 -> (* None *)
            let v596 : obj = ()
            v596
        | US8_1(v597) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v605 : obj = ()
            v605
        | US3_1(v606) -> (* Some *)
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
        | US2_0 -> (* None *)
            let v614 : obj = ()
            v614
        | US2_1(v615) -> (* Some *)
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
        | US3_0 -> (* None *)
            let v623 : obj = ()
            v623
        | US3_1(v624) -> (* Some *)
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
and closure7 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US3, v6 : US3, v7 : US5, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US6, v15 : US7, v16 : US3, v17 : US3, v18 : US6, v19 : US8, v20 : US3, v21 : US3, v22 : US3, v23 : US9, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US11, v44 : US12, v45 : US11, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US10, v62 : US3, v63 : US3, v64 : US8, v65 : US3, v66 : US2, v67 : US3) = method5()
    let v68 : (unit -> (JSX.Element [])) = closure8(v0)
    let v69 : US7 = US7_1(v68)
    let v70 : string = "9px"
    let v71 : US3 = US3_1(v70)
    let v72 : ((string * obj) []) = method7(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v69, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v71, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
    let v73 : obj = createObj v72
    let v74 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v75 : string = "createComponent"
    let v76 : string = "solid-js"
    let v77 : JS.Function = import v75 v76
    let v78 : JSX.Element = v77.Invoke (v74, v73) |> unbox<JSX.Element>
    [|v78|]
and method6 () : JSX.Element =
    let v0 : string = "useStoreon"
    let v1 : string = "@storeon/solidjs"
    let v2 : JS.Function = import v0 v1
    let v3 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v4 : Mut1 = v3.[0] |> unbox
    let v5 : JS.Function = v3.[1] |> unbox
    let v6 : string = "Box"
    let v7 : string = "@hope-ui/solid"
    let v8 : JS.Function = import v6 v7
    let struct (v9 : US3, v10 : US3, v11 : US5, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US6, v19 : US7, v20 : US3, v21 : US3, v22 : US6, v23 : US8, v24 : US3, v25 : US3, v26 : US3, v27 : US9, v28 : US6, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US10, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US11, v48 : US12, v49 : US11, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US10, v66 : US3, v67 : US3, v68 : US8, v69 : US3, v70 : US2, v71 : US3) = method5()
    let v72 : string = "#00000066"
    let v73 : US3 = US3_1(v72)
    let v74 : string = "0"
    let v75 : US3 = US3_1(v74)
    let v76 : (unit -> (JSX.Element [])) = closure7(v4)
    let v77 : US7 = US7_1(v76)
    let v78 : string = "auto"
    let v79 : US3 = US3_1(v78)
    let v80 : string = "absolute"
    let v81 : US3 = US3_1(v80)
    let v82 : US3 = US3_1(v74)
    let v83 : US3 = US3_1(v74)
    let v84 : int32 = 1
    let v85 : US2 = US2_1(v84)
    let v86 : ((string * obj) []) = method7(v9, v10, v11, v73, v13, v14, v15, v16, v75, v18, v77, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v79, v53, v54, v55, v56, v57, v81, v82, v60, v61, v62, v63, v64, v65, v83, v67, v68, v69, v85, v71)
    let v87 : obj = createObj v86
    let v88 : (obj -> JSX.Element) = v8 |> unbox<obj -> JSX.Element>
    let v89 : string = "createComponent"
    let v90 : string = "solid-js"
    let v91 : JS.Function = import v89 v90
    let v92 : JSX.Element = v91.Invoke (v88, v87) |> unbox<JSX.Element>
    v92
and closure6 () (v0 : Mut3) : JSX.Element =
    method6()
and closure11 () () : (JSX.Element []) =
    [||]
and closure10 (v0 : Mut2) () : (JSX.Element []) =
    let v1 : US7 = v0.l10
    let v4 : (unit -> (JSX.Element [])) =
        match v1 with
        | US7_0 -> (* None *)
            closure11()
        | US7_1(v3) -> (* Some *)
            v3
    let v5 : string = "Tbody"
    let v6 : string = "@hope-ui/solid"
    let v7 : JS.Function = import v5 v6
    let struct (v8 : US3, v9 : US3, v10 : US5, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US6, v18 : US7, v19 : US3, v20 : US3, v21 : US6, v22 : US8, v23 : US3, v24 : US3, v25 : US3, v26 : US9, v27 : US6, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US10, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US11, v47 : US12, v48 : US11, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US10, v65 : US3, v66 : US3, v67 : US8, v68 : US3, v69 : US2, v70 : US3) = method5()
    let v71 : string = "$blackAlpha3"
    let v72 : US3 = US3_1(v71)
    let v73 : US7 = US7_1(v4)
    let v74 : string = "flex"
    let v75 : US3 = US3_1(v74)
    let v76 : string = "column"
    let v77 : US3 = US3_1(v76)
    let v78 : string = "-1px"
    let v79 : US3 = US3_1(v78)
    let v80 : ((string * obj) []) = method7(v8, v9, v10, v72, v12, v13, v14, v15, v16, v17, v73, v19, v20, v21, v22, v23, v24, v75, v26, v27, v28, v77, v30, v31, v32, v33, v34, v35, v36, v37, v38, v79, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
    let v81 : obj = createObj v80
    let v82 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    let v83 : string = "createComponent"
    let v84 : string = "solid-js"
    let v85 : JS.Function = import v83 v84
    let v86 : JSX.Element = v85.Invoke (v82, v81) |> unbox<JSX.Element>
    [|v86|]
and method11 (v0 : Mut2) : JSX.Element =
    let v1 : string = "Table"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method5()
    let v67 : US3 = v0.l43
    let v70 : string =
        match v67 with
        | US3_0 -> (* None *)
            let v68 : string = "hidden"
            v68
        | US3_1(v69) -> (* Some *)
            v69
    let v71 : (unit -> (JSX.Element [])) = closure10(v0)
    let v72 : US7 = US7_1(v71)
    let v73 : string = "flex"
    let v74 : US3 = US3_1(v73)
    let v75 : string = "1"
    let v76 : US3 = US3_1(v75)
    let v77 : string = "column"
    let v78 : US3 = US3_1(v77)
    let v79 : string = "hidden"
    let v80 : US3 = US3_1(v79)
    let v81 : US3 = US3_1(v70)
    let v82 : ((string * obj) []) = method7(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v72, v15, v16, v17, v18, v19, v20, v74, v22, v23, v76, v78, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v80, v81, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66)
    let v83 : obj = createObj v82
    let v84 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v85 : string = "createComponent"
    let v86 : string = "solid-js"
    let v87 : JS.Function = import v85 v86
    let v88 : JSX.Element = v87.Invoke (v84, v83) |> unbox<JSX.Element>
    v88
and closure9 () (v0 : Mut2) : JSX.Element =
    method11(v0)
and method13 (v0 : string, v1 : string) : string =
    let v2 : string = {| ``@initial`` = v1; ``@sm`` = v0 |} |> unbox<string>
    v2
and closure17 (v0 : JSX.Element) () : (JSX.Element []) =
    [|v0|]
and closure16 (v0 : JSX.Element) () : (JSX.Element []) =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method5()
    let v67 : (unit -> (JSX.Element [])) = closure17(v0)
    let v68 : US7 = US7_1(v67)
    let v69 : string = "2px"
    let v70 : US3 = US3_1(v69)
    let v71 : ((string * obj) []) = method7(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v68, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v70, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66)
    let v72 : obj = createObj v71
    let v73 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v74 : string = "createComponent"
    let v75 : string = "solid-js"
    let v76 : JS.Function = import v74 v75
    let v77 : JSX.Element = v76.Invoke (v73, v72) |> unbox<JSX.Element>
    [|v77|]
and closure18 (v0 : (bool -> unit)) (v1 : obj) : unit =
    let v2 : bool = v1?target?checked
    v0 v2
    ()
and closure15 (v0 : Mut4, v1 : (bool -> unit), v2 : (unit -> bool), v3 : JSX.Element) () : (JSX.Element []) =
    let v4 : US14 = v0.l2
    let v175 : JSX.Element =
        match v4 with
        | US14_0 -> (* CheckDisabled *)
            let v5 : string = "Checkbox"
            let v6 : string = "@hope-ui/solid"
            let v7 : JS.Function = import v5 v6
            let struct (v8 : US3, v9 : US3, v10 : US5, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US6, v18 : US7, v19 : US3, v20 : US3, v21 : US6, v22 : US8, v23 : US3, v24 : US3, v25 : US3, v26 : US9, v27 : US6, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US10, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US11, v47 : US12, v48 : US11, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US10, v65 : US3, v66 : US3, v67 : US8, v68 : US3, v69 : US2, v70 : US3) = method5()
            let v71 : bool = v2 ()
            let v72 : US6 = US6_1(v71)
            let v73 : (unit -> (JSX.Element [])) = closure16(v3)
            let v74 : US7 = US7_1(v73)
            let v75 : string = "neutral"
            let v76 : US3 = US3_1(v75)
            let v77 : string = "2px"
            let v78 : US3 = US3_1(v77)
            let v79 : (obj -> unit) = closure18(v1)
            let v80 : US11 = US11_1(v79)
            let v81 : string = "sm"
            let v82 : US3 = US3_1(v81)
            let v83 : ((string * obj) []) = method7(v8, v9, v10, v11, v12, v13, v14, v15, v16, v72, v74, v19, v76, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v78, v41, v42, v43, v44, v45, v80, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v82, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70)
            let v84 : obj = createObj v83
            let v85 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
            let v86 : string = "createComponent"
            let v87 : string = "solid-js"
            let v88 : JS.Function = import v86 v87
            let v89 : JSX.Element = v88.Invoke (v85, v84) |> unbox<JSX.Element>
            v89
        | US14_1 -> (* CheckEnabled *)
            let v90 : string = "Checkbox"
            let v91 : string = "@hope-ui/solid"
            let v92 : JS.Function = import v90 v91
            let struct (v93 : US3, v94 : US3, v95 : US5, v96 : US3, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US6, v103 : US7, v104 : US3, v105 : US3, v106 : US6, v107 : US8, v108 : US3, v109 : US3, v110 : US3, v111 : US9, v112 : US6, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US10, v119 : US3, v120 : US3, v121 : US3, v122 : US10, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US11, v132 : US12, v133 : US11, v134 : US3, v135 : US3, v136 : US3, v137 : US3, v138 : US3, v139 : US3, v140 : US3, v141 : US3, v142 : US3, v143 : US3, v144 : US3, v145 : US3, v146 : US3, v147 : US3, v148 : US3, v149 : US10, v150 : US3, v151 : US3, v152 : US8, v153 : US3, v154 : US2, v155 : US3) = method5()
            let v156 : bool = v2 ()
            let v157 : US6 = US6_1(v156)
            let v158 : (unit -> (JSX.Element [])) = closure16(v3)
            let v159 : US7 = US7_1(v158)
            let v160 : string = "neutral"
            let v161 : US3 = US3_1(v160)
            let v162 : string = "2px"
            let v163 : US3 = US3_1(v162)
            let v164 : (obj -> unit) = closure18(v1)
            let v165 : US11 = US11_1(v164)
            let v166 : string = "sm"
            let v167 : US3 = US3_1(v166)
            let v168 : ((string * obj) []) = method7(v93, v94, v95, v96, v97, v98, v99, v100, v101, v157, v159, v104, v161, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v163, v126, v127, v128, v129, v130, v165, v132, v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v143, v167, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155)
            let v169 : obj = createObj v168
            let v170 : (obj -> JSX.Element) = v92 |> unbox<obj -> JSX.Element>
            let v171 : string = "createComponent"
            let v172 : string = "solid-js"
            let v173 : JS.Function = import v171 v172
            let v174 : JSX.Element = v173.Invoke (v170, v169) |> unbox<JSX.Element>
            v174
        | US14_2 -> (* CheckHidden *)
            v3
    [|v175|]
and closure19 () () : (JSX.Element []) =
    let v0 : string = "&nbsp;"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure22 (v0 : (unit -> bool)) () : (obj []) =
    let v1 : bool = v0 ()
    let v2 : obj = v1
    [|v2|]
and closure23 (v0 : (bool -> unit), v1 : (unit -> bool)) () : unit =
    let v2 : bool = v1 ()
    if v2 then
        v0 false
        ()
and closure24 (v0 : Mut1, v1 : JS.Function) (v2 : (Mut1 -> (Mut1 -> unit))) : unit =
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
and closure28 () () : (JSX.Element []) =
    [||]
and method17 (v0 : int32, v1 : Mut6) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method16 (v0 : Mut2, v1 : Mut2) : unit =
    let v2 : (string []) = JS.Constructors.Object.keys v0 |> unbox<string[]>
    let v3 : int32 = v2.Length
    let v4 : Mut6 = {l0 = 0} : Mut6
    while method17(v3, v4) do
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
and method15 (v0 : Mut2) : JSX.Element =
    let v1 : US7 = v0.l10
    let v4 : (unit -> (JSX.Element [])) =
        match v1 with
        | US7_0 -> (* None *)
            closure28()
        | US7_1(v3) -> (* Some *)
            v3
    let v5 : string = "Button"
    let v6 : string = "@hope-ui/solid"
    let v7 : JS.Function = import v5 v6
    let struct (v8 : US3, v9 : US3, v10 : US5, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US6, v18 : US7, v19 : US3, v20 : US3, v21 : US6, v22 : US8, v23 : US3, v24 : US3, v25 : US3, v26 : US9, v27 : US6, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US10, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US11, v47 : US12, v48 : US11, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US10, v65 : US3, v66 : US3, v67 : US8, v68 : US3, v69 : US2, v70 : US3) = method5()
    let struct (v71 : US3, v72 : US3, v73 : US5, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US6, v81 : US7, v82 : US3, v83 : US3, v84 : US6, v85 : US8, v86 : US3, v87 : US3, v88 : US3, v89 : US9, v90 : US6, v91 : US3, v92 : US3, v93 : US3, v94 : US3, v95 : US3, v96 : US10, v97 : US3, v98 : US3, v99 : US3, v100 : US10, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US11, v110 : US12, v111 : US11, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US10, v128 : US3, v129 : US3, v130 : US8, v131 : US3, v132 : US2, v133 : US3) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61, v0.l62
    let v134 : Mut2 = {l0 = v71; l1 = v72; l2 = v73; l3 = v74; l4 = v75; l5 = v76; l6 = v77; l7 = v78; l8 = v79; l9 = v80; l10 = v81; l11 = v82; l12 = v83; l13 = v84; l14 = v85; l15 = v86; l16 = v87; l17 = v88; l18 = v89; l19 = v90; l20 = v91; l21 = v92; l22 = v93; l23 = v94; l24 = v95; l25 = v96; l26 = v97; l27 = v98; l28 = v99; l29 = v100; l30 = v101; l31 = v102; l32 = v103; l33 = v104; l34 = v105; l35 = v106; l36 = v107; l37 = v108; l38 = v109; l39 = v110; l40 = v111; l41 = v112; l42 = v113; l43 = v114; l44 = v115; l45 = v116; l46 = v117; l47 = v118; l48 = v119; l49 = v120; l50 = v121; l51 = v122; l52 = v123; l53 = v124; l54 = v125; l55 = v126; l56 = v127; l57 = v128; l58 = v129; l59 = v130; l60 = v131; l61 = v132; l62 = v133} : Mut2
    let v135 : string = "neutral"
    let v136 : US3 = US3_1(v135)
    let v137 : US6 = US6_1(true)
    let v138 : string = "left"
    let v139 : US3 = US3_1(v138)
    let v140 : string = "xs"
    let v141 : US3 = US3_1(v140)
    let v142 : Mut2 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v18; l11 = v19; l12 = v136; l13 = v137; l14 = v22; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v34; l27 = v139; l28 = v36; l29 = v37; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50; l43 = v51; l44 = v52; l45 = v53; l46 = v54; l47 = v55; l48 = v56; l49 = v57; l50 = v58; l51 = v141; l52 = v60; l53 = v61; l54 = v62; l55 = v63; l56 = v64; l57 = v65; l58 = v66; l59 = v67; l60 = v68; l61 = v69; l62 = v70} : Mut2
    method16(v142, v134)
    let struct (v143 : US3, v144 : US3, v145 : US5, v146 : US3, v147 : US3, v148 : US3, v149 : US3, v150 : US3, v151 : US3, v152 : US6, v153 : US7, v154 : US3, v155 : US3, v156 : US6, v157 : US8, v158 : US3, v159 : US3, v160 : US3, v161 : US9, v162 : US6, v163 : US3, v164 : US3, v165 : US3, v166 : US3, v167 : US3, v168 : US10, v169 : US3, v170 : US3, v171 : US3, v172 : US10, v173 : US3, v174 : US3, v175 : US3, v176 : US3, v177 : US3, v178 : US3, v179 : US3, v180 : US3, v181 : US11, v182 : US12, v183 : US11, v184 : US3, v185 : US3, v186 : US3, v187 : US3, v188 : US3, v189 : US3, v190 : US3, v191 : US3, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US3, v197 : US3, v198 : US3, v199 : US10, v200 : US3, v201 : US3, v202 : US8, v203 : US3, v204 : US2, v205 : US3) = v142.l0, v142.l1, v142.l2, v142.l3, v142.l4, v142.l5, v142.l6, v142.l7, v142.l8, v142.l9, v142.l10, v142.l11, v142.l12, v142.l13, v142.l14, v142.l15, v142.l16, v142.l17, v142.l18, v142.l19, v142.l20, v142.l21, v142.l22, v142.l23, v142.l24, v142.l25, v142.l26, v142.l27, v142.l28, v142.l29, v142.l30, v142.l31, v142.l32, v142.l33, v142.l34, v142.l35, v142.l36, v142.l37, v142.l38, v142.l39, v142.l40, v142.l41, v142.l42, v142.l43, v142.l44, v142.l45, v142.l46, v142.l47, v142.l48, v142.l49, v142.l50, v142.l51, v142.l52, v142.l53, v142.l54, v142.l55, v142.l56, v142.l57, v142.l58, v142.l59, v142.l60, v142.l61, v142.l62
    let v206 : US7 = US7_1(v4)
    let v207 : ((string * obj) []) = method7(v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v206, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205)
    let v208 : obj = createObj v207
    let v209 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    let v210 : string = "createComponent"
    let v211 : string = "solid-js"
    let v212 : JS.Function = import v210 v211
    let v213 : JSX.Element = v212.Invoke (v209, v208) |> unbox<JSX.Element>
    v213
and closure27 () (v0 : Mut2) : JSX.Element =
    method15(v0)
and closure29 () () : (JSX.Element []) =
    let v0 : string = "Load"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure30 (v0 : (bool -> unit), v1 : Mut5, v2 : Mut1, v3 : JS.Function) () : unit =
    let v4 : US13 = v1.l2
    match v4 with
    | US13_0 -> (* None *)
        ()
    | US13_1(v5) -> (* Some *)
        let v6 : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) = v5 v2
        let v7 : ((Mut1 -> (Mut1 -> unit)) -> unit) = closure24(v2, v3)
        v6 v7
        ()
    v0 true
    ()
and closure26 (v0 : (bool -> unit), v1 : Mut5, v2 : Mut1, v3 : JS.Function) () : (JSX.Element []) =
    let v4 : (Mut2 -> JSX.Element) = closure27()
    let v5 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let struct (v6 : US3, v7 : US3, v8 : US5, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US6, v16 : US7, v17 : US3, v18 : US3, v19 : US6, v20 : US8, v21 : US3, v22 : US3, v23 : US3, v24 : US9, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US10, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US11, v45 : US12, v46 : US11, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US10, v63 : US3, v64 : US3, v65 : US8, v66 : US3, v67 : US2, v68 : US3) = method5()
    let v69 : (unit -> (JSX.Element [])) = closure29()
    let v70 : US7 = US7_1(v69)
    let v71 : (unit -> unit) = closure30(v0, v1, v2, v3)
    let v72 : US12 = US12_1(v71)
    let v73 : Mut2 = {l0 = v6; l1 = v7; l2 = v8; l3 = v9; l4 = v10; l5 = v11; l6 = v12; l7 = v13; l8 = v14; l9 = v15; l10 = v70; l11 = v17; l12 = v18; l13 = v19; l14 = v20; l15 = v21; l16 = v22; l17 = v23; l18 = v24; l19 = v25; l20 = v26; l21 = v27; l22 = v28; l23 = v29; l24 = v30; l25 = v31; l26 = v32; l27 = v33; l28 = v34; l29 = v35; l30 = v36; l31 = v37; l32 = v38; l33 = v39; l34 = v40; l35 = v41; l36 = v42; l37 = v43; l38 = v44; l39 = v72; l40 = v46; l41 = v47; l42 = v48; l43 = v49; l44 = v50; l45 = v51; l46 = v52; l47 = v53; l48 = v54; l49 = v55; l50 = v56; l51 = v57; l52 = v58; l53 = v59; l54 = v60; l55 = v61; l56 = v62; l57 = v63; l58 = v64; l59 = v65; l60 = v66; l61 = v67; l62 = v68} : Mut2
    emitJsExpr (v73, v69) "$0.children = $1"
    let v74 : obj = v73
    let v75 : string = "createComponent"
    let v76 : string = "solid-js"
    let v77 : JS.Function = import v75 v76
    let v78 : JSX.Element = v77.Invoke (v5, v74) |> unbox<JSX.Element>
    [|v78|]
and closure35 () () : (JSX.Element []) =
    [||]
and method18 (v0 : Mut7) : JSX.Element =
    let v1 : string = "Icon"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method5()
    let v67 : (unit -> JS.Function) = v0.l1
    let v68 : JS.Function = v67 ()
    let struct (v69 : US3, v70 : US3, v71 : US5, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US6, v79 : US7, v80 : US3, v81 : US3, v82 : US6, v83 : US8, v84 : US3, v85 : US3, v86 : US3, v87 : US9, v88 : US6, v89 : US3, v90 : US3, v91 : US3, v92 : US3, v93 : US3, v94 : US10, v95 : US3, v96 : US3, v97 : US3, v98 : US10, v99 : US3, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US11, v108 : US12, v109 : US11, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US10, v126 : US3, v127 : US3, v128 : US8, v129 : US3, v130 : US2, v131 : US3) = method5()
    let v132 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = v0.l0
    let v133 : string = "-12px"
    let v134 : US3 = US3_1(v133)
    let v135 : US3 = US3_1(v133)
    let v136 : string = "0.6"
    let v137 : US3 = US3_1(v136)
    let struct (v138 : US3, v139 : US3, v140 : US5, v141 : US3, v142 : US3, v143 : US3, v144 : US3, v145 : US3, v146 : US3, v147 : US6, v148 : US7, v149 : US3, v150 : US3, v151 : US6, v152 : US8, v153 : US3, v154 : US3, v155 : US3, v156 : US9, v157 : US6, v158 : US3, v159 : US3, v160 : US3, v161 : US3, v162 : US3, v163 : US10, v164 : US3, v165 : US3, v166 : US3, v167 : US10, v168 : US3, v169 : US3, v170 : US3, v171 : US3, v172 : US3, v173 : US3, v174 : US3, v175 : US3, v176 : US11, v177 : US12, v178 : US11, v179 : US3, v180 : US3, v181 : US3, v182 : US3, v183 : US3, v184 : US3, v185 : US3, v186 : US3, v187 : US3, v188 : US3, v189 : US3, v190 : US3, v191 : US3, v192 : US3, v193 : US3, v194 : US10, v195 : US3, v196 : US3, v197 : US8, v198 : US3, v199 : US2, v200 : US3) = v132 struct (v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v134, v103, v135, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v137)
    let v201 : ((string * obj) []) = method7(v138, v139, v140, v141, v142, v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200)
    let v202 : obj = createObj v201
    let v203 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = v0.l2
    let v204 : US5 = US5_1(v68)
    let v205 : US8 = US8_1(v202)
    let v206 : string = "14px"
    let v207 : US3 = US3_1(v206)
    let struct (v208 : US3, v209 : US3, v210 : US5, v211 : US3, v212 : US3, v213 : US3, v214 : US3, v215 : US3, v216 : US3, v217 : US6, v218 : US7, v219 : US3, v220 : US3, v221 : US6, v222 : US8, v223 : US3, v224 : US3, v225 : US3, v226 : US9, v227 : US6, v228 : US3, v229 : US3, v230 : US3, v231 : US3, v232 : US3, v233 : US10, v234 : US3, v235 : US3, v236 : US3, v237 : US10, v238 : US3, v239 : US3, v240 : US3, v241 : US3, v242 : US3, v243 : US3, v244 : US3, v245 : US3, v246 : US11, v247 : US12, v248 : US11, v249 : US3, v250 : US3, v251 : US3, v252 : US3, v253 : US3, v254 : US3, v255 : US3, v256 : US3, v257 : US3, v258 : US3, v259 : US3, v260 : US3, v261 : US3, v262 : US3, v263 : US3, v264 : US10, v265 : US3, v266 : US3, v267 : US8, v268 : US3, v269 : US2, v270 : US3) = v203 struct (v4, v5, v204, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v205, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v207, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66)
    let v271 : (unit -> (JSX.Element [])) = closure35()
    let v272 : US7 = US7_1(v271)
    let v273 : ((string * obj) []) = method7(v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v272, v219, v220, v221, v222, v223, v224, v225, v226, v227, v228, v229, v230, v231, v232, v233, v234, v235, v236, v237, v238, v239, v240, v241, v242, v243, v244, v245, v246, v247, v248, v249, v250, v251, v252, v253, v254, v255, v256, v257, v258, v259, v260, v261, v262, v263, v264, v265, v266, v267, v268, v269, v270)
    let v274 : obj = createObj v273
    let v275 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v276 : string = "createComponent"
    let v277 : string = "solid-js"
    let v278 : JS.Function = import v276 v277
    let v279 : JSX.Element = v278.Invoke (v275, v274) |> unbox<JSX.Element>
    v279
and closure34 () (v0 : Mut7) : JSX.Element =
    method18(v0)
and closure36 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure37 () () : JS.Function =
    let v0 : string = "BiRegularRefresh"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure38 () () : (JSX.Element []) =
    [||]
and closure39 (v0 : (bool -> unit)) () : unit =
    v0 true
    ()
and closure40 () () : JS.Function =
    let v0 : string = "BiRegularDownArrow"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure41 () () : JS.Function =
    let v0 : string = "BiRegularUpArrow"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure42 () () : (JSX.Element []) =
    [||]
and closure43 (v0 : Mut1, v1 : JS.Function, v2 : int32, v3 : (bool -> unit), v4 : (unit -> bool)) () : unit =
    let v5 : bool = v4 ()
    let v6 : bool = v5 = false
    v3 v6
    let v7 : ((string * obj) []) = Array.zeroCreate<(string * obj)> (0)
    let v8 : obj = createObj v7
    let v9 : Mut1 = v8 |> unbox
    let v12 : US2 =
        if v6 then
            US2_1(v2)
        else
            US2_0
    v9.l9 <- v12
    let v13 : string = JS.JSON.stringify v9
    let v14 : string = "use_store dispatch"
    let v15 : string = "new_state(new):"
    printfn $"%A{struct (v14, v15, v13)}"
    let v16 : obj = v9
    v1.Invoke ("set", v16) |> ignore
    ()
and closure44 () () : JS.Function =
    let v0 : string = "BiRegularUndo"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure45 () () : (JSX.Element []) =
    [||]
and closure46 (v0 : (bool -> unit)) () : unit =
    v0 false
    ()
and closure33 (v0 : Mut1, v1 : JS.Function, v2 : int32, v3 : (bool -> unit), v4 : (bool -> unit), v5 : (bool -> unit), v6 : (unit -> bool)) () : (JSX.Element []) =
    let v7 : string = "IconButton"
    let v8 : string = "@hope-ui/solid"
    let v9 : JS.Function = import v7 v8
    let struct (v10 : US3, v11 : US3, v12 : US5, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US3, v19 : US6, v20 : US7, v21 : US3, v22 : US3, v23 : US6, v24 : US8, v25 : US3, v26 : US3, v27 : US3, v28 : US9, v29 : US6, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US10, v36 : US3, v37 : US3, v38 : US3, v39 : US10, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US11, v49 : US12, v50 : US11, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US10, v67 : US3, v68 : US3, v69 : US8, v70 : US3, v71 : US2, v72 : US3) = method5()
    let v73 : (Mut7 -> JSX.Element) = closure34()
    let v74 : (obj -> JSX.Element) = v73 |> unbox<obj -> JSX.Element>
    let v75 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure36()
    let v76 : (unit -> JS.Function) = closure37()
    let v77 : Mut7 = {l0 = v75; l1 = v76; l2 = v75} : Mut7
    let v78 : obj = v77
    let v79 : string = "createComponent"
    let v80 : string = "solid-js"
    let v81 : JS.Function = import v79 v80
    let v82 : JSX.Element = v81.Invoke (v74, v78) |> unbox<JSX.Element>
    let v83 : string = "Refresh"
    let v84 : US3 = US3_1(v83)
    let v85 : (unit -> (JSX.Element [])) = closure38()
    let v86 : US7 = US7_1(v85)
    let v87 : string = "neutral"
    let v88 : US3 = US3_1(v87)
    let v89 : string = "20px"
    let v90 : US3 = US3_1(v89)
    let v91 : US10 = US10_1(v82)
    let v92 : (unit -> unit) = closure39(v4)
    let v93 : US12 = US12_1(v92)
    let v94 : string = "xs"
    let v95 : US3 = US3_1(v94)
    let v96 : ((string * obj) []) = method7(v10, v84, v12, v13, v14, v15, v16, v17, v18, v19, v86, v21, v88, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v90, v34, v91, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v93, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v95, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v97 : obj = createObj v96
    let v98 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    let v99 : JS.Function = import v79 v80
    let v100 : JSX.Element = v99.Invoke (v98, v97) |> unbox<JSX.Element>
    let v101 : JS.Function = import v7 v8
    let struct (v102 : US3, v103 : US3, v104 : US5, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US6, v112 : US7, v113 : US3, v114 : US3, v115 : US6, v116 : US8, v117 : US3, v118 : US3, v119 : US3, v120 : US9, v121 : US6, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US10, v128 : US3, v129 : US3, v130 : US3, v131 : US10, v132 : US3, v133 : US3, v134 : US3, v135 : US3, v136 : US3, v137 : US3, v138 : US3, v139 : US3, v140 : US11, v141 : US12, v142 : US11, v143 : US3, v144 : US3, v145 : US3, v146 : US3, v147 : US3, v148 : US3, v149 : US3, v150 : US3, v151 : US3, v152 : US3, v153 : US3, v154 : US3, v155 : US3, v156 : US3, v157 : US3, v158 : US10, v159 : US3, v160 : US3, v161 : US8, v162 : US3, v163 : US2, v164 : US3) = method5()
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
            closure40()
        else
            closure41()
    let v173 : (obj -> JSX.Element) = v73 |> unbox<obj -> JSX.Element>
    let v174 : Mut7 = {l0 = v75; l1 = v172; l2 = v75} : Mut7
    let v175 : obj = v174
    let v176 : JS.Function = import v79 v80
    let v177 : JSX.Element = v176.Invoke (v173, v175) |> unbox<JSX.Element>
    let v178 : US3 = US3_1(v168)
    let v179 : (unit -> (JSX.Element [])) = closure42()
    let v180 : US7 = US7_1(v179)
    let v181 : US3 = US3_1(v87)
    let v182 : US3 = US3_1(v89)
    let v183 : US10 = US10_1(v177)
    let v184 : (unit -> unit) = closure43(v0, v1, v2, v5, v6)
    let v185 : US12 = US12_1(v184)
    let v186 : US3 = US3_1(v94)
    let v187 : ((string * obj) []) = method7(v102, v178, v104, v105, v106, v107, v108, v109, v110, v111, v180, v113, v181, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v182, v126, v183, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140, v185, v142, v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v186, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164)
    let v188 : obj = createObj v187
    let v189 : (obj -> JSX.Element) = v101 |> unbox<obj -> JSX.Element>
    let v190 : JS.Function = import v79 v80
    let v191 : JSX.Element = v190.Invoke (v189, v188) |> unbox<JSX.Element>
    let v192 : JS.Function = import v7 v8
    let struct (v193 : US3, v194 : US3, v195 : US5, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US3, v201 : US3, v202 : US6, v203 : US7, v204 : US3, v205 : US3, v206 : US6, v207 : US8, v208 : US3, v209 : US3, v210 : US3, v211 : US9, v212 : US6, v213 : US3, v214 : US3, v215 : US3, v216 : US3, v217 : US3, v218 : US10, v219 : US3, v220 : US3, v221 : US3, v222 : US10, v223 : US3, v224 : US3, v225 : US3, v226 : US3, v227 : US3, v228 : US3, v229 : US3, v230 : US3, v231 : US11, v232 : US12, v233 : US11, v234 : US3, v235 : US3, v236 : US3, v237 : US3, v238 : US3, v239 : US3, v240 : US3, v241 : US3, v242 : US3, v243 : US3, v244 : US3, v245 : US3, v246 : US3, v247 : US3, v248 : US3, v249 : US10, v250 : US3, v251 : US3, v252 : US8, v253 : US3, v254 : US2, v255 : US3) = method5()
    let v256 : (obj -> JSX.Element) = v73 |> unbox<obj -> JSX.Element>
    let v257 : (unit -> JS.Function) = closure44()
    let v258 : Mut7 = {l0 = v75; l1 = v257; l2 = v75} : Mut7
    let v259 : obj = v258
    let v260 : JS.Function = import v79 v80
    let v261 : JSX.Element = v260.Invoke (v256, v259) |> unbox<JSX.Element>
    let v262 : string = "Unload"
    let v263 : US3 = US3_1(v262)
    let v264 : (unit -> (JSX.Element [])) = closure45()
    let v265 : US7 = US7_1(v264)
    let v266 : US3 = US3_1(v87)
    let v267 : US3 = US3_1(v89)
    let v268 : US10 = US10_1(v261)
    let v269 : (unit -> unit) = closure46(v3)
    let v270 : US12 = US12_1(v269)
    let v271 : US3 = US3_1(v94)
    let v272 : ((string * obj) []) = method7(v193, v263, v195, v196, v197, v198, v199, v200, v201, v202, v265, v204, v266, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v267, v217, v268, v219, v220, v221, v222, v223, v224, v225, v226, v227, v228, v229, v230, v231, v270, v233, v234, v235, v236, v237, v238, v239, v240, v241, v242, v243, v271, v245, v246, v247, v248, v249, v250, v251, v252, v253, v254, v255)
    let v273 : obj = createObj v272
    let v274 : (obj -> JSX.Element) = v192 |> unbox<obj -> JSX.Element>
    let v275 : JS.Function = import v79 v80
    let v276 : JSX.Element = v275.Invoke (v274, v273) |> unbox<JSX.Element>
    [|v100; v191; v276|]
and closure32 (v0 : Mut1, v1 : JS.Function, v2 : int32, v3 : (bool -> unit), v4 : (bool -> unit), v5 : (unit -> bool), v6 : (bool -> unit), v7 : (unit -> bool), v8 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v9 : string = "Stack"
    let v10 : string = "@hope-ui/solid"
    let v11 : JS.Function = import v9 v10
    let struct (v12 : US3, v13 : US3, v14 : US5, v15 : US3, v16 : US3, v17 : US3, v18 : US3, v19 : US3, v20 : US3, v21 : US6, v22 : US7, v23 : US3, v24 : US3, v25 : US6, v26 : US8, v27 : US3, v28 : US3, v29 : US3, v30 : US9, v31 : US6, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US10, v38 : US3, v39 : US3, v40 : US3, v41 : US10, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US11, v51 : US12, v52 : US11, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US3, v67 : US3, v68 : US10, v69 : US3, v70 : US3, v71 : US8, v72 : US3, v73 : US2, v74 : US3) = method5()
    let v75 : US2 = v0.l9
    let v84 : US3 =
        match v75 with
        | US2_0 -> (* None *)
            US3_0
        | US2_1(v77) -> (* Some *)
            let v78 : bool = v77 = v2
            let v79 : bool = v78 <> true
            if v79 then
                let v80 : string = "none"
                US3_1(v80)
            else
                US3_0
    let v85 : (unit -> (JSX.Element [])) = closure33(v0, v1, v2, v3, v4, v6, v7)
    let v86 : US7 = US7_1(v85)
    let v87 : string = "row"
    let v88 : US3 = US3_1(v87)
    let v89 : string = "absolute"
    let v90 : US3 = US3_1(v89)
    let v91 : string = "6px"
    let v92 : US3 = US3_1(v91)
    let v93 : string = "3px"
    let v94 : US3 = US3_1(v93)
    let v95 : US3 = US3_1(v91)
    let v96 : int32 = 1
    let v97 : US2 = US2_1(v96)
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
and closure31 (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3, v63 : Mut1, v64 : JS.Function, v65 : int32, v66 : (bool -> unit), v67 : (bool -> unit), v68 : (unit -> bool), v69 : (bool -> unit), v70 : (unit -> bool)) () : (JSX.Element []) =
    let v159 : JSX.Element =
        match v10 with
        | US7_0 -> (* None *)
            let v71 : JSX.Element = Html.fragment []
            v71
        | US7_1(v72) -> (* Some *)
            let v73 : string = "Box"
            let v74 : string = "@hope-ui/solid"
            let v75 : JS.Function = import v73 v74
            let struct (v76 : US3, v77 : US3, v78 : US5, v79 : US3, v80 : US3, v81 : US3, v82 : US3, v83 : US3, v84 : US3, v85 : US6, v86 : US7, v87 : US3, v88 : US3, v89 : US6, v90 : US8, v91 : US3, v92 : US3, v93 : US3, v94 : US9, v95 : US6, v96 : US3, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US10, v102 : US3, v103 : US3, v104 : US3, v105 : US10, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US11, v115 : US12, v116 : US11, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US10, v133 : US3, v134 : US3, v135 : US8, v136 : US3, v137 : US2, v138 : US3) = method5()
            let v139 : US2 = v63.l9
            let v141 : bool =
                match v139 with
                | US2_0 -> (* None *)
                    true
                | _ ->
                    false
            let v145 : US3 =
                if v141 then
                    let v142 : string = "relative"
                    US3_1(v142)
                else
                    US3_0
            let v146 : (unit -> (JSX.Element [])) = closure32(v63, v64, v65, v66, v67, v68, v69, v70, v72)
            let v147 : US7 = US7_1(v146)
            let v148 : string = "flex"
            let v149 : US3 = US3_1(v148)
            let v150 : string = "1"
            let v151 : US3 = US3_1(v150)
            let v152 : ((string * obj) []) = method7(v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v147, v87, v88, v89, v90, v91, v92, v149, v94, v95, v151, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v145, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138)
            let v153 : obj = createObj v152
            let v154 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
            let v155 : string = "createComponent"
            let v156 : string = "solid-js"
            let v157 : JS.Function = import v155 v156
            let v158 : JSX.Element = v157.Invoke (v154, v153) |> unbox<JSX.Element>
            v158
    [|v159|]
and closure25 (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3, v63 : Mut1, v64 : JS.Function, v65 : int32, v66 : (bool -> unit), v67 : (unit -> bool), v68 : (bool -> unit), v69 : (unit -> bool), v70 : (bool -> unit), v71 : (unit -> bool), v72 : Mut5) () : (JSX.Element []) =
    let v73 : bool = v67 ()
    let v74 : bool = v73 = false
    let v265 : JSX.Element =
        if v74 then
            let v75 : string = "Box"
            let v76 : string = "@hope-ui/solid"
            let v77 : JS.Function = import v75 v76
            let struct (v78 : US3, v79 : US3, v80 : US5, v81 : US3, v82 : US3, v83 : US3, v84 : US3, v85 : US3, v86 : US3, v87 : US6, v88 : US7, v89 : US3, v90 : US3, v91 : US6, v92 : US8, v93 : US3, v94 : US3, v95 : US3, v96 : US9, v97 : US6, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US3, v103 : US10, v104 : US3, v105 : US3, v106 : US3, v107 : US10, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US11, v117 : US12, v118 : US11, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US10, v135 : US3, v136 : US3, v137 : US8, v138 : US3, v139 : US2, v140 : US3) = method5()
            let v141 : (unit -> (JSX.Element [])) = closure26(v66, v72, v63, v64)
            let v142 : US7 = US7_1(v141)
            let v143 : string = "3px 0"
            let v144 : US3 = US3_1(v143)
            let v145 : ((string * obj) []) = method7(v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v142, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v144, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, v138, v139, v140)
            let v146 : obj = createObj v145
            let v147 : (obj -> JSX.Element) = v77 |> unbox<obj -> JSX.Element>
            let v148 : string = "createComponent"
            let v149 : string = "solid-js"
            let v150 : JS.Function = import v148 v149
            let v151 : JSX.Element = v150.Invoke (v147, v146) |> unbox<JSX.Element>
            v151
        else
            let v152 : string = "Box"
            let v153 : string = "@hope-ui/solid"
            let v154 : JS.Function = import v152 v153
            let struct (v155 : US3, v156 : US3, v157 : US5, v158 : US3, v159 : US3, v160 : US3, v161 : US3, v162 : US3, v163 : US3, v164 : US6, v165 : US7, v166 : US3, v167 : US3, v168 : US6, v169 : US8, v170 : US3, v171 : US3, v172 : US3, v173 : US9, v174 : US6, v175 : US3, v176 : US3, v177 : US3, v178 : US3, v179 : US3, v180 : US10, v181 : US3, v182 : US3, v183 : US3, v184 : US10, v185 : US3, v186 : US3, v187 : US3, v188 : US3, v189 : US3, v190 : US3, v191 : US3, v192 : US3, v193 : US11, v194 : US12, v195 : US11, v196 : US3, v197 : US3, v198 : US3, v199 : US3, v200 : US3, v201 : US3, v202 : US3, v203 : US3, v204 : US3, v205 : US3, v206 : US3, v207 : US3, v208 : US3, v209 : US3, v210 : US3, v211 : US10, v212 : US3, v213 : US3, v214 : US8, v215 : US3, v216 : US2, v217 : US3) = method5()
            let v218 : bool = v71 ()
            let v221 : US2 =
                if v218 then
                    US2_1(1)
                else
                    US2_0
            let v222 : bool = v71 ()
            let v226 : US3 =
                if v222 then
                    let v223 : string = "absolute"
                    US3_1(v223)
                else
                    US3_0
            let v227 : bool = v71 ()
            let v231 : US3 =
                if v227 then
                    let v228 : string = "0"
                    US3_1(v228)
                else
                    US3_0
            let v232 : bool = v71 ()
            let v236 : US3 =
                if v232 then
                    let v233 : string = "0"
                    US3_1(v233)
                else
                    US3_0
            let v237 : bool = v71 ()
            let v241 : US3 =
                if v237 then
                    let v238 : string = "0"
                    US3_1(v238)
                else
                    US3_0
            let v242 : bool = v71 ()
            let v246 : US3 =
                if v242 then
                    let v243 : string = "0"
                    US3_1(v243)
                else
                    US3_0
            let v247 : bool = v71 ()
            let v251 : US3 =
                if v247 then
                    let v248 : string = "$bg"
                    US3_1(v248)
                else
                    US3_0
            let v252 : (unit -> (JSX.Element [])) = closure31(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v68, v69, v70, v71)
            let v253 : US7 = US7_1(v252)
            let v254 : string = "flex"
            let v255 : US3 = US3_1(v254)
            let v256 : string = "1"
            let v257 : US3 = US3_1(v256)
            let v258 : ((string * obj) []) = method7(v155, v156, v157, v251, v159, v160, v161, v162, v241, v164, v253, v166, v167, v168, v169, v170, v171, v255, v173, v174, v257, v176, v177, v178, v179, v180, v181, v182, v246, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v226, v236, v206, v207, v208, v209, v210, v211, v231, v213, v214, v215, v221, v217)
            let v259 : obj = createObj v258
            let v260 : (obj -> JSX.Element) = v154 |> unbox<obj -> JSX.Element>
            let v261 : string = "createComponent"
            let v262 : string = "solid-js"
            let v263 : JS.Function = import v261 v262
            let v264 : JSX.Element = v263.Invoke (v260, v259) |> unbox<JSX.Element>
            v264
    [|v265|]
and method14 (v0 : Mut5) : JSX.Element =
    let v1 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = v0.l3
    let struct (v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) = method5()
    let struct (v65 : US3, v66 : US3, v67 : US5, v68 : US3, v69 : US3, v70 : US3, v71 : US3, v72 : US3, v73 : US3, v74 : US6, v75 : US7, v76 : US3, v77 : US3, v78 : US6, v79 : US8, v80 : US3, v81 : US3, v82 : US3, v83 : US9, v84 : US6, v85 : US3, v86 : US3, v87 : US3, v88 : US3, v89 : US3, v90 : US10, v91 : US3, v92 : US3, v93 : US3, v94 : US10, v95 : US3, v96 : US3, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US3, v103 : US11, v104 : US12, v105 : US11, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US10, v122 : US3, v123 : US3, v124 : US8, v125 : US3, v126 : US2, v127 : US3) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64)
    let v128 : string = "useStoreon"
    let v129 : string = "@storeon/solidjs"
    let v130 : JS.Function = import v128 v129
    let v131 : (JS.Function []) = v130.Invoke () |> unbox<JS.Function[]>
    let v132 : Mut1 = v131.[0] |> unbox
    let v133 : JS.Function = v131.[1] |> unbox
    let v134 : int32 = Random().Next ()
    let v135 : bool = v0.l0
    let v136 : string = "createSignal"
    let v137 : string = "solid-js"
    let v138 : JS.Function = import v136 v137
    let v139 : (JS.Function []) = v138.Invoke v135 |> unbox<JS.Function[]>
    let v140 : (unit -> bool) = v139.[0] |> unbox
    let v141 : (bool -> unit) = v139.[1] |> unbox
    let v142 : JS.Function = import v136 v137
    let v143 : (JS.Function []) = v142.Invoke false |> unbox<JS.Function[]>
    let v144 : (unit -> bool) = v143.[0] |> unbox
    let v145 : (bool -> unit) = v143.[1] |> unbox
    let v146 : bool = v0.l1
    let v147 : JS.Function = import v136 v137
    let v148 : (JS.Function []) = v147.Invoke v146 |> unbox<JS.Function[]>
    let v149 : (unit -> bool) = v148.[0] |> unbox
    let v150 : (bool -> unit) = v148.[1] |> unbox
    let v151 : string = "on"
    let v152 : JS.Function = import v151 v137
    let v153 : (unit -> (obj [])) = closure22(v144)
    let v154 : (unit -> unit) = closure23(v145, v144)
    let v155 : JS.Function = v152.Invoke (v153, v154) |> unbox<JS.Function>
    let v156 : string = "createEffect"
    let v157 : JS.Function = import v156 v137
    v157.Invoke v155 |> ignore
    let v158 : bool = v0.l0
    let v159 : bool = v158 = true
    if v159 then
        let v160 : US13 = v0.l2
        match v160 with
        | US13_0 -> (* None *)
            ()
        | US13_1(v161) -> (* Some *)
            let v162 : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) = v161 v132
            let v163 : ((Mut1 -> (Mut1 -> unit)) -> unit) = closure24(v132, v133)
            v162 v163
            ()
    let v164 : string = "Box"
    let v165 : string = "@hope-ui/solid"
    let v166 : JS.Function = import v164 v165
    let struct (v167 : US3, v168 : US3, v169 : US5, v170 : US3, v171 : US3, v172 : US3, v173 : US3, v174 : US3, v175 : US3, v176 : US6, v177 : US7, v178 : US3, v179 : US3, v180 : US6, v181 : US8, v182 : US3, v183 : US3, v184 : US3, v185 : US9, v186 : US6, v187 : US3, v188 : US3, v189 : US3, v190 : US3, v191 : US3, v192 : US10, v193 : US3, v194 : US3, v195 : US3, v196 : US10, v197 : US3, v198 : US3, v199 : US3, v200 : US3, v201 : US3, v202 : US3, v203 : US3, v204 : US3, v205 : US11, v206 : US12, v207 : US11, v208 : US3, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US3, v214 : US3, v215 : US3, v216 : US3, v217 : US3, v218 : US3, v219 : US3, v220 : US3, v221 : US3, v222 : US3, v223 : US10, v224 : US3, v225 : US3, v226 : US8, v227 : US3, v228 : US2, v229 : US3) = method5()
    let v230 : (unit -> (JSX.Element [])) = closure25(v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v132, v133, v134, v141, v140, v145, v144, v150, v149, v0)
    let v231 : US7 = US7_1(v230)
    let v232 : string = "flex"
    let v233 : US3 = US3_1(v232)
    let v234 : string = "1"
    let v235 : US3 = US3_1(v234)
    let v236 : ((string * obj) []) = method7(v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v231, v178, v179, v180, v181, v182, v183, v233, v185, v186, v235, v188, v189, v190, v191, v192, v91, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v220, v221, v222, v223, v224, v225, v226, v227, v228, v229)
    let v237 : obj = createObj v236
    let v238 : (obj -> JSX.Element) = v166 |> unbox<obj -> JSX.Element>
    let v239 : string = "createComponent"
    let v240 : JS.Function = import v239 v137
    let v241 : JSX.Element = v240.Invoke (v238, v237) |> unbox<JSX.Element>
    v241
and closure21 () (v0 : Mut5) : JSX.Element =
    method14(v0)
and closure47 (v0 : (unit -> (JSX.Element []))) struct (v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US10, v58 : US3, v59 : US3, v60 : US8, v61 : US3, v62 : US2, v63 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v64 : US7 = US7_1(v0)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v64, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63)
and closure20 (v0 : Mut4, v1 : (unit -> bool), v2 : (unit -> (JSX.Element []))) () : (JSX.Element []) =
    let v3 : US14 = v0.l2
    let v31 : JSX.Element =
        match v3 with
        | US14_0 -> (* CheckDisabled *)
            let v4 : bool = v1 ()
            if v4 then
                let v5 : US13 = v0.l0
                let v6 : (Mut5 -> JSX.Element) = closure21()
                let v7 : (obj -> JSX.Element) = v6 |> unbox<obj -> JSX.Element>
                let v8 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure47(v2)
                let v9 : Mut5 = {l0 = true; l1 = false; l2 = v5; l3 = v8} : Mut5
                let v10 : obj = v9
                let v11 : string = "createComponent"
                let v12 : string = "solid-js"
                let v13 : JS.Function = import v11 v12
                let v14 : JSX.Element = v13.Invoke (v7, v10) |> unbox<JSX.Element>
                v14
            else
                let v15 : JSX.Element = Html.fragment []
                v15
        | US14_1 -> (* CheckEnabled *)
            let v17 : bool = v1 ()
            if v17 then
                let v18 : US13 = v0.l0
                let v19 : (Mut5 -> JSX.Element) = closure21()
                let v20 : (obj -> JSX.Element) = v19 |> unbox<obj -> JSX.Element>
                let v21 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure47(v2)
                let v22 : Mut5 = {l0 = true; l1 = false; l2 = v18; l3 = v21} : Mut5
                let v23 : obj = v22
                let v24 : string = "createComponent"
                let v25 : string = "solid-js"
                let v26 : JS.Function = import v24 v25
                let v27 : JSX.Element = v26.Invoke (v20, v23) |> unbox<JSX.Element>
                v27
            else
                let v28 : JSX.Element = Html.fragment []
                v28
        | US14_2 -> (* CheckHidden *)
            let v30 : JSX.Element = v2 |> unbox<JSX.Element>
            v30
    [|v31|]
and closure14 (v0 : Mut4, v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US10, v58 : US3, v59 : US3, v60 : US8, v61 : US3, v62 : US2, v63 : US3, v64 : (bool -> unit), v65 : (unit -> bool)) () : (JSX.Element []) =
    let v166 : JSX.Element =
        match v57 with
        | US10_0 -> (* None *)
            let v66 : JSX.Element = Html.fragment []
            v66
        | US10_1(v67) -> (* Some *)
            let v68 : string = "Td"
            let v69 : string = "@hope-ui/solid"
            let v70 : JS.Function = import v68 v69
            let struct (v71 : US3, v72 : US3, v73 : US5, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US6, v81 : US7, v82 : US3, v83 : US3, v84 : US6, v85 : US8, v86 : US3, v87 : US3, v88 : US3, v89 : US9, v90 : US6, v91 : US3, v92 : US3, v93 : US3, v94 : US3, v95 : US3, v96 : US10, v97 : US3, v98 : US3, v99 : US3, v100 : US10, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US3, v109 : US11, v110 : US12, v111 : US11, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US10, v128 : US3, v129 : US3, v130 : US8, v131 : US3, v132 : US2, v133 : US3) = method5()
            let v134 : US14 = v0.l2
            let v136 : bool =
                match v134 with
                | US14_2 -> (* CheckHidden *)
                    true
                | _ ->
                    false
            let v138 : bool =
                if v136 then
                    true
                else
                    let v137 : bool = v65 ()
                    v137
            let v143 : string =
                if v138 then
                    let v139 : string = "2px !important"
                    let v140 : string = "0px !important"
                    method13(v140, v139)
                else
                    let v142 : string = "0px !important"
                    v142
            let v144 : US3 = US3_1(v143)
            let v145 : string = "$neutral5"
            let v146 : US3 = US3_1(v145)
            let v147 : (unit -> (JSX.Element [])) = closure15(v0, v64, v65, v67)
            let v148 : US7 = US7_1(v147)
            let v149 : string = "$neutral9"
            let v150 : US3 = US3_1(v149)
            let v151 : string = "flex"
            let v152 : US3 = US3_1(v151)
            let v153 : string = "column"
            let v154 : US3 = US3_1(v153)
            let v155 : string = "$sm"
            let v156 : US3 = US3_1(v155)
            let v157 : string = "3px 20px 0 8px"
            let v158 : US3 = US3_1(v157)
            let v159 : ((string * obj) []) = method7(v71, v72, v73, v74, v75, v144, v146, v78, v79, v80, v148, v150, v83, v84, v85, v86, v87, v152, v89, v90, v91, v154, v156, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v158, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133)
            let v160 : obj = createObj v159
            let v161 : (obj -> JSX.Element) = v70 |> unbox<obj -> JSX.Element>
            let v162 : string = "createComponent"
            let v163 : string = "solid-js"
            let v164 : JS.Function = import v162 v163
            let v165 : JSX.Element = v164.Invoke (v161, v160) |> unbox<JSX.Element>
            v165
    let v345 : JSX.Element =
        match v11 with
        | US7_0 -> (* None *)
            let v167 : string = "Td"
            let v168 : string = "@hope-ui/solid"
            let v169 : JS.Function = import v167 v168
            let struct (v170 : US3, v171 : US3, v172 : US5, v173 : US3, v174 : US3, v175 : US3, v176 : US3, v177 : US3, v178 : US3, v179 : US6, v180 : US7, v181 : US3, v182 : US3, v183 : US6, v184 : US8, v185 : US3, v186 : US3, v187 : US3, v188 : US9, v189 : US6, v190 : US3, v191 : US3, v192 : US3, v193 : US3, v194 : US3, v195 : US10, v196 : US3, v197 : US3, v198 : US3, v199 : US10, v200 : US3, v201 : US3, v202 : US3, v203 : US3, v204 : US3, v205 : US3, v206 : US3, v207 : US3, v208 : US11, v209 : US12, v210 : US11, v211 : US3, v212 : US3, v213 : US3, v214 : US3, v215 : US3, v216 : US3, v217 : US3, v218 : US3, v219 : US3, v220 : US3, v221 : US3, v222 : US3, v223 : US3, v224 : US3, v225 : US3, v226 : US10, v227 : US3, v228 : US3, v229 : US8, v230 : US3, v231 : US2, v232 : US3) = method5()
            let v233 : string = "0"
            let v234 : US3 = US3_1(v233)
            let v235 : (unit -> (JSX.Element [])) = closure19()
            let v236 : US7 = US7_1(v235)
            let v237 : string = "9px"
            let v238 : US3 = US3_1(v237)
            let v239 : US3 = US3_1(v233)
            let v240 : ((string * obj) []) = method7(v170, v171, v172, v173, v234, v175, v176, v177, v178, v179, v236, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v238, v201, v202, v203, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v239, v215, v216, v217, v218, v219, v220, v221, v222, v223, v224, v225, v226, v227, v228, v229, v230, v231, v232)
            let v241 : obj = createObj v240
            let v242 : (obj -> JSX.Element) = v169 |> unbox<obj -> JSX.Element>
            let v243 : string = "createComponent"
            let v244 : string = "solid-js"
            let v245 : JS.Function = import v243 v244
            let v246 : JSX.Element = v245.Invoke (v242, v241) |> unbox<JSX.Element>
            v246
        | US7_1(v247) -> (* Some *)
            let v248 : string = "Td"
            let v249 : string = "@hope-ui/solid"
            let v250 : JS.Function = import v248 v249
            let struct (v251 : US3, v252 : US3, v253 : US5, v254 : US3, v255 : US3, v256 : US3, v257 : US3, v258 : US3, v259 : US3, v260 : US6, v261 : US7, v262 : US3, v263 : US3, v264 : US6, v265 : US8, v266 : US3, v267 : US3, v268 : US3, v269 : US9, v270 : US6, v271 : US3, v272 : US3, v273 : US3, v274 : US3, v275 : US3, v276 : US10, v277 : US3, v278 : US3, v279 : US3, v280 : US10, v281 : US3, v282 : US3, v283 : US3, v284 : US3, v285 : US3, v286 : US3, v287 : US3, v288 : US3, v289 : US11, v290 : US12, v291 : US11, v292 : US3, v293 : US3, v294 : US3, v295 : US3, v296 : US3, v297 : US3, v298 : US3, v299 : US3, v300 : US3, v301 : US3, v302 : US3, v303 : US3, v304 : US3, v305 : US3, v306 : US3, v307 : US10, v308 : US3, v309 : US3, v310 : US8, v311 : US3, v312 : US2, v313 : US3) = method5()
            let v316 : string =
                match v45 with
                | US3_0 -> (* None *)
                    let v314 : string = "0"
                    v314
                | US3_1(v315) -> (* Some *)
                    v315
            let v317 : string = "0"
            let v318 : US3 = US3_1(v317)
            let v319 : (unit -> (JSX.Element [])) = closure20(v0, v65, v247)
            let v320 : US7 = US7_1(v319)
            let v321 : string = "flex"
            let v322 : US3 = US3_1(v321)
            let v323 : string = "6"
            let v324 : US3 = US3_1(v323)
            let v325 : string = "column"
            let v326 : US3 = US3_1(v325)
            let v327 : string = "$sm"
            let v328 : US3 = US3_1(v327)
            let v329 : string = "$base"
            let v330 : US3 = US3_1(v329)
            let v331 : US3 = US3_1(v317)
            let v332 : string = "85vh"
            let v333 : US3 = US3_1(v332)
            let v334 : US3 = US3_1(v317)
            let v335 : string = "auto"
            let v336 : US3 = US3_1(v335)
            let v337 : US3 = US3_1(v316)
            let v338 : ((string * obj) []) = method7(v251, v252, v253, v254, v318, v256, v257, v258, v259, v260, v320, v262, v263, v264, v265, v266, v267, v322, v269, v270, v324, v326, v328, v274, v275, v276, v277, v278, v279, v280, v330, v331, v283, v284, v285, v286, v333, v288, v289, v290, v291, v334, v293, v336, v337, v296, v297, v298, v299, v300, v301, v302, v303, v304, v305, v306, v307, v308, v309, v310, v311, v312, v313)
            let v339 : obj = createObj v338
            let v340 : (obj -> JSX.Element) = v250 |> unbox<obj -> JSX.Element>
            let v341 : string = "createComponent"
            let v342 : string = "solid-js"
            let v343 : JS.Function = import v341 v342
            let v344 : JSX.Element = v343.Invoke (v340, v339) |> unbox<JSX.Element>
            v344
    [|v166; v345|]
and method12 (v0 : Mut4) : JSX.Element =
    let v1 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = v0.l1
    let struct (v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) = method5()
    let struct (v65 : US3, v66 : US3, v67 : US5, v68 : US3, v69 : US3, v70 : US3, v71 : US3, v72 : US3, v73 : US3, v74 : US6, v75 : US7, v76 : US3, v77 : US3, v78 : US6, v79 : US8, v80 : US3, v81 : US3, v82 : US3, v83 : US9, v84 : US6, v85 : US3, v86 : US3, v87 : US3, v88 : US3, v89 : US3, v90 : US10, v91 : US3, v92 : US3, v93 : US3, v94 : US10, v95 : US3, v96 : US3, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US3, v103 : US11, v104 : US12, v105 : US11, v106 : US3, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US10, v122 : US3, v123 : US3, v124 : US8, v125 : US3, v126 : US2, v127 : US3) = v1 struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64)
    let v128 : US14 = v0.l2
    let v130 : bool =
        match v128 with
        | US14_0 -> (* CheckDisabled *)
            true
        | _ ->
            false
    let v131 : bool = v130 <> true
    let v132 : string = "createSignal"
    let v133 : string = "solid-js"
    let v134 : JS.Function = import v132 v133
    let v135 : (JS.Function []) = v134.Invoke v131 |> unbox<JS.Function[]>
    let v136 : (unit -> bool) = v135.[0] |> unbox
    let v137 : (bool -> unit) = v135.[1] |> unbox
    let v138 : string = "Tr"
    let v139 : string = "@hope-ui/solid"
    let v140 : JS.Function = import v138 v139
    let struct (v141 : US3, v142 : US3, v143 : US5, v144 : US3, v145 : US3, v146 : US3, v147 : US3, v148 : US3, v149 : US3, v150 : US6, v151 : US7, v152 : US3, v153 : US3, v154 : US6, v155 : US8, v156 : US3, v157 : US3, v158 : US3, v159 : US9, v160 : US6, v161 : US3, v162 : US3, v163 : US3, v164 : US3, v165 : US3, v166 : US10, v167 : US3, v168 : US3, v169 : US3, v170 : US10, v171 : US3, v172 : US3, v173 : US3, v174 : US3, v175 : US3, v176 : US3, v177 : US3, v178 : US3, v179 : US11, v180 : US12, v181 : US11, v182 : US3, v183 : US3, v184 : US3, v185 : US3, v186 : US3, v187 : US3, v188 : US3, v189 : US3, v190 : US3, v191 : US3, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US3, v197 : US10, v198 : US3, v199 : US3, v200 : US8, v201 : US3, v202 : US2, v203 : US3) = method5()
    let v204 : string = "column"
    let v205 : string = "row"
    let v206 : string = method13(v205, v204)
    let v207 : string = "$neutral5"
    let v208 : US3 = US3_1(v207)
    let v209 : string = "1px 2px"
    let v210 : US3 = US3_1(v209)
    let v211 : (unit -> (JSX.Element [])) = closure14(v0, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v137, v136)
    let v212 : US7 = US7_1(v211)
    let v213 : string = "flex"
    let v214 : US3 = US3_1(v213)
    let v215 : string = "1"
    let v216 : US3 = US3_1(v215)
    let v217 : US3 = US3_1(v206)
    let v218 : ((string * obj) []) = method7(v141, v142, v143, v144, v145, v146, v208, v210, v149, v150, v212, v152, v153, v154, v155, v156, v157, v214, v159, v160, v216, v217, v163, v164, v165, v166, v91, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195, v196, v197, v198, v199, v200, v201, v202, v203)
    let v219 : obj = createObj v218
    let v220 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    let v221 : string = "createComponent"
    let v222 : JS.Function = import v221 v133
    let v223 : JSX.Element = v222.Invoke (v220, v219) |> unbox<JSX.Element>
    v223
and closure13 () (v0 : Mut4) : JSX.Element =
    method12(v0)
and closure56 (v0 : Mut2) () : (JSX.Element []) =
    let v1 : US3 = v0.l24
    let v4 : string =
        match v1 with
        | US3_0 -> (* None *)
            let v2 : string = ""
            v2
        | US3_1(v3) -> (* Some *)
            v3
    let v5 : JSX.Element = Html.fragment [ v4 |> unbox<JSX.Element> ]
    [|v5|]
and closure57 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : US3 = US3_0
    let v64 : string = "-13px"
    let v65 : US3 = US3_1(v64)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v63, v34, v65, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure58 () () : JS.Function =
    let v0 : string = "BiRegularLinkExternal"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure55 (v0 : Mut2) () : (JSX.Element []) =
    let v1 : string = "Anchor"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method5()
    let struct (v67 : US3, v68 : US3, v69 : US5, v70 : US3, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US6, v77 : US7, v78 : US3, v79 : US3, v80 : US6, v81 : US8, v82 : US3, v83 : US3, v84 : US3, v85 : US9, v86 : US6, v87 : US3, v88 : US3, v89 : US3, v90 : US3, v91 : US3, v92 : US10, v93 : US3, v94 : US3, v95 : US3, v96 : US10, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US11, v106 : US12, v107 : US11, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US10, v124 : US3, v125 : US3, v126 : US8, v127 : US3, v128 : US2, v129 : US3) = v0.l0, v0.l1, v0.l2, v0.l3, v0.l4, v0.l5, v0.l6, v0.l7, v0.l8, v0.l9, v0.l10, v0.l11, v0.l12, v0.l13, v0.l14, v0.l15, v0.l16, v0.l17, v0.l18, v0.l19, v0.l20, v0.l21, v0.l22, v0.l23, v0.l24, v0.l25, v0.l26, v0.l27, v0.l28, v0.l29, v0.l30, v0.l31, v0.l32, v0.l33, v0.l34, v0.l35, v0.l36, v0.l37, v0.l38, v0.l39, v0.l40, v0.l41, v0.l42, v0.l43, v0.l44, v0.l45, v0.l46, v0.l47, v0.l48, v0.l49, v0.l50, v0.l51, v0.l52, v0.l53, v0.l54, v0.l55, v0.l56, v0.l57, v0.l58, v0.l59, v0.l60, v0.l61, v0.l62
    let v130 : Mut2 = {l0 = v67; l1 = v68; l2 = v69; l3 = v70; l4 = v71; l5 = v72; l6 = v73; l7 = v74; l8 = v75; l9 = v76; l10 = v77; l11 = v78; l12 = v79; l13 = v80; l14 = v81; l15 = v82; l16 = v83; l17 = v84; l18 = v85; l19 = v86; l20 = v87; l21 = v88; l22 = v89; l23 = v90; l24 = v91; l25 = v92; l26 = v93; l27 = v94; l28 = v95; l29 = v96; l30 = v97; l31 = v98; l32 = v99; l33 = v100; l34 = v101; l35 = v102; l36 = v103; l37 = v104; l38 = v105; l39 = v106; l40 = v107; l41 = v108; l42 = v109; l43 = v110; l44 = v111; l45 = v112; l46 = v113; l47 = v114; l48 = v115; l49 = v116; l50 = v117; l51 = v118; l52 = v119; l53 = v120; l54 = v121; l55 = v122; l56 = v123; l57 = v124; l58 = v125; l59 = v126; l60 = v127; l61 = v128; l62 = v129} : Mut2
    let v131 : US6 = US6_1(true)
    let v132 : Mut2 = {l0 = v4; l1 = v5; l2 = v6; l3 = v7; l4 = v8; l5 = v9; l6 = v10; l7 = v11; l8 = v12; l9 = v13; l10 = v14; l11 = v15; l12 = v16; l13 = v17; l14 = v18; l15 = v19; l16 = v20; l17 = v21; l18 = v22; l19 = v131; l20 = v24; l21 = v25; l22 = v26; l23 = v27; l24 = v28; l25 = v29; l26 = v30; l27 = v31; l28 = v32; l29 = v33; l30 = v34; l31 = v35; l32 = v36; l33 = v37; l34 = v38; l35 = v39; l36 = v40; l37 = v41; l38 = v42; l39 = v43; l40 = v44; l41 = v45; l42 = v46; l43 = v47; l44 = v48; l45 = v49; l46 = v50; l47 = v51; l48 = v52; l49 = v53; l50 = v54; l51 = v55; l52 = v56; l53 = v57; l54 = v58; l55 = v59; l56 = v60; l57 = v61; l58 = v62; l59 = v63; l60 = v64; l61 = v65; l62 = v66} : Mut2
    method16(v132, v130)
    let struct (v133 : US3, v134 : US3, v135 : US5, v136 : US3, v137 : US3, v138 : US3, v139 : US3, v140 : US3, v141 : US3, v142 : US6, v143 : US7, v144 : US3, v145 : US3, v146 : US6, v147 : US8, v148 : US3, v149 : US3, v150 : US3, v151 : US9, v152 : US6, v153 : US3, v154 : US3, v155 : US3, v156 : US3, v157 : US3, v158 : US10, v159 : US3, v160 : US3, v161 : US3, v162 : US10, v163 : US3, v164 : US3, v165 : US3, v166 : US3, v167 : US3, v168 : US3, v169 : US3, v170 : US3, v171 : US11, v172 : US12, v173 : US11, v174 : US3, v175 : US3, v176 : US3, v177 : US3, v178 : US3, v179 : US3, v180 : US3, v181 : US3, v182 : US3, v183 : US3, v184 : US3, v185 : US3, v186 : US3, v187 : US3, v188 : US3, v189 : US10, v190 : US3, v191 : US3, v192 : US8, v193 : US3, v194 : US2, v195 : US3) = v132.l0, v132.l1, v132.l2, v132.l3, v132.l4, v132.l5, v132.l6, v132.l7, v132.l8, v132.l9, v132.l10, v132.l11, v132.l12, v132.l13, v132.l14, v132.l15, v132.l16, v132.l17, v132.l18, v132.l19, v132.l20, v132.l21, v132.l22, v132.l23, v132.l24, v132.l25, v132.l26, v132.l27, v132.l28, v132.l29, v132.l30, v132.l31, v132.l32, v132.l33, v132.l34, v132.l35, v132.l36, v132.l37, v132.l38, v132.l39, v132.l40, v132.l41, v132.l42, v132.l43, v132.l44, v132.l45, v132.l46, v132.l47, v132.l48, v132.l49, v132.l50, v132.l51, v132.l52, v132.l53, v132.l54, v132.l55, v132.l56, v132.l57, v132.l58, v132.l59, v132.l60, v132.l61, v132.l62
    let v196 : (unit -> (JSX.Element [])) = closure56(v0)
    let v197 : US7 = US7_1(v196)
    let v198 : ((string * obj) []) = method7(v133, v134, v135, v136, v137, v138, v139, v140, v141, v142, v197, v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, v162, v163, v164, v165, v166, v167, v168, v169, v170, v171, v172, v173, v174, v175, v176, v177, v178, v179, v180, v181, v182, v183, v184, v185, v186, v187, v188, v189, v190, v191, v192, v193, v194, v195)
    let v199 : obj = createObj v198
    let v200 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v201 : string = "createComponent"
    let v202 : string = "solid-js"
    let v203 : JS.Function = import v201 v202
    let v204 : JSX.Element = v203.Invoke (v200, v199) |> unbox<JSX.Element>
    let v205 : string = "&nbsp;"
    let v206 : JSX.Element = Html.fragment [ v205 |> unbox<JSX.Element> ]
    let v207 : (Mut7 -> JSX.Element) = closure34()
    let v208 : (obj -> JSX.Element) = v207 |> unbox<obj -> JSX.Element>
    let v209 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure57()
    let v210 : (unit -> JS.Function) = closure58()
    let v211 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure36()
    let v212 : Mut7 = {l0 = v209; l1 = v210; l2 = v211} : Mut7
    let v213 : obj = v212
    let v214 : JS.Function = import v201 v202
    let v215 : JSX.Element = v214.Invoke (v208, v213) |> unbox<JSX.Element>
    [|v204; v206; v215|]
and method20 (v0 : Mut2) : JSX.Element =
    let v1 : string = "Box"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let struct (v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method5()
    let v67 : (unit -> (JSX.Element [])) = closure55(v0)
    let v68 : US7 = US7_1(v67)
    let v69 : ((string * obj) []) = method7(v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v68, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66)
    let v70 : obj = createObj v69
    let v71 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v72 : string = "createComponent"
    let v73 : string = "solid-js"
    let v74 : JS.Function = import v72 v73
    let v75 : JSX.Element = v74.Invoke (v71, v70) |> unbox<JSX.Element>
    v75
and closure54 () (v0 : Mut2) : JSX.Element =
    method20(v0)
and closure59 () () : (JSX.Element []) =
    [||]
and closure53 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure54()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure59()
    let v66 : US7 = US7_1(v65)
    let v67 : string = "https://github.com/fc1943s/tictactoe_spiral"
    let v68 : US3 = US3_1(v67)
    let v69 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v68; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v69, v65) "$0.children = $1"
    let v70 : obj = v69
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v1, v70) |> unbox<JSX.Element>
    [|v74|]
and closure52 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : (unit -> (JSX.Element [])) = closure53()
    let v64 : US7 = US7_1(v63)
    let v65 : string = "1px 6px"
    let v66 : US3 = US3_1(v65)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v64, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v66, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure61 (v0 : string) () : (JSX.Element []) =
    let v1 : (Mut2 -> JSX.Element) = closure54()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let struct (v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) = method5()
    let v66 : (unit -> (JSX.Element [])) = closure59()
    let v67 : US7 = US7_1(v66)
    let v68 : US3 = US3_1(v0)
    let v69 : Mut2 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v67; l11 = v14; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v68; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v47; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v59; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64; l62 = v65} : Mut2
    emitJsExpr (v69, v66) "$0.children = $1"
    let v70 : obj = v69
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v2, v70) |> unbox<JSX.Element>
    [|v74|]
and closure60 (v0 : string) struct (v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US10, v58 : US3, v59 : US3, v60 : US8, v61 : US3, v62 : US2, v63 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v64 : (unit -> (JSX.Element [])) = closure61(v0)
    let v65 : US7 = US7_1(v64)
    let v66 : string = "1px 6px"
    let v67 : US3 = US3_1(v66)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v65, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v67, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63)
and closure63 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure54()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure59()
    let v66 : US7 = US7_1(v65)
    let v67 : string = "https://fc1943s.github.io/tictactoe_spiral"
    let v68 : US3 = US3_1(v67)
    let v69 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v68; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v69, v65) "$0.children = $1"
    let v70 : obj = v69
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v1, v70) |> unbox<JSX.Element>
    [|v74|]
and closure62 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : (unit -> (JSX.Element [])) = closure63()
    let v64 : US7 = US7_1(v63)
    let v65 : string = "1px 6px"
    let v66 : US3 = US3_1(v65)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v64, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v66, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure65 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure54()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure59()
    let v66 : US7 = US7_1(v65)
    let v67 : string = "https://fc1943s.github.io/tictactoe_spiral/docs"
    let v68 : US3 = US3_1(v67)
    let v69 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v68; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v69, v65) "$0.children = $1"
    let v70 : obj = v69
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v1, v70) |> unbox<JSX.Element>
    [|v74|]
and closure64 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : (unit -> (JSX.Element [])) = closure65()
    let v64 : US7 = US7_1(v63)
    let v65 : string = "1px 6px"
    let v66 : US3 = US3_1(v65)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v64, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v66, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure51 (v0 : string) () : (JSX.Element []) =
    let v1 : bool = "" = v0
    let v25 : JSX.Element =
        if v1 then
            let v2 : (Mut4 -> JSX.Element) = closure13()
            let v3 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
            let v4 : US13 = US13_0
            let v5 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure52()
            let v6 : US14 = US14_2
            let v7 : Mut4 = {l0 = v4; l1 = v5; l2 = v6} : Mut4
            let v8 : obj = v7
            let v9 : string = "createComponent"
            let v10 : string = "solid-js"
            let v11 : JS.Function = import v9 v10
            let v12 : JSX.Element = v11.Invoke (v3, v8) |> unbox<JSX.Element>
            v12
        else
            let v13 : string = $"https://github.com/fc1943s/tictactoe_spiral/tree/{v0}"
            let v14 : (Mut4 -> JSX.Element) = closure13()
            let v15 : (obj -> JSX.Element) = v14 |> unbox<obj -> JSX.Element>
            let v16 : US13 = US13_0
            let v17 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure60(v13)
            let v18 : US14 = US14_2
            let v19 : Mut4 = {l0 = v16; l1 = v17; l2 = v18} : Mut4
            let v20 : obj = v19
            let v21 : string = "createComponent"
            let v22 : string = "solid-js"
            let v23 : JS.Function = import v21 v22
            let v24 : JSX.Element = v23.Invoke (v15, v20) |> unbox<JSX.Element>
            v24
    let v26 : (Mut4 -> JSX.Element) = closure13()
    let v27 : (obj -> JSX.Element) = v26 |> unbox<obj -> JSX.Element>
    let v28 : US13 = US13_0
    let v29 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure62()
    let v30 : US14 = US14_2
    let v31 : Mut4 = {l0 = v28; l1 = v29; l2 = v30} : Mut4
    let v32 : obj = v31
    let v33 : string = "createComponent"
    let v34 : string = "solid-js"
    let v35 : JS.Function = import v33 v34
    let v36 : JSX.Element = v35.Invoke (v27, v32) |> unbox<JSX.Element>
    let v37 : (obj -> JSX.Element) = v26 |> unbox<obj -> JSX.Element>
    let v38 : US13 = US13_0
    let v39 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure64()
    let v40 : US14 = US14_2
    let v41 : Mut4 = {l0 = v38; l1 = v39; l2 = v40} : Mut4
    let v42 : obj = v41
    let v43 : JS.Function = import v33 v34
    let v44 : JSX.Element = v43.Invoke (v37, v42) |> unbox<JSX.Element>
    [|v25; v36; v44|]
and method19 () : JSX.Element =
    let v0 : obj = emitJsExpr () "components_spi.env"
    let v1 : string = emitJsExpr v0 "$0.CODESPACE_NAME || \"\""
    let v2 : string = emitJsExpr v0 "$0.GITHUB_RUN_ID || \"\""
    let v3 : string = emitJsExpr v0 "$0.GITHUB_SHA || \"\""
    let v4 : obj = v0?IS_TEST
    let v5 : bool = emitJsExpr v4 "!$0"
    let v6 : bool = v5 = false
    let v7 : (Mut2 -> JSX.Element) = closure9()
    let v8 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    let struct (v9 : US3, v10 : US3, v11 : US5, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US6, v19 : US7, v20 : US3, v21 : US3, v22 : US6, v23 : US8, v24 : US3, v25 : US3, v26 : US3, v27 : US9, v28 : US6, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US10, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US11, v48 : US12, v49 : US11, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US10, v66 : US3, v67 : US3, v68 : US8, v69 : US3, v70 : US2, v71 : US3) = method5()
    let v72 : (unit -> (JSX.Element [])) = closure51(v3)
    let v73 : US7 = US7_1(v72)
    let v74 : Mut2 = {l0 = v9; l1 = v10; l2 = v11; l3 = v12; l4 = v13; l5 = v14; l6 = v15; l7 = v16; l8 = v17; l9 = v18; l10 = v73; l11 = v20; l12 = v21; l13 = v22; l14 = v23; l15 = v24; l16 = v25; l17 = v26; l18 = v27; l19 = v28; l20 = v29; l21 = v30; l22 = v31; l23 = v32; l24 = v33; l25 = v34; l26 = v35; l27 = v36; l28 = v37; l29 = v38; l30 = v39; l31 = v40; l32 = v41; l33 = v42; l34 = v43; l35 = v44; l36 = v45; l37 = v46; l38 = v47; l39 = v48; l40 = v49; l41 = v50; l42 = v51; l43 = v52; l44 = v53; l45 = v54; l46 = v55; l47 = v56; l48 = v57; l49 = v58; l50 = v59; l51 = v60; l52 = v61; l53 = v62; l54 = v63; l55 = v64; l56 = v65; l57 = v66; l58 = v67; l59 = v68; l60 = v69; l61 = v70; l62 = v71} : Mut2
    emitJsExpr (v74, v72) "$0.children = $1"
    let v75 : obj = v74
    let v76 : string = "createComponent"
    let v77 : string = "solid-js"
    let v78 : JS.Function = import v76 v77
    let v79 : JSX.Element = v78.Invoke (v8, v75) |> unbox<JSX.Element>
    v79
and closure50 () (v0 : Mut2) : JSX.Element =
    method19()
and closure66 () () : (JSX.Element []) =
    [||]
and closure49 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure50()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure66()
    let v66 : US7 = US7_1(v65)
    let v67 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v67, v65) "$0.children = $1"
    let v68 : obj = v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v1, v68) |> unbox<JSX.Element>
    [|v72|]
and closure48 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : string = "Links"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : (unit -> (JSX.Element [])) = closure49()
    let v66 : US7 = US7_1(v65)
    let v67 : US10 = US10_1(v64)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v66, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v67, v57, v58, v59, v60, v61, v62)
and closure75 () () : (JSX.Element []) =
    let v0 : string = "Dark"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure76 () () : (JSX.Element []) =
    let v0 : string = "Light"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure74 () () : (JSX.Element []) =
    let v0 : string = "Radio"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) = method5()
    let v66 : string = "dark"
    let v67 : obj = v66
    let v68 : (unit -> (JSX.Element [])) = closure75()
    let v69 : US7 = US7_1(v68)
    let v70 : string = "neutral"
    let v71 : US3 = US3_1(v70)
    let v72 : string = "sm"
    let v73 : US3 = US3_1(v72)
    let v74 : US8 = US8_1(v67)
    let v75 : ((string * obj) []) = method7(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v69, v14, v71, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v73, v55, v56, v57, v58, v59, v60, v61, v74, v63, v64, v65)
    let v76 : obj = createObj v75
    let v77 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v78 : string = "createComponent"
    let v79 : string = "solid-js"
    let v80 : JS.Function = import v78 v79
    let v81 : JSX.Element = v80.Invoke (v77, v76) |> unbox<JSX.Element>
    let v82 : JS.Function = import v0 v1
    let struct (v83 : US3, v84 : US3, v85 : US5, v86 : US3, v87 : US3, v88 : US3, v89 : US3, v90 : US3, v91 : US3, v92 : US6, v93 : US7, v94 : US3, v95 : US3, v96 : US6, v97 : US8, v98 : US3, v99 : US3, v100 : US3, v101 : US9, v102 : US6, v103 : US3, v104 : US3, v105 : US3, v106 : US3, v107 : US3, v108 : US10, v109 : US3, v110 : US3, v111 : US3, v112 : US10, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US11, v122 : US12, v123 : US11, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US3, v135 : US3, v136 : US3, v137 : US3, v138 : US3, v139 : US10, v140 : US3, v141 : US3, v142 : US8, v143 : US3, v144 : US2, v145 : US3) = method5()
    let v146 : string = "light"
    let v147 : obj = v146
    let v148 : (unit -> (JSX.Element [])) = closure76()
    let v149 : US7 = US7_1(v148)
    let v150 : US3 = US3_1(v70)
    let v151 : US3 = US3_1(v72)
    let v152 : US8 = US8_1(v147)
    let v153 : ((string * obj) []) = method7(v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v149, v94, v150, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v151, v135, v136, v137, v138, v139, v140, v141, v152, v143, v144, v145)
    let v154 : obj = createObj v153
    let v155 : (obj -> JSX.Element) = v82 |> unbox<obj -> JSX.Element>
    let v156 : JS.Function = import v78 v79
    let v157 : JSX.Element = v156.Invoke (v155, v154) |> unbox<JSX.Element>
    [|v81; v157|]
and closure73 () () : (JSX.Element []) =
    let v0 : string = "Stack"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) = method5()
    let v66 : (unit -> (JSX.Element [])) = closure74()
    let v67 : US7 = US7_1(v66)
    let v68 : string = "row"
    let v69 : US3 = US3_1(v68)
    let v70 : string = "$4"
    let v71 : US3 = US3_1(v70)
    let v72 : ((string * obj) []) = method7(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v67, v14, v15, v16, v17, v18, v69, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v71, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65)
    let v73 : obj = createObj v72
    let v74 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v75 : string = "createComponent"
    let v76 : string = "solid-js"
    let v77 : JS.Function = import v75 v76
    let v78 : JSX.Element = v77.Invoke (v74, v73) |> unbox<JSX.Element>
    [|v78|]
and closure77 (v0 : (unit -> unit)) (v1 : obj) : unit =
    v0 ()
    ()
and closure72 (v0 : (unit -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : string = "RadioGroup"
    let v3 : string = "@hope-ui/solid"
    let v4 : JS.Function = import v2 v3
    let struct (v5 : US3, v6 : US3, v7 : US5, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US6, v15 : US7, v16 : US3, v17 : US3, v18 : US6, v19 : US8, v20 : US3, v21 : US3, v22 : US3, v23 : US9, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US11, v44 : US12, v45 : US11, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US10, v62 : US3, v63 : US3, v64 : US8, v65 : US3, v66 : US2, v67 : US3) = method5()
    let v68 : string = v1 ()
    let v69 : (unit -> (JSX.Element [])) = closure73()
    let v70 : US7 = US7_1(v69)
    let v71 : US3 = US3_1(v68)
    let v72 : (obj -> unit) = closure77(v0)
    let v73 : US11 = US11_1(v72)
    let v74 : ((string * obj) []) = method7(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v70, v16, v17, v18, v19, v71, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v73, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
    let v75 : obj = createObj v74
    let v76 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v77 : string = "createComponent"
    let v78 : string = "solid-js"
    let v79 : JS.Function = import v77 v78
    let v80 : JSX.Element = v79.Invoke (v76, v75) |> unbox<JSX.Element>
    [|v80|]
and closure71 (v0 : (unit -> unit), v1 : (unit -> string)) struct (v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v65 : string = "Theme"
    let v66 : JSX.Element = Html.fragment [ v65 |> unbox<JSX.Element> ]
    let v67 : (unit -> (JSX.Element [])) = closure72(v0, v1)
    let v68 : US7 = US7_1(v67)
    let v69 : string = "5px 6px"
    let v70 : US3 = US3_1(v69)
    let v71 : US10 = US10_1(v66)
    struct (v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v68, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v70, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v71, v59, v60, v61, v62, v63, v64)
and closure70 (v0 : (unit -> unit), v1 : (unit -> string)) () : (JSX.Element []) =
    let v2 : (Mut4 -> JSX.Element) = closure13()
    let v3 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v4 : US13 = US13_0
    let v5 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure71(v0, v1)
    let v6 : US14 = US14_2
    let v7 : Mut4 = {l0 = v4; l1 = v5; l2 = v6} : Mut4
    let v8 : obj = v7
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : JSX.Element = v11.Invoke (v3, v8) |> unbox<JSX.Element>
    [|v12|]
and method21 () : JSX.Element =
    let v0 : string = "useColorMode"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : obj = v2.Invoke () |> unbox
    let v4 : (unit -> string) = v3?colorMode |> unbox
    let v5 : (unit -> unit) = v3?toggleColorMode |> unbox
    let v6 : (Mut2 -> JSX.Element) = closure9()
    let v7 : (obj -> JSX.Element) = v6 |> unbox<obj -> JSX.Element>
    let struct (v8 : US3, v9 : US3, v10 : US5, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US6, v18 : US7, v19 : US3, v20 : US3, v21 : US6, v22 : US8, v23 : US3, v24 : US3, v25 : US3, v26 : US9, v27 : US6, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US10, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US11, v47 : US12, v48 : US11, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US10, v65 : US3, v66 : US3, v67 : US8, v68 : US3, v69 : US2, v70 : US3) = method5()
    let v71 : (unit -> (JSX.Element [])) = closure70(v5, v4)
    let v72 : US7 = US7_1(v71)
    let v73 : Mut2 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v72; l11 = v19; l12 = v20; l13 = v21; l14 = v22; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v34; l27 = v35; l28 = v36; l29 = v37; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50; l43 = v51; l44 = v52; l45 = v53; l46 = v54; l47 = v55; l48 = v56; l49 = v57; l50 = v58; l51 = v59; l52 = v60; l53 = v61; l54 = v62; l55 = v63; l56 = v64; l57 = v65; l58 = v66; l59 = v67; l60 = v68; l61 = v69; l62 = v70} : Mut2
    emitJsExpr (v73, v71) "$0.children = $1"
    let v74 : obj = v73
    let v75 : string = "createComponent"
    let v76 : string = "solid-js"
    let v77 : JS.Function = import v75 v76
    let v78 : JSX.Element = v77.Invoke (v7, v74) |> unbox<JSX.Element>
    v78
and closure69 () (v0 : Mut2) : JSX.Element =
    method21()
and closure78 () () : (JSX.Element []) =
    [||]
and closure68 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure69()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure78()
    let v66 : US7 = US7_1(v65)
    let v67 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v67, v65) "$0.children = $1"
    let v68 : obj = v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v1, v68) |> unbox<JSX.Element>
    [|v72|]
and closure67 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : string = "Settings"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : (unit -> (JSX.Element [])) = closure68()
    let v66 : US7 = US7_1(v65)
    let v67 : US10 = US10_1(v64)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v66, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v67, v57, v58, v59, v60, v61, v62)
and closure90 () () : (JSX.Element []) =
    [||]
and closure91 (v0 : Mut8, v1 : Mut1, v2 : JS.Function) (v3 : obj) : unit =
    let v4 : string = v3?currentTarget?value
    let v5 : ((string * obj) []) = Array.zeroCreate<(string * obj)> (0)
    let v6 : obj = createObj v5
    let v7 : Mut1 = v6 |> unbox
    let v8 : (Mut1 -> (Mut1 -> (US3 -> unit))) = v0.l1
    let v9 : (Mut1 -> (US3 -> unit)) = v8 v1
    let v10 : (US3 -> unit) = v9 v7
    let v11 : US3 = US3_1(v4)
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
    let struct (v10 : US3, v11 : US3, v12 : US5, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US3, v19 : US6, v20 : US7, v21 : US3, v22 : US3, v23 : US6, v24 : US8, v25 : US3, v26 : US3, v27 : US3, v28 : US9, v29 : US6, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US10, v36 : US3, v37 : US3, v38 : US3, v39 : US10, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US11, v49 : US12, v50 : US11, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US10, v67 : US3, v68 : US3, v69 : US8, v70 : US3, v71 : US2, v72 : US3) = method5()
    let v73 : (Mut1 -> US3) = v0.l0
    let v74 : US3 = v73 v5
    let v75 : string = JS.undefined
    let v77 : string =
        match v74 with
        | US3_0 -> (* None *)
            v75
        | US3_1(v76) -> (* Some *)
            v76
    let v78 : obj = v77
    let v79 : (unit -> (JSX.Element [])) = closure90()
    let v80 : US7 = US7_1(v79)
    let v81 : (obj -> unit) = closure91(v0, v5, v6)
    let v82 : US11 = US11_1(v81)
    let v83 : string = "xs"
    let v84 : US3 = US3_1(v83)
    let v85 : string = "text"
    let v86 : US3 = US3_1(v85)
    let v87 : US8 = US8_1(v78)
    let v88 : ((string * obj) []) = method7(v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v80, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v82, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v84, v62, v63, v64, v65, v66, v67, v86, v87, v70, v71, v72)
    let v89 : obj = createObj v88
    let v90 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    let v91 : string = "createComponent"
    let v92 : string = "solid-js"
    let v93 : JS.Function = import v91 v92
    let v94 : JSX.Element = v93.Invoke (v90, v89) |> unbox<JSX.Element>
    v94
and closure89 () (v0 : Mut8) : JSX.Element =
    method24(v0)
and closure92 () (v0 : Mut1) : US3 =
    let struct (v1 : (struct (US0 * string * string * string) []), v2 : US2, v3 : US3, v4 : US3) = v0.l0, v0.l1, v0.l2, v0.l3
    v3
and closure95 (v0 : Mut1) (v1 : US3) : unit =
    v0.l2 <- v1
    ()
and closure94 () (v0 : Mut1) : (US3 -> unit) =
    closure95(v0)
and closure93 () (v0 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure94()
and closure88 () () : (JSX.Element []) =
    let v0 : (Mut8 -> JSX.Element) = closure89()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : (Mut1 -> US3) = closure92()
    let v3 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure93()
    let v4 : Mut8 = {l0 = v2; l1 = v3} : Mut8
    let v5 : obj = v4
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v1, v5) |> unbox<JSX.Element>
    [|v9|]
and closure87 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : string = "Token"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : (unit -> (JSX.Element [])) = closure88()
    let v66 : US7 = US7_1(v65)
    let v67 : string = "3px"
    let v68 : US3 = US3_1(v67)
    let v69 : US10 = US10_1(v64)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v66, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v68, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v69, v57, v58, v59, v60, v61, v62)
and closure98 () (v0 : Mut1) : US3 =
    let struct (v1 : (struct (US0 * string * string * string) []), v2 : US2, v3 : US3, v4 : US3) = v0.l0, v0.l1, v0.l2, v0.l3
    v4
and closure101 (v0 : Mut1) (v1 : US3) : unit =
    v0.l3 <- v1
    ()
and closure100 () (v0 : Mut1) : (US3 -> unit) =
    closure101(v0)
and closure99 () (v0 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure100()
and closure97 () () : (JSX.Element []) =
    let v0 : (Mut8 -> JSX.Element) = closure89()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : (Mut1 -> US3) = closure98()
    let v3 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure99()
    let v4 : Mut8 = {l0 = v2; l1 = v3} : Mut8
    let v5 : obj = v4
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v1, v5) |> unbox<JSX.Element>
    [|v9|]
and closure96 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : string = "URL"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : (unit -> (JSX.Element [])) = closure97()
    let v66 : US7 = US7_1(v65)
    let v67 : string = "3px"
    let v68 : US3 = US3_1(v67)
    let v69 : US10 = US10_1(v64)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v66, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v68, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v69, v57, v58, v59, v60, v61, v62)
and closure105 (v0 : Mut9, v1 : Mut1, v2 : JS.Function) (v3 : obj) : unit =
    let v4 : int32 = v3?currentTarget?value
    let v5 : ((string * obj) []) = Array.zeroCreate<(string * obj)> (0)
    let v6 : obj = createObj v5
    let v7 : Mut1 = v6 |> unbox
    let v8 : (Mut1 -> (Mut1 -> (US2 -> unit))) = v0.l1
    let v9 : (Mut1 -> (US2 -> unit)) = v8 v1
    let v10 : (US2 -> unit) = v9 v7
    let v11 : US2 = US2_1(v4)
    v10 v11
    let v12 : string = JS.JSON.stringify v7
    let v13 : string = "use_store dispatch"
    let v14 : string = "new_state(new):"
    printfn $"%A{struct (v13, v14, v12)}"
    let v15 : obj = v7
    v2.Invoke ("set", v15) |> ignore
    ()
and method25 (v0 : Mut9) : JSX.Element =
    let v1 : string = "useStoreon"
    let v2 : string = "@storeon/solidjs"
    let v3 : JS.Function = import v1 v2
    let v4 : (JS.Function []) = v3.Invoke () |> unbox<JS.Function[]>
    let v5 : Mut1 = v4.[0] |> unbox
    let v6 : JS.Function = v4.[1] |> unbox
    let v7 : string = "Input"
    let v8 : string = "@hope-ui/solid"
    let v9 : JS.Function = import v7 v8
    let struct (v10 : US3, v11 : US3, v12 : US5, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US3, v19 : US6, v20 : US7, v21 : US3, v22 : US3, v23 : US6, v24 : US8, v25 : US3, v26 : US3, v27 : US3, v28 : US9, v29 : US6, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US10, v36 : US3, v37 : US3, v38 : US3, v39 : US10, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US11, v49 : US12, v50 : US11, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US10, v67 : US3, v68 : US3, v69 : US8, v70 : US3, v71 : US2, v72 : US3) = method5()
    let v73 : (Mut1 -> US2) = v0.l0
    let v74 : US2 = v73 v5
    let v75 : int32 = JS.undefined
    let v77 : int32 =
        match v74 with
        | US2_0 -> (* None *)
            v75
        | US2_1(v76) -> (* Some *)
            v76
    let v78 : obj = v77
    let v79 : (unit -> (JSX.Element [])) = closure90()
    let v80 : US7 = US7_1(v79)
    let v81 : (obj -> unit) = closure105(v0, v5, v6)
    let v82 : US11 = US11_1(v81)
    let v83 : string = "xs"
    let v84 : US3 = US3_1(v83)
    let v85 : string = "text"
    let v86 : US3 = US3_1(v85)
    let v87 : US8 = US8_1(v78)
    let v88 : ((string * obj) []) = method7(v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v80, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v82, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v84, v62, v63, v64, v65, v66, v67, v86, v87, v70, v71, v72)
    let v89 : obj = createObj v88
    let v90 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    let v91 : string = "createComponent"
    let v92 : string = "solid-js"
    let v93 : JS.Function = import v91 v92
    let v94 : JSX.Element = v93.Invoke (v90, v89) |> unbox<JSX.Element>
    v94
and closure104 () (v0 : Mut9) : JSX.Element =
    method25(v0)
and closure106 () (v0 : Mut1) : US2 =
    let struct (v1 : (struct (US0 * string * string * string) []), v2 : US2, v3 : US3, v4 : US3) = v0.l0, v0.l1, v0.l2, v0.l3
    v2
and closure109 (v0 : Mut1) (v1 : US2) : unit =
    v0.l1 <- v1
    ()
and closure108 () (v0 : Mut1) : (US2 -> unit) =
    closure109(v0)
and closure107 () (v0 : Mut1) : (Mut1 -> (US2 -> unit)) =
    closure108()
and closure103 () () : (JSX.Element []) =
    let v0 : (Mut9 -> JSX.Element) = closure104()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : (Mut1 -> US2) = closure106()
    let v3 : (Mut1 -> (Mut1 -> (US2 -> unit))) = closure107()
    let v4 : Mut9 = {l0 = v2; l1 = v3} : Mut9
    let v5 : obj = v4
    let v6 : string = "createComponent"
    let v7 : string = "solid-js"
    let v8 : JS.Function = import v6 v7
    let v9 : JSX.Element = v8.Invoke (v1, v5) |> unbox<JSX.Element>
    [|v9|]
and closure102 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : string = "Port"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : (unit -> (JSX.Element [])) = closure103()
    let v66 : US7 = US7_1(v65)
    let v67 : string = "3px"
    let v68 : US3 = US3_1(v67)
    let v69 : US10 = US10_1(v64)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v66, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v68, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v69, v57, v58, v59, v60, v61, v62)
and closure86 () () : (JSX.Element []) =
    let v0 : (Mut4 -> JSX.Element) = closure13()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : US13 = US13_0
    let v3 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure87()
    let v4 : US14 = US14_2
    let v5 : Mut4 = {l0 = v2; l1 = v3; l2 = v4} : Mut4
    let v6 : obj = v5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v1, v6) |> unbox<JSX.Element>
    let v11 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v12 : US13 = US13_0
    let v13 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure96()
    let v14 : US14 = US14_2
    let v15 : Mut4 = {l0 = v12; l1 = v13; l2 = v14} : Mut4
    let v16 : obj = v15
    let v17 : JS.Function = import v7 v8
    let v18 : JSX.Element = v17.Invoke (v11, v16) |> unbox<JSX.Element>
    let v19 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v20 : US13 = US13_0
    let v21 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure102()
    let v22 : US14 = US14_2
    let v23 : Mut4 = {l0 = v20; l1 = v21; l2 = v22} : Mut4
    let v24 : obj = v23
    let v25 : JS.Function = import v7 v8
    let v26 : JSX.Element = v25.Invoke (v19, v24) |> unbox<JSX.Element>
    [|v10; v18; v26|]
and method23 () : JSX.Element =
    let v0 : (Mut2 -> JSX.Element) = closure9()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure86()
    let v66 : US7 = US7_1(v65)
    let v67 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v67, v65) "$0.children = $1"
    let v68 : obj = v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v1, v68) |> unbox<JSX.Element>
    v72
and closure85 () (v0 : Mut2) : JSX.Element =
    method23()
and closure110 () () : (JSX.Element []) =
    [||]
and closure84 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure85()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure110()
    let v66 : US7 = US7_1(v65)
    let v67 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v67, v65) "$0.children = $1"
    let v68 : obj = v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v1, v68) |> unbox<JSX.Element>
    [|v72|]
and closure83 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : string = "Connection"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : (unit -> (JSX.Element [])) = closure84()
    let v66 : US7 = US7_1(v65)
    let v67 : US10 = US10_1(v64)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v66, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v67, v57, v58, v59, v60, v61, v62)
and closure121 (v0 : US0, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : US3 =
    US3_1(v1)
and closure124 (v0 : US0, v1 : string, v2 : string, v3 : string, v4 : Mut1, v5 : Mut1) (v6 : US3) : unit =
    let struct (v7 : (struct (US0 * string * string * string) []), v8 : US2, v9 : US3, v10 : US3) = v4.l0, v4.l1, v4.l2, v4.l3
    let v11 : int32 = v7.Length
    let v12 : (struct (US0 * string * string * string) []) = Array.zeroCreate<struct (US0 * string * string * string)> (v11)
    let v13 : Mut6 = {l0 = 0} : Mut6
    while method17(v11, v13) do
        let v15 : int32 = v13.l0
        let struct (v16 : US0, v17 : string, v18 : string, v19 : string) = v7.[int v15]
        let v23 : bool =
            match v16, v0 with
            | US0_0, US0_0 -> (* Admin *)
                true
            | US0_1(v20), US0_1(v21) -> (* Player *)
                match v20, v21 with
                | US1_0, US1_0 -> (* O *)
                    true
                | US1_1, US1_1 -> (* X *)
                    true
                | _ ->
                    false
            | _ ->
                false
        let struct (v27 : US0, v28 : string, v29 : string, v30 : string) =
            if v23 then
                let v26 : string =
                    match v6 with
                    | US3_0 -> (* None *)
                        let v24 : string = ""
                        v24
                    | US3_1(v25) -> (* Some *)
                        v25
                struct (v16, v26, v18, v19)
            else
                struct (v16, v17, v18, v19)
        v12.[int v15] <- struct (v27, v28, v29, v30)
        let v31 : int32 = v15 + 1
        v13.l0 <- v31
        ()
    v5.l0 <- v12
    ()
and closure123 (v0 : US0, v1 : string, v2 : string, v3 : string, v4 : Mut1) (v5 : Mut1) : (US3 -> unit) =
    closure124(v0, v1, v2, v3, v4, v5)
and closure122 (v0 : US0, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure123(v0, v1, v2, v3, v4)
and closure120 (v0 : US0, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut8 -> JSX.Element) = closure89()
    let v5 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v6 : (Mut1 -> US3) = closure121(v0, v1, v2, v3)
    let v7 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure122(v0, v1, v2, v3)
    let v8 : Mut8 = {l0 = v6; l1 = v7} : Mut8
    let v9 : obj = v8
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v5, v9) |> unbox<JSX.Element>
    [|v13|]
and closure119 (v0 : US0, v1 : string, v2 : string, v3 : string) struct (v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v67 : string = "Address"
    let v68 : JSX.Element = Html.fragment [ v67 |> unbox<JSX.Element> ]
    let v69 : (unit -> (JSX.Element [])) = closure120(v0, v1, v2, v3)
    let v70 : US7 = US7_1(v69)
    let v71 : string = "3px"
    let v72 : US3 = US3_1(v71)
    let v73 : US10 = US10_1(v68)
    struct (v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v70, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v72, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v73, v61, v62, v63, v64, v65, v66)
and closure127 (v0 : US0, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : US3 =
    US3_1(v3)
and closure130 (v0 : US0, v1 : string, v2 : string, v3 : string, v4 : Mut1, v5 : Mut1) (v6 : US3) : unit =
    let struct (v7 : (struct (US0 * string * string * string) []), v8 : US2, v9 : US3, v10 : US3) = v4.l0, v4.l1, v4.l2, v4.l3
    let v11 : int32 = v7.Length
    let v12 : (struct (US0 * string * string * string) []) = Array.zeroCreate<struct (US0 * string * string * string)> (v11)
    let v13 : Mut6 = {l0 = 0} : Mut6
    while method17(v11, v13) do
        let v15 : int32 = v13.l0
        let struct (v16 : US0, v17 : string, v18 : string, v19 : string) = v7.[int v15]
        let v23 : bool =
            match v16, v0 with
            | US0_0, US0_0 -> (* Admin *)
                true
            | US0_1(v20), US0_1(v21) -> (* Player *)
                match v20, v21 with
                | US1_0, US1_0 -> (* O *)
                    true
                | US1_1, US1_1 -> (* X *)
                    true
                | _ ->
                    false
            | _ ->
                false
        let struct (v27 : US0, v28 : string, v29 : string, v30 : string) =
            if v23 then
                let v26 : string =
                    match v6 with
                    | US3_0 -> (* None *)
                        let v24 : string = ""
                        v24
                    | US3_1(v25) -> (* Some *)
                        v25
                struct (v16, v17, v18, v26)
            else
                struct (v16, v17, v18, v19)
        v12.[int v15] <- struct (v27, v28, v29, v30)
        let v31 : int32 = v15 + 1
        v13.l0 <- v31
        ()
    v5.l0 <- v12
    ()
and closure129 (v0 : US0, v1 : string, v2 : string, v3 : string, v4 : Mut1) (v5 : Mut1) : (US3 -> unit) =
    closure130(v0, v1, v2, v3, v4, v5)
and closure128 (v0 : US0, v1 : string, v2 : string, v3 : string) (v4 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure129(v0, v1, v2, v3, v4)
and closure126 (v0 : US0, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut8 -> JSX.Element) = closure89()
    let v5 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v6 : (Mut1 -> US3) = closure127(v0, v1, v2, v3)
    let v7 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure128(v0, v1, v2, v3)
    let v8 : Mut8 = {l0 = v6; l1 = v7} : Mut8
    let v9 : obj = v8
    let v10 : string = "createComponent"
    let v11 : string = "solid-js"
    let v12 : JS.Function = import v10 v11
    let v13 : JSX.Element = v12.Invoke (v5, v9) |> unbox<JSX.Element>
    [|v13|]
and closure125 (v0 : US0, v1 : string, v2 : string, v3 : string) struct (v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v67 : string = "Private Key"
    let v68 : JSX.Element = Html.fragment [ v67 |> unbox<JSX.Element> ]
    let v69 : (unit -> (JSX.Element [])) = closure126(v0, v1, v2, v3)
    let v70 : US7 = US7_1(v69)
    let v71 : string = "3px"
    let v72 : US3 = US3_1(v71)
    let v73 : US10 = US10_1(v68)
    struct (v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v70, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v72, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v73, v61, v62, v63, v64, v65, v66)
and closure118 (v0 : US0, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut4 -> JSX.Element) = closure13()
    let v5 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v6 : US13 = US13_0
    let v7 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure119(v0, v1, v2, v3)
    let v8 : US14 = US14_2
    let v9 : Mut4 = {l0 = v6; l1 = v7; l2 = v8} : Mut4
    let v10 : obj = v9
    let v11 : string = "createComponent"
    let v12 : string = "solid-js"
    let v13 : JS.Function = import v11 v12
    let v14 : JSX.Element = v13.Invoke (v5, v10) |> unbox<JSX.Element>
    let v15 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v16 : US13 = US13_0
    let v17 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure125(v0, v1, v2, v3)
    let v18 : US14 = US14_2
    let v19 : Mut4 = {l0 = v16; l1 = v17; l2 = v18} : Mut4
    let v20 : obj = v19
    let v21 : JS.Function = import v11 v12
    let v22 : JSX.Element = v21.Invoke (v15, v20) |> unbox<JSX.Element>
    [|v14; v22|]
and closure117 (v0 : US0, v1 : string, v2 : string, v3 : string) () : (JSX.Element []) =
    let v4 : (Mut2 -> JSX.Element) = closure9()
    let v5 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let struct (v6 : US3, v7 : US3, v8 : US5, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US6, v16 : US7, v17 : US3, v18 : US3, v19 : US6, v20 : US8, v21 : US3, v22 : US3, v23 : US3, v24 : US9, v25 : US6, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US10, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US11, v45 : US12, v46 : US11, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US10, v63 : US3, v64 : US3, v65 : US8, v66 : US3, v67 : US2, v68 : US3) = method5()
    let v69 : (unit -> (JSX.Element [])) = closure118(v0, v1, v2, v3)
    let v70 : US7 = US7_1(v69)
    let v71 : Mut2 = {l0 = v6; l1 = v7; l2 = v8; l3 = v9; l4 = v10; l5 = v11; l6 = v12; l7 = v13; l8 = v14; l9 = v15; l10 = v70; l11 = v17; l12 = v18; l13 = v19; l14 = v20; l15 = v21; l16 = v22; l17 = v23; l18 = v24; l19 = v25; l20 = v26; l21 = v27; l22 = v28; l23 = v29; l24 = v30; l25 = v31; l26 = v32; l27 = v33; l28 = v34; l29 = v35; l30 = v36; l31 = v37; l32 = v38; l33 = v39; l34 = v40; l35 = v41; l36 = v42; l37 = v43; l38 = v44; l39 = v45; l40 = v46; l41 = v47; l42 = v48; l43 = v49; l44 = v50; l45 = v51; l46 = v52; l47 = v53; l48 = v54; l49 = v55; l50 = v56; l51 = v57; l52 = v58; l53 = v59; l54 = v60; l55 = v61; l56 = v62; l57 = v63; l58 = v64; l59 = v65; l60 = v66; l61 = v67; l62 = v68} : Mut2
    emitJsExpr (v71, v69) "$0.children = $1"
    let v72 : obj = v71
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v5, v72) |> unbox<JSX.Element>
    [|v76|]
and closure116 (v0 : US0, v1 : string, v2 : string, v3 : string) struct (v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v72 : string =
        match v0 with
        | US0_0 -> (* Admin *)
            let v67 : string = "admin"
            v67
        | US0_1(v68) -> (* Player *)
            match v68 with
            | US1_0 -> (* O *)
                let v69 : string = "o"
                v69
            | US1_1 -> (* X *)
                let v70 : string = "x"
                v70
    let v73 : JSX.Element = Html.fragment [ v72 |> unbox<JSX.Element> ]
    let v74 : (unit -> (JSX.Element [])) = closure117(v0, v1, v2, v3)
    let v75 : US7 = US7_1(v74)
    let v76 : US10 = US10_1(v73)
    struct (v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v75, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v76, v61, v62, v63, v64, v65, v66)
and closure115 () struct (v0 : US0, v1 : string, v2 : string, v3 : string) : (JSX.Element []) =
    let v4 : (Mut4 -> JSX.Element) = closure13()
    let v5 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v6 : US13 = US13_0
    let v7 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure116(v0, v1, v2, v3)
    let v8 : US14 = US14_2
    let v9 : Mut4 = {l0 = v6; l1 = v7; l2 = v8} : Mut4
    let v10 : obj = v9
    let v11 : string = "createComponent"
    let v12 : string = "solid-js"
    let v13 : JS.Function = import v11 v12
    let v14 : JSX.Element = v13.Invoke (v5, v10) |> unbox<JSX.Element>
    [|v14|]
and closure114 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (US0 * string * string * string) []), v2 : US2, v3 : US3, v4 : US3) = v0.l0, v0.l1, v0.l2, v0.l3
    let v5 : string = "For"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : (struct (US0 * string * string * string) -> (JSX.Element [])) = closure115()
    let v9 : (unit -> (JSX.Element [])) = v8 |> unbox
    let struct (v10 : US3, v11 : US3, v12 : US5, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US3, v19 : US6, v20 : US7, v21 : US3, v22 : US3, v23 : US6, v24 : US8, v25 : US3, v26 : US3, v27 : US3, v28 : US9, v29 : US6, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US10, v36 : US3, v37 : US3, v38 : US3, v39 : US10, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US11, v49 : US12, v50 : US11, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US10, v67 : US3, v68 : US3, v69 : US8, v70 : US3, v71 : US2, v72 : US3) = method5()
    let v73 : (obj []) = v1 |> unbox<obj[]>
    let v74 : US7 = US7_1(v9)
    let v75 : US9 = US9_1(v73)
    let v76 : ((string * obj) []) = method7(v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v74, v21, v22, v23, v24, v25, v26, v27, v75, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72)
    let v77 : obj = createObj v76
    let v78 : (obj -> JSX.Element) = v7 |> unbox<obj -> JSX.Element>
    let v79 : string = "createComponent"
    let v80 : JS.Function = import v79 v6
    let v81 : JSX.Element = v80.Invoke (v78, v77) |> unbox<JSX.Element>
    [|v81|]
and method26 () : JSX.Element =
    let v0 : string = "useStoreon"
    let v1 : string = "@storeon/solidjs"
    let v2 : JS.Function = import v0 v1
    let v3 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v4 : Mut1 = v3.[0] |> unbox
    let v5 : JS.Function = v3.[1] |> unbox
    let v6 : (Mut2 -> JSX.Element) = closure9()
    let v7 : (obj -> JSX.Element) = v6 |> unbox<obj -> JSX.Element>
    let struct (v8 : US3, v9 : US3, v10 : US5, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US6, v18 : US7, v19 : US3, v20 : US3, v21 : US6, v22 : US8, v23 : US3, v24 : US3, v25 : US3, v26 : US9, v27 : US6, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US10, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US11, v47 : US12, v48 : US11, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US10, v65 : US3, v66 : US3, v67 : US8, v68 : US3, v69 : US2, v70 : US3) = method5()
    let v71 : (unit -> (JSX.Element [])) = closure114(v4)
    let v72 : US7 = US7_1(v71)
    let v73 : Mut2 = {l0 = v8; l1 = v9; l2 = v10; l3 = v11; l4 = v12; l5 = v13; l6 = v14; l7 = v15; l8 = v16; l9 = v17; l10 = v72; l11 = v19; l12 = v20; l13 = v21; l14 = v22; l15 = v23; l16 = v24; l17 = v25; l18 = v26; l19 = v27; l20 = v28; l21 = v29; l22 = v30; l23 = v31; l24 = v32; l25 = v33; l26 = v34; l27 = v35; l28 = v36; l29 = v37; l30 = v38; l31 = v39; l32 = v40; l33 = v41; l34 = v42; l35 = v43; l36 = v44; l37 = v45; l38 = v46; l39 = v47; l40 = v48; l41 = v49; l42 = v50; l43 = v51; l44 = v52; l45 = v53; l46 = v54; l47 = v55; l48 = v56; l49 = v57; l50 = v58; l51 = v59; l52 = v60; l53 = v61; l54 = v62; l55 = v63; l56 = v64; l57 = v65; l58 = v66; l59 = v67; l60 = v68; l61 = v69; l62 = v70} : Mut2
    emitJsExpr (v73, v71) "$0.children = $1"
    let v74 : obj = v73
    let v75 : string = "createComponent"
    let v76 : string = "solid-js"
    let v77 : JS.Function = import v75 v76
    let v78 : JSX.Element = v77.Invoke (v7, v74) |> unbox<JSX.Element>
    v78
and closure113 () (v0 : Mut2) : JSX.Element =
    method26()
and closure131 () () : (JSX.Element []) =
    [||]
and closure112 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure113()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure131()
    let v66 : US7 = US7_1(v65)
    let v67 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v67, v65) "$0.children = $1"
    let v68 : obj = v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v1, v68) |> unbox<JSX.Element>
    [|v72|]
and closure111 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : string = "Accounts"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : (unit -> (JSX.Element [])) = closure112()
    let v66 : US7 = US7_1(v65)
    let v67 : US10 = US10_1(v64)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v66, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v67, v57, v58, v59, v60, v61, v62)
and closure134 () () : (JSX.Element []) =
    [||]
and closure133 () () : (JSX.Element []) =
    let v0 : string = "hope"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let v3 : JS.Function = v2?iframe
    let struct (v4 : US3, v5 : US3, v6 : US5, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US6, v14 : US7, v15 : US3, v16 : US3, v17 : US6, v18 : US8, v19 : US3, v20 : US3, v21 : US3, v22 : US9, v23 : US6, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US10, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US11, v43 : US12, v44 : US11, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US10, v61 : US3, v62 : US3, v63 : US8, v64 : US3, v65 : US2, v66 : US3) = method5()
    let v67 : string = "algorand testnet bank"
    let v68 : JSX.Element = Html.fragment [ v67 |> unbox<JSX.Element> ]
    let v69 : string = "#aaa"
    let v70 : US3 = US3_1(v69)
    let v71 : (unit -> (JSX.Element [])) = closure134()
    let v72 : US7 = US7_1(v71)
    let v73 : string = "1"
    let v74 : US3 = US3_1(v73)
    let v75 : string = "350px"
    let v76 : US3 = US3_1(v75)
    let v77 : string = "https://bank.testnet.algorand.network"
    let v78 : US3 = US3_1(v77)
    let v79 : US10 = US10_1(v68)
    let v80 : ((string * obj) []) = method7(v4, v5, v6, v70, v8, v9, v10, v11, v12, v13, v72, v15, v16, v17, v18, v19, v20, v21, v22, v23, v74, v25, v26, v76, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v78, v58, v59, v79, v61, v62, v63, v64, v65, v66)
    let v81 : obj = createObj v80
    let v82 : (obj -> JSX.Element) = v3 |> unbox<obj -> JSX.Element>
    let v83 : string = "createComponent"
    let v84 : string = "solid-js"
    let v85 : JS.Function = import v83 v84
    let v86 : JSX.Element = v85.Invoke (v82, v81) |> unbox<JSX.Element>
    [|v86|]
and closure132 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : string = "Testnet Bank Dispenser"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : (unit -> (JSX.Element [])) = closure133()
    let v66 : US7 = US7_1(v65)
    let v67 : US10 = US10_1(v64)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v66, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v67, v57, v58, v59, v60, v61, v62)
and closure82 () () : (JSX.Element []) =
    let v0 : (Mut4 -> JSX.Element) = closure13()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : US13 = US13_0
    let v3 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure83()
    let v4 : US14 = US14_2
    let v5 : Mut4 = {l0 = v2; l1 = v3; l2 = v4} : Mut4
    let v6 : obj = v5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v1, v6) |> unbox<JSX.Element>
    let v11 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v12 : US13 = US13_0
    let v13 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure111()
    let v14 : US14 = US14_2
    let v15 : Mut4 = {l0 = v12; l1 = v13; l2 = v14} : Mut4
    let v16 : obj = v15
    let v17 : JS.Function = import v7 v8
    let v18 : JSX.Element = v17.Invoke (v11, v16) |> unbox<JSX.Element>
    let v19 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v20 : US13 = US13_0
    let v21 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure132()
    let v22 : US14 = US14_0
    let v23 : Mut4 = {l0 = v20; l1 = v21; l2 = v22} : Mut4
    let v24 : obj = v23
    let v25 : JS.Function = import v7 v8
    let v26 : JSX.Element = v25.Invoke (v19, v24) |> unbox<JSX.Element>
    [|v10; v18; v26|]
and method22 () : JSX.Element =
    let v0 : (Mut2 -> JSX.Element) = closure9()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure82()
    let v66 : US7 = US7_1(v65)
    let v67 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v67, v65) "$0.children = $1"
    let v68 : obj = v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v1, v68) |> unbox<JSX.Element>
    v72
and closure81 () (v0 : Mut2) : JSX.Element =
    method22()
and closure135 () () : (JSX.Element []) =
    [||]
and closure80 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure81()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure135()
    let v66 : US7 = US7_1(v65)
    let v67 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v67, v65) "$0.children = $1"
    let v68 : obj = v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v1, v68) |> unbox<JSX.Element>
    [|v72|]
and closure79 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : string = "Chain"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : (unit -> (JSX.Element [])) = closure80()
    let v66 : US7 = US7_1(v65)
    let v67 : string = "db"
    let v68 : US3 = US3_1(v67)
    let v69 : US10 = US10_1(v64)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v66, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v68, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v69, v57, v58, v59, v60, v61, v62)
and closure143 (v0 : Mut1) (v1 : Mut1) : unit =
    let v2 : string = JS.JSON.stringify v0
    let v3 : string = JS.JSON.stringify v1
    let struct (v4 : (struct (US4 * int32 * string * string) []), v5 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let v6 : string = JS.JSON.stringify v5
    let v7 : string = "database row on_load"
    let v8 : string = "old_state:"
    let v9 : string = "state:"
    let v10 : string = "state.db.status:"
    printfn $"%A{struct (v7, v8, v2, v9, v3, v10, v6)}"
    let struct (v11 : (struct (US4 * int32 * string * string) []), v12 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v13 : US4 = US4_1
    let v14 : US4 = US4_1
    let v15 : (struct (US4 * US4) []) = [|struct (v13, v14)|]
    let v16 : int32 = v12.Length
    let v17 : int32 = v15.Length
    let v18 : int32 = v16 + v17
    let v19 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v18)
    let v20 : Mut6 = {l0 = 0} : Mut6
    while method17(v18, v20) do
        let v22 : int32 = v20.l0
        let v23 : bool = v22 < v16
        let struct (v29 : US4, v30 : US4) =
            if v23 then
                let struct (v24 : US4, v25 : US4) = v12.[int v22]
                struct (v24, v25)
            else
                let v26 : int32 = v22 - v16
                let struct (v27 : US4, v28 : US4) = v15.[int v26]
                struct (v27, v28)
        v19.[int v22] <- struct (v29, v30)
        let v31 : int32 = v22 + 1
        v20.l0 <- v31
        ()
    v1.l5 <- v19
    ()
and closure142 () (v0 : Mut1) : (Mut1 -> unit) =
    closure143(v0)
and closure141 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure142()
    v0 v1
    ()
and closure140 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure141()
and method30 (v0 : int32, v1 : Mut12) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure151 (v0 : Mut11) (v1 : Mut1) : US3 =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let v4 : int32 = v2.Length
    let v5 : US3 = US3_0
    let v6 : Mut12 = {l0 = 0; l1 = v5} : Mut12
    while method30(v4, v6) do
        let v8 : int32 = v6.l0
        let v9 : int32 =  -v8
        let v10 : int32 = v9 + v4
        let v11 : int32 = v10 - 1
        let v12 : US3 = v6.l1
        let struct (v13 : US4, v14 : int32, v15 : string, v16 : string) = v2.[int v11]
        let v24 : US3 =
            match v12 with
            | US3_0 -> (* None *)
                let v17 : US4 = v0.l0
                let v18 : bool =
                    match v13, v17 with
                    | US4_0, US4_0 -> (* GunJs *)
                        true
                    | US4_1, US4_1 -> (* GunRs *)
                        true
                    | _ ->
                        false
                if v18 then
                    let v19 : (struct (US4 * int32 * string * string) -> US3) = v0.l1
                    let v20 : US3 = v19 struct (v13, v14, v15, v16)
                    v20
                else
                    US3_0
            | US3_1(v23) -> (* Some *)
                v12
        let v25 : int32 = v8 + 1
        v6.l0 <- v25
        v6.l1 <- v24
        ()
    let v26 : US3 = v6.l1
    v26
and method31 (v0 : int32, v1 : Mut13) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method32 () : struct (US4 * int32 * string * string) =
    let v0 : US4 = US4_1
    let v1 : string = ""
    struct (v0, 0, v1, v1)
and closure154 (v0 : Mut11, v1 : Mut1, v2 : Mut1) (v3 : US3) : unit =
    let struct (v4 : (struct (US4 * int32 * string * string) []), v5 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let struct (v6 : (struct (US4 * int32 * string * string) []), v7 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let v8 : int32 = v6.Length
    let v9 : US15 = US15_0
    let v10 : Mut13 = {l0 = 0; l1 = v9} : Mut13
    while method31(v8, v10) do
        let v12 : int32 = v10.l0
        let v13 : int32 =  -v12
        let v14 : int32 = v13 + v8
        let v15 : int32 = v14 - 1
        let v16 : US15 = v10.l1
        let struct (v17 : US4, v18 : int32, v19 : string, v20 : string) = v6.[int v15]
        let v30 : US15 =
            match v16 with
            | US15_0 -> (* None *)
                let v21 : US4 = v0.l0
                let v22 : bool =
                    match v17, v21 with
                    | US4_0, US4_0 -> (* GunJs *)
                        true
                    | US4_1, US4_1 -> (* GunRs *)
                        true
                    | _ ->
                        false
                if v22 then
                    US15_1(v17, v18, v19, v20)
                else
                    US15_0
            | US15_1(v26, v27, v28, v29) -> (* Some *)
                v16
        let v31 : int32 = v12 + 1
        v10.l0 <- v31
        v10.l1 <- v30
        ()
    let v32 : US15 = v10.l1
    let struct (v33 : US4, v34 : int32, v35 : string, v36 : string) = method32()
    let struct (v41 : US4, v42 : int32, v43 : string, v44 : string) =
        match v32 with
        | US15_0 -> (* None *)
            struct (v33, v34, v35, v36)
        | US15_1(v37, v38, v39, v40) -> (* Some *)
            struct (v37, v38, v39, v40)
    let v45 : (struct (US4 * int32 * string * string) -> (US3 -> struct (US4 * int32 * string * string))) = v0.l2
    let v46 : (US3 -> struct (US4 * int32 * string * string)) = v45 struct (v41, v42, v43, v44)
    let struct (v47 : US4, v48 : int32, v49 : string, v50 : string) = v46 v3
    let v51 : (struct (US4 * int32 * string * string) []) = [|struct (v47, v48, v49, v50)|]
    let v52 : int32 = v4.Length
    let v53 : int32 = v51.Length
    let v54 : int32 = v52 + v53
    let v55 : (struct (US4 * int32 * string * string) []) = Array.zeroCreate<struct (US4 * int32 * string * string)> (v54)
    let v56 : Mut6 = {l0 = 0} : Mut6
    while method17(v54, v56) do
        let v58 : int32 = v56.l0
        let v59 : bool = v58 < v52
        let struct (v69 : US4, v70 : int32, v71 : string, v72 : string) =
            if v59 then
                let struct (v60 : US4, v61 : int32, v62 : string, v63 : string) = v4.[int v58]
                struct (v60, v61, v62, v63)
            else
                let v64 : int32 = v58 - v52
                let struct (v65 : US4, v66 : int32, v67 : string, v68 : string) = v51.[int v64]
                struct (v65, v66, v67, v68)
        v55.[int v58] <- struct (v69, v70, v71, v72)
        let v73 : int32 = v58 + 1
        v56.l0 <- v73
        ()
    v2.l4 <- v55
    ()
and closure153 (v0 : Mut11, v1 : Mut1) (v2 : Mut1) : (US3 -> unit) =
    closure154(v0, v1, v2)
and closure152 (v0 : Mut11) (v1 : Mut1) : (Mut1 -> (US3 -> unit)) =
    closure153(v0, v1)
and method29 (v0 : Mut11) : JSX.Element =
    let v1 : (Mut8 -> JSX.Element) = closure89()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let v3 : (Mut1 -> US3) = closure151(v0)
    let v4 : (Mut1 -> (Mut1 -> (US3 -> unit))) = closure152(v0)
    let v5 : Mut8 = {l0 = v3; l1 = v4} : Mut8
    let v6 : obj = v5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v2, v6) |> unbox<JSX.Element>
    v10
and closure150 () (v0 : Mut11) : JSX.Element =
    method29(v0)
and closure155 () struct (v0 : US4, v1 : int32, v2 : string, v3 : string) : US3 =
    US3_1(v2)
and closure157 (v0 : Mut10, v1 : US4, v2 : int32, v3 : string, v4 : string) (v5 : US3) : struct (US4 * int32 * string * string) =
    let v6 : US4 = v0.l0
    let v9 : string =
        match v5 with
        | US3_0 -> (* None *)
            let v7 : string = ""
            v7
        | US3_1(v8) -> (* Some *)
            v8
    struct (v6, v2, v9, v4)
and closure156 (v0 : Mut10) struct (v1 : US4, v2 : int32, v3 : string, v4 : string) : (US3 -> struct (US4 * int32 * string * string)) =
    closure157(v0, v1, v2, v3, v4)
and closure149 (v0 : Mut10) () : (JSX.Element []) =
    let v1 : US4 = v0.l0
    let v2 : (Mut11 -> JSX.Element) = closure150()
    let v3 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v4 : (struct (US4 * int32 * string * string) -> US3) = closure155()
    let v5 : (struct (US4 * int32 * string * string) -> (US3 -> struct (US4 * int32 * string * string))) = closure156(v0)
    let v6 : Mut11 = {l0 = v1; l1 = v4; l2 = v5} : Mut11
    let v7 : obj = v6
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v3, v7) |> unbox<JSX.Element>
    [|v11|]
and closure148 (v0 : Mut10) struct (v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US10, v58 : US3, v59 : US3, v60 : US8, v61 : US3, v62 : US2, v63 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v64 : string = "URL"
    let v65 : JSX.Element = Html.fragment [ v64 |> unbox<JSX.Element> ]
    let v66 : (unit -> (JSX.Element [])) = closure149(v0)
    let v67 : US7 = US7_1(v66)
    let v68 : string = "3px"
    let v69 : US3 = US3_1(v68)
    let v70 : US10 = US10_1(v65)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v67, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v69, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v70, v58, v59, v60, v61, v62, v63)
and method34 (v0 : int32, v1 : Mut15) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure161 (v0 : Mut14) (v1 : Mut1) : US2 =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let v4 : int32 = v2.Length
    let v5 : US2 = US2_0
    let v6 : Mut15 = {l0 = 0; l1 = v5} : Mut15
    while method34(v4, v6) do
        let v8 : int32 = v6.l0
        let v9 : int32 =  -v8
        let v10 : int32 = v9 + v4
        let v11 : int32 = v10 - 1
        let v12 : US2 = v6.l1
        let struct (v13 : US4, v14 : int32, v15 : string, v16 : string) = v2.[int v11]
        let v24 : US2 =
            match v12 with
            | US2_0 -> (* None *)
                let v17 : US4 = v0.l0
                let v18 : bool =
                    match v13, v17 with
                    | US4_0, US4_0 -> (* GunJs *)
                        true
                    | US4_1, US4_1 -> (* GunRs *)
                        true
                    | _ ->
                        false
                if v18 then
                    let v19 : (struct (US4 * int32 * string * string) -> US2) = v0.l1
                    let v20 : US2 = v19 struct (v13, v14, v15, v16)
                    v20
                else
                    US2_0
            | US2_1(v23) -> (* Some *)
                v12
        let v25 : int32 = v8 + 1
        v6.l0 <- v25
        v6.l1 <- v24
        ()
    let v26 : US2 = v6.l1
    v26
and closure164 (v0 : Mut14, v1 : Mut1, v2 : Mut1) (v3 : US2) : unit =
    let struct (v4 : (struct (US4 * int32 * string * string) []), v5 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let struct (v6 : (struct (US4 * int32 * string * string) []), v7 : (struct (US4 * US4) [])) = v1.l4, v1.l5
    let v8 : int32 = v6.Length
    let v9 : US15 = US15_0
    let v10 : Mut13 = {l0 = 0; l1 = v9} : Mut13
    while method31(v8, v10) do
        let v12 : int32 = v10.l0
        let v13 : int32 =  -v12
        let v14 : int32 = v13 + v8
        let v15 : int32 = v14 - 1
        let v16 : US15 = v10.l1
        let struct (v17 : US4, v18 : int32, v19 : string, v20 : string) = v6.[int v15]
        let v30 : US15 =
            match v16 with
            | US15_0 -> (* None *)
                let v21 : US4 = v0.l0
                let v22 : bool =
                    match v17, v21 with
                    | US4_0, US4_0 -> (* GunJs *)
                        true
                    | US4_1, US4_1 -> (* GunRs *)
                        true
                    | _ ->
                        false
                if v22 then
                    US15_1(v17, v18, v19, v20)
                else
                    US15_0
            | US15_1(v26, v27, v28, v29) -> (* Some *)
                v16
        let v31 : int32 = v12 + 1
        v10.l0 <- v31
        v10.l1 <- v30
        ()
    let v32 : US15 = v10.l1
    let struct (v33 : US4, v34 : int32, v35 : string, v36 : string) = method32()
    let struct (v41 : US4, v42 : int32, v43 : string, v44 : string) =
        match v32 with
        | US15_0 -> (* None *)
            struct (v33, v34, v35, v36)
        | US15_1(v37, v38, v39, v40) -> (* Some *)
            struct (v37, v38, v39, v40)
    let v45 : (struct (US4 * int32 * string * string) -> (US2 -> struct (US4 * int32 * string * string))) = v0.l2
    let v46 : (US2 -> struct (US4 * int32 * string * string)) = v45 struct (v41, v42, v43, v44)
    let struct (v47 : US4, v48 : int32, v49 : string, v50 : string) = v46 v3
    let v51 : (struct (US4 * int32 * string * string) []) = [|struct (v47, v48, v49, v50)|]
    let v52 : int32 = v4.Length
    let v53 : int32 = v51.Length
    let v54 : int32 = v52 + v53
    let v55 : (struct (US4 * int32 * string * string) []) = Array.zeroCreate<struct (US4 * int32 * string * string)> (v54)
    let v56 : Mut6 = {l0 = 0} : Mut6
    while method17(v54, v56) do
        let v58 : int32 = v56.l0
        let v59 : bool = v58 < v52
        let struct (v69 : US4, v70 : int32, v71 : string, v72 : string) =
            if v59 then
                let struct (v60 : US4, v61 : int32, v62 : string, v63 : string) = v4.[int v58]
                struct (v60, v61, v62, v63)
            else
                let v64 : int32 = v58 - v52
                let struct (v65 : US4, v66 : int32, v67 : string, v68 : string) = v51.[int v64]
                struct (v65, v66, v67, v68)
        v55.[int v58] <- struct (v69, v70, v71, v72)
        let v73 : int32 = v58 + 1
        v56.l0 <- v73
        ()
    v2.l4 <- v55
    ()
and closure163 (v0 : Mut14, v1 : Mut1) (v2 : Mut1) : (US2 -> unit) =
    closure164(v0, v1, v2)
and closure162 (v0 : Mut14) (v1 : Mut1) : (Mut1 -> (US2 -> unit)) =
    closure163(v0, v1)
and method33 (v0 : Mut14) : JSX.Element =
    let v1 : (Mut9 -> JSX.Element) = closure104()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let v3 : (Mut1 -> US2) = closure161(v0)
    let v4 : (Mut1 -> (Mut1 -> (US2 -> unit))) = closure162(v0)
    let v5 : Mut9 = {l0 = v3; l1 = v4} : Mut9
    let v6 : obj = v5
    let v7 : string = "createComponent"
    let v8 : string = "solid-js"
    let v9 : JS.Function = import v7 v8
    let v10 : JSX.Element = v9.Invoke (v2, v6) |> unbox<JSX.Element>
    v10
and closure160 () (v0 : Mut14) : JSX.Element =
    method33(v0)
and closure165 () struct (v0 : US4, v1 : int32, v2 : string, v3 : string) : US2 =
    US2_1(v1)
and closure167 (v0 : Mut10, v1 : US4, v2 : int32, v3 : string, v4 : string) (v5 : US2) : struct (US4 * int32 * string * string) =
    let v6 : US4 = v0.l0
    let v8 : int32 =
        match v5 with
        | US2_0 -> (* None *)
            0
        | US2_1(v7) -> (* Some *)
            v7
    struct (v6, v8, v3, v4)
and closure166 (v0 : Mut10) struct (v1 : US4, v2 : int32, v3 : string, v4 : string) : (US2 -> struct (US4 * int32 * string * string)) =
    closure167(v0, v1, v2, v3, v4)
and closure159 (v0 : Mut10) () : (JSX.Element []) =
    let v1 : US4 = v0.l0
    let v2 : (Mut14 -> JSX.Element) = closure160()
    let v3 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v4 : (struct (US4 * int32 * string * string) -> US2) = closure165()
    let v5 : (struct (US4 * int32 * string * string) -> (US2 -> struct (US4 * int32 * string * string))) = closure166(v0)
    let v6 : Mut14 = {l0 = v1; l1 = v4; l2 = v5} : Mut14
    let v7 : obj = v6
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v3, v7) |> unbox<JSX.Element>
    [|v11|]
and closure158 (v0 : Mut10) struct (v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US10, v58 : US3, v59 : US3, v60 : US8, v61 : US3, v62 : US2, v63 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v64 : string = "Port"
    let v65 : JSX.Element = Html.fragment [ v64 |> unbox<JSX.Element> ]
    let v66 : (unit -> (JSX.Element [])) = closure159(v0)
    let v67 : US7 = US7_1(v66)
    let v68 : string = "3px"
    let v69 : US3 = US3_1(v68)
    let v70 : US10 = US10_1(v65)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v67, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v69, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v70, v58, v59, v60, v61, v62, v63)
and closure147 (v0 : Mut10) () : (JSX.Element []) =
    let v1 : (Mut4 -> JSX.Element) = closure13()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let v3 : US13 = US13_0
    let v4 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure148(v0)
    let v5 : US14 = US14_2
    let v6 : Mut4 = {l0 = v3; l1 = v4; l2 = v5} : Mut4
    let v7 : obj = v6
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v2, v7) |> unbox<JSX.Element>
    let v12 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let v13 : US13 = US13_0
    let v14 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure158(v0)
    let v15 : US14 = US14_2
    let v16 : Mut4 = {l0 = v13; l1 = v14; l2 = v15} : Mut4
    let v17 : obj = v16
    let v18 : JS.Function = import v8 v9
    let v19 : JSX.Element = v18.Invoke (v12, v17) |> unbox<JSX.Element>
    [|v11; v19|]
and method28 (v0 : Mut10) : JSX.Element =
    let v1 : (Mut2 -> JSX.Element) = closure9()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let struct (v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) = method5()
    let v66 : (unit -> (JSX.Element [])) = closure147(v0)
    let v67 : US7 = US7_1(v66)
    let v68 : Mut2 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v67; l11 = v14; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v47; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v59; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64; l62 = v65} : Mut2
    emitJsExpr (v68, v66) "$0.children = $1"
    let v69 : obj = v68
    let v70 : string = "createComponent"
    let v71 : string = "solid-js"
    let v72 : JS.Function = import v70 v71
    let v73 : JSX.Element = v72.Invoke (v2, v69) |> unbox<JSX.Element>
    v73
and closure146 () (v0 : Mut10) : JSX.Element =
    method28(v0)
and closure145 () () : (JSX.Element []) =
    let v0 : (Mut10 -> JSX.Element) = closure146()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : US4 = US4_1
    let v3 : Mut10 = {l0 = v2} : Mut10
    let v4 : obj = v3
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v1, v4) |> unbox<JSX.Element>
    [|v8|]
and closure144 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : string = "Rust -{'>'} Rust"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : (unit -> (JSX.Element [])) = closure145()
    let v66 : US7 = US7_1(v65)
    let v67 : string = "db-gun-rs-rs"
    let v68 : US3 = US3_1(v67)
    let v69 : US10 = US10_1(v64)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v66, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v68, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v69, v57, v58, v59, v60, v61, v62)
and closure171 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : US4 = US4_1
    let v5 : US4 = US4_0
    let v6 : (struct (US4 * US4) []) = [|struct (v4, v5)|]
    let v7 : int32 = v3.Length
    let v8 : int32 = v6.Length
    let v9 : int32 = v7 + v8
    let v10 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v9)
    let v11 : Mut6 = {l0 = 0} : Mut6
    while method17(v9, v11) do
        let v13 : int32 = v11.l0
        let v14 : bool = v13 < v7
        let struct (v20 : US4, v21 : US4) =
            if v14 then
                let struct (v15 : US4, v16 : US4) = v3.[int v13]
                struct (v15, v16)
            else
                let v17 : int32 = v13 - v7
                let struct (v18 : US4, v19 : US4) = v6.[int v17]
                struct (v18, v19)
        v10.[int v13] <- struct (v20, v21)
        let v22 : int32 = v13 + 1
        v11.l0 <- v22
        ()
    v1.l5 <- v10
    ()
and closure170 () (v0 : Mut1) : (Mut1 -> unit) =
    closure171(v0)
and closure169 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure170()
    v0 v1
    ()
and closure168 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure169()
and closure173 () () : (JSX.Element []) =
    let v0 : (Mut10 -> JSX.Element) = closure146()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : US4 = US4_0
    let v3 : Mut10 = {l0 = v2} : Mut10
    let v4 : obj = v3
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v1, v4) |> unbox<JSX.Element>
    [|v8|]
and closure172 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : string = "Rust -{'>'} JavaScript"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : (unit -> (JSX.Element [])) = closure173()
    let v66 : US7 = US7_1(v65)
    let v67 : string = "db-gun-rs-js"
    let v68 : US3 = US3_1(v67)
    let v69 : US10 = US10_1(v64)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v66, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v68, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v69, v57, v58, v59, v60, v61, v62)
and closure177 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : US4 = US4_0
    let v5 : US4 = US4_0
    let v6 : (struct (US4 * US4) []) = [|struct (v4, v5)|]
    let v7 : int32 = v3.Length
    let v8 : int32 = v6.Length
    let v9 : int32 = v7 + v8
    let v10 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v9)
    let v11 : Mut6 = {l0 = 0} : Mut6
    while method17(v9, v11) do
        let v13 : int32 = v11.l0
        let v14 : bool = v13 < v7
        let struct (v20 : US4, v21 : US4) =
            if v14 then
                let struct (v15 : US4, v16 : US4) = v3.[int v13]
                struct (v15, v16)
            else
                let v17 : int32 = v13 - v7
                let struct (v18 : US4, v19 : US4) = v6.[int v17]
                struct (v18, v19)
        v10.[int v13] <- struct (v20, v21)
        let v22 : int32 = v13 + 1
        v11.l0 <- v22
        ()
    v1.l5 <- v10
    ()
and closure176 () (v0 : Mut1) : (Mut1 -> unit) =
    closure177(v0)
and closure175 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure176()
    v0 v1
    ()
and closure174 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure175()
and closure179 () () : (JSX.Element []) =
    let v0 : (Mut10 -> JSX.Element) = closure146()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : US4 = US4_0
    let v3 : Mut10 = {l0 = v2} : Mut10
    let v4 : obj = v3
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v1, v4) |> unbox<JSX.Element>
    [|v8|]
and closure178 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : string = "JavaScript -{'>'} JavaScript"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : (unit -> (JSX.Element [])) = closure179()
    let v66 : US7 = US7_1(v65)
    let v67 : string = "db-gun-js-js"
    let v68 : US3 = US3_1(v67)
    let v69 : US10 = US10_1(v64)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v66, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v68, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v69, v57, v58, v59, v60, v61, v62)
and closure183 (v0 : Mut1) (v1 : Mut1) : unit =
    let struct (v2 : (struct (US4 * int32 * string * string) []), v3 : (struct (US4 * US4) [])) = v0.l4, v0.l5
    let v4 : US4 = US4_0
    let v5 : US4 = US4_1
    let v6 : (struct (US4 * US4) []) = [|struct (v4, v5)|]
    let v7 : int32 = v3.Length
    let v8 : int32 = v6.Length
    let v9 : int32 = v7 + v8
    let v10 : (struct (US4 * US4) []) = Array.zeroCreate<struct (US4 * US4)> (v9)
    let v11 : Mut6 = {l0 = 0} : Mut6
    while method17(v9, v11) do
        let v13 : int32 = v11.l0
        let v14 : bool = v13 < v7
        let struct (v20 : US4, v21 : US4) =
            if v14 then
                let struct (v15 : US4, v16 : US4) = v3.[int v13]
                struct (v15, v16)
            else
                let v17 : int32 = v13 - v7
                let struct (v18 : US4, v19 : US4) = v6.[int v17]
                struct (v18, v19)
        v10.[int v13] <- struct (v20, v21)
        let v22 : int32 = v13 + 1
        v11.l0 <- v22
        ()
    v1.l5 <- v10
    ()
and closure182 () (v0 : Mut1) : (Mut1 -> unit) =
    closure183(v0)
and closure181 () (v0 : ((Mut1 -> (Mut1 -> unit)) -> unit)) : unit =
    let v1 : (Mut1 -> (Mut1 -> unit)) = closure182()
    v0 v1
    ()
and closure180 () (v0 : Mut1) : (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit) =
    closure181()
and closure185 () () : (JSX.Element []) =
    let v0 : (Mut10 -> JSX.Element) = closure146()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : US4 = US4_1
    let v3 : Mut10 = {l0 = v2} : Mut10
    let v4 : obj = v3
    let v5 : string = "createComponent"
    let v6 : string = "solid-js"
    let v7 : JS.Function = import v5 v6
    let v8 : JSX.Element = v7.Invoke (v1, v4) |> unbox<JSX.Element>
    [|v8|]
and closure184 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : string = "JavaScript -{'>'} Rust"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : (unit -> (JSX.Element [])) = closure185()
    let v66 : US7 = US7_1(v65)
    let v67 : string = "db-gun-js-rs"
    let v68 : US3 = US3_1(v67)
    let v69 : US10 = US10_1(v64)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v66, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v68, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v69, v57, v58, v59, v60, v61, v62)
and closure139 () () : (JSX.Element []) =
    let v0 : (Mut4 -> JSX.Element) = closure13()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v2 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure140()
    let v3 : US13 = US13_1(v2)
    let v4 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure144()
    let v5 : US14 = US14_0
    let v6 : Mut4 = {l0 = v3; l1 = v4; l2 = v5} : Mut4
    let v7 : obj = v6
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v1, v7) |> unbox<JSX.Element>
    let v12 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v13 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure168()
    let v14 : US13 = US13_1(v13)
    let v15 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure172()
    let v16 : US14 = US14_0
    let v17 : Mut4 = {l0 = v14; l1 = v15; l2 = v16} : Mut4
    let v18 : obj = v17
    let v19 : JS.Function = import v8 v9
    let v20 : JSX.Element = v19.Invoke (v12, v18) |> unbox<JSX.Element>
    let v21 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v22 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure174()
    let v23 : US13 = US13_1(v22)
    let v24 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure178()
    let v25 : US14 = US14_0
    let v26 : Mut4 = {l0 = v23; l1 = v24; l2 = v25} : Mut4
    let v27 : obj = v26
    let v28 : JS.Function = import v8 v9
    let v29 : JSX.Element = v28.Invoke (v21, v27) |> unbox<JSX.Element>
    let v30 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let v31 : (Mut1 -> (((Mut1 -> (Mut1 -> unit)) -> unit) -> unit)) = closure180()
    let v32 : US13 = US13_1(v31)
    let v33 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure184()
    let v34 : US14 = US14_0
    let v35 : Mut4 = {l0 = v32; l1 = v33; l2 = v34} : Mut4
    let v36 : obj = v35
    let v37 : JS.Function = import v8 v9
    let v38 : JSX.Element = v37.Invoke (v30, v36) |> unbox<JSX.Element>
    [|v11; v20; v29; v38|]
and method27 () : JSX.Element =
    let v0 : (Mut2 -> JSX.Element) = closure9()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure139()
    let v66 : US7 = US7_1(v65)
    let v67 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v67, v65) "$0.children = $1"
    let v68 : obj = v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v1, v68) |> unbox<JSX.Element>
    v72
and closure138 () (v0 : Mut2) : JSX.Element =
    method27()
and closure186 () () : (JSX.Element []) =
    [||]
and closure137 () () : (JSX.Element []) =
    let v0 : (Mut2 -> JSX.Element) = closure138()
    let v1 : (obj -> JSX.Element) = v0 |> unbox<obj -> JSX.Element>
    let struct (v2 : US3, v3 : US3, v4 : US5, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US6, v12 : US7, v13 : US3, v14 : US3, v15 : US6, v16 : US8, v17 : US3, v18 : US3, v19 : US3, v20 : US9, v21 : US6, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US10, v28 : US3, v29 : US3, v30 : US3, v31 : US10, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US11, v41 : US12, v42 : US11, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US10, v59 : US3, v60 : US3, v61 : US8, v62 : US3, v63 : US2, v64 : US3) = method5()
    let v65 : (unit -> (JSX.Element [])) = closure186()
    let v66 : US7 = US7_1(v65)
    let v67 : Mut2 = {l0 = v2; l1 = v3; l2 = v4; l3 = v5; l4 = v6; l5 = v7; l6 = v8; l7 = v9; l8 = v10; l9 = v11; l10 = v66; l11 = v13; l12 = v14; l13 = v15; l14 = v16; l15 = v17; l16 = v18; l17 = v19; l18 = v20; l19 = v21; l20 = v22; l21 = v23; l22 = v24; l23 = v25; l24 = v26; l25 = v27; l26 = v28; l27 = v29; l28 = v30; l29 = v31; l30 = v32; l31 = v33; l32 = v34; l33 = v35; l34 = v36; l35 = v37; l36 = v38; l37 = v39; l38 = v40; l39 = v41; l40 = v42; l41 = v43; l42 = v44; l43 = v45; l44 = v46; l45 = v47; l46 = v48; l47 = v49; l48 = v50; l49 = v51; l50 = v52; l51 = v53; l52 = v54; l53 = v55; l54 = v56; l55 = v57; l56 = v58; l57 = v59; l58 = v60; l59 = v61; l60 = v62; l61 = v63; l62 = v64} : Mut2
    emitJsExpr (v67, v65) "$0.children = $1"
    let v68 : obj = v67
    let v69 : string = "createComponent"
    let v70 : string = "solid-js"
    let v71 : JS.Function = import v69 v70
    let v72 : JSX.Element = v71.Invoke (v1, v68) |> unbox<JSX.Element>
    [|v72|]
and closure136 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : string = "Database"
    let v64 : JSX.Element = Html.fragment [ v63 |> unbox<JSX.Element> ]
    let v65 : (unit -> (JSX.Element [])) = closure137()
    let v66 : US7 = US7_1(v65)
    let v67 : string = "db"
    let v68 : US3 = US3_1(v67)
    let v69 : US10 = US10_1(v64)
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v66, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v68, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v69, v57, v58, v59, v60, v61, v62)
and closure193 () () : (JSX.Element []) =
    let v0 : string = "Counter"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure194 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v63, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure195 () () : JS.Function =
    let v0 : string = "BiRegularPlus"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure196 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure197 () () : unit =
    let v0 : string = "use_fetch request."
    let v1 : string = "content_address:"
    let v2 : string = "profile/tmp/counter"
    printfn $"%A{struct (v0, v1, v2)}"
    ()
and closure198 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v63, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure199 () () : JS.Function =
    let v0 : string = "BiRegularMinus"
    let v1 : string = "solid-icons/bi"
    let v2 : JS.Function = import v0 v1
    v2
and closure200 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure201 () () : unit =
    let v0 : string = "use_fetch clear."
    let v1 : string = "content_address:"
    let v2 : string = "profile/tmp/counter"
    printfn $"%A{struct (v0, v1, v2)}"
    ()
and closure192 () () : (JSX.Element []) =
    let v0 : string = "Box"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) = method5()
    let v66 : (unit -> (JSX.Element [])) = closure193()
    let v67 : US7 = US7_1(v66)
    let v68 : ((string * obj) []) = method7(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v67, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65)
    let v69 : obj = createObj v68
    let v70 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v70, v69) |> unbox<JSX.Element>
    let v75 : (Mut2 -> JSX.Element) = closure27()
    let v76 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    let struct (v77 : US3, v78 : US3, v79 : US5, v80 : US3, v81 : US3, v82 : US3, v83 : US3, v84 : US3, v85 : US3, v86 : US6, v87 : US7, v88 : US3, v89 : US3, v90 : US6, v91 : US8, v92 : US3, v93 : US3, v94 : US3, v95 : US9, v96 : US6, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US10, v103 : US3, v104 : US3, v105 : US3, v106 : US10, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US11, v116 : US12, v117 : US11, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US10, v134 : US3, v135 : US3, v136 : US8, v137 : US3, v138 : US2, v139 : US3) = method5()
    let v140 : (Mut7 -> JSX.Element) = closure34()
    let v141 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    let v142 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure194()
    let v143 : (unit -> JS.Function) = closure195()
    let v144 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure36()
    let v145 : Mut7 = {l0 = v142; l1 = v143; l2 = v144} : Mut7
    let v146 : obj = v145
    let v147 : JS.Function = import v71 v72
    let v148 : JSX.Element = v147.Invoke (v141, v146) |> unbox<JSX.Element>
    let v149 : (unit -> (JSX.Element [])) = closure196()
    let v150 : US7 = US7_1(v149)
    let v151 : US10 = US10_1(v148)
    let v152 : (unit -> unit) = closure197()
    let v153 : US12 = US12_1(v152)
    let v154 : string = "10px"
    let v155 : US3 = US3_1(v154)
    let v156 : Mut2 = {l0 = v77; l1 = v78; l2 = v79; l3 = v80; l4 = v81; l5 = v82; l6 = v83; l7 = v84; l8 = v85; l9 = v86; l10 = v150; l11 = v88; l12 = v89; l13 = v90; l14 = v91; l15 = v92; l16 = v93; l17 = v94; l18 = v95; l19 = v96; l20 = v97; l21 = v98; l22 = v99; l23 = v100; l24 = v101; l25 = v102; l26 = v103; l27 = v104; l28 = v105; l29 = v151; l30 = v107; l31 = v108; l32 = v109; l33 = v110; l34 = v111; l35 = v112; l36 = v113; l37 = v114; l38 = v115; l39 = v153; l40 = v117; l41 = v118; l42 = v119; l43 = v120; l44 = v121; l45 = v122; l46 = v123; l47 = v155; l48 = v125; l49 = v126; l50 = v127; l51 = v128; l52 = v129; l53 = v130; l54 = v131; l55 = v132; l56 = v133; l57 = v134; l58 = v135; l59 = v136; l60 = v137; l61 = v138; l62 = v139} : Mut2
    emitJsExpr (v156, v149) "$0.children = $1"
    let v157 : obj = v156
    let v158 : JS.Function = import v71 v72
    let v159 : JSX.Element = v158.Invoke (v76, v157) |> unbox<JSX.Element>
    let v160 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    let struct (v161 : US3, v162 : US3, v163 : US5, v164 : US3, v165 : US3, v166 : US3, v167 : US3, v168 : US3, v169 : US3, v170 : US6, v171 : US7, v172 : US3, v173 : US3, v174 : US6, v175 : US8, v176 : US3, v177 : US3, v178 : US3, v179 : US9, v180 : US6, v181 : US3, v182 : US3, v183 : US3, v184 : US3, v185 : US3, v186 : US10, v187 : US3, v188 : US3, v189 : US3, v190 : US10, v191 : US3, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US3, v197 : US3, v198 : US3, v199 : US11, v200 : US12, v201 : US11, v202 : US3, v203 : US3, v204 : US3, v205 : US3, v206 : US3, v207 : US3, v208 : US3, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US3, v214 : US3, v215 : US3, v216 : US3, v217 : US10, v218 : US3, v219 : US3, v220 : US8, v221 : US3, v222 : US2, v223 : US3) = method5()
    let v224 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    let v225 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure198()
    let v226 : (unit -> JS.Function) = closure199()
    let v227 : Mut7 = {l0 = v225; l1 = v226; l2 = v144} : Mut7
    let v228 : obj = v227
    let v229 : JS.Function = import v71 v72
    let v230 : JSX.Element = v229.Invoke (v224, v228) |> unbox<JSX.Element>
    let v231 : (unit -> (JSX.Element [])) = closure200()
    let v232 : US7 = US7_1(v231)
    let v233 : US10 = US10_1(v230)
    let v234 : (unit -> unit) = closure201()
    let v235 : US12 = US12_1(v234)
    let v236 : US3 = US3_1(v154)
    let v237 : Mut2 = {l0 = v161; l1 = v162; l2 = v163; l3 = v164; l4 = v165; l5 = v166; l6 = v167; l7 = v168; l8 = v169; l9 = v170; l10 = v232; l11 = v172; l12 = v173; l13 = v174; l14 = v175; l15 = v176; l16 = v177; l17 = v178; l18 = v179; l19 = v180; l20 = v181; l21 = v182; l22 = v183; l23 = v184; l24 = v185; l25 = v186; l26 = v187; l27 = v188; l28 = v189; l29 = v233; l30 = v191; l31 = v192; l32 = v193; l33 = v194; l34 = v195; l35 = v196; l36 = v197; l37 = v198; l38 = v199; l39 = v235; l40 = v201; l41 = v202; l42 = v203; l43 = v204; l44 = v205; l45 = v206; l46 = v207; l47 = v236; l48 = v209; l49 = v210; l50 = v211; l51 = v212; l52 = v213; l53 = v214; l54 = v215; l55 = v216; l56 = v217; l57 = v218; l58 = v219; l59 = v220; l60 = v221; l61 = v222; l62 = v223} : Mut2
    emitJsExpr (v237, v231) "$0.children = $1"
    let v238 : obj = v237
    let v239 : JS.Function = import v71 v72
    let v240 : JSX.Element = v239.Invoke (v160, v238) |> unbox<JSX.Element>
    [|v74; v159; v240|]
and method36 (v0 : int32, v1 : Mut16) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method37 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH1 = UH1_0(v2, v3, v1)
        method37(v4, v5)
    | UH1_1 -> (* Nil *)
        v1
and method39 (v0 : UH1, v1 : int32) : int32 =
    match v0 with
    | UH1_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method39(v4, v5)
    | UH1_1 -> (* Nil *)
        v1
and method40 (v0 : (struct (int32 * int32) []), v1 : UH1, v2 : int32) : int32 =
    match v1 with
    | UH1_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method40(v0, v5, v6)
    | UH1_1 -> (* Nil *)
        v2
and method38 (v0 : UH1) : (struct (int32 * int32) []) =
    let v1 : int32 = 0
    let v2 : int32 = method39(v0, v1)
    let v3 : (struct (int32 * int32) []) = Array.zeroCreate<struct (int32 * int32)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method40(v3, v0, v4)
    v3
and closure207 (v0 : (unit -> struct (int32 * int32))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : int32) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = Html.fragment [ v3 |> unbox<JSX.Element> ]
    [|v4|]
and closure206 (v0 : (unit -> struct (int32 * int32))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US3, v6 : US3, v7 : US5, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US6, v15 : US7, v16 : US3, v17 : US3, v18 : US6, v19 : US8, v20 : US3, v21 : US3, v22 : US3, v23 : US9, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US11, v44 : US12, v45 : US11, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US10, v62 : US3, v63 : US3, v64 : US8, v65 : US3, v66 : US2, v67 : US3) = method5()
    let v68 : (unit -> (JSX.Element [])) = closure207(v0)
    let v69 : US7 = US7_1(v68)
    let v70 : ((string * obj) []) = method7(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v69, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
    let v71 : obj = createObj v70
    let v72 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v72, v71) |> unbox<JSX.Element>
    [|v76|]
and closure205 (v0 : (unit -> struct (int32 * int32))) struct (v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US10, v58 : US3, v59 : US3, v60 : US8, v61 : US3, v62 : US2, v63 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let struct (v64 : int32, v65 : int32) = v0 ()
    let v66 : string = v64.ToString ()
    let v67 : JSX.Element = Html.fragment [ v66 |> unbox<JSX.Element> ]
    let v68 : (unit -> (JSX.Element [])) = closure206(v0)
    let v69 : US7 = US7_1(v68)
    let v70 : string = "3px"
    let v71 : US3 = US3_1(v70)
    let v72 : US10 = US10_1(v67)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v69, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v71, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v72, v58, v59, v60, v61, v62, v63)
and closure204 () (v0 : (unit -> struct (int32 * int32))) : (JSX.Element []) =
    let v1 : (Mut4 -> JSX.Element) = closure13()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let v3 : US13 = US13_0
    let v4 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure205(v0)
    let v5 : US14 = US14_2
    let v6 : Mut4 = {l0 = v3; l1 = v4; l2 = v5} : Mut4
    let v7 : obj = v6
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v2, v7) |> unbox<JSX.Element>
    [|v11|]
and closure203 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (int32 * obj) []), v2 : (struct (int32 * obj) []), v3 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v4 : int32 = v3.Length
    let v5 : UH1 = UH1_1
    let v6 : Mut16 = {l0 = 0; l1 = v5} : Mut16
    while method36(v4, v6) do
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
    let v19 : UH1 = method37(v17, v18)
    let v20 : (struct (int32 * int32) []) = method38(v19)
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : JS.Function = import v21 v22
    let v24 : ((unit -> struct (int32 * int32)) -> (JSX.Element [])) = closure204()
    let v25 : (unit -> (JSX.Element [])) = v24 |> unbox
    let struct (v26 : US3, v27 : US3, v28 : US5, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US6, v36 : US7, v37 : US3, v38 : US3, v39 : US6, v40 : US8, v41 : US3, v42 : US3, v43 : US3, v44 : US9, v45 : US6, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US10, v52 : US3, v53 : US3, v54 : US3, v55 : US10, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US12, v66 : US11, v67 : US3, v68 : US3, v69 : US3, v70 : US3, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US10, v83 : US3, v84 : US3, v85 : US8, v86 : US3, v87 : US2, v88 : US3) = method5()
    let v89 : (obj []) = v20 |> unbox<obj[]>
    let v90 : US7 = US7_1(v25)
    let v91 : US9 = US9_1(v89)
    let v92 : ((string * obj) []) = method7(v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v90, v37, v38, v39, v40, v41, v42, v43, v91, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88)
    let v93 : obj = createObj v92
    let v94 : (obj -> JSX.Element) = v23 |> unbox<obj -> JSX.Element>
    let v95 : string = "createComponent"
    let v96 : JS.Function = import v95 v22
    let v97 : JSX.Element = v96.Invoke (v94, v93) |> unbox<JSX.Element>
    [|v97|]
and closure202 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : (Mut2 -> JSX.Element) = closure9()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let struct (v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) = method5()
    let v66 : (unit -> (JSX.Element [])) = closure203(v0)
    let v67 : US7 = US7_1(v66)
    let v68 : Mut2 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v67; l11 = v14; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v47; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v59; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64; l62 = v65} : Mut2
    emitJsExpr (v68, v66) "$0.children = $1"
    let v69 : obj = v68
    let v70 : string = "createComponent"
    let v71 : string = "solid-js"
    let v72 : JS.Function = import v70 v71
    let v73 : JSX.Element = v72.Invoke (v2, v69) |> unbox<JSX.Element>
    [|v73|]
and closure191 (v0 : Mut1) struct (v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US10, v58 : US3, v59 : US3, v60 : US8, v61 : US3, v62 : US2, v63 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v64 : string = "Stack"
    let v65 : string = "@hope-ui/solid"
    let v66 : JS.Function = import v64 v65
    let struct (v67 : US3, v68 : US3, v69 : US5, v70 : US3, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US6, v77 : US7, v78 : US3, v79 : US3, v80 : US6, v81 : US8, v82 : US3, v83 : US3, v84 : US3, v85 : US9, v86 : US6, v87 : US3, v88 : US3, v89 : US3, v90 : US3, v91 : US3, v92 : US10, v93 : US3, v94 : US3, v95 : US3, v96 : US10, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US11, v106 : US12, v107 : US11, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US10, v124 : US3, v125 : US3, v126 : US8, v127 : US3, v128 : US2, v129 : US3) = method5()
    let v130 : string = "row"
    let v131 : string = "column"
    let v132 : string = method13(v131, v130)
    let v133 : string = "0"
    let v134 : string = "8px"
    let v135 : string = method13(v134, v133)
    let v136 : string = "start"
    let v137 : US3 = US3_1(v136)
    let v138 : (unit -> (JSX.Element [])) = closure192()
    let v139 : US7 = US7_1(v138)
    let v140 : US3 = US3_1(v132)
    let v141 : US3 = US3_1(v135)
    let v142 : string = "3px"
    let v143 : US3 = US3_1(v142)
    let v144 : string = "7px"
    let v145 : US3 = US3_1(v144)
    let v146 : ((string * obj) []) = method7(v137, v68, v69, v70, v71, v72, v73, v74, v75, v76, v139, v78, v79, v80, v81, v82, v140, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v141, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v143, v112, v113, v114, v115, v116, v117, v118, v145, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129)
    let v147 : obj = createObj v146
    let v148 : (obj -> JSX.Element) = v66 |> unbox<obj -> JSX.Element>
    let v149 : string = "createComponent"
    let v150 : string = "solid-js"
    let v151 : JS.Function = import v149 v150
    let v152 : JSX.Element = v151.Invoke (v148, v147) |> unbox<JSX.Element>
    let v153 : (unit -> (JSX.Element [])) = closure202(v0)
    let v154 : US7 = US7_1(v153)
    let v155 : string = "counter"
    let v156 : US3 = US3_1(v155)
    let v157 : US10 = US10_1(v152)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v154, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v156, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v157, v58, v59, v60, v61, v62, v63)
and method35 () : JSX.Element =
    let v0 : string = "useStoreon"
    let v1 : string = "@storeon/solidjs"
    let v2 : JS.Function = import v0 v1
    let v3 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v4 : Mut1 = v3.[0] |> unbox
    let v5 : JS.Function = v3.[1] |> unbox
    let struct (v6 : (struct (int32 * obj) []), v7 : (struct (int32 * obj) []), v8 : (struct (int32 * int32) [])) = v4.l6, v4.l7, v4.l8
    let v9 : (Mut4 -> JSX.Element) = closure13()
    let v10 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    let v11 : US13 = US13_0
    let v12 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure191(v4)
    let v13 : US14 = US14_2
    let v14 : Mut4 = {l0 = v11; l1 = v12; l2 = v13} : Mut4
    let v15 : obj = v14
    let v16 : string = "createComponent"
    let v17 : string = "solid-js"
    let v18 : JS.Function = import v16 v17
    let v19 : JSX.Element = v18.Invoke (v10, v15) |> unbox<JSX.Element>
    v19
and closure190 () (v0 : Mut2) : JSX.Element =
    method35()
and closure208 () () : (JSX.Element []) =
    [||]
and closure212 () () : (JSX.Element []) =
    let v0 : string = "Chain Status"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure213 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v63, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure214 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure215 () () : unit =
    let v0 : string = "use_fetch request."
    let v1 : string = "content_address:"
    let v2 : string = "profile/tmp/chain_status"
    printfn $"%A{struct (v0, v1, v2)}"
    ()
and closure216 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v63, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure217 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure218 () () : unit =
    let v0 : string = "use_fetch clear."
    let v1 : string = "content_address:"
    let v2 : string = "profile/tmp/chain_status"
    printfn $"%A{struct (v0, v1, v2)}"
    ()
and closure211 () () : (JSX.Element []) =
    let v0 : string = "Box"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) = method5()
    let v66 : (unit -> (JSX.Element [])) = closure212()
    let v67 : US7 = US7_1(v66)
    let v68 : ((string * obj) []) = method7(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v67, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65)
    let v69 : obj = createObj v68
    let v70 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v70, v69) |> unbox<JSX.Element>
    let v75 : (Mut2 -> JSX.Element) = closure27()
    let v76 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    let struct (v77 : US3, v78 : US3, v79 : US5, v80 : US3, v81 : US3, v82 : US3, v83 : US3, v84 : US3, v85 : US3, v86 : US6, v87 : US7, v88 : US3, v89 : US3, v90 : US6, v91 : US8, v92 : US3, v93 : US3, v94 : US3, v95 : US9, v96 : US6, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US10, v103 : US3, v104 : US3, v105 : US3, v106 : US10, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US11, v116 : US12, v117 : US11, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US10, v134 : US3, v135 : US3, v136 : US8, v137 : US3, v138 : US2, v139 : US3) = method5()
    let v140 : (Mut7 -> JSX.Element) = closure34()
    let v141 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    let v142 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure213()
    let v143 : (unit -> JS.Function) = closure195()
    let v144 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure36()
    let v145 : Mut7 = {l0 = v142; l1 = v143; l2 = v144} : Mut7
    let v146 : obj = v145
    let v147 : JS.Function = import v71 v72
    let v148 : JSX.Element = v147.Invoke (v141, v146) |> unbox<JSX.Element>
    let v149 : (unit -> (JSX.Element [])) = closure214()
    let v150 : US7 = US7_1(v149)
    let v151 : US10 = US10_1(v148)
    let v152 : (unit -> unit) = closure215()
    let v153 : US12 = US12_1(v152)
    let v154 : string = "10px"
    let v155 : US3 = US3_1(v154)
    let v156 : Mut2 = {l0 = v77; l1 = v78; l2 = v79; l3 = v80; l4 = v81; l5 = v82; l6 = v83; l7 = v84; l8 = v85; l9 = v86; l10 = v150; l11 = v88; l12 = v89; l13 = v90; l14 = v91; l15 = v92; l16 = v93; l17 = v94; l18 = v95; l19 = v96; l20 = v97; l21 = v98; l22 = v99; l23 = v100; l24 = v101; l25 = v102; l26 = v103; l27 = v104; l28 = v105; l29 = v151; l30 = v107; l31 = v108; l32 = v109; l33 = v110; l34 = v111; l35 = v112; l36 = v113; l37 = v114; l38 = v115; l39 = v153; l40 = v117; l41 = v118; l42 = v119; l43 = v120; l44 = v121; l45 = v122; l46 = v123; l47 = v155; l48 = v125; l49 = v126; l50 = v127; l51 = v128; l52 = v129; l53 = v130; l54 = v131; l55 = v132; l56 = v133; l57 = v134; l58 = v135; l59 = v136; l60 = v137; l61 = v138; l62 = v139} : Mut2
    emitJsExpr (v156, v149) "$0.children = $1"
    let v157 : obj = v156
    let v158 : JS.Function = import v71 v72
    let v159 : JSX.Element = v158.Invoke (v76, v157) |> unbox<JSX.Element>
    let v160 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    let struct (v161 : US3, v162 : US3, v163 : US5, v164 : US3, v165 : US3, v166 : US3, v167 : US3, v168 : US3, v169 : US3, v170 : US6, v171 : US7, v172 : US3, v173 : US3, v174 : US6, v175 : US8, v176 : US3, v177 : US3, v178 : US3, v179 : US9, v180 : US6, v181 : US3, v182 : US3, v183 : US3, v184 : US3, v185 : US3, v186 : US10, v187 : US3, v188 : US3, v189 : US3, v190 : US10, v191 : US3, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US3, v197 : US3, v198 : US3, v199 : US11, v200 : US12, v201 : US11, v202 : US3, v203 : US3, v204 : US3, v205 : US3, v206 : US3, v207 : US3, v208 : US3, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US3, v214 : US3, v215 : US3, v216 : US3, v217 : US10, v218 : US3, v219 : US3, v220 : US8, v221 : US3, v222 : US2, v223 : US3) = method5()
    let v224 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    let v225 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure216()
    let v226 : (unit -> JS.Function) = closure199()
    let v227 : Mut7 = {l0 = v225; l1 = v226; l2 = v144} : Mut7
    let v228 : obj = v227
    let v229 : JS.Function = import v71 v72
    let v230 : JSX.Element = v229.Invoke (v224, v228) |> unbox<JSX.Element>
    let v231 : (unit -> (JSX.Element [])) = closure217()
    let v232 : US7 = US7_1(v231)
    let v233 : US10 = US10_1(v230)
    let v234 : (unit -> unit) = closure218()
    let v235 : US12 = US12_1(v234)
    let v236 : US3 = US3_1(v154)
    let v237 : Mut2 = {l0 = v161; l1 = v162; l2 = v163; l3 = v164; l4 = v165; l5 = v166; l6 = v167; l7 = v168; l8 = v169; l9 = v170; l10 = v232; l11 = v172; l12 = v173; l13 = v174; l14 = v175; l15 = v176; l16 = v177; l17 = v178; l18 = v179; l19 = v180; l20 = v181; l21 = v182; l22 = v183; l23 = v184; l24 = v185; l25 = v186; l26 = v187; l27 = v188; l28 = v189; l29 = v233; l30 = v191; l31 = v192; l32 = v193; l33 = v194; l34 = v195; l35 = v196; l36 = v197; l37 = v198; l38 = v199; l39 = v235; l40 = v201; l41 = v202; l42 = v203; l43 = v204; l44 = v205; l45 = v206; l46 = v207; l47 = v236; l48 = v209; l49 = v210; l50 = v211; l51 = v212; l52 = v213; l53 = v214; l54 = v215; l55 = v216; l56 = v217; l57 = v218; l58 = v219; l59 = v220; l60 = v221; l61 = v222; l62 = v223} : Mut2
    emitJsExpr (v237, v231) "$0.children = $1"
    let v238 : obj = v237
    let v239 : JS.Function = import v71 v72
    let v240 : JSX.Element = v239.Invoke (v160, v238) |> unbox<JSX.Element>
    [|v74; v159; v240|]
and method42 (v0 : int32, v1 : Mut17) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method43 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_0(v2, v3, v4) -> (* Cons *)
        let v5 : UH2 = UH2_0(v2, v3, v1)
        method43(v4, v5)
    | UH2_1 -> (* Nil *)
        v1
and method45 (v0 : UH2, v1 : int32) : int32 =
    match v0 with
    | UH2_0(v2, v3, v4) -> (* Cons *)
        let v5 : int32 = v1 + 1
        method45(v4, v5)
    | UH2_1 -> (* Nil *)
        v1
and method46 (v0 : (struct (int32 * obj) []), v1 : UH2, v2 : int32) : int32 =
    match v1 with
    | UH2_0(v3, v4, v5) -> (* Cons *)
        v0.[int v2] <- struct (v3, v4)
        let v6 : int32 = v2 + 1
        method46(v0, v5, v6)
    | UH2_1 -> (* Nil *)
        v2
and method44 (v0 : UH2) : (struct (int32 * obj) []) =
    let v1 : int32 = 0
    let v2 : int32 = method45(v0, v1)
    let v3 : (struct (int32 * obj) []) = Array.zeroCreate<struct (int32 * obj)> (v2)
    let v4 : int32 = 0
    let v5 : int32 = method46(v3, v0, v4)
    v3
and closure224 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : obj) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = Html.fragment [ v3 |> unbox<JSX.Element> ]
    [|v4|]
and closure223 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US3, v6 : US3, v7 : US5, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US6, v15 : US7, v16 : US3, v17 : US3, v18 : US6, v19 : US8, v20 : US3, v21 : US3, v22 : US3, v23 : US9, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US11, v44 : US12, v45 : US11, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US10, v62 : US3, v63 : US3, v64 : US8, v65 : US3, v66 : US2, v67 : US3) = method5()
    let v68 : (unit -> (JSX.Element [])) = closure224(v0)
    let v69 : US7 = US7_1(v68)
    let v70 : ((string * obj) []) = method7(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v69, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
    let v71 : obj = createObj v70
    let v72 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v72, v71) |> unbox<JSX.Element>
    [|v76|]
and closure222 (v0 : (unit -> struct (int32 * obj))) struct (v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US10, v58 : US3, v59 : US3, v60 : US8, v61 : US3, v62 : US2, v63 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let struct (v64 : int32, v65 : obj) = v0 ()
    let v66 : string = v64.ToString ()
    let v67 : JSX.Element = Html.fragment [ v66 |> unbox<JSX.Element> ]
    let v68 : (unit -> (JSX.Element [])) = closure223(v0)
    let v69 : US7 = US7_1(v68)
    let v70 : string = "3px"
    let v71 : US3 = US3_1(v70)
    let v72 : US10 = US10_1(v67)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v69, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v71, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v72, v58, v59, v60, v61, v62, v63)
and closure221 () (v0 : (unit -> struct (int32 * obj))) : (JSX.Element []) =
    let v1 : (Mut4 -> JSX.Element) = closure13()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let v3 : US13 = US13_0
    let v4 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure222(v0)
    let v5 : US14 = US14_2
    let v6 : Mut4 = {l0 = v3; l1 = v4; l2 = v5} : Mut4
    let v7 : obj = v6
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v2, v7) |> unbox<JSX.Element>
    [|v11|]
and closure220 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (int32 * obj) []), v2 : (struct (int32 * obj) []), v3 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v4 : int32 = v2.Length
    let v5 : UH2 = UH2_1
    let v6 : Mut17 = {l0 = 0; l1 = v5} : Mut17
    while method42(v4, v6) do
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
    let v19 : UH2 = method43(v17, v18)
    let v20 : (struct (int32 * obj) []) = method44(v19)
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : JS.Function = import v21 v22
    let v24 : ((unit -> struct (int32 * obj)) -> (JSX.Element [])) = closure221()
    let v25 : (unit -> (JSX.Element [])) = v24 |> unbox
    let struct (v26 : US3, v27 : US3, v28 : US5, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US6, v36 : US7, v37 : US3, v38 : US3, v39 : US6, v40 : US8, v41 : US3, v42 : US3, v43 : US3, v44 : US9, v45 : US6, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US10, v52 : US3, v53 : US3, v54 : US3, v55 : US10, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US12, v66 : US11, v67 : US3, v68 : US3, v69 : US3, v70 : US3, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US10, v83 : US3, v84 : US3, v85 : US8, v86 : US3, v87 : US2, v88 : US3) = method5()
    let v89 : (obj []) = v20 |> unbox<obj[]>
    let v90 : US7 = US7_1(v25)
    let v91 : US9 = US9_1(v89)
    let v92 : ((string * obj) []) = method7(v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v90, v37, v38, v39, v40, v41, v42, v43, v91, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88)
    let v93 : obj = createObj v92
    let v94 : (obj -> JSX.Element) = v23 |> unbox<obj -> JSX.Element>
    let v95 : string = "createComponent"
    let v96 : JS.Function = import v95 v22
    let v97 : JSX.Element = v96.Invoke (v94, v93) |> unbox<JSX.Element>
    [|v97|]
and closure219 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : (Mut2 -> JSX.Element) = closure9()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let struct (v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) = method5()
    let v66 : (unit -> (JSX.Element [])) = closure220(v0)
    let v67 : US7 = US7_1(v66)
    let v68 : Mut2 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v67; l11 = v14; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v47; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v59; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64; l62 = v65} : Mut2
    emitJsExpr (v68, v66) "$0.children = $1"
    let v69 : obj = v68
    let v70 : string = "createComponent"
    let v71 : string = "solid-js"
    let v72 : JS.Function = import v70 v71
    let v73 : JSX.Element = v72.Invoke (v2, v69) |> unbox<JSX.Element>
    [|v73|]
and closure210 (v0 : Mut1) struct (v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US10, v58 : US3, v59 : US3, v60 : US8, v61 : US3, v62 : US2, v63 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v64 : string = "Stack"
    let v65 : string = "@hope-ui/solid"
    let v66 : JS.Function = import v64 v65
    let struct (v67 : US3, v68 : US3, v69 : US5, v70 : US3, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US6, v77 : US7, v78 : US3, v79 : US3, v80 : US6, v81 : US8, v82 : US3, v83 : US3, v84 : US3, v85 : US9, v86 : US6, v87 : US3, v88 : US3, v89 : US3, v90 : US3, v91 : US3, v92 : US10, v93 : US3, v94 : US3, v95 : US3, v96 : US10, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US11, v106 : US12, v107 : US11, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US10, v124 : US3, v125 : US3, v126 : US8, v127 : US3, v128 : US2, v129 : US3) = method5()
    let v130 : string = "row"
    let v131 : string = "column"
    let v132 : string = method13(v131, v130)
    let v133 : string = "0"
    let v134 : string = "8px"
    let v135 : string = method13(v134, v133)
    let v136 : string = "start"
    let v137 : US3 = US3_1(v136)
    let v138 : (unit -> (JSX.Element [])) = closure211()
    let v139 : US7 = US7_1(v138)
    let v140 : US3 = US3_1(v132)
    let v141 : US3 = US3_1(v135)
    let v142 : string = "3px"
    let v143 : US3 = US3_1(v142)
    let v144 : string = "7px"
    let v145 : US3 = US3_1(v144)
    let v146 : ((string * obj) []) = method7(v137, v68, v69, v70, v71, v72, v73, v74, v75, v76, v139, v78, v79, v80, v81, v82, v140, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v141, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v143, v112, v113, v114, v115, v116, v117, v118, v145, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129)
    let v147 : obj = createObj v146
    let v148 : (obj -> JSX.Element) = v66 |> unbox<obj -> JSX.Element>
    let v149 : string = "createComponent"
    let v150 : string = "solid-js"
    let v151 : JS.Function = import v149 v150
    let v152 : JSX.Element = v151.Invoke (v148, v147) |> unbox<JSX.Element>
    let v153 : (unit -> (JSX.Element [])) = closure219(v0)
    let v154 : US7 = US7_1(v153)
    let v155 : string = "status"
    let v156 : US3 = US3_1(v155)
    let v157 : US10 = US10_1(v152)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v154, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v156, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v157, v58, v59, v60, v61, v62, v63)
and method41 () : JSX.Element =
    let v0 : string = "useStoreon"
    let v1 : string = "@storeon/solidjs"
    let v2 : JS.Function = import v0 v1
    let v3 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v4 : Mut1 = v3.[0] |> unbox
    let v5 : JS.Function = v3.[1] |> unbox
    let struct (v6 : (struct (int32 * obj) []), v7 : (struct (int32 * obj) []), v8 : (struct (int32 * int32) [])) = v4.l6, v4.l7, v4.l8
    let v9 : (Mut4 -> JSX.Element) = closure13()
    let v10 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    let v11 : US13 = US13_0
    let v12 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure210(v4)
    let v13 : US14 = US14_2
    let v14 : Mut4 = {l0 = v11; l1 = v12; l2 = v13} : Mut4
    let v15 : obj = v14
    let v16 : string = "createComponent"
    let v17 : string = "solid-js"
    let v18 : JS.Function = import v16 v17
    let v19 : JSX.Element = v18.Invoke (v10, v15) |> unbox<JSX.Element>
    v19
and closure209 () (v0 : Mut2) : JSX.Element =
    method41()
and closure225 () () : (JSX.Element []) =
    [||]
and closure229 () () : (JSX.Element []) =
    let v0 : string = "Chain Deploy"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure230 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v63, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure231 () () : (JSX.Element []) =
    let v0 : string = "Request"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure232 () () : unit =
    let v0 : string = "use_fetch request."
    let v1 : string = "content_address:"
    let v2 : string = "profile/tmp/chain_deploy"
    printfn $"%A{struct (v0, v1, v2)}"
    ()
and closure233 () struct (v0 : US3, v1 : US3, v2 : US5, v3 : US3, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US6, v10 : US7, v11 : US3, v12 : US3, v13 : US6, v14 : US8, v15 : US3, v16 : US3, v17 : US3, v18 : US9, v19 : US6, v20 : US3, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US10, v26 : US3, v27 : US3, v28 : US3, v29 : US10, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US11, v39 : US12, v40 : US11, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US10, v57 : US3, v58 : US3, v59 : US8, v60 : US3, v61 : US2, v62 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v63 : US3 = US3_0
    struct (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v63, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62)
and closure234 () () : (JSX.Element []) =
    let v0 : string = "Clear"
    let v1 : JSX.Element = Html.fragment [ v0 |> unbox<JSX.Element> ]
    [|v1|]
and closure235 () () : unit =
    let v0 : string = "use_fetch clear."
    let v1 : string = "content_address:"
    let v2 : string = "profile/tmp/chain_deploy"
    printfn $"%A{struct (v0, v1, v2)}"
    ()
and closure228 () () : (JSX.Element []) =
    let v0 : string = "Box"
    let v1 : string = "@hope-ui/solid"
    let v2 : JS.Function = import v0 v1
    let struct (v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) = method5()
    let v66 : (unit -> (JSX.Element [])) = closure229()
    let v67 : US7 = US7_1(v66)
    let v68 : ((string * obj) []) = method7(v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v67, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65)
    let v69 : obj = createObj v68
    let v70 : (obj -> JSX.Element) = v2 |> unbox<obj -> JSX.Element>
    let v71 : string = "createComponent"
    let v72 : string = "solid-js"
    let v73 : JS.Function = import v71 v72
    let v74 : JSX.Element = v73.Invoke (v70, v69) |> unbox<JSX.Element>
    let v75 : (Mut2 -> JSX.Element) = closure27()
    let v76 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    let struct (v77 : US3, v78 : US3, v79 : US5, v80 : US3, v81 : US3, v82 : US3, v83 : US3, v84 : US3, v85 : US3, v86 : US6, v87 : US7, v88 : US3, v89 : US3, v90 : US6, v91 : US8, v92 : US3, v93 : US3, v94 : US3, v95 : US9, v96 : US6, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US10, v103 : US3, v104 : US3, v105 : US3, v106 : US10, v107 : US3, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US11, v116 : US12, v117 : US11, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US10, v134 : US3, v135 : US3, v136 : US8, v137 : US3, v138 : US2, v139 : US3) = method5()
    let v140 : (Mut7 -> JSX.Element) = closure34()
    let v141 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    let v142 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure230()
    let v143 : (unit -> JS.Function) = closure195()
    let v144 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure36()
    let v145 : Mut7 = {l0 = v142; l1 = v143; l2 = v144} : Mut7
    let v146 : obj = v145
    let v147 : JS.Function = import v71 v72
    let v148 : JSX.Element = v147.Invoke (v141, v146) |> unbox<JSX.Element>
    let v149 : (unit -> (JSX.Element [])) = closure231()
    let v150 : US7 = US7_1(v149)
    let v151 : US10 = US10_1(v148)
    let v152 : (unit -> unit) = closure232()
    let v153 : US12 = US12_1(v152)
    let v154 : string = "10px"
    let v155 : US3 = US3_1(v154)
    let v156 : Mut2 = {l0 = v77; l1 = v78; l2 = v79; l3 = v80; l4 = v81; l5 = v82; l6 = v83; l7 = v84; l8 = v85; l9 = v86; l10 = v150; l11 = v88; l12 = v89; l13 = v90; l14 = v91; l15 = v92; l16 = v93; l17 = v94; l18 = v95; l19 = v96; l20 = v97; l21 = v98; l22 = v99; l23 = v100; l24 = v101; l25 = v102; l26 = v103; l27 = v104; l28 = v105; l29 = v151; l30 = v107; l31 = v108; l32 = v109; l33 = v110; l34 = v111; l35 = v112; l36 = v113; l37 = v114; l38 = v115; l39 = v153; l40 = v117; l41 = v118; l42 = v119; l43 = v120; l44 = v121; l45 = v122; l46 = v123; l47 = v155; l48 = v125; l49 = v126; l50 = v127; l51 = v128; l52 = v129; l53 = v130; l54 = v131; l55 = v132; l56 = v133; l57 = v134; l58 = v135; l59 = v136; l60 = v137; l61 = v138; l62 = v139} : Mut2
    emitJsExpr (v156, v149) "$0.children = $1"
    let v157 : obj = v156
    let v158 : JS.Function = import v71 v72
    let v159 : JSX.Element = v158.Invoke (v76, v157) |> unbox<JSX.Element>
    let v160 : (obj -> JSX.Element) = v75 |> unbox<obj -> JSX.Element>
    let struct (v161 : US3, v162 : US3, v163 : US5, v164 : US3, v165 : US3, v166 : US3, v167 : US3, v168 : US3, v169 : US3, v170 : US6, v171 : US7, v172 : US3, v173 : US3, v174 : US6, v175 : US8, v176 : US3, v177 : US3, v178 : US3, v179 : US9, v180 : US6, v181 : US3, v182 : US3, v183 : US3, v184 : US3, v185 : US3, v186 : US10, v187 : US3, v188 : US3, v189 : US3, v190 : US10, v191 : US3, v192 : US3, v193 : US3, v194 : US3, v195 : US3, v196 : US3, v197 : US3, v198 : US3, v199 : US11, v200 : US12, v201 : US11, v202 : US3, v203 : US3, v204 : US3, v205 : US3, v206 : US3, v207 : US3, v208 : US3, v209 : US3, v210 : US3, v211 : US3, v212 : US3, v213 : US3, v214 : US3, v215 : US3, v216 : US3, v217 : US10, v218 : US3, v219 : US3, v220 : US8, v221 : US3, v222 : US2, v223 : US3) = method5()
    let v224 : (obj -> JSX.Element) = v140 |> unbox<obj -> JSX.Element>
    let v225 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure233()
    let v226 : (unit -> JS.Function) = closure199()
    let v227 : Mut7 = {l0 = v225; l1 = v226; l2 = v144} : Mut7
    let v228 : obj = v227
    let v229 : JS.Function = import v71 v72
    let v230 : JSX.Element = v229.Invoke (v224, v228) |> unbox<JSX.Element>
    let v231 : (unit -> (JSX.Element [])) = closure234()
    let v232 : US7 = US7_1(v231)
    let v233 : US10 = US10_1(v230)
    let v234 : (unit -> unit) = closure235()
    let v235 : US12 = US12_1(v234)
    let v236 : US3 = US3_1(v154)
    let v237 : Mut2 = {l0 = v161; l1 = v162; l2 = v163; l3 = v164; l4 = v165; l5 = v166; l6 = v167; l7 = v168; l8 = v169; l9 = v170; l10 = v232; l11 = v172; l12 = v173; l13 = v174; l14 = v175; l15 = v176; l16 = v177; l17 = v178; l18 = v179; l19 = v180; l20 = v181; l21 = v182; l22 = v183; l23 = v184; l24 = v185; l25 = v186; l26 = v187; l27 = v188; l28 = v189; l29 = v233; l30 = v191; l31 = v192; l32 = v193; l33 = v194; l34 = v195; l35 = v196; l36 = v197; l37 = v198; l38 = v199; l39 = v235; l40 = v201; l41 = v202; l42 = v203; l43 = v204; l44 = v205; l45 = v206; l46 = v207; l47 = v236; l48 = v209; l49 = v210; l50 = v211; l51 = v212; l52 = v213; l53 = v214; l54 = v215; l55 = v216; l56 = v217; l57 = v218; l58 = v219; l59 = v220; l60 = v221; l61 = v222; l62 = v223} : Mut2
    emitJsExpr (v237, v231) "$0.children = $1"
    let v238 : obj = v237
    let v239 : JS.Function = import v71 v72
    let v240 : JSX.Element = v239.Invoke (v160, v238) |> unbox<JSX.Element>
    [|v74; v159; v240|]
and closure241 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let struct (v1 : int32, v2 : obj) = v0 ()
    let v3 : string = emitJsExpr v2 "JSON.stringify($0, null, 2)"
    let v4 : JSX.Element = Html.fragment [ v3 |> unbox<JSX.Element> ]
    [|v4|]
and closure240 (v0 : (unit -> struct (int32 * obj))) () : (JSX.Element []) =
    let v1 : string = "hope"
    let v2 : string = "@hope-ui/solid"
    let v3 : JS.Function = import v1 v2
    let v4 : JS.Function = v3?pre
    let struct (v5 : US3, v6 : US3, v7 : US5, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US6, v15 : US7, v16 : US3, v17 : US3, v18 : US6, v19 : US8, v20 : US3, v21 : US3, v22 : US3, v23 : US9, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US11, v44 : US12, v45 : US11, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US10, v62 : US3, v63 : US3, v64 : US8, v65 : US3, v66 : US2, v67 : US3) = method5()
    let v68 : (unit -> (JSX.Element [])) = closure241(v0)
    let v69 : US7 = US7_1(v68)
    let v70 : ((string * obj) []) = method7(v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v69, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67)
    let v71 : obj = createObj v70
    let v72 : (obj -> JSX.Element) = v4 |> unbox<obj -> JSX.Element>
    let v73 : string = "createComponent"
    let v74 : string = "solid-js"
    let v75 : JS.Function = import v73 v74
    let v76 : JSX.Element = v75.Invoke (v72, v71) |> unbox<JSX.Element>
    [|v76|]
and closure239 (v0 : (unit -> struct (int32 * obj))) struct (v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US10, v58 : US3, v59 : US3, v60 : US8, v61 : US3, v62 : US2, v63 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let struct (v64 : int32, v65 : obj) = v0 ()
    let v66 : string = v64.ToString ()
    let v67 : JSX.Element = Html.fragment [ v66 |> unbox<JSX.Element> ]
    let v68 : (unit -> (JSX.Element [])) = closure240(v0)
    let v69 : US7 = US7_1(v68)
    let v70 : string = "3px"
    let v71 : US3 = US3_1(v70)
    let v72 : US10 = US10_1(v67)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v69, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v71, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v72, v58, v59, v60, v61, v62, v63)
and closure238 () (v0 : (unit -> struct (int32 * obj))) : (JSX.Element []) =
    let v1 : (Mut4 -> JSX.Element) = closure13()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let v3 : US13 = US13_0
    let v4 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure239(v0)
    let v5 : US14 = US14_2
    let v6 : Mut4 = {l0 = v3; l1 = v4; l2 = v5} : Mut4
    let v7 : obj = v6
    let v8 : string = "createComponent"
    let v9 : string = "solid-js"
    let v10 : JS.Function = import v8 v9
    let v11 : JSX.Element = v10.Invoke (v2, v7) |> unbox<JSX.Element>
    [|v11|]
and closure237 (v0 : Mut1) () : (JSX.Element []) =
    let struct (v1 : (struct (int32 * obj) []), v2 : (struct (int32 * obj) []), v3 : (struct (int32 * int32) [])) = v0.l6, v0.l7, v0.l8
    let v4 : int32 = v1.Length
    let v5 : UH2 = UH2_1
    let v6 : Mut17 = {l0 = 0; l1 = v5} : Mut17
    while method42(v4, v6) do
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
    let v19 : UH2 = method43(v17, v18)
    let v20 : (struct (int32 * obj) []) = method44(v19)
    let v21 : string = "Index"
    let v22 : string = "solid-js"
    let v23 : JS.Function = import v21 v22
    let v24 : ((unit -> struct (int32 * obj)) -> (JSX.Element [])) = closure238()
    let v25 : (unit -> (JSX.Element [])) = v24 |> unbox
    let struct (v26 : US3, v27 : US3, v28 : US5, v29 : US3, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US6, v36 : US7, v37 : US3, v38 : US3, v39 : US6, v40 : US8, v41 : US3, v42 : US3, v43 : US3, v44 : US9, v45 : US6, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US10, v52 : US3, v53 : US3, v54 : US3, v55 : US10, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US11, v65 : US12, v66 : US11, v67 : US3, v68 : US3, v69 : US3, v70 : US3, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US3, v77 : US3, v78 : US3, v79 : US3, v80 : US3, v81 : US3, v82 : US10, v83 : US3, v84 : US3, v85 : US8, v86 : US3, v87 : US2, v88 : US3) = method5()
    let v89 : (obj []) = v20 |> unbox<obj[]>
    let v90 : US7 = US7_1(v25)
    let v91 : US9 = US9_1(v89)
    let v92 : ((string * obj) []) = method7(v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v90, v37, v38, v39, v40, v41, v42, v43, v91, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88)
    let v93 : obj = createObj v92
    let v94 : (obj -> JSX.Element) = v23 |> unbox<obj -> JSX.Element>
    let v95 : string = "createComponent"
    let v96 : JS.Function = import v95 v22
    let v97 : JSX.Element = v96.Invoke (v94, v93) |> unbox<JSX.Element>
    [|v97|]
and closure236 (v0 : Mut1) () : (JSX.Element []) =
    let v1 : (Mut2 -> JSX.Element) = closure9()
    let v2 : (obj -> JSX.Element) = v1 |> unbox<obj -> JSX.Element>
    let struct (v3 : US3, v4 : US3, v5 : US5, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US6, v13 : US7, v14 : US3, v15 : US3, v16 : US6, v17 : US8, v18 : US3, v19 : US3, v20 : US3, v21 : US9, v22 : US6, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US10, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US11, v42 : US12, v43 : US11, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US10, v60 : US3, v61 : US3, v62 : US8, v63 : US3, v64 : US2, v65 : US3) = method5()
    let v66 : (unit -> (JSX.Element [])) = closure237(v0)
    let v67 : US7 = US7_1(v66)
    let v68 : Mut2 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v67; l11 = v14; l12 = v15; l13 = v16; l14 = v17; l15 = v18; l16 = v19; l17 = v20; l18 = v21; l19 = v22; l20 = v23; l21 = v24; l22 = v25; l23 = v26; l24 = v27; l25 = v28; l26 = v29; l27 = v30; l28 = v31; l29 = v32; l30 = v33; l31 = v34; l32 = v35; l33 = v36; l34 = v37; l35 = v38; l36 = v39; l37 = v40; l38 = v41; l39 = v42; l40 = v43; l41 = v44; l42 = v45; l43 = v46; l44 = v47; l45 = v48; l46 = v49; l47 = v50; l48 = v51; l49 = v52; l50 = v53; l51 = v54; l52 = v55; l53 = v56; l54 = v57; l55 = v58; l56 = v59; l57 = v60; l58 = v61; l59 = v62; l60 = v63; l61 = v64; l62 = v65} : Mut2
    emitJsExpr (v68, v66) "$0.children = $1"
    let v69 : obj = v68
    let v70 : string = "createComponent"
    let v71 : string = "solid-js"
    let v72 : JS.Function = import v70 v71
    let v73 : JSX.Element = v72.Invoke (v2, v69) |> unbox<JSX.Element>
    [|v73|]
and closure227 (v0 : Mut1) struct (v1 : US3, v2 : US3, v3 : US5, v4 : US3, v5 : US3, v6 : US3, v7 : US3, v8 : US3, v9 : US3, v10 : US6, v11 : US7, v12 : US3, v13 : US3, v14 : US6, v15 : US8, v16 : US3, v17 : US3, v18 : US3, v19 : US9, v20 : US6, v21 : US3, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US10, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US11, v40 : US12, v41 : US11, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US10, v58 : US3, v59 : US3, v60 : US8, v61 : US3, v62 : US2, v63 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v64 : string = "Stack"
    let v65 : string = "@hope-ui/solid"
    let v66 : JS.Function = import v64 v65
    let struct (v67 : US3, v68 : US3, v69 : US5, v70 : US3, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US3, v76 : US6, v77 : US7, v78 : US3, v79 : US3, v80 : US6, v81 : US8, v82 : US3, v83 : US3, v84 : US3, v85 : US9, v86 : US6, v87 : US3, v88 : US3, v89 : US3, v90 : US3, v91 : US3, v92 : US10, v93 : US3, v94 : US3, v95 : US3, v96 : US10, v97 : US3, v98 : US3, v99 : US3, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US11, v106 : US12, v107 : US11, v108 : US3, v109 : US3, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US3, v119 : US3, v120 : US3, v121 : US3, v122 : US3, v123 : US10, v124 : US3, v125 : US3, v126 : US8, v127 : US3, v128 : US2, v129 : US3) = method5()
    let v130 : string = "row"
    let v131 : string = "column"
    let v132 : string = method13(v131, v130)
    let v133 : string = "0"
    let v134 : string = "8px"
    let v135 : string = method13(v134, v133)
    let v136 : string = "start"
    let v137 : US3 = US3_1(v136)
    let v138 : (unit -> (JSX.Element [])) = closure228()
    let v139 : US7 = US7_1(v138)
    let v140 : US3 = US3_1(v132)
    let v141 : US3 = US3_1(v135)
    let v142 : string = "3px"
    let v143 : US3 = US3_1(v142)
    let v144 : string = "7px"
    let v145 : US3 = US3_1(v144)
    let v146 : ((string * obj) []) = method7(v137, v68, v69, v70, v71, v72, v73, v74, v75, v76, v139, v78, v79, v80, v81, v82, v140, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v141, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v143, v112, v113, v114, v115, v116, v117, v118, v145, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129)
    let v147 : obj = createObj v146
    let v148 : (obj -> JSX.Element) = v66 |> unbox<obj -> JSX.Element>
    let v149 : string = "createComponent"
    let v150 : string = "solid-js"
    let v151 : JS.Function = import v149 v150
    let v152 : JSX.Element = v151.Invoke (v148, v147) |> unbox<JSX.Element>
    let v153 : (unit -> (JSX.Element [])) = closure236(v0)
    let v154 : US7 = US7_1(v153)
    let v155 : string = "deploy"
    let v156 : US3 = US3_1(v155)
    let v157 : US10 = US10_1(v152)
    struct (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v154, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v156, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v157, v58, v59, v60, v61, v62, v63)
and method47 () : JSX.Element =
    let v0 : string = "useStoreon"
    let v1 : string = "@storeon/solidjs"
    let v2 : JS.Function = import v0 v1
    let v3 : (JS.Function []) = v2.Invoke () |> unbox<JS.Function[]>
    let v4 : Mut1 = v3.[0] |> unbox
    let v5 : JS.Function = v3.[1] |> unbox
    let struct (v6 : (struct (int32 * obj) []), v7 : (struct (int32 * obj) []), v8 : (struct (int32 * int32) [])) = v4.l6, v4.l7, v4.l8
    let v9 : (Mut4 -> JSX.Element) = closure13()
    let v10 : (obj -> JSX.Element) = v9 |> unbox<obj -> JSX.Element>
    let v11 : US13 = US13_0
    let v12 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure227(v4)
    let v13 : US14 = US14_2
    let v14 : Mut4 = {l0 = v11; l1 = v12; l2 = v13} : Mut4
    let v15 : obj = v14
    let v16 : string = "createComponent"
    let v17 : string = "solid-js"
    let v18 : JS.Function = import v16 v17
    let v19 : JSX.Element = v18.Invoke (v10, v15) |> unbox<JSX.Element>
    v19
and closure226 () (v0 : Mut2) : JSX.Element =
    method47()
and closure242 () () : (JSX.Element []) =
    [||]
and closure189 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut2 -> JSX.Element) = closure190()
    let v6 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let struct (v7 : US3, v8 : US3, v9 : US5, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US6, v17 : US7, v18 : US3, v19 : US3, v20 : US6, v21 : US8, v22 : US3, v23 : US3, v24 : US3, v25 : US9, v26 : US6, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US10, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US11, v46 : US12, v47 : US11, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US10, v64 : US3, v65 : US3, v66 : US8, v67 : US3, v68 : US2, v69 : US3) = method5()
    let v70 : (unit -> (JSX.Element [])) = closure208()
    let v71 : US7 = US7_1(v70)
    let v72 : Mut2 = {l0 = v7; l1 = v8; l2 = v9; l3 = v10; l4 = v11; l5 = v12; l6 = v13; l7 = v14; l8 = v15; l9 = v16; l10 = v71; l11 = v18; l12 = v19; l13 = v20; l14 = v21; l15 = v22; l16 = v23; l17 = v24; l18 = v25; l19 = v26; l20 = v27; l21 = v28; l22 = v29; l23 = v30; l24 = v31; l25 = v32; l26 = v33; l27 = v34; l28 = v35; l29 = v36; l30 = v37; l31 = v38; l32 = v39; l33 = v40; l34 = v41; l35 = v42; l36 = v43; l37 = v44; l38 = v45; l39 = v46; l40 = v47; l41 = v48; l42 = v49; l43 = v50; l44 = v51; l45 = v52; l46 = v53; l47 = v54; l48 = v55; l49 = v56; l50 = v57; l51 = v58; l52 = v59; l53 = v60; l54 = v61; l55 = v62; l56 = v63; l57 = v64; l58 = v65; l59 = v66; l60 = v67; l61 = v68; l62 = v69} : Mut2
    emitJsExpr (v72, v70) "$0.children = $1"
    let v73 : obj = v72
    let v74 : string = "createComponent"
    let v75 : string = "solid-js"
    let v76 : JS.Function = import v74 v75
    let v77 : JSX.Element = v76.Invoke (v6, v73) |> unbox<JSX.Element>
    let v78 : (Mut2 -> JSX.Element) = closure209()
    let v79 : (obj -> JSX.Element) = v78 |> unbox<obj -> JSX.Element>
    let struct (v80 : US3, v81 : US3, v82 : US5, v83 : US3, v84 : US3, v85 : US3, v86 : US3, v87 : US3, v88 : US3, v89 : US6, v90 : US7, v91 : US3, v92 : US3, v93 : US6, v94 : US8, v95 : US3, v96 : US3, v97 : US3, v98 : US9, v99 : US6, v100 : US3, v101 : US3, v102 : US3, v103 : US3, v104 : US3, v105 : US10, v106 : US3, v107 : US3, v108 : US3, v109 : US10, v110 : US3, v111 : US3, v112 : US3, v113 : US3, v114 : US3, v115 : US3, v116 : US3, v117 : US3, v118 : US11, v119 : US12, v120 : US11, v121 : US3, v122 : US3, v123 : US3, v124 : US3, v125 : US3, v126 : US3, v127 : US3, v128 : US3, v129 : US3, v130 : US3, v131 : US3, v132 : US3, v133 : US3, v134 : US3, v135 : US3, v136 : US10, v137 : US3, v138 : US3, v139 : US8, v140 : US3, v141 : US2, v142 : US3) = method5()
    let v143 : (unit -> (JSX.Element [])) = closure225()
    let v144 : US7 = US7_1(v143)
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
    let v154 : (Mut2 -> JSX.Element) = closure226()
    let v155 : (obj -> JSX.Element) = v154 |> unbox<obj -> JSX.Element>
    let struct (v156 : US3, v157 : US3, v158 : US5, v159 : US3, v160 : US3, v161 : US3, v162 : US3, v163 : US3, v164 : US3, v165 : US6, v166 : US7, v167 : US3, v168 : US3, v169 : US6, v170 : US8, v171 : US3, v172 : US3, v173 : US3, v174 : US9, v175 : US6, v176 : US3, v177 : US3, v178 : US3, v179 : US3, v180 : US3, v181 : US10, v182 : US3, v183 : US3, v184 : US3, v185 : US10, v186 : US3, v187 : US3, v188 : US3, v189 : US3, v190 : US3, v191 : US3, v192 : US3, v193 : US3, v194 : US11, v195 : US12, v196 : US11, v197 : US3, v198 : US3, v199 : US3, v200 : US3, v201 : US3, v202 : US3, v203 : US3, v204 : US3, v205 : US3, v206 : US3, v207 : US3, v208 : US3, v209 : US3, v210 : US3, v211 : US3, v212 : US10, v213 : US3, v214 : US3, v215 : US8, v216 : US3, v217 : US2, v218 : US3) = method5()
    let v219 : (unit -> (JSX.Element [])) = closure242()
    let v220 : US7 = US7_1(v219)
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
and closure188 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut2 -> JSX.Element) = closure9()
    let v6 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let struct (v7 : US3, v8 : US3, v9 : US5, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US3, v15 : US3, v16 : US6, v17 : US7, v18 : US3, v19 : US3, v20 : US6, v21 : US8, v22 : US3, v23 : US3, v24 : US3, v25 : US9, v26 : US6, v27 : US3, v28 : US3, v29 : US3, v30 : US3, v31 : US3, v32 : US10, v33 : US3, v34 : US3, v35 : US3, v36 : US10, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US11, v46 : US12, v47 : US11, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US10, v64 : US3, v65 : US3, v66 : US8, v67 : US3, v68 : US2, v69 : US3) = method5()
    let v70 : (unit -> (JSX.Element [])) = closure189(v0, v1, v2, v3, v4)
    let v71 : US7 = US7_1(v70)
    let v72 : Mut2 = {l0 = v7; l1 = v8; l2 = v9; l3 = v10; l4 = v11; l5 = v12; l6 = v13; l7 = v14; l8 = v15; l9 = v16; l10 = v71; l11 = v18; l12 = v19; l13 = v20; l14 = v21; l15 = v22; l16 = v23; l17 = v24; l18 = v25; l19 = v26; l20 = v27; l21 = v28; l22 = v29; l23 = v30; l24 = v31; l25 = v32; l26 = v33; l27 = v34; l28 = v35; l29 = v36; l30 = v37; l31 = v38; l32 = v39; l33 = v40; l34 = v41; l35 = v42; l36 = v43; l37 = v44; l38 = v45; l39 = v46; l40 = v47; l41 = v48; l42 = v49; l43 = v50; l44 = v51; l45 = v52; l46 = v53; l47 = v54; l48 = v55; l49 = v56; l50 = v57; l51 = v58; l52 = v59; l53 = v60; l54 = v61; l55 = v62; l56 = v63; l57 = v64; l58 = v65; l59 = v66; l60 = v67; l61 = v68; l62 = v69} : Mut2
    emitJsExpr (v72, v70) "$0.children = $1"
    let v73 : obj = v72
    let v74 : string = "createComponent"
    let v75 : string = "solid-js"
    let v76 : JS.Function = import v74 v75
    let v77 : JSX.Element = v76.Invoke (v6, v73) |> unbox<JSX.Element>
    [|v77|]
and closure187 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) struct (v5 : US3, v6 : US3, v7 : US5, v8 : US3, v9 : US3, v10 : US3, v11 : US3, v12 : US3, v13 : US3, v14 : US6, v15 : US7, v16 : US3, v17 : US3, v18 : US6, v19 : US8, v20 : US3, v21 : US3, v22 : US3, v23 : US9, v24 : US6, v25 : US3, v26 : US3, v27 : US3, v28 : US3, v29 : US3, v30 : US10, v31 : US3, v32 : US3, v33 : US3, v34 : US10, v35 : US3, v36 : US3, v37 : US3, v38 : US3, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US11, v44 : US12, v45 : US11, v46 : US3, v47 : US3, v48 : US3, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US10, v62 : US3, v63 : US3, v64 : US8, v65 : US3, v66 : US2, v67 : US3) : struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) =
    let v68 : string = "Profile"
    let v69 : JSX.Element = Html.fragment [ v68 |> unbox<JSX.Element> ]
    let v70 : (unit -> (JSX.Element [])) = closure188(v0, v1, v2, v3, v4)
    let v71 : US7 = US7_1(v70)
    let v72 : US10 = US10_1(v69)
    struct (v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v71, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v72, v62, v63, v64, v65, v66, v67)
and closure12 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut4 -> JSX.Element) = closure13()
    let v6 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v7 : US13 = US13_0
    let v8 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure48()
    let v9 : US14 = US14_2
    let v10 : Mut4 = {l0 = v7; l1 = v8; l2 = v9} : Mut4
    let v11 : obj = v10
    let v12 : string = "createComponent"
    let v13 : string = "solid-js"
    let v14 : JS.Function = import v12 v13
    let v15 : JSX.Element = v14.Invoke (v6, v11) |> unbox<JSX.Element>
    let v16 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v17 : US13 = US13_0
    let v18 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure36()
    let v19 : US14 = US14_2
    let v20 : Mut4 = {l0 = v17; l1 = v18; l2 = v19} : Mut4
    let v21 : obj = v20
    let v22 : JS.Function = import v12 v13
    let v23 : JSX.Element = v22.Invoke (v16, v21) |> unbox<JSX.Element>
    let v24 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v25 : US13 = US13_0
    let v26 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure67()
    let v27 : US14 = US14_2
    let v28 : Mut4 = {l0 = v25; l1 = v26; l2 = v27} : Mut4
    let v29 : obj = v28
    let v30 : JS.Function = import v12 v13
    let v31 : JSX.Element = v30.Invoke (v24, v29) |> unbox<JSX.Element>
    let v32 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v33 : US13 = US13_0
    let v34 : US14 = US14_2
    let v35 : Mut4 = {l0 = v33; l1 = v18; l2 = v34} : Mut4
    let v36 : obj = v35
    let v37 : JS.Function = import v12 v13
    let v38 : JSX.Element = v37.Invoke (v32, v36) |> unbox<JSX.Element>
    let v39 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v40 : US13 = US13_0
    let v41 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure79()
    let v42 : US14 = US14_0
    let v43 : Mut4 = {l0 = v40; l1 = v41; l2 = v42} : Mut4
    let v44 : obj = v43
    let v45 : JS.Function = import v12 v13
    let v46 : JSX.Element = v45.Invoke (v39, v44) |> unbox<JSX.Element>
    let v47 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v48 : US13 = US13_0
    let v49 : US14 = US14_2
    let v50 : Mut4 = {l0 = v48; l1 = v18; l2 = v49} : Mut4
    let v51 : obj = v50
    let v52 : JS.Function = import v12 v13
    let v53 : JSX.Element = v52.Invoke (v47, v51) |> unbox<JSX.Element>
    let v54 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v55 : US13 = US13_0
    let v56 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure136()
    let v57 : US14 = US14_0
    let v58 : Mut4 = {l0 = v55; l1 = v56; l2 = v57} : Mut4
    let v59 : obj = v58
    let v60 : JS.Function = import v12 v13
    let v61 : JSX.Element = v60.Invoke (v54, v59) |> unbox<JSX.Element>
    let v62 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v63 : US13 = US13_0
    let v64 : US14 = US14_2
    let v65 : Mut4 = {l0 = v63; l1 = v18; l2 = v64} : Mut4
    let v66 : obj = v65
    let v67 : JS.Function = import v12 v13
    let v68 : JSX.Element = v67.Invoke (v62, v66) |> unbox<JSX.Element>
    let v69 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v70 : US13 = US13_0
    let v71 : (struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3) -> struct (US3 * US3 * US5 * US3 * US3 * US3 * US3 * US3 * US3 * US6 * US7 * US3 * US3 * US6 * US8 * US3 * US3 * US3 * US9 * US6 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US10 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US11 * US12 * US11 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US3 * US10 * US3 * US3 * US8 * US3 * US2 * US3)) = closure187(v0, v1, v2, v3, v4)
    let v72 : US14 = US14_2
    let v73 : Mut4 = {l0 = v70; l1 = v71; l2 = v72} : Mut4
    let v74 : obj = v73
    let v75 : JS.Function = import v12 v13
    let v76 : JSX.Element = v75.Invoke (v69, v74) |> unbox<JSX.Element>
    [|v15; v23; v31; v38; v46; v53; v61; v68; v76|]
and closure5 (v0 : string, v1 : obj, v2 : string, v3 : string, v4 : bool) () : (JSX.Element []) =
    let v5 : (Mut3 -> JSX.Element) = closure6()
    let v6 : (obj -> JSX.Element) = v5 |> unbox<obj -> JSX.Element>
    let v7 : Mut3 = Mut3()
    let v8 : obj = v7
    let v9 : string = "createComponent"
    let v10 : string = "solid-js"
    let v11 : JS.Function = import v9 v10
    let v12 : JSX.Element = v11.Invoke (v6, v8) |> unbox<JSX.Element>
    let v14 : bool = v2 = ""
    let v16 : JSX.Element =
        if v14 then
            v12
        else
            let v15 : JSX.Element = Html.fragment []
            v15
    let v17 : (Mut2 -> JSX.Element) = closure9()
    let v18 : (obj -> JSX.Element) = v17 |> unbox<obj -> JSX.Element>
    let struct (v19 : US3, v20 : US3, v21 : US5, v22 : US3, v23 : US3, v24 : US3, v25 : US3, v26 : US3, v27 : US3, v28 : US6, v29 : US7, v30 : US3, v31 : US3, v32 : US6, v33 : US8, v34 : US3, v35 : US3, v36 : US3, v37 : US9, v38 : US6, v39 : US3, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US10, v45 : US3, v46 : US3, v47 : US3, v48 : US10, v49 : US3, v50 : US3, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US11, v58 : US12, v59 : US11, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US3, v67 : US3, v68 : US3, v69 : US3, v70 : US3, v71 : US3, v72 : US3, v73 : US3, v74 : US3, v75 : US10, v76 : US3, v77 : US3, v78 : US8, v79 : US3, v80 : US2, v81 : US3) = method5()
    let v82 : (unit -> (JSX.Element [])) = closure12(v0, v1, v2, v3, v4)
    let v83 : US7 = US7_1(v82)
    let v84 : string = "flex"
    let v85 : US3 = US3_1(v84)
    let v86 : string = "1"
    let v87 : US3 = US3_1(v86)
    let v88 : string = "column"
    let v89 : US3 = US3_1(v88)
    let v90 : string = "hidden"
    let v91 : US3 = US3_1(v90)
    let v92 : string = "auto"
    let v93 : US3 = US3_1(v92)
    let v94 : Mut2 = {l0 = v19; l1 = v20; l2 = v21; l3 = v22; l4 = v23; l5 = v24; l6 = v25; l7 = v26; l8 = v27; l9 = v28; l10 = v83; l11 = v30; l12 = v31; l13 = v32; l14 = v33; l15 = v34; l16 = v35; l17 = v85; l18 = v37; l19 = v38; l20 = v87; l21 = v89; l22 = v41; l23 = v42; l24 = v43; l25 = v44; l26 = v45; l27 = v46; l28 = v47; l29 = v48; l30 = v49; l31 = v50; l32 = v51; l33 = v52; l34 = v53; l35 = v54; l36 = v55; l37 = v56; l38 = v57; l39 = v58; l40 = v59; l41 = v60; l42 = v91; l43 = v93; l44 = v63; l45 = v64; l46 = v65; l47 = v66; l48 = v67; l49 = v68; l50 = v69; l51 = v70; l52 = v71; l53 = v72; l54 = v73; l55 = v74; l56 = v75; l57 = v76; l58 = v77; l59 = v78; l60 = v79; l61 = v80; l62 = v81} : Mut2
    emitJsExpr (v94, v82) "$0.children = $1"
    let v95 : obj = v94
    let v96 : JS.Function = import v9 v10
    let v97 : JSX.Element = v96.Invoke (v18, v95) |> unbox<JSX.Element>
    [|v16; v97|]
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
    let struct (v10 : US3, v11 : US3, v12 : US5, v13 : US3, v14 : US3, v15 : US3, v16 : US3, v17 : US3, v18 : US3, v19 : US6, v20 : US7, v21 : US3, v22 : US3, v23 : US6, v24 : US8, v25 : US3, v26 : US3, v27 : US3, v28 : US9, v29 : US6, v30 : US3, v31 : US3, v32 : US3, v33 : US3, v34 : US3, v35 : US10, v36 : US3, v37 : US3, v38 : US3, v39 : US10, v40 : US3, v41 : US3, v42 : US3, v43 : US3, v44 : US3, v45 : US3, v46 : US3, v47 : US3, v48 : US11, v49 : US12, v50 : US11, v51 : US3, v52 : US3, v53 : US3, v54 : US3, v55 : US3, v56 : US3, v57 : US3, v58 : US3, v59 : US3, v60 : US3, v61 : US3, v62 : US3, v63 : US3, v64 : US3, v65 : US3, v66 : US10, v67 : US3, v68 : US3, v69 : US8, v70 : US3, v71 : US2, v72 : US3) = method5()
    let v73 : string = "$bg"
    let v74 : US3 = US3_1(v73)
    let v75 : (unit -> (JSX.Element [])) = closure5(v1, v0, v2, v3, v6)
    let v76 : US7 = US7_1(v75)
    let v77 : string = "$text1"
    let v78 : US3 = US3_1(v77)
    let v79 : string = "flex"
    let v80 : US3 = US3_1(v79)
    let v81 : string = "1"
    let v82 : US3 = US3_1(v81)
    let v83 : string = "column"
    let v84 : US3 = US3_1(v83)
    let v85 : string = "$sm"
    let v86 : US3 = US3_1(v85)
    let v87 : string = "100vh"
    let v88 : US3 = US3_1(v87)
    let v89 : string = "100vw"
    let v90 : US3 = US3_1(v89)
    let v91 : string = "1px"
    let v92 : US3 = US3_1(v91)
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
let struct (v77 : (struct (US0 * string * string * string) []), v78 : US2, v79 : US3, v80 : US3, v81 : (struct (US4 * int32 * string * string) []), v82 : (struct (US4 * US4) []), v83 : (struct (int32 * obj) []), v84 : (struct (int32 * obj) []), v85 : (struct (int32 * int32) []), v86 : US2) = method0(v71, v70, v72, v73, v76)
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
